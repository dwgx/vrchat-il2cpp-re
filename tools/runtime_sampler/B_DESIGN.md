# Approach B — Pure frida-il2cpp-bridge on VRChat's Beebyte Layout

Research + empirical export-table evidence + verdict for the "pure bridge" comparison arm.
All findings below are from reading the actual bridge source shipped in this repo
(`node_modules/frida-il2cpp-bridge@0.13.1`) and parsing the **live**
`GameAssembly.dll` PE export table. No Frida was run (VRChat not running).

---

## 1. How frida-il2cpp-bridge discovers offsets (mechanism, from source)

Key fact for this evaluation: **the bridge does NOT hardcode struct offsets, and it does
NOT pattern-scan for them either.** It gets every piece of class/field/object metadata by
*calling the exported `il2cpp_*` C API* and letting GameAssembly.dll's own code do the
struct walking. Evidence, by file/line in
`node_modules/frida-il2cpp-bridge/dist/index.js`:

- **Central resolver** (line 697-716), `r(exportName, retType, argTypes)`:
  ```js
  const handle = Il2Cpp.$config.exports?.[exportName]?.()
      ?? Il2Cpp.module.findExportByName(exportName)
      ?? Il2Cpp.memorySnapshotExports[exportName];
  const target = new NativeFunction(handle ?? NULL, retType, argTypes);
  ```
  Every API is a lazy getter that calls `r("il2cpp_<name>", ...)`. Resolution order is:
  1. user override in `Il2Cpp.$config.exports[name]` (a `() => NativePointer`),
  2. **`module.findExportByName("il2cpp_<name>")`** — i.e. a *literal export-name lookup*,
  3. a tiny built-in CModule that only provides the two `il2cpp_memory_snapshot_*` helpers.

  If all three fail, it returns a Proxy that throws on first call:
  > `export <name> points to NULL — IL2CPP library has likely been stripped, obfuscated, or customized` (line 711).

- **All metadata flows through that API**, not through raw reads:
  - `Il2Cpp.Class.name` → `Il2Cpp.exports.classGetName(this).readUtf8String()` (line 1981-1982)
  - `Il2Cpp.Class.namespace` → `classGetNamespace(this)` (line 1985-1986)
  - `Il2Cpp.Class.fields` → `readNativeIterator(_ => classGetFields(this, _))` (line 1894-1895)
  - `Il2Cpp.Class.parent` → `classGetParent(this)` (line 1994)
  - `Il2Cpp.Field.offset` → `fieldGetOffset(this)` (line 2342-2343)
  - `Il2Cpp.Field.name` → `fieldGetName(this)` (line 2338-2339)
  - `Il2Cpp.Object.class` → `objectGetClass(this)` (line 3079-3080)
  - `Il2Cpp.gc.choose(klass)` → `il2cpp_unity_liveness_*` + stop/startWorld (line 830-862)

  So "auto-detect" here means **name-based export resolution**, full stop. There is exactly
  one place the bridge brute-scans for an offset rather than asking the API: the
  `Il2Cpp.String` content offset is found heuristically via `handle.offsetOf(...)` (line
  1861, 3351) — but that path still depends on `il2cpp_string_*` / a known string existing.

- **Official escape hatch for obfuscated binaries** (doc comment, line 304-322): exports
  "are searched by **name** ... hence they might get stripped, hidden or renamed by a nasty
  obfuscator. However, it is possible to override ... using `Il2Cpp.$config.exports`":
  ```ts
  Il2Cpp.$config.exports = {
      il2cpp_image_get_class: () => Il2Cpp.module.base.add(0x1204c),
      il2cpp_class_get_parent: () => Memory.scanSync(...)[0].address,
  };
  ```
  This is the intended path when `findExportByName` fails. It supplies a **function
  pointer**, not a struct offset — i.e. you still call the real GA routine, you just point
  the bridge at the renamed export. There is **no** config knob to inject the
  `klass.name@+0x50` style struct offsets directly; the bridge has no code path that reads
  those fields itself, so feeding it offsets is not even meaningful.

`Il2Cpp.$config` (line 145-149) exposes only three knobs: `moduleName`, `unityVersion`,
`exports`. Module detection (line 1333-1342) honors `$config.moduleName`, else probes
platform defaults — on Windows we set it to `GameAssembly.dll`.

---

## 2. Empirical export-table evidence — does GameAssembly.dll export the il2cpp_* API?

**No. The il2cpp_* API is almost entirely stripped/renamed.** Parsed directly from the live
DLL on disk (`D:/Steam/steamapps/common/VRChat/GameAssembly.dll`, 216 MB, mtime 2026-06-26)
with `pefile 2024.8.26`:

```
TOTAL named exports:                 251
il2cpp_-prefixed exports:              3   ->  il2cpp_free
                                            il2cpp_gchandle_get_target
                                            il2cpp_native_stack_trace
candidate Beebyte-renamed (11-char):  232
```

The repo's cached `data/exports.json` (264 names) agrees: only those same **3** keep their
`il2cpp_` names. Everything else is renamed by Beebyte to 11-char gibberish
(`xbdxfIjXGZA`, `HVnVGWHvEoF`, ...). Confirmed independently of the cache by re-parsing the
PE this session, so it is not stale.

**What the bridge needs vs. what name-lookup can find.** The bridge resolves **123 distinct
`il2cpp_*` exports** (counted from `r("il2cpp_...")` call sites in dist/index.js). Against
the renamed export table, `findExportByName` will hit exactly the **3** unobfuscated names.
The other 120 resolve to NULL and throw on first use. So pure auto-detect fails immediately
— `Il2Cpp.domain` / `Il2Cpp.perform` can't even bootstrap, because `il2cpp_domain_get` and
`il2cpp_thread_attach` are both renamed.

**How much of the renamed table has the repo already de-obfuscated?** This is what makes the
`$config.exports` override path *partially* feasible. From `data/export_mapping.json` /
`data/il2cpp_export_map.json`:

| Mapping confidence | count | notes |
|---|---|---|
| `confirmed` (hand-verified, in `final_mapping`) | **5 APIs** | domain_get, thread_attach, free, gchandle_get_target, native_stack_trace |
| heuristic `best_match` (size/param/call-count guess, conf 0.3-0.9) | ~40 entries | mostly collide onto a few APIs (e.g. ~25 different obf names all guessed as `il2cpp_class_from_name` at conf 0.4 — i.e. unusable as 1:1 overrides) |
| unmapped | rest | — |

Coverage of the **minimal sampler path** (the 27 APIs needed for: bootstrap →
enumerate image classes / class-from-name → `gc.choose` live instances → read field
name/offset/type → read string content):

```
MINIMAL SAMPLER PATH: 27 APIs needed
  confirmed-mapped:  2   (il2cpp_domain_get, il2cpp_thread_attach)
  NOT mapped (confirmed): 25
```

Critically missing, confirmed-grade: `domain_get_assemblies`, `assembly_get_image`,
`image_get_class[_count]`, `class_from_name`, `object_get_class`, `class_get_name`,
`class_get_namespace`, `class_get_fields`, `class_get_parent`, `field_get_name`,
`field_get_offset`, `field_get_type`, the six `unity_liveness_*` routines, `stop/start_gc_world`,
`string_chars`, `string_length`, `gc_disable/enable`. These are the *core* of any sampler and
none are reliably resolved today.

### 2b. Second, independent blocker: anti-tamper return-address check

Even with correct export pointers, the bridge's calling convention is wrong for VRChat.
Per this repo's own `tools/bridge.js` (header + `_installTrampoline`, line 4-6, 65-151),
VRChat validates the **return address** of calls into GameAssembly.dll: a call is only
accepted if the return address lies inside GA's VA range. The repo's working bridge defeats
this by writing a 64-byte trampoline into GA's `.data` section (RWX), so `call rax` returns
into GA, not into Frida/Gum's allocated stub.

`frida-il2cpp-bridge` calls every export with a **plain `new NativeFunction(handle, ...)`**
(line 699). Those calls return into Gum's trampoline pages, *outside* GA's range, so they
would trip VRChat's check exactly the way the repo notes the naive approach does. The bridge
has no hook for routing calls through an in-module trampoline; `$config.exports` only lets
you change *where the function is*, not *how it's called*. (This anti-tamper behavior is a
prior-work finding documented in `tools/bridge.js` and the memory notes; I did not
re-verify it dynamically this session since VRChat is not running.)

---

## 3. What a "pure bridge" attempt would actually require (patch surface)

To make vfsfitvnm's bridge drive sampling end-to-end on this binary you would need all of:

1. **De-obfuscate ~120 exports to confirmed 1:1 mappings.** Today only 5 are confirmed and
   ~40 more are low-confidence guesses with many-to-one collisions. The minimal path alone
   needs 27, of which 25 are not confirmed. Producing the rest is a full RE sub-project
   (disassemble each candidate, match prologue/semantics to a known IL2CPP routine), and the
   bridge needs them as an exact `$config.exports` table of `() => NativePointer`.
2. **Resolve the renamed exports per-session under ASLR.** GA base moves each launch
   (`vrc_frida_config.json` ga_base is documented stale), so overrides must be
   `() => Process.findModuleByName("GameAssembly.dll").base.add(rva)` using the per-export
   RVAs from `data/export_mapping.json` — not hardcoded VAs.
3. **Patch the bridge's call mechanism** to route every export call through an in-GA
   trampoline to satisfy the return-address check. This is a fork-level change: the bridge
   builds `NativeFunction`s inline in dozens of getters; there is no single interception
   point. You'd either monkeypatch `Il2Cpp.exports` getters or fork `r()`.
4. **Re-validate the snapshot/liveness struct assumptions.** `gc.choose` and
   `memorySnapshotExports` embed a CModule with a hardcoded `Il2CppManagedMemorySnapshot`
   layout (line 696). Beebyte/Unity-version drift there would corrupt the walk. Needs
   confirmation against this exact build.

By contrast, the verified Beebyte struct offsets we already hold (klass name +0x50, ns +0x18,
methods +0x88, fields +0x1D8, parent +0x80, static_fields +0xB8, mc +0x120, fc +0x122; field
stride 0x30 name+0x08/offset+0x04/type+0x10; Il2CppString len+0x10/chars+0x14) let approach A
read everything with **raw memory reads and zero export calls** — which also sidesteps the
return-address check entirely, because it never calls into GA.

---

## 4. VERDICT

**Pure-bridge is NOT viable on this Beebyte binary; hybrid (Approach A) wins. Decisively, on
two independent grounds.**

1. **Export resolution is broken at the root.** Only 3 of 123 needed `il2cpp_*` exports keep
   resolvable names; 232 of 251 exports are Beebyte-renamed. The bridge's entire offset/
   metadata story is "call the named export," so it cannot bootstrap (`il2cpp_domain_get` is
   renamed) let alone read fields. Making it work means hand-confirming ~120 export mappings
   — today only 5 are confirmed and the minimal sampler path is 2/27. That is not
   "configuration," it's the same RE labor approach A already encodes as 8 struct offsets.

2. **Even fully mapped, the calling convention is wrong.** VRChat's return-address anti-tamper
   check rejects the bridge's plain `NativeFunction` calls (return into Gum, outside GA).
   Defeating it requires the in-GA trampoline this repo's `bridge.js` already implements,
   which is a fork-level patch to the bridge's call path with no clean override point.

The bridge's one genuine asset is `gc.choose` (GC-safe liveness enumeration via
`il2cpp_unity_liveness_*`). But those six exports are also renamed and unconfirmed, and they
must be *called* (so they hit the same anti-tamper wall). Approach A's manual object-header
scan in `vrc_frida_lib.js` already covers enumeration without any export call.

**Recommendation:** keep Approach A (hybrid: raw struct reads on verified Beebyte offsets +
manual heap scan). The accompanying `pure_bridge_sampler.js` is built as the *evidence
artifact* for this verdict: it wires `Il2Cpp.$config.exports` from the repo's confirmed
mapping and falls back to a pure raw-offset reader (no export calls) for the parts the bridge
can't reach. In practice the fallback path is the only one that runs end-to-end here, which is
exactly why hybrid wins. If anyone later confirms the full ~120-export mapping AND adds the
trampoline call shim, pure-bridge could be revisited — but that is strictly more work than
approach A for an identical result.
