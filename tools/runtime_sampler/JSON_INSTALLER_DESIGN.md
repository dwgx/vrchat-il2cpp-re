# JSON Key Capture - Runtime Installer Design

How `json_hook_installer.js` + `collect_json_keys.py` turn VRChat's live
Newtonsoft deserialisation into a stream of `(obfuscated class -> real field
name)` pairs, and why every read is anti-tamper-safe. Companion to
`JSON_HOOK_DESIGN.md` (which located the hook points); this doc is the build.

## What we capture and why it works

Beebyte stripped compile-time class/member names; the on-disk metadata only has
`ÌÍÎÏ` garbage. But a DTO deserialised from JSON still receives its real member
names as wire keys (`avatarId`, `performanceRating`, ...). Newtonsoft resolves
each wire key to a `JsonProperty` whose `UnderlyingName` is the pre-rename C#
member name. Hooking the one method that sees both the `JsonProperty` and the
target object gives `(obf_class_token, real_field_name)` for free, once per key.

That method is `JsonSerializerInternalReader::SetPropertyValue`.

## Rebase math (file-VA -> live runtime address)

The hook addresses in `output/p2_research/json_hook_points.json` are file-VAs on
the `0x180000000` PE image base. Per `map_runtime_to_fileva.py` (spec item 28):

```
file_va = runtime_va - (module_base - 0x180000000)
```

Inverting for install time:

```
runtime_va = module_base + (file_va - 0x180000000)
```

`module_base` is read LIVE from the loaded module, not from any stale dump base:

```js
var gaBase = VRC.gaBase();                 // Process.getModuleByName('GameAssembly.dll').base
runtime = gaBase.add(ptr(fileVa).sub(ptr('0x180000000')));
```

Each resolved address is bounds-checked against `[gaBase, gaBase+module.size)`
before `Interceptor.attach`, so a wrong file-VA fails loud instead of hooking
arbitrary memory.

## Hook points

Newtonsoft is linked into GameAssembly.dll twice (copy A `0x186...`, copy B
`0x188...`), so `SetPropertyValue` exists at two addresses. We attach BOTH and
let whichever the live call sites bind to fire; `try/catch` + a bounds check
guard each attach independently.

| symbol | copy | file-VA |
|---|---|---|
| `JsonSerializerInternalReader::SetPropertyValue` | A | `0x186a71520` |
| `JsonSerializerInternalReader::SetPropertyValue` | B | `0x18818f6d0` |

`PopulateObject` (`0x186a78ea0` / `0x188196940`) brackets keys per object but
isn't needed for the class->key mapping, so it is documented here but not hooked
by default; `SetPropertyValue` already carries the target on every call.

## Anti-tamper-safe read strategy

`B_DESIGN.md` / `EXPORT_FINDING.md` establish that VRChat validates the RETURN
ADDRESS of calls into GameAssembly.dll: a plain `new NativeFunction(handle, ...)`
returns into Gum's trampoline pages (outside GA) and is rejected. That is why the
sampler avoids bridge calls.

`Interceptor.attach` is fundamentally different: it places an inline hook and
hands us the incoming register/stack args in `onEnter`. It makes NO outbound call
into GA, so it cannot trip the return-address check. The only thing we must avoid
is calling a game function to decode the args (e.g. invoking
`JsonProperty::get_UnderlyingName` as a NativeFunction). We don't. We read the
backing fields directly with raw memory reads:

- **target class:** `target` arg is a managed object; its first qword is the
  `Il2CppClass*` (`obj+0x00`). `VRC.klassGetName(klass)` reads the Beebyte name
  pointer at `klass+0x50`. Pure reads.
- **property name:** instead of calling `get_UnderlyingName`, we read the
  `JsonProperty`'s `UnderlyingName` STRING FIELD by offset, then decode it as an
  `Il2CppString` (len `+0x10`, chars `+0x14`). Pure reads.

## Resolving the UnderlyingName field offset at runtime

The `JsonProperty` field offset isn't hardcoded. On the first `JsonProperty` we
see, we enumerate its class fields with `VRC.klassGetFields(klass)` (stride 0x30,
name `+0x08`, offset `+0x04`) and match by name. Newtonsoft field names are NOT
Beebyte-obfuscated (the symbol table keeps `JsonProperty::get_UnderlyingName`
intact), so a substring match is reliable:

- primary: any field whose lowercased name contains `underlyingname`
  (`UnderlyingName`, `_underlyingName`, `<UnderlyingName>k__BackingField`) -
  this is the pre-rename member name, the best signal.
- fallback: `propertyname` (`PropertyName` / `_propertyName`) - the on-the-wire
  key, used if `UnderlyingName` is null/empty.

The resolved offsets are cached per class pointer. Both fields are
`System.String` references: read the pointer at `instance+offset`, then decode.

## Argument layout - assumptions to verify live

`SetPropertyValue` is a managed instance method. Managed signature (stable
Newtonsoft 11.x-13.x):

```csharp
bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter,
    JsonContainerContract containerContract, JsonProperty containerProperty,
    JsonReader reader, object target)
```

IL2CPP x64 lowers this to a free function: arg0 = implicit `this`
(`JsonSerializerInternalReader*`), managed args shift right by one, and a hidden
`MethodInfo*` trails. Expected native frame:

```
args[0] = this                 (JsonSerializerInternalReader*)
args[1] = property             (JsonProperty*)   <- KEY source
args[2] = propertyConverter
args[3] = containerContract
args[4] = containerProperty    (JsonProperty*)
args[5] = reader
args[6] = target               (object*)         <- CLASS source
args[7] = MethodInfo*
```

These indices (1 = property, 6 = target) are the documented expectation and are
tried as a fast path. Because they are NOT verified against the live prologue,
the hook does not trust them blindly: if either fast-path read misses, it SCANS
`args[1..7]`, classifying each managed-object arg as the property (its class
exposes an `UnderlyingName`/`PropertyName` string field) or the target (its
class name resolves and it isn't the property). This tolerates a one-slot shift
or an inlined `this`.

**Open items for live verification:**
1. Confirm the actual arg index of `property` and `target` against the live
   decompiled prologue; the scan masks a wrong index but the fast path assumes
   1/6.
2. Confirm which Newtonsoft copy (A/B) actually fires from VRChat's call sites
   (the `stats`/`info` messages report fires per attach implicitly via total
   counts; add per-tag counting if disambiguation is needed).
3. Confirm `JsonProperty` exposes `UnderlyingName`/`PropertyName` as direct
   string fields in this build (not only as auto-property getters with a
   differently named backing field) - the substring match covers
   `<UnderlyingName>k__BackingField` too, but verify a real capture yields
   non-empty keys.
4. Confirm `klassGetName`'s `+0x50` name offset is correct for THIS build (the
   lib header notes it as a Jun-5 layout; the project's later memory notes
   discuss layout drift across builds). If class names come back null/garbage,
   the name offset must be re-pinned before trusting the class side.

## Output

`collect_json_keys.py` aggregates `{type:'json_keys', obf_class, key}` messages
into `output/p2_research/runtime_json_keys.json`:

```json
{
  "session_pid": 12345,
  "duration_s": 180,
  "class_count": 42,
  "pair_count": 530,
  "last_stats": { "hook_fires": 5123, "unique_pairs": 530 },
  "errors": [],
  "classes": {
    "BaseClass17Impl_3A2B": ["avatarId", "performanceRating", "..."]
  }
}
```

Keys are de-duplicated in the agent (per `(class,key)`) and again in the driver
(set per class), then sorted.

## Run instructions

```bash
# VRChat must already be running (own client; VRChat.exe --no-vr offline).
pip install frida frida-tools          # frida-python 17.x

python collect_json_keys.py                 # auto-find PID, 180s capture
python collect_json_keys.py --pid 12345 --duration 600
```

While it captures, EXERCISE the game: open the menu, load avatars, enter worlds,
browse search - each API fetch funnels through Newtonsoft and fires the hook.
The console prints running pair/stat counts; results land in
`output/p2_research/runtime_json_keys.json`.

The agent never calls a game function, so it is safe to run against the live
client per the anti-tamper analysis. It does not call `get_UnderlyingName`,
`gc.choose`, or any export - only `Interceptor.attach` + raw memory reads.
