// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Mathematics
// Classes: 11
// Methods: 169

namespace ThirdParty.Other.Unity.Mathematics
{
    public class bool3 : ValueType
    {
        public object x;
        public object y;
        public object z;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8C060
        public void Equals(){} // RVA: 0x93EC00
        public void GetHashCode(){} // RVA: 0x93ECA0
        public void ToString(){} // RVA: 0x93ECF0
    }

    public class float2 : ValueType
    {
        public object x;
        public object y;
        public object zero;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7C540
        public void op_Multiply(){} // RVA: 0x7950180
        public void Equals(){} // RVA: 0x93EDF0
        public void GetHashCode(){} // RVA: 0x93EE90
        public void ToString(){} // RVA: 0x93EFC0
        public void op_Implicit(){} // RVA: 0x7950440
    }

    public class float3 : ValueType
    {
        public object x;
        public object y;
        public object z;
        public object zero;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x90B970
        public void op_Implicit(){} // RVA: 0x2331CF0
        public void op_Multiply(){} // RVA: 0x79504B0
        public void op_Addition(){} // RVA: 0x79504E0
        public void op_Subtraction(){} // RVA: 0x7287F10
        public void op_Division(){} // RVA: 0x7950510
        public void op_LessThan(){} // RVA: 0x7950540
        public void op_GreaterThan(){} // RVA: 0x7950580
        public void op_UnaryNegation(){} // RVA: 0x79505C0
        public void get_yxxy(){} // RVA: 0x93F090
        public void get_zzyz(){} // RVA: 0x93F0D0
        public void get_xyz(){} // RVA: 0x8F91D0
        public void get_yzx(){} // RVA: 0x93F110
        public void get_zxy(){} // RVA: 0x93F130
        public void get_Item(){} // RVA: 0x93F150
        public void Equals(){} // RVA: 0x93F160
        public void GetHashCode(){} // RVA: 0x93F210
        public void ToString(){} // RVA: 0x93F370
    }

    public class float3x3 : ValueType
    {
        public object c0;
        public object c1;
        public object c2;
        public object identity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x93F740
        public void op_Multiply(){} // RVA: 0x79509D0
        public void get_Item(){} // RVA: 0x93F510
        public void Equals(){} // RVA: 0x93F550
        public void GetHashCode(){} // RVA: 0x93F5F0
        public void ToString(){} // RVA: 0x93F6C0
        public void .cctor(){} // RVA: 0x79517C0
    }

    public class float4 : ValueType
    {
        public object x;
        public object y;
        public object z;
        public object w;
        public object zero;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x93F790
        public void op_Implicit(){} // RVA: 0x2315EC0
        public void op_Multiply(){} // RVA: 0x79518C0
        public void op_Addition(){} // RVA: 0x79518E0
        public void op_Subtraction(){} // RVA: 0x7951930
        public void op_Division(){} // RVA: 0x7951980
        public void op_UnaryNegation(){} // RVA: 0x79519D0
        public void get_xyzx(){} // RVA: 0x93F7A0
        public void get_yzxy(){} // RVA: 0x93F7E0
        public void get_yzxz(){} // RVA: 0x93F820
        public void get_yzxw(){} // RVA: 0x93F860
        public void get_zxyy(){} // RVA: 0x93F8A0
        public void get_zxyz(){} // RVA: 0x93F8E0
        public void get_zwxy(){} // RVA: 0x93F920
        public void get_wzyx(){} // RVA: 0x93F960
        public void get_wwwx(){} // RVA: 0x93F9A0
        public void get_wwww(){} // RVA: 0x93F9E0
        public void get_xyz(){} // RVA: 0x8F91D0
        public void get_yxw(){} // RVA: 0x93FA20
        public void get_zwx(){} // RVA: 0x93FA40
        public void get_wzy(){} // RVA: 0x93FA60
        public void Equals(){} // RVA: 0x93FA80
        public void GetHashCode(){} // RVA: 0x93FB50
        public void ToString(){} // RVA: 0x93FBB0
    }

    public class float4x4 : ValueType
    {
        public object c0;
        public object c1;
        public object c2;
        public object c3;
        public object identity;
        public object zero;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x93FBF0
        public void Equals(){} // RVA: 0x93FD30
        public void GetHashCode(){} // RVA: 0x93FDE0
        public void ToString(){} // RVA: 0x93FE30
        public void op_Implicit(){} // RVA: 0x7953100
        public void TRS(){} // RVA: 0x79531B0
        public void .cctor(){} // RVA: 0x79533A0
    }

    public class math : Object
    {
        // ── Methods ──
        public void hash(){} // RVA: 0x794FF90
        public void float3(){} // RVA: 0x794AD60
        public void float3x3(){} // RVA: 0x794E950
        public void inverse(){} // RVA: 0x794F550
        public void float4(){} // RVA: 0x794B140
        public void shuffle(){} // RVA: 0x794B1A0
        public void select_shuffle_component(){} // RVA: 0x794B2C0
        public void float4x4(){} // RVA: 0x794B3F0
        public void rotate(){} // RVA: 0x20EE720
        public void transform(){} // RVA: 0x794B4F0
        public void determinant(){} // RVA: 0x794D1C0
        public void asint(){} // RVA: 0x67EE640
        public void asuint(){} // RVA: 0xFE9840
        public void asfloat(){} // RVA: 0xFE9840
        public void isfinite(){} // RVA: 0x794D610
        public void isnan(){} // RVA: 0x692B520
        public void min(){} // RVA: 0x794D670
        public void max(){} // RVA: 0x794D720
        public void lerp(){} // RVA: 0x794D7A0
        public void unlerp(){} // RVA: 0x6F09AA0
        public void remap(){} // RVA: 0x794D810
        public void clamp(){} // RVA: 0x794D870
        public void saturate(){} // RVA: 0x794D970
        public void abs(){} // RVA: 0x794D9C0
        public void dot(){} // RVA: 0x794F610
        public void atan2(){} // RVA: 0x794DA50
        public void cos(){} // RVA: 0x794DB20
        public void acos(){} // RVA: 0x794DB90
        public void sin(){} // RVA: 0x794DC50
        public void asin(){} // RVA: 0x794DCC0
        public void floor(){} // RVA: 0x794DD20
        public void ceil(){} // RVA: 0x794DD80
        public void frac(){} // RVA: 0x794DDE0
        public void rcp(){} // RVA: 0x794DE10
        public void sign(){} // RVA: 0x794DE50
        public void pow(){} // RVA: 0x794DF50
        public void sqrt(){} // RVA: 0x794DFD0
        public void rsqrt(){} // RVA: 0x794E050
        public void normalize(){} // RVA: 0x794F6B0
        public void normalizesafe(){} // RVA: 0x794F790
        public void length(){} // RVA: 0x794E2A0
        public void lengthsq(){} // RVA: 0x794F660
        public void distance(){} // RVA: 0x794E320
        public void cross(){} // RVA: 0x794E370
        public void any(){} // RVA: 0x794E3E0
        public void all(){} // RVA: 0x794E410
        public void select(){} // RVA: 0x794E4A0
        public void sincos(){} // RVA: 0x794E500
        public void lzcnt(){} // RVA: 0x794E5A0
        public void ceilpow2(){} // RVA: 0x6272B10
        public void radians(){} // RVA: 0x794E600
        public void cmin(){} // RVA: 0x794E640
        public void cmax(){} // RVA: 0x1EEF570
        public void csum(){} // RVA: 0x794E6B0
        public void chgsign(){} // RVA: 0x794E6D0
        public void movelh(){} // RVA: 0x794E750
        public void movehl(){} // RVA: 0x794E850
        public void mul(){} // RVA: 0x20EE720
        public void quaternion(){} // RVA: 0x794F510
        public void nlerp(){} // RVA: 0x794FA40
        public void slerp(){} // RVA: 0x794FC40
        public void uint2(){} // RVA: 0x794FEA0
        public void uint3(){} // RVA: 0x794FF00
        public void uint4(){} // RVA: 0x794FF80
    }

    public class quaternion : ValueType
    {
        public object value;
        public object identity;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0xFE9840
        public void .ctor(){} // RVA: 0x93FE90
        public void AxisAngle(){} // RVA: 0x7953AD0
        public void EulerXYZ(){} // RVA: 0x7953B60
        public void EulerXZY(){} // RVA: 0x7953CD0
        public void EulerYXZ(){} // RVA: 0x7953E40
        public void EulerYZX(){} // RVA: 0x7953FB0
        public void EulerZXY(){} // RVA: 0x7954120
        public void EulerZYX(){} // RVA: 0x7954290
        public void Euler(){} // RVA: 0x7954570
        public void RotateY(){} // RVA: 0x79545B0
        public void LookRotationSafe(){} // RVA: 0x7954620
        public void Equals(){} // RVA: 0x93FED0
        public void GetHashCode(){} // RVA: 0x93FB50
        public void ToString(){} // RVA: 0x93FFB0
        public void .cctor(){} // RVA: 0x7954EE0
    }

    public class uint2 : ValueType
    {
        public object x;
        public object y;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2B100
        public void op_Multiply(){} // RVA: 0x7954F30
        public void Equals(){} // RVA: 0x93FFC0
        public void GetHashCode(){} // RVA: 0x940050
        public void ToString(){} // RVA: 0x940160
    }

    public class uint3 : ValueType
    {
        public object x;
        public object y;
        public object z;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E1050
        public void op_Multiply(){} // RVA: 0x79551C0
        public void op_Addition(){} // RVA: 0x79551F0
        public void op_BitwiseAnd(){} // RVA: 0x7955210
        public void op_ExclusiveOr(){} // RVA: 0x7955230
        public void Equals(){} // RVA: 0x940270
        public void GetHashCode(){} // RVA: 0x940320
        public void ToString(){} // RVA: 0x940470
    }

    public class uint4 : ValueType
    {
        public object x;
        public object y;
        public object z;
        public object w;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x940570
        public void op_Multiply(){} // RVA: 0x7955520
        public void op_Addition(){} // RVA: 0x7955550
        public void op_OnesComplement(){} // RVA: 0x7955580
        public void op_BitwiseAnd(){} // RVA: 0x79555E0
        public void op_BitwiseOr(){} // RVA: 0x7955610
        public void op_ExclusiveOr(){} // RVA: 0x7955640
        public void Equals(){} // RVA: 0x9405B0
        public void GetHashCode(){} // RVA: 0x940660
        public void ToString(){} // RVA: 0x9406C0
    }

}