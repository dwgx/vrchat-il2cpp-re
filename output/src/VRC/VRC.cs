// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC
// Classes: 13
// Methods: 183

namespace VRC
{
    public class AssetCache : Object
    {
        public System.Collections.Generic.List`1<ÎÏÏÍÍÍÏÎÎÏÎÎÎÎÍÌÎÌÍÍÌÏÏ> _assetCache; // 0x10
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.IList> <ÌÍÏÎÎÍÎÍÏÍÍÌÌÏÏÏÎÏÌÏÍÎÍ>k__BackingField; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4E3447C0
        public void Init(){} // RVA: 0x7FFD4E3A7E80
        public void Equals(){} // RVA: 0x7FFD4E3A7E80
        public void op_Implicit(){} // RVA: 0x7FFD4FA6FAE0
        public void CompareBaseObjects(){} // RVA: 0x7FFD4FA6FE40
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4FA701A0
        public void Initialize(){} // RVA: 0x7FFD4FA70200
        public void get_name(){} // RVA: 0x7FFD4FA70270
        public void set_name(){} // RVA: 0x7FFD4FA703F0
        public void .ctor(){} // RVA: 0x7FFD4FA70540
        public void Instantiate(){} // RVA: 0x7FFD4FA707E0
        public void GetHashCode(){} // RVA: 0x7FFD4E3447C0
        public void ToString(){} // RVA: 0x7FFD4FA70850
        public void ProcessChildTransforms(){} // RVA: 0x7FFD4FA701A0
        public void Initialize_1B5EA1659B63(){} // RVA: 0x7FFD4FA70950
        public void op_Implicit_F3F4686A1091(){} // RVA: 0x7FFD4FA709C0
    }

    public class BackgroundOption : Object
    {
        public VRC.Localization.LocalizableString IsLoaded; // 0x10
        public string BackgroundName; // 0x38
        public UnityEngine.Sprite Preview; // 0x40
        public bool IsVRCPlus; // 0x48
        public UnityEngine.Material _loadedMaterial; // 0x50

        // ── Methods ──
        public void set_IsLoaded(){} // RVA: 0x7FFD4F9DEBF0
        public void get_IsLoaded(){} // RVA: 0x7FFD4F9DEC70
        public void get_IsVRCPlus(){} // RVA: 0x7FFD4E3F8D30
        public void set_IsVRCPlus(){} // RVA: 0x7FFD4F9DED40
        public void get_Preview(){} // RVA: 0x7FFD4E3BE740
        public void get_hidden(){} // RVA: 0x7FFD4E3F8D30
        public void GetCachedPtr(){} // RVA: 0x7FFD4F9DEDF0
        public void get_name(){} // RVA: 0x7FFD4E3F8D30
        public void get_DisplayName(){} // RVA: 0x7FFD4EC33C20
        public void Instantiate(){} // RVA: 0x7FFD4E3F8D30
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_BackgroundName(){} // RVA: 0x7FFD4EC33C20
        public void set_BackgroundName(){} // RVA: 0x7FFD4EC33C20
    }

    public class BackgroundOptions : ScriptableObject
    {
        public VRC.BackgroundOption[] Options; // 0x18

        // ── Methods ──
        public void set_Options(){} // RVA: 0x7FFD4E3447C0
        public void get_Options(){} // RVA: 0x7FFD4E3447C0
        public void CreateInstance(){} // RVA: 0x7FFD4E3447C0
        public void CreateScriptableObject(){} // RVA: 0x7FFD4E3447C0
        public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7FFD4E3447C0
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
        public void Initialize(){} // RVA: 0x7FFD4E3447C0
        public void Equals(){} // RVA: 0x7FFD4E3447C0
        public void GetHashCode(){} // RVA: 0x7FFD4E3447C0
        public void ToString(){} // RVA: 0x7FFD4E3447C0
    }

    public class ClientPlayerLoop : Object
    {
        public System.Action ÌÍÌÏÏÍÌÌÏÎÏÏÍÏÏÌÏÏÍÏÍÌÌ;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4FA177E0
        public void Equals(){} // RVA: 0x7FFD4FA178F0
        public void Initialize(){} // RVA: 0x7FFD4FA17A00
        public void op_Implicit(){} // RVA: 0x7FFD4FA17CD0
        public void CompareBaseObjects(){} // RVA: 0x7FFD4FA17E80
    }

    public class GiftDisplayReferences : ScriptableObject
    {
        public GiftDisplayReference[] giftDisplayReferences; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4F9F82F0
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
        public void Initialize(){} // RVA: 0x7FFD4F9F8390
        public void CreateScriptableObject(){} // RVA: 0x7FFD4F9F8430
        public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7FFD4F9F84F0
        public void GetHashCode(){} // RVA: 0x7FFD4F9F82F0
        public void ToString(){} // RVA: 0x7FFD4F9F8430
        public void .ctor_53F7ECC03924(){} // RVA: 0x7FFD4F9F82F0
        public void DoSlerp_Injected_D6B(){} // RVA: 0x7FFD4F9F84F0
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
        public void Awake(){} // RVA: 0x7FFD5527A470
        public void OnDestroy(){} // RVA: 0x7FFD5527A690
        public void OnDraw(){} // RVA: 0x7FFD5527A880
        public void Draw(){} // RVA: 0x7FFD5527AAB0
        public void Clear(){} // RVA: 0x7FFD5527AB90
        public void UpdateCommandBuffers(){} // RVA: 0x7FFD5527AC10
        public void BuildCommandBuffer(){} // RVA: 0x7FFD5527AD10
        public void Line2D(){} // RVA: 0x7FFD5527ADB0
        public void Line3D(){} // RVA: 0x7FFD5527B050 | overloaded x2
        public void Sphere(){} // RVA: 0x7FFD5527B280 | overloaded x2
        public void Capsule(){} // RVA: 0x7FFD5527B4C0 | overloaded x2
        public void Cone(){} // RVA: 0x7FFD5527B6A0 | overloaded x2
        public void WireSquare3D(){} // RVA: 0x7FFD5527B800
        public void WireCube3D(){} // RVA: 0x7FFD5527C2E0 | overloaded x2
        public void WireCircle3D(){} // RVA: 0x7FFD5527CB30
        public void WireArc3D(){} // RVA: 0x7FFD5527D1D0
        public void .ctor(){} // RVA: 0x7FFD5527D890
    }

    public class InputLatencyTracker : Object
    {
        public System.Diagnostics.Stopwatch _inputLatencyTracker;
        public bool ÌÎÏÌÏÌÌÌÎÎÏÍÌÌÏÌÎÎÌÏÏÏÎ; // 0x8
        public float ÏÎÎÏÎÏÏÌÍÏÍÏÍÍÌÌÍÍÎÎÌÏÎ; // 0xC
        public object ÏÌÎÎÍÌÌÏÏÏÎÏÍÏÏÏÍÎÎÍÌÎÏ; // 0x10

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD4FA17EE0
        public void Equals(){} // RVA: 0x7FFD4FA180B0
        public void GetHashCode(){} // RVA: 0x7FFD4FA18370
        public void op_Implicit(){} // RVA: 0x7FFD4FA18590
        public void CompareBaseObjects(){} // RVA: 0x7FFD4FA18760
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4FA188A0
        public void .cctor(){} // RVA: 0x7FFD4FA18940
    }

    public class PlayerLoopUtility : Object
    {
        // ── Methods ──
        public void AddNewSystem(){} // RVA: 0x7FFD4E09B2F0
        public void RemoveExistingSystem(){} // RVA: 0x7FFD5726F910
        public void MoveExistingSystem(){} // RVA: 0x7FFD5726FD90
        public void GetLoopIndexByType(){} // RVA: 0x7FFD57270A40
    }

    public class StickerCollectionPrefab : ScriptableObject
    {
        public UnityEngine.Sprite icon; // 0x18
        public VRC.StickerPrefab[] stickers; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
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
        public void get_IsAnimated(){} // RVA: 0x7FFD4E42F9D0
        public void get_Frames(){} // RVA: 0x7FFD4ED41980
        public void set_DisplayTexture(){} // RVA: 0x7FFD4E3BC740
        public void get_DisplayTexture(){} // RVA: 0x7FFD4E3BC730
        public void get_MaskTag(){} // RVA: 0x7FFD4E919180
        public void get_FileId(){} // RVA: 0x7FFD4E919180
        public void set_CollectionID(){} // RVA: 0x7FFD4E369200
        public void set_LinearLoop(){} // RVA: 0x7FFD4FA0F750
        public void get_LinearLoop(){} // RVA: 0x7FFD4FA0F8F0
        public void set_FullResolutionTexture(){} // RVA: 0x7FFD4E4994D0
        public void GetSessionId(){} // RVA: 0x7FFD4E5F0140
        public void get_Sprite(){} // RVA: 0x7FFD4E5F0140
        public void set_ID(){} // RVA: 0x7FFD4FA0F970
        public void .ctor(){} // RVA: 0x7FFD4FA0F9B0
        public void SetModelAlphaBlendShader(){} // RVA: 0x7FFD4E4994D0
        public void get_ID(){} // RVA: 0x7FFD4E563DB0
        public void get_IsBuiltIn(){} // RVA: 0x7FFD4E426850
        public void set_IsBuiltIn(){} // RVA: 0x7FFD4E4994D0
        public void get_FPS(){} // RVA: 0x7FFD4E70C4C0
        public void get_FullResolutionTexture(){} // RVA: 0x7FFD4E3E20E0
        public void get_EffectBundleID(){} // RVA: 0x7FFD4FA0FA40
        public void get_LoopStyle(){} // RVA: 0x7FFD4E5F95E0
        public void set_Sprite(){} // RVA: 0x7FFD4E5F0C20
        public void set_EffectBundleID(){} // RVA: 0x7FFD4FA0FA80
        public void set_IsSpecialFX(){} // RVA: 0x7FFD4E919180
        public void get_IsSpecialFX(){} // RVA: 0x7FFD4E341320
        public void get_CollectionID(){} // RVA: 0x7FFD4E3BE740
        public void Equals(){} // RVA: 0x7FFD4E919180
        public void GetHashCode(){} // RVA: 0x7FFD4FA0FAD0
        public void ToString(){} // RVA: 0x7FFD4FA0FE10
    }

    public class SystemsPlayerLoop : Object
    {
        public bool _initialized;
        public System.Action OnAvatarClone; // 0x8
        public System.Action OnAvatarHeadChop; // 0x10

        // ── Methods ──
        public void add_OnAvatarClone(){} // RVA: 0x7FFD57270CB0
        public void remove_OnAvatarClone(){} // RVA: 0x7FFD57270DC0
        public void add_OnAvatarHeadChop(){} // RVA: 0x7FFD57270ED0
        public void remove_OnAvatarHeadChop(){} // RVA: 0x7FFD57270FE0
        public void Initialize(){} // RVA: 0x7FFD572710F0
        public void FixConstraints(){} // RVA: 0x7FFD572711A0
        public void SetupDynamicsLoops(){} // RVA: 0x7FFD572713D0
        public void OnVRCConstraintsUpdate(){} // RVA: 0x7FFD57271910
        public void OnAvatarDynamicsPreSchedule(){} // RVA: 0x7FFD572719A0
        public void OnAvatarDynamicsPostSchedule(){} // RVA: 0x7FFD572719F0
        public void OnAvatarDynamicsComplete(){} // RVA: 0x7FFD57271AB0
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
        public void get_isClient(){} // RVA: 0x7FFD57272530
        public void SetGameServerVersion(){} // RVA: 0x7FFD572725B0
        public void get_GameServerVersion(){} // RVA: 0x7FFD57272670
        public void get_ClientVersion(){} // RVA: 0x7FFD572726D0
        public void get_SdkVersion(){} // RVA: 0x7FFD57272850
        public void get_UnityVersion(){} // RVA: 0x7FFD572728B0
        public void get_Platform(){} // RVA: 0x7FFD57272A30
        public void SetLayerRecursively(){} // RVA: 0x7FFD57272CD0
        public void SetLayerRecursivelyExceptMask(){} // RVA: 0x7FFD57272D60
        public void GetOrDefaultFromDictionary(){} // RVA: 0x7FFD572730F0
        public void ArrToString(){} // RVA: 0x7FFD57273170
        public void ListToString(){} // RVA: 0x7FFD57273240
        public void ScrambledEquals(){} // RVA: 0x7FFD4E07A350
        public void ObjListToStringList(){} // RVA: 0x7FFD572734B0
        public void ObjDictToStringDict(){} // RVA: 0x7FFD57273730
        public void GetGameObjectPath(){} // RVA: 0x7FFD572739F0
        public void CombineHashCodes(){} // RVA: 0x7FFD57273D40
        public void GetRandomDigits(){} // RVA: 0x7FFD57273D50
        public void GetRandomHex(){} // RVA: 0x7FFD57273EC0
        public void Truncate(){} // RVA: 0x7FFD57274070
        public void IsValidURL(){} // RVA: 0x7FFD572740F0
        public void IsAllowedUrl(){} // RVA: 0x7FFD572741F0
        public void ClearUserData(){} // RVA: 0x7FFD572749C0
        public void ClearCookies(){} // RVA: 0x7FFD57274B40
        public void UnixTimeStampToDateTime(){} // RVA: 0x7FFD57274B90
        public void FindSceneObjectsOfTypeAll(){} // RVA: 0x7FFD57274C80 | overloaded x2
        public void TwoDArrayToOneDArray(){} // RVA: 0x7FFD4E078F80
        public void OneDArrayToTwoDArray(){} // RVA: 0x7FFD4E089F10
        public void GetNumReservedLayers(){} // RVA: 0x7FFD4E5919D0
        public void GetReservedLayers(){} // RVA: 0x7FFD57274EC0
        public void ClearExpiredBestHTTPCache(){} // RVA: 0x7FFD57275000
        public void GetTempFolderPath(){} // RVA: 0x7FFD57275140
        public void GetTempFileName(){} // RVA: 0x7FFD57275210
        public void FileCanRead(){} // RVA: 0x7FFD572755C0 | overloaded x2
        public void FileCopy(){} // RVA: 0x7FFD572756C0
        public void FileMove(){} // RVA: 0x7FFD572757A0
        public void DivideSafe(){} // RVA: 0x7FFD57275880
        public void GetFileSize(){} // RVA: 0x7FFD572758A0
        public void FileMD5(){} // RVA: 0x7FFD572759E0
        public void StringToMD5(){} // RVA: 0x7FFD57275B20
        public void JsonEncode(){} // RVA: 0x7FFD57275E90
        public void JsonDecode(){} // RVA: 0x7FFD57275F50
        public void IsProton(){} // RVA: 0x7FFD57275FF0
        public void FindComponentInPossibleClones(){} // RVA: 0x7FFD572760A0
        public void .cctor(){} // RVA: 0x7FFD57276220
    }

    public class VRCFastCrypto_Client : Object
    {
        public string NATIVE_LIB;
        public ulong publicKeyLength;
        public ulong secretKeyLength; // 0x8
        public ulong signatureLength; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD552A8960
        public void GetSizes(){} // RVA: 0x7FFD552A89E0
        public void GenerateSigningKey(){} // RVA: 0x7FFD552A8A70 | overloaded x2
        public void SignMessage(){} // RVA: 0x7FFD552A8CB0 | overloaded x2
        public void VerifyMessage(){} // RVA: 0x7FFD552A8F00 | overloaded x2
    }

}