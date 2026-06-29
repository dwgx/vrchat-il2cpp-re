// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Drawing
// Classes: 8
// Methods: 58

namespace ThirdParty.DotNet.System.Drawing
{
    public class Color : ValueType
    {
        public object name;
        public object value;
        public object knownColor;
        public object state;

        // ── Methods ──
        public void get_R(){} // RVA: 0x909290
        public void get_G(){} // RVA: 0x9092B0
        public void get_B(){} // RVA: 0x9092D0
        public void get_A(){} // RVA: 0x9092E0
        public void get_IsKnownColor(){} // RVA: 0x909300
        public void get_Name(){} // RVA: 0x909310
        public void get_Value(){} // RVA: 0x909320
        public void ToString(){} // RVA: 0x909330
        public void op_Equality(){} // RVA: 0x7246FA0
        public void Equals(){} // RVA: 0x9093E0
        public void GetHashCode(){} // RVA: 0x909410
    }

    public class KnownColorTable : Object
    {
        public object s_colorTable;
        public object s_colorNameTable;

        // ── Methods ──
        public void EnsureColorTable(){} // RVA: 0x7244050
        public void InitColorTable(){} // RVA: 0x72440A0
        public void EnsureColorNameTable(){} // RVA: 0x7244D00
        public void InitColorNameTable(){} // RVA: 0x7244D50
        public void KnownColorToArgb(){} // RVA: 0x7246740
        public void KnownColorToName(){} // RVA: 0x72467E0
        public void UpdateSystemColors(){} // RVA: 0x7246880
    }

    public class Point : ValueType
    {
        public object x;
        public object y;

        // ── Methods ──
        public void get_X(){} // RVA: 0x77E60
        public void get_Y(){} // RVA: 0x77E50
        public void op_Equality(){} // RVA: 0x72472A0
        public void Equals(){} // RVA: 0x909590
        public void GetHashCode(){} // RVA: 0x9095B0
        public void ToString(){} // RVA: 0x909620
    }

    public class PointF : ValueType
    {
        public object x;
        public object y;

        // ── Methods ──
        public void get_X(){} // RVA: 0x88D10
        public void get_Y(){} // RVA: 0xD1B60
        public void op_Equality(){} // RVA: 0x72475F0
        public void Equals(){} // RVA: 0x9096D0
        public void GetHashCode(){} // RVA: 0x909700
        public void ToString(){} // RVA: 0x909790
    }

    public class Rectangle : ValueType
    {
        public object x;
        public object y;
        public object width;
        public object height;

        // ── Methods ──
        public void get_X(){} // RVA: 0x77E60
        public void get_Y(){} // RVA: 0x77E50
        public void get_Width(){} // RVA: 0x14790
        public void get_Height(){} // RVA: 0x92DE0
        public void Equals(){} // RVA: 0x909960
        public void op_Equality(){} // RVA: 0x690F240
        public void GetHashCode(){} // RVA: 0x9099B0
        public void ToString(){} // RVA: 0x909A40
    }

    public class RectangleF : ValueType
    {
        public object x;
        public object y;
        public object width;
        public object height;

        // ── Methods ──
        public void get_X(){} // RVA: 0x88D10
        public void get_Y(){} // RVA: 0xD1B60
        public void get_Width(){} // RVA: 0xD1B30
        public void get_Height(){} // RVA: 0xD1B00
        public void Equals(){} // RVA: 0x909B20
        public void op_Equality(){} // RVA: 0x7247EC0
        public void GetHashCode(){} // RVA: 0x909B70
        public void ToString(){} // RVA: 0x909C60
    }

    public class Size : ValueType
    {
        public object width;
        public object height;

        // ── Methods ──
        public void op_Equality(){} // RVA: 0x72472A0
        public void get_Width(){} // RVA: 0x77E60
        public void get_Height(){} // RVA: 0x77E50
        public void Equals(){} // RVA: 0x909590
        public void GetHashCode(){} // RVA: 0x909D10
        public void ToString(){} // RVA: 0x909D80
    }

    public class SizeF : ValueType
    {
        public object width;
        public object height;

        // ── Methods ──
        public void op_Equality(){} // RVA: 0x72475F0
        public void get_Width(){} // RVA: 0x88D10
        public void get_Height(){} // RVA: 0xD1B60
        public void Equals(){} // RVA: 0x9096D0
        public void GetHashCode(){} // RVA: 0x909F30
        public void ToString(){} // RVA: 0x909FC0
    }

}