// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.Unity
// Classes: 4
// Methods: 18

namespace ThirdParty.Other.ZLogger.Unity
{
    public class UnityDebugLogProcessor : Object
    {
        public object bufferWriter;
        public object options;
        public object formatter;
        public object _isPostingToUnity;
        public object StackTraceLogTypeMappings;

        // ── Methods ──
        public void get_IsPostingToUnity(){} // RVA: 0x8314F60
        public void set_IsPostingToUnity(){} // RVA: 0x8314FC0
        public void SetupStackTraceLogTypeMappings(){} // RVA: 0x8315020
        public void .ctor(){} // RVA: 0x83152F0
        public void DisposeAsync(){} // RVA: 0x1DF4930
        public void Post(){} // RVA: 0x83153E0
        public void FormatToString(){} // RVA: 0x8315C70
        public void .cctor(){} // RVA: 0x8315FC0
    }

    public class ZLoggerUnityDebugLoggerProvider : Object
    {
        public object options;
        public object processor;
        public object scopeProvider;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x83160B0
        public void CreateLogger(){} // RVA: 0x83162B0
        public void Dispose(){} // RVA: 0x8316370
        public void DisposeAsync(){} // RVA: 0x83163F0
        public void SetScopeProvider(){} // RVA: 0xB70100
    }

    public class ZLoggerUnityDebugOptions : ZLoggerOptions
    {
        public object _prettyStacktrace;

        // ── Methods ──
        public void get_PrettyStacktrace(){} // RVA: 0xD16660
        public void set_PrettyStacktrace(){} // RVA: 0xD14C10
        public void .ctor(){} // RVA: 0x8314CF0
    }

    public class ZLoggerUnityExtensions : Object
    {
        // ── Methods ──
        public void AddZLoggerUnityDebug(){} // RVA: 0x8314D00
        public void AsUnityLogType(){} // RVA: 0x8314E60
    }

}