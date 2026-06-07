// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 4
// Methods: 21

namespace VRC.Core
{
    public class IBundleSignatureHolder
    {
        // ── Methods ──
        public void get_BundleSignature(){} // RVA: 0xCD60
    }

    public class ILoggerReceiver
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x2F090
        public void LogWarning(){} // RVA: 0x2F090
        public void LogError(){} // RVA: 0x2F090
        public void LogException(){} // RVA: 0x2DC60
        public void LogFormat(){} // RVA: 0x2F9F0
        public void LogWarningFormat(){} // RVA: 0x2F9F0
        public void LogErrorFormat(){} // RVA: 0x2F9F0
    }

    public class IVRCLogger
    {
        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0xDBE0
        public void LogOnceEvery(){}
        public void LogOnceEveryFormat(){}
        public void Log(){} // RVA: 0x24B10
        public void LogFormat(){} // RVA: 0x2DC60
        public void LogWarning(){} // RVA: 0x24B10
        public void LogWarningFormat(){} // RVA: 0x2DC60
        public void LogError(){} // RVA: 0x24B10
        public void LogErrorFormat(){} // RVA: 0x2DC60
    }

    public class InstanceAccessTypeExtensions
    {
        // ── Methods ──
        public void ToInstanceAccessType(){} // RVA: 0x99189A0
        public void ToApiString(){} // RVA: 0x9918C00
        public void ToShortString(){} // RVA: 0x9918D80
        public void ToDisplayString(){} // RVA: 0x9918F10
    }

}