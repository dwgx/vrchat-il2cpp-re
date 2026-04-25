// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 19
// Methods: 188

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class Vector2 : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_X(){} // RVA: 0x7FFAC9DA5D50
        public void MutateX(){} // RVA: 0x7FFAC9DA5D80
        public void get_Y(){} // RVA: 0x7FFAC9DBBB00
        public void MutateY(){} // RVA: 0x7FFAC9DBBB30
        public void CreateVector2(){} // RVA: 0x7FFAC9DBBB60
        public void UnPack(){} // RVA: 0x7FFAC9DBBC20
        public void UnPackTo(){} // RVA: 0x7FFAC9DBBCB0
        public void Pack(){} // RVA: 0x7FFAC9DBBD10
    }

    public class Vector2Array : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsVector2Array(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9DCD0D0
        public void get_ValueLength(){} // RVA: 0x7FFAC9DA6550
        public void CreateVector2Array(){} // RVA: 0x7FFAC9DCD220
        public void StartVector2Array(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void StartValueVector(){} // RVA: 0x7FFAC9DCD2A0
        public void EndVector2Array(){} // RVA: 0x7FFAC9DCD2D0
        public void UnPack(){} // RVA: 0x7FFAC9DCD320
        public void UnPackTo(){} // RVA: 0x7FFAC9DCD3D0
        public void Pack(){} // RVA: 0x7FFAC9DCD5E0
    }

    public class Vector2ArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.Vector2T> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class Vector2ArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DC9420
    }

    public class Vector2T : Object
    {
        public float zero; // 0x10
        public float magnitude; // 0x14

        // ── Methods ──
        public void ToNumerics(){} // RVA: 0x7FFAC58743D0
        public void get_zero(){} // RVA: 0x7FFAC9D9F5A0
        public void .ctor(){} // RVA: 0x7FFAC89DB450 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFAC9D72CA0
        public void op_UnaryNegation(){} // RVA: 0x7FFAC9D9F5E0
        public void get_magnitude(){} // RVA: 0x7FFAC9D9F650
        public void get_sqrMagnitude(){} // RVA: 0x7FFAC9D72DD0
        public void op_Multiply(){} // RVA: 0x7FFAC9D9F860 | overloaded x4
        public void op_Division(){} // RVA: 0x7FFAC9D9F960 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFAC9D9FAE0 | overloaded x3
        public void op_Subtraction(){} // RVA: 0x7FFAC9D9FC60 | overloaded x3
        public void LerpUnclamped(){} // RVA: 0x7FFAC9D9FCE0
        public void Lerp(){} // RVA: 0x7FFAC9D9FDE0
        public void IsBad(){} // RVA: 0x7FFAC9D736D0
        public void get_X(){} // RVA: 0x7FFAC304B320
        public void set_X(){} // RVA: 0x7FFAC304B330
        public void get_Y(){} // RVA: 0x7FFAC304B340
        public void set_Y(){} // RVA: 0x7FFAC304B350
    }

    public class Vector3 : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_X(){} // RVA: 0x7FFAC9DA5D50
        public void MutateX(){} // RVA: 0x7FFAC9DA5D80
        public void get_Y(){} // RVA: 0x7FFAC9DBBB00
        public void MutateY(){} // RVA: 0x7FFAC9DBBB30
        public void get_Z(){} // RVA: 0x7FFAC9DBBD30
        public void MutateZ(){} // RVA: 0x7FFAC9DBBD60
        public void CreateVector3(){} // RVA: 0x7FFAC9DBBD90
        public void UnPack(){} // RVA: 0x7FFAC9DBBE80
        public void UnPackTo(){} // RVA: 0x7FFAC9DBBF30
        public void Pack(){} // RVA: 0x7FFAC9DBBFB0
    }

    public class Vector3Array : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsVector3Array(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9DCD7C0
        public void get_ValueLength(){} // RVA: 0x7FFAC9DA6550
        public void CreateVector3Array(){} // RVA: 0x7FFAC9DCD920
        public void StartVector3Array(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void StartValueVector(){} // RVA: 0x7FFAC9DCD9A0
        public void EndVector3Array(){} // RVA: 0x7FFAC9DCD9D0
        public void UnPack(){} // RVA: 0x7FFAC9DCDA20
        public void UnPackTo(){} // RVA: 0x7FFAC9DCDAD0
        public void Pack(){} // RVA: 0x7FFAC9DCDCE0
    }

    public class Vector3ArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.Vector3T> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class Vector3ArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DCDEC0
    }

    public class Vector3Half : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Data(){} // RVA: 0x7FFAC9DBC540
        public void MutateData(){} // RVA: 0x7FFAC9DBC570
        public void CreateVector3Half(){} // RVA: 0x7FFAC9DBCD70
        public void UnPack(){} // RVA: 0x7FFAC9DBCE40
        public void UnPackTo(){} // RVA: 0x7FFAC9DBCF20
        public void Pack(){} // RVA: 0x7FFAC9DBD020
    }

    public class Vector3HalfT : Object
    {
        public byte[] Data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAC2F3C380
        public void set_Data(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC9DBD100
    }

    public class Vector3T : Object
    {
        public VRC.Core.Networking.FlatBuffers.FlatBuffers32.Vector3T magnitude;
        public float sqrMagnitude; // 0x10
        public float X; // 0x14
        public float Y; // 0x18

        // ── Methods ──
        public void ToNumerics(){} // RVA: 0x7FFAC3736D20
        public void .ctor(){} // RVA: 0x7FFAC8A7DD60 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFAC9D73780
        public void get_magnitude(){} // RVA: 0x7FFAC9D9FFC0
        public void get_sqrMagnitude(){} // RVA: 0x7FFAC9D73850
        public void op_Multiply(){} // RVA: 0x7FFAC9DA0450 | overloaded x4
        public void op_UnaryNegation(){} // RVA: 0x7FFAC9DA00F0
        public void op_Division(){} // RVA: 0x7FFAC9DA0380 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFAC9DA0680 | overloaded x3
        public void op_Subtraction(){} // RVA: 0x7FFAC9DA08C0 | overloaded x3
        public void LerpUnclamped(){} // RVA: 0x7FFAC9DA0950
        public void Lerp(){} // RVA: 0x7FFAC9DA0A80
        public void IsBad(){} // RVA: 0x7FFAC9D742E0
        public void get_X(){} // RVA: 0x7FFAC304B320
        public void set_X(){} // RVA: 0x7FFAC304B330
        public void get_Y(){} // RVA: 0x7FFAC304B340
        public void set_Y(){} // RVA: 0x7FFAC304B350
        public void get_Z(){} // RVA: 0x7FFAC2F25CF0
        public void set_Z(){} // RVA: 0x7FFAC2F3C4D0
        public void .cctor(){} // RVA: 0x7FFAC9DA0CD0
    }

    public class Vector3TenBit : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Data(){} // RVA: 0x7FFAC9DBC540
        public void MutateData(){} // RVA: 0x7FFAC9DBC570
        public void CreateVector3TenBit(){} // RVA: 0x7FFAC9DBC5A0
        public void UnPack(){} // RVA: 0x7FFAC9DBC670
        public void UnPackTo(){} // RVA: 0x7FFAC9DBC750
        public void Pack(){} // RVA: 0x7FFAC9DBC850
    }

    public class Vector3TenBitT : Object
    {
        public byte[] Data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAC2F3C380
        public void set_Data(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC9DBC930
    }

    public class Vector4 : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_X(){} // RVA: 0x7FFAC9DA5D50
        public void MutateX(){} // RVA: 0x7FFAC9DA5D80
        public void get_Y(){} // RVA: 0x7FFAC9DBBB00
        public void MutateY(){} // RVA: 0x7FFAC9DBBB30
        public void get_Z(){} // RVA: 0x7FFAC9DBBD30
        public void MutateZ(){} // RVA: 0x7FFAC9DBBD60
        public void get_W(){} // RVA: 0x7FFAC9DBBFF0
        public void MutateW(){} // RVA: 0x7FFAC9DBC020
        public void CreateVector4(){} // RVA: 0x7FFAC9DBC050
        public void UnPack(){} // RVA: 0x7FFAC9DBC170
        public void UnPackTo(){} // RVA: 0x7FFAC9DBC240
        public void Pack(){} // RVA: 0x7FFAC9DBC2D0
    }

    public class Vector4Array : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsVector4Array(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9DCDF30
        public void get_ValueLength(){} // RVA: 0x7FFAC9DA6550
        public void CreateVector4Array(){} // RVA: 0x7FFAC9DCE080
        public void StartVector4Array(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void StartValueVector(){} // RVA: 0x7FFAC9DCE100
        public void EndVector4Array(){} // RVA: 0x7FFAC9DCE130
        public void UnPack(){} // RVA: 0x7FFAC9DCE180
        public void UnPackTo(){} // RVA: 0x7FFAC9DCE230
        public void Pack(){} // RVA: 0x7FFAC9DCE440
    }

    public class Vector4ArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.Vector4T> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class Vector4ArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DCE630
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