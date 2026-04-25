// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 10
// Methods: 88

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class Color : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_R(){} // RVA: 0x7FFAC9D75400
        public void MutateR(){} // RVA: 0x7FFAC9D75430
        public void get_G(){} // RVA: 0x7FFAC9D80770
        public void MutateG(){} // RVA: 0x7FFAC9D807A0
        public void get_B(){} // RVA: 0x7FFAC9D80E30
        public void MutateB(){} // RVA: 0x7FFAC9D80E60
        public void get_A(){} // RVA: 0x7FFAC9D81140
        public void MutateA(){} // RVA: 0x7FFAC9D81170
        public void CreateColor(){} // RVA: 0x7FFAC9D82790
        public void UnPack(){} // RVA: 0x7FFAC9D82900
        public void UnPackTo(){} // RVA: 0x7FFAC9D813E0
        public void Pack(){} // RVA: 0x7FFAC9D829D0
    }

    public class Color32 : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_R(){} // RVA: 0x7FFAC9D7A9A0
        public void MutateR(){} // RVA: 0x7FFAC9D75030
        public void get_G(){} // RVA: 0x7FFAC9D7A9D0
        public void MutateG(){} // RVA: 0x7FFAC9D7AA00
        public void get_B(){} // RVA: 0x7FFAC9D82A10
        public void MutateB(){} // RVA: 0x7FFAC9D82A40
        public void get_A(){} // RVA: 0x7FFAC9D82A70
        public void MutateA(){} // RVA: 0x7FFAC9D82AA0
        public void CreateColor32(){} // RVA: 0x7FFAC9D82AD0
        public void UnPack(){} // RVA: 0x7FFAC9D82C30
        public void UnPackTo(){} // RVA: 0x7FFAC9D82CF0
        public void Pack(){} // RVA: 0x7FFAC9D82D80
    }

    public class Color32Array : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsColor32Array(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9D98BC0
        public void get_ValueLength(){} // RVA: 0x7FFAC9D75CA0
        public void CreateColor32Array(){} // RVA: 0x7FFAC9D98D20
        public void StartColor32Array(){} // RVA: 0x7FFAC9D758E0
        public void AddValue(){} // RVA: 0x7FFAC9D75900
        public void StartValueVector(){} // RVA: 0x7FFAC9D98DE0
        public void EndColor32Array(){} // RVA: 0x7FFAC9D98E10
        public void UnPack(){} // RVA: 0x7FFAC9D98EA0
        public void UnPackTo(){} // RVA: 0x7FFAC9D98F50
        public void Pack(){} // RVA: 0x7FFAC9D99160
    }

    public class Color32ArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.Color32T> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class Color32ArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D92130
    }

    public class Color32T : Object
    {
        public byte R; // 0x10
        public byte G; // 0x11
        public byte B; // 0x12
        public byte A; // 0x13

        // ── Methods ──
        public void get_R(){} // RVA: 0x7FFAC2FEB5E0
        public void set_R(){} // RVA: 0x7FFAC2FEB5F0
        public void get_G(){} // RVA: 0x7FFAC3771DA0
        public void set_G(){} // RVA: 0x7FFAC3771D90
        public void get_B(){} // RVA: 0x7FFAC3AE1A90
        public void set_B(){} // RVA: 0x7FFAC4411DE0
        public void get_A(){} // RVA: 0x7FFAC4411E00
        public void set_A(){} // RVA: 0x7FFAC4411E10
        public void .ctor(){} // RVA: 0x7FFAC369FBB0
    }

    public class ColorArray : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsColorArray(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9D98470
        public void get_ValueLength(){} // RVA: 0x7FFAC9D75CA0
        public void CreateColorArray(){} // RVA: 0x7FFAC9D985C0
        public void StartColorArray(){} // RVA: 0x7FFAC9D758E0
        public void AddValue(){} // RVA: 0x7FFAC9D75900
        public void StartValueVector(){} // RVA: 0x7FFAC9D97740
        public void EndColorArray(){} // RVA: 0x7FFAC9D98680
        public void UnPack(){} // RVA: 0x7FFAC9D98710
        public void UnPackTo(){} // RVA: 0x7FFAC9D987C0
        public void Pack(){} // RVA: 0x7FFAC9D989D0
    }

    public class ColorArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.ColorT> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class ColorArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D97CB0
    }

    public class ColorT : Object
    {
        public float R; // 0x10
        public float G; // 0x14
        public float B; // 0x18
        public float A; // 0x1C

        // ── Methods ──
        public void get_R(){} // RVA: 0x7FFAC304B320
        public void set_R(){} // RVA: 0x7FFAC304B330
        public void get_G(){} // RVA: 0x7FFAC304B340
        public void set_G(){} // RVA: 0x7FFAC304B350
        public void get_B(){} // RVA: 0x7FFAC2F25CF0
        public void set_B(){} // RVA: 0x7FFAC2F3C4D0
        public void get_A(){} // RVA: 0x7FFAC2FEE570
        public void set_A(){} // RVA: 0x7FFAC2FEE580
        public void .ctor(){} // RVA: 0x7FFAC9D72C50
    }

}