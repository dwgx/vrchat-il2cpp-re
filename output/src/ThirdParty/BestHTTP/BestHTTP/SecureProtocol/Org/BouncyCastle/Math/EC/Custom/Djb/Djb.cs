// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Djb
// Classes: 4
// Methods: 68

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Djb
{
    public class Curve25519 : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int Curve25519_DEFAULT_COORDS;
        public int CURVE25519_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F60830
        public void CloneCurve(){} // RVA: 0x7FFE89F60C60
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89F60CB0
        public void get_Q(){} // RVA: 0x7FFE89F60CC0
        public void get_Infinity(){} // RVA: 0x7FFE8119C0E0
        public void get_FieldSize(){} // RVA: 0x7FFE89F60D20
        public void FromBigInteger(){} // RVA: 0x7FFE89F60D90
        public void CreateRawPoint(){} // RVA: 0x7FFE89F60EE0 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F60F80
        public void .cctor(){} // RVA: 0x7FFE89F61200
    }

    public class Curve25519Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89F61570
        public void AddExt(){} // RVA: 0x7FFE89F616B0
        public void AddOne(){} // RVA: 0x7FFE89F617E0
        public void FromBigInteger(){} // RVA: 0x7FFE89F61970
        public void Half(){} // RVA: 0x7FFE89F61A60
        public void Multiply(){} // RVA: 0x7FFE89F61B80
        public void MultiplyAddToExt(){} // RVA: 0x7FFE89F61C40
        public void Negate(){} // RVA: 0x7FFE89F61D20
        public void Reduce(){} // RVA: 0x7FFE89F61E30
        public void Reduce27(){} // RVA: 0x7FFE89F62060
        public void Square(){} // RVA: 0x7FFE89F62200
        public void SquareN(){} // RVA: 0x7FFE89F622B0
        public void Subtract(){} // RVA: 0x7FFE89F623B0
        public void SubtractExt(){} // RVA: 0x7FFE89F624A0
        public void Twice(){} // RVA: 0x7FFE89F62570
        public void AddPTo(){} // RVA: 0x7FFE89F626E0
        public void AddPExtTo(){} // RVA: 0x7FFE89F62770
        public void SubPFrom(){} // RVA: 0x7FFE89F62910
        public void SubPExtFrom(){} // RVA: 0x7FFE89F62990
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89F62B30
    }

    public class Curve25519FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] PRECOMP_POW2; // 0x8
        public uint[] x; // 0x10
        public object field_3; // 0x3BD

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFE89F04D80
        public void get_IsOne(){} // RVA: 0x7FFE89F04DC0
        public void TestBitZero(){} // RVA: 0x7FFE89EDF2D0
        public void ToBigInteger(){} // RVA: 0x7FFE89F04E20
        public void get_FieldName(){} // RVA: 0x7FFE89F62EE0
        public void get_FieldSize(){} // RVA: 0x7FFE89F62F20
        public void Add(){} // RVA: 0x7FFE89F62F90
        public void AddOne(){} // RVA: 0x7FFE89F63210
        public void Subtract(){} // RVA: 0x7FFE89F63310
        public void Multiply(){} // RVA: 0x7FFE89F63480
        public void Divide(){} // RVA: 0x7FFE89F635F0
        public void Negate(){} // RVA: 0x7FFE89F637B0
        public void Square(){} // RVA: 0x7FFE89F638B0
        public void Invert(){} // RVA: 0x7FFE89F639B0
        public void Sqrt(){} // RVA: 0x7FFE89F63B00
        public void Equals(){} // RVA: 0x7FFE89F06090 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89F64060
        public void .cctor(){} // RVA: 0x7FFE89F64160
    }

    public class Curve25519Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F64440
        public void GetZCoord(){} // RVA: 0x7FFE89F64550
        public void Add(){} // RVA: 0x7FFE89F645B0
        public void Twice(){} // RVA: 0x7FFE89F65040
        public void TwicePlus(){} // RVA: 0x7FFE89F650F0
        public void ThreeTimes(){} // RVA: 0x7FFE89F651F0
        public void Negate(){} // RVA: 0x7FFE89F65280
        public void CalculateJacobianModifiedW(){} // RVA: 0x7FFE89F65380
        public void GetJacobianModifiedW(){} // RVA: 0x7FFE89F655A0
        public void TwiceJacobianModified(){} // RVA: 0x7FFE89F656F0
    }

}