// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 8
// Methods: 77

namespace ThirdParty.Unity.UnityEngine
{
    public class Debug : Object
    {
        public UnityEngine.ILogger s_DefaultLogger;
        public UnityEngine.ILogger s_Logger; // 0x8

        // ── Methods ──
        public void get_unityLogger(){} // RVA: 0x7FFE87C07C20
        public void DrawLine(){} // RVA: 0x7FFE87C07FF0 | overloaded x4
        public void DrawRay(){} // RVA: 0x7FFE87C082F0 | overloaded x4
        public void Break(){} // RVA: 0x7FFE87C08480
        public void DebugBreak(){} // RVA: 0x7FFE87C084D0
        public void ExtractStackTraceNoAlloc(){} // RVA: 0x7FFE87C08520
        public void Log(){} // RVA: 0x7FFE87C08660 | overloaded x2
        public void LogFormat(){} // RVA: 0x7FFE87C088E0 | overloaded x3
        public void LogError(){} // RVA: 0x7FFE87C08C20 | overloaded x2
        public void LogErrorFormat(){} // RVA: 0x7FFE87C08DC0 | overloaded x2
        public void LogException(){} // RVA: 0x7FFE87C08F60 | overloaded x2
        public void LogWarning(){} // RVA: 0x7FFE87C09100 | overloaded x2
        public void LogWarningFormat(){} // RVA: 0x7FFE87C092A0 | overloaded x2
        public void Assert(){} // RVA: 0x7FFE87C09430 | overloaded x2
        public void LogAssertion(){} // RVA: 0x7FFE87C094D0
        public void LogAssertionFormat(){} // RVA: 0x7FFE87C095A0
        public void get_isDebugBuild(){} // RVA: 0x7FFE87C09670
        public void CallOverridenDebugHandler(){} // RVA: 0x7FFE87C096C0
        public void IsLoggingEnabled(){} // RVA: 0x7FFE87C09920
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE87C09A70
        public void DrawLine_Injected(){} // RVA: 0x7FFE87C09C10
    }

    public class DebugLogHandler : Object
    {
        // ── Methods ──
        public void Internal_Log(){} // RVA: 0x7FFE87C078A0
        public void Internal_LogException(){} // RVA: 0x7FFE87C07920
        public void LogFormat(){} // RVA: 0x7FFE87C07A70 | overloaded x2
        public void LogException(){} // RVA: 0x7FFE87C07B70
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DefaultExecutionOrder : Attribute
    {
        public int m_Order; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void get_order(){} // RVA: 0x7FFE87BFA280
    }

    public class DetailPrototype : Object
    {
        public UnityEngine.Color DefaultHealthColor;

        // ── Methods ──
        public void get_prototype(){} // RVA: 0x7FFE84022BE0
        public void .ctor(){} // RVA: 0x7FFE87D9E6E0
        public void Equals(){} // RVA: 0x7FFE87D9E8B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87C6E400
        public void .cctor(){} // RVA: 0x7FFE87D9ECB0
    }

    public class DisallowMultipleComponent : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Display : Object
    {
        public UIntPtr nativeDisplay; // 0x10
        public UnityEngine.Display[] displays;
        public UnityEngine.Display _mainDisplay; // 0x8
        public int m_ActiveEditorGameViewTarget; // 0x10
        public DisplaysUpdatedDelegate onDisplaysUpdated; // 0x18
        public object field_5;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE826F2ED0 | overloaded x2
        public void get_renderingWidth(){} // RVA: 0x7FFE87C13900
        public void get_renderingHeight(){} // RVA: 0x7FFE87C139A0
        public void get_systemWidth(){} // RVA: 0x7FFE87C13A40
        public void get_systemHeight(){} // RVA: 0x7FFE87C13AE0
        public void get_colorBuffer(){} // RVA: 0x7FFE87C13B80
        public void RelativeMouseAt(){} // RVA: 0x7FFE87C13C40
        public void get_main(){} // RVA: 0x7FFE87C13D30
        public void RecreateDisplayList(){} // RVA: 0x7FFE87C13D90
        public void FireDisplaysUpdated(){} // RVA: 0x7FFE87C14040
        public void GetSystemExtImpl(){} // RVA: 0x7FFE87C140E0
        public void GetRenderingExtImpl(){} // RVA: 0x7FFE87C14150
        public void GetRenderingBuffersImpl(){} // RVA: 0x7FFE87C141C0
        public void RelativeMouseAtImpl(){} // RVA: 0x7FFE87C14230
        public void .cctor(){} // RVA: 0x7FFE87C142B0
    }

    public class DistanceJoint2D : AnchoredJoint2D
    {
        // ── Methods ──
        public void get_autoConfigureDistance(){} // RVA: 0x7FFE87D2BF50
        public void set_autoConfigureDistance(){} // RVA: 0x7FFE87D2BFA0
        public void get_distance(){} // RVA: 0x7FFE87D2C000
        public void set_distance(){} // RVA: 0x7FFE87D2C050
        public void get_maxDistanceOnly(){} // RVA: 0x7FFE87D2C0B0
        public void set_maxDistanceOnly(){} // RVA: 0x7FFE87D2C100
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class DrivenRectTransformTracker : ValueType
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE810FB310
        public void Clear(){} // RVA: 0x7FFE810FB310
    }

}