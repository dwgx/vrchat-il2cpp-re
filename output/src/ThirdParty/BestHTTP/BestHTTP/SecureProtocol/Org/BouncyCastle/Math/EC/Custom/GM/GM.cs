// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.GM
// Classes: 4
// Methods: 62

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.GM
{
    public class SM2P256V1Curve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SM2P256V1_DEFAULT_COORDS;
        public int SM2P256V1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94F94C0
        public void CloneCurve(){} // RVA: 0x94F98F0
        public void SupportsCoordinateSystem(){} // RVA: 0x947A750
        public void get_Q(){} // RVA: 0x94F9940
        public void get_Infinity(){} // RVA: 0x37E0E0
        public void get_FieldSize(){} // RVA: 0x94F99A0
        public void FromBigInteger(){} // RVA: 0x94F9A10
        public void CreateRawPoint(){} // RVA: 0x94F9B60 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94F9C00
        public void .cctor(){} // RVA: 0x94F9E80
    }

    public class SM2P256V1Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x94FA250
        public void AddExt(){} // RVA: 0x94FA360
        public void AddOne(){} // RVA: 0x94FA510
        public void FromBigInteger(){} // RVA: 0x94FA670
        public void Half(){} // RVA: 0x94FA760
        public void Multiply(){} // RVA: 0x94FA890
        public void MultiplyAddToExt(){} // RVA: 0x94FA950
        public void Negate(){} // RVA: 0x94FAAC0
        public void Reduce(){} // RVA: 0x94FABD0
        public void Reduce32(){} // RVA: 0x94FAE50
        public void Square(){} // RVA: 0x94FB030
        public void SquareN(){} // RVA: 0x94FB0E0
        public void Subtract(){} // RVA: 0x94FB1E0
        public void SubtractExt(){} // RVA: 0x94FB330
        public void Twice(){} // RVA: 0x94FB460
        public void AddPInvTo(){} // RVA: 0x94FB5A0
        public void SubPInvFrom(){} // RVA: 0x94FB6A0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x94FB780
    }

    public class SM2P256V1FieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x94A29B0
        public void get_IsOne(){} // RVA: 0x94A29F0
        public void TestBitZero(){} // RVA: 0x947CF00
        public void ToBigInteger(){} // RVA: 0x94A2A50
        public void get_FieldName(){} // RVA: 0x94FBB20
        public void get_FieldSize(){} // RVA: 0x94FBB60
        public void Add(){} // RVA: 0x94FBBD0
        public void AddOne(){} // RVA: 0x94FBD40
        public void Subtract(){} // RVA: 0x94FBF80
        public void Multiply(){} // RVA: 0x94FC0F0
        public void Divide(){} // RVA: 0x94FC260
        public void Negate(){} // RVA: 0x94FC420
        public void Square(){} // RVA: 0x94FC520
        public void Invert(){} // RVA: 0x94FC620
        public void Sqrt(){} // RVA: 0x94FC770
        public void Equals(){} // RVA: 0x94A3CC0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x94FCCC0
        public void .cctor(){} // RVA: 0x94FCDC0
    }

    public class SM2P256V1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94FCFD0
        public void Add(){} // RVA: 0x94FD0E0
        public void Twice(){} // RVA: 0x94FDB80
        public void TwicePlus(){} // RVA: 0x947F5F0
        public void ThreeTimes(){} // RVA: 0x947F6F0
        public void Negate(){} // RVA: 0x94FE360
    }

}