# VRChat IL2CPP Deobfuscation Report

## Summary

| Metric | Count |
|--------|-------|
| Total obfuscated classes | 8431 |
| Semantically named | 5445 (64.6%) |
| Fallback-named (hash only) | 2986 |
| Methods renamed | 108480 |
| Fields renamed | 332 |

## Phase Breakdown

| Phase | Description | Count |
|-------|-------------|-------|
| P1: Async State Machines | 777 |
| P1: Enumerators | 4 |
| P2: Known Method Semantics | 19 |
| P2: Semantic Word Analysis | 1030 |
| P5: Inheritance Base Classes | 3 |
| P5: Inheritance Children | 2 |
| P6: Known Parent Derivation | 21 |
| P6b: Shared Method Siblings | 2102 |
| P6b: Method Frequency Clusters | 514 |
| P6c: Binary String References | 758 |
| P7: Fallback Structural | 2986 |

## Notable Renames

Top renamed classes by method count:

| New Name | Methods | Original (truncated) |
|----------|---------|----------------------|
| `VRC_Main_F4CB` | 963 | `ÌÏÌÍÏÏÏÌÍÏÎÏÍÏÏÏÎÏÌÌ...` |
| `VRCNetworkBehaviourSibling_BF5Sibling_C533` | 942 | `ÌÎÏÎÎÍÎÎÎÍÌÌÏÏÎÍÏÏÎÎ...` |
| `TransformPhysicsSystem_923C` | 625 | `ÏÎÏÏÌÌÏÏÌÌÍÏÌÌÍÍÎÎÎÏ...` |
| `VRC_Secondary_8E5E` | 499 | `ÍÏÎÏÍÌÏÍÏÌÎÌÍÍÍÍÍÍÌÍ...` |
| `VRC_MainSibling_E81F` | 351 | `ÏÏÍÏÏÌÏÌÍÏÎÍÌÍÏÍÌÌÌÌ...` |
| `ExceptionInt16OverflowComponent_B2EE` | 300 | `ÌÎÏÏÍÎÍÌÏÍÌÏÎÏÍÌÍÍÌÌ...` |
| `ctorDerivedSiblingSibling_2E7B` | 274 | `ÍÏÌÌÌÏÎÎÏÍÌÏÎÌÎÍÍÏÌÎ...` |
| `NetworkManager_216D` | 268 | `ÏÎÍÏÏÍÏÏÍÏÎÌÏÌÏÎÍÎÎÌ...` |
| `VRCPlayer_F618` | 258 | `ÌÎÌÍÌÎÏÏÎÍÌÍÌÏÌÌÌÏÌÌ...` |
| `AnimatedTextureBaseImpl_0682_3A0F` | 232 | `ÍÌÍÎÎÍÏÎÏÌÎÌÌÎÏÍÍÏÎÏ...` |
| `VRC_MainSibling_035C` | 195 | `ÎÍÎÌÎÏÏÏÎÍÏÎÌÍÍÎÎÍÌÎ...` |
| `ctorDerivedSibling_0676` | 194 | `ÌÌÌÌÍÌÌÎÌÏÍÏÌÏÌÏÏÎÏÏ...` |
| `PointerCoroutinePhotonComponent_6DBE` | 185 | `ÌÍÍÌÌÎÎÏÎÏÍÍÍÍÏÌÍÌÍÍ...` |
| `ctorDerivedSiblingSibling_4929` | 170 | `ÌÏÏÎÌÌÎÎÏÏÍÌÎÏÏÌÍÍÎÌ...` |
| `VRC_SecondarySiblingRelated_6465` | 157 | `ÌÌÏÌÏÍÍÌÏÌÎÎÎÎÎÍÎÌÌÎ...` |
| `TransformProfiledSystem_5268` | 154 | `ÏÏÌÎÍÍÍÍÏÌÍÌÍÌÏÌÏÌÍÎ...` |
| `AnimatedTextureBaseImpl_0682Sibling_AEEA` | 153 | `ÍÌÏÍÍÎÍÏÍÍÍÍÌÎÍÎÍÌÎÌ...` |
| `PlayerNet_7B7C` | 144 | `ÎÍÏÎÍÍÏÌÏÎÏÏÎÍÎÎÏÌÏÍ...` |
| `TransformIKMovementComponent_9CB4` | 143 | `ÌÍÌÍÌÏÌÌÏÎÎÏÎÏÌÌÏÌÌÎ...` |
| `UdonOperationResponseDisconnectMessage_331A_E89F` | 141 | `ÎÎÌÏÎÏÏÎÍÎÏÍÎÎÎÍÎÏÏÌ...` |
| `VRC_MainSibling_C23A` | 141 | `ÌÎÎÏÏÎÏÍÎÌÎÍÍÎÎÌÍÌÏÌ...` |
| `currentAvatarThumbnailImacurrentAvatarIm_EC02` | 133 | `ÍÎÌÍÏÎÎÎÍÏÌÎÍÏÌÎÎÏÎÍ...` |
| `NetworkReadyHandler_50BA` | 130 | `ÏÎÌÌÌÌÏÌÍÎÌÌÏÎÍÎÍÏÎÌ...` |
| `Static123m_9C6F` | 123 | `ÌÎÎÌÎÍÌÏÏÏÍÍÎÎÍÎÎÌÏÍ...` |
| `AnimatedTextureBaseImpl_0682SiSibling_F5E1` | 122 | `ÏÍÎÍÎÏÍÏÌÏÎÏÏÎÌÌÏÍÎÎ...` |
| `PlayerNet` | 120 | `ÎÎÏÍÏÏÏÍÎÌÍÎÍÏÎÍÏÍÎÌ...` |
| `UserConnectionApplyComponent_D0E4` | 120 | `ÍÌÎÎÌÍÌÎÍÌÏÌÏÏÌÍÍÌÌÌ...` |
| `UIDescriptionPurchase_F7C6` | 119 | `ÏÎÍÌÎÏÍÌÏÏÎÍÍÏÏÎÍÎÌÎ...` |
| `AvatarPickupUseDownPickup_640ASibling_74B7` | 116 | `ÌÎÌÍÌÎÌÎÎÌÎÏÏÎÌÎÏÎÏÌ...` |
| `UICompareDispose_241D_E151` | 114 | `ÏÏÌÏÎÏÌÍÌÍÌÍÏÎÌÌÏÎÎÍ...` |