# VRChat IL2CPP Deobfuscation Report

## Summary

| Metric | Count |
|--------|-------|
| Total obfuscated classes | 8211 |
| Semantically named | 4781 (58.2%) |
| Fallback-named (hash only) | 3430 |
| Methods renamed | 109801 |
| Fields renamed | 0 |

## Phase Breakdown

| Phase | Description | Count |
|-------|-------------|-------|
| P1: Async State Machines | 789 |
| P1: Delegates | 450 |
| P2: Known Method Semantics | 26 |
| P2: Semantic Word Analysis | 654 |
| P4: Unity Components | 882 |
| P5: Inheritance Base Classes | 45 |
| P5: Inheritance Children | 801 |
| P6: Known Parent Derivation | 41 |
| P6b: Shared Method Siblings | 708 |
| P6b: Method Frequency Clusters | 365 |
| P6c: Binary String References | 1930 |
| P7: Fallback Structural | 3430 |

## Notable Renames

Top renamed classes by method count:

| New Name | Methods | Original (truncated) |
|----------|---------|----------------------|
| `VRC_Main` | 965 | `ÌÍÌÎÌÏÏÍÎÍÌÌÍÍÍÍÎÎÏÍ...` |
| `Static625m_5D5E` | 625 | `ÍÍÍÎÍÌÏÌÍÏÎÏÎÏÎÍÎÎÍÌ...` |
| `VRC_Secondary` | 498 | `ÍÏÌÏÍÌÎÍÌÍÎÏÌÏÍÎÌÎÌÎ...` |
| `VRC_MainSibling_98B4` | 355 | `ÌÎÎÎÌÍÌÎÌÍÎÏÌÏÏÎÌÍÎÎ...` |
| `MajorSystem_4634` | 291 | `ÌÍÍÏÎÍÌÏÏÌÌÌÍÏÍÌÎÏÎÏ...` |
| `NetworkManager` | 267 | `ÍÏÌÎÎÎÎÍÍÏÍÍÌÍÎÍÏÎÌÏ...` |
| `VRCUiManager` | 259 | `ÍÎÌÍÎÍÎÌÌÎÍÌÏÍÏÏÌÏÏÎ...` |
| `VRCPlayer` | 257 | `ÌÏÌÍÏÏÎÎÍÌÍÍÍÍÌÏÎÎÏÏ...` |
| `AnimatedTextureBaseImpl_62B6` | 241 | `ÎÌÍÌÍÍÌÏÍÏÌÎÌÌÎÍÏÏÍÍ...` |
| `VRC_MainSiblingSibling_9DC6` | 194 | `ÌÎÏÌÎÏÌÎÎÌÎÎÎÎÏÏÏÍÌÎ...` |
| `ComplexComponent_B588` | 182 | `ÏÌÌÌÎÍÌÍÎÌÎÏÎÌÎÏÎÍÎÏ...` |
| `VRCUiManagerSibling_FAA7` | 180 | `ÏÌÌÏÎÎÍÏÌÍÎÌÏÌÎÎÏÏÍÌ...` |
| `VRCUiManagerSiblingSibling_A721` | 160 | `ÍÎÍÏÌÍÍÎÌÏÎÏÍÌÏÏÍÎÍÏ...` |
| `ComplexComponent_031C` | 158 | `ÌÏÍÍÎÍÌÍÌÏÏÎÎÍÌÏÍÏÌÏ...` |
| `AnimatedTextureBaseImplSibling_3C51` | 155 | `ÍÍÎÍÌÌÎÏÍÍÏÎÏÎÌÍÍÌÌÌ...` |
| `Static153m_7407` | 153 | `ÍÍÎÏÏÎÍÏÌÌÏÍÍÏÍÏÍÎÍÎ...` |
| `ComplexComponent_65C4` | 146 | `ÏÌÏÍÏÍÍÍÎÏÎÏÌÌÏÎÌÌÌÎ...` |
| `PlayerNet` | 142 | `ÌÏÏÎÍÌÏÏÌÏÎÏÍÍÌÏÎÌÏÍ...` |
| `VRC_MainSibling_F8DA` | 139 | `ÎÎÏÌÎÏÏÎÎÌÏÌÏÏÌÌÎÎÌÎ...` |
| `UdonOperationResponseDisconnectMessage_1EC0` | 138 | `ÍÏÎÍÌÌÌÍÎÏÎÏÍÏÏÏÎÏÍÌ...` |
| `ComplexComponent_F1B2` | 132 | `ÌÏÍÏÍÍÌÍÎÎÍÎÍÏÏÍÎÌÌÎ...` |
| `AnimatedTextureBaseImpl_E1A7` | 127 | `ÌÌÍÌÍÏÌÍÎÏÏÌÏÍÌÏÏÎÍÌ...` |
| `NetworkReadyHandler_E98B` | 126 | `ÏÌÏÏÏÌÎÍÌÎÏÎÎÏÍÌÏÎÏÏ...` |
| `ComplexComponent_D3AA` | 122 | `ÎÏÏÎÌÍÌÎÏÌÌÎÍÏÎÏÎÍÏÌ...` |
| `UpdateComponentImpl_28FF` | 119 | `ÏÎÏÎÍÏÎÍÌÏÍÎÍÌÏÏÌÍÍÍ...` |
| `UIDescriptionPurchase_4413` | 117 | `ÏÏÏÏÏÏÍÎÎÏÍÏÏÎÏÍÌÍÎÎ...` |
| `NetworkSyncable_F480` | 116 | `ÍÎÍÎÌÌÌÍÏÏÌÎÎÌÌÍÎÌÍÎ...` |
| `ComplexComponent_38C8` | 114 | `ÌÏÏÍÍÎÍÏÏÎÍÎÍÏÎÌÏÏÏÎ...` |
| `PlayerRectTransformDimensionsChCalculateLayout_BB74` | 113 | `ÍÏÎÌÍÌÏÏÎÌÍÌÍÎÌÍÏÍÏÎ...` |
| `ComplexComponent_FE47` | 111 | `ÏÏÍÍÏÏÏÏÍÎÏÏÌÎÌÎÍÍÎÍ...` |