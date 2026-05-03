// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Props
// Classes: 2
// Methods: 33

namespace VRC.SDK3.Props
{
    public class VRCPropApi : Object
    {
        // ── Methods ──
        public void TryGetPropFromGameObject(){} // RVA: 0x7FFE8A467EC0
        public void TryGetProp(){} // RVA: 0x7FFE8A467F80
        public void GetPropId(){} // RVA: 0x7FFE80E2E2E0
        public void GetItemId(){} // RVA: 0x7FFE80E2E2E0
        public void GetSpawner(){} // RVA: 0x7FFE80E2E2E0
        public void GetPosition(){} // RVA: 0x7FFE80E2DCF0
        public void GetRotation(){} // RVA: 0x7FFE80E2DCF0
        public void GetScale(){} // RVA: 0x7FFE80E2DCF0
        public void GetNearestPlayerInRange(){}
        public void GetPlayersInRange(){} // overloaded x2
        public void GetUserAttributes(){} // RVA: 0x7FFE80E2E2E0
        public void GetIsConsumable(){} // RVA: 0x7FFE80E2F150
        public void GetQuantity(){} // RVA: 0x7FFE80E2EDB0
        public void RequestConsume(){} // RVA: 0x7FFE80E2F150
        public void RequestDespawn(){} // RVA: 0x7FFE80E2F150
        public void StartPlayingConsumableEffect(){} // RVA: 0x7FFE80E45FE0
        public void StopPlayingConsumableEffect(){} // RVA: 0x7FFE80E45FE0
        public void GetIsPlayingConsumableEffect(){} // RVA: 0x7FFE80E2F150
        public void ManuallyRecordInteractionEvent(){} // RVA: 0x7FFE80E460A0
        public void SetUserAttributes(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class VRCPropUtilities : Object
    {
        // ── Methods ──
        public void DoesLocalPropFolderExist(){} // RVA: 0x7FFE8A2B03F0
        public void GetLocalPropFolderPath(){} // RVA: 0x7FFE8A2B0410
        public void GetOrCreateLocalPropFolder(){} // RVA: 0x7FFE8A2B0490
        public void GetCorrectionRotation(){} // RVA: 0x7FFE8A2B04D0
        public void DrawDebugBox(){} // RVA: 0x7FFE8A2B0720
        public void FetchPermissionsAsync(){} // RVA: 0x7FFE8A2B1C00
        public void ClearCachedPermissions(){} // RVA: 0x7FFE8A2B20E0
        public void ArePermissionsAvailable(){} // RVA: 0x7FFE8A2B2210
        public void CanUseProps(){} // RVA: 0x7FFE8A2B2250
        public void CanUploadProps(){} // RVA: 0x7FFE8A2B2330
        public void CanTestProps(){} // RVA: 0x7FFE8A2B2410
    }

}