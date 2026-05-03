// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Localization
// Classes: 9
// Methods: 140

namespace VRC.Localization
{
    public class LocalizableOptionData : ValueType
    {
        public VRC.Localization.LocalizableString _localizableText; // 0x10
        public UnityEngine.Sprite _image; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE835C2620
        public void InternalEquals(){} // RVA: 0x7FFE81129130
        public void DefaultEquals(){} // RVA: 0x7FFE835C2620
        public void .ctor(){} // RVA: 0x7FFE895F20F0 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFE81129130
        public void set_LocalizableText(){} // RVA: 0x7FFE835C2620
        public void get_LocalizableText(){} // RVA: 0x7FFE835C2620
        public void GetHashCode(){} // RVA: 0x7FFE81129130
        public void get_Image(){} // RVA: 0x7FFE81129130
        public void set_Image(){} // RVA: 0x7FFE835C2620
    }

    public class LocalizableString : ValueType
    {
        public string VARIANT_KEY_SEPARATOR;
        public string _localizationKey; // 0x10
        public string _fallbackText; // 0x18
        public object _arg0; // 0x20
        public object _arg1; // 0x28

        // ── Methods ──
        public void op_Equality(){} // RVA: 0x7FFE865E1A60
        public void op_Inequality(){} // RVA: 0x7FFE865E1AF0
        public void get_Key(){} // RVA: 0x7FFE8284EF60
        public void get_FallbackText(){} // RVA: 0x7FFE865E1B90
        public void get_HasKey(){} // RVA: 0x7FFE82B2C8E0
        public void get_IsLocalized(){} // RVA: 0x7FFE865E1BE0
        public void get_IsEmpty(){} // RVA: 0x7FFE865E1CF0
        public void .ctor(){} // RVA: 0x7FFE8274B710
        public void ToString(){} // RVA: 0x7FFE865E1D20
        public void Equals(){} // RVA: 0x7FFE865E1D80
        public void GetHashCode(){} // RVA: 0x7FFE865E1F70
        public void GetTranslation(){} // RVA: 0x7FFE865E2030
        public void GetFormattedFallbackText(){} // RVA: 0x7FFE865E2280
        public void GetKeyWithoutVariantKey(){} // RVA: 0x7FFE865E23E0
        public void DoesArgsContain(){} // RVA: 0x7FFE865E2630
        public void .cctor(){} // RVA: 0x7FFE865E2880
        public void <DoesArgsContain>g__Matches|26_0(){} // RVA: 0x7FFE865E2970
    }

    public class LocalizableStringExtensions : Object
    {
        // ── Methods ──
        public void Localize(){} // RVA: 0x7FFE865E2A40
        public void LocalizeWithFallback(){} // RVA: 0x7FFE865E2A90
        public void LocalizeVariant(){} // RVA: 0x7FFE865E2AD0
        public void LocalizeVariantWithFallback(){} // RVA: 0x7FFE865E2B80
        public void NoTranslation(){} // RVA: 0x7FFE865E2C30
        public void SetNewArgs(){} // RVA: 0x7FFE865E2D10
    }

    public class LocalizableStringFormatter : Object
    {
        // ── Methods ──
        public void GetStringBuilder(){} // RVA: 0x7FFE865E2ED0
        public void PutStringBuilder(){} // RVA: 0x7FFE865E3070
        public void FormatString(){} // RVA: 0x7FFE865E3110
        public void .cctor(){} // RVA: 0x7FFE865E3DC0
    }

    public class LocalizationAssetParser : Object
    {
        // ── Methods ──
        public void SeparateCSVDataIntoFilesPerLanguage(){} // RVA: 0x7FFE865D6C40
        public void SplitCsvLine(){} // RVA: 0x7FFE865D7300
        public void CleanString(){} // RVA: 0x7FFE865D7510
        public void .cctor(){} // RVA: 0x7FFE865D77D0
        public void <SeparateCSVDataIntoFilesPerLanguage>g__createSplitFile|2_4(){} // RVA: 0x7FFE865D7890
    }

    public class LocalizationAssetSource : Object
    {
        public string BASE_FOLDER_NAME;
        public string LANGUAGES_FILE_NAME;
        public string KEYS_FILE_NAME;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865D8270
        public void get_ID(){} // RVA: 0x7FFE81116380
        public void set_ID(){} // RVA: 0x7FFE810FCE30
        public void get_FolderPath(){} // RVA: 0x7FFE810FE7C0
        public void set_FolderPath(){} // RVA: 0x7FFE81161E80
        public void get_Groups(){} // RVA: 0x7FFE811290C0
        public void set_Groups(){} // RVA: 0x7FFE811290D0
        public void GetAvailableLanguagesFile(){} // RVA: 0x7FFE80E2DCF0
        public void PrepareFiles(){} // RVA: 0x7FFE80E2DCF0
        public void GetLanguageFiles(){}
        public void GetTextFile(){}
        public void .cctor(){} // RVA: 0x7FFE865D8410
    }

    public class LocalizationDatabase : Object
    {
        public string DEFAULT_LANGUAGE;
        public System.Collections.Generic.Dictionary`2<string,string> _currentLanguageDictionary; // 0x10
        public System.Collections.Generic.List`1<string> _languages; // 0x18
        public System.Collections.Generic.HashSet`1<string> _invalidKeysCache; // 0x20
        public System.Collections.Generic.List`1<string> _richTextTags; // 0x28
        public System.Collections.Generic.List`1<VRC.Localization.LocalizationAssetSource> _loadedAssetSources; // 0x30
        public System.Text.StringBuilder TMPBuilder; // 0x38

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE865D9B80
        public void set_Instance(){} // RVA: 0x7FFE865D9BC0
        public void get_Languages(){} // RVA: 0x7FFE810FE7C0
        public void get_LanguageCount(){} // RVA: 0x7FFE865D9C60
        public void get_KeyCount(){} // RVA: 0x7FFE865D9CB0
        public void get_Timestamp(){} // RVA: 0x7FFE81178740
        public void set_Timestamp(){} // RVA: 0x7FFE81123200
        public void get_CurrentLanguage(){} // RVA: 0x7FFE81176730
        public void set_CurrentLanguage(){} // RVA: 0x7FFE81176740
        public void get_IsRTL(){} // RVA: 0x7FFE811B58E0
        public void set_IsRTL(){} // RVA: 0x7FFE811B58F0
        public void CreateDefault(){} // RVA: 0x7FFE865D9D00
        public void LoadDefaultAssets(){} // RVA: 0x7FFE865D9F30
        public void LoadLanguage(){} // RVA: 0x7FFE865DA060
        public void AddOrRefreshAsset(){} // RVA: 0x7FFE865DA230
        public void PrepareAndLoad(){} // RVA: 0x7FFE865DA3F0
        public void LoadAssetLanguage(){} // RVA: 0x7FFE865DA5A0
        public void LoadAvailableLanguages(){} // RVA: 0x7FFE865DA760
        public void LoadFile(){} // RVA: 0x7FFE865DA920
        public void MakeStringAndReplaceCustomBlocks(){} // RVA: 0x7FFE865DADF0
        public void HasKey(){} // RVA: 0x7FFE865DB010
        public void Translate(){} // RVA: 0x7FFE865DB0B0
        public void IsInvalidated(){} // RVA: 0x7FFE865DB3A0
        public void InvalidateCachedKey(){} // RVA: 0x7FFE865DB400
        public void FindRichTextTags(){} // RVA: 0x7FFE865DB470
        public void ReplaceMarkersWithRichTextTags(){} // RVA: 0x7FFE865DB7A0
        public void BiDiString(){} // RVA: 0x7FFE865DB8C0
        public void .ctor(){} // RVA: 0x7FFE865DBA60
    }

    public class LocalizationManager : Object
    {
        public System.Lazy`1<ÎÍÍÎÏÎÎÍÏÍÌÏÌÌÎÍÌÏÍÏÎÎÍ> _m_CachedPtr; // 0x10
        public string _offsetOfInstanceIDInCPlusPlusObject;
        public ÏÍÍÍÌÏÏÏÏÏÍÍÌÏÎÏÎÎÎÍÌÎÍ<string> f_B59; // 0x18
        public ÏÍÍÍÌÏÏÏÏÏÍÍÌÏÎÏÎÎÎÍÌÎÍ<VRC.Localization.LocalizableString> f_F88; // 0x20
        public System.Collections.Generic.List`1<string> f_C7B; // 0x28
        public ÎÍÎÌÍÏÏÏÏÏÌÍÏÎÎÌÎÏÏÌÏÍÏ f_708; // 0x30
        public string f_C1A;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE829CD8D0
        public void Equals(){} // RVA: 0x7FFE829CDAC0
        public void GetHashCode(){} // RVA: 0x7FFE812CF770
        public void op_Implicit(){} // RVA: 0x7FFE829CDE30
        public void .cctor(){} // RVA: 0x7FFE829CE0E0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE829CF120
        public void GetCachedPtr(){} // RVA: 0x7FFE829CF160
        public void get_name(){} // RVA: 0x7FFE829CF2E0
        public void set_name(){} // RVA: 0x7FFE829CF4B0
        public void Instantiate(){} // RVA: 0x7FFE829CF730
        public void ToString(){} // RVA: 0x7FFE829CFA00
        public void GetLocalizedString(){} // RVA: 0x7FFE829CFF20
        public void SetLanguage(){} // RVA: 0x7FFE829D01E0
        public void LoadLanguagePack(){} // RVA: 0x7FFE829D02B0
        public void GetCurrentLanguage(){} // RVA: 0x7FFE811290C0
        public void RegisterLocalizedComponent(){} // RVA: 0x7FFE829D0390
        public void StaticInitialize(){} // RVA: 0x7FFE829D0410
        public void OnPlayerJoined(){} // RVA: 0x7FFE829D04F0
        public void UnregisterLocalizedComponent(){} // RVA: 0x7FFE829D0570
        public void Internal_CloneSingle(){} // RVA: 0x7FFE829D3270 | overloaded x2
        public void Destroy(){} // RVA: 0x7FFE829D0CB0
        public void DestroyImmediate(){} // RVA: 0x7FFE829D11B0
        public void ReloadLocalizations(){} // RVA: 0x7FFE81129130
        public void FindObjectsOfType(){} // RVA: 0x7FFE812D0010
        public void FormatLocalizedString(){} // RVA: 0x7FFE829D1240
        public void FindObjectsByType(){} // RVA: 0x7FFE829D17A0
        public void HasLocalizationKey(){} // RVA: 0x7FFE829D1900
        public void DontDestroyOnLoad(){} // RVA: 0x7FFE829D1AA0
        public void get_hideFlags(){} // RVA: 0x7FFE829D1CE0
        public void set_hideFlags(){} // RVA: 0x7FFE829D1E00
        public void GetSupportedLanguages(){} // RVA: 0x7FFE81129890
        public void FindObjectOfType(){} // RVA: 0x7FFE829D1E90
        public void FindFirstObjectByType(){} // RVA: 0x7FFE829D1F60
        public void OnLanguageChanged(){} // RVA: 0x7FFE829D2100
        public void CheckNullArgument(){} // RVA: 0x7FFE829D23C0
        public void ApplyLocalizationToText(){} // RVA: 0x7FFE829D2730
        public void InvalidateLocalizationCache(){} // RVA: 0x7FFE829D2870
        public void GetLocalizedFormat(){} // RVA: 0x7FFE829D2A80
        public void ResolveLanguageCode(){} // RVA: 0x7FFE8144E200
        public void BroadcastLanguageChange(){} // RVA: 0x7FFE829D2DF0
        public void op_Equality(){} // RVA: 0x7FFE829D30B0
        public void op_Inequality(){} // RVA: 0x7FFE829D3190
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFE829D3220
        public void .ctor(){} // RVA: 0x7FFE829D33D0
        public void Initialize(){} // RVA: 0x7FFE829D37E0
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7FFE829D3E30
        public void GetFallbackLanguage(){} // RVA: 0x7FFE829D4040
        public void GetName(){} // RVA: 0x7FFE829D4280
        public void SetName(){} // RVA: 0x7FFE810FE7C0
        public void FindObjectFromInstanceID(){} // RVA: 0x7FFE829D43A0
        public void ForceLoadFromInstanceID(){} // RVA: 0x7FFE829D4420
    }

    public class ResourcesLocalizationAssetSource : LocalizationAssetSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865D8540
        public void GetAvailableLanguagesFile(){} // RVA: 0x7FFE865D87D0
        public void PrepareFiles(){} // RVA: 0x7FFE865D8970
        public void GetLanguageFiles(){} // RVA: 0x7FFE865D89D0
        public void GetTextFile(){} // RVA: 0x7FFE865D8BE0
    }

}