# JSON Deserialization Hook Design

How VRChat's Newtonsoft.Json deserialization works internally, exactly which
method to hook to observe `(property_name, target_object_class)` pairs, and the
runtime read strategy at each hook. Every address below is sourced from
`output/p2_research/steam_symbols.json` (file-VA, `0x180...` base) and the DTO
methods from `output/p2_research/merged_pseudocode.json`.

## Why JSON keys are the strongest leak

Beebyte stripped the compile-time class names; the on-disk metadata stores the
same `ÌÍÎÏ` garbage, so structural reversing only recovers a class's *role*. But
a DTO deserialised from JSON still receives its real field names as wire keys:
`avatarId`, `performanceRating`, ... Those keys ARE the obfuscated class's own
member names. Capture which keys flow into which obfuscated object and you have a
near-symbol-grade fingerprint. This doc locates where in the binary that mapping
is observable.

Confirmed: VRChat uses Newtonsoft.Json. The symbol table contains the full
`JsonSerializerInternalReader` / `JsonConvert` / `JsonProperty` surface, and the
`is_dto` targets carry callee hints `JsonObjectAttribute`, `JsonProperty`,
`JsonConverter`, `JsonReader`.

## How Newtonsoft populates an object (internal flow)

For a non-converter object type, `JsonConvert.DeserializeObject` funnels down to
the internal reader. The relevant call chain (all in
`JsonSerializerInternalReader`):

```
JsonConvert::DeserializeObject            0x1831135c0   public entry, has the root Type
  -> JsonSerializer::Deserialize          0x1869dc4b0   serializer-level entry
    -> JsonSerializerInternalReader::Deserialize        0x186a6c4f0   root dispatch
      -> CreateObject                     0x186a6db30   pick path: $type / converter / plain
        -> CreateNewObject                0x186a78bb0   instantiate target, then loop props
          -> PopulateObject               0x186a78ea0   FOR EACH json property of the object:
               CalculatePropertyDetails   0x186a71930     resolve reader token -> JsonProperty
               SetPropertyValue           0x186a71520     <-- write value into target object
               SetPropertyPresence        0x186a7a8e0     mark property as seen
```

The single point that sees **both** the property identity and the object being
filled, once per key, is `SetPropertyValue`. That is the prime hook.

Two complications, both handled below:

1. **Two shipped copies.** The binary ships the Newtonsoft assembly twice: one
   in the `0x186...` range, one in `0x188...`. Every core method resolves to two
   addresses (e.g. `SetPropertyValue` = `0x186a71520` and `0x18818f6d0`). Hook
   both, or determine at runtime which copy VRChat's call sites bind to and hook
   that one. The tool tags each address with `range: asm_copy_A(0x186)` /
   `asm_copy_B(0x188)`.

2. **Constructor-populated DTOs.** Immutable / record-style DTOs are built via
   `CreateObjectUsingCreatorWithParameters` (`0x186a762c0`); their values go
   straight into a constructor and `SetPropertyValue` never fires. For those the
   keys are gathered in `ResolvePropertyAndCreatorValues` (`0x186a77fd0`) — hook
   it too to avoid missing record-type DTOs.

3. **Custom converters.** A class with its own `JsonConverter` reads the JSON
   itself in `ReadJson`; the library core never iterates its keys. Those are
   covered by the per-target list, not the core hook (see `Static23m_A445`).

## The prime hook: `SetPropertyValue`

`JsonSerializerInternalReader::SetPropertyValue`
- copy A: `0x186a71520`
- copy B: `0x18818f6d0`

Managed signature (Newtonsoft, stable across 11.x–13.x):

```csharp
private bool SetPropertyValue(
    JsonProperty property,            // arg: the property -> real field name
    JsonConverter propertyConverter,
    JsonContainerContract containerContract,
    JsonProperty containerProperty,
    JsonReader reader,                // arg: current value
    object target)                    // arg: the object being filled  <-- class id
```

In the IL2CPP ABI the implicit `this` is arg0 and managed args shift right by
one. At the hook read:

- **property name (the JSON key):** the `JsonProperty` arg, then call
  `JsonProperty::get_UnderlyingName` (`0x180be2c60`) for the pre-rename member
  name (best), or read the `PropertyName` field set by
  `JsonProperty::set_PropertyName` (`0x186a6a400`) for the on-the-wire key.
- **target object's class:** take the `target` arg pointer; its first qword is
  the `Il2CppClass*`. Resolve the class name via the normal IL2CPP runtime
  (`il2cpp_class_get_name` / the project's existing class-name resolver). For
  the obfuscated DTOs this yields the `BaseClass*Impl_*` token, which is exactly
  the key the naming pipeline joins on.

Recording `(target_class_token, underlying_name)` for every call rebuilds each
obfuscated class's full key set. One hook covers all 65 `is_dto` classes and
every not-yet-flagged class that deserialises from JSON.

### Bracketing keys to one object

`SetPropertyValue` fires per property with no explicit object boundary. To group
keys per instance without relying on argument identity alone, optionally also
hook `PopulateObject` (`0x186a78ea0`) on entry/exit: it holds the same `target`
for the whole property loop, so its entry marks "new object, class = X, start
collecting" and its return marks "flush key set." `CreateNewObject`
(`0x186a78bb0`) and `CreateObject` (`0x186a6db30`) additionally expose the
`JsonObjectContract` whose `CreatedType` (set via
`JsonContract::set_CreatedType`, `0x186a65170`) is the class about to be filled —
a second, independent way to read the target class before any key arrives.

## Support accessors (what the hook calls to decode args)

| symbol | ea | use |
|---|---|---|
| `JsonProperty::get_UnderlyingName` | `0x180be2c60` | JsonProperty -> real field name (the key) |
| `JsonProperty::set_PropertyName`   | `0x186a6a400` | on-the-wire key fallback |
| `JsonContract::set_CreatedType`    | `0x186a65170` | contract -> obf class being built |
| `JsonReader::get_ValueType`        | `0x1869d35e0` | record the value's CLR type alongside the key |

These let the hook turn a raw `JsonProperty*` / `target*` into
`(name, class)` strings without re-implementing Newtonsoft.

## Per-target DTO hooks (custom-converter fallback)

The `is_dto` set dedups to 5 unique classes (the 65 rows repeat each class once
per live VA). For each, `find_json_hooks.py` ranks the class's own pseudocode
methods by deserialisation signal (custom `ReadJson` = 4.0, declares
`JsonConverter` = 3.0, property setter = 2.0, `JsonProperty`/`JsonContract`
member = 1.5, body references Newtonsoft types = 1.0). Results:

- **`Static23m_A445`** — strongest, score 8.0. Owns
  `JsonConverter::ReadJson` @ `0x18088d2c0` (pseudocode confirms the signature
  `JsonConverter__ReadJson(reader, objectType, existingValue, serializer)`).
  This is a **custom converter**: it reads keys itself, so the library
  `SetPropertyValue` hook will NOT see them. Hook `0x18088d2c0` directly and
  read its `JsonReader` arg as it walks the object. callee_hint `JsonConverter`
  corroborates.
- **`BackingFieldBase_k__BackingField_55CF`** — 6 candidates, best
  `JsonProperty::set_UnderlyingName` @ `0x180be2c70` (score 4.5). This class is a
  thin wrapper over Newtonsoft `JsonProperty` accessors (the resolved symbols are
  literally `JsonProperty::get_/set_UnderlyingName`, `get_ValueProvider`,
  `JsonObjectAttribute::get_MemberSerialization`). It is metadata plumbing, not a
  payload DTO — useful as a sanity anchor but unlikely to carry domain keys.
- **`BackingFieldBase_k__Impl_F1E6`** — 3 candidates, but the top
  (`SslConfiguration::set_EnabledSslProtocols`, score 2.0) is only a generic
  setter match; its one genuinely relevant method is
  `JsonReader::get_CurrentState` @ `0x1815af000`. Treat as low-confidence; the
  resolved symbols suggest the three pseudocode EAs are shared/thunked across
  unrelated classes. Verify at runtime before trusting.
- **`BaseClass290ImplImpl_828C`** and **`BaseClass45Impl_7C14`** — 0 candidates.
  290's hint is `XElement`/`SafeSerializationManager` (XML path, not JSON);
  45's pseudocode methods resolve to no symbol and show no Json tokens. These
  are reached only through the **core `SetPropertyValue` hook**, which is exactly
  why the library-level hook is the primary strategy.

## Runtime hook strategy (summary)

1. **Primary:** hook `JsonSerializerInternalReader::SetPropertyValue` (both
   copies `0x186a71520` / `0x18818f6d0`). At each call read the `JsonProperty`
   arg -> `get_UnderlyingName`, and the `target` arg -> `*target` = `Il2CppClass*`
   -> class name. Emit `(class, key)`.
2. **Record-type coverage:** also hook
   `ResolvePropertyAndCreatorValues` (`0x186a77fd0`) /
   `CreateObjectUsingCreatorWithParameters` (`0x186a762c0`) for constructor-
   populated DTOs.
3. **Object bracketing (optional):** hook `PopulateObject` (`0x186a78ea0`) entry
   /return to group a class's keys into one schema per instance.
4. **Custom converters:** hook the per-target `ReadJson` methods directly — for
   now that is `Static23m_A445` @ `0x18088d2c0`. The library core cannot see
   these keys.
5. **Decode helpers:** resolve names/classes with the support accessors above.

All addresses are file-VA (`0x180...`). Convert to runtime VA with the project's
build-matched rebase (`runtime_va = file_va + (module_base - 0x180000000)`,
SHARED_CONTEXT Track D) before installing hooks. The two-copy ambiguity should be
resolved empirically: log which copy actually fires from VRChat call sites and
keep that one.

## Caveats / not verified

- Static only. No hook was installed; argument positions follow the documented
  Newtonsoft signatures + IL2CPP `this`-shift convention and must be confirmed
  against the live decompiled prologue of `SetPropertyValue` before trusting arg
  offsets.
- The Newtonsoft library methods are **not** in `merged_pseudocode.json` (only
  VRChat-owned classes were decompiled); their addresses come purely from the
  symbol table, which is reliable for naming but was not re-validated here.
- Per-target scoring is heuristic; `BackingFieldBase_k__Impl_F1E6`'s top match is
  a generic-setter false positive and is flagged as low confidence.
