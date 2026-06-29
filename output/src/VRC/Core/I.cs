// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 4
// Methods: 21

namespace VRC.Core
{
    public class IBundleSignatureHolder
    {
        // ── Methods ──
        public void get_BundleSignature(){} // RVA: 0x7A7E00680
    }

    public class ILoggerReceiver
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x7A7E1DDC0
        public void LogWarning(){} // RVA: 0x7A7E1DDC0
        public void LogError(){} // RVA: 0x7A7E1DDC0
        public void LogException(){} // RVA: 0x7A7E18890
        public void LogFormat(){} // RVA: 0x7A7E1DB70
        public void LogWarningFormat(){} // RVA: 0x7A7E1DB70
        public void LogErrorFormat(){} // RVA: 0x7A7E1DB70
    }

    public class IVRCLogger
    {
        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7A7E01900
        public void LogOnceEvery(){} // RVA: 0x7A7E26510
        public void LogOnceEveryFormat(){} // RVA: 0x7A7E26590
        public void Log(){} // RVA: 0x7A7E18800
        public void LogFormat(){} // RVA: 0x7A7E18890
        public void LogWarning(){} // RVA: 0x7A7E18800
        public void LogWarningFormat(){} // RVA: 0x7A7E18890
        public void LogError(){} // RVA: 0x7A7E18800
        public void LogErrorFormat(){} // RVA: 0x7A7E18890
    }

    public class InstanceAccessTypeExtensions : Object
    {
        // ── Methods ──
        public void ToInstanceAccessType(){} // RVA: 0x7B1754350
        public void ToApiString(){} // RVA: 0x7B17545B0
        public void ToShortString(){} // RVA: 0x7B1754730
        public void ToDisplayString(){} // RVA: 0x7B17548C0
    }

}