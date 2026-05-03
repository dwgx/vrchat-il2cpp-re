// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 9
// Methods: 74

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class Quaternion : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0xF3
        public object field_2; // 0xF4
        public object field_3; // 0xF5
        public object field_4; // 0xF6

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_X(){} // RVA: 0x7FFE8811DA60
        public void get_Y(){} // RVA: 0x7FFE88128960
        public void get_Z(){} // RVA: 0x7FFE88128FD0
        public void get_W(){} // RVA: 0x7FFE88129280
        public void CreateQuaternion(){} // RVA: 0x7FFE88129570
        public void UnPack(){} // RVA: 0x7FFE88129690
        public void UnPackTo(){} // RVA: 0x7FFE881294A0
        public void Pack(){} // RVA: 0x7FFE88129760
    }

    public class QuaternionArray : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x1B1

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsQuaternionArray(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8813F630
        public void get_ValueLength(){} // RVA: 0x7FFE8811E2C0
        public void CreateQuaternionArray(){} // RVA: 0x7FFE8813F780
        public void StartQuaternionArray(){} // RVA: 0x7FFE8811DF00
        public void AddValue(){} // RVA: 0x7FFE8811DF20
        public void StartValueVector(){} // RVA: 0x7FFE8813F050
        public void EndQuaternionArray(){} // RVA: 0x7FFE8813F840
        public void UnPack(){} // RVA: 0x7FFE8813F8D0
        public void UnPackTo(){} // RVA: 0x7FFE8813F980
        public void Pack(){} // RVA: 0x7FFE8813FB90
    }

    public class QuaternionArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.QuaternionT> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class QuaternionArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8813F5C0
    }

    public class QuaternionHalf : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Data(){} // RVA: 0x7FFE881228C0
        public void CreateQuaternionHalf(){} // RVA: 0x7FFE8812A350
        public void UnPack(){} // RVA: 0x7FFE8812A460
        public void UnPackTo(){} // RVA: 0x7FFE8812A540
        public void Pack(){} // RVA: 0x7FFE8812A640
    }

    public class QuaternionHalfT : Object
    {
        public byte[] _data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFE81116380
        public void set_Data(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE8812A770
    }

    public class QuaternionT : Object
    {
        public float _x; // 0x10
        public float _y; // 0x14
        public float _z; // 0x18
        public float _w; // 0x1C
        public object field_4; // 0x7E
        public object field_5; // 0x7F
        public object field_6; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8811C4F0 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFE8811BF10 | overloaded x2
        public void ToNumerics(){} // RVA: 0x7FFE8811BF30
        public void op_Implicit(){} // RVA: 0x7FFE8811BF50
        public void op_Explicit(){} // RVA: 0x7FFE8811BF80
        public void get_identity(){} // RVA: 0x7FFE8811BFE0
        public void get_magnitude(){} // RVA: 0x7FFE8811C030
        public void get_sqrMagnitude(){} // RVA: 0x7FFE8811C0E0
        public void IsBad(){} // RVA: 0x7FFE8811C120
        public void Normalize(){} // RVA: 0x7FFE8811C1A0
        public void ToString(){} // RVA: 0x7FFE8811C2A0
        public void get_X(){} // RVA: 0x7FFE81225320
        public void set_X(){} // RVA: 0x7FFE81225330
        public void get_Y(){} // RVA: 0x7FFE81225340
        public void set_Y(){} // RVA: 0x7FFE81225350
        public void get_Z(){} // RVA: 0x7FFE810FFCF0
        public void set_Z(){} // RVA: 0x7FFE811164D0
        public void get_W(){} // RVA: 0x7FFE811C8570
        public void set_W(){} // RVA: 0x7FFE811C8580
    }

    public class QuaternionTenBit : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Data(){} // RVA: 0x7FFE881228C0
        public void CreateQuaternionTenBit(){} // RVA: 0x7FFE88129AD0
        public void UnPack(){} // RVA: 0x7FFE88129BE0
        public void UnPackTo(){} // RVA: 0x7FFE88129C50
        public void Pack(){} // RVA: 0x7FFE88129D50
    }

    public class QuaternionTenBitT : Object
    {
        public byte[] _data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFE81116380
        public void set_Data(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE88129E80
    }

}