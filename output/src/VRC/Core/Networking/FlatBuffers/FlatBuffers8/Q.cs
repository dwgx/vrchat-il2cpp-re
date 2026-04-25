// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 9
// Methods: 81

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class Quaternion : ValueType
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
        public void CreateQuaternion(){} // RVA: 0x7FFAC9D814B0
        public void UnPack(){} // RVA: 0x7FFAC9D81620
        public void UnPackTo(){} // RVA: 0x7FFAC9D813E0
        public void Pack(){} // RVA: 0x7FFAC9D816F0
    }

    public class QuaternionArray : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsQuaternionArray(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Value(){} // RVA: 0x7FFAC9D97D20
        public void get_ValueLength(){} // RVA: 0x7FFAC9D75CA0
        public void CreateQuaternionArray(){} // RVA: 0x7FFAC9D97E70
        public void StartQuaternionArray(){} // RVA: 0x7FFAC9D758E0
        public void AddValue(){} // RVA: 0x7FFAC9D75900
        public void StartValueVector(){} // RVA: 0x7FFAC9D97740
        public void EndQuaternionArray(){} // RVA: 0x7FFAC9D97F30
        public void UnPack(){} // RVA: 0x7FFAC9D97FC0
        public void UnPackTo(){} // RVA: 0x7FFAC9D98070
        public void Pack(){} // RVA: 0x7FFAC9D98280
    }

    public class QuaternionArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.QuaternionT> Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC7DDDC00
    }

    public class QuaternionArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D97CB0
    }

    public class QuaternionHalf : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Data(){} // RVA: 0x7FFAC9D7A3F0
        public void MutateData(){} // RVA: 0x7FFAC9D7A420
        public void CreateQuaternionHalf(){} // RVA: 0x7FFAC9D822E0
        public void UnPack(){} // RVA: 0x7FFAC9D823F0
        public void UnPackTo(){} // RVA: 0x7FFAC9D824D0
        public void Pack(){} // RVA: 0x7FFAC9D825D0
    }

    public class QuaternionHalfT : Object
    {
        public byte[] Data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAC2F3C380
        public void set_Data(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC9D82700
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
        public void get_identity(){} // RVA: 0x7FFAC9D72320
        public void get_magnitude(){} // RVA: 0x7FFAC9D72370
        public void get_sqrMagnitude(){} // RVA: 0x7FFAC9D72420
        public void Slerp(){} // RVA: 0x7FFAC9D72540 | overloaded x2
        public void Inverse(){} // RVA: 0x7FFAC9D725D0
        public void op_Multiply(){} // RVA: 0x7FFAC9D726D0
        public void IsBad(){} // RVA: 0x7FFAC9D72880
        public void Normalize(){} // RVA: 0x7FFAC9D72900
        public void ToString(){} // RVA: 0x7FFAC9D72A00
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
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Data(){} // RVA: 0x7FFAC9D7A3F0
        public void MutateData(){} // RVA: 0x7FFAC9D7A420
        public void CreateQuaternionTenBit(){} // RVA: 0x7FFAC9D81A60
        public void UnPack(){} // RVA: 0x7FFAC9D81B70
        public void UnPackTo(){} // RVA: 0x7FFAC9D81BE0
        public void Pack(){} // RVA: 0x7FFAC9D81CE0
    }

    public class QuaternionTenBitT : Object
    {
        public byte[] Data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAC2F3C380
        public void set_Data(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC9D81E10
    }

}