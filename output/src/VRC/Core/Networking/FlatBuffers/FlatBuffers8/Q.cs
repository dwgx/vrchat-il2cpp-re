// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 9
// Methods: 72

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class Quaternion : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_X(){} // RVA: 0x7A7F12600
        public void get_Y(){} // RVA: 0x7A7F13420
        public void get_Z(){} // RVA: 0x7A7F13520
        public void get_W(){} // RVA: 0x7A7F13600
        public void CreateQuaternion(){} // RVA: 0x7AF3CAA50
        public void UnPack(){} // RVA: 0x7A7F13670
        public void UnPackTo(){} // RVA: 0x7A7F13640
        public void Pack(){} // RVA: 0x7AF3CAC40
    }

    public class QuaternionArray : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsQuaternionArray(){} // RVA: 0x7AF3BF190
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void Value(){} // RVA: 0x7A7F15780
        public void get_ValueLength(){} // RVA: 0x7A7F12820
        public void CreateQuaternionArray(){} // RVA: 0x7AF3E0E10
        public void StartQuaternionArray(){} // RVA: 0x7AF3BF400
        public void AddValue(){} // RVA: 0x7AF3BF420
        public void StartValueVector(){} // RVA: 0x7AF3E06A0
        public void EndQuaternionArray(){} // RVA: 0x7AF3E0ED0
        public void UnPack(){} // RVA: 0x7A7F157B0
        public void UnPackTo(){} // RVA: 0x7A7F157C0
        public void Pack(){} // RVA: 0x7AF3E1220
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
        public void Verify(){} // RVA: 0x7AF3E0C40
    }

    public class QuaternionHalf : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void Data(){} // RVA: 0x7A7F12D70
        public void CreateQuaternionHalf(){} // RVA: 0x7AF3CB8B0
        public void UnPack(){} // RVA: 0x7A7F13760
        public void UnPackTo(){} // RVA: 0x7A7F13840
        public void Pack(){} // RVA: 0x7AF3CBBC0
    }

    public class QuaternionHalfT : Object
    {
        // ── Methods ──
        public void get_Data(){} // RVA: 0x7A80F2570
        public void set_Data(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AF3CBD00
    }

    public class QuaternionT : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF3BDA20
        public void CopyFrom(){} // RVA: 0x7AF3BD440
        public void ToNumerics(){} // RVA: 0x7AF3BD460
        public void op_Implicit(){} // RVA: 0x7AF3BD480
        public void op_Explicit(){} // RVA: 0x7AF3BD4B0
        public void get_identity(){} // RVA: 0x7AF3BD510
        public void get_magnitude(){} // RVA: 0x7AF3BD560
        public void get_sqrMagnitude(){} // RVA: 0x7AF3BD610
        public void IsBad(){} // RVA: 0x7AF3BD650
        public void Normalize(){} // RVA: 0x7AF3BD6D0
        public void ToString(){} // RVA: 0x7AF3BD7D0
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
        public void Data(){} // RVA: 0x7A7F12D70
        public void CreateQuaternionTenBit(){} // RVA: 0x7AF3CAFD0
        public void UnPack(){} // RVA: 0x7A7F136E0
        public void UnPackTo(){} // RVA: 0x7A7F136F0
        public void Pack(){} // RVA: 0x7AF3CB270
    }

    public class QuaternionTenBitT : Object
    {
        // ── Methods ──
        public void get_Data(){} // RVA: 0x7A80F2570
        public void set_Data(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AF3CB3B0
    }

}