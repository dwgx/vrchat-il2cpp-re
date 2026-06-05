// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 9
// Methods: 74

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class Quaternion
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_X(){} // RVA: 0x7FFAFA0BEF40
        public void get_Y(){} // RVA: 0x7FFAFA0D46A0
        public void get_Z(){} // RVA: 0x7FFAFA0D4880
        public void get_W(){} // RVA: 0x7FFAFA0D4AE0
        public void CreateQuaternion(){} // RVA: 0x7FFAFA0D4D90
        public void UnPack(){} // RVA: 0x7FFAFA0D4E70
        public void UnPackTo(){} // RVA: 0x7FFAFA0D4CC0
        public void Pack(){} // RVA: 0x7FFAFA0D4F40
    }

    public class QuaternionArray
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsQuaternionArray(){} // RVA: 0x7FFAFA0B7450 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void Value(){} // RVA: 0x7FFAFA0E6D00
        public void get_ValueLength(){} // RVA: 0x7FFAFA0BF6F0
        public void CreateQuaternionArray(){} // RVA: 0x7FFAFA0E6E50
        public void StartQuaternionArray(){} // RVA: 0x7FFAFA0BF310
        public void AddValue(){} // RVA: 0x7FFAFA0BF330
        public void StartValueVector(){} // RVA: 0x7FFAFA0E6760
        public void EndQuaternionArray(){} // RVA: 0x7FFAFA0E6ED0
        public void UnPack(){} // RVA: 0x7FFAFA0E6F20
        public void UnPackTo(){} // RVA: 0x7FFAFA0E6FD0
        public void Pack(){} // RVA: 0x7FFAFA0E71E0
    }

    public class QuaternionArrayT
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAF2DA8380
        public void set_Value(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAF81FFB20
    }

    public class QuaternionArrayVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0E6C90
    }

    public class QuaternionHalf
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void Data(){} // RVA: 0x7FFAFA0D4F80
        public void CreateQuaternionHalf(){} // RVA: 0x7FFAFA0D5BA0
        public void UnPack(){} // RVA: 0x7FFAFA0D5C70
        public void UnPackTo(){} // RVA: 0x7FFAFA0D5D50
        public void Pack(){} // RVA: 0x7FFAFA0D5E50
    }

    public class QuaternionHalfT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAF2DA8380
        public void set_Data(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAFA0D5F30
    }

    public class QuaternionT
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA08F4A0 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFAFA08EEC0 | overloaded x2
        public void ToNumerics(){} // RVA: 0x7FFAFA08EEE0
        public void op_Implicit(){} // RVA: 0x7FFAFA08EF00
        public void op_Explicit(){} // RVA: 0x7FFAFA0B9820
        public void get_identity(){} // RVA: 0x7FFAFA0B9880
        public void get_magnitude(){} // RVA: 0x7FFAFA0B98D0
        public void get_sqrMagnitude(){} // RVA: 0x7FFAFA08F090
        public void IsBad(){} // RVA: 0x7FFAFA08F0D0
        public void Normalize(){} // RVA: 0x7FFAFA0B9980
        public void ToString(){} // RVA: 0x7FFAFA0B9B10
        public void get_X(){} // RVA: 0x7FFAF2EB7320
        public void set_X(){} // RVA: 0x7FFAF2EB7330
        public void get_Y(){} // RVA: 0x7FFAF2EB7340
        public void set_Y(){} // RVA: 0x7FFAF2EB7350
        public void get_Z(){} // RVA: 0x7FFAF2D91CF0
        public void set_Z(){} // RVA: 0x7FFAF2DA84D0
        public void get_W(){} // RVA: 0x7FFAF2E5A570
        public void set_W(){} // RVA: 0x7FFAF2E5A580
    }

    public class QuaternionTenBit
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void Data(){} // RVA: 0x7FFAFA0D4F80
        public void CreateQuaternionTenBit(){} // RVA: 0x7FFAFA0D53D0
        public void UnPack(){} // RVA: 0x7FFAFA0D54A0
        public void UnPackTo(){} // RVA: 0x7FFAFA0D5510
        public void Pack(){} // RVA: 0x7FFAFA0D5610
    }

    public class QuaternionTenBitT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAF2DA8380
        public void set_Data(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAFA0D56F0
    }

}