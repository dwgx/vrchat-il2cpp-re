// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC
// Classes: 25
// Methods: 385

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC
{
    public class AbstractF2mCurve
    {
        // ── Methods ──
        public void Inverse(){} // RVA: 0x7FFAFC46C580
        public void BuildField(){} // RVA: 0x7FFAFC46C620
        public void .ctor(){} // RVA: 0x7FFAFC46C890
        public void IsValidFieldElement(){} // RVA: 0x7FFAFC46C910
        public void CreatePoint(){} // RVA: 0x7FFAFC46C970
        public void DecompressPoint(){} // RVA: 0x7FFAFC46CB30
        public void SolveQuadraticEquation(){} // RVA: 0x7FFAFC46CDD0
        public void GetSi(){} // RVA: 0x7FFAFC46D200
        public void get_IsKoblitz(){} // RVA: 0x7FFAFC46D3E0
    }

    public class AbstractF2mFieldElement
    {
        // ── Methods ──
        public void HalfTrace(){} // RVA: 0x7FFAFC4712A0
        public void get_HasFastTrace(){} // RVA: 0x7FFAF2D8D320
        public void Trace(){} // RVA: 0x7FFAFC4714A0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBF2E360 | overloaded x2
        public void SatisfiesCurveEquation(){} // RVA: 0x7FFAFC4791E0
        public void SatisfiesOrder(){} // RVA: 0x7FFAFC479750
        public void ScaleX(){} // RVA: 0x7FFAFC479BF0
        public void ScaleXNegateY(){} // RVA: 0x7FFAF94CFDE0
        public void ScaleY(){} // RVA: 0x7FFAFC479F80
        public void ScaleYNegateX(){} // RVA: 0x7FFAFC47A140
        public void Subtract(){} // RVA: 0x7FFAFC475020
        public void Tau(){} // RVA: 0x7FFAFC47A160
        public void TauPow(){} // RVA: 0x7FFAFC47A4A0
    }

    public class AbstractFpCurve
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC46B3F0
        public void IsValidFieldElement(){} // RVA: 0x7FFAFC46B5F0
        public void DecompressPoint(){} // RVA: 0x7FFAFC46B690
    }

    public class AbstractFpFieldElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBF2E360 | overloaded x2
        public void get_CompressionYTilde(){} // RVA: 0x7FFAFC474C10
        public void SatisfiesCurveEquation(){} // RVA: 0x7FFAFC474C50
        public void Subtract(){} // RVA: 0x7FFAFC475020
    }

    public class ECAlgorithms
    {
        // ── Methods ──
        public void IsF2mCurve(){} // RVA: 0x7FFAFC464C80
        public void IsF2mField(){} // RVA: 0x7FFAFC464DA0
        public void IsFpCurve(){} // RVA: 0x7FFAFC464EA0
        public void IsFpField(){} // RVA: 0x7FFAFC464F10
        public void SumOfMultiplies(){} // RVA: 0x7FFAFC464F70
        public void SumOfTwoMultiplies(){} // RVA: 0x7FFAFC4653B0
        public void ShamirsTrick(){} // RVA: 0x7FFAFC465890
        public void ImportPoint(){} // RVA: 0x7FFAFC465A30
        public void MontgomeryTrick(){} // RVA: 0x7FFAFC465B20 | overloaded x2
        public void ReferenceMultiply(){} // RVA: 0x7FFAFC465F00
        public void ValidatePoint(){} // RVA: 0x7FFAFC466060
        public void CleanPoint(){} // RVA: 0x7FFAFC4660E0
        public void ImplCheckResult(){} // RVA: 0x7FFAFC4661D0
        public void ImplShamirsTrickJsf(){} // RVA: 0x7FFAFC466250
        public void ImplShamirsTrickWNaf(){} // RVA: 0x7FFAFC466FE0 | overloaded x3
        public void ImplSumOfMultiplies(){} // RVA: 0x7FFAFC468400 | overloaded x3
        public void ImplSumOfMultipliesGlv(){} // RVA: 0x7FFAFC4676B0
        public void ImplShamirsTrickFixedPoint(){} // RVA: 0x7FFAFC468760
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ECCurve
    {
        // ── Methods ──
        public void GetAllCoordinateSystems(){} // RVA: 0x7FFAFC468C20
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_FieldSize(){} // RVA: 0x7FFAF2ABD840
        public void FromBigInteger(){} // RVA: 0x7FFAF2ABCE10
        public void IsValidFieldElement(){} // RVA: 0x7FFAF2ABDE40
        public void Configure(){} // RVA: 0x7FFAFC468C90
        public void ValidatePoint(){} // RVA: 0x7FFAFC468E90 | overloaded x2
        public void CreatePoint(){} // RVA: 0x7FFAFC468F30 | overloaded x2
        public void CloneCurve(){} // RVA: 0x7FFAF2ABCD60
        public void CreateRawPoint(){} // overloaded x2
        public void CreateDefaultMultiplier(){} // RVA: 0x7FFAFC468FC0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFAF40178D0
        public void GetPreCompInfo(){} // RVA: 0x7FFAFC469190
        public void Precompute(){} // RVA: 0x7FFAFC469510
        public void ImportPoint(){} // RVA: 0x7FFAFC4699B0
        public void NormalizeAll(){} // RVA: 0x7FFAFC469B40 | overloaded x2
        public void get_Infinity(){} // RVA: 0x7FFAF2ABCD60
        public void get_Field(){} // RVA: 0x7FFAF2DA8380
        public void get_A(){} // RVA: 0x7FFAF2D907C0
        public void get_B(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Order(){} // RVA: 0x7FFAF2DBB130
        public void get_Cofactor(){} // RVA: 0x7FFAF30E74D0
        public void get_CoordinateSystem(){} // RVA: 0x7FFAF3A8C9F0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFAFC469EE0
        public void CheckPoint(){} // RVA: 0x7FFAFC46A1C0
        public void CheckPoints(){} // RVA: 0x7FFAFC46A2A0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAFC46A640 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC46A6E0
        public void DecompressPoint(){} // RVA: 0x7FFAF2ACCEE0
        public void GetEndomorphism(){} // RVA: 0x7FFAF2E0A740
        public void GetMultiplier(){} // RVA: 0x7FFAFC46A800
        public void DecodePoint(){} // RVA: 0x7FFAFC46A9B0
    }

    public class ECFieldElement
    {
        // ── Methods ──
        public void ToBigInteger(){} // RVA: 0x7FFAF2ABCD60
        public void get_FieldName(){} // RVA: 0x7FFAF2ABCD60
        public void get_FieldSize(){} // RVA: 0x7FFAF2ABD840
        public void Add(){} // RVA: 0x7FFAF2ABCE10
        public void AddOne(){} // RVA: 0x7FFAF2ABCD60
        public void Subtract(){} // RVA: 0x7FFAF2ABCE10
        public void Multiply(){} // RVA: 0x7FFAF2ABCE10
        public void Divide(){} // RVA: 0x7FFAF2ABCE10
        public void Negate(){} // RVA: 0x7FFAF2ABCD60
        public void Square(){} // RVA: 0x7FFAF2ABCD60
        public void Invert(){} // RVA: 0x7FFAF2ABCD60
        public void Sqrt(){} // RVA: 0x7FFAF2ABCD60
        public void get_BitLength(){} // RVA: 0x7FFAFC46E690
        public void get_IsOne(){} // RVA: 0x7FFAFC46E6C0
        public void get_IsZero(){} // RVA: 0x7FFAFC46E6F0
        public void MultiplyMinusProduct(){} // RVA: 0x7FFAFC46E720
        public void MultiplyPlusProduct(){} // RVA: 0x7FFAFC46E7A0
        public void SquareMinusProduct(){} // RVA: 0x7FFAFC46E820
        public void SquarePlusProduct(){} // RVA: 0x7FFAFC46E8A0
        public void SquarePow(){} // RVA: 0x7FFAFC46E920
        public void TestBitZero(){} // RVA: 0x7FFAFC46E970
        public void Equals(){} // RVA: 0x7FFAFC46EA50 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8763C00
        public void ToString(){} // RVA: 0x7FFAFC46EAE0
        public void GetEncoded(){} // RVA: 0x7FFAFC46EB20
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ECLookupTable
    {
        // ── Methods ──
        public void get_Size(){} // RVA: 0x7FFAF2ABD840
        public void Lookup(){} // RVA: 0x7FFAF2ACBCC0
    }

    public class ECPoint
    {
        // ── Methods ──
        public void GetInitialZCoords(){} // RVA: 0x7FFAFC472BA0
        public void .ctor(){} // RVA: 0x7FFAFC472FC0 | overloaded x2
        public void SatisfiesCurveEquation(){} // RVA: 0x7FFAF2ABDBE0
        public void SatisfiesOrder(){} // RVA: 0x7FFAFC473120
        public void GetDetachedPoint(){} // RVA: 0x7FFAFC473260
        public void get_Curve(){} // RVA: 0x7FFAF2DA8380
        public void Detach(){} // RVA: 0x7FFAF2ABCD60
        public void get_CurveCoordinateSystem(){} // RVA: 0x7FFAFC4732A0
        public void get_AffineXCoord(){} // RVA: 0x7FFAFC4732D0
        public void get_AffineYCoord(){} // RVA: 0x7FFAFC473310
        public void get_XCoord(){} // RVA: 0x7FFAF2D907C0
        public void get_YCoord(){} // RVA: 0x7FFAF2DBB0C0
        public void GetZCoord(){} // RVA: 0x7FFAFC473350
        public void GetZCoords(){} // RVA: 0x7FFAFC473390
        public void get_RawXCoord(){} // RVA: 0x7FFAF2D907C0
        public void get_RawYCoord(){} // RVA: 0x7FFAF2DBB0C0
        public void get_RawZCoords(){} // RVA: 0x7FFAF2DBB130
        public void CheckNormalized(){} // RVA: 0x7FFAFC473420
        public void IsNormalized(){} // RVA: 0x7FFAFC4734A0
        public void Normalize(){} // RVA: 0x7FFAFC4735F0 | overloaded x2
        public void CreateScaledPoint(){} // RVA: 0x7FFAFC473740
        public void get_IsInfinity(){} // RVA: 0x7FFAFC473800
        public void get_IsCompressed(){} // RVA: 0x7FFAF2DB3450
        public void IsValid(){} // RVA: 0x7FFAFC473820
        public void IsValidPartial(){} // RVA: 0x7FFAFC473830
        public void ImplIsValid(){} // RVA: 0x7FFAFC473840
        public void ScaleX(){} // RVA: 0x7FFAFC4739E0
        public void ScaleXNegateY(){} // RVA: 0x7FFAFC473AA0
        public void ScaleY(){} // RVA: 0x7FFAFC473B70
        public void ScaleYNegateX(){} // RVA: 0x7FFAFC473C30
        public void Equals(){} // RVA: 0x7FFAFC473DB0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC4740E0
        public void ToString(){} // RVA: 0x7FFAFC4741F0
        public void GetEncoded(){} // RVA: 0x7FFAFC474430 | overloaded x2
        public void get_CompressionYTilde(){} // RVA: 0x7FFAF2ABDBE0
        public void Add(){} // RVA: 0x7FFAF2ABCE10
        public void Subtract(){} // RVA: 0x7FFAF2ABCE10
        public void Negate(){} // RVA: 0x7FFAF2ABCD60
        public void TimesPow2(){} // RVA: 0x7FFAFC474450
        public void Twice(){} // RVA: 0x7FFAF2ABCD60
        public void Multiply(){} // RVA: 0x7FFAF2ABCE10
        public void TwicePlus(){} // RVA: 0x7FFAFC474500
        public void ThreeTimes(){} // RVA: 0x7FFAFC474550
        public void .cctor(){} // RVA: 0x7FFAFC474570
    }

    public class ECPointBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC4748A0 | overloaded x2
        public void GetEncoded(){} // RVA: 0x7FFAFC474930
        public void Multiply(){} // RVA: 0x7FFAFC474B60
    }

    public class ECPointMap
    {
        // ── Methods ──
        public void Map(){} // RVA: 0x7FFAF2ABCE10
    }

    public class F2mCurve
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC46D950 | overloaded x5
        public void CloneCurve(){} // RVA: 0x7FFAFC46DBD0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFAFC46DCA0
        public void CreateDefaultMultiplier(){} // RVA: 0x7FFAFC46DCB0
        public void get_FieldSize(){} // RVA: 0x7FFAF349AB90
        public void FromBigInteger(){} // RVA: 0x7FFAFC46DD20
        public void CreateRawPoint(){} // RVA: 0x7FFAFC46DEF0 | overloaded x2
        public void get_Infinity(){} // RVA: 0x7FFAF2E08D50
        public void get_M(){} // RVA: 0x7FFAF349AB90
        public void IsTrinomial(){} // RVA: 0x7FFAFC46DF90
        public void get_K1(){} // RVA: 0x7FFAF30554D0
        public void get_K2(){} // RVA: 0x7FFAF304CEC0
        public void get_K3(){} // RVA: 0x7FFAF304C4F0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFAFC46DFB0
    }

    public class F2mFieldElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC4718F0 | overloaded x3
        public void get_BitLength(){} // RVA: 0x7FFAFC4719D0
        public void get_IsOne(){} // RVA: 0x7FFAFC4719F0
        public void get_IsZero(){} // RVA: 0x7FFAFC471A60
        public void TestBitZero(){} // RVA: 0x7FFAFC471AC0
        public void ToBigInteger(){} // RVA: 0x7FFAFC471B10
        public void get_FieldName(){} // RVA: 0x7FFAFC471B30
        public void get_FieldSize(){} // RVA: 0x7FFAF335BED0
        public void CheckFieldElements(){} // RVA: 0x7FFAFC471B70
        public void Add(){} // RVA: 0x7FFAFC471DC0
        public void AddOne(){} // RVA: 0x7FFAFC471EC0
        public void Subtract(){} // RVA: 0x7FFAF79962A0
        public void Multiply(){} // RVA: 0x7FFAFC471F60
        public void MultiplyMinusProduct(){} // RVA: 0x7FFAFBF665A0
        public void MultiplyPlusProduct(){} // RVA: 0x7FFAFC472050
        public void Divide(){} // RVA: 0x7FFAFBF667F0
        public void Negate(){} // RVA: 0x7FFAF44EF520
        public void Square(){} // RVA: 0x7FFAFC472260
        public void SquareMinusProduct(){} // RVA: 0x7FFAFBF66920
        public void SquarePlusProduct(){} // RVA: 0x7FFAFC472300
        public void SquarePow(){} // RVA: 0x7FFAFC472600
        public void Invert(){} // RVA: 0x7FFAFC4726C0
        public void Sqrt(){} // RVA: 0x7FFAFC472760
        public void get_Representation(){} // RVA: 0x7FFAF2DDA5C0
        public void get_M(){} // RVA: 0x7FFAF335BED0
        public void get_K1(){} // RVA: 0x7FFAFC472820
        public void get_K2(){} // RVA: 0x7FFAFC472850
        public void get_K3(){} // RVA: 0x7FFAFC472890
        public void Equals(){} // RVA: 0x7FFAFC472990 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC472AE0
    }

    public class F2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBF2E360 | overloaded x3
        public void Detach(){} // RVA: 0x7FFAFC47A9B0
        public void get_YCoord(){} // RVA: 0x7FFAFC47AAD0
        public void get_CompressionYTilde(){} // RVA: 0x7FFAFC47AC20
        public void Add(){} // RVA: 0x7FFAFC47AD30
        public void Twice(){} // RVA: 0x7FFAFC47BEB0
        public void TwicePlus(){} // RVA: 0x7FFAFC47CB90
        public void Negate(){} // RVA: 0x7FFAFC47D2E0
    }

    public class FpCurve
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC46BC00 | overloaded x4
        public void CloneCurve(){} // RVA: 0x7FFAFC46BEF0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFAFC46BFB0
        public void get_Q(){} // RVA: 0x7FFAF2E2E0E0
        public void get_Infinity(){} // RVA: 0x7FFAF2E2B370
        public void get_FieldSize(){} // RVA: 0x7FFAFC46BFC0
        public void FromBigInteger(){} // RVA: 0x7FFAFC46BFE0
        public void CreateRawPoint(){} // RVA: 0x7FFAFC46C160 | overloaded x2
        public void ImportPoint(){} // RVA: 0x7FFAFC46C200
    }

    public class FpFieldElement
    {
        // ── Methods ──
        public void CalculateResidue(){} // RVA: 0x7FFAFC46EB80
        public void .ctor(){} // RVA: 0x7FFAFC46ED30 | overloaded x2
        public void ToBigInteger(){} // RVA: 0x7FFAF2DBB0C0
        public void get_FieldName(){} // RVA: 0x7FFAFC46EE10
        public void get_FieldSize(){} // RVA: 0x7FFAFC46EE50
        public void get_Q(){} // RVA: 0x7FFAF2DA8380
        public void Add(){} // RVA: 0x7FFAFC46EE70
        public void AddOne(){} // RVA: 0x7FFAFC46EF50
        public void Subtract(){} // RVA: 0x7FFAFC46F080
        public void Multiply(){} // RVA: 0x7FFAFC46F160
        public void MultiplyMinusProduct(){} // RVA: 0x7FFAFC46F240
        public void MultiplyPlusProduct(){} // RVA: 0x7FFAFC46F3B0
        public void Divide(){} // RVA: 0x7FFAFC46F5A0
        public void Negate(){} // RVA: 0x7FFAFC46F6A0
        public void Square(){} // RVA: 0x7FFAFC46F760
        public void SquareMinusProduct(){} // RVA: 0x7FFAFC46F810
        public void SquarePlusProduct(){} // RVA: 0x7FFAFC46F960
        public void Invert(){} // RVA: 0x7FFAFC46FB20
        public void Sqrt(){} // RVA: 0x7FFAFC46FBC0
        public void CheckSqrt(){} // RVA: 0x7FFAFC4702F0
        public void LucasSequence(){} // RVA: 0x7FFAFC470360
        public void ModAdd(){} // RVA: 0x7FFAFC470960
        public void ModDouble(){} // RVA: 0x7FFAFC4709D0
        public void ModHalf(){} // RVA: 0x7FFAFC470A40
        public void ModHalfAbs(){} // RVA: 0x7FFAFC470AB0
        public void ModInverse(){} // RVA: 0x7FFAFC470B20
        public void ModMult(){} // RVA: 0x7FFAFC470C20
        public void ModReduce(){} // RVA: 0x7FFAFC470C70
        public void ModSubtract(){} // RVA: 0x7FFAFC471050
        public void Equals(){} // RVA: 0x7FFAFC471160 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC471220
    }

    public class FpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBF2E360 | overloaded x3
        public void Detach(){} // RVA: 0x7FFAFC4751D0
        public void GetZCoord(){} // RVA: 0x7FFAFC4752E0
        public void Add(){} // RVA: 0x7FFAFC475370
        public void Twice(){} // RVA: 0x7FFAFC476390
        public void TwicePlus(){} // RVA: 0x7FFAFC477190
        public void ThreeTimes(){} // RVA: 0x7FFAFC477800
        public void TimesPow2(){} // RVA: 0x7FFAFC477DA0
        public void Two(){} // RVA: 0x7FFAFC4787E0
        public void Three(){} // RVA: 0x7FFAFC478810
        public void Four(){} // RVA: 0x7FFAFC478860
        public void Eight(){} // RVA: 0x7FFAFC4788A0
        public void DoubleProductFromSquares(){} // RVA: 0x7FFAFC4788E0
        public void Negate(){} // RVA: 0x7FFAFC478980
        public void CalculateJacobianModifiedW(){} // RVA: 0x7FFAFC478B70
        public void GetJacobianModifiedW(){} // RVA: 0x7FFAFC478D10
        public void TwiceJacobianModified(){} // RVA: 0x7FFAFC478DB0
    }

    public class LongArray
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC47D960 | overloaded x4
        public void CopyTo(){} // RVA: 0x7FFAFC47DBA0
        public void IsOne(){} // RVA: 0x7FFAFC47DBE0
        public void IsZero(){} // RVA: 0x7FFAFC47DC40
        public void GetUsedLength(){} // RVA: 0x7FFAFC47DC90
        public void GetUsedLengthFrom(){} // RVA: 0x7FFAFC47DD70
        public void Degree(){} // RVA: 0x7FFAFC47DE50
        public void DegreeFrom(){} // RVA: 0x7FFAFC47DF00
        public void BitLength(){} // RVA: 0x7FFAFC47DFC0
        public void ResizedInts(){} // RVA: 0x7FFAFC47E170
        public void ToBigInteger(){} // RVA: 0x7FFAFC47E230
        public void ShiftUp(){} // RVA: 0x7FFAFC47E530 | overloaded x2
        public void AddOne(){} // RVA: 0x7FFAFC47E600
        public void AddShiftedByBitsSafe(){} // RVA: 0x7FFAFC47E7F0
        public void AddShiftedUp(){} // RVA: 0x7FFAFC47E9A0
        public void AddShiftedDown(){} // RVA: 0x7FFAFC47EA60
        public void AddShiftedByWords(){} // RVA: 0x7FFAFC47EB20
        public void Add(){} // RVA: 0x7FFAFC47ECE0 | overloaded x2
        public void AddBoth(){} // RVA: 0x7FFAFC47ED90
        public void Distribute(){} // RVA: 0x7FFAFC47EE40
        public void get_Length(){} // RVA: 0x7FFAF39EF910
        public void FlipWord(){} // RVA: 0x7FFAFC47EEE0
        public void TestBitZero(){} // RVA: 0x7FFAFC47EF70
        public void TestBit(){} // RVA: 0x7FFAFC47EFB0
        public void FlipBit(){} // RVA: 0x7FFAFC47F000
        public void MultiplyWord(){} // RVA: 0x7FFAFC47F040
        public void ModMultiplyLD(){} // RVA: 0x7FFAFC47F1E0
        public void ModMultiply(){} // RVA: 0x7FFAFC47FAA0
        public void ModMultiplyAlt(){} // RVA: 0x7FFAFC480230
        public void ModReduce(){} // RVA: 0x7FFAFC480A00
        public void Multiply(){} // RVA: 0x7FFAFC480B60
        public void Reduce(){} // RVA: 0x7FFAFC4812A0
        public void ReduceResult(){} // RVA: 0x7FFAFC4813D0
        public void ReduceInPlace(){} // RVA: 0x7FFAFC481490
        public void ReduceBitWise(){} // RVA: 0x7FFAFC4818A0
        public void ReduceBit(){} // RVA: 0x7FFAFC4819A0
        public void ReduceWordWise(){} // RVA: 0x7FFAFC481B00
        public void ReduceWord(){} // RVA: 0x7FFAFC481C90
        public void ReduceVectorWise(){} // RVA: 0x7FFAFC481E40
        public void FlipVector(){} // RVA: 0x7FFAFC4821B0
        public void ModSquare(){} // RVA: 0x7FFAFC482350
        public void ModSquareN(){} // RVA: 0x7FFAFC482530
        public void Square(){} // RVA: 0x7FFAFC482750
        public void SquareInPlace(){} // RVA: 0x7FFAFC4828E0
        public void Interleave(){} // RVA: 0x7FFAFC4829B0
        public void Interleave3(){} // RVA: 0x7FFAFC483060 | overloaded x2
        public void Interleave3_21to63(){} // RVA: 0x7FFAFC483120
        public void Interleave5(){} // RVA: 0x7FFAFC4833B0 | overloaded x2
        public void Interleave3_13to65(){} // RVA: 0x7FFAFC4834A0
        public void Interleave7(){} // RVA: 0x7FFAFC483620 | overloaded x2
        public void Interleave2_n(){} // RVA: 0x7FFAFC483890 | overloaded x2
        public void Interleave4_16to64(){} // RVA: 0x7FFAFC483B80
        public void Interleave2_32to64(){} // RVA: 0x7FFAFC483C10
        public void ModInverse(){} // RVA: 0x7FFAFC483CF0
        public void Equals(){} // RVA: 0x7FFAFC4842E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC484390
        public void Copy(){} // RVA: 0x7FFAFC484400
        public void ToString(){} // RVA: 0x7FFAFC484530
        public void .cctor(){} // RVA: 0x7FFAFC484770
    }

    public class ScaleXNegateYPointMap : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Map(){} // RVA: 0x7FFAFC484BC0
    }

    public class ScaleXPointMap : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Map(){} // RVA: 0x7FFAFC484C00
    }

    public class ScaleYNegateXPointMap : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Map(){} // RVA: 0x7FFAFC484C40
    }

    public class ScaleYPointMap : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Map(){} // RVA: 0x7FFAFC484C80
    }

    public class SimpleLookupTable
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFAFC484CC0
        public void .ctor(){} // RVA: 0x7FFAFC484E20
        public void get_Size(){} // RVA: 0x7FFAF39EF910
        public void Lookup(){} // RVA: 0x7FFAF95884E0
    }

}