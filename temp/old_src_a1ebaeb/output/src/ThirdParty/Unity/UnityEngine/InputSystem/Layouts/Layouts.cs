// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Layouts
// Classes: 7
// Methods: 197

namespace ThirdParty.Unity.UnityEngine.InputSystem.Layouts
{
    public class InputControlAttribute : PropertyAttribute
    {
        public object _name; // 0x33C859C0, was: <name>k__BackingField
        public object _usages; // 0x33C859C0, was: <usages>k__BackingField
        public object _alias; // 0x33C859C0, was: <alias>k__BackingField
        public object _bit; // 0x33C859C0, was: <bit>k__BackingField
        public object _arraySize; // 0x33C859C0, was: <arraySize>k__BackingField
        public object _noisy; // 0x33C859C0, was: <noisy>k__BackingField
        public object _defaultState; // 0x33C859C0, was: <defaultState>k__BackingField

        // ── Original Methods ──
        public void get_layout(){} // RVA: 0x7ffaa894d380
        public void set_layout(){} // RVA: 0x7ffaa8933e30
        public void get_variants(){} // RVA: 0x7ffaa89357c0
        public void set_variants(){} // RVA: 0x7ffaa8998e80
        public void get_name(){} // RVA: 0x7ffaa89600c0
        public void set_name(){} // RVA: 0x7ffaa89600d0
        public void get_format(){} // RVA: 0x7ffaa8960130
        public void set_format(){} // RVA: 0x7ffaa8933e90
        public void get_usage(){} // RVA: 0x7ffaa8bfcc80
        public void set_usage(){} // RVA: 0x7ffaa8960890
        public void get_usages(){} // RVA: 0x7ffaa8bf45b0
        public void set_usages(){} // RVA: 0x7ffaa8bf45c0
        public void get_parameters(){} // RVA: 0x7ffaa89af740
        public void set_parameters(){} // RVA: 0x7ffaa895a200
        public void get_processors(){} // RVA: 0x7ffaa89ad730
        public void set_processors(){} // RVA: 0x7ffaa89ad740
        public void get_alias(){} // RVA: 0x7ffaa89d30e0
        public void set_alias(){} // RVA: 0x7ffaa8a8a4d0
        public void get_aliases(){} // RVA: 0x7ffaa89fa500
        public void set_aliases(){} // RVA: 0x7ffaa89fa510
        public void get_useStateFrom(){} // RVA: 0x7ffaa89d0370
        public void set_useStateFrom(){} // RVA: 0x7ffaa89d0380
        public void get_bit(){} // RVA: 0x7ffaaa1c2a40
        public void set_bit(){} // RVA: 0x7ffaaa1c2a50
        public void get_offset(){} // RVA: 0x7ffaaa1c2a60
        public void set_offset(){} // RVA: 0x7ffaaa1c2a70
        public void get_sizeInBits(){} // RVA: 0x7ffaa95c5a20
        public void set_sizeInBits(){} // RVA: 0x7ffaa8ac7670
        public void get_arraySize(){} // RVA: 0x7ffaa9e03940
        public void set_arraySize(){} // RVA: 0x7ffaaa2bddd0
        public void get_displayName(){} // RVA: 0x7ffaa8af68f0
        public void set_displayName(){} // RVA: 0x7ffaa8af19e0
        public void get_shortDisplayName(){} // RVA: 0x7ffaa8d1a3b0
        public void set_shortDisplayName(){} // RVA: 0x7ffaa8efece0
        public void get_noisy(){} // RVA: 0x7ffaa98372b0
        public void set_noisy(){} // RVA: 0x7ffaa9836fb0
        public void get_synthetic(){} // RVA: 0x7ffaa9839a00
        public void set_synthetic(){} // RVA: 0x7ffaa983a020
        public void get_dontReset(){} // RVA: 0x7ffaae4e4810
        public void set_dontReset(){} // RVA: 0x7ffaaf0aa970
        public void get_defaultState(){} // RVA: 0x7ffaa8d1b980
        public void set_defaultState(){} // RVA: 0x7ffaa8f7b070
        public void get_minValue(){} // RVA: 0x7ffaa8f75d20
        public void set_minValue(){} // RVA: 0x7ffaa8f7b0d0
        public void get_maxValue(){} // RVA: 0x7ffaa8f78170
        public void set_maxValue(){} // RVA: 0x7ffaa8f7b130
        public void .ctor(){} // RVA: 0x7ffaaf0aa980
    }

    public class InputControlLayout : Object
    {
        public object m_Name; // 0x31A64C70
        public object m_StateFormat; // 0x31A64C70
        public object m_BaseLayouts; // 0x31A64C70
        public object m_Controls; // 0x31A64C70
        public object m_Flags; // 0x31A64C70
        public object s_CacheInstanceRef; // 0x31A64C70
        public object additionalValues; // 0x33DBEE80

        // ── Original Methods ──
        public void get_DefaultVariant(){} // RVA: 0x7ffaaf0aab10
        public void get_name(){} // RVA: 0x7ffaa9e49b20
        public void get_displayName(){} // RVA: 0x7ffaaf0aab70
        public void get_type(){} // RVA: 0x7ffaa89600c0
        public void get_variants(){} // RVA: 0x7ffaa95ffd80
        public void get_stateFormat(){} // RVA: 0x7ffaa8fb82b0
        public void get_stateSizeInBytes(){} // RVA: 0x7ffaa8de7460
        public void get_baseLayouts(){} // RVA: 0x7ffaaf0aabd0
        public void get_appliedOverrides(){} // RVA: 0x7ffaaf0aac30
        public void get_commonUsages(){} // RVA: 0x7ffaaf0aac90
        public void get_controls(){} // RVA: 0x7ffaaf0aad60
        public void get_updateBeforeRender(){} // RVA: 0x7ffaaf0aae30
        public void get_isDeviceLayout(){} // RVA: 0x7ffaaf0aae70
        public void get_isControlLayout(){} // RVA: 0x7ffaaf0aaf50
        public void get_isOverride(){} // RVA: 0x7ffaaf0ab030
        public void set_isOverride(){} // RVA: 0x7ffaaf0ab040
        public void get_isGenericTypeOfDevice(){} // RVA: 0x7ffaaf0ab060
        public void set_isGenericTypeOfDevice(){} // RVA: 0x7ffaaf0ab070
        public void get_hideInUI(){} // RVA: 0x7ffaaf0ab090
        public void set_hideInUI(){} // RVA: 0x7ffaaf0ab0a0
        public void get_isNoisy(){} // RVA: 0x7ffaaf0ab0c0
        public void set_isNoisy(){} // RVA: 0x7ffaaf0ab0d0
        public void get_canRunInBackground(){} // RVA: 0x7ffaaf0ab0f0
        public void set_canRunInBackground(){} // RVA: 0x7ffaaf0ab150
        public void get_Item(){} // RVA: 0x7ffaaf0ab1f0
        public void FindControl(){} // RVA: 0x7ffaaf0ab3b0
        public void FindControlIncludingArrayElements(){} // RVA: 0x7ffaaf0ab700
        public void FromType(){} // RVA: 0x7ffaaf0ac160
        public void ToJson(){} // RVA: 0x7ffaaf0ac870
        public void FromJson(){} // RVA: 0x7ffaaf0ac920
        public void .ctor(){} // RVA: 0x7ffaaf0acac0
        public void AddControlItems(){} // RVA: 0x7ffaaf0acbb0
        public void AddControlItemsFromFields(){} // RVA: 0x7ffaaf0accf0
        public void AddControlItemsFromProperties(){} // RVA: 0x7ffaaf0acd90
        public void AddControlItemsFromMembers(){} // RVA: 0x7ffaaf0ace30
        public void AddControlItemsFromMember(){} // RVA: 0x7ffaaf0ad450
        public void CreateControlItemFromMember(){} // RVA: 0x7ffaaf0ad810
        public void InferLayoutFromValueType(){} // RVA: 0x7ffaaf0aea40
        public void MergeLayout(){} // RVA: 0x7ffaaf0aeca0
        public void CreateLookupTableForControls(){} // RVA: 0x7ffaaf0b0710
        public void VariantsMatch(){} // RVA: 0x7ffaaf0b0c20
        public void VariantsMatch(){} // RVA: 0x7ffaaf0b0c20
        public void ParseHeaderFieldsFromJson(){} // RVA: 0x7ffaaf0b0d90
        public void get_cache(){} // RVA: 0x7ffaaf0b10f0
        public void CacheRef(){} // RVA: 0x7ffaaf0b1150
        public void .cctor(){} // RVA: 0x7ffaaf0b11b0
        public void <MergeLayout>b__77_0(){} // RVA: 0x7ffaaf0b1280
        // ── Binary Analysis Named ──
        public void GetValueType(){} // RVA: 0x7ffaaf0ac090
    }

    public class InputControlLayoutAttribute : Attribute
    {
        public object _commonUsages; // 0x33A56370, was: <commonUsages>k__BackingField
        public object canRunInBackgroundInternal; // 0x33A56370
        public object _displayName; // 0x33A56370, was: <displayName>k__BackingField

        // ── Original Methods ──
        public void get_stateType(){} // RVA: 0x7ffaa894d380
        public void set_stateType(){} // RVA: 0x7ffaa8933e30
        public void get_stateFormat(){} // RVA: 0x7ffaa89357c0
        public void set_stateFormat(){} // RVA: 0x7ffaa8998e80
        public void get_commonUsages(){} // RVA: 0x7ffaa89600c0
        public void set_commonUsages(){} // RVA: 0x7ffaa89600d0
        public void get_variants(){} // RVA: 0x7ffaa8960130
        public void set_variants(){} // RVA: 0x7ffaa8933e90
        public void get_isNoisy(){} // RVA: 0x7ffaa8958450
        public void set_isNoisy(){} // RVA: 0x7ffaa8958460
        public void get_canRunInBackground(){} // RVA: 0x7ffaaef72160
        public void set_canRunInBackground(){} // RVA: 0x7ffaaef721b0
        public void get_updateBeforeRender(){} // RVA: 0x7ffaaef72200
        public void set_updateBeforeRender(){} // RVA: 0x7ffaaef72250
        public void get_isGenericTypeOfDevice(){} // RVA: 0x7ffaa92431f0
        public void set_isGenericTypeOfDevice(){} // RVA: 0x7ffaaa152e60
        public void get_displayName(){} // RVA: 0x7ffaa8bf45b0
        public void set_displayName(){} // RVA: 0x7ffaa8bf45c0
        public void get_description(){} // RVA: 0x7ffaa89af740
        public void set_description(){} // RVA: 0x7ffaa895a200
        public void get_hideInUI(){} // RVA: 0x7ffaa89e9d30
        public void set_hideInUI(){} // RVA: 0x7ffaa89e9d40
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class InputDeviceBuilder : ValueType
    {
        public object m_ChildControlOverrides; // 0x339BF510
        public object kSizeForControlUsingStateFromOtherControl; // 0x339BF510

        // ── Original Methods ──
        public void Finish(){} // RVA: 0x7ffaaef72530
        public void Dispose(){} // RVA: 0x7ffaaef728e0
        public void Reset(){} // RVA: 0x7ffaaef728f0
        public void InstantiateLayout(){} // RVA: 0x7ffaaef72b50
        public void InstantiateLayout(){} // RVA: 0x7ffaaef72b50
        public void AddChildControls(){} // RVA: 0x7ffaaef734c0
        public void AddChildControl(){} // RVA: 0x7ffaaef73e60
        public void InsertChildControlOverride(){} // RVA: 0x7ffaaef749b0
        public void ChildControlOverridePath(){} // RVA: 0x7ffaaef74df0
        public void AddChildControlIfMissing(){} // RVA: 0x7ffaaef75020
        public void InsertChildControl(){} // RVA: 0x7ffaaef75150
        public void ApplyUseStateFrom(){} // RVA: 0x7ffaaef75790
        public void ShiftChildIndicesInHierarchyOneUp(){} // RVA: 0x7ffaaef75a30
        public void AddParentDisplayNameRecursive(){} // RVA: 0x7ffaaef75e20
        public void AddProcessors(){} // RVA: 0x7ffaaef75f50
        public void FindOrLoadLayout(){} // RVA: 0x7ffaaef76340
        public void ComputeStateLayout(){} // RVA: 0x7ffaaef763e0
        public void FinalizeControlHierarchy(){} // RVA: 0x7ffaaef76dc0
        public void FinalizeControlHierarchyRecursive(){} // RVA: 0x7ffaaef77120
        public void InsertControlBitRangeNode(){} // RVA: 0x7ffaaef77670
        public void AddControlToNode(){} // RVA: 0x7ffaaef782e0
        public void AddChildren(){} // RVA: 0x7ffaaef785e0
        public void get_instance(){} // RVA: 0x7ffaaef787f0
        public void Ref(){} // RVA: 0x7ffaaef78830
        // ── Binary Analysis Named ──
        public void Setup(){} // RVA: 0x7ffaaef722a0
        public void SetDisplayName(){} // RVA: 0x7ffaaef75aa0
        public void SetFormat(){} // RVA: 0x7ffaaef76280
        public void GetBestMidPoint(){} // RVA: 0x7ffaaef77b50
        public void GetControlIndex(){} // RVA: 0x7ffaaef78720
    }

    public class InputDeviceDescription : ValueType
    {
        public object m_Manufacturer; // 0x317BB3B0
        public object m_Version; // 0x317BB3B0

        // ── Original Methods ──
        public void get_interfaceName(){} // RVA: 0x7ffaa950bda0
        public void set_interfaceName(){} // RVA: 0x7ffaa930eca0
        public void get_deviceClass(){} // RVA: 0x7ffaa9e47540
        public void set_deviceClass(){} // RVA: 0x7ffaa9e47560
        public void get_manufacturer(){} // RVA: 0x7ffaa894d380
        public void set_manufacturer(){} // RVA: 0x7ffaa8933e30
        public void get_product(){} // RVA: 0x7ffaa89357c0
        public void set_product(){} // RVA: 0x7ffaa8998e80
        public void get_serial(){} // RVA: 0x7ffaa89600c0
        public void set_serial(){} // RVA: 0x7ffaa89600d0
        public void get_version(){} // RVA: 0x7ffaa8960130
        public void set_version(){} // RVA: 0x7ffaa8933e90
        public void get_capabilities(){} // RVA: 0x7ffaa8bfcc80
        public void set_capabilities(){} // RVA: 0x7ffaa8960890
        public void get_empty(){} // RVA: 0x7ffaaef78920
        public void ToString(){} // RVA: 0x7ffaaef78990
        public void Equals(){} // RVA: 0x7ffaaef78f20
        public void Equals(){} // RVA: 0x7ffaaef78f20
        public void op_Equality(){} // RVA: 0x7ffaaef79130
        public void op_Inequality(){} // RVA: 0x7ffaaef79170
        public void ToJson(){} // RVA: 0x7ffaaef791b0
        public void FromJson(){} // RVA: 0x7ffaaef79490
        public void ComparePropertyToDeviceDescriptor(){} // RVA: 0x7ffaaef798f0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaef78fd0
    }

    public class InputDeviceFindControlLayoutDelegate : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf0aa990
        public void Invoke(){} // RVA: 0x7ffaa8a8e4e0
        public void EndInvoke(){} // RVA: 0x7ffaaa403b40
        // ── Binary Analysis Named ──
        public void BeginInvoke(){} // RVA: 0x7ffaaf0aaa70
    }

    public class InputDeviceMatcher : ValueType
    {
        public object kDeviceClassKey; // 0x317BB6D0
        public object kProductKey; // 0x317BB6D0

        // ── Original Methods ──
        public void get_empty(){} // RVA: 0x7ffaaa254200
        public void get_patterns(){} // RVA: 0x7ffaaef79ac0
        public void WithInterface(){} // RVA: 0x7ffaaef79b70
        public void WithDeviceClass(){} // RVA: 0x7ffaaef79c10
        public void WithManufacturer(){} // RVA: 0x7ffaaef79cb0
        public void WithManufacturerContains(){} // RVA: 0x7ffaaef79d50
        public void WithProduct(){} // RVA: 0x7ffaaef79de0
        public void WithVersion(){} // RVA: 0x7ffaaef79e80
        public void WithCapability(){} // RVA: 0x7ffaa887e5c0
        public void With(){} // RVA: 0x7ffaaef79f20
        public void MatchPercentage(){} // RVA: 0x7ffaaef7a2a0
        public void MatchSingleProperty(){} // RVA: 0x7ffaaef7a890
        public void MatchSinglePropertyContains(){} // RVA: 0x7ffaaef7aa80
        public void FromDeviceDescription(){} // RVA: 0x7ffaaef7acd0
        public void ToString(){} // RVA: 0x7ffaaef7afe0
        public void Equals(){} // RVA: 0x7ffaaef7b300
        public void Equals(){} // RVA: 0x7ffaaef7b300
        public void op_Equality(){} // RVA: 0x7ffaaef7b3a0
        public void op_Inequality(){} // RVA: 0x7ffaaef7b400
        public void .cctor(){} // RVA: 0x7ffaaef7b4a0
        // ── Binary Analysis Named ──
        public void GetNumPropertiesIn(){} // RVA: 0x7ffaaef7ac60
        public void GetHashCode(){} // RVA: 0x7ffaab94bfa0
    }

}