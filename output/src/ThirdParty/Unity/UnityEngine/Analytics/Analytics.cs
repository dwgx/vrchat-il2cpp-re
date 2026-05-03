// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Analytics
// Classes: 4
// Methods: 24

namespace ThirdParty.Unity.UnityEngine.Analytics
{
    public class Analytics : Object
    {
        // ── Methods ──
        public void IsInitialized(){} // RVA: 0x7FFE88037C40
        public void Transaction(){} // RVA: 0x7FFE88037E00 | overloaded x3
        public void SendCustomEventName(){} // RVA: 0x7FFE88037D20
        public void SendCustomEvent(){} // RVA: 0x7FFE88037D70
        public void CustomEvent(){} // RVA: 0x7FFE88038040
    }

    public class AnalyticsSessionInfo : Object
    {
        public SessionStateChanged sessionStateChanged;

        // ── Methods ──
        public void CallSessionStateChanged(){} // RVA: 0x7FFE880369D0
        public void get_userId(){} // RVA: 0x7FFE88036A60
        public void CallIdentityTokenChanged(){} // RVA: 0x7FFE88036AB0
    }

    public class ContinuousEvent : Object
    {
    }

    public class CustomEventData : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88036BE0
        public void Finalize(){} // RVA: 0x7FFE88036C50
        public void Destroy(){} // RVA: 0x7FFE88036C90
        public void Dispose(){} // RVA: 0x7FFE88036D00
        public void Internal_Create(){} // RVA: 0x7FFE88036D60
        public void Internal_Destroy(){} // RVA: 0x7FFE88036DC0
        public void AddString(){} // RVA: 0x7FFE88036E10
        public void AddInt32(){} // RVA: 0x7FFE88036E80
        public void AddUInt32(){} // RVA: 0x7FFE88036EF0
        public void AddInt64(){} // RVA: 0x7FFE88036F60
        public void AddUInt64(){} // RVA: 0x7FFE88036FD0
        public void AddBool(){} // RVA: 0x7FFE88037040
        public void AddDouble(){} // RVA: 0x7FFE880370B0
        public void AddDictionary(){} // RVA: 0x7FFE88037120
    }

}