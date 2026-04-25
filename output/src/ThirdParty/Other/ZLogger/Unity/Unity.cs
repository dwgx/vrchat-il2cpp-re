// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger.Unity
// Classes: 4
// Methods: 18

namespace ThirdParty.Other.ZLogger.Unity
{
    public class UnityDebugLogProcessor : Object
    {
        public System.Buffers.ArrayBufferWriter`1<byte> IsPostingToUnity; // 0xFFFF
        public ZLogger.Unity.ZLoggerUnityDebugOptions options; // 0x10
        public ZLogger.IZLoggerFormatter formatter; // 0x18
        public bool <IsPostingToUnity>k__BackingField;
        public System.Collections.Generic.Dictionary`2<0x6B179630,0x6B179318> StackTraceLogTypeMappings; // 0x8

        // ── Methods ──
        public void get_IsPostingToUnity(){} // RVA: 0x7FFAC9E60410
        public void set_IsPostingToUnity(){} // RVA: 0x7FFAC9E60470
        public void SetupStackTraceLogTypeMappings(){} // RVA: 0x7FFAC9E604D0
        public void .ctor(){} // RVA: 0x7FFAC9E60800
        public void DisposeAsync(){} // RVA: 0x7FFAC3FB3780
        public void Post(){} // RVA: 0x7FFAC9E608F0
        public void FormatToString(){} // RVA: 0x7FFAC9E61190
        public void .cctor(){} // RVA: 0x7FFAC9E614C0
    }

    public class ZLoggerUnityDebugLoggerProvider : Object
    {
        public ZLogger.ZLoggerOptions options; // 0x10
        public ZLogger.Unity.UnityDebugLogProcessor processor; // 0x18
        public Microsoft.Extensions.Logging.IExternalScopeProvider scopeProvider; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E615B0
        public void CreateLogger(){} // RVA: 0x7FFAC9E617B0
        public void Dispose(){} // RVA: 0x7FFAC9E61860
        public void DisposeAsync(){} // RVA: 0x7FFAC9E618E0
        public void SetScopeProvider(){} // RVA: 0x7FFAC2F4F0D0
    }

    public class ZLoggerUnityDebugOptions : ZLoggerOptions
    {
        public bool PrettyStacktrace; // 0x38

        // ── Methods ──
        public void get_PrettyStacktrace(){} // RVA: 0x7FFAC31D95D0
        public void set_PrettyStacktrace(){} // RVA: 0x7FFAC31D95C0
        public void .ctor(){} // RVA: 0x7FFAC9E601A0
    }

    public class ZLoggerUnityExtensions : Object
    {
        // ── Methods ──
        public void AddZLoggerUnityDebug(){} // RVA: 0x7FFAC9E601B0
        public void AsUnityLogType(){} // RVA: 0x7FFAC9E60310
    }

}