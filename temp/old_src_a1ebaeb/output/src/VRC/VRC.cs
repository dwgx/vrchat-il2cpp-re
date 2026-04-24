// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC
// Classes: 13
// Methods: 181

namespace VRC
{
    public class AssetCache : Object
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaa89357c0
        public void CompareBaseObjects(){} // RVA: 0x7ffaaa06f3c0
        public void IsNativeObjectAlive(){} // RVA: 0x7ffaaa06f420
        public void get_name(){} // RVA: 0x7ffaaa06f1e0
        public void .ctor(){} // RVA: 0x7ffaaa06f8b0
        public void Instantiate(){} // RVA: 0x7ffaaa06fb50
        public void ToString(){} // RVA: 0x7ffaaa06f3c0
        public void CacheAssetInformation(){} // RVA: 0x7ffaaa06fc80
        public void RetrieveCachedAsset(){} // RVA: 0x7ffaaa06ffe0
        public void RetrieveCachedAssetValue(){} // RVA: 0x7ffaaa070340
        public void Initialize(){} // RVA: 0x7ffaaa070490
        // ── Binary Analysis Named ──
        public void GetInstanceID(){} // RVA: 0x7ffaaa06f1e0
        public void GetHashCode(){} // RVA: 0x7ffaaa06f240
        public void SetMessage(){} // RVA: 0x7ffaa8998e80
        public void GetCachedPtr(){} // RVA: 0x7ffaaa06f780
    }

    public class BackgroundOption : Object
    {
        public object _preview; // 0x33C7FA00

        // ── Original Methods ──
        public void get_hidden(){} // RVA: 0x7ffaa89e9d30
        public void get_IsLoaded(){} // RVA: 0x7ffaa9fe3440
        public void get_BackgroundName(){} // RVA: 0x7ffaa9241a40
        public void get_DisplayName(){} // RVA: 0x7ffaa9241a40
        public void CompareBaseObjects(){} // RVA: 0x7ffaa9241a40
        public void ComputeIsLoaded(){} // RVA: 0x7ffaa9fe3590
        public void get_Preview(){} // RVA: 0x7ffaa89af740
        public void get_IsVRCPlus(){} // RVA: 0x7ffaa89e9d30
        public void set_IsVRCPlus(){} // RVA: 0x7ffaa9241a40
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void Initialize(){} // RVA: 0x7ffaa9fe3640
        public void Instantiate(){} // RVA: 0x7ffaa9fe3710
        // ── Binary Analysis Named ──
        public void DoUnloadAsset(){} // RVA: 0x7ffaa9fe3510
        public void GetCachedPtr(){} // RVA: 0x7ffaa89e9d30
    }

    public class BackgroundOptions : ScriptableObject
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaa89357c0
        public void CreateInstance(){} // RVA: 0x7ffaa89357c0
        public void set_Options(){} // RVA: 0x7ffaa89357c0
        public void CreateScriptableObject(){} // RVA: 0x7ffaa89357c0
        public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7ffaa89357c0
        public void get_Options(){} // RVA: 0x7ffaa89357c0
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class ClientPlayerLoop : Object
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaaa016f40
        public void Initialize(){} // RVA: 0x7ffaaa017050
        public void CompareBaseObjects(){} // RVA: 0x7ffaaa0174d0
        // ── Binary Analysis Named ──
        public void GetInstanceID(){} // RVA: 0x7ffaaa016e30
        public void GetGameObject_D4D(){} // RVA: 0x7ffaaa017320
    }

    public class GiftDisplayReferences : ScriptableObject
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaa9ffb490
        public void CreateInstance(){} // RVA: 0x7ffaa9ffb550
        public void CreateScriptableObject(){} // RVA: 0x7ffaa9ffb5f0
        public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7ffaa9ffb690
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
        public void ToString(){} // RVA: 0x7ffaa9ffb690
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa9ffb550
        public void DoSlerp_Injected_0EE(){} // RVA: 0x7ffaa9ffb5f0
        public void DoSlerp_Injected_4C0(){} // RVA: 0x7ffaa9ffb490
        public void DoSlerp_Injected_D6B(){} // RVA: 0x7ffaa9ffb550
    }

    public class IMDraw : MonoBehaviour
    {
        public object sphere; // 0x33B04030
        public object Color; // 0x33B04030
        public object DEFAULT_LINE_WIDTH; // 0x33B04030
        public object DrawToMainCamera; // 0x33B04030
        public object  $00; // 0x4000004

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaaf87ce90
        public void OnDestroy(){} // RVA: 0x7ffaaf87d0b0
        public void OnDraw(){} // RVA: 0x7ffaaf87d2a0
        public void Draw(){} // RVA: 0x7ffaaf87d4d0
        public void Clear(){} // RVA: 0x7ffaaf87d5b0
        public void UpdateCommandBuffers(){} // RVA: 0x7ffaaf87d630
        public void BuildCommandBuffer(){} // RVA: 0x7ffaaf87d730
        public void Line2D(){} // RVA: 0x7ffaaf87d7d0
        public void Line3D(){} // RVA: 0x7ffaaf87da70
        public void Line3D(){} // RVA: 0x7ffaaf87da70
        public void Sphere(){} // RVA: 0x7ffaaf87dca0
        public void Sphere(){} // RVA: 0x7ffaaf87dca0
        public void Capsule(){} // RVA: 0x7ffaaf87dee0
        public void Capsule(){} // RVA: 0x7ffaaf87dee0
        public void Cone(){} // RVA: 0x7ffaaf87e0c0
        public void Cone(){} // RVA: 0x7ffaaf87e0c0
        public void WireSquare3D(){} // RVA: 0x7ffaaf87e220
        public void WireCube3D(){} // RVA: 0x7ffaaf87ed00
        public void WireCube3D(){} // RVA: 0x7ffaaf87ed00
        public void WireCircle3D(){} // RVA: 0x7ffaaf87f550
        public void WireArc3D(){} // RVA: 0x7ffaaf87fbf0
        public void .ctor(){} // RVA: 0x7ffaaf8802b0
    }

    public class InputLatencyTracker : Object
    {
        public object _inputLatencyTracker; // 0x33AE5E80, was: ÎÏÌÎÎÌÍÏÌÏÍÌÍÏÌÎÏÎÍÏÎÎÌ

        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaaa017530
        public void Equals(){} // RVA: 0x7ffaaa017700
        public void IsNativeObjectAlive(){} // RVA: 0x7ffaaa017ef0
        public void .cctor(){} // RVA: 0x7ffaaa017f90
        // ── Binary Analysis Named ──
        public void DoStop(){} // RVA: 0x7ffaaa0179c0
        public void DoInternal_Create_174(){} // RVA: 0x7ffaaa017be0
        public void DoGetKey_Injected_F61(){} // RVA: 0x7ffaaa017db0
    }

    public class PlayerLoopUtility : Object
    {
        // ── Original Methods ──
        public void AddNewSystem(){} // RVA: 0x7ffaa866b630
        public void RemoveExistingSystem(){} // RVA: 0x7ffab186b5f0
        public void MoveExistingSystem(){} // RVA: 0x7ffab186ba70
        // ── Binary Analysis Named ──
        public void GetLoopIndexByType(){} // RVA: 0x7ffab186c720
    }

    public class StickerCollectionPrefab : ScriptableObject
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class StickerPrefab : ScriptableObject
    {
        public object frames; // 0x336F6A80
        public object f_C78; // 0x336F6A80, was: <ÍÎÍÍÎÌÌÏÌÍÌÍÎÎÎÏÍÎÌÍÍÌÌ>k__Ba
        public object f_C7C; // 0x336F6A80, was: <ÎÍÎÌÏÍÌÎÍÏÌÎÍÎÍÌÏÎÎÏÍÍÏ>k__Ba
        public object ID; // 0x1700099B
        public object FileId; // 0x1700099C
        public object IsBuiltIn; // 0x1700099D

        // ── Original Methods ──
        public void set_LoopStyle(){} // RVA: 0x7ffaaa010cb0
        public void set_CollectionID(){} // RVA: 0x7ffaa895a200
        public void get_LoopStyle(){} // RVA: 0x7ffaa8bfcc80
        public void set_FullResolutionTexture(){} // RVA: 0x7ffaa8a8a4d0
        public void set_EffectBundleID(){} // RVA: 0x7ffaaa010cf0
        public void get_EffectBundleID(){} // RVA: 0x7ffaaa011030
        public void get_FileId(){} // RVA: 0x7ffaa8f22da0
        public void set_FileId(){} // RVA: 0x7ffaaa011070
        public void get_Frames(){} // RVA: 0x7ffaa9349010
        public void get_LinearLoop(){} // RVA: 0x7ffaaa0110c0
        public void get_CollectionID(){} // RVA: 0x7ffaa89af740
        public void get_ID(){} // RVA: 0x7ffaa8b680f0
        public void get_FullResolutionTexture(){} // RVA: 0x7ffaa89d30e0
        public void get_Sprite(){} // RVA: 0x7ffaa8bf45b0
        public void get_FPS(){} // RVA: 0x7ffaa8d14570
        public void set_element(){} // RVA: 0x7ffaa8bf45c0
        public void set_IsBuiltIn(){} // RVA: 0x7ffaaa011140
        public void get_IsBuiltIn(){} // RVA: 0x7ffaa8a17850
        public void get_IsSpecialFX(){} // RVA: 0x7ffaa8932320
        public void set_Sprite(){} // RVA: 0x7ffaa8bf45c0
        public void get_MaskTag(){} // RVA: 0x7ffaa8f22da0
        public void get_IsAnimated(){} // RVA: 0x7ffaa8a209d0
        public void set_IsAnimated(){} // RVA: 0x7ffaaa011190
        public void set_MaskTag(){} // RVA: 0x7ffaaa0114d0
        public void set_DisplayTexture(){} // RVA: 0x7ffaa89ad740
        public void Equals(){} // RVA: 0x7ffaa8bf45c0
        public void get_DisplayTexture(){} // RVA: 0x7ffaa89ad730
        public void .ctor(){} // RVA: 0x7ffaaa011670
        // ── Binary Analysis Named ──
        public void GetShapes(){} // RVA: 0x7ffaa8bf45b0
        public void GetPublicKey(){} // RVA: 0x7ffaa89ad730
    }

    public class SystemsPlayerLoop : Object
    {
        public object OnAvatarHeadChop; // 0x354EA050

        // ── Original Methods ──
        public void add_OnAvatarClone(){} // RVA: 0x7ffab186c990
        public void remove_OnAvatarClone(){} // RVA: 0x7ffab186caa0
        public void add_OnAvatarHeadChop(){} // RVA: 0x7ffab186cbb0
        public void remove_OnAvatarHeadChop(){} // RVA: 0x7ffab186ccc0
        public void Initialize(){} // RVA: 0x7ffab186cdd0
        public void FixConstraints(){} // RVA: 0x7ffab186ce80
        public void OnVRCConstraintsUpdate(){} // RVA: 0x7ffab186d5f0
        public void OnAvatarDynamicsPreSchedule(){} // RVA: 0x7ffab186d680
        public void OnAvatarDynamicsPostSchedule(){} // RVA: 0x7ffab186d6d0
        public void OnAvatarDynamicsComplete(){} // RVA: 0x7ffab186d790
        // ── Binary Analysis Named ──
        public void SetupDynamicsLoops(){} // RVA: 0x7ffab186d0b0
    }

    public class Tools : Object
    {
        public object _clientVersion; // 0x318C3A50
        public object _platform; // 0x318C3A50
        public object major; // 0x35EC98B0

        // ── Original Methods ──
        public void get_isClient(){} // RVA: 0x7ffab186e210
        public void get_GameServerVersion(){} // RVA: 0x7ffab186e350
        public void get_ClientVersion(){} // RVA: 0x7ffab186e3b0
        public void get_SdkVersion(){} // RVA: 0x7ffab186e530
        public void get_UnityVersion(){} // RVA: 0x7ffab186e590
        public void get_Platform(){} // RVA: 0x7ffab186e710
        public void ArrToString(){} // RVA: 0x7ffab186ee50
        public void ListToString(){} // RVA: 0x7ffab186ef20
        public void ScrambledEquals(){} // RVA: 0x7ffaa864a690
        public void ObjListToStringList(){} // RVA: 0x7ffab186f190
        public void ObjDictToStringDict(){} // RVA: 0x7ffab186f410
        public void CombineHashCodes(){} // RVA: 0x7ffab186fa20
        public void Truncate(){} // RVA: 0x7ffab186fd50
        public void IsValidURL(){} // RVA: 0x7ffab186fdd0
        public void IsAllowedUrl(){} // RVA: 0x7ffab186fed0
        public void ClearUserData(){} // RVA: 0x7ffab18706a0
        public void ClearCookies(){} // RVA: 0x7ffab1870820
        public void UnixTimeStampToDateTime(){} // RVA: 0x7ffab1870870
        public void FindSceneObjectsOfTypeAll(){} // RVA: 0x7ffab1870960
        public void FindSceneObjectsOfTypeAll(){} // RVA: 0x7ffab1870960
        public void TwoDArrayToOneDArray(){} // RVA: 0x7ffaa86492c0
        public void OneDArrayToTwoDArray(){} // RVA: 0x7ffaa865a250
        public void ClearExpiredBestHTTPCache(){} // RVA: 0x7ffab1870ce0
        public void FileCanRead(){} // RVA: 0x7ffab18712a0
        public void FileCanRead(){} // RVA: 0x7ffab18712a0
        public void FileCopy(){} // RVA: 0x7ffab18713a0
        public void FileMove(){} // RVA: 0x7ffab1871480
        public void DivideSafe(){} // RVA: 0x7ffab1871560
        public void FileMD5(){} // RVA: 0x7ffab18716c0
        public void StringToMD5(){} // RVA: 0x7ffab1871800
        public void JsonEncode(){} // RVA: 0x7ffab1871b70
        public void JsonDecode(){} // RVA: 0x7ffab1871c30
        public void IsProton(){} // RVA: 0x7ffab1871cd0
        public void FindComponentInPossibleClones(){} // RVA: 0x7ffab1871d80
        public void .cctor(){} // RVA: 0x7ffab1871f00
        // ── Binary Analysis Named ──
        public void SetGameServerVersion(){} // RVA: 0x7ffab186e290
        public void SetLayerRecursively(){} // RVA: 0x7ffab186e9b0
        public void SetLayerRecursivelyExceptMask(){} // RVA: 0x7ffab186ea40
        public void GetOrDefaultFromDictionary(){} // RVA: 0x7ffab186edd0
        public void GetGameObjectPath(){} // RVA: 0x7ffab186f6d0
        public void GetRandomDigits(){} // RVA: 0x7ffab186fa30
        public void GetRandomHex(){} // RVA: 0x7ffab186fba0
        public void GetNumReservedLayers(){} // RVA: 0x7ffaa8b9a420
        public void GetReservedLayers(){} // RVA: 0x7ffab1870ba0
        public void GetTempFolderPath(){} // RVA: 0x7ffab1870e20
        public void GetTempFileName(){} // RVA: 0x7ffab1870ef0
        public void GetFileSize(){} // RVA: 0x7ffab1871580
    }

    public class VRCFastCrypto_Client : Object
    {
        public object secretKeyLength; // 0x3383F100

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaf8ab380
        public void GenerateSigningKey(){} // RVA: 0x7ffaaf8ab490
        public void GenerateSigningKey(){} // RVA: 0x7ffaaf8ab490
        public void SignMessage(){} // RVA: 0x7ffaaf8ab6d0
        public void SignMessage(){} // RVA: 0x7ffaaf8ab6d0
        public void VerifyMessage(){} // RVA: 0x7ffaaf8ab920
        public void VerifyMessage(){} // RVA: 0x7ffaaf8ab920
        // ── Binary Analysis Named ──
        public void GetSizes(){} // RVA: 0x7ffaaf8ab400
    }

}