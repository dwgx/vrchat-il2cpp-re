// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.GM
// Classes: 4
// Methods: 55

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.GM
{
    public class SM2P256V1Curve : AbstractFpCurve
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B132F220
        public void CloneCurve(){} // RVA: 0x7B132F670
        public void SupportsCoordinateSystem(){} // RVA: 0x7B12AE6F0
        public void get_Q(){} // RVA: 0x7B132F6C0
        public void get_Infinity(){} // RVA: 0x7A8178B90
        public void get_FieldSize(){} // RVA: 0x7B132F720
        public void FromBigInteger(){} // RVA: 0x7B132F790
        public void CreateRawPoint(){} // RVA: 0x7B132F8E0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7B132F980
        public void .cctor(){} // RVA: 0x7B132FC10
    }

    public class SM2P256V1Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7B132FFF0
        public void AddExt(){} // RVA: 0x7B1330110
        public void AddOne(){} // RVA: 0x7B13302F0
        public void FromBigInteger(){} // RVA: 0x7B1330480
        public void Half(){} // RVA: 0x7B1330590
        public void Multiply(){} // RVA: 0x7B13306C0
        public void MultiplyAddToExt(){} // RVA: 0x7B1330780
        public void Negate(){} // RVA: 0x7B1330900
        public void Reduce(){} // RVA: 0x7B1330A30
        public void Reduce32(){} // RVA: 0x7B1330CB0
        public void Square(){} // RVA: 0x7B1330E90
        public void SquareN(){} // RVA: 0x7B1330F40
        public void Subtract(){} // RVA: 0x7B1331040
        public void SubtractExt(){} // RVA: 0x7B1331180
        public void Twice(){} // RVA: 0x7B13312E0
        public void AddPInvTo(){} // RVA: 0x7B1331440
        public void SubPInvFrom(){} // RVA: 0x7B1331520
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B1331600
    }

    public class SM2P256V1FieldElement : AbstractFpFieldElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_IsZero(){} // RVA: 0x7B12D6F40
        public void get_IsOne(){} // RVA: 0x7B12D6FA0
        public void TestBitZero(){} // RVA: 0x7B12B10D0
        public void ToBigInteger(){} // RVA: 0x7B12D7000
        public void get_FieldName(){} // RVA: 0x7B13319C0
        public void get_FieldSize(){} // RVA: 0x7B1331A00
        public void Add(){} // RVA: 0x7B1331A70
        public void AddOne(){} // RVA: 0x7B1331BE0
        public void Subtract(){} // RVA: 0x7B1331CE0
        public void Multiply(){} // RVA: 0x7B1331E50
        public void Divide(){} // RVA: 0x7B1331FC0
        public void Negate(){} // RVA: 0x7B1332180
        public void Square(){} // RVA: 0x7B1332280
        public void Invert(){} // RVA: 0x7B1332380
        public void Sqrt(){} // RVA: 0x7B13324D0
        public void Equals(){} // RVA: 0x7B12D82C0
        public void GetHashCode(){} // RVA: 0x7B1332A50
        public void .cctor(){} // RVA: 0x7B1332B50
    }

    public class SM2P256V1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B12B2560
        public void Detach(){} // RVA: 0x7B1332D60
        public void Add(){} // RVA: 0x7B1332E70
        public void Twice(){} // RVA: 0x7B1333960
        public void TwicePlus(){} // RVA: 0x7B12B36C0
        public void ThreeTimes(){} // RVA: 0x7B12B37C0
        public void Negate(){} // RVA: 0x7B1334160
    }

}