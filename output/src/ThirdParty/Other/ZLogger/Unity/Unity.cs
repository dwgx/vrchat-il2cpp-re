// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.Unity
// Classes: 4
// Methods: 18

namespace ThirdParty.Other.ZLogger.Unity
{
    public class UnityDebugLogProcessor : Object
    {
        // ── Methods ──
        public void get_IsPostingToUnity(){} // RVA: 0x7AF4B49A0
        public void set_IsPostingToUnity(){} // RVA: 0x7AF4B4A00
        public void SetupStackTraceLogTypeMappings(){} // RVA: 0x7AF4B4A60
        public void .ctor(){} // RVA: 0x7AF4B4D90
        public void DisposeAsync(){} // RVA: 0x7A92BE230
        public void Post(){} // RVA: 0x7AF4B4E80
        public void FormatToString(){} // RVA: 0x7AF4B5710
        public void .cctor(){} // RVA: 0x7AF4B5A60
    }

    public class ZLoggerUnityDebugLoggerProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF4B5B50
        public void CreateLogger(){} // RVA: 0x7AF4B5D50
        public void Dispose(){} // RVA: 0x7AF4B5E10
        public void DisposeAsync(){} // RVA: 0x7AF4B5E90
        public void SetScopeProvider(){} // RVA: 0x7A81052D0
    }

    public class ZLoggerUnityDebugOptions : ZLoggerOptions
    {
        // ── Methods ──
        public void get_PrettyStacktrace(){} // RVA: 0x7A82A20A0
        public void set_PrettyStacktrace(){} // RVA: 0x7A82A2C90
        public void .ctor(){} // RVA: 0x7AF4B4730
    }

    public class ZLoggerUnityExtensions : Object
    {
        // ── Methods ──
        public void AddZLoggerUnityDebug(){} // RVA: 0x7AF4B4740
        public void AsUnityLogType(){} // RVA: 0x7AF4B48A0
    }

}