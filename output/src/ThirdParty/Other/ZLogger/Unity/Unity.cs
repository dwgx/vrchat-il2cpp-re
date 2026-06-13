// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.Unity
// Classes: 4
// Methods: 18

namespace ThirdParty.Other.ZLogger.Unity
{
    public class UnityDebugLogProcessor
    {
        public System.Buffers.ArrayBufferWriter`1<byte> bufferWriter; // 0xFFFFFFFF

        // ── Methods ──
        public void get_IsPostingToUnity(){} // RVA: 0x76D5C60
        public void set_IsPostingToUnity(){} // RVA: 0x76D5CC0
        public void SetupStackTraceLogTypeMappings(){} // RVA: 0x76D5D20
        public void .ctor(){} // RVA: 0x76D6050
        public void DisposeAsync(){} // RVA: 0x1529E90
        public void Post(){} // RVA: 0x76D6140
        public void FormatToString(){} // RVA: 0x76D69E0
        public void .cctor(){} // RVA: 0x76D6D10
    }

    public class ZLoggerUnityDebugLoggerProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76D6E00
        public void CreateLogger(){} // RVA: 0x76D7000
        public void Dispose(){} // RVA: 0x76D70B0
        public void DisposeAsync(){} // RVA: 0x76D7130
        public void SetScopeProvider(){} // RVA: 0x30B0D0
    }

    public class ZLoggerUnityDebugOptions
    {
        public bool InternalErrorLogger; // 0x38

        // ── Methods ──
        public void get_PrettyStacktrace(){} // RVA: 0x4A6500
        public void set_PrettyStacktrace(){} // RVA: 0x4A78C0
        public void .ctor(){} // RVA: 0x76D59F0
    }

    public class ZLoggerUnityExtensions
    {
        // ── Methods ──
        public void AddZLoggerUnityDebug(){} // RVA: 0x76D5A00
        public void AsUnityLogType(){} // RVA: 0x76D5B60
    }

}