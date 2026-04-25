// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Layouts
// Classes: 7
// Methods: 197

namespace ThirdParty.Unity.UnityEngine.InputSystem.Layouts
{
    public class InputControlAttribute : PropertyAttribute
    {
        public string layout; // 0x10
        public string variants; // 0x18
        public string name; // 0x20
        public string format; // 0x28
        public string usage; // 0x30
        public string[] usages; // 0x38
        public string parameters; // 0x40
        public string processors; // 0x48
        public string alias; // 0x50
        public string[] aliases; // 0x58
        public string useStateFrom; // 0x60
        public uint bit; // 0x68
        public uint offset; // 0x6C
        public uint sizeInBits; // 0x70
        public int arraySize; // 0x74
        public string displayName; // 0x78
        public string shortDisplayName; // 0x80
        public bool noisy; // 0x88
        public bool synthetic; // 0x89
        public bool dontReset; // 0x8A
        public object defaultState; // 0x90
        public object minValue; // 0x98
        public object maxValue; // 0xA0

        // ── Methods ──
        public void get_layout(){} // RVA: 0x7FFAC2F3C380
        public void set_layout(){} // RVA: 0x7FFAC2F22E30
        public void get_variants(){} // RVA: 0x7FFAC2F247C0
        public void set_variants(){} // RVA: 0x7FFAC2F87E80
        public void get_name(){} // RVA: 0x7FFAC2F4F0C0
        public void set_name(){} // RVA: 0x7FFAC2F4F0D0
        public void get_format(){} // RVA: 0x7FFAC2F4F130
        public void set_format(){} // RVA: 0x7FFAC2F22E90
        public void get_usage(){} // RVA: 0x7FFAC31D95E0
        public void set_usage(){} // RVA: 0x7FFAC2F4F890
        public void get_usages(){} // RVA: 0x7FFAC31D0140
        public void set_usages(){} // RVA: 0x7FFAC31D0C20
        public void get_parameters(){} // RVA: 0x7FFAC2F9E740
        public void set_parameters(){} // RVA: 0x7FFAC2F49200
        public void get_processors(){} // RVA: 0x7FFAC2F9C730
        public void set_processors(){} // RVA: 0x7FFAC2F9C740
        public void get_alias(){} // RVA: 0x7FFAC2FC20E0
        public void set_alias(){} // RVA: 0x7FFAC30794D0
        public void get_aliases(){} // RVA: 0x7FFAC2FE9500
        public void set_aliases(){} // RVA: 0x7FFAC2FE9510
        public void get_useStateFrom(){} // RVA: 0x7FFAC2FBF370
        public void set_useStateFrom(){} // RVA: 0x7FFAC2FBF380
        public void get_bit(){} // RVA: 0x7FFAC47BAB50
        public void set_bit(){} // RVA: 0x7FFAC47BAB60
        public void get_offset(){} // RVA: 0x7FFAC47BAB70
        public void set_offset(){} // RVA: 0x7FFAC47BAB80
        public void get_sizeInBits(){} // RVA: 0x7FFAC3B99E80
        public void set_sizeInBits(){} // RVA: 0x7FFAC30B6520
        public void get_arraySize(){} // RVA: 0x7FFAC43D9E20
        public void set_arraySize(){} // RVA: 0x7FFAC48B4C80
        public void get_displayName(){} // RVA: 0x7FFAC30E5600
        public void set_displayName(){} // RVA: 0x7FFAC30E06F0
        public void get_shortDisplayName(){} // RVA: 0x7FFAC32EF410
        public void set_shortDisplayName(){} // RVA: 0x7FFAC34D4AA0
        public void get_noisy(){} // RVA: 0x7FFAC3E003A0
        public void set_noisy(){} // RVA: 0x7FFAC3E0C170
        public void get_synthetic(){} // RVA: 0x7FFAC3E04950
        public void set_synthetic(){} // RVA: 0x7FFAC3E09570
        public void get_dontReset(){} // RVA: 0x7FFAC8AC35F0
        public void set_dontReset(){} // RVA: 0x7FFAC9688990
        public void get_defaultState(){} // RVA: 0x7FFAC32EF640
        public void set_defaultState(){} // RVA: 0x7FFAC354E360
        public void get_minValue(){} // RVA: 0x7FFAC354DFB0
        public void set_minValue(){} // RVA: 0x7FFAC354E3C0
        public void get_maxValue(){} // RVA: 0x7FFAC3543900
        public void set_maxValue(){} // RVA: 0x7FFAC354E420
        public void .ctor(){} // RVA: 0x7FFAC96889A0
    }

    public class InputControlLayout : Object
    {
        public UnityEngine.InputSystem.Utilities.InternedString DefaultVariant;
        public string name;
        public UnityEngine.InputSystem.Utilities.InternedString displayName; // 0x10
        public System.Type type; // 0x20
        public UnityEngine.InputSystem.Utilities.InternedString variants; // 0x28
        public UnityEngine.InputSystem.Utilities.FourCC stateFormat; // 0x38
        public int stateSizeInBytes; // 0x3C
        public System.Nullable`1<bool> baseLayouts; // 0x40
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.Utilities.InternedString> appliedOverrides; // 0x48
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.Utilities.InternedString> commonUsages; // 0x68
        public UnityEngine.InputSystem.Utilities.InternedString[] controls; // 0x88
        public ControlItem[] updateBeforeRender; // 0x90
        public string isDeviceLayout; // 0x98
        public string isControlLayout; // 0xA0
        public 0x6B14FAA0 isOverride; // 0xA8
        public Collection isGenericTypeOfDevice; // 0x10
        public Cache hideInUI; // 0x50
        public int isNoisy; // 0x58

        // ── Methods ──
        public void get_DefaultVariant(){} // RVA: 0x7FFAC9688B30
        public void get_name(){} // RVA: 0x7FFAC4422E80
        public void get_displayName(){} // RVA: 0x7FFAC9688B90
        public void get_type(){} // RVA: 0x7FFAC2F4F0C0
        public void get_variants(){} // RVA: 0x7FFAC3BCF020
        public void get_stateFormat(){} // RVA: 0x7FFAC358A870
        public void get_stateSizeInBytes(){} // RVA: 0x7FFAC33BD4A0
        public void get_baseLayouts(){} // RVA: 0x7FFAC9688BF0
        public void get_appliedOverrides(){} // RVA: 0x7FFAC9688C50
        public void get_commonUsages(){} // RVA: 0x7FFAC9688CB0
        public void get_controls(){} // RVA: 0x7FFAC9688D80
        public void get_updateBeforeRender(){} // RVA: 0x7FFAC9688E50
        public void get_isDeviceLayout(){} // RVA: 0x7FFAC9688E90
        public void get_isControlLayout(){} // RVA: 0x7FFAC9688F70
        public void get_isOverride(){} // RVA: 0x7FFAC9689050
        public void set_isOverride(){} // RVA: 0x7FFAC9689060
        public void get_isGenericTypeOfDevice(){} // RVA: 0x7FFAC9689080
        public void set_isGenericTypeOfDevice(){} // RVA: 0x7FFAC9689090
        public void get_hideInUI(){} // RVA: 0x7FFAC96890B0
        public void set_hideInUI(){} // RVA: 0x7FFAC96890C0
        public void get_isNoisy(){} // RVA: 0x7FFAC96890E0
        public void set_isNoisy(){} // RVA: 0x7FFAC96890F0
        public void get_canRunInBackground(){} // RVA: 0x7FFAC9689110
        public void set_canRunInBackground(){} // RVA: 0x7FFAC9689170
        public void get_Item(){} // RVA: 0x7FFAC9689210
        public void FindControl(){} // RVA: 0x7FFAC96893D0
        public void FindControlIncludingArrayElements(){} // RVA: 0x7FFAC9689720
        public void GetValueType(){} // RVA: 0x7FFAC968A0B0
        public void FromType(){} // RVA: 0x7FFAC968A180
        public void ToJson(){} // RVA: 0x7FFAC968A890
        public void FromJson(){} // RVA: 0x7FFAC968A940
        public void .ctor(){} // RVA: 0x7FFAC968AAE0
        public void AddControlItems(){} // RVA: 0x7FFAC968ABD0
        public void AddControlItemsFromFields(){} // RVA: 0x7FFAC968AD10
        public void AddControlItemsFromProperties(){} // RVA: 0x7FFAC968ADB0
        public void AddControlItemsFromMembers(){} // RVA: 0x7FFAC968AE50
        public void AddControlItemsFromMember(){} // RVA: 0x7FFAC968B470
        public void CreateControlItemFromMember(){} // RVA: 0x7FFAC968B830
        public void InferLayoutFromValueType(){} // RVA: 0x7FFAC968CA60
        public void MergeLayout(){} // RVA: 0x7FFAC968CCC0
        public void CreateLookupTableForControls(){} // RVA: 0x7FFAC968E730
        public void VariantsMatch(){} // RVA: 0x7FFAC968EC40 | overloaded x2
        public void ParseHeaderFieldsFromJson(){} // RVA: 0x7FFAC968EDB0
        public void get_cache(){} // RVA: 0x7FFAC968F110
        public void CacheRef(){} // RVA: 0x7FFAC968F170
        public void .cctor(){} // RVA: 0x7FFAC968F1D0
        public void <MergeLayout>b__77_0(){} // RVA: 0x7FFAC968F2A0
    }

    public class InputControlLayoutAttribute : Attribute
    {
        public System.Type stateType; // 0x10
        public string stateFormat; // 0x18
        public string[] commonUsages; // 0x20
        public string variants; // 0x28
        public bool isNoisy; // 0x30
        public System.Nullable`1<bool> canRunInBackground; // 0x31
        public System.Nullable`1<bool> updateBeforeRender; // 0x33
        public bool isGenericTypeOfDevice; // 0x35
        public string displayName; // 0x38
        public string description; // 0x40
        public bool hideInUI; // 0x48

        // ── Methods ──
        public void get_stateType(){} // RVA: 0x7FFAC2F3C380
        public void set_stateType(){} // RVA: 0x7FFAC2F22E30
        public void get_stateFormat(){} // RVA: 0x7FFAC2F247C0
        public void set_stateFormat(){} // RVA: 0x7FFAC2F87E80
        public void get_commonUsages(){} // RVA: 0x7FFAC2F4F0C0
        public void set_commonUsages(){} // RVA: 0x7FFAC2F4F0D0
        public void get_variants(){} // RVA: 0x7FFAC2F4F130
        public void set_variants(){} // RVA: 0x7FFAC2F22E90
        public void get_isNoisy(){} // RVA: 0x7FFAC2F47450
        public void set_isNoisy(){} // RVA: 0x7FFAC2F47460
        public void get_canRunInBackground(){} // RVA: 0x7FFAC9550190
        public void set_canRunInBackground(){} // RVA: 0x7FFAC95501E0
        public void get_updateBeforeRender(){} // RVA: 0x7FFAC9550230
        public void set_updateBeforeRender(){} // RVA: 0x7FFAC9550280
        public void get_isGenericTypeOfDevice(){} // RVA: 0x7FFAC3816470
        public void set_isGenericTypeOfDevice(){} // RVA: 0x7FFAC47394B0
        public void get_displayName(){} // RVA: 0x7FFAC31D0140
        public void set_displayName(){} // RVA: 0x7FFAC31D0C20
        public void get_description(){} // RVA: 0x7FFAC2F9E740
        public void set_description(){} // RVA: 0x7FFAC2F49200
        public void get_hideInUI(){} // RVA: 0x7FFAC2FD8D30
        public void set_hideInUI(){} // RVA: 0x7FFAC2FD8D40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class InputDeviceBuilder : ValueType
    {
        public UnityEngine.InputSystem.InputDevice instance; // 0x10
        public CacheRefInstance m_LayoutCacheRef; // 0x18
        public System.Collections.Generic.Dictionary`2<string,ControlItem> m_ChildControlOverrides; // 0x20
        public System.Collections.Generic.List`1<uint> m_StateOffsetToControlMap; // 0x28
        public System.Text.StringBuilder m_StringBuilder; // 0x30
        public uint kSizeForControlUsingStateFromOtherControl;
        public UnityEngine.InputSystem.Layouts.InputDeviceBuilder s_Instance;
        public int s_InstanceRef; // 0x28

        // ── Methods ──
        public void Setup(){} // RVA: 0x7FFAC95502D0
        public void Finish(){} // RVA: 0x7FFAC9550560
        public void Dispose(){} // RVA: 0x7FFAC9550910
        public void Reset(){} // RVA: 0x7FFAC9550920
        public void InstantiateLayout(){} // RVA: 0x7FFAC9550B80 | overloaded x2
        public void AddChildControls(){} // RVA: 0x7FFAC95514F0
        public void AddChildControl(){} // RVA: 0x7FFAC9551E90
        public void InsertChildControlOverride(){} // RVA: 0x7FFAC95529E0
        public void ChildControlOverridePath(){} // RVA: 0x7FFAC9552E20
        public void AddChildControlIfMissing(){} // RVA: 0x7FFAC9553050
        public void InsertChildControl(){} // RVA: 0x7FFAC9553180
        public void ApplyUseStateFrom(){} // RVA: 0x7FFAC95537C0
        public void ShiftChildIndicesInHierarchyOneUp(){} // RVA: 0x7FFAC9553A60
        public void SetDisplayName(){} // RVA: 0x7FFAC9553AD0
        public void AddParentDisplayNameRecursive(){} // RVA: 0x7FFAC9553E50
        public void AddProcessors(){} // RVA: 0x7FFAC9553F80
        public void SetFormat(){} // RVA: 0x7FFAC95542B0
        public void FindOrLoadLayout(){} // RVA: 0x7FFAC9554370
        public void ComputeStateLayout(){} // RVA: 0x7FFAC9554410
        public void FinalizeControlHierarchy(){} // RVA: 0x7FFAC9554DF0
        public void FinalizeControlHierarchyRecursive(){} // RVA: 0x7FFAC9555150
        public void InsertControlBitRangeNode(){} // RVA: 0x7FFAC95556A0
        public void GetBestMidPoint(){} // RVA: 0x7FFAC9555B80
        public void AddControlToNode(){} // RVA: 0x7FFAC9556310
        public void AddChildren(){} // RVA: 0x7FFAC9556610
        public void GetControlIndex(){} // RVA: 0x7FFAC9556750
        public void get_instance(){} // RVA: 0x7FFAC9556820
        public void Ref(){} // RVA: 0x7FFAC9556860
    }

    public class InputDeviceDescription : ValueType
    {
        public string interfaceName; // 0x10
        public string deviceClass; // 0x18
        public string manufacturer; // 0x20
        public string product; // 0x28
        public string serial; // 0x30
        public string version; // 0x38
        public string capabilities; // 0x40

        // ── Methods ──
        public void get_interfaceName(){} // RVA: 0x7FFAC3AD9F60
        public void set_interfaceName(){} // RVA: 0x7FFAC38DFE40
        public void get_deviceClass(){} // RVA: 0x7FFAC4420220
        public void set_deviceClass(){} // RVA: 0x7FFAC4420240
        public void get_manufacturer(){} // RVA: 0x7FFAC2F3C380
        public void set_manufacturer(){} // RVA: 0x7FFAC2F22E30
        public void get_product(){} // RVA: 0x7FFAC2F247C0
        public void set_product(){} // RVA: 0x7FFAC2F87E80
        public void get_serial(){} // RVA: 0x7FFAC2F4F0C0
        public void set_serial(){} // RVA: 0x7FFAC2F4F0D0
        public void get_version(){} // RVA: 0x7FFAC2F4F130
        public void set_version(){} // RVA: 0x7FFAC2F22E90
        public void get_capabilities(){} // RVA: 0x7FFAC31D95E0
        public void set_capabilities(){} // RVA: 0x7FFAC2F4F890
        public void get_empty(){} // RVA: 0x7FFAC9556950
        public void ToString(){} // RVA: 0x7FFAC95569C0
        public void Equals(){} // RVA: 0x7FFAC9556F50 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9557000
        public void op_Equality(){} // RVA: 0x7FFAC9557160
        public void op_Inequality(){} // RVA: 0x7FFAC95571A0
        public void ToJson(){} // RVA: 0x7FFAC95571E0
        public void FromJson(){} // RVA: 0x7FFAC95574C0
        public void ComparePropertyToDeviceDescriptor(){} // RVA: 0x7FFAC9557920
    }

    public class InputDeviceFindControlLayoutDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96889B0
        public void Invoke(){} // RVA: 0x7FFAC307D4E0
        public void BeginInvoke(){} // RVA: 0x7FFAC9688A90
        public void EndInvoke(){} // RVA: 0x7FFAC49FC700
    }

    public class InputDeviceMatcher : ValueType
    {
        public System.Collections.Generic.KeyValuePair`2<UnityEngine.InputSystem.Utilities.InternedString,object>[] empty; // 0x10
        public UnityEngine.InputSystem.Utilities.InternedString patterns;
        public UnityEngine.InputSystem.Utilities.InternedString kDeviceClassKey; // 0x10
        public UnityEngine.InputSystem.Utilities.InternedString kManufacturerKey; // 0x20
        public UnityEngine.InputSystem.Utilities.InternedString kManufacturerContainsKey; // 0x30
        public UnityEngine.InputSystem.Utilities.InternedString kProductKey; // 0x40
        public UnityEngine.InputSystem.Utilities.InternedString kVersionKey; // 0x50

        // ── Methods ──
        public void get_empty(){} // RVA: 0x7FFAC484C2F0
        public void get_patterns(){} // RVA: 0x7FFAC9557AF0
        public void WithInterface(){} // RVA: 0x7FFAC9557BA0
        public void WithDeviceClass(){} // RVA: 0x7FFAC9557C40
        public void WithManufacturer(){} // RVA: 0x7FFAC9557CE0
        public void WithManufacturerContains(){} // RVA: 0x7FFAC9557D80
        public void WithProduct(){} // RVA: 0x7FFAC9557E10
        public void WithVersion(){} // RVA: 0x7FFAC9557EB0
        public void WithCapability(){} // RVA: 0x7FFAC2E8DC40
        public void With(){} // RVA: 0x7FFAC9557F50
        public void MatchPercentage(){} // RVA: 0x7FFAC95582D0
        public void MatchSingleProperty(){} // RVA: 0x7FFAC95588C0
        public void MatchSinglePropertyContains(){} // RVA: 0x7FFAC9558AB0
        public void GetNumPropertiesIn(){} // RVA: 0x7FFAC9558C90
        public void FromDeviceDescription(){} // RVA: 0x7FFAC9558D00
        public void ToString(){} // RVA: 0x7FFAC9559010
        public void Equals(){} // RVA: 0x7FFAC9559330 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC95593D0
        public void op_Inequality(){} // RVA: 0x7FFAC9559430
        public void GetHashCode(){} // RVA: 0x7FFAC5F3AC20
        public void .cctor(){} // RVA: 0x7FFAC95594D0
    }

}