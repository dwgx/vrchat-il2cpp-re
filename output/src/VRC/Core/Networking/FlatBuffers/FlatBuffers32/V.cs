// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers32
// Classes: 19
// Methods: 148

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers32
{
    public class Vector2 : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_X(){} // RVA: 0x9BC560
        public void get_Y(){} // RVA: 0x9BFF70
        public void CreateVector2(){} // RVA: 0x825D540
        public void UnPack(){} // RVA: 0x9BFFA0
        public void UnPackTo(){} // RVA: 0x9BFFB0
        public void Pack(){} // RVA: 0x825D6D0
    }

    public class Vector2Array : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsVector2Array(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9C35F0
        public void get_ValueLength(){} // RVA: 0x9BC8C0
        public void CreateVector2Array(){} // RVA: 0x826F3A0
        public void StartVector2Array(){} // RVA: 0x82476C0
        public void AddValue(){} // RVA: 0x82476E0
        public void StartValueVector(){} // RVA: 0x826F420
        public void EndVector2Array(){} // RVA: 0x826F450
        public void UnPack(){} // RVA: 0x9C3620
        public void UnPackTo(){} // RVA: 0x9C3630
        public void Pack(){} // RVA: 0x826F760
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
        public void Verify(){} // RVA: 0x826B670
    }

    public class Vector2T : Object
    {
        public object _x;
        public object _y;

        // ── Methods ──
        public void ToNumerics(){} // RVA: 0x3926E10
        public void op_Implicit(){} // RVA: 0x1976A90
        public void op_Explicit(){} // RVA: 0x8241E70
        public void get_zero(){} // RVA: 0x8241ED0
        public void .ctor(){} // RVA: 0x6CB16C0
        public void CopyFrom(){} // RVA: 0x8215A50
        public void op_UnaryNegation(){} // RVA: 0x8241F10
        public void get_magnitude(){} // RVA: 0x8241F80
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
        public void get_X(){} // RVA: 0x9BC560
        public void get_Y(){} // RVA: 0x9BFF70
        public void get_Z(){} // RVA: 0x9C00D0
        public void CreateVector3(){} // RVA: 0x825D720
        public void UnPack(){} // RVA: 0x9C0100
        public void UnPackTo(){} // RVA: 0x9C0110
        public void Pack(){} // RVA: 0x825D910
    }

    public class Vector3Array : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsVector3Array(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9C3700
        public void get_ValueLength(){} // RVA: 0x9BC8C0
        public void CreateVector3Array(){} // RVA: 0x826FAB0
        public void StartVector3Array(){} // RVA: 0x82476C0
        public void AddValue(){} // RVA: 0x82476E0
        public void StartValueVector(){} // RVA: 0x826FB30
        public void EndVector3Array(){} // RVA: 0x826FB60
        public void UnPack(){} // RVA: 0x9C3730
        public void UnPackTo(){} // RVA: 0x9C3740
        public void Pack(){} // RVA: 0x826FE70
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
        public void Verify(){} // RVA: 0x8270070
    }

    public class Vector3Half : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Data(){} // RVA: 0x9C0430
        public void CreateVector3Half(){} // RVA: 0x825E630
        public void UnPack(){} // RVA: 0x9C06F0
        public void UnPackTo(){} // RVA: 0x9C07D0
        public void Pack(){} // RVA: 0x825E900
    }

    public class Vector3HalfT : Object
    {
        public object _data;

        // ── Methods ──
        public void get_Data(){} // RVA: 0xB5DBF0
        public void set_Data(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x825E9E0
    }

    public class Vector3T : Object
    {
        public object _x;
        public object _y;
        public object _z;

        // ── Methods ──
        public void ToNumerics(){} // RVA: 0x18BF490
        public void op_Implicit(){} // RVA: 0x8215BD0
        public void op_Explicit(){} // RVA: 0x8242010
        public void get_zero(){} // RVA: 0x8242060
        public void .ctor(){} // RVA: 0x6D53840
        public void CopyFrom(){} // RVA: 0x8215D00
        public void get_magnitude(){} // RVA: 0x82420A0
        public void get_sqrMagnitude(){} // RVA: 0x8215DC0
        public void IsBad(){} // RVA: 0x8215DF0
        public void ToString(){} // RVA: 0x8242140
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
        public void Data(){} // RVA: 0x9C0430
        public void CreateVector3TenBit(){} // RVA: 0x825DE20
        public void UnPack(){} // RVA: 0x9C0460
        public void UnPackTo(){} // RVA: 0x9C0540
        public void Pack(){} // RVA: 0x825E0F0
    }

    public class Vector3TenBitT : Object
    {
        public object _data;

        // ── Methods ──
        public void get_Data(){} // RVA: 0xB5DBF0
        public void set_Data(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x825E1D0
    }

    public class Vector4 : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_X(){} // RVA: 0x9BC560
        public void get_Y(){} // RVA: 0x9BFF70
        public void get_Z(){} // RVA: 0x9C00D0
        public void get_W(){} // RVA: 0x9C0250
        public void CreateVector4(){} // RVA: 0x825D980
        public void UnPack(){} // RVA: 0x9C0280
        public void UnPackTo(){} // RVA: 0x9C0290
        public void Pack(){} // RVA: 0x825DBC0
    }

    public class Vector4Array : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsVector4Array(){} // RVA: 0x823F500
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Value(){} // RVA: 0x9C3810
        public void get_ValueLength(){} // RVA: 0x9BC8C0
        public void CreateVector4Array(){} // RVA: 0x8270240
        public void StartVector4Array(){} // RVA: 0x82476C0
        public void AddValue(){} // RVA: 0x82476E0
        public void StartValueVector(){} // RVA: 0x82702C0
        public void EndVector4Array(){} // RVA: 0x82702F0
        public void UnPack(){} // RVA: 0x9C3840
        public void UnPackTo(){} // RVA: 0x9C3850
        public void Pack(){} // RVA: 0x8270600
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
        public void Verify(){} // RVA: 0x8270810
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