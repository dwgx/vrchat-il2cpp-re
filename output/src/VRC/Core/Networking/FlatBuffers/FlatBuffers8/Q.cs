// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 9
// Methods: 71

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class Quaternion : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_X(){} // RVA: 0x9B56F0
        public void get_Y(){} // RVA: 0x9B6D30
        public void get_Z(){} // RVA: 0x9B6F70
        public void get_W(){} // RVA: 0x9B70F0
        public void CreateQuaternion(){} // RVA: 0x8222F30
        public void UnPack(){} // RVA: 0x9B7200
        public void UnPackTo(){} // RVA: 0x9B7130
        public void Pack(){} // RVA: 0x8223120
    }

    public class QuaternionArray : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsQuaternionArray(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9BB270
        public void get_ValueLength(){} // RVA: 0x9B5A50
        public void CreateQuaternionArray(){} // RVA: 0x823A710
        public void StartQuaternionArray(){} // RVA: 0x8217590
        public void AddValue(){} // RVA: 0x82175B0
        public void StartValueVector(){} // RVA: 0x8239FA0
        public void EndQuaternionArray(){} // RVA: 0x823A7D0
        public void UnPack(){} // RVA: 0x9BB2A0
        public void UnPackTo(){} // RVA: 0x9BB2B0
        public void Pack(){} // RVA: 0x823AB20
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
        public void Verify(){} // RVA: 0x823A540
    }

    public class QuaternionHalf : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Data(){} // RVA: 0x9B6360
        public void CreateQuaternionHalf(){} // RVA: 0x8223D90
        public void UnPack(){} // RVA: 0x9B7570
        public void UnPackTo(){} // RVA: 0x9B7650
        public void Pack(){} // RVA: 0x82240A0
    }

    public class QuaternionHalfT : Object
    {
        // ── Methods ──
        public void get_Data(){} // RVA: 0xB5DBF0
        public void set_Data(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x82241E0
    }

    public class QuaternionT : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8215970
        public void CopyFrom(){} // RVA: 0x82153A0
        public void ToNumerics(){} // RVA: 0x82153C0
        public void op_Implicit(){} // RVA: 0x82153E0
        public void op_Explicit(){} // RVA: 0x8215410
        public void get_identity(){} // RVA: 0x8215470
        public void get_magnitude(){} // RVA: 0x82154C0
        public void get_sqrMagnitude(){} // RVA: 0x8215570
        public void IsBad(){} // RVA: 0x82155B0
        public void Normalize(){} // RVA: 0x8215630
        public void ToString(){} // RVA: 0x8215730
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
        public void Data(){} // RVA: 0x9B6360
        public void CreateQuaternionTenBit(){} // RVA: 0x82234B0
        public void UnPack(){} // RVA: 0x9B73B0
        public void UnPackTo(){} // RVA: 0x9B73C0
        public void Pack(){} // RVA: 0x8223750
    }

    public class QuaternionTenBitT : Object
    {
        // ── Methods ──
        public void get_Data(){} // RVA: 0xB5DBF0
        public void set_Data(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x8223890
    }

}