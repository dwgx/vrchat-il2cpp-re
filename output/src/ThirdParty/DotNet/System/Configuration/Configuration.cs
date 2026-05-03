// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Configuration
// Classes: 64
// Methods: 313

namespace ThirdParty.DotNet.System.Configuration
{
    public class AppSettingsReader : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877154B0
        public void GetValue(){} // RVA: 0x7FFE877154E0
    }

    public class ApplicationScopedSettingAttribute : SettingAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ApplicationSettingsBase : SettingsBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87714C10 | overloaded x4
        public void get_Context(){} // RVA: 0x7FFE87714C40
        public void get_Item(){} // RVA: 0x7FFE87714C70
        public void set_Item(){} // RVA: 0x7FFE87714CA0
        public void get_Properties(){} // RVA: 0x7FFE87714CD0
        public void get_PropertyValues(){} // RVA: 0x7FFE87714D00
        public void get_Providers(){} // RVA: 0x7FFE87714D30
        public void get_SettingsKey(){} // RVA: 0x7FFE87714D60
        public void set_SettingsKey(){} // RVA: 0x7FFE87714D90
        public void add_PropertyChanged(){} // RVA: 0x7FFE87714DC0
        public void remove_PropertyChanged(){} // RVA: 0x7FFE87714DF0
        public void add_SettingChanging(){} // RVA: 0x7FFE87714E20
        public void remove_SettingChanging(){} // RVA: 0x7FFE87714E50
        public void add_SettingsLoaded(){} // RVA: 0x7FFE87714E80
        public void remove_SettingsLoaded(){} // RVA: 0x7FFE87714EB0
        public void add_SettingsSaving(){} // RVA: 0x7FFE87714EE0
        public void remove_SettingsSaving(){} // RVA: 0x7FFE87714F10
        public void GetPreviousVersion(){} // RVA: 0x7FFE87714F40
        public void OnPropertyChanged(){} // RVA: 0x7FFE87714F70
        public void OnSettingChanging(){} // RVA: 0x7FFE87714FA0
        public void OnSettingsLoaded(){} // RVA: 0x7FFE87714FD0
        public void OnSettingsSaving(){} // RVA: 0x7FFE87715000
        public void Reload(){} // RVA: 0x7FFE87715030
        public void Reset(){} // RVA: 0x7FFE87715060
        public void Save(){} // RVA: 0x7FFE87715090
        public void Upgrade(){} // RVA: 0x7FFE877150C0
    }

    public class ApplicationSettingsGroup : ConfigurationSectionGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87715480
    }

    public class ClientSettingsSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87715510
        public void get_Properties(){} // RVA: 0x7FFE87715540
        public void get_Settings(){} // RVA: 0x7FFE87715570
    }

    public class ConfigXmlDocument : XmlDocument
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87715B70
        public void get_Filename(){} // RVA: 0x7FFE87715BA0
        public void get_LineNumber(){} // RVA: 0x7FFE87715BD0
        public void System.Configuration.Internal.IConfigErrorInfo.get_Filename(){} // RVA: 0x7FFE87715C00
        public void System.Configuration.Internal.IConfigErrorInfo.get_LineNumber(){} // RVA: 0x7FFE87715C30
        public void LoadSingleElement(){} // RVA: 0x7FFE87715C60
    }

    public class Configuration : Object
    {
    }

    public class ConfigurationCollectionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void set_AddItemName(){} // RVA: 0x7FFE810FB310
        public void set_ClearItemsName(){} // RVA: 0x7FFE810FB310
        public void set_CollectionType(){} // RVA: 0x7FFE810FB310
        public void set_RemoveItemName(){} // RVA: 0x7FFE810FB310
    }

    public class ConfigurationElement : Object
    {
        // ── Methods ──
        public void get_Properties(){} // RVA: 0x7FFE870DCD90
        public void DeserializeElement(){} // RVA: 0x7FFE870DCDC0
        public void InitializeDefault(){} // RVA: 0x7FFE870DCDF0
        public void IsModified(){} // RVA: 0x7FFE870DCE20
        public void PostDeserialize(){} // RVA: 0x7FFE870DCE50
        public void Reset(){} // RVA: 0x7FFE870DCE80
        public void ResetModified(){} // RVA: 0x7FFE870DCEB0
        public void SerializeToXmlElement(){} // RVA: 0x7FFE870DCEE0
        public void Unmerge(){} // RVA: 0x7FFE870DCF10
    }

    public class ConfigurationElementCollection : ConfigurationElement
    {
        // ── Methods ──
        public void get_CollectionType(){} // RVA: 0x7FFE870DD000
        public void get_ElementName(){} // RVA: 0x7FFE870DD030
        public void get_ThrowOnDuplicate(){} // RVA: 0x7FFE870DD060
        public void CreateNewElement(){} // RVA: 0x7FFE80E2E2E0
        public void GetElementKey(){} // RVA: 0x7FFE80E2E390
    }

    public class ConfigurationException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877106B0 | overloaded x8
        public void get_BareMessage(){} // RVA: 0x7FFE877106E0
        public void get_Filename(){} // RVA: 0x7FFE87710710
        public void get_Line(){} // RVA: 0x7FFE87710740
        public void GetXmlNodeFilename(){} // RVA: 0x7FFE87710770
        public void GetXmlNodeLineNumber(){} // RVA: 0x7FFE877107A0
    }

    public class ConfigurationPropertyCollection : Object
    {
    }

    public class ConfigurationSection : ConfigurationElement
    {
        // ── Methods ──
        public void DeserializeSection(){} // RVA: 0x7FFE870DCF40
        public void IsModified(){} // RVA: 0x7FFE870DCF70
        public void ResetModified(){} // RVA: 0x7FFE870DCFA0
        public void SerializeSection(){} // RVA: 0x7FFE870DCFD0
    }

    public class ConfigurationSectionGroup : Object
    {
    }

    public class ConfigurationSettings : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87715AE0
        public void get_AppSettings(){} // RVA: 0x7FFE87715B10
        public void GetConfig(){} // RVA: 0x7FFE87715B40
    }

    public class DefaultSettingValueAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Value(){} // RVA: 0x7FFE87715C90
    }

    public class DictionarySectionHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87715CC0
        public void get_KeyAttributeName(){} // RVA: 0x7FFE87715CF0
        public void get_ValueAttributeName(){} // RVA: 0x7FFE87715D20
        public void Create(){} // RVA: 0x7FFE87715D50
    }

    public class IApplicationSettingsProvider
    {
        // ── Methods ──
        public void GetPreviousVersion(){} // RVA: 0x7FFE80E3FC10
        public void Reset(){} // RVA: 0x7FFE80E460A0
        public void Upgrade(){} // RVA: 0x7FFE80E4F230
    }

    public class IConfigurationSectionHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE80E403A0
    }

    public class IConfigurationSystem
    {
        // ── Methods ──
        public void GetConfig(){} // RVA: 0x7FFE80E2E390
        public void Init(){} // RVA: 0x7FFE80E45FE0
    }

    public class IPersistComponentSettings
    {
        // ── Methods ──
        public void get_SaveSettings(){} // RVA: 0x7FFE80E2F150
        public void set_SaveSettings(){} // RVA: 0x7FFE80E466C0
        public void get_SettingsKey(){} // RVA: 0x7FFE80E2E2E0
        public void set_SettingsKey(){} // RVA: 0x7FFE80E460A0
        public void LoadComponentSettings(){} // RVA: 0x7FFE80E45FE0
        public void ResetComponentSettings(){} // RVA: 0x7FFE80E45FE0
        public void SaveComponentSettings(){} // RVA: 0x7FFE80E45FE0
    }

    public class ISettingsProviderService
    {
        // ── Methods ──
        public void GetSettingsProvider(){} // RVA: 0x7FFE80E2E390
    }

    public class IdnElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87715D80
        public void get_Enabled(){} // RVA: 0x7FFE87715DB0
        public void set_Enabled(){} // RVA: 0x7FFE87715DE0
        public void get_Properties(){} // RVA: 0x7FFE87715E10
    }

    public class IgnoreSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE870DD0C0
        public void get_Properties(){} // RVA: 0x7FFE870DD0F0
        public void DeserializeSection(){} // RVA: 0x7FFE870DD120
        public void IsModified(){} // RVA: 0x7FFE870DD150
        public void Reset(){} // RVA: 0x7FFE870DD180
        public void ResetModified(){} // RVA: 0x7FFE870DD1B0
        public void SerializeSection(){} // RVA: 0x7FFE870DD1E0
    }

    public class IgnoreSectionHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87715E40
        public void Create(){} // RVA: 0x7FFE87715E70
    }

    public class IriParsingElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87715EA0
        public void get_Enabled(){} // RVA: 0x7FFE87715ED0
        public void set_Enabled(){} // RVA: 0x7FFE87715F00
        public void get_Properties(){} // RVA: 0x7FFE87715F30
    }

    public class LocalFileSettingsProvider : SettingsProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87715F60
        public void get_ApplicationName(){} // RVA: 0x7FFE87715F90
        public void set_ApplicationName(){} // RVA: 0x7FFE87715FC0
        public void GetPreviousVersion(){} // RVA: 0x7FFE87715FF0
        public void GetPropertyValues(){} // RVA: 0x7FFE87716020
        public void Initialize(){} // RVA: 0x7FFE87716050
        public void Reset(){} // RVA: 0x7FFE87716080
        public void SetPropertyValues(){} // RVA: 0x7FFE877160B0
        public void Upgrade(){} // RVA: 0x7FFE877160E0
    }

    public class NameValueFileSectionHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87716110
        public void Create(){} // RVA: 0x7FFE87716140
    }

    public class NameValueSectionHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87716170
        public void get_KeyAttributeName(){} // RVA: 0x7FFE877161A0
        public void get_ValueAttributeName(){} // RVA: 0x7FFE877161D0
        public void Create(){} // RVA: 0x7FFE87716200
    }

    public class NoSettingsVersionUpgradeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SchemeSettingElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87716230
        public void get_GenericUriParserOptions(){} // RVA: 0x7FFE87716260
        public void get_Name(){} // RVA: 0x7FFE87716290
        public void get_Properties(){} // RVA: 0x7FFE877162C0
    }

    public class SchemeSettingElementCollection : ConfigurationElementCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877162F0
        public void get_CollectionType(){} // RVA: 0x7FFE87716320
        public void get_Item(){} // RVA: 0x7FFE87716380 | overloaded x2
        public void CreateNewElement(){} // RVA: 0x7FFE877163B0
        public void GetElementKey(){} // RVA: 0x7FFE877163E0
        public void IndexOf(){} // RVA: 0x7FFE87716410
    }

    public class SettingAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SettingChangingEventArgs : CancelEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877151B0
        public void get_NewValue(){} // RVA: 0x7FFE877151E0
        public void get_SettingClass(){} // RVA: 0x7FFE87715210
        public void get_SettingKey(){} // RVA: 0x7FFE87715240
        public void get_SettingName(){} // RVA: 0x7FFE87715270
    }

    public class SettingChangingEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877150F0
        public void Invoke(){} // RVA: 0x7FFE87715120
        public void BeginInvoke(){} // RVA: 0x7FFE87715150
        public void EndInvoke(){} // RVA: 0x7FFE87715180
    }

    public class SettingElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87715780 | overloaded x2
        public void get_Name(){} // RVA: 0x7FFE877157B0
        public void set_Name(){} // RVA: 0x7FFE877157E0
        public void get_Properties(){} // RVA: 0x7FFE87715810
        public void get_SerializeAs(){} // RVA: 0x7FFE87715840
        public void set_SerializeAs(){} // RVA: 0x7FFE87715870
        public void get_Value(){} // RVA: 0x7FFE877158A0
        public void set_Value(){} // RVA: 0x7FFE877158D0
    }

    public class SettingElementCollection : ConfigurationElementCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877155A0
        public void get_CollectionType(){} // RVA: 0x7FFE877155D0
        public void get_ElementName(){} // RVA: 0x7FFE87715600
        public void Add(){} // RVA: 0x7FFE87715630
        public void Clear(){} // RVA: 0x7FFE87715660
        public void CreateNewElement(){} // RVA: 0x7FFE87715690
        public void Get(){} // RVA: 0x7FFE877156C0
        public void GetElementKey(){} // RVA: 0x7FFE877156F0
        public void Remove(){} // RVA: 0x7FFE87715720
    }

    public class SettingValueElement : ConfigurationElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87715900
        public void get_Properties(){} // RVA: 0x7FFE87715930
        public void get_ValueXml(){} // RVA: 0x7FFE87715960
        public void set_ValueXml(){} // RVA: 0x7FFE87715990
        public void DeserializeElement(){} // RVA: 0x7FFE877159C0
        public void IsModified(){} // RVA: 0x7FFE877159F0
        public void Reset(){} // RVA: 0x7FFE87715A20
        public void ResetModified(){} // RVA: 0x7FFE87715A50
        public void SerializeToXmlElement(){} // RVA: 0x7FFE87715A80
        public void Unmerge(){} // RVA: 0x7FFE87715AB0
    }

    public class SettingsAttributeDictionary : Hashtable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87711610 | overloaded x2
    }

    public class SettingsBase : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877107D0
        public void get_Context(){} // RVA: 0x7FFE87710800
        public void get_IsSynchronized(){} // RVA: 0x7FFE87710830
        public void get_Item(){} // RVA: 0x7FFE87710860
        public void set_Item(){} // RVA: 0x7FFE87710890
        public void get_Properties(){} // RVA: 0x7FFE877108C0
        public void get_PropertyValues(){} // RVA: 0x7FFE877108F0
        public void get_Providers(){} // RVA: 0x7FFE87710920
        public void Initialize(){} // RVA: 0x7FFE87710950
        public void Save(){} // RVA: 0x7FFE87710980
        public void Synchronized(){} // RVA: 0x7FFE877109B0
    }

    public class SettingsContext : Hashtable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877109E0
    }

    public class SettingsDescriptionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Description(){} // RVA: 0x7FFE87716440
    }

    public class SettingsGroupDescriptionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Description(){} // RVA: 0x7FFE87716470
    }

    public class SettingsGroupNameAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_GroupName(){} // RVA: 0x7FFE877164A0
    }

    public class SettingsLoadedEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87715360
        public void get_Provider(){} // RVA: 0x7FFE87715390
    }

    public class SettingsLoadedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877152A0
        public void Invoke(){} // RVA: 0x7FFE877152D0
        public void BeginInvoke(){} // RVA: 0x7FFE87715300
        public void EndInvoke(){} // RVA: 0x7FFE87715330
    }

    public class SettingsManageabilityAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Manageability(){} // RVA: 0x7FFE877164D0
    }

    public class SettingsProperty : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87710DD0 | overloaded x3
        public void get_Attributes(){} // RVA: 0x7FFE87710E00
        public void get_DefaultValue(){} // RVA: 0x7FFE87710E30
        public void set_DefaultValue(){} // RVA: 0x7FFE87710E60
        public void get_IsReadOnly(){} // RVA: 0x7FFE87710E90
        public void set_IsReadOnly(){} // RVA: 0x7FFE87710EC0
        public void get_Name(){} // RVA: 0x7FFE87710EF0
        public void set_Name(){} // RVA: 0x7FFE87710F20
        public void get_PropertyType(){} // RVA: 0x7FFE87710F50
        public void set_PropertyType(){} // RVA: 0x7FFE87710F80
        public void get_Provider(){} // RVA: 0x7FFE87710FB0
        public void set_Provider(){} // RVA: 0x7FFE87710FE0
        public void get_SerializeAs(){} // RVA: 0x7FFE87711010
        public void set_SerializeAs(){} // RVA: 0x7FFE87711040
        public void get_ThrowOnErrorDeserializing(){} // RVA: 0x7FFE87711070
        public void set_ThrowOnErrorDeserializing(){} // RVA: 0x7FFE877110A0
        public void get_ThrowOnErrorSerializing(){} // RVA: 0x7FFE877110D0
        public void set_ThrowOnErrorSerializing(){} // RVA: 0x7FFE87711100
    }

    public class SettingsPropertyCollection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87710A10
        public void get_Count(){} // RVA: 0x7FFE87710A40
        public void get_IsSynchronized(){} // RVA: 0x7FFE87710A70
        public void get_Item(){} // RVA: 0x7FFE87710AA0
        public void get_SyncRoot(){} // RVA: 0x7FFE87710AD0
        public void Add(){} // RVA: 0x7FFE87710B00
        public void Clear(){} // RVA: 0x7FFE87710B30
        public void Clone(){} // RVA: 0x7FFE87710B60
        public void CopyTo(){} // RVA: 0x7FFE87710B90
        public void GetEnumerator(){} // RVA: 0x7FFE87710BC0
        public void OnAdd(){} // RVA: 0x7FFE87710BF0
        public void OnAddComplete(){} // RVA: 0x7FFE87710C20
        public void OnClear(){} // RVA: 0x7FFE87710C50
        public void OnClearComplete(){} // RVA: 0x7FFE87710C80
        public void OnRemove(){} // RVA: 0x7FFE87710CB0
        public void OnRemoveComplete(){} // RVA: 0x7FFE87710CE0
        public void Remove(){} // RVA: 0x7FFE87710D10
        public void SetReadOnly(){} // RVA: 0x7FFE87710D40
    }

    public class SettingsPropertyIsReadOnlyException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87716590 | overloaded x4
    }

    public class SettingsPropertyNotFoundException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87716650 | overloaded x4
    }

    public class SettingsPropertyValue : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877113A0
        public void get_Deserialized(){} // RVA: 0x7FFE877113D0
        public void set_Deserialized(){} // RVA: 0x7FFE87711400
        public void get_IsDirty(){} // RVA: 0x7FFE87711430
        public void set_IsDirty(){} // RVA: 0x7FFE87711460
        public void get_Name(){} // RVA: 0x7FFE87711490
        public void get_Property(){} // RVA: 0x7FFE877114C0
        public void get_PropertyValue(){} // RVA: 0x7FFE877114F0
        public void set_PropertyValue(){} // RVA: 0x7FFE87711520
        public void get_SerializedValue(){} // RVA: 0x7FFE87711550
        public void set_SerializedValue(){} // RVA: 0x7FFE87711580
        public void get_UsingDefaultValue(){} // RVA: 0x7FFE877115B0
    }

    public class SettingsPropertyValueCollection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87711160
        public void get_Count(){} // RVA: 0x7FFE87711190
        public void get_IsSynchronized(){} // RVA: 0x7FFE877111C0
        public void get_Item(){} // RVA: 0x7FFE877111F0
        public void get_SyncRoot(){} // RVA: 0x7FFE87711220
        public void Add(){} // RVA: 0x7FFE87711250
        public void Clear(){} // RVA: 0x7FFE87711280
        public void Clone(){} // RVA: 0x7FFE877112B0
        public void CopyTo(){} // RVA: 0x7FFE877112E0
        public void GetEnumerator(){} // RVA: 0x7FFE87711310
        public void Remove(){} // RVA: 0x7FFE87711340
        public void SetReadOnly(){} // RVA: 0x7FFE87711370
    }

    public class SettingsPropertyWrongTypeException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87716710 | overloaded x4
    }

    public class SettingsProvider : ProviderBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87711130
        public void get_ApplicationName(){} // RVA: 0x7FFE80E2E2E0
        public void set_ApplicationName(){} // RVA: 0x7FFE80E460A0
        public void GetPropertyValues(){} // RVA: 0x7FFE80E3FC10
        public void SetPropertyValues(){} // RVA: 0x7FFE80E4F230
    }

    public class SettingsProviderAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void get_ProviderTypeName(){} // RVA: 0x7FFE87716740
    }

    public class SettingsProviderCollection : ProviderCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87711640
        public void get_Item(){} // RVA: 0x7FFE87711670
        public void Add(){} // RVA: 0x7FFE877116A0
    }

    public class SettingsSavingEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877153C0
        public void Invoke(){} // RVA: 0x7FFE877153F0
        public void BeginInvoke(){} // RVA: 0x7FFE87715420
        public void EndInvoke(){} // RVA: 0x7FFE87715450
    }

    public class SettingsSerializeAsAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_SerializeAs(){} // RVA: 0x7FFE87716770
    }

    public class SingleTagSectionHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877167A0
        public void Create(){} // RVA: 0x7FFE877167D0
    }

    public class SpecialSettingAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_SpecialSetting(){} // RVA: 0x7FFE87716800
    }

    public class UriSection : ConfigurationSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87716830
        public void get_Idn(){} // RVA: 0x7FFE87716860
        public void get_IriParsing(){} // RVA: 0x7FFE87716890
        public void get_Properties(){} // RVA: 0x7FFE877168C0
        public void get_SchemeSettings(){} // RVA: 0x7FFE877168F0
    }

    public class UserScopedSettingAttribute : SettingAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UserSettingsGroup : ConfigurationSectionGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87716920
    }

}