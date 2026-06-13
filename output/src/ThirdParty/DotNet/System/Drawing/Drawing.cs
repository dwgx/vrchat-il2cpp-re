// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Drawing
// Classes: 8
// Methods: 65

namespace ThirdParty.DotNet.System.Drawing
{
    public class Color
    {
        public string name; // 0x10
        public long value; // 0x18
        public short knownColor; // 0x20
        public short state; // 0x22

        // ── Methods ──
        public void get_R(){} // RVA: 0x67E1D20
        public void get_G(){} // RVA: 0x67E1D40
        public void get_B(){} // RVA: 0x67E1D60
        public void get_A(){} // RVA: 0x67E1D70
        public void get_IsKnownColor(){} // RVA: 0x67E1D90
        public void get_Name(){} // RVA: 0x67E1DA0
        public void get_Value(){} // RVA: 0x67E1EC0
        public void ToString(){} // RVA: 0x67E1F90
        public void op_Equality(){} // RVA: 0x67E21D0
        public void Equals(){} // RVA: 0x67E2320 | overloaded x2
        public void GetHashCode(){} // RVA: 0x67E23F0
    }

    public class KnownColorTable
    {
        // ── Methods ──
        public void EnsureColorTable(){} // RVA: 0x67DF280
        public void InitColorTable(){} // RVA: 0x67DF2D0
        public void EnsureColorNameTable(){} // RVA: 0x67DFF30
        public void InitColorNameTable(){} // RVA: 0x67DFF80
        public void KnownColorToArgb(){} // RVA: 0x67E1970
        public void KnownColorToName(){} // RVA: 0x67E1A10
        public void UpdateSystemColors(){} // RVA: 0x67E1AB0
    }

    public class Point
    {
        public int x; // 0x10
        public int y; // 0x14

        // ── Methods ──
        public void get_X(){} // RVA: 0x19689B0
        public void get_Y(){} // RVA: 0x19689E0
        public void op_Equality(){} // RVA: 0x67E24D0
        public void Equals(){} // RVA: 0x67E2590 | overloaded x2
        public void GetHashCode(){} // RVA: 0x67E25B0
        public void ToString(){} // RVA: 0x67E2620
    }

    public class PointF
    {
        public float x; // 0x10
        public float y; // 0x14

        // ── Methods ──
        public void get_X(){} // RVA: 0x1D26670
        public void get_Y(){} // RVA: 0x1F78370
        public void op_Equality(){} // RVA: 0x67E2820
        public void Equals(){} // RVA: 0x67E2900 | overloaded x2
        public void GetHashCode(){} // RVA: 0x67E2930
        public void ToString(){} // RVA: 0x67E29C0
    }

    public class Rectangle
    {
        public int x; // 0x10
        public int y; // 0x14
        public int width; // 0x18
        public int height; // 0x1C

        // ── Methods ──
        public void get_X(){} // RVA: 0x19689B0
        public void get_Y(){} // RVA: 0x19689E0
        public void get_Width(){} // RVA: 0x1EA9890
        public void get_Height(){} // RVA: 0x1EA98B0
        public void Equals(){} // RVA: 0x67E2B90 | overloaded x2
        public void op_Equality(){} // RVA: 0x5E95BE0
        public void GetHashCode(){} // RVA: 0x67E2BE0
        public void ToString(){} // RVA: 0x67E2C70
    }

    public class RectangleF
    {
        public float x; // 0x10
        public float y; // 0x14
        public float width; // 0x18
        public float height; // 0x1C

        // ── Methods ──
        public void get_X(){} // RVA: 0x1D26670
        public void get_Y(){} // RVA: 0x1F78370
        public void get_Width(){} // RVA: 0x1F78360
        public void get_Height(){} // RVA: 0x1F78390
        public void Equals(){} // RVA: 0x67E30A0 | overloaded x2
        public void op_Equality(){} // RVA: 0x67E30F0
        public void GetHashCode(){} // RVA: 0x67E3130
        public void ToString(){} // RVA: 0x67E3220
    }

    public class Size
    {
        public int width; // 0x10
        public int height; // 0x14

        // ── Methods ──
        public void op_Equality(){} // RVA: 0x67E24D0
        public void get_Width(){} // RVA: 0x19689B0
        public void get_Height(){} // RVA: 0x19689E0
        public void Equals(){} // RVA: 0x67E2590 | overloaded x2
        public void GetHashCode(){} // RVA: 0x67E3590
        public void ToString(){} // RVA: 0x67E3600
    }

    public class SizeF
    {
        public float width; // 0x10
        public float height; // 0x14

        // ── Methods ──
        public void op_Equality(){} // RVA: 0x67E2820
        public void get_Width(){} // RVA: 0x1D26670
        public void get_Height(){} // RVA: 0x1F78370
        public void Equals(){} // RVA: 0x67E2900 | overloaded x2
        public void GetHashCode(){} // RVA: 0x67E37B0
        public void ToString(){} // RVA: 0x67E3840
    }

}