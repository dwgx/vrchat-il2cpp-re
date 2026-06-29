// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Localization
// Classes: 12
// Methods: 182

namespace VRC.Localization
{
    public class LocalizableOptionData : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x8C700
        public void .ctor(){} // RVA: 0xA4F9C0
        public void Initialize(){} // RVA: 0x8C700
        public void GetHashCode(){} // RVA: 0x8C700
        public void InternalGetHashCode(){} // RVA: 0x8C700
        public void set_Image(){} // RVA: 0x458E20
        public void get_Image(){} // RVA: 0x8C700
        public void get_LocalizableText(){} // RVA: 0x458E20
        public void set_LocalizableText(){} // RVA: 0x8C700
    }

    public class LocalizableOptionData[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7F710
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7AF90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4D90
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E355B0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7AF90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class LocalizableString : ValueType
    {
        // ── Methods ──
        public void op_Equality(){} // RVA: 0x651B6A0
        public void op_Inequality(){} // RVA: 0x651B730
        public void get_Key(){} // RVA: 0x77900
        public void get_FallbackText(){} // RVA: 0x8A48F0
        public void get_HasKey(){} // RVA: 0x8E4D0
        public void get_IsLocalized(){} // RVA: 0x8A4940
        public void get_IsEmpty(){} // RVA: 0x8A4A50
        public void .ctor(){} // RVA: 0x78E50
        public void ToString(){} // RVA: 0x8A4A80
        public void Equals(){} // RVA: 0x8A4AE0
        public void GetHashCode(){} // RVA: 0x8A4AF0
        public void GetTranslation(){} // RVA: 0x8A4B00
        public void GetFormattedFallbackText(){} // RVA: 0x8A4B10
        public void GetKeyWithoutVariantKey(){} // RVA: 0x8A4B20
        public void DoesArgsContain(){} // RVA: 0x8A4B30
        public void .cctor(){} // RVA: 0x651C4B0
        public void <DoesArgsContain>g__Matches|26_0(){} // RVA: 0x651C5A0
    }

    public class LocalizableStringExtensions : Object
    {
        // ── Methods ──
        public void Localize(){} // RVA: 0x651C670
        public void LocalizeWithFallback(){} // RVA: 0x651C6C0
        public void LocalizeVariant(){} // RVA: 0x651C700
        public void LocalizeVariantWithFallback(){} // RVA: 0x651C7B0
        public void NoTranslation(){} // RVA: 0x651C860
        public void SetNewArgs(){} // RVA: 0x651C940
    }

    public class LocalizableStringFormatter : Object
    {
        // ── Methods ──
        public void GetStringBuilder(){} // RVA: 0x651CB00
        public void PutStringBuilder(){} // RVA: 0x651CCC0
        public void FormatString(){} // RVA: 0x651CD60
        public void .cctor(){} // RVA: 0x651D9E0
    }

    public class LocalizableString[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB3BE0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7ABD0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4700
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6E680
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7ABD0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class LocalizationAssetParser : Object
    {
        // ── Methods ──
        public void SeparateCSVDataIntoFilesPerLanguage(){} // RVA: 0x6510240
        public void SplitCsvLine(){} // RVA: 0x65108F0
        public void CleanString(){} // RVA: 0x6510B00
        public void .cctor(){} // RVA: 0x6510DC0
        public void <SeparateCSVDataIntoFilesPerLanguage>g__createSplitFile|2_4(){} // RVA: 0x6510E80
    }

    public class LocalizationAssetSource : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6511830
        public void get_ID(){} // RVA: 0xB5DBF0
        public void set_ID(){} // RVA: 0xB44D60
        public void get_FolderPath(){} // RVA: 0xB465B0
        public void set_FolderPath(){} // RVA: 0xBA9BA0
        public void get_Groups(){} // RVA: 0xB700F0
        public void set_Groups(){} // RVA: 0xB70100
        public void GetAvailableLanguagesFile(){} // RVA: 0x87BEB0
        public void PrepareFiles(){} // RVA: 0x87BEB0
        public void GetLanguageFiles(){} // RVA: 0x87BF80
        public void GetTextFile(){} // RVA: 0x87BF80
        public void .cctor(){} // RVA: 0x65119D0
    }

    public class LocalizationAssetSource[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class LocalizationDatabase : Object
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x6513170
        public void set_Instance(){} // RVA: 0x65131B0
        public void get_Languages(){} // RVA: 0xB465B0
        public void get_LanguageCount(){} // RVA: 0x6513250
        public void get_KeyCount(){} // RVA: 0x65132A0
        public void get_Timestamp(){} // RVA: 0xBC1B30
        public void set_Timestamp(){} // RVA: 0xB6A8C0
        public void get_CurrentLanguage(){} // RVA: 0xBBF8F0
        public void set_CurrentLanguage(){} // RVA: 0xBBF900
        public void get_IsRTL(){} // RVA: 0xC00EC0
        public void set_IsRTL(){} // RVA: 0xC00ED0
        public void CreateDefault(){} // RVA: 0x65132F0
        public void LoadDefaultAssets(){} // RVA: 0x6513520
        public void LoadLanguage(){} // RVA: 0x6513650
        public void AddOrRefreshAsset(){} // RVA: 0x6513820
        public void PrepareAndLoad(){} // RVA: 0x65139E0
        public void LoadAssetLanguage(){} // RVA: 0x6513B90
        public void LoadAvailableLanguages(){} // RVA: 0x6513D50
        public void LoadFile(){} // RVA: 0x6513F10
        public void MakeStringAndReplaceCustomBlocks(){} // RVA: 0x65143F0
        public void HasKey(){} // RVA: 0x6514610
        public void Translate(){} // RVA: 0x65146B0
        public void IsInvalidated(){} // RVA: 0x65149A0
        public void InvalidateCachedKey(){} // RVA: 0x6514A00
        public void FindRichTextTags(){} // RVA: 0x6514A70
        public void ReplaceMarkersWithRichTextTags(){} // RVA: 0x6514D90
        public void BiDiString(){} // RVA: 0x6514EB0
        public void .ctor(){} // RVA: 0x6515050
    }

    public class LocalizationManager : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x2522140
        public void Equals(){} // RVA: 0xD16660
        public void GetHashCode(){} // RVA: 0x25224B0
        public void op_Implicit(){} // RVA: 0x25224F0
        public void CompareBaseObjects(){} // RVA: 0x25227B0
        public void IsNativeObjectAlive(){} // RVA: 0x2522930
        public void GetCachedPtr(){} // RVA: 0x2522A10
        public void get_name(){} // RVA: 0x2522C20
        public void set_name(){} // RVA: 0xB465B0
        public void Instantiate(){} // RVA: 0xD33E60
        public void Destroy(){} // RVA: 0xB700F0
        public void DestroyImmediate(){} // RVA: 0x2522EA0
        public void FindObjectsOfType(){} // RVA: 0x25233C0
        public void OnPlayerJoined(){} // RVA: 0x25234C0
        public void DontDestroyOnLoad(){} // RVA: 0x2523540
        public void get_hideFlags(){} // RVA: 0x25238B0
        public void set_hideFlags(){} // RVA: 0x2523DB0
        public void .ctor(){} // RVA: 0x2523E80
        public void Initialize(){} // RVA: 0x25242A0
        public void StaticInitialize(){} // RVA: 0x25244B0
        public void ToString(){} // RVA: 0x2524590
        public void op_Equality(){} // RVA: 0x2524760
        public void op_Inequality(){} // RVA: 0x2524950
        public void BroadcastLanguageChange(){} // RVA: 0xB70160
        public void Internal_CloneSingle(){} // RVA: 0x2524A30
        public void Internal_CloneSingleWithParent(){} // RVA: 0x2524BB0
        public void Destroy_A8F620784F86(){} // RVA: 0x2526080
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x2524E60
        public void GetName(){} // RVA: 0x2524F40
        public void IsPersistent(){} // RVA: 0x25250C0
        public void SetName(){} // RVA: 0x2525110
        public void FindObjectFromInstanceID(){} // RVA: 0xD14C10
        public void ForceLoadFromInstanceID(){} // RVA: 0x25253C0
        public void Destroy_Injected(){} // RVA: 0xB708C0
        public void DestroyImmediate_Injected(){} // RVA: 0x2525950
        public void DontDestroyOnLoad_Injected(){} // RVA: 0x2525A20
        public void get_hideFlags_Injected(){} // RVA: 0x2525CE0
        public void set_hideFlags_Injected(){} // RVA: 0x2525D60
        public void Internal_CloneSingle_Injected(){} // RVA: 0x2525FC0
        public void Internal_CloneSingleWithParent_Injected(){} // RVA: 0x25261E0
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x25264A0
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0x25265E0
        public void ToString_Injected(){} // RVA: 0x2526740
        public void GetName_Injected(){} // RVA: 0x2526980
        public void IsPersistent_Injected(){} // RVA: 0x2526FD0
        public void SetName_Injected(){} // RVA: 0x2527620
        public void FindObjectFromInstanceID_Injected(){} // RVA: 0x2527B80
        public void .cctor(){} // RVA: 0x2527C10
        public void h(){} // RVA: 0xB700F0
        // ── Unresolved (hash) ──
        public void m_DCB(){} // RVA: 0x2525600
        public void m_7BC(){} // RVA: 0x2525680
    }

    public class ResourcesLocalizationAssetSource : LocalizationAssetSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6511B00
        public void GetAvailableLanguagesFile(){} // RVA: 0x6511D90
        public void PrepareFiles(){} // RVA: 0x6511F30
        public void GetLanguageFiles(){} // RVA: 0x6511F90
        public void GetTextFile(){} // RVA: 0x65121A0
    }

}