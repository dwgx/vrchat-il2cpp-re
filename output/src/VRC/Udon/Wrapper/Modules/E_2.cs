// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Wrapper.Modules
// Classes: 100
// Methods: 4624

namespace VRC.Udon.Wrapper.Modules
{
    public class ExternCinemachineCinemachineVirtualCamera : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x891F9E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x891FA20
        public void .ctor(){} // RVA: 0x891FAA0
        public void GetExternFunctionParameterCount(){} // RVA: 0x891FE70
        public void GetExternFunctionDelegate(){} // RVA: 0x891FFA0
        public void __CancelDamping__SystemBoolean__SystemVoid(){} // RVA: 0x89200B0
        public void __DetachedFollowTargetDamp__SystemSingle_SystemSingle_SystemSingle__SystemSingle(){} // RVA: 0x89203D0
        public void __DetachedFollowTargetDamp__UnityEngineVector3_SystemSingle_SystemSingle__UnityEngineVector3(){} // RVA: 0x8920560
        public void __DetachedFollowTargetDamp__UnityEngineVector3_UnityEngineVector3_SystemSingle__UnityEngineVector3(){} // RVA: 0x89207A0
        public void __DetachedLookAtTargetDamp__SystemSingle_SystemSingle_SystemSingle__SystemSingle(){} // RVA: 0x89209B0
        public void __DetachedLookAtTargetDamp__UnityEngineVector3_SystemSingle_SystemSingle__UnityEngineVector3(){} // RVA: 0x8920B40
        public void __DetachedLookAtTargetDamp__UnityEngineVector3_UnityEngineVector3_SystemSingle__UnityEngineVector3(){} // RVA: 0x8920D80
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x89210A0
        public void __ForceCameraPosition__UnityEngineVector3_UnityEngineQuaternion__SystemVoid(){} // RVA: 0x8921280
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x89213E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x89214D0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8921760
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x89218E0
        public void __GetComponentInChildren__T(){} // RVA: 0x8921A20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x8921B10
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8921D60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8921E50
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x89220E0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x8922260
        public void __GetComponentInParent__T(){} // RVA: 0x89223A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x8922490
        public void __GetComponentOwner__UnityEngineTransform(){} // RVA: 0x89226E0
        public void __GetComponentPipeline__CinemachineCinemachineComponentBaseArray(){} // RVA: 0x8922800
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x8922AC0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x8922BF0
        public void __GetComponent__T(){} // RVA: 0x8922D30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x8922E10
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8923040
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8923130
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8923440
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8923530
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8923860
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8923950
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8923C40
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x8923DE0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x8923F30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x8924020
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89242D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89243C0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x89246F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x89247E0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8924AD0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x8924C70
        public void __GetComponentsInParent__TArray(){} // RVA: 0x8924DC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x8924EB0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x8925160
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x8925250
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x8925520
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x8925670
        public void __GetComponents__TArray(){} // RVA: 0x89257C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x89258B0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8925B70
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x8925CE0
        public void __GetType__SystemType(){} // RVA: 0x8925E40
        public void __MoveToTopOfPrioritySubqueue__SystemVoid(){} // RVA: 0x8925F30
        public void __ResolveFollow__UnityEngineTransform__UnityEngineTransform(){} // RVA: 0x8925FF0
        public void __ResolveLookAt__UnityEngineTransform__UnityEngineTransform(){} // RVA: 0x8926150
        public void __get_AbstractFollowTargetGroup__CinemachineICinemachineTargetGroup(){} // RVA: 0x89262B0
        public void __get_AbstractLookAtTargetGroup__CinemachineICinemachineTargetGroup(){} // RVA: 0x8926390
        public void __get_Description__SystemString(){} // RVA: 0x8926470
        public void __get_FollowTargetAsVcam__CinemachineCinemachineVirtualCameraBase(){} // RVA: 0x8926560
        public void __get_FollowTargetAttachment__SystemSingle(){} // RVA: 0x8926660
        public void __set_FollowTargetAttachment__SystemSingle(){} // RVA: 0x8926740
        public void __get_FollowTargetChanged__SystemBoolean(){} // RVA: 0x8926820
        public void __get_Follow__UnityEngineTransform(){} // RVA: 0x8926900
        public void __get_IsValid__SystemBoolean(){} // RVA: 0x8926A20
        public void __get_LookAtTargetAsVcam__CinemachineCinemachineVirtualCameraBase(){} // RVA: 0x8926BC0
        public void __get_LookAtTargetAttachment__SystemSingle(){} // RVA: 0x8926CC0
        public void __set_LookAtTargetAttachment__SystemSingle(){} // RVA: 0x8926DA0
        public void __get_LookAtTargetChanged__SystemBoolean(){} // RVA: 0x8926E80
        public void __get_LookAt__UnityEngineTransform(){} // RVA: 0x8926F60
        public void __get_Priority__SystemInt32(){} // RVA: 0x8927080
        public void __get_enabled__SystemBoolean(){} // RVA: 0x8927160
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x89272D0
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x89273E0
        public void __get_m_Lens__CinemachineLensSettings(){} // RVA: 0x8927550
        public void __set_m_Lens__CinemachineLensSettings(){} // RVA: 0x8927770
        public void __get_name__SystemString(){} // RVA: 0x8927950
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x8927AB0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8927BC0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x8927EC0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x89280C0
        public void __set_Follow__UnityEngineTransform__SystemVoid(){} // RVA: 0x89283A0
        public void __set_LookAt__UnityEngineTransform__SystemVoid(){} // RVA: 0x89284C0
        public void __set_Priority__SystemInt32__SystemVoid(){} // RVA: 0x89285E0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x89286C0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x89287B0
        public void <.ctor>b__8_1(){} // RVA: 0x8928910
    }

    public class ExternCinemachineCinemachineVirtualCameraArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x892C1B0
        public void .ctor(){} // RVA: 0x892C1F0
        public void GetExternFunctionParameterCount(){} // RVA: 0x892C5C0
        public void GetExternFunctionDelegate(){} // RVA: 0x892C6F0
        public void __Clone__SystemObject(){} // RVA: 0x892C800
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x892C8F0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x892C9D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x892CAA0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x892CBF0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x892CC90
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x892CDA0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x892CEC0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x892CFD0
        public void __GetType__SystemType(){} // RVA: 0x892D0F0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x892D1E0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x892D2C0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x892D3F0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x892D580
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x892D6D0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x892D800
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x892D930
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x892DAB0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x892DC00
        public void __Get__SystemInt32__CinemachineCinemachineVirtualCamera(){} // RVA: 0x892DD30
        public void __Initialize__SystemVoid(){} // RVA: 0x892DE80
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x892DEF0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x892E020
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x892E1A0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x892E300
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x892E430
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x892E560
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x892E6D0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x892E820
        public void __Set__SystemInt32_CinemachineCinemachineVirtualCamera__SystemVoid(){} // RVA: 0x892E950
        public void __ToString__SystemString(){} // RVA: 0x892EAD0
        public void __ctor__SystemInt32__CinemachineCinemachineVirtualCameraArray(){} // RVA: 0x892EBD0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x892ECD0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x892ED70
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x892EE10
        public void __get_Length__SystemInt32(){} // RVA: 0x892EEB0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x892EF50
        public void __get_Rank__SystemInt32(){} // RVA: 0x892EFF0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x892F090
        public void <.ctor>b__6_1(){} // RVA: 0x892F170
    }

    public class ExternTMProHorizontalAlignmentOptions : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8931090
        public void .ctor(){} // RVA: 0x89310D0
        public void GetExternFunctionParameterCount(){} // RVA: 0x89314A0
        public void GetExternFunctionDelegate(){} // RVA: 0x89315D0
        public void __CompareTo__SystemObject__SystemInt32(){} // RVA: 0x89316E0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8931810
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8931950
        public void __GetType__SystemType(){} // RVA: 0x8931A00
        public void __HasFlag__SystemEnum__SystemBoolean(){} // RVA: 0x8931AF0
        public void __ToString__SystemString(){} // RVA: 0x8931BC0
        public void __ToString__SystemString__SystemString(){} // RVA: 0x8931C70
        public void __get_Center__TMProHorizontalAlignmentOptions(){} // RVA: 0x8931D40
        public void __get_Flush__TMProHorizontalAlignmentOptions(){} // RVA: 0x8931DB0
        public void __get_Geometry__TMProHorizontalAlignmentOptions(){} // RVA: 0x8931E20
        public void __get_Justified__TMProHorizontalAlignmentOptions(){} // RVA: 0x8931E90
        public void __get_Left__TMProHorizontalAlignmentOptions(){} // RVA: 0x8931F00
        public void __get_Right__TMProHorizontalAlignmentOptions(){} // RVA: 0x8931F70
        public void <.ctor>b__6_1(){} // RVA: 0x8931FE0
    }

    public class ExternTMProHorizontalAlignmentOptionsArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8932B70
        public void .ctor(){} // RVA: 0x8932BB0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8932F80
        public void GetExternFunctionDelegate(){} // RVA: 0x89330B0
        public void __Clone__SystemObject(){} // RVA: 0x89331C0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x89332B0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8933390
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8933460
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x89335B0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8933650
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8933760
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8933880
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8933990
        public void __GetType__SystemType(){} // RVA: 0x8933AB0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8933BA0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8933C80
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8933DB0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8933F40
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8934090
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x89341C0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x89342F0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8934470
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x89345C0
        public void __Get__SystemInt32__TMProHorizontalAlignmentOptions(){} // RVA: 0x89346F0
        public void __Initialize__SystemVoid(){} // RVA: 0x89347D0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8934840
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8934970
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8934AF0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8934C50
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8934D80
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8934EB0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8935020
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8935170
        public void __Set__SystemInt32_TMProHorizontalAlignmentOptions__SystemVoid(){} // RVA: 0x89352A0
        public void __ToString__SystemString(){} // RVA: 0x8935390
        public void __ctor__SystemInt32__TMProHorizontalAlignmentOptionsArray(){} // RVA: 0x8935490
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8935630
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x89356D0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8935770
        public void __get_Length__SystemInt32(){} // RVA: 0x8935810
        public void __get_LongLength__SystemInt64(){} // RVA: 0x89358B0
        public void __get_Rank__SystemInt32(){} // RVA: 0x8935950
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x89359F0
        public void <.ctor>b__6_1(){} // RVA: 0x8935AD0
    }

    public class ExternTMProTMP_Dropdown : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x896B710
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x896B750
        public void .ctor(){} // RVA: 0x896B7D0
        public void GetExternFunctionParameterCount(){} // RVA: 0x896BBA0
        public void GetExternFunctionDelegate(){} // RVA: 0x896BCD0
        public void __ClearOptions__SystemVoid(){} // RVA: 0x896BDE0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x896BEA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x896BF90
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x896C220
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x896C3A0
        public void __GetComponentInChildren__T(){} // RVA: 0x896C4E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x896C5D0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x896C820
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x896C910
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x896CBA0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x896CD20
        public void __GetComponentInParent__T(){} // RVA: 0x896CE60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x896CF50
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x896D1A0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x896D2D0
        public void __GetComponent__T(){} // RVA: 0x896D410
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x896D4F0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x896D720
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x896D810
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x896DB20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x896DC10
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x896DF40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x896E030
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x896E320
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x896E4C0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x896E610
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x896E700
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x896E9B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x896EAA0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x896EDD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x896EEC0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x896F1B0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x896F350
        public void __GetComponentsInParent__TArray(){} // RVA: 0x896F4A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x896F590
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x896F840
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x896F930
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x896FC00
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x896FD50
        public void __GetComponents__TArray(){} // RVA: 0x896FEA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x896FF90
        public void __Hide__SystemVoid(){} // RVA: 0x8970250
        public void __RefreshShownValue__SystemVoid(){} // RVA: 0x8970310
        public void __SetValueWithoutNotify__SystemInt32__SystemVoid(){} // RVA: 0x89703D0
        public void __Show__SystemVoid(){} // RVA: 0x89704C0
        public void __get_IsExpanded__SystemBoolean(){} // RVA: 0x8970580
        public void __get_enabled__SystemBoolean(){} // RVA: 0x8970670
        public void __get_value__SystemInt32(){} // RVA: 0x89707E0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x89708C0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x8970BC0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8970DC0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x89710A0
        public void __set_value__SystemInt32__SystemVoid(){} // RVA: 0x8971190
        public void <.ctor>b__8_1(){} // RVA: 0x8971280
    }

    public class ExternTMProTMP_DropdownArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89731A0
        public void .ctor(){} // RVA: 0x89731E0
        public void GetExternFunctionParameterCount(){} // RVA: 0x89735B0
        public void GetExternFunctionDelegate(){} // RVA: 0x89736E0
        public void __Clone__SystemObject(){} // RVA: 0x89737F0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x89738E0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x89739C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8973A90
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8973BE0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8973C80
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8973D90
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8973EB0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8973FC0
        public void __GetType__SystemType(){} // RVA: 0x89740E0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x89741D0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x89742B0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x89743E0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8974570
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x89746C0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x89747F0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8974920
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8974AA0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8974BF0
        public void __Get__SystemInt32__TMProTMP_Dropdown(){} // RVA: 0x8974D20
        public void __Initialize__SystemVoid(){} // RVA: 0x8974E70
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8974EE0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8975010
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8975190
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x89752F0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8975420
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8975550
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x89756C0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8975810
        public void __Set__SystemInt32_TMProTMP_Dropdown__SystemVoid(){} // RVA: 0x8975940
        public void __ToString__SystemString(){} // RVA: 0x8975B10
        public void __ctor__SystemInt32__TMProTMP_DropdownArray(){} // RVA: 0x8975C10
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8975D10
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8975DB0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8975E50
        public void __get_Length__SystemInt32(){} // RVA: 0x8975EF0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8975F90
        public void __get_Rank__SystemInt32(){} // RVA: 0x8976030
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x89760D0
        public void <.ctor>b__6_1(){} // RVA: 0x89761B0
    }

    public class ExternTMProTMP_DropdownOptionData : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89780D0
        public void .ctor(){} // RVA: 0x8978110
        public void GetExternFunctionParameterCount(){} // RVA: 0x89784E0
        public void GetExternFunctionDelegate(){} // RVA: 0x8978610
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8978720
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8978870
        public void __GetType__SystemType(){} // RVA: 0x8978980
        public void __ToString__SystemString(){} // RVA: 0x8978A70
        public void __ctor__SystemString_UnityEngineSprite_UnityEngineColor__TMProTMP_DropdownOptionData(){} // RVA: 0x8978B70
        public void __ctor__SystemString__TMProTMP_DropdownOptionData(){} // RVA: 0x8978D10
        public void __ctor__UnityEngineSprite__TMProTMP_DropdownOptionData(){} // RVA: 0x8978E20
        public void __ctor____TMProTMP_DropdownOptionData(){} // RVA: 0x8978F70
        public void __get_color__UnityEngineColor(){} // RVA: 0x8979000
        public void __get_image__UnityEngineSprite(){} // RVA: 0x89790B0
        public void __get_text__SystemString(){} // RVA: 0x8979190
        public void __set_color__UnityEngineColor__SystemVoid(){} // RVA: 0x8979220
        public void __set_image__UnityEngineSprite__SystemVoid(){} // RVA: 0x89792D0
        public void __set_text__SystemString__SystemVoid(){} // RVA: 0x8979410
        public void <.ctor>b__6_1(){} // RVA: 0x8979500
    }

    public class ExternTMProTMP_DropdownOptionDataArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x897A160
        public void .ctor(){} // RVA: 0x897A1A0
        public void GetExternFunctionParameterCount(){} // RVA: 0x897A570
        public void GetExternFunctionDelegate(){} // RVA: 0x897A6A0
        public void __Clone__SystemObject(){} // RVA: 0x897A7B0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x897A8A0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x897A980
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x897AA50
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x897ABA0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x897AC40
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x897AD50
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x897AE70
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x897AF80
        public void __GetType__SystemType(){} // RVA: 0x897B0A0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x897B190
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x897B270
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x897B3A0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x897B530
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x897B680
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x897B7B0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x897B8E0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x897BA60
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x897BBB0
        public void __Get__SystemInt32__TMProTMP_DropdownOptionData(){} // RVA: 0x897BCE0
        public void __Initialize__SystemVoid(){} // RVA: 0x897BDC0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x897BE30
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x897BF60
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x897C0E0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x897C240
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x897C370
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x897C4A0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x897C610
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x897C760
        public void __Set__SystemInt32_TMProTMP_DropdownOptionData__SystemVoid(){} // RVA: 0x897C890
        public void __ToString__SystemString(){} // RVA: 0x897CA00
        public void __ctor__SystemInt32__TMProTMP_DropdownOptionDataArray(){} // RVA: 0x897CB00
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x897CCA0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x897CD40
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x897CDE0
        public void __get_Length__SystemInt32(){} // RVA: 0x897CE80
        public void __get_LongLength__SystemInt64(){} // RVA: 0x897CF20
        public void __get_Rank__SystemInt32(){} // RVA: 0x897CFC0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x897D060
        public void <.ctor>b__6_1(){} // RVA: 0x897D140
    }

    public class ExternTMProTMP_InputField : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x897F060
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x897F0A0
        public void .ctor(){} // RVA: 0x897F120
        public void GetExternFunctionParameterCount(){} // RVA: 0x897F4F0
        public void GetExternFunctionDelegate(){} // RVA: 0x897F620
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x897F730
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x897F820
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x897FAB0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x897FC30
        public void __GetComponentInChildren__T(){} // RVA: 0x897FD70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x897FE60
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x89800B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x89801A0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8980430
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x89805B0
        public void __GetComponentInParent__T(){} // RVA: 0x89806F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x89807E0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x8980A30
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x8980B60
        public void __GetComponent__T(){} // RVA: 0x8980CA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x8980D80
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8980FB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x89810A0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89813B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89814A0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x89817D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x89818C0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8981BB0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x8981D50
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x8981EA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x8981F90
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8982240
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8982330
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8982660
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8982750
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8982A40
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x8982BE0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x8982D30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x8982E20
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x89830D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x89831C0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x8983490
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x89835E0
        public void __GetComponents__TArray(){} // RVA: 0x8983730
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x8983820
        public void __SetTextWithoutNotify__SystemString__SystemVoid(){} // RVA: 0x8983AE0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x8983BC0
        public void __get_isFocused__SystemBoolean(){} // RVA: 0x8983D30
        public void __get_readOnly__SystemBoolean(){} // RVA: 0x8983E10
        public void __get_richText__SystemBoolean(){} // RVA: 0x8983EF0
        public void __get_text__SystemString(){} // RVA: 0x8983FD0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x89840B0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x89843B0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x89845B0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x8984890
        public void __set_readOnly__SystemBoolean__SystemVoid(){} // RVA: 0x8984980
        public void __set_richText__SystemBoolean__SystemVoid(){} // RVA: 0x8984A60
        public void __set_text__SystemString__SystemVoid(){} // RVA: 0x8984B50
        public void <.ctor>b__8_1(){} // RVA: 0x8984C30
    }

    public class ExternTMProTMP_InputFieldArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8986B50
        public void .ctor(){} // RVA: 0x8986B90
        public void GetExternFunctionParameterCount(){} // RVA: 0x8986F60
        public void GetExternFunctionDelegate(){} // RVA: 0x8987090
        public void __Clone__SystemObject(){} // RVA: 0x89871A0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8987290
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8987370
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8987440
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8987590
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8987630
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8987740
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8987860
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8987970
        public void __GetType__SystemType(){} // RVA: 0x8987A90
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8987B80
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8987C60
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8987D90
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8987F20
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8988070
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x89881A0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x89882D0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8988450
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x89885A0
        public void __Get__SystemInt32__TMProTMP_InputField(){} // RVA: 0x89886D0
        public void __Initialize__SystemVoid(){} // RVA: 0x8988820
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8988890
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x89889C0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8988B40
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8988CA0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8988DD0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8988F00
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8989070
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x89891C0
        public void __Set__SystemInt32_TMProTMP_InputField__SystemVoid(){} // RVA: 0x89892F0
        public void __ToString__SystemString(){} // RVA: 0x89894C0
        public void __ctor__SystemInt32__TMProTMP_InputFieldArray(){} // RVA: 0x89895C0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x89896C0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8989760
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8989800
        public void __get_Length__SystemInt32(){} // RVA: 0x89898A0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8989940
        public void __get_Rank__SystemInt32(){} // RVA: 0x89899E0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8989A80
        public void <.ctor>b__6_1(){} // RVA: 0x8989B60
    }

    public class ExternTMProTMP_MeshInfo : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x898BA80
        public void .ctor(){} // RVA: 0x898BAC0
        public void GetExternFunctionParameterCount(){} // RVA: 0x898BE90
        public void GetExternFunctionDelegate(){} // RVA: 0x898BFC0
        public void __ClearUnusedVertices__SystemInt32_SystemBoolean__SystemVoid(){} // RVA: 0x898C0D0
        public void __ClearUnusedVertices__SystemInt32__SystemVoid(){} // RVA: 0x898C220
        public void __ClearUnusedVertices__SystemVoid(){} // RVA: 0x898C320
        public void __Clear__SystemBoolean__SystemVoid(){} // RVA: 0x898C400
        public void __Clear__SystemVoid(){} // RVA: 0x898C510
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x898C5E0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x898C720
        public void __GetType__SystemType(){} // RVA: 0x898C7D0
        public void __ResizeMeshInfo__SystemInt32_SystemBoolean__SystemVoid(){} // RVA: 0x898C8C0
        public void __ResizeMeshInfo__SystemInt32__SystemVoid(){} // RVA: 0x898CA30
        public void __SortGeometry__SystemCollectionsGenericIListSystemInt32__SystemVoid(){} // RVA: 0x898CB60
        public void __SortGeometry__TMProVertexSortingOrder__SystemVoid(){} // RVA: 0x898CC90
        public void __SwapVertexData__SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x898CDC0
        public void __ToString__SystemString(){} // RVA: 0x898CF20
        public void __ctor__UnityEngineMesh_SystemInt32_SystemBoolean__TMProTMP_MeshInfo(){} // RVA: 0x898CFD0
        public void __ctor__UnityEngineMesh_SystemInt32__TMProTMP_MeshInfo(){} // RVA: 0x898D1E0
        public void __get_colors32__UnityEngineColor32Array(){} // RVA: 0x898D3B0
        public void __set_colors32__UnityEngineColor32Array(){} // RVA: 0x898D530
        public void __get_material__UnityEngineMaterial(){} // RVA: 0x898D6C0
        public void __set_material__UnityEngineMaterial(){} // RVA: 0x898D880
        public void __get_mesh__UnityEngineMesh(){} // RVA: 0x898DA10
        public void __set_mesh__UnityEngineMesh(){} // RVA: 0x898DBD0
        public void __get_normals__UnityEngineVector3Array(){} // RVA: 0x898DD60
        public void __set_normals__UnityEngineVector3Array(){} // RVA: 0x898DEE0
        public void __get_tangents__UnityEngineVector4Array(){} // RVA: 0x898E070
        public void __set_tangents__UnityEngineVector4Array(){} // RVA: 0x898E1E0
        public void __get_triangles__SystemInt32Array(){} // RVA: 0x898E370
        public void __set_triangles__SystemInt32Array(){} // RVA: 0x898E4E0
        public void __get_uvs0__UnityEngineVector4Array(){} // RVA: 0x898E670
        public void __set_uvs0__UnityEngineVector4Array(){} // RVA: 0x898E7F0
        public void __get_uvs2__UnityEngineVector2Array(){} // RVA: 0x898E980
        public void __set_uvs2__UnityEngineVector2Array(){} // RVA: 0x898EAF0
        public void __get_vertexCount__SystemInt32(){} // RVA: 0x898EC80
        public void __set_vertexCount__SystemInt32(){} // RVA: 0x898EE00
        public void __get_vertices__UnityEngineVector3Array(){} // RVA: 0x898EF40
        public void __set_vertices__UnityEngineVector3Array(){} // RVA: 0x898F0B0
        public void <.ctor>b__6_1(){} // RVA: 0x898F240
    }

    public class ExternTMProTMP_MeshInfoArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8990F10
        public void .ctor(){} // RVA: 0x8990F50
        public void GetExternFunctionParameterCount(){} // RVA: 0x8991320
        public void GetExternFunctionDelegate(){} // RVA: 0x8991450
        public void __Clone__SystemObject(){} // RVA: 0x8991560
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8991650
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8991730
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8991800
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8991950
        public void __GetHashCode__SystemInt32(){} // RVA: 0x89919F0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8991B00
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8991C20
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8991D30
        public void __GetType__SystemType(){} // RVA: 0x8991E50
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8991F40
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8992020
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8992150
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x89922E0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8992430
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8992560
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8992690
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8992810
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8992960
        public void __Get__SystemInt32__TMProTMP_MeshInfo(){} // RVA: 0x8992A90
        public void __Initialize__SystemVoid(){} // RVA: 0x8992BB0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8992C20
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8992D50
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8992ED0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8993030
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8993160
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8993290
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8993400
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8993550
        public void __Set__SystemInt32_TMProTMP_MeshInfo__SystemVoid(){} // RVA: 0x8993680
        public void __ToString__SystemString(){} // RVA: 0x89937C0
        public void __ctor__SystemInt32__TMProTMP_MeshInfoArray(){} // RVA: 0x89938C0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8993970
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8993A10
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8993AB0
        public void __get_Length__SystemInt32(){} // RVA: 0x8993B50
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8993BF0
        public void __get_Rank__SystemInt32(){} // RVA: 0x8993C90
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8993D30
        public void <.ctor>b__6_1(){} // RVA: 0x8993E10
    }

    public class ExternTMProTMP_Text : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8995D30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x8995D70
        public void .ctor(){} // RVA: 0x8995DF0
        public void GetExternFunctionParameterCount(){} // RVA: 0x89961C0
        public void GetExternFunctionDelegate(){} // RVA: 0x89962F0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8996400
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x89964F0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8996780
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x8996900
        public void __GetComponentInChildren__T(){} // RVA: 0x8996A40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x8996B30
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8996D80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8996E70
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8997100
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x8997280
        public void __GetComponentInParent__T(){} // RVA: 0x89973C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x89974B0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x8997700
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x8997830
        public void __GetComponent__T(){} // RVA: 0x8997970
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x8997A50
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8997C80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8997D70
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8998080
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8998170
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x89984A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8998590
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8998880
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x8998A20
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x8998B70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x8998C60
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8998F10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8999000
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8999330
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8999420
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8999710
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x89998B0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x8999A00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x8999AF0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x8999DA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x8999E90
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x899A160
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x899A2B0
        public void __GetComponents__TArray(){} // RVA: 0x899A400
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x899A4F0
        public void __get_alignment__TMProTextAlignmentOptions(){} // RVA: 0x899A7B0
        public void __get_alpha__SystemSingle(){} // RVA: 0x899A8A0
        public void __get_characterSpacing__SystemSingle(){} // RVA: 0x899A980
        public void __get_characterWidthAdjustment__SystemSingle(){} // RVA: 0x899AA60
        public void __get_color__UnityEngineColor(){} // RVA: 0x899AB40
        public void __get_enableAutoSizing__SystemBoolean(){} // RVA: 0x899AC50
        public void __get_enabled__SystemBoolean(){} // RVA: 0x899AD30
        public void __get_firstVisibleCharacter__SystemInt32(){} // RVA: 0x899AEA0
        public void __get_fontMaterial__UnityEngineMaterial(){} // RVA: 0x899AF80
        public void __get_fontSharedMaterial__UnityEngineMaterial(){} // RVA: 0x899B0B0
        public void __get_fontSizeMax__SystemSingle(){} // RVA: 0x899B1D0
        public void __get_fontSizeMin__SystemSingle(){} // RVA: 0x899B2B0
        public void __get_fontSize__SystemSingle(){} // RVA: 0x899B390
        public void __get_horizontalAlignment__TMProHorizontalAlignmentOptions(){} // RVA: 0x899B470
        public void __get_isRightToLeftText__SystemBoolean(){} // RVA: 0x899B550
        public void __get_lineSpacing__SystemSingle(){} // RVA: 0x899B630
        public void __get_maxVisibleCharacters__SystemInt32(){} // RVA: 0x899B710
        public void __get_maxVisibleLines__SystemInt32(){} // RVA: 0x899B7F0
        public void __get_maxVisibleWords__SystemInt32(){} // RVA: 0x899B8D0
        public void __get_overflowMode__TMProTextOverflowModes(){} // RVA: 0x899B9B0
        public void __get_paragraphSpacing__SystemSingle(){} // RVA: 0x899BA90
        public void __get_parseCtrlCharacters__SystemBoolean(){} // RVA: 0x899BB70
        public void __get_richText__SystemBoolean(){} // RVA: 0x899BC50
        public void __get_text__SystemString(){} // RVA: 0x899BD30
        public void __get_verticalAlignment__TMProVerticalAlignmentOptions(){} // RVA: 0x899BE20
        public void __get_wordSpacing__SystemSingle(){} // RVA: 0x899BF00
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x899BFE0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x899C2E0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x899C4E0
        public void __set_alignment__TMProTextAlignmentOptions__SystemVoid(){} // RVA: 0x899C7C0
        public void __set_alpha__SystemSingle__SystemVoid(){} // RVA: 0x899C8F0
        public void __set_characterSpacing__SystemSingle__SystemVoid(){} // RVA: 0x899CA00
        public void __set_characterWidthAdjustment__SystemSingle__SystemVoid(){} // RVA: 0x899CB30
        public void __set_color__UnityEngineColor__SystemVoid(){} // RVA: 0x899CC60
        public void __set_enableAutoSizing__SystemBoolean__SystemVoid(){} // RVA: 0x899CD70
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x899CE90
        public void __set_firstVisibleCharacter__SystemInt32__SystemVoid(){} // RVA: 0x899CF80
        public void __set_fontMaterial__UnityEngineMaterial__SystemVoid(){} // RVA: 0x899D090
        public void __set_fontSharedMaterial__UnityEngineMaterial__SystemVoid(){} // RVA: 0x899D330
        public void __set_fontSizeMax__SystemSingle__SystemVoid(){} // RVA: 0x899D450
        public void __set_fontSizeMin__SystemSingle__SystemVoid(){} // RVA: 0x899D580
        public void __set_fontSize__SystemSingle__SystemVoid(){} // RVA: 0x899D6B0
        public void __set_horizontalAlignment__TMProHorizontalAlignmentOptions__SystemVoid(){} // RVA: 0x899D7A0
        public void __set_isRightToLeftText__SystemBoolean__SystemVoid(){} // RVA: 0x899D8B0
        public void __set_lineSpacing__SystemSingle__SystemVoid(){} // RVA: 0x899D9E0
        public void __set_maxVisibleCharacters__SystemInt32__SystemVoid(){} // RVA: 0x899DB10
        public void __set_maxVisibleLines__SystemInt32__SystemVoid(){} // RVA: 0x899DC20
        public void __set_maxVisibleWords__SystemInt32__SystemVoid(){} // RVA: 0x899DD30
        public void __set_overflowMode__TMProTextOverflowModes__SystemVoid(){} // RVA: 0x899DE40
        public void __set_paragraphSpacing__SystemSingle__SystemVoid(){} // RVA: 0x899DF70
        public void __set_parseCtrlCharacters__SystemBoolean__SystemVoid(){} // RVA: 0x899E0A0
        public void __set_richText__SystemBoolean__SystemVoid(){} // RVA: 0x899E1D0
        public void __set_text__SystemString__SystemVoid(){} // RVA: 0x899E300
        public void __set_verticalAlignment__TMProVerticalAlignmentOptions__SystemVoid(){} // RVA: 0x899E3F0
        public void __set_wordSpacing__SystemSingle__SystemVoid(){} // RVA: 0x899E500
        public void <.ctor>b__8_1(){} // RVA: 0x899E630
    }

    public class ExternTMProTMP_TextArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89A24D0
        public void .ctor(){} // RVA: 0x89A2510
        public void GetExternFunctionParameterCount(){} // RVA: 0x89A28E0
        public void GetExternFunctionDelegate(){} // RVA: 0x89A2A10
        public void __Clone__SystemObject(){} // RVA: 0x89A2B20
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x89A2C10
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x89A2CF0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x89A2DC0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x89A2F10
        public void __GetHashCode__SystemInt32(){} // RVA: 0x89A2FB0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x89A30C0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x89A31E0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x89A32F0
        public void __GetType__SystemType(){} // RVA: 0x89A3410
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x89A3500
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x89A35E0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x89A3710
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x89A38A0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x89A39F0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x89A3B20
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x89A3C50
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x89A3DD0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x89A3F20
        public void __Get__SystemInt32__TMProTMP_Text(){} // RVA: 0x89A4050
        public void __Initialize__SystemVoid(){} // RVA: 0x89A41A0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x89A4210
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x89A4340
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x89A44C0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x89A4620
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x89A4750
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x89A4880
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x89A49F0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x89A4B40
        public void __Set__SystemInt32_TMProTMP_Text__SystemVoid(){} // RVA: 0x89A4C70
        public void __ToString__SystemString(){} // RVA: 0x89A4E40
        public void __ctor__SystemInt32__TMProTMP_TextArray(){} // RVA: 0x89A4F40
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x89A5040
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x89A50E0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x89A5180
        public void __get_Length__SystemInt32(){} // RVA: 0x89A5220
        public void __get_LongLength__SystemInt64(){} // RVA: 0x89A52C0
        public void __get_Rank__SystemInt32(){} // RVA: 0x89A5360
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x89A5400
        public void <.ctor>b__6_1(){} // RVA: 0x89A54E0
    }

    public class ExternTMProTMP_TextInfo : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89A7400
        public void .ctor(){} // RVA: 0x89A7440
        public void GetExternFunctionParameterCount(){} // RVA: 0x89A7810
        public void GetExternFunctionDelegate(){} // RVA: 0x89A7940
        public void __ClearAllMeshInfo__SystemVoid(){} // RVA: 0x89A7A50
        public void __ClearMeshInfo__SystemBoolean__SystemVoid(){} // RVA: 0x89A7B50
        public void __ClearUnusedVertices__TMProMaterialReferenceArray__SystemVoid(){} // RVA: 0x89A7C00
        public void __CopyMeshInfoVertexData__TMProTMP_MeshInfoArray(){} // RVA: 0x89A7E20
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x89A7EC0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x89A8010
        public void __GetType__SystemType(){} // RVA: 0x89A8120
        public void __ResetVertexLayout__SystemBoolean__SystemVoid(){} // RVA: 0x89A8210
        public void __ToString__SystemString(){} // RVA: 0x89A82C0
        public void __ctor__TMProTMP_Text__TMProTMP_TextInfo(){} // RVA: 0x89A83C0
        public void __ctor____TMProTMP_TextInfo(){} // RVA: 0x89A84D0
        public void __get_characterCount__SystemInt32(){} // RVA: 0x89A8570
        public void __set_characterCount__SystemInt32(){} // RVA: 0x89A8610
        public void __get_characterInfo__TMProTMP_CharacterInfoArray(){} // RVA: 0x89A86C0
        public void __set_characterInfo__TMProTMP_CharacterInfoArray(){} // RVA: 0x89A8840
        public void __get_lineCount__SystemInt32(){} // RVA: 0x89A8A10
        public void __set_lineCount__SystemInt32(){} // RVA: 0x89A8AB0
        public void __get_lineInfo__TMProTMP_LineInfoArray(){} // RVA: 0x89A8B60
        public void __set_lineInfo__TMProTMP_LineInfoArray(){} // RVA: 0x89A8CE0
        public void __get_linkCount__SystemInt32(){} // RVA: 0x89A8EB0
        public void __set_linkCount__SystemInt32(){} // RVA: 0x89A8F50
        public void __get_linkInfo__TMProTMP_LinkInfoArray(){} // RVA: 0x89A9000
        public void __set_linkInfo__TMProTMP_LinkInfoArray(){} // RVA: 0x89A9180
        public void __get_materialCount__SystemInt32(){} // RVA: 0x89A9350
        public void __set_materialCount__SystemInt32(){} // RVA: 0x89A93F0
        public void __get_meshInfo__TMProTMP_MeshInfoArray(){} // RVA: 0x89A94A0
        public void __set_meshInfo__TMProTMP_MeshInfoArray(){} // RVA: 0x89A9530
        public void __get_pageCount__SystemInt32(){} // RVA: 0x89A9620
        public void __set_pageCount__SystemInt32(){} // RVA: 0x89A96C0
        public void __get_pageInfo__TMProTMP_PageInfoArray(){} // RVA: 0x89A9770
        public void __set_pageInfo__TMProTMP_PageInfoArray(){} // RVA: 0x89A98F0
        public void __get_spaceCount__SystemInt32(){} // RVA: 0x89A9AC0
        public void __set_spaceCount__SystemInt32(){} // RVA: 0x89A9B60
        public void __get_spriteCount__SystemInt32(){} // RVA: 0x89A9C10
        public void __set_spriteCount__SystemInt32(){} // RVA: 0x89A9CB0
        public void __get_textComponent__TMProTMP_Text(){} // RVA: 0x89A9D60
        public void __set_textComponent__TMProTMP_Text(){} // RVA: 0x89A9E40
        public void __get_wordCount__SystemInt32(){} // RVA: 0x89A9F30
        public void __set_wordCount__SystemInt32(){} // RVA: 0x89A9FD0
        public void __get_wordInfo__TMProTMP_WordInfoArray(){} // RVA: 0x89AA080
        public void __set_wordInfo__TMProTMP_WordInfoArray(){} // RVA: 0x89AA200
        public void <.ctor>b__6_1(){} // RVA: 0x89AA3D0
    }

    public class ExternTMProTMP_TextInfoArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89AC470
        public void .ctor(){} // RVA: 0x89AC4B0
        public void GetExternFunctionParameterCount(){} // RVA: 0x89AC880
        public void GetExternFunctionDelegate(){} // RVA: 0x89AC9B0
        public void __Clone__SystemObject(){} // RVA: 0x89ACAC0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x89ACBB0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x89ACC90
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x89ACD60
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x89ACEB0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x89ACF50
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x89AD060
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x89AD180
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x89AD290
        public void __GetType__SystemType(){} // RVA: 0x89AD3B0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x89AD4A0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x89AD580
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x89AD6B0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x89AD840
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x89AD990
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x89ADAC0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x89ADBF0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x89ADD70
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x89ADEC0
        public void __Get__SystemInt32__TMProTMP_TextInfo(){} // RVA: 0x89ADFF0
        public void __Initialize__SystemVoid(){} // RVA: 0x89AE0D0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x89AE140
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x89AE270
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x89AE3F0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x89AE550
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x89AE680
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x89AE7B0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x89AE920
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x89AEA70
        public void __Set__SystemInt32_TMProTMP_TextInfo__SystemVoid(){} // RVA: 0x89AEBA0
        public void __ToString__SystemString(){} // RVA: 0x89AED10
        public void __ctor__SystemInt32__TMProTMP_TextInfoArray(){} // RVA: 0x89AEE10
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x89AEFB0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x89AF050
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x89AF0F0
        public void __get_Length__SystemInt32(){} // RVA: 0x89AF190
        public void __get_LongLength__SystemInt64(){} // RVA: 0x89AF230
        public void __get_Rank__SystemInt32(){} // RVA: 0x89AF2D0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x89AF370
        public void <.ctor>b__6_1(){} // RVA: 0x89AF450
    }

    public class ExternTMProTextAlignmentOptions : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89379F0
        public void .ctor(){} // RVA: 0x8937A30
        public void GetExternFunctionParameterCount(){} // RVA: 0x8937E00
        public void GetExternFunctionDelegate(){} // RVA: 0x8937F30
        public void __CompareTo__SystemObject__SystemInt32(){} // RVA: 0x8938040
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8938170
        public void __GetHashCode__SystemInt32(){} // RVA: 0x89382B0
        public void __GetType__SystemType(){} // RVA: 0x8938360
        public void __HasFlag__SystemEnum__SystemBoolean(){} // RVA: 0x8938450
        public void __ToString__SystemString(){} // RVA: 0x8938520
        public void __ToString__SystemString__SystemString(){} // RVA: 0x89385D0
        public void __get_BaselineFlush__TMProTextAlignmentOptions(){} // RVA: 0x89386A0
        public void __get_BaselineGeoAligned__TMProTextAlignmentOptions(){} // RVA: 0x8938710
        public void __get_BaselineJustified__TMProTextAlignmentOptions(){} // RVA: 0x8938780
        public void __get_BaselineLeft__TMProTextAlignmentOptions(){} // RVA: 0x89387F0
        public void __get_BaselineRight__TMProTextAlignmentOptions(){} // RVA: 0x8938860
        public void __get_Baseline__TMProTextAlignmentOptions(){} // RVA: 0x89388D0
        public void __get_BottomFlush__TMProTextAlignmentOptions(){} // RVA: 0x8938940
        public void __get_BottomGeoAligned__TMProTextAlignmentOptions(){} // RVA: 0x89389B0
        public void __get_BottomJustified__TMProTextAlignmentOptions(){} // RVA: 0x8938A20
        public void __get_BottomLeft__TMProTextAlignmentOptions(){} // RVA: 0x8938A90
        public void __get_BottomRight__TMProTextAlignmentOptions(){} // RVA: 0x8938B00
        public void __get_Bottom__TMProTextAlignmentOptions(){} // RVA: 0x8938B70
        public void __get_CaplineFlush__TMProTextAlignmentOptions(){} // RVA: 0x8938BE0
        public void __get_CaplineGeoAligned__TMProTextAlignmentOptions(){} // RVA: 0x8938C50
        public void __get_CaplineJustified__TMProTextAlignmentOptions(){} // RVA: 0x8938CC0
        public void __get_CaplineLeft__TMProTextAlignmentOptions(){} // RVA: 0x8938D30
        public void __get_CaplineRight__TMProTextAlignmentOptions(){} // RVA: 0x8938DA0
        public void __get_Capline__TMProTextAlignmentOptions(){} // RVA: 0x8938E10
        public void __get_CenterGeoAligned__TMProTextAlignmentOptions(){} // RVA: 0x8938E80
        public void __get_Center__TMProTextAlignmentOptions(){} // RVA: 0x8938EF0
        public void __get_Converted__TMProTextAlignmentOptions(){} // RVA: 0x8938F60
        public void __get_Flush__TMProTextAlignmentOptions(){} // RVA: 0x8938FD0
        public void __get_Justified__TMProTextAlignmentOptions(){} // RVA: 0x8939040
        public void __get_Left__TMProTextAlignmentOptions(){} // RVA: 0x89390B0
        public void __get_MidlineFlush__TMProTextAlignmentOptions(){} // RVA: 0x8939120
        public void __get_MidlineGeoAligned__TMProTextAlignmentOptions(){} // RVA: 0x8939190
        public void __get_MidlineJustified__TMProTextAlignmentOptions(){} // RVA: 0x8939200
        public void __get_MidlineLeft__TMProTextAlignmentOptions(){} // RVA: 0x8939270
        public void __get_MidlineRight__TMProTextAlignmentOptions(){} // RVA: 0x89392E0
        public void __get_Midline__TMProTextAlignmentOptions(){} // RVA: 0x8939350
        public void __get_Right__TMProTextAlignmentOptions(){} // RVA: 0x89393C0
        public void __get_TopFlush__TMProTextAlignmentOptions(){} // RVA: 0x8939430
        public void __get_TopGeoAligned__TMProTextAlignmentOptions(){} // RVA: 0x89394A0
        public void __get_TopJustified__TMProTextAlignmentOptions(){} // RVA: 0x8939510
        public void __get_TopLeft__TMProTextAlignmentOptions(){} // RVA: 0x8939580
        public void __get_TopRight__TMProTextAlignmentOptions(){} // RVA: 0x89395F0
        public void __get_Top__TMProTextAlignmentOptions(){} // RVA: 0x8939660
        public void <.ctor>b__6_1(){} // RVA: 0x89396D0
    }

    public class ExternTMProTextAlignmentOptionsArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x893B9B0
        public void .ctor(){} // RVA: 0x893B9F0
        public void GetExternFunctionParameterCount(){} // RVA: 0x893BDC0
        public void GetExternFunctionDelegate(){} // RVA: 0x893BEF0
        public void __Clone__SystemObject(){} // RVA: 0x893C000
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x893C0F0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x893C1D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x893C2A0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x893C3F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x893C490
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x893C5A0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x893C6C0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x893C7D0
        public void __GetType__SystemType(){} // RVA: 0x893C8F0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x893C9E0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x893CAC0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x893CBF0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x893CD80
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x893CED0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x893D000
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x893D130
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x893D2B0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x893D400
        public void __Get__SystemInt32__TMProTextAlignmentOptions(){} // RVA: 0x893D530
        public void __Initialize__SystemVoid(){} // RVA: 0x893D610
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x893D680
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x893D7B0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x893D930
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x893DA90
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x893DBC0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x893DCF0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x893DE60
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x893DFB0
        public void __Set__SystemInt32_TMProTextAlignmentOptions__SystemVoid(){} // RVA: 0x893E0E0
        public void __ToString__SystemString(){} // RVA: 0x893E1D0
        public void __ctor__SystemInt32__TMProTextAlignmentOptionsArray(){} // RVA: 0x893E2D0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x893E470
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x893E510
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x893E5B0
        public void __get_Length__SystemInt32(){} // RVA: 0x893E650
        public void __get_LongLength__SystemInt64(){} // RVA: 0x893E6F0
        public void __get_Rank__SystemInt32(){} // RVA: 0x893E790
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x893E830
        public void <.ctor>b__6_1(){} // RVA: 0x893E910
    }

    public class ExternTMProTextMeshPro : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8940830
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x8940870
        public void .ctor(){} // RVA: 0x89408F0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8940CC0
        public void GetExternFunctionDelegate(){} // RVA: 0x8940DF0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8940F00
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x89410E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x89411D0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8941460
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x89415E0
        public void __GetComponentInChildren__T(){} // RVA: 0x8941720
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x8941810
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8941A60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8941B50
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8941DE0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x8941F60
        public void __GetComponentInParent__T(){} // RVA: 0x89420A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x8942190
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x89423E0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x8942510
        public void __GetComponent__T(){} // RVA: 0x8942650
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x8942730
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8942960
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8942A50
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8942D60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8942E50
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8943180
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8943270
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8943560
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x8943700
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x8943850
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x8943940
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8943BF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8943CE0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8944010
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8944100
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x89443F0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x8944590
        public void __GetComponentsInParent__TArray(){} // RVA: 0x89446E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x89447D0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x8944A80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x8944B70
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x8944E40
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x8944F90
        public void __GetComponents__TArray(){} // RVA: 0x89450E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x89451D0
        public void __GetType__SystemType(){} // RVA: 0x8945490
        public void __get_color__UnityEngineColor(){} // RVA: 0x8945580
        public void __get_enabled__SystemBoolean(){} // RVA: 0x8945690
        public void __get_faceColor__UnityEngineColor32(){} // RVA: 0x8945800
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x89458E0
        public void __get_isMaskingGraphic__SystemBoolean(){} // RVA: 0x89459F0
        public void __get_isTextObjectScaleStatic__SystemBoolean(){} // RVA: 0x8945AD0
        public void __get_mainTexture__UnityEngineTexture(){} // RVA: 0x8945BB0
        public void __get_material__UnityEngineMaterial(){} // RVA: 0x8945CD0
        public void __get_maxVisibleCharacters__SystemInt32(){} // RVA: 0x8945DF0
        public void __get_name__SystemString(){} // RVA: 0x8945ED0
        public void __get_outlineColor__UnityEngineColor32(){} // RVA: 0x8946030
        public void __get_outlineWidth__SystemSingle(){} // RVA: 0x8946110
        public void __get_renderer__UnityEngineRenderer(){} // RVA: 0x8946200
        public void __get_textInfo__TMProTMP_TextInfo(){} // RVA: 0x8946310
        public void __get_text__SystemString(){} // RVA: 0x89463F0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x89464E0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x89467E0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x89469E0
        public void __set_color__UnityEngineColor__SystemVoid(){} // RVA: 0x8946CC0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x8946DD0
        public void __set_faceColor__UnityEngineColor32__SystemVoid(){} // RVA: 0x8946EC0
        public void __set_isMaskingGraphic__SystemBoolean__SystemVoid(){} // RVA: 0x8946FA0
        public void __set_isTextObjectScaleStatic__SystemBoolean__SystemVoid(){} // RVA: 0x8947090
        public void __set_material__UnityEngineMaterial__SystemVoid(){} // RVA: 0x8947180
        public void __set_maxVisibleCharacters__SystemInt32__SystemVoid(){} // RVA: 0x89472A0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x89473B0
        public void __set_outlineColor__UnityEngineColor32__SystemVoid(){} // RVA: 0x8947510
        public void __set_outlineWidth__SystemSingle__SystemVoid(){} // RVA: 0x89475F0
        public void __set_text__SystemString__SystemVoid(){} // RVA: 0x8947740
        public void <.ctor>b__8_1(){} // RVA: 0x8947830
    }

    public class ExternTMProTextMeshProArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x894A4D0
        public void .ctor(){} // RVA: 0x894A510
        public void GetExternFunctionParameterCount(){} // RVA: 0x894A8E0
        public void GetExternFunctionDelegate(){} // RVA: 0x894AA10
        public void __Clone__SystemObject(){} // RVA: 0x894AB20
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x894AC10
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x894ACF0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x894ADC0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x894AF10
        public void __GetHashCode__SystemInt32(){} // RVA: 0x894AFB0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x894B0C0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x894B1E0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x894B2F0
        public void __GetType__SystemType(){} // RVA: 0x894B410
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x894B500
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x894B5E0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x894B710
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x894B8A0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x894B9F0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x894BB20
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x894BC50
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x894BDD0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x894BF20
        public void __Get__SystemInt32__TMProTextMeshPro(){} // RVA: 0x894C050
        public void __Initialize__SystemVoid(){} // RVA: 0x894C1A0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x894C210
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x894C340
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x894C4C0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x894C620
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x894C750
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x894C880
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x894C9F0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x894CB40
        public void __Set__SystemInt32_TMProTextMeshPro__SystemVoid(){} // RVA: 0x894CC70
        public void __ToString__SystemString(){} // RVA: 0x894CE40
        public void __ctor__SystemInt32__TMProTextMeshProArray(){} // RVA: 0x894CF40
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x894D040
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x894D0E0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x894D180
        public void __get_Length__SystemInt32(){} // RVA: 0x894D220
        public void __get_LongLength__SystemInt64(){} // RVA: 0x894D2C0
        public void __get_Rank__SystemInt32(){} // RVA: 0x894D360
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x894D400
        public void <.ctor>b__6_1(){} // RVA: 0x894D4E0
    }

    public class ExternTMProTextMeshProUGUI : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x894F400
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x894F440
        public void .ctor(){} // RVA: 0x894F4C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x894F890
        public void GetExternFunctionDelegate(){} // RVA: 0x894F9C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x894FAD0
        public void __ForceMeshUpdate__SystemBoolean_SystemBoolean__SystemVoid(){} // RVA: 0x894FCB0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x894FDD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x894FEC0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8950150
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x89502D0
        public void __GetComponentInChildren__T(){} // RVA: 0x8950410
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x8950500
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8950750
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8950840
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8950AD0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x8950C50
        public void __GetComponentInParent__T(){} // RVA: 0x8950D90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x8950E80
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x89510D0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x8951200
        public void __GetComponent__T(){} // RVA: 0x8951340
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x8951420
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8951650
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8951740
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8951A50
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8951B40
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8951E70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8951F60
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8952250
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x89523F0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x8952540
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x8952630
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89528E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89529D0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8952D00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8952DF0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x89530E0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x8953280
        public void __GetComponentsInParent__TArray(){} // RVA: 0x89533D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x89534C0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x8953770
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x8953860
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x8953B30
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x8953C80
        public void __GetComponents__TArray(){} // RVA: 0x8953DD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x8953EC0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8954180
        public void __GetType__SystemType(){} // RVA: 0x89542F0
        public void __ToString__SystemString(){} // RVA: 0x89543E0
        public void __UpdateGeometry__UnityEngineMesh_SystemInt32__SystemVoid(){} // RVA: 0x8954550
        public void __get_color__UnityEngineColor(){} // RVA: 0x89546A0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x89547B0
        public void __get_faceColor__UnityEngineColor32(){} // RVA: 0x8954920
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x8954A00
        public void __get_isMaskingGraphic__SystemBoolean(){} // RVA: 0x8954B10
        public void __get_isTextObjectScaleStatic__SystemBoolean(){} // RVA: 0x8954BF0
        public void __get_mainTexture__UnityEngineTexture(){} // RVA: 0x8954CD0
        public void __get_material__UnityEngineMaterial(){} // RVA: 0x8954DF0
        public void __get_maxVisibleCharacters__SystemInt32(){} // RVA: 0x8954F10
        public void __get_name__SystemString(){} // RVA: 0x8954FF0
        public void __get_outlineColor__UnityEngineColor32(){} // RVA: 0x8955150
        public void __get_outlineWidth__SystemSingle(){} // RVA: 0x8955230
        public void __get_textInfo__TMProTMP_TextInfo(){} // RVA: 0x8955320
        public void __get_text__SystemString(){} // RVA: 0x8955400
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x89554F0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8955600
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x8955900
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8955B00
        public void __set_color__UnityEngineColor__SystemVoid(){} // RVA: 0x8955DE0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x8955EF0
        public void __set_faceColor__UnityEngineColor32__SystemVoid(){} // RVA: 0x8955FE0
        public void __set_isMaskingGraphic__SystemBoolean__SystemVoid(){} // RVA: 0x89560C0
        public void __set_isTextObjectScaleStatic__SystemBoolean__SystemVoid(){} // RVA: 0x89561B0
        public void __set_material__UnityEngineMaterial__SystemVoid(){} // RVA: 0x89562A0
        public void __set_maxVisibleCharacters__SystemInt32__SystemVoid(){} // RVA: 0x89563C0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x89564D0
        public void __set_outlineColor__UnityEngineColor32__SystemVoid(){} // RVA: 0x8956630
        public void __set_outlineWidth__SystemSingle__SystemVoid(){} // RVA: 0x8956710
        public void __set_text__SystemString__SystemVoid(){} // RVA: 0x8956860
        public void <.ctor>b__8_1(){} // RVA: 0x8956950
    }

    public class ExternTMProTextMeshProUGUIArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89598E0
        public void .ctor(){} // RVA: 0x8959920
        public void GetExternFunctionParameterCount(){} // RVA: 0x8959CF0
        public void GetExternFunctionDelegate(){} // RVA: 0x8959E20
        public void __Clone__SystemObject(){} // RVA: 0x8959F30
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x895A020
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x895A100
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x895A1D0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x895A320
        public void __GetHashCode__SystemInt32(){} // RVA: 0x895A3C0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x895A4D0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x895A5F0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x895A700
        public void __GetType__SystemType(){} // RVA: 0x895A820
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x895A910
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x895A9F0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x895AB20
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x895ACB0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x895AE00
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x895AF30
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x895B060
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x895B1E0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x895B330
        public void __Get__SystemInt32__TMProTextMeshProUGUI(){} // RVA: 0x895B460
        public void __Initialize__SystemVoid(){} // RVA: 0x895B5B0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x895B620
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x895B750
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x895B8D0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x895BA30
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x895BB60
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x895BC90
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x895BE00
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x895BF50
        public void __Set__SystemInt32_TMProTextMeshProUGUI__SystemVoid(){} // RVA: 0x895C080
        public void __ToString__SystemString(){} // RVA: 0x895C200
        public void __ctor__SystemInt32__TMProTextMeshProUGUIArray(){} // RVA: 0x895C300
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x895C400
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x895C4A0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x895C540
        public void __get_Length__SystemInt32(){} // RVA: 0x895C5E0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x895C680
        public void __get_Rank__SystemInt32(){} // RVA: 0x895C720
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x895C7C0
        public void <.ctor>b__6_1(){} // RVA: 0x895C8A0
    }

    public class ExternTMProTextOverflowModes : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x895E7C0
        public void .ctor(){} // RVA: 0x895E800
        public void GetExternFunctionParameterCount(){} // RVA: 0x895EBD0
        public void GetExternFunctionDelegate(){} // RVA: 0x895ED00
        public void __CompareTo__SystemObject__SystemInt32(){} // RVA: 0x895EE10
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x895EF40
        public void __GetHashCode__SystemInt32(){} // RVA: 0x895F080
        public void __GetType__SystemType(){} // RVA: 0x895F130
        public void __HasFlag__SystemEnum__SystemBoolean(){} // RVA: 0x895F220
        public void __ToString__SystemString(){} // RVA: 0x895F2F0
        public void __ToString__SystemString__SystemString(){} // RVA: 0x895F3A0
        public void __get_Ellipsis__TMProTextOverflowModes(){} // RVA: 0x895F470
        public void __get_Linked__TMProTextOverflowModes(){} // RVA: 0x895F4E0
        public void __get_Masking__TMProTextOverflowModes(){} // RVA: 0x895F550
        public void __get_Overflow__TMProTextOverflowModes(){} // RVA: 0x895F5C0
        public void __get_Page__TMProTextOverflowModes(){} // RVA: 0x895F630
        public void __get_ScrollRect__TMProTextOverflowModes(){} // RVA: 0x895F6A0
        public void __get_Truncate__TMProTextOverflowModes(){} // RVA: 0x895F710
        public void <.ctor>b__6_1(){} // RVA: 0x895F780
    }

    public class ExternTMProTextOverflowModesArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89603E0
        public void .ctor(){} // RVA: 0x8960420
        public void GetExternFunctionParameterCount(){} // RVA: 0x89607F0
        public void GetExternFunctionDelegate(){} // RVA: 0x8960920
        public void __Clone__SystemObject(){} // RVA: 0x8960A30
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8960B20
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8960C00
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8960CD0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8960E20
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8960EC0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8960FD0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x89610F0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8961200
        public void __GetType__SystemType(){} // RVA: 0x8961320
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8961410
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x89614F0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8961620
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x89617B0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8961900
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8961A30
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8961B60
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8961CE0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8961E30
        public void __Get__SystemInt32__TMProTextOverflowModes(){} // RVA: 0x8961F60
        public void __Initialize__SystemVoid(){} // RVA: 0x8962040
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x89620B0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x89621E0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8962360
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x89624C0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x89625F0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8962720
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8962890
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x89629E0
        public void __Set__SystemInt32_TMProTextOverflowModes__SystemVoid(){} // RVA: 0x8962B10
        public void __ToString__SystemString(){} // RVA: 0x8962C00
        public void __ctor__SystemInt32__TMProTextOverflowModesArray(){} // RVA: 0x8962D00
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8962EA0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8962F40
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8962FE0
        public void __get_Length__SystemInt32(){} // RVA: 0x8963080
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8963120
        public void __get_Rank__SystemInt32(){} // RVA: 0x89631C0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8963260
        public void <.ctor>b__6_1(){} // RVA: 0x8963340
    }

    public class ExternTMProTextRenderFlags : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8965260
        public void .ctor(){} // RVA: 0x89652A0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8965670
        public void GetExternFunctionDelegate(){} // RVA: 0x89657A0
        public void __CompareTo__SystemObject__SystemInt32(){} // RVA: 0x89658B0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x89659E0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8965B20
        public void __GetType__SystemType(){} // RVA: 0x8965BD0
        public void __HasFlag__SystemEnum__SystemBoolean(){} // RVA: 0x8965CC0
        public void __ToString__SystemString(){} // RVA: 0x8965D90
        public void __ToString__SystemString__SystemString(){} // RVA: 0x8965E40
        public void __get_DontRender__TMProTextRenderFlags(){} // RVA: 0x8965F10
        public void __get_Render__TMProTextRenderFlags(){} // RVA: 0x8965F80
        public void <.ctor>b__6_1(){} // RVA: 0x8965FF0
    }

    public class ExternTMProTextRenderFlagsArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8966890
        public void .ctor(){} // RVA: 0x89668D0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8966CA0
        public void GetExternFunctionDelegate(){} // RVA: 0x8966DD0
        public void __Clone__SystemObject(){} // RVA: 0x8966EE0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8966FD0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x89670B0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8967180
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x89672D0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8967370
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8967480
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x89675A0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x89676B0
        public void __GetType__SystemType(){} // RVA: 0x89677D0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x89678C0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x89679A0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8967AD0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8967C60
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8967DB0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8967EE0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8968010
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8968190
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x89682E0
        public void __Get__SystemInt32__TMProTextRenderFlags(){} // RVA: 0x8968410
        public void __Initialize__SystemVoid(){} // RVA: 0x89684F0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8968560
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8968690
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8968810
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8968970
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8968AA0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8968BD0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8968D40
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8968E90
        public void __Set__SystemInt32_TMProTextRenderFlags__SystemVoid(){} // RVA: 0x8968FC0
        public void __ToString__SystemString(){} // RVA: 0x89690B0
        public void __ctor__SystemInt32__TMProTextRenderFlagsArray(){} // RVA: 0x89691B0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8969350
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x89693F0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8969490
        public void __get_Length__SystemInt32(){} // RVA: 0x8969530
        public void __get_LongLength__SystemInt64(){} // RVA: 0x89695D0
        public void __get_Rank__SystemInt32(){} // RVA: 0x8969670
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8969710
        public void <.ctor>b__6_1(){} // RVA: 0x89697F0
    }

    public class ExternTMProVertexSortingOrder : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89B1370
        public void .ctor(){} // RVA: 0x89B13B0
        public void GetExternFunctionParameterCount(){} // RVA: 0x89B1780
        public void GetExternFunctionDelegate(){} // RVA: 0x89B18B0
        public void __CompareTo__SystemObject__SystemInt32(){} // RVA: 0x89B19C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x89B1AF0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x89B1C30
        public void __GetType__SystemType(){} // RVA: 0x89B1CE0
        public void __HasFlag__SystemEnum__SystemBoolean(){} // RVA: 0x89B1DD0
        public void __ToString__SystemString(){} // RVA: 0x89B1EA0
        public void __ToString__SystemString__SystemString(){} // RVA: 0x89B1F50
        public void __get_Normal__TMProVertexSortingOrder(){} // RVA: 0x89B2020
        public void __get_Reverse__TMProVertexSortingOrder(){} // RVA: 0x89B2090
        public void <.ctor>b__6_1(){} // RVA: 0x89B2100
    }

    public class ExternTMProVertexSortingOrderArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89B29A0
        public void .ctor(){} // RVA: 0x89B29E0
        public void GetExternFunctionParameterCount(){} // RVA: 0x89B2DB0
        public void GetExternFunctionDelegate(){} // RVA: 0x89B2EE0
        public void __Clone__SystemObject(){} // RVA: 0x89B2FF0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x89B30E0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x89B31C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x89B3290
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x89B33E0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x89B3480
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x89B3590
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x89B36B0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x89B37C0
        public void __GetType__SystemType(){} // RVA: 0x89B38E0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x89B39D0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x89B3AB0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x89B3BE0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x89B3D70
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x89B3EC0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x89B3FF0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x89B4120
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x89B42A0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x89B43F0
        public void __Get__SystemInt32__TMProVertexSortingOrder(){} // RVA: 0x89B4520
        public void __Initialize__SystemVoid(){} // RVA: 0x89B4600
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x89B4670
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x89B47A0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x89B4920
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x89B4A80
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x89B4BB0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x89B4CE0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x89B4E50
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x89B4FA0
        public void __Set__SystemInt32_TMProVertexSortingOrder__SystemVoid(){} // RVA: 0x89B50D0
        public void __ToString__SystemString(){} // RVA: 0x89B51C0
        public void __ctor__SystemInt32__TMProVertexSortingOrderArray(){} // RVA: 0x89B52C0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x89B5460
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x89B5500
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x89B55A0
        public void __get_Length__SystemInt32(){} // RVA: 0x89B5640
        public void __get_LongLength__SystemInt64(){} // RVA: 0x89B56E0
        public void __get_Rank__SystemInt32(){} // RVA: 0x89B5780
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x89B5820
        public void <.ctor>b__6_1(){} // RVA: 0x89B5900
    }

    public class ExternTMProVerticalAlignmentOptions : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89B7820
        public void .ctor(){} // RVA: 0x89B7860
        public void GetExternFunctionParameterCount(){} // RVA: 0x89B7C30
        public void GetExternFunctionDelegate(){} // RVA: 0x89B7D60
        public void __CompareTo__SystemObject__SystemInt32(){} // RVA: 0x89B7E70
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x89B7FA0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x89B80E0
        public void __GetType__SystemType(){} // RVA: 0x89B8190
        public void __HasFlag__SystemEnum__SystemBoolean(){} // RVA: 0x89B8280
        public void __ToString__SystemString(){} // RVA: 0x89B8350
        public void __ToString__SystemString__SystemString(){} // RVA: 0x89B8400
        public void __get_Baseline__TMProVerticalAlignmentOptions(){} // RVA: 0x89B84D0
        public void __get_Bottom__TMProVerticalAlignmentOptions(){} // RVA: 0x89B8540
        public void __get_Capline__TMProVerticalAlignmentOptions(){} // RVA: 0x89B85B0
        public void __get_Geometry__TMProVerticalAlignmentOptions(){} // RVA: 0x89B8620
        public void __get_Middle__TMProVerticalAlignmentOptions(){} // RVA: 0x89B8690
        public void __get_Top__TMProVerticalAlignmentOptions(){} // RVA: 0x89B8700
        public void <.ctor>b__6_1(){} // RVA: 0x89B8770
    }

    public class ExternTMProVerticalAlignmentOptionsArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89B9300
        public void .ctor(){} // RVA: 0x89B9340
        public void GetExternFunctionParameterCount(){} // RVA: 0x89B9710
        public void GetExternFunctionDelegate(){} // RVA: 0x89B9840
        public void __Clone__SystemObject(){} // RVA: 0x89B9950
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x89B9A40
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x89B9B20
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x89B9BF0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x89B9D40
        public void __GetHashCode__SystemInt32(){} // RVA: 0x89B9DE0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x89B9EF0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x89BA010
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x89BA120
        public void __GetType__SystemType(){} // RVA: 0x89BA240
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x89BA330
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x89BA410
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x89BA540
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x89BA6D0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x89BA820
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x89BA950
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x89BAA80
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x89BAC00
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x89BAD50
        public void __Get__SystemInt32__TMProVerticalAlignmentOptions(){} // RVA: 0x89BAE80
        public void __Initialize__SystemVoid(){} // RVA: 0x89BAF60
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x89BAFD0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x89BB100
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x89BB280
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x89BB3E0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x89BB510
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x89BB640
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x89BB7B0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x89BB900
        public void __Set__SystemInt32_TMProVerticalAlignmentOptions__SystemVoid(){} // RVA: 0x89BBA30
        public void __ToString__SystemString(){} // RVA: 0x89BBB20
        public void __ctor__SystemInt32__TMProVerticalAlignmentOptionsArray(){} // RVA: 0x89BBC20
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x89BBDC0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x89BBE60
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x89BBF00
        public void __get_Length__SystemInt32(){} // RVA: 0x89BBFA0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x89BC040
        public void __get_Rank__SystemInt32(){} // RVA: 0x89BC0E0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x89BC180
        public void <.ctor>b__6_1(){} // RVA: 0x89BC260
    }

    public class ExternUnityAINavigationCollectObjects : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89BE180
        public void .ctor(){} // RVA: 0x89BE1C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x89BE590
        public void GetExternFunctionDelegate(){} // RVA: 0x89BE6C0
        public void __CompareTo__SystemObject__SystemInt32(){} // RVA: 0x89BE7D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x89BE900
        public void __GetHashCode__SystemInt32(){} // RVA: 0x89BEA40
        public void __GetType__SystemType(){} // RVA: 0x89BEAF0
        public void __HasFlag__SystemEnum__SystemBoolean(){} // RVA: 0x89BEBE0
        public void __ToString__SystemString(){} // RVA: 0x89BECB0
        public void __ToString__SystemString__SystemString(){} // RVA: 0x89BED60
        public void __get_All__UnityAINavigationCollectObjects(){} // RVA: 0x89BEE30
        public void __get_Children__UnityAINavigationCollectObjects(){} // RVA: 0x89BEEA0
        public void __get_MarkedWithModifier__UnityAINavigationCollectObjects(){} // RVA: 0x89BEF10
        public void __get_Volume__UnityAINavigationCollectObjects(){} // RVA: 0x89BEF80
        public void <.ctor>b__6_1(){} // RVA: 0x89BEFF0
    }

    public class ExternUnityAINavigationNavMeshLink : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89BFA00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x89BFA40
        public void .ctor(){} // RVA: 0x89BFAC0
        public void GetExternFunctionParameterCount(){} // RVA: 0x89BFE90
        public void GetExternFunctionDelegate(){} // RVA: 0x89BFFC0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x89C00D0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x89C02B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x89C03A0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x89C0630
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x89C07B0
        public void __GetComponentInChildren__T(){} // RVA: 0x89C08F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x89C09E0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x89C0C30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x89C0D20
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x89C0FB0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x89C1130
        public void __GetComponentInParent__T(){} // RVA: 0x89C1270
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x89C1360
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x89C15B0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x89C16E0
        public void __GetComponent__T(){} // RVA: 0x89C1820
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x89C1900
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x89C1B30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x89C1C20
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89C1F30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89C2020
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x89C2350
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x89C2440
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x89C2730
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x89C28D0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x89C2A20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x89C2B10
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89C2DC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89C2EB0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x89C31E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x89C32D0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x89C35C0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x89C3760
        public void __GetComponentsInParent__TArray(){} // RVA: 0x89C38B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x89C39A0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x89C3C50
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x89C3D40
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x89C4010
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x89C4160
        public void __GetComponents__TArray(){} // RVA: 0x89C42B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x89C43A0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x89C4660
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x89C47D0
        public void __GetType__SystemType(){} // RVA: 0x89C4930
        public void __ToString__SystemString(){} // RVA: 0x89C4A20
        public void __UpdateLink__SystemVoid(){} // RVA: 0x89C4B90
        public void __get_activated__SystemBoolean(){} // RVA: 0x89C4C50
        public void __get_agentTypeID__SystemInt32(){} // RVA: 0x89C4D30
        public void __get_area__SystemInt32(){} // RVA: 0x89C4E10
        public void __get_autoUpdate__SystemBoolean(){} // RVA: 0x89C4EF0
        public void __get_bidirectional__SystemBoolean(){} // RVA: 0x89C4FD0
        public void __get_costModifier__SystemSingle(){} // RVA: 0x89C50B0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x89C51A0
        public void __get_endPoint__UnityEngineVector3(){} // RVA: 0x89C5310
        public void __get_endTransform__UnityEngineTransform(){} // RVA: 0x89C5400
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x89C5510
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x89C5620
        public void __get_name__SystemString(){} // RVA: 0x89C5790
        public void __get_occupied__SystemBoolean(){} // RVA: 0x89C58F0
        public void __get_startPoint__UnityEngineVector3(){} // RVA: 0x89C5A20
        public void __get_startTransform__UnityEngineTransform(){} // RVA: 0x89C5B10
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x89C5C20
        public void __get_width__SystemSingle(){} // RVA: 0x89C5D30
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x89C5E10
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x89C6110
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x89C6310
        public void __set_activated__SystemBoolean__SystemVoid(){} // RVA: 0x89C65F0
        public void __set_area__SystemInt32__SystemVoid(){} // RVA: 0x89C6720
        public void __set_autoUpdate__SystemBoolean__SystemVoid(){} // RVA: 0x89C6810
        public void __set_bidirectional__SystemBoolean__SystemVoid(){} // RVA: 0x89C6900
        public void __set_costModifier__SystemSingle__SystemVoid(){} // RVA: 0x89C69F0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x89C6B40
        public void __set_endPoint__UnityEngineVector3__SystemVoid(){} // RVA: 0x89C6C30
        public void __set_endTransform__UnityEngineTransform__SystemVoid(){} // RVA: 0x89C6D80
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x89C6FF0
        public void __set_startPoint__UnityEngineVector3__SystemVoid(){} // RVA: 0x89C7150
        public void __set_startTransform__UnityEngineTransform__SystemVoid(){} // RVA: 0x89C72A0
        public void __set_width__SystemSingle__SystemVoid(){} // RVA: 0x89C7510
        public void <.ctor>b__8_1(){} // RVA: 0x89C7630
    }

    public class ExternUnityAINavigationNavMeshLinkArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89CA810
        public void .ctor(){} // RVA: 0x89CA850
        public void GetExternFunctionParameterCount(){} // RVA: 0x89CAC20
        public void GetExternFunctionDelegate(){} // RVA: 0x89CAD50
        public void __Clone__SystemObject(){} // RVA: 0x89CAE60
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x89CAF50
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x89CB030
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x89CB100
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x89CB250
        public void __GetHashCode__SystemInt32(){} // RVA: 0x89CB2F0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x89CB400
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x89CB520
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x89CB630
        public void __GetType__SystemType(){} // RVA: 0x89CB750
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x89CB840
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x89CB920
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x89CBA50
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x89CBBE0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x89CBD30
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x89CBE60
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x89CBF90
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x89CC110
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x89CC260
        public void __Get__SystemInt32__UnityAINavigationNavMeshLink(){} // RVA: 0x89CC390
        public void __Initialize__SystemVoid(){} // RVA: 0x89CC4E0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x89CC550
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x89CC680
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x89CC800
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x89CC960
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x89CCA90
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x89CCBC0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x89CCD30
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x89CCE80
        public void __Set__SystemInt32_UnityAINavigationNavMeshLink__SystemVoid(){} // RVA: 0x89CCFB0
        public void __ToString__SystemString(){} // RVA: 0x89CD180
        public void __ctor__SystemInt32__UnityAINavigationNavMeshLinkArray(){} // RVA: 0x89CD280
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x89CD380
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x89CD420
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x89CD4C0
        public void __get_Length__SystemInt32(){} // RVA: 0x89CD560
        public void __get_LongLength__SystemInt64(){} // RVA: 0x89CD600
        public void __get_Rank__SystemInt32(){} // RVA: 0x89CD6A0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x89CD740
        public void <.ctor>b__6_1(){} // RVA: 0x89CD820
    }

    public class ExternUnityAINavigationNavMeshModifier : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89CF740
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x89CF780
        public void .ctor(){} // RVA: 0x89CF800
        public void GetExternFunctionParameterCount(){} // RVA: 0x89CFBD0
        public void GetExternFunctionDelegate(){} // RVA: 0x89CFD00
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x89CFE10
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x89CFFF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x89D00E0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x89D0370
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x89D04F0
        public void __GetComponentInChildren__T(){} // RVA: 0x89D0630
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x89D0720
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x89D0970
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x89D0A60
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x89D0CF0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x89D0E70
        public void __GetComponentInParent__T(){} // RVA: 0x89D0FB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x89D10A0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x89D12F0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x89D1420
        public void __GetComponent__T(){} // RVA: 0x89D1560
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x89D1640
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x89D1870
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x89D1960
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89D1C70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89D1D60
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x89D2090
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x89D2180
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x89D2470
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x89D2610
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x89D2760
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x89D2850
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89D2B00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89D2BF0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x89D2F20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x89D3010
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x89D3300
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x89D34A0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x89D35F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x89D36E0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x89D3990
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x89D3A80
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x89D3D50
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x89D3EA0
        public void __GetComponents__TArray(){} // RVA: 0x89D3FF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x89D40E0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x89D43A0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x89D4510
        public void __GetType__SystemType(){} // RVA: 0x89D4670
        public void __ToString__SystemString(){} // RVA: 0x89D4760
        public void __get_applyToChildren__SystemBoolean(){} // RVA: 0x89D48D0
        public void __get_area__SystemInt32(){} // RVA: 0x89D49B0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x89D4A90
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x89D4C00
        public void __get_generateLinks__SystemBoolean(){} // RVA: 0x89D4D10
        public void __get_ignoreFromBuild__SystemBoolean(){} // RVA: 0x89D4DF0
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x89D4ED0
        public void __get_name__SystemString(){} // RVA: 0x89D5040
        public void __get_overrideArea__SystemBoolean(){} // RVA: 0x89D51A0
        public void __get_overrideGenerateLinks__SystemBoolean(){} // RVA: 0x89D5280
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x89D5360
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x89D5470
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x89D5770
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x89D5970
        public void __set_applyToChildren__SystemBoolean__SystemVoid(){} // RVA: 0x89D5C50
        public void __set_area__SystemInt32__SystemVoid(){} // RVA: 0x89D5D30
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x89D5E10
        public void __set_generateLinks__SystemBoolean__SystemVoid(){} // RVA: 0x89D5F00
        public void __set_ignoreFromBuild__SystemBoolean__SystemVoid(){} // RVA: 0x89D5FE0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x89D60C0
        public void __set_overrideArea__SystemBoolean__SystemVoid(){} // RVA: 0x89D6220
        public void __set_overrideGenerateLinks__SystemBoolean__SystemVoid(){} // RVA: 0x89D6300
        public void <.ctor>b__8_1(){} // RVA: 0x89D63E0
    }

    public class ExternUnityAINavigationNavMeshModifierArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89D8D80
        public void .ctor(){} // RVA: 0x89D8DC0
        public void GetExternFunctionParameterCount(){} // RVA: 0x89D9190
        public void GetExternFunctionDelegate(){} // RVA: 0x89D92C0
        public void __Clone__SystemObject(){} // RVA: 0x89D93D0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x89D94C0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x89D95A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x89D9670
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x89D97C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x89D9860
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x89D9970
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x89D9A90
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x89D9BA0
        public void __GetType__SystemType(){} // RVA: 0x89D9CC0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x89D9DB0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x89D9E90
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x89D9FC0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x89DA150
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x89DA2A0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x89DA3D0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x89DA500
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x89DA680
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x89DA7D0
        public void __Get__SystemInt32__UnityAINavigationNavMeshModifier(){} // RVA: 0x89DA900
        public void __Initialize__SystemVoid(){} // RVA: 0x89DAA50
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x89DAAC0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x89DABF0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x89DAD70
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x89DAED0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x89DB000
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x89DB130
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x89DB2A0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x89DB3F0
        public void __Set__SystemInt32_UnityAINavigationNavMeshModifier__SystemVoid(){} // RVA: 0x89DB520
        public void __ToString__SystemString(){} // RVA: 0x89DB6F0
        public void __ctor__SystemInt32__UnityAINavigationNavMeshModifierArray(){} // RVA: 0x89DB7F0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x89DB8F0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x89DB990
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x89DBA30
        public void __get_Length__SystemInt32(){} // RVA: 0x89DBAD0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x89DBB70
        public void __get_Rank__SystemInt32(){} // RVA: 0x89DBC10
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x89DBCB0
        public void <.ctor>b__6_1(){} // RVA: 0x89DBD90
    }

    public class ExternUnityAINavigationNavMeshModifierVolume : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89DDCB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x89DDCF0
        public void .ctor(){} // RVA: 0x89DDD70
        public void GetExternFunctionParameterCount(){} // RVA: 0x89DE140
        public void GetExternFunctionDelegate(){} // RVA: 0x89DE270
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x89DE380
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x89DE560
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x89DE650
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x89DE8E0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x89DEA60
        public void __GetComponentInChildren__T(){} // RVA: 0x89DEBA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x89DEC90
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x89DEEE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x89DEFD0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x89DF260
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x89DF3E0
        public void __GetComponentInParent__T(){} // RVA: 0x89DF520
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x89DF610
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x89DF860
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x89DF990
        public void __GetComponent__T(){} // RVA: 0x89DFAD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x89DFBB0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x89DFDE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x89DFED0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89E01E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89E02D0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x89E0600
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x89E06F0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x89E09E0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x89E0B80
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x89E0CD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x89E0DC0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89E1070
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89E1160
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x89E1490
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x89E1580
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x89E1870
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x89E1A10
        public void __GetComponentsInParent__TArray(){} // RVA: 0x89E1B60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x89E1C50
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x89E1F00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x89E1FF0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x89E22C0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x89E2410
        public void __GetComponents__TArray(){} // RVA: 0x89E2560
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x89E2650
        public void __GetHashCode__SystemInt32(){} // RVA: 0x89E2910
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x89E2A80
        public void __GetType__SystemType(){} // RVA: 0x89E2BE0
        public void __ToString__SystemString(){} // RVA: 0x89E2CD0
        public void __get_area__SystemInt32(){} // RVA: 0x89E2E40
        public void __get_center__UnityEngineVector3(){} // RVA: 0x89E2F20
        public void __get_enabled__SystemBoolean(){} // RVA: 0x89E3010
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x89E3180
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x89E3290
        public void __get_name__SystemString(){} // RVA: 0x89E3400
        public void __get_size__UnityEngineVector3(){} // RVA: 0x89E3560
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x89E3650
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x89E3760
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x89E3A60
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x89E3C60
        public void __set_area__SystemInt32__SystemVoid(){} // RVA: 0x89E3F40
        public void __set_center__UnityEngineVector3__SystemVoid(){} // RVA: 0x89E4020
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x89E4110
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x89E4200
        public void __set_size__UnityEngineVector3__SystemVoid(){} // RVA: 0x89E4360
        public void <.ctor>b__8_1(){} // RVA: 0x89E4450
    }

    public class ExternUnityAINavigationNavMeshModifierVolumeArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89E6970
        public void .ctor(){} // RVA: 0x89E69B0
        public void GetExternFunctionParameterCount(){} // RVA: 0x89E6D80
        public void GetExternFunctionDelegate(){} // RVA: 0x89E6EB0
        public void __Clone__SystemObject(){} // RVA: 0x89E6FC0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x89E70B0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x89E7190
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x89E7260
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x89E73B0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x89E7450
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x89E7560
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x89E7680
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x89E7790
        public void __GetType__SystemType(){} // RVA: 0x89E78B0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x89E79A0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x89E7A80
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x89E7BB0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x89E7D40
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x89E7E90
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x89E7FC0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x89E80F0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x89E8270
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x89E83C0
        public void __Get__SystemInt32__UnityAINavigationNavMeshModifierVolume(){} // RVA: 0x89E84F0
        public void __Initialize__SystemVoid(){} // RVA: 0x89E8640
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x89E86B0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x89E87E0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x89E8960
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x89E8AC0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x89E8BF0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x89E8D20
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x89E8E90
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x89E8FE0
        public void __Set__SystemInt32_UnityAINavigationNavMeshModifierVolume__SystemVoid(){} // RVA: 0x89E9110
        public void __ToString__SystemString(){} // RVA: 0x89E92E0
        public void __ctor__SystemInt32__UnityAINavigationNavMeshModifierVolumeArray(){} // RVA: 0x89E93E0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x89E94E0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x89E9580
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x89E9620
        public void __get_Length__SystemInt32(){} // RVA: 0x89E96C0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x89E9760
        public void __get_Rank__SystemInt32(){} // RVA: 0x89E9800
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x89E98A0
        public void <.ctor>b__6_1(){} // RVA: 0x89E9980
    }

    public class ExternUnityAINavigationNavMeshSurface : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89EB8A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x89EB8E0
        public void .ctor(){} // RVA: 0x89EB960
        public void GetExternFunctionParameterCount(){} // RVA: 0x89EBD30
        public void GetExternFunctionDelegate(){} // RVA: 0x89EBE60
        public void __AddData__SystemVoid(){} // RVA: 0x89EBF70
        public void __BuildNavMesh__SystemVoid(){} // RVA: 0x89EC030
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x89EC0F0
        public void __GetBuildSettings__UnityEngineAINavMeshBuildSettings(){} // RVA: 0x89EC2D0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x89EC400
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x89EC4F0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x89EC780
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x89EC900
        public void __GetComponentInChildren__T(){} // RVA: 0x89ECA40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x89ECB30
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x89ECD80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x89ECE70
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x89ED100
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x89ED280
        public void __GetComponentInParent__T(){} // RVA: 0x89ED3C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x89ED4B0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x89ED700
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x89ED830
        public void __GetComponent__T(){} // RVA: 0x89ED970
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x89EDA50
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x89EDC80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x89EDD70
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89EE080
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89EE170
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x89EE4A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x89EE590
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x89EE880
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x89EEA20
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x89EEB70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x89EEC60
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89EEF10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x89EF000
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x89EF330
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x89EF420
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x89EF710
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x89EF8B0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x89EFA00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x89EFAF0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x89EFDA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x89EFE90
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x89F0160
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x89F02B0
        public void __GetComponents__TArray(){} // RVA: 0x89F0400
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x89F04F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x89F07B0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x89F0920
        public void __GetType__SystemType(){} // RVA: 0x89F0A80
        public void __RemoveData__SystemVoid(){} // RVA: 0x89F0B70
        public void __ToString__SystemString(){} // RVA: 0x89F0C70
        public void __UpdateNavMesh__UnityEngineAINavMeshData__UnityEngineAsyncOperation(){} // RVA: 0x89F0DE0
        public void __get_activeSurfaces__SystemCollectionsGenericListUnityAINavigationNavMeshSurface(){} // RVA: 0x89F10B0
        public void __get_agentTypeID__SystemInt32(){} // RVA: 0x89F1280
        public void __get_buildHeightMesh__SystemBoolean(){} // RVA: 0x89F1360
        public void __get_center__UnityEngineVector3(){} // RVA: 0x89F1440
        public void __get_collectObjects__UnityAINavigationCollectObjects(){} // RVA: 0x89F1530
        public void __get_defaultArea__SystemInt32(){} // RVA: 0x89F1610
        public void __get_enabled__SystemBoolean(){} // RVA: 0x89F16F0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x89F1860
        public void __get_ignoreNavMeshAgent__SystemBoolean(){} // RVA: 0x89F1970
        public void __get_ignoreNavMeshObstacle__SystemBoolean(){} // RVA: 0x89F1A50
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x89F1B30
        public void __get_layerMask__UnityEngineLayerMask(){} // RVA: 0x89F1CA0
        public void __get_minRegionArea__SystemSingle(){} // RVA: 0x89F1D80
        public void __get_name__SystemString(){} // RVA: 0x89F1E60
        public void __get_navMeshData__UnityEngineAINavMeshData(){} // RVA: 0x89F1FC0
        public void __get_overrideTileSize__SystemBoolean(){} // RVA: 0x89F20D0
        public void __get_overrideVoxelSize__SystemBoolean(){} // RVA: 0x89F21B0
        public void __get_size__UnityEngineVector3(){} // RVA: 0x89F2290
        public void __get_tileSize__SystemInt32(){} // RVA: 0x89F2380
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x89F2460
        public void __get_useGeometry__UnityEngineAINavMeshCollectGeometry(){} // RVA: 0x89F2570
        public void __get_voxelSize__SystemSingle(){} // RVA: 0x89F2650
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x89F2730
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x89F2A30
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x89F2C30
        public void __set_buildHeightMesh__SystemBoolean__SystemVoid(){} // RVA: 0x89F2F10
        public void __set_center__UnityEngineVector3__SystemVoid(){} // RVA: 0x89F2FF0
        public void __set_collectObjects__UnityAINavigationCollectObjects__SystemVoid(){} // RVA: 0x89F30E0
        public void __set_defaultArea__SystemInt32__SystemVoid(){} // RVA: 0x89F31C0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x89F32A0
        public void __set_ignoreNavMeshAgent__SystemBoolean__SystemVoid(){} // RVA: 0x89F3390
        public void __set_ignoreNavMeshObstacle__SystemBoolean__SystemVoid(){} // RVA: 0x89F3470
        public void __set_layerMask__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x89F3550
        public void __set_minRegionArea__SystemSingle__SystemVoid(){} // RVA: 0x89F3630
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x89F3710
        public void __set_navMeshData__UnityEngineAINavMeshData__SystemVoid(){} // RVA: 0x89F3870
        public void __set_overrideTileSize__SystemBoolean__SystemVoid(){} // RVA: 0x89F39D0
        public void __set_overrideVoxelSize__SystemBoolean__SystemVoid(){} // RVA: 0x89F3AB0
        public void __set_size__UnityEngineVector3__SystemVoid(){} // RVA: 0x89F3B90
        public void __set_tileSize__SystemInt32__SystemVoid(){} // RVA: 0x89F3C80
        public void __set_useGeometry__UnityEngineAINavMeshCollectGeometry__SystemVoid(){} // RVA: 0x89F3D60
        public void __set_voxelSize__SystemSingle__SystemVoid(){} // RVA: 0x89F3E40
        public void <.ctor>b__8_1(){} // RVA: 0x89F3F20
    }

    public class ExternUnityAINavigationNavMeshSurfaceArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89F7B80
        public void .ctor(){} // RVA: 0x89F7BC0
        public void GetExternFunctionParameterCount(){} // RVA: 0x89F7F90
        public void GetExternFunctionDelegate(){} // RVA: 0x89F80C0
        public void __Clone__SystemObject(){} // RVA: 0x89F81D0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x89F82C0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x89F83A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x89F8470
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x89F85C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x89F8660
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x89F8770
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x89F8890
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x89F89A0
        public void __GetType__SystemType(){} // RVA: 0x89F8AC0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x89F8BB0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x89F8C90
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x89F8DC0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x89F8F50
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x89F90A0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x89F91D0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x89F9300
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x89F9480
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x89F95D0
        public void __Get__SystemInt32__UnityAINavigationNavMeshSurface(){} // RVA: 0x89F9700
        public void __Initialize__SystemVoid(){} // RVA: 0x89F9850
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x89F98C0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x89F99F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x89F9B70
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x89F9CD0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x89F9E00
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x89F9F30
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x89FA0A0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x89FA1F0
        public void __Set__SystemInt32_UnityAINavigationNavMeshSurface__SystemVoid(){} // RVA: 0x89FA320
        public void __ToString__SystemString(){} // RVA: 0x89FA4F0
        public void __ctor__SystemInt32__UnityAINavigationNavMeshSurfaceArray(){} // RVA: 0x89FA5F0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x89FA6F0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x89FA790
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x89FA830
        public void __get_Length__SystemInt32(){} // RVA: 0x89FA8D0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x89FA970
        public void __get_Rank__SystemInt32(){} // RVA: 0x89FAA10
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x89FAAB0
        public void <.ctor>b__6_1(){} // RVA: 0x89FAB90
    }

    public class ExternUnityEngineAINavMesh : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x89FCAB0
        public void .ctor(){} // RVA: 0x89FCAF0
        public void GetExternFunctionParameterCount(){} // RVA: 0x89FCEC0
        public void GetExternFunctionDelegate(){} // RVA: 0x89FCFF0
        public void __AddLink__UnityEngineAINavMeshLinkData_UnityEngineVector3_UnityEngineQuaternion__UnityEngineAINavMeshLinkInstance(){} // RVA: 0x89FD100
        public void __AddLink__UnityEngineAINavMeshLinkData__UnityEngineAINavMeshLinkInstance(){} // RVA: 0x89FD2F0
        public void __AddNavMeshData__UnityEngineAINavMeshData_UnityEngineVector3_UnityEngineQuaternion__UnityEngineAINavMeshDataInstance(){} // RVA: 0x89FD4D0
        public void __AddNavMeshData__UnityEngineAINavMeshData__UnityEngineAINavMeshDataInstance(){} // RVA: 0x89FD650
        public void __CalculatePath__UnityEngineVector3_UnityEngineVector3_SystemInt32_UnityEngineAINavMeshPath__SystemBoolean(){} // RVA: 0x89FD8B0
        public void __CalculatePath__UnityEngineVector3_UnityEngineVector3_UnityEngineAINavMeshQueryFilter_UnityEngineAINavMeshPath__SystemBoolean(){} // RVA: 0x89FDAB0
        public void __CalculateTriangulation__UnityEngineAINavMeshTriangulation(){} // RVA: 0x89FDD80
        public void __CreateSettings__UnityEngineAINavMeshBuildSettings(){} // RVA: 0x89FDE50
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x89FDF50
        public void __FindClosestEdge__UnityEngineVector3_UnityEngineAINavMeshHitRef_SystemInt32__SystemBoolean(){} // RVA: 0x89FE0A0
        public void __FindClosestEdge__UnityEngineVector3_UnityEngineAINavMeshHitRef_UnityEngineAINavMeshQueryFilter__SystemBoolean(){} // RVA: 0x89FE280
        public void __GetAreaCost__SystemInt32__SystemSingle(){} // RVA: 0x89FE460
        public void __GetAreaFromName__SystemString__SystemInt32(){} // RVA: 0x89FE550
        public void __GetAreaNames__SystemStringArray(){} // RVA: 0x89FE5F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x89FE690
        public void __GetLinkOwner__UnityEngineAINavMeshLinkInstance__UnityEngineObject(){} // RVA: 0x89FE7A0
        public void __GetSettingsByID__SystemInt32__UnityEngineAINavMeshBuildSettings(){} // RVA: 0x89FE950
        public void __GetSettingsByIndex__SystemInt32__UnityEngineAINavMeshBuildSettings(){} // RVA: 0x89FEA90
        public void __GetSettingsCount__SystemInt32(){} // RVA: 0x89FEBD0
        public void __GetSettingsNameFromID__SystemInt32__SystemString(){} // RVA: 0x89FEC80
        public void __GetType__SystemType(){} // RVA: 0x89FED20
        public void __IsLinkActive__UnityEngineAINavMeshLinkInstance__SystemBoolean(){} // RVA: 0x89FEE10
        public void __IsLinkOccupied__UnityEngineAINavMeshLinkInstance__SystemBoolean(){} // RVA: 0x89FEEF0
        public void __IsLinkValid__UnityEngineAINavMeshLinkInstance__SystemBoolean(){} // RVA: 0x89FEFD0
        public void __Raycast__UnityEngineVector3_UnityEngineVector3_UnityEngineAINavMeshHitRef_SystemInt32__SystemBoolean(){} // RVA: 0x89FF0B0
        public void __Raycast__UnityEngineVector3_UnityEngineVector3_UnityEngineAINavMeshHitRef_UnityEngineAINavMeshQueryFilter__SystemBoolean(){} // RVA: 0x89FF2F0
        public void __RemoveAllNavMeshData__SystemVoid(){} // RVA: 0x7AE6C00
        public void __RemoveLink__UnityEngineAINavMeshLinkInstance__SystemVoid(){} // RVA: 0x89FF520
        public void __RemoveNavMeshData__UnityEngineAINavMeshDataInstance__SystemVoid(){} // RVA: 0x89FF5D0
        public void __RemoveSettings__SystemInt32__SystemVoid(){} // RVA: 0x89FF680
        public void __SamplePosition__UnityEngineVector3_UnityEngineAINavMeshHitRef_SystemSingle_SystemInt32__SystemBoolean(){} // RVA: 0x89FF730
        public void __SamplePosition__UnityEngineVector3_UnityEngineAINavMeshHitRef_SystemSingle_UnityEngineAINavMeshQueryFilter__SystemBoolean(){} // RVA: 0x89FF960
        public void __SetAreaCost__SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x89FFB90
        public void __SetLinkActive__UnityEngineAINavMeshLinkInstance_SystemBoolean__SystemVoid(){} // RVA: 0x89FFC90
        public void __SetLinkOwner__UnityEngineAINavMeshLinkInstance_UnityEngineObject__SystemVoid(){} // RVA: 0x89FFD80
        public void __ToString__SystemString(){} // RVA: 0x89FFED0
        public void __get_AllAreas__SystemInt32(){} // RVA: 0x89FFFD0
        public void __get_avoidancePredictionTime__SystemSingle(){} // RVA: 0x8A00040
        public void __set_avoidancePredictionTime__SystemSingle__SystemVoid(){} // RVA: 0x8A000F0
        public void <.ctor>b__6_1(){} // RVA: 0x8A001B0
    }

    public class ExternUnityEngineAINavMeshAgent : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A020D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x8A02110
        public void .ctor(){} // RVA: 0x8A02190
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A02560
        public void GetExternFunctionDelegate(){} // RVA: 0x8A02690
        public void __ActivateCurrentOffMeshLink__SystemBoolean__SystemVoid(){} // RVA: 0x8A027A0
        public void __CalculatePath__UnityEngineVector3_UnityEngineAINavMeshPath__SystemBoolean(){} // RVA: 0x8A02910
        public void __CompleteOffMeshLink__SystemVoid(){} // RVA: 0x8A02B50
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A02C80
        public void __FindClosestEdge__UnityEngineAINavMeshHitRef__SystemBoolean(){} // RVA: 0x8A02E60
        public void __GetAreaCost__SystemInt32__SystemSingle(){} // RVA: 0x8A03050
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8A031F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8A032E0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8A03570
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x8A036F0
        public void __GetComponentInChildren__T(){} // RVA: 0x8A03830
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x8A03920
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8A03B70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8A03C60
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8A03EF0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x8A04070
        public void __GetComponentInParent__T(){} // RVA: 0x8A041B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x8A042A0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x8A044F0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x8A04620
        public void __GetComponent__T(){} // RVA: 0x8A04760
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x8A04840
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8A04A70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8A04B60
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8A04E70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8A04F60
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8A05290
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8A05380
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8A05670
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x8A05810
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x8A05960
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x8A05A50
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8A05D00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8A05DF0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8A06120
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8A06210
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8A06500
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x8A066A0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x8A067F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x8A068E0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x8A06B90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x8A06C80
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x8A06F50
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x8A070A0
        public void __GetComponents__TArray(){} // RVA: 0x8A071F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x8A072E0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A075A0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x8A07710
        public void __GetType__SystemType(){} // RVA: 0x8A07870
        public void __Move__UnityEngineVector3__SystemVoid(){} // RVA: 0x8A07960
        public void __Raycast__UnityEngineVector3_UnityEngineAINavMeshHitRef__SystemBoolean(){} // RVA: 0x8A07AF0
        public void __ResetPath__SystemVoid(){} // RVA: 0x8A07D40
        public void __SamplePathPosition__SystemInt32_SystemSingle_UnityEngineAINavMeshHitRef__SystemBoolean(){} // RVA: 0x8A07E70
        public void __SetAreaCost__SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x8A080E0
        public void __SetDestination__UnityEngineVector3__SystemBoolean(){} // RVA: 0x8A08290
        public void __SetPath__UnityEngineAINavMeshPath__SystemBoolean(){} // RVA: 0x8A08460
        public void __ToString__SystemString(){} // RVA: 0x8A08580
        public void __Warp__UnityEngineVector3__SystemBoolean(){} // RVA: 0x8A086F0
        public void __get_acceleration__SystemSingle(){} // RVA: 0x8A088C0
        public void __get_agentTypeID__SystemInt32(){} // RVA: 0x8A08A30
        public void __get_angularSpeed__SystemSingle(){} // RVA: 0x8A08BA0
        public void __get_areaMask__SystemInt32(){} // RVA: 0x8A08D10
        public void __get_autoBraking__SystemBoolean(){} // RVA: 0x8A08E80
        public void __get_autoRepath__SystemBoolean(){} // RVA: 0x8A08FF0
        public void __get_autoTraverseOffMeshLink__SystemBoolean(){} // RVA: 0x8A09160
        public void __get_avoidancePriority__SystemInt32(){} // RVA: 0x8A092D0
        public void __get_baseOffset__SystemSingle(){} // RVA: 0x8A09440
        public void __get_currentOffMeshLinkData__UnityEngineAIOffMeshLinkData(){} // RVA: 0x8A095B0
        public void __get_desiredVelocity__UnityEngineVector3(){} // RVA: 0x8A09770
        public void __get_destination__UnityEngineVector3(){} // RVA: 0x8A09910
        public void __get_enabled__SystemBoolean(){} // RVA: 0x8A09AB0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x8A09C20
        public void __get_hasPath__SystemBoolean(){} // RVA: 0x8A09D30
        public void __get_height__SystemSingle(){} // RVA: 0x8A09EA0
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x8A0A010
        public void __get_isOnNavMesh__SystemBoolean(){} // RVA: 0x8A0A180
        public void __get_isOnOffMeshLink__SystemBoolean(){} // RVA: 0x8A0A2F0
        public void __get_isPathStale__SystemBoolean(){} // RVA: 0x8A0A460
        public void __get_isStopped__SystemBoolean(){} // RVA: 0x8A0A5D0
        public void __get_name__SystemString(){} // RVA: 0x8A0A740
        public void __get_navMeshOwner__UnityEngineObject(){} // RVA: 0x8A0A8A0
        public void __get_nextOffMeshLinkData__UnityEngineAIOffMeshLinkData(){} // RVA: 0x8A0AAC0
        public void __get_nextPosition__UnityEngineVector3(){} // RVA: 0x8A0AC80
        public void __get_obstacleAvoidanceType__UnityEngineAIObstacleAvoidanceType(){} // RVA: 0x8A0AE20
        public void __get_pathEndPosition__UnityEngineVector3(){} // RVA: 0x8A0AF90
        public void __get_pathPending__SystemBoolean(){} // RVA: 0x8A0B130
        public void __get_pathStatus__UnityEngineAINavMeshPathStatus(){} // RVA: 0x8A0B2A0
        public void __get_path__UnityEngineAINavMeshPath(){} // RVA: 0x8A0B410
        public void __get_radius__SystemSingle(){} // RVA: 0x8A0B620
        public void __get_remainingDistance__SystemSingle(){} // RVA: 0x8A0B790
        public void __get_speed__SystemSingle(){} // RVA: 0x8A0B900
        public void __get_steeringTarget__UnityEngineVector3(){} // RVA: 0x8A0BA70
        public void __get_stoppingDistance__SystemSingle(){} // RVA: 0x8A0BC10
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x8A0BD80
        public void __get_updatePosition__SystemBoolean(){} // RVA: 0x8A0BE90
        public void __get_updateRotation__SystemBoolean(){} // RVA: 0x8A0C000
        public void __get_updateUpAxis__SystemBoolean(){} // RVA: 0x8A0C170
        public void __get_velocity__UnityEngineVector3(){} // RVA: 0x8A0C2E0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8A0C480
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x8A0C780
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8A0C980
        public void __set_acceleration__SystemSingle__SystemVoid(){} // RVA: 0x8A0CC60
        public void __set_agentTypeID__SystemInt32__SystemVoid(){} // RVA: 0x8A0CDD0
        public void __set_angularSpeed__SystemSingle__SystemVoid(){} // RVA: 0x8A0CF40
        public void __set_areaMask__SystemInt32__SystemVoid(){} // RVA: 0x8A0D0B0
        public void __set_autoBraking__SystemBoolean__SystemVoid(){} // RVA: 0x8A0D1A0
        public void __set_autoRepath__SystemBoolean__SystemVoid(){} // RVA: 0x8A0D310
        public void __set_autoTraverseOffMeshLink__SystemBoolean__SystemVoid(){} // RVA: 0x8A0D480
        public void __set_avoidancePriority__SystemInt32__SystemVoid(){} // RVA: 0x8A0D5F0
        public void __set_baseOffset__SystemSingle__SystemVoid(){} // RVA: 0x8A0D760
        public void __set_destination__UnityEngineVector3__SystemVoid(){} // RVA: 0x8A0D8D0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x8A0DA60
        public void __set_height__SystemSingle__SystemVoid(){} // RVA: 0x8A0DB50
        public void __set_isStopped__SystemBoolean__SystemVoid(){} // RVA: 0x8A0DCC0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x8A0DE30
        public void __set_nextPosition__UnityEngineVector3__SystemVoid(){} // RVA: 0x8A0DF90
        public void __set_obstacleAvoidanceType__UnityEngineAIObstacleAvoidanceType__SystemVoid(){} // RVA: 0x8A0E120
        public void __set_path__UnityEngineAINavMeshPath__SystemVoid(){} // RVA: 0x8A0E290
        public void __set_radius__SystemSingle__SystemVoid(){} // RVA: 0x8A0E3C0
        public void __set_speed__SystemSingle__SystemVoid(){} // RVA: 0x8A0E530
        public void __set_stoppingDistance__SystemSingle__SystemVoid(){} // RVA: 0x8A0E6A0
        public void __set_updatePosition__SystemBoolean__SystemVoid(){} // RVA: 0x8A0E810
        public void __set_updateRotation__SystemBoolean__SystemVoid(){} // RVA: 0x8A0E900
        public void __set_updateUpAxis__SystemBoolean__SystemVoid(){} // RVA: 0x8A0E9F0
        public void __set_velocity__UnityEngineVector3__SystemVoid(){} // RVA: 0x8A0EB60
        public void <.ctor>b__8_1(){} // RVA: 0x8A0ECF0
    }

    public class ExternUnityEngineAINavMeshAgentArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A14210
        public void .ctor(){} // RVA: 0x8A14250
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A14620
        public void GetExternFunctionDelegate(){} // RVA: 0x8A14750
        public void __Clone__SystemObject(){} // RVA: 0x8A14860
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8A14950
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8A14A30
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A14B00
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8A14C50
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A14CF0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8A14E00
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8A14F20
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8A15030
        public void __GetType__SystemType(){} // RVA: 0x8A15150
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8A15240
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8A15320
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A15450
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A155E0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8A15730
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8A15860
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A15990
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A15B10
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8A15C60
        public void __Get__SystemInt32__UnityEngineAINavMeshAgent(){} // RVA: 0x8A15D90
        public void __Initialize__SystemVoid(){} // RVA: 0x8A15EE0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8A15F50
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A16080
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A16200
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8A16360
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8A16490
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A165C0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A16730
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8A16880
        public void __Set__SystemInt32_UnityEngineAINavMeshAgent__SystemVoid(){} // RVA: 0x8A169B0
        public void __ToString__SystemString(){} // RVA: 0x8A16B50
        public void __ctor__SystemInt32__UnityEngineAINavMeshAgentArray(){} // RVA: 0x8A16C50
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8A16D50
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8A16DF0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8A16E90
        public void __get_Length__SystemInt32(){} // RVA: 0x8A16F30
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8A16FD0
        public void __get_Rank__SystemInt32(){} // RVA: 0x8A17070
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8A17110
        public void <.ctor>b__6_1(){} // RVA: 0x8A171F0
    }

    public class ExternUnityEngineAINavMeshBuildSettings : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A19110
        public void .ctor(){} // RVA: 0x8A19150
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A19520
        public void GetExternFunctionDelegate(){} // RVA: 0x8A19650
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A19760
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A198A0
        public void __GetType__SystemType(){} // RVA: 0x8A19950
        public void __ToString__SystemString(){} // RVA: 0x8A19A40
        public void __ValidationReport__UnityEngineBounds__SystemStringArray(){} // RVA: 0x8A19AF0
        public void __get_agentClimb__SystemSingle(){} // RVA: 0x8A19C80
        public void __get_agentHeight__SystemSingle(){} // RVA: 0x8A19D20
        public void __get_agentRadius__SystemSingle(){} // RVA: 0x8A19DC0
        public void __get_agentSlope__SystemSingle(){} // RVA: 0x8A19E60
        public void __get_agentTypeID__SystemInt32(){} // RVA: 0x8A19F00
        public void __get_buildHeightMesh__SystemBoolean(){} // RVA: 0x8A19FB0
        public void __get_debug__UnityEngineAINavMeshBuildDebugSettings(){} // RVA: 0x8A1A060
        public void __get_ledgeDropHeight__SystemSingle(){} // RVA: 0x8A1A200
        public void __get_maxJumpAcrossDistance__SystemSingle(){} // RVA: 0x8A1A2A0
        public void __get_minRegionArea__SystemSingle(){} // RVA: 0x8A1A340
        public void __get_overrideTileSize__SystemBoolean(){} // RVA: 0x8A1A3E0
        public void __get_overrideVoxelSize__SystemBoolean(){} // RVA: 0x8A1A490
        public void __get_preserveTilesOutsideBounds__SystemBoolean(){} // RVA: 0x8A1A540
        public void __get_tileSize__SystemInt32(){} // RVA: 0x8A1A5F0
        public void __get_voxelSize__SystemSingle(){} // RVA: 0x8A1A6A0
        public void __set_agentClimb__SystemSingle__SystemVoid(){} // RVA: 0x8A1A740
        public void __set_agentHeight__SystemSingle__SystemVoid(){} // RVA: 0x8A1A880
        public void __set_agentRadius__SystemSingle__SystemVoid(){} // RVA: 0x8A1A9C0
        public void __set_agentSlope__SystemSingle__SystemVoid(){} // RVA: 0x8A1AB00
        public void __set_agentTypeID__SystemInt32__SystemVoid(){} // RVA: 0x8A1AC40
        public void __set_buildHeightMesh__SystemBoolean__SystemVoid(){} // RVA: 0x8A1AD70
        public void __set_debug__UnityEngineAINavMeshBuildDebugSettings__SystemVoid(){} // RVA: 0x8A1AEA0
        public void __set_ledgeDropHeight__SystemSingle__SystemVoid(){} // RVA: 0x8A1B0C0
        public void __set_maxJumpAcrossDistance__SystemSingle__SystemVoid(){} // RVA: 0x8A1B200
        public void __set_minRegionArea__SystemSingle__SystemVoid(){} // RVA: 0x8A1B340
        public void __set_overrideTileSize__SystemBoolean__SystemVoid(){} // RVA: 0x8A1B480
        public void __set_overrideVoxelSize__SystemBoolean__SystemVoid(){} // RVA: 0x8A1B5B0
        public void __set_preserveTilesOutsideBounds__SystemBoolean__SystemVoid(){} // RVA: 0x8A1B6E0
        public void __set_tileSize__SystemInt32__SystemVoid(){} // RVA: 0x8A1B810
        public void __set_voxelSize__SystemSingle__SystemVoid(){} // RVA: 0x8A1B940
        public void <.ctor>b__6_1(){} // RVA: 0x8A1BA80
    }

    public class ExternUnityEngineAINavMeshBuildSettingsArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A1D6A0
        public void .ctor(){} // RVA: 0x8A1D6E0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A1DAB0
        public void GetExternFunctionDelegate(){} // RVA: 0x8A1DBE0
        public void __Clone__SystemObject(){} // RVA: 0x8A1DCF0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8A1DDE0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8A1DEC0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A1DF90
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8A1E0E0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A1E180
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8A1E290
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8A1E3B0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8A1E4C0
        public void __GetType__SystemType(){} // RVA: 0x8A1E5E0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8A1E6D0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8A1E7B0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A1E8E0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A1EA70
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8A1EBC0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8A1ECF0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A1EE20
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A1EFA0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8A1F0F0
        public void __Get__SystemInt32__UnityEngineAINavMeshBuildSettings(){} // RVA: 0x8A1F220
        public void __Initialize__SystemVoid(){} // RVA: 0x8A1F330
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8A1F3A0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A1F4D0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A1F650
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8A1F7B0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8A1F8E0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A1FA10
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A1FB80
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8A1FCD0
        public void __Set__SystemInt32_UnityEngineAINavMeshBuildSettings__SystemVoid(){} // RVA: 0x8A1FE00
        public void __ToString__SystemString(){} // RVA: 0x8A1FF20
        public void __ctor__SystemInt32__UnityEngineAINavMeshBuildSettingsArray(){} // RVA: 0x8A20020
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8A201C0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8A20260
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8A20300
        public void __get_Length__SystemInt32(){} // RVA: 0x8A203A0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8A20440
        public void __get_Rank__SystemInt32(){} // RVA: 0x8A204E0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8A20580
        public void <.ctor>b__6_1(){} // RVA: 0x8A20660
    }

    public class ExternUnityEngineAINavMeshCollectGeometry : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A22580
        public void .ctor(){} // RVA: 0x8A225C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A22990
        public void GetExternFunctionDelegate(){} // RVA: 0x8A22AC0
        public void __CompareTo__SystemObject__SystemInt32(){} // RVA: 0x8A22BD0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A22D00
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A22E40
        public void __GetType__SystemType(){} // RVA: 0x8A22EF0
        public void __HasFlag__SystemEnum__SystemBoolean(){} // RVA: 0x8A22FE0
        public void __ToString__SystemString(){} // RVA: 0x8A230B0
        public void __ToString__SystemString__SystemString(){} // RVA: 0x8A23160
        public void __get_PhysicsColliders__UnityEngineAINavMeshCollectGeometry(){} // RVA: 0x8A23230
        public void __get_RenderMeshes__UnityEngineAINavMeshCollectGeometry(){} // RVA: 0x8A232A0
        public void <.ctor>b__6_1(){} // RVA: 0x8A23310
    }

    public class ExternUnityEngineAINavMeshData : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A23BB0
        public void .ctor(){} // RVA: 0x8A23BF0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A23FC0
        public void GetExternFunctionDelegate(){} // RVA: 0x8A240F0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A24200
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A243E0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x8A24550
        public void __GetType__SystemType(){} // RVA: 0x8A246B0
        public void __ToString__SystemString(){} // RVA: 0x8A247A0
        public void __get_name__SystemString(){} // RVA: 0x8A24910
        public void __get_position__UnityEngineVector3(){} // RVA: 0x8A24A70
        public void __get_rotation__UnityEngineQuaternion(){} // RVA: 0x8A24C10
        public void __get_sourceBounds__UnityEngineBounds(){} // RVA: 0x8A24D90
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8A24F30
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x8A25230
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8A25430
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x8A25710
        public void __set_position__UnityEngineVector3__SystemVoid(){} // RVA: 0x8A25870
        public void __set_rotation__UnityEngineQuaternion__SystemVoid(){} // RVA: 0x8A25A00
        public void <.ctor>b__6_1(){} // RVA: 0x8A25B80
    }

    public class ExternUnityEngineAINavMeshDataArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A268A0
        public void .ctor(){} // RVA: 0x8A268E0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A26CB0
        public void GetExternFunctionDelegate(){} // RVA: 0x8A26DE0
        public void __Clone__SystemObject(){} // RVA: 0x8A26EF0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8A26FE0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8A270C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A27190
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8A272E0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A27380
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8A27490
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8A275B0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8A276C0
        public void __GetType__SystemType(){} // RVA: 0x8A277E0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8A278D0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8A279B0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A27AE0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A27C70
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8A27DC0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8A27EF0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A28020
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A281A0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8A282F0
        public void __Get__SystemInt32__UnityEngineAINavMeshData(){} // RVA: 0x8A28420
        public void __Initialize__SystemVoid(){} // RVA: 0x8A28570
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8A285E0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A28710
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A28890
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8A289F0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8A28B20
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A28C50
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A28DC0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8A28F10
        public void __Set__SystemInt32_UnityEngineAINavMeshData__SystemVoid(){} // RVA: 0x8A29040
        public void __ToString__SystemString(){} // RVA: 0x8A291E0
        public void __ctor__SystemInt32__UnityEngineAINavMeshDataArray(){} // RVA: 0x8A292E0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8A294A0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8A29540
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8A295E0
        public void __get_Length__SystemInt32(){} // RVA: 0x8A29680
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8A29720
        public void __get_Rank__SystemInt32(){} // RVA: 0x8A297C0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8A29860
        public void <.ctor>b__6_1(){} // RVA: 0x8A29940
    }

    public class ExternUnityEngineAINavMeshDataInstance : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A2B860
        public void .ctor(){} // RVA: 0x8A2B8A0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A2BC70
        public void GetExternFunctionDelegate(){} // RVA: 0x8A2BDA0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A2BEB0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A2BFF0
        public void __GetType__SystemType(){} // RVA: 0x8A2C0A0
        public void __Remove__SystemVoid(){} // RVA: 0x8A2C190
        public void __ToString__SystemString(){} // RVA: 0x8A2C240
        public void __get_owner__UnityEngineObject(){} // RVA: 0x8A2C2F0
        public void __get_valid__SystemBoolean(){} // RVA: 0x8A2C4A0
        public void __set_owner__UnityEngineObject__SystemVoid(){} // RVA: 0x8A2C590
        public void <.ctor>b__6_1(){} // RVA: 0x8A2C720
    }

    public class ExternUnityEngineAINavMeshDataInstanceArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A2CF00
        public void .ctor(){} // RVA: 0x8A2CF40
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A2D310
        public void GetExternFunctionDelegate(){} // RVA: 0x8A2D440
        public void __Clone__SystemObject(){} // RVA: 0x8A2D550
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8A2D640
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8A2D720
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A2D7F0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8A2D940
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A2D9E0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8A2DAF0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8A2DC10
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8A2DD20
        public void __GetType__SystemType(){} // RVA: 0x8A2DE40
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8A2DF30
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8A2E010
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A2E140
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A2E2D0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8A2E420
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8A2E550
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A2E680
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A2E800
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8A2E950
        public void __Get__SystemInt32__UnityEngineAINavMeshDataInstance(){} // RVA: 0x8A2EA80
        public void __Initialize__SystemVoid(){} // RVA: 0x8A2EB60
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8A2EBD0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A2ED00
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A2EE80
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8A2EFE0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8A2F110
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A2F240
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A2F3B0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8A2F500
        public void __Set__SystemInt32_UnityEngineAINavMeshDataInstance__SystemVoid(){} // RVA: 0x8A2F630
        public void __ToString__SystemString(){} // RVA: 0x8A2F710
        public void __ctor__SystemInt32__UnityEngineAINavMeshDataInstanceArray(){} // RVA: 0x8A2F810
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8A2F9B0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8A2FA50
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8A2FAF0
        public void __get_Length__SystemInt32(){} // RVA: 0x8A2FB90
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8A2FC30
        public void __get_Rank__SystemInt32(){} // RVA: 0x8A2FCD0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8A2FD70
        public void <.ctor>b__6_1(){} // RVA: 0x8A2FE50
    }

    public class ExternUnityEngineAINavMeshHit : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A31D70
        public void .ctor(){} // RVA: 0x8A31DB0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A32180
        public void GetExternFunctionDelegate(){} // RVA: 0x8A322B0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A323C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A32500
        public void __GetType__SystemType(){} // RVA: 0x8A325B0
        public void __ToString__SystemString(){} // RVA: 0x8A326A0
        public void __get_distance__SystemSingle(){} // RVA: 0x8A32750
        public void __get_hit__SystemBoolean(){} // RVA: 0x8A327F0
        public void __get_mask__SystemInt32(){} // RVA: 0x8A32890
        public void __get_normal__UnityEngineVector3(){} // RVA: 0x8A32940
        public void __get_position__UnityEngineVector3(){} // RVA: 0x8A32A10
        public void __set_distance__SystemSingle__SystemVoid(){} // RVA: 0x8A32AD0
        public void __set_hit__SystemBoolean__SystemVoid(){} // RVA: 0x8A32BF0
        public void __set_mask__SystemInt32__SystemVoid(){} // RVA: 0x8A32CF0
        public void __set_normal__UnityEngineVector3__SystemVoid(){} // RVA: 0x8A32E00
        public void __set_position__UnityEngineVector3__SystemVoid(){} // RVA: 0x8A32F30
        public void <.ctor>b__6_1(){} // RVA: 0x8A33050
    }

    public class ExternUnityEngineAINavMeshHitArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A33CB0
        public void .ctor(){} // RVA: 0x8A33CF0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A340C0
        public void GetExternFunctionDelegate(){} // RVA: 0x8A341F0
        public void __Clone__SystemObject(){} // RVA: 0x8A34300
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8A343F0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8A344D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A345A0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8A346F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A34790
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8A348A0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8A349C0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8A34AD0
        public void __GetType__SystemType(){} // RVA: 0x8A34BF0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8A34CE0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8A34DC0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A34EF0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A35080
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8A351D0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8A35300
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A35430
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A355B0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8A35700
        public void __Get__SystemInt32__UnityEngineAINavMeshHit(){} // RVA: 0x8A35830
        public void __Initialize__SystemVoid(){} // RVA: 0x8A35930
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8A359A0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A35AD0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A35C50
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8A35DB0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8A35EE0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A36010
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A36180
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8A362D0
        public void __Set__SystemInt32_UnityEngineAINavMeshHit__SystemVoid(){} // RVA: 0x8A36400
        public void __ToString__SystemString(){} // RVA: 0x8A36510
        public void __ctor__SystemInt32__UnityEngineAINavMeshHitArray(){} // RVA: 0x8A36610
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8A367B0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8A36850
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8A368F0
        public void __get_Length__SystemInt32(){} // RVA: 0x8A36990
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8A36A30
        public void __get_Rank__SystemInt32(){} // RVA: 0x8A36AD0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8A36B70
        public void <.ctor>b__6_1(){} // RVA: 0x8A36C50
    }

    public class ExternUnityEngineAINavMeshLinkData : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A38B70
        public void .ctor(){} // RVA: 0x8A38BB0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A38F80
        public void GetExternFunctionDelegate(){} // RVA: 0x8A390B0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A391C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A39300
        public void __GetType__SystemType(){} // RVA: 0x8A393B0
        public void __ToString__SystemString(){} // RVA: 0x8A394A0
        public void __get_agentTypeID__SystemInt32(){} // RVA: 0x8A39550
        public void __get_area__SystemInt32(){} // RVA: 0x8A395F0
        public void __get_bidirectional__SystemBoolean(){} // RVA: 0x8A396A0
        public void __get_costModifier__SystemSingle(){} // RVA: 0x8A39750
        public void __get_endPosition__UnityEngineVector3(){} // RVA: 0x8A397F0
        public void __get_startPosition__UnityEngineVector3(){} // RVA: 0x8A398C0
        public void __get_width__SystemSingle(){} // RVA: 0x8A39980
        public void __set_agentTypeID__SystemInt32__SystemVoid(){} // RVA: 0x8A39A30
        public void __set_area__SystemInt32__SystemVoid(){} // RVA: 0x8A39B50
        public void __set_bidirectional__SystemBoolean__SystemVoid(){} // RVA: 0x8A39C80
        public void __set_costModifier__SystemSingle__SystemVoid(){} // RVA: 0x8A39DB0
        public void __set_endPosition__UnityEngineVector3__SystemVoid(){} // RVA: 0x8A39EF0
        public void __set_startPosition__UnityEngineVector3__SystemVoid(){} // RVA: 0x8A3A040
        public void __set_width__SystemSingle__SystemVoid(){} // RVA: 0x8A3A190
        public void <.ctor>b__6_1(){} // RVA: 0x8A3A2D0
    }

    public class ExternUnityEngineAINavMeshLinkDataArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A3B230
        public void .ctor(){} // RVA: 0x8A3B270
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A3B640
        public void GetExternFunctionDelegate(){} // RVA: 0x8A3B770
        public void __Clone__SystemObject(){} // RVA: 0x8A3B880
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8A3B970
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8A3BA50
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A3BB20
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8A3BC70
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A3BD10
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8A3BE20
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8A3BF40
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8A3C050
        public void __GetType__SystemType(){} // RVA: 0x8A3C170
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8A3C260
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8A3C340
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A3C470
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A3C600
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8A3C750
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8A3C880
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A3C9B0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A3CB30
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8A3CC80
        public void __Get__SystemInt32__UnityEngineAINavMeshLinkData(){} // RVA: 0x8A3CDB0
        public void __Initialize__SystemVoid(){} // RVA: 0x8A3CEC0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8A3CF30
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A3D060
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A3D1E0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8A3D340
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8A3D470
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A3D5A0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A3D710
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8A3D860
        public void __Set__SystemInt32_UnityEngineAINavMeshLinkData__SystemVoid(){} // RVA: 0x8A3D990
        public void __ToString__SystemString(){} // RVA: 0x8A3DAA0
        public void __ctor__SystemInt32__UnityEngineAINavMeshLinkDataArray(){} // RVA: 0x8A3DBA0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8A3DD40
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8A3DDE0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8A3DE80
        public void __get_Length__SystemInt32(){} // RVA: 0x8A3DF20
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8A3DFC0
        public void __get_Rank__SystemInt32(){} // RVA: 0x8A3E060
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8A3E100
        public void <.ctor>b__6_1(){} // RVA: 0x8A3E1E0
    }

    public class ExternUnityEngineAINavMeshLinkInstance : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A40100
        public void .ctor(){} // RVA: 0x8A40140
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A40510
        public void GetExternFunctionDelegate(){} // RVA: 0x8A40640
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A40750
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A40890
        public void __GetType__SystemType(){} // RVA: 0x8A40940
        public void __ToString__SystemString(){} // RVA: 0x8A40A30
        public void <.ctor>b__6_1(){} // RVA: 0x8A40AE0
    }

    public class ExternUnityEngineAINavMeshLinkInstanceArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A40FB0
        public void .ctor(){} // RVA: 0x8A40FF0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A413C0
        public void GetExternFunctionDelegate(){} // RVA: 0x8A414F0
        public void __Clone__SystemObject(){} // RVA: 0x8A41600
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8A416F0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8A417D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A418A0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8A419F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A41A90
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8A41BA0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8A41CC0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8A41DD0
        public void __GetType__SystemType(){} // RVA: 0x8A41EF0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8A41FE0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8A420C0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A421F0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A42380
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8A424D0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8A42600
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A42730
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A428B0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8A42A00
        public void __Get__SystemInt32__UnityEngineAINavMeshLinkInstance(){} // RVA: 0x8A42B30
        public void __Initialize__SystemVoid(){} // RVA: 0x8A42C10
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8A42C80
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A42DB0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A42F30
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8A43090
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8A431C0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A432F0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A43460
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8A435B0
        public void __Set__SystemInt32_UnityEngineAINavMeshLinkInstance__SystemVoid(){} // RVA: 0x8A436E0
        public void __ToString__SystemString(){} // RVA: 0x8A437C0
        public void __ctor__SystemInt32__UnityEngineAINavMeshLinkInstanceArray(){} // RVA: 0x8A438C0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8A43A60
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8A43B00
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8A43BA0
        public void __get_Length__SystemInt32(){} // RVA: 0x8A43C40
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8A43CE0
        public void __get_Rank__SystemInt32(){} // RVA: 0x8A43D80
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8A43E20
        public void <.ctor>b__6_1(){} // RVA: 0x8A43F00
    }

    public class ExternUnityEngineAINavMeshObstacle : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A45E20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x8A45E60
        public void .ctor(){} // RVA: 0x8A45EE0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A462B0
        public void GetExternFunctionDelegate(){} // RVA: 0x8A463E0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A464F0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8A466D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8A467C0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8A46A50
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x8A46BD0
        public void __GetComponentInChildren__T(){} // RVA: 0x8A46D10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x8A46E00
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8A47050
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8A47140
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8A473D0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x8A47550
        public void __GetComponentInParent__T(){} // RVA: 0x8A47690
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x8A47780
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x8A479D0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x8A47B00
        public void __GetComponent__T(){} // RVA: 0x8A47C40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x8A47D20
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8A47F50
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8A48040
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8A48350
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8A48440
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8A48770
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8A48860
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8A48B50
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x8A48CF0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x8A48E40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x8A48F30
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8A491E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8A492D0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8A49600
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8A496F0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8A499E0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x8A49B80
        public void __GetComponentsInParent__TArray(){} // RVA: 0x8A49CD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x8A49DC0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x8A4A070
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x8A4A160
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x8A4A430
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x8A4A580
        public void __GetComponents__TArray(){} // RVA: 0x8A4A6D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x8A4A7C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A4AA80
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x8A4ABF0
        public void __GetType__SystemType(){} // RVA: 0x8A4AD50
        public void __ToString__SystemString(){} // RVA: 0x8A4AE40
        public void __get_carveOnlyStationary__SystemBoolean(){} // RVA: 0x8A4AFB0
        public void __get_carvingMoveThreshold__SystemSingle(){} // RVA: 0x8A4B120
        public void __get_carvingTimeToStationary__SystemSingle(){} // RVA: 0x8A4B290
        public void __get_carving__SystemBoolean(){} // RVA: 0x8A4B400
        public void __get_center__UnityEngineVector3(){} // RVA: 0x8A4B570
        public void __get_enabled__SystemBoolean(){} // RVA: 0x8A4B710
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x8A4B880
        public void __get_height__SystemSingle(){} // RVA: 0x8A4B990
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x8A4BB00
        public void __get_name__SystemString(){} // RVA: 0x8A4BC70
        public void __get_radius__SystemSingle(){} // RVA: 0x8A4BDD0
        public void __get_shape__UnityEngineAINavMeshObstacleShape(){} // RVA: 0x8A4BF40
        public void __get_size__UnityEngineVector3(){} // RVA: 0x8A4C0B0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x8A4C250
        public void __get_velocity__UnityEngineVector3(){} // RVA: 0x8A4C360
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8A4C500
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x8A4C800
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8A4CA00
        public void __set_carveOnlyStationary__SystemBoolean__SystemVoid(){} // RVA: 0x8A4CCE0
        public void __set_carvingMoveThreshold__SystemSingle__SystemVoid(){} // RVA: 0x8A4CE50
        public void __set_carvingTimeToStationary__SystemSingle__SystemVoid(){} // RVA: 0x8A4CFC0
        public void __set_carving__SystemBoolean__SystemVoid(){} // RVA: 0x8A4D130
        public void __set_center__UnityEngineVector3__SystemVoid(){} // RVA: 0x8A4D2A0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x8A4D430
        public void __set_height__SystemSingle__SystemVoid(){} // RVA: 0x8A4D520
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x8A4D690
        public void __set_radius__SystemSingle__SystemVoid(){} // RVA: 0x8A4D7F0
        public void __set_shape__UnityEngineAINavMeshObstacleShape__SystemVoid(){} // RVA: 0x8A4D960
        public void __set_size__UnityEngineVector3__SystemVoid(){} // RVA: 0x8A4DAD0
        public void __set_velocity__UnityEngineVector3__SystemVoid(){} // RVA: 0x8A4DC60
        public void <.ctor>b__8_1(){} // RVA: 0x8A4DDF0
    }

    public class ExternUnityEngineAINavMeshObstacleArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A50D80
        public void .ctor(){} // RVA: 0x8A50DC0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A51190
        public void GetExternFunctionDelegate(){} // RVA: 0x8A512C0
        public void __Clone__SystemObject(){} // RVA: 0x8A513D0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8A514C0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8A515A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A51670
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8A517C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A51860
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8A51970
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8A51A90
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8A51BA0
        public void __GetType__SystemType(){} // RVA: 0x8A51CC0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8A51DB0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8A51E90
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A51FC0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A52150
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8A522A0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8A523D0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A52500
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A52680
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8A527D0
        public void __Get__SystemInt32__UnityEngineAINavMeshObstacle(){} // RVA: 0x8A52900
        public void __Initialize__SystemVoid(){} // RVA: 0x8A52A50
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8A52AC0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A52BF0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A52D70
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8A52ED0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8A53000
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A53130
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A532A0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8A533F0
        public void __Set__SystemInt32_UnityEngineAINavMeshObstacle__SystemVoid(){} // RVA: 0x8A53520
        public void __ToString__SystemString(){} // RVA: 0x8A536C0
        public void __ctor__SystemInt32__UnityEngineAINavMeshObstacleArray(){} // RVA: 0x8A537C0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8A538C0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8A53960
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8A53A00
        public void __get_Length__SystemInt32(){} // RVA: 0x8A53AA0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8A53B40
        public void __get_Rank__SystemInt32(){} // RVA: 0x8A53BE0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8A53C80
        public void <.ctor>b__6_1(){} // RVA: 0x8A53D60
    }

    public class ExternUnityEngineAINavMeshPath : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A55C80
        public void .ctor(){} // RVA: 0x8A55CC0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A56090
        public void GetExternFunctionDelegate(){} // RVA: 0x8A561C0
        public void __ClearCorners__SystemVoid(){} // RVA: 0x8A562D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A56340
        public void __GetCornersNonAlloc__UnityEngineVector3Array__SystemInt32(){} // RVA: 0x8A56490
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A56570
        public void __GetType__SystemType(){} // RVA: 0x8A56680
        public void __ToString__SystemString(){} // RVA: 0x8A56770
        public void __ctor____UnityEngineAINavMeshPath(){} // RVA: 0x8A56870
        public void __get_corners__UnityEngineVector3Array(){} // RVA: 0x8A56940
        public void __get_status__UnityEngineAINavMeshPathStatus(){} // RVA: 0x8A569E0
        public void <.ctor>b__6_1(){} // RVA: 0x8A56AE0
    }

    public class ExternUnityEngineAINavMeshPathArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A57380
        public void .ctor(){} // RVA: 0x8A573C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A57790
        public void GetExternFunctionDelegate(){} // RVA: 0x8A578C0
        public void __Clone__SystemObject(){} // RVA: 0x8A579D0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8A57AC0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8A57BA0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A57C70
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8A57DC0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A57E60
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8A57F70
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8A58090
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8A581A0
        public void __GetType__SystemType(){} // RVA: 0x8A582C0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8A583B0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8A58490
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A585C0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A58750
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8A588A0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8A589D0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A58B00
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A58C80
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8A58DD0
        public void __Get__SystemInt32__UnityEngineAINavMeshPath(){} // RVA: 0x8A58F00
        public void __Initialize__SystemVoid(){} // RVA: 0x8A58FE0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8A59050
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A59180
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A59300
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8A59460
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8A59590
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A596C0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A59830
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8A59980
        public void __Set__SystemInt32_UnityEngineAINavMeshPath__SystemVoid(){} // RVA: 0x8A59AB0
        public void __ToString__SystemString(){} // RVA: 0x8A59BF0
        public void __ctor__SystemInt32__UnityEngineAINavMeshPathArray(){} // RVA: 0x8A59CF0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8A59E90
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8A59F30
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8A59FD0
        public void __get_Length__SystemInt32(){} // RVA: 0x8A5A070
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8A5A110
        public void __get_Rank__SystemInt32(){} // RVA: 0x8A5A1B0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8A5A250
        public void <.ctor>b__6_1(){} // RVA: 0x8A5A330
    }

    public class ExternUnityEngineAINavMeshQueryFilter : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A86D20
        public void .ctor(){} // RVA: 0x8A86D60
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A87130
        public void GetExternFunctionDelegate(){} // RVA: 0x8A87260
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A87370
        public void __GetAreaCost__SystemInt32__SystemSingle(){} // RVA: 0x8A874B0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A87590
        public void __GetType__SystemType(){} // RVA: 0x8A87640
        public void __SetAreaCost__SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x8A87730
        public void __ToString__SystemString(){} // RVA: 0x8A87820
        public void __get_agentTypeID__SystemInt32(){} // RVA: 0x8A878D0
        public void __get_areaMask__SystemInt32(){} // RVA: 0x8A87970
        public void __set_agentTypeID__SystemInt32__SystemVoid(){} // RVA: 0x8A87A10
        public void __set_areaMask__SystemInt32__SystemVoid(){} // RVA: 0x8A87AF0
        public void <.ctor>b__6_1(){} // RVA: 0x8A87BD0
    }

    public class ExternUnityEngineAINavMeshQueryFilterArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A88530
        public void .ctor(){} // RVA: 0x8A88570
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A88940
        public void GetExternFunctionDelegate(){} // RVA: 0x8A88A70
        public void __Clone__SystemObject(){} // RVA: 0x8A88B80
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8A88C70
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8A88D50
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A88E20
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8A88F70
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A89010
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8A89120
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8A89240
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8A89350
        public void __GetType__SystemType(){} // RVA: 0x8A89470
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8A89560
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8A89640
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A89770
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A89900
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8A89A50
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8A89B80
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A89CB0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A89E30
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8A89F80
        public void __Get__SystemInt32__UnityEngineAINavMeshQueryFilter(){} // RVA: 0x8A8A0B0
        public void __Initialize__SystemVoid(){} // RVA: 0x8A8A1A0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8A8A210
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A8A340
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A8A4C0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8A8A620
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8A8A750
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A8A880
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A8A9F0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8A8AB40
        public void __Set__SystemInt32_UnityEngineAINavMeshQueryFilter__SystemVoid(){} // RVA: 0x8A8AC70
        public void __ToString__SystemString(){} // RVA: 0x8A8ADD0
        public void __ctor__SystemInt32__UnityEngineAINavMeshQueryFilterArray(){} // RVA: 0x8A8AED0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8A8B070
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8A8B110
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8A8B1B0
        public void __get_Length__SystemInt32(){} // RVA: 0x8A8B250
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8A8B2F0
        public void __get_Rank__SystemInt32(){} // RVA: 0x8A8B390
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8A8B430
        public void <.ctor>b__6_1(){} // RVA: 0x8A8B510
    }

    public class ExternUnityEngineAINavMeshTriangulation : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A8D430
        public void .ctor(){} // RVA: 0x8A8D470
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A8D840
        public void GetExternFunctionDelegate(){} // RVA: 0x8A8D970
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A8DA80
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A8DBC0
        public void __GetType__SystemType(){} // RVA: 0x8A8DC70
        public void __ToString__SystemString(){} // RVA: 0x8A8DD60
        public void __get_areas__SystemInt32Array(){} // RVA: 0x8A8DE10
        public void __set_areas__SystemInt32Array(){} // RVA: 0x8A8DF20
        public void __get_indices__SystemInt32Array(){} // RVA: 0x8A8E070
        public void __set_indices__SystemInt32Array(){} // RVA: 0x8A8E170
        public void __get_vertices__UnityEngineVector3Array(){} // RVA: 0x8A8E2C0
        public void __set_vertices__UnityEngineVector3Array(){} // RVA: 0x8A8E3B0
        public void <.ctor>b__6_1(){} // RVA: 0x8A8E500
    }

    public class ExternUnityEngineAINavMeshTriangulationArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A8EE60
        public void .ctor(){} // RVA: 0x8A8EEA0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A8F270
        public void GetExternFunctionDelegate(){} // RVA: 0x8A8F3A0
        public void __Clone__SystemObject(){} // RVA: 0x8A8F4B0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8A8F5A0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8A8F680
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A8F750
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8A8F8A0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A8F940
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8A8FA50
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8A8FB70
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8A8FC80
        public void __GetType__SystemType(){} // RVA: 0x8A8FDA0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8A8FE90
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8A8FF70
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A900A0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A90230
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8A90380
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8A904B0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A905E0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A90760
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8A908B0
        public void __Get__SystemInt32__UnityEngineAINavMeshTriangulation(){} // RVA: 0x8A909E0
        public void __Initialize__SystemVoid(){} // RVA: 0x8A90AE0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8A90B50
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A90C80
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A90E00
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8A90F60
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8A91090
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A911C0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A91330
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8A91480
        public void __Set__SystemInt32_UnityEngineAINavMeshTriangulation__SystemVoid(){} // RVA: 0x8A915B0
        public void __ToString__SystemString(){} // RVA: 0x8A91720
        public void __ctor__SystemInt32__UnityEngineAINavMeshTriangulationArray(){} // RVA: 0x8A91820
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8A919C0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8A91A60
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8A91B00
        public void __get_Length__SystemInt32(){} // RVA: 0x8A91BA0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8A91C40
        public void __get_Rank__SystemInt32(){} // RVA: 0x8A91CE0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8A91D80
        public void <.ctor>b__6_1(){} // RVA: 0x8A91E60
    }

    public class ExternUnityEngineAIOffMeshLink : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A93D80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x8A93DC0
        public void .ctor(){} // RVA: 0x8A93E40
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A94210
        public void GetExternFunctionDelegate(){} // RVA: 0x8A94340
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A94450
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8A94630
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8A94720
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8A949B0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x8A94B30
        public void __GetComponentInChildren__T(){} // RVA: 0x8A94C70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x8A94D60
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8A94FB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8A950A0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8A95330
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x8A954B0
        public void __GetComponentInParent__T(){} // RVA: 0x8A955F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x8A956E0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x8A95930
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x8A95A60
        public void __GetComponent__T(){} // RVA: 0x8A95BA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x8A95C80
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8A95EB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8A95FA0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8A962B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8A963A0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8A966D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8A967C0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8A96AB0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x8A96C50
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x8A96DA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x8A96E90
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8A97140
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8A97230
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8A97560
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8A97650
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8A97940
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x8A97AE0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x8A97C30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x8A97D20
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x8A97FD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x8A980C0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x8A98390
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x8A984E0
        public void __GetComponents__TArray(){} // RVA: 0x8A98630
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x8A98720
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A989E0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x8A98B50
        public void __GetType__SystemType(){} // RVA: 0x8A98CB0
        public void __ToString__SystemString(){} // RVA: 0x8A98DA0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x8A98F10
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x8A99080
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x8A99190
        public void __get_name__SystemString(){} // RVA: 0x8A99300
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x8A99460
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8A99570
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x8A99870
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8A99A70
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x8A99D50
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x8A99E40
        public void <.ctor>b__8_1(){} // RVA: 0x8A99FA0
    }

    public class ExternUnityEngineAIOffMeshLinkArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8A9C040
        public void .ctor(){} // RVA: 0x8A9C080
        public void GetExternFunctionParameterCount(){} // RVA: 0x8A9C450
        public void GetExternFunctionDelegate(){} // RVA: 0x8A9C580
        public void __Clone__SystemObject(){} // RVA: 0x8A9C690
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8A9C780
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8A9C860
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8A9C930
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8A9CA80
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8A9CB20
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8A9CC30
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8A9CD50
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8A9CE60
        public void __GetType__SystemType(){} // RVA: 0x8A9CF80
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8A9D070
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8A9D150
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A9D280
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8A9D410
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8A9D560
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8A9D690
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A9D7C0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8A9D940
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8A9DA90
        public void __Get__SystemInt32__UnityEngineAIOffMeshLink(){} // RVA: 0x8A9DBC0
        public void __Initialize__SystemVoid(){} // RVA: 0x8A9DD10
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8A9DD80
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A9DEB0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8A9E030
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8A9E190
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8A9E2C0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A9E3F0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8A9E560
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8A9E6B0
        public void __Set__SystemInt32_UnityEngineAIOffMeshLink__SystemVoid(){} // RVA: 0x8A9E7E0
        public void __ToString__SystemString(){} // RVA: 0x8A9EA50
        public void __ctor__SystemInt32__UnityEngineAIOffMeshLinkArray(){} // RVA: 0x8A9EB50
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8A9EC50
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8A9ECF0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8A9ED90
        public void __get_Length__SystemInt32(){} // RVA: 0x8A9EE30
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8A9EED0
        public void __get_Rank__SystemInt32(){} // RVA: 0x8A9EF70
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8A9F010
        public void <.ctor>b__6_1(){} // RVA: 0x8A9F0F0
    }

    public class ExternUnityEngineAIOffMeshLinkData : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8AA1010
        public void .ctor(){} // RVA: 0x8AA1050
        public void GetExternFunctionParameterCount(){} // RVA: 0x8AA1420
        public void GetExternFunctionDelegate(){} // RVA: 0x8AA1550
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8AA1660
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8AA17A0
        public void __GetType__SystemType(){} // RVA: 0x8AA1850
        public void __ToString__SystemString(){} // RVA: 0x8AA1940
        public void __get_activated__SystemBoolean(){} // RVA: 0x8AA19F0
        public void __get_endPos__UnityEngineVector3(){} // RVA: 0x8AA1AA0
        public void __get_linkType__UnityEngineAIOffMeshLinkType(){} // RVA: 0x8AA1B70
        public void __get_owner__UnityEngineObject(){} // RVA: 0x8AA1C20
        public void __get_startPos__UnityEngineVector3(){} // RVA: 0x8AA1E00
        public void __get_valid__SystemBoolean(){} // RVA: 0x8AA1EC0
        public void <.ctor>b__6_1(){} // RVA: 0x8AA1F70
    }

    public class ExternUnityEngineAIOffMeshLinkDataArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8AA28D0
        public void .ctor(){} // RVA: 0x8AA2910
        public void GetExternFunctionParameterCount(){} // RVA: 0x8AA2CE0
        public void GetExternFunctionDelegate(){} // RVA: 0x8AA2E10
        public void __Clone__SystemObject(){} // RVA: 0x8AA2F20
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8AA3010
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8AA30F0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8AA31C0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8AA3310
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8AA33B0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8AA34C0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8AA35E0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8AA36F0
        public void __GetType__SystemType(){} // RVA: 0x8AA3810
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8AA3900
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8AA39E0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8AA3B10
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8AA3CA0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8AA3DF0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8AA3F20
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8AA4050
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8AA41D0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8AA4320
        public void __Get__SystemInt32__UnityEngineAIOffMeshLinkData(){} // RVA: 0x8AA4450
        public void __Initialize__SystemVoid(){} // RVA: 0x8AA4550
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8AA45C0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8AA46F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8AA4870
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8AA49D0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8AA4B00
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8AA4C30
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8AA4DA0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8AA4EF0
        public void __Set__SystemInt32_UnityEngineAIOffMeshLinkData__SystemVoid(){} // RVA: 0x8AA5020
        public void __ToString__SystemString(){} // RVA: 0x8AA5130
        public void __ctor__SystemInt32__UnityEngineAIOffMeshLinkDataArray(){} // RVA: 0x8AA5230
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8AA53D0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8AA5470
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8AA5510
        public void __get_Length__SystemInt32(){} // RVA: 0x8AA55B0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8AA5650
        public void __get_Rank__SystemInt32(){} // RVA: 0x8AA56F0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8AA5790
        public void <.ctor>b__6_1(){} // RVA: 0x8AA5870
    }

    public class ExternUnityEngineAnimationClip : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8AA7790
        public void .ctor(){} // RVA: 0x8AA77D0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8AA7BA0
        public void GetExternFunctionDelegate(){} // RVA: 0x8AA7CD0
        public void __ClearCurves__SystemVoid(){} // RVA: 0x8AA7DE0
        public void __EnsureQuaternionContinuity__SystemVoid(){} // RVA: 0x8AA7F10
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8AA8040
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8AA8220
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x8AA8390
        public void __GetType__SystemType(){} // RVA: 0x8AA84F0
        public void __SampleAnimation__UnityEngineGameObject_SystemSingle__SystemVoid(){} // RVA: 0x8AA85E0
        public void __SetCurve__SystemString_SystemType_SystemString_UnityEngineAnimationCurve__SystemVoid(){} // RVA: 0x8AA8730
        public void __ToString__SystemString(){} // RVA: 0x8AA88A0
        public void __get_apparentSpeed__SystemSingle(){} // RVA: 0x8AA8A10
        public void __get_averageAngularSpeed__SystemSingle(){} // RVA: 0x8AA8B80
        public void __get_averageDuration__SystemSingle(){} // RVA: 0x8AA8CF0
        public void __get_averageSpeed__UnityEngineVector3(){} // RVA: 0x8AA8E60
        public void __get_empty__SystemBoolean(){} // RVA: 0x8AA9000
        public void __get_frameRate__SystemSingle(){} // RVA: 0x8AA9170
        public void __get_hasGenericRootTransform__SystemBoolean(){} // RVA: 0x8AA92E0
        public void __get_hasMotionCurves__SystemBoolean(){} // RVA: 0x8AA9450
        public void __get_hasMotionFloatCurves__SystemBoolean(){} // RVA: 0x8AA95C0
        public void __get_hasRootCurves__SystemBoolean(){} // RVA: 0x8AA9730
        public void __get_humanMotion__SystemBoolean(){} // RVA: 0x8AA98A0
        public void __get_isHumanMotion__SystemBoolean(){} // RVA: 0x8AA9A10
        public void __get_isLooping__SystemBoolean(){} // RVA: 0x8AA9B80
        public void __get_length__SystemSingle(){} // RVA: 0x8AA9CF0
        public void __get_localBounds__UnityEngineBounds(){} // RVA: 0x8AA9E60
        public void __get_name__SystemString(){} // RVA: 0x8AAA000
        public void __get_wrapMode__UnityEngineWrapMode(){} // RVA: 0x8AAA160
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8AAA2D0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x8AAA5D0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8AAA7D0
        public void __set_frameRate__SystemSingle__SystemVoid(){} // RVA: 0x8AAAAB0
        public void __set_localBounds__UnityEngineBounds__SystemVoid(){} // RVA: 0x8AAABA0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x8AAAD20
        public void __set_wrapMode__UnityEngineWrapMode__SystemVoid(){} // RVA: 0x8AAAE80
        public void <.ctor>b__6_1(){} // RVA: 0x8AAAFF0
    }

    public class ExternUnityEngineAnimationClipArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8AACA90
        public void .ctor(){} // RVA: 0x8AACAD0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8AACEA0
        public void GetExternFunctionDelegate(){} // RVA: 0x8AACFD0
        public void __Clone__SystemObject(){} // RVA: 0x8AAD0E0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8AAD1D0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8AAD2B0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8AAD380
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8AAD4D0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8AAD570
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8AAD680
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8AAD7A0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8AAD8B0
        public void __GetType__SystemType(){} // RVA: 0x8AAD9D0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8AADAC0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8AADBA0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8AADCD0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8AADE60
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8AADFB0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8AAE0E0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8AAE210
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8AAE390
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8AAE4E0
        public void __Get__SystemInt32__UnityEngineAnimationClip(){} // RVA: 0x8AAE610
        public void __Initialize__SystemVoid(){} // RVA: 0x8AAE760
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8AAE7D0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8AAE900
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8AAEA80
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8AAEBE0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8AAED10
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8AAEE40
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8AAEFB0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8AAF100
        public void __Set__SystemInt32_UnityEngineAnimationClip__SystemVoid(){} // RVA: 0x8AAF230
        public void __ToString__SystemString(){} // RVA: 0x8AAF3D0
        public void __ctor__SystemInt32__UnityEngineAnimationClipArray(){} // RVA: 0x8AAF4D0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8AAF5D0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8AAF670
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8AAF710
        public void __get_Length__SystemInt32(){} // RVA: 0x8AAF7B0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8AAF850
        public void __get_Rank__SystemInt32(){} // RVA: 0x8AAF8F0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8AAF990
        public void <.ctor>b__6_1(){} // RVA: 0x8AAFA70
    }

    public class ExternUnityEngineAnimationCurve : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8AB1990
        public void .ctor(){} // RVA: 0x8AB19D0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8AB1DA0
        public void GetExternFunctionDelegate(){} // RVA: 0x8AB1ED0
        public void __AddKey__SystemSingle_SystemSingle__SystemInt32(){} // RVA: 0x8AB1FE0
        public void __AddKey__UnityEngineKeyframe__SystemInt32(){} // RVA: 0x8AB2170
        public void __ClearKeys__SystemVoid(){} // RVA: 0x8AB22E0
        public void __Constant__SystemSingle_SystemSingle_SystemSingle__UnityEngineAnimationCurve(){} // RVA: 0x8AB23A0
        public void __CopyFrom__UnityEngineAnimationCurve__SystemVoid(){} // RVA: 0x8AB24B0
        public void __EaseInOut__SystemSingle_SystemSingle_SystemSingle_SystemSingle__UnityEngineAnimationCurve(){} // RVA: 0x8AB25A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8AB26E0
        public void __Equals__UnityEngineAnimationCurve__SystemBoolean(){} // RVA: 0x8AB2820
        public void __Evaluate__SystemSingle__SystemSingle(){} // RVA: 0x8AB28F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8AB2A50
        public void __GetType__SystemType(){} // RVA: 0x8AB2B00
        public void __Linear__SystemSingle_SystemSingle_SystemSingle_SystemSingle__UnityEngineAnimationCurve(){} // RVA: 0x8AB2BF0
        public void __MoveKey__SystemInt32_UnityEngineKeyframe__SystemInt32(){} // RVA: 0x8AB2D30
        public void __RemoveKey__SystemInt32__SystemVoid(){} // RVA: 0x8AB2EF0
        public void __SmoothTangents__SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x8AB2FF0
        public void __ToString__SystemString(){} // RVA: 0x8AB3140
        public void __ctor__UnityEngineKeyframeArray__UnityEngineAnimationCurve(){} // RVA: 0x8AB3240
        public void __ctor____UnityEngineAnimationCurve(){} // RVA: 0x8AB3320
        public void __get_Item__SystemInt32__UnityEngineKeyframe(){} // RVA: 0x8AB33C0
        public void __get_keys__UnityEngineKeyframeArray(){} // RVA: 0x8AB3620
        public void __get_length__SystemInt32(){} // RVA: 0x8AB37B0
        public void __get_postWrapMode__UnityEngineWrapMode(){} // RVA: 0x8AB38B0
        public void __get_preWrapMode__UnityEngineWrapMode(){} // RVA: 0x8AB39B0
        public void __set_keys__UnityEngineKeyframeArray__SystemVoid(){} // RVA: 0x8AB3AB0
        public void __set_postWrapMode__UnityEngineWrapMode__SystemVoid(){} // RVA: 0x8AB3B60
        public void __set_preWrapMode__UnityEngineWrapMode__SystemVoid(){} // RVA: 0x8AB3C60
        public void <.ctor>b__6_1(){} // RVA: 0x8AB3D60
    }

    public class ExternUnityEngineAnimationCurveArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8AB52C0
        public void .ctor(){} // RVA: 0x8AB5300
        public void GetExternFunctionParameterCount(){} // RVA: 0x8AB56D0
        public void GetExternFunctionDelegate(){} // RVA: 0x8AB5800
        public void __Clone__SystemObject(){} // RVA: 0x8AB5910
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8AB5A00
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8AB5AE0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8AB5BB0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8AB5D00
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8AB5DA0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8AB5EB0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8AB5FD0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8AB60E0
        public void __GetType__SystemType(){} // RVA: 0x8AB6200
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8AB62F0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8AB63D0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8AB6500
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8AB6690
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8AB67E0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8AB6910
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8AB6A40
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8AB6BC0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8AB6D10
        public void __Get__SystemInt32__UnityEngineAnimationCurve(){} // RVA: 0x8AB6E40
        public void __Initialize__SystemVoid(){} // RVA: 0x8AB6F20
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8AB6F90
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8AB70C0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8AB7240
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8AB73A0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8AB74D0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8AB7600
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8AB7770
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8AB78C0
        public void __Set__SystemInt32_UnityEngineAnimationCurve__SystemVoid(){} // RVA: 0x8AB79F0
        public void __ToString__SystemString(){} // RVA: 0x8AB7B10
        public void __ctor__SystemInt32__UnityEngineAnimationCurveArray(){} // RVA: 0x8AB7C10
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8AB7DB0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8AB7E50
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8AB7EF0
        public void __get_Length__SystemInt32(){} // RVA: 0x8AB7F90
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8AB8030
        public void __get_Rank__SystemInt32(){} // RVA: 0x8AB80D0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8AB8170
        public void <.ctor>b__6_1(){} // RVA: 0x8AB8250
    }

    public class ExternUnityEngineAnimationState : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8B22900
        public void .ctor(){} // RVA: 0x8B22940
        public void GetExternFunctionParameterCount(){} // RVA: 0x8B22D10
        public void GetExternFunctionDelegate(){} // RVA: 0x8B22E40
        public void __AddMixingTransform__UnityEngineTransform_SystemBoolean__SystemVoid(){} // RVA: 0x8B22F50
        public void __AddMixingTransform__UnityEngineTransform__SystemVoid(){} // RVA: 0x8B23080
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8B23170
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8B232B0
        public void __GetType__SystemType(){} // RVA: 0x8B23360
        public void __RemoveMixingTransform__UnityEngineTransform__SystemVoid(){} // RVA: 0x8B23450
        public void __ToString__SystemString(){} // RVA: 0x8B23610
        public void __ctor____UnityEngineAnimationState(){} // RVA: 0x8B23710
        public void __get_blendMode__UnityEngineAnimationBlendMode(){} // RVA: 0x8B23790
        public void __get_clip__UnityEngineAnimationClip(){} // RVA: 0x8B23890
        public void __get_enabled__SystemBoolean(){} // RVA: 0x8B23970
        public void __get_layer__SystemInt32(){} // RVA: 0x8B23A70
        public void __get_length__SystemSingle(){} // RVA: 0x8B23B70
        public void __get_name__SystemString(){} // RVA: 0x8B23C70
        public void __get_normalizedSpeed__SystemSingle(){} // RVA: 0x8B23D10
        public void __get_normalizedTime__SystemSingle(){} // RVA: 0x8B23E10
        public void __get_speed__SystemSingle(){} // RVA: 0x8B23F10
        public void __get_time__SystemSingle(){} // RVA: 0x8B24010
        public void __get_weight__SystemSingle(){} // RVA: 0x8B24110
        public void __get_wrapMode__UnityEngineWrapMode(){} // RVA: 0x8B24210
        public void __op_Equality__UnityEngineTrackedReference_UnityEngineTrackedReference__SystemBoolean(){} // RVA: 0x8B24310
        public void __op_Implicit__UnityEngineTrackedReference__SystemBoolean(){} // RVA: 0x8B24400
        public void __op_Inequality__UnityEngineTrackedReference_UnityEngineTrackedReference__SystemBoolean(){} // RVA: 0x8B244A0
        public void __set_blendMode__UnityEngineAnimationBlendMode__SystemVoid(){} // RVA: 0x8B24580
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x8B24680
        public void __set_layer__SystemInt32__SystemVoid(){} // RVA: 0x8B24790
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x8B24890
        public void __set_normalizedSpeed__SystemSingle__SystemVoid(){} // RVA: 0x8B24940
        public void __set_normalizedTime__SystemSingle__SystemVoid(){} // RVA: 0x8B24A50
        public void __set_speed__SystemSingle__SystemVoid(){} // RVA: 0x8B24B60
        public void __set_time__SystemSingle__SystemVoid(){} // RVA: 0x8B24C70
        public void __set_weight__SystemSingle__SystemVoid(){} // RVA: 0x8B24D80
        public void __set_wrapMode__UnityEngineWrapMode__SystemVoid(){} // RVA: 0x8B24E90
        public void <.ctor>b__6_1(){} // RVA: 0x8B24F90
    }

    public class ExternUnityEngineAnimationStateArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8B26A30
        public void .ctor(){} // RVA: 0x8B26A70
        public void GetExternFunctionParameterCount(){} // RVA: 0x8B26E40
        public void GetExternFunctionDelegate(){} // RVA: 0x8B26F70
        public void __Clone__SystemObject(){} // RVA: 0x8B27080
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8B27170
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8B27250
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8B27320
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8B27470
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8B27510
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8B27620
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8B27740
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8B27850
        public void __GetType__SystemType(){} // RVA: 0x8B27970
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8B27A60
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8B27B40
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8B27C70
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8B27E00
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8B27F50
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8B28080
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8B281B0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8B28330
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8B28480
        public void __Get__SystemInt32__UnityEngineAnimationState(){} // RVA: 0x8B285B0
        public void __Initialize__SystemVoid(){} // RVA: 0x8B28690
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8B28700
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B28830
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B289B0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8B28B10
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8B28C40
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8B28D70
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8B28EE0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8B29030
        public void __Set__SystemInt32_UnityEngineAnimationState__SystemVoid(){} // RVA: 0x8B29160
        public void __ToString__SystemString(){} // RVA: 0x8B292A0
        public void __ctor__SystemInt32__UnityEngineAnimationStateArray(){} // RVA: 0x8B293A0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8B29540
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8B295E0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8B29680
        public void __get_Length__SystemInt32(){} // RVA: 0x8B29720
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8B297C0
        public void __get_Rank__SystemInt32(){} // RVA: 0x8B29860
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8B29900
        public void <.ctor>b__6_1(){} // RVA: 0x8B299E0
    }

    public class ExternUnityEngineAnimationsAimConstraint : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8ABA170
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x8ABA1B0
        public void .ctor(){} // RVA: 0x8ABA230
        public void GetExternFunctionParameterCount(){} // RVA: 0x8ABA600
        public void GetExternFunctionDelegate(){} // RVA: 0x8ABA730
        public void __AddSource__UnityEngineAnimationsConstraintSource__SystemInt32(){} // RVA: 0x8ABA840
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8ABAA00
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8ABABE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8ABACD0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8ABAF60
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x8ABB0E0
        public void __GetComponentInChildren__T(){} // RVA: 0x8ABB220
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x8ABB310
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8ABB560
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8ABB650
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8ABB8E0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x8ABBA60
        public void __GetComponentInParent__T(){} // RVA: 0x8ABBBA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x8ABBC90
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x8ABBEE0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x8ABC010
        public void __GetComponent__T(){} // RVA: 0x8ABC150
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x8ABC230
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8ABC460
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8ABC550
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8ABC860
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8ABC950
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8ABCC80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8ABCD70
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8ABD060
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x8ABD200
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x8ABD350
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x8ABD440
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8ABD6F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8ABD7E0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8ABDB10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8ABDC00
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8ABDEF0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x8ABE090
        public void __GetComponentsInParent__TArray(){} // RVA: 0x8ABE1E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x8ABE2D0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x8ABE580
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x8ABE670
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x8ABE940
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x8ABEA90
        public void __GetComponents__TArray(){} // RVA: 0x8ABEBE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x8ABECD0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8ABEF90
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x8ABF100
        public void __GetSource__SystemInt32__UnityEngineAnimationsConstraintSource(){} // RVA: 0x8ABF260
        public void __GetSources__SystemCollectionsGenericListUnityEngineAnimationsConstraintSource__SystemVoid(){} // RVA: 0x8ABF420
        public void __GetType__SystemType(){} // RVA: 0x8ABF5B0
        public void __RemoveSource__SystemInt32__SystemVoid(){} // RVA: 0x8ABF6A0
        public void __SetSource__SystemInt32_UnityEngineAnimationsConstraintSource__SystemVoid(){} // RVA: 0x8ABF820
        public void __SetSources__SystemCollectionsGenericListUnityEngineAnimationsConstraintSource__SystemVoid(){} // RVA: 0x8ABF9E0
        public void __ToString__SystemString(){} // RVA: 0x8ABFBB0
        public void __get_aimVector__UnityEngineVector3(){} // RVA: 0x8ABFD20
        public void __get_constraintActive__SystemBoolean(){} // RVA: 0x8ABFEC0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x8AC0030
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x8AC01A0
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x8AC02B0
        public void __get_locked__SystemBoolean(){} // RVA: 0x8AC0420
        public void __get_name__SystemString(){} // RVA: 0x8AC0590
        public void __get_rotationAtRest__UnityEngineVector3(){} // RVA: 0x8AC06F0
        public void __get_rotationAxis__UnityEngineAnimationsAxis(){} // RVA: 0x8AC0890
        public void __get_rotationOffset__UnityEngineVector3(){} // RVA: 0x8AC0A00
        public void __get_sourceCount__SystemInt32(){} // RVA: 0x8AC0BA0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x8AC0C90
        public void __get_upVector__UnityEngineVector3(){} // RVA: 0x8AC0DA0
        public void __get_weight__SystemSingle(){} // RVA: 0x8AC0F40
        public void __get_worldUpObject__UnityEngineTransform(){} // RVA: 0x8AC10B0
        public void __get_worldUpType__UnityEngineAnimationsAimConstraintWorldUpType(){} // RVA: 0x8AC11C0
        public void __get_worldUpVector__UnityEngineVector3(){} // RVA: 0x8AC1330
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8AC14D0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x8AC17D0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8AC19D0
        public void __set_aimVector__UnityEngineVector3__SystemVoid(){} // RVA: 0x8AC1CB0
        public void __set_constraintActive__SystemBoolean__SystemVoid(){} // RVA: 0x8AC1E40
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x8AC1FB0
        public void __set_locked__SystemBoolean__SystemVoid(){} // RVA: 0x8AC20A0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x8AC2210
        public void __set_rotationAtRest__UnityEngineVector3__SystemVoid(){} // RVA: 0x8AC2370
        public void __set_rotationAxis__UnityEngineAnimationsAxis__SystemVoid(){} // RVA: 0x8AC2500
        public void __set_rotationOffset__UnityEngineVector3__SystemVoid(){} // RVA: 0x8AC2670
        public void __set_upVector__UnityEngineVector3__SystemVoid(){} // RVA: 0x8AC2800
        public void __set_weight__SystemSingle__SystemVoid(){} // RVA: 0x8AC2990
        public void __set_worldUpObject__UnityEngineTransform__SystemVoid(){} // RVA: 0x8AC2B00
        public void __set_worldUpType__UnityEngineAnimationsAimConstraintWorldUpType__SystemVoid(){} // RVA: 0x8AC2CC0
        public void __set_worldUpVector__UnityEngineVector3__SystemVoid(){} // RVA: 0x8AC2E30
        public void <.ctor>b__8_1(){} // RVA: 0x8AC2FC0
    }

    public class ExternUnityEngineAnimationsAimConstraintArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8AC6610
        public void .ctor(){} // RVA: 0x8AC6650
        public void GetExternFunctionParameterCount(){} // RVA: 0x8AC6A20
        public void GetExternFunctionDelegate(){} // RVA: 0x8AC6B50
        public void __Clone__SystemObject(){} // RVA: 0x8AC6C60
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8AC6D50
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8AC6E30
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8AC6F00
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8AC7050
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8AC70F0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8AC7200
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8AC7320
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8AC7430
        public void __GetType__SystemType(){} // RVA: 0x8AC7550
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8AC7640
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8AC7720
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8AC7850
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8AC79E0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8AC7B30
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8AC7C60
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8AC7D90
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8AC7F10
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8AC8060
        public void __Get__SystemInt32__UnityEngineAnimationsAimConstraint(){} // RVA: 0x8AC8190
        public void __Initialize__SystemVoid(){} // RVA: 0x8AC82E0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8AC8350
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8AC8480
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8AC8600
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8AC8760
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8AC8890
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8AC89C0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8AC8B30
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8AC8C80
        public void __Set__SystemInt32_UnityEngineAnimationsAimConstraint__SystemVoid(){} // RVA: 0x8AC8DB0
        public void __ToString__SystemString(){} // RVA: 0x8AC8F50
        public void __ctor__SystemInt32__UnityEngineAnimationsAimConstraintArray(){} // RVA: 0x8AC9050
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8AC9150
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8AC91F0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8AC9290
        public void __get_Length__SystemInt32(){} // RVA: 0x8AC9330
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8AC93D0
        public void __get_Rank__SystemInt32(){} // RVA: 0x8AC9470
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8AC9510
        public void <.ctor>b__6_1(){} // RVA: 0x8AC95F0
    }

    public class ExternUnityEngineAnimationsConstraintSource : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8ACB510
        public void .ctor(){} // RVA: 0x8ACB550
        public void GetExternFunctionParameterCount(){} // RVA: 0x8ACB920
        public void GetExternFunctionDelegate(){} // RVA: 0x8ACBA50
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8ACBB60
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8ACBCA0
        public void __GetType__SystemType(){} // RVA: 0x8ACBD50
        public void __ToString__SystemString(){} // RVA: 0x8ACBE40
        public void __get_sourceTransform__UnityEngineTransform(){} // RVA: 0x8ACBEF0
        public void __get_weight__SystemSingle(){} // RVA: 0x8ACBFD0
        public void __set_sourceTransform__UnityEngineTransform__SystemVoid(){} // RVA: 0x8ACC070
        public void __set_weight__SystemSingle__SystemVoid(){} // RVA: 0x8ACC1F0
        public void <.ctor>b__6_1(){} // RVA: 0x8ACC2D0
    }

    public class ExternUnityEngineAnimationsConstraintSourceArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8ACCAB0
        public void .ctor(){} // RVA: 0x8ACCAF0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8ACCEC0
        public void GetExternFunctionDelegate(){} // RVA: 0x8ACCFF0
        public void __Clone__SystemObject(){} // RVA: 0x8ACD100
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8ACD1F0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8ACD2D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8ACD3A0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8ACD4F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8ACD590
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8ACD6A0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8ACD7C0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8ACD8D0
        public void __GetType__SystemType(){} // RVA: 0x8ACD9F0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8ACDAE0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8ACDBC0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8ACDCF0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8ACDE80
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8ACDFD0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8ACE100
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8ACE230
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8ACE3B0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8ACE500
        public void __Get__SystemInt32__UnityEngineAnimationsConstraintSource(){} // RVA: 0x8ACE630
        public void __Initialize__SystemVoid(){} // RVA: 0x8ACE720
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8ACE790
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8ACE8C0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8ACEA40
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8ACEBA0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8ACECD0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8ACEE00
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8ACEF70
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8ACF0C0
        public void __Set__SystemInt32_UnityEngineAnimationsConstraintSource__SystemVoid(){} // RVA: 0x8ACF1F0
        public void __ToString__SystemString(){} // RVA: 0x8ACF350
        public void __ctor__SystemInt32__UnityEngineAnimationsConstraintSourceArray(){} // RVA: 0x8ACF450
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8ACF5F0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8ACF690
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8ACF730
        public void __get_Length__SystemInt32(){} // RVA: 0x8ACF7D0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8ACF870
        public void __get_Rank__SystemInt32(){} // RVA: 0x8ACF910
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8ACF9B0
        public void <.ctor>b__6_1(){} // RVA: 0x8ACFA90
    }

    public class ExternUnityEngineAnimationsLookAtConstraint : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8AD19B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x8AD19F0
        public void .ctor(){} // RVA: 0x8AD1A70
        public void GetExternFunctionParameterCount(){} // RVA: 0x8AD1E40
        public void GetExternFunctionDelegate(){} // RVA: 0x8AD1F70
        public void __AddSource__UnityEngineAnimationsConstraintSource__SystemInt32(){} // RVA: 0x8AD2080
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8AD2240
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8AD2420
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8AD2510
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8AD27A0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x8AD2920
        public void __GetComponentInChildren__T(){} // RVA: 0x8AD2A60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x8AD2B50
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8AD2DA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8AD2E90
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8AD3120
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x8AD32A0
        public void __GetComponentInParent__T(){} // RVA: 0x8AD33E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x8AD34D0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x8AD3720
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x8AD3850
        public void __GetComponent__T(){} // RVA: 0x8AD3990
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x8AD3A70
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8AD3CA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8AD3D90
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8AD40A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8AD4190
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8AD44C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8AD45B0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8AD48A0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x8AD4A40
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x8AD4B90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x8AD4C80
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8AD4F30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8AD5020
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8AD5350
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8AD5440
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8AD5730
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x8AD58D0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x8AD5A20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x8AD5B10
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x8AD5DC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x8AD5EB0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x8AD6180
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x8AD62D0
        public void __GetComponents__TArray(){} // RVA: 0x8AD6420
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x8AD6510
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8AD67D0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x8AD6940
        public void __GetSource__SystemInt32__UnityEngineAnimationsConstraintSource(){} // RVA: 0x8AD6AA0
        public void __GetSources__SystemCollectionsGenericListUnityEngineAnimationsConstraintSource__SystemVoid(){} // RVA: 0x8AD6C60
        public void __GetType__SystemType(){} // RVA: 0x8AD6DF0
        public void __RemoveSource__SystemInt32__SystemVoid(){} // RVA: 0x8AD6EE0
        public void __SetSource__SystemInt32_UnityEngineAnimationsConstraintSource__SystemVoid(){} // RVA: 0x8AD7060
        public void __SetSources__SystemCollectionsGenericListUnityEngineAnimationsConstraintSource__SystemVoid(){} // RVA: 0x8AD7220
        public void __ToString__SystemString(){} // RVA: 0x8AD73F0
        public void __get_constraintActive__SystemBoolean(){} // RVA: 0x8AD7560
        public void __get_enabled__SystemBoolean(){} // RVA: 0x8AD76D0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x8AD7840
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x8AD7950
        public void __get_locked__SystemBoolean(){} // RVA: 0x8AD7AC0
        public void __get_name__SystemString(){} // RVA: 0x8AD7C30
        public void __get_roll__SystemSingle(){} // RVA: 0x8AD7D90
        public void __get_rotationAtRest__UnityEngineVector3(){} // RVA: 0x8AD7F00
        public void __get_rotationOffset__UnityEngineVector3(){} // RVA: 0x8AD80A0
        public void __get_sourceCount__SystemInt32(){} // RVA: 0x8AD8240
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x8AD8330
        public void __get_useUpObject__SystemBoolean(){} // RVA: 0x8AD8440
        public void __get_weight__SystemSingle(){} // RVA: 0x8AD85B0
        public void __get_worldUpObject__UnityEngineTransform(){} // RVA: 0x8AD8720
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8AD8830
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x8AD8B30
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8AD8D30
        public void __set_constraintActive__SystemBoolean__SystemVoid(){} // RVA: 0x8AD9010
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x8AD9180
        public void __set_locked__SystemBoolean__SystemVoid(){} // RVA: 0x8AD9270
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x8AD93E0
        public void __set_roll__SystemSingle__SystemVoid(){} // RVA: 0x8AD9540
        public void __set_rotationAtRest__UnityEngineVector3__SystemVoid(){} // RVA: 0x8AD96B0
        public void __set_rotationOffset__UnityEngineVector3__SystemVoid(){} // RVA: 0x8AD9840
        public void __set_useUpObject__SystemBoolean__SystemVoid(){} // RVA: 0x8AD99D0
        public void __set_weight__SystemSingle__SystemVoid(){} // RVA: 0x8AD9B40
        public void __set_worldUpObject__UnityEngineTransform__SystemVoid(){} // RVA: 0x8AD9CB0
        public void <.ctor>b__8_1(){} // RVA: 0x8AD9E70
    }

    public class ExternUnityEngineAnimationsLookAtConstraintArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8ADD050
        public void .ctor(){} // RVA: 0x8ADD090
        public void GetExternFunctionParameterCount(){} // RVA: 0x8ADD460
        public void GetExternFunctionDelegate(){} // RVA: 0x8ADD590
        public void __Clone__SystemObject(){} // RVA: 0x8ADD6A0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8ADD790
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8ADD870
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8ADD940
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8ADDA90
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8ADDB30
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8ADDC40
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8ADDD60
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8ADDE70
        public void __GetType__SystemType(){} // RVA: 0x8ADDF90
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8ADE080
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8ADE160
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8ADE290
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8ADE420
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8ADE570
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8ADE6A0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8ADE7D0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8ADE950
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8ADEAA0
        public void __Get__SystemInt32__UnityEngineAnimationsLookAtConstraint(){} // RVA: 0x8ADEBD0
        public void __Initialize__SystemVoid(){} // RVA: 0x8ADED20
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8ADED90
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8ADEEC0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8ADF040
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8ADF1A0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8ADF2D0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8ADF400
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8ADF570
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8ADF6C0
        public void __Set__SystemInt32_UnityEngineAnimationsLookAtConstraint__SystemVoid(){} // RVA: 0x8ADF7F0
        public void __ToString__SystemString(){} // RVA: 0x8ADF990
        public void __ctor__SystemInt32__UnityEngineAnimationsLookAtConstraintArray(){} // RVA: 0x8ADFA90
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8ADFB90
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8ADFC30
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8ADFCD0
        public void __get_Length__SystemInt32(){} // RVA: 0x8ADFD70
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8ADFE10
        public void __get_Rank__SystemInt32(){} // RVA: 0x8ADFEB0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8ADFF50
        public void <.ctor>b__6_1(){} // RVA: 0x8AE0030
    }

    public class ExternUnityEngineAnimationsParentConstraint : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8AE1F50
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x8AE1F90
        public void .ctor(){} // RVA: 0x8AE2010
        public void GetExternFunctionParameterCount(){} // RVA: 0x8AE23E0
        public void GetExternFunctionDelegate(){} // RVA: 0x8AE2510
        public void __AddSource__UnityEngineAnimationsConstraintSource__SystemInt32(){} // RVA: 0x8AE2620
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8AE27E0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8AE29C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8AE2AB0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8AE2D40
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x8AE2EC0
        public void __GetComponentInChildren__T(){} // RVA: 0x8AE3000
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x8AE30F0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8AE3340
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8AE3430
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8AE36C0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x8AE3840
        public void __GetComponentInParent__T(){} // RVA: 0x8AE3980
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x8AE3A70
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x8AE3CC0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x8AE3DF0
        public void __GetComponent__T(){} // RVA: 0x8AE3F30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x8AE4010
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8AE4240
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8AE4330
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8AE4640
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8AE4730
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8AE4A60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8AE4B50
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8AE4E40
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x8AE4FE0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x8AE5130
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x8AE5220
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8AE54D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8AE55C0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8AE58F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8AE59E0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8AE5CD0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x8AE5E70
        public void __GetComponentsInParent__TArray(){} // RVA: 0x8AE5FC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x8AE60B0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x8AE6360
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x8AE6450
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x8AE6720
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x8AE6870
        public void __GetComponents__TArray(){} // RVA: 0x8AE69C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x8AE6AB0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8AE6D70
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x8AE6EE0
        public void __GetRotationOffset__SystemInt32__UnityEngineVector3(){} // RVA: 0x8AE7040
        public void __GetSource__SystemInt32__UnityEngineAnimationsConstraintSource(){} // RVA: 0x8AE7180
        public void __GetSources__SystemCollectionsGenericListUnityEngineAnimationsConstraintSource__SystemVoid(){} // RVA: 0x8AE7340
        public void __GetTranslationOffset__SystemInt32__UnityEngineVector3(){} // RVA: 0x8AE74D0
        public void __GetType__SystemType(){} // RVA: 0x8AE7610
        public void __RemoveSource__SystemInt32__SystemVoid(){} // RVA: 0x8AE7700
        public void __SetRotationOffset__SystemInt32_UnityEngineVector3__SystemVoid(){} // RVA: 0x8AE7880
        public void __SetSource__SystemInt32_UnityEngineAnimationsConstraintSource__SystemVoid(){} // RVA: 0x8AE7A50
        public void __SetSources__SystemCollectionsGenericListUnityEngineAnimationsConstraintSource__SystemVoid(){} // RVA: 0x8AE7C10
        public void __SetTranslationOffset__SystemInt32_UnityEngineVector3__SystemVoid(){} // RVA: 0x8AE7DE0
        public void __ToString__SystemString(){} // RVA: 0x8AE7FB0
        public void __get_constraintActive__SystemBoolean(){} // RVA: 0x8AE8120
        public void __get_enabled__SystemBoolean(){} // RVA: 0x8AE8290
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x8AE8400
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x8AE8510
        public void __get_locked__SystemBoolean(){} // RVA: 0x8AE8680
        public void __get_name__SystemString(){} // RVA: 0x8AE87F0
        public void __get_rotationAtRest__UnityEngineVector3(){} // RVA: 0x8AE8950
        public void __get_rotationAxis__UnityEngineAnimationsAxis(){} // RVA: 0x8AE8AF0
        public void __get_rotationOffsets__UnityEngineVector3Array(){} // RVA: 0x8AE8C60
        public void __get_sourceCount__SystemInt32(){} // RVA: 0x8AE8D40
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x8AE8E30
        public void __get_translationAtRest__UnityEngineVector3(){} // RVA: 0x8AE8F40
        public void __get_translationAxis__UnityEngineAnimationsAxis(){} // RVA: 0x8AE90E0
        public void __get_translationOffsets__UnityEngineVector3Array(){} // RVA: 0x8AE9250
        public void __get_weight__SystemSingle(){} // RVA: 0x8AE9330
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8AE94A0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x8AE97A0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8AE99A0
        public void __set_constraintActive__SystemBoolean__SystemVoid(){} // RVA: 0x8AE9C80
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x8AE9DF0
        public void __set_locked__SystemBoolean__SystemVoid(){} // RVA: 0x8AE9EE0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x8AEA050
        public void __set_rotationAtRest__UnityEngineVector3__SystemVoid(){} // RVA: 0x8AEA1B0
        public void __set_rotationAxis__UnityEngineAnimationsAxis__SystemVoid(){} // RVA: 0x8AEA340
        public void __set_rotationOffsets__UnityEngineVector3Array__SystemVoid(){} // RVA: 0x8AEA4B0
        public void __set_translationAtRest__UnityEngineVector3__SystemVoid(){} // RVA: 0x8AEA690
        public void __set_translationAxis__UnityEngineAnimationsAxis__SystemVoid(){} // RVA: 0x8AEA820
        public void __set_translationOffsets__UnityEngineVector3Array__SystemVoid(){} // RVA: 0x8AEA990
        public void __set_weight__SystemSingle__SystemVoid(){} // RVA: 0x8AEAB70
        public void <.ctor>b__8_1(){} // RVA: 0x8AEACE0
    }

    public class ExternUnityEngineAnimationsParentConstraintArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8AEE330
        public void .ctor(){} // RVA: 0x8AEE370
        public void GetExternFunctionParameterCount(){} // RVA: 0x8AEE740
        public void GetExternFunctionDelegate(){} // RVA: 0x8AEE870
        public void __Clone__SystemObject(){} // RVA: 0x8AEE980
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8AEEA70
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8AEEB50
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8AEEC20
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8AEED70
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8AEEE10
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8AEEF20
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8AEF040
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8AEF150
        public void __GetType__SystemType(){} // RVA: 0x8AEF270
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8AEF360
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8AEF440
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8AEF570
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8AEF700
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8AEF850
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8AEF980
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8AEFAB0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8AEFC30
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8AEFD80
        public void __Get__SystemInt32__UnityEngineAnimationsParentConstraint(){} // RVA: 0x8AEFEB0
        public void __Initialize__SystemVoid(){} // RVA: 0x8AF0000
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8AF0070
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8AF01A0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8AF0320
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8AF0480
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8AF05B0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8AF06E0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8AF0850
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8AF09A0
        public void __Set__SystemInt32_UnityEngineAnimationsParentConstraint__SystemVoid(){} // RVA: 0x8AF0AD0
        public void __ToString__SystemString(){} // RVA: 0x8AF0C70
        public void __ctor__SystemInt32__UnityEngineAnimationsParentConstraintArray(){} // RVA: 0x8AF0D70
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8AF0E70
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8AF0F10
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8AF0FB0
        public void __get_Length__SystemInt32(){} // RVA: 0x8AF1050
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8AF10F0
        public void __get_Rank__SystemInt32(){} // RVA: 0x8AF1190
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8AF1230
        public void <.ctor>b__6_1(){} // RVA: 0x8AF1310
    }

    public class ExternUnityEngineAnimationsPositionConstraint : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8AF3230
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x8AF3270
        public void .ctor(){} // RVA: 0x8AF32F0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8AF36C0
        public void GetExternFunctionDelegate(){} // RVA: 0x8AF37F0
        public void __AddSource__UnityEngineAnimationsConstraintSource__SystemInt32(){} // RVA: 0x8AF3900
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8AF3AC0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8AF3CA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8AF3D90
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8AF4020
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x8AF41A0
        public void __GetComponentInChildren__T(){} // RVA: 0x8AF42E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x8AF43D0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8AF4620
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8AF4710
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8AF49A0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x8AF4B20
        public void __GetComponentInParent__T(){} // RVA: 0x8AF4C60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x8AF4D50
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x8AF4FA0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x8AF50D0
        public void __GetComponent__T(){} // RVA: 0x8AF5210
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x8AF52F0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8AF5520
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8AF5610
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8AF5920
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8AF5A10
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8AF5D40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8AF5E30
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8AF6120
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x8AF62C0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x8AF6410
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x8AF6500
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8AF67B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8AF68A0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8AF6BD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8AF6CC0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8AF6FB0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x8AF7150
        public void __GetComponentsInParent__TArray(){} // RVA: 0x8AF72A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x8AF7390
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x8AF7640
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x8AF7730
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x8AF7A00
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x8AF7B50
        public void __GetComponents__TArray(){} // RVA: 0x8AF7CA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x8AF7D90
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8AF8050
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x8AF81C0
        public void __GetSource__SystemInt32__UnityEngineAnimationsConstraintSource(){} // RVA: 0x8AF8320
        public void __GetSources__SystemCollectionsGenericListUnityEngineAnimationsConstraintSource__SystemVoid(){} // RVA: 0x8AF84E0
        public void __GetType__SystemType(){} // RVA: 0x8AF8670
        public void __RemoveSource__SystemInt32__SystemVoid(){} // RVA: 0x8AF8760
        public void __SetSource__SystemInt32_UnityEngineAnimationsConstraintSource__SystemVoid(){} // RVA: 0x8AF88E0
        public void __SetSources__SystemCollectionsGenericListUnityEngineAnimationsConstraintSource__SystemVoid(){} // RVA: 0x8AF8AA0
        public void __ToString__SystemString(){} // RVA: 0x8AF8C70
        public void __get_constraintActive__SystemBoolean(){} // RVA: 0x8AF8DE0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x8AF8F50
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x8AF90C0
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x8AF91D0
        public void __get_locked__SystemBoolean(){} // RVA: 0x8AF9340
        public void __get_name__SystemString(){} // RVA: 0x8AF94B0
        public void __get_sourceCount__SystemInt32(){} // RVA: 0x8AF9610
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x8AF9700
        public void __get_translationAtRest__UnityEngineVector3(){} // RVA: 0x8AF9810
        public void __get_translationAxis__UnityEngineAnimationsAxis(){} // RVA: 0x8AF99B0
        public void __get_translationOffset__UnityEngineVector3(){} // RVA: 0x8AF9B20
        public void __get_weight__SystemSingle(){} // RVA: 0x8AF9CC0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8AF9E30
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x8AFA130
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8AFA330
        public void __set_constraintActive__SystemBoolean__SystemVoid(){} // RVA: 0x8AFA610
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x8AFA780
        public void __set_locked__SystemBoolean__SystemVoid(){} // RVA: 0x8AFA870
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x8AFA9E0
        public void __set_translationAtRest__UnityEngineVector3__SystemVoid(){} // RVA: 0x8AFAB40
        public void __set_translationAxis__UnityEngineAnimationsAxis__SystemVoid(){} // RVA: 0x8AFACD0
        public void __set_translationOffset__UnityEngineVector3__SystemVoid(){} // RVA: 0x8AFAE40
        public void __set_weight__SystemSingle__SystemVoid(){} // RVA: 0x8AFAFD0
        public void <.ctor>b__8_1(){} // RVA: 0x8AFB140
    }

    public class ExternUnityEngineAnimationsPositionConstraintArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8AFE020
        public void .ctor(){} // RVA: 0x8AFE060
        public void GetExternFunctionParameterCount(){} // RVA: 0x8AFE430
        public void GetExternFunctionDelegate(){} // RVA: 0x8AFE560
        public void __Clone__SystemObject(){} // RVA: 0x8AFE670
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8AFE760
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8AFE840
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8AFE910
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8AFEA60
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8AFEB00
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8AFEC10
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8AFED30
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8AFEE40
        public void __GetType__SystemType(){} // RVA: 0x8AFEF60
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8AFF050
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8AFF130
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8AFF260
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8AFF3F0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8AFF540
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8AFF670
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8AFF7A0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8AFF920
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8AFFA70
        public void __Get__SystemInt32__UnityEngineAnimationsPositionConstraint(){} // RVA: 0x8AFFBA0
        public void __Initialize__SystemVoid(){} // RVA: 0x8AFFCF0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8AFFD60
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8AFFE90
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B00010
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8B00170
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8B002A0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8B003D0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8B00540
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8B00690
        public void __Set__SystemInt32_UnityEngineAnimationsPositionConstraint__SystemVoid(){} // RVA: 0x8B007C0
        public void __ToString__SystemString(){} // RVA: 0x8B00960
        public void __ctor__SystemInt32__UnityEngineAnimationsPositionConstraintArray(){} // RVA: 0x8B00A60
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8B00B60
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8B00C00
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8B00CA0
        public void __get_Length__SystemInt32(){} // RVA: 0x8B00D40
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8B00DE0
        public void __get_Rank__SystemInt32(){} // RVA: 0x8B00E80
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8B00F20
        public void <.ctor>b__6_1(){} // RVA: 0x8B01000
    }

    public class ExternUnityEngineAnimationsRotationConstraint : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8B02F20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x8B02F60
        public void .ctor(){} // RVA: 0x8B02FE0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8B033B0
        public void GetExternFunctionDelegate(){} // RVA: 0x8B034E0
        public void __AddSource__UnityEngineAnimationsConstraintSource__SystemInt32(){} // RVA: 0x8B035F0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8B037B0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8B03990
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8B03A80
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8B03D10
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x8B03E90
        public void __GetComponentInChildren__T(){} // RVA: 0x8B03FD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x8B040C0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8B04310
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8B04400
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8B04690
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x8B04810
        public void __GetComponentInParent__T(){} // RVA: 0x8B04950
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x8B04A40
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x8B04C90
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x8B04DC0
        public void __GetComponent__T(){} // RVA: 0x8B04F00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x8B04FE0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8B05210
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8B05300
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8B05610
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8B05700
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8B05A30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8B05B20
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8B05E10
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x8B05FB0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x8B06100
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x8B061F0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8B064A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8B06590
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8B068C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8B069B0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8B06CA0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x8B06E40
        public void __GetComponentsInParent__TArray(){} // RVA: 0x8B06F90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x8B07080
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x8B07330
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x8B07420
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x8B076F0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x8B07840
        public void __GetComponents__TArray(){} // RVA: 0x8B07990
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x8B07A80
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8B07D40
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x8B07EB0
        public void __GetSource__SystemInt32__UnityEngineAnimationsConstraintSource(){} // RVA: 0x8B08010
        public void __GetSources__SystemCollectionsGenericListUnityEngineAnimationsConstraintSource__SystemVoid(){} // RVA: 0x8B081D0
        public void __GetType__SystemType(){} // RVA: 0x8B08360
        public void __RemoveSource__SystemInt32__SystemVoid(){} // RVA: 0x8B08450
        public void __SetSource__SystemInt32_UnityEngineAnimationsConstraintSource__SystemVoid(){} // RVA: 0x8B085D0
        public void __SetSources__SystemCollectionsGenericListUnityEngineAnimationsConstraintSource__SystemVoid(){} // RVA: 0x8B08790
        public void __ToString__SystemString(){} // RVA: 0x8B08960
        public void __get_constraintActive__SystemBoolean(){} // RVA: 0x8B08AD0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x8B08C40
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x8B08DB0
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x8B08EC0
        public void __get_locked__SystemBoolean(){} // RVA: 0x8B09030
        public void __get_name__SystemString(){} // RVA: 0x8B091A0
        public void __get_rotationAtRest__UnityEngineVector3(){} // RVA: 0x8B09300
        public void __get_rotationAxis__UnityEngineAnimationsAxis(){} // RVA: 0x8B094A0
        public void __get_rotationOffset__UnityEngineVector3(){} // RVA: 0x8B09610
        public void __get_sourceCount__SystemInt32(){} // RVA: 0x8B097B0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x8B098A0
        public void __get_weight__SystemSingle(){} // RVA: 0x8B099B0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8B09B20
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x8B09E20
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8B0A020
        public void __set_constraintActive__SystemBoolean__SystemVoid(){} // RVA: 0x8B0A300
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x8B0A470
        public void __set_locked__SystemBoolean__SystemVoid(){} // RVA: 0x8B0A560
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x8B0A6D0
        public void __set_rotationAtRest__UnityEngineVector3__SystemVoid(){} // RVA: 0x8B0A830
        public void __set_rotationAxis__UnityEngineAnimationsAxis__SystemVoid(){} // RVA: 0x8B0A9C0
        public void __set_rotationOffset__UnityEngineVector3__SystemVoid(){} // RVA: 0x8B0AB30
        public void __set_weight__SystemSingle__SystemVoid(){} // RVA: 0x8B0ACC0
        public void <.ctor>b__8_1(){} // RVA: 0x8B0AE30
    }

    public class ExternUnityEngineAnimationsRotationConstraintArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8B0DD10
        public void .ctor(){} // RVA: 0x8B0DD50
        public void GetExternFunctionParameterCount(){} // RVA: 0x8B0E120
        public void GetExternFunctionDelegate(){} // RVA: 0x8B0E250
        public void __Clone__SystemObject(){} // RVA: 0x8B0E360
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8B0E450
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8B0E530
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8B0E600
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8B0E750
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8B0E7F0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8B0E900
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8B0EA20
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8B0EB30
        public void __GetType__SystemType(){} // RVA: 0x8B0EC50
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8B0ED40
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8B0EE20
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8B0EF50
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8B0F0E0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8B0F230
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8B0F360
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8B0F490
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8B0F610
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8B0F760
        public void __Get__SystemInt32__UnityEngineAnimationsRotationConstraint(){} // RVA: 0x8B0F890
        public void __Initialize__SystemVoid(){} // RVA: 0x8B0F9E0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8B0FA50
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B0FB80
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B0FD00
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8B0FE60
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8B0FF90
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8B100C0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8B10230
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8B10380
        public void __Set__SystemInt32_UnityEngineAnimationsRotationConstraint__SystemVoid(){} // RVA: 0x8B104B0
        public void __ToString__SystemString(){} // RVA: 0x8B10650
        public void __ctor__SystemInt32__UnityEngineAnimationsRotationConstraintArray(){} // RVA: 0x8B10750
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8B10850
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8B108F0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8B10990
        public void __get_Length__SystemInt32(){} // RVA: 0x8B10A30
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8B10AD0
        public void __get_Rank__SystemInt32(){} // RVA: 0x8B10B70
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8B10C10
        public void <.ctor>b__6_1(){} // RVA: 0x8B10CF0
    }

    public class ExternUnityEngineAnimationsScaleConstraint : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8B12C10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x8B12C50
        public void .ctor(){} // RVA: 0x8B12CD0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8B130A0
        public void GetExternFunctionDelegate(){} // RVA: 0x8B131D0
        public void __AddSource__UnityEngineAnimationsConstraintSource__SystemInt32(){} // RVA: 0x8B132E0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8B134A0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8B13680
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8B13770
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8B13A00
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x8B13B80
        public void __GetComponentInChildren__T(){} // RVA: 0x8B13CC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x8B13DB0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8B14000
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8B140F0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8B14380
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x8B14500
        public void __GetComponentInParent__T(){} // RVA: 0x8B14640
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x8B14730
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x8B14980
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x8B14AB0
        public void __GetComponent__T(){} // RVA: 0x8B14BF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x8B14CD0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8B14F00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8B14FF0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8B15300
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8B153F0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8B15720
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8B15810
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8B15B00
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x8B15CA0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x8B15DF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x8B15EE0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8B16190
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8B16280
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8B165B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8B166A0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8B16990
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x8B16B30
        public void __GetComponentsInParent__TArray(){} // RVA: 0x8B16C80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x8B16D70
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x8B17020
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x8B17110
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x8B173E0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x8B17530
        public void __GetComponents__TArray(){} // RVA: 0x8B17680
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x8B17770
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8B17A30
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x8B17BA0
        public void __GetSource__SystemInt32__UnityEngineAnimationsConstraintSource(){} // RVA: 0x8B17D00
        public void __GetSources__SystemCollectionsGenericListUnityEngineAnimationsConstraintSource__SystemVoid(){} // RVA: 0x8B17EC0
        public void __GetType__SystemType(){} // RVA: 0x8B18050
        public void __RemoveSource__SystemInt32__SystemVoid(){} // RVA: 0x8B18140
        public void __SetSource__SystemInt32_UnityEngineAnimationsConstraintSource__SystemVoid(){} // RVA: 0x8B182C0
        public void __SetSources__SystemCollectionsGenericListUnityEngineAnimationsConstraintSource__SystemVoid(){} // RVA: 0x8B18480
        public void __ToString__SystemString(){} // RVA: 0x8B18650
        public void __get_constraintActive__SystemBoolean(){} // RVA: 0x8B187C0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x8B18930
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x8B18AA0
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x8B18BB0
        public void __get_locked__SystemBoolean(){} // RVA: 0x8B18D20
        public void __get_name__SystemString(){} // RVA: 0x8B18E90
        public void __get_scaleAtRest__UnityEngineVector3(){} // RVA: 0x8B18FF0
        public void __get_scaleOffset__UnityEngineVector3(){} // RVA: 0x8B19190
        public void __get_scalingAxis__UnityEngineAnimationsAxis(){} // RVA: 0x8B19330
        public void __get_sourceCount__SystemInt32(){} // RVA: 0x8B194A0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x8B19590
        public void __get_weight__SystemSingle(){} // RVA: 0x8B196A0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8B19810
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x8B19B10
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8B19D10
        public void __set_constraintActive__SystemBoolean__SystemVoid(){} // RVA: 0x8B19FF0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x8B1A160
        public void __set_locked__SystemBoolean__SystemVoid(){} // RVA: 0x8B1A250
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x8B1A3C0
        public void __set_scaleAtRest__UnityEngineVector3__SystemVoid(){} // RVA: 0x8B1A520
        public void __set_scaleOffset__UnityEngineVector3__SystemVoid(){} // RVA: 0x8B1A6B0
        public void __set_scalingAxis__UnityEngineAnimationsAxis__SystemVoid(){} // RVA: 0x8B1A840
        public void __set_weight__SystemSingle__SystemVoid(){} // RVA: 0x8B1A9B0
        public void <.ctor>b__8_1(){} // RVA: 0x8B1AB20
    }

    public class ExternUnityEngineAnimationsScaleConstraintArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8B1DA00
        public void .ctor(){} // RVA: 0x8B1DA40
        public void GetExternFunctionParameterCount(){} // RVA: 0x8B1DE10
        public void GetExternFunctionDelegate(){} // RVA: 0x8B1DF40
        public void __Clone__SystemObject(){} // RVA: 0x8B1E050
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8B1E140
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8B1E220
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8B1E2F0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8B1E440
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8B1E4E0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8B1E5F0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8B1E710
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8B1E820
        public void __GetType__SystemType(){} // RVA: 0x8B1E940
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8B1EA30
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8B1EB10
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8B1EC40
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8B1EDD0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8B1EF20
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8B1F050
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8B1F180
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8B1F300
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8B1F450
        public void __Get__SystemInt32__UnityEngineAnimationsScaleConstraint(){} // RVA: 0x8B1F580
        public void __Initialize__SystemVoid(){} // RVA: 0x8B1F6D0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8B1F740
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B1F870
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B1F9F0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8B1FB50
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8B1FC80
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8B1FDB0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8B1FF20
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8B20070
        public void __Set__SystemInt32_UnityEngineAnimationsScaleConstraint__SystemVoid(){} // RVA: 0x8B201A0
        public void __ToString__SystemString(){} // RVA: 0x8B20340
        public void __ctor__SystemInt32__UnityEngineAnimationsScaleConstraintArray(){} // RVA: 0x8B20440
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8B20540
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8B205E0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8B20680
        public void __get_Length__SystemInt32(){} // RVA: 0x8B20720
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8B207C0
        public void __get_Rank__SystemInt32(){} // RVA: 0x8B20860
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8B20900
        public void <.ctor>b__6_1(){} // RVA: 0x8B209E0
    }

    public class ExternUnityEngineAnimator : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8B2B900
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x8B2B940
        public void .ctor(){} // RVA: 0x8B2B9C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8B2BD90
        public void GetExternFunctionDelegate(){} // RVA: 0x8B2BEC0
        public void __ApplyBuiltinRootMotion__SystemVoid(){} // RVA: 0x8B2BFD0
        public void __CrossFadeInFixedTime__SystemInt32_SystemSingle_SystemInt32_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x8B2C100
        public void __CrossFadeInFixedTime__SystemInt32_SystemSingle_SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x8B2C2C0
        public void __CrossFadeInFixedTime__SystemInt32_SystemSingle_SystemInt32__SystemVoid(){} // RVA: 0x8B2C450
        public void __CrossFadeInFixedTime__SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x8B2C5C0
        public void __CrossFadeInFixedTime__SystemString_SystemSingle_SystemInt32_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x8B2C700
        public void __CrossFadeInFixedTime__SystemString_SystemSingle_SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x8B2C900
        public void __CrossFadeInFixedTime__SystemString_SystemSingle_SystemInt32__SystemVoid(){} // RVA: 0x8B2CAC0
        public void __CrossFadeInFixedTime__SystemString_SystemSingle__SystemVoid(){} // RVA: 0x8B2CC50
        public void __CrossFade__SystemInt32_SystemSingle_SystemInt32_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x8B2CDB0
        public void __CrossFade__SystemInt32_SystemSingle_SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x8B2CF70
        public void __CrossFade__SystemInt32_SystemSingle_SystemInt32__SystemVoid(){} // RVA: 0x8B2D100
        public void __CrossFade__SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x8B2D270
        public void __CrossFade__SystemString_SystemSingle_SystemInt32_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x8B2D3C0
        public void __CrossFade__SystemString_SystemSingle_SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x8B2D5C0
        public void __CrossFade__SystemString_SystemSingle_SystemInt32__SystemVoid(){} // RVA: 0x8B2D780
        public void __CrossFade__SystemString_SystemSingle__SystemVoid(){} // RVA: 0x8B2D910
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8B2DA70
        public void __GetAnimatorTransitionInfo__SystemInt32__UnityEngineAnimatorTransitionInfo(){} // RVA: 0x8B2DC50
        public void __GetBoneTransform__UnityEngineHumanBodyBones__UnityEngineTransform(){} // RVA: 0x8B2DE30
        public void __GetBool__SystemInt32__SystemBoolean(){} // RVA: 0x8B2DF80
        public void __GetBool__SystemString__SystemBoolean(){} // RVA: 0x8B2E0A0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8B2E1C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x8B2E2B0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8B2E540
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x8B2E6C0
        public void __GetComponentInChildren__T(){} // RVA: 0x8B2E800
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x8B2E8F0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8B2EB40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x8B2EC30
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x8B2EEC0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x8B2F040
        public void __GetComponentInParent__T(){} // RVA: 0x8B2F180
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x8B2F270
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x8B2F4C0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x8B2F5F0
        public void __GetComponent__T(){} // RVA: 0x8B2F730
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x8B2F810
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8B2FA40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x8B2FB30
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8B2FE40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8B2FF30
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8B30260
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x8B30350
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8B30640
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x8B307E0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x8B30930
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x8B30A20
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8B30CD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x8B30DC0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8B310F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x8B311E0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x8B314D0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x8B31670
        public void __GetComponentsInParent__TArray(){} // RVA: 0x8B317C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x8B318B0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x8B31B60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x8B31C50
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x8B31F20
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x8B32070
        public void __GetComponents__TArray(){} // RVA: 0x8B321C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x8B322B0
        public void __GetCurrentAnimatorClipInfoCount__SystemInt32__SystemInt32(){} // RVA: 0x8B32570
        public void __GetCurrentAnimatorClipInfo__SystemInt32_SystemCollectionsGenericListUnityEngineAnimatorClipInfo__SystemVoid(){} // RVA: 0x8B32690
        public void __GetCurrentAnimatorClipInfo__SystemInt32__UnityEngineAnimatorClipInfoArray(){} // RVA: 0x8B32800
        public void __GetCurrentAnimatorStateInfo__SystemInt32__UnityEngineAnimatorStateInfo(){} // RVA: 0x8B32920
        public void __GetFloat__SystemInt32__SystemSingle(){} // RVA: 0x8B32A70
        public void __GetFloat__SystemString__SystemSingle(){} // RVA: 0x8B32B90
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8B32CB0
        public void __GetIKHintPositionWeight__UnityEngineAvatarIKHint__SystemSingle(){} // RVA: 0x8B32E20
        public void __GetIKHintPosition__UnityEngineAvatarIKHint__UnityEngineVector3(){} // RVA: 0x8B32FD0
        public void __GetIKPositionWeight__UnityEngineAvatarIKGoal__SystemSingle(){} // RVA: 0x8B331A0
        public void __GetIKPosition__UnityEngineAvatarIKGoal__UnityEngineVector3(){} // RVA: 0x8B33350
        public void __GetIKRotationWeight__UnityEngineAvatarIKGoal__SystemSingle(){} // RVA: 0x8B33520
        public void __GetIKRotation__UnityEngineAvatarIKGoal__UnityEngineQuaternion(){} // RVA: 0x8B336D0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x8B33890
        public void __GetInteger__SystemInt32__SystemInt32(){} // RVA: 0x8B339F0
        public void __GetInteger__SystemString__SystemInt32(){} // RVA: 0x8B33B10
        public void __GetLayerIndex__SystemString__SystemInt32(){} // RVA: 0x8B33C30
        public void __GetLayerName__SystemInt32__SystemString(){} // RVA: 0x8B33D50
        public void __GetLayerWeight__SystemInt32__SystemSingle(){} // RVA: 0x8B33E70
        public void __GetNextAnimatorClipInfoCount__SystemInt32__SystemInt32(){} // RVA: 0x8B33F90
        public void __GetNextAnimatorClipInfo__SystemInt32_SystemCollectionsGenericListUnityEngineAnimatorClipInfo__SystemVoid(){} // RVA: 0x8B340B0
        public void __GetNextAnimatorClipInfo__SystemInt32__UnityEngineAnimatorClipInfoArray(){} // RVA: 0x8B34220
        public void __GetNextAnimatorStateInfo__SystemInt32__UnityEngineAnimatorStateInfo(){} // RVA: 0x8B343C0
        public void __GetParameter__SystemInt32__UnityEngineAnimatorControllerParameter(){} // RVA: 0x8B34510
        public void __GetType__SystemType(){} // RVA: 0x8B34630
        public void __HasState__SystemInt32_SystemInt32__SystemBoolean(){} // RVA: 0x8B34720
        public void __InterruptMatchTarget__SystemBoolean__SystemVoid(){} // RVA: 0x8B34860
        public void __InterruptMatchTarget__SystemVoid(){} // RVA: 0x8B34950
        public void __IsInTransition__SystemInt32__SystemBoolean(){} // RVA: 0x8B34A10
        public void __IsParameterControlledByCurve__SystemInt32__SystemBoolean(){} // RVA: 0x8B34B30
        public void __IsParameterControlledByCurve__SystemString__SystemBoolean(){} // RVA: 0x8B34C50
        public void __MatchTarget__UnityEngineVector3_UnityEngineQuaternion_UnityEngineAvatarTarget_UnityEngineMatchTargetWeightMask_SystemSingle_SystemSingle_SystemBoolean__SystemVoid(){} // RVA: 0x8B34D70
        public void __MatchTarget__UnityEngineVector3_UnityEngineQuaternion_UnityEngineAvatarTarget_UnityEngineMatchTargetWeightMask_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x8B350C0
        public void __MatchTarget__UnityEngineVector3_UnityEngineQuaternion_UnityEngineAvatarTarget_UnityEngineMatchTargetWeightMask_SystemSingle__SystemVoid(){} // RVA: 0x8B353E0
        public void __PlayInFixedTime__SystemInt32_SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x8B356D0
        public void __PlayInFixedTime__SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B35830
        public void __PlayInFixedTime__SystemInt32__SystemVoid(){} // RVA: 0x8B35950
        public void __PlayInFixedTime__SystemString_SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x8B35A50
        public void __PlayInFixedTime__SystemString_SystemInt32__SystemVoid(){} // RVA: 0x8B35BD0
        public void __PlayInFixedTime__SystemString__SystemVoid(){} // RVA: 0x8B35D10
        public void __Play__SystemInt32_SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x8B35E20
        public void __Play__SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B35F80
        public void __Play__SystemInt32__SystemVoid(){} // RVA: 0x8B360A0
        public void __Play__SystemString_SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x8B361A0
        public void __Play__SystemString_SystemInt32__SystemVoid(){} // RVA: 0x8B36320
        public void __Play__SystemString__SystemVoid(){} // RVA: 0x8B36460
        public void __Rebind__SystemVoid(){} // RVA: 0x8B36570
        public void __ResetTrigger__SystemInt32__SystemVoid(){} // RVA: 0x8B366A0
        public void __ResetTrigger__SystemString__SystemVoid(){} // RVA: 0x8B36790
        public void __SetBoneLocalRotation__UnityEngineHumanBodyBones_UnityEngineQuaternion__SystemVoid(){} // RVA: 0x8B36870
        public void __SetBool__SystemInt32_SystemBoolean__SystemVoid(){} // RVA: 0x8B36A70
        public void __SetBool__SystemString_SystemBoolean__SystemVoid(){} // RVA: 0x8B36B90
        public void __SetFloat__SystemInt32_SystemSingle_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x8B36CB0
        public void __SetFloat__SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x8B36EC0
        public void __SetFloat__SystemString_SystemSingle_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x8B36FE0
        public void __SetFloat__SystemString_SystemSingle__SystemVoid(){} // RVA: 0x8B37170
        public void __SetIKHintPositionWeight__UnityEngineAvatarIKHint_SystemSingle__SystemVoid(){} // RVA: 0x8B37290
        public void __SetIKHintPosition__UnityEngineAvatarIKHint_UnityEngineVector3__SystemVoid(){} // RVA: 0x8B37440
        public void __SetIKPositionWeight__UnityEngineAvatarIKGoal_SystemSingle__SystemVoid(){} // RVA: 0x8B37610
        public void __SetIKPosition__UnityEngineAvatarIKGoal_UnityEngineVector3__SystemVoid(){} // RVA: 0x8B37730
        public void __SetIKRotationWeight__UnityEngineAvatarIKGoal_SystemSingle__SystemVoid(){} // RVA: 0x8B37900
        public void __SetIKRotation__UnityEngineAvatarIKGoal_UnityEngineQuaternion__SystemVoid(){} // RVA: 0x8B37A20
        public void __SetInteger__SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B37BE0
        public void __SetInteger__SystemString_SystemInt32__SystemVoid(){} // RVA: 0x8B37CF0
        public void __SetLayerWeight__SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x8B37E10
        public void __SetLookAtPosition__UnityEngineVector3__SystemVoid(){} // RVA: 0x8B37F30
        public void __SetLookAtWeight__SystemSingle_SystemSingle_SystemSingle_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x8B380D0
        public void __SetLookAtWeight__SystemSingle_SystemSingle_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x8B382D0
        public void __SetLookAtWeight__SystemSingle_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x8B384A0
        public void __SetLookAtWeight__SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x8B385F0
        public void __SetLookAtWeight__SystemSingle__SystemVoid(){} // RVA: 0x8B387C0
        public void __SetTarget__UnityEngineAvatarTarget_SystemSingle__SystemVoid(){} // RVA: 0x8B38960
        public void __SetTrigger__SystemInt32__SystemVoid(){} // RVA: 0x8B38B10
        public void __SetTrigger__SystemString__SystemVoid(){} // RVA: 0x8B38C00
        public void __StartPlayback__SystemVoid(){} // RVA: 0x8B38CE0
        public void __StartRecording__SystemInt32__SystemVoid(){} // RVA: 0x8B38E10
        public void __StopPlayback__SystemVoid(){} // RVA: 0x8B38F80
        public void __StopRecording__SystemVoid(){} // RVA: 0x8B390B0
        public void __StringToHash__SystemString__SystemInt32(){} // RVA: 0x8B391E0
        public void __ToString__SystemString(){} // RVA: 0x8B39280
        public void __Update__SystemSingle__SystemVoid(){} // RVA: 0x8B393F0
        public void __WriteDefaultValues__SystemVoid(){} // RVA: 0x8B394E0
        public void __get_angularVelocity__UnityEngineVector3(){} // RVA: 0x8B39610
        public void __get_applyRootMotion__SystemBoolean(){} // RVA: 0x8B397B0
        public void __get_avatarRoot__UnityEngineTransform(){} // RVA: 0x8B39920
        public void __get_avatar__UnityEngineAvatar(){} // RVA: 0x8B39A30
        public void __get_bodyPosition__UnityEngineVector3(){} // RVA: 0x8B39B40
        public void __get_bodyRotation__UnityEngineQuaternion(){} // RVA: 0x8B39CE0
        public void __get_cullingMode__UnityEngineAnimatorCullingMode(){} // RVA: 0x8B39E70
        public void __get_deltaPosition__UnityEngineVector3(){} // RVA: 0x8B39FE0
        public void __get_deltaRotation__UnityEngineQuaternion(){} // RVA: 0x8B3A180
        public void __get_enabled__SystemBoolean(){} // RVA: 0x8B3A300
        public void __get_feetPivotActive__SystemSingle(){} // RVA: 0x8B3A470
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x8B3A5E0
        public void __get_gravityWeight__SystemSingle(){} // RVA: 0x8B3A6F0
        public void __get_hasRootMotion__SystemBoolean(){} // RVA: 0x8B3A860
        public void __get_hasTransformHierarchy__SystemBoolean(){} // RVA: 0x8B3A9D0
        public void __get_humanScale__SystemSingle(){} // RVA: 0x8B3AB40
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x8B3ACB0
        public void __get_isHuman__SystemBoolean(){} // RVA: 0x8B3AE20
        public void __get_isInitialized__SystemBoolean(){} // RVA: 0x8B3AF90
        public void __get_isMatchingTarget__SystemBoolean(){} // RVA: 0x8B3B100
        public void __get_isOptimizable__SystemBoolean(){} // RVA: 0x8B3B270
        public void __get_keepAnimatorControllerStateOnDisable__SystemBoolean(){} // RVA: 0x8B3B3E0
        public void __get_keepAnimatorStateOnDisable__SystemBoolean(){} // RVA: 0x8B3B550
        public void __get_layerCount__SystemInt32(){} // RVA: 0x8B3B6C0
        public void __get_layersAffectMassCenter__SystemBoolean(){} // RVA: 0x8B3B830
        public void __get_leftFeetBottomHeight__SystemSingle(){} // RVA: 0x8B3B9A0
        public void __get_logWarnings__SystemBoolean(){} // RVA: 0x8B3BB10
        public void __get_name__SystemString(){} // RVA: 0x8B3BC80
        public void __get_parameterCount__SystemInt32(){} // RVA: 0x8B3BDE0
        public void __get_parameters__UnityEngineAnimatorControllerParameterArray(){} // RVA: 0x8B3BF50
        public void __get_pivotPosition__UnityEngineVector3(){} // RVA: 0x8B3C0C0
        public void __get_pivotWeight__SystemSingle(){} // RVA: 0x8B3C260
        public void __get_playbackTime__SystemSingle(){} // RVA: 0x8B3C3D0
        public void __get_recorderMode__UnityEngineAnimatorRecorderMode(){} // RVA: 0x8B3C540
        public void __get_recorderStartTime__SystemSingle(){} // RVA: 0x8B3C6B0
        public void __get_recorderStopTime__SystemSingle(){} // RVA: 0x8B3C820
        public void __get_rightFeetBottomHeight__SystemSingle(){} // RVA: 0x8B3C990
        public void __get_rootPosition__UnityEngineVector3(){} // RVA: 0x8B3CB00
        public void __get_rootRotation__UnityEngineQuaternion(){} // RVA: 0x8B3CCA0
        public void __get_runtimeAnimatorController__UnityEngineRuntimeAnimatorController(){} // RVA: 0x8B3CE20
        public void __get_speed__SystemSingle(){} // RVA: 0x8B3CF30
        public void __get_stabilizeFeet__SystemBoolean(){} // RVA: 0x8B3D0A0
        public void __get_targetPosition__UnityEngineVector3(){} // RVA: 0x8B3D210
        public void __get_targetRotation__UnityEngineQuaternion(){} // RVA: 0x8B3D3B0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x8B3D530
        public void __get_updateMode__UnityEngineAnimatorUpdateMode(){} // RVA: 0x8B3D640
        public void __get_velocity__UnityEngineVector3(){} // RVA: 0x8B3D7B0
        public void __get_writeDefaultValuesOnDisable__SystemBoolean(){} // RVA: 0x8B3D950
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8B3DAC0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x8B3DDC0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8B3DFC0
        public void __set_applyRootMotion__SystemBoolean__SystemVoid(){} // RVA: 0x8B3E2A0
        public void __set_avatar__UnityEngineAvatar__SystemVoid(){} // RVA: 0x8B3E390
        public void __set_bodyPosition__UnityEngineVector3__SystemVoid(){} // RVA: 0x8B3E550
        public void __set_bodyRotation__UnityEngineQuaternion__SystemVoid(){} // RVA: 0x8B3E6F0
        public void __set_cullingMode__UnityEngineAnimatorCullingMode__SystemVoid(){} // RVA: 0x8B3E870
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x8B3E960
        public void __set_feetPivotActive__SystemSingle__SystemVoid(){} // RVA: 0x8B3EA50
        public void __set_keepAnimatorControllerStateOnDisable__SystemBoolean__SystemVoid(){} // RVA: 0x8B3EBC0
        public void __set_keepAnimatorStateOnDisable__SystemBoolean__SystemVoid(){} // RVA: 0x8B3ECB0
        public void __set_layersAffectMassCenter__SystemBoolean__SystemVoid(){} // RVA: 0x8B3EDA0
        public void __set_logWarnings__SystemBoolean__SystemVoid(){} // RVA: 0x8B3EF10
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x8B3F000
        public void __set_playbackTime__SystemSingle__SystemVoid(){} // RVA: 0x8B3F160
        public void __set_recorderStartTime__SystemSingle__SystemVoid(){} // RVA: 0x8B3F2D0
        public void __set_recorderStopTime__SystemSingle__SystemVoid(){} // RVA: 0x8B3F3B0
        public void __set_rootPosition__UnityEngineVector3__SystemVoid(){} // RVA: 0x8B3F490
        public void __set_rootRotation__UnityEngineQuaternion__SystemVoid(){} // RVA: 0x8B3F620
        public void __set_runtimeAnimatorController__UnityEngineRuntimeAnimatorController__SystemVoid(){} // RVA: 0x8B3F7A0
        public void __set_speed__SystemSingle__SystemVoid(){} // RVA: 0x8B3F8B0
        public void __set_stabilizeFeet__SystemBoolean__SystemVoid(){} // RVA: 0x8B3F9A0
        public void __set_updateMode__UnityEngineAnimatorUpdateMode__SystemVoid(){} // RVA: 0x8B3FB10
        public void __set_writeDefaultValuesOnDisable__SystemBoolean__SystemVoid(){} // RVA: 0x8B3FC00
        public void <.ctor>b__8_1(){} // RVA: 0x8B3FD70
    }

    public class ExternUnityEngineAnimatorArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8B496A0
        public void .ctor(){} // RVA: 0x8B496E0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8B49AB0
        public void GetExternFunctionDelegate(){} // RVA: 0x8B49BE0
        public void __Clone__SystemObject(){} // RVA: 0x8B49CF0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8B49DE0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8B49EC0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8B49F90
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8B4A0E0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8B4A180
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8B4A290
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8B4A3B0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8B4A4C0
        public void __GetType__SystemType(){} // RVA: 0x8B4A5E0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8B4A6D0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8B4A7B0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8B4A8E0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8B4AA70
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8B4ABC0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8B4ACF0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8B4AE20
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8B4AFA0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8B4B0F0
        public void __Get__SystemInt32__UnityEngineAnimator(){} // RVA: 0x8B4B220
        public void __Initialize__SystemVoid(){} // RVA: 0x8B4B370
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8B4B3E0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B4B510
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B4B690
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8B4B7F0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8B4B920
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8B4BA50
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8B4BBC0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8B4BD10
        public void __Set__SystemInt32_UnityEngineAnimator__SystemVoid(){} // RVA: 0x8B4BE40
        public void __ToString__SystemString(){} // RVA: 0x8B4C010
        public void __ctor__SystemInt32__UnityEngineAnimatorArray(){} // RVA: 0x8B4C110
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8B4C210
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8B4C2B0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8B4C350
        public void __get_Length__SystemInt32(){} // RVA: 0x8B4C3F0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8B4C490
        public void __get_Rank__SystemInt32(){} // RVA: 0x8B4C530
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8B4C5D0
        public void <.ctor>b__6_1(){} // RVA: 0x8B4C6B0
    }

    public class ExternUnityEngineAnimatorClipInfo : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8B4E5D0
        public void .ctor(){} // RVA: 0x8B4E610
        public void GetExternFunctionParameterCount(){} // RVA: 0x8B4E9E0
        public void GetExternFunctionDelegate(){} // RVA: 0x8B4EB10
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8B4EC20
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8B4ED60
        public void __GetType__SystemType(){} // RVA: 0x8B4EE10
        public void __ToString__SystemString(){} // RVA: 0x8B4EF00
        public void __get_clip__UnityEngineAnimationClip(){} // RVA: 0x8B4EFB0
        public void __get_weight__SystemSingle(){} // RVA: 0x8B4F100
        public void <.ctor>b__6_1(){} // RVA: 0x8B4F1A0
    }

    public class ExternUnityEngineAnimatorClipInfoArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8B4F7F0
        public void .ctor(){} // RVA: 0x8B4F830
        public void GetExternFunctionParameterCount(){} // RVA: 0x8B4FC00
        public void GetExternFunctionDelegate(){} // RVA: 0x8B4FD30
        public void __Clone__SystemObject(){} // RVA: 0x8B4FE40
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8B4FF30
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8B50010
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8B500E0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8B50230
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8B502D0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8B503E0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8B50500
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8B50610
        public void __GetType__SystemType(){} // RVA: 0x8B50730
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8B50820
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8B50900
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8B50A30
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8B50BC0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8B50D10
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8B50E40
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8B50F70
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8B510F0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8B51240
        public void __Get__SystemInt32__UnityEngineAnimatorClipInfo(){} // RVA: 0x8B51370
        public void __Initialize__SystemVoid(){} // RVA: 0x8B51530
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8B515A0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B516D0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B51850
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8B519B0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8B51AE0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8B51C10
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8B51D80
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8B51ED0
        public void __Set__SystemInt32_UnityEngineAnimatorClipInfo__SystemVoid(){} // RVA: 0x8B52000
        public void __ToString__SystemString(){} // RVA: 0x8B520E0
        public void __ctor__SystemInt32__UnityEngineAnimatorClipInfoArray(){} // RVA: 0x8B521E0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8B52290
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8B52330
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8B523D0
        public void __get_Length__SystemInt32(){} // RVA: 0x8B52470
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8B52510
        public void __get_Rank__SystemInt32(){} // RVA: 0x8B525B0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8B52650
        public void <.ctor>b__6_1(){} // RVA: 0x8B52730
    }

    public class ExternUnityEngineAnimatorControllerParameter : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8B54650
        public void .ctor(){} // RVA: 0x8B54690
        public void GetExternFunctionParameterCount(){} // RVA: 0x8B54A60
        public void GetExternFunctionDelegate(){} // RVA: 0x8B54B90
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8B54CA0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8B54DE0
        public void __GetType__SystemType(){} // RVA: 0x8B54E90
        public void __ToString__SystemString(){} // RVA: 0x8B54F80
        public void __ctor____UnityEngineAnimatorControllerParameter(){} // RVA: 0x8B55080
        public void __get_defaultBool__SystemBoolean(){} // RVA: 0x8B55120
        public void __get_defaultFloat__SystemSingle(){} // RVA: 0x8B551C0
        public void __get_defaultInt__SystemInt32(){} // RVA: 0x8B55260
        public void __get_nameHash__SystemInt32(){} // RVA: 0x8B55300
        public void __get_name__SystemString(){} // RVA: 0x8B553A0
        public void __get_type__UnityEngineAnimatorControllerParameterType(){} // RVA: 0x8B55430
        public void __set_defaultBool__SystemBoolean__SystemVoid(){} // RVA: 0x8B554D0
        public void __set_defaultFloat__SystemSingle__SystemVoid(){} // RVA: 0x8B55580
        public void __set_defaultInt__SystemInt32__SystemVoid(){} // RVA: 0x8B55630
        public void __set_type__UnityEngineAnimatorControllerParameterType__SystemVoid(){} // RVA: 0x8B556E0
        public void <.ctor>b__6_1(){} // RVA: 0x8B55790
    }

    public class ExternUnityEngineAnimatorControllerParameterArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8B564B0
        public void .ctor(){} // RVA: 0x8B564F0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8B568C0
        public void GetExternFunctionDelegate(){} // RVA: 0x8B569F0
        public void __Clone__SystemObject(){} // RVA: 0x8B56B00
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8B56BF0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8B56CD0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8B56DA0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8B56EF0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8B56F90
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8B570A0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8B571C0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8B572D0
        public void __GetType__SystemType(){} // RVA: 0x8B573F0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8B574E0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8B575C0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8B576F0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8B57880
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8B579D0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8B57B00
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8B57C30
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8B57DB0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8B57F00
        public void __Get__SystemInt32__UnityEngineAnimatorControllerParameter(){} // RVA: 0x8B58030
        public void __Initialize__SystemVoid(){} // RVA: 0x8B58110
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8B58180
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B582B0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B58430
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8B58590
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8B586C0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8B587F0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8B58960
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8B58AB0
        public void __Set__SystemInt32_UnityEngineAnimatorControllerParameter__SystemVoid(){} // RVA: 0x8B58BE0
        public void __ToString__SystemString(){} // RVA: 0x8B58D50
        public void __ctor__SystemInt32__UnityEngineAnimatorControllerParameterArray(){} // RVA: 0x8B58E50
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8B58F00
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8B58FA0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8B59040
        public void __get_Length__SystemInt32(){} // RVA: 0x8B590E0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8B59180
        public void __get_Rank__SystemInt32(){} // RVA: 0x8B59220
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8B592C0
        public void <.ctor>b__6_1(){} // RVA: 0x8B593A0
    }

    public class ExternUnityEngineAnimatorOverrideController : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8B5B2C0
        public void .ctor(){} // RVA: 0x8B5B300
        public void GetExternFunctionParameterCount(){} // RVA: 0x8B5B6D0
        public void GetExternFunctionDelegate(){} // RVA: 0x8B5B800
        public void __ApplyOverrides__SystemCollectionsGenericIListSystemCollectionsGenericKeyValuePairUnityEngineAnimationClipUnityEngineAnimationClip__SystemVoid(){} // RVA: 0x8B5B910
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8B5BA00
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8B5BBE0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x8B5BD50
        public void __GetOverrides__SystemCollectionsGenericListSystemCollectionsGenericKeyValuePairUnityEngineAnimationClipUnityEngineAnimationClip__SystemVoid(){} // RVA: 0x8B5BEB0
        public void __GetType__SystemType(){} // RVA: 0x8B5C060
        public void __ToString__SystemString(){} // RVA: 0x8B5C150
        public void __get_Item__SystemString__UnityEngineAnimationClip(){} // RVA: 0x8B5C2C0
        public void __get_Item__UnityEngineAnimationClip__UnityEngineAnimationClip(){} // RVA: 0x8B5C400
        public void __get_animationClips__UnityEngineAnimationClipArray(){} // RVA: 0x8B5C640
        public void __get_name__SystemString(){} // RVA: 0x8B5C7D0
        public void __get_overridesCount__SystemInt32(){} // RVA: 0x8B5C930
        public void __get_runtimeAnimatorController__UnityEngineRuntimeAnimatorController(){} // RVA: 0x8B5CAA0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8B5CC50
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x8B5CF50
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x8B5D150
        public void __set_Item__SystemString_UnityEngineAnimationClip__SystemVoid(){} // RVA: 0x8B5D430
        public void __set_Item__UnityEngineAnimationClip_UnityEngineAnimationClip__SystemVoid(){} // RVA: 0x8B5D570
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x8B5D6C0
        public void __set_runtimeAnimatorController__UnityEngineRuntimeAnimatorController__SystemVoid(){} // RVA: 0x8B5D820
        public void <.ctor>b__6_1(){} // RVA: 0x8B5D9E0
    }

    public class ExternUnityEngineAnimatorOverrideControllerArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8B5EAB0
        public void .ctor(){} // RVA: 0x8B5EAF0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8B5EEC0
        public void GetExternFunctionDelegate(){} // RVA: 0x8B5EFF0
        public void __Clone__SystemObject(){} // RVA: 0x8B5F100
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8B5F1F0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8B5F2D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8B5F3A0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8B5F4F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8B5F590
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8B5F6A0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8B5F7C0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8B5F8D0
        public void __GetType__SystemType(){} // RVA: 0x8B5F9F0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8B5FAE0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8B5FBC0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8B5FCF0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8B5FE80
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8B5FFD0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8B60100
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8B60230
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8B603B0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8B60500
        public void __Get__SystemInt32__UnityEngineAnimatorOverrideController(){} // RVA: 0x8B60630
        public void __Initialize__SystemVoid(){} // RVA: 0x8B60840
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8B608B0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B609E0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B60B60
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8B60CC0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8B60DF0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8B60F20
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8B61090
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8B611E0
        public void __Set__SystemInt32_UnityEngineAnimatorOverrideController__SystemVoid(){} // RVA: 0x8B61310
        public void __ToString__SystemString(){} // RVA: 0x8B614E0
        public void __ctor__SystemInt32__UnityEngineAnimatorOverrideControllerArray(){} // RVA: 0x8B615E0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8B617A0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8B61840
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8B618E0
        public void __get_Length__SystemInt32(){} // RVA: 0x8B61980
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8B61A20
        public void __get_Rank__SystemInt32(){} // RVA: 0x8B61AC0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8B61B60
        public void <.ctor>b__6_1(){} // RVA: 0x8B61C40
    }

    public class ExternUnityEngineAnimatorStateInfo : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8B63B60
        public void .ctor(){} // RVA: 0x8B63BA0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8B63F70
        public void GetExternFunctionDelegate(){} // RVA: 0x8B640A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8B641B0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8B642F0
        public void __GetType__SystemType(){} // RVA: 0x8B643A0
        public void __IsName__SystemString__SystemBoolean(){} // RVA: 0x8B64490
        public void __IsTag__SystemString__SystemBoolean(){} // RVA: 0x8B645B0
        public void __ToString__SystemString(){} // RVA: 0x8B646A0
        public void __get_fullPathHash__SystemInt32(){} // RVA: 0x8B64750
        public void __get_length__SystemSingle(){} // RVA: 0x8B64800
        public void __get_loop__SystemBoolean(){} // RVA: 0x8B648A0
        public void __get_normalizedTime__SystemSingle(){} // RVA: 0x8B64940
        public void __get_shortNameHash__SystemInt32(){} // RVA: 0x8B649E0
        public void __get_speedMultiplier__SystemSingle(){} // RVA: 0x8B64A80
        public void __get_speed__SystemSingle(){} // RVA: 0x8B64B20
        public void __get_tagHash__SystemInt32(){} // RVA: 0x8B64BC0
        public void <.ctor>b__6_1(){} // RVA: 0x8B64C70
    }

    public class ExternUnityEngineAnimatorStateInfoArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8B658D0
        public void .ctor(){} // RVA: 0x8B65910
        public void GetExternFunctionParameterCount(){} // RVA: 0x8B65CE0
        public void GetExternFunctionDelegate(){} // RVA: 0x8B65E10
        public void __Clone__SystemObject(){} // RVA: 0x8B65F20
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8B66010
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8B660F0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8B661C0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8B66310
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8B663B0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8B664C0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8B665E0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8B666F0
        public void __GetType__SystemType(){} // RVA: 0x8B66810
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8B66900
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8B669E0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8B66B10
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8B66CA0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8B66DF0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8B66F20
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8B67050
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8B671D0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8B67320
        public void __Get__SystemInt32__UnityEngineAnimatorStateInfo(){} // RVA: 0x8B67450
        public void __Initialize__SystemVoid(){} // RVA: 0x8B67550
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8B675C0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B676F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B67870
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8B679D0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8B67B00
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8B67C30
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8B67DA0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8B67EF0
        public void __Set__SystemInt32_UnityEngineAnimatorStateInfo__SystemVoid(){} // RVA: 0x8B68020
        public void __ToString__SystemString(){} // RVA: 0x8B68130
        public void __ctor__SystemInt32__UnityEngineAnimatorStateInfoArray(){} // RVA: 0x8B68230
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8B683D0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8B68470
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8B68510
        public void __get_Length__SystemInt32(){} // RVA: 0x8B685B0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8B68650
        public void __get_Rank__SystemInt32(){} // RVA: 0x8B686F0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8B68790
        public void <.ctor>b__6_1(){} // RVA: 0x8B68870
    }

    public class ExternUnityEngineAnimatorTransitionInfo : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8B6A790
        public void .ctor(){} // RVA: 0x8B6A7D0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8B6ABA0
        public void GetExternFunctionDelegate(){} // RVA: 0x8B6ACD0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8B6ADE0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8B6AF20
        public void __GetType__SystemType(){} // RVA: 0x8B6AFD0
        public void __IsName__SystemString__SystemBoolean(){} // RVA: 0x8B6B0C0
        public void __IsUserName__SystemString__SystemBoolean(){} // RVA: 0x8B6B1D0
        public void __ToString__SystemString(){} // RVA: 0x8B6B2B0
        public void __get_anyState__SystemBoolean(){} // RVA: 0x8B6B360
        public void __get_durationUnit__UnityEngineDurationUnit(){} // RVA: 0x8B6B400
        public void __get_duration__SystemSingle(){} // RVA: 0x8B6B4B0
        public void __get_fullPathHash__SystemInt32(){} // RVA: 0x8B6B550
        public void __get_nameHash__SystemInt32(){} // RVA: 0x8B6B5F0
        public void __get_normalizedTime__SystemSingle(){} // RVA: 0x8B6B690
        public void __get_userNameHash__SystemInt32(){} // RVA: 0x8B6B730
        public void <.ctor>b__6_1(){} // RVA: 0x8B6B7D0
    }

    public class ExternUnityEngineAnimatorTransitionInfoArray : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8B6C360
        public void .ctor(){} // RVA: 0x8B6C3A0
        public void GetExternFunctionParameterCount(){} // RVA: 0x8B6C770
        public void GetExternFunctionDelegate(){} // RVA: 0x8B6C8A0
        public void __Clone__SystemObject(){} // RVA: 0x8B6C9B0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x8B6CAA0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x8B6CB80
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8B6CC50
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x8B6CDA0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8B6CE40
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x8B6CF50
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x8B6D070
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x8B6D180
        public void __GetType__SystemType(){} // RVA: 0x8B6D2A0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x8B6D390
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x8B6D470
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8B6D5A0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x8B6D730
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x8B6D880
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x8B6D9B0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8B6DAE0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x8B6DC60
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x8B6DDB0
        public void __Get__SystemInt32__UnityEngineAnimatorTransitionInfo(){} // RVA: 0x8B6DEE0
        public void __Initialize__SystemVoid(){} // RVA: 0x8B6DFE0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x8B6E050
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B6E180
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x8B6E300
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x8B6E460
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x8B6E590
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8B6E6C0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x8B6E830
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x8B6E980
        public void __Set__SystemInt32_UnityEngineAnimatorTransitionInfo__SystemVoid(){} // RVA: 0x8B6EAB0
        public void __ToString__SystemString(){} // RVA: 0x8B6EBB0
        public void __ctor__SystemInt32__UnityEngineAnimatorTransitionInfoArray(){} // RVA: 0x8B6ECB0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x8B6EE50
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x8B6EEF0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x8B6EF90
        public void __get_Length__SystemInt32(){} // RVA: 0x8B6F030
        public void __get_LongLength__SystemInt64(){} // RVA: 0x8B6F0D0
        public void __get_Rank__SystemInt32(){} // RVA: 0x8B6F170
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x8B6F210
        public void <.ctor>b__6_1(){} // RVA: 0x8B6F2F0
    }

    public class ExternUnityEngineAnimatorUtility : Object
    {
        public object _parameterCounts;
        public object _functionDelegates;
        public object _componentGetter;
        public object _filter;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x8B71210
        public void .ctor(){} // RVA: 0x8B71250
        public void GetExternFunctionParameterCount(){} // RVA: 0x8B71620
        public void GetExternFunctionDelegate(){} // RVA: 0x8B71750
        public void __DeoptimizeTransformHierarchy__UnityEngineGameObject__SystemVoid(){} // RVA: 0x8B71860
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x8B719C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x8B71B10
        public void __GetType__SystemType(){} // RVA: 0x8B71C20
        public void __OptimizeTransformHierarchy__UnityEngineGameObject_SystemStringArray__SystemVoid(){} // RVA: 0x8B71D10
        public void __ToString__SystemString(){} // RVA: 0x8B71EA0
        public void __ctor____UnityEngineAnimatorUtility(){} // RVA: 0x8B71FA0
        public void <.ctor>b__6_1(){} // RVA: 0x8B72020
    }

}