// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.X509
// Classes: 12
// Methods: 133

namespace ThirdParty.DotNet.Mono.Security.X509
{
    public class PKCS12 : Object
    {
        public object _password;
        public object _keyBags;
        public object _secretBags;
        public object _certs;
        public object _keyBagsChanged;
        public object _secretBagsChanged;
        public object _certsChanged;
        public object _iterations;
        public object _safeBags;
        public object _rng;
        public object password_max_length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6633FF0
        public void Decode(){} // RVA: 0x6634040
        public void Finalize(){} // RVA: 0x6634AF0
        public void set_Password(){} // RVA: 0x6634BA0
        public void get_IterationCount(){} // RVA: 0xE9CE60
        public void set_IterationCount(){} // RVA: 0xEA1260
        public void get_Keys(){} // RVA: 0x6634E20
        public void get_Certificates(){} // RVA: 0x6635520
        public void get_RNG(){} // RVA: 0x6635990
        public void Compare(){} // RVA: 0x6635A10
        public void GetSymmetricAlgorithm(){} // RVA: 0x6635A90
        public void Decrypt(){} // RVA: 0x6636580
        public void Encrypt(){} // RVA: 0x66366C0
        public void GetExistingParameters(){} // RVA: 0x6636830
        public void AddPrivateKey(){} // RVA: 0x6636A90
        public void ReadSafeBag(){} // RVA: 0x6636DA0
        public void Pkcs8ShroudedKeyBagSafeBag(){} // RVA: 0x6637860
        public void CertificateSafeBag(){} // RVA: 0x6638670
        public void MAC(){} // RVA: 0x6639100
        public void GetBytes(){} // RVA: 0x6639370
        public void EncryptedContentInfo(){} // RVA: 0x663B6E0
        public void AddCertificate(){} // RVA: 0x663BE00
        public void RemoveCertificate(){} // RVA: 0x663C130
        public void CompareAsymmetricAlgorithm(){} // RVA: 0x663C7D0
        public void AddPkcs8ShroudedKeyBag(){} // RVA: 0x663C8D0
        public void Clone(){} // RVA: 0x663CCE0
        public void get_MaximumPasswordLength(){} // RVA: 0x663CDF0
        public void .cctor(){} // RVA: 0x663CE50
    }

    public class SafeBag : Object
    {
        public object _bagOID;
        public object _asn1;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_BagOID(){} // RVA: 0xB5DBF0
        public void get_ASN1(){} // RVA: 0xB465B0
    }

    public class X501 : Object
    {
        public object countryName;
        public object organizationName;
        public object organizationalUnitName;
        public object commonName;
        public object localityName;
        public object stateOrProvinceName;
        public object streetAddress;
        public object serialNumber;
        public object domainComponent;
        public object userid;
        public object email;
        public object dnQualifier;
        public object title;
        public object surname;
        public object givenName;
        public object initial;

        // ── Methods ──
        public void ToString(){} // RVA: 0x663DC40
        public void AppendEntry(){} // RVA: 0x663DE30
        public void GetAttributeFromOid(){} // RVA: 0x663E810
        public void IsOid(){} // RVA: 0x663F970
        public void ReadAttribute(){} // RVA: 0x663FA60
        public void IsHex(){} // RVA: 0x663FC10
        public void ReadHex(){} // RVA: 0x663FD90
        public void ReadEscaped(){} // RVA: 0x66400B0
        public void ReadQuoted(){} // RVA: 0x6640260
        public void ReadValue(){} // RVA: 0x66403D0
        public void FromString(){} // RVA: 0x6640690
        public void .cctor(){} // RVA: 0x6640990
    }

    public class X509Certificate : Object
    {
        public object decoder;
        public object m_encodedcert;
        public object m_from;
        public object m_until;
        public object issuer;
        public object m_issuername;
        public object m_keyalgo;
        public object m_keyalgoparams;
        public object subject;
        public object m_subject;
        public object m_publickey;
        public object signature;
        public object m_signaturealgo;
        public object m_signaturealgoparams;
        public object certhash;
        public object _rsa;
        public object _dsa;
        public object version;
        public object serialnumber;
        public object issuerUniqueID;
        public object subjectUniqueID;
        public object extensions;
        public object encoding_error;

        // ── Methods ──
        public void Parse(){} // RVA: 0x6642B90
        public void .ctor(){} // RVA: 0x6643550
        public void GetUnsignedBigInteger(){} // RVA: 0x6643680
        public void get_DSA(){} // RVA: 0x6643730
        public void set_DSA(){} // RVA: 0x6643C50
        public void get_Extensions(){} // RVA: 0xBAE3B0
        public void get_Hash(){} // RVA: 0x6643D20
        public void get_IssuerName(){} // RVA: 0xD05CA0
        public void get_KeyAlgorithm(){} // RVA: 0xBC1B30
        public void get_KeyAlgorithmParameters(){} // RVA: 0x6643F70
        public void set_KeyAlgorithmParameters(){} // RVA: 0xBBF900
        public void get_PublicKey(){} // RVA: 0x6643FF0
        public void get_RSA(){} // RVA: 0x6644070
        public void set_RSA(){} // RVA: 0x6644360
        public void get_RawData(){} // RVA: 0x6644420
        public void get_SerialNumber(){} // RVA: 0x66444A0
        public void get_Signature(){} // RVA: 0x6644530
        public void get_SubjectName(){} // RVA: 0xC0FFC0
        public void get_ValidFrom(){} // RVA: 0xB700F0
        public void get_ValidUntil(){} // RVA: 0xB70160
        public void get_Version(){} // RVA: 0x262A930
        public void get_IsCurrent(){} // RVA: 0x6644A40
        public void WasCurrent(){} // RVA: 0x6644B50
        public void VerifySignature(){} // RVA: 0x6644E80
        public void get_IsSelfSigned(){} // RVA: 0x6645080
        public void GetObjectData(){} // RVA: 0x6645150
        public void PEM(){} // RVA: 0x6645390
        public void .cctor(){} // RVA: 0x6645610
    }

    public class X509CertificateCollection : CollectionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66456C0
        public void get_Item(){} // RVA: 0x66456D0
        public void Add(){} // RVA: 0x6645770
        public void AddRange(){} // RVA: 0x6645800
        public void Contains(){} // RVA: 0x66458E0
        public void GetEnumerator(){} // RVA: 0x6645900
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x66459E0
        public void GetHashCode(){} // RVA: 0x1269730
        public void IndexOf(){} // RVA: 0x6645A10
        public void Compare(){} // RVA: 0x6641EE0
    }

    public class X509Chain : Object
    {
        public object roots;
        public object certs;
        public object _root;
        public object _chain;
        public object _status;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6645E70
        public void get_TrustAnchors(){} // RVA: 0x6645F10
        public void LoadCertificates(){} // RVA: 0x66460A0
        public void Build(){} // RVA: 0x66460C0
        public void Reset(){} // RVA: 0x6646570
        public void IsValid(){} // RVA: 0x6646690
        public void FindCertificateParent(){} // RVA: 0x6646800
        public void FindCertificateRoot(){} // RVA: 0x6646980
        public void IsTrusted(){} // RVA: 0x6646B90
        public void IsParent(){} // RVA: 0x6646BD0
    }

    public class X509Crl : Object
    {
        public object issuer;
        public object version;
        public object thisUpdate;
        public object nextUpdate;
        public object entries;
        public object signatureOID;
        public object signature;
        public object extensions;
        public object encoded;
        public object hash_value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6641400
        public void Parse(){} // RVA: 0x6641550
        public void get_Extensions(){} // RVA: 0xBBF8F0
        public void get_Hash(){} // RVA: 0x6641C10
        public void get_IssuerName(){} // RVA: 0xB5DBF0
        public void get_NextUpdate(){} // RVA: 0xB70160
        public void Compare(){} // RVA: 0x6641EE0
        public void GetCrlEntry(){} // RVA: 0x6641FE0
        public void VerifySignature(){} // RVA: 0x6642630
    }

    public class X509Extension : Object
    {
        public object extnOid;
        public object extnCritical;
        public object extnValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66470B0
        public void Decode(){} // RVA: 0xB43310
        public void Encode(){} // RVA: 0xB43310
        public void get_Oid(){} // RVA: 0xB5DBF0
        public void get_Critical(){} // RVA: 0xB5DD50
        public void get_Value(){} // RVA: 0x6647230
        public void Equals(){} // RVA: 0x6647270
        public void GetHashCode(){} // RVA: 0x1269730
        public void WriteLine(){} // RVA: 0x6647400
        public void ToString(){} // RVA: 0x6647650
    }

    public class X509ExtensionCollection : CollectionBase
    {
        public object readOnly;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6647780
        public void IndexOf(){} // RVA: 0x66478D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x66459E0
        public void get_Item(){} // RVA: 0x6647A60
    }

    public class X509Store : Object
    {
        public object _storePath;
        public object _certificates;
        public object _crls;
        public object _crl;
        public object _newFormat;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6647C90
        public void get_Certificates(){} // RVA: 0x6647D00
        public void get_Crls(){} // RVA: 0x6647D80
        public void Load(){} // RVA: 0x6647EA0
        public void LoadCertificate(){} // RVA: 0x6648020
        public void LoadCrl(){} // RVA: 0x6648090
        public void CheckStore(){} // RVA: 0x6648230
        public void BuildCertificatesCollection(){} // RVA: 0x6648290
        public void BuildCrlsCollection(){} // RVA: 0x6648470
    }

    public class X509StoreManager : Object
    {
        public object _userPath;
        public object _localMachinePath;
        public object _newUserPath;
        public object _newLocalMachinePath;
        public object _userStore;
        public object _machineStore;

        // ── Methods ──
        public void get_CurrentUserPath(){} // RVA: 0x66485D0
        public void get_LocalMachinePath(){} // RVA: 0x6648790
        public void get_NewCurrentUserPath(){} // RVA: 0x6648960
        public void get_NewLocalMachinePath(){} // RVA: 0x6648B30
        public void get_CurrentUser(){} // RVA: 0x6648D00
        public void get_LocalMachine(){} // RVA: 0x6648FF0
        public void get_TrustedRootCertificates(){} // RVA: 0x66492F0
    }

    public class X509Stores : Object
    {
        public object _storePath;
        public object _newFormat;
        public object _trusted;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x237A5A0
        public void get_TrustedRoot(){} // RVA: 0x66493B0
        public void Open(){} // RVA: 0x6649520
    }

}