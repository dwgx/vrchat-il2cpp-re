// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509
// Classes: 71
// Methods: 452

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509
{
    public class AccessDescription : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B155A330
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_AccessMethod(){} // RVA: 0x7A80F2570
        public void get_AccessLocation(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B155A6D0
        public void ToString(){} // RVA: 0x7B155A7E0
        public void .cctor(){} // RVA: 0x7B155A850
    }

    public class AlgorithmIdentifier : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B155AA00
        public void .ctor(){} // RVA: 0x7B155ABA0
        public void get_Algorithm(){} // RVA: 0x7A80F2570
        public void get_ObjectID(){} // RVA: 0x7A80F2570
        public void get_Parameters(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B155ADE0
    }

    public class AttCertIssuer : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B155B320
        public void .ctor(){} // RVA: 0x7B155B460
        public void get_Issuer(){} // RVA: 0x7A80F2570
        public void ToAsn1Object(){} // RVA: 0x7A80DA7B0
    }

    public class AttCertValidityPeriod : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B155B760
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_NotBeforeTime(){} // RVA: 0x7A80F2570
        public void get_NotAfterTime(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B155B940
    }

    public class AttributeCertificate : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B155BF20
        public void .ctor(){} // RVA: 0x7B155C000
        public void get_ACInfo(){} // RVA: 0x7A80F2570
        public void get_SignatureAlgorithm(){} // RVA: 0x7A80DA7B0
        public void get_SignatureValue(){} // RVA: 0x7A81052C0
        public void GetSignatureOctets(){} // RVA: 0x7AE513D50
        public void ToAsn1Object(){} // RVA: 0x7B155C270
    }

    public class AttributeCertificateInfo : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B155C3F0
        public void .ctor(){} // RVA: 0x7B155C5D0
        public void get_Version(){} // RVA: 0x7A80F2570
        public void get_Holder(){} // RVA: 0x7A80DA7B0
        public void get_Issuer(){} // RVA: 0x7A81052C0
        public void get_Signature(){} // RVA: 0x7A8105330
        public void get_SerialNumber(){} // RVA: 0x7A83F69F0
        public void get_AttrCertValidityPeriod(){} // RVA: 0x7A8292C30
        public void get_Attributes(){} // RVA: 0x7A8154D80
        public void get_IssuerUniqueID(){} // RVA: 0x7A8152D80
        public void get_Extensions(){} // RVA: 0x7A8178B90
        public void ToAsn1Object(){} // RVA: 0x7B155CB90
    }

    public class AttributeTable : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B155D2C0
        public void Get(){} // RVA: 0x7B155D500
        public void ToHashtable(){} // RVA: 0x7B155D5B0
        public void ToDictionary(){} // RVA: 0x7B155D620
    }

    public class AttributeX509 : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B155BA50
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_AttrType(){} // RVA: 0x7A80F2570
        public void GetAttributeValues(){} // RVA: 0x7ADAB0050
        public void get_AttrValues(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B155BE10
    }

    public class AuthorityInformationAccess : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B155D680
        public void .ctor(){} // RVA: 0x7B155DCA0
        public void GetAccessDescriptions(){} // RVA: 0x7B155DE80
        public void ToAsn1Object(){} // RVA: 0x7B155DF00
        public void ToString(){} // RVA: 0x7B155DF60
    }

    public class AuthorityKeyIdentifier : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B155E110
        public void .ctor(){} // RVA: 0x7B155F040
        public void GetKeyIdentifier(){} // RVA: 0x7B155F350
        public void get_AuthorityCertIssuer(){} // RVA: 0x7A80DA7B0
        public void get_AuthorityCertSerialNumber(){} // RVA: 0x7B155F380
        public void ToAsn1Object(){} // RVA: 0x7B155F3A0
        public void ToString(){} // RVA: 0x7B155F5C0
    }

    public class BasicConstraints : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B155F680
        public void .ctor(){} // RVA: 0x7B155FC20
        public void IsCA(){} // RVA: 0x7B155FD80
        public void get_PathLenConstraint(){} // RVA: 0x7B155FDA0
        public void ToAsn1Object(){} // RVA: 0x7B155FDC0
        public void ToString(){} // RVA: 0x7B155FFA0
    }

    public class CertPolicyID : DerObjectIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1561680
    }

    public class CertificateList : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15601A0
        public void .ctor(){} // RVA: 0x7B1560280
        public void get_TbsCertList(){} // RVA: 0x7A80F2570
        public void GetRevokedCertificates(){} // RVA: 0x7B15604D0
        public void GetRevokedCertificateEnumeration(){} // RVA: 0x7B15604F0
        public void get_SignatureAlgorithm(){} // RVA: 0x7A80DA7B0
        public void get_Signature(){} // RVA: 0x7A81052C0
        public void GetSignatureOctets(){} // RVA: 0x7AE513D50
        public void get_Version(){} // RVA: 0x7B15605F0
        public void get_Issuer(){} // RVA: 0x7A88F3AF0
        public void get_ThisUpdate(){} // RVA: 0x7A88F42F0
        public void get_NextUpdate(){} // RVA: 0x7A88F3B10
        public void ToAsn1Object(){} // RVA: 0x7B1560660
    }

    public class CertificatePair : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15607C0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void ToAsn1Object(){} // RVA: 0x7B1560CA0
        public void get_Forward(){} // RVA: 0x7A80F2570
        public void get_Reverse(){} // RVA: 0x7A80DA7B0
    }

    public class CertificatePolicies : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1561010
        public void .ctor(){} // RVA: 0x7B15611E0
        public void GetPolicyInformation(){} // RVA: 0x7B15613D0
        public void ToAsn1Object(){} // RVA: 0x7B1561450
        public void ToString(){} // RVA: 0x7B15614B0
    }

    public class CrlDistPoint : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1561700
        public void .ctor(){} // RVA: 0x7B1561910
        public void GetDistributionPoints(){} // RVA: 0x7B15619D0
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
        public void ToString(){} // RVA: 0x7B1561B80
    }

    public class CrlEntry : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15754D0
        public void get_UserCertificate(){} // RVA: 0x7A80DA7B0
        public void get_RevocationDate(){} // RVA: 0x7A81052C0
        public void get_Extensions(){} // RVA: 0x7B1575710
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class CrlNumber : DerInteger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1515CE0
        public void get_Number(){} // RVA: 0x7B1561D20
        public void ToString(){} // RVA: 0x7B1561D30
    }

    public class CrlReason : DerEnumerated
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1561E00
        public void ToString(){} // RVA: 0x7B1561EB0
        public void .cctor(){} // RVA: 0x7B1561FB0
    }

    public class DigestInfo : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1562230
        public void .ctor(){} // RVA: 0x7B1562410
        public void get_AlgorithmID(){} // RVA: 0x7A80DA7B0
        public void GetDigest(){} // RVA: 0x7A80F2570
        public void ToAsn1Object(){} // RVA: 0x7B15625D0
    }

    public class DisplayText : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A813E420
        public void GetInstance(){} // RVA: 0x7B1562F60
        public void ToAsn1Object(){} // RVA: 0x7B1563160
        public void GetString(){} // RVA: 0x7B15631E0
    }

    public class DistributionPoint : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1563250
        public void .ctor(){} // RVA: 0x7A81B7C50
        public void get_DistributionPointName(){} // RVA: 0x7A80F2570
        public void get_Reasons(){} // RVA: 0x7A80DA7B0
        public void get_CrlIssuer(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B15635D0
        public void ToString(){} // RVA: 0x7B1563870
        public void appendObject(){} // RVA: 0x7B1563A90
    }

    public class DistributionPointName : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1563BD0
        public void .ctor(){} // RVA: 0x7B1563EF0
        public void get_PointType(){} // RVA: 0x7A83782A0
        public void get_Name(){} // RVA: 0x7A80F2570
        public void ToAsn1Object(){} // RVA: 0x7B1564000
        public void ToString(){} // RVA: 0x7B1564080
        public void appendObject(){} // RVA: 0x7B1564230
    }

    public class DsaParameter : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1564340
        public void .ctor(){} // RVA: 0x7B1564890
        public void get_P(){} // RVA: 0x7B1564AD0
        public void get_Q(){} // RVA: 0x7B1564AF0
        public void get_G(){} // RVA: 0x7B1564B10
        public void ToAsn1Object(){} // RVA: 0x7B1564B30
    }

    public class ExtendedKeyUsage : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1564CB0
        public void .ctor(){} // RVA: 0x7B15654C0
        public void HasKeyPurposeId(){} // RVA: 0x7B15659D0
        public void GetUsages(){} // RVA: 0x7B1565A30
        public void GetAllUsages(){} // RVA: 0x7B1565AC0
        public void get_Count(){} // RVA: 0x7B1565B90
        public void ToAsn1Object(){} // RVA: 0x7A80DA7B0
    }

    public class GeneralName : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1565CB0
        public void GetInstance(){} // RVA: 0x7B1566520
        public void get_TagNo(){} // RVA: 0x7A83782A0
        public void get_Name(){} // RVA: 0x7A80F2570
        public void ToString(){} // RVA: 0x7B1566570
        public void toGeneralNameEncoding(){} // RVA: 0x7B1566700
        public void parseIPv4Mask(){} // RVA: 0x7B1566B90
        public void parseIPv4(){} // RVA: 0x7B1566C20
        public void parseMask(){} // RVA: 0x7B1566E80
        public void copyInts(){} // RVA: 0x7B1566F30
        public void parseIPv6(){} // RVA: 0x7B1566FB0
        public void ToAsn1Object(){} // RVA: 0x7B15674C0
    }

    public class GeneralNames : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1567720
        public void .ctor(){} // RVA: 0x7B1567930
        public void GetNames(){} // RVA: 0x7B1567B20
        public void ToAsn1Object(){} // RVA: 0x7B1567BA0
        public void ToString(){} // RVA: 0x7B1567C00
    }

    public class GeneralSubtree : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15683A0
        public void GetInstance(){} // RVA: 0x7B15684A0
        public void get_Base(){} // RVA: 0x7A80F2570
        public void get_Minimum(){} // RVA: 0x7B1568580
        public void get_Maximum(){} // RVA: 0x7B155F380
        public void ToAsn1Object(){} // RVA: 0x7B1568600
    }

    public class Holder : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1568850
        public void .ctor(){} // RVA: 0x7B1569150
        public void get_Version(){} // RVA: 0x7A854FDE0
        public void get_BaseCertificateID(){} // RVA: 0x7A80F2570
        public void get_EntityName(){} // RVA: 0x7A80DA7B0
        public void get_ObjectDigestInfo(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B15691C0
    }

    public class IetfAttrSyntax : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1569470
        public void get_PolicyAuthority(){} // RVA: 0x7A80F2570
        public void get_ValueType(){} // RVA: 0x7A851DB90
        public void GetValues(){} // RVA: 0x7B1569B00
        public void ToAsn1Object(){} // RVA: 0x7B156A020
    }

    public class IssuerSerial : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B156A490
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_Issuer(){} // RVA: 0x7A80F2570
        public void get_Serial(){} // RVA: 0x7A80DA7B0
        public void get_IssuerUid(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B156A770
    }

    public class IssuingDistributionPoint : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B156A9E0
        public void .ctor(){} // RVA: 0x7B156B130
        public void get_OnlyContainsUserCerts(){} // RVA: 0x7A80F26D0
        public void get_OnlyContainsCACerts(){} // RVA: 0x7A8475E20
        public void get_IsIndirectCrl(){} // RVA: 0x7A84A5BD0
        public void get_OnlyContainsAttributeCerts(){} // RVA: 0x7A89FCA90
        public void get_DistributionPoint(){} // RVA: 0x7A80F2570
        public void get_OnlySomeReasons(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7A83F69F0
        public void ToString(){} // RVA: 0x7B156B490
        public void appendObject(){} // RVA: 0x7B156B8A0
    }

    public class KeyPurposeID : DerObjectIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B156B990
        public void .cctor(){} // RVA: 0x7B156B9F0
    }

    public class KeyUsage : DerBitString
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B156C4D0
        public void .ctor(){} // RVA: 0x7B156C730
        public void ToString(){} // RVA: 0x7B156C7E0
    }

    public class NameConstraints : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B156C9D0
        public void .ctor(){} // RVA: 0x7B156CE00
        public void CreateSequence(){} // RVA: 0x7B156CEF0
        public void get_PermittedSubtrees(){} // RVA: 0x7A80F2570
        public void get_ExcludedSubtrees(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B156D220
    }

    public class NoticeReference : Asn1Encodable
    {
        // ── Methods ──
        public void ConvertVector(){} // RVA: 0x7B156D3D0
        public void .ctor(){} // RVA: 0x7B156DAF0
        public void GetInstance(){} // RVA: 0x7B156DCC0
        public void get_Organization(){} // RVA: 0x7A80F2570
        public void GetNoticeNumbers(){} // RVA: 0x7B156DDA0
        public void ToAsn1Object(){} // RVA: 0x7B156DF50
    }

    public class ObjectDigestInfo : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B156E230
        public void .ctor(){} // RVA: 0x7B156E480
        public void get_DigestedObjectType(){} // RVA: 0x7A80F2570
        public void get_OtherObjectTypeID(){} // RVA: 0x7A80DA7B0
        public void get_DigestAlgorithm(){} // RVA: 0x7A81052C0
        public void get_ObjectDigest(){} // RVA: 0x7A8105330
        public void ToAsn1Object(){} // RVA: 0x7B156E7C0
    }

    public class PolicyInformation : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void GetInstance(){} // RVA: 0x7B156EC60
        public void get_PolicyIdentifier(){} // RVA: 0x7A80F2570
        public void get_PolicyQualifiers(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B156ED30
    }

    public class PolicyMappings : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B156EF50
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class PolicyQualifierID : DerObjectIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B156F5B0
        public void .cctor(){} // RVA: 0x7B156F610
    }

    public class PolicyQualifierInfo : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B156F9F0
        public void GetInstance(){} // RVA: 0x7B156FBF0
        public void get_PolicyQualifierId(){} // RVA: 0x7A80F2570
        public void get_Qualifier(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B156FCD0
    }

    public class PrivateKeyUsagePeriod : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B156FDE0
        public void .ctor(){} // RVA: 0x7B1570040
        public void get_NotBefore(){} // RVA: 0x7A80F2570
        public void get_NotAfter(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15702A0
    }

    public class ReasonFlags : DerBitString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15704B0
    }

    public class RoleSyntax : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1570560
        public void .ctor(){} // RVA: 0x7B1570B60
        public void get_RoleAuthority(){} // RVA: 0x7A80F2570
        public void get_RoleName(){} // RVA: 0x7A80DA7B0
        public void GetRoleNameAsString(){} // RVA: 0x7B1570D90
        public void GetRoleAuthorityAsString(){} // RVA: 0x7B1570E40
        public void ToAsn1Object(){} // RVA: 0x7B1570FF0
        public void ToString(){} // RVA: 0x7B1571200
    }

    public class RsaPublicKeyStructure : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15714F0
        public void .ctor(){} // RVA: 0x7B1571850
        public void get_Modulus(){} // RVA: 0x7A80F2570
        public void get_PublicExponent(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1571A30
    }

    public class SubjectDirectoryAttributes : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1571CF0
        public void .ctor(){} // RVA: 0x7B15721F0
        public void ToAsn1Object(){} // RVA: 0x7B15722E0
        public void get_Attributes(){} // RVA: 0x7B1572650
    }

    public class SubjectKeyIdentifier : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1572760
        public void .ctor(){} // RVA: 0x7B1572B80
        public void GetKeyIdentifier(){} // RVA: 0x7A80F2570
        public void ToAsn1Object(){} // RVA: 0x7B1572BF0
        public void CreateSha1KeyIdentifier(){} // RVA: 0x7B1572CE0
        public void CreateTruncatedSha1KeyIdentifier(){} // RVA: 0x7B1572D40
        public void GetDigest(){} // RVA: 0x7B1572E70
    }

    public class SubjectPublicKeyInfo : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1572FB0
        public void .ctor(){} // RVA: 0x7B15732F0
        public void get_AlgorithmID(){} // RVA: 0x7A80F2570
        public void ParsePublicKey(){} // RVA: 0x7B1573500
        public void GetPublicKey(){} // RVA: 0x7B1573500
        public void get_PublicKeyData(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1573540
    }

    public class Target : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1573650
        public void .ctor(){} // RVA: 0x7B1573A20
        public void get_TargetGroup(){} // RVA: 0x7A80DA7B0
        public void get_TargetName(){} // RVA: 0x7A80F2570
        public void ToAsn1Object(){} // RVA: 0x7B1573AE0
    }

    public class TargetInformation : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1573C70
        public void .ctor(){} // RVA: 0x7B15740F0
        public void GetTargetsObjects(){} // RVA: 0x7B1573E80
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class Targets : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1574270
        public void .ctor(){} // RVA: 0x7B1574480
        public void GetTargets(){} // RVA: 0x7B1574540
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class TbsCertificateList : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1575850
        public void .ctor(){} // RVA: 0x7B15759F0
        public void get_Version(){} // RVA: 0x7B1575460
        public void get_VersionNumber(){} // RVA: 0x7A80DA7B0
        public void get_Signature(){} // RVA: 0x7A81052C0
        public void get_Issuer(){} // RVA: 0x7A8105330
        public void get_ThisUpdate(){} // RVA: 0x7A83F69F0
        public void get_NextUpdate(){} // RVA: 0x7A8292C30
        public void GetRevokedCertificates(){} // RVA: 0x7B1576060
        public void GetRevokedCertificateEnumeration(){} // RVA: 0x7B1576230
        public void get_Extensions(){} // RVA: 0x7A8152D80
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class TbsCertificateStructure : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15748C0
        public void .ctor(){} // RVA: 0x7B15749A0
        public void get_Version(){} // RVA: 0x7B1575460
        public void get_VersionNumber(){} // RVA: 0x7A80DA7B0
        public void get_SerialNumber(){} // RVA: 0x7A81052C0
        public void get_Signature(){} // RVA: 0x7A8105330
        public void get_Issuer(){} // RVA: 0x7A83F69F0
        public void get_StartDate(){} // RVA: 0x7A8292C30
        public void get_EndDate(){} // RVA: 0x7A8154D80
        public void get_Subject(){} // RVA: 0x7A8152D80
        public void get_SubjectPublicKeyInfo(){} // RVA: 0x7A8178B90
        public void get_IssuerUniqueID(){} // RVA: 0x7A81A0050
        public void get_SubjectUniqueID(){} // RVA: 0x7A8175DF0
        public void get_Extensions(){} // RVA: 0x7A8153390
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class Time : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15769C0
        public void .ctor(){} // RVA: 0x7B15766F0
        public void GetTime(){} // RVA: 0x7B1576C10
        public void ToDateTime(){} // RVA: 0x7B1576D20
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
        public void ToString(){} // RVA: 0x7B1576F00
    }

    public class UserNotice : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1577030
        public void GetInstance(){} // RVA: 0x7B1577370
        public void get_NoticeRef(){} // RVA: 0x7A80F2570
        public void get_ExplicitText(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1577450
    }

    public class V1TbsCertificateGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1577630
        public void SetSerialNumber(){} // RVA: 0x7A813E420
        public void SetSignature(){} // RVA: 0x7A81052D0
        public void SetIssuer(){} // RVA: 0x7A80D8E80
        public void SetStartDate(){} // RVA: 0x7B1577760
        public void SetEndDate(){} // RVA: 0x7B1577820
        public void SetSubject(){} // RVA: 0x7A80FF440
        public void SetSubjectPublicKeyInfo(){} // RVA: 0x7A8152D90
        public void GenerateTbsCertificate(){} // RVA: 0x7B15778E0
    }

    public class V2AttributeCertificateInfoGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1577C80
        public void SetHolder(){} // RVA: 0x7A813E420
        public void AddAttribute(){} // RVA: 0x7B1577EB0
        public void SetSerialNumber(){} // RVA: 0x7A8105A90
        public void SetSignature(){} // RVA: 0x7A80D8E80
        public void SetIssuer(){} // RVA: 0x7A81052D0
        public void SetStartDate(){} // RVA: 0x7A8230620
        public void SetEndDate(){} // RVA: 0x7A81A0060
        public void SetIssuerUniqueID(){} // RVA: 0x7A80FF440
        public void SetExtensions(){} // RVA: 0x7A8152D90
        public void GenerateAttributeCertificateInfo(){} // RVA: 0x7B1577ED0
    }

    public class V2Form : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15782F0
        public void .ctor(){} // RVA: 0x7B1578430
        public void get_IssuerName(){} // RVA: 0x7A80F2570
        public void get_BaseCertificateID(){} // RVA: 0x7A80DA7B0
        public void get_ObjectDigestInfo(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B1578720
    }

    public class V2TbsCertListGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1578990
        public void SetSignature(){} // RVA: 0x7A813E420
        public void SetIssuer(){} // RVA: 0x7A81052D0
        public void SetThisUpdate(){} // RVA: 0x7A80D8E80
        public void SetNextUpdate(){} // RVA: 0x7A8105A90
        public void AddCrlEntry(){} // RVA: 0x7B1579430
        public void SetExtensions(){} // RVA: 0x7A8296DE0
        public void GenerateTbsCertList(){} // RVA: 0x7B1579670
    }

    public class V3TbsCertificateGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1579D40
        public void SetSerialNumber(){} // RVA: 0x7A813E420
        public void SetSignature(){} // RVA: 0x7A81052D0
        public void SetIssuer(){} // RVA: 0x7A80D8E80
        public void SetStartDate(){} // RVA: 0x7A8105A90
        public void SetEndDate(){} // RVA: 0x7A8296DE0
        public void SetSubject(){} // RVA: 0x7A80FF440
        public void SetIssuerUniqueID(){} // RVA: 0x7A8175E00
        public void SetSubjectUniqueID(){} // RVA: 0x7A81533A0
        public void SetSubjectPublicKeyInfo(){} // RVA: 0x7A8152D90
        public void SetExtensions(){} // RVA: 0x7B1579FF0
        public void GenerateTbsCertificate(){} // RVA: 0x7B157A0D0
    }

    public class X509Attributes : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B157A5B0
    }

    public class X509CertificateStructure : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B157A6B0
        public void .ctor(){} // RVA: 0x7B157A8C0
        public void get_TbsCertificate(){} // RVA: 0x7A80F2570
        public void get_Version(){} // RVA: 0x7B15605F0
        public void get_SerialNumber(){} // RVA: 0x7A88F38D0
        public void get_Issuer(){} // RVA: 0x7A88F42F0
        public void get_StartDate(){} // RVA: 0x7A88F3B10
        public void get_EndDate(){} // RVA: 0x7A88F35D0
        public void get_Subject(){} // RVA: 0x7A8D0A960
        public void get_SubjectPublicKeyInfo(){} // RVA: 0x7A8D094E0
        public void get_SignatureAlgorithm(){} // RVA: 0x7A80DA7B0
        public void get_Signature(){} // RVA: 0x7A81052C0
        public void GetSignatureOctets(){} // RVA: 0x7AE513D50
        public void ToAsn1Object(){} // RVA: 0x7B157AB10
    }

    public class X509CertificateStructure[] : Array
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

    public class X509DefaultEntryConverter : X509NameEntryConverter
    {
        // ── Methods ──
        public void GetConvertedValue(){} // RVA: 0x7B157AC70
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class X509Extension : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD993240
        public void get_IsCritical(){} // RVA: 0x7A81A2200
        public void get_Value(){} // RVA: 0x7A80DA7B0
        public void GetParsedValue(){} // RVA: 0x7B157B390
        public void GetHashCode(){} // RVA: 0x7B157B3A0
        public void Equals(){} // RVA: 0x7B157B3E0
        public void ConvertValueToObject(){} // RVA: 0x7B157B490
    }

    public class X509Extensions : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B157B5C0
        public void .ctor(){} // RVA: 0x7B157D060
        public void Oids(){} // RVA: 0x7B157D530
        public void get_ExtensionOids(){} // RVA: 0x7B157D590
        public void GetExtension(){} // RVA: 0x7B157D680
        public void ToAsn1Object(){} // RVA: 0x7B157D730
        public void Equivalent(){} // RVA: 0x7B157DD20
        public void GetExtensionOids(){} // RVA: 0x7B157E0F0
        public void GetNonCriticalExtensionOids(){} // RVA: 0x7B157E0D0
        public void GetCriticalExtensionOids(){} // RVA: 0x7B157E0E0
        public void ToOidArray(){} // RVA: 0x7B157E570
        public void .cctor(){} // RVA: 0x7B157E610
    }

    public class X509ExtensionsGenerator : Object
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7B157FA80
        public void AddExtension(){} // RVA: 0x7B157FD20
        public void get_IsEmpty(){} // RVA: 0x7B157FFE0
        public void Generate(){} // RVA: 0x7B1580040
        public void .ctor(){} // RVA: 0x7B15800B0
    }

    public class X509Name : Asn1Encodable
    {
        // ── Methods ──
        public void get_DefaultReverse(){} // RVA: 0x7B1580240
        public void set_DefaultReverse(){} // RVA: 0x7B15802C0
        public void .cctor(){} // RVA: 0x7B1580340
        public void GetInstance(){} // RVA: 0x7B15832E0
        public void .ctor(){} // RVA: 0x7B1585110
        public void DecodeOid(){} // RVA: 0x7B1584F10
        public void GetOidList(){} // RVA: 0x7B1585B50
        public void GetValueList(){} // RVA: 0x7B1585C00
        public void ToAsn1Object(){} // RVA: 0x7B1585EB0
        public void Equivalent(){} // RVA: 0x7B1586850
        public void equivalentStrings(){} // RVA: 0x7B1586C50
        public void canonicalize(){} // RVA: 0x7B1586D80
        public void decodeObject(){} // RVA: 0x7B1586F20
        public void stripInternalSpaces(){} // RVA: 0x7B1587050
        public void AppendValue(){} // RVA: 0x7B1587170
        public void ToString(){} // RVA: 0x7B1587A10
    }

    public class X509NameEntryConverter : Object
    {
        // ── Methods ──
        public void ConvertHexEncoded(){} // RVA: 0x7B1587A80
        public void CanBePrintable(){} // RVA: 0x7B1587B10
        public void GetConvertedValue(){} // RVA: 0x7A7E00BD0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class X509NameTokenizer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1587B30
        public void HasMoreTokens(){} // RVA: 0x7B1587C50
        public void NextToken(){} // RVA: 0x7B1587C80
    }

    public class X509ObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B1587E80
    }

}