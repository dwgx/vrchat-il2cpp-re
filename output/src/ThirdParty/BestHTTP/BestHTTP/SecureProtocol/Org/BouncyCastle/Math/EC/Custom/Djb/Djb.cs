// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Djb
// Classes: 4
// Methods: 68

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Djb
{
    public class Curve25519
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x94FE460
        public void CloneCurve(){} // RVA: 0x94FE890
        public void SupportsCoordinateSystem(){} // RVA: 0x94FE8E0
        public void get_Q(){} // RVA: 0x94FE8F0
        public void get_Infinity(){} // RVA: 0x37E0E0
        public void get_FieldSize(){} // RVA: 0x94FE950
        public void FromBigInteger(){} // RVA: 0x94FE9C0
        public void CreateRawPoint(){} // RVA: 0x94FEB10 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94FEBB0
        public void .cctor(){} // RVA: 0x94FEE30
    }

    public class Curve25519Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x94FF1A0
        public void AddExt(){} // RVA: 0x94FF2E0
        public void AddOne(){} // RVA: 0x94FF410
        public void FromBigInteger(){} // RVA: 0x94FF5A0
        public void Half(){} // RVA: 0x94FF690
        public void Multiply(){} // RVA: 0x94FF7B0
        public void MultiplyAddToExt(){} // RVA: 0x94FF870
        public void Negate(){} // RVA: 0x94FF950
        public void Reduce(){} // RVA: 0x94FFA60
        public void Reduce27(){} // RVA: 0x94FFC90
        public void Square(){} // RVA: 0x94FFE30
        public void SquareN(){} // RVA: 0x94FFEE0
        public void Subtract(){} // RVA: 0x94FFFE0
        public void SubtractExt(){} // RVA: 0x95000D0
        public void Twice(){} // RVA: 0x95001A0
        public void AddPTo(){} // RVA: 0x9500310
        public void AddPExtTo(){} // RVA: 0x95003A0
        public void SubPFrom(){} // RVA: 0x9500540
        public void SubPExtFrom(){} // RVA: 0x95005C0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9500760
    }

    public class Curve25519FieldElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x94A29B0
        public void get_IsOne(){} // RVA: 0x94A29F0
        public void TestBitZero(){} // RVA: 0x947CF00
        public void ToBigInteger(){} // RVA: 0x94A2A50
        public void get_FieldName(){} // RVA: 0x9500B10
        public void get_FieldSize(){} // RVA: 0x9500B50
        public void Add(){} // RVA: 0x9500BC0
        public void AddOne(){} // RVA: 0x9500E40
        public void Subtract(){} // RVA: 0x9500F40
        public void Multiply(){} // RVA: 0x95010B0
        public void Divide(){} // RVA: 0x9501220
        public void Negate(){} // RVA: 0x95013E0
        public void Square(){} // RVA: 0x95014E0
        public void Invert(){} // RVA: 0x95015E0
        public void Sqrt(){} // RVA: 0x9501730
        public void Equals(){} // RVA: 0x94A3CC0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x9501C90
        public void .cctor(){} // RVA: 0x9501D90
    }

    public class Curve25519Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x9502070
        public void GetZCoord(){} // RVA: 0x9502180
        public void Add(){} // RVA: 0x95021E0
        public void Twice(){} // RVA: 0x9502C70
        public void TwicePlus(){} // RVA: 0x9502D20
        public void ThreeTimes(){} // RVA: 0x9502E20
        public void Negate(){} // RVA: 0x9502EB0
        public void CalculateJacobianModifiedW(){} // RVA: 0x9502FB0
        public void GetJacobianModifiedW(){} // RVA: 0x95031D0
        public void TwiceJacobianModified(){} // RVA: 0x9503320
    }

}