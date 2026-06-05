// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.X509
// Classes: 13
// Methods: 146

namespace ThirdParty.DotNet.Mono.Security.X509
{
    public class PKCS12
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF866B570 | overloaded x3
        public void Decode(){} // RVA: 0x7FFAF866B5C0
        public void Finalize(){} // RVA: 0x7FFAF866C070
        public void set_Password(){} // RVA: 0x7FFAF866C120
        public void get_IterationCount(){} // RVA: 0x7FFAF2F76670
        public void set_IterationCount(){} // RVA: 0x7FFAF2F75F20
        public void get_Keys(){} // RVA: 0x7FFAF866C380
        public void get_Certificates(){} // RVA: 0x7FFAF866CAB0
        public void get_RNG(){} // RVA: 0x7FFAF866CF30
        public void Compare(){} // RVA: 0x7FFAF866CFB0
        public void GetSymmetricAlgorithm(){} // RVA: 0x7FFAF866D030
        public void Decrypt(){} // RVA: 0x7FFAF866DB20 | overloaded x2
        public void Encrypt(){} // RVA: 0x7FFAF866DC60
        public void GetExistingParameters(){} // RVA: 0x7FFAF866DDD0
        public void AddPrivateKey(){} // RVA: 0x7FFAF866E050
        public void ReadSafeBag(){} // RVA: 0x7FFAF866E350
        public void Pkcs8ShroudedKeyBagSafeBag(){} // RVA: 0x7FFAF866EE10
        public void CertificateSafeBag(){} // RVA: 0x7FFAF866FC40
        public void MAC(){} // RVA: 0x7FFAF86706F0
        public void GetBytes(){} // RVA: 0x7FFAF8670960
        public void EncryptedContentInfo(){} // RVA: 0x7FFAF8672DB0
        public void AddCertificate(){} // RVA: 0x7FFAF86734D0 | overloaded x2
        public void RemoveCertificate(){} // RVA: 0x7FFAF8673810 | overloaded x2
        public void CompareAsymmetricAlgorithm(){} // RVA: 0x7FFAF8673EB0
        public void AddPkcs8ShroudedKeyBag(){} // RVA: 0x7FFAF8673FB0
        public void Clone(){} // RVA: 0x7FFAF86743C0
        public void get_MaximumPasswordLength(){} // RVA: 0x7FFAF86744D0
        public void .cctor(){} // RVA: 0x7FFAF8674530
    }

    public class SafeBag
    {
        public object HashName;
        public object IterationCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void get_BagOID(){} // RVA: 0x7FFAF2DA8380
        public void get_ASN1(){} // RVA: 0x7FFAF2D907C0
    }

    public class X501
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAF86752F0 | overloaded x2
        public void AppendEntry(){} // RVA: 0x7FFAF86754E0
        public void GetAttributeFromOid(){} // RVA: 0x7FFAF8675EC0
        public void IsOid(){} // RVA: 0x7FFAF8677020
        public void ReadAttribute(){} // RVA: 0x7FFAF8677110
        public void IsHex(){} // RVA: 0x7FFAF86772C0
        public void ReadHex(){} // RVA: 0x7FFAF8677420
        public void ReadEscaped(){} // RVA: 0x7FFAF8677730
        public void ReadQuoted(){} // RVA: 0x7FFAF86778E0
        public void ReadValue(){} // RVA: 0x7FFAF8677A50
        public void FromString(){} // RVA: 0x7FFAF8677D20
        public void .cctor(){} // RVA: 0x7FFAF8678030
    }

    public class X509Certificate
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x7FFAF867A1F0
        public void .ctor(){} // RVA: 0x7FFAF867AB90
        public void GetUnsignedBigInteger(){} // RVA: 0x7FFAF867ACC0
        public void get_DSA(){} // RVA: 0x7FFAF867AD70
        public void set_DSA(){} // RVA: 0x7FFAF867B2A0
        public void get_Extensions(){} // RVA: 0x7FFAF2DF80B0
        public void get_Hash(){} // RVA: 0x7FFAF867B370
        public void get_IssuerName(){} // RVA: 0x7FFAF2F476A0
        public void get_KeyAlgorithm(){} // RVA: 0x7FFAF2E0A740
        public void get_KeyAlgorithmParameters(){} // RVA: 0x7FFAF867B5C0
        public void set_KeyAlgorithmParameters(){} // RVA: 0x7FFAF2E08740
        public void get_PublicKey(){} // RVA: 0x7FFAF867B640
        public void get_RSA(){} // RVA: 0x7FFAF867B6C0
        public void set_RSA(){} // RVA: 0x7FFAF867B9A0
        public void get_RawData(){} // RVA: 0x7FFAF867BA60
        public void get_SerialNumber(){} // RVA: 0x7FFAF867BAE0
        public void get_Signature(){} // RVA: 0x7FFAF867BB70
        public void get_SubjectName(){} // RVA: 0x7FFAF2E55500
        public void get_ValidFrom(){} // RVA: 0x7FFAF2DBB0C0
        public void get_ValidUntil(){} // RVA: 0x7FFAF2DBB130
        public void get_Version(){} // RVA: 0x7FFAF4826570
        public void get_IsCurrent(){} // RVA: 0x7FFAF867C080
        public void WasCurrent(){} // RVA: 0x7FFAF867C190
        public void VerifySignature(){} // RVA: 0x7FFAF867C4C0 | overloaded x3
        public void get_IsSelfSigned(){} // RVA: 0x7FFAF867C6B0
        public void GetObjectData(){} // RVA: 0x7FFAF867C780
        public void PEM(){} // RVA: 0x7FFAF867C9C0
        public void .cctor(){} // RVA: 0x7FFAF867CC40
    }

    public class X509CertificateCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF867CCF0
        public void get_Item(){} // RVA: 0x7FFAF867CD00
        public void Add(){} // RVA: 0x7FFAF867CDA0
        public void AddRange(){} // RVA: 0x7FFAF867CE30
        public void Contains(){} // RVA: 0x7FFAF867CF10
        public void GetEnumerator(){} // RVA: 0x7FFAF867CF30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF867D010
        public void GetHashCode(){} // RVA: 0x7FFAF344E0E0
        public void IndexOf(){} // RVA: 0x7FFAF867D040
        public void Compare(){} // RVA: 0x7FFAF8679580
    }

    public class X509Chain
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF867D4A0
        public void get_TrustAnchors(){} // RVA: 0x7FFAF867D540
        public void LoadCertificates(){} // RVA: 0x7FFAF867D6D0
        public void Build(){} // RVA: 0x7FFAF867D6F0
        public void Reset(){} // RVA: 0x7FFAF867DBC0
        public void IsValid(){} // RVA: 0x7FFAF867DCE0
        public void FindCertificateParent(){} // RVA: 0x7FFAF867DE50
        public void FindCertificateRoot(){} // RVA: 0x7FFAF867DFF0
        public void IsTrusted(){} // RVA: 0x7FFAF867E220
        public void IsParent(){} // RVA: 0x7FFAF867E260
    }

    public class X509Crl
    {
        public object DSA;
        public object Extensions;
        public object Hash;
        public object IssuerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8678AA0
        public void Parse(){} // RVA: 0x7FFAF8678BF0
        public void get_Extensions(){} // RVA: 0x7FFAF2E08730
        public void get_Hash(){} // RVA: 0x7FFAF86792B0
        public void get_IssuerName(){} // RVA: 0x7FFAF2DA8380
        public void get_NextUpdate(){} // RVA: 0x7FFAF2DBB130
        public void Compare(){} // RVA: 0x7FFAF8679580
        public void GetCrlEntry(){} // RVA: 0x7FFAF8679680 | overloaded x2
        public void VerifySignature(){} // RVA: 0x7FFAF8679CB0 | overloaded x3
    }

    public class X509Extension
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF867E740 | overloaded x2
        public void Decode(){} // RVA: 0x7FFAF2D8D310
        public void Encode(){} // RVA: 0x7FFAF2D8D310
        public void get_Oid(){} // RVA: 0x7FFAF2DA8380
        public void get_Critical(){} // RVA: 0x7FFAF2DA84E0
        public void get_Value(){} // RVA: 0x7FFAF867E8B0
        public void Equals(){} // RVA: 0x7FFAF867E8F0
        public void GetHashCode(){} // RVA: 0x7FFAF344E0E0
        public void WriteLine(){} // RVA: 0x7FFAF867EA80
        public void ToString(){} // RVA: 0x7FFAF867ECC0
    }

    public class X509ExtensionCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF867EDF0 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFAF867EF40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF867D010
        public void get_Item(){} // RVA: 0x7FFAF867F0D0
    }

    public class X509Store
    {
        public object CurrentUserPath;
        public object LocalMachinePath;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF867F300
        public void get_Certificates(){} // RVA: 0x7FFAF867F370
        public void get_Crls(){} // RVA: 0x7FFAF867F3F0
        public void Load(){} // RVA: 0x7FFAF867F510
        public void LoadCertificate(){} // RVA: 0x7FFAF867F680
        public void LoadCrl(){} // RVA: 0x7FFAF867F6F0
        public void CheckStore(){} // RVA: 0x7FFAF867F890
        public void BuildCertificatesCollection(){} // RVA: 0x7FFAF867F8F0
        public void BuildCrlsCollection(){} // RVA: 0x7FFAF867FAD0
    }

    public class X509StoreManager
    {
        public object TrustedRoot;
        public object `;
        public object set_Value;

        // ── Methods ──
        public void get_CurrentUserPath(){} // RVA: 0x7FFAF867FC30
        public void get_LocalMachinePath(){} // RVA: 0x7FFAF867FDF0
        public void get_NewCurrentUserPath(){} // RVA: 0x7FFAF867FFC0
        public void get_NewLocalMachinePath(){} // RVA: 0x7FFAF8680190
        public void get_CurrentUser(){} // RVA: 0x7FFAF8680360
        public void get_LocalMachine(){} // RVA: 0x7FFAF8680650
        public void get_TrustedRootCertificates(){} // RVA: 0x7FFAF8680950
    }

    public class X509Stores
    {
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF45641A0
        public void get_TrustedRoot(){} // RVA: 0x7FFAF8680A10
        public void Open(){} // RVA: 0x7FFAF8680B80
    }

    public class X520
    {
    }

}