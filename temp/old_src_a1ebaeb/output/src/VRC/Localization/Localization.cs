// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Localization
// Classes: 9
// Methods: 142

namespace VRC.Localization
{
    public class LocalizableOptionData : ValueType
    {
        // ── Original Methods ──
        public void InternalEquals(){} // RVA: 0x7ffaaad0d640
        public void set_Image(){} // RVA: 0x7ffaaad0d640
        public void get_Image(){} // RVA: 0x7ffaa8960130
        public void InternalGetHashCode(){} // RVA: 0x7ffaaad0d640
        public void Equals(){} // RVA: 0x7ffaa8960130
        public void .ctor(){} // RVA: 0x7ffab0c554d0
        public void .ctor(){} // RVA: 0x7ffab0c554d0
        public void get_LocalizableText(){} // RVA: 0x7ffaaad0d640
        public void set_LocalizableText(){} // RVA: 0x7ffaa8960130
        // ── Binary Analysis Named ──
        public void GetMethod(){} // RVA: 0x7ffaa8960130
        public void GetHashCodeOfPtr(){} // RVA: 0x7ffaaad0d640
        public void GetHashCode(){} // RVA: 0x7ffaa8960130
    }

    public class LocalizableString : ValueType
    {
        public object _fallbackText; // 0x315F3820
        public object _arg2; // 0x315F3820

        // ── Original Methods ──
        public void op_Equality(){} // RVA: 0x7ffaadc592d0
        public void op_Inequality(){} // RVA: 0x7ffaadc59360
        public void get_Key(){} // RVA: 0x7ffaa950bda0
        public void get_FallbackText(){} // RVA: 0x7ffaadc59400
        public void get_HasKey(){} // RVA: 0x7ffaaa2cb5b0
        public void get_IsLocalized(){} // RVA: 0x7ffaadc59450
        public void get_IsEmpty(){} // RVA: 0x7ffaadc59560
        public void .ctor(){} // RVA: 0x7ffaa9e7d020
        public void ToString(){} // RVA: 0x7ffaadc59590
        public void Equals(){} // RVA: 0x7ffaadc595f0
        public void .cctor(){} // RVA: 0x7ffaadc5a0f0
        public void <DoesArgsContain>g__Matches|26_0(){} // RVA: 0x7ffaadc5a1e0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadc597e0
        public void GetTranslation(){} // RVA: 0x7ffaadc598a0
        public void GetFormattedFallbackText(){} // RVA: 0x7ffaadc59af0
        public void GetKeyWithoutVariantKey(){} // RVA: 0x7ffaadc59c50
        public void DoesArgsContain(){} // RVA: 0x7ffaadc59ea0
    }

    public class LocalizableStringExtensions : Object
    {
        // ── Original Methods ──
        public void Localize(){} // RVA: 0x7ffaadc5a2b0
        public void LocalizeWithFallback(){} // RVA: 0x7ffaadc5a300
        public void LocalizeVariant(){} // RVA: 0x7ffaadc5a340
        public void LocalizeVariantWithFallback(){} // RVA: 0x7ffaadc5a3f0
        public void NoTranslation(){} // RVA: 0x7ffaadc5a4a0
        // ── Binary Analysis Named ──
        public void SetNewArgs(){} // RVA: 0x7ffaadc5a580
    }

    public class LocalizableStringFormatter : Object
    {
        // ── Original Methods ──
        public void PutStringBuilder(){} // RVA: 0x7ffaadc5a8e0
        public void FormatString(){} // RVA: 0x7ffaadc5a980
        public void .cctor(){} // RVA: 0x7ffaadc5b630
        // ── Binary Analysis Named ──
        public void GetStringBuilder(){} // RVA: 0x7ffaadc5a740
    }

    public class LocalizationAssetParser : Object
    {
        // ── Original Methods ──
        public void SeparateCSVDataIntoFilesPerLanguage(){} // RVA: 0x7ffaadc4e4b0
        public void SplitCsvLine(){} // RVA: 0x7ffaadc4eb70
        public void CleanString(){} // RVA: 0x7ffaadc4ed80
        public void .cctor(){} // RVA: 0x7ffaadc4f040
        public void <SeparateCSVDataIntoFilesPerLanguage>g__createSplitFile|2_4(){} // RVA: 0x7ffaadc4f100
    }

    public class LocalizationAssetSource : Object
    {
        public object KEYS_FILE_NAME; // 0x336F7B70
        public object API_CONSUMER_STRINGS_GROUP; // 0x336F7B70
        public object _iD; // 0x336F7B70, was: <ID>k__BackingField

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadc4fae0
        public void get_ID(){} // RVA: 0x7ffaa894d380
        public void set_ID(){} // RVA: 0x7ffaa8933e30
        public void get_FolderPath(){} // RVA: 0x7ffaa89357c0
        public void set_FolderPath(){} // RVA: 0x7ffaa8998e80
        public void get_Groups(){} // RVA: 0x7ffaa89600c0
        public void set_Groups(){} // RVA: 0x7ffaa89600d0
        public void PrepareFiles(){} // RVA: 0x7ffaa8648be0
        public void .cctor(){} // RVA: 0x7ffaadc4fc80
        // ── Binary Analysis Named ──
        public void GetAvailableLanguagesFile(){} // RVA: 0x7ffaa8648be0
        public void GetLanguageFiles(){}
        public void GetTextFile(){}
    }

    public class LocalizationDatabase : Object
    {
        public object _languages; // 0x33416000
        public object _loadedAssetSources; // 0x33416000
        public object _timestamp; // 0x33416000, was: <Timestamp>k__BackingField

        // ── Original Methods ──
        public void get_Instance(){} // RVA: 0x7ffaadc513f0
        public void set_Instance(){} // RVA: 0x7ffaadc51430
        public void get_Languages(){} // RVA: 0x7ffaa89357c0
        public void get_LanguageCount(){} // RVA: 0x7ffaadc514d0
        public void get_KeyCount(){} // RVA: 0x7ffaadc51520
        public void get_Timestamp(){} // RVA: 0x7ffaa89af740
        public void set_Timestamp(){} // RVA: 0x7ffaa895a200
        public void get_CurrentLanguage(){} // RVA: 0x7ffaa89ad730
        public void set_CurrentLanguage(){} // RVA: 0x7ffaa89ad740
        public void get_IsRTL(){} // RVA: 0x7ffaa89ec8e0
        public void set_IsRTL(){} // RVA: 0x7ffaa89ec8f0
        public void CreateDefault(){} // RVA: 0x7ffaadc51570
        public void LoadDefaultAssets(){} // RVA: 0x7ffaadc517a0
        public void LoadLanguage(){} // RVA: 0x7ffaadc518d0
        public void AddOrRefreshAsset(){} // RVA: 0x7ffaadc51aa0
        public void PrepareAndLoad(){} // RVA: 0x7ffaadc51c60
        public void LoadAssetLanguage(){} // RVA: 0x7ffaadc51e10
        public void LoadAvailableLanguages(){} // RVA: 0x7ffaadc51fd0
        public void LoadFile(){} // RVA: 0x7ffaadc52190
        public void MakeStringAndReplaceCustomBlocks(){} // RVA: 0x7ffaadc52660
        public void HasKey(){} // RVA: 0x7ffaadc52880
        public void Translate(){} // RVA: 0x7ffaadc52920
        public void IsInvalidated(){} // RVA: 0x7ffaadc52c10
        public void InvalidateCachedKey(){} // RVA: 0x7ffaadc52c70
        public void FindRichTextTags(){} // RVA: 0x7ffaadc52ce0
        public void ReplaceMarkersWithRichTextTags(){} // RVA: 0x7ffaadc53010
        public void BiDiString(){} // RVA: 0x7ffaadc53130
        public void .ctor(){} // RVA: 0x7ffaadc532d0
    }

    public class LocalizationManager : Object
    {
        public object _objectIsNullMessage; // 0x3345CD10, was: ÍÍÍÏÌÏÏÌÎÌÎÍÏÌÌÎÍÏÍÏÍÎÌ
        public object _name; // 0x3345CD10, was: <ÍÌÌÍÍÏÍÏÌÍÍÏÍÎÏÏÏÏÏÎÌÌÍ>k__Ba
        public object f_1F1; // 0x3345CD10, was: ÎÎÎÌÏÍÏÎÍÏÎÍÏÏÎÎÎÌÌÏÎÏÏ

        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaaa0e7a20
        public void OnPlayerJoined(){} // RVA: 0x7ffaaa0e7c30
        public void op_Implicit(){} // RVA: 0x7ffaaa0e7cb0
        public void CompareBaseObjects(){} // RVA: 0x7ffaaa0e81d0
        public void StaticInitialize(){} // RVA: 0x7ffaaa0e8430
        public void .ctor(){} // RVA: 0x7ffaaa0e8510
        public void Initialize(){} // RVA: 0x7ffaaa0e8920
        public void FindFirstObjectByType(){} // RVA: 0x7ffaaa0ec0b0
        public void IsResource(){} // RVA: 0x7ffaa8bfcc70
        public void ToString(){} // RVA: 0x7ffaaa0e9580
        public void OnPlayerJoined_impl(){} // RVA: 0x7ffaaa0e9660
        public void Instantiate(){} // RVA: 0x7ffaaa0e99d0
        public void RegisterLocalizationContext(){} // RVA: 0x7ffaaa0e9b50
        public void Destroy(){} // RVA: 0x7ffaaa0e9d20
        public void .cctor(){} // RVA: 0x7ffaaa0e9fd0
        public void DestroyImmediate(){} // RVA: 0x7ffaaa0eb010
        public void InitializeLocalizationData(){} // RVA: 0x7ffaaa0eb0f0
        public void FindObjectsOfType(){} // RVA: 0x7ffaaa0eb370
        public void InitializeLocalizationState(){} // RVA: 0x7ffaaa0eb490
        public void FindObjectsByType(){} // RVA: 0x7ffaaa0eb9f0
        public void get_hideFlags(){} // RVA: 0x7ffaaa0ebc20
        public void set_hideFlags(){} // RVA: 0x7ffaaa0ebef0
        public void FindObjectOfType(){} // RVA: 0x7ffaaa0ebef0
        public void FindFirstObjectByType(){} // RVA: 0x7ffaaa0ec0b0
        public void ProcessLocalizationData(){} // RVA: 0x7ffaaa0ec450
        public void RegisterLocalizationManager(){} // RVA: 0x7ffaaa0ec7c0
        public void InitializeLocalizationStaticData(){} // RVA: 0x7ffaaa0ec900
        public void op_Equality(){} // RVA: 0x7ffaaa0ecbc0
        public void op_Inequality(){} // RVA: 0x7ffaaa0ecf30
        public void Internal_CloneSingle(){} // RVA: 0x7ffaaa0ed640
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7ffaaa0ed680
        public void Internal_InstantiateSingle(){} // RVA: 0x7ffaaa0ed850
        public void ComputeValue(){} // RVA: 0x7ffaaa0edba0
        public void FindObjectFromInstanceID(){} // RVA: 0x7ffaaa0edd00
        public void ForceLoadFromInstanceID(){} // RVA: 0x7ffaaa0ede20
        // ── Binary Analysis Named ──
        public void GetInstanceID(){} // RVA: 0x7ffaaa0e77e0
        public void DoGetCurrentUICultureNoAppX(){} // RVA: 0x7ffaaa0e89f0
        public void GetHashCode(){} // RVA: 0x7ffaaa0e92c0
        public void Doremove_OnUdonReady(){} // RVA: 0x7ffaaa0e9850
        public void GetOrInitializeCurrentUICulture(){} // RVA: 0x7ffaaa0e9cd0
        public void GetMethod(){} // RVA: 0x7ffaa8960130
        public void GetLocalizedValue(){} // RVA: 0x7ffaaa0eba70
        public void DontDestroyOnLoad(){} // RVA: 0x7ffaaa0ebb50
        public void GetLocalizedInstance(){} // RVA: 0x7ffaaa0ebff0
        public void SetStoreCallback(){} // RVA: 0x7ffaa8960890
        public void CheckNullArgument(){} // RVA: 0x7ffaaa0ec210
        public void GetInternalData(){} // RVA: 0x7ffaa89357c0
        public void SetCompletedSynchronously(){} // RVA: 0x7ffaa8bfbbe0
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7ffaaa0ed140
        public void DoConstructCurrentCulture(){} // RVA: 0x7ffaaa0edb10
        public void GetName(){} // RVA: 0x7ffaa89600c0
        public void SetName(){} // RVA: 0x7ffaa8960130
        public void GetFileName(){} // RVA: 0x7ffaa8bfcc80
    }

    public class ResourcesLocalizationAssetSource : LocalizationAssetSource
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadc4fdb0
        public void PrepareFiles(){} // RVA: 0x7ffaadc501e0
        // ── Binary Analysis Named ──
        public void GetAvailableLanguagesFile(){} // RVA: 0x7ffaadc50040
        public void GetLanguageFiles(){} // RVA: 0x7ffaadc50240
        public void GetTextFile(){} // RVA: 0x7ffaadc50450
    }

}