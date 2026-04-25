// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 5
// Methods: 258

namespace ThirdParty.Unity.UnityEngine
{
    public class Vector2 : ValueType
    {
        public float Item; // 0x10
        public float normalized; // 0x14
        public UnityEngine.Vector2 magnitude;
        public UnityEngine.Vector2 sqrMagnitude; // 0x8
        public UnityEngine.Vector2 zero; // 0x10
        public UnityEngine.Vector2 one; // 0x18
        public UnityEngine.Vector2 up; // 0x20
        public UnityEngine.Vector2 down; // 0x28
        public UnityEngine.Vector2 left; // 0x30
        public UnityEngine.Vector2 right; // 0x38
        public float positiveInfinity;
        public float negativeInfinity;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFAC36FF650
        public void set_Item(){} // RVA: 0x7FFAC98B2370
        public void .ctor(){} // RVA: 0x7FFAC2F44D10
        public void Set(){} // RVA: 0x7FFAC2F44D10
        public void Lerp(){} // RVA: 0x7FFAC98B23F0
        public void LerpUnclamped(){} // RVA: 0x7FFAC98B2460
        public void MoveTowards(){} // RVA: 0x7FFAC98B24B0
        public void Scale(){} // RVA: 0x7FFAC98B2630 | overloaded x2
        public void Normalize(){} // RVA: 0x7FFAC2F45EA0
        public void get_normalized(){} // RVA: 0x7FFAC98B2660
        public void ToString(){} // RVA: 0x7FFAC98B2730 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFAC98B28F0
        public void Equals(){} // RVA: 0x7FFAC8FB8C50 | overloaded x2
        public void Reflect(){} // RVA: 0x7FFAC98B29D0
        public void Perpendicular(){} // RVA: 0x7FFAC98B2A30
        public void Dot(){} // RVA: 0x7FFAC98B2A60
        public void get_magnitude(){} // RVA: 0x7FFAC98B2A90
        public void get_sqrMagnitude(){} // RVA: 0x7FFAC2F6E0D0
        public void Angle(){} // RVA: 0x7FFAC98B2B50
        public void SignedAngle(){} // RVA: 0x7FFAC98B2CB0
        public void Distance(){} // RVA: 0x7FFAC98B2D10
        public void ClampMagnitude(){} // RVA: 0x7FFAC98B2DC0
        public void SqrMagnitude(){} // RVA: 0x7FFAC2F6E0D0 | overloaded x2
        public void Min(){} // RVA: 0x7FFAC98B2EE0
        public void Max(){} // RVA: 0x7FFAC98B2F20
        public void SmoothDamp(){} // RVA: 0x7FFAC98B30C0 | overloaded x3
        public void op_Addition(){} // RVA: 0x7FFAC98B3370
        public void op_Subtraction(){} // RVA: 0x7FFAC98B33B0
        public void op_Multiply(){} // RVA: 0x7FFAC98B3460 | overloaded x3
        public void op_Division(){} // RVA: 0x7FFAC98B3490 | overloaded x2
        public void op_UnaryNegation(){} // RVA: 0x7FFAC98B3430
        public void op_Equality(){} // RVA: 0x7FFAC98B34C0
        public void op_Inequality(){} // RVA: 0x7FFAC98B3510
        public void op_Implicit(){} // RVA: 0x7FFAC98B3560 | overloaded x2
        public void get_zero(){} // RVA: 0x7FFAC98B3590
        public void get_one(){} // RVA: 0x7FFAC98B35E0
        public void get_up(){} // RVA: 0x7FFAC98B3630
        public void get_down(){} // RVA: 0x7FFAC98B3680
        public void get_left(){} // RVA: 0x7FFAC98B36D0
        public void get_right(){} // RVA: 0x7FFAC98B3720
        public void get_positiveInfinity(){} // RVA: 0x7FFAC98B3770
        public void get_negativeInfinity(){} // RVA: 0x7FFAC98B37C0
        public void .cctor(){} // RVA: 0x7FFAC98B3810
    }

    public class Vector2Int : ValueType
    {
        public int x; // 0x10
        public int y; // 0x14
        public UnityEngine.Vector2Int Item;
        public UnityEngine.Vector2Int magnitude; // 0x8
        public UnityEngine.Vector2Int sqrMagnitude; // 0x10
        public UnityEngine.Vector2Int zero; // 0x18
        public UnityEngine.Vector2Int one; // 0x20
        public UnityEngine.Vector2Int up; // 0x28

        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFAC8F93F90
        public void set_x(){} // RVA: 0x7FFAC336D8B0
        public void get_y(){} // RVA: 0x7FFAC69CBEA0
        public void set_y(){} // RVA: 0x7FFAC4420230
        public void .ctor(){} // RVA: 0x7FFAC33D6D50
        public void Set(){} // RVA: 0x7FFAC33D6D50
        public void get_Item(){} // RVA: 0x7FFAC98B3900
        public void set_Item(){} // RVA: 0x7FFAC98B39B0
        public void get_magnitude(){} // RVA: 0x7FFAC98B3A60
        public void get_sqrMagnitude(){} // RVA: 0x7FFAC98B3A90
        public void Distance(){} // RVA: 0x7FFAC98B3AA0
        public void Min(){} // RVA: 0x7FFAC98B3B60
        public void Max(){} // RVA: 0x7FFAC98B3B90
        public void Scale(){} // RVA: 0x7FFAC98B3BE0 | overloaded x2
        public void Clamp(){} // RVA: 0x7FFAC98B3C00
        public void op_Implicit(){} // RVA: 0x7FFAC98B3C90
        public void op_Explicit(){} // RVA: 0x7FFAC98B3CB0
        public void FloorToInt(){} // RVA: 0x7FFAC98B3CE0
        public void CeilToInt(){} // RVA: 0x7FFAC98B3D20
        public void RoundToInt(){} // RVA: 0x7FFAC98B3D60
        public void op_UnaryNegation(){} // RVA: 0x7FFAC98B3DA0
        public void op_Addition(){} // RVA: 0x7FFAC98B3DC0
        public void op_Subtraction(){} // RVA: 0x7FFAC98B3DE0
        public void op_Multiply(){} // RVA: 0x7FFAC98B3E20 | overloaded x3
        public void op_Division(){} // RVA: 0x7FFAC98B3E40
        public void op_Equality(){} // RVA: 0x7FFAC98B3E70
        public void op_Inequality(){} // RVA: 0x7FFAC98B3E90
        public void Equals(){} // RVA: 0x7FFAC98B3F50 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC98B3F70
        public void ToString(){} // RVA: 0x7FFAC98B3FA0 | overloaded x3
        public void get_zero(){} // RVA: 0x7FFAC98B4250
        public void get_one(){} // RVA: 0x7FFAC98B4290
        public void get_up(){} // RVA: 0x7FFAC98B42D0
        public void get_down(){} // RVA: 0x7FFAC98B4310
        public void get_left(){} // RVA: 0x7FFAC98B4350
        public void get_right(){} // RVA: 0x7FFAC98B4390
        public void .cctor(){} // RVA: 0x7FFAC98B43D0
    }

    public class Vector3 : ValueType
    {
        public float Item;
        public float normalized;
        public float magnitude; // 0x10
        public float sqrMagnitude; // 0x14
        public float zero; // 0x18
        public UnityEngine.Vector3 one;
        public UnityEngine.Vector3 forward; // 0xC
        public UnityEngine.Vector3 back; // 0x18
        public UnityEngine.Vector3 up; // 0x24
        public UnityEngine.Vector3 down; // 0x30
        public UnityEngine.Vector3 left; // 0x3C
        public UnityEngine.Vector3 right; // 0x48
        public UnityEngine.Vector3 positiveInfinity; // 0x54
        public UnityEngine.Vector3 negativeInfinity; // 0x60
        public UnityEngine.Vector3 negativeInfinityVector; // 0x6C

        // ── Methods ──
        public void Slerp(){} // RVA: 0x7FFAC98AD7D0
        public void SlerpUnclamped(){} // RVA: 0x7FFAC98AD860
        public void OrthoNormalize2(){} // RVA: 0x7FFAC98AD8F0
        public void OrthoNormalize(){} // RVA: 0x7FFAC98AD950 | overloaded x2
        public void OrthoNormalize3(){} // RVA: 0x7FFAC98AD950
        public void RotateTowards(){} // RVA: 0x7FFAC98AD9C0
        public void Lerp(){} // RVA: 0x7FFAC2F453E0
        public void LerpUnclamped(){} // RVA: 0x7FFAC98ADA60
        public void MoveTowards(){} // RVA: 0x7FFAC98ADAB0
        public void SmoothDamp(){} // RVA: 0x7FFAC98ADE30 | overloaded x3
        public void get_Item(){} // RVA: 0x7FFAC4852250
        public void set_Item(){} // RVA: 0x7FFAC3A89BF0
        public void .ctor(){} // RVA: 0x7FFAC98AE1A0 | overloaded x2
        public void Set(){} // RVA: 0x7FFAC2F44D70
        public void Scale(){} // RVA: 0x7FFAC98AE1F0 | overloaded x2
        public void Cross(){} // RVA: 0x7FFAC2F6DE60
        public void GetHashCode(){} // RVA: 0x7FFAC5DA2AE0
        public void Equals(){} // RVA: 0x7FFAC8BF9BC0 | overloaded x2
        public void Reflect(){} // RVA: 0x7FFAC98AE2D0
        public void Normalize(){} // RVA: 0x7FFAC2F6DDC0 | overloaded x2
        public void get_normalized(){} // RVA: 0x7FFAC2F452C0
        public void Dot(){} // RVA: 0x7FFAC2F455A0
        public void Project(){} // RVA: 0x7FFAC98AE350
        public void ProjectOnPlane(){} // RVA: 0x7FFAC98AE4A0
        public void Angle(){} // RVA: 0x7FFAC98AE5C0
        public void SignedAngle(){} // RVA: 0x7FFAC98AE730
        public void Distance(){} // RVA: 0x7FFAC98AE810
        public void ClampMagnitude(){} // RVA: 0x7FFAC98AE8E0
        public void Magnitude(){} // RVA: 0x7FFAC98AE9E0
        public void get_magnitude(){} // RVA: 0x7FFAC98AEA90
        public void SqrMagnitude(){} // RVA: 0x7FFAC98AEB80
        public void get_sqrMagnitude(){} // RVA: 0x7FFAC98AEB80
        public void Min(){} // RVA: 0x7FFAC98AEBB0
        public void Max(){} // RVA: 0x7FFAC98AEBF0
        public void get_zero(){} // RVA: 0x7FFAC98AEC30
        public void get_one(){} // RVA: 0x7FFAC98AEC80
        public void get_forward(){} // RVA: 0x7FFAC98AECD0
        public void get_back(){} // RVA: 0x7FFAC98AED20
        public void get_up(){} // RVA: 0x7FFAC98AED70
        public void get_down(){} // RVA: 0x7FFAC98AEDC0
        public void get_left(){} // RVA: 0x7FFAC98AEE10
        public void get_right(){} // RVA: 0x7FFAC98AEE60
        public void get_positiveInfinity(){} // RVA: 0x7FFAC98AEEB0
        public void get_negativeInfinity(){} // RVA: 0x7FFAC98AEF00
        public void op_Addition(){} // RVA: 0x7FFAC2F44D40
        public void op_Subtraction(){} // RVA: 0x7FFAC2F45290
        public void op_UnaryNegation(){} // RVA: 0x7FFAC2F44E20
        public void op_Multiply(){} // RVA: 0x7FFAC2F45450 | overloaded x2
        public void op_Division(){} // RVA: 0x7FFAC2F45AB0
        public void op_Equality(){} // RVA: 0x7FFAC98AEF50
        public void op_Inequality(){} // RVA: 0x7FFAC98AEF90
        public void ToString(){} // RVA: 0x7FFAC98AF010 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAC98AF220
        public void Slerp_Injected(){} // RVA: 0x7FFAC98AF3A0
        public void SlerpUnclamped_Injected(){} // RVA: 0x7FFAC98AF420
        public void RotateTowards_Injected(){} // RVA: 0x7FFAC98AF4A0
    }

    public class Vector3Int : ValueType
    {
        public int x; // 0x10
        public int y; // 0x14
        public int z; // 0x18
        public UnityEngine.Vector3Int Item;
        public UnityEngine.Vector3Int magnitude; // 0xC
        public UnityEngine.Vector3Int sqrMagnitude; // 0x18
        public UnityEngine.Vector3Int zero; // 0x24
        public UnityEngine.Vector3Int one; // 0x30
        public UnityEngine.Vector3Int up; // 0x3C
        public UnityEngine.Vector3Int down; // 0x48
        public UnityEngine.Vector3Int left; // 0x54

        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFAC8F93F90
        public void set_x(){} // RVA: 0x7FFAC336D8B0
        public void get_y(){} // RVA: 0x7FFAC69CBEA0
        public void set_y(){} // RVA: 0x7FFAC4420230
        public void get_z(){} // RVA: 0x7FFAC653D9A0
        public void set_z(){} // RVA: 0x7FFAC49C7510
        public void .ctor(){} // RVA: 0x7FFAC721A020 | overloaded x2
        public void Set(){} // RVA: 0x7FFAC721A020
        public void get_Item(){} // RVA: 0x7FFAC98B44E0
        public void set_Item(){} // RVA: 0x7FFAC98B45E0
        public void get_magnitude(){} // RVA: 0x7FFAC98B46E0
        public void get_sqrMagnitude(){} // RVA: 0x7FFAC98B4720
        public void Distance(){} // RVA: 0x7FFAC98B4740
        public void Min(){} // RVA: 0x7FFAC98B47C0
        public void Max(){} // RVA: 0x7FFAC98B4820
        public void Scale(){} // RVA: 0x7FFAC98B48C0 | overloaded x2
        public void Clamp(){} // RVA: 0x7FFAC98B48E0
        public void op_Implicit(){} // RVA: 0x7FFAC98B49A0
        public void op_Explicit(){} // RVA: 0x7FFAC98B49D0
        public void FloorToInt(){} // RVA: 0x7FFAC98B49F0
        public void CeilToInt(){} // RVA: 0x7FFAC98B4A50
        public void RoundToInt(){} // RVA: 0x7FFAC98B4AB0
        public void op_Addition(){} // RVA: 0x7FFAC98B4B10
        public void op_Subtraction(){} // RVA: 0x7FFAC98B4B50
        public void op_Multiply(){} // RVA: 0x7FFAC98B4C00 | overloaded x3
        public void op_UnaryNegation(){} // RVA: 0x7FFAC98B4B90
        public void op_Division(){} // RVA: 0x7FFAC98B4C40
        public void op_Equality(){} // RVA: 0x7FFAC98B4C80
        public void op_Inequality(){} // RVA: 0x7FFAC98B4CA0
        public void Equals(){} // RVA: 0x7FFAC98B4DC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC98B4E10
        public void ToString(){} // RVA: 0x7FFAC98B4E60 | overloaded x3
        public void get_zero(){} // RVA: 0x7FFAC98B51F0
        public void get_one(){} // RVA: 0x7FFAC98B5240
        public void get_up(){} // RVA: 0x7FFAC98B5290
        public void get_down(){} // RVA: 0x7FFAC98B52E0
        public void get_left(){} // RVA: 0x7FFAC98B5330
        public void get_right(){} // RVA: 0x7FFAC98B5380
        public void get_forward(){} // RVA: 0x7FFAC98B53D0
        public void get_back(){} // RVA: 0x7FFAC98B5420
        public void .cctor(){} // RVA: 0x7FFAC98B5470
    }

    public class Vector4 : ValueType
    {
        public float Item;
        public float normalized; // 0x10
        public float magnitude; // 0x14
        public float sqrMagnitude; // 0x18
        public float zero; // 0x1C
        public UnityEngine.Vector4 one;
        public UnityEngine.Vector4 positiveInfinity; // 0x10
        public UnityEngine.Vector4 negativeInfinity; // 0x20
        public UnityEngine.Vector4 negativeInfinityVector; // 0x30

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFAC2F459C0
        public void set_Item(){} // RVA: 0x7FFAC36FF6D0
        public void .ctor(){} // RVA: 0x7FFAC98B55F0 | overloaded x3
        public void Set(){} // RVA: 0x7FFAC2F45570
        public void Lerp(){} // RVA: 0x7FFAC2F6DEC0
        public void LerpUnclamped(){} // RVA: 0x7FFAC98A8A00
        public void MoveTowards(){} // RVA: 0x7FFAC98B5600
        public void Scale(){} // RVA: 0x7FFAC98B57C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC3AB0630
        public void Equals(){} // RVA: 0x7FFAC8F79BA0 | overloaded x2
        public void Normalize(){} // RVA: 0x7FFAC98B5990 | overloaded x2
        public void get_normalized(){} // RVA: 0x7FFAC451BB70
        public void Dot(){} // RVA: 0x7FFAC98AFF40
        public void Project(){} // RVA: 0x7FFAC98B5A40
        public void Distance(){} // RVA: 0x7FFAC98B5B40
        public void Magnitude(){} // RVA: 0x7FFAC98B5BC0
        public void get_magnitude(){} // RVA: 0x7FFAC98B5C90
        public void get_sqrMagnitude(){} // RVA: 0x7FFAC98B5D60
        public void Min(){} // RVA: 0x7FFAC98B5DB0
        public void Max(){} // RVA: 0x7FFAC98B5E10
        public void get_zero(){} // RVA: 0x7FFAC98B5E70
        public void get_one(){} // RVA: 0x7FFAC98B5EC0
        public void get_positiveInfinity(){} // RVA: 0x7FFAC98B5F10
        public void get_negativeInfinity(){} // RVA: 0x7FFAC98B5F60
        public void op_Addition(){} // RVA: 0x7FFAC98A8740
        public void op_Subtraction(){} // RVA: 0x7FFAC98A87A0
        public void op_UnaryNegation(){} // RVA: 0x7FFAC98B5FB0
        public void op_Multiply(){} // RVA: 0x7FFAC98A88B0 | overloaded x2
        public void op_Division(){} // RVA: 0x7FFAC98A8900
        public void op_Equality(){} // RVA: 0x7FFAC98B5FD0
        public void op_Inequality(){} // RVA: 0x7FFAC98B6030
        public void op_Implicit(){} // RVA: 0x7FFAC98666C0 | overloaded x4
        public void ToString(){} // RVA: 0x7FFAC98B6170 | overloaded x3
        public void SqrMagnitude(){} // RVA: 0x7FFAC98B5D60 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC98B63D0
    }

}