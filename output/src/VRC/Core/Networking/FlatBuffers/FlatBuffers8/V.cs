// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 21
// Methods: 159

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class Vector2 : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_X(){} // RVA: 0x9B56F0
        public void get_Y(){} // RVA: 0x9B6D30
        public void CreateVector2(){} // RVA: 0x8222320
        public void UnPack(){} // RVA: 0x9B6D60
        public void UnPackTo(){} // RVA: 0x9B6D70
        public void Pack(){} // RVA: 0x8222500
    }

    public class Vector2Array : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsVector2Array(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9BAF40
        public void get_ValueLength(){} // RVA: 0x9B5A50
        public void CreateVector2Array(){} // RVA: 0x8238F20
        public void StartVector2Array(){} // RVA: 0x8217590
        public void AddValue(){} // RVA: 0x82175B0
        public void StartValueVector(){} // RVA: 0x8238FE0
        public void EndVector2Array(){} // RVA: 0x8239010
        public void UnPack(){} // RVA: 0x9BAF70
        public void UnPackTo(){} // RVA: 0x9BAF80
        public void Pack(){} // RVA: 0x8239360
    }

    public class Vector2ArrayT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class Vector2ArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x82354A0
    }

    public class Vector2T : Object
    {
        public object _x;
        public object _y;

        // ── Methods ──
        public void ToNumerics(){} // RVA: 0x3926E10
        public void op_Implicit(){} // RVA: 0x1976A90
        public void op_Explicit(){} // RVA: 0x8215980
        public void get_zero(){} // RVA: 0x82159E0
        public void .ctor(){} // RVA: 0x6CB16C0
        public void CopyFrom(){} // RVA: 0x8215A50
        public void op_UnaryNegation(){} // RVA: 0x8215A70
        public void get_magnitude(){} // RVA: 0x8215AE0
        public void get_sqrMagnitude(){} // RVA: 0x8215B70
        public void IsBad(){} // RVA: 0x8215B90
        public void get_X(){} // RVA: 0xC763E0
        public void set_X(){} // RVA: 0xC763F0
        public void get_Y(){} // RVA: 0xC76400
        public void set_Y(){} // RVA: 0xC76410
    }

    public class Vector3 : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_X(){} // RVA: 0x9B56F0
        public void get_Y(){} // RVA: 0x9B6D30
        public void get_Z(){} // RVA: 0x9B6F70
        public void CreateVector3(){} // RVA: 0x82229C0
        public void UnPack(){} // RVA: 0x9B6FA0
        public void UnPackTo(){} // RVA: 0x9B6FB0
        public void Pack(){} // RVA: 0x8222C00
    }

    public class Vector3Array : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsVector3Array(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9BB050
        public void get_ValueLength(){} // RVA: 0x9B5A50
        public void CreateVector3Array(){} // RVA: 0x82396C0
        public void StartVector3Array(){} // RVA: 0x8217590
        public void AddValue(){} // RVA: 0x82175B0
        public void StartValueVector(){} // RVA: 0x8239780
        public void EndVector3Array(){} // RVA: 0x82397B0
        public void UnPack(){} // RVA: 0x9BB080
        public void UnPackTo(){} // RVA: 0x9BB090
        public void Pack(){} // RVA: 0x8239B00
    }

    public class Vector3ArrayT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class Vector3ArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x8239D10
    }

    public class Vector3Bytes : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Data(){} // RVA: 0x9B6360
        public void CreateVector3Bytes(){} // RVA: 0x8222520
        public void UnPack(){} // RVA: 0x9B6E90
        public void UnPackTo(){} // RVA: 0x9B6EA0
        public void Pack(){} // RVA: 0x82227C0
    }

    public class Vector3BytesT : Object
    {
        public object _data;

        // ── Methods ──
        public void get_Data(){} // RVA: 0xB5DBF0
        public void set_Data(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x8222900
    }

    public class Vector3Half : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Data(){} // RVA: 0x9B6360
        public void CreateVector3Half(){} // RVA: 0x8223920
        public void UnPack(){} // RVA: 0x9B7490
        public void UnPackTo(){} // RVA: 0x9B74A0
        public void Pack(){} // RVA: 0x8223BC0
    }

    public class Vector3HalfT : Object
    {
        public object _data;

        // ── Methods ──
        public void get_Data(){} // RVA: 0xB5DBF0
        public void set_Data(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x8223D00
    }

    public class Vector3T : Object
    {
        public object _x;
        public object _y;
        public object _z;

        // ── Methods ──
        public void ToNumerics(){} // RVA: 0x18BF490
        public void op_Implicit(){} // RVA: 0x8215BD0
        public void op_Explicit(){} // RVA: 0x8215C10
        public void get_zero(){} // RVA: 0x8215C60
        public void .ctor(){} // RVA: 0x6D53840
        public void CopyFrom(){} // RVA: 0x8215D00
        public void get_magnitude(){} // RVA: 0x8215D20
        public void get_sqrMagnitude(){} // RVA: 0x8215DC0
        public void IsBad(){} // RVA: 0x8215DF0
        public void ToString(){} // RVA: 0x8215E50
        public void get_X(){} // RVA: 0xC763E0
        public void set_X(){} // RVA: 0xC763F0
        public void get_Y(){} // RVA: 0xC76400
        public void set_Y(){} // RVA: 0xC76410
        public void get_Z(){} // RVA: 0xB47B50
        public void set_Z(){} // RVA: 0xB5DD40
    }

    public class Vector3TenBit : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Data(){} // RVA: 0x9B6360
        public void CreateVector3TenBit(){} // RVA: 0x8223160
        public void UnPack(){} // RVA: 0x9B72D0
        public void UnPackTo(){} // RVA: 0x9B72E0
        public void Pack(){} // RVA: 0x8223400
    }

    public class Vector3TenBitT : Object
    {
        public object _data;

        // ── Methods ──
        public void get_Data(){} // RVA: 0xB5DBF0
        public void set_Data(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x8223420
    }

    public class Vector4 : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_X(){} // RVA: 0x9B56F0
        public void get_Y(){} // RVA: 0x9B6D30
        public void get_Z(){} // RVA: 0x9B6F70
        public void get_W(){} // RVA: 0x9B70F0
        public void CreateVector4(){} // RVA: 0x8222C70
        public void UnPack(){} // RVA: 0x9B7120
        public void UnPackTo(){} // RVA: 0x9B7130
        public void Pack(){} // RVA: 0x8222EF0
    }

    public class Vector4Array : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsVector4Array(){} // RVA: 0x8217320
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9BB160
        public void get_ValueLength(){} // RVA: 0x9B5A50
        public void CreateVector4Array(){} // RVA: 0x8239EE0
        public void StartVector4Array(){} // RVA: 0x8217590
        public void AddValue(){} // RVA: 0x82175B0
        public void StartValueVector(){} // RVA: 0x8239FA0
        public void EndVector4Array(){} // RVA: 0x8239FD0
        public void UnPack(){} // RVA: 0x9BB190
        public void UnPackTo(){} // RVA: 0x9BB1A0
        public void Pack(){} // RVA: 0x823A320
    }

    public class Vector4ArrayT : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x627C9E0
    }

    public class Vector4ArrayVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x823A540
    }

    public class Vector4T : Object
    {
        public object _x;
        public object _y;
        public object _z;
        public object _w;

        // ── Methods ──
        public void get_X(){} // RVA: 0xC763E0
        public void set_X(){} // RVA: 0xC763F0
        public void get_Y(){} // RVA: 0xC76400
        public void set_Y(){} // RVA: 0xC76410
        public void get_Z(){} // RVA: 0xB47B50
        public void set_Z(){} // RVA: 0xB5DD40
        public void get_W(){} // RVA: 0xC152D0
        public void set_W(){} // RVA: 0xC152E0
        public void .ctor(){} // RVA: 0x8215970
    }

}