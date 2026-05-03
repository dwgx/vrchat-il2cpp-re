// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 19
// Methods: 155

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class Vector2 : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x293
        public object field_2; // 0x294

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_X(){} // RVA: 0x7FFE8814BF90
        public void get_Y(){} // RVA: 0x7FFE881616F0
        public void CreateVector2(){} // RVA: 0x7FFE88161720
        public void UnPack(){} // RVA: 0x7FFE881617C0
        public void UnPackTo(){} // RVA: 0x7FFE88161850
        public void Pack(){} // RVA: 0x7FFE881618B0
    }

    public class Vector2Array : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x326

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsVector2Array(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE88172780
        public void get_ValueLength(){} // RVA: 0x7FFE8814C740
        public void CreateVector2Array(){} // RVA: 0x7FFE881728D0
        public void StartVector2Array(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void StartValueVector(){} // RVA: 0x7FFE88172950
        public void EndVector2Array(){} // RVA: 0x7FFE88172980
        public void UnPack(){} // RVA: 0x7FFE881729D0
        public void UnPackTo(){} // RVA: 0x7FFE88172A80
        public void Pack(){} // RVA: 0x7FFE88172C90
    }

    public class Vector2ArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.Vector2T> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class Vector2ArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE8816EC10
    }

    public class Vector2T : Object
    {
        public float _x; // 0x10
        public float _y; // 0x14
        public object field_2; // 0x1D2
        public object field_3; // 0x1D3
        public object field_4; // 0x1D4

        // ── Methods ──
        public void ToNumerics(){} // RVA: 0x7FFE83BB1530
        public void op_Implicit(){} // RVA: 0x7FFE8811C500
        public void op_Explicit(){} // RVA: 0x7FFE88146DB0
        public void get_zero(){} // RVA: 0x7FFE88146E10
        public void .ctor(){} // RVA: 0x7FFE86D84AD0 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFE8811C600 | overloaded x2
        public void op_UnaryNegation(){} // RVA: 0x7FFE88146E50
        public void get_magnitude(){} // RVA: 0x7FFE88146EC0
        public void get_sqrMagnitude(){} // RVA: 0x7FFE8811C720
        public void IsBad(){} // RVA: 0x7FFE8811C740
        public void get_X(){} // RVA: 0x7FFE81225320
        public void set_X(){} // RVA: 0x7FFE81225330
        public void get_Y(){} // RVA: 0x7FFE81225340
        public void set_Y(){} // RVA: 0x7FFE81225350
    }

    public class Vector3 : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x296
        public object field_2; // 0x297
        public object field_3; // 0x298

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_X(){} // RVA: 0x7FFE8814BF90
        public void get_Y(){} // RVA: 0x7FFE881616F0
        public void get_Z(){} // RVA: 0x7FFE881618D0
        public void CreateVector3(){} // RVA: 0x7FFE88161900
        public void UnPack(){} // RVA: 0x7FFE881619C0
        public void UnPackTo(){} // RVA: 0x7FFE88161A70
        public void Pack(){} // RVA: 0x7FFE88161AF0
    }

    public class Vector3Array : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x329

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsVector3Array(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE88172E70
        public void get_ValueLength(){} // RVA: 0x7FFE8814C740
        public void CreateVector3Array(){} // RVA: 0x7FFE88172FD0
        public void StartVector3Array(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void StartValueVector(){} // RVA: 0x7FFE88173050
        public void EndVector3Array(){} // RVA: 0x7FFE88173080
        public void UnPack(){} // RVA: 0x7FFE881730D0
        public void UnPackTo(){} // RVA: 0x7FFE88173180
        public void Pack(){} // RVA: 0x7FFE88173390
    }

    public class Vector3ArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.Vector3T> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class Vector3ArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE88173570
    }

    public class Vector3Half : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Data(){} // RVA: 0x7FFE88161FD0
        public void CreateVector3Half(){} // RVA: 0x7FFE881627D0
        public void UnPack(){} // RVA: 0x7FFE881628A0
        public void UnPackTo(){} // RVA: 0x7FFE88162980
        public void Pack(){} // RVA: 0x7FFE88162A80
    }

    public class Vector3HalfT : Object
    {
        public byte[] _data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFE81116380
        public void set_Data(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE88162B60
    }

    public class Vector3T : Object
    {
        public float _x; // 0x10
        public float _y; // 0x14
        public float _z; // 0x18
        public object field_3; // 0x1D7
        public object field_4; // 0x1D8
        public object field_5; // 0x1D9

        // ── Methods ──
        public void ToNumerics(){} // RVA: 0x7FFE81D60500
        public void op_Implicit(){} // RVA: 0x7FFE8811C780
        public void op_Explicit(){} // RVA: 0x7FFE88146F50
        public void get_zero(){} // RVA: 0x7FFE88146FA0
        public void .ctor(){} // RVA: 0x7FFE86E273F0 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFE8811C8B0 | overloaded x2
        public void get_magnitude(){} // RVA: 0x7FFE88146FE0
        public void get_sqrMagnitude(){} // RVA: 0x7FFE8811C970
        public void IsBad(){} // RVA: 0x7FFE8811C9A0
        public void ToString(){} // RVA: 0x7FFE88147080
        public void get_X(){} // RVA: 0x7FFE81225320
        public void set_X(){} // RVA: 0x7FFE81225330
        public void get_Y(){} // RVA: 0x7FFE81225340
        public void set_Y(){} // RVA: 0x7FFE81225350
        public void get_Z(){} // RVA: 0x7FFE810FFCF0
        public void set_Z(){} // RVA: 0x7FFE811164D0
    }

    public class Vector3TenBit : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Data(){} // RVA: 0x7FFE88161FD0
        public void CreateVector3TenBit(){} // RVA: 0x7FFE88162000
        public void UnPack(){} // RVA: 0x7FFE881620D0
        public void UnPackTo(){} // RVA: 0x7FFE881621B0
        public void Pack(){} // RVA: 0x7FFE881622B0
    }

    public class Vector3TenBitT : Object
    {
        public byte[] _data; // 0x10

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFE81116380
        public void set_Data(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE88162390
    }

    public class Vector4 : ValueType
    {
        public Google.FlatBuffers32.Struct __p; // 0x10
        public object field_1; // 0x29A
        public object field_2; // 0x29B
        public object field_3; // 0x29C
        public object field_4; // 0x29D

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_X(){} // RVA: 0x7FFE8814BF90
        public void get_Y(){} // RVA: 0x7FFE881616F0
        public void get_Z(){} // RVA: 0x7FFE881618D0
        public void get_W(){} // RVA: 0x7FFE88161B30
        public void CreateVector4(){} // RVA: 0x7FFE88161B60
        public void UnPack(){} // RVA: 0x7FFE88161C40
        public void UnPackTo(){} // RVA: 0x7FFE88161D10
        public void Pack(){} // RVA: 0x7FFE88161DA0
    }

    public class Vector4Array : ValueType
    {
        public Google.FlatBuffers32.Table __p; // 0x10
        public object field_1; // 0x32C

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsVector4Array(){} // RVA: 0x7FFE881444A0 | overloaded x2
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Value(){} // RVA: 0x7FFE881735E0
        public void get_ValueLength(){} // RVA: 0x7FFE8814C740
        public void CreateVector4Array(){} // RVA: 0x7FFE88173730
        public void StartVector4Array(){} // RVA: 0x7FFE8814C360
        public void AddValue(){} // RVA: 0x7FFE8814C380
        public void StartValueVector(){} // RVA: 0x7FFE881737B0
        public void EndVector4Array(){} // RVA: 0x7FFE881737E0
        public void UnPack(){} // RVA: 0x7FFE88173830
        public void UnPackTo(){} // RVA: 0x7FFE881738E0
        public void Pack(){} // RVA: 0x7FFE88173AF0
    }

    public class Vector4ArrayT : Object
    {
        public System.Collections.Generic.List`1<VRC.Core.Networking.FlatBuffers.FlatBuffers32.Vector4T> _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE86200400
    }

    public class Vector4ArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE88173CE0
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