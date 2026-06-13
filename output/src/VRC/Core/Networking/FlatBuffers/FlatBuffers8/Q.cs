// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 9
// Methods: 74

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class Quaternion
    {
        public Google.FlatBuffers8.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_X(){} // RVA: 0x75E0A10
        public void get_Y(){} // RVA: 0x75EB910
        public void get_Z(){} // RVA: 0x75EBF80
        public void get_W(){} // RVA: 0x75EC230
        public void CreateQuaternion(){} // RVA: 0x75EC520
        public void UnPack(){} // RVA: 0x75EC640
        public void UnPackTo(){} // RVA: 0x75EC450
        public void Pack(){} // RVA: 0x75EC710
    }

    public class QuaternionArray
    {
        public Google.FlatBuffers8.Table __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsQuaternionArray(){} // RVA: 0x75E0C40 | overloaded x2
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Value(){} // RVA: 0x76025E0
        public void get_ValueLength(){} // RVA: 0x75E1270
        public void CreateQuaternionArray(){} // RVA: 0x7602730
        public void StartQuaternionArray(){} // RVA: 0x75E0EB0
        public void AddValue(){} // RVA: 0x75E0ED0
        public void StartValueVector(){} // RVA: 0x7602000
        public void EndQuaternionArray(){} // RVA: 0x76027F0
        public void UnPack(){} // RVA: 0x7602880
        public void UnPackTo(){} // RVA: 0x7602930
        public void Pack(){} // RVA: 0x7602B40
    }

    public class QuaternionArrayT
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.QuaternionT> <Value>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x574FB20
    }

    public class QuaternionArrayVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7602570
    }

    public class QuaternionHalf
    {
        public Google.FlatBuffers8.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Data(){} // RVA: 0x75E5870
        public void CreateQuaternionHalf(){} // RVA: 0x75ED300
        public void UnPack(){} // RVA: 0x75ED410
        public void UnPackTo(){} // RVA: 0x75ED4F0
        public void Pack(){} // RVA: 0x75ED5F0
    }

    public class QuaternionHalfT
    {
        public byte[] ByteBuffer; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x2F8380
        public void set_Data(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x75ED720
    }

    public class QuaternionT
    {
        public float <X>k__BackingField; // 0x10
        public float <Y>k__BackingField; // 0x14
        public float <Z>k__BackingField; // 0x18
        public float <W>k__BackingField; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75DF4A0 | overloaded x2
        public void CopyFrom(){} // RVA: 0x75DEEC0 | overloaded x2
        public void ToNumerics(){} // RVA: 0x75DEEE0
        public void op_Implicit(){} // RVA: 0x75DEF00
        public void op_Explicit(){} // RVA: 0x75DEF30
        public void get_identity(){} // RVA: 0x75DEF90
        public void get_magnitude(){} // RVA: 0x75DEFE0
        public void get_sqrMagnitude(){} // RVA: 0x75DF090
        public void IsBad(){} // RVA: 0x75DF0D0
        public void Normalize(){} // RVA: 0x75DF150
        public void ToString(){} // RVA: 0x75DF250
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
        public Google.FlatBuffers8.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Data(){} // RVA: 0x75E5870
        public void CreateQuaternionTenBit(){} // RVA: 0x75ECA80
        public void UnPack(){} // RVA: 0x75ECB90
        public void UnPackTo(){} // RVA: 0x75ECC00
        public void Pack(){} // RVA: 0x75ECD00
    }

    public class QuaternionTenBitT
    {
        public byte[] ByteBuffer; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x2F8380
        public void set_Data(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x75ECE30
    }

}