// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Layouts
// Classes: 7
// Methods: 197

namespace ThirdParty.Unity.UnityEngine.InputSystem.Layouts
{
    public class InputControlAttribute : PropertyAttribute
    {
        public object layout;
        public object variants;
        public object name;
        public object format;
        public object usage;
        public object usages;
        public object parameters;
        public object processors;
        public object alias;
        public object aliases;
        public object useStateFrom;
        public object bit;
        public object offset;
        public object sizeInBits;
        public object arraySize;
        public object displayName;
        public object shortDisplayName;
        public object noisy;
        public object synthetic;
        public object dontReset;
        public object defaultState;
        public object minValue;
        public object maxValue;

        // ── Methods ──
        public void get_layout(){} // RVA: 0x7FFD4E35C380
        public void set_layout(){} // RVA: 0x7FFD4E342E30
        public void get_variants(){} // RVA: 0x7FFD4E3447C0
        public void set_variants(){} // RVA: 0x7FFD4E3A7E80
        public void get_name(){} // RVA: 0x7FFD4E36F0C0
        public void set_name(){} // RVA: 0x7FFD4E36F0D0
        public void get_format(){} // RVA: 0x7FFD4E36F130
        public void set_format(){} // RVA: 0x7FFD4E342E90
        public void get_usage(){} // RVA: 0x7FFD4E5F95E0
        public void set_usage(){} // RVA: 0x7FFD4E36F890
        public void get_usages(){} // RVA: 0x7FFD4E5F0140
        public void set_usages(){} // RVA: 0x7FFD4E5F0C20
        public void get_parameters(){} // RVA: 0x7FFD4E3BE740
        public void set_parameters(){} // RVA: 0x7FFD4E369200
        public void get_processors(){} // RVA: 0x7FFD4E3BC730
        public void set_processors(){} // RVA: 0x7FFD4E3BC740
        public void get_alias(){} // RVA: 0x7FFD4E3E20E0
        public void set_alias(){} // RVA: 0x7FFD4E4994D0
        public void get_aliases(){} // RVA: 0x7FFD4E409500
        public void set_aliases(){} // RVA: 0x7FFD4E409510
        public void get_useStateFrom(){} // RVA: 0x7FFD4E3DF370
        public void set_useStateFrom(){} // RVA: 0x7FFD4E3DF380
        public void get_bit(){} // RVA: 0x7FFD4FBDAB50
        public void set_bit(){} // RVA: 0x7FFD4FBDAB60
        public void get_offset(){} // RVA: 0x7FFD4FBDAB70
        public void set_offset(){} // RVA: 0x7FFD4FBDAB80
        public void get_sizeInBits(){} // RVA: 0x7FFD4EFB9E80
        public void set_sizeInBits(){} // RVA: 0x7FFD4E4D6520
        public void get_arraySize(){} // RVA: 0x7FFD4F7F9E20
        public void set_arraySize(){} // RVA: 0x7FFD4FCD4C80
        public void get_displayName(){} // RVA: 0x7FFD4E505600
        public void set_displayName(){} // RVA: 0x7FFD4E5006F0
        public void get_shortDisplayName(){} // RVA: 0x7FFD4E70F410
        public void set_shortDisplayName(){} // RVA: 0x7FFD4E8F4AA0
        public void get_noisy(){} // RVA: 0x7FFD4F2203A0
        public void set_noisy(){} // RVA: 0x7FFD4F22C170
        public void get_synthetic(){} // RVA: 0x7FFD4F224950
        public void set_synthetic(){} // RVA: 0x7FFD4F229570
        public void get_dontReset(){} // RVA: 0x7FFD53EE35F0
        public void set_dontReset(){} // RVA: 0x7FFD54AA8990
        public void get_defaultState(){} // RVA: 0x7FFD4E70F640
        public void set_defaultState(){} // RVA: 0x7FFD4E96E360
        public void get_minValue(){} // RVA: 0x7FFD4E96DFB0
        public void set_minValue(){} // RVA: 0x7FFD4E96E3C0
        public void get_maxValue(){} // RVA: 0x7FFD4E963900
        public void set_maxValue(){} // RVA: 0x7FFD4E96E420
        public void .ctor(){} // RVA: 0x7FFD54AA89A0
    }

    public class InputControlLayout : Object
    {
        public object DefaultVariant;
        public object name;
        public object displayName;
        public object type;
        public object variants;
        public object stateFormat;
        public object stateSizeInBytes;
        public object baseLayouts;
        public object appliedOverrides;
        public object commonUsages;
        public object controls;
        public object updateBeforeRender;
        public object isDeviceLayout;
        public object isControlLayout;
        public object isOverride;
        public object isGenericTypeOfDevice;
        public object hideInUI;
        public object isNoisy;
        public object canRunInBackground;
        public object Item;
        public object cache;

        // ── Methods ──
        public void get_DefaultVariant(){} // RVA: 0x7FFD54AA8B30
        public void get_name(){} // RVA: 0x7FFD4F842E80
        public void get_displayName(){} // RVA: 0x7FFD54AA8B90
        public void get_type(){} // RVA: 0x7FFD4E36F0C0
        public void get_variants(){} // RVA: 0x7FFD4EFEF020
        public void get_stateFormat(){} // RVA: 0x7FFD4E9AA870
        public void get_stateSizeInBytes(){} // RVA: 0x7FFD4E7DD4A0
        public void get_baseLayouts(){} // RVA: 0x7FFD54AA8BF0
        public void get_appliedOverrides(){} // RVA: 0x7FFD54AA8C50
        public void get_commonUsages(){} // RVA: 0x7FFD54AA8CB0
        public void get_controls(){} // RVA: 0x7FFD54AA8D80
        public void get_updateBeforeRender(){} // RVA: 0x7FFD54AA8E50
        public void get_isDeviceLayout(){} // RVA: 0x7FFD54AA8E90
        public void get_isControlLayout(){} // RVA: 0x7FFD54AA8F70
        public void get_isOverride(){} // RVA: 0x7FFD54AA9050
        public void set_isOverride(){} // RVA: 0x7FFD54AA9060
        public void get_isGenericTypeOfDevice(){} // RVA: 0x7FFD54AA9080
        public void set_isGenericTypeOfDevice(){} // RVA: 0x7FFD54AA9090
        public void get_hideInUI(){} // RVA: 0x7FFD54AA90B0
        public void set_hideInUI(){} // RVA: 0x7FFD54AA90C0
        public void get_isNoisy(){} // RVA: 0x7FFD54AA90E0
        public void set_isNoisy(){} // RVA: 0x7FFD54AA90F0
        public void get_canRunInBackground(){} // RVA: 0x7FFD54AA9110
        public void set_canRunInBackground(){} // RVA: 0x7FFD54AA9170
        public void get_Item(){} // RVA: 0x7FFD54AA9210
        public void FindControl(){} // RVA: 0x7FFD54AA93D0
        public void FindControlIncludingArrayElements(){} // RVA: 0x7FFD54AA9720
        public void GetValueType(){} // RVA: 0x7FFD54AAA0B0
        public void FromType(){} // RVA: 0x7FFD54AAA180
        public void ToJson(){} // RVA: 0x7FFD54AAA890
        public void FromJson(){} // RVA: 0x7FFD54AAA940
        public void .ctor(){} // RVA: 0x7FFD54AAAAE0
        public void AddControlItems(){} // RVA: 0x7FFD54AAABD0
        public void AddControlItemsFromFields(){} // RVA: 0x7FFD54AAAD10
        public void AddControlItemsFromProperties(){} // RVA: 0x7FFD54AAADB0
        public void AddControlItemsFromMembers(){} // RVA: 0x7FFD54AAAE50
        public void AddControlItemsFromMember(){} // RVA: 0x7FFD54AAB470
        public void CreateControlItemFromMember(){} // RVA: 0x7FFD54AAB830
        public void InferLayoutFromValueType(){} // RVA: 0x7FFD54AACA60
        public void MergeLayout(){} // RVA: 0x7FFD54AACCC0
        public void CreateLookupTableForControls(){} // RVA: 0x7FFD54AAE730
        public void VariantsMatch(){} // RVA: 0x7FFD54AAEC40 | overloaded x2
        public void ParseHeaderFieldsFromJson(){} // RVA: 0x7FFD54AAEDB0
        public void get_cache(){} // RVA: 0x7FFD54AAF110
        public void CacheRef(){} // RVA: 0x7FFD54AAF170
        public void .cctor(){} // RVA: 0x7FFD54AAF1D0
        public void <MergeLayout>b__77_0(){} // RVA: 0x7FFD54AAF2A0
    }

    public class InputControlLayoutAttribute : Attribute
    {
        public object stateType;
        public object stateFormat;
        public object commonUsages;
        public object variants;
        public object isNoisy;
        public object canRunInBackground;
        public object updateBeforeRender;
        public object isGenericTypeOfDevice;
        public object displayName;
        public object description;
        public object hideInUI;

        // ── Methods ──
        public void get_stateType(){} // RVA: 0x7FFD4E35C380
        public void set_stateType(){} // RVA: 0x7FFD4E342E30
        public void get_stateFormat(){} // RVA: 0x7FFD4E3447C0
        public void set_stateFormat(){} // RVA: 0x7FFD4E3A7E80
        public void get_commonUsages(){} // RVA: 0x7FFD4E36F0C0
        public void set_commonUsages(){} // RVA: 0x7FFD4E36F0D0
        public void get_variants(){} // RVA: 0x7FFD4E36F130
        public void set_variants(){} // RVA: 0x7FFD4E342E90
        public void get_isNoisy(){} // RVA: 0x7FFD4E367450
        public void set_isNoisy(){} // RVA: 0x7FFD4E367460
        public void get_canRunInBackground(){} // RVA: 0x7FFD54970190
        public void set_canRunInBackground(){} // RVA: 0x7FFD549701E0
        public void get_updateBeforeRender(){} // RVA: 0x7FFD54970230
        public void set_updateBeforeRender(){} // RVA: 0x7FFD54970280
        public void get_isGenericTypeOfDevice(){} // RVA: 0x7FFD4EC36470
        public void set_isGenericTypeOfDevice(){} // RVA: 0x7FFD4FB594B0
        public void get_displayName(){} // RVA: 0x7FFD4E5F0140
        public void set_displayName(){} // RVA: 0x7FFD4E5F0C20
        public void get_description(){} // RVA: 0x7FFD4E3BE740
        public void set_description(){} // RVA: 0x7FFD4E369200
        public void get_hideInUI(){} // RVA: 0x7FFD4E3F8D30
        public void set_hideInUI(){} // RVA: 0x7FFD4E3F8D40
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class InputDeviceBuilder : ValueType
    {
        public object instance;

        // ── Methods ──
        public void Setup(){} // RVA: 0x7FFD549702D0
        public void Finish(){} // RVA: 0x7FFD54970560
        public void Dispose(){} // RVA: 0x7FFD54970910
        public void Reset(){} // RVA: 0x7FFD54970920
        public void InstantiateLayout(){} // RVA: 0x7FFD54970B80 | overloaded x2
        public void AddChildControls(){} // RVA: 0x7FFD549714F0
        public void AddChildControl(){} // RVA: 0x7FFD54971E90
        public void InsertChildControlOverride(){} // RVA: 0x7FFD549729E0
        public void ChildControlOverridePath(){} // RVA: 0x7FFD54972E20
        public void AddChildControlIfMissing(){} // RVA: 0x7FFD54973050
        public void InsertChildControl(){} // RVA: 0x7FFD54973180
        public void ApplyUseStateFrom(){} // RVA: 0x7FFD549737C0
        public void ShiftChildIndicesInHierarchyOneUp(){} // RVA: 0x7FFD54973A60
        public void SetDisplayName(){} // RVA: 0x7FFD54973AD0
        public void AddParentDisplayNameRecursive(){} // RVA: 0x7FFD54973E50
        public void AddProcessors(){} // RVA: 0x7FFD54973F80
        public void SetFormat(){} // RVA: 0x7FFD549742B0
        public void FindOrLoadLayout(){} // RVA: 0x7FFD54974370
        public void ComputeStateLayout(){} // RVA: 0x7FFD54974410
        public void FinalizeControlHierarchy(){} // RVA: 0x7FFD54974DF0
        public void FinalizeControlHierarchyRecursive(){} // RVA: 0x7FFD54975150
        public void InsertControlBitRangeNode(){} // RVA: 0x7FFD549756A0
        public void GetBestMidPoint(){} // RVA: 0x7FFD54975B80
        public void AddControlToNode(){} // RVA: 0x7FFD54976310
        public void AddChildren(){} // RVA: 0x7FFD54976610
        public void GetControlIndex(){} // RVA: 0x7FFD54976750
        public void get_instance(){} // RVA: 0x7FFD54976820
        public void Ref(){} // RVA: 0x7FFD54976860
    }

    public class InputDeviceDescription : ValueType
    {
        public object interfaceName;
        public object deviceClass;
        public object manufacturer;
        public object product;
        public object serial;
        public object version;
        public object capabilities;
        public object empty;

        // ── Methods ──
        public void get_interfaceName(){} // RVA: 0x7FFD4EEF9F60
        public void set_interfaceName(){} // RVA: 0x7FFD4ECFFE40
        public void get_deviceClass(){} // RVA: 0x7FFD4F840220
        public void set_deviceClass(){} // RVA: 0x7FFD4F840240
        public void get_manufacturer(){} // RVA: 0x7FFD4E35C380
        public void set_manufacturer(){} // RVA: 0x7FFD4E342E30
        public void get_product(){} // RVA: 0x7FFD4E3447C0
        public void set_product(){} // RVA: 0x7FFD4E3A7E80
        public void get_serial(){} // RVA: 0x7FFD4E36F0C0
        public void set_serial(){} // RVA: 0x7FFD4E36F0D0
        public void get_version(){} // RVA: 0x7FFD4E36F130
        public void set_version(){} // RVA: 0x7FFD4E342E90
        public void get_capabilities(){} // RVA: 0x7FFD4E5F95E0
        public void set_capabilities(){} // RVA: 0x7FFD4E36F890
        public void get_empty(){} // RVA: 0x7FFD54976950
        public void ToString(){} // RVA: 0x7FFD549769C0
        public void Equals(){} // RVA: 0x7FFD54976F50 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54977000
        public void op_Equality(){} // RVA: 0x7FFD54977160
        public void op_Inequality(){} // RVA: 0x7FFD549771A0
        public void ToJson(){} // RVA: 0x7FFD549771E0
        public void FromJson(){} // RVA: 0x7FFD549774C0
        public void ComparePropertyToDeviceDescriptor(){} // RVA: 0x7FFD54977920
    }

    public class InputDeviceFindControlLayoutDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54AA89B0
        public void Invoke(){} // RVA: 0x7FFD4E49D4E0
        public void BeginInvoke(){} // RVA: 0x7FFD54AA8A90
        public void EndInvoke(){} // RVA: 0x7FFD4FE1C700
    }

    public class InputDeviceMatcher : ValueType
    {
        public object empty;
        public object patterns;

        // ── Methods ──
        public void get_empty(){} // RVA: 0x7FFD4FC6C2F0
        public void get_patterns(){} // RVA: 0x7FFD54977AF0
        public void WithInterface(){} // RVA: 0x7FFD54977BA0
        public void WithDeviceClass(){} // RVA: 0x7FFD54977C40
        public void WithManufacturer(){} // RVA: 0x7FFD54977CE0
        public void WithManufacturerContains(){} // RVA: 0x7FFD54977D80
        public void WithProduct(){} // RVA: 0x7FFD54977E10
        public void WithVersion(){} // RVA: 0x7FFD54977EB0
        public void WithCapability(){} // RVA: 0x7FFD4E2ADC40
        public void With(){} // RVA: 0x7FFD54977F50
        public void MatchPercentage(){} // RVA: 0x7FFD549782D0
        public void MatchSingleProperty(){} // RVA: 0x7FFD549788C0
        public void MatchSinglePropertyContains(){} // RVA: 0x7FFD54978AB0
        public void GetNumPropertiesIn(){} // RVA: 0x7FFD54978C90
        public void FromDeviceDescription(){} // RVA: 0x7FFD54978D00
        public void ToString(){} // RVA: 0x7FFD54979010
        public void Equals(){} // RVA: 0x7FFD54979330 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFD549793D0
        public void op_Inequality(){} // RVA: 0x7FFD54979430
        public void GetHashCode(){} // RVA: 0x7FFD5135AC20
        public void .cctor(){} // RVA: 0x7FFD549794D0
    }

}