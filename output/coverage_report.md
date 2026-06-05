# VRChat IL2CPP Deobfuscation Coverage Report

Generated: 2026-06-05 | Source dump: June 5 build

---

## Executive Summary

| Metric | Count | Coverage |
|--------|------:|----------|
| Total classes | 88,400 | - |
| Semantic class names | 83,873 | 94.9% |
| Fallback class names | 4,527 | 5.1% |
| Still obfuscated classes | 0 | 0.0% |
| Total methods | 528,135 | - |
| Semantic method names | 440,440 | 83.4% |
| Renamed methods | 87,695 | 16.6% of total |
| Total fields | 2,870 | - |
| Semantic field names | 2,712 | 94.5% |
| Renamed fields | 158 | 5.5% of total |

**Bottom line:** The June 5 pipeline covers 88,400 classes, 528,135 methods, and 2,870 fields. Class names are fully resolved to either semantic names or stable fallback names; 83,873 classes (94.9%) are semantic and 4,527 (5.1%) are structural/hash fallback names. No raw Beebyte class names remain in the final dump.

---

## Deobfuscation Effort Applied

| Resource | Count |
|----------|------:|
| Classes renamed from obfuscated input | 11,503 |
| -- Semantic renamed classes | 6,976 |
| -- Fallback renamed classes | 4,527 |
| Methods renamed | 87,695 |
| Fields renamed | 158 |
| **Total identifiers renamed** | **99,356** |

The final `deobfuscated_dump.json` metadata records 10,628 class renames, 90,743 method renames, and 331 field renames from the dump generation stage. The headline quality metrics above use `pipeline_coverage_report.md`, which is the current pipeline coverage summary for the June 5 build.

---

## Breakdown by Namespace Category

These counts are computed from `output/deobfuscated_dump.json`. The semantic/fallback split in this table is a final-name heuristic: raw obfuscated names are exact Beebyte-character matches; fallback names are structural/hash-looking names in the final output.

| Category | Classes | Semantic Classes | Fallback Classes | Methods | Semantic Methods | Fallback Methods | Fields | Semantic Fields | Fallback Fields |
|----------|--------:|-----------------:|-----------------:|--------:|-----------------:|-----------------:|-------:|----------------:|----------------:|
| Global (no namespace) | 28,184 | 14,165 | 14,019 | 177,109 | 89,640 | 87,469 | 996 | 838 | 158 |
| VRC.* | 2,959 | 2,949 | 10 | 57,946 | 57,739 | 207 | 169 | 169 | 0 |
| Third-party | 54,332 | 54,137 | 195 | 270,275 | 270,270 | 5 | 1,569 | 1,569 | 0 |
| Other | 2,925 | 2,908 | 17 | 22,805 | 22,791 | 14 | 136 | 136 | 0 |
| **Total** | **88,400** | **74,159** | **14,241** | **528,135** | **440,440** | **87,695** | **2,870** | **2,712** | **158** |

**Key insight:** The remaining fallback-looking names are concentrated in the global namespace. VRC.* namespaces are effectively semantic at the class level: 2,949 of 2,959 VRC.* classes have semantic final names by heuristic, and all VRC.* fields are named semantically.

---

## Pipeline Quality Metrics

| Metric | Count | Rate |
|--------|------:|-----:|
| Renamed obfuscated classes | 11,503 | 13.0% of all classes |
| Semantic renamed classes | 6,976 | 60.6% of renamed classes |
| Fallback renamed classes | 4,527 | 39.4% of renamed classes |
| Total semantic classes | 83,873 | 94.9% of all classes |
| Total semantic methods | 440,440 | 83.4% of all methods |
| Total semantic fields | 2,712 | 94.5% of all fields |
| Total semantic identifiers | 527,025 | 85.1% of all identifiers |

The class quality rate is high because most non-obfuscated framework and third-party classes already carry semantic names. The renamed-class semantic rate measures only classes that started from obfuscated names.

---

## VRC Namespace Coverage

| Namespace | Classes | Semantic Classes | Fallback Classes | Methods | Fallback Methods | Fields |
|-----------|--------:|-----------------:|-----------------:|--------:|-----------------:|-------:|
| VRC.Udon.Wrapper.Modules | 802 | 802 | 0 | 39,161 | 0 | 0 |
| VRC.Udon.Serialization.OdinSerializer | 397 | 394 | 3 | 2,667 | 0 | 6 |
| VRC.Core | 243 | 243 | 0 | 3,840 | 2 | 9 |
| VRC.Core.Networking.FlatBuffers.FlatBuffers32 | 225 | 222 | 3 | 2,025 | 0 | 61 |
| VRC.Core.Pool | 194 | 194 | 0 | 1,054 | 0 | 0 |
| VRC.Core.Networking.FlatBuffers.FlatBuffers8 | 184 | 184 | 0 | 1,629 | 0 | 49 |
| VRC.Dynamics | 89 | 89 | 0 | 911 | 0 | 11 |
| VRC.SDKBase | 78 | 78 | 0 | 662 | 0 | 0 |
| VRCSDK2 | 67 | 67 | 0 | 200 | 0 | 0 |
| VRC.Udon.Serialization.AOT | 53 | 53 | 0 | 53 | 0 | 0 |
| VRC.Udon.Serialization.OdinSerializer.Utilities | 53 | 50 | 3 | 492 | 0 | 0 |
| VRC.Core.Networking | 43 | 43 | 0 | 496 | 0 | 0 |
| VRC.SDK3.Components | 30 | 30 | 0 | 448 | 0 | 1 |
| VRC.Udon.Common.Interfaces | 29 | 29 | 0 | 154 | 0 | 0 |
| VRC.Core.Services | 19 | 19 | 0 | 73 | 0 | 0 |
| VRC.UI.Elements.Menus | 18 | 18 | 0 | 208 | 73 | 4 |
| VRC | 17 | 17 | 0 | 201 | 6 | 6 |
| VRC.SDK3.Avatars.Components | 16 | 16 | 0 | 79 | 0 | 0 |
| VRC.SDK3.Internal | 16 | 16 | 0 | 112 | 5 | 0 |
| VRC.Udon.Common | 16 | 16 | 0 | 104 | 0 | 0 |

Top VRC namespaces account for most of the VRC surface area. The largest remaining VRC fallback-method pocket is `VRC.UI.Elements.Menus` with 73 fallback-looking method names.

---

## Global Namespace Coverage

| Metric | Count | Coverage |
|--------|------:|---------:|
| Classes | 28,184 | - |
| Semantic classes | 14,165 | 50.3% |
| Fallback classes | 14,019 | 49.7% |
| Methods | 177,109 | - |
| Semantic methods | 89,640 | 50.6% |
| Fallback methods | 87,469 | 49.4% |
| Fields | 996 | - |
| Semantic fields | 838 | 84.1% |
| Fallback fields | 158 | 15.9% |

The global namespace is the primary remaining target. It contains compiler artifacts, lifted obfuscated classes, generated handlers, async state machines, and structural placeholders that do not have stable namespace context.

---

## Third-Party Coverage

| Metric | Count | Coverage |
|--------|------:|---------:|
| Classes | 54,332 | - |
| Semantic classes | 54,137 | 99.6% |
| Fallback classes | 195 | 0.4% |
| Methods | 270,275 | - |
| Semantic methods | 270,270 | ~100% |
| Fallback methods | 5 | ~0% |
| Fields | 1,569 | - |
| Semantic fields | 1,569 | 100% |

Third-party code dominates the class count because of framework, Unity, generic collection, async, serialization, and package types. It is almost entirely semantic in the final dump.

---

## Top Namespaces by Class Count

| Namespace | Classes | Methods | Fields |
|-----------|--------:|--------:|-------:|
| System.Collections.Generic | 29,972 | 118,928 | 41 |
| Global namespace | 28,184 | 177,109 | 996 |
| System | 6,762 | 13,275 | 85 |
| Cysharp.Threading.Tasks | 2,170 | 6,224 | 11 |
| UnityEngine.UIElements | 992 | 9,556 | 30 |
| System.Collections.ObjectModel | 914 | 753 | 0 |
| VRC.Udon.Wrapper.Modules | 802 | 39,161 | 0 |
| UnityEngine | 678 | 9,365 | 467 |
| System.Text.Json.Serialization | 541 | 7,432 | 0 |
| Cysharp.Threading.Tasks.CompilerServices | 535 | 4,887 | 2 |

---

## Fallback Name Patterns

Top fallback-looking class name patterns in the final dump:

| Pattern Prefix | Count |
|----------------|------:|
| Enumerator | 2,400 |
| VRCNetworkBehaviourSibling_BF5Sibling | 1,191 |
| AsyncStateMachine | 940 |
| CameraBeginInvokeEndInvoke | 570 |
| Static10m | 548 |
| Static8m | 507 |
| Derived | 486 |
| EmptyType | 450 |
| Static2m | 445 |
| NetworkItem_722FSiblingSiblingSibling | 398 |
| Static1m | 396 |
| PlayerMoveNext | 389 |
| Static9m | 389 |
| Static7m | 318 |
| BaseClass4Impl | 276 |

These are structural labels rather than raw obfuscation. They are stable and readable enough for navigation, but they do not always reveal the original product-level type identity.

---

## What We Know vs. What Remains

### Known

- 88,400 classes are represented in the final dump.
- 528,135 methods and 2,870 fields are represented in the final dump.
- No raw Beebyte class names remain.
- VRC.* classes are almost entirely semantic by final-name inspection.
- Third-party namespaces are effectively fully semantic.

### Remaining

- 4,527 renamed obfuscated classes are pipeline-classified as fallback names.
- 87,695 methods are renamed/fallback rather than pre-existing semantic names.
- 158 fields use fallback-style names.
- The global namespace contains the largest remaining semantic gap.

---

## Prioritized High-Value Targets

1. **Global namespace structural classes**: Resolve `AsyncStateMachine_*`, `Static*m_*`, `PlayerMoveNext_*`, and handler-style names using method bodies, strings, and call graph context.
2. **VRC.UI.Elements.Menus fallback methods**: This namespace has the largest VRC fallback-method cluster.
3. **VRCNetworkBehaviour sibling patterns**: These structural names likely represent network behaviour variants and generated relatives.
4. **Compiler artifact triage**: Separate genuinely useful product classes from generated enumerators and async state machines so coverage reports can distinguish product coverage from compiler noise.
5. **Cross-version lifting**: Continue propagating stable names from older dumps where structure and method signatures align.

---

## Appendix: Coverage Statistics

```
Total Identifiers in Dump:     619,405
  Classes:                      88,400
  Methods:                     528,135
  Fields:                        2,870

Pipeline Semantic Names:       527,025 (85.1%)
  Semantic classes:             83,873 (94.9%)
  Semantic methods:            440,440 (83.4%)
  Semantic fields:               2,712 (94.5%)

Pipeline Fallback/Renamed:      92,380 (14.9%)
  Fallback classes:              4,527 (5.1%)
  Renamed/fallback methods:     87,695 (16.6%)
  Renamed/fallback fields:         158 (5.5%)

Current Pipeline Report: output/pipeline_coverage_report.md
Current Full Dump:       output/deobfuscated_dump.json
```
