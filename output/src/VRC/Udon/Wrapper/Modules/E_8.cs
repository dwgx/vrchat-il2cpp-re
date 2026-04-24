// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Wrapper.Modules
// Classes: 95
// Methods: 3199

namespace VRC.Udon.Wrapper.Modules
{
    public class ExternVRCSDK3DataVRCJson : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD556ADD80
        public void .ctor(){} // RVA: 0x7FFD556ADDC0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD556AE190
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD556AE2C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD556AE3D0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD556AE520
        public void __GetType__SystemType(){} // RVA: 0x7FFD556AE620
        public void __ToString__SystemString(){} // RVA: 0x7FFD556AE710
        public void __TryDeserializeFromJson__SystemString_VRCSDK3DataDataTokenRef__SystemBoolean(){} // RVA: 0x7FFD556AE800
        public void __TrySerializeToJson__VRCSDK3DataDataToken_VRCSDK3DataJsonExportType_VRCSDK3DataDataTokenRef__SystemBoolean(){} // RVA: 0x7FFD556AE930
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD556AEAD0
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCAimConstraint : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD556AF120
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFD556AF160
        public void .ctor(){} // RVA: 0x7FFD556AF210
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD556AF5E0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD556AF710
        public void __ActivateConstraint__SystemVoid(){} // RVA: 0x7FFD556AF820
        public void __ApplyConfigurationChanges__SystemVoid(){} // RVA: 0x7FFD556AF8E0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD556AF990
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD556AFA80
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD556AFD30
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD556AFE90
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFD556AFFB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFD556B00A0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD556B0320
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD556B0410
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD556B06C0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD556B0820
        public void __GetComponentInParent__T(){} // RVA: 0x7FFD556B0940
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFD556B0A30
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFD556B0CB0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD556B0E20
        public void __GetComponent__T(){} // RVA: 0x7FFD556B0F40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFD556B1020
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD556B1270
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD556B1360
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD556B1690
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD556B1780
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD556B1AC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD556B1BB0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD556B1EC0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD556B2030
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFD556B2160
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFD556B2250
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD556B2540
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD556B2630
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD556B2970
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD556B2A60
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD556B2D70
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD556B2EE0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFD556B3020
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFD556B3110
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD556B3400
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD556B34F0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFD556B37E0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD556B3930
        public void __GetComponents__TArray(){} // RVA: 0x7FFD556B3A60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFD556B3B50
        public void __ZeroConstraint__SystemVoid(){} // RVA: 0x7FFD556B3E00
        public void __get_AimAxis__UnityEngineVector3(){} // RVA: 0x7FFD556B3EB0
        public void __set_AimAxis__UnityEngineVector3(){} // RVA: 0x7FFD556B3FA0
        public void __get_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFD556B4090
        public void __set_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFD556B4170
        public void __get_GlobalWeight__SystemSingle(){} // RVA: 0x7FFD556B4250
        public void __set_GlobalWeight__SystemSingle(){} // RVA: 0x7FFD556B4330
        public void __get_IsActive__SystemBoolean(){} // RVA: 0x7FFD556B4410
        public void __set_IsActive__SystemBoolean(){} // RVA: 0x7FFD556B44F0
        public void __get_Locked__SystemBoolean(){} // RVA: 0x7FFD556B45D0
        public void __set_Locked__SystemBoolean(){} // RVA: 0x7FFD556B46B0
        public void __get_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFD556B4790
        public void __set_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFD556B4870
        public void __get_RotationAtRest__UnityEngineVector3(){} // RVA: 0x7FFD556B4950
        public void __set_RotationAtRest__UnityEngineVector3(){} // RVA: 0x7FFD556B4A40
        public void __get_RotationOffset__UnityEngineVector3(){} // RVA: 0x7FFD556B4B30
        public void __set_RotationOffset__UnityEngineVector3(){} // RVA: 0x7FFD556B4C20
        public void __get_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFD556B4D10
        public void __set_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFD556B4DF0
        public void __get_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFD556B4ED0
        public void __set_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFD556B5040
        public void __get_TargetTransform__UnityEngineTransform(){} // RVA: 0x7FFD556B5270
        public void __get_UpAxis__UnityEngineVector3(){} // RVA: 0x7FFD556B5370
        public void __set_UpAxis__UnityEngineVector3(){} // RVA: 0x7FFD556B5460
        public void __get_WorldUpTransform__UnityEngineTransform(){} // RVA: 0x7FFD556B5550
        public void __set_WorldUpTransform__UnityEngineTransform(){} // RVA: 0x7FFD556B5650
        public void __get_WorldUpVector__UnityEngineVector3(){} // RVA: 0x7FFD556B5780
        public void __set_WorldUpVector__UnityEngineVector3(){} // RVA: 0x7FFD556B5870
        public void __get_WorldUp__VRCDynamicsVRCConstraintBaseWorldUpType(){} // RVA: 0x7FFD556B5960
        public void __set_WorldUp__VRCDynamicsVRCConstraintBaseWorldUpType(){} // RVA: 0x7FFD556B5A40
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFD556B5B20
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFD556B5C40
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFD556B5D80
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD556B5EC0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD556B60C0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD556B6240
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD556B6440
        public void <.ctor>b__8_1(){} // RVA: 0x7FFD556B6570
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCAimConstraintArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD556B9810
        public void .ctor(){} // RVA: 0x7FFD556B9850
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD556B9C20
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD556B9D50
        public void __Clone__SystemObject(){} // RVA: 0x7FFD556B9E60
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD556B9F40
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD556BA020
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD556BA0F0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD556BA240
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD556BA2E0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD556BA3E0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD556BA500
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD556BA610
        public void __GetType__SystemType(){} // RVA: 0x7FFD556BA730
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD556BA820
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD556BA900
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD556BAA20
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD556BABB0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD556BAD00
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD556BAE30
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD556BAF50
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD556BB0C0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD556BB200
        public void __Get__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCAimConstraint(){} // RVA: 0x7FFD556BB320
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD556BB460
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD556BB4D0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD556BB5F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD556BB770
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD556BB8D0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD556BBA00
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD556BBB20
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD556BBC80
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD556BBDD0
        public void __Set__SystemInt32_VRCSDK3DynamicsConstraintComponentsVRCAimConstraint__SystemVoid(){} // RVA: 0x7FFD556BBEF0
        public void __ToString__SystemString(){} // RVA: 0x7FFD556BC080
        public void __ctor__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCAimConstraintArray(){} // RVA: 0x7FFD556BC170
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD556BC260
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD556BC300
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD556BC3A0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD556BC440
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD556BC4E0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD556BC580
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD556BC620
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD556BC700
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCLookAtConstraint : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD556BE620
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFD556BE660
        public void .ctor(){} // RVA: 0x7FFD556BE710
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD556BEAE0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD556BEC10
        public void __ActivateConstraint__SystemVoid(){} // RVA: 0x7FFD556BED20
        public void __ApplyConfigurationChanges__SystemVoid(){} // RVA: 0x7FFD556BEDE0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD556BEE90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD556BEF80
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD556BF230
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD556BF390
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFD556BF4B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFD556BF5A0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD556BF820
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD556BF910
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD556BFBC0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD556BFD20
        public void __GetComponentInParent__T(){} // RVA: 0x7FFD556BFE40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFD556BFF30
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFD556C01B0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD556C0320
        public void __GetComponent__T(){} // RVA: 0x7FFD556C0440
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFD556C0520
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD556C0770
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD556C0860
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD556C0B90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD556C0C80
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD556C0FC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD556C10B0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD556C13C0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD556C1530
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFD556C1660
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFD556C1750
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD556C1A40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD556C1B30
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD556C1E70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD556C1F60
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD556C2270
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD556C23E0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFD556C2520
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFD556C2610
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD556C2900
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD556C29F0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFD556C2CE0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD556C2E30
        public void __GetComponents__TArray(){} // RVA: 0x7FFD556C2F60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFD556C3050
        public void __ZeroConstraint__SystemVoid(){} // RVA: 0x7FFD556C3300
        public void __get_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFD556C33B0
        public void __set_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFD556C3490
        public void __get_GlobalWeight__SystemSingle(){} // RVA: 0x7FFD556C3570
        public void __set_GlobalWeight__SystemSingle(){} // RVA: 0x7FFD556C3650
        public void __get_IsActive__SystemBoolean(){} // RVA: 0x7FFD556C3730
        public void __set_IsActive__SystemBoolean(){} // RVA: 0x7FFD556C3810
        public void __get_Locked__SystemBoolean(){} // RVA: 0x7FFD556C38F0
        public void __set_Locked__SystemBoolean(){} // RVA: 0x7FFD556C39D0
        public void __get_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFD556C3AB0
        public void __set_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFD556C3B90
        public void __get_Roll__SystemSingle(){} // RVA: 0x7FFD556C3C70
        public void __set_Roll__SystemSingle(){} // RVA: 0x7FFD556C3D50
        public void __get_RotationAtRest__UnityEngineVector3(){} // RVA: 0x7FFD556C3E30
        public void __set_RotationAtRest__UnityEngineVector3(){} // RVA: 0x7FFD556C3F20
        public void __get_RotationOffset__UnityEngineVector3(){} // RVA: 0x7FFD556C4010
        public void __set_RotationOffset__UnityEngineVector3(){} // RVA: 0x7FFD556C4100
        public void __get_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFD556C41F0
        public void __set_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFD556C42D0
        public void __get_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFD556C43B0
        public void __set_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFD556C4520
        public void __get_TargetTransform__UnityEngineTransform(){} // RVA: 0x7FFD556C4750
        public void __get_UseUpTransform__SystemBoolean(){} // RVA: 0x7FFD556C4850
        public void __set_UseUpTransform__SystemBoolean(){} // RVA: 0x7FFD556C4930
        public void __get_WorldUpTransform__UnityEngineTransform(){} // RVA: 0x7FFD556C4A10
        public void __set_WorldUpTransform__UnityEngineTransform(){} // RVA: 0x7FFD556C4B10
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFD556C4C40
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFD556C4D60
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFD556C4EA0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD556C4FE0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD556C51E0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD556C5360
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD556C5560
        public void <.ctor>b__8_1(){} // RVA: 0x7FFD556C5690
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCLookAtConstraintArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD556C8620
        public void .ctor(){} // RVA: 0x7FFD556C8660
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD556C8A30
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD556C8B60
        public void __Clone__SystemObject(){} // RVA: 0x7FFD556C8C70
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD556C8D50
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD556C8E30
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD556C8F00
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD556C9050
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD556C90F0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD556C91F0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD556C9310
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD556C9420
        public void __GetType__SystemType(){} // RVA: 0x7FFD556C9540
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD556C9630
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD556C9710
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD556C9830
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD556C99C0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD556C9B10
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD556C9C40
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD556C9D60
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD556C9ED0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD556CA010
        public void __Get__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCLookAtConstraint(){} // RVA: 0x7FFD556CA130
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD556CA270
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD556CA2E0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD556CA400
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD556CA580
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD556CA6E0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD556CA810
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD556CA930
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD556CAA90
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD556CABE0
        public void __Set__SystemInt32_VRCSDK3DynamicsConstraintComponentsVRCLookAtConstraint__SystemVoid(){} // RVA: 0x7FFD556CAD00
        public void __ToString__SystemString(){} // RVA: 0x7FFD556CAE90
        public void __ctor__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCLookAtConstraintArray(){} // RVA: 0x7FFD556CAF80
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD556CB070
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD556CB110
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD556CB1B0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD556CB250
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD556CB2F0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD556CB390
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD556CB430
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD556CB510
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCParentConstraint : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD556CD430
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFD556CD470
        public void .ctor(){} // RVA: 0x7FFD556CD520
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD556CD8F0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD556CDA20
        public void __ActivateConstraint__SystemVoid(){} // RVA: 0x7FFD556CDB30
        public void __ApplyConfigurationChanges__SystemVoid(){} // RVA: 0x7FFD556CDBF0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD556CDCA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD556CDD90
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD556CE040
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD556CE1A0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFD556CE2C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFD556CE3B0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD556CE630
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD556CE720
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD556CE9D0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD556CEB30
        public void __GetComponentInParent__T(){} // RVA: 0x7FFD556CEC50
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFD556CED40
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFD556CEFC0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD556CF130
        public void __GetComponent__T(){} // RVA: 0x7FFD556CF250
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFD556CF330
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD556CF580
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD556CF670
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD556CF9A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD556CFA90
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD556CFDD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD556CFEC0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD556D01D0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD556D0340
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFD556D0470
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFD556D0560
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD556D0850
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD556D0940
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD556D0C80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD556D0D70
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD556D1080
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD556D11F0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFD556D1330
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFD556D1420
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD556D1710
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD556D1800
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFD556D1AF0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD556D1C40
        public void __GetComponents__TArray(){} // RVA: 0x7FFD556D1D70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFD556D1E60
        public void __ZeroConstraint__SystemVoid(){} // RVA: 0x7FFD556D2110
        public void __get_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFD556D21C0
        public void __set_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFD556D22A0
        public void __get_GlobalWeight__SystemSingle(){} // RVA: 0x7FFD556D2380
        public void __set_GlobalWeight__SystemSingle(){} // RVA: 0x7FFD556D2460
        public void __get_IsActive__SystemBoolean(){} // RVA: 0x7FFD556D2540
        public void __set_IsActive__SystemBoolean(){} // RVA: 0x7FFD556D2620
        public void __get_Locked__SystemBoolean(){} // RVA: 0x7FFD556D2700
        public void __set_Locked__SystemBoolean(){} // RVA: 0x7FFD556D27E0
        public void __get_PositionAtRest__UnityEngineVector3(){} // RVA: 0x7FFD556D28C0
        public void __set_PositionAtRest__UnityEngineVector3(){} // RVA: 0x7FFD556D29B0
        public void __get_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFD556D2AA0
        public void __set_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFD556D2B80
        public void __get_RotationAtRest__UnityEngineVector3(){} // RVA: 0x7FFD556D2C60
        public void __set_RotationAtRest__UnityEngineVector3(){} // RVA: 0x7FFD556D2D50
        public void __get_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFD556D2E40
        public void __set_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFD556D2F20
        public void __get_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFD556D3000
        public void __set_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFD556D3170
        public void __get_TargetTransform__UnityEngineTransform(){} // RVA: 0x7FFD556D33A0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFD556D34A0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFD556D35C0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFD556D3700
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD556D3840
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD556D3A40
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD556D3BC0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD556D3DC0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFD556D3EF0
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCParentConstraintArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD556D6A10
        public void .ctor(){} // RVA: 0x7FFD556D6A50
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD556D6E20
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD556D6F50
        public void __Clone__SystemObject(){} // RVA: 0x7FFD556D7060
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD556D7140
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD556D7220
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD556D72F0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD556D7440
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD556D74E0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD556D75E0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD556D7700
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD556D7810
        public void __GetType__SystemType(){} // RVA: 0x7FFD556D7930
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD556D7A20
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD556D7B00
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD556D7C20
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD556D7DB0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD556D7F00
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD556D8030
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD556D8150
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD556D82C0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD556D8400
        public void __Get__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCParentConstraint(){} // RVA: 0x7FFD556D8520
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD556D8660
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD556D86D0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD556D87F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD556D8970
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD556D8AD0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD556D8C00
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD556D8D20
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD556D8E80
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD556D8FD0
        public void __Set__SystemInt32_VRCSDK3DynamicsConstraintComponentsVRCParentConstraint__SystemVoid(){} // RVA: 0x7FFD556D90F0
        public void __ToString__SystemString(){} // RVA: 0x7FFD556D9280
        public void __ctor__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCParentConstraintArray(){} // RVA: 0x7FFD556D9370
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD556D9460
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD556D9500
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD556D95A0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD556D9640
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD556D96E0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD556D9780
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD556D9820
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD556D9900
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCPositionConstraint : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD556DB820
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFD556DB860
        public void .ctor(){} // RVA: 0x7FFD556DB910
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD556DBCE0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD556DBE10
        public void __ActivateConstraint__SystemVoid(){} // RVA: 0x7FFD556DBF20
        public void __ApplyConfigurationChanges__SystemVoid(){} // RVA: 0x7FFD556DBFE0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD556DC090
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD556DC180
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD556DC430
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD556DC590
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFD556DC6B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFD556DC7A0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD556DCA20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD556DCB10
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD556DCDC0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD556DCF20
        public void __GetComponentInParent__T(){} // RVA: 0x7FFD556DD040
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFD556DD130
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFD556DD3B0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD556DD520
        public void __GetComponent__T(){} // RVA: 0x7FFD556DD640
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFD556DD720
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD556DD970
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD556DDA60
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD556DDD90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD556DDE80
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD556DE1C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD556DE2B0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD556DE5C0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD556DE730
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFD556DE860
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFD556DE950
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD556DEC40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD556DED30
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD556DF070
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD556DF160
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD556DF470
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD556DF5E0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFD556DF720
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFD556DF810
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD556DFB00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD556DFBF0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFD556DFEE0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD556E0030
        public void __GetComponents__TArray(){} // RVA: 0x7FFD556E0160
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFD556E0250
        public void __ZeroConstraint__SystemVoid(){} // RVA: 0x7FFD556E0500
        public void __get_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFD556E05B0
        public void __set_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFD556E0690
        public void __get_GlobalWeight__SystemSingle(){} // RVA: 0x7FFD556E0770
        public void __set_GlobalWeight__SystemSingle(){} // RVA: 0x7FFD556E0850
        public void __get_IsActive__SystemBoolean(){} // RVA: 0x7FFD556E0930
        public void __set_IsActive__SystemBoolean(){} // RVA: 0x7FFD556E0A10
        public void __get_Locked__SystemBoolean(){} // RVA: 0x7FFD556E0AF0
        public void __set_Locked__SystemBoolean(){} // RVA: 0x7FFD556E0BD0
        public void __get_PositionAtRest__UnityEngineVector3(){} // RVA: 0x7FFD556E0CB0
        public void __set_PositionAtRest__UnityEngineVector3(){} // RVA: 0x7FFD556E0DA0
        public void __get_PositionOffset__UnityEngineVector3(){} // RVA: 0x7FFD556E0E90
        public void __set_PositionOffset__UnityEngineVector3(){} // RVA: 0x7FFD556E0F80
        public void __get_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFD556E1070
        public void __set_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFD556E1150
        public void __get_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFD556E1230
        public void __set_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFD556E1310
        public void __get_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFD556E13F0
        public void __set_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFD556E1560
        public void __get_TargetTransform__UnityEngineTransform(){} // RVA: 0x7FFD556E1790
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFD556E1890
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFD556E19B0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFD556E1AF0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD556E1C30
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD556E1E30
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD556E1FB0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD556E21B0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFD556E22E0
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCPositionConstraintArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD554A77A0
        public void .ctor(){} // RVA: 0x7FFD554A77E0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD554A7BB0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD554A7CE0
        public void __Clone__SystemObject(){} // RVA: 0x7FFD554A7DF0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554A7ED0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554A7FB0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD554A8080
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD554A81D0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD554A8270
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD554A8370
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD554A8490
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD554A85A0
        public void __GetType__SystemType(){} // RVA: 0x7FFD554A86C0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD554A87B0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD554A8890
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD554A89B0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD554A8B40
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD554A8C90
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD554A8DC0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD554A8EE0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD554A9050
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD554A9190
        public void __Get__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCPositionConstraint(){} // RVA: 0x7FFD554A92B0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD554A93F0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD554A9460
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554A9580
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554A9700
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554A9860
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD554A9990
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554A9AB0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554A9C10
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554A9D60
        public void __Set__SystemInt32_VRCSDK3DynamicsConstraintComponentsVRCPositionConstraint__SystemVoid(){} // RVA: 0x7FFD554A9E80
        public void __ToString__SystemString(){} // RVA: 0x7FFD554AA010
        public void __ctor__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCPositionConstraintArray(){} // RVA: 0x7FFD554AA100
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD554AA1F0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD554AA290
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD554AA330
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD554AA3D0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD554AA470
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD554AA510
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD554AA5B0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD554AA690
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCRotationConstraint : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD554AC5B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFD554AC5F0
        public void .ctor(){} // RVA: 0x7FFD554AC6A0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD554ACA70
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD554ACBA0
        public void __ActivateConstraint__SystemVoid(){} // RVA: 0x7FFD554ACCB0
        public void __ApplyConfigurationChanges__SystemVoid(){} // RVA: 0x7FFD554ACD70
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD554ACE20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD554ACF10
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD554AD1C0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD554AD320
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFD554AD440
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFD554AD530
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD554AD7B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD554AD8A0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD554ADB50
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD554ADCB0
        public void __GetComponentInParent__T(){} // RVA: 0x7FFD554ADDD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFD554ADEC0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFD554AE140
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD554AE2B0
        public void __GetComponent__T(){} // RVA: 0x7FFD554AE3D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFD554AE4B0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD554AE700
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD554AE7F0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD554AEB20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD554AEC10
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD554AEF50
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD554AF040
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD554AF350
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD554AF4C0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFD554AF5F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFD554AF6E0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD554AF9D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD554AFAC0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD554AFE00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD554AFEF0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD554B0200
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD554B0370
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFD554B04B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFD554B05A0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD554B0890
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD554B0980
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFD554B0C70
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD554B0DC0
        public void __GetComponents__TArray(){} // RVA: 0x7FFD554B0EF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFD554B0FE0
        public void __ZeroConstraint__SystemVoid(){} // RVA: 0x7FFD554B1290
        public void __get_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFD554B1340
        public void __set_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFD554B1420
        public void __get_GlobalWeight__SystemSingle(){} // RVA: 0x7FFD554B1500
        public void __set_GlobalWeight__SystemSingle(){} // RVA: 0x7FFD554B15E0
        public void __get_IsActive__SystemBoolean(){} // RVA: 0x7FFD554B16C0
        public void __set_IsActive__SystemBoolean(){} // RVA: 0x7FFD554B17A0
        public void __get_Locked__SystemBoolean(){} // RVA: 0x7FFD554B1880
        public void __set_Locked__SystemBoolean(){} // RVA: 0x7FFD554B1960
        public void __get_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFD554B1A40
        public void __set_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFD554B1B20
        public void __get_RotationAtRest__UnityEngineVector3(){} // RVA: 0x7FFD554B1C00
        public void __set_RotationAtRest__UnityEngineVector3(){} // RVA: 0x7FFD554B1CF0
        public void __get_RotationOffset__UnityEngineVector3(){} // RVA: 0x7FFD554B1DE0
        public void __set_RotationOffset__UnityEngineVector3(){} // RVA: 0x7FFD554B1ED0
        public void __get_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFD554B1FC0
        public void __set_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFD554B20A0
        public void __get_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFD554B2180
        public void __set_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFD554B22F0
        public void __get_TargetTransform__UnityEngineTransform(){} // RVA: 0x7FFD554B2520
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFD554B2620
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFD554B2740
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFD554B2880
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD554B29C0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD554B2BC0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD554B2D40
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD554B2F40
        public void <.ctor>b__8_1(){} // RVA: 0x7FFD554B3070
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCRotationConstraintArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD554B5B90
        public void .ctor(){} // RVA: 0x7FFD554B5BD0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD554B5FA0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD554B60D0
        public void __Clone__SystemObject(){} // RVA: 0x7FFD554B61E0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554B62C0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554B63A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD554B6470
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD554B65C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD554B6660
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD554B6760
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD554B6880
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD554B6990
        public void __GetType__SystemType(){} // RVA: 0x7FFD554B6AB0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD554B6BA0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD554B6C80
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD554B6DA0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD554B6F30
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD554B7080
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD554B71B0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD554B72D0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD554B7440
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD554B7580
        public void __Get__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCRotationConstraint(){} // RVA: 0x7FFD554B76A0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD554B77E0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD554B7850
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554B7970
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554B7AF0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554B7C50
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD554B7D80
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554B7EA0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554B8000
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554B8150
        public void __Set__SystemInt32_VRCSDK3DynamicsConstraintComponentsVRCRotationConstraint__SystemVoid(){} // RVA: 0x7FFD554B8270
        public void __ToString__SystemString(){} // RVA: 0x7FFD554B8400
        public void __ctor__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCRotationConstraintArray(){} // RVA: 0x7FFD554B84F0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD554B85E0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD554B8680
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD554B8720
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD554B87C0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD554B8860
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD554B8900
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD554B89A0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD554B8A80
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCScaleConstraint : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD554BA9A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFD554BA9E0
        public void .ctor(){} // RVA: 0x7FFD554BAA90
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD554BAE60
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD554BAF90
        public void __ActivateConstraint__SystemVoid(){} // RVA: 0x7FFD554BB0A0
        public void __ApplyConfigurationChanges__SystemVoid(){} // RVA: 0x7FFD554BB160
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD554BB210
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD554BB300
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD554BB5B0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD554BB710
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFD554BB830
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFD554BB920
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD554BBBA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD554BBC90
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD554BBF40
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD554BC0A0
        public void __GetComponentInParent__T(){} // RVA: 0x7FFD554BC1C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFD554BC2B0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFD554BC530
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD554BC6A0
        public void __GetComponent__T(){} // RVA: 0x7FFD554BC7C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFD554BC8A0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD554BCAF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD554BCBE0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD554BCF10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD554BD000
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD554BD340
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD554BD430
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD554BD740
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD554BD8B0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFD554BD9E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFD554BDAD0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD554BDDC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD554BDEB0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD554BE1F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD554BE2E0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD554BE5F0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD554BE760
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFD554BE8A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFD554BE990
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD554BEC80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD554BED70
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFD554BF060
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD554BF1B0
        public void __GetComponents__TArray(){} // RVA: 0x7FFD554BF2E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFD554BF3D0
        public void __ZeroConstraint__SystemVoid(){} // RVA: 0x7FFD554BF680
        public void __get_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFD554BF730
        public void __set_FreezeToWorld__SystemBoolean(){} // RVA: 0x7FFD554BF810
        public void __get_GlobalWeight__SystemSingle(){} // RVA: 0x7FFD554BF8F0
        public void __set_GlobalWeight__SystemSingle(){} // RVA: 0x7FFD554BF9D0
        public void __get_IsActive__SystemBoolean(){} // RVA: 0x7FFD554BFAB0
        public void __set_IsActive__SystemBoolean(){} // RVA: 0x7FFD554BFB90
        public void __get_Locked__SystemBoolean(){} // RVA: 0x7FFD554BFC70
        public void __set_Locked__SystemBoolean(){} // RVA: 0x7FFD554BFD50
        public void __get_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFD554BFE30
        public void __set_RebakeOffsetsWhenUnfrozen__SystemBoolean(){} // RVA: 0x7FFD554BFF10
        public void __get_ScaleAtRest__UnityEngineVector3(){} // RVA: 0x7FFD554BFFF0
        public void __set_ScaleAtRest__UnityEngineVector3(){} // RVA: 0x7FFD554C00E0
        public void __get_ScaleOffset__UnityEngineVector3(){} // RVA: 0x7FFD554C01D0
        public void __set_ScaleOffset__UnityEngineVector3(){} // RVA: 0x7FFD554C02C0
        public void __get_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFD554C03B0
        public void __set_SolveInLocalSpace__SystemBoolean(){} // RVA: 0x7FFD554C0490
        public void __get_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFD554C0570
        public void __set_Sources__VRCDynamicsVRCConstraintSourceKeyableList(){} // RVA: 0x7FFD554C06E0
        public void __get_TargetTransform__UnityEngineTransform(){} // RVA: 0x7FFD554C0910
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFD554C0A10
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFD554C0B30
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFD554C0C70
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD554C0DB0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD554C0FB0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD554C1130
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD554C1330
        public void <.ctor>b__8_1(){} // RVA: 0x7FFD554C1460
    }

    public class ExternVRCSDK3DynamicsConstraintComponentsVRCScaleConstraintArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD554C3F80
        public void .ctor(){} // RVA: 0x7FFD554C3FC0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD554C4390
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD554C44C0
        public void __Clone__SystemObject(){} // RVA: 0x7FFD554C45D0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554C46B0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554C4790
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD554C4860
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD554C49B0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD554C4A50
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD554C4B50
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD554C4C70
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD554C4D80
        public void __GetType__SystemType(){} // RVA: 0x7FFD554C4EA0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD554C4F90
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD554C5070
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD554C5190
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD554C5320
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD554C5470
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD554C55A0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD554C56C0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD554C5830
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD554C5970
        public void __Get__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCScaleConstraint(){} // RVA: 0x7FFD554C5A90
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD554C5BD0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD554C5C40
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554C5D60
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554C5EE0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554C6040
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD554C6170
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554C6290
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554C63F0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554C6540
        public void __Set__SystemInt32_VRCSDK3DynamicsConstraintComponentsVRCScaleConstraint__SystemVoid(){} // RVA: 0x7FFD554C6660
        public void __ToString__SystemString(){} // RVA: 0x7FFD554C67F0
        public void __ctor__SystemInt32__VRCSDK3DynamicsConstraintComponentsVRCScaleConstraintArray(){} // RVA: 0x7FFD554C68E0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD554C69D0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD554C6A70
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD554C6B10
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD554C6BB0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD554C6C50
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD554C6CF0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD554C6D90
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD554C6E70
    }

    public class ExternVRCSDK3DynamicsContactComponentsVRCContactReceiver : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD554C8D90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFD554C8DD0
        public void .ctor(){} // RVA: 0x7FFD554C8E80
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD554C9250
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD554C9380
        public void __ApplyConfigurationChanges__SystemVoid(){} // RVA: 0x7FFD554C9490
        public void __CalculateProximity__VRCDynamicsContactSenderProxy__SystemSingle(){} // RVA: 0x7FFD554C9540
        public void __CalculateProximity__VRCSDK3DynamicsContactComponentsVRCContactSender__SystemSingle(){} // RVA: 0x7FFD554C96F0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD554C9920
        public void __Equals__VRCDynamicsContactReceiverProxy__SystemBoolean(){} // RVA: 0x7FFD554C9A80
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD554C9BE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD554C9CD0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD554C9F80
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD554CA0E0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFD554CA200
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFD554CA2F0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD554CA570
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD554CA660
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD554CA910
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD554CAA70
        public void __GetComponentInParent__T(){} // RVA: 0x7FFD554CAB90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFD554CAC80
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFD554CAF00
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD554CB070
        public void __GetComponent__T(){} // RVA: 0x7FFD554CB190
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFD554CB270
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD554CB4C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD554CB5B0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD554CB8E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD554CB9D0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD554CBD10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD554CBE00
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD554CC110
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD554CC280
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFD554CC3B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFD554CC4A0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD554CC790
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD554CC880
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD554CCBC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD554CCCB0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD554CCFC0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD554CD130
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFD554CD270
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFD554CD360
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD554CD650
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD554CD740
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFD554CDA30
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD554CDB80
        public void __GetComponents__TArray(){} // RVA: 0x7FFD554CDCB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFD554CDDA0
        public void __UpdateCollisionTags__SystemStringArray__SystemVoid(){} // RVA: 0x7FFD554CE050
        public void __UpdateContentTypes__VRCDynamicsDynamicsUsageFlags__SystemVoid(){} // RVA: 0x7FFD554CE130
        public void __get_Usage__VRCDynamicsDynamicsUsage(){} // RVA: 0x7FFD554CE210
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFD554CE2F0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFD554CE410
        public void __get_height__SystemSingle(){} // RVA: 0x7FFD554CE550
        public void __set_height__SystemSingle(){} // RVA: 0x7FFD554CE630
        public void __get_position__UnityEngineVector3(){} // RVA: 0x7FFD554CE710
        public void __set_position__UnityEngineVector3(){} // RVA: 0x7FFD554CE7F0
        public void __get_radius__SystemSingle(){} // RVA: 0x7FFD554CE8D0
        public void __set_radius__SystemSingle(){} // RVA: 0x7FFD554CE9B0
        public void __get_rotation__UnityEngineQuaternion(){} // RVA: 0x7FFD554CEA90
        public void __set_rotation__UnityEngineQuaternion(){} // RVA: 0x7FFD554CEB70
        public void __get_shapeType__VRCDynamicsContactBaseShapeType(){} // RVA: 0x7FFD554CEC50
        public void __set_shapeType__VRCDynamicsContactBaseShapeType(){} // RVA: 0x7FFD554CED30
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFD554CEE10
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD554CEF50
        public void __op_Equality__VRCDynamicsContactReceiverProxy_VRCSDK3DynamicsContactComponentsVRCContactReceiver__SystemBoolean(){} // RVA: 0x7FFD554CF150
        public void __op_Equality__VRCSDK3DynamicsContactComponentsVRCContactReceiver_VRCDynamicsContactReceiverProxy__SystemBoolean(){} // RVA: 0x7FFD554CF270
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD554CF380
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD554CF500
        public void __op_Inequality__VRCDynamicsContactReceiverProxy_VRCSDK3DynamicsContactComponentsVRCContactReceiver__SystemBoolean(){} // RVA: 0x7FFD554CF700
        public void __op_Inequality__VRCSDK3DynamicsContactComponentsVRCContactReceiver_VRCDynamicsContactReceiverProxy__SystemBoolean(){} // RVA: 0x7FFD554CF820
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD554CF930
        public void <.ctor>b__8_1(){} // RVA: 0x7FFD554CFA60
    }

    public class ExternVRCSDK3DynamicsContactComponentsVRCContactReceiverArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD554D2580
        public void .ctor(){} // RVA: 0x7FFD554D25C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD554D2990
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD554D2AC0
        public void __Clone__SystemObject(){} // RVA: 0x7FFD554D2BD0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554D2CB0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554D2D90
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD554D2E60
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD554D2FB0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD554D3050
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD554D3150
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD554D3270
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD554D3380
        public void __GetType__SystemType(){} // RVA: 0x7FFD554D34A0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD554D3590
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD554D3670
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD554D3790
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD554D3920
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD554D3A70
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD554D3BA0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD554D3CC0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD554D3E30
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD554D3F70
        public void __Get__SystemInt32__VRCSDK3DynamicsContactComponentsVRCContactReceiver(){} // RVA: 0x7FFD554D4090
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD554D41D0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD554D4240
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554D4360
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554D44E0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554D4640
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD554D4770
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554D4890
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554D49F0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554D4B40
        public void __Set__SystemInt32_VRCSDK3DynamicsContactComponentsVRCContactReceiver__SystemVoid(){} // RVA: 0x7FFD554D4C60
        public void __ToString__SystemString(){} // RVA: 0x7FFD554D4E20
        public void __ctor__SystemInt32__VRCSDK3DynamicsContactComponentsVRCContactReceiverArray(){} // RVA: 0x7FFD554D4F10
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD554D5000
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD554D50A0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD554D5140
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD554D51E0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD554D5280
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD554D5320
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD554D53C0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD554D54A0
    }

    public class ExternVRCSDK3DynamicsContactComponentsVRCContactSender : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD554D73C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFD554D7400
        public void .ctor(){} // RVA: 0x7FFD554D74B0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD554D7880
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD554D79B0
        public void __ApplyConfigurationChanges__SystemVoid(){} // RVA: 0x7FFD554D7AC0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD554D7B70
        public void __Equals__VRCDynamicsContactSenderProxy__SystemBoolean(){} // RVA: 0x7FFD554D7CD0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD554D7E30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD554D7F20
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD554D81D0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD554D8330
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFD554D8450
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFD554D8540
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD554D87C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD554D88B0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD554D8B60
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD554D8CC0
        public void __GetComponentInParent__T(){} // RVA: 0x7FFD554D8DE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFD554D8ED0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFD554D9150
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD554D92C0
        public void __GetComponent__T(){} // RVA: 0x7FFD554D93E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFD554D94C0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD554D9710
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD554D9800
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD554D9B30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD554D9C20
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD554D9F60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD554DA050
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD554DA360
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD554DA4D0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFD554DA600
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFD554DA6F0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD554DA9E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD554DAAD0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD554DAE10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD554DAF00
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD554DB210
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD554DB380
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFD554DB4C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFD554DB5B0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD554DB8A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD554DB990
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFD554DBC80
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD554DBDD0
        public void __GetComponents__TArray(){} // RVA: 0x7FFD554DBF00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFD554DBFF0
        public void __UpdateCollisionTags__SystemStringArray__SystemVoid(){} // RVA: 0x7FFD554DC2A0
        public void __UpdateContentTypes__VRCDynamicsDynamicsUsageFlags__SystemVoid(){} // RVA: 0x7FFD554DC380
        public void __get_Usage__VRCDynamicsDynamicsUsage(){} // RVA: 0x7FFD554DC460
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFD554DC540
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFD554DC660
        public void __get_height__SystemSingle(){} // RVA: 0x7FFD554DC7A0
        public void __set_height__SystemSingle(){} // RVA: 0x7FFD554DC880
        public void __get_position__UnityEngineVector3(){} // RVA: 0x7FFD554DC960
        public void __set_position__UnityEngineVector3(){} // RVA: 0x7FFD554DCA40
        public void __get_radius__SystemSingle(){} // RVA: 0x7FFD554DCB20
        public void __set_radius__SystemSingle(){} // RVA: 0x7FFD554DCC00
        public void __get_rotation__UnityEngineQuaternion(){} // RVA: 0x7FFD554DCCE0
        public void __set_rotation__UnityEngineQuaternion(){} // RVA: 0x7FFD554DCDC0
        public void __get_shapeType__VRCDynamicsContactBaseShapeType(){} // RVA: 0x7FFD554DCEA0
        public void __set_shapeType__VRCDynamicsContactBaseShapeType(){} // RVA: 0x7FFD554DCF80
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFD554DD060
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD554DD1A0
        public void __op_Equality__VRCDynamicsContactSenderProxy_VRCSDK3DynamicsContactComponentsVRCContactSender__SystemBoolean(){} // RVA: 0x7FFD554DD3A0
        public void __op_Equality__VRCSDK3DynamicsContactComponentsVRCContactSender_VRCDynamicsContactSenderProxy__SystemBoolean(){} // RVA: 0x7FFD554DD4C0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD554DD5D0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD554DD750
        public void __op_Inequality__VRCDynamicsContactSenderProxy_VRCSDK3DynamicsContactComponentsVRCContactSender__SystemBoolean(){} // RVA: 0x7FFD554DD950
        public void __op_Inequality__VRCSDK3DynamicsContactComponentsVRCContactSender_VRCDynamicsContactSenderProxy__SystemBoolean(){} // RVA: 0x7FFD554DDA70
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD554DDB80
        public void <.ctor>b__8_1(){} // RVA: 0x7FFD554DDCB0
    }

    public class ExternVRCSDK3DynamicsContactComponentsVRCContactSenderArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD554E0650
        public void .ctor(){} // RVA: 0x7FFD554E0690
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD554E0A60
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD554E0B90
        public void __Clone__SystemObject(){} // RVA: 0x7FFD554E0CA0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554E0D80
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554E0E60
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD554E0F30
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD554E1080
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD554E1120
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD554E1220
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD554E1340
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD554E1450
        public void __GetType__SystemType(){} // RVA: 0x7FFD554E1570
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD554E1660
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD554E1740
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD554E1860
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD554E19F0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD554E1B40
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD554E1C70
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD554E1D90
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD554E1F00
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD554E2040
        public void __Get__SystemInt32__VRCSDK3DynamicsContactComponentsVRCContactSender(){} // RVA: 0x7FFD554E2160
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD554E22A0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD554E2310
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554E2430
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554E25B0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554E2710
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD554E2840
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554E2960
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554E2AC0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554E2C10
        public void __Set__SystemInt32_VRCSDK3DynamicsContactComponentsVRCContactSender__SystemVoid(){} // RVA: 0x7FFD554E2D30
        public void __ToString__SystemString(){} // RVA: 0x7FFD554E2EF0
        public void __ctor__SystemInt32__VRCSDK3DynamicsContactComponentsVRCContactSenderArray(){} // RVA: 0x7FFD554E2FE0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD554E30D0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD554E3170
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD554E3210
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD554E32B0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD554E3350
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD554E33F0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD554E3490
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD554E3570
    }

    public class ExternVRCSDK3DynamicsPhysBoneComponentsVRCPhysBone : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD554E5490
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFD554E54D0
        public void .ctor(){} // RVA: 0x7FFD554E5580
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD554E5950
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD554E5A80
        public void __ApplyConfigurationChanges__SystemVoid(){} // RVA: 0x7FFD554E5B90
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD554E5C40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD554E5D30
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD554E5FE0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD554E6140
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFD554E6260
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFD554E6350
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD554E65D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD554E66C0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD554E6970
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD554E6AD0
        public void __GetComponentInParent__T(){} // RVA: 0x7FFD554E6BF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFD554E6CE0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFD554E6F60
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD554E70D0
        public void __GetComponent__T(){} // RVA: 0x7FFD554E71F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFD554E72D0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD554E7520
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD554E7610
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD554E7940
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD554E7A30
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD554E7D70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD554E7E60
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD554E8170
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD554E82E0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFD554E8410
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFD554E8500
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD554E87F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD554E88E0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD554E8C20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD554E8D10
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD554E9020
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD554E9190
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFD554E92D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFD554E93C0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD554E96B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD554E97A0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFD554E9A90
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD554E9BE0
        public void __GetComponents__TArray(){} // RVA: 0x7FFD554E9D10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFD554E9E00
        public void __ReleaseGrabs__SystemVoid(){} // RVA: 0x7FFD554EA0B0
        public void __ReleasePoses__SystemVoid(){} // RVA: 0x7FFD554EA1E0
        public void __get_Angle__SystemSingle(){} // RVA: 0x7FFD554EA360
        public void __get_IsGrabbed__SystemBoolean(){} // RVA: 0x7FFD554EA440
        public void __get_IsPosed__SystemBoolean(){} // RVA: 0x7FFD554EA520
        public void __get_Squish__SystemSingle(){} // RVA: 0x7FFD554EA600
        public void __get_Stretch__SystemSingle(){} // RVA: 0x7FFD554EA6E0
        public void __get_allowCollision__VRCDynamicsVRCPhysBoneBaseAdvancedBool(){} // RVA: 0x7FFD554EA7C0
        public void __set_allowCollision__VRCDynamicsVRCPhysBoneBaseAdvancedBool(){} // RVA: 0x7FFD554EA8A0
        public void __get_allowGrabbing__VRCDynamicsVRCPhysBoneBaseAdvancedBool(){} // RVA: 0x7FFD554EA980
        public void __set_allowGrabbing__VRCDynamicsVRCPhysBoneBaseAdvancedBool(){} // RVA: 0x7FFD554EAA60
        public void __get_allowPosing__VRCDynamicsVRCPhysBoneBaseAdvancedBool(){} // RVA: 0x7FFD554EAB40
        public void __set_allowPosing__VRCDynamicsVRCPhysBoneBaseAdvancedBool(){} // RVA: 0x7FFD554EAC20
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFD554EAD00
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFD554EAE20
        public void __get_grabMovement__SystemSingle(){} // RVA: 0x7FFD554EAF60
        public void __set_grabMovement__SystemSingle(){} // RVA: 0x7FFD554EB040
        public void __get_gravityCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EB120
        public void __set_gravityCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EB1F0
        public void __get_gravityFalloffCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EB320
        public void __set_gravityFalloffCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EB3F0
        public void __get_gravityFalloff__SystemSingle(){} // RVA: 0x7FFD554EB520
        public void __set_gravityFalloff__SystemSingle(){} // RVA: 0x7FFD554EB600
        public void __get_gravity__SystemSingle(){} // RVA: 0x7FFD554EB6E0
        public void __set_gravity__SystemSingle(){} // RVA: 0x7FFD554EB7C0
        public void __get_immobileCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EB8A0
        public void __set_immobileCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EB970
        public void __get_immobileType__VRCDynamicsVRCPhysBoneBaseImmobileType(){} // RVA: 0x7FFD554EBAA0
        public void __set_immobileType__VRCDynamicsVRCPhysBoneBaseImmobileType(){} // RVA: 0x7FFD554EBB80
        public void __get_immobile__SystemSingle(){} // RVA: 0x7FFD554EBC60
        public void __set_immobile__SystemSingle(){} // RVA: 0x7FFD554EBD40
        public void __get_limitRotationXCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EBE20
        public void __set_limitRotationXCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EBEF0
        public void __get_limitRotationYCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EC020
        public void __set_limitRotationYCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EC0F0
        public void __get_limitRotationZCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EC220
        public void __set_limitRotationZCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EC2F0
        public void __get_limitRotation__UnityEngineVector3(){} // RVA: 0x7FFD554EC420
        public void __set_limitRotation__UnityEngineVector3(){} // RVA: 0x7FFD554EC510
        public void __get_limitType__VRCDynamicsVRCPhysBoneBaseLimitType(){} // RVA: 0x7FFD554EC600
        public void __set_limitType__VRCDynamicsVRCPhysBoneBaseLimitType(){} // RVA: 0x7FFD554EC6E0
        public void __get_maxAngleXCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EC7C0
        public void __set_maxAngleXCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EC890
        public void __get_maxAngleX__SystemSingle(){} // RVA: 0x7FFD554EC9C0
        public void __set_maxAngleX__SystemSingle(){} // RVA: 0x7FFD554ECAA0
        public void __get_maxAngleZCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554ECB80
        public void __set_maxAngleZCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554ECC50
        public void __get_maxAngleZ__SystemSingle(){} // RVA: 0x7FFD554ECD80
        public void __set_maxAngleZ__SystemSingle(){} // RVA: 0x7FFD554ECE60
        public void __get_maxSquishCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554ECF40
        public void __set_maxSquishCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554ED010
        public void __get_maxSquish__SystemSingle(){} // RVA: 0x7FFD554ED140
        public void __set_maxSquish__SystemSingle(){} // RVA: 0x7FFD554ED220
        public void __get_maxStretchCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554ED300
        public void __set_maxStretchCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554ED3D0
        public void __get_maxStretch__SystemSingle(){} // RVA: 0x7FFD554ED500
        public void __set_maxStretch__SystemSingle(){} // RVA: 0x7FFD554ED5E0
        public void __get_pullCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554ED6C0
        public void __set_pullCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554ED790
        public void __get_pull__SystemSingle(){} // RVA: 0x7FFD554ED8B0
        public void __set_pull__SystemSingle(){} // RVA: 0x7FFD554ED990
        public void __get_radiusCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EDA70
        public void __set_radiusCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EDB40
        public void __get_radius__SystemSingle(){} // RVA: 0x7FFD554EDC70
        public void __set_radius__SystemSingle(){} // RVA: 0x7FFD554EDD50
        public void __get_snapToHand__SystemBoolean(){} // RVA: 0x7FFD554EDE30
        public void __set_snapToHand__SystemBoolean(){} // RVA: 0x7FFD554EDF10
        public void __get_springCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EDFF0
        public void __set_springCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EE0C0
        public void __get_spring__SystemSingle(){} // RVA: 0x7FFD554EE1E0
        public void __set_spring__SystemSingle(){} // RVA: 0x7FFD554EE2C0
        public void __get_stiffnessCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EE3A0
        public void __set_stiffnessCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EE470
        public void __get_stiffness__SystemSingle(){} // RVA: 0x7FFD554EE590
        public void __set_stiffness__SystemSingle(){} // RVA: 0x7FFD554EE670
        public void __get_stretchMotionCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EE750
        public void __set_stretchMotionCurve__UnityEngineAnimationCurve(){} // RVA: 0x7FFD554EE820
        public void __get_stretchMotion__SystemSingle(){} // RVA: 0x7FFD554EE950
        public void __set_stretchMotion__SystemSingle(){} // RVA: 0x7FFD554EEA30
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFD554EEB10
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD554EEC50
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD554EEE50
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD554EEFD0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD554EF1D0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFD554EF300
    }

    public class ExternVRCSDK3DynamicsPhysBoneComponentsVRCPhysBoneArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD554F4820
        public void .ctor(){} // RVA: 0x7FFD554F4860
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD554F4C30
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD554F4D60
        public void __Clone__SystemObject(){} // RVA: 0x7FFD554F4E70
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554F4F50
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554F5030
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD554F5100
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD554F5250
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD554F52F0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD554F53F0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD554F5510
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD554F5620
        public void __GetType__SystemType(){} // RVA: 0x7FFD554F5740
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD554F5830
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD554F5910
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD554F5A30
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD554F5BC0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD554F5D10
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD554F5E40
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD554F5F60
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD554F60D0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD554F6210
        public void __Get__SystemInt32__VRCSDK3DynamicsPhysBoneComponentsVRCPhysBone(){} // RVA: 0x7FFD554F6330
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD554F6470
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD554F64E0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554F6600
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554F6780
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554F68E0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD554F6A10
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554F6B30
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554F6C90
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554F6DE0
        public void __Set__SystemInt32_VRCSDK3DynamicsPhysBoneComponentsVRCPhysBone__SystemVoid(){} // RVA: 0x7FFD554F6F00
        public void __ToString__SystemString(){} // RVA: 0x7FFD554F70C0
        public void __ctor__SystemInt32__VRCSDK3DynamicsPhysBoneComponentsVRCPhysBoneArray(){} // RVA: 0x7FFD554F71B0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD554F72A0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD554F7340
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD554F73E0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD554F7480
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD554F7520
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD554F75C0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD554F7660
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD554F7740
    }

    public class ExternVRCSDK3ImageIVRCImageDownload : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD554F9660
        public void .ctor(){} // RVA: 0x7FFD554F96A0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD554F9A70
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD554F9BA0
        public void __Dispose__SystemVoid(){} // RVA: 0x7FFD554F9CB0
        public void __get_ErrorMessage__SystemString(){} // RVA: 0x7FFD554F9D40
        public void __get_Error__VRCSDK3ImageVRCImageDownloadError(){} // RVA: 0x7FFD554F9E00
        public void __get_Material__UnityEngineMaterial(){} // RVA: 0x7FFD554F9ED0
        public void __get_Progress__SystemSingle(){} // RVA: 0x7FFD554F9FD0
        public void __get_Result__UnityEngineTexture2D(){} // RVA: 0x7FFD554FA0A0
        public void __get_SizeInMemoryBytes__SystemInt32(){} // RVA: 0x7FFD554FA1A0
        public void __get_State__VRCSDK3ImageVRCImageDownloadState(){} // RVA: 0x7FFD554FA270
        public void __get_TextureInfo__VRCSDK3ImageTextureInfo(){} // RVA: 0x7FFD554FA330
        public void __get_UdonBehaviour__VRCUdonCommonInterfacesIUdonEventReceiver(){} // RVA: 0x7FFD554FA470
        public void __get_Url__VRCSDKBaseVRCUrl(){} // RVA: 0x7FFD554FA540
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD554FA600
    }

    public class ExternVRCSDK3ImageIVRCImageDownloadArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD554FB010
        public void .ctor(){} // RVA: 0x7FFD554FB050
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD554FB420
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD554FB550
        public void __Clone__SystemObject(){} // RVA: 0x7FFD554FB660
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554FB740
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554FB820
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD554FB8F0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD554FBA40
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD554FBAE0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD554FBBE0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD554FBD00
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD554FBE10
        public void __GetType__SystemType(){} // RVA: 0x7FFD554FBF30
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD554FC020
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD554FC100
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD554FC220
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD554FC3B0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD554FC500
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD554FC630
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD554FC750
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD554FC8C0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD554FCA00
        public void __Get__SystemInt32__VRCSDK3ImageIVRCImageDownload(){} // RVA: 0x7FFD554FCB20
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD554FCC00
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD554FCC70
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554FCD90
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554FCF10
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD554FD070
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD554FD1A0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554FD2C0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554FD420
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD554FD570
        public void __Set__SystemInt32_VRCSDK3ImageIVRCImageDownload__SystemVoid(){} // RVA: 0x7FFD554FD690
        public void __ToString__SystemString(){} // RVA: 0x7FFD554FD810
        public void __ctor__SystemInt32__VRCSDK3ImageIVRCImageDownloadArray(){} // RVA: 0x7FFD554FD900
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD554FDAA0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD554FDB40
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD554FDBE0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD554FDC80
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD554FDD20
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD554FDDC0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD554FDE60
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD554FDF40
    }

    public class ExternVRCSDK3ImageTextureInfo : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD554FFE60
        public void .ctor(){} // RVA: 0x7FFD554FFEA0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55500270
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD555003A0
        public void __ctor____VRCSDK3ImageTextureInfo(){} // RVA: 0x7FFD555004B0
        public void __get_AnisoLevel__SystemInt32(){} // RVA: 0x7FFD55500550
        public void __set_AnisoLevel__SystemInt32(){} // RVA: 0x7FFD555005F0
        public void __get_FilterMode__UnityEngineFilterMode(){} // RVA: 0x7FFD555006A0
        public void __set_FilterMode__UnityEngineFilterMode(){} // RVA: 0x7FFD55500740
        public void __get_GenerateMipMaps__SystemBoolean(){} // RVA: 0x7FFD555007F0
        public void __set_GenerateMipMaps__SystemBoolean(){} // RVA: 0x7FFD55500890
        public void __get_MaterialProperty__SystemString(){} // RVA: 0x7FFD55500940
        public void __set_MaterialProperty__SystemString(){} // RVA: 0x7FFD555009D0
        public void __get_WrapModeU__UnityEngineTextureWrapMode(){} // RVA: 0x7FFD55500AC0
        public void __set_WrapModeU__UnityEngineTextureWrapMode(){} // RVA: 0x7FFD55500B60
        public void __get_WrapModeV__UnityEngineTextureWrapMode(){} // RVA: 0x7FFD55500C10
        public void __set_WrapModeV__UnityEngineTextureWrapMode(){} // RVA: 0x7FFD55500CB0
        public void __get_WrapModeW__UnityEngineTextureWrapMode(){} // RVA: 0x7FFD55500D60
        public void __set_WrapModeW__UnityEngineTextureWrapMode(){} // RVA: 0x7FFD55500E00
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD55500EB0
    }

    public class ExternVRCSDK3ImageTextureInfoArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55501BD0
        public void .ctor(){} // RVA: 0x7FFD55501C10
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55501FE0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55502110
        public void __Clone__SystemObject(){} // RVA: 0x7FFD55502220
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55502300
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD555023E0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD555024B0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD55502600
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD555026A0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD555027A0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD555028C0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD555029D0
        public void __GetType__SystemType(){} // RVA: 0x7FFD55502AF0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD55502BE0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD55502CC0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD55502DE0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD55502F70
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD555030C0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD555031F0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD55503310
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD55503480
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD555035C0
        public void __Get__SystemInt32__VRCSDK3ImageTextureInfo(){} // RVA: 0x7FFD555036E0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD555037C0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD55503830
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55503950
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55503AD0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55503C30
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD55503D60
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55503E80
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55503FE0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55504130
        public void __Set__SystemInt32_VRCSDK3ImageTextureInfo__SystemVoid(){} // RVA: 0x7FFD55504250
        public void __ToString__SystemString(){} // RVA: 0x7FFD555043D0
        public void __ctor__SystemInt32__VRCSDK3ImageTextureInfoArray(){} // RVA: 0x7FFD555044C0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD55504660
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD55504700
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD555047A0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD55504840
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD555048E0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD55504980
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD55504A20
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD55504B00
    }

    public class ExternVRCSDK3ImageVRCImageDownloadError : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5550C9B0
        public void .ctor(){} // RVA: 0x7FFD5550C9F0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5550CDC0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5550CEF0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD5550D000
        public void __ToString__SystemString(){} // RVA: 0x7FFD5550D140
        public void __ToString__SystemString__SystemString(){} // RVA: 0x7FFD5550D1F0
        public void __get_AccessDenied__VRCSDK3ImageVRCImageDownloadError(){} // RVA: 0x7FFD5550D2C0
        public void __get_DownloadError__VRCSDK3ImageVRCImageDownloadError(){} // RVA: 0x7FFD5550D330
        public void __get_InvalidImage__VRCSDK3ImageVRCImageDownloadError(){} // RVA: 0x7FFD5550D3A0
        public void __get_InvalidURL__VRCSDK3ImageVRCImageDownloadError(){} // RVA: 0x7FFD5550D410
        public void __get_TooManyRequests__VRCSDK3ImageVRCImageDownloadError(){} // RVA: 0x7FFD5550D480
        public void __get_Unknown__VRCSDK3ImageVRCImageDownloadError(){} // RVA: 0x7FFD5550D4F0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD5550D560
    }

    public class ExternVRCSDK3ImageVRCImageDownloadState : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5550DE00
        public void .ctor(){} // RVA: 0x7FFD5550DE40
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5550E210
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5550E340
        public void __CompareTo__SystemObject__SystemInt32(){} // RVA: 0x7FFD5550E450
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD5550E580
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD5550E6C0
        public void __GetType__SystemType(){} // RVA: 0x7FFD5550E770
        public void __ToString__SystemString(){} // RVA: 0x7FFD5550E860
        public void __ToString__SystemString__SystemString(){} // RVA: 0x7FFD5550E910
        public void __get_Complete__VRCSDK3ImageVRCImageDownloadState(){} // RVA: 0x7FFD5550E9E0
        public void __get_Error__VRCSDK3ImageVRCImageDownloadState(){} // RVA: 0x7FFD5550EA50
        public void __get_Pending__VRCSDK3ImageVRCImageDownloadState(){} // RVA: 0x7FFD5550EAC0
        public void __get_Unknown__VRCSDK3ImageVRCImageDownloadState(){} // RVA: 0x7FFD5550EB30
        public void __get_Unloaded__VRCSDK3ImageVRCImageDownloadState(){} // RVA: 0x7FFD5550EBA0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD5550EC10
    }

    public class ExternVRCSDK3ImageVRCImageDownloadStateArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5550F620
        public void .ctor(){} // RVA: 0x7FFD5550F660
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5550FA30
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5550FB60
        public void __Clone__SystemObject(){} // RVA: 0x7FFD5550FC70
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5550FD50
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5550FE30
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD5550FF00
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD55510050
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD555100F0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD555101F0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD55510310
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD55510420
        public void __GetType__SystemType(){} // RVA: 0x7FFD55510540
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD55510630
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD55510710
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD55510830
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD555109C0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD55510B10
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD55510C40
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD55510D60
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD55510ED0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD55511010
        public void __Get__SystemInt32__VRCSDK3ImageVRCImageDownloadState(){} // RVA: 0x7FFD55511130
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD55511210
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD55511280
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD555113A0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55511520
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55511680
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD555117B0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD555118D0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55511A30
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55511B80
        public void __Set__SystemInt32_VRCSDK3ImageVRCImageDownloadState__SystemVoid(){} // RVA: 0x7FFD55511CA0
        public void __ToString__SystemString(){} // RVA: 0x7FFD55511D90
        public void __ctor__SystemInt32__VRCSDK3ImageVRCImageDownloadStateArray(){} // RVA: 0x7FFD55511E80
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD55512020
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD555120C0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD55512160
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD55512200
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD555122A0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD55512340
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD555123E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD555124C0
    }

    public class ExternVRCSDK3ImageVRCImageDownloader : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55506A20
        public void .ctor(){} // RVA: 0x7FFD55506A60
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55506E30
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55506F60
        public void __Dispose__SystemVoid(){} // RVA: 0x7FFD55507070
        public void __DownloadImage__VRCSDKBaseVRCUrl_UnityEngineMaterial_VRCUdonCommonInterfacesIUdonEventReceiver_VRCSDK3ImageTextureInfo__VRCSDK3ImageIVRCImageDownload(){} // RVA: 0x7FFD55507130
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD55507440
        public void __ctor____VRCSDK3ImageVRCImageDownloader(){} // RVA: 0x7FFD55507590
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD555076C0
    }

    public class ExternVRCSDK3ImageVRCImageDownloaderArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55507B90
        public void .ctor(){} // RVA: 0x7FFD55507BD0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55507FA0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD555080D0
        public void __Clone__SystemObject(){} // RVA: 0x7FFD555081E0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD555082C0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD555083A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD55508470
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD555085C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD55508660
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD55508760
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD55508880
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD55508990
        public void __GetType__SystemType(){} // RVA: 0x7FFD55508AB0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD55508BA0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD55508C80
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD55508DA0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD55508F30
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD55509080
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD555091B0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD555092D0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD55509440
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD55509580
        public void __Get__SystemInt32__VRCSDK3ImageVRCImageDownloader(){} // RVA: 0x7FFD555096A0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD55509780
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD555097F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55509910
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55509A90
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55509BF0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD55509D20
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55509E40
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55509FA0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5550A0F0
        public void __Set__SystemInt32_VRCSDK3ImageVRCImageDownloader__SystemVoid(){} // RVA: 0x7FFD5550A210
        public void __ToString__SystemString(){} // RVA: 0x7FFD5550A360
        public void __ctor__SystemInt32__VRCSDK3ImageVRCImageDownloaderArray(){} // RVA: 0x7FFD5550A450
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD5550A5F0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD5550A690
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD5550A730
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD5550A7D0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD5550A870
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD5550A910
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD5550A9B0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD5550AA90
    }

    public class ExternVRCSDK3InternalBestInstancesListener : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4FB76F50
        public void .ctor(){} // RVA: 0x7FFD4FB76F90
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD4FB77360
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD4FB77490
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD4FB775A0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD4FB776F0
        public void __GetType__SystemType(){} // RVA: 0x7FFD4FB777F0
        public void __StartListening__SystemVoid(){} // RVA: 0x7FFD4FB778E0
        public void __ToString__SystemString(){} // RVA: 0x7FFD4FB77AB0
        public void __ctor__SystemStringArray_SystemString_VRCUdonCommonInterfacesIUdonEventReceiver__VRCSDK3InternalBestInstancesListener(){} // RVA: 0x7FFD4FB77BA0
        public void __get_requestedPopulationBracket__SystemString(){} // RVA: 0x7FFD4FB77CF0
        public void __get_resultInstances__SystemStringArray(){} // RVA: 0x7FFD4FB77D80
        public void __set_resultInstances__SystemStringArray(){} // RVA: 0x7FFD4FB77E10
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD4FB77F00
    }

    public class ExternVRCSDK3InternalChangeSettings : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4FB79940
        public void .ctor(){} // RVA: 0x7FFD4FB79980
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD4FB79D50
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD4FB79E80
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD4FB79F90
        public void __GetChatBubbleVisibility__VRCSDK3InternalVRCChatBubbleVisibility(){} // RVA: 0x7FFD4FB7A0E0
        public void __GetComfortMode__VRCSDK3InternalVRCComfortMode(){} // RVA: 0x7FFD4FB7A1F0
        public void __GetComfortTurningEnabled__SystemBoolean(){} // RVA: 0x7FFD4FB7A300
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD4FB7A430
        public void __GetPersonalSpaceEnabled__SystemBoolean(){} // RVA: 0x7FFD4FB7A530
        public void __GetSafetyLevel__VRCSDK3InternalVRCSafetyLevels(){} // RVA: 0x7FFD4FB7A660
        public void __GetType__SystemType(){} // RVA: 0x7FFD4FB7A770
        public void __SetChatBubbleVisibility__VRCSDK3InternalVRCChatBubbleVisibility__SystemVoid(){} // RVA: 0x7FFD4FB7A860
        public void __SetComfortMode__VRCSDK3InternalVRCComfortMode__SystemVoid(){} // RVA: 0x7FFD4FB7A980
        public void __SetComfortTurningEnabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD4FB7AAA0
        public void __SetPersonalSpaceEnabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD4FB7ABD0
        public void __SetSafetyLevel__VRCSDK3InternalVRCSafetyLevels__SystemVoid(){} // RVA: 0x7FFD4FB7AD00
        public void __ToString__SystemString(){} // RVA: 0x7FFD4FB7AE20
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD4FB7AF10
    }

    public class ExternVRCSDK3InternalEventPortalsVRCEventPortalManager : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5528BCF0
        public void .ctor(){} // RVA: 0x7FFD5528BD30
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5528C100
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5528C230
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD5528C340
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD5528C4A0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD5528C590
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD5528C6F0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFD5528C810
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD5528C900
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD5528C9F0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD5528CB50
        public void __GetComponentInParent__T(){} // RVA: 0x7FFD5528CC70
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFD5528CD60
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD5528CED0
        public void __GetComponent__T(){} // RVA: 0x7FFD5528CFF0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD5528D0D0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD5528D1C0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD5528D2B0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD5528D3A0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD5528D510
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFD5528D640
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD5528D730
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD5528D820
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD5528D910
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD5528DA80
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFD5528DBC0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD5528DCB0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFD5528DDA0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD5528DEF0
        public void __GetComponents__TArray(){} // RVA: 0x7FFD5528E020
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD5528E110
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFD5528E200
        public void __GetType__SystemType(){} // RVA: 0x7FFD5528E2E0
        public void __RegisterPortal__VRCSDK3ComponentsVRCPortalMarker__SystemVoid(){} // RVA: 0x7FFD5528E3D0
        public void __RegisterPortal__VRCSDKBaseVRC_PortalMarker__SystemVoid(){} // RVA: 0x7FFD5528E510
        public void __ToString__SystemString(){} // RVA: 0x7FFD5528E650
        public void __UnregisterPortal__VRCSDK3ComponentsVRCPortalMarker__SystemVoid(){} // RVA: 0x7FFD5528E730
        public void __UnregisterPortal__VRCSDKBaseVRC_PortalMarker__SystemVoid(){} // RVA: 0x7FFD5528E870
        public void __get_destroyCancellationToken__SystemThreadingCancellationToken(){} // RVA: 0x7FFD5528E9B0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFD5528EA90
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFD5528EBB0
        public void __get_name__SystemString(){} // RVA: 0x7FFD5528ECF0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFD5528EDD0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD5528EF10
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD5528F110
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD5528F290
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD5528F490
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFD5528F5C0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD5528F6A0
    }

    public class ExternVRCSDK3InternalPedestalPreviewListener : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4FB805B0
        public void .ctor(){} // RVA: 0x7FFD4FB805F0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD4FB809C0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD4FB80AF0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD4FB80C00
        public void __GetAvatarPreview__UnityEngineTexture2D(){} // RVA: 0x7FFD4FB80D50
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD4FB80E70
        public void __GetType__SystemType(){} // RVA: 0x7FFD4FB80F70
        public void __StartListening__SystemVoid(){} // RVA: 0x7FFD4FB81060
        public void __ToString__SystemString(){} // RVA: 0x7FFD4FB81220
        public void __ctor__VRCSDK3ComponentsVRCAvatarPedestal_VRCUdonCommonInterfacesIUdonEventReceiver__VRCSDK3InternalPedestalPreviewListener(){} // RVA: 0x7FFD4FB81310
        public void __get_target__VRCSDK3ComponentsVRCAvatarPedestal(){} // RVA: 0x7FFD4FB81450
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD4FB81520
    }

    public class ExternVRCSDK3InternalPlatformChecker : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4FB89580
        public void .ctor(){} // RVA: 0x7FFD4FB895C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD4FB89990
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD4FB89AC0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD4FB89BD0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD4FB89D20
        public void __GetType__SystemType(){} // RVA: 0x7FFD4FB89E20
        public void __StartFetchingWorldInfo__SystemVoid(){} // RVA: 0x7FFD4FB89F10
        public void __ToString__SystemString(){} // RVA: 0x7FFD4FB8A0B0
        public void __ctor__SystemString_VRCUdonCommonInterfacesIUdonEventReceiver__VRCSDK3InternalPlatformChecker(){} // RVA: 0x7FFD4FB8A1A0
        public void __get_isUnavailableOnThisPlatform__SystemBoolean(){} // RVA: 0x7FFD4FB8A2C0
        public void __get_udonEventReceiver__VRCUdonCommonInterfacesIUdonEventReceiver(){} // RVA: 0x7FFD4FB8A360
        public void __get_worldID__SystemString(){} // RVA: 0x7FFD4FB8A400
        public void __set_isUnavailableOnThisPlatform__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD4FB8A490
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD4FB8A540
    }

    public class ExternVRCSDK3InternalToolsVRCInternalUserInterests : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4FB87F60
        public void .ctor(){} // RVA: 0x7FFD4FB87FA0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD4FB88370
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD4FB884A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD4FB885B0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD4FB88700
        public void __GetLastError__SystemString(){} // RVA: 0x7FFD4FB88800
        public void __GetResult__VRCSDK3DataDataDictionary(){} // RVA: 0x7FFD4FB888C0
        public void __GetType__SystemType(){} // RVA: 0x7FFD4FB88980
        public void __HasFinishedFetchingUserInterests__SystemBoolean(){} // RVA: 0x7FFD4FB88A70
        public void __SetUserInterests__VRCSDK3DataDataDictionary__SystemVoid(){} // RVA: 0x7FFD4FB88B30
        public void __StartFetchingUserInterests__SystemVoid(){} // RVA: 0x7FFD4FB88BA0
        public void __ToString__SystemString(){} // RVA: 0x7FFD4FB88BB0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD4FB88CA0
    }

    public class ExternVRCSDK3InternalVRCBestInstances : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4FB787A0
        public void .ctor(){} // RVA: 0x7FFD4FB787E0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD4FB78BB0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD4FB78CE0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD4FB78DF0
        public void __GetBestInstances__SystemStringArray_SystemString_VRCUdonCommonInterfacesIUdonEventReceiver__VRCSDK3InternalBestInstancesListener(){} // RVA: 0x7FFD4FB78F40
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD4FB790C0
        public void __GetType__SystemType(){} // RVA: 0x7FFD4FB791C0
        public void __ToString__SystemString(){} // RVA: 0x7FFD4FB792B0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD4FB793A0
    }

    public class ExternVRCSDK3InternalVRCChatBubbleVisibility : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4FB7BB70
        public void .ctor(){} // RVA: 0x7FFD4FB7BBB0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD4FB7BF80
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD4FB7C0B0
        public void __CompareTo__SystemObject__SystemInt32(){} // RVA: 0x7FFD4FB7C1C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD4FB7C2F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD4FB7C430
        public void __GetType__SystemType(){} // RVA: 0x7FFD4FB7C4E0
        public void __ToString__SystemString(){} // RVA: 0x7FFD4FB7C5D0
        public void __ToString__SystemString__SystemString(){} // RVA: 0x7FFD4FB7C680
        public void __get_Everyone__VRCSDK3InternalVRCChatBubbleVisibility(){} // RVA: 0x7FFD4FB7C750
        public void __get_Friends__VRCSDK3InternalVRCChatBubbleVisibility(){} // RVA: 0x7FFD4FB7C7C0
        public void __get_Mine__VRCSDK3InternalVRCChatBubbleVisibility(){} // RVA: 0x7FFD4FB7C830
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD4FB7C8A0
    }

    public class ExternVRCSDK3InternalVRCComfortMode : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4FB7D140
        public void .ctor(){} // RVA: 0x7FFD4FB7D180
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD4FB7D550
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD4FB7D680
        public void __CompareTo__SystemObject__SystemInt32(){} // RVA: 0x7FFD4FB7D790
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD4FB7D8C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD4FB7DA00
        public void __GetType__SystemType(){} // RVA: 0x7FFD4FB7DAB0
        public void __ToString__SystemString(){} // RVA: 0x7FFD4FB7DBA0
        public void __ToString__SystemString__SystemString(){} // RVA: 0x7FFD4FB7DC50
        public void __get_Holoport__VRCSDK3InternalVRCComfortMode(){} // RVA: 0x7FFD4FB7DD20
        public void __get_Standard__VRCSDK3InternalVRCComfortMode(){} // RVA: 0x7FFD4FB7DD90
        public void __get_TunnellingHigh__VRCSDK3InternalVRCComfortMode(){} // RVA: 0x7FFD4FB7DE00
        public void __get_TunnellingLow__VRCSDK3InternalVRCComfortMode(){} // RVA: 0x7FFD4FB7DE70
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD4FB7DEE0
    }

    public class ExternVRCSDK3InternalVRCExperiments : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4FB7E840
        public void .ctor(){} // RVA: 0x7FFD4FB7E880
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD4FB7EC50
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD4FB7ED80
        public void __GetExperimentPayload__SystemString_SystemString_SystemBoolean__SystemBoolean(){} // RVA: 0x7FFD4FB7EE90
        public void __GetExperimentPayload__SystemString_SystemString_SystemDouble__SystemDouble(){} // RVA: 0x7FFD4FB7F040
        public void __GetExperimentPayload__SystemString_SystemString_SystemInt32__SystemInt32(){} // RVA: 0x7FFD4FB7F1E0
        public void __GetExperimentPayload__SystemString_SystemString_SystemString__SystemString(){} // RVA: 0x7FFD4FB7F380
        public void __IsInExperimentSegment__SystemString_SystemString__SystemBoolean(){} // RVA: 0x7FFD4FB7F500
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD4FB7F670
    }

    public class ExternVRCSDK3InternalVRCInternalAvatarPedestal : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4FB81D00
        public void .ctor(){} // RVA: 0x7FFD4FB81D40
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD4FB82110
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD4FB82240
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD4FB82350
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD4FB824A0
        public void __GetPedestalListener__VRCSDK3ComponentsVRCAvatarPedestal_VRCUdonCommonInterfacesIUdonEventReceiver__VRCSDK3InternalPedestalPreviewListener(){} // RVA: 0x7FFD4FB825A0
        public void __GetType__SystemType(){} // RVA: 0x7FFD4FB82710
        public void __ToString__SystemString(){} // RVA: 0x7FFD4FB82800
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD4FB828F0
    }

    public class ExternVRCSDK3InternalVRCOpenMenu : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4FB7FC10
        public void .ctor(){} // RVA: 0x7FFD4FB7FC50
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD4FB80020
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD4FB80150
        public void __OpenFriendsList__SystemVoid(){} // RVA: 0x7FFD4FB1A650
        public void __OpenMassGifting__SystemVoid(){} // RVA: 0x7FFD4FB1A710
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD4FB80260
    }

    public class ExternVRCSDK3InternalVRCPrideCampaign : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4FB82E90
        public void .ctor(){} // RVA: 0x7FFD4FB82ED0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD4FB832A0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD4FB833D0
        public void __RefreshData__SystemVoid(){} // RVA: 0x7FFD4FB834E0
        public void __get_FriendParticipantCount__SystemInt32(){} // RVA: 0x7FFD4FB835C0
        public void __get_FriendParticipantIcons__UnityEngineSpriteArray(){} // RVA: 0x7FFD4FB836D0
        public void __get_FriendParticipantNames__SystemStringArray(){} // RVA: 0x7FFD4FB83800
        public void __get_GlobalDollarsGoal__SystemInt32(){} // RVA: 0x7FFD4FB838F0
        public void __get_GlobalDollarsRaised__SystemInt32(){} // RVA: 0x7FFD4FB83A10
        public void __get_GlobalParticipantCount__SystemInt32(){} // RVA: 0x7FFD4FB83B30
        public void __get_IsCampaignActive__SystemBoolean(){} // RVA: 0x7FFD4FB83C50
        public void __get_LastRefreshTimestampUTC__SystemDateTime(){} // RVA: 0x7FFD4FB83D60
        public void __get_LocalGiftsCount__SystemInt32(){} // RVA: 0x7FFD4FB83E60
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD4FB83F80
    }

    public class ExternVRCSDK3InternalVRCUrlConstructor : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4FB85040
        public void .ctor(){} // RVA: 0x7FFD4FB85080
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD4FB85450
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD4FB85580
        public void __GetAllowlistedUrl__SystemString__VRCSDKBaseVRCUrl(){} // RVA: 0x7FFD4FB85690
        public void __GetUrl__SystemString__VRCSDKBaseVRCUrl(){} // RVA: 0x7FFD4FB857A0
        public void __GetYouTubeUrlFromId__SystemString__VRCSDKBaseVRCUrl(){} // RVA: 0x7FFD4FB85930
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD4FB859D0
    }

    public class ExternVRCSDK3InternalVRCUrlLauncher : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4FB85DF0
        public void .ctor(){} // RVA: 0x7FFD4FB85E30
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD4FB86200
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD4FB86330
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD4FB86440
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD4FB86590
        public void __GetType__SystemType(){} // RVA: 0x7FFD4FB86690
        public void __OpenURLWithData__VRCSDKBaseVRCUrl_SystemString__SystemVoid(){} // RVA: 0x7FFD4FB86780
        public void __ToString__SystemString(){} // RVA: 0x7FFD4FB86830
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD4FB86920
    }

    public class ExternVRCSDK3InternalVRCUserFirstJoin : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4FB86EC0
        public void .ctor(){} // RVA: 0x7FFD4FB86F00
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD4FB872D0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD4FB87400
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD4FB87510
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD4FB87660
        public void __GetIsNewUser__VRCUdonCommonInterfacesIUdonEventReceiver__SystemVoid(){} // RVA: 0x7FFD4FB87760
        public void __GetType__SystemType(){} // RVA: 0x7FFD4FB877E0
        public void __ToString__SystemString(){} // RVA: 0x7FFD4FB878D0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD4FB879C0
    }

    public class ExternVRCSDK3InternalVRCWorldPlatformChecker : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD4FB8AEA0
        public void .ctor(){} // RVA: 0x7FFD4FB8AEE0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD4FB8B2B0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD4FB8B3E0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD4FB8B4F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD4FB8B640
        public void __GetPlatformChecker__SystemString_VRCUdonCommonInterfacesIUdonEventReceiver__VRCSDK3InternalPlatformChecker(){} // RVA: 0x7FFD4FB8B740
        public void __GetType__SystemType(){} // RVA: 0x7FFD4FB8B890
        public void __ToString__SystemString(){} // RVA: 0x7FFD4FB8B980
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD4FB8BA70
    }

    public class ExternVRCSDK3MidiMidiData : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD555143E0
        public void .ctor(){} // RVA: 0x7FFD55514420
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD555147F0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55514920
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD55514A30
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD55514B80
        public void __GetType__SystemType(){} // RVA: 0x7FFD55514C80
        public void __ToString__SystemString(){} // RVA: 0x7FFD55514D70
        public void __ctor____VRCSDK3MidiMidiData(){} // RVA: 0x7FFD55514E60
        public void __get_bpm__SystemByte(){} // RVA: 0x7FFD55514EE0
        public void __set_bpm__SystemByte(){} // RVA: 0x7FFD55514F80
        public void __get_tracks__VRCSDK3MidiMidiDataMidiTrackArray(){} // RVA: 0x7FFD55515030
        public void __set_tracks__VRCSDK3MidiMidiDataMidiTrackArray(){} // RVA: 0x7FFD555150C0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD555151B0
    }

    public class ExternVRCSDK3MidiMidiDataMidiBlock : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55515A50
        public void .ctor(){} // RVA: 0x7FFD55515A90
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55515E60
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55515F90
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD555160A0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD555161F0
        public void __GetType__SystemType(){} // RVA: 0x7FFD555162F0
        public void __ToString__SystemString(){} // RVA: 0x7FFD555163E0
        public void __ctor____VRCSDK3MidiMidiDataMidiBlock(){} // RVA: 0x7FFD55516490
        public void __get_channel__SystemInt32(){} // RVA: 0x7FFD55516510
        public void __set_channel__SystemInt32(){} // RVA: 0x7FFD555165B0
        public void __get_endTimeMs__SystemSingle(){} // RVA: 0x7FFD55516660
        public void __set_endTimeMs__SystemSingle(){} // RVA: 0x7FFD55516700
        public void __get_endTimeSec__SystemSingle(){} // RVA: 0x7FFD555167B0
        public void __get_lengthSec__SystemSingle(){} // RVA: 0x7FFD55516850
        public void __get_note__SystemByte(){} // RVA: 0x7FFD55516900
        public void __set_note__SystemByte(){} // RVA: 0x7FFD555169A0
        public void __get_startTimeMs__SystemSingle(){} // RVA: 0x7FFD55516A50
        public void __set_startTimeMs__SystemSingle(){} // RVA: 0x7FFD55516AF0
        public void __get_startTimeSec__SystemSingle(){} // RVA: 0x7FFD55516BA0
        public void __get_velocity__SystemByte(){} // RVA: 0x7FFD55516C40
        public void __set_velocity__SystemByte(){} // RVA: 0x7FFD55516CE0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD55516D90
    }

    public class ExternVRCSDK3MidiMidiDataMidiBlockArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55517CF0
        public void .ctor(){} // RVA: 0x7FFD55517D30
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55518100
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55518230
        public void __Clone__SystemObject(){} // RVA: 0x7FFD55518340
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55518420
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55518500
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD555185D0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD55518720
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD555187C0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD555188C0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD555189E0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD55518AF0
        public void __GetType__SystemType(){} // RVA: 0x7FFD55518C10
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD55518D00
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD55518DE0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD55518F00
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD55519090
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD555191E0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD55519310
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD55519430
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD555195A0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD555196E0
        public void __Get__SystemInt32__VRCSDK3MidiMidiDataMidiBlock(){} // RVA: 0x7FFD55519800
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD555198E0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD55519950
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55519A70
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55519BF0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55519D50
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD55519E80
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55519FA0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5551A100
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5551A250
        public void __Set__SystemInt32_VRCSDK3MidiMidiDataMidiBlock__SystemVoid(){} // RVA: 0x7FFD5551A370
        public void __ToString__SystemString(){} // RVA: 0x7FFD5551A4F0
        public void __ctor__SystemInt32__VRCSDK3MidiMidiDataMidiBlockArray(){} // RVA: 0x7FFD5551A5E0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD5551A690
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD5551A730
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD5551A7D0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD5551A870
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD5551A910
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD5551A9B0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD5551AA50
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD5551AB30
    }

    public class ExternVRCSDK3MidiMidiDataMidiTrack : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5551CA50
        public void .ctor(){} // RVA: 0x7FFD5551CA90
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5551CE60
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5551CF90
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD5551D0A0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD5551D1F0
        public void __GetType__SystemType(){} // RVA: 0x7FFD5551D2F0
        public void __SetBlocks__SystemCollectionsGenericListVRCSDK3MidiMidiDataMidiBlock__SystemVoid(){} // RVA: 0x7FFD5551D3E0
        public void __ToString__SystemString(){} // RVA: 0x7FFD5551D570
        public void __ctor____VRCSDK3MidiMidiDataMidiTrack(){} // RVA: 0x7FFD5551D660
        public void __get_blocks__VRCSDK3MidiMidiDataMidiBlockArray(){} // RVA: 0x7FFD5551D6F0
        public void __set_blocks__VRCSDK3MidiMidiDataMidiBlockArray(){} // RVA: 0x7FFD5551D780
        public void __get_maxNote__SystemByte(){} // RVA: 0x7FFD5551D870
        public void __set_maxNote__SystemByte(){} // RVA: 0x7FFD5551D910
        public void __get_maxVelocity__SystemByte(){} // RVA: 0x7FFD5551D9C0
        public void __set_maxVelocity__SystemByte(){} // RVA: 0x7FFD5551DA60
        public void __get_minNote__SystemByte(){} // RVA: 0x7FFD5551DB10
        public void __set_minNote__SystemByte(){} // RVA: 0x7FFD5551DBB0
        public void __get_minVelocity__SystemByte(){} // RVA: 0x7FFD5551DC60
        public void __set_minVelocity__SystemByte(){} // RVA: 0x7FFD5551DD00
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD5551DDB0
    }

    public class ExternVRCSDK3MidiMidiDataMidiTrackArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5551EB90
        public void .ctor(){} // RVA: 0x7FFD5551EBD0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5551EFA0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5551F0D0
        public void __Clone__SystemObject(){} // RVA: 0x7FFD5551F1E0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5551F2C0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5551F3A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD5551F470
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD5551F5C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD5551F660
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD5551F760
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD5551F880
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD5551F990
        public void __GetType__SystemType(){} // RVA: 0x7FFD5551FAB0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD5551FBA0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD5551FC80
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD5551FDA0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD5551FF30
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD55520080
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD555201B0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD555202D0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD55520440
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD55520580
        public void __Get__SystemInt32__VRCSDK3MidiMidiDataMidiTrack(){} // RVA: 0x7FFD555206A0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD55520780
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD555207F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55520910
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55520A90
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55520BF0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD55520D20
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55520E40
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55520FA0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD555210F0
        public void __Set__SystemInt32_VRCSDK3MidiMidiDataMidiTrack__SystemVoid(){} // RVA: 0x7FFD55521210
        public void __ToString__SystemString(){} // RVA: 0x7FFD55521390
        public void __ctor__SystemInt32__VRCSDK3MidiMidiDataMidiTrackArray(){} // RVA: 0x7FFD55521480
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD55521530
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD555215D0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD55521670
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD55521710
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD555217B0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD55521850
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD555218F0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD555219D0
    }

    public class ExternVRCSDK3MidiVRCMidiPlayer : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD555238F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFD55523930
        public void .ctor(){} // RVA: 0x7FFD555239E0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55523DB0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55523EE0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD55523FF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD555240E0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD55524390
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD555244F0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFD55524610
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFD55524700
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD55524980
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD55524A70
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD55524D20
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD55524E80
        public void __GetComponentInParent__T(){} // RVA: 0x7FFD55524FA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFD55525090
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFD55525310
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD55525480
        public void __GetComponent__T(){} // RVA: 0x7FFD555255A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFD55525680
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD555258D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD555259C0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD55525CF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD55525DE0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD55526120
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD55526210
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD55526520
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD55526690
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFD555267C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFD555268B0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD55526BA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD55526C90
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD55526FD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD555270C0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD555273D0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD55527540
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFD55527680
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFD55527770
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD55527A60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD55527B50
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFD55527E40
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD55527F90
        public void __GetComponents__TArray(){} // RVA: 0x7FFD555280C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFD555281B0
        public void __Play__SystemVoid(){} // RVA: 0x7FFD55528460
        public void __Stop__SystemVoid(){} // RVA: 0x7FFD55528510
        public void __get_MidiData__VRCSDK3MidiMidiData(){} // RVA: 0x7FFD555285C0
        public void __get_Time__SystemSingle(){} // RVA: 0x7FFD555286A0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD555287D0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD555289D0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD55528B50
        public void __set_Time__SystemSingle__SystemVoid(){} // RVA: 0x7FFD55528D50
        public void <.ctor>b__8_1(){} // RVA: 0x7FFD55528E90
    }

    public class ExternVRCSDK3MidiVRCMidiPlayerArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5552A9F0
        public void .ctor(){} // RVA: 0x7FFD5552AA30
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5552AE00
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5552AF30
        public void __Clone__SystemObject(){} // RVA: 0x7FFD5552B040
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5552B120
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5552B200
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD5552B2D0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD5552B420
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD5552B4C0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD5552B5C0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD5552B6E0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD5552B7F0
        public void __GetType__SystemType(){} // RVA: 0x7FFD5552B910
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD5552BA00
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD5552BAE0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD5552BC00
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD5552BD90
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD5552BEE0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD5552C010
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD5552C130
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD5552C2A0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD5552C3E0
        public void __Get__SystemInt32__VRCSDK3MidiVRCMidiPlayer(){} // RVA: 0x7FFD5552C500
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD5552C640
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD5552C6B0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5552C7D0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5552C950
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5552CAB0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD5552CBE0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5552CD00
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5552CE60
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5552CFB0
        public void __Set__SystemInt32_VRCSDK3MidiVRCMidiPlayer__SystemVoid(){} // RVA: 0x7FFD5552D0D0
        public void __ToString__SystemString(){} // RVA: 0x7FFD5552D290
        public void __ctor__SystemInt32__VRCSDK3MidiVRCMidiPlayerArray(){} // RVA: 0x7FFD5552D380
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD5552D470
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD5552D510
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD5552D5B0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD5552D650
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD5552D6F0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD5552D790
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD5552D830
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD5552D910
    }

    public class ExternVRCSDK3NetworkStats : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5552F830
        public void .ctor(){} // RVA: 0x7FFD5552F870
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5552FC40
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5552FD70
        public void __BytesPerSecondAverage__UnityEngineGameObject__SystemSingle(){} // RVA: 0x7FFD5552FE80
        public void __BytesPerSecondAverage__VRCSDKBaseVRCPlayerApi__SystemSingle(){} // RVA: 0x7FFD5552FFB0
        public void __FinalDelay__UnityEngineGameObject__SystemSingle(){} // RVA: 0x7FFD555300B0
        public void __FinalDelay__VRCSDKBaseVRCPlayerApi__SystemSingle(){} // RVA: 0x7FFD555301E0
        public void __GroupDelay__UnityEngineGameObject__SystemSingle(){} // RVA: 0x7FFD555302E0
        public void __GroupDelay__VRCSDKBaseVRCPlayerApi__SystemSingle(){} // RVA: 0x7FFD55530410
        public void __Group__UnityEngineGameObject__SystemInt32(){} // RVA: 0x7FFD55530510
        public void __Group__VRCSDKBaseVRCPlayerApi__SystemInt32(){} // RVA: 0x7FFD55530640
        public void __LastReceiveTime__UnityEngineGameObject__SystemSingle(){} // RVA: 0x7FFD55530740
        public void __LastReceiveTime__VRCSDKBaseVRCPlayerApi__SystemSingle(){} // RVA: 0x7FFD55530870
        public void __LastSendTime__UnityEngineGameObject__SystemSingle(){} // RVA: 0x7FFD55530970
        public void __LastSendTime__VRCSDKBaseVRCPlayerApi__SystemSingle(){} // RVA: 0x7FFD55530AA0
        public void __ReceiveInterval__UnityEngineGameObject__SystemSingle(){} // RVA: 0x7FFD55530BA0
        public void __ReceiveInterval__VRCSDKBaseVRCPlayerApi__SystemSingle(){} // RVA: 0x7FFD55530CD0
        public void __ReliableEventsInOutboundQueue__UnityEngineGameObject__SystemInt32(){} // RVA: 0x7FFD55530DD0
        public void __ReliableEventsInOutboundQueue__VRCSDKBaseVRCPlayerApi__SystemInt32(){} // RVA: 0x7FFD55530F00
        public void __Size__UnityEngineGameObject__SystemInt32(){} // RVA: 0x7FFD55531000
        public void __Size__VRCSDKBaseVRCPlayerApi__SystemInt32(){} // RVA: 0x7FFD55531130
        public void __Sleeping__UnityEngineGameObject__SystemBoolean(){} // RVA: 0x7FFD55531230
        public void __Sleeping__VRCSDKBaseVRCPlayerApi__SystemBoolean(){} // RVA: 0x7FFD55531360
        public void __TotalBytes__UnityEngineGameObject__SystemInt32(){} // RVA: 0x7FFD55531460
        public void __TotalBytes__VRCSDKBaseVRCPlayerApi__SystemInt32(){} // RVA: 0x7FFD55531590
        public void __UpdateInterval__UnityEngineGameObject__SystemSingle(){} // RVA: 0x7FFD55531690
        public void __UpdateInterval__VRCSDKBaseVRCPlayerApi__SystemSingle(){} // RVA: 0x7FFD555317C0
        public void __get_BytesInAverage__SystemSingle(){} // RVA: 0x7FFD555318C0
        public void __get_BytesInMax__SystemInt32(){} // RVA: 0x7FFD55531980
        public void __get_BytesOutAverage__SystemSingle(){} // RVA: 0x7FFD55531A40
        public void __get_BytesOutMax__SystemInt32(){} // RVA: 0x7FFD55531B00
        public void __get_HitchesPerNetworkTick__SystemSingle(){} // RVA: 0x7FFD55531BC0
        public void __get_RoundTripTime__SystemInt32(){} // RVA: 0x7FFD55531C80
        public void __get_RoundTripVariance__SystemSingle(){} // RVA: 0x7FFD55531D40
        public void __get_Suffering__SystemSingle(){} // RVA: 0x7FFD55531E00
        public void __get_ThroughputPercentage__SystemSingle(){} // RVA: 0x7FFD55531EC0
        public void __get_TimeInRoom__SystemSingle(){} // RVA: 0x7FFD55531F80
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD55532070
    }

    public class ExternVRCSDK3PersistencePlayerData : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55533BD0
        public void .ctor(){} // RVA: 0x7FFD55533C10
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55533FE0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55534110
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD55534220
        public void __GetBool__VRCSDKBaseVRCPlayerApi_SystemString__SystemBoolean(){} // RVA: 0x7FFD55534370
        public void __GetByte__VRCSDKBaseVRCPlayerApi_SystemString__SystemByte(){} // RVA: 0x7FFD55534450
        public void __GetBytes__VRCSDKBaseVRCPlayerApi_SystemString__SystemByteArray(){} // RVA: 0x7FFD55534530
        public void __GetColor32__VRCSDKBaseVRCPlayerApi_SystemString__UnityEngineColor32(){} // RVA: 0x7FFD55534600
        public void __GetColor__VRCSDKBaseVRCPlayerApi_SystemString__UnityEngineColor(){} // RVA: 0x7FFD555346D0
        public void __GetDouble__VRCSDKBaseVRCPlayerApi_SystemString__SystemDouble(){} // RVA: 0x7FFD55534810
        public void __GetFloat__VRCSDKBaseVRCPlayerApi_SystemString__SystemSingle(){} // RVA: 0x7FFD555348E0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD555349C0
        public void __GetInt__VRCSDKBaseVRCPlayerApi_SystemString__SystemInt32(){} // RVA: 0x7FFD55534AC0
        public void __GetKeys__VRCSDKBaseVRCPlayerApi__SystemCollectionsGenericIEnumerableSystemString(){} // RVA: 0x7FFD55534BA0
        public void __GetLong__VRCSDKBaseVRCPlayerApi_SystemString__SystemInt64(){} // RVA: 0x7FFD55534CB0
        public void __GetQuaternion__VRCSDKBaseVRCPlayerApi_SystemString__UnityEngineQuaternion(){} // RVA: 0x7FFD55534D80
        public void __GetSByte__VRCSDKBaseVRCPlayerApi_SystemString__SystemSByte(){} // RVA: 0x7FFD55534EC0
        public void __GetShort__VRCSDKBaseVRCPlayerApi_SystemString__SystemInt16(){} // RVA: 0x7FFD55534F90
        public void __GetString__VRCSDKBaseVRCPlayerApi_SystemString__SystemString(){} // RVA: 0x7FFD55535060
        public void __GetType__SystemType(){} // RVA: 0x7FFD55535130
        public void __GetType__VRCSDKBaseVRCPlayerApi_SystemString__SystemType(){} // RVA: 0x7FFD55535220
        public void __GetUInt__VRCSDKBaseVRCPlayerApi_SystemString__SystemUInt32(){} // RVA: 0x7FFD555352F0
        public void __GetULong__VRCSDKBaseVRCPlayerApi_SystemString__SystemUInt64(){} // RVA: 0x7FFD555353C0
        public void __GetUShort__VRCSDKBaseVRCPlayerApi_SystemString__SystemUInt16(){} // RVA: 0x7FFD55535490
        public void __GetVector2__VRCSDKBaseVRCPlayerApi_SystemString__UnityEngineVector2(){} // RVA: 0x7FFD55535560
        public void __GetVector3__VRCSDKBaseVRCPlayerApi_SystemString__UnityEngineVector3(){} // RVA: 0x7FFD55535630
        public void __GetVector4__VRCSDKBaseVRCPlayerApi_SystemString__UnityEngineVector4(){} // RVA: 0x7FFD55535790
        public void __HasKey__VRCSDKBaseVRCPlayerApi_SystemString__SystemBoolean(){} // RVA: 0x7FFD555358D0
        public void __IsType__VRCSDKBaseVRCPlayerApi_SystemString_SystemType__SystemBoolean(){} // RVA: 0x7FFD55535A00
        public void __SetBool__SystemString_SystemBoolean__SystemVoid(){} // RVA: 0x7FFD55535B60
        public void __SetByte__SystemString_SystemByte__SystemVoid(){} // RVA: 0x7FFD55535C60
        public void __SetBytes__SystemString_SystemByteArray__SystemVoid(){} // RVA: 0x7FFD55535D60
        public void __SetColor32__SystemString_UnityEngineColor32__SystemVoid(){} // RVA: 0x7FFD55535E50
        public void __SetColor__SystemString_UnityEngineColor__SystemVoid(){} // RVA: 0x7FFD55535F40
        public void __SetDouble__SystemString_SystemDouble__SystemVoid(){} // RVA: 0x7FFD55536050
        public void __SetFloat__SystemString_SystemSingle__SystemVoid(){} // RVA: 0x7FFD55536150
        public void __SetInt__SystemString_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55536260
        public void __SetLong__SystemString_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55536360
        public void __SetQuaternion__SystemString_UnityEngineQuaternion__SystemVoid(){} // RVA: 0x7FFD55536450
        public void __SetSByte__SystemString_SystemSByte__SystemVoid(){} // RVA: 0x7FFD55536560
        public void __SetShort__SystemString_SystemInt16__SystemVoid(){} // RVA: 0x7FFD55536650
        public void __SetString__SystemString_SystemString__SystemVoid(){} // RVA: 0x7FFD55536740
        public void __SetUInt__SystemString_SystemUInt32__SystemVoid(){} // RVA: 0x7FFD55536820
        public void __SetULong__SystemString_SystemUInt64__SystemVoid(){} // RVA: 0x7FFD55536920
        public void __SetUShort__SystemString_SystemUInt16__SystemVoid(){} // RVA: 0x7FFD55536A10
        public void __SetVector2__SystemString_UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFD55536B00
        public void __SetVector3__SystemString_UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFD55536C00
        public void __SetVector4__SystemString_UnityEngineVector4__SystemVoid(){} // RVA: 0x7FFD55536D20
        public void __ToString__SystemString(){} // RVA: 0x7FFD55536E30
        public void __TryGetBool__VRCSDKBaseVRCPlayerApi_SystemString_SystemBooleanRef__SystemBoolean(){} // RVA: 0x7FFD55536F20
        public void __TryGetByte__VRCSDKBaseVRCPlayerApi_SystemString_SystemByteRef__SystemBoolean(){} // RVA: 0x7FFD55537100
        public void __TryGetBytes__VRCSDKBaseVRCPlayerApi_SystemString_SystemByteArrayRef__SystemBoolean(){} // RVA: 0x7FFD555372F0
        public void __TryGetColor32__VRCSDKBaseVRCPlayerApi_SystemString_UnityEngineColor32Ref__SystemBoolean(){} // RVA: 0x7FFD55537590
        public void __TryGetColor__VRCSDKBaseVRCPlayerApi_SystemString_UnityEngineColorRef__SystemBoolean(){} // RVA: 0x7FFD55537770
        public void __TryGetDouble__VRCSDKBaseVRCPlayerApi_SystemString_SystemDoubleRef__SystemBoolean(){} // RVA: 0x7FFD555379B0
        public void __TryGetFloat__VRCSDKBaseVRCPlayerApi_SystemString_SystemSingleRef__SystemBoolean(){} // RVA: 0x7FFD55537B90
        public void __TryGetInt__VRCSDKBaseVRCPlayerApi_SystemString_SystemInt32Ref__SystemBoolean(){} // RVA: 0x7FFD55537D80
        public void __TryGetLong__VRCSDKBaseVRCPlayerApi_SystemString_SystemInt64Ref__SystemBoolean(){} // RVA: 0x7FFD55537F80
        public void __TryGetQuaternion__VRCSDKBaseVRCPlayerApi_SystemString_UnityEngineQuaternionRef__SystemBoolean(){} // RVA: 0x7FFD55538170
        public void __TryGetSByte__VRCSDKBaseVRCPlayerApi_SystemString_SystemSByteRef__SystemBoolean(){} // RVA: 0x7FFD555383B0
        public void __TryGetShort__VRCSDKBaseVRCPlayerApi_SystemString_SystemInt16Ref__SystemBoolean(){} // RVA: 0x7FFD55538590
        public void __TryGetString__VRCSDKBaseVRCPlayerApi_SystemString_SystemStringRef__SystemBoolean(){} // RVA: 0x7FFD55538780
        public void __TryGetType__VRCSDKBaseVRCPlayerApi_SystemString_SystemTypeRef__SystemBoolean(){} // RVA: 0x7FFD55538A20
        public void __TryGetUInt__VRCSDKBaseVRCPlayerApi_SystemString_SystemUInt32Ref__SystemBoolean(){} // RVA: 0x7FFD55538BC0
        public void __TryGetULong__VRCSDKBaseVRCPlayerApi_SystemString_SystemUInt64Ref__SystemBoolean(){} // RVA: 0x7FFD55538DB0
        public void __TryGetUShort__VRCSDKBaseVRCPlayerApi_SystemString_SystemUInt16Ref__SystemBoolean(){} // RVA: 0x7FFD55538FA0
        public void __TryGetVector2__VRCSDKBaseVRCPlayerApi_SystemString_UnityEngineVector2Ref__SystemBoolean(){} // RVA: 0x7FFD55539190
        public void __TryGetVector3__VRCSDKBaseVRCPlayerApi_SystemString_UnityEngineVector3Ref__SystemBoolean(){} // RVA: 0x7FFD55539390
        public void __TryGetVector4__VRCSDKBaseVRCPlayerApi_SystemString_UnityEngineVector4Ref__SystemBoolean(){} // RVA: 0x7FFD555395F0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD55539830
    }

    public class ExternVRCSDK3PersistencePlayerDataInfo : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5553CB90
        public void .ctor(){} // RVA: 0x7FFD5553CBD0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5553CFA0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5553D0D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD5553D1E0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD5553D320
        public void __GetType__SystemType(){} // RVA: 0x7FFD5553D3D0
        public void __ToString__SystemString(){} // RVA: 0x7FFD5553D4C0
        public void __ctor__SystemString_VRCSDK3PersistencePlayerDataState__VRCSDK3PersistencePlayerDataInfo(){} // RVA: 0x7FFD5553D570
        public void __get_Key__SystemString(){} // RVA: 0x7FFD5553D6B0
        public void __get_State__VRCSDK3PersistencePlayerDataState(){} // RVA: 0x7FFD5553D790
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD5553D870
    }

    public class ExternVRCSDK3PersistencePlayerDataInfoArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5553DF90
        public void .ctor(){} // RVA: 0x7FFD5553DFD0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5553E3A0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5553E4D0
        public void __Clone__SystemObject(){} // RVA: 0x7FFD5553E5E0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5553E6C0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5553E7A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD5553E870
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD5553E9C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD5553EA60
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD5553EB60
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD5553EC80
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD5553ED90
        public void __GetType__SystemType(){} // RVA: 0x7FFD5553EEB0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD5553EFA0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD5553F080
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD5553F1A0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD5553F330
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD5553F480
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD5553F5B0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD5553F6D0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD5553F840
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD5553F980
        public void __Get__SystemInt32__VRCSDK3PersistencePlayerDataInfo(){} // RVA: 0x7FFD5553FAA0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD5553FB90
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD5553FC00
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5553FD20
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5553FEA0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55540000
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD55540130
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55540250
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD555403B0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55540500
        public void __Set__SystemInt32_VRCSDK3PersistencePlayerDataInfo__SystemVoid(){} // RVA: 0x7FFD55540620
        public void __ToString__SystemString(){} // RVA: 0x7FFD55540780
        public void __ctor__SystemInt32__VRCSDK3PersistencePlayerDataInfoArray(){} // RVA: 0x7FFD55540870
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD55540A10
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD55540AB0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD55540B50
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD55540BF0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD55540C90
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD55540D30
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD55540DD0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD55540EB0
    }

    public class ExternVRCSDK3PlatformScreenUpdateData : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55542DD0
        public void .ctor(){} // RVA: 0x7FFD55542E10
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD555431E0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55543310
        public void __get_orientation__VRCSDKBasePlatformVRCOrientation(){} // RVA: 0x7FFD55543420
        public void __get_resolution__UnityEngineVector2(){} // RVA: 0x7FFD55543500
        public void __get_type__VRCSDK3PlatformScreenUpdateType(){} // RVA: 0x7FFD555435E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD555436C0
    }

    public class ExternVRCSDK3PropsVRCPropApi : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55543AE0
        public void .ctor(){} // RVA: 0x7FFD55543B20
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55543EF0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55544020
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD55544130
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD55544280
        public void __GetIsConsumable__SystemBoolean(){} // RVA: 0x7FFD55544380
        public void __GetIsPlayingConsumableEffect__SystemBoolean(){} // RVA: 0x7FFD55544430
        public void __GetItemId__SystemString(){} // RVA: 0x7FFD555444E0
        public void __GetNearestPlayerInRange__SystemSingle__VRCSDKBaseVRCPlayerApi(){} // RVA: 0x7FFD55544590
        public void __GetPlayersInRange__SystemSingle_VRCSDKBaseVRCPlayerApiArray__SystemInt32(){} // RVA: 0x7FFD55544680
        public void __GetPlayersInRange__SystemSingle__VRCSDKBaseVRCPlayerApiArray(){} // RVA: 0x7FFD555447B0
        public void __GetPosition__UnityEngineVector3(){} // RVA: 0x7FFD555448A0
        public void __GetPropId__SystemString(){} // RVA: 0x7FFD55544960
        public void __GetQuantity__SystemInt32(){} // RVA: 0x7FFD55544A10
        public void __GetRotation__UnityEngineQuaternion(){} // RVA: 0x7FFD55544AC0
        public void __GetScale__UnityEngineVector3(){} // RVA: 0x7FFD55544B80
        public void __GetSpawner__VRCSDKBaseVRCPlayerApi(){} // RVA: 0x7FFD55544C40
        public void __GetType__SystemType(){} // RVA: 0x7FFD55544CF0
        public void __GetUserAttributes__VRCSDK3DataDataDictionary(){} // RVA: 0x7FFD55544DE0
        public void __ManuallyRecordInteractionEvent__VRCSDKBaseVRCPlayerApi__SystemVoid(){} // RVA: 0x7FFD55544E90
        public void __RequestConsume__SystemBoolean(){} // RVA: 0x7FFD55544F50
        public void __RequestDespawn__SystemBoolean(){} // RVA: 0x7FFD55545000
        public void __SetUserAttributes__VRCSDK3DataDataDictionary__SystemVoid(){} // RVA: 0x7FFD555450B0
        public void __StartPlayingConsumableEffect__SystemVoid(){} // RVA: 0x7FFD55545170
        public void __StopPlayingConsumableEffect__SystemVoid(){} // RVA: 0x7FFD555451F0
        public void __ToString__SystemString(){} // RVA: 0x7FFD55545270
        public void __TryGetProp__VRCSDK3PropsVRCPropApiRef__SystemBoolean(){} // RVA: 0x7FFD55545360
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD555454B0
    }

    public class ExternVRCSDK3PropsVRCPropApiArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55546890
        public void .ctor(){} // RVA: 0x7FFD555468D0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55546CA0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55546DD0
        public void __Clone__SystemObject(){} // RVA: 0x7FFD55546EE0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55546FC0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD555470A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD55547170
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD555472C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD55547360
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD55547460
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD55547580
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD55547690
        public void __GetType__SystemType(){} // RVA: 0x7FFD555477B0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD555478A0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD55547980
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD55547AA0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD55547C30
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD55547D80
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD55547EB0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD55547FD0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD55548140
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD55548280
        public void __Get__SystemInt32__VRCSDK3PropsVRCPropApi(){} // RVA: 0x7FFD555483A0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD55548480
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD555484F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55548610
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55548790
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD555488F0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD55548A20
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55548B40
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55548CA0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55548DF0
        public void __Set__SystemInt32_VRCSDK3PropsVRCPropApi__SystemVoid(){} // RVA: 0x7FFD55548F10
        public void __ToString__SystemString(){} // RVA: 0x7FFD55549090
        public void __ctor__SystemInt32__VRCSDK3PropsVRCPropApiArray(){} // RVA: 0x7FFD55549180
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD55549320
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD555493C0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD55549460
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD55549500
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD555495A0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD55549640
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD555496E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD555497C0
    }

    public class ExternVRCSDK3RenderingVRCAsyncGPUReadback : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5554B6E0
        public void .ctor(){} // RVA: 0x7FFD5554B720
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5554BAF0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5554BC20
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD5554BD30
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD5554BE80
        public void __GetType__SystemType(){} // RVA: 0x7FFD5554BF80
        public void __Request__UnityEngineTexture_SystemInt32_SystemInt32_SystemInt32_SystemInt32_SystemInt32_SystemInt32_SystemInt32_UnityEngineTextureFormat_VRCUdonCommonInterfacesIUdonEventReceiver__VRCSDK3RenderingVRCAsyncGPUReadbackRequest(){} // RVA: 0x7FFD5554C070
        public void __Request__UnityEngineTexture_SystemInt32_SystemInt32_SystemInt32_SystemInt32_SystemInt32_SystemInt32_SystemInt32_VRCUdonCommonInterfacesIUdonEventReceiver__VRCSDK3RenderingVRCAsyncGPUReadbackRequest(){} // RVA: 0x7FFD5554C420
        public void __Request__UnityEngineTexture_SystemInt32_UnityEngineTextureFormat_VRCUdonCommonInterfacesIUdonEventReceiver__VRCSDK3RenderingVRCAsyncGPUReadbackRequest(){} // RVA: 0x7FFD5554C690
        public void __Request__UnityEngineTexture_SystemInt32_VRCUdonCommonInterfacesIUdonEventReceiver__VRCSDK3RenderingVRCAsyncGPUReadbackRequest(){} // RVA: 0x7FFD5554C930
        public void __ToString__SystemString(){} // RVA: 0x7FFD5554CB70
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD5554CC60
    }

    public class ExternVRCSDK3RenderingVRCAsyncGPUReadbackRequest : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5554D440
        public void .ctor(){} // RVA: 0x7FFD5554D480
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5554D850
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5554D980
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD5554DA90
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD5554DBE0
        public void __GetType__SystemType(){} // RVA: 0x7FFD5554DCE0
        public void __ToString__SystemString(){} // RVA: 0x7FFD5554DDD0
        public void __TryGetData__SystemByteArray_SystemInt32__SystemBoolean(){} // RVA: 0x7FFD5554DEC0
        public void __TryGetData__SystemSingleArray_SystemInt32__SystemBoolean(){} // RVA: 0x7FFD5554E020
        public void __TryGetData__UnityEngineColor32Array_SystemInt32__SystemBoolean(){} // RVA: 0x7FFD5554E180
        public void __TryGetData__UnityEngineColorArray_SystemInt32__SystemBoolean(){} // RVA: 0x7FFD5554E2E0
        public void __get_depth__SystemInt32(){} // RVA: 0x7FFD5554E440
        public void __get_done__SystemBoolean(){} // RVA: 0x7FFD5554E530
        public void __get_hasError__SystemBoolean(){} // RVA: 0x7FFD5554E620
        public void __get_height__SystemInt32(){} // RVA: 0x7FFD5554E710
        public void __get_layerCount__SystemInt32(){} // RVA: 0x7FFD5554E800
        public void __get_layerDataSize__SystemInt32(){} // RVA: 0x7FFD5554E8F0
        public void __get_width__SystemInt32(){} // RVA: 0x7FFD5554E9E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD5554EAD0
    }

    public class ExternVRCSDK3RenderingVRCAsyncGPUReadbackRequestArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5554F7F0
        public void .ctor(){} // RVA: 0x7FFD5554F830
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5554FC00
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5554FD30
        public void __Clone__SystemObject(){} // RVA: 0x7FFD5554FE40
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5554FF20
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55550000
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD555500D0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD55550220
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD555502C0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD555503C0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD555504E0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD555505F0
        public void __GetType__SystemType(){} // RVA: 0x7FFD55550710
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD55550800
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD555508E0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD55550A00
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD55550B90
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD55550CE0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD55550E10
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD55550F30
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD555510A0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD555511E0
        public void __Get__SystemInt32__VRCSDK3RenderingVRCAsyncGPUReadbackRequest(){} // RVA: 0x7FFD55551300
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD555513E0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD55551450
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55551570
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD555516F0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55551850
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD55551980
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55551AA0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55551C00
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55551D50
        public void __Set__SystemInt32_VRCSDK3RenderingVRCAsyncGPUReadbackRequest__SystemVoid(){} // RVA: 0x7FFD55551E70
        public void __ToString__SystemString(){} // RVA: 0x7FFD55551FF0
        public void __ctor__SystemInt32__VRCSDK3RenderingVRCAsyncGPUReadbackRequestArray(){} // RVA: 0x7FFD555520E0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD55552280
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD55552320
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD555523C0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD55552460
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD55552500
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD555525A0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD55552640
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD55552720
    }

    public class ExternVRCSDK3RenderingVRCCameraSettings : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55554640
        public void .ctor(){} // RVA: 0x7FFD55554680
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55554A50
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55554B80
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD55554C90
        public void __GetCurrentCamera__VRCSDK3RenderingVRCCameraSettingsRef_UnityEngineCameraRef__SystemVoid(){} // RVA: 0x7FFD55554DD0
        public void __GetEyePosition__UnityEngineCameraStereoscopicEye__UnityEngineVector3(){} // RVA: 0x7FFD55554EF0
        public void __GetEyeRotation__UnityEngineCameraStereoscopicEye__UnityEngineQuaternion(){} // RVA: 0x7FFD55554FE0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD555550C0
        public void __GetType__SystemType(){} // RVA: 0x7FFD55555170
        public void __ToString__SystemString(){} // RVA: 0x7FFD55555260
        public void __get_Active__SystemBoolean(){} // RVA: 0x7FFD55555310
        public void __get_AllowHDR__SystemBoolean(){} // RVA: 0x7FFD555553B0
        public void __get_AllowMSAA__SystemBoolean(){} // RVA: 0x7FFD555554A0
        public void __get_Aspect__SystemSingle(){} // RVA: 0x7FFD55555590
        public void __get_BackgroundColor__UnityEngineColor(){} // RVA: 0x7FFD55555680
        public void __get_CameraMode__VRCSDK3RenderingVRCCameraMode(){} // RVA: 0x7FFD55555790
        public void __get_ClearFlags__UnityEngineCameraClearFlags(){} // RVA: 0x7FFD55555850
        public void __get_CullingMask__UnityEngineLayerMask(){} // RVA: 0x7FFD55555940
        public void __get_DepthTextureMode__UnityEngineDepthTextureMode(){} // RVA: 0x7FFD55555A30
        public void __get_FarClipPlane__SystemSingle(){} // RVA: 0x7FFD55555B20
        public void __get_FieldOfView__SystemSingle(){} // RVA: 0x7FFD55555C10
        public void __get_Forward__UnityEngineVector3(){} // RVA: 0x7FFD55555D00
        public void __get_LayerCullDistances__SystemSingleArray(){} // RVA: 0x7FFD55555E40
        public void __get_LayerCullSpherical__SystemBoolean(){} // RVA: 0x7FFD55555F30
        public void __get_NearClipPlane__SystemSingle(){} // RVA: 0x7FFD55555FD0
        public void __get_PhotoCamera__VRCSDK3RenderingVRCCameraSettings(){} // RVA: 0x7FFD555560C0
        public void __get_PixelHeight__SystemInt32(){} // RVA: 0x7FFD55556190
        public void __get_PixelWidth__SystemInt32(){} // RVA: 0x7FFD55556280
        public void __get_Position__UnityEngineVector3(){} // RVA: 0x7FFD55556370
        public void __get_Right__UnityEngineVector3(){} // RVA: 0x7FFD555564F0
        public void __get_Rotation__UnityEngineQuaternion(){} // RVA: 0x7FFD55556630
        public void __get_ScreenCamera__VRCSDK3RenderingVRCCameraSettings(){} // RVA: 0x7FFD555567A0
        public void __get_StereoEnabled__SystemBoolean(){} // RVA: 0x7FFD55556870
        public void __get_Up__UnityEngineVector3(){} // RVA: 0x7FFD55556960
        public void __get_UseOcclusionCulling__SystemBoolean(){} // RVA: 0x7FFD55556AA0
        public void __set_AllowHDR__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD55556B90
        public void __set_AllowMSAA__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD55556D00
        public void __set_BackgroundColor__UnityEngineColor__SystemVoid(){} // RVA: 0x7FFD55556E70
        public void __set_ClearFlags__UnityEngineCameraClearFlags__SystemVoid(){} // RVA: 0x7FFD55556FF0
        public void __set_CullingMask__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFD55557160
        public void __set_DepthTextureMode__UnityEngineDepthTextureMode__SystemVoid(){} // RVA: 0x7FFD55557210
        public void __set_FarClipPlane__SystemSingle__SystemVoid(){} // RVA: 0x7FFD555572C0
        public void __set_LayerCullDistances__SystemSingleArray__SystemVoid(){} // RVA: 0x7FFD55557440
        public void __set_LayerCullSpherical__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD55557560
        public void __set_NearClipPlane__SystemSingle__SystemVoid(){} // RVA: 0x7FFD555576E0
        public void __set_UseOcclusionCulling__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD55557850
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD555579C0
    }

    public class ExternVRCSDK3RenderingVRCCameraSettingsArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55559BD0
        public void .ctor(){} // RVA: 0x7FFD55559C10
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55559FE0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5555A110
        public void __Clone__SystemObject(){} // RVA: 0x7FFD5555A220
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5555A300
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5555A3E0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD5555A4B0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD5555A600
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD5555A6A0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD5555A7A0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD5555A8C0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD5555A9D0
        public void __GetType__SystemType(){} // RVA: 0x7FFD5555AAF0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD5555ABE0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD5555ACC0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD5555ADE0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD5555AF70
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD5555B0C0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD5555B1F0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD5555B310
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD5555B480
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD5555B5C0
        public void __Get__SystemInt32__VRCSDK3RenderingVRCCameraSettings(){} // RVA: 0x7FFD5555B6E0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD5555B7C0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD5555B830
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5555B950
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5555BAD0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5555BC30
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD5555BD60
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5555BE80
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5555BFE0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5555C130
        public void __Set__SystemInt32_VRCSDK3RenderingVRCCameraSettings__SystemVoid(){} // RVA: 0x7FFD5555C250
        public void __ToString__SystemString(){} // RVA: 0x7FFD5555C3D0
        public void __ctor__SystemInt32__VRCSDK3RenderingVRCCameraSettingsArray(){} // RVA: 0x7FFD5555C4C0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD5555C660
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD5555C700
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD5555C7A0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD5555C840
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD5555C8E0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD5555C980
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD5555CA20
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD5555CB00
    }

    public class ExternVRCSDK3RenderingVRCQualitySettings : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5555EA20
        public void .ctor(){} // RVA: 0x7FFD5555EA60
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5555EE30
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5555EF60
        public void __ResetShadowDistance__SystemVoid(){} // RVA: 0x7FFD5555F070
        public void __SetShadowDistance__SystemSingle_SystemSingle_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x7FFD5555F0D0
        public void __SetShadowDistance__SystemSingle__SystemVoid(){} // RVA: 0x7FFD5555F240
        public void __get_AntiAliasing__SystemInt32(){} // RVA: 0x7FFD5555F310
        public void __get_LODBias__SystemSingle(){} // RVA: 0x7FFD5555F3C0
        public void __get_MaximumLODLevel__SystemInt32(){} // RVA: 0x7FFD5555F470
        public void __get_PixelLightCount__SystemInt32(){} // RVA: 0x7FFD5555F520
        public void __get_ShadowCascade2Split__SystemSingle(){} // RVA: 0x7FFD5555F5D0
        public void __get_ShadowCascade4Split__UnityEngineVector3(){} // RVA: 0x7FFD5555F680
        public void __get_ShadowCascades__SystemInt32(){} // RVA: 0x7FFD5555F750
        public void __get_ShadowDistance__SystemSingle(){} // RVA: 0x7FFD5555F800
        public void __get_ShadowResolution__UnityEngineShadowResolution(){} // RVA: 0x7FFD5555F8B0
        public void __get_VSyncCount__SystemInt32(){} // RVA: 0x7FFD5555F960
        public void __set_ShadowCascade2Split__SystemSingle__SystemVoid(){} // RVA: 0x7FFD5555FA10
        public void __set_ShadowCascade4Split__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFD5555FAD0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD5555FB90
    }

    public class ExternVRCSDK3StringLoadingIVRCStringDownload : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD555608B0
        public void .ctor(){} // RVA: 0x7FFD555608F0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55560CC0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55560DF0
        public void __get_ErrorCode__SystemInt32(){} // RVA: 0x7FFD55560F00
        public void __get_Error__SystemString(){} // RVA: 0x7FFD55560FD0
        public void __get_ResultBytes__SystemByteArray(){} // RVA: 0x7FFD55561090
        public void __get_Result__SystemString(){} // RVA: 0x7FFD55561150
        public void __get_UdonBehaviour__VRCUdonCommonInterfacesIUdonEventReceiver(){} // RVA: 0x7FFD55561210
        public void __get_Url__VRCSDKBaseVRCUrl(){} // RVA: 0x7FFD555612E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD555613A0
    }

    public class ExternVRCSDK3StringLoadingVRCStringDownloader : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD555619F0
        public void .ctor(){} // RVA: 0x7FFD55561A30
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55561E00
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55561F30
        public void __LoadUrl__VRCSDKBaseVRCUrl_VRCUdonCommonInterfacesIUdonEventReceiver__SystemVoid(){} // RVA: 0x7FFD55562040
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD555621B0
    }

    public class ExternVRCSDK3UdonNetworkCallingNetworkCalling : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55562440
        public void .ctor(){} // RVA: 0x7FFD55562480
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55562850
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55562980
        public void __GetAllQueuedEvents__SystemInt32(){} // RVA: 0x7FFD55562A90
        public void __GetQueuedEvents__VRCUdonCommonInterfacesIUdonEventReceiver_SystemString__SystemInt32(){} // RVA: 0x7FFD55562C20
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesIUdonEventReceiver_VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFD55562E30
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesIUdonEventReceiver_VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFD55563210
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesIUdonEventReceiver_VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFD555635E0
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesIUdonEventReceiver_VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFD55563950
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesIUdonEventReceiver_VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFD55563C60
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesIUdonEventReceiver_VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFD55563F10
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesIUdonEventReceiver_VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFD55564160
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesIUdonEventReceiver_VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject__SystemVoid(){} // RVA: 0x7FFD55564350
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesIUdonEventReceiver_VRCUdonCommonInterfacesNetworkEventTarget_SystemString__SystemVoid(){} // RVA: 0x7FFD555644F0
        public void __get_CallingPlayer__VRCSDKBaseVRCPlayerApi(){} // RVA: 0x7FFD55564610
        public void __get_InNetworkCall__SystemBoolean(){} // RVA: 0x7FFD555646E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD555647C0
    }

    public class ExternVRCSDK3VideoComponentsBaseBaseVRCVideoPlayer : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55565350
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFD55565390
        public void .ctor(){} // RVA: 0x7FFD55565440
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55565810
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55565940
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD55565A50
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD55565BB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD55565CA0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD55565F50
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD555660B0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFD555661D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFD555662C0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD55566540
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD55566630
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD555668E0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD55566A40
        public void __GetComponentInParent__T(){} // RVA: 0x7FFD55566B60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFD55566C50
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFD55566ED0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD55567040
        public void __GetComponent__T(){} // RVA: 0x7FFD55567160
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFD55567240
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD55567490
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD55567580
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD555678B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD555679A0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD55567CE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD55567DD0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD555680E0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD55568250
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFD55568380
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFD55568470
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD55568760
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD55568850
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD55568B90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD55568C80
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD55568F90
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD55569100
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFD55569240
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFD55569330
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD55569620
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD55569710
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFD55569A00
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD55569B50
        public void __GetComponents__TArray(){} // RVA: 0x7FFD55569C80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFD55569D70
        public void __GetDuration__SystemSingle(){} // RVA: 0x7FFD5556A020
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD5556A110
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFD5556A200
        public void __GetTime__SystemSingle(){} // RVA: 0x7FFD5556A2E0
        public void __GetType__SystemType(){} // RVA: 0x7FFD5556A3D0
        public void __LoadURL__VRCSDKBaseVRCUrl__SystemVoid(){} // RVA: 0x7FFD5556A4C0
        public void __Pause__SystemVoid(){} // RVA: 0x7FFD5556A5A0
        public void __PlayURL__VRCSDKBaseVRCUrl__SystemVoid(){} // RVA: 0x7FFD5556A660
        public void __Play__SystemVoid(){} // RVA: 0x7FFD5556A740
        public void __SetTime__SystemSingle__SystemVoid(){} // RVA: 0x7FFD5556A800
        public void __Stop__SystemVoid(){} // RVA: 0x7FFD5556A8F0
        public void __ToString__SystemString(){} // RVA: 0x7FFD5556A9B0
        public void __get_EnableAutomaticResync__SystemBoolean(){} // RVA: 0x7FFD5556AA90
        public void __set_EnableAutomaticResync__SystemBoolean(){} // RVA: 0x7FFD5556AB70
        public void __get_IsPlaying__SystemBoolean(){} // RVA: 0x7FFD5556AC50
        public void __get_IsReady__SystemBoolean(){} // RVA: 0x7FFD5556AD40
        public void __get_Loop__SystemBoolean(){} // RVA: 0x7FFD5556AE30
        public void __get_VideoHeight__SystemInt32(){} // RVA: 0x7FFD5556AF20
        public void __get_VideoWidth__SystemInt32(){} // RVA: 0x7FFD5556B010
        public void __get_destroyCancellationToken__SystemThreadingCancellationToken(){} // RVA: 0x7FFD5556B100
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFD5556B1E0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFD5556B300
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFD5556B440
        public void __get_name__SystemString(){} // RVA: 0x7FFD5556B560
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFD5556B640
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD5556B780
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD5556B980
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD5556BB00
        public void __set_Loop__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD5556BD00
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD5556BDF0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFD5556BF20
        public void <.ctor>b__8_1(){} // RVA: 0x7FFD5556C000
    }

    public class ExternVRCSDK3VideoComponentsBaseBaseVRCVideoPlayerArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5556ED60
        public void .ctor(){} // RVA: 0x7FFD5556EDA0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5556F170
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5556F2A0
        public void __Clone__SystemObject(){} // RVA: 0x7FFD5556F3B0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5556F490
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5556F570
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD5556F640
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD5556F790
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD5556F830
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD5556F930
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD5556FA50
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD5556FB60
        public void __GetType__SystemType(){} // RVA: 0x7FFD5556FC80
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD5556FD70
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD5556FE50
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD5556FF70
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD55570100
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD55570250
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD55570380
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD555704A0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD55570610
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD55570750
        public void __Get__SystemInt32__VRCSDK3VideoComponentsBaseBaseVRCVideoPlayer(){} // RVA: 0x7FFD55570870
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD555709B0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD55570A20
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55570B40
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55570CC0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55570E20
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD55570F50
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55571070
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD555711D0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55571320
        public void __Set__SystemInt32_VRCSDK3VideoComponentsBaseBaseVRCVideoPlayer__SystemVoid(){} // RVA: 0x7FFD55571440
        public void __ToString__SystemString(){} // RVA: 0x7FFD55571600
        public void __ctor__SystemInt32__VRCSDK3VideoComponentsBaseBaseVRCVideoPlayerArray(){} // RVA: 0x7FFD555716F0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD555717E0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD55571880
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD55571920
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD555719C0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD55571A60
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD55571B00
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD55571BA0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD55571C80
    }

    public class ExternVRCSDKBaseInputManager : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55573BA0
        public void .ctor(){} // RVA: 0x7FFD55573BE0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55573FB0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD555740E0
        public void __EnableObjectHighlight__UnityEngineGameObject_SystemBoolean__SystemVoid(){} // RVA: 0x7FFD555741F0
        public void __EnableObjectHighlight__UnityEngineRenderer_SystemBoolean__SystemVoid(){} // RVA: 0x7FFD555743B0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD55574490
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD555745E0
        public void __GetLastUsedInputMethod__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFD555746E0
        public void __GetType__SystemType(){} // RVA: 0x7FFD555747B0
        public void __IsUsingHandController__SystemBoolean(){} // RVA: 0x7FFD555748A0
        public void __ToString__SystemString(){} // RVA: 0x7FFD55574960
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD55574A50
    }

    public class ExternVRCSDKBaseNetworking : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55575230
        public void .ctor(){} // RVA: 0x7FFD55575270
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55575640
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55575770
        public void __CalculateServerDeltaTime__SystemDouble_SystemDouble__SystemDouble(){} // RVA: 0x7FFD55575880
        public void __Destroy__UnityEngineGameObject__SystemVoid(){} // RVA: 0x7FFD555759B0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD55575AB0
        public void __FindComponentInPlayerObjects__VRCSDKBaseVRCPlayerApi_UnityEngineComponent__UnityEngineComponent(){} // RVA: 0x7FFD55575C00
        public void __GetEventDispatcher__VRCSDKBaseVRC_EventDispatcher(){} // RVA: 0x7FFD55575D20
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD55575F60
        public void __GetNetworkDateTime__SystemDateTime(){} // RVA: 0x7FFD55576060
        public void __GetOwner__UnityEngineGameObject__VRCSDKBaseVRCPlayerApi(){} // RVA: 0x7FFD55576150
        public void __GetPlayerDataStorageLimit__SystemInt32(){} // RVA: 0x7FFD55576270
        public void __GetPlayerDataStorageUsage__VRCSDKBaseVRCPlayerApi__SystemInt32(){} // RVA: 0x7FFD55576330
        public void __GetPlayerObjectStorageLimit__SystemInt32(){} // RVA: 0x7FFD55576430
        public void __GetPlayerObjectStorageUsage__VRCSDKBaseVRCPlayerApi__SystemInt32(){} // RVA: 0x7FFD555764F0
        public void __GetPlayerObjects__VRCSDKBaseVRCPlayerApi__UnityEngineGameObjectArray(){} // RVA: 0x7FFD555765F0
        public void __GetServerTimeInMilliseconds__SystemInt32(){} // RVA: 0x7FFD55576750
        public void __GetServerTimeInSeconds__SystemDouble(){} // RVA: 0x7FFD555767D0
        public void __GetType__SystemType(){} // RVA: 0x7FFD555768D0
        public void __GetUniqueName__UnityEngineGameObject__SystemString(){} // RVA: 0x7FFD555769C0
        public void __IsObjectReady__UnityEngineGameObject__SystemBoolean(){} // RVA: 0x7FFD55576AE0
        public void __IsOwner__UnityEngineGameObject__SystemBoolean(){} // RVA: 0x7FFD55576C10
        public void __IsOwner__VRCSDKBaseVRCPlayerApi_UnityEngineGameObject__SystemBoolean(){} // RVA: 0x7FFD55576CF0
        public void __RequestStorageUsageUpdate__SystemVoid(){} // RVA: 0x7FFD55576E60
        public void __SetOwner__VRCSDKBaseVRCPlayerApi_UnityEngineGameObject__SystemVoid(){} // RVA: 0x7FFD55576EC0
        public void __SimulationTime__UnityEngineGameObject__SystemSingle(){} // RVA: 0x7FFD55576FA0
        public void __SimulationTime__VRCSDKBaseVRCPlayerApi__SystemSingle(){} // RVA: 0x7FFD55577110
        public void __ToString__SystemString(){} // RVA: 0x7FFD55577250
        public void __get_InstanceOwner__VRCSDKBaseVRCPlayerApi(){} // RVA: 0x7FFD55577340
        public void __get_IsClogged__SystemBoolean(){} // RVA: 0x7FFD555773F0
        public void __get_IsInstanceOwner__SystemBoolean(){} // RVA: 0x7FFD555774B0
        public void __get_IsMaster__SystemBoolean(){} // RVA: 0x7FFD55577570
        public void __get_IsNetworkSettled__SystemBoolean(){} // RVA: 0x7FFD55577630
        public void __get_LocalPlayer__VRCSDKBaseVRCPlayerApi(){} // RVA: 0x7FFD555776F0
        public void __get_Master__VRCSDKBaseVRCPlayerApi(){} // RVA: 0x7FFD555777A0
        public void __get_SceneEventHandler__VRCSDKBaseVRC_EventHandler(){} // RVA: 0x7FFD55577850
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD55577A90
    }

    public class ExternVRCSDKBaseUtilities : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55579530
        public void .ctor(){} // RVA: 0x7FFD55579570
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55579940
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55579A70
        public void __IsValid__SystemObject__SystemBoolean(){} // RVA: 0x7FFD55579B80
        public void __ShuffleArray__SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD55579C70
        public void __ShuffleArray__TArray__SystemVoid(){} // RVA: 0x7FFD55579CE0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD55579D60
    }

    public class ExternVRCSDKBaseVRCCustomAction : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5557A180
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFD5557A1C0
        public void .ctor(){} // RVA: 0x7FFD5557A270
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5557A640
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5557A770
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD5557A880
        public void __Execute__SystemInt32__SystemVoid(){} // RVA: 0x7FFD5557A9E0
        public void __Execute__SystemString__SystemVoid(){} // RVA: 0x7FFD5557AAD0
        public void __Execute__VRCSDKBaseVRCUrl__SystemVoid(){} // RVA: 0x7FFD5557ABB0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD5557AC90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFD5557AD80
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD5557B030
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD5557B190
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFD5557B2B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFD5557B3A0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD5557B620
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFD5557B710
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFD5557B9C0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD5557BB20
        public void __GetComponentInParent__T(){} // RVA: 0x7FFD5557BC40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFD5557BD30
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFD5557BFB0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFD5557C120
        public void __GetComponent__T(){} // RVA: 0x7FFD5557C240
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFD5557C320
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD5557C570
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFD5557C660
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD5557C990
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD5557CA80
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD5557CDC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFD5557CEB0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD5557D1C0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD5557D330
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFD5557D460
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFD5557D550
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD5557D840
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFD5557D930
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD5557DC70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFD5557DD60
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFD5557E070
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD5557E1E0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFD5557E320
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFD5557E410
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD5557E700
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFD5557E7F0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFD5557EAE0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFD5557EC30
        public void __GetComponents__TArray(){} // RVA: 0x7FFD5557ED60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFD5557EE50
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD5557F100
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFD5557F1F0
        public void __GetType__SystemType(){} // RVA: 0x7FFD5557F2D0
        public void __ToString__SystemString(){} // RVA: 0x7FFD5557F3C0
        public void __get_destroyCancellationToken__SystemThreadingCancellationToken(){} // RVA: 0x7FFD5557F4A0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFD5557F580
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFD5557F6A0
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFD5557F7E0
        public void __get_name__SystemString(){} // RVA: 0x7FFD5557F900
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFD5557F9E0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD5557FB20
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD5557FD20
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFD5557FEA0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD555800A0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFD555801D0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFD555802B0
    }

    public class ExternVRCSDKBaseVRCCustomActionArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55582640
        public void .ctor(){} // RVA: 0x7FFD55582680
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55582A50
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55582B80
        public void __Clone__SystemObject(){} // RVA: 0x7FFD55582C90
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55582D70
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55582E50
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD55582F20
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD55583070
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD55583110
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD55583210
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD55583330
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD55583440
        public void __GetType__SystemType(){} // RVA: 0x7FFD55583560
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD55583650
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD55583730
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD55583850
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD555839E0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD55583B30
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD55583C60
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD55583D80
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD55583EF0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD55584030
        public void __Get__SystemInt32__VRCSDKBaseVRCCustomAction(){} // RVA: 0x7FFD55584150
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD55584290
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD55584300
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55584420
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD555845A0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55584700
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD55584830
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55584950
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55584AB0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55584C00
        public void __Set__SystemInt32_VRCSDKBaseVRCCustomAction__SystemVoid(){} // RVA: 0x7FFD55584D20
        public void __ToString__SystemString(){} // RVA: 0x7FFD55584EE0
        public void __ctor__SystemInt32__VRCSDKBaseVRCCustomActionArray(){} // RVA: 0x7FFD55584FD0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD555850C0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD55585160
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD55585200
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD555852A0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD55585340
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD555853E0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD55585480
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD55585560
    }

    public class ExternVRCSDKBaseVRCDroneApi : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55587480
        public void .ctor(){} // RVA: 0x7FFD555874C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55587890
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD555879C0
        public void __GetPlayer__VRCSDKBaseVRCPlayerApi(){} // RVA: 0x7FFD55587AD0
        public void __GetPosition__UnityEngineVector3(){} // RVA: 0x7FFD55587B80
        public void __GetRotation__UnityEngineQuaternion(){} // RVA: 0x7FFD55587C40
        public void __GetVelocity__UnityEngineVector3(){} // RVA: 0x7FFD55587D00
        public void __IsDeployed__SystemBoolean(){} // RVA: 0x7FFD55587DC0
        public void __SetVelocity__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFD55587E70
        public void __TeleportTo__UnityEngineVector3_UnityEngineQuaternion_SystemBoolean__SystemVoid(){} // RVA: 0x7FFD55587F40
        public void __TeleportTo__UnityEngineVector3_UnityEngineQuaternion__SystemVoid(){} // RVA: 0x7FFD555880C0
        public void __TryGetPosition__UnityEngineVector3Ref__SystemBoolean(){} // RVA: 0x7FFD555881F0
        public void __TryGetRotation__UnityEngineQuaternionRef__SystemBoolean(){} // RVA: 0x7FFD55588310
        public void __TryGetVelocity__UnityEngineVector3Ref__SystemBoolean(){} // RVA: 0x7FFD55588420
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD55588540
    }

    public class ExternVRCSDKBaseVRCDroneApiArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55588F50
        public void .ctor(){} // RVA: 0x7FFD55588F90
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55589360
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55589490
        public void __Clone__SystemObject(){} // RVA: 0x7FFD555895A0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55589680
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55589760
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD55589830
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD55589980
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD55589A20
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD55589B20
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD55589C40
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD55589D50
        public void __GetType__SystemType(){} // RVA: 0x7FFD55589E70
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD55589F60
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD5558A040
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD5558A160
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD5558A2F0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD5558A440
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD5558A570
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD5558A690
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD5558A800
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD5558A940
        public void __Get__SystemInt32__VRCSDKBaseVRCDroneApi(){} // RVA: 0x7FFD5558AA60
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD5558AB40
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD5558ABB0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5558ACD0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5558AE50
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5558AFB0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD5558B0E0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5558B200
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5558B360
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5558B4B0
        public void __Set__SystemInt32_VRCSDKBaseVRCDroneApi__SystemVoid(){} // RVA: 0x7FFD5558B5D0
        public void __ToString__SystemString(){} // RVA: 0x7FFD5558B750
        public void __ctor__SystemInt32__VRCSDKBaseVRCDroneApiArray(){} // RVA: 0x7FFD5558B840
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD5558B9E0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD5558BA80
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD5558BB20
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD5558BBC0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD5558BC60
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD5558BD00
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD5558BDA0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD5558BE80
    }

    public class ExternVRCSDKBaseVRCGraphics : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5558DDA0
        public void .ctor(){} // RVA: 0x7FFD5558DDE0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5558E1B0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5558E2E0
        public void __Blit__UnityEngineTexture_UnityEngineMaterial_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5558E3F0
        public void __Blit__UnityEngineTexture_UnityEngineRenderTexture_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5558E630
        public void __Blit__UnityEngineTexture_UnityEngineRenderTexture_UnityEngineMaterial_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5558E890
        public void __Blit__UnityEngineTexture_UnityEngineRenderTexture_UnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFD5558EAD0
        public void __Blit__UnityEngineTexture_UnityEngineRenderTexture_UnityEngineVector2_UnityEngineVector2_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5558ECD0
        public void __Blit__UnityEngineTexture_UnityEngineRenderTexture_UnityEngineVector2_UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFD5558F000
        public void __Blit__UnityEngineTexture_UnityEngineRenderTexture__SystemVoid(){} // RVA: 0x7FFD5558F210
    }

    public class ExternVRCSDKBaseVRCInputMethod : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD555921D0
        public void .ctor(){} // RVA: 0x7FFD55592210
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD555925E0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55592710
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD55592820
        public void __ToString__SystemString(){} // RVA: 0x7FFD55592960
        public void __ToString__SystemString__SystemString(){} // RVA: 0x7FFD55592A10
        public void __get_Controller__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFD55592AE0
        public void __get_Count__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFD55592B50
        public void __get_Gaze__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFD55592BC0
        public void __get_Generic__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFD55592C30
        public void __get_HPMotionController__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFD55592CA0
        public void __get_Index__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFD55592D10
        public void __get_Keyboard__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFD55592D80
        public void __get_Mouse__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFD55592DF0
        public void __get_Oculus__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFD55592E60
        public void __get_OpenXRGeneric__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFD55592ED0
        public void __get_Osc__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFD55592F40
        public void __get_Pico__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFD55592FB0
        public void __get_QuestHands__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFD55593020
        public void __get_SteamVR2__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFD55593090
        public void __get_Touch__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFD55593100
        public void __get_ViveXr__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFD55593170
        public void __get_Vive__VRCSDKBaseVRCInputMethod(){} // RVA: 0x7FFD555931E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD55593250
    }

    public class ExternVRCSDKBaseVRCPlayerApi : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55594320
        public void .ctor(){} // RVA: 0x7FFD55594360
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55594730
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55594860
        public void __ClearPlayerTags__SystemVoid(){} // RVA: 0x7FFD55594970
        public void __ClearSilence__SystemVoid(){} // RVA: 0x7FFD55594A50
        public void __CombatGetCurrentHitpoints__SystemSingle(){} // RVA: 0x7FFD55594B30
        public void __CombatGetDestructible__VRCSDKBaseIVRC_Destructible(){} // RVA: 0x7FFD55594C50
        public void __CombatSetCurrentHitpoints__SystemSingle__SystemVoid(){} // RVA: 0x7FFD55594D70
        public void __CombatSetDamageGraphic__UnityEngineGameObject__SystemVoid(){} // RVA: 0x7FFD55594EA0
        public void __CombatSetMaxHitpoints__SystemSingle__SystemVoid(){} // RVA: 0x7FFD55594FF0
        public void __CombatSetRespawn__SystemBoolean_SystemSingle_UnityEngineTransform__SystemVoid(){} // RVA: 0x7FFD55595120
        public void __CombatSetup__SystemVoid(){} // RVA: 0x7FFD555952F0
        public void __EnablePickups__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD555953D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD55595480
        public void __FindComponentInPlayerObjects__UnityEngineComponent__UnityEngineComponent(){} // RVA: 0x7FFD555955D0
        public void __GetAvailableLanguages__SystemStringArray(){} // RVA: 0x7FFD555956F0
        public void __GetAvatarEyeHeightAsMeters__SystemSingle(){} // RVA: 0x7FFD555957E0
        public void __GetAvatarEyeHeightMaximumAsMeters__SystemSingle(){} // RVA: 0x7FFD55595900
        public void __GetAvatarEyeHeightMinimumAsMeters__SystemSingle(){} // RVA: 0x7FFD55595A20
        public void __GetBonePosition__UnityEngineHumanBodyBones__UnityEngineVector3(){} // RVA: 0x7FFD55595B40
        public void __GetBoneRotation__UnityEngineHumanBodyBones__UnityEngineQuaternion(){} // RVA: 0x7FFD55595CB0
        public void __GetCurrentLanguage__SystemString(){} // RVA: 0x7FFD55595E20
        public void __GetDrone__VRCSDKBaseVRCDroneApi(){} // RVA: 0x7FFD55595F10
        public void __GetGravityStrength__SystemSingle(){} // RVA: 0x7FFD55596020
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD55596140
        public void __GetJumpImpulse__SystemSingle(){} // RVA: 0x7FFD55596240
        public void __GetManualAvatarScalingAllowed__SystemBoolean(){} // RVA: 0x7FFD55596360
        public void __GetPickupInHand__VRCSDKBaseVRC_PickupPickupHand__VRCSDKBaseVRC_Pickup(){} // RVA: 0x7FFD55596480
        public void __GetPlayerById__SystemInt32__VRCSDKBaseVRCPlayerApi(){} // RVA: 0x7FFD55596660
        public void __GetPlayerCount__SystemInt32(){} // RVA: 0x7FFD55596730
        public void __GetPlayerId__VRCSDKBaseVRCPlayerApi__SystemInt32(){} // RVA: 0x7FFD55596820
        public void __GetPlayerObjects__UnityEngineGameObjectArray(){} // RVA: 0x7FFD555968F0
        public void __GetPlayerTag__SystemString__SystemString(){} // RVA: 0x7FFD55596A50
        public void __GetPlayersWithTag__SystemString_SystemString__SystemCollectionsGenericListSystemInt32(){} // RVA: 0x7FFD55596BA0
        public void __GetPlayers__VRCSDKBaseVRCPlayerApiArray(){} // RVA: 0x7FFD55596D50
        public void __GetPlayers__VRCSDKBaseVRCPlayerApiArray__VRCSDKBaseVRCPlayerApiArray(){} // RVA: 0x7FFD55596E70
        public void __GetPosition__UnityEngineVector3(){} // RVA: 0x7FFD55596F40
        public void __GetRotation__UnityEngineQuaternion(){} // RVA: 0x7FFD55597070
        public void __GetRunSpeed__SystemSingle(){} // RVA: 0x7FFD55597190
        public void __GetStrafeSpeed__SystemSingle(){} // RVA: 0x7FFD555972B0
        public void __GetTrackingData__VRCSDKBaseVRCPlayerApiTrackingDataType__VRCSDKBaseVRCPlayerApiTrackingData(){} // RVA: 0x7FFD555973D0
        public void __GetType__SystemType(){} // RVA: 0x7FFD55597560
        public void __GetVelocity__UnityEngineVector3(){} // RVA: 0x7FFD55597650
        public void __GetVoiceDistanceFar__SystemSingle(){} // RVA: 0x7FFD55597780
        public void __GetVoiceDistanceNear__SystemSingle(){} // RVA: 0x7FFD555978A0
        public void __GetVoiceGain__SystemSingle(){} // RVA: 0x7FFD555979C0
        public void __GetVoiceLowpass__SystemBoolean(){} // RVA: 0x7FFD55597AE0
        public void __GetVoiceVolumetricRadius__SystemSingle(){} // RVA: 0x7FFD55597C00
        public void __GetWalkSpeed__SystemSingle(){} // RVA: 0x7FFD55597D20
        public void __Immobilize__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD55597E40
        public void __IsOwner__UnityEngineGameObject__SystemBoolean(){} // RVA: 0x7FFD55597F60
        public void __IsPlayerGrounded__SystemBoolean(){} // RVA: 0x7FFD555980E0
        public void __IsUserInVR__SystemBoolean(){} // RVA: 0x7FFD55598220
        public void __IsValid__SystemBoolean(){} // RVA: 0x7FFD55598340
        public void __PlayHapticEventInHand__VRCSDKBaseVRC_PickupPickupHand_SystemSingle_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x7FFD555983E0
        public void __Respawn__SystemInt32__SystemVoid(){} // RVA: 0x7FFD55598540
        public void __Respawn__SystemVoid(){} // RVA: 0x7FFD55598660
        public void __SetAvatarAudioCustomCurve__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD55598740
        public void __SetAvatarAudioFarRadius__SystemSingle__SystemVoid(){} // RVA: 0x7FFD55598860
        public void __SetAvatarAudioForceSpatial__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD55598990
        public void __SetAvatarAudioGain__SystemSingle__SystemVoid(){} // RVA: 0x7FFD55598AB0
        public void __SetAvatarAudioNearRadius__SystemSingle__SystemVoid(){} // RVA: 0x7FFD55598BE0
        public void __SetAvatarAudioVolumetricRadius__SystemSingle__SystemVoid(){} // RVA: 0x7FFD55598D10
        public void __SetAvatarEyeHeightByMeters__SystemSingle__SystemVoid(){} // RVA: 0x7FFD55598E40
        public void __SetAvatarEyeHeightByMultiplier__SystemSingle__SystemVoid(){} // RVA: 0x7FFD55598F70
        public void __SetAvatarEyeHeightMaximumByMeters__SystemSingle__SystemVoid(){} // RVA: 0x7FFD555990A0
        public void __SetAvatarEyeHeightMinimumByMeters__SystemSingle__SystemVoid(){} // RVA: 0x7FFD555991D0
        public void __SetGravityStrength__SystemSingle__SystemVoid(){} // RVA: 0x7FFD55599300
        public void __SetJumpImpulse__SystemSingle__SystemVoid(){} // RVA: 0x7FFD55599430
        public void __SetManualAvatarScalingAllowed__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD55599560
        public void __SetPlayerTag__SystemString_SystemString__SystemVoid(){} // RVA: 0x7FFD55599680
        public void __SetRunSpeed__SystemSingle__SystemVoid(){} // RVA: 0x7FFD555997D0
        public void __SetSilencedToTagged__SystemInt32_SystemString_SystemString__SystemVoid(){} // RVA: 0x7FFD55599900
        public void __SetSilencedToUntagged__SystemInt32_SystemString_SystemString__SystemVoid(){} // RVA: 0x7FFD55599A90
        public void __SetStrafeSpeed__SystemSingle__SystemVoid(){} // RVA: 0x7FFD55599C20
        public void __SetVelocity__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFD55599D50
        public void __SetVoiceDistanceFar__SystemSingle__SystemVoid(){} // RVA: 0x7FFD55599E90
        public void __SetVoiceDistanceNear__SystemSingle__SystemVoid(){} // RVA: 0x7FFD55599FC0
        public void __SetVoiceGain__SystemSingle__SystemVoid(){} // RVA: 0x7FFD5559A0F0
        public void __SetVoiceLowpass__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD5559A220
        public void __SetVoiceVolumetricRadius__SystemSingle__SystemVoid(){} // RVA: 0x7FFD5559A340
        public void __SetWalkSpeed__SystemSingle__SystemVoid(){} // RVA: 0x7FFD5559A470
        public void __TeleportTo__UnityEngineVector3_UnityEngineQuaternion_VRCSDKBaseVRC_SceneDescriptorSpawnOrientation_SystemBoolean__SystemVoid(){} // RVA: 0x7FFD5559A5A0
        public void __TeleportTo__UnityEngineVector3_UnityEngineQuaternion_VRCSDKBaseVRC_SceneDescriptorSpawnOrientation__SystemVoid(){} // RVA: 0x7FFD5559A7F0
        public void __TeleportTo__UnityEngineVector3_UnityEngineQuaternion__SystemVoid(){} // RVA: 0x7FFD5559A9F0
        public void __ToString__SystemString(){} // RVA: 0x7FFD5559ABB0
        public void __UseAttachedStation__SystemVoid(){} // RVA: 0x7FFD5559ACA0
        public void __UseLegacyLocomotion__SystemVoid(){} // RVA: 0x7FFD5559AD80
        public void __get_displayName__SystemString(){} // RVA: 0x7FFD5559AE60
        public void __get_isInstanceOwner__SystemBoolean(){} // RVA: 0x7FFD5559AEF0
        public void __get_isLocal__SystemBoolean(){} // RVA: 0x7FFD5559B000
        public void __get_isMaster__SystemBoolean(){} // RVA: 0x7FFD5559B0A0
        public void __get_isSuspended__SystemBoolean(){} // RVA: 0x7FFD5559B140
        public void __get_isVRCPlus__SystemBoolean(){} // RVA: 0x7FFD5559B250
        public void __get_playerId__SystemInt32(){} // RVA: 0x7FFD5559B360
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD5559B460
    }

    public class ExternVRCSDKBaseVRCPlayerApiArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5559FB40
        public void .ctor(){} // RVA: 0x7FFD5559FB80
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5559FF50
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD555A0080
        public void __Clone__SystemObject(){} // RVA: 0x7FFD555A0190
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD555A0270
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD555A0350
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD555A0420
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD555A0570
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD555A0610
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD555A0710
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD555A0830
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD555A0940
        public void __GetType__SystemType(){} // RVA: 0x7FFD555A0A60
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD555A0B50
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD555A0C30
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD555A0D50
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD555A0EE0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD555A1030
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD555A1160
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD555A1280
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD555A13F0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD555A1530
        public void __Get__SystemInt32__VRCSDKBaseVRCPlayerApi(){} // RVA: 0x7FFD555A1650
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD555A1730
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD555A17A0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD555A18C0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD555A1A40
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD555A1BA0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD555A1CD0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD555A1DF0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD555A1F50
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD555A20A0
        public void __Set__SystemInt32_VRCSDKBaseVRCPlayerApi__SystemVoid(){} // RVA: 0x7FFD555A21C0
        public void __ToString__SystemString(){} // RVA: 0x7FFD555A22E0
        public void __ctor__SystemInt32__VRCSDKBaseVRCPlayerApiArray(){} // RVA: 0x7FFD555A23D0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD555A2480
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD555A2520
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD555A25C0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD555A2660
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD555A2700
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD555A27A0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD555A2840
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD555A2920
    }

    public class ExternVRCSDKBaseVRCPlayerApiTrackingData : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD555A4840
        public void .ctor(){} // RVA: 0x7FFD555A4880
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD555A4C50
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD555A4D80
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD555A4E90
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD555A4FD0
        public void __GetType__SystemType(){} // RVA: 0x7FFD555A5080
        public void __ToString__SystemString(){} // RVA: 0x7FFD555A5170
        public void __get_position__UnityEngineVector3(){} // RVA: 0x7FFD555A5220
        public void __get_rotation__UnityEngineQuaternion(){} // RVA: 0x7FFD555A5350
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD555A5480
    }

    public class ExternVRCSDKBaseVRCPlayerApiTrackingDataArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD555A5AD0
        public void .ctor(){} // RVA: 0x7FFD555A5B10
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD555A5EE0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD555A6010
        public void __Clone__SystemObject(){} // RVA: 0x7FFD555A6120
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD555A6200
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD555A62E0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD555A63B0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD555A6500
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD555A65A0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD555A66A0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD555A67C0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD555A68D0
        public void __GetType__SystemType(){} // RVA: 0x7FFD555A69F0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD555A6AE0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD555A6BC0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD555A6CE0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD555A6E70
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD555A6FC0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD555A70F0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD555A7210
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD555A7380
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD555A74C0
        public void __Get__SystemInt32__VRCSDKBaseVRCPlayerApiTrackingData(){} // RVA: 0x7FFD555A75E0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD555A76E0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD555A7750
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD555A7870
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD555A79F0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD555A7B50
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD555A7C80
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD555A7DA0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD555A7F00
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD555A8050
        public void __Set__SystemInt32_VRCSDKBaseVRCPlayerApiTrackingData__SystemVoid(){} // RVA: 0x7FFD555A8170
        public void __ToString__SystemString(){} // RVA: 0x7FFD555A8280
        public void __ctor__SystemInt32__VRCSDKBaseVRCPlayerApiTrackingDataArray(){} // RVA: 0x7FFD555A8370
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD555A8510
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD555A85B0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD555A8650
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD555A86F0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD555A8790
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD555A8830
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD555A88D0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD555A89B0
    }

    public class ExternVRCSDKBaseVRCRenderTexture : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD555AA8D0
        public void .ctor(){} // RVA: 0x7FFD555AA910
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD555AACE0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD555AAE10
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD555AAF20
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD555AB070
        public void __GetTemporary__SystemInt32_SystemInt32_SystemInt32_UnityEngineRenderTextureFormat_UnityEngineRenderTextureReadWrite_SystemInt32_UnityEngineRenderTextureMemoryless_UnityEngineVRTextureUsage_SystemBoolean__UnityEngineRenderTexture(){} // RVA: 0x7FFD555AB170
        public void __GetTemporary__UnityEngineRenderTextureDescriptor__UnityEngineRenderTexture(){} // RVA: 0x7FFD555AB480
        public void __GetType__SystemType(){} // RVA: 0x7FFD555AB610
        public void __ReleaseTemporary__UnityEngineRenderTexture__SystemVoid(){} // RVA: 0x7FFD555AB700
        public void __ToString__SystemString(){} // RVA: 0x7FFD555AB840
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD555AB930
    }

    public class ExternVRCSDKBaseVRCShader : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD555AC050
        public void .ctor(){} // RVA: 0x7FFD555AC090
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD555AC460
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD555AC590
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD555AC6A0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD555AC7F0
        public void __GetType__SystemType(){} // RVA: 0x7FFD555AC8F0
        public void __PropertyToID__SystemString__SystemInt32(){} // RVA: 0x7FFD555AC9E0
        public void __SetGlobalColor__SystemInt32_UnityEngineColor__SystemVoid(){} // RVA: 0x7FFD555ACAB0
        public void __SetGlobalFloatArray__SystemInt32_SystemSingleArray__SystemVoid(){} // RVA: 0x7FFD555ACC80
        public void __SetGlobalFloat__SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x7FFD555ACDD0
        public void __SetGlobalInteger__SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD555ACF60
        public void __SetGlobalMatrixArray__SystemInt32_UnityEngineMatrix4x4Array__SystemVoid(){} // RVA: 0x7FFD555AD0D0
        public void __SetGlobalMatrix__SystemInt32_UnityEngineMatrix4x4__SystemVoid(){} // RVA: 0x7FFD555AD220
        public void __SetGlobalTexture__SystemInt32_UnityEngineTexture__SystemVoid(){} // RVA: 0x7FFD555AD400
        public void __SetGlobalVectorArray__SystemInt32_UnityEngineVector4Array__SystemVoid(){} // RVA: 0x7FFD555AD5C0
        public void __SetGlobalVector__SystemInt32_UnityEngineVector4__SystemVoid(){} // RVA: 0x7FFD555AD710
        public void __ToString__SystemString(){} // RVA: 0x7FFD555AD8B0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD555AD9A0
    }

    public class ExternVRCSDKBaseVRCUrl : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD555AE600
        public void .ctor(){} // RVA: 0x7FFD555AE640
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD555AEA10
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD555AEB40
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD555AEC50
        public void __Equals__VRCSDKBaseVRCUrl__SystemBoolean(){} // RVA: 0x7FFD555AED90
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD555AEEA0
        public void __GetType__SystemType(){} // RVA: 0x7FFD555AEF50
        public void __Get__SystemString(){} // RVA: 0x7FFD555AF040
        public void __IsNullOrEmpty__VRCSDKBaseVRCUrl__SystemBoolean(){} // RVA: 0x7FFD555AF0D0
        public void __ToString__SystemString(){} // RVA: 0x7FFD555AF230
        public void __get_Empty__VRCSDKBaseVRCUrl(){} // RVA: 0x7FFD555AF2E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD555AF3B0
    }

    public class ExternVRCSDKBaseVRCUrlArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD555AFB90
        public void .ctor(){} // RVA: 0x7FFD555AFBD0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD555AFFA0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD555B00D0
        public void __Clone__SystemObject(){} // RVA: 0x7FFD555B01E0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD555B02C0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD555B03A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD555B0470
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD555B05C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD555B0660
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD555B0760
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD555B0880
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD555B0990
        public void __GetType__SystemType(){} // RVA: 0x7FFD555B0AB0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD555B0BA0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD555B0C80
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD555B0DA0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD555B0F30
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD555B1080
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD555B11B0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD555B12D0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD555B1440
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD555B1580
        public void __Get__SystemInt32__VRCSDKBaseVRCUrl(){} // RVA: 0x7FFD555B16A0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD555B1780
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD555B17F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD555B1910
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD555B1A90
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD555B1BF0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD555B1D20
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD555B1E40
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD555B1FA0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD555B20F0
        public void __Set__SystemInt32_VRCSDKBaseVRCUrl__SystemVoid(){} // RVA: 0x7FFD555B2210
        public void __ToString__SystemString(){} // RVA: 0x7FFD555B2330
        public void __ctor__SystemInt32__VRCSDKBaseVRCUrlArray(){} // RVA: 0x7FFD555B2420
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD555B25C0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD555B2660
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD555B2700
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD555B27A0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD555B2840
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD555B28E0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD555B2980
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD555B2A60
    }

    public class ExternVRCUdonCommonDeserializationResult : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55869380
        public void .ctor(){} // RVA: 0x7FFD558693C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55869790
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD558698C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD558699D0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD55869B10
        public void __GetType__SystemType(){} // RVA: 0x7FFD55869BC0
        public void __ToString__SystemString(){} // RVA: 0x7FFD55869CB0
        public void __get_isFromStorage__SystemBoolean(){} // RVA: 0x7FFD55869D60
        public void __get_receiveTime__SystemSingle(){} // RVA: 0x7FFD55869E50
        public void __get_sendTime__SystemSingle(){} // RVA: 0x7FFD55869F50
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD5586A050
    }

    public class ExternVRCUdonCommonHandType : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5586A770
        public void .ctor(){} // RVA: 0x7FFD5586A7B0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5586AB80
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5586ACB0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD5586ADC0
        public void __get_LEFT__VRCUdonCommonHandType(){} // RVA: 0x7FFD5586AF00
        public void __get_RIGHT__VRCUdonCommonHandType(){} // RVA: 0x7FFD5586AF70
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD5586AFE0
    }

    public class ExternVRCUdonCommonInterfacesIUdonEventReceiver : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5573AD80
        public void .ctor(){} // RVA: 0x7FFD5573ADC0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5573B190
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5573B2C0
        public void __GetProgramVariableType__SystemString__SystemType(){} // RVA: 0x7FFD5573B3D0
        public void __GetProgramVariable__SystemString__SystemObject(){} // RVA: 0x7FFD5573B4C0
        public void __RequestSerialization__SystemVoid(){} // RVA: 0x7FFD5573B610
        public void __SendCustomEventDelayedFrames__SystemString_SystemInt32_VRCUdonCommonEnumsEventTiming__SystemVoid(){} // RVA: 0x7FFD5573B6B0
        public void __SendCustomEventDelayedSeconds__SystemString_SystemSingle_VRCUdonCommonEnumsEventTiming__SystemVoid(){} // RVA: 0x7FFD5573B880
        public void __SendCustomEvent__SystemString__SystemVoid(){} // RVA: 0x7FFD5573BA50
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFD5573BB20
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFD5573BF70
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFD5573C3B0
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFD5573C790
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFD5573CB00
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFD5573CE10
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject_SystemObject__SystemVoid(){} // RVA: 0x7FFD5573D0C0
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesNetworkEventTarget_SystemString_SystemObject__SystemVoid(){} // RVA: 0x7FFD5573D310
        public void __SendCustomNetworkEvent__VRCUdonCommonInterfacesNetworkEventTarget_SystemString__SystemVoid(){} // RVA: 0x7FFD5573D4A0
        public void __SetProgramVariable__SystemString_SystemObject__SystemVoid(){} // RVA: 0x7FFD5573D5B0
        public void __get_DisableInteractive__SystemBoolean(){} // RVA: 0x7FFD5573D700
        public void __get_InteractionText__SystemString(){} // RVA: 0x7FFD5573D7D0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFD5573D890
        public void __set_DisableInteractive__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD5573D960
        public void __set_InteractionText__SystemString__SystemVoid(){} // RVA: 0x7FFD5573DA30
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFD5573DB00
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD5573DBD0
    }

    public class ExternVRCUdonCommonInterfacesIUdonEventReceiverArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5573EE20
        public void .ctor(){} // RVA: 0x7FFD5573EE60
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5573F230
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5573F360
        public void __Clone__SystemObject(){} // RVA: 0x7FFD5573F470
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5573F550
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5573F630
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD5573F700
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD5573F850
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD5573F8F0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD5573F9F0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD5573FB10
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD5573FC20
        public void __GetType__SystemType(){} // RVA: 0x7FFD5573FD40
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD5573FE30
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD5573FF10
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD55740030
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD557401C0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD55740310
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD55740440
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD55740560
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD557406D0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD55740810
        public void __Get__SystemInt32__VRCUdonCommonInterfacesIUdonEventReceiver(){} // RVA: 0x7FFD55740930
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD55740A10
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD55740A80
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55740BA0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55740D20
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD55740E80
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD55740FB0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD557410D0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55741230
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD55741380
        public void __Set__SystemInt32_VRCUdonCommonInterfacesIUdonEventReceiver__SystemVoid(){} // RVA: 0x7FFD557414A0
        public void __ToString__SystemString(){} // RVA: 0x7FFD55741620
        public void __ctor__SystemInt32__VRCUdonCommonInterfacesIUdonEventReceiverArray(){} // RVA: 0x7FFD55741710
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD557418B0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD55741950
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD557419F0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD55741A90
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD55741B30
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD55741BD0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD55741C70
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD55741D50
    }

    public class ExternVRCUdonCommonSerializationResult : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5586B400
        public void .ctor(){} // RVA: 0x7FFD5586B440
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5586B810
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5586B940
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD5586BA50
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD5586BB90
        public void __GetType__SystemType(){} // RVA: 0x7FFD5586BC40
        public void __ToString__SystemString(){} // RVA: 0x7FFD5586BD30
        public void __get_byteCount__SystemInt32(){} // RVA: 0x7FFD5586BDE0
        public void __get_success__SystemBoolean(){} // RVA: 0x7FFD5586BEB0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD5586BF80
    }

    public class ExternVRCUdonCommonSerializationResultArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD5586C5D0
        public void .ctor(){} // RVA: 0x7FFD5586C610
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD5586C9E0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD5586CB10
        public void __Clone__SystemObject(){} // RVA: 0x7FFD5586CC20
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5586CD00
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5586CDE0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD5586CEB0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFD5586D000
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD5586D0A0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFD5586D1A0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFD5586D2C0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD5586D3D0
        public void __GetType__SystemType(){} // RVA: 0x7FFD5586D4F0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFD5586D5E0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFD5586D6C0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD5586D7E0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFD5586D970
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFD5586DAC0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFD5586DBF0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD5586DD10
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFD5586DE80
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFD5586DFC0
        public void __Get__SystemInt32__VRCUdonCommonSerializationResult(){} // RVA: 0x7FFD5586E0E0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFD5586E1C0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFD5586E230
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5586E350
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5586E4D0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFD5586E630
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFD5586E760
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5586E880
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5586E9E0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFD5586EB30
        public void __Set__SystemInt32_VRCUdonCommonSerializationResult__SystemVoid(){} // RVA: 0x7FFD5586EC50
        public void __ToString__SystemString(){} // RVA: 0x7FFD5586ED30
        public void __ctor__SystemInt32__VRCUdonCommonSerializationResultArray(){} // RVA: 0x7FFD5586EE20
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFD5586EFC0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFD5586F060
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFD5586F100
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFD5586F1A0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFD5586F240
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFD5586F2E0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFD5586F380
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD5586F460
    }

    public class ExternVRCUdonCommonUdonInputEventArgs : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55871380
        public void .ctor(){} // RVA: 0x7FFD558713C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55871790
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD558718C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD558719D0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFD55871B10
        public void __GetType__SystemType(){} // RVA: 0x7FFD55871BC0
        public void __ToString__SystemString(){} // RVA: 0x7FFD55871CB0
        public void __get_boolValue__SystemBoolean(){} // RVA: 0x7FFD55871D60
        public void __get_eventType__VRCUdonCommonUdonInputEventType(){} // RVA: 0x7FFD55871E60
        public void __get_floatValue__SystemSingle(){} // RVA: 0x7FFD55871F50
        public void __get_handType__VRCUdonCommonHandType(){} // RVA: 0x7FFD55872040
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD55872140
    }

    public class ExternVRCUdonCommonUdonInputEventType : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,0x666304C8>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD55872920
        public void .ctor(){} // RVA: 0x7FFD55872960
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFD55872D30
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFD55872E60
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFD55872F70
        public void __get_AXIS__VRCUdonCommonUdonInputEventType(){} // RVA: 0x7FFD558730B0
        public void __get_BUTTON__VRCUdonCommonUdonInputEventType(){} // RVA: 0x7FFD55873120
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD55873190
    }

}