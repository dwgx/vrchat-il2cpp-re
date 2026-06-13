// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Events
// Classes: 2
// Methods: 16

namespace ThirdParty.Unity.UnityEngine.Events
{
    public class PersistentCall
    {
        public UnityEngine.Object m_Target; // 0x10
        public string m_TargetAssemblyTypeName; // 0x18
        public string m_MethodName; // 0x20
        public 0x6589DC98 m_Mode; // 0x28
        public UnityEngine.Events.ArgumentCache m_Arguments; // 0x30
        public 0x6589E008 m_CallState; // 0x38

        // ── Methods ──
        public void get_target(){} // RVA: 0x33B6D40
        public void get_targetAssemblyTypeName(){} // RVA: 0x7145D00
        public void get_methodName(){} // RVA: 0x6A24380
        public void get_mode(){} // RVA: 0x43DB8C0
        public void get_arguments(){} // RVA: 0x7145E90
        public void get_callState(){} // RVA: 0x7145EA0
        public void IsValid(){} // RVA: 0x7145EB0
        public void GetRuntimeCall(){} // RVA: 0x7145EF0
        public void GetObjectCall(){} // RVA: 0x7146330
        public void OnBeforeSerialize(){} // RVA: 0x71455B0
        public void OnAfterDeserialize(){} // RVA: 0x71455B0
        public void .ctor(){} // RVA: 0x71469D0
    }

    public class PersistentCallGroup
    {
        public System.Collections.Generic.List`1<UnityEngine.Events.PersistentCall> m_Calls; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7146A70
        public void get_Count(){} // RVA: 0x7146B30
        public void GetListener(){} // RVA: 0x7146B80
        public void Initialize(){} // RVA: 0x7146C00
    }

}