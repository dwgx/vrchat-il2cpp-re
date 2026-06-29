// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC
// Classes: 27
// Methods: 368

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC
{
    public class AbstractF2mCurve : ECCurve
    {
        // ── Methods ──
        public void Inverse(){} // RVA: 0x7B17FA1B0
        public void BuildField(){} // RVA: 0x7B17FA250
        public void .ctor(){} // RVA: 0x7B17FA4C0
        public void IsValidFieldElement(){} // RVA: 0x7B17FA540
        public void CreatePoint(){} // RVA: 0x7B17FA5A0
        public void DecompressPoint(){} // RVA: 0x7B17FA760
        public void SolveQuadraticEquation(){} // RVA: 0x7B17FAA00
        public void GetSi(){} // RVA: 0x7B17FAE30
        public void get_IsKoblitz(){} // RVA: 0x7B17FAFE0
    }

    public class AbstractF2mFieldElement : ECFieldElement
    {
        // ── Methods ──
        public void HalfTrace(){} // RVA: 0x7B17FEF20
        public void get_HasFastTrace(){} // RVA: 0x7A80D7320
        public void Trace(){} // RVA: 0x7B17FF110
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class AbstractF2mPoint : ECPointBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B12B2560
        public void SatisfiesCurveEquation(){} // RVA: 0x7B1806E20
        public void SatisfiesOrder(){} // RVA: 0x7B1807390
        public void ScaleX(){} // RVA: 0x7B1807830
        public void ScaleXNegateY(){} // RVA: 0x7AE810010
        public void ScaleY(){} // RVA: 0x7B1807BC0
        public void ScaleYNegateX(){} // RVA: 0x7B1807D80
        public void Subtract(){} // RVA: 0x7B1802C50
        public void Tau(){} // RVA: 0x7B1807DA0
        public void TauPow(){} // RVA: 0x7B18080E0
    }

    public class AbstractFpCurve : ECCurve
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B17F9020
        public void IsValidFieldElement(){} // RVA: 0x7B17F9220
        public void DecompressPoint(){} // RVA: 0x7B17F92C0
    }

    public class AbstractFpFieldElement : ECFieldElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class AbstractFpPoint : ECPointBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B12B2560
        public void get_CompressionYTilde(){} // RVA: 0x7B1802830
        public void SatisfiesCurveEquation(){} // RVA: 0x7B1802870
        public void Subtract(){} // RVA: 0x7B1802C50
    }

    public class ECAlgorithms : Object
    {
        // ── Methods ──
        public void IsF2mCurve(){} // RVA: 0x7B17F2600
        public void IsF2mField(){} // RVA: 0x7B17F2720
        public void IsFpCurve(){} // RVA: 0x7B17F2820
        public void IsFpField(){} // RVA: 0x7B17F2890
        public void SumOfMultiplies(){} // RVA: 0x7B17F28F0
        public void SumOfTwoMultiplies(){} // RVA: 0x7B17F2D50
        public void ShamirsTrick(){} // RVA: 0x7B17F3230
        public void ImportPoint(){} // RVA: 0x7B17F33D0
        public void MontgomeryTrick(){} // RVA: 0x7B17F34C0
        public void ReferenceMultiply(){} // RVA: 0x7B17F38E0
        public void ValidatePoint(){} // RVA: 0x7B17F3A40
        public void CleanPoint(){} // RVA: 0x7B17F3AC0
        public void ImplCheckResult(){} // RVA: 0x7B17F3BB0
        public void ImplShamirsTrickJsf(){} // RVA: 0x7B17F3C30
        public void ImplShamirsTrickWNaf(){} // RVA: 0x7B17F49D0
        public void ImplSumOfMultiplies(){} // RVA: 0x7B17F5FB0
        public void ImplSumOfMultipliesGlv(){} // RVA: 0x7B17F5180
        public void ImplShamirsTrickFixedPoint(){} // RVA: 0x7B17F6370
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ECCurve : Object
    {
        // ── Methods ──
        public void GetAllCoordinateSystems(){} // RVA: 0x7B17F6830
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_FieldSize(){} // RVA: 0x7A7E00710
        public void FromBigInteger(){} // RVA: 0x7A7E00B20
        public void IsValidFieldElement(){} // RVA: 0x7A7E019D0
        public void Configure(){} // RVA: 0x7B17F68A0
        public void ValidatePoint(){} // RVA: 0x7B17F6AA0
        public void CreatePoint(){} // RVA: 0x7B17F6B40
        public void CloneCurve(){} // RVA: 0x7A7E00680
        public void CreateRawPoint(){} // RVA: 0x7A7E12BD0
        public void CreateDefaultMultiplier(){} // RVA: 0x7B17F6BD0
        public void SupportsCoordinateSystem(){} // RVA: 0x7A93206C0
        public void GetPreCompInfo(){} // RVA: 0x7B17F6DA0
        public void Precompute(){} // RVA: 0x7B17F70D0
        public void ImportPoint(){} // RVA: 0x7B17F7520
        public void NormalizeAll(){} // RVA: 0x7B17F76B0
        public void get_Infinity(){} // RVA: 0x7A7E00680
        public void get_Field(){} // RVA: 0x7A80F2570
        public void get_A(){} // RVA: 0x7A80DA7B0
        public void get_B(){} // RVA: 0x7A81052C0
        public void get_Order(){} // RVA: 0x7A8105330
        public void get_Cofactor(){} // RVA: 0x7A83F69F0
        public void get_CoordinateSystem(){} // RVA: 0x7A8D863F0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7B17F7AD0
        public void CheckPoint(){} // RVA: 0x7B17F7DD0
        public void CheckPoints(){} // RVA: 0x7B17F7EB0
        public void Equals(){} // RVA: 0x7B17F8260
        public void GetHashCode(){} // RVA: 0x7B17F8300
        public void DecompressPoint(){} // RVA: 0x7A7E0FAB0
        public void GetEndomorphism(){} // RVA: 0x7A8154D80
        public void GetMultiplier(){} // RVA: 0x7B17F8420
        public void DecodePoint(){} // RVA: 0x7B17F85A0
    }

    public class ECFieldElement : Object
    {
        // ── Methods ──
        public void ToBigInteger(){} // RVA: 0x7A7E00680
        public void get_FieldName(){} // RVA: 0x7A7E00680
        public void get_FieldSize(){} // RVA: 0x7A7E00710
        public void Add(){} // RVA: 0x7A7E00B20
        public void AddOne(){} // RVA: 0x7A7E00680
        public void Subtract(){} // RVA: 0x7A7E00B20
        public void Multiply(){} // RVA: 0x7A7E00B20
        public void Divide(){} // RVA: 0x7A7E00B20
        public void Negate(){} // RVA: 0x7A7E00680
        public void Square(){} // RVA: 0x7A7E00680
        public void Invert(){} // RVA: 0x7A7E00680
        public void Sqrt(){} // RVA: 0x7A7E00680
        public void get_BitLength(){} // RVA: 0x7B17FC330
        public void get_IsOne(){} // RVA: 0x7B17FC360
        public void get_IsZero(){} // RVA: 0x7B17FC390
        public void MultiplyMinusProduct(){} // RVA: 0x7B17FC3C0
        public void MultiplyPlusProduct(){} // RVA: 0x7B17FC440
        public void SquareMinusProduct(){} // RVA: 0x7B17FC4C0
        public void SquarePlusProduct(){} // RVA: 0x7B17FC540
        public void SquarePow(){} // RVA: 0x7B17FC5C0
        public void TestBitZero(){} // RVA: 0x7B17FC610
        public void Equals(){} // RVA: 0x7B17FC6F0
        public void GetHashCode(){} // RVA: 0x7ADAA1C80
        public void ToString(){} // RVA: 0x7B17FC780
        public void GetEncoded(){} // RVA: 0x7B17FC7C0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ECFieldElement[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ECLookupTable
    {
        // ── Methods ──
        public void get_Size(){} // RVA: 0x7A7E00710
        public void Lookup(){} // RVA: 0x7A7E00740
    }

    public class ECPoint : Object
    {
        // ── Methods ──
        public void GetInitialZCoords(){} // RVA: 0x7B18007C0
        public void .ctor(){} // RVA: 0x7B1800BD0
        public void SatisfiesCurveEquation(){} // RVA: 0x7A7E01900
        public void SatisfiesOrder(){} // RVA: 0x7B1800D30
        public void GetDetachedPoint(){} // RVA: 0x7B1800E70
        public void get_Curve(){} // RVA: 0x7A80F2570
        public void Detach(){} // RVA: 0x7A7E00680
        public void get_CurveCoordinateSystem(){} // RVA: 0x7B1800EB0
        public void get_AffineXCoord(){} // RVA: 0x7B1800EE0
        public void get_AffineYCoord(){} // RVA: 0x7B1800F20
        public void get_XCoord(){} // RVA: 0x7A80DA7B0
        public void get_YCoord(){} // RVA: 0x7A81052C0
        public void GetZCoord(){} // RVA: 0x7B1800F60
        public void GetZCoords(){} // RVA: 0x7B1800FA0
        public void get_RawXCoord(){} // RVA: 0x7A80DA7B0
        public void get_RawYCoord(){} // RVA: 0x7A81052C0
        public void get_RawZCoords(){} // RVA: 0x7A8105330
        public void CheckNormalized(){} // RVA: 0x7B1801030
        public void IsNormalized(){} // RVA: 0x7B18010B0
        public void Normalize(){} // RVA: 0x7B1801200
        public void CreateScaledPoint(){} // RVA: 0x7B1801350
        public void get_IsInfinity(){} // RVA: 0x7B1801410
        public void get_IsCompressed(){} // RVA: 0x7A80FD690
        public void IsValid(){} // RVA: 0x7B1801430
        public void IsValidPartial(){} // RVA: 0x7B1801440
        public void ImplIsValid(){} // RVA: 0x7B1801450
        public void ScaleX(){} // RVA: 0x7B1801600
        public void ScaleXNegateY(){} // RVA: 0x7B18016C0
        public void ScaleY(){} // RVA: 0x7B1801790
        public void ScaleYNegateX(){} // RVA: 0x7B1801850
        public void Equals(){} // RVA: 0x7B18019D0
        public void GetHashCode(){} // RVA: 0x7B1801D10
        public void ToString(){} // RVA: 0x7B1801E20
        public void GetEncoded(){} // RVA: 0x7A7E063A0
        public void get_CompressionYTilde(){} // RVA: 0x7A7E01900
        public void Add(){} // RVA: 0x7A7E00B20
        public void Subtract(){} // RVA: 0x7A7E00B20
        public void Negate(){} // RVA: 0x7A7E00680
        public void TimesPow2(){} // RVA: 0x7B1802090
        public void Twice(){} // RVA: 0x7A7E00680
        public void Multiply(){} // RVA: 0x7A7E00B20
        public void TwicePlus(){} // RVA: 0x7B1802140
        public void ThreeTimes(){} // RVA: 0x7B1802190
        public void .cctor(){} // RVA: 0x7B18021B0
    }

    public class ECPointBase : ECPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B18024C0
        public void GetEncoded(){} // RVA: 0x7B1802550
        public void Multiply(){} // RVA: 0x7B1802780
    }

    public class ECPointMap
    {
        // ── Methods ──
        public void Map(){} // RVA: 0x7A7E00B20
    }

    public class ECPoint[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class F2mCurve : AbstractF2mCurve
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B17FB550
        public void CloneCurve(){} // RVA: 0x7B17FB7D0
        public void SupportsCoordinateSystem(){} // RVA: 0x7B17FB8A0
        public void CreateDefaultMultiplier(){} // RVA: 0x7B17FB8B0
        public void get_FieldSize(){} // RVA: 0x7A87A7DA0
        public void FromBigInteger(){} // RVA: 0x7B17FB920
        public void CreateRawPoint(){} // RVA: 0x7B17FBAF0
        public void get_Infinity(){} // RVA: 0x7A8153390
        public void get_M(){} // RVA: 0x7A87A7DA0
        public void IsTrinomial(){} // RVA: 0x7B17FBB90
        public void get_K1(){} // RVA: 0x7A835E820
        public void get_K2(){} // RVA: 0x7A83562E0
        public void get_K3(){} // RVA: 0x7A8355900
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7B17FBBB0
    }

    public class F2mFieldElement : AbstractF2mFieldElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B17FF550
        public void get_BitLength(){} // RVA: 0x7B17FF630
        public void get_IsOne(){} // RVA: 0x7B17FF650
        public void get_IsZero(){} // RVA: 0x7B17FF6C0
        public void TestBitZero(){} // RVA: 0x7B17FF720
        public void ToBigInteger(){} // RVA: 0x7B17FF770
        public void get_FieldName(){} // RVA: 0x7B17FF790
        public void get_FieldSize(){} // RVA: 0x7A8668BC0
        public void CheckFieldElements(){} // RVA: 0x7B17FF7D0
        public void Add(){} // RVA: 0x7B17FFA20
        public void AddOne(){} // RVA: 0x7B17FFB20
        public void Subtract(){} // RVA: 0x7ACF03DA0
        public void Multiply(){} // RVA: 0x7B17FFBC0
        public void MultiplyMinusProduct(){} // RVA: 0x7B12EB7E0
        public void MultiplyPlusProduct(){} // RVA: 0x7B17FFCB0
        public void Divide(){} // RVA: 0x7B12EBA30
        public void Negate(){} // RVA: 0x7A97F8BA0
        public void Square(){} // RVA: 0x7B17FFEB0
        public void SquareMinusProduct(){} // RVA: 0x7B12EBB60
        public void SquarePlusProduct(){} // RVA: 0x7B17FFF50
        public void SquarePow(){} // RVA: 0x7B1800250
        public void Invert(){} // RVA: 0x7B1800310
        public void Sqrt(){} // RVA: 0x7B18003B0
        public void get_Representation(){} // RVA: 0x7A8124910
        public void get_M(){} // RVA: 0x7A8668BC0
        public void get_K1(){} // RVA: 0x7B1800440
        public void get_K2(){} // RVA: 0x7B1800470
        public void get_K3(){} // RVA: 0x7B18004B0
        public void Equals(){} // RVA: 0x7B18005A0
        public void GetHashCode(){} // RVA: 0x7B18006F0
    }

    public class F2mPoint : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B12B2560
        public void Detach(){} // RVA: 0x7B18085F0
        public void get_YCoord(){} // RVA: 0x7B1808710
        public void get_CompressionYTilde(){} // RVA: 0x7B1808860
        public void Add(){} // RVA: 0x7B1808970
        public void Twice(){} // RVA: 0x7B1809AF0
        public void TwicePlus(){} // RVA: 0x7B180A7D0
        public void Negate(){} // RVA: 0x7B180AF30
    }

    public class FpCurve : AbstractFpCurve
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B17F9830
        public void CloneCurve(){} // RVA: 0x7B17F9B20
        public void SupportsCoordinateSystem(){} // RVA: 0x7B17F9BE0
        public void get_Q(){} // RVA: 0x7A8178B90
        public void get_Infinity(){} // RVA: 0x7A8175DF0
        public void get_FieldSize(){} // RVA: 0x7B17F9BF0
        public void FromBigInteger(){} // RVA: 0x7B17F9C10
        public void CreateRawPoint(){} // RVA: 0x7B17F9D90
        public void ImportPoint(){} // RVA: 0x7B17F9E30
    }

    public class FpFieldElement : AbstractFpFieldElement
    {
        // ── Methods ──
        public void CalculateResidue(){} // RVA: 0x7B17FC820
        public void .ctor(){} // RVA: 0x7B17FC9D0
        public void ToBigInteger(){} // RVA: 0x7A81052C0
        public void get_FieldName(){} // RVA: 0x7B17FCAB0
        public void get_FieldSize(){} // RVA: 0x7B17FCAF0
        public void get_Q(){} // RVA: 0x7A80F2570
        public void Add(){} // RVA: 0x7B17FCB10
        public void AddOne(){} // RVA: 0x7B17FCBF0
        public void Subtract(){} // RVA: 0x7B17FCD20
        public void Multiply(){} // RVA: 0x7B17FCE00
        public void MultiplyMinusProduct(){} // RVA: 0x7B17FCEE0
        public void MultiplyPlusProduct(){} // RVA: 0x7B17FD050
        public void Divide(){} // RVA: 0x7B17FD240
        public void Negate(){} // RVA: 0x7B17FD340
        public void Square(){} // RVA: 0x7B17FD400
        public void SquareMinusProduct(){} // RVA: 0x7B17FD4B0
        public void SquarePlusProduct(){} // RVA: 0x7B17FD600
        public void Invert(){} // RVA: 0x7B17FD7C0
        public void Sqrt(){} // RVA: 0x7B17FD860
        public void CheckSqrt(){} // RVA: 0x7B17FDF80
        public void LucasSequence(){} // RVA: 0x7B17FDFF0
        public void ModAdd(){} // RVA: 0x7B17FE5F0
        public void ModDouble(){} // RVA: 0x7B17FE660
        public void ModHalf(){} // RVA: 0x7B17FE6D0
        public void ModHalfAbs(){} // RVA: 0x7B17FE740
        public void ModInverse(){} // RVA: 0x7B17FE7B0
        public void ModMult(){} // RVA: 0x7B17FE8B0
        public void ModReduce(){} // RVA: 0x7B17FE900
        public void ModSubtract(){} // RVA: 0x7B17FECE0
        public void Equals(){} // RVA: 0x7B17FEDE0
        public void GetHashCode(){} // RVA: 0x7B17FEEA0
    }

    public class FpPoint : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B12B2560
        public void Detach(){} // RVA: 0x7B1802E00
        public void GetZCoord(){} // RVA: 0x7B1802F10
        public void Add(){} // RVA: 0x7B1802FA0
        public void Twice(){} // RVA: 0x7B1803FC0
        public void TwicePlus(){} // RVA: 0x7B1804DB0
        public void ThreeTimes(){} // RVA: 0x7B1805420
        public void TimesPow2(){} // RVA: 0x7B18059C0
        public void Two(){} // RVA: 0x7B1806420
        public void Three(){} // RVA: 0x7B1806450
        public void Four(){} // RVA: 0x7B18064A0
        public void Eight(){} // RVA: 0x7B18064E0
        public void DoubleProductFromSquares(){} // RVA: 0x7B1806520
        public void Negate(){} // RVA: 0x7B18065C0
        public void CalculateJacobianModifiedW(){} // RVA: 0x7B18067B0
        public void GetJacobianModifiedW(){} // RVA: 0x7B1806950
        public void TwiceJacobianModified(){} // RVA: 0x7B18069F0
    }

    public class LongArray : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B180B5A0
        public void CopyTo(){} // RVA: 0x7B180B800
        public void IsOne(){} // RVA: 0x7B180B840
        public void IsZero(){} // RVA: 0x7B180B8B0
        public void GetUsedLength(){} // RVA: 0x7B180B910
        public void GetUsedLengthFrom(){} // RVA: 0x7B180B9F0
        public void Degree(){} // RVA: 0x7B180BAC0
        public void DegreeFrom(){} // RVA: 0x7B180BB70
        public void BitLength(){} // RVA: 0x7B180BC30
        public void ResizedInts(){} // RVA: 0x7B180BDC0
        public void ToBigInteger(){} // RVA: 0x7B180BE80
        public void ShiftUp(){} // RVA: 0x7B180C1B0
        public void AddOne(){} // RVA: 0x7B180C2A0
        public void AddShiftedByBitsSafe(){} // RVA: 0x7B180C490
        public void AddShiftedUp(){} // RVA: 0x7B180C670
        public void AddShiftedDown(){} // RVA: 0x7B180C750
        public void AddShiftedByWords(){} // RVA: 0x7B180C820
        public void Add(){} // RVA: 0x7B180CA10
        public void AddBoth(){} // RVA: 0x7B180CAE0
        public void Distribute(){} // RVA: 0x7B180CBC0
        public void get_Length(){} // RVA: 0x7A8D0A110
        public void FlipWord(){} // RVA: 0x7B180CC70
        public void TestBitZero(){} // RVA: 0x7B180CD00
        public void TestBit(){} // RVA: 0x7B180CD40
        public void FlipBit(){} // RVA: 0x7B180CD90
        public void MultiplyWord(){} // RVA: 0x7B180CDD0
        public void ModMultiplyLD(){} // RVA: 0x7B180CFE0
        public void ModMultiply(){} // RVA: 0x7B180D9C0
        public void ModMultiplyAlt(){} // RVA: 0x7B180E280
        public void ModReduce(){} // RVA: 0x7B180EB50
        public void Multiply(){} // RVA: 0x7B180ECB0
        public void Reduce(){} // RVA: 0x7B180F550
        public void ReduceResult(){} // RVA: 0x7B180F680
        public void ReduceInPlace(){} // RVA: 0x7B180F740
        public void ReduceBitWise(){} // RVA: 0x7B180FB90
        public void ReduceBit(){} // RVA: 0x7B180FC90
        public void ReduceWordWise(){} // RVA: 0x7B180FE00
        public void ReduceWord(){} // RVA: 0x7B180FFC0
        public void ReduceVectorWise(){} // RVA: 0x7B1810180
        public void FlipVector(){} // RVA: 0x7B18105C0
        public void ModSquare(){} // RVA: 0x7B1810790
        public void ModSquareN(){} // RVA: 0x7B1810970
        public void Square(){} // RVA: 0x7B1810BA0
        public void SquareInPlace(){} // RVA: 0x7B1810D40
        public void Interleave(){} // RVA: 0x7B1810E20
        public void Interleave3(){} // RVA: 0x7B1811420
        public void Interleave3_21to63(){} // RVA: 0x7B18114E0
        public void Interleave5(){} // RVA: 0x7B18117B0
        public void Interleave3_13to65(){} // RVA: 0x7B18118A0
        public void Interleave7(){} // RVA: 0x7B1811A40
        public void Interleave2_n(){} // RVA: 0x7B1811D20
        public void Interleave4_16to64(){} // RVA: 0x7B1812020
        public void Interleave2_32to64(){} // RVA: 0x7B18120B0
        public void ModInverse(){} // RVA: 0x7B18121A0
        public void Equals(){} // RVA: 0x7B1812780
        public void GetHashCode(){} // RVA: 0x7B1812840
        public void Copy(){} // RVA: 0x7B18128C0
        public void ToString(){} // RVA: 0x7B18129F0
        public void .cctor(){} // RVA: 0x7B1812C40
    }

    public class ScaleXNegateYPointMap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Map(){} // RVA: 0x7B1813090
    }

    public class ScaleXPointMap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Map(){} // RVA: 0x7B18130D0
    }

    public class ScaleYNegateXPointMap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Map(){} // RVA: 0x7B1813110
    }

    public class ScaleYPointMap : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Map(){} // RVA: 0x7B1813150
    }

    public class SimpleLookupTable : Object
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x7B1813190
        public void .ctor(){} // RVA: 0x7B1813310
        public void get_Size(){} // RVA: 0x7A8D0A110
        public void Lookup(){} // RVA: 0x7AE8C8950
    }

}