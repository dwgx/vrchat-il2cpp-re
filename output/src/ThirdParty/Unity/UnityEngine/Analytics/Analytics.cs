// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Analytics
// Classes: 4
// Methods: 24

namespace ThirdParty.Unity.UnityEngine.Analytics
{
    public class Analytics
    {
        // ── Methods ──
        public void IsInitialized(){} // RVA: 0x74F7A70
        public void Transaction(){} // RVA: 0x74F7C30 | overloaded x3
        public void SendCustomEventName(){} // RVA: 0x74F7B50
        public void SendCustomEvent(){} // RVA: 0x74F7BA0
        public void CustomEvent(){} // RVA: 0x74F7E70
    }

    public class AnalyticsSessionInfo
    {
        // ── Methods ──
        public void CallSessionStateChanged(){} // RVA: 0x74F6800
        public void get_userId(){} // RVA: 0x74F6890
        public void CallIdentityTokenChanged(){} // RVA: 0x74F68E0
    }

    public class ContinuousEvent
    {
    }

    public class CustomEventData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x74F6A10
        public void Finalize(){} // RVA: 0x74F6A80
        public void Destroy(){} // RVA: 0x74F6AC0
        public void Dispose(){} // RVA: 0x74F6B30
        public void Internal_Create(){} // RVA: 0x74F6B90
        public void Internal_Destroy(){} // RVA: 0x74F6BF0
        public void AddString(){} // RVA: 0x74F6C40
        public void AddInt32(){} // RVA: 0x74F6CB0
        public void AddUInt32(){} // RVA: 0x74F6D20
        public void AddInt64(){} // RVA: 0x74F6D90
        public void AddUInt64(){} // RVA: 0x74F6E00
        public void AddBool(){} // RVA: 0x74F6E70
        public void AddDouble(){} // RVA: 0x74F6EE0
        public void AddDictionary(){} // RVA: 0x74F6F50
    }

}