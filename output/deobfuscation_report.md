# VRChat IL2CPP Deobfuscation Report

## Summary

| Metric | Count |
|--------|-------|
| Total obfuscated classes | 7938 |
| Semantically named | 6752 (85.1%) |
| Fallback-named (hash only) | 1186 |
| Methods renamed | 100801 |
| Fields renamed | 12650 |

## Phase Breakdown

| Phase | Description | Count |
|-------|-------------|-------|
| P1: Async State Machines | 50 |
| P1: Enumerators | 84 |
| P1: Delegates | 426 |
| P2: Semantic Word Analysis | 20 |
| P4: Unity Components | 10 |
| P5: Inheritance Base Classes | 7 |
| P5: Inheritance Children | 150 |
| P6: Known Parent Derivation | 11 |
| P6b: Shared Method Siblings | 1331 |
| P6b: Method Frequency Clusters | 206 |
| P6c: Binary String References | 1987 |
| P7: Fallback Structural | 1186 |

## Notable Renames

Top renamed classes by method count:

| New Name | Methods | Original (truncated) |
|----------|---------|----------------------|
| `VRC_Main_B194` | 964 | `ÎÏÍÎÏÎÎÍÍÏÌÍÏÌÍÌÌÏÏÌ...` |
| `NetworkItemSibling_FEF9Sibling_AAE2` | 942 | `ÌÌÌÏÎÎÍÌÍÏÎÎÍÎÌÎÎÏÏÎ...` |
| `Static625m_1E86` | 625 | `ÏÏÏÎÏÎÏÎÏÌÏÎÎÏÍÌÌÎÍÏ...` |
| `VRC_Secondary_870C` | 497 | `ÎÎÍÎÏÏÌÏÎÎÌÍÏÌÎÎÍÌÍÌ...` |
| `VRC_MainSibling_9171` | 350 | `ÌÍÌÎÍÍÎÏÌÎÍÎÌÍÎÌÏÌÏÍ...` |
| `MajorSystem_13C5_13C5` | 293 | `ÎÎÌÎÍÏÍÌÍÌÌÍÌÍÏÎÎÌÍÎ...` |
| `VRCUiManager_C0CD` | 271 | `ÎÍÍÏÎÏÍÍÌÌÌÎÎÌÎÏÎÌÍÏ...` |
| `NetworkManager_97F8` | 263 | `ÏÏÏÎÍÏÎÏÍÎÎÌÏÍÎÍÍÍÎÍ...` |
| `VRCPlayer_3561` | 251 | `ÏÏÍÎÍÍÎÌÍÍÍÍÎÌÏÎÍÎÎÏ...` |
| `AnimatedTextureBaseImpl_0682_0682` | 230 | `ÍÍÌÎÏÎÏÌÏÌÎÏÌÍÎÌÌÏÍÌ...` |
| `VRC_MainSiblingSibling_D4AF_D4AF` | 190 | `ÎÍÏÏÏÏÎÎÍÎÍÌÏÏÌÎÏÌÏÏ...` |
| `VRCUiManagerSibling_0842_0842` | 189 | `ÌÎÌÌÏÎÌÏÍÍÏÌÍÎÌÌÎÎÍÏ...` |
| `ComplexComponent_29A6_29A6` | 182 | `ÌÏÎÏÌÌÎÌÏÎÍÍÏÌÏÍÍÏÍÏ...` |
| `VRCUiManagerSibling_0842Sibling_39B9` | 167 | `ÎÎÎÎÍÍÌÏÍÎÍÏÏÍÍÎÌÌÌÎ...` |
| `Major148m_82E5_82E5` | 148 | `ÎÎÎÌÌÏÏÎÏÎÍÏÏÏÌÍÌÍÎÍ...` |
| `ComplexComponent_6FD4_6FD4` | 148 | `ÏÍÍÎÏÏÌÎÌÍÏÏÍÌÌÏÌÏÌÍ...` |
| `AnimatedTextureBaseImpl_0682Sibling_BF67` | 148 | `ÍÎÏÎÌÌÌÎÍÏÎÌÏÎÍÏÌÏÏÌ...` |
| `PlayerNet_7F0A` | 146 | `ÌÍÌÌÍÌÍÍÍÍÌÍÏÌÏÎÌÎÍÎ...` |
| `ComplexComponent_8C61_8C61` | 143 | `ÌÎÏÎÏÎÍÌÍÌÎÌÎÎÍÍÌÌÌÎ...` |
| `UdonOperationResponseDisconnectMessage_331A_331A` | 139 | `ÏÌÌÎÍÏÏÍÎÍÌÌÏÏÏÏÎÎÌÏ...` |
| `VRC_MainSibling_0495_0495` | 138 | `ÍÏÏÌÏÍÍÍÌÌÌÏÏÌÎÍÏÎÍÎ...` |
| `ComplexComponent_AFA2_AFA2` | 129 | `ÌÍÍÌÎÌÍÍÏÏÎÌÍÌÍÎÏÌÏÎ...` |
| `ComplexComponent_7316_7316` | 128 | `ÌÍÎÎÍÎÌÌÍÎÌÌÍÏÎÎÍÍÍÏ...` |
| `NetworkReadyHandler_44F3_44F3` | 127 | `ÎÍÏÎÎÌÏÏÎÏÍÌÌÍÎÌÍÍÍÎ...` |
| `ComplexComponent_7679_7679` | 122 | `ÍÎÍÌÏÏÌÌÌÍÌÍÏÎÍÌÎÍÍÌ...` |
| `AnimatedTextureBaseImpl_937F_937F` | 120 | `ÌÌÎÎÏÍÍÌÎÍÌÍÎÏÏÏÏÎÍÏ...` |
| `NetworkSyncable_8636_8636` | 119 | `ÍÌÌÍÎÌÎÍÌÎÌÍÎÎÌÌÌÏÎÌ...` |
| `UpdateComponentImpl_7FD0_7FD0` | 119 | `ÍÍÏÎÎÌÌÍÏÏÌÎÌÌÍÏÏÎÍÍ...` |
| `UIDescriptionPurchase_5BDD_5BDD` | 117 | `ÏÎÏÎÏÎÏÌÌÎÏÌÍÌÎÌÏÌÌÍ...` |
| `ComplexComponent_0B13_0B13` | 116 | `ÏÏÏÌÌÍÎÌÍÏÏÎÎÍÌÌÍÏÎÌ...` |