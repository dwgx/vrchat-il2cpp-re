// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 5
// Methods: 258

namespace ThirdParty.Unity.UnityEngine
{
    public class Vector2 : ValueType
    {
        public object Item;
        public object normalized;
        public object magnitude;
        public object sqrMagnitude;
        public object zero;
        public object one;
        public object up;
        public object down;
        public object left;
        public object right;
        public object positiveInfinity;
        public object negativeInfinity;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFD4EB1F650
        public void set_Item(){} // RVA: 0x7FFD54CD2370
        public void .ctor(){} // RVA: 0x7FFD4E364D10
        public void Set(){} // RVA: 0x7FFD4E364D10
        public void Lerp(){} // RVA: 0x7FFD54CD23F0
        public void LerpUnclamped(){} // RVA: 0x7FFD54CD2460
        public void MoveTowards(){} // RVA: 0x7FFD54CD24B0
        public void Scale(){} // RVA: 0x7FFD54CD2630 | overloaded x2
        public void Normalize(){} // RVA: 0x7FFD4E365EA0
        public void get_normalized(){} // RVA: 0x7FFD54CD2660
        public void ToString(){} // RVA: 0x7FFD54CD2730 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFD54CD28F0
        public void Equals(){} // RVA: 0x7FFD543D8C50 | overloaded x2
        public void Reflect(){} // RVA: 0x7FFD54CD29D0
        public void Perpendicular(){} // RVA: 0x7FFD54CD2A30
        public void Dot(){} // RVA: 0x7FFD54CD2A60
        public void get_magnitude(){} // RVA: 0x7FFD54CD2A90
        public void get_sqrMagnitude(){} // RVA: 0x7FFD4E38E0D0
        public void Angle(){} // RVA: 0x7FFD54CD2B50
        public void SignedAngle(){} // RVA: 0x7FFD54CD2CB0
        public void Distance(){} // RVA: 0x7FFD54CD2D10
        public void ClampMagnitude(){} // RVA: 0x7FFD54CD2DC0
        public void SqrMagnitude(){} // RVA: 0x7FFD4E38E0D0 | overloaded x2
        public void Min(){} // RVA: 0x7FFD54CD2EE0
        public void Max(){} // RVA: 0x7FFD54CD2F20
        public void SmoothDamp(){} // RVA: 0x7FFD54CD30C0 | overloaded x3
        public void op_Addition(){} // RVA: 0x7FFD54CD3370
        public void op_Subtraction(){} // RVA: 0x7FFD54CD33B0
        public void op_Multiply(){} // RVA: 0x7FFD54CD3460 | overloaded x3
        public void op_Division(){} // RVA: 0x7FFD54CD3490 | overloaded x2
        public void op_UnaryNegation(){} // RVA: 0x7FFD54CD3430
        public void op_Equality(){} // RVA: 0x7FFD54CD34C0
        public void op_Inequality(){} // RVA: 0x7FFD54CD3510
        public void op_Implicit(){} // RVA: 0x7FFD54CD3560 | overloaded x2
        public void get_zero(){} // RVA: 0x7FFD54CD3590
        public void get_one(){} // RVA: 0x7FFD54CD35E0
        public void get_up(){} // RVA: 0x7FFD54CD3630
        public void get_down(){} // RVA: 0x7FFD54CD3680
        public void get_left(){} // RVA: 0x7FFD54CD36D0
        public void get_right(){} // RVA: 0x7FFD54CD3720
        public void get_positiveInfinity(){} // RVA: 0x7FFD54CD3770
        public void get_negativeInfinity(){} // RVA: 0x7FFD54CD37C0
        public void .cctor(){} // RVA: 0x7FFD54CD3810
    }

    public class Vector2Int : ValueType
    {
        public object x;
        public object y;
        public object Item;
        public object magnitude;
        public object sqrMagnitude;
        public object zero;
        public object one;
        public object up;
        public object down;
        public object left;
        public object right;

        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFD543B3F90
        public void set_x(){} // RVA: 0x7FFD4E78D8B0
        public void get_y(){} // RVA: 0x7FFD51DEBEA0
        public void set_y(){} // RVA: 0x7FFD4F840230
        public void .ctor(){} // RVA: 0x7FFD4E7F6D50
        public void Set(){} // RVA: 0x7FFD4E7F6D50
        public void get_Item(){} // RVA: 0x7FFD54CD3900
        public void set_Item(){} // RVA: 0x7FFD54CD39B0
        public void get_magnitude(){} // RVA: 0x7FFD54CD3A60
        public void get_sqrMagnitude(){} // RVA: 0x7FFD54CD3A90
        public void Distance(){} // RVA: 0x7FFD54CD3AA0
        public void Min(){} // RVA: 0x7FFD54CD3B60
        public void Max(){} // RVA: 0x7FFD54CD3B90
        public void Scale(){} // RVA: 0x7FFD54CD3BE0 | overloaded x2
        public void Clamp(){} // RVA: 0x7FFD54CD3C00
        public void op_Implicit(){} // RVA: 0x7FFD54CD3C90
        public void op_Explicit(){} // RVA: 0x7FFD54CD3CB0
        public void FloorToInt(){} // RVA: 0x7FFD54CD3CE0
        public void CeilToInt(){} // RVA: 0x7FFD54CD3D20
        public void RoundToInt(){} // RVA: 0x7FFD54CD3D60
        public void op_UnaryNegation(){} // RVA: 0x7FFD54CD3DA0
        public void op_Addition(){} // RVA: 0x7FFD54CD3DC0
        public void op_Subtraction(){} // RVA: 0x7FFD54CD3DE0
        public void op_Multiply(){} // RVA: 0x7FFD54CD3E20 | overloaded x3
        public void op_Division(){} // RVA: 0x7FFD54CD3E40
        public void op_Equality(){} // RVA: 0x7FFD54CD3E70
        public void op_Inequality(){} // RVA: 0x7FFD54CD3E90
        public void Equals(){} // RVA: 0x7FFD54CD3F50 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54CD3F70
        public void ToString(){} // RVA: 0x7FFD54CD3FA0 | overloaded x3
        public void get_zero(){} // RVA: 0x7FFD54CD4250
        public void get_one(){} // RVA: 0x7FFD54CD4290
        public void get_up(){} // RVA: 0x7FFD54CD42D0
        public void get_down(){} // RVA: 0x7FFD54CD4310
        public void get_left(){} // RVA: 0x7FFD54CD4350
        public void get_right(){} // RVA: 0x7FFD54CD4390
        public void .cctor(){} // RVA: 0x7FFD54CD43D0
    }

    public class Vector3 : ValueType
    {
        public object Item;
        public object normalized;
        public object magnitude;
        public object sqrMagnitude;
        public object zero;
        public object one;
        public object forward;
        public object back;
        public object up;
        public object down;
        public object left;
        public object right;
        public object positiveInfinity;
        public object negativeInfinity;

        // ── Methods ──
        public void Slerp(){} // RVA: 0x7FFD54CCD7D0
        public void SlerpUnclamped(){} // RVA: 0x7FFD54CCD860
        public void OrthoNormalize2(){} // RVA: 0x7FFD54CCD8F0
        public void OrthoNormalize(){} // RVA: 0x7FFD54CCD950 | overloaded x2
        public void OrthoNormalize3(){} // RVA: 0x7FFD54CCD950
        public void RotateTowards(){} // RVA: 0x7FFD54CCD9C0
        public void Lerp(){} // RVA: 0x7FFD4E3653E0
        public void LerpUnclamped(){} // RVA: 0x7FFD54CCDA60
        public void MoveTowards(){} // RVA: 0x7FFD54CCDAB0
        public void SmoothDamp(){} // RVA: 0x7FFD54CCDE30 | overloaded x3
        public void get_Item(){} // RVA: 0x7FFD4FC72250
        public void set_Item(){} // RVA: 0x7FFD4EEA9BF0
        public void .ctor(){} // RVA: 0x7FFD54CCE1A0 | overloaded x2
        public void Set(){} // RVA: 0x7FFD4E364D70
        public void Scale(){} // RVA: 0x7FFD54CCE1F0 | overloaded x2
        public void Cross(){} // RVA: 0x7FFD4E38DE60
        public void GetHashCode(){} // RVA: 0x7FFD511C2AE0
        public void Equals(){} // RVA: 0x7FFD54019BC0 | overloaded x2
        public void Reflect(){} // RVA: 0x7FFD54CCE2D0
        public void Normalize(){} // RVA: 0x7FFD4E38DDC0 | overloaded x2
        public void get_normalized(){} // RVA: 0x7FFD4E3652C0
        public void Dot(){} // RVA: 0x7FFD4E3655A0
        public void Project(){} // RVA: 0x7FFD54CCE350
        public void ProjectOnPlane(){} // RVA: 0x7FFD54CCE4A0
        public void Angle(){} // RVA: 0x7FFD54CCE5C0
        public void SignedAngle(){} // RVA: 0x7FFD54CCE730
        public void Distance(){} // RVA: 0x7FFD54CCE810
        public void ClampMagnitude(){} // RVA: 0x7FFD54CCE8E0
        public void Magnitude(){} // RVA: 0x7FFD54CCE9E0
        public void get_magnitude(){} // RVA: 0x7FFD54CCEA90
        public void SqrMagnitude(){} // RVA: 0x7FFD54CCEB80
        public void get_sqrMagnitude(){} // RVA: 0x7FFD54CCEB80
        public void Min(){} // RVA: 0x7FFD54CCEBB0
        public void Max(){} // RVA: 0x7FFD54CCEBF0
        public void get_zero(){} // RVA: 0x7FFD54CCEC30
        public void get_one(){} // RVA: 0x7FFD54CCEC80
        public void get_forward(){} // RVA: 0x7FFD54CCECD0
        public void get_back(){} // RVA: 0x7FFD54CCED20
        public void get_up(){} // RVA: 0x7FFD54CCED70
        public void get_down(){} // RVA: 0x7FFD54CCEDC0
        public void get_left(){} // RVA: 0x7FFD54CCEE10
        public void get_right(){} // RVA: 0x7FFD54CCEE60
        public void get_positiveInfinity(){} // RVA: 0x7FFD54CCEEB0
        public void get_negativeInfinity(){} // RVA: 0x7FFD54CCEF00
        public void op_Addition(){} // RVA: 0x7FFD4E364D40
        public void op_Subtraction(){} // RVA: 0x7FFD4E365290
        public void op_UnaryNegation(){} // RVA: 0x7FFD4E364E20
        public void op_Multiply(){} // RVA: 0x7FFD4E365450 | overloaded x2
        public void op_Division(){} // RVA: 0x7FFD4E365AB0
        public void op_Equality(){} // RVA: 0x7FFD54CCEF50
        public void op_Inequality(){} // RVA: 0x7FFD54CCEF90
        public void ToString(){} // RVA: 0x7FFD54CCF010 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFD54CCF220
        public void Slerp_Injected(){} // RVA: 0x7FFD54CCF3A0
        public void SlerpUnclamped_Injected(){} // RVA: 0x7FFD54CCF420
        public void RotateTowards_Injected(){} // RVA: 0x7FFD54CCF4A0
    }

    public class Vector3Int : ValueType
    {
        public object x;
        public object y;
        public object z;
        public object Item;
        public object magnitude;
        public object sqrMagnitude;
        public object zero;
        public object one;
        public object up;
        public object down;
        public object left;
        public object right;
        public object forward;
        public object back;

        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFD543B3F90
        public void set_x(){} // RVA: 0x7FFD4E78D8B0
        public void get_y(){} // RVA: 0x7FFD51DEBEA0
        public void set_y(){} // RVA: 0x7FFD4F840230
        public void get_z(){} // RVA: 0x7FFD5195D9A0
        public void set_z(){} // RVA: 0x7FFD4FDE7510
        public void .ctor(){} // RVA: 0x7FFD5263A020 | overloaded x2
        public void Set(){} // RVA: 0x7FFD5263A020
        public void get_Item(){} // RVA: 0x7FFD54CD44E0
        public void set_Item(){} // RVA: 0x7FFD54CD45E0
        public void get_magnitude(){} // RVA: 0x7FFD54CD46E0
        public void get_sqrMagnitude(){} // RVA: 0x7FFD54CD4720
        public void Distance(){} // RVA: 0x7FFD54CD4740
        public void Min(){} // RVA: 0x7FFD54CD47C0
        public void Max(){} // RVA: 0x7FFD54CD4820
        public void Scale(){} // RVA: 0x7FFD54CD48C0 | overloaded x2
        public void Clamp(){} // RVA: 0x7FFD54CD48E0
        public void op_Implicit(){} // RVA: 0x7FFD54CD49A0
        public void op_Explicit(){} // RVA: 0x7FFD54CD49D0
        public void FloorToInt(){} // RVA: 0x7FFD54CD49F0
        public void CeilToInt(){} // RVA: 0x7FFD54CD4A50
        public void RoundToInt(){} // RVA: 0x7FFD54CD4AB0
        public void op_Addition(){} // RVA: 0x7FFD54CD4B10
        public void op_Subtraction(){} // RVA: 0x7FFD54CD4B50
        public void op_Multiply(){} // RVA: 0x7FFD54CD4C00 | overloaded x3
        public void op_UnaryNegation(){} // RVA: 0x7FFD54CD4B90
        public void op_Division(){} // RVA: 0x7FFD54CD4C40
        public void op_Equality(){} // RVA: 0x7FFD54CD4C80
        public void op_Inequality(){} // RVA: 0x7FFD54CD4CA0
        public void Equals(){} // RVA: 0x7FFD54CD4DC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54CD4E10
        public void ToString(){} // RVA: 0x7FFD54CD4E60 | overloaded x3
        public void get_zero(){} // RVA: 0x7FFD54CD51F0
        public void get_one(){} // RVA: 0x7FFD54CD5240
        public void get_up(){} // RVA: 0x7FFD54CD5290
        public void get_down(){} // RVA: 0x7FFD54CD52E0
        public void get_left(){} // RVA: 0x7FFD54CD5330
        public void get_right(){} // RVA: 0x7FFD54CD5380
        public void get_forward(){} // RVA: 0x7FFD54CD53D0
        public void get_back(){} // RVA: 0x7FFD54CD5420
        public void .cctor(){} // RVA: 0x7FFD54CD5470
    }

    public class Vector4 : ValueType
    {
        public object Item;
        public object normalized;
        public object magnitude;
        public object sqrMagnitude;
        public object zero;
        public object one;
        public object positiveInfinity;
        public object negativeInfinity;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFD4E3659C0
        public void set_Item(){} // RVA: 0x7FFD4EB1F6D0
        public void .ctor(){} // RVA: 0x7FFD54CD55F0 | overloaded x3
        public void Set(){} // RVA: 0x7FFD4E365570
        public void Lerp(){} // RVA: 0x7FFD4E38DEC0
        public void LerpUnclamped(){} // RVA: 0x7FFD54CC8A00
        public void MoveTowards(){} // RVA: 0x7FFD54CD5600
        public void Scale(){} // RVA: 0x7FFD54CD57C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4EED0630
        public void Equals(){} // RVA: 0x7FFD54399BA0 | overloaded x2
        public void Normalize(){} // RVA: 0x7FFD54CD5990 | overloaded x2
        public void get_normalized(){} // RVA: 0x7FFD4F93BB70
        public void Dot(){} // RVA: 0x7FFD54CCFF40
        public void Project(){} // RVA: 0x7FFD54CD5A40
        public void Distance(){} // RVA: 0x7FFD54CD5B40
        public void Magnitude(){} // RVA: 0x7FFD54CD5BC0
        public void get_magnitude(){} // RVA: 0x7FFD54CD5C90
        public void get_sqrMagnitude(){} // RVA: 0x7FFD54CD5D60
        public void Min(){} // RVA: 0x7FFD54CD5DB0
        public void Max(){} // RVA: 0x7FFD54CD5E10
        public void get_zero(){} // RVA: 0x7FFD54CD5E70
        public void get_one(){} // RVA: 0x7FFD54CD5EC0
        public void get_positiveInfinity(){} // RVA: 0x7FFD54CD5F10
        public void get_negativeInfinity(){} // RVA: 0x7FFD54CD5F60
        public void op_Addition(){} // RVA: 0x7FFD54CC8740
        public void op_Subtraction(){} // RVA: 0x7FFD54CC87A0
        public void op_UnaryNegation(){} // RVA: 0x7FFD54CD5FB0
        public void op_Multiply(){} // RVA: 0x7FFD54CC88B0 | overloaded x2
        public void op_Division(){} // RVA: 0x7FFD54CC8900
        public void op_Equality(){} // RVA: 0x7FFD54CD5FD0
        public void op_Inequality(){} // RVA: 0x7FFD54CD6030
        public void op_Implicit(){} // RVA: 0x7FFD54C866C0 | overloaded x4
        public void ToString(){} // RVA: 0x7FFD54CD6170 | overloaded x3
        public void SqrMagnitude(){} // RVA: 0x7FFD54CD5D60 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD54CD63D0
    }

}