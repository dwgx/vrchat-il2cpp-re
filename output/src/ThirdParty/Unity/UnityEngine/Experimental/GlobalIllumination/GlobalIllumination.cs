// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Experimental.GlobalIllumination
// Classes: 3
// Methods: 19

namespace ThirdParty.Unity.UnityEngine.Experimental.GlobalIllumination
{
    public class LightDataGI : ValueType
    {
        public int instanceID; // 0x10
        public int cookieID; // 0x14
        public float cookieScale; // 0x18
        public eadedLoadingDebug.SkinnedClothBeginUpdate color; // 0x1C
        public eadedLoadingDebug.SkinnedClothBeginUpdate indirectColor; // 0x2C
        public R_12x12 orientation; // 0x3C
        public amut position; // 0x4C
        public float range; // 0x58
        public float coneAngle; // 0x5C
        public float innerConeAngle; // 0x60
        public float shape0; // 0x64
        public float shape1; // 0x68
        public eadedLoadingDebug.nNormal type; // 0x6C
        public eadedLoadingDebug.ameCenterCallbacks mode; // 0x6D
        public byte shadow; // 0x6E
        public eadedLoadingDebug.allbacks falloff; // 0x6F

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFD54D1D230 | overloaded x5
        public void InitNoBake(){} // RVA: 0x7FFD54D1D2A0
    }

    public class Lightmapping : Object
    {
        public llbackInternal s_DefaultDelegate;
        public llbackInternal s_RequestLightsDelegate; // 0x8

        // ── Methods ──
        public void SetDelegate(){} // RVA: 0x7FFD54D1EC30
        public void GetDelegate(){} // RVA: 0x7FFD54D1ED10
        public void ResetDelegate(){} // RVA: 0x7FFD54D1ED70
        public void RequestLights(){} // RVA: 0x7FFD54D1EE20
        public void .cctor(){} // RVA: 0x7FFD54D1EEF0
    }

    public class LinearColor : ValueType
    {
        public float red; // 0x10
        public float green; // 0x14
        public float blue; // 0x18
        public float m_intensity; // 0x1C

        // ── Methods ──
        public void get_red(){} // RVA: 0x7FFD4E364D20
        public void set_red(){} // RVA: 0x7FFD54D1CAA0
        public void get_green(){} // RVA: 0x7FFD4E364D30
        public void set_green(){} // RVA: 0x7FFD54D1CB60
        public void get_blue(){} // RVA: 0x7FFD4E364CF0
        public void set_blue(){} // RVA: 0x7FFD54D1CC20
        public void Convert(){} // RVA: 0x7FFD54D1CCE0
        public void Black(){} // RVA: 0x7FFD54D1D020
    }

}