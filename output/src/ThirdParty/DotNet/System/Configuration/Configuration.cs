// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Configuration
// Classes: 64
// Methods: 313

namespace ThirdParty.DotNet.System.Configuration
{
    public class AppSettingsReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9684600
        public void GetValue(){} // RVA: 0x7FFAF9684630
    }

    public class ApplicationScopedSettingAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ApplicationSettingsBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9683D60 | overloaded x4
        public void get_Context(){} // RVA: 0x7FFAF9683D90
        public void get_Item(){} // RVA: 0x7FFAF9683DC0
        public void set_Item(){} // RVA: 0x7FFAF9683DF0
        public void get_Properties(){} // RVA: 0x7FFAF9683E20
        public void get_PropertyValues(){} // RVA: 0x7FFAF9683E50
        public void get_Providers(){} // RVA: 0x7FFAF9683E80
        public void get_SettingsKey(){} // RVA: 0x7FFAF9683EB0
        public void set_SettingsKey(){} // RVA: 0x7FFAF9683EE0
        public void add_PropertyChanged(){} // RVA: 0x7FFAF9683F10
        public void remove_PropertyChanged(){} // RVA: 0x7FFAF9683F40
        public void add_SettingChanging(){} // RVA: 0x7FFAF9683F70
        public void remove_SettingChanging(){} // RVA: 0x7FFAF9683FA0
        public void add_SettingsLoaded(){} // RVA: 0x7FFAF9683FD0
        public void remove_SettingsLoaded(){} // RVA: 0x7FFAF9684000
        public void add_SettingsSaving(){} // RVA: 0x7FFAF9684030
        public void remove_SettingsSaving(){} // RVA: 0x7FFAF9684060
        public void GetPreviousVersion(){} // RVA: 0x7FFAF9684090
        public void OnPropertyChanged(){} // RVA: 0x7FFAF96840C0
        public void OnSettingChanging(){} // RVA: 0x7FFAF96840F0
        public void OnSettingsLoaded(){} // RVA: 0x7FFAF9684120
        public void OnSettingsSaving(){} // RVA: 0x7FFAF9684150
        public void Reload(){} // RVA: 0x7FFAF9684180
        public void Reset(){} // RVA: 0x7FFAF96841B0
        public void Save(){} // RVA: 0x7FFAF96841E0
        public void Upgrade(){} // RVA: 0x7FFAF9684210
    }

    public class ApplicationSettingsGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96845D0
    }

    public class ClientSettingsSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9684660
        public void get_Properties(){} // RVA: 0x7FFAF9684690
        public void get_Settings(){} // RVA: 0x7FFAF96846C0
    }

    public class ConfigXmlDocument
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9684CC0
        public void get_Filename(){} // RVA: 0x7FFAF9684CF0
        public void get_LineNumber(){} // RVA: 0x7FFAF9684D20
        public void System.Configuration.Internal.IConfigErrorInfo.get_Filename(){} // RVA: 0x7FFAF9684D50
        public void System.Configuration.Internal.IConfigErrorInfo.get_LineNumber(){} // RVA: 0x7FFAF9684D80
        public void LoadSingleElement(){} // RVA: 0x7FFAF9684DB0
    }

    public class Configuration
    {
    }

    public class ConfigurationCollectionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void set_AddItemName(){} // RVA: 0x7FFAF2D8D310
        public void set_ClearItemsName(){} // RVA: 0x7FFAF2D8D310
        public void set_CollectionType(){} // RVA: 0x7FFAF2D8D310
        public void set_RemoveItemName(){} // RVA: 0x7FFAF2D8D310
    }

    public class ConfigurationElement
    {
        // ── Methods ──
        public void get_Properties(){} // RVA: 0x7FFAF904DD00
        public void DeserializeElement(){} // RVA: 0x7FFAF904DD30
        public void InitializeDefault(){} // RVA: 0x7FFAF904DD60
        public void IsModified(){} // RVA: 0x7FFAF904DD90
        public void PostDeserialize(){} // RVA: 0x7FFAF904DDC0
        public void Reset(){} // RVA: 0x7FFAF904DDF0
        public void ResetModified(){} // RVA: 0x7FFAF904DE20
        public void SerializeToXmlElement(){} // RVA: 0x7FFAF904DE50
        public void Unmerge(){} // RVA: 0x7FFAF904DE80
    }

    public class ConfigurationElementCollection
    {
        // ── Methods ──
        public void get_CollectionType(){} // RVA: 0x7FFAF904DF70
        public void get_ElementName(){} // RVA: 0x7FFAF904DFA0
        public void get_ThrowOnDuplicate(){} // RVA: 0x7FFAF904DFD0
        public void CreateNewElement(){} // RVA: 0x7FFAF2ABCD60
        public void GetElementKey(){} // RVA: 0x7FFAF2ABCE10
    }

    public class ConfigurationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF967F800 | overloaded x8
        public void get_BareMessage(){} // RVA: 0x7FFAF967F830
        public void get_Filename(){} // RVA: 0x7FFAF967F860
        public void get_Line(){} // RVA: 0x7FFAF967F890
        public void GetXmlNodeFilename(){} // RVA: 0x7FFAF967F8C0
        public void GetXmlNodeLineNumber(){} // RVA: 0x7FFAF967F8F0
    }

    public class ConfigurationPropertyCollection
    {
    }

    public class ConfigurationSection
    {
        // ── Methods ──
        public void DeserializeSection(){} // RVA: 0x7FFAF904DEB0
        public void IsModified(){} // RVA: 0x7FFAF904DEE0
        public void ResetModified(){} // RVA: 0x7FFAF904DF10
        public void SerializeSection(){} // RVA: 0x7FFAF904DF40
    }

    public class ConfigurationSectionGroup
    {
    }

    public class ConfigurationSettings
    {
        public object Filename;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9684C30
        public void get_AppSettings(){} // RVA: 0x7FFAF9684C60
        public void GetConfig(){} // RVA: 0x7FFAF9684C90
    }

    public class DefaultSettingValueAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_Value(){} // RVA: 0x7FFAF9684DE0
    }

    public class DictionarySectionHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9684E10
        public void get_KeyAttributeName(){} // RVA: 0x7FFAF9684E40
        public void get_ValueAttributeName(){} // RVA: 0x7FFAF9684E70
        public void Create(){} // RVA: 0x7FFAF9684EA0
    }

    public class IApplicationSettingsProvider
    {
        // ── Methods ──
        public void GetPreviousVersion(){} // RVA: 0x7FFAF2ACE6A0
        public void Reset(){} // RVA: 0x7FFAF2AD4B10
        public void Upgrade(){} // RVA: 0x7FFAF2ADDC60
    }

    public class IConfigurationSectionHandler
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF2ACEE30
    }

    public class IConfigurationSystem
    {
        // ── Methods ──
        public void GetConfig(){} // RVA: 0x7FFAF2ABCE10
        public void Init(){} // RVA: 0x7FFAF2AD4A50
    }

    public class IPersistComponentSettings
    {
        // ── Methods ──
        public void get_SaveSettings(){} // RVA: 0x7FFAF2ABDBE0
        public void set_SaveSettings(){} // RVA: 0x7FFAF2AD5130
        public void get_SettingsKey(){} // RVA: 0x7FFAF2ABCD60
        public void set_SettingsKey(){} // RVA: 0x7FFAF2AD4B10
        public void LoadComponentSettings(){} // RVA: 0x7FFAF2AD4A50
        public void ResetComponentSettings(){} // RVA: 0x7FFAF2AD4A50
        public void SaveComponentSettings(){} // RVA: 0x7FFAF2AD4A50
    }

    public class ISettingsProviderService
    {
        // ── Methods ──
        public void GetSettingsProvider(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IdnElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9684ED0
        public void get_Enabled(){} // RVA: 0x7FFAF9684F00
        public void set_Enabled(){} // RVA: 0x7FFAF9684F30
        public void get_Properties(){} // RVA: 0x7FFAF9684F60
    }

    public class IgnoreSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF904E030
        public void get_Properties(){} // RVA: 0x7FFAF904E060
        public void DeserializeSection(){} // RVA: 0x7FFAF904E090
        public void IsModified(){} // RVA: 0x7FFAF904E0C0
        public void Reset(){} // RVA: 0x7FFAF904E0F0
        public void ResetModified(){} // RVA: 0x7FFAF904E120
        public void SerializeSection(){} // RVA: 0x7FFAF904E150
    }

    public class IgnoreSectionHandler : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9684F90
        public void Create(){} // RVA: 0x7FFAF9684FC0
    }

    public class IriParsingElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9684FF0
        public void get_Enabled(){} // RVA: 0x7FFAF9685020
        public void set_Enabled(){} // RVA: 0x7FFAF9685050
        public void get_Properties(){} // RVA: 0x7FFAF9685080
    }

    public class LocalFileSettingsProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96850B0
        public void get_ApplicationName(){} // RVA: 0x7FFAF96850E0
        public void set_ApplicationName(){} // RVA: 0x7FFAF9685110
        public void GetPreviousVersion(){} // RVA: 0x7FFAF9685140
        public void GetPropertyValues(){} // RVA: 0x7FFAF9685170
        public void Initialize(){} // RVA: 0x7FFAF96851A0
        public void Reset(){} // RVA: 0x7FFAF96851D0
        public void SetPropertyValues(){} // RVA: 0x7FFAF9685200
        public void Upgrade(){} // RVA: 0x7FFAF9685230
    }

    public class NameValueFileSectionHandler : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9685260
        public void Create(){} // RVA: 0x7FFAF9685290
    }

    public class NameValueSectionHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96852C0
        public void get_KeyAttributeName(){} // RVA: 0x7FFAF96852F0
        public void get_ValueAttributeName(){} // RVA: 0x7FFAF9685320
        public void Create(){} // RVA: 0x7FFAF9685350
    }

    public class NoSettingsVersionUpgradeAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SchemeSettingElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9685380
        public void get_GenericUriParserOptions(){} // RVA: 0x7FFAF96853B0
        public void get_Name(){} // RVA: 0x7FFAF96853E0
        public void get_Properties(){} // RVA: 0x7FFAF9685410
    }

    public class SchemeSettingElementCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9685440
        public void get_CollectionType(){} // RVA: 0x7FFAF9685470
        public void get_Item(){} // RVA: 0x7FFAF96854D0 | overloaded x2
        public void CreateNewElement(){} // RVA: 0x7FFAF9685500
        public void GetElementKey(){} // RVA: 0x7FFAF9685530
        public void IndexOf(){} // RVA: 0x7FFAF9685560
    }

    public class SettingAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SettingChangingEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9684300
        public void get_NewValue(){} // RVA: 0x7FFAF9684330
        public void get_SettingClass(){} // RVA: 0x7FFAF9684360
        public void get_SettingKey(){} // RVA: 0x7FFAF9684390
        public void get_SettingName(){} // RVA: 0x7FFAF96843C0
    }

    public class SettingChangingEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9684240
        public void Invoke(){} // RVA: 0x7FFAF9684270
        public void BeginInvoke(){} // RVA: 0x7FFAF96842A0
        public void EndInvoke(){} // RVA: 0x7FFAF96842D0
    }

    public class SettingElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96848D0 | overloaded x2
        public void get_Name(){} // RVA: 0x7FFAF9684900
        public void set_Name(){} // RVA: 0x7FFAF9684930
        public void get_Properties(){} // RVA: 0x7FFAF9684960
        public void get_SerializeAs(){} // RVA: 0x7FFAF9684990
        public void set_SerializeAs(){} // RVA: 0x7FFAF96849C0
        public void get_Value(){} // RVA: 0x7FFAF96849F0
        public void set_Value(){} // RVA: 0x7FFAF9684A20
    }

    public class SettingElementCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96846F0
        public void get_CollectionType(){} // RVA: 0x7FFAF9684720
        public void get_ElementName(){} // RVA: 0x7FFAF9684750
        public void Add(){} // RVA: 0x7FFAF9684780
        public void Clear(){} // RVA: 0x7FFAF96847B0
        public void CreateNewElement(){} // RVA: 0x7FFAF96847E0
        public void Get(){} // RVA: 0x7FFAF9684810
        public void GetElementKey(){} // RVA: 0x7FFAF9684840
        public void Remove(){} // RVA: 0x7FFAF9684870
    }

    public class SettingValueElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9684A50
        public void get_Properties(){} // RVA: 0x7FFAF9684A80
        public void get_ValueXml(){} // RVA: 0x7FFAF9684AB0
        public void set_ValueXml(){} // RVA: 0x7FFAF9684AE0
        public void DeserializeElement(){} // RVA: 0x7FFAF9684B10
        public void IsModified(){} // RVA: 0x7FFAF9684B40
        public void Reset(){} // RVA: 0x7FFAF9684B70
        public void ResetModified(){} // RVA: 0x7FFAF9684BA0
        public void SerializeToXmlElement(){} // RVA: 0x7FFAF9684BD0
        public void Unmerge(){} // RVA: 0x7FFAF9684C00
    }

    public class SettingsAttributeDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9680760 | overloaded x2
    }

    public class SettingsBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF967F920
        public void get_Context(){} // RVA: 0x7FFAF967F950
        public void get_IsSynchronized(){} // RVA: 0x7FFAF967F980
        public void get_Item(){} // RVA: 0x7FFAF967F9B0
        public void set_Item(){} // RVA: 0x7FFAF967F9E0
        public void get_Properties(){} // RVA: 0x7FFAF967FA10
        public void get_PropertyValues(){} // RVA: 0x7FFAF967FA40
        public void get_Providers(){} // RVA: 0x7FFAF967FA70
        public void Initialize(){} // RVA: 0x7FFAF967FAA0
        public void Save(){} // RVA: 0x7FFAF967FAD0
        public void Synchronized(){} // RVA: 0x7FFAF967FB00
    }

    public class SettingsContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF967FB30
    }

    public class SettingsDescriptionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_Description(){} // RVA: 0x7FFAF9685590
    }

    public class SettingsGroupDescriptionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_Description(){} // RVA: 0x7FFAF96855C0
    }

    public class SettingsGroupNameAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_GroupName(){} // RVA: 0x7FFAF96855F0
    }

    public class SettingsLoadedEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96844B0
        public void get_Provider(){} // RVA: 0x7FFAF96844E0
    }

    public class SettingsLoadedEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96843F0
        public void Invoke(){} // RVA: 0x7FFAF9684420
        public void BeginInvoke(){} // RVA: 0x7FFAF9684450
        public void EndInvoke(){} // RVA: 0x7FFAF9684480
    }

    public class SettingsManageabilityAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_Manageability(){} // RVA: 0x7FFAF9685620
    }

    public class SettingsProperty
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF967FF20 | overloaded x3
        public void get_Attributes(){} // RVA: 0x7FFAF967FF50
        public void get_DefaultValue(){} // RVA: 0x7FFAF967FF80
        public void set_DefaultValue(){} // RVA: 0x7FFAF967FFB0
        public void get_IsReadOnly(){} // RVA: 0x7FFAF967FFE0
        public void set_IsReadOnly(){} // RVA: 0x7FFAF9680010
        public void get_Name(){} // RVA: 0x7FFAF9680040
        public void set_Name(){} // RVA: 0x7FFAF9680070
        public void get_PropertyType(){} // RVA: 0x7FFAF96800A0
        public void set_PropertyType(){} // RVA: 0x7FFAF96800D0
        public void get_Provider(){} // RVA: 0x7FFAF9680100
        public void set_Provider(){} // RVA: 0x7FFAF9680130
        public void get_SerializeAs(){} // RVA: 0x7FFAF9680160
        public void set_SerializeAs(){} // RVA: 0x7FFAF9680190
        public void get_ThrowOnErrorDeserializing(){} // RVA: 0x7FFAF96801C0
        public void set_ThrowOnErrorDeserializing(){} // RVA: 0x7FFAF96801F0
        public void get_ThrowOnErrorSerializing(){} // RVA: 0x7FFAF9680220
        public void set_ThrowOnErrorSerializing(){} // RVA: 0x7FFAF9680250
    }

    public class SettingsPropertyCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF967FB60
        public void get_Count(){} // RVA: 0x7FFAF967FB90
        public void get_IsSynchronized(){} // RVA: 0x7FFAF967FBC0
        public void get_Item(){} // RVA: 0x7FFAF967FBF0
        public void get_SyncRoot(){} // RVA: 0x7FFAF967FC20
        public void Add(){} // RVA: 0x7FFAF967FC50
        public void Clear(){} // RVA: 0x7FFAF967FC80
        public void Clone(){} // RVA: 0x7FFAF967FCB0
        public void CopyTo(){} // RVA: 0x7FFAF967FCE0
        public void GetEnumerator(){} // RVA: 0x7FFAF967FD10
        public void OnAdd(){} // RVA: 0x7FFAF967FD40
        public void OnAddComplete(){} // RVA: 0x7FFAF967FD70
        public void OnClear(){} // RVA: 0x7FFAF967FDA0
        public void OnClearComplete(){} // RVA: 0x7FFAF967FDD0
        public void OnRemove(){} // RVA: 0x7FFAF967FE00
        public void OnRemoveComplete(){} // RVA: 0x7FFAF967FE30
        public void Remove(){} // RVA: 0x7FFAF967FE60
        public void SetReadOnly(){} // RVA: 0x7FFAF967FE90
    }

    public class SettingsPropertyIsReadOnlyException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96856E0 | overloaded x4
    }

    public class SettingsPropertyNotFoundException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96857A0 | overloaded x4
    }

    public class SettingsPropertyValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96804F0
        public void get_Deserialized(){} // RVA: 0x7FFAF9680520
        public void set_Deserialized(){} // RVA: 0x7FFAF9680550
        public void get_IsDirty(){} // RVA: 0x7FFAF9680580
        public void set_IsDirty(){} // RVA: 0x7FFAF96805B0
        public void get_Name(){} // RVA: 0x7FFAF96805E0
        public void get_Property(){} // RVA: 0x7FFAF9680610
        public void get_PropertyValue(){} // RVA: 0x7FFAF9680640
        public void set_PropertyValue(){} // RVA: 0x7FFAF9680670
        public void get_SerializedValue(){} // RVA: 0x7FFAF96806A0
        public void set_SerializedValue(){} // RVA: 0x7FFAF96806D0
        public void get_UsingDefaultValue(){} // RVA: 0x7FFAF9680700
    }

    public class SettingsPropertyValueCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96802B0
        public void get_Count(){} // RVA: 0x7FFAF96802E0
        public void get_IsSynchronized(){} // RVA: 0x7FFAF9680310
        public void get_Item(){} // RVA: 0x7FFAF9680340
        public void get_SyncRoot(){} // RVA: 0x7FFAF9680370
        public void Add(){} // RVA: 0x7FFAF96803A0
        public void Clear(){} // RVA: 0x7FFAF96803D0
        public void Clone(){} // RVA: 0x7FFAF9680400
        public void CopyTo(){} // RVA: 0x7FFAF9680430
        public void GetEnumerator(){} // RVA: 0x7FFAF9680460
        public void Remove(){} // RVA: 0x7FFAF9680490
        public void SetReadOnly(){} // RVA: 0x7FFAF96804C0
    }

    public class SettingsPropertyWrongTypeException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9685860 | overloaded x4
    }

    public class SettingsProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9680280
        public void get_ApplicationName(){} // RVA: 0x7FFAF2ABCD60
        public void set_ApplicationName(){} // RVA: 0x7FFAF2AD4B10
        public void GetPropertyValues(){} // RVA: 0x7FFAF2ACE6A0
        public void SetPropertyValues(){} // RVA: 0x7FFAF2ADDC60
    }

    public class SettingsProviderAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void get_ProviderTypeName(){} // RVA: 0x7FFAF9685890
    }

    public class SettingsProviderCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9680790
        public void get_Item(){} // RVA: 0x7FFAF96807C0
        public void Add(){} // RVA: 0x7FFAF96807F0
    }

    public class SettingsSavingEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9684510
        public void Invoke(){} // RVA: 0x7FFAF9684540
        public void BeginInvoke(){} // RVA: 0x7FFAF9684570
        public void EndInvoke(){} // RVA: 0x7FFAF96845A0
    }

    public class SettingsSerializeAsAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_SerializeAs(){} // RVA: 0x7FFAF96858C0
    }

    public class SingleTagSectionHandler : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96858F0
        public void Create(){} // RVA: 0x7FFAF9685920
    }

    public class SpecialSettingAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_SpecialSetting(){} // RVA: 0x7FFAF9685950
    }

    public class UriSection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9685980
        public void get_Idn(){} // RVA: 0x7FFAF96859B0
        public void get_IriParsing(){} // RVA: 0x7FFAF96859E0
        public void get_Properties(){} // RVA: 0x7FFAF9685A10
        public void get_SchemeSettings(){} // RVA: 0x7FFAF9685A40
    }

    public class UserScopedSettingAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class UserSettingsGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9685A70
    }

}