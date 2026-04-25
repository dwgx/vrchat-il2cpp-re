// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Props
// Classes: 2
// Methods: 33

namespace VRC.SDK3.Props
{
    public class VRCPropApi : Object
    {
        public GetPropFromGameObjectDelegate _GetPropFromGameObject;
        public GetPropApiDelegate _GetPropApi; // 0x8

        // ── Methods ──
        public void TryGetPropFromGameObject(){} // RVA: 0x7FFACC002610
        public void TryGetProp(){} // RVA: 0x7FFACC0026D0
        public void GetPropId(){} // RVA: 0x7FFAC2C58E90
        public void GetItemId(){} // RVA: 0x7FFAC2C58E90
        public void GetSpawner(){} // RVA: 0x7FFAC2C58E90
        public void GetPosition(){} // RVA: 0x7FFAC2C588A0
        public void GetRotation(){} // RVA: 0x7FFAC2C588A0
        public void GetScale(){} // RVA: 0x7FFAC2C588A0
        public void GetNearestPlayerInRange(){}
        public void GetPlayersInRange(){} // overloaded x2
        public void GetUserAttributes(){} // RVA: 0x7FFAC2C58E90
        public void GetIsConsumable(){} // RVA: 0x7FFAC2C59D00
        public void GetQuantity(){} // RVA: 0x7FFAC2C59960
        public void RequestConsume(){} // RVA: 0x7FFAC2C59D00
        public void RequestDespawn(){} // RVA: 0x7FFAC2C59D00
        public void StartPlayingConsumableEffect(){} // RVA: 0x7FFAC2C70980
        public void StopPlayingConsumableEffect(){} // RVA: 0x7FFAC2C70980
        public void GetIsPlayingConsumableEffect(){} // RVA: 0x7FFAC2C59D00
        public void ManuallyRecordInteractionEvent(){} // RVA: 0x7FFAC2C70A40
        public void SetUserAttributes(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class VRCPropUtilities : Object
    {
        public VRC.Core.ApiUserPermissions _cachedPermissions;
        public bool _hasOngoingPermissionsFetchTask; // 0x8
        public Cysharp.Threading.Tasks.UniTask`1<VRC.Core.ApiUserPermissions> _ongoingPermissionsFetchTask; // 0x10
        public System.Threading.CancellationTokenSource _permissionsFetchCancellationSource; // 0x28

        // ── Methods ──
        public void DoesLocalPropFolderExist(){} // RVA: 0x7FFACBE56D70
        public void GetLocalPropFolderPath(){} // RVA: 0x7FFACBE56D90
        public void GetOrCreateLocalPropFolder(){} // RVA: 0x7FFACBE56E10
        public void GetCorrectionRotation(){} // RVA: 0x7FFACBE56E50
        public void DrawDebugBox(){} // RVA: 0x7FFACBE570A0
        public void FetchPermissionsAsync(){} // RVA: 0x7FFACBE58580
        public void ClearCachedPermissions(){} // RVA: 0x7FFACBE58A60
        public void ArePermissionsAvailable(){} // RVA: 0x7FFACBE58B90
        public void CanUseProps(){} // RVA: 0x7FFACBE58BD0
        public void CanUploadProps(){} // RVA: 0x7FFACBE58CB0
        public void CanTestProps(){} // RVA: 0x7FFACBE58D90
    }

}