// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 5
// Methods: 258

namespace ThirdParty.Unity.UnityEngine
{
    public class Vector2 : ValueType
    {
        public float x; // 0x10
        public float y; // 0x14
        public UnityEngine.Vector2 zeroVector;
        public UnityEngine.Vector2 oneVector; // 0x8
        public UnityEngine.Vector2 upVector; // 0x10
        public UnityEngine.Vector2 downVector; // 0x18
        public UnityEngine.Vector2 leftVector; // 0x20
        public UnityEngine.Vector2 rightVector; // 0x28
        public UnityEngine.Vector2 positiveInfinityVector; // 0x30
        public UnityEngine.Vector2 negativeInfinityVector; // 0x38
        public float kEpsilon;
        public float kEpsilonNormalSqrt;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFE81855890
        public void set_Item(){} // RVA: 0x7FFE87C5AB90
        public void .ctor(){} // RVA: 0x7FFE8111ED10
        public void Set(){} // RVA: 0x7FFE8111ED10
        public void Lerp(){} // RVA: 0x7FFE87C5AC10
        public void LerpUnclamped(){} // RVA: 0x7FFE87C5AC80
        public void MoveTowards(){} // RVA: 0x7FFE87C5ACD0
        public void Scale(){} // RVA: 0x7FFE87C5AE10 | overloaded x2
        public void Normalize(){} // RVA: 0x7FFE8111FEA0
        public void get_normalized(){} // RVA: 0x7FFE87C5AE40
        public void ToString(){} // RVA: 0x7FFE87C5AF10 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE87C5B0D0
        public void Equals(){} // RVA: 0x7FFE87361150 | overloaded x2
        public void Reflect(){} // RVA: 0x7FFE87C5B1B0
        public void Perpendicular(){} // RVA: 0x7FFE87C5B210
        public void Dot(){} // RVA: 0x7FFE87C5B240
        public void get_magnitude(){} // RVA: 0x7FFE87C5B270
        public void get_sqrMagnitude(){} // RVA: 0x7FFE811480D0
        public void Angle(){} // RVA: 0x7FFE87C5B330
        public void SignedAngle(){} // RVA: 0x7FFE87C5B490
        public void Distance(){} // RVA: 0x7FFE87C5B4F0
        public void ClampMagnitude(){} // RVA: 0x7FFE87C5B5A0
        public void SqrMagnitude(){} // RVA: 0x7FFE811480D0 | overloaded x2
        public void Min(){} // RVA: 0x7FFE87C5B6C0
        public void Max(){} // RVA: 0x7FFE87C5B700
        public void SmoothDamp(){} // RVA: 0x7FFE87C5B8A0 | overloaded x3
        public void op_Addition(){} // RVA: 0x7FFE87361180
        public void op_Subtraction(){} // RVA: 0x7FFE873611C0
        public void op_Multiply(){} // RVA: 0x7FFE87361240 | overloaded x3
        public void op_Division(){} // RVA: 0x7FFE87C5BBC0 | overloaded x2
        public void op_UnaryNegation(){} // RVA: 0x7FFE87C5BB90
        public void op_Equality(){} // RVA: 0x7FFE87C5BBF0
        public void op_Inequality(){} // RVA: 0x7FFE87C5BC40
        public void op_Implicit(){} // RVA: 0x7FFE87C5BC90 | overloaded x2
        public void get_zero(){} // RVA: 0x7FFE87C5BCC0
        public void get_one(){} // RVA: 0x7FFE87C5BD10
        public void get_up(){} // RVA: 0x7FFE87C5BD60
        public void get_down(){} // RVA: 0x7FFE87C5BDB0
        public void get_left(){} // RVA: 0x7FFE87C5BE00
        public void get_right(){} // RVA: 0x7FFE87C5BE50
        public void get_positiveInfinity(){} // RVA: 0x7FFE87C5BEA0
        public void get_negativeInfinity(){} // RVA: 0x7FFE87C5BEF0
        public void .cctor(){} // RVA: 0x7FFE87C5BF40
    }

    public class Vector2Int : ValueType
    {
        public int m_X; // 0x10
        public int m_Y; // 0x14
        public UnityEngine.Vector2Int s_Zero;
        public UnityEngine.Vector2Int s_One; // 0x8
        public UnityEngine.Vector2Int s_Up; // 0x10
        public UnityEngine.Vector2Int s_Down; // 0x18
        public UnityEngine.Vector2Int s_Left; // 0x20
        public UnityEngine.Vector2Int s_Right; // 0x28
        public object field_8; // 0x2F1
        public object field_9; // 0x2F2
        public object field_10; // 0x2F3

        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFE8733C3B0
        public void set_x(){} // RVA: 0x7FFE815BF990
        public void get_y(){} // RVA: 0x7FFE84D2D330
        public void set_y(){} // RVA: 0x7FFE826F4290
        public void .ctor(){} // RVA: 0x7FFE8164E250
        public void Set(){} // RVA: 0x7FFE8164E250
        public void get_Item(){} // RVA: 0x7FFE87C5C030
        public void set_Item(){} // RVA: 0x7FFE87C5C0E0
        public void get_magnitude(){} // RVA: 0x7FFE87C5C190
        public void get_sqrMagnitude(){} // RVA: 0x7FFE87C5C1C0
        public void Distance(){} // RVA: 0x7FFE87C5C1D0
        public void Min(){} // RVA: 0x7FFE87C5C290
        public void Max(){} // RVA: 0x7FFE87C5C2C0
        public void Scale(){} // RVA: 0x7FFE87C5C310 | overloaded x2
        public void Clamp(){} // RVA: 0x7FFE87C5C330
        public void op_Implicit(){} // RVA: 0x7FFE87C5C3C0
        public void op_Explicit(){} // RVA: 0x7FFE87C5C3E0
        public void FloorToInt(){} // RVA: 0x7FFE87C5C410
        public void CeilToInt(){} // RVA: 0x7FFE87C5C450
        public void RoundToInt(){} // RVA: 0x7FFE87C5C490
        public void op_UnaryNegation(){} // RVA: 0x7FFE87C5C4D0
        public void op_Addition(){} // RVA: 0x7FFE87C5C4F0
        public void op_Subtraction(){} // RVA: 0x7FFE87C5C510
        public void op_Multiply(){} // RVA: 0x7FFE87C5C550 | overloaded x3
        public void op_Division(){} // RVA: 0x7FFE87C5C570
        public void op_Equality(){} // RVA: 0x7FFE87C5C5A0
        public void op_Inequality(){} // RVA: 0x7FFE87C5C5C0
        public void Equals(){} // RVA: 0x7FFE87C5C680 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87C5C6A0
        public void ToString(){} // RVA: 0x7FFE87C5C6D0 | overloaded x3
        public void get_zero(){} // RVA: 0x7FFE87C5C980
        public void get_one(){} // RVA: 0x7FFE87C5C9C0
        public void get_up(){} // RVA: 0x7FFE87C5CA00
        public void get_down(){} // RVA: 0x7FFE87C5CA40
        public void get_left(){} // RVA: 0x7FFE87C5CA80
        public void get_right(){} // RVA: 0x7FFE87C5CAC0
        public void .cctor(){} // RVA: 0x7FFE87C5CB00
    }

    public class Vector3 : ValueType
    {
        public float kEpsilon;
        public float kEpsilonNormalSqrt;
        public float x; // 0x10
        public float y; // 0x14
        public float z; // 0x18
        public UnityEngine.Vector3 zeroVector;
        public UnityEngine.Vector3 oneVector; // 0xC
        public UnityEngine.Vector3 upVector; // 0x18
        public UnityEngine.Vector3 downVector; // 0x24
        public UnityEngine.Vector3 leftVector; // 0x30
        public UnityEngine.Vector3 rightVector; // 0x3C
        public UnityEngine.Vector3 forwardVector; // 0x48
        public UnityEngine.Vector3 backVector; // 0x54
        public UnityEngine.Vector3 positiveInfinityVector; // 0x60

        // ── Methods ──
        public void Slerp(){} // RVA: 0x7FFE87C560D0
        public void SlerpUnclamped(){} // RVA: 0x7FFE87C56160
        public void OrthoNormalize2(){} // RVA: 0x7FFE87C561F0
        public void OrthoNormalize(){} // RVA: 0x7FFE87C56250 | overloaded x2
        public void OrthoNormalize3(){} // RVA: 0x7FFE87C56250
        public void RotateTowards(){} // RVA: 0x7FFE87C562C0
        public void Lerp(){} // RVA: 0x7FFE8111F3E0
        public void LerpUnclamped(){} // RVA: 0x7FFE87C56360
        public void MoveTowards(){} // RVA: 0x7FFE87C563B0
        public void SmoothDamp(){} // RVA: 0x7FFE87C56730 | overloaded x3
        public void get_Item(){} // RVA: 0x7FFE82ABA5F0
        public void set_Item(){} // RVA: 0x7FFE81DC5300
        public void .ctor(){} // RVA: 0x7FFE87C56AA0 | overloaded x2
        public void Set(){} // RVA: 0x7FFE8111ED70
        public void Scale(){} // RVA: 0x7FFE87C56AF0 | overloaded x2
        public void Cross(){} // RVA: 0x7FFE81147E60
        public void GetHashCode(){} // RVA: 0x7FFE8410A1D0
        public void Equals(){} // RVA: 0x7FFE86FA2B80 | overloaded x2
        public void Reflect(){} // RVA: 0x7FFE87C56BD0
        public void Normalize(){} // RVA: 0x7FFE81147DC0 | overloaded x2
        public void get_normalized(){} // RVA: 0x7FFE8111F2C0
        public void Dot(){} // RVA: 0x7FFE8111F5A0
        public void Project(){} // RVA: 0x7FFE87C56C50
        public void ProjectOnPlane(){} // RVA: 0x7FFE87C56DA0
        public void Angle(){} // RVA: 0x7FFE87C56EC0
        public void SignedAngle(){} // RVA: 0x7FFE81327390
        public void Distance(){} // RVA: 0x7FFE87C57030
        public void ClampMagnitude(){} // RVA: 0x7FFE87C57100
        public void Magnitude(){} // RVA: 0x7FFE87C57200
        public void get_magnitude(){} // RVA: 0x7FFE87C572B0
        public void SqrMagnitude(){} // RVA: 0x7FFE87C573A0
        public void get_sqrMagnitude(){} // RVA: 0x7FFE87C573A0
        public void Min(){} // RVA: 0x7FFE87C573D0
        public void Max(){} // RVA: 0x7FFE87C57410
        public void get_zero(){} // RVA: 0x7FFE87C57450
        public void get_one(){} // RVA: 0x7FFE87C574A0
        public void get_forward(){} // RVA: 0x7FFE87C574F0
        public void get_back(){} // RVA: 0x7FFE87C57540
        public void get_up(){} // RVA: 0x7FFE87C57590
        public void get_down(){} // RVA: 0x7FFE87C575E0
        public void get_left(){} // RVA: 0x7FFE87C57630
        public void get_right(){} // RVA: 0x7FFE87C57680
        public void get_positiveInfinity(){} // RVA: 0x7FFE87C576D0
        public void get_negativeInfinity(){} // RVA: 0x7FFE87C57720
        public void op_Addition(){} // RVA: 0x7FFE8111ED40
        public void op_Subtraction(){} // RVA: 0x7FFE8111F290
        public void op_UnaryNegation(){} // RVA: 0x7FFE8111EE20
        public void op_Multiply(){} // RVA: 0x7FFE8111F450 | overloaded x2
        public void op_Division(){} // RVA: 0x7FFE8111FAB0
        public void op_Equality(){} // RVA: 0x7FFE87C57770
        public void op_Inequality(){} // RVA: 0x7FFE87C577B0
        public void ToString(){} // RVA: 0x7FFE87C57830 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFE87C57A40
        public void Slerp_Injected(){} // RVA: 0x7FFE87C57BC0
        public void SlerpUnclamped_Injected(){} // RVA: 0x7FFE87C57C40
        public void RotateTowards_Injected(){} // RVA: 0x7FFE87C57CC0
    }

    public class Vector3Int : ValueType
    {
        public int m_X; // 0x10
        public int m_Y; // 0x14
        public int m_Z; // 0x18
        public UnityEngine.Vector3Int s_Zero;
        public UnityEngine.Vector3Int s_One; // 0xC
        public UnityEngine.Vector3Int s_Up; // 0x18
        public UnityEngine.Vector3Int s_Down; // 0x24
        public UnityEngine.Vector3Int s_Left; // 0x30
        public UnityEngine.Vector3Int s_Right; // 0x3C
        public UnityEngine.Vector3Int s_Forward; // 0x48
        public UnityEngine.Vector3Int s_Back; // 0x54
        public object field_11; // 0x2FC
        public object field_12; // 0x2FD
        public object field_13; // 0x2FE

        // ── Methods ──
        public void get_x(){} // RVA: 0x7FFE8733C3B0
        public void set_x(){} // RVA: 0x7FFE815BF990
        public void get_y(){} // RVA: 0x7FFE84D2D330
        public void set_y(){} // RVA: 0x7FFE826F4290
        public void get_z(){} // RVA: 0x7FFE848C3400
        public void set_z(){} // RVA: 0x7FFE82C33010
        public void .ctor(){} // RVA: 0x7FFE855D5D40 | overloaded x2
        public void Set(){} // RVA: 0x7FFE855D5D40
        public void get_Item(){} // RVA: 0x7FFE87C5CC10
        public void set_Item(){} // RVA: 0x7FFE87C5CD10
        public void get_magnitude(){} // RVA: 0x7FFE87C5CE10
        public void get_sqrMagnitude(){} // RVA: 0x7FFE87C5CE50
        public void Distance(){} // RVA: 0x7FFE87C5CE70
        public void Min(){} // RVA: 0x7FFE87C5CEF0
        public void Max(){} // RVA: 0x7FFE87C5CF50
        public void Scale(){} // RVA: 0x7FFE87C5CFF0 | overloaded x2
        public void Clamp(){} // RVA: 0x7FFE87C5D010
        public void op_Implicit(){} // RVA: 0x7FFE87C5D0D0
        public void op_Explicit(){} // RVA: 0x7FFE87C5D100
        public void FloorToInt(){} // RVA: 0x7FFE87C5D120
        public void CeilToInt(){} // RVA: 0x7FFE87C5D180
        public void RoundToInt(){} // RVA: 0x7FFE87C5D1E0
        public void op_Addition(){} // RVA: 0x7FFE87C5D240
        public void op_Subtraction(){} // RVA: 0x7FFE87C5D280
        public void op_Multiply(){} // RVA: 0x7FFE87C5D330 | overloaded x3
        public void op_UnaryNegation(){} // RVA: 0x7FFE87C5D2C0
        public void op_Division(){} // RVA: 0x7FFE87C5D370
        public void op_Equality(){} // RVA: 0x7FFE87C5D3B0
        public void op_Inequality(){} // RVA: 0x7FFE87C5D3D0
        public void Equals(){} // RVA: 0x7FFE87C5D4F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87C5D540
        public void ToString(){} // RVA: 0x7FFE87C5D590 | overloaded x3
        public void get_zero(){} // RVA: 0x7FFE87C5D920
        public void get_one(){} // RVA: 0x7FFE87C5D970
        public void get_up(){} // RVA: 0x7FFE87C5D9C0
        public void get_down(){} // RVA: 0x7FFE87C5DA10
        public void get_left(){} // RVA: 0x7FFE87C5DA60
        public void get_right(){} // RVA: 0x7FFE87C5DAB0
        public void get_forward(){} // RVA: 0x7FFE87C5DB00
        public void get_back(){} // RVA: 0x7FFE87C5DB50
        public void .cctor(){} // RVA: 0x7FFE87C5DBA0
    }

    public class Vector4 : ValueType
    {
        public float kEpsilon;
        public float x; // 0x10
        public float y; // 0x14
        public float z; // 0x18
        public float w; // 0x1C
        public UnityEngine.Vector4 zeroVector;
        public UnityEngine.Vector4 oneVector; // 0x10
        public UnityEngine.Vector4 positiveInfinityVector; // 0x20

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFE8111F9C0
        public void set_Item(){} // RVA: 0x7FFE81855910
        public void .ctor(){} // RVA: 0x7FFE87C5DD20 | overloaded x3
        public void Set(){} // RVA: 0x7FFE8111F570
        public void Lerp(){} // RVA: 0x7FFE81147EC0
        public void LerpUnclamped(){} // RVA: 0x7FFE87C51300
        public void MoveTowards(){} // RVA: 0x7FFE87C5DD30
        public void Scale(){} // RVA: 0x7FFE87C5DEF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE81BDC9F0
        public void Equals(){} // RVA: 0x7FFE87321FF0 | overloaded x2
        public void Normalize(){} // RVA: 0x7FFE87C5E0C0 | overloaded x2
        public void get_normalized(){} // RVA: 0x7FFE827E89E0
        public void Dot(){} // RVA: 0x7FFE87C58760
        public void Project(){} // RVA: 0x7FFE87C5E170
        public void Distance(){} // RVA: 0x7FFE87C5E270
        public void Magnitude(){} // RVA: 0x7FFE87C5E2F0
        public void get_magnitude(){} // RVA: 0x7FFE87C5E3C0
        public void get_sqrMagnitude(){} // RVA: 0x7FFE87C5E490
        public void Min(){} // RVA: 0x7FFE87C5E4E0
        public void Max(){} // RVA: 0x7FFE87C5E540
        public void get_zero(){} // RVA: 0x7FFE87C5E5A0
        public void get_one(){} // RVA: 0x7FFE87C5E5F0
        public void get_positiveInfinity(){} // RVA: 0x7FFE87C5E640
        public void get_negativeInfinity(){} // RVA: 0x7FFE87C5E690
        public void op_Addition(){} // RVA: 0x7FFE87C51040
        public void op_Subtraction(){} // RVA: 0x7FFE87C510A0
        public void op_UnaryNegation(){} // RVA: 0x7FFE87C5E6E0
        public void op_Multiply(){} // RVA: 0x7FFE87C511B0 | overloaded x2
        public void op_Division(){} // RVA: 0x7FFE87C51200
        public void op_Equality(){} // RVA: 0x7FFE87C5E700
        public void op_Inequality(){} // RVA: 0x7FFE87C5E760
        public void op_Implicit(){} // RVA: 0x7FFE87C0EC10 | overloaded x4
        public void ToString(){} // RVA: 0x7FFE87C5E8A0 | overloaded x3
        public void SqrMagnitude(){} // RVA: 0x7FFE87C5E490 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87C5EB00
    }

}