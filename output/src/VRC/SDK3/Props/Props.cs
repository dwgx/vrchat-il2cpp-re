// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Props
// Classes: 2
// Methods: 32

namespace VRC.SDK3.Props
{
    public class VRCPropApi : Object
    {
        // ── Methods ──
        public void TryGetPropFromGameObject(){} // RVA: 0x7A8F5C040
        public void TryGetProp(){} // RVA: 0x7B184B1F0
        public void GetPropId(){} // RVA: 0x7A7E00680
        public void GetItemId(){} // RVA: 0x7A7E00680
        public void GetSpawner(){} // RVA: 0x7A7E00680
        public void GetPosition(){} // RVA: 0x7A7E00490
        public void GetRotation(){} // RVA: 0x7A7E00490
        public void GetScale(){} // RVA: 0x7A7E00490
        public void GetNearestPlayerInRange(){} // RVA: 0x7A7E14E80
        public void GetPlayersInRange(){} // RVA: 0x7A7E0D460
        public void GetUserAttributes(){} // RVA: 0x7A7E00680
        public void GetIsConsumable(){} // RVA: 0x7A7E01900
        public void GetQuantity(){} // RVA: 0x7A7E00710
        public void RequestConsume(){} // RVA: 0x7A7E01900
        public void RequestDespawn(){} // RVA: 0x7A7E01900
        public void StartPlayingConsumableEffect(){} // RVA: 0x7A7E18770
        public void StopPlayingConsumableEffect(){} // RVA: 0x7A7E18770
        public void GetIsPlayingConsumableEffect(){} // RVA: 0x7A7E01900
        public void ManuallyRecordInteractionEvent(){} // RVA: 0x7A7E18800
        public void SetUserAttributes(){} // RVA: 0x7A7E18800
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class VRCPropUtilities : Object
    {
        // ── Methods ──
        public void DoesLocalPropFolderExist(){} // RVA: 0x7B1688F00
        public void GetLocalPropFolderPath(){} // RVA: 0x7B1688F20
        public void GetOrCreateLocalPropFolder(){} // RVA: 0x7B1688FA0
        public void GetCorrectionRotation(){} // RVA: 0x7B1688FE0
        public void DrawDebugBox(){} // RVA: 0x7B1689230
        public void FetchPermissionsAsync(){} // RVA: 0x7B168A700
        public void ClearCachedPermissions(){} // RVA: 0x7B168ABE0
        public void ArePermissionsAvailable(){} // RVA: 0x7B168AD10
        public void CanUseProps(){} // RVA: 0x7B168AD50
        public void CanUploadProps(){} // RVA: 0x7B168AE30
        public void CanTestProps(){} // RVA: 0x7B168AF10
    }

}