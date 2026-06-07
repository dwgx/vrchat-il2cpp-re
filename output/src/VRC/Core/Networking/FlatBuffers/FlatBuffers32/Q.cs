// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 9
// Methods: 74

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class Quaternion
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_X(){} // RVA: 0x760EF40
        public void get_Y(){} // RVA: 0x76246A0
        public void get_Z(){} // RVA: 0x7624880
        public void get_W(){} // RVA: 0x7624AE0
        public void CreateQuaternion(){} // RVA: 0x7624D90
        public void UnPack(){} // RVA: 0x7624E70
        public void UnPackTo(){} // RVA: 0x7624CC0
        public void Pack(){} // RVA: 0x7624F40
    }

    public class QuaternionArray
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsQuaternionArray(){} // RVA: 0x7607450 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Value(){} // RVA: 0x7636D00
        public void get_ValueLength(){} // RVA: 0x760F6F0
        public void CreateQuaternionArray(){} // RVA: 0x7636E50
        public void StartQuaternionArray(){} // RVA: 0x760F310
        public void AddValue(){} // RVA: 0x760F330
        public void StartValueVector(){} // RVA: 0x7636760
        public void EndQuaternionArray(){} // RVA: 0x7636ED0
        public void UnPack(){} // RVA: 0x7636F20
        public void UnPackTo(){} // RVA: 0x7636FD0
        public void Pack(){} // RVA: 0x76371E0
    }

    public class QuaternionArrayT
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class QuaternionArrayVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7636C90
    }

    public class QuaternionHalf
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Data(){} // RVA: 0x7624F80
        public void CreateQuaternionHalf(){} // RVA: 0x7625BA0
        public void UnPack(){} // RVA: 0x7625C70
        public void UnPackTo(){} // RVA: 0x7625D50
        public void Pack(){} // RVA: 0x7625E50
    }

    public class QuaternionHalfT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Data(){} // RVA: 0x2F8380
        public void set_Data(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x7625F30
    }

    public class QuaternionT
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x75DF4A0 | overloaded x2
        public void CopyFrom(){} // RVA: 0x75DEEC0 | overloaded x2
        public void ToNumerics(){} // RVA: 0x75DEEE0
        public void op_Implicit(){} // RVA: 0x75DEF00
        public void op_Explicit(){} // RVA: 0x7609820
        public void get_identity(){} // RVA: 0x7609880
        public void get_magnitude(){} // RVA: 0x76098D0
        public void get_sqrMagnitude(){} // RVA: 0x75DF090
        public void IsBad(){} // RVA: 0x75DF0D0
        public void Normalize(){} // RVA: 0x7609980
        public void ToString(){} // RVA: 0x7609B10
        public void get_X(){} // RVA: 0x407320
        public void set_X(){} // RVA: 0x407330
        public void get_Y(){} // RVA: 0x407340
        public void set_Y(){} // RVA: 0x407350
        public void get_Z(){} // RVA: 0x2E1CF0
        public void set_Z(){} // RVA: 0x2F84D0
        public void get_W(){} // RVA: 0x3AA570
        public void set_W(){} // RVA: 0x3AA580
    }

    public class QuaternionTenBit
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Data(){} // RVA: 0x7624F80
        public void CreateQuaternionTenBit(){} // RVA: 0x76253D0
        public void UnPack(){} // RVA: 0x76254A0
        public void UnPackTo(){} // RVA: 0x7625510
        public void Pack(){} // RVA: 0x7625610
    }

    public class QuaternionTenBitT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Data(){} // RVA: 0x2F8380
        public void set_Data(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x76256F0
    }

}