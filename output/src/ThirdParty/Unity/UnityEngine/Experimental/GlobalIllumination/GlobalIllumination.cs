// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Experimental.GlobalIllumination
// Classes: 10
// Methods: 30

namespace ThirdParty.Unity.UnityEngine.Experimental.GlobalIllumination
{
    public class Cookie : ValueType
    {
    }

    public class DirectionalLight : ValueType
    {
    }

    public class DiscLight : ValueType
    {
    }

    public class LightDataGI : ValueType
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE87CA5AD0 | overloaded x5
        public void InitNoBake(){} // RVA: 0x7FFE87CA5B40
    }

    public class LightmapperUtils : Object
    {
        // ── Methods ──
        public void Extract(){} // RVA: 0x7FFE87CA7150 | overloaded x7
        public void ExtractIndirect(){} // RVA: 0x7FFE87CA5B70
        public void ExtractInnerCone(){} // RVA: 0x7FFE87CA5CB0
        public void ExtractColorTemperature(){} // RVA: 0x7FFE87CA5D40
        public void ApplyColorTemperature(){} // RVA: 0x7FFE87CA5EC0
    }

    public class Lightmapping : Object
    {
        // ── Methods ──
        public void SetDelegate(){} // RVA: 0x7FFE87CA74D0
        public void GetDelegate(){} // RVA: 0x7FFE87CA75B0
        public void ResetDelegate(){} // RVA: 0x7FFE87CA7610
        public void RequestLights(){} // RVA: 0x7FFE87CA76C0
        public void .cctor(){} // RVA: 0x7FFE87CA7790
    }

    public class LinearColor : ValueType
    {
        public float m_red; // 0x10
        public float m_green; // 0x14
        public float m_blue; // 0x18

        // ── Methods ──
        public void get_red(){} // RVA: 0x7FFE8111ED20
        public void set_red(){} // RVA: 0x7FFE87CA5340
        public void get_green(){} // RVA: 0x7FFE8111ED30
        public void set_green(){} // RVA: 0x7FFE87CA5400
        public void get_blue(){} // RVA: 0x7FFE8111ECF0
        public void set_blue(){} // RVA: 0x7FFE87CA54C0
        public void Convert(){} // RVA: 0x7FFE87CA5580
        public void Black(){} // RVA: 0x7FFE87CA58C0
    }

    public class PointLight : ValueType
    {
    }

    public class RectangleLight : ValueType
    {
    }

    public class SpotLight : ValueType
    {
    }

}