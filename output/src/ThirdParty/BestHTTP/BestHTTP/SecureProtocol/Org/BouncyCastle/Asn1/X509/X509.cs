// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509
// Classes: 70
// Methods: 588

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509
{
    public class AccessDescription
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdADCAIssuers;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdADOcsp; // 0x8

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9720810
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void get_AccessMethod(){} // RVA: 0x2F8380
        public void get_AccessLocation(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9720BB0
        public void ToString(){} // RVA: 0x9720CC0
        public void .cctor(){} // RVA: 0x9720D30
    }

    public class AlgorithmIdentifier
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable parameters; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9720EE0 | overloaded x2
        public void .ctor(){} // RVA: 0x9721080 | overloaded x4
        public void get_Algorithm(){} // RVA: 0x2F8380
        public void get_ObjectID(){} // RVA: 0x2F8380
        public void get_Parameters(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97212C0
    }

    public class AttCertIssuer : GetInstance
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable obj; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9721800 | overloaded x2
        public void .ctor(){} // RVA: 0x9721940 | overloaded x2
        public void get_Issuer(){} // RVA: 0x2F8380
        public void ToAsn1Object(){} // RVA: 0x2E07C0
    }

    public class AttCertValidityPeriod
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime notBeforeTime; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime notAfterTime; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9721C40 | overloaded x2
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void get_NotBeforeTime(){} // RVA: 0x2F8380
        public void get_NotAfterTime(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9721E20
    }

    public class AttributeCertificate
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AttributeCertificateInfo acinfo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signatureAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString signatureValue; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9722400
        public void .ctor(){} // RVA: 0x97224E0 | overloaded x2
        public void get_ACInfo(){} // RVA: 0x2F8380
        public void get_SignatureAlgorithm(){} // RVA: 0x2E07C0
        public void get_SignatureValue(){} // RVA: 0x30B0C0
        public void GetSignatureOctets(){} // RVA: 0x6725860
        public void ToAsn1Object(){} // RVA: 0x9722750
    }

    public class AttributeCertificateInfo
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Holder holder; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AttCertIssuer issuer; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signature; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger serialNumber; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AttCertValidityPeriod attrCertValidityPeriod; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence attributes; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString issuerUniqueID; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions extensions; // 0x50

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97228D0 | overloaded x2
        public void .ctor(){} // RVA: 0x9722AB0
        public void get_Version(){} // RVA: 0x2F8380
        public void get_Holder(){} // RVA: 0x2E07C0
        public void get_Issuer(){} // RVA: 0x30B0C0
        public void get_Signature(){} // RVA: 0x30B130
        public void get_SerialNumber(){} // RVA: 0x6374D0
        public void get_AttrCertValidityPeriod(){} // RVA: 0x4976A0
        public void get_Attributes(){} // RVA: 0x35A740
        public void get_IssuerUniqueID(){} // RVA: 0x358730
        public void get_Extensions(){} // RVA: 0x37E0E0
        public void ToAsn1Object(){} // RVA: 0x9723070
    }

    public class AttributeTable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97237A0 | overloaded x4
        public void Get(){} // RVA: 0x97239E0
        public void ToHashtable(){} // RVA: 0x9723A90
        public void ToDictionary(){} // RVA: 0x9723B00
    }

    public class AttributeX509
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier attrType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set attrValues; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9721F30
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void get_AttrType(){} // RVA: 0x2F8380
        public void GetAttributeValues(){} // RVA: 0x5CC1EA0
        public void get_AttrValues(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97222F0
    }

    public class AuthorityInformationAccess
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9723B60
        public void .ctor(){} // RVA: 0x9724160 | overloaded x3
        public void GetAccessDescriptions(){} // RVA: 0x9724340
        public void ToAsn1Object(){} // RVA: 0x97243C0
        public void ToString(){} // RVA: 0x9724420
    }

    public class AuthorityKeyIdentifier
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString keyidentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralNames certissuer; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97245E0 | overloaded x2
        public void .ctor(){} // RVA: 0x9725530 | overloaded x6
        public void GetKeyIdentifier(){} // RVA: 0x9725830
        public void get_AuthorityCertIssuer(){} // RVA: 0x2E07C0
        public void get_AuthorityCertSerialNumber(){} // RVA: 0x9725860
        public void ToAsn1Object(){} // RVA: 0x9725880
        public void ToString(){} // RVA: 0x9725AA0
    }

    public class BasicConstraints
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBoolean cA; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9725B60 | overloaded x2
        public void .ctor(){} // RVA: 0x9726110 | overloaded x3
        public void IsCA(){} // RVA: 0x9726270
        public void get_PathLenConstraint(){} // RVA: 0x9726290
        public void ToAsn1Object(){} // RVA: 0x97262B0
        public void ToString(){} // RVA: 0x9726490
    }

    public class CertPolicyID
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9727B60
    }

    public class CertificateList
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.TbsCertificateList tbsCertList; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString sig; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9726690 | overloaded x2
        public void .ctor(){} // RVA: 0x9726770
        public void get_TbsCertList(){} // RVA: 0x2F8380
        public void GetRevokedCertificates(){} // RVA: 0x97269C0
        public void GetRevokedCertificateEnumeration(){} // RVA: 0x97269E0
        public void get_SignatureAlgorithm(){} // RVA: 0x2E07C0
        public void get_Signature(){} // RVA: 0x30B0C0
        public void GetSignatureOctets(){} // RVA: 0x6725860
        public void get_Version(){} // RVA: 0x9726AE0
        public void get_Issuer(){} // RVA: 0xB2E750
        public void get_ThisUpdate(){} // RVA: 0xB2EE60
        public void get_NextUpdate(){} // RVA: 0xB2E770
        public void ToAsn1Object(){} // RVA: 0x9726B50
    }

    public class CertificatePair
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509CertificateStructure forward; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509CertificateStructure reverse; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9726CB0
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void ToAsn1Object(){} // RVA: 0x97271B0
        public void get_Forward(){} // RVA: 0x2F8380
        public void get_Reverse(){} // RVA: 0x2E07C0
    }

    public class CertificatePolicies
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9727510 | overloaded x2
        public void .ctor(){} // RVA: 0x97276E0 | overloaded x3
        public void GetPolicyInformation(){} // RVA: 0x97278C0
        public void ToAsn1Object(){} // RVA: 0x9727940
        public void ToString(){} // RVA: 0x97279A0
    }

    public class CrlDistPoint
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9727BE0 | overloaded x2
        public void .ctor(){} // RVA: 0x9727DF0 | overloaded x2
        public void GetDistributionPoints(){} // RVA: 0x9727EB0
        public void ToAsn1Object(){} // RVA: 0x2F8380
        public void ToString(){} // RVA: 0x9728050
    }

    public class CrlEntry
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence seq; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger userCertificate; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time revocationDate; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x973B7B0
        public void get_UserCertificate(){} // RVA: 0x2E07C0
        public void get_RevocationDate(){} // RVA: 0x30B0C0
        public void get_Extensions(){} // RVA: 0x973B9F0
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class CrlNumber
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96DC200
        public void get_Number(){} // RVA: 0x97281E0
        public void ToString(){} // RVA: 0x97281F0
    }

    public class CrlReason
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97282C0 | overloaded x2
        public void ToString(){} // RVA: 0x9728370
        public void .cctor(){} // RVA: 0x9728470
    }

    public class DigestInfo
    {
        public byte[] digest; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97286F0 | overloaded x2
        public void .ctor(){} // RVA: 0x97288D0 | overloaded x2
        public void get_AlgorithmID(){} // RVA: 0x2E07C0
        public void GetDigest(){} // RVA: 0x2F8380
        public void ToAsn1Object(){} // RVA: 0x9728A90
    }

    public class DisplayText : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x343E80 | overloaded x3
        public void GetInstance(){} // RVA: 0x9729420
        public void ToAsn1Object(){} // RVA: 0x9729620
        public void GetString(){} // RVA: 0x97296A0
    }

    public class DistributionPoint
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.DistributionPointName distributionPoint; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.ReasonFlags reasons; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralNames cRLIssuer; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9729710 | overloaded x2
        public void .ctor(){} // RVA: 0x3BCE00 | overloaded x2
        public void get_DistributionPointName(){} // RVA: 0x2F8380
        public void get_Reasons(){} // RVA: 0x2E07C0
        public void get_CrlIssuer(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x9729A90
        public void ToString(){} // RVA: 0x9729D20
        public void appendObject(){} // RVA: 0x9729F40
    }

    public class DistributionPointName
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable name; // 0x10
        public int type; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x972A080 | overloaded x2
        public void .ctor(){} // RVA: 0x972A3A0 | overloaded x3
        public void get_PointType(){} // RVA: 0x5BED50
        public void get_Name(){} // RVA: 0x2F8380
        public void ToAsn1Object(){} // RVA: 0x972A4B0
        public void ToString(){} // RVA: 0x972A530
        public void appendObject(){} // RVA: 0x972A6E0
    }

    public class DsaParameter
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger p; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger q; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger g; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x972A7F0 | overloaded x2
        public void .ctor(){} // RVA: 0x972AD40 | overloaded x2
        public void get_P(){} // RVA: 0x972AF80
        public void get_Q(){} // RVA: 0x972AFA0
        public void get_G(){} // RVA: 0x972AFC0
        public void ToAsn1Object(){} // RVA: 0x972AFE0
    }

    public class ExtendedKeyUsage
    {
        public System.Collections.IDictionary usageTable; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x972B160 | overloaded x2
        public void .ctor(){} // RVA: 0x972B980 | overloaded x4
        public void HasKeyPurposeId(){} // RVA: 0x972BE90
        public void GetUsages(){} // RVA: 0x972BEF0
        public void GetAllUsages(){} // RVA: 0x972BF80
        public void get_Count(){} // RVA: 0x972C050
        public void ToAsn1Object(){} // RVA: 0x2E07C0
    }

    public class GeneralName
    {
        public int OtherName;
        public int Rfc822Name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x972C170 | overloaded x4
        public void GetInstance(){} // RVA: 0x972C980 | overloaded x2
        public void get_TagNo(){} // RVA: 0x5BED50
        public void get_Name(){} // RVA: 0x2F8380
        public void ToString(){} // RVA: 0x972C9D0
        public void toGeneralNameEncoding(){} // RVA: 0x972CB60
        public void parseIPv4Mask(){} // RVA: 0x972CFF0
        public void parseIPv4(){} // RVA: 0x972D080
        public void parseMask(){} // RVA: 0x972D2C0
        public void copyInts(){} // RVA: 0x972D370
        public void parseIPv6(){} // RVA: 0x972D3F0
        public void ToAsn1Object(){} // RVA: 0x972D8A0
    }

    public class GeneralNames
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x972DB00 | overloaded x2
        public void .ctor(){} // RVA: 0x972DD10 | overloaded x3
        public void GetNames(){} // RVA: 0x972DEF0
        public void ToAsn1Object(){} // RVA: 0x972DF70
        public void ToString(){} // RVA: 0x972DFD0
    }

    public class GeneralSubtree
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName baseName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger minimum; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger maximum; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x972E770 | overloaded x3
        public void GetInstance(){} // RVA: 0x972E870 | overloaded x2
        public void get_Base(){} // RVA: 0x2F8380
        public void get_Minimum(){} // RVA: 0x972E950
        public void get_Maximum(){} // RVA: 0x9725860
        public void ToAsn1Object(){} // RVA: 0x972E9D0
    }

    public class Holder
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.IssuerSerial baseCertificateID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralNames entityName; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.ObjectDigestInfo objectDigestInfo; // 0x20
        public int version; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x972EC10
        public void .ctor(){} // RVA: 0x972F510 | overloaded x7
        public void get_Version(){} // RVA: 0x791DC0
        public void get_BaseCertificateID(){} // RVA: 0x2F8380
        public void get_EntityName(){} // RVA: 0x2E07C0
        public void get_ObjectDigestInfo(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x972F580
    }

    public class IetfAttrSyntax
    {
        public int ValueOctets;
        public int ValueOid;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x972F830
        public void get_PolicyAuthority(){} // RVA: 0x2F8380
        public void get_ValueType(){} // RVA: 0x760030
        public void GetValues(){} // RVA: 0x972FEE0
        public void ToAsn1Object(){} // RVA: 0x97303F0
    }

    public class IssuerSerial
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralNames issuer; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger serial; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString issuerUid; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9730840 | overloaded x2
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void get_Issuer(){} // RVA: 0x2F8380
        public void get_Serial(){} // RVA: 0x2E07C0
        public void get_IssuerUid(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x9730B20
    }

    public class IssuingDistributionPoint
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.DistributionPointName _distributionPoint; // 0x10
        public bool _onlyContainsUserCerts; // 0x18
        public bool _onlyContainsCACerts; // 0x19
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.ReasonFlags _onlySomeReasons; // 0x20
        public bool _indirectCRL; // 0x28
        public bool _onlyContainsAttributeCerts; // 0x29

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9730D80 | overloaded x2
        public void .ctor(){} // RVA: 0x97314D0 | overloaded x2
        public void get_OnlyContainsUserCerts(){} // RVA: 0x2F84E0
        public void get_OnlyContainsCACerts(){} // RVA: 0x6B93D0
        public void get_IsIndirectCrl(){} // RVA: 0x6E8A80
        public void get_OnlyContainsAttributeCerts(){} // RVA: 0xC36000
        public void get_DistributionPoint(){} // RVA: 0x2F8380
        public void get_OnlySomeReasons(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x6374D0
        public void ToString(){} // RVA: 0x9731830
        public void appendObject(){} // RVA: 0x9731C40
    }

    public class KeyPurposeID
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9731D30
        public void .cctor(){} // RVA: 0x9731D90
    }

    public class KeyUsage
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9732870
        public void .ctor(){} // RVA: 0x9732AD0 | overloaded x2
        public void ToString(){} // RVA: 0x9732B80
    }

    public class NameConstraints
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence permitted; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence excluded; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9732CE0
        public void .ctor(){} // RVA: 0x9733120 | overloaded x3
        public void CreateSequence(){} // RVA: 0x9733210
        public void get_PermittedSubtrees(){} // RVA: 0x2F8380
        public void get_ExcludedSubtrees(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9733540
    }

    public class NoticeReference
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.DisplayText organization; // 0x10

        // ── Methods ──
        public void ConvertVector(){} // RVA: 0x97336F0
        public void .ctor(){} // RVA: 0x9733E20 | overloaded x4
        public void GetInstance(){} // RVA: 0x9733FF0
        public void get_Organization(){} // RVA: 0x2F8380
        public void GetNoticeNumbers(){} // RVA: 0x97340D0
        public void ToAsn1Object(){} // RVA: 0x9734270
    }

    public class ObjectDigestInfo
    {
        public int PublicKey;
        public int PublicKeyCert;
        public int OtherObjectDigest;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerEnumerated digestedObjectType; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9734550 | overloaded x2
        public void .ctor(){} // RVA: 0x97347A0 | overloaded x2
        public void get_DigestedObjectType(){} // RVA: 0x2F8380
        public void get_OtherObjectTypeID(){} // RVA: 0x2E07C0
        public void get_DigestAlgorithm(){} // RVA: 0x30B0C0
        public void get_ObjectDigest(){} // RVA: 0x30B130
        public void ToAsn1Object(){} // RVA: 0x9734AE0
    }

    public class PolicyInformation
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier policyIdentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence policyQualifiers; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x3
        public void GetInstance(){} // RVA: 0x9734F80
        public void get_PolicyIdentifier(){} // RVA: 0x2F8380
        public void get_PolicyQualifiers(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9735050
    }

    public class PolicyMappings
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9735260 | overloaded x3
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class PolicyQualifierID
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97358C0
        public void .cctor(){} // RVA: 0x9735920
    }

    public class PolicyQualifierInfo
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier policyQualifierId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable qualifier; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9735D00 | overloaded x3
        public void GetInstance(){} // RVA: 0x9735F00
        public void get_PolicyQualifierId(){} // RVA: 0x2F8380
        public void get_Qualifier(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9735FE0
    }

    public class PrivateKeyUsagePeriod
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime _notBefore; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime _notAfter; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97360F0
        public void .ctor(){} // RVA: 0x9736350
        public void get_NotBefore(){} // RVA: 0x2F8380
        public void get_NotAfter(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97365C0
    }

    public class ReasonFlags
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97367D0 | overloaded x2
    }

    public class RoleSyntax
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralNames roleAuthority; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName roleName; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9736880
        public void .ctor(){} // RVA: 0x9736E80 | overloaded x4
        public void get_RoleAuthority(){} // RVA: 0x2F8380
        public void get_RoleName(){} // RVA: 0x2E07C0
        public void GetRoleNameAsString(){} // RVA: 0x97370B0
        public void GetRoleAuthorityAsString(){} // RVA: 0x9737160
        public void ToAsn1Object(){} // RVA: 0x9737300
        public void ToString(){} // RVA: 0x9737510
    }

    public class RsaPublicKeyStructure
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger modulus; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger publicExponent; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97377F0 | overloaded x2
        public void .ctor(){} // RVA: 0x9737B50 | overloaded x2
        public void get_Modulus(){} // RVA: 0x2F8380
        public void get_PublicExponent(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9737D30
    }

    public class SubjectDirectoryAttributes
    {
        public System.Collections.IList attributes; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9737FD0
        public void .ctor(){} // RVA: 0x97384E0 | overloaded x3
        public void ToAsn1Object(){} // RVA: 0x97385D0
        public void get_Attributes(){} // RVA: 0x9738940
    }

    public class SubjectKeyIdentifier
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9738A50 | overloaded x2
        public void .ctor(){} // RVA: 0x9738E70 | overloaded x3
        public void GetKeyIdentifier(){} // RVA: 0x2F8380
        public void ToAsn1Object(){} // RVA: 0x9738EE0
        public void CreateSha1KeyIdentifier(){} // RVA: 0x9738FD0
        public void CreateTruncatedSha1KeyIdentifier(){} // RVA: 0x9739030
        public void GetDigest(){} // RVA: 0x9739160
    }

    public class SubjectPublicKeyInfo
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString keyData; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97392A0 | overloaded x2
        public void .ctor(){} // RVA: 0x97395E0 | overloaded x3
        public void get_AlgorithmID(){} // RVA: 0x2F8380
        public void ParsePublicKey(){} // RVA: 0x97397F0
        public void GetPublicKey(){} // RVA: 0x97397F0
        public void get_PublicKeyData(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9739830
    }

    public class Target : GetInstance
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName targetName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName targetGroup; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9739940
        public void .ctor(){} // RVA: 0x9739D10 | overloaded x2
        public void get_TargetGroup(){} // RVA: 0x2E07C0
        public void get_TargetName(){} // RVA: 0x2F8380
        public void ToAsn1Object(){} // RVA: 0x9739DD0
    }

    public class TargetInformation
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9739F60
        public void .ctor(){} // RVA: 0x973A3D0 | overloaded x3
        public void GetTargetsObjects(){} // RVA: 0x973A170
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class Targets
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x973A550
        public void .ctor(){} // RVA: 0x973A760 | overloaded x2
        public void GetTargets(){} // RVA: 0x973A820
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class TbsCertificateList
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence seq; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signature; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name issuer; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time thisUpdate; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time nextUpdate; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence revokedCertificates; // 0x40

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x973BB30 | overloaded x2
        public void .ctor(){} // RVA: 0x973BCE0
        public void get_Version(){} // RVA: 0x973B740
        public void get_VersionNumber(){} // RVA: 0x2E07C0
        public void get_Signature(){} // RVA: 0x30B0C0
        public void get_Issuer(){} // RVA: 0x30B130
        public void get_ThisUpdate(){} // RVA: 0x6374D0
        public void get_NextUpdate(){} // RVA: 0x4976A0
        public void GetRevokedCertificates(){} // RVA: 0x973C350
        public void GetRevokedCertificateEnumeration(){} // RVA: 0x973C510
        public void get_Extensions(){} // RVA: 0x358730
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class TbsCertificateStructure
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence seq; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger serialNumber; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signature; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name issuer; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time startDate; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time endDate; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name subject; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo subjectPublicKeyInfo; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString issuerUniqueID; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString subjectUniqueID; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions extensions; // 0x68

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x973ABA0 | overloaded x2
        public void .ctor(){} // RVA: 0x973AC80
        public void get_Version(){} // RVA: 0x973B740
        public void get_VersionNumber(){} // RVA: 0x2E07C0
        public void get_SerialNumber(){} // RVA: 0x30B0C0
        public void get_Signature(){} // RVA: 0x30B130
        public void get_Issuer(){} // RVA: 0x6374D0
        public void get_StartDate(){} // RVA: 0x4976A0
        public void get_EndDate(){} // RVA: 0x35A740
        public void get_Subject(){} // RVA: 0x358730
        public void get_SubjectPublicKeyInfo(){} // RVA: 0x37E0E0
        public void get_IssuerUniqueID(){} // RVA: 0x3A5500
        public void get_SubjectUniqueID(){} // RVA: 0x37B370
        public void get_Extensions(){} // RVA: 0x358D50
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class Time
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x973CCA0 | overloaded x2
        public void .ctor(){} // RVA: 0x973C9D0 | overloaded x2
        public void GetTime(){} // RVA: 0x973CEF0
        public void ToDateTime(){} // RVA: 0x973D010
        public void ToAsn1Object(){} // RVA: 0x2F8380
        public void ToString(){} // RVA: 0x973D220
    }

    public class UserNotice
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.NoticeReference noticeRef; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.DisplayText explicitText; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x973D350 | overloaded x3
        public void GetInstance(){} // RVA: 0x973D690
        public void get_NoticeRef(){} // RVA: 0x2F8380
        public void get_ExplicitText(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x973D770
    }

    public class V1TbsCertificateGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x973D950
        public void SetSerialNumber(){} // RVA: 0x343E80
        public void SetSignature(){} // RVA: 0x30B0D0
        public void SetIssuer(){} // RVA: 0x2DEE90
        public void SetStartDate(){} // RVA: 0x973DA80 | overloaded x2
        public void SetEndDate(){} // RVA: 0x973DB40 | overloaded x2
        public void SetSubject(){} // RVA: 0x305200
        public void SetSubjectPublicKeyInfo(){} // RVA: 0x358740
        public void GenerateTbsCertificate(){} // RVA: 0x973DC00
    }

    public class V2AttributeCertificateInfoGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x973DFA0
        public void SetHolder(){} // RVA: 0x343E80
        public void AddAttribute(){} // RVA: 0x973E1D0 | overloaded x2
        public void SetSerialNumber(){} // RVA: 0x30B890
        public void SetSignature(){} // RVA: 0x2DEE90
        public void SetIssuer(){} // RVA: 0x30B0D0
        public void SetStartDate(){} // RVA: 0x4354D0
        public void SetEndDate(){} // RVA: 0x3A5510
        public void SetIssuerUniqueID(){} // RVA: 0x305200
        public void SetExtensions(){} // RVA: 0x358740
        public void GenerateAttributeCertificateInfo(){} // RVA: 0x973E1F0
    }

    public class V2Form
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralNames issuerName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.IssuerSerial baseCertificateID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.ObjectDigestInfo objectDigestInfo; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x973E610 | overloaded x2
        public void .ctor(){} // RVA: 0x973E750 | overloaded x5
        public void get_IssuerName(){} // RVA: 0x2F8380
        public void get_BaseCertificateID(){} // RVA: 0x2E07C0
        public void get_ObjectDigestInfo(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x973EA40
    }

    public class V2TbsCertListGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x973ECB0
        public void SetSignature(){} // RVA: 0x343E80
        public void SetIssuer(){} // RVA: 0x30B0D0
        public void SetThisUpdate(){} // RVA: 0x2DEE90 | overloaded x2
        public void SetNextUpdate(){} // RVA: 0x30B890 | overloaded x2
        public void AddCrlEntry(){} // RVA: 0x973F750 | overloaded x5
        public void SetExtensions(){} // RVA: 0x49B830
        public void GenerateTbsCertList(){} // RVA: 0x973F970
    }

    public class V3TbsCertificateGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9740020
        public void SetSerialNumber(){} // RVA: 0x343E80
        public void SetSignature(){} // RVA: 0x30B0D0
        public void SetIssuer(){} // RVA: 0x2DEE90
        public void SetStartDate(){} // RVA: 0x30B890 | overloaded x2
        public void SetEndDate(){} // RVA: 0x49B830 | overloaded x2
        public void SetSubject(){} // RVA: 0x305200
        public void SetIssuerUniqueID(){} // RVA: 0x37B380
        public void SetSubjectUniqueID(){} // RVA: 0x358D60
        public void SetSubjectPublicKeyInfo(){} // RVA: 0x358740
        public void SetExtensions(){} // RVA: 0x97402D0
        public void GenerateTbsCertificate(){} // RVA: 0x97403B0
    }

    public class X509Attributes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9740890
    }

    public class X509CertificateStructure
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.TbsCertificateStructure tbsCert; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString sig; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9740990 | overloaded x2
        public void .ctor(){} // RVA: 0x9740BA0 | overloaded x2
        public void get_TbsCertificate(){} // RVA: 0x2F8380
        public void get_Version(){} // RVA: 0x9726AE0
        public void get_SerialNumber(){} // RVA: 0xB2E530
        public void get_Issuer(){} // RVA: 0xB2EE60
        public void get_StartDate(){} // RVA: 0xB2E770
        public void get_EndDate(){} // RVA: 0xB2E230
        public void get_Subject(){} // RVA: 0xF40150
        public void get_SubjectPublicKeyInfo(){} // RVA: 0xF3ED00
        public void get_SignatureAlgorithm(){} // RVA: 0x2E07C0
        public void get_Signature(){} // RVA: 0x30B0C0
        public void GetSignatureOctets(){} // RVA: 0x6725860
        public void ToAsn1Object(){} // RVA: 0x9740DF0
    }

    public class X509DefaultEntryConverter
    {
        // ── Methods ──
        public void GetConvertedValue(){} // RVA: 0x9740F50
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class X509Extension
    {
        public bool ExtensionOids; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BA57A0 | overloaded x2
        public void get_IsCritical(){} // RVA: 0x3A75E0
        public void get_Value(){} // RVA: 0x2E07C0
        public void GetParsedValue(){} // RVA: 0x97415C0
        public void GetHashCode(){} // RVA: 0x97415D0
        public void Equals(){} // RVA: 0x9741610
        public void ConvertValueToObject(){} // RVA: 0x97416E0
    }

    public class X509Extensions
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SubjectDirectoryAttributes;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9741810 | overloaded x2
        public void .ctor(){} // RVA: 0x97432F0 | overloaded x7
        public void Oids(){} // RVA: 0x97437D0
        public void get_ExtensionOids(){} // RVA: 0x9743830
        public void GetExtension(){} // RVA: 0x9743920
        public void ToAsn1Object(){} // RVA: 0x97439D0
        public void Equivalent(){} // RVA: 0x9743FC0
        public void GetExtensionOids(){} // RVA: 0x97443A0 | overloaded x2
        public void GetNonCriticalExtensionOids(){} // RVA: 0x9744380
        public void GetCriticalExtensionOids(){} // RVA: 0x9744390
        public void ToOidArray(){} // RVA: 0x9744820
        public void .cctor(){} // RVA: 0x97448C0
    }

    public class X509ExtensionsGenerator
    {
        public System.Collections.IDictionary DefaultReverse; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x9745D30
        public void AddExtension(){} // RVA: 0x9745FD0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x9746270
        public void Generate(){} // RVA: 0x97462D0
        public void .ctor(){} // RVA: 0x9746340
    }

    public class X509Name
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C;

        // ── Methods ──
        public void get_DefaultReverse(){} // RVA: 0x97464D0
        public void set_DefaultReverse(){} // RVA: 0x9746550
        public void .cctor(){} // RVA: 0x97465D0
        public void GetInstance(){} // RVA: 0x9749570 | overloaded x2
        public void .ctor(){} // RVA: 0x974B3C0 | overloaded x12
        public void DecodeOid(){} // RVA: 0x974B1C0
        public void GetOidList(){} // RVA: 0x974BE00
        public void GetValueList(){} // RVA: 0x974BEB0 | overloaded x2
        public void ToAsn1Object(){} // RVA: 0x974C160
        public void Equivalent(){} // RVA: 0x974CB80 | overloaded x2
        public void equivalentStrings(){} // RVA: 0x974CF70
        public void canonicalize(){} // RVA: 0x974D0A0
        public void decodeObject(){} // RVA: 0x974D240
        public void stripInternalSpaces(){} // RVA: 0x974D370
        public void AppendValue(){} // RVA: 0x974D490
        public void ToString(){} // RVA: 0x974DD30 | overloaded x2
    }

    public class X509NameEntryConverter
    {
        // ── Methods ──
        public void ConvertHexEncoded(){} // RVA: 0x974DDA0
        public void CanBePrintable(){} // RVA: 0x974DE30
        public void GetConvertedValue(){} // RVA: 0x1E6A0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class X509NameTokenizer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x974DE50 | overloaded x2
        public void HasMoreTokens(){} // RVA: 0x974DF70
        public void NextToken(){} // RVA: 0x974DFA0
    }

    public class X509ObjectIdentifiers
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x974E1A0
    }

}