# Live Il2CppClass layout hypotheses (offline-derived)

Source: `output/p2_research/live_klass_raw_structs.json` (2000 structs, 0x200 bytes each, class name confirmed at +0x50).

## Hard limitation

The capture holds only the 0x200-byte klass struct, not the memory it points to. FieldInfo **stride** and the **sub-offsets** (field name ptr / field offset u32 / field type ptr) cannot be derived from this file; they must be read live by dereferencing the field_array_ptr below. Everything here is a ranked hypothesis.

## Top hypotheses

| member | best offset | confidence |
|---|---|---|
| field_count | 0x120 | high |
| field_array_ptr | 0x108 | high |
| method_count | None | low |
| method_array_ptr | 0x20 | low |

## Self-reference offsets (structural anchors)

Slots equal to the klass own address (element_class / cast_class family in IL2CPP):

| offset | self-ref frac |
|---|---|
| 0x68 | 98.6% |
| 0x170 | 30.0% |
| 0x190 | 25.4% |
| 0x130 | 19.3% |
| 0x180 | 16.5% |

## Clean count u16 slots and the pointers they gate

A real count is bounded (max <= 2000), varied, and a paired array pointer is present exactly when the count > 0.

| u16 off | score | max | distinct | mean(nz) | gated pointers |
|---|---|---|---|---|---|
| 0x120 | 0.775 | 285 | 24 | 52.7 | 0x108(corr=0.98), 0x118(corr=0.98), 0x150(corr=0.94), 0xf8(corr=0.93) |

## field_array_ptr candidates (best: 0x108)

| offset | corr | P(cnt>0 -> ptr) | P(cnt=0 -> null) |
|---|---|---|---|
| 0x108 | 0.981 | 0.984 | 0.969 |
| 0x118 | 0.976 | 0.987 | 0.938 |
| 0x150 | 0.939 | 0.935 | 0.953 |
| 0xf8 | 0.927 | 0.981 | 0.742 |

## method_array_ptr candidates (best: 0x20)

Always-present structural pointers not gated by field_count:

| offset | ptr presence |
|---|---|
| 0x20 | 0.995 |
| 0x78 | 0.991 |
| 0x80 | 0.990 |
| 0x90 | 0.984 |
| 0xa8 | 0.975 |
| 0xb8 | 0.978 |

## Sibling-pointer notes (fixed deltas)

- 0xf8 is -368 bytes from field_ptr in 1232/2000 classes (fixed delta -> adjacent member, not array bound)
- 0x118 is 368 bytes from field_ptr in 1281/2000 classes (fixed delta -> adjacent member, not array bound)

## Reasoning and confidence

- **field_count (0x120) -- HIGH**: the only bounded, varied u16 slot; it gates pointer(s) that appear exactly when it is > 0.
- **field_array_ptr (0x108) -- HIGH**: highest gating correlation with field_count.
- **method_count -- LOW**: no second clean count is isolable offline; neighbouring u16 slots overlap pointer bytes. Read live.
- **method_array_ptr (0x20) -- LOW**: best-guess always-present pointer; cannot be confirmed without a method_count to correlate.

## Next live step

Dereference field_array_ptr (+0x108) on a class with known fields, then scan the pointee for the FieldInfo stride and the name/offset/type sub-offsets.
