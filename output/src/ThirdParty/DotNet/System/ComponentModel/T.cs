// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 9
// Methods: 203

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class TimeSpanConverter : TypeConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x7FFAC9414380
        public void CanConvertTo(){} // RVA: 0x7FFAC9414470
        public void ConvertFrom(){} // RVA: 0x7FFAC9414560
        public void ConvertTo(){} // RVA: 0x7FFAC94147A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ToolboxItemAttribute : Attribute
    {
        public System.Type ToolboxItemType; // 0x10
        public string ToolboxItemTypeName; // 0x18
        public System.ComponentModel.ToolboxItemAttribute Default;
        public System.ComponentModel.ToolboxItemAttribute None; // 0x8

        // ── Methods ──
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC93F9640
        public void .ctor(){} // RVA: 0x7FFAC93F98D0 | overloaded x3
        public void get_ToolboxItemType(){} // RVA: 0x7FFAC93F99C0
        public void get_ToolboxItemTypeName(){} // RVA: 0x7FFAC93F9B50
        public void Equals(){} // RVA: 0x7FFAC93F9BB0
        public void GetHashCode(){} // RVA: 0x7FFAC93F9D20
        public void .cctor(){} // RVA: 0x7FFAC93F9D60
    }

    public class ToolboxItemFilterAttribute : Attribute
    {
        public string FilterString; // 0x10
        public string FilterType; // 0x18
        public 0x6B135798 TypeId; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9414BA0 | overloaded x2
        public void get_FilterString(){} // RVA: 0x7FFAC2F247C0
        public void get_FilterType(){} // RVA: 0x7FFAC30DBBE0
        public void get_TypeId(){} // RVA: 0x7FFAC9414C60
        public void Equals(){} // RVA: 0x7FFAC9414D00
        public void GetHashCode(){} // RVA: 0x7FFAC490A6E0
        public void Match(){} // RVA: 0x7FFAC9414E40
        public void ToString(){} // RVA: 0x7FFAC9414EF0
    }

    public class TypeConverter : Object
    {
        public string UseCompatibleTypeConversion;
        public bool useCompatibleTypeConversion;

        // ── Methods ──
        public void get_UseCompatibleTypeConversion(){} // RVA: 0x7FFAC94338E0
        public void CanConvertFrom(){} // RVA: 0x7FFAC9433920 | overloaded x2
        public void CanConvertTo(){} // RVA: 0x7FFAC9433A10 | overloaded x2
        public void ConvertFrom(){} // RVA: 0x7FFAC9433BA0 | overloaded x2
        public void ConvertFromInvariantString(){} // RVA: 0x7FFAC9433CD0 | overloaded x2
        public void ConvertFromString(){} // RVA: 0x7FFAC9391460 | overloaded x3
        public void ConvertTo(){} // RVA: 0x7FFAC9433ED0 | overloaded x2
        public void ConvertToInvariantString(){} // RVA: 0x7FFAC9434160 | overloaded x2
        public void ConvertToString(){} // RVA: 0x7FFAC9434590 | overloaded x3
        public void CreateInstance(){} // RVA: 0x7FFAC34F9180 | overloaded x2
        public void GetConvertFromException(){} // RVA: 0x7FFAC9434700
        public void GetConvertToException(){} // RVA: 0x7FFAC9434850
        public void GetCreateInstanceSupported(){} // RVA: 0x7FFAC2F21320 | overloaded x2
        public void GetProperties(){} // RVA: 0x7FFAC34F9180 | overloaded x3
        public void GetPropertiesSupported(){} // RVA: 0x7FFAC2F21320 | overloaded x2
        public void GetStandardValues(){} // RVA: 0x7FFAC34F9180 | overloaded x2
        public void GetStandardValuesExclusive(){} // RVA: 0x7FFAC2F21320 | overloaded x2
        public void GetStandardValuesSupported(){} // RVA: 0x7FFAC2F21320 | overloaded x2
        public void IsValid(){} // RVA: 0x7FFAC9434C70 | overloaded x2
        public void SortProperties(){} // RVA: 0x7FFAC9434D90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TypeConverterAttribute : Attribute
    {
        public System.ComponentModel.TypeConverterAttribute ConverterTypeName;
        public string <ConverterTypeName>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_ConverterTypeName(){} // RVA: 0x7FFAC2F3C380
        public void Equals(){} // RVA: 0x7FFAC9415160
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
        public void .cctor(){} // RVA: 0x7FFAC9415210
    }

    public class TypeDescriptionProvider : Object
    {
        public System.ComponentModel.TypeDescriptionProvider _parent; // 0x10
        public EmptyCustomTypeDescriptor _emptyDescriptor; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void CreateInstance(){} // RVA: 0x7FFAC9415340
        public void GetCache(){} // RVA: 0x7FFAC9415470
        public void GetExtendedTypeDescriptor(){} // RVA: 0x7FFAC9415490
        public void GetExtenderProviders(){} // RVA: 0x7FFAC9415570
        public void GetFullComponentName(){} // RVA: 0x7FFAC9415640
        public void GetReflectionType(){} // RVA: 0x7FFAC94157F0 | overloaded x3
        public void GetRuntimeType(){} // RVA: 0x7FFAC9415820
        public void GetTypeDescriptor(){} // RVA: 0x7FFAC9415AC0 | overloaded x3
        public void IsSupportedType(){} // RVA: 0x7FFAC9415BB0
    }

    public class TypeDescriptionProviderAttribute : Attribute
    {
        public string TypeName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9415D30 | overloaded x2
        public void get_TypeName(){} // RVA: 0x7FFAC2F3C380
    }

    public class TypeDescriptor : Object
    {
        public System.ComponentModel.WeakHashtable ComNativeDescriptorHandler;
        public System.Collections.Hashtable ComObjectType; // 0x8
        public System.Collections.Hashtable InterfaceType; // 0x10
        public System.ComponentModel.WeakHashtable MetadataVersion; // 0x18
        public int _metadataVersion; // 0x20
        public int _collisionIndex; // 0x24
        public System.Diagnostics.BooleanSwitch TraceDescriptor; // 0x28
        public int PIPELINE_ATTRIBUTES;
        public int PIPELINE_PROPERTIES;
        public int PIPELINE_EVENTS;
        public System.Guid[] _pipelineInitializeKeys; // 0x30
        public System.Guid[] _pipelineMergeKeys; // 0x38
        public System.Guid[] _pipelineFilterKeys; // 0x40
        public System.Guid[] _pipelineAttributeFilterKeys; // 0x48
        public object _internalSyncObject; // 0x50
        public System.ComponentModel.RefreshEventHandler Refreshed; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_ComNativeDescriptorHandler(){} // RVA: 0x7FFAC9435770
        public void set_ComNativeDescriptorHandler(){} // RVA: 0x7FFAC9435860
        public void get_ComObjectType(){} // RVA: 0x7FFAC9435A50
        public void get_InterfaceType(){} // RVA: 0x7FFAC9435B00
        public void get_MetadataVersion(){} // RVA: 0x7FFAC9435BB0
        public void add_Refreshed(){} // RVA: 0x7FFAC9435C10
        public void remove_Refreshed(){} // RVA: 0x7FFAC9435D60
        public void AddAttributes(){} // RVA: 0x7FFAC9436090 | overloaded x2
        public void AddEditorTable(){} // RVA: 0x7FFAC9436230
        public void AddProvider(){} // RVA: 0x7FFAC9436640 | overloaded x2
        public void AddProviderTransparent(){} // RVA: 0x7FFAC9436B40 | overloaded x2
        public void CheckDefaultProvider(){} // RVA: 0x7FFAC9436C40
        public void CreateAssociation(){} // RVA: 0x7FFAC9437490
        public void CreateDesigner(){} // RVA: 0x7FFAC9437E50
        public void CreateEvent(){} // RVA: 0x7FFAC94382E0 | overloaded x2
        public void CreateInstance(){} // RVA: 0x7FFAC9438360
        public void CreateProperty(){} // RVA: 0x7FFAC94386B0 | overloaded x2
        public void DebugValidate(){} // RVA: 0x7FFAC2F21310 | overloaded x10
        public void FilterMembers(){} // RVA: 0x7FFAC94388A0
        public void GetAssociation(){} // RVA: 0x7FFAC9438B00
        public void GetAttributes(){} // RVA: 0x7FFAC94391F0 | overloaded x3
        public void GetCache(){} // RVA: 0x7FFAC94394F0
        public void GetClassName(){} // RVA: 0x7FFAC94396F0 | overloaded x3
        public void GetComponentName(){} // RVA: 0x7FFAC9439850 | overloaded x2
        public void GetConverter(){} // RVA: 0x7FFAC9439A20 | overloaded x3
        public void ConvertFromInvariantString(){} // RVA: 0x7FFAC9439AB0
        public void GetDefaultEvent(){} // RVA: 0x7FFAC9439CB0 | overloaded x3
        public void GetDefaultProperty(){} // RVA: 0x7FFAC9439ED0 | overloaded x3
        public void GetDescriptor(){} // RVA: 0x7FFAC943A0A0 | overloaded x2
        public void GetExtendedDescriptor(){} // RVA: 0x7FFAC943A3D0
        public void GetEditor(){} // RVA: 0x7FFAC943A730 | overloaded x3
        public void GetEvents(){} // RVA: 0x7FFAC943ACA0 | overloaded x6
        public void GetExtenderCollisionSuffix(){} // RVA: 0x7FFAC943B000
        public void GetFullComponentName(){} // RVA: 0x7FFAC943B2B0
        public void GetNodeForBaseType(){} // RVA: 0x7FFAC943B3B0
        public void GetProperties(){} // RVA: 0x7FFAC943B960 | overloaded x6
        public void GetPropertiesImpl(){} // RVA: 0x7FFAC943B9E0
        public void GetProvider(){} // RVA: 0x7FFAC943BE80 | overloaded x2
        public void GetProviderRecursive(){} // RVA: 0x7FFAC943BF20
        public void GetReflectionType(){} // RVA: 0x7FFAC943C0B0 | overloaded x2
        public void NodeFor(){} // RVA: 0x7FFAC943C8D0 | overloaded x4
        public void NodeRemove(){} // RVA: 0x7FFAC943CAC0
        public void PipelineAttributeFilter(){} // RVA: 0x7FFAC943D050
        public void PipelineFilter(){} // RVA: 0x7FFAC943D560
        public void PipelineInitialize(){} // RVA: 0x7FFAC943E750
        public void PipelineMerge(){} // RVA: 0x7FFAC943EB10
        public void RaiseRefresh(){} // RVA: 0x7FFAC943F740 | overloaded x2
        public void Refresh(){} // RVA: 0x7FFAC9440E80 | overloaded x5
        public void RemoveAssociation(){} // RVA: 0x7FFAC9440F40
        public void RemoveAssociations(){} // RVA: 0x7FFAC94412F0
        public void RemoveProvider(){} // RVA: 0x7FFAC94414F0 | overloaded x2
        public void RemoveProviderTransparent(){} // RVA: 0x7FFAC9441790 | overloaded x2
        public void ShouldHideMember(){} // RVA: 0x7FFAC94418D0
        public void SortDescriptorArray(){} // RVA: 0x7FFAC9441990
        public void Trace(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9441AB0
    }

    public class TypeListConverter : TypeConverter
    {
        public System.Type[] _types; // 0x10
        public StandardValuesCollection _values; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void CanConvertFrom(){} // RVA: 0x7FFAC9415E40
        public void CanConvertTo(){} // RVA: 0x7FFAC9415F30
        public void ConvertFrom(){} // RVA: 0x7FFAC9416020
        public void ConvertTo(){} // RVA: 0x7FFAC9416170
        public void GetStandardValues(){} // RVA: 0x7FFAC9416300
        public void GetStandardValuesExclusive(){} // RVA: 0x7FFAC3006850
        public void GetStandardValuesSupported(){} // RVA: 0x7FFAC3006850
    }

}