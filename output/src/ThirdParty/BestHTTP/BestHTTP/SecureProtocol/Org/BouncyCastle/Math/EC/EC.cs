// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC
// Classes: 25
// Methods: 385

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC
{
    public class AbstractF2mCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger[] si; // 0x50

        // ── Methods ──
        public void Inverse(){} // RVA: 0x99BC580
        public void BuildField(){} // RVA: 0x99BC620
        public void .ctor(){} // RVA: 0x99BC890
        public void IsValidFieldElement(){} // RVA: 0x99BC910
        public void CreatePoint(){} // RVA: 0x99BC970
        public void DecompressPoint(){} // RVA: 0x99BCB30
        public void SolveQuadraticEquation(){} // RVA: 0x99BCDD0
        public void GetSi(){} // RVA: 0x99BD200
        public void get_IsKoblitz(){} // RVA: 0x99BD3E0
    }

    public class AbstractF2mFieldElement
    {
        // ── Methods ──
        public void HalfTrace(){} // RVA: 0x99C12A0
        public void get_HasFastTrace(){} // RVA: 0x2DD320
        public void Trace(){} // RVA: 0x99C14A0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x2
        public void SatisfiesCurveEquation(){} // RVA: 0x99C91E0
        public void SatisfiesOrder(){} // RVA: 0x99C9750
        public void ScaleX(){} // RVA: 0x99C9BF0
        public void ScaleXNegateY(){} // RVA: 0x6A1FDE0
        public void ScaleY(){} // RVA: 0x99C9F80
        public void ScaleYNegateX(){} // RVA: 0x99CA140
        public void Subtract(){} // RVA: 0x99C5020
        public void Tau(){} // RVA: 0x99CA160
        public void TauPow(){} // RVA: 0x99CA4A0
    }

    public class AbstractFpCurve
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99BB3F0
        public void IsValidFieldElement(){} // RVA: 0x99BB5F0
        public void DecompressPoint(){} // RVA: 0x99BB690
    }

    public class AbstractFpFieldElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x2
        public void get_CompressionYTilde(){} // RVA: 0x99C4C10
        public void SatisfiesCurveEquation(){} // RVA: 0x99C4C50
        public void Subtract(){} // RVA: 0x99C5020
    }

    public class ECAlgorithms
    {
        // ── Methods ──
        public void IsF2mCurve(){} // RVA: 0x99B4C80
        public void IsF2mField(){} // RVA: 0x99B4DA0
        public void IsFpCurve(){} // RVA: 0x99B4EA0
        public void IsFpField(){} // RVA: 0x99B4F10
        public void SumOfMultiplies(){} // RVA: 0x99B4F70
        public void SumOfTwoMultiplies(){} // RVA: 0x99B53B0
        public void ShamirsTrick(){} // RVA: 0x99B5890
        public void ImportPoint(){} // RVA: 0x99B5A30
        public void MontgomeryTrick(){} // RVA: 0x99B5B20 | overloaded x2
        public void ReferenceMultiply(){} // RVA: 0x99B5F00
        public void ValidatePoint(){} // RVA: 0x99B6060
        public void CleanPoint(){} // RVA: 0x99B60E0
        public void ImplCheckResult(){} // RVA: 0x99B61D0
        public void ImplShamirsTrickJsf(){} // RVA: 0x99B6250
        public void ImplShamirsTrickWNaf(){} // RVA: 0x99B6FE0 | overloaded x3
        public void ImplSumOfMultiplies(){} // RVA: 0x99B8400 | overloaded x3
        public void ImplSumOfMultipliesGlv(){} // RVA: 0x99B76B0
        public void ImplShamirsTrickFixedPoint(){} // RVA: 0x99B8760
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ECCurve
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
        public void GetAllCoordinateSystems(){} // RVA: 0x99B8C20
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_FieldSize(){} // RVA: 0xD840
        public void FromBigInteger(){} // RVA: 0xCE10
        public void IsValidFieldElement(){} // RVA: 0xDE40
        public void Configure(){} // RVA: 0x99B8C90
        public void ValidatePoint(){} // RVA: 0x99B8E90 | overloaded x2
        public void CreatePoint(){} // RVA: 0x99B8F30 | overloaded x2
        public void CloneCurve(){} // RVA: 0xCD60
        public void CreateRawPoint(){} // overloaded x2
        public void CreateDefaultMultiplier(){} // RVA: 0x99B8FC0
        public void SupportsCoordinateSystem(){} // RVA: 0x15678D0
        public void GetPreCompInfo(){} // RVA: 0x99B9190
        public void Precompute(){} // RVA: 0x99B9510
        public void ImportPoint(){} // RVA: 0x99B99B0
        public void NormalizeAll(){} // RVA: 0x99B9B40 | overloaded x2
        public void get_Infinity(){} // RVA: 0xCD60
        public void get_Field(){} // RVA: 0x2F8380
        public void get_A(){} // RVA: 0x2E07C0
        public void get_B(){} // RVA: 0x30B0C0
        public void get_Order(){} // RVA: 0x30B130
        public void get_Cofactor(){} // RVA: 0x6374D0
        public void get_CoordinateSystem(){} // RVA: 0xFDC9F0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x99B9EE0
        public void CheckPoint(){} // RVA: 0x99BA1C0
        public void CheckPoints(){} // RVA: 0x99BA2A0 | overloaded x2
        public void Equals(){} // RVA: 0x99BA640 | overloaded x2
        public void GetHashCode(){} // RVA: 0x99BA6E0
        public void DecompressPoint(){} // RVA: 0x1CEE0
        public void GetEndomorphism(){} // RVA: 0x35A740
        public void GetMultiplier(){} // RVA: 0x99BA800
        public void DecodePoint(){} // RVA: 0x99BA9B0
    }

    public class ECFieldElement
    {
        // ── Methods ──
        public void ToBigInteger(){} // RVA: 0xCD60
        public void get_FieldName(){} // RVA: 0xCD60
        public void get_FieldSize(){} // RVA: 0xD840
        public void Add(){} // RVA: 0xCE10
        public void AddOne(){} // RVA: 0xCD60
        public void Subtract(){} // RVA: 0xCE10
        public void Multiply(){} // RVA: 0xCE10
        public void Divide(){} // RVA: 0xCE10
        public void Negate(){} // RVA: 0xCD60
        public void Square(){} // RVA: 0xCD60
        public void Invert(){} // RVA: 0xCD60
        public void Sqrt(){} // RVA: 0xCD60
        public void get_BitLength(){} // RVA: 0x99BE690
        public void get_IsOne(){} // RVA: 0x99BE6C0
        public void get_IsZero(){} // RVA: 0x99BE6F0
        public void MultiplyMinusProduct(){} // RVA: 0x99BE720
        public void MultiplyPlusProduct(){} // RVA: 0x99BE7A0
        public void SquareMinusProduct(){} // RVA: 0x99BE820
        public void SquarePlusProduct(){} // RVA: 0x99BE8A0
        public void SquarePow(){} // RVA: 0x99BE920
        public void TestBitZero(){} // RVA: 0x99BE970
        public void Equals(){} // RVA: 0x99BEA50 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5CB3C00
        public void ToString(){} // RVA: 0x99BEAE0
        public void GetEncoded(){} // RVA: 0x99BEB20
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ECLookupTable
    {
        // ── Methods ──
        public void get_Size(){} // RVA: 0xD840
        public void Lookup(){} // RVA: 0x1BCC0
    }

    public class ECPoint
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECFieldElement[] EMPTY_ZS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECCurve m_curve; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECFieldElement m_x; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECFieldElement m_y; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECFieldElement[] m_zs; // 0x28
        public bool m_withCompression; // 0x30
        public System.Collections.IDictionary m_preCompTable; // 0x38

        // ── Methods ──
        public void GetInitialZCoords(){} // RVA: 0x99C2BA0
        public void .ctor(){} // RVA: 0x99C2FC0 | overloaded x2
        public void SatisfiesCurveEquation(){} // RVA: 0xDBE0
        public void SatisfiesOrder(){} // RVA: 0x99C3120
        public void GetDetachedPoint(){} // RVA: 0x99C3260
        public void get_Curve(){} // RVA: 0x2F8380
        public void Detach(){} // RVA: 0xCD60
        public void get_CurveCoordinateSystem(){} // RVA: 0x99C32A0
        public void get_AffineXCoord(){} // RVA: 0x99C32D0
        public void get_AffineYCoord(){} // RVA: 0x99C3310
        public void get_XCoord(){} // RVA: 0x2E07C0
        public void get_YCoord(){} // RVA: 0x30B0C0
        public void GetZCoord(){} // RVA: 0x99C3350
        public void GetZCoords(){} // RVA: 0x99C3390
        public void get_RawXCoord(){} // RVA: 0x2E07C0
        public void get_RawYCoord(){} // RVA: 0x30B0C0
        public void get_RawZCoords(){} // RVA: 0x30B130
        public void CheckNormalized(){} // RVA: 0x99C3420
        public void IsNormalized(){} // RVA: 0x99C34A0
        public void Normalize(){} // RVA: 0x99C35F0 | overloaded x2
        public void CreateScaledPoint(){} // RVA: 0x99C3740
        public void get_IsInfinity(){} // RVA: 0x99C3800
        public void get_IsCompressed(){} // RVA: 0x303450
        public void IsValid(){} // RVA: 0x99C3820
        public void IsValidPartial(){} // RVA: 0x99C3830
        public void ImplIsValid(){} // RVA: 0x99C3840
        public void ScaleX(){} // RVA: 0x99C39E0
        public void ScaleXNegateY(){} // RVA: 0x99C3AA0
        public void ScaleY(){} // RVA: 0x99C3B70
        public void ScaleYNegateX(){} // RVA: 0x99C3C30
        public void Equals(){} // RVA: 0x99C3DB0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x99C40E0
        public void ToString(){} // RVA: 0x99C41F0
        public void GetEncoded(){} // RVA: 0x99C4430 | overloaded x2
        public void get_CompressionYTilde(){} // RVA: 0xDBE0
        public void Add(){} // RVA: 0xCE10
        public void Subtract(){} // RVA: 0xCE10
        public void Negate(){} // RVA: 0xCD60
        public void TimesPow2(){} // RVA: 0x99C4450
        public void Twice(){} // RVA: 0xCD60
        public void Multiply(){} // RVA: 0xCE10
        public void TwicePlus(){} // RVA: 0x99C4500
        public void ThreeTimes(){} // RVA: 0x99C4550
        public void .cctor(){} // RVA: 0x99C4570
    }

    public class ECPointBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99C48A0 | overloaded x2
        public void GetEncoded(){} // RVA: 0x99C4930
        public void Multiply(){} // RVA: 0x99C4B60
    }

    public class ECPointMap
    {
        // ── Methods ──
        public void Map(){} // RVA: 0xCE10
    }

    public class F2mCurve
    {
        public int F2M_DEFAULT_COORDS;
        public int m; // 0x58
        public int k1; // 0x5C
        public int k2; // 0x60
        public int k3; // 0x64
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.F2mPoint m_infinity; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x99BD950 | overloaded x5
        public void CloneCurve(){} // RVA: 0x99BDBD0
        public void SupportsCoordinateSystem(){} // RVA: 0x99BDCA0
        public void CreateDefaultMultiplier(){} // RVA: 0x99BDCB0
        public void get_FieldSize(){} // RVA: 0x9EAB90
        public void FromBigInteger(){} // RVA: 0x99BDD20
        public void CreateRawPoint(){} // RVA: 0x99BDEF0 | overloaded x2
        public void get_Infinity(){} // RVA: 0x358D50
        public void get_M(){} // RVA: 0x9EAB90
        public void IsTrinomial(){} // RVA: 0x99BDF90
        public void get_K1(){} // RVA: 0x5A54D0
        public void get_K2(){} // RVA: 0x59CEC0
        public void get_K3(){} // RVA: 0x59C4F0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x99BDFB0
    }

    public class F2mFieldElement
    {
        public int Gnb;
        public int Tpb;
        public int Ppb;
        public int representation; // 0x10
        public int m; // 0x14
        public int[] ks; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.LongArray x; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x99C18F0 | overloaded x3
        public void get_BitLength(){} // RVA: 0x99C19D0
        public void get_IsOne(){} // RVA: 0x99C19F0
        public void get_IsZero(){} // RVA: 0x99C1A60
        public void TestBitZero(){} // RVA: 0x99C1AC0
        public void ToBigInteger(){} // RVA: 0x99C1B10
        public void get_FieldName(){} // RVA: 0x99C1B30
        public void get_FieldSize(){} // RVA: 0x8ABED0
        public void CheckFieldElements(){} // RVA: 0x99C1B70
        public void Add(){} // RVA: 0x99C1DC0
        public void AddOne(){} // RVA: 0x99C1EC0
        public void Subtract(){} // RVA: 0x4EE62A0
        public void Multiply(){} // RVA: 0x99C1F60
        public void MultiplyMinusProduct(){} // RVA: 0x94B65A0
        public void MultiplyPlusProduct(){} // RVA: 0x99C2050
        public void Divide(){} // RVA: 0x94B67F0
        public void Negate(){} // RVA: 0x1A3F520
        public void Square(){} // RVA: 0x99C2260
        public void SquareMinusProduct(){} // RVA: 0x94B6920
        public void SquarePlusProduct(){} // RVA: 0x99C2300
        public void SquarePow(){} // RVA: 0x99C2600
        public void Invert(){} // RVA: 0x99C26C0
        public void Sqrt(){} // RVA: 0x99C2760
        public void get_Representation(){} // RVA: 0x32A5C0
        public void get_M(){} // RVA: 0x8ABED0
        public void get_K1(){} // RVA: 0x99C2820
        public void get_K2(){} // RVA: 0x99C2850
        public void get_K3(){} // RVA: 0x99C2890
        public void Equals(){} // RVA: 0x99C2990 | overloaded x2
        public void GetHashCode(){} // RVA: 0x99C2AE0
    }

    public class F2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x99CA9B0
        public void get_YCoord(){} // RVA: 0x99CAAD0
        public void get_CompressionYTilde(){} // RVA: 0x99CAC20
        public void Add(){} // RVA: 0x99CAD30
        public void Twice(){} // RVA: 0x99CBEB0
        public void TwicePlus(){} // RVA: 0x99CCB90
        public void Negate(){} // RVA: 0x99CD2E0
    }

    public class FpCurve
    {
        public int FP_DEFAULT_COORDS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_q; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_r; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x99BBC00 | overloaded x4
        public void CloneCurve(){} // RVA: 0x99BBEF0
        public void SupportsCoordinateSystem(){} // RVA: 0x99BBFB0
        public void get_Q(){} // RVA: 0x37E0E0
        public void get_Infinity(){} // RVA: 0x37B370
        public void get_FieldSize(){} // RVA: 0x99BBFC0
        public void FromBigInteger(){} // RVA: 0x99BBFE0
        public void CreateRawPoint(){} // RVA: 0x99BC160 | overloaded x2
        public void ImportPoint(){} // RVA: 0x99BC200
    }

    public class FpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger r; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger x; // 0x20

        // ── Methods ──
        public void CalculateResidue(){} // RVA: 0x99BEB80
        public void .ctor(){} // RVA: 0x99BED30 | overloaded x2
        public void ToBigInteger(){} // RVA: 0x30B0C0
        public void get_FieldName(){} // RVA: 0x99BEE10
        public void get_FieldSize(){} // RVA: 0x99BEE50
        public void get_Q(){} // RVA: 0x2F8380
        public void Add(){} // RVA: 0x99BEE70
        public void AddOne(){} // RVA: 0x99BEF50
        public void Subtract(){} // RVA: 0x99BF080
        public void Multiply(){} // RVA: 0x99BF160
        public void MultiplyMinusProduct(){} // RVA: 0x99BF240
        public void MultiplyPlusProduct(){} // RVA: 0x99BF3B0
        public void Divide(){} // RVA: 0x99BF5A0
        public void Negate(){} // RVA: 0x99BF6A0
        public void Square(){} // RVA: 0x99BF760
        public void SquareMinusProduct(){} // RVA: 0x99BF810
        public void SquarePlusProduct(){} // RVA: 0x99BF960
        public void Invert(){} // RVA: 0x99BFB20
        public void Sqrt(){} // RVA: 0x99BFBC0
        public void CheckSqrt(){} // RVA: 0x99C02F0
        public void LucasSequence(){} // RVA: 0x99C0360
        public void ModAdd(){} // RVA: 0x99C0960
        public void ModDouble(){} // RVA: 0x99C09D0
        public void ModHalf(){} // RVA: 0x99C0A40
        public void ModHalfAbs(){} // RVA: 0x99C0AB0
        public void ModInverse(){} // RVA: 0x99C0B20
        public void ModMult(){} // RVA: 0x99C0C20
        public void ModReduce(){} // RVA: 0x99C0C70
        public void ModSubtract(){} // RVA: 0x99C1050
        public void Equals(){} // RVA: 0x99C1160 | overloaded x2
        public void GetHashCode(){} // RVA: 0x99C1220
    }

    public class FpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x99C51D0
        public void GetZCoord(){} // RVA: 0x99C52E0
        public void Add(){} // RVA: 0x99C5370
        public void Twice(){} // RVA: 0x99C6390
        public void TwicePlus(){} // RVA: 0x99C7190
        public void ThreeTimes(){} // RVA: 0x99C7800
        public void TimesPow2(){} // RVA: 0x99C7DA0
        public void Two(){} // RVA: 0x99C87E0
        public void Three(){} // RVA: 0x99C8810
        public void Four(){} // RVA: 0x99C8860
        public void Eight(){} // RVA: 0x99C88A0
        public void DoubleProductFromSquares(){} // RVA: 0x99C88E0
        public void Negate(){} // RVA: 0x99C8980
        public void CalculateJacobianModifiedW(){} // RVA: 0x99C8B70
        public void GetJacobianModifiedW(){} // RVA: 0x99C8D10
        public void TwiceJacobianModified(){} // RVA: 0x99C8DB0
    }

    public class LongArray
    {
        public ushort[] INTERLEAVE2_TABLE;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x99CD960 | overloaded x4
        public void CopyTo(){} // RVA: 0x99CDBA0
        public void IsOne(){} // RVA: 0x99CDBE0
        public void IsZero(){} // RVA: 0x99CDC40
        public void GetUsedLength(){} // RVA: 0x99CDC90
        public void GetUsedLengthFrom(){} // RVA: 0x99CDD70
        public void Degree(){} // RVA: 0x99CDE50
        public void DegreeFrom(){} // RVA: 0x99CDF00
        public void BitLength(){} // RVA: 0x99CDFC0
        public void ResizedInts(){} // RVA: 0x99CE170
        public void ToBigInteger(){} // RVA: 0x99CE230
        public void ShiftUp(){} // RVA: 0x99CE530 | overloaded x2
        public void AddOne(){} // RVA: 0x99CE600
        public void AddShiftedByBitsSafe(){} // RVA: 0x99CE7F0
        public void AddShiftedUp(){} // RVA: 0x99CE9A0
        public void AddShiftedDown(){} // RVA: 0x99CEA60
        public void AddShiftedByWords(){} // RVA: 0x99CEB20
        public void Add(){} // RVA: 0x99CECE0 | overloaded x2
        public void AddBoth(){} // RVA: 0x99CED90
        public void Distribute(){} // RVA: 0x99CEE40
        public void get_Length(){} // RVA: 0xF3F910
        public void FlipWord(){} // RVA: 0x99CEEE0
        public void TestBitZero(){} // RVA: 0x99CEF70
        public void TestBit(){} // RVA: 0x99CEFB0
        public void FlipBit(){} // RVA: 0x99CF000
        public void MultiplyWord(){} // RVA: 0x99CF040
        public void ModMultiplyLD(){} // RVA: 0x99CF1E0
        public void ModMultiply(){} // RVA: 0x99CFAA0
        public void ModMultiplyAlt(){} // RVA: 0x99D0230
        public void ModReduce(){} // RVA: 0x99D0A00
        public void Multiply(){} // RVA: 0x99D0B60
        public void Reduce(){} // RVA: 0x99D12A0
        public void ReduceResult(){} // RVA: 0x99D13D0
        public void ReduceInPlace(){} // RVA: 0x99D1490
        public void ReduceBitWise(){} // RVA: 0x99D18A0
        public void ReduceBit(){} // RVA: 0x99D19A0
        public void ReduceWordWise(){} // RVA: 0x99D1B00
        public void ReduceWord(){} // RVA: 0x99D1C90
        public void ReduceVectorWise(){} // RVA: 0x99D1E40
        public void FlipVector(){} // RVA: 0x99D21B0
        public void ModSquare(){} // RVA: 0x99D2350
        public void ModSquareN(){} // RVA: 0x99D2530
        public void Square(){} // RVA: 0x99D2750
        public void SquareInPlace(){} // RVA: 0x99D28E0
        public void Interleave(){} // RVA: 0x99D29B0
        public void Interleave3(){} // RVA: 0x99D3060 | overloaded x2
        public void Interleave3_21to63(){} // RVA: 0x99D3120
        public void Interleave5(){} // RVA: 0x99D33B0 | overloaded x2
        public void Interleave3_13to65(){} // RVA: 0x99D34A0
        public void Interleave7(){} // RVA: 0x99D3620 | overloaded x2
        public void Interleave2_n(){} // RVA: 0x99D3890 | overloaded x2
        public void Interleave4_16to64(){} // RVA: 0x99D3B80
        public void Interleave2_32to64(){} // RVA: 0x99D3C10
        public void ModInverse(){} // RVA: 0x99D3CF0
        public void Equals(){} // RVA: 0x99D42E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x99D4390
        public void Copy(){} // RVA: 0x99D4400
        public void ToString(){} // RVA: 0x99D4530
        public void .cctor(){} // RVA: 0x99D4770
    }

    public class ScaleXNegateYPointMap : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void Map(){} // RVA: 0x99D4BC0
    }

    public class ScaleXPointMap : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void Map(){} // RVA: 0x99D4C00
    }

    public class ScaleYNegateXPointMap : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void Map(){} // RVA: 0x99D4C40
    }

    public class ScaleYPointMap : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void Map(){} // RVA: 0x99D4C80
    }

    public class SimpleLookupTable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint[] points; // 0x10

        // ── Methods ──
        public void Copy(){} // RVA: 0x99D4CC0
        public void .ctor(){} // RVA: 0x99D4E20
        public void get_Size(){} // RVA: 0xF3F910
        public void Lookup(){} // RVA: 0x6AD84E0
    }

}