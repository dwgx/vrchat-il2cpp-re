// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509
// Classes: 70
// Methods: 588

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509
{
    public class AccessDescription : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdADCAIssuers;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdADOcsp; // 0x8

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A182C10
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void get_AccessMethod(){} // RVA: 0x7FFE81116380
        public void get_AccessLocation(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A182FB0
        public void ToString(){} // RVA: 0x7FFE8A1830C0
        public void .cctor(){} // RVA: 0x7FFE8A183130
    }

    public class AlgorithmIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable parameters; // 0x18
        public object field_2; // 0x6B7

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1832E0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A183480 | overloaded x4
        public void get_Algorithm(){} // RVA: 0x7FFE81116380
        public void get_ObjectID(){} // RVA: 0x7FFE81116380
        public void get_Parameters(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1836C0
    }

    public class AttCertIssuer : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable obj; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A183C00 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A183D40 | overloaded x2
        public void get_Issuer(){} // RVA: 0x7FFE81116380
        public void ToAsn1Object(){} // RVA: 0x7FFE810FE7C0
    }

    public class AttCertValidityPeriod : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime notBeforeTime; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime notAfterTime; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A184040 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void get_NotBeforeTime(){} // RVA: 0x7FFE81116380
        public void get_NotAfterTime(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A184220
    }

    public class AttributeCertificate : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AttributeCertificateInfo acinfo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signatureAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString signatureValue; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A184800
        public void .ctor(){} // RVA: 0x7FFE8A1848E0 | overloaded x2
        public void get_ACInfo(){} // RVA: 0x7FFE81116380
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFE810FE7C0
        public void get_SignatureValue(){} // RVA: 0x7FFE811290C0
        public void GetSignatureOctets(){} // RVA: 0x7FFE87264760
        public void ToAsn1Object(){} // RVA: 0x7FFE8A184B50
    }

    public class AttributeCertificateInfo : Asn1Encodable
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
        public void GetInstance(){} // RVA: 0x7FFE8A184CD0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A184EB0
        public void get_Version(){} // RVA: 0x7FFE81116380
        public void get_Holder(){} // RVA: 0x7FFE810FE7C0
        public void get_Issuer(){} // RVA: 0x7FFE811290C0
        public void get_Signature(){} // RVA: 0x7FFE81129130
        public void get_SerialNumber(){} // RVA: 0x7FFE8144E200
        public void get_AttrCertValidityPeriod(){} // RVA: 0x7FFE8143BA80
        public void get_Attributes(){} // RVA: 0x7FFE81178740
        public void get_IssuerUniqueID(){} // RVA: 0x7FFE81176730
        public void get_Extensions(){} // RVA: 0x7FFE8119C0E0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A185470
    }

    public class AttributeTable : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A185BA0 | overloaded x4
        public void Get(){} // RVA: 0x7FFE8A185DE0
        public void ToHashtable(){} // RVA: 0x7FFE8A185E90
        public void ToDictionary(){} // RVA: 0x7FFE8A185F00
    }

    public class AttributeX509 : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier attrType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set attrValues; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A184330
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void get_AttrType(){} // RVA: 0x7FFE81116380
        public void GetAttributeValues(){} // RVA: 0x7FFE86802DA0
        public void get_AttrValues(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1846F0
    }

    public class AuthorityInformationAccess : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A185F60
        public void .ctor(){} // RVA: 0x7FFE8A186560 | overloaded x3
        public void GetAccessDescriptions(){} // RVA: 0x7FFE8A186740
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1867C0
        public void ToString(){} // RVA: 0x7FFE8A186820
    }

    public class AuthorityKeyIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString keyidentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralNames certissuer; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1869E0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A187930 | overloaded x6
        public void GetKeyIdentifier(){} // RVA: 0x7FFE8A187C30
        public void get_AuthorityCertIssuer(){} // RVA: 0x7FFE810FE7C0
        public void get_AuthorityCertSerialNumber(){} // RVA: 0x7FFE8A187C60
        public void ToAsn1Object(){} // RVA: 0x7FFE8A187C80
        public void ToString(){} // RVA: 0x7FFE8A187EA0
    }

    public class BasicConstraints : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBoolean cA; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A187F60 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A188510 | overloaded x3
        public void IsCA(){} // RVA: 0x7FFE8A188670
        public void get_PathLenConstraint(){} // RVA: 0x7FFE8A188690
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1886B0
        public void ToString(){} // RVA: 0x7FFE8A188890
    }

    public class CertPolicyID : DerObjectIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A189F60
    }

    public class CertificateList : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.TbsCertificateList tbsCertList; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString sig; // 0x20
        public object field_3; // 0x6CE
        public object field_4; // 0x6CF
        public object field_5; // 0x6D0
        public object field_6; // 0x6D1

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A188A90 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A188B70
        public void get_TbsCertList(){} // RVA: 0x7FFE81116380
        public void GetRevokedCertificates(){} // RVA: 0x7FFE8A188DC0
        public void GetRevokedCertificateEnumeration(){} // RVA: 0x7FFE8A188DE0
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFE810FE7C0
        public void get_Signature(){} // RVA: 0x7FFE811290C0
        public void GetSignatureOctets(){} // RVA: 0x7FFE87264760
        public void get_Version(){} // RVA: 0x7FFE8A188EE0
        public void get_Issuer(){} // RVA: 0x7FFE8189B9F0
        public void get_ThisUpdate(){} // RVA: 0x7FFE8189BF90
        public void get_NextUpdate(){} // RVA: 0x7FFE8189C060
        public void ToAsn1Object(){} // RVA: 0x7FFE8A188F50
    }

    public class CertificatePair : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509CertificateStructure forward; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509CertificateStructure reverse; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1890B0
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1895B0
        public void get_Forward(){} // RVA: 0x7FFE81116380
        public void get_Reverse(){} // RVA: 0x7FFE810FE7C0
    }

    public class CertificatePolicies : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A189910 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A189AE0 | overloaded x3
        public void GetPolicyInformation(){} // RVA: 0x7FFE8A189CC0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A189D40
        public void ToString(){} // RVA: 0x7FFE8A189DA0
    }

    public class CrlDistPoint : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A189FE0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A18A1F0 | overloaded x2
        public void GetDistributionPoints(){} // RVA: 0x7FFE8A18A2B0
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
        public void ToString(){} // RVA: 0x7FFE8A18A450
    }

    public class CrlEntry : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence seq; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger userCertificate; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time revocationDate; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A19DBB0
        public void get_UserCertificate(){} // RVA: 0x7FFE810FE7C0
        public void get_RevocationDate(){} // RVA: 0x7FFE811290C0
        public void get_Extensions(){} // RVA: 0x7FFE8A19DDF0
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class CrlNumber : DerInteger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A13E5E0
        public void get_Number(){} // RVA: 0x7FFE8A18A5E0
        public void ToString(){} // RVA: 0x7FFE8A18A5F0
    }

    public class CrlReason : DerEnumerated
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A18A6C0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE8A18A770
        public void .cctor(){} // RVA: 0x7FFE8A18A870
    }

    public class DigestInfo : Asn1Encodable
    {
        public byte[] digest; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A18AAF0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A18ACD0 | overloaded x2
        public void get_AlgorithmID(){} // RVA: 0x7FFE810FE7C0
        public void GetDigest(){} // RVA: 0x7FFE81116380
        public void ToAsn1Object(){} // RVA: 0x7FFE8A18AE90
    }

    public class DisplayText : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81161E80 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A18B820
        public void ToAsn1Object(){} // RVA: 0x7FFE8A18BA20
        public void GetString(){} // RVA: 0x7FFE8A18BAA0
    }

    public class DistributionPoint : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.DistributionPointName distributionPoint; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.ReasonFlags reasons; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralNames cRLIssuer; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A18BB10 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE811DAE00 | overloaded x2
        public void get_DistributionPointName(){} // RVA: 0x7FFE81116380
        public void get_Reasons(){} // RVA: 0x7FFE810FE7C0
        public void get_CrlIssuer(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A18BE90
        public void ToString(){} // RVA: 0x7FFE8A18C120
        public void appendObject(){} // RVA: 0x7FFE8A18C340
    }

    public class DistributionPointName : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable name; // 0x10
        public int type; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A18C480 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A18C7A0 | overloaded x3
        public void get_PointType(){} // RVA: 0x7FFE813DB630
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void ToAsn1Object(){} // RVA: 0x7FFE8A18C8B0
        public void ToString(){} // RVA: 0x7FFE8A18C930
        public void appendObject(){} // RVA: 0x7FFE8A18CAE0
    }

    public class DsaParameter : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger p; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger q; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger g; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A18CBF0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A18D140 | overloaded x2
        public void get_P(){} // RVA: 0x7FFE8A18D380
        public void get_Q(){} // RVA: 0x7FFE8A18D3A0
        public void get_G(){} // RVA: 0x7FFE8A18D3C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A18D3E0
    }

    public class ExtendedKeyUsage : Asn1Encodable
    {
        public System.Collections.IDictionary usageTable; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A18D560 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A18DD80 | overloaded x4
        public void HasKeyPurposeId(){} // RVA: 0x7FFE8A18E290
        public void GetUsages(){} // RVA: 0x7FFE8A18E2F0
        public void GetAllUsages(){} // RVA: 0x7FFE8A18E380
        public void get_Count(){} // RVA: 0x7FFE8A18E450
        public void ToAsn1Object(){} // RVA: 0x7FFE810FE7C0
    }

    public class GeneralName : Asn1Encodable
    {
        public int OtherName;
        public int Rfc822Name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A18E570 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFE8A18ED80 | overloaded x2
        public void get_TagNo(){} // RVA: 0x7FFE813DB630
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void ToString(){} // RVA: 0x7FFE8A18EDD0
        public void toGeneralNameEncoding(){} // RVA: 0x7FFE8A18EF60
        public void parseIPv4Mask(){} // RVA: 0x7FFE8A18F3F0
        public void parseIPv4(){} // RVA: 0x7FFE8A18F480
        public void parseMask(){} // RVA: 0x7FFE8A18F6C0
        public void copyInts(){} // RVA: 0x7FFE8A18F770
        public void parseIPv6(){} // RVA: 0x7FFE8A18F7F0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A18FCA0
    }

    public class GeneralNames : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A18FF00 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A190110 | overloaded x3
        public void GetNames(){} // RVA: 0x7FFE8A1902F0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A190370
        public void ToString(){} // RVA: 0x7FFE8A1903D0
    }

    public class GeneralSubtree : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName baseName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger minimum; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger maximum; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A190B70 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A190C70 | overloaded x2
        public void get_Base(){} // RVA: 0x7FFE81116380
        public void get_Minimum(){} // RVA: 0x7FFE8A190D50
        public void get_Maximum(){} // RVA: 0x7FFE8A187C60
        public void ToAsn1Object(){} // RVA: 0x7FFE8A190DD0
    }

    public class Holder : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.IssuerSerial baseCertificateID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralNames entityName; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.ObjectDigestInfo objectDigestInfo; // 0x20
        public int version; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A191010
        public void .ctor(){} // RVA: 0x7FFE8A191910 | overloaded x7
        public void get_Version(){} // RVA: 0x7FFE81549710
        public void get_BaseCertificateID(){} // RVA: 0x7FFE81116380
        public void get_EntityName(){} // RVA: 0x7FFE810FE7C0
        public void get_ObjectDigestInfo(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A191980
    }

    public class IetfAttrSyntax : Asn1Encodable
    {
        public int ValueOctets;
        public int ValueOid;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A191C30
        public void get_PolicyAuthority(){} // RVA: 0x7FFE81116380
        public void get_ValueType(){} // RVA: 0x7FFE8151D690
        public void GetValues(){} // RVA: 0x7FFE8A1922E0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1927F0
    }

    public class IssuerSerial : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralNames issuer; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger serial; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString issuerUid; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A192C40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void get_Issuer(){} // RVA: 0x7FFE81116380
        public void get_Serial(){} // RVA: 0x7FFE810FE7C0
        public void get_IssuerUid(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A192F20
    }

    public class IssuingDistributionPoint : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.DistributionPointName _distributionPoint; // 0x10
        public bool _onlyContainsUserCerts; // 0x18
        public bool _onlyContainsCACerts; // 0x19
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.ReasonFlags _onlySomeReasons; // 0x20
        public bool _indirectCRL; // 0x28
        public bool _onlyContainsAttributeCerts; // 0x29

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A193180 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1938D0 | overloaded x2
        public void get_OnlyContainsUserCerts(){} // RVA: 0x7FFE811164E0
        public void get_OnlyContainsCACerts(){} // RVA: 0x7FFE814B3730
        public void get_IsIndirectCrl(){} // RVA: 0x7FFE815F1380
        public void get_OnlyContainsAttributeCerts(){} // RVA: 0x7FFE819C2EA0
        public void get_DistributionPoint(){} // RVA: 0x7FFE81116380
        public void get_OnlySomeReasons(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8144E200
        public void ToString(){} // RVA: 0x7FFE8A193C30
        public void appendObject(){} // RVA: 0x7FFE8A194040
    }

    public class KeyPurposeID : DerObjectIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A194130
        public void .cctor(){} // RVA: 0x7FFE8A194190
    }

    public class KeyUsage : DerBitString
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A194C70
        public void .ctor(){} // RVA: 0x7FFE8A194ED0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE8A194F80
    }

    public class NameConstraints : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence permitted; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence excluded; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1950E0
        public void .ctor(){} // RVA: 0x7FFE8A195520 | overloaded x3
        public void CreateSequence(){} // RVA: 0x7FFE8A195610
        public void get_PermittedSubtrees(){} // RVA: 0x7FFE81116380
        public void get_ExcludedSubtrees(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A195940
    }

    public class NoticeReference : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.DisplayText organization; // 0x10

        // ── Methods ──
        public void ConvertVector(){} // RVA: 0x7FFE8A195AF0
        public void .ctor(){} // RVA: 0x7FFE8A196220 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFE8A1963F0
        public void get_Organization(){} // RVA: 0x7FFE81116380
        public void GetNoticeNumbers(){} // RVA: 0x7FFE8A1964D0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A196670
    }

    public class ObjectDigestInfo : Asn1Encodable
    {
        public int PublicKey;
        public int PublicKeyCert;
        public int OtherObjectDigest;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerEnumerated digestedObjectType; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A196950 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A196BA0 | overloaded x2
        public void get_DigestedObjectType(){} // RVA: 0x7FFE81116380
        public void get_OtherObjectTypeID(){} // RVA: 0x7FFE810FE7C0
        public void get_DigestAlgorithm(){} // RVA: 0x7FFE811290C0
        public void get_ObjectDigest(){} // RVA: 0x7FFE81129130
        public void ToAsn1Object(){} // RVA: 0x7FFE8A196EE0
    }

    public class PolicyInformation : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier policyIdentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence policyQualifiers; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A197380
        public void get_PolicyIdentifier(){} // RVA: 0x7FFE81116380
        public void get_PolicyQualifiers(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A197450
    }

    public class PolicyMappings : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A197660 | overloaded x3
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class PolicyQualifierID : DerObjectIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A197CC0
        public void .cctor(){} // RVA: 0x7FFE8A197D20
    }

    public class PolicyQualifierInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier policyQualifierId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable qualifier; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A198100 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A198300
        public void get_PolicyQualifierId(){} // RVA: 0x7FFE81116380
        public void get_Qualifier(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1983E0
    }

    public class PrivateKeyUsagePeriod : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime _notBefore; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime _notAfter; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1984F0
        public void .ctor(){} // RVA: 0x7FFE8A198750
        public void get_NotBefore(){} // RVA: 0x7FFE81116380
        public void get_NotAfter(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1989C0
    }

    public class ReasonFlags : DerBitString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A198BD0 | overloaded x2
    }

    public class RoleSyntax : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralNames roleAuthority; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName roleName; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A198C80
        public void .ctor(){} // RVA: 0x7FFE8A199280 | overloaded x4
        public void get_RoleAuthority(){} // RVA: 0x7FFE81116380
        public void get_RoleName(){} // RVA: 0x7FFE810FE7C0
        public void GetRoleNameAsString(){} // RVA: 0x7FFE8A1994B0
        public void GetRoleAuthorityAsString(){} // RVA: 0x7FFE8A199560
        public void ToAsn1Object(){} // RVA: 0x7FFE8A199700
        public void ToString(){} // RVA: 0x7FFE8A199910
    }

    public class RsaPublicKeyStructure : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger modulus; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger publicExponent; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A199BF0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A199F50 | overloaded x2
        public void get_Modulus(){} // RVA: 0x7FFE81116380
        public void get_PublicExponent(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A19A130
    }

    public class SubjectDirectoryAttributes : Asn1Encodable
    {
        public System.Collections.IList attributes; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A19A3D0
        public void .ctor(){} // RVA: 0x7FFE8A19A8E0 | overloaded x3
        public void ToAsn1Object(){} // RVA: 0x7FFE8A19A9D0
        public void get_Attributes(){} // RVA: 0x7FFE8A19AD40
    }

    public class SubjectKeyIdentifier : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A19AE50 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A19B270 | overloaded x3
        public void GetKeyIdentifier(){} // RVA: 0x7FFE81116380
        public void ToAsn1Object(){} // RVA: 0x7FFE8A19B2E0
        public void CreateSha1KeyIdentifier(){} // RVA: 0x7FFE8A19B3D0
        public void CreateTruncatedSha1KeyIdentifier(){} // RVA: 0x7FFE8A19B430
        public void GetDigest(){} // RVA: 0x7FFE8A19B560
    }

    public class SubjectPublicKeyInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString keyData; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A19B6A0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A19B9E0 | overloaded x3
        public void get_AlgorithmID(){} // RVA: 0x7FFE81116380
        public void ParsePublicKey(){} // RVA: 0x7FFE8A19BBF0
        public void GetPublicKey(){} // RVA: 0x7FFE8A19BBF0
        public void get_PublicKeyData(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A19BC30
    }

    public class Target : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName targetName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName targetGroup; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A19BD40
        public void .ctor(){} // RVA: 0x7FFE8A19C110 | overloaded x2
        public void get_TargetGroup(){} // RVA: 0x7FFE810FE7C0
        public void get_TargetName(){} // RVA: 0x7FFE81116380
        public void ToAsn1Object(){} // RVA: 0x7FFE8A19C1D0
    }

    public class TargetInformation : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A19C360
        public void .ctor(){} // RVA: 0x7FFE8A19C7D0 | overloaded x3
        public void GetTargetsObjects(){} // RVA: 0x7FFE8A19C570
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class Targets : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A19C950
        public void .ctor(){} // RVA: 0x7FFE8A19CB60 | overloaded x2
        public void GetTargets(){} // RVA: 0x7FFE8A19CC20
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class TbsCertificateList : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence seq; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signature; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name issuer; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time thisUpdate; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time nextUpdate; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence revokedCertificates; // 0x40

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A19DF30 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A19E0E0
        public void get_Version(){} // RVA: 0x7FFE8A19DB40
        public void get_VersionNumber(){} // RVA: 0x7FFE810FE7C0
        public void get_Signature(){} // RVA: 0x7FFE811290C0
        public void get_Issuer(){} // RVA: 0x7FFE81129130
        public void get_ThisUpdate(){} // RVA: 0x7FFE8144E200
        public void get_NextUpdate(){} // RVA: 0x7FFE8143BA80
        public void GetRevokedCertificates(){} // RVA: 0x7FFE8A19E750
        public void GetRevokedCertificateEnumeration(){} // RVA: 0x7FFE8A19E910
        public void get_Extensions(){} // RVA: 0x7FFE81176730
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class TbsCertificateStructure : Asn1Encodable
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
        public void GetInstance(){} // RVA: 0x7FFE8A19CFA0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A19D080
        public void get_Version(){} // RVA: 0x7FFE8A19DB40
        public void get_VersionNumber(){} // RVA: 0x7FFE810FE7C0
        public void get_SerialNumber(){} // RVA: 0x7FFE811290C0
        public void get_Signature(){} // RVA: 0x7FFE81129130
        public void get_Issuer(){} // RVA: 0x7FFE8144E200
        public void get_StartDate(){} // RVA: 0x7FFE8143BA80
        public void get_EndDate(){} // RVA: 0x7FFE81178740
        public void get_Subject(){} // RVA: 0x7FFE81176730
        public void get_SubjectPublicKeyInfo(){} // RVA: 0x7FFE8119C0E0
        public void get_IssuerUniqueID(){} // RVA: 0x7FFE811C3500
        public void get_SubjectUniqueID(){} // RVA: 0x7FFE81199370
        public void get_Extensions(){} // RVA: 0x7FFE81176D50
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class Time : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A19F0A0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A19EDD0 | overloaded x2
        public void GetTime(){} // RVA: 0x7FFE8A19F2F0
        public void ToDateTime(){} // RVA: 0x7FFE8A19F410
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
        public void ToString(){} // RVA: 0x7FFE8A19F620
    }

    public class UserNotice : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.NoticeReference noticeRef; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.DisplayText explicitText; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A19F750 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A19FA90
        public void get_NoticeRef(){} // RVA: 0x7FFE81116380
        public void get_ExplicitText(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A19FB70
    }

    public class V1TbsCertificateGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A19FD50
        public void SetSerialNumber(){} // RVA: 0x7FFE81161E80
        public void SetSignature(){} // RVA: 0x7FFE811290D0
        public void SetIssuer(){} // RVA: 0x7FFE810FCE90
        public void SetStartDate(){} // RVA: 0x7FFE8A19FE80 | overloaded x2
        public void SetEndDate(){} // RVA: 0x7FFE8A19FF40 | overloaded x2
        public void SetSubject(){} // RVA: 0x7FFE81123200
        public void SetSubjectPublicKeyInfo(){} // RVA: 0x7FFE81176740
        public void GenerateTbsCertificate(){} // RVA: 0x7FFE8A1A0000
    }

    public class V2AttributeCertificateInfoGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1A03A0
        public void SetHolder(){} // RVA: 0x7FFE81161E80
        public void AddAttribute(){} // RVA: 0x7FFE8A1A05D0 | overloaded x2
        public void SetSerialNumber(){} // RVA: 0x7FFE81129890
        public void SetSignature(){} // RVA: 0x7FFE810FCE90
        public void SetIssuer(){} // RVA: 0x7FFE811290D0
        public void SetStartDate(){} // RVA: 0x7FFE812534D0
        public void SetEndDate(){} // RVA: 0x7FFE811C3510
        public void SetIssuerUniqueID(){} // RVA: 0x7FFE81123200
        public void SetExtensions(){} // RVA: 0x7FFE81176740
        public void GenerateAttributeCertificateInfo(){} // RVA: 0x7FFE8A1A05F0
    }

    public class V2Form : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralNames issuerName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.IssuerSerial baseCertificateID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.ObjectDigestInfo objectDigestInfo; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1A0A10 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1A0B50 | overloaded x5
        public void get_IssuerName(){} // RVA: 0x7FFE81116380
        public void get_BaseCertificateID(){} // RVA: 0x7FFE810FE7C0
        public void get_ObjectDigestInfo(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1A0E40
    }

    public class V2TbsCertListGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1A10B0
        public void SetSignature(){} // RVA: 0x7FFE81161E80
        public void SetIssuer(){} // RVA: 0x7FFE811290D0
        public void SetThisUpdate(){} // RVA: 0x7FFE810FCE90 | overloaded x2
        public void SetNextUpdate(){} // RVA: 0x7FFE81129890 | overloaded x2
        public void AddCrlEntry(){} // RVA: 0x7FFE8A1A1B50 | overloaded x5
        public void SetExtensions(){} // RVA: 0x7FFE81437330
        public void GenerateTbsCertList(){} // RVA: 0x7FFE8A1A1D70
    }

    public class V3TbsCertificateGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1A2420
        public void SetSerialNumber(){} // RVA: 0x7FFE81161E80
        public void SetSignature(){} // RVA: 0x7FFE811290D0
        public void SetIssuer(){} // RVA: 0x7FFE810FCE90
        public void SetStartDate(){} // RVA: 0x7FFE81129890 | overloaded x2
        public void SetEndDate(){} // RVA: 0x7FFE81437330 | overloaded x2
        public void SetSubject(){} // RVA: 0x7FFE81123200
        public void SetIssuerUniqueID(){} // RVA: 0x7FFE81199380
        public void SetSubjectUniqueID(){} // RVA: 0x7FFE81176D60
        public void SetSubjectPublicKeyInfo(){} // RVA: 0x7FFE81176740
        public void SetExtensions(){} // RVA: 0x7FFE8A1A26D0
        public void GenerateTbsCertificate(){} // RVA: 0x7FFE8A1A27B0
    }

    public class X509Attributes : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A1A2C90
    }

    public class X509CertificateStructure : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.TbsCertificateStructure tbsCert; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString sig; // 0x20
        public object field_3; // 0x728
        public object field_4; // 0x729
        public object field_5; // 0x72A
        public object field_6; // 0x72B
        public object field_7; // 0x72C
        public object field_8; // 0x72D
        public object field_9; // 0x72E

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1A2D90 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1A2FA0 | overloaded x2
        public void get_TbsCertificate(){} // RVA: 0x7FFE81116380
        public void get_Version(){} // RVA: 0x7FFE8A188EE0
        public void get_SerialNumber(){} // RVA: 0x7FFE8189B810
        public void get_Issuer(){} // RVA: 0x7FFE8189BF90
        public void get_StartDate(){} // RVA: 0x7FFE8189C060
        public void get_EndDate(){} // RVA: 0x7FFE8189B8F0
        public void get_Subject(){} // RVA: 0x7FFE81CCBEC0
        public void get_SubjectPublicKeyInfo(){} // RVA: 0x7FFE87163660
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFE810FE7C0
        public void get_Signature(){} // RVA: 0x7FFE811290C0
        public void GetSignatureOctets(){} // RVA: 0x7FFE87264760
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1A31F0
    }

    public class X509DefaultEntryConverter : X509NameEntryConverter
    {
        // ── Methods ──
        public void GetConvertedValue(){} // RVA: 0x7FFE8A1A3350
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class X509Extension : Object
    {
        public bool critical; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866E65F0 | overloaded x2
        public void get_IsCritical(){} // RVA: 0x7FFE811C55E0
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void GetParsedValue(){} // RVA: 0x7FFE8A1A39C0
        public void GetHashCode(){} // RVA: 0x7FFE8A1A39D0
        public void Equals(){} // RVA: 0x7FFE8A1A3A10
        public void ConvertValueToObject(){} // RVA: 0x7FFE8A1A3AE0
    }

    public class X509Extensions : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SubjectDirectoryAttributes;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1A3C10 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1A56F0 | overloaded x7
        public void Oids(){} // RVA: 0x7FFE8A1A5BD0
        public void get_ExtensionOids(){} // RVA: 0x7FFE8A1A5C30
        public void GetExtension(){} // RVA: 0x7FFE8A1A5D20
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1A5DD0
        public void Equivalent(){} // RVA: 0x7FFE8A1A63C0
        public void GetExtensionOids(){} // RVA: 0x7FFE8A1A67A0 | overloaded x2
        public void GetNonCriticalExtensionOids(){} // RVA: 0x7FFE8A1A6780
        public void GetCriticalExtensionOids(){} // RVA: 0x7FFE8A1A6790
        public void ToOidArray(){} // RVA: 0x7FFE8A1A6C20
        public void .cctor(){} // RVA: 0x7FFE8A1A6CC0
    }

    public class X509ExtensionsGenerator : Object
    {
        public System.Collections.IDictionary extensions; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFE8A1A8130
        public void AddExtension(){} // RVA: 0x7FFE8A1A83D0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFE8A1A8670
        public void Generate(){} // RVA: 0x7FFE8A1A86D0
        public void .ctor(){} // RVA: 0x7FFE8A1A8740
    }

    public class X509Name : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier C;

        // ── Methods ──
        public void get_DefaultReverse(){} // RVA: 0x7FFE8A1A88D0
        public void set_DefaultReverse(){} // RVA: 0x7FFE8A1A8950
        public void .cctor(){} // RVA: 0x7FFE8A1A89D0
        public void GetInstance(){} // RVA: 0x7FFE8A1AB970 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1AD7C0 | overloaded x12
        public void DecodeOid(){} // RVA: 0x7FFE8A1AD5C0
        public void GetOidList(){} // RVA: 0x7FFE8A1AE200
        public void GetValueList(){} // RVA: 0x7FFE8A1AE2B0 | overloaded x2
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1AE560
        public void Equivalent(){} // RVA: 0x7FFE8A1AEF80 | overloaded x2
        public void equivalentStrings(){} // RVA: 0x7FFE8A1AF370
        public void canonicalize(){} // RVA: 0x7FFE8A1AF4A0
        public void decodeObject(){} // RVA: 0x7FFE8A1AF640
        public void stripInternalSpaces(){} // RVA: 0x7FFE8A1AF770
        public void AppendValue(){} // RVA: 0x7FFE8A1AF890
        public void ToString(){} // RVA: 0x7FFE8A1B0130 | overloaded x2
    }

    public class X509NameEntryConverter : Object
    {
        // ── Methods ──
        public void ConvertHexEncoded(){} // RVA: 0x7FFE8A1B01A0
        public void CanBePrintable(){} // RVA: 0x7FFE8A1B0230
        public void GetConvertedValue(){} // RVA: 0x7FFE80E3FC10
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class X509NameTokenizer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1B0250 | overloaded x2
        public void HasMoreTokens(){} // RVA: 0x7FFE8A1B0370
        public void NextToken(){} // RVA: 0x7FFE8A1B03A0
    }

    public class X509ObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A1B05A0
    }

}