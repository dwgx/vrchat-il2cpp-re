// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.GM
// Classes: 4
// Methods: 62

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.GM
{
    public class SM2P256V1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SM2P256V1_DEFAULT_COORDS;
        public int SM2P256V1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F5B890
        public void CloneCurve(){} // RVA: 0x7FFE89F5BCC0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89EDCB20
        public void get_Q(){} // RVA: 0x7FFE89F5BD10
        public void get_Infinity(){} // RVA: 0x7FFE8119C0E0
        public void get_FieldSize(){} // RVA: 0x7FFE89F5BD70
        public void FromBigInteger(){} // RVA: 0x7FFE89F5BDE0
        public void CreateRawPoint(){} // RVA: 0x7FFE89F5BF30 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F5BFD0
        public void .cctor(){} // RVA: 0x7FFE89F5C250
    }

    public class SM2P256V1Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89F5C620
        public void AddExt(){} // RVA: 0x7FFE89F5C730
        public void AddOne(){} // RVA: 0x7FFE89F5C8E0
        public void FromBigInteger(){} // RVA: 0x7FFE89F5CA40
        public void Half(){} // RVA: 0x7FFE89F5CB30
        public void Multiply(){} // RVA: 0x7FFE89F5CC60
        public void MultiplyAddToExt(){} // RVA: 0x7FFE89F5CD20
        public void Negate(){} // RVA: 0x7FFE89F5CE90
        public void Reduce(){} // RVA: 0x7FFE89F5CFA0
        public void Reduce32(){} // RVA: 0x7FFE89F5D220
        public void Square(){} // RVA: 0x7FFE89F5D400
        public void SquareN(){} // RVA: 0x7FFE89F5D4B0
        public void Subtract(){} // RVA: 0x7FFE89F5D5B0
        public void SubtractExt(){} // RVA: 0x7FFE89F5D700
        public void Twice(){} // RVA: 0x7FFE89F5D830
        public void AddPInvTo(){} // RVA: 0x7FFE89F5D970
        public void SubPInvFrom(){} // RVA: 0x7FFE89F5DA70
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89F5DB50
    }

    public class SM2P256V1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10
        public object field_2; // 0x3B5
        public object field_3; // 0x3B6

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFE89F04D80
        public void get_IsOne(){} // RVA: 0x7FFE89F04DC0
        public void TestBitZero(){} // RVA: 0x7FFE89EDF2D0
        public void ToBigInteger(){} // RVA: 0x7FFE89F04E20
        public void get_FieldName(){} // RVA: 0x7FFE89F5DEF0
        public void get_FieldSize(){} // RVA: 0x7FFE89F5DF30
        public void Add(){} // RVA: 0x7FFE89F5DFA0
        public void AddOne(){} // RVA: 0x7FFE89F5E110
        public void Subtract(){} // RVA: 0x7FFE89F5E350
        public void Multiply(){} // RVA: 0x7FFE89F5E4C0
        public void Divide(){} // RVA: 0x7FFE89F5E630
        public void Negate(){} // RVA: 0x7FFE89F5E7F0
        public void Square(){} // RVA: 0x7FFE89F5E8F0
        public void Invert(){} // RVA: 0x7FFE89F5E9F0
        public void Sqrt(){} // RVA: 0x7FFE89F5EB40
        public void Equals(){} // RVA: 0x7FFE89F06090 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89F5F090
        public void .cctor(){} // RVA: 0x7FFE89F5F190
    }

    public class SM2P256V1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F5F3A0
        public void Add(){} // RVA: 0x7FFE89F5F4B0
        public void Twice(){} // RVA: 0x7FFE89F5FF50
        public void TwicePlus(){} // RVA: 0x7FFE89EE19C0
        public void ThreeTimes(){} // RVA: 0x7FFE89EE1AC0
        public void Negate(){} // RVA: 0x7FFE89F60730
    }

}