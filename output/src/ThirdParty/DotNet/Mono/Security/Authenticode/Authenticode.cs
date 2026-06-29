// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Authenticode
// Classes: 3
// Methods: 21

namespace ThirdParty.DotNet.Mono.Security.Authenticode
{
    public class AuthenticodeBase : Object
    {
        public object fileblock;
        public object fs;
        public object blockNo;
        public object blockLength;
        public object peOffset;
        public object dirSecurityOffset;
        public object dirSecuritySize;
        public object coffSymbolTableOffset;
        public object pe64;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x665E550
        public void get_PEOffset(){} // RVA: 0x665E5E0
        public void Open(){} // RVA: 0x665E710
        public void Close(){} // RVA: 0x665E7E0
        public void ReadFirstBlock(){} // RVA: 0x665E860
        public void ProcessFirstBlock(){} // RVA: 0x665E930
        public void GetSecurityEntry(){} // RVA: 0x665ED00
        public void GetHash(){} // RVA: 0x665EDD0
    }

    public class AuthenticodeDeformatter : AuthenticodeBase
    {
        public object filename;
        public object rawdata;
        public object hash;
        public object coll;
        public object signedHash;
        public object timestamp;
        public object signingCertificate;
        public object reason;
        public object trustedRoot;
        public object trustedTimestampRoot;
        public object entry;
        public object signerChain;
        public object timestampChain;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x665F560
        public void set_RawData(){} // RVA: 0x665F740
        public void get_SigningCertificate(){} // RVA: 0xC10050
        public void CheckSignature(){} // RVA: 0x665F7F0
        public void CompareIssuerSerial(){} // RVA: 0x665FE10
        public void VerifySignature(){} // RVA: 0x665FF40
        public void VerifyCounterSignature(){} // RVA: 0x6660AE0
        public void Reset(){} // RVA: 0x6661710
    }

    public class PrivateKey : Object
    {
        public object encrypted;
        public object rsa;
        public object weak;
        public object keyType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66619A0
        public void get_RSA(){} // RVA: 0xB465B0
        public void DeriveKey(){} // RVA: 0x6661A70
        public void Decode(){} // RVA: 0x6661D70
        public void CreateFromFile(){} // RVA: 0x66622B0
    }

}