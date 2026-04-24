# VRChat IL2CPP Deobfuscation Report

## Summary

| Metric | Count |
|--------|-------|
| Total obfuscated classes | 5501 |
| Semantically named | 3391 (61.6%) |
| Fallback-named (hash only) | 2110 |
| Methods renamed | 77006 |
| Fields renamed | 9408 |

## Phase Breakdown

| Phase | Description | Count |
|-------|-------------|-------|
| P1: Async State Machines | 643 |
| P1: Enumerators | 359 |
| P1: Delegates | 45 |
| P2: Known Method Semantics | 26 |
| P2: Semantic Word Analysis | 277 |
| P4: Unity Components | 891 |
| P5: Inheritance Base Classes | 32 |
| P5: Inheritance Children | 535 |
| P6: Known Parent Derivation | 33 |
| P6b: Shared Method Siblings | 502 |
| P6b: Method Frequency Clusters | 28 |
| P6c: Binary String References | 1987 |
| P7: Fallback Structural | 2110 |

## Notable Renames

Top renamed classes by method count:

| New Name | Methods | Original (truncated) |
|----------|---------|----------------------|
| `VRC_Main` | 964 | `ÎÏÍÎÏÎÎÍÍÏÌÍÏÌÍÌÌÏÏÌ...` |
| `NetworkItemSiblingSibling_AAE2` | 942 | `ÌÌÌÏÎÎÍÌÍÏÎÎÍÎÌÎÎÏÏÎ...` |
| `VRC_Secondary` | 497 | `ÎÎÍÎÏÏÌÏÎÎÌÍÏÌÎÎÍÌÍÌ...` |
| `VRC_MainSibling_9171` | 350 | `ÌÍÌÎÍÍÎÏÌÎÍÎÌÍÎÌÏÌÏÍ...` |
| `MajorSystem_13C5` | 293 | `ÎÎÌÎÍÏÍÌÍÌÌÍÌÍÏÎÎÌÍÎ...` |
| `VRCUiManager` | 271 | `ÎÍÍÏÎÏÍÍÌÌÌÎÎÌÎÏÎÌÍÏ...` |
| `NetworkManager` | 263 | `ÏÏÏÎÍÏÎÏÍÎÎÌÏÍÎÍÍÍÎÍ...` |
| `VRCPlayer` | 251 | `ÏÏÍÎÍÍÎÌÍÍÍÍÎÌÏÎÍÎÎÏ...` |
| `AnimatedTextureBaseImpl_0682` | 230 | `ÍÍÌÎÏÎÏÌÏÌÎÏÌÍÎÌÌÏÍÌ...` |
| `VRC_MainSiblingSibling_D4AF` | 190 | `ÎÍÏÏÏÏÎÎÍÎÍÌÏÏÌÎÏÌÏÏ...` |
| `VRCUiManagerSibling_0842` | 189 | `ÌÎÌÌÏÎÌÏÍÍÏÌÍÎÌÌÎÎÍÏ...` |
| `ComplexComponent_29A6` | 182 | `ÌÏÎÏÌÌÎÌÏÎÍÍÏÌÏÍÍÏÍÏ...` |
| `VRCUiManagerSiblingSibling_39B9` | 167 | `ÎÎÎÎÍÍÌÏÍÎÍÏÏÍÍÎÌÌÌÎ...` |
| `ComplexComponent_6FD4` | 148 | `ÏÍÍÎÏÏÌÎÌÍÏÏÍÌÌÏÌÏÌÍ...` |
| `AnimatedTextureBaseImplSibling_BF67` | 148 | `ÍÎÏÎÌÌÌÎÍÏÎÌÏÎÍÏÌÏÏÌ...` |
| `Major148m_82E5` | 148 | `ÎÎÎÌÌÏÏÎÏÎÍÏÏÏÌÍÌÍÎÍ...` |
| `PlayerNet` | 146 | `ÌÍÌÌÍÌÍÍÍÍÌÍÏÌÏÎÌÎÍÎ...` |
| `ComplexComponent_8C61` | 143 | `ÌÎÏÎÏÎÍÌÍÌÎÌÎÎÍÍÌÌÌÎ...` |
| `UdonOperationResponseDisconnectMessage_331A` | 139 | `ÏÌÌÎÍÏÏÍÎÍÌÌÏÏÏÏÎÎÌÏ...` |
| `VRC_MainSibling_0495` | 138 | `ÍÏÏÌÏÍÍÍÌÌÌÏÏÌÎÍÏÎÍÎ...` |
| `ComplexComponent_AFA2` | 129 | `ÌÍÍÌÎÌÍÍÏÏÎÌÍÌÍÎÏÌÏÎ...` |
| `ComplexComponent_7316` | 128 | `ÌÍÎÎÍÎÌÌÍÎÌÌÍÏÎÎÍÍÍÏ...` |
| `NetworkReadyHandler_44F3` | 127 | `ÎÍÏÎÎÌÏÏÎÏÍÌÌÍÎÌÍÍÍÎ...` |
| `ComplexComponent_7679` | 122 | `ÍÎÍÌÏÏÌÌÌÍÌÍÏÎÍÌÎÍÍÌ...` |
| `AnimatedTextureBaseImpl_937F` | 120 | `ÌÌÎÎÏÍÍÌÎÍÌÍÎÏÏÏÏÎÍÏ...` |
| `NetworkSyncable_8636` | 119 | `ÍÌÌÍÎÌÎÍÌÎÌÍÎÎÌÌÌÏÎÌ...` |
| `UpdateComponentImpl_7FD0` | 119 | `ÍÍÏÎÎÌÌÍÏÏÌÎÌÌÍÏÏÎÍÍ...` |
| `UIDescriptionPurchase_5BDD` | 117 | `ÏÎÏÎÏÎÏÌÌÎÏÌÍÌÎÌÏÌÌÍ...` |
| `ComplexComponent_0B13` | 116 | `ÏÏÏÌÌÍÎÌÍÏÏÎÎÍÌÌÍÏÎÌ...` |
| `ComplexComponent_5D5C` | 115 | `ÌÌÎÍÍÌÌÍÏÍÍÍÏÌÍÍÎÍÍÎ...` |