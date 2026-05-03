# VRChat IL2CPP Deobfuscation Report

## Summary

| Metric | Count |
|--------|-------|
| Total obfuscated classes | 8183 |
| Semantically named | 5131 (62.7%) |
| Fallback-named (hash only) | 3052 |
| Methods renamed | 103055 |
| Fields renamed | 16492 |

## Phase Breakdown

| Phase | Description | Count |
|-------|-------------|-------|
| P1: Async State Machines | 743 |
| P1: Delegates | 450 |
| P2: Known Method Semantics | 26 |
| P2: Semantic Word Analysis | 862 |
| P4: Unity Components | 740 |
| P5: Inheritance Base Classes | 42 |
| P5: Inheritance Children | 660 |
| P6: Known Parent Derivation | 39 |
| P6b: Shared Method Siblings | 1090 |
| P6b: Method Frequency Clusters | 459 |
| P7: Fallback Structural | 3052 |

## Notable Renames

Top renamed classes by method count:

| New Name | Methods | Original (truncated) |
|----------|---------|----------------------|
| `VRC_Main` | 961 | `ÎÌÍÌÌÍÎÎÎÎÏÍÎÏÌÍÏÍÏÌ...` |
| `UpdateComponentSibling_91E4` | 942 | `ÍÍÌÎÍÏÎÍÍÍÍÌÎÏÎÎÏÌÍÎ...` |
| `Static625m_1581` | 625 | `ÎÏÌÍÌÎÍÌÏÌÌÎÌÌÎÌÌÏÏÍ...` |
| `VRC_Secondary` | 500 | `ÎÌÎÍÎÎÏÌÏÏÏÍÏÍÍÏÍÎÏÍ...` |
| `VRC_MainSibling_F4F7` | 351 | `ÎÏÌÌÌÌÏÏÏÏÌÎÌÍÍÎÍÏÏÏ...` |
| `MajorSystem_F28F` | 300 | `ÎÍÎÏÌÎÎÎÏÎÌÎÍÎÎÎÎÎÏÎ...` |
| `VRCUiManager` | 272 | `ÍÎÏÏÍÌÎÏÏÏÍÌÍÎÌÏÌÏÍÌ...` |
| `NetworkManager` | 268 | `ÎÏÏÏÎÍÎÌÍÏÏÍÏÍÎÌÏÌÎÏ...` |
| `VRCPlayer` | 256 | `ÍÎÎÌÏÍÎÌÎÏÍÌÎÍÍÏÌÏÎÌ...` |
| `BackingFieldBase_k__BackingField_F22C` | 232 | `ÍÎÏÎÌÎÎÌÏÌÏÌÌÎÎÏÌÌÌÌ...` |
| `VRC_MainSibling_8CBB` | 195 | `ÎÎÏÏÍÏÎÏÌÏÏÏÌÎÎÎÏÏÌÌ...` |
| `VRCUiManagerSibling_A133` | 193 | `ÌÍÏÍÍÎÎÎÎÍÏÌÏÍÎÎÌÍÏÏ...` |
| `ComplexComponent_F979` | 184 | `ÏÌÏÍÏÏÏÏÎÍÌÎÍÌÌÌÌÏÎÎ...` |
| `VRCUiManagerSiblingSibling_A576` | 169 | `ÍÌÏÍÌÌÏÎÏÌÎÌÎÎÌÌÌÌÌÍ...` |
| `Major155m_077A` | 155 | `ÍÌÌÍÏÌÏÍÏÎÌÏÎÏÏÏÎÏÎÏ...` |
| `k__BackingFieldComponent_5BEE` | 151 | `ÎÍÏÍÏÍÏÍÍÌÍÎÌÍÍÍÏÍÏÍ...` |
| `BackingFieldBase_k__BackingFieSibling_79B2` | 151 | `ÎÍÏÍÏÎÌÏÌÎÏÍÎÎÏÏÌÌÎÍ...` |
| `NetworkSyncable_81C5` | 146 | `ÎÍÍÍÎÏÏÌÌÍÏÎÍÎÏÏÌÍÏÎ...` |
| `k__BackingFieldComponent_9F0E` | 143 | `ÎÌÍÎÏÌÍÍÎÍÏÍÌÌÏÍÌÏÎÏ...` |
| `Udonk__BackingField_7DFB` | 140 | `ÏÍÍÏÌÍÎÎÎÏÌÏÌÎÏÏÍÌÌÏ...` |
| `VRC_MainSibling_4E6F` | 139 | `ÎÍÌÍÍÍÎÎÎÌÍÌÌÎÍÌÎÌÎÎ...` |
| `NetworkReadyHandler_6729` | 127 | `ÍÎÍÌÌÎÎÍÏÍÏÍÍÎÎÍÎÎÏÍ...` |
| `k__BackingFieldComponent_4025` | 127 | `ÏÌÍÏÍÍÌÏÍÏÌÌÏÎÏÍÌÎÌÍ...` |
| `ComplexComponent_C7A9` | 123 | `ÎÌÎÏÏÌÎÌÌÏÏÍÍÍÍÎÌÎÎÌ...` |
| `BackingFieldBaseImpl_5C93` | 122 | `ÍÏÎÍÍÎÌÏÏÏÏÎÎÌÌÌÍÍÎÏ...` |
| `k__BackingField_D7B0` | 121 | `ÎÌÌÏÌÎÏÌÏÍÍÎÏÍÎÍÍÏÍÎ...` |
| `UIk__BackingField_CAB9` | 119 | `ÌÎÏÏÌÌÏÍÍÏÎÏÌÏÌÌÏÎÌÌ...` |
| `PlayerNet` | 118 | `ÌÌÍÎÌÎÍÏÏÍÍÎÌÎÏÏÌÎÍÍ...` |
| `ComplexComponent_844B` | 117 | `ÏÎÏÏÏÎÎÌÍÎÌÍÎÍÌÏÏÍÌÌ...` |
| `PlayerRectTransformDimensionsChCalculateLayout_C36B` | 113 | `ÎÍÍÏÍÌÏÍÌÏÎÎÏÏÍÌÍÌÎÏ...` |