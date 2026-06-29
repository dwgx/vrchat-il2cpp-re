// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Srp
// Classes: 5
// Methods: 37

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Srp
{
    public class Srp6Client : Object
    {
        public object N;
        public object g;
        public object privA;
        public object pubA;
        public object B;
        public object x;
        public object u;
        public object S;
        public object M1;
        public object M2;
        public object Key;
        public object digest;
        public object random;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Init(){} // RVA: 0xA3293E0
        public void GenerateClientCredentials(){} // RVA: 0xA329420
        public void CalculateSecret(){} // RVA: 0xA329590
        public void SelectPrivateValue(){} // RVA: 0xA3296E0
        public void CalculateS(){} // RVA: 0xA329710
        public void CalculateClientEvidenceMessage(){} // RVA: 0xA329910
        public void VerifyServerEvidenceMessage(){} // RVA: 0xA3299C0
        public void CalculateSessionKey(){} // RVA: 0xA329AB0
    }

    public class Srp6Server : Object
    {
        public object N;
        public object g;
        public object v;
        public object random;
        public object digest;
        public object A;
        public object privB;
        public object pubB;
        public object u;
        public object S;
        public object M1;
        public object M2;
        public object Key;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Init(){} // RVA: 0xA329D00
        public void GenerateServerCredentials(){} // RVA: 0xA329D50
        public void CalculateSecret(){} // RVA: 0xA329FF0
        public void SelectPrivateValue(){} // RVA: 0xA32A220
        public void CalculateS(){} // RVA: 0xA32A250
        public void VerifyClientEvidenceMessage(){} // RVA: 0xA32A350
        public void CalculateServerEvidenceMessage(){} // RVA: 0xA32A440
        public void CalculateSessionKey(){} // RVA: 0xA32A4F0
    }

    public class Srp6StandardGroups : Object
    {
        public object rfc5054_1024_N;
        public object rfc5054_1024_g;
        public object rfc5054_1024;
        public object rfc5054_1536_N;
        public object rfc5054_1536_g;
        public object rfc5054_1536;
        public object rfc5054_2048_N;
        public object rfc5054_2048_g;
        public object rfc5054_2048;
        public object rfc5054_3072_N;
        public object rfc5054_3072_g;
        public object rfc5054_3072;
        public object rfc5054_4096_N;
        public object rfc5054_4096_g;
        public object rfc5054_4096;
        public object rfc5054_6144_N;
        public object rfc5054_6144_g;
        public object rfc5054_6144;
        public object rfc5054_8192_N;
        public object rfc5054_8192_g;
        public object rfc5054_8192;

        // ── Methods ──
        public void FromHex(){} // RVA: 0xA32A590
        public void FromNG(){} // RVA: 0xA32A640
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA32A6F0
    }

    public class Srp6Utilities : Object
    {
        // ── Methods ──
        public void CalculateK(){} // RVA: 0xA32AB50
        public void CalculateU(){} // RVA: 0xA32AB70
        public void CalculateX(){} // RVA: 0xA32AB80
        public void GeneratePrivateValue(){} // RVA: 0xA32AD70
        public void ValidatePublicValue(){} // RVA: 0xA32AE80
        public void CalculateM1(){} // RVA: 0xA32AFF0
        public void CalculateM2(){} // RVA: 0xA32AFF0
        public void CalculateKey(){} // RVA: 0xA32B000
        public void HashPaddedTriplet(){} // RVA: 0xA32B150
        public void HashPaddedPair(){} // RVA: 0xA32B340
        public void GetPadded(){} // RVA: 0xA32B4E0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Srp6VerifierGenerator : Object
    {
        public object N;
        public object g;
        public object digest;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Init(){} // RVA: 0xA32B590
        public void GenerateVerifier(){} // RVA: 0xA32B5D0
    }

}