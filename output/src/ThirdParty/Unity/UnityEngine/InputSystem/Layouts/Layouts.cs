// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Layouts
// Classes: 8
// Methods: 208

namespace ThirdParty.Unity.UnityEngine.InputSystem.Layouts
{
    public class InputControlAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void get_layout(){} // RVA: 0xB465B0
        public void set_layout(){} // RVA: 0xBA9BA0
        public void get_variants(){} // RVA: 0xB700F0
        public void set_variants(){} // RVA: 0xB70100
        public void get_name(){} // RVA: 0xB70160
        public void set_name(){} // RVA: 0xB44DC0
        public void get_format(){} // RVA: 0xD33E60
        public void set_format(){} // RVA: 0xB708C0
        public void get_usage(){} // RVA: 0xD05CA0
        public void set_usage(){} // RVA: 0xD09D70
        public void get_usages(){} // RVA: 0xBC1B30
        public void set_usages(){} // RVA: 0xB6A8C0
        public void get_parameters(){} // RVA: 0xBBF8F0
        public void set_parameters(){} // RVA: 0xBBF900
        public void get_processors(){} // RVA: 0xBE58B0
        public void set_processors(){} // RVA: 0xCA4DF0
        public void get_alias(){} // RVA: 0xC0FFC0
        public void set_alias(){} // RVA: 0xC0FFD0
        public void get_aliases(){} // RVA: 0xBE2C60
        public void set_aliases(){} // RVA: 0xBE2C70
        public void get_useStateFrom(){} // RVA: 0xBBFF90
        public void set_useStateFrom(){} // RVA: 0xBBFFA0
        public void get_bit(){} // RVA: 0x19C6270
        public void set_bit(){} // RVA: 0xCE5450
        public void get_offset(){} // RVA: 0x21EA4F0
        public void set_offset(){} // RVA: 0x26432E0
        public void get_sizeInBits(){} // RVA: 0x23ADD10
        public void set_sizeInBits(){} // RVA: 0x23B2A80
        public void get_arraySize(){} // RVA: 0x23A4270
        public void set_arraySize(){} // RVA: 0x6CB6340
        public void get_displayName(){} // RVA: 0xCD48B0
        public void set_displayName(){} // RVA: 0xCD3600
        public void get_shortDisplayName(){} // RVA: 0xB813B0
        public void set_shortDisplayName(){} // RVA: 0xD5CBB0
        public void get_noisy(){} // RVA: 0x1C4D9A0
        public void set_noisy(){} // RVA: 0x1C4DB10
        public void get_synthetic(){} // RVA: 0x24BB4D0
        public void set_synthetic(){} // RVA: 0x24BB3A0
        public void get_dontReset(){} // RVA: 0x1D61360
        public void set_dontReset(){} // RVA: 0x25EA890
        public void get_defaultState(){} // RVA: 0x106A7D0
        public void set_defaultState(){} // RVA: 0xD5CC70
        public void get_minValue(){} // RVA: 0x106A050
        public void set_minValue(){} // RVA: 0xD5CCD0
        public void get_maxValue(){} // RVA: 0x12EB090
        public void set_maxValue(){} // RVA: 0x13B1040
        public void .ctor(){} // RVA: 0x793C4B0
    }

    public class InputControlLayout : Object
    {
        // ── Methods ──
        public void get_DefaultVariant(){} // RVA: 0x793C650
        public void get_name(){} // RVA: 0x22343B0
        public void get_displayName(){} // RVA: 0x793C6B0
        public void get_type(){} // RVA: 0xB700F0
        public void get_variants(){} // RVA: 0x19F92B0
        public void get_stateFormat(){} // RVA: 0x18A0130
        public void get_stateSizeInBytes(){} // RVA: 0x114DAD0
        public void get_baseLayouts(){} // RVA: 0x793C6E0
        public void get_appliedOverrides(){} // RVA: 0x793C740
        public void get_commonUsages(){} // RVA: 0x793C7A0
        public void get_controls(){} // RVA: 0x793C870
        public void get_updateBeforeRender(){} // RVA: 0x793C940
        public void get_isDeviceLayout(){} // RVA: 0x793C980
        public void get_isControlLayout(){} // RVA: 0x793CA30
        public void get_isOverride(){} // RVA: 0x793CAE0
        public void set_isOverride(){} // RVA: 0x793CAF0
        public void get_isGenericTypeOfDevice(){} // RVA: 0x793CB10
        public void set_isGenericTypeOfDevice(){} // RVA: 0x793CB20
        public void get_hideInUI(){} // RVA: 0x793CB40
        public void set_hideInUI(){} // RVA: 0x793CB50
        public void get_isNoisy(){} // RVA: 0x793CB70
        public void set_isNoisy(){} // RVA: 0x793CB80
        public void get_canRunInBackground(){} // RVA: 0x793CBA0
        public void set_canRunInBackground(){} // RVA: 0x793CC00
        public void get_Item(){} // RVA: 0x793CCA0
        public void FindControl(){} // RVA: 0x793CE60
        public void FindControlIncludingArrayElements(){} // RVA: 0x793D160
        public void GetValueType(){} // RVA: 0x793D790
        public void FromType(){} // RVA: 0x793D830
        public void ToJson(){} // RVA: 0x793DF60
        public void FromJson(){} // RVA: 0x793E010
        public void .ctor(){} // RVA: 0x793E1A0
        public void AddControlItems(){} // RVA: 0x793E290
        public void AddControlItemsFromFields(){} // RVA: 0x793E3D0
        public void AddControlItemsFromProperties(){} // RVA: 0x793E470
        public void AddControlItemsFromMembers(){} // RVA: 0x793E510
        public void AddControlItemsFromMember(){} // RVA: 0x793EB10
        public void CreateControlItemFromMember(){} // RVA: 0x793EED0
        public void InferLayoutFromValueType(){} // RVA: 0x7940090
        public void MergeLayout(){} // RVA: 0x79402D0
        public void CreateLookupTableForControls(){} // RVA: 0x7941D60
        public void VariantsMatch(){} // RVA: 0x7942250
        public void ParseHeaderFieldsFromJson(){} // RVA: 0x7942390
        public void get_cache(){} // RVA: 0x79426C0
        public void CacheRef(){} // RVA: 0x7942720
        public void .cctor(){} // RVA: 0x7942780
        public void <MergeLayout>b__77_0(){} // RVA: 0x7942850
    }

    public class InputControlLayoutAttribute : Attribute
    {
        // ── Methods ──
        public void get_stateType(){} // RVA: 0xB5DBF0
        public void set_stateType(){} // RVA: 0xB44D60
        public void get_stateFormat(){} // RVA: 0xB465B0
        public void set_stateFormat(){} // RVA: 0xBA9BA0
        public void get_commonUsages(){} // RVA: 0xB700F0
        public void set_commonUsages(){} // RVA: 0xB70100
        public void get_variants(){} // RVA: 0xB70160
        public void set_variants(){} // RVA: 0xB44DC0
        public void get_isNoisy(){} // RVA: 0xB68DF0
        public void set_isNoisy(){} // RVA: 0xB68E00
        public void get_canRunInBackground(){} // RVA: 0x7816170
        public void set_canRunInBackground(){} // RVA: 0x78161C0
        public void get_updateBeforeRender(){} // RVA: 0x7816210
        public void set_updateBeforeRender(){} // RVA: 0x7816260
        public void get_isGenericTypeOfDevice(){} // RVA: 0xD95ED0
        public void set_isGenericTypeOfDevice(){} // RVA: 0xD96A30
        public void get_displayName(){} // RVA: 0xD05CA0
        public void set_displayName(){} // RVA: 0xD09D70
        public void get_description(){} // RVA: 0xBC1B30
        public void set_description(){} // RVA: 0xB6A8C0
        public void get_hideInUI(){} // RVA: 0xBFDA40
        public void set_hideInUI(){} // RVA: 0xBFDA50
        public void .ctor(){} // RVA: 0xB43310
    }

    public class InputDeviceBuilder : ValueType
    {
        // ── Methods ──
        public void Setup(){} // RVA: 0x92CE90
        public void Finish(){} // RVA: 0x92CF00
        public void Dispose(){} // RVA: 0x92CF10
        public void Reset(){} // RVA: 0x92CF20
        public void InstantiateLayout(){} // RVA: 0x92D050
        public void AddChildControls(){} // RVA: 0x92D0A0
        public void AddChildControl(){} // RVA: 0x92D0E0
        public void InsertChildControlOverride(){} // RVA: 0x92D1E0
        public void ChildControlOverridePath(){} // RVA: 0x92D1F0
        public void AddChildControlIfMissing(){} // RVA: 0x92D210
        public void InsertChildControl(){} // RVA: 0x92D260
        public void ApplyUseStateFrom(){} // RVA: 0x7819500
        public void ShiftChildIndicesInHierarchyOneUp(){} // RVA: 0x7819760
        public void SetDisplayName(){} // RVA: 0x92D2B0
        public void AddParentDisplayNameRecursive(){} // RVA: 0x7819B70
        public void AddProcessors(){} // RVA: 0x7819CA0
        public void SetFormat(){} // RVA: 0x7819FB0
        public void FindOrLoadLayout(){} // RVA: 0x781A070
        public void ComputeStateLayout(){} // RVA: 0x781A110
        public void FinalizeControlHierarchy(){} // RVA: 0x92D2D0
        public void FinalizeControlHierarchyRecursive(){} // RVA: 0x92D2E0
        public void InsertControlBitRangeNode(){} // RVA: 0x92D300
        public void GetBestMidPoint(){} // RVA: 0x92D320
        public void AddControlToNode(){} // RVA: 0x92D350
        public void AddChildren(){} // RVA: 0x92D360
        public void GetControlIndex(){} // RVA: 0x92D3C0
        public void get_instance(){} // RVA: 0x781C3D0
        public void Ref(){} // RVA: 0x781C410
    }

    public class InputDeviceDescription : ValueType
    {
        // ── Methods ──
        public void get_interfaceName(){} // RVA: 0x77900
        public void set_interfaceName(){} // RVA: 0x47F10
        public void get_deviceClass(){} // RVA: 0x77ED0
        public void set_deviceClass(){} // RVA: 0x77E70
        public void get_manufacturer(){} // RVA: 0x7E450
        public void set_manufacturer(){} // RVA: 0x7E3E0
        public void get_product(){} // RVA: 0x931A0
        public void set_product(){} // RVA: 0x93120
        public void get_serial(){} // RVA: 0x8C630
        public void set_serial(){} // RVA: 0x8C670
        public void get_version(){} // RVA: 0x8C700
        public void set_version(){} // RVA: 0x8C5A0
        public void get_capabilities(){} // RVA: 0xA6BB0
        public void set_capabilities(){} // RVA: 0xA6B00
        public void get_empty(){} // RVA: 0x92D890
        public void ToString(){} // RVA: 0x92D8A0
        public void Equals(){} // RVA: 0x92D8F0
        public void GetHashCode(){} // RVA: 0x92D900
        public void op_Equality(){} // RVA: 0x781CD60
        public void op_Inequality(){} // RVA: 0x781CDA0
        public void ToJson(){} // RVA: 0x92D910
        public void FromJson(){} // RVA: 0x781D0C0
        public void ComparePropertyToDeviceDescriptor(){} // RVA: 0x781D4F0
    }

    public class InputDeviceFindControlLayoutDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x793C4C0
        public void Invoke(){} // RVA: 0xCA8D60
        public void BeginInvoke(){} // RVA: 0x793C5B0
        public void EndInvoke(){} // RVA: 0x275FED0
    }

    public class InputDeviceFindControlLayoutDelegate[] : Array
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

    public class InputDeviceMatcher : ValueType
    {
        // ── Methods ──
        public void WithCapability(){} // RVA: 0x1F9C20
        public void get_empty(){} // RVA: 0x88E70
        public void get_patterns(){} // RVA: 0x92D9E0
        public void WithInterface(){} // RVA: 0x92DA90
        public void WithDeviceClass(){} // RVA: 0x92DAA0
        public void WithManufacturer(){} // RVA: 0x92DAB0
        public void WithManufacturerContains(){} // RVA: 0x92DAC0
        public void WithProduct(){} // RVA: 0x92DAD0
        public void WithVersion(){} // RVA: 0x92DAE0
        public void With(){} // RVA: 0x92DAF0
        public void MatchPercentage(){} // RVA: 0x92DB20
        public void MatchSingleProperty(){} // RVA: 0x781E4E0
        public void MatchSinglePropertyContains(){} // RVA: 0x781E6B0
        public void GetNumPropertiesIn(){} // RVA: 0x781E870
        public void FromDeviceDescription(){} // RVA: 0x781E8E0
        public void ToString(){} // RVA: 0x92DB60
        public void Equals(){} // RVA: 0x92DB80
        public void op_Equality(){} // RVA: 0x781EFA0
        public void op_Inequality(){} // RVA: 0x781F000
        public void GetHashCode(){} // RVA: 0x33EAA0
        public void .cctor(){} // RVA: 0x781F0A0
    }

}