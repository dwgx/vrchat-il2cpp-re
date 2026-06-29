// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.X509
// Classes: 12
// Methods: 133

namespace ThirdParty.DotNet.Mono.Security.X509
{
    public class PKCS12 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9A91C0
        public void Decode(){} // RVA: 0x7AD9A9210
        public void Finalize(){} // RVA: 0x7AD9A9CC0
        public void set_Password(){} // RVA: 0x7AD9A9D70
        public void get_IterationCount(){} // RVA: 0x7A82C2070
        public void set_IterationCount(){} // RVA: 0x7A82C0430
        public void get_Keys(){} // RVA: 0x7AD9A9FF0
        public void get_Certificates(){} // RVA: 0x7AD9AA6F0
        public void get_RNG(){} // RVA: 0x7AD9AAB60
        public void Compare(){} // RVA: 0x7AD9AABE0
        public void GetSymmetricAlgorithm(){} // RVA: 0x7AD9AAC60
        public void Decrypt(){} // RVA: 0x7AD9AB750
        public void Encrypt(){} // RVA: 0x7AD9AB890
        public void GetExistingParameters(){} // RVA: 0x7AD9ABA00
        public void AddPrivateKey(){} // RVA: 0x7AD9ABC60
        public void ReadSafeBag(){} // RVA: 0x7AD9ABF70
        public void Pkcs8ShroudedKeyBagSafeBag(){} // RVA: 0x7AD9ACA30
        public void CertificateSafeBag(){} // RVA: 0x7AD9AD850
        public void MAC(){} // RVA: 0x7AD9AE2F0
        public void GetBytes(){} // RVA: 0x7AD9AE560
        public void EncryptedContentInfo(){} // RVA: 0x7AD9B08D0
        public void AddCertificate(){} // RVA: 0x7AD9B0FF0
        public void RemoveCertificate(){} // RVA: 0x7AD9B1320
        public void CompareAsymmetricAlgorithm(){} // RVA: 0x7AD9B19C0
        public void AddPkcs8ShroudedKeyBag(){} // RVA: 0x7AD9B1AC0
        public void Clone(){} // RVA: 0x7AD9B1ED0
        public void get_MaximumPasswordLength(){} // RVA: 0x7AD9B1FE0
        public void .cctor(){} // RVA: 0x7AD9B2040
    }

    public class SafeBag : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_BagOID(){} // RVA: 0x7A80F2570
        public void get_ASN1(){} // RVA: 0x7A80DA7B0
    }

    public class X501 : Object
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7AD9B2E30
        public void AppendEntry(){} // RVA: 0x7AD9B3020
        public void GetAttributeFromOid(){} // RVA: 0x7AD9B3A00
        public void IsOid(){} // RVA: 0x7AD9B4B60
        public void ReadAttribute(){} // RVA: 0x7AD9B4C50
        public void IsHex(){} // RVA: 0x7AD9B4E00
        public void ReadHex(){} // RVA: 0x7AD9B4F60
        public void ReadEscaped(){} // RVA: 0x7AD9B5260
        public void ReadQuoted(){} // RVA: 0x7AD9B5410
        public void ReadValue(){} // RVA: 0x7AD9B5580
        public void FromString(){} // RVA: 0x7AD9B5850
        public void .cctor(){} // RVA: 0x7AD9B5B60
    }

    public class X509Certificate : Object
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x7AD9B7D60
        public void .ctor(){} // RVA: 0x7AD9B8720
        public void GetUnsignedBigInteger(){} // RVA: 0x7AD9B8850
        public void get_DSA(){} // RVA: 0x7AD9B8900
        public void set_DSA(){} // RVA: 0x7AD9B8E20
        public void get_Extensions(){} // RVA: 0x7A8142680
        public void get_Hash(){} // RVA: 0x7AD9B8EF0
        public void get_IssuerName(){} // RVA: 0x7A8292C30
        public void get_KeyAlgorithm(){} // RVA: 0x7A8154D80
        public void get_KeyAlgorithmParameters(){} // RVA: 0x7AD9B9140
        public void set_KeyAlgorithmParameters(){} // RVA: 0x7A8152D90
        public void get_PublicKey(){} // RVA: 0x7AD9B91C0
        public void get_RSA(){} // RVA: 0x7AD9B9240
        public void set_RSA(){} // RVA: 0x7AD9B9530
        public void get_RawData(){} // RVA: 0x7AD9B95F0
        public void get_SerialNumber(){} // RVA: 0x7AD9B9670
        public void get_Signature(){} // RVA: 0x7AD9B9700
        public void get_SubjectName(){} // RVA: 0x7A81A0050
        public void get_ValidFrom(){} // RVA: 0x7A81052C0
        public void get_ValidUntil(){} // RVA: 0x7A8105330
        public void get_Version(){} // RVA: 0x7A9B79A20
        public void get_IsCurrent(){} // RVA: 0x7AD9B9C10
        public void WasCurrent(){} // RVA: 0x7AD9B9D20
        public void VerifySignature(){} // RVA: 0x7AD9BA050
        public void get_IsSelfSigned(){} // RVA: 0x7AD9BA250
        public void GetObjectData(){} // RVA: 0x7AD9BA320
        public void PEM(){} // RVA: 0x7AD9BA560
        public void .cctor(){} // RVA: 0x7AD9BA7E0
    }

    public class X509CertificateCollection : CollectionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9BA890
        public void get_Item(){} // RVA: 0x7AD9BA8A0
        public void Add(){} // RVA: 0x7AD9BA940
        public void AddRange(){} // RVA: 0x7AD9BA9D0
        public void Contains(){} // RVA: 0x7AD9BAAB0
        public void GetEnumerator(){} // RVA: 0x7AD9BAAD0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AD9BABB0
        public void GetHashCode(){} // RVA: 0x7A8738190
        public void IndexOf(){} // RVA: 0x7AD9BABE0
        public void Compare(){} // RVA: 0x7AD9B70B0
    }

    public class X509Chain : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9BB040
        public void get_TrustAnchors(){} // RVA: 0x7AD9BB0E0
        public void LoadCertificates(){} // RVA: 0x7AD9BB270
        public void Build(){} // RVA: 0x7AD9BB290
        public void Reset(){} // RVA: 0x7AD9BB740
        public void IsValid(){} // RVA: 0x7AD9BB860
        public void FindCertificateParent(){} // RVA: 0x7AD9BB9D0
        public void FindCertificateRoot(){} // RVA: 0x7AD9BBB50
        public void IsTrusted(){} // RVA: 0x7AD9BBD60
        public void IsParent(){} // RVA: 0x7AD9BBDA0
    }

    public class X509Crl : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9B65D0
        public void Parse(){} // RVA: 0x7AD9B6720
        public void get_Extensions(){} // RVA: 0x7A8152D80
        public void get_Hash(){} // RVA: 0x7AD9B6DE0
        public void get_IssuerName(){} // RVA: 0x7A80F2570
        public void get_NextUpdate(){} // RVA: 0x7A8105330
        public void Compare(){} // RVA: 0x7AD9B70B0
        public void GetCrlEntry(){} // RVA: 0x7AD9B71B0
        public void VerifySignature(){} // RVA: 0x7AD9B7800
    }

    public class X509Extension : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9BC280
        public void Decode(){} // RVA: 0x7A80D7310
        public void Encode(){} // RVA: 0x7A80D7310
        public void get_Oid(){} // RVA: 0x7A80F2570
        public void get_Critical(){} // RVA: 0x7A80F26D0
        public void get_Value(){} // RVA: 0x7AD9BC400
        public void Equals(){} // RVA: 0x7AD9BC440
        public void GetHashCode(){} // RVA: 0x7A8738190
        public void WriteLine(){} // RVA: 0x7AD9BC5D0
        public void ToString(){} // RVA: 0x7AD9BC820
    }

    public class X509ExtensionCollection : CollectionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9BC950
        public void IndexOf(){} // RVA: 0x7AD9BCAA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AD9BABB0
        public void get_Item(){} // RVA: 0x7AD9BCC30
    }

    public class X509Store : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9BCE60
        public void get_Certificates(){} // RVA: 0x7AD9BCED0
        public void get_Crls(){} // RVA: 0x7AD9BCF50
        public void Load(){} // RVA: 0x7AD9BD070
        public void LoadCertificate(){} // RVA: 0x7AD9BD1F0
        public void LoadCrl(){} // RVA: 0x7AD9BD260
        public void CheckStore(){} // RVA: 0x7AD9BD400
        public void BuildCertificatesCollection(){} // RVA: 0x7AD9BD460
        public void BuildCrlsCollection(){} // RVA: 0x7AD9BD640
    }

    public class X509StoreManager : Object
    {
        // ── Methods ──
        public void get_CurrentUserPath(){} // RVA: 0x7AD9BD7A0
        public void get_LocalMachinePath(){} // RVA: 0x7AD9BD960
        public void get_NewCurrentUserPath(){} // RVA: 0x7AD9BDB30
        public void get_NewLocalMachinePath(){} // RVA: 0x7AD9BDD00
        public void get_CurrentUser(){} // RVA: 0x7AD9BDED0
        public void get_LocalMachine(){} // RVA: 0x7AD9BE1C0
        public void get_TrustedRootCertificates(){} // RVA: 0x7AD9BE4C0
    }

    public class X509Stores : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A986DB30
        public void get_TrustedRoot(){} // RVA: 0x7AD9BE580
        public void Open(){} // RVA: 0x7AD9BE6F0
    }

}