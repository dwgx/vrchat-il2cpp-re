// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 3
// Methods: 20

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class RareData : ValueType
    {
        public UnityEngine.UIElements.Cursor cursor; // 0x10
        public 0x66482970 textOverflow; // 0x28
        public UnityEngine.Color unityBackgroundImageTintColor; // 0x2C
        public 0x66482760 unityOverflowClipBox; // 0x3C
        public int unitySliceBottom; // 0x40
        public int unitySliceLeft; // 0x44
        public int unitySliceRight; // 0x48
        public float unitySliceScale; // 0x4C
        public int unitySliceTop; // 0x50
        public 0x66482918 unityTextOverflowPosition; // 0x54

        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFD550195D0
        public void CopyFrom(){} // RVA: 0x7FFD53037AB0
        public void op_Equality(){} // RVA: 0x7FFD55019600
        public void Equals(){} // RVA: 0x7FFD55019920 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD55019A30
    }

    public class Rotate : ValueType
    {
        public UnityEngine.UIElements.Angle angle; // 0x10
        public UnityEngine.Vector3 axis; // 0x18
        public bool m_IsNone; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5501CE00
        public void Initial(){} // RVA: 0x7FFD5501CE60
        public void None(){} // RVA: 0x7FFD5501CF00
        public void get_angle(){} // RVA: 0x7FFD4EEF9F60
        public void set_angle(){} // RVA: 0x7FFD4F9DB120
        public void get_axis(){} // RVA: 0x7FFD51515A40
        public void op_Equality(){} // RVA: 0x7FFD5501CFD0
        public void op_Inequality(){} // RVA: 0x7FFD5501D0D0
        public void Equals(){} // RVA: 0x7FFD5501D170 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD5501D230
        public void ToString(){} // RVA: 0x7FFD5501D320
        public void ToQuaternion(){} // RVA: 0x7FFD5501D390
    }

    public class RuleMatcher : ValueType
    {
        public UnityEngine.UIElements.StyleSheet sheet; // 0x10
        public 0x664838E8 complexSelector; // 0x18

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD55044120
    }

}