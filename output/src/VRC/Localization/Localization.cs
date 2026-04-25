// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Localization
// Classes: 9
// Methods: 139

namespace VRC.Localization
{
    public class LocalizableOptionData : ValueType
    {
        public VRC.Localization.LocalizableString LocalizableText; // 0x10
        public UnityEngine.Sprite Image; // 0x38

        // ── Methods ──
        public void GetLanguage(){} // RVA: 0x7FFAC2F4F130
        public void .ctor(){} // RVA: 0x7FFACB232B10 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFAC530B6E0
        public void Equals(){} // RVA: 0x7FFAC530B6E0
        public void set_LocalizableText(){} // RVA: 0x7FFAC2F4F130
        public void get_LocalizableText(){} // RVA: 0x7FFAC530B6E0
        public void get_Image(){} // RVA: 0x7FFAC2F4F130
        public void set_Image(){} // RVA: 0x7FFAC530B6E0
    }

    public class LocalizableString : ValueType
    {
        public string Key;
        public string FallbackText; // 0x10
        public string HasKey; // 0x18
        public object IsLocalized; // 0x20
        public object IsEmpty; // 0x28
        public object _arg2; // 0x30
        public VRC.Localization.LocalizableString Empty;

        // ── Methods ──
        public void op_Equality(){} // RVA: 0x7FFAC8238120
        public void op_Inequality(){} // RVA: 0x7FFAC82381B0
        public void get_Key(){} // RVA: 0x7FFAC3AD9F60
        public void get_FallbackText(){} // RVA: 0x7FFAC8238250
        public void get_HasKey(){} // RVA: 0x7FFAC48C2000
        public void get_IsLocalized(){} // RVA: 0x7FFAC82382A0
        public void get_IsEmpty(){} // RVA: 0x7FFAC82383B0
        public void .ctor(){} // RVA: 0x7FFAC445AE70
        public void ToString(){} // RVA: 0x7FFAC82383E0
        public void Equals(){} // RVA: 0x7FFAC8238440
        public void GetHashCode(){} // RVA: 0x7FFAC8238630
        public void GetTranslation(){} // RVA: 0x7FFAC82386F0
        public void GetFormattedFallbackText(){} // RVA: 0x7FFAC8238940
        public void GetKeyWithoutVariantKey(){} // RVA: 0x7FFAC8238AA0
        public void DoesArgsContain(){} // RVA: 0x7FFAC8238CF0
        public void .cctor(){} // RVA: 0x7FFAC8238F40
        public void <DoesArgsContain>g__Matches|26_0(){} // RVA: 0x7FFAC8239030
    }

    public class LocalizableStringExtensions : Object
    {
        // ── Methods ──
        public void Localize(){} // RVA: 0x7FFAC8239100
        public void LocalizeWithFallback(){} // RVA: 0x7FFAC8239150
        public void LocalizeVariant(){} // RVA: 0x7FFAC8239190
        public void LocalizeVariantWithFallback(){} // RVA: 0x7FFAC8239240
        public void NoTranslation(){} // RVA: 0x7FFAC82392F0
        public void SetNewArgs(){} // RVA: 0x7FFAC82393D0
    }

    public class LocalizableStringFormatter : Object
    {
        public System.Collections.Generic.Stack`1<System.Text.StringBuilder> _formattedStringBuilders;

        // ── Methods ──
        public void GetStringBuilder(){} // RVA: 0x7FFAC8239590
        public void PutStringBuilder(){} // RVA: 0x7FFAC8239730
        public void FormatString(){} // RVA: 0x7FFAC82397D0
        public void .cctor(){} // RVA: 0x7FFAC823A480
    }

    public class LocalizationAssetParser : Object
    {
        public System.Text.StringBuilder TMPBuilder;

        // ── Methods ──
        public void SeparateCSVDataIntoFilesPerLanguage(){} // RVA: 0x7FFAC822D300
        public void SplitCsvLine(){} // RVA: 0x7FFAC822D9C0
        public void CleanString(){} // RVA: 0x7FFAC822DBD0
        public void .cctor(){} // RVA: 0x7FFAC822DE90
        public void <SeparateCSVDataIntoFilesPerLanguage>g__createSplitFile|2_4(){} // RVA: 0x7FFAC822DF50
    }

    public class LocalizationAssetSource : Object
    {
        public string ID;
        public string FolderPath;
        public string Groups;
        public string IDS_FILE_NAME;
        public string CLIENT_STRINGS_GROUP;
        public string API_CONSUMER_STRINGS_GROUP;
        public string DYNAMIC_CONTENT_STRINGS_GROUP;
        public string[] DEFAULT_GROUPS;
        public string <ID>k__BackingField; // 0x10
        public string <FolderPath>k__BackingField; // 0x18
        public string[] <Groups>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC822E930
        public void get_ID(){} // RVA: 0x7FFAC2F3C380
        public void set_ID(){} // RVA: 0x7FFAC2F22E30
        public void get_FolderPath(){} // RVA: 0x7FFAC2F247C0
        public void set_FolderPath(){} // RVA: 0x7FFAC2F87E80
        public void get_Groups(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Groups(){} // RVA: 0x7FFAC2F4F0D0
        public void GetAvailableLanguagesFile(){} // RVA: 0x7FFAC2C588A0
        public void PrepareFiles(){} // RVA: 0x7FFAC2C588A0
        public void GetLanguageFiles(){}
        public void GetTextFile(){}
        public void .cctor(){} // RVA: 0x7FFAC822EAD0
    }

    public class LocalizationDatabase : Object
    {
        public string Instance;
        public System.Collections.Generic.Dictionary`2<string,string> Languages; // 0x10
        public System.Collections.Generic.List`1<string> LanguageCount; // 0x18
        public System.Collections.Generic.HashSet`1<string> KeyCount; // 0x20
        public System.Collections.Generic.List`1<string> Timestamp; // 0x28
        public System.Collections.Generic.List`1<VRC.Localization.LocalizationAssetSource> CurrentLanguage; // 0x30
        public System.Text.StringBuilder IsRTL; // 0x38
        public VRC.Localization.LocalizationDatabase <Instance>k__BackingField;
        public string <Timestamp>k__BackingField; // 0x40
        public string <CurrentLanguage>k__BackingField; // 0x48
        public bool <IsRTL>k__BackingField; // 0x50

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC8230240
        public void set_Instance(){} // RVA: 0x7FFAC8230280
        public void get_Languages(){} // RVA: 0x7FFAC2F247C0
        public void get_LanguageCount(){} // RVA: 0x7FFAC8230320
        public void get_KeyCount(){} // RVA: 0x7FFAC8230370
        public void get_Timestamp(){} // RVA: 0x7FFAC2F9E740
        public void set_Timestamp(){} // RVA: 0x7FFAC2F49200
        public void get_CurrentLanguage(){} // RVA: 0x7FFAC2F9C730
        public void set_CurrentLanguage(){} // RVA: 0x7FFAC2F9C740
        public void get_IsRTL(){} // RVA: 0x7FFAC2FDB8E0
        public void set_IsRTL(){} // RVA: 0x7FFAC2FDB8F0
        public void CreateDefault(){} // RVA: 0x7FFAC82303C0
        public void LoadDefaultAssets(){} // RVA: 0x7FFAC82305F0
        public void LoadLanguage(){} // RVA: 0x7FFAC8230720
        public void AddOrRefreshAsset(){} // RVA: 0x7FFAC82308F0
        public void PrepareAndLoad(){} // RVA: 0x7FFAC8230AB0
        public void LoadAssetLanguage(){} // RVA: 0x7FFAC8230C60
        public void LoadAvailableLanguages(){} // RVA: 0x7FFAC8230E20
        public void LoadFile(){} // RVA: 0x7FFAC8230FE0
        public void MakeStringAndReplaceCustomBlocks(){} // RVA: 0x7FFAC82314B0
        public void HasKey(){} // RVA: 0x7FFAC82316D0
        public void Translate(){} // RVA: 0x7FFAC8231770
        public void IsInvalidated(){} // RVA: 0x7FFAC8231A60
        public void InvalidateCachedKey(){} // RVA: 0x7FFAC8231AC0
        public void FindRichTextTags(){} // RVA: 0x7FFAC8231B30
        public void ReplaceMarkersWithRichTextTags(){} // RVA: 0x7FFAC8231E60
        public void BiDiString(){} // RVA: 0x7FFAC8231F80
        public void .ctor(){} // RVA: 0x7FFAC8232120
    }

    public class LocalizationManager : Object
    {
        public System.Lazy`1<ÌÎÏÍÏÏÍÎÍÍÏÌÎÌÏÍÏÏÌÎÌÏÌ> _name; // 0x10
        public string _hideFlags;
        public ÏÎÎÌÏÏÎÌÎÌÎÍÍÎÏÌÏÎÌÏÎÏÎ<string> f_86E; // 0x18
        public ÏÎÎÌÏÏÎÌÎÌÎÍÍÎÏÌÏÎÌÏÎÏÎ<VRC.Localization.LocalizableString> f_032; // 0x20
        public System.Collections.Generic.List`1<string> f_D44; // 0x28
        public ÌÎÌÌÎÎÍÌÍÍÏÏÏÌÌÌÎÌÏÍÎÍÎ f_B88; // 0x30
        public string f_708;
        public bool <ÌÍÌÎÍÌÏÍÌÍÍÎÎÍÌÏÍÎÏÏÌÎÌ>k__BackingField; // 0x38
        public System.Collections.Generic.Dictionary`2<string,ÌÎÌÌÎÎÍÌÍÍÏÏÏÌÌÌÎÌÏÍÎÍÎ> ÏÍÍÌÎÎÏÌÌÌÌÏÏÌÍÏÍÌÎÎÏÍÍ;
        public System.Collections.Generic.Dictionary`2<string,string> ÌÏÎÌÍÏÏÎÍÎÍÌÎÌÎÌÍÍÎÍÎÍÏ; // 0x8

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC46C3E60
        public void OnPlayerJoined(){} // RVA: 0x7FFAC46C4070
        public void Equals(){} // RVA: 0x7FFAC46C40F0
        public void op_Implicit(){} // RVA: 0x7FFAC46C45F0
        public void CompareBaseObjects(){} // RVA: 0x7FFAC46C46D0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC46C48E0
        public void GetCachedPtr(){} // RVA: 0x7FFAC46C4B40
        public void get_name(){} // RVA: 0x7FFAC46C4C00
        public void set_name(){} // RVA: 0x7FFAC46C4ED0
        public void Instantiate(){} // RVA: 0x7FFAC46C5190
        public void GetHashCode(){} // RVA: 0x7FFAC46C5210
        public void ToString(){} // RVA: 0x7FFAC46C5250
        public void OnPlayerJoined_6DECA2D0F913(){} // RVA: 0x7FFAC2F4F0C0
        public void OnPlayerJoined_impl(){} // RVA: 0x7FFAC46C55C0
        public void Doremove_OnUdonReady(){} // RVA: 0x7FFAC46C5840
        public void Instantiate_43D7E48D9426(){} // RVA: 0x7FFAC46C5BB0
        public void RegisterLocalizationContext(){} // RVA: 0x7FFAC46C5E60
        public void GetOrInitializeCurrentUICulture(){} // RVA: 0x7FFAC46C6120
        public void GetMethod(){} // RVA: 0x7FFAC46C6760
        public void StaticInitialize(){} // RVA: 0x7FFAC46C6840
        public void Destroy(){} // RVA: 0x7FFAC46C6920
        public void Internal_CloneSingle_BCB8BEC580C1_BCB8BEC580C1(){} // RVA: 0x7FFAC46C9FC0 | overloaded x2
        public void GetPlatform(){} // RVA: 0x7FFAC31D95E0
        public void FindObjectsOfType(){} // RVA: 0x7FFAC46C6F80
        public void SetCompletedSynchronously(){} // RVA: 0x7FFAC31D95C0
        public void FindObjectsByType(){} // RVA: 0x7FFAC46C7240
        public void GetLocalizedValue(){} // RVA: 0x7FFAC46C7310
        public void AddUnitNode(){} // RVA: 0x7FFAC2F4F890
        public void get_hideFlags(){} // RVA: 0x7FFAC46C7490
        public void IsResource(){} // RVA: 0x7FFAC31D95D0
        public void GetLocalizedInstance(){} // RVA: 0x7FFAC46C75F0
        public void FindObjectOfType(){} // RVA: 0x7FFAC46C7800
        public void FindFirstObjectByType(){} // RVA: 0x7FFAC46C7960
        public void SetStoreCallback(){} // RVA: 0x7FFAC46C7BA0
        public void GetLanguage(){} // RVA: 0x7FFAC2F4F130
        public void GetInternalData(){} // RVA: 0x7FFAC46C81F0
        public void .cctor(){} // RVA: 0x7FFAC46C8240
        public void StaticInitialize_AFCF7B6F80AC(){} // RVA: 0x7FFAC46C9280
        public void RegisterLocalizationManager(){} // RVA: 0x7FFAC46C97A0
        public void InitializeLocalizationStaticData(){} // RVA: 0x7FFAC46C98C0
        public void .ctor(){} // RVA: 0x7FFAC46C9910
        public void Initialize(){} // RVA: 0x7FFAC46C9D20
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFAC46C9DF0
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFAC46CA120
        public void Internal_InstantiateSingle(){} // RVA: 0x7FFAC46CA3E0
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7FFAC46CA470
        public void ComputeValue(){} // RVA: 0x7FFAC2F247C0
        public void GetName(){} // RVA: 0x7FFAC2F4F890
        public void SetName(){} // RVA: 0x7FFAC46CA7E0
        public void FindObjectFromInstanceID(){} // RVA: 0x7FFAC46CA920
        public void ForceLoadFromInstanceID(){} // RVA: 0x7FFAC46CAB60
        public void GetFileName(){} // RVA: 0x7FFAC46CAC30
    }

    public class ResourcesLocalizationAssetSource : LocalizationAssetSource
    {
        public string BaseFolder; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC822EC00
        public void GetAvailableLanguagesFile(){} // RVA: 0x7FFAC822EE90
        public void PrepareFiles(){} // RVA: 0x7FFAC822F030
        public void GetLanguageFiles(){} // RVA: 0x7FFAC822F090
        public void GetTextFile(){} // RVA: 0x7FFAC822F2A0
    }

}