// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Layouts
// Classes: 8
// Methods: 211

namespace ThirdParty.Unity.UnityEngine.InputSystem.Layouts
{
    public class InputControlAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void get_layout(){} // RVA: 0x7A80F2570
        public void set_layout(){} // RVA: 0x7A80D8E20
        public void get_variants(){} // RVA: 0x7A80DA7B0
        public void set_variants(){} // RVA: 0x7A813E420
        public void get_name(){} // RVA: 0x7A81052C0
        public void set_name(){} // RVA: 0x7A81052D0
        public void get_format(){} // RVA: 0x7A8105330
        public void set_format(){} // RVA: 0x7A80D8E80
        public void get_usage(){} // RVA: 0x7A83F69F0
        public void set_usage(){} // RVA: 0x7A8105A90
        public void get_usages(){} // RVA: 0x7A8292C30
        public void set_usages(){} // RVA: 0x7A8296DE0
        public void get_parameters(){} // RVA: 0x7A8154D80
        public void set_parameters(){} // RVA: 0x7A80FF440
        public void get_processors(){} // RVA: 0x7A8152D80
        public void set_processors(){} // RVA: 0x7A8152D90
        public void get_alias(){} // RVA: 0x7A8178B90
        public void set_alias(){} // RVA: 0x7A8230620
        public void get_aliases(){} // RVA: 0x7A81A0050
        public void set_aliases(){} // RVA: 0x7A81A0060
        public void get_useStateFrom(){} // RVA: 0x7A8175DF0
        public void set_useStateFrom(){} // RVA: 0x7A8175E00
        public void get_bit(){} // RVA: 0x7A9A93870
        public void set_bit(){} // RVA: 0x7A9A93880
        public void get_offset(){} // RVA: 0x7A9A93890
        public void set_offset(){} // RVA: 0x7A9A938A0
        public void get_sizeInBits(){} // RVA: 0x7A8EA8210
        public void set_sizeInBits(){} // RVA: 0x7A8270510
        public void get_arraySize(){} // RVA: 0x7A96E4F70
        public void set_arraySize(){} // RVA: 0x7A9B90E90
        public void get_displayName(){} // RVA: 0x7A82C2060
        public void set_displayName(){} // RVA: 0x7A82C0530
        public void get_shortDisplayName(){} // RVA: 0x7A825E100
        public void set_shortDisplayName(){} // RVA: 0x7A825F860
        public void get_noisy(){} // RVA: 0x7A90FA160
        public void set_noisy(){} // RVA: 0x7A90F9520
        public void get_synthetic(){} // RVA: 0x7A9101D50
        public void set_synthetic(){} // RVA: 0x7A90FAED0
        public void get_dontReset(){} // RVA: 0x7AE117D20
        public void set_dontReset(){} // RVA: 0x7AECCEC10
        public void get_defaultState(){} // RVA: 0x7A8555100
        public void set_defaultState(){} // RVA: 0x7A8919DE0
        public void get_minValue(){} // RVA: 0x7A87D9C10
        public void set_minValue(){} // RVA: 0x7A8744720
        public void get_maxValue(){} // RVA: 0x7A87C5850
        public void set_maxValue(){} // RVA: 0x7A87446C0
        public void .ctor(){} // RVA: 0x7AECCEC20
        public void <layout>k__BackingField(){} // RVA: 0x7B3FAD638
    }

    public class InputControlLayout : Object
    {
        // ── Methods ──
        public void get_DefaultVariant(){} // RVA: 0x7AECCEDC0
        public void get_name(){} // RVA: 0x7A97277F0
        public void get_displayName(){} // RVA: 0x7AECCEE20
        public void get_type(){} // RVA: 0x7A81052C0
        public void get_variants(){} // RVA: 0x7A8EDF360
        public void get_stateFormat(){} // RVA: 0x7A8D863F0
        public void get_stateSizeInBytes(){} // RVA: 0x7A864E8D0
        public void get_baseLayouts(){} // RVA: 0x7AECCEE80
        public void get_appliedOverrides(){} // RVA: 0x7AECCEEE0
        public void get_commonUsages(){} // RVA: 0x7AECCEF40
        public void get_controls(){} // RVA: 0x7AECCF010
        public void get_updateBeforeRender(){} // RVA: 0x7AECCF0E0
        public void get_isDeviceLayout(){} // RVA: 0x7AECCF120
        public void get_isControlLayout(){} // RVA: 0x7AECCF200
        public void get_isOverride(){} // RVA: 0x7AECCF2E0
        public void set_isOverride(){} // RVA: 0x7AECCF2F0
        public void get_isGenericTypeOfDevice(){} // RVA: 0x7AECCF310
        public void set_isGenericTypeOfDevice(){} // RVA: 0x7AECCF320
        public void get_hideInUI(){} // RVA: 0x7AECCF340
        public void set_hideInUI(){} // RVA: 0x7AECCF350
        public void get_isNoisy(){} // RVA: 0x7AECCF370
        public void set_isNoisy(){} // RVA: 0x7AECCF380
        public void get_canRunInBackground(){} // RVA: 0x7AECCF3A0
        public void set_canRunInBackground(){} // RVA: 0x7AECCF400
        public void get_Item(){} // RVA: 0x7AECCF4A0
        public void FindControl(){} // RVA: 0x7AECCF660
        public void FindControlIncludingArrayElements(){} // RVA: 0x7AECCF990
        public void GetValueType(){} // RVA: 0x7AECD0040
        public void FromType(){} // RVA: 0x7AECD0110
        public void ToJson(){} // RVA: 0x7AECD0830
        public void FromJson(){} // RVA: 0x7AECD08E0
        public void .ctor(){} // RVA: 0x7AECD0AB0
        public void AddControlItems(){} // RVA: 0x7AECD0BA0
        public void AddControlItemsFromFields(){} // RVA: 0x7AECD0CE0
        public void AddControlItemsFromProperties(){} // RVA: 0x7AECD0D80
        public void AddControlItemsFromMembers(){} // RVA: 0x7AECD0E20
        public void AddControlItemsFromMember(){} // RVA: 0x7AECD1450
        public void CreateControlItemFromMember(){} // RVA: 0x7AECD1810
        public void InferLayoutFromValueType(){} // RVA: 0x7AECD29D0
        public void MergeLayout(){} // RVA: 0x7AECD2C30
        public void CreateLookupTableForControls(){} // RVA: 0x7AECD46D0
        public void VariantsMatch(){} // RVA: 0x7AECD4BE0
        public void ParseHeaderFieldsFromJson(){} // RVA: 0x7AECD4D50
        public void get_cache(){} // RVA: 0x7AECD50C0
        public void CacheRef(){} // RVA: 0x7AECD5120
        public void .cctor(){} // RVA: 0x7AECD5180
        public void <MergeLayout>b__77_0(){} // RVA: 0x7AECD5250
        public void s_DefaultVariant(){} // RVA: 0x7B3F8A758
    }

    public class InputControlLayoutAttribute : Attribute
    {
        // ── Methods ──
        public void get_stateType(){} // RVA: 0x7A80F2570
        public void set_stateType(){} // RVA: 0x7A80D8E20
        public void get_stateFormat(){} // RVA: 0x7A80DA7B0
        public void set_stateFormat(){} // RVA: 0x7A813E420
        public void get_commonUsages(){} // RVA: 0x7A81052C0
        public void set_commonUsages(){} // RVA: 0x7A81052D0
        public void get_variants(){} // RVA: 0x7A8105330
        public void set_variants(){} // RVA: 0x7A80D8E80
        public void get_isNoisy(){} // RVA: 0x7A80FD690
        public void set_isNoisy(){} // RVA: 0x7A80FD6A0
        public void get_canRunInBackground(){} // RVA: 0x7AEBA6610
        public void set_canRunInBackground(){} // RVA: 0x7AEBA6660
        public void get_updateBeforeRender(){} // RVA: 0x7AEBA66B0
        public void set_updateBeforeRender(){} // RVA: 0x7AEBA6700
        public void get_isGenericTypeOfDevice(){} // RVA: 0x7A89A4480
        public void set_isGenericTypeOfDevice(){} // RVA: 0x7A9A77810
        public void get_displayName(){} // RVA: 0x7A8292C30
        public void set_displayName(){} // RVA: 0x7A8296DE0
        public void get_description(){} // RVA: 0x7A8154D80
        public void set_description(){} // RVA: 0x7A80FF440
        public void get_hideInUI(){} // RVA: 0x7A818F850
        public void set_hideInUI(){} // RVA: 0x7A818F860
        public void .ctor(){} // RVA: 0x7A80D7310
        public void <stateType>k__BackingField(){} // RVA: 0x7B3FB4428
    }

    public class InputDeviceBuilder : ValueType
    {
        // ── Methods ──
        public void Setup(){} // RVA: 0x7A7EAC3D0
        public void Finish(){} // RVA: 0x7A7EAC440
        public void Dispose(){} // RVA: 0x7A7EAC450
        public void Reset(){} // RVA: 0x7A7EAC460
        public void InstantiateLayout(){} // RVA: 0x7A7EAC4D0
        public void AddChildControls(){} // RVA: 0x7A7EAC520
        public void AddChildControl(){} // RVA: 0x7A7EAC560
        public void InsertChildControlOverride(){} // RVA: 0x7A7EAC660
        public void ChildControlOverridePath(){} // RVA: 0x7A7EAC670
        public void AddChildControlIfMissing(){} // RVA: 0x7A7EAC690
        public void InsertChildControl(){} // RVA: 0x7A7EAC6E0
        public void ApplyUseStateFrom(){} // RVA: 0x7AEBA9B40
        public void ShiftChildIndicesInHierarchyOneUp(){} // RVA: 0x7AEBA9DD0
        public void SetDisplayName(){} // RVA: 0x7A7EAC730
        public void AddParentDisplayNameRecursive(){} // RVA: 0x7AEBAA1D0
        public void AddProcessors(){} // RVA: 0x7AEBAA300
        public void SetFormat(){} // RVA: 0x7AEBAA620
        public void FindOrLoadLayout(){} // RVA: 0x7AEBAA6E0
        public void ComputeStateLayout(){} // RVA: 0x7AEBAA780
        public void FinalizeControlHierarchy(){} // RVA: 0x7A7EAC750
        public void FinalizeControlHierarchyRecursive(){} // RVA: 0x7A7EAC760
        public void InsertControlBitRangeNode(){} // RVA: 0x7A7EAC780
        public void GetBestMidPoint(){} // RVA: 0x7A7EAC7A0
        public void AddControlToNode(){} // RVA: 0x7A7EAC7D0
        public void AddChildren(){} // RVA: 0x7A7EAC7E0
        public void GetControlIndex(){} // RVA: 0x7A7EAC840
        public void get_instance(){} // RVA: 0x7AEBACA70
        public void Ref(){} // RVA: 0x7AEBACAB0
    }

    public class InputDeviceDescription : ValueType
    {
        // ── Methods ──
        public void get_interfaceName(){} // RVA: 0x7A765F710
        public void set_interfaceName(){} // RVA: 0x7A7637E60
        public void get_deviceClass(){} // RVA: 0x7A765F080
        public void set_deviceClass(){} // RVA: 0x7A765F010
        public void get_manufacturer(){} // RVA: 0x7A7664CF0
        public void set_manufacturer(){} // RVA: 0x7A7664E50
        public void get_product(){} // RVA: 0x7A767FF40
        public void set_product(){} // RVA: 0x7A767FF60
        public void get_serial(){} // RVA: 0x7A7677A70
        public void set_serial(){} // RVA: 0x7A7677A80
        public void get_version(){} // RVA: 0x7A7677A20
        public void set_version(){} // RVA: 0x7A76779C0
        public void get_capabilities(){} // RVA: 0x7A7690C10
        public void set_capabilities(){} // RVA: 0x7A7690C80
        public void get_empty(){} // RVA: 0x7A7EACD10
        public void ToString(){} // RVA: 0x7A7EACD20
        public void Equals(){} // RVA: 0x7A7EACD70
        public void GetHashCode(){} // RVA: 0x7A7EACD80
        public void op_Equality(){} // RVA: 0x7AEBAD400
        public void op_Inequality(){} // RVA: 0x7AEBAD440
        public void ToJson(){} // RVA: 0x7A7EACD90
        public void FromJson(){} // RVA: 0x7AEBAD760
        public void ComparePropertyToDeviceDescriptor(){} // RVA: 0x7AEBADBC0
    }

    public class InputDeviceFindControlLayoutDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AECCEC30
        public void Invoke(){} // RVA: 0x7A8234660
        public void BeginInvoke(){} // RVA: 0x7AECCED20
        public void EndInvoke(){} // RVA: 0x7A9CE2680
    }

    public class InputDeviceFindControlLayoutDelegate[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class InputDeviceMatcher : ValueType
    {
        // ── Methods ──
        public void get_empty(){} // RVA: 0x7A7673DE0
        public void get_patterns(){} // RVA: 0x7A7EACDC0
        public void WithInterface(){} // RVA: 0x7A7EACE70
        public void WithDeviceClass(){} // RVA: 0x7A7EACE80
        public void WithManufacturer(){} // RVA: 0x7A7EACE90
        public void WithManufacturerContains(){} // RVA: 0x7A7EACEA0
        public void WithProduct(){} // RVA: 0x7A7EACEB0
        public void WithVersion(){} // RVA: 0x7A7EACEC0
        public void WithCapability(){} // RVA: 0x7A77AFE50
        public void With(){} // RVA: 0x7A7EACED0
        public void MatchPercentage(){} // RVA: 0x7A7EACF00
        public void MatchSingleProperty(){} // RVA: 0x7AEBAEBF0
        public void MatchSinglePropertyContains(){} // RVA: 0x7AEBAEDD0
        public void GetNumPropertiesIn(){} // RVA: 0x7AEBAEFB0
        public void FromDeviceDescription(){} // RVA: 0x7AEBAF020
        public void ToString(){} // RVA: 0x7A7EACF40
        public void Equals(){} // RVA: 0x7A7EACF60
        public void op_Equality(){} // RVA: 0x7AEBAF6F0
        public void op_Inequality(){} // RVA: 0x7AEBAF750
        public void GetHashCode(){} // RVA: 0x7A78F67B0
        public void .cctor(){} // RVA: 0x7AEBAF7F0
    }

}