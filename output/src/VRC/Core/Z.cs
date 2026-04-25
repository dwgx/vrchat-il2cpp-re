// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 1
// Methods: 7

namespace VRC.Core
{
    public class ZLoggerHandlerLogger : Object
    {
        public System.Action`3<string,object[],0x6B179630> UnityHandler; // 0x10
        public UnityEngine.ILogHandler _unityHandler;
        public Unity.Profiling.ProfilerMarker _profilerMarkerLogFormat; // 0x8
        public Unity.Profiling.ProfilerMarker _profilerMarkerLogException; // 0x10

        // ── Methods ──
        public void get_UnityHandler(){} // RVA: 0x7FFAC9E6ADB0
        public void EnsureCapturedUnityHandler(){} // RVA: 0x7FFAC9E6AE10
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void SetUnityInterceptActive(){} // RVA: 0x7FFAC9E6AF50
        public void LogFormat(){} // RVA: 0x7FFAC9E6B050
        public void LogException(){} // RVA: 0x7FFAC9E6B6F0
        public void .cctor(){} // RVA: 0x7FFAC9E6B8F0
    }

}