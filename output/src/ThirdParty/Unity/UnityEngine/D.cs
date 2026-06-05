// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 9
// Methods: 78

namespace ThirdParty.Unity.UnityEngine
{
    public class Debug
    {
        public object order;

        // ── Methods ──
        public void get_unityLogger(){} // RVA: 0x7FFAF9B76D00
        public void DrawLine(){} // RVA: 0x7FFAF9B770D0 | overloaded x4
        public void DrawRay(){} // RVA: 0x7FFAF9B773D0 | overloaded x4
        public void Break(){} // RVA: 0x7FFAF9B77560
        public void DebugBreak(){} // RVA: 0x7FFAF9B775B0
        public void ExtractStackTraceNoAlloc(){} // RVA: 0x7FFAF9B77600
        public void Log(){} // RVA: 0x7FFAF9B77740 | overloaded x2
        public void LogFormat(){} // RVA: 0x7FFAF9B779C0 | overloaded x3
        public void LogError(){} // RVA: 0x7FFAF9B77D00 | overloaded x2
        public void LogErrorFormat(){} // RVA: 0x7FFAF9B77EA0 | overloaded x2
        public void LogException(){} // RVA: 0x7FFAF9B78040 | overloaded x2
        public void LogWarning(){} // RVA: 0x7FFAF9B781E0 | overloaded x2
        public void LogWarningFormat(){} // RVA: 0x7FFAF9B78380 | overloaded x2
        public void Assert(){} // RVA: 0x7FFAF9B78510 | overloaded x2
        public void LogAssertion(){} // RVA: 0x7FFAF9B785B0
        public void LogAssertionFormat(){} // RVA: 0x7FFAF9B78680
        public void get_isDebugBuild(){} // RVA: 0x7FFAF9B78750
        public void CallOverridenDebugHandler(){} // RVA: 0x7FFAF9B787A0
        public void IsLoggingEnabled(){} // RVA: 0x7FFAF9B78A00
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF9B78B50
        public void DrawLine_Injected(){} // RVA: 0x7FFAF9B78CF0
    }

    public class DebugLogHandler : Internal_Log
    {
        // ── Methods ──
        public void Internal_Log(){} // RVA: 0x7FFAF9B76980
        public void Internal_LogException(){} // RVA: 0x7FFAF9B76A00
        public void LogFormat(){} // RVA: 0x7FFAF9B76B50 | overloaded x2
        public void LogException(){} // RVA: 0x7FFAF9B76C50
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DefaultExecutionOrder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
        public void get_order(){} // RVA: 0x7FFAF9B692A0
    }

    public class DetailPrototype
    {
        // ── Methods ──
        public void get_prototype(){} // RVA: 0x7FFAF5E66D40
        public void .ctor(){} // RVA: 0x7FFAF9D0E540
        public void Equals(){} // RVA: 0x7FFAF9D0E710 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF9BDD740
        public void .cctor(){} // RVA: 0x7FFAF9D0EB10
    }

    public class DisallowMultipleComponent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Display
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4417700 | overloaded x2
        public void get_renderingWidth(){} // RVA: 0x7FFAF9B82A30
        public void get_renderingHeight(){} // RVA: 0x7FFAF9B82AD0
        public void get_systemWidth(){} // RVA: 0x7FFAF9B82B70
        public void get_systemHeight(){} // RVA: 0x7FFAF9B82C10
        public void get_colorBuffer(){} // RVA: 0x7FFAF9B82CB0
        public void RelativeMouseAt(){} // RVA: 0x7FFAF9B82D70
        public void get_main(){} // RVA: 0x7FFAF9B82E60
        public void RecreateDisplayList(){} // RVA: 0x7FFAF9B82EC0
        public void FireDisplaysUpdated(){} // RVA: 0x7FFAF9B83170
        public void GetSystemExtImpl(){} // RVA: 0x7FFAF9B83210
        public void GetRenderingExtImpl(){} // RVA: 0x7FFAF9B83280
        public void GetRenderingBuffersImpl(){} // RVA: 0x7FFAF9B832F0
        public void RelativeMouseAtImpl(){} // RVA: 0x7FFAF9B83360
        public void .cctor(){} // RVA: 0x7FFAF9B833E0
    }

    public class DistanceJoint2D
    {
        public object dampingRatio;
        public object frequency;
        public object referenceAngle;

        // ── Methods ──
        public void get_autoConfigureDistance(){} // RVA: 0x7FFAF9C9BDB0
        public void set_autoConfigureDistance(){} // RVA: 0x7FFAF9C9BE00
        public void get_distance(){} // RVA: 0x7FFAF9C9BE60
        public void set_distance(){} // RVA: 0x7FFAF9C9BEB0
        public void get_maxDistanceOnly(){} // RVA: 0x7FFAF9C9BF10
        public void set_maxDistanceOnly(){} // RVA: 0x7FFAF9C9BF60
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class DrivenRectTransformTracker
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAF2D8D310
        public void Clear(){} // RVA: 0x7FFAF2D8D310
    }

    public class DynamicGI
    {
        // ── Methods ──
        public void UpdateEnvironment(){} // RVA: 0x7FFAF9B7FDF0
    }

}