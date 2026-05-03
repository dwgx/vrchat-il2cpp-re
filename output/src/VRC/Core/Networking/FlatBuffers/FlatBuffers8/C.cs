// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 10
// Methods: 80

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class Color : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0x100
        public object field_2; // 0x101
        public object field_3; // 0x102
        public object field_4; // 0x103

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_R(){} // RVA: 0x7FFE8811DA60
        public void get_G(){} // RVA: 0x7FFE88128960
        public void get_B(){} // RVA: 0x7FFE88128FD0
        public void get_A(){} // RVA: 0x7FFE88129280
        public void CreateColor(){} // RVA: 0x7FFE8812A800
        public void UnPack(){} // RVA: 0x7FFE8812A920
        public void UnPackTo(){} // RVA: 0x7FFE881294A0
        public void Pack(){} // RVA: 0x7FFE8812A9F0
    }

    public class Color32 : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0x109
        public object field_2; // 0x10A
        public object field_3; // 0x10B
        public object field_4; // 0x10C

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_R(){} // RVA: 0x7FFE88122E10
        public void get_G(){} // RVA: 0x7FFE88122E40
        public void get_B(){} // RVA: 0x7FFE8812AA30
        public void get_A(){} // RVA: 0x7FFE8812AA60
        public void CreateColor32(){} // RVA: 0x7FFE8812AA90
        public void UnPack(){} // RVA: 0x7FFE8812ABF0
        public void UnPackTo(){} // RVA: 0x7FFE8812ACB0
        public void Pack(){} // RVA: 0x7FFE8812AD40
    }

    public class Color32Array : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x1B7

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsColor32Array(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE881404D0
        public void get_ValueLength(){} // RVA: 0x7FFE8811E2C0
        public void CreateColor32Array(){} // RVA: 0x7FFE88140630
        public void StartColor32Array(){} // RVA: 0x7FFE8811DF00
        public void AddValue(){} // RVA: 0x7FFE8811DF20
        public void StartValueVector(){} // RVA: 0x7FFE881406F0
        public void EndColor32Array(){} // RVA: 0x7FFE88140720
        public void UnPack(){} // RVA: 0x7FFE881407B0
        public void UnPackTo(){} // RVA: 0x7FFE88140860
        public void Pack(){} // RVA: 0x7FFE88140A70
    }

    public class Color32ArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.Color32T> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class Color32ArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE88139AF0
    }

    public class Color32T : Object
    {
        public byte _r; // 0x10
        public byte _g; // 0x11
        public byte _b; // 0x12
        public byte _a; // 0x13

        // ── Methods ──
        public void get_R(){} // RVA: 0x7FFE811C55E0
        public void set_R(){} // RVA: 0x7FFE811C55F0
        public void get_G(){} // RVA: 0x7FFE81346E30
        public void set_G(){} // RVA: 0x7FFE813471A0
        public void get_B(){} // RVA: 0x7FFE826E3520
        public void set_B(){} // RVA: 0x7FFE826E34A0
        public void get_A(){} // RVA: 0x7FFE826E3500
        public void set_A(){} // RVA: 0x7FFE826E3510
        public void .ctor(){} // RVA: 0x7FFE817EE4A0
    }

    public class ColorArray : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x1B4

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsColorArray(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8813FD80
        public void get_ValueLength(){} // RVA: 0x7FFE8811E2C0
        public void CreateColorArray(){} // RVA: 0x7FFE8813FED0
        public void StartColorArray(){} // RVA: 0x7FFE8811DF00
        public void AddValue(){} // RVA: 0x7FFE8811DF20
        public void StartValueVector(){} // RVA: 0x7FFE8813F050
        public void EndColorArray(){} // RVA: 0x7FFE8813FF90
        public void UnPack(){} // RVA: 0x7FFE88140020
        public void UnPackTo(){} // RVA: 0x7FFE881400D0
        public void Pack(){} // RVA: 0x7FFE881402E0
    }

    public class ColorArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.ColorT> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class ColorArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8813F5C0
    }

    public class ColorT : Object
    {
        public float _r; // 0x10
        public float _g; // 0x14
        public float _b; // 0x18
        public float _a; // 0x1C

        // ── Methods ──
        public void get_R(){} // RVA: 0x7FFE81225320
        public void set_R(){} // RVA: 0x7FFE81225330
        public void get_G(){} // RVA: 0x7FFE81225340
        public void set_G(){} // RVA: 0x7FFE81225350
        public void get_B(){} // RVA: 0x7FFE810FFCF0
        public void set_B(){} // RVA: 0x7FFE811164D0
        public void get_A(){} // RVA: 0x7FFE811C8570
        public void set_A(){} // RVA: 0x7FFE811C8580
        public void .ctor(){} // RVA: 0x7FFE8811C4F0
    }

}