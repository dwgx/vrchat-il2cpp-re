// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509
// Classes: 70
// Methods: 588

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509
{
    public class AccessDescription
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1D0810
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x2
        public void get_AccessMethod(){} // RVA: 0x7FFAF2DA8380
        public void get_AccessLocation(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1D0BB0
        public void ToString(){} // RVA: 0x7FFAFC1D0CC0
        public void .cctor(){} // RVA: 0x7FFAFC1D0D30
    }

    public class AlgorithmIdentifier
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1D0EE0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1D1080 | overloaded x4
        public void get_Algorithm(){} // RVA: 0x7FFAF2DA8380
        public void get_ObjectID(){} // RVA: 0x7FFAF2DA8380
        public void get_Parameters(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1D12C0
    }

    public class AttCertIssuer : GetInstance
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1D1800 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1D1940 | overloaded x2
        public void get_Issuer(){} // RVA: 0x7FFAF2DA8380
        public void ToAsn1Object(){} // RVA: 0x7FFAF2D907C0
    }

    public class AttCertValidityPeriod
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1D1C40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x2
        public void get_NotBeforeTime(){} // RVA: 0x7FFAF2DA8380
        public void get_NotAfterTime(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1D1E20
    }

    public class AttributeCertificate
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1D2400
        public void .ctor(){} // RVA: 0x7FFAFC1D24E0 | overloaded x2
        public void get_ACInfo(){} // RVA: 0x7FFAF2DA8380
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAF2D907C0
        public void get_SignatureValue(){} // RVA: 0x7FFAF2DBB0C0
        public void GetSignatureOctets(){} // RVA: 0x7FFAF91D5860
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1D2750
    }

    public class AttributeCertificateInfo
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1D28D0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1D2AB0
        public void get_Version(){} // RVA: 0x7FFAF2DA8380
        public void get_Holder(){} // RVA: 0x7FFAF2D907C0
        public void get_Issuer(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Signature(){} // RVA: 0x7FFAF2DBB130
        public void get_SerialNumber(){} // RVA: 0x7FFAF30E74D0
        public void get_AttrCertValidityPeriod(){} // RVA: 0x7FFAF2F476A0
        public void get_Attributes(){} // RVA: 0x7FFAF2E0A740
        public void get_IssuerUniqueID(){} // RVA: 0x7FFAF2E08730
        public void get_Extensions(){} // RVA: 0x7FFAF2E2E0E0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1D3070
    }

    public class AttributeTable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1D37A0 | overloaded x4
        public void Get(){} // RVA: 0x7FFAFC1D39E0
        public void ToHashtable(){} // RVA: 0x7FFAFC1D3A90
        public void ToDictionary(){} // RVA: 0x7FFAFC1D3B00
    }

    public class AttributeX509
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1D1F30
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x2
        public void get_AttrType(){} // RVA: 0x7FFAF2DA8380
        public void GetAttributeValues(){} // RVA: 0x7FFAF8771EA0
        public void get_AttrValues(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1D22F0
    }

    public class AuthorityInformationAccess
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1D3B60
        public void .ctor(){} // RVA: 0x7FFAFC1D4160 | overloaded x3
        public void GetAccessDescriptions(){} // RVA: 0x7FFAFC1D4340
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1D43C0
        public void ToString(){} // RVA: 0x7FFAFC1D4420
    }

    public class AuthorityKeyIdentifier
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1D45E0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1D5530 | overloaded x6
        public void GetKeyIdentifier(){} // RVA: 0x7FFAFC1D5830
        public void get_AuthorityCertIssuer(){} // RVA: 0x7FFAF2D907C0
        public void get_AuthorityCertSerialNumber(){} // RVA: 0x7FFAFC1D5860
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1D5880
        public void ToString(){} // RVA: 0x7FFAFC1D5AA0
    }

    public class BasicConstraints
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1D5B60 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1D6110 | overloaded x3
        public void IsCA(){} // RVA: 0x7FFAFC1D6270
        public void get_PathLenConstraint(){} // RVA: 0x7FFAFC1D6290
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1D62B0
        public void ToString(){} // RVA: 0x7FFAFC1D6490
    }

    public class CertPolicyID
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1D7B60
    }

    public class CertificateList
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1D6690 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1D6770
        public void get_TbsCertList(){} // RVA: 0x7FFAF2DA8380
        public void GetRevokedCertificates(){} // RVA: 0x7FFAFC1D69C0
        public void GetRevokedCertificateEnumeration(){} // RVA: 0x7FFAFC1D69E0
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAF2D907C0
        public void get_Signature(){} // RVA: 0x7FFAF2DBB0C0
        public void GetSignatureOctets(){} // RVA: 0x7FFAF91D5860
        public void get_Version(){} // RVA: 0x7FFAFC1D6AE0
        public void get_Issuer(){} // RVA: 0x7FFAF35DE750
        public void get_ThisUpdate(){} // RVA: 0x7FFAF35DEE60
        public void get_NextUpdate(){} // RVA: 0x7FFAF35DE770
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1D6B50
    }

    public class CertificatePair
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1D6CB0
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x2
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1D71B0
        public void get_Forward(){} // RVA: 0x7FFAF2DA8380
        public void get_Reverse(){} // RVA: 0x7FFAF2D907C0
    }

    public class CertificatePolicies
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1D7510 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1D76E0 | overloaded x3
        public void GetPolicyInformation(){} // RVA: 0x7FFAFC1D78C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1D7940
        public void ToString(){} // RVA: 0x7FFAFC1D79A0
    }

    public class CrlDistPoint
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1D7BE0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1D7DF0 | overloaded x2
        public void GetDistributionPoints(){} // RVA: 0x7FFAFC1D7EB0
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
        public void ToString(){} // RVA: 0x7FFAFC1D8050
    }

    public class CrlEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1EB7B0
        public void get_UserCertificate(){} // RVA: 0x7FFAF2D907C0
        public void get_RevocationDate(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Extensions(){} // RVA: 0x7FFAFC1EB9F0
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class CrlNumber
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC18C200
        public void get_Number(){} // RVA: 0x7FFAFC1D81E0
        public void ToString(){} // RVA: 0x7FFAFC1D81F0
    }

    public class CrlReason
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1D82C0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAFC1D8370
        public void .cctor(){} // RVA: 0x7FFAFC1D8470
    }

    public class DigestInfo
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1D86F0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1D88D0 | overloaded x2
        public void get_AlgorithmID(){} // RVA: 0x7FFAF2D907C0
        public void GetDigest(){} // RVA: 0x7FFAF2DA8380
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1D8A90
    }

    public class DisplayText : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DF3E80 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC1D9420
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1D9620
        public void GetString(){} // RVA: 0x7FFAFC1D96A0
    }

    public class DistributionPoint
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1D9710 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF2E6CE00 | overloaded x2
        public void get_DistributionPointName(){} // RVA: 0x7FFAF2DA8380
        public void get_Reasons(){} // RVA: 0x7FFAF2D907C0
        public void get_CrlIssuer(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1D9A90
        public void ToString(){} // RVA: 0x7FFAFC1D9D20
        public void appendObject(){} // RVA: 0x7FFAFC1D9F40
    }

    public class DistributionPointName
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1DA080 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1DA3A0 | overloaded x3
        public void get_PointType(){} // RVA: 0x7FFAF306ED50
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1DA4B0
        public void ToString(){} // RVA: 0x7FFAFC1DA530
        public void appendObject(){} // RVA: 0x7FFAFC1DA6E0
    }

    public class DsaParameter
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1DA7F0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1DAD40 | overloaded x2
        public void get_P(){} // RVA: 0x7FFAFC1DAF80
        public void get_Q(){} // RVA: 0x7FFAFC1DAFA0
        public void get_G(){} // RVA: 0x7FFAFC1DAFC0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1DAFE0
    }

    public class ExtendedKeyUsage
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1DB160 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1DB980 | overloaded x4
        public void HasKeyPurposeId(){} // RVA: 0x7FFAFC1DBE90
        public void GetUsages(){} // RVA: 0x7FFAFC1DBEF0
        public void GetAllUsages(){} // RVA: 0x7FFAFC1DBF80
        public void get_Count(){} // RVA: 0x7FFAFC1DC050
        public void ToAsn1Object(){} // RVA: 0x7FFAF2D907C0
    }

    public class GeneralName
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1DC170 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFAFC1DC980 | overloaded x2
        public void get_TagNo(){} // RVA: 0x7FFAF306ED50
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void ToString(){} // RVA: 0x7FFAFC1DC9D0
        public void toGeneralNameEncoding(){} // RVA: 0x7FFAFC1DCB60
        public void parseIPv4Mask(){} // RVA: 0x7FFAFC1DCFF0
        public void parseIPv4(){} // RVA: 0x7FFAFC1DD080
        public void parseMask(){} // RVA: 0x7FFAFC1DD2C0
        public void copyInts(){} // RVA: 0x7FFAFC1DD370
        public void parseIPv6(){} // RVA: 0x7FFAFC1DD3F0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1DD8A0
    }

    public class GeneralNames
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1DDB00 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1DDD10 | overloaded x3
        public void GetNames(){} // RVA: 0x7FFAFC1DDEF0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1DDF70
        public void ToString(){} // RVA: 0x7FFAFC1DDFD0
    }

    public class GeneralSubtree
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1DE770 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC1DE870 | overloaded x2
        public void get_Base(){} // RVA: 0x7FFAF2DA8380
        public void get_Minimum(){} // RVA: 0x7FFAFC1DE950
        public void get_Maximum(){} // RVA: 0x7FFAFC1D5860
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1DE9D0
    }

    public class Holder
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1DEC10
        public void .ctor(){} // RVA: 0x7FFAFC1DF510 | overloaded x7
        public void get_Version(){} // RVA: 0x7FFAF3241DC0
        public void get_BaseCertificateID(){} // RVA: 0x7FFAF2DA8380
        public void get_EntityName(){} // RVA: 0x7FFAF2D907C0
        public void get_ObjectDigestInfo(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1DF580
    }

    public class IetfAttrSyntax
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1DF830
        public void get_PolicyAuthority(){} // RVA: 0x7FFAF2DA8380
        public void get_ValueType(){} // RVA: 0x7FFAF3210030
        public void GetValues(){} // RVA: 0x7FFAFC1DFEE0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1E03F0
    }

    public class IssuerSerial
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1E0840 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x2
        public void get_Issuer(){} // RVA: 0x7FFAF2DA8380
        public void get_Serial(){} // RVA: 0x7FFAF2D907C0
        public void get_IssuerUid(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1E0B20
    }

    public class IssuingDistributionPoint
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1E0D80 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1E14D0 | overloaded x2
        public void get_OnlyContainsUserCerts(){} // RVA: 0x7FFAF2DA84E0
        public void get_OnlyContainsCACerts(){} // RVA: 0x7FFAF31693D0
        public void get_IsIndirectCrl(){} // RVA: 0x7FFAF3198A80
        public void get_OnlyContainsAttributeCerts(){} // RVA: 0x7FFAF36E6000
        public void get_DistributionPoint(){} // RVA: 0x7FFAF2DA8380
        public void get_OnlySomeReasons(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAF30E74D0
        public void ToString(){} // RVA: 0x7FFAFC1E1830
        public void appendObject(){} // RVA: 0x7FFAFC1E1C40
    }

    public class KeyPurposeID
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1E1D30
        public void .cctor(){} // RVA: 0x7FFAFC1E1D90
    }

    public class KeyUsage
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1E2870
        public void .ctor(){} // RVA: 0x7FFAFC1E2AD0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAFC1E2B80
    }

    public class NameConstraints
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1E2CE0
        public void .ctor(){} // RVA: 0x7FFAFC1E3120 | overloaded x3
        public void CreateSequence(){} // RVA: 0x7FFAFC1E3210
        public void get_PermittedSubtrees(){} // RVA: 0x7FFAF2DA8380
        public void get_ExcludedSubtrees(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1E3540
    }

    public class NoticeReference
    {
        // ── Methods ──
        public void ConvertVector(){} // RVA: 0x7FFAFC1E36F0
        public void .ctor(){} // RVA: 0x7FFAFC1E3E20 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFAFC1E3FF0
        public void get_Organization(){} // RVA: 0x7FFAF2DA8380
        public void GetNoticeNumbers(){} // RVA: 0x7FFAFC1E40D0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1E4270
    }

    public class ObjectDigestInfo
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1E4550 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1E47A0 | overloaded x2
        public void get_DigestedObjectType(){} // RVA: 0x7FFAF2DA8380
        public void get_OtherObjectTypeID(){} // RVA: 0x7FFAF2D907C0
        public void get_DigestAlgorithm(){} // RVA: 0x7FFAF2DBB0C0
        public void get_ObjectDigest(){} // RVA: 0x7FFAF2DBB130
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1E4AE0
    }

    public class PolicyInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC1E4F80
        public void get_PolicyIdentifier(){} // RVA: 0x7FFAF2DA8380
        public void get_PolicyQualifiers(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1E5050
    }

    public class PolicyMappings
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1E5260 | overloaded x3
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class PolicyQualifierID
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1E58C0
        public void .cctor(){} // RVA: 0x7FFAFC1E5920
    }

    public class PolicyQualifierInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1E5D00 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC1E5F00
        public void get_PolicyQualifierId(){} // RVA: 0x7FFAF2DA8380
        public void get_Qualifier(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1E5FE0
    }

    public class PrivateKeyUsagePeriod
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1E60F0
        public void .ctor(){} // RVA: 0x7FFAFC1E6350
        public void get_NotBefore(){} // RVA: 0x7FFAF2DA8380
        public void get_NotAfter(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1E65C0
    }

    public class ReasonFlags
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1E67D0 | overloaded x2
    }

    public class RoleSyntax
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1E6880
        public void .ctor(){} // RVA: 0x7FFAFC1E6E80 | overloaded x4
        public void get_RoleAuthority(){} // RVA: 0x7FFAF2DA8380
        public void get_RoleName(){} // RVA: 0x7FFAF2D907C0
        public void GetRoleNameAsString(){} // RVA: 0x7FFAFC1E70B0
        public void GetRoleAuthorityAsString(){} // RVA: 0x7FFAFC1E7160
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1E7300
        public void ToString(){} // RVA: 0x7FFAFC1E7510
    }

    public class RsaPublicKeyStructure
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1E77F0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1E7B50 | overloaded x2
        public void get_Modulus(){} // RVA: 0x7FFAF2DA8380
        public void get_PublicExponent(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1E7D30
    }

    public class SubjectDirectoryAttributes
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1E7FD0
        public void .ctor(){} // RVA: 0x7FFAFC1E84E0 | overloaded x3
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1E85D0
        public void get_Attributes(){} // RVA: 0x7FFAFC1E8940
    }

    public class SubjectKeyIdentifier
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1E8A50 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1E8E70 | overloaded x3
        public void GetKeyIdentifier(){} // RVA: 0x7FFAF2DA8380
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1E8EE0
        public void CreateSha1KeyIdentifier(){} // RVA: 0x7FFAFC1E8FD0
        public void CreateTruncatedSha1KeyIdentifier(){} // RVA: 0x7FFAFC1E9030
        public void GetDigest(){} // RVA: 0x7FFAFC1E9160
    }

    public class SubjectPublicKeyInfo
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1E92A0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1E95E0 | overloaded x3
        public void get_AlgorithmID(){} // RVA: 0x7FFAF2DA8380
        public void ParsePublicKey(){} // RVA: 0x7FFAFC1E97F0
        public void GetPublicKey(){} // RVA: 0x7FFAFC1E97F0
        public void get_PublicKeyData(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1E9830
    }

    public class Target : GetInstance
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1E9940
        public void .ctor(){} // RVA: 0x7FFAFC1E9D10 | overloaded x2
        public void get_TargetGroup(){} // RVA: 0x7FFAF2D907C0
        public void get_TargetName(){} // RVA: 0x7FFAF2DA8380
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1E9DD0
    }

    public class TargetInformation
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1E9F60
        public void .ctor(){} // RVA: 0x7FFAFC1EA3D0 | overloaded x3
        public void GetTargetsObjects(){} // RVA: 0x7FFAFC1EA170
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class Targets
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1EA550
        public void .ctor(){} // RVA: 0x7FFAFC1EA760 | overloaded x2
        public void GetTargets(){} // RVA: 0x7FFAFC1EA820
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class TbsCertificateList
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1EBB30 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1EBCE0
        public void get_Version(){} // RVA: 0x7FFAFC1EB740
        public void get_VersionNumber(){} // RVA: 0x7FFAF2D907C0
        public void get_Signature(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Issuer(){} // RVA: 0x7FFAF2DBB130
        public void get_ThisUpdate(){} // RVA: 0x7FFAF30E74D0
        public void get_NextUpdate(){} // RVA: 0x7FFAF2F476A0
        public void GetRevokedCertificates(){} // RVA: 0x7FFAFC1EC350
        public void GetRevokedCertificateEnumeration(){} // RVA: 0x7FFAFC1EC510
        public void get_Extensions(){} // RVA: 0x7FFAF2E08730
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class TbsCertificateStructure
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1EABA0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1EAC80
        public void get_Version(){} // RVA: 0x7FFAFC1EB740
        public void get_VersionNumber(){} // RVA: 0x7FFAF2D907C0
        public void get_SerialNumber(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Signature(){} // RVA: 0x7FFAF2DBB130
        public void get_Issuer(){} // RVA: 0x7FFAF30E74D0
        public void get_StartDate(){} // RVA: 0x7FFAF2F476A0
        public void get_EndDate(){} // RVA: 0x7FFAF2E0A740
        public void get_Subject(){} // RVA: 0x7FFAF2E08730
        public void get_SubjectPublicKeyInfo(){} // RVA: 0x7FFAF2E2E0E0
        public void get_IssuerUniqueID(){} // RVA: 0x7FFAF2E55500
        public void get_SubjectUniqueID(){} // RVA: 0x7FFAF2E2B370
        public void get_Extensions(){} // RVA: 0x7FFAF2E08D50
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class Time
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1ECCA0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1EC9D0 | overloaded x2
        public void GetTime(){} // RVA: 0x7FFAFC1ECEF0
        public void ToDateTime(){} // RVA: 0x7FFAFC1ED010
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
        public void ToString(){} // RVA: 0x7FFAFC1ED220
    }

    public class UserNotice
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1ED350 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC1ED690
        public void get_NoticeRef(){} // RVA: 0x7FFAF2DA8380
        public void get_ExplicitText(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1ED770
    }

    public class V1TbsCertificateGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1ED950
        public void SetSerialNumber(){} // RVA: 0x7FFAF2DF3E80
        public void SetSignature(){} // RVA: 0x7FFAF2DBB0D0
        public void SetIssuer(){} // RVA: 0x7FFAF2D8EE90
        public void SetStartDate(){} // RVA: 0x7FFAFC1EDA80 | overloaded x2
        public void SetEndDate(){} // RVA: 0x7FFAFC1EDB40 | overloaded x2
        public void SetSubject(){} // RVA: 0x7FFAF2DB5200
        public void SetSubjectPublicKeyInfo(){} // RVA: 0x7FFAF2E08740
        public void GenerateTbsCertificate(){} // RVA: 0x7FFAFC1EDC00
    }

    public class V2AttributeCertificateInfoGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1EDFA0
        public void SetHolder(){} // RVA: 0x7FFAF2DF3E80
        public void AddAttribute(){} // RVA: 0x7FFAFC1EE1D0 | overloaded x2
        public void SetSerialNumber(){} // RVA: 0x7FFAF2DBB890
        public void SetSignature(){} // RVA: 0x7FFAF2D8EE90
        public void SetIssuer(){} // RVA: 0x7FFAF2DBB0D0
        public void SetStartDate(){} // RVA: 0x7FFAF2EE54D0
        public void SetEndDate(){} // RVA: 0x7FFAF2E55510
        public void SetIssuerUniqueID(){} // RVA: 0x7FFAF2DB5200
        public void SetExtensions(){} // RVA: 0x7FFAF2E08740
        public void GenerateAttributeCertificateInfo(){} // RVA: 0x7FFAFC1EE1F0
    }

    public class V2Form
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1EE610 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1EE750 | overloaded x5
        public void get_IssuerName(){} // RVA: 0x7FFAF2DA8380
        public void get_BaseCertificateID(){} // RVA: 0x7FFAF2D907C0
        public void get_ObjectDigestInfo(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1EEA40
    }

    public class V2TbsCertListGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1EECB0
        public void SetSignature(){} // RVA: 0x7FFAF2DF3E80
        public void SetIssuer(){} // RVA: 0x7FFAF2DBB0D0
        public void SetThisUpdate(){} // RVA: 0x7FFAF2D8EE90 | overloaded x2
        public void SetNextUpdate(){} // RVA: 0x7FFAF2DBB890 | overloaded x2
        public void AddCrlEntry(){} // RVA: 0x7FFAFC1EF750 | overloaded x5
        public void SetExtensions(){} // RVA: 0x7FFAF2F4B830
        public void GenerateTbsCertList(){} // RVA: 0x7FFAFC1EF970
    }

    public class V3TbsCertificateGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1F0020
        public void SetSerialNumber(){} // RVA: 0x7FFAF2DF3E80
        public void SetSignature(){} // RVA: 0x7FFAF2DBB0D0
        public void SetIssuer(){} // RVA: 0x7FFAF2D8EE90
        public void SetStartDate(){} // RVA: 0x7FFAF2DBB890 | overloaded x2
        public void SetEndDate(){} // RVA: 0x7FFAF2F4B830 | overloaded x2
        public void SetSubject(){} // RVA: 0x7FFAF2DB5200
        public void SetIssuerUniqueID(){} // RVA: 0x7FFAF2E2B380
        public void SetSubjectUniqueID(){} // RVA: 0x7FFAF2E08D60
        public void SetSubjectPublicKeyInfo(){} // RVA: 0x7FFAF2E08740
        public void SetExtensions(){} // RVA: 0x7FFAFC1F02D0
        public void GenerateTbsCertificate(){} // RVA: 0x7FFAFC1F03B0
    }

    public class X509Attributes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC1F0890
    }

    public class X509CertificateStructure
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1F0990 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1F0BA0 | overloaded x2
        public void get_TbsCertificate(){} // RVA: 0x7FFAF2DA8380
        public void get_Version(){} // RVA: 0x7FFAFC1D6AE0
        public void get_SerialNumber(){} // RVA: 0x7FFAF35DE530
        public void get_Issuer(){} // RVA: 0x7FFAF35DEE60
        public void get_StartDate(){} // RVA: 0x7FFAF35DE770
        public void get_EndDate(){} // RVA: 0x7FFAF35DE230
        public void get_Subject(){} // RVA: 0x7FFAF39F0150
        public void get_SubjectPublicKeyInfo(){} // RVA: 0x7FFAF39EED00
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAF2D907C0
        public void get_Signature(){} // RVA: 0x7FFAF2DBB0C0
        public void GetSignatureOctets(){} // RVA: 0x7FFAF91D5860
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1F0DF0
    }

    public class X509DefaultEntryConverter
    {
        // ── Methods ──
        public void GetConvertedValue(){} // RVA: 0x7FFAFC1F0F50
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class X509Extension
    {
        public object ExtensionOids;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86557A0 | overloaded x2
        public void get_IsCritical(){} // RVA: 0x7FFAF2E575E0
        public void get_Value(){} // RVA: 0x7FFAF2D907C0
        public void GetParsedValue(){} // RVA: 0x7FFAFC1F15C0
        public void GetHashCode(){} // RVA: 0x7FFAFC1F15D0
        public void Equals(){} // RVA: 0x7FFAFC1F1610
        public void ConvertValueToObject(){} // RVA: 0x7FFAFC1F16E0
    }

    public class X509Extensions
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC1F1810 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1F32F0 | overloaded x7
        public void Oids(){} // RVA: 0x7FFAFC1F37D0
        public void get_ExtensionOids(){} // RVA: 0x7FFAFC1F3830
        public void GetExtension(){} // RVA: 0x7FFAFC1F3920
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1F39D0
        public void Equivalent(){} // RVA: 0x7FFAFC1F3FC0
        public void GetExtensionOids(){} // RVA: 0x7FFAFC1F43A0 | overloaded x2
        public void GetNonCriticalExtensionOids(){} // RVA: 0x7FFAFC1F4380
        public void GetCriticalExtensionOids(){} // RVA: 0x7FFAFC1F4390
        public void ToOidArray(){} // RVA: 0x7FFAFC1F4820
        public void .cctor(){} // RVA: 0x7FFAFC1F48C0
    }

    public class X509ExtensionsGenerator
    {
        public object DefaultReverse;

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAFC1F5D30
        public void AddExtension(){} // RVA: 0x7FFAFC1F5FD0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAFC1F6270
        public void Generate(){} // RVA: 0x7FFAFC1F62D0
        public void .ctor(){} // RVA: 0x7FFAFC1F6340
    }

    public class X509Name
    {
        // ── Methods ──
        public void get_DefaultReverse(){} // RVA: 0x7FFAFC1F64D0
        public void set_DefaultReverse(){} // RVA: 0x7FFAFC1F6550
        public void .cctor(){} // RVA: 0x7FFAFC1F65D0
        public void GetInstance(){} // RVA: 0x7FFAFC1F9570 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC1FB3C0 | overloaded x12
        public void DecodeOid(){} // RVA: 0x7FFAFC1FB1C0
        public void GetOidList(){} // RVA: 0x7FFAFC1FBE00
        public void GetValueList(){} // RVA: 0x7FFAFC1FBEB0 | overloaded x2
        public void ToAsn1Object(){} // RVA: 0x7FFAFC1FC160
        public void Equivalent(){} // RVA: 0x7FFAFC1FCB80 | overloaded x2
        public void equivalentStrings(){} // RVA: 0x7FFAFC1FCF70
        public void canonicalize(){} // RVA: 0x7FFAFC1FD0A0
        public void decodeObject(){} // RVA: 0x7FFAFC1FD240
        public void stripInternalSpaces(){} // RVA: 0x7FFAFC1FD370
        public void AppendValue(){} // RVA: 0x7FFAFC1FD490
        public void ToString(){} // RVA: 0x7FFAFC1FDD30 | overloaded x2
    }

    public class X509NameEntryConverter
    {
        // ── Methods ──
        public void ConvertHexEncoded(){} // RVA: 0x7FFAFC1FDDA0
        public void CanBePrintable(){} // RVA: 0x7FFAFC1FDE30
        public void GetConvertedValue(){} // RVA: 0x7FFAF2ACE6A0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class X509NameTokenizer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1FDE50 | overloaded x2
        public void HasMoreTokens(){} // RVA: 0x7FFAFC1FDF70
        public void NextToken(){} // RVA: 0x7FFAFC1FDFA0
    }

    public class X509ObjectIdentifiers
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC1FE1A0
    }

}