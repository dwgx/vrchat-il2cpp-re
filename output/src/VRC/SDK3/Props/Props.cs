// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Props
// Classes: 2
// Methods: 34

namespace VRC.SDK3.Props
{
    public class VRCPropApi : Object
    {
        public object _GetPropFromGameObject;
        public object _GetPropApi;

        // ── Methods ──
        public void TryGetPropFromGameObject(){} // RVA: 0x1AA30E0
        public void TryGetProp(){} // RVA: 0xA6B5CA0
        public void GetPropId(){} // RVA: 0x87C0A0
        public void GetItemId(){} // RVA: 0x87C0A0
        public void GetSpawner(){} // RVA: 0x87C0A0
        public void GetPosition(){} // RVA: 0x87BEB0
        public void GetRotation(){} // RVA: 0x87BEB0
        public void GetScale(){} // RVA: 0x87BEB0
        public void GetNearestPlayerInRange(){} // RVA: 0x8908B0
        public void GetPlayersInRange(){} // RVA: 0x888EC0
        public void GetUserAttributes(){} // RVA: 0x87C0A0
        public void GetIsConsumable(){} // RVA: 0x87D280
        public void GetQuantity(){} // RVA: 0x87C130
        public void RequestConsume(){} // RVA: 0x87D280
        public void RequestDespawn(){} // RVA: 0x87D280
        public void StartPlayingConsumableEffect(){} // RVA: 0x894290
        public void StopPlayingConsumableEffect(){} // RVA: 0x894290
        public void GetIsPlayingConsumableEffect(){} // RVA: 0x87D280
        public void ManuallyRecordInteractionEvent(){} // RVA: 0x894320
        public void SetUserAttributes(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0xB43310
    }

    public class VRCPropUtilities : Object
    {
        public object API_VISIBILITY_TYPE_EVERYONE;
        public object API_VISIBILITY_TYPE_ITEM_OWNER_ONLY;
        public object _cachedPermissions;
        public object _hasOngoingPermissionsFetchTask;
        public object _ongoingPermissionsFetchTask;
        public object _permissionsFetchCancellationSource;

        // ── Methods ──
        public void DoesLocalPropFolderExist(){} // RVA: 0xA4F4040
        public void GetLocalPropFolderPath(){} // RVA: 0xA4F4060
        public void GetOrCreateLocalPropFolder(){} // RVA: 0xA4F40E0
        public void GetCorrectionRotation(){} // RVA: 0xA4F4120
        public void DrawDebugBox(){} // RVA: 0xA4F4370
        public void ToApiValue(){} // RVA: 0xA4F5840
        public void GetVisibilityTypeFromApiValue(){} // RVA: 0xA4F5950
        public void FetchPermissionsAsync(){} // RVA: 0xA4F5A90
        public void ClearCachedPermissions(){} // RVA: 0xA4F5F70
        public void ArePermissionsAvailable(){} // RVA: 0xA4F60A0
        public void CanUseProps(){} // RVA: 0xA4F60E0
        public void CanUploadProps(){} // RVA: 0xA4F61C0
        public void CanTestProps(){} // RVA: 0xA4F62A0
    }

}