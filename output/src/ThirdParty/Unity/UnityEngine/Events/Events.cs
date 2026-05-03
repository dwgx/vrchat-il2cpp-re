// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Events
// Classes: 23
// Methods: 135

namespace ThirdParty.Unity.UnityEngine.Events
{
    public class ArgumentCache : Object
    {
        public UnityEngine.Object m_ObjectArgument; // 0x10
        public string m_ObjectArgumentAssemblyTypeName; // 0x18
        public int m_IntArgument; // 0x20
        public float m_FloatArgument; // 0x24
        public string m_StringArgument; // 0x28
        public bool m_BoolArgument; // 0x30

        // ── Methods ──
        public void get_unityObjectArgument(){} // RVA: 0x7FFE84022BE0
        public void get_unityObjectArgumentAssemblyTypeName(){} // RVA: 0x7FFE83BBC680
        public void get_intArgument(){} // RVA: 0x7FFE850173A0
        public void get_floatArgument(){} // RVA: 0x7FFE87BBD380
        public void get_stringArgument(){} // RVA: 0x7FFE87C86200
        public void get_boolArgument(){} // RVA: 0x7FFE87C86210
        public void OnBeforeSerialize(){} // RVA: 0x7FFE87C86220
        public void OnAfterDeserialize(){} // RVA: 0x7FFE87C86220
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class BaseInvokableCall : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C86290 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFE80E460A0
        public void ThrowOnInvalidArg(){} // RVA: 0x7FFE80E46070
        public void AllowInvoke(){} // RVA: 0x7FFE87C863B0
        public void Find(){} // RVA: 0x7FFE80E32650
    }

    public class CachedInvokableCall`1 : InvokableCall`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void Invoke(){} // RVA: 0x7FFE810A1420 | overloaded x2
    }

    public class InvokableCall : BaseInvokableCall
    {
        // ── Methods ──
        public void add_Delegate(){} // RVA: 0x7FFE87C864E0
        public void remove_Delegate(){} // RVA: 0x7FFE87C865D0
        public void .ctor(){} // RVA: 0x7FFE87C86910 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFE87C86920 | overloaded x2
        public void Find(){} // RVA: 0x7FFE842774A0
    }

    public class InvokableCallList : Object
    {
        // ── Methods ──
        public void AddPersistentInvokableCall(){} // RVA: 0x7FFE87C87A30
        public void AddListener(){} // RVA: 0x7FFE87C87A90
        public void RemoveListener(){} // RVA: 0x7FFE87C87AF0
        public void Clear(){} // RVA: 0x7FFE87C87E00
        public void ClearPersistent(){} // RVA: 0x7FFE87C87F20
        public void PrepareInvoke(){} // RVA: 0x7FFE87C88040
        public void .ctor(){} // RVA: 0x7FFE87C88130
    }

    public class InvokableCall`1 : BaseInvokableCall
    {
        // ── Methods ──
        public void add_Delegate(){} // RVA: 0x7FFE84276D20
        public void remove_Delegate(){} // RVA: 0x7FFE84276E30
        public void .ctor(){} // RVA: 0x7FFE8427A460 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFE8427A6E0 | overloaded x2
        public void Find(){} // RVA: 0x7FFE842774A0
    }

    public class InvokableCall`2 : BaseInvokableCall
    {
        // ── Methods ──
        public void add_Delegate(){} // RVA: 0x7FFE80E460A0
        public void remove_Delegate(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Find(){} // RVA: 0x7FFE80E32650
    }

    public class InvokableCall`3 : BaseInvokableCall
    {
        // ── Methods ──
        public void add_Delegate(){} // RVA: 0x7FFE80E460A0
        public void remove_Delegate(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Find(){} // RVA: 0x7FFE80E32650
    }

    public class InvokableCall`4 : BaseInvokableCall
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4F230
        public void Invoke(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Find(){} // RVA: 0x7FFE80E32650
    }

    public class PersistentCall : Object
    {
        public UnityEngine.Object m_Target; // 0x10
        public string m_TargetAssemblyTypeName; // 0x18
        public string m_MethodName; // 0x20
        public 0x6657B504 m_Mode; // 0x28
        public UnityEngine.Events.ArgumentCache m_Arguments; // 0x30
        public 0x6657B874 m_CallState; // 0x38

        // ── Methods ──
        public void get_target(){} // RVA: 0x7FFE84022BE0
        public void get_targetAssemblyTypeName(){} // RVA: 0x7FFE87C86970
        public void get_methodName(){} // RVA: 0x7FFE87563690
        public void get_mode(){} // RVA: 0x7FFE850164C0
        public void get_arguments(){} // RVA: 0x7FFE87C86B00
        public void get_callState(){} // RVA: 0x7FFE87C86B10
        public void IsValid(){} // RVA: 0x7FFE87C86B20
        public void GetRuntimeCall(){} // RVA: 0x7FFE87C86B60
        public void GetObjectCall(){} // RVA: 0x7FFE87C86FA0
        public void OnBeforeSerialize(){} // RVA: 0x7FFE87C86220
        public void OnAfterDeserialize(){} // RVA: 0x7FFE87C86220
        public void .ctor(){} // RVA: 0x7FFE87C87640
    }

    public class PersistentCallGroup : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.Events.PersistentCall> m_Calls; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C876E0
        public void get_Count(){} // RVA: 0x7FFE87C877A0
        public void GetListener(){} // RVA: 0x7FFE87C877F0
        public void Initialize(){} // RVA: 0x7FFE87C87870
    }

    public class UnityAction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81159980
        public void Invoke(){} // RVA: 0x7FFE81159A50
    }

    public class UnityAction`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class UnityAction`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class UnityAction`3 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class UnityAction`4 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class UnityEvent : UnityEventBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82ABC810
        public void AddListener(){} // RVA: 0x7FFE87C89650
        public void RemoveListener(){} // RVA: 0x7FFE870450D0
        public void FindMethod_Impl(){} // RVA: 0x7FFE87C89700
        public void GetDelegate(){} // RVA: 0x7FFE87C897D0 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFE87C89830
    }

    public class UnityEventBase : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C882E0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE87C88650
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE87C88650
        public void FindMethod_Impl(){} // RVA: 0x7FFE80E3FC10
        public void GetDelegate(){} // RVA: 0x7FFE80E3FC10
        public void FindMethod(){} // RVA: 0x7FFE87C888F0 | overloaded x2
        public void GetPersistentEventCount(){} // RVA: 0x7FFE87C88CC0
        public void GetPersistentTarget(){} // RVA: 0x7FFE87C88D10
        public void GetPersistentMethodName(){} // RVA: 0x7FFE87C88D40
        public void DirtyPersistentCalls(){} // RVA: 0x7FFE87C88DC0
        public void RebuildPersistentCallsIfNeeded(){} // RVA: 0x7FFE87C88EF0
        public void GetPersistentListenerState(){} // RVA: 0x7FFE87C88F30
        public void AddCall(){} // RVA: 0x7FFE87C89070
        public void RemoveListener(){} // RVA: 0x7FFE87C890D0
        public void RemoveAllListeners(){} // RVA: 0x7FFE87C890F0
        public void PrepareInvoke(){} // RVA: 0x7FFE87C89220
        public void ToString(){} // RVA: 0x7FFE87C89340
        public void GetValidMethodInfo(){} // RVA: 0x7FFE87C893F0
    }

    public class UnityEventTools : Object
    {
        // ── Methods ──
        public void TidyAssemblyTypeName(){} // RVA: 0x7FFE87C85FE0
    }

    public class UnityEvent`1 : UnityEventBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82ABC810
        public void AddListener(){} // RVA: 0x7FFE851A0280
        public void RemoveListener(){} // RVA: 0x7FFE8519CBC0
        public void FindMethod_Impl(){} // RVA: 0x7FFE851A0310
        public void GetDelegate(){} // RVA: 0x7FFE851A04D0 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFE851A0590
    }

    public class UnityEvent`2 : UnityEventBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82ABC810
        public void AddListener(){} // RVA: 0x7FFE851A0280
        public void RemoveListener(){} // RVA: 0x7FFE8519CBC0
        public void FindMethod_Impl(){} // RVA: 0x7FFE851A2AA0
        public void GetDelegate(){} // RVA: 0x7FFE851A2D10 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFE851A2DD0
    }

    public class UnityEvent`3 : UnityEventBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82ABC810
        public void AddListener(){} // RVA: 0x7FFE851A0280
        public void RemoveListener(){} // RVA: 0x7FFE8519CBC0
        public void FindMethod_Impl(){} // RVA: 0x7FFE851A5620
        public void GetDelegate(){} // RVA: 0x7FFE851A5930 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFE851A59F0
    }

    public class UnityEvent`4 : UnityEventBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void FindMethod_Impl(){} // RVA: 0x7FFE80E3FC10
        public void GetDelegate(){} // RVA: 0x7FFE80E3FC10
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

}