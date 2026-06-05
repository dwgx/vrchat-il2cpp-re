// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 10
// Methods: 80

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class Color
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_R(){} // RVA: 0x7FFAFA090A10
        public void get_G(){} // RVA: 0x7FFAFA09B910
        public void get_B(){} // RVA: 0x7FFAFA09BF80
        public void get_A(){} // RVA: 0x7FFAFA09C230
        public void CreateColor(){} // RVA: 0x7FFAFA09D7B0
        public void UnPack(){} // RVA: 0x7FFAFA09D8D0
        public void UnPackTo(){} // RVA: 0x7FFAFA09C450
        public void Pack(){} // RVA: 0x7FFAFA09D9A0
    }

    public class Color32
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_R(){} // RVA: 0x7FFAFA095DC0
        public void get_G(){} // RVA: 0x7FFAFA095DF0
        public void get_B(){} // RVA: 0x7FFAFA09D9E0
        public void get_A(){} // RVA: 0x7FFAFA09DA10
        public void CreateColor32(){} // RVA: 0x7FFAFA09DA40
        public void UnPack(){} // RVA: 0x7FFAFA09DBA0
        public void UnPackTo(){} // RVA: 0x7FFAFA09DC60
        public void Pack(){} // RVA: 0x7FFAFA09DCF0
    }

    public class Color32Array
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsColor32Array(){} // RVA: 0x7FFAFA090C40 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void Value(){} // RVA: 0x7FFAFA0B3480
        public void get_ValueLength(){} // RVA: 0x7FFAFA091270
        public void CreateColor32Array(){} // RVA: 0x7FFAFA0B35E0
        public void StartColor32Array(){} // RVA: 0x7FFAFA090EB0
        public void AddValue(){} // RVA: 0x7FFAFA090ED0
        public void StartValueVector(){} // RVA: 0x7FFAFA0B36A0
        public void EndColor32Array(){} // RVA: 0x7FFAFA0B36D0
        public void UnPack(){} // RVA: 0x7FFAFA0B3760
        public void UnPackTo(){} // RVA: 0x7FFAFA0B3810
        public void Pack(){} // RVA: 0x7FFAFA0B3A20
    }

    public class Color32ArrayT
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAF2DA8380
        public void set_Value(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAF81FFB20
    }

    public class Color32ArrayVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0ACAA0
    }

    public class Color32T
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_R(){} // RVA: 0x7FFAF2E575E0
        public void set_R(){} // RVA: 0x7FFAF2E575F0
        public void get_G(){} // RVA: 0x7FFAF2FF3460
        public void set_G(){} // RVA: 0x7FFAF2FF3470
        public void get_B(){} // RVA: 0x7FFAF440A940
        public void set_B(){} // RVA: 0x7FFAF440A9A0
        public void get_A(){} // RVA: 0x7FFAF440A9E0
        public void set_A(){} // RVA: 0x7FFAF440A9B0
        public void .ctor(){} // RVA: 0x7FFAF350D070
    }

    public class ColorArray
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsColorArray(){} // RVA: 0x7FFAFA090C40 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void Value(){} // RVA: 0x7FFAFA0B2D30
        public void get_ValueLength(){} // RVA: 0x7FFAFA091270
        public void CreateColorArray(){} // RVA: 0x7FFAFA0B2E80
        public void StartColorArray(){} // RVA: 0x7FFAFA090EB0
        public void AddValue(){} // RVA: 0x7FFAFA090ED0
        public void StartValueVector(){} // RVA: 0x7FFAFA0B2000
        public void EndColorArray(){} // RVA: 0x7FFAFA0B2F40
        public void UnPack(){} // RVA: 0x7FFAFA0B2FD0
        public void UnPackTo(){} // RVA: 0x7FFAFA0B3080
        public void Pack(){} // RVA: 0x7FFAFA0B3290
    }

    public class ColorArrayT
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAF2DA8380
        public void set_Value(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAF81FFB20
    }

    public class ColorArrayVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0B2570
    }

    public class ColorT
    {
        public object ByteBuffer;
        public object R;
        public object G;
        public object B;

        // ── Methods ──
        public void get_R(){} // RVA: 0x7FFAF2EB7320
        public void set_R(){} // RVA: 0x7FFAF2EB7330
        public void get_G(){} // RVA: 0x7FFAF2EB7340
        public void set_G(){} // RVA: 0x7FFAF2EB7350
        public void get_B(){} // RVA: 0x7FFAF2D91CF0
        public void set_B(){} // RVA: 0x7FFAF2DA84D0
        public void get_A(){} // RVA: 0x7FFAF2E5A570
        public void set_A(){} // RVA: 0x7FFAF2E5A580
        public void .ctor(){} // RVA: 0x7FFAFA08F4A0
    }

}