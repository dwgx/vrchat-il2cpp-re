// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC
// Classes: 17
// Methods: 201

namespace VRC
{
    public class AssetCache : Object
    {
        public System.Collections.Generic.List`1<ÎÏÏÍÍÍÏÎÎÏÎÎÎÎÍÌÎÌÍÍÌÏÏ> _assetCache; // 0x10
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.IList> <ÌÍÏÎÎÍÎÍÏÍÍÌÌÏÏÏÎÏÌÏÍÎÍ>k__BackingField; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC2F247C0
        public void Init(){} // RVA: 0x7FFAC2F87E80
        public void Equals(){} // RVA: 0x7FFAC2F87E80
        public void op_Implicit(){} // RVA: 0x7FFAC464FAE0
        public void CompareBaseObjects(){} // RVA: 0x7FFAC464FE40
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC46501A0
        public void Initialize(){} // RVA: 0x7FFAC4650200
        public void get_name(){} // RVA: 0x7FFAC4650270
        public void set_name(){} // RVA: 0x7FFAC46503F0
        public void .ctor(){} // RVA: 0x7FFAC4650540
        public void Instantiate(){} // RVA: 0x7FFAC46507E0
        public void GetHashCode(){} // RVA: 0x7FFAC2F247C0
        public void ToString(){} // RVA: 0x7FFAC4650850
        public void ProcessChildTransforms(){} // RVA: 0x7FFAC46501A0
        public void Initialize_1B5EA1659B63(){} // RVA: 0x7FFAC4650950
        public void op_Implicit_F3F4686A1091(){} // RVA: 0x7FFAC46509C0
    }

    public class BackgroundOption : Object
    {
        public VRC.Localization.LocalizableString IsLoaded; // 0x10
        public string BackgroundName; // 0x38
        public UnityEngine.Sprite Preview; // 0x40
        public bool IsVRCPlus; // 0x48
        public UnityEngine.Material _loadedMaterial; // 0x50

        // ── Methods ──
        public void set_IsLoaded(){} // RVA: 0x7FFAC45BEBF0
        public void get_IsLoaded(){} // RVA: 0x7FFAC45BEC70
        public void get_IsVRCPlus(){} // RVA: 0x7FFAC2FD8D30
        public void set_IsVRCPlus(){} // RVA: 0x7FFAC45BED40
        public void get_Preview(){} // RVA: 0x7FFAC2F9E740
        public void get_hidden(){} // RVA: 0x7FFAC2FD8D30
        public void GetCachedPtr(){} // RVA: 0x7FFAC45BEDF0
        public void get_name(){} // RVA: 0x7FFAC2FD8D30
        public void get_DisplayName(){} // RVA: 0x7FFAC3813C20
        public void Instantiate(){} // RVA: 0x7FFAC2FD8D30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_BackgroundName(){} // RVA: 0x7FFAC3813C20
        public void set_BackgroundName(){} // RVA: 0x7FFAC3813C20
    }

    public class BackgroundOptions : ScriptableObject
    {
        public VRC.BackgroundOption[] Options; // 0x18

        // ── Methods ──
        public void set_Options(){} // RVA: 0x7FFAC2F247C0
        public void get_Options(){} // RVA: 0x7FFAC2F247C0
        public void CreateInstance(){} // RVA: 0x7FFAC2F247C0
        public void CreateScriptableObject(){} // RVA: 0x7FFAC2F247C0
        public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
        public void Initialize(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC2F247C0
        public void GetHashCode(){} // RVA: 0x7FFAC2F247C0
        public void ToString(){} // RVA: 0x7FFAC2F247C0
    }

    public class ClientPlayerLoop : Object
    {
        public System.Action ÌÍÌÏÏÍÌÌÏÎÏÏÍÏÏÌÏÏÍÏÍÌÌ;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC45F77E0
        public void Equals(){} // RVA: 0x7FFAC45F78F0
        public void Initialize(){} // RVA: 0x7FFAC45F7A00
        public void op_Implicit(){} // RVA: 0x7FFAC45F7CD0
        public void CompareBaseObjects(){} // RVA: 0x7FFAC45F7E80
    }

    public class FileSizeUnitExtensions : Object
    {
        public string UnitPostfixB;
        public string UnitPostfixKB;
        public string UnitPostfixMB;
        public string UnitPostfixGB;
        public string UnitPostfixTB;
        public ulong KBInBytes;
        public ulong MBInBytes;
        public ulong GBInBytes;
        public ulong TBInBytes;

        // ── Methods ──
        public void TryParse(){} // RVA: 0x7FFACC044560
        public void GetUnitSize(){} // RVA: 0x7FFACC0447B0
        public void GetPostfix(){} // RVA: 0x7FFACC0448A0
    }

    public class GiftDisplayReferences : ScriptableObject
    {
        public GiftDisplayReference[] giftDisplayReferences; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC45D82F0
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
        public void Initialize(){} // RVA: 0x7FFAC45D8390
        public void CreateScriptableObject(){} // RVA: 0x7FFAC45D8430
        public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7FFAC45D84F0
        public void GetHashCode(){} // RVA: 0x7FFAC45D82F0
        public void ToString(){} // RVA: 0x7FFAC45D8430
        public void .ctor_53F7ECC03924(){} // RVA: 0x7FFAC45D82F0
        public void DoSlerp_Injected_D6B(){} // RVA: 0x7FFAC45D84F0
    }

    public class HttpRequest : Object
    {
        public object InternalRequest; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Abort(){} // RVA: 0x7FFACBE56D10
    }

    public class IMDraw : MonoBehaviour
    {
        public IMDrawLine line2D; // 0x20
        public IMDrawLine line3D; // 0x28
        public IMDrawShape sphere; // 0x30
        public IMDrawShape cone; // 0x38
        public int MaxBuffer; // 0x40
        public UnityEngine.Color Color; // 0x44
        public float Alpha; // 0x54
        public float LineWidth; // 0x58
        public float DEFAULT_LINE_WIDTH;
        public int Layer; // 0x5C
        public bool ClearEachFrame; // 0x60
        public bool DrawToMainCamera; // 0x61

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC9E5A470
        public void OnDestroy(){} // RVA: 0x7FFAC9E5A690
        public void OnDraw(){} // RVA: 0x7FFAC9E5A880
        public void Draw(){} // RVA: 0x7FFAC9E5AAB0
        public void Clear(){} // RVA: 0x7FFAC9E5AB90
        public void UpdateCommandBuffers(){} // RVA: 0x7FFAC9E5AC10
        public void BuildCommandBuffer(){} // RVA: 0x7FFAC9E5AD10
        public void Line2D(){} // RVA: 0x7FFAC9E5ADB0
        public void Line3D(){} // RVA: 0x7FFAC9E5B050 | overloaded x2
        public void Sphere(){} // RVA: 0x7FFAC9E5B280 | overloaded x2
        public void Capsule(){} // RVA: 0x7FFAC9E5B4C0 | overloaded x2
        public void Cone(){} // RVA: 0x7FFAC9E5B6A0 | overloaded x2
        public void WireSquare3D(){} // RVA: 0x7FFAC9E5B800
        public void WireCube3D(){} // RVA: 0x7FFAC9E5C2E0 | overloaded x2
        public void WireCircle3D(){} // RVA: 0x7FFAC9E5CB30
        public void WireArc3D(){} // RVA: 0x7FFAC9E5D1D0
        public void .ctor(){} // RVA: 0x7FFAC9E5D890
    }

    public class InputLatencyTracker : Object
    {
        public System.Diagnostics.Stopwatch _inputLatencyTracker;
        public bool ÌÎÏÌÏÌÌÌÎÎÏÍÌÌÏÌÎÎÌÏÏÏÎ; // 0x8
        public float ÏÎÎÏÎÏÏÌÍÏÍÏÍÍÌÌÍÍÎÎÌÏÎ; // 0xC
        public object ÏÌÎÎÍÌÌÏÏÏÎÏÍÏÏÏÍÎÎÍÌÎÏ; // 0x10

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC45F7EE0
        public void Equals(){} // RVA: 0x7FFAC45F80B0
        public void GetHashCode(){} // RVA: 0x7FFAC45F8370
        public void op_Implicit(){} // RVA: 0x7FFAC45F8590
        public void CompareBaseObjects(){} // RVA: 0x7FFAC45F8760
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC45F88A0
        public void .cctor(){} // RVA: 0x7FFAC45F8940
    }

    public class PlayerLoopUtility : Object
    {
        // ── Methods ──
        public void AddNewSystem(){} // RVA: 0x7FFAC2C7B2F0
        public void RemoveExistingSystem(){} // RVA: 0x7FFACBE4F910
        public void MoveExistingSystem(){} // RVA: 0x7FFACBE4FD90
        public void GetLoopIndexByType(){} // RVA: 0x7FFACBE50A40
    }

    public class StickerCollectionPrefab : ScriptableObject
    {
        public UnityEngine.Sprite icon; // 0x18
        public VRC.StickerPrefab[] stickers; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class StickerPrefab : ScriptableObject
    {
        public UnityEngine.Texture2D ID; // 0x18
        public bool FileId; // 0x20
        public int IsBuiltIn; // 0x24
        public int Sprite; // 0x28
        public string CollectionID; // 0x30
        public ÍÍÌÎÏÍÍÏÏÏÎÏÍÍÌÌÎÍÌÍÍÍÏ<UnityEngine.Sprite> DisplayTexture; // 0x38
        public string FullResolutionTexture; // 0x40
        public ÍÍÌÎÏÍÍÏÏÏÎÏÍÍÌÌÎÍÌÍÍÍÏ<UnityEngine.Texture2D> MaskTag; // 0x48
        public ÍÍÌÎÏÍÍÏÏÏÎÏÍÍÌÌÎÍÌÍÍÍÏ<UnityEngine.Texture2D> IsAnimated; // 0x50

        // ── Methods ──
        public void get_IsAnimated(){} // RVA: 0x7FFAC300F9D0
        public void get_Frames(){} // RVA: 0x7FFAC3921980
        public void set_DisplayTexture(){} // RVA: 0x7FFAC2F9C740
        public void get_DisplayTexture(){} // RVA: 0x7FFAC2F9C730
        public void get_MaskTag(){} // RVA: 0x7FFAC34F9180
        public void get_FileId(){} // RVA: 0x7FFAC34F9180
        public void set_CollectionID(){} // RVA: 0x7FFAC2F49200
        public void set_LinearLoop(){} // RVA: 0x7FFAC45EF750
        public void get_LinearLoop(){} // RVA: 0x7FFAC45EF8F0
        public void set_FullResolutionTexture(){} // RVA: 0x7FFAC30794D0
        public void GetSessionId(){} // RVA: 0x7FFAC31D0140
        public void get_Sprite(){} // RVA: 0x7FFAC31D0140
        public void set_ID(){} // RVA: 0x7FFAC45EF970
        public void .ctor(){} // RVA: 0x7FFAC45EF9B0
        public void SetModelAlphaBlendShader(){} // RVA: 0x7FFAC30794D0
        public void get_ID(){} // RVA: 0x7FFAC3143DB0
        public void get_IsBuiltIn(){} // RVA: 0x7FFAC3006850
        public void set_IsBuiltIn(){} // RVA: 0x7FFAC30794D0
        public void get_FPS(){} // RVA: 0x7FFAC32EC4C0
        public void get_FullResolutionTexture(){} // RVA: 0x7FFAC2FC20E0
        public void get_EffectBundleID(){} // RVA: 0x7FFAC45EFA40
        public void get_LoopStyle(){} // RVA: 0x7FFAC31D95E0
        public void set_Sprite(){} // RVA: 0x7FFAC31D0C20
        public void set_EffectBundleID(){} // RVA: 0x7FFAC45EFA80
        public void set_IsSpecialFX(){} // RVA: 0x7FFAC34F9180
        public void get_IsSpecialFX(){} // RVA: 0x7FFAC2F21320
        public void get_CollectionID(){} // RVA: 0x7FFAC2F9E740
        public void Equals(){} // RVA: 0x7FFAC34F9180
        public void GetHashCode(){} // RVA: 0x7FFAC45EFAD0
        public void ToString(){} // RVA: 0x7FFAC45EFE10
    }

    public class SystemsPlayerLoop : Object
    {
        public bool _initialized;
        public System.Action OnAvatarClone; // 0x8
        public System.Action OnAvatarHeadChop; // 0x10

        // ── Methods ──
        public void add_OnAvatarClone(){} // RVA: 0x7FFACBE50CB0
        public void remove_OnAvatarClone(){} // RVA: 0x7FFACBE50DC0
        public void add_OnAvatarHeadChop(){} // RVA: 0x7FFACBE50ED0
        public void remove_OnAvatarHeadChop(){} // RVA: 0x7FFACBE50FE0
        public void Initialize(){} // RVA: 0x7FFACBE510F0
        public void FixConstraints(){} // RVA: 0x7FFACBE511A0
        public void SetupDynamicsLoops(){} // RVA: 0x7FFACBE513D0
        public void OnVRCConstraintsUpdate(){} // RVA: 0x7FFACBE51910
        public void OnAvatarDynamicsPreSchedule(){} // RVA: 0x7FFACBE519A0
        public void OnAvatarDynamicsPostSchedule(){} // RVA: 0x7FFACBE519F0
        public void OnAvatarDynamicsComplete(){} // RVA: 0x7FFACBE51AB0
    }

    public class Tools : Object
    {
        public System.Lazy`1<bool> isClient;
        public string GameServerVersion; // 0x8
        public string ClientVersion; // 0x10
        public string SdkVersion; // 0x18
        public VRC.Core.UnityVersion UnityVersion; // 0x20
        public string Platform; // 0x38
        public System.Random random; // 0x40

        // ── Methods ──
        public void get_isClient(){} // RVA: 0x7FFACBE52530
        public void SetGameServerVersion(){} // RVA: 0x7FFACBE525B0
        public void get_GameServerVersion(){} // RVA: 0x7FFACBE52670
        public void get_ClientVersion(){} // RVA: 0x7FFACBE526D0
        public void get_SdkVersion(){} // RVA: 0x7FFACBE52850
        public void get_UnityVersion(){} // RVA: 0x7FFACBE528B0
        public void get_Platform(){} // RVA: 0x7FFACBE52A30
        public void SetLayerRecursively(){} // RVA: 0x7FFACBE52CD0
        public void SetLayerRecursivelyExceptMask(){} // RVA: 0x7FFACBE52D60
        public void GetOrDefaultFromDictionary(){} // RVA: 0x7FFACBE530F0
        public void ArrToString(){} // RVA: 0x7FFACBE53170
        public void ListToString(){} // RVA: 0x7FFACBE53240
        public void ScrambledEquals(){} // RVA: 0x7FFAC2C5A350
        public void ObjListToStringList(){} // RVA: 0x7FFACBE534B0
        public void ObjDictToStringDict(){} // RVA: 0x7FFACBE53730
        public void GetGameObjectPath(){} // RVA: 0x7FFACBE539F0
        public void CombineHashCodes(){} // RVA: 0x7FFACBE53D40
        public void GetRandomDigits(){} // RVA: 0x7FFACBE53D50
        public void GetRandomHex(){} // RVA: 0x7FFACBE53EC0
        public void Truncate(){} // RVA: 0x7FFACBE54070
        public void IsValidURL(){} // RVA: 0x7FFACBE540F0
        public void IsAllowedUrl(){} // RVA: 0x7FFACBE541F0
        public void ClearUserData(){} // RVA: 0x7FFACBE549C0
        public void ClearCookies(){} // RVA: 0x7FFACBE54B40
        public void UnixTimeStampToDateTime(){} // RVA: 0x7FFACBE54B90
        public void FindSceneObjectsOfTypeAll(){} // RVA: 0x7FFACBE54C80 | overloaded x2
        public void TwoDArrayToOneDArray(){} // RVA: 0x7FFAC2C58F80
        public void OneDArrayToTwoDArray(){} // RVA: 0x7FFAC2C69F10
        public void GetNumReservedLayers(){} // RVA: 0x7FFAC31719D0
        public void GetReservedLayers(){} // RVA: 0x7FFACBE54EC0
        public void ClearExpiredBestHTTPCache(){} // RVA: 0x7FFACBE55000
        public void GetTempFolderPath(){} // RVA: 0x7FFACBE55140
        public void GetTempFileName(){} // RVA: 0x7FFACBE55210
        public void FileCanRead(){} // RVA: 0x7FFACBE555C0 | overloaded x2
        public void FileCopy(){} // RVA: 0x7FFACBE556C0
        public void FileMove(){} // RVA: 0x7FFACBE557A0
        public void DivideSafe(){} // RVA: 0x7FFACBE55880
        public void GetFileSize(){} // RVA: 0x7FFACBE558A0
        public void FileMD5(){} // RVA: 0x7FFACBE559E0
        public void StringToMD5(){} // RVA: 0x7FFACBE55B20
        public void JsonEncode(){} // RVA: 0x7FFACBE55E90
        public void JsonDecode(){} // RVA: 0x7FFACBE55F50
        public void IsProton(){} // RVA: 0x7FFACBE55FF0
        public void FindComponentInPossibleClones(){} // RVA: 0x7FFACBE560A0
        public void .cctor(){} // RVA: 0x7FFACBE56220
    }

    public class VRCFastCrypto : Object
    {
        public string NATIVE_LIB;
        public ulong publicKeyLength;
        public ulong secretKeyLength; // 0x8
        public ulong signatureLength; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBE51B00
        public void GetSizes(){} // RVA: 0x7FFACBE51B80
        public void GenerateSigningKey(){} // RVA: 0x7FFACBE51C10 | overloaded x2
        public void SignMessage(){} // RVA: 0x7FFACBE51E50 | overloaded x2
        public void VerifyMessage(){} // RVA: 0x7FFACBE520A0 | overloaded x2
    }

    public class VRCFastCrypto_Client : Object
    {
        public string NATIVE_LIB;
        public ulong publicKeyLength;
        public ulong secretKeyLength; // 0x8
        public ulong signatureLength; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9E88960
        public void GetSizes(){} // RVA: 0x7FFAC9E889E0
        public void GenerateSigningKey(){} // RVA: 0x7FFAC9E88A70 | overloaded x2
        public void SignMessage(){} // RVA: 0x7FFAC9E88CB0 | overloaded x2
        public void VerifyMessage(){} // RVA: 0x7FFAC9E88F00 | overloaded x2
    }

    public class ValidationHelpers : Object
    {
        public int BYTES_TO_MB;
        public int CONTENT_WORLD_ASSET_BUNDLE_SIZE_LIMIT_PC;
        public int CONTENT_WORLD_UNCOMPRESSED_ASSET_BUNDLE_SIZE_LIMIT_PC;
        public int CONTENT_AVATAR_ASSET_BUNDLE_SIZE_LIMIT_PC;
        public int CONTENT_AVATAR_UNCOMPRESSED_ASSET_BUNDLE_SIZE_LIMIT_PC;
        public int CONTENT_PROP_ASSET_BUNDLE_SIZE_LIMIT_PC;
        public int CONTENT_PROP_UNCOMPRESSED_ASSET_BUNDLE_SIZE_LIMIT_PC;
        public int CONTENT_WORLD_ASSET_BUNDLE_SIZE_LIMIT_MOBILE;
        public int CONTENT_WORLD_UNCOMPRESSED_ASSET_BUNDLE_SIZE_LIMIT_MOBILE;
        public int CONTENT_AVATAR_ASSET_BUNDLE_SIZE_LIMIT_MOBILE;
        public int CONTENT_AVATAR_UNCOMPRESSED_ASSET_BUNDLE_SIZE_LIMIT_MOBILE;
        public int CONTENT_PROP_ASSET_BUNDLE_SIZE_LIMIT_MOBILE;
        public int CONTENT_PROP_UNCOMPRESSED_ASSET_BUNDLE_SIZE_LIMIT_MOBILE;

        // ── Methods ──
        public void GetAssetBundleSizeLimit(){} // RVA: 0x7FFACC0449F0
        public void GetAssetBundleOverSizeLimitMessage(){} // RVA: 0x7FFACC044AB0 | overloaded x2
        public void GetAssetBundleOverSizeLimitMessageSDKWarning(){} // RVA: 0x7FFACC044DD0
        public void FormatFileSize(){} // RVA: 0x7FFACC045090
    }

}