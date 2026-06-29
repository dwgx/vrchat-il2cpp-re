// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Internal.Cryptography.Pal
// Classes: 1
// Methods: 5

namespace ThirdParty.Other.Internal.Cryptography.Pal
{
    public class CertificateData : ValueType
    {
        public object RawData;
        public object SubjectPublicKeyInfo;
        public object Version;
        public object SerialNumber;
        public object TbsSignature;
        public object Issuer;
        public object NotBefore;
        public object NotAfter;
        public object Subject;
        public object PublicKeyAlgorithm;
        public object PublicKey;
        public object IssuerUniqueId;
        public object SubjectUniqueId;
        public object Extensions;
        public object SignatureAlgorithm;
        public object SignatureValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x91D400
        public void GetNameInfo(){} // RVA: 0x91D410
        public void GetSimpleNameInfo(){} // RVA: 0x764DF00
        public void FindAltNameMatch(){} // RVA: 0x764E360
        public void ReadReverseRdns(){} // RVA: 0x764E560
    }

}