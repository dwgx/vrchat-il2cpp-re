// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Srp
// Classes: 5
// Methods: 37

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Srp
{
    public class Srp6Client : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Init(){} // RVA: 0x7B14BDF60
        public void GenerateClientCredentials(){} // RVA: 0x7B14BDFA0
        public void CalculateSecret(){} // RVA: 0x7B14BE110
        public void SelectPrivateValue(){} // RVA: 0x7B14BE260
        public void CalculateS(){} // RVA: 0x7B14BE290
        public void CalculateClientEvidenceMessage(){} // RVA: 0x7B14BE490
        public void VerifyServerEvidenceMessage(){} // RVA: 0x7B14BE540
        public void CalculateSessionKey(){} // RVA: 0x7B14BE630
    }

    public class Srp6Server : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Init(){} // RVA: 0x7B14BE880
        public void GenerateServerCredentials(){} // RVA: 0x7B14BE8D0
        public void CalculateSecret(){} // RVA: 0x7B14BEB70
        public void SelectPrivateValue(){} // RVA: 0x7B14BEDA0
        public void CalculateS(){} // RVA: 0x7B14BEDD0
        public void VerifyClientEvidenceMessage(){} // RVA: 0x7B14BEED0
        public void CalculateServerEvidenceMessage(){} // RVA: 0x7B14BEFC0
        public void CalculateSessionKey(){} // RVA: 0x7B14BF070
    }

    public class Srp6StandardGroups : Object
    {
        // ── Methods ──
        public void FromHex(){} // RVA: 0x7B14BF110
        public void FromNG(){} // RVA: 0x7B14BF1C0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B14BF270
    }

    public class Srp6Utilities : Object
    {
        // ── Methods ──
        public void CalculateK(){} // RVA: 0x7B14BF6D0
        public void CalculateU(){} // RVA: 0x7B14BF6F0
        public void CalculateX(){} // RVA: 0x7B14BF700
        public void GeneratePrivateValue(){} // RVA: 0x7B14BF8F0
        public void ValidatePublicValue(){} // RVA: 0x7B14BFA00
        public void CalculateM1(){} // RVA: 0x7B14BFB70
        public void CalculateM2(){} // RVA: 0x7B14BFB70
        public void CalculateKey(){} // RVA: 0x7B14BFB80
        public void HashPaddedTriplet(){} // RVA: 0x7B14BFCD0
        public void HashPaddedPair(){} // RVA: 0x7B14BFEC0
        public void GetPadded(){} // RVA: 0x7B14C0060
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Srp6VerifierGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Init(){} // RVA: 0x7B14C0110
        public void GenerateVerifier(){} // RVA: 0x7B14C0150
    }

}