// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Srp
// Classes: 5
// Methods: 40

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Srp
{
    public class Srp6Client : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Init(){} // RVA: 0x7FFE8A0E70A0 | overloaded x2
        public void GenerateClientCredentials(){} // RVA: 0x7FFE8A0E70E0
        public void CalculateSecret(){} // RVA: 0x7FFE8A0E7250
        public void SelectPrivateValue(){} // RVA: 0x7FFE8A0E73A0
        public void CalculateS(){} // RVA: 0x7FFE8A0E73D0
        public void CalculateClientEvidenceMessage(){} // RVA: 0x7FFE8A0E75D0
        public void VerifyServerEvidenceMessage(){} // RVA: 0x7FFE8A0E7680
        public void CalculateSessionKey(){} // RVA: 0x7FFE8A0E7770
    }

    public class Srp6Server : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Init(){} // RVA: 0x7FFE8A0E79C0 | overloaded x2
        public void GenerateServerCredentials(){} // RVA: 0x7FFE8A0E7A10
        public void CalculateSecret(){} // RVA: 0x7FFE8A0E7CB0
        public void SelectPrivateValue(){} // RVA: 0x7FFE8A0E7EE0
        public void CalculateS(){} // RVA: 0x7FFE8A0E7F10
        public void VerifyClientEvidenceMessage(){} // RVA: 0x7FFE8A0E8010
        public void CalculateServerEvidenceMessage(){} // RVA: 0x7FFE8A0E8100
        public void CalculateSessionKey(){} // RVA: 0x7FFE8A0E81B0
    }

    public class Srp6StandardGroups : Object
    {
        // ── Methods ──
        public void FromHex(){} // RVA: 0x7FFE8A0E8250
        public void FromNG(){} // RVA: 0x7FFE8A0E8300
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A0E83B0
    }

    public class Srp6Utilities : Object
    {
        // ── Methods ──
        public void CalculateK(){} // RVA: 0x7FFE8A0E8810
        public void CalculateU(){} // RVA: 0x7FFE8A0E8830
        public void CalculateX(){} // RVA: 0x7FFE8A0E8840
        public void GeneratePrivateValue(){} // RVA: 0x7FFE8A0E8A30
        public void ValidatePublicValue(){} // RVA: 0x7FFE8A0E8B40
        public void CalculateM1(){} // RVA: 0x7FFE8A0E8CB0
        public void CalculateM2(){} // RVA: 0x7FFE8A0E8CB0
        public void CalculateKey(){} // RVA: 0x7FFE8A0E8CC0
        public void HashPaddedTriplet(){} // RVA: 0x7FFE8A0E8E10
        public void HashPaddedPair(){} // RVA: 0x7FFE8A0E9000
        public void GetPadded(){} // RVA: 0x7FFE8A0E91A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Srp6VerifierGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Init(){} // RVA: 0x7FFE8A0E9250 | overloaded x2
        public void GenerateVerifier(){} // RVA: 0x7FFE8A0E9290
    }

}