// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 2
// Methods: 24

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class LayoutData : ValueType
    {
        public 0x66482868 alignContent; // 0x10
        public 0x66482868 alignItems; // 0x14
        public 0x66482868 alignSelf; // 0x18
        public float borderBottomWidth; // 0x1C
        public float borderLeftWidth; // 0x20
        public float borderRightWidth; // 0x24
        public float borderTopWidth; // 0x28
        public UnityEngine.UIElements.Length bottom; // 0x2C
        public r display; // 0x34
        public UnityEngine.UIElements.Length flexBasis; // 0x38
        public 0x664827B8 flexDirection; // 0x40
        public float flexGrow; // 0x44
        public float flexShrink; // 0x48
        public 0x66482810 flexWrap; // 0x4C
        public UnityEngine.UIElements.Length height; // 0x50
        public 0x664828C0 justifyContent; // 0x58
        public UnityEngine.UIElements.Length left; // 0x5C
        public UnityEngine.UIElements.Length marginBottom; // 0x64
        public UnityEngine.UIElements.Length marginLeft; // 0x6C
        public UnityEngine.UIElements.Length marginRight; // 0x74
        public UnityEngine.UIElements.Length marginTop; // 0x7C
        public UnityEngine.UIElements.Length maxHeight; // 0x84
        public UnityEngine.UIElements.Length maxWidth; // 0x8C
        public UnityEngine.UIElements.Length minHeight; // 0x94
        public UnityEngine.UIElements.Length minWidth; // 0x9C
        public UnityEngine.UIElements.Length paddingBottom; // 0xA4
        public UnityEngine.UIElements.Length paddingLeft; // 0xAC
        public UnityEngine.UIElements.Length paddingRight; // 0xB4
        public UnityEngine.UIElements.Length paddingTop; // 0xBC
        public 0x66482658 position; // 0xC4
        public UnityEngine.UIElements.Length right; // 0xC8
        public UnityEngine.UIElements.Length top; // 0xD0
        public UnityEngine.UIElements.Length width; // 0xD8

        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFD55016360
        public void CopyFrom(){} // RVA: 0x7FFD550163E0
        public void op_Equality(){} // RVA: 0x7FFD550164F0
        public void Equals(){} // RVA: 0x7FFD55019010 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD55019140
    }

    public class Length : ValueType
    {
        public float value;
        public float unit; // 0x10
        public 0x66481D10 m_Unit; // 0x14

        // ── Methods ──
        public void Percent(){} // RVA: 0x7FFD5501C9C0
        public void Auto(){} // RVA: 0x7FFD5501CA00
        public void None(){} // RVA: 0x7FFD5501CA20
        public void get_value(){} // RVA: 0x7FFD4FC6C150
        public void set_value(){} // RVA: 0x7FFD5501CA40
        public void get_unit(){} // RVA: 0x7FFD4F8402A0
        public void IsAuto(){} // RVA: 0x7FFD5501CA70
        public void IsNone(){} // RVA: 0x7FFD5501CA80
        public void .ctor(){} // RVA: 0x7FFD5501CAC0 | overloaded x3
        public void op_Implicit(){} // RVA: 0x7FFD5501CAF0
        public void op_Equality(){} // RVA: 0x7FFD54FF3800
        public void op_Inequality(){} // RVA: 0x7FFD5501CB30
        public void Equals(){} // RVA: 0x7FFD5501CB60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54FF3910
        public void ToString(){} // RVA: 0x7FFD5501CC10
    }

}