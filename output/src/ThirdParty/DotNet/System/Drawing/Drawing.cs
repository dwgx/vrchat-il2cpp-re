// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Drawing
// Classes: 8
// Methods: 65

namespace ThirdParty.DotNet.System.Drawing
{
    public class Color : ValueType
    {
        public string R; // 0x10
        public long G; // 0x18
        public short B; // 0x20
        public short A; // 0x22

        // ── Methods ──
        public void get_R(){} // RVA: 0x7FFAC8F787D0
        public void get_G(){} // RVA: 0x7FFAC8F787F0
        public void get_B(){} // RVA: 0x7FFAC8F78810
        public void get_A(){} // RVA: 0x7FFAC8F78820
        public void get_IsKnownColor(){} // RVA: 0x7FFAC8F78840
        public void get_Name(){} // RVA: 0x7FFAC8F78850
        public void get_Value(){} // RVA: 0x7FFAC8F78970
        public void ToString(){} // RVA: 0x7FFAC8F78A40
        public void op_Equality(){} // RVA: 0x7FFAC8F78C80
        public void Equals(){} // RVA: 0x7FFAC8F78DD0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8F78EA0
    }

    public class KnownColorTable : Object
    {
        public int[] s_colorTable;
        public string[] s_colorNameTable; // 0x8

        // ── Methods ──
        public void EnsureColorTable(){} // RVA: 0x7FFAC8F75D30
        public void InitColorTable(){} // RVA: 0x7FFAC8F75D80
        public void EnsureColorNameTable(){} // RVA: 0x7FFAC8F769E0
        public void InitColorNameTable(){} // RVA: 0x7FFAC8F76A30
        public void KnownColorToArgb(){} // RVA: 0x7FFAC8F78420
        public void KnownColorToName(){} // RVA: 0x7FFAC8F784C0
        public void UpdateSystemColors(){} // RVA: 0x7FFAC8F78560
    }

    public class Point : ValueType
    {
        public int X; // 0x10
        public int Y; // 0x14

        // ── Methods ──
        public void get_X(){} // RVA: 0x7FFAC4420210
        public void get_Y(){} // RVA: 0x7FFAC44202A0
        public void op_Equality(){} // RVA: 0x7FFAC8F78F80
        public void Equals(){} // RVA: 0x7FFAC8F79040 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8F79060
        public void ToString(){} // RVA: 0x7FFAC8F790D0
    }

    public class PointF : ValueType
    {
        public float X; // 0x10
        public float Y; // 0x14

        // ── Methods ──
        public void get_X(){} // RVA: 0x7FFAC484C150
        public void get_Y(){} // RVA: 0x7FFAC4A9B900
        public void op_Equality(){} // RVA: 0x7FFAC8F792D0
        public void Equals(){} // RVA: 0x7FFAC8F793B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8F793E0
        public void ToString(){} // RVA: 0x7FFAC8F79470
    }

    public class Rectangle : ValueType
    {
        public int X; // 0x10
        public int Y; // 0x14
        public int Width; // 0x18
        public int Height; // 0x1C

        // ── Methods ──
        public void get_X(){} // RVA: 0x7FFAC4420210
        public void get_Y(){} // RVA: 0x7FFAC44202A0
        public void get_Width(){} // RVA: 0x7FFAC49C7500
        public void get_Height(){} // RVA: 0x7FFAC49C7520
        public void Equals(){} // RVA: 0x7FFAC8F79640 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC862D250
        public void GetHashCode(){} // RVA: 0x7FFAC8F79690
        public void ToString(){} // RVA: 0x7FFAC8F79720
    }

    public class RectangleF : ValueType
    {
        public float X; // 0x10
        public float Y; // 0x14
        public float Width; // 0x18
        public float Height; // 0x1C

        // ── Methods ──
        public void get_X(){} // RVA: 0x7FFAC484C150
        public void get_Y(){} // RVA: 0x7FFAC4A9B900
        public void get_Width(){} // RVA: 0x7FFAC4A9B8E0
        public void get_Height(){} // RVA: 0x7FFAC4A9B8D0
        public void Equals(){} // RVA: 0x7FFAC8F79B50 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC8F79BA0
        public void GetHashCode(){} // RVA: 0x7FFAC8F79BE0
        public void ToString(){} // RVA: 0x7FFAC8F79CD0
    }

    public class Size : ValueType
    {
        public int Width; // 0x10
        public int Height; // 0x14

        // ── Methods ──
        public void op_Equality(){} // RVA: 0x7FFAC8F78F80
        public void get_Width(){} // RVA: 0x7FFAC4420210
        public void get_Height(){} // RVA: 0x7FFAC44202A0
        public void Equals(){} // RVA: 0x7FFAC8F79040 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8F7A040
        public void ToString(){} // RVA: 0x7FFAC8F7A0B0
    }

    public class SizeF : ValueType
    {
        public float Width; // 0x10
        public float Height; // 0x14

        // ── Methods ──
        public void op_Equality(){} // RVA: 0x7FFAC8F792D0
        public void get_Width(){} // RVA: 0x7FFAC484C150
        public void get_Height(){} // RVA: 0x7FFAC4A9B900
        public void Equals(){} // RVA: 0x7FFAC8F793B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8F7A260
        public void ToString(){} // RVA: 0x7FFAC8F7A2F0
    }

}