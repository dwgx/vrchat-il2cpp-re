// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Experimental.GlobalIllumination
// Classes: 6
// Methods: 50

namespace ThirdParty.Unity.UnityEngine.Experimental.GlobalIllumination
{
    public class LightDataGI : ValueType
    {
        public object instanceID;
        public object cookieID;
        public object cookieScale;
        public object color;
        public object indirectColor;
        public object orientation;
        public object position;
        public object range;
        public object coneAngle;
        public object innerConeAngle;
        public object shape0;
        public object shape1;
        public object type;
        public object mode;
        public object shadow;
        public object falloff;

        // ── Methods ──
        public void Init(){} // RVA: 0x96D430
        public void InitNoBake(){} // RVA: 0x96D4B0
    }

    public class LightDataGI[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7F930
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B050
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4EE0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E35750
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B050
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class LightmapperUtils : Object
    {
        // ── Methods ──
        public void Extract(){} // RVA: 0x7C4EB80
        public void ExtractIndirect(){} // RVA: 0x7C4CAC0
        public void ExtractInnerCone(){} // RVA: 0x7C4CCB0
        public void ExtractColorTemperature(){} // RVA: 0x7C4CD80
        public void ApplyColorTemperature(){} // RVA: 0x7C4CF40
    }

    public class Lightmapping : Object
    {
        public object s_DefaultDelegate;
        public object s_RequestLightsDelegate;

        // ── Methods ──
        public void SetDelegate(){} // RVA: 0x7C4EE10
        public void GetDelegate(){} // RVA: 0x7C4EEF0
        public void ResetDelegate(){} // RVA: 0x7C4EF50
        public void RequestLights(){} // RVA: 0x7C4F000
        public void .cctor(){} // RVA: 0x7C4F0D0
    }

    public class Lightmapping[] : Array
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

    public class LinearColor : ValueType
    {
        public object m_red;
        public object m_green;
        public object m_blue;
        public object m_intensity;

        // ── Methods ──
        public void get_red(){} // RVA: 0x459690
        public void set_red(){} // RVA: 0x96CEB0
        public void get_green(){} // RVA: 0x958940
        public void set_green(){} // RVA: 0x96CEC0
        public void get_blue(){} // RVA: 0x958950
        public void set_blue(){} // RVA: 0x96CED0
        public void Convert(){} // RVA: 0x7C4C490
        public void Black(){} // RVA: 0x7C4C810
    }

}