// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 9
// Methods: 78

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class Quaternion : ValueType
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
        public void CreateQuaternion(){} // RVA: 0x7FFAC9DBC310
        public void UnPack(){} // RVA: 0x7FFAC9DBC430
        public void UnPackTo(){} // RVA: 0x7FFAC9DBC240
        public void Pack(){} // RVA: 0x7FFAC9DBC500
    }

    public class QuaternionArray : ValueType
    {
        public Google.FlatBuffers32.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsQuaternionArray(){} // RVA: 0x7FFAC9D9CB90 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9DCE6A0
        public void get_ValueLength(){} // RVA: 0x7FFAC9DA6550
        public void CreateQuaternionArray(){} // RVA: 0x7FFAC9DCE7F0
        public void StartQuaternionArray(){} // RVA: 0x7FFAC9DA6170
        public void AddValue(){} // RVA: 0x7FFAC9DA6190
        public void StartValueVector(){} // RVA: 0x7FFAC9DCE100
        public void EndQuaternionArray(){} // RVA: 0x7FFAC9DCE870
        public void UnPack(){} // RVA: 0x7FFAC9DCE8C0
        public void UnPackTo(){} // RVA: 0x7FFAC9DCE970
        public void Pack(){} // RVA: 0x7FFAC9DCEB80
    }

    public class QuaternionArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.QuaternionT> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class QuaternionArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9DCE630
    }

    public class QuaternionHalf : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Data(){} // RVA: 0x7FFAC9DBC540
        public void MutateData(){} // RVA: 0x7FFAC9DBC570
        public void CreateQuaternionHalf(){} // RVA: 0x7FFAC9DBD190
        public void UnPack(){} // RVA: 0x7FFAC9DBD260
        public void UnPackTo(){} // RVA: 0x7FFAC9DBD340
        public void Pack(){} // RVA: 0x7FFAC9DBD440
    }

    public class QuaternionHalfT : Object
    {
        public byte[] Data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAC2F3C380
        public void set_Data(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC9DBD520
    }

    public class QuaternionT : Object
    {
        public float identity; // 0x10
        public float magnitude; // 0x14
        public float sqrMagnitude; // 0x18
        public float X; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D72C50 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFAC9D722D0
        public void ToNumerics(){} // RVA: 0x7FFAC9D72300
        public void get_identity(){} // RVA: 0x7FFAC9D9F080
        public void get_magnitude(){} // RVA: 0x7FFAC9D9F0D0
        public void get_sqrMagnitude(){} // RVA: 0x7FFAC9D72420
        public void Slerp(){} // RVA: 0x7FFAC9D9F180
        public void op_Multiply(){} // RVA: 0x7FFAC9D9F260
        public void IsBad(){} // RVA: 0x7FFAC9D72880
        public void Normalize(){} // RVA: 0x7FFAC9D9F410
        public void get_X(){} // RVA: 0x7FFAC304B320
        public void set_X(){} // RVA: 0x7FFAC304B330
        public void get_Y(){} // RVA: 0x7FFAC304B340
        public void set_Y(){} // RVA: 0x7FFAC304B350
        public void get_Z(){} // RVA: 0x7FFAC2F25CF0
        public void set_Z(){} // RVA: 0x7FFAC2F3C4D0
        public void get_W(){} // RVA: 0x7FFAC2FEE570
        public void set_W(){} // RVA: 0x7FFAC2FEE580
    }

    public class QuaternionTenBit : ValueType
    {
        public Google.FlatBuffers32.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Data(){} // RVA: 0x7FFAC9DBC540
        public void MutateData(){} // RVA: 0x7FFAC9DBC570
        public void CreateQuaternionTenBit(){} // RVA: 0x7FFAC9DBC9C0
        public void UnPack(){} // RVA: 0x7FFAC9DBCA90
        public void UnPackTo(){} // RVA: 0x7FFAC9DBCB00
        public void Pack(){} // RVA: 0x7FFAC9DBCC00
    }

    public class QuaternionTenBitT : Object
    {
        public byte[] Data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAC2F3C380
        public void set_Data(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC9DBCCE0
    }

}