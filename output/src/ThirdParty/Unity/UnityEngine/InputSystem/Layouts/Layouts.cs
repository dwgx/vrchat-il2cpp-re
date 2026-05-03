// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Layouts
// Classes: 7
// Methods: 197

namespace ThirdParty.Unity.UnityEngine.InputSystem.Layouts
{
    public class InputControlAttribute : PropertyAttribute
    {
        public string _layout; // 0x10
        public string _variants; // 0x18
        public string _name; // 0x20
        public string _format; // 0x28
        public string _usage; // 0x30
        public string[] _usages; // 0x38
        public string _parameters; // 0x40
        public string _processors; // 0x48
        public string _alias; // 0x50
        public string[] _aliases; // 0x58
        public string _useStateFrom; // 0x60
        public uint _bit; // 0x68
        public uint _offset; // 0x6C
        public uint _sizeInBits; // 0x70
        public int _arraySize; // 0x74
        public string _displayName; // 0x78
        public string _shortDisplayName; // 0x80
        public bool _noisy; // 0x88
        public bool _synthetic; // 0x89
        public bool _dontReset; // 0x8A
        public object _defaultState; // 0x90
        public object _minValue; // 0x98
        public object _maxValue; // 0xA0

        // ── Methods ──
        public void get_layout(){} // RVA: 0x7FFE81116380
        public void set_layout(){} // RVA: 0x7FFE810FCE30
        public void get_variants(){} // RVA: 0x7FFE810FE7C0
        public void set_variants(){} // RVA: 0x7FFE81161E80
        public void get_name(){} // RVA: 0x7FFE811290C0
        public void set_name(){} // RVA: 0x7FFE811290D0
        public void get_format(){} // RVA: 0x7FFE81129130
        public void set_format(){} // RVA: 0x7FFE810FCE90
        public void get_usage(){} // RVA: 0x7FFE8144E200
        public void set_usage(){} // RVA: 0x7FFE81129890
        public void get_usages(){} // RVA: 0x7FFE8143BA80
        public void set_usages(){} // RVA: 0x7FFE81437330
        public void get_parameters(){} // RVA: 0x7FFE81178740
        public void set_parameters(){} // RVA: 0x7FFE81123200
        public void get_processors(){} // RVA: 0x7FFE81176730
        public void set_processors(){} // RVA: 0x7FFE81176740
        public void get_alias(){} // RVA: 0x7FFE8119C0E0
        public void set_alias(){} // RVA: 0x7FFE812534D0
        public void get_aliases(){} // RVA: 0x7FFE811C3500
        public void set_aliases(){} // RVA: 0x7FFE811C3510
        public void get_useStateFrom(){} // RVA: 0x7FFE81199370
        public void set_useStateFrom(){} // RVA: 0x7FFE81199380
        public void get_bit(){} // RVA: 0x7FFE82A22EF0
        public void set_bit(){} // RVA: 0x7FFE82A22F00
        public void get_offset(){} // RVA: 0x7FFE82A22F10
        public void set_offset(){} // RVA: 0x7FFE82A22F20
        public void get_sizeInBits(){} // RVA: 0x7FFE81E60180
        public void set_sizeInBits(){} // RVA: 0x7FFE81293CF0
        public void get_arraySize(){} // RVA: 0x7FFE826A9B90
        public void set_arraySize(){} // RVA: 0x7FFE82B1F9C0
        public void get_displayName(){} // RVA: 0x7FFE81463AE0
        public void set_displayName(){} // RVA: 0x7FFE81464570
        public void get_shortDisplayName(){} // RVA: 0x7FFE81280C30
        public void set_shortDisplayName(){} // RVA: 0x7FFE81282380
        public void get_noisy(){} // RVA: 0x7FFE820C4230
        public void set_noisy(){} // RVA: 0x7FFE820C0790
        public void get_synthetic(){} // RVA: 0x7FFE820C3D10
        public void set_synthetic(){} // RVA: 0x7FFE820BE3A0
        public void get_dontReset(){} // RVA: 0x7FFE86E6CC70
        public void set_dontReset(){} // RVA: 0x7FFE87A310F0
        public void get_defaultState(){} // RVA: 0x7FFE8154EB60
        public void set_defaultState(){} // RVA: 0x7FFE818CE320
        public void get_minValue(){} // RVA: 0x7FFE817AE360
        public void set_minValue(){} // RVA: 0x7FFE8171B470
        public void get_maxValue(){} // RVA: 0x7FFE8179C860
        public void set_maxValue(){} // RVA: 0x7FFE8171B4D0
        public void .ctor(){} // RVA: 0x7FFE87A31100
    }

    public class InputControlLayout : Object
    {
        public UnityEngine.InputSystem.Utilities.InternedString s_DefaultVariant;
        public string VariantSeparator;
        public UnityEngine.InputSystem.Utilities.InternedString m_Name; // 0x10
        public System.Type m_Type; // 0x20
        public UnityEngine.InputSystem.Utilities.InternedString m_Variants; // 0x28
        public UnityEngine.InputSystem.Utilities.FourCC m_StateFormat; // 0x38
        public int m_StateSizeInBytes; // 0x3C
        public System.Nullable`1<bool> m_UpdateBeforeRender; // 0x40
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.Utilities.InternedString> m_BaseLayouts; // 0x48
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.Utilities.InternedString> m_AppliedOverrides; // 0x68
        public UnityEngine.InputSystem.Utilities.InternedString[] m_CommonUsages; // 0x88
        public ControlItem[] m_Controls; // 0x90
        public string m_DisplayName; // 0x98
        public string m_Description; // 0xA0
        public 0x665489C4 m_Flags; // 0xA8
        public Collection s_Layouts; // 0x10
        public Cache s_CacheInstance; // 0x50
        public int s_CacheInstanceRef; // 0x58
        public int length; // 0x10
        public UnityEngine.InputSystem.Utilities.InternedString firstValue; // 0x18
        public UnityEngine.InputSystem.Utilities.InternedString[] additionalValues; // 0x28

        // ── Methods ──
        public void get_DefaultVariant(){} // RVA: 0x7FFE87A31290
        public void get_name(){} // RVA: 0x7FFE826F6B90
        public void get_displayName(){} // RVA: 0x7FFE87A312F0
        public void get_type(){} // RVA: 0x7FFE811290C0
        public void get_variants(){} // RVA: 0x7FFE81E90600
        public void get_stateFormat(){} // RVA: 0x7FFE81D46090
        public void get_stateSizeInBytes(){} // RVA: 0x7FFE816311C0
        public void get_baseLayouts(){} // RVA: 0x7FFE87A31350
        public void get_appliedOverrides(){} // RVA: 0x7FFE87A313B0
        public void get_commonUsages(){} // RVA: 0x7FFE87A31410
        public void get_controls(){} // RVA: 0x7FFE87A314E0
        public void get_updateBeforeRender(){} // RVA: 0x7FFE87A315B0
        public void get_isDeviceLayout(){} // RVA: 0x7FFE87A315F0
        public void get_isControlLayout(){} // RVA: 0x7FFE87A316D0
        public void get_isOverride(){} // RVA: 0x7FFE87A317B0
        public void set_isOverride(){} // RVA: 0x7FFE87A317C0
        public void get_isGenericTypeOfDevice(){} // RVA: 0x7FFE87A317E0
        public void set_isGenericTypeOfDevice(){} // RVA: 0x7FFE87A317F0
        public void get_hideInUI(){} // RVA: 0x7FFE87A31810
        public void set_hideInUI(){} // RVA: 0x7FFE87A31820
        public void get_isNoisy(){} // RVA: 0x7FFE87A31840
        public void set_isNoisy(){} // RVA: 0x7FFE87A31850
        public void get_canRunInBackground(){} // RVA: 0x7FFE87A31870
        public void set_canRunInBackground(){} // RVA: 0x7FFE87A318D0
        public void get_Item(){} // RVA: 0x7FFE87A31970
        public void FindControl(){} // RVA: 0x7FFE87A31B30
        public void FindControlIncludingArrayElements(){} // RVA: 0x7FFE87A31E80
        public void GetValueType(){} // RVA: 0x7FFE87A32810
        public void FromType(){} // RVA: 0x7FFE87A328E0
        public void ToJson(){} // RVA: 0x7FFE87A32FF0
        public void FromJson(){} // RVA: 0x7FFE87A330A0
        public void .ctor(){} // RVA: 0x7FFE87A33240
        public void AddControlItems(){} // RVA: 0x7FFE87A33330
        public void AddControlItemsFromFields(){} // RVA: 0x7FFE87A33470
        public void AddControlItemsFromProperties(){} // RVA: 0x7FFE87A33510
        public void AddControlItemsFromMembers(){} // RVA: 0x7FFE87A335B0
        public void AddControlItemsFromMember(){} // RVA: 0x7FFE87A33BD0
        public void CreateControlItemFromMember(){} // RVA: 0x7FFE87A33F90
        public void InferLayoutFromValueType(){} // RVA: 0x7FFE87A351C0
        public void MergeLayout(){} // RVA: 0x7FFE87A35420
        public void CreateLookupTableForControls(){} // RVA: 0x7FFE87A36E90
        public void VariantsMatch(){} // RVA: 0x7FFE87A373A0 | overloaded x2
        public void ParseHeaderFieldsFromJson(){} // RVA: 0x7FFE87A37510
        public void get_cache(){} // RVA: 0x7FFE87A37870
        public void CacheRef(){} // RVA: 0x7FFE87A378D0
        public void .cctor(){} // RVA: 0x7FFE87A37930
        public void <MergeLayout>b__77_0(){} // RVA: 0x7FFE87A37A00
    }

    public class InputControlLayoutAttribute : Attribute
    {
        public System.Type _stateType; // 0x10
        public string _stateFormat; // 0x18
        public string[] _commonUsages; // 0x20
        public string _variants; // 0x28
        public bool _isNoisy; // 0x30
        public System.Nullable`1<bool> canRunInBackgroundInternal; // 0x31
        public System.Nullable`1<bool> updateBeforeRenderInternal; // 0x33
        public bool _isGenericTypeOfDevice; // 0x35
        public string _displayName; // 0x38
        public string _description; // 0x40
        public bool _hideInUI; // 0x48

        // ── Methods ──
        public void get_stateType(){} // RVA: 0x7FFE81116380
        public void set_stateType(){} // RVA: 0x7FFE810FCE30
        public void get_stateFormat(){} // RVA: 0x7FFE810FE7C0
        public void set_stateFormat(){} // RVA: 0x7FFE81161E80
        public void get_commonUsages(){} // RVA: 0x7FFE811290C0
        public void set_commonUsages(){} // RVA: 0x7FFE811290D0
        public void get_variants(){} // RVA: 0x7FFE81129130
        public void set_variants(){} // RVA: 0x7FFE810FCE90
        public void get_isNoisy(){} // RVA: 0x7FFE81121450
        public void set_isNoisy(){} // RVA: 0x7FFE81121460
        public void get_canRunInBackground(){} // RVA: 0x7FFE878F88D0
        public void set_canRunInBackground(){} // RVA: 0x7FFE878F8920
        public void get_updateBeforeRender(){} // RVA: 0x7FFE878F8970
        public void set_updateBeforeRender(){} // RVA: 0x7FFE878F89C0
        public void get_isGenericTypeOfDevice(){} // RVA: 0x7FFE8130B140
        public void set_isGenericTypeOfDevice(){} // RVA: 0x7FFE8130CFA0
        public void get_displayName(){} // RVA: 0x7FFE8143BA80
        public void set_displayName(){} // RVA: 0x7FFE81437330
        public void get_description(){} // RVA: 0x7FFE81178740
        public void set_description(){} // RVA: 0x7FFE81123200
        public void get_hideInUI(){} // RVA: 0x7FFE811B2D30
        public void set_hideInUI(){} // RVA: 0x7FFE811B2D40
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class InputDeviceBuilder : ValueType
    {
        public UnityEngine.InputSystem.InputDevice m_Device; // 0x10

        // ── Methods ──
        public void Setup(){} // RVA: 0x7FFE878F8A10
        public void Finish(){} // RVA: 0x7FFE878F8CA0
        public void Dispose(){} // RVA: 0x7FFE878F9050
        public void Reset(){} // RVA: 0x7FFE878F9060
        public void InstantiateLayout(){} // RVA: 0x7FFE878F92C0 | overloaded x2
        public void AddChildControls(){} // RVA: 0x7FFE878F9C30
        public void AddChildControl(){} // RVA: 0x7FFE878FA5D0
        public void InsertChildControlOverride(){} // RVA: 0x7FFE878FB120
        public void ChildControlOverridePath(){} // RVA: 0x7FFE878FB560
        public void AddChildControlIfMissing(){} // RVA: 0x7FFE878FB790
        public void InsertChildControl(){} // RVA: 0x7FFE878FB8C0
        public void ApplyUseStateFrom(){} // RVA: 0x7FFE878FBF00
        public void ShiftChildIndicesInHierarchyOneUp(){} // RVA: 0x7FFE878FC1A0
        public void SetDisplayName(){} // RVA: 0x7FFE878FC210
        public void AddParentDisplayNameRecursive(){} // RVA: 0x7FFE878FC590
        public void AddProcessors(){} // RVA: 0x7FFE878FC6C0
        public void SetFormat(){} // RVA: 0x7FFE878FC9F0
        public void FindOrLoadLayout(){} // RVA: 0x7FFE878FCAB0
        public void ComputeStateLayout(){} // RVA: 0x7FFE878FCB50
        public void FinalizeControlHierarchy(){} // RVA: 0x7FFE878FD530
        public void FinalizeControlHierarchyRecursive(){} // RVA: 0x7FFE878FD890
        public void InsertControlBitRangeNode(){} // RVA: 0x7FFE878FDDE0
        public void GetBestMidPoint(){} // RVA: 0x7FFE878FE2C0
        public void AddControlToNode(){} // RVA: 0x7FFE878FEA50
        public void AddChildren(){} // RVA: 0x7FFE878FED50
        public void GetControlIndex(){} // RVA: 0x7FFE878FEE90
        public void get_instance(){} // RVA: 0x7FFE878FEF60
        public void Ref(){} // RVA: 0x7FFE878FEFA0
    }

    public class InputDeviceDescription : ValueType
    {
        public string m_InterfaceName; // 0x10
        public string m_DeviceClass; // 0x18
        public string m_Manufacturer; // 0x20
        public string m_Product; // 0x28
        public string m_Serial; // 0x30
        public string m_Version; // 0x38
        public string m_Capabilities; // 0x40
        public object field_7; // 0xB100

        // ── Methods ──
        public void get_interfaceName(){} // RVA: 0x7FFE8284EF60
        public void set_interfaceName(){} // RVA: 0x7FFE81D7E9E0
        public void get_deviceClass(){} // RVA: 0x7FFE826F4210
        public void set_deviceClass(){} // RVA: 0x7FFE826F4230
        public void get_manufacturer(){} // RVA: 0x7FFE81116380
        public void set_manufacturer(){} // RVA: 0x7FFE810FCE30
        public void get_product(){} // RVA: 0x7FFE810FE7C0
        public void set_product(){} // RVA: 0x7FFE81161E80
        public void get_serial(){} // RVA: 0x7FFE811290C0
        public void set_serial(){} // RVA: 0x7FFE811290D0
        public void get_version(){} // RVA: 0x7FFE81129130
        public void set_version(){} // RVA: 0x7FFE810FCE90
        public void get_capabilities(){} // RVA: 0x7FFE8144E200
        public void set_capabilities(){} // RVA: 0x7FFE81129890
        public void get_empty(){} // RVA: 0x7FFE878FF090
        public void ToString(){} // RVA: 0x7FFE878FF100
        public void Equals(){} // RVA: 0x7FFE878FF690 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE878FF740
        public void op_Equality(){} // RVA: 0x7FFE878FF8A0
        public void op_Inequality(){} // RVA: 0x7FFE878FF8E0
        public void ToJson(){} // RVA: 0x7FFE878FF920
        public void FromJson(){} // RVA: 0x7FFE878FFC00
        public void ComparePropertyToDeviceDescriptor(){} // RVA: 0x7FFE87900060
    }

    public class InputDeviceFindControlLayoutDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A31110
        public void Invoke(){} // RVA: 0x7FFE812574E0
        public void BeginInvoke(){} // RVA: 0x7FFE87A311F0
        public void EndInvoke(){} // RVA: 0x7FFE82C67E40
    }

    public class InputDeviceMatcher : ValueType
    {
        public System.Collections.Generic.KeyValuePair`2<UnityEngine.InputSystem.Utilities.InternedString,object>[] m_Patterns; // 0x10
        public UnityEngine.InputSystem.Utilities.InternedString kInterfaceKey;

        // ── Methods ──
        public void get_empty(){} // RVA: 0x7FFE82AB4690
        public void get_patterns(){} // RVA: 0x7FFE87900230
        public void WithInterface(){} // RVA: 0x7FFE879002E0
        public void WithDeviceClass(){} // RVA: 0x7FFE87900380
        public void WithManufacturer(){} // RVA: 0x7FFE87900420
        public void WithManufacturerContains(){} // RVA: 0x7FFE879004C0
        public void WithProduct(){} // RVA: 0x7FFE87900550
        public void WithVersion(){} // RVA: 0x7FFE879005F0
        public void WithCapability(){} // RVA: 0x7FFE810A1420
        public void With(){} // RVA: 0x7FFE87900690
        public void MatchPercentage(){} // RVA: 0x7FFE87900A10
        public void MatchSingleProperty(){} // RVA: 0x7FFE87901000
        public void MatchSinglePropertyContains(){} // RVA: 0x7FFE879011F0
        public void GetNumPropertiesIn(){} // RVA: 0x7FFE879013D0
        public void FromDeviceDescription(){} // RVA: 0x7FFE87901440
        public void ToString(){} // RVA: 0x7FFE87901750
        public void Equals(){} // RVA: 0x7FFE87901A70 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE87901B10
        public void op_Inequality(){} // RVA: 0x7FFE87901B70
        public void GetHashCode(){} // RVA: 0x7FFE84291EA0
        public void .cctor(){} // RVA: 0x7FFE87901C10
    }

}