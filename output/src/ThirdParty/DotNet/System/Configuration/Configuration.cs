// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Configuration
// Classes: 61
// Methods: 288

namespace ThirdParty.DotNet.System.Configuration
{
    public class AppSettingsReader : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C3500
        public void GetValue(){} // RVA: 0x7AE9C3530
    }

    public class ApplicationScopedSettingAttribute : SettingAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ApplicationSettingsBase : SettingsBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C2C60
        public void get_Context(){} // RVA: 0x7AE9C2C90
        public void get_Item(){} // RVA: 0x7AE9C2CC0
        public void set_Item(){} // RVA: 0x7AE9C2CF0
        public void get_Properties(){} // RVA: 0x7AE9C2D20
        public void get_PropertyValues(){} // RVA: 0x7AE9C2D50
        public void get_Providers(){} // RVA: 0x7AE9C2D80
        public void get_SettingsKey(){} // RVA: 0x7AE9C2DB0
        public void set_SettingsKey(){} // RVA: 0x7AE9C2DE0
        public void add_PropertyChanged(){} // RVA: 0x7AE9C2E10
        public void remove_PropertyChanged(){} // RVA: 0x7AE9C2E40
        public void add_SettingChanging(){} // RVA: 0x7AE9C2E70
        public void remove_SettingChanging(){} // RVA: 0x7AE9C2EA0
        public void add_SettingsLoaded(){} // RVA: 0x7AE9C2ED0
        public void remove_SettingsLoaded(){} // RVA: 0x7AE9C2F00
        public void add_SettingsSaving(){} // RVA: 0x7AE9C2F30
        public void remove_SettingsSaving(){} // RVA: 0x7AE9C2F60
        public void GetPreviousVersion(){} // RVA: 0x7AE9C2F90
        public void OnPropertyChanged(){} // RVA: 0x7AE9C2FC0
        public void OnSettingChanging(){} // RVA: 0x7AE9C2FF0
        public void OnSettingsLoaded(){} // RVA: 0x7AE9C3020
        public void OnSettingsSaving(){} // RVA: 0x7AE9C3050
        public void Reload(){} // RVA: 0x7AE9C3080
        public void Reset(){} // RVA: 0x7AE9C30B0
        public void Save(){} // RVA: 0x7AE9C30E0
        public void Upgrade(){} // RVA: 0x7AE9C3110
    }

    public class ApplicationSettingsGroup : ConfigurationSectionGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C34D0
    }

    public class ClientSettingsSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C3560
        public void get_Properties(){} // RVA: 0x7AE9C3590
        public void get_Settings(){} // RVA: 0x7AE9C35C0
    }

    public class ConfigXmlDocument : XmlDocument
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C3BC0
        public void get_Filename(){} // RVA: 0x7AE9C3BF0
        public void get_LineNumber(){} // RVA: 0x7AE9C3C20
        public void System.Configuration.Internal.IConfigErrorInfo.get_Filename(){} // RVA: 0x7AE9C3C50
        public void System.Configuration.Internal.IConfigErrorInfo.get_LineNumber(){} // RVA: 0x7AE9C3C80
        public void LoadSingleElement(){} // RVA: 0x7AE9C3CB0
    }

    public class ConfigurationCollectionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void set_AddItemName(){} // RVA: 0x7A80D7310
        public void set_ClearItemsName(){} // RVA: 0x7A80D7310
        public void set_CollectionType(){} // RVA: 0x7A80D7310
        public void set_RemoveItemName(){} // RVA: 0x7A80D7310
    }

    public class ConfigurationElement : Object
    {
        // ── Methods ──
        public void get_Properties(){} // RVA: 0x7AE38C200
        public void DeserializeElement(){} // RVA: 0x7AE38C230
        public void InitializeDefault(){} // RVA: 0x7AE38C260
        public void IsModified(){} // RVA: 0x7AE38C290
        public void PostDeserialize(){} // RVA: 0x7AE38C2C0
        public void Reset(){} // RVA: 0x7AE38C2F0
        public void ResetModified(){} // RVA: 0x7AE38C320
        public void SerializeToXmlElement(){} // RVA: 0x7AE38C350
        public void Unmerge(){} // RVA: 0x7AE38C380
    }

    public class ConfigurationElementCollection : ConfigurationElement
    {
        // ── Methods ──
        public void get_CollectionType(){} // RVA: 0x7AE38C470
        public void get_ElementName(){} // RVA: 0x7AE38C4A0
        public void get_ThrowOnDuplicate(){} // RVA: 0x7AE38C4D0
        public void CreateNewElement(){} // RVA: 0x7A7E00680
        public void GetElementKey(){} // RVA: 0x7A7E00B20
    }

    public class ConfigurationException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9BE700
        public void get_BareMessage(){} // RVA: 0x7AE9BE730
        public void get_Filename(){} // RVA: 0x7AE9BE760
        public void get_Line(){} // RVA: 0x7AE9BE790
        public void GetXmlNodeFilename(){} // RVA: 0x7AE9BE7C0
        public void GetXmlNodeLineNumber(){} // RVA: 0x7AE9BE7F0
    }

    public class ConfigurationSection : ConfigurationElement
    {
        // ── Methods ──
        public void DeserializeSection(){} // RVA: 0x7AE38C3B0
        public void IsModified(){} // RVA: 0x7AE38C3E0
        public void ResetModified(){} // RVA: 0x7AE38C410
        public void SerializeSection(){} // RVA: 0x7AE38C440
    }

    public class ConfigurationSettings : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C3B30
        public void get_AppSettings(){} // RVA: 0x7AE9C3B60
        public void GetConfig(){} // RVA: 0x7AE9C3B90
    }

    public class DefaultSettingValueAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_Value(){} // RVA: 0x7AE9C3CE0
    }

    public class DictionarySectionHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C3D10
        public void get_KeyAttributeName(){} // RVA: 0x7AE9C3D40
        public void get_ValueAttributeName(){} // RVA: 0x7AE9C3D70
        public void Create(){} // RVA: 0x7AE9C3DA0
    }

    public class IApplicationSettingsProvider
    {
        // ── Methods ──
        public void GetPreviousVersion(){} // RVA: 0x7A7E00BD0
        public void Reset(){} // RVA: 0x7A7E18800
        public void Upgrade(){} // RVA: 0x7A7E18890
    }

    public class IConfigurationSectionHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7A7E06710
    }

    public class IConfigurationSystem
    {
        // ── Methods ──
        public void GetConfig(){} // RVA: 0x7A7E00B20
        public void Init(){} // RVA: 0x7A7E18770
    }

    public class IPersistComponentSettings
    {
        // ── Methods ──
        public void get_SaveSettings(){} // RVA: 0x7A7E01900
        public void set_SaveSettings(){} // RVA: 0x7A7E18C30
        public void get_SettingsKey(){} // RVA: 0x7A7E00680
        public void set_SettingsKey(){} // RVA: 0x7A7E18800
        public void LoadComponentSettings(){} // RVA: 0x7A7E18770
        public void ResetComponentSettings(){} // RVA: 0x7A7E18770
        public void SaveComponentSettings(){} // RVA: 0x7A7E18770
    }

    public class ISettingsProviderService
    {
        // ── Methods ──
        public void GetSettingsProvider(){} // RVA: 0x7A7E00B20
    }

    public class IdnElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C3DD0
        public void get_Enabled(){} // RVA: 0x7AE9C3E00
        public void set_Enabled(){} // RVA: 0x7AE9C3E30
        public void get_Properties(){} // RVA: 0x7AE9C3E60
    }

    public class IgnoreSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE38C530
        public void get_Properties(){} // RVA: 0x7AE38C560
        public void DeserializeSection(){} // RVA: 0x7AE38C590
        public void IsModified(){} // RVA: 0x7AE38C5C0
        public void Reset(){} // RVA: 0x7AE38C5F0
        public void ResetModified(){} // RVA: 0x7AE38C620
        public void SerializeSection(){} // RVA: 0x7AE38C650
    }

    public class IgnoreSectionHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C3E90
        public void Create(){} // RVA: 0x7AE9C3EC0
    }

    public class IriParsingElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C3EF0
        public void get_Enabled(){} // RVA: 0x7AE9C3F20
        public void set_Enabled(){} // RVA: 0x7AE9C3F50
        public void get_Properties(){} // RVA: 0x7AE9C3F80
    }

    public class LocalFileSettingsProvider : SettingsProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C3FB0
        public void get_ApplicationName(){} // RVA: 0x7AE9C3FE0
        public void set_ApplicationName(){} // RVA: 0x7AE9C4010
        public void GetPreviousVersion(){} // RVA: 0x7AE9C4040
        public void GetPropertyValues(){} // RVA: 0x7AE9C4070
        public void Initialize(){} // RVA: 0x7AE9C40A0
        public void Reset(){} // RVA: 0x7AE9C40D0
        public void SetPropertyValues(){} // RVA: 0x7AE9C4100
        public void Upgrade(){} // RVA: 0x7AE9C4130
    }

    public class NameValueFileSectionHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C4160
        public void Create(){} // RVA: 0x7AE9C4190
    }

    public class NameValueSectionHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C41C0
        public void get_KeyAttributeName(){} // RVA: 0x7AE9C41F0
        public void get_ValueAttributeName(){} // RVA: 0x7AE9C4220
        public void Create(){} // RVA: 0x7AE9C4250
    }

    public class NoSettingsVersionUpgradeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SchemeSettingElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C4280
        public void get_GenericUriParserOptions(){} // RVA: 0x7AE9C42B0
        public void get_Name(){} // RVA: 0x7AE9C42E0
        public void get_Properties(){} // RVA: 0x7AE9C4310
    }

    public class SchemeSettingElementCollection : ConfigurationElementCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C4340
        public void get_CollectionType(){} // RVA: 0x7AE9C4370
        public void get_Item(){} // RVA: 0x7AE9C43D0
        public void CreateNewElement(){} // RVA: 0x7AE9C4400
        public void GetElementKey(){} // RVA: 0x7AE9C4430
        public void IndexOf(){} // RVA: 0x7AE9C4460
    }

    public class SettingAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SettingChangingEventArgs : CancelEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C3200
        public void get_NewValue(){} // RVA: 0x7AE9C3230
        public void get_SettingClass(){} // RVA: 0x7AE9C3260
        public void get_SettingKey(){} // RVA: 0x7AE9C3290
        public void get_SettingName(){} // RVA: 0x7AE9C32C0
    }

    public class SettingChangingEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C3140
        public void Invoke(){} // RVA: 0x7AE9C3170
        public void BeginInvoke(){} // RVA: 0x7AE9C31A0
        public void EndInvoke(){} // RVA: 0x7AE9C31D0
    }

    public class SettingElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C37D0
        public void get_Name(){} // RVA: 0x7AE9C3800
        public void set_Name(){} // RVA: 0x7AE9C3830
        public void get_Properties(){} // RVA: 0x7AE9C3860
        public void get_SerializeAs(){} // RVA: 0x7AE9C3890
        public void set_SerializeAs(){} // RVA: 0x7AE9C38C0
        public void get_Value(){} // RVA: 0x7AE9C38F0
        public void set_Value(){} // RVA: 0x7AE9C3920
    }

    public class SettingElementCollection : ConfigurationElementCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C35F0
        public void get_CollectionType(){} // RVA: 0x7AE9C3620
        public void get_ElementName(){} // RVA: 0x7AE9C3650
        public void Add(){} // RVA: 0x7AE9C3680
        public void Clear(){} // RVA: 0x7AE9C36B0
        public void CreateNewElement(){} // RVA: 0x7AE9C36E0
        public void Get(){} // RVA: 0x7AE9C3710
        public void GetElementKey(){} // RVA: 0x7AE9C3740
        public void Remove(){} // RVA: 0x7AE9C3770
    }

    public class SettingValueElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C3950
        public void get_Properties(){} // RVA: 0x7AE9C3980
        public void get_ValueXml(){} // RVA: 0x7AE9C39B0
        public void set_ValueXml(){} // RVA: 0x7AE9C39E0
        public void DeserializeElement(){} // RVA: 0x7AE9C3A10
        public void IsModified(){} // RVA: 0x7AE9C3A40
        public void Reset(){} // RVA: 0x7AE9C3A70
        public void ResetModified(){} // RVA: 0x7AE9C3AA0
        public void SerializeToXmlElement(){} // RVA: 0x7AE9C3AD0
        public void Unmerge(){} // RVA: 0x7AE9C3B00
    }

    public class SettingsAttributeDictionary : Hashtable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9BF660
    }

    public class SettingsBase : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9BE820
        public void get_Context(){} // RVA: 0x7AE9BE850
        public void get_IsSynchronized(){} // RVA: 0x7AE9BE880
        public void get_Item(){} // RVA: 0x7AE9BE8B0
        public void set_Item(){} // RVA: 0x7AE9BE8E0
        public void get_Properties(){} // RVA: 0x7AE9BE910
        public void get_PropertyValues(){} // RVA: 0x7AE9BE940
        public void get_Providers(){} // RVA: 0x7AE9BE970
        public void Initialize(){} // RVA: 0x7AE9BE9A0
        public void Save(){} // RVA: 0x7AE9BE9D0
        public void Synchronized(){} // RVA: 0x7AE9BEA00
    }

    public class SettingsContext : Hashtable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9BEA30
    }

    public class SettingsDescriptionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_Description(){} // RVA: 0x7AE9C4490
    }

    public class SettingsGroupDescriptionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_Description(){} // RVA: 0x7AE9C44C0
    }

    public class SettingsGroupNameAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_GroupName(){} // RVA: 0x7AE9C44F0
    }

    public class SettingsLoadedEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C33B0
        public void get_Provider(){} // RVA: 0x7AE9C33E0
    }

    public class SettingsLoadedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C32F0
        public void Invoke(){} // RVA: 0x7AE9C3320
        public void BeginInvoke(){} // RVA: 0x7AE9C3350
        public void EndInvoke(){} // RVA: 0x7AE9C3380
    }

    public class SettingsManageabilityAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_Manageability(){} // RVA: 0x7AE9C4520
    }

    public class SettingsProperty : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9BEE20
        public void get_Attributes(){} // RVA: 0x7AE9BEE50
        public void get_DefaultValue(){} // RVA: 0x7AE9BEE80
        public void set_DefaultValue(){} // RVA: 0x7AE9BEEB0
        public void get_IsReadOnly(){} // RVA: 0x7AE9BEEE0
        public void set_IsReadOnly(){} // RVA: 0x7AE9BEF10
        public void get_Name(){} // RVA: 0x7AE9BEF40
        public void set_Name(){} // RVA: 0x7AE9BEF70
        public void get_PropertyType(){} // RVA: 0x7AE9BEFA0
        public void set_PropertyType(){} // RVA: 0x7AE9BEFD0
        public void get_Provider(){} // RVA: 0x7AE9BF000
        public void set_Provider(){} // RVA: 0x7AE9BF030
        public void get_SerializeAs(){} // RVA: 0x7AE9BF060
        public void set_SerializeAs(){} // RVA: 0x7AE9BF090
        public void get_ThrowOnErrorDeserializing(){} // RVA: 0x7AE9BF0C0
        public void set_ThrowOnErrorDeserializing(){} // RVA: 0x7AE9BF0F0
        public void get_ThrowOnErrorSerializing(){} // RVA: 0x7AE9BF120
        public void set_ThrowOnErrorSerializing(){} // RVA: 0x7AE9BF150
    }

    public class SettingsPropertyCollection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9BEA60
        public void get_Count(){} // RVA: 0x7AE9BEA90
        public void get_IsSynchronized(){} // RVA: 0x7AE9BEAC0
        public void get_Item(){} // RVA: 0x7AE9BEAF0
        public void get_SyncRoot(){} // RVA: 0x7AE9BEB20
        public void Add(){} // RVA: 0x7AE9BEB50
        public void Clear(){} // RVA: 0x7AE9BEB80
        public void Clone(){} // RVA: 0x7AE9BEBB0
        public void CopyTo(){} // RVA: 0x7AE9BEBE0
        public void GetEnumerator(){} // RVA: 0x7AE9BEC10
        public void OnAdd(){} // RVA: 0x7AE9BEC40
        public void OnAddComplete(){} // RVA: 0x7AE9BEC70
        public void OnClear(){} // RVA: 0x7AE9BECA0
        public void OnClearComplete(){} // RVA: 0x7AE9BECD0
        public void OnRemove(){} // RVA: 0x7AE9BED00
        public void OnRemoveComplete(){} // RVA: 0x7AE9BED30
        public void Remove(){} // RVA: 0x7AE9BED60
        public void SetReadOnly(){} // RVA: 0x7AE9BED90
    }

    public class SettingsPropertyIsReadOnlyException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C45E0
    }

    public class SettingsPropertyNotFoundException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C46A0
    }

    public class SettingsPropertyValue : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9BF3F0
        public void get_Deserialized(){} // RVA: 0x7AE9BF420
        public void set_Deserialized(){} // RVA: 0x7AE9BF450
        public void get_IsDirty(){} // RVA: 0x7AE9BF480
        public void set_IsDirty(){} // RVA: 0x7AE9BF4B0
        public void get_Name(){} // RVA: 0x7AE9BF4E0
        public void get_Property(){} // RVA: 0x7AE9BF510
        public void get_PropertyValue(){} // RVA: 0x7AE9BF540
        public void set_PropertyValue(){} // RVA: 0x7AE9BF570
        public void get_SerializedValue(){} // RVA: 0x7AE9BF5A0
        public void set_SerializedValue(){} // RVA: 0x7AE9BF5D0
        public void get_UsingDefaultValue(){} // RVA: 0x7AE9BF600
    }

    public class SettingsPropertyValueCollection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9BF1B0
        public void get_Count(){} // RVA: 0x7AE9BF1E0
        public void get_IsSynchronized(){} // RVA: 0x7AE9BF210
        public void get_Item(){} // RVA: 0x7AE9BF240
        public void get_SyncRoot(){} // RVA: 0x7AE9BF270
        public void Add(){} // RVA: 0x7AE9BF2A0
        public void Clear(){} // RVA: 0x7AE9BF2D0
        public void Clone(){} // RVA: 0x7AE9BF300
        public void CopyTo(){} // RVA: 0x7AE9BF330
        public void GetEnumerator(){} // RVA: 0x7AE9BF360
        public void Remove(){} // RVA: 0x7AE9BF390
        public void SetReadOnly(){} // RVA: 0x7AE9BF3C0
    }

    public class SettingsPropertyWrongTypeException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C4760
    }

    public class SettingsProvider : ProviderBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9BF180
        public void get_ApplicationName(){} // RVA: 0x7A7E00680
        public void set_ApplicationName(){} // RVA: 0x7A7E18800
        public void GetPropertyValues(){} // RVA: 0x7A7E00BD0
        public void SetPropertyValues(){} // RVA: 0x7A7E18890
    }

    public class SettingsProviderAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_ProviderTypeName(){} // RVA: 0x7AE9C4790
    }

    public class SettingsProviderCollection : ProviderCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9BF690
        public void get_Item(){} // RVA: 0x7AE9BF6C0
        public void Add(){} // RVA: 0x7AE9BF6F0
    }

    public class SettingsSavingEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C3410
        public void Invoke(){} // RVA: 0x7AE9C3440
        public void BeginInvoke(){} // RVA: 0x7AE9C3470
        public void EndInvoke(){} // RVA: 0x7AE9C34A0
    }

    public class SettingsSerializeAsAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_SerializeAs(){} // RVA: 0x7AE9C47C0
    }

    public class SingleTagSectionHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C47F0
        public void Create(){} // RVA: 0x7AE9C4820
    }

    public class SpecialSettingAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_SpecialSetting(){} // RVA: 0x7AE9C4850
    }

    public class UriSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C4880
        public void get_Idn(){} // RVA: 0x7AE9C48B0
        public void get_IriParsing(){} // RVA: 0x7AE9C48E0
        public void get_Properties(){} // RVA: 0x7AE9C4910
        public void get_SchemeSettings(){} // RVA: 0x7AE9C4940
    }

    public class UserScopedSettingAttribute : SettingAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class UserSettingsGroup : ConfigurationSectionGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C4970
    }

}