// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Configuration
// Classes: 64
// Methods: 313

namespace ThirdParty.DotNet.System.Configuration
{
    public class AppSettingsReader : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936CD80
        public void GetValue(){} // RVA: 0x7FFAC936CDB0
    }

    public class ApplicationScopedSettingAttribute : SettingAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ApplicationSettingsBase : SettingsBase
    {
        public object Context;
        public object Item;
        public object Properties;
        public object PropertyValues;
        public object Providers;
        public object SettingsKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936C4E0 | overloaded x4
        public void get_Context(){} // RVA: 0x7FFAC936C510
        public void get_Item(){} // RVA: 0x7FFAC936C540
        public void set_Item(){} // RVA: 0x7FFAC936C570
        public void get_Properties(){} // RVA: 0x7FFAC936C5A0
        public void get_PropertyValues(){} // RVA: 0x7FFAC936C5D0
        public void get_Providers(){} // RVA: 0x7FFAC936C600
        public void get_SettingsKey(){} // RVA: 0x7FFAC936C630
        public void set_SettingsKey(){} // RVA: 0x7FFAC936C660
        public void add_PropertyChanged(){} // RVA: 0x7FFAC936C690
        public void remove_PropertyChanged(){} // RVA: 0x7FFAC936C6C0
        public void add_SettingChanging(){} // RVA: 0x7FFAC936C6F0
        public void remove_SettingChanging(){} // RVA: 0x7FFAC936C720
        public void add_SettingsLoaded(){} // RVA: 0x7FFAC936C750
        public void remove_SettingsLoaded(){} // RVA: 0x7FFAC936C780
        public void add_SettingsSaving(){} // RVA: 0x7FFAC936C7B0
        public void remove_SettingsSaving(){} // RVA: 0x7FFAC936C7E0
        public void GetPreviousVersion(){} // RVA: 0x7FFAC936C810
        public void OnPropertyChanged(){} // RVA: 0x7FFAC936C840
        public void OnSettingChanging(){} // RVA: 0x7FFAC936C870
        public void OnSettingsLoaded(){} // RVA: 0x7FFAC936C8A0
        public void OnSettingsSaving(){} // RVA: 0x7FFAC936C8D0
        public void Reload(){} // RVA: 0x7FFAC936C900
        public void Reset(){} // RVA: 0x7FFAC936C930
        public void Save(){} // RVA: 0x7FFAC936C960
        public void Upgrade(){} // RVA: 0x7FFAC936C990
    }

    public class ApplicationSettingsGroup : ConfigurationSectionGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936CD50
    }

    public class ClientSettingsSection : ConfigurationSection
    {
        public object Properties;
        public object Settings;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936CDE0
        public void get_Properties(){} // RVA: 0x7FFAC936CE10
        public void get_Settings(){} // RVA: 0x7FFAC936CE40
    }

    public class ConfigXmlDocument : XmlDocument
    {
        public object Filename;
        public object LineNumber;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936D440
        public void get_Filename(){} // RVA: 0x7FFAC936D470
        public void get_LineNumber(){} // RVA: 0x7FFAC936D4A0
        public void System.Configuration.Internal.IConfigErrorInfo.get_Filename(){} // RVA: 0x7FFAC936D4D0
        public void System.Configuration.Internal.IConfigErrorInfo.get_LineNumber(){} // RVA: 0x7FFAC936D500
        public void LoadSingleElement(){} // RVA: 0x7FFAC936D530
    }

    public class Configuration : Object
    {
    }

    public class ConfigurationCollectionAttribute : Attribute
    {
        public object AddItemName;
        public object ClearItemsName;
        public object CollectionType;
        public object RemoveItemName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void set_AddItemName(){} // RVA: 0x7FFAC2F21310
        public void set_ClearItemsName(){} // RVA: 0x7FFAC2F21310
        public void set_CollectionType(){} // RVA: 0x7FFAC2F21310
        public void set_RemoveItemName(){} // RVA: 0x7FFAC2F21310
    }

    public class ConfigurationElement : Object
    {
        public object Properties;

        // ── Methods ──
        public void get_Properties(){} // RVA: 0x7FFAC8D348A0
        public void DeserializeElement(){} // RVA: 0x7FFAC8D348D0
        public void InitializeDefault(){} // RVA: 0x7FFAC8D34900
        public void IsModified(){} // RVA: 0x7FFAC8D34930
        public void PostDeserialize(){} // RVA: 0x7FFAC8D34960
        public void Reset(){} // RVA: 0x7FFAC8D34990
        public void ResetModified(){} // RVA: 0x7FFAC8D349C0
        public void SerializeToXmlElement(){} // RVA: 0x7FFAC8D349F0
        public void Unmerge(){} // RVA: 0x7FFAC8D34A20
    }

    public class ConfigurationElementCollection : ConfigurationElement
    {
        public object CollectionType;
        public object ElementName;
        public object ThrowOnDuplicate;

        // ── Methods ──
        public void get_CollectionType(){} // RVA: 0x7FFAC8D34B10
        public void get_ElementName(){} // RVA: 0x7FFAC8D34B40
        public void get_ThrowOnDuplicate(){} // RVA: 0x7FFAC8D34B70
        public void CreateNewElement(){} // RVA: 0x7FFAC2C58E90
        public void GetElementKey(){} // RVA: 0x7FFAC2C58F40
    }

    public class ConfigurationException : SystemException
    {
        public object BareMessage;
        public object Filename;
        public object Line;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9367F80 | overloaded x8
        public void get_BareMessage(){} // RVA: 0x7FFAC9367FB0
        public void get_Filename(){} // RVA: 0x7FFAC9367FE0
        public void get_Line(){} // RVA: 0x7FFAC9368010
        public void GetXmlNodeFilename(){} // RVA: 0x7FFAC9368040
        public void GetXmlNodeLineNumber(){} // RVA: 0x7FFAC9368070
    }

    public class ConfigurationPropertyCollection : Object
    {
    }

    public class ConfigurationSection : ConfigurationElement
    {
        // ── Methods ──
        public void DeserializeSection(){} // RVA: 0x7FFAC8D34A50
        public void IsModified(){} // RVA: 0x7FFAC8D34A80
        public void ResetModified(){} // RVA: 0x7FFAC8D34AB0
        public void SerializeSection(){} // RVA: 0x7FFAC8D34AE0
    }

    public class ConfigurationSectionGroup : Object
    {
    }

    public class ConfigurationSettings : Object
    {
        public object AppSettings;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936D3B0
        public void get_AppSettings(){} // RVA: 0x7FFAC936D3E0
        public void GetConfig(){} // RVA: 0x7FFAC936D410
    }

    public class DefaultSettingValueAttribute : Attribute
    {
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Value(){} // RVA: 0x7FFAC936D560
    }

    public class DictionarySectionHandler : Object
    {
        public object KeyAttributeName;
        public object ValueAttributeName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936D590
        public void get_KeyAttributeName(){} // RVA: 0x7FFAC936D5C0
        public void get_ValueAttributeName(){} // RVA: 0x7FFAC936D5F0
        public void Create(){} // RVA: 0x7FFAC936D620
    }

    public class IApplicationSettingsProvider
    {
        // ── Methods ──
        public void GetPreviousVersion(){} // RVA: 0x7FFAC2C6A6F0
        public void Reset(){} // RVA: 0x7FFAC2C70A40
        public void Upgrade(){} // RVA: 0x7FFAC2C79B30
    }

    public class IConfigurationSectionHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC2C6AE80
    }

    public class IConfigurationSystem
    {
        // ── Methods ──
        public void GetConfig(){} // RVA: 0x7FFAC2C58F40
        public void Init(){} // RVA: 0x7FFAC2C70980
    }

    public class IPersistComponentSettings
    {
        public object SaveSettings;
        public object SettingsKey;

        // ── Methods ──
        public void get_SaveSettings(){} // RVA: 0x7FFAC2C59D00
        public void set_SaveSettings(){} // RVA: 0x7FFAC2C71060
        public void get_SettingsKey(){} // RVA: 0x7FFAC2C58E90
        public void set_SettingsKey(){} // RVA: 0x7FFAC2C70A40
        public void LoadComponentSettings(){} // RVA: 0x7FFAC2C70980
        public void ResetComponentSettings(){} // RVA: 0x7FFAC2C70980
        public void SaveComponentSettings(){} // RVA: 0x7FFAC2C70980
    }

    public class ISettingsProviderService
    {
        // ── Methods ──
        public void GetSettingsProvider(){} // RVA: 0x7FFAC2C58F40
    }

    public class IdnElement : ConfigurationElement
    {
        public object Enabled;
        public object Properties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936D650
        public void get_Enabled(){} // RVA: 0x7FFAC936D680
        public void set_Enabled(){} // RVA: 0x7FFAC936D6B0
        public void get_Properties(){} // RVA: 0x7FFAC936D6E0
    }

    public class IgnoreSection : ConfigurationSection
    {
        public object Properties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D34BD0
        public void get_Properties(){} // RVA: 0x7FFAC8D34C00
        public void DeserializeSection(){} // RVA: 0x7FFAC8D34C30
        public void IsModified(){} // RVA: 0x7FFAC8D34C60
        public void Reset(){} // RVA: 0x7FFAC8D34C90
        public void ResetModified(){} // RVA: 0x7FFAC8D34CC0
        public void SerializeSection(){} // RVA: 0x7FFAC8D34CF0
    }

    public class IgnoreSectionHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936D710
        public void Create(){} // RVA: 0x7FFAC936D740
    }

    public class IriParsingElement : ConfigurationElement
    {
        public object Enabled;
        public object Properties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936D770
        public void get_Enabled(){} // RVA: 0x7FFAC936D7A0
        public void set_Enabled(){} // RVA: 0x7FFAC936D7D0
        public void get_Properties(){} // RVA: 0x7FFAC936D800
    }

    public class LocalFileSettingsProvider : SettingsProvider
    {
        public object ApplicationName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936D830
        public void get_ApplicationName(){} // RVA: 0x7FFAC936D860
        public void set_ApplicationName(){} // RVA: 0x7FFAC936D890
        public void GetPreviousVersion(){} // RVA: 0x7FFAC936D8C0
        public void GetPropertyValues(){} // RVA: 0x7FFAC936D8F0
        public void Initialize(){} // RVA: 0x7FFAC936D920
        public void Reset(){} // RVA: 0x7FFAC936D950
        public void SetPropertyValues(){} // RVA: 0x7FFAC936D980
        public void Upgrade(){} // RVA: 0x7FFAC936D9B0
    }

    public class NameValueFileSectionHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936D9E0
        public void Create(){} // RVA: 0x7FFAC936DA10
    }

    public class NameValueSectionHandler : Object
    {
        public object KeyAttributeName;
        public object ValueAttributeName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936DA40
        public void get_KeyAttributeName(){} // RVA: 0x7FFAC936DA70
        public void get_ValueAttributeName(){} // RVA: 0x7FFAC936DAA0
        public void Create(){} // RVA: 0x7FFAC936DAD0
    }

    public class NoSettingsVersionUpgradeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SchemeSettingElement : ConfigurationElement
    {
        public object GenericUriParserOptions;
        public object Name;
        public object Properties;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936DB00
        public void get_GenericUriParserOptions(){} // RVA: 0x7FFAC936DB30
        public void get_Name(){} // RVA: 0x7FFAC936DB60
        public void get_Properties(){} // RVA: 0x7FFAC936DB90
    }

    public class SchemeSettingElementCollection : ConfigurationElementCollection
    {
        public object CollectionType;
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936DBC0
        public void get_CollectionType(){} // RVA: 0x7FFAC936DBF0
        public void get_Item(){} // RVA: 0x7FFAC936DC50 | overloaded x2
        public void CreateNewElement(){} // RVA: 0x7FFAC936DC80
        public void GetElementKey(){} // RVA: 0x7FFAC936DCB0
        public void IndexOf(){} // RVA: 0x7FFAC936DCE0
    }

    public class SettingAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SettingChangingEventArgs : CancelEventArgs
    {
        public object NewValue;
        public object SettingClass;
        public object SettingKey;
        public object SettingName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936CA80
        public void get_NewValue(){} // RVA: 0x7FFAC936CAB0
        public void get_SettingClass(){} // RVA: 0x7FFAC936CAE0
        public void get_SettingKey(){} // RVA: 0x7FFAC936CB10
        public void get_SettingName(){} // RVA: 0x7FFAC936CB40
    }

    public class SettingChangingEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936C9C0
        public void Invoke(){} // RVA: 0x7FFAC936C9F0
        public void BeginInvoke(){} // RVA: 0x7FFAC936CA20
        public void EndInvoke(){} // RVA: 0x7FFAC936CA50
    }

    public class SettingElement : ConfigurationElement
    {
        public object Name;
        public object Properties;
        public object SerializeAs;
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936D050 | overloaded x2
        public void get_Name(){} // RVA: 0x7FFAC936D080
        public void set_Name(){} // RVA: 0x7FFAC936D0B0
        public void get_Properties(){} // RVA: 0x7FFAC936D0E0
        public void get_SerializeAs(){} // RVA: 0x7FFAC936D110
        public void set_SerializeAs(){} // RVA: 0x7FFAC936D140
        public void get_Value(){} // RVA: 0x7FFAC936D170
        public void set_Value(){} // RVA: 0x7FFAC936D1A0
    }

    public class SettingElementCollection : ConfigurationElementCollection
    {
        public object CollectionType;
        public object ElementName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936CE70
        public void get_CollectionType(){} // RVA: 0x7FFAC936CEA0
        public void get_ElementName(){} // RVA: 0x7FFAC936CED0
        public void Add(){} // RVA: 0x7FFAC936CF00
        public void Clear(){} // RVA: 0x7FFAC936CF30
        public void CreateNewElement(){} // RVA: 0x7FFAC936CF60
        public void Get(){} // RVA: 0x7FFAC936CF90
        public void GetElementKey(){} // RVA: 0x7FFAC936CFC0
        public void Remove(){} // RVA: 0x7FFAC936CFF0
    }

    public class SettingValueElement : ConfigurationElement
    {
        public object Properties;
        public object ValueXml;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936D1D0
        public void get_Properties(){} // RVA: 0x7FFAC936D200
        public void get_ValueXml(){} // RVA: 0x7FFAC936D230
        public void set_ValueXml(){} // RVA: 0x7FFAC936D260
        public void DeserializeElement(){} // RVA: 0x7FFAC936D290
        public void IsModified(){} // RVA: 0x7FFAC936D2C0
        public void Reset(){} // RVA: 0x7FFAC936D2F0
        public void ResetModified(){} // RVA: 0x7FFAC936D320
        public void SerializeToXmlElement(){} // RVA: 0x7FFAC936D350
        public void Unmerge(){} // RVA: 0x7FFAC936D380
    }

    public class SettingsAttributeDictionary : Hashtable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9368EE0 | overloaded x2
    }

    public class SettingsBase : Object
    {
        public object Context;
        public object IsSynchronized;
        public object Item;
        public object Properties;
        public object PropertyValues;
        public object Providers;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93680A0
        public void get_Context(){} // RVA: 0x7FFAC93680D0
        public void get_IsSynchronized(){} // RVA: 0x7FFAC9368100
        public void get_Item(){} // RVA: 0x7FFAC9368130
        public void set_Item(){} // RVA: 0x7FFAC9368160
        public void get_Properties(){} // RVA: 0x7FFAC9368190
        public void get_PropertyValues(){} // RVA: 0x7FFAC93681C0
        public void get_Providers(){} // RVA: 0x7FFAC93681F0
        public void Initialize(){} // RVA: 0x7FFAC9368220
        public void Save(){} // RVA: 0x7FFAC9368250
        public void Synchronized(){} // RVA: 0x7FFAC9368280
    }

    public class SettingsContext : Hashtable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93682B0
    }

    public class SettingsDescriptionAttribute : Attribute
    {
        public object Description;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Description(){} // RVA: 0x7FFAC936DD10
    }

    public class SettingsGroupDescriptionAttribute : Attribute
    {
        public object Description;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Description(){} // RVA: 0x7FFAC936DD40
    }

    public class SettingsGroupNameAttribute : Attribute
    {
        public object GroupName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_GroupName(){} // RVA: 0x7FFAC936DD70
    }

    public class SettingsLoadedEventArgs : EventArgs
    {
        public object Provider;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936CC30
        public void get_Provider(){} // RVA: 0x7FFAC936CC60
    }

    public class SettingsLoadedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936CB70
        public void Invoke(){} // RVA: 0x7FFAC936CBA0
        public void BeginInvoke(){} // RVA: 0x7FFAC936CBD0
        public void EndInvoke(){} // RVA: 0x7FFAC936CC00
    }

    public class SettingsManageabilityAttribute : Attribute
    {
        public object Manageability;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Manageability(){} // RVA: 0x7FFAC936DDA0
    }

    public class SettingsProperty : Object
    {
        public object Attributes;
        public object DefaultValue;
        public object IsReadOnly;
        public object Name;
        public object PropertyType;
        public object Provider;
        public object SerializeAs;
        public object ThrowOnErrorDeserializing;
        public object ThrowOnErrorSerializing;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93686A0 | overloaded x3
        public void get_Attributes(){} // RVA: 0x7FFAC93686D0
        public void get_DefaultValue(){} // RVA: 0x7FFAC9368700
        public void set_DefaultValue(){} // RVA: 0x7FFAC9368730
        public void get_IsReadOnly(){} // RVA: 0x7FFAC9368760
        public void set_IsReadOnly(){} // RVA: 0x7FFAC9368790
        public void get_Name(){} // RVA: 0x7FFAC93687C0
        public void set_Name(){} // RVA: 0x7FFAC93687F0
        public void get_PropertyType(){} // RVA: 0x7FFAC9368820
        public void set_PropertyType(){} // RVA: 0x7FFAC9368850
        public void get_Provider(){} // RVA: 0x7FFAC9368880
        public void set_Provider(){} // RVA: 0x7FFAC93688B0
        public void get_SerializeAs(){} // RVA: 0x7FFAC93688E0
        public void set_SerializeAs(){} // RVA: 0x7FFAC9368910
        public void get_ThrowOnErrorDeserializing(){} // RVA: 0x7FFAC9368940
        public void set_ThrowOnErrorDeserializing(){} // RVA: 0x7FFAC9368970
        public void get_ThrowOnErrorSerializing(){} // RVA: 0x7FFAC93689A0
        public void set_ThrowOnErrorSerializing(){} // RVA: 0x7FFAC93689D0
    }

    public class SettingsPropertyCollection : Object
    {
        public object Count;
        public object IsSynchronized;
        public object Item;
        public object SyncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93682E0
        public void get_Count(){} // RVA: 0x7FFAC9368310
        public void get_IsSynchronized(){} // RVA: 0x7FFAC9368340
        public void get_Item(){} // RVA: 0x7FFAC9368370
        public void get_SyncRoot(){} // RVA: 0x7FFAC93683A0
        public void Add(){} // RVA: 0x7FFAC93683D0
        public void Clear(){} // RVA: 0x7FFAC9368400
        public void Clone(){} // RVA: 0x7FFAC9368430
        public void CopyTo(){} // RVA: 0x7FFAC9368460
        public void GetEnumerator(){} // RVA: 0x7FFAC9368490
        public void OnAdd(){} // RVA: 0x7FFAC93684C0
        public void OnAddComplete(){} // RVA: 0x7FFAC93684F0
        public void OnClear(){} // RVA: 0x7FFAC9368520
        public void OnClearComplete(){} // RVA: 0x7FFAC9368550
        public void OnRemove(){} // RVA: 0x7FFAC9368580
        public void OnRemoveComplete(){} // RVA: 0x7FFAC93685B0
        public void Remove(){} // RVA: 0x7FFAC93685E0
        public void SetReadOnly(){} // RVA: 0x7FFAC9368610
    }

    public class SettingsPropertyIsReadOnlyException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936DE60 | overloaded x4
    }

    public class SettingsPropertyNotFoundException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936DF20 | overloaded x4
    }

    public class SettingsPropertyValue : Object
    {
        public object Deserialized;
        public object IsDirty;
        public object Name;
        public object Property;
        public object PropertyValue;
        public object SerializedValue;
        public object UsingDefaultValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9368C70
        public void get_Deserialized(){} // RVA: 0x7FFAC9368CA0
        public void set_Deserialized(){} // RVA: 0x7FFAC9368CD0
        public void get_IsDirty(){} // RVA: 0x7FFAC9368D00
        public void set_IsDirty(){} // RVA: 0x7FFAC9368D30
        public void get_Name(){} // RVA: 0x7FFAC9368D60
        public void get_Property(){} // RVA: 0x7FFAC9368D90
        public void get_PropertyValue(){} // RVA: 0x7FFAC9368DC0
        public void set_PropertyValue(){} // RVA: 0x7FFAC9368DF0
        public void get_SerializedValue(){} // RVA: 0x7FFAC9368E20
        public void set_SerializedValue(){} // RVA: 0x7FFAC9368E50
        public void get_UsingDefaultValue(){} // RVA: 0x7FFAC9368E80
    }

    public class SettingsPropertyValueCollection : Object
    {
        public object Count;
        public object IsSynchronized;
        public object Item;
        public object SyncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9368A30
        public void get_Count(){} // RVA: 0x7FFAC9368A60
        public void get_IsSynchronized(){} // RVA: 0x7FFAC9368A90
        public void get_Item(){} // RVA: 0x7FFAC9368AC0
        public void get_SyncRoot(){} // RVA: 0x7FFAC9368AF0
        public void Add(){} // RVA: 0x7FFAC9368B20
        public void Clear(){} // RVA: 0x7FFAC9368B50
        public void Clone(){} // RVA: 0x7FFAC9368B80
        public void CopyTo(){} // RVA: 0x7FFAC9368BB0
        public void GetEnumerator(){} // RVA: 0x7FFAC9368BE0
        public void Remove(){} // RVA: 0x7FFAC9368C10
        public void SetReadOnly(){} // RVA: 0x7FFAC9368C40
    }

    public class SettingsPropertyWrongTypeException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936DFE0 | overloaded x4
    }

    public class SettingsProvider : ProviderBase
    {
        public object ApplicationName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9368A00
        public void get_ApplicationName(){} // RVA: 0x7FFAC2C58E90
        public void set_ApplicationName(){} // RVA: 0x7FFAC2C70A40
        public void GetPropertyValues(){} // RVA: 0x7FFAC2C6A6F0
        public void SetPropertyValues(){} // RVA: 0x7FFAC2C79B30
    }

    public class SettingsProviderAttribute : Attribute
    {
        public object ProviderTypeName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void get_ProviderTypeName(){} // RVA: 0x7FFAC936E010
    }

    public class SettingsProviderCollection : ProviderCollection
    {
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9368F10
        public void get_Item(){} // RVA: 0x7FFAC9368F40
        public void Add(){} // RVA: 0x7FFAC9368F70
    }

    public class SettingsSavingEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936CC90
        public void Invoke(){} // RVA: 0x7FFAC936CCC0
        public void BeginInvoke(){} // RVA: 0x7FFAC936CCF0
        public void EndInvoke(){} // RVA: 0x7FFAC936CD20
    }

    public class SettingsSerializeAsAttribute : Attribute
    {
        public object SerializeAs;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_SerializeAs(){} // RVA: 0x7FFAC936E040
    }

    public class SingleTagSectionHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936E070
        public void Create(){} // RVA: 0x7FFAC936E0A0
    }

    public class SpecialSettingAttribute : Attribute
    {
        public object SpecialSetting;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_SpecialSetting(){} // RVA: 0x7FFAC936E0D0
    }

    public class UriSection : ConfigurationSection
    {
        public object Idn;
        public object IriParsing;
        public object Properties;
        public object SchemeSettings;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936E100
        public void get_Idn(){} // RVA: 0x7FFAC936E130
        public void get_IriParsing(){} // RVA: 0x7FFAC936E160
        public void get_Properties(){} // RVA: 0x7FFAC936E190
        public void get_SchemeSettings(){} // RVA: 0x7FFAC936E1C0
    }

    public class UserScopedSettingAttribute : SettingAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UserSettingsGroup : ConfigurationSectionGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936E1F0
    }

}