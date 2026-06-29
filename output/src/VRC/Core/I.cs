// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 4
// Methods: 21

namespace VRC.Core
{
    public class IBundleSignatureHolder
    {
        // ── Methods ──
        public void get_BundleSignature(){} // RVA: 0x87C0A0
    }

    public class ILoggerReceiver
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x8954D0
        public void LogWarning(){} // RVA: 0x8954D0
        public void LogError(){} // RVA: 0x8954D0
        public void LogException(){} // RVA: 0x8943B0
        public void LogFormat(){} // RVA: 0x899870
        public void LogWarningFormat(){} // RVA: 0x899870
        public void LogErrorFormat(){} // RVA: 0x899870
    }

    public class IVRCLogger
    {
        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x87D280
        public void LogOnceEvery(){} // RVA: 0x8A26F0
        public void LogOnceEveryFormat(){} // RVA: 0x8A2770
        public void Log(){} // RVA: 0x894320
        public void LogFormat(){} // RVA: 0x8943B0
        public void LogWarning(){} // RVA: 0x894320
        public void LogWarningFormat(){} // RVA: 0x8943B0
        public void LogError(){} // RVA: 0x894320
        public void LogErrorFormat(){} // RVA: 0x8943B0
    }

    public class InstanceAccessTypeExtensions : Object
    {
        // ── Methods ──
        public void ToInstanceAccessType(){} // RVA: 0xA5C06D0
        public void ToApiString(){} // RVA: 0xA5C0930
        public void ToShortString(){} // RVA: 0xA5C0AB0
        public void ToDisplayString(){} // RVA: 0xA5C0C40
    }

}