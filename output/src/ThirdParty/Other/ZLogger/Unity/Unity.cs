// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.Unity
// Classes: 4
// Methods: 18

namespace ThirdParty.Other.ZLogger.Unity
{
    public class UnityDebugLogProcessor : Object
    {
        public System.Buffers.ArrayBufferWriter`1<byte> bufferWriter; // 0xFFFF

        // ── Methods ──
        public void get_IsPostingToUnity(){} // RVA: 0x7FFE88212D80
        public void set_IsPostingToUnity(){} // RVA: 0x7FFE88212DE0
        public void SetupStackTraceLogTypeMappings(){} // RVA: 0x7FFE88212E40
        public void .ctor(){} // RVA: 0x7FFE88213170
        public void DisposeAsync(){} // RVA: 0x7FFE822CCD10
        public void Post(){} // RVA: 0x7FFE88213260
        public void FormatToString(){} // RVA: 0x7FFE88213B00
        public void .cctor(){} // RVA: 0x7FFE88213E30
    }

    public class ZLoggerUnityDebugLoggerProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88213F20
        public void CreateLogger(){} // RVA: 0x7FFE88214120
        public void Dispose(){} // RVA: 0x7FFE882141D0
        public void DisposeAsync(){} // RVA: 0x7FFE88214250
        public void SetScopeProvider(){} // RVA: 0x7FFE811290D0
    }

    public class ZLoggerUnityDebugOptions : ZLoggerOptions
    {
        public bool _prettyStacktrace; // 0x38

        // ── Methods ──
        public void get_PrettyStacktrace(){} // RVA: 0x7FFE812CF770
        public void set_PrettyStacktrace(){} // RVA: 0x7FFE812D0010
        public void .ctor(){} // RVA: 0x7FFE88212B10
    }

    public class ZLoggerUnityExtensions : Object
    {
        // ── Methods ──
        public void AddZLoggerUnityDebug(){} // RVA: 0x7FFE88212B20
        public void AsUnityLogType(){} // RVA: 0x7FFE88212C80
    }

}