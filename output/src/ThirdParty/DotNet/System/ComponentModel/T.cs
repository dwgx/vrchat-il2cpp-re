// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 9
// Methods: 203

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class TimeSpanConverter : TypeConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x7FFE877BCAB0
        public void CanConvertTo(){} // RVA: 0x7FFE877BCBA0
        public void ConvertFrom(){} // RVA: 0x7FFE877BCC90
        public void ConvertTo(){} // RVA: 0x7FFE877BCED0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ToolboxItemAttribute : Attribute
    {
        public System.Type _toolboxItemType; // 0x10
        public string _toolboxItemTypeName; // 0x18

        // ── Methods ──
        public void IsDefaultAttribute(){} // RVA: 0x7FFE877A1D70
        public void .ctor(){} // RVA: 0x7FFE877A2000 | overloaded x3
        public void get_ToolboxItemType(){} // RVA: 0x7FFE877A20F0
        public void get_ToolboxItemTypeName(){} // RVA: 0x7FFE877A2280
        public void Equals(){} // RVA: 0x7FFE877A22E0
        public void GetHashCode(){} // RVA: 0x7FFE877A2450
        public void .cctor(){} // RVA: 0x7FFE877A2490
    }

    public class ToolboxItemFilterAttribute : Attribute
    {
        public string _typeId; // 0x10
        public string _filterString; // 0x18
        public 0x6652E6BC _filterType; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877BD2D0 | overloaded x2
        public void get_FilterString(){} // RVA: 0x7FFE810FE7C0
        public void get_FilterType(){} // RVA: 0x7FFE8151D690
        public void get_TypeId(){} // RVA: 0x7FFE877BD390
        public void Equals(){} // RVA: 0x7FFE877BD430
        public void GetHashCode(){} // RVA: 0x7FFE82B72360
        public void Match(){} // RVA: 0x7FFE877BD570
        public void ToString(){} // RVA: 0x7FFE877BD620
    }

    public class TypeConverter : Object
    {
        public string s_UseCompatibleTypeConverterBehavior;

        // ── Methods ──
        public void get_UseCompatibleTypeConversion(){} // RVA: 0x7FFE877DC010
        public void CanConvertFrom(){} // RVA: 0x7FFE877DC050 | overloaded x2
        public void CanConvertTo(){} // RVA: 0x7FFE877DC140 | overloaded x2
        public void ConvertFrom(){} // RVA: 0x7FFE877DC2D0 | overloaded x2
        public void ConvertFromInvariantString(){} // RVA: 0x7FFE877DC400 | overloaded x2
        public void ConvertFromString(){} // RVA: 0x7FFE87739B90 | overloaded x3
        public void ConvertTo(){} // RVA: 0x7FFE877DC600 | overloaded x2
        public void ConvertToInvariantString(){} // RVA: 0x7FFE877DC890 | overloaded x2
        public void ConvertToString(){} // RVA: 0x7FFE877DCCC0 | overloaded x3
        public void CreateInstance(){} // RVA: 0x7FFE813240E0 | overloaded x2
        public void GetConvertFromException(){} // RVA: 0x7FFE877DCE30
        public void GetConvertToException(){} // RVA: 0x7FFE877DCF80
        public void GetCreateInstanceSupported(){} // RVA: 0x7FFE810FB320 | overloaded x2
        public void GetProperties(){} // RVA: 0x7FFE813240E0 | overloaded x3
        public void GetPropertiesSupported(){} // RVA: 0x7FFE810FB320 | overloaded x2
        public void GetStandardValues(){} // RVA: 0x7FFE813240E0 | overloaded x2
        public void GetStandardValuesExclusive(){} // RVA: 0x7FFE810FB320 | overloaded x2
        public void GetStandardValuesSupported(){} // RVA: 0x7FFE810FB320 | overloaded x2
        public void IsValid(){} // RVA: 0x7FFE877DD3C0 | overloaded x2
        public void SortProperties(){} // RVA: 0x7FFE877DD4E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TypeConverterAttribute : Attribute
    {
        public System.ComponentModel.TypeConverterAttribute Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_ConverterTypeName(){} // RVA: 0x7FFE81116380
        public void Equals(){} // RVA: 0x7FFE877BD890
        public void GetHashCode(){} // RVA: 0x7FFE8170B620
        public void .cctor(){} // RVA: 0x7FFE877BD940
    }

    public class TypeDescriptionProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void CreateInstance(){} // RVA: 0x7FFE877BDA70
        public void GetCache(){} // RVA: 0x7FFE877BDBA0
        public void GetExtendedTypeDescriptor(){} // RVA: 0x7FFE877BDBC0
        public void GetExtenderProviders(){} // RVA: 0x7FFE877BDCA0
        public void GetFullComponentName(){} // RVA: 0x7FFE877BDD70
        public void GetReflectionType(){} // RVA: 0x7FFE877BDF20 | overloaded x3
        public void GetRuntimeType(){} // RVA: 0x7FFE877BDF50
        public void GetTypeDescriptor(){} // RVA: 0x7FFE877BE1F0 | overloaded x3
        public void IsSupportedType(){} // RVA: 0x7FFE877BE2E0
    }

    public class TypeDescriptionProviderAttribute : Attribute
    {
        public string _typeName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877BE460 | overloaded x2
        public void get_TypeName(){} // RVA: 0x7FFE81116380
    }

    public class TypeDescriptor : Object
    {
        public System.ComponentModel.WeakHashtable _providerTable;
        public System.Collections.Hashtable _providerTypeTable; // 0x8
        public System.Collections.Hashtable _defaultProviders; // 0x10
        public System.ComponentModel.WeakHashtable _associationTable; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_ComNativeDescriptorHandler(){} // RVA: 0x7FFE877DDEC0
        public void set_ComNativeDescriptorHandler(){} // RVA: 0x7FFE877DDFB0
        public void get_ComObjectType(){} // RVA: 0x7FFE877DE1A0
        public void get_InterfaceType(){} // RVA: 0x7FFE877DE250
        public void get_MetadataVersion(){} // RVA: 0x7FFE877DE300
        public void add_Refreshed(){} // RVA: 0x7FFE877DE360
        public void remove_Refreshed(){} // RVA: 0x7FFE877DE4B0
        public void AddAttributes(){} // RVA: 0x7FFE877DE7E0 | overloaded x2
        public void AddEditorTable(){} // RVA: 0x7FFE877DE980
        public void AddProvider(){} // RVA: 0x7FFE877DED90 | overloaded x2
        public void AddProviderTransparent(){} // RVA: 0x7FFE877DF290 | overloaded x2
        public void CheckDefaultProvider(){} // RVA: 0x7FFE877DF390
        public void CreateAssociation(){} // RVA: 0x7FFE877DFBE0
        public void CreateDesigner(){} // RVA: 0x7FFE877E05A0
        public void CreateEvent(){} // RVA: 0x7FFE877E0A30 | overloaded x2
        public void CreateInstance(){} // RVA: 0x7FFE877E0AB0
        public void CreateProperty(){} // RVA: 0x7FFE877E0E00 | overloaded x2
        public void DebugValidate(){} // RVA: 0x7FFE810FB310 | overloaded x10
        public void FilterMembers(){} // RVA: 0x7FFE877E0FF0
        public void GetAssociation(){} // RVA: 0x7FFE877E1250
        public void GetAttributes(){} // RVA: 0x7FFE877E1940 | overloaded x3
        public void GetCache(){} // RVA: 0x7FFE877E1C40
        public void GetClassName(){} // RVA: 0x7FFE877E1E40 | overloaded x3
        public void GetComponentName(){} // RVA: 0x7FFE877E1FA0 | overloaded x2
        public void GetConverter(){} // RVA: 0x7FFE877E2170 | overloaded x3
        public void ConvertFromInvariantString(){} // RVA: 0x7FFE877E2200
        public void GetDefaultEvent(){} // RVA: 0x7FFE877E2400 | overloaded x3
        public void GetDefaultProperty(){} // RVA: 0x7FFE877E2620 | overloaded x3
        public void GetDescriptor(){} // RVA: 0x7FFE877E27F0 | overloaded x2
        public void GetExtendedDescriptor(){} // RVA: 0x7FFE877E2B20
        public void GetEditor(){} // RVA: 0x7FFE877E2E80 | overloaded x3
        public void GetEvents(){} // RVA: 0x7FFE877E33F0 | overloaded x6
        public void GetExtenderCollisionSuffix(){} // RVA: 0x7FFE877E3750
        public void GetFullComponentName(){} // RVA: 0x7FFE877E3A00
        public void GetNodeForBaseType(){} // RVA: 0x7FFE877E3B00
        public void GetProperties(){} // RVA: 0x7FFE877E40B0 | overloaded x6
        public void GetPropertiesImpl(){} // RVA: 0x7FFE877E4130
        public void GetProvider(){} // RVA: 0x7FFE877E45D0 | overloaded x2
        public void GetProviderRecursive(){} // RVA: 0x7FFE877E4670
        public void GetReflectionType(){} // RVA: 0x7FFE877E4800 | overloaded x2
        public void NodeFor(){} // RVA: 0x7FFE877E5020 | overloaded x4
        public void NodeRemove(){} // RVA: 0x7FFE877E5210
        public void PipelineAttributeFilter(){} // RVA: 0x7FFE877E57A0
        public void PipelineFilter(){} // RVA: 0x7FFE877E5CB0
        public void PipelineInitialize(){} // RVA: 0x7FFE877E6EA0
        public void PipelineMerge(){} // RVA: 0x7FFE877E7260
        public void RaiseRefresh(){} // RVA: 0x7FFE877E7E90 | overloaded x2
        public void Refresh(){} // RVA: 0x7FFE877E95D0 | overloaded x5
        public void RemoveAssociation(){} // RVA: 0x7FFE877E9690
        public void RemoveAssociations(){} // RVA: 0x7FFE877E9A40
        public void RemoveProvider(){} // RVA: 0x7FFE877E9C40 | overloaded x2
        public void RemoveProviderTransparent(){} // RVA: 0x7FFE877E9EE0 | overloaded x2
        public void ShouldHideMember(){} // RVA: 0x7FFE877EA020
        public void SortDescriptorArray(){} // RVA: 0x7FFE877EA0E0
        public void Trace(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE877EA200
    }

    public class TypeListConverter : TypeConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void CanConvertFrom(){} // RVA: 0x7FFE877BE570
        public void CanConvertTo(){} // RVA: 0x7FFE877BE660
        public void ConvertFrom(){} // RVA: 0x7FFE877BE750
        public void ConvertTo(){} // RVA: 0x7FFE877BE8A0
        public void GetStandardValues(){} // RVA: 0x7FFE877BEA30
        public void GetStandardValuesExclusive(){} // RVA: 0x7FFE811E0850
        public void GetStandardValuesSupported(){} // RVA: 0x7FFE811E0850
    }

}