// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.X509
// Classes: 13
// Methods: 146

namespace ThirdParty.DotNet.Mono.Security.X509
{
    public class PKCS12
    {
        public byte[] _password; // 0x10
        public System.Collections.ArrayList _keyBags; // 0x18
        public System.Collections.ArrayList _secretBags; // 0x20
        public Mono.Security.X509.X509CertificateCollection _certs; // 0x28
        public bool _keyBagsChanged; // 0x30
        public bool _secretBagsChanged; // 0x31

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BBB570 | overloaded x3
        public void Decode(){} // RVA: 0x5BBB5C0
        public void Finalize(){} // RVA: 0x5BBC070
        public void set_Password(){} // RVA: 0x5BBC120
        public void get_IterationCount(){} // RVA: 0x4C6670
        public void set_IterationCount(){} // RVA: 0x4C5F20
        public void get_Keys(){} // RVA: 0x5BBC380
        public void get_Certificates(){} // RVA: 0x5BBCAB0
        public void get_RNG(){} // RVA: 0x5BBCF30
        public void Compare(){} // RVA: 0x5BBCFB0
        public void GetSymmetricAlgorithm(){} // RVA: 0x5BBD030
        public void Decrypt(){} // RVA: 0x5BBDB20 | overloaded x2
        public void Encrypt(){} // RVA: 0x5BBDC60
        public void GetExistingParameters(){} // RVA: 0x5BBDDD0
        public void AddPrivateKey(){} // RVA: 0x5BBE050
        public void ReadSafeBag(){} // RVA: 0x5BBE350
        public void Pkcs8ShroudedKeyBagSafeBag(){} // RVA: 0x5BBEE10
        public void CertificateSafeBag(){} // RVA: 0x5BBFC40
        public void MAC(){} // RVA: 0x5BC06F0
        public void GetBytes(){} // RVA: 0x5BC0960
        public void EncryptedContentInfo(){} // RVA: 0x5BC2DB0
        public void AddCertificate(){} // RVA: 0x5BC34D0 | overloaded x2
        public void RemoveCertificate(){} // RVA: 0x5BC3810 | overloaded x2
        public void CompareAsymmetricAlgorithm(){} // RVA: 0x5BC3EB0
        public void AddPkcs8ShroudedKeyBag(){} // RVA: 0x5BC3FB0
        public void Clone(){} // RVA: 0x5BC43C0
        public void get_MaximumPasswordLength(){} // RVA: 0x5BC44D0
        public void .cctor(){} // RVA: 0x5BC4530
    }

    public class SafeBag
    {
        public string HashName; // 0x10
        public Mono.Security.ASN1 IterationCount; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void get_BagOID(){} // RVA: 0x2F8380
        public void get_ASN1(){} // RVA: 0x2E07C0
    }

    public class X501
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x5BC52F0 | overloaded x2
        public void AppendEntry(){} // RVA: 0x5BC54E0
        public void GetAttributeFromOid(){} // RVA: 0x5BC5EC0
        public void IsOid(){} // RVA: 0x5BC7020
        public void ReadAttribute(){} // RVA: 0x5BC7110
        public void IsHex(){} // RVA: 0x5BC72C0
        public void ReadHex(){} // RVA: 0x5BC7420
        public void ReadEscaped(){} // RVA: 0x5BC7730
        public void ReadQuoted(){} // RVA: 0x5BC78E0
        public void ReadValue(){} // RVA: 0x5BC7A50
        public void FromString(){} // RVA: 0x5BC7D20
        public void .cctor(){} // RVA: 0x5BC8030
    }

    public class X509Certificate
    {
        public Mono.Security.ASN1 decoder; // 0x10
        public byte[] m_encodedcert; // 0x18
        public System.DateTime m_from; // 0x20
        public System.DateTime m_until; // 0x28
        public Mono.Security.ASN1 issuer; // 0x30
        public string m_issuername; // 0x38
        public string m_keyalgo; // 0x40
        public byte[] m_keyalgoparams; // 0x48
        public Mono.Security.ASN1 subject; // 0x50
        public string m_subject; // 0x58
        public byte[] m_publickey; // 0x60
        public byte[] signature; // 0x68
        public string m_signaturealgo; // 0x70
        public byte[] m_signaturealgoparams; // 0x78
        public byte[] certhash; // 0x80
        public System.Security.Cryptography.RSA _rsa; // 0x88
        public System.Security.Cryptography.DSA _dsa; // 0x90

        // ── Methods ──
        public void Parse(){} // RVA: 0x5BCA1F0
        public void .ctor(){} // RVA: 0x5BCAB90
        public void GetUnsignedBigInteger(){} // RVA: 0x5BCACC0
        public void get_DSA(){} // RVA: 0x5BCAD70
        public void set_DSA(){} // RVA: 0x5BCB2A0
        public void get_Extensions(){} // RVA: 0x3480B0
        public void get_Hash(){} // RVA: 0x5BCB370
        public void get_IssuerName(){} // RVA: 0x4976A0
        public void get_KeyAlgorithm(){} // RVA: 0x35A740
        public void get_KeyAlgorithmParameters(){} // RVA: 0x5BCB5C0
        public void set_KeyAlgorithmParameters(){} // RVA: 0x358740
        public void get_PublicKey(){} // RVA: 0x5BCB640
        public void get_RSA(){} // RVA: 0x5BCB6C0
        public void set_RSA(){} // RVA: 0x5BCB9A0
        public void get_RawData(){} // RVA: 0x5BCBA60
        public void get_SerialNumber(){} // RVA: 0x5BCBAE0
        public void get_Signature(){} // RVA: 0x5BCBB70
        public void get_SubjectName(){} // RVA: 0x3A5500
        public void get_ValidFrom(){} // RVA: 0x30B0C0
        public void get_ValidUntil(){} // RVA: 0x30B130
        public void get_Version(){} // RVA: 0x1D76570
        public void get_IsCurrent(){} // RVA: 0x5BCC080
        public void WasCurrent(){} // RVA: 0x5BCC190
        public void VerifySignature(){} // RVA: 0x5BCC4C0 | overloaded x3
        public void get_IsSelfSigned(){} // RVA: 0x5BCC6B0
        public void GetObjectData(){} // RVA: 0x5BCC780
        public void PEM(){} // RVA: 0x5BCC9C0
        public void .cctor(){} // RVA: 0x5BCCC40
    }

    public class X509CertificateCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BCCCF0
        public void get_Item(){} // RVA: 0x5BCCD00
        public void Add(){} // RVA: 0x5BCCDA0
        public void AddRange(){} // RVA: 0x5BCCE30
        public void Contains(){} // RVA: 0x5BCCF10
        public void GetEnumerator(){} // RVA: 0x5BCCF30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x5BCD010
        public void GetHashCode(){} // RVA: 0x99E0E0
        public void IndexOf(){} // RVA: 0x5BCD040
        public void Compare(){} // RVA: 0x5BC9580
    }

    public class X509Chain
    {
        public Mono.Security.X509.X509CertificateCollection roots; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BCD4A0
        public void get_TrustAnchors(){} // RVA: 0x5BCD540
        public void LoadCertificates(){} // RVA: 0x5BCD6D0
        public void Build(){} // RVA: 0x5BCD6F0
        public void Reset(){} // RVA: 0x5BCDBC0
        public void IsValid(){} // RVA: 0x5BCDCE0
        public void FindCertificateParent(){} // RVA: 0x5BCDE50
        public void FindCertificateRoot(){} // RVA: 0x5BCDFF0
        public void IsTrusted(){} // RVA: 0x5BCE220
        public void IsParent(){} // RVA: 0x5BCE260
    }

    public class X509Crl
    {
        public string DSA; // 0x10
        public byte Extensions; // 0x18
        public System.DateTime Hash; // 0x20
        public System.DateTime IssuerName; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BC8AA0
        public void Parse(){} // RVA: 0x5BC8BF0
        public void get_Extensions(){} // RVA: 0x358730
        public void get_Hash(){} // RVA: 0x5BC92B0
        public void get_IssuerName(){} // RVA: 0x2F8380
        public void get_NextUpdate(){} // RVA: 0x30B130
        public void Compare(){} // RVA: 0x5BC9580
        public void GetCrlEntry(){} // RVA: 0x5BC9680 | overloaded x2
        public void VerifySignature(){} // RVA: 0x5BC9CB0 | overloaded x3
    }

    public class X509Extension
    {
        public string extnOid; // 0x10
        public bool extnCritical; // 0x18
        public Mono.Security.ASN1 extnValue; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BCE740 | overloaded x2
        public void Decode(){} // RVA: 0x2DD310
        public void Encode(){} // RVA: 0x2DD310
        public void get_Oid(){} // RVA: 0x2F8380
        public void get_Critical(){} // RVA: 0x2F84E0
        public void get_Value(){} // RVA: 0x5BCE8B0
        public void Equals(){} // RVA: 0x5BCE8F0
        public void GetHashCode(){} // RVA: 0x99E0E0
        public void WriteLine(){} // RVA: 0x5BCEA80
        public void ToString(){} // RVA: 0x5BCECC0
    }

    public class X509ExtensionCollection
    {
        public bool readOnly; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BCEDF0 | overloaded x2
        public void IndexOf(){} // RVA: 0x5BCEF40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x5BCD010
        public void get_Item(){} // RVA: 0x5BCF0D0
    }

    public class X509Store
    {
        public string CurrentUserPath; // 0x10
        public Mono.Security.X509.X509CertificateCollection LocalMachinePath; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BCF300
        public void get_Certificates(){} // RVA: 0x5BCF370
        public void get_Crls(){} // RVA: 0x5BCF3F0
        public void Load(){} // RVA: 0x5BCF510
        public void LoadCertificate(){} // RVA: 0x5BCF680
        public void LoadCrl(){} // RVA: 0x5BCF6F0
        public void CheckStore(){} // RVA: 0x5BCF890
        public void BuildCertificatesCollection(){} // RVA: 0x5BCF8F0
        public void BuildCrlsCollection(){} // RVA: 0x5BCFAD0
    }

    public class X509StoreManager
    {
        public string TrustedRoot;
        public string `; // 0x8
        public string set_Value; // 0x10
        public string _newLocalMachinePath; // 0x18
        public Mono.Security.X509.X509Stores _userStore; // 0x20
        public Mono.Security.X509.X509Stores _machineStore; // 0x28

        // ── Methods ──
        public void get_CurrentUserPath(){} // RVA: 0x5BCFC30
        public void get_LocalMachinePath(){} // RVA: 0x5BCFDF0
        public void get_NewCurrentUserPath(){} // RVA: 0x5BCFFC0
        public void get_NewLocalMachinePath(){} // RVA: 0x5BD0190
        public void get_CurrentUser(){} // RVA: 0x5BD0360
        public void get_LocalMachine(){} // RVA: 0x5BD0650
        public void get_TrustedRootCertificates(){} // RVA: 0x5BD0950
    }

    public class X509Stores
    {
        public string Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AB41A0
        public void get_TrustedRoot(){} // RVA: 0x5BD0A10
        public void Open(){} // RVA: 0x5BD0B80
    }

    public class X520
    {
    }

}