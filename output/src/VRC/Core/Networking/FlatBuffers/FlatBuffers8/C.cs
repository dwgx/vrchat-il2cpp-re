// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 10
// Methods: 78

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class Color : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_R(){} // RVA: 0x9B56F0
        public void get_G(){} // RVA: 0x9B6D30
        public void get_B(){} // RVA: 0x9B6F70
        public void get_A(){} // RVA: 0x9B70F0
        public void CreateColor(){} // RVA: 0x8224270
        public void UnPack(){} // RVA: 0x9B7720
        public void UnPackTo(){} // RVA: 0x9B7130
        public void Pack(){} // RVA: 0x8224460
    }

    public class Color32 : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_R(){} // RVA: 0x9B64A0
        public void get_G(){} // RVA: 0x9B64D0
        public void get_B(){} // RVA: 0x9B77F0
        public void get_A(){} // RVA: 0x9B7820
        public void CreateColor32(){} // RVA: 0x8224500
        public void UnPack(){} // RVA: 0x9B7850
        public void UnPackTo(){} // RVA: 0x9B7860
        public void Pack(){} // RVA: 0x82247B0
    }

    public class Color32Array : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsColor32Array(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9BB490
        public void get_ValueLength(){} // RVA: 0x9B5A50
        public void CreateColor32Array(){} // RVA: 0x823B630
        public void StartColor32Array(){} // RVA: 0x8217590
        public void AddValue(){} // RVA: 0x82175B0
        public void StartValueVector(){} // RVA: 0x823B6F0
        public void EndColor32Array(){} // RVA: 0x823B720
        public void UnPack(){} // RVA: 0x9BB4C0
        public void UnPackTo(){} // RVA: 0x9BB4D0
        public void Pack(){} // RVA: 0x823BA70
    }

    public class Color32ArrayT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class Color32ArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8234AB0
    }

    public class Color32T : Object
    {
        public object _r;
        public object _g;
        public object _b;
        public object _a;

        // ── Methods ──
        public void get_R(){} // RVA: 0xC120A0
        public void set_R(){} // RVA: 0xC120B0
        public void get_G(){} // RVA: 0xDD5C50
        public void set_G(){} // RVA: 0xDD7A00
        public void get_B(){} // RVA: 0x22201E0
        public void set_B(){} // RVA: 0x22201F0
        public void get_A(){} // RVA: 0x2220200
        public void set_A(){} // RVA: 0x2220210
        public void .ctor(){} // RVA: 0x132A2D0
    }

    public class ColorArray : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsColorArray(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9BB380
        public void get_ValueLength(){} // RVA: 0x9B5A50
        public void CreateColorArray(){} // RVA: 0x823AEA0
        public void StartColorArray(){} // RVA: 0x8217590
        public void AddValue(){} // RVA: 0x82175B0
        public void StartValueVector(){} // RVA: 0x8239FA0
        public void EndColorArray(){} // RVA: 0x823AF60
        public void UnPack(){} // RVA: 0x9BB3B0
        public void UnPackTo(){} // RVA: 0x9BB3C0
        public void Pack(){} // RVA: 0x823B2B0
    }

    public class ColorArrayT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class ColorArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x823A540
    }

    public class ColorT : Object
    {
        public object _r;
        public object _g;
        public object _b;
        public object _a;

        // ── Methods ──
        public void get_R(){} // RVA: 0xC763E0
        public void set_R(){} // RVA: 0xC763F0
        public void get_G(){} // RVA: 0xC76400
        public void set_G(){} // RVA: 0xC76410
        public void get_B(){} // RVA: 0xB47B50
        public void set_B(){} // RVA: 0xB5DD40
        public void get_A(){} // RVA: 0xC152D0
        public void set_A(){} // RVA: 0xC152E0
        public void .ctor(){} // RVA: 0x8215970
    }

}