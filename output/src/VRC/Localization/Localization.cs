// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Localization
// Classes: 9
// Methods: 140

namespace VRC.Localization
{
    public class LocalizableOptionData
    {
        // ── Methods ──
        public void set_LocalizableText(){} // RVA: 0x7FFAF2DBB130
        public void .ctor(){} // RVA: 0x7FFAF7456E20 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFAF5328D20
        public void set_Image(){} // RVA: 0x7FFAF5328D20
        public void get_LocalizableText(){} // RVA: 0x7FFAF5328D20
        public void get_Image(){} // RVA: 0x7FFAF2DBB130
        public void get_Image_A8D1CA619E51(){} // RVA: 0x7FFAF2DBB130
        public void set_Image_B2DE882243F2(){} // RVA: 0x7FFAF5328D20
        public void get_Image_B2DE882243F2(){} // RVA: 0x7FFAF2DBB130
        // ── Unresolved (hash) ──
        public void m_F79(){} // RVA: 0x7FFAF5328D20
    }

    public class LocalizableString
    {
        // ── Methods ──
        public void op_Equality(){} // RVA: 0x7FFAF8550C30
        public void op_Inequality(){} // RVA: 0x7FFAF8550CC0
        public void get_Key(){} // RVA: 0x7FFAF4584690
        public void get_FallbackText(){} // RVA: 0x7FFAF8550D60
        public void get_HasKey(){} // RVA: 0x7FFAF4849CA0
        public void get_IsLocalized(){} // RVA: 0x7FFAF8550DB0
        public void get_IsEmpty(){} // RVA: 0x7FFAF8550EC0
        public void .ctor(){} // RVA: 0x7FFAF444F920
        public void ToString(){} // RVA: 0x7FFAF8550EF0
        public void Equals(){} // RVA: 0x7FFAF8550F50
        public void GetHashCode(){} // RVA: 0x7FFAF8551140
        public void GetTranslation(){} // RVA: 0x7FFAF8551200
        public void GetFormattedFallbackText(){} // RVA: 0x7FFAF8551450
        public void GetKeyWithoutVariantKey(){} // RVA: 0x7FFAF85515B0
        public void DoesArgsContain(){} // RVA: 0x7FFAF8551800
        public void .cctor(){} // RVA: 0x7FFAF8551A50
        public void <DoesArgsContain>g__Matches|26_0(){} // RVA: 0x7FFAF8551B40
    }

    public class LocalizableStringExtensions
    {
        // ── Methods ──
        public void Localize(){} // RVA: 0x7FFAF8551C10
        public void LocalizeWithFallback(){} // RVA: 0x7FFAF8551C60
        public void LocalizeVariant(){} // RVA: 0x7FFAF8551CA0
        public void LocalizeVariantWithFallback(){} // RVA: 0x7FFAF8551D50
        public void NoTranslation(){} // RVA: 0x7FFAF8551E00
        public void SetNewArgs(){} // RVA: 0x7FFAF8551EE0
    }

    public class LocalizableStringFormatter
    {
        // ── Methods ──
        public void GetStringBuilder(){} // RVA: 0x7FFAF85520A0
        public void PutStringBuilder(){} // RVA: 0x7FFAF8552240
        public void FormatString(){} // RVA: 0x7FFAF85522E0
        public void .cctor(){} // RVA: 0x7FFAF8552F90
    }

    public class LocalizationAssetParser
    {
        // ── Methods ──
        public void SeparateCSVDataIntoFilesPerLanguage(){} // RVA: 0x7FFAF8545E10
        public void SplitCsvLine(){} // RVA: 0x7FFAF85464D0
        public void CleanString(){} // RVA: 0x7FFAF85466E0
        public void .cctor(){} // RVA: 0x7FFAF85469A0
        public void <SeparateCSVDataIntoFilesPerLanguage>g__createSplitFile|2_4(){} // RVA: 0x7FFAF8546A60
    }

    public class LocalizationAssetSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8547440
        public void get_ID(){} // RVA: 0x7FFAF2DA8380
        public void set_ID(){} // RVA: 0x7FFAF2D8EE30
        public void get_FolderPath(){} // RVA: 0x7FFAF2D907C0
        public void set_FolderPath(){} // RVA: 0x7FFAF2DF3E80
        public void get_Groups(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Groups(){} // RVA: 0x7FFAF2DBB0D0
        public void GetAvailableLanguagesFile(){} // RVA: 0x7FFAF2ABC770
        public void PrepareFiles(){} // RVA: 0x7FFAF2ABC770
        public void GetLanguageFiles(){}
        public void GetTextFile(){}
        public void .cctor(){} // RVA: 0x7FFAF85475E0
    }

    public class LocalizationDatabase
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAF8548D50
        public void set_Instance(){} // RVA: 0x7FFAF8548D90
        public void get_Languages(){} // RVA: 0x7FFAF2D907C0
        public void get_LanguageCount(){} // RVA: 0x7FFAF8548E30
        public void get_KeyCount(){} // RVA: 0x7FFAF8548E80
        public void get_Timestamp(){} // RVA: 0x7FFAF2E0A740
        public void set_Timestamp(){} // RVA: 0x7FFAF2DB5200
        public void get_CurrentLanguage(){} // RVA: 0x7FFAF2E08730
        public void set_CurrentLanguage(){} // RVA: 0x7FFAF2E08740
        public void get_IsRTL(){} // RVA: 0x7FFAF2E478E0
        public void set_IsRTL(){} // RVA: 0x7FFAF2E478F0
        public void CreateDefault(){} // RVA: 0x7FFAF8548ED0
        public void LoadDefaultAssets(){} // RVA: 0x7FFAF8549100
        public void LoadLanguage(){} // RVA: 0x7FFAF8549230
        public void AddOrRefreshAsset(){} // RVA: 0x7FFAF8549400
        public void PrepareAndLoad(){} // RVA: 0x7FFAF85495C0
        public void LoadAssetLanguage(){} // RVA: 0x7FFAF8549770
        public void LoadAvailableLanguages(){} // RVA: 0x7FFAF8549930
        public void LoadFile(){} // RVA: 0x7FFAF8549AF0
        public void MakeStringAndReplaceCustomBlocks(){} // RVA: 0x7FFAF8549FC0
        public void HasKey(){} // RVA: 0x7FFAF854A1E0
        public void Translate(){} // RVA: 0x7FFAF854A280
        public void IsInvalidated(){} // RVA: 0x7FFAF854A570
        public void InvalidateCachedKey(){} // RVA: 0x7FFAF854A5D0
        public void FindRichTextTags(){} // RVA: 0x7FFAF854A640
        public void ReplaceMarkersWithRichTextTags(){} // RVA: 0x7FFAF854A970
        public void BiDiString(){} // RVA: 0x7FFAF854AA90
        public void .ctor(){} // RVA: 0x7FFAF854AC30
    }

    public class LocalizationManager
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAF46F8670
        public void OnPlayerJoined_A226E8E63B0E(){} // RVA: 0x7FFAF46F86B0
        public void Equals(){} // RVA: 0x7FFAF46F8830
        public void op_Implicit(){} // RVA: 0x7FFAF46F8A20
        public void CompareBaseObjects(){} // RVA: 0x7FFAF46F8F40
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAF46F91F0
        public void GetCachedPtr(){} // RVA: 0x7FFAF46F93C0
        public void get_name(){} // RVA: 0x7FFAF46F9680
        public void set_name_08FE711B4A07(){} // RVA: 0x7FFAF46FAB50 | overloaded x2
        public void Instantiate(){} // RVA: 0x7FFAF2DBB0C0
        public void GetHashCode(){} // RVA: 0x7FFAF46F98B0
        public void StaticInitialize(){} // RVA: 0x7FFAF46F9B10
        public void OnPlayerJoined(){} // RVA: 0x7FFAF46F9BF0
        public void OnPlayerJoined_impl(){} // RVA: 0x7FFAF46F9C70
        public void Doremove_OnUdonReady(){} // RVA: 0x7FFAF46FA2B0
        public void ResolveLocalizedValue(){} // RVA: 0x7FFAF46FA370
        public void RegisterLocalizationContext(){} // RVA: 0x7FFAF2DBB130
        public void GetOrInitializeCurrentUICulture(){} // RVA: 0x7FFAF2F56500
        public void GetMethod(){} // RVA: 0x7FFAF2F578C0
        public void StaticInitialize_852E3599EAE7(){} // RVA: 0x7FFAF46FA5F0
        public void Internal_CloneSingle(){} // RVA: 0x7FFAF46FAC50
        public void GetPlatform(){} // RVA: 0x7FFAF46FB2A0
        public void FindObjectsOfType(){} // RVA: 0x7FFAF46FB4E0
        public void SetCompletedSynchronously(){} // RVA: 0x7FFAF46FB600
        public void FindObjectsByType(){} // RVA: 0x7FFAF2DBB890
        public void GetLocalizedValue(){} // RVA: 0x7FFAF46FB6E0
        public void .cctor(){} // RVA: 0x7FFAF46FB7C0
        public void get_hideFlags(){} // RVA: 0x7FFAF46FC800
        public void IsResource(){} // RVA: 0x7FFAF46FCAD0
        public void GetLocalizedInstance(){} // RVA: 0x7FFAF46FCBA0
        public void FindObjectOfType(){} // RVA: 0x7FFAF46FCCE0
        public void FindFirstObjectByType(){} // RVA: 0x7FFAF46FCD60
        public void SetStoreCallback(){} // RVA: 0x7FFAF46FD0D0
        public void GetLanguage(){} // RVA: 0x7FFAF46FD160
        public void GetInternalData(){} // RVA: 0x7FFAF46FD2C0
        public void .cctor_A6044F048A6A(){} // RVA: 0x7FFAF46FD3A0
        public void RefreshLocalizationContext(){} // RVA: 0x7FFAF46FD5B0
        public void RegisterLocalizationManager(){} // RVA: 0x7FFAF46FD600
        public void InitializeLocalizationStaticData(){} // RVA: 0x7FFAF46FD8C0
        public void .ctor_DCF3C12FAD4B(){} // RVA: 0x7FFAF46FDDC0
        public void Initialize(){} // RVA: 0x7FFAF46FE040
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFAF46FE250
        public void Internal_CloneSingle_F9C03B5A0036(){} // RVA: 0x7FFAF46FE5C0
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFAF30E74D0
        public void Internal_InstantiateSingle(){} // RVA: 0x7FFAF46FE880
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7FFAF46FEAC0
        public void ComputeValue(){} // RVA: 0x7FFAF46FEB40
        public void GetName(){} // RVA: 0x7FFAF46FEE00
        public void SetName(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAF46FF450
        // ── Unresolved (hash) ──
        public void m_AA6(){} // RVA: 0x7FFAF30E74D0
    }

    public class ResourcesLocalizationAssetSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8547710
        public void GetAvailableLanguagesFile(){} // RVA: 0x7FFAF85479A0
        public void PrepareFiles(){} // RVA: 0x7FFAF8547B40
        public void GetLanguageFiles(){} // RVA: 0x7FFAF8547BA0
        public void GetTextFile(){} // RVA: 0x7FFAF8547DB0
    }

}