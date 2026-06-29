// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Djb
// Classes: 4
// Methods: 61

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Djb
{
    public class Curve25519 : AbstractFpCurve
    {
        public object q;
        public object Curve25519_DEFAULT_COORDS;
        public object CURVE25519_FE_INTS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA19FBD0
        public void CloneCurve(){} // RVA: 0xA1A0020
        public void SupportsCoordinateSystem(){} // RVA: 0xA1A0070
        public void get_Q(){} // RVA: 0xA1A0080
        public void get_Infinity(){} // RVA: 0xBE58B0
        public void get_FieldSize(){} // RVA: 0xA1A00E0
        public void FromBigInteger(){} // RVA: 0xA1A0150
        public void CreateRawPoint(){} // RVA: 0xA1A02A0
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA1A0340
        public void .cctor(){} // RVA: 0xA1A05D0
    }

    public class Curve25519Field : Object
    {
        public object P;
        public object P7;
        public object PExt;
        public object PInv;

        // ── Methods ──
        public void Add(){} // RVA: 0xA1A0940
        public void AddExt(){} // RVA: 0xA1A0AA0
        public void AddOne(){} // RVA: 0xA1A0C00
        public void FromBigInteger(){} // RVA: 0xA1A0DC0
        public void Half(){} // RVA: 0xA1A0EC0
        public void Multiply(){} // RVA: 0xA1A0FE0
        public void MultiplyAddToExt(){} // RVA: 0xA1A10A0
        public void Negate(){} // RVA: 0xA1A1190
        public void Reduce(){} // RVA: 0xA1A12C0
        public void Reduce27(){} // RVA: 0xA1A1510
        public void Square(){} // RVA: 0xA1A16F0
        public void SquareN(){} // RVA: 0xA1A17A0
        public void Subtract(){} // RVA: 0xA1A18A0
        public void SubtractExt(){} // RVA: 0xA1A1990
        public void Twice(){} // RVA: 0xA1A1A70
        public void AddPTo(){} // RVA: 0xA1A1C10
        public void AddPExtTo(){} // RVA: 0xA1A1CA0
        public void SubPFrom(){} // RVA: 0xA1A1E40
        public void SubPExtFrom(){} // RVA: 0xA1A1ED0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA1A2080
    }

    public class Curve25519FieldElement : AbstractFpFieldElement
    {
        public object Q;
        public object PRECOMP_POW2;
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsZero(){} // RVA: 0xA1428B0
        public void get_IsOne(){} // RVA: 0xA142910
        public void TestBitZero(){} // RVA: 0xA11CA40
        public void ToBigInteger(){} // RVA: 0xA142970
        public void get_FieldName(){} // RVA: 0xA1A2440
        public void get_FieldSize(){} // RVA: 0xA1A2480
        public void Add(){} // RVA: 0xA1A24F0
        public void AddOne(){} // RVA: 0xA1A2780
        public void Subtract(){} // RVA: 0xA1A2880
        public void Multiply(){} // RVA: 0xA1A29F0
        public void Divide(){} // RVA: 0xA1A2B60
        public void Negate(){} // RVA: 0xA1A2D20
        public void Square(){} // RVA: 0xA1A2E20
        public void Invert(){} // RVA: 0xA1A2F20
        public void Sqrt(){} // RVA: 0xA1A3070
        public void Equals(){} // RVA: 0xA143C30
        public void GetHashCode(){} // RVA: 0xA1A3600
        public void .cctor(){} // RVA: 0xA1A3700
    }

    public class Curve25519Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA1A39E0
        public void GetZCoord(){} // RVA: 0xA1A3AF0
        public void Add(){} // RVA: 0xA1A3B50
        public void Twice(){} // RVA: 0xA1A4610
        public void TwicePlus(){} // RVA: 0xA1A46C0
        public void ThreeTimes(){} // RVA: 0xA1A47C0
        public void Negate(){} // RVA: 0xA1A4850
        public void CalculateJacobianModifiedW(){} // RVA: 0xA1A4950
        public void GetJacobianModifiedW(){} // RVA: 0xA1A4B80
        public void TwiceJacobianModified(){} // RVA: 0xA1A4CD0
    }

}