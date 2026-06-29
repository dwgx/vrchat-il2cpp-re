// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Rfc7748
// Classes: 4
// Methods: 82

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Rfc7748
{
    public class X25519 : Object
    {
        public object PointSize;
        public object ScalarSize;
        public object C_A;
        public object C_A24;

        // ── Methods ──
        public void CalculateAgreement(){} // RVA: 0xA68E8B0
        public void Decode32(){} // RVA: 0xA10A3D0
        public void DecodeScalar(){} // RVA: 0xA68E9A0
        public void GeneratePrivateKey(){} // RVA: 0xA68EA80
        public void GeneratePublicKey(){} // RVA: 0xA68EAE0
        public void PointDouble(){} // RVA: 0xA68EAF0
        public void Precompute(){} // RVA: 0xA68ED30
        public void ScalarMult(){} // RVA: 0xA68ED80
        public void ScalarMultBase(){} // RVA: 0xA68F620
        public void .ctor(){} // RVA: 0xB43310
    }

    public class X25519Field : Object
    {
        public object Size;
        public object M24;
        public object M25;
        public object M26;
        public object RootNegOne;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Add(){} // RVA: 0xA109A80
        public void AddOne(){} // RVA: 0xA109B30
        public void Apm(){} // RVA: 0xA109B60
        public void Carry(){} // RVA: 0xA109C20
        public void CMov(){} // RVA: 0xA109DF0
        public void CNegate(){} // RVA: 0xA109E90
        public void Copy(){} // RVA: 0xA109EE0
        public void Create(){} // RVA: 0xA109F60
        public void CreateTable(){} // RVA: 0xA109FA0
        public void CSwap(){} // RVA: 0xA109FE0
        public void Decode(){} // RVA: 0xA10A070
        public void Decode128(){} // RVA: 0xA10A120
        public void Decode32(){} // RVA: 0xA10A3D0
        public void Encode(){} // RVA: 0xA10A440
        public void Encode128(){} // RVA: 0xA10A4E0
        public void Encode32(){} // RVA: 0xA10A740
        public void Inv(){} // RVA: 0xA10A7B0
        public void IsZero(){} // RVA: 0xA10A8C0
        public void IsZeroVar(){} // RVA: 0xA10A920
        public void Mul(){} // RVA: 0xA10AC00
        public void Negate(){} // RVA: 0xA10B430
        public void Normalize(){} // RVA: 0xA10B490
        public void One(){} // RVA: 0xA10B520
        public void PowPm5d8(){} // RVA: 0xA10B570
        public void Reduce(){} // RVA: 0xA10B810
        public void Sqr(){} // RVA: 0xA10BEA0
        public void SqrtRatioVar(){} // RVA: 0xA10BF50
        public void Sub(){} // RVA: 0xA10C480
        public void SubOne(){} // RVA: 0xA10C500
        public void Zero(){} // RVA: 0xA10C530
        public void .cctor(){} // RVA: 0xA10C580
    }

    public class X448 : Object
    {
        public object PointSize;
        public object ScalarSize;
        public object C_A;
        public object C_A24;

        // ── Methods ──
        public void CalculateAgreement(){} // RVA: 0xA10C660
        public void Decode32(){} // RVA: 0xA10A3D0
        public void DecodeScalar(){} // RVA: 0xA10C750
        public void GeneratePrivateKey(){} // RVA: 0xA10C820
        public void GeneratePublicKey(){} // RVA: 0xA10C870
        public void PointDouble(){} // RVA: 0xA10C9B0
        public void Precompute(){} // RVA: 0xA10CB70
        public void ScalarMult(){} // RVA: 0xA10CBC0
        public void ScalarMultBase(){} // RVA: 0xA10C870
        public void .ctor(){} // RVA: 0xB43310
    }

    public class X448Field : Object
    {
        public object Size;
        public object M28;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Add(){} // RVA: 0xA10D2C0
        public void AddOne(){} // RVA: 0xA109B30
        public void Carry(){} // RVA: 0xA10D340
        public void CMov(){} // RVA: 0xA10D660
        public void CNegate(){} // RVA: 0xA10D700
        public void Copy(){} // RVA: 0xA10D7C0
        public void Create(){} // RVA: 0xA10D840
        public void CSwap(){} // RVA: 0xA10D880
        public void Decode(){} // RVA: 0xA10D910
        public void Decode24(){} // RVA: 0xA10DF30
        public void Decode32(){} // RVA: 0xA10A3D0
        public void Decode56(){} // RVA: 0xA10DF90
        public void Encode(){} // RVA: 0xA10E090
        public void Encode24(){} // RVA: 0xA10E630
        public void Encode32(){} // RVA: 0xA10A740
        public void Encode56(){} // RVA: 0xA10E690
        public void Inv(){} // RVA: 0xA10E770
        public void IsZero(){} // RVA: 0xA10E820
        public void IsZeroVar(){} // RVA: 0xA10E880
        public void Mul(){} // RVA: 0xA10EC80
        public void Negate(){} // RVA: 0xA10FFC0
        public void Normalize(){} // RVA: 0xA110020
        public void One(){} // RVA: 0xA110110
        public void PowPm3d4(){} // RVA: 0xA110160
        public void Reduce(){} // RVA: 0xA110680
        public void Sqr(){} // RVA: 0xA111220
        public void SqrtRatioVar(){} // RVA: 0xA111260
        public void Sub(){} // RVA: 0xA1114C0
        public void Zero(){} // RVA: 0xA111940
    }

}