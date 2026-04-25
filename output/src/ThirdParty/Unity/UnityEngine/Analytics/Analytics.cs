// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Analytics
// Classes: 4
// Methods: 24

namespace ThirdParty.Unity.UnityEngine.Analytics
{
    public class Analytics : Object
    {
        // ── Methods ──
        public void IsInitialized(){} // RVA: 0x7FFAC9C8F3F0
        public void Transaction(){} // RVA: 0x7FFAC9C8F5B0 | overloaded x3
        public void SendCustomEventName(){} // RVA: 0x7FFAC9C8F4D0
        public void SendCustomEvent(){} // RVA: 0x7FFAC9C8F520
        public void CustomEvent(){} // RVA: 0x7FFAC9C8F7F0
    }

    public class AnalyticsSessionInfo : Object
    {
        public SessionStateChanged userId;
        public IdentityTokenChanged identityTokenChanged; // 0x8

        // ── Methods ──
        public void CallSessionStateChanged(){} // RVA: 0x7FFAC9C8E180
        public void get_userId(){} // RVA: 0x7FFAC9C8E210
        public void CallIdentityTokenChanged(){} // RVA: 0x7FFAC9C8E260
    }

    public class ContinuousEvent : Object
    {
    }

    public class CustomEventData : Object
    {
        public UIntPtr m_Ptr; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C8E390
        public void Finalize(){} // RVA: 0x7FFAC9C8E400
        public void Destroy(){} // RVA: 0x7FFAC9C8E440
        public void Dispose(){} // RVA: 0x7FFAC9C8E4B0
        public void Internal_Create(){} // RVA: 0x7FFAC9C8E510
        public void Internal_Destroy(){} // RVA: 0x7FFAC9C8E570
        public void AddString(){} // RVA: 0x7FFAC9C8E5C0
        public void AddInt32(){} // RVA: 0x7FFAC9C8E630
        public void AddUInt32(){} // RVA: 0x7FFAC9C8E6A0
        public void AddInt64(){} // RVA: 0x7FFAC9C8E710
        public void AddUInt64(){} // RVA: 0x7FFAC9C8E780
        public void AddBool(){} // RVA: 0x7FFAC9C8E7F0
        public void AddDouble(){} // RVA: 0x7FFAC9C8E860
        public void AddDictionary(){} // RVA: 0x7FFAC9C8E8D0
    }

}