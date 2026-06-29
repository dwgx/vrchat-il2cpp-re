// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC
// Classes: 27
// Methods: 368

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC
{
    public class AbstractF2mCurve : ECCurve
    {
        public object si;

        // ── Methods ──
        public void Inverse(){} // RVA: 0xA666020
        public void BuildField(){} // RVA: 0xA6660C0
        public void .ctor(){} // RVA: 0xA666330
        public void IsValidFieldElement(){} // RVA: 0xA6663B0
        public void CreatePoint(){} // RVA: 0xA666410
        public void DecompressPoint(){} // RVA: 0xA6665D0
        public void SolveQuadraticEquation(){} // RVA: 0xA666870
        public void GetSi(){} // RVA: 0xA666CA0
        public void get_IsKoblitz(){} // RVA: 0xA666E50
    }

    public class AbstractF2mFieldElement : ECFieldElement
    {
        // ── Methods ──
        public void HalfTrace(){} // RVA: 0xA66AD90
        public void get_HasFastTrace(){} // RVA: 0xB43320
        public void Trace(){} // RVA: 0xA66AF80
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AbstractF2mPoint : ECPointBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void SatisfiesCurveEquation(){} // RVA: 0xA672C90
        public void SatisfiesOrder(){} // RVA: 0xA673200
        public void ScaleX(){} // RVA: 0xA6736A0
        public void ScaleXNegateY(){} // RVA: 0x7485660
        public void ScaleY(){} // RVA: 0xA673A30
        public void ScaleYNegateX(){} // RVA: 0xA673BF0
        public void Subtract(){} // RVA: 0xA66EAC0
        public void Tau(){} // RVA: 0xA673C10
        public void TauPow(){} // RVA: 0xA673F50
    }

    public class AbstractFpCurve : ECCurve
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA664E90
        public void IsValidFieldElement(){} // RVA: 0xA665090
        public void DecompressPoint(){} // RVA: 0xA665130
    }

    public class AbstractFpFieldElement : ECFieldElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AbstractFpPoint : ECPointBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void get_CompressionYTilde(){} // RVA: 0xA66E6A0
        public void SatisfiesCurveEquation(){} // RVA: 0xA66E6E0
        public void Subtract(){} // RVA: 0xA66EAC0
    }

    public class ECAlgorithms : Object
    {
        // ── Methods ──
        public void IsF2mCurve(){} // RVA: 0xA65E470
        public void IsF2mField(){} // RVA: 0xA65E590
        public void IsFpCurve(){} // RVA: 0xA65E690
        public void IsFpField(){} // RVA: 0xA65E700
        public void SumOfMultiplies(){} // RVA: 0xA65E760
        public void SumOfTwoMultiplies(){} // RVA: 0xA65EBC0
        public void ShamirsTrick(){} // RVA: 0xA65F0A0
        public void ImportPoint(){} // RVA: 0xA65F240
        public void MontgomeryTrick(){} // RVA: 0xA65F330
        public void ReferenceMultiply(){} // RVA: 0xA65F750
        public void ValidatePoint(){} // RVA: 0xA65F8B0
        public void CleanPoint(){} // RVA: 0xA65F930
        public void ImplCheckResult(){} // RVA: 0xA65FA20
        public void ImplShamirsTrickJsf(){} // RVA: 0xA65FAA0
        public void ImplShamirsTrickWNaf(){} // RVA: 0xA660840
        public void ImplSumOfMultiplies(){} // RVA: 0xA661E20
        public void ImplSumOfMultipliesGlv(){} // RVA: 0xA660FF0
        public void ImplShamirsTrickFixedPoint(){} // RVA: 0xA6621E0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ECCurve : Object
    {
        public object COORD_AFFINE;
        public object COORD_HOMOGENEOUS;
        public object COORD_JACOBIAN;
        public object COORD_JACOBIAN_CHUDNOVSKY;
        public object COORD_JACOBIAN_MODIFIED;
        public object COORD_LAMBDA_AFFINE;
        public object COORD_LAMBDA_PROJECTIVE;
        public object COORD_SKEWED;
        public object m_field;
        public object m_a;
        public object m_b;
        public object m_order;
        public object m_cofactor;
        public object m_coord;
        public object m_endomorphism;
        public object m_multiplier;

        // ── Methods ──
        public void GetAllCoordinateSystems(){} // RVA: 0xA6626A0
        public void .ctor(){} // RVA: 0xB44D60
        public void get_FieldSize(){} // RVA: 0x87C130
        public void FromBigInteger(){} // RVA: 0x87C540
        public void IsValidFieldElement(){} // RVA: 0x87D350
        public void Configure(){} // RVA: 0xA662710
        public void ValidatePoint(){} // RVA: 0xA662910
        public void CreatePoint(){} // RVA: 0xA6629B0
        public void CloneCurve(){} // RVA: 0x87C0A0
        public void CreateRawPoint(){} // RVA: 0x88E660
        public void CreateDefaultMultiplier(){} // RVA: 0xA662A40
        public void SupportsCoordinateSystem(){} // RVA: 0x1E35590
        public void GetPreCompInfo(){} // RVA: 0xA662C10
        public void Precompute(){} // RVA: 0xA662F40
        public void ImportPoint(){} // RVA: 0xA663390
        public void NormalizeAll(){} // RVA: 0xA663520
        public void get_Infinity(){} // RVA: 0x87C0A0
        public void get_Field(){} // RVA: 0xB5DBF0
        public void get_A(){} // RVA: 0xB465B0
        public void get_B(){} // RVA: 0xB700F0
        public void get_Order(){} // RVA: 0xB70160
        public void get_Cofactor(){} // RVA: 0xD33E60
        public void get_CoordinateSystem(){} // RVA: 0x18A0130
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA663940
        public void CheckPoint(){} // RVA: 0xA663C40
        public void CheckPoints(){} // RVA: 0xA663D20
        public void Equals(){} // RVA: 0xA6640D0
        public void GetHashCode(){} // RVA: 0xA664170
        public void DecompressPoint(){} // RVA: 0x88B510
        public void GetEndomorphism(){} // RVA: 0xBC1B30
        public void GetMultiplier(){} // RVA: 0xA664290
        public void DecodePoint(){} // RVA: 0xA664410
    }

    public class ECFieldElement : Object
    {
        // ── Methods ──
        public void ToBigInteger(){} // RVA: 0x87C0A0
        public void get_FieldName(){} // RVA: 0x87C0A0
        public void get_FieldSize(){} // RVA: 0x87C130
        public void Add(){} // RVA: 0x87C540
        public void AddOne(){} // RVA: 0x87C0A0
        public void Subtract(){} // RVA: 0x87C540
        public void Multiply(){} // RVA: 0x87C540
        public void Divide(){} // RVA: 0x87C540
        public void Negate(){} // RVA: 0x87C0A0
        public void Square(){} // RVA: 0x87C0A0
        public void Invert(){} // RVA: 0x87C0A0
        public void Sqrt(){} // RVA: 0x87C0A0
        public void get_BitLength(){} // RVA: 0xA6681A0
        public void get_IsOne(){} // RVA: 0xA6681D0
        public void get_IsZero(){} // RVA: 0xA668200
        public void MultiplyMinusProduct(){} // RVA: 0xA668230
        public void MultiplyPlusProduct(){} // RVA: 0xA6682B0
        public void SquareMinusProduct(){} // RVA: 0xA668330
        public void SquarePlusProduct(){} // RVA: 0xA6683B0
        public void SquarePow(){} // RVA: 0xA668430
        public void TestBitZero(){} // RVA: 0xA668480
        public void Equals(){} // RVA: 0xA668560
        public void GetHashCode(){} // RVA: 0x672C590
        public void ToString(){} // RVA: 0xA6685F0
        public void GetEncoded(){} // RVA: 0xA668630
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ECFieldElement[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ECLookupTable
    {
        // ── Methods ──
        public void get_Size(){} // RVA: 0x87C130
        public void Lookup(){} // RVA: 0x87C160
    }

    public class ECPoint : Object
    {
        public object EMPTY_ZS;
        public object m_curve;
        public object m_x;
        public object m_y;
        public object m_zs;
        public object m_withCompression;
        public object m_preCompTable;

        // ── Methods ──
        public void GetInitialZCoords(){} // RVA: 0xA66C630
        public void .ctor(){} // RVA: 0xA66CA40
        public void SatisfiesCurveEquation(){} // RVA: 0x87D280
        public void SatisfiesOrder(){} // RVA: 0xA66CBA0
        public void GetDetachedPoint(){} // RVA: 0xA66CCE0
        public void get_Curve(){} // RVA: 0xB5DBF0
        public void Detach(){} // RVA: 0x87C0A0
        public void get_CurveCoordinateSystem(){} // RVA: 0xA66CD20
        public void get_AffineXCoord(){} // RVA: 0xA66CD50
        public void get_AffineYCoord(){} // RVA: 0xA66CD90
        public void get_XCoord(){} // RVA: 0xB465B0
        public void get_YCoord(){} // RVA: 0xB700F0
        public void GetZCoord(){} // RVA: 0xA66CDD0
        public void GetZCoords(){} // RVA: 0xA66CE10
        public void get_RawXCoord(){} // RVA: 0xB465B0
        public void get_RawYCoord(){} // RVA: 0xB700F0
        public void get_RawZCoords(){} // RVA: 0xB70160
        public void CheckNormalized(){} // RVA: 0xA66CEA0
        public void IsNormalized(){} // RVA: 0xA66CF20
        public void Normalize(){} // RVA: 0xA66D070
        public void CreateScaledPoint(){} // RVA: 0xA66D1C0
        public void get_IsInfinity(){} // RVA: 0xA66D280
        public void get_IsCompressed(){} // RVA: 0xB68DF0
        public void IsValid(){} // RVA: 0xA66D2A0
        public void IsValidPartial(){} // RVA: 0xA66D2B0
        public void ImplIsValid(){} // RVA: 0xA66D2C0
        public void ScaleX(){} // RVA: 0xA66D470
        public void ScaleXNegateY(){} // RVA: 0xA66D530
        public void ScaleY(){} // RVA: 0xA66D600
        public void ScaleYNegateX(){} // RVA: 0xA66D6C0
        public void Equals(){} // RVA: 0xA66D840
        public void GetHashCode(){} // RVA: 0xA66DB80
        public void ToString(){} // RVA: 0xA66DC90
        public void GetEncoded(){} // RVA: 0x881D20
        public void get_CompressionYTilde(){} // RVA: 0x87D280
        public void Add(){} // RVA: 0x87C540
        public void Subtract(){} // RVA: 0x87C540
        public void Negate(){} // RVA: 0x87C0A0
        public void TimesPow2(){} // RVA: 0xA66DF00
        public void Twice(){} // RVA: 0x87C0A0
        public void Multiply(){} // RVA: 0x87C540
        public void TwicePlus(){} // RVA: 0xA66DFB0
        public void ThreeTimes(){} // RVA: 0xA66E000
        public void .cctor(){} // RVA: 0xA66E020
    }

    public class ECPointBase : ECPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA66E330
        public void GetEncoded(){} // RVA: 0xA66E3C0
        public void Multiply(){} // RVA: 0xA66E5F0
    }

    public class ECPointMap
    {
        // ── Methods ──
        public void Map(){} // RVA: 0x87C540
    }

    public class ECPoint[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class F2mCurve : AbstractF2mCurve
    {
        public object F2M_DEFAULT_COORDS;
        public object m;
        public object k1;
        public object k2;
        public object k3;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6673C0
        public void CloneCurve(){} // RVA: 0xA667640
        public void SupportsCoordinateSystem(){} // RVA: 0xA667710
        public void CreateDefaultMultiplier(){} // RVA: 0xA667720
        public void get_FieldSize(){} // RVA: 0x12BB630
        public void FromBigInteger(){} // RVA: 0xA667790
        public void CreateRawPoint(){} // RVA: 0xA667960
        public void get_Infinity(){} // RVA: 0xBBFF90
        public void get_M(){} // RVA: 0x12BB630
        public void IsTrinomial(){} // RVA: 0xA667A00
        public void get_K1(){} // RVA: 0xE36310
        public void get_K2(){} // RVA: 0xD347A0
        public void get_K3(){} // RVA: 0xD34720
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA667A20
    }

    public class F2mFieldElement : AbstractF2mFieldElement
    {
        public object Gnb;
        public object Tpb;
        public object Ppb;
        public object representation;
        public object m;
        public object ks;
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA66B3C0
        public void get_BitLength(){} // RVA: 0xA66B4A0
        public void get_IsOne(){} // RVA: 0xA66B4C0
        public void get_IsZero(){} // RVA: 0xA66B530
        public void TestBitZero(){} // RVA: 0xA66B590
        public void ToBigInteger(){} // RVA: 0xA66B5E0
        public void get_FieldName(){} // RVA: 0xA66B600
        public void get_FieldSize(){} // RVA: 0x116A650
        public void CheckFieldElements(){} // RVA: 0xA66B640
        public void Add(){} // RVA: 0xA66B890
        public void AddOne(){} // RVA: 0xA66B990
        public void Subtract(){} // RVA: 0x5BA5570
        public void Multiply(){} // RVA: 0xA66BA30
        public void MultiplyMinusProduct(){} // RVA: 0xA157150
        public void MultiplyPlusProduct(){} // RVA: 0xA66BB20
        public void Divide(){} // RVA: 0xA1573A0
        public void Negate(){} // RVA: 0x2303260
        public void Square(){} // RVA: 0xA66BD20
        public void SquareMinusProduct(){} // RVA: 0xA1574D0
        public void SquarePlusProduct(){} // RVA: 0xA66BDC0
        public void SquarePow(){} // RVA: 0xA66C0C0
        public void Invert(){} // RVA: 0xA66C180
        public void Sqrt(){} // RVA: 0xA66C220
        public void get_Representation(){} // RVA: 0xB8F8F0
        public void get_M(){} // RVA: 0x116A650
        public void get_K1(){} // RVA: 0xA66C2B0
        public void get_K2(){} // RVA: 0xA66C2E0
        public void get_K3(){} // RVA: 0xA66C320
        public void Equals(){} // RVA: 0xA66C410
        public void GetHashCode(){} // RVA: 0xA66C560
    }

    public class F2mPoint : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA674460
        public void get_YCoord(){} // RVA: 0xA674580
        public void get_CompressionYTilde(){} // RVA: 0xA6746D0
        public void Add(){} // RVA: 0xA6747E0
        public void Twice(){} // RVA: 0xA675960
        public void TwicePlus(){} // RVA: 0xA676640
        public void Negate(){} // RVA: 0xA676DA0
    }

    public class FpCurve : AbstractFpCurve
    {
        public object FP_DEFAULT_COORDS;
        public object m_q;
        public object m_r;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6656A0
        public void CloneCurve(){} // RVA: 0xA665990
        public void SupportsCoordinateSystem(){} // RVA: 0xA665A50
        public void get_Q(){} // RVA: 0xBE58B0
        public void get_Infinity(){} // RVA: 0xBE2C60
        public void get_FieldSize(){} // RVA: 0xA665A60
        public void FromBigInteger(){} // RVA: 0xA665A80
        public void CreateRawPoint(){} // RVA: 0xA665C00
        public void ImportPoint(){} // RVA: 0xA665CA0
    }

    public class FpFieldElement : AbstractFpFieldElement
    {
        public object q;
        public object r;
        public object x;

        // ── Methods ──
        public void CalculateResidue(){} // RVA: 0xA668690
        public void .ctor(){} // RVA: 0xA668840
        public void ToBigInteger(){} // RVA: 0xB700F0
        public void get_FieldName(){} // RVA: 0xA668920
        public void get_FieldSize(){} // RVA: 0xA668960
        public void get_Q(){} // RVA: 0xB5DBF0
        public void Add(){} // RVA: 0xA668980
        public void AddOne(){} // RVA: 0xA668A60
        public void Subtract(){} // RVA: 0xA668B90
        public void Multiply(){} // RVA: 0xA668C70
        public void MultiplyMinusProduct(){} // RVA: 0xA668D50
        public void MultiplyPlusProduct(){} // RVA: 0xA668EC0
        public void Divide(){} // RVA: 0xA6690B0
        public void Negate(){} // RVA: 0xA6691B0
        public void Square(){} // RVA: 0xA669270
        public void SquareMinusProduct(){} // RVA: 0xA669320
        public void SquarePlusProduct(){} // RVA: 0xA669470
        public void Invert(){} // RVA: 0xA669630
        public void Sqrt(){} // RVA: 0xA6696D0
        public void CheckSqrt(){} // RVA: 0xA669DF0
        public void LucasSequence(){} // RVA: 0xA669E60
        public void ModAdd(){} // RVA: 0xA66A460
        public void ModDouble(){} // RVA: 0xA66A4D0
        public void ModHalf(){} // RVA: 0xA66A540
        public void ModHalfAbs(){} // RVA: 0xA66A5B0
        public void ModInverse(){} // RVA: 0xA66A620
        public void ModMult(){} // RVA: 0xA66A720
        public void ModReduce(){} // RVA: 0xA66A770
        public void ModSubtract(){} // RVA: 0xA66AB50
        public void Equals(){} // RVA: 0xA66AC50
        public void GetHashCode(){} // RVA: 0xA66AD10
    }

    public class FpPoint : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA66EC70
        public void GetZCoord(){} // RVA: 0xA66ED80
        public void Add(){} // RVA: 0xA66EE10
        public void Twice(){} // RVA: 0xA66FE30
        public void TwicePlus(){} // RVA: 0xA670C20
        public void ThreeTimes(){} // RVA: 0xA671290
        public void TimesPow2(){} // RVA: 0xA671830
        public void Two(){} // RVA: 0xA672290
        public void Three(){} // RVA: 0xA6722C0
        public void Four(){} // RVA: 0xA672310
        public void Eight(){} // RVA: 0xA672350
        public void DoubleProductFromSquares(){} // RVA: 0xA672390
        public void Negate(){} // RVA: 0xA672430
        public void CalculateJacobianModifiedW(){} // RVA: 0xA672620
        public void GetJacobianModifiedW(){} // RVA: 0xA6727C0
        public void TwiceJacobianModified(){} // RVA: 0xA672860
    }

    public class LongArray : Object
    {
        public object INTERLEAVE2_TABLE;
        public object INTERLEAVE3_TABLE;
        public object INTERLEAVE4_TABLE;
        public object INTERLEAVE5_TABLE;
        public object INTERLEAVE7_TABLE;
        public object ZEROES;
        public object BitLengths;
        public object m_ints;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA677410
        public void CopyTo(){} // RVA: 0xA677670
        public void IsOne(){} // RVA: 0xA6776B0
        public void IsZero(){} // RVA: 0xA677720
        public void GetUsedLength(){} // RVA: 0xA677780
        public void GetUsedLengthFrom(){} // RVA: 0xA677860
        public void Degree(){} // RVA: 0xA677930
        public void DegreeFrom(){} // RVA: 0xA6779E0
        public void BitLength(){} // RVA: 0xA677AA0
        public void ResizedInts(){} // RVA: 0xA677C30
        public void ToBigInteger(){} // RVA: 0xA677CF0
        public void ShiftUp(){} // RVA: 0xA678020
        public void AddOne(){} // RVA: 0xA678110
        public void AddShiftedByBitsSafe(){} // RVA: 0xA678300
        public void AddShiftedUp(){} // RVA: 0xA6784E0
        public void AddShiftedDown(){} // RVA: 0xA6785C0
        public void AddShiftedByWords(){} // RVA: 0xA678690
        public void Add(){} // RVA: 0xA678880
        public void AddBoth(){} // RVA: 0xA678950
        public void Distribute(){} // RVA: 0xA678A30
        public void get_Length(){} // RVA: 0x17F0080
        public void FlipWord(){} // RVA: 0xA678AE0
        public void TestBitZero(){} // RVA: 0xA678B70
        public void TestBit(){} // RVA: 0xA678BB0
        public void FlipBit(){} // RVA: 0xA678C00
        public void MultiplyWord(){} // RVA: 0xA678C40
        public void ModMultiplyLD(){} // RVA: 0xA678E50
        public void ModMultiply(){} // RVA: 0xA679830
        public void ModMultiplyAlt(){} // RVA: 0xA67A0F0
        public void ModReduce(){} // RVA: 0xA67A9C0
        public void Multiply(){} // RVA: 0xA67AB20
        public void Reduce(){} // RVA: 0xA67B3C0
        public void ReduceResult(){} // RVA: 0xA67B4F0
        public void ReduceInPlace(){} // RVA: 0xA67B5B0
        public void ReduceBitWise(){} // RVA: 0xA67BA00
        public void ReduceBit(){} // RVA: 0xA67BB00
        public void ReduceWordWise(){} // RVA: 0xA67BC70
        public void ReduceWord(){} // RVA: 0xA67BE30
        public void ReduceVectorWise(){} // RVA: 0xA67BFF0
        public void FlipVector(){} // RVA: 0xA67C430
        public void ModSquare(){} // RVA: 0xA67C600
        public void ModSquareN(){} // RVA: 0xA67C7E0
        public void Square(){} // RVA: 0xA67CA10
        public void SquareInPlace(){} // RVA: 0xA67CBB0
        public void Interleave(){} // RVA: 0xA67CC90
        public void Interleave3(){} // RVA: 0xA67D290
        public void Interleave3_21to63(){} // RVA: 0xA67D350
        public void Interleave5(){} // RVA: 0xA67D620
        public void Interleave3_13to65(){} // RVA: 0xA67D710
        public void Interleave7(){} // RVA: 0xA67D8B0
        public void Interleave2_n(){} // RVA: 0xA67DB90
        public void Interleave4_16to64(){} // RVA: 0xA67DE90
        public void Interleave2_32to64(){} // RVA: 0xA67DF20
        public void ModInverse(){} // RVA: 0xA67E010
        public void Equals(){} // RVA: 0xA67E5F0
        public void GetHashCode(){} // RVA: 0xA67E6B0
        public void Copy(){} // RVA: 0xA67E730
        public void ToString(){} // RVA: 0xA67E860
        public void .cctor(){} // RVA: 0xA67EAB0
    }

    public class ScaleXNegateYPointMap : Object
    {
        public object scale;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Map(){} // RVA: 0xA67EF00
    }

    public class ScaleXPointMap : Object
    {
        public object scale;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Map(){} // RVA: 0xA67EF40
    }

    public class ScaleYNegateXPointMap : Object
    {
        public object scale;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Map(){} // RVA: 0xA67EF80
    }

    public class ScaleYPointMap : Object
    {
        public object scale;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Map(){} // RVA: 0xA67EFC0
    }

    public class SimpleLookupTable : Object
    {
        public object points;

        // ── Methods ──
        public void Copy(){} // RVA: 0xA67F000
        public void .ctor(){} // RVA: 0xA67F180
        public void get_Size(){} // RVA: 0x17F0080
        public void Lookup(){} // RVA: 0x753C8F0
    }

}