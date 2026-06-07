// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Localization
// Classes: 9
// Methods: 140

namespace VRC.Localization
{
    public class LocalizableOptionData
    {
        // ── Methods ──
        public void set_LocalizableText(){} // RVA: 0x30B130
        public void .ctor(){} // RVA: 0x49A6E20 | overloaded x2
        public void Initialize(){} // RVA: 0x2878D20
        public void set_Image(){} // RVA: 0x2878D20
        public void get_LocalizableText(){} // RVA: 0x2878D20
        public void get_Image(){} // RVA: 0x30B130
        public void get_Image_A8D1CA619E51(){} // RVA: 0x30B130
        public void set_Image_B2DE882243F2(){} // RVA: 0x2878D20
        public void get_Image_B2DE882243F2(){} // RVA: 0x30B130
        public void get_LocalizableText_F7941DD887ED(){} // RVA: 0x2878D20
    }

    public class LocalizableString
    {
        // ── Methods ──
        public void op_Equality(){} // RVA: 0x5AA0C30
        public void op_Inequality(){} // RVA: 0x5AA0CC0
        public void get_Key(){} // RVA: 0x1AD4690
        public void get_FallbackText(){} // RVA: 0x5AA0D60
        public void get_HasKey(){} // RVA: 0x1D99CA0
        public void get_IsLocalized(){} // RVA: 0x5AA0DB0
        public void get_IsEmpty(){} // RVA: 0x5AA0EC0
        public void .ctor(){} // RVA: 0x199F920
        public void ToString(){} // RVA: 0x5AA0EF0
        public void Equals(){} // RVA: 0x5AA0F50
        public void GetHashCode(){} // RVA: 0x5AA1140
        public void GetTranslation(){} // RVA: 0x5AA1200
        public void GetFormattedFallbackText(){} // RVA: 0x5AA1450
        public void GetKeyWithoutVariantKey(){} // RVA: 0x5AA15B0
        public void DoesArgsContain(){} // RVA: 0x5AA1800
        public void .cctor(){} // RVA: 0x5AA1A50
        public void <DoesArgsContain>g__Matches|26_0(){} // RVA: 0x5AA1B40
    }

    public class LocalizableStringExtensions
    {
        // ── Methods ──
        public void Localize(){} // RVA: 0x5AA1C10
        public void LocalizeWithFallback(){} // RVA: 0x5AA1C60
        public void LocalizeVariant(){} // RVA: 0x5AA1CA0
        public void LocalizeVariantWithFallback(){} // RVA: 0x5AA1D50
        public void NoTranslation(){} // RVA: 0x5AA1E00
        public void SetNewArgs(){} // RVA: 0x5AA1EE0
    }

    public class LocalizableStringFormatter
    {
        // ── Methods ──
        public void GetStringBuilder(){} // RVA: 0x5AA20A0
        public void PutStringBuilder(){} // RVA: 0x5AA2240
        public void FormatString(){} // RVA: 0x5AA22E0
        public void .cctor(){} // RVA: 0x5AA2F90
    }

    public class LocalizationAssetParser
    {
        // ── Methods ──
        public void SeparateCSVDataIntoFilesPerLanguage(){} // RVA: 0x5A95E10
        public void SplitCsvLine(){} // RVA: 0x5A964D0
        public void CleanString(){} // RVA: 0x5A966E0
        public void .cctor(){} // RVA: 0x5A969A0
        public void <SeparateCSVDataIntoFilesPerLanguage>g__createSplitFile|2_4(){} // RVA: 0x5A96A60
    }

    public class LocalizationAssetSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A97440
        public void get_ID(){} // RVA: 0x2F8380
        public void set_ID(){} // RVA: 0x2DEE30
        public void get_FolderPath(){} // RVA: 0x2E07C0
        public void set_FolderPath(){} // RVA: 0x343E80
        public void get_Groups(){} // RVA: 0x30B0C0
        public void set_Groups(){} // RVA: 0x30B0D0
        public void GetAvailableLanguagesFile(){} // RVA: 0xC770
        public void PrepareFiles(){} // RVA: 0xC770
        public void GetLanguageFiles(){}
        public void GetTextFile(){}
        public void .cctor(){} // RVA: 0x5A975E0
    }

    public class LocalizationDatabase
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x5A98D50
        public void set_Instance(){} // RVA: 0x5A98D90
        public void get_Languages(){} // RVA: 0x2E07C0
        public void get_LanguageCount(){} // RVA: 0x5A98E30
        public void get_KeyCount(){} // RVA: 0x5A98E80
        public void get_Timestamp(){} // RVA: 0x35A740
        public void set_Timestamp(){} // RVA: 0x305200
        public void get_CurrentLanguage(){} // RVA: 0x358730
        public void set_CurrentLanguage(){} // RVA: 0x358740
        public void get_IsRTL(){} // RVA: 0x3978E0
        public void set_IsRTL(){} // RVA: 0x3978F0
        public void CreateDefault(){} // RVA: 0x5A98ED0
        public void LoadDefaultAssets(){} // RVA: 0x5A99100
        public void LoadLanguage(){} // RVA: 0x5A99230
        public void AddOrRefreshAsset(){} // RVA: 0x5A99400
        public void PrepareAndLoad(){} // RVA: 0x5A995C0
        public void LoadAssetLanguage(){} // RVA: 0x5A99770
        public void LoadAvailableLanguages(){} // RVA: 0x5A99930
        public void LoadFile(){} // RVA: 0x5A99AF0
        public void MakeStringAndReplaceCustomBlocks(){} // RVA: 0x5A99FC0
        public void HasKey(){} // RVA: 0x5A9A1E0
        public void Translate(){} // RVA: 0x5A9A280
        public void IsInvalidated(){} // RVA: 0x5A9A570
        public void InvalidateCachedKey(){} // RVA: 0x5A9A5D0
        public void FindRichTextTags(){} // RVA: 0x5A9A640
        public void ReplaceMarkersWithRichTextTags(){} // RVA: 0x5A9A970
        public void BiDiString(){} // RVA: 0x5A9AA90
        public void .ctor(){} // RVA: 0x5A9AC30
    }

    public class LocalizationManager
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x1C48670
        public void OnPlayerJoined_A226E8E63B0E(){} // RVA: 0x1C486B0
        public void Equals(){} // RVA: 0x1C48830
        public void op_Implicit(){} // RVA: 0x1C48A20
        public void CompareBaseObjects(){} // RVA: 0x1C48F40
        public void IsNativeObjectAlive(){} // RVA: 0x1C491F0
        public void GetCachedPtr(){} // RVA: 0x1C493C0
        public void get_name(){} // RVA: 0x1C49680
        public void set_name_08FE711B4A07(){} // RVA: 0x1C4AB50 | overloaded x2
        public void Instantiate(){} // RVA: 0x30B0C0
        public void GetHashCode(){} // RVA: 0x1C498B0
        public void StaticInitialize(){} // RVA: 0x1C49B10
        public void OnPlayerJoined(){} // RVA: 0x1C49BF0
        public void OnPlayerJoined_impl(){} // RVA: 0x1C49C70
        public void Doremove_OnUdonReady(){} // RVA: 0x1C4A2B0
        public void ResolveLocalizedValue(){} // RVA: 0x1C4A370
        public void RegisterLocalizationContext(){} // RVA: 0x30B130
        public void GetOrInitializeCurrentUICulture(){} // RVA: 0x4A6500
        public void GetMethod(){} // RVA: 0x4A78C0
        public void StaticInitialize_852E3599EAE7(){} // RVA: 0x1C4A5F0
        public void Internal_CloneSingle(){} // RVA: 0x1C4AC50
        public void GetPlatform(){} // RVA: 0x1C4B2A0
        public void FindObjectsOfType(){} // RVA: 0x1C4B4E0
        public void SetCompletedSynchronously(){} // RVA: 0x1C4B600
        public void FindObjectsByType(){} // RVA: 0x30B890
        public void GetLocalizedValue(){} // RVA: 0x1C4B6E0
        public void .cctor(){} // RVA: 0x1C4B7C0
        public void get_hideFlags(){} // RVA: 0x1C4C800
        public void IsResource(){} // RVA: 0x1C4CAD0
        public void GetLocalizedInstance(){} // RVA: 0x1C4CBA0
        public void FindObjectOfType(){} // RVA: 0x1C4CCE0
        public void FindFirstObjectByType(){} // RVA: 0x1C4CD60
        public void SetStoreCallback(){} // RVA: 0x1C4D0D0
        public void GetLanguage(){} // RVA: 0x1C4D160
        public void GetInternalData(){} // RVA: 0x1C4D2C0
        public void .cctor_A6044F048A6A(){} // RVA: 0x1C4D3A0
        public void RefreshLocalizationContext(){} // RVA: 0x1C4D5B0
        public void RegisterLocalizationManager(){} // RVA: 0x1C4D600
        public void InitializeLocalizationStaticData(){} // RVA: 0x1C4D8C0
        public void .ctor_DCF3C12FAD4B(){} // RVA: 0x1C4DDC0
        public void Initialize(){} // RVA: 0x1C4E040
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x1C4E250
        public void Internal_CloneSingle_F9C03B5A0036(){} // RVA: 0x1C4E5C0
        public void Internal_CloneSingleWithParent(){} // RVA: 0x6374D0
        public void Internal_InstantiateSingle(){} // RVA: 0x1C4E880
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x1C4EAC0
        public void ComputeValue(){} // RVA: 0x1C4EB40
        public void GetName(){} // RVA: 0x1C4EE00
        public void SetName(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0x1C4F450
        public void get_Comparer(){} // RVA: 0x6374D0
    }

    public class ResourcesLocalizationAssetSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A97710
        public void GetAvailableLanguagesFile(){} // RVA: 0x5A979A0
        public void PrepareFiles(){} // RVA: 0x5A97B40
        public void GetLanguageFiles(){} // RVA: 0x5A97BA0
        public void GetTextFile(){} // RVA: 0x5A97DB0
    }

}