// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Props
// Classes: 2
// Methods: 33

namespace VRC.SDK3.Props
{
    public class VRCPropApi
    {
        // ── Methods ──
        public void TryGetPropFromGameObject(){} // RVA: 0x7FFAFC4BC490
        public void TryGetProp(){} // RVA: 0x7FFAFC4BC550
        public void GetPropId(){} // RVA: 0x7FFAF2ABCD60
        public void GetItemId(){} // RVA: 0x7FFAF2ABCD60
        public void GetSpawner(){} // RVA: 0x7FFAF2ABCD60
        public void GetPosition(){} // RVA: 0x7FFAF2ABC770
        public void GetRotation(){} // RVA: 0x7FFAF2ABC770
        public void GetScale(){} // RVA: 0x7FFAF2ABC770
        public void GetNearestPlayerInRange(){}
        public void GetPlayersInRange(){} // overloaded x2
        public void GetUserAttributes(){} // RVA: 0x7FFAF2ABCD60
        public void GetIsConsumable(){} // RVA: 0x7FFAF2ABDBE0
        public void GetQuantity(){} // RVA: 0x7FFAF2ABD840
        public void RequestConsume(){} // RVA: 0x7FFAF2ABDBE0
        public void RequestDespawn(){} // RVA: 0x7FFAF2ABDBE0
        public void StartPlayingConsumableEffect(){} // RVA: 0x7FFAF2AD4A50
        public void StopPlayingConsumableEffect(){} // RVA: 0x7FFAF2AD4A50
        public void GetIsPlayingConsumableEffect(){} // RVA: 0x7FFAF2ABDBE0
        public void ManuallyRecordInteractionEvent(){} // RVA: 0x7FFAF2AD4B10
        public void SetUserAttributes(){} // RVA: 0x7FFAF2AD4B10
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class VRCPropUtilities
    {
        // ── Methods ──
        public void DoesLocalPropFolderExist(){} // RVA: 0x7FFAFC2FE150
        public void GetLocalPropFolderPath(){} // RVA: 0x7FFAFC2FE170
        public void GetOrCreateLocalPropFolder(){} // RVA: 0x7FFAFC2FE1F0
        public void GetCorrectionRotation(){} // RVA: 0x7FFAFC2FE230
        public void DrawDebugBox(){} // RVA: 0x7FFAFC2FE480
        public void FetchPermissionsAsync(){} // RVA: 0x7FFAFC2FF960
        public void ClearCachedPermissions(){} // RVA: 0x7FFAFC2FFE40
        public void ArePermissionsAvailable(){} // RVA: 0x7FFAFC2FFF70
        public void CanUseProps(){} // RVA: 0x7FFAFC2FFFB0
        public void CanUploadProps(){} // RVA: 0x7FFAFC300090
        public void CanTestProps(){} // RVA: 0x7FFAFC300170
    }

}