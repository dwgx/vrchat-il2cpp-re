// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Authenticode
// Classes: 3
// Methods: 21

namespace ThirdParty.DotNet.Mono.Security.Authenticode
{
    public class AuthenticodeBase : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9D3750
        public void get_PEOffset(){} // RVA: 0x7AD9D37E0
        public void Open(){} // RVA: 0x7AD9D3910
        public void Close(){} // RVA: 0x7AD9D39E0
        public void ReadFirstBlock(){} // RVA: 0x7AD9D3A60
        public void ProcessFirstBlock(){} // RVA: 0x7AD9D3B40
        public void GetSecurityEntry(){} // RVA: 0x7AD9D3F20
        public void GetHash(){} // RVA: 0x7AD9D3FF0
    }

    public class AuthenticodeDeformatter : AuthenticodeBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9D4780
        public void set_RawData(){} // RVA: 0x7AD9D4960
        public void get_SigningCertificate(){} // RVA: 0x7A81A00E0
        public void CheckSignature(){} // RVA: 0x7AD9D4A10
        public void CompareIssuerSerial(){} // RVA: 0x7AD9D5030
        public void VerifySignature(){} // RVA: 0x7AD9D5160
        public void VerifyCounterSignature(){} // RVA: 0x7AD9D5D00
        public void Reset(){} // RVA: 0x7AD9D6930
    }

    public class PrivateKey : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9D6BC0
        public void get_RSA(){} // RVA: 0x7A80DA7B0
        public void DeriveKey(){} // RVA: 0x7AD9D6C90
        public void Decode(){} // RVA: 0x7AD9D6F90
        public void CreateFromFile(){} // RVA: 0x7AD9D74D0
    }

}