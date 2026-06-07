// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Props
// Classes: 2
// Methods: 33

namespace VRC.SDK3.Props
{
    public class VRCPropApi
    {
        // ── Methods ──
        public void TryGetPropFromGameObject(){} // RVA: 0x9A0C490
        public void TryGetProp(){} // RVA: 0x9A0C550
        public void GetPropId(){} // RVA: 0xCD60
        public void GetItemId(){} // RVA: 0xCD60
        public void GetSpawner(){} // RVA: 0xCD60
        public void GetPosition(){} // RVA: 0xC770
        public void GetRotation(){} // RVA: 0xC770
        public void GetScale(){} // RVA: 0xC770
        public void GetNearestPlayerInRange(){}
        public void GetPlayersInRange(){} // overloaded x2
        public void GetUserAttributes(){} // RVA: 0xCD60
        public void GetIsConsumable(){} // RVA: 0xDBE0
        public void GetQuantity(){} // RVA: 0xD840
        public void RequestConsume(){} // RVA: 0xDBE0
        public void RequestDespawn(){} // RVA: 0xDBE0
        public void StartPlayingConsumableEffect(){} // RVA: 0x24A50
        public void StopPlayingConsumableEffect(){} // RVA: 0x24A50
        public void GetIsPlayingConsumableEffect(){} // RVA: 0xDBE0
        public void ManuallyRecordInteractionEvent(){} // RVA: 0x24B10
        public void SetUserAttributes(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class VRCPropUtilities
    {
        // ── Methods ──
        public void DoesLocalPropFolderExist(){} // RVA: 0x984E150
        public void GetLocalPropFolderPath(){} // RVA: 0x984E170
        public void GetOrCreateLocalPropFolder(){} // RVA: 0x984E1F0
        public void GetCorrectionRotation(){} // RVA: 0x984E230
        public void DrawDebugBox(){} // RVA: 0x984E480
        public void FetchPermissionsAsync(){} // RVA: 0x984F960
        public void ClearCachedPermissions(){} // RVA: 0x984FE40
        public void ArePermissionsAvailable(){} // RVA: 0x984FF70
        public void CanUseProps(){} // RVA: 0x984FFB0
        public void CanUploadProps(){} // RVA: 0x9850090
        public void CanTestProps(){} // RVA: 0x9850170
    }

}