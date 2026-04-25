// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.X509
// Classes: 13
// Methods: 146

namespace ThirdParty.DotNet.Mono.Security.X509
{
    public class PKCS12 : Object
    {
        public byte[] Password; // 0x10
        public System.Collections.ArrayList IterationCount; // 0x18
        public System.Collections.ArrayList Keys; // 0x20
        public Mono.Security.X509.X509CertificateCollection Certificates; // 0x28
        public bool RNG; // 0x30
        public bool MaximumPasswordLength; // 0x31
        public bool _certsChanged; // 0x32
        public int _iterations; // 0x34
        public System.Collections.ArrayList _safeBags; // 0x38
        public System.Security.Cryptography.RandomNumberGenerator _rng; // 0x40
        public int password_max_length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8352AC0 | overloaded x3
        public void Decode(){} // RVA: 0x7FFAC8352B10
        public void Finalize(){} // RVA: 0x7FFAC83535C0
        public void set_Password(){} // RVA: 0x7FFAC8353670
        public void get_IterationCount(){} // RVA: 0x7FFAC3ADEDC0
        public void set_IterationCount(){} // RVA: 0x7FFAC416A6E0
        public void get_Keys(){} // RVA: 0x7FFAC83538D0
        public void get_Certificates(){} // RVA: 0x7FFAC8354000
        public void get_RNG(){} // RVA: 0x7FFAC8354480
        public void Compare(){} // RVA: 0x7FFAC8354500
        public void GetSymmetricAlgorithm(){} // RVA: 0x7FFAC8354580
        public void Decrypt(){} // RVA: 0x7FFAC8355070 | overloaded x2
        public void Encrypt(){} // RVA: 0x7FFAC83551B0
        public void GetExistingParameters(){} // RVA: 0x7FFAC8355320
        public void AddPrivateKey(){} // RVA: 0x7FFAC83555A0
        public void ReadSafeBag(){} // RVA: 0x7FFAC83558A0
        public void Pkcs8ShroudedKeyBagSafeBag(){} // RVA: 0x7FFAC8356360
        public void CertificateSafeBag(){} // RVA: 0x7FFAC8357190
        public void MAC(){} // RVA: 0x7FFAC8357C40
        public void GetBytes(){} // RVA: 0x7FFAC8357EB0
        public void EncryptedContentInfo(){} // RVA: 0x7FFAC835A300
        public void AddCertificate(){} // RVA: 0x7FFAC835AA20 | overloaded x2
        public void RemoveCertificate(){} // RVA: 0x7FFAC835AD60 | overloaded x2
        public void CompareAsymmetricAlgorithm(){} // RVA: 0x7FFAC835B400
        public void AddPkcs8ShroudedKeyBag(){} // RVA: 0x7FFAC835B500
        public void Clone(){} // RVA: 0x7FFAC835B910
        public void get_MaximumPasswordLength(){} // RVA: 0x7FFAC835BA20
        public void .cctor(){} // RVA: 0x7FFAC835BA80
    }

    public class SafeBag : Object
    {
        public string BagOID; // 0x10
        public Mono.Security.ASN1 ASN1; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void get_BagOID(){} // RVA: 0x7FFAC2F3C380
        public void get_ASN1(){} // RVA: 0x7FFAC2F247C0
    }

    public class X501 : Object
    {
        public byte[] countryName;
        public byte[] organizationName; // 0x8
        public byte[] organizationalUnitName; // 0x10
        public byte[] commonName; // 0x18
        public byte[] localityName; // 0x20
        public byte[] stateOrProvinceName; // 0x28
        public byte[] streetAddress; // 0x30
        public byte[] serialNumber; // 0x38
        public byte[] domainComponent; // 0x40
        public byte[] userid; // 0x48
        public byte[] email; // 0x50
        public byte[] dnQualifier; // 0x58
        public byte[] title; // 0x60
        public byte[] surname; // 0x68
        public byte[] givenName; // 0x70
        public byte[] initial; // 0x78

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC835C840 | overloaded x2
        public void AppendEntry(){} // RVA: 0x7FFAC835CA30
        public void GetAttributeFromOid(){} // RVA: 0x7FFAC835D410
        public void IsOid(){} // RVA: 0x7FFAC835E570
        public void ReadAttribute(){} // RVA: 0x7FFAC835E660
        public void IsHex(){} // RVA: 0x7FFAC835E810
        public void ReadHex(){} // RVA: 0x7FFAC835E970
        public void ReadEscaped(){} // RVA: 0x7FFAC835EC80
        public void ReadQuoted(){} // RVA: 0x7FFAC835EE30
        public void ReadValue(){} // RVA: 0x7FFAC835EFA0
        public void FromString(){} // RVA: 0x7FFAC835F270
        public void .cctor(){} // RVA: 0x7FFAC835F580
    }

    public class X509Certificate : Object
    {
        public Mono.Security.ASN1 DSA; // 0x10
        public byte[] Extensions; // 0x18
        public System.DateTime Hash; // 0x20
        public System.DateTime IssuerName; // 0x28
        public Mono.Security.ASN1 KeyAlgorithm; // 0x30
        public string KeyAlgorithmParameters; // 0x38
        public string PublicKey; // 0x40
        public byte[] RSA; // 0x48
        public Mono.Security.ASN1 RawData; // 0x50
        public string SerialNumber; // 0x58
        public byte[] Signature; // 0x60
        public byte[] SubjectName; // 0x68
        public string ValidFrom; // 0x70
        public byte[] ValidUntil; // 0x78
        public byte[] Version; // 0x80
        public System.Security.Cryptography.RSA IsCurrent; // 0x88
        public System.Security.Cryptography.DSA IsSelfSigned; // 0x90
        public int version; // 0x98
        public byte[] serialnumber; // 0xA0
        public byte[] issuerUniqueID; // 0xA8
        public byte[] subjectUniqueID; // 0xB0
        public Mono.Security.X509.X509ExtensionCollection extensions; // 0xB8
        public string encoding_error;

        // ── Methods ──
        public void Parse(){} // RVA: 0x7FFAC8361740
        public void .ctor(){} // RVA: 0x7FFAC83620E0
        public void GetUnsignedBigInteger(){} // RVA: 0x7FFAC8362210
        public void get_DSA(){} // RVA: 0x7FFAC83622C0
        public void set_DSA(){} // RVA: 0x7FFAC83627F0
        public void get_Extensions(){} // RVA: 0x7FFAC2F8C0B0
        public void get_Hash(){} // RVA: 0x7FFAC83628C0
        public void get_IssuerName(){} // RVA: 0x7FFAC31D0140
        public void get_KeyAlgorithm(){} // RVA: 0x7FFAC2F9E740
        public void get_KeyAlgorithmParameters(){} // RVA: 0x7FFAC8362B10
        public void set_KeyAlgorithmParameters(){} // RVA: 0x7FFAC2F9C740
        public void get_PublicKey(){} // RVA: 0x7FFAC8362B90
        public void get_RSA(){} // RVA: 0x7FFAC8362C10
        public void set_RSA(){} // RVA: 0x7FFAC8362EF0
        public void get_RawData(){} // RVA: 0x7FFAC8362FB0
        public void get_SerialNumber(){} // RVA: 0x7FFAC8363030
        public void get_Signature(){} // RVA: 0x7FFAC83630C0
        public void get_SubjectName(){} // RVA: 0x7FFAC2FE9500
        public void get_ValidFrom(){} // RVA: 0x7FFAC2F4F0C0
        public void get_ValidUntil(){} // RVA: 0x7FFAC2F4F130
        public void get_Version(){} // RVA: 0x7FFAC489E530
        public void get_IsCurrent(){} // RVA: 0x7FFAC83635D0
        public void WasCurrent(){} // RVA: 0x7FFAC83636E0
        public void VerifySignature(){} // RVA: 0x7FFAC8363A10 | overloaded x3
        public void get_IsSelfSigned(){} // RVA: 0x7FFAC8363C00
        public void GetObjectData(){} // RVA: 0x7FFAC8363CD0
        public void PEM(){} // RVA: 0x7FFAC8363F10
        public void .cctor(){} // RVA: 0x7FFAC8364190
    }

    public class X509CertificateCollection : CollectionBase
    {
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8364240
        public void get_Item(){} // RVA: 0x7FFAC8364250
        public void Add(){} // RVA: 0x7FFAC83642F0
        public void AddRange(){} // RVA: 0x7FFAC8364380
        public void Contains(){} // RVA: 0x7FFAC8364460
        public void GetEnumerator(){} // RVA: 0x7FFAC8364480
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8364560
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
        public void IndexOf(){} // RVA: 0x7FFAC8364590
        public void Compare(){} // RVA: 0x7FFAC8360AD0
    }

    public class X509Chain : Object
    {
        public Mono.Security.X509.X509CertificateCollection TrustAnchors; // 0x10
        public Mono.Security.X509.X509CertificateCollection certs; // 0x18
        public Mono.Security.X509.X509Certificate _root; // 0x20
        public Mono.Security.X509.X509CertificateCollection _chain; // 0x28
        public 0x6B2839F0 _status; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83649F0
        public void get_TrustAnchors(){} // RVA: 0x7FFAC8364A90
        public void LoadCertificates(){} // RVA: 0x7FFAC8364C20
        public void Build(){} // RVA: 0x7FFAC8364C40
        public void Reset(){} // RVA: 0x7FFAC8365110
        public void IsValid(){} // RVA: 0x7FFAC8365230
        public void FindCertificateParent(){} // RVA: 0x7FFAC83653A0
        public void FindCertificateRoot(){} // RVA: 0x7FFAC8365540
        public void IsTrusted(){} // RVA: 0x7FFAC8365770
        public void IsParent(){} // RVA: 0x7FFAC83657B0
    }

    public class X509Crl : Object
    {
        public string Extensions; // 0x10
        public byte Hash; // 0x18
        public System.DateTime IssuerName; // 0x20
        public System.DateTime NextUpdate; // 0x28
        public System.Collections.ArrayList entries; // 0x30
        public string signatureOID; // 0x38
        public byte[] signature; // 0x40
        public Mono.Security.X509.X509ExtensionCollection extensions; // 0x48
        public byte[] encoded; // 0x50
        public byte[] hash_value; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC835FFF0
        public void Parse(){} // RVA: 0x7FFAC8360140
        public void get_Extensions(){} // RVA: 0x7FFAC2F9C730
        public void get_Hash(){} // RVA: 0x7FFAC8360800
        public void get_IssuerName(){} // RVA: 0x7FFAC2F3C380
        public void get_NextUpdate(){} // RVA: 0x7FFAC2F4F130
        public void Compare(){} // RVA: 0x7FFAC8360AD0
        public void GetCrlEntry(){} // RVA: 0x7FFAC8360BD0 | overloaded x2
        public void VerifySignature(){} // RVA: 0x7FFAC8361200 | overloaded x3
    }

    public class X509Extension : Object
    {
        public string Oid; // 0x10
        public bool Critical; // 0x18
        public Mono.Security.ASN1 Value; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8365C90 | overloaded x2
        public void Decode(){} // RVA: 0x7FFAC2F21310
        public void Encode(){} // RVA: 0x7FFAC2F21310
        public void get_Oid(){} // RVA: 0x7FFAC2F3C380
        public void get_Critical(){} // RVA: 0x7FFAC2F3C4E0
        public void get_Value(){} // RVA: 0x7FFAC8365E00
        public void Equals(){} // RVA: 0x7FFAC8365E40
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
        public void WriteLine(){} // RVA: 0x7FFAC8365FD0
        public void ToString(){} // RVA: 0x7FFAC8366210
    }

    public class X509ExtensionCollection : CollectionBase
    {
        public bool Item; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8366340 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFAC8366490
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8364560
        public void get_Item(){} // RVA: 0x7FFAC8366620
    }

    public class X509Store : Object
    {
        public string Certificates; // 0x10
        public Mono.Security.X509.X509CertificateCollection Crls; // 0x18
        public System.Collections.ArrayList _crls; // 0x20
        public bool _crl; // 0x28
        public bool _newFormat; // 0x29

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8366850
        public void get_Certificates(){} // RVA: 0x7FFAC83668C0
        public void get_Crls(){} // RVA: 0x7FFAC8366940
        public void Load(){} // RVA: 0x7FFAC8366A60
        public void LoadCertificate(){} // RVA: 0x7FFAC8366BD0
        public void LoadCrl(){} // RVA: 0x7FFAC8366C40
        public void CheckStore(){} // RVA: 0x7FFAC8366DE0
        public void BuildCertificatesCollection(){} // RVA: 0x7FFAC8366E40
        public void BuildCrlsCollection(){} // RVA: 0x7FFAC8367020
    }

    public class X509StoreManager : Object
    {
        public string CurrentUserPath;
        public string LocalMachinePath; // 0x8
        public string NewCurrentUserPath; // 0x10
        public string NewLocalMachinePath; // 0x18
        public Mono.Security.X509.X509Stores CurrentUser; // 0x20
        public Mono.Security.X509.X509Stores LocalMachine; // 0x28

        // ── Methods ──
        public void get_CurrentUserPath(){} // RVA: 0x7FFAC8367180
        public void get_LocalMachinePath(){} // RVA: 0x7FFAC8367340
        public void get_NewCurrentUserPath(){} // RVA: 0x7FFAC8367510
        public void get_NewLocalMachinePath(){} // RVA: 0x7FFAC83676E0
        public void get_CurrentUser(){} // RVA: 0x7FFAC83678B0
        public void get_LocalMachine(){} // RVA: 0x7FFAC8367BA0
        public void get_TrustedRootCertificates(){} // RVA: 0x7FFAC8367EA0
    }

    public class X509Stores : Object
    {
        public string TrustedRoot; // 0x10
        public bool _newFormat; // 0x18
        public Mono.Security.X509.X509Store _trusted; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45687E0
        public void get_TrustedRoot(){} // RVA: 0x7FFAC8367F60
        public void Open(){} // RVA: 0x7FFAC83680D0
    }

    public class X520 : Object
    {
    }

}