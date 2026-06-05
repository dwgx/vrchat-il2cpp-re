// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 9
// Methods: 74

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class Quaternion
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_X(){} // RVA: 0x7FFAFA090A10
        public void get_Y(){} // RVA: 0x7FFAFA09B910
        public void get_Z(){} // RVA: 0x7FFAFA09BF80
        public void get_W(){} // RVA: 0x7FFAFA09C230
        public void CreateQuaternion(){} // RVA: 0x7FFAFA09C520
        public void UnPack(){} // RVA: 0x7FFAFA09C640
        public void UnPackTo(){} // RVA: 0x7FFAFA09C450
        public void Pack(){} // RVA: 0x7FFAFA09C710
    }

    public class QuaternionArray
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsQuaternionArray(){} // RVA: 0x7FFAFA090C40 | overloaded x2
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void Value(){} // RVA: 0x7FFAFA0B25E0
        public void get_ValueLength(){} // RVA: 0x7FFAFA091270
        public void CreateQuaternionArray(){} // RVA: 0x7FFAFA0B2730
        public void StartQuaternionArray(){} // RVA: 0x7FFAFA090EB0
        public void AddValue(){} // RVA: 0x7FFAFA090ED0
        public void StartValueVector(){} // RVA: 0x7FFAFA0B2000
        public void EndQuaternionArray(){} // RVA: 0x7FFAFA0B27F0
        public void UnPack(){} // RVA: 0x7FFAFA0B2880
        public void UnPackTo(){} // RVA: 0x7FFAFA0B2930
        public void Pack(){} // RVA: 0x7FFAFA0B2B40
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
        public void Verify(){} // RVA: 0x7FFAFA0B2570
    }

    public class QuaternionHalf
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void Data(){} // RVA: 0x7FFAFA095870
        public void CreateQuaternionHalf(){} // RVA: 0x7FFAFA09D300
        public void UnPack(){} // RVA: 0x7FFAFA09D410
        public void UnPackTo(){} // RVA: 0x7FFAFA09D4F0
        public void Pack(){} // RVA: 0x7FFAFA09D5F0
    }

    public class QuaternionHalfT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAF2DA8380
        public void set_Data(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAFA09D720
    }

    public class QuaternionT
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA08F4A0 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFAFA08EEC0 | overloaded x2
        public void ToNumerics(){} // RVA: 0x7FFAFA08EEE0
        public void op_Implicit(){} // RVA: 0x7FFAFA08EF00
        public void op_Explicit(){} // RVA: 0x7FFAFA08EF30
        public void get_identity(){} // RVA: 0x7FFAFA08EF90
        public void get_magnitude(){} // RVA: 0x7FFAFA08EFE0
        public void get_sqrMagnitude(){} // RVA: 0x7FFAFA08F090
        public void IsBad(){} // RVA: 0x7FFAFA08F0D0
        public void Normalize(){} // RVA: 0x7FFAFA08F150
        public void ToString(){} // RVA: 0x7FFAFA08F250
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
        public void Data(){} // RVA: 0x7FFAFA095870
        public void CreateQuaternionTenBit(){} // RVA: 0x7FFAFA09CA80
        public void UnPack(){} // RVA: 0x7FFAFA09CB90
        public void UnPackTo(){} // RVA: 0x7FFAFA09CC00
        public void Pack(){} // RVA: 0x7FFAFA09CD00
    }

    public class QuaternionTenBitT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAF2DA8380
        public void set_Data(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAFA09CE30
    }

}