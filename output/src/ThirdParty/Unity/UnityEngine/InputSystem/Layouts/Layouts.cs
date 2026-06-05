// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Layouts
// Classes: 7
// Methods: 197

namespace ThirdParty.Unity.UnityEngine.InputSystem.Layouts
{
    public class InputControlAttribute
    {
        // ── Methods ──
        public void get_layout(){} // RVA: 0x7FFAF2DA8380
        public void set_layout(){} // RVA: 0x7FFAF2D8EE30
        public void get_variants(){} // RVA: 0x7FFAF2D907C0
        public void set_variants(){} // RVA: 0x7FFAF2DF3E80
        public void get_name(){} // RVA: 0x7FFAF2DBB0C0
        public void set_name(){} // RVA: 0x7FFAF2DBB0D0
        public void get_format(){} // RVA: 0x7FFAF2DBB130
        public void set_format(){} // RVA: 0x7FFAF2D8EE90
        public void get_usage(){} // RVA: 0x7FFAF30E74D0
        public void set_usage(){} // RVA: 0x7FFAF2DBB890
        public void get_usages(){} // RVA: 0x7FFAF2F476A0
        public void set_usages(){} // RVA: 0x7FFAF2F4B830
        public void get_parameters(){} // RVA: 0x7FFAF2E0A740
        public void set_parameters(){} // RVA: 0x7FFAF2DB5200
        public void get_processors(){} // RVA: 0x7FFAF2E08730
        public void set_processors(){} // RVA: 0x7FFAF2E08740
        public void get_alias(){} // RVA: 0x7FFAF2E2E0E0
        public void set_alias(){} // RVA: 0x7FFAF2EE54D0
        public void get_aliases(){} // RVA: 0x7FFAF2E55500
        public void set_aliases(){} // RVA: 0x7FFAF2E55510
        public void get_useStateFrom(){} // RVA: 0x7FFAF2E2B370
        public void set_useStateFrom(){} // RVA: 0x7FFAF2E2B380
        public void get_bit(){} // RVA: 0x7FFAF4741440
        public void set_bit(){} // RVA: 0x7FFAF4741450
        public void get_offset(){} // RVA: 0x7FFAF4741460
        public void set_offset(){} // RVA: 0x7FFAF4741470
        public void get_sizeInBits(){} // RVA: 0x7FFAF3B95CF0
        public void set_sizeInBits(){} // RVA: 0x7FFAF2F25080
        public void get_arraySize(){} // RVA: 0x7FFAF43D9080
        public void set_arraySize(){} // RVA: 0x7FFAF483D640
        public void get_displayName(){} // RVA: 0x7FFAF2F77C50
        public void set_displayName(){} // RVA: 0x7FFAF2F734F0
        public void get_shortDisplayName(){} // RVA: 0x7FFAF2F12D00
        public void set_shortDisplayName(){} // RVA: 0x7FFAF2F14450
        public void get_noisy(){} // RVA: 0x7FFAF3DF2AB0
        public void set_noisy(){} // RVA: 0x7FFAF3BA2C40
        public void get_synthetic(){} // RVA: 0x7FFAF3DFA680
        public void set_synthetic(){} // RVA: 0x7FFAF3DF3820
        public void get_dontReset(){} // RVA: 0x7FFAF8DDC250
        public void set_dontReset(){} // RVA: 0x7FFAF99A0260
        public void get_defaultState(){} // RVA: 0x7FFAF3246DE0
        public void set_defaultState(){} // RVA: 0x7FFAF3604600
        public void get_minValue(){} // RVA: 0x7FFAF34CC8C0
        public void set_minValue(){} // RVA: 0x7FFAF345A650
        public void get_maxValue(){} // RVA: 0x7FFAF34B85E0
        public void set_maxValue(){} // RVA: 0x7FFAF345A5F0
        public void .ctor(){} // RVA: 0x7FFAF99A0270
    }

    public class InputControlLayout
    {
        public object header;
        public object recordIndex;
        public object version;
        public object valid;
        public object owner;
        public object index;
        public object time;
        public object control;
        public object next;
        public object previous;

        // ── Methods ──
        public void get_DefaultVariant(){} // RVA: 0x7FFAF99A0400
        public void get_name(){} // RVA: 0x7FFAF441ABE0
        public void get_displayName(){} // RVA: 0x7FFAF99A0460
        public void get_type(){} // RVA: 0x7FFAF2DBB0C0
        public void get_variants(){} // RVA: 0x7FFAF3BCF520
        public void get_stateFormat(){} // RVA: 0x7FFAF3A8C9F0
        public void get_stateSizeInBytes(){} // RVA: 0x7FFAF3341AF0
        public void get_baseLayouts(){} // RVA: 0x7FFAF99A04C0
        public void get_appliedOverrides(){} // RVA: 0x7FFAF99A0520
        public void get_commonUsages(){} // RVA: 0x7FFAF99A0580
        public void get_controls(){} // RVA: 0x7FFAF99A0650
        public void get_updateBeforeRender(){} // RVA: 0x7FFAF99A0720
        public void get_isDeviceLayout(){} // RVA: 0x7FFAF99A0760
        public void get_isControlLayout(){} // RVA: 0x7FFAF99A0840
        public void get_isOverride(){} // RVA: 0x7FFAF99A0920
        public void set_isOverride(){} // RVA: 0x7FFAF99A0930
        public void get_isGenericTypeOfDevice(){} // RVA: 0x7FFAF99A0950
        public void set_isGenericTypeOfDevice(){} // RVA: 0x7FFAF99A0960
        public void get_hideInUI(){} // RVA: 0x7FFAF99A0980
        public void set_hideInUI(){} // RVA: 0x7FFAF99A0990
        public void get_isNoisy(){} // RVA: 0x7FFAF99A09B0
        public void set_isNoisy(){} // RVA: 0x7FFAF99A09C0
        public void get_canRunInBackground(){} // RVA: 0x7FFAF99A09E0
        public void set_canRunInBackground(){} // RVA: 0x7FFAF99A0A40
        public void get_Item(){} // RVA: 0x7FFAF99A0AE0
        public void FindControl(){} // RVA: 0x7FFAF99A0CA0
        public void FindControlIncludingArrayElements(){} // RVA: 0x7FFAF99A0FF0
        public void GetValueType(){} // RVA: 0x7FFAF99A1980
        public void FromType(){} // RVA: 0x7FFAF99A1A50
        public void ToJson(){} // RVA: 0x7FFAF99A2160
        public void FromJson(){} // RVA: 0x7FFAF99A2210
        public void .ctor(){} // RVA: 0x7FFAF99A23B0
        public void AddControlItems(){} // RVA: 0x7FFAF99A24A0
        public void AddControlItemsFromFields(){} // RVA: 0x7FFAF99A25E0
        public void AddControlItemsFromProperties(){} // RVA: 0x7FFAF99A2680
        public void AddControlItemsFromMembers(){} // RVA: 0x7FFAF99A2720
        public void AddControlItemsFromMember(){} // RVA: 0x7FFAF99A2D40
        public void CreateControlItemFromMember(){} // RVA: 0x7FFAF99A3100
        public void InferLayoutFromValueType(){} // RVA: 0x7FFAF99A4330
        public void MergeLayout(){} // RVA: 0x7FFAF99A4590
        public void CreateLookupTableForControls(){} // RVA: 0x7FFAF99A6000
        public void VariantsMatch(){} // RVA: 0x7FFAF99A6510 | overloaded x2
        public void ParseHeaderFieldsFromJson(){} // RVA: 0x7FFAF99A6680
        public void get_cache(){} // RVA: 0x7FFAF99A69E0
        public void CacheRef(){} // RVA: 0x7FFAF99A6A40
        public void .cctor(){} // RVA: 0x7FFAF99A6AA0
        public void <MergeLayout>b__77_0(){} // RVA: 0x7FFAF99A6B70
    }

    public class InputControlLayoutAttribute
    {
        // ── Methods ──
        public void get_stateType(){} // RVA: 0x7FFAF2DA8380
        public void set_stateType(){} // RVA: 0x7FFAF2D8EE30
        public void get_stateFormat(){} // RVA: 0x7FFAF2D907C0
        public void set_stateFormat(){} // RVA: 0x7FFAF2DF3E80
        public void get_commonUsages(){} // RVA: 0x7FFAF2DBB0C0
        public void set_commonUsages(){} // RVA: 0x7FFAF2DBB0D0
        public void get_variants(){} // RVA: 0x7FFAF2DBB130
        public void set_variants(){} // RVA: 0x7FFAF2D8EE90
        public void get_isNoisy(){} // RVA: 0x7FFAF2DB3450
        public void set_isNoisy(){} // RVA: 0x7FFAF2DB3460
        public void get_canRunInBackground(){} // RVA: 0x7FFAF9867A30
        public void set_canRunInBackground(){} // RVA: 0x7FFAF9867A80
        public void get_updateBeforeRender(){} // RVA: 0x7FFAF9867AD0
        public void set_updateBeforeRender(){} // RVA: 0x7FFAF9867B20
        public void get_isGenericTypeOfDevice(){} // RVA: 0x7FFAF2FAAD10
        public void set_isGenericTypeOfDevice(){} // RVA: 0x7FFAF2FABCA0
        public void get_displayName(){} // RVA: 0x7FFAF2F476A0
        public void set_displayName(){} // RVA: 0x7FFAF2F4B830
        public void get_description(){} // RVA: 0x7FFAF2E0A740
        public void set_description(){} // RVA: 0x7FFAF2DB5200
        public void get_hideInUI(){} // RVA: 0x7FFAF2E44D30
        public void set_hideInUI(){} // RVA: 0x7FFAF2E44D40
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class InputDeviceBuilder
    {
        // ── Methods ──
        public void Setup(){} // RVA: 0x7FFAF9867B70
        public void Finish(){} // RVA: 0x7FFAF9867E00
        public void Dispose(){} // RVA: 0x7FFAF98681B0
        public void Reset(){} // RVA: 0x7FFAF98681C0
        public void InstantiateLayout(){} // RVA: 0x7FFAF9868420 | overloaded x2
        public void AddChildControls(){} // RVA: 0x7FFAF9868D90
        public void AddChildControl(){} // RVA: 0x7FFAF9869730
        public void InsertChildControlOverride(){} // RVA: 0x7FFAF986A280
        public void ChildControlOverridePath(){} // RVA: 0x7FFAF986A6C0
        public void AddChildControlIfMissing(){} // RVA: 0x7FFAF986A8F0
        public void InsertChildControl(){} // RVA: 0x7FFAF986AA20
        public void ApplyUseStateFrom(){} // RVA: 0x7FFAF986B060
        public void ShiftChildIndicesInHierarchyOneUp(){} // RVA: 0x7FFAF986B300
        public void SetDisplayName(){} // RVA: 0x7FFAF986B370
        public void AddParentDisplayNameRecursive(){} // RVA: 0x7FFAF986B6F0
        public void AddProcessors(){} // RVA: 0x7FFAF986B820
        public void SetFormat(){} // RVA: 0x7FFAF986BB50
        public void FindOrLoadLayout(){} // RVA: 0x7FFAF986BC10
        public void ComputeStateLayout(){} // RVA: 0x7FFAF986BCB0
        public void FinalizeControlHierarchy(){} // RVA: 0x7FFAF986C690
        public void FinalizeControlHierarchyRecursive(){} // RVA: 0x7FFAF986C9F0
        public void InsertControlBitRangeNode(){} // RVA: 0x7FFAF986CF40
        public void GetBestMidPoint(){} // RVA: 0x7FFAF986D420
        public void AddControlToNode(){} // RVA: 0x7FFAF986DBB0
        public void AddChildren(){} // RVA: 0x7FFAF986DEB0
        public void GetControlIndex(){} // RVA: 0x7FFAF986DFF0
        public void get_instance(){} // RVA: 0x7FFAF986E0C0
        public void Ref(){} // RVA: 0x7FFAF986E100
    }

    public class InputDeviceDescription
    {
        // ── Methods ──
        public void get_interfaceName(){} // RVA: 0x7FFAF4584690
        public void set_interfaceName(){} // RVA: 0x7FFAF3ABA2F0
        public void get_deviceClass(){} // RVA: 0x7FFAF44189C0
        public void set_deviceClass(){} // RVA: 0x7FFAF4418950
        public void get_manufacturer(){} // RVA: 0x7FFAF2DA8380
        public void set_manufacturer(){} // RVA: 0x7FFAF2D8EE30
        public void get_product(){} // RVA: 0x7FFAF2D907C0
        public void set_product(){} // RVA: 0x7FFAF2DF3E80
        public void get_serial(){} // RVA: 0x7FFAF2DBB0C0
        public void set_serial(){} // RVA: 0x7FFAF2DBB0D0
        public void get_version(){} // RVA: 0x7FFAF2DBB130
        public void set_version(){} // RVA: 0x7FFAF2D8EE90
        public void get_capabilities(){} // RVA: 0x7FFAF30E74D0
        public void set_capabilities(){} // RVA: 0x7FFAF2DBB890
        public void get_empty(){} // RVA: 0x7FFAF986E1F0
        public void ToString(){} // RVA: 0x7FFAF986E260
        public void Equals(){} // RVA: 0x7FFAF986E7F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF986E8A0
        public void op_Equality(){} // RVA: 0x7FFAF986EA00
        public void op_Inequality(){} // RVA: 0x7FFAF986EA40
        public void ToJson(){} // RVA: 0x7FFAF986EA80
        public void FromJson(){} // RVA: 0x7FFAF986ED60
        public void ComparePropertyToDeviceDescriptor(){} // RVA: 0x7FFAF986F1C0
    }

    public class InputDeviceFindControlLayoutDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF99A0280
        public void Invoke(){} // RVA: 0x7FFAF2EE94E0
        public void BeginInvoke(){} // RVA: 0x7FFAF99A0360
        public void EndInvoke(){} // RVA: 0x7FFAF498D9F0
    }

    public class InputDeviceMatcher
    {
        // ── Methods ──
        public void get_empty(){} // RVA: 0x7FFAF47D6810
        public void get_patterns(){} // RVA: 0x7FFAF986F390
        public void WithInterface(){} // RVA: 0x7FFAF986F440
        public void WithDeviceClass(){} // RVA: 0x7FFAF986F4E0
        public void WithManufacturer(){} // RVA: 0x7FFAF986F580
        public void WithManufacturerContains(){} // RVA: 0x7FFAF986F620
        public void WithProduct(){} // RVA: 0x7FFAF986F6B0
        public void WithVersion(){} // RVA: 0x7FFAF986F750
        public void WithCapability(){} // RVA: 0x7FFAF2D33FA0
        public void With(){} // RVA: 0x7FFAF986F7F0
        public void MatchPercentage(){} // RVA: 0x7FFAF986FB70
        public void MatchSingleProperty(){} // RVA: 0x7FFAF9870160
        public void MatchSinglePropertyContains(){} // RVA: 0x7FFAF9870350
        public void GetNumPropertiesIn(){} // RVA: 0x7FFAF9870530
        public void FromDeviceDescription(){} // RVA: 0x7FFAF98705A0
        public void ToString(){} // RVA: 0x7FFAF98708B0
        public void Equals(){} // RVA: 0x7FFAF9870BD0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAF9870C70
        public void op_Inequality(){} // RVA: 0x7FFAF9870CD0
        public void GetHashCode(){} // RVA: 0x7FFAF60C8360
        public void .cctor(){} // RVA: 0x7FFAF9870D70
    }

}