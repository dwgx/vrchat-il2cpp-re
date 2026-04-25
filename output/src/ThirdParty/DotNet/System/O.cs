// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 11
// Methods: 64

namespace ThirdParty.DotNet.System
{
    public class Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC8261650 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Finalize(){} // RVA: 0x7FFAC2F21310
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void GetType(){} // RVA: 0x7FFAC8653DF0
        public void MemberwiseClone(){} // RVA: 0x7FFAC8512B10
        public void ToString(){} // RVA: 0x7FFAC852AC80
        public void ReferenceEquals(){} // RVA: 0x7FFAC530B460
        public void InternalGetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void FieldGetter(){} // RVA: 0x7FFAC2F21310
        public void FieldSetter(){} // RVA: 0x7FFAC2F21310
    }

    public class ObjectDisposedException : InvalidOperationException
    {
        public string Message; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86449C0 | overloaded x4
        public void GetObjectData(){} // RVA: 0x7FFAC8644AD0
        public void get_Message(){} // RVA: 0x7FFAC8644CD0
        public void get_ObjectName(){} // RVA: 0x7FFAC8644DA0
    }

    public class ObsoleteAttribute : Attribute
    {
        public string Message; // 0x10
        public bool IsError; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45687E0 | overloaded x3
        public void get_Message(){} // RVA: 0x7FFAC2F3C380
        public void get_IsError(){} // RVA: 0x7FFAC2F3C4E0
    }

    public class Obsoletions : Object
    {
        public string SharedUrlFormat;
        public string SystemTextEncodingUTF7Message;
        public string SystemTextEncodingUTF7DiagId;
        public string PrincipalPermissionAttributeMessage;
        public string PrincipalPermissionAttributeDiagId;
        public string CodeAccessSecurityMessage;
        public string CodeAccessSecurityDiagId;
        public string ConstrainedExecutionRegionMessage;
        public string ConstrainedExecutionRegionDiagId;
        public string GlobalAssemblyCacheMessage;
        public string GlobalAssemblyCacheDiagId;
        public string ThreadAbortMessage;
        public string ThreadResetAbortMessage;
        public string ThreadAbortDiagId;
        public string DefaultCryptoAlgorithmsMessage;
        public string DefaultCryptoAlgorithmsDiagId;
        public string CreatePdbGeneratorMessage;
        public string CreatePdbGeneratorDiagId;
        public string AuthenticationManagerMessage;
        public string AuthenticationManagerDiagId;
        public string RemotingApisMessage;
        public string RemotingApisDiagId;
        public string BinaryFormatterMessage;
        public string BinaryFormatterDiagId;
        public string CodeBaseMessage;
        public string CodeBaseDiagId;
        public string EscapeUriStringMessage;
        public string EscapeUriStringDiagId;
        public string WebRequestMessage;
        public string WebRequestDiagId;
        public string DisablePrivateReflectionAttributeMessage;
        public string DisablePrivateReflectionAttributeDiagId;
        public string GetContextInfoMessage;
        public string GetContextInfoDiagId;
        public string StrongNameKeyPairMessage;
        public string StrongNameKeyPairDiagId;
        public string ReflectionOnlyLoadingMessage;
        public string ReflectionOnlyLoadingDiagId;
        public string RuntimeEnvironmentMessage;
        public string RuntimeEnvironmentDiagId;
        public string JsonSerializerOptionsIgnoreNullValuesMessage;
        public string JsonSerializerOptionsIgnoreNullValuesDiagId;
        public string DerivedCryptographicTypesMessage;
        public string DerivedCryptographicTypesDiagId;
        public string RijndaelMessage;
        public string RijndaelDiagId;
        public string RNGCryptoServiceProviderMessage;
        public string RNGCryptoServiceProviderDiagId;
        public string AppDomainCreateUnloadMessage;
        public string AppDomainCreateUnloadDiagId;
        public string SuppressIldasmAttributeMessage;
        public string SuppressIldasmAttributeDiagId;
        public string X509CertificateImmutableMessage;
        public string X509CertificateImmutableDiagId;
        public string PublicKeyPropertyMessage;
        public string PublicKeyPropertyDiagId;
        public string X509CertificatePrivateKeyMessage;
        public string X509CertificatePrivateKeyDiagId;
        public string ProduceLegacyHmacValuesMessage;
        public string ProduceLegacyHmacValuesDiagId;
        public string UseManagedSha1Message;
        public string UseManagedSha1DiagId;
        public string CryptoConfigEncodeOIDMessage;
        public string CryptoConfigEncodeOIDDiagId;
        public string CorruptedStateRecoveryMessage;
        public string CorruptedStateRecoveryDiagId;
        public string Rfc2898CryptDeriveKeyMessage;
        public string Rfc2898CryptDeriveKeyDiagId;
        public string CmsSignerCspParamsCtorMessage;
        public string CmsSignerCspParamsCtorDiagId;
        public string SignerInfoCounterSigMessage;
        public string SignerInfoCounterSigDiagId;
        public string RegexCompileToAssemblyMessage;
        public string RegexCompileToAssemblyDiagId;
        public string AssemblyNameMembersMessage;
        public string AssemblyNameMembersDiagId;
        public string SystemDataSerializationFormatBinaryMessage;
        public string SystemDataSerializationFormatBinaryDiagId;
        public string TlsVersion10and11Message;
        public string TlsVersion10and11DiagId;
        public string EncryptionPolicyMessage;
        public string EncryptionPolicyDiagId;
        public string Rfc2898OutdatedCtorMessage;
        public string Rfc2898OutdatedCtorDiagId;
        public string EccXmlExportImportMessage;
        public string EccXmlExportImportDiagId;
        public string EcDhPublicKeyBlobMessage;
        public string EcDhPublicKeyBlobDiagId;
        public string AssemblyNameCodeBaseMessage;
        public string AssemblyNameCodeBaseDiagId;
        public string CryptoStringFactoryMessage;
        public string CryptoStringFactoryDiagId;
        public string ControlledExecutionRunMessage;
        public string ControlledExecutionRunDiagId;
        public string XmlSecureResolverMessage;
        public string XmlSecureResolverDiagId;
        public string RsaEncryptDecryptValueMessage;
        public string RsaEncryptDecryptDiagId;
        public string JsonSerializerOptionsAddContextMessage;
        public string JsonSerializerOptionsAddContextDiagId;
        public string LegacyFormatterMessage;
        public string LegacyFormatterDiagId;
        public string LegacyFormatterImplMessage;
        public string LegacyFormatterImplDiagId;
        public string RegexExtensibilityImplMessage;
        public string RegexExtensibilityDiagId;
        public string AesGcmTagConstructorMessage;
        public string AesGcmTagConstructorDiagId;
    }

    public class OperatingSystem : Object
    {
        public System.Version Platform; // 0x10
        public 0x6B0C43B0 Version; // 0x18
        public string VersionString; // 0x20
        public string _versionString; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC865FDC0 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFAC865FF10
        public void get_Platform(){} // RVA: 0x7FFAC3157800
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
        public void Clone(){} // RVA: 0x7FFAC865FF50
        public void ToString(){} // RVA: 0x7FFAC865FFE0
        public void get_VersionString(){} // RVA: 0x7FFAC865FFF0
    }

    public class OperationCanceledException : SystemException
    {
        public System.Threading.CancellationToken CancellationToken; // 0x90

        // ── Methods ──
        public void get_CancellationToken(){} // RVA: 0x7FFAC32EF640
        public void set_CancellationToken(){} // RVA: 0x7FFAC354E360
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x7
    }

    public class OrdinalCaseSensitiveComparer : OrdinalComparer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC864E720
        public void Compare(){} // RVA: 0x7FFAC84E2950
        public void Equals(){} // RVA: 0x7FFAC84E29A0
        public void GetHashCode(){} // RVA: 0x7FFAC864E770
        public void GetObjectData(){} // RVA: 0x7FFAC864E7A0
    }

    public class OrdinalComparer : StringComparer
    {
        public bool _ignoreCase; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC864E2E0
        public void Compare(){} // RVA: 0x7FFAC864E340
        public void Equals(){} // RVA: 0x7FFAC864E620 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC864E6C0 | overloaded x2
    }

    public class OrdinalIgnoreCaseComparer : OrdinalComparer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC864E8A0
        public void Compare(){} // RVA: 0x7FFAC864E8F0
        public void Equals(){} // RVA: 0x7FFAC864E9E0
        public void GetHashCode(){} // RVA: 0x7FFAC864EAB0
        public void GetObjectData(){} // RVA: 0x7FFAC864EB10
    }

    public class OutOfMemoryException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class OverflowException : ArithmeticException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x4
    }

}