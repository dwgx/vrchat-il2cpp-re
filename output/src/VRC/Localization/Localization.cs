// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Localization
// Classes: 9
// Methods: 139

namespace VRC.Localization
{
    public class LocalizableOptionData : ValueType
    {
        public object LocalizableText;
        public object Image;

        // ── Methods ──
        public void GetLanguage(){} // RVA: 0x7FFD4E36F130
        public void .ctor(){} // RVA: 0x7FFD56652B10 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFD5072B6E0
        public void Equals(){} // RVA: 0x7FFD5072B6E0
        public void set_LocalizableText(){} // RVA: 0x7FFD4E36F130
        public void get_LocalizableText(){} // RVA: 0x7FFD5072B6E0
        public void get_Image(){} // RVA: 0x7FFD4E36F130
        public void set_Image(){} // RVA: 0x7FFD5072B6E0
    }

    public class LocalizableString : ValueType
    {
        public object Key;
        public object FallbackText;
        public object HasKey;
        public object IsLocalized;
        public object IsEmpty;

        // ── Methods ──
        public void op_Equality(){} // RVA: 0x7FFD53658120
        public void op_Inequality(){} // RVA: 0x7FFD536581B0
        public void get_Key(){} // RVA: 0x7FFD4EEF9F60
        public void get_FallbackText(){} // RVA: 0x7FFD53658250
        public void get_HasKey(){} // RVA: 0x7FFD4FCE2000
        public void get_IsLocalized(){} // RVA: 0x7FFD536582A0
        public void get_IsEmpty(){} // RVA: 0x7FFD536583B0
        public void .ctor(){} // RVA: 0x7FFD4F87AE70
        public void ToString(){} // RVA: 0x7FFD536583E0
        public void Equals(){} // RVA: 0x7FFD53658440
        public void GetHashCode(){} // RVA: 0x7FFD53658630
        public void GetTranslation(){} // RVA: 0x7FFD536586F0
        public void GetFormattedFallbackText(){} // RVA: 0x7FFD53658940
        public void GetKeyWithoutVariantKey(){} // RVA: 0x7FFD53658AA0
        public void DoesArgsContain(){} // RVA: 0x7FFD53658CF0
        public void .cctor(){} // RVA: 0x7FFD53658F40
        public void <DoesArgsContain>g__Matches|26_0(){} // RVA: 0x7FFD53659030
    }

    public class LocalizableStringExtensions : Object
    {
        // ── Methods ──
        public void Localize(){} // RVA: 0x7FFD53659100
        public void LocalizeWithFallback(){} // RVA: 0x7FFD53659150
        public void LocalizeVariant(){} // RVA: 0x7FFD53659190
        public void LocalizeVariantWithFallback(){} // RVA: 0x7FFD53659240
        public void NoTranslation(){} // RVA: 0x7FFD536592F0
        public void SetNewArgs(){} // RVA: 0x7FFD536593D0
    }

    public class LocalizableStringFormatter : Object
    {
        // ── Methods ──
        public void GetStringBuilder(){} // RVA: 0x7FFD53659590
        public void PutStringBuilder(){} // RVA: 0x7FFD53659730
        public void FormatString(){} // RVA: 0x7FFD536597D0
        public void .cctor(){} // RVA: 0x7FFD5365A480
    }

    public class LocalizationAssetParser : Object
    {
        // ── Methods ──
        public void SeparateCSVDataIntoFilesPerLanguage(){} // RVA: 0x7FFD5364D300
        public void SplitCsvLine(){} // RVA: 0x7FFD5364D9C0
        public void CleanString(){} // RVA: 0x7FFD5364DBD0
        public void .cctor(){} // RVA: 0x7FFD5364DE90
        public void <SeparateCSVDataIntoFilesPerLanguage>g__createSplitFile|2_4(){} // RVA: 0x7FFD5364DF50
    }

    public class LocalizationAssetSource : Object
    {
        public object ID;
        public object FolderPath;
        public object Groups;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5364E930
        public void get_ID(){} // RVA: 0x7FFD4E35C380
        public void set_ID(){} // RVA: 0x7FFD4E342E30
        public void get_FolderPath(){} // RVA: 0x7FFD4E3447C0
        public void set_FolderPath(){} // RVA: 0x7FFD4E3A7E80
        public void get_Groups(){} // RVA: 0x7FFD4E36F0C0
        public void set_Groups(){} // RVA: 0x7FFD4E36F0D0
        public void GetAvailableLanguagesFile(){} // RVA: 0x7FFD4E0788A0
        public void PrepareFiles(){} // RVA: 0x7FFD4E0788A0
        public void GetLanguageFiles(){}
        public void GetTextFile(){}
        public void .cctor(){} // RVA: 0x7FFD5364EAD0
    }

    public class LocalizationDatabase : Object
    {
        public object Instance;
        public object Languages;
        public object LanguageCount;
        public object KeyCount;
        public object Timestamp;
        public object CurrentLanguage;
        public object IsRTL;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFD53650240
        public void set_Instance(){} // RVA: 0x7FFD53650280
        public void get_Languages(){} // RVA: 0x7FFD4E3447C0
        public void get_LanguageCount(){} // RVA: 0x7FFD53650320
        public void get_KeyCount(){} // RVA: 0x7FFD53650370
        public void get_Timestamp(){} // RVA: 0x7FFD4E3BE740
        public void set_Timestamp(){} // RVA: 0x7FFD4E369200
        public void get_CurrentLanguage(){} // RVA: 0x7FFD4E3BC730
        public void set_CurrentLanguage(){} // RVA: 0x7FFD4E3BC740
        public void get_IsRTL(){} // RVA: 0x7FFD4E3FB8E0
        public void set_IsRTL(){} // RVA: 0x7FFD4E3FB8F0
        public void CreateDefault(){} // RVA: 0x7FFD536503C0
        public void LoadDefaultAssets(){} // RVA: 0x7FFD536505F0
        public void LoadLanguage(){} // RVA: 0x7FFD53650720
        public void AddOrRefreshAsset(){} // RVA: 0x7FFD536508F0
        public void PrepareAndLoad(){} // RVA: 0x7FFD53650AB0
        public void LoadAssetLanguage(){} // RVA: 0x7FFD53650C60
        public void LoadAvailableLanguages(){} // RVA: 0x7FFD53650E20
        public void LoadFile(){} // RVA: 0x7FFD53650FE0
        public void MakeStringAndReplaceCustomBlocks(){} // RVA: 0x7FFD536514B0
        public void HasKey(){} // RVA: 0x7FFD536516D0
        public void Translate(){} // RVA: 0x7FFD53651770
        public void IsInvalidated(){} // RVA: 0x7FFD53651A60
        public void InvalidateCachedKey(){} // RVA: 0x7FFD53651AC0
        public void FindRichTextTags(){} // RVA: 0x7FFD53651B30
        public void ReplaceMarkersWithRichTextTags(){} // RVA: 0x7FFD53651E60
        public void BiDiString(){} // RVA: 0x7FFD53651F80
        public void .ctor(){} // RVA: 0x7FFD53652120
    }

    public class LocalizationManager : Object
    {
        public object _name;
        public object _hideFlags;
        public object f_86E;
        public object f_032;
        public object f_D44;
        public object f_B88;
        public object f_708;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4FAE3E60
        public void OnPlayerJoined(){} // RVA: 0x7FFD4FAE4070
        public void Equals(){} // RVA: 0x7FFD4FAE40F0
        public void op_Implicit(){} // RVA: 0x7FFD4FAE45F0
        public void CompareBaseObjects(){} // RVA: 0x7FFD4FAE46D0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4FAE48E0
        public void GetCachedPtr(){} // RVA: 0x7FFD4FAE4B40
        public void get_name(){} // RVA: 0x7FFD4FAE4C00
        public void set_name(){} // RVA: 0x7FFD4FAE4ED0
        public void Instantiate(){} // RVA: 0x7FFD4FAE5190
        public void GetHashCode(){} // RVA: 0x7FFD4FAE5210
        public void ToString(){} // RVA: 0x7FFD4FAE5250
        public void OnPlayerJoined_6DECA2D0F913(){} // RVA: 0x7FFD4E36F0C0
        public void OnPlayerJoined_impl(){} // RVA: 0x7FFD4FAE55C0
        public void Doremove_OnUdonReady(){} // RVA: 0x7FFD4FAE5840
        public void Instantiate_43D7E48D9426(){} // RVA: 0x7FFD4FAE5BB0
        public void RegisterLocalizationContext(){} // RVA: 0x7FFD4FAE5E60
        public void GetOrInitializeCurrentUICulture(){} // RVA: 0x7FFD4FAE6120
        public void GetMethod(){} // RVA: 0x7FFD4FAE6760
        public void StaticInitialize(){} // RVA: 0x7FFD4FAE6840
        public void Destroy(){} // RVA: 0x7FFD4FAE6920
        public void Internal_CloneSingle_BCB8BEC580C1(){} // RVA: 0x7FFD4FAE9FC0 | overloaded x2
        public void GetPlatform(){} // RVA: 0x7FFD4E5F95E0
        public void FindObjectsOfType(){} // RVA: 0x7FFD4FAE6F80
        public void SetCompletedSynchronously(){} // RVA: 0x7FFD4E5F95C0
        public void FindObjectsByType(){} // RVA: 0x7FFD4FAE7240
        public void GetLocalizedValue(){} // RVA: 0x7FFD4FAE7310
        public void AddUnitNode(){} // RVA: 0x7FFD4E36F890
        public void get_hideFlags(){} // RVA: 0x7FFD4FAE7490
        public void IsResource(){} // RVA: 0x7FFD4E5F95D0
        public void GetLocalizedInstance(){} // RVA: 0x7FFD4FAE75F0
        public void FindObjectOfType(){} // RVA: 0x7FFD4FAE7800
        public void FindFirstObjectByType(){} // RVA: 0x7FFD4FAE7960
        public void SetStoreCallback(){} // RVA: 0x7FFD4FAE7BA0
        public void GetLanguage(){} // RVA: 0x7FFD4E36F130
        public void GetInternalData(){} // RVA: 0x7FFD4FAE81F0
        public void .cctor(){} // RVA: 0x7FFD4FAE8240
        public void StaticInitialize_AFCF7B6F80AC(){} // RVA: 0x7FFD4FAE9280
        public void RegisterLocalizationManager(){} // RVA: 0x7FFD4FAE97A0
        public void InitializeLocalizationStaticData(){} // RVA: 0x7FFD4FAE98C0
        public void .ctor(){} // RVA: 0x7FFD4FAE9910
        public void Initialize(){} // RVA: 0x7FFD4FAE9D20
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFD4FAE9DF0
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFD4FAEA120
        public void Internal_InstantiateSingle(){} // RVA: 0x7FFD4FAEA3E0
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7FFD4FAEA470
        public void ComputeValue(){} // RVA: 0x7FFD4E3447C0
        public void GetName(){} // RVA: 0x7FFD4E36F890
        public void SetName(){} // RVA: 0x7FFD4FAEA7E0
        public void FindObjectFromInstanceID(){} // RVA: 0x7FFD4FAEA920
        public void ForceLoadFromInstanceID(){} // RVA: 0x7FFD4FAEAB60
        public void GetFileName(){} // RVA: 0x7FFD4FAEAC30
    }

    public class ResourcesLocalizationAssetSource : LocalizationAssetSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5364EC00
        public void GetAvailableLanguagesFile(){} // RVA: 0x7FFD5364EE90
        public void PrepareFiles(){} // RVA: 0x7FFD5364F030
        public void GetLanguageFiles(){} // RVA: 0x7FFD5364F090
        public void GetTextFile(){} // RVA: 0x7FFD5364F2A0
    }

}