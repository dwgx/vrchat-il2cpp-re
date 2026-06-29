# VRChat IL2CPP Deobfuscation Report

## Summary

| Metric | Count |
|--------|-------|
| Total obfuscated classes | 8121 |
| Semantically named | 4883 (60.1%) |
| Fallback-named (hash only) | 3238 |
| Methods renamed | 108040 |
| Fields renamed | 0 |

## Phase Breakdown

| Phase | Description | Count |
|-------|-------------|-------|
| P1: Async State Machines | 784 |
| P1: Delegates | 450 |
| P2: Known Method Semantics | 26 |
| P2: Semantic Word Analysis | 657 |
| P4: Unity Components | 892 |
| P5: Inheritance Base Classes | 46 |
| P5: Inheritance Children | 783 |
| P6: Known Parent Derivation | 41 |
| P6b: Shared Method Siblings | 864 |
| P6b: Method Frequency Clusters | 320 |
| P6c: Binary String References | 1930 |
| P7: Fallback Structural | 3238 |

## Notable Renames

Top renamed classes by method count:

| New Name | Methods | Original (truncated) |
|----------|---------|----------------------|
| `VRC_Main` | 962 | `ÌÌÎÏÍÏÌÎÌÌÍÏÌÌÎÌÏÌÎÏ...` |
| `Static625m_94DB` | 625 | `ÍÍÍÌÎÍÍÌÌÌÏÏÍÎÎÌÎÌÍÏ...` |
| `VRC_Secondary` | 497 | `ÍÌÍÌÏÏÏÏÍÎÎÍÍÎÏÎÍÏÍÏ...` |
| `VRC_MainSibling_FE14` | 351 | `ÏÍÏÌÎÌÌÌÎÎÎÍÍÌÍÏÍÌÌÎ...` |
| `MajorSystem_CC40` | 289 | `ÍÌÎÏÍÌÎÌÌÌÌÍÌÍÍÌÎÍÏÍ...` |
| `NetworkManager` | 267 | `ÏÏÌÍÏÌÍÌÏÎÍÏÌÌÍÌÍÌÍÎ...` |
| `VRCUiManager` | 261 | `ÎÌÏÍÏÍÎÌÏÌÍÌÍÏÏÎÌÎÌÍ...` |
| `VRCPlayer` | 253 | `ÎÏÎÍÍÏÍÌÌÍÌÍÏÍÌÎÌÍÎÌ...` |
| `AnimatedTextureBaseImpl_7236` | 232 | `ÍÍÏÎÏÏÏÎÏÎÎÌÏÍÏÎÎÎÎÌ...` |
| `VRC_MainSibling_4F73` | 195 | `ÍÏÌÎÍÍÎÍÍÎÌÍÌÍÎÌÍÏÎÍ...` |
| `VRCUiManagerSibling_4574` | 183 | `ÎÍÏÏÏÎÌÍÏÌÍÌÍÍÌÍÌÎÏÏ...` |
| `ComplexComponent_7A09` | 179 | `ÏÌÎÏÌÎÏÌÏÎÎÌÎÎÌÌÌÍÌÎ...` |
| `VRCUiManagerSiblingSibling_AD4E` | 161 | `ÌÌÏÏÌÌÌÌÎÎÏÍÎÌÍÌÎÍÎÍ...` |
| `ComplexComponent_01CC` | 157 | `ÏÍÌÌÏÌÍÌÎÏÍÏÎÎÌÌÍÎÌÌ...` |
| `AnimatedTextureBaseImplSibling_FBD6` | 153 | `ÎÎÎÏÎÎÏÎÎÍÏÌÌÎÏÌÎÌÌÌ...` |
| `Static152m_56E4` | 152 | `ÏÏÎÌÏÎÍÎÍÏÍÎÎÍÎÌÏÎÌÍ...` |
| `ComplexComponent_AD14` | 143 | `ÍÏÎÌÎÏÌÌÎÌÎÏÏÏÍÌÎÍÌÎ...` |
| `PlayerNet` | 142 | `ÎÍÎÍÍÎÍÎÎÌÏÌÍÍÎÎÌÏÍÏ...` |
| `VRC_MainSibling_B0C9` | 139 | `ÌÌÎÎÌÏÏÎÎÎÎÏÏÎÌÏÍÎÏÌ...` |
| `UdonOperationResponseDisconnectMessage_E3D6` | 138 | `ÎÌÌÏÍÏÍÌÏÌÌÍÎÌÍÎÍÎÌÏ...` |
| `ComplexComponent_C3CA` | 133 | `ÍÍÎÎÌÏÏÏÍÍÎÏÌÍÌÌÍÍÌÌ...` |
| `NetworkReadyHandler_CE56` | 128 | `ÍÎÏÎÎÍÏÌÎÌÌÏÍÍÍÏÌÎÏÏ...` |
| `ComplexComponent_D0A2` | 123 | `ÏÏÎÌÌÏÏÏÏÌÏÍÍÏÌÎÏÍÎÎ...` |
| `AnimatedTextureBaseImpl_C87D` | 122 | `ÌÍÏÍÏÍÍÍÎÌÌÍÌÎÏÌÎÏÏÏ...` |
| `UpdateComponentImpl_F5D9` | 119 | `ÎÎÎÍÍÏÌÍÏÏÌÌÎÎÌÎÍÎÎÍ...` |
| `UIDescriptionPurchase_88A1` | 117 | `ÎÎÍÎÏÎÍÌÎÌÎÌÎÌÎÏÎÍÌÎ...` |
| `NetworkSyncable_DBC8` | 114 | `ÍÌÎÍÏÌÎÌÏÏÎÌÎÏÌÎÍÌÌÏ...` |
| `ComplexComponent_9C28` | 111 | `ÌÎÎÍÎÍÌÍÌÏÌÌÌÌÌÎÌÏÌÌ...` |
| `ComplexComponent_AF1E` | 111 | `ÍÍÌÌÍÍÌÌÏÍÌÎÎÏÍÎÌÎÌÍ...` |
| `ComplexComponent_2748` | 111 | `ÎÎÌÍÎÎÎÌÎÎÎÏÏÎÌÏÌÌÌÏ...` |