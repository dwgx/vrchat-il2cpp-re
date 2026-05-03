// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Authenticode
// Classes: 3
// Methods: 24

namespace ThirdParty.DotNet.Mono.Security.Authenticode
{
    public class AuthenticodeBase : Object
    {
        public byte[] fileblock; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86726900
        public void get_PEOffset(){} // RVA: 0x7FFE86726990
        public void Open(){} // RVA: 0x7FFE86726AC0 | overloaded x2
        public void Close(){} // RVA: 0x7FFE86726B90
        public void ReadFirstBlock(){} // RVA: 0x7FFE86726C10
        public void ProcessFirstBlock(){} // RVA: 0x7FFE86726CF0
        public void GetSecurityEntry(){} // RVA: 0x7FFE867270E0
        public void GetHash(){} // RVA: 0x7FFE867271B0
    }

    public class AuthenticodeDeformatter : AuthenticodeBase
    {
        public string filename; // 0x40
        public byte[] rawdata; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86727950 | overloaded x2
        public void set_RawData(){} // RVA: 0x7FFE86727B30
        public void get_SigningCertificate(){} // RVA: 0x7FFE811C3590
        public void CheckSignature(){} // RVA: 0x7FFE86727BE0
        public void CompareIssuerSerial(){} // RVA: 0x7FFE867281F0
        public void VerifySignature(){} // RVA: 0x7FFE86728320
        public void VerifyCounterSignature(){} // RVA: 0x7FFE86728F30
        public void Reset(){} // RVA: 0x7FFE86729B80
    }

    public class PrivateKey : Object
    {
        public bool encrypted; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86729E10
        public void get_RSA(){} // RVA: 0x7FFE810FE7C0
        public void DeriveKey(){} // RVA: 0x7FFE86729EE0
        public void Decode(){} // RVA: 0x7FFE8672A1E0
        public void CreateFromFile(){} // RVA: 0x7FFE8672A720 | overloaded x2
    }

}