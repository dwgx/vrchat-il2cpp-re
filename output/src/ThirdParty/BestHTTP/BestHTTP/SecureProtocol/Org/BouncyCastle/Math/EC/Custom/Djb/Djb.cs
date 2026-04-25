// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Djb
// Classes: 4
// Methods: 68

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Djb
{
    public class Curve25519 : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point m_infinity; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB07210
        public void CloneCurve(){} // RVA: 0x7FFACBB07640
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBB07690
        public void get_Q(){} // RVA: 0x7FFACBB076A0
        public void get_Infinity(){} // RVA: 0x7FFAC2FC20E0
        public void get_FieldSize(){} // RVA: 0x7FFACBB07700
        public void FromBigInteger(){} // RVA: 0x7FFACBB07770
        public void CreateRawPoint(){} // RVA: 0x7FFACBB078C0 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBB07960
        public void .cctor(){} // RVA: 0x7FFACBB07BE0
    }

    public class Curve25519Field : Object
    {
        public uint[] P;
        public uint P7;
        public uint[] PExt; // 0x8
        public uint PInv;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBB07F50
        public void AddExt(){} // RVA: 0x7FFACBB08090
        public void AddOne(){} // RVA: 0x7FFACBB081C0
        public void FromBigInteger(){} // RVA: 0x7FFACBB08350
        public void Half(){} // RVA: 0x7FFACBB08440
        public void Multiply(){} // RVA: 0x7FFACBB08560
        public void MultiplyAddToExt(){} // RVA: 0x7FFACBB08620
        public void Negate(){} // RVA: 0x7FFACBB08700
        public void Reduce(){} // RVA: 0x7FFACBB08810
        public void Reduce27(){} // RVA: 0x7FFACBB08A40
        public void Square(){} // RVA: 0x7FFACBB08BE0
        public void SquareN(){} // RVA: 0x7FFACBB08C90
        public void Subtract(){} // RVA: 0x7FFACBB08D90
        public void SubtractExt(){} // RVA: 0x7FFACBB08E80
        public void Twice(){} // RVA: 0x7FFACBB08F50
        public void AddPTo(){} // RVA: 0x7FFACBB090C0
        public void AddPExtTo(){} // RVA: 0x7FFACBB09150
        public void SubPFrom(){} // RVA: 0x7FFACBB092F0
        public void SubPExtFrom(){} // RVA: 0x7FFACBB09370
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBB09510
    }

    public class Curve25519FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger IsZero;
        public uint[] IsOne; // 0x8
        public uint[] FieldName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFACBAAB760
        public void get_IsOne(){} // RVA: 0x7FFACBAAB7A0
        public void TestBitZero(){} // RVA: 0x7FFACBA85CB0
        public void ToBigInteger(){} // RVA: 0x7FFACBAAB800
        public void get_FieldName(){} // RVA: 0x7FFACBB098C0
        public void get_FieldSize(){} // RVA: 0x7FFACBB09900
        public void Add(){} // RVA: 0x7FFACBB09970
        public void AddOne(){} // RVA: 0x7FFACBB09BF0
        public void Subtract(){} // RVA: 0x7FFACBB09CF0
        public void Multiply(){} // RVA: 0x7FFACBB09E60
        public void Divide(){} // RVA: 0x7FFACBB09FD0
        public void Negate(){} // RVA: 0x7FFACBB0A190
        public void Square(){} // RVA: 0x7FFACBB0A290
        public void Invert(){} // RVA: 0x7FFACBB0A390
        public void Sqrt(){} // RVA: 0x7FFACBB0A4E0
        public void Equals(){} // RVA: 0x7FFACBAACA70 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBB0AA40
        public void .cctor(){} // RVA: 0x7FFACBB0AB40
    }

    public class Curve25519Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBB0AE20
        public void GetZCoord(){} // RVA: 0x7FFACBB0AF30
        public void Add(){} // RVA: 0x7FFACBB0AF90
        public void Twice(){} // RVA: 0x7FFACBB0BA20
        public void TwicePlus(){} // RVA: 0x7FFACBB0BAD0
        public void ThreeTimes(){} // RVA: 0x7FFACBB0BBD0
        public void Negate(){} // RVA: 0x7FFACBB0BC60
        public void CalculateJacobianModifiedW(){} // RVA: 0x7FFACBB0BD60
        public void GetJacobianModifiedW(){} // RVA: 0x7FFACBB0BF80
        public void TwiceJacobianModified(){} // RVA: 0x7FFACBB0C0D0
    }

}