// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 8
// Methods: 77

namespace ThirdParty.Unity.UnityEngine
{
    public class Debug : Object
    {
        public UnityEngine.ILogger unityLogger;
        public UnityEngine.ILogger isDebugBuild; // 0x8

        // ── Methods ──
        public void get_unityLogger(){} // RVA: 0x7FFD54C7F6D0
        public void DrawLine(){} // RVA: 0x7FFD54C7FAA0 | overloaded x4
        public void DrawRay(){} // RVA: 0x7FFD54C7FDA0 | overloaded x4
        public void Break(){} // RVA: 0x7FFD54C7FF30
        public void DebugBreak(){} // RVA: 0x7FFD54C7FF80
        public void ExtractStackTraceNoAlloc(){} // RVA: 0x7FFD54C7FFD0
        public void Log(){} // RVA: 0x7FFD54C80110 | overloaded x2
        public void LogFormat(){} // RVA: 0x7FFD54C80390 | overloaded x3
        public void LogError(){} // RVA: 0x7FFD54C806D0 | overloaded x2
        public void LogErrorFormat(){} // RVA: 0x7FFD54C80870 | overloaded x2
        public void LogException(){} // RVA: 0x7FFD54C80A10 | overloaded x2
        public void LogWarning(){} // RVA: 0x7FFD54C80BB0 | overloaded x2
        public void LogWarningFormat(){} // RVA: 0x7FFD54C80D50 | overloaded x2
        public void Assert(){} // RVA: 0x7FFD54C80EE0 | overloaded x2
        public void LogAssertion(){} // RVA: 0x7FFD54C80F80
        public void LogAssertionFormat(){} // RVA: 0x7FFD54C81050
        public void get_isDebugBuild(){} // RVA: 0x7FFD54C81120
        public void CallOverridenDebugHandler(){} // RVA: 0x7FFD54C81170
        public void IsLoggingEnabled(){} // RVA: 0x7FFD54C813D0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD54C81520
        public void DrawLine_Injected(){} // RVA: 0x7FFD54C816C0
    }

    public class DebugLogHandler : Object
    {
        // ── Methods ──
        public void Internal_Log(){} // RVA: 0x7FFD54C7F350
        public void Internal_LogException(){} // RVA: 0x7FFD54C7F3D0
        public void LogFormat(){} // RVA: 0x7FFD54C7F520 | overloaded x2
        public void LogException(){} // RVA: 0x7FFD54C7F620
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class DefaultExecutionOrder : Attribute
    {
        public int order; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E3440C0
        public void get_order(){} // RVA: 0x7FFD54C71CE0
    }

    public class DetailPrototype : Object
    {
        public UnityEngine.Color prototype;
        public UnityEngine.Color DefaultDryColor; // 0x10
        public UnityEngine.GameObject m_Prototype; // 0x10
        public UnityEngine.Texture2D m_PrototypeTexture; // 0x18
        public UnityEngine.Color m_HealthyColor; // 0x20
        public UnityEngine.Color m_DryColor; // 0x30
        public float m_MinWidth; // 0x40
        public float m_MaxWidth; // 0x44
        public float m_MinHeight; // 0x48
        public float m_MaxHeight; // 0x4C
        public int m_NoiseSeed; // 0x50
        public float m_NoiseSpread; // 0x54
        public float m_Density; // 0x58
        public float m_HoleEdgePadding; // 0x5C
        public int m_RenderMode; // 0x60
        public int m_UsePrototypeMesh; // 0x64
        public int m_UseInstancing; // 0x68
        public int m_UseDensityScaling; // 0x6C
        public float m_AlignToGround; // 0x70
        public float m_PositionJitter; // 0x74
        public float m_TargetCoverage; // 0x78

        // ── Methods ──
        public void get_prototype(){} // RVA: 0x7FFD510E4750
        public void .ctor(){} // RVA: 0x7FFD54E15E40
        public void Equals(){} // RVA: 0x7FFD54E16010 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54CE5CD0
        public void .cctor(){} // RVA: 0x7FFD54E16410
    }

    public class DisallowMultipleComponent : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class Display : Object
    {
        public UIntPtr renderingWidth; // 0x10
        public UnityEngine.Display[] renderingHeight;
        public UnityEngine.Display systemWidth; // 0x8
        public int systemHeight; // 0x10
        public DisplaysUpdatedDelegate colorBuffer; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F83EFB0 | overloaded x2
        public void get_renderingWidth(){} // RVA: 0x7FFD54C8B3B0
        public void get_renderingHeight(){} // RVA: 0x7FFD54C8B450
        public void get_systemWidth(){} // RVA: 0x7FFD54C8B4F0
        public void get_systemHeight(){} // RVA: 0x7FFD54C8B590
        public void get_colorBuffer(){} // RVA: 0x7FFD54C8B630
        public void RelativeMouseAt(){} // RVA: 0x7FFD54C8B6F0
        public void get_main(){} // RVA: 0x7FFD54C8B7E0
        public void RecreateDisplayList(){} // RVA: 0x7FFD54C8B840
        public void FireDisplaysUpdated(){} // RVA: 0x7FFD54C8BAF0
        public void GetSystemExtImpl(){} // RVA: 0x7FFD54C8BB90
        public void GetRenderingExtImpl(){} // RVA: 0x7FFD54C8BC00
        public void GetRenderingBuffersImpl(){} // RVA: 0x7FFD54C8BC70
        public void RelativeMouseAtImpl(){} // RVA: 0x7FFD54C8BCE0
        public void .cctor(){} // RVA: 0x7FFD54C8BD60
    }

    public class DistanceJoint2D : AnchoredJoint2D
    {
        public object autoConfigureDistance;
        public object distance;
        public object maxDistanceOnly;

        // ── Methods ──
        public void get_autoConfigureDistance(){} // RVA: 0x7FFD54DA36B0
        public void set_autoConfigureDistance(){} // RVA: 0x7FFD54DA3700
        public void get_distance(){} // RVA: 0x7FFD54DA3760
        public void set_distance(){} // RVA: 0x7FFD54DA37B0
        public void get_maxDistanceOnly(){} // RVA: 0x7FFD54DA3810
        public void set_maxDistanceOnly(){} // RVA: 0x7FFD54DA3860
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class DrivenRectTransformTracker : ValueType
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD4E341310
        public void Clear(){} // RVA: 0x7FFD4E341310
    }

}