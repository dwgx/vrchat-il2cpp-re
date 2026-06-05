// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.GM
// Classes: 4
// Methods: 62

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.GM
{
    public class SM2P256V1Curve
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFA94C0
        public void CloneCurve(){} // RVA: 0x7FFAFBFA98F0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFAFBF2A750
        public void get_Q(){} // RVA: 0x7FFAFBFA9940
        public void get_Infinity(){} // RVA: 0x7FFAF2E2E0E0
        public void get_FieldSize(){} // RVA: 0x7FFAFBFA99A0
        public void FromBigInteger(){} // RVA: 0x7FFAFBFA9A10
        public void CreateRawPoint(){} // RVA: 0x7FFAFBFA9B60 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFAFBFA9C00
        public void .cctor(){} // RVA: 0x7FFAFBFA9E80
    }

    public class SM2P256V1Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAFBFAA250
        public void AddExt(){} // RVA: 0x7FFAFBFAA360
        public void AddOne(){} // RVA: 0x7FFAFBFAA510
        public void FromBigInteger(){} // RVA: 0x7FFAFBFAA670
        public void Half(){} // RVA: 0x7FFAFBFAA760
        public void Multiply(){} // RVA: 0x7FFAFBFAA890
        public void MultiplyAddToExt(){} // RVA: 0x7FFAFBFAA950
        public void Negate(){} // RVA: 0x7FFAFBFAAAC0
        public void Reduce(){} // RVA: 0x7FFAFBFAABD0
        public void Reduce32(){} // RVA: 0x7FFAFBFAAE50
        public void Square(){} // RVA: 0x7FFAFBFAB030
        public void SquareN(){} // RVA: 0x7FFAFBFAB0E0
        public void Subtract(){} // RVA: 0x7FFAFBFAB1E0
        public void SubtractExt(){} // RVA: 0x7FFAFBFAB330
        public void Twice(){} // RVA: 0x7FFAFBFAB460
        public void AddPInvTo(){} // RVA: 0x7FFAFBFAB5A0
        public void SubPInvFrom(){} // RVA: 0x7FFAFBFAB6A0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFBFAB780
    }

    public class SM2P256V1FieldElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFAFBF529B0
        public void get_IsOne(){} // RVA: 0x7FFAFBF529F0
        public void TestBitZero(){} // RVA: 0x7FFAFBF2CF00
        public void ToBigInteger(){} // RVA: 0x7FFAFBF52A50
        public void get_FieldName(){} // RVA: 0x7FFAFBFABB20
        public void get_FieldSize(){} // RVA: 0x7FFAFBFABB60
        public void Add(){} // RVA: 0x7FFAFBFABBD0
        public void AddOne(){} // RVA: 0x7FFAFBFABD40
        public void Subtract(){} // RVA: 0x7FFAFBFABF80
        public void Multiply(){} // RVA: 0x7FFAFBFAC0F0
        public void Divide(){} // RVA: 0x7FFAFBFAC260
        public void Negate(){} // RVA: 0x7FFAFBFAC420
        public void Square(){} // RVA: 0x7FFAFBFAC520
        public void Invert(){} // RVA: 0x7FFAFBFAC620
        public void Sqrt(){} // RVA: 0x7FFAFBFAC770
        public void Equals(){} // RVA: 0x7FFAFBF53CC0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFAFBFACCC0
        public void .cctor(){} // RVA: 0x7FFAFBFACDC0
    }

    public class SM2P256V1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBF2E360 | overloaded x3
        public void Detach(){} // RVA: 0x7FFAFBFACFD0
        public void Add(){} // RVA: 0x7FFAFBFAD0E0
        public void Twice(){} // RVA: 0x7FFAFBFADB80
        public void TwicePlus(){} // RVA: 0x7FFAFBF2F5F0
        public void ThreeTimes(){} // RVA: 0x7FFAFBF2F6F0
        public void Negate(){} // RVA: 0x7FFAFBFAE360
    }

}