// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.GM
// Classes: 4
// Methods: 55

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.GM
{
    public class SM2P256V1Curve : AbstractFpCurve
    {
        public object q;
        public object SM2P256V1_DEFAULT_COORDS;
        public object SM2P256V1_FE_INTS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA19AB90
        public void CloneCurve(){} // RVA: 0xA19AFE0
        public void SupportsCoordinateSystem(){} // RVA: 0xA11A060
        public void get_Q(){} // RVA: 0xA19B030
        public void get_Infinity(){} // RVA: 0xBE58B0
        public void get_FieldSize(){} // RVA: 0xA19B090
        public void FromBigInteger(){} // RVA: 0xA19B100
        public void CreateRawPoint(){} // RVA: 0xA19B250
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA19B2F0
        public void .cctor(){} // RVA: 0xA19B580
    }

    public class SM2P256V1Field : Object
    {
        public object P;
        public object PExt;
        public object P7;
        public object PExt15;

        // ── Methods ──
        public void Add(){} // RVA: 0xA19B960
        public void AddExt(){} // RVA: 0xA19BA80
        public void AddOne(){} // RVA: 0xA19BC60
        public void FromBigInteger(){} // RVA: 0xA19BDF0
        public void Half(){} // RVA: 0xA19BF00
        public void Multiply(){} // RVA: 0xA19C030
        public void MultiplyAddToExt(){} // RVA: 0xA19C0F0
        public void Negate(){} // RVA: 0xA19C270
        public void Reduce(){} // RVA: 0xA19C3A0
        public void Reduce32(){} // RVA: 0xA19C620
        public void Square(){} // RVA: 0xA19C800
        public void SquareN(){} // RVA: 0xA19C8B0
        public void Subtract(){} // RVA: 0xA19C9B0
        public void SubtractExt(){} // RVA: 0xA19CAF0
        public void Twice(){} // RVA: 0xA19CC50
        public void AddPInvTo(){} // RVA: 0xA19CDB0
        public void SubPInvFrom(){} // RVA: 0xA19CE90
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA19CF70
    }

    public class SM2P256V1FieldElement : AbstractFpFieldElement
    {
        public object Q;
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsZero(){} // RVA: 0xA1428B0
        public void get_IsOne(){} // RVA: 0xA142910
        public void TestBitZero(){} // RVA: 0xA11CA40
        public void ToBigInteger(){} // RVA: 0xA142970
        public void get_FieldName(){} // RVA: 0xA19D330
        public void get_FieldSize(){} // RVA: 0xA19D370
        public void Add(){} // RVA: 0xA19D3E0
        public void AddOne(){} // RVA: 0xA19D550
        public void Subtract(){} // RVA: 0xA19D650
        public void Multiply(){} // RVA: 0xA19D7C0
        public void Divide(){} // RVA: 0xA19D930
        public void Negate(){} // RVA: 0xA19DAF0
        public void Square(){} // RVA: 0xA19DBF0
        public void Invert(){} // RVA: 0xA19DCF0
        public void Sqrt(){} // RVA: 0xA19DE40
        public void Equals(){} // RVA: 0xA143C30
        public void GetHashCode(){} // RVA: 0xA19E3C0
        public void .cctor(){} // RVA: 0xA19E4C0
    }

    public class SM2P256V1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA19E6D0
        public void Add(){} // RVA: 0xA19E7E0
        public void Twice(){} // RVA: 0xA19F2D0
        public void TwicePlus(){} // RVA: 0xA11F030
        public void ThreeTimes(){} // RVA: 0xA11F130
        public void Negate(){} // RVA: 0xA19FAD0
    }

}