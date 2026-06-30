# VRChat Runtime Instance-Value Sampler

Recover real class names for VRChat's Beebyte-obfuscated IL2CPP build by reading
**live data**, not the binary. This directory is the master orchestration point
for that runtime axis: capture values flowing through live instances, turn them
into ranked name candidates, and feed those candidates into the existing naming
gate.

---

## Why runtime sampling exists

Static reversing has a ceiling. VRChat is **Beebyte-obfuscated**: class names are
*stripped at compile time*, not encrypted. There is no key, no metadata blob, no
decryptor that brings them back — the authored strings simply are not in
`GameAssembly.dll` or its `global-metadata.dat` anymore (the on-disk metadata
holds the same `ÌÍÎÏ` glyph garbage). Structural reversing can only label a
class's *role* (`BaseClass290Impl_828C`, `DataOnly4f`), never its developer name.
That is why the static naming pipeline tops out around **56.9%** class coverage
and cannot climb further from the file alone.

What obfuscation cannot strip is the data a *live* instance carries:

- the **JSON keys** it (de)serialises — those keys ARE its own field names,
- the **GameObject** it is attached to (a developer-authored identifier),
- the **string values** drawn from the product's domain,
- its **`ToString()`** output (often leads with the type name).

Runtime sampling is the new axis: dump those live values, score them, and recover
names the binary alone can never yield.

---

## The bridge-vs-memscan decision (read this before running)

We evaluated two enumeration paths and **memscan won decisively**. The full
evidence is in `EXPORT_FINDING.md` (empirical) and `B_DESIGN.md` (mechanism +
verdict). Summary:

| | frida-il2cpp-bridge (pure) | memscan (pure-memory) |
|---|---|---|
| How it reads metadata | calls exported `il2cpp_*` C API | raw struct reads at verified Beebyte offsets |
| Works on this build? | **No** | **Yes** |
| Why | only **3 of ~123** needed `il2cpp_*` exports survive (`il2cpp_free`, `il2cpp_gchandle_get_target`, `il2cpp_native_stack_trace`); the other 232 of 251 exports are Beebyte-renamed, so the bridge cannot even bootstrap | enumerates instances by object-header scan and reads every field by raw offset — **zero GameAssembly function calls** |
| Anti-tamper | VRChat's **return-address check** rejects the bridge's `NativeFunction` calls (return into Gum, outside GA) and can terminate the process | never calls into GA, so it never trips the check |

`memscan_sampler.js` is therefore the reliable path and the default
(`--mode auto` resolves to `memscan`). `hybrid_sampler.js` (bridge `gc.choose` +
our offset readers) and `pure_bridge_sampler.js` are kept as the comparison /
evidence artifacts and require the bridge to initialise, which it cannot do here
without hand-confirming ~120 export mappings plus a call-shim. Do not reach for
`--mode bridge` unless that work has been done.

---

## Architecture

```
                       runtime_sample_targets.json   (4282 weak classes / 65 DTO-priority)
                       name|nfields|nmethods + is_dto + callee_hint   ('va' is STALE, ignored)
                                       |
            +--------------------------+--------------------------------+
            |                                                           |
   INSTANCE-VALUE CAPTURE (memscan)                          JSON-KEY CAPTURE (Interceptor)
   sample_instances.py --mode memscan                        find_json_hooks.py  (static map)
            |  injects, in order:                                       |  -> json_hook_points.json
            |    vrc_frida_lib.js  (global VRC, Beebyte readers)        |  hook SetPropertyValue etc.
            |    memscan_sampler.js (re-resolve + scan + read)          |
            v                                                           v
   runtime_instance_values.json                              runtime_json_keys.json
   { results:[{obf_class, instances:[{fields,strings,json_keys}]}] }   (key -> obf class)
            |                                                           |
            +--------------------------+--------------------------------+
                                       v
                       extract_realnames.py   (signal scoring: json_keys>gameobject>strings>tostring)
                       FIRST gate: name_quality.is_weak_name + VALID format + confidence floor
                                       |
                                       v
            output/p2_research/naming_results/runtime_sampler_slice_realnames.json
                       (slice_* name -> picked up by the gate's existing glob, no code change)
                                       |
                                       v
                       tools/gate_decompile_names.py   (CENTRAL gate: is_weak_name + distinctive
                       callee signal + obfclass_to_original map)  -> decompile_class_names.json
                                       |
                                       v
                       tools/apply_class_names.py  ->  recount coverage
```

Everything that re-enters the live process uses **only** the verified Beebyte
offsets in `vrc_frida_lib.js`. No path trusts the standard IL2CPP layout.

### Verified Beebyte offsets (this build, `vrc_frida_lib.js`)

| Struct | Field | Offset |
|---|---|---|
| `Il2CppClass` | name | `+0x50` |
| | namespace | `+0x18` |
| | fields array | `+0x1D8` |
| | methods array | `+0x88` |
| | parent | `+0x80` |
| | static_fields | `+0xB8` |
| | method_count | `+0x120` |
| | field_count | `+0x122` |
| field entry (stride `0x30`) | name | `+0x08` |
| | offset | `+0x04` |
| | type | `+0x10` |
| `Il2CppString` | length | `+0x10` |
| | chars (UTF-16) | `+0x14` |

**File-VA <-> runtime rebase:** addresses in the design docs / symbol tables are
file-VA on a `0x180000000` image base. Convert to the live address with:

```
runtime_va = module_base + (file_va - 0x180000000)
```

The dump `va` fields in `runtime_sample_targets.json` are **stale** (captured
under a previous session's ASLR base) and are never used — every target is
re-resolved live each run by matching `name|nfields|nmethods` against a fresh
class scan.

---

## The 5-step pipeline (exact commands)

Run from the repo root `D:/Project/vrchat-il2cpp-re/`.

### Step 0 — sanity check (no Frida, VRChat not needed)

```bash
python tools/runtime_sampler/dry_run_check.py
```

Verifies every component wires together: files present, all `.js` pass
`node --check`, all `.py` compile, the target list + any produced JSON parse, and
`extract_realnames`'s behaviour test passes. Outputs the readiness table. Run
this until green before going live.

### Step 1 — prep the game (you, in-game)

Launch your own client offline and exercise the features whose instances /
DTOs you want to recover, so live objects populate and JSON deserialisation
fires:

```
VRChat.exe --no-vr        # offline, own-client research; --no-vr avoids the VR/EAC path
```

Then **log in and use the app** — see the in-game checklist below.

### Step 2 — capture instance values (memscan, the reliable path)

```bash
python tools/runtime_sampler/sample_instances.py --mode memscan
# variants:
python tools/runtime_sampler/sample_instances.py --mode memscan --all --max-instances 30
python tools/runtime_sampler/sample_instances.py --pid 12345 --mode memscan
```

Auto-finds `VRChat.exe` (or pass `--pid`), injects `vrc_frida_lib.js` +
`memscan_sampler.js`, posts the target list, collects `send()` messages, and
writes:

```
output/p2_research/runtime_instance_values.json
```

Defaults to the **65 DTO-priority** targets; `--all` covers all 4282 weak
classes (slow). `--tostring` is **off by default and risky** (a managed call can
trip the anti-tamper return-address check) — leave it off unless you accept that.

### Step 3 — capture JSON keys

The strongest leak is the set of JSON keys flowing into each obfuscated object
during Newtonsoft deserialisation (`SetPropertyValue` is the prime hook — it sees
both the property identity and the target object once per key). The static hook
map is produced by:

```bash
python tools/runtime_sampler/find_json_hooks.py
# -> output/p2_research/json_hook_points.json
#    (newtonsoft core hooks + support accessors + per-target DTO candidates)
```

The live Interceptor collector that installs those hooks and writes
`output/p2_research/runtime_json_keys.json` is the **one pending-live component**
in this directory (see "Status & honesty notes"). Until it lands, JSON keys are
sampled as the `json_keys[]` derived field already emitted per instance by the
memscan sampler, which `extract_realnames.py` consumes directly.

### Step 4 — extract candidate names

```bash
python tools/runtime_sampler/extract_realnames.py
# in : output/p2_research/runtime_instance_values.json
# out: output/p2_research/naming_results/runtime_sampler_slice_realnames.json
```

Aggregates each class's signals **across instances** (consistency is the point),
scores `json_keys (4.0) > gameobject_name (3.0) > strings (1.5) > tostring (1.0)`,
and emits `{obf_class, proposed_name, confidence, evidence[]}`. The output lands
in `naming_results/` with a `slice_*` name so the gate's existing `*slice_*.json`
glob picks it up with no code change. This module is the **first** gate: every
surviving candidate must clear `name_quality.is_weak_name` + the `VALID`
PascalCase format + a confidence floor, else `proposed_name=null`. Prefer null
over a structural guess (the item-20 anti-inflation lesson).

### Step 5 — gate, apply, recount

```bash
python tools/gate_decompile_names.py     # central gate -> output/decompile_class_names.json
python tools/apply_class_names.py        # merge into the dump
# then re-run the project's coverage report to recount
```

The central `gate_decompile_names.py` is the authority: it re-applies
`is_weak_name`, the `VALID` format, the **distinctive callee-signal** requirement,
and the `obfclass_to_original` map before anything reaches
`decompile_class_names.json`. A runtime candidate can never bypass the coverage
criterion — its name has to survive both gates.

---

## What you must do in-game (capture checklist)

Instances only exist while a feature is active and JSON only fires while data
loads. Before/while running Step 2, drive the client through the features whose
DTOs you want, leaving each panel open long enough for its objects to populate:

- [ ] **Log in** fully (forces the auth / config / user-profile DTOs to deserialise).
- [ ] **Avatars** — open the avatar menu, load several avatars, open avatar details / performance stats.
- [ ] **Worlds** — browse world rows, open a world's detail page, join a world.
- [ ] **Favorites** — open Favorites (avatars + worlds), scroll the lists.
- [ ] **Groups** — open the Groups tab, view a group, its members / roles / posts.
- [ ] **Inventory** — open Inventory, view owned items / products.
- [ ] **Settings** — open Settings (loads the settings/config DTOs).
- [ ] Leave panels open a few seconds each so instances are live during the scan; the sampler caps at `--max-instances` per class.

The more of these you exercise, the more obfuscated classes resolve to a live
klass pointer and carry recoverable values.

---

## GC, anti-tamper & safety notes

- **memscan never calls into GameAssembly.dll.** It enumerates instances by
  object-header scan (every IL2CPP object's first qword is its `Il2CppClass*`)
  and reads fields by raw Beebyte offset. That is what sidesteps the
  return-address anti-tamper check — there is no `NativeFunction` call to flag.
- **Boehm GC safety.** memscan does not (cannot) call `il2cpp_gc_disable`. Instead
  it minimises the read window and **re-validates each object's header**
  (`[inst+0]==klass`) immediately before reading, skipping anything that moved.
- **`--tostring` is off by default.** A managed `ToString()` routes through a
  bridge `NativeFunction`, which can trip the return-address check and terminate
  the process. Enable only if you accept that risk; the `bridge.js` trampoline
  (data-section return address) is the mitigation path if it ever proves needed.
- **Field reads are passive and low-risk;** managed calls are not. The default
  configuration issues **zero** managed calls.
- **Own-client, offline research only.** `--no-vr` keeps you off the VR/EAC path.

---

## Files in this directory

| File | Role |
|---|---|
| `README.md` | this file — master orchestration |
| `dry_run_check.py` | static validator (no Frida); run until green |
| `sample_instances.py` | Python driver: attach, inject, collect, write JSON |
| `memscan_sampler.js` | **default** sampler: pure-memory, zero export calls |
| `hybrid_sampler.js` | bridge `gc.choose` + our readers (needs bridge init) |
| `pure_bridge_sampler.js` | pure-bridge evidence artifact (verdict: not viable) |
| `extract_realnames.py` | scores sampled values -> ranked name candidates (1st gate) |
| `test_extract_realnames.py` | behaviour lock for the scorer |
| `find_json_hooks.py` | static map of Newtonsoft hook points -> `json_hook_points.json` |
| `A_DESIGN.md` | hybrid (Approach A) design |
| `B_DESIGN.md` | pure-bridge research + verdict |
| `EXPORT_FINDING.md` | export-table evidence (3/123 il2cpp_* survive) |
| `EXTRACT_DESIGN.md` | name-extraction scoring design |
| `JSON_HOOK_DESIGN.md` | Newtonsoft deserialisation hook design |
| `package.json` / `node_modules/` | frida-il2cpp-bridge 0.13.1 + frida-compile (for the bridge path) |

Shared, repo-level dependencies (one level up):
`tools/vrc_frida_lib.js`, `tools/name_quality.py`, `tools/gate_decompile_names.py`,
`tools/apply_class_names.py`.

---

## Status & honesty notes

- **Nothing has been run live.** VRChat is not running; every component here is
  validated statically (`node --check`, `py_compile`, the scorer's behaviour
  test). `gc.choose`, the live klass re-resolution, and the GC/anti-tamper
  behaviour are documented from analysis and the bridge's public API and have
  **not** been confirmed at runtime against this build.
- **Pending-live outputs.** `runtime_instance_values.json`,
  `runtime_json_keys.json`, and `runtime_sampler_slice_realnames.json` do not
  exist until Steps 2-4 run against a live client. `dry_run_check.py` treats them
  as *pending live*, not failures.
- **Pending component.** A standalone live JSON-key collector
  (`collect_json_keys.py` -> `runtime_json_keys.json`) is not yet built;
  `find_json_hooks.py` produces the static hook map it would install, and the
  memscan sampler already emits derived `json_keys[]` per instance in the
  meantime.
- **agent.js** (the frida-compiled bridge bundle) is only needed for
  `--mode bridge`; build it once with
  `python tools/runtime_sampler/sample_instances.py --build-agent`. The default
  memscan path does not need it.
