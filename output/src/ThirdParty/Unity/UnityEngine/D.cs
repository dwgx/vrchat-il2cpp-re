// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 9
// Methods: 78

namespace ThirdParty.Unity.UnityEngine
{
    public class Debug
    {
        public UnityEngine.ILogger order;
        public UnityEngine.ILogger s_Logger; // 0x8

        // ── Methods ──
        public void get_unityLogger(){} // RVA: 0x70C6D00
        public void DrawLine(){} // RVA: 0x70C70D0 | overloaded x4
        public void DrawRay(){} // RVA: 0x70C73D0 | overloaded x4
        public void Break(){} // RVA: 0x70C7560
        public void DebugBreak(){} // RVA: 0x70C75B0
        public void ExtractStackTraceNoAlloc(){} // RVA: 0x70C7600
        public void Log(){} // RVA: 0x70C7740 | overloaded x2
        public void LogFormat(){} // RVA: 0x70C79C0 | overloaded x3
        public void LogError(){} // RVA: 0x70C7D00 | overloaded x2
        public void LogErrorFormat(){} // RVA: 0x70C7EA0 | overloaded x2
        public void LogException(){} // RVA: 0x70C8040 | overloaded x2
        public void LogWarning(){} // RVA: 0x70C81E0 | overloaded x2
        public void LogWarningFormat(){} // RVA: 0x70C8380 | overloaded x2
        public void Assert(){} // RVA: 0x70C8510 | overloaded x2
        public void LogAssertion(){} // RVA: 0x70C85B0
        public void LogAssertionFormat(){} // RVA: 0x70C8680
        public void get_isDebugBuild(){} // RVA: 0x70C8750
        public void CallOverridenDebugHandler(){} // RVA: 0x70C87A0
        public void IsLoggingEnabled(){} // RVA: 0x70C8A00
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x70C8B50
        public void DrawLine_Injected(){} // RVA: 0x70C8CF0
    }

    public class DebugLogHandler : Internal_Log
    {
        // ── Methods ──
        public void Internal_Log(){} // RVA: 0x70C6980
        public void Internal_LogException(){} // RVA: 0x70C6A00
        public void LogFormat(){} // RVA: 0x70C6B50 | overloaded x2
        public void LogException(){} // RVA: 0x70C6C50
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DefaultExecutionOrder
    {
        public int m_Order; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void get_order(){} // RVA: 0x70B92A0
    }

    public class DetailPrototype
    {
        public UnityEngine.Color DefaultHealthColor;

        // ── Methods ──
        public void get_prototype(){} // RVA: 0x33B6D40
        public void .ctor(){} // RVA: 0x725E540
        public void Equals(){} // RVA: 0x725E710 | overloaded x2
        public void GetHashCode(){} // RVA: 0x712D740
        public void .cctor(){} // RVA: 0x725EB10
    }

    public class DisallowMultipleComponent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Display
    {
        public UIntPtr nativeDisplay; // 0x10
        public UnityEngine.Display[] displays;
        public UnityEngine.Display _mainDisplay; // 0x8
        public int m_ActiveEditorGameViewTarget; // 0x10
        public DisplaysUpdatedDelegate onDisplaysUpdated; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1967700 | overloaded x2
        public void get_renderingWidth(){} // RVA: 0x70D2A30
        public void get_renderingHeight(){} // RVA: 0x70D2AD0
        public void get_systemWidth(){} // RVA: 0x70D2B70
        public void get_systemHeight(){} // RVA: 0x70D2C10
        public void get_colorBuffer(){} // RVA: 0x70D2CB0
        public void RelativeMouseAt(){} // RVA: 0x70D2D70
        public void get_main(){} // RVA: 0x70D2E60
        public void RecreateDisplayList(){} // RVA: 0x70D2EC0
        public void FireDisplaysUpdated(){} // RVA: 0x70D3170
        public void GetSystemExtImpl(){} // RVA: 0x70D3210
        public void GetRenderingExtImpl(){} // RVA: 0x70D3280
        public void GetRenderingBuffersImpl(){} // RVA: 0x70D32F0
        public void RelativeMouseAtImpl(){} // RVA: 0x70D3360
        public void .cctor(){} // RVA: 0x70D33E0
    }

    public class DistanceJoint2D
    {
        public object dampingRatio;
        public object frequency;
        public object referenceAngle;

        // ── Methods ──
        public void get_autoConfigureDistance(){} // RVA: 0x71EBDB0
        public void set_autoConfigureDistance(){} // RVA: 0x71EBE00
        public void get_distance(){} // RVA: 0x71EBE60
        public void set_distance(){} // RVA: 0x71EBEB0
        public void get_maxDistanceOnly(){} // RVA: 0x71EBF10
        public void set_maxDistanceOnly(){} // RVA: 0x71EBF60
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class DrivenRectTransformTracker
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x2DD310
        public void Clear(){} // RVA: 0x2DD310
    }

    public class DynamicGI
    {
        // ── Methods ──
        public void UpdateEnvironment(){} // RVA: 0x70CFDF0
    }

}