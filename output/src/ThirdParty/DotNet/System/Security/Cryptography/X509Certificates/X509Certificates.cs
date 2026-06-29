// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography.X509Certificates
// Classes: 33
// Methods: 361

namespace ThirdParty.DotNet.System.Security.Cryptography.X509Certificates
{
    public class PublicKey : Object
    {
        public object rsaOid;
        public object dsaOid;
        public object _key;
        public object _keyValue;
        public object _params;
        public object _oid;
        public object Empty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7694E90
        public void get_EncodedKeyValue(){} // RVA: 0xB465B0
        public void get_EncodedParameters(){} // RVA: 0xB700F0
        public void get_Key(){} // RVA: 0x7695080
        public void get_Oid(){} // RVA: 0xB70160
        public void GetUnsignedBigInteger(){} // RVA: 0x76952B0
        public void DecodeDSA(){} // RVA: 0x7695360
        public void DecodeRSA(){} // RVA: 0x7695920
        public void .cctor(){} // RVA: 0x7695D40
    }

    public class RSACertificateExtensions : Object
    {
        // ── Methods ──
        public void GetRSAPublicKey(){} // RVA: 0x7014DF0
    }

    public class X500DistinguishedName : AsnEncodedData
    {
        public object AllFlags;
        public object name;
        public object canonEncoding;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7695F30
        public void get_Name(){} // RVA: 0xB700F0
        public void Decode(){} // RVA: 0x7696280
        public void Format(){} // RVA: 0x7696440
        public void GetSeparator(){} // RVA: 0x76964B0
        public void DecodeRawData(){} // RVA: 0x7696520
        public void Canonize(){} // RVA: 0x76966C0
        public void AreEqual(){} // RVA: 0x76968F0
    }

    public class X509BasicConstraintsExtension : X509Extension
    {
        public object oid;
        public object friendlyName;
        public object _certificateAuthority;
        public object _hasPathLengthConstraint;
        public object _pathLengthConstraint;
        public object _status;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7696D90
        public void get_CertificateAuthority(){} // RVA: 0x7696F00
        public void get_HasPathLengthConstraint(){} // RVA: 0x7696F70
        public void get_PathLengthConstraint(){} // RVA: 0x7696FE0
        public void CopyFrom(){} // RVA: 0x7697050
        public void Decode(){} // RVA: 0x7697250
        public void Encode(){} // RVA: 0x76973C0
        public void ToString(){} // RVA: 0x7697640
    }

    public class X509Certificate : Object
    {
        public object impl;
        public object lazyCertHash;
        public object lazySerialNumber;
        public object lazyIssuer;
        public object lazySubject;
        public object lazyKeyAlgorithm;
        public object lazyKeyAlgorithmParameters;
        public object lazyPublicKey;
        public object lazyNotBefore;
        public object lazyNotAfter;

        // ── Methods ──
        public void Reset(){} // RVA: 0x6728550
        public void .ctor(){} // RVA: 0x67291E0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x6729230
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x6729270
        public void get_Issuer(){} // RVA: 0x67292B0
        public void get_Subject(){} // RVA: 0x67293A0
        public void Dispose(){} // RVA: 0x67294B0
        public void Equals(){} // RVA: 0x6729570
        public void Export(){} // RVA: 0x67296A0
        public void GetCertHash(){} // RVA: 0x6729870
        public void GetCertHashString(){} // RVA: 0x6729940
        public void GetRawCertHash(){} // RVA: 0x67299C0
        public void GetPublicKeyString(){} // RVA: 0x6729A50
        public void GetRawCertData(){} // RVA: 0x6729A90
        public void GetHashCode(){} // RVA: 0x6729B80
        public void GetKeyAlgorithm(){} // RVA: 0x6729C80
        public void GetKeyAlgorithmParameters(){} // RVA: 0x6729D70
        public void GetPublicKey(){} // RVA: 0x6729EC0
        public void GetSerialNumber(){} // RVA: 0x672A010
        public void GetSerialNumberString(){} // RVA: 0x672A180
        public void GetRawSerialNumber(){} // RVA: 0x672A200
        public void ToString(){} // RVA: 0x672A2B0
        public void GetNotAfter(){} // RVA: 0x672A7E0
        public void GetNotBefore(){} // RVA: 0x672A910
        public void FormatDate(){} // RVA: 0x672AA40
        public void ValidateKeyStorageFlags(){} // RVA: 0x672ACD0
        public void VerifyContentType(){} // RVA: 0x672ADF0
        public void ImportHandle(){} // RVA: 0x672AE60
        public void get_Impl(){} // RVA: 0xB5DBF0
        public void get_IsValid(){} // RVA: 0x672AEE0
        public void ThrowIfInvalid(){} // RVA: 0x672AF00
    }

    public class X509Certificate2 : X509Certificate
    {
        public object lazyRawData;
        public object lazySignatureAlgorithm;
        public object lazyVersion;
        public object lazySubjectName;
        public object lazyIssuerName;
        public object lazyPublicKey;
        public object lazyPrivateKey;
        public object lazyExtensions;

        // ── Methods ──
        public void Reset(){} // RVA: 0x76978F0
        public void .ctor(){} // RVA: 0x7697D70
        public void get_Extensions(){} // RVA: 0x7697D90
        public void get_HasPrivateKey(){} // RVA: 0x76981D0
        public void get_PrivateKey(){} // RVA: 0x7698250
        public void get_IssuerName(){} // RVA: 0x7698480
        public void get_NotAfter(){} // RVA: 0x7698590
        public void get_NotBefore(){} // RVA: 0x76985A0
        public void get_PublicKey(){} // RVA: 0x76985B0
        public void get_RawData(){} // RVA: 0x76987E0
        public void get_SerialNumber(){} // RVA: 0x42E82B0
        public void get_SignatureAlgorithm(){} // RVA: 0x7698940
        public void get_SubjectName(){} // RVA: 0x7698A50
        public void get_Thumbprint(){} // RVA: 0x7698B50
        public void get_Version(){} // RVA: 0x7698B90
        public void GetCertContentType(){} // RVA: 0x7698C30
        public void GetNameInfo(){} // RVA: 0x7698CD0
        public void ToString(){} // RVA: 0x7698D30
        public void Verify(){} // RVA: 0x7699DC0
        public void CreateCustomExtensionIfAny(){} // RVA: 0x7699E00
        public void get_Impl(){} // RVA: 0x769A300
    }

    public class X509Certificate2Collection : X509CertificateCollection
    {
        public object newline_split;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x769A3B0
        public void get_Item(){} // RVA: 0x769A450
        public void Add(){} // RVA: 0x769A5C0
        public void AddRange(){} // RVA: 0x769A650
        public void Contains(){} // RVA: 0x769A6E0
        public void GetKeyIdentifier(){} // RVA: 0x769A910
        public void Find(){} // RVA: 0x769A9F0
        public void GetEnumerator(){} // RVA: 0x769C0A0
        public void .cctor(){} // RVA: 0x769C180
    }

    public class X509Certificate2Enumerator : Object
    {
        public object enumerator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x769C250
        public void get_Current(){} // RVA: 0x769C300
        public void MoveNext(){} // RVA: 0x769C3A0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x769C3F0
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x769C440
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x769C490
    }

    public class X509Certificate2Impl : X509CertificateImpl
    {
        // ── Methods ──
        public void get_Extensions(){} // RVA: 0x87C0A0
        public void get_IssuerName(){} // RVA: 0x87C0A0
        public void get_PrivateKey(){} // RVA: 0x87C0A0
        public void set_PrivateKey(){} // RVA: 0x894320
        public void get_SignatureAlgorithm(){} // RVA: 0x87C0A0
        public void get_SubjectName(){} // RVA: 0x87C0A0
        public void get_Version(){} // RVA: 0x87C130
        public void get_IntermediateCertificates(){} // RVA: 0x87C0A0
        public void GetNameInfo(){} // RVA: 0x88C4E0
        public void Verify(){} // RVA: 0x87D350
        public void AppendPrivateKeyInfo(){} // RVA: 0x894320
        public void CopyWithPrivateKey(){} // RVA: 0x769C4E0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class X509Certificate2ImplMono : X509Certificate2ImplUnix
    {
        public object intermediateCerts;
        public object _cert;
        public object empty_error;
        public object signedData;

        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x73FF900
        public void .ctor(){} // RVA: 0x769C700
        public void Clone(){} // RVA: 0x769C980
        public void get_Cert(){} // RVA: 0x7645F00
        public void GetRawCertData(){} // RVA: 0x769CB40
        public void get_HasPrivateKey(){} // RVA: 0x769CBF0
        public void get_PrivateKey(){} // RVA: 0x769CC20
        public void set_PrivateKey(){} // RVA: 0x769D0A0
        public void GetRSAPrivateKey(){} // RVA: 0x769D360
        public void GetDSAPrivateKey(){} // RVA: 0x769D3F0
        public void ImportPkcs12(){} // RVA: 0x769D520
        public void Verify(){} // RVA: 0x769DD40
        public void get_IntermediateCertificates(){} // RVA: 0xBAE340
        public void get_MonoCertificate(){} // RVA: 0xBAE3B0
        public void .cctor(){} // RVA: 0x769DE30
    }

    public class X509Certificate2ImplUnix : X509Certificate2Impl
    {
        public object readCertData;
        public object certData;

        // ── Methods ──
        public void EnsureCertData(){} // RVA: 0x769DFB0
        public void GetRawCertData(){} // RVA: 0x87C0A0
        public void get_KeyAlgorithm(){} // RVA: 0x769E140
        public void get_KeyAlgorithmParameters(){} // RVA: 0x769E160
        public void get_PublicKeyValue(){} // RVA: 0x769E180
        public void get_SerialNumber(){} // RVA: 0x769E1A0
        public void get_SignatureAlgorithm(){} // RVA: 0x769E1C0
        public void get_Version(){} // RVA: 0x769E1E0
        public void get_SubjectName(){} // RVA: 0x769E200
        public void get_IssuerName(){} // RVA: 0x769E220
        public void get_Subject(){} // RVA: 0x769E240
        public void get_Issuer(){} // RVA: 0x769E270
        public void get_RawData(){} // RVA: 0x769E2A0
        public void get_Thumbprint(){} // RVA: 0x769E2C0
        public void GetNameInfo(){} // RVA: 0x769E4A0
        public void get_Extensions(){} // RVA: 0x769E4E0
        public void get_NotAfter(){} // RVA: 0x769E500
        public void get_NotBefore(){} // RVA: 0x769E5A0
        public void AppendPrivateKeyInfo(){} // RVA: 0x769E640
        public void Export(){} // RVA: 0x769E700
        public void ExportPkcs12(){} // RVA: 0x769E960
        public void .ctor(){} // RVA: 0xB43310
    }

    public class X509CertificateCollection : CollectionBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x769EDE0
        public void get_Item(){} // RVA: 0x769EE10
        public void Add(){} // RVA: 0x769EEB0
        public void AddRange(){} // RVA: 0x769EF40
        public void GetEnumerator(){} // RVA: 0x769F020
        public void GetHashCode(){} // RVA: 0x1269730
    }

    public class X509CertificateImpl : Object
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x87D280
        public void ThrowIfContextInvalid(){} // RVA: 0x672AF60
        public void Clone(){} // RVA: 0x87C0A0
        public void get_Issuer(){} // RVA: 0x87C0A0
        public void get_Subject(){} // RVA: 0x87C0A0
        public void get_RawData(){} // RVA: 0x87C0A0
        public void get_NotAfter(){} // RVA: 0x87C0A0
        public void get_NotBefore(){} // RVA: 0x87C0A0
        public void get_Thumbprint(){} // RVA: 0x87C0A0
        public void GetHashCode(){} // RVA: 0x672AFB0
        public void get_KeyAlgorithm(){} // RVA: 0x87C0A0
        public void get_KeyAlgorithmParameters(){} // RVA: 0x87C0A0
        public void get_PublicKeyValue(){} // RVA: 0x87C0A0
        public void get_SerialNumber(){} // RVA: 0x87C0A0
        public void get_HasPrivateKey(){} // RVA: 0x87D280
        public void GetRSAPrivateKey(){} // RVA: 0x87C0A0
        public void GetDSAPrivateKey(){} // RVA: 0x87C0A0
        public void Export(){} // RVA: 0x88B510
        public void CopyWithPrivateKey(){} // RVA: 0x87C540
        public void Equals(){} // RVA: 0x672B040
        public void Dispose(){} // RVA: 0xB43310
        public void Finalize(){} // RVA: 0x672B280
        public void .ctor(){} // RVA: 0xB43310
    }

    public class X509CertificateImplCollection : Object
    {
        public object list;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x769F450
        public void get_Count(){} // RVA: 0x769F6F0
        public void get_Item(){} // RVA: 0x769F740
        public void Add(){} // RVA: 0x769F7C0
        public void Clone(){} // RVA: 0x769F850
        public void Dispose(){} // RVA: 0x769F920
        public void Finalize(){} // RVA: 0x6527310
    }

    public class X509Chain : Object
    {
        public object impl;

        // ── Methods ──
        public void get_Impl(){} // RVA: 0x769FAC0
        public void .ctor(){} // RVA: 0x769FDE0
        public void get_ChainElements(){} // RVA: 0x769FE20
        public void get_ChainPolicy(){} // RVA: 0x769FEA0
        public void Build(){} // RVA: 0x769FF20
        public void Reset(){} // RVA: 0x769FFB0
        public void Create(){} // RVA: 0x76A0030
        public void Dispose(){} // RVA: 0x76A00F0
        public void Finalize(){} // RVA: 0x6527310
    }

    public class X509ChainElement : Object
    {
        public object certificate;
        public object status;
        public object info;
        public object compressed_status_flags;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76A01D0
        public void get_Certificate(){} // RVA: 0xB5DBF0
        public void get_ChainElementStatus(){} // RVA: 0xB465B0
        public void get_StatusFlags(){} // RVA: 0x1065D50
        public void set_StatusFlags(){} // RVA: 0x13233D0
        public void Count(){} // RVA: 0x76A0290
        public void Set(){} // RVA: 0x76A02C0
        public void UncompressFlags(){} // RVA: 0x76A0380
    }

    public class X509ChainElementCollection : Object
    {
        public object _list;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76A1040
        public void get_Count(){} // RVA: 0x6875CA0
        public void get_IsSynchronized(){} // RVA: 0x10694A0
        public void get_Item(){} // RVA: 0x76A10E0
        public void get_SyncRoot(){} // RVA: 0x6875F20
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x6875F50
        public void GetEnumerator(){} // RVA: 0x76A1180
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x76A11E0
        public void Add(){} // RVA: 0x76A1240
        public void Clear(){} // RVA: 0x71DA540
        public void Contains(){} // RVA: 0x76A1370
    }

    public class X509ChainElementEnumerator : Object
    {
        public object enumerator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76A14B0
        public void get_Current(){} // RVA: 0x76A1560
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x76A1600
        public void MoveNext(){} // RVA: 0x76A1650
        public void Reset(){} // RVA: 0x76A16A0
    }

    public class X509ChainImpl : Object
    {
        // ── Methods ──
        public void get_IsValid(){} // RVA: 0x87D280
        public void ThrowIfContextInvalid(){} // RVA: 0x76A16F0
        public void get_ChainElements(){} // RVA: 0x87C0A0
        public void get_ChainPolicy(){} // RVA: 0x87C0A0
        public void Build(){} // RVA: 0x87D350
        public void AddStatus(){} // RVA: 0x8944F0
        public void Reset(){} // RVA: 0x894290
        public void Dispose(){} // RVA: 0xB43310
        public void Finalize(){} // RVA: 0x668C6F0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class X509ChainImplMono : X509ChainImpl
    {
        public object location;
        public object elements;
        public object policy;
        public object status;
        public object Empty;
        public object max_path_length;
        public object working_issuer_name;
        public object working_public_key;
        public object bce_restriction;
        public object roots;
        public object cas;
        public object root_store;
        public object ca_store;
        public object user_root_store;
        public object user_ca_store;
        public object collection;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76A17B0
        public void get_IsValid(){} // RVA: 0xC2E4C0
        public void get_ChainElements(){} // RVA: 0xB465B0
        public void get_ChainPolicy(){} // RVA: 0xB700F0
        public void AddStatus(){} // RVA: 0xB43310
        public void Build(){} // RVA: 0x76A1900
        public void Reset(){} // RVA: 0x76A2110
        public void get_Roots(){} // RVA: 0x76A2510
        public void get_CertificateAuthorities(){} // RVA: 0x76A2710
        public void get_LMRootStore(){} // RVA: 0x76A2910
        public void get_UserRootStore(){} // RVA: 0x76A2A00
        public void get_LMCAStore(){} // RVA: 0x76A2AF0
        public void get_UserCAStore(){} // RVA: 0x76A2BE0
        public void get_CertificateCollection(){} // RVA: 0x76A2CD0
        public void BuildChainFrom(){} // RVA: 0x76A2F50
        public void SelectBestFromCollection(){} // RVA: 0x76A3190
        public void FindParent(){} // RVA: 0x76A33C0
        public void IsChainComplete(){} // RVA: 0x76A3570
        public void IsSelfIssued(){} // RVA: 0x76A36B0
        public void ValidateChain(){} // RVA: 0x76A3740
        public void Process(){} // RVA: 0x76A39F0
        public void PrepareForNextCertificate(){} // RVA: 0x76A3D70
        public void WrapUp(){} // RVA: 0x76A4110
        public void ProcessCertificateExtensions(){} // RVA: 0x76A41E0
        public void IsSignedWith(){} // RVA: 0x76A4370
        public void GetSubjectKeyIdentifier(){} // RVA: 0x76A43C0
        public void GetAuthorityKeyIdentifier(){} // RVA: 0x76A45A0
        public void CheckRevocationOnChain(){} // RVA: 0x76A4840
        public void CheckRevocation(){} // RVA: 0x76A4BE0
        public void CheckCrls(){} // RVA: 0x76A4E60
        public void FindCrl(){} // RVA: 0x76A5200
        public void ProcessCrlExtensions(){} // RVA: 0x76A5490
        public void ProcessCrlEntryExtensions(){} // RVA: 0x76A5720
        public void .cctor(){} // RVA: 0x76A5940
    }

    public class X509ChainPolicy : Object
    {
        public object apps;
        public object cert;
        public object store;
        public object store2;
        public object rflag;
        public object mode;
        public object timeout;
        public object vflags;
        public object vtime;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76A59F0
        public void get_ExtraStore(){} // RVA: 0x76A5A00
        public void set_ExtraStore(){} // RVA: 0xB44DC0
        public void get_RevocationFlag(){} // RVA: 0xB9E080
        public void get_RevocationMode(){} // RVA: 0xE9CE60
        public void set_RevocationMode(){} // RVA: 0x76A5CB0
        public void get_VerificationFlags(){} // RVA: 0xBE5850
        public void set_VerificationFlags(){} // RVA: 0x76A5D20
        public void get_VerificationTime(){} // RVA: 0xBBF8F0
        public void Reset(){} // RVA: 0x76A5D90
    }

    public class X509ChainStatus : ValueType
    {
        public object status;
        public object info;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x91E3C0
        public void get_Status(){} // RVA: 0x77E60
        public void set_Status(){} // RVA: 0x29580
        public void set_StatusInformation(){} // RVA: 0x77E70
        public void GetInformation(){} // RVA: 0x76A6000
    }

    public class X509ChainStatus[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class X509EnhancedKeyUsageExtension : X509Extension
    {
        public object _enhKeyUsage;
        public object _status;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76A63C0
        public void get_EnhancedKeyUsages(){} // RVA: 0x76A6650
        public void CopyFrom(){} // RVA: 0x76A67C0
        public void Decode(){} // RVA: 0x76A69C0
        public void Encode(){} // RVA: 0x76A6BC0
        public void ToString(){} // RVA: 0x76A6E10
    }

    public class X509Extension : AsnEncodedData
    {
        public object _critical;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76A71E0
        public void get_Critical(){} // RVA: 0xC38360
        public void set_Critical(){} // RVA: 0xC38370
        public void CopyFrom(){} // RVA: 0x76A72C0
        public void FormatUnkownData(){} // RVA: 0x76A7460
    }

    public class X509ExtensionCollection : Object
    {
        public object Empty;
        public object _list;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76A7640
        public void get_Count(){} // RVA: 0x6875CA0
        public void get_IsSynchronized(){} // RVA: 0x10694A0
        public void get_SyncRoot(){} // RVA: 0x2303260
        public void get_Item(){} // RVA: 0x76A76E0
        public void Add(){} // RVA: 0x76A7970
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x76A7A00
        public void GetEnumerator(){} // RVA: 0x76A7B50
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x76A7C20
        public void .cctor(){} // RVA: 0x76A7CF0
    }

    public class X509ExtensionEnumerator : Object
    {
        public object enumerator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76A7DA0
        public void get_Current(){} // RVA: 0x76A7E20
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x76A7EC0
        public void MoveNext(){} // RVA: 0x76A7F10
        public void Reset(){} // RVA: 0x76A7F60
    }

    public class X509Extension[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class X509Helper : Object
    {
        // ── Methods ──
        public void get_CertificateProvider(){} // RVA: 0x672B2D0
        public void InitFromCertificate(){} // RVA: 0x672B420
        public void IsValid(){} // RVA: 0x672B440
        public void ThrowIfContextInvalid(){} // RVA: 0x672B460
        public void GetInvalidContextException(){} // RVA: 0x672B4B0
        public void Import(){} // RVA: 0x672B5F0
    }

    public class X509Helper2 : Object
    {
        // ── Methods ──
        public void GetMonoCertificate(){} // RVA: 0x76A7FB0
        public void CreateChainImpl(){} // RVA: 0x76A8080
        public void IsValid(){} // RVA: 0x672B440
        public void ThrowIfContextInvalid(){} // RVA: 0x76A8210
        public void GetInvalidChainContextException(){} // RVA: 0x76A8260
    }

    public class X509KeyUsageExtension : X509Extension
    {
        public object oid;
        public object friendlyName;
        public object all;
        public object _keyUsages;
        public object _status;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76A8530
        public void get_KeyUsages(){} // RVA: 0x76A8650
        public void CopyFrom(){} // RVA: 0x76A86C0
        public void GetValidFlags(){} // RVA: 0x76A88C0
        public void Decode(){} // RVA: 0x76A88D0
        public void Encode(){} // RVA: 0x76A8A30
        public void ToString(){} // RVA: 0x76A8CE0
    }

    public class X509Store : Object
    {
        public object _name;
        public object _location;
        public object list;
        public object _flags;
        public object store;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76A9360
        public void get_Certificates(){} // RVA: 0x76A94B0
        public void get_Factory(){} // RVA: 0x76A9580
        public void get_Store(){} // RVA: 0xD33E60
        public void Close(){} // RVA: 0x76A95A0
        public void Dispose(){} // RVA: 0x76A9670
        public void Open(){} // RVA: 0x76A9680
    }

    public class X509SubjectKeyIdentifierExtension : X509Extension
    {
        public object oid;
        public object friendlyName;
        public object _subjectKeyIdentifier;
        public object _ski;
        public object _status;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76AA320
        public void get_SubjectKeyIdentifier(){} // RVA: 0x76AA8B0
        public void CopyFrom(){} // RVA: 0x76AA980
        public void FromHexChar(){} // RVA: 0x76AAB80
        public void FromHexChars(){} // RVA: 0x76AABB0
        public void FromHex(){} // RVA: 0x76AAC30
        public void Decode(){} // RVA: 0x76AADB0
        public void Encode(){} // RVA: 0x76AAF30
        public void ToString(){} // RVA: 0x76AAFF0
    }

}