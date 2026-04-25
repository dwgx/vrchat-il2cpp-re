// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Authenticode
// Classes: 3
// Methods: 24

namespace ThirdParty.DotNet.Mono.Security.Authenticode
{
    public class AuthenticodeBase : Object
    {
        public byte[] PEOffset; // 0x10
        public System.IO.Stream fs; // 0x18
        public int blockNo; // 0x20
        public int blockLength; // 0x24
        public int peOffset; // 0x28
        public int dirSecurityOffset; // 0x2C
        public int dirSecuritySize; // 0x30
        public int coffSymbolTableOffset; // 0x34
        public bool pe64; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC837D000
        public void get_PEOffset(){} // RVA: 0x7FFAC837D090
        public void Open(){} // RVA: 0x7FFAC837D1C0 | overloaded x2
        public void Close(){} // RVA: 0x7FFAC837D290
        public void ReadFirstBlock(){} // RVA: 0x7FFAC837D310
        public void ProcessFirstBlock(){} // RVA: 0x7FFAC837D3F0
        public void GetSecurityEntry(){} // RVA: 0x7FFAC837D7E0
        public void GetHash(){} // RVA: 0x7FFAC837D8B0
    }

    public class AuthenticodeDeformatter : AuthenticodeBase
    {
        public string RawData; // 0x40
        public byte[] SigningCertificate; // 0x48
        public byte[] hash; // 0x50
        public Mono.Security.X509.X509CertificateCollection coll; // 0x58
        public Mono.Security.ASN1 signedHash; // 0x60
        public System.DateTime timestamp; // 0x68
        public Mono.Security.X509.X509Certificate signingCertificate; // 0x70
        public int reason; // 0x78
        public bool trustedRoot; // 0x7C
        public bool trustedTimestampRoot; // 0x7D
        public byte[] entry; // 0x80
        public Mono.Security.X509.X509Chain signerChain; // 0x88
        public Mono.Security.X509.X509Chain timestampChain; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC837E050 | overloaded x2
        public void set_RawData(){} // RVA: 0x7FFAC837E230
        public void get_SigningCertificate(){} // RVA: 0x7FFAC2FE9590
        public void CheckSignature(){} // RVA: 0x7FFAC837E2E0
        public void CompareIssuerSerial(){} // RVA: 0x7FFAC837E8F0
        public void VerifySignature(){} // RVA: 0x7FFAC837EA20
        public void VerifyCounterSignature(){} // RVA: 0x7FFAC837F630
        public void Reset(){} // RVA: 0x7FFAC8380280
    }

    public class PrivateKey : Object
    {
        public bool RSA; // 0x10
        public System.Security.Cryptography.RSA rsa; // 0x18
        public bool weak; // 0x20
        public int keyType; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8380510
        public void get_RSA(){} // RVA: 0x7FFAC2F247C0
        public void DeriveKey(){} // RVA: 0x7FFAC83805E0
        public void Decode(){} // RVA: 0x7FFAC83808E0
        public void CreateFromFile(){} // RVA: 0x7FFAC8380E20 | overloaded x2
    }

}