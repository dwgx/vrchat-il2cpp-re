// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography.X509Certificates
// Classes: 31
// Methods: 382

namespace ThirdParty.DotNet.System.Security.Cryptography.X509Certificates
{
    public class PublicKey : Object
    {
        public string rsaOid;
        public string dsaOid;
        public System.Security.Cryptography.AsymmetricAlgorithm _key; // 0x10
        public System.Security.Cryptography.AsnEncodedData _keyValue; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87775100
        public void get_EncodedKeyValue(){} // RVA: 0x7FFE810FE7C0
        public void get_EncodedParameters(){} // RVA: 0x7FFE811290C0
        public void get_Key(){} // RVA: 0x7FFE877752F0
        public void get_Oid(){} // RVA: 0x7FFE81129130
        public void GetUnsignedBigInteger(){} // RVA: 0x7FFE87775520
        public void DecodeDSA(){} // RVA: 0x7FFE877755D0
        public void DecodeRSA(){} // RVA: 0x7FFE87775B80
        public void .cctor(){} // RVA: 0x7FFE87775F90
    }

    public class RSACertificateExtensions : Object
    {
        // ── Methods ──
        public void GetRSAPublicKey(){} // RVA: 0x7FFE870E6100
    }

    public class X500DistinguishedName : AsnEncodedData
    {
        public 0x6652A77C AllFlags;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87776190 | overloaded x3
        public void get_Name(){} // RVA: 0x7FFE811290C0
        public void Decode(){} // RVA: 0x7FFE877764E0
        public void Format(){} // RVA: 0x7FFE877766B0
        public void GetSeparator(){} // RVA: 0x7FFE87776720
        public void DecodeRawData(){} // RVA: 0x7FFE87776790
        public void Canonize(){} // RVA: 0x7FFE87776940
        public void AreEqual(){} // RVA: 0x7FFE87776B70
    }

    public class X509BasicConstraintsExtension : X509Extension
    {
        public string oid;
        public string friendlyName;
        public bool _certificateAuthority; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87776FF0 | overloaded x3
        public void get_CertificateAuthority(){} // RVA: 0x7FFE87777160
        public void get_HasPathLengthConstraint(){} // RVA: 0x7FFE877771D0
        public void get_PathLengthConstraint(){} // RVA: 0x7FFE87777240
        public void CopyFrom(){} // RVA: 0x7FFE877772B0
        public void Decode(){} // RVA: 0x7FFE877774B0
        public void Encode(){} // RVA: 0x7FFE87777620
        public void ToString(){} // RVA: 0x7FFE87777870
    }

    public class X509Certificate : Object
    {
        public System.Security.Cryptography.X509Certificates.X509CertificateImpl impl; // 0x10
        public byte[] lazyCertHash; // 0x18
        public byte[] lazySerialNumber; // 0x20
        public string lazyIssuer; // 0x28

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFE867F0AC0
        public void .ctor(){} // RVA: 0x7FFE867F1740 | overloaded x9
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE867F1790
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFE867F17D0
        public void get_Issuer(){} // RVA: 0x7FFE867F1810
        public void get_Subject(){} // RVA: 0x7FFE867F1900
        public void Dispose(){} // RVA: 0x7FFE867F1A10 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE867F1AE0 | overloaded x2
        public void Export(){} // RVA: 0x7FFE867F1C10
        public void GetCertHash(){} // RVA: 0x7FFE867F1DE0
        public void GetCertHashString(){} // RVA: 0x7FFE867F1EB0
        public void GetRawCertHash(){} // RVA: 0x7FFE867F1F30
        public void GetPublicKeyString(){} // RVA: 0x7FFE867F1FC0
        public void GetRawCertData(){} // RVA: 0x7FFE867F2000
        public void GetHashCode(){} // RVA: 0x7FFE867F20F0
        public void GetKeyAlgorithm(){} // RVA: 0x7FFE867F21F0
        public void GetKeyAlgorithmParameters(){} // RVA: 0x7FFE867F22E0
        public void GetPublicKey(){} // RVA: 0x7FFE867F2430
        public void GetSerialNumber(){} // RVA: 0x7FFE867F2580
        public void GetSerialNumberString(){} // RVA: 0x7FFE867F26F0
        public void GetRawSerialNumber(){} // RVA: 0x7FFE867F2770
        public void ToString(){} // RVA: 0x7FFE867F2820 | overloaded x2
        public void GetNotAfter(){} // RVA: 0x7FFE867F2D50
        public void GetNotBefore(){} // RVA: 0x7FFE867F2E80
        public void FormatDate(){} // RVA: 0x7FFE867F2FB0
        public void ValidateKeyStorageFlags(){} // RVA: 0x7FFE867F3240
        public void VerifyContentType(){} // RVA: 0x7FFE867F3360
        public void ImportHandle(){} // RVA: 0x7FFE867F33D0
        public void get_Impl(){} // RVA: 0x7FFE81116380
        public void get_IsValid(){} // RVA: 0x7FFE867F3450
        public void ThrowIfInvalid(){} // RVA: 0x7FFE867F3470
    }

    public class X509Certificate2 : X509Certificate
    {
        public byte[] lazyRawData; // 0x60
        public System.Security.Cryptography.Oid lazySignatureAlgorithm; // 0x68
        public int lazyVersion; // 0x70
        public System.Security.Cryptography.X509Certificates.X500DistinguishedName lazySubjectName; // 0x78
        public System.Security.Cryptography.X509Certificates.X500DistinguishedName lazyIssuerName; // 0x80
        public System.Security.Cryptography.X509Certificates.PublicKey lazyPublicKey; // 0x88
        public System.Security.Cryptography.AsymmetricAlgorithm lazyPrivateKey; // 0x90
        public System.Security.Cryptography.X509Certificates.X509ExtensionCollection lazyExtensions; // 0x98
        public object field_8; // 0x151
        public object field_9; // 0x152
        public object field_10; // 0x153
        public object field_11; // 0x154
        public object field_12; // 0x155
        public object field_13; // 0x156

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFE87777B30
        public void .ctor(){} // RVA: 0x7FFE87777FB0 | overloaded x7
        public void get_Extensions(){} // RVA: 0x7FFE87777FD0
        public void get_HasPrivateKey(){} // RVA: 0x7FFE87778400
        public void get_PrivateKey(){} // RVA: 0x7FFE87778480
        public void get_IssuerName(){} // RVA: 0x7FFE877786B0
        public void get_NotAfter(){} // RVA: 0x7FFE877787C0
        public void get_NotBefore(){} // RVA: 0x7FFE877787D0
        public void get_PublicKey(){} // RVA: 0x7FFE877787E0
        public void get_RawData(){} // RVA: 0x7FFE87778A10
        public void get_SerialNumber(){} // RVA: 0x7FFE844E23A0
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFE87778B70
        public void get_SubjectName(){} // RVA: 0x7FFE87778C80
        public void get_Thumbprint(){} // RVA: 0x7FFE87778D80
        public void get_Version(){} // RVA: 0x7FFE87778DC0
        public void GetCertContentType(){} // RVA: 0x7FFE87778E60
        public void GetNameInfo(){} // RVA: 0x7FFE87778F00
        public void ToString(){} // RVA: 0x7FFE87778F60 | overloaded x2
        public void Verify(){} // RVA: 0x7FFE87779FF0
        public void CreateCustomExtensionIfAny(){} // RVA: 0x7FFE8777A030
        public void get_Impl(){} // RVA: 0x7FFE8777A530
    }

    public class X509Certificate2Collection : X509CertificateCollection
    {
        public string[] newline_split;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8777A5F0 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFE8777A690
        public void Add(){} // RVA: 0x7FFE8777A800
        public void AddRange(){} // RVA: 0x7FFE8777A890
        public void Contains(){} // RVA: 0x7FFE8777A920
        public void GetKeyIdentifier(){} // RVA: 0x7FFE8777AB60
        public void Find(){} // RVA: 0x7FFE8777AC40
        public void GetEnumerator(){} // RVA: 0x7FFE8777C070
        public void .cctor(){} // RVA: 0x7FFE8777C150
    }

    public class X509Certificate2Enumerator : Object
    {
        public System.Collections.IEnumerator enumerator; // 0x10
        public object field_1; // 0x160

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8777C220
        public void get_Current(){} // RVA: 0x7FFE8777C2D0
        public void MoveNext(){} // RVA: 0x7FFE8777C370
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE8777C3C0
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7FFE8777C410
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE8777C460
    }

    public class X509Certificate2Impl : X509CertificateImpl
    {
        // ── Methods ──
        public void get_Extensions(){} // RVA: 0x7FFE80E2E2E0
        public void get_IssuerName(){} // RVA: 0x7FFE80E2E2E0
        public void get_PrivateKey(){} // RVA: 0x7FFE80E2E2E0
        public void set_PrivateKey(){} // RVA: 0x7FFE80E460A0
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFE80E2E2E0
        public void get_SubjectName(){} // RVA: 0x7FFE80E2E2E0
        public void get_Version(){} // RVA: 0x7FFE80E2EDB0
        public void get_IntermediateCertificates(){} // RVA: 0x7FFE80E2E2E0
        public void GetNameInfo(){}
        public void Verify(){} // RVA: 0x7FFE80E2F3B0
        public void AppendPrivateKeyInfo(){} // RVA: 0x7FFE80E460A0
        public void CopyWithPrivateKey(){} // RVA: 0x7FFE8777C4B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class X509Certificate2ImplMono : X509Certificate2ImplUnix
    {
        public System.Security.Cryptography.X509Certificates.X509CertificateImplCollection intermediateCerts; // 0xB0
        public Mono.Security.X509.X509Certificate _cert; // 0xB8
        public string empty_error;
        public byte[] signedData; // 0x8
        public object field_4; // 0x169
        public object field_5; // 0x16A

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFE874D9180
        public void .ctor(){} // RVA: 0x7FFE8777C6C0 | overloaded x3
        public void Clone(){} // RVA: 0x7FFE8777C940
        public void get_Cert(){} // RVA: 0x7FFE87725CE0
        public void GetRawCertData(){} // RVA: 0x7FFE8777CB00
        public void get_HasPrivateKey(){} // RVA: 0x7FFE8777CBB0
        public void get_PrivateKey(){} // RVA: 0x7FFE8777CBE0
        public void set_PrivateKey(){} // RVA: 0x7FFE8777D050
        public void GetRSAPrivateKey(){} // RVA: 0x7FFE8777D310
        public void GetDSAPrivateKey(){} // RVA: 0x7FFE8777D3B0
        public void ImportPkcs12(){} // RVA: 0x7FFE8777D4F0 | overloaded x2
        public void Verify(){} // RVA: 0x7FFE8777DD50
        public void get_IntermediateCertificates(){} // RVA: 0x7FFE81166040
        public void get_MonoCertificate(){} // RVA: 0x7FFE811660B0
        public void .cctor(){} // RVA: 0x7FFE8777DE40
    }

    public class X509Certificate2ImplUnix : X509Certificate2Impl
    {
        public bool readCertData; // 0x10
        public Internal.Cryptography.Pal.CertificateData certData; // 0x18
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

        // ── Methods ──
        public void EnsureCertData(){} // RVA: 0x7FFE8777DFC0
        public void GetRawCertData(){} // RVA: 0x7FFE80E2E2E0
        public void get_KeyAlgorithm(){} // RVA: 0x7FFE8777E150
        public void get_KeyAlgorithmParameters(){} // RVA: 0x7FFE8777E170
        public void get_PublicKeyValue(){} // RVA: 0x7FFE8777E190
        public void get_SerialNumber(){} // RVA: 0x7FFE8777E1B0
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFE8777E1D0
        public void get_Version(){} // RVA: 0x7FFE8777E1F0
        public void get_SubjectName(){} // RVA: 0x7FFE8777E210
        public void get_IssuerName(){} // RVA: 0x7FFE8777E230
        public void get_Subject(){} // RVA: 0x7FFE8777E250
        public void get_Issuer(){} // RVA: 0x7FFE8777E280
        public void get_RawData(){} // RVA: 0x7FFE8777E2B0
        public void get_Thumbprint(){} // RVA: 0x7FFE8777E2D0
        public void GetNameInfo(){} // RVA: 0x7FFE8777E4A0
        public void get_Extensions(){} // RVA: 0x7FFE8777E4E0
        public void get_NotAfter(){} // RVA: 0x7FFE8777E500
        public void get_NotBefore(){} // RVA: 0x7FFE8777E5A0
        public void AppendPrivateKeyInfo(){} // RVA: 0x7FFE8777E640
        public void Export(){} // RVA: 0x7FFE8777E700
        public void ExportPkcs12(){} // RVA: 0x7FFE8777E960 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class X509CertificateCollection : CollectionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8777EDE0 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFE8777EE10
        public void Add(){} // RVA: 0x7FFE8777EEB0
        public void AddRange(){} // RVA: 0x7FFE8777EF40
        public void GetEnumerator(){} // RVA: 0x7FFE8777F020
        public void GetHashCode(){} // RVA: 0x7FFE8170B620
    }

    public class X509CertificateImpl : Object
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFE80E2F150
        public void ThrowIfContextInvalid(){} // RVA: 0x7FFE867F34D0
        public void Clone(){} // RVA: 0x7FFE80E2E2E0
        public void get_Issuer(){} // RVA: 0x7FFE80E2E2E0
        public void get_Subject(){} // RVA: 0x7FFE80E2E2E0
        public void get_RawData(){} // RVA: 0x7FFE80E2E2E0
        public void get_NotAfter(){} // RVA: 0x7FFE80E2E2E0
        public void get_NotBefore(){} // RVA: 0x7FFE80E2E2E0
        public void get_Thumbprint(){} // RVA: 0x7FFE80E2E2E0
        public void GetHashCode(){} // RVA: 0x7FFE867F3520
        public void get_KeyAlgorithm(){} // RVA: 0x7FFE80E2E2E0
        public void get_KeyAlgorithmParameters(){} // RVA: 0x7FFE80E2E2E0
        public void get_PublicKeyValue(){} // RVA: 0x7FFE80E2E2E0
        public void get_SerialNumber(){} // RVA: 0x7FFE80E2E2E0
        public void get_HasPrivateKey(){} // RVA: 0x7FFE80E2F150
        public void GetRSAPrivateKey(){} // RVA: 0x7FFE80E2E2E0
        public void GetDSAPrivateKey(){} // RVA: 0x7FFE80E2E2E0
        public void Export(){} // RVA: 0x7FFE80E3E450
        public void CopyWithPrivateKey(){} // RVA: 0x7FFE80E2E390
        public void Equals(){} // RVA: 0x7FFE867F35C0
        public void Dispose(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE867F3800
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class X509CertificateImplCollection : Object
    {
        public System.Collections.Generic.List`1<System.Security.Cryptography.X509Certificates.X509CertificateImpl> list; // 0x10
        public object field_1; // 0x181

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8777F450 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFE8777F6F0
        public void get_Item(){} // RVA: 0x7FFE8777F740
        public void Add(){} // RVA: 0x7FFE8777F7C0
        public void Clone(){} // RVA: 0x7FFE8777F850
        public void Dispose(){} // RVA: 0x7FFE8777F920 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE865ED780
    }

    public class X509Chain : Object
    {
        public System.Security.Cryptography.X509Certificates.X509ChainImpl impl; // 0x10
        public object field_1; // 0x183
        public object field_2; // 0x184

        // ── Methods ──
        public void get_Impl(){} // RVA: 0x7FFE8777FAC0
        public void .ctor(){} // RVA: 0x7FFE8777FDE0 | overloaded x4
        public void get_ChainElements(){} // RVA: 0x7FFE8777FE20
        public void get_ChainPolicy(){} // RVA: 0x7FFE8777FEA0
        public void Build(){} // RVA: 0x7FFE8777FF20
        public void Reset(){} // RVA: 0x7FFE8777FFB0
        public void Create(){} // RVA: 0x7FFE87780030
        public void Dispose(){} // RVA: 0x7FFE877800F0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE865ED780
    }

    public class X509ChainElement : Object
    {
        public System.Security.Cryptography.X509Certificates.X509Certificate2 certificate; // 0x10
        public System.Security.Cryptography.X509Certificates.X509ChainStatus[] status; // 0x18
        public string info; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877801D0
        public void get_Certificate(){} // RVA: 0x7FFE81116380
        public void get_ChainElementStatus(){} // RVA: 0x7FFE810FE7C0
        public void get_StatusFlags(){} // RVA: 0x7FFE81549710
        public void set_StatusFlags(){} // RVA: 0x7FFE817E4800
        public void Count(){} // RVA: 0x7FFE877802D0
        public void Set(){} // RVA: 0x7FFE87780300
        public void UncompressFlags(){} // RVA: 0x7FFE877803C0
    }

    public class X509ChainElementCollection : Object
    {
        public System.Collections.ArrayList _list; // 0x10
        public object field_1; // 0x189
        public object field_2; // 0x18A
        public object field_3; // 0x18B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87781090
        public void get_Count(){} // RVA: 0x7FFE8154F670
        public void get_IsSynchronized(){} // RVA: 0x7FFE8693D0E0
        public void get_Item(){} // RVA: 0x7FFE87781130
        public void get_SyncRoot(){} // RVA: 0x7FFE8693D110
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE8693D140
        public void GetEnumerator(){} // RVA: 0x7FFE877811D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE87781230
        public void Add(){} // RVA: 0x7FFE87781290
        public void Clear(){} // RVA: 0x7FFE872B3100
        public void Contains(){} // RVA: 0x7FFE877813F0
    }

    public class X509ChainElementEnumerator : Object
    {
        public System.Collections.IEnumerator enumerator; // 0x10
        public object field_1; // 0x18D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87781530
        public void get_Current(){} // RVA: 0x7FFE877815E0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE87781680
        public void MoveNext(){} // RVA: 0x7FFE877816D0
        public void Reset(){} // RVA: 0x7FFE87781720
    }

    public class X509ChainImpl : Object
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFE80E2F150
        public void ThrowIfContextInvalid(){} // RVA: 0x7FFE87781770
        public void get_ChainElements(){} // RVA: 0x7FFE80E2E2E0
        public void get_ChainPolicy(){} // RVA: 0x7FFE80E2E2E0
        public void Build(){} // RVA: 0x7FFE80E2F3B0
        public void AddStatus(){} // RVA: 0x7FFE80E46530
        public void Reset(){} // RVA: 0x7FFE80E45FE0
        public void Dispose(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE86754C20
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class X509ChainImplMono : X509ChainImpl
    {
        public 0x6652A6CC location; // 0x10
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
        public void .ctor(){} // RVA: 0x7FFE87781830
        public void get_IsValid(){} // RVA: 0x7FFE811E0850
        public void get_ChainElements(){} // RVA: 0x7FFE810FE7C0
        public void get_ChainPolicy(){} // RVA: 0x7FFE811290C0
        public void AddStatus(){} // RVA: 0x7FFE810FB310
        public void Build(){} // RVA: 0x7FFE87781980
        public void Reset(){} // RVA: 0x7FFE87782150
        public void get_Roots(){} // RVA: 0x7FFE87782550
        public void get_CertificateAuthorities(){} // RVA: 0x7FFE87782750
        public void get_LMRootStore(){} // RVA: 0x7FFE87782950
        public void get_UserRootStore(){} // RVA: 0x7FFE87782A40
        public void get_LMCAStore(){} // RVA: 0x7FFE87782B30
        public void get_UserCAStore(){} // RVA: 0x7FFE87782C20
        public void get_CertificateCollection(){} // RVA: 0x7FFE87782D10
        public void BuildChainFrom(){} // RVA: 0x7FFE87782F90
        public void SelectBestFromCollection(){} // RVA: 0x7FFE877831D0
        public void FindParent(){} // RVA: 0x7FFE87783400
        public void IsChainComplete(){} // RVA: 0x7FFE877835B0
        public void IsSelfIssued(){} // RVA: 0x7FFE877836F0
        public void ValidateChain(){} // RVA: 0x7FFE87783780
        public void Process(){} // RVA: 0x7FFE87783A30
        public void PrepareForNextCertificate(){} // RVA: 0x7FFE87783DB0
        public void WrapUp(){} // RVA: 0x7FFE87784150
        public void ProcessCertificateExtensions(){} // RVA: 0x7FFE87784220
        public void IsSignedWith(){} // RVA: 0x7FFE877843B0
        public void GetSubjectKeyIdentifier(){} // RVA: 0x7FFE87784400
        public void GetAuthorityKeyIdentifier(){} // RVA: 0x7FFE877845F0 | overloaded x3
        public void CheckRevocationOnChain(){} // RVA: 0x7FFE87784890
        public void CheckRevocation(){} // RVA: 0x7FFE87784C40 | overloaded x2
        public void CheckCrls(){} // RVA: 0x7FFE87784EC0
        public void FindCrl(){} // RVA: 0x7FFE87785280
        public void ProcessCrlExtensions(){} // RVA: 0x7FFE87785430
        public void ProcessCrlEntryExtensions(){} // RVA: 0x7FFE877856C0
        public void .cctor(){} // RVA: 0x7FFE87785900
    }

    public class X509ChainPolicy : Object
    {
        public System.Security.Cryptography.OidCollection apps; // 0x10
        public System.Security.Cryptography.OidCollection cert; // 0x18
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection store; // 0x20
        public System.Security.Cryptography.X509Certificates.X509Certificate2Collection store2; // 0x28
        public 0x6652A934 rflag; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877859B0
        public void get_ExtraStore(){} // RVA: 0x7FFE877859C0
        public void set_ExtraStore(){} // RVA: 0x7FFE810FCE90
        public void get_RevocationFlag(){} // RVA: 0x7FFE81156CD0
        public void get_RevocationMode(){} // RVA: 0x7FFE82447220
        public void set_RevocationMode(){} // RVA: 0x7FFE87785C80
        public void get_VerificationFlags(){} // RVA: 0x7FFE8119C080
        public void set_VerificationFlags(){} // RVA: 0x7FFE87785CF0
        public void get_VerificationTime(){} // RVA: 0x7FFE81176730
        public void Reset(){} // RVA: 0x7FFE87785D60
    }

    public class X509ChainStatus : ValueType
    {
        public 0x6652A7D4 status; // 0x10
        public string info; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87785F60
        public void get_Status(){} // RVA: 0x7FFE826F4220
        public void set_Status(){} // RVA: 0x7FFE815BF990
        public void set_StatusInformation(){} // RVA: 0x7FFE826F4230
        public void GetInformation(){} // RVA: 0x7FFE87785FD0
    }

    public class X509EnhancedKeyUsageExtension : X509Extension
    {
        public System.Security.Cryptography.OidCollection _enhKeyUsage; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877863A0 | overloaded x3
        public void get_EnhancedKeyUsages(){} // RVA: 0x7FFE87786620
        public void CopyFrom(){} // RVA: 0x7FFE87786790
        public void Decode(){} // RVA: 0x7FFE87786990
        public void Encode(){} // RVA: 0x7FFE87786B90
        public void ToString(){} // RVA: 0x7FFE87786DD0
    }

    public class X509Extension : AsnEncodedData
    {
        public bool _critical; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877871A0 | overloaded x2
        public void get_Critical(){} // RVA: 0x7FFE811E99D0
        public void set_Critical(){} // RVA: 0x7FFE811E99E0
        public void CopyFrom(){} // RVA: 0x7FFE87787280
        public void FormatUnkownData(){} // RVA: 0x7FFE87787420
    }

    public class X509ExtensionCollection : Object
    {
        public byte[] Empty;
        public System.Collections.ArrayList _list; // 0x10
        public object field_2; // 0x1A5
        public object field_3; // 0x1A6

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87787600
        public void get_Count(){} // RVA: 0x7FFE8154F670
        public void get_IsSynchronized(){} // RVA: 0x7FFE8693D0E0
        public void get_SyncRoot(){} // RVA: 0x7FFE827C4A80
        public void get_Item(){} // RVA: 0x7FFE877876A0
        public void Add(){} // RVA: 0x7FFE87787950
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE877879E0
        public void GetEnumerator(){} // RVA: 0x7FFE87787B30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE87787C00
        public void .cctor(){} // RVA: 0x7FFE87787CD0
    }

    public class X509ExtensionEnumerator : Object
    {
        public System.Collections.IEnumerator enumerator; // 0x10
        public object field_1; // 0x1A9

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87787D80
        public void get_Current(){} // RVA: 0x7FFE87787E00
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE87787EA0
        public void MoveNext(){} // RVA: 0x7FFE87787EF0
        public void Reset(){} // RVA: 0x7FFE87787F40
    }

    public class X509Helper : Object
    {
        // ── Methods ──
        public void get_CertificateProvider(){} // RVA: 0x7FFE867F3850
        public void InitFromCertificate(){} // RVA: 0x7FFE867F39A0 | overloaded x2
        public void IsValid(){} // RVA: 0x7FFE867F39C0
        public void ThrowIfContextInvalid(){} // RVA: 0x7FFE867F39E0
        public void GetInvalidContextException(){} // RVA: 0x7FFE867F3A30
        public void Import(){} // RVA: 0x7FFE867F3B70 | overloaded x2
    }

    public class X509Helper2 : Object
    {
        // ── Methods ──
        public void GetMonoCertificate(){} // RVA: 0x7FFE87787F90
        public void CreateChainImpl(){} // RVA: 0x7FFE87788080
        public void IsValid(){} // RVA: 0x7FFE867F39C0
        public void ThrowIfContextInvalid(){} // RVA: 0x7FFE87788210
        public void GetInvalidChainContextException(){} // RVA: 0x7FFE87788260
    }

    public class X509KeyUsageExtension : X509Extension
    {
        public string oid;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87788530 | overloaded x3
        public void get_KeyUsages(){} // RVA: 0x7FFE87788650
        public void CopyFrom(){} // RVA: 0x7FFE877886C0
        public void GetValidFlags(){} // RVA: 0x7FFE877888C0
        public void Decode(){} // RVA: 0x7FFE877888D0
        public void Encode(){} // RVA: 0x7FFE87788A30
        public void ToString(){} // RVA: 0x7FFE87788CE0
    }

    public class X509Store : Object
    {
        public string _name; // 0x10
        public 0x6652A6CC _location; // 0x18
        public System.Security.Cryptography.X509Certificates.X509Certificate2Collection list; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87789390
        public void get_Certificates(){} // RVA: 0x7FFE877894E0
        public void get_Factory(){} // RVA: 0x7FFE877895B0
        public void get_Store(){} // RVA: 0x7FFE8144E200
        public void Close(){} // RVA: 0x7FFE877895D0
        public void Dispose(){} // RVA: 0x7FFE877896A0
        public void Open(){} // RVA: 0x7FFE877896B0
    }

    public class X509SubjectKeyIdentifierExtension : X509Extension
    {
        public string oid;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8778A370 | overloaded x6
        public void get_SubjectKeyIdentifier(){} // RVA: 0x7FFE8778A900
        public void CopyFrom(){} // RVA: 0x7FFE8778A9D0
        public void FromHexChar(){} // RVA: 0x7FFE8778ABD0
        public void FromHexChars(){} // RVA: 0x7FFE8778AC00
        public void FromHex(){} // RVA: 0x7FFE8778AC80
        public void Decode(){} // RVA: 0x7FFE8778ADF0
        public void Encode(){} // RVA: 0x7FFE8778AF80
        public void ToString(){} // RVA: 0x7FFE8778B030
    }

}