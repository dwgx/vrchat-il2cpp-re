// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.Unity
// Classes: 4
// Methods: 18

namespace ThirdParty.Other.ZLogger.Unity
{
    public class UnityDebugLogProcessor : Object
    {
        public object formatter; // 0x34DA8C50

        // ── Original Methods ──
        public void get_IsPostingToUnity(){} // RVA: 0x7ffaaf882e30
        public void set_IsPostingToUnity(){} // RVA: 0x7ffaaf882e90
        public void .ctor(){} // RVA: 0x7ffaaf883220
        public void DisposeAsync(){} // RVA: 0x7ffaa99e0f50
        public void Post(){} // RVA: 0x7ffaaf883310
        public void FormatToString(){} // RVA: 0x7ffaaf883bb0
        public void .cctor(){} // RVA: 0x7ffaaf883ee0
        // ── Binary Analysis Named ──
        public void SetupStackTraceLogTypeMappings(){} // RVA: 0x7ffaaf882ef0
    }

    public class ZLoggerUnityDebugLoggerProvider : Object
    {
        public object scopeProvider; // 0x3354B1C0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf883fd0
        public void CreateLogger(){} // RVA: 0x7ffaaf8841d0
        public void Dispose(){} // RVA: 0x7ffaaf884280
        public void DisposeAsync(){} // RVA: 0x7ffaaf884300
        // ── Binary Analysis Named ──
        public void SetScopeProvider(){} // RVA: 0x7ffaa89600d0
    }

    public class ZLoggerUnityDebugOptions : ZLoggerOptions
    {
        // ── Original Methods ──
        public void get_PrettyStacktrace(){} // RVA: 0x7ffaa8bfcc70
        public void set_PrettyStacktrace(){} // RVA: 0x7ffaa8bfbbe0
        public void .ctor(){} // RVA: 0x7ffaaf882bc0
    }

    public class ZLoggerUnityExtensions : Object
    {
        // ── Original Methods ──
        public void AddZLoggerUnityDebug(){} // RVA: 0x7ffaaf882bd0
        public void AsUnityLogType(){} // RVA: 0x7ffaaf882d30
    }

}