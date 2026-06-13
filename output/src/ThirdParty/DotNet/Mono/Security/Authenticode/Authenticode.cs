// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Authenticode
// Classes: 3
// Methods: 24

namespace ThirdParty.DotNet.Mono.Security.Authenticode
{
    public class AuthenticodeBase
    {
        public byte[] RawData; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BE5AB0
        public void get_PEOffset(){} // RVA: 0x5BE5B40
        public void Open(){} // RVA: 0x5BE5C70 | overloaded x2
        public void Close(){} // RVA: 0x5BE5D40
        public void ReadFirstBlock(){} // RVA: 0x5BE5DC0
        public void ProcessFirstBlock(){} // RVA: 0x5BE5EA0
        public void GetSecurityEntry(){} // RVA: 0x5BE6290
        public void GetHash(){} // RVA: 0x5BE6360
    }

    public class AuthenticodeDeformatter
    {
        public string RSA; // 0x40
        public byte[] rawdata; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BE6B00 | overloaded x2
        public void set_RawData(){} // RVA: 0x5BE6CE0
        public void get_SigningCertificate(){} // RVA: 0x3A5590
        public void CheckSignature(){} // RVA: 0x5BE6D90
        public void CompareIssuerSerial(){} // RVA: 0x5BE73A0
        public void VerifySignature(){} // RVA: 0x5BE74D0
        public void VerifyCounterSignature(){} // RVA: 0x5BE80E0
        public void Reset(){} // RVA: 0x5BE8D30
    }

    public class PrivateKey
    {
        public bool encrypted; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BE8FC0
        public void get_RSA(){} // RVA: 0x2E07C0
        public void DeriveKey(){} // RVA: 0x5BE9090
        public void Decode(){} // RVA: 0x5BE9390
        public void CreateFromFile(){} // RVA: 0x5BE98D0 | overloaded x2
    }

}