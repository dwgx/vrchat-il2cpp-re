# Approach A — Hybrid Runtime Instance-Value Sampler

Leak VRChat class identity from **live data**, since Beebyte stripped class names at
compile time (not encrypted — no metadata tool can recover them). We dump real values
flowing through live instances: string field values, nested object class names,
numeric/enum values, and (optionally) `ToString()` output.

## Why hybrid

Two layout worlds collide:

- **frida-il2cpp-bridge** (`vfsfitvnm`) assumes a *standard* IL2CPP `Il2CppClass` layout.
  VRChat is **Beebyte-modified**, so the bridge's struct readers point at the wrong
  offsets — names, field arrays, counts all land in the wrong place.
- **Our `vrc_frida_lib.js`** has the *verified Beebyte* offsets (name `+0x50`,
  fields `+0x1D8` stride `0x30`, counts `+0x120/+0x122`, etc).

So we split responsibilities:

| Job | Tool | Why it is safe |
|---|---|---|
| Enumerate live instances of a class | `Il2Cpp.gc.choose(klass)` (bridge) | Walks the Boehm GC heap through the public IL2CPP API. Does **not** depend on the shuffled struct layout — only needs a valid `Il2CppClass*`. |
| Read every field value | `VRC.klassGetFields` + raw `instPtr.add(offset)` (ours) | Uses our verified Beebyte offsets, never the bridge's standard-layout field reader. |

The bridge's only structural dependency is producing a class handle for `gc.choose`.
We feed it a klass pointer that **we** discovered with our offsets, wrapped via
`new Il2Cpp.Class(handle)`, so the enumeration path never trusts the bridge's idea of
field/name layout.

## Files

```
tools/runtime_sampler/
  hybrid_sampler.js   Frida agent: re-resolve targets, gc.choose, read fields, send()
  sample_instances.py Python driver: build agent, attach, inject, collect, write JSON
  agent.ts            (generated) frida-compile entry: import "frida-il2cpp-bridge"
  package.json        pins the bridge + frida-compile (frida-il2cpp-bridge 0.13.1)
  agent.js            (generated) frida-compiled bridge bundle (the global Il2Cpp)
  A_DESIGN.md         this file
```

Injected script is the concatenation, in order:
`agent.js` (global `Il2Cpp`) + `vrc_frida_lib.js` (global `VRC`) + `hybrid_sampler.js`.
A single `session.create_script` keeps all three in one scope so the sampler sees both
globals.

## Stale `va` → live klass re-resolution (the critical part)

The target list (`runtime_sample_targets.json`, 4282 weak rows / 65 DTO-priority) carries
a `va` per row, but **those are stale** — captured under a previous session's ASLR base.
GameAssembly.dll's base changes every launch, so a hardcoded `va` would point at garbage
(or a different object) this session. We never use `va`.

Instead, each run does a fresh re-resolution inside the agent:

1. **`buildClassIndex()`** — walk `Il2Cpp.domain.assemblies[*].image.classes` (public
   API, layout-agnostic), and for each class read, **with our Beebyte offsets**, the
   name (`+0x50`), field count (`+0x122`), method count (`+0x120`). Index by
   `"name|nfields|nmethods"`.
2. **`resolveTargets()`** — for each target, look up `name|nfields|nmethods`.
   - exact hit → use those current klass pointer(s), `matchedBy = "name+counts"`.
   - no hit → loosen to **name-only** (counts can drift if a struct field is re-read
     differently), `matchedBy = "name-only"`, flagged ambiguous if >1.
   - still nothing → counted as `unmatched`.

The obfuscated `name` is itself the join key: Beebyte names like
`BaseClass290ImplImpl_828C` are stable strings in this build, so matching the obfuscated
original name + structural counts uniquely (or near-uniquely) recovers the **current**
`Il2CppClass*`. This is robust to ASLR because it rediscovers pointers live every run.

## GC handling (Boehm)

Boehm GC can move/free objects mid-traversal, invalidating pointers we are reading.
For each class we wrap the **entire `choose` + field-read window** in
`il2cpp_gc_disable()` / `il2cpp_gc_enable()`:

- `gcDisable()` / `gcEnable()` prefer `Il2Cpp.gc.disable/enable`, falling back to the raw
  `Il2Cpp.api.il2cpp_gc_disable/enable` exports the bridge resolves.
- Pinning is per-class (in a `try/finally`) so GC is always re-enabled even on error,
  and we never hold the collector off for the whole (possibly long) run.
- Instances are capped at `maxInstancesPerClass` (default 50) to keep each pinned window
  short.

## Field value heuristics

We do **not** trust `Il2CppType` layout (Beebyte may shuffle it and we have no verified
`Il2CppType` offsets). For each field slot at `instPtr + field.offset` we record multiple
cheap interpretations and keep whatever decodes cleanly:

- `i32` / `u32` / `f32` — inline primitive guesses (enums, ints, floats).
- `str` — read slot as `Il2CppString` (`VRC.readIl2CppString`, len `+0x10`, UTF-16 `+0x14`);
  kept only if printable and within `maxStringLen`.
- `objClass` / `objNamespace` — if the slot is a heap pointer to a managed object, read
  *that* object's `[klass]` and resolve its name via Beebyte `+0x50`. Nested class names
  are strong identity signals (e.g. a field typed `ApiWorld` betrays the owner DTO).
- `objIsObfuscated` — flags whether the nested class name is still Beebyte glyphs.

`looksLikeHeapPtr` rejects unaligned / out-of-range junk; `isPrintable` accepts ASCII and
Beebyte glyph range `U+00CC–00CF`.

### ToString() — off by default

`tryToString()` can invoke the managed `ToString()` via the bridge, which often yields a
clean identity string for DTOs. It is **disabled by default** (`invokeToString: false`)
because a managed call routes through a bridge `NativeFunction`, and VRChat's anti-tamper
**return-address check** may terminate the process when the return address is outside
GameAssembly.dll's range. Enable with `--tostring` only if you accept that risk; the
existing `bridge.js` trampoline (data-section return address) is the mitigation path if
this proves necessary.

## Output

`output/p2_research/runtime_instance_values.json`:

```jsonc
{
  "session_pid": 12345,
  "target_count": 65,
  "sampled_classes": 60,
  "summary": { "resolved": 60, "unmatched": 5, "ambiguous": 3, "instances": 1840 },
  "errors": [ ... ],
  "results": [
    {
      "klass": "0x...",                 // CURRENT-session pointer
      "original_name": "BackingFieldBase_k__BackingField_55CF",
      "full_name": "<ns>.<obf-name>",
      "is_dto": true,
      "callee_hint": ["JsonProperty", "ObjectPool_1", ...],
      "matched_by": "name+counts",
      "live_count": 12,
      "declared_fields": [ {"name": "...", "offset": "0x10"}, ... ],
      "instances": [
        { "addr": "0x...", "fields": [
            {"name":"...","offset":"0x10","str":"https://api.vrchat.cloud/..."},
            {"name":"...","offset":"0x18","objClass":"ApiWorld","objNamespace":""},
            {"name":"...","offset":"0x20","i32":3,"u32":3}
        ] }
      ]
    }
  ]
}
```

## Build & run

```bash
# 1. one-time: build the bridge agent (needs node/npm)
python tools/runtime_sampler/sample_instances.py --build-agent
#   -> reuses package.json/node_modules here (frida-il2cpp-bridge 0.13.1)
#   -> npx frida-compile agent.ts -o agent.js

# 2. launch the target yourself (own client, offline research):
#      VRChat.exe --no-vr        # avoids EAC; get into a world so DTOs are populated

# 3. sample (DTO-priority by default):
python tools/runtime_sampler/sample_instances.py
python tools/runtime_sampler/sample_instances.py --all --max-instances 30
python tools/runtime_sampler/sample_instances.py --tostring   # risky, see above
```

Driver auto-finds `VRChat.exe` (or pass `--pid`), injects the combined script, posts the
target list via `script.post({type:"start", ...})`, collects `send()` messages, and writes
the JSON. `--timeout` bounds the wait and writes partial results on timeout.

## Open risks / not yet verified

- **Not run live.** JS validated with `node --check`, Python with `py_compile`. No
  attach/inject was performed (VRChat not running). `gc.choose` behavior, `Il2Cpp.Class`
  wrapping a raw Beebyte handle, and the `gc.disable/enable` export names are assumed from
  the bridge's public API and have **not** been confirmed against this build at runtime.
- **Bridge init on Beebyte layout.** frida-il2cpp-bridge auto-detects exports/metadata at
  load. If its initializer hard-depends on standard struct fields it may throw before
  `Il2Cpp.perform` runs. Mitigation if so: import the bridge for its `gc.choose` +
  `il2cpp_gc_*` API only, and skip its metadata bootstrap. Untested.
- **`Il2Cpp.Class(handle)` API shape** may differ by bridge version; `sampleKlass` assumes
  `new Il2Cpp.Class(ptr)` then `Il2Cpp.gc.choose(wrapped)` returning objects with
  `.handle`. Confirm against the installed `frida-il2cpp-bridge` version before a long run.
- **Re-resolution ambiguity.** Classes sharing an obfuscated name + identical counts yield
  multiple klass pointers; we sample all and tag `ambiguous`. Disambiguation is left to
  post-analysis of the leaked values.
- **EAC / anti-tamper.** Field *reads* are passive and low-risk. `--tostring` issues
  managed calls and may trip the return-address check; keep it off unless needed.
- **Agent version pins** in `package.json` (`frida-il2cpp-bridge ^0.13.1`,
  `frida-compile ^19`) match the already-installed `node_modules` (bridge 0.13.1 confirmed
  present); adjust if `frida-compile` emits an incompatible runtime for frida-python 17.15.1.
