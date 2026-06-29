// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 14
// Methods: 144

namespace ThirdParty.Unity.UnityEngine
{
    public class Debug : Object
    {
        public object s_DefaultLogger;
        public object s_Logger;

        // ── Methods ──
        public void get_unityLogger(){} // RVA: 0x7B6B5E0
        public void DrawLine(){} // RVA: 0x7B6B9B0
        public void DrawRay(){} // RVA: 0x7B6BCB0
        public void Break(){} // RVA: 0x7B6BE40
        public void DebugBreak(){} // RVA: 0x7B6BE90
        public void ExtractStackTraceNoAlloc(){} // RVA: 0x7B6BEE0
        public void Log(){} // RVA: 0x7B6C130
        public void LogFormat(){} // RVA: 0x7B6C3B0
        public void LogError(){} // RVA: 0x7B6C6F0
        public void LogErrorFormat(){} // RVA: 0x7B6C890
        public void LogException(){} // RVA: 0x7B6CA30
        public void LogWarning(){} // RVA: 0x7B6CBD0
        public void LogWarningFormat(){} // RVA: 0x7B6CD70
        public void Assert(){} // RVA: 0x7B6CF00
        public void LogAssertion(){} // RVA: 0x7B6CFA0
        public void LogAssertionFormat(){} // RVA: 0x7B6D070
        public void get_isDebugBuild(){} // RVA: 0x7B6D140
        public void CallOverridenDebugHandler(){} // RVA: 0x7B6D190
        public void IsLoggingEnabled(){} // RVA: 0x7B6D3F0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x7B6D540
        public void DrawLine_Injected(){} // RVA: 0x7B6D6E0
        public void ExtractStackTraceNoAlloc_Injected(){} // RVA: 0x7B6D770
    }

    public class DebugLogHandler : Object
    {
        // ── Methods ──
        public void Internal_Log(){} // RVA: 0x7B6AFE0
        public void Internal_LogException(){} // RVA: 0x7B6B180
        public void LogFormat(){} // RVA: 0x7B6B310
        public void LogException(){} // RVA: 0x7B6B410
        public void .ctor(){} // RVA: 0xB43310
        public void Internal_Log_Injected(){} // RVA: 0x7B6B500
        public void Internal_LogException_Injected(){} // RVA: 0x7B6B580
    }

    public class Debug[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class DefaultExecutionOrder : Attribute
    {
        public object m_Order;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_order(){} // RVA: 0x7B51740
    }

    public class DefaultExecutionOrder[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class DetailPrototype : Object
    {
        public object DefaultHealthColor;
        public object DefaultDryColor;
        public object m_Prototype;
        public object m_PrototypeTexture;
        public object m_HealthyColor;
        public object m_DryColor;
        public object m_MinWidth;
        public object m_MaxWidth;
        public object m_MinHeight;
        public object m_MaxHeight;
        public object m_NoiseSeed;
        public object m_NoiseSpread;
        public object m_Density;
        public object m_HoleEdgePadding;
        public object m_RenderMode;
        public object m_UsePrototypeMesh;
        public object m_UseInstancing;
        public object m_UseDensityScaling;
        public object m_AlignToGround;
        public object m_PositionJitter;
        public object m_TargetCoverage;

        // ── Methods ──
        public void get_prototype(){} // RVA: 0x3E42230
        public void .ctor(){} // RVA: 0x7DB6030
        public void Equals(){} // RVA: 0x7DB6200
        public void GetHashCode(){} // RVA: 0x7C08E90
        public void .cctor(){} // RVA: 0x7DB65E0
    }

    public class DetailPrototype[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class DisallowMultipleComponent : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DisallowMultipleComponent[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Display : Object
    {
        public object nativeDisplay;
        public object displays;
        public object _mainDisplay;
        public object m_ActiveEditorGameViewTarget;
        public object onDisplaysUpdated;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2230E30
        public void get_renderingWidth(){} // RVA: 0x7B78F60
        public void get_renderingHeight(){} // RVA: 0x7B79000
        public void get_systemWidth(){} // RVA: 0x7B790A0
        public void get_systemHeight(){} // RVA: 0x7B79140
        public void get_colorBuffer(){} // RVA: 0x7B791E0
        public void RelativeMouseAt(){} // RVA: 0x7B792A0
        public void get_main(){} // RVA: 0x7B79390
        public void RecreateDisplayList(){} // RVA: 0x7B793F0
        public void FireDisplaysUpdated(){} // RVA: 0x7B796B0
        public void GetSystemExtImpl(){} // RVA: 0x7B79750
        public void GetRenderingExtImpl(){} // RVA: 0x7B797C0
        public void GetRenderingBuffersImpl(){} // RVA: 0x7B79830
        public void RelativeMouseAtImpl(){} // RVA: 0x7B798A0
        public void .cctor(){} // RVA: 0x7B79920
    }

    public class Display[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class DistanceJoint2D : AnchoredJoint2D
    {
        // ── Methods ──
        public void get_autoConfigureDistance(){} // RVA: 0x7D0CCF0
        public void set_autoConfigureDistance(){} // RVA: 0x7D0CD90
        public void get_distance(){} // RVA: 0x7D0CE40
        public void set_distance(){} // RVA: 0x7D0CEE0
        public void get_maxDistanceOnly(){} // RVA: 0x7D0CF90
        public void set_maxDistanceOnly(){} // RVA: 0x7D0D030
        public void .ctor(){} // RVA: 0xB43D60
        public void get_autoConfigureDistance_Injected(){} // RVA: 0x7D0D0E0
        public void set_autoConfigureDistance_Injected(){} // RVA: 0x7D0D130
        public void get_distance_Injected(){} // RVA: 0x7D0D190
        public void set_distance_Injected(){} // RVA: 0x7D0D1E0
        public void get_maxDistanceOnly_Injected(){} // RVA: 0x7D0D240
        public void set_maxDistanceOnly_Injected(){} // RVA: 0x7D0D290
    }

    public class DrivenRectTransformTracker : ValueType
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x3FC0
        public void Clear(){} // RVA: 0x3FC0
    }

    public class DynamicGI : Object
    {
        // ── Methods ──
        public void UpdateEnvironment(){} // RVA: 0x7B75CC0
    }

}