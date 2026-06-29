// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 10
// Methods: 138

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class TimeSpanConverter : TypeConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x76B2D50
        public void CanConvertTo(){} // RVA: 0x76DB610
        public void ConvertFrom(){} // RVA: 0x76DB710
        public void ConvertTo(){} // RVA: 0x76DB940
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ToolboxItemAttribute : Attribute
    {
        public object _toolboxItemType;
        public object _toolboxItemTypeName;
        public object Default;
        public object None;

        // ── Methods ──
        public void IsDefaultAttribute(){} // RVA: 0x76C0F50
        public void .ctor(){} // RVA: 0x76C11E0
        public void get_ToolboxItemType(){} // RVA: 0x76C12D0
        public void get_ToolboxItemTypeName(){} // RVA: 0x7503900
        public void Equals(){} // RVA: 0x76C1450
        public void GetHashCode(){} // RVA: 0x76C1550
        public void .cctor(){} // RVA: 0x76C1590
    }

    public class ToolboxItemFilterAttribute : Attribute
    {
        public object _typeId;
        public object _filterString;
        public object _filterType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76DBD30
        public void get_FilterString(){} // RVA: 0xB465B0
        public void get_FilterType(){} // RVA: 0xFEAE90
        public void get_TypeId(){} // RVA: 0x76DBDB0
        public void Equals(){} // RVA: 0x76DBE50
        public void GetHashCode(){} // RVA: 0x266A270
        public void Match(){} // RVA: 0x76DBF90
        public void ToString(){} // RVA: 0x76DC040
    }

    public class TypeConverter : Object
    {
        public object s_UseCompatibleTypeConverterBehavior;
        public object useCompatibleTypeConversion;

        // ── Methods ──
        public void get_UseCompatibleTypeConversion(){} // RVA: 0x76FA600
        public void CanConvertFrom(){} // RVA: 0x76FA640
        public void CanConvertTo(){} // RVA: 0x6E365B0
        public void ConvertFrom(){} // RVA: 0x76FA7C0
        public void ConvertFromInvariantString(){} // RVA: 0x76FA8F0
        public void ConvertFromString(){} // RVA: 0x7659E20
        public void ConvertTo(){} // RVA: 0x76FAAF0
        public void ConvertToInvariantString(){} // RVA: 0x76FAD80
        public void ConvertToString(){} // RVA: 0x76FB110
        public void CreateInstance(){} // RVA: 0xDAC980
        public void GetConvertFromException(){} // RVA: 0x76FB220
        public void GetConvertToException(){} // RVA: 0x76FB370
        public void GetCreateInstanceSupported(){} // RVA: 0xB43320
        public void GetProperties(){} // RVA: 0xDAC980
        public void GetPropertiesSupported(){} // RVA: 0xB43320
        public void GetStandardValues(){} // RVA: 0xDAC980
        public void GetStandardValuesExclusive(){} // RVA: 0xB43320
        public void GetStandardValuesSupported(){} // RVA: 0xB43320
        public void IsValid(){} // RVA: 0x76FB7B0
        public void SortProperties(){} // RVA: 0x76FB8D0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TypeConverterAttribute : Attribute
    {
        public object Default;
        public object _converterTypeName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_ConverterTypeName(){} // RVA: 0xB5DBF0
        public void Equals(){} // RVA: 0x76DC1C0
        public void GetHashCode(){} // RVA: 0x1269730
        public void .cctor(){} // RVA: 0x76DC270
    }

    public class TypeDescriptionProvider : Object
    {
        public object _parent;
        public object _emptyDescriptor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void CreateInstance(){} // RVA: 0x76DC370
        public void GetCache(){} // RVA: 0x76DC440
        public void GetExtendedTypeDescriptor(){} // RVA: 0x76DC460
        public void GetExtenderProviders(){} // RVA: 0x76DC540
        public void GetFullComponentName(){} // RVA: 0x76DC610
        public void GetReflectionType(){} // RVA: 0x76DC7C0
        public void GetRuntimeType(){} // RVA: 0x76DC7F0
        public void GetTypeDescriptor(){} // RVA: 0x76DCA90
        public void IsSupportedType(){} // RVA: 0x76DCB80
    }

    public class TypeDescriptionProviderAttribute : Attribute
    {
        public object _typeName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76DCCE0
        public void get_TypeName(){} // RVA: 0xB5DBF0
    }

    public class TypeDescriptionProviderAttribute[] : Array
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

    public class TypeDescriptor : Object
    {
        public object _providerTable;
        public object _providerTypeTable;
        public object _defaultProviders;
        public object _associationTable;
        public object _metadataVersion;
        public object _collisionIndex;
        public object TraceDescriptor;
        public object PIPELINE_ATTRIBUTES;
        public object PIPELINE_PROPERTIES;
        public object PIPELINE_EVENTS;
        public object _pipelineInitializeKeys;
        public object _pipelineMergeKeys;
        public object _pipelineFilterKeys;
        public object _pipelineAttributeFilterKeys;
        public object _internalSyncObject;
        public object Refreshed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_ComNativeDescriptorHandler(){} // RVA: 0x76FC220
        public void set_ComNativeDescriptorHandler(){} // RVA: 0x76FC310
        public void get_ComObjectType(){} // RVA: 0x76FC580
        public void get_InterfaceType(){} // RVA: 0x76FC600
        public void get_MetadataVersion(){} // RVA: 0x76FC680
        public void add_Refreshed(){} // RVA: 0x76FC6E0
        public void remove_Refreshed(){} // RVA: 0x76FC830
        public void AddAttributes(){} // RVA: 0x76FCB40
        public void AddEditorTable(){} // RVA: 0x76FCCE0
        public void AddProvider(){} // RVA: 0x76FD0A0
        public void AddProviderTransparent(){} // RVA: 0x76FD560
        public void CheckDefaultProvider(){} // RVA: 0x76FD660
        public void CreateAssociation(){} // RVA: 0x76FDE70
        public void CreateDesigner(){} // RVA: 0x76FE780
        public void CreateEvent(){} // RVA: 0x76FEBD0
        public void CreateInstance(){} // RVA: 0x76FEC50
        public void CreateProperty(){} // RVA: 0x76FEFB0
        public void DebugValidate(){} // RVA: 0xB43310
        public void FilterMembers(){} // RVA: 0x76FF1B0
        public void GetAssociation(){} // RVA: 0x76FF410
        public void GetAttributes(){} // RVA: 0x76FFAB0
        public void GetCache(){} // RVA: 0x76FFDA0
        public void GetClassName(){} // RVA: 0x76FFFA0
        public void GetComponentName(){} // RVA: 0x7700100
        public void GetConverter(){} // RVA: 0x77002D0
        public void ConvertFromInvariantString(){} // RVA: 0x7700360
        public void GetDefaultEvent(){} // RVA: 0x7700550
        public void GetDefaultProperty(){} // RVA: 0x7700760
        public void GetDescriptor(){} // RVA: 0x7700920
        public void GetExtendedDescriptor(){} // RVA: 0x7700C50
        public void GetEditor(){} // RVA: 0x7700F90
        public void GetEvents(){} // RVA: 0x77014D0
        public void GetExtenderCollisionSuffix(){} // RVA: 0x7701820
        public void GetFullComponentName(){} // RVA: 0x7701A90
        public void GetNodeForBaseType(){} // RVA: 0x7701B90
        public void GetProperties(){} // RVA: 0x7702110
        public void GetPropertiesImpl(){} // RVA: 0x7702190
        public void GetProvider(){} // RVA: 0x7702610
        public void GetProviderRecursive(){} // RVA: 0x77026B0
        public void GetReflectionType(){} // RVA: 0x7702830
        public void NodeFor(){} // RVA: 0x7703010
        public void NodeRemove(){} // RVA: 0x7703200
        public void PipelineAttributeFilter(){} // RVA: 0x7703740
        public void PipelineFilter(){} // RVA: 0x7703C50
        public void PipelineInitialize(){} // RVA: 0x7704DF0
        public void PipelineMerge(){} // RVA: 0x77051B0
        public void RaiseRefresh(){} // RVA: 0x7705DC0
        public void Refresh(){} // RVA: 0x7707380
        public void RemoveAssociation(){} // RVA: 0x7707440
        public void RemoveAssociations(){} // RVA: 0x77077B0
        public void RemoveProvider(){} // RVA: 0x77079A0
        public void RemoveProviderTransparent(){} // RVA: 0x7707C20
        public void ShouldHideMember(){} // RVA: 0x7707D60
        public void SortDescriptorArray(){} // RVA: 0x7707E20
        public void Trace(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x7707F40
    }

    public class TypeListConverter : TypeConverter
    {
        public object _types;
        public object _values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void CanConvertFrom(){} // RVA: 0x76B5B40
        public void CanConvertTo(){} // RVA: 0x76DCDD0
        public void ConvertFrom(){} // RVA: 0x76DCED0
        public void ConvertTo(){} // RVA: 0x76DD010
        public void GetStandardValues(){} // RVA: 0x76DD1B0
        public void GetStandardValuesExclusive(){} // RVA: 0xC2E4C0
        public void GetStandardValuesSupported(){} // RVA: 0xC2E4C0
    }

}