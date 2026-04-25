// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.GM
// Classes: 4
// Methods: 62

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.GM
{
    public class SM2P256V1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Point m_infinity; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB02270
        public void CloneCurve(){} // RVA: 0x7FFACBB026A0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBA83500
        public void get_Q(){} // RVA: 0x7FFACBB026F0
        public void get_Infinity(){} // RVA: 0x7FFAC2FC20E0
        public void get_FieldSize(){} // RVA: 0x7FFACBB02750
        public void FromBigInteger(){} // RVA: 0x7FFACBB027C0
        public void CreateRawPoint(){} // RVA: 0x7FFACBB02910 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBB029B0
        public void .cctor(){} // RVA: 0x7FFACBB02C30
    }

    public class SM2P256V1Field : Object
    {
        public uint[] P;
        public uint[] PExt; // 0x8
        public uint P7;
        public uint PExt15;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBB03000
        public void AddExt(){} // RVA: 0x7FFACBB03110
        public void AddOne(){} // RVA: 0x7FFACBB032C0
        public void FromBigInteger(){} // RVA: 0x7FFACBB03420
        public void Half(){} // RVA: 0x7FFACBB03510
        public void Multiply(){} // RVA: 0x7FFACBB03640
        public void MultiplyAddToExt(){} // RVA: 0x7FFACBB03700
        public void Negate(){} // RVA: 0x7FFACBB03870
        public void Reduce(){} // RVA: 0x7FFACBB03980
        public void Reduce32(){} // RVA: 0x7FFACBB03C00
        public void Square(){} // RVA: 0x7FFACBB03DE0
        public void SquareN(){} // RVA: 0x7FFACBB03E90
        public void Subtract(){} // RVA: 0x7FFACBB03F90
        public void SubtractExt(){} // RVA: 0x7FFACBB040E0
        public void Twice(){} // RVA: 0x7FFACBB04210
        public void AddPInvTo(){} // RVA: 0x7FFACBB04350
        public void SubPInvFrom(){} // RVA: 0x7FFACBB04450
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBB04530
    }

    public class SM2P256V1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger IsZero;
        public uint[] IsOne; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFACBAAB760
        public void get_IsOne(){} // RVA: 0x7FFACBAAB7A0
        public void TestBitZero(){} // RVA: 0x7FFACBA85CB0
        public void ToBigInteger(){} // RVA: 0x7FFACBAAB800
        public void get_FieldName(){} // RVA: 0x7FFACBB048D0
        public void get_FieldSize(){} // RVA: 0x7FFACBB04910
        public void Add(){} // RVA: 0x7FFACBB04980
        public void AddOne(){} // RVA: 0x7FFACBB04AF0
        public void Subtract(){} // RVA: 0x7FFACBB04D30
        public void Multiply(){} // RVA: 0x7FFACBB04EA0
        public void Divide(){} // RVA: 0x7FFACBB05010
        public void Negate(){} // RVA: 0x7FFACBB051D0
        public void Square(){} // RVA: 0x7FFACBB052D0
        public void Invert(){} // RVA: 0x7FFACBB053D0
        public void Sqrt(){} // RVA: 0x7FFACBB05520
        public void Equals(){} // RVA: 0x7FFACBAACA70 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBB05A70
        public void .cctor(){} // RVA: 0x7FFACBB05B70
    }

    public class SM2P256V1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBB05D80
        public void Add(){} // RVA: 0x7FFACBB05E90
        public void Twice(){} // RVA: 0x7FFACBB06930
        public void TwicePlus(){} // RVA: 0x7FFACBA883A0
        public void ThreeTimes(){} // RVA: 0x7FFACBA884A0
        public void Negate(){} // RVA: 0x7FFACBB07110
    }

}