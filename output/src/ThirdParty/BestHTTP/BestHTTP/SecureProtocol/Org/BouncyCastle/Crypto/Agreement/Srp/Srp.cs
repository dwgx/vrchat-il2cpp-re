// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Srp
// Classes: 5
// Methods: 40

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Srp
{
    public class Srp6Client
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Init(){} // RVA: 0x7FFAFC134CC0 | overloaded x2
        public void GenerateClientCredentials(){} // RVA: 0x7FFAFC134D00
        public void CalculateSecret(){} // RVA: 0x7FFAFC134E70
        public void SelectPrivateValue(){} // RVA: 0x7FFAFC134FC0
        public void CalculateS(){} // RVA: 0x7FFAFC134FF0
        public void CalculateClientEvidenceMessage(){} // RVA: 0x7FFAFC1351F0
        public void VerifyServerEvidenceMessage(){} // RVA: 0x7FFAFC1352A0
        public void CalculateSessionKey(){} // RVA: 0x7FFAFC135390
    }

    public class Srp6Server
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Init(){} // RVA: 0x7FFAFC1355E0 | overloaded x2
        public void GenerateServerCredentials(){} // RVA: 0x7FFAFC135630
        public void CalculateSecret(){} // RVA: 0x7FFAFC1358D0
        public void SelectPrivateValue(){} // RVA: 0x7FFAFC135B00
        public void CalculateS(){} // RVA: 0x7FFAFC135B30
        public void VerifyClientEvidenceMessage(){} // RVA: 0x7FFAFC135C30
        public void CalculateServerEvidenceMessage(){} // RVA: 0x7FFAFC135D20
        public void CalculateSessionKey(){} // RVA: 0x7FFAFC135DD0
    }

    public class Srp6StandardGroups
    {
        // ── Methods ──
        public void FromHex(){} // RVA: 0x7FFAFC135E70
        public void FromNG(){} // RVA: 0x7FFAFC135F20
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC135FD0
    }

    public class Srp6Utilities
    {
        // ── Methods ──
        public void CalculateK(){} // RVA: 0x7FFAFC136430
        public void CalculateU(){} // RVA: 0x7FFAFC136450
        public void CalculateX(){} // RVA: 0x7FFAFC136460
        public void GeneratePrivateValue(){} // RVA: 0x7FFAFC136650
        public void ValidatePublicValue(){} // RVA: 0x7FFAFC136760
        public void CalculateM1(){} // RVA: 0x7FFAFC1368D0
        public void CalculateM2(){} // RVA: 0x7FFAFC1368D0
        public void CalculateKey(){} // RVA: 0x7FFAFC1368E0
        public void HashPaddedTriplet(){} // RVA: 0x7FFAFC136A30
        public void HashPaddedPair(){} // RVA: 0x7FFAFC136C20
        public void GetPadded(){} // RVA: 0x7FFAFC136DC0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Srp6VerifierGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Init(){} // RVA: 0x7FFAFC136E70 | overloaded x2
        public void GenerateVerifier(){} // RVA: 0x7FFAFC136EB0
    }

}