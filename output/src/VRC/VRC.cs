// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC
// Classes: 17
// Methods: 202

namespace VRC
{
    public class AssetCache : Object
    {
        public System.Collections.Generic.List`1<ÍÎÎÏÎÌÏÍÌÏÌÎÏÏÍÎÏÏÌÍÍÌÎ> _assetCache; // 0x10

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE82955590
        public void Equals(){} // RVA: 0x7FFE82955600
        public void GetHashCode(){} // RVA: 0x7FFE82955780
        public void op_Implicit(){} // RVA: 0x7FFE82955AE0
        public void CompareBaseObjects(){} // RVA: 0x7FFE82955B40
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE82955BC0
        public void .ctor(){} // RVA: 0x7FFE82955F20
        public void get_name(){} // RVA: 0x7FFE829561C0
        public void set_name(){} // RVA: 0x7FFE82955B40
        public void Instantiate(){} // RVA: 0x7FFE829562F0
        public void ToString(){} // RVA: 0x7FFE829562F0
        public void GetHashCode_4315ED5FF0F8(){} // RVA: 0x7FFE810FE7C0
        public void ToString_BDAA3F2D4CB2(){} // RVA: 0x7FFE82955B40
        public void ProcessChildTransforms(){} // RVA: 0x7FFE81161E80
        public void Initialize(){} // RVA: 0x7FFE82956350
        // ── Unresolved (hash) ──
        public void m_E5A(){} // RVA: 0x7FFE82955AE0
    }

    public class BackgroundOption : Object
    {
        public VRC.Localization.LocalizableString _backgroundName; // 0x10
        public string _materialName; // 0x38
        public UnityEngine.Sprite _preview; // 0x40
        public bool _isVRCPlus; // 0x48

        // ── Methods ──
        public void get_BackgroundName(){} // RVA: 0x7FFE8196FB10
        public void set_BackgroundName(){} // RVA: 0x7FFE828F45C0
        public void get_IsVRCPlus(){} // RVA: 0x7FFE811B2D30
        public void set_IsVRCPlus(){} // RVA: 0x7FFE8196FB10
        public void CompareBaseObjects(){} // RVA: 0x7FFE828F46F0
        public void set_Preview(){} // RVA: 0x7FFE828F47C0
        public void get_Preview(){} // RVA: 0x7FFE81178740
        public void get_name(){} // RVA: 0x7FFE8196FB10
        public void set_name(){} // RVA: 0x7FFE828F4870
        public void set_IsLoaded(){} // RVA: 0x7FFE8196FB10
        public void get_IsLoaded(){} // RVA: 0x7FFE828F48F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE828F49C0
    }

    public class BackgroundOptions : ScriptableObject
    {
        public VRC.BackgroundOption[] _options; // 0x18

        // ── Methods ──
        public void set_Options(){} // RVA: 0x7FFE810FE7C0
        public void CreateInstance(){} // RVA: 0x7FFE810FE7C0
        public void get_Options(){} // RVA: 0x7FFE810FE7C0
        public void CreateScriptableObject(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE81345B60
        public void Initialize(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE810FE7C0
    }

    public class ClientPlayerLoop : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE8292CA50
        public void Equals(){} // RVA: 0x7FFE8292CB60
        public void Initialize(){} // RVA: 0x7FFE8292CC70
        public void op_Implicit(){} // RVA: 0x7FFE8292CF40
        public void CompareBaseObjects(){} // RVA: 0x7FFE8292D0F0
    }

    public class FileSizeUnitExtensions : Object
    {
        // ── Methods ──
        public void TryParse(){} // RVA: 0x7FFE8A4AA040
        public void GetUnitSize(){} // RVA: 0x7FFE8A4AA290
        public void GetPostfix(){} // RVA: 0x7FFE8A4AA380
    }

    public class GiftDisplayReferences : ScriptableObject
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE82911B10
        public void CreateInstance(){} // RVA: 0x7FFE82911B10
        public void GetHashCode(){} // RVA: 0x7FFE82911B10
        public void .ctor(){} // RVA: 0x7FFE81345B60
        public void Initialize(){} // RVA: 0x7FFE82911BD0
        public void ToString(){} // RVA: 0x7FFE82911BD0
        public void ToString_C126FE1D69A8(){} // RVA: 0x7FFE82911B10
        public void DoSlerp_Injected_D6B(){} // RVA: 0x7FFE82911BD0
        // ── Unresolved (hash) ──
        public void m_2E8(){} // RVA: 0x7FFE82911C90
        public void m_FFB(){} // RVA: 0x7FFE82911D30
    }

    public class HttpRequest : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Abort(){} // RVA: 0x7FFE8A2B0390
    }

    public class IMDraw : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8820C2E0
        public void OnDestroy(){} // RVA: 0x7FFE8820C500
        public void OnDraw(){} // RVA: 0x7FFE8820C6F0
        public void Draw(){} // RVA: 0x7FFE8820C920
        public void Clear(){} // RVA: 0x7FFE8820CA00
        public void UpdateCommandBuffers(){} // RVA: 0x7FFE8820CA80
        public void BuildCommandBuffer(){} // RVA: 0x7FFE8820CB80
        public void BuildFallbackCommandBuffer(){} // RVA: 0x7FFE8820CC20
        public void Line2D(){} // RVA: 0x7FFE8820CD20
        public void Line3D(){} // RVA: 0x7FFE8820CFC0 | overloaded x2
        public void Sphere(){} // RVA: 0x7FFE8820D1F0 | overloaded x2
        public void Capsule(){} // RVA: 0x7FFE8820D430 | overloaded x2
        public void Cone(){} // RVA: 0x7FFE8820D610 | overloaded x2
        public void WireSquare3D(){} // RVA: 0x7FFE8820D770
        public void WireCube3D(){} // RVA: 0x7FFE8820EC50 | overloaded x3
        public void WireCircle3D(){} // RVA: 0x7FFE8820F4A0
        public void WireArc3D(){} // RVA: 0x7FFE8820FB40
        public void .ctor(){} // RVA: 0x7FFE88210200
    }

    public class InputLatencyTracker : Object
    {
        public System.Diagnostics.Stopwatch _inputLatencyTracker;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE8292D150
        public void Equals(){} // RVA: 0x7FFE8292D320
        public void GetHashCode(){} // RVA: 0x7FFE8292D5E0
        public void op_Implicit(){} // RVA: 0x7FFE8292D800
        public void CompareBaseObjects(){} // RVA: 0x7FFE8292D9D0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE8292DB10
        public void .cctor(){} // RVA: 0x7FFE8292DBB0
    }

    public class PlayerLoopUtility : Object
    {
        // ── Methods ──
        public void AddNewSystem(){} // RVA: 0x7FFE80E509F0
        public void RemoveExistingSystem(){} // RVA: 0x7FFE8A2A8F30
        public void MoveExistingSystem(){} // RVA: 0x7FFE8A2A93B0
        public void GetLoopIndexByType(){} // RVA: 0x7FFE8A2AA060
    }

    public class StickerCollectionPrefab : ScriptableObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class StickerPrefab : ScriptableObject
    {
        public UnityEngine.Texture2D texture; // 0x18
        public bool isAnimated; // 0x20
        public int frames; // 0x24
        public int fps; // 0x28
        public string loopStyle; // 0x30
        public ÏÌÌÍÏÍÍÏÎÍÍÎÏÎÍÏÍÎÌÍÌÌÌ<UnityEngine.Sprite> f_282; // 0x38
        public string f_805; // 0x40
        public ÏÌÌÍÏÍÍÏÎÍÍÎÏÎÍÏÍÎÌÍÌÌÌ<UnityEngine.Texture2D> f_EF1; // 0x48
        public ÏÌÌÍÏÍÍÏÎÍÍÎÏÎÍÏÍÎÌÍÌÌÌ<UnityEngine.Texture2D> f_7C8; // 0x50
        public object field_9; // 0xA0A
        public object field_10; // 0xA0B
        public object field_11; // 0xA0C
        public object field_12; // 0xA0D
        public object field_13; // 0xA0E
        public object field_14; // 0xA0F

        // ── Methods ──
        public void get_LoopStyle(){} // RVA: 0x7FFE8144E200
        public void set_LoopStyle(){} // RVA: 0x7FFE813240E0
        public void CreateInstance(){} // RVA: 0x7FFE81549710
        public void set_IsAnimated(){} // RVA: 0x7FFE813A1D90
        public void get_IsAnimated(){} // RVA: 0x7FFE811E99D0
        public void get_EffectBundleID(){} // RVA: 0x7FFE82925FB0
        public void get_CollectionID(){} // RVA: 0x7FFE81178740
        public void set_CollectionID(){} // RVA: 0x7FFE81123200
        public void get_LinearLoop(){} // RVA: 0x7FFE82925FF0
        public void set_LinearLoop(){} // RVA: 0x7FFE8119C0E0
        public void get_IsBuiltIn(){} // RVA: 0x7FFE811E0850
        public void set_IsBuiltIn(){} // RVA: 0x7FFE82926070
        public void get_FPS(){} // RVA: 0x7FFE81549710
        public void set_FPS(){} // RVA: 0x7FFE829260C0
        public void get_FileId(){} // RVA: 0x7FFE813240E0
        public void set_Sprite(){} // RVA: 0x7FFE81437330
        public void set_Frames(){} // RVA: 0x7FFE8119C0E0
        public void get_Frames(){} // RVA: 0x7FFE81A56130
        public void get_Sprite(){} // RVA: 0x7FFE8143BA80
        public void set_ID(){} // RVA: 0x7FFE82926400
        public void get_ID(){} // RVA: 0x7FFE813A1D90
        public void set_FullResolutionTexture(){} // RVA: 0x7FFE812534D0
        public void get_MaskTag(){} // RVA: 0x7FFE813240E0
        public void set_MaskTag(){} // RVA: 0x7FFE82926740
        public void .ctor(){} // RVA: 0x7FFE829268E0
        public void set_DisplayTexture(){} // RVA: 0x7FFE81176740
        public void get_FullResolutionTexture(){} // RVA: 0x7FFE8119C0E0
        public void set_IsSpecialFX(){} // RVA: 0x7FFE81178740
        public void get_IsSpecialFX(){} // RVA: 0x7FFE810FB320
        public void get_DisplayTexture(){} // RVA: 0x7FFE81176730
        public void Equals(){} // RVA: 0x7FFE82926970
    }

    public class SystemsPlayerLoop : Object
    {
        // ── Methods ──
        public void add_OnAvatarClone(){} // RVA: 0x7FFE8A2AA2D0
        public void remove_OnAvatarClone(){} // RVA: 0x7FFE8A2AA3E0
        public void add_OnAvatarHeadChop(){} // RVA: 0x7FFE8A2AA4F0
        public void remove_OnAvatarHeadChop(){} // RVA: 0x7FFE8A2AA600
        public void Initialize(){} // RVA: 0x7FFE8A2AA710
        public void FixConstraints(){} // RVA: 0x7FFE8A2AA7C0
        public void SetupDynamicsLoops(){} // RVA: 0x7FFE8A2AA9F0
        public void OnVRCConstraintsUpdate(){} // RVA: 0x7FFE8A2AAF30
        public void OnAvatarDynamicsPreSchedule(){} // RVA: 0x7FFE8A2AAFC0
        public void OnAvatarDynamicsPostSchedule(){} // RVA: 0x7FFE8A2AB010
        public void OnAvatarDynamicsComplete(){} // RVA: 0x7FFE8A2AB130
    }

    public class Tools : Object
    {
        public System.Lazy`1<bool> _isClient;
        public string _gameServerVersion; // 0x8
        public string _clientVersion; // 0x10
        public string _sdkVersion; // 0x18
        public VRC.Core.UnityVersion _unityVersion; // 0x20
        public string _platform; // 0x38

        // ── Methods ──
        public void get_isClient(){} // RVA: 0x7FFE8A2ABBB0
        public void SetGameServerVersion(){} // RVA: 0x7FFE8A2ABC30
        public void get_GameServerVersion(){} // RVA: 0x7FFE8A2ABCF0
        public void get_ClientVersion(){} // RVA: 0x7FFE8A2ABD50
        public void get_SdkVersion(){} // RVA: 0x7FFE8A2ABED0
        public void get_UnityVersion(){} // RVA: 0x7FFE8A2ABF30
        public void get_Platform(){} // RVA: 0x7FFE8A2AC0B0
        public void SetLayerRecursively(){} // RVA: 0x7FFE8A2AC350
        public void SetLayerRecursivelyExceptMask(){} // RVA: 0x7FFE8A2AC3E0
        public void GetOrDefaultFromDictionary(){} // RVA: 0x7FFE8A2AC770
        public void ArrToString(){} // RVA: 0x7FFE8A2AC7F0
        public void ListToString(){} // RVA: 0x7FFE8A2AC8C0
        public void ScrambledEquals(){} // RVA: 0x7FFE80E2F7A0
        public void ObjListToStringList(){} // RVA: 0x7FFE8A2ACB30
        public void ObjDictToStringDict(){} // RVA: 0x7FFE8A2ACDB0
        public void GetGameObjectPath(){} // RVA: 0x7FFE8A2AD070
        public void CombineHashCodes(){} // RVA: 0x7FFE8A2AD3C0
        public void GetRandomDigits(){} // RVA: 0x7FFE8A2AD3D0
        public void GetRandomHex(){} // RVA: 0x7FFE8A2AD540
        public void Truncate(){} // RVA: 0x7FFE8A2AD6F0
        public void IsValidURL(){} // RVA: 0x7FFE8A2AD770
        public void IsAllowedUrl(){} // RVA: 0x7FFE8A2AD870
        public void ClearUserData(){} // RVA: 0x7FFE8A2AE040
        public void ClearCookies(){} // RVA: 0x7FFE8A2AE1C0
        public void UnixTimeStampToDateTime(){} // RVA: 0x7FFE8A2AE210
        public void FindSceneObjectsOfTypeAll(){} // RVA: 0x7FFE8A2AE300 | overloaded x2
        public void TwoDArrayToOneDArray(){} // RVA: 0x7FFE80E2E3D0
        public void OneDArrayToTwoDArray(){} // RVA: 0x7FFE80E3F430
        public void GetNumReservedLayers(){} // RVA: 0x7FFE813DA8C0
        public void GetReservedLayers(){} // RVA: 0x7FFE8A2AE540
        public void ClearExpiredBestHTTPCache(){} // RVA: 0x7FFE8A2AE680
        public void GetTempFolderPath(){} // RVA: 0x7FFE8A2AE7C0
        public void GetTempFileName(){} // RVA: 0x7FFE8A2AE890
        public void FileCanRead(){} // RVA: 0x7FFE8A2AEC40 | overloaded x2
        public void FileCopy(){} // RVA: 0x7FFE8A2AED40
        public void FileMove(){} // RVA: 0x7FFE8A2AEE20
        public void DivideSafe(){} // RVA: 0x7FFE8A2AEF00
        public void GetFileSize(){} // RVA: 0x7FFE8A2AEF20
        public void FileMD5(){} // RVA: 0x7FFE8A2AF060
        public void StringToMD5(){} // RVA: 0x7FFE8A2AF1A0
        public void JsonEncode(){} // RVA: 0x7FFE8A2AF510
        public void JsonDecode(){} // RVA: 0x7FFE8A2AF5D0
        public void IsProton(){} // RVA: 0x7FFE8A2AF670
        public void FindComponentInPossibleClones(){} // RVA: 0x7FFE8A2AF720
        public void .cctor(){} // RVA: 0x7FFE8A2AF8A0
    }

    public class VRCFastCrypto : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A2AB180
        public void GetSizes(){} // RVA: 0x7FFE8A2AB200
        public void GenerateSigningKey(){} // RVA: 0x7FFE8A2AB290 | overloaded x2
        public void SignMessage(){} // RVA: 0x7FFE8A2AB4D0 | overloaded x2
        public void VerifyMessage(){} // RVA: 0x7FFE8A2AB720 | overloaded x2
    }

    public class VRCFastCrypto_Client : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8823B3F0
        public void GetSizes(){} // RVA: 0x7FFE8823B470
        public void GenerateSigningKey(){} // RVA: 0x7FFE8823B500 | overloaded x2
        public void SignMessage(){} // RVA: 0x7FFE8823B740 | overloaded x2
        public void VerifyMessage(){} // RVA: 0x7FFE8823B990 | overloaded x2
    }

    public class ValidationHelpers : Object
    {
        // ── Methods ──
        public void GetAssetBundleSizeLimit(){} // RVA: 0x7FFE8A4AA4D0
        public void GetAssetBundleOverSizeLimitMessage(){} // RVA: 0x7FFE8A4AA590 | overloaded x2
        public void GetAssetBundleOverSizeLimitMessageSDKWarning(){} // RVA: 0x7FFE8A4AA8B0
        public void FormatFileSize(){} // RVA: 0x7FFE8A4AAB70
    }

}