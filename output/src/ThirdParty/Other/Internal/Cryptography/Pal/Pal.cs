// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Internal.Cryptography.Pal
// Classes: 1
// Methods: 5

namespace ThirdParty.Other.Internal.Cryptography.Pal
{
    public class CertificateData : ValueType
    {
        public byte[] RawData; // 0x10
        public byte[] SubjectPublicKeyInfo; // 0x18
        public int Version; // 0x20
        public byte[] SerialNumber; // 0x28
        public AlgorithmIdentifier TbsSignature; // 0x30
        public System.Security.Cryptography.X509Certificates.X500DistinguishedName Issuer; // 0x40
        public System.DateTime NotBefore; // 0x48
        public System.DateTime NotAfter; // 0x50
        public System.Security.Cryptography.X509Certificates.X500DistinguishedName Subject; // 0x58
        public AlgorithmIdentifier PublicKeyAlgorithm; // 0x60
        public byte[] PublicKey; // 0x70
        public byte[] IssuerUniqueId; // 0x78
        public byte[] SubjectUniqueId; // 0x80
        public System.Collections.Generic.List`1<System.Security.Cryptography.X509Certificates.X509Extension> Extensions; // 0x88
        public AlgorithmIdentifier SignatureAlgorithm; // 0x90
        public byte[] SignatureValue; // 0xA0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9384420
        public void GetNameInfo(){} // RVA: 0x7FFAC9384F80
        public void GetSimpleNameInfo(){} // RVA: 0x7FFAC9385540
        public void FindAltNameMatch(){} // RVA: 0x7FFAC93859A0
        public void ReadReverseRdns(){} // RVA: 0x7FFAC9385BA0
    }

}