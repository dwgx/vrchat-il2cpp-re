// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Rfc7748
// Classes: 4
// Methods: 88

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Rfc7748
{
    public class X25519 : Object
    {
        public int PointSize;
        public int ScalarSize;
        public int C_A;
        public int C_A24;

        // ── Methods ──
        public void CalculateAgreement(){} // RVA: 0x7FFACBFDF080
        public void Decode32(){} // RVA: 0x7FFACBA73990
        public void DecodeScalar(){} // RVA: 0x7FFACBFDF160
        public void GeneratePrivateKey(){} // RVA: 0x7FFACBFDF250
        public void GeneratePublicKey(){} // RVA: 0x7FFACBFDF2B0
        public void PointDouble(){} // RVA: 0x7FFACBFDF2C0
        public void Precompute(){} // RVA: 0x7FFACBFDF4E0
        public void ScalarMult(){} // RVA: 0x7FFACBFDF530
        public void ScalarMultBase(){} // RVA: 0x7FFACBFDFD50
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class X25519Field : Object
    {
        public int Size;
        public int M24;
        public int M25;
        public int M26;
        public int[] RootNegOne;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Add(){} // RVA: 0x7FFACBA730D0
        public void AddOne(){} // RVA: 0x7FFACBA73170 | overloaded x2
        public void Apm(){} // RVA: 0x7FFACBA731A0
        public void Carry(){} // RVA: 0x7FFACBA73230
        public void CMov(){} // RVA: 0x7FFACBA73400
        public void CNegate(){} // RVA: 0x7FFACBA73480
        public void Copy(){} // RVA: 0x7FFACBA734D0
        public void Create(){} // RVA: 0x7FFACBA73530
        public void CreateTable(){} // RVA: 0x7FFACBA73570
        public void CSwap(){} // RVA: 0x7FFACBA735B0
        public void Decode(){} // RVA: 0x7FFACBA73630
        public void Decode128(){} // RVA: 0x7FFACBA736E0
        public void Decode32(){} // RVA: 0x7FFACBA73990
        public void Encode(){} // RVA: 0x7FFACBA73A00
        public void Encode128(){} // RVA: 0x7FFACBA73AA0
        public void Encode32(){} // RVA: 0x7FFACBA73D00
        public void Inv(){} // RVA: 0x7FFACBA73D70
        public void IsZero(){} // RVA: 0x7FFACBA73E80
        public void IsZeroVar(){} // RVA: 0x7FFACBA73ED0
        public void Mul(){} // RVA: 0x7FFACBA741A0 | overloaded x2
        public void Negate(){} // RVA: 0x7FFACBA749C0
        public void Normalize(){} // RVA: 0x7FFACBA74A20
        public void One(){} // RVA: 0x7FFACBA74AB0
        public void PowPm5d8(){} // RVA: 0x7FFACBA74B00
        public void Reduce(){} // RVA: 0x7FFACBA74DA0
        public void Sqr(){} // RVA: 0x7FFACBA75430 | overloaded x2
        public void SqrtRatioVar(){} // RVA: 0x7FFACBA754E0
        public void Sub(){} // RVA: 0x7FFACBA759E0
        public void SubOne(){} // RVA: 0x7FFACBA75A50
        public void Zero(){} // RVA: 0x7FFACBA75A80
        public void .cctor(){} // RVA: 0x7FFACBA75AC0
    }

    public class X448 : Object
    {
        public int PointSize;
        public int ScalarSize;
        public uint C_A;
        public uint C_A24;

        // ── Methods ──
        public void CalculateAgreement(){} // RVA: 0x7FFACBA75BA0
        public void Decode32(){} // RVA: 0x7FFACBA73990
        public void DecodeScalar(){} // RVA: 0x7FFACBA75C80
        public void GeneratePrivateKey(){} // RVA: 0x7FFACBA75D60
        public void GeneratePublicKey(){} // RVA: 0x7FFACBA75DB0
        public void PointDouble(){} // RVA: 0x7FFACBA75DC0
        public void Precompute(){} // RVA: 0x7FFACBA75F80
        public void ScalarMult(){} // RVA: 0x7FFACBA75FD0
        public void ScalarMultBase(){} // RVA: 0x7FFACBA76670
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class X448Field : Object
    {
        public int Size;
        public uint M28;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Add(){} // RVA: 0x7FFACBA76920
        public void AddOne(){} // RVA: 0x7FFACBA73170 | overloaded x2
        public void Carry(){} // RVA: 0x7FFACBA76990
        public void CMov(){} // RVA: 0x7FFACBA76CB0
        public void CNegate(){} // RVA: 0x7FFACBA76D30
        public void Copy(){} // RVA: 0x7FFACBA76DE0
        public void Create(){} // RVA: 0x7FFACBA76E40
        public void CSwap(){} // RVA: 0x7FFACBA76E80
        public void Decode(){} // RVA: 0x7FFACBA76F00
        public void Decode24(){} // RVA: 0x7FFACBA77520
        public void Decode32(){} // RVA: 0x7FFACBA73990
        public void Decode56(){} // RVA: 0x7FFACBA77580
        public void Encode(){} // RVA: 0x7FFACBA77680
        public void Encode24(){} // RVA: 0x7FFACBA77C20
        public void Encode32(){} // RVA: 0x7FFACBA73D00
        public void Encode56(){} // RVA: 0x7FFACBA77C80
        public void Inv(){} // RVA: 0x7FFACBA77D60
        public void IsZero(){} // RVA: 0x7FFACBA77E10
        public void IsZeroVar(){} // RVA: 0x7FFACBA77E60
        public void Mul(){} // RVA: 0x7FFACBA78250 | overloaded x2
        public void Negate(){} // RVA: 0x7FFACBA79570
        public void Normalize(){} // RVA: 0x7FFACBA795D0
        public void One(){} // RVA: 0x7FFACBA796A0
        public void PowPm3d4(){} // RVA: 0x7FFACBA796F0
        public void Reduce(){} // RVA: 0x7FFACBA79C10
        public void Sqr(){} // RVA: 0x7FFACBA7A7C0 | overloaded x2
        public void SqrtRatioVar(){} // RVA: 0x7FFACBA7A800
        public void Sub(){} // RVA: 0x7FFACBA7AA40
        public void Zero(){} // RVA: 0x7FFACBA7AEC0
    }

}