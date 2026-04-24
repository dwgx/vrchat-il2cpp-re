// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Mathematics
// Classes: 11
// Methods: 269

namespace ThirdParty.Other.Unity.Mathematics
{
    public class bool3 : ValueType
    {
        public bool x; // 0x10
        public bool y; // 0x11
        public bool z; // 0x12

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FD7DE30
        public void Equals(){} // RVA: 0x7FFD54ABCD20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54AB74E0
        public void ToString(){} // RVA: 0x7FFD54ABCDC0
    }

    public class float2 : ValueType
    {
        public float x; // 0x10
        public float y; // 0x14
        public es.gine.XR zero;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E364D10
        public void op_Multiply(){} // RVA: 0x7FFD54ABCED0
        public void Equals(){} // RVA: 0x7FFD54ABCF00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54ABCFA0
        public void ToString(){} // RVA: 0x7FFD54ABD0E0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFD54ABD1B0
    }

    public class float3 : ValueType
    {
        public float yxxy; // 0x10
        public float zzyz; // 0x14
        public float xyz; // 0x18
        public es.ap yzx;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54ABD1D0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFD4F9473D0 | overloaded x3
        public void op_Multiply(){} // RVA: 0x7FFD54ABD270 | overloaded x3
        public void op_Addition(){} // RVA: 0x7FFD54ABD2A0
        public void op_Subtraction(){} // RVA: 0x7FFD54ABD2E0
        public void op_Division(){} // RVA: 0x7FFD54ABD320 | overloaded x2
        public void op_LessThan(){} // RVA: 0x7FFD54ABD350
        public void op_GreaterThan(){} // RVA: 0x7FFD54ABD390
        public void op_UnaryNegation(){} // RVA: 0x7FFD54ABD3D0
        public void get_yxxy(){} // RVA: 0x7FFD54ABD410
        public void get_zzyz(){} // RVA: 0x7FFD54ABD430
        public void get_xyz(){} // RVA: 0x7FFD4F9473D0
        public void get_yzx(){} // RVA: 0x7FFD54ABD450
        public void get_zxy(){} // RVA: 0x7FFD54ABD470
        public void Equals(){} // RVA: 0x7FFD54ABD490 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54ABD540
        public void ToString(){} // RVA: 0x7FFD54ABD6B0 | overloaded x2
    }

    public class float3x3 : ValueType
    {
        public es.ap c0; // 0x10
        public es.ap c1; // 0x1C
        public es.ap c2; // 0x28
        public es.owedCodePointsBitmap identity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54ABE340 | overloaded x4
        public void op_Multiply(){} // RVA: 0x7FFD54ABD840
        public void Equals(){} // RVA: 0x7FFD54ABD9C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54ABDA60
        public void ToString(){} // RVA: 0x7FFD54ABDF20 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD54ABE620
    }

    public class float4 : ValueType
    {
        public float xyzx; // 0x10
        public float yzxy; // 0x14
        public float yzxz; // 0x18
        public float yzxw; // 0x1C
        public es.ointsBitmap zxyy;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54ABE6A0 | overloaded x3
        public void op_Implicit(){} // RVA: 0x7FFD4F92BA70 | overloaded x3
        public void op_Multiply(){} // RVA: 0x7FFD54ABE720 | overloaded x3
        public void op_Addition(){} // RVA: 0x7FFD54ABE740
        public void op_Subtraction(){} // RVA: 0x7FFD54ABE790
        public void op_Division(){} // RVA: 0x7FFD54ABE7E0
        public void op_UnaryNegation(){} // RVA: 0x7FFD54ABE830
        public void get_xyzx(){} // RVA: 0x7FFD54ABE850
        public void get_yzxy(){} // RVA: 0x7FFD54ABE870
        public void get_yzxz(){} // RVA: 0x7FFD54ABE890
        public void get_yzxw(){} // RVA: 0x7FFD54ABE8B0
        public void get_zxyy(){} // RVA: 0x7FFD54ABE8D0
        public void get_zxyz(){} // RVA: 0x7FFD54ABE8F0
        public void get_zwxy(){} // RVA: 0x7FFD54ABE910
        public void get_wzyx(){} // RVA: 0x7FFD54ABE930
        public void get_wwwx(){} // RVA: 0x7FFD54ABE950
        public void get_wwww(){} // RVA: 0x7FFD54ABE970
        public void get_xyz(){} // RVA: 0x7FFD4F9473D0
        public void get_yxw(){} // RVA: 0x7FFD54ABE990
        public void get_zwx(){} // RVA: 0x7FFD54ABE9B0
        public void get_wzy(){} // RVA: 0x7FFD54ABE9D0
        public void Equals(){} // RVA: 0x7FFD54ABE9F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54AB79A0
        public void ToString(){} // RVA: 0x7FFD54ABED00 | overloaded x2
    }

    public class float4x4 : ValueType
    {
        public es.ointsBitmap c0; // 0x10
        public es.ointsBitmap c1; // 0x20
        public es.ointsBitmap c2; // 0x30
        public es.ointsBitmap c3; // 0x40
        public es._14 identity;
        public es._14 zero; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54ABEF60 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD54ABF1D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54ABF280
        public void ToString(){} // RVA: 0x7FFD54ABF940 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFD54ABFFE0 | overloaded x2
        public void TRS(){} // RVA: 0x7FFD54AC0090
        public void .cctor(){} // RVA: 0x7FFD54AC0270
    }

    public class math : Object
    {
        // ── Methods ──
        public void hash(){} // RVA: 0x7FFD54ABCCE0 | overloaded x10
        public void float3(){} // RVA: 0x7FFD54AB7590
        public void float3x3(){} // RVA: 0x7FFD54ABB690 | overloaded x2
        public void inverse(){} // RVA: 0x7FFD54ABC120 | overloaded x3
        public void float4(){} // RVA: 0x7FFD54AB7990 | overloaded x3
        public void shuffle(){} // RVA: 0x7FFD54AB79E0
        public void select_shuffle_component(){} // RVA: 0x7FFD54AB7B00
        public void float4x4(){} // RVA: 0x7FFD54AB7C30
        public void rotate(){} // RVA: 0x7FFD54ABC5F0 | overloaded x2
        public void transform(){} // RVA: 0x7FFD54AB7D10
        public void determinant(){} // RVA: 0x7FFD54AB9F20
        public void asint(){} // RVA: 0x7FFD5392C850
        public void asuint(){} // RVA: 0x7FFD4E6E0590 | overloaded x4
        public void asfloat(){} // RVA: 0x7FFD4E6E0590 | overloaded x3
        public void isfinite(){} // RVA: 0x7FFD54ABA2A0
        public void isnan(){} // RVA: 0x7FFD53A69A70
        public void min(){} // RVA: 0x7FFD54ABA300 | overloaded x4
        public void max(){} // RVA: 0x7FFD54ABA3C0 | overloaded x4
        public void lerp(){} // RVA: 0x7FFD54ABA440 | overloaded x2
        public void unlerp(){} // RVA: 0x7FFD54054090
        public void remap(){} // RVA: 0x7FFD54ABA4B0
        public void clamp(){} // RVA: 0x7FFD54ABA510 | overloaded x2
        public void saturate(){} // RVA: 0x7FFD54ABA610
        public void abs(){} // RVA: 0x7FFD54ABA660 | overloaded x2
        public void dot(){} // RVA: 0x7FFD54ABC1D0 | overloaded x3
        public void atan2(){} // RVA: 0x7FFD54ABA730
        public void cos(){} // RVA: 0x7FFD54ABA800 | overloaded x2
        public void acos(){} // RVA: 0x7FFD54ABA870
        public void sin(){} // RVA: 0x7FFD54ABA930 | overloaded x2
        public void asin(){} // RVA: 0x7FFD54ABA9A0
        public void floor(){} // RVA: 0x7FFD54ABAA00
        public void ceil(){} // RVA: 0x7FFD54ABAA60
        public void frac(){} // RVA: 0x7FFD54ABAAC0
        public void rcp(){} // RVA: 0x7FFD54ABAAF0
        public void sign(){} // RVA: 0x7FFD54ABAB30 | overloaded x2
        public void pow(){} // RVA: 0x7FFD54ABAC30 | overloaded x2
        public void sqrt(){} // RVA: 0x7FFD54ABACB0
        public void rsqrt(){} // RVA: 0x7FFD54ABAD30
        public void normalize(){} // RVA: 0x7FFD54ABC270 | overloaded x3
        public void normalizesafe(){} // RVA: 0x7FFD54ABC350 | overloaded x2
        public void length(){} // RVA: 0x7FFD54ABAF60
        public void lengthsq(){} // RVA: 0x7FFD54ABC220 | overloaded x2
        public void distance(){} // RVA: 0x7FFD54ABAFE0
        public void cross(){} // RVA: 0x7FFD54ABB030
        public void any(){} // RVA: 0x7FFD54ABB0B0
        public void all(){} // RVA: 0x7FFD54ABB0E0
        public void select(){} // RVA: 0x7FFD54ABB180 | overloaded x3
        public void sincos(){} // RVA: 0x7FFD54ABB1E0 | overloaded x2
        public void lzcnt(){} // RVA: 0x7FFD54ABB280 | overloaded x2
        public void tzcnt(){} // RVA: 0x7FFD54ABB2D0 | overloaded x2
        public void ceilpow2(){} // RVA: 0x7FFD531F3A20
        public void radians(){} // RVA: 0x7FFD54ABB330 | overloaded x2
        public void cmin(){} // RVA: 0x7FFD54ABB370
        public void cmax(){} // RVA: 0x7FFD4F4F8170
        public void csum(){} // RVA: 0x7FFD54ABB3E0 | overloaded x5
        public void chgsign(){} // RVA: 0x7FFD54ABB400
        public void movelh(){} // RVA: 0x7FFD54ABB490
        public void movehl(){} // RVA: 0x7FFD54ABB590
        public void mul(){} // RVA: 0x7FFD54ABC5F0 | overloaded x6
        public void quaternion(){} // RVA: 0x7FFD54ABC0E0 | overloaded x3
        public void nlerp(){} // RVA: 0x7FFD54ABC740
        public void slerp(){} // RVA: 0x7FFD54ABC940
        public void uint2(){} // RVA: 0x7FFD54ABCBF0
        public void uint3(){} // RVA: 0x7FFD54ABCC50
        public void uint4(){} // RVA: 0x7FFD54ABCCD0 | overloaded x2
    }

    public class quaternion : ValueType
    {
        public es.ointsBitmap value; // 0x10
        public es.eout identity;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFD4E6E0590 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFD54AC0640 | overloaded x4
        public void AxisAngle(){} // RVA: 0x7FFD54AC09A0
        public void EulerXYZ(){} // RVA: 0x7FFD54AC0A30
        public void EulerXZY(){} // RVA: 0x7FFD54AC0BB0
        public void EulerYXZ(){} // RVA: 0x7FFD54AC0D30
        public void EulerYZX(){} // RVA: 0x7FFD54AC0EC0
        public void EulerZXY(){} // RVA: 0x7FFD54AC1050
        public void EulerZYX(){} // RVA: 0x7FFD54AC11D0
        public void Euler(){} // RVA: 0x7FFD54AC14D0 | overloaded x2
        public void RotateY(){} // RVA: 0x7FFD54AC1510
        public void LookRotationSafe(){} // RVA: 0x7FFD54AC1580
        public void Equals(){} // RVA: 0x7FFD54AC1920 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54ABCBB0
        public void ToString(){} // RVA: 0x7FFD54AC1C30 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD54AC1E60
    }

    public class uint2 : ValueType
    {
        public uint x; // 0x10
        public uint y; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E7F6D50
        public void op_Multiply(){} // RVA: 0x7FFD54AC1EB0
        public void Equals(){} // RVA: 0x7FFD54AC1ED0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54AC1F60
        public void ToString(){} // RVA: 0x7FFD54AC2080 | overloaded x2
    }

    public class uint3 : ValueType
    {
        public uint x; // 0x10
        public uint y; // 0x14
        public uint z; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5263A020
        public void op_Multiply(){} // RVA: 0x7FFD54AC2150
        public void op_Addition(){} // RVA: 0x7FFD54AC2180
        public void op_BitwiseAnd(){} // RVA: 0x7FFD54AC21A0
        public void op_ExclusiveOr(){} // RVA: 0x7FFD54AC21C0
        public void Equals(){} // RVA: 0x7FFD54AC2200 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54ABCC60
        public void ToString(){} // RVA: 0x7FFD54AC23C0 | overloaded x2
    }

    public class uint4 : ValueType
    {
        public uint x; // 0x10
        public uint y; // 0x14
        public uint z; // 0x18
        public uint w; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54AC24B0 | overloaded x2
        public void op_Multiply(){} // RVA: 0x7FFD54AC24C0
        public void op_Addition(){} // RVA: 0x7FFD54AC24F0
        public void op_OnesComplement(){} // RVA: 0x7FFD54AC2520
        public void op_BitwiseAnd(){} // RVA: 0x7FFD54AC2580 | overloaded x2
        public void op_BitwiseOr(){} // RVA: 0x7FFD54AC25B0
        public void op_ExclusiveOr(){} // RVA: 0x7FFD54AC25E0
        public void Equals(){} // RVA: 0x7FFD54AC2610 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54AC26C0
        public void ToString(){} // RVA: 0x7FFD54AC2950 | overloaded x2
    }

}