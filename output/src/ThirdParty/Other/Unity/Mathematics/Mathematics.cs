// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Mathematics
// Classes: 11
// Methods: 272

namespace ThirdParty.Other.Unity.Mathematics
{
    public class bool3 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82BC9960
        public void Equals(){} // RVA: 0x7FFE87A45330 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87A3FC40
        public void ToString(){} // RVA: 0x7FFE87A453D0
    }

    public class float2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8111ED10
        public void op_Multiply(){} // RVA: 0x7FFE87A454E0
        public void Equals(){} // RVA: 0x7FFE87A45510 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87A455B0
        public void ToString(){} // RVA: 0x7FFE87A456F0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFE87A457C0
    }

    public class float3 : ValueType
    {
        public float x; // 0x10
        public float y; // 0x14
        public float z; // 0x18
        public Unity.Mathematics.float3 zero;
        public object field_4; // 0x7
        public object field_5;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87361830 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFE827F5210 | overloaded x3
        public void op_Multiply(){} // RVA: 0x7FFE87A45830 | overloaded x3
        public void op_Addition(){} // RVA: 0x7FFE87A45860 | overloaded x2
        public void op_Subtraction(){} // RVA: 0x7FFE87361880
        public void op_Division(){} // RVA: 0x7FFE87A45890 | overloaded x2
        public void op_LessThan(){} // RVA: 0x7FFE87A458C0
        public void op_GreaterThan(){} // RVA: 0x7FFE87A45900
        public void op_UnaryNegation(){} // RVA: 0x7FFE87A45940
        public void get_yxxy(){} // RVA: 0x7FFE87A45980
        public void get_zzyz(){} // RVA: 0x7FFE87A459A0
        public void get_xyz(){} // RVA: 0x7FFE827F5210
        public void get_yzx(){} // RVA: 0x7FFE87A459C0
        public void get_zxy(){} // RVA: 0x7FFE87A459E0
        public void get_Item(){} // RVA: 0x7FFE835C55B0
        public void Equals(){} // RVA: 0x7FFE87A45A00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87A45AB0
        public void ToString(){} // RVA: 0x7FFE87A45C20 | overloaded x2
    }

    public class float3x3 : ValueType
    {
        public Unity.Mathematics.float3 c0; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A468B0 | overloaded x4
        public void op_Multiply(){} // RVA: 0x7FFE87A45DB0
        public void get_Item(){} // RVA: 0x7FFE835C2710
        public void Equals(){} // RVA: 0x7FFE87A45F30 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87A45FD0
        public void ToString(){} // RVA: 0x7FFE87A46490 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87A46B90
    }

    public class float4 : ValueType
    {
        public float x; // 0x10
        public float y; // 0x14
        public float z; // 0x18
        public float w; // 0x1C
        public Unity.Mathematics.float4 zero;
        public object System;
        public object System;
        public object field_7; // 0x1B80
        public object field_8;
        public object field_9;
        public object field_10;
        public object field_11;
        public object field_12;
        public object field_13; // 0x7690

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A46C10 | overloaded x3
        public void op_Implicit(){} // RVA: 0x7FFE827D9F70 | overloaded x3
        public void op_Multiply(){} // RVA: 0x7FFE87A46C90 | overloaded x3
        public void op_Addition(){} // RVA: 0x7FFE87A46CB0
        public void op_Subtraction(){} // RVA: 0x7FFE87A46D00
        public void op_Division(){} // RVA: 0x7FFE87A46D50
        public void op_UnaryNegation(){} // RVA: 0x7FFE87A46DA0
        public void get_xyzx(){} // RVA: 0x7FFE87A46DC0
        public void get_yzxy(){} // RVA: 0x7FFE87A46DE0
        public void get_yzxz(){} // RVA: 0x7FFE87A46E00
        public void get_yzxw(){} // RVA: 0x7FFE87A46E20
        public void get_zxyy(){} // RVA: 0x7FFE87A46E40
        public void get_zxyz(){} // RVA: 0x7FFE87A46E60
        public void get_zwxy(){} // RVA: 0x7FFE87A46E80
        public void get_wzyx(){} // RVA: 0x7FFE87A46EA0
        public void get_wwwx(){} // RVA: 0x7FFE87A46EC0
        public void get_wwww(){} // RVA: 0x7FFE87A46EE0
        public void get_xyz(){} // RVA: 0x7FFE827F5210
        public void get_yxw(){} // RVA: 0x7FFE87A46F00
        public void get_zwx(){} // RVA: 0x7FFE87A46F20
        public void get_wzy(){} // RVA: 0x7FFE87A46F40
        public void Equals(){} // RVA: 0x7FFE87A46F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87A40100
        public void ToString(){} // RVA: 0x7FFE87A47270 | overloaded x2
    }

    public class float4x4 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A474D0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE87A47740 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87A477F0
        public void ToString(){} // RVA: 0x7FFE87A47EB0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFE87A48550 | overloaded x2
        public void TRS(){} // RVA: 0x7FFE87A48600
        public void .cctor(){} // RVA: 0x7FFE87A487E0
    }

    public class math : Object
    {
        // ── Methods ──
        public void hash(){} // RVA: 0x7FFE87A452F0 | overloaded x10
        public void float3(){} // RVA: 0x7FFE87A3FCF0
        public void float3x3(){} // RVA: 0x7FFE87A43DF0 | overloaded x2
        public void inverse(){} // RVA: 0x7FFE87A44880 | overloaded x3
        public void float4(){} // RVA: 0x7FFE87A400F0 | overloaded x3
        public void shuffle(){} // RVA: 0x7FFE87A40140
        public void select_shuffle_component(){} // RVA: 0x7FFE87A40260
        public void float4x4(){} // RVA: 0x7FFE87A40390
        public void rotate(){} // RVA: 0x7FFE8273F5D0 | overloaded x2
        public void transform(){} // RVA: 0x7FFE87A40470
        public void determinant(){} // RVA: 0x7FFE87A42680
        public void asint(){} // RVA: 0x7FFE868B6050
        public void asuint(){} // RVA: 0x7FFE8151C410 | overloaded x4
        public void asfloat(){} // RVA: 0x7FFE8151C410 | overloaded x3
        public void isfinite(){} // RVA: 0x7FFE87A42A00
        public void isnan(){} // RVA: 0x7FFE869F3260
        public void min(){} // RVA: 0x7FFE87A42A60 | overloaded x4
        public void max(){} // RVA: 0x7FFE87A42B20 | overloaded x4
        public void lerp(){} // RVA: 0x7FFE87A42BA0 | overloaded x2
        public void unlerp(){} // RVA: 0x7FFE86FDC5B0
        public void remap(){} // RVA: 0x7FFE87A42C10
        public void clamp(){} // RVA: 0x7FFE87A42C70 | overloaded x2
        public void saturate(){} // RVA: 0x7FFE87A42D70
        public void abs(){} // RVA: 0x7FFE87A42DC0 | overloaded x2
        public void dot(){} // RVA: 0x7FFE87A44930 | overloaded x3
        public void atan2(){} // RVA: 0x7FFE87A42E90
        public void cos(){} // RVA: 0x7FFE87A42F60 | overloaded x2
        public void acos(){} // RVA: 0x7FFE87A42FD0
        public void sin(){} // RVA: 0x7FFE87A43090 | overloaded x2
        public void asin(){} // RVA: 0x7FFE87A43100
        public void floor(){} // RVA: 0x7FFE87A43160
        public void ceil(){} // RVA: 0x7FFE87A431C0
        public void frac(){} // RVA: 0x7FFE87A43220
        public void rcp(){} // RVA: 0x7FFE87A43250
        public void sign(){} // RVA: 0x7FFE87A43290 | overloaded x2
        public void pow(){} // RVA: 0x7FFE87A43390 | overloaded x2
        public void sqrt(){} // RVA: 0x7FFE87A43410
        public void rsqrt(){} // RVA: 0x7FFE87A43490
        public void normalize(){} // RVA: 0x7FFE87A449D0 | overloaded x3
        public void normalizesafe(){} // RVA: 0x7FFE87A44AB0 | overloaded x2
        public void length(){} // RVA: 0x7FFE87A436C0
        public void lengthsq(){} // RVA: 0x7FFE87A44980 | overloaded x2
        public void distance(){} // RVA: 0x7FFE87A43740
        public void cross(){} // RVA: 0x7FFE87A43790
        public void any(){} // RVA: 0x7FFE87A43810
        public void all(){} // RVA: 0x7FFE87A43840
        public void select(){} // RVA: 0x7FFE87A438E0 | overloaded x3
        public void sincos(){} // RVA: 0x7FFE87A43940 | overloaded x2
        public void lzcnt(){} // RVA: 0x7FFE87A439E0 | overloaded x2
        public void tzcnt(){} // RVA: 0x7FFE87A43A30 | overloaded x2
        public void ceilpow2(){} // RVA: 0x7FFE861F6240
        public void radians(){} // RVA: 0x7FFE87A43A90 | overloaded x2
        public void cmin(){} // RVA: 0x7FFE87A43AD0
        public void cmax(){} // RVA: 0x7FFE8238F1C0
        public void csum(){} // RVA: 0x7FFE87A43B40 | overloaded x5
        public void chgsign(){} // RVA: 0x7FFE87A43B60
        public void movelh(){} // RVA: 0x7FFE87A43BF0
        public void movehl(){} // RVA: 0x7FFE87A43CF0
        public void mul(){} // RVA: 0x7FFE8273F5D0 | overloaded x6
        public void quaternion(){} // RVA: 0x7FFE87A44840 | overloaded x3
        public void nlerp(){} // RVA: 0x7FFE87A44D50
        public void slerp(){} // RVA: 0x7FFE87A44F50
        public void uint2(){} // RVA: 0x7FFE87A45200
        public void uint3(){} // RVA: 0x7FFE87A45260
        public void uint4(){} // RVA: 0x7FFE87A452E0 | overloaded x2
    }

    public class quaternion : ValueType
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFE8151C410 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFE87A48BB0 | overloaded x4
        public void AxisAngle(){} // RVA: 0x7FFE87A48F10
        public void EulerXYZ(){} // RVA: 0x7FFE87A48FA0
        public void EulerXZY(){} // RVA: 0x7FFE87A49120
        public void EulerYXZ(){} // RVA: 0x7FFE87A492A0
        public void EulerYZX(){} // RVA: 0x7FFE87A49430
        public void EulerZXY(){} // RVA: 0x7FFE87A495C0
        public void EulerZYX(){} // RVA: 0x7FFE87A49740
        public void Euler(){} // RVA: 0x7FFE87A49A40 | overloaded x2
        public void RotateY(){} // RVA: 0x7FFE87A49A80
        public void LookRotationSafe(){} // RVA: 0x7FFE87A49AF0
        public void Equals(){} // RVA: 0x7FFE87A49E90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87A451C0
        public void ToString(){} // RVA: 0x7FFE87A4A1A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87A4A3D0
    }

    public class uint2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8164E250
        public void op_Multiply(){} // RVA: 0x7FFE87A4A420
        public void Equals(){} // RVA: 0x7FFE87A4A440 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87A4A4D0
        public void ToString(){} // RVA: 0x7FFE87A4A5F0 | overloaded x2
    }

    public class uint3 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE855D5D40
        public void op_Multiply(){} // RVA: 0x7FFE87A4A6C0
        public void op_Addition(){} // RVA: 0x7FFE87A4A6F0
        public void op_BitwiseAnd(){} // RVA: 0x7FFE87A4A710
        public void op_ExclusiveOr(){} // RVA: 0x7FFE87A4A730
        public void Equals(){} // RVA: 0x7FFE87A4A770 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87A45270
        public void ToString(){} // RVA: 0x7FFE87A4A930 | overloaded x2
    }

    public class uint4 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A4AA20 | overloaded x2
        public void op_Multiply(){} // RVA: 0x7FFE87A4AA30
        public void op_Addition(){} // RVA: 0x7FFE87A4AA60
        public void op_OnesComplement(){} // RVA: 0x7FFE87A4AA90
        public void op_BitwiseAnd(){} // RVA: 0x7FFE87A4AAF0 | overloaded x2
        public void op_BitwiseOr(){} // RVA: 0x7FFE87A4AB20
        public void op_ExclusiveOr(){} // RVA: 0x7FFE87A4AB50
        public void Equals(){} // RVA: 0x7FFE87A4AB80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87A4AC30
        public void ToString(){} // RVA: 0x7FFE87A4AEC0 | overloaded x2
    }

}