// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Configuration
// Classes: 64
// Methods: 313

namespace ThirdParty.DotNet.System.Configuration
{
    public class AppSettingsReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD4600
        public void GetValue(){} // RVA: 0x6BD4630
    }

    public class ApplicationScopedSettingAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ApplicationSettingsBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD3D60 | overloaded x4
        public void get_Context(){} // RVA: 0x6BD3D90
        public void get_Item(){} // RVA: 0x6BD3DC0
        public void set_Item(){} // RVA: 0x6BD3DF0
        public void get_Properties(){} // RVA: 0x6BD3E20
        public void get_PropertyValues(){} // RVA: 0x6BD3E50
        public void get_Providers(){} // RVA: 0x6BD3E80
        public void get_SettingsKey(){} // RVA: 0x6BD3EB0
        public void set_SettingsKey(){} // RVA: 0x6BD3EE0
        public void add_PropertyChanged(){} // RVA: 0x6BD3F10
        public void remove_PropertyChanged(){} // RVA: 0x6BD3F40
        public void add_SettingChanging(){} // RVA: 0x6BD3F70
        public void remove_SettingChanging(){} // RVA: 0x6BD3FA0
        public void add_SettingsLoaded(){} // RVA: 0x6BD3FD0
        public void remove_SettingsLoaded(){} // RVA: 0x6BD4000
        public void add_SettingsSaving(){} // RVA: 0x6BD4030
        public void remove_SettingsSaving(){} // RVA: 0x6BD4060
        public void GetPreviousVersion(){} // RVA: 0x6BD4090
        public void OnPropertyChanged(){} // RVA: 0x6BD40C0
        public void OnSettingChanging(){} // RVA: 0x6BD40F0
        public void OnSettingsLoaded(){} // RVA: 0x6BD4120
        public void OnSettingsSaving(){} // RVA: 0x6BD4150
        public void Reload(){} // RVA: 0x6BD4180
        public void Reset(){} // RVA: 0x6BD41B0
        public void Save(){} // RVA: 0x6BD41E0
        public void Upgrade(){} // RVA: 0x6BD4210
    }

    public class ApplicationSettingsGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD45D0
    }

    public class ClientSettingsSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD4660
        public void get_Properties(){} // RVA: 0x6BD4690
        public void get_Settings(){} // RVA: 0x6BD46C0
    }

    public class ConfigXmlDocument
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD4CC0
        public void get_Filename(){} // RVA: 0x6BD4CF0
        public void get_LineNumber(){} // RVA: 0x6BD4D20
        public void System.Configuration.Internal.IConfigErrorInfo.get_Filename(){} // RVA: 0x6BD4D50
        public void System.Configuration.Internal.IConfigErrorInfo.get_LineNumber(){} // RVA: 0x6BD4D80
        public void LoadSingleElement(){} // RVA: 0x6BD4DB0
    }

    public class Configuration
    {
    }

    public class ConfigurationCollectionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void set_AddItemName(){} // RVA: 0x2DD310
        public void set_ClearItemsName(){} // RVA: 0x2DD310
        public void set_CollectionType(){} // RVA: 0x2DD310
        public void set_RemoveItemName(){} // RVA: 0x2DD310
    }

    public class ConfigurationElement
    {
        // ── Methods ──
        public void get_Properties(){} // RVA: 0x659DD00
        public void DeserializeElement(){} // RVA: 0x659DD30
        public void InitializeDefault(){} // RVA: 0x659DD60
        public void IsModified(){} // RVA: 0x659DD90
        public void PostDeserialize(){} // RVA: 0x659DDC0
        public void Reset(){} // RVA: 0x659DDF0
        public void ResetModified(){} // RVA: 0x659DE20
        public void SerializeToXmlElement(){} // RVA: 0x659DE50
        public void Unmerge(){} // RVA: 0x659DE80
    }

    public class ConfigurationElementCollection
    {
        // ── Methods ──
        public void get_CollectionType(){} // RVA: 0x659DF70
        public void get_ElementName(){} // RVA: 0x659DFA0
        public void get_ThrowOnDuplicate(){} // RVA: 0x659DFD0
        public void CreateNewElement(){} // RVA: 0xCD60
        public void GetElementKey(){} // RVA: 0xCE10
    }

    public class ConfigurationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BCF800 | overloaded x8
        public void get_BareMessage(){} // RVA: 0x6BCF830
        public void get_Filename(){} // RVA: 0x6BCF860
        public void get_Line(){} // RVA: 0x6BCF890
        public void GetXmlNodeFilename(){} // RVA: 0x6BCF8C0
        public void GetXmlNodeLineNumber(){} // RVA: 0x6BCF8F0
    }

    public class ConfigurationPropertyCollection
    {
    }

    public class ConfigurationSection
    {
        // ── Methods ──
        public void DeserializeSection(){} // RVA: 0x659DEB0
        public void IsModified(){} // RVA: 0x659DEE0
        public void ResetModified(){} // RVA: 0x659DF10
        public void SerializeSection(){} // RVA: 0x659DF40
    }

    public class ConfigurationSectionGroup
    {
    }

    public class ConfigurationSettings
    {
        public object Filename;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD4C30
        public void get_AppSettings(){} // RVA: 0x6BD4C60
        public void GetConfig(){} // RVA: 0x6BD4C90
    }

    public class DefaultSettingValueAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Value(){} // RVA: 0x6BD4DE0
    }

    public class DictionarySectionHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD4E10
        public void get_KeyAttributeName(){} // RVA: 0x6BD4E40
        public void get_ValueAttributeName(){} // RVA: 0x6BD4E70
        public void Create(){} // RVA: 0x6BD4EA0
    }

    public class IApplicationSettingsProvider
    {
        // ── Methods ──
        public void GetPreviousVersion(){} // RVA: 0x1E6A0
        public void Reset(){} // RVA: 0x24B10
        public void Upgrade(){} // RVA: 0x2DC60
    }

    public class IConfigurationSectionHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x1EE30
    }

    public class IConfigurationSystem
    {
        // ── Methods ──
        public void GetConfig(){} // RVA: 0xCE10
        public void Init(){} // RVA: 0x24A50
    }

    public class IPersistComponentSettings
    {
        // ── Methods ──
        public void get_SaveSettings(){} // RVA: 0xDBE0
        public void set_SaveSettings(){} // RVA: 0x25130
        public void get_SettingsKey(){} // RVA: 0xCD60
        public void set_SettingsKey(){} // RVA: 0x24B10
        public void LoadComponentSettings(){} // RVA: 0x24A50
        public void ResetComponentSettings(){} // RVA: 0x24A50
        public void SaveComponentSettings(){} // RVA: 0x24A50
    }

    public class ISettingsProviderService
    {
        // ── Methods ──
        public void GetSettingsProvider(){} // RVA: 0xCE10
    }

    public class IdnElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD4ED0
        public void get_Enabled(){} // RVA: 0x6BD4F00
        public void set_Enabled(){} // RVA: 0x6BD4F30
        public void get_Properties(){} // RVA: 0x6BD4F60
    }

    public class IgnoreSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x659E030
        public void get_Properties(){} // RVA: 0x659E060
        public void DeserializeSection(){} // RVA: 0x659E090
        public void IsModified(){} // RVA: 0x659E0C0
        public void Reset(){} // RVA: 0x659E0F0
        public void ResetModified(){} // RVA: 0x659E120
        public void SerializeSection(){} // RVA: 0x659E150
    }

    public class IgnoreSectionHandler : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD4F90
        public void Create(){} // RVA: 0x6BD4FC0
    }

    public class IriParsingElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD4FF0
        public void get_Enabled(){} // RVA: 0x6BD5020
        public void set_Enabled(){} // RVA: 0x6BD5050
        public void get_Properties(){} // RVA: 0x6BD5080
    }

    public class LocalFileSettingsProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD50B0
        public void get_ApplicationName(){} // RVA: 0x6BD50E0
        public void set_ApplicationName(){} // RVA: 0x6BD5110
        public void GetPreviousVersion(){} // RVA: 0x6BD5140
        public void GetPropertyValues(){} // RVA: 0x6BD5170
        public void Initialize(){} // RVA: 0x6BD51A0
        public void Reset(){} // RVA: 0x6BD51D0
        public void SetPropertyValues(){} // RVA: 0x6BD5200
        public void Upgrade(){} // RVA: 0x6BD5230
    }

    public class NameValueFileSectionHandler : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD5260
        public void Create(){} // RVA: 0x6BD5290
    }

    public class NameValueSectionHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD52C0
        public void get_KeyAttributeName(){} // RVA: 0x6BD52F0
        public void get_ValueAttributeName(){} // RVA: 0x6BD5320
        public void Create(){} // RVA: 0x6BD5350
    }

    public class NoSettingsVersionUpgradeAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SchemeSettingElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD5380
        public void get_GenericUriParserOptions(){} // RVA: 0x6BD53B0
        public void get_Name(){} // RVA: 0x6BD53E0
        public void get_Properties(){} // RVA: 0x6BD5410
    }

    public class SchemeSettingElementCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD5440
        public void get_CollectionType(){} // RVA: 0x6BD5470
        public void get_Item(){} // RVA: 0x6BD54D0 | overloaded x2
        public void CreateNewElement(){} // RVA: 0x6BD5500
        public void GetElementKey(){} // RVA: 0x6BD5530
        public void IndexOf(){} // RVA: 0x6BD5560
    }

    public class SettingAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SettingChangingEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD4300
        public void get_NewValue(){} // RVA: 0x6BD4330
        public void get_SettingClass(){} // RVA: 0x6BD4360
        public void get_SettingKey(){} // RVA: 0x6BD4390
        public void get_SettingName(){} // RVA: 0x6BD43C0
    }

    public class SettingChangingEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD4240
        public void Invoke(){} // RVA: 0x6BD4270
        public void BeginInvoke(){} // RVA: 0x6BD42A0
        public void EndInvoke(){} // RVA: 0x6BD42D0
    }

    public class SettingElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD48D0 | overloaded x2
        public void get_Name(){} // RVA: 0x6BD4900
        public void set_Name(){} // RVA: 0x6BD4930
        public void get_Properties(){} // RVA: 0x6BD4960
        public void get_SerializeAs(){} // RVA: 0x6BD4990
        public void set_SerializeAs(){} // RVA: 0x6BD49C0
        public void get_Value(){} // RVA: 0x6BD49F0
        public void set_Value(){} // RVA: 0x6BD4A20
    }

    public class SettingElementCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD46F0
        public void get_CollectionType(){} // RVA: 0x6BD4720
        public void get_ElementName(){} // RVA: 0x6BD4750
        public void Add(){} // RVA: 0x6BD4780
        public void Clear(){} // RVA: 0x6BD47B0
        public void CreateNewElement(){} // RVA: 0x6BD47E0
        public void Get(){} // RVA: 0x6BD4810
        public void GetElementKey(){} // RVA: 0x6BD4840
        public void Remove(){} // RVA: 0x6BD4870
    }

    public class SettingValueElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD4A50
        public void get_Properties(){} // RVA: 0x6BD4A80
        public void get_ValueXml(){} // RVA: 0x6BD4AB0
        public void set_ValueXml(){} // RVA: 0x6BD4AE0
        public void DeserializeElement(){} // RVA: 0x6BD4B10
        public void IsModified(){} // RVA: 0x6BD4B40
        public void Reset(){} // RVA: 0x6BD4B70
        public void ResetModified(){} // RVA: 0x6BD4BA0
        public void SerializeToXmlElement(){} // RVA: 0x6BD4BD0
        public void Unmerge(){} // RVA: 0x6BD4C00
    }

    public class SettingsAttributeDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD0760 | overloaded x2
    }

    public class SettingsBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BCF920
        public void get_Context(){} // RVA: 0x6BCF950
        public void get_IsSynchronized(){} // RVA: 0x6BCF980
        public void get_Item(){} // RVA: 0x6BCF9B0
        public void set_Item(){} // RVA: 0x6BCF9E0
        public void get_Properties(){} // RVA: 0x6BCFA10
        public void get_PropertyValues(){} // RVA: 0x6BCFA40
        public void get_Providers(){} // RVA: 0x6BCFA70
        public void Initialize(){} // RVA: 0x6BCFAA0
        public void Save(){} // RVA: 0x6BCFAD0
        public void Synchronized(){} // RVA: 0x6BCFB00
    }

    public class SettingsContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BCFB30
    }

    public class SettingsDescriptionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Description(){} // RVA: 0x6BD5590
    }

    public class SettingsGroupDescriptionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Description(){} // RVA: 0x6BD55C0
    }

    public class SettingsGroupNameAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_GroupName(){} // RVA: 0x6BD55F0
    }

    public class SettingsLoadedEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD44B0
        public void get_Provider(){} // RVA: 0x6BD44E0
    }

    public class SettingsLoadedEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD43F0
        public void Invoke(){} // RVA: 0x6BD4420
        public void BeginInvoke(){} // RVA: 0x6BD4450
        public void EndInvoke(){} // RVA: 0x6BD4480
    }

    public class SettingsManageabilityAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Manageability(){} // RVA: 0x6BD5620
    }

    public class SettingsProperty
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BCFF20 | overloaded x3
        public void get_Attributes(){} // RVA: 0x6BCFF50
        public void get_DefaultValue(){} // RVA: 0x6BCFF80
        public void set_DefaultValue(){} // RVA: 0x6BCFFB0
        public void get_IsReadOnly(){} // RVA: 0x6BCFFE0
        public void set_IsReadOnly(){} // RVA: 0x6BD0010
        public void get_Name(){} // RVA: 0x6BD0040
        public void set_Name(){} // RVA: 0x6BD0070
        public void get_PropertyType(){} // RVA: 0x6BD00A0
        public void set_PropertyType(){} // RVA: 0x6BD00D0
        public void get_Provider(){} // RVA: 0x6BD0100
        public void set_Provider(){} // RVA: 0x6BD0130
        public void get_SerializeAs(){} // RVA: 0x6BD0160
        public void set_SerializeAs(){} // RVA: 0x6BD0190
        public void get_ThrowOnErrorDeserializing(){} // RVA: 0x6BD01C0
        public void set_ThrowOnErrorDeserializing(){} // RVA: 0x6BD01F0
        public void get_ThrowOnErrorSerializing(){} // RVA: 0x6BD0220
        public void set_ThrowOnErrorSerializing(){} // RVA: 0x6BD0250
    }

    public class SettingsPropertyCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BCFB60
        public void get_Count(){} // RVA: 0x6BCFB90
        public void get_IsSynchronized(){} // RVA: 0x6BCFBC0
        public void get_Item(){} // RVA: 0x6BCFBF0
        public void get_SyncRoot(){} // RVA: 0x6BCFC20
        public void Add(){} // RVA: 0x6BCFC50
        public void Clear(){} // RVA: 0x6BCFC80
        public void Clone(){} // RVA: 0x6BCFCB0
        public void CopyTo(){} // RVA: 0x6BCFCE0
        public void GetEnumerator(){} // RVA: 0x6BCFD10
        public void OnAdd(){} // RVA: 0x6BCFD40
        public void OnAddComplete(){} // RVA: 0x6BCFD70
        public void OnClear(){} // RVA: 0x6BCFDA0
        public void OnClearComplete(){} // RVA: 0x6BCFDD0
        public void OnRemove(){} // RVA: 0x6BCFE00
        public void OnRemoveComplete(){} // RVA: 0x6BCFE30
        public void Remove(){} // RVA: 0x6BCFE60
        public void SetReadOnly(){} // RVA: 0x6BCFE90
    }

    public class SettingsPropertyIsReadOnlyException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD56E0 | overloaded x4
    }

    public class SettingsPropertyNotFoundException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD57A0 | overloaded x4
    }

    public class SettingsPropertyValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD04F0
        public void get_Deserialized(){} // RVA: 0x6BD0520
        public void set_Deserialized(){} // RVA: 0x6BD0550
        public void get_IsDirty(){} // RVA: 0x6BD0580
        public void set_IsDirty(){} // RVA: 0x6BD05B0
        public void get_Name(){} // RVA: 0x6BD05E0
        public void get_Property(){} // RVA: 0x6BD0610
        public void get_PropertyValue(){} // RVA: 0x6BD0640
        public void set_PropertyValue(){} // RVA: 0x6BD0670
        public void get_SerializedValue(){} // RVA: 0x6BD06A0
        public void set_SerializedValue(){} // RVA: 0x6BD06D0
        public void get_UsingDefaultValue(){} // RVA: 0x6BD0700
    }

    public class SettingsPropertyValueCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD02B0
        public void get_Count(){} // RVA: 0x6BD02E0
        public void get_IsSynchronized(){} // RVA: 0x6BD0310
        public void get_Item(){} // RVA: 0x6BD0340
        public void get_SyncRoot(){} // RVA: 0x6BD0370
        public void Add(){} // RVA: 0x6BD03A0
        public void Clear(){} // RVA: 0x6BD03D0
        public void Clone(){} // RVA: 0x6BD0400
        public void CopyTo(){} // RVA: 0x6BD0430
        public void GetEnumerator(){} // RVA: 0x6BD0460
        public void Remove(){} // RVA: 0x6BD0490
        public void SetReadOnly(){} // RVA: 0x6BD04C0
    }

    public class SettingsPropertyWrongTypeException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD5860 | overloaded x4
    }

    public class SettingsProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD0280
        public void get_ApplicationName(){} // RVA: 0xCD60
        public void set_ApplicationName(){} // RVA: 0x24B10
        public void GetPropertyValues(){} // RVA: 0x1E6A0
        public void SetPropertyValues(){} // RVA: 0x2DC60
    }

    public class SettingsProviderAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310 | overloaded x2
        public void get_ProviderTypeName(){} // RVA: 0x6BD5890
    }

    public class SettingsProviderCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD0790
        public void get_Item(){} // RVA: 0x6BD07C0
        public void Add(){} // RVA: 0x6BD07F0
    }

    public class SettingsSavingEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD4510
        public void Invoke(){} // RVA: 0x6BD4540
        public void BeginInvoke(){} // RVA: 0x6BD4570
        public void EndInvoke(){} // RVA: 0x6BD45A0
    }

    public class SettingsSerializeAsAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_SerializeAs(){} // RVA: 0x6BD58C0
    }

    public class SingleTagSectionHandler : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD58F0
        public void Create(){} // RVA: 0x6BD5920
    }

    public class SpecialSettingAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_SpecialSetting(){} // RVA: 0x6BD5950
    }

    public class UriSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD5980
        public void get_Idn(){} // RVA: 0x6BD59B0
        public void get_IriParsing(){} // RVA: 0x6BD59E0
        public void get_Properties(){} // RVA: 0x6BD5A10
        public void get_SchemeSettings(){} // RVA: 0x6BD5A40
    }

    public class UserScopedSettingAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class UserSettingsGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD5A70
    }

}