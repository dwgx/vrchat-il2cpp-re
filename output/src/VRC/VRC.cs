// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC
// Classes: 17
// Methods: 201

namespace VRC
{
    public class AssetCache
    {
        public System.Collections.Generic.List`1<ÎÍÍÎÎÏÌÍÌÏÌÍÌÌÎÎÏÎÏÌÏÏÎ> ÎÌÌÌÍÌÎÍÏÎÍÏÏÍÎÍÎÎÏÍÌÌÌ; // 0x10

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x1BBE8E0
        public void Init(){} // RVA: 0x1BBE940
        public void Equals(){} // RVA: 0x343E80
        public void Initialize(){} // RVA: 0x1BBE9A0
        public void CompareBaseObjects(){} // RVA: 0x1BBEA10
        public void IsNativeObjectAlive(){} // RVA: 0x1BBEB90
        public void Initialize_A924CC784C59(){} // RVA: 0x1BBEC10
        public void .ctor(){} // RVA: 0x1BBED40
        public void set_name(){} // RVA: 0x1BBE8E0
        public void .ctor_6540F524EFBA(){} // RVA: 0x1BBEFE0
        public void Instantiate(){} // RVA: 0x343E80
        public void GetHashCode(){} // RVA: 0x2E07C0
        public void ToString(){} // RVA: 0x1BBF340
        public void ProcessChildTransforms(){} // RVA: 0x1BBE8E0
        public void IsNativeObjectAlive_648472B1FD23(){} // RVA: 0x1BBEB90
        // ── Unresolved (hash) ──
        public void m_8AE(){} // RVA: 0x1BBF470
        public void m_F73(){} // RVA: 0x1BBF7D0
    }

    public class BackgroundOption
    {
        public VRC.Localization.LocalizableString _backgroundName; // 0x10
        public string _materialName; // 0x38
        public UnityEngine.Sprite _preview; // 0x40
        public bool _isVRCPlus; // 0x48

        // ── Methods ──
        public void set_Preview(){} // RVA: 0x1B61EE0
        public void get_IsLoaded_35EBE0473145(){} // RVA: 0x35A740
        public void .ctor(){} // RVA: 0x2DD310
        public void Initialize(){} // RVA: 0x1B61FB0
        public void get_Preview(){} // RVA: 0x35A740
        public void set_IsLoaded(){} // RVA: 0x1B62060
        public void set_BackgroundName(){} // RVA: 0xBDB960
        public void get_BackgroundName(){} // RVA: 0xBDB960
        public void get_DisplayName(){} // RVA: 0x394D30
        public void get_IsLoaded(){} // RVA: 0x1B62110
        public void set_IsVRCPlus(){} // RVA: 0x1B621E0
        public void get_BackgroundName_6F1769432624(){} // RVA: 0x1B62260
        public void set_BackgroundName_1A82B182B65F(){} // RVA: 0x1B621E0
        public void get_IsVRCPlus(){} // RVA: 0x394D30
        public void get_Preview_61272830E33C(){} // RVA: 0x35A740
    }

    public class BackgroundOptions
    {
        public VRC.BackgroundOption[] _options; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x53BFB0
        public void Initialize(){} // RVA: 0x2E07C0
        public void set_Options(){} // RVA: 0x2E07C0
        public void get_Options_404873064031(){} // RVA: 0x2E07C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x2E07C0
        public void get_Options(){} // RVA: 0x2E07C0
        public void System.Collections.IEnumerator.get_Current_35C4078BDB59(){} // RVA: 0x2E07C0
    }

    public class ClientPlayerLoop
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x1B96C00
        public void Equals(){} // RVA: 0x1B96D10
        public void Initialize(){} // RVA: 0x1B96E20
        public void op_Implicit(){} // RVA: 0x1B970F0
        public void CompareBaseObjects(){} // RVA: 0x1B972A0
    }

    public class FileSizeUnitExtensions
    {
        // ── Methods ──
        public void TryParse(){} // RVA: 0x9A5E7A0
        public void GetUnitSize(){} // RVA: 0x9A5E9F0
        public void GetPostfix(){} // RVA: 0x9A5EAE0
    }

    public class GiftDisplayReferences
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x1B7AEE0
        public void .ctor_819DB5B55CFF(){} // RVA: 0x1B7AEE0
        public void Initialize(){} // RVA: 0x1B7AEE0
        public void CreateScriptableObject(){} // RVA: 0x1B7AFA0
        public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x1B7B060
        public void GetHashCode(){} // RVA: 0x1B7AFA0
        public void ToString(){} // RVA: 0x1B7AFA0
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class HttpRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void Abort(){} // RVA: 0x984E0F0
    }

    public class IMDraw
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x76CF1C0
        public void OnDestroy(){} // RVA: 0x76CF3E0
        public void OnDraw(){} // RVA: 0x76CF5D0
        public void Draw(){} // RVA: 0x76CF800
        public void Clear(){} // RVA: 0x76CF8E0
        public void UpdateCommandBuffers(){} // RVA: 0x76CF960
        public void BuildCommandBuffer(){} // RVA: 0x76CFA60
        public void BuildFallbackCommandBuffer(){} // RVA: 0x76CFB00
        public void Line2D(){} // RVA: 0x76CFC00
        public void Line3D(){} // RVA: 0x76CFEA0 | overloaded x2
        public void Sphere(){} // RVA: 0x76D00D0 | overloaded x2
        public void Capsule(){} // RVA: 0x76D0310 | overloaded x2
        public void Cone(){} // RVA: 0x76D04F0 | overloaded x2
        public void WireSquare3D(){} // RVA: 0x76D0650
        public void WireCube3D(){} // RVA: 0x76D1B30 | overloaded x3
        public void WireCircle3D(){} // RVA: 0x76D2380
        public void WireArc3D(){} // RVA: 0x76D2A20
        public void .ctor(){} // RVA: 0x76D30E0
    }

    public class InputLatencyTracker
    {
        public System.Diagnostics.Stopwatch ÌÍÌÍÍÏÌÍÌÏÎÏÏÍÍÎÏÎÏÏÍÎÏ;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x1B97300
        public void Equals(){} // RVA: 0x1B974D0
        public void GetHashCode(){} // RVA: 0x1B97790
        public void op_Implicit(){} // RVA: 0x1B979B0
        public void CompareBaseObjects(){} // RVA: 0x1B97B80
        public void IsNativeObjectAlive(){} // RVA: 0x1B97CC0
        public void .cctor(){} // RVA: 0x1B97D60
    }

    public class PlayerLoopUtility
    {
        // ── Methods ──
        public void AddNewSystem(){} // RVA: 0x2F420
        public void RemoveExistingSystem(){} // RVA: 0x9846B50
        public void MoveExistingSystem(){} // RVA: 0x9846FD0
        public void GetLoopIndexByType(){} // RVA: 0x9847C80
    }

    public class StickerCollectionPrefab
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class StickerPrefab
    {
        public UnityEngine.Texture2D texture; // 0x18
        public bool isAnimated; // 0x20
        public int frames; // 0x24
        public int fps; // 0x28
        public string loopStyle; // 0x30
        public ÎÎÏÏÍÍÎÍÍÍÍÎÌÌÌÍÍÏÍÏÍÎÎ<UnityEngine.Sprite> <ÍÍÍÌÎÏÏÍÎÍÍÌÍÌÎÏÎÎÎÎÍÌÏ>k__BackingField; // 0x38
        public string <ÎÏÎÌÎÌÏÎÏÌÎÌÏÍÍÎÍÏÎÌÏÏÍ>k__BackingField; // 0x40
        public ÎÎÏÏÍÍÎÍÍÍÍÎÌÌÌÍÍÏÍÏÍÎÎ<UnityEngine.Texture2D> <ÏÌÏÏÍÎÎÎÎÌÌÎÍÍÍÎÏÌÏÌÌÍÍ>k__BackingField; // 0x48
        public ÎÎÏÏÍÍÎÍÍÍÍÎÌÌÌÍÍÏÍÏÍÎÎ<UnityEngine.Texture2D> <ÌÏÍÌÏÌÌÎÍÏÍÍÏÍÌÌÎÍÍÏÎÎÏ>k__BackingField; // 0x50

        // ── Methods ──
        public void get_EffectBundleID(){} // RVA: 0x1B90FC0
        public void set_CollectionID(){} // RVA: 0x305200
        public void get_LinearLoop(){} // RVA: 0x1B91000
        public void set_LinearLoop(){} // RVA: 0x2DD320
        public void set_Sprite(){} // RVA: 0x49B830
        public void get_Frames(){} // RVA: 0xCEF5B0
        public void get_FileId(){} // RVA: 0x519240
        public void get_FullResolutionTexture(){} // RVA: 0x37E0E0
        public void get_MaskTag(){} // RVA: 0x519240
        public void set_MaskTag(){} // RVA: 0x1B91080
        public void set_FullResolutionTexture(){} // RVA: 0x4354D0
        public void get_DisplayTexture(){} // RVA: 0x358730
        public void get_LoopStyle(){} // RVA: 0x6374D0
        public void get_CollectionID(){} // RVA: 0x35A740
        public void .ctor(){} // RVA: 0x1B91220
        public void get_IsAnimated(){} // RVA: 0x3CB9D0
        public void set_IsAnimated(){} // RVA: 0x1B912B0
        public void set_ID(){} // RVA: 0x1B915F0
        public void get_ID(){} // RVA: 0x59E520
        public void set_DisplayTexture(){} // RVA: 0x358740
        public void get_IsBuiltIn(){} // RVA: 0x3C2850
        public void set_IsBuiltIn(){} // RVA: 0x49B830
        public void get_FPS(){} // RVA: 0x791DC0
        public void set_FPS(){} // RVA: 0x358730
        public void get_Sprite(){} // RVA: 0x4976A0
        public void set_IsSpecialFX(){} // RVA: 0x59E520
        public void get_CollectionID_AA4DCDE9C0AF(){} // RVA: 0x37E0E0
        public void Equals(){} // RVA: 0x1B91640
        public void get_IsSpecialFX(){} // RVA: 0x2DD320
    }

    public class SystemsPlayerLoop
    {
        // ── Methods ──
        public void add_OnAvatarClone(){} // RVA: 0x9847EF0
        public void remove_OnAvatarClone(){} // RVA: 0x9848000
        public void add_OnAvatarHeadChop(){} // RVA: 0x9848110
        public void remove_OnAvatarHeadChop(){} // RVA: 0x9848220
        public void Initialize(){} // RVA: 0x9848330
        public void FixConstraints(){} // RVA: 0x98483E0
        public void SetupDynamicsLoops(){} // RVA: 0x9848610
        public void OnVRCConstraintsUpdate(){} // RVA: 0x9848B50
        public void OnAvatarDynamicsPreSchedule(){} // RVA: 0x9848BE0
        public void OnAvatarDynamicsPostSchedule(){} // RVA: 0x9848C30
        public void OnAvatarDynamicsComplete(){} // RVA: 0x9848D50
    }

    public class Tools
    {
        public System.Lazy`1<bool> start;
        public string end; // 0x8
        public string duration; // 0x10
        public string muted; // 0x18
        public VRC.Core.UnityVersion mutedInHierarchy; // 0x20
        public string timelineAsset; // 0x38

        // ── Methods ──
        public void get_isClient(){} // RVA: 0x98497D0
        public void SetGameServerVersion(){} // RVA: 0x9849850
        public void get_GameServerVersion(){} // RVA: 0x9849910
        public void get_ClientVersion(){} // RVA: 0x9849970
        public void get_SdkVersion(){} // RVA: 0x9849AF0
        public void get_UnityVersion(){} // RVA: 0x9849B50
        public void get_Platform(){} // RVA: 0x9849CD0
        public void SetLayerRecursively(){} // RVA: 0x9849F70
        public void SetLayerRecursivelyExceptMask(){} // RVA: 0x984A000
        public void GetOrDefaultFromDictionary(){} // RVA: 0x984A390
        public void ArrToString(){} // RVA: 0x984A410
        public void ListToString(){} // RVA: 0x984A4E0
        public void ScrambledEquals(){} // RVA: 0xE230
        public void ObjListToStringList(){} // RVA: 0x984A750
        public void ObjDictToStringDict(){} // RVA: 0x984A9D0
        public void GetGameObjectPath(){} // RVA: 0x984AC90
        public void CombineHashCodes(){} // RVA: 0x984AFE0
        public void GetRandomDigits(){} // RVA: 0x984AFF0
        public void GetRandomHex(){} // RVA: 0x984B160
        public void Truncate(){} // RVA: 0x984B310
        public void IsValidURL(){} // RVA: 0x984B390
        public void IsAllowedUrl(){} // RVA: 0x984B490
        public void ClearUserData(){} // RVA: 0x984BD30
        public void ClearCookies(){} // RVA: 0x984BEB0
        public void UnixTimeStampToDateTime(){} // RVA: 0x984BF00
        public void FindSceneObjectsOfTypeAll(){} // RVA: 0x984BFF0 | overloaded x2
        public void TwoDArrayToOneDArray(){} // RVA: 0xCE50
        public void OneDArrayToTwoDArray(){} // RVA: 0x1DEC0
        public void GetNumReservedLayers(){} // RVA: 0x5D5200
        public void GetReservedLayers(){} // RVA: 0x984C230
        public void ClearExpiredBestHTTPCache(){} // RVA: 0x984C370
        public void GetTempFolderPath(){} // RVA: 0x984C4B0
        public void GetTempFileName(){} // RVA: 0x984C580
        public void FileCanRead(){} // RVA: 0x984C930 | overloaded x2
        public void FileCopy(){} // RVA: 0x984CA30
        public void FileMove(){} // RVA: 0x984CB10
        public void DivideSafe(){} // RVA: 0x984CBF0
        public void GetFileSize(){} // RVA: 0x984CC10
        public void FileMD5(){} // RVA: 0x984CD50
        public void StringToMD5(){} // RVA: 0x984CE90
        public void JsonEncode(){} // RVA: 0x984D200
        public void JsonDecode(){} // RVA: 0x984D2C0
        public void IsProton(){} // RVA: 0x984D360
        public void FindComponentInPossibleClones(){} // RVA: 0x984D410
        public void .cctor(){} // RVA: 0x984D590
    }

    public class VRCFastCrypto
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x9848DA0
        public void GetSizes(){} // RVA: 0x9848E20
        public void GenerateSigningKey(){} // RVA: 0x9848EB0 | overloaded x2
        public void SignMessage(){} // RVA: 0x98490F0 | overloaded x2
        public void VerifyMessage(){} // RVA: 0x9849340 | overloaded x2
    }

    public class VRCFastCrypto_Client
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x76FE750
        public void GetSizes(){} // RVA: 0x76FE7D0
        public void GenerateSigningKey(){} // RVA: 0x76FE860 | overloaded x2
        public void SignMessage(){} // RVA: 0x76FEAA0 | overloaded x2
        public void VerifyMessage(){} // RVA: 0x76FECF0 | overloaded x2
    }

    public class ValidationHelpers
    {
        // ── Methods ──
        public void GetAssetBundleSizeLimit(){} // RVA: 0x9A5EC30
        public void GetAssetBundleOverSizeLimitMessage(){} // RVA: 0x9A5ECF0 | overloaded x2
        public void GetAssetBundleOverSizeLimitMessageSDKWarning(){} // RVA: 0x9A5F010
        public void FormatFileSize(){} // RVA: 0x9A5F2D0
    }

}