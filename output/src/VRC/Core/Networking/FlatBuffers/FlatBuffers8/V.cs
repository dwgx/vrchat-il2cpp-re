// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 21
// Methods: 201

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class Vector2 : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_X(){} // RVA: 0x7FFAC9D75400
        public void MutateX(){} // RVA: 0x7FFAC9D75430
        public void get_Y(){} // RVA: 0x7FFAC9D80770
        public void MutateY(){} // RVA: 0x7FFAC9D807A0
        public void CreateVector2(){} // RVA: 0x7FFAC9D807D0
        public void UnPack(){} // RVA: 0x7FFAC9D808E0
        public void UnPackTo(){} // RVA: 0x7FFAC9D80970
        public void Pack(){} // RVA: 0x7FFAC9D809D0
    }

    public class Vector2Array : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsVector2Array(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9D965B0
        public void get_ValueLength(){} // RVA: 0x7FFAC9D75CA0
        public void CreateVector2Array(){} // RVA: 0x7FFAC9D96710
        public void StartVector2Array(){} // RVA: 0x7FFAC9D758E0
        public void AddValue(){} // RVA: 0x7FFAC9D75900
        public void StartValueVector(){} // RVA: 0x7FFAC9D967D0
        public void EndVector2Array(){} // RVA: 0x7FFAC9D96800
        public void UnPack(){} // RVA: 0x7FFAC9D96890
        public void UnPackTo(){} // RVA: 0x7FFAC9D96940
        public void Pack(){} // RVA: 0x7FFAC9D96B50
    }

    public class Vector2ArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector2T> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class Vector2ArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D92B90
    }

    public class Vector2T : Object
    {
        public float zero; // 0x10
        public float magnitude; // 0x14

        // ── Methods ──
        public void ToNumerics(){} // RVA: 0x7FFAC58743D0
        public void get_zero(){} // RVA: 0x7FFAC9D72C60
        public void .ctor(){} // RVA: 0x7FFAC89DB450 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFAC9D72CA0
        public void op_UnaryNegation(){} // RVA: 0x7FFAC9D72CD0
        public void get_magnitude(){} // RVA: 0x7FFAC9D72D40
        public void get_sqrMagnitude(){} // RVA: 0x7FFAC9D72DD0
        public void op_Multiply(){} // RVA: 0x7FFAC9D72F70 | overloaded x4
        public void op_Division(){} // RVA: 0x7FFAC9D73070 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFAC9D731F0 | overloaded x3
        public void op_Subtraction(){} // RVA: 0x7FFAC9D73370 | overloaded x3
        public void LerpUnclamped(){} // RVA: 0x7FFAC9D733F0
        public void Lerp(){} // RVA: 0x7FFAC9D734F0
        public void IsBad(){} // RVA: 0x7FFAC9D736D0
        public void get_X(){} // RVA: 0x7FFAC304B320
        public void set_X(){} // RVA: 0x7FFAC304B330
        public void get_Y(){} // RVA: 0x7FFAC304B340
        public void set_Y(){} // RVA: 0x7FFAC304B350
    }

    public class Vector3 : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_X(){} // RVA: 0x7FFAC9D75400
        public void MutateX(){} // RVA: 0x7FFAC9D75430
        public void get_Y(){} // RVA: 0x7FFAC9D80770
        public void MutateY(){} // RVA: 0x7FFAC9D807A0
        public void get_Z(){} // RVA: 0x7FFAC9D80E30
        public void MutateZ(){} // RVA: 0x7FFAC9D80E60
        public void CreateVector3(){} // RVA: 0x7FFAC9D80E90
        public void UnPack(){} // RVA: 0x7FFAC9D80FD0
        public void UnPackTo(){} // RVA: 0x7FFAC9D81080
        public void Pack(){} // RVA: 0x7FFAC9D81100
    }

    public class Vector3Array : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsVector3Array(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9D96D30
        public void get_ValueLength(){} // RVA: 0x7FFAC9D75CA0
        public void CreateVector3Array(){} // RVA: 0x7FFAC9D96E90
        public void StartVector3Array(){} // RVA: 0x7FFAC9D758E0
        public void AddValue(){} // RVA: 0x7FFAC9D75900
        public void StartValueVector(){} // RVA: 0x7FFAC9D96F50
        public void EndVector3Array(){} // RVA: 0x7FFAC9D96F80
        public void UnPack(){} // RVA: 0x7FFAC9D97010
        public void UnPackTo(){} // RVA: 0x7FFAC9D970C0
        public void Pack(){} // RVA: 0x7FFAC9D972D0
    }

    public class Vector3ArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector3T> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class Vector3ArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D974C0
    }

    public class Vector3Bytes : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Data(){} // RVA: 0x7FFAC9D7A3F0
        public void MutateData(){} // RVA: 0x7FFAC9D7A420
        public void CreateVector3Bytes(){} // RVA: 0x7FFAC9D809F0
        public void UnPack(){} // RVA: 0x7FFAC9D80B00
        public void UnPackTo(){} // RVA: 0x7FFAC9D80B70
        public void Pack(){} // RVA: 0x7FFAC9D80C70
    }

    public class Vector3BytesT : Object
    {
        public byte[] Data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAC2F3C380
        public void set_Data(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC9D80DA0
    }

    public class Vector3Half : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Data(){} // RVA: 0x7FFAC9D7A3F0
        public void MutateData(){} // RVA: 0x7FFAC9D7A420
        public void CreateVector3Half(){} // RVA: 0x7FFAC9D81EA0
        public void UnPack(){} // RVA: 0x7FFAC9D81FB0
        public void UnPackTo(){} // RVA: 0x7FFAC9D82020
        public void Pack(){} // RVA: 0x7FFAC9D82120
    }

    public class Vector3HalfT : Object
    {
        public byte[] Data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAC2F3C380
        public void set_Data(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC9D82250
    }

    public class Vector3T : Object
    {
        public float zero; // 0x10
        public float magnitude; // 0x14
        public float sqrMagnitude; // 0x18

        // ── Methods ──
        public void ToNumerics(){} // RVA: 0x7FFAC3736D20
        public void get_zero(){} // RVA: 0x7FFAC9D73710
        public void .ctor(){} // RVA: 0x7FFAC8A7DD60 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFAC9D73780
        public void get_magnitude(){} // RVA: 0x7FFAC9D737B0
        public void get_sqrMagnitude(){} // RVA: 0x7FFAC9D73850
        public void op_Multiply(){} // RVA: 0x7FFAC9D73AB0 | overloaded x4
        public void op_UnaryNegation(){} // RVA: 0x7FFAC9D73910
        public void op_Division(){} // RVA: 0x7FFAC9D73BD0 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFAC9D73D60 | overloaded x3
        public void op_Subtraction(){} // RVA: 0x7FFAC9D73EF0 | overloaded x3
        public void LerpUnclamped(){} // RVA: 0x7FFAC9D73F80
        public void Lerp(){} // RVA: 0x7FFAC9D740B0
        public void IsBad(){} // RVA: 0x7FFAC9D742E0
        public void ToString(){} // RVA: 0x7FFAC9D74340
        public void get_X(){} // RVA: 0x7FFAC304B320
        public void set_X(){} // RVA: 0x7FFAC304B330
        public void get_Y(){} // RVA: 0x7FFAC304B340
        public void set_Y(){} // RVA: 0x7FFAC304B350
        public void get_Z(){} // RVA: 0x7FFAC2F25CF0
        public void set_Z(){} // RVA: 0x7FFAC2F3C4D0
    }

    public class Vector3TenBit : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Data(){} // RVA: 0x7FFAC9D7A3F0
        public void MutateData(){} // RVA: 0x7FFAC9D7A420
        public void CreateVector3TenBit(){} // RVA: 0x7FFAC9D81730
        public void UnPack(){} // RVA: 0x7FFAC9D81840
        public void UnPackTo(){} // RVA: 0x7FFAC9D818B0
        public void Pack(){} // RVA: 0x7FFAC9D819B0
    }

    public class Vector3TenBitT : Object
    {
        public byte[] Data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAC2F3C380
        public void set_Data(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC9D819D0
    }

    public class Vector4 : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_X(){} // RVA: 0x7FFAC9D75400
        public void MutateX(){} // RVA: 0x7FFAC9D75430
        public void get_Y(){} // RVA: 0x7FFAC9D80770
        public void MutateY(){} // RVA: 0x7FFAC9D807A0
        public void get_Z(){} // RVA: 0x7FFAC9D80E30
        public void MutateZ(){} // RVA: 0x7FFAC9D80E60
        public void get_W(){} // RVA: 0x7FFAC9D81140
        public void MutateW(){} // RVA: 0x7FFAC9D81170
        public void CreateVector4(){} // RVA: 0x7FFAC9D811A0
        public void UnPack(){} // RVA: 0x7FFAC9D81310
        public void UnPackTo(){} // RVA: 0x7FFAC9D813E0
        public void Pack(){} // RVA: 0x7FFAC9D81470
    }

    public class Vector4Array : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsVector4Array(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9D97530
        public void get_ValueLength(){} // RVA: 0x7FFAC9D75CA0
        public void CreateVector4Array(){} // RVA: 0x7FFAC9D97680
        public void StartVector4Array(){} // RVA: 0x7FFAC9D758E0
        public void AddValue(){} // RVA: 0x7FFAC9D75900
        public void StartValueVector(){} // RVA: 0x7FFAC9D97740
        public void EndVector4Array(){} // RVA: 0x7FFAC9D97770
        public void UnPack(){} // RVA: 0x7FFAC9D97800
        public void UnPackTo(){} // RVA: 0x7FFAC9D978B0
        public void Pack(){} // RVA: 0x7FFAC9D97AC0
    }

    public class Vector4ArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector4T> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class Vector4ArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D97CB0
    }

    public class Vector4T : Object
    {
        public float X; // 0x10
        public float Y; // 0x14
        public float Z; // 0x18
        public float W; // 0x1C

        // ── Methods ──
        public void get_X(){} // RVA: 0x7FFAC304B320
        public void set_X(){} // RVA: 0x7FFAC304B330
        public void get_Y(){} // RVA: 0x7FFAC304B340
        public void set_Y(){} // RVA: 0x7FFAC304B350
        public void get_Z(){} // RVA: 0x7FFAC2F25CF0
        public void set_Z(){} // RVA: 0x7FFAC2F3C4D0
        public void get_W(){} // RVA: 0x7FFAC2FEE570
        public void set_W(){} // RVA: 0x7FFAC2FEE580
        public void .ctor(){} // RVA: 0x7FFAC9D72C50
    }

}