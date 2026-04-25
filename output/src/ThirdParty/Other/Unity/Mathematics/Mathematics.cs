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
        public void .ctor(){} // RVA: 0x7FFAC495DE30
        public void Equals(){} // RVA: 0x7FFAC969CD20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC96974E0
        public void ToString(){} // RVA: 0x7FFAC969CDC0
    }

    public class float2 : ValueType
    {
        public float x; // 0x10
        public float y; // 0x14
        public Unity.Mathematics.float2 zero;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F44D10
        public void op_Multiply(){} // RVA: 0x7FFAC969CED0
        public void Equals(){} // RVA: 0x7FFAC969CF00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC969CFA0
        public void ToString(){} // RVA: 0x7FFAC969D0E0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFAC969D1B0
    }

    public class float3 : ValueType
    {
        public float yxxy; // 0x10
        public float zzyz; // 0x14
        public float xyz; // 0x18
        public Unity.Mathematics.float3 yzx;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC969D1D0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFAC45273D0 | overloaded x3
        public void op_Multiply(){} // RVA: 0x7FFAC969D270 | overloaded x3
        public void op_Addition(){} // RVA: 0x7FFAC969D2A0
        public void op_Subtraction(){} // RVA: 0x7FFAC969D2E0
        public void op_Division(){} // RVA: 0x7FFAC969D320 | overloaded x2
        public void op_LessThan(){} // RVA: 0x7FFAC969D350
        public void op_GreaterThan(){} // RVA: 0x7FFAC969D390
        public void op_UnaryNegation(){} // RVA: 0x7FFAC969D3D0
        public void get_yxxy(){} // RVA: 0x7FFAC969D410
        public void get_zzyz(){} // RVA: 0x7FFAC969D430
        public void get_xyz(){} // RVA: 0x7FFAC45273D0
        public void get_yzx(){} // RVA: 0x7FFAC969D450
        public void get_zxy(){} // RVA: 0x7FFAC969D470
        public void Equals(){} // RVA: 0x7FFAC969D490 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC969D540
        public void ToString(){} // RVA: 0x7FFAC969D6B0 | overloaded x2
    }

    public class float3x3 : ValueType
    {
        public Unity.Mathematics.float3 c0; // 0x10
        public Unity.Mathematics.float3 c1; // 0x1C
        public Unity.Mathematics.float3 c2; // 0x28
        public Unity.Mathematics.float3x3 identity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC969E340 | overloaded x4
        public void op_Multiply(){} // RVA: 0x7FFAC969D840
        public void Equals(){} // RVA: 0x7FFAC969D9C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC969DA60
        public void ToString(){} // RVA: 0x7FFAC969DF20 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC969E620
    }

    public class float4 : ValueType
    {
        public float xyzx; // 0x10
        public float yzxy; // 0x14
        public float yzxz; // 0x18
        public float yzxw; // 0x1C
        public Unity.Mathematics.float4 zxyy;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC969E6A0 | overloaded x3
        public void op_Implicit(){} // RVA: 0x7FFAC450BA70 | overloaded x3
        public void op_Multiply(){} // RVA: 0x7FFAC969E720 | overloaded x3
        public void op_Addition(){} // RVA: 0x7FFAC969E740
        public void op_Subtraction(){} // RVA: 0x7FFAC969E790
        public void op_Division(){} // RVA: 0x7FFAC969E7E0
        public void op_UnaryNegation(){} // RVA: 0x7FFAC969E830
        public void get_xyzx(){} // RVA: 0x7FFAC969E850
        public void get_yzxy(){} // RVA: 0x7FFAC969E870
        public void get_yzxz(){} // RVA: 0x7FFAC969E890
        public void get_yzxw(){} // RVA: 0x7FFAC969E8B0
        public void get_zxyy(){} // RVA: 0x7FFAC969E8D0
        public void get_zxyz(){} // RVA: 0x7FFAC969E8F0
        public void get_zwxy(){} // RVA: 0x7FFAC969E910
        public void get_wzyx(){} // RVA: 0x7FFAC969E930
        public void get_wwwx(){} // RVA: 0x7FFAC969E950
        public void get_wwww(){} // RVA: 0x7FFAC969E970
        public void get_xyz(){} // RVA: 0x7FFAC45273D0
        public void get_yxw(){} // RVA: 0x7FFAC969E990
        public void get_zwx(){} // RVA: 0x7FFAC969E9B0
        public void get_wzy(){} // RVA: 0x7FFAC969E9D0
        public void Equals(){} // RVA: 0x7FFAC969E9F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC96979A0
        public void ToString(){} // RVA: 0x7FFAC969ED00 | overloaded x2
    }

    public class float4x4 : ValueType
    {
        public Unity.Mathematics.float4 c0; // 0x10
        public Unity.Mathematics.float4 c1; // 0x20
        public Unity.Mathematics.float4 c2; // 0x30
        public Unity.Mathematics.float4 c3; // 0x40
        public Unity.Mathematics.float4x4 identity;
        public Unity.Mathematics.float4x4 zero; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC969EF60 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC969F1D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC969F280
        public void ToString(){} // RVA: 0x7FFAC969F940 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFAC969FFE0 | overloaded x2
        public void TRS(){} // RVA: 0x7FFAC96A0090
        public void .cctor(){} // RVA: 0x7FFAC96A0270
    }

    public class math : Object
    {
        // ── Methods ──
        public void hash(){} // RVA: 0x7FFAC969CCE0 | overloaded x10
        public void float3(){} // RVA: 0x7FFAC9697590
        public void float3x3(){} // RVA: 0x7FFAC969B690 | overloaded x2
        public void inverse(){} // RVA: 0x7FFAC969C120 | overloaded x3
        public void float4(){} // RVA: 0x7FFAC9697990 | overloaded x3
        public void shuffle(){} // RVA: 0x7FFAC96979E0
        public void select_shuffle_component(){} // RVA: 0x7FFAC9697B00
        public void float4x4(){} // RVA: 0x7FFAC9697C30
        public void rotate(){} // RVA: 0x7FFAC969C5F0 | overloaded x2
        public void transform(){} // RVA: 0x7FFAC9697D10
        public void determinant(){} // RVA: 0x7FFAC9699F20
        public void asint(){} // RVA: 0x7FFAC850C850
        public void asuint(){} // RVA: 0x7FFAC32C0590 | overloaded x4
        public void asfloat(){} // RVA: 0x7FFAC32C0590 | overloaded x3
        public void isfinite(){} // RVA: 0x7FFAC969A2A0
        public void isnan(){} // RVA: 0x7FFAC8649A70
        public void min(){} // RVA: 0x7FFAC969A300 | overloaded x4
        public void max(){} // RVA: 0x7FFAC969A3C0 | overloaded x4
        public void lerp(){} // RVA: 0x7FFAC969A440 | overloaded x2
        public void unlerp(){} // RVA: 0x7FFAC8C34090
        public void remap(){} // RVA: 0x7FFAC969A4B0
        public void clamp(){} // RVA: 0x7FFAC969A510 | overloaded x2
        public void saturate(){} // RVA: 0x7FFAC969A610
        public void abs(){} // RVA: 0x7FFAC969A660 | overloaded x2
        public void dot(){} // RVA: 0x7FFAC969C1D0 | overloaded x3
        public void atan2(){} // RVA: 0x7FFAC969A730
        public void cos(){} // RVA: 0x7FFAC969A800 | overloaded x2
        public void acos(){} // RVA: 0x7FFAC969A870
        public void sin(){} // RVA: 0x7FFAC969A930 | overloaded x2
        public void asin(){} // RVA: 0x7FFAC969A9A0
        public void floor(){} // RVA: 0x7FFAC969AA00
        public void ceil(){} // RVA: 0x7FFAC969AA60
        public void frac(){} // RVA: 0x7FFAC969AAC0
        public void rcp(){} // RVA: 0x7FFAC969AAF0
        public void sign(){} // RVA: 0x7FFAC969AB30 | overloaded x2
        public void pow(){} // RVA: 0x7FFAC969AC30 | overloaded x2
        public void sqrt(){} // RVA: 0x7FFAC969ACB0
        public void rsqrt(){} // RVA: 0x7FFAC969AD30
        public void normalize(){} // RVA: 0x7FFAC969C270 | overloaded x3
        public void normalizesafe(){} // RVA: 0x7FFAC969C350 | overloaded x2
        public void length(){} // RVA: 0x7FFAC969AF60
        public void lengthsq(){} // RVA: 0x7FFAC969C220 | overloaded x2
        public void distance(){} // RVA: 0x7FFAC969AFE0
        public void cross(){} // RVA: 0x7FFAC969B030
        public void any(){} // RVA: 0x7FFAC969B0B0
        public void all(){} // RVA: 0x7FFAC969B0E0
        public void select(){} // RVA: 0x7FFAC969B180 | overloaded x3
        public void sincos(){} // RVA: 0x7FFAC969B1E0 | overloaded x2
        public void lzcnt(){} // RVA: 0x7FFAC969B280 | overloaded x2
        public void tzcnt(){} // RVA: 0x7FFAC969B2D0 | overloaded x2
        public void ceilpow2(){} // RVA: 0x7FFAC7DD3A20
        public void radians(){} // RVA: 0x7FFAC969B330 | overloaded x2
        public void cmin(){} // RVA: 0x7FFAC969B370
        public void cmax(){} // RVA: 0x7FFAC40D8170
        public void csum(){} // RVA: 0x7FFAC969B3E0 | overloaded x5
        public void chgsign(){} // RVA: 0x7FFAC969B400
        public void movelh(){} // RVA: 0x7FFAC969B490
        public void movehl(){} // RVA: 0x7FFAC969B590
        public void mul(){} // RVA: 0x7FFAC969C5F0 | overloaded x6
        public void quaternion(){} // RVA: 0x7FFAC969C0E0 | overloaded x3
        public void nlerp(){} // RVA: 0x7FFAC969C740
        public void slerp(){} // RVA: 0x7FFAC969C940
        public void uint2(){} // RVA: 0x7FFAC969CBF0
        public void uint3(){} // RVA: 0x7FFAC969CC50
        public void uint4(){} // RVA: 0x7FFAC969CCD0 | overloaded x2
    }

    public class quaternion : ValueType
    {
        public Unity.Mathematics.float4 value; // 0x10
        public Unity.Mathematics.quaternion identity;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFAC32C0590 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFAC96A0640 | overloaded x4
        public void AxisAngle(){} // RVA: 0x7FFAC96A09A0
        public void EulerXYZ(){} // RVA: 0x7FFAC96A0A30
        public void EulerXZY(){} // RVA: 0x7FFAC96A0BB0
        public void EulerYXZ(){} // RVA: 0x7FFAC96A0D30
        public void EulerYZX(){} // RVA: 0x7FFAC96A0EC0
        public void EulerZXY(){} // RVA: 0x7FFAC96A1050
        public void EulerZYX(){} // RVA: 0x7FFAC96A11D0
        public void Euler(){} // RVA: 0x7FFAC96A14D0 | overloaded x2
        public void RotateY(){} // RVA: 0x7FFAC96A1510
        public void LookRotationSafe(){} // RVA: 0x7FFAC96A1580
        public void Equals(){} // RVA: 0x7FFAC96A1920 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC969CBB0
        public void ToString(){} // RVA: 0x7FFAC96A1C30 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC96A1E60
    }

    public class uint2 : ValueType
    {
        public uint x; // 0x10
        public uint y; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC33D6D50
        public void op_Multiply(){} // RVA: 0x7FFAC96A1EB0
        public void Equals(){} // RVA: 0x7FFAC96A1ED0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC96A1F60
        public void ToString(){} // RVA: 0x7FFAC96A2080 | overloaded x2
    }

    public class uint3 : ValueType
    {
        public uint x; // 0x10
        public uint y; // 0x14
        public uint z; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC721A020
        public void op_Multiply(){} // RVA: 0x7FFAC96A2150
        public void op_Addition(){} // RVA: 0x7FFAC96A2180
        public void op_BitwiseAnd(){} // RVA: 0x7FFAC96A21A0
        public void op_ExclusiveOr(){} // RVA: 0x7FFAC96A21C0
        public void Equals(){} // RVA: 0x7FFAC96A2200 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC969CC60
        public void ToString(){} // RVA: 0x7FFAC96A23C0 | overloaded x2
    }

    public class uint4 : ValueType
    {
        public uint x; // 0x10
        public uint y; // 0x14
        public uint z; // 0x18
        public uint w; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96A24B0 | overloaded x2
        public void op_Multiply(){} // RVA: 0x7FFAC96A24C0
        public void op_Addition(){} // RVA: 0x7FFAC96A24F0
        public void op_OnesComplement(){} // RVA: 0x7FFAC96A2520
        public void op_BitwiseAnd(){} // RVA: 0x7FFAC96A2580 | overloaded x2
        public void op_BitwiseOr(){} // RVA: 0x7FFAC96A25B0
        public void op_ExclusiveOr(){} // RVA: 0x7FFAC96A25E0
        public void Equals(){} // RVA: 0x7FFAC96A2610 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC96A26C0
        public void ToString(){} // RVA: 0x7FFAC96A2950 | overloaded x2
    }

}