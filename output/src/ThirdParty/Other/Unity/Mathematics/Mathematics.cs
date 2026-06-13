// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Mathematics
// Classes: 11
// Methods: 272

namespace ThirdParty.Other.Unity.Mathematics
{
    public class bool3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D765C0
        public void Equals(){} // RVA: 0x6F044A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6EFEDB0
        public void ToString(){} // RVA: 0x6F04540
    }

    public class float2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x300D10
        public void op_Multiply(){} // RVA: 0x6F04650
        public void Equals(){} // RVA: 0x6F04680 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6F04720
        public void ToString(){} // RVA: 0x6F04860 | overloaded x2
        public void op_Implicit(){} // RVA: 0x6F04930
    }

    public class float3
    {
        public float x; // 0x10
        public float y; // 0x14
        public float z; // 0x18
        public Unity.Mathematics.float3 zero;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6822550 | overloaded x2
        public void op_Implicit(){} // RVA: 0x1A6E260 | overloaded x3
        public void op_Multiply(){} // RVA: 0x6F049A0 | overloaded x3
        public void op_Addition(){} // RVA: 0x6F049D0 | overloaded x2
        public void op_Subtraction(){} // RVA: 0x68225A0
        public void op_Division(){} // RVA: 0x6F04A00 | overloaded x2
        public void op_LessThan(){} // RVA: 0x6F04A30
        public void op_GreaterThan(){} // RVA: 0x6F04A70
        public void op_UnaryNegation(){} // RVA: 0x6F04AB0
        public void get_yxxy(){} // RVA: 0x6F04AF0
        public void get_zzyz(){} // RVA: 0x6F04B10
        public void get_xyz(){} // RVA: 0x1A6E260
        public void get_yzx(){} // RVA: 0x6F04B30
        public void get_zxy(){} // RVA: 0x6F04B50
        public void get_Item(){} // RVA: 0x2111160
        public void Equals(){} // RVA: 0x6F04B70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6F04C20
        public void ToString(){} // RVA: 0x6F04D90 | overloaded x2
    }

    public class float3x3
    {
        public Unity.Mathematics.float3 c0; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F05A20 | overloaded x4
        public void op_Multiply(){} // RVA: 0x6F04F20
        public void get_Item(){} // RVA: 0x2878E10
        public void Equals(){} // RVA: 0x6F050A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6F05140
        public void ToString(){} // RVA: 0x6F05600 | overloaded x2
        public void .cctor(){} // RVA: 0x6F05D00
    }

    public class float4
    {
        public float x; // 0x10
        public float y; // 0x14
        public float z; // 0x18
        public float w; // 0x1C
        public Unity.Mathematics.float4 zero;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F05D80 | overloaded x3
        public void op_Implicit(){} // RVA: 0x1A53750 | overloaded x3
        public void op_Multiply(){} // RVA: 0x6F05E00 | overloaded x3
        public void op_Addition(){} // RVA: 0x6F05E20
        public void op_Subtraction(){} // RVA: 0x6F05E70
        public void op_Division(){} // RVA: 0x6F05EC0
        public void op_UnaryNegation(){} // RVA: 0x6F05F10
        public void get_xyzx(){} // RVA: 0x6F05F30
        public void get_yzxy(){} // RVA: 0x6F05F50
        public void get_yzxz(){} // RVA: 0x6F05F70
        public void get_yzxw(){} // RVA: 0x6F05F90
        public void get_zxyy(){} // RVA: 0x6F05FB0
        public void get_zxyz(){} // RVA: 0x6F05FD0
        public void get_zwxy(){} // RVA: 0x6F05FF0
        public void get_wzyx(){} // RVA: 0x6F06010
        public void get_wwwx(){} // RVA: 0x6F06030
        public void get_wwww(){} // RVA: 0x6F06050
        public void get_xyz(){} // RVA: 0x1A6E260
        public void get_yxw(){} // RVA: 0x6F06070
        public void get_zwx(){} // RVA: 0x6F06090
        public void get_wzy(){} // RVA: 0x6F060B0
        public void Equals(){} // RVA: 0x6F060D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6EFF270
        public void ToString(){} // RVA: 0x6F063E0 | overloaded x2
    }

    public class float4x4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F06640 | overloaded x2
        public void Equals(){} // RVA: 0x6F068B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6F06960
        public void ToString(){} // RVA: 0x6F07020 | overloaded x2
        public void op_Implicit(){} // RVA: 0x6F076C0 | overloaded x2
        public void TRS(){} // RVA: 0x6F07770
        public void .cctor(){} // RVA: 0x6F07950
    }

    public class math
    {
        // ── Methods ──
        public void hash(){} // RVA: 0x6F04460 | overloaded x10
        public void float3(){} // RVA: 0x6EFEE60
        public void float3x3(){} // RVA: 0x6F02F60 | overloaded x2
        public void inverse(){} // RVA: 0x6F039F0 | overloaded x3
        public void float4(){} // RVA: 0x6EFF260 | overloaded x3
        public void shuffle(){} // RVA: 0x6EFF2B0
        public void select_shuffle_component(){} // RVA: 0x6EFF3D0
        public void float4x4(){} // RVA: 0x6EFF500
        public void rotate(){} // RVA: 0x1851970 | overloaded x2
        public void transform(){} // RVA: 0x6EFF5E0
        public void determinant(){} // RVA: 0x6F017F0
        public void asint(){} // RVA: 0x5D751C0
        public void asuint(){} // RVA: 0x75E7E0 | overloaded x4
        public void asfloat(){} // RVA: 0x75E7E0 | overloaded x3
        public void isfinite(){} // RVA: 0x6F01B70
        public void isnan(){} // RVA: 0x5EB23C0
        public void min(){} // RVA: 0x6F01BD0 | overloaded x4
        public void max(){} // RVA: 0x6F01C90 | overloaded x4
        public void lerp(){} // RVA: 0x6F01D10 | overloaded x2
        public void unlerp(){} // RVA: 0x649D500
        public void remap(){} // RVA: 0x6F01D80
        public void clamp(){} // RVA: 0x6F01DE0 | overloaded x2
        public void saturate(){} // RVA: 0x6F01EE0
        public void abs(){} // RVA: 0x6F01F30 | overloaded x2
        public void dot(){} // RVA: 0x6F03AA0 | overloaded x3
        public void atan2(){} // RVA: 0x6F02000
        public void cos(){} // RVA: 0x6F020D0 | overloaded x2
        public void acos(){} // RVA: 0x6F02140
        public void sin(){} // RVA: 0x6F02200 | overloaded x2
        public void asin(){} // RVA: 0x6F02270
        public void floor(){} // RVA: 0x6F022D0
        public void ceil(){} // RVA: 0x6F02330
        public void frac(){} // RVA: 0x6F02390
        public void rcp(){} // RVA: 0x6F023C0
        public void sign(){} // RVA: 0x6F02400 | overloaded x2
        public void pow(){} // RVA: 0x6F02500 | overloaded x2
        public void sqrt(){} // RVA: 0x6F02580
        public void rsqrt(){} // RVA: 0x6F02600
        public void normalize(){} // RVA: 0x6F03B40 | overloaded x3
        public void normalizesafe(){} // RVA: 0x6F03C20 | overloaded x2
        public void length(){} // RVA: 0x6F02830
        public void lengthsq(){} // RVA: 0x6F03AF0 | overloaded x2
        public void distance(){} // RVA: 0x6F028B0
        public void cross(){} // RVA: 0x6F02900
        public void any(){} // RVA: 0x6F02980
        public void all(){} // RVA: 0x6F029B0
        public void select(){} // RVA: 0x6F02A50 | overloaded x3
        public void sincos(){} // RVA: 0x6F02AB0 | overloaded x2
        public void lzcnt(){} // RVA: 0x6F02B50 | overloaded x2
        public void tzcnt(){} // RVA: 0x6F02BA0 | overloaded x2
        public void ceilpow2(){} // RVA: 0x5745940
        public void radians(){} // RVA: 0x6F02C00 | overloaded x2
        public void cmin(){} // RVA: 0x6F02C40
        public void cmax(){} // RVA: 0x1623540
        public void csum(){} // RVA: 0x6F02CB0 | overloaded x5
        public void chgsign(){} // RVA: 0x6F02CD0
        public void movelh(){} // RVA: 0x6F02D60
        public void movehl(){} // RVA: 0x6F02E60
        public void mul(){} // RVA: 0x1851970 | overloaded x6
        public void quaternion(){} // RVA: 0x6F039B0 | overloaded x3
        public void nlerp(){} // RVA: 0x6F03EC0
        public void slerp(){} // RVA: 0x6F040C0
        public void uint2(){} // RVA: 0x6F04370
        public void uint3(){} // RVA: 0x6F043D0
        public void uint4(){} // RVA: 0x6F04450 | overloaded x2
    }

    public class quaternion
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x75E7E0 | overloaded x3
        public void .ctor(){} // RVA: 0x6F07D20 | overloaded x4
        public void AxisAngle(){} // RVA: 0x6F08080
        public void EulerXYZ(){} // RVA: 0x6F08110
        public void EulerXZY(){} // RVA: 0x6F08290
        public void EulerYXZ(){} // RVA: 0x6F08410
        public void EulerYZX(){} // RVA: 0x6F085A0
        public void EulerZXY(){} // RVA: 0x6F08730
        public void EulerZYX(){} // RVA: 0x6F088B0
        public void Euler(){} // RVA: 0x6F08BB0 | overloaded x2
        public void RotateY(){} // RVA: 0x6F08BF0
        public void LookRotationSafe(){} // RVA: 0x6F08C60
        public void Equals(){} // RVA: 0x6F09000 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6F04330
        public void ToString(){} // RVA: 0x6F09310 | overloaded x2
        public void .cctor(){} // RVA: 0x6F09540
    }

    public class uint2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8AE010
        public void op_Multiply(){} // RVA: 0x6F09590
        public void Equals(){} // RVA: 0x6F095B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6F09640
        public void ToString(){} // RVA: 0x6F09760 | overloaded x2
    }

    public class uint3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x49D93F0
        public void op_Multiply(){} // RVA: 0x6F09830
        public void op_Addition(){} // RVA: 0x6F09860
        public void op_BitwiseAnd(){} // RVA: 0x6F09880
        public void op_ExclusiveOr(){} // RVA: 0x6F098A0
        public void Equals(){} // RVA: 0x6F098E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6F043E0
        public void ToString(){} // RVA: 0x6F09AA0 | overloaded x2
    }

    public class uint4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F09B90 | overloaded x2
        public void op_Multiply(){} // RVA: 0x6F09BA0
        public void op_Addition(){} // RVA: 0x6F09BD0
        public void op_OnesComplement(){} // RVA: 0x6F09C00
        public void op_BitwiseAnd(){} // RVA: 0x6F09C60 | overloaded x2
        public void op_BitwiseOr(){} // RVA: 0x6F09C90
        public void op_ExclusiveOr(){} // RVA: 0x6F09CC0
        public void Equals(){} // RVA: 0x6F09CF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6F09DA0
        public void ToString(){} // RVA: 0x6F0A030 | overloaded x2
    }

}