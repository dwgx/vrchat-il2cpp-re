// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.Unity
// Classes: 4
// Methods: 18

namespace ThirdParty.Other.ZLogger.Unity
{
    public class UnityDebugLogProcessor : Object
    {
        public object IsPostingToUnity;

        // ── Methods ──
        public void get_IsPostingToUnity(){} // RVA: 0x7FFD55280410
        public void set_IsPostingToUnity(){} // RVA: 0x7FFD55280470
        public void SetupStackTraceLogTypeMappings(){} // RVA: 0x7FFD552804D0
        public void .ctor(){} // RVA: 0x7FFD55280800
        public void DisposeAsync(){} // RVA: 0x7FFD4F3D3780
        public void Post(){} // RVA: 0x7FFD552808F0
        public void FormatToString(){} // RVA: 0x7FFD55281190
        public void .cctor(){} // RVA: 0x7FFD552814C0
    }

    public class ZLoggerUnityDebugLoggerProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD552815B0
        public void CreateLogger(){} // RVA: 0x7FFD552817B0
        public void Dispose(){} // RVA: 0x7FFD55281860
        public void DisposeAsync(){} // RVA: 0x7FFD552818E0
        public void SetScopeProvider(){} // RVA: 0x7FFD4E36F0D0
    }

    public class ZLoggerUnityDebugOptions : ZLoggerOptions
    {
        public object PrettyStacktrace;

        // ── Methods ──
        public void get_PrettyStacktrace(){} // RVA: 0x7FFD4E5F95D0
        public void set_PrettyStacktrace(){} // RVA: 0x7FFD4E5F95C0
        public void .ctor(){} // RVA: 0x7FFD552801A0
    }

    public class ZLoggerUnityExtensions : Object
    {
        // ── Methods ──
        public void AddZLoggerUnityDebug(){} // RVA: 0x7FFD552801B0
        public void AsUnityLogType(){} // RVA: 0x7FFD55280310
    }

}