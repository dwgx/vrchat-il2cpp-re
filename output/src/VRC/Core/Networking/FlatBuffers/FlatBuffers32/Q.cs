// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 9
// Methods: 71

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class Quaternion : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_X(){} // RVA: 0x9BC560
        public void get_Y(){} // RVA: 0x9BFF70
        public void get_Z(){} // RVA: 0x9C00D0
        public void get_W(){} // RVA: 0x9C0250
        public void CreateQuaternion(){} // RVA: 0x825DC00
        public void UnPack(){} // RVA: 0x9C0360
        public void UnPackTo(){} // RVA: 0x9C0290
        public void Pack(){} // RVA: 0x825DDB0
    }

    public class QuaternionArray : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsQuaternionArray(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9C3920
        public void get_ValueLength(){} // RVA: 0x9BC8C0
        public void CreateQuaternionArray(){} // RVA: 0x82709E0
        public void StartQuaternionArray(){} // RVA: 0x82476C0
        public void AddValue(){} // RVA: 0x82476E0
        public void StartValueVector(){} // RVA: 0x82702C0
        public void EndQuaternionArray(){} // RVA: 0x8270A60
        public void UnPack(){} // RVA: 0x9C3950
        public void UnPackTo(){} // RVA: 0x9C3960
        public void Pack(){} // RVA: 0x8270D70
    }

    public class QuaternionArrayT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class QuaternionArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8270810
    }

    public class QuaternionHalf : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Data(){} // RVA: 0x9C0430
        public void CreateQuaternionHalf(){} // RVA: 0x825EA70
        public void UnPack(){} // RVA: 0x9C08A0
        public void UnPackTo(){} // RVA: 0x9C0980
        public void Pack(){} // RVA: 0x825ED40
    }

    public class QuaternionHalfT : Object
    {
        // ── Methods ──
        public void get_Data(){} // RVA: 0xB5DBF0
        public void set_Data(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x825EE20
    }

    public class QuaternionT : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8215970
        public void CopyFrom(){} // RVA: 0x82153A0
        public void ToNumerics(){} // RVA: 0x82153C0
        public void op_Implicit(){} // RVA: 0x82153E0
        public void op_Explicit(){} // RVA: 0x8241940
        public void get_identity(){} // RVA: 0x82419A0
        public void get_magnitude(){} // RVA: 0x82419F0
        public void get_sqrMagnitude(){} // RVA: 0x8215570
        public void IsBad(){} // RVA: 0x82155B0
        public void Normalize(){} // RVA: 0x8241AA0
        public void ToString(){} // RVA: 0x8241C30
        public void get_X(){} // RVA: 0xC763E0
        public void set_X(){} // RVA: 0xC763F0
        public void get_Y(){} // RVA: 0xC76400
        public void set_Y(){} // RVA: 0xC76410
        public void get_Z(){} // RVA: 0xB47B50
        public void set_Z(){} // RVA: 0xB5DD40
        public void get_W(){} // RVA: 0xC152D0
        public void set_W(){} // RVA: 0xC152E0
    }

    public class QuaternionTenBit : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Data(){} // RVA: 0x9C0430
        public void CreateQuaternionTenBit(){} // RVA: 0x825E260
        public void UnPack(){} // RVA: 0x9C0610
        public void UnPackTo(){} // RVA: 0x9C0620
        public void Pack(){} // RVA: 0x825E4C0
    }

    public class QuaternionTenBitT : Object
    {
        // ── Methods ──
        public void get_Data(){} // RVA: 0xB5DBF0
        public void set_Data(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x825E5A0
    }

}