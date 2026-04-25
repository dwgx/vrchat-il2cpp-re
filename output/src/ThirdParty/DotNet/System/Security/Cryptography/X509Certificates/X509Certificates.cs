// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography.X509Certificates
// Classes: 31
// Methods: 382

namespace ThirdParty.DotNet.System.Security.Cryptography.X509Certificates
{
    public class PublicKey : Object
    {
        public string EncodedKeyValue;
        public string EncodedParameters;
        public System.Security.Cryptography.AsymmetricAlgorithm Key; // 0x10
        public System.Security.Cryptography.AsnEncodedData Oid; // 0x18
        public System.Security.Cryptography.AsnEncodedData _params; // 0x20
        public System.Security.Cryptography.Oid _oid; // 0x28
        public byte[] Empty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93CC9D0
        public void get_EncodedKeyValue(){} // RVA: 0x7FFAC2F247C0
        public void get_EncodedParameters(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Key(){} // RVA: 0x7FFAC93CCBC0
        public void get_Oid(){} // RVA: 0x7FFAC2F4F130
        public void GetUnsignedBigInteger(){} // RVA: 0x7FFAC93CCDF0
        public void DecodeDSA(){} // RVA: 0x7FFAC93CCEA0
        public void DecodeRSA(){} // RVA: 0x7FFAC93CD450
        public void .cctor(){} // RVA: 0x7FFAC93CD860
    }

    public class RSACertificateExtensions : Object
    {
        // ── Methods ──
        public void GetRSAPublicKey(){} // RVA: 0x7FFAC8D3DC40
    }

    public class X500DistinguishedName : AsnEncodedData
    {
        public 0x6B131858 Name;
        public string name; // 0x20
        public byte[] canonEncoding; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93CDA60 | overloaded x3
        public void get_Name(){} // RVA: 0x7FFAC2F4F0C0
        public void Decode(){} // RVA: 0x7FFAC93CDDB0
        public void Format(){} // RVA: 0x7FFAC93CDF80
        public void GetSeparator(){} // RVA: 0x7FFAC93CDFF0
        public void DecodeRawData(){} // RVA: 0x7FFAC93CE060
        public void Canonize(){} // RVA: 0x7FFAC93CE210
        public void AreEqual(){} // RVA: 0x7FFAC93CE440
    }

    public class X509BasicConstraintsExtension : X509Extension
    {
        public string CertificateAuthority;
        public string HasPathLengthConstraint;
        public bool PathLengthConstraint; // 0x28
        public bool _hasPathLengthConstraint; // 0x29
        public int _pathLengthConstraint; // 0x2C
        public 0x6B1316A0 _status; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93CE8C0 | overloaded x3
        public void get_CertificateAuthority(){} // RVA: 0x7FFAC93CEA30
        public void get_HasPathLengthConstraint(){} // RVA: 0x7FFAC93CEAA0
        public void get_PathLengthConstraint(){} // RVA: 0x7FFAC93CEB10
        public void CopyFrom(){} // RVA: 0x7FFAC93CEB80
        public void Decode(){} // RVA: 0x7FFAC93CED80
        public void Encode(){} // RVA: 0x7FFAC93CEEF0
        public void ToString(){} // RVA: 0x7FFAC93CF140
    }

    public class X509Certificate : Object
    {
        public System.Security.Cryptography.X509Certificates.X509CertificateImpl Issuer; // 0x10
        public byte[] Subject; // 0x18
        public byte[] Impl; // 0x20
        public string IsValid; // 0x28
        public string lazySubject; // 0x30
        public string lazyKeyAlgorithm; // 0x38
        public byte[] lazyKeyAlgorithmParameters; // 0x40
        public byte[] lazyPublicKey; // 0x48
        public System.DateTime lazyNotBefore; // 0x50
        public System.DateTime lazyNotAfter; // 0x58
        public 0x6B0CDE60 KeyStorageFlagsAll;

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAC84471B0
        public void .ctor(){} // RVA: 0x7FFAC8447E30 | overloaded x9
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC8447E80
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFAC8447EC0
        public void get_Issuer(){} // RVA: 0x7FFAC8447F00
        public void get_Subject(){} // RVA: 0x7FFAC8447FF0
        public void Dispose(){} // RVA: 0x7FFAC8448100 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC84481D0 | overloaded x2
        public void Export(){} // RVA: 0x7FFAC8448300
        public void GetCertHash(){} // RVA: 0x7FFAC84484D0
        public void GetCertHashString(){} // RVA: 0x7FFAC84485A0
        public void GetRawCertHash(){} // RVA: 0x7FFAC8448620
        public void GetPublicKeyString(){} // RVA: 0x7FFAC84486B0
        public void GetRawCertData(){} // RVA: 0x7FFAC84486F0
        public void GetHashCode(){} // RVA: 0x7FFAC84487E0
        public void GetKeyAlgorithm(){} // RVA: 0x7FFAC84488E0
        public void GetKeyAlgorithmParameters(){} // RVA: 0x7FFAC84489D0
        public void GetPublicKey(){} // RVA: 0x7FFAC8448B20
        public void GetSerialNumber(){} // RVA: 0x7FFAC8448C70
        public void GetSerialNumberString(){} // RVA: 0x7FFAC8448DE0
        public void GetRawSerialNumber(){} // RVA: 0x7FFAC8448E60
        public void ToString(){} // RVA: 0x7FFAC8448F10 | overloaded x2
        public void GetNotAfter(){} // RVA: 0x7FFAC8449440
        public void GetNotBefore(){} // RVA: 0x7FFAC8449570
        public void FormatDate(){} // RVA: 0x7FFAC84496A0
        public void ValidateKeyStorageFlags(){} // RVA: 0x7FFAC8449930
        public void VerifyContentType(){} // RVA: 0x7FFAC8449A50
        public void ImportHandle(){} // RVA: 0x7FFAC8449AC0
        public void get_Impl(){} // RVA: 0x7FFAC2F3C380
        public void get_IsValid(){} // RVA: 0x7FFAC8449B40
        public void ThrowIfInvalid(){} // RVA: 0x7FFAC8449B60
    }

    public class X509Certificate2 : X509Certificate
    {
        public byte[] Extensions; // 0x60
        public System.Security.Cryptography.Oid HasPrivateKey; // 0x68
        public int PrivateKey; // 0x70
        public System.Security.Cryptography.X509Certificates.X500DistinguishedName IssuerName; // 0x78
        public System.Security.Cryptography.X509Certificates.X500DistinguishedName NotAfter; // 0x80
        public System.Security.Cryptography.X509Certificates.PublicKey NotBefore; // 0x88
        public System.Security.Cryptography.AsymmetricAlgorithm PublicKey; // 0x90
        public System.Security.Cryptography.X509Certificates.X509ExtensionCollection RawData; // 0x98

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAC93CF400
        public void .ctor(){} // RVA: 0x7FFAC93CF880 | overloaded x7
        public void get_Extensions(){} // RVA: 0x7FFAC93CF8A0
        public void get_HasPrivateKey(){} // RVA: 0x7FFAC93CFCD0
        public void get_PrivateKey(){} // RVA: 0x7FFAC93CFD50
        public void get_IssuerName(){} // RVA: 0x7FFAC93CFF80
        public void get_NotAfter(){} // RVA: 0x7FFAC93D0090
        public void get_NotBefore(){} // RVA: 0x7FFAC93D00A0
        public void get_PublicKey(){} // RVA: 0x7FFAC93D00B0
        public void get_RawData(){} // RVA: 0x7FFAC93D02E0
        public void get_SerialNumber(){} // RVA: 0x7FFAC617D250
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAC93D0440
        public void get_SubjectName(){} // RVA: 0x7FFAC93D0550
        public void get_Thumbprint(){} // RVA: 0x7FFAC93D0650
        public void get_Version(){} // RVA: 0x7FFAC93D0690
        public void GetCertContentType(){} // RVA: 0x7FFAC93D0730
        public void GetNameInfo(){} // RVA: 0x7FFAC93D07D0
        public void ToString(){} // RVA: 0x7FFAC93D0830 | overloaded x2
        public void Verify(){} // RVA: 0x7FFAC93D18C0
        public void CreateCustomExtensionIfAny(){} // RVA: 0x7FFAC93D1900
        public void get_Impl(){} // RVA: 0x7FFAC93D1E00
    }

    public class X509Certificate2Collection : X509CertificateCollection
    {
        public string[] Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93D1EC0 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFAC93D1F60
        public void Add(){} // RVA: 0x7FFAC93D20D0
        public void AddRange(){} // RVA: 0x7FFAC93D2160
        public void Contains(){} // RVA: 0x7FFAC93D21F0
        public void GetKeyIdentifier(){} // RVA: 0x7FFAC93D2430
        public void Find(){} // RVA: 0x7FFAC93D2510
        public void GetEnumerator(){} // RVA: 0x7FFAC93D3940
        public void .cctor(){} // RVA: 0x7FFAC93D3A20
    }

    public class X509Certificate2Enumerator : Object
    {
        public System.Collections.IEnumerator Current; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93D3AF0
        public void get_Current(){} // RVA: 0x7FFAC93D3BA0
        public void MoveNext(){} // RVA: 0x7FFAC93D3C40
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC93D3C90
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7FFAC93D3CE0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC93D3D30
    }

    public class X509Certificate2Impl : X509CertificateImpl
    {
        public object Extensions;
        public object IssuerName;
        public object PrivateKey;
        public object SignatureAlgorithm;
        public object SubjectName;
        public object Version;
        public object IntermediateCertificates;

        // ── Methods ──
        public void get_Extensions(){} // RVA: 0x7FFAC2C58E90
        public void get_IssuerName(){} // RVA: 0x7FFAC2C58E90
        public void get_PrivateKey(){} // RVA: 0x7FFAC2C58E90
        public void set_PrivateKey(){} // RVA: 0x7FFAC2C70A40
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAC2C58E90
        public void get_SubjectName(){} // RVA: 0x7FFAC2C58E90
        public void get_Version(){} // RVA: 0x7FFAC2C59960
        public void get_IntermediateCertificates(){} // RVA: 0x7FFAC2C58E90
        public void GetNameInfo(){}
        public void Verify(){} // RVA: 0x7FFAC2C59F60
        public void AppendPrivateKeyInfo(){} // RVA: 0x7FFAC2C70A40
        public void CopyWithPrivateKey(){} // RVA: 0x7FFAC93D3D80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class X509Certificate2ImplMono : X509Certificate2ImplUnix
    {
        public System.Security.Cryptography.X509Certificates.X509CertificateImplCollection IsValid; // 0xB0
        public Mono.Security.X509.X509Certificate Cert; // 0xB8
        public string HasPrivateKey;
        public byte[] PrivateKey; // 0x8

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFAC91309D0
        public void .ctor(){} // RVA: 0x7FFAC93D3F90 | overloaded x3
        public void Clone(){} // RVA: 0x7FFAC93D4210
        public void get_Cert(){} // RVA: 0x7FFAC937D5B0
        public void GetRawCertData(){} // RVA: 0x7FFAC93D43D0
        public void get_HasPrivateKey(){} // RVA: 0x7FFAC93D4480
        public void get_PrivateKey(){} // RVA: 0x7FFAC93D44B0
        public void set_PrivateKey(){} // RVA: 0x7FFAC93D4920
        public void GetRSAPrivateKey(){} // RVA: 0x7FFAC93D4BE0
        public void GetDSAPrivateKey(){} // RVA: 0x7FFAC93D4C80
        public void ImportPkcs12(){} // RVA: 0x7FFAC93D4DC0 | overloaded x2
        public void Verify(){} // RVA: 0x7FFAC93D5620
        public void get_IntermediateCertificates(){} // RVA: 0x7FFAC2F8C040
        public void get_MonoCertificate(){} // RVA: 0x7FFAC2F8C0B0
        public void .cctor(){} // RVA: 0x7FFAC93D5710
    }

    public class X509Certificate2ImplUnix : X509Certificate2Impl
    {
        public bool KeyAlgorithm; // 0x10
        public Internal.Cryptography.Pal.CertificateData KeyAlgorithmParameters; // 0x18

        // ── Methods ──
        public void EnsureCertData(){} // RVA: 0x7FFAC93D5890
        public void GetRawCertData(){} // RVA: 0x7FFAC2C58E90
        public void get_KeyAlgorithm(){} // RVA: 0x7FFAC93D5A20
        public void get_KeyAlgorithmParameters(){} // RVA: 0x7FFAC93D5A40
        public void get_PublicKeyValue(){} // RVA: 0x7FFAC93D5A60
        public void get_SerialNumber(){} // RVA: 0x7FFAC93D5A80
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAC93D5AA0
        public void get_Version(){} // RVA: 0x7FFAC93D5AC0
        public void get_SubjectName(){} // RVA: 0x7FFAC93D5AE0
        public void get_IssuerName(){} // RVA: 0x7FFAC93D5B00
        public void get_Subject(){} // RVA: 0x7FFAC93D5B20
        public void get_Issuer(){} // RVA: 0x7FFAC93D5B50
        public void get_RawData(){} // RVA: 0x7FFAC93D5B80
        public void get_Thumbprint(){} // RVA: 0x7FFAC93D5BA0
        public void GetNameInfo(){} // RVA: 0x7FFAC93D5D70
        public void get_Extensions(){} // RVA: 0x7FFAC93D5DB0
        public void get_NotAfter(){} // RVA: 0x7FFAC93D5DD0
        public void get_NotBefore(){} // RVA: 0x7FFAC93D5E70
        public void AppendPrivateKeyInfo(){} // RVA: 0x7FFAC93D5F10
        public void Export(){} // RVA: 0x7FFAC93D5FD0
        public void ExportPkcs12(){} // RVA: 0x7FFAC93D6230 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class X509CertificateCollection : CollectionBase
    {
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93D66B0 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFAC93D66E0
        public void Add(){} // RVA: 0x7FFAC93D6780
        public void AddRange(){} // RVA: 0x7FFAC93D6810
        public void GetEnumerator(){} // RVA: 0x7FFAC93D68F0
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
    }

    public class X509CertificateImpl : Object
    {
        public object IsValid;
        public object Issuer;
        public object Subject;
        public object RawData;
        public object NotAfter;
        public object NotBefore;
        public object Thumbprint;
        public object KeyAlgorithm;
        public object KeyAlgorithmParameters;
        public object PublicKeyValue;
        public object SerialNumber;
        public object HasPrivateKey;

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFAC2C59D00
        public void ThrowIfContextInvalid(){} // RVA: 0x7FFAC8449BC0
        public void Clone(){} // RVA: 0x7FFAC2C58E90
        public void get_Issuer(){} // RVA: 0x7FFAC2C58E90
        public void get_Subject(){} // RVA: 0x7FFAC2C58E90
        public void get_RawData(){} // RVA: 0x7FFAC2C58E90
        public void get_NotAfter(){} // RVA: 0x7FFAC2C58E90
        public void get_NotBefore(){} // RVA: 0x7FFAC2C58E90
        public void get_Thumbprint(){} // RVA: 0x7FFAC2C58E90
        public void GetHashCode(){} // RVA: 0x7FFAC8449C10
        public void get_KeyAlgorithm(){} // RVA: 0x7FFAC2C58E90
        public void get_KeyAlgorithmParameters(){} // RVA: 0x7FFAC2C58E90
        public void get_PublicKeyValue(){} // RVA: 0x7FFAC2C58E90
        public void get_SerialNumber(){} // RVA: 0x7FFAC2C58E90
        public void get_HasPrivateKey(){} // RVA: 0x7FFAC2C59D00
        public void GetRSAPrivateKey(){} // RVA: 0x7FFAC2C58E90
        public void GetDSAPrivateKey(){} // RVA: 0x7FFAC2C58E90
        public void Export(){} // RVA: 0x7FFAC2C68F90
        public void CopyWithPrivateKey(){} // RVA: 0x7FFAC2C58F40
        public void Equals(){} // RVA: 0x7FFAC8449CB0
        public void Dispose(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8449EF0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class X509CertificateImplCollection : Object
    {
        public System.Collections.Generic.List`1<System.Security.Cryptography.X509Certificates.X509CertificateImpl> Count; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93D6D20 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFAC93D6FC0
        public void get_Item(){} // RVA: 0x7FFAC93D7010
        public void Add(){} // RVA: 0x7FFAC93D7090
        public void Clone(){} // RVA: 0x7FFAC93D7120
        public void Dispose(){} // RVA: 0x7FFAC93D71F0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8243E40
    }

    public class X509Chain : Object
    {
        public System.Security.Cryptography.X509Certificates.X509ChainImpl Impl; // 0x10

        // ── Methods ──
        public void get_Impl(){} // RVA: 0x7FFAC93D7390
        public void .ctor(){} // RVA: 0x7FFAC93D76B0 | overloaded x4
        public void get_ChainElements(){} // RVA: 0x7FFAC93D76F0
        public void get_ChainPolicy(){} // RVA: 0x7FFAC93D7770
        public void Build(){} // RVA: 0x7FFAC93D77F0
        public void Reset(){} // RVA: 0x7FFAC93D7880
        public void Create(){} // RVA: 0x7FFAC93D7900
        public void Dispose(){} // RVA: 0x7FFAC93D79C0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8243E40
    }

    public class X509ChainElement : Object
    {
        public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate; // 0x10
        public System.Security.Cryptography.X509Certificates.X509ChainStatus[] ChainElementStatus; // 0x18
        public string StatusFlags; // 0x20
        public 0x6B1318B0 compressed_status_flags; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93D7AA0
        public void get_Certificate(){} // RVA: 0x7FFAC2F3C380
        public void get_ChainElementStatus(){} // RVA: 0x7FFAC2F247C0
        public void get_StatusFlags(){} // RVA: 0x7FFAC32EC4C0
        public void set_StatusFlags(){} // RVA: 0x7FFAC369A6E0
        public void Count(){} // RVA: 0x7FFAC93D7BA0
        public void Set(){} // RVA: 0x7FFAC93D7BD0
        public void UncompressFlags(){} // RVA: 0x7FFAC93D7C90
    }

    public class X509ChainElementCollection : Object
    {
        public System.Collections.ArrayList Count; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93D8960
        public void get_Count(){} // RVA: 0x7FFAC8593680
        public void get_IsSynchronized(){} // RVA: 0x7FFAC8593900
        public void get_Item(){} // RVA: 0x7FFAC93D8A00
        public void get_SyncRoot(){} // RVA: 0x7FFAC8593930
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC8593960
        public void GetEnumerator(){} // RVA: 0x7FFAC93D8AA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC93D8B00
        public void Add(){} // RVA: 0x7FFAC93D8B60
        public void Clear(){} // RVA: 0x7FFAC32F0BD0
        public void Contains(){} // RVA: 0x7FFAC93D8CC0
    }

    public class X509ChainElementEnumerator : Object
    {
        public System.Collections.IEnumerator Current; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93D8E00
        public void get_Current(){} // RVA: 0x7FFAC93D8EB0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC93D8F50
        public void MoveNext(){} // RVA: 0x7FFAC93D8FA0
        public void Reset(){} // RVA: 0x7FFAC93D8FF0
    }

    public class X509ChainImpl : Object
    {
        public object IsValid;
        public object ChainElements;
        public object ChainPolicy;

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFAC2C59D00
        public void ThrowIfContextInvalid(){} // RVA: 0x7FFAC93D9040
        public void get_ChainElements(){} // RVA: 0x7FFAC2C58E90
        public void get_ChainPolicy(){} // RVA: 0x7FFAC2C58E90
        public void Build(){} // RVA: 0x7FFAC2C59F60
        public void AddStatus(){} // RVA: 0x7FFAC2C70ED0
        public void Reset(){} // RVA: 0x7FFAC2C70980
        public void Dispose(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC83AB320
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class X509ChainImplMono : X509ChainImpl
    {
        public 0x6B1317A8 IsValid; // 0x10
        public System.Security.Cryptography.X509Certificates.X509ChainElementCollection ChainElements; // 0x18
        public System.Security.Cryptography.X509Certificates.X509ChainPolicy ChainPolicy; // 0x20
        public System.Security.Cryptography.X509Certificates.X509ChainStatus[] Roots; // 0x28
        public System.Security.Cryptography.X509Certificates.X509ChainStatus[] CertificateAuthorities;
        public int LMRootStore; // 0x30
        public System.Security.Cryptography.X509Certificates.X500DistinguishedName UserRootStore; // 0x38
        public System.Security.Cryptography.AsymmetricAlgorithm LMCAStore; // 0x40
        public System.Security.Cryptography.X509Certificates.X509ChainElement UserCAStore; // 0x48
        public System.Security.Cryptography.X509Certificates.X509Certificate2Collection CertificateCollection; // 0x50
        public System.Security.Cryptography.X509Certificates.X509Certificate2Collection cas; // 0x58
        public System.Security.Cryptography.X509Certificates.X509Store root_store; // 0x60
        public System.Security.Cryptography.X509Certificates.X509Store ca_store; // 0x68
        public System.Security.Cryptography.X509Certificates.X509Store user_root_store; // 0x70
        public System.Security.Cryptography.X509Certificates.X509Store user_ca_store; // 0x78
        public System.Security.Cryptography.X509Certificates.X509Certificate2Collection collection; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93D9100
        public void get_IsValid(){} // RVA: 0x7FFAC3006850
        public void get_ChainElements(){} // RVA: 0x7FFAC2F247C0
        public void get_ChainPolicy(){} // RVA: 0x7FFAC2F4F0C0
        public void AddStatus(){} // RVA: 0x7FFAC2F21310
        public void Build(){} // RVA: 0x7FFAC93D9250
        public void Reset(){} // RVA: 0x7FFAC93D9A20
        public void get_Roots(){} // RVA: 0x7FFAC93D9E20
        public void get_CertificateAuthorities(){} // RVA: 0x7FFAC93DA020
        public void get_LMRootStore(){} // RVA: 0x7FFAC93DA220
        public void get_UserRootStore(){} // RVA: 0x7FFAC93DA310
        public void get_LMCAStore(){} // RVA: 0x7FFAC93DA400
        public void get_UserCAStore(){} // RVA: 0x7FFAC93DA4F0
        public void get_CertificateCollection(){} // RVA: 0x7FFAC93DA5E0
        public void BuildChainFrom(){} // RVA: 0x7FFAC93DA860
        public void SelectBestFromCollection(){} // RVA: 0x7FFAC93DAAA0
        public void FindParent(){} // RVA: 0x7FFAC93DACD0
        public void IsChainComplete(){} // RVA: 0x7FFAC93DAE80
        public void IsSelfIssued(){} // RVA: 0x7FFAC93DAFC0
        public void ValidateChain(){} // RVA: 0x7FFAC93DB050
        public void Process(){} // RVA: 0x7FFAC93DB300
        public void PrepareForNextCertificate(){} // RVA: 0x7FFAC93DB680
        public void WrapUp(){} // RVA: 0x7FFAC93DBA20
        public void ProcessCertificateExtensions(){} // RVA: 0x7FFAC93DBAF0
        public void IsSignedWith(){} // RVA: 0x7FFAC93DBC80
        public void GetSubjectKeyIdentifier(){} // RVA: 0x7FFAC93DBCD0
        public void GetAuthorityKeyIdentifier(){} // RVA: 0x7FFAC93DBEC0 | overloaded x3
        public void CheckRevocationOnChain(){} // RVA: 0x7FFAC93DC160
        public void CheckRevocation(){} // RVA: 0x7FFAC93DC510 | overloaded x2
        public void CheckCrls(){} // RVA: 0x7FFAC93DC790
        public void FindCrl(){} // RVA: 0x7FFAC93DCB50
        public void ProcessCrlExtensions(){} // RVA: 0x7FFAC93DCD00
        public void ProcessCrlEntryExtensions(){} // RVA: 0x7FFAC93DCF90
        public void .cctor(){} // RVA: 0x7FFAC93DD1D0
    }

    public class X509ChainPolicy : Object
    {
        public System.Security.Cryptography.OidCollection ExtraStore; // 0x10
        public System.Security.Cryptography.OidCollection RevocationFlag; // 0x18
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection RevocationMode; // 0x20
        public System.Security.Cryptography.X509Certificates.X509Certificate2Collection VerificationFlags; // 0x28
        public 0x6B131A10 VerificationTime; // 0x30
        public 0x6B131A68 mode; // 0x34
        public System.TimeSpan timeout; // 0x38
        public 0x6B131B18 vflags; // 0x40
        public System.DateTime vtime; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93DD280
        public void get_ExtraStore(){} // RVA: 0x7FFAC93DD290
        public void set_ExtraStore(){} // RVA: 0x7FFAC2F22E90
        public void get_RevocationFlag(){} // RVA: 0x7FFAC2F7CCD0
        public void get_RevocationMode(){} // RVA: 0x7FFAC3ADEDC0
        public void set_RevocationMode(){} // RVA: 0x7FFAC93DD550
        public void get_VerificationFlags(){} // RVA: 0x7FFAC2FC2080
        public void set_VerificationFlags(){} // RVA: 0x7FFAC93DD5C0
        public void get_VerificationTime(){} // RVA: 0x7FFAC2F9C730
        public void Reset(){} // RVA: 0x7FFAC93DD630
    }

    public class X509ChainStatus : ValueType
    {
        public 0x6B1318B0 Status; // 0x10
        public string StatusInformation; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93DD830
        public void get_Status(){} // RVA: 0x7FFAC4420210
        public void set_Status(){} // RVA: 0x7FFAC336D8B0
        public void set_StatusInformation(){} // RVA: 0x7FFAC4420240
        public void GetInformation(){} // RVA: 0x7FFAC93DD8A0
    }

    public class X509EnhancedKeyUsageExtension : X509Extension
    {
        public System.Security.Cryptography.OidCollection EnhancedKeyUsages; // 0x28
        public 0x6B1316A0 _status; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93DDC70 | overloaded x3
        public void get_EnhancedKeyUsages(){} // RVA: 0x7FFAC93DDEF0
        public void CopyFrom(){} // RVA: 0x7FFAC93DE060
        public void Decode(){} // RVA: 0x7FFAC93DE260
        public void Encode(){} // RVA: 0x7FFAC93DE460
        public void ToString(){} // RVA: 0x7FFAC93DE6A0
    }

    public class X509Extension : AsnEncodedData
    {
        public bool Critical; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93DEA70 | overloaded x2
        public void get_Critical(){} // RVA: 0x7FFAC300F9D0
        public void set_Critical(){} // RVA: 0x7FFAC300F9E0
        public void CopyFrom(){} // RVA: 0x7FFAC93DEB50
        public void FormatUnkownData(){} // RVA: 0x7FFAC93DECF0
    }

    public class X509ExtensionCollection : Object
    {
        public byte[] Count;
        public System.Collections.ArrayList IsSynchronized; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93DEED0
        public void get_Count(){} // RVA: 0x7FFAC8593680
        public void get_IsSynchronized(){} // RVA: 0x7FFAC8593900
        public void get_SyncRoot(){} // RVA: 0x7FFAC44F81E0
        public void get_Item(){} // RVA: 0x7FFAC93DEF70
        public void Add(){} // RVA: 0x7FFAC93DF220
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC93DF2B0
        public void GetEnumerator(){} // RVA: 0x7FFAC93DF400
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC93DF4D0
        public void .cctor(){} // RVA: 0x7FFAC93DF5A0
    }

    public class X509ExtensionEnumerator : Object
    {
        public System.Collections.IEnumerator Current; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93DF650
        public void get_Current(){} // RVA: 0x7FFAC93DF6D0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC93DF770
        public void MoveNext(){} // RVA: 0x7FFAC93DF7C0
        public void Reset(){} // RVA: 0x7FFAC93DF810
    }

    public class X509Helper : Object
    {
        public object CertificateProvider;

        // ── Methods ──
        public void get_CertificateProvider(){} // RVA: 0x7FFAC8449F40
        public void InitFromCertificate(){} // RVA: 0x7FFAC844A090 | overloaded x2
        public void IsValid(){} // RVA: 0x7FFAC844A0B0
        public void ThrowIfContextInvalid(){} // RVA: 0x7FFAC844A0D0
        public void GetInvalidContextException(){} // RVA: 0x7FFAC844A120
        public void Import(){} // RVA: 0x7FFAC844A260 | overloaded x2
    }

    public class X509Helper2 : Object
    {
        // ── Methods ──
        public void GetMonoCertificate(){} // RVA: 0x7FFAC93DF860
        public void CreateChainImpl(){} // RVA: 0x7FFAC93DF950
        public void IsValid(){} // RVA: 0x7FFAC844A0B0
        public void ThrowIfContextInvalid(){} // RVA: 0x7FFAC93DFAE0
        public void GetInvalidChainContextException(){} // RVA: 0x7FFAC93DFB30
    }

    public class X509KeyUsageExtension : X509Extension
    {
        public string KeyUsages;
        public string friendlyName;
        public 0x6B131960 all;
        public 0x6B131960 _keyUsages; // 0x28
        public 0x6B1316A0 _status; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93DFE00 | overloaded x3
        public void get_KeyUsages(){} // RVA: 0x7FFAC93DFF20
        public void CopyFrom(){} // RVA: 0x7FFAC93DFF90
        public void GetValidFlags(){} // RVA: 0x7FFAC93E0190
        public void Decode(){} // RVA: 0x7FFAC93E01A0
        public void Encode(){} // RVA: 0x7FFAC93E0300
        public void ToString(){} // RVA: 0x7FFAC93E05B0
    }

    public class X509Store : Object
    {
        public string Certificates; // 0x10
        public 0x6B1317A8 Factory; // 0x18
        public System.Security.Cryptography.X509Certificates.X509Certificate2Collection Store; // 0x20
        public 0x6B131750 _flags; // 0x28
        public Mono.Security.X509.X509Store store; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93E0C60
        public void get_Certificates(){} // RVA: 0x7FFAC93E0DB0
        public void get_Factory(){} // RVA: 0x7FFAC93E0E80
        public void get_Store(){} // RVA: 0x7FFAC31D95E0
        public void Close(){} // RVA: 0x7FFAC93E0EA0
        public void Dispose(){} // RVA: 0x7FFAC93E0F70
        public void Open(){} // RVA: 0x7FFAC93E0F80
    }

    public class X509SubjectKeyIdentifierExtension : X509Extension
    {
        public string SubjectKeyIdentifier;
        public string friendlyName;
        public byte[] _subjectKeyIdentifier; // 0x28
        public string _ski; // 0x30
        public 0x6B1316A0 _status; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93E1C40 | overloaded x6
        public void get_SubjectKeyIdentifier(){} // RVA: 0x7FFAC93E21D0
        public void CopyFrom(){} // RVA: 0x7FFAC93E22A0
        public void FromHexChar(){} // RVA: 0x7FFAC93E24A0
        public void FromHexChars(){} // RVA: 0x7FFAC93E24D0
        public void FromHex(){} // RVA: 0x7FFAC93E2550
        public void Decode(){} // RVA: 0x7FFAC93E26C0
        public void Encode(){} // RVA: 0x7FFAC93E2850
        public void ToString(){} // RVA: 0x7FFAC93E2900
    }

}