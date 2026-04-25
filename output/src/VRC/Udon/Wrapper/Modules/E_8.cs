// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Wrapper.Modules
// Classes: 95
// Methods: 3199

namespace VRC.Udon.Wrapper.Modules
{
    public class ExternVRCSDK3DataVRCJson : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA28DD80
        public void .ctor(){} // RVA: 0x7FFACA28DDC0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA28E190
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA28E2C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA28E3D0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA28E520
        public void __GetType__SystemType(){} // RVA: 0x7FFACA28E620
        public void __ToString__SystemString(){} // RVA: 0x7FFACA28E710
        public void __TryDeserializeFromJson__SystemString_VRCSDK3DataDataTokenRef__SystemBoolean(){} // RVA: 0x7FFACA28E800
        public void __TrySerializeToJson__VRCSDK3DataDataToken_VRCSDK3DataJsonExportType_VRCSDK3DataDataTokenRef__SystemBoolean(){} // RVA: 0x7FFACA28E930
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA28EAD0
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCAimConstraint : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA28F120
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA28F160
        public void .ctor(){} // RVA: 0x7FFACA28F210
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA28F5E0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA28F710
        public void __ActivateConstraint__SystemVoid(){} // RVA: 0x7FFACA28F820
        public void __ApplyConfigurationChanges__SystemVoid(){} // RVA: 0x7FFACA28F8E0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA28F990
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA28FA80
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA28FD30
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA28FE90
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA28FFB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA2900A0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA290320
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA290410
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA2906C0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA290820
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA290940
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA290A30
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA290CB0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA290E20
        public void __GetComponent__T(){} // RVA: 0x7FFACA290F40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA291020
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA291270
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA291360
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA291690
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA291780
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA291AC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA291BB0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA291EC0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA292030
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA292160
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA292250
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA292540
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA292630
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA292970
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA292A60
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA292D70
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA292EE0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA293020
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA293110
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA293400
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA2934F0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA2937E0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA293930
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA293A60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA293B50
        public void __ZeroConstraint__SystemVoid(){} // RVA: 0x7FFACA293E00
        public void __get_AimAxis__UnityEngineVector3(){} // RVA: 0x7FFACA293EB0
        public void __set_AimAxis__UnityEngineVector3(){} // RVA: 0x7FFACA293FA0
        public void __get_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFACA294090
        public void __set_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFACA294170
        public void __get_GlobalWeight__SystemSingle(){} // RVA: 0x7FFACA294250
        public void __set_GlobalWeight__SystemSingle(){} // RVA: 0x7FFACA294330
        public void __get_IsActive__SystemBoolean(){} // RVA: 0x7FFACA294410
        public void __set_IsActive__SystemBoolean(){} // RVA: 0x7FFACA2944F0
        public void __get_Locked__SystemBoolean(){} // RVA: 0x7FFACA2945D0
        public void __set_Locked__SystemBoolean(){} // RVA: 0x7FFACA2946B0
        public void __get_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFACA294790
        public void __set_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFACA294870
        public void __get_RotationAtRest__UnityEngineVector3(){} // RVA: 0x7FFACA294950
        public void __set_RotationAtRest__UnityEngineVector3(){} // RVA: 0x7FFACA294A40
        public void __get_RotationOffset__UnityEngineVector3(){} // RVA: 0x7FFACA294B30
        public void __set_RotationOffset__UnityEngineVector3(){} // RVA: 0x7FFACA294C20
        public void __get_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFACA294D10
        public void __set_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFACA294DF0
        public void __get_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFACA294ED0
        public void __set_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFACA295040
        public void __get_TargetTransform__UnityEngineTransform(){} // RVA: 0x7FFACA295270
        public void __get_UpAxis__UnityEngineVector3(){} // RVA: 0x7FFACA295370
        public void __set_UpAxis__UnityEngineVector3(){} // RVA: 0x7FFACA295460
        public void __get_WorldUpTransform__UnityEngineTransform(){} // RVA: 0x7FFACA295550
        public void __set_WorldUpTransform__UnityEngineTransform(){} // RVA: 0x7FFACA295650
        public void __get_WorldUpVector__UnityEngineVector3(){} // RVA: 0x7FFACA295780
        public void __set_WorldUpVector__UnityEngineVector3(){} // RVA: 0x7FFACA295870
        public void __get_WorldUp__VRCDynamicsVRCConstraintBaseWorldUpType(){} // RVA: 0x7FFACA295960
        public void __set_WorldUp__VRCDynamicsVRCConstraintBaseWorldUpType(){} // RVA: 0x7FFACA295A40
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA295B20
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA295C40
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA295D80
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA295EC0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA2960C0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA296240
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA296440
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA296570
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCAimConstraintArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA299810
        public void .ctor(){} // RVA: 0x7FFACA299850
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA299C20
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA299D50
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA299E60
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA299F40
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA29A020
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA29A0F0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA29A240
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA29A2E0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA29A3E0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA29A500
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA29A610
        public void __GetType__SystemType(){} // RVA: 0x7FFACA29A730
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA29A820
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA29A900
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA29AA20
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA29ABB0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA29AD00
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA29AE30
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA29AF50
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA29B0C0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA29B200
        public void __Get__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCAimConstraint(){} // RVA: 0x7FFACA29B320
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA29B460
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA29B4D0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA29B5F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA29B770
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA29B8D0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA29BA00
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA29BB20
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA29BC80
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA29BDD0
        public void __Set__SystemInt32_VRCSDK3DynamicsConstraintComponentsVRCAimConstraint__SystemVoid(){} // RVA: 0x7FFACA29BEF0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA29C080
        public void __ctor__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCAimConstraintArray(){} // RVA: 0x7FFACA29C170
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA29C260
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA29C300
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA29C3A0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA29C440
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA29C4E0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA29C580
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA29C620
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA29C700
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCLookAtConstraint : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA29E620
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA29E660
        public void .ctor(){} // RVA: 0x7FFACA29E710
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA29EAE0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA29EC10
        public void __ActivateConstraint__SystemVoid(){} // RVA: 0x7FFACA29ED20
        public void __ApplyConfigurationChanges__SystemVoid(){} // RVA: 0x7FFACA29EDE0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA29EE90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA29EF80
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA29F230
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA29F390
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA29F4B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA29F5A0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA29F820
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA29F910
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA29FBC0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA29FD20
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA29FE40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA29FF30
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA2A01B0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA2A0320
        public void __GetComponent__T(){} // RVA: 0x7FFACA2A0440
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA2A0520
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA2A0770
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA2A0860
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA2A0B90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA2A0C80
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA2A0FC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA2A10B0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA2A13C0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA2A1530
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA2A1660
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA2A1750
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA2A1A40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA2A1B30
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA2A1E70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA2A1F60
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA2A2270
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA2A23E0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA2A2520
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA2A2610
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA2A2900
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA2A29F0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA2A2CE0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA2A2E30
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA2A2F60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA2A3050
        public void __ZeroConstraint__SystemVoid(){} // RVA: 0x7FFACA2A3300
        public void __get_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFACA2A33B0
        public void __set_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFACA2A3490
        public void __get_GlobalWeight__SystemSingle(){} // RVA: 0x7FFACA2A3570
        public void __set_GlobalWeight__SystemSingle(){} // RVA: 0x7FFACA2A3650
        public void __get_IsActive__SystemBoolean(){} // RVA: 0x7FFACA2A3730
        public void __set_IsActive__SystemBoolean(){} // RVA: 0x7FFACA2A3810
        public void __get_Locked__SystemBoolean(){} // RVA: 0x7FFACA2A38F0
        public void __set_Locked__SystemBoolean(){} // RVA: 0x7FFACA2A39D0
        public void __get_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFACA2A3AB0
        public void __set_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFACA2A3B90
        public void __get_Roll__SystemSingle(){} // RVA: 0x7FFACA2A3C70
        public void __set_Roll__SystemSingle(){} // RVA: 0x7FFACA2A3D50
        public void __get_RotationAtRest__UnityEngineVector3(){} // RVA: 0x7FFACA2A3E30
        public void __set_RotationAtRest__UnityEngineVector3(){} // RVA: 0x7FFACA2A3F20
        public void __get_RotationOffset__UnityEngineVector3(){} // RVA: 0x7FFACA2A4010
        public void __set_RotationOffset__UnityEngineVector3(){} // RVA: 0x7FFACA2A4100
        public void __get_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFACA2A41F0
        public void __set_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFACA2A42D0
        public void __get_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFACA2A43B0
        public void __set_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFACA2A4520
        public void __get_TargetTransform__UnityEngineTransform(){} // RVA: 0x7FFACA2A4750
        public void __get_UseUpTransform__SystemBoolean(){} // RVA: 0x7FFACA2A4850
        public void __set_UseUpTransform__SystemBoolean(){} // RVA: 0x7FFACA2A4930
        public void __get_WorldUpTransform__UnityEngineTransform(){} // RVA: 0x7FFACA2A4A10
        public void __set_WorldUpTransform__UnityEngineTransform(){} // RVA: 0x7FFACA2A4B10
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA2A4C40
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA2A4D60
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA2A4EA0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA2A4FE0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA2A51E0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA2A5360
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA2A5560
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA2A5690
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCLookAtConstraintArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA2A8620
        public void .ctor(){} // RVA: 0x7FFACA2A8660
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA2A8A30
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA2A8B60
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA2A8C70
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA2A8D50
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA2A8E30
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA2A8F00
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA2A9050
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA2A90F0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA2A91F0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA2A9310
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA2A9420
        public void __GetType__SystemType(){} // RVA: 0x7FFACA2A9540
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA2A9630
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA2A9710
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA2A9830
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA2A99C0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA2A9B10
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA2A9C40
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA2A9D60
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA2A9ED0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA2AA010
        public void __Get__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCLookAtConstraint(){} // RVA: 0x7FFACA2AA130
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA2AA270
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA2AA2E0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA2AA400
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA2AA580
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA2AA6E0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA2AA810
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA2AA930
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA2AAA90
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA2AABE0
        public void __Set__SystemInt32_VRCSDK3DynamicsConstraintComponentsVRCLookAtConstraint__SystemVoid(){} // RVA: 0x7FFACA2AAD00
        public void __ToString__SystemString(){} // RVA: 0x7FFACA2AAE90
        public void __ctor__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCLookAtConstraintArray(){} // RVA: 0x7FFACA2AAF80
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA2AB070
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA2AB110
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA2AB1B0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA2AB250
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA2AB2F0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA2AB390
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA2AB430
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA2AB510
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCParentConstraint : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA2AD430
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA2AD470
        public void .ctor(){} // RVA: 0x7FFACA2AD520
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA2AD8F0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA2ADA20
        public void __ActivateConstraint__SystemVoid(){} // RVA: 0x7FFACA2ADB30
        public void __ApplyConfigurationChanges__SystemVoid(){} // RVA: 0x7FFACA2ADBF0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA2ADCA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA2ADD90
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA2AE040
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA2AE1A0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA2AE2C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA2AE3B0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA2AE630
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA2AE720
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA2AE9D0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA2AEB30
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA2AEC50
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA2AED40
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA2AEFC0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA2AF130
        public void __GetComponent__T(){} // RVA: 0x7FFACA2AF250
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA2AF330
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA2AF580
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA2AF670
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA2AF9A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA2AFA90
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA2AFDD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA2AFEC0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA2B01D0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA2B0340
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA2B0470
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA2B0560
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA2B0850
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA2B0940
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA2B0C80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA2B0D70
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA2B1080
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA2B11F0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA2B1330
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA2B1420
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA2B1710
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA2B1800
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA2B1AF0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA2B1C40
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA2B1D70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA2B1E60
        public void __ZeroConstraint__SystemVoid(){} // RVA: 0x7FFACA2B2110
        public void __get_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFACA2B21C0
        public void __set_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFACA2B22A0
        public void __get_GlobalWeight__SystemSingle(){} // RVA: 0x7FFACA2B2380
        public void __set_GlobalWeight__SystemSingle(){} // RVA: 0x7FFACA2B2460
        public void __get_IsActive__SystemBoolean(){} // RVA: 0x7FFACA2B2540
        public void __set_IsActive__SystemBoolean(){} // RVA: 0x7FFACA2B2620
        public void __get_Locked__SystemBoolean(){} // RVA: 0x7FFACA2B2700
        public void __set_Locked__SystemBoolean(){} // RVA: 0x7FFACA2B27E0
        public void __get_PositionAtRest__UnityEngineVector3(){} // RVA: 0x7FFACA2B28C0
        public void __set_PositionAtRest__UnityEngineVector3(){} // RVA: 0x7FFACA2B29B0
        public void __get_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFACA2B2AA0
        public void __set_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFACA2B2B80
        public void __get_RotationAtRest__UnityEngineVector3(){} // RVA: 0x7FFACA2B2C60
        public void __set_RotationAtRest__UnityEngineVector3(){} // RVA: 0x7FFACA2B2D50
        public void __get_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFACA2B2E40
        public void __set_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFACA2B2F20
        public void __get_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFACA2B3000
        public void __set_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFACA2B3170
        public void __get_TargetTransform__UnityEngineTransform(){} // RVA: 0x7FFACA2B33A0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA2B34A0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA2B35C0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA2B3700
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA2B3840
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA2B3A40
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA2B3BC0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA2B3DC0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA2B3EF0
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCParentConstraintArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA2B6A10
        public void .ctor(){} // RVA: 0x7FFACA2B6A50
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA2B6E20
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA2B6F50
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA2B7060
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA2B7140
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA2B7220
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA2B72F0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA2B7440
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA2B74E0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA2B75E0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA2B7700
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA2B7810
        public void __GetType__SystemType(){} // RVA: 0x7FFACA2B7930
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA2B7A20
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA2B7B00
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA2B7C20
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA2B7DB0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA2B7F00
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA2B8030
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA2B8150
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA2B82C0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA2B8400
        public void __Get__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCParentConstraint(){} // RVA: 0x7FFACA2B8520
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA2B8660
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA2B86D0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA2B87F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA2B8970
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA2B8AD0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA2B8C00
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA2B8D20
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA2B8E80
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA2B8FD0
        public void __Set__SystemInt32_VRCSDK3DynamicsConstraintComponentsVRCParentConstraint__SystemVoid(){} // RVA: 0x7FFACA2B90F0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA2B9280
        public void __ctor__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCParentConstraintArray(){} // RVA: 0x7FFACA2B9370
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA2B9460
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA2B9500
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA2B95A0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA2B9640
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA2B96E0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA2B9780
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA2B9820
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA2B9900
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCPositionConstraint : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA2BB820
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA2BB860
        public void .ctor(){} // RVA: 0x7FFACA2BB910
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA2BBCE0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA2BBE10
        public void __ActivateConstraint__SystemVoid(){} // RVA: 0x7FFACA2BBF20
        public void __ApplyConfigurationChanges__SystemVoid(){} // RVA: 0x7FFACA2BBFE0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA2BC090
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA2BC180
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA2BC430
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA2BC590
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA2BC6B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA2BC7A0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA2BCA20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA2BCB10
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA2BCDC0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA2BCF20
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA2BD040
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA2BD130
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA2BD3B0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA2BD520
        public void __GetComponent__T(){} // RVA: 0x7FFACA2BD640
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA2BD720
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA2BD970
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA2BDA60
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA2BDD90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA2BDE80
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA2BE1C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA2BE2B0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA2BE5C0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA2BE730
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA2BE860
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA2BE950
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA2BEC40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA2BED30
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA2BF070
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA2BF160
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA2BF470
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA2BF5E0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA2BF720
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA2BF810
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA2BFB00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA2BFBF0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA2BFEE0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA2C0030
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA2C0160
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA2C0250
        public void __ZeroConstraint__SystemVoid(){} // RVA: 0x7FFACA2C0500
        public void __get_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFACA2C05B0
        public void __set_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFACA2C0690
        public void __get_GlobalWeight__SystemSingle(){} // RVA: 0x7FFACA2C0770
        public void __set_GlobalWeight__SystemSingle(){} // RVA: 0x7FFACA2C0850
        public void __get_IsActive__SystemBoolean(){} // RVA: 0x7FFACA2C0930
        public void __set_IsActive__SystemBoolean(){} // RVA: 0x7FFACA2C0A10
        public void __get_Locked__SystemBoolean(){} // RVA: 0x7FFACA2C0AF0
        public void __set_Locked__SystemBoolean(){} // RVA: 0x7FFACA2C0BD0
        public void __get_PositionAtRest__UnityEngineVector3(){} // RVA: 0x7FFACA2C0CB0
        public void __set_PositionAtRest__UnityEngineVector3(){} // RVA: 0x7FFACA2C0DA0
        public void __get_PositionOffset__UnityEngineVector3(){} // RVA: 0x7FFACA2C0E90
        public void __set_PositionOffset__UnityEngineVector3(){} // RVA: 0x7FFACA2C0F80
        public void __get_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFACA2C1070
        public void __set_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFACA2C1150
        public void __get_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFACA2C1230
        public void __set_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFACA2C1310
        public void __get_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFACA2C13F0
        public void __set_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFACA2C1560
        public void __get_TargetTransform__UnityEngineTransform(){} // RVA: 0x7FFACA2C1790
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA2C1890
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA2C19B0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA2C1AF0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA2C1C30
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA2C1E30
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA2C1FB0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA2C21B0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA2C22E0
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCPositionConstraintArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0877A0
        public void .ctor(){} // RVA: 0x7FFACA0877E0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA087BB0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA087CE0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA087DF0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA087ED0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA087FB0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA088080
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA0881D0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA088270
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA088370
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA088490
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0885A0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA0886C0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0887B0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA088890
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA0889B0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA088B40
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA088C90
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA088DC0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA088EE0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA089050
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA089190
        public void __Get__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCPositionConstraint(){} // RVA: 0x7FFACA0892B0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA0893F0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA089460
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA089580
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA089700
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA089860
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA089990
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA089AB0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA089C10
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA089D60
        public void __Set__SystemInt32_VRCSDK3DynamicsConstraintComponentsVRCPositionConstraint__SystemVoid(){} // RVA: 0x7FFACA089E80
        public void __ToString__SystemString(){} // RVA: 0x7FFACA08A010
        public void __ctor__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCPositionConstraintArray(){} // RVA: 0x7FFACA08A100
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA08A1F0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA08A290
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA08A330
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA08A3D0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA08A470
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA08A510
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA08A5B0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA08A690
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCRotationConstraint : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA08C5B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA08C5F0
        public void .ctor(){} // RVA: 0x7FFACA08C6A0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA08CA70
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA08CBA0
        public void __ActivateConstraint__SystemVoid(){} // RVA: 0x7FFACA08CCB0
        public void __ApplyConfigurationChanges__SystemVoid(){} // RVA: 0x7FFACA08CD70
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA08CE20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA08CF10
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA08D1C0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA08D320
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA08D440
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA08D530
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA08D7B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA08D8A0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA08DB50
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA08DCB0
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA08DDD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA08DEC0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA08E140
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA08E2B0
        public void __GetComponent__T(){} // RVA: 0x7FFACA08E3D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA08E4B0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA08E700
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA08E7F0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA08EB20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA08EC10
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA08EF50
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA08F040
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA08F350
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA08F4C0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA08F5F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA08F6E0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA08F9D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA08FAC0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA08FE00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA08FEF0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA090200
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA090370
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA0904B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA0905A0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA090890
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA090980
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA090C70
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA090DC0
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA090EF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA090FE0
        public void __ZeroConstraint__SystemVoid(){} // RVA: 0x7FFACA091290
        public void __get_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFACA091340
        public void __set_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFACA091420
        public void __get_GlobalWeight__SystemSingle(){} // RVA: 0x7FFACA091500
        public void __set_GlobalWeight__SystemSingle(){} // RVA: 0x7FFACA0915E0
        public void __get_IsActive__SystemBoolean(){} // RVA: 0x7FFACA0916C0
        public void __set_IsActive__SystemBoolean(){} // RVA: 0x7FFACA0917A0
        public void __get_Locked__SystemBoolean(){} // RVA: 0x7FFACA091880
        public void __set_Locked__SystemBoolean(){} // RVA: 0x7FFACA091960
        public void __get_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFACA091A40
        public void __set_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFACA091B20
        public void __get_RotationAtRest__UnityEngineVector3(){} // RVA: 0x7FFACA091C00
        public void __set_RotationAtRest__UnityEngineVector3(){} // RVA: 0x7FFACA091CF0
        public void __get_RotationOffset__UnityEngineVector3(){} // RVA: 0x7FFACA091DE0
        public void __set_RotationOffset__UnityEngineVector3(){} // RVA: 0x7FFACA091ED0
        public void __get_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFACA091FC0
        public void __set_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFACA0920A0
        public void __get_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFACA092180
        public void __set_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFACA0922F0
        public void __get_TargetTransform__UnityEngineTransform(){} // RVA: 0x7FFACA092520
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA092620
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA092740
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA092880
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA0929C0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA092BC0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA092D40
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA092F40
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA093070
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCRotationConstraintArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA095B90
        public void .ctor(){} // RVA: 0x7FFACA095BD0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA095FA0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0960D0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA0961E0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0962C0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0963A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA096470
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA0965C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA096660
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA096760
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA096880
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA096990
        public void __GetType__SystemType(){} // RVA: 0x7FFACA096AB0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA096BA0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA096C80
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA096DA0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA096F30
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA097080
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA0971B0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA0972D0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA097440
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA097580
        public void __Get__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCRotationConstraint(){} // RVA: 0x7FFACA0976A0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA0977E0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA097850
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA097970
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA097AF0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA097C50
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA097D80
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA097EA0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA098000
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA098150
        public void __Set__SystemInt32_VRCSDK3DynamicsConstraintComponentsVRCRotationConstraint__SystemVoid(){} // RVA: 0x7FFACA098270
        public void __ToString__SystemString(){} // RVA: 0x7FFACA098400
        public void __ctor__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCRotationConstraintArray(){} // RVA: 0x7FFACA0984F0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA0985E0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA098680
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA098720
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA0987C0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA098860
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA098900
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA0989A0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA098A80
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCScaleConstraint : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA09A9A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA09A9E0
        public void .ctor(){} // RVA: 0x7FFACA09AA90
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA09AE60
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA09AF90
        public void __ActivateConstraint__SystemVoid(){} // RVA: 0x7FFACA09B0A0
        public void __ApplyConfigurationChanges__SystemVoid(){} // RVA: 0x7FFACA09B160
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA09B210
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA09B300
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA09B5B0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA09B710
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA09B830
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA09B920
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA09BBA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA09BC90
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA09BF40
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA09C0A0
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA09C1C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA09C2B0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA09C530
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA09C6A0
        public void __GetComponent__T(){} // RVA: 0x7FFACA09C7C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA09C8A0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA09CAF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA09CBE0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA09CF10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA09D000
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA09D340
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA09D430
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA09D740
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA09D8B0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA09D9E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA09DAD0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA09DDC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA09DEB0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA09E1F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA09E2E0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA09E5F0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA09E760
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA09E8A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA09E990
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA09EC80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA09ED70
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA09F060
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA09F1B0
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA09F2E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA09F3D0
        public void __ZeroConstraint__SystemVoid(){} // RVA: 0x7FFACA09F680
        public void __get_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFACA09F730
        public void __set_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFACA09F810
        public void __get_GlobalWeight__SystemSingle(){} // RVA: 0x7FFACA09F8F0
        public void __set_GlobalWeight__SystemSingle(){} // RVA: 0x7FFACA09F9D0
        public void __get_IsActive__SystemBoolean(){} // RVA: 0x7FFACA09FAB0
        public void __set_IsActive__SystemBoolean(){} // RVA: 0x7FFACA09FB90
        public void __get_Locked__SystemBoolean(){} // RVA: 0x7FFACA09FC70
        public void __set_Locked__SystemBoolean(){} // RVA: 0x7FFACA09FD50
        public void __get_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFACA09FE30
        public void __set_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFACA09FF10
        public void __get_ScaleAtRest__UnityEngineVector3(){} // RVA: 0x7FFACA09FFF0
        public void __set_ScaleAtRest__UnityEngineVector3(){} // RVA: 0x7FFACA0A00E0
        public void __get_ScaleOffset__UnityEngineVector3(){} // RVA: 0x7FFACA0A01D0
        public void __set_ScaleOffset__UnityEngineVector3(){} // RVA: 0x7FFACA0A02C0
        public void __get_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFACA0A03B0
        public void __set_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFACA0A0490
        public void __get_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFACA0A0570
        public void __set_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFACA0A06E0
        public void __get_TargetTransform__UnityEngineTransform(){} // RVA: 0x7FFACA0A0910
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA0A0A10
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA0A0B30
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA0A0C70
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA0A0DB0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA0A0FB0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA0A1130
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA0A1330
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA0A1460
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCScaleConstraintArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0A3F80
        public void .ctor(){} // RVA: 0x7FFACA0A3FC0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA0A4390
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0A44C0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA0A45D0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0A46B0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0A4790
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA0A4860
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA0A49B0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA0A4A50
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0A4B50
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA0A4C70
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0A4D80
        public void __GetType__SystemType(){} // RVA: 0x7FFACA0A4EA0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0A4F90
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA0A5070
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA0A5190
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA0A5320
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA0A5470
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA0A55A0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA0A56C0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA0A5830
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA0A5970
        public void __Get__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCScaleConstraint(){} // RVA: 0x7FFACA0A5A90
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA0A5BD0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA0A5C40
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0A5D60
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0A5EE0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0A6040
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA0A6170
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0A6290
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0A63F0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0A6540
        public void __Set__SystemInt32_VRCSDK3DynamicsConstraintComponentsVRCScaleConstraint__SystemVoid(){} // RVA: 0x7FFACA0A6660
        public void __ToString__SystemString(){} // RVA: 0x7FFACA0A67F0
        public void __ctor__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCScaleConstraintArray(){} // RVA: 0x7FFACA0A68E0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA0A69D0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA0A6A70
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA0A6B10
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA0A6BB0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA0A6C50
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA0A6CF0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA0A6D90
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA0A6E70
    }

    public class ExternVRCSDK3DynamicsContactComponentsVRCContactReceiver : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0A8D90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA0A8DD0
        public void .ctor(){} // RVA: 0x7FFACA0A8E80
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA0A9250
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0A9380
        public void __ApplyConfigurationChanges__SystemVoid(){} // RVA: 0x7FFACA0A9490
        public void __CalculateProximity__VRCDynamicsContactSenderProxy__SystemSingle(){} // RVA: 0x7FFACA0A9540
        public void __CalculateProximity__VRCSDK3DynamicsContactComponentsVRCContactSender__SystemSingle(){} // RVA: 0x7FFACA0A96F0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA0A9920
        public void __Equals__VRCDynamicsContactReceiverProxy__SystemBoolean(){} // RVA: 0x7FFACA0A9A80
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA0A9BE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA0A9CD0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA0A9F80
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA0AA0E0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA0AA200
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA0AA2F0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA0AA570
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA0AA660
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA0AA910
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA0AAA70
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA0AAB90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA0AAC80
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA0AAF00
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA0AB070
        public void __GetComponent__T(){} // RVA: 0x7FFACA0AB190
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA0AB270
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA0AB4C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA0AB5B0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA0AB8E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA0AB9D0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA0ABD10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA0ABE00
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA0AC110
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA0AC280
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA0AC3B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA0AC4A0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA0AC790
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA0AC880
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA0ACBC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA0ACCB0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA0ACFC0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA0AD130
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA0AD270
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA0AD360
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA0AD650
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA0AD740
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA0ADA30
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA0ADB80
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA0ADCB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA0ADDA0
        public void __UpdateCollisionTags__SystemStringArray__SystemVoid(){} // RVA: 0x7FFACA0AE050
        public void __UpdateContentTypes__VRCDynamicsDynamicsUsageFlags__SystemVoid(){} // RVA: 0x7FFACA0AE130
        public void __get_Usage__VRCDynamicsDynamicsUsage(){} // RVA: 0x7FFACA0AE210
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA0AE2F0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA0AE410
        public void __get_height__SystemSingle(){} // RVA: 0x7FFACA0AE550
        public void __set_height__SystemSingle(){} // RVA: 0x7FFACA0AE630
        public void __get_position__UnityEngineVector3(){} // RVA: 0x7FFACA0AE710
        public void __set_position__UnityEngineVector3(){} // RVA: 0x7FFACA0AE7F0
        public void __get_radius__SystemSingle(){} // RVA: 0x7FFACA0AE8D0
        public void __set_radius__SystemSingle(){} // RVA: 0x7FFACA0AE9B0
        public void __get_rotation__UnityEngineQuaternion(){} // RVA: 0x7FFACA0AEA90
        public void __set_rotation__UnityEngineQuaternion(){} // RVA: 0x7FFACA0AEB70
        public void __get_shapeType__VRCDynamicsContactBaseShapeType(){} // RVA: 0x7FFACA0AEC50
        public void __set_shapeType__VRCDynamicsContactBaseShapeType(){} // RVA: 0x7FFACA0AED30
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA0AEE10
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA0AEF50
        public void __op_Equality__VRCDynamicsContactReceiverProxy_VRCSDK3DynamicsContactComponentsVRCContactReceiver__SystemBoolean(){} // RVA: 0x7FFACA0AF150
        public void __op_Equality__VRCSDK3DynamicsContactComponentsVRCContactReceiver_VRCDynamicsContactReceiverProxy__SystemBoolean(){} // RVA: 0x7FFACA0AF270
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA0AF380
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA0AF500
        public void __op_Inequality__VRCDynamicsContactReceiverProxy_VRCSDK3DynamicsContactComponentsVRCContactReceiver__SystemBoolean(){} // RVA: 0x7FFACA0AF700
        public void __op_Inequality__VRCSDK3DynamicsContactComponentsVRCContactReceiver_VRCDynamicsContactReceiverProxy__SystemBoolean(){} // RVA: 0x7FFACA0AF820
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA0AF930
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA0AFA60
    }

    public class ExternVRCSDK3DynamicsContactComponentsVRCContactReceiverArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0B2580
        public void .ctor(){} // RVA: 0x7FFACA0B25C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA0B2990
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0B2AC0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA0B2BD0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0B2CB0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0B2D90
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA0B2E60
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA0B2FB0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA0B3050
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0B3150
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA0B3270
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0B3380
        public void __GetType__SystemType(){} // RVA: 0x7FFACA0B34A0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0B3590
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA0B3670
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA0B3790
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA0B3920
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA0B3A70
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA0B3BA0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA0B3CC0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA0B3E30
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA0B3F70
        public void __Get__SystemInt32__VRCSDK3DynamicsContactComponentsVRCContactReceiver(){} // RVA: 0x7FFACA0B4090
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA0B41D0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA0B4240
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0B4360
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0B44E0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0B4640
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA0B4770
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0B4890
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0B49F0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0B4B40
        public void __Set__SystemInt32_VRCSDK3DynamicsContactComponentsVRCContactReceiver__SystemVoid(){} // RVA: 0x7FFACA0B4C60
        public void __ToString__SystemString(){} // RVA: 0x7FFACA0B4E20
        public void __ctor__SystemInt32__VRCSDK3DynamicsContactComponentsVRCContactReceiverArray(){} // RVA: 0x7FFACA0B4F10
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA0B5000
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA0B50A0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA0B5140
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA0B51E0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA0B5280
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA0B5320
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA0B53C0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA0B54A0
    }

    public class ExternVRCSDK3DynamicsContactComponentsVRCContactSender : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0B73C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA0B7400
        public void .ctor(){} // RVA: 0x7FFACA0B74B0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA0B7880
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0B79B0
        public void __ApplyConfigurationChanges__SystemVoid(){} // RVA: 0x7FFACA0B7AC0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA0B7B70
        public void __Equals__VRCDynamicsContactSenderProxy__SystemBoolean(){} // RVA: 0x7FFACA0B7CD0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA0B7E30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA0B7F20
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA0B81D0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA0B8330
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA0B8450
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA0B8540
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA0B87C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA0B88B0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA0B8B60
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA0B8CC0
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA0B8DE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA0B8ED0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA0B9150
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA0B92C0
        public void __GetComponent__T(){} // RVA: 0x7FFACA0B93E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA0B94C0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA0B9710
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA0B9800
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA0B9B30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA0B9C20
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA0B9F60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA0BA050
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA0BA360
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA0BA4D0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA0BA600
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA0BA6F0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA0BA9E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA0BAAD0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA0BAE10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA0BAF00
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA0BB210
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA0BB380
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA0BB4C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA0BB5B0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA0BB8A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA0BB990
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA0BBC80
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA0BBDD0
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA0BBF00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA0BBFF0
        public void __UpdateCollisionTags__SystemStringArray__SystemVoid(){} // RVA: 0x7FFACA0BC2A0
        public void __UpdateContentTypes__VRCDynamicsDynamicsUsageFlags__SystemVoid(){} // RVA: 0x7FFACA0BC380
        public void __get_Usage__VRCDynamicsDynamicsUsage(){} // RVA: 0x7FFACA0BC460
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA0BC540
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA0BC660
        public void __get_height__SystemSingle(){} // RVA: 0x7FFACA0BC7A0
        public void __set_height__SystemSingle(){} // RVA: 0x7FFACA0BC880
        public void __get_position__UnityEngineVector3(){} // RVA: 0x7FFACA0BC960
        public void __set_position__UnityEngineVector3(){} // RVA: 0x7FFACA0BCA40
        public void __get_radius__SystemSingle(){} // RVA: 0x7FFACA0BCB20
        public void __set_radius__SystemSingle(){} // RVA: 0x7FFACA0BCC00
        public void __get_rotation__UnityEngineQuaternion(){} // RVA: 0x7FFACA0BCCE0
        public void __set_rotation__UnityEngineQuaternion(){} // RVA: 0x7FFACA0BCDC0
        public void __get_shapeType__VRCDynamicsContactBaseShapeType(){} // RVA: 0x7FFACA0BCEA0
        public void __set_shapeType__VRCDynamicsContactBaseShapeType(){} // RVA: 0x7FFACA0BCF80
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA0BD060
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA0BD1A0
        public void __op_Equality__VRCDynamicsContactSenderProxy_VRCSDK3DynamicsContactComponentsVRCContactSender__SystemBoolean(){} // RVA: 0x7FFACA0BD3A0
        public void __op_Equality__VRCSDK3DynamicsContactComponentsVRCContactSender_VRCDynamicsContactSenderProxy__SystemBoolean(){} // RVA: 0x7FFACA0BD4C0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA0BD5D0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA0BD750
        public void __op_Inequality__VRCDynamicsContactSenderProxy_VRCSDK3DynamicsContactComponentsVRCContactSender__SystemBoolean(){} // RVA: 0x7FFACA0BD950
        public void __op_Inequality__VRCSDK3DynamicsContactComponentsVRCContactSender_VRCDynamicsContactSenderProxy__SystemBoolean(){} // RVA: 0x7FFACA0BDA70
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA0BDB80
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA0BDCB0
    }

    public class ExternVRCSDK3DynamicsContactComponentsVRCContactSenderArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0C0650
        public void .ctor(){} // RVA: 0x7FFACA0C0690
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA0C0A60
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0C0B90
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA0C0CA0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0C0D80
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0C0E60
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA0C0F30
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA0C1080
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA0C1120
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0C1220
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA0C1340
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0C1450
        public void __GetType__SystemType(){} // RVA: 0x7FFACA0C1570
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0C1660
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA0C1740
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA0C1860
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA0C19F0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA0C1B40
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA0C1C70
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA0C1D90
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA0C1F00
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA0C2040
        public void __Get__SystemInt32__VRCSDK3DynamicsContactComponentsVRCContactSender(){} // RVA: 0x7FFACA0C2160
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA0C22A0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA0C2310
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0C2430
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0C25B0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0C2710
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA0C2840
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0C2960
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0C2AC0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0C2C10
        public void __Set__SystemInt32_VRCSDK3DynamicsContactComponentsVRCContactSender__SystemVoid(){} // RVA: 0x7FFACA0C2D30
        public void __ToString__SystemString(){} // RVA: 0x7FFACA0C2EF0
        public void __ctor__SystemInt32__VRCSDK3DynamicsContactComponentsVRCContactSenderArray(){} // RVA: 0x7FFACA0C2FE0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA0C30D0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA0C3170
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA0C3210
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA0C32B0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA0C3350
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA0C33F0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA0C3490
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA0C3570
    }

    public class ExternVRCSDK3DynamicsPhysBoneComponentsVRCPhysBone : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0C5490
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA0C54D0
        public void .ctor(){} // RVA: 0x7FFACA0C5580
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA0C5950
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0C5A80
        public void __ApplyConfigurationChanges__SystemVoid(){} // RVA: 0x7FFACA0C5B90
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA0C5C40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA0C5D30
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA0C5FE0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA0C6140
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA0C6260
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA0C6350
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA0C65D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA0C66C0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA0C6970
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA0C6AD0
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA0C6BF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA0C6CE0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA0C6F60
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA0C70D0
        public void __GetComponent__T(){} // RVA: 0x7FFACA0C71F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA0C72D0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA0C7520
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA0C7610
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA0C7940
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA0C7A30
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA0C7D70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA0C7E60
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA0C8170
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA0C82E0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA0C8410
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA0C8500
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA0C87F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA0C88E0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA0C8C20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA0C8D10
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA0C9020
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA0C9190
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA0C92D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA0C93C0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA0C96B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA0C97A0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA0C9A90
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA0C9BE0
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA0C9D10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA0C9E00
        public void __ReleaseGrabs__SystemVoid(){} // RVA: 0x7FFACA0CA0B0
        public void __ReleasePoses__SystemVoid(){} // RVA: 0x7FFACA0CA1E0
        public void __get_Angle__SystemSingle(){} // RVA: 0x7FFACA0CA360
        public void __get_IsGrabbed__SystemBoolean(){} // RVA: 0x7FFACA0CA440
        public void __get_IsPosed__SystemBoolean(){} // RVA: 0x7FFACA0CA520
        public void __get_Squish__SystemSingle(){} // RVA: 0x7FFACA0CA600
        public void __get_Stretch__SystemSingle(){} // RVA: 0x7FFACA0CA6E0
        public void __get_allowCollision__VRCDynamicsVRCPhysBoneBaseAdvancedBool(){} // RVA: 0x7FFACA0CA7C0
        public void __set_allowCollision__VRCDynamicsVRCPhysBoneBaseAdvancedBool(){} // RVA: 0x7FFACA0CA8A0
        public void __get_allowGrabbing__VRCDynamicsVRCPhysBoneBaseAdvancedBool(){} // RVA: 0x7FFACA0CA980
        public void __set_allowGrabbing__VRCDynamicsVRCPhysBoneBaseAdvancedBool(){} // RVA: 0x7FFACA0CAA60
        public void __get_allowPosing__VRCDynamicsVRCPhysBoneBaseAdvancedBool(){} // RVA: 0x7FFACA0CAB40
        public void __set_allowPosing__VRCDynamicsVRCPhysBoneBaseAdvancedBool(){} // RVA: 0x7FFACA0CAC20
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA0CAD00
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA0CAE20
        public void __get_grabMovement__SystemSingle(){} // RVA: 0x7FFACA0CAF60
        public void __set_grabMovement__SystemSingle(){} // RVA: 0x7FFACA0CB040
        public void __get_gravityCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CB120
        public void __set_gravityCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CB1F0
        public void __get_gravityFalloffCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CB320
        public void __set_gravityFalloffCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CB3F0
        public void __get_gravityFalloff__SystemSingle(){} // RVA: 0x7FFACA0CB520
        public void __set_gravityFalloff__SystemSingle(){} // RVA: 0x7FFACA0CB600
        public void __get_gravity__SystemSingle(){} // RVA: 0x7FFACA0CB6E0
        public void __set_gravity__SystemSingle(){} // RVA: 0x7FFACA0CB7C0
        public void __get_immobileCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CB8A0
        public void __set_immobileCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CB970
        public void __get_immobileType__VRCDynamicsVRCPhysBoneBaseImmobileType(){} // RVA: 0x7FFACA0CBAA0
        public void __set_immobileType__VRCDynamicsVRCPhysBoneBaseImmobileType(){} // RVA: 0x7FFACA0CBB80
        public void __get_immobile__SystemSingle(){} // RVA: 0x7FFACA0CBC60
        public void __set_immobile__SystemSingle(){} // RVA: 0x7FFACA0CBD40
        public void __get_limitRotationXCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CBE20
        public void __set_limitRotationXCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CBEF0
        public void __get_limitRotationYCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CC020
        public void __set_limitRotationYCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CC0F0
        public void __get_limitRotationZCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CC220
        public void __set_limitRotationZCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CC2F0
        public void __get_limitRotation__UnityEngineVector3(){} // RVA: 0x7FFACA0CC420
        public void __set_limitRotation__UnityEngineVector3(){} // RVA: 0x7FFACA0CC510
        public void __get_limitType__VRCDynamicsVRCPhysBoneBaseLimitType(){} // RVA: 0x7FFACA0CC600
        public void __set_limitType__VRCDynamicsVRCPhysBoneBaseLimitType(){} // RVA: 0x7FFACA0CC6E0
        public void __get_maxAngleXCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CC7C0
        public void __set_maxAngleXCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CC890
        public void __get_maxAngleX__SystemSingle(){} // RVA: 0x7FFACA0CC9C0
        public void __set_maxAngleX__SystemSingle(){} // RVA: 0x7FFACA0CCAA0
        public void __get_maxAngleZCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CCB80
        public void __set_maxAngleZCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CCC50
        public void __get_maxAngleZ__SystemSingle(){} // RVA: 0x7FFACA0CCD80
        public void __set_maxAngleZ__SystemSingle(){} // RVA: 0x7FFACA0CCE60
        public void __get_maxSquishCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CCF40
        public void __set_maxSquishCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CD010
        public void __get_maxSquish__SystemSingle(){} // RVA: 0x7FFACA0CD140
        public void __set_maxSquish__SystemSingle(){} // RVA: 0x7FFACA0CD220
        public void __get_maxStretchCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CD300
        public void __set_maxStretchCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CD3D0
        public void __get_maxStretch__SystemSingle(){} // RVA: 0x7FFACA0CD500
        public void __set_maxStretch__SystemSingle(){} // RVA: 0x7FFACA0CD5E0
        public void __get_pullCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CD6C0
        public void __set_pullCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CD790
        public void __get_pull__SystemSingle(){} // RVA: 0x7FFACA0CD8B0
        public void __set_pull__SystemSingle(){} // RVA: 0x7FFACA0CD990
        public void __get_radiusCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CDA70
        public void __set_radiusCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CDB40
        public void __get_radius__SystemSingle(){} // RVA: 0x7FFACA0CDC70
        public void __set_radius__SystemSingle(){} // RVA: 0x7FFACA0CDD50
        public void __get_snapToHand__SystemBoolean(){} // RVA: 0x7FFACA0CDE30
        public void __set_snapToHand__SystemBoolean(){} // RVA: 0x7FFACA0CDF10
        public void __get_springCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CDFF0
        public void __set_springCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CE0C0
        public void __get_spring__SystemSingle(){} // RVA: 0x7FFACA0CE1E0
        public void __set_spring__SystemSingle(){} // RVA: 0x7FFACA0CE2C0
        public void __get_stiffnessCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CE3A0
        public void __set_stiffnessCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CE470
        public void __get_stiffness__SystemSingle(){} // RVA: 0x7FFACA0CE590
        public void __set_stiffness__SystemSingle(){} // RVA: 0x7FFACA0CE670
        public void __get_stretchMotionCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CE750
        public void __set_stretchMotionCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFACA0CE820
        public void __get_stretchMotion__SystemSingle(){} // RVA: 0x7FFACA0CE950
        public void __set_stretchMotion__SystemSingle(){} // RVA: 0x7FFACA0CEA30
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA0CEB10
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA0CEC50
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA0CEE50
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA0CEFD0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA0CF1D0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA0CF300
    }

    public class ExternVRCSDK3DynamicsPhysBoneComponentsVRCPhysBoneArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0D4820
        public void .ctor(){} // RVA: 0x7FFACA0D4860
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA0D4C30
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0D4D60
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA0D4E70
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0D4F50
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0D5030
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA0D5100
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA0D5250
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA0D52F0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0D53F0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA0D5510
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0D5620
        public void __GetType__SystemType(){} // RVA: 0x7FFACA0D5740
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0D5830
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA0D5910
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA0D5A30
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA0D5BC0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA0D5D10
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA0D5E40
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA0D5F60
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA0D60D0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA0D6210
        public void __Get__SystemInt32__VRCSDK3DynamicsPhysBoneComponentsVRCPhysBone(){} // RVA: 0x7FFACA0D6330
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA0D6470
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA0D64E0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0D6600
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0D6780
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0D68E0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA0D6A10
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0D6B30
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0D6C90
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0D6DE0
        public void __Set__SystemInt32_VRCSDK3DynamicsPhysBoneComponentsVRCPhysBone__SystemVoid(){} // RVA: 0x7FFACA0D6F00
        public void __ToString__SystemString(){} // RVA: 0x7FFACA0D70C0
        public void __ctor__SystemInt32__VRCSDK3DynamicsPhysBoneComponentsVRCPhysBoneArray(){} // RVA: 0x7FFACA0D71B0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA0D72A0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA0D7340
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA0D73E0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA0D7480
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA0D7520
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA0D75C0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA0D7660
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA0D7740
    }

    public class ExternVRCSDK3ImageIVRCImageDownload : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0D9660
        public void .ctor(){} // RVA: 0x7FFACA0D96A0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA0D9A70
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0D9BA0
        public void __Dispose__SystemVoid(){} // RVA: 0x7FFACA0D9CB0
        public void __get_ErrorMessage__SystemString(){} // RVA: 0x7FFACA0D9D40
        public void __get_Error__VRCSDK3ImageVRCImageDownloadError(){} // RVA: 0x7FFACA0D9E00
        public void __get_Material__UnityEngineMaterial(){} // RVA: 0x7FFACA0D9ED0
        public void __get_Progress__SystemSingle(){} // RVA: 0x7FFACA0D9FD0
        public void __get_Result__UnityEngineTexture2D(){} // RVA: 0x7FFACA0DA0A0
        public void __get_SizeInMemoryBytes__SystemInt32(){} // RVA: 0x7FFACA0DA1A0
        public void __get_State__VRCSDK3ImageVRCImageDownloadState(){} // RVA: 0x7FFACA0DA270
        public void __get_TextureInfo__VRCSDK3ImageTextureInfo(){} // RVA: 0x7FFACA0DA330
        public void __get_UdonBehaviour__VRCUdonCommonInterfacesIUdonEventReceiver(){} // RVA: 0x7FFACA0DA470
        public void __get_Url__VRCSDKBaseVRCUrl(){} // RVA: 0x7FFACA0DA540
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA0DA600
    }

    public class ExternVRCSDK3ImageIVRCImageDownloadArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0DB010
        public void .ctor(){} // RVA: 0x7FFACA0DB050
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA0DB420
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0DB550
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA0DB660
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0DB740
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0DB820
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA0DB8F0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA0DBA40
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA0DBAE0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0DBBE0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA0DBD00
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0DBE10
        public void __GetType__SystemType(){} // RVA: 0x7FFACA0DBF30
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0DC020
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA0DC100
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA0DC220
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA0DC3B0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA0DC500
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA0DC630
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA0DC750
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA0DC8C0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA0DCA00
        public void __Get__SystemInt32__VRCSDK3ImageIVRCImageDownload(){} // RVA: 0x7FFACA0DCB20
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA0DCC00
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA0DCC70
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0DCD90
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0DCF10
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0DD070
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA0DD1A0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0DD2C0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0DD420
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0DD570
        public void __Set__SystemInt32_VRCSDK3ImageIVRCImageDownload__SystemVoid(){} // RVA: 0x7FFACA0DD690
        public void __ToString__SystemString(){} // RVA: 0x7FFACA0DD810
        public void __ctor__SystemInt32__VRCSDK3ImageIVRCImageDownloadArray(){} // RVA: 0x7FFACA0DD900
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA0DDAA0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA0DDB40
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA0DDBE0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA0DDC80
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA0DDD20
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA0DDDC0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA0DDE60
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA0DDF40
    }

    public class ExternVRCSDK3ImageTextureInfo : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0DFE60
        public void .ctor(){} // RVA: 0x7FFACA0DFEA0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA0E0270
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0E03A0
        public void __ctor____VRCSDK3ImageTextureInfo(){} // RVA: 0x7FFACA0E04B0
        public void __get_AnisoLevel__SystemInt32(){} // RVA: 0x7FFACA0E0550
        public void __set_AnisoLevel__SystemInt32(){} // RVA: 0x7FFACA0E05F0
        public void __get_FilterMode__UnityEngineFilterMode(){} // RVA: 0x7FFACA0E06A0
        public void __set_FilterMode__UnityEngineFilterMode(){} // RVA: 0x7FFACA0E0740
        public void __get_GenerateMipMaps__SystemBoolean(){} // RVA: 0x7FFACA0E07F0
        public void __set_GenerateMipMaps__SystemBoolean(){} // RVA: 0x7FFACA0E0890
        public void __get_MaterialProperty__SystemString(){} // RVA: 0x7FFACA0E0940
        public void __set_MaterialProperty__SystemString(){} // RVA: 0x7FFACA0E09D0
        public void __get_WrapModeU__UnityEngineTextureWrapMode(){} // RVA: 0x7FFACA0E0AC0
        public void __set_WrapModeU__UnityEngineTextureWrapMode(){} // RVA: 0x7FFACA0E0B60
        public void __get_WrapModeV__UnityEngineTextureWrapMode(){} // RVA: 0x7FFACA0E0C10
        public void __set_WrapModeV__UnityEngineTextureWrapMode(){} // RVA: 0x7FFACA0E0CB0
        public void __get_WrapModeW__UnityEngineTextureWrapMode(){} // RVA: 0x7FFACA0E0D60
        public void __set_WrapModeW__UnityEngineTextureWrapMode(){} // RVA: 0x7FFACA0E0E00
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA0E0EB0
    }

    public class ExternVRCSDK3ImageTextureInfoArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0E1BD0
        public void .ctor(){} // RVA: 0x7FFACA0E1C10
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA0E1FE0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0E2110
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA0E2220
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0E2300
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0E23E0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA0E24B0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA0E2600
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA0E26A0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0E27A0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA0E28C0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0E29D0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA0E2AF0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0E2BE0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA0E2CC0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA0E2DE0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA0E2F70
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA0E30C0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA0E31F0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA0E3310
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA0E3480
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA0E35C0
        public void __Get__SystemInt32__VRCSDK3ImageTextureInfo(){} // RVA: 0x7FFACA0E36E0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA0E37C0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA0E3830
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0E3950
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0E3AD0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0E3C30
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA0E3D60
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0E3E80
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0E3FE0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0E4130
        public void __Set__SystemInt32_VRCSDK3ImageTextureInfo__SystemVoid(){} // RVA: 0x7FFACA0E4250
        public void __ToString__SystemString(){} // RVA: 0x7FFACA0E43D0
        public void __ctor__SystemInt32__VRCSDK3ImageTextureInfoArray(){} // RVA: 0x7FFACA0E44C0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA0E4660
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA0E4700
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA0E47A0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA0E4840
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA0E48E0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA0E4980
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA0E4A20
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA0E4B00
    }

    public class ExternVRCSDK3ImageVRCImageDownloadError : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0EC9B0
        public void .ctor(){} // RVA: 0x7FFACA0EC9F0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA0ECDC0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0ECEF0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA0ED000
        public void __ToString__SystemString(){} // RVA: 0x7FFACA0ED140
        public void __ToString__SystemString__SystemString(){} // RVA: 0x7FFACA0ED1F0
        public void __get_AccessDenied__VRCSDK3ImageVRCImageDownloadError(){} // RVA: 0x7FFACA0ED2C0
        public void __get_DownloadError__VRCSDK3ImageVRCImageDownloadError(){} // RVA: 0x7FFACA0ED330
        public void __get_InvalidImage__VRCSDK3ImageVRCImageDownloadError(){} // RVA: 0x7FFACA0ED3A0
        public void __get_InvalidURL__VRCSDK3ImageVRCImageDownloadError(){} // RVA: 0x7FFACA0ED410
        public void __get_TooManyRequests__VRCSDK3ImageVRCImageDownloadError(){} // RVA: 0x7FFACA0ED480
        public void __get_Unknown__VRCSDK3ImageVRCImageDownloadError(){} // RVA: 0x7FFACA0ED4F0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA0ED560
    }

    public class ExternVRCSDK3ImageVRCImageDownloadState : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0EDE00
        public void .ctor(){} // RVA: 0x7FFACA0EDE40
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA0EE210
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0EE340
        public void __CompareTo__SystemObject__SystemInt32(){} // RVA: 0x7FFACA0EE450
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA0EE580
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA0EE6C0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA0EE770
        public void __ToString__SystemString(){} // RVA: 0x7FFACA0EE860
        public void __ToString__SystemString__SystemString(){} // RVA: 0x7FFACA0EE910
        public void __get_Complete__VRCSDK3ImageVRCImageDownloadState(){} // RVA: 0x7FFACA0EE9E0
        public void __get_Error__VRCSDK3ImageVRCImageDownloadState(){} // RVA: 0x7FFACA0EEA50
        public void __get_Pending__VRCSDK3ImageVRCImageDownloadState(){} // RVA: 0x7FFACA0EEAC0
        public void __get_Unknown__VRCSDK3ImageVRCImageDownloadState(){} // RVA: 0x7FFACA0EEB30
        public void __get_Unloaded__VRCSDK3ImageVRCImageDownloadState(){} // RVA: 0x7FFACA0EEBA0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA0EEC10
    }

    public class ExternVRCSDK3ImageVRCImageDownloadStateArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0EF620
        public void .ctor(){} // RVA: 0x7FFACA0EF660
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA0EFA30
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0EFB60
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA0EFC70
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0EFD50
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0EFE30
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA0EFF00
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA0F0050
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA0F00F0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0F01F0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA0F0310
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0F0420
        public void __GetType__SystemType(){} // RVA: 0x7FFACA0F0540
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0F0630
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA0F0710
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA0F0830
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA0F09C0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA0F0B10
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA0F0C40
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA0F0D60
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA0F0ED0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA0F1010
        public void __Get__SystemInt32__VRCSDK3ImageVRCImageDownloadState(){} // RVA: 0x7FFACA0F1130
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA0F1210
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA0F1280
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0F13A0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0F1520
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0F1680
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA0F17B0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0F18D0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0F1A30
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0F1B80
        public void __Set__SystemInt32_VRCSDK3ImageVRCImageDownloadState__SystemVoid(){} // RVA: 0x7FFACA0F1CA0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA0F1D90
        public void __ctor__SystemInt32__VRCSDK3ImageVRCImageDownloadStateArray(){} // RVA: 0x7FFACA0F1E80
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA0F2020
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA0F20C0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA0F2160
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA0F2200
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA0F22A0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA0F2340
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA0F23E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA0F24C0
    }

    public class ExternVRCSDK3ImageVRCImageDownloader : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0E6A20
        public void .ctor(){} // RVA: 0x7FFACA0E6A60
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA0E6E30
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0E6F60
        public void __Dispose__SystemVoid(){} // RVA: 0x7FFACA0E7070
        public void __DownloadImage__VRCSDKBaseVRCUrl_UnityEngineMaterial_VRCUdonCommonInterfacesIUdonEventReceiver_VRCSDK3ImageTextureInfo__VRCSDK3ImageIVRCImageDownload(){} // RVA: 0x7FFACA0E7130
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA0E7440
        public void __ctor____VRCSDK3ImageVRCImageDownloader(){} // RVA: 0x7FFACA0E7590
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA0E76C0
    }

    public class ExternVRCSDK3ImageVRCImageDownloaderArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0E7B90
        public void .ctor(){} // RVA: 0x7FFACA0E7BD0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA0E7FA0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0E80D0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA0E81E0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0E82C0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0E83A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA0E8470
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA0E85C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA0E8660
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0E8760
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA0E8880
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0E8990
        public void __GetType__SystemType(){} // RVA: 0x7FFACA0E8AB0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0E8BA0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA0E8C80
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA0E8DA0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA0E8F30
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA0E9080
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA0E91B0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA0E92D0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA0E9440
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA0E9580
        public void __Get__SystemInt32__VRCSDK3ImageVRCImageDownloader(){} // RVA: 0x7FFACA0E96A0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA0E9780
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA0E97F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0E9910
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0E9A90
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0E9BF0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA0E9D20
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0E9E40
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0E9FA0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0EA0F0
        public void __Set__SystemInt32_VRCSDK3ImageVRCImageDownloader__SystemVoid(){} // RVA: 0x7FFACA0EA210
        public void __ToString__SystemString(){} // RVA: 0x7FFACA0EA360
        public void __ctor__SystemInt32__VRCSDK3ImageVRCImageDownloaderArray(){} // RVA: 0x7FFACA0EA450
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA0EA5F0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA0EA690
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA0EA730
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA0EA7D0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA0EA870
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA0EA910
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA0EA9B0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA0EAA90
    }

    public class ExternVRCSDK3InternalBestInstancesListener : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC4756F50
        public void .ctor(){} // RVA: 0x7FFAC4756F90
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFAC4757360
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFAC4757490
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFAC47575A0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFAC47576F0
        public void __GetType__SystemType(){} // RVA: 0x7FFAC47577F0
        public void __StartListening__SystemVoid(){} // RVA: 0x7FFAC47578E0
        public void __ToString__SystemString(){} // RVA: 0x7FFAC4757AB0
        public void __ctor__SystemStringArray_SystemString_VRCUdonCommonInterfacesIUdonEventReceiver__VRCSDK3InternalBestInstancesListener(){} // RVA: 0x7FFAC4757BA0
        public void __get_requestedPopulationBracket__SystemString(){} // RVA: 0x7FFAC4757CF0
        public void __get_resultInstances__SystemStringArray(){} // RVA: 0x7FFAC4757D80
        public void __set_resultInstances__SystemStringArray(){} // RVA: 0x7FFAC4757E10
        public void <.ctor>b__6_1(){} // RVA: 0x7FFAC4757F00
    }

    public class ExternVRCSDK3InternalChangeSettings : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC4759940
        public void .ctor(){} // RVA: 0x7FFAC4759980
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFAC4759D50
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFAC4759E80
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFAC4759F90
        public void __GetChatBubbleVisibility__VRCSDK3InternalVRCChatBubbleVisibility(){} // RVA: 0x7FFAC475A0E0
        public void __GetComfortMode__VRCSDK3InternalVRCComfortMode(){} // RVA: 0x7FFAC475A1F0
        public void __GetComfortTurningEnabled__SystemBoolean(){} // RVA: 0x7FFAC475A300
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFAC475A430
        public void __GetPersonalSpaceEnabled__SystemBoolean(){} // RVA: 0x7FFAC475A530
        public void __GetSafetyLevel__VRCSDK3InternalVRCSafetyLevels(){} // RVA: 0x7FFAC475A660
        public void __GetType__SystemType(){} // RVA: 0x7FFAC475A770
        public void __SetChatBubbleVisibility__VRCSDK3InternalVRCChatBubbleVisibility__SystemVoid(){} // RVA: 0x7FFAC475A860
        public void __SetComfortMode__VRCSDK3InternalVRCComfortMode__SystemVoid(){} // RVA: 0x7FFAC475A980
        public void __SetComfortTurningEnabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFAC475AAA0
        public void __SetPersonalSpaceEnabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFAC475ABD0
        public void __SetSafetyLevel__VRCSDK3InternalVRCSafetyLevels__SystemVoid(){} // RVA: 0x7FFAC475AD00
        public void __ToString__SystemString(){} // RVA: 0x7FFAC475AE20
        public void <.ctor>b__6_1(){} // RVA: 0x7FFAC475AF10
    }

    public class ExternVRCSDK3InternalEventPortalsVRCEventPortalManager : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC9E6BCF0
        public void .ctor(){} // RVA: 0x7FFAC9E6BD30
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFAC9E6C100
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFAC9E6C230
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFAC9E6C340
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFAC9E6C4A0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFAC9E6C590
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFAC9E6C6F0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFAC9E6C810
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFAC9E6C900
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFAC9E6C9F0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFAC9E6CB50
        public void __GetComponentInParent__T(){} // RVA: 0x7FFAC9E6CC70
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFAC9E6CD60
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFAC9E6CED0
        public void __GetComponent__T(){} // RVA: 0x7FFAC9E6CFF0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFAC9E6D0D0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFAC9E6D1C0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFAC9E6D2B0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFAC9E6D3A0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFAC9E6D510
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFAC9E6D640
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFAC9E6D730
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFAC9E6D820
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFAC9E6D910
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFAC9E6DA80
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFAC9E6DBC0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFAC9E6DCB0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFAC9E6DDA0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFAC9E6DEF0
        public void __GetComponents__TArray(){} // RVA: 0x7FFAC9E6E020
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFAC9E6E110
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFAC9E6E200
        public void __GetType__SystemType(){} // RVA: 0x7FFAC9E6E2E0
        public void __RegisterPortal__VRCSDK3ComponentsVRCPortalMarker__SystemVoid(){} // RVA: 0x7FFAC9E6E3D0
        public void __RegisterPortal__VRCSDKBaseVRC_PortalMarker__SystemVoid(){} // RVA: 0x7FFAC9E6E510
        public void __ToString__SystemString(){} // RVA: 0x7FFAC9E6E650
        public void __UnregisterPortal__VRCSDK3ComponentsVRCPortalMarker__SystemVoid(){} // RVA: 0x7FFAC9E6E730
        public void __UnregisterPortal__VRCSDKBaseVRC_PortalMarker__SystemVoid(){} // RVA: 0x7FFAC9E6E870
        public void __get_destroyCancellationToken__SystemThreadingCancellationToken(){} // RVA: 0x7FFAC9E6E9B0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFAC9E6EA90
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFAC9E6EBB0
        public void __get_name__SystemString(){} // RVA: 0x7FFAC9E6ECF0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFAC9E6EDD0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFAC9E6EF10
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFAC9E6F110
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFAC9E6F290
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFAC9E6F490
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFAC9E6F5C0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFAC9E6F6A0
    }

    public class ExternVRCSDK3InternalPedestalPreviewListener : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC47605B0
        public void .ctor(){} // RVA: 0x7FFAC47605F0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFAC47609C0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFAC4760AF0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFAC4760C00
        public void __GetAvatarPreview__UnityEngineTexture2D(){} // RVA: 0x7FFAC4760D50
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFAC4760E70
        public void __GetType__SystemType(){} // RVA: 0x7FFAC4760F70
        public void __StartListening__SystemVoid(){} // RVA: 0x7FFAC4761060
        public void __ToString__SystemString(){} // RVA: 0x7FFAC4761220
        public void __ctor__VRCSDK3ComponentsVRCAvatarPedestal_VRCUdonCommonInterfacesIUdonEventReceiver__VRCSDK3InternalPedestalPreviewListener(){} // RVA: 0x7FFAC4761310
        public void __get_target__VRCSDK3ComponentsVRCAvatarPedestal(){} // RVA: 0x7FFAC4761450
        public void <.ctor>b__6_1(){} // RVA: 0x7FFAC4761520
    }

    public class ExternVRCSDK3InternalPlatformChecker : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC4769580
        public void .ctor(){} // RVA: 0x7FFAC47695C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFAC4769990
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFAC4769AC0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFAC4769BD0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFAC4769D20
        public void __GetType__SystemType(){} // RVA: 0x7FFAC4769E20
        public void __StartFetchingWorldInfo__SystemVoid(){} // RVA: 0x7FFAC4769F10
        public void __ToString__SystemString(){} // RVA: 0x7FFAC476A0B0
        public void __ctor__SystemString_VRCUdonCommonInterfacesIUdonEventReceiver__VRCSDK3InternalPlatformChecker(){} // RVA: 0x7FFAC476A1A0
        public void __get_isUnavailableOnThisPlatform__SystemBoolean(){} // RVA: 0x7FFAC476A2C0
        public void __get_udonEventReceiver__VRCUdonCommonInterfacesIUdonEventReceiver(){} // RVA: 0x7FFAC476A360
        public void __get_worldID__SystemString(){} // RVA: 0x7FFAC476A400
        public void __set_isUnavailableOnThisPlatform__SystemBoolean__SystemVoid(){} // RVA: 0x7FFAC476A490
        public void <.ctor>b__6_1(){} // RVA: 0x7FFAC476A540
    }

    public class ExternVRCSDK3InternalToolsVRCInternalUserInterests : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC4767F60
        public void .ctor(){} // RVA: 0x7FFAC4767FA0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFAC4768370
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFAC47684A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFAC47685B0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFAC4768700
        public void __GetLastError__SystemString(){} // RVA: 0x7FFAC4768800
        public void __GetResult__VRCSDK3DataDataDictionary(){} // RVA: 0x7FFAC47688C0
        public void __GetType__SystemType(){} // RVA: 0x7FFAC4768980
        public void __HasFinishedFetchingUserInterests__SystemBoolean(){} // RVA: 0x7FFAC4768A70
        public void __SetUserInterests__VRCSDK3DataDataDictionary__SystemVoid(){} // RVA: 0x7FFAC4768B30
        public void __StartFetchingUserInterests__SystemVoid(){} // RVA: 0x7FFAC4768BA0
        public void __ToString__SystemString(){} // RVA: 0x7FFAC4768BB0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFAC4768CA0
    }

    public class ExternVRCSDK3InternalVRCBestInstances : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC47587A0
        public void .ctor(){} // RVA: 0x7FFAC47587E0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFAC4758BB0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFAC4758CE0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFAC4758DF0
        public void __GetBestInstances__SystemStringArray_SystemString_VRCUdonCommonInterfacesIUdonEventReceiver__VRCSDK3InternalBestInstancesListener(){} // RVA: 0x7FFAC4758F40
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFAC47590C0
        public void __GetType__SystemType(){} // RVA: 0x7FFAC47591C0
        public void __ToString__SystemString(){} // RVA: 0x7FFAC47592B0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFAC47593A0
    }

    public class ExternVRCSDK3InternalVRCChatBubbleVisibility : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC475BB70
        public void .ctor(){} // RVA: 0x7FFAC475BBB0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFAC475BF80
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFAC475C0B0
        public void __CompareTo__SystemObject__SystemInt32(){} // RVA: 0x7FFAC475C1C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFAC475C2F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFAC475C430
        public void __GetType__SystemType(){} // RVA: 0x7FFAC475C4E0
        public void __ToString__SystemString(){} // RVA: 0x7FFAC475C5D0
        public void __ToString__SystemString__SystemString(){} // RVA: 0x7FFAC475C680
        public void __get_Everyone__VRCSDK3InternalVRCChatBubbleVisibility(){} // RVA: 0x7FFAC475C750
        public void __get_Friends__VRCSDK3InternalVRCChatBubbleVisibility(){} // RVA: 0x7FFAC475C7C0
        public void __get_Mine__VRCSDK3InternalVRCChatBubbleVisibility(){} // RVA: 0x7FFAC475C830
        public void <.ctor>b__6_1(){} // RVA: 0x7FFAC475C8A0
    }

    public class ExternVRCSDK3InternalVRCComfortMode : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC475D140
        public void .ctor(){} // RVA: 0x7FFAC475D180
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFAC475D550
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFAC475D680
        public void __CompareTo__SystemObject__SystemInt32(){} // RVA: 0x7FFAC475D790
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFAC475D8C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFAC475DA00
        public void __GetType__SystemType(){} // RVA: 0x7FFAC475DAB0
        public void __ToString__SystemString(){} // RVA: 0x7FFAC475DBA0
        public void __ToString__SystemString__SystemString(){} // RVA: 0x7FFAC475DC50
        public void __get_Holoport__VRCSDK3InternalVRCComfortMode(){} // RVA: 0x7FFAC475DD20
        public void __get_Standard__VRCSDK3InternalVRCComfortMode(){} // RVA: 0x7FFAC475DD90
        public void __get_TunnellingHigh__VRCSDK3InternalVRCComfortMode(){} // RVA: 0x7FFAC475DE00
        public void __get_TunnellingLow__VRCSDK3InternalVRCComfortMode(){} // RVA: 0x7FFAC475DE70
        public void <.ctor>b__6_1(){} // RVA: 0x7FFAC475DEE0
    }

    public class ExternVRCSDK3InternalVRCExperiments : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC475E840
        public void .ctor(){} // RVA: 0x7FFAC475E880
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFAC475EC50
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFAC475ED80
        public void __GetExperimentPayload__SystemString_SystemString_SystemBoolean__SystemBoolean(){} // RVA: 0x7FFAC475EE90
        public void __GetExperimentPayload__SystemString_SystemString_SystemDouble__SystemDouble(){} // RVA: 0x7FFAC475F040
        public void __GetExperimentPayload__SystemString_SystemString_SystemInt32__SystemInt32(){} // RVA: 0x7FFAC475F1E0
        public void __GetExperimentPayload__SystemString_SystemString_SystemString__SystemString(){} // RVA: 0x7FFAC475F380
        public void __IsInExperimentSegment__SystemString_SystemString__SystemBoolean(){} // RVA: 0x7FFAC475F500
        public void <.ctor>b__6_1(){} // RVA: 0x7FFAC475F670
    }

    public class ExternVRCSDK3InternalVRCInternalAvatarPedestal : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC4761D00
        public void .ctor(){} // RVA: 0x7FFAC4761D40
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFAC4762110
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFAC4762240
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFAC4762350
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFAC47624A0
        public void __GetPedestalListener__VRCSDK3ComponentsVRCAvatarPedestal_VRCUdonCommonInterfacesIUdonEventReceiver__VRCSDK3InternalPedestalPreviewListener(){} // RVA: 0x7FFAC47625A0
        public void __GetType__SystemType(){} // RVA: 0x7FFAC4762710
        public void __ToString__SystemString(){} // RVA: 0x7FFAC4762800
        public void <.ctor>b__6_1(){} // RVA: 0x7FFAC47628F0
    }

    public class ExternVRCSDK3InternalVRCOpenMenu : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC475FC10
        public void .ctor(){} // RVA: 0x7FFAC475FC50
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFAC4760020
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFAC4760150
        public void __OpenFriendsList__SystemVoid(){} // RVA: 0x7FFAC46FA650
        public void __OpenMassGifting__SystemVoid(){} // RVA: 0x7FFAC46FA710
        public void <.ctor>b__6_1(){} // RVA: 0x7FFAC4760260
    }

    public class ExternVRCSDK3InternalVRCPrideCampaign : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC4762E90
        public void .ctor(){} // RVA: 0x7FFAC4762ED0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFAC47632A0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFAC47633D0
        public void __RefreshData__SystemVoid(){} // RVA: 0x7FFAC47634E0
        public void __get_FriendParticipantCount__SystemInt32(){} // RVA: 0x7FFAC47635C0
        public void __get_FriendParticipantIcons__UnityEngineSpriteArray(){} // RVA: 0x7FFAC47636D0
        public void __get_FriendParticipantNames__SystemStringArray(){} // RVA: 0x7FFAC4763800
        public void __get_GlobalDollarsGoal__SystemInt32(){} // RVA: 0x7FFAC47638F0
        public void __get_GlobalDollarsRaised__SystemInt32(){} // RVA: 0x7FFAC4763A10
        public void __get_GlobalParticipantCount__SystemInt32(){} // RVA: 0x7FFAC4763B30
        public void __get_IsCampaignActive__SystemBoolean(){} // RVA: 0x7FFAC4763C50
        public void __get_LastRefreshTimestampUTC__SystemDateTime(){} // RVA: 0x7FFAC4763D60
        public void __get_LocalGiftsCount__SystemInt32(){} // RVA: 0x7FFAC4763E60
        public void <.ctor>b__6_1(){} // RVA: 0x7FFAC4763F80
    }

    public class ExternVRCSDK3InternalVRCUrlConstructor : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC4765040
        public void .ctor(){} // RVA: 0x7FFAC4765080
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFAC4765450
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFAC4765580
        public void __GetAllowlistedUrl__SystemString__VRCSDKBaseVRCUrl(){} // RVA: 0x7FFAC4765690
        public void __GetUrl__SystemString__VRCSDKBaseVRCUrl(){} // RVA: 0x7FFAC47657A0
        public void __GetYouTubeUrlFromId__SystemString__VRCSDKBaseVRCUrl(){} // RVA: 0x7FFAC4765930
        public void <.ctor>b__6_1(){} // RVA: 0x7FFAC47659D0
    }

    public class ExternVRCSDK3InternalVRCUrlLauncher : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC4765DF0
        public void .ctor(){} // RVA: 0x7FFAC4765E30
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFAC4766200
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFAC4766330
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFAC4766440
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFAC4766590
        public void __GetType__SystemType(){} // RVA: 0x7FFAC4766690
        public void __OpenURLWithData__VRCSDKBaseVRCUrl_SystemString__SystemVoid(){} // RVA: 0x7FFAC4766780
        public void __ToString__SystemString(){} // RVA: 0x7FFAC4766830
        public void <.ctor>b__6_1(){} // RVA: 0x7FFAC4766920
    }

    public class ExternVRCSDK3InternalVRCUserFirstJoin : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC4766EC0
        public void .ctor(){} // RVA: 0x7FFAC4766F00
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFAC47672D0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFAC4767400
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFAC4767510
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFAC4767660
        public void __GetIsNewUser__VRCUdonCommonInterfacesIUdonEventReceiver__SystemVoid(){} // RVA: 0x7FFAC4767760
        public void __GetType__SystemType(){} // RVA: 0x7FFAC47677E0
        public void __ToString__SystemString(){} // RVA: 0x7FFAC47678D0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFAC47679C0
    }

    public class ExternVRCSDK3InternalVRCWorldPlatformChecker : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC476AEA0
        public void .ctor(){} // RVA: 0x7FFAC476AEE0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFAC476B2B0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFAC476B3E0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFAC476B4F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFAC476B640
        public void __GetPlatformChecker__SystemString_VRCUdonCommonInterfacesIUdonEventReceiver__VRCSDK3InternalPlatformChecker(){} // RVA: 0x7FFAC476B740
        public void __GetType__SystemType(){} // RVA: 0x7FFAC476B890
        public void __ToString__SystemString(){} // RVA: 0x7FFAC476B980
        public void <.ctor>b__6_1(){} // RVA: 0x7FFAC476BA70
    }

    public class ExternVRCSDK3MidiMidiData : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0F43E0
        public void .ctor(){} // RVA: 0x7FFACA0F4420
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA0F47F0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0F4920
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA0F4A30
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA0F4B80
        public void __GetType__SystemType(){} // RVA: 0x7FFACA0F4C80
        public void __ToString__SystemString(){} // RVA: 0x7FFACA0F4D70
        public void __ctor____VRCSDK3MidiMidiData(){} // RVA: 0x7FFACA0F4E60
        public void __get_bpm__SystemByte(){} // RVA: 0x7FFACA0F4EE0
        public void __set_bpm__SystemByte(){} // RVA: 0x7FFACA0F4F80
        public void __get_tracks__VRCSDK3MidiMidiDataMidiTrackArray(){} // RVA: 0x7FFACA0F5030
        public void __set_tracks__VRCSDK3MidiMidiDataMidiTrackArray(){} // RVA: 0x7FFACA0F50C0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA0F51B0
    }

    public class ExternVRCSDK3MidiMidiDataMidiBlock : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0F5A50
        public void .ctor(){} // RVA: 0x7FFACA0F5A90
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA0F5E60
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0F5F90
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA0F60A0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA0F61F0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA0F62F0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA0F63E0
        public void __ctor____VRCSDK3MidiMidiDataMidiBlock(){} // RVA: 0x7FFACA0F6490
        public void __get_channel__SystemInt32(){} // RVA: 0x7FFACA0F6510
        public void __set_channel__SystemInt32(){} // RVA: 0x7FFACA0F65B0
        public void __get_endTimeMs__SystemSingle(){} // RVA: 0x7FFACA0F6660
        public void __set_endTimeMs__SystemSingle(){} // RVA: 0x7FFACA0F6700
        public void __get_endTimeSec__SystemSingle(){} // RVA: 0x7FFACA0F67B0
        public void __get_lengthSec__SystemSingle(){} // RVA: 0x7FFACA0F6850
        public void __get_note__SystemByte(){} // RVA: 0x7FFACA0F6900
        public void __set_note__SystemByte(){} // RVA: 0x7FFACA0F69A0
        public void __get_startTimeMs__SystemSingle(){} // RVA: 0x7FFACA0F6A50
        public void __set_startTimeMs__SystemSingle(){} // RVA: 0x7FFACA0F6AF0
        public void __get_startTimeSec__SystemSingle(){} // RVA: 0x7FFACA0F6BA0
        public void __get_velocity__SystemByte(){} // RVA: 0x7FFACA0F6C40
        public void __set_velocity__SystemByte(){} // RVA: 0x7FFACA0F6CE0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA0F6D90
    }

    public class ExternVRCSDK3MidiMidiDataMidiBlockArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0F7CF0
        public void .ctor(){} // RVA: 0x7FFACA0F7D30
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA0F8100
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0F8230
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA0F8340
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0F8420
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0F8500
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA0F85D0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA0F8720
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA0F87C0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0F88C0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA0F89E0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0F8AF0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA0F8C10
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0F8D00
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA0F8DE0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA0F8F00
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA0F9090
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA0F91E0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA0F9310
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA0F9430
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA0F95A0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA0F96E0
        public void __Get__SystemInt32__VRCSDK3MidiMidiDataMidiBlock(){} // RVA: 0x7FFACA0F9800
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA0F98E0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA0F9950
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0F9A70
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0F9BF0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0F9D50
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA0F9E80
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0F9FA0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0FA100
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0FA250
        public void __Set__SystemInt32_VRCSDK3MidiMidiDataMidiBlock__SystemVoid(){} // RVA: 0x7FFACA0FA370
        public void __ToString__SystemString(){} // RVA: 0x7FFACA0FA4F0
        public void __ctor__SystemInt32__VRCSDK3MidiMidiDataMidiBlockArray(){} // RVA: 0x7FFACA0FA5E0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA0FA690
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA0FA730
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA0FA7D0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA0FA870
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA0FA910
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA0FA9B0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA0FAA50
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA0FAB30
    }

    public class ExternVRCSDK3MidiMidiDataMidiTrack : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0FCA50
        public void .ctor(){} // RVA: 0x7FFACA0FCA90
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA0FCE60
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0FCF90
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA0FD0A0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA0FD1F0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA0FD2F0
        public void __SetBlocks__SystemCollectionsGenericListVRCSDK3MidiMidiDataMidiBlock__SystemVoid(){} // RVA: 0x7FFACA0FD3E0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA0FD570
        public void __ctor____VRCSDK3MidiMidiDataMidiTrack(){} // RVA: 0x7FFACA0FD660
        public void __get_blocks__VRCSDK3MidiMidiDataMidiBlockArray(){} // RVA: 0x7FFACA0FD6F0
        public void __set_blocks__VRCSDK3MidiMidiDataMidiBlockArray(){} // RVA: 0x7FFACA0FD780
        public void __get_maxNote__SystemByte(){} // RVA: 0x7FFACA0FD870
        public void __set_maxNote__SystemByte(){} // RVA: 0x7FFACA0FD910
        public void __get_maxVelocity__SystemByte(){} // RVA: 0x7FFACA0FD9C0
        public void __set_maxVelocity__SystemByte(){} // RVA: 0x7FFACA0FDA60
        public void __get_minNote__SystemByte(){} // RVA: 0x7FFACA0FDB10
        public void __set_minNote__SystemByte(){} // RVA: 0x7FFACA0FDBB0
        public void __get_minVelocity__SystemByte(){} // RVA: 0x7FFACA0FDC60
        public void __set_minVelocity__SystemByte(){} // RVA: 0x7FFACA0FDD00
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA0FDDB0
    }

    public class ExternVRCSDK3MidiMidiDataMidiTrackArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA0FEB90
        public void .ctor(){} // RVA: 0x7FFACA0FEBD0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA0FEFA0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA0FF0D0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA0FF1E0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA0FF2C0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA0FF3A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA0FF470
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA0FF5C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA0FF660
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0FF760
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA0FF880
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0FF990
        public void __GetType__SystemType(){} // RVA: 0x7FFACA0FFAB0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA0FFBA0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA0FFC80
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA0FFDA0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA0FFF30
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA100080
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA1001B0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA1002D0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA100440
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA100580
        public void __Get__SystemInt32__VRCSDK3MidiMidiDataMidiTrack(){} // RVA: 0x7FFACA1006A0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA100780
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA1007F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA100910
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA100A90
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA100BF0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA100D20
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA100E40
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA100FA0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA1010F0
        public void __Set__SystemInt32_VRCSDK3MidiMidiDataMidiTrack__SystemVoid(){} // RVA: 0x7FFACA101210
        public void __ToString__SystemString(){} // RVA: 0x7FFACA101390
        public void __ctor__SystemInt32__VRCSDK3MidiMidiDataMidiTrackArray(){} // RVA: 0x7FFACA101480
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA101530
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA1015D0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA101670
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA101710
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA1017B0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA101850
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA1018F0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA1019D0
    }

    public class ExternVRCSDK3MidiVRCMidiPlayer : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA1038F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA103930
        public void .ctor(){} // RVA: 0x7FFACA1039E0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA103DB0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA103EE0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA103FF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA1040E0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA104390
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA1044F0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA104610
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA104700
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA104980
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA104A70
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA104D20
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA104E80
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA104FA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA105090
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA105310
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA105480
        public void __GetComponent__T(){} // RVA: 0x7FFACA1055A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA105680
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA1058D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA1059C0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA105CF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA105DE0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA106120
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA106210
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA106520
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA106690
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA1067C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA1068B0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA106BA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA106C90
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA106FD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA1070C0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA1073D0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA107540
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA107680
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA107770
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA107A60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA107B50
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA107E40
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA107F90
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA1080C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA1081B0
        public void __Play__SystemVoid(){} // RVA: 0x7FFACA108460
        public void __Stop__SystemVoid(){} // RVA: 0x7FFACA108510
        public void __get_MidiData__VRCSDK3MidiMidiData(){} // RVA: 0x7FFACA1085C0
        public void __get_Time__SystemSingle(){} // RVA: 0x7FFACA1086A0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA1087D0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA1089D0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA108B50
        public void __set_Time__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA108D50
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA108E90
    }

    public class ExternVRCSDK3MidiVRCMidiPlayerArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA10A9F0
        public void .ctor(){} // RVA: 0x7FFACA10AA30
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA10AE00
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA10AF30
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA10B040
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA10B120
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA10B200
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA10B2D0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA10B420
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA10B4C0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA10B5C0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA10B6E0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA10B7F0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA10B910
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA10BA00
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA10BAE0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA10BC00
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA10BD90
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA10BEE0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA10C010
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA10C130
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA10C2A0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA10C3E0
        public void __Get__SystemInt32__VRCSDK3MidiVRCMidiPlayer(){} // RVA: 0x7FFACA10C500
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA10C640
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA10C6B0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA10C7D0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA10C950
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA10CAB0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA10CBE0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA10CD00
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA10CE60
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA10CFB0
        public void __Set__SystemInt32_VRCSDK3MidiVRCMidiPlayer__SystemVoid(){} // RVA: 0x7FFACA10D0D0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA10D290
        public void __ctor__SystemInt32__VRCSDK3MidiVRCMidiPlayerArray(){} // RVA: 0x7FFACA10D380
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA10D470
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA10D510
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA10D5B0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA10D650
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA10D6F0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA10D790
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA10D830
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA10D910
    }

    public class ExternVRCSDK3NetworkStats : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA10F830
        public void .ctor(){} // RVA: 0x7FFACA10F870
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA10FC40
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA10FD70
        public void __BytesPerSecondAverage__UnityEngineGameObject__SystemSingle(){} // RVA: 0x7FFACA10FE80
        public void __BytesPerSecondAverage__VRCSDKBaseVRCPlayerApi__SystemSingle(){} // RVA: 0x7FFACA10FFB0
        public void __FinalDelay__UnityEngineGameObject__SystemSingle(){} // RVA: 0x7FFACA1100B0
        public void __FinalDelay__VRCSDKBaseVRCPlayerApi__SystemSingle(){} // RVA: 0x7FFACA1101E0
        public void __GroupDelay__UnityEngineGameObject__SystemSingle(){} // RVA: 0x7FFACA1102E0
        public void __GroupDelay__VRCSDKBaseVRCPlayerApi__SystemSingle(){} // RVA: 0x7FFACA110410
        public void __Group__UnityEngineGameObject__SystemInt32(){} // RVA: 0x7FFACA110510
        public void __Group__VRCSDKBaseVRCPlayerApi__SystemInt32(){} // RVA: 0x7FFACA110640
        public void __LastReceiveTime__UnityEngineGameObject__SystemSingle(){} // RVA: 0x7FFACA110740
        public void __LastReceiveTime__VRCSDKBaseVRCPlayerApi__SystemSingle(){} // RVA: 0x7FFACA110870
        public void __LastSendTime__UnityEngineGameObject__SystemSingle(){} // RVA: 0x7FFACA110970
        public void __LastSendTime__VRCSDKBaseVRCPlayerApi__SystemSingle(){} // RVA: 0x7FFACA110AA0
        public void __ReceiveInterval__UnityEngineGameObject__SystemSingle(){} // RVA: 0x7FFACA110BA0
        public void __ReceiveInterval__VRCSDKBaseVRCPlayerApi__SystemSingle(){} // RVA: 0x7FFACA110CD0
        public void __ReliableEventsInOutboundQueue__UnityEngineGameObject__SystemInt32(){} // RVA: 0x7FFACA110DD0
        public void __ReliableEventsInOutboundQueue__VRCSDKBaseVRCPlayerApi__SystemInt32(){} // RVA: 0x7FFACA110F00
        public void __Size__UnityEngineGameObject__SystemInt32(){} // RVA: 0x7FFACA111000
        public void __Size__VRCSDKBaseVRCPlayerApi__SystemInt32(){} // RVA: 0x7FFACA111130
        public void __Sleeping__UnityEngineGameObject__SystemBoolean(){} // RVA: 0x7FFACA111230
        public void __Sleeping__VRCSDKBaseVRCPlayerApi__SystemBoolean(){} // RVA: 0x7FFACA111360
        public void __TotalBytes__UnityEngineGameObject__SystemInt32(){} // RVA: 0x7FFACA111460
        public void __TotalBytes__VRCSDKBaseVRCPlayerApi__SystemInt32(){} // RVA: 0x7FFACA111590
        public void __UpdateInterval__UnityEngineGameObject__SystemSingle(){} // RVA: 0x7FFACA111690
        public void __UpdateInterval__VRCSDKBaseVRCPlayerApi__SystemSingle(){} // RVA: 0x7FFACA1117C0
        public void __get_BytesInAverage__SystemSingle(){} // RVA: 0x7FFACA1118C0
        public void __get_BytesInMax__SystemInt32(){} // RVA: 0x7FFACA111980
        public void __get_BytesOutAverage__SystemSingle(){} // RVA: 0x7FFACA111A40
        public void __get_BytesOutMax__SystemInt32(){} // RVA: 0x7FFACA111B00
        public void __get_HitchesPerNetworkTick__SystemSingle(){} // RVA: 0x7FFACA111BC0
        public void __get_RoundTripTime__SystemInt32(){} // RVA: 0x7FFACA111C80
        public void __get_RoundTripVariance__SystemSingle(){} // RVA: 0x7FFACA111D40
        public void __get_Suffering__SystemSingle(){} // RVA: 0x7FFACA111E00
        public void __get_ThroughputPercentage__SystemSingle(){} // RVA: 0x7FFACA111EC0
        public void __get_TimeInRoom__SystemSingle(){} // RVA: 0x7FFACA111F80
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA112070
    }

    public class ExternVRCSDK3PersistencePlayerData : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA113BD0
        public void .ctor(){} // RVA: 0x7FFACA113C10
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA113FE0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA114110
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA114220
        public void __GetBool__VRCSDKBaseVRCPlayerApi_SystemString__SystemBoolean(){} // RVA: 0x7FFACA114370
        public void __GetByte__VRCSDKBaseVRCPlayerApi_SystemString__SystemByte(){} // RVA: 0x7FFACA114450
        public void __GetBytes__VRCSDKBaseVRCPlayerApi_SystemString__SystemByteArray(){} // RVA: 0x7FFACA114530
        public void __GetColor32__VRCSDKBaseVRCPlayerApi_SystemString__UnityEngineColor32(){} // RVA: 0x7FFACA114600
        public void __GetColor__VRCSDKBaseVRCPlayerApi_SystemString__UnityEngineColor(){} // RVA: 0x7FFACA1146D0
        public void __GetDouble__VRCSDKBaseVRCPlayerApi_SystemString__SystemDouble(){} // RVA: 0x7FFACA114810
        public void __GetFloat__VRCSDKBaseVRCPlayerApi_SystemString__SystemSingle(){} // RVA: 0x7FFACA1148E0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA1149C0
        public void __GetInt__VRCSDKBaseVRCPlayerApi_SystemString__SystemInt32(){} // RVA: 0x7FFACA114AC0
        public void __GetKeys__VRCSDKBaseVRCPlayerApi__SystemCollectionsGenericIEnumerableSystemString(){} // RVA: 0x7FFACA114BA0
        public void __GetLong__VRCSDKBaseVRCPlayerApi_SystemString__SystemInt64(){} // RVA: 0x7FFACA114CB0
        public void __GetQuaternion__VRCSDKBaseVRCPlayerApi_SystemString__UnityEngineQuaternion(){} // RVA: 0x7FFACA114D80
        public void __GetSByte__VRCSDKBaseVRCPlayerApi_SystemString__SystemSByte(){} // RVA: 0x7FFACA114EC0
        public void __GetShort__VRCSDKBaseVRCPlayerApi_SystemString__SystemInt16(){} // RVA: 0x7FFACA114F90
        public void __GetString__VRCSDKBaseVRCPlayerApi_SystemString__SystemString(){} // RVA: 0x7FFACA115060
        public void __GetType__SystemType(){} // RVA: 0x7FFACA115130
        public void __GetType__VRCSDKBaseVRCPlayerApi_SystemString__SystemType(){} // RVA: 0x7FFACA115220
        public void __GetUInt__VRCSDKBaseVRCPlayerApi_SystemString__SystemUInt32(){} // RVA: 0x7FFACA1152F0
        public void __GetULong__VRCSDKBaseVRCPlayerApi_SystemString__SystemUInt64(){} // RVA: 0x7FFACA1153C0
        public void __GetUShort__VRCSDKBaseVRCPlayerApi_SystemString__SystemUInt16(){} // RVA: 0x7FFACA115490
        public void __GetVector2__VRCSDKBaseVRCPlayerApi_SystemString__UnityEngineVector2(){} // RVA: 0x7FFACA115560
        public void __GetVector3__VRCSDKBaseVRCPlayerApi_SystemString__UnityEngineVector3(){} // RVA: 0x7FFACA115630
        public void __GetVector4__VRCSDKBaseVRCPlayerApi_SystemString__UnityEngineVector4(){} // RVA: 0x7FFACA115790
        public void __HasKey__VRCSDKBaseVRCPlayerApi_SystemString__SystemBoolean(){} // RVA: 0x7FFACA1158D0
        public void __IsType__VRCSDKBaseVRCPlayerApi_SystemString_SystemType__SystemBoolean(){} // RVA: 0x7FFACA115A00
        public void __SetBool__SystemString_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA115B60
        public void __SetByte__SystemString_SystemByte__SystemVoid(){} // RVA: 0x7FFACA115C60
        public void __SetBytes__SystemString_SystemByteArray__SystemVoid(){} // RVA: 0x7FFACA115D60
        public void __SetColor32__SystemString_UnityEngineColor32__SystemVoid(){} // RVA: 0x7FFACA115E50
        public void __SetColor__SystemString_UnityEngineColor__SystemVoid(){} // RVA: 0x7FFACA115F40
        public void __SetDouble__SystemString_SystemDouble__SystemVoid(){} // RVA: 0x7FFACA116050
        public void __SetFloat__SystemString_SystemSingle__SystemVoid(){} // RVA: 0x7FFACA116150
        public void __SetInt__SystemString_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA116260
        public void __SetLong__SystemString_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA116360
        public void __SetQuaternion__SystemString_UnityEngineQuaternion__SystemVoid(){} // RVA: 0x7FFACA116450
        public void __SetSByte__SystemString_SystemSByte__SystemVoid(){} // RVA: 0x7FFACA116560
        public void __SetShort__SystemString_SystemInt16__SystemVoid(){} // RVA: 0x7FFACA116650
        public void __SetString__SystemString_SystemString__SystemVoid(){} // RVA: 0x7FFACA116740
        public void __SetUInt__SystemString_SystemUInt32__SystemVoid(){} // RVA: 0x7FFACA116820
        public void __SetULong__SystemString_SystemUInt64__SystemVoid(){} // RVA: 0x7FFACA116920
        public void __SetUShort__SystemString_SystemUInt16__SystemVoid(){} // RVA: 0x7FFACA116A10
        public void __SetVector2__SystemString_UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA116B00
        public void __SetVector3__SystemString_UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA116C00
        public void __SetVector4__SystemString_UnityEngineVector4__SystemVoid(){} // RVA: 0x7FFACA116D20
        public void __ToString__SystemString(){} // RVA: 0x7FFACA116E30
        public void __TryGetBool__VRCSDKBaseVRCPlayerApi_SystemString_SystemBooleanRef__SystemBoolean(){} // RVA: 0x7FFACA116F20
        public void __TryGetByte__VRCSDKBaseVRCPlayerApi_SystemString_SystemByteRef__SystemBoolean(){} // RVA: 0x7FFACA117100
        public void __TryGetBytes__VRCSDKBaseVRCPlayerApi_SystemString_SystemByteArrayRef__SystemBoolean(){} // RVA: 0x7FFACA1172F0
        public void __TryGetColor32__VRCSDKBaseVRCPlayerApi_SystemString_UnityEngineColor32Ref__SystemBoolean(){} // RVA: 0x7FFACA117590
        public void __TryGetColor__VRCSDKBaseVRCPlayerApi_SystemString_UnityEngineColorRef__SystemBoolean(){} // RVA: 0x7FFACA117770
        public void __TryGetDouble__VRCSDKBaseVRCPlayerApi_SystemString_SystemDoubleRef__SystemBoolean(){} // RVA: 0x7FFACA1179B0
        public void __TryGetFloat__VRCSDKBaseVRCPlayerApi_SystemString_SystemSingleRef__SystemBoolean(){} // RVA: 0x7FFACA117B90
        public void __TryGetInt__VRCSDKBaseVRCPlayerApi_SystemString_SystemInt32Ref__SystemBoolean(){} // RVA: 0x7FFACA117D80
        public void __TryGetLong__VRCSDKBaseVRCPlayerApi_SystemString_SystemInt64Ref__SystemBoolean(){} // RVA: 0x7FFACA117F80
        public void __TryGetQuaternion__VRCSDKBaseVRCPlayerApi_SystemString_UnityEngineQuaternionRef__SystemBoolean(){} // RVA: 0x7FFACA118170
        public void __TryGetSByte__VRCSDKBaseVRCPlayerApi_SystemString_SystemSByteRef__SystemBoolean(){} // RVA: 0x7FFACA1183B0
        public void __TryGetShort__VRCSDKBaseVRCPlayerApi_SystemString_SystemInt16Ref__SystemBoolean(){} // RVA: 0x7FFACA118590
        public void __TryGetString__VRCSDKBaseVRCPlayerApi_SystemString_SystemStringRef__SystemBoolean(){} // RVA: 0x7FFACA118780
        public void __TryGetType__VRCSDKBaseVRCPlayerApi_SystemString_SystemTypeRef__SystemBoolean(){} // RVA: 0x7FFACA118A20
        public void __TryGetUInt__VRCSDKBaseVRCPlayerApi_SystemString_SystemUInt32Ref__SystemBoolean(){} // RVA: 0x7FFACA118BC0
        public void __TryGetULong__VRCSDKBaseVRCPlayerApi_SystemString_SystemUInt64Ref__SystemBoolean(){} // RVA: 0x7FFACA118DB0
        public void __TryGetUShort__VRCSDKBaseVRCPlayerApi_SystemString_SystemUInt16Ref__SystemBoolean(){} // RVA: 0x7FFACA118FA0
        public void __TryGetVector2__VRCSDKBaseVRCPlayerApi_SystemString_UnityEngineVector2Ref__SystemBoolean(){} // RVA: 0x7FFACA119190
        public void __TryGetVector3__VRCSDKBaseVRCPlayerApi_SystemString_UnityEngineVector3Ref__SystemBoolean(){} // RVA: 0x7FFACA119390
        public void __TryGetVector4__VRCSDKBaseVRCPlayerApi_SystemString_UnityEngineVector4Ref__SystemBoolean(){} // RVA: 0x7FFACA1195F0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA119830
    }

    public class ExternVRCSDK3PersistencePlayerDataInfo : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA11CB90
        public void .ctor(){} // RVA: 0x7FFACA11CBD0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA11CFA0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA11D0D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA11D1E0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA11D320
        public void __GetType__SystemType(){} // RVA: 0x7FFACA11D3D0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA11D4C0
        public void __ctor__SystemString_VRCSDK3PersistencePlayerDataState__VRCSDK3PersistencePlayerDataInfo(){} // RVA: 0x7FFACA11D570
        public void __get_Key__SystemString(){} // RVA: 0x7FFACA11D6B0
        public void __get_State__VRCSDK3PersistencePlayerDataState(){} // RVA: 0x7FFACA11D790
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA11D870
    }

    public class ExternVRCSDK3PersistencePlayerDataInfoArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA11DF90
        public void .ctor(){} // RVA: 0x7FFACA11DFD0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA11E3A0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA11E4D0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA11E5E0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA11E6C0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA11E7A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA11E870
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA11E9C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA11EA60
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA11EB60
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA11EC80
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA11ED90
        public void __GetType__SystemType(){} // RVA: 0x7FFACA11EEB0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA11EFA0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA11F080
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA11F1A0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA11F330
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA11F480
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA11F5B0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA11F6D0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA11F840
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA11F980
        public void __Get__SystemInt32__VRCSDK3PersistencePlayerDataInfo(){} // RVA: 0x7FFACA11FAA0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA11FB90
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA11FC00
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA11FD20
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA11FEA0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA120000
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA120130
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA120250
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA1203B0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA120500
        public void __Set__SystemInt32_VRCSDK3PersistencePlayerDataInfo__SystemVoid(){} // RVA: 0x7FFACA120620
        public void __ToString__SystemString(){} // RVA: 0x7FFACA120780
        public void __ctor__SystemInt32__VRCSDK3PersistencePlayerDataInfoArray(){} // RVA: 0x7FFACA120870
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA120A10
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA120AB0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA120B50
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA120BF0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA120C90
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA120D30
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA120DD0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA120EB0
    }

    public class ExternVRCSDK3PlatformScreenUpdateData : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA122DD0
        public void .ctor(){} // RVA: 0x7FFACA122E10
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA1231E0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA123310
        public void __get_orientation__VRCSDKBasePlatformVRCOrientation(){} // RVA: 0x7FFACA123420
        public void __get_resolution__UnityEngineVector2(){} // RVA: 0x7FFACA123500
        public void __get_type__VRCSDK3PlatformScreenUpdateType(){} // RVA: 0x7FFACA1235E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA1236C0
    }

    public class ExternVRCSDK3PropsVRCPropApi : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA123AE0
        public void .ctor(){} // RVA: 0x7FFACA123B20
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA123EF0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA124020
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA124130
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA124280
        public void __GetIsConsumable__SystemBoolean(){} // RVA: 0x7FFACA124380
        public void __GetIsPlayingConsumableEffect__SystemBoolean(){} // RVA: 0x7FFACA124430
        public void __GetItemId__SystemString(){} // RVA: 0x7FFACA1244E0
        public void __GetNearestPlayerInRange__SystemSingle__VRCSDKBaseVRCPlayerApi(){} // RVA: 0x7FFACA124590
        public void __GetPlayersInRange__SystemSingle_VRCSDKBaseVRCPlayerApiArray__SystemInt32(){} // RVA: 0x7FFACA124680
        public void __GetPlayersInRange__SystemSingle__VRCSDKBaseVRCPlayerApiArray(){} // RVA: 0x7FFACA1247B0
        public void __GetPosition__UnityEngineVector3(){} // RVA: 0x7FFACA1248A0
        public void __GetPropId__SystemString(){} // RVA: 0x7FFACA124960
        public void __GetQuantity__SystemInt32(){} // RVA: 0x7FFACA124A10
        public void __GetRotation__UnityEngineQuaternion(){} // RVA: 0x7FFACA124AC0
        public void __GetScale__UnityEngineVector3(){} // RVA: 0x7FFACA124B80
        public void __GetSpawner__VRCSDKBaseVRCPlayerApi(){} // RVA: 0x7FFACA124C40
        public void __GetType__SystemType(){} // RVA: 0x7FFACA124CF0
        public void __GetUserAttributes__VRCSDK3DataDataDictionary(){} // RVA: 0x7FFACA124DE0
        public void __ManuallyRecordInteractionEvent__VRCSDKBaseVRCPlayerApi__SystemVoid(){} // RVA: 0x7FFACA124E90
        public void __RequestConsume__SystemBoolean(){} // RVA: 0x7FFACA124F50
        public void __RequestDespawn__SystemBoolean(){} // RVA: 0x7FFACA125000
        public void __SetUserAttributes__VRCSDK3DataDataDictionary__SystemVoid(){} // RVA: 0x7FFACA1250B0
        public void __StartPlayingConsumableEffect__SystemVoid(){} // RVA: 0x7FFACA125170
        public void __StopPlayingConsumableEffect__SystemVoid(){} // RVA: 0x7FFACA1251F0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA125270
        public void __TryGetProp__VRCSDK3PropsVRCPropApiRef__SystemBoolean(){} // RVA: 0x7FFACA125360
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA1254B0
    }

    public class ExternVRCSDK3PropsVRCPropApiArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA126890
        public void .ctor(){} // RVA: 0x7FFACA1268D0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA126CA0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA126DD0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA126EE0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA126FC0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA1270A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA127170
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA1272C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA127360
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA127460
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA127580
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA127690
        public void __GetType__SystemType(){} // RVA: 0x7FFACA1277B0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA1278A0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA127980
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA127AA0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA127C30
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA127D80
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA127EB0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA127FD0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA128140
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA128280
        public void __Get__SystemInt32__VRCSDK3PropsVRCPropApi(){} // RVA: 0x7FFACA1283A0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA128480
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA1284F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA128610
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA128790
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA1288F0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA128A20
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA128B40
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA128CA0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA128DF0
        public void __Set__SystemInt32_VRCSDK3PropsVRCPropApi__SystemVoid(){} // RVA: 0x7FFACA128F10
        public void __ToString__SystemString(){} // RVA: 0x7FFACA129090
        public void __ctor__SystemInt32__VRCSDK3PropsVRCPropApiArray(){} // RVA: 0x7FFACA129180
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA129320
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA1293C0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA129460
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA129500
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA1295A0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA129640
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA1296E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA1297C0
    }

    public class ExternVRCSDK3RenderingVRCAsyncGPUReadback : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA12B6E0
        public void .ctor(){} // RVA: 0x7FFACA12B720
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA12BAF0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA12BC20
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA12BD30
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA12BE80
        public void __GetType__SystemType(){} // RVA: 0x7FFACA12BF80
        public void __Request__UnityEngineTexture_SystemInt32_SystemInt32_SystemInt32_SystemInt32_SystemInt32_SystemInt32_SystemInt32_UnityEngineTextureFormat_VRCUdonCommonInterfacesIUdonEventReceiver__VRCSDK3RenderingVRCAsyncGPUReadbackRequest(){} // RVA: 0x7FFACA12C070
        public void __Request__UnityEngineTexture_SystemInt32_SystemInt32_SystemInt32_SystemInt32_SystemInt32_SystemInt32_SystemInt32_VRCUdonCommonInterfacesIUdonEventReceiver__VRCSDK3RenderingVRCAsyncGPUReadbackRequest(){} // RVA: 0x7FFACA12C420
        public void __Request__UnityEngineTexture_SystemInt32_UnityEngineTextureFormat_VRCUdonCommonInterfacesIUdonEventReceiver__VRCSDK3RenderingVRCAsyncGPUReadbackRequest(){} // RVA: 0x7FFACA12C690
        public void __Request__UnityEngineTexture_SystemInt32_VRCUdonCommonInterfacesIUdonEventReceiver__VRCSDK3RenderingVRCAsyncGPUReadbackRequest(){} // RVA: 0x7FFACA12C930
        public void __ToString__SystemString(){} // RVA: 0x7FFACA12CB70
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA12CC60
    }

    public class ExternVRCSDK3RenderingVRCAsyncGPUReadbackRequest : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA12D440
        public void .ctor(){} // RVA: 0x7FFACA12D480
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA12D850
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA12D980
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA12DA90
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA12DBE0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA12DCE0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA12DDD0
        public void __TryGetData__SystemByteArray_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACA12DEC0
        public void __TryGetData__SystemSingleArray_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACA12E020
        public void __TryGetData__UnityEngineColor32Array_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACA12E180
        public void __TryGetData__UnityEngineColorArray_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACA12E2E0
        public void __get_depth__SystemInt32(){} // RVA: 0x7FFACA12E440
        public void __get_done__SystemBoolean(){} // RVA: 0x7FFACA12E530
        public void __get_hasError__SystemBoolean(){} // RVA: 0x7FFACA12E620
        public void __get_height__SystemInt32(){} // RVA: 0x7FFACA12E710
        public void __get_layerCount__SystemInt32(){} // RVA: 0x7FFACA12E800
        public void __get_layerDataSize__SystemInt32(){} // RVA: 0x7FFACA12E8F0
        public void __get_width__SystemInt32(){} // RVA: 0x7FFACA12E9E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA12EAD0
    }

    public class ExternVRCSDK3RenderingVRCAsyncGPUReadbackRequestArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA12F7F0
        public void .ctor(){} // RVA: 0x7FFACA12F830
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA12FC00
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA12FD30
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA12FE40
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA12FF20
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA130000
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA1300D0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA130220
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA1302C0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA1303C0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA1304E0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA1305F0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA130710
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA130800
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA1308E0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA130A00
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA130B90
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA130CE0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA130E10
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA130F30
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA1310A0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA1311E0
        public void __Get__SystemInt32__VRCSDK3RenderingVRCAsyncGPUReadbackRequest(){} // RVA: 0x7FFACA131300
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA1313E0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA131450
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA131570
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA1316F0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA131850
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA131980
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA131AA0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA131C00
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA131D50
        public void __Set__SystemInt32_VRCSDK3RenderingVRCAsyncGPUReadbackRequest__SystemVoid(){} // RVA: 0x7FFACA131E70
        public void __ToString__SystemString(){} // RVA: 0x7FFACA131FF0
        public void __ctor__SystemInt32__VRCSDK3RenderingVRCAsyncGPUReadbackRequestArray(){} // RVA: 0x7FFACA1320E0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA132280
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA132320
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA1323C0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA132460
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA132500
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA1325A0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA132640
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA132720
    }

    public class ExternVRCSDK3RenderingVRCCameraSettings : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA134640
        public void .ctor(){} // RVA: 0x7FFACA134680
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA134A50
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA134B80
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA134C90
        public void __GetCurrentCamera__VRCSDK3RenderingVRCCameraSettingsRef_UnityEngineCameraRef__SystemVoid(){} // RVA: 0x7FFACA134DD0
        public void __GetEyePosition__UnityEngineCameraStereoscopicEye__UnityEngineVector3(){} // RVA: 0x7FFACA134EF0
        public void __GetEyeRotation__UnityEngineCameraStereoscopicEye__UnityEngineQuaternion(){} // RVA: 0x7FFACA134FE0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA1350C0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA135170
        public void __ToString__SystemString(){} // RVA: 0x7FFACA135260
        public void __get_Active__SystemBoolean(){} // RVA: 0x7FFACA135310
        public void __get_AllowHDR__SystemBoolean(){} // RVA: 0x7FFACA1353B0
        public void __get_AllowMSAA__SystemBoolean(){} // RVA: 0x7FFACA1354A0
        public void __get_Aspect__SystemSingle(){} // RVA: 0x7FFACA135590
        public void __get_BackgroundColor__UnityEngineColor(){} // RVA: 0x7FFACA135680
        public void __get_CameraMode__VRCSDK3RenderingVRCCameraMode(){} // RVA: 0x7FFACA135790
        public void __get_ClearFlags__UnityEngineCameraClearFlags(){} // RVA: 0x7FFACA135850
        public void __get_CullingMask__UnityEngineLayerMask(){} // RVA: 0x7FFACA135940
        public void __get_DepthTextureMode__UnityEngineDepthTextureMode(){} // RVA: 0x7FFACA135A30
        public void __get_FarClipPlane__SystemSingle(){} // RVA: 0x7FFACA135B20
        public void __get_FieldOfView__SystemSingle(){} // RVA: 0x7FFACA135C10
        public void __get_Forward__UnityEngineVector3(){} // RVA: 0x7FFACA135D00
        public void __get_LayerCullDistances__SystemSingleArray(){} // RVA: 0x7FFACA135E40
        public void __get_LayerCullSpherical__SystemBoolean(){} // RVA: 0x7FFACA135F30
        public void __get_NearClipPlane__SystemSingle(){} // RVA: 0x7FFACA135FD0
        public void __get_PhotoCamera__VRCSDK3RenderingVRCCameraSettings(){} // RVA: 0x7FFACA1360C0
        public void __get_PixelHeight__SystemInt32(){} // RVA: 0x7FFACA136190
        public void __get_PixelWidth__SystemInt32(){} // RVA: 0x7FFACA136280
        public void __get_Position__UnityEngineVector3(){} // RVA: 0x7FFACA136370
        public void __get_Right__UnityEngineVector3(){} // RVA: 0x7FFACA1364F0
        public void __get_Rotation__UnityEngineQuaternion(){} // RVA: 0x7FFACA136630
        public void __get_ScreenCamera__VRCSDK3RenderingVRCCameraSettings(){} // RVA: 0x7FFACA1367A0
        public void __get_StereoEnabled__SystemBoolean(){} // RVA: 0x7FFACA136870
        public void __get_Up__UnityEngineVector3(){} // RVA: 0x7FFACA136960
        public void __get_UseOcclusionCulling__SystemBoolean(){} // RVA: 0x7FFACA136AA0
        public void __set_AllowHDR__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA136B90
        public void __set_AllowMSAA__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA136D00
        public void __set_BackgroundColor__UnityEngineColor__SystemVoid(){} // RVA: 0x7FFACA136E70
        public void __set_ClearFlags__UnityEngineCameraClearFlags__SystemVoid(){} // RVA: 0x7FFACA136FF0
        public void __set_CullingMask__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA137160
        public void __set_DepthTextureMode__UnityEngineDepthTextureMode__SystemVoid(){} // RVA: 0x7FFACA137210
        public void __set_FarClipPlane__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA1372C0
        public void __set_LayerCullDistances__SystemSingleArray__SystemVoid(){} // RVA: 0x7FFACA137440
        public void __set_LayerCullSpherical__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA137560
        public void __set_NearClipPlane__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA1376E0
        public void __set_UseOcclusionCulling__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA137850
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA1379C0
    }

    public class ExternVRCSDK3RenderingVRCCameraSettingsArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA139BD0
        public void .ctor(){} // RVA: 0x7FFACA139C10
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA139FE0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA13A110
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA13A220
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA13A300
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA13A3E0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA13A4B0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA13A600
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA13A6A0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA13A7A0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA13A8C0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA13A9D0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA13AAF0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA13ABE0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA13ACC0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA13ADE0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA13AF70
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA13B0C0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA13B1F0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA13B310
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA13B480
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA13B5C0
        public void __Get__SystemInt32__VRCSDK3RenderingVRCCameraSettings(){} // RVA: 0x7FFACA13B6E0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA13B7C0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA13B830
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA13B950
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA13BAD0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA13BC30
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA13BD60
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA13BE80
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA13BFE0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA13C130
        public void __Set__SystemInt32_VRCSDK3RenderingVRCCameraSettings__SystemVoid(){} // RVA: 0x7FFACA13C250
        public void __ToString__SystemString(){} // RVA: 0x7FFACA13C3D0
        public void __ctor__SystemInt32__VRCSDK3RenderingVRCCameraSettingsArray(){} // RVA: 0x7FFACA13C4C0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA13C660
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA13C700
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA13C7A0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA13C840
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA13C8E0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA13C980
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA13CA20
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA13CB00
    }

    public class ExternVRCSDK3RenderingVRCQualitySettings : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA13EA20
        public void .ctor(){} // RVA: 0x7FFACA13EA60
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA13EE30
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA13EF60
        public void __ResetShadowDistance__SystemVoid(){} // RVA: 0x7FFACA13F070
        public void __SetShadowDistance__SystemSingle_SystemSingle_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x7FFACA13F0D0
        public void __SetShadowDistance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA13F240
        public void __get_AntiAliasing__SystemInt32(){} // RVA: 0x7FFACA13F310
        public void __get_LODBias__SystemSingle(){} // RVA: 0x7FFACA13F3C0
        public void __get_MaximumLODLevel__SystemInt32(){} // RVA: 0x7FFACA13F470
        public void __get_PixelLightCount__SystemInt32(){} // RVA: 0x7FFACA13F520
        public void __get_ShadowCascade2Split__SystemSingle(){} // RVA: 0x7FFACA13F5D0
        public void __get_ShadowCascade4Split__UnityEngineVector3(){} // RVA: 0x7FFACA13F680
        public void __get_ShadowCascades__SystemInt32(){} // RVA: 0x7FFACA13F750
        public void __get_ShadowDistance__SystemSingle(){} // RVA: 0x7FFACA13F800
        public void __get_ShadowResolution__UnityEngineShadowResolution(){} // RVA: 0x7FFACA13F8B0
        public void __get_VSyncCount__SystemInt32(){} // RVA: 0x7FFACA13F960
        public void __set_ShadowCascade2Split__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA13FA10
        public void __set_ShadowCascade4Split__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA13FAD0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA13FB90
    }

    public class ExternVRCSDK3StringLoadingIVRCStringDownload : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA1408B0
        public void .ctor(){} // RVA: 0x7FFACA1408F0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA140CC0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA140DF0
        public void __get_ErrorCode__SystemInt32(){} // RVA: 0x7FFACA140F00
        public void __get_Error__SystemString(){} // RVA: 0x7FFACA140FD0
        public void __get_ResultBytes__SystemByteArray(){} // RVA: 0x7FFACA141090
        public void __get_Result__SystemString(){} // RVA: 0x7FFACA141150
        public void __get_UdonBehaviour__VRCUdonCommonInterfacesIUdonEventReceiver(){} // RVA: 0x7FFACA141210
        public void __get_Url__VRCSDKBaseVRCUrl(){} // RVA: 0x7FFACA1412E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA1413A0
    }

    public class ExternVRCSDK3StringLoadingVRCStringDownloader : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA1419F0
        public void .ctor(){} // RVA: 0x7FFACA141A30
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA141E00
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA141F30
        public void __LoadUrl__VRCSDKBaseVRCUrl_VRCUdonCommonInterfacesIUdonEventReceiver__SystemVoid(){} // RVA: 0x7FFACA142040
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA1421B0
    }

    public class ExternVRCSDK3UdonNetworkCallingNetworkCalling : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA142440
        public void .ctor(){} // RVA: 0x7FFACA142480
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA142850
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA142980
        public void __GetAllQueuedEvents__SystemInt32(){} // RVA: 0x7FFACA142A90
        public void __GetQueuedEvents__VRCUdonCommonInterfacesIUdonEventReceiver_SystemString__SystemInt32(){} // RVA: 0x7FFACA142C20
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesIUdonEventReceiver_VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFACA142E30
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesIUdonEventReceiver_VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFACA143210
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesIUdonEventReceiver_VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFACA1435E0
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesIUdonEventReceiver_VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFACA143950
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesIUdonEventReceiver_VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFACA143C60
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesIUdonEventReceiver_VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFACA143F10
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesIUdonEventReceiver_VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFACA144160
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesIUdonEventReceiver_VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject__SystemVoid(){} // RVA: 0x7FFACA144350
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesIUdonEventReceiver_VRCUdonCommonInterfacesNetworkEventTarget_SystemString__SystemVoid(){} // RVA: 0x7FFACA1444F0
        public void __get_CallingPlayer__VRCSDKBaseVRCPlayerApi(){} // RVA: 0x7FFACA144610
        public void __get_InNetworkCall__SystemBoolean(){} // RVA: 0x7FFACA1446E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA1447C0
    }

    public class ExternVRCSDK3VideoComponentsBaseBaseVRCVideoPlayer : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA145350
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA145390
        public void .ctor(){} // RVA: 0x7FFACA145440
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA145810
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA145940
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA145A50
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA145BB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA145CA0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA145F50
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA1460B0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA1461D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA1462C0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA146540
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA146630
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA1468E0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA146A40
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA146B60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA146C50
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA146ED0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA147040
        public void __GetComponent__T(){} // RVA: 0x7FFACA147160
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA147240
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA147490
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA147580
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA1478B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA1479A0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA147CE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA147DD0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA1480E0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA148250
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA148380
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA148470
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA148760
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA148850
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA148B90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA148C80
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA148F90
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA149100
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA149240
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA149330
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA149620
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA149710
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA149A00
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA149B50
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA149C80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA149D70
        public void __GetDuration__SystemSingle(){} // RVA: 0x7FFACA14A020
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA14A110
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA14A200
        public void __GetTime__SystemSingle(){} // RVA: 0x7FFACA14A2E0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA14A3D0
        public void __LoadURL__VRCSDKBaseVRCUrl__SystemVoid(){} // RVA: 0x7FFACA14A4C0
        public void __Pause__SystemVoid(){} // RVA: 0x7FFACA14A5A0
        public void __PlayURL__VRCSDKBaseVRCUrl__SystemVoid(){} // RVA: 0x7FFACA14A660
        public void __Play__SystemVoid(){} // RVA: 0x7FFACA14A740
        public void __SetTime__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA14A800
        public void __Stop__SystemVoid(){} // RVA: 0x7FFACA14A8F0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA14A9B0
        public void __get_EnableAutomaticResync__SystemBoolean(){} // RVA: 0x7FFACA14AA90
        public void __set_EnableAutomaticResync__SystemBoolean(){} // RVA: 0x7FFACA14AB70
        public void __get_IsPlaying__SystemBoolean(){} // RVA: 0x7FFACA14AC50
        public void __get_IsReady__SystemBoolean(){} // RVA: 0x7FFACA14AD40
        public void __get_Loop__SystemBoolean(){} // RVA: 0x7FFACA14AE30
        public void __get_VideoHeight__SystemInt32(){} // RVA: 0x7FFACA14AF20
        public void __get_VideoWidth__SystemInt32(){} // RVA: 0x7FFACA14B010
        public void __get_destroyCancellationToken__SystemThreadingCancellationToken(){} // RVA: 0x7FFACA14B100
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA14B1E0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA14B300
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACA14B440
        public void __get_name__SystemString(){} // RVA: 0x7FFACA14B560
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA14B640
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA14B780
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA14B980
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA14BB00
        public void __set_Loop__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA14BD00
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA14BDF0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA14BF20
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA14C000
    }

    public class ExternVRCSDK3VideoComponentsBaseBaseVRCVideoPlayerArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA14ED60
        public void .ctor(){} // RVA: 0x7FFACA14EDA0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA14F170
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA14F2A0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA14F3B0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA14F490
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA14F570
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA14F640
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA14F790
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA14F830
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA14F930
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA14FA50
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA14FB60
        public void __GetType__SystemType(){} // RVA: 0x7FFACA14FC80
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA14FD70
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA14FE50
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA14FF70
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA150100
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA150250
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA150380
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA1504A0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA150610
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA150750
        public void __Get__SystemInt32__VRCSDK3VideoComponentsBaseBaseVRCVideoPlayer(){} // RVA: 0x7FFACA150870
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA1509B0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA150A20
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA150B40
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA150CC0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA150E20
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA150F50
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA151070
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA1511D0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA151320
        public void __Set__SystemInt32_VRCSDK3VideoComponentsBaseBaseVRCVideoPlayer__SystemVoid(){} // RVA: 0x7FFACA151440
        public void __ToString__SystemString(){} // RVA: 0x7FFACA151600
        public void __ctor__SystemInt32__VRCSDK3VideoComponentsBaseBaseVRCVideoPlayerArray(){} // RVA: 0x7FFACA1516F0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA1517E0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA151880
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA151920
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA1519C0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA151A60
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA151B00
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA151BA0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA151C80
    }

    public class ExternVRCSDKBaseInputManager : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA153BA0
        public void .ctor(){} // RVA: 0x7FFACA153BE0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA153FB0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA1540E0
        public void __EnableObjectHighlight__UnityEngineGameObject_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA1541F0
        public void __EnableObjectHighlight__UnityEngineRenderer_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA1543B0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA154490
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA1545E0
        public void __GetLastUsedInputMethod__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFACA1546E0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA1547B0
        public void __IsUsingHandController__SystemBoolean(){} // RVA: 0x7FFACA1548A0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA154960
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA154A50
    }

    public class ExternVRCSDKBaseNetworking : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA155230
        public void .ctor(){} // RVA: 0x7FFACA155270
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA155640
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA155770
        public void __CalculateServerDeltaTime__SystemDouble_SystemDouble__SystemDouble(){} // RVA: 0x7FFACA155880
        public void __Destroy__UnityEngineGameObject__SystemVoid(){} // RVA: 0x7FFACA1559B0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA155AB0
        public void __FindComponentInPlayerObjects__VRCSDKBaseVRCPlayerApi_UnityEngineComponent__UnityEngineComponent(){} // RVA: 0x7FFACA155C00
        public void __GetEventDispatcher__VRCSDKBaseVRC_EventDispatcher(){} // RVA: 0x7FFACA155D20
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA155F60
        public void __GetNetworkDateTime__SystemDateTime(){} // RVA: 0x7FFACA156060
        public void __GetOwner__UnityEngineGameObject__VRCSDKBaseVRCPlayerApi(){} // RVA: 0x7FFACA156150
        public void __GetPlayerDataStorageLimit__SystemInt32(){} // RVA: 0x7FFACA156270
        public void __GetPlayerDataStorageUsage__VRCSDKBaseVRCPlayerApi__SystemInt32(){} // RVA: 0x7FFACA156330
        public void __GetPlayerObjectStorageLimit__SystemInt32(){} // RVA: 0x7FFACA156430
        public void __GetPlayerObjectStorageUsage__VRCSDKBaseVRCPlayerApi__SystemInt32(){} // RVA: 0x7FFACA1564F0
        public void __GetPlayerObjects__VRCSDKBaseVRCPlayerApi__UnityEngineGameObjectArray(){} // RVA: 0x7FFACA1565F0
        public void __GetServerTimeInMilliseconds__SystemInt32(){} // RVA: 0x7FFACA156750
        public void __GetServerTimeInSeconds__SystemDouble(){} // RVA: 0x7FFACA1567D0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA1568D0
        public void __GetUniqueName__UnityEngineGameObject__SystemString(){} // RVA: 0x7FFACA1569C0
        public void __IsObjectReady__UnityEngineGameObject__SystemBoolean(){} // RVA: 0x7FFACA156AE0
        public void __IsOwner__UnityEngineGameObject__SystemBoolean(){} // RVA: 0x7FFACA156C10
        public void __IsOwner__VRCSDKBaseVRCPlayerApi_UnityEngineGameObject__SystemBoolean(){} // RVA: 0x7FFACA156CF0
        public void __RequestStorageUsageUpdate__SystemVoid(){} // RVA: 0x7FFACA156E60
        public void __SetOwner__VRCSDKBaseVRCPlayerApi_UnityEngineGameObject__SystemVoid(){} // RVA: 0x7FFACA156EC0
        public void __SimulationTime__UnityEngineGameObject__SystemSingle(){} // RVA: 0x7FFACA156FA0
        public void __SimulationTime__VRCSDKBaseVRCPlayerApi__SystemSingle(){} // RVA: 0x7FFACA157110
        public void __ToString__SystemString(){} // RVA: 0x7FFACA157250
        public void __get_InstanceOwner__VRCSDKBaseVRCPlayerApi(){} // RVA: 0x7FFACA157340
        public void __get_IsClogged__SystemBoolean(){} // RVA: 0x7FFACA1573F0
        public void __get_IsInstanceOwner__SystemBoolean(){} // RVA: 0x7FFACA1574B0
        public void __get_IsMaster__SystemBoolean(){} // RVA: 0x7FFACA157570
        public void __get_IsNetworkSettled__SystemBoolean(){} // RVA: 0x7FFACA157630
        public void __get_LocalPlayer__VRCSDKBaseVRCPlayerApi(){} // RVA: 0x7FFACA1576F0
        public void __get_Master__VRCSDKBaseVRCPlayerApi(){} // RVA: 0x7FFACA1577A0
        public void __get_SceneEventHandler__VRCSDKBaseVRC_EventHandler(){} // RVA: 0x7FFACA157850
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA157A90
    }

    public class ExternVRCSDKBaseUtilities : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA159530
        public void .ctor(){} // RVA: 0x7FFACA159570
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA159940
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA159A70
        public void __IsValid__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA159B80
        public void __ShuffleArray__SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA159C70
        public void __ShuffleArray__TArray__SystemVoid(){} // RVA: 0x7FFACA159CE0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA159D60
    }

    public class ExternVRCSDKBaseVRCCustomAction : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA15A180
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA15A1C0
        public void .ctor(){} // RVA: 0x7FFACA15A270
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA15A640
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA15A770
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA15A880
        public void __Execute__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA15A9E0
        public void __Execute__SystemString__SystemVoid(){} // RVA: 0x7FFACA15AAD0
        public void __Execute__VRCSDKBaseVRCUrl__SystemVoid(){} // RVA: 0x7FFACA15ABB0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA15AC90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA15AD80
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA15B030
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA15B190
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA15B2B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA15B3A0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA15B620
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA15B710
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA15B9C0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA15BB20
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA15BC40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA15BD30
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA15BFB0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA15C120
        public void __GetComponent__T(){} // RVA: 0x7FFACA15C240
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA15C320
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA15C570
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA15C660
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA15C990
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA15CA80
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA15CDC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA15CEB0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA15D1C0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA15D330
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA15D460
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA15D550
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA15D840
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA15D930
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA15DC70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA15DD60
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA15E070
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA15E1E0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA15E320
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA15E410
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA15E700
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA15E7F0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA15EAE0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA15EC30
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA15ED60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA15EE50
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA15F100
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA15F1F0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA15F2D0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA15F3C0
        public void __get_destroyCancellationToken__SystemThreadingCancellationToken(){} // RVA: 0x7FFACA15F4A0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA15F580
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA15F6A0
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACA15F7E0
        public void __get_name__SystemString(){} // RVA: 0x7FFACA15F900
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA15F9E0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA15FB20
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA15FD20
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA15FEA0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA1600A0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA1601D0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA1602B0
    }

    public class ExternVRCSDKBaseVRCCustomActionArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA162640
        public void .ctor(){} // RVA: 0x7FFACA162680
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA162A50
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA162B80
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA162C90
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA162D70
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA162E50
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA162F20
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA163070
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA163110
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA163210
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA163330
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA163440
        public void __GetType__SystemType(){} // RVA: 0x7FFACA163560
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA163650
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA163730
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA163850
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA1639E0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA163B30
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA163C60
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA163D80
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA163EF0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA164030
        public void __Get__SystemInt32__VRCSDKBaseVRCCustomAction(){} // RVA: 0x7FFACA164150
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA164290
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA164300
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA164420
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA1645A0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA164700
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA164830
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA164950
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA164AB0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA164C00
        public void __Set__SystemInt32_VRCSDKBaseVRCCustomAction__SystemVoid(){} // RVA: 0x7FFACA164D20
        public void __ToString__SystemString(){} // RVA: 0x7FFACA164EE0
        public void __ctor__SystemInt32__VRCSDKBaseVRCCustomActionArray(){} // RVA: 0x7FFACA164FD0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA1650C0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA165160
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA165200
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA1652A0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA165340
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA1653E0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA165480
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA165560
    }

    public class ExternVRCSDKBaseVRCDroneApi : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA167480
        public void .ctor(){} // RVA: 0x7FFACA1674C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA167890
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA1679C0
        public void __GetPlayer__VRCSDKBaseVRCPlayerApi(){} // RVA: 0x7FFACA167AD0
        public void __GetPosition__UnityEngineVector3(){} // RVA: 0x7FFACA167B80
        public void __GetRotation__UnityEngineQuaternion(){} // RVA: 0x7FFACA167C40
        public void __GetVelocity__UnityEngineVector3(){} // RVA: 0x7FFACA167D00
        public void __IsDeployed__SystemBoolean(){} // RVA: 0x7FFACA167DC0
        public void __SetVelocity__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA167E70
        public void __TeleportTo__UnityEngineVector3_UnityEngineQuaternion_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA167F40
        public void __TeleportTo__UnityEngineVector3_UnityEngineQuaternion__SystemVoid(){} // RVA: 0x7FFACA1680C0
        public void __TryGetPosition__UnityEngineVector3Ref__SystemBoolean(){} // RVA: 0x7FFACA1681F0
        public void __TryGetRotation__UnityEngineQuaternionRef__SystemBoolean(){} // RVA: 0x7FFACA168310
        public void __TryGetVelocity__UnityEngineVector3Ref__SystemBoolean(){} // RVA: 0x7FFACA168420
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA168540
    }

    public class ExternVRCSDKBaseVRCDroneApiArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA168F50
        public void .ctor(){} // RVA: 0x7FFACA168F90
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA169360
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA169490
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA1695A0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA169680
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA169760
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA169830
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA169980
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA169A20
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA169B20
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA169C40
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA169D50
        public void __GetType__SystemType(){} // RVA: 0x7FFACA169E70
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA169F60
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA16A040
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA16A160
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA16A2F0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA16A440
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA16A570
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA16A690
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA16A800
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA16A940
        public void __Get__SystemInt32__VRCSDKBaseVRCDroneApi(){} // RVA: 0x7FFACA16AA60
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA16AB40
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA16ABB0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA16ACD0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA16AE50
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA16AFB0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA16B0E0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA16B200
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA16B360
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA16B4B0
        public void __Set__SystemInt32_VRCSDKBaseVRCDroneApi__SystemVoid(){} // RVA: 0x7FFACA16B5D0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA16B750
        public void __ctor__SystemInt32__VRCSDKBaseVRCDroneApiArray(){} // RVA: 0x7FFACA16B840
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA16B9E0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA16BA80
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA16BB20
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA16BBC0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA16BC60
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA16BD00
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA16BDA0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA16BE80
    }

    public class ExternVRCSDKBaseVRCGraphics : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA16DDA0
        public void .ctor(){} // RVA: 0x7FFACA16DDE0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA16E1B0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA16E2E0
        public void __Blit__UnityEngineTexture_UnityEngineMaterial_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA16E3F0
        public void __Blit__UnityEngineTexture_UnityEngineRenderTexture_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA16E630
        public void __Blit__UnityEngineTexture_UnityEngineRenderTexture_UnityEngineMaterial_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA16E890
        public void __Blit__UnityEngineTexture_UnityEngineRenderTexture_UnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACA16EAD0
        public void __Blit__UnityEngineTexture_UnityEngineRenderTexture_UnityEngineVector2_UnityEngineVector2_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA16ECD0
        public void __Blit__UnityEngineTexture_UnityEngineRenderTexture_UnityEngineVector2_UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA16F000
        public void __Blit__UnityEngineTexture_UnityEngineRenderTexture__SystemVoid(){} // RVA: 0x7FFACA16F210
    }

    public class ExternVRCSDKBaseVRCInputMethod : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA1721D0
        public void .ctor(){} // RVA: 0x7FFACA172210
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA1725E0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA172710
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA172820
        public void __ToString__SystemString(){} // RVA: 0x7FFACA172960
        public void __ToString__SystemString__SystemString(){} // RVA: 0x7FFACA172A10
        public void __get_Controller__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFACA172AE0
        public void __get_Count__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFACA172B50
        public void __get_Gaze__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFACA172BC0
        public void __get_Generic__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFACA172C30
        public void __get_HPMotionController__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFACA172CA0
        public void __get_Index__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFACA172D10
        public void __get_Keyboard__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFACA172D80
        public void __get_Mouse__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFACA172DF0
        public void __get_Oculus__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFACA172E60
        public void __get_OpenXRGeneric__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFACA172ED0
        public void __get_Osc__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFACA172F40
        public void __get_Pico__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFACA172FB0
        public void __get_QuestHands__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFACA173020
        public void __get_SteamVR2__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFACA173090
        public void __get_Touch__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFACA173100
        public void __get_ViveXr__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFACA173170
        public void __get_Vive__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFACA1731E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA173250
    }

    public class ExternVRCSDKBaseVRCPlayerApi : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA174320
        public void .ctor(){} // RVA: 0x7FFACA174360
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA174730
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA174860
        public void __ClearPlayerTags__SystemVoid(){} // RVA: 0x7FFACA174970
        public void __ClearSilence__SystemVoid(){} // RVA: 0x7FFACA174A50
        public void __CombatGetCurrentHitpoints__SystemSingle(){} // RVA: 0x7FFACA174B30
        public void __CombatGetDestructible__VRCSDKBaseIVRC_Destructible(){} // RVA: 0x7FFACA174C50
        public void __CombatSetCurrentHitpoints__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA174D70
        public void __CombatSetDamageGraphic__UnityEngineGameObject__SystemVoid(){} // RVA: 0x7FFACA174EA0
        public void __CombatSetMaxHitpoints__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA174FF0
        public void __CombatSetRespawn__SystemBoolean_SystemSingle_UnityEngineTransform__SystemVoid(){} // RVA: 0x7FFACA175120
        public void __CombatSetup__SystemVoid(){} // RVA: 0x7FFACA1752F0
        public void __EnablePickups__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA1753D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA175480
        public void __FindComponentInPlayerObjects__UnityEngineComponent__UnityEngineComponent(){} // RVA: 0x7FFACA1755D0
        public void __GetAvailableLanguages__SystemStringArray(){} // RVA: 0x7FFACA1756F0
        public void __GetAvatarEyeHeightAsMeters__SystemSingle(){} // RVA: 0x7FFACA1757E0
        public void __GetAvatarEyeHeightMaximumAsMeters__SystemSingle(){} // RVA: 0x7FFACA175900
        public void __GetAvatarEyeHeightMinimumAsMeters__SystemSingle(){} // RVA: 0x7FFACA175A20
        public void __GetBonePosition__UnityEngineHumanBodyBones__UnityEngineVector3(){} // RVA: 0x7FFACA175B40
        public void __GetBoneRotation__UnityEngineHumanBodyBones__UnityEngineQuaternion(){} // RVA: 0x7FFACA175CB0
        public void __GetCurrentLanguage__SystemString(){} // RVA: 0x7FFACA175E20
        public void __GetDrone__VRCSDKBaseVRCDroneApi(){} // RVA: 0x7FFACA175F10
        public void __GetGravityStrength__SystemSingle(){} // RVA: 0x7FFACA176020
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA176140
        public void __GetJumpImpulse__SystemSingle(){} // RVA: 0x7FFACA176240
        public void __GetManualAvatarScalingAllowed__SystemBoolean(){} // RVA: 0x7FFACA176360
        public void __GetPickupInHand__VRCSDKBaseVRC_PickupPickupHand__VRCSDKBaseVRC_Pickup(){} // RVA: 0x7FFACA176480
        public void __GetPlayerById__SystemInt32__VRCSDKBaseVRCPlayerApi(){} // RVA: 0x7FFACA176660
        public void __GetPlayerCount__SystemInt32(){} // RVA: 0x7FFACA176730
        public void __GetPlayerId__VRCSDKBaseVRCPlayerApi__SystemInt32(){} // RVA: 0x7FFACA176820
        public void __GetPlayerObjects__UnityEngineGameObjectArray(){} // RVA: 0x7FFACA1768F0
        public void __GetPlayerTag__SystemString__SystemString(){} // RVA: 0x7FFACA176A50
        public void __GetPlayersWithTag__SystemString_SystemString__SystemCollectionsGenericListSystemInt32(){} // RVA: 0x7FFACA176BA0
        public void __GetPlayers__VRCSDKBaseVRCPlayerApiArray(){} // RVA: 0x7FFACA176D50
        public void __GetPlayers__VRCSDKBaseVRCPlayerApiArray__VRCSDKBaseVRCPlayerApiArray(){} // RVA: 0x7FFACA176E70
        public void __GetPosition__UnityEngineVector3(){} // RVA: 0x7FFACA176F40
        public void __GetRotation__UnityEngineQuaternion(){} // RVA: 0x7FFACA177070
        public void __GetRunSpeed__SystemSingle(){} // RVA: 0x7FFACA177190
        public void __GetStrafeSpeed__SystemSingle(){} // RVA: 0x7FFACA1772B0
        public void __GetTrackingData__VRCSDKBaseVRCPlayerApiTrackingDataType__VRCSDKBaseVRCPlayerApiTrackingData(){} // RVA: 0x7FFACA1773D0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA177560
        public void __GetVelocity__UnityEngineVector3(){} // RVA: 0x7FFACA177650
        public void __GetVoiceDistanceFar__SystemSingle(){} // RVA: 0x7FFACA177780
        public void __GetVoiceDistanceNear__SystemSingle(){} // RVA: 0x7FFACA1778A0
        public void __GetVoiceGain__SystemSingle(){} // RVA: 0x7FFACA1779C0
        public void __GetVoiceLowpass__SystemBoolean(){} // RVA: 0x7FFACA177AE0
        public void __GetVoiceVolumetricRadius__SystemSingle(){} // RVA: 0x7FFACA177C00
        public void __GetWalkSpeed__SystemSingle(){} // RVA: 0x7FFACA177D20
        public void __Immobilize__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA177E40
        public void __IsOwner__UnityEngineGameObject__SystemBoolean(){} // RVA: 0x7FFACA177F60
        public void __IsPlayerGrounded__SystemBoolean(){} // RVA: 0x7FFACA1780E0
        public void __IsUserInVR__SystemBoolean(){} // RVA: 0x7FFACA178220
        public void __IsValid__SystemBoolean(){} // RVA: 0x7FFACA178340
        public void __PlayHapticEventInHand__VRCSDKBaseVRC_PickupPickupHand_SystemSingle_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x7FFACA1783E0
        public void __Respawn__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA178540
        public void __Respawn__SystemVoid(){} // RVA: 0x7FFACA178660
        public void __SetAvatarAudioCustomCurve__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA178740
        public void __SetAvatarAudioFarRadius__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA178860
        public void __SetAvatarAudioForceSpatial__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA178990
        public void __SetAvatarAudioGain__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA178AB0
        public void __SetAvatarAudioNearRadius__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA178BE0
        public void __SetAvatarAudioVolumetricRadius__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA178D10
        public void __SetAvatarEyeHeightByMeters__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA178E40
        public void __SetAvatarEyeHeightByMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA178F70
        public void __SetAvatarEyeHeightMaximumByMeters__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA1790A0
        public void __SetAvatarEyeHeightMinimumByMeters__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA1791D0
        public void __SetGravityStrength__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA179300
        public void __SetJumpImpulse__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA179430
        public void __SetManualAvatarScalingAllowed__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA179560
        public void __SetPlayerTag__SystemString_SystemString__SystemVoid(){} // RVA: 0x7FFACA179680
        public void __SetRunSpeed__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA1797D0
        public void __SetSilencedToTagged__SystemInt32_SystemString_SystemString__SystemVoid(){} // RVA: 0x7FFACA179900
        public void __SetSilencedToUntagged__SystemInt32_SystemString_SystemString__SystemVoid(){} // RVA: 0x7FFACA179A90
        public void __SetStrafeSpeed__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA179C20
        public void __SetVelocity__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA179D50
        public void __SetVoiceDistanceFar__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA179E90
        public void __SetVoiceDistanceNear__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA179FC0
        public void __SetVoiceGain__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA17A0F0
        public void __SetVoiceLowpass__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA17A220
        public void __SetVoiceVolumetricRadius__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA17A340
        public void __SetWalkSpeed__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA17A470
        public void __TeleportTo__UnityEngineVector3_UnityEngineQuaternion_VRCSDKBaseVRC_SceneDescriptorSpawnOrientation_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA17A5A0
        public void __TeleportTo__UnityEngineVector3_UnityEngineQuaternion_VRCSDKBaseVRC_SceneDescriptorSpawnOrientation__SystemVoid(){} // RVA: 0x7FFACA17A7F0
        public void __TeleportTo__UnityEngineVector3_UnityEngineQuaternion__SystemVoid(){} // RVA: 0x7FFACA17A9F0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA17ABB0
        public void __UseAttachedStation__SystemVoid(){} // RVA: 0x7FFACA17ACA0
        public void __UseLegacyLocomotion__SystemVoid(){} // RVA: 0x7FFACA17AD80
        public void __get_displayName__SystemString(){} // RVA: 0x7FFACA17AE60
        public void __get_isInstanceOwner__SystemBoolean(){} // RVA: 0x7FFACA17AEF0
        public void __get_isLocal__SystemBoolean(){} // RVA: 0x7FFACA17B000
        public void __get_isMaster__SystemBoolean(){} // RVA: 0x7FFACA17B0A0
        public void __get_isSuspended__SystemBoolean(){} // RVA: 0x7FFACA17B140
        public void __get_isVRCPlus__SystemBoolean(){} // RVA: 0x7FFACA17B250
        public void __get_playerId__SystemInt32(){} // RVA: 0x7FFACA17B360
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA17B460
    }

    public class ExternVRCSDKBaseVRCPlayerApiArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA17FB40
        public void .ctor(){} // RVA: 0x7FFACA17FB80
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA17FF50
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA180080
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA180190
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA180270
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA180350
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA180420
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA180570
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA180610
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA180710
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA180830
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA180940
        public void __GetType__SystemType(){} // RVA: 0x7FFACA180A60
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA180B50
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA180C30
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA180D50
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA180EE0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA181030
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA181160
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA181280
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA1813F0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA181530
        public void __Get__SystemInt32__VRCSDKBaseVRCPlayerApi(){} // RVA: 0x7FFACA181650
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA181730
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA1817A0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA1818C0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA181A40
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA181BA0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA181CD0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA181DF0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA181F50
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA1820A0
        public void __Set__SystemInt32_VRCSDKBaseVRCPlayerApi__SystemVoid(){} // RVA: 0x7FFACA1821C0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA1822E0
        public void __ctor__SystemInt32__VRCSDKBaseVRCPlayerApiArray(){} // RVA: 0x7FFACA1823D0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA182480
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA182520
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA1825C0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA182660
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA182700
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA1827A0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA182840
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA182920
    }

    public class ExternVRCSDKBaseVRCPlayerApiTrackingData : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA184840
        public void .ctor(){} // RVA: 0x7FFACA184880
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA184C50
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA184D80
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA184E90
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA184FD0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA185080
        public void __ToString__SystemString(){} // RVA: 0x7FFACA185170
        public void __get_position__UnityEngineVector3(){} // RVA: 0x7FFACA185220
        public void __get_rotation__UnityEngineQuaternion(){} // RVA: 0x7FFACA185350
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA185480
    }

    public class ExternVRCSDKBaseVRCPlayerApiTrackingDataArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA185AD0
        public void .ctor(){} // RVA: 0x7FFACA185B10
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA185EE0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA186010
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA186120
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA186200
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA1862E0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA1863B0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA186500
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA1865A0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA1866A0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA1867C0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA1868D0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA1869F0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA186AE0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA186BC0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA186CE0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA186E70
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA186FC0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA1870F0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA187210
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA187380
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA1874C0
        public void __Get__SystemInt32__VRCSDKBaseVRCPlayerApiTrackingData(){} // RVA: 0x7FFACA1875E0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA1876E0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA187750
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA187870
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA1879F0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA187B50
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA187C80
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA187DA0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA187F00
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA188050
        public void __Set__SystemInt32_VRCSDKBaseVRCPlayerApiTrackingData__SystemVoid(){} // RVA: 0x7FFACA188170
        public void __ToString__SystemString(){} // RVA: 0x7FFACA188280
        public void __ctor__SystemInt32__VRCSDKBaseVRCPlayerApiTrackingDataArray(){} // RVA: 0x7FFACA188370
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA188510
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA1885B0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA188650
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA1886F0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA188790
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA188830
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA1888D0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA1889B0
    }

    public class ExternVRCSDKBaseVRCRenderTexture : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA18A8D0
        public void .ctor(){} // RVA: 0x7FFACA18A910
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA18ACE0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA18AE10
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA18AF20
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA18B070
        public void __GetTemporary__SystemInt32_SystemInt32_SystemInt32_UnityEngineRenderTextureFormat_UnityEngineRenderTextureReadWrite_SystemInt32_UnityEngineRenderTextureMemoryless_UnityEngineVRTextureUsage_SystemBoolean__UnityEngineRenderTexture(){} // RVA: 0x7FFACA18B170
        public void __GetTemporary__UnityEngineRenderTextureDescriptor__UnityEngineRenderTexture(){} // RVA: 0x7FFACA18B480
        public void __GetType__SystemType(){} // RVA: 0x7FFACA18B610
        public void __ReleaseTemporary__UnityEngineRenderTexture__SystemVoid(){} // RVA: 0x7FFACA18B700
        public void __ToString__SystemString(){} // RVA: 0x7FFACA18B840
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA18B930
    }

    public class ExternVRCSDKBaseVRCShader : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA18C050
        public void .ctor(){} // RVA: 0x7FFACA18C090
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA18C460
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA18C590
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA18C6A0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA18C7F0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA18C8F0
        public void __PropertyToID__SystemString__SystemInt32(){} // RVA: 0x7FFACA18C9E0
        public void __SetGlobalColor__SystemInt32_UnityEngineColor__SystemVoid(){} // RVA: 0x7FFACA18CAB0
        public void __SetGlobalFloatArray__SystemInt32_SystemSingleArray__SystemVoid(){} // RVA: 0x7FFACA18CC80
        public void __SetGlobalFloat__SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x7FFACA18CDD0
        public void __SetGlobalInteger__SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA18CF60
        public void __SetGlobalMatrixArray__SystemInt32_UnityEngineMatrix4x4Array__SystemVoid(){} // RVA: 0x7FFACA18D0D0
        public void __SetGlobalMatrix__SystemInt32_UnityEngineMatrix4x4__SystemVoid(){} // RVA: 0x7FFACA18D220
        public void __SetGlobalTexture__SystemInt32_UnityEngineTexture__SystemVoid(){} // RVA: 0x7FFACA18D400
        public void __SetGlobalVectorArray__SystemInt32_UnityEngineVector4Array__SystemVoid(){} // RVA: 0x7FFACA18D5C0
        public void __SetGlobalVector__SystemInt32_UnityEngineVector4__SystemVoid(){} // RVA: 0x7FFACA18D710
        public void __ToString__SystemString(){} // RVA: 0x7FFACA18D8B0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA18D9A0
    }

    public class ExternVRCSDKBaseVRCUrl : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA18E600
        public void .ctor(){} // RVA: 0x7FFACA18E640
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA18EA10
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA18EB40
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA18EC50
        public void __Equals__VRCSDKBaseVRCUrl__SystemBoolean(){} // RVA: 0x7FFACA18ED90
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA18EEA0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA18EF50
        public void __Get__SystemString(){} // RVA: 0x7FFACA18F040
        public void __IsNullOrEmpty__VRCSDKBaseVRCUrl__SystemBoolean(){} // RVA: 0x7FFACA18F0D0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA18F230
        public void __get_Empty__VRCSDKBaseVRCUrl(){} // RVA: 0x7FFACA18F2E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA18F3B0
    }

    public class ExternVRCSDKBaseVRCUrlArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA18FB90
        public void .ctor(){} // RVA: 0x7FFACA18FBD0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA18FFA0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA1900D0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA1901E0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA1902C0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA1903A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA190470
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA1905C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA190660
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA190760
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA190880
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA190990
        public void __GetType__SystemType(){} // RVA: 0x7FFACA190AB0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA190BA0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA190C80
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA190DA0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA190F30
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA191080
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA1911B0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA1912D0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA191440
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA191580
        public void __Get__SystemInt32__VRCSDKBaseVRCUrl(){} // RVA: 0x7FFACA1916A0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA191780
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA1917F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA191910
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA191A90
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA191BF0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA191D20
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA191E40
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA191FA0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA1920F0
        public void __Set__SystemInt32_VRCSDKBaseVRCUrl__SystemVoid(){} // RVA: 0x7FFACA192210
        public void __ToString__SystemString(){} // RVA: 0x7FFACA192330
        public void __ctor__SystemInt32__VRCSDKBaseVRCUrlArray(){} // RVA: 0x7FFACA192420
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA1925C0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA192660
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA192700
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA1927A0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA192840
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA1928E0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA192980
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA192A60
    }

    public class ExternVRCUdonCommonDeserializationResult : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA449380
        public void .ctor(){} // RVA: 0x7FFACA4493C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA449790
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA4498C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA4499D0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA449B10
        public void __GetType__SystemType(){} // RVA: 0x7FFACA449BC0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA449CB0
        public void __get_isFromStorage__SystemBoolean(){} // RVA: 0x7FFACA449D60
        public void __get_receiveTime__SystemSingle(){} // RVA: 0x7FFACA449E50
        public void __get_sendTime__SystemSingle(){} // RVA: 0x7FFACA449F50
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA44A050
    }

    public class ExternVRCUdonCommonHandType : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA44A770
        public void .ctor(){} // RVA: 0x7FFACA44A7B0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA44AB80
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA44ACB0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA44ADC0
        public void __get_LEFT__VRCUdonCommonHandType(){} // RVA: 0x7FFACA44AF00
        public void __get_RIGHT__VRCUdonCommonHandType(){} // RVA: 0x7FFACA44AF70
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA44AFE0
    }

    public class ExternVRCUdonCommonInterfacesIUdonEventReceiver : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA31AD80
        public void .ctor(){} // RVA: 0x7FFACA31ADC0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA31B190
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA31B2C0
        public void __GetProgramVariableType__SystemString__SystemType(){} // RVA: 0x7FFACA31B3D0
        public void __GetProgramVariable__SystemString__SystemObject(){} // RVA: 0x7FFACA31B4C0
        public void __RequestSerialization__SystemVoid(){} // RVA: 0x7FFACA31B610
        public void __SendCustomEventDelayedFrames__SystemString_SystemInt32_VRCUdonCommonEnumsEventTiming__SystemVoid(){} // RVA: 0x7FFACA31B6B0
        public void __SendCustomEventDelayedSeconds__SystemString_SystemSingle_VRCUdonCommonEnumsEventTiming__SystemVoid(){} // RVA: 0x7FFACA31B880
        public void __SendCustomEvent__SystemString__SystemVoid(){} // RVA: 0x7FFACA31BA50
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFACA31BB20
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFACA31BF70
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFACA31C3B0
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFACA31C790
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFACA31CB00
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFACA31CE10
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFACA31D0C0
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject__SystemVoid(){} // RVA: 0x7FFACA31D310
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesNetworkEventTarget_SystemString__SystemVoid(){} // RVA: 0x7FFACA31D4A0
        public void __SetProgramVariable__SystemString_SystemObject__SystemVoid(){} // RVA: 0x7FFACA31D5B0
        public void __get_DisableInteractive__SystemBoolean(){} // RVA: 0x7FFACA31D700
        public void __get_InteractionText__SystemString(){} // RVA: 0x7FFACA31D7D0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA31D890
        public void __set_DisableInteractive__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA31D960
        public void __set_InteractionText__SystemString__SystemVoid(){} // RVA: 0x7FFACA31DA30
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA31DB00
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA31DBD0
    }

    public class ExternVRCUdonCommonInterfacesIUdonEventReceiverArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA31EE20
        public void .ctor(){} // RVA: 0x7FFACA31EE60
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA31F230
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA31F360
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA31F470
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA31F550
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA31F630
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA31F700
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA31F850
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA31F8F0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA31F9F0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA31FB10
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA31FC20
        public void __GetType__SystemType(){} // RVA: 0x7FFACA31FD40
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA31FE30
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA31FF10
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA320030
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA3201C0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA320310
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA320440
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA320560
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA3206D0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA320810
        public void __Get__SystemInt32__VRCUdonCommonInterfacesIUdonEventReceiver(){} // RVA: 0x7FFACA320930
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA320A10
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA320A80
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA320BA0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA320D20
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA320E80
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA320FB0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA3210D0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA321230
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA321380
        public void __Set__SystemInt32_VRCUdonCommonInterfacesIUdonEventReceiver__SystemVoid(){} // RVA: 0x7FFACA3214A0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA321620
        public void __ctor__SystemInt32__VRCUdonCommonInterfacesIUdonEventReceiverArray(){} // RVA: 0x7FFACA321710
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA3218B0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA321950
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA3219F0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA321A90
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA321B30
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA321BD0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA321C70
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA321D50
    }

    public class ExternVRCUdonCommonSerializationResult : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA44B400
        public void .ctor(){} // RVA: 0x7FFACA44B440
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA44B810
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA44B940
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA44BA50
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA44BB90
        public void __GetType__SystemType(){} // RVA: 0x7FFACA44BC40
        public void __ToString__SystemString(){} // RVA: 0x7FFACA44BD30
        public void __get_byteCount__SystemInt32(){} // RVA: 0x7FFACA44BDE0
        public void __get_success__SystemBoolean(){} // RVA: 0x7FFACA44BEB0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA44BF80
    }

    public class ExternVRCUdonCommonSerializationResultArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA44C5D0
        public void .ctor(){} // RVA: 0x7FFACA44C610
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA44C9E0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA44CB10
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA44CC20
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA44CD00
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA44CDE0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA44CEB0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA44D000
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA44D0A0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA44D1A0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA44D2C0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA44D3D0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA44D4F0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA44D5E0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA44D6C0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA44D7E0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA44D970
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA44DAC0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA44DBF0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA44DD10
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA44DE80
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA44DFC0
        public void __Get__SystemInt32__VRCUdonCommonSerializationResult(){} // RVA: 0x7FFACA44E0E0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA44E1C0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA44E230
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA44E350
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA44E4D0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA44E630
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA44E760
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA44E880
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA44E9E0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA44EB30
        public void __Set__SystemInt32_VRCUdonCommonSerializationResult__SystemVoid(){} // RVA: 0x7FFACA44EC50
        public void __ToString__SystemString(){} // RVA: 0x7FFACA44ED30
        public void __ctor__SystemInt32__VRCUdonCommonSerializationResultArray(){} // RVA: 0x7FFACA44EE20
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA44EFC0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA44F060
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA44F100
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA44F1A0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA44F240
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA44F2E0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA44F380
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA44F460
    }

    public class ExternVRCUdonCommonUdonInputEventArgs : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA451380
        public void .ctor(){} // RVA: 0x7FFACA4513C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA451790
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA4518C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA4519D0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA451B10
        public void __GetType__SystemType(){} // RVA: 0x7FFACA451BC0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA451CB0
        public void __get_boolValue__SystemBoolean(){} // RVA: 0x7FFACA451D60
        public void __get_eventType__VRCUdonCommonUdonInputEventType(){} // RVA: 0x7FFACA451E60
        public void __get_floatValue__SystemSingle(){} // RVA: 0x7FFACA451F50
        public void __get_handType__VRCUdonCommonHandType(){} // RVA: 0x7FFACA452040
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA452140
    }

    public class ExternVRCUdonCommonUdonInputEventType : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA452920
        public void .ctor(){} // RVA: 0x7FFACA452960
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA452D30
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA452E60
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA452F70
        public void __get_AXIS__VRCUdonCommonUdonInputEventType(){} // RVA: 0x7FFACA4530B0
        public void __get_BUTTON__VRCUdonCommonUdonInputEventType(){} // RVA: 0x7FFACA453120
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA453190
    }

}