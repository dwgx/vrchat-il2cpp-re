# FIELDTYPE_DESIGN — per-target field-type map for the runtime sampler

## What this produces

`build_target_fieldtypes.py` → `output/p2_research/target_field_types.json`,
keyed by obfuscated target class name. For each of the 4282 weak targets it emits
every instance field with: field obf-name, estimated byte offset, resolved static
type, and a **sampling class** the runtime sampler acts on:

| sampling_class | meaning | how the sampler reads the slot |
|---|---|---|
| `STRING` | `System.String` | read via Il2CppString at the slot offset |
| `OBJECT` | managed ref (domain class / interface / array / generic collection / `Object`) | follow the pointer, read the nested object's class name |
| `VALUE`  | numeric / bool / char / enum / known blittable struct (Vector3, Guid, ...) | read raw bytes at the slot |
| `SKIP`   | generic plumbing (delegates, `Action`/`Func`, `CancellationToken`, `Awaiter`, `Type`, compiler `<>c`, still-obfuscated unresolvable refs) | do not sample — no identity value |

## Where the type info came from

Three inputs were inspected:

- **`output/field_types_from_metadata.json` — UNUSABLE.** jun26 `global-metadata.dat`
  is encrypted, so this extract is garbage: empty `name` strings, wild
  `type_index` values (range ±2.1e9), only 1 "type" recovered. Discarded.
- **`output/field_type_signal.json` — DERIVED, not source.** It is a digest of the
  typed dump keeping only *discriminative* field types (primitives/plumbing/obf
  dropped), keyed by current/obf name. Useful as a naming signal, not as a complete
  per-field type table. Not used for the join.
- **`data/precise_dump_unity6_typed.json` — THE SOURCE.** Each class carries
  `field_types: { field_obf_name → resolved_type_string }`, produced by the Unity 6
  reverse extractor (FieldInfo `Il2CppType` @ FI+0x10, klass byval-arg map @
  klass+0x20; `schema_version: 2`, `typed_fields: true`). This is the only input
  with a resolvable static type for every field.

## The join (two hops — VAs are not stable across dump sessions)

```
target.va  --[precise_dump.json, same dump session as the target list]-->  obf class
obf class name  --[typed dump, obf NAME is the stable cross-session key]-->  field_types
```

The target list (`runtime_sample_targets.json`) uses **deobfuscated display names**
(`Struct2f_B46C`, `Record9f_5498`, ...) plus runtime VAs from
`VRChat_32984_20260629_180349_full.dmp`. `precise_dump.json` is that same session,
so `target.va` resolves there to the still-**obfuscated** class (Beebyte ÌÍÎÏ name).
The typed dump is a *different* session (`VRChat_6456_...`) with different VAs, but
class/field obfuscated names are stable, so we re-key by obf class name to pull the
resolved `field_types`. Verified: all 4282 target VAs resolve in `precise_dump.json`;
target names match the typed dump 0% by name but 100% via this VA→obf-name bridge.

## Offsets — estimated, not authoritative

No available input carries a true runtime byte offset: both source minidumps are
gone, and the typed/precise dumps store fields as ordered name lists only. The
runtime samplers (`memscan_sampler.js`, `hybrid_sampler.js`) read the **live**
FieldInfo offset themselves via `VRC.klassGetFields` at sample time — that is the
authoritative value. This tool emits a best-effort `offset` by walking field sizes
from the x64 object header (0x10) with natural alignment, and flags every field
`offset_estimated: true`. **The sampler must trust its live FieldInfo.offset over
this estimate** when both are present; the estimate is only an ordering/likely-slot
hint for fields the live scan can't place.

## Coverage

| metric | value |
|---|---|
| target entries | 4282 |
| distinct target classes | 3543 |
| target VAs resolved in `precise_dump.json` | 3543 / 3543 (100%) |
| **classes with resolved field types** | **2703 / 3543 = 76.29%** |
| classes without resolved types | 840 — all have **0 declared instance fields** (DTO/static-only); no field info is lost |
| total instance fields across targets | 7616 |
| **fields with a resolved static type** | **7616 / 7616 = 100%** |

Field-level coverage is 100% because every field that exists belongs to a class
that joined; the 840 "missing" classes simply have no instance fields to type.

### Sampling-class breakdown (7616 fields)

| class | count |
|---|---|
| VALUE  | 3864 |
| SKIP   | 2989 |
| STRING |  398 |
| OBJECT |  365 |

## Best initial sampling candidates — richest STRING-field profiles

String fields are the strongest identity leak (JSON keys, ids, URLs, names), so
these are the first classes to point the sampler at:

| string fields / total | class |
|---|---|
| 38 / 38 | `Record38f_1304` |
| 15 / 16 | `Record16f_370F` |
|  9 /  9 | `Record9f_5498` |
|  8 /  8 | `Record8f_7E17` |
|  7 /  7 | `Record7f_BB52` |
|  6 /  6 | `Record6f_F39B` |
|  6 /  6 | `Record6f_4F0D` |
|  5 / 18 | `BaseClass45Impl_2367` |
|  5 /  9 | `UIk__BackingFieldSibling_FEFB` |
|  5 /  5 | `Record5f_E784` |
|  4 /  4 | `Record4f_A568` |
|  3 /  4 | `Type20m4f_B8EC` |
|  3 /  4 | `Struct4f_B03F` |
|  3 /  4 | `BackingFieldBase_k__BackingField_55CF` |
|  3 /  3 | `Type14m3f_B4DA` |

The all-string `RecordNf_*` classes are pure string DTOs — sampling one live
instance of each yields N labelled string values directly, the highest-yield
starting set. The full ranked list (top 30) is in
`target_field_types.json → summary.top_string_rich_classes`.

## Reproduce

```
python tools/runtime_sampler/build_target_fieldtypes.py
```

Inputs: `output/p2_research/runtime_sample_targets.json`, `data/precise_dump.json`,
`data/precise_dump_unity6_typed.json`. Output: `output/p2_research/target_field_types.json`.
