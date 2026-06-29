# VRChat IL2CPP Deobfuscation Report

## Summary

| Metric | Count |
|--------|-------|
| Total obfuscated classes | 8211 |
| Semantically named | 4784 (58.3%) |
| Fallback-named (hash only) | 3427 |
| Methods renamed | 109621 |
| Fields renamed | 52925 |

## Phase Breakdown

| Phase | Description | Count |
|-------|-------------|-------|
| P1: Async State Machines | 789 |
| P1: Delegates | 450 |
| P2: Known Method Semantics | 26 |
| P2: Semantic Word Analysis | 1353 |
| P4: Unity Components | 359 |
| P5: Inheritance Base Classes | 42 |
| P5: Inheritance Children | 661 |
| P6: Known Parent Derivation | 40 |
| P6b: Shared Method Siblings | 684 |
| P6b: Method Frequency Clusters | 360 |
| P6c: Binary String References | 1930 |
| P7: Fallback Structural | 3427 |

## Notable Renames

Top renamed classes by method count:

| New Name | Methods | Original (truncated) |
|----------|---------|----------------------|
| `VRC_Main` | 965 | `ÌÍÌÎÌÏÏÍÎÍÌÌÍÍÍÍÎÎÏÍ...` |
| `Static625m_5D5E` | 625 | `ÍÍÍÎÍÌÏÌÍÏÎÏÎÏÎÍÎÎÍÌ...` |
| `VRC_Secondary` | 498 | `ÍÏÌÏÍÌÎÍÌÍÎÏÌÏÍÎÌÎÌÎ...` |
| `VRC_MainSibling_98B4` | 355 | `ÌÎÎÎÌÍÌÎÌÍÎÏÌÏÏÎÌÍÎÎ...` |
| `k__BackingFieldComponent_4634` | 291 | `ÌÍÍÏÎÍÌÏÏÌÌÌÍÏÍÌÎÏÎÏ...` |
| `NetworkManager` | 267 | `ÍÏÌÎÎÎÎÍÍÏÍÍÌÍÎÍÏÎÌÏ...` |
| `VRCUiManager` | 259 | `ÍÎÌÍÎÍÎÌÌÎÍÌÏÍÏÏÌÏÏÎ...` |
| `VRCPlayer` | 257 | `ÌÏÌÍÏÏÎÎÍÌÍÍÍÍÌÏÎÎÏÏ...` |
| `BackingFieldBase_k__BackingField_62B6` | 241 | `ÎÌÍÌÍÍÌÏÍÏÌÎÌÌÎÍÏÏÍÍ...` |
| `VRC_MainSibling_9DC6` | 194 | `ÌÎÏÌÎÏÌÎÎÌÎÎÎÎÏÏÏÍÌÎ...` |
| `PhysicsraycastCollideruiShapeComponent_B588` | 182 | `ÏÌÌÌÎÍÌÍÎÌÎÏÎÌÎÏÎÍÎÏ...` |
| `VRCUiManagerSibling_FAA7` | 180 | `ÏÌÌÏÎÎÍÏÌÍÎÌÏÌÎÎÏÏÍÌ...` |
| `VRCUiManagerSiblingSibling_A721` | 160 | `ÍÎÍÏÌÍÍÎÌÏÎÏÍÌÏÏÍÎÍÏ...` |
| `k__BackingFieldComponent_031C` | 158 | `ÌÏÍÍÎÍÌÍÌÏÏÎÎÍÌÏÍÏÌÏ...` |
| `BackingFieldBase_k__BackingFieSibling_3C51` | 155 | `ÍÍÎÍÌÌÎÏÍÍÏÎÏÎÌÍÍÌÌÌ...` |
| `Major153m_7407` | 153 | `ÍÍÎÏÏÎÍÏÌÌÏÍÍÏÍÏÍÎÍÎ...` |
| `k__BackingFieldComponent_65C4` | 146 | `ÏÌÏÍÏÍÍÍÎÏÎÏÌÌÏÎÌÌÌÎ...` |
| `PlayerNet` | 142 | `ÌÏÏÎÍÌÏÏÌÏÎÏÍÍÌÏÎÌÏÍ...` |
| `VRC_MainSibling_F8DA` | 139 | `ÎÎÏÌÎÏÏÎÎÌÏÌÏÏÌÌÎÎÌÎ...` |
| `Udonk__BackingField_1EC0` | 138 | `ÍÏÎÍÌÌÌÍÎÏÎÏÍÏÏÏÎÏÍÌ...` |
| `k__BackingFieldComponent_F1B2` | 132 | `ÌÏÍÏÍÍÌÍÎÎÍÎÍÏÏÍÎÌÌÎ...` |
| `BackingFieldBaseImpl_E1A7` | 127 | `ÌÌÍÌÍÏÌÍÎÏÏÌÏÍÌÏÏÎÍÌ...` |
| `NetworkReadyHandler_E98B` | 126 | `ÏÌÏÏÏÌÎÍÌÎÏÎÎÏÍÌÏÎÏÏ...` |
| `ComplexComponent_D3AA` | 122 | `ÎÏÏÎÌÍÌÎÏÌÌÎÍÏÎÏÎÍÏÌ...` |
| `k__BackingField_28FF` | 119 | `ÏÎÏÎÍÏÎÍÌÏÍÎÍÌÏÏÌÍÍÍ...` |
| `UIk__BackingField_4413` | 117 | `ÏÏÏÏÏÏÍÎÎÏÍÏÏÎÏÍÌÍÎÎ...` |
| `NetworkSyncable_F480` | 116 | `ÍÎÍÎÌÌÌÍÏÏÌÎÎÌÌÍÎÌÍÎ...` |
| `UIk__BackingFieldComponent_38C8` | 114 | `ÌÏÏÍÍÎÍÏÏÎÍÎÍÏÎÌÏÏÏÎ...` |
| `PlayerRectTransformDimensionsChCalculateLayout_BB74` | 113 | `ÍÏÎÌÍÌÏÏÎÌÍÌÍÎÌÍÏÍÏÎ...` |
| `Camerak__BackingFieldComponent_FE47` | 111 | `ÏÏÍÍÏÏÏÏÍÎÏÏÌÎÌÎÍÍÎÍ...` |