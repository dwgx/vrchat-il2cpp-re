// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 21
// Methods: 166

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class Vector2 : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0xE1
        public object field_2; // 0xE2

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_X(){} // RVA: 0x7FFE8811DA60
        public void get_Y(){} // RVA: 0x7FFE88128960
        public void CreateVector2(){} // RVA: 0x7FFE88128990
        public void UnPack(){} // RVA: 0x7FFE88128A80
        public void UnPackTo(){} // RVA: 0x7FFE88128B10
        public void Pack(){} // RVA: 0x7FFE88128B70
    }

    public class Vector2Array : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x1A8

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsVector2Array(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8813DEC0
        public void get_ValueLength(){} // RVA: 0x7FFE8811E2C0
        public void CreateVector2Array(){} // RVA: 0x7FFE8813E020
        public void StartVector2Array(){} // RVA: 0x7FFE8811DF00
        public void AddValue(){} // RVA: 0x7FFE8811DF20
        public void StartValueVector(){} // RVA: 0x7FFE8813E0E0
        public void EndVector2Array(){} // RVA: 0x7FFE8813E110
        public void UnPack(){} // RVA: 0x7FFE8813E1A0
        public void UnPackTo(){} // RVA: 0x7FFE8813E250
        public void Pack(){} // RVA: 0x7FFE8813E460
    }

    public class Vector2ArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector2T> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class Vector2ArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8813A4C0
    }

    public class Vector2T : Object
    {
        public float _x; // 0x10
        public float _y; // 0x14
        public object field_2; // 0x85
        public object field_3; // 0x86
        public object field_4; // 0x87

        // ── Methods ──
        public void ToNumerics(){} // RVA: 0x7FFE83BB1530
        public void op_Implicit(){} // RVA: 0x7FFE8811C500
        public void op_Explicit(){} // RVA: 0x7FFE8811C530
        public void get_zero(){} // RVA: 0x7FFE8811C590
        public void .ctor(){} // RVA: 0x7FFE86D84AD0 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFE8811C600 | overloaded x2
        public void op_UnaryNegation(){} // RVA: 0x7FFE8811C620
        public void get_magnitude(){} // RVA: 0x7FFE8811C690
        public void get_sqrMagnitude(){} // RVA: 0x7FFE8811C720
        public void IsBad(){} // RVA: 0x7FFE8811C740
        public void get_X(){} // RVA: 0x7FFE81225320
        public void set_X(){} // RVA: 0x7FFE81225330
        public void get_Y(){} // RVA: 0x7FFE81225340
        public void set_Y(){} // RVA: 0x7FFE81225350
    }

    public class Vector3 : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0xE6
        public object field_2; // 0xE7
        public object field_3; // 0xE8

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_X(){} // RVA: 0x7FFE8811DA60
        public void get_Y(){} // RVA: 0x7FFE88128960
        public void get_Z(){} // RVA: 0x7FFE88128FD0
        public void CreateVector3(){} // RVA: 0x7FFE88129000
        public void UnPack(){} // RVA: 0x7FFE88129110
        public void UnPackTo(){} // RVA: 0x7FFE881291C0
        public void Pack(){} // RVA: 0x7FFE88129240
    }

    public class Vector3Array : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x1AB

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsVector3Array(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8813E640
        public void get_ValueLength(){} // RVA: 0x7FFE8811E2C0
        public void CreateVector3Array(){} // RVA: 0x7FFE8813E7A0
        public void StartVector3Array(){} // RVA: 0x7FFE8811DF00
        public void AddValue(){} // RVA: 0x7FFE8811DF20
        public void StartValueVector(){} // RVA: 0x7FFE8813E860
        public void EndVector3Array(){} // RVA: 0x7FFE8813E890
        public void UnPack(){} // RVA: 0x7FFE8813E920
        public void UnPackTo(){} // RVA: 0x7FFE8813E9D0
        public void Pack(){} // RVA: 0x7FFE8813EBE0
    }

    public class Vector3ArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector3T> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class Vector3ArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8813EDD0
    }

    public class Vector3Bytes : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Data(){} // RVA: 0x7FFE881228C0
        public void CreateVector3Bytes(){} // RVA: 0x7FFE88128B90
        public void UnPack(){} // RVA: 0x7FFE88128CA0
        public void UnPackTo(){} // RVA: 0x7FFE88128D10
        public void Pack(){} // RVA: 0x7FFE88128E10
    }

    public class Vector3BytesT : Object
    {
        public byte[] _data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFE81116380
        public void set_Data(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE88128F40
    }

    public class Vector3Half : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Data(){} // RVA: 0x7FFE881228C0
        public void CreateVector3Half(){} // RVA: 0x7FFE88129F10
        public void UnPack(){} // RVA: 0x7FFE8812A020
        public void UnPackTo(){} // RVA: 0x7FFE8812A090
        public void Pack(){} // RVA: 0x7FFE8812A190
    }

    public class Vector3HalfT : Object
    {
        public byte[] _data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFE81116380
        public void set_Data(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE8812A2C0
    }

    public class Vector3T : Object
    {
        public float _x; // 0x10
        public float _y; // 0x14
        public float _z; // 0x18
        public object field_3; // 0x8A
        public object field_4; // 0x8B
        public object field_5; // 0x8C

        // ── Methods ──
        public void ToNumerics(){} // RVA: 0x7FFE81D60500
        public void op_Implicit(){} // RVA: 0x7FFE8811C780
        public void op_Explicit(){} // RVA: 0x7FFE8811C7C0
        public void get_zero(){} // RVA: 0x7FFE8811C810
        public void .ctor(){} // RVA: 0x7FFE86E273F0 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFE8811C8B0 | overloaded x2
        public void get_magnitude(){} // RVA: 0x7FFE8811C8D0
        public void get_sqrMagnitude(){} // RVA: 0x7FFE8811C970
        public void IsBad(){} // RVA: 0x7FFE8811C9A0
        public void ToString(){} // RVA: 0x7FFE8811CA00
        public void get_X(){} // RVA: 0x7FFE81225320
        public void set_X(){} // RVA: 0x7FFE81225330
        public void get_Y(){} // RVA: 0x7FFE81225340
        public void set_Y(){} // RVA: 0x7FFE81225350
        public void get_Z(){} // RVA: 0x7FFE810FFCF0
        public void set_Z(){} // RVA: 0x7FFE811164D0
    }

    public class Vector3TenBit : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Data(){} // RVA: 0x7FFE881228C0
        public void CreateVector3TenBit(){} // RVA: 0x7FFE881297A0
        public void UnPack(){} // RVA: 0x7FFE881298B0
        public void UnPackTo(){} // RVA: 0x7FFE88129920
        public void Pack(){} // RVA: 0x7FFE88129A20
    }

    public class Vector3TenBitT : Object
    {
        public byte[] _data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFE81116380
        public void set_Data(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE88129A40
    }

    public class Vector4 : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0xEA
        public object field_2; // 0xEB
        public object field_3; // 0xEC
        public object field_4; // 0xED

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_X(){} // RVA: 0x7FFE8811DA60
        public void get_Y(){} // RVA: 0x7FFE88128960
        public void get_Z(){} // RVA: 0x7FFE88128FD0
        public void get_W(){} // RVA: 0x7FFE88129280
        public void CreateVector4(){} // RVA: 0x7FFE881292B0
        public void UnPack(){} // RVA: 0x7FFE881293D0
        public void UnPackTo(){} // RVA: 0x7FFE881294A0
        public void Pack(){} // RVA: 0x7FFE88129530
    }

    public class Vector4Array : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0x1AE

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsVector4Array(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE8813EE40
        public void get_ValueLength(){} // RVA: 0x7FFE8811E2C0
        public void CreateVector4Array(){} // RVA: 0x7FFE8813EF90
        public void StartVector4Array(){} // RVA: 0x7FFE8811DF00
        public void AddValue(){} // RVA: 0x7FFE8811DF20
        public void StartValueVector(){} // RVA: 0x7FFE8813F050
        public void EndVector4Array(){} // RVA: 0x7FFE8813F080
        public void UnPack(){} // RVA: 0x7FFE8813F110
        public void UnPackTo(){} // RVA: 0x7FFE8813F1C0
        public void Pack(){} // RVA: 0x7FFE8813F3D0
    }

    public class Vector4ArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector4T> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class Vector4ArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8813F5C0
    }

    public class Vector4T : Object
    {
        public float _x; // 0x10
        public float _y; // 0x14
        public float _z; // 0x18
        public float _w; // 0x1C

        // ── Methods ──
        public void get_X(){} // RVA: 0x7FFE81225320
        public void set_X(){} // RVA: 0x7FFE81225330
        public void get_Y(){} // RVA: 0x7FFE81225340
        public void set_Y(){} // RVA: 0x7FFE81225350
        public void get_Z(){} // RVA: 0x7FFE810FFCF0
        public void set_Z(){} // RVA: 0x7FFE811164D0
        public void get_W(){} // RVA: 0x7FFE811C8570
        public void set_W(){} // RVA: 0x7FFE811C8580
        public void .ctor(){} // RVA: 0x7FFE8811C4F0
    }

}