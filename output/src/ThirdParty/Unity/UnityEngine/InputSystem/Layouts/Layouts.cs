// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Layouts
// Classes: 7
// Methods: 197

namespace ThirdParty.Unity.UnityEngine.InputSystem.Layouts
{
    public class InputControlAttribute
    {
        public string <layout>k__BackingField; // 0x10
        public string <variants>k__BackingField; // 0x18
        public string <name>k__BackingField; // 0x20
        public string <format>k__BackingField; // 0x28
        public string <usage>k__BackingField; // 0x30
        public string[] <usages>k__BackingField; // 0x38
        public string <parameters>k__BackingField; // 0x40
        public string <processors>k__BackingField; // 0x48
        public string <alias>k__BackingField; // 0x50
        public string[] <aliases>k__BackingField; // 0x58
        public string <useStateFrom>k__BackingField; // 0x60
        public uint <bit>k__BackingField; // 0x68
        public uint <offset>k__BackingField; // 0x6C
        public uint <sizeInBits>k__BackingField; // 0x70
        public int <arraySize>k__BackingField; // 0x74
        public string <displayName>k__BackingField; // 0x78
        public string <shortDisplayName>k__BackingField; // 0x80
        public bool <noisy>k__BackingField; // 0x88
        public bool <synthetic>k__BackingField; // 0x89
        public bool <dontReset>k__BackingField; // 0x8A
        public object <defaultState>k__BackingField; // 0x90
        public object <minValue>k__BackingField; // 0x98
        public object <maxValue>k__BackingField; // 0xA0

        // ── Methods ──
        public void get_layout(){} // RVA: 0x2F8380
        public void set_layout(){} // RVA: 0x2DEE30
        public void get_variants(){} // RVA: 0x2E07C0
        public void set_variants(){} // RVA: 0x343E80
        public void get_name(){} // RVA: 0x30B0C0
        public void set_name(){} // RVA: 0x30B0D0
        public void get_format(){} // RVA: 0x30B130
        public void set_format(){} // RVA: 0x2DEE90
        public void get_usage(){} // RVA: 0x6374D0
        public void set_usage(){} // RVA: 0x30B890
        public void get_usages(){} // RVA: 0x4976A0
        public void set_usages(){} // RVA: 0x49B830
        public void get_parameters(){} // RVA: 0x35A740
        public void set_parameters(){} // RVA: 0x305200
        public void get_processors(){} // RVA: 0x358730
        public void set_processors(){} // RVA: 0x358740
        public void get_alias(){} // RVA: 0x37E0E0
        public void set_alias(){} // RVA: 0x4354D0
        public void get_aliases(){} // RVA: 0x3A5500
        public void set_aliases(){} // RVA: 0x3A5510
        public void get_useStateFrom(){} // RVA: 0x37B370
        public void set_useStateFrom(){} // RVA: 0x37B380
        public void get_bit(){} // RVA: 0x1C91440
        public void set_bit(){} // RVA: 0x1C91450
        public void get_offset(){} // RVA: 0x1C91460
        public void set_offset(){} // RVA: 0x1C91470
        public void get_sizeInBits(){} // RVA: 0x10E5CF0
        public void set_sizeInBits(){} // RVA: 0x475080
        public void get_arraySize(){} // RVA: 0x1929080
        public void set_arraySize(){} // RVA: 0x1D8D640
        public void get_displayName(){} // RVA: 0x4C7C50
        public void set_displayName(){} // RVA: 0x4C34F0
        public void get_shortDisplayName(){} // RVA: 0x462D00
        public void set_shortDisplayName(){} // RVA: 0x464450
        public void get_noisy(){} // RVA: 0x1342AB0
        public void set_noisy(){} // RVA: 0x10F2C40
        public void get_synthetic(){} // RVA: 0x134A680
        public void set_synthetic(){} // RVA: 0x1343820
        public void get_dontReset(){} // RVA: 0x632C250
        public void set_dontReset(){} // RVA: 0x6EF0260
        public void get_defaultState(){} // RVA: 0x796DE0
        public void set_defaultState(){} // RVA: 0xB54600
        public void get_minValue(){} // RVA: 0xA1C8C0
        public void set_minValue(){} // RVA: 0x9AA650
        public void get_maxValue(){} // RVA: 0xA085E0
        public void set_maxValue(){} // RVA: 0x9AA5F0
        public void .ctor(){} // RVA: 0x6EF0270
    }

    public class InputControlLayout
    {
        public UnityEngine.InputSystem.Utilities.InternedString header;
        public string recordIndex;
        public UnityEngine.InputSystem.Utilities.InternedString version; // 0x10
        public System.Type valid; // 0x20
        public UnityEngine.InputSystem.Utilities.InternedString owner; // 0x28
        public UnityEngine.InputSystem.Utilities.FourCC index; // 0x38
        public int time; // 0x3C
        public System.Nullable`1<bool> control; // 0x40
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.Utilities.InternedString> next; // 0x48
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.Utilities.InternedString> previous; // 0x68
        public UnityEngine.InputSystem.Utilities.InternedString[] m_CommonUsages; // 0x88
        public ControlItem[] m_Controls; // 0x90
        public string m_DisplayName; // 0x98
        public string m_Description; // 0xA0
        public 0x65870B10 m_Flags; // 0xA8
        public Collection s_Layouts; // 0x10
        public Cache s_CacheInstance; // 0x50
        public int s_CacheInstanceRef; // 0x58

        // ── Methods ──
        public void get_DefaultVariant(){} // RVA: 0x6EF0400
        public void get_name(){} // RVA: 0x196ABE0
        public void get_displayName(){} // RVA: 0x6EF0460
        public void get_type(){} // RVA: 0x30B0C0
        public void get_variants(){} // RVA: 0x111F520
        public void get_stateFormat(){} // RVA: 0xFDC9F0
        public void get_stateSizeInBytes(){} // RVA: 0x891AF0
        public void get_baseLayouts(){} // RVA: 0x6EF04C0
        public void get_appliedOverrides(){} // RVA: 0x6EF0520
        public void get_commonUsages(){} // RVA: 0x6EF0580
        public void get_controls(){} // RVA: 0x6EF0650
        public void get_updateBeforeRender(){} // RVA: 0x6EF0720
        public void get_isDeviceLayout(){} // RVA: 0x6EF0760
        public void get_isControlLayout(){} // RVA: 0x6EF0840
        public void get_isOverride(){} // RVA: 0x6EF0920
        public void set_isOverride(){} // RVA: 0x6EF0930
        public void get_isGenericTypeOfDevice(){} // RVA: 0x6EF0950
        public void set_isGenericTypeOfDevice(){} // RVA: 0x6EF0960
        public void get_hideInUI(){} // RVA: 0x6EF0980
        public void set_hideInUI(){} // RVA: 0x6EF0990
        public void get_isNoisy(){} // RVA: 0x6EF09B0
        public void set_isNoisy(){} // RVA: 0x6EF09C0
        public void get_canRunInBackground(){} // RVA: 0x6EF09E0
        public void set_canRunInBackground(){} // RVA: 0x6EF0A40
        public void get_Item(){} // RVA: 0x6EF0AE0
        public void FindControl(){} // RVA: 0x6EF0CA0
        public void FindControlIncludingArrayElements(){} // RVA: 0x6EF0FF0
        public void GetValueType(){} // RVA: 0x6EF1980
        public void FromType(){} // RVA: 0x6EF1A50
        public void ToJson(){} // RVA: 0x6EF2160
        public void FromJson(){} // RVA: 0x6EF2210
        public void .ctor(){} // RVA: 0x6EF23B0
        public void AddControlItems(){} // RVA: 0x6EF24A0
        public void AddControlItemsFromFields(){} // RVA: 0x6EF25E0
        public void AddControlItemsFromProperties(){} // RVA: 0x6EF2680
        public void AddControlItemsFromMembers(){} // RVA: 0x6EF2720
        public void AddControlItemsFromMember(){} // RVA: 0x6EF2D40
        public void CreateControlItemFromMember(){} // RVA: 0x6EF3100
        public void InferLayoutFromValueType(){} // RVA: 0x6EF4330
        public void MergeLayout(){} // RVA: 0x6EF4590
        public void CreateLookupTableForControls(){} // RVA: 0x6EF6000
        public void VariantsMatch(){} // RVA: 0x6EF6510 | overloaded x2
        public void ParseHeaderFieldsFromJson(){} // RVA: 0x6EF6680
        public void get_cache(){} // RVA: 0x6EF69E0
        public void CacheRef(){} // RVA: 0x6EF6A40
        public void .cctor(){} // RVA: 0x6EF6AA0
        public void <MergeLayout>b__77_0(){} // RVA: 0x6EF6B70
    }

    public class InputControlLayoutAttribute
    {
        public System.Type <stateType>k__BackingField; // 0x10
        public string <stateFormat>k__BackingField; // 0x18
        public string[] <commonUsages>k__BackingField; // 0x20
        public string <variants>k__BackingField; // 0x28
        public bool <isNoisy>k__BackingField; // 0x30
        public System.Nullable`1<bool> canRunInBackgroundInternal; // 0x31
        public System.Nullable`1<bool> updateBeforeRenderInternal; // 0x33
        public bool <isGenericTypeOfDevice>k__BackingField; // 0x35
        public string <displayName>k__BackingField; // 0x38
        public string <description>k__BackingField; // 0x40
        public bool <hideInUI>k__BackingField; // 0x48

        // ── Methods ──
        public void get_stateType(){} // RVA: 0x2F8380
        public void set_stateType(){} // RVA: 0x2DEE30
        public void get_stateFormat(){} // RVA: 0x2E07C0
        public void set_stateFormat(){} // RVA: 0x343E80
        public void get_commonUsages(){} // RVA: 0x30B0C0
        public void set_commonUsages(){} // RVA: 0x30B0D0
        public void get_variants(){} // RVA: 0x30B130
        public void set_variants(){} // RVA: 0x2DEE90
        public void get_isNoisy(){} // RVA: 0x303450
        public void set_isNoisy(){} // RVA: 0x303460
        public void get_canRunInBackground(){} // RVA: 0x6DB7A30
        public void set_canRunInBackground(){} // RVA: 0x6DB7A80
        public void get_updateBeforeRender(){} // RVA: 0x6DB7AD0
        public void set_updateBeforeRender(){} // RVA: 0x6DB7B20
        public void get_isGenericTypeOfDevice(){} // RVA: 0x4FAD10
        public void set_isGenericTypeOfDevice(){} // RVA: 0x4FBCA0
        public void get_displayName(){} // RVA: 0x4976A0
        public void set_displayName(){} // RVA: 0x49B830
        public void get_description(){} // RVA: 0x35A740
        public void set_description(){} // RVA: 0x305200
        public void get_hideInUI(){} // RVA: 0x394D30
        public void set_hideInUI(){} // RVA: 0x394D40
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class InputDeviceBuilder
    {
        public UnityEngine.InputSystem.InputDevice m_Device; // 0x10

        // ── Methods ──
        public void Setup(){} // RVA: 0x6DB7B70
        public void Finish(){} // RVA: 0x6DB7E00
        public void Dispose(){} // RVA: 0x6DB81B0
        public void Reset(){} // RVA: 0x6DB81C0
        public void InstantiateLayout(){} // RVA: 0x6DB8420 | overloaded x2
        public void AddChildControls(){} // RVA: 0x6DB8D90
        public void AddChildControl(){} // RVA: 0x6DB9730
        public void InsertChildControlOverride(){} // RVA: 0x6DBA280
        public void ChildControlOverridePath(){} // RVA: 0x6DBA6C0
        public void AddChildControlIfMissing(){} // RVA: 0x6DBA8F0
        public void InsertChildControl(){} // RVA: 0x6DBAA20
        public void ApplyUseStateFrom(){} // RVA: 0x6DBB060
        public void ShiftChildIndicesInHierarchyOneUp(){} // RVA: 0x6DBB300
        public void SetDisplayName(){} // RVA: 0x6DBB370
        public void AddParentDisplayNameRecursive(){} // RVA: 0x6DBB6F0
        public void AddProcessors(){} // RVA: 0x6DBB820
        public void SetFormat(){} // RVA: 0x6DBBB50
        public void FindOrLoadLayout(){} // RVA: 0x6DBBC10
        public void ComputeStateLayout(){} // RVA: 0x6DBBCB0
        public void FinalizeControlHierarchy(){} // RVA: 0x6DBC690
        public void FinalizeControlHierarchyRecursive(){} // RVA: 0x6DBC9F0
        public void InsertControlBitRangeNode(){} // RVA: 0x6DBCF40
        public void GetBestMidPoint(){} // RVA: 0x6DBD420
        public void AddControlToNode(){} // RVA: 0x6DBDBB0
        public void AddChildren(){} // RVA: 0x6DBDEB0
        public void GetControlIndex(){} // RVA: 0x6DBDFF0
        public void get_instance(){} // RVA: 0x6DBE0C0
        public void Ref(){} // RVA: 0x6DBE100
    }

    public class InputDeviceDescription
    {
        public string m_InterfaceName; // 0x10
        public string m_DeviceClass; // 0x18
        public string m_Manufacturer; // 0x20
        public string m_Product; // 0x28
        public string m_Serial; // 0x30
        public string m_Version; // 0x38
        public string m_Capabilities; // 0x40

        // ── Methods ──
        public void get_interfaceName(){} // RVA: 0x1AD4690
        public void set_interfaceName(){} // RVA: 0x100A2F0
        public void get_deviceClass(){} // RVA: 0x19689C0
        public void set_deviceClass(){} // RVA: 0x1968950
        public void get_manufacturer(){} // RVA: 0x2F8380
        public void set_manufacturer(){} // RVA: 0x2DEE30
        public void get_product(){} // RVA: 0x2E07C0
        public void set_product(){} // RVA: 0x343E80
        public void get_serial(){} // RVA: 0x30B0C0
        public void set_serial(){} // RVA: 0x30B0D0
        public void get_version(){} // RVA: 0x30B130
        public void set_version(){} // RVA: 0x2DEE90
        public void get_capabilities(){} // RVA: 0x6374D0
        public void set_capabilities(){} // RVA: 0x30B890
        public void get_empty(){} // RVA: 0x6DBE1F0
        public void ToString(){} // RVA: 0x6DBE260
        public void Equals(){} // RVA: 0x6DBE7F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6DBE8A0
        public void op_Equality(){} // RVA: 0x6DBEA00
        public void op_Inequality(){} // RVA: 0x6DBEA40
        public void ToJson(){} // RVA: 0x6DBEA80
        public void FromJson(){} // RVA: 0x6DBED60
        public void ComparePropertyToDeviceDescriptor(){} // RVA: 0x6DBF1C0
    }

    public class InputDeviceFindControlLayoutDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EF0280
        public void Invoke(){} // RVA: 0x4394E0
        public void BeginInvoke(){} // RVA: 0x6EF0360
        public void EndInvoke(){} // RVA: 0x1EDD9F0
    }

    public class InputDeviceMatcher
    {
        public System.Collections.Generic.KeyValuePair`2<UnityEngine.InputSystem.Utilities.InternedString,object>[] m_Patterns; // 0x10
        public UnityEngine.InputSystem.Utilities.InternedString kInterfaceKey;

        // ── Methods ──
        public void get_empty(){} // RVA: 0x1D26810
        public void get_patterns(){} // RVA: 0x6DBF390
        public void WithInterface(){} // RVA: 0x6DBF440
        public void WithDeviceClass(){} // RVA: 0x6DBF4E0
        public void WithManufacturer(){} // RVA: 0x6DBF580
        public void WithManufacturerContains(){} // RVA: 0x6DBF620
        public void WithProduct(){} // RVA: 0x6DBF6B0
        public void WithVersion(){} // RVA: 0x6DBF750
        public void WithCapability(){} // RVA: 0x283FA0
        public void With(){} // RVA: 0x6DBF7F0
        public void MatchPercentage(){} // RVA: 0x6DBFB70
        public void MatchSingleProperty(){} // RVA: 0x6DC0160
        public void MatchSinglePropertyContains(){} // RVA: 0x6DC0350
        public void GetNumPropertiesIn(){} // RVA: 0x6DC0530
        public void FromDeviceDescription(){} // RVA: 0x6DC05A0
        public void ToString(){} // RVA: 0x6DC08B0
        public void Equals(){} // RVA: 0x6DC0BD0 | overloaded x2
        public void op_Equality(){} // RVA: 0x6DC0C70
        public void op_Inequality(){} // RVA: 0x6DC0CD0
        public void GetHashCode(){} // RVA: 0x3618360
        public void .cctor(){} // RVA: 0x6DC0D70
    }

}