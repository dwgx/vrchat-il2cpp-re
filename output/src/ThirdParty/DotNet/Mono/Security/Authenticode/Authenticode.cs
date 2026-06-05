// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Authenticode
// Classes: 3
// Methods: 24

namespace ThirdParty.DotNet.Mono.Security.Authenticode
{
    public class AuthenticodeBase
    {
        public object RawData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8695AB0
        public void get_PEOffset(){} // RVA: 0x7FFAF8695B40
        public void Open(){} // RVA: 0x7FFAF8695C70 | overloaded x2
        public void Close(){} // RVA: 0x7FFAF8695D40
        public void ReadFirstBlock(){} // RVA: 0x7FFAF8695DC0
        public void ProcessFirstBlock(){} // RVA: 0x7FFAF8695EA0
        public void GetSecurityEntry(){} // RVA: 0x7FFAF8696290
        public void GetHash(){} // RVA: 0x7FFAF8696360
    }

    public class AuthenticodeDeformatter
    {
        public object RSA;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8696B00 | overloaded x2
        public void set_RawData(){} // RVA: 0x7FFAF8696CE0
        public void get_SigningCertificate(){} // RVA: 0x7FFAF2E55590
        public void CheckSignature(){} // RVA: 0x7FFAF8696D90
        public void CompareIssuerSerial(){} // RVA: 0x7FFAF86973A0
        public void VerifySignature(){} // RVA: 0x7FFAF86974D0
        public void VerifyCounterSignature(){} // RVA: 0x7FFAF86980E0
        public void Reset(){} // RVA: 0x7FFAF8698D30
    }

    public class PrivateKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8698FC0
        public void get_RSA(){} // RVA: 0x7FFAF2D907C0
        public void DeriveKey(){} // RVA: 0x7FFAF8699090
        public void Decode(){} // RVA: 0x7FFAF8699390
        public void CreateFromFile(){} // RVA: 0x7FFAF86998D0 | overloaded x2
    }

}