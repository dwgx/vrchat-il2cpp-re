// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Drawing
// Classes: 8
// Methods: 65

namespace ThirdParty.DotNet.System.Drawing
{
    public class Color : ValueType
    {
        public string name; // 0x10
        public long value; // 0x18
        public short knownColor; // 0x20
        public short state; // 0x22
        public object field_4; // 0x1
        public object field_5; // 0x2
        public object field_6; // 0x3

        // ── Methods ──
        public void get_R(){} // RVA: 0x7FFE87320C20
        public void get_G(){} // RVA: 0x7FFE87320C40
        public void get_B(){} // RVA: 0x7FFE87320C60
        public void get_A(){} // RVA: 0x7FFE87320C70
        public void get_IsKnownColor(){} // RVA: 0x7FFE87320C90
        public void get_Name(){} // RVA: 0x7FFE87320CA0
        public void get_Value(){} // RVA: 0x7FFE87320DC0
        public void ToString(){} // RVA: 0x7FFE87320E90
        public void op_Equality(){} // RVA: 0x7FFE873210D0
        public void Equals(){} // RVA: 0x7FFE87321220 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE873212F0
    }

    public class KnownColorTable : Object
    {
        // ── Methods ──
        public void EnsureColorTable(){} // RVA: 0x7FFE8731E180
        public void InitColorTable(){} // RVA: 0x7FFE8731E1D0
        public void EnsureColorNameTable(){} // RVA: 0x7FFE8731EE30
        public void InitColorNameTable(){} // RVA: 0x7FFE8731EE80
        public void KnownColorToArgb(){} // RVA: 0x7FFE87320870
        public void KnownColorToName(){} // RVA: 0x7FFE87320910
        public void UpdateSystemColors(){} // RVA: 0x7FFE873209B0
    }

    public class Point : ValueType
    {
        public int x; // 0x10
        public int y; // 0x14

        // ── Methods ──
        public void get_X(){} // RVA: 0x7FFE826F4220
        public void get_Y(){} // RVA: 0x7FFE826F42A0
        public void op_Equality(){} // RVA: 0x7FFE873213D0
        public void Equals(){} // RVA: 0x7FFE87321490 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE873214B0
        public void ToString(){} // RVA: 0x7FFE87321520
    }

    public class PointF : ValueType
    {
        public float x; // 0x10
        public float y; // 0x14

        // ── Methods ──
        public void get_X(){} // RVA: 0x7FFE82AB44F0
        public void get_Y(){} // RVA: 0x7FFE82D03B70
        public void op_Equality(){} // RVA: 0x7FFE87321720
        public void Equals(){} // RVA: 0x7FFE87321800 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87321830
        public void ToString(){} // RVA: 0x7FFE873218C0
    }

    public class Rectangle : ValueType
    {
        public int x; // 0x10
        public int y; // 0x14
        public int width; // 0x18
        public int height; // 0x1C

        // ── Methods ──
        public void get_X(){} // RVA: 0x7FFE826F4220
        public void get_Y(){} // RVA: 0x7FFE826F42A0
        public void get_Width(){} // RVA: 0x7FFE82C33000
        public void get_Height(){} // RVA: 0x7FFE82C33020
        public void Equals(){} // RVA: 0x7FFE87321A90 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE869D6A20
        public void GetHashCode(){} // RVA: 0x7FFE87321AE0
        public void ToString(){} // RVA: 0x7FFE87321B70
    }

    public class RectangleF : ValueType
    {
        public float x; // 0x10
        public float y; // 0x14
        public float width; // 0x18
        public float height; // 0x1C

        // ── Methods ──
        public void get_X(){} // RVA: 0x7FFE82AB44F0
        public void get_Y(){} // RVA: 0x7FFE82D03B70
        public void get_Width(){} // RVA: 0x7FFE82D03B90
        public void get_Height(){} // RVA: 0x7FFE82D03BA0
        public void Equals(){} // RVA: 0x7FFE87321FA0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE87321FF0
        public void GetHashCode(){} // RVA: 0x7FFE87322030
        public void ToString(){} // RVA: 0x7FFE87322120
    }

    public class Size : ValueType
    {
        public int width; // 0x10
        public int height; // 0x14

        // ── Methods ──
        public void op_Equality(){} // RVA: 0x7FFE873213D0
        public void get_Width(){} // RVA: 0x7FFE826F4220
        public void get_Height(){} // RVA: 0x7FFE826F42A0
        public void Equals(){} // RVA: 0x7FFE87321490 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87322490
        public void ToString(){} // RVA: 0x7FFE87322500
    }

    public class SizeF : ValueType
    {
        public float width; // 0x10
        public float height; // 0x14

        // ── Methods ──
        public void op_Equality(){} // RVA: 0x7FFE87321720
        public void get_Width(){} // RVA: 0x7FFE82AB44F0
        public void get_Height(){} // RVA: 0x7FFE82D03B70
        public void Equals(){} // RVA: 0x7FFE87321800 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE873226B0
        public void ToString(){} // RVA: 0x7FFE87322740
    }

}