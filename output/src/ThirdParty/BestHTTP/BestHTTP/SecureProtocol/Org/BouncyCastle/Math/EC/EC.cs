// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC
// Classes: 25
// Methods: 385

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC
{
    public class AbstractF2mCurve : ECCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger[] IsKoblitz; // 0x50

        // ── Methods ──
        public void Inverse(){} // RVA: 0x7FFACBFB7440
        public void BuildField(){} // RVA: 0x7FFACBFB74E0
        public void .ctor(){} // RVA: 0x7FFACBFB7750
        public void IsValidFieldElement(){} // RVA: 0x7FFACBFB77D0
        public void CreatePoint(){} // RVA: 0x7FFACBFB7830
        public void DecompressPoint(){} // RVA: 0x7FFACBFB79F0
        public void SolveQuadraticEquation(){} // RVA: 0x7FFACBFB7C90
        public void GetSi(){} // RVA: 0x7FFACBFB80C0
        public void get_IsKoblitz(){} // RVA: 0x7FFACBFB82A0
    }

    public class AbstractF2mFieldElement : ECFieldElement
    {
        public object HasFastTrace;

        // ── Methods ──
        public void HalfTrace(){} // RVA: 0x7FFACBFBC160
        public void get_HasFastTrace(){} // RVA: 0x7FFAC2F21320
        public void Trace(){} // RVA: 0x7FFACBFBC360
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AbstractF2mPoint : ECPointBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x2
        public void SatisfiesCurveEquation(){} // RVA: 0x7FFACBFC40A0
        public void SatisfiesOrder(){} // RVA: 0x7FFACBFC4610
        public void ScaleX(){} // RVA: 0x7FFACBFC4AB0
        public void ScaleXNegateY(){} // RVA: 0x7FFAC91B6940
        public void ScaleY(){} // RVA: 0x7FFACBFC4E40
        public void ScaleYNegateX(){} // RVA: 0x7FFACBFC5000
        public void Subtract(){} // RVA: 0x7FFACBFBFEE0
        public void Tau(){} // RVA: 0x7FFACBFC5020
        public void TauPow(){} // RVA: 0x7FFACBFC5360
    }

    public class AbstractFpCurve : ECCurve
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFB62B0
        public void IsValidFieldElement(){} // RVA: 0x7FFACBFB64B0
        public void DecompressPoint(){} // RVA: 0x7FFACBFB6550
    }

    public class AbstractFpFieldElement : ECFieldElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AbstractFpPoint : ECPointBase
    {
        public object CompressionYTilde;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x2
        public void get_CompressionYTilde(){} // RVA: 0x7FFACBFBFAD0
        public void SatisfiesCurveEquation(){} // RVA: 0x7FFACBFBFB10
        public void Subtract(){} // RVA: 0x7FFACBFBFEE0
    }

    public class ECAlgorithms : Object
    {
        // ── Methods ──
        public void IsF2mCurve(){} // RVA: 0x7FFACBFAFB40
        public void IsF2mField(){} // RVA: 0x7FFACBFAFC60
        public void IsFpCurve(){} // RVA: 0x7FFACBFAFD60
        public void IsFpField(){} // RVA: 0x7FFACBFAFDD0
        public void SumOfMultiplies(){} // RVA: 0x7FFACBFAFE30
        public void SumOfTwoMultiplies(){} // RVA: 0x7FFACBFB0270
        public void ShamirsTrick(){} // RVA: 0x7FFACBFB0750
        public void ImportPoint(){} // RVA: 0x7FFACBFB08F0
        public void MontgomeryTrick(){} // RVA: 0x7FFACBFB09E0 | overloaded x2
        public void ReferenceMultiply(){} // RVA: 0x7FFACBFB0DC0
        public void ValidatePoint(){} // RVA: 0x7FFACBFB0F20
        public void CleanPoint(){} // RVA: 0x7FFACBFB0FA0
        public void ImplCheckResult(){} // RVA: 0x7FFACBFB1090
        public void ImplShamirsTrickJsf(){} // RVA: 0x7FFACBFB1110
        public void ImplShamirsTrickWNaf(){} // RVA: 0x7FFACBFB1EA0 | overloaded x3
        public void ImplSumOfMultiplies(){} // RVA: 0x7FFACBFB32C0 | overloaded x3
        public void ImplSumOfMultipliesGlv(){} // RVA: 0x7FFACBFB2570
        public void ImplShamirsTrickFixedPoint(){} // RVA: 0x7FFACBFB3620
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ECCurve : Object
    {
        public int FieldSize;
        public int Infinity;
        public int Field;
        public int A;
        public int B;
        public int Order;
        public int Cofactor;
        public int CoordinateSystem;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Field.IFiniteField m_field; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECFieldElement m_a; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECFieldElement m_b; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_order; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger m_cofactor; // 0x30
        public int m_coord; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Endo.ECEndomorphism m_endomorphism; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier m_multiplier; // 0x48

        // ── Methods ──
        public void GetAllCoordinateSystems(){} // RVA: 0x7FFACBFB3AE0
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_FieldSize(){} // RVA: 0x7FFAC2C59960
        public void FromBigInteger(){} // RVA: 0x7FFAC2C58F40
        public void IsValidFieldElement(){} // RVA: 0x7FFAC2C59F60
        public void Configure(){} // RVA: 0x7FFACBFB3B50
        public void ValidatePoint(){} // RVA: 0x7FFACBFB3D50 | overloaded x2
        public void CreatePoint(){} // RVA: 0x7FFACBFB3DF0 | overloaded x2
        public void CloneCurve(){} // RVA: 0x7FFAC2C58E90
        public void CreateRawPoint(){} // overloaded x2
        public void CreateDefaultMultiplier(){} // RVA: 0x7FFACBFB3E80
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFAC36AA740
        public void GetPreCompInfo(){} // RVA: 0x7FFACBFB4050
        public void Precompute(){} // RVA: 0x7FFACBFB43D0
        public void ImportPoint(){} // RVA: 0x7FFACBFB4870
        public void NormalizeAll(){} // RVA: 0x7FFACBFB4A00 | overloaded x2
        public void get_Infinity(){} // RVA: 0x7FFAC2C58E90
        public void get_Field(){} // RVA: 0x7FFAC2F3C380
        public void get_A(){} // RVA: 0x7FFAC2F247C0
        public void get_B(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Order(){} // RVA: 0x7FFAC2F4F130
        public void get_Cofactor(){} // RVA: 0x7FFAC31D95E0
        public void get_CoordinateSystem(){} // RVA: 0x7FFAC358A870
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBFB4DA0
        public void CheckPoint(){} // RVA: 0x7FFACBFB5080
        public void CheckPoints(){} // RVA: 0x7FFACBFB5160 | overloaded x2
        public void Equals(){} // RVA: 0x7FFACBFB5500 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBFB55A0
        public void DecompressPoint(){} // RVA: 0x7FFAC2C68F90
        public void GetEndomorphism(){} // RVA: 0x7FFAC2F9E740
        public void GetMultiplier(){} // RVA: 0x7FFACBFB56C0
        public void DecodePoint(){} // RVA: 0x7FFACBFB5870
    }

    public class ECFieldElement : Object
    {
        public object FieldName;
        public object FieldSize;
        public object BitLength;
        public object IsOne;
        public object IsZero;

        // ── Methods ──
        public void ToBigInteger(){} // RVA: 0x7FFAC2C58E90
        public void get_FieldName(){} // RVA: 0x7FFAC2C58E90
        public void get_FieldSize(){} // RVA: 0x7FFAC2C59960
        public void Add(){} // RVA: 0x7FFAC2C58F40
        public void AddOne(){} // RVA: 0x7FFAC2C58E90
        public void Subtract(){} // RVA: 0x7FFAC2C58F40
        public void Multiply(){} // RVA: 0x7FFAC2C58F40
        public void Divide(){} // RVA: 0x7FFAC2C58F40
        public void Negate(){} // RVA: 0x7FFAC2C58E90
        public void Square(){} // RVA: 0x7FFAC2C58E90
        public void Invert(){} // RVA: 0x7FFAC2C58E90
        public void Sqrt(){} // RVA: 0x7FFAC2C58E90
        public void get_BitLength(){} // RVA: 0x7FFACBFB9550
        public void get_IsOne(){} // RVA: 0x7FFACBFB9580
        public void get_IsZero(){} // RVA: 0x7FFACBFB95B0
        public void MultiplyMinusProduct(){} // RVA: 0x7FFACBFB95E0
        public void MultiplyPlusProduct(){} // RVA: 0x7FFACBFB9660
        public void SquareMinusProduct(){} // RVA: 0x7FFACBFB96E0
        public void SquarePlusProduct(){} // RVA: 0x7FFACBFB9760
        public void SquarePow(){} // RVA: 0x7FFACBFB97E0
        public void TestBitZero(){} // RVA: 0x7FFACBFB9830
        public void Equals(){} // RVA: 0x7FFACBFB9910 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC844B1F0
        public void ToString(){} // RVA: 0x7FFACBFB99A0
        public void GetEncoded(){} // RVA: 0x7FFACBFB99E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ECLookupTable
    {
        public object Size;

        // ── Methods ──
        public void get_Size(){} // RVA: 0x7FFAC2C59960
        public void Lookup(){} // RVA: 0x7FFAC2C67DE0
    }

    public class ECPoint : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECFieldElement[] Curve;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECCurve CurveCoordinateSystem; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECFieldElement AffineXCoord; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECFieldElement AffineYCoord; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECFieldElement[] XCoord; // 0x28
        public bool YCoord; // 0x30
        public System.Collections.IDictionary RawXCoord; // 0x38

        // ── Methods ──
        public void GetInitialZCoords(){} // RVA: 0x7FFACBFBDA60
        public void .ctor(){} // RVA: 0x7FFACBFBDE80 | overloaded x2
        public void SatisfiesCurveEquation(){} // RVA: 0x7FFAC2C59D00
        public void SatisfiesOrder(){} // RVA: 0x7FFACBFBDFE0
        public void GetDetachedPoint(){} // RVA: 0x7FFACBFBE120
        public void get_Curve(){} // RVA: 0x7FFAC2F3C380
        public void Detach(){} // RVA: 0x7FFAC2C58E90
        public void get_CurveCoordinateSystem(){} // RVA: 0x7FFACBFBE160
        public void get_AffineXCoord(){} // RVA: 0x7FFACBFBE190
        public void get_AffineYCoord(){} // RVA: 0x7FFACBFBE1D0
        public void get_XCoord(){} // RVA: 0x7FFAC2F247C0
        public void get_YCoord(){} // RVA: 0x7FFAC2F4F0C0
        public void GetZCoord(){} // RVA: 0x7FFACBFBE210
        public void GetZCoords(){} // RVA: 0x7FFACBFBE250
        public void get_RawXCoord(){} // RVA: 0x7FFAC2F247C0
        public void get_RawYCoord(){} // RVA: 0x7FFAC2F4F0C0
        public void get_RawZCoords(){} // RVA: 0x7FFAC2F4F130
        public void CheckNormalized(){} // RVA: 0x7FFACBFBE2E0
        public void IsNormalized(){} // RVA: 0x7FFACBFBE360
        public void Normalize(){} // RVA: 0x7FFACBFBE4B0 | overloaded x2
        public void CreateScaledPoint(){} // RVA: 0x7FFACBFBE600
        public void get_IsInfinity(){} // RVA: 0x7FFACBFBE6C0
        public void get_IsCompressed(){} // RVA: 0x7FFAC2F47450
        public void IsValid(){} // RVA: 0x7FFACBFBE6E0
        public void IsValidPartial(){} // RVA: 0x7FFACBFBE6F0
        public void ImplIsValid(){} // RVA: 0x7FFACBFBE700
        public void ScaleX(){} // RVA: 0x7FFACBFBE8A0
        public void ScaleXNegateY(){} // RVA: 0x7FFACBFBE960
        public void ScaleY(){} // RVA: 0x7FFACBFBEA30
        public void ScaleYNegateX(){} // RVA: 0x7FFACBFBEAF0
        public void Equals(){} // RVA: 0x7FFACBFBEC70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBFBEFA0
        public void ToString(){} // RVA: 0x7FFACBFBF0B0
        public void GetEncoded(){} // RVA: 0x7FFACBFBF2F0 | overloaded x2
        public void get_CompressionYTilde(){} // RVA: 0x7FFAC2C59D00
        public void Add(){} // RVA: 0x7FFAC2C58F40
        public void Subtract(){} // RVA: 0x7FFAC2C58F40
        public void Negate(){} // RVA: 0x7FFAC2C58E90
        public void TimesPow2(){} // RVA: 0x7FFACBFBF310
        public void Twice(){} // RVA: 0x7FFAC2C58E90
        public void Multiply(){} // RVA: 0x7FFAC2C58F40
        public void TwicePlus(){} // RVA: 0x7FFACBFBF3C0
        public void ThreeTimes(){} // RVA: 0x7FFACBFBF410
        public void .cctor(){} // RVA: 0x7FFACBFBF430
    }

    public class ECPointBase : ECPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFBF760 | overloaded x2
        public void GetEncoded(){} // RVA: 0x7FFACBFBF7F0
        public void Multiply(){} // RVA: 0x7FFACBFBFA20
    }

    public class ECPointMap
    {
        // ── Methods ──
        public void Map(){} // RVA: 0x7FFAC2C58F40
    }

    public class F2mCurve : AbstractF2mCurve
    {
        public int FieldSize;
        public int Infinity; // 0x58
        public int M; // 0x5C
        public int K1; // 0x60
        public int K2; // 0x64
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.F2mPoint K3; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFB8810 | overloaded x5
        public void CloneCurve(){} // RVA: 0x7FFACBFB8A90
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBFB8B60
        public void CreateDefaultMultiplier(){} // RVA: 0x7FFACBFB8B70
        public void get_FieldSize(){} // RVA: 0x7FFAC362EA40
        public void FromBigInteger(){} // RVA: 0x7FFACBFB8BE0
        public void CreateRawPoint(){} // RVA: 0x7FFACBFB8DB0 | overloaded x2
        public void get_Infinity(){} // RVA: 0x7FFAC2F9CD50
        public void get_M(){} // RVA: 0x7FFAC362EA40
        public void IsTrinomial(){} // RVA: 0x7FFACBFB8E50
        public void get_K1(){} // RVA: 0x7FFAC313CBA0
        public void get_K2(){} // RVA: 0x7FFAC3138C20
        public void get_K3(){} // RVA: 0x7FFAC3138CA0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBFB8E70
    }

    public class F2mFieldElement : AbstractF2mFieldElement
    {
        public int BitLength;
        public int IsOne;
        public int IsZero;
        public int FieldName; // 0x10
        public int FieldSize; // 0x14
        public int[] Representation; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.LongArray M; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFBC7B0 | overloaded x3
        public void get_BitLength(){} // RVA: 0x7FFACBFBC890
        public void get_IsOne(){} // RVA: 0x7FFACBFBC8B0
        public void get_IsZero(){} // RVA: 0x7FFACBFBC920
        public void TestBitZero(){} // RVA: 0x7FFACBFBC980
        public void ToBigInteger(){} // RVA: 0x7FFACBFBC9D0
        public void get_FieldName(){} // RVA: 0x7FFACBFBC9F0
        public void get_FieldSize(){} // RVA: 0x7FFAC33D5A20
        public void CheckFieldElements(){} // RVA: 0x7FFACBFBCA30
        public void Add(){} // RVA: 0x7FFACBFBCC80
        public void AddOne(){} // RVA: 0x7FFACBFBCD80
        public void Subtract(){} // RVA: 0x7FFAC77C53C0
        public void Multiply(){} // RVA: 0x7FFACBFBCE20
        public void MultiplyMinusProduct(){} // RVA: 0x7FFACBABF350
        public void MultiplyPlusProduct(){} // RVA: 0x7FFACBFBCF10
        public void Divide(){} // RVA: 0x7FFACBABF5A0
        public void Negate(){} // RVA: 0x7FFAC44F81E0
        public void Square(){} // RVA: 0x7FFACBFBD120
        public void SquareMinusProduct(){} // RVA: 0x7FFACBABF6D0
        public void SquarePlusProduct(){} // RVA: 0x7FFACBFBD1C0
        public void SquarePow(){} // RVA: 0x7FFACBFBD4C0
        public void Invert(){} // RVA: 0x7FFACBFBD580
        public void Sqrt(){} // RVA: 0x7FFACBFBD620
        public void get_Representation(){} // RVA: 0x7FFAC2F6E5C0
        public void get_M(){} // RVA: 0x7FFAC33D5A20
        public void get_K1(){} // RVA: 0x7FFACBFBD6E0
        public void get_K2(){} // RVA: 0x7FFACBFBD710
        public void get_K3(){} // RVA: 0x7FFACBFBD750
        public void Equals(){} // RVA: 0x7FFACBFBD850 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBFBD9A0
    }

    public class F2mPoint : AbstractF2mPoint
    {
        public object YCoord;
        public object CompressionYTilde;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBFC5870
        public void get_YCoord(){} // RVA: 0x7FFACBFC5990
        public void get_CompressionYTilde(){} // RVA: 0x7FFACBFC5AE0
        public void Add(){} // RVA: 0x7FFACBFC5BF0
        public void Twice(){} // RVA: 0x7FFACBFC6D70
        public void TwicePlus(){} // RVA: 0x7FFACBFC7A50
        public void Negate(){} // RVA: 0x7FFACBFC81A0
    }

    public class FpCurve : AbstractFpCurve
    {
        public int Q;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Infinity; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger FieldSize; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.FpPoint m_infinity; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFB6AC0 | overloaded x4
        public void CloneCurve(){} // RVA: 0x7FFACBFB6DB0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBFB6E70
        public void get_Q(){} // RVA: 0x7FFAC2FC20E0
        public void get_Infinity(){} // RVA: 0x7FFAC2FBF370
        public void get_FieldSize(){} // RVA: 0x7FFACBFB6E80
        public void FromBigInteger(){} // RVA: 0x7FFACBFB6EA0
        public void CreateRawPoint(){} // RVA: 0x7FFACBFB7020 | overloaded x2
        public void ImportPoint(){} // RVA: 0x7FFACBFB70C0
    }

    public class FpFieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger FieldName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger FieldSize; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q; // 0x20

        // ── Methods ──
        public void CalculateResidue(){} // RVA: 0x7FFACBFB9A40
        public void .ctor(){} // RVA: 0x7FFACBFB9BF0 | overloaded x2
        public void ToBigInteger(){} // RVA: 0x7FFAC2F4F0C0
        public void get_FieldName(){} // RVA: 0x7FFACBFB9CD0
        public void get_FieldSize(){} // RVA: 0x7FFACBFB9D10
        public void get_Q(){} // RVA: 0x7FFAC2F3C380
        public void Add(){} // RVA: 0x7FFACBFB9D30
        public void AddOne(){} // RVA: 0x7FFACBFB9E10
        public void Subtract(){} // RVA: 0x7FFACBFB9F40
        public void Multiply(){} // RVA: 0x7FFACBFBA020
        public void MultiplyMinusProduct(){} // RVA: 0x7FFACBFBA100
        public void MultiplyPlusProduct(){} // RVA: 0x7FFACBFBA270
        public void Divide(){} // RVA: 0x7FFACBFBA460
        public void Negate(){} // RVA: 0x7FFACBFBA560
        public void Square(){} // RVA: 0x7FFACBFBA620
        public void SquareMinusProduct(){} // RVA: 0x7FFACBFBA6D0
        public void SquarePlusProduct(){} // RVA: 0x7FFACBFBA820
        public void Invert(){} // RVA: 0x7FFACBFBA9E0
        public void Sqrt(){} // RVA: 0x7FFACBFBAA80
        public void CheckSqrt(){} // RVA: 0x7FFACBFBB1B0
        public void LucasSequence(){} // RVA: 0x7FFACBFBB220
        public void ModAdd(){} // RVA: 0x7FFACBFBB820
        public void ModDouble(){} // RVA: 0x7FFACBFBB890
        public void ModHalf(){} // RVA: 0x7FFACBFBB900
        public void ModHalfAbs(){} // RVA: 0x7FFACBFBB970
        public void ModInverse(){} // RVA: 0x7FFACBFBB9E0
        public void ModMult(){} // RVA: 0x7FFACBFBBAE0
        public void ModReduce(){} // RVA: 0x7FFACBFBBB30
        public void ModSubtract(){} // RVA: 0x7FFACBFBBF10
        public void Equals(){} // RVA: 0x7FFACBFBC020 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBFBC0E0
    }

    public class FpPoint : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBFC0090
        public void GetZCoord(){} // RVA: 0x7FFACBFC01A0
        public void Add(){} // RVA: 0x7FFACBFC0230
        public void Twice(){} // RVA: 0x7FFACBFC1250
        public void TwicePlus(){} // RVA: 0x7FFACBFC2050
        public void ThreeTimes(){} // RVA: 0x7FFACBFC26C0
        public void TimesPow2(){} // RVA: 0x7FFACBFC2C60
        public void Two(){} // RVA: 0x7FFACBFC36A0
        public void Three(){} // RVA: 0x7FFACBFC36D0
        public void Four(){} // RVA: 0x7FFACBFC3720
        public void Eight(){} // RVA: 0x7FFACBFC3760
        public void DoubleProductFromSquares(){} // RVA: 0x7FFACBFC37A0
        public void Negate(){} // RVA: 0x7FFACBFC3840
        public void CalculateJacobianModifiedW(){} // RVA: 0x7FFACBFC3A30
        public void GetJacobianModifiedW(){} // RVA: 0x7FFACBFC3BD0
        public void TwiceJacobianModified(){} // RVA: 0x7FFACBFC3C70
    }

    public class LongArray : Object
    {
        public ushort[] Length;
        public int[] INTERLEAVE3_TABLE; // 0x8
        public int[] INTERLEAVE4_TABLE; // 0x10
        public int[] INTERLEAVE5_TABLE; // 0x18
        public long[] INTERLEAVE7_TABLE; // 0x20
        public string ZEROES;
        public byte[] BitLengths; // 0x28
        public long[] m_ints; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBFC8820 | overloaded x4
        public void CopyTo(){} // RVA: 0x7FFACBFC8A60
        public void IsOne(){} // RVA: 0x7FFACBFC8AA0
        public void IsZero(){} // RVA: 0x7FFACBFC8B00
        public void GetUsedLength(){} // RVA: 0x7FFACBFC8B50
        public void GetUsedLengthFrom(){} // RVA: 0x7FFACBFC8C30
        public void Degree(){} // RVA: 0x7FFACBFC8D10
        public void DegreeFrom(){} // RVA: 0x7FFACBFC8DC0
        public void BitLength(){} // RVA: 0x7FFACBFC8E80
        public void ResizedInts(){} // RVA: 0x7FFACBFC9030
        public void ToBigInteger(){} // RVA: 0x7FFACBFC90F0
        public void ShiftUp(){} // RVA: 0x7FFACBFC93F0 | overloaded x2
        public void AddOne(){} // RVA: 0x7FFACBFC94C0
        public void AddShiftedByBitsSafe(){} // RVA: 0x7FFACBFC96B0
        public void AddShiftedUp(){} // RVA: 0x7FFACBFC9860
        public void AddShiftedDown(){} // RVA: 0x7FFACBFC9920
        public void AddShiftedByWords(){} // RVA: 0x7FFACBFC99E0
        public void Add(){} // RVA: 0x7FFACBFC9BA0 | overloaded x2
        public void AddBoth(){} // RVA: 0x7FFACBFC9C50
        public void Distribute(){} // RVA: 0x7FFACBFC9D00
        public void get_Length(){} // RVA: 0x7FFAC3510620
        public void FlipWord(){} // RVA: 0x7FFACBFC9DA0
        public void TestBitZero(){} // RVA: 0x7FFACBFC9E30
        public void TestBit(){} // RVA: 0x7FFACBFC9E70
        public void FlipBit(){} // RVA: 0x7FFACBFC9EC0
        public void MultiplyWord(){} // RVA: 0x7FFACBFC9F00
        public void ModMultiplyLD(){} // RVA: 0x7FFACBFCA0A0
        public void ModMultiply(){} // RVA: 0x7FFACBFCA960
        public void ModMultiplyAlt(){} // RVA: 0x7FFACBFCB0F0
        public void ModReduce(){} // RVA: 0x7FFACBFCB8C0
        public void Multiply(){} // RVA: 0x7FFACBFCBA20
        public void Reduce(){} // RVA: 0x7FFACBFCC160
        public void ReduceResult(){} // RVA: 0x7FFACBFCC290
        public void ReduceInPlace(){} // RVA: 0x7FFACBFCC350
        public void ReduceBitWise(){} // RVA: 0x7FFACBFCC760
        public void ReduceBit(){} // RVA: 0x7FFACBFCC860
        public void ReduceWordWise(){} // RVA: 0x7FFACBFCC9C0
        public void ReduceWord(){} // RVA: 0x7FFACBFCCB50
        public void ReduceVectorWise(){} // RVA: 0x7FFACBFCCD00
        public void FlipVector(){} // RVA: 0x7FFACBFCD070
        public void ModSquare(){} // RVA: 0x7FFACBFCD210
        public void ModSquareN(){} // RVA: 0x7FFACBFCD3F0
        public void Square(){} // RVA: 0x7FFACBFCD610
        public void SquareInPlace(){} // RVA: 0x7FFACBFCD7A0
        public void Interleave(){} // RVA: 0x7FFACBFCD870
        public void Interleave3(){} // RVA: 0x7FFACBFCDF20 | overloaded x2
        public void Interleave3_21to63(){} // RVA: 0x7FFACBFCDFE0
        public void Interleave5(){} // RVA: 0x7FFACBFCE270 | overloaded x2
        public void Interleave3_13to65(){} // RVA: 0x7FFACBFCE360
        public void Interleave7(){} // RVA: 0x7FFACBFCE4E0 | overloaded x2
        public void Interleave2_n(){} // RVA: 0x7FFACBFCE750 | overloaded x2
        public void Interleave4_16to64(){} // RVA: 0x7FFACBFCEA40
        public void Interleave2_32to64(){} // RVA: 0x7FFACBFCEAD0
        public void ModInverse(){} // RVA: 0x7FFACBFCEBB0
        public void Equals(){} // RVA: 0x7FFACBFCF1A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBFCF250
        public void Copy(){} // RVA: 0x7FFACBFCF2C0
        public void ToString(){} // RVA: 0x7FFACBFCF3F0
        public void .cctor(){} // RVA: 0x7FFACBFCF630
    }

    public class ScaleXNegateYPointMap : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECFieldElement scale; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Map(){} // RVA: 0x7FFACBFCFA80
    }

    public class ScaleXPointMap : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECFieldElement scale; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Map(){} // RVA: 0x7FFACBFCFAC0
    }

    public class ScaleYNegateXPointMap : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECFieldElement scale; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Map(){} // RVA: 0x7FFACBFCFB00
    }

    public class ScaleYPointMap : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECFieldElement scale; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Map(){} // RVA: 0x7FFACBFCFB40
    }

    public class SimpleLookupTable : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint[] Size; // 0x10

        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFACBFCFB80
        public void .ctor(){} // RVA: 0x7FFACBFCFCE0
        public void get_Size(){} // RVA: 0x7FFAC3510620
        public void Lookup(){} // RVA: 0x7FFAC926F060
    }

}