// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 9
// Methods: 74

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class Quaternion : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x2A3
        public object field_2; // 0x2A4
        public object field_3; // 0x2A5
        public object field_4; // 0x2A6

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_X(){} // RVA: 0x7FFE8814BF90
        public void get_Y(){} // RVA: 0x7FFE881616F0
        public void get_Z(){} // RVA: 0x7FFE881618D0
        public void get_W(){} // RVA: 0x7FFE88161B30
        public void CreateQuaternion(){} // RVA: 0x7FFE88161DE0
        public void UnPack(){} // RVA: 0x7FFE88161EC0
        public void UnPackTo(){} // RVA: 0x7FFE88161D10
        public void Pack(){} // RVA: 0x7FFE88161F90
    }

    public class QuaternionArray : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x32F

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsQuaternionArray(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE88173D50
        public void get_ValueLength(){} // RVA: 0x7FFE8814C740
        public void CreateQuaternionArray(){} // RVA: 0x7FFE88173EA0
        public void StartQuaternionArray(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void StartValueVector(){} // RVA: 0x7FFE881737B0
        public void EndQuaternionArray(){} // RVA: 0x7FFE88173F20
        public void UnPack(){} // RVA: 0x7FFE88173F70
        public void UnPackTo(){} // RVA: 0x7FFE88174020
        public void Pack(){} // RVA: 0x7FFE88174230
    }

    public class QuaternionArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.QuaternionT> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class QuaternionArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE88173CE0
    }

    public class QuaternionHalf : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Data(){} // RVA: 0x7FFE88161FD0
        public void CreateQuaternionHalf(){} // RVA: 0x7FFE88162BF0
        public void UnPack(){} // RVA: 0x7FFE88162CC0
        public void UnPackTo(){} // RVA: 0x7FFE88162DA0
        public void Pack(){} // RVA: 0x7FFE88162EA0
    }

    public class QuaternionHalfT : Object
    {
        public byte[] _data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFE81116380
        public void set_Data(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE88162F80
    }

    public class QuaternionT : Object
    {
        public float _x; // 0x10
        public float _y; // 0x14
        public float _z; // 0x18
        public float _w; // 0x1C
        public object field_4; // 0x1CB
        public object field_5; // 0x1CC
        public object field_6; // 0x1CD

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8811C4F0 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFE8811BF10 | overloaded x2
        public void ToNumerics(){} // RVA: 0x7FFE8811BF30
        public void op_Implicit(){} // RVA: 0x7FFE8811BF50
        public void op_Explicit(){} // RVA: 0x7FFE88146870
        public void get_identity(){} // RVA: 0x7FFE881468D0
        public void get_magnitude(){} // RVA: 0x7FFE88146920
        public void get_sqrMagnitude(){} // RVA: 0x7FFE8811C0E0
        public void IsBad(){} // RVA: 0x7FFE8811C120
        public void Normalize(){} // RVA: 0x7FFE881469D0
        public void ToString(){} // RVA: 0x7FFE88146B60
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
        public Google.FlatBuffers32.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Data(){} // RVA: 0x7FFE88161FD0
        public void CreateQuaternionTenBit(){} // RVA: 0x7FFE88162420
        public void UnPack(){} // RVA: 0x7FFE881624F0
        public void UnPackTo(){} // RVA: 0x7FFE88162560
        public void Pack(){} // RVA: 0x7FFE88162660
    }

    public class QuaternionTenBitT : Object
    {
        public byte[] _data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFE81116380
        public void set_Data(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE88162740
    }

}