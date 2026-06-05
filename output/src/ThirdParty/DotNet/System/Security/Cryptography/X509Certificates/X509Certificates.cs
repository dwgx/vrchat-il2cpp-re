// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography.X509Certificates
// Classes: 31
// Methods: 382

namespace ThirdParty.DotNet.System.Security.Cryptography.X509Certificates
{
    public class PublicKey
    {
        public object Name;
        public object `;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96E4250
        public void get_EncodedKeyValue(){} // RVA: 0x7FFAF2D907C0
        public void get_EncodedParameters(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Key(){} // RVA: 0x7FFAF96E4440
        public void get_Oid(){} // RVA: 0x7FFAF2DBB130
        public void GetUnsignedBigInteger(){} // RVA: 0x7FFAF96E4670
        public void DecodeDSA(){} // RVA: 0x7FFAF96E4720
        public void DecodeRSA(){} // RVA: 0x7FFAF96E4CD0
        public void .cctor(){} // RVA: 0x7FFAF96E50E0
    }

    public class RSACertificateExtensions
    {
        // ── Methods ──
        public void GetRSAPublicKey(){} // RVA: 0x7FFAF90570A0
    }

    public class X500DistinguishedName
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96E52E0 | overloaded x3
        public void get_Name(){} // RVA: 0x7FFAF2DBB0C0
        public void Decode(){} // RVA: 0x7FFAF96E5630
        public void Format(){} // RVA: 0x7FFAF96E5800
        public void GetSeparator(){} // RVA: 0x7FFAF96E5870
        public void DecodeRawData(){} // RVA: 0x7FFAF96E58E0
        public void Canonize(){} // RVA: 0x7FFAF96E5A90
        public void AreEqual(){} // RVA: 0x7FFAF96E5CC0
    }

    public class X509BasicConstraintsExtension
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96E6140 | overloaded x3
        public void get_CertificateAuthority(){} // RVA: 0x7FFAF96E62B0
        public void get_HasPathLengthConstraint(){} // RVA: 0x7FFAF96E6320
        public void get_PathLengthConstraint(){} // RVA: 0x7FFAF96E6390
        public void CopyFrom(){} // RVA: 0x7FFAF96E6400
        public void Decode(){} // RVA: 0x7FFAF96E6600
        public void Encode(){} // RVA: 0x7FFAF96E6770
        public void ToString(){} // RVA: 0x7FFAF96E69C0
    }

    public class X509Certificate
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF875FBC0
        public void .ctor(){} // RVA: 0x7FFAF8760840 | overloaded x9
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF8760890
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFAF87608D0
        public void get_Issuer(){} // RVA: 0x7FFAF8760910
        public void get_Subject(){} // RVA: 0x7FFAF8760A00
        public void Dispose(){} // RVA: 0x7FFAF8760B10 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAF8760BE0 | overloaded x2
        public void Export(){} // RVA: 0x7FFAF8760D10
        public void GetCertHash(){} // RVA: 0x7FFAF8760EE0
        public void GetCertHashString(){} // RVA: 0x7FFAF8760FB0
        public void GetRawCertHash(){} // RVA: 0x7FFAF8761030
        public void GetPublicKeyString(){} // RVA: 0x7FFAF87610C0
        public void GetRawCertData(){} // RVA: 0x7FFAF8761100
        public void GetHashCode(){} // RVA: 0x7FFAF87611F0
        public void GetKeyAlgorithm(){} // RVA: 0x7FFAF87612F0
        public void GetKeyAlgorithmParameters(){} // RVA: 0x7FFAF87613E0
        public void GetPublicKey(){} // RVA: 0x7FFAF8761530
        public void GetSerialNumber(){} // RVA: 0x7FFAF8761680
        public void GetSerialNumberString(){} // RVA: 0x7FFAF87617F0
        public void GetRawSerialNumber(){} // RVA: 0x7FFAF8761870
        public void ToString(){} // RVA: 0x7FFAF8761920 | overloaded x2
        public void GetNotAfter(){} // RVA: 0x7FFAF8761E50
        public void GetNotBefore(){} // RVA: 0x7FFAF8761F80
        public void FormatDate(){} // RVA: 0x7FFAF87620B0
        public void ValidateKeyStorageFlags(){} // RVA: 0x7FFAF8762340
        public void VerifyContentType(){} // RVA: 0x7FFAF8762460
        public void ImportHandle(){} // RVA: 0x7FFAF87624D0
        public void get_Impl(){} // RVA: 0x7FFAF2DA8380
        public void get_IsValid(){} // RVA: 0x7FFAF8762550
        public void ThrowIfInvalid(){} // RVA: 0x7FFAF8762570
    }

    public class X509Certificate2
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF96E6C80
        public void .ctor(){} // RVA: 0x7FFAF96E7100 | overloaded x7
        public void get_Extensions(){} // RVA: 0x7FFAF96E7120
        public void get_HasPrivateKey(){} // RVA: 0x7FFAF96E7550
        public void get_PrivateKey(){} // RVA: 0x7FFAF96E75D0
        public void get_IssuerName(){} // RVA: 0x7FFAF96E7800
        public void get_NotAfter(){} // RVA: 0x7FFAF96E7910
        public void get_NotBefore(){} // RVA: 0x7FFAF96E7920
        public void get_PublicKey(){} // RVA: 0x7FFAF96E7930
        public void get_RawData(){} // RVA: 0x7FFAF96E7B60
        public void get_SerialNumber(){} // RVA: 0x7FFAF631F560
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAF96E7CC0
        public void get_SubjectName(){} // RVA: 0x7FFAF96E7DD0
        public void get_Thumbprint(){} // RVA: 0x7FFAF96E7ED0
        public void get_Version(){} // RVA: 0x7FFAF96E7F10
        public void GetCertContentType(){} // RVA: 0x7FFAF96E7FB0
        public void GetNameInfo(){} // RVA: 0x7FFAF96E8050
        public void ToString(){} // RVA: 0x7FFAF96E80B0 | overloaded x2
        public void Verify(){} // RVA: 0x7FFAF96E9140
        public void CreateCustomExtensionIfAny(){} // RVA: 0x7FFAF96E9180
        public void get_Impl(){} // RVA: 0x7FFAF96E9680
    }

    public class X509Certificate2Collection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96E9740 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFAF96E97E0
        public void Add(){} // RVA: 0x7FFAF96E9950
        public void AddRange(){} // RVA: 0x7FFAF96E99E0
        public void Contains(){} // RVA: 0x7FFAF96E9A70
        public void GetKeyIdentifier(){} // RVA: 0x7FFAF96E9CB0
        public void Find(){} // RVA: 0x7FFAF96E9D90
        public void GetEnumerator(){} // RVA: 0x7FFAF96EB1C0
        public void .cctor(){} // RVA: 0x7FFAF96EB2A0
    }

    public class X509Certificate2Enumerator : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96EB370
        public void get_Current(){} // RVA: 0x7FFAF96EB420
        public void MoveNext(){} // RVA: 0x7FFAF96EB4C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAF96EB510
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7FFAF96EB560
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAF96EB5B0
    }

    public class X509Certificate2Impl
    {
        // ── Methods ──
        public void get_Extensions(){} // RVA: 0x7FFAF2ABCD60
        public void get_IssuerName(){} // RVA: 0x7FFAF2ABCD60
        public void get_PrivateKey(){} // RVA: 0x7FFAF2ABCD60
        public void set_PrivateKey(){} // RVA: 0x7FFAF2AD4B10
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAF2ABCD60
        public void get_SubjectName(){} // RVA: 0x7FFAF2ABCD60
        public void get_Version(){} // RVA: 0x7FFAF2ABD840
        public void get_IntermediateCertificates(){} // RVA: 0x7FFAF2ABCD60
        public void GetNameInfo(){}
        public void Verify(){} // RVA: 0x7FFAF2ABDE40
        public void AppendPrivateKeyInfo(){} // RVA: 0x7FFAF2AD4B10
        public void CopyWithPrivateKey(){} // RVA: 0x7FFAF96EB600
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class X509Certificate2ImplMono
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFAF9449EB0
        public void .ctor(){} // RVA: 0x7FFAF96EB810 | overloaded x3
        public void Clone(){} // RVA: 0x7FFAF96EBA90
        public void get_Cert(){} // RVA: 0x7FFAF9694E30
        public void GetRawCertData(){} // RVA: 0x7FFAF96EBC50
        public void get_HasPrivateKey(){} // RVA: 0x7FFAF96EBD00
        public void get_PrivateKey(){} // RVA: 0x7FFAF96EBD30
        public void set_PrivateKey(){} // RVA: 0x7FFAF96EC1A0
        public void GetRSAPrivateKey(){} // RVA: 0x7FFAF96EC460
        public void GetDSAPrivateKey(){} // RVA: 0x7FFAF96EC500
        public void ImportPkcs12(){} // RVA: 0x7FFAF96EC640 | overloaded x2
        public void Verify(){} // RVA: 0x7FFAF96ECEA0
        public void get_IntermediateCertificates(){} // RVA: 0x7FFAF2DF8040
        public void get_MonoCertificate(){} // RVA: 0x7FFAF2DF80B0
        public void .cctor(){} // RVA: 0x7FFAF96ECF90
    }

    public class X509Certificate2ImplUnix
    {
        // ── Methods ──
        public void EnsureCertData(){} // RVA: 0x7FFAF96ED110
        public void GetRawCertData(){} // RVA: 0x7FFAF2ABCD60
        public void get_KeyAlgorithm(){} // RVA: 0x7FFAF96ED2A0
        public void get_KeyAlgorithmParameters(){} // RVA: 0x7FFAF96ED2C0
        public void get_PublicKeyValue(){} // RVA: 0x7FFAF96ED2E0
        public void get_SerialNumber(){} // RVA: 0x7FFAF96ED300
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAF96ED320
        public void get_Version(){} // RVA: 0x7FFAF96ED340
        public void get_SubjectName(){} // RVA: 0x7FFAF96ED360
        public void get_IssuerName(){} // RVA: 0x7FFAF96ED380
        public void get_Subject(){} // RVA: 0x7FFAF96ED3A0
        public void get_Issuer(){} // RVA: 0x7FFAF96ED3D0
        public void get_RawData(){} // RVA: 0x7FFAF96ED400
        public void get_Thumbprint(){} // RVA: 0x7FFAF96ED420
        public void GetNameInfo(){} // RVA: 0x7FFAF96ED5F0
        public void get_Extensions(){} // RVA: 0x7FFAF96ED630
        public void get_NotAfter(){} // RVA: 0x7FFAF96ED650
        public void get_NotBefore(){} // RVA: 0x7FFAF96ED6F0
        public void AppendPrivateKeyInfo(){} // RVA: 0x7FFAF96ED790
        public void Export(){} // RVA: 0x7FFAF96ED850
        public void ExportPkcs12(){} // RVA: 0x7FFAF96EDAB0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class X509CertificateCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96EDF30 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFAF96EDF60
        public void Add(){} // RVA: 0x7FFAF96EE000
        public void AddRange(){} // RVA: 0x7FFAF96EE090
        public void GetEnumerator(){} // RVA: 0x7FFAF96EE170
        public void GetHashCode(){} // RVA: 0x7FFAF344E0E0
    }

    public class X509CertificateImpl
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFAF2ABDBE0
        public void ThrowIfContextInvalid(){} // RVA: 0x7FFAF87625D0
        public void Clone(){} // RVA: 0x7FFAF2ABCD60
        public void get_Issuer(){} // RVA: 0x7FFAF2ABCD60
        public void get_Subject(){} // RVA: 0x7FFAF2ABCD60
        public void get_RawData(){} // RVA: 0x7FFAF2ABCD60
        public void get_NotAfter(){} // RVA: 0x7FFAF2ABCD60
        public void get_NotBefore(){} // RVA: 0x7FFAF2ABCD60
        public void get_Thumbprint(){} // RVA: 0x7FFAF2ABCD60
        public void GetHashCode(){} // RVA: 0x7FFAF8762620
        public void get_KeyAlgorithm(){} // RVA: 0x7FFAF2ABCD60
        public void get_KeyAlgorithmParameters(){} // RVA: 0x7FFAF2ABCD60
        public void get_PublicKeyValue(){} // RVA: 0x7FFAF2ABCD60
        public void get_SerialNumber(){} // RVA: 0x7FFAF2ABCD60
        public void get_HasPrivateKey(){} // RVA: 0x7FFAF2ABDBE0
        public void GetRSAPrivateKey(){} // RVA: 0x7FFAF2ABCD60
        public void GetDSAPrivateKey(){} // RVA: 0x7FFAF2ABCD60
        public void Export(){} // RVA: 0x7FFAF2ACCEE0
        public void CopyWithPrivateKey(){} // RVA: 0x7FFAF2ABCE10
        public void Equals(){} // RVA: 0x7FFAF87626C0
        public void Dispose(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF8762900
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class X509CertificateImplCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96EE5A0 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFAF96EE840
        public void get_Item(){} // RVA: 0x7FFAF96EE890
        public void Add(){} // RVA: 0x7FFAF96EE910
        public void Clone(){} // RVA: 0x7FFAF96EE9A0
        public void Dispose(){} // RVA: 0x7FFAF96EEA70 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF855C950
    }

    public class X509Chain
    {
        // ── Methods ──
        public void get_Impl(){} // RVA: 0x7FFAF96EEC10
        public void .ctor(){} // RVA: 0x7FFAF96EEF30 | overloaded x4
        public void get_ChainElements(){} // RVA: 0x7FFAF96EEF70
        public void get_ChainPolicy(){} // RVA: 0x7FFAF96EEFF0
        public void Build(){} // RVA: 0x7FFAF96EF070
        public void Reset(){} // RVA: 0x7FFAF96EF100
        public void Create(){} // RVA: 0x7FFAF96EF180
        public void Dispose(){} // RVA: 0x7FFAF96EF240 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF855C950
    }

    public class X509ChainElement
    {
        public object Count;
        public object IsSynchronized;
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96EF320
        public void get_Certificate(){} // RVA: 0x7FFAF2DA8380
        public void get_ChainElementStatus(){} // RVA: 0x7FFAF2D907C0
        public void get_StatusFlags(){} // RVA: 0x7FFAF3241DC0
        public void set_StatusFlags(){} // RVA: 0x7FFAF3503440
        public void Count(){} // RVA: 0x7FFAF96EF420
        public void Set(){} // RVA: 0x7FFAF96EF450
        public void UncompressFlags(){} // RVA: 0x7FFAF96EF510
    }

    public class X509ChainElementCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96F01E0
        public void get_Count(){} // RVA: 0x7FFAF88AC050
        public void get_IsSynchronized(){} // RVA: 0x7FFAF3247560
        public void get_Item(){} // RVA: 0x7FFAF96F0280
        public void get_SyncRoot(){} // RVA: 0x7FFAF88AC2D0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF88AC300
        public void GetEnumerator(){} // RVA: 0x7FFAF96F0320
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF96F0380
        public void Add(){} // RVA: 0x7FFAF96F03E0
        public void Clear(){} // RVA: 0x7FFAF9224200
        public void Contains(){} // RVA: 0x7FFAF96F0540
    }

    public class X509ChainElementEnumerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96F0680
        public void get_Current(){} // RVA: 0x7FFAF96F0730
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAF96F07D0
        public void MoveNext(){} // RVA: 0x7FFAF96F0820
        public void Reset(){} // RVA: 0x7FFAF96F0870
    }

    public class X509ChainImpl
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7FFAF2ABDBE0
        public void ThrowIfContextInvalid(){} // RVA: 0x7FFAF96F08C0
        public void get_ChainElements(){} // RVA: 0x7FFAF2ABCD60
        public void get_ChainPolicy(){} // RVA: 0x7FFAF2ABCD60
        public void Build(){} // RVA: 0x7FFAF2ABDE40
        public void AddStatus(){} // RVA: 0x7FFAF2AD4FA0
        public void Reset(){} // RVA: 0x7FFAF2AD4A50
        public void Dispose(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF86C3DD0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class X509ChainImplMono
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96F0980
        public void get_IsValid(){} // RVA: 0x7FFAF2E72850
        public void get_ChainElements(){} // RVA: 0x7FFAF2D907C0
        public void get_ChainPolicy(){} // RVA: 0x7FFAF2DBB0C0
        public void AddStatus(){} // RVA: 0x7FFAF2D8D310
        public void Build(){} // RVA: 0x7FFAF96F0AD0
        public void Reset(){} // RVA: 0x7FFAF96F12A0
        public void get_Roots(){} // RVA: 0x7FFAF96F16A0
        public void get_CertificateAuthorities(){} // RVA: 0x7FFAF96F18A0
        public void get_LMRootStore(){} // RVA: 0x7FFAF96F1AA0
        public void get_UserRootStore(){} // RVA: 0x7FFAF96F1B90
        public void get_LMCAStore(){} // RVA: 0x7FFAF96F1C80
        public void get_UserCAStore(){} // RVA: 0x7FFAF96F1D70
        public void get_CertificateCollection(){} // RVA: 0x7FFAF96F1E60
        public void BuildChainFrom(){} // RVA: 0x7FFAF96F20E0
        public void SelectBestFromCollection(){} // RVA: 0x7FFAF96F2320
        public void FindParent(){} // RVA: 0x7FFAF96F2550
        public void IsChainComplete(){} // RVA: 0x7FFAF96F2700
        public void IsSelfIssued(){} // RVA: 0x7FFAF96F2840
        public void ValidateChain(){} // RVA: 0x7FFAF96F28D0
        public void Process(){} // RVA: 0x7FFAF96F2B80
        public void PrepareForNextCertificate(){} // RVA: 0x7FFAF96F2F00
        public void WrapUp(){} // RVA: 0x7FFAF96F32A0
        public void ProcessCertificateExtensions(){} // RVA: 0x7FFAF96F3370
        public void IsSignedWith(){} // RVA: 0x7FFAF96F3500
        public void GetSubjectKeyIdentifier(){} // RVA: 0x7FFAF96F3550
        public void GetAuthorityKeyIdentifier(){} // RVA: 0x7FFAF96F3740 | overloaded x3
        public void CheckRevocationOnChain(){} // RVA: 0x7FFAF96F39E0
        public void CheckRevocation(){} // RVA: 0x7FFAF96F3D90 | overloaded x2
        public void CheckCrls(){} // RVA: 0x7FFAF96F4010
        public void FindCrl(){} // RVA: 0x7FFAF96F43D0
        public void ProcessCrlExtensions(){} // RVA: 0x7FFAF96F4580
        public void ProcessCrlEntryExtensions(){} // RVA: 0x7FFAF96F4810
        public void .cctor(){} // RVA: 0x7FFAF96F4A50
    }

    public class X509ChainPolicy
    {
        public object Status;
        public object StatusInformation;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96F4B00
        public void get_ExtraStore(){} // RVA: 0x7FFAF96F4B10
        public void set_ExtraStore(){} // RVA: 0x7FFAF2D8EE90
        public void get_RevocationFlag(){} // RVA: 0x7FFAF2DE8CD0
        public void get_RevocationMode(){} // RVA: 0x7FFAF2F76670
        public void set_RevocationMode(){} // RVA: 0x7FFAF96F4DD0
        public void get_VerificationFlags(){} // RVA: 0x7FFAF2E2E080
        public void set_VerificationFlags(){} // RVA: 0x7FFAF96F4E40
        public void get_VerificationTime(){} // RVA: 0x7FFAF2E08730
        public void Reset(){} // RVA: 0x7FFAF96F4EB0
    }

    public class X509ChainStatus
    {
        public object EnhancedKeyUsages;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96F50B0
        public void get_Status(){} // RVA: 0x7FFAF44189B0
        public void set_Status(){} // RVA: 0x7FFAF32E3580
        public void set_StatusInformation(){} // RVA: 0x7FFAF4418950
        public void GetInformation(){} // RVA: 0x7FFAF96F5120
    }

    public class X509EnhancedKeyUsageExtension
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96F54F0 | overloaded x3
        public void get_EnhancedKeyUsages(){} // RVA: 0x7FFAF96F5770
        public void CopyFrom(){} // RVA: 0x7FFAF96F58E0
        public void Decode(){} // RVA: 0x7FFAF96F5AE0
        public void Encode(){} // RVA: 0x7FFAF96F5CE0
        public void ToString(){} // RVA: 0x7FFAF96F5F20
    }

    public class X509Extension
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96F62F0 | overloaded x2
        public void get_Critical(){} // RVA: 0x7FFAF2E7B9D0
        public void set_Critical(){} // RVA: 0x7FFAF2E7B9E0
        public void CopyFrom(){} // RVA: 0x7FFAF96F63D0
        public void FormatUnkownData(){} // RVA: 0x7FFAF96F6570
    }

    public class X509ExtensionCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96F6750
        public void get_Count(){} // RVA: 0x7FFAF88AC050
        public void get_IsSynchronized(){} // RVA: 0x7FFAF3247560
        public void get_SyncRoot(){} // RVA: 0x7FFAF44EF520
        public void get_Item(){} // RVA: 0x7FFAF96F67F0
        public void Add(){} // RVA: 0x7FFAF96F6AA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF96F6B30
        public void GetEnumerator(){} // RVA: 0x7FFAF96F6C80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF96F6D50
        public void .cctor(){} // RVA: 0x7FFAF96F6E20
    }

    public class X509ExtensionEnumerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96F6ED0
        public void get_Current(){} // RVA: 0x7FFAF96F6F50
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAF96F6FF0
        public void MoveNext(){} // RVA: 0x7FFAF96F7040
        public void Reset(){} // RVA: 0x7FFAF96F7090
    }

    public class X509Helper
    {
        // ── Methods ──
        public void get_CertificateProvider(){} // RVA: 0x7FFAF8762950
        public void InitFromCertificate(){} // RVA: 0x7FFAF8762AA0 | overloaded x2
        public void IsValid(){} // RVA: 0x7FFAF8762AC0
        public void ThrowIfContextInvalid(){} // RVA: 0x7FFAF8762AE0
        public void GetInvalidContextException(){} // RVA: 0x7FFAF8762B30
        public void Import(){} // RVA: 0x7FFAF8762C70 | overloaded x2
    }

    public class X509Helper2
    {
        // ── Methods ──
        public void GetMonoCertificate(){} // RVA: 0x7FFAF96F70E0
        public void CreateChainImpl(){} // RVA: 0x7FFAF96F71D0
        public void IsValid(){} // RVA: 0x7FFAF8762AC0
        public void ThrowIfContextInvalid(){} // RVA: 0x7FFAF96F7360
        public void GetInvalidChainContextException(){} // RVA: 0x7FFAF96F73B0
    }

    public class X509KeyUsageExtension
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96F7680 | overloaded x3
        public void get_KeyUsages(){} // RVA: 0x7FFAF96F77A0
        public void CopyFrom(){} // RVA: 0x7FFAF96F7810
        public void GetValidFlags(){} // RVA: 0x7FFAF96F7A10
        public void Decode(){} // RVA: 0x7FFAF96F7A20
        public void Encode(){} // RVA: 0x7FFAF96F7B80
        public void ToString(){} // RVA: 0x7FFAF96F7E30
    }

    public class X509Store
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96F84E0
        public void get_Certificates(){} // RVA: 0x7FFAF96F8630
        public void get_Factory(){} // RVA: 0x7FFAF96F8700
        public void get_Store(){} // RVA: 0x7FFAF30E74D0
        public void Close(){} // RVA: 0x7FFAF96F8720
        public void Dispose(){} // RVA: 0x7FFAF96F87F0
        public void Open(){} // RVA: 0x7FFAF96F8800
    }

    public class X509SubjectKeyIdentifierExtension
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96F94C0 | overloaded x6
        public void get_SubjectKeyIdentifier(){} // RVA: 0x7FFAF96F9A50
        public void CopyFrom(){} // RVA: 0x7FFAF96F9B20
        public void FromHexChar(){} // RVA: 0x7FFAF96F9D20
        public void FromHexChars(){} // RVA: 0x7FFAF96F9D50
        public void FromHex(){} // RVA: 0x7FFAF96F9DD0
        public void Decode(){} // RVA: 0x7FFAF96F9F40
        public void Encode(){} // RVA: 0x7FFAF96FA0D0
        public void ToString(){} // RVA: 0x7FFAF96FA180
    }

}