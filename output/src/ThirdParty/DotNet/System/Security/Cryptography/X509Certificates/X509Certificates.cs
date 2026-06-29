// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography.X509Certificates
// Classes: 33
// Methods: 361

namespace ThirdParty.DotNet.System.Security.Cryptography.X509Certificates
{
    public class PublicKey : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA23190
        public void get_EncodedKeyValue(){} // RVA: 0x7A80DA7B0
        public void get_EncodedParameters(){} // RVA: 0x7A81052C0
        public void get_Key(){} // RVA: 0x7AEA23380
        public void get_Oid(){} // RVA: 0x7A8105330
        public void GetUnsignedBigInteger(){} // RVA: 0x7AEA235B0
        public void DecodeDSA(){} // RVA: 0x7AEA23660
        public void DecodeRSA(){} // RVA: 0x7AEA23C20
        public void .cctor(){} // RVA: 0x7AEA24040
    }

    public class RSACertificateExtensions : Object
    {
        // ── Methods ──
        public void GetRSAPublicKey(){} // RVA: 0x7AE3955C0
    }

    public class X500DistinguishedName : AsnEncodedData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA24240
        public void get_Name(){} // RVA: 0x7A81052C0
        public void Decode(){} // RVA: 0x7AEA24590
        public void Format(){} // RVA: 0x7AEA24760
        public void GetSeparator(){} // RVA: 0x7AEA247D0
        public void DecodeRawData(){} // RVA: 0x7AEA24840
        public void Canonize(){} // RVA: 0x7AEA249F0
        public void AreEqual(){} // RVA: 0x7AEA24C30
    }

    public class X509BasicConstraintsExtension : X509Extension
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA250D0
        public void get_CertificateAuthority(){} // RVA: 0x7AEA25240
        public void get_HasPathLengthConstraint(){} // RVA: 0x7AEA252B0
        public void get_PathLengthConstraint(){} // RVA: 0x7AEA25320
        public void CopyFrom(){} // RVA: 0x7AEA25390
        public void Decode(){} // RVA: 0x7AEA25590
        public void Encode(){} // RVA: 0x7AEA25700
        public void ToString(){} // RVA: 0x7AEA25980
    }

    public class X509Certificate : Object
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7ADA9DC40
        public void .ctor(){} // RVA: 0x7ADA9E8D0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7ADA9E920
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7ADA9E960
        public void get_Issuer(){} // RVA: 0x7ADA9E9A0
        public void get_Subject(){} // RVA: 0x7ADA9EA90
        public void Dispose(){} // RVA: 0x7ADA9EBA0
        public void Equals(){} // RVA: 0x7ADA9EC60
        public void Export(){} // RVA: 0x7ADA9ED90
        public void GetCertHash(){} // RVA: 0x7ADA9EF60
        public void GetCertHashString(){} // RVA: 0x7ADA9F030
        public void GetRawCertHash(){} // RVA: 0x7ADA9F0B0
        public void GetPublicKeyString(){} // RVA: 0x7ADA9F140
        public void GetRawCertData(){} // RVA: 0x7ADA9F180
        public void GetHashCode(){} // RVA: 0x7ADA9F270
        public void GetKeyAlgorithm(){} // RVA: 0x7ADA9F370
        public void GetKeyAlgorithmParameters(){} // RVA: 0x7ADA9F460
        public void GetPublicKey(){} // RVA: 0x7ADA9F5B0
        public void GetSerialNumber(){} // RVA: 0x7ADA9F700
        public void GetSerialNumberString(){} // RVA: 0x7ADA9F870
        public void GetRawSerialNumber(){} // RVA: 0x7ADA9F8F0
        public void ToString(){} // RVA: 0x7ADA9F9A0
        public void GetNotAfter(){} // RVA: 0x7ADA9FED0
        public void GetNotBefore(){} // RVA: 0x7ADAA0000
        public void FormatDate(){} // RVA: 0x7ADAA0130
        public void ValidateKeyStorageFlags(){} // RVA: 0x7ADAA03C0
        public void VerifyContentType(){} // RVA: 0x7ADAA04E0
        public void ImportHandle(){} // RVA: 0x7ADAA0550
        public void get_Impl(){} // RVA: 0x7A80F2570
        public void get_IsValid(){} // RVA: 0x7ADAA05D0
        public void ThrowIfInvalid(){} // RVA: 0x7ADAA05F0
    }

    public class X509Certificate2 : X509Certificate
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7AEA25C40
        public void .ctor(){} // RVA: 0x7AEA260C0
        public void get_Extensions(){} // RVA: 0x7AEA260E0
        public void get_HasPrivateKey(){} // RVA: 0x7AEA26520
        public void get_PrivateKey(){} // RVA: 0x7AEA265A0
        public void get_IssuerName(){} // RVA: 0x7AEA267D0
        public void get_NotAfter(){} // RVA: 0x7AEA268E0
        public void get_NotBefore(){} // RVA: 0x7AEA268F0
        public void get_PublicKey(){} // RVA: 0x7AEA26900
        public void get_RawData(){} // RVA: 0x7AEA26B30
        public void get_SerialNumber(){} // RVA: 0x7AB65E3A0
        public void get_SignatureAlgorithm(){} // RVA: 0x7AEA26C90
        public void get_SubjectName(){} // RVA: 0x7AEA26DA0
        public void get_Thumbprint(){} // RVA: 0x7AEA26EA0
        public void get_Version(){} // RVA: 0x7AEA26EE0
        public void GetCertContentType(){} // RVA: 0x7AEA26F80
        public void GetNameInfo(){} // RVA: 0x7AEA27020
        public void ToString(){} // RVA: 0x7AEA27080
        public void Verify(){} // RVA: 0x7AEA28110
        public void CreateCustomExtensionIfAny(){} // RVA: 0x7AEA28150
        public void get_Impl(){} // RVA: 0x7AEA28650
    }

    public class X509Certificate2Collection : X509CertificateCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA28700
        public void get_Item(){} // RVA: 0x7AEA287A0
        public void Add(){} // RVA: 0x7AEA28910
        public void AddRange(){} // RVA: 0x7AEA289A0
        public void Contains(){} // RVA: 0x7AEA28A30
        public void GetKeyIdentifier(){} // RVA: 0x7AEA28C60
        public void Find(){} // RVA: 0x7AEA28D40
        public void GetEnumerator(){} // RVA: 0x7AEA2A400
        public void .cctor(){} // RVA: 0x7AEA2A4E0
    }

    public class X509Certificate2Enumerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA2A5B0
        public void get_Current(){} // RVA: 0x7AEA2A660
        public void MoveNext(){} // RVA: 0x7AEA2A700
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7AEA2A750
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7AEA2A7A0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7AEA2A7F0
    }

    public class X509Certificate2Impl : X509CertificateImpl
    {
        // ── Methods ──
        public void get_Extensions(){} // RVA: 0x7A7E00680
        public void get_IssuerName(){} // RVA: 0x7A7E00680
        public void get_PrivateKey(){} // RVA: 0x7A7E00680
        public void set_PrivateKey(){} // RVA: 0x7A7E18800
        public void get_SignatureAlgorithm(){} // RVA: 0x7A7E00680
        public void get_SubjectName(){} // RVA: 0x7A7E00680
        public void get_Version(){} // RVA: 0x7A7E00710
        public void get_IntermediateCertificates(){} // RVA: 0x7A7E00680
        public void GetNameInfo(){} // RVA: 0x7A7E10AC0
        public void Verify(){} // RVA: 0x7A7E019D0
        public void AppendPrivateKeyInfo(){} // RVA: 0x7A7E18800
        public void CopyWithPrivateKey(){} // RVA: 0x7AEA2A840
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class X509Certificate2ImplMono : X509Certificate2ImplUnix
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7AE7888D0
        public void .ctor(){} // RVA: 0x7AEA2AA60
        public void Clone(){} // RVA: 0x7AEA2ACE0
        public void get_Cert(){} // RVA: 0x7AE9D3DC0
        public void GetRawCertData(){} // RVA: 0x7AEA2AEA0
        public void get_HasPrivateKey(){} // RVA: 0x7AEA2AF50
        public void get_PrivateKey(){} // RVA: 0x7AEA2AF80
        public void set_PrivateKey(){} // RVA: 0x7AEA2B400
        public void GetRSAPrivateKey(){} // RVA: 0x7AEA2B6C0
        public void GetDSAPrivateKey(){} // RVA: 0x7AEA2B750
        public void ImportPkcs12(){} // RVA: 0x7AEA2B880
        public void Verify(){} // RVA: 0x7AEA2C0B0
        public void get_IntermediateCertificates(){} // RVA: 0x7A8142610
        public void get_MonoCertificate(){} // RVA: 0x7A8142680
        public void .cctor(){} // RVA: 0x7AEA2C1A0
    }

    public class X509Certificate2ImplUnix : X509Certificate2Impl
    {
        // ── Methods ──
        public void EnsureCertData(){} // RVA: 0x7AEA2C320
        public void GetRawCertData(){} // RVA: 0x7A7E00680
        public void get_KeyAlgorithm(){} // RVA: 0x7AEA2C4B0
        public void get_KeyAlgorithmParameters(){} // RVA: 0x7AEA2C4D0
        public void get_PublicKeyValue(){} // RVA: 0x7AEA2C4F0
        public void get_SerialNumber(){} // RVA: 0x7AEA2C510
        public void get_SignatureAlgorithm(){} // RVA: 0x7AEA2C530
        public void get_Version(){} // RVA: 0x7AEA2C550
        public void get_SubjectName(){} // RVA: 0x7AEA2C570
        public void get_IssuerName(){} // RVA: 0x7AEA2C590
        public void get_Subject(){} // RVA: 0x7AEA2C5B0
        public void get_Issuer(){} // RVA: 0x7AEA2C5E0
        public void get_RawData(){} // RVA: 0x7AEA2C610
        public void get_Thumbprint(){} // RVA: 0x7AEA2C630
        public void GetNameInfo(){} // RVA: 0x7AEA2C810
        public void get_Extensions(){} // RVA: 0x7AEA2C850
        public void get_NotAfter(){} // RVA: 0x7AEA2C870
        public void get_NotBefore(){} // RVA: 0x7AEA2C910
        public void AppendPrivateKeyInfo(){} // RVA: 0x7AEA2C9B0
        public void Export(){} // RVA: 0x7AEA2CA70
        public void ExportPkcs12(){} // RVA: 0x7AEA2CCD0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class X509CertificateCollection : CollectionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA2D150
        public void get_Item(){} // RVA: 0x7AEA2D180
        public void Add(){} // RVA: 0x7AEA2D220
        public void AddRange(){} // RVA: 0x7AEA2D2B0
        public void GetEnumerator(){} // RVA: 0x7AEA2D390
        public void GetHashCode(){} // RVA: 0x7A8738190
    }

    public class X509CertificateImpl : Object
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7A7E01900
        public void ThrowIfContextInvalid(){} // RVA: 0x7ADAA0650
        public void Clone(){} // RVA: 0x7A7E00680
        public void get_Issuer(){} // RVA: 0x7A7E00680
        public void get_Subject(){} // RVA: 0x7A7E00680
        public void get_RawData(){} // RVA: 0x7A7E00680
        public void get_NotAfter(){} // RVA: 0x7A7E00680
        public void get_NotBefore(){} // RVA: 0x7A7E00680
        public void get_Thumbprint(){} // RVA: 0x7A7E00680
        public void GetHashCode(){} // RVA: 0x7ADAA06A0
        public void get_KeyAlgorithm(){} // RVA: 0x7A7E00680
        public void get_KeyAlgorithmParameters(){} // RVA: 0x7A7E00680
        public void get_PublicKeyValue(){} // RVA: 0x7A7E00680
        public void get_SerialNumber(){} // RVA: 0x7A7E00680
        public void get_HasPrivateKey(){} // RVA: 0x7A7E01900
        public void GetRSAPrivateKey(){} // RVA: 0x7A7E00680
        public void GetDSAPrivateKey(){} // RVA: 0x7A7E00680
        public void Export(){} // RVA: 0x7A7E0FAB0
        public void CopyWithPrivateKey(){} // RVA: 0x7A7E00B20
        public void Equals(){} // RVA: 0x7ADAA0730
        public void Dispose(){} // RVA: 0x7A80D7310
        public void Finalize(){} // RVA: 0x7ADAA0970
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class X509CertificateImplCollection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA2D7C0
        public void get_Count(){} // RVA: 0x7AEA2DA60
        public void get_Item(){} // RVA: 0x7AEA2DAB0
        public void Add(){} // RVA: 0x7AEA2DB30
        public void Clone(){} // RVA: 0x7AEA2DBC0
        public void Dispose(){} // RVA: 0x7AEA2DC90
        public void Finalize(){} // RVA: 0x7AD899E40
    }

    public class X509Chain : Object
    {
        // ── Methods ──
        public void get_Impl(){} // RVA: 0x7AEA2DE30
        public void .ctor(){} // RVA: 0x7AEA2E150
        public void get_ChainElements(){} // RVA: 0x7AEA2E190
        public void get_ChainPolicy(){} // RVA: 0x7AEA2E210
        public void Build(){} // RVA: 0x7AEA2E290
        public void Reset(){} // RVA: 0x7AEA2E320
        public void Create(){} // RVA: 0x7AEA2E3A0
        public void Dispose(){} // RVA: 0x7AEA2E460
        public void Finalize(){} // RVA: 0x7AD899E40
    }

    public class X509ChainElement : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA2E540
        public void get_Certificate(){} // RVA: 0x7A80F2570
        public void get_ChainElementStatus(){} // RVA: 0x7A80DA7B0
        public void get_StatusFlags(){} // RVA: 0x7A854FDE0
        public void set_StatusFlags(){} // RVA: 0x7A8810F60
        public void Count(){} // RVA: 0x7AEA2E640
        public void Set(){} // RVA: 0x7AEA2E670
        public void UncompressFlags(){} // RVA: 0x7AEA2E730
    }

    public class X509ChainElementCollection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA2F420
        public void get_Count(){} // RVA: 0x7ADBEAB80
        public void get_IsSynchronized(){} // RVA: 0x7ADBEAE00
        public void get_Item(){} // RVA: 0x7AEA2F4C0
        public void get_SyncRoot(){} // RVA: 0x7ADBEAE30
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ADBEAE60
        public void GetEnumerator(){} // RVA: 0x7AEA2F560
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AEA2F5C0
        public void Add(){} // RVA: 0x7AEA2F620
        public void Clear(){} // RVA: 0x7AE562190
        public void Contains(){} // RVA: 0x7AEA2F780
    }

    public class X509ChainElementEnumerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA2F8C0
        public void get_Current(){} // RVA: 0x7AEA2F970
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7AEA2FA10
        public void MoveNext(){} // RVA: 0x7AEA2FA60
        public void Reset(){} // RVA: 0x7AEA2FAB0
    }

    public class X509ChainImpl : Object
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x7A7E01900
        public void ThrowIfContextInvalid(){} // RVA: 0x7AEA2FB00
        public void get_ChainElements(){} // RVA: 0x7A7E00680
        public void get_ChainPolicy(){} // RVA: 0x7A7E00680
        public void Build(){} // RVA: 0x7A7E019D0
        public void AddStatus(){} // RVA: 0x7A7E189D0
        public void Reset(){} // RVA: 0x7A7E18770
        public void Dispose(){} // RVA: 0x7A80D7310
        public void Finalize(){} // RVA: 0x7ADA01B90
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class X509ChainImplMono : X509ChainImpl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA2FBC0
        public void get_IsValid(){} // RVA: 0x7A81BD750
        public void get_ChainElements(){} // RVA: 0x7A80DA7B0
        public void get_ChainPolicy(){} // RVA: 0x7A81052C0
        public void AddStatus(){} // RVA: 0x7A80D7310
        public void Build(){} // RVA: 0x7AEA2FD10
        public void Reset(){} // RVA: 0x7AEA30500
        public void get_Roots(){} // RVA: 0x7AEA30900
        public void get_CertificateAuthorities(){} // RVA: 0x7AEA30B00
        public void get_LMRootStore(){} // RVA: 0x7AEA30D00
        public void get_UserRootStore(){} // RVA: 0x7AEA30DF0
        public void get_LMCAStore(){} // RVA: 0x7AEA30EE0
        public void get_UserCAStore(){} // RVA: 0x7AEA30FD0
        public void get_CertificateCollection(){} // RVA: 0x7AEA310C0
        public void BuildChainFrom(){} // RVA: 0x7AEA31340
        public void SelectBestFromCollection(){} // RVA: 0x7AEA31580
        public void FindParent(){} // RVA: 0x7AEA317B0
        public void IsChainComplete(){} // RVA: 0x7AEA31960
        public void IsSelfIssued(){} // RVA: 0x7AEA31AA0
        public void ValidateChain(){} // RVA: 0x7AEA31B30
        public void Process(){} // RVA: 0x7AEA31DE0
        public void PrepareForNextCertificate(){} // RVA: 0x7AEA32160
        public void WrapUp(){} // RVA: 0x7AEA32500
        public void ProcessCertificateExtensions(){} // RVA: 0x7AEA325D0
        public void IsSignedWith(){} // RVA: 0x7AEA32760
        public void GetSubjectKeyIdentifier(){} // RVA: 0x7AEA327B0
        public void GetAuthorityKeyIdentifier(){} // RVA: 0x7AEA329A0
        public void CheckRevocationOnChain(){} // RVA: 0x7AEA32C50
        public void CheckRevocation(){} // RVA: 0x7AEA32FF0
        public void CheckCrls(){} // RVA: 0x7AEA33270
        public void FindCrl(){} // RVA: 0x7AEA33610
        public void ProcessCrlExtensions(){} // RVA: 0x7AEA337C0
        public void ProcessCrlEntryExtensions(){} // RVA: 0x7AEA33A50
        public void .cctor(){} // RVA: 0x7AEA33C70
    }

    public class X509ChainPolicy : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA33D20
        public void get_ExtraStore(){} // RVA: 0x7AEA33D30
        public void set_ExtraStore(){} // RVA: 0x7A80D8E80
        public void get_RevocationFlag(){} // RVA: 0x7A8133100
        public void get_RevocationMode(){} // RVA: 0x7A82C2070
        public void set_RevocationMode(){} // RVA: 0x7AEA33FE0
        public void get_VerificationFlags(){} // RVA: 0x7A8178B30
        public void set_VerificationFlags(){} // RVA: 0x7AEA34050
        public void get_VerificationTime(){} // RVA: 0x7A8152D80
        public void Reset(){} // RVA: 0x7AEA340C0
    }

    public class X509ChainStatus : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E9DC60
        public void get_Status(){} // RVA: 0x7A765F070
        public void set_Status(){} // RVA: 0x7A76134D0
        public void set_StatusInformation(){} // RVA: 0x7A765F010
        public void GetInformation(){} // RVA: 0x7AEA34330
    }

    public class X509ChainStatus[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1530
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250600
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class X509EnhancedKeyUsageExtension : X509Extension
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA34700
        public void get_EnhancedKeyUsages(){} // RVA: 0x7AEA34990
        public void CopyFrom(){} // RVA: 0x7AEA34B00
        public void Decode(){} // RVA: 0x7AEA34D00
        public void Encode(){} // RVA: 0x7AEA34F00
        public void ToString(){} // RVA: 0x7AEA35150
    }

    public class X509Extension : AsnEncodedData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA35530
        public void get_Critical(){} // RVA: 0x7A81C68D0
        public void set_Critical(){} // RVA: 0x7A81C68E0
        public void CopyFrom(){} // RVA: 0x7AEA35610
        public void FormatUnkownData(){} // RVA: 0x7AEA357B0
    }

    public class X509ExtensionCollection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA359A0
        public void get_Count(){} // RVA: 0x7ADBEAB80
        public void get_IsSynchronized(){} // RVA: 0x7ADBEAE00
        public void get_SyncRoot(){} // RVA: 0x7A97F8BA0
        public void get_Item(){} // RVA: 0x7AEA35A40
        public void Add(){} // RVA: 0x7AEA35CD0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AEA35D60
        public void GetEnumerator(){} // RVA: 0x7AEA35EB0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AEA35F80
        public void .cctor(){} // RVA: 0x7AEA36050
    }

    public class X509ExtensionEnumerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA36100
        public void get_Current(){} // RVA: 0x7AEA36180
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7AEA36220
        public void MoveNext(){} // RVA: 0x7AEA36270
        public void Reset(){} // RVA: 0x7AEA362C0
    }

    public class X509Extension[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class X509Helper : Object
    {
        // ── Methods ──
        public void get_CertificateProvider(){} // RVA: 0x7ADAA09C0
        public void InitFromCertificate(){} // RVA: 0x7ADAA0B10
        public void IsValid(){} // RVA: 0x7ADAA0B30
        public void ThrowIfContextInvalid(){} // RVA: 0x7ADAA0B50
        public void GetInvalidContextException(){} // RVA: 0x7ADAA0BA0
        public void Import(){} // RVA: 0x7ADAA0CE0
    }

    public class X509Helper2 : Object
    {
        // ── Methods ──
        public void GetMonoCertificate(){} // RVA: 0x7AEA36310
        public void CreateChainImpl(){} // RVA: 0x7AEA363E0
        public void IsValid(){} // RVA: 0x7ADAA0B30
        public void ThrowIfContextInvalid(){} // RVA: 0x7AEA36570
        public void GetInvalidChainContextException(){} // RVA: 0x7AEA365C0
    }

    public class X509KeyUsageExtension : X509Extension
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA36890
        public void get_KeyUsages(){} // RVA: 0x7AEA369B0
        public void CopyFrom(){} // RVA: 0x7AEA36A20
        public void GetValidFlags(){} // RVA: 0x7AEA36C20
        public void Decode(){} // RVA: 0x7AEA36C30
        public void Encode(){} // RVA: 0x7AEA36D90
        public void ToString(){} // RVA: 0x7AEA37040
    }

    public class X509Store : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA376E0
        public void get_Certificates(){} // RVA: 0x7AEA37830
        public void get_Factory(){} // RVA: 0x7AEA37900
        public void get_Store(){} // RVA: 0x7A83F69F0
        public void Close(){} // RVA: 0x7AEA37920
        public void Dispose(){} // RVA: 0x7AEA379F0
        public void Open(){} // RVA: 0x7AEA37A00
    }

    public class X509SubjectKeyIdentifierExtension : X509Extension
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA386A0
        public void get_SubjectKeyIdentifier(){} // RVA: 0x7AEA38C30
        public void CopyFrom(){} // RVA: 0x7AEA38D00
        public void FromHexChar(){} // RVA: 0x7AEA38F00
        public void FromHexChars(){} // RVA: 0x7AEA38F30
        public void FromHex(){} // RVA: 0x7AEA38FB0
        public void Decode(){} // RVA: 0x7AEA39130
        public void Encode(){} // RVA: 0x7AEA392C0
        public void ToString(){} // RVA: 0x7AEA39380
    }

}