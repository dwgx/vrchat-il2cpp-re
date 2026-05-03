// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.X509
// Classes: 13
// Methods: 146

namespace ThirdParty.DotNet.Mono.Security.X509
{
    public class PKCS12 : Object
    {
        public byte[] _password; // 0x10
        public System.Collections.ArrayList _keyBags; // 0x18
        public System.Collections.ArrayList _secretBags; // 0x20
        public Mono.Security.X509.X509CertificateCollection _certs; // 0x28
        public bool _keyBagsChanged; // 0x30
        public bool _secretBagsChanged; // 0x31

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866FC3C0 | overloaded x3
        public void Decode(){} // RVA: 0x7FFE866FC410
        public void Finalize(){} // RVA: 0x7FFE866FCEC0
        public void set_Password(){} // RVA: 0x7FFE866FCF70
        public void get_IterationCount(){} // RVA: 0x7FFE82447220
        public void set_IterationCount(){} // RVA: 0x7FFE82443340
        public void get_Keys(){} // RVA: 0x7FFE866FD1D0
        public void get_Certificates(){} // RVA: 0x7FFE866FD900
        public void get_RNG(){} // RVA: 0x7FFE866FDD80
        public void Compare(){} // RVA: 0x7FFE866FDE00
        public void GetSymmetricAlgorithm(){} // RVA: 0x7FFE866FDE80
        public void Decrypt(){} // RVA: 0x7FFE866FE970 | overloaded x2
        public void Encrypt(){} // RVA: 0x7FFE866FEAB0
        public void GetExistingParameters(){} // RVA: 0x7FFE866FEC20
        public void AddPrivateKey(){} // RVA: 0x7FFE866FEEA0
        public void ReadSafeBag(){} // RVA: 0x7FFE866FF1A0
        public void Pkcs8ShroudedKeyBagSafeBag(){} // RVA: 0x7FFE866FFC60
        public void CertificateSafeBag(){} // RVA: 0x7FFE86700A90
        public void MAC(){} // RVA: 0x7FFE86701540
        public void GetBytes(){} // RVA: 0x7FFE867017B0
        public void EncryptedContentInfo(){} // RVA: 0x7FFE86703C00
        public void AddCertificate(){} // RVA: 0x7FFE86704320 | overloaded x2
        public void RemoveCertificate(){} // RVA: 0x7FFE86704660 | overloaded x2
        public void CompareAsymmetricAlgorithm(){} // RVA: 0x7FFE86704D00
        public void AddPkcs8ShroudedKeyBag(){} // RVA: 0x7FFE86704E00
        public void Clone(){} // RVA: 0x7FFE86705210
        public void get_MaximumPasswordLength(){} // RVA: 0x7FFE86705320
        public void .cctor(){} // RVA: 0x7FFE86705380
    }

    public class SafeBag : Object
    {
        public string _bagOID; // 0x10
        public Mono.Security.ASN1 _asn1; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void get_BagOID(){} // RVA: 0x7FFE81116380
        public void get_ASN1(){} // RVA: 0x7FFE810FE7C0
    }

    public class X501 : Object
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE86706140 | overloaded x2
        public void AppendEntry(){} // RVA: 0x7FFE86706330
        public void GetAttributeFromOid(){} // RVA: 0x7FFE86706D10
        public void IsOid(){} // RVA: 0x7FFE86707E70
        public void ReadAttribute(){} // RVA: 0x7FFE86707F60
        public void IsHex(){} // RVA: 0x7FFE86708110
        public void ReadHex(){} // RVA: 0x7FFE86708270
        public void ReadEscaped(){} // RVA: 0x7FFE86708580
        public void ReadQuoted(){} // RVA: 0x7FFE86708730
        public void ReadValue(){} // RVA: 0x7FFE867088A0
        public void FromString(){} // RVA: 0x7FFE86708B70
        public void .cctor(){} // RVA: 0x7FFE86708E80
    }

    public class X509Certificate : Object
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
        public void Parse(){} // RVA: 0x7FFE8670B040
        public void .ctor(){} // RVA: 0x7FFE8670B9E0
        public void GetUnsignedBigInteger(){} // RVA: 0x7FFE8670BB10
        public void get_DSA(){} // RVA: 0x7FFE8670BBC0
        public void set_DSA(){} // RVA: 0x7FFE8670C0F0
        public void get_Extensions(){} // RVA: 0x7FFE811660B0
        public void get_Hash(){} // RVA: 0x7FFE8670C1C0
        public void get_IssuerName(){} // RVA: 0x7FFE8143BA80
        public void get_KeyAlgorithm(){} // RVA: 0x7FFE81178740
        public void get_KeyAlgorithmParameters(){} // RVA: 0x7FFE8670C410
        public void set_KeyAlgorithmParameters(){} // RVA: 0x7FFE81176740
        public void get_PublicKey(){} // RVA: 0x7FFE8670C490
        public void get_RSA(){} // RVA: 0x7FFE8670C510
        public void set_RSA(){} // RVA: 0x7FFE8670C7F0
        public void get_RawData(){} // RVA: 0x7FFE8670C8B0
        public void get_SerialNumber(){} // RVA: 0x7FFE8670C930
        public void get_Signature(){} // RVA: 0x7FFE8670C9C0
        public void get_SubjectName(){} // RVA: 0x7FFE811C3500
        public void get_ValidFrom(){} // RVA: 0x7FFE811290C0
        public void get_ValidUntil(){} // RVA: 0x7FFE81129130
        public void get_Version(){} // RVA: 0x7FFE82B06A40
        public void get_IsCurrent(){} // RVA: 0x7FFE8670CED0
        public void WasCurrent(){} // RVA: 0x7FFE8670CFE0
        public void VerifySignature(){} // RVA: 0x7FFE8670D310 | overloaded x3
        public void get_IsSelfSigned(){} // RVA: 0x7FFE8670D500
        public void GetObjectData(){} // RVA: 0x7FFE8670D5D0
        public void PEM(){} // RVA: 0x7FFE8670D810
        public void .cctor(){} // RVA: 0x7FFE8670DA90
    }

    public class X509CertificateCollection : CollectionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8670DB40
        public void get_Item(){} // RVA: 0x7FFE8670DB50
        public void Add(){} // RVA: 0x7FFE8670DBF0
        public void AddRange(){} // RVA: 0x7FFE8670DC80
        public void Contains(){} // RVA: 0x7FFE8670DD60
        public void GetEnumerator(){} // RVA: 0x7FFE8670DD80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8670DE60
        public void GetHashCode(){} // RVA: 0x7FFE8170B620
        public void IndexOf(){} // RVA: 0x7FFE8670DE90
        public void Compare(){} // RVA: 0x7FFE8670A3D0
    }

    public class X509Chain : Object
    {
        public Mono.Security.X509.X509CertificateCollection roots; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8670E2F0
        public void get_TrustAnchors(){} // RVA: 0x7FFE8670E390
        public void LoadCertificates(){} // RVA: 0x7FFE8670E520
        public void Build(){} // RVA: 0x7FFE8670E540
        public void Reset(){} // RVA: 0x7FFE8670EA10
        public void IsValid(){} // RVA: 0x7FFE8670EB30
        public void FindCertificateParent(){} // RVA: 0x7FFE8670ECA0
        public void FindCertificateRoot(){} // RVA: 0x7FFE8670EE40
        public void IsTrusted(){} // RVA: 0x7FFE8670F070
        public void IsParent(){} // RVA: 0x7FFE8670F0B0
    }

    public class X509Crl : Object
    {
        public string issuer; // 0x10
        public byte version; // 0x18
        public System.DateTime thisUpdate; // 0x20
        public System.DateTime nextUpdate; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867098F0
        public void Parse(){} // RVA: 0x7FFE86709A40
        public void get_Extensions(){} // RVA: 0x7FFE81176730
        public void get_Hash(){} // RVA: 0x7FFE8670A100
        public void get_IssuerName(){} // RVA: 0x7FFE81116380
        public void get_NextUpdate(){} // RVA: 0x7FFE81129130
        public void Compare(){} // RVA: 0x7FFE8670A3D0
        public void GetCrlEntry(){} // RVA: 0x7FFE8670A4D0 | overloaded x2
        public void VerifySignature(){} // RVA: 0x7FFE8670AB00 | overloaded x3
    }

    public class X509Extension : Object
    {
        public string extnOid; // 0x10
        public bool extnCritical; // 0x18
        public Mono.Security.ASN1 extnValue; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8670F590 | overloaded x2
        public void Decode(){} // RVA: 0x7FFE810FB310
        public void Encode(){} // RVA: 0x7FFE810FB310
        public void get_Oid(){} // RVA: 0x7FFE81116380
        public void get_Critical(){} // RVA: 0x7FFE811164E0
        public void get_Value(){} // RVA: 0x7FFE8670F700
        public void Equals(){} // RVA: 0x7FFE8670F740
        public void GetHashCode(){} // RVA: 0x7FFE8170B620
        public void WriteLine(){} // RVA: 0x7FFE8670F8D0
        public void ToString(){} // RVA: 0x7FFE8670FB10
    }

    public class X509ExtensionCollection : CollectionBase
    {
        public bool readOnly; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8670FC40 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFE8670FD90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8670DE60
        public void get_Item(){} // RVA: 0x7FFE8670FF20
    }

    public class X509Store : Object
    {
        public string _storePath; // 0x10
        public Mono.Security.X509.X509CertificateCollection _certificates; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86710150
        public void get_Certificates(){} // RVA: 0x7FFE867101C0
        public void get_Crls(){} // RVA: 0x7FFE86710240
        public void Load(){} // RVA: 0x7FFE86710360
        public void LoadCertificate(){} // RVA: 0x7FFE867104D0
        public void LoadCrl(){} // RVA: 0x7FFE86710540
        public void CheckStore(){} // RVA: 0x7FFE867106E0
        public void BuildCertificatesCollection(){} // RVA: 0x7FFE86710740
        public void BuildCrlsCollection(){} // RVA: 0x7FFE86710920
    }

    public class X509StoreManager : Object
    {
        public string _userPath;
        public string _localMachinePath; // 0x8
        public string _newUserPath; // 0x10
        public string _newLocalMachinePath; // 0x18
        public Mono.Security.X509.X509Stores _userStore; // 0x20
        public Mono.Security.X509.X509Stores _machineStore; // 0x28
        public object field_6; // 0x44

        // ── Methods ──
        public void get_CurrentUserPath(){} // RVA: 0x7FFE86710A80
        public void get_LocalMachinePath(){} // RVA: 0x7FFE86710C40
        public void get_NewCurrentUserPath(){} // RVA: 0x7FFE86710E10
        public void get_NewLocalMachinePath(){} // RVA: 0x7FFE86710FE0
        public void get_CurrentUser(){} // RVA: 0x7FFE867111B0
        public void get_LocalMachine(){} // RVA: 0x7FFE867114A0
        public void get_TrustedRootCertificates(){} // RVA: 0x7FFE867117A0
    }

    public class X509Stores : Object
    {
        public string _storePath; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828378F0
        public void get_TrustedRoot(){} // RVA: 0x7FFE86711860
        public void Open(){} // RVA: 0x7FFE867119D0
    }

    public class X520 : Object
    {
    }

}