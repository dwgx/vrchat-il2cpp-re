// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Srp
// Classes: 5
// Methods: 40

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Srp
{
    public class Srp6Client
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Init(){} // RVA: 0x9684CC0 | overloaded x2
        public void GenerateClientCredentials(){} // RVA: 0x9684D00
        public void CalculateSecret(){} // RVA: 0x9684E70
        public void SelectPrivateValue(){} // RVA: 0x9684FC0
        public void CalculateS(){} // RVA: 0x9684FF0
        public void CalculateClientEvidenceMessage(){} // RVA: 0x96851F0
        public void VerifyServerEvidenceMessage(){} // RVA: 0x96852A0
        public void CalculateSessionKey(){} // RVA: 0x9685390
    }

    public class Srp6Server
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Init(){} // RVA: 0x96855E0 | overloaded x2
        public void GenerateServerCredentials(){} // RVA: 0x9685630
        public void CalculateSecret(){} // RVA: 0x96858D0
        public void SelectPrivateValue(){} // RVA: 0x9685B00
        public void CalculateS(){} // RVA: 0x9685B30
        public void VerifyClientEvidenceMessage(){} // RVA: 0x9685C30
        public void CalculateServerEvidenceMessage(){} // RVA: 0x9685D20
        public void CalculateSessionKey(){} // RVA: 0x9685DD0
    }

    public class Srp6StandardGroups
    {
        // ── Methods ──
        public void FromHex(){} // RVA: 0x9685E70
        public void FromNG(){} // RVA: 0x9685F20
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9685FD0
    }

    public class Srp6Utilities
    {
        // ── Methods ──
        public void CalculateK(){} // RVA: 0x9686430
        public void CalculateU(){} // RVA: 0x9686450
        public void CalculateX(){} // RVA: 0x9686460
        public void GeneratePrivateValue(){} // RVA: 0x9686650
        public void ValidatePublicValue(){} // RVA: 0x9686760
        public void CalculateM1(){} // RVA: 0x96868D0
        public void CalculateM2(){} // RVA: 0x96868D0
        public void CalculateKey(){} // RVA: 0x96868E0
        public void HashPaddedTriplet(){} // RVA: 0x9686A30
        public void HashPaddedPair(){} // RVA: 0x9686C20
        public void GetPadded(){} // RVA: 0x9686DC0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Srp6VerifierGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Init(){} // RVA: 0x9686E70 | overloaded x2
        public void GenerateVerifier(){} // RVA: 0x9686EB0
    }

}