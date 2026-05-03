// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC
// Classes: 25
// Methods: 385

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC
{
    public class AbstractF2mCurve : ECCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger[] si; // 0x50

        // ── Methods ──
        public void Inverse(){} // RVA: 0x7FFE8A417FB0
        public void BuildField(){} // RVA: 0x7FFE8A418050
        public void .ctor(){} // RVA: 0x7FFE8A4182C0
        public void IsValidFieldElement(){} // RVA: 0x7FFE8A418340
        public void CreatePoint(){} // RVA: 0x7FFE8A4183A0
        public void DecompressPoint(){} // RVA: 0x7FFE8A418560
        public void SolveQuadraticEquation(){} // RVA: 0x7FFE8A418800
        public void GetSi(){} // RVA: 0x7FFE8A418C30
        public void get_IsKoblitz(){} // RVA: 0x7FFE8A418E10
    }

    public class AbstractF2mFieldElement : ECFieldElement
    {
        // ── Methods ──
        public void HalfTrace(){} // RVA: 0x7FFE8A41CCD0
        public void get_HasFastTrace(){} // RVA: 0x7FFE810FB320
        public void Trace(){} // RVA: 0x7FFE8A41CED0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class AbstractF2mPoint : ECPointBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x2
        public void SatisfiesCurveEquation(){} // RVA: 0x7FFE8A424C10
        public void SatisfiesOrder(){} // RVA: 0x7FFE8A425180
        public void ScaleX(){} // RVA: 0x7FFE8A425620
        public void ScaleXNegateY(){} // RVA: 0x7FFE8755F0F0
        public void ScaleY(){} // RVA: 0x7FFE8A4259B0
        public void ScaleYNegateX(){} // RVA: 0x7FFE8A425B70
        public void Subtract(){} // RVA: 0x7FFE8A420A50
        public void Tau(){} // RVA: 0x7FFE8A425B90
        public void TauPow(){} // RVA: 0x7FFE8A425ED0
    }

    public class AbstractFpCurve : ECCurve
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A416E20
        public void IsValidFieldElement(){} // RVA: 0x7FFE8A417020
        public void DecompressPoint(){} // RVA: 0x7FFE8A4170C0
    }

    public class AbstractFpFieldElement : ECFieldElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class AbstractFpPoint : ECPointBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x2
        public void get_CompressionYTilde(){} // RVA: 0x7FFE8A420640
        public void SatisfiesCurveEquation(){} // RVA: 0x7FFE8A420680
        public void Subtract(){} // RVA: 0x7FFE8A420A50
    }

    public class ECAlgorithms : Object
    {
        // ── Methods ──
        public void IsF2mCurve(){} // RVA: 0x7FFE8A4106B0
        public void IsF2mField(){} // RVA: 0x7FFE8A4107D0
        public void IsFpCurve(){} // RVA: 0x7FFE8A4108D0
        public void IsFpField(){} // RVA: 0x7FFE8A410940
        public void SumOfMultiplies(){} // RVA: 0x7FFE8A4109A0
        public void SumOfTwoMultiplies(){} // RVA: 0x7FFE8A410DE0
        public void ShamirsTrick(){} // RVA: 0x7FFE8A4112C0
        public void ImportPoint(){} // RVA: 0x7FFE8A411460
        public void MontgomeryTrick(){} // RVA: 0x7FFE8A411550 | overloaded x2
        public void ReferenceMultiply(){} // RVA: 0x7FFE8A411930
        public void ValidatePoint(){} // RVA: 0x7FFE8A411A90
        public void CleanPoint(){} // RVA: 0x7FFE8A411B10
        public void ImplCheckResult(){} // RVA: 0x7FFE8A411C00
        public void ImplShamirsTrickJsf(){} // RVA: 0x7FFE8A411C80
        public void ImplShamirsTrickWNaf(){} // RVA: 0x7FFE8A412A10 | overloaded x3
        public void ImplSumOfMultiplies(){} // RVA: 0x7FFE8A413E30 | overloaded x3
        public void ImplSumOfMultipliesGlv(){} // RVA: 0x7FFE8A4130E0
        public void ImplShamirsTrickFixedPoint(){} // RVA: 0x7FFE8A414190
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ECCurve : Object
    {
        public int COORD_AFFINE;
        public int COORD_HOMOGENEOUS;
        public int COORD_JACOBIAN;
        public int COORD_JACOBIAN_CHUDNOVSKY;
        public int COORD_JACOBIAN_MODIFIED;
        public int COORD_LAMBDA_AFFINE;
        public int COORD_LAMBDA_PROJECTIVE;
        public int COORD_SKEWED;

        // ── Methods ──
        public void GetAllCoordinateSystems(){} // RVA: 0x7FFE8A414650
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_FieldSize(){} // RVA: 0x7FFE80E2EDB0
        public void FromBigInteger(){} // RVA: 0x7FFE80E2E390
        public void IsValidFieldElement(){} // RVA: 0x7FFE80E2F3B0
        public void Configure(){} // RVA: 0x7FFE8A4146C0
        public void ValidatePoint(){} // RVA: 0x7FFE8A4148C0 | overloaded x2
        public void CreatePoint(){} // RVA: 0x7FFE8A414960 | overloaded x2
        public void CloneCurve(){} // RVA: 0x7FFE80E2E2E0
        public void CreateRawPoint(){} // overloaded x2
        public void CreateDefaultMultiplier(){} // RVA: 0x7FFE8A4149F0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE817F4630
        public void GetPreCompInfo(){} // RVA: 0x7FFE8A414BC0
        public void Precompute(){} // RVA: 0x7FFE8A414F40
        public void ImportPoint(){} // RVA: 0x7FFE8A4153E0
        public void NormalizeAll(){} // RVA: 0x7FFE8A415570 | overloaded x2
        public void get_Infinity(){} // RVA: 0x7FFE80E2E2E0
        public void get_Field(){} // RVA: 0x7FFE81116380
        public void get_A(){} // RVA: 0x7FFE810FE7C0
        public void get_B(){} // RVA: 0x7FFE811290C0
        public void get_Order(){} // RVA: 0x7FFE81129130
        public void get_Cofactor(){} // RVA: 0x7FFE8144E200
        public void get_CoordinateSystem(){} // RVA: 0x7FFE81D46090
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE8A415910
        public void CheckPoint(){} // RVA: 0x7FFE8A415BF0
        public void CheckPoints(){} // RVA: 0x7FFE8A415CD0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE8A416070 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8A416110
        public void DecompressPoint(){} // RVA: 0x7FFE80E3E450
        public void GetEndomorphism(){} // RVA: 0x7FFE81178740
        public void GetMultiplier(){} // RVA: 0x7FFE8A416230
        public void DecodePoint(){} // RVA: 0x7FFE8A4163E0
    }

    public class ECFieldElement : Object
    {
        // ── Methods ──
        public void ToBigInteger(){} // RVA: 0x7FFE80E2E2E0
        public void get_FieldName(){} // RVA: 0x7FFE80E2E2E0
        public void get_FieldSize(){} // RVA: 0x7FFE80E2EDB0
        public void Add(){} // RVA: 0x7FFE80E2E390
        public void AddOne(){} // RVA: 0x7FFE80E2E2E0
        public void Subtract(){} // RVA: 0x7FFE80E2E390
        public void Multiply(){} // RVA: 0x7FFE80E2E390
        public void Divide(){} // RVA: 0x7FFE80E2E390
        public void Negate(){} // RVA: 0x7FFE80E2E2E0
        public void Square(){} // RVA: 0x7FFE80E2E2E0
        public void Invert(){} // RVA: 0x7FFE80E2E2E0
        public void Sqrt(){} // RVA: 0x7FFE80E2E2E0
        public void get_BitLength(){} // RVA: 0x7FFE8A41A0C0
        public void get_IsOne(){} // RVA: 0x7FFE8A41A0F0
        public void get_IsZero(){} // RVA: 0x7FFE8A41A120
        public void MultiplyMinusProduct(){} // RVA: 0x7FFE8A41A150
        public void MultiplyPlusProduct(){} // RVA: 0x7FFE8A41A1D0
        public void SquareMinusProduct(){} // RVA: 0x7FFE8A41A250
        public void SquarePlusProduct(){} // RVA: 0x7FFE8A41A2D0
        public void SquarePow(){} // RVA: 0x7FFE8A41A350
        public void TestBitZero(){} // RVA: 0x7FFE8A41A3A0
        public void Equals(){} // RVA: 0x7FFE8A41A480 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE867F4B00
        public void ToString(){} // RVA: 0x7FFE8A41A510
        public void GetEncoded(){} // RVA: 0x7FFE8A41A550
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ECLookupTable
    {
        // ── Methods ──
        public void get_Size(){} // RVA: 0x7FFE80E2EDB0
        public void Lookup(){} // RVA: 0x7FFE80E3D230
    }

    public class ECPoint : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECFieldElement[] EMPTY_ZS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECCurve m_curve; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECFieldElement m_x; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECFieldElement m_y; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECFieldElement[] m_zs; // 0x28
        public bool m_withCompression; // 0x30
        public System.Collections.IDictionary m_preCompTable; // 0x38
        public object field_7; // 0x1FF
        public object field_8; // 0x200
        public object field_9; // 0x201
        public object field_10; // 0x202
        public object field_11; // 0x203

        // ── Methods ──
        public void GetInitialZCoords(){} // RVA: 0x7FFE8A41E5D0
        public void .ctor(){} // RVA: 0x7FFE8A41E9F0 | overloaded x2
        public void SatisfiesCurveEquation(){} // RVA: 0x7FFE80E2F150
        public void SatisfiesOrder(){} // RVA: 0x7FFE8A41EB50
        public void GetDetachedPoint(){} // RVA: 0x7FFE8A41EC90
        public void get_Curve(){} // RVA: 0x7FFE81116380
        public void Detach(){} // RVA: 0x7FFE80E2E2E0
        public void get_CurveCoordinateSystem(){} // RVA: 0x7FFE8A41ECD0
        public void get_AffineXCoord(){} // RVA: 0x7FFE8A41ED00
        public void get_AffineYCoord(){} // RVA: 0x7FFE8A41ED40
        public void get_XCoord(){} // RVA: 0x7FFE810FE7C0
        public void get_YCoord(){} // RVA: 0x7FFE811290C0
        public void GetZCoord(){} // RVA: 0x7FFE8A41ED80
        public void GetZCoords(){} // RVA: 0x7FFE8A41EDC0
        public void get_RawXCoord(){} // RVA: 0x7FFE810FE7C0
        public void get_RawYCoord(){} // RVA: 0x7FFE811290C0
        public void get_RawZCoords(){} // RVA: 0x7FFE81129130
        public void CheckNormalized(){} // RVA: 0x7FFE8A41EE50
        public void IsNormalized(){} // RVA: 0x7FFE8A41EED0
        public void Normalize(){} // RVA: 0x7FFE8A41F020 | overloaded x2
        public void CreateScaledPoint(){} // RVA: 0x7FFE8A41F170
        public void get_IsInfinity(){} // RVA: 0x7FFE8A41F230
        public void get_IsCompressed(){} // RVA: 0x7FFE81121450
        public void IsValid(){} // RVA: 0x7FFE8A41F250
        public void IsValidPartial(){} // RVA: 0x7FFE8A41F260
        public void ImplIsValid(){} // RVA: 0x7FFE8A41F270
        public void ScaleX(){} // RVA: 0x7FFE8A41F410
        public void ScaleXNegateY(){} // RVA: 0x7FFE8A41F4D0
        public void ScaleY(){} // RVA: 0x7FFE8A41F5A0
        public void ScaleYNegateX(){} // RVA: 0x7FFE8A41F660
        public void Equals(){} // RVA: 0x7FFE8A41F7E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8A41FB10
        public void ToString(){} // RVA: 0x7FFE8A41FC20
        public void GetEncoded(){} // RVA: 0x7FFE8A41FE60 | overloaded x2
        public void get_CompressionYTilde(){} // RVA: 0x7FFE80E2F150
        public void Add(){} // RVA: 0x7FFE80E2E390
        public void Subtract(){} // RVA: 0x7FFE80E2E390
        public void Negate(){} // RVA: 0x7FFE80E2E2E0
        public void TimesPow2(){} // RVA: 0x7FFE8A41FE80
        public void Twice(){} // RVA: 0x7FFE80E2E2E0
        public void Multiply(){} // RVA: 0x7FFE80E2E390
        public void TwicePlus(){} // RVA: 0x7FFE8A41FF30
        public void ThreeTimes(){} // RVA: 0x7FFE8A41FF80
        public void .cctor(){} // RVA: 0x7FFE8A41FFA0
    }

    public class ECPointBase : ECPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A4202D0 | overloaded x2
        public void GetEncoded(){} // RVA: 0x7FFE8A420360
        public void Multiply(){} // RVA: 0x7FFE8A420590
    }

    public class ECPointMap
    {
        // ── Methods ──
        public void Map(){} // RVA: 0x7FFE80E2E390
    }

    public class F2mCurve : AbstractF2mCurve
    {
        public int F2M_DEFAULT_COORDS;
        public int m; // 0x58
        public int k1; // 0x5C
        public int k2; // 0x60
        public int k3; // 0x64
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.F2mPoint m_infinity; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A419380 | overloaded x5
        public void CloneCurve(){} // RVA: 0x7FFE8A419600
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE8A4196D0
        public void CreateDefaultMultiplier(){} // RVA: 0x7FFE8A4196E0
        public void get_FieldSize(){} // RVA: 0x7FFE8175AC90
        public void FromBigInteger(){} // RVA: 0x7FFE8A419750
        public void CreateRawPoint(){} // RVA: 0x7FFE8A419920 | overloaded x2
        public void get_Infinity(){} // RVA: 0x7FFE81176D50
        public void get_M(){} // RVA: 0x7FFE8175AC90
        public void IsTrinomial(){} // RVA: 0x7FFE8A4199C0
        public void get_K1(){} // RVA: 0x7FFE813A7A20
        public void get_K2(){} // RVA: 0x7FFE8139EA30
        public void get_K3(){} // RVA: 0x7FFE8139DA60
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE8A4199E0
    }

    public class F2mFieldElement : AbstractF2mFieldElement
    {
        public int Gnb;
        public int Tpb;
        public int Ppb;
        public int representation; // 0x10
        public int m; // 0x14
        public int[] ks; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.LongArray x; // 0x20
        public object field_7; // 0x1F4
        public object field_8; // 0x1F5
        public object field_9; // 0x1F6

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A41D320 | overloaded x3
        public void get_BitLength(){} // RVA: 0x7FFE8A41D400
        public void get_IsOne(){} // RVA: 0x7FFE8A41D420
        public void get_IsZero(){} // RVA: 0x7FFE8A41D490
        public void TestBitZero(){} // RVA: 0x7FFE8A41D4F0
        public void ToBigInteger(){} // RVA: 0x7FFE8A41D540
        public void get_FieldName(){} // RVA: 0x7FFE8A41D560
        public void get_FieldSize(){} // RVA: 0x7FFE8164B230
        public void CheckFieldElements(){} // RVA: 0x7FFE8A41D5A0
        public void Add(){} // RVA: 0x7FFE8A41D7F0
        public void AddOne(){} // RVA: 0x7FFE8A41D8F0
        public void Subtract(){} // RVA: 0x7FFE85B3A4A0
        public void Multiply(){} // RVA: 0x7FFE8A41D990
        public void MultiplyMinusProduct(){} // RVA: 0x7FFE89F18970
        public void MultiplyPlusProduct(){} // RVA: 0x7FFE8A41DA80
        public void Divide(){} // RVA: 0x7FFE89F18BC0
        public void Negate(){} // RVA: 0x7FFE827C4A80
        public void Square(){} // RVA: 0x7FFE8A41DC90
        public void SquareMinusProduct(){} // RVA: 0x7FFE89F18CF0
        public void SquarePlusProduct(){} // RVA: 0x7FFE8A41DD30
        public void SquarePow(){} // RVA: 0x7FFE8A41E030
        public void Invert(){} // RVA: 0x7FFE8A41E0F0
        public void Sqrt(){} // RVA: 0x7FFE8A41E190
        public void get_Representation(){} // RVA: 0x7FFE811485C0
        public void get_M(){} // RVA: 0x7FFE8164B230
        public void get_K1(){} // RVA: 0x7FFE8A41E250
        public void get_K2(){} // RVA: 0x7FFE8A41E280
        public void get_K3(){} // RVA: 0x7FFE8A41E2C0
        public void Equals(){} // RVA: 0x7FFE8A41E3C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8A41E510
    }

    public class F2mPoint : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE8A4263E0
        public void get_YCoord(){} // RVA: 0x7FFE8A426500
        public void get_CompressionYTilde(){} // RVA: 0x7FFE8A426650
        public void Add(){} // RVA: 0x7FFE8A426760
        public void Twice(){} // RVA: 0x7FFE8A4278E0
        public void TwicePlus(){} // RVA: 0x7FFE8A4285C0
        public void Negate(){} // RVA: 0x7FFE8A428D10
    }

    public class FpCurve : AbstractFpCurve
    {
        public int FP_DEFAULT_COORDS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_q; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_r; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A417630 | overloaded x4
        public void CloneCurve(){} // RVA: 0x7FFE8A417920
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE8A4179E0
        public void get_Q(){} // RVA: 0x7FFE8119C0E0
        public void get_Infinity(){} // RVA: 0x7FFE81199370
        public void get_FieldSize(){} // RVA: 0x7FFE8A4179F0
        public void FromBigInteger(){} // RVA: 0x7FFE8A417A10
        public void CreateRawPoint(){} // RVA: 0x7FFE8A417B90 | overloaded x2
        public void ImportPoint(){} // RVA: 0x7FFE8A417C30
    }

    public class FpFieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger r; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger x; // 0x20

        // ── Methods ──
        public void CalculateResidue(){} // RVA: 0x7FFE8A41A5B0
        public void .ctor(){} // RVA: 0x7FFE8A41A760 | overloaded x2
        public void ToBigInteger(){} // RVA: 0x7FFE811290C0
        public void get_FieldName(){} // RVA: 0x7FFE8A41A840
        public void get_FieldSize(){} // RVA: 0x7FFE8A41A880
        public void get_Q(){} // RVA: 0x7FFE81116380
        public void Add(){} // RVA: 0x7FFE8A41A8A0
        public void AddOne(){} // RVA: 0x7FFE8A41A980
        public void Subtract(){} // RVA: 0x7FFE8A41AAB0
        public void Multiply(){} // RVA: 0x7FFE8A41AB90
        public void MultiplyMinusProduct(){} // RVA: 0x7FFE8A41AC70
        public void MultiplyPlusProduct(){} // RVA: 0x7FFE8A41ADE0
        public void Divide(){} // RVA: 0x7FFE8A41AFD0
        public void Negate(){} // RVA: 0x7FFE8A41B0D0
        public void Square(){} // RVA: 0x7FFE8A41B190
        public void SquareMinusProduct(){} // RVA: 0x7FFE8A41B240
        public void SquarePlusProduct(){} // RVA: 0x7FFE8A41B390
        public void Invert(){} // RVA: 0x7FFE8A41B550
        public void Sqrt(){} // RVA: 0x7FFE8A41B5F0
        public void CheckSqrt(){} // RVA: 0x7FFE8A41BD20
        public void LucasSequence(){} // RVA: 0x7FFE8A41BD90
        public void ModAdd(){} // RVA: 0x7FFE8A41C390
        public void ModDouble(){} // RVA: 0x7FFE8A41C400
        public void ModHalf(){} // RVA: 0x7FFE8A41C470
        public void ModHalfAbs(){} // RVA: 0x7FFE8A41C4E0
        public void ModInverse(){} // RVA: 0x7FFE8A41C550
        public void ModMult(){} // RVA: 0x7FFE8A41C650
        public void ModReduce(){} // RVA: 0x7FFE8A41C6A0
        public void ModSubtract(){} // RVA: 0x7FFE8A41CA80
        public void Equals(){} // RVA: 0x7FFE8A41CB90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8A41CC50
    }

    public class FpPoint : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE8A420C00
        public void GetZCoord(){} // RVA: 0x7FFE8A420D10
        public void Add(){} // RVA: 0x7FFE8A420DA0
        public void Twice(){} // RVA: 0x7FFE8A421DC0
        public void TwicePlus(){} // RVA: 0x7FFE8A422BC0
        public void ThreeTimes(){} // RVA: 0x7FFE8A423230
        public void TimesPow2(){} // RVA: 0x7FFE8A4237D0
        public void Two(){} // RVA: 0x7FFE8A424210
        public void Three(){} // RVA: 0x7FFE8A424240
        public void Four(){} // RVA: 0x7FFE8A424290
        public void Eight(){} // RVA: 0x7FFE8A4242D0
        public void DoubleProductFromSquares(){} // RVA: 0x7FFE8A424310
        public void Negate(){} // RVA: 0x7FFE8A4243B0
        public void CalculateJacobianModifiedW(){} // RVA: 0x7FFE8A4245A0
        public void GetJacobianModifiedW(){} // RVA: 0x7FFE8A424740
        public void TwiceJacobianModified(){} // RVA: 0x7FFE8A4247E0
    }

    public class LongArray : Object
    {
        public ushort[] INTERLEAVE2_TABLE;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A429390 | overloaded x4
        public void CopyTo(){} // RVA: 0x7FFE8A4295D0
        public void IsOne(){} // RVA: 0x7FFE8A429610
        public void IsZero(){} // RVA: 0x7FFE8A429670
        public void GetUsedLength(){} // RVA: 0x7FFE8A4296C0
        public void GetUsedLengthFrom(){} // RVA: 0x7FFE8A4297A0
        public void Degree(){} // RVA: 0x7FFE8A429880
        public void DegreeFrom(){} // RVA: 0x7FFE8A429930
        public void BitLength(){} // RVA: 0x7FFE8A4299F0
        public void ResizedInts(){} // RVA: 0x7FFE8A429BA0
        public void ToBigInteger(){} // RVA: 0x7FFE8A429C60
        public void ShiftUp(){} // RVA: 0x7FFE8A429F60 | overloaded x2
        public void AddOne(){} // RVA: 0x7FFE8A42A030
        public void AddShiftedByBitsSafe(){} // RVA: 0x7FFE8A42A220
        public void AddShiftedUp(){} // RVA: 0x7FFE8A42A3D0
        public void AddShiftedDown(){} // RVA: 0x7FFE8A42A490
        public void AddShiftedByWords(){} // RVA: 0x7FFE8A42A550
        public void Add(){} // RVA: 0x7FFE8A42A710 | overloaded x2
        public void AddBoth(){} // RVA: 0x7FFE8A42A7C0
        public void Distribute(){} // RVA: 0x7FFE8A42A870
        public void get_Length(){} // RVA: 0x7FFE81CCB610
        public void FlipWord(){} // RVA: 0x7FFE8A42A910
        public void TestBitZero(){} // RVA: 0x7FFE8A42A9A0
        public void TestBit(){} // RVA: 0x7FFE8A42A9E0
        public void FlipBit(){} // RVA: 0x7FFE8A42AA30
        public void MultiplyWord(){} // RVA: 0x7FFE8A42AA70
        public void ModMultiplyLD(){} // RVA: 0x7FFE8A42AC10
        public void ModMultiply(){} // RVA: 0x7FFE8A42B4D0
        public void ModMultiplyAlt(){} // RVA: 0x7FFE8A42BC60
        public void ModReduce(){} // RVA: 0x7FFE8A42C430
        public void Multiply(){} // RVA: 0x7FFE8A42C590
        public void Reduce(){} // RVA: 0x7FFE8A42CCD0
        public void ReduceResult(){} // RVA: 0x7FFE8A42CE00
        public void ReduceInPlace(){} // RVA: 0x7FFE8A42CEC0
        public void ReduceBitWise(){} // RVA: 0x7FFE8A42D2D0
        public void ReduceBit(){} // RVA: 0x7FFE8A42D3D0
        public void ReduceWordWise(){} // RVA: 0x7FFE8A42D530
        public void ReduceWord(){} // RVA: 0x7FFE8A42D6C0
        public void ReduceVectorWise(){} // RVA: 0x7FFE8A42D870
        public void FlipVector(){} // RVA: 0x7FFE8A42DBE0
        public void ModSquare(){} // RVA: 0x7FFE8A42DD80
        public void ModSquareN(){} // RVA: 0x7FFE8A42DF60
        public void Square(){} // RVA: 0x7FFE8A42E180
        public void SquareInPlace(){} // RVA: 0x7FFE8A42E310
        public void Interleave(){} // RVA: 0x7FFE8A42E3E0
        public void Interleave3(){} // RVA: 0x7FFE8A42EA90 | overloaded x2
        public void Interleave3_21to63(){} // RVA: 0x7FFE8A42EB50
        public void Interleave5(){} // RVA: 0x7FFE8A42EDE0 | overloaded x2
        public void Interleave3_13to65(){} // RVA: 0x7FFE8A42EED0
        public void Interleave7(){} // RVA: 0x7FFE8A42F050 | overloaded x2
        public void Interleave2_n(){} // RVA: 0x7FFE8A42F2C0 | overloaded x2
        public void Interleave4_16to64(){} // RVA: 0x7FFE8A42F5B0
        public void Interleave2_32to64(){} // RVA: 0x7FFE8A42F640
        public void ModInverse(){} // RVA: 0x7FFE8A42F720
        public void Equals(){} // RVA: 0x7FFE8A42FD10 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8A42FDC0
        public void Copy(){} // RVA: 0x7FFE8A42FE30
        public void ToString(){} // RVA: 0x7FFE8A42FF60
        public void .cctor(){} // RVA: 0x7FFE8A4301A0
    }

    public class ScaleXNegateYPointMap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Map(){} // RVA: 0x7FFE8A4305F0
    }

    public class ScaleXPointMap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Map(){} // RVA: 0x7FFE8A430630
    }

    public class ScaleYNegateXPointMap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Map(){} // RVA: 0x7FFE8A430670
    }

    public class ScaleYPointMap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Map(){} // RVA: 0x7FFE8A4306B0
    }

    public class SimpleLookupTable : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint[] points; // 0x10

        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFE8A4306F0
        public void .ctor(){} // RVA: 0x7FFE8A430850
        public void get_Size(){} // RVA: 0x7FFE81CCB610
        public void Lookup(){} // RVA: 0x7FFE876177D0
    }

}