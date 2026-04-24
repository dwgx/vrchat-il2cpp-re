// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 8
// Methods: 77

namespace ThirdParty.Unity.UnityEngine
{
    public class Debug : Object
    {
        // ── Original Methods ──
        public void get_unityLogger(){} // RVA: 0x7ffaaf281630
        public void DrawLine(){} // RVA: 0x7ffaaf281a00
        public void DrawLine(){} // RVA: 0x7ffaaf281a00
        public void DrawLine(){} // RVA: 0x7ffaaf281a00
        public void DrawLine(){} // RVA: 0x7ffaaf281a00
        public void DrawRay(){} // RVA: 0x7ffaaf281d00
        public void DrawRay(){} // RVA: 0x7ffaaf281d00
        public void DrawRay(){} // RVA: 0x7ffaaf281d00
        public void DrawRay(){} // RVA: 0x7ffaaf281d00
        public void Break(){} // RVA: 0x7ffaaf281e90
        public void DebugBreak(){} // RVA: 0x7ffaaf281ee0
        public void ExtractStackTraceNoAlloc(){} // RVA: 0x7ffaaf281f30
        public void Log(){} // RVA: 0x7ffaaf282070
        public void Log(){} // RVA: 0x7ffaaf282070
        public void LogFormat(){} // RVA: 0x7ffaaf2822f0
        public void LogFormat(){} // RVA: 0x7ffaaf2822f0
        public void LogFormat(){} // RVA: 0x7ffaaf2822f0
        public void LogError(){} // RVA: 0x7ffaaf282630
        public void LogError(){} // RVA: 0x7ffaaf282630
        public void LogErrorFormat(){} // RVA: 0x7ffaaf2827d0
        public void LogErrorFormat(){} // RVA: 0x7ffaaf2827d0
        public void LogException(){} // RVA: 0x7ffaaf282970
        public void LogException(){} // RVA: 0x7ffaaf282970
        public void LogWarning(){} // RVA: 0x7ffaaf282b10
        public void LogWarning(){} // RVA: 0x7ffaaf282b10
        public void LogWarningFormat(){} // RVA: 0x7ffaaf282cb0
        public void LogWarningFormat(){} // RVA: 0x7ffaaf282cb0
        public void Assert(){} // RVA: 0x7ffaaf282e40
        public void Assert(){} // RVA: 0x7ffaaf282e40
        public void LogAssertion(){} // RVA: 0x7ffaaf282ee0
        public void LogAssertionFormat(){} // RVA: 0x7ffaaf282fb0
        public void get_isDebugBuild(){} // RVA: 0x7ffaaf283080
        public void CallOverridenDebugHandler(){} // RVA: 0x7ffaaf2830d0
        public void IsLoggingEnabled(){} // RVA: 0x7ffaaf283330
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaf283480
        public void DrawLine_Injected(){} // RVA: 0x7ffaaf283620
    }

    public class DebugLogHandler : Object
    {
        // ── Original Methods ──
        public void Internal_Log(){} // RVA: 0x7ffaaf2812b0
        public void Internal_LogException(){} // RVA: 0x7ffaaf281330
        public void LogFormat(){} // RVA: 0x7ffaaf281480
        public void LogFormat(){} // RVA: 0x7ffaaf281480
        public void LogException(){} // RVA: 0x7ffaaf281580
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class DefaultExecutionOrder : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa89350c0
        public void get_order(){} // RVA: 0x7ffaaf273c40
    }

    public class DetailPrototype : Object
    {
        public object m_Prototype; // 0x32E72300
        public object m_DryColor; // 0x32E72300
        public object m_MinHeight; // 0x32E72300
        public object m_NoiseSpread; // 0x32E72300
        public object m_RenderMode; // 0x32E72300
        public object m_UseDensityScaling; // 0x32E72300
        public object m_TargetCoverage; // 0x32E72300

        // ── Original Methods ──
        public void get_prototype(){} // RVA: 0x7ffaab6f26c0
        public void .ctor(){} // RVA: 0x7ffaaf417da0
        public void Equals(){} // RVA: 0x7ffaaf417f70
        public void Equals(){} // RVA: 0x7ffaaf417f70
        public void .cctor(){} // RVA: 0x7ffaaf418370
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf2e7c30
    }

    public class DisallowMultipleComponent : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class Display : Object
    {
        public object _mainDisplay; // 0x32CA30D0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9e463c0
        public void .ctor(){} // RVA: 0x7ffaa9e463c0
        public void get_renderingWidth(){} // RVA: 0x7ffaaf28d310
        public void get_renderingHeight(){} // RVA: 0x7ffaaf28d3b0
        public void get_systemWidth(){} // RVA: 0x7ffaaf28d450
        public void get_systemHeight(){} // RVA: 0x7ffaaf28d4f0
        public void get_colorBuffer(){} // RVA: 0x7ffaaf28d590
        public void RelativeMouseAt(){} // RVA: 0x7ffaaf28d650
        public void get_main(){} // RVA: 0x7ffaaf28d740
        public void RecreateDisplayList(){} // RVA: 0x7ffaaf28d7a0
        public void FireDisplaysUpdated(){} // RVA: 0x7ffaaf28da50
        public void RelativeMouseAtImpl(){} // RVA: 0x7ffaaf28dc40
        public void .cctor(){} // RVA: 0x7ffaaf28dcc0
        // ── Binary Analysis Named ──
        public void GetSystemExtImpl(){} // RVA: 0x7ffaaf28daf0
        public void GetRenderingExtImpl(){} // RVA: 0x7ffaaf28db60
        public void GetRenderingBuffersImpl(){} // RVA: 0x7ffaaf28dbd0
    }

    public class DistanceJoint2D : AnchoredJoint2D
    {
        // ── Original Methods ──
        public void get_autoConfigureDistance(){} // RVA: 0x7ffaaf3a5610
        public void set_autoConfigureDistance(){} // RVA: 0x7ffaaf3a5660
        public void get_distance(){} // RVA: 0x7ffaaf3a56c0
        public void set_distance(){} // RVA: 0x7ffaaf3a5710
        public void get_maxDistanceOnly(){} // RVA: 0x7ffaaf3a5770
        public void set_maxDistanceOnly(){} // RVA: 0x7ffaaf3a57c0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class DrivenRectTransformTracker : ValueType
    {
        // ── Original Methods ──
        public void Add(){} // RVA: 0x7ffaa8932310
        public void Clear(){} // RVA: 0x7ffaa8932310
    }

}