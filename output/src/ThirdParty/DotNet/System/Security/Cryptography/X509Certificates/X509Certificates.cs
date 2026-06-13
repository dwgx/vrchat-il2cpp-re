// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography.X509Certificates
// Classes: 31
// Methods: 382

namespace ThirdParty.DotNet.System.Security.Cryptography.X509Certificates
{
    public class PublicKey
    {
        public string Name;
        public string `;
        public System.Security.Cryptography.AsymmetricAlgorithm _key; // 0x10
        public System.Security.Cryptography.AsnEncodedData _keyValue; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C34250
        public void get_EncodedKeyValue(){} // RVA: 0x2E07C0
        public void get_EncodedParameters(){} // RVA: 0x30B0C0
        public void get_Key(){} // RVA: 0x6C34440
        public void get_Oid(){} // RVA: 0x30B130
        public void GetUnsignedBigInteger(){} // RVA: 0x6C34670
        public void DecodeDSA(){} // RVA: 0x6C34720
        public void DecodeRSA(){} // RVA: 0x6C34CD0
        public void .cctor(){} // RVA: 0x6C350E0
    }

    public class RSACertificateExtensions
    {
        // ── Methods ──
        public void GetRSAPublicKey(){} // RVA: 0x65A70A0
    }

    public class X500DistinguishedName
    {
        public 0x6584C7D8 AllFlags;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C352E0 | overloaded x3
        public void get_Name(){} // RVA: 0x30B0C0
        public void Decode(){} // RVA: 0x6C35630
        public void Format(){} // RVA: 0x6C35800
        public void GetSeparator(){} // RVA: 0x6C35870
        public void DecodeRawData(){} // RVA: 0x6C358E0
        public void Canonize(){} // RVA: 0x6C35A90
        public void AreEqual(){} // RVA: 0x6C35CC0
    }

    public class X509BasicConstraintsExtension
    {
        public string oid;
        public string friendlyName;
        public bool _certificateAuthority; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C36140 | overloaded x3
        public void get_CertificateAuthority(){} // RVA: 0x6C362B0
        public void get_HasPathLengthConstraint(){} // RVA: 0x6C36320
        public void get_PathLengthConstraint(){} // RVA: 0x6C36390
        public void CopyFrom(){} // RVA: 0x6C36400
        public void Decode(){} // RVA: 0x6C36600
        public void Encode(){} // RVA: 0x6C36770
        public void ToString(){} // RVA: 0x6C369C0
    }

    public class X509Certificate
    {
        public System.Security.Cryptography.X509Certificates.X509CertificateImpl impl; // 0x10
        public byte[] lazyCertHash; // 0x18
        public byte[] lazySerialNumber; // 0x20
        public string lazyIssuer; // 0x28

        // ── Methods ──
        public void Reset(){} // RVA: 0x5CAFBC0
        public void .ctor(){} // RVA: 0x5CB0840 | overloaded x9
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x5CB0890
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x5CB08D0
        public void get_Issuer(){} // RVA: 0x5CB0910
        public void get_Subject(){} // RVA: 0x5CB0A00
        public void Dispose(){} // RVA: 0x5CB0B10 | overloaded x2
        public void Equals(){} // RVA: 0x5CB0BE0 | overloaded x2
        public void Export(){} // RVA: 0x5CB0D10
        public void GetCertHash(){} // RVA: 0x5CB0EE0
        public void GetCertHashString(){} // RVA: 0x5CB0FB0
        public void GetRawCertHash(){} // RVA: 0x5CB1030
        public void GetPublicKeyString(){} // RVA: 0x5CB10C0
        public void GetRawCertData(){} // RVA: 0x5CB1100
        public void GetHashCode(){} // RVA: 0x5CB11F0
        public void GetKeyAlgorithm(){} // RVA: 0x5CB12F0
        public void GetKeyAlgorithmParameters(){} // RVA: 0x5CB13E0
        public void GetPublicKey(){} // RVA: 0x5CB1530
        public void GetSerialNumber(){} // RVA: 0x5CB1680
        public void GetSerialNumberString(){} // RVA: 0x5CB17F0
        public void GetRawSerialNumber(){} // RVA: 0x5CB1870
        public void ToString(){} // RVA: 0x5CB1920 | overloaded x2
        public void GetNotAfter(){} // RVA: 0x5CB1E50
        public void GetNotBefore(){} // RVA: 0x5CB1F80
        public void FormatDate(){} // RVA: 0x5CB20B0
        public void ValidateKeyStorageFlags(){} // RVA: 0x5CB2340
        public void VerifyContentType(){} // RVA: 0x5CB2460
        public void ImportHandle(){} // RVA: 0x5CB24D0
        public void get_Impl(){} // RVA: 0x2F8380
        public void get_IsValid(){} // RVA: 0x5CB2550
        public void ThrowIfInvalid(){} // RVA: 0x5CB2570
    }

    public class X509Certificate2
    {
        public byte[] lazyRawData; // 0x60
        public System.Security.Cryptography.Oid lazySignatureAlgorithm; // 0x68
        public int lazyVersion; // 0x70
        public System.Security.Cryptography.X509Certificates.X500DistinguishedName lazySubjectName; // 0x78
        public System.Security.Cryptography.X509Certificates.X500DistinguishedName lazyIssuerName; // 0x80
        public System.Security.Cryptography.X509Certificates.PublicKey lazyPublicKey; // 0x88
        public System.Security.Cryptography.AsymmetricAlgorithm lazyPrivateKey; // 0x90
        public System.Security.Cryptography.X509Certificates.X509ExtensionCollection lazyExtensions; // 0x98

        // ── Methods ──
        public void Reset(){} // RVA: 0x6C36C80
        public void .ctor(){} // RVA: 0x6C37100 | overloaded x7
        public void get_Extensions(){} // RVA: 0x6C37120
        public void get_HasPrivateKey(){} // RVA: 0x6C37550
        public void get_PrivateKey(){} // RVA: 0x6C375D0
        public void get_IssuerName(){} // RVA: 0x6C37800
        public void get_NotAfter(){} // RVA: 0x6C37910
        public void get_NotBefore(){} // RVA: 0x6C37920
        public void get_PublicKey(){} // RVA: 0x6C37930
        public void get_RawData(){} // RVA: 0x6C37B60
        public void get_SerialNumber(){} // RVA: 0x386F560
        public void get_SignatureAlgorithm(){} // RVA: 0x6C37CC0
        public void get_SubjectName(){} // RVA: 0x6C37DD0
        public void get_Thumbprint(){} // RVA: 0x6C37ED0
        public void get_Version(){} // RVA: 0x6C37F10
        public void GetCertContentType(){} // RVA: 0x6C37FB0
        public void GetNameInfo(){} // RVA: 0x6C38050
        public void ToString(){} // RVA: 0x6C380B0 | overloaded x2
        public void Verify(){} // RVA: 0x6C39140
        public void CreateCustomExtensionIfAny(){} // RVA: 0x6C39180
        public void get_Impl(){} // RVA: 0x6C39680
    }

    public class X509Certificate2Collection
    {
        public string[] newline_split;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C39740 | overloaded x2
        public void get_Item(){} // RVA: 0x6C397E0
        public void Add(){} // RVA: 0x6C39950
        public void AddRange(){} // RVA: 0x6C399E0
        public void Contains(){} // RVA: 0x6C39A70
        public void GetKeyIdentifier(){} // RVA: 0x6C39CB0
        public void Find(){} // RVA: 0x6C39D90
        public void GetEnumerator(){} // RVA: 0x6C3B1C0
        public void .cctor(){} // RVA: 0x6C3B2A0
    }

    public class X509Certificate2Enumerator : .ctor
    {
        public System.Collections.IEnumerator enumerator; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C3B370
        public void get_Current(){} // RVA: 0x6C3B420
        public void MoveNext(){} // RVA: 0x6C3B4C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x6C3B510
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x6C3B560
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x6C3B5B0
    }

    public class X509Certificate2Impl
    {
        // ── Methods ──
        public void get_Extensions(){} // RVA: 0xCD60
        public void get_IssuerName(){} // RVA: 0xCD60
        public void get_PrivateKey(){} // RVA: 0xCD60
        public void set_PrivateKey(){} // RVA: 0x24B10
        public void get_SignatureAlgorithm(){} // RVA: 0xCD60
        public void get_SubjectName(){} // RVA: 0xCD60
        public void get_Version(){} // RVA: 0xD840
        public void get_IntermediateCertificates(){} // RVA: 0xCD60
        public void GetNameInfo(){}
        public void Verify(){} // RVA: 0xDE40
        public void AppendPrivateKeyInfo(){} // RVA: 0x24B10
        public void CopyWithPrivateKey(){} // RVA: 0x6C3B600
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class X509Certificate2ImplMono
    {
        public System.Security.Cryptography.X509Certificates.X509CertificateImplCollection intermediateCerts; // 0xB0
        public Mono.Security.X509.X509Certificate _cert; // 0xB8
        public string empty_error;
        public byte[] signedData; // 0x8

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x6999EB0
        public void .ctor(){} // RVA: 0x6C3B810 | overloaded x3
        public void Clone(){} // RVA: 0x6C3BA90
        public void get_Cert(){} // RVA: 0x6BE4E30
        public void GetRawCertData(){} // RVA: 0x6C3BC50
        public void get_HasPrivateKey(){} // RVA: 0x6C3BD00
        public void get_PrivateKey(){} // RVA: 0x6C3BD30
        public void set_PrivateKey(){} // RVA: 0x6C3C1A0
        public void GetRSAPrivateKey(){} // RVA: 0x6C3C460
        public void GetDSAPrivateKey(){} // RVA: 0x6C3C500
        public void ImportPkcs12(){} // RVA: 0x6C3C640 | overloaded x2
        public void Verify(){} // RVA: 0x6C3CEA0
        public void get_IntermediateCertificates(){} // RVA: 0x348040
        public void get_MonoCertificate(){} // RVA: 0x3480B0
        public void .cctor(){} // RVA: 0x6C3CF90
    }

    public class X509Certificate2ImplUnix
    {
        public bool readCertData; // 0x10
        public Internal.Cryptography.Pal.CertificateData certData; // 0x18

        // ── Methods ──
        public void EnsureCertData(){} // RVA: 0x6C3D110
        public void GetRawCertData(){} // RVA: 0xCD60
        public void get_KeyAlgorithm(){} // RVA: 0x6C3D2A0
        public void get_KeyAlgorithmParameters(){} // RVA: 0x6C3D2C0
        public void get_PublicKeyValue(){} // RVA: 0x6C3D2E0
        public void get_SerialNumber(){} // RVA: 0x6C3D300
        public void get_SignatureAlgorithm(){} // RVA: 0x6C3D320
        public void get_Version(){} // RVA: 0x6C3D340
        public void get_SubjectName(){} // RVA: 0x6C3D360
        public void get_IssuerName(){} // RVA: 0x6C3D380
        public void get_Subject(){} // RVA: 0x6C3D3A0
        public void get_Issuer(){} // RVA: 0x6C3D3D0
        public void get_RawData(){} // RVA: 0x6C3D400
        public void get_Thumbprint(){} // RVA: 0x6C3D420
        public void GetNameInfo(){} // RVA: 0x6C3D5F0
        public void get_Extensions(){} // RVA: 0x6C3D630
        public void get_NotAfter(){} // RVA: 0x6C3D650
        public void get_NotBefore(){} // RVA: 0x6C3D6F0
        public void AppendPrivateKeyInfo(){} // RVA: 0x6C3D790
        public void Export(){} // RVA: 0x6C3D850
        public void ExportPkcs12(){} // RVA: 0x6C3DAB0 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class X509CertificateCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C3DF30 | overloaded x2
        public void get_Item(){} // RVA: 0x6C3DF60
        public void Add(){} // RVA: 0x6C3E000
        public void AddRange(){} // RVA: 0x6C3E090
        public void GetEnumerator(){} // RVA: 0x6C3E170
        public void GetHashCode(){} // RVA: 0x99E0E0
    }

    public class X509CertificateImpl
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0xDBE0
        public void ThrowIfContextInvalid(){} // RVA: 0x5CB25D0
        public void Clone(){} // RVA: 0xCD60
        public void get_Issuer(){} // RVA: 0xCD60
        public void get_Subject(){} // RVA: 0xCD60
        public void get_RawData(){} // RVA: 0xCD60
        public void get_NotAfter(){} // RVA: 0xCD60
        public void get_NotBefore(){} // RVA: 0xCD60
        public void get_Thumbprint(){} // RVA: 0xCD60
        public void GetHashCode(){} // RVA: 0x5CB2620
        public void get_KeyAlgorithm(){} // RVA: 0xCD60
        public void get_KeyAlgorithmParameters(){} // RVA: 0xCD60
        public void get_PublicKeyValue(){} // RVA: 0xCD60
        public void get_SerialNumber(){} // RVA: 0xCD60
        public void get_HasPrivateKey(){} // RVA: 0xDBE0
        public void GetRSAPrivateKey(){} // RVA: 0xCD60
        public void GetDSAPrivateKey(){} // RVA: 0xCD60
        public void Export(){} // RVA: 0x1CEE0
        public void CopyWithPrivateKey(){} // RVA: 0xCE10
        public void Equals(){} // RVA: 0x5CB26C0
        public void Dispose(){} // RVA: 0x2DD310 | overloaded x2
        public void Finalize(){} // RVA: 0x5CB2900
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class X509CertificateImplCollection
    {
        public System.Collections.Generic.List`1<System.Security.Cryptography.X509Certificates.X509CertificateImpl> list; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C3E5A0 | overloaded x2
        public void get_Count(){} // RVA: 0x6C3E840
        public void get_Item(){} // RVA: 0x6C3E890
        public void Add(){} // RVA: 0x6C3E910
        public void Clone(){} // RVA: 0x6C3E9A0
        public void Dispose(){} // RVA: 0x6C3EA70 | overloaded x2
        public void Finalize(){} // RVA: 0x5AAC950
    }

    public class X509Chain
    {
        public System.Security.Cryptography.X509Certificates.X509ChainImpl impl; // 0x10

        // ── Methods ──
        public void get_Impl(){} // RVA: 0x6C3EC10
        public void .ctor(){} // RVA: 0x6C3EF30 | overloaded x4
        public void get_ChainElements(){} // RVA: 0x6C3EF70
        public void get_ChainPolicy(){} // RVA: 0x6C3EFF0
        public void Build(){} // RVA: 0x6C3F070
        public void Reset(){} // RVA: 0x6C3F100
        public void Create(){} // RVA: 0x6C3F180
        public void Dispose(){} // RVA: 0x6C3F240 | overloaded x2
        public void Finalize(){} // RVA: 0x5AAC950
    }

    public class X509ChainElement
    {
        public System.Security.Cryptography.X509Certificates.X509Certificate2 Count; // 0x10
        public System.Security.Cryptography.X509Certificates.X509ChainStatus[] IsSynchronized; // 0x18
        public string Item; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C3F320
        public void get_Certificate(){} // RVA: 0x2F8380
        public void get_ChainElementStatus(){} // RVA: 0x2E07C0
        public void get_StatusFlags(){} // RVA: 0x791DC0
        public void set_StatusFlags(){} // RVA: 0xA53440
        public void Count(){} // RVA: 0x6C3F420
        public void Set(){} // RVA: 0x6C3F450
        public void UncompressFlags(){} // RVA: 0x6C3F510
    }

    public class X509ChainElementCollection
    {
        public System.Collections.ArrayList _list; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C401E0
        public void get_Count(){} // RVA: 0x5DFC050
        public void get_IsSynchronized(){} // RVA: 0x797560
        public void get_Item(){} // RVA: 0x6C40280
        public void get_SyncRoot(){} // RVA: 0x5DFC2D0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x5DFC300
        public void GetEnumerator(){} // RVA: 0x6C40320
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6C40380
        public void Add(){} // RVA: 0x6C403E0
        public void Clear(){} // RVA: 0x6774200
        public void Contains(){} // RVA: 0x6C40540
    }

    public class X509ChainElementEnumerator
    {
        public System.Collections.IEnumerator enumerator; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C40680
        public void get_Current(){} // RVA: 0x6C40730
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x6C407D0
        public void MoveNext(){} // RVA: 0x6C40820
        public void Reset(){} // RVA: 0x6C40870
    }

    public class X509ChainImpl
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0xDBE0
        public void ThrowIfContextInvalid(){} // RVA: 0x6C408C0
        public void get_ChainElements(){} // RVA: 0xCD60
        public void get_ChainPolicy(){} // RVA: 0xCD60
        public void Build(){} // RVA: 0xDE40
        public void AddStatus(){} // RVA: 0x24FA0
        public void Reset(){} // RVA: 0x24A50
        public void Dispose(){} // RVA: 0x2DD310 | overloaded x2
        public void Finalize(){} // RVA: 0x5C13DD0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class X509ChainImplMono
    {
        public 0x6584C728 location; // 0x10
        public System.Security.Cryptography.X509Certificates.X509ChainElementCollection elements; // 0x18
        public System.Security.Cryptography.X509Certificates.X509ChainPolicy policy; // 0x20
        public System.Security.Cryptography.X509Certificates.X509ChainStatus[] status; // 0x28
        public System.Security.Cryptography.X509Certificates.X509ChainStatus[] Empty;
        public int max_path_length; // 0x30
        public System.Security.Cryptography.X509Certificates.X500DistinguishedName working_issuer_name; // 0x38
        public System.Security.Cryptography.AsymmetricAlgorithm working_public_key; // 0x40
        public System.Security.Cryptography.X509Certificates.X509ChainElement bce_restriction; // 0x48
        public System.Security.Cryptography.X509Certificates.X509Certificate2Collection roots; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C40980
        public void get_IsValid(){} // RVA: 0x3C2850
        public void get_ChainElements(){} // RVA: 0x2E07C0
        public void get_ChainPolicy(){} // RVA: 0x30B0C0
        public void AddStatus(){} // RVA: 0x2DD310
        public void Build(){} // RVA: 0x6C40AD0
        public void Reset(){} // RVA: 0x6C412A0
        public void get_Roots(){} // RVA: 0x6C416A0
        public void get_CertificateAuthorities(){} // RVA: 0x6C418A0
        public void get_LMRootStore(){} // RVA: 0x6C41AA0
        public void get_UserRootStore(){} // RVA: 0x6C41B90
        public void get_LMCAStore(){} // RVA: 0x6C41C80
        public void get_UserCAStore(){} // RVA: 0x6C41D70
        public void get_CertificateCollection(){} // RVA: 0x6C41E60
        public void BuildChainFrom(){} // RVA: 0x6C420E0
        public void SelectBestFromCollection(){} // RVA: 0x6C42320
        public void FindParent(){} // RVA: 0x6C42550
        public void IsChainComplete(){} // RVA: 0x6C42700
        public void IsSelfIssued(){} // RVA: 0x6C42840
        public void ValidateChain(){} // RVA: 0x6C428D0
        public void Process(){} // RVA: 0x6C42B80
        public void PrepareForNextCertificate(){} // RVA: 0x6C42F00
        public void WrapUp(){} // RVA: 0x6C432A0
        public void ProcessCertificateExtensions(){} // RVA: 0x6C43370
        public void IsSignedWith(){} // RVA: 0x6C43500
        public void GetSubjectKeyIdentifier(){} // RVA: 0x6C43550
        public void GetAuthorityKeyIdentifier(){} // RVA: 0x6C43740 | overloaded x3
        public void CheckRevocationOnChain(){} // RVA: 0x6C439E0
        public void CheckRevocation(){} // RVA: 0x6C43D90 | overloaded x2
        public void CheckCrls(){} // RVA: 0x6C44010
        public void FindCrl(){} // RVA: 0x6C443D0
        public void ProcessCrlExtensions(){} // RVA: 0x6C44580
        public void ProcessCrlEntryExtensions(){} // RVA: 0x6C44810
        public void .cctor(){} // RVA: 0x6C44A50
    }

    public class X509ChainPolicy
    {
        public System.Security.Cryptography.OidCollection Status; // 0x10
        public System.Security.Cryptography.OidCollection StatusInformation; // 0x18
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection store; // 0x20
        public System.Security.Cryptography.X509Certificates.X509Certificate2Collection store2; // 0x28
        public 0x6584C990 rflag; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C44B00
        public void get_ExtraStore(){} // RVA: 0x6C44B10
        public void set_ExtraStore(){} // RVA: 0x2DEE90
        public void get_RevocationFlag(){} // RVA: 0x338CD0
        public void get_RevocationMode(){} // RVA: 0x4C6670
        public void set_RevocationMode(){} // RVA: 0x6C44DD0
        public void get_VerificationFlags(){} // RVA: 0x37E080
        public void set_VerificationFlags(){} // RVA: 0x6C44E40
        public void get_VerificationTime(){} // RVA: 0x358730
        public void Reset(){} // RVA: 0x6C44EB0
    }

    public class X509ChainStatus
    {
        public 0x6584C830 EnhancedKeyUsages; // 0x10
        public string info; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C450B0
        public void get_Status(){} // RVA: 0x19689B0
        public void set_Status(){} // RVA: 0x833580
        public void set_StatusInformation(){} // RVA: 0x1968950
        public void GetInformation(){} // RVA: 0x6C45120
    }

    public class X509EnhancedKeyUsageExtension
    {
        public System.Security.Cryptography.OidCollection _enhKeyUsage; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C454F0 | overloaded x3
        public void get_EnhancedKeyUsages(){} // RVA: 0x6C45770
        public void CopyFrom(){} // RVA: 0x6C458E0
        public void Decode(){} // RVA: 0x6C45AE0
        public void Encode(){} // RVA: 0x6C45CE0
        public void ToString(){} // RVA: 0x6C45F20
    }

    public class X509Extension
    {
        public bool _critical; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C462F0 | overloaded x2
        public void get_Critical(){} // RVA: 0x3CB9D0
        public void set_Critical(){} // RVA: 0x3CB9E0
        public void CopyFrom(){} // RVA: 0x6C463D0
        public void FormatUnkownData(){} // RVA: 0x6C46570
    }

    public class X509ExtensionCollection
    {
        public byte[] Empty;
        public System.Collections.ArrayList _list; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C46750
        public void get_Count(){} // RVA: 0x5DFC050
        public void get_IsSynchronized(){} // RVA: 0x797560
        public void get_SyncRoot(){} // RVA: 0x1A3F520
        public void get_Item(){} // RVA: 0x6C467F0
        public void Add(){} // RVA: 0x6C46AA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x6C46B30
        public void GetEnumerator(){} // RVA: 0x6C46C80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6C46D50
        public void .cctor(){} // RVA: 0x6C46E20
    }

    public class X509ExtensionEnumerator
    {
        public System.Collections.IEnumerator enumerator; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C46ED0
        public void get_Current(){} // RVA: 0x6C46F50
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x6C46FF0
        public void MoveNext(){} // RVA: 0x6C47040
        public void Reset(){} // RVA: 0x6C47090
    }

    public class X509Helper
    {
        // ── Methods ──
        public void get_CertificateProvider(){} // RVA: 0x5CB2950
        public void InitFromCertificate(){} // RVA: 0x5CB2AA0 | overloaded x2
        public void IsValid(){} // RVA: 0x5CB2AC0
        public void ThrowIfContextInvalid(){} // RVA: 0x5CB2AE0
        public void GetInvalidContextException(){} // RVA: 0x5CB2B30
        public void Import(){} // RVA: 0x5CB2C70 | overloaded x2
    }

    public class X509Helper2
    {
        // ── Methods ──
        public void GetMonoCertificate(){} // RVA: 0x6C470E0
        public void CreateChainImpl(){} // RVA: 0x6C471D0
        public void IsValid(){} // RVA: 0x5CB2AC0
        public void ThrowIfContextInvalid(){} // RVA: 0x6C47360
        public void GetInvalidChainContextException(){} // RVA: 0x6C473B0
    }

    public class X509KeyUsageExtension
    {
        public string oid;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C47680 | overloaded x3
        public void get_KeyUsages(){} // RVA: 0x6C477A0
        public void CopyFrom(){} // RVA: 0x6C47810
        public void GetValidFlags(){} // RVA: 0x6C47A10
        public void Decode(){} // RVA: 0x6C47A20
        public void Encode(){} // RVA: 0x6C47B80
        public void ToString(){} // RVA: 0x6C47E30
    }

    public class X509Store
    {
        public string _name; // 0x10
        public 0x6584C728 _location; // 0x18
        public System.Security.Cryptography.X509Certificates.X509Certificate2Collection list; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C484E0
        public void get_Certificates(){} // RVA: 0x6C48630
        public void get_Factory(){} // RVA: 0x6C48700
        public void get_Store(){} // RVA: 0x6374D0
        public void Close(){} // RVA: 0x6C48720
        public void Dispose(){} // RVA: 0x6C487F0
        public void Open(){} // RVA: 0x6C48800
    }

    public class X509SubjectKeyIdentifierExtension
    {
        public string oid;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C494C0 | overloaded x6
        public void get_SubjectKeyIdentifier(){} // RVA: 0x6C49A50
        public void CopyFrom(){} // RVA: 0x6C49B20
        public void FromHexChar(){} // RVA: 0x6C49D20
        public void FromHexChars(){} // RVA: 0x6C49D50
        public void FromHex(){} // RVA: 0x6C49DD0
        public void Decode(){} // RVA: 0x6C49F40
        public void Encode(){} // RVA: 0x6C4A0D0
        public void ToString(){} // RVA: 0x6C4A180
    }

}