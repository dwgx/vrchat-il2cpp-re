// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Experimental.GlobalIllumination
// Classes: 10
// Methods: 30

namespace ThirdParty.Unity.UnityEngine.Experimental.GlobalIllumination
{
    public class Cookie : ValueType
    {
        public int instanceID; // 0x10
        public float scale; // 0x14
        public UnityEngine.Vector2 sizes; // 0x18
    }

    public class DirectionalLight : ValueType
    {
        public int instanceID; // 0x10
        public bool shadow; // 0x14
        public 0x6B188D58 mode; // 0x15
        public UnityEngine.Vector3 position; // 0x18
        public UnityEngine.Quaternion orientation; // 0x24
        public UnityEngine.Experimental.GlobalIllumination.LinearColor color; // 0x34
        public UnityEngine.Experimental.GlobalIllumination.LinearColor indirectColor; // 0x44
        public float penumbraWidthRadian; // 0x54
        public UnityEngine.Vector3 direction; // 0x58
    }

    public class DiscLight : ValueType
    {
        public int instanceID; // 0x10
        public bool shadow; // 0x14
        public 0x6B188D58 mode; // 0x15
        public UnityEngine.Vector3 position; // 0x18
        public UnityEngine.Quaternion orientation; // 0x24
        public UnityEngine.Experimental.GlobalIllumination.LinearColor color; // 0x34
        public UnityEngine.Experimental.GlobalIllumination.LinearColor indirectColor; // 0x44
        public float range; // 0x54
        public float radius; // 0x58
        public 0x6B188DB0 falloff; // 0x5C
    }

    public class LightDataGI : ValueType
    {
        public int instanceID; // 0x10
        public int cookieID; // 0x14
        public float cookieScale; // 0x18
        public UnityEngine.Experimental.GlobalIllumination.LinearColor color; // 0x1C
        public UnityEngine.Experimental.GlobalIllumination.LinearColor indirectColor; // 0x2C
        public UnityEngine.Quaternion orientation; // 0x3C
        public UnityEngine.Vector3 position; // 0x4C
        public float range; // 0x58
        public float coneAngle; // 0x5C
        public float innerConeAngle; // 0x60
        public float shape0; // 0x64
        public float shape1; // 0x68
        public 0x6B188D00 type; // 0x6C
        public 0x6B188D58 mode; // 0x6D
        public byte shadow; // 0x6E
        public 0x6B188DB0 falloff; // 0x6F

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC98FD230 | overloaded x5
        public void InitNoBake(){} // RVA: 0x7FFAC98FD2A0
    }

    public class LightmapperUtils : Object
    {
        // ── Methods ──
        public void Extract(){} // RVA: 0x7FFAC98FE8B0 | overloaded x7
        public void ExtractIndirect(){} // RVA: 0x7FFAC98FD2D0
        public void ExtractInnerCone(){} // RVA: 0x7FFAC98FD410
        public void ExtractColorTemperature(){} // RVA: 0x7FFAC98FD4A0
        public void ApplyColorTemperature(){} // RVA: 0x7FFAC98FD620
    }

    public class Lightmapping : Object
    {
        public RequestLightsDelegate s_DefaultDelegate;
        public RequestLightsDelegate s_RequestLightsDelegate; // 0x8

        // ── Methods ──
        public void SetDelegate(){} // RVA: 0x7FFAC98FEC30
        public void GetDelegate(){} // RVA: 0x7FFAC98FED10
        public void ResetDelegate(){} // RVA: 0x7FFAC98FED70
        public void RequestLights(){} // RVA: 0x7FFAC98FEE20
        public void .cctor(){} // RVA: 0x7FFAC98FEEF0
    }

    public class LinearColor : ValueType
    {
        public float red; // 0x10
        public float green; // 0x14
        public float blue; // 0x18
        public float m_intensity; // 0x1C

        // ── Methods ──
        public void get_red(){} // RVA: 0x7FFAC2F44D20
        public void set_red(){} // RVA: 0x7FFAC98FCAA0
        public void get_green(){} // RVA: 0x7FFAC2F44D30
        public void set_green(){} // RVA: 0x7FFAC98FCB60
        public void get_blue(){} // RVA: 0x7FFAC2F44CF0
        public void set_blue(){} // RVA: 0x7FFAC98FCC20
        public void Convert(){} // RVA: 0x7FFAC98FCCE0
        public void Black(){} // RVA: 0x7FFAC98FD020
    }

    public class PointLight : ValueType
    {
        public int instanceID; // 0x10
        public bool shadow; // 0x14
        public 0x6B188D58 mode; // 0x15
        public UnityEngine.Vector3 position; // 0x18
        public UnityEngine.Quaternion orientation; // 0x24
        public UnityEngine.Experimental.GlobalIllumination.LinearColor color; // 0x34
        public UnityEngine.Experimental.GlobalIllumination.LinearColor indirectColor; // 0x44
        public float range; // 0x54
        public float sphereRadius; // 0x58
        public 0x6B188DB0 falloff; // 0x5C
    }

    public class RectangleLight : ValueType
    {
        public int instanceID; // 0x10
        public bool shadow; // 0x14
        public 0x6B188D58 mode; // 0x15
        public UnityEngine.Vector3 position; // 0x18
        public UnityEngine.Quaternion orientation; // 0x24
        public UnityEngine.Experimental.GlobalIllumination.LinearColor color; // 0x34
        public UnityEngine.Experimental.GlobalIllumination.LinearColor indirectColor; // 0x44
        public float range; // 0x54
        public float width; // 0x58
        public float height; // 0x5C
        public 0x6B188DB0 falloff; // 0x60
    }

    public class SpotLight : ValueType
    {
        public int instanceID; // 0x10
        public bool shadow; // 0x14
        public 0x6B188D58 mode; // 0x15
        public UnityEngine.Vector3 position; // 0x18
        public UnityEngine.Quaternion orientation; // 0x24
        public UnityEngine.Experimental.GlobalIllumination.LinearColor color; // 0x34
        public UnityEngine.Experimental.GlobalIllumination.LinearColor indirectColor; // 0x44
        public float range; // 0x54
        public float sphereRadius; // 0x58
        public float coneAngle; // 0x5C
        public float innerConeAngle; // 0x60
        public 0x6B188DB0 falloff; // 0x64
        public 0x6B188E08 angularFalloff; // 0x65
    }

}