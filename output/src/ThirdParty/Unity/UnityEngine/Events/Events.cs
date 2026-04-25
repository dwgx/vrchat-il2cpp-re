// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Events
// Classes: 16
// Methods: 93

namespace ThirdParty.Unity.UnityEngine.Events
{
    public class BaseInvokableCall : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54CFDB60 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFD4E090A40
        public void ThrowOnInvalidArg(){} // RVA: 0x7FFD4E090A10
        public void AllowInvoke(){} // RVA: 0x7FFD54CFDC80
        public void Find(){} // RVA: 0x7FFD4E07D200
    }

    public class CachedInvokableCall`1 : InvokableCall`1
    {
        public int m_Arg1; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    }

    public class InvokableCall`1 : BaseInvokableCall
    {
        public UnityEngine.Events.UnityAction`1<Valve.VR.VREvent_t> Delegate; // 0x10

        // ── Methods ──
        public void add_Delegate(){} // RVA: 0x7FFD513408D0
        public void remove_Delegate(){} // RVA: 0x7FFD513409E0
        public void .ctor(){} // RVA: 0x7FFD51344010 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFD51344290 | overloaded x2
        public void Find(){} // RVA: 0x7FFD51341050
    }

    public class InvokableCall`2 : BaseInvokableCall
    {
        public UnityEngine.Events.UnityAction`2<Cinemachine.ICinemachineCamera,Cinemachine.ICinemachineCamera> Delegate; // 0x10

        // ── Methods ──
        public void add_Delegate(){} // RVA: 0x7FFD4E090A40
        public void remove_Delegate(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Find(){} // RVA: 0x7FFD4E07D200
    }

    public class InvokableCall`3 : BaseInvokableCall
    {
        public UnityEngine.Events.UnityAction`3<UnityEngine.Color,float,bool> Delegate; // 0x10

        // ── Methods ──
        public void add_Delegate(){} // RVA: 0x7FFD4E090A40
        public void remove_Delegate(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Find(){} // RVA: 0x7FFD4E07D200
    }

    public class InvokableCall`4 : BaseInvokableCall
    {
        public UnityEngine.Events.UnityAction`4<U,V,W,T> Delegate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Find(){} // RVA: 0x7FFD4E07D200
    }

    public class UnityAction`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class UnityAction`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class UnityAction`3 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class UnityAction`4 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class UnityEvent : UnityEventBase
    {
        public object[] m_InvokeArray; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FC74470
        public void AddListener(){} // RVA: 0x7FFD54D00F20
        public void RemoveListener(){} // RVA: 0x7FFD540BCBE0
        public void FindMethod_Impl(){} // RVA: 0x7FFD54D00FD0
        public void GetDelegate(){} // RVA: 0x7FFD54D010A0 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFD54D01100
    }

    public class UnityEventBase : Object
    {
        public 0x664E2110 m_Calls; // 0x10
        public 0x664E20B8 m_PersistentCalls; // 0x18
        public bool m_CallsDirty; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54CFFBB0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD54CFFF20
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD54CFFF20
        public void FindMethod_Impl(){} // RVA: 0x7FFD4E08A6F0
        public void GetDelegate(){} // RVA: 0x7FFD4E08A6F0
        public void FindMethod(){} // RVA: 0x7FFD54D001C0 | overloaded x2
        public void GetPersistentEventCount(){} // RVA: 0x7FFD54D00590
        public void GetPersistentTarget(){} // RVA: 0x7FFD54D005E0
        public void GetPersistentMethodName(){} // RVA: 0x7FFD54D00610
        public void DirtyPersistentCalls(){} // RVA: 0x7FFD54D00690
        public void RebuildPersistentCallsIfNeeded(){} // RVA: 0x7FFD54D007C0
        public void GetPersistentListenerState(){} // RVA: 0x7FFD54D00800
        public void AddCall(){} // RVA: 0x7FFD54D00940
        public void RemoveListener(){} // RVA: 0x7FFD54D009A0
        public void RemoveAllListeners(){} // RVA: 0x7FFD54D009C0
        public void PrepareInvoke(){} // RVA: 0x7FFD54D00AF0
        public void ToString(){} // RVA: 0x7FFD54D00C10
        public void GetValidMethodInfo(){} // RVA: 0x7FFD54D00CC0
    }

    public class UnityEvent`1 : UnityEventBase
    {
        public object[] m_InvokeArray; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FC74470
        public void AddListener(){} // RVA: 0x7FFD522344D0
        public void RemoveListener(){} // RVA: 0x7FFD52230E10
        public void FindMethod_Impl(){} // RVA: 0x7FFD52234560
        public void GetDelegate(){} // RVA: 0x7FFD52234720 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFD522347E0
    }

    public class UnityEvent`2 : UnityEventBase
    {
        public object[] m_InvokeArray; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FC74470
        public void AddListener(){} // RVA: 0x7FFD522344D0
        public void RemoveListener(){} // RVA: 0x7FFD52230E10
        public void FindMethod_Impl(){} // RVA: 0x7FFD52236CF0
        public void GetDelegate(){} // RVA: 0x7FFD52236F60 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFD52237020
    }

    public class UnityEvent`3 : UnityEventBase
    {
        public object[] m_InvokeArray; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FC74470
        public void AddListener(){} // RVA: 0x7FFD522344D0
        public void RemoveListener(){} // RVA: 0x7FFD52230E10
        public void FindMethod_Impl(){} // RVA: 0x7FFD52239870
        public void GetDelegate(){} // RVA: 0x7FFD52239B80 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFD52239C40
    }

    public class UnityEvent`4 : UnityEventBase
    {
        public object[] m_InvokeArray; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void FindMethod_Impl(){} // RVA: 0x7FFD4E08A6F0
        public void GetDelegate(){} // RVA: 0x7FFD4E08A6F0
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

}