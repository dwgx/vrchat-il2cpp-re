// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Wrapper.Modules
// Classes: 100
// Methods: 5520

namespace VRC.Udon.Wrapper.Modules
{
    public class ExternUnityEngineAvatar : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA766700
        public void .ctor(){} // RVA: 0x7FFACA766740
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA766B10
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA766C40
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA766D50
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA766F20
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA767080
        public void __GetType__SystemType(){} // RVA: 0x7FFACA7671D0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA7672C0
        public void __get_humanDescription__UnityEngineHumanDescription(){} // RVA: 0x7FFACA767410
        public void __get_isHuman__SystemBoolean(){} // RVA: 0x7FFACA767590
        public void __get_isValid__SystemBoolean(){} // RVA: 0x7FFACA7676B0
        public void __get_name__SystemString(){} // RVA: 0x7FFACA7677D0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA767920
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA767C20
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA767E10
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA768110
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA768260
    }

    public class ExternUnityEngineAvatarArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA768DF0
        public void .ctor(){} // RVA: 0x7FFACA768E30
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA769200
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA769330
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA769440
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA769520
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA769600
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA7696D0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA769820
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA7698C0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA7699C0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA769AE0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA769BF0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA769D10
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA769E00
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA769EE0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA76A000
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA76A190
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA76A2E0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA76A410
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA76A530
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA76A6A0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA76A7E0
        public void __Get__SystemInt32__UnityEngineAvatar(){} // RVA: 0x7FFACA76A900
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA76AA40
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA76AAB0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA76ABD0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA76AD50
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA76AEB0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA76AFE0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA76B100
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA76B260
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA76B3B0
        public void __Set__SystemInt32_UnityEngineAvatar__SystemVoid(){} // RVA: 0x7FFACA76B4D0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA76B690
        public void __ctor__SystemInt32__UnityEngineAvatarArray(){} // RVA: 0x7FFACA76B780
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA76B930
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA76B9D0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA76BA70
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA76BB10
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA76BBB0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA76BC50
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA76BCF0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA76BDD0
    }

    public class ExternUnityEngineAvatarBuilder : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA76DCF0
        public void .ctor(){} // RVA: 0x7FFACA76DD30
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA76E100
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA76E230
        public void __BuildGenericAvatar__UnityEngineGameObject_SystemString__UnityEngineAvatar(){} // RVA: 0x7FFACA76E340
        public void __BuildHumanAvatar__UnityEngineGameObject_UnityEngineHumanDescription__UnityEngineAvatar(){} // RVA: 0x7FFACA76E4C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA76E790
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA76E8E0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA76E9E0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA76EAD0
        public void __ctor____UnityEngineAvatarBuilder(){} // RVA: 0x7FFACA76EBC0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA76EC40
    }

    public class ExternUnityEngineAvatarBuilderArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA76F360
        public void .ctor(){} // RVA: 0x7FFACA76F3A0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA76F770
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA76F8A0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA76F9B0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA76FA90
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA76FB70
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA76FC40
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA76FD90
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA76FE30
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA76FF30
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA770050
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA770160
        public void __GetType__SystemType(){} // RVA: 0x7FFACA770280
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA770370
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA770450
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA770570
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA770700
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA770850
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA770980
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA770AA0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA770C10
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA770D50
        public void __Get__SystemInt32__UnityEngineAvatarBuilder(){} // RVA: 0x7FFACA770E70
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA770F50
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA770FC0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7710E0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA771260
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7713C0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA7714F0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA771610
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA771770
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7718C0
        public void __Set__SystemInt32_UnityEngineAvatarBuilder__SystemVoid(){} // RVA: 0x7FFACA7719E0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA771C20
        public void __ctor__SystemInt32__UnityEngineAvatarBuilderArray(){} // RVA: 0x7FFACA771D10
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA771EB0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA771F50
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA771FF0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA772090
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA772130
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA7721D0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA772270
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA772350
    }

    public class ExternUnityEngineAvatarMask : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA774270
        public void .ctor(){} // RVA: 0x7FFACA7742B0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA774680
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA7747B0
        public void __AddTransformPath__UnityEngineTransform_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7748C0
        public void __AddTransformPath__UnityEngineTransform__SystemVoid(){} // RVA: 0x7FFACA774A00
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA774B50
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA774D20
        public void __GetHumanoidBodyPartActive__UnityEngineAvatarMaskBodyPart__SystemBoolean(){} // RVA: 0x7FFACA774E80
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA774FE0
        public void __GetTransformActive__SystemInt32__SystemBoolean(){} // RVA: 0x7FFACA775130
        public void __GetTransformPath__SystemInt32__SystemString(){} // RVA: 0x7FFACA775250
        public void __GetType__SystemType(){} // RVA: 0x7FFACA7753B0
        public void __RemoveTransformPath__UnityEngineTransform_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7754A0
        public void __RemoveTransformPath__UnityEngineTransform__SystemVoid(){} // RVA: 0x7FFACA7755E0
        public void __SetHumanoidBodyPartActive__UnityEngineAvatarMaskBodyPart_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA775730
        public void __SetTransformActive__SystemInt32_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA775850
        public void __SetTransformPath__SystemInt32_SystemString__SystemVoid(){} // RVA: 0x7FFACA7759C0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA775B10
        public void __get_name__SystemString(){} // RVA: 0x7FFACA775C60
        public void __get_transformCount__SystemInt32(){} // RVA: 0x7FFACA775DB0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA775ED0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA7761D0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA7763C0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA7766C0
        public void __set_transformCount__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA776810
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA776930
    }

    public class ExternUnityEngineAvatarMaskArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA777B80
        public void .ctor(){} // RVA: 0x7FFACA777BC0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA777F90
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA7780C0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA7781D0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7782B0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA778390
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA778460
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA7785B0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA778650
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA778750
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA778870
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA778980
        public void __GetType__SystemType(){} // RVA: 0x7FFACA778AA0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA778B90
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA778C70
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA778D90
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA778F20
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA779070
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA7791A0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA7792C0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA779430
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA779570
        public void __Get__SystemInt32__UnityEngineAvatarMask(){} // RVA: 0x7FFACA779690
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA7798A0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA779910
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA779A30
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA779BB0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA779D10
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA779E40
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA779F60
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA77A0C0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA77A210
        public void __Set__SystemInt32_UnityEngineAvatarMask__SystemVoid(){} // RVA: 0x7FFACA77A330
        public void __ToString__SystemString(){} // RVA: 0x7FFACA77A4C0
        public void __ctor__SystemInt32__UnityEngineAvatarMaskArray(){} // RVA: 0x7FFACA77A5B0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA77A760
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA77A800
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA77A8A0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA77A940
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA77A9E0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA77AA80
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA77AB20
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA77AC00
    }

    public class ExternUnityEngineBehaviour : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA77CB20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA77CB60
        public void .ctor(){} // RVA: 0x7FFACA77CC10
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA77CFE0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA77D110
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA77D220
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA77D310
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA77D5C0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA77D720
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA77D840
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA77D930
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA77DBB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA77DCA0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA77DF50
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA77E0B0
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA77E1D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA77E2C0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA77E540
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA77E6B0
        public void __GetComponent__T(){} // RVA: 0x7FFACA77E7D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA77E8B0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA77EB00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA77EBF0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA77EF20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA77F010
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA77F350
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA77F440
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA77F750
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA77F8C0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA77F9F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA77FAE0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA77FDD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA77FEC0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA780200
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA7802F0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA780600
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA780770
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA7808B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA7809A0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA780C90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA780D80
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA781070
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA7811C0
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA7812F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA7813E0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA781690
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACA7817B0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA7818D0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA781BD0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA781DC0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7820C0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA7821F0
    }

    public class ExternUnityEngineBehaviourArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA783BD0
        public void .ctor(){} // RVA: 0x7FFACA783C10
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA783FE0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA784110
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA784220
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA784300
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7843E0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA7844B0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA784600
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA7846A0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA7847A0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA7848C0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA7849D0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA784AF0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA784BE0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA784CC0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA784DE0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA784F70
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA7850C0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA7851F0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA785310
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA785480
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA7855C0
        public void __Get__SystemInt32__UnityEngineBehaviour(){} // RVA: 0x7FFACA7856E0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA785820
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA785890
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7859B0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA785B30
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA785C90
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA785DC0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA785EE0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA786040
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA786190
        public void __Set__SystemInt32_UnityEngineBehaviour__SystemVoid(){} // RVA: 0x7FFACA7862B0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA786470
        public void __ctor__SystemInt32__UnityEngineBehaviourArray(){} // RVA: 0x7FFACA786560
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA786650
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA7866F0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA786790
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA786830
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA7868D0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA786970
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA786A10
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA786AF0
    }

    public class ExternUnityEngineBillboardRenderer : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA788A10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA788A50
        public void .ctor(){} // RVA: 0x7FFACA788B00
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA788ED0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA789000
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA789110
        public void __GetClosestReflectionProbes__SystemCollectionsGenericListUnityEngineRenderingReflectionProbeBlendInfo__SystemVoid(){} // RVA: 0x7FFACA7892E0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA789400
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA7894F0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA7897A0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA789900
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA789A20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA789B10
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA789D90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA789E80
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA78A130
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA78A290
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA78A3B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA78A4A0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA78A720
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA78A890
        public void __GetComponent__T(){} // RVA: 0x7FFACA78A9B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA78AA90
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA78ACE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA78ADD0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA78B100
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA78B1F0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA78B530
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA78B620
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA78B930
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA78BAA0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA78BBD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA78BCC0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA78BFB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA78C0A0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA78C3E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA78C4D0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA78C7E0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA78C950
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA78CA90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA78CB80
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA78CE70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA78CF60
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA78D250
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA78D3A0
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA78D4D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA78D5C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA78D870
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA78D9D0
        public void __GetMaterials__SystemCollectionsGenericListUnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACA78DB20
        public void __GetPropertyBlock__UnityEngineMaterialPropertyBlock_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA78DC40
        public void __GetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemVoid(){} // RVA: 0x7FFACA78DD50
        public void __GetSharedMaterials__SystemCollectionsGenericListUnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACA78DE70
        public void __GetType__SystemType(){} // RVA: 0x7FFACA78DF90
        public void __HasPropertyBlock__SystemBoolean(){} // RVA: 0x7FFACA78E080
        public void __ResetBounds__SystemVoid(){} // RVA: 0x7FFACA78E1A0
        public void __ResetLocalBounds__SystemVoid(){} // RVA: 0x7FFACA78E290
        public void __SetMaterials__SystemCollectionsGenericListUnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACA78E380
        public void __SetPropertyBlock__UnityEngineMaterialPropertyBlock_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA78E550
        public void __SetPropertyBlock__UnityEngineMaterialPropertyBlock__SystemVoid(){} // RVA: 0x7FFACA78E660
        public void __SetSharedMaterials__SystemCollectionsGenericListUnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACA78E780
        public void __ToString__SystemString(){} // RVA: 0x7FFACA78E950
        public void __get_allowOcclusionWhenDynamic__SystemBoolean(){} // RVA: 0x7FFACA78EAA0
        public void __get_billboard__UnityEngineBillboardAsset(){} // RVA: 0x7FFACA78EBC0
        public void __get_bounds__UnityEngineBounds(){} // RVA: 0x7FFACA78EDD0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA78EF20
        public void __get_forceRenderingOff__SystemBoolean(){} // RVA: 0x7FFACA78F040
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA78F160
        public void __get_isPartOfStaticBatch__SystemBoolean(){} // RVA: 0x7FFACA78F2A0
        public void __get_isVisible__SystemBoolean(){} // RVA: 0x7FFACA78F3C0
        public void __get_lightProbeProxyVolumeOverride__UnityEngineGameObject(){} // RVA: 0x7FFACA78F4E0
        public void __get_lightProbeUsage__UnityEngineRenderingLightProbeUsage(){} // RVA: 0x7FFACA78F620
        public void __get_lightmapIndex__SystemInt32(){} // RVA: 0x7FFACA78F740
        public void __get_lightmapScaleOffset__UnityEngineVector4(){} // RVA: 0x7FFACA78F860
        public void __get_localBounds__UnityEngineBounds(){} // RVA: 0x7FFACA78F9A0
        public void __get_localToWorldMatrix__UnityEngineMatrix4x4(){} // RVA: 0x7FFACA78FAF0
        public void __get_material__UnityEngineMaterial(){} // RVA: 0x7FFACA78FC70
        public void __get_materials__UnityEngineMaterialArray(){} // RVA: 0x7FFACA78FDB0
        public void __get_motionVectorGenerationMode__UnityEngineMotionVectorGenerationMode(){} // RVA: 0x7FFACA78FEF0
        public void __get_name__SystemString(){} // RVA: 0x7FFACA790010
        public void __get_probeAnchor__UnityEngineTransform(){} // RVA: 0x7FFACA790160
        public void __get_realtimeLightmapIndex__SystemInt32(){} // RVA: 0x7FFACA7902A0
        public void __get_realtimeLightmapScaleOffset__UnityEngineVector4(){} // RVA: 0x7FFACA7903D0
        public void __get_receiveShadows__SystemBoolean(){} // RVA: 0x7FFACA790510
        public void __get_reflectionProbeUsage__UnityEngineRenderingReflectionProbeUsage(){} // RVA: 0x7FFACA790630
        public void __get_rendererPriority__SystemInt32(){} // RVA: 0x7FFACA790750
        public void __get_renderingLayerMask__SystemUInt32(){} // RVA: 0x7FFACA790870
        public void __get_shadowCastingMode__UnityEngineRenderingShadowCastingMode(){} // RVA: 0x7FFACA790990
        public void __get_sharedMaterial__UnityEngineMaterial(){} // RVA: 0x7FFACA790AB0
        public void __get_sharedMaterials__UnityEngineMaterialArray(){} // RVA: 0x7FFACA790BF0
        public void __get_sortingLayerID__SystemInt32(){} // RVA: 0x7FFACA790D30
        public void __get_sortingLayerName__SystemString(){} // RVA: 0x7FFACA790E50
        public void __get_sortingOrder__SystemInt32(){} // RVA: 0x7FFACA790F70
        public void __get_staticShadowCaster__SystemBoolean(){} // RVA: 0x7FFACA791090
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA7911B0
        public void __get_worldToLocalMatrix__UnityEngineMatrix4x4(){} // RVA: 0x7FFACA7912F0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA791470
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA791770
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA791960
        public void __set_allowOcclusionWhenDynamic__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA791C60
        public void __set_billboard__UnityEngineBillboardAsset__SystemVoid(){} // RVA: 0x7FFACA791D90
        public void __set_bounds__UnityEngineBounds__SystemVoid(){} // RVA: 0x7FFACA791FA0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7920E0
        public void __set_forceRenderingOff__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA792210
        public void __set_lightProbeProxyVolumeOverride__UnityEngineGameObject__SystemVoid(){} // RVA: 0x7FFACA792340
        public void __set_lightProbeUsage__UnityEngineRenderingLightProbeUsage__SystemVoid(){} // RVA: 0x7FFACA792490
        public void __set_lightmapIndex__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7925B0
        public void __set_lightmapScaleOffset__UnityEngineVector4__SystemVoid(){} // RVA: 0x7FFACA7926E0
        public void __set_localBounds__UnityEngineBounds__SystemVoid(){} // RVA: 0x7FFACA792810
        public void __set_material__UnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACA792950
        public void __set_materials__UnityEngineMaterialArray__SystemVoid(){} // RVA: 0x7FFACA792AA0
        public void __set_motionVectorGenerationMode__UnityEngineMotionVectorGenerationMode__SystemVoid(){} // RVA: 0x7FFACA792BD0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA792CF0
        public void __set_probeAnchor__UnityEngineTransform__SystemVoid(){} // RVA: 0x7FFACA792E40
        public void __set_realtimeLightmapIndex__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA792F90
        public void __set_realtimeLightmapScaleOffset__UnityEngineVector4__SystemVoid(){} // RVA: 0x7FFACA7930C0
        public void __set_receiveShadows__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7931F0
        public void __set_reflectionProbeUsage__UnityEngineRenderingReflectionProbeUsage__SystemVoid(){} // RVA: 0x7FFACA793320
        public void __set_rendererPriority__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA793440
        public void __set_renderingLayerMask__SystemUInt32__SystemVoid(){} // RVA: 0x7FFACA793560
        public void __set_shadowCastingMode__UnityEngineRenderingShadowCastingMode__SystemVoid(){} // RVA: 0x7FFACA793680
        public void __set_sharedMaterial__UnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACA7937A0
        public void __set_sharedMaterials__UnityEngineMaterialArray__SystemVoid(){} // RVA: 0x7FFACA7938F0
        public void __set_sortingLayerID__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA793A20
        public void __set_sortingLayerName__SystemString__SystemVoid(){} // RVA: 0x7FFACA793B40
        public void __set_sortingOrder__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA793C60
        public void __set_staticShadowCaster__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA793D80
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA793EB0
    }

    public class ExternUnityEngineBillboardRendererArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA799190
        public void .ctor(){} // RVA: 0x7FFACA7991D0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA7995A0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA7996D0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA7997E0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7998C0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7999A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA799A70
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA799BC0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA799C60
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA799D60
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA799E80
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA799F90
        public void __GetType__SystemType(){} // RVA: 0x7FFACA79A0B0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA79A1A0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA79A280
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA79A3A0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA79A530
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA79A680
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA79A7B0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA79A8D0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA79AA40
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA79AB80
        public void __Get__SystemInt32__UnityEngineBillboardRenderer(){} // RVA: 0x7FFACA79ACA0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA79ADE0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA79AE50
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA79AF70
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA79B0F0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA79B250
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA79B380
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA79B4A0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA79B600
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA79B750
        public void __Set__SystemInt32_UnityEngineBillboardRenderer__SystemVoid(){} // RVA: 0x7FFACA79B870
        public void __ToString__SystemString(){} // RVA: 0x7FFACA79BA00
        public void __ctor__SystemInt32__UnityEngineBillboardRendererArray(){} // RVA: 0x7FFACA79BAF0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA79BBE0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA79BC80
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA79BD20
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA79BDC0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA79BE60
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA79BF00
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA79BFA0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA79C080
    }

    public class ExternUnityEngineBounds : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA79DFA0
        public void .ctor(){} // RVA: 0x7FFACA79DFE0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA79E3B0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA79E4E0
        public void __ClosestPoint__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACA79E5F0
        public void __Contains__UnityEngineVector3__SystemBoolean(){} // RVA: 0x7FFACA79E760
        public void __Encapsulate__UnityEngineBounds__SystemVoid(){} // RVA: 0x7FFACA79E8B0
        public void __Encapsulate__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA79E930
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA79E9D0
        public void __Equals__UnityEngineBounds__SystemBoolean(){} // RVA: 0x7FFACA79EB00
        public void __Expand__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA79EC50
        public void __Expand__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA79ECF0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA79ED90
        public void __GetType__SystemType(){} // RVA: 0x7FFACA79EE50
        public void __IntersectRay__UnityEngineRay_SystemSingleRef__SystemBoolean(){} // RVA: 0x7FFACA79EF40
        public void __IntersectRay__UnityEngineRay__SystemBoolean(){} // RVA: 0x7FFACA79F110
        public void __Intersects__UnityEngineBounds__SystemBoolean(){} // RVA: 0x7FFACA79F290
        public void __SetMinMax__UnityEngineVector3_UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA79F420
        public void __SqrDistance__UnityEngineVector3__SystemSingle(){} // RVA: 0x7FFACA79F4D0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA79F620
        public void __ToString__SystemString_SystemIFormatProvider__SystemString(){} // RVA: 0x7FFACA79F6D0
        public void __ToString__SystemString__SystemString(){} // RVA: 0x7FFACA79F7F0
        public void __ctor__UnityEngineVector3_UnityEngineVector3__UnityEngineBounds(){} // RVA: 0x7FFACA79F8D0
        public void __get_center__UnityEngineVector3(){} // RVA: 0x7FFACA79F9F0
        public void __get_extents__UnityEngineVector3(){} // RVA: 0x7FFACA79FAA0
        public void __get_max__UnityEngineVector3(){} // RVA: 0x7FFACA79FB60
        public void __get_min__UnityEngineVector3(){} // RVA: 0x7FFACA79FC40
        public void __get_size__UnityEngineVector3(){} // RVA: 0x7FFACA79FD20
        public void __op_Equality__UnityEngineBounds_UnityEngineBounds__SystemBoolean(){} // RVA: 0x7FFACA79FDF0
        public void __op_Inequality__UnityEngineBounds_UnityEngineBounds__SystemBoolean(){} // RVA: 0x7FFACA79FF70
        public void __set_center__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA7A00F0
        public void __set_extents__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA7A01F0
        public void __set_max__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA7A02F0
        public void __set_min__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA7A0480
        public void __set_size__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA7A0610
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA7A0730
    }

    public class ExternUnityEngineBoundsArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA7A2050
        public void .ctor(){} // RVA: 0x7FFACA7A2090
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA7A2460
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA7A2590
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA7A26A0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7A2780
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7A2860
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA7A2930
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA7A2A80
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA7A2B20
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA7A2C20
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA7A2D40
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA7A2E50
        public void __GetType__SystemType(){} // RVA: 0x7FFACA7A2F70
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA7A3060
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA7A3140
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA7A3260
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA7A33F0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA7A3540
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA7A3670
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA7A3790
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA7A3900
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA7A3A40
        public void __Get__SystemInt32__UnityEngineBounds(){} // RVA: 0x7FFACA7A3B60
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA7A3C60
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA7A3CD0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7A3DF0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7A3F70
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7A40D0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA7A4200
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7A4320
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7A4480
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7A45D0
        public void __Set__SystemInt32_UnityEngineBounds__SystemVoid(){} // RVA: 0x7FFACA7A46F0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA7A4800
        public void __ctor__SystemInt32__UnityEngineBoundsArray(){} // RVA: 0x7FFACA7A48F0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA7A4A90
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA7A4B30
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA7A4BD0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA7A4C70
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA7A4D10
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA7A4DB0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA7A4E50
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA7A4F30
    }

    public class ExternUnityEngineBoxCollider : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA7A6E50
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA7A6E90
        public void .ctor(){} // RVA: 0x7FFACA7A6F40
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA7A7310
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA7A7440
        public void __ClosestPointOnBounds__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACA7A7550
        public void __ClosestPoint__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACA7A7740
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA7A78D0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA7A7AA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA7A7B90
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA7A7E40
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA7A7FA0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA7A80C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA7A81B0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA7A8430
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA7A8520
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA7A87D0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA7A8930
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA7A8A50
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA7A8B40
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA7A8DC0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA7A8F30
        public void __GetComponent__T(){} // RVA: 0x7FFACA7A9050
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA7A9130
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA7A9380
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA7A9470
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA7A97A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA7A9890
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA7A9BD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA7A9CC0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA7A9FD0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA7AA140
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA7AA270
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA7AA360
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA7AA650
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA7AA740
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA7AAA80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA7AAB70
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA7AAE80
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA7AAFF0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA7AB130
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA7AB220
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA7AB510
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA7AB600
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA7AB8F0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA7ABA40
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA7ABB70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA7ABC60
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA7ABF10
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA7AC070
        public void __GetType__SystemType(){} // RVA: 0x7FFACA7AC1C0
        public void __Raycast__UnityEngineRay_UnityEngineRaycastHitRef_SystemSingle__SystemBoolean(){} // RVA: 0x7FFACA7AC2B0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA7AC500
        public void __get_attachedArticulationBody__UnityEngineArticulationBody(){} // RVA: 0x7FFACA7AC650
        public void __get_attachedRigidbody__UnityEngineRigidbody(){} // RVA: 0x7FFACA7AC790
        public void __get_bounds__UnityEngineBounds(){} // RVA: 0x7FFACA7AC8D0
        public void __get_center__UnityEngineVector3(){} // RVA: 0x7FFACA7ACA20
        public void __get_contactOffset__SystemSingle(){} // RVA: 0x7FFACA7ACB60
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA7ACC80
        public void __get_excludeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA7ACDA0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA7ACED0
        public void __get_hasModifiableContacts__SystemBoolean(){} // RVA: 0x7FFACA7AD010
        public void __get_includeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA7AD130
        public void __get_isTrigger__SystemBoolean(){} // RVA: 0x7FFACA7AD260
        public void __get_layerOverridePriority__SystemInt32(){} // RVA: 0x7FFACA7AD380
        public void __get_material__UnityEnginePhysicMaterial(){} // RVA: 0x7FFACA7AD4A0
        public void __get_name__SystemString(){} // RVA: 0x7FFACA7AD5E0
        public void __get_providesContacts__SystemBoolean(){} // RVA: 0x7FFACA7AD730
        public void __get_sharedMaterial__UnityEnginePhysicMaterial(){} // RVA: 0x7FFACA7AD850
        public void __get_size__UnityEngineVector3(){} // RVA: 0x7FFACA7AD990
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA7ADAD0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA7ADC10
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA7ADF10
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA7AE100
        public void __set_center__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA7AE400
        public void __set_contactOffset__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7AE540
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7AE670
        public void __set_excludeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA7AE7A0
        public void __set_hasModifiableContacts__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7AE8C0
        public void __set_includeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA7AE9F0
        public void __set_isTrigger__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7AEB10
        public void __set_layerOverridePriority__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7AEC40
        public void __set_material__UnityEnginePhysicMaterial__SystemVoid(){} // RVA: 0x7FFACA7AED60
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA7AEEB0
        public void __set_providesContacts__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7AF000
        public void __set_sharedMaterial__UnityEnginePhysicMaterial__SystemVoid(){} // RVA: 0x7FFACA7AF130
        public void __set_size__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA7AF280
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA7AF3C0
    }

    public class ExternUnityEngineBoxCollider2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA7B2890
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA7B28D0
        public void .ctor(){} // RVA: 0x7FFACA7B2980
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA7B2D50
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA7B2E80
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D_SystemSingle_SystemBoolean__SystemInt32(){} // RVA: 0x7FFACA7B2F90
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle_SystemBoolean__SystemInt32(){} // RVA: 0x7FFACA7B3260
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA7B3530
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA7B37B0
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemBoolean__SystemInt32(){} // RVA: 0x7FFACA7B39F0
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA7B3BC0
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA7B3D50
        public void __ClosestPoint__UnityEngineVector2__UnityEngineVector2(){} // RVA: 0x7FFACA7B3EA0
        public void __CreateMesh__SystemBoolean_SystemBoolean__UnityEngineMesh(){} // RVA: 0x7FFACA7B4000
        public void __Distance__UnityEngineCollider2D__UnityEngineColliderDistance2D(){} // RVA: 0x7FFACA7B4160
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA7B42F0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA7B44C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA7B45B0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA7B4860
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA7B49C0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA7B4AE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA7B4BD0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA7B4E50
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA7B4F40
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA7B51F0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA7B5350
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA7B5470
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA7B5560
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA7B57E0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA7B5950
        public void __GetComponent__T(){} // RVA: 0x7FFACA7B5A70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA7B5B50
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA7B5DA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA7B5E90
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA7B61C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA7B62B0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA7B65F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA7B66E0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA7B69F0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA7B6B60
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA7B6C90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA7B6D80
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA7B7070
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA7B7160
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA7B74A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA7B7590
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA7B78A0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA7B7A10
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA7B7B50
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA7B7C40
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA7B7F30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA7B8020
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA7B8310
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA7B8460
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA7B8590
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA7B8680
        public void __GetContacts__SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACA7B8930
        public void __GetContacts__SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACA7B8A80
        public void __GetContacts__UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACA7B8B90
        public void __GetContacts__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACA7B8CE0
        public void __GetContacts__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACA7B8F10
        public void __GetContacts__UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACA7B90F0
        public void __GetContacts__UnityEngineContactFilter2D_UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACA7B9320
        public void __GetContacts__UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACA7B9500
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA7B9610
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA7B9770
        public void __GetShapeHash__SystemUInt32(){} // RVA: 0x7FFACA7B98C0
        public void __GetShapes__UnityEnginePhysicsShapeGroup2D_SystemInt32_SystemInt32__SystemInt32(){} // RVA: 0x7FFACA7B99E0
        public void __GetShapes__UnityEnginePhysicsShapeGroup2D__SystemInt32(){} // RVA: 0x7FFACA7B9B60
        public void __GetType__SystemType(){} // RVA: 0x7FFACA7B9CE0
        public void __IsTouchingLayers__SystemBoolean(){} // RVA: 0x7FFACA7B9DD0
        public void __IsTouchingLayers__SystemInt32__SystemBoolean(){} // RVA: 0x7FFACA7B9F00
        public void __IsTouching__UnityEngineCollider2D_UnityEngineContactFilter2D__SystemBoolean(){} // RVA: 0x7FFACA7BA060
        public void __IsTouching__UnityEngineCollider2D__SystemBoolean(){} // RVA: 0x7FFACA7BA220
        public void __IsTouching__UnityEngineContactFilter2D__SystemBoolean(){} // RVA: 0x7FFACA7BA380
        public void __OverlapCollider__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACA7BA500
        public void __OverlapCollider__UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACA7BA730
        public void __OverlapPoint__UnityEngineVector2__SystemBoolean(){} // RVA: 0x7FFACA7BA960
        public void __Raycast__UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA7BAAC0
        public void __Raycast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA7BAD30
        public void __Raycast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA7BAFA0
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA7BB1D0
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA7BB420
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32__SystemInt32(){} // RVA: 0x7FFACA7BB630
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA7BB800
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA7BB990
        public void __ToString__SystemString(){} // RVA: 0x7FFACA7BBAE0
        public void __get_attachedRigidbody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACA7BBC30
        public void __get_autoTiling__SystemBoolean(){} // RVA: 0x7FFACA7BBD70
        public void __get_bounciness__SystemSingle(){} // RVA: 0x7FFACA7BBE90
        public void __get_bounds__UnityEngineBounds(){} // RVA: 0x7FFACA7BBFB0
        public void __get_callbackLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA7BC100
        public void __get_composite__UnityEngineCompositeCollider2D(){} // RVA: 0x7FFACA7BC230
        public void __get_contactCaptureLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA7BC370
        public void __get_density__SystemSingle(){} // RVA: 0x7FFACA7BC4A0
        public void __get_edgeRadius__SystemSingle(){} // RVA: 0x7FFACA7BC5C0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA7BC6E0
        public void __get_errorState__UnityEngineColliderErrorState2D(){} // RVA: 0x7FFACA7BC800
        public void __get_excludeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA7BC920
        public void __get_forceReceiveLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA7BCA50
        public void __get_forceSendLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA7BCB80
        public void __get_friction__SystemSingle(){} // RVA: 0x7FFACA7BCCB0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA7BCDD0
        public void __get_includeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA7BCF10
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACA7BD040
        public void __get_isTrigger__SystemBoolean(){} // RVA: 0x7FFACA7BD160
        public void __get_layerOverridePriority__SystemInt32(){} // RVA: 0x7FFACA7BD280
        public void __get_name__SystemString(){} // RVA: 0x7FFACA7BD3A0
        public void __get_offset__UnityEngineVector2(){} // RVA: 0x7FFACA7BD4F0
        public void __get_shapeCount__SystemInt32(){} // RVA: 0x7FFACA7BD620
        public void __get_sharedMaterial__UnityEnginePhysicsMaterial2D(){} // RVA: 0x7FFACA7BD740
        public void __get_size__UnityEngineVector2(){} // RVA: 0x7FFACA7BD880
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA7BD9B0
        public void __get_usedByComposite__SystemBoolean(){} // RVA: 0x7FFACA7BDAF0
        public void __get_usedByEffector__SystemBoolean(){} // RVA: 0x7FFACA7BDC10
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA7BDD30
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA7BE030
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA7BE220
        public void __set_autoTiling__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7BE520
        public void __set_callbackLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA7BE650
        public void __set_contactCaptureLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA7BE770
        public void __set_density__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7BE890
        public void __set_edgeRadius__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7BE9C0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7BEAF0
        public void __set_excludeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA7BEC20
        public void __set_forceReceiveLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA7BED40
        public void __set_forceSendLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA7BEE60
        public void __set_includeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA7BEF80
        public void __set_isTrigger__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7BF0A0
        public void __set_layerOverridePriority__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7BF1D0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA7BF2F0
        public void __set_offset__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA7BF440
        public void __set_sharedMaterial__UnityEnginePhysicsMaterial2D__SystemVoid(){} // RVA: 0x7FFACA7BF560
        public void __set_size__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA7BF6B0
        public void __set_usedByComposite__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7BF7D0
        public void __set_usedByEffector__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7BF900
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA7BFA30
    }

    public class ExternUnityEngineBoxCollider2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA7C53D0
        public void .ctor(){} // RVA: 0x7FFACA7C5410
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA7C57E0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA7C5910
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA7C5A20
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7C5B00
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7C5BE0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA7C5CB0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA7C5E00
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA7C5EA0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA7C5FA0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA7C60C0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA7C61D0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA7C62F0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA7C63E0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA7C64C0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA7C65E0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA7C6770
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA7C68C0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA7C69F0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA7C6B10
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA7C6C80
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA7C6DC0
        public void __Get__SystemInt32__UnityEngineBoxCollider2D(){} // RVA: 0x7FFACA7C6EE0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA7C7020
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA7C7090
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7C71B0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7C7330
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7C7490
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA7C75C0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7C76E0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7C7840
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7C7990
        public void __Set__SystemInt32_UnityEngineBoxCollider2D__SystemVoid(){} // RVA: 0x7FFACA7C7AB0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA7C7C40
        public void __ctor__SystemInt32__UnityEngineBoxCollider2DArray(){} // RVA: 0x7FFACA7C7D30
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA7C7E20
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA7C7EC0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA7C7F60
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA7C8000
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA7C80A0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA7C8140
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA7C81E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA7C82C0
    }

    public class ExternUnityEngineBoxColliderArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA7CA1E0
        public void .ctor(){} // RVA: 0x7FFACA7CA220
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA7CA5F0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA7CA720
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA7CA830
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7CA910
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7CA9F0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA7CAAC0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA7CAC10
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA7CACB0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA7CADB0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA7CAED0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA7CAFE0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA7CB100
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA7CB1F0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA7CB2D0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA7CB3F0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA7CB580
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA7CB6D0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA7CB800
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA7CB920
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA7CBA90
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA7CBBD0
        public void __Get__SystemInt32__UnityEngineBoxCollider(){} // RVA: 0x7FFACA7CBCF0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA7CBE30
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA7CBEA0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7CBFC0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7CC140
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7CC2A0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA7CC3D0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7CC4F0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7CC650
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7CC7A0
        public void __Set__SystemInt32_UnityEngineBoxCollider__SystemVoid(){} // RVA: 0x7FFACA7CC8C0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA7CCA80
        public void __ctor__SystemInt32__UnityEngineBoxColliderArray(){} // RVA: 0x7FFACA7CCB70
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA7CCC60
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA7CCD00
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA7CCDA0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA7CCE40
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA7CCEE0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA7CCF80
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA7CD020
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA7CD100
    }

    public class ExternUnityEngineCamera : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA7CF020
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA7CF060
        public void .ctor(){} // RVA: 0x7FFACA7CF110
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA7CF4E0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA7CF610
        public void __CalculateFrustumCorners__UnityEngineRect_SystemSingle_UnityEngineCameraMonoOrStereoscopicEye_UnityEngineVector3Array__SystemVoid(){} // RVA: 0x7FFACA7CF720
        public void __CalculateObliqueMatrix__UnityEngineVector4__UnityEngineMatrix4x4(){} // RVA: 0x7FFACA7CF9C0
        public void __CalculateProjectionMatrixFromPhysicalProperties__UnityEngineMatrix4x4Ref_SystemSingle_UnityEngineVector2_UnityEngineVector2_SystemSingle_SystemSingle_UnityEngineCameraGateFitParameters__SystemVoid(){} // RVA: 0x7FFACA7CFB80
        public void __CopyFrom__UnityEngineCamera__SystemVoid(){} // RVA: 0x7FFACA7CFE40
        public void __CopyStereoDeviceProjectionMatrixToNonJittered__UnityEngineCameraStereoscopicEye__SystemVoid(){} // RVA: 0x7FFACA7CFF70
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA7D0090
        public void __FieldOfViewToFocalLength__SystemSingle_SystemSingle__SystemSingle(){} // RVA: 0x7FFACA7D0260
        public void __FocalLengthToFieldOfView__SystemSingle_SystemSingle__SystemSingle(){} // RVA: 0x7FFACA7D0330
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA7D0450
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA7D0540
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA7D07F0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA7D0950
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA7D0A70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA7D0B60
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA7D0DE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA7D0ED0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA7D1180
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA7D12E0
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA7D1400
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA7D14F0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA7D1770
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA7D18E0
        public void __GetComponent__T(){} // RVA: 0x7FFACA7D1A00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA7D1AE0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA7D1D30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA7D1E20
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA7D2150
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA7D2240
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA7D2580
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA7D2670
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA7D2980
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA7D2AF0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA7D2C20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA7D2D10
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA7D3000
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA7D30F0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA7D3430
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA7D3520
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA7D3830
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA7D39A0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA7D3AE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA7D3BD0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA7D3EC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA7D3FB0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA7D42A0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA7D43F0
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA7D4520
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA7D4610
        public void __GetGateFittedFieldOfView__SystemSingle(){} // RVA: 0x7FFACA7D48C0
        public void __GetGateFittedLensShift__UnityEngineVector2(){} // RVA: 0x7FFACA7D49E0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA7D4B10
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA7D4C70
        public void __GetStereoNonJitteredProjectionMatrix__UnityEngineCameraStereoscopicEye__UnityEngineMatrix4x4(){} // RVA: 0x7FFACA7D4DC0
        public void __GetStereoProjectionMatrix__UnityEngineCameraStereoscopicEye__UnityEngineMatrix4x4(){} // RVA: 0x7FFACA7D4F80
        public void __GetStereoViewMatrix__UnityEngineCameraStereoscopicEye__UnityEngineMatrix4x4(){} // RVA: 0x7FFACA7D5140
        public void __GetType__SystemType(){} // RVA: 0x7FFACA7D5300
        public void __HorizontalToVerticalFieldOfView__SystemSingle_SystemSingle__SystemSingle(){} // RVA: 0x7FFACA7D53F0
        public void __RenderDontRestore__SystemVoid(){} // RVA: 0x7FFACA7D54C0
        public void __RenderToCubemap__UnityEngineCubemap_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACA7D55B0
        public void __RenderToCubemap__UnityEngineCubemap__SystemBoolean(){} // RVA: 0x7FFACA7D5720
        public void __RenderToCubemap__UnityEngineRenderTexture_SystemInt32_UnityEngineCameraMonoOrStereoscopicEye__SystemBoolean(){} // RVA: 0x7FFACA7D58B0
        public void __RenderToCubemap__UnityEngineRenderTexture_SystemInt32__SystemBoolean(){} // RVA: 0x7FFACA7D5A60
        public void __RenderToCubemap__UnityEngineRenderTexture__SystemBoolean(){} // RVA: 0x7FFACA7D5BD0
        public void __RenderWithShader__UnityEngineShader_SystemString__SystemVoid(){} // RVA: 0x7FFACA7D5D60
        public void __Render__SystemVoid(){} // RVA: 0x7FFACA7D5EE0
        public void __ResetAspect__SystemVoid(){} // RVA: 0x7FFACA7D5FD0
        public void __ResetCullingMatrix__SystemVoid(){} // RVA: 0x7FFACA7D60C0
        public void __ResetProjectionMatrix__SystemVoid(){} // RVA: 0x7FFACA7D61B0
        public void __ResetReplacementShader__SystemVoid(){} // RVA: 0x7FFACA7D62A0
        public void __ResetStereoProjectionMatrices__SystemVoid(){} // RVA: 0x7FFACA7D6390
        public void __ResetStereoViewMatrices__SystemVoid(){} // RVA: 0x7FFACA7D6480
        public void __ResetTransparencySortSettings__SystemVoid(){} // RVA: 0x7FFACA7D6570
        public void __ResetWorldToCameraMatrix__SystemVoid(){} // RVA: 0x7FFACA7D6660
        public void __Reset__SystemVoid(){} // RVA: 0x7FFACA7D6750
        public void __ScreenPointToRay__UnityEngineVector3_UnityEngineCameraMonoOrStereoscopicEye__UnityEngineRay(){} // RVA: 0x7FFACA7D6840
        public void __ScreenPointToRay__UnityEngineVector3__UnityEngineRay(){} // RVA: 0x7FFACA7D6A30
        public void __ScreenToViewportPoint__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACA7D6BE0
        public void __ScreenToWorldPoint__UnityEngineVector3_UnityEngineCameraMonoOrStereoscopicEye__UnityEngineVector3(){} // RVA: 0x7FFACA7D6D70
        public void __ScreenToWorldPoint__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACA7D6F40
        public void __SetReplacementShader__UnityEngineShader_SystemString__SystemVoid(){} // RVA: 0x7FFACA7D70D0
        public void __SetStereoProjectionMatrix__UnityEngineCameraStereoscopicEye_UnityEngineMatrix4x4__SystemVoid(){} // RVA: 0x7FFACA7D7200
        public void __SetStereoViewMatrix__UnityEngineCameraStereoscopicEye_UnityEngineMatrix4x4__SystemVoid(){} // RVA: 0x7FFACA7D73A0
        public void __SetTargetBuffers__UnityEngineRenderBufferArray_UnityEngineRenderBuffer__SystemVoid(){} // RVA: 0x7FFACA7D7540
        public void __SetTargetBuffers__UnityEngineRenderBuffer_UnityEngineRenderBuffer__SystemVoid(){} // RVA: 0x7FFACA7D76A0
        public void __SetupCurrent__UnityEngineCamera__SystemVoid(){} // RVA: 0x7FFACA7D7800
        public void __ToString__SystemString(){} // RVA: 0x7FFACA7D78E0
        public void __VerticalToHorizontalFieldOfView__SystemSingle_SystemSingle__SystemSingle(){} // RVA: 0x7FFACA7D7A30
        public void __ViewportPointToRay__UnityEngineVector3_UnityEngineCameraMonoOrStereoscopicEye__UnityEngineRay(){} // RVA: 0x7FFACA7D7B00
        public void __ViewportPointToRay__UnityEngineVector3__UnityEngineRay(){} // RVA: 0x7FFACA7D7CF0
        public void __ViewportToScreenPoint__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACA7D7EA0
        public void __ViewportToWorldPoint__UnityEngineVector3_UnityEngineCameraMonoOrStereoscopicEye__UnityEngineVector3(){} // RVA: 0x7FFACA7D8030
        public void __ViewportToWorldPoint__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACA7D8200
        public void __WorldToScreenPoint__UnityEngineVector3_UnityEngineCameraMonoOrStereoscopicEye__UnityEngineVector3(){} // RVA: 0x7FFACA7D8390
        public void __WorldToScreenPoint__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACA7D8560
        public void __WorldToViewportPoint__UnityEngineVector3_UnityEngineCameraMonoOrStereoscopicEye__UnityEngineVector3(){} // RVA: 0x7FFACA7D86F0
        public void __WorldToViewportPoint__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACA7D88C0
        public void __get_activeTexture__UnityEngineRenderTexture(){} // RVA: 0x7FFACA7D8A50
        public void __get_actualRenderingPath__UnityEngineRenderingPath(){} // RVA: 0x7FFACA7D8B90
        public void __get_allowDynamicResolution__SystemBoolean(){} // RVA: 0x7FFACA7D8CB0
        public void __get_allowHDR__SystemBoolean(){} // RVA: 0x7FFACA7D8DD0
        public void __get_allowMSAA__SystemBoolean(){} // RVA: 0x7FFACA7D8EF0
        public void __get_anamorphism__SystemSingle(){} // RVA: 0x7FFACA7D9010
        public void __get_aperture__SystemSingle(){} // RVA: 0x7FFACA7D9130
        public void __get_areVRStereoViewMatricesWithinSingleCullTolerance__SystemBoolean(){} // RVA: 0x7FFACA7D9250
        public void __get_aspect__SystemSingle(){} // RVA: 0x7FFACA7D9370
        public void __get_backgroundColor__UnityEngineColor(){} // RVA: 0x7FFACA7D9490
        public void __get_barrelClipping__SystemSingle(){} // RVA: 0x7FFACA7D95D0
        public void __get_bladeCount__SystemInt32(){} // RVA: 0x7FFACA7D96F0
        public void __get_cameraToWorldMatrix__UnityEngineMatrix4x4(){} // RVA: 0x7FFACA7D9810
        public void __get_cameraType__UnityEngineCameraType(){} // RVA: 0x7FFACA7D9990
        public void __get_clearFlags__UnityEngineCameraClearFlags(){} // RVA: 0x7FFACA7D9AB0
        public void __get_clearStencilAfterLightingPass__SystemBoolean(){} // RVA: 0x7FFACA7D9BD0
        public void __get_cullingMask__SystemInt32(){} // RVA: 0x7FFACA7D9CF0
        public void __get_cullingMatrix__UnityEngineMatrix4x4(){} // RVA: 0x7FFACA7D9E10
        public void __get_curvature__UnityEngineVector2(){} // RVA: 0x7FFACA7D9F90
        public void __get_depthTextureMode__UnityEngineDepthTextureMode(){} // RVA: 0x7FFACA7DA0C0
        public void __get_depth__SystemSingle(){} // RVA: 0x7FFACA7DA1E0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA7DA300
        public void __get_eventMask__SystemInt32(){} // RVA: 0x7FFACA7DA420
        public void __get_farClipPlane__SystemSingle(){} // RVA: 0x7FFACA7DA540
        public void __get_fieldOfView__SystemSingle(){} // RVA: 0x7FFACA7DA660
        public void __get_focalLength__SystemSingle(){} // RVA: 0x7FFACA7DA780
        public void __get_focusDistance__SystemSingle(){} // RVA: 0x7FFACA7DA8A0
        public void __get_forceIntoRenderTexture__SystemBoolean(){} // RVA: 0x7FFACA7DA9C0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA7DAAE0
        public void __get_gateFit__UnityEngineCameraGateFitMode(){} // RVA: 0x7FFACA7DAC20
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACA7DAD40
        public void __get_iso__SystemInt32(){} // RVA: 0x7FFACA7DAE60
        public void __get_kMaxAperture__SystemSingle(){} // RVA: 0x7FFACA7DAF80
        public void __get_kMaxBladeCount__SystemInt32(){} // RVA: 0x7FFACA7DAFF0
        public void __get_kMinAperture__SystemSingle(){} // RVA: 0x7FFACA7DB060
        public void __get_kMinBladeCount__SystemInt32(){} // RVA: 0x7FFACA7DB0D0
        public void __get_layerCullDistances__SystemSingleArray(){} // RVA: 0x7FFACA7DB140
        public void __get_layerCullSpherical__SystemBoolean(){} // RVA: 0x7FFACA7DB260
        public void __get_lensShift__UnityEngineVector2(){} // RVA: 0x7FFACA7DB380
        public void __get_name__SystemString(){} // RVA: 0x7FFACA7DB4B0
        public void __get_nearClipPlane__SystemSingle(){} // RVA: 0x7FFACA7DB600
        public void __get_nonJitteredProjectionMatrix__UnityEngineMatrix4x4(){} // RVA: 0x7FFACA7DB720
        public void __get_opaqueSortMode__UnityEngineRenderingOpaqueSortMode(){} // RVA: 0x7FFACA7DB8A0
        public void __get_orthographicSize__SystemSingle(){} // RVA: 0x7FFACA7DB9C0
        public void __get_orthographic__SystemBoolean(){} // RVA: 0x7FFACA7DBAE0
        public void __get_overrideSceneCullingMask__SystemUInt64(){} // RVA: 0x7FFACA7DBC00
        public void __get_pixelHeight__SystemInt32(){} // RVA: 0x7FFACA7DBD20
        public void __get_pixelRect__UnityEngineRect(){} // RVA: 0x7FFACA7DBE40
        public void __get_pixelWidth__SystemInt32(){} // RVA: 0x7FFACA7DBF80
        public void __get_previousViewProjectionMatrix__UnityEngineMatrix4x4(){} // RVA: 0x7FFACA7DC0A0
        public void __get_projectionMatrix__UnityEngineMatrix4x4(){} // RVA: 0x7FFACA7DC220
        public void __get_rect__UnityEngineRect(){} // RVA: 0x7FFACA7DC3A0
        public void __get_renderingPath__UnityEngineRenderingPath(){} // RVA: 0x7FFACA7DC4E0
        public void __get_scaledPixelHeight__SystemInt32(){} // RVA: 0x7FFACA7DC600
        public void __get_scaledPixelWidth__SystemInt32(){} // RVA: 0x7FFACA7DC720
        public void __get_sensorSize__UnityEngineVector2(){} // RVA: 0x7FFACA7DC840
        public void __get_shutterSpeed__SystemSingle(){} // RVA: 0x7FFACA7DC970
        public void __get_stereoActiveEye__UnityEngineCameraMonoOrStereoscopicEye(){} // RVA: 0x7FFACA7DCA90
        public void __get_stereoConvergence__SystemSingle(){} // RVA: 0x7FFACA7DCBB0
        public void __get_stereoEnabled__SystemBoolean(){} // RVA: 0x7FFACA7DCCD0
        public void __get_stereoSeparation__SystemSingle(){} // RVA: 0x7FFACA7DCDF0
        public void __get_stereoTargetEye__UnityEngineStereoTargetEyeMask(){} // RVA: 0x7FFACA7DCF10
        public void __get_targetDisplay__SystemInt32(){} // RVA: 0x7FFACA7DD030
        public void __get_targetTexture__UnityEngineRenderTexture(){} // RVA: 0x7FFACA7DD150
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA7DD290
        public void __get_transparencySortAxis__UnityEngineVector3(){} // RVA: 0x7FFACA7DD3D0
        public void __get_transparencySortMode__UnityEngineTransparencySortMode(){} // RVA: 0x7FFACA7DD510
        public void __get_useJitteredProjectionMatrixForTransparentRendering__SystemBoolean(){} // RVA: 0x7FFACA7DD630
        public void __get_useOcclusionCulling__SystemBoolean(){} // RVA: 0x7FFACA7DD750
        public void __get_usePhysicalProperties__SystemBoolean(){} // RVA: 0x7FFACA7DD870
        public void __get_velocity__UnityEngineVector3(){} // RVA: 0x7FFACA7DD990
        public void __get_worldToCameraMatrix__UnityEngineMatrix4x4(){} // RVA: 0x7FFACA7DDAD0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA7DDC50
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA7DDF50
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA7DE140
        public void __set_allowDynamicResolution__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7DE440
        public void __set_allowHDR__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7DE570
        public void __set_allowMSAA__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7DE6A0
        public void __set_anamorphism__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7DE7D0
        public void __set_aperture__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7DE900
        public void __set_aspect__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7DEA30
        public void __set_backgroundColor__UnityEngineColor__SystemVoid(){} // RVA: 0x7FFACA7DEB60
        public void __set_barrelClipping__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7DEC90
        public void __set_bladeCount__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7DEDC0
        public void __set_cameraType__UnityEngineCameraType__SystemVoid(){} // RVA: 0x7FFACA7DEEE0
        public void __set_clearFlags__UnityEngineCameraClearFlags__SystemVoid(){} // RVA: 0x7FFACA7DF000
        public void __set_clearStencilAfterLightingPass__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7DF120
        public void __set_cullingMask__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7DF250
        public void __set_cullingMatrix__UnityEngineMatrix4x4__SystemVoid(){} // RVA: 0x7FFACA7DF370
        public void __set_curvature__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA7DF4D0
        public void __set_depthTextureMode__UnityEngineDepthTextureMode__SystemVoid(){} // RVA: 0x7FFACA7DF5F0
        public void __set_depth__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7DF710
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7DF840
        public void __set_eventMask__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7DF970
        public void __set_farClipPlane__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7DFA90
        public void __set_fieldOfView__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7DFBC0
        public void __set_focalLength__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7DFCF0
        public void __set_focusDistance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7DFE20
        public void __set_forceIntoRenderTexture__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7DFF50
        public void __set_gateFit__UnityEngineCameraGateFitMode__SystemVoid(){} // RVA: 0x7FFACA7E0080
        public void __set_iso__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7E01A0
        public void __set_layerCullDistances__SystemSingleArray__SystemVoid(){} // RVA: 0x7FFACA7E02C0
        public void __set_layerCullSpherical__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7E03A0
        public void __set_lensShift__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA7E04D0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA7E05F0
        public void __set_nearClipPlane__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7E0740
        public void __set_nonJitteredProjectionMatrix__UnityEngineMatrix4x4__SystemVoid(){} // RVA: 0x7FFACA7E0870
        public void __set_opaqueSortMode__UnityEngineRenderingOpaqueSortMode__SystemVoid(){} // RVA: 0x7FFACA7E09D0
        public void __set_orthographicSize__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7E0AF0
        public void __set_orthographic__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7E0C20
        public void __set_overrideSceneCullingMask__SystemUInt64__SystemVoid(){} // RVA: 0x7FFACA7E0D50
        public void __set_pixelRect__UnityEngineRect__SystemVoid(){} // RVA: 0x7FFACA7E0E70
        public void __set_projectionMatrix__UnityEngineMatrix4x4__SystemVoid(){} // RVA: 0x7FFACA7E0FA0
        public void __set_rect__UnityEngineRect__SystemVoid(){} // RVA: 0x7FFACA7E1100
        public void __set_renderingPath__UnityEngineRenderingPath__SystemVoid(){} // RVA: 0x7FFACA7E1230
        public void __set_sensorSize__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA7E1350
        public void __set_shutterSpeed__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7E1470
        public void __set_stereoConvergence__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7E15A0
        public void __set_stereoSeparation__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7E16D0
        public void __set_stereoTargetEye__UnityEngineStereoTargetEyeMask__SystemVoid(){} // RVA: 0x7FFACA7E1800
        public void __set_targetDisplay__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7E1920
        public void __set_targetTexture__UnityEngineRenderTexture__SystemVoid(){} // RVA: 0x7FFACA7E1A40
        public void __set_transparencySortAxis__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA7E1B90
        public void __set_transparencySortMode__UnityEngineTransparencySortMode__SystemVoid(){} // RVA: 0x7FFACA7E1CD0
        public void __set_useJitteredProjectionMatrixForTransparentRendering__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7E1DF0
        public void __set_useOcclusionCulling__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7E1F20
        public void __set_usePhysicalProperties__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7E2050
        public void __set_worldToCameraMatrix__UnityEngineMatrix4x4__SystemVoid(){} // RVA: 0x7FFACA7E2180
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA7E22E0
    }

    public class ExternUnityEngineCameraArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA7EC030
        public void .ctor(){} // RVA: 0x7FFACA7EC070
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA7EC440
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA7EC570
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA7EC680
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7EC760
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7EC840
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA7EC910
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA7ECA60
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA7ECB00
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA7ECC00
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA7ECD20
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA7ECE30
        public void __GetType__SystemType(){} // RVA: 0x7FFACA7ECF50
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA7ED040
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA7ED120
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA7ED240
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA7ED3D0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA7ED520
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA7ED650
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA7ED770
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA7ED8E0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA7EDA20
        public void __Get__SystemInt32__UnityEngineCamera(){} // RVA: 0x7FFACA7EDB40
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA7EDC80
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA7EDCF0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7EDE10
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7EDF90
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7EE0F0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA7EE220
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7EE340
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7EE4A0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7EE5F0
        public void __Set__SystemInt32_UnityEngineCamera__SystemVoid(){} // RVA: 0x7FFACA7EE710
        public void __ToString__SystemString(){} // RVA: 0x7FFACA7EE850
        public void __ctor__SystemInt32__UnityEngineCameraArray(){} // RVA: 0x7FFACA7EE940
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA7EEA30
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA7EEAD0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA7EEB70
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA7EEC10
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA7EECB0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA7EED50
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA7EEDF0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA7EEED0
    }

    public class ExternUnityEngineCameraGateFitParameters : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA7F0DF0
        public void .ctor(){} // RVA: 0x7FFACA7F0E30
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA7F1200
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA7F1330
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA7F1440
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA7F1580
        public void __GetType__SystemType(){} // RVA: 0x7FFACA7F1630
        public void __ToString__SystemString(){} // RVA: 0x7FFACA7F1720
        public void __ctor__UnityEngineCameraGateFitMode_SystemSingle__UnityEngineCameraGateFitParameters(){} // RVA: 0x7FFACA7F17D0
        public void __get_aspect__SystemSingle(){} // RVA: 0x7FFACA7F18A0
        public void __get_mode__UnityEngineCameraGateFitMode(){} // RVA: 0x7FFACA7F1940
        public void __set_aspect__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7F19D0
        public void __set_mode__UnityEngineCameraGateFitMode__SystemVoid(){} // RVA: 0x7FFACA7F1AA0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA7F1B60
    }

    public class ExternUnityEngineCameraGateFitParametersArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA7F2400
        public void .ctor(){} // RVA: 0x7FFACA7F2440
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA7F2810
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA7F2940
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA7F2A50
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7F2B30
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7F2C10
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA7F2CE0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA7F2E30
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA7F2ED0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA7F2FD0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA7F30F0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA7F3200
        public void __GetType__SystemType(){} // RVA: 0x7FFACA7F3320
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA7F3410
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA7F34F0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA7F3610
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA7F37A0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA7F38F0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA7F3A20
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA7F3B40
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA7F3CB0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA7F3DF0
        public void __Get__SystemInt32__UnityEngineCameraGateFitParameters(){} // RVA: 0x7FFACA7F3F10
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA7F3FF0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA7F4060
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7F4180
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7F4300
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7F4460
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA7F4590
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7F46B0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7F4810
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA7F4960
        public void __Set__SystemInt32_UnityEngineCameraGateFitParameters__SystemVoid(){} // RVA: 0x7FFACA7F4A80
        public void __ToString__SystemString(){} // RVA: 0x7FFACA7F4B60
        public void __ctor__SystemInt32__UnityEngineCameraGateFitParametersArray(){} // RVA: 0x7FFACA7F4C50
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA7F4DF0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA7F4E90
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA7F4F30
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA7F4FD0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA7F5070
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA7F5110
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA7F51B0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA7F5290
    }

    public class ExternUnityEngineCanvas : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA7F71B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA7F71F0
        public void .ctor(){} // RVA: 0x7FFACA7F72A0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA7F7670
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA7F77A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA7F78B0
        public void __ForceUpdateCanvases__SystemVoid(){} // RVA: 0x7FFACA7F7A80
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA7F7A90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA7F7B80
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA7F7E30
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA7F7F90
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA7F80B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA7F81A0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA7F8420
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA7F8510
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA7F87C0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA7F8920
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA7F8A40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA7F8B30
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA7F8DB0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA7F8F20
        public void __GetComponent__T(){} // RVA: 0x7FFACA7F9040
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA7F9120
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA7F9370
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA7F9460
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA7F9790
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA7F9880
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA7F9BC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA7F9CB0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA7F9FC0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA7FA130
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA7FA260
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA7FA350
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA7FA640
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA7FA730
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA7FAA70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA7FAB60
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA7FAE70
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA7FAFE0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA7FB120
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA7FB210
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA7FB500
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA7FB5F0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA7FB8E0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA7FBA30
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA7FBB60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA7FBC50
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA7FBF00
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA7FC060
        public void __GetType__SystemType(){} // RVA: 0x7FFACA7FC1B0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA7FC2A0
        public void __get_additionalShaderChannels__UnityEngineAdditionalCanvasShaderChannels(){} // RVA: 0x7FFACA7FC3F0
        public void __get_cachedSortingLayerValue__SystemInt32(){} // RVA: 0x7FFACA7FC510
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA7FC630
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA7FC750
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACA7FC890
        public void __get_isRootCanvas__SystemBoolean(){} // RVA: 0x7FFACA7FC9B0
        public void __get_name__SystemString(){} // RVA: 0x7FFACA7FCAD0
        public void __get_normalizedSortingGridSize__SystemSingle(){} // RVA: 0x7FFACA7FCC20
        public void __get_overridePixelPerfect__SystemBoolean(){} // RVA: 0x7FFACA7FCD40
        public void __get_overrideSorting__SystemBoolean(){} // RVA: 0x7FFACA7FCE60
        public void __get_pixelPerfect__SystemBoolean(){} // RVA: 0x7FFACA7FCF80
        public void __get_pixelRect__UnityEngineRect(){} // RVA: 0x7FFACA7FD0A0
        public void __get_planeDistance__SystemSingle(){} // RVA: 0x7FFACA7FD1E0
        public void __get_referencePixelsPerUnit__SystemSingle(){} // RVA: 0x7FFACA7FD300
        public void __get_renderOrder__SystemInt32(){} // RVA: 0x7FFACA7FD420
        public void __get_renderingDisplaySize__UnityEngineVector2(){} // RVA: 0x7FFACA7FD540
        public void __get_rootCanvas__UnityEngineCanvas(){} // RVA: 0x7FFACA7FD670
        public void __get_scaleFactor__SystemSingle(){} // RVA: 0x7FFACA7FD7A0
        public void __get_sortingLayerID__SystemInt32(){} // RVA: 0x7FFACA7FD8C0
        public void __get_sortingLayerName__SystemString(){} // RVA: 0x7FFACA7FD9E0
        public void __get_sortingOrder__SystemInt32(){} // RVA: 0x7FFACA7FDB00
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA7FDC20
        public void __get_updateRectTransformForStandalone__UnityEngineStandaloneRenderResize(){} // RVA: 0x7FFACA7FDD60
        public void __get_vertexColorAlwaysGammaSpace__SystemBoolean(){} // RVA: 0x7FFACA7FDE80
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA7FDFA0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA7FE2A0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA7FE490
        public void __set_additionalShaderChannels__UnityEngineAdditionalCanvasShaderChannels__SystemVoid(){} // RVA: 0x7FFACA7FE790
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7FE8B0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA7FE9E0
        public void __set_normalizedSortingGridSize__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7FEB30
        public void __set_overridePixelPerfect__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7FEC60
        public void __set_overrideSorting__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7FED90
        public void __set_pixelPerfect__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7FEEC0
        public void __set_planeDistance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7FEFF0
        public void __set_referencePixelsPerUnit__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7FF120
        public void __set_scaleFactor__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA7FF250
        public void __set_sortingLayerID__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7FF380
        public void __set_sortingLayerName__SystemString__SystemVoid(){} // RVA: 0x7FFACA7FF4A0
        public void __set_sortingOrder__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA7FF5C0
        public void __set_updateRectTransformForStandalone__UnityEngineStandaloneRenderResize__SystemVoid(){} // RVA: 0x7FFACA7FF6E0
        public void __set_vertexColorAlwaysGammaSpace__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA7FF800
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA7FF930
    }

    public class ExternUnityEngineCanvasArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA803290
        public void .ctor(){} // RVA: 0x7FFACA8032D0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA8036A0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA8037D0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA8038E0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8039C0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA803AA0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA803B70
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA803CC0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA803D60
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA803E60
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA803F80
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA804090
        public void __GetType__SystemType(){} // RVA: 0x7FFACA8041B0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8042A0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA804380
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA8044A0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA804630
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA804780
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA8048B0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA8049D0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA804B40
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA804C80
        public void __Get__SystemInt32__UnityEngineCanvas(){} // RVA: 0x7FFACA804DA0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA804EE0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA804F50
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA805070
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8051F0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA805350
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA805480
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8055A0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA805700
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA805850
        public void __Set__SystemInt32_UnityEngineCanvas__SystemVoid(){} // RVA: 0x7FFACA805970
        public void __ToString__SystemString(){} // RVA: 0x7FFACA805AB0
        public void __ctor__SystemInt32__UnityEngineCanvasArray(){} // RVA: 0x7FFACA805BA0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA805C90
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA805D30
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA805DD0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA805E70
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA805F10
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA805FB0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA806050
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA806130
    }

    public class ExternUnityEngineCanvasGroup : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA808050
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA808090
        public void .ctor(){} // RVA: 0x7FFACA808140
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA808510
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA808640
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA808750
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA808920
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA808A10
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA808CC0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA808E20
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA808F40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA809030
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA8092B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA8093A0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA809650
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA8097B0
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA8098D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA8099C0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA809C40
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA809DB0
        public void __GetComponent__T(){} // RVA: 0x7FFACA809ED0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA809FB0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA80A200
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA80A2F0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA80A620
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA80A710
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA80AA50
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA80AB40
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA80AE50
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA80AFC0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA80B0F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA80B1E0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA80B4D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA80B5C0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA80B900
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA80B9F0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA80BD00
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA80BE70
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA80BFB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA80C0A0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA80C390
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA80C480
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA80C770
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA80C8C0
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA80C9F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA80CAE0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA80CD90
        public void __IsRaycastLocationValid__UnityEngineVector2_UnityEngineCamera__SystemBoolean(){} // RVA: 0x7FFACA80CEE0
        public void __get_alpha__SystemSingle(){} // RVA: 0x7FFACA80D080
        public void __get_blocksRaycasts__SystemBoolean(){} // RVA: 0x7FFACA80D1A0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA80D2C0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA80D3E0
        public void __get_ignoreParentGroups__SystemBoolean(){} // RVA: 0x7FFACA80D520
        public void __get_interactable__SystemBoolean(){} // RVA: 0x7FFACA80D640
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACA80D760
        public void __get_name__SystemString(){} // RVA: 0x7FFACA80D880
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA80D9D0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA80DB10
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA80DE10
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA80E000
        public void __set_alpha__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA80E300
        public void __set_blocksRaycasts__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA80E430
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA80E560
        public void __set_ignoreParentGroups__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA80E690
        public void __set_interactable__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA80E7C0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA80E8F0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA80EA40
    }

    public class ExternUnityEngineCanvasGroupArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA810F60
        public void .ctor(){} // RVA: 0x7FFACA810FA0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA811370
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA8114A0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA8115B0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA811690
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA811770
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA811840
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA811990
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA811A30
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA811B50
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA811C60
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA811D80
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA811E60
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA811F80
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA812110
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA812260
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA812390
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA8124B0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA812620
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA812760
        public void __Get__SystemInt32__UnityEngineCanvasGroup(){} // RVA: 0x7FFACA812880
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA8129C0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA812A30
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA812B50
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA812CD0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA812E30
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA812F60
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA813080
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8131E0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA813330
        public void __Set__SystemInt32_UnityEngineCanvasGroup__SystemVoid(){} // RVA: 0x7FFACA813450
        public void __ctor__SystemInt32__UnityEngineCanvasGroupArray(){} // RVA: 0x7FFACA8135E0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA8136D0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA813770
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA813810
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA8138B0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA813950
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA8139F0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA813A90
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA813B70
    }

    public class ExternUnityEngineCanvasRenderer : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA815840
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA815880
        public void .ctor(){} // RVA: 0x7FFACA815930
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA815D00
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA815E30
    }

    public class ExternUnityEngineCanvasRendererArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA822B00
        public void .ctor(){} // RVA: 0x7FFACA822B40
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA822F10
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA823040
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA823150
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA823230
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA823310
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA8233E0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA823530
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA8235D0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8236D0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA8237F0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA823900
        public void __GetType__SystemType(){} // RVA: 0x7FFACA823A20
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA823B10
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA823BF0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA823D10
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA823EA0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA823FF0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA824120
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA824240
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA8243B0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA8244F0
        public void __Get__SystemInt32__UnityEngineCanvasRenderer(){} // RVA: 0x7FFACA824610
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA824750
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA8247C0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8248E0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA824A60
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA824BC0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA824CF0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA824E10
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA824F70
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8250C0
        public void __Set__SystemInt32_UnityEngineCanvasRenderer__SystemVoid(){} // RVA: 0x7FFACA8251E0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA825370
        public void __ctor__SystemInt32__UnityEngineCanvasRendererArray(){} // RVA: 0x7FFACA825460
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA825550
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA8255F0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA825690
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA825730
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA8257D0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA825870
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA825910
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA8259F0
    }

    public class ExternUnityEngineCapsuleCollider : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA827910
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA827950
        public void .ctor(){} // RVA: 0x7FFACA827A00
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA827DD0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA827F00
        public void __ClosestPointOnBounds__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACA828010
        public void __ClosestPoint__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACA828200
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA828390
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA828560
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA828650
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA828900
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA828A60
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA828B80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA828C70
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA828EF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA828FE0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA829290
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA8293F0
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA829510
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA829600
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA829880
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA8299F0
        public void __GetComponent__T(){} // RVA: 0x7FFACA829B10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA829BF0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA829E40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA829F30
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA82A260
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA82A350
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA82A690
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA82A780
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA82AA90
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA82AC00
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA82AD30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA82AE20
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA82B110
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA82B200
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA82B540
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA82B630
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA82B940
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA82BAB0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA82BBF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA82BCE0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA82BFD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA82C0C0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA82C3B0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA82C500
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA82C630
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA82C720
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA82C9D0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA82CB30
        public void __GetType__SystemType(){} // RVA: 0x7FFACA82CC80
        public void __Raycast__UnityEngineRay_UnityEngineRaycastHitRef_SystemSingle__SystemBoolean(){} // RVA: 0x7FFACA82CD70
        public void __ToString__SystemString(){} // RVA: 0x7FFACA82CFC0
        public void __get_attachedArticulationBody__UnityEngineArticulationBody(){} // RVA: 0x7FFACA82D110
        public void __get_attachedRigidbody__UnityEngineRigidbody(){} // RVA: 0x7FFACA82D250
        public void __get_bounds__UnityEngineBounds(){} // RVA: 0x7FFACA82D390
        public void __get_center__UnityEngineVector3(){} // RVA: 0x7FFACA82D4E0
        public void __get_contactOffset__SystemSingle(){} // RVA: 0x7FFACA82D620
        public void __get_direction__SystemInt32(){} // RVA: 0x7FFACA82D740
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA82D860
        public void __get_excludeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA82D980
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA82DAB0
        public void __get_hasModifiableContacts__SystemBoolean(){} // RVA: 0x7FFACA82DBF0
        public void __get_height__SystemSingle(){} // RVA: 0x7FFACA82DD10
        public void __get_includeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA82DE30
        public void __get_isTrigger__SystemBoolean(){} // RVA: 0x7FFACA82DF60
        public void __get_layerOverridePriority__SystemInt32(){} // RVA: 0x7FFACA82E080
        public void __get_material__UnityEnginePhysicMaterial(){} // RVA: 0x7FFACA82E1A0
        public void __get_name__SystemString(){} // RVA: 0x7FFACA82E2E0
        public void __get_providesContacts__SystemBoolean(){} // RVA: 0x7FFACA82E430
        public void __get_radius__SystemSingle(){} // RVA: 0x7FFACA82E550
        public void __get_sharedMaterial__UnityEnginePhysicMaterial(){} // RVA: 0x7FFACA82E670
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA82E7B0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA82E8F0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA82EBF0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA82EDE0
        public void __set_center__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA82F0E0
        public void __set_contactOffset__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA82F220
        public void __set_direction__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA82F350
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA82F470
        public void __set_excludeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA82F5A0
        public void __set_hasModifiableContacts__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA82F6C0
        public void __set_height__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA82F7F0
        public void __set_includeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA82F920
        public void __set_isTrigger__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA82FA40
        public void __set_layerOverridePriority__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA82FB70
        public void __set_material__UnityEnginePhysicMaterial__SystemVoid(){} // RVA: 0x7FFACA82FC90
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA82FDE0
        public void __set_providesContacts__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA82FF30
        public void __set_radius__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA830060
        public void __set_sharedMaterial__UnityEnginePhysicMaterial__SystemVoid(){} // RVA: 0x7FFACA830190
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA8302E0
    }

    public class ExternUnityEngineCapsuleCollider2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA833AC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA833B00
        public void .ctor(){} // RVA: 0x7FFACA833BB0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA833F80
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA8340B0
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D_SystemSingle_SystemBoolean__SystemInt32(){} // RVA: 0x7FFACA8341C0
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle_SystemBoolean__SystemInt32(){} // RVA: 0x7FFACA834490
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA834760
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA8349E0
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemBoolean__SystemInt32(){} // RVA: 0x7FFACA834C20
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA834DF0
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA834F80
        public void __ClosestPoint__UnityEngineVector2__UnityEngineVector2(){} // RVA: 0x7FFACA8350D0
        public void __CreateMesh__SystemBoolean_SystemBoolean__UnityEngineMesh(){} // RVA: 0x7FFACA835230
        public void __Distance__UnityEngineCollider2D__UnityEngineColliderDistance2D(){} // RVA: 0x7FFACA835390
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA835520
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA8356F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA8357E0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA835A90
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA835BF0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA835D10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA835E00
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA836080
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA836170
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA836420
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA836580
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA8366A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA836790
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA836A10
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA836B80
        public void __GetComponent__T(){} // RVA: 0x7FFACA836CA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA836D80
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA836FD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA8370C0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA8373F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA8374E0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA837820
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA837910
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA837C20
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA837D90
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA837EC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA837FB0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA8382A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA838390
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA8386D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA8387C0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA838AD0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA838C40
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA838D80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA838E70
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA839160
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA839250
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA839540
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA839690
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA8397C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA8398B0
        public void __GetContacts__SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACA839B60
        public void __GetContacts__SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACA839CB0
        public void __GetContacts__UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACA839DC0
        public void __GetContacts__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACA839F10
        public void __GetContacts__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACA83A140
        public void __GetContacts__UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACA83A320
        public void __GetContacts__UnityEngineContactFilter2D_UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACA83A550
        public void __GetContacts__UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACA83A730
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA83A840
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA83A9A0
        public void __GetShapeHash__SystemUInt32(){} // RVA: 0x7FFACA83AAF0
        public void __GetShapes__UnityEnginePhysicsShapeGroup2D_SystemInt32_SystemInt32__SystemInt32(){} // RVA: 0x7FFACA83AC10
        public void __GetShapes__UnityEnginePhysicsShapeGroup2D__SystemInt32(){} // RVA: 0x7FFACA83AD90
        public void __GetType__SystemType(){} // RVA: 0x7FFACA83AF10
        public void __IsTouchingLayers__SystemBoolean(){} // RVA: 0x7FFACA83B000
        public void __IsTouchingLayers__SystemInt32__SystemBoolean(){} // RVA: 0x7FFACA83B130
        public void __IsTouching__UnityEngineCollider2D_UnityEngineContactFilter2D__SystemBoolean(){} // RVA: 0x7FFACA83B290
        public void __IsTouching__UnityEngineCollider2D__SystemBoolean(){} // RVA: 0x7FFACA83B450
        public void __IsTouching__UnityEngineContactFilter2D__SystemBoolean(){} // RVA: 0x7FFACA83B5B0
        public void __OverlapCollider__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACA83B730
        public void __OverlapCollider__UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACA83B960
        public void __OverlapPoint__UnityEngineVector2__SystemBoolean(){} // RVA: 0x7FFACA83BB90
        public void __Raycast__UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA83BCF0
        public void __Raycast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA83BF60
        public void __Raycast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA83C1D0
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA83C400
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA83C650
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32__SystemInt32(){} // RVA: 0x7FFACA83C860
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA83CA30
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA83CBC0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA83CD10
        public void __get_attachedRigidbody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACA83CE60
        public void __get_bounciness__SystemSingle(){} // RVA: 0x7FFACA83CFA0
        public void __get_bounds__UnityEngineBounds(){} // RVA: 0x7FFACA83D0C0
        public void __get_callbackLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA83D210
        public void __get_composite__UnityEngineCompositeCollider2D(){} // RVA: 0x7FFACA83D340
        public void __get_contactCaptureLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA83D480
        public void __get_density__SystemSingle(){} // RVA: 0x7FFACA83D5B0
        public void __get_direction__UnityEngineCapsuleDirection2D(){} // RVA: 0x7FFACA83D6D0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA83D7F0
        public void __get_errorState__UnityEngineColliderErrorState2D(){} // RVA: 0x7FFACA83D910
        public void __get_excludeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA83DA30
        public void __get_forceReceiveLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA83DB60
        public void __get_forceSendLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA83DC90
        public void __get_friction__SystemSingle(){} // RVA: 0x7FFACA83DDC0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA83DEE0
        public void __get_includeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA83E020
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACA83E150
        public void __get_isTrigger__SystemBoolean(){} // RVA: 0x7FFACA83E270
        public void __get_layerOverridePriority__SystemInt32(){} // RVA: 0x7FFACA83E390
        public void __get_name__SystemString(){} // RVA: 0x7FFACA83E4B0
        public void __get_offset__UnityEngineVector2(){} // RVA: 0x7FFACA83E600
        public void __get_shapeCount__SystemInt32(){} // RVA: 0x7FFACA83E730
        public void __get_sharedMaterial__UnityEnginePhysicsMaterial2D(){} // RVA: 0x7FFACA83E850
        public void __get_size__UnityEngineVector2(){} // RVA: 0x7FFACA83E990
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA83EAC0
        public void __get_usedByComposite__SystemBoolean(){} // RVA: 0x7FFACA83EC00
        public void __get_usedByEffector__SystemBoolean(){} // RVA: 0x7FFACA83ED20
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA83EE40
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA83F140
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA83F330
        public void __set_callbackLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA83F630
        public void __set_contactCaptureLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA83F750
        public void __set_density__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA83F870
        public void __set_direction__UnityEngineCapsuleDirection2D__SystemVoid(){} // RVA: 0x7FFACA83F9A0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA83FAC0
        public void __set_excludeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA83FBF0
        public void __set_forceReceiveLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA83FD10
        public void __set_forceSendLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA83FE30
        public void __set_includeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA83FF50
        public void __set_isTrigger__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA840070
        public void __set_layerOverridePriority__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8401A0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA8402C0
        public void __set_offset__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA840410
        public void __set_sharedMaterial__UnityEnginePhysicsMaterial2D__SystemVoid(){} // RVA: 0x7FFACA840530
        public void __set_size__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA840680
        public void __set_usedByComposite__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA8407A0
        public void __set_usedByEffector__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA8408D0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA840A00
    }

    public class ExternUnityEngineCapsuleCollider2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA846220
        public void .ctor(){} // RVA: 0x7FFACA846260
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA846630
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA846760
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA846870
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA846950
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA846A30
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA846B00
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA846C50
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA846CF0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA846DF0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA846F10
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA847020
        public void __GetType__SystemType(){} // RVA: 0x7FFACA847140
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA847230
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA847310
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA847430
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA8475C0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA847710
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA847840
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA847960
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA847AD0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA847C10
        public void __Get__SystemInt32__UnityEngineCapsuleCollider2D(){} // RVA: 0x7FFACA847D30
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA847E70
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA847EE0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA848000
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA848180
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8482E0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA848410
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA848530
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA848690
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8487E0
        public void __Set__SystemInt32_UnityEngineCapsuleCollider2D__SystemVoid(){} // RVA: 0x7FFACA848900
        public void __ToString__SystemString(){} // RVA: 0x7FFACA848A90
        public void __ctor__SystemInt32__UnityEngineCapsuleCollider2DArray(){} // RVA: 0x7FFACA848B80
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA848C70
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA848D10
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA848DB0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA848E50
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA848EF0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA848F90
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA849030
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA849110
    }

    public class ExternUnityEngineCapsuleColliderArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA84B030
        public void .ctor(){} // RVA: 0x7FFACA84B070
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA84B440
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA84B570
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA84B680
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA84B760
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA84B840
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA84B910
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA84BA60
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA84BB00
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA84BC00
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA84BD20
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA84BE30
        public void __GetType__SystemType(){} // RVA: 0x7FFACA84BF50
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA84C040
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA84C120
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA84C240
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA84C3D0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA84C520
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA84C650
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA84C770
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA84C8E0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA84CA20
        public void __Get__SystemInt32__UnityEngineCapsuleCollider(){} // RVA: 0x7FFACA84CB40
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA84CC80
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA84CCF0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA84CE10
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA84CF90
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA84D0F0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA84D220
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA84D340
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA84D4A0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA84D5F0
        public void __Set__SystemInt32_UnityEngineCapsuleCollider__SystemVoid(){} // RVA: 0x7FFACA84D710
        public void __ToString__SystemString(){} // RVA: 0x7FFACA84D8D0
        public void __ctor__SystemInt32__UnityEngineCapsuleColliderArray(){} // RVA: 0x7FFACA84D9C0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA84DAB0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA84DB50
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA84DBF0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA84DC90
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA84DD30
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA84DDD0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA84DE70
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA84DF50
    }

    public class ExternUnityEngineCharacterController : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA84FE70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA84FEB0
        public void .ctor(){} // RVA: 0x7FFACA84FF60
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA850330
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA850460
        public void __ClosestPointOnBounds__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACA850570
        public void __ClosestPoint__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACA850760
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA8508F0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA850AC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA850BB0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA850E60
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA850FC0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA8510E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA8511D0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA851450
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA851540
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA8517F0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA851950
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA851A70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA851B60
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA851DE0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA851F50
        public void __GetComponent__T(){} // RVA: 0x7FFACA852070
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA852150
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA8523A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA852490
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA8527C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA8528B0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA852BF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA852CE0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA852FF0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA853160
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA853290
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA853380
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA853670
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA853760
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA853AA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA853B90
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA853EA0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA854010
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA854150
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA854240
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA854530
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA854620
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA854910
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA854A60
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA854B90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA854C80
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA854F30
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA855090
        public void __GetType__SystemType(){} // RVA: 0x7FFACA8551E0
        public void __Move__UnityEngineVector3__UnityEngineCollisionFlags(){} // RVA: 0x7FFACA8552D0
        public void __Raycast__UnityEngineRay_UnityEngineRaycastHitRef_SystemSingle__SystemBoolean(){} // RVA: 0x7FFACA855450
        public void __SimpleMove__UnityEngineVector3__SystemBoolean(){} // RVA: 0x7FFACA8556A0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA855820
        public void __get_attachedArticulationBody__UnityEngineArticulationBody(){} // RVA: 0x7FFACA855970
        public void __get_attachedRigidbody__UnityEngineRigidbody(){} // RVA: 0x7FFACA855AB0
        public void __get_bounds__UnityEngineBounds(){} // RVA: 0x7FFACA855BF0
        public void __get_center__UnityEngineVector3(){} // RVA: 0x7FFACA855D40
        public void __get_collisionFlags__UnityEngineCollisionFlags(){} // RVA: 0x7FFACA855E80
        public void __get_contactOffset__SystemSingle(){} // RVA: 0x7FFACA855FA0
        public void __get_detectCollisions__SystemBoolean(){} // RVA: 0x7FFACA8560C0
        public void __get_enableOverlapRecovery__SystemBoolean(){} // RVA: 0x7FFACA8561E0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA856300
        public void __get_excludeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA856420
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA856550
        public void __get_hasModifiableContacts__SystemBoolean(){} // RVA: 0x7FFACA856690
        public void __get_height__SystemSingle(){} // RVA: 0x7FFACA8567B0
        public void __get_includeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA8568D0
        public void __get_isGrounded__SystemBoolean(){} // RVA: 0x7FFACA856A00
        public void __get_isTrigger__SystemBoolean(){} // RVA: 0x7FFACA856B20
        public void __get_layerOverridePriority__SystemInt32(){} // RVA: 0x7FFACA856C40
        public void __get_material__UnityEnginePhysicMaterial(){} // RVA: 0x7FFACA856D60
        public void __get_minMoveDistance__SystemSingle(){} // RVA: 0x7FFACA856EA0
        public void __get_name__SystemString(){} // RVA: 0x7FFACA856FC0
        public void __get_providesContacts__SystemBoolean(){} // RVA: 0x7FFACA857110
        public void __get_radius__SystemSingle(){} // RVA: 0x7FFACA857230
        public void __get_sharedMaterial__UnityEnginePhysicMaterial(){} // RVA: 0x7FFACA857350
        public void __get_skinWidth__SystemSingle(){} // RVA: 0x7FFACA857490
        public void __get_slopeLimit__SystemSingle(){} // RVA: 0x7FFACA8575B0
        public void __get_stepOffset__SystemSingle(){} // RVA: 0x7FFACA8576D0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA8577F0
        public void __get_velocity__UnityEngineVector3(){} // RVA: 0x7FFACA857930
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA857A70
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA857D70
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA857F60
        public void __set_center__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA858260
        public void __set_contactOffset__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA8583A0
        public void __set_detectCollisions__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA8584D0
        public void __set_enableOverlapRecovery__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA858600
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA858730
        public void __set_excludeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA858860
        public void __set_hasModifiableContacts__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA858980
        public void __set_height__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA858AB0
        public void __set_includeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA858BE0
        public void __set_isTrigger__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA858D00
        public void __set_layerOverridePriority__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA858E30
        public void __set_material__UnityEnginePhysicMaterial__SystemVoid(){} // RVA: 0x7FFACA858F50
        public void __set_minMoveDistance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA8590A0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA8591D0
        public void __set_providesContacts__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA859320
        public void __set_radius__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA859450
        public void __set_sharedMaterial__UnityEnginePhysicMaterial__SystemVoid(){} // RVA: 0x7FFACA859580
        public void __set_skinWidth__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA8596D0
        public void __set_slopeLimit__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA859800
        public void __set_stepOffset__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA859930
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA859A60
    }

    public class ExternUnityEngineCharacterControllerArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA85DD80
        public void .ctor(){} // RVA: 0x7FFACA85DDC0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA85E190
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA85E2C0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA85E3D0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA85E4B0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA85E590
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA85E660
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA85E7B0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA85E850
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA85E950
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA85EA70
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA85EB80
        public void __GetType__SystemType(){} // RVA: 0x7FFACA85ECA0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA85ED90
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA85EE70
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA85EF90
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA85F120
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA85F270
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA85F3A0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA85F4C0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA85F630
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA85F770
        public void __Get__SystemInt32__UnityEngineCharacterController(){} // RVA: 0x7FFACA85F890
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA85F9D0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA85FA40
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA85FB60
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA85FCE0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA85FE40
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA85FF70
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA860090
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8601F0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA860340
        public void __Set__SystemInt32_UnityEngineCharacterController__SystemVoid(){} // RVA: 0x7FFACA860460
        public void __ToString__SystemString(){} // RVA: 0x7FFACA860620
        public void __ctor__SystemInt32__UnityEngineCharacterControllerArray(){} // RVA: 0x7FFACA860710
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA860800
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA8608A0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA860940
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA8609E0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA860A80
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA860B20
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA860BC0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA860CA0
    }

    public class ExternUnityEngineCircleCollider2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA862BC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA862C00
        public void .ctor(){} // RVA: 0x7FFACA862CB0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA863080
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA8631B0
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D_SystemSingle_SystemBoolean__SystemInt32(){} // RVA: 0x7FFACA8632C0
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle_SystemBoolean__SystemInt32(){} // RVA: 0x7FFACA863590
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA863860
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA863AE0
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemBoolean__SystemInt32(){} // RVA: 0x7FFACA863D20
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA863EF0
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA864080
        public void __ClosestPoint__UnityEngineVector2__UnityEngineVector2(){} // RVA: 0x7FFACA8641D0
        public void __CreateMesh__SystemBoolean_SystemBoolean__UnityEngineMesh(){} // RVA: 0x7FFACA864330
        public void __Distance__UnityEngineCollider2D__UnityEngineColliderDistance2D(){} // RVA: 0x7FFACA864490
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA864620
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA8647F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA8648E0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA864B90
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA864CF0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA864E10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA864F00
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA865180
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA865270
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA865520
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA865680
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA8657A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA865890
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA865B10
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA865C80
        public void __GetComponent__T(){} // RVA: 0x7FFACA865DA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA865E80
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA8660D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA8661C0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA8664F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA8665E0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA866920
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA866A10
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA866D20
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA866E90
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA866FC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA8670B0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA8673A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA867490
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA8677D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA8678C0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA867BD0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA867D40
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA867E80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA867F70
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA868260
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA868350
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA868640
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA868790
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA8688C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA8689B0
        public void __GetContacts__SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACA868C60
        public void __GetContacts__SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACA868DB0
        public void __GetContacts__UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACA868EC0
        public void __GetContacts__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACA869010
        public void __GetContacts__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACA869240
        public void __GetContacts__UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACA869420
        public void __GetContacts__UnityEngineContactFilter2D_UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACA869650
        public void __GetContacts__UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACA869830
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA869940
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA869AA0
        public void __GetShapeHash__SystemUInt32(){} // RVA: 0x7FFACA869BF0
        public void __GetShapes__UnityEnginePhysicsShapeGroup2D_SystemInt32_SystemInt32__SystemInt32(){} // RVA: 0x7FFACA869D10
        public void __GetShapes__UnityEnginePhysicsShapeGroup2D__SystemInt32(){} // RVA: 0x7FFACA869E90
        public void __GetType__SystemType(){} // RVA: 0x7FFACA86A010
        public void __IsTouchingLayers__SystemBoolean(){} // RVA: 0x7FFACA86A100
        public void __IsTouchingLayers__SystemInt32__SystemBoolean(){} // RVA: 0x7FFACA86A230
        public void __IsTouching__UnityEngineCollider2D_UnityEngineContactFilter2D__SystemBoolean(){} // RVA: 0x7FFACA86A390
        public void __IsTouching__UnityEngineCollider2D__SystemBoolean(){} // RVA: 0x7FFACA86A550
        public void __IsTouching__UnityEngineContactFilter2D__SystemBoolean(){} // RVA: 0x7FFACA86A6B0
        public void __OverlapCollider__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACA86A830
        public void __OverlapCollider__UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACA86AA60
        public void __OverlapPoint__UnityEngineVector2__SystemBoolean(){} // RVA: 0x7FFACA86AC90
        public void __Raycast__UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA86ADF0
        public void __Raycast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA86B060
        public void __Raycast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA86B2D0
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA86B500
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA86B750
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32__SystemInt32(){} // RVA: 0x7FFACA86B960
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA86BB30
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA86BCC0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA86BE10
        public void __get_attachedRigidbody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACA86BF60
        public void __get_bounciness__SystemSingle(){} // RVA: 0x7FFACA86C0A0
        public void __get_bounds__UnityEngineBounds(){} // RVA: 0x7FFACA86C1C0
        public void __get_callbackLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA86C310
        public void __get_composite__UnityEngineCompositeCollider2D(){} // RVA: 0x7FFACA86C440
        public void __get_contactCaptureLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA86C580
        public void __get_density__SystemSingle(){} // RVA: 0x7FFACA86C6B0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA86C7D0
        public void __get_errorState__UnityEngineColliderErrorState2D(){} // RVA: 0x7FFACA86C8F0
        public void __get_excludeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA86CA10
        public void __get_forceReceiveLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA86CB40
        public void __get_forceSendLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA86CC70
        public void __get_friction__SystemSingle(){} // RVA: 0x7FFACA86CDA0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA86CEC0
        public void __get_includeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA86D000
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACA86D130
        public void __get_isTrigger__SystemBoolean(){} // RVA: 0x7FFACA86D250
        public void __get_layerOverridePriority__SystemInt32(){} // RVA: 0x7FFACA86D370
        public void __get_name__SystemString(){} // RVA: 0x7FFACA86D490
        public void __get_offset__UnityEngineVector2(){} // RVA: 0x7FFACA86D5E0
        public void __get_radius__SystemSingle(){} // RVA: 0x7FFACA86D710
        public void __get_shapeCount__SystemInt32(){} // RVA: 0x7FFACA86D830
        public void __get_sharedMaterial__UnityEnginePhysicsMaterial2D(){} // RVA: 0x7FFACA86D950
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA86DA90
        public void __get_usedByComposite__SystemBoolean(){} // RVA: 0x7FFACA86DBD0
        public void __get_usedByEffector__SystemBoolean(){} // RVA: 0x7FFACA86DCF0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA86DE10
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA86E110
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA86E300
        public void __set_callbackLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA86E600
        public void __set_contactCaptureLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA86E720
        public void __set_density__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA86E840
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA86E970
        public void __set_excludeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA86EAA0
        public void __set_forceReceiveLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA86EBC0
        public void __set_forceSendLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA86ECE0
        public void __set_includeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA86EE00
        public void __set_isTrigger__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA86EF20
        public void __set_layerOverridePriority__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA86F050
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA86F170
        public void __set_offset__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA86F2C0
        public void __set_radius__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA86F3E0
        public void __set_sharedMaterial__UnityEnginePhysicsMaterial2D__SystemVoid(){} // RVA: 0x7FFACA86F510
        public void __set_usedByComposite__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA86F660
        public void __set_usedByEffector__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA86F790
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA86F8C0
    }

    public class ExternUnityEngineCircleCollider2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA874F60
        public void .ctor(){} // RVA: 0x7FFACA874FA0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA875370
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA8754A0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA8755B0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA875690
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA875770
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA875840
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA875990
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA875A30
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA875B30
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA875C50
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA875D60
        public void __GetType__SystemType(){} // RVA: 0x7FFACA875E80
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA875F70
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA876050
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA876170
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA876300
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA876450
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA876580
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA8766A0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA876810
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA876950
        public void __Get__SystemInt32__UnityEngineCircleCollider2D(){} // RVA: 0x7FFACA876A70
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA876BB0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA876C20
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA876D40
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA876EC0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA877020
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA877150
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA877270
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8773D0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA877520
        public void __Set__SystemInt32_UnityEngineCircleCollider2D__SystemVoid(){} // RVA: 0x7FFACA877640
        public void __ToString__SystemString(){} // RVA: 0x7FFACA8777D0
        public void __ctor__SystemInt32__UnityEngineCircleCollider2DArray(){} // RVA: 0x7FFACA8778C0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA8779B0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA877A50
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA877AF0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA877B90
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA877C30
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA877CD0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA877D70
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA877E50
    }

    public class ExternUnityEngineCollider : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA879D70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA879DB0
        public void .ctor(){} // RVA: 0x7FFACA879E60
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA87A230
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA87A360
        public void __ClosestPointOnBounds__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACA87A470
        public void __ClosestPoint__UnityEngineVector3__UnityEngineVector3(){} // RVA: 0x7FFACA87A660
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA87A7F0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA87A9C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA87AAB0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA87AD60
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA87AEC0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA87AFE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA87B0D0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA87B350
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA87B440
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA87B6F0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA87B850
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA87B970
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA87BA60
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA87BCE0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA87BE50
        public void __GetComponent__T(){} // RVA: 0x7FFACA87BF70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA87C050
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA87C2A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA87C390
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA87C6C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA87C7B0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA87CAF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA87CBE0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA87CEF0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA87D060
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA87D190
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA87D280
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA87D570
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA87D660
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA87D9A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA87DA90
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA87DDA0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA87DF10
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA87E050
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA87E140
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA87E430
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA87E520
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA87E810
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA87E960
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA87EA90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA87EB80
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA87EE30
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA87EF90
        public void __GetType__SystemType(){} // RVA: 0x7FFACA87F0E0
        public void __Raycast__UnityEngineRay_UnityEngineRaycastHitRef_SystemSingle__SystemBoolean(){} // RVA: 0x7FFACA87F1D0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA87F420
        public void __get_attachedArticulationBody__UnityEngineArticulationBody(){} // RVA: 0x7FFACA87F570
        public void __get_attachedRigidbody__UnityEngineRigidbody(){} // RVA: 0x7FFACA87F6B0
        public void __get_bounds__UnityEngineBounds(){} // RVA: 0x7FFACA87F7F0
        public void __get_contactOffset__SystemSingle(){} // RVA: 0x7FFACA87F940
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA87FA60
        public void __get_excludeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA87FB80
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA87FCB0
        public void __get_hasModifiableContacts__SystemBoolean(){} // RVA: 0x7FFACA87FDF0
        public void __get_includeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA87FF10
        public void __get_isTrigger__SystemBoolean(){} // RVA: 0x7FFACA880040
        public void __get_layerOverridePriority__SystemInt32(){} // RVA: 0x7FFACA880160
        public void __get_material__UnityEnginePhysicMaterial(){} // RVA: 0x7FFACA880280
        public void __get_name__SystemString(){} // RVA: 0x7FFACA8803C0
        public void __get_providesContacts__SystemBoolean(){} // RVA: 0x7FFACA880510
        public void __get_sharedMaterial__UnityEnginePhysicMaterial(){} // RVA: 0x7FFACA880630
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA880770
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA8808B0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA880BB0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA880DA0
        public void __set_contactOffset__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA8810A0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA8811D0
        public void __set_excludeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA881300
        public void __set_hasModifiableContacts__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA881420
        public void __set_includeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA881550
        public void __set_isTrigger__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA881670
        public void __set_layerOverridePriority__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8817A0
        public void __set_material__UnityEnginePhysicMaterial__SystemVoid(){} // RVA: 0x7FFACA8818C0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA881A10
        public void __set_providesContacts__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA881B60
        public void __set_sharedMaterial__UnityEnginePhysicMaterial__SystemVoid(){} // RVA: 0x7FFACA881C90
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA881DE0
    }

    public class ExternUnityEngineCollider2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA884FC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA885000
        public void .ctor(){} // RVA: 0x7FFACA8850B0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA885480
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA8855B0
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D_SystemSingle_SystemBoolean__SystemInt32(){} // RVA: 0x7FFACA8856C0
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle_SystemBoolean__SystemInt32(){} // RVA: 0x7FFACA885990
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA885C60
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA885EE0
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemBoolean__SystemInt32(){} // RVA: 0x7FFACA886120
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA8862F0
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA886480
        public void __ClosestPoint__UnityEngineVector2__UnityEngineVector2(){} // RVA: 0x7FFACA8865D0
        public void __CreateMesh__SystemBoolean_SystemBoolean__UnityEngineMesh(){} // RVA: 0x7FFACA886730
        public void __Distance__UnityEngineCollider2D__UnityEngineColliderDistance2D(){} // RVA: 0x7FFACA886890
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA886A20
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA886BF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA886CE0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA886F90
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA8870F0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA887210
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA887300
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA887580
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA887670
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA887920
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA887A80
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA887BA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA887C90
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA887F10
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA888080
        public void __GetComponent__T(){} // RVA: 0x7FFACA8881A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA888280
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA8884D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA8885C0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA8888F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA8889E0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA888D20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA888E10
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA889120
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA889290
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA8893C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA8894B0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA8897A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA889890
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA889BD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA889CC0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA889FD0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA88A140
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA88A280
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA88A370
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA88A660
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA88A750
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA88AA40
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA88AB90
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA88ACC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA88ADB0
        public void __GetContacts__SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACA88B060
        public void __GetContacts__SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACA88B1B0
        public void __GetContacts__UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACA88B2C0
        public void __GetContacts__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACA88B410
        public void __GetContacts__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACA88B640
        public void __GetContacts__UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACA88B820
        public void __GetContacts__UnityEngineContactFilter2D_UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACA88BA50
        public void __GetContacts__UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACA88BC30
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA88BD40
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA88BEA0
        public void __GetShapeHash__SystemUInt32(){} // RVA: 0x7FFACA88BFF0
        public void __GetShapes__UnityEnginePhysicsShapeGroup2D_SystemInt32_SystemInt32__SystemInt32(){} // RVA: 0x7FFACA88C110
        public void __GetShapes__UnityEnginePhysicsShapeGroup2D__SystemInt32(){} // RVA: 0x7FFACA88C290
        public void __GetType__SystemType(){} // RVA: 0x7FFACA88C410
        public void __IsTouchingLayers__SystemBoolean(){} // RVA: 0x7FFACA88C500
        public void __IsTouchingLayers__SystemInt32__SystemBoolean(){} // RVA: 0x7FFACA88C630
        public void __IsTouching__UnityEngineCollider2D_UnityEngineContactFilter2D__SystemBoolean(){} // RVA: 0x7FFACA88C790
        public void __IsTouching__UnityEngineCollider2D__SystemBoolean(){} // RVA: 0x7FFACA88C950
        public void __IsTouching__UnityEngineContactFilter2D__SystemBoolean(){} // RVA: 0x7FFACA88CAB0
        public void __OverlapCollider__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACA88CC30
        public void __OverlapCollider__UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACA88CE60
        public void __OverlapPoint__UnityEngineVector2__SystemBoolean(){} // RVA: 0x7FFACA88D090
        public void __Raycast__UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA88D1F0
        public void __Raycast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA88D460
        public void __Raycast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA88D6D0
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA88D900
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA88DB50
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32__SystemInt32(){} // RVA: 0x7FFACA88DD60
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA88DF30
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA88E0C0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA88E210
        public void __get_attachedRigidbody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACA88E360
        public void __get_bounciness__SystemSingle(){} // RVA: 0x7FFACA88E4A0
        public void __get_bounds__UnityEngineBounds(){} // RVA: 0x7FFACA88E5C0
        public void __get_callbackLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA88E710
        public void __get_composite__UnityEngineCompositeCollider2D(){} // RVA: 0x7FFACA88E840
        public void __get_contactCaptureLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA88E980
        public void __get_density__SystemSingle(){} // RVA: 0x7FFACA88EAB0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA88EBD0
        public void __get_errorState__UnityEngineColliderErrorState2D(){} // RVA: 0x7FFACA88ECF0
        public void __get_excludeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA88EE10
        public void __get_forceReceiveLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA88EF40
        public void __get_forceSendLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA88F070
        public void __get_friction__SystemSingle(){} // RVA: 0x7FFACA88F1A0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA88F2C0
        public void __get_includeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA88F400
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACA88F530
        public void __get_isTrigger__SystemBoolean(){} // RVA: 0x7FFACA88F650
        public void __get_layerOverridePriority__SystemInt32(){} // RVA: 0x7FFACA88F770
        public void __get_name__SystemString(){} // RVA: 0x7FFACA88F890
        public void __get_offset__UnityEngineVector2(){} // RVA: 0x7FFACA88F9E0
        public void __get_shapeCount__SystemInt32(){} // RVA: 0x7FFACA88FB10
        public void __get_sharedMaterial__UnityEnginePhysicsMaterial2D(){} // RVA: 0x7FFACA88FC30
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA88FD70
        public void __get_usedByComposite__SystemBoolean(){} // RVA: 0x7FFACA88FEB0
        public void __get_usedByEffector__SystemBoolean(){} // RVA: 0x7FFACA88FFD0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA8900F0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA8903F0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA8905E0
        public void __set_callbackLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA8908E0
        public void __set_contactCaptureLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA890A00
        public void __set_density__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA890B20
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA890C50
        public void __set_excludeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA890D80
        public void __set_forceReceiveLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA890EA0
        public void __set_forceSendLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA890FC0
        public void __set_includeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA8910E0
        public void __set_isTrigger__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA891200
        public void __set_layerOverridePriority__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA891330
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA891450
        public void __set_offset__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA8915A0
        public void __set_sharedMaterial__UnityEnginePhysicsMaterial2D__SystemVoid(){} // RVA: 0x7FFACA8916C0
        public void __set_usedByComposite__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA891810
        public void __set_usedByEffector__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA891940
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA891A70
    }

    public class ExternUnityEngineCollider2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA896F90
        public void .ctor(){} // RVA: 0x7FFACA896FD0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA8973A0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA8974D0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA8975E0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8976C0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8977A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA897870
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA8979C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA897A60
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA897B60
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA897C80
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA897D90
        public void __GetType__SystemType(){} // RVA: 0x7FFACA897EB0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA897FA0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA898080
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA8981A0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA898330
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA898480
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA8985B0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA8986D0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA898840
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA898980
        public void __Get__SystemInt32__UnityEngineCollider2D(){} // RVA: 0x7FFACA898AA0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA898BE0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA898C50
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA898D70
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA898EF0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA899050
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA899180
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8992A0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA899400
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA899550
        public void __Set__SystemInt32_UnityEngineCollider2D__SystemVoid(){} // RVA: 0x7FFACA899670
        public void __ToString__SystemString(){} // RVA: 0x7FFACA899830
        public void __ctor__SystemInt32__UnityEngineCollider2DArray(){} // RVA: 0x7FFACA899920
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA899A10
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA899AB0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA899B50
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA899BF0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA899C90
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA899D30
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA899DD0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA899EB0
    }

    public class ExternUnityEngineColliderArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA89BDD0
        public void .ctor(){} // RVA: 0x7FFACA89BE10
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA89C1E0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA89C310
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA89C420
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA89C500
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA89C5E0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA89C6B0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA89C800
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA89C8A0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA89C9A0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA89CAC0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA89CBD0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA89CCF0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA89CDE0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA89CEC0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA89CFE0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA89D170
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA89D2C0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA89D3F0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA89D510
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA89D680
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA89D7C0
        public void __Get__SystemInt32__UnityEngineCollider(){} // RVA: 0x7FFACA89D8E0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA89DA20
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA89DA90
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA89DBB0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA89DD30
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA89DE90
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA89DFC0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA89E0E0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA89E240
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA89E390
        public void __Set__SystemInt32_UnityEngineCollider__SystemVoid(){} // RVA: 0x7FFACA89E4B0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA89E620
        public void __ctor__SystemInt32__UnityEngineColliderArray(){} // RVA: 0x7FFACA89E710
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA89E800
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA89E8A0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA89E940
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA89E9E0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA89EA80
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA89EB20
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA89EBC0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA89ECA0
    }

    public class ExternUnityEngineColliderDistance2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA8A0BC0
        public void .ctor(){} // RVA: 0x7FFACA8A0C00
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA8A0FD0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA8A1100
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA8A1210
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA8A1350
        public void __GetType__SystemType(){} // RVA: 0x7FFACA8A1400
        public void __ToString__SystemString(){} // RVA: 0x7FFACA8A14F0
        public void __get_distance__SystemSingle(){} // RVA: 0x7FFACA8A15A0
        public void __get_isOverlapped__SystemBoolean(){} // RVA: 0x7FFACA8A1640
        public void __get_isValid__SystemBoolean(){} // RVA: 0x7FFACA8A16E0
        public void __get_normal__UnityEngineVector2(){} // RVA: 0x7FFACA8A1790
        public void __get_pointA__UnityEngineVector2(){} // RVA: 0x7FFACA8A1840
        public void __get_pointB__UnityEngineVector2(){} // RVA: 0x7FFACA8A18E0
        public void __set_distance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA8A1990
        public void __set_isValid__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA8A1A80
        public void __set_pointA__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA8A1B80
        public void __set_pointB__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA8A1C90
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA8A1DA0
    }

    public class ExternUnityEngineColliderDistance2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA8A2A00
        public void .ctor(){} // RVA: 0x7FFACA8A2A40
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA8A2E10
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA8A2F40
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA8A3050
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8A3130
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8A3210
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA8A32E0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA8A3430
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA8A34D0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8A35D0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA8A36F0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8A3800
        public void __GetType__SystemType(){} // RVA: 0x7FFACA8A3920
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8A3A10
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA8A3AF0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA8A3C10
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA8A3DA0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA8A3EF0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA8A4020
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA8A4140
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA8A42B0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA8A43F0
        public void __Get__SystemInt32__UnityEngineColliderDistance2D(){} // RVA: 0x7FFACA8A4510
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA8A4610
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA8A4680
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8A47A0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8A4920
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8A4A80
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA8A4BB0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8A4CD0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8A4E30
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8A4F80
        public void __Set__SystemInt32_UnityEngineColliderDistance2D__SystemVoid(){} // RVA: 0x7FFACA8A50A0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA8A51A0
        public void __ctor__SystemInt32__UnityEngineColliderDistance2DArray(){} // RVA: 0x7FFACA8A5290
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA8A5430
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA8A54D0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA8A5570
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA8A5610
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA8A56B0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA8A5750
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA8A57F0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA8A58D0
    }

    public class ExternUnityEngineCollision : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA8A77F0
        public void .ctor(){} // RVA: 0x7FFACA8A7830
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA8A7C00
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA8A7D30
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA8A7E40
        public void __GetContact__SystemInt32__UnityEngineContactPoint(){} // RVA: 0x7FFACA8A7F90
        public void __GetContacts__SystemCollectionsGenericListUnityEngineContactPoint__SystemInt32(){} // RVA: 0x7FFACA8A80A0
        public void __GetContacts__UnityEngineContactPointArray__SystemInt32(){} // RVA: 0x7FFACA8A8380
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA8A8570
        public void __GetType__SystemType(){} // RVA: 0x7FFACA8A8670
        public void __ToString__SystemString(){} // RVA: 0x7FFACA8A8760
        public void __ctor____UnityEngineCollision(){} // RVA: 0x7FFACA8A8850
        public void __get_articulationBody__UnityEngineArticulationBody(){} // RVA: 0x7FFACA8A88F0
        public void __get_body__UnityEngineComponent(){} // RVA: 0x7FFACA8A8A50
        public void __get_collider__UnityEngineCollider(){} // RVA: 0x7FFACA8A8B30
        public void __get_contactCount__SystemInt32(){} // RVA: 0x7FFACA8A8C10
        public void __get_contacts__UnityEngineContactPointArray(){} // RVA: 0x7FFACA8A8CB0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA8A8D50
        public void __get_impulse__UnityEngineVector3(){} // RVA: 0x7FFACA8A8E30
        public void __get_relativeVelocity__UnityEngineVector3(){} // RVA: 0x7FFACA8A8EE0
        public void __get_rigidbody__UnityEngineRigidbody(){} // RVA: 0x7FFACA8A8FE0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA8A90C0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA8A91A0
    }

    public class ExternUnityEngineCollision2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA8AA100
        public void .ctor(){} // RVA: 0x7FFACA8AA140
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA8AA510
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA8AA640
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA8AA750
        public void __GetContact__SystemInt32__UnityEngineContactPoint2D(){} // RVA: 0x7FFACA8AA8A0
        public void __GetContacts__SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACA8AAA80
        public void __GetContacts__UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACA8AACE0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA8AAF00
        public void __GetType__SystemType(){} // RVA: 0x7FFACA8AB000
        public void __ToString__SystemString(){} // RVA: 0x7FFACA8AB0F0
        public void __ctor____UnityEngineCollision2D(){} // RVA: 0x7FFACA8AB1E0
        public void __get_collider__UnityEngineCollider2D(){} // RVA: 0x7FFACA8AB260
        public void __get_contactCount__SystemInt32(){} // RVA: 0x7FFACA8AB340
        public void __get_contacts__UnityEngineContactPoint2DArray(){} // RVA: 0x7FFACA8AB3E0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA8AB480
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA8AB520
        public void __get_otherCollider__UnityEngineCollider2D(){} // RVA: 0x7FFACA8AB600
        public void __get_otherRigidbody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACA8AB7B0
        public void __get_relativeVelocity__UnityEngineVector2(){} // RVA: 0x7FFACA8AB940
        public void __get_rigidbody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACA8AB9E0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA8ABAC0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA8ABD00
    }

    public class ExternUnityEngineCollision2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA8ACC60
        public void .ctor(){} // RVA: 0x7FFACA8ACCA0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA8AD070
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA8AD1A0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA8AD2B0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8AD390
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8AD470
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA8AD540
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA8AD690
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA8AD730
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8AD830
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA8AD950
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8ADA60
        public void __GetType__SystemType(){} // RVA: 0x7FFACA8ADB80
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8ADC70
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA8ADD50
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA8ADE70
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA8AE000
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA8AE150
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA8AE280
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA8AE3A0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA8AE510
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA8AE650
        public void __Get__SystemInt32__UnityEngineCollision2D(){} // RVA: 0x7FFACA8AE770
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA8AE850
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA8AE8C0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8AE9E0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8AEB60
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8AECC0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA8AEDF0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8AEF10
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8AF070
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8AF1C0
        public void __Set__SystemInt32_UnityEngineCollision2D__SystemVoid(){} // RVA: 0x7FFACA8AF2E0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA8AF460
        public void __ctor__SystemInt32__UnityEngineCollision2DArray(){} // RVA: 0x7FFACA8AF550
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA8AF6F0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA8AF790
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA8AF830
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA8AF8D0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA8AF970
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA8AFA10
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA8AFAB0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA8AFB90
    }

    public class ExternUnityEngineCollisionArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA8B1AB0
        public void .ctor(){} // RVA: 0x7FFACA8B1AF0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA8B1EC0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA8B1FF0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA8B2100
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8B21E0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8B22C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA8B2390
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA8B24E0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA8B2580
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8B2680
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA8B27A0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8B28B0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA8B29D0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8B2AC0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA8B2BA0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA8B2CC0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA8B2E50
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA8B2FA0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA8B30D0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA8B31F0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA8B3360
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA8B34A0
        public void __Get__SystemInt32__UnityEngineCollision(){} // RVA: 0x7FFACA8B35C0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA8B36A0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA8B3710
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8B3830
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8B39B0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8B3B10
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA8B3C40
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8B3D60
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8B3EC0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8B4010
        public void __Set__SystemInt32_UnityEngineCollision__SystemVoid(){} // RVA: 0x7FFACA8B4130
        public void __ToString__SystemString(){} // RVA: 0x7FFACA8B42B0
        public void __ctor__SystemInt32__UnityEngineCollisionArray(){} // RVA: 0x7FFACA8B43A0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA8B4540
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA8B45E0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA8B4680
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA8B4720
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA8B47C0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA8B4860
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA8B4900
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA8B49E0
    }

    public class ExternUnityEngineColor : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA8B6900
        public void .ctor(){} // RVA: 0x7FFACA8B6940
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA8B6D10
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA8B6E40
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA8B6F50
        public void __Equals__UnityEngineColor__SystemBoolean(){} // RVA: 0x7FFACA8B71B0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA8B7350
        public void __GetType__SystemType(){} // RVA: 0x7FFACA8B7480
        public void __HSVToRGB__SystemSingle_SystemSingle_SystemSingle_SystemBoolean__UnityEngineColor(){} // RVA: 0x7FFACA8B7570
        public void __HSVToRGB__SystemSingle_SystemSingle_SystemSingle__UnityEngineColor(){} // RVA: 0x7FFACA8B76D0
        public void __LerpUnclamped__UnityEngineColor_UnityEngineColor_SystemSingle__UnityEngineColor(){} // RVA: 0x7FFACA8B77F0
        public void __Lerp__UnityEngineColor_UnityEngineColor_SystemSingle__UnityEngineColor(){} // RVA: 0x7FFACA8B7980
        public void __RGBToHSV__UnityEngineColor_SystemSingleRef_SystemSingleRef_SystemSingleRef__SystemVoid(){} // RVA: 0x7FFACA8B7B20
        public void __ToString__SystemString(){} // RVA: 0x7FFACA8B7CB0
        public void __ToString__SystemString_SystemIFormatProvider__SystemString(){} // RVA: 0x7FFACA8B7D60
        public void __ToString__SystemString__SystemString(){} // RVA: 0x7FFACA8B7E70
        public void __ctor__SystemSingle_SystemSingle_SystemSingle_SystemSingle__UnityEngineColor(){} // RVA: 0x7FFACA8B7F40
        public void __ctor__SystemSingle_SystemSingle_SystemSingle__UnityEngineColor(){} // RVA: 0x7FFACA8B8090
        public void __get_Item__SystemInt32__SystemSingle(){} // RVA: 0x7FFACA8B81C0
        public void __get_a__SystemSingle(){} // RVA: 0x7FFACA8B82A0
        public void __set_a__SystemSingle(){} // RVA: 0x7FFACA8B83C0
        public void __get_b__SystemSingle(){} // RVA: 0x7FFACA8B84D0
        public void __set_b__SystemSingle(){} // RVA: 0x7FFACA8B85F0
        public void __get_black__UnityEngineColor(){} // RVA: 0x7FFACA8B8700
        public void __get_blue__UnityEngineColor(){} // RVA: 0x7FFACA8B8780
        public void __get_clear__UnityEngineColor(){} // RVA: 0x7FFACA8B8800
        public void __get_cyan__UnityEngineColor(){} // RVA: 0x7FFACA8B8870
        public void __get_g__SystemSingle(){} // RVA: 0x7FFACA8B88F0
        public void __set_g__SystemSingle(){} // RVA: 0x7FFACA8B8A10
        public void __get_gamma__UnityEngineColor(){} // RVA: 0x7FFACA8B8B20
        public void __get_gray__UnityEngineColor(){} // RVA: 0x7FFACA8B8BD0
        public void __get_grayscale__SystemSingle(){} // RVA: 0x7FFACA8B8C50
        public void __get_green__UnityEngineColor(){} // RVA: 0x7FFACA8B8D20
        public void __get_grey__UnityEngineColor(){} // RVA: 0x7FFACA8B8DA0
        public void __get_linear__UnityEngineColor(){} // RVA: 0x7FFACA8B8E20
        public void __get_magenta__UnityEngineColor(){} // RVA: 0x7FFACA8B8ED0
        public void __get_maxColorComponent__SystemSingle(){} // RVA: 0x7FFACA8B8F50
        public void __get_r__SystemSingle(){} // RVA: 0x7FFACA8B9000
        public void __set_r__SystemSingle(){} // RVA: 0x7FFACA8B9120
        public void __get_red__UnityEngineColor(){} // RVA: 0x7FFACA8B9230
        public void __get_white__UnityEngineColor(){} // RVA: 0x7FFACA8B92B0
        public void __get_yellow__UnityEngineColor(){} // RVA: 0x7FFACA8B9330
        public void __op_Addition__UnityEngineColor_UnityEngineColor__UnityEngineColor(){} // RVA: 0x7FFACA8B93B0
        public void __op_Division__UnityEngineColor_SystemSingle__UnityEngineColor(){} // RVA: 0x7FFACA8B94E0
        public void __op_Equality__UnityEngineColor_UnityEngineColor__SystemBoolean(){} // RVA: 0x7FFACA8B9610
        public void __op_Implicit__UnityEngineColor__UnityEngineVector4(){} // RVA: 0x7FFACA8B9740
        public void __op_Implicit__UnityEngineVector4__UnityEngineColor(){} // RVA: 0x7FFACA8B9810
        public void __op_Inequality__UnityEngineColor_UnityEngineColor__SystemBoolean(){} // RVA: 0x7FFACA8B98E0
        public void __op_Multiply__SystemSingle_UnityEngineColor__UnityEngineColor(){} // RVA: 0x7FFACA8B9A10
        public void __op_Multiply__UnityEngineColor_SystemSingle__UnityEngineColor(){} // RVA: 0x7FFACA8B9B40
        public void __op_Multiply__UnityEngineColor_UnityEngineColor__UnityEngineColor(){} // RVA: 0x7FFACA8B9C70
        public void __op_Subtraction__UnityEngineColor_UnityEngineColor__UnityEngineColor(){} // RVA: 0x7FFACA8B9DA0
        public void __set_Item__SystemInt32_SystemSingle__SystemVoid(){} // RVA: 0x7FFACA8B9ED0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA8B9FF0
    }

    public class ExternUnityEngineColor32 : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA8BC690
        public void .ctor(){} // RVA: 0x7FFACA8BC6D0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA8BCAA0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA8BCBD0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA8BCCE0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA8BCE20
        public void __GetType__SystemType(){} // RVA: 0x7FFACA8BCED0
        public void __LerpUnclamped__UnityEngineColor32_UnityEngineColor32_SystemSingle__UnityEngineColor32(){} // RVA: 0x7FFACA8BCFC0
        public void __Lerp__UnityEngineColor32_UnityEngineColor32_SystemSingle__UnityEngineColor32(){} // RVA: 0x7FFACA8BD0C0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA8BD1C0
        public void __ToString__SystemString_SystemIFormatProvider__SystemString(){} // RVA: 0x7FFACA8BD260
        public void __ToString__SystemString__SystemString(){} // RVA: 0x7FFACA8BD370
        public void __ctor__SystemByte_SystemByte_SystemByte_SystemByte__UnityEngineColor32(){} // RVA: 0x7FFACA8BD440
        public void __get_Item__SystemInt32__SystemByte(){} // RVA: 0x7FFACA8BD560
        public void __get_a__SystemByte(){} // RVA: 0x7FFACA8BD630
        public void __set_a__SystemByte(){} // RVA: 0x7FFACA8BD700
        public void __get_b__SystemByte(){} // RVA: 0x7FFACA8BD7C0
        public void __set_b__SystemByte(){} // RVA: 0x7FFACA8BD890
        public void __get_g__SystemByte(){} // RVA: 0x7FFACA8BD950
        public void __set_g__SystemByte(){} // RVA: 0x7FFACA8BDA20
        public void __get_r__SystemByte(){} // RVA: 0x7FFACA8BDAE0
        public void __set_r__SystemByte(){} // RVA: 0x7FFACA8BDBB0
        public void __op_Implicit__UnityEngineColor32__UnityEngineColor(){} // RVA: 0x7FFACA8BDC70
        public void __op_Implicit__UnityEngineColor__UnityEngineColor32(){} // RVA: 0x7FFACA8BDD80
        public void __set_Item__SystemInt32_SystemByte__SystemVoid(){} // RVA: 0x7FFACA8BDE20
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA8BDF30
    }

    public class ExternUnityEngineColor32Array : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA8BF0D0
        public void .ctor(){} // RVA: 0x7FFACA8BF110
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA8BF4E0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA8BF610
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA8BF720
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8BF800
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8BF8E0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA8BF9B0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA8BFB00
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA8BFBA0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8BFCA0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA8BFDC0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8BFED0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA8BFFF0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8C00E0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA8C01C0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA8C02E0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA8C0470
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA8C05C0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA8C06F0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA8C0810
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA8C0980
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA8C0AC0
        public void __Get__SystemInt32__UnityEngineColor32(){} // RVA: 0x7FFACA8C0BE0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA8C0CC0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA8C0D30
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8C0E50
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8C0FD0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8C1130
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA8C1260
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8C1380
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8C14E0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8C1630
        public void __Set__SystemInt32_UnityEngineColor32__SystemVoid(){} // RVA: 0x7FFACA8C1750
        public void __ToString__SystemString(){} // RVA: 0x7FFACA8C1830
        public void __ctor__SystemInt32__UnityEngineColor32Array(){} // RVA: 0x7FFACA8C1920
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA8C19D0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA8C1A70
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA8C1B10
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA8C1BB0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA8C1C50
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA8C1CF0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA8C1D90
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA8C1E70
    }

    public class ExternUnityEngineColorArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA8C3D90
        public void .ctor(){} // RVA: 0x7FFACA8C3DD0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA8C41A0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA8C42D0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA8C43E0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8C44C0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8C45A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA8C4670
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA8C47C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA8C4860
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8C4960
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA8C4A80
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8C4B90
        public void __GetType__SystemType(){} // RVA: 0x7FFACA8C4CB0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8C4DA0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA8C4E80
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA8C4FA0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA8C5130
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA8C5280
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA8C53B0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA8C54D0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA8C5640
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA8C5780
        public void __Get__SystemInt32__UnityEngineColor(){} // RVA: 0x7FFACA8C58A0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA8C5990
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA8C5A00
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8C5B20
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8C5CA0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8C5E00
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA8C5F30
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8C6050
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8C61B0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8C6300
        public void __Set__SystemInt32_UnityEngineColor__SystemVoid(){} // RVA: 0x7FFACA8C6420
        public void __ToString__SystemString(){} // RVA: 0x7FFACA8C6510
        public void __ctor__SystemInt32__UnityEngineColorArray(){} // RVA: 0x7FFACA8C6600
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA8C66B0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA8C6750
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA8C67F0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA8C6890
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA8C6930
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA8C69D0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA8C6A70
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA8C6B50
    }

    public class ExternUnityEngineCombineInstance : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA8EFDC0
        public void .ctor(){} // RVA: 0x7FFACA8EFE00
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA8F01D0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA8F0300
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA8F0410
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA8F0550
        public void __GetType__SystemType(){} // RVA: 0x7FFACA8F0600
        public void __ToString__SystemString(){} // RVA: 0x7FFACA8F06F0
        public void __get_lightmapScaleOffset__UnityEngineVector4(){} // RVA: 0x7FFACA8F07A0
        public void __get_mesh__UnityEngineMesh(){} // RVA: 0x7FFACA8F0860
        public void __get_realtimeLightmapScaleOffset__UnityEngineVector4(){} // RVA: 0x7FFACA8F0990
        public void __get_subMeshIndex__SystemInt32(){} // RVA: 0x7FFACA8F0A60
        public void __get_transform__UnityEngineMatrix4x4(){} // RVA: 0x7FFACA8F0B10
        public void __set_lightmapScaleOffset__UnityEngineVector4__SystemVoid(){} // RVA: 0x7FFACA8F0C20
        public void __set_mesh__UnityEngineMesh__SystemVoid(){} // RVA: 0x7FFACA8F0DB0
        public void __set_realtimeLightmapScaleOffset__UnityEngineVector4__SystemVoid(){} // RVA: 0x7FFACA8F0F50
        public void __set_subMeshIndex__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8F10D0
        public void __set_transform__UnityEngineMatrix4x4__SystemVoid(){} // RVA: 0x7FFACA8F1250
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA8F13D0
    }

    public class ExternUnityEngineCombineInstanceArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA8F2030
        public void .ctor(){} // RVA: 0x7FFACA8F2070
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA8F2440
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA8F2570
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA8F2680
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8F2760
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8F2840
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA8F2910
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA8F2A60
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA8F2B00
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8F2C00
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA8F2D20
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8F2E30
        public void __GetType__SystemType(){} // RVA: 0x7FFACA8F2F50
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8F3040
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA8F3120
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA8F3240
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA8F33D0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA8F3520
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA8F3650
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA8F3770
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA8F38E0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA8F3A20
        public void __Get__SystemInt32__UnityEngineCombineInstance(){} // RVA: 0x7FFACA8F3B40
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA8F3C90
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA8F3D00
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8F3E20
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8F3FA0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8F4100
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA8F4230
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8F4350
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8F44B0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8F4600
        public void __Set__SystemInt32_UnityEngineCombineInstance__SystemVoid(){} // RVA: 0x7FFACA8F4720
        public void __ToString__SystemString(){} // RVA: 0x7FFACA8F4870
        public void __ctor__SystemInt32__UnityEngineCombineInstanceArray(){} // RVA: 0x7FFACA8F4960
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA8F4B00
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA8F4BA0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA8F4C40
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA8F4CE0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA8F4D80
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA8F4E20
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA8F4EC0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA8F4FA0
    }

    public class ExternUnityEngineComponent : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA8F6EC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA8F6F00
        public void .ctor(){} // RVA: 0x7FFACA8F6FB0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA8F7380
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA8F74B0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA8F75C0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA8F7790
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA8F7880
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA8F7B30
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA8F7C90
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA8F7DB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA8F7EA0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA8F8120
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA8F8210
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA8F84C0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA8F8620
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA8F8740
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA8F8830
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA8F8AB0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA8F8C20
        public void __GetComponent__T(){} // RVA: 0x7FFACA8F8D40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA8F8E20
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA8F9070
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA8F9160
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA8F9490
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA8F9580
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA8F98C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA8F99B0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA8F9CC0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA8F9E30
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA8F9F60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA8FA050
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA8FA340
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA8FA430
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA8FA770
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA8FA860
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA8FAB70
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA8FACE0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA8FAE20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA8FAF10
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA8FB200
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA8FB2F0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA8FB5E0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA8FB730
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA8FB860
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA8FB950
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA8FBC00
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA8FBD60
        public void __GetType__SystemType(){} // RVA: 0x7FFACA8FBEB0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA8FBFA0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA8FC0F0
        public void __get_name__SystemString(){} // RVA: 0x7FFACA8FC230
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA8FC380
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA8FC4C0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA8FC7C0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA8FC9B0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA8FCCB0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA8FCE00
    }

    public class ExternUnityEngineComponentArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA8FEC50
        public void .ctor(){} // RVA: 0x7FFACA8FEC90
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA8FF060
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA8FF190
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA8FF2A0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA8FF380
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA8FF460
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA8FF530
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA8FF680
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA8FF720
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8FF820
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA8FF940
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8FFA50
        public void __GetType__SystemType(){} // RVA: 0x7FFACA8FFB70
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA8FFC60
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA8FFD40
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA8FFE60
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA8FFFF0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA900140
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA900270
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA900390
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA900500
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA900640
        public void __Get__SystemInt32__UnityEngineComponent(){} // RVA: 0x7FFACA900760
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA9008A0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA900910
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA900A30
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA900BB0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA900D10
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA900E40
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA900F60
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9010C0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA901210
        public void __Set__SystemInt32_UnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA901330
        public void __ToString__SystemString(){} // RVA: 0x7FFACA9014F0
        public void __ctor__SystemInt32__UnityEngineComponentArray(){} // RVA: 0x7FFACA9015E0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA9016D0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA901770
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA901810
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA9018B0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA901950
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA9019F0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA901A90
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA901B70
    }

    public class ExternUnityEngineCompositeCollider2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA903A90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA903AD0
        public void .ctor(){} // RVA: 0x7FFACA903B80
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA903F50
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA904080
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D_SystemSingle_SystemBoolean__SystemInt32(){} // RVA: 0x7FFACA904190
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle_SystemBoolean__SystemInt32(){} // RVA: 0x7FFACA904460
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA904730
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA9049B0
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemBoolean__SystemInt32(){} // RVA: 0x7FFACA904BF0
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA904DC0
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA904F50
        public void __ClosestPoint__UnityEngineVector2__UnityEngineVector2(){} // RVA: 0x7FFACA9050A0
        public void __CreateMesh__SystemBoolean_SystemBoolean__UnityEngineMesh(){} // RVA: 0x7FFACA905200
        public void __Distance__UnityEngineCollider2D__UnityEngineColliderDistance2D(){} // RVA: 0x7FFACA905360
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA9054F0
        public void __GenerateGeometry__SystemVoid(){} // RVA: 0x7FFACA9056C0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA9057B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA9058A0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA905B50
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA905CB0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA905DD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA905EC0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA906140
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA906230
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA9064E0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA906640
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA906760
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA906850
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA906AD0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA906C40
        public void __GetComponent__T(){} // RVA: 0x7FFACA906D60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA906E40
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA907090
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA907180
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9074B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9075A0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA9078E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA9079D0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA907CE0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA907E50
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA907F80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA908070
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA908360
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA908450
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA908790
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA908880
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA908B90
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA908D00
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA908E40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA908F30
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA909220
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA909310
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA909600
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA909750
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA909880
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA909970
        public void __GetContacts__SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACA909C20
        public void __GetContacts__SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACA909D70
        public void __GetContacts__UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACA909E80
        public void __GetContacts__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACA909FD0
        public void __GetContacts__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACA90A200
        public void __GetContacts__UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACA90A3E0
        public void __GetContacts__UnityEngineContactFilter2D_UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACA90A610
        public void __GetContacts__UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACA90A7F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA90A900
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA90AA60
        public void __GetPathPointCount__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA90ABB0
        public void __GetPath__SystemInt32_SystemCollectionsGenericListUnityEngineVector2__SystemInt32(){} // RVA: 0x7FFACA90AE20
        public void __GetPath__SystemInt32_UnityEngineVector2Array__SystemInt32(){} // RVA: 0x7FFACA90AF60
        public void __GetShapeHash__SystemUInt32(){} // RVA: 0x7FFACA90B0A0
        public void __GetShapes__UnityEnginePhysicsShapeGroup2D_SystemInt32_SystemInt32__SystemInt32(){} // RVA: 0x7FFACA90B1C0
        public void __GetShapes__UnityEnginePhysicsShapeGroup2D__SystemInt32(){} // RVA: 0x7FFACA90B340
        public void __GetType__SystemType(){} // RVA: 0x7FFACA90B4C0
        public void __IsTouchingLayers__SystemBoolean(){} // RVA: 0x7FFACA90B5B0
        public void __IsTouchingLayers__SystemInt32__SystemBoolean(){} // RVA: 0x7FFACA90B6E0
        public void __IsTouching__UnityEngineCollider2D_UnityEngineContactFilter2D__SystemBoolean(){} // RVA: 0x7FFACA90B840
        public void __IsTouching__UnityEngineCollider2D__SystemBoolean(){} // RVA: 0x7FFACA90BA00
        public void __IsTouching__UnityEngineContactFilter2D__SystemBoolean(){} // RVA: 0x7FFACA90BB60
        public void __OverlapCollider__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACA90BCE0
        public void __OverlapCollider__UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACA90BF10
        public void __OverlapPoint__UnityEngineVector2__SystemBoolean(){} // RVA: 0x7FFACA90C140
        public void __Raycast__UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA90C2A0
        public void __Raycast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA90C510
        public void __Raycast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA90C780
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA90C9B0
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA90CC00
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32__SystemInt32(){} // RVA: 0x7FFACA90CE10
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA90CFE0
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA90D170
        public void __ToString__SystemString(){} // RVA: 0x7FFACA90D2C0
        public void __get_attachedRigidbody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACA90D410
        public void __get_bounciness__SystemSingle(){} // RVA: 0x7FFACA90D550
        public void __get_bounds__UnityEngineBounds(){} // RVA: 0x7FFACA90D670
        public void __get_callbackLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA90D7C0
        public void __get_composite__UnityEngineCompositeCollider2D(){} // RVA: 0x7FFACA90D8F0
        public void __get_contactCaptureLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA90DA30
        public void __get_density__SystemSingle(){} // RVA: 0x7FFACA90DB60
        public void __get_edgeRadius__SystemSingle(){} // RVA: 0x7FFACA90DC80
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA90DDA0
        public void __get_errorState__UnityEngineColliderErrorState2D(){} // RVA: 0x7FFACA90DEC0
        public void __get_excludeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA90DFE0
        public void __get_forceReceiveLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA90E110
        public void __get_forceSendLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA90E240
        public void __get_friction__SystemSingle(){} // RVA: 0x7FFACA90E370
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA90E490
        public void __get_generationType__UnityEngineCompositeCollider2DGenerationType(){} // RVA: 0x7FFACA90E5D0
        public void __get_geometryType__UnityEngineCompositeCollider2DGeometryType(){} // RVA: 0x7FFACA90E6F0
        public void __get_includeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA90E810
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACA90E940
        public void __get_isTrigger__SystemBoolean(){} // RVA: 0x7FFACA90EA60
        public void __get_layerOverridePriority__SystemInt32(){} // RVA: 0x7FFACA90EB80
        public void __get_name__SystemString(){} // RVA: 0x7FFACA90ECA0
        public void __get_offsetDistance__SystemSingle(){} // RVA: 0x7FFACA90EDF0
        public void __get_offset__UnityEngineVector2(){} // RVA: 0x7FFACA90EF10
        public void __get_pathCount__SystemInt32(){} // RVA: 0x7FFACA90F040
        public void __get_pointCount__SystemInt32(){} // RVA: 0x7FFACA90F160
        public void __get_shapeCount__SystemInt32(){} // RVA: 0x7FFACA90F280
        public void __get_sharedMaterial__UnityEnginePhysicsMaterial2D(){} // RVA: 0x7FFACA90F3A0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA90F4E0
        public void __get_useDelaunayMesh__SystemBoolean(){} // RVA: 0x7FFACA90F620
        public void __get_usedByComposite__SystemBoolean(){} // RVA: 0x7FFACA90F740
        public void __get_usedByEffector__SystemBoolean(){} // RVA: 0x7FFACA90F860
        public void __get_vertexDistance__SystemSingle(){} // RVA: 0x7FFACA90F980
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA90FAA0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA90FDA0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA90FF90
        public void __set_callbackLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA910290
        public void __set_contactCaptureLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA9103B0
        public void __set_density__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9104D0
        public void __set_edgeRadius__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA910600
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA910730
        public void __set_excludeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA910860
        public void __set_forceReceiveLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA910980
        public void __set_forceSendLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA910AA0
        public void __set_generationType__UnityEngineCompositeCollider2DGenerationType__SystemVoid(){} // RVA: 0x7FFACA910BC0
        public void __set_geometryType__UnityEngineCompositeCollider2DGeometryType__SystemVoid(){} // RVA: 0x7FFACA910CE0
        public void __set_includeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA910E00
        public void __set_isTrigger__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA910F20
        public void __set_layerOverridePriority__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA911050
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA911170
        public void __set_offsetDistance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9112C0
        public void __set_offset__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA9113F0
        public void __set_sharedMaterial__UnityEnginePhysicsMaterial2D__SystemVoid(){} // RVA: 0x7FFACA911510
        public void __set_useDelaunayMesh__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA911660
        public void __set_usedByComposite__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA911790
        public void __set_usedByEffector__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9118C0
        public void __set_vertexDistance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9119F0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA911B20
    }

    public class ExternUnityEngineCompositeCollider2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA917DC0
        public void .ctor(){} // RVA: 0x7FFACA917E00
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA9181D0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA918300
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA918410
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9184F0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9185D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA9186A0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA9187F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA918890
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA918990
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA918AB0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA918BC0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA918CE0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA918DD0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA918EB0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA918FD0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA919160
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA9192B0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA9193E0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA919500
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA919670
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA9197B0
        public void __Get__SystemInt32__UnityEngineCompositeCollider2D(){} // RVA: 0x7FFACA9198D0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA919A10
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA919A80
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA919BA0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA919D20
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA919E80
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA919FB0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA91A0D0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA91A230
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA91A380
        public void __Set__SystemInt32_UnityEngineCompositeCollider2D__SystemVoid(){} // RVA: 0x7FFACA91A4A0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA91A630
        public void __ctor__SystemInt32__UnityEngineCompositeCollider2DArray(){} // RVA: 0x7FFACA91A720
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA91A810
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA91A8B0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA91A950
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA91A9F0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA91AA90
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA91AB30
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA91ABD0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA91ACB0
    }

    public class ExternUnityEngineConfigurableJoint : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA91CBD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA91CC10
        public void .ctor(){} // RVA: 0x7FFACA91CCC0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA91D090
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA91D1C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA91D2D0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA91D4A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA91D590
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA91D840
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA91D9A0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA91DAC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA91DBB0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA91DE30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA91DF20
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA91E1D0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA91E330
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA91E450
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA91E540
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA91E7C0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA91E930
        public void __GetComponent__T(){} // RVA: 0x7FFACA91EA50
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA91EB30
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA91ED80
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA91EE70
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA91F1A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA91F290
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA91F5D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA91F6C0
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA91F9D0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA91FB40
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA91FC70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA91FD60
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA920050
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA920140
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA920480
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA920570
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA920880
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA9209F0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA920B30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA920C20
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA920F10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA921000
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA9212F0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA921440
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA921570
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA921660
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA921910
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA921A70
        public void __GetType__SystemType(){} // RVA: 0x7FFACA921BC0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA921CB0
        public void __get_anchor__UnityEngineVector3(){} // RVA: 0x7FFACA921E00
        public void __get_angularXDrive__UnityEngineJointDrive(){} // RVA: 0x7FFACA921F40
        public void __get_angularXLimitSpring__UnityEngineSoftJointLimitSpring(){} // RVA: 0x7FFACA922080
        public void __get_angularXMotion__UnityEngineConfigurableJointMotion(){} // RVA: 0x7FFACA9221B0
        public void __get_angularYLimit__UnityEngineSoftJointLimit(){} // RVA: 0x7FFACA9222D0
        public void __get_angularYMotion__UnityEngineConfigurableJointMotion(){} // RVA: 0x7FFACA922410
        public void __get_angularYZDrive__UnityEngineJointDrive(){} // RVA: 0x7FFACA922530
        public void __get_angularYZLimitSpring__UnityEngineSoftJointLimitSpring(){} // RVA: 0x7FFACA922670
        public void __get_angularZLimit__UnityEngineSoftJointLimit(){} // RVA: 0x7FFACA9227A0
        public void __get_angularZMotion__UnityEngineConfigurableJointMotion(){} // RVA: 0x7FFACA9228E0
        public void __get_autoConfigureConnectedAnchor__SystemBoolean(){} // RVA: 0x7FFACA922A00
        public void __get_axis__UnityEngineVector3(){} // RVA: 0x7FFACA922B20
        public void __get_breakForce__SystemSingle(){} // RVA: 0x7FFACA922C60
        public void __get_breakTorque__SystemSingle(){} // RVA: 0x7FFACA922D80
        public void __get_configuredInWorldSpace__SystemBoolean(){} // RVA: 0x7FFACA922EA0
        public void __get_connectedAnchor__UnityEngineVector3(){} // RVA: 0x7FFACA922FC0
        public void __get_connectedArticulationBody__UnityEngineArticulationBody(){} // RVA: 0x7FFACA923100
        public void __get_connectedBody__UnityEngineRigidbody(){} // RVA: 0x7FFACA923240
        public void __get_connectedMassScale__SystemSingle(){} // RVA: 0x7FFACA923380
        public void __get_currentForce__UnityEngineVector3(){} // RVA: 0x7FFACA9234A0
        public void __get_currentTorque__UnityEngineVector3(){} // RVA: 0x7FFACA923590
        public void __get_enableCollision__SystemBoolean(){} // RVA: 0x7FFACA923680
        public void __get_enablePreprocessing__SystemBoolean(){} // RVA: 0x7FFACA9237A0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA9238C0
        public void __get_highAngularXLimit__UnityEngineSoftJointLimit(){} // RVA: 0x7FFACA923A00
        public void __get_linearLimitSpring__UnityEngineSoftJointLimitSpring(){} // RVA: 0x7FFACA923B40
        public void __get_linearLimit__UnityEngineSoftJointLimit(){} // RVA: 0x7FFACA923C70
        public void __get_lowAngularXLimit__UnityEngineSoftJointLimit(){} // RVA: 0x7FFACA923DB0
        public void __get_massScale__SystemSingle(){} // RVA: 0x7FFACA923EF0
        public void __get_name__SystemString(){} // RVA: 0x7FFACA924010
        public void __get_projectionAngle__SystemSingle(){} // RVA: 0x7FFACA924160
        public void __get_projectionDistance__SystemSingle(){} // RVA: 0x7FFACA924280
        public void __get_projectionMode__UnityEngineJointProjectionMode(){} // RVA: 0x7FFACA9243A0
        public void __get_rotationDriveMode__UnityEngineRotationDriveMode(){} // RVA: 0x7FFACA9244C0
        public void __get_secondaryAxis__UnityEngineVector3(){} // RVA: 0x7FFACA9245E0
        public void __get_slerpDrive__UnityEngineJointDrive(){} // RVA: 0x7FFACA924720
        public void __get_swapBodies__SystemBoolean(){} // RVA: 0x7FFACA924860
        public void __get_targetAngularVelocity__UnityEngineVector3(){} // RVA: 0x7FFACA924980
        public void __get_targetPosition__UnityEngineVector3(){} // RVA: 0x7FFACA924AC0
        public void __get_targetRotation__UnityEngineQuaternion(){} // RVA: 0x7FFACA924C00
        public void __get_targetVelocity__UnityEngineVector3(){} // RVA: 0x7FFACA924D40
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA924E80
        public void __get_xDrive__UnityEngineJointDrive(){} // RVA: 0x7FFACA924FC0
        public void __get_xMotion__UnityEngineConfigurableJointMotion(){} // RVA: 0x7FFACA925100
        public void __get_yDrive__UnityEngineJointDrive(){} // RVA: 0x7FFACA925220
        public void __get_yMotion__UnityEngineConfigurableJointMotion(){} // RVA: 0x7FFACA925360
        public void __get_zDrive__UnityEngineJointDrive(){} // RVA: 0x7FFACA925480
        public void __get_zMotion__UnityEngineConfigurableJointMotion(){} // RVA: 0x7FFACA9255C0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA9256E0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA9259E0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA925BD0
        public void __set_anchor__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA925ED0
        public void __set_angularXDrive__UnityEngineJointDrive__SystemVoid(){} // RVA: 0x7FFACA926010
        public void __set_angularXLimitSpring__UnityEngineSoftJointLimitSpring__SystemVoid(){} // RVA: 0x7FFACA926140
        public void __set_angularXMotion__UnityEngineConfigurableJointMotion__SystemVoid(){} // RVA: 0x7FFACA926260
        public void __set_angularYLimit__UnityEngineSoftJointLimit__SystemVoid(){} // RVA: 0x7FFACA926380
        public void __set_angularYMotion__UnityEngineConfigurableJointMotion__SystemVoid(){} // RVA: 0x7FFACA9264C0
        public void __set_angularYZDrive__UnityEngineJointDrive__SystemVoid(){} // RVA: 0x7FFACA9265E0
        public void __set_angularYZLimitSpring__UnityEngineSoftJointLimitSpring__SystemVoid(){} // RVA: 0x7FFACA926710
        public void __set_angularZLimit__UnityEngineSoftJointLimit__SystemVoid(){} // RVA: 0x7FFACA926830
        public void __set_angularZMotion__UnityEngineConfigurableJointMotion__SystemVoid(){} // RVA: 0x7FFACA926970
        public void __set_autoConfigureConnectedAnchor__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA926A90
        public void __set_axis__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA926BC0
        public void __set_breakForce__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA926D00
        public void __set_breakTorque__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA926E30
        public void __set_configuredInWorldSpace__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA926F60
        public void __set_connectedAnchor__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA927090
        public void __set_connectedArticulationBody__UnityEngineArticulationBody__SystemVoid(){} // RVA: 0x7FFACA9271D0
        public void __set_connectedBody__UnityEngineRigidbody__SystemVoid(){} // RVA: 0x7FFACA927320
        public void __set_connectedMassScale__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA927470
        public void __set_enableCollision__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9275A0
        public void __set_enablePreprocessing__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9276D0
        public void __set_highAngularXLimit__UnityEngineSoftJointLimit__SystemVoid(){} // RVA: 0x7FFACA927800
        public void __set_linearLimitSpring__UnityEngineSoftJointLimitSpring__SystemVoid(){} // RVA: 0x7FFACA927940
        public void __set_linearLimit__UnityEngineSoftJointLimit__SystemVoid(){} // RVA: 0x7FFACA927A60
        public void __set_lowAngularXLimit__UnityEngineSoftJointLimit__SystemVoid(){} // RVA: 0x7FFACA927BA0
        public void __set_massScale__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA927CE0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA927E10
        public void __set_projectionAngle__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA927F60
        public void __set_projectionDistance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA928090
        public void __set_projectionMode__UnityEngineJointProjectionMode__SystemVoid(){} // RVA: 0x7FFACA9281C0
        public void __set_rotationDriveMode__UnityEngineRotationDriveMode__SystemVoid(){} // RVA: 0x7FFACA9282E0
        public void __set_secondaryAxis__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA928400
        public void __set_slerpDrive__UnityEngineJointDrive__SystemVoid(){} // RVA: 0x7FFACA928540
        public void __set_swapBodies__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA928670
        public void __set_targetAngularVelocity__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA9287A0
        public void __set_targetPosition__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA9288E0
        public void __set_targetRotation__UnityEngineQuaternion__SystemVoid(){} // RVA: 0x7FFACA928A20
        public void __set_targetVelocity__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA928B50
        public void __set_xDrive__UnityEngineJointDrive__SystemVoid(){} // RVA: 0x7FFACA928C90
        public void __set_xMotion__UnityEngineConfigurableJointMotion__SystemVoid(){} // RVA: 0x7FFACA928DC0
        public void __set_yDrive__UnityEngineJointDrive__SystemVoid(){} // RVA: 0x7FFACA928EE0
        public void __set_yMotion__UnityEngineConfigurableJointMotion__SystemVoid(){} // RVA: 0x7FFACA929010
        public void __set_zDrive__UnityEngineJointDrive__SystemVoid(){} // RVA: 0x7FFACA929130
        public void __set_zMotion__UnityEngineConfigurableJointMotion__SystemVoid(){} // RVA: 0x7FFACA929260
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA929380
    }

    public class ExternUnityEngineConfigurableJointArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA92F3E0
        public void .ctor(){} // RVA: 0x7FFACA92F420
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA92F7F0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA92F920
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA92FA30
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA92FB10
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA92FBF0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA92FCC0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA92FE10
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA92FEB0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA92FFB0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA9300D0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9301E0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA930300
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9303F0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA9304D0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA9305F0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA930780
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA9308D0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA930A00
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA930B20
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA930C90
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA930DD0
        public void __Get__SystemInt32__UnityEngineConfigurableJoint(){} // RVA: 0x7FFACA930EF0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA931030
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA9310A0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9311C0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA931340
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9314A0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA9315D0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9316F0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA931850
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9319A0
        public void __Set__SystemInt32_UnityEngineConfigurableJoint__SystemVoid(){} // RVA: 0x7FFACA931AC0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA931C80
        public void __ctor__SystemInt32__UnityEngineConfigurableJointArray(){} // RVA: 0x7FFACA931D70
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA931E60
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA931F00
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA931FA0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA932040
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA9320E0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA932180
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA932220
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA932300
    }

    public class ExternUnityEngineConstantForce : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA934220
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA934260
        public void .ctor(){} // RVA: 0x7FFACA934310
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA9346E0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA934810
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA934920
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA934AF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA934BE0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA934E90
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA934FF0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA935110
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA935200
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA935480
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA935570
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA935820
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA935980
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA935AA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA935B90
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA935E10
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA935F80
        public void __GetComponent__T(){} // RVA: 0x7FFACA9360A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA936180
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA9363D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA9364C0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9367F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9368E0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA936C20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA936D10
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA937020
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA937190
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA9372C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA9373B0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9376A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA937790
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA937AD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA937BC0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA937ED0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA938040
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA938180
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA938270
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA938560
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA938650
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA938940
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA938A90
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA938BC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA938CB0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA938F60
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA9390C0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA939210
        public void __ToString__SystemString(){} // RVA: 0x7FFACA939300
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA939450
        public void __get_force__UnityEngineVector3(){} // RVA: 0x7FFACA939570
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA9396B0
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACA9397F0
        public void __get_name__SystemString(){} // RVA: 0x7FFACA939910
        public void __get_relativeForce__UnityEngineVector3(){} // RVA: 0x7FFACA939A60
        public void __get_relativeTorque__UnityEngineVector3(){} // RVA: 0x7FFACA939BA0
        public void __get_torque__UnityEngineVector3(){} // RVA: 0x7FFACA939CE0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA939E20
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA939F60
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA93A260
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA93A450
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA93A750
        public void __set_force__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA93A880
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA93A9C0
        public void __set_relativeForce__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA93AB10
        public void __set_relativeTorque__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA93AC50
        public void __set_torque__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA93AD90
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA93AED0
    }

    public class ExternUnityEngineConstantForce2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA93D570
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA93D5B0
        public void .ctor(){} // RVA: 0x7FFACA93D660
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA93DA30
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA93DB60
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA93DC70
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA93DE40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA93DF30
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA93E1E0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA93E340
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA93E460
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA93E550
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA93E7D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA93E8C0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA93EB70
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA93ECD0
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA93EDF0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA93EEE0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA93F160
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA93F2D0
        public void __GetComponent__T(){} // RVA: 0x7FFACA93F3F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA93F4D0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA93F720
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA93F810
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA93FB40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA93FC30
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA93FF70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA940060
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA940370
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA9404E0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA940610
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA940700
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9409F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA940AE0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA940E20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA940F10
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA941220
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA941390
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA9414D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA9415C0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA9418B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA9419A0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA941C90
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA941DE0
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA941F10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA942000
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA9422B0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA942410
        public void __GetType__SystemType(){} // RVA: 0x7FFACA942560
        public void __ToString__SystemString(){} // RVA: 0x7FFACA942650
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA9427A0
        public void __get_force__UnityEngineVector2(){} // RVA: 0x7FFACA9428C0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA9429F0
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACA942B30
        public void __get_name__SystemString(){} // RVA: 0x7FFACA942C50
        public void __get_relativeForce__UnityEngineVector2(){} // RVA: 0x7FFACA942DA0
        public void __get_torque__SystemSingle(){} // RVA: 0x7FFACA942ED0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA942FF0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA943130
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA943430
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA943620
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA943920
        public void __set_force__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA943A50
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA943B70
        public void __set_relativeForce__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA943CC0
        public void __set_torque__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA943DE0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA943F10
    }

    public class ExternUnityEngineConstantForce2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA946430
        public void .ctor(){} // RVA: 0x7FFACA946470
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA946840
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA946970
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA946A80
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA946B60
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA946C40
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA946D10
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA946E60
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA946F00
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA947000
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA947120
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA947230
        public void __GetType__SystemType(){} // RVA: 0x7FFACA947350
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA947440
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA947520
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA947640
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA9477D0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA947920
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA947A50
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA947B70
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA947CE0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA947E20
        public void __Get__SystemInt32__UnityEngineConstantForce2D(){} // RVA: 0x7FFACA947F40
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA948080
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA9480F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA948210
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA948390
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9484F0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA948620
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA948740
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9488A0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9489F0
        public void __Set__SystemInt32_UnityEngineConstantForce2D__SystemVoid(){} // RVA: 0x7FFACA948B10
        public void __ToString__SystemString(){} // RVA: 0x7FFACA948CA0
        public void __ctor__SystemInt32__UnityEngineConstantForce2DArray(){} // RVA: 0x7FFACA948D90
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA948E80
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA948F20
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA948FC0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA949060
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA949100
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA9491A0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA949240
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA949320
    }

    public class ExternUnityEngineConstantForceArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA94B240
        public void .ctor(){} // RVA: 0x7FFACA94B280
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA94B650
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA94B780
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA94B890
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA94B970
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA94BA50
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA94BB20
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA94BC70
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA94BD10
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA94BE10
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA94BF30
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA94C040
        public void __GetType__SystemType(){} // RVA: 0x7FFACA94C160
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA94C250
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA94C330
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA94C450
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA94C5E0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA94C730
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA94C860
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA94C980
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA94CAF0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA94CC30
        public void __Get__SystemInt32__UnityEngineConstantForce(){} // RVA: 0x7FFACA94CD50
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA94CE90
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA94CF00
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA94D020
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA94D1A0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA94D300
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA94D430
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA94D550
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA94D6B0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA94D800
        public void __Set__SystemInt32_UnityEngineConstantForce__SystemVoid(){} // RVA: 0x7FFACA94D920
        public void __ToString__SystemString(){} // RVA: 0x7FFACA94DAE0
        public void __ctor__SystemInt32__UnityEngineConstantForceArray(){} // RVA: 0x7FFACA94DBD0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA94DCC0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA94DD60
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA94DE00
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA94DEA0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA94DF40
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA94DFE0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA94E080
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA94E160
    }

    public class ExternUnityEngineContactFilter2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA950080
        public void .ctor(){} // RVA: 0x7FFACA9500C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA950490
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA9505C0
        public void __ClearDepth__SystemVoid(){} // RVA: 0x7FFACA9506D0
        public void __ClearLayerMask__SystemVoid(){} // RVA: 0x7FFACA950740
        public void __ClearNormalAngle__SystemVoid(){} // RVA: 0x7FFACA9507B0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA950820
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA950960
        public void __GetType__SystemType(){} // RVA: 0x7FFACA950A10
        public void __IsFilteringDepth__UnityEngineGameObject__SystemBoolean(){} // RVA: 0x7FFACA950B00
        public void __IsFilteringLayerMask__UnityEngineGameObject__SystemBoolean(){} // RVA: 0x7FFACA950C30
        public void __IsFilteringNormalAngle__SystemSingle__SystemBoolean(){} // RVA: 0x7FFACA950DC0
        public void __IsFilteringNormalAngle__UnityEngineVector2__SystemBoolean(){} // RVA: 0x7FFACA950F10
        public void __IsFilteringTrigger__UnityEngineCollider2D__SystemBoolean(){} // RVA: 0x7FFACA951050
        public void __NoFilter__UnityEngineContactFilter2D(){} // RVA: 0x7FFACA9511C0
        public void __SetDepth__SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x7FFACA951310
        public void __SetLayerMask__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA951460
        public void __SetNormalAngle__SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9514F0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA951640
        public void __get_NormalAngleUpperLimit__SystemSingle(){} // RVA: 0x7FFACA9516F0
        public void __get_isFiltering__SystemBoolean(){} // RVA: 0x7FFACA951790
        public void __get_layerMask__UnityEngineLayerMask(){} // RVA: 0x7FFACA951860
        public void __set_layerMask__UnityEngineLayerMask(){} // RVA: 0x7FFACA951990
        public void __get_maxDepth__SystemSingle(){} // RVA: 0x7FFACA951A90
        public void __set_maxDepth__SystemSingle(){} // RVA: 0x7FFACA951BC0
        public void __get_maxNormalAngle__SystemSingle(){} // RVA: 0x7FFACA951CD0
        public void __set_maxNormalAngle__SystemSingle(){} // RVA: 0x7FFACA951DF0
        public void __get_minDepth__SystemSingle(){} // RVA: 0x7FFACA951EF0
        public void __set_minDepth__SystemSingle(){} // RVA: 0x7FFACA952010
        public void __get_minNormalAngle__SystemSingle(){} // RVA: 0x7FFACA952120
        public void __set_minNormalAngle__SystemSingle(){} // RVA: 0x7FFACA952250
        public void __get_useDepth__SystemBoolean(){} // RVA: 0x7FFACA952360
        public void __set_useDepth__SystemBoolean(){} // RVA: 0x7FFACA952490
        public void __get_useLayerMask__SystemBoolean(){} // RVA: 0x7FFACA9525A0
        public void __set_useLayerMask__SystemBoolean(){} // RVA: 0x7FFACA9526D0
        public void __get_useNormalAngle__SystemBoolean(){} // RVA: 0x7FFACA9527E0
        public void __set_useNormalAngle__SystemBoolean(){} // RVA: 0x7FFACA952910
        public void __get_useOutsideDepth__SystemBoolean(){} // RVA: 0x7FFACA952A20
        public void __set_useOutsideDepth__SystemBoolean(){} // RVA: 0x7FFACA952B50
        public void __get_useOutsideNormalAngle__SystemBoolean(){} // RVA: 0x7FFACA952C60
        public void __set_useOutsideNormalAngle__SystemBoolean(){} // RVA: 0x7FFACA952D90
        public void __get_useTriggers__SystemBoolean(){} // RVA: 0x7FFACA952EA0
        public void __set_useTriggers__SystemBoolean(){} // RVA: 0x7FFACA952FC0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA9530D0
    }

    public class ExternUnityEngineContactFilter2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA9550B0
        public void .ctor(){} // RVA: 0x7FFACA9550F0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA9554C0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA9555F0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA955700
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9557E0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9558C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA955990
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA955AE0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA955B80
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA955C80
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA955DA0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA955EB0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA955FD0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9560C0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA9561A0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA9562C0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA956450
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA9565A0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA9566D0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA9567F0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA956960
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA956AA0
        public void __Get__SystemInt32__UnityEngineContactFilter2D(){} // RVA: 0x7FFACA956BC0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA956CC0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA956D30
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA956E50
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA956FD0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA957130
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA957260
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA957380
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9574E0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA957630
        public void __Set__SystemInt32_UnityEngineContactFilter2D__SystemVoid(){} // RVA: 0x7FFACA957750
        public void __ToString__SystemString(){} // RVA: 0x7FFACA957860
        public void __ctor__SystemInt32__UnityEngineContactFilter2DArray(){} // RVA: 0x7FFACA957950
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA957AF0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA957B90
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA957C30
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA957CD0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA957D70
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA957E10
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA957EB0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA957F90
    }

    public class ExternUnityEngineContactPoint : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA959EB0
        public void .ctor(){} // RVA: 0x7FFACA959EF0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA95A2C0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA95A3F0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA95A500
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA95A640
        public void __GetType__SystemType(){} // RVA: 0x7FFACA95A6F0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA95A7E0
        public void __get_impulse__UnityEngineVector3(){} // RVA: 0x7FFACA95A890
        public void __get_normal__UnityEngineVector3(){} // RVA: 0x7FFACA95A940
        public void __get_otherCollider__UnityEngineCollider(){} // RVA: 0x7FFACA95AA10
        public void __get_point__UnityEngineVector3(){} // RVA: 0x7FFACA95AB80
        public void __get_separation__SystemSingle(){} // RVA: 0x7FFACA95AC30
        public void __get_thisCollider__UnityEngineCollider(){} // RVA: 0x7FFACA95ACD0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA95AE40
    }

    public class ExternUnityEngineContactPoint2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA95B7A0
        public void .ctor(){} // RVA: 0x7FFACA95B7E0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA95BBB0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA95BCE0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA95BDF0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA95BF30
        public void __GetType__SystemType(){} // RVA: 0x7FFACA95BFE0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA95C0D0
        public void __get_collider__UnityEngineCollider2D(){} // RVA: 0x7FFACA95C180
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA95C2A0
        public void __get_normalImpulse__SystemSingle(){} // RVA: 0x7FFACA95C350
        public void __get_normal__UnityEngineVector2(){} // RVA: 0x7FFACA95C3F0
        public void __get_otherCollider__UnityEngineCollider2D(){} // RVA: 0x7FFACA95C4A0
        public void __get_otherRigidbody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACA95C5C0
        public void __get_point__UnityEngineVector2(){} // RVA: 0x7FFACA95C6E0
        public void __get_relativeVelocity__UnityEngineVector2(){} // RVA: 0x7FFACA95C790
        public void __get_rigidbody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACA95C840
        public void __get_separation__SystemSingle(){} // RVA: 0x7FFACA95C960
        public void __get_tangentImpulse__SystemSingle(){} // RVA: 0x7FFACA95CA00
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA95CAA0
    }

    public class ExternUnityEngineContactPoint2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA95D7C0
        public void .ctor(){} // RVA: 0x7FFACA95D800
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA95DBD0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA95DD00
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA95DE10
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA95DEF0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA95DFD0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA95E0A0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA95E1F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA95E290
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA95E390
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA95E4B0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA95E5C0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA95E6E0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA95E7D0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA95E8B0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA95E9D0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA95EB60
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA95ECB0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA95EDE0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA95EF00
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA95F070
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA95F1B0
        public void __Get__SystemInt32__UnityEngineContactPoint2D(){} // RVA: 0x7FFACA95F2D0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA95F3E0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA95F450
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA95F570
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA95F6F0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA95F850
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA95F980
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA95FAA0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA95FC00
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA95FD50
        public void __Set__SystemInt32_UnityEngineContactPoint2D__SystemVoid(){} // RVA: 0x7FFACA95FE70
        public void __ToString__SystemString(){} // RVA: 0x7FFACA95FF90
        public void __ctor__SystemInt32__UnityEngineContactPoint2DArray(){} // RVA: 0x7FFACA960080
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA960130
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA9601D0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA960270
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA960310
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA9603B0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA960450
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA9604F0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA9605D0
    }

    public class ExternUnityEngineContactPointArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA9624F0
        public void .ctor(){} // RVA: 0x7FFACA962530
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA962900
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA962A30
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA962B40
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA962C20
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA962D00
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA962DD0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA962F20
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA962FC0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9630C0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA9631E0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9632F0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA963410
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA963500
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA9635E0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA963700
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA963890
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA9639E0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA963B10
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA963C30
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA963DA0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA963EE0
        public void __Get__SystemInt32__UnityEngineContactPoint(){} // RVA: 0x7FFACA964000
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA964100
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA964170
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA964290
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA964410
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA964570
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA9646A0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9647C0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA964920
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA964A70
        public void __Set__SystemInt32_UnityEngineContactPoint__SystemVoid(){} // RVA: 0x7FFACA964B90
        public void __ToString__SystemString(){} // RVA: 0x7FFACA964CA0
        public void __ctor__SystemInt32__UnityEngineContactPointArray(){} // RVA: 0x7FFACA964D90
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA964E40
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA964EE0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA964F80
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA965020
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA9650C0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA965160
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA965200
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA9652E0
    }

    public class ExternUnityEngineControllerColliderHit : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA967200
        public void .ctor(){} // RVA: 0x7FFACA967240
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA967610
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA967740
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA967850
        public void __get_collider__UnityEngineCollider(){} // RVA: 0x7FFACA9679A0
        public void __get_controller__UnityEngineCharacterController(){} // RVA: 0x7FFACA967A70
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA967B40
        public void __get_moveDirection__UnityEngineVector3(){} // RVA: 0x7FFACA967C70
        public void __get_moveLength__SystemSingle(){} // RVA: 0x7FFACA967D20
        public void __get_normal__UnityEngineVector3(){} // RVA: 0x7FFACA967DC0
        public void __get_point__UnityEngineVector3(){} // RVA: 0x7FFACA967E70
        public void __get_rigidbody__UnityEngineRigidbody(){} // RVA: 0x7FFACA967F20
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA968050
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA968180
    }

    public class ExternUnityEngineCubemap : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA968AE0
        public void .ctor(){} // RVA: 0x7FFACA968B20
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA968EF0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA969020
        public void __Apply__SystemBoolean_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA969130
        public void __Apply__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA969240
        public void __Apply__SystemVoid(){} // RVA: 0x7FFACA969320
        public void __ClearRequestedMipmapLevel__SystemVoid(){} // RVA: 0x7FFACA9693D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA9694C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA969690
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA9697F0
        public void __GetPixel__UnityEngineCubemapFace_SystemInt32_SystemInt32_SystemInt32__UnityEngineColor(){} // RVA: 0x7FFACA969940
        public void __GetPixel__UnityEngineCubemapFace_SystemInt32_SystemInt32__UnityEngineColor(){} // RVA: 0x7FFACA969B00
        public void __GetPixels__UnityEngineCubemapFace_SystemInt32__UnityEngineColorArray(){} // RVA: 0x7FFACA969C90
        public void __GetPixels__UnityEngineCubemapFace__UnityEngineColorArray(){} // RVA: 0x7FFACA969E20
        public void __GetType__SystemType(){} // RVA: 0x7FFACA969F80
        public void __IncrementUpdateCount__SystemVoid(){} // RVA: 0x7FFACA96A070
        public void __SetPixelData__TArray_SystemInt32_UnityEngineCubemapFace_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA96A160
        public void __SetPixel__UnityEngineCubemapFace_SystemInt32_SystemInt32_UnityEngineColor_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA96A4B0
        public void __SetPixel__UnityEngineCubemapFace_SystemInt32_SystemInt32_UnityEngineColor__SystemVoid(){} // RVA: 0x7FFACA96A690
        public void __SetPixels__UnityEngineColorArray_UnityEngineCubemapFace_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA96A830
        public void __SetPixels__UnityEngineColorArray_UnityEngineCubemapFace__SystemVoid(){} // RVA: 0x7FFACA96A990
        public void __SmoothEdges__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA96AAB0
        public void __SmoothEdges__SystemVoid(){} // RVA: 0x7FFACA96ABD0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA96ACC0
        public void __get_anisoLevel__SystemInt32(){} // RVA: 0x7FFACA96AE10
        public void __get_desiredMipmapLevel__SystemInt32(){} // RVA: 0x7FFACA96AF30
        public void __get_dimension__UnityEngineRenderingTextureDimension(){} // RVA: 0x7FFACA96B050
        public void __get_filterMode__UnityEngineFilterMode(){} // RVA: 0x7FFACA96B140
        public void __get_format__UnityEngineTextureFormat(){} // RVA: 0x7FFACA96B260
        public void __get_height__SystemInt32(){} // RVA: 0x7FFACA96B380
        public void __get_isDataSRGB__SystemBoolean(){} // RVA: 0x7FFACA96B470
        public void __get_isReadable__SystemBoolean(){} // RVA: 0x7FFACA96B5A0
        public void __get_loadedMipmapLevel__SystemInt32(){} // RVA: 0x7FFACA96B690
        public void __get_loadingMipmapLevel__SystemInt32(){} // RVA: 0x7FFACA96B7B0
        public void __get_mipMapBias__SystemSingle(){} // RVA: 0x7FFACA96B8D0
        public void __get_mipmapCount__SystemInt32(){} // RVA: 0x7FFACA96B9F0
        public void __get_name__SystemString(){} // RVA: 0x7FFACA96BB10
        public void __get_requestedMipmapLevel__SystemInt32(){} // RVA: 0x7FFACA96BC60
        public void __get_streamingMipmapsPriority__SystemInt32(){} // RVA: 0x7FFACA96BD80
        public void __get_streamingMipmaps__SystemBoolean(){} // RVA: 0x7FFACA96BEA0
        public void __get_texelSize__UnityEngineVector2(){} // RVA: 0x7FFACA96BFC0
        public void __get_updateCount__SystemUInt32(){} // RVA: 0x7FFACA96C0F0
        public void __get_width__SystemInt32(){} // RVA: 0x7FFACA96C210
        public void __get_wrapModeU__UnityEngineTextureWrapMode(){} // RVA: 0x7FFACA96C300
        public void __get_wrapModeV__UnityEngineTextureWrapMode(){} // RVA: 0x7FFACA96C420
        public void __get_wrapModeW__UnityEngineTextureWrapMode(){} // RVA: 0x7FFACA96C540
        public void __get_wrapMode__UnityEngineTextureWrapMode(){} // RVA: 0x7FFACA96C660
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA96C780
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA96CA80
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA96CC70
        public void __set_anisoLevel__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA96CF70
        public void __set_dimension__UnityEngineRenderingTextureDimension__SystemVoid(){} // RVA: 0x7FFACA96D090
        public void __set_filterMode__UnityEngineFilterMode__SystemVoid(){} // RVA: 0x7FFACA96D180
        public void __set_height__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA96D2A0
        public void __set_mipMapBias__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA96D390
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA96D4C0
        public void __set_requestedMipmapLevel__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA96D610
        public void __set_width__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA96D730
        public void __set_wrapModeU__UnityEngineTextureWrapMode__SystemVoid(){} // RVA: 0x7FFACA96D820
        public void __set_wrapModeV__UnityEngineTextureWrapMode__SystemVoid(){} // RVA: 0x7FFACA96D940
        public void __set_wrapModeW__UnityEngineTextureWrapMode__SystemVoid(){} // RVA: 0x7FFACA96DA60
        public void __set_wrapMode__UnityEngineTextureWrapMode__SystemVoid(){} // RVA: 0x7FFACA96DB80
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA96DCA0
    }

    public class ExternUnityEngineCubemapArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA970AB0
        public void .ctor(){} // RVA: 0x7FFACA970AF0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA970EC0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA970FF0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA971100
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9711E0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9712C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA971390
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA9714E0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA971580
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA971680
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA9717A0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9718B0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA9719D0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA971AC0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA971BA0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA971CC0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA971E50
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA971FA0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA9720D0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA9721F0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA972360
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA9724A0
        public void __Get__SystemInt32__UnityEngineCubemap(){} // RVA: 0x7FFACA9725C0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA9727D0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA972840
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA972960
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA972AE0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA972C40
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA972D70
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA972E90
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA972FF0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA973140
        public void __Set__SystemInt32_UnityEngineCubemap__SystemVoid(){} // RVA: 0x7FFACA973260
        public void __ToString__SystemString(){} // RVA: 0x7FFACA9733F0
        public void __ctor__SystemInt32__UnityEngineCubemapArray(){} // RVA: 0x7FFACA9734E0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA973690
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA973730
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA9737D0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA973870
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA973910
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA9739B0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA973A50
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA973B30
    }

    public class ExternUnityEngineCubemapFace : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA975A50
        public void .ctor(){} // RVA: 0x7FFACA975A90
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA975E60
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA975F90
        public void __CompareTo__SystemObject__SystemInt32(){} // RVA: 0x7FFACA9760A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA9761D0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA976310
        public void __GetType__SystemType(){} // RVA: 0x7FFACA9763C0
        public void __HasFlag__SystemEnum__SystemBoolean(){} // RVA: 0x7FFACA9764B0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA976580
        public void __ToString__SystemString__SystemString(){} // RVA: 0x7FFACA976630
        public void __get_NegativeX__UnityEngineCubemapFace(){} // RVA: 0x7FFACA976700
        public void __get_NegativeY__UnityEngineCubemapFace(){} // RVA: 0x7FFACA976770
        public void __get_NegativeZ__UnityEngineCubemapFace(){} // RVA: 0x7FFACA9767E0
        public void __get_PositiveX__UnityEngineCubemapFace(){} // RVA: 0x7FFACA976850
        public void __get_PositiveY__UnityEngineCubemapFace(){} // RVA: 0x7FFACA9768C0
        public void __get_PositiveZ__UnityEngineCubemapFace(){} // RVA: 0x7FFACA976930
        public void __get_Unknown__UnityEngineCubemapFace(){} // RVA: 0x7FFACA9769A0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA976A10
    }

    public class ExternUnityEngineCubemapFaceArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA977670
        public void .ctor(){} // RVA: 0x7FFACA9776B0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA977A80
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA977BB0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA977CC0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA977DA0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA977E80
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA977F50
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA9780A0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA978140
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA978240
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA978360
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA978470
        public void __GetType__SystemType(){} // RVA: 0x7FFACA978590
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA978680
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA978760
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA978880
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA978A10
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA978B60
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA978C90
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA978DB0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA978F20
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA979060
        public void __Get__SystemInt32__UnityEngineCubemapFace(){} // RVA: 0x7FFACA979180
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA979260
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA9792D0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9793F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA979570
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9796D0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA979800
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA979920
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA979A80
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA979BD0
        public void __Set__SystemInt32_UnityEngineCubemapFace__SystemVoid(){} // RVA: 0x7FFACA979CF0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA979DE0
        public void __ctor__SystemInt32__UnityEngineCubemapFaceArray(){} // RVA: 0x7FFACA979ED0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA97A070
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA97A110
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA97A1B0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA97A250
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA97A2F0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA97A390
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA97A430
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA97A510
    }

    public class ExternUnityEngineCustomRenderTexture : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA97C430
        public void .ctor(){} // RVA: 0x7FFACA97C470
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA97C840
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA97C970
        public void __ClearUpdateZones__SystemVoid(){} // RVA: 0x7FFACA97CA80
        public void __ConvertToEquirect__UnityEngineRenderTexture_UnityEngineCameraMonoOrStereoscopicEye__SystemVoid(){} // RVA: 0x7FFACA97CB70
        public void __DiscardContents__SystemBoolean_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA97CC90
        public void __DiscardContents__SystemVoid(){} // RVA: 0x7FFACA97CDA0
        public void __EnsureDoubleBufferConsistency__SystemVoid(){} // RVA: 0x7FFACA97CE90
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA97CF80
        public void __GenerateMips__SystemVoid(){} // RVA: 0x7FFACA97D150
        public void __GetDoubleBufferRenderTexture__UnityEngineRenderTexture(){} // RVA: 0x7FFACA97D240
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA97D380
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA97D4E0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA97D630
        public void __GetUpdateZones__SystemCollectionsGenericListUnityEngineCustomRenderTextureUpdateZone__SystemVoid(){} // RVA: 0x7FFACA97D720
        public void __IncrementUpdateCount__SystemVoid(){} // RVA: 0x7FFACA97D910
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA97DA00
        public void __IsCreated__SystemBoolean(){} // RVA: 0x7FFACA97DB40
        public void __Release__SystemVoid(){} // RVA: 0x7FFACA97DC60
        public void __ResolveAntiAliasedSurface__SystemVoid(){} // RVA: 0x7FFACA97DD50
        public void __ResolveAntiAliasedSurface__UnityEngineRenderTexture__SystemVoid(){} // RVA: 0x7FFACA97DE40
        public void __SetUpdateZones__UnityEngineCustomRenderTextureUpdateZoneArray__SystemVoid(){} // RVA: 0x7FFACA97DF70
        public void __ToString__SystemString(){} // RVA: 0x7FFACA97E1B0
        public void __Update__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA97E300
        public void __Update__SystemVoid(){} // RVA: 0x7FFACA97E3E0
        public void __get_anisoLevel__SystemInt32(){} // RVA: 0x7FFACA97E490
        public void __get_antiAliasing__SystemInt32(){} // RVA: 0x7FFACA97E5B0
        public void __get_autoGenerateMips__SystemBoolean(){} // RVA: 0x7FFACA97E6D0
        public void __get_bindTextureMS__SystemBoolean(){} // RVA: 0x7FFACA97E7F0
        public void __get_colorBuffer__UnityEngineRenderBuffer(){} // RVA: 0x7FFACA97E910
        public void __get_cubemapFaceMask__SystemUInt32(){} // RVA: 0x7FFACA97EA50
        public void __get_depthBuffer__UnityEngineRenderBuffer(){} // RVA: 0x7FFACA97EB70
        public void __get_depth__SystemInt32(){} // RVA: 0x7FFACA97ECB0
        public void __get_descriptor__UnityEngineRenderTextureDescriptor(){} // RVA: 0x7FFACA97EDD0
        public void __get_dimension__UnityEngineRenderingTextureDimension(){} // RVA: 0x7FFACA97EEF0
        public void __get_doubleBuffered__SystemBoolean(){} // RVA: 0x7FFACA97EFE0
        public void __get_enableRandomWrite__SystemBoolean(){} // RVA: 0x7FFACA97F100
        public void __get_filterMode__UnityEngineFilterMode(){} // RVA: 0x7FFACA97F220
        public void __get_format__UnityEngineRenderTextureFormat(){} // RVA: 0x7FFACA97F340
        public void __get_height__SystemInt32(){} // RVA: 0x7FFACA97F420
        public void __get_initializationColor__UnityEngineColor(){} // RVA: 0x7FFACA97F510
        public void __get_initializationMaterial__UnityEngineMaterial(){} // RVA: 0x7FFACA97F650
        public void __get_initializationMode__UnityEngineCustomRenderTextureUpdateMode(){} // RVA: 0x7FFACA97F790
        public void __get_initializationSource__UnityEngineCustomRenderTextureInitializationSource(){} // RVA: 0x7FFACA97F8B0
        public void __get_initializationTexture__UnityEngineTexture(){} // RVA: 0x7FFACA97F9D0
        public void __get_isDataSRGB__SystemBoolean(){} // RVA: 0x7FFACA97FB10
        public void __get_isPowerOfTwo__SystemBoolean(){} // RVA: 0x7FFACA97FC40
        public void __get_isReadable__SystemBoolean(){} // RVA: 0x7FFACA97FD60
        public void __get_material__UnityEngineMaterial(){} // RVA: 0x7FFACA97FE50
        public void __get_mipMapBias__SystemSingle(){} // RVA: 0x7FFACA97FF90
        public void __get_mipmapCount__SystemInt32(){} // RVA: 0x7FFACA9800B0
        public void __get_name__SystemString(){} // RVA: 0x7FFACA9801D0
        public void __get_sRGB__SystemBoolean(){} // RVA: 0x7FFACA980320
        public void __get_shaderPass__SystemInt32(){} // RVA: 0x7FFACA980440
        public void __get_texelSize__UnityEngineVector2(){} // RVA: 0x7FFACA980560
        public void __get_updateCount__SystemUInt32(){} // RVA: 0x7FFACA980690
        public void __get_updateMode__UnityEngineCustomRenderTextureUpdateMode(){} // RVA: 0x7FFACA9807B0
        public void __get_updatePeriod__SystemSingle(){} // RVA: 0x7FFACA9808D0
        public void __get_updateZoneSpace__UnityEngineCustomRenderTextureUpdateZoneSpace(){} // RVA: 0x7FFACA9809F0
        public void __get_useDynamicScale__SystemBoolean(){} // RVA: 0x7FFACA980B10
        public void __get_useMipMap__SystemBoolean(){} // RVA: 0x7FFACA980C30
        public void __get_volumeDepth__SystemInt32(){} // RVA: 0x7FFACA980D50
        public void __get_vrUsage__UnityEngineVRTextureUsage(){} // RVA: 0x7FFACA980E70
        public void __get_width__SystemInt32(){} // RVA: 0x7FFACA980F90
        public void __get_wrapModeU__UnityEngineTextureWrapMode(){} // RVA: 0x7FFACA981080
        public void __get_wrapModeV__UnityEngineTextureWrapMode(){} // RVA: 0x7FFACA9811A0
        public void __get_wrapModeW__UnityEngineTextureWrapMode(){} // RVA: 0x7FFACA9812C0
        public void __get_wrapMode__UnityEngineTextureWrapMode(){} // RVA: 0x7FFACA9813E0
        public void __get_wrapUpdateZones__SystemBoolean(){} // RVA: 0x7FFACA981500
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA981620
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA981920
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA981B10
        public void __set_anisoLevel__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA981E10
        public void __set_antiAliasing__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA981F30
        public void __set_autoGenerateMips__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA982050
        public void __set_bindTextureMS__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA982180
        public void __set_cubemapFaceMask__SystemUInt32__SystemVoid(){} // RVA: 0x7FFACA9822B0
        public void __set_depth__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9823D0
        public void __set_descriptor__UnityEngineRenderTextureDescriptor__SystemVoid(){} // RVA: 0x7FFACA9824F0
        public void __set_dimension__UnityEngineRenderingTextureDimension__SystemVoid(){} // RVA: 0x7FFACA982610
        public void __set_doubleBuffered__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA982700
        public void __set_enableRandomWrite__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA982830
        public void __set_filterMode__UnityEngineFilterMode__SystemVoid(){} // RVA: 0x7FFACA982960
        public void __set_format__UnityEngineRenderTextureFormat__SystemVoid(){} // RVA: 0x7FFACA982A80
        public void __set_height__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA982B60
        public void __set_initializationColor__UnityEngineColor__SystemVoid(){} // RVA: 0x7FFACA982C50
        public void __set_initializationMaterial__UnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACA982D80
        public void __set_initializationMode__UnityEngineCustomRenderTextureUpdateMode__SystemVoid(){} // RVA: 0x7FFACA982ED0
        public void __set_initializationSource__UnityEngineCustomRenderTextureInitializationSource__SystemVoid(){} // RVA: 0x7FFACA982FF0
        public void __set_initializationTexture__UnityEngineTexture__SystemVoid(){} // RVA: 0x7FFACA983110
        public void __set_isPowerOfTwo__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA983260
        public void __set_material__UnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACA983330
        public void __set_mipMapBias__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA983480
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA9835B0
        public void __set_shaderPass__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA983700
        public void __set_updateMode__UnityEngineCustomRenderTextureUpdateMode__SystemVoid(){} // RVA: 0x7FFACA983820
        public void __set_updatePeriod__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA983940
        public void __set_updateZoneSpace__UnityEngineCustomRenderTextureUpdateZoneSpace__SystemVoid(){} // RVA: 0x7FFACA983A70
        public void __set_useDynamicScale__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA983B90
        public void __set_useMipMap__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA983CC0
        public void __set_volumeDepth__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA983DF0
        public void __set_vrUsage__UnityEngineVRTextureUsage__SystemVoid(){} // RVA: 0x7FFACA983F10
        public void __set_width__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA984030
        public void __set_wrapModeU__UnityEngineTextureWrapMode__SystemVoid(){} // RVA: 0x7FFACA984120
        public void __set_wrapModeV__UnityEngineTextureWrapMode__SystemVoid(){} // RVA: 0x7FFACA984240
        public void __set_wrapModeW__UnityEngineTextureWrapMode__SystemVoid(){} // RVA: 0x7FFACA984360
        public void __set_wrapMode__UnityEngineTextureWrapMode__SystemVoid(){} // RVA: 0x7FFACA984480
        public void __set_wrapUpdateZones__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9845A0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA9846D0
    }

    public class ExternUnityEngineCustomRenderTextureArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA989770
        public void .ctor(){} // RVA: 0x7FFACA9897B0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA989B80
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA989CB0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA989DC0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA989EA0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA989F80
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA98A050
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA98A1A0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA98A240
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA98A340
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA98A460
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA98A570
        public void __GetType__SystemType(){} // RVA: 0x7FFACA98A690
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA98A780
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA98A860
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA98A980
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA98AB10
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA98AC60
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA98AD90
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA98AEB0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA98B020
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA98B160
        public void __Get__SystemInt32__UnityEngineCustomRenderTexture(){} // RVA: 0x7FFACA98B280
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA98B490
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA98B500
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA98B620
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA98B7A0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA98B900
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA98BA30
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA98BB50
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA98BCB0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA98BE00
        public void __Set__SystemInt32_UnityEngineCustomRenderTexture__SystemVoid(){} // RVA: 0x7FFACA98BF20
        public void __ToString__SystemString(){} // RVA: 0x7FFACA98C0B0
        public void __ctor__SystemInt32__UnityEngineCustomRenderTextureArray(){} // RVA: 0x7FFACA98C1A0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA98C350
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA98C3F0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA98C490
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA98C530
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA98C5D0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA98C670
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA98C710
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA98C7F0
    }

    public class ExternUnityEngineDebug : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA98E710
        public void .ctor(){} // RVA: 0x7FFACA98E750
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA98EB20
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA98EC50
        public void __AssertFormat__SystemBoolean_SystemString_SystemObjectArray__SystemVoid(){} // RVA: 0x7FFACA98ED60
        public void __AssertFormat__SystemBoolean_UnityEngineObject_SystemString_SystemObjectArray__SystemVoid(){} // RVA: 0x7FFACA98EE50
        public void __Assert__SystemBoolean_SystemObject_UnityEngineObject__SystemVoid(){} // RVA: 0x7FFACA98F000
        public void __Assert__SystemBoolean_SystemObject__SystemVoid(){} // RVA: 0x7FFACA98F1A0
        public void __Assert__SystemBoolean_SystemString_UnityEngineObject__SystemVoid(){} // RVA: 0x7FFACA98F280
        public void __Assert__SystemBoolean_SystemString__SystemVoid(){} // RVA: 0x7FFACA98F3F0
        public void __Assert__SystemBoolean_UnityEngineObject__SystemVoid(){} // RVA: 0x7FFACA98F480
        public void __Assert__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA98F5C0
        public void __DebugBreak__SystemVoid(){} // RVA: 0x7FFACA98F630
        public void __DrawLine__UnityEngineVector3_UnityEngineVector3_UnityEngineColor_SystemSingle_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA98F6B0
        public void __DrawLine__UnityEngineVector3_UnityEngineVector3_UnityEngineColor_SystemSingle__SystemVoid(){} // RVA: 0x7FFACA98F920
        public void __DrawLine__UnityEngineVector3_UnityEngineVector3_UnityEngineColor__SystemVoid(){} // RVA: 0x7FFACA98FB90
        public void __DrawLine__UnityEngineVector3_UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA98FDC0
        public void __DrawRay__UnityEngineVector3_UnityEngineVector3_UnityEngineColor_SystemSingle_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA98FED0
        public void __DrawRay__UnityEngineVector3_UnityEngineVector3_UnityEngineColor_SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9900D0
        public void __DrawRay__UnityEngineVector3_UnityEngineVector3_UnityEngineColor__SystemVoid(){} // RVA: 0x7FFACA9902D0
        public void __DrawRay__UnityEngineVector3_UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA990490
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA990610
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA990760
        public void __GetType__SystemType(){} // RVA: 0x7FFACA990860
        public void __LogAssertionFormat__SystemString_SystemObjectArray__SystemVoid(){} // RVA: 0x7FFACA990950
        public void __LogAssertionFormat__UnityEngineObject_SystemString_SystemObjectArray__SystemVoid(){} // RVA: 0x7FFACA990A10
        public void __LogAssertion__SystemObject_UnityEngineObject__SystemVoid(){} // RVA: 0x7FFACA990B90
        public void __LogAssertion__SystemObject__SystemVoid(){} // RVA: 0x7FFACA990D00
        public void __LogErrorFormat__SystemString_SystemObjectArray__SystemVoid(){} // RVA: 0x7FFACA990DB0
        public void __LogErrorFormat__UnityEngineObject_SystemString_SystemObjectArray__SystemVoid(){} // RVA: 0x7FFACA990EC0
        public void __LogError__SystemObject_UnityEngineObject__SystemVoid(){} // RVA: 0x7FFACA991090
        public void __LogError__SystemObject__SystemVoid(){} // RVA: 0x7FFACA991240
        public void __LogException__SystemException_UnityEngineObject__SystemVoid(){} // RVA: 0x7FFACA991320
        public void __LogException__SystemException__SystemVoid(){} // RVA: 0x7FFACA9914A0
        public void __LogFormat__SystemString_SystemObjectArray__SystemVoid(){} // RVA: 0x7FFACA991540
        public void __LogFormat__UnityEngineLogType_UnityEngineLogOption_UnityEngineObject_SystemString_SystemObjectArray__SystemVoid(){} // RVA: 0x7FFACA991650
        public void __LogFormat__UnityEngineObject_SystemString_SystemObjectArray__SystemVoid(){} // RVA: 0x7FFACA9918C0
        public void __LogWarningFormat__SystemString_SystemObjectArray__SystemVoid(){} // RVA: 0x7FFACA991A90
        public void __LogWarningFormat__UnityEngineObject_SystemString_SystemObjectArray__SystemVoid(){} // RVA: 0x7FFACA991BA0
        public void __LogWarning__SystemObject_UnityEngineObject__SystemVoid(){} // RVA: 0x7FFACA991D70
        public void __LogWarning__SystemObject__SystemVoid(){} // RVA: 0x7FFACA991F20
        public void __Log__SystemObject_UnityEngineObject__SystemVoid(){} // RVA: 0x7FFACA992000
        public void __Log__SystemObject__SystemVoid(){} // RVA: 0x7FFACA9921B0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA992290
        public void __ctor____UnityEngineDebug(){} // RVA: 0x7FFACA992380
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA992400
    }

    public class ExternUnityEngineDebugArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA994490
        public void .ctor(){} // RVA: 0x7FFACA9944D0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA9948A0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA9949D0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA994AE0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA994BC0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA994CA0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA994D70
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA994EC0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA994F60
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA995060
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA995180
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA995290
        public void __GetType__SystemType(){} // RVA: 0x7FFACA9953B0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9954A0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA995580
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA9956A0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA995830
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA995980
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA995AB0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA995BD0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA995D40
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA995E80
        public void __Get__SystemInt32__UnityEngineDebug(){} // RVA: 0x7FFACA995FA0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA996080
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA9960F0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA996210
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA996390
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9964F0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA996620
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA996740
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9968A0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9969F0
        public void __Set__SystemInt32_UnityEngineDebug__SystemVoid(){} // RVA: 0x7FFACA996B10
        public void __ToString__SystemString(){} // RVA: 0x7FFACA996D50
        public void __ctor__SystemInt32__UnityEngineDebugArray(){} // RVA: 0x7FFACA996E40
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA996FE0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA997080
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA997120
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA9971C0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA997260
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA997300
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA9973A0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA997480
    }

    public class ExternUnityEngineDistanceJoint2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA9993A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA9993E0
        public void .ctor(){} // RVA: 0x7FFACA999490
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA999860
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA999990
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA999AA0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA999C70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA999D60
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA99A010
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA99A170
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA99A290
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA99A380
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA99A600
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA99A6F0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA99A9A0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA99AB00
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA99AC20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA99AD10
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA99AF90
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA99B100
        public void __GetComponent__T(){} // RVA: 0x7FFACA99B220
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA99B300
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA99B550
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA99B640
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA99B970
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA99BA60
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA99BDA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA99BE90
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA99C1A0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA99C310
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA99C440
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA99C530
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA99C820
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA99C910
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA99CC50
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA99CD40
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA99D050
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA99D1C0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA99D300
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA99D3F0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA99D6E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA99D7D0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA99DAC0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA99DC10
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA99DD40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA99DE30
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA99E0E0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA99E240
        public void __GetReactionForce__SystemSingle__UnityEngineVector2(){} // RVA: 0x7FFACA99E390
        public void __GetReactionTorque__SystemSingle__SystemSingle(){} // RVA: 0x7FFACA99E4A0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA99E600
        public void __ToString__SystemString(){} // RVA: 0x7FFACA99E6F0
        public void __get_anchor__UnityEngineVector2(){} // RVA: 0x7FFACA99E840
        public void __get_attachedRigidbody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACA99E970
        public void __get_autoConfigureConnectedAnchor__SystemBoolean(){} // RVA: 0x7FFACA99EAB0
        public void __get_autoConfigureDistance__SystemBoolean(){} // RVA: 0x7FFACA99EBD0
        public void __get_breakAction__UnityEngineJointBreakAction2D(){} // RVA: 0x7FFACA99ECF0
        public void __get_breakForce__SystemSingle(){} // RVA: 0x7FFACA99EE10
        public void __get_breakTorque__SystemSingle(){} // RVA: 0x7FFACA99EF30
        public void __get_connectedAnchor__UnityEngineVector2(){} // RVA: 0x7FFACA99F050
        public void __get_connectedBody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACA99F180
        public void __get_distance__SystemSingle(){} // RVA: 0x7FFACA99F2C0
        public void __get_enableCollision__SystemBoolean(){} // RVA: 0x7FFACA99F3E0
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA99F500
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA99F620
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACA99F760
        public void __get_maxDistanceOnly__SystemBoolean(){} // RVA: 0x7FFACA99F880
        public void __get_name__SystemString(){} // RVA: 0x7FFACA99F9A0
        public void __get_reactionForce__UnityEngineVector2(){} // RVA: 0x7FFACA99FAF0
        public void __get_reactionTorque__SystemSingle(){} // RVA: 0x7FFACA99FC20
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA99FD40
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA99FE80
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA9A0180
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA9A0370
        public void __set_anchor__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA9A0670
        public void __set_autoConfigureConnectedAnchor__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9A0790
        public void __set_autoConfigureDistance__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9A08C0
        public void __set_breakAction__UnityEngineJointBreakAction2D__SystemVoid(){} // RVA: 0x7FFACA9A09F0
        public void __set_breakForce__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9A0B10
        public void __set_breakTorque__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9A0C40
        public void __set_connectedAnchor__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA9A0D70
        public void __set_connectedBody__UnityEngineRigidbody2D__SystemVoid(){} // RVA: 0x7FFACA9A0E90
        public void __set_distance__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9A0FE0
        public void __set_enableCollision__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9A1110
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9A1240
        public void __set_maxDistanceOnly__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9A1370
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA9A14A0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA9A15F0
    }

    public class ExternUnityEngineDistanceJoint2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA9A4AC0
        public void .ctor(){} // RVA: 0x7FFACA9A4B00
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA9A4ED0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA9A5000
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA9A5110
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9A51F0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9A52D0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA9A53A0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA9A54F0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA9A5590
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9A5690
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA9A57B0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9A58C0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA9A59E0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9A5AD0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA9A5BB0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA9A5CD0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA9A5E60
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA9A5FB0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA9A60E0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA9A6200
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA9A6370
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA9A64B0
        public void __Get__SystemInt32__UnityEngineDistanceJoint2D(){} // RVA: 0x7FFACA9A65D0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA9A6710
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA9A6780
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9A68A0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9A6A20
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9A6B80
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA9A6CB0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9A6DD0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9A6F30
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9A7080
        public void __Set__SystemInt32_UnityEngineDistanceJoint2D__SystemVoid(){} // RVA: 0x7FFACA9A71A0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA9A7330
        public void __ctor__SystemInt32__UnityEngineDistanceJoint2DArray(){} // RVA: 0x7FFACA9A7420
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA9A7510
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA9A75B0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA9A7650
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA9A76F0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA9A7790
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA9A7830
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA9A78D0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA9A79B0
    }

    public class ExternUnityEngineEdgeCollider2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA9A98D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA9A9910
        public void .ctor(){} // RVA: 0x7FFACA9A99C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA9A9D90
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA9A9EC0
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D_SystemSingle_SystemBoolean__SystemInt32(){} // RVA: 0x7FFACA9A9FD0
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle_SystemBoolean__SystemInt32(){} // RVA: 0x7FFACA9AA2A0
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA9AA570
        public void __Cast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA9AA7F0
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemBoolean__SystemInt32(){} // RVA: 0x7FFACA9AAA30
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA9AAC00
        public void __Cast__UnityEngineVector2_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA9AAD90
        public void __ClosestPoint__UnityEngineVector2__UnityEngineVector2(){} // RVA: 0x7FFACA9AAEE0
        public void __CreateMesh__SystemBoolean_SystemBoolean__UnityEngineMesh(){} // RVA: 0x7FFACA9AB040
        public void __Distance__UnityEngineCollider2D__UnityEngineColliderDistance2D(){} // RVA: 0x7FFACA9AB1A0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA9AB330
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA9AB500
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA9AB5F0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA9AB8A0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA9ABA00
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA9ABB20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA9ABC10
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA9ABE90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA9ABF80
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA9AC230
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA9AC390
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA9AC4B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA9AC5A0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA9AC820
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA9AC990
        public void __GetComponent__T(){} // RVA: 0x7FFACA9ACAB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA9ACB90
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA9ACDE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA9ACED0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9AD200
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9AD2F0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA9AD630
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA9AD720
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA9ADA30
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA9ADBA0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA9ADCD0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA9ADDC0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9AE0B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9AE1A0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA9AE4E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA9AE5D0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA9AE8E0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA9AEA50
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA9AEB90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA9AEC80
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA9AEF70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA9AF060
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA9AF350
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA9AF4A0
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA9AF5D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA9AF6C0
        public void __GetContacts__SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACA9AF970
        public void __GetContacts__SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACA9AFAC0
        public void __GetContacts__UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACA9AFBD0
        public void __GetContacts__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACA9AFD20
        public void __GetContacts__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineContactPoint2D__SystemInt32(){} // RVA: 0x7FFACA9AFF50
        public void __GetContacts__UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACA9B0130
        public void __GetContacts__UnityEngineContactFilter2D_UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACA9B0360
        public void __GetContacts__UnityEngineContactPoint2DArray__SystemInt32(){} // RVA: 0x7FFACA9B0540
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA9B0650
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA9B07B0
        public void __GetPoints__SystemCollectionsGenericListUnityEngineVector2__SystemInt32(){} // RVA: 0x7FFACA9B0900
        public void __GetShapeHash__SystemUInt32(){} // RVA: 0x7FFACA9B0A60
        public void __GetShapes__UnityEnginePhysicsShapeGroup2D_SystemInt32_SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9B0B80
        public void __GetShapes__UnityEnginePhysicsShapeGroup2D__SystemInt32(){} // RVA: 0x7FFACA9B0D00
        public void __GetType__SystemType(){} // RVA: 0x7FFACA9B0E80
        public void __IsTouchingLayers__SystemBoolean(){} // RVA: 0x7FFACA9B0F70
        public void __IsTouchingLayers__SystemInt32__SystemBoolean(){} // RVA: 0x7FFACA9B10A0
        public void __IsTouching__UnityEngineCollider2D_UnityEngineContactFilter2D__SystemBoolean(){} // RVA: 0x7FFACA9B1200
        public void __IsTouching__UnityEngineCollider2D__SystemBoolean(){} // RVA: 0x7FFACA9B13C0
        public void __IsTouching__UnityEngineContactFilter2D__SystemBoolean(){} // RVA: 0x7FFACA9B1520
        public void __OverlapCollider__UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineCollider2D__SystemInt32(){} // RVA: 0x7FFACA9B16A0
        public void __OverlapCollider__UnityEngineContactFilter2D_UnityEngineCollider2DArray__SystemInt32(){} // RVA: 0x7FFACA9B18D0
        public void __OverlapPoint__UnityEngineVector2__SystemBoolean(){} // RVA: 0x7FFACA9B1B00
        public void __Raycast__UnityEngineVector2_UnityEngineContactFilter2D_SystemCollectionsGenericListUnityEngineRaycastHit2D_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA9B1C60
        public void __Raycast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA9B1ED0
        public void __Raycast__UnityEngineVector2_UnityEngineContactFilter2D_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA9B2140
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA9B2370
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA9B25C0
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle_SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9B27D0
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray_SystemSingle__SystemInt32(){} // RVA: 0x7FFACA9B29A0
        public void __Raycast__UnityEngineVector2_UnityEngineRaycastHit2DArray__SystemInt32(){} // RVA: 0x7FFACA9B2B30
        public void __Reset__SystemVoid(){} // RVA: 0x7FFACA9B2C80
        public void __SetPoints__SystemCollectionsGenericListUnityEngineVector2__SystemBoolean(){} // RVA: 0x7FFACA9B2D70
        public void __ToString__SystemString(){} // RVA: 0x7FFACA9B2ED0
        public void __get_adjacentEndPoint__UnityEngineVector2(){} // RVA: 0x7FFACA9B3020
        public void __get_adjacentStartPoint__UnityEngineVector2(){} // RVA: 0x7FFACA9B3150
        public void __get_attachedRigidbody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACA9B3280
        public void __get_bounciness__SystemSingle(){} // RVA: 0x7FFACA9B33C0
        public void __get_bounds__UnityEngineBounds(){} // RVA: 0x7FFACA9B34E0
        public void __get_callbackLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA9B3630
        public void __get_composite__UnityEngineCompositeCollider2D(){} // RVA: 0x7FFACA9B3760
        public void __get_contactCaptureLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA9B38A0
        public void __get_density__SystemSingle(){} // RVA: 0x7FFACA9B39D0
        public void __get_edgeCount__SystemInt32(){} // RVA: 0x7FFACA9B3AF0
        public void __get_edgeRadius__SystemSingle(){} // RVA: 0x7FFACA9B3C10
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA9B3D30
        public void __get_errorState__UnityEngineColliderErrorState2D(){} // RVA: 0x7FFACA9B3E50
        public void __get_excludeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA9B3F70
        public void __get_forceReceiveLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA9B40A0
        public void __get_forceSendLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA9B41D0
        public void __get_friction__SystemSingle(){} // RVA: 0x7FFACA9B4300
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA9B4420
        public void __get_includeLayers__UnityEngineLayerMask(){} // RVA: 0x7FFACA9B4560
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACA9B4690
        public void __get_isTrigger__SystemBoolean(){} // RVA: 0x7FFACA9B47B0
        public void __get_layerOverridePriority__SystemInt32(){} // RVA: 0x7FFACA9B48D0
        public void __get_name__SystemString(){} // RVA: 0x7FFACA9B49F0
        public void __get_offset__UnityEngineVector2(){} // RVA: 0x7FFACA9B4B40
        public void __get_pointCount__SystemInt32(){} // RVA: 0x7FFACA9B4C70
        public void __get_points__UnityEngineVector2Array(){} // RVA: 0x7FFACA9B4D90
        public void __get_shapeCount__SystemInt32(){} // RVA: 0x7FFACA9B4EB0
        public void __get_sharedMaterial__UnityEnginePhysicsMaterial2D(){} // RVA: 0x7FFACA9B4FD0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA9B5110
        public void __get_useAdjacentEndPoint__SystemBoolean(){} // RVA: 0x7FFACA9B5250
        public void __get_useAdjacentStartPoint__SystemBoolean(){} // RVA: 0x7FFACA9B5370
        public void __get_usedByComposite__SystemBoolean(){} // RVA: 0x7FFACA9B5490
        public void __get_usedByEffector__SystemBoolean(){} // RVA: 0x7FFACA9B55B0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA9B56D0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA9B59D0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA9B5BC0
        public void __set_adjacentEndPoint__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA9B5EC0
        public void __set_adjacentStartPoint__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA9B5FE0
        public void __set_callbackLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA9B6100
        public void __set_contactCaptureLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA9B6220
        public void __set_density__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9B6340
        public void __set_edgeRadius__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9B6470
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9B65A0
        public void __set_excludeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA9B66D0
        public void __set_forceReceiveLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA9B67F0
        public void __set_forceSendLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA9B6910
        public void __set_includeLayers__UnityEngineLayerMask__SystemVoid(){} // RVA: 0x7FFACA9B6A30
        public void __set_isTrigger__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9B6B50
        public void __set_layerOverridePriority__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9B6C80
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA9B6DA0
        public void __set_offset__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA9B6EF0
        public void __set_points__UnityEngineVector2Array__SystemVoid(){} // RVA: 0x7FFACA9B7010
        public void __set_sharedMaterial__UnityEnginePhysicsMaterial2D__SystemVoid(){} // RVA: 0x7FFACA9B7130
        public void __set_useAdjacentEndPoint__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9B7280
        public void __set_useAdjacentStartPoint__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9B73B0
        public void __set_usedByComposite__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9B74E0
        public void __set_usedByEffector__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9B7610
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA9B7740
    }

    public class ExternUnityEngineEdgeCollider2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA9BD920
        public void .ctor(){} // RVA: 0x7FFACA9BD960
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA9BDD30
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA9BDE60
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA9BDF70
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9BE050
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9BE130
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA9BE200
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA9BE350
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA9BE3F0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9BE4F0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA9BE610
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9BE720
        public void __GetType__SystemType(){} // RVA: 0x7FFACA9BE840
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9BE930
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA9BEA10
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA9BEB30
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA9BECC0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA9BEE10
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA9BEF40
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA9BF060
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA9BF1D0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA9BF310
        public void __Get__SystemInt32__UnityEngineEdgeCollider2D(){} // RVA: 0x7FFACA9BF430
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA9BF570
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA9BF5E0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9BF700
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9BF880
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9BF9E0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA9BFB10
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9BFC30
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9BFD90
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9BFEE0
        public void __Set__SystemInt32_UnityEngineEdgeCollider2D__SystemVoid(){} // RVA: 0x7FFACA9C0000
        public void __ToString__SystemString(){} // RVA: 0x7FFACA9C0190
        public void __ctor__SystemInt32__UnityEngineEdgeCollider2DArray(){} // RVA: 0x7FFACA9C0280
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA9C0370
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA9C0410
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA9C04B0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA9C0550
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA9C05F0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA9C0690
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA9C0730
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA9C0810
    }

    public class ExternUnityEngineEffector2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA9C2730
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA9C2770
        public void .ctor(){} // RVA: 0x7FFACA9C2820
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA9C2BF0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA9C2D20
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA9C2E30
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA9C3000
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA9C30F0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA9C33A0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA9C3500
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA9C3620
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA9C3710
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA9C3990
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA9C3A80
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA9C3D30
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA9C3E90
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA9C3FB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA9C40A0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA9C4320
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA9C4490
        public void __GetComponent__T(){} // RVA: 0x7FFACA9C45B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA9C4690
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA9C48E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA9C49D0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9C4D00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9C4DF0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA9C5130
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA9C5220
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA9C5530
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA9C56A0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA9C57D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA9C58C0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9C5BB0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9C5CA0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA9C5FE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA9C60D0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA9C63E0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA9C6550
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA9C6690
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA9C6780
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA9C6A70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA9C6B60
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA9C6E50
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA9C6FA0
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA9C70D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA9C71C0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA9C7470
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA9C75D0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA9C7720
        public void __ToString__SystemString(){} // RVA: 0x7FFACA9C7810
        public void __get_colliderMask__SystemInt32(){} // RVA: 0x7FFACA9C7960
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA9C7A80
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA9C7BA0
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACA9C7CE0
        public void __get_name__SystemString(){} // RVA: 0x7FFACA9C7E00
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA9C7F50
        public void __get_useColliderMask__SystemBoolean(){} // RVA: 0x7FFACA9C8090
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA9C81B0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA9C84B0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA9C86A0
        public void __set_colliderMask__SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9C89A0
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9C8AC0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA9C8BF0
        public void __set_useColliderMask__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9C8D40
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA9C8E70
    }

    public class ExternUnityEngineEffector2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA9CB200
        public void .ctor(){} // RVA: 0x7FFACA9CB240
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA9CB610
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA9CB740
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA9CB850
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9CB930
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9CBA10
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA9CBAE0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA9CBC30
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA9CBCD0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9CBDD0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA9CBEF0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9CC000
        public void __GetType__SystemType(){} // RVA: 0x7FFACA9CC120
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9CC210
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA9CC2F0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA9CC410
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA9CC5A0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA9CC6F0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA9CC820
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA9CC940
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA9CCAB0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA9CCBF0
        public void __Get__SystemInt32__UnityEngineEffector2D(){} // RVA: 0x7FFACA9CCD10
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA9CCE50
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA9CCEC0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9CCFE0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9CD160
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9CD2C0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA9CD3F0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9CD510
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9CD670
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9CD7C0
        public void __Set__SystemInt32_UnityEngineEffector2D__SystemVoid(){} // RVA: 0x7FFACA9CD8E0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA9CDAA0
        public void __ctor__SystemInt32__UnityEngineEffector2DArray(){} // RVA: 0x7FFACA9CDB90
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA9CDC80
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA9CDD20
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA9CDDC0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA9CDE60
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA9CDF00
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA9CDFA0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA9CE040
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA9CE120
    }

    public class ExternUnityEngineFixedJoint : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA9D0040
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA9D0080
        public void .ctor(){} // RVA: 0x7FFACA9D0130
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA9D0500
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA9D0630
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA9D0740
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA9D0910
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA9D0A00
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA9D0CB0
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA9D0E10
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA9D0F30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA9D1020
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA9D12A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA9D1390
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA9D1640
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA9D17A0
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA9D18C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA9D19B0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA9D1C30
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA9D1DA0
        public void __GetComponent__T(){} // RVA: 0x7FFACA9D1EC0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA9D1FA0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA9D21F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA9D22E0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9D2610
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9D2700
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA9D2A40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA9D2B30
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA9D2E40
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA9D2FB0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA9D30E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA9D31D0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9D34C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9D35B0
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA9D38F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA9D39E0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA9D3CF0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA9D3E60
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA9D3FA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA9D4090
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA9D4380
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA9D4470
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA9D4760
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA9D48B0
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA9D49E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA9D4AD0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA9D4D80
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA9D4EE0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA9D5030
        public void __ToString__SystemString(){} // RVA: 0x7FFACA9D5120
        public void __get_anchor__UnityEngineVector3(){} // RVA: 0x7FFACA9D5270
        public void __get_autoConfigureConnectedAnchor__SystemBoolean(){} // RVA: 0x7FFACA9D53B0
        public void __get_axis__UnityEngineVector3(){} // RVA: 0x7FFACA9D54D0
        public void __get_breakForce__SystemSingle(){} // RVA: 0x7FFACA9D5610
        public void __get_breakTorque__SystemSingle(){} // RVA: 0x7FFACA9D5730
        public void __get_connectedAnchor__UnityEngineVector3(){} // RVA: 0x7FFACA9D5850
        public void __get_connectedArticulationBody__UnityEngineArticulationBody(){} // RVA: 0x7FFACA9D5990
        public void __get_connectedBody__UnityEngineRigidbody(){} // RVA: 0x7FFACA9D5AD0
        public void __get_connectedMassScale__SystemSingle(){} // RVA: 0x7FFACA9D5C10
        public void __get_currentForce__UnityEngineVector3(){} // RVA: 0x7FFACA9D5D30
        public void __get_currentTorque__UnityEngineVector3(){} // RVA: 0x7FFACA9D5E20
        public void __get_enableCollision__SystemBoolean(){} // RVA: 0x7FFACA9D5F10
        public void __get_enablePreprocessing__SystemBoolean(){} // RVA: 0x7FFACA9D6030
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA9D6150
        public void __get_massScale__SystemSingle(){} // RVA: 0x7FFACA9D6290
        public void __get_name__SystemString(){} // RVA: 0x7FFACA9D63B0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA9D6500
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA9D6640
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA9D6940
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA9D6B30
        public void __set_anchor__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA9D6E30
        public void __set_autoConfigureConnectedAnchor__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9D6F70
        public void __set_axis__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA9D70A0
        public void __set_breakForce__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9D71E0
        public void __set_breakTorque__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9D7310
        public void __set_connectedAnchor__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACA9D7440
        public void __set_connectedArticulationBody__UnityEngineArticulationBody__SystemVoid(){} // RVA: 0x7FFACA9D7580
        public void __set_connectedBody__UnityEngineRigidbody__SystemVoid(){} // RVA: 0x7FFACA9D76D0
        public void __set_connectedMassScale__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9D7820
        public void __set_enableCollision__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9D7950
        public void __set_enablePreprocessing__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9D7A80
        public void __set_massScale__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9D7BB0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA9D7CE0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA9D7E30
    }

    public class ExternUnityEngineFixedJoint2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA9DB010
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA9DB050
        public void .ctor(){} // RVA: 0x7FFACA9DB100
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA9DB4D0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA9DB600
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA9DB710
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA9DB8E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA9DB9D0
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA9DBC80
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA9DBDE0
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA9DBF00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA9DBFF0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA9DC270
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA9DC360
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA9DC610
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA9DC770
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA9DC890
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA9DC980
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA9DCC00
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA9DCD70
        public void __GetComponent__T(){} // RVA: 0x7FFACA9DCE90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA9DCF70
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA9DD1C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA9DD2B0
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9DD5E0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9DD6D0
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA9DDA10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA9DDB00
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA9DDE10
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA9DDF80
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA9DE0B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA9DE1A0
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9DE490
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9DE580
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA9DE8C0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA9DE9B0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA9DECC0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA9DEE30
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA9DEF70
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA9DF060
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA9DF350
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA9DF440
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA9DF730
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA9DF880
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA9DF9B0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA9DFAA0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA9DFD50
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA9DFEB0
        public void __GetReactionForce__SystemSingle__UnityEngineVector2(){} // RVA: 0x7FFACA9E0000
        public void __GetReactionTorque__SystemSingle__SystemSingle(){} // RVA: 0x7FFACA9E0110
        public void __GetType__SystemType(){} // RVA: 0x7FFACA9E0270
        public void __ToString__SystemString(){} // RVA: 0x7FFACA9E0360
        public void __get_anchor__UnityEngineVector2(){} // RVA: 0x7FFACA9E04B0
        public void __get_attachedRigidbody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACA9E05E0
        public void __get_autoConfigureConnectedAnchor__SystemBoolean(){} // RVA: 0x7FFACA9E0720
        public void __get_breakAction__UnityEngineJointBreakAction2D(){} // RVA: 0x7FFACA9E0840
        public void __get_breakForce__SystemSingle(){} // RVA: 0x7FFACA9E0960
        public void __get_breakTorque__SystemSingle(){} // RVA: 0x7FFACA9E0A80
        public void __get_connectedAnchor__UnityEngineVector2(){} // RVA: 0x7FFACA9E0BA0
        public void __get_connectedBody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACA9E0CD0
        public void __get_dampingRatio__SystemSingle(){} // RVA: 0x7FFACA9E0E10
        public void __get_enableCollision__SystemBoolean(){} // RVA: 0x7FFACA9E0F30
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA9E1050
        public void __get_frequency__SystemSingle(){} // RVA: 0x7FFACA9E1170
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA9E1290
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACA9E13D0
        public void __get_name__SystemString(){} // RVA: 0x7FFACA9E14F0
        public void __get_reactionForce__UnityEngineVector2(){} // RVA: 0x7FFACA9E1640
        public void __get_reactionTorque__SystemSingle(){} // RVA: 0x7FFACA9E1770
        public void __get_referenceAngle__SystemSingle(){} // RVA: 0x7FFACA9E1890
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA9E19B0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA9E1AF0
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA9E1DF0
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA9E1FE0
        public void __set_anchor__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA9E22E0
        public void __set_autoConfigureConnectedAnchor__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9E2400
        public void __set_breakAction__UnityEngineJointBreakAction2D__SystemVoid(){} // RVA: 0x7FFACA9E2530
        public void __set_breakForce__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9E2650
        public void __set_breakTorque__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9E2780
        public void __set_connectedAnchor__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA9E28B0
        public void __set_connectedBody__UnityEngineRigidbody2D__SystemVoid(){} // RVA: 0x7FFACA9E29D0
        public void __set_dampingRatio__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9E2B20
        public void __set_enableCollision__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9E2C50
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9E2D80
        public void __set_frequency__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9E2EB0
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA9E2FE0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA9E3130
    }

    public class ExternUnityEngineFixedJoint2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA9E6550
        public void .ctor(){} // RVA: 0x7FFACA9E6590
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA9E6960
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA9E6A90
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA9E6BA0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9E6C80
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9E6D60
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA9E6E30
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA9E6F80
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA9E7020
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9E7120
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA9E7240
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9E7350
        public void __GetType__SystemType(){} // RVA: 0x7FFACA9E7470
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9E7560
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA9E7640
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA9E7760
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA9E78F0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA9E7A40
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA9E7B70
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA9E7C90
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA9E7E00
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA9E7F40
        public void __Get__SystemInt32__UnityEngineFixedJoint2D(){} // RVA: 0x7FFACA9E8060
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA9E81A0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA9E8210
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9E8330
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9E84B0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9E8610
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA9E8740
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9E8860
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9E89C0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9E8B10
        public void __Set__SystemInt32_UnityEngineFixedJoint2D__SystemVoid(){} // RVA: 0x7FFACA9E8C30
        public void __ToString__SystemString(){} // RVA: 0x7FFACA9E8DC0
        public void __ctor__SystemInt32__UnityEngineFixedJoint2DArray(){} // RVA: 0x7FFACA9E8EB0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA9E8FA0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA9E9040
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA9E90E0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA9E9180
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA9E9220
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA9E92C0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA9E9360
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA9E9440
    }

    public class ExternUnityEngineFixedJointArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA9EB360
        public void .ctor(){} // RVA: 0x7FFACA9EB3A0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA9EB770
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA9EB8A0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA9EB9B0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9EBA90
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9EBB70
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA9EBC40
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA9EBD90
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA9EBE30
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9EBF30
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA9EC050
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9EC160
        public void __GetType__SystemType(){} // RVA: 0x7FFACA9EC280
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9EC370
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA9EC450
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA9EC570
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA9EC700
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA9EC850
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA9EC980
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA9ECAA0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA9ECC10
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA9ECD50
        public void __Get__SystemInt32__UnityEngineFixedJoint(){} // RVA: 0x7FFACA9ECE70
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA9ECFB0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA9ED020
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9ED140
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9ED2C0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9ED420
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA9ED550
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9ED670
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9ED7D0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9ED920
        public void __Set__SystemInt32_UnityEngineFixedJoint__SystemVoid(){} // RVA: 0x7FFACA9EDA40
        public void __ToString__SystemString(){} // RVA: 0x7FFACA9EDCF0
        public void __ctor__SystemInt32__UnityEngineFixedJointArray(){} // RVA: 0x7FFACA9EDDE0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA9EDED0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA9EDF70
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA9EE010
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA9EE0B0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA9EE150
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA9EE1F0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA9EE290
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA9EE370
    }

    public class ExternUnityEngineFrictionJoint2D : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA9F0290
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACA9F02D0
        public void .ctor(){} // RVA: 0x7FFACA9F0380
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA9F0750
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA9F0880
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA9F0990
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA9F0B60
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACA9F0C50
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA9F0F00
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA9F1060
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACA9F1180
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACA9F1270
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA9F14F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACA9F15E0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACA9F1890
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA9F19F0
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACA9F1B10
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACA9F1C00
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACA9F1E80
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACA9F1FF0
        public void __GetComponent__T(){} // RVA: 0x7FFACA9F2110
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACA9F21F0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA9F2440
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACA9F2530
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9F2860
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9F2950
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA9F2C90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACA9F2D80
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA9F3090
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA9F3200
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA9F3330
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACA9F3420
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9F3710
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACA9F3800
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA9F3B40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACA9F3C30
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACA9F3F40
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA9F40B0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACA9F41F0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACA9F42E0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA9F45D0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACA9F46C0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACA9F49B0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACA9F4B00
        public void __GetComponents__TArray(){} // RVA: 0x7FFACA9F4C30
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACA9F4D20
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA9F4FD0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACA9F5130
        public void __GetReactionForce__SystemSingle__UnityEngineVector2(){} // RVA: 0x7FFACA9F5280
        public void __GetReactionTorque__SystemSingle__SystemSingle(){} // RVA: 0x7FFACA9F5390
        public void __GetType__SystemType(){} // RVA: 0x7FFACA9F54F0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA9F55E0
        public void __get_anchor__UnityEngineVector2(){} // RVA: 0x7FFACA9F5730
        public void __get_attachedRigidbody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACA9F5860
        public void __get_autoConfigureConnectedAnchor__SystemBoolean(){} // RVA: 0x7FFACA9F59A0
        public void __get_breakAction__UnityEngineJointBreakAction2D(){} // RVA: 0x7FFACA9F5AC0
        public void __get_breakForce__SystemSingle(){} // RVA: 0x7FFACA9F5BE0
        public void __get_breakTorque__SystemSingle(){} // RVA: 0x7FFACA9F5D00
        public void __get_connectedAnchor__UnityEngineVector2(){} // RVA: 0x7FFACA9F5E20
        public void __get_connectedBody__UnityEngineRigidbody2D(){} // RVA: 0x7FFACA9F5F50
        public void __get_enableCollision__SystemBoolean(){} // RVA: 0x7FFACA9F6090
        public void __get_enabled__SystemBoolean(){} // RVA: 0x7FFACA9F61B0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACA9F62D0
        public void __get_isActiveAndEnabled__SystemBoolean(){} // RVA: 0x7FFACA9F6410
        public void __get_maxForce__SystemSingle(){} // RVA: 0x7FFACA9F6530
        public void __get_maxTorque__SystemSingle(){} // RVA: 0x7FFACA9F6650
        public void __get_name__SystemString(){} // RVA: 0x7FFACA9F6770
        public void __get_reactionForce__UnityEngineVector2(){} // RVA: 0x7FFACA9F68C0
        public void __get_reactionTorque__SystemSingle(){} // RVA: 0x7FFACA9F69F0
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACA9F6B10
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA9F6C50
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA9F6F50
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACA9F7140
        public void __set_anchor__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA9F7440
        public void __set_autoConfigureConnectedAnchor__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9F7560
        public void __set_breakAction__UnityEngineJointBreakAction2D__SystemVoid(){} // RVA: 0x7FFACA9F7690
        public void __set_breakForce__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9F77B0
        public void __set_breakTorque__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9F78E0
        public void __set_connectedAnchor__UnityEngineVector2__SystemVoid(){} // RVA: 0x7FFACA9F7A10
        public void __set_connectedBody__UnityEngineRigidbody2D__SystemVoid(){} // RVA: 0x7FFACA9F7B30
        public void __set_enableCollision__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9F7C80
        public void __set_enabled__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACA9F7DB0
        public void __set_maxForce__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9F7EE0
        public void __set_maxTorque__SystemSingle__SystemVoid(){} // RVA: 0x7FFACA9F8010
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACA9F8140
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACA9F8290
    }

    public class ExternUnityEngineFrictionJoint2DArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACA9FB5F0
        public void .ctor(){} // RVA: 0x7FFACA9FB630
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACA9FBA00
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACA9FBB30
        public void __Clone__SystemObject(){} // RVA: 0x7FFACA9FBC40
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9FBD20
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9FBE00
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACA9FBED0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACA9FC020
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACA9FC0C0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9FC1C0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACA9FC2E0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9FC3F0
        public void __GetType__SystemType(){} // RVA: 0x7FFACA9FC510
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACA9FC600
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACA9FC6E0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA9FC800
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACA9FC990
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACA9FCAE0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACA9FCC10
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA9FCD30
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACA9FCEA0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACA9FCFE0
        public void __Get__SystemInt32__UnityEngineFrictionJoint2D(){} // RVA: 0x7FFACA9FD100
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACA9FD240
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACA9FD2B0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9FD3D0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9FD550
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACA9FD6B0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACA9FD7E0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9FD900
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9FDA60
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACA9FDBB0
        public void __Set__SystemInt32_UnityEngineFrictionJoint2D__SystemVoid(){} // RVA: 0x7FFACA9FDCD0
        public void __ToString__SystemString(){} // RVA: 0x7FFACA9FDE60
        public void __ctor__SystemInt32__UnityEngineFrictionJoint2DArray(){} // RVA: 0x7FFACA9FDF50
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACA9FE040
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACA9FE0E0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACA9FE180
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACA9FE220
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACA9FE2C0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACA9FE360
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACA9FE400
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACA9FE4E0
    }

    public class ExternUnityEngineFrustumPlanes : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAA00400
        public void .ctor(){} // RVA: 0x7FFACAA00440
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAA00810
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAA00940
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAA00A50
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAA00B90
        public void __GetType__SystemType(){} // RVA: 0x7FFACAA00C40
        public void __ToString__SystemString(){} // RVA: 0x7FFACAA00D30
        public void __get_bottom__SystemSingle(){} // RVA: 0x7FFACAA00DE0
        public void __set_bottom__SystemSingle(){} // RVA: 0x7FFACAA00EE0
        public void __get_left__SystemSingle(){} // RVA: 0x7FFACAA00FE0
        public void __set_left__SystemSingle(){} // RVA: 0x7FFACAA010D0
        public void __get_right__SystemSingle(){} // RVA: 0x7FFACAA011D0
        public void __set_right__SystemSingle(){} // RVA: 0x7FFACAA012D0
        public void __get_top__SystemSingle(){} // RVA: 0x7FFACAA013D0
        public void __set_top__SystemSingle(){} // RVA: 0x7FFACAA014D0
        public void __get_zFar__SystemSingle(){} // RVA: 0x7FFACAA015D0
        public void __set_zFar__SystemSingle(){} // RVA: 0x7FFACAA016E0
        public void __get_zNear__SystemSingle(){} // RVA: 0x7FFACAA017E0
        public void __set_zNear__SystemSingle(){} // RVA: 0x7FFACAA018F0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAA019F0
    }

    public class ExternUnityEngineFrustumPlanesArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAA027D0
        public void .ctor(){} // RVA: 0x7FFACAA02810
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAA02BE0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAA02D10
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAA02E20
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA02F00
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAA02FE0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAA030B0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAA03200
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAA032A0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAA033A0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAA034C0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAA035D0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAA036F0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAA037E0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAA038C0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAA039E0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAA03B70
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAA03CC0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAA03DF0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAA03F10
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAA04080
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAA041C0
        public void __Get__SystemInt32__UnityEngineFrustumPlanes(){} // RVA: 0x7FFACAA042E0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAA043E0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAA04450
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA04570
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA046F0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA04850
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAA04980
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAA04AA0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAA04C00
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAA04D50
        public void __Set__SystemInt32_UnityEngineFrustumPlanes__SystemVoid(){} // RVA: 0x7FFACAA04E70
        public void __ToString__SystemString(){} // RVA: 0x7FFACAA04F80
        public void __ctor__SystemInt32__UnityEngineFrustumPlanesArray(){} // RVA: 0x7FFACAA05070
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAA05210
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAA052B0
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAA05350
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAA053F0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAA05490
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAA05530
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAA055D0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAA056B0
    }

    public class ExternUnityEngineGameObject : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAA075D0
        public void .ctor(){} // RVA: 0x7FFACAA07610
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAA079E0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAA07B10
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAA07C20
        public void __Find__SystemString__UnityEngineGameObject(){} // RVA: 0x7FFACAA07DF0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAA07F10
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAA08000
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAA08170
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACAA082F0
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAA083E0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAA084D0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAA08640
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACAA087C0
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACAA088B0
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAA08A30
        public void __GetComponent__T(){} // RVA: 0x7FFACAA08BB0
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAA08C90
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAA08D80
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAA08E70
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAA08F60
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAA090D0
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAA09210
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAA09300
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAA093F0
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAA094E0
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAA09650
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACAA09790
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAA09880
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACAA09970
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAA09AC0
        public void __GetComponents__TArray(){} // RVA: 0x7FFACAA09BF0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAA09CE0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACAA09E40
        public void __GetType__SystemType(){} // RVA: 0x7FFACAA09F90
        public void __SetActive__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAA0A080
        public void __ToString__SystemString(){} // RVA: 0x7FFACAA0A1B0
        public void __get_activeInHierarchy__SystemBoolean(){} // RVA: 0x7FFACAA0A300
        public void __get_activeSelf__SystemBoolean(){} // RVA: 0x7FFACAA0A420
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACAA0A540
        public void __get_isStatic__SystemBoolean(){} // RVA: 0x7FFACAA0A630
        public void __get_layer__SystemInt32(){} // RVA: 0x7FFACAA0A750
        public void __get_name__SystemString(){} // RVA: 0x7FFACAA0A870
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACAA0A9C0
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAA0AB00
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAA0AE00
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAA0AFF0
        public void __set_isStatic__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAA0B2F0
        public void __set_layer__SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA0B420
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACAA0B540
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAA0B690
    }

    public class ExternUnityEngineGameObjectArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAA0DAF0
        public void .ctor(){} // RVA: 0x7FFACAA0DB30
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAA0DF00
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAA0E030
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAA0E140
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA0E220
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAA0E300
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAA0E3D0
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAA0E520
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAA0E5C0
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAA0E6C0
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAA0E7E0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAA0E8F0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAA0EA10
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAA0EB00
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAA0EBE0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAA0ED00
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAA0EE90
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAA0EFE0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAA0F110
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAA0F230
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAA0F3A0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAA0F4E0
        public void __Get__SystemInt32__UnityEngineGameObject(){} // RVA: 0x7FFACAA0F600
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAA0F740
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAA0F7B0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA0F8D0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA0FA50
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA0FBB0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAA0FCE0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAA0FE00
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAA0FF60
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAA100B0
        public void __Set__SystemInt32_UnityEngineGameObject__SystemVoid(){} // RVA: 0x7FFACAA101D0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAA10310
        public void __ctor__SystemInt32__UnityEngineGameObjectArray(){} // RVA: 0x7FFACAA10400
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAA104F0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAA10590
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAA10630
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAA106D0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAA10770
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAA10810
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAA108B0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAA10990
    }

    public class ExternUnityEngineGeometryUtility : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAA128B0
        public void .ctor(){} // RVA: 0x7FFACAA128F0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAA12CC0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAA12DF0
        public void __CalculateBounds__UnityEngineVector3Array_UnityEngineMatrix4x4__UnityEngineBounds(){} // RVA: 0x7FFACAA12F00
        public void __CalculateFrustumPlanes__UnityEngineCamera_UnityEnginePlaneArray__SystemVoid(){} // RVA: 0x7FFACAA13030
        public void __CalculateFrustumPlanes__UnityEngineCamera__UnityEnginePlaneArray(){} // RVA: 0x7FFACAA13100
        public void __CalculateFrustumPlanes__UnityEngineMatrix4x4_UnityEnginePlaneArray__SystemVoid(){} // RVA: 0x7FFACAA13220
        public void __CalculateFrustumPlanes__UnityEngineMatrix4x4__UnityEnginePlaneArray(){} // RVA: 0x7FFACAA13320
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAA13470
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAA135C0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAA136C0
        public void __TestPlanesAABB__UnityEnginePlaneArray_UnityEngineBounds__SystemBoolean(){} // RVA: 0x7FFACAA137B0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAA138F0
        public void __TryCreatePlaneFromPolygon__UnityEngineVector3Array_UnityEnginePlaneRef__SystemBoolean(){} // RVA: 0x7FFACAA139E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAA13AD0
    }

    public class ExternUnityEngineGizmos : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAA144E0
        public void .ctor(){} // RVA: 0x7FFACAA14520
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAA148F0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAA14A20
        public void __DrawCube__UnityEngineVector3_UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAA14B30
        public void __DrawFrustum__UnityEngineVector3_SystemSingle_SystemSingle_SystemSingle_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAA14C40
        public void __DrawGUITexture__UnityEngineRect_UnityEngineTexture_SystemInt32_SystemInt32_SystemInt32_SystemInt32_UnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACAA14E10
        public void __DrawGUITexture__UnityEngineRect_UnityEngineTexture_SystemInt32_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA15090
        public void __DrawGUITexture__UnityEngineRect_UnityEngineTexture_UnityEngineMaterial__SystemVoid(){} // RVA: 0x7FFACAA15290
        public void __DrawGUITexture__UnityEngineRect_UnityEngineTexture__SystemVoid(){} // RVA: 0x7FFACAA15440
        public void __DrawIcon__UnityEngineVector3_SystemString_SystemBoolean_UnityEngineColor__SystemVoid(){} // RVA: 0x7FFACAA15590
        public void __DrawIcon__UnityEngineVector3_SystemString_SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAA15720
        public void __DrawIcon__UnityEngineVector3_SystemString__SystemVoid(){} // RVA: 0x7FFACAA15880
        public void __DrawLine__UnityEngineVector3_UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAA15990
        public void __DrawRay__UnityEngineRay__SystemVoid(){} // RVA: 0x7FFACAA15AA0
        public void __DrawRay__UnityEngineVector3_UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAA15BC0
        public void __DrawSphere__UnityEngineVector3_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAA15D00
        public void __DrawWireCube__UnityEngineVector3_UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAA15E20
        public void __DrawWireMesh__UnityEngineMesh_SystemInt32_UnityEngineVector3_UnityEngineQuaternion_UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAA15F30
        public void __DrawWireMesh__UnityEngineMesh_SystemInt32_UnityEngineVector3_UnityEngineQuaternion__SystemVoid(){} // RVA: 0x7FFACAA16150
        public void __DrawWireMesh__UnityEngineMesh_SystemInt32_UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAA16380
        public void __DrawWireMesh__UnityEngineMesh_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA165A0
        public void __DrawWireMesh__UnityEngineMesh_UnityEngineVector3_UnityEngineQuaternion_UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAA167B0
        public void __DrawWireMesh__UnityEngineMesh_UnityEngineVector3_UnityEngineQuaternion__SystemVoid(){} // RVA: 0x7FFACAA16990
        public void __DrawWireMesh__UnityEngineMesh_UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAA16B80
        public void __DrawWireMesh__UnityEngineMesh__SystemVoid(){} // RVA: 0x7FFACAA16D70
        public void __DrawWireSphere__UnityEngineVector3_SystemSingle__SystemVoid(){} // RVA: 0x7FFACAA16F50
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAA17070
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAA171C0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAA172C0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAA173B0
        public void __get_color__UnityEngineColor(){} // RVA: 0x7FFACAA174A0
        public void __get_matrix__UnityEngineMatrix4x4(){} // RVA: 0x7FFACAA17560
        public void __get_probeSize__SystemSingle(){} // RVA: 0x7FFACAA17660
        public void __set_color__UnityEngineColor__SystemVoid(){} // RVA: 0x7FFACAA17710
        public void __set_matrix__UnityEngineMatrix4x4__SystemVoid(){} // RVA: 0x7FFACAA177C0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAA178A0
    }

    public class ExternUnityEngineGradient : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAA19280
        public void .ctor(){} // RVA: 0x7FFACAA192C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAA19690
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAA197C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAA198D0
        public void __Equals__UnityEngineGradient__SystemBoolean(){} // RVA: 0x7FFACAA19A10
        public void __Evaluate__SystemSingle__UnityEngineColor(){} // RVA: 0x7FFACAA19AE0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAA19C30
        public void __GetType__SystemType(){} // RVA: 0x7FFACAA19CE0
        public void __SetKeys__UnityEngineGradientColorKeyArray_UnityEngineGradientAlphaKeyArray__SystemVoid(){} // RVA: 0x7FFACAA19DD0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAA19EB0
        public void __ctor____UnityEngineGradient(){} // RVA: 0x7FFACAA19FA0
        public void __get_alphaKeys__UnityEngineGradientAlphaKeyArray(){} // RVA: 0x7FFACAA1A070
        public void __get_colorKeys__UnityEngineGradientColorKeyArray(){} // RVA: 0x7FFACAA1A150
        public void __get_colorSpace__UnityEngineColorSpace(){} // RVA: 0x7FFACAA1A230
        public void __get_mode__UnityEngineGradientMode(){} // RVA: 0x7FFACAA1A320
        public void __set_alphaKeys__UnityEngineGradientAlphaKeyArray__SystemVoid(){} // RVA: 0x7FFACAA1A410
        public void __set_colorKeys__UnityEngineGradientColorKeyArray__SystemVoid(){} // RVA: 0x7FFACAA1A500
        public void __set_colorSpace__UnityEngineColorSpace__SystemVoid(){} // RVA: 0x7FFACAA1A5F0
        public void __set_mode__UnityEngineGradientMode__SystemVoid(){} // RVA: 0x7FFACAA1A6E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAA1A7D0
    }

    public class ExternUnityEngineGradientAlphaKey : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAA1B5B0
        public void .ctor(){} // RVA: 0x7FFACAA1B5F0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAA1B9C0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAA1BAF0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAA1BC00
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAA1BD40
        public void __GetType__SystemType(){} // RVA: 0x7FFACAA1BDF0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAA1BEE0
        public void __ctor__SystemSingle_SystemSingle__UnityEngineGradientAlphaKey(){} // RVA: 0x7FFACAA1BF90
        public void __get_alpha__SystemSingle(){} // RVA: 0x7FFACAA1C050
        public void __set_alpha__SystemSingle(){} // RVA: 0x7FFACAA1C130
        public void __get_time__SystemSingle(){} // RVA: 0x7FFACAA1C200
        public void __set_time__SystemSingle(){} // RVA: 0x7FFACAA1C2E0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAA1C3B0
    }

    public class ExternUnityEngineGradientAlphaKeyArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAA1CC50
        public void .ctor(){} // RVA: 0x7FFACAA1CC90
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAA1D060
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAA1D190
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAA1D2A0
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA1D380
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAA1D460
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAA1D530
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAA1D680
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAA1D720
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAA1D820
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAA1D940
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAA1DA50
        public void __GetType__SystemType(){} // RVA: 0x7FFACAA1DB70
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAA1DC60
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAA1DD40
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAA1DE60
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAA1DFF0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAA1E140
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAA1E270
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAA1E390
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAA1E500
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAA1E640
        public void __Get__SystemInt32__UnityEngineGradientAlphaKey(){} // RVA: 0x7FFACAA1E760
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAA1E840
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAA1E8B0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA1E9D0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA1EB50
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA1ECB0
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAA1EDE0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAA1EF00
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAA1F060
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAA1F1B0
        public void __Set__SystemInt32_UnityEngineGradientAlphaKey__SystemVoid(){} // RVA: 0x7FFACAA1F2D0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAA1F3D0
        public void __ctor__SystemInt32__UnityEngineGradientAlphaKeyArray(){} // RVA: 0x7FFACAA1F4C0
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAA1F570
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAA1F610
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAA1F6B0
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAA1F750
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAA1F7F0
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAA1F890
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAA1F930
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAA1FA10
    }

    public class ExternUnityEngineGradientArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAA21930
        public void .ctor(){} // RVA: 0x7FFACAA21970
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAA21D40
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAA21E70
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAA21F80
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA22060
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAA22140
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAA22210
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAA22360
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAA22400
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAA22500
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAA22620
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAA22730
        public void __GetType__SystemType(){} // RVA: 0x7FFACAA22850
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAA22940
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAA22A20
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAA22B40
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAA22CD0
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAA22E20
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAA22F50
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAA23070
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAA231E0
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAA23320
        public void __Get__SystemInt32__UnityEngineGradient(){} // RVA: 0x7FFACAA23440
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAA23520
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAA23590
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA236B0
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA23830
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA23990
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAA23AC0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAA23BE0
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAA23D40
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAA23E90
        public void __Set__SystemInt32_UnityEngineGradient__SystemVoid(){} // RVA: 0x7FFACAA23FB0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAA24130
        public void __ctor__SystemInt32__UnityEngineGradientArray(){} // RVA: 0x7FFACAA24220
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAA243C0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAA24460
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAA24500
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAA245A0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAA24640
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAA246E0
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAA24780
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAA24860
    }

    public class ExternUnityEngineGradientColorKey : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAA26780
        public void .ctor(){} // RVA: 0x7FFACAA267C0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAA26B90
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAA26CC0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAA26DD0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAA26F10
        public void __GetType__SystemType(){} // RVA: 0x7FFACAA26FC0
        public void __ToString__SystemString(){} // RVA: 0x7FFACAA270B0
        public void __ctor__UnityEngineColor_SystemSingle__UnityEngineGradientColorKey(){} // RVA: 0x7FFACAA27160
        public void __get_color__UnityEngineColor(){} // RVA: 0x7FFACAA27270
        public void __set_color__UnityEngineColor(){} // RVA: 0x7FFACAA27360
        public void __get_time__SystemSingle(){} // RVA: 0x7FFACAA27440
        public void __set_time__SystemSingle(){} // RVA: 0x7FFACAA27530
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAA27610
    }

    public class ExternUnityEngineGradientColorKeyArray : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> _functionDelegates; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAA27EB0
        public void .ctor(){} // RVA: 0x7FFACAA27EF0
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAA282C0
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAA283F0
        public void __Clone__SystemObject(){} // RVA: 0x7FFACAA28500
        public void __CopyTo__SystemArray_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA285E0
        public void __CopyTo__SystemArray_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAA286C0
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAA28790
        public void __GetEnumerator__SystemCollectionsIEnumerator(){} // RVA: 0x7FFACAA288E0
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAA28980
        public void __GetLength__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAA28A80
        public void __GetLongLength__SystemInt32__SystemInt64(){} // RVA: 0x7FFACAA28BA0
        public void __GetLowerBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAA28CB0
        public void __GetType__SystemType(){} // RVA: 0x7FFACAA28DD0
        public void __GetUpperBound__SystemInt32__SystemInt32(){} // RVA: 0x7FFACAA28EC0
        public void __GetValue__SystemInt32Array__SystemObject(){} // RVA: 0x7FFACAA28FA0
        public void __GetValue__SystemInt32_SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAA290C0
        public void __GetValue__SystemInt32_SystemInt32__SystemObject(){} // RVA: 0x7FFACAA29250
        public void __GetValue__SystemInt32__SystemObject(){} // RVA: 0x7FFACAA293A0
        public void __GetValue__SystemInt64Array__SystemObject(){} // RVA: 0x7FFACAA294D0
        public void __GetValue__SystemInt64_SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAA295F0
        public void __GetValue__SystemInt64_SystemInt64__SystemObject(){} // RVA: 0x7FFACAA29760
        public void __GetValue__SystemInt64__SystemObject(){} // RVA: 0x7FFACAA298A0
        public void __Get__SystemInt32__UnityEngineGradientColorKey(){} // RVA: 0x7FFACAA299C0
        public void __Initialize__SystemVoid(){} // RVA: 0x7FFACAA29AB0
        public void __SetValue__SystemObject_SystemInt32Array__SystemVoid(){} // RVA: 0x7FFACAA29B20
        public void __SetValue__SystemObject_SystemInt32_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA29C40
        public void __SetValue__SystemObject_SystemInt32_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA29DC0
        public void __SetValue__SystemObject_SystemInt32__SystemVoid(){} // RVA: 0x7FFACAA29F20
        public void __SetValue__SystemObject_SystemInt64Array__SystemVoid(){} // RVA: 0x7FFACAA2A050
        public void __SetValue__SystemObject_SystemInt64_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAA2A170
        public void __SetValue__SystemObject_SystemInt64_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAA2A2D0
        public void __SetValue__SystemObject_SystemInt64__SystemVoid(){} // RVA: 0x7FFACAA2A420
        public void __Set__SystemInt32_UnityEngineGradientColorKey__SystemVoid(){} // RVA: 0x7FFACAA2A540
        public void __ToString__SystemString(){} // RVA: 0x7FFACAA2A640
        public void __ctor__SystemInt32__UnityEngineGradientColorKeyArray(){} // RVA: 0x7FFACAA2A730
        public void __get_IsFixedSize__SystemBoolean(){} // RVA: 0x7FFACAA2A7E0
        public void __get_IsReadOnly__SystemBoolean(){} // RVA: 0x7FFACAA2A880
        public void __get_IsSynchronized__SystemBoolean(){} // RVA: 0x7FFACAA2A920
        public void __get_Length__SystemInt32(){} // RVA: 0x7FFACAA2A9C0
        public void __get_LongLength__SystemInt64(){} // RVA: 0x7FFACAA2AA60
        public void __get_Rank__SystemInt32(){} // RVA: 0x7FFACAA2AB00
        public void __get_SyncRoot__SystemObject(){} // RVA: 0x7FFACAA2ABA0
        public void <.ctor>b__6_1(){} // RVA: 0x7FFACAA2AC80
    }

    public class ExternUnityEngineHingeJoint : Object
    {
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,int>> Name; // 0x10
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<string,VRC.Udon.Common.Delegates.UdonExternDelegate>> VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetterType; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonComponentGetter _componentGetter; // 0x20
        public VRC.Udon.Common.Interfaces.IUdonSecurityFilter`1<UnityEngine.Object> _filter; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFACAA2CBA0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.get_GetterType(){} // RVA: 0x7FFACAA2CBE0
        public void .ctor(){} // RVA: 0x7FFACAA2CC90
        public void GetExternFunctionParameterCount(){} // RVA: 0x7FFACAA2D060
        public void GetExternFunctionDelegate(){} // RVA: 0x7FFACAA2D190
        public void __Equals__SystemObject__SystemBoolean(){} // RVA: 0x7FFACAA2D2A0
        public void __GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAA2D470
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__SystemBoolean__T(){} // RVA: 0x7FFACAA2D560
        public void __GetComponentInChildren__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAA2D810
        public void __GetComponentInChildren__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAA2D970
        public void __GetComponentInChildren__T(){} // RVA: 0x7FFACAA2DA90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInChildren__T(){} // RVA: 0x7FFACAA2DB80
        public void __GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAA2DE00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__SystemBoolean__T(){} // RVA: 0x7FFACAA2DEF0
        public void __GetComponentInParent__SystemType_SystemBoolean__UnityEngineComponent(){} // RVA: 0x7FFACAA2E1A0
        public void __GetComponentInParent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAA2E300
        public void __GetComponentInParent__T(){} // RVA: 0x7FFACAA2E420
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentInParent__T(){} // RVA: 0x7FFACAA2E510
        public void __GetComponent__SystemString__UnityEngineComponent(){} // RVA: 0x7FFACAA2E790
        public void __GetComponent__SystemType__UnityEngineComponent(){} // RVA: 0x7FFACAA2E900
        public void __GetComponent__T(){} // RVA: 0x7FFACAA2EA20
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponent__T(){} // RVA: 0x7FFACAA2EB00
        public void __GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAA2ED50
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__ListT__SystemVoid(){} // RVA: 0x7FFACAA2EE40
        public void __GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAA2F170
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAA2F260
        public void __GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAA2F5A0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__SystemBoolean__TArray(){} // RVA: 0x7FFACAA2F690
        public void __GetComponentsInChildren__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAA2F9A0
        public void __GetComponentsInChildren__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAA2FB10
        public void __GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAA2FC40
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInChildren__TArray(){} // RVA: 0x7FFACAA2FD30
        public void __GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAA30020
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean_ListT__SystemVoid(){} // RVA: 0x7FFACAA30110
        public void __GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAA30450
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__SystemBoolean__TArray(){} // RVA: 0x7FFACAA30540
        public void __GetComponentsInParent__SystemType_SystemBoolean__UnityEngineComponentArray(){} // RVA: 0x7FFACAA30850
        public void __GetComponentsInParent__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAA309C0
        public void __GetComponentsInParent__TArray(){} // RVA: 0x7FFACAA30B00
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFACAA30BF0
        public void __GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAA30EE0
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__ListT__SystemVoid(){} // RVA: 0x7FFACAA30FD0
        public void __GetComponents__SystemType_SystemCollectionsGenericListUnityEngineComponent__SystemVoid(){} // RVA: 0x7FFACAA312C0
        public void __GetComponents__SystemType__UnityEngineComponentArray(){} // RVA: 0x7FFACAA31410
        public void __GetComponents__TArray(){} // RVA: 0x7FFACAA31540
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponents__TArray(){} // RVA: 0x7FFACAA31630
        public void __GetHashCode__SystemInt32(){} // RVA: 0x7FFACAA318E0
        public void __GetInstanceID__SystemInt32(){} // RVA: 0x7FFACAA31A40
        public void __GetType__SystemType(){} // RVA: 0x7FFACAA31B90
        public void __ToString__SystemString(){} // RVA: 0x7FFACAA31C80
        public void __get_anchor__UnityEngineVector3(){} // RVA: 0x7FFACAA31DD0
        public void __get_angle__SystemSingle(){} // RVA: 0x7FFACAA31F10
        public void __get_autoConfigureConnectedAnchor__SystemBoolean(){} // RVA: 0x7FFACAA32030
        public void __get_axis__UnityEngineVector3(){} // RVA: 0x7FFACAA32150
        public void __get_breakForce__SystemSingle(){} // RVA: 0x7FFACAA32290
        public void __get_breakTorque__SystemSingle(){} // RVA: 0x7FFACAA323B0
        public void __get_connectedAnchor__UnityEngineVector3(){} // RVA: 0x7FFACAA324D0
        public void __get_connectedArticulationBody__UnityEngineArticulationBody(){} // RVA: 0x7FFACAA32610
        public void __get_connectedBody__UnityEngineRigidbody(){} // RVA: 0x7FFACAA32750
        public void __get_connectedMassScale__SystemSingle(){} // RVA: 0x7FFACAA32890
        public void __get_currentForce__UnityEngineVector3(){} // RVA: 0x7FFACAA329B0
        public void __get_currentTorque__UnityEngineVector3(){} // RVA: 0x7FFACAA32AA0
        public void __get_enableCollision__SystemBoolean(){} // RVA: 0x7FFACAA32B90
        public void __get_enablePreprocessing__SystemBoolean(){} // RVA: 0x7FFACAA32CB0
        public void __get_extendedLimits__SystemBoolean(){} // RVA: 0x7FFACAA32DD0
        public void __get_gameObject__UnityEngineGameObject(){} // RVA: 0x7FFACAA32EF0
        public void __get_limits__UnityEngineJointLimits(){} // RVA: 0x7FFACAA33030
        public void __get_massScale__SystemSingle(){} // RVA: 0x7FFACAA33190
        public void __get_motor__UnityEngineJointMotor(){} // RVA: 0x7FFACAA332B0
        public void __get_name__SystemString(){} // RVA: 0x7FFACAA333F0
        public void __get_spring__UnityEngineJointSpring(){} // RVA: 0x7FFACAA33540
        public void __get_transform__UnityEngineTransform(){} // RVA: 0x7FFACAA33680
        public void __get_useAcceleration__SystemBoolean(){} // RVA: 0x7FFACAA337C0
        public void __get_useLimits__SystemBoolean(){} // RVA: 0x7FFACAA338E0
        public void __get_useMotor__SystemBoolean(){} // RVA: 0x7FFACAA33A00
        public void __get_useSpring__SystemBoolean(){} // RVA: 0x7FFACAA33B20
        public void __get_velocity__SystemSingle(){} // RVA: 0x7FFACAA33C40
        public void __op_Equality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAA33D60
        public void __op_Implicit__UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAA34060
        public void __op_Inequality__UnityEngineObject_UnityEngineObject__SystemBoolean(){} // RVA: 0x7FFACAA34250
        public void __set_anchor__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAA34550
        public void __set_autoConfigureConnectedAnchor__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAA34690
        public void __set_axis__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAA347C0
        public void __set_breakForce__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAA34900
        public void __set_breakTorque__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAA34A30
        public void __set_connectedAnchor__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFACAA34B60
        public void __set_connectedArticulationBody__UnityEngineArticulationBody__SystemVoid(){} // RVA: 0x7FFACAA34CA0
        public void __set_connectedBody__UnityEngineRigidbody__SystemVoid(){} // RVA: 0x7FFACAA34DF0
        public void __set_connectedMassScale__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAA34F40
        public void __set_enableCollision__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAA35070
        public void __set_enablePreprocessing__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAA351A0
        public void __set_extendedLimits__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAA352D0
        public void __set_limits__UnityEngineJointLimits__SystemVoid(){} // RVA: 0x7FFACAA35400
        public void __set_massScale__SystemSingle__SystemVoid(){} // RVA: 0x7FFACAA35540
        public void __set_motor__UnityEngineJointMotor__SystemVoid(){} // RVA: 0x7FFACAA35670
        public void __set_name__SystemString__SystemVoid(){} // RVA: 0x7FFACAA357B0
        public void __set_spring__UnityEngineJointSpring__SystemVoid(){} // RVA: 0x7FFACAA35900
        public void __set_useAcceleration__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAA35A40
        public void __set_useLimits__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAA35B70
        public void __set_useMotor__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAA35CA0
        public void __set_useSpring__SystemBoolean__SystemVoid(){} // RVA: 0x7FFACAA35DD0
        public void <.ctor>b__8_1(){} // RVA: 0x7FFACAA35F00
    }

}