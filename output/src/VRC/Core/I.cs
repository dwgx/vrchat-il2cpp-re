// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 4
// Methods: 21

namespace VRC.Core
{
    public class IBundleSignatureHolder
    {
        // ── Methods ──
        public void get_BundleSignature(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ILoggerReceiver
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x7FFE80E50660
        public void LogWarning(){} // RVA: 0x7FFE80E50660
        public void LogError(){} // RVA: 0x7FFE80E50660
        public void LogException(){} // RVA: 0x7FFE80E4F230
        public void LogFormat(){} // RVA: 0x7FFE80E50FC0
        public void LogWarningFormat(){} // RVA: 0x7FFE80E50FC0
        public void LogErrorFormat(){} // RVA: 0x7FFE80E50FC0
    }

    public class IVRCLogger
    {
        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7FFE80E2F150
        public void LogOnceEvery(){}
        public void LogOnceEveryFormat(){}
        public void Log(){} // RVA: 0x7FFE80E460A0
        public void LogFormat(){} // RVA: 0x7FFE80E4F230
        public void LogWarning(){} // RVA: 0x7FFE80E460A0
        public void LogWarningFormat(){} // RVA: 0x7FFE80E4F230
        public void LogError(){} // RVA: 0x7FFE80E460A0
        public void LogErrorFormat(){} // RVA: 0x7FFE80E4F230
    }

    public class InstanceAccessTypeExtensions : Object
    {
        // ── Methods ──
        public void ToInstanceAccessType(){} // RVA: 0x7FFE8A375440
        public void ToApiString(){} // RVA: 0x7FFE8A3756A0
        public void ToShortString(){} // RVA: 0x7FFE8A375820
        public void ToDisplayString(){} // RVA: 0x7FFE8A3759B0
    }

}