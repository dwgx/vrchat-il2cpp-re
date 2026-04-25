// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Events
// Classes: 23
// Methods: 135

namespace ThirdParty.Unity.UnityEngine.Events
{
    public class ArgumentCache : Object
    {
        public UnityEngine.Object unityObjectArgument; // 0x10
        public string unityObjectArgumentAssemblyTypeName; // 0x18
        public int intArgument; // 0x20
        public float floatArgument; // 0x24
        public string stringArgument; // 0x28
        public bool boolArgument; // 0x30

        // ── Methods ──
        public void get_unityObjectArgument(){} // RVA: 0x7FFAC5CC4750
        public void get_unityObjectArgumentAssemblyTypeName(){} // RVA: 0x7FFAC58A1130
        public void get_intArgument(){} // RVA: 0x7FFAC6C90D40
        public void get_floatArgument(){} // RVA: 0x7FFAC9814E10
        public void get_stringArgument(){} // RVA: 0x7FFAC98DDAD0
        public void get_boolArgument(){} // RVA: 0x7FFAC98DDAE0
        public void OnBeforeSerialize(){} // RVA: 0x7FFAC98DDAF0
        public void OnAfterDeserialize(){} // RVA: 0x7FFAC98DDAF0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class BaseInvokableCall : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98DDB60 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFAC2C70A40
        public void ThrowOnInvalidArg(){} // RVA: 0x7FFAC2C70A10
        public void AllowInvoke(){} // RVA: 0x7FFAC98DDC80
        public void Find(){} // RVA: 0x7FFAC2C5D200
    }

    public class CachedInvokableCall`1 : InvokableCall`1
    {
        public T m_Arg1;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    }

    public class InvokableCall : BaseInvokableCall
    {
        public UnityEngine.Events.UnityAction Delegate; // 0x10

        // ── Methods ──
        public void add_Delegate(){} // RVA: 0x7FFAC98DDDB0
        public void remove_Delegate(){} // RVA: 0x7FFAC98DDEA0
        public void .ctor(){} // RVA: 0x7FFAC98DE1E0 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFAC98DE1F0 | overloaded x2
        public void Find(){} // RVA: 0x7FFAC5F21050
    }

    public class InvokableCallList : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.Events.BaseInvokableCall> m_PersistentCalls; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.Events.BaseInvokableCall> m_RuntimeCalls; // 0x18
        public System.Collections.Generic.List`1<UnityEngine.Events.BaseInvokableCall> m_ExecutingCalls; // 0x20
        public bool m_NeedsUpdate; // 0x28

        // ── Methods ──
        public void AddPersistentInvokableCall(){} // RVA: 0x7FFAC98DF300
        public void AddListener(){} // RVA: 0x7FFAC98DF360
        public void RemoveListener(){} // RVA: 0x7FFAC98DF3C0
        public void Clear(){} // RVA: 0x7FFAC98DF6D0
        public void ClearPersistent(){} // RVA: 0x7FFAC98DF7F0
        public void PrepareInvoke(){} // RVA: 0x7FFAC98DF910
        public void .ctor(){} // RVA: 0x7FFAC98DFA00
    }

    public class InvokableCall`1 : BaseInvokableCall
    {
        public UnityEngine.Events.UnityAction`1<T> Delegate; // 0x10

        // ── Methods ──
        public void add_Delegate(){} // RVA: 0x7FFAC5F208D0
        public void remove_Delegate(){} // RVA: 0x7FFAC5F209E0
        public void .ctor(){} // RVA: 0x7FFAC5F24010 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFAC5F24290 | overloaded x2
        public void Find(){} // RVA: 0x7FFAC5F21050
    }

    public class InvokableCall`2 : BaseInvokableCall
    {
        public UnityEngine.Events.UnityAction`2<U,T> Delegate;

        // ── Methods ──
        public void add_Delegate(){} // RVA: 0x7FFAC2C70A40
        public void remove_Delegate(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Find(){} // RVA: 0x7FFAC2C5D200
    }

    public class InvokableCall`3 : BaseInvokableCall
    {
        public UnityEngine.Events.UnityAction`3<U,V,T> Delegate;

        // ── Methods ──
        public void add_Delegate(){} // RVA: 0x7FFAC2C70A40
        public void remove_Delegate(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Find(){} // RVA: 0x7FFAC2C5D200
    }

    public class InvokableCall`4 : BaseInvokableCall
    {
        public UnityEngine.Events.UnityAction`4<U,V,W,T> Delegate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Find(){} // RVA: 0x7FFAC2C5D200
    }

    public class PersistentCall : Object
    {
        public UnityEngine.Object target; // 0x10
        public string targetAssemblyTypeName; // 0x18
        public string methodName; // 0x20
        public 0x6B181C98 mode; // 0x28
        public UnityEngine.Events.ArgumentCache arguments; // 0x30
        public 0x6B182008 callState; // 0x38

        // ── Methods ──
        public void get_target(){} // RVA: 0x7FFAC5CC4750
        public void get_targetAssemblyTypeName(){} // RVA: 0x7FFAC98DE240
        public void get_methodName(){} // RVA: 0x7FFAC91BAEE0
        public void get_mode(){} // RVA: 0x7FFAC6C8FE60
        public void get_arguments(){} // RVA: 0x7FFAC98DE3D0
        public void get_callState(){} // RVA: 0x7FFAC98DE3E0
        public void IsValid(){} // RVA: 0x7FFAC98DE3F0
        public void GetRuntimeCall(){} // RVA: 0x7FFAC98DE430
        public void GetObjectCall(){} // RVA: 0x7FFAC98DE870
        public void OnBeforeSerialize(){} // RVA: 0x7FFAC98DDAF0
        public void OnAfterDeserialize(){} // RVA: 0x7FFAC98DDAF0
        public void .ctor(){} // RVA: 0x7FFAC98DEF10
    }

    public class PersistentCallGroup : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.Events.PersistentCall> Count; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98DEFB0
        public void get_Count(){} // RVA: 0x7FFAC98DF070
        public void GetListener(){} // RVA: 0x7FFAC98DF0C0
        public void Initialize(){} // RVA: 0x7FFAC98DF140
    }

    public class UnityAction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F7F980
        public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    }

    public class UnityAction`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class UnityAction`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class UnityAction`3 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class UnityAction`4 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class UnityEvent : UnityEventBase
    {
        public object[] m_InvokeArray; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4854470
        public void AddListener(){} // RVA: 0x7FFAC98E0F20
        public void RemoveListener(){} // RVA: 0x7FFAC8C9CBE0
        public void FindMethod_Impl(){} // RVA: 0x7FFAC98E0FD0
        public void GetDelegate(){} // RVA: 0x7FFAC98E10A0 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFAC98E1100
    }

    public class UnityEventBase : Object
    {
        public UnityEngine.Events.InvokableCallList m_Calls; // 0x10
        public UnityEngine.Events.PersistentCallGroup m_PersistentCalls; // 0x18
        public bool m_CallsDirty; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98DFBB0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC98DFF20
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC98DFF20
        public void FindMethod_Impl(){} // RVA: 0x7FFAC2C6A6F0
        public void GetDelegate(){} // RVA: 0x7FFAC2C6A6F0
        public void FindMethod(){} // RVA: 0x7FFAC98E01C0 | overloaded x2
        public void GetPersistentEventCount(){} // RVA: 0x7FFAC98E0590
        public void GetPersistentTarget(){} // RVA: 0x7FFAC98E05E0
        public void GetPersistentMethodName(){} // RVA: 0x7FFAC98E0610
        public void DirtyPersistentCalls(){} // RVA: 0x7FFAC98E0690
        public void RebuildPersistentCallsIfNeeded(){} // RVA: 0x7FFAC98E07C0
        public void GetPersistentListenerState(){} // RVA: 0x7FFAC98E0800
        public void AddCall(){} // RVA: 0x7FFAC98E0940
        public void RemoveListener(){} // RVA: 0x7FFAC98E09A0
        public void RemoveAllListeners(){} // RVA: 0x7FFAC98E09C0
        public void PrepareInvoke(){} // RVA: 0x7FFAC98E0AF0
        public void ToString(){} // RVA: 0x7FFAC98E0C10
        public void GetValidMethodInfo(){} // RVA: 0x7FFAC98E0CC0
    }

    public class UnityEventTools : Object
    {
        // ── Methods ──
        public void TidyAssemblyTypeName(){} // RVA: 0x7FFAC98DD8B0
    }

    public class UnityEvent`1 : UnityEventBase
    {
        public object[] m_InvokeArray; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4854470
        public void AddListener(){} // RVA: 0x7FFAC6E144D0
        public void RemoveListener(){} // RVA: 0x7FFAC6E10E10
        public void FindMethod_Impl(){} // RVA: 0x7FFAC6E14560
        public void GetDelegate(){} // RVA: 0x7FFAC6E14720 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFAC6E147E0
    }

    public class UnityEvent`2 : UnityEventBase
    {
        public object[] m_InvokeArray; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4854470
        public void AddListener(){} // RVA: 0x7FFAC6E144D0
        public void RemoveListener(){} // RVA: 0x7FFAC6E10E10
        public void FindMethod_Impl(){} // RVA: 0x7FFAC6E16CF0
        public void GetDelegate(){} // RVA: 0x7FFAC6E16F60 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFAC6E17020
    }

    public class UnityEvent`3 : UnityEventBase
    {
        public object[] m_InvokeArray; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4854470
        public void AddListener(){} // RVA: 0x7FFAC6E144D0
        public void RemoveListener(){} // RVA: 0x7FFAC6E10E10
        public void FindMethod_Impl(){} // RVA: 0x7FFAC6E19870
        public void GetDelegate(){} // RVA: 0x7FFAC6E19B80 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFAC6E19C40
    }

    public class UnityEvent`4 : UnityEventBase
    {
        public object[] m_InvokeArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void FindMethod_Impl(){} // RVA: 0x7FFAC2C6A6F0
        public void GetDelegate(){} // RVA: 0x7FFAC2C6A6F0
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

}