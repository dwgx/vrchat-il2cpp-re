// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 9
// Methods: 72

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class Quaternion : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_X(){} // RVA: 0x7A7F16510
        public void get_Y(){} // RVA: 0x7A7F189C0
        public void get_Z(){} // RVA: 0x7A7F18A60
        public void get_W(){} // RVA: 0x7A7F18B20
        public void CreateQuaternion(){} // RVA: 0x7AF403970
        public void UnPack(){} // RVA: 0x7A7F18B70
        public void UnPackTo(){} // RVA: 0x7A7F18B60
        public void Pack(){} // RVA: 0x7AF403B20
    }

    public class QuaternionArray : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsQuaternionArray(){} // RVA: 0x7AF3E5C00
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void Value(){} // RVA: 0x7A7F1A230
        public void get_ValueLength(){} // RVA: 0x7A7F166F0
        public void CreateQuaternionArray(){} // RVA: 0x7AF415CC0
        public void StartQuaternionArray(){} // RVA: 0x7AF3EDBF0
        public void AddValue(){} // RVA: 0x7AF3EDC10
        public void StartValueVector(){} // RVA: 0x7AF4155A0
        public void EndQuaternionArray(){} // RVA: 0x7AF415D40
        public void UnPack(){} // RVA: 0x7A7F1A260
        public void UnPackTo(){} // RVA: 0x7A7F1A270
        public void Pack(){} // RVA: 0x7AF416050
    }

    public class QuaternionArrayT : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7A80F2570
        public void set_Value(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AD51EC30
    }

    public class QuaternionArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF415AF0
    }

    public class QuaternionHalf : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void Data(){} // RVA: 0x7A7F18B80
        public void CreateQuaternionHalf(){} // RVA: 0x7AF4047E0
        public void UnPack(){} // RVA: 0x7A7F18DB0
        public void UnPackTo(){} // RVA: 0x7A7F18E90
        public void Pack(){} // RVA: 0x7AF404AB0
    }

    public class QuaternionHalfT : Object
    {
        // ── Methods ──
        public void get_Data(){} // RVA: 0x7A80F2570
        public void set_Data(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AF404B90
    }

    public class QuaternionT : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF3BDA20
        public void CopyFrom(){} // RVA: 0x7AF3BD440
        public void ToNumerics(){} // RVA: 0x7AF3BD460
        public void op_Implicit(){} // RVA: 0x7AF3BD480
        public void op_Explicit(){} // RVA: 0x7AF3E8040
        public void get_identity(){} // RVA: 0x7AF3E80A0
        public void get_magnitude(){} // RVA: 0x7AF3E80F0
        public void get_sqrMagnitude(){} // RVA: 0x7AF3BD610
        public void IsBad(){} // RVA: 0x7AF3BD650
        public void Normalize(){} // RVA: 0x7AF3E81A0
        public void ToString(){} // RVA: 0x7AF3E8330
        public void get_X(){} // RVA: 0x7A82023C0
        public void set_X(){} // RVA: 0x7A82023D0
        public void get_Y(){} // RVA: 0x7A82023E0
        public void set_Y(){} // RVA: 0x7A82023F0
        public void get_Z(){} // RVA: 0x7A80DBCE0
        public void set_Z(){} // RVA: 0x7A80F26C0
        public void get_W(){} // RVA: 0x7A81A5180
        public void set_W(){} // RVA: 0x7A81A5190
        public void <X>k__BackingField(){} // RVA: 0x7B3FAD6B8
    }

    public class QuaternionTenBit : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void Data(){} // RVA: 0x7A7F18B80
        public void CreateQuaternionTenBit(){} // RVA: 0x7AF403FD0
        public void UnPack(){} // RVA: 0x7A7F18CA0
        public void UnPackTo(){} // RVA: 0x7A7F18CB0
        public void Pack(){} // RVA: 0x7AF404230
    }

    public class QuaternionTenBitT : Object
    {
        // ── Methods ──
        public void get_Data(){} // RVA: 0x7A80F2570
        public void set_Data(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AF404310
    }

}