// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 9
// Methods: 203

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class TimeSpanConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x6C7BC00
        public void CanConvertTo(){} // RVA: 0x6C7BCF0
        public void ConvertFrom(){} // RVA: 0x6C7BDE0
        public void ConvertTo(){} // RVA: 0x6C7C020
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ToolboxItemAttribute
    {
        public System.Type _toolboxItemType; // 0x10
        public string _toolboxItemTypeName; // 0x18

        // ── Methods ──
        public void IsDefaultAttribute(){} // RVA: 0x6C60EC0
        public void .ctor(){} // RVA: 0x6C61150 | overloaded x3
        public void get_ToolboxItemType(){} // RVA: 0x6C61240
        public void get_ToolboxItemTypeName(){} // RVA: 0x6C613D0
        public void Equals(){} // RVA: 0x6C61430
        public void GetHashCode(){} // RVA: 0x6C615A0
        public void .cctor(){} // RVA: 0x6C615E0
    }

    public class ToolboxItemFilterAttribute
    {
        public string _typeId; // 0x10
        public string <FilterString>k__BackingField; // 0x18
        public 0x65850718 <FilterType>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C7C420 | overloaded x2
        public void get_FilterString(){} // RVA: 0x2E07C0
        public void get_FilterType(){} // RVA: 0x760030
        public void get_TypeId(){} // RVA: 0x6C7C4E0
        public void Equals(){} // RVA: 0x6C7C580
        public void GetHashCode(){} // RVA: 0x1DE6980
        public void Match(){} // RVA: 0x6C7C6C0
        public void ToString(){} // RVA: 0x6C7C770
    }

    public class TypeConverter
    {
        public string s_UseCompatibleTypeConverterBehavior;

        // ── Methods ──
        public void get_UseCompatibleTypeConversion(){} // RVA: 0x6C9B160
        public void CanConvertFrom(){} // RVA: 0x6C9B1A0 | overloaded x2
        public void CanConvertTo(){} // RVA: 0x6C9B290 | overloaded x2
        public void ConvertFrom(){} // RVA: 0x6C9B420 | overloaded x2
        public void ConvertFromInvariantString(){} // RVA: 0x6C9B550 | overloaded x2
        public void ConvertFromString(){} // RVA: 0x6BF8CE0 | overloaded x3
        public void ConvertTo(){} // RVA: 0x6C9B750 | overloaded x2
        public void ConvertToInvariantString(){} // RVA: 0x6C9B9E0 | overloaded x2
        public void ConvertToString(){} // RVA: 0x6C9BE10 | overloaded x3
        public void CreateInstance(){} // RVA: 0x519240 | overloaded x2
        public void GetConvertFromException(){} // RVA: 0x6C9BF80
        public void GetConvertToException(){} // RVA: 0x6C9C0D0
        public void GetCreateInstanceSupported(){} // RVA: 0x2DD320 | overloaded x2
        public void GetProperties(){} // RVA: 0x519240 | overloaded x3
        public void GetPropertiesSupported(){} // RVA: 0x2DD320 | overloaded x2
        public void GetStandardValues(){} // RVA: 0x519240 | overloaded x2
        public void GetStandardValuesExclusive(){} // RVA: 0x2DD320 | overloaded x2
        public void GetStandardValuesSupported(){} // RVA: 0x2DD320 | overloaded x2
        public void IsValid(){} // RVA: 0x6C9C510 | overloaded x2
        public void SortProperties(){} // RVA: 0x6C9C630
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TypeConverterAttribute
    {
        public System.ComponentModel.TypeConverterAttribute Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_ConverterTypeName(){} // RVA: 0x2F8380
        public void Equals(){} // RVA: 0x6C7C9E0
        public void GetHashCode(){} // RVA: 0x99E0E0
        public void .cctor(){} // RVA: 0x6C7CA90
    }

    public class TypeDescriptionProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void CreateInstance(){} // RVA: 0x6C7CBC0
        public void GetCache(){} // RVA: 0x6C7CCF0
        public void GetExtendedTypeDescriptor(){} // RVA: 0x6C7CD10
        public void GetExtenderProviders(){} // RVA: 0x6C7CDF0
        public void GetFullComponentName(){} // RVA: 0x6C7CEC0
        public void GetReflectionType(){} // RVA: 0x6C7D070 | overloaded x3
        public void GetRuntimeType(){} // RVA: 0x6C7D0A0
        public void GetTypeDescriptor(){} // RVA: 0x6C7D340 | overloaded x3
        public void IsSupportedType(){} // RVA: 0x6C7D430
    }

    public class TypeDescriptionProviderAttribute
    {
        public string <TypeName>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C7D5B0 | overloaded x2
        public void get_TypeName(){} // RVA: 0x2F8380
    }

    public class TypeDescriptor
    {
        public System.ComponentModel.WeakHashtable _providerTable;
        public System.Collections.Hashtable _providerTypeTable; // 0x8
        public System.Collections.Hashtable _defaultProviders; // 0x10
        public System.ComponentModel.WeakHashtable _associationTable; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_ComNativeDescriptorHandler(){} // RVA: 0x6C9D010
        public void set_ComNativeDescriptorHandler(){} // RVA: 0x6C9D100
        public void get_ComObjectType(){} // RVA: 0x6C9D2F0
        public void get_InterfaceType(){} // RVA: 0x6C9D3A0
        public void get_MetadataVersion(){} // RVA: 0x6C9D450
        public void add_Refreshed(){} // RVA: 0x6C9D4B0
        public void remove_Refreshed(){} // RVA: 0x6C9D600
        public void AddAttributes(){} // RVA: 0x6C9D930 | overloaded x2
        public void AddEditorTable(){} // RVA: 0x6C9DAD0
        public void AddProvider(){} // RVA: 0x6C9DEE0 | overloaded x2
        public void AddProviderTransparent(){} // RVA: 0x6C9E3E0 | overloaded x2
        public void CheckDefaultProvider(){} // RVA: 0x6C9E4E0
        public void CreateAssociation(){} // RVA: 0x6C9ED30
        public void CreateDesigner(){} // RVA: 0x6C9F6F0
        public void CreateEvent(){} // RVA: 0x6C9FB80 | overloaded x2
        public void CreateInstance(){} // RVA: 0x6C9FC00
        public void CreateProperty(){} // RVA: 0x6C9FF50 | overloaded x2
        public void DebugValidate(){} // RVA: 0x2DD310 | overloaded x10
        public void FilterMembers(){} // RVA: 0x6CA0140
        public void GetAssociation(){} // RVA: 0x6CA03A0
        public void GetAttributes(){} // RVA: 0x6CA0A90 | overloaded x3
        public void GetCache(){} // RVA: 0x6CA0D90
        public void GetClassName(){} // RVA: 0x6CA0F90 | overloaded x3
        public void GetComponentName(){} // RVA: 0x6CA10F0 | overloaded x2
        public void GetConverter(){} // RVA: 0x6CA12C0 | overloaded x3
        public void ConvertFromInvariantString(){} // RVA: 0x6CA1350
        public void GetDefaultEvent(){} // RVA: 0x6CA1550 | overloaded x3
        public void GetDefaultProperty(){} // RVA: 0x6CA1770 | overloaded x3
        public void GetDescriptor(){} // RVA: 0x6CA1940 | overloaded x2
        public void GetExtendedDescriptor(){} // RVA: 0x6CA1C70
        public void GetEditor(){} // RVA: 0x6CA1FD0 | overloaded x3
        public void GetEvents(){} // RVA: 0x6CA2540 | overloaded x6
        public void GetExtenderCollisionSuffix(){} // RVA: 0x6CA28A0
        public void GetFullComponentName(){} // RVA: 0x6CA2B50
        public void GetNodeForBaseType(){} // RVA: 0x6CA2C50
        public void GetProperties(){} // RVA: 0x6CA3200 | overloaded x6
        public void GetPropertiesImpl(){} // RVA: 0x6CA3280
        public void GetProvider(){} // RVA: 0x6CA3720 | overloaded x2
        public void GetProviderRecursive(){} // RVA: 0x6CA37C0
        public void GetReflectionType(){} // RVA: 0x6CA3950 | overloaded x2
        public void NodeFor(){} // RVA: 0x6CA4170 | overloaded x4
        public void NodeRemove(){} // RVA: 0x6CA4360
        public void PipelineAttributeFilter(){} // RVA: 0x6CA48F0
        public void PipelineFilter(){} // RVA: 0x6CA4E00
        public void PipelineInitialize(){} // RVA: 0x6CA5FF0
        public void PipelineMerge(){} // RVA: 0x6CA63B0
        public void RaiseRefresh(){} // RVA: 0x6CA6FE0 | overloaded x2
        public void Refresh(){} // RVA: 0x6CA8720 | overloaded x5
        public void RemoveAssociation(){} // RVA: 0x6CA87E0
        public void RemoveAssociations(){} // RVA: 0x6CA8B90
        public void RemoveProvider(){} // RVA: 0x6CA8D90 | overloaded x2
        public void RemoveProviderTransparent(){} // RVA: 0x6CA9030 | overloaded x2
        public void ShouldHideMember(){} // RVA: 0x6CA9170
        public void SortDescriptorArray(){} // RVA: 0x6CA9230
        public void Trace(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x6CA9350
    }

    public class TypeListConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void CanConvertFrom(){} // RVA: 0x6C7D6C0
        public void CanConvertTo(){} // RVA: 0x6C7D7B0
        public void ConvertFrom(){} // RVA: 0x6C7D8A0
        public void ConvertTo(){} // RVA: 0x6C7D9F0
        public void GetStandardValues(){} // RVA: 0x6C7DB80
        public void GetStandardValuesExclusive(){} // RVA: 0x3C2850
        public void GetStandardValuesSupported(){} // RVA: 0x3C2850
    }

}