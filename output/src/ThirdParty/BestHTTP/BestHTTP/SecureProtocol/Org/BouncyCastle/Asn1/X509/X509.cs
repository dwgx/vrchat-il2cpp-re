// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509
// Classes: 70
// Methods: 588

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509
{
    public class AccessDescription : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier AccessMethod;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier AccessLocation; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier accessMethod; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName accessLocation; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD295F0
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void get_AccessMethod(){} // RVA: 0x7FFAC2F3C380
        public void get_AccessLocation(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD29990
        public void ToString(){} // RVA: 0x7FFACBD29AA0
        public void .cctor(){} // RVA: 0x7FFACBD29B10
    }

    public class AlgorithmIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Algorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable ObjectID; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD29CC0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD29E60 | overloaded x4
        public void get_Algorithm(){} // RVA: 0x7FFAC2F3C380
        public void get_ObjectID(){} // RVA: 0x7FFAC2F3C380
        public void get_Parameters(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD2A0A0
    }

    public class AttCertIssuer : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable Issuer; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object choiceObj; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD2A5E0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD2A720 | overloaded x2
        public void get_Issuer(){} // RVA: 0x7FFAC2F3C380
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F247C0
    }

    public class AttCertValidityPeriod : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime NotBeforeTime; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime NotAfterTime; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD2AA20 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void get_NotBeforeTime(){} // RVA: 0x7FFAC2F3C380
        public void get_NotAfterTime(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD2AC00
    }

    public class AttributeCertificate : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AttributeCertificateInfo ACInfo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier SignatureAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString SignatureValue; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD2B1E0
        public void .ctor(){} // RVA: 0x7FFACBD2B2C0 | overloaded x2
        public void get_ACInfo(){} // RVA: 0x7FFAC2F3C380
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAC2F247C0
        public void get_SignatureValue(){} // RVA: 0x7FFAC2F4F0C0
        public void GetSignatureOctets(){} // RVA: 0x7FFAC8EBC310
        public void ToAsn1Object(){} // RVA: 0x7FFACBD2B530
    }

    public class AttributeCertificateInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Holder Holder; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AttCertIssuer Issuer; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Signature; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger SerialNumber; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AttCertValidityPeriod AttrCertValidityPeriod; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence Attributes; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString IssuerUniqueID; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions Extensions; // 0x50

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD2B6B0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD2B890
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
        public void get_Holder(){} // RVA: 0x7FFAC2F247C0
        public void get_Issuer(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Signature(){} // RVA: 0x7FFAC2F4F130
        public void get_SerialNumber(){} // RVA: 0x7FFAC31D95E0
        public void get_AttrCertValidityPeriod(){} // RVA: 0x7FFAC31D0140
        public void get_Attributes(){} // RVA: 0x7FFAC2F9E740
        public void get_IssuerUniqueID(){} // RVA: 0x7FFAC2F9C730
        public void get_Extensions(){} // RVA: 0x7FFAC2FC20E0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD2BE50
    }

    public class AttributeTable : Object
    {
        public System.Collections.IDictionary attributes; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD2C580 | overloaded x4
        public void Get(){} // RVA: 0x7FFACBD2C7C0
        public void ToHashtable(){} // RVA: 0x7FFACBD2C870
        public void ToDictionary(){} // RVA: 0x7FFACBD2C8E0
    }

    public class AttributeX509 : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier AttrType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set AttrValues; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD2AD10
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void get_AttrType(){} // RVA: 0x7FFAC2F3C380
        public void GetAttributeValues(){} // RVA: 0x7FFAC8459490
        public void get_AttrValues(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD2B0D0
    }

    public class AuthorityInformationAccess : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AccessDescription[] descriptions; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD2C940
        public void .ctor(){} // RVA: 0x7FFACBD2CF40 | overloaded x3
        public void GetAccessDescriptions(){} // RVA: 0x7FFACBD2D120
        public void ToAsn1Object(){} // RVA: 0x7FFACBD2D1A0
        public void ToString(){} // RVA: 0x7FFACBD2D200
    }

    public class AuthorityKeyIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString AuthorityCertIssuer; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralNames AuthorityCertSerialNumber; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger certserno; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD2D3C0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD2E310 | overloaded x6
        public void GetKeyIdentifier(){} // RVA: 0x7FFACBD2E610
        public void get_AuthorityCertIssuer(){} // RVA: 0x7FFAC2F247C0
        public void get_AuthorityCertSerialNumber(){} // RVA: 0x7FFACBD2E640
        public void ToAsn1Object(){} // RVA: 0x7FFACBD2E660
        public void ToString(){} // RVA: 0x7FFACBD2E880
    }

    public class BasicConstraints : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBoolean PathLenConstraint; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger pathLenConstraint; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD2E940 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD2EEF0 | overloaded x3
        public void IsCA(){} // RVA: 0x7FFACBD2F050
        public void get_PathLenConstraint(){} // RVA: 0x7FFACBD2F070
        public void ToAsn1Object(){} // RVA: 0x7FFACBD2F090
        public void ToString(){} // RVA: 0x7FFACBD2F270
    }

    public class CertPolicyID : DerObjectIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD30940
    }

    public class CertificateList : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.TbsCertificateList TbsCertList; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier SignatureAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString Signature; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD2F470 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD2F550
        public void get_TbsCertList(){} // RVA: 0x7FFAC2F3C380
        public void GetRevokedCertificates(){} // RVA: 0x7FFACBD2F7A0
        public void GetRevokedCertificateEnumeration(){} // RVA: 0x7FFACBD2F7C0
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAC2F247C0
        public void get_Signature(){} // RVA: 0x7FFAC2F4F0C0
        public void GetSignatureOctets(){} // RVA: 0x7FFAC8EBC310
        public void get_Version(){} // RVA: 0x7FFACBD2F8C0
        public void get_Issuer(){} // RVA: 0x7FFAC3773190
        public void get_ThisUpdate(){} // RVA: 0x7FFAC3510100
        public void get_NextUpdate(){} // RVA: 0x7FFAC37735C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD2F930
    }

    public class CertificatePair : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509CertificateStructure Forward; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509CertificateStructure Reverse; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD2FA90
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void ToAsn1Object(){} // RVA: 0x7FFACBD2FF90
        public void get_Forward(){} // RVA: 0x7FFAC2F3C380
        public void get_Reverse(){} // RVA: 0x7FFAC2F247C0
    }

    public class CertificatePolicies : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.PolicyInformation[] policyInformation; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD302F0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD304C0 | overloaded x3
        public void GetPolicyInformation(){} // RVA: 0x7FFACBD306A0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD30720
        public void ToString(){} // RVA: 0x7FFACBD30780
    }

    public class CrlDistPoint : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence seq; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD309C0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD30BD0 | overloaded x2
        public void GetDistributionPoints(){} // RVA: 0x7FFACBD30C90
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
        public void ToString(){} // RVA: 0x7FFACBD30E30
    }

    public class CrlEntry : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence UserCertificate; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger RevocationDate; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time Extensions; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions crlEntryExtensions; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD44590
        public void get_UserCertificate(){} // RVA: 0x7FFAC2F247C0
        public void get_RevocationDate(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Extensions(){} // RVA: 0x7FFACBD447D0
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class CrlNumber : DerInteger
    {
        public object Number;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCE4FC0
        public void get_Number(){} // RVA: 0x7FFACBD30FC0
        public void ToString(){} // RVA: 0x7FFACBD30FD0
    }

    public class CrlReason : DerEnumerated
    {
        public int Unspecified;
        public int KeyCompromise;
        public int CACompromise;
        public int AffiliationChanged;
        public int Superseded;
        public int CessationOfOperation;
        public int CertificateHold;
        public int RemoveFromCrl;
        public int PrivilegeWithdrawn;
        public int AACompromise;
        public string[] ReasonString;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD310A0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFACBD31150
        public void .cctor(){} // RVA: 0x7FFACBD31250
    }

    public class DigestInfo : Asn1Encodable
    {
        public byte[] AlgorithmID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD314D0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD316B0 | overloaded x2
        public void get_AlgorithmID(){} // RVA: 0x7FFAC2F247C0
        public void GetDigest(){} // RVA: 0x7FFAC2F3C380
        public void ToAsn1Object(){} // RVA: 0x7FFACBD31870
    }

    public class DisplayText : Asn1Encodable
    {
        public int ContentTypeIA5String;
        public int ContentTypeBmpString;
        public int ContentTypeUtf8String;
        public int ContentTypeVisibleString;
        public int DisplayTextMaximumSize;
        public int contentType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IAsn1String contents; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F87E80 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBD32200
        public void ToAsn1Object(){} // RVA: 0x7FFACBD32400
        public void GetString(){} // RVA: 0x7FFACBD32480
    }

    public class DistributionPoint : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.DistributionPointName DistributionPointName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.ReasonFlags Reasons; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralNames CrlIssuer; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD324F0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC3000E00 | overloaded x2
        public void get_DistributionPointName(){} // RVA: 0x7FFAC2F3C380
        public void get_Reasons(){} // RVA: 0x7FFAC2F247C0
        public void get_CrlIssuer(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD32870
        public void ToString(){} // RVA: 0x7FFACBD32B00
        public void appendObject(){} // RVA: 0x7FFACBD32D20
    }

    public class DistributionPointName : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable PointType; // 0x10
        public int Name; // 0x18
        public int FullName;
        public int NameRelativeToCrlIssuer;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD32E60 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD33180 | overloaded x3
        public void get_PointType(){} // RVA: 0x7FFAC3157800
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void ToAsn1Object(){} // RVA: 0x7FFACBD33290
        public void ToString(){} // RVA: 0x7FFACBD33310
        public void appendObject(){} // RVA: 0x7FFACBD334C0
    }

    public class DsaParameter : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger P; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Q; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger G; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD335D0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD33B20 | overloaded x2
        public void get_P(){} // RVA: 0x7FFACBD33D60
        public void get_Q(){} // RVA: 0x7FFACBD33D80
        public void get_G(){} // RVA: 0x7FFACBD33DA0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD33DC0
    }

    public class ExtendedKeyUsage : Asn1Encodable
    {
        public System.Collections.IDictionary Count; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence seq; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD33F40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD34760 | overloaded x4
        public void HasKeyPurposeId(){} // RVA: 0x7FFACBD34C70
        public void GetUsages(){} // RVA: 0x7FFACBD34CD0
        public void GetAllUsages(){} // RVA: 0x7FFACBD34D60
        public void get_Count(){} // RVA: 0x7FFACBD34E30
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F247C0
    }

    public class GeneralName : Asn1Encodable
    {
        public int TagNo;
        public int Name;
        public int DnsName;
        public int X400Address;
        public int DirectoryName;
        public int EdiPartyName;
        public int UniformResourceIdentifier;
        public int IPAddress;
        public int RegisteredID;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable obj; // 0x10
        public int tag; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD34F50 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFACBD35760 | overloaded x2
        public void get_TagNo(){} // RVA: 0x7FFAC3157800
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void ToString(){} // RVA: 0x7FFACBD357B0
        public void toGeneralNameEncoding(){} // RVA: 0x7FFACBD35940
        public void parseIPv4Mask(){} // RVA: 0x7FFACBD35DD0
        public void parseIPv4(){} // RVA: 0x7FFACBD35E60
        public void parseMask(){} // RVA: 0x7FFACBD360A0
        public void copyInts(){} // RVA: 0x7FFACBD36150
        public void parseIPv6(){} // RVA: 0x7FFACBD361D0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD36680
    }

    public class GeneralNames : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName[] names; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD368E0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD36AF0 | overloaded x3
        public void GetNames(){} // RVA: 0x7FFACBD36CD0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD36D50
        public void ToString(){} // RVA: 0x7FFACBD36DB0
    }

    public class GeneralSubtree : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName Base; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Minimum; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Maximum; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD37550 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBD37650 | overloaded x2
        public void get_Base(){} // RVA: 0x7FFAC2F3C380
        public void get_Minimum(){} // RVA: 0x7FFACBD37730
        public void get_Maximum(){} // RVA: 0x7FFACBD2E640
        public void ToAsn1Object(){} // RVA: 0x7FFACBD377B0
    }

    public class Holder : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.IssuerSerial Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralNames BaseCertificateID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.ObjectDigestInfo EntityName; // 0x20
        public int ObjectDigestInfo; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD379F0
        public void .ctor(){} // RVA: 0x7FFACBD382F0 | overloaded x7
        public void get_Version(){} // RVA: 0x7FFAC32EC4C0
        public void get_BaseCertificateID(){} // RVA: 0x7FFAC2F3C380
        public void get_EntityName(){} // RVA: 0x7FFAC2F247C0
        public void get_ObjectDigestInfo(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD38360
    }

    public class IetfAttrSyntax : Asn1Encodable
    {
        public int PolicyAuthority;
        public int ValueType;
        public int ValueUtf8;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralNames policyAuthority; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1EncodableVector values; // 0x18
        public int valueChoice; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD38610
        public void get_PolicyAuthority(){} // RVA: 0x7FFAC2F3C380
        public void get_ValueType(){} // RVA: 0x7FFAC30DBBE0
        public void GetValues(){} // RVA: 0x7FFACBD38CC0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD391D0
    }

    public class IssuerSerial : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralNames Issuer; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Serial; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString IssuerUid; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD39620 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void get_Issuer(){} // RVA: 0x7FFAC2F3C380
        public void get_Serial(){} // RVA: 0x7FFAC2F247C0
        public void get_IssuerUid(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD39900
    }

    public class IssuingDistributionPoint : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.DistributionPointName OnlyContainsUserCerts; // 0x10
        public bool OnlyContainsCACerts; // 0x18
        public bool IsIndirectCrl; // 0x19
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.ReasonFlags OnlyContainsAttributeCerts; // 0x20
        public bool DistributionPoint; // 0x28
        public bool OnlySomeReasons; // 0x29
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence seq; // 0x30

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD39B60 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD3A2B0 | overloaded x2
        public void get_OnlyContainsUserCerts(){} // RVA: 0x7FFAC2F3C4E0
        public void get_OnlyContainsCACerts(){} // RVA: 0x7FFAC3228D50
        public void get_IsIndirectCrl(){} // RVA: 0x7FFAC30F6BA0
        public void get_OnlyContainsAttributeCerts(){} // RVA: 0x7FFAC386C550
        public void get_DistributionPoint(){} // RVA: 0x7FFAC2F3C380
        public void get_OnlySomeReasons(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAC31D95E0
        public void ToString(){} // RVA: 0x7FFACBD3A610
        public void appendObject(){} // RVA: 0x7FFACBD3AA20
    }

    public class KeyPurposeID : DerObjectIdentifier
    {
        public string IdKP;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.KeyPurposeID AnyExtendedKeyUsage;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPServerAuth; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPClientAuth; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPCodeSigning; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPEmailProtection; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPIpsecEndSystem; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPIpsecTunnel; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPIpsecUser; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPTimeStamping; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPOcspSigning; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPSmartCardLogon; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPMacAddress; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD3AB10
        public void .cctor(){} // RVA: 0x7FFACBD3AB70
    }

    public class KeyUsage : DerBitString
    {
        public int DigitalSignature;
        public int NonRepudiation;
        public int KeyEncipherment;
        public int DataEncipherment;
        public int KeyAgreement;
        public int KeyCertSign;
        public int CrlSign;
        public int EncipherOnly;
        public int DecipherOnly;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD3B650
        public void .ctor(){} // RVA: 0x7FFACBD3B8B0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFACBD3B960
    }

    public class NameConstraints : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence PermittedSubtrees; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence ExcludedSubtrees; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD3BAC0
        public void .ctor(){} // RVA: 0x7FFACBD3BF00 | overloaded x3
        public void CreateSequence(){} // RVA: 0x7FFACBD3BFF0
        public void get_PermittedSubtrees(){} // RVA: 0x7FFAC2F3C380
        public void get_ExcludedSubtrees(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD3C320
    }

    public class NoticeReference : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.DisplayText Organization; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence noticeNumbers; // 0x18

        // ── Methods ──
        public void ConvertVector(){} // RVA: 0x7FFACBD3C4D0
        public void .ctor(){} // RVA: 0x7FFACBD3CC00 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFACBD3CDD0
        public void get_Organization(){} // RVA: 0x7FFAC2F3C380
        public void GetNoticeNumbers(){} // RVA: 0x7FFACBD3CEB0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD3D050
    }

    public class ObjectDigestInfo : Asn1Encodable
    {
        public int DigestedObjectType;
        public int OtherObjectTypeID;
        public int DigestAlgorithm;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerEnumerated ObjectDigest; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier otherObjectTypeID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digestAlgorithm; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString objectDigest; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD3D330 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD3D580 | overloaded x2
        public void get_DigestedObjectType(){} // RVA: 0x7FFAC2F3C380
        public void get_OtherObjectTypeID(){} // RVA: 0x7FFAC2F247C0
        public void get_DigestAlgorithm(){} // RVA: 0x7FFAC2F4F0C0
        public void get_ObjectDigest(){} // RVA: 0x7FFAC2F4F130
        public void ToAsn1Object(){} // RVA: 0x7FFACBD3D8C0
    }

    public class PolicyInformation : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PolicyIdentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence PolicyQualifiers; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBD3DD60
        public void get_PolicyIdentifier(){} // RVA: 0x7FFAC2F3C380
        public void get_PolicyQualifiers(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD3DE30
    }

    public class PolicyMappings : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence seq; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD3E040 | overloaded x3
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class PolicyQualifierID : DerObjectIdentifier
    {
        public string IdQt;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.PolicyQualifierID IdQtCps;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.PolicyQualifierID IdQtUnotice; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD3E6A0
        public void .cctor(){} // RVA: 0x7FFACBD3E700
    }

    public class PolicyQualifierInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PolicyQualifierId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable Qualifier; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD3EAE0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBD3ECE0
        public void get_PolicyQualifierId(){} // RVA: 0x7FFAC2F3C380
        public void get_Qualifier(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD3EDC0
    }

    public class PrivateKeyUsagePeriod : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime NotBefore; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime NotAfter; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD3EED0
        public void .ctor(){} // RVA: 0x7FFACBD3F130
        public void get_NotBefore(){} // RVA: 0x7FFAC2F3C380
        public void get_NotAfter(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD3F3A0
    }

    public class ReasonFlags : DerBitString
    {
        public int Unused;
        public int KeyCompromise;
        public int CACompromise;
        public int AffiliationChanged;
        public int Superseded;
        public int CessationOfOperation;
        public int CertificateHold;
        public int PrivilegeWithdrawn;
        public int AACompromise;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD3F5B0 | overloaded x2
    }

    public class RoleSyntax : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralNames RoleAuthority; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName RoleName; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD3F660
        public void .ctor(){} // RVA: 0x7FFACBD3FC60 | overloaded x4
        public void get_RoleAuthority(){} // RVA: 0x7FFAC2F3C380
        public void get_RoleName(){} // RVA: 0x7FFAC2F247C0
        public void GetRoleNameAsString(){} // RVA: 0x7FFACBD3FE90
        public void GetRoleAuthorityAsString(){} // RVA: 0x7FFACBD3FF40
        public void ToAsn1Object(){} // RVA: 0x7FFACBD400E0
        public void ToString(){} // RVA: 0x7FFACBD402F0
    }

    public class RsaPublicKeyStructure : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Modulus; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger PublicExponent; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD405D0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD40930 | overloaded x2
        public void get_Modulus(){} // RVA: 0x7FFAC2F3C380
        public void get_PublicExponent(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD40B10
    }

    public class SubjectDirectoryAttributes : Asn1Encodable
    {
        public System.Collections.IList Attributes; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD40DB0
        public void .ctor(){} // RVA: 0x7FFACBD412C0 | overloaded x3
        public void ToAsn1Object(){} // RVA: 0x7FFACBD413B0
        public void get_Attributes(){} // RVA: 0x7FFACBD41720
    }

    public class SubjectKeyIdentifier : Asn1Encodable
    {
        public byte[] keyIdentifier; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD41830 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD41C50 | overloaded x3
        public void GetKeyIdentifier(){} // RVA: 0x7FFAC2F3C380
        public void ToAsn1Object(){} // RVA: 0x7FFACBD41CC0
        public void CreateSha1KeyIdentifier(){} // RVA: 0x7FFACBD41DB0
        public void CreateTruncatedSha1KeyIdentifier(){} // RVA: 0x7FFACBD41E10
        public void GetDigest(){} // RVA: 0x7FFACBD41F40
    }

    public class SubjectPublicKeyInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier AlgorithmID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString PublicKeyData; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD42080 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD423C0 | overloaded x3
        public void get_AlgorithmID(){} // RVA: 0x7FFAC2F3C380
        public void ParsePublicKey(){} // RVA: 0x7FFACBD425D0
        public void GetPublicKey(){} // RVA: 0x7FFACBD425D0
        public void get_PublicKeyData(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD42610
    }

    public class Target : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName TargetGroup; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName TargetName; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD42720
        public void .ctor(){} // RVA: 0x7FFACBD42AF0 | overloaded x2
        public void get_TargetGroup(){} // RVA: 0x7FFAC2F247C0
        public void get_TargetName(){} // RVA: 0x7FFAC2F3C380
        public void ToAsn1Object(){} // RVA: 0x7FFACBD42BB0
    }

    public class TargetInformation : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence targets; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD42D40
        public void .ctor(){} // RVA: 0x7FFACBD431B0 | overloaded x3
        public void GetTargetsObjects(){} // RVA: 0x7FFACBD42F50
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class Targets : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence targets; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD43330
        public void .ctor(){} // RVA: 0x7FFACBD43540 | overloaded x2
        public void GetTargets(){} // RVA: 0x7FFACBD43600
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class TbsCertificateList : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger VersionNumber; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Signature; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name Issuer; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time ThisUpdate; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time NextUpdate; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence Extensions; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions crlExtensions; // 0x48

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD44910 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD44AC0
        public void get_Version(){} // RVA: 0x7FFACBD44520
        public void get_VersionNumber(){} // RVA: 0x7FFAC2F247C0
        public void get_Signature(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Issuer(){} // RVA: 0x7FFAC2F4F130
        public void get_ThisUpdate(){} // RVA: 0x7FFAC31D95E0
        public void get_NextUpdate(){} // RVA: 0x7FFAC31D0140
        public void GetRevokedCertificates(){} // RVA: 0x7FFACBD45130
        public void GetRevokedCertificateEnumeration(){} // RVA: 0x7FFACBD452F0
        public void get_Extensions(){} // RVA: 0x7FFAC2F9C730
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class TbsCertificateStructure : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger VersionNumber; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger SerialNumber; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Signature; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name Issuer; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time StartDate; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time EndDate; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name Subject; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo SubjectPublicKeyInfo; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString IssuerUniqueID; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString SubjectUniqueID; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions Extensions; // 0x68

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD43980 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD43A60
        public void get_Version(){} // RVA: 0x7FFACBD44520
        public void get_VersionNumber(){} // RVA: 0x7FFAC2F247C0
        public void get_SerialNumber(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Signature(){} // RVA: 0x7FFAC2F4F130
        public void get_Issuer(){} // RVA: 0x7FFAC31D95E0
        public void get_StartDate(){} // RVA: 0x7FFAC31D0140
        public void get_EndDate(){} // RVA: 0x7FFAC2F9E740
        public void get_Subject(){} // RVA: 0x7FFAC2F9C730
        public void get_SubjectPublicKeyInfo(){} // RVA: 0x7FFAC2FC20E0
        public void get_IssuerUniqueID(){} // RVA: 0x7FFAC2FE9500
        public void get_SubjectUniqueID(){} // RVA: 0x7FFAC2FBF370
        public void get_Extensions(){} // RVA: 0x7FFAC2F9CD50
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class Time : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object time; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD45A80 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD457B0 | overloaded x2
        public void GetTime(){} // RVA: 0x7FFACBD45CD0
        public void ToDateTime(){} // RVA: 0x7FFACBD45DF0
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
        public void ToString(){} // RVA: 0x7FFACBD46000
    }

    public class UserNotice : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.NoticeReference NoticeRef; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.DisplayText ExplicitText; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD46130 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBD46470
        public void get_NoticeRef(){} // RVA: 0x7FFAC2F3C380
        public void get_ExplicitText(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD46550
    }

    public class V1TbsCertificateGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerTaggedObject version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger serialNumber; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signature; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name issuer; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time startDate; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time endDate; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name subject; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo subjectPublicKeyInfo; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD46730
        public void SetSerialNumber(){} // RVA: 0x7FFAC2F87E80
        public void SetSignature(){} // RVA: 0x7FFAC2F4F0D0
        public void SetIssuer(){} // RVA: 0x7FFAC2F22E90
        public void SetStartDate(){} // RVA: 0x7FFACBD46860 | overloaded x2
        public void SetEndDate(){} // RVA: 0x7FFACBD46920 | overloaded x2
        public void SetSubject(){} // RVA: 0x7FFAC2F49200
        public void SetSubjectPublicKeyInfo(){} // RVA: 0x7FFAC2F9C740
        public void GenerateTbsCertificate(){} // RVA: 0x7FFACBD469E0
    }

    public class V2AttributeCertificateInfoGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Holder holder; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AttCertIssuer issuer; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signature; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger serialNumber; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1EncodableVector attributes; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString issuerUniqueID; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions extensions; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime startDate; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime endDate; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD46D80
        public void SetHolder(){} // RVA: 0x7FFAC2F87E80
        public void AddAttribute(){} // RVA: 0x7FFACBD46FB0 | overloaded x2
        public void SetSerialNumber(){} // RVA: 0x7FFAC2F4F890
        public void SetSignature(){} // RVA: 0x7FFAC2F22E90
        public void SetIssuer(){} // RVA: 0x7FFAC2F4F0D0
        public void SetStartDate(){} // RVA: 0x7FFAC30794D0
        public void SetEndDate(){} // RVA: 0x7FFAC2FE9510
        public void SetIssuerUniqueID(){} // RVA: 0x7FFAC2F49200
        public void SetExtensions(){} // RVA: 0x7FFAC2F9C740
        public void GenerateAttributeCertificateInfo(){} // RVA: 0x7FFACBD46FD0
    }

    public class V2Form : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralNames IssuerName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.IssuerSerial BaseCertificateID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.ObjectDigestInfo ObjectDigestInfo; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD473F0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD47530 | overloaded x5
        public void get_IssuerName(){} // RVA: 0x7FFAC2F3C380
        public void get_BaseCertificateID(){} // RVA: 0x7FFAC2F247C0
        public void get_ObjectDigestInfo(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD47820
    }

    public class V2TbsCertListGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signature; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name issuer; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time thisUpdate; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time nextUpdate; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions extensions; // 0x38
        public System.Collections.IList crlEntries; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD47A90
        public void SetSignature(){} // RVA: 0x7FFAC2F87E80
        public void SetIssuer(){} // RVA: 0x7FFAC2F4F0D0
        public void SetThisUpdate(){} // RVA: 0x7FFAC2F22E90 | overloaded x2
        public void SetNextUpdate(){} // RVA: 0x7FFAC2F4F890 | overloaded x2
        public void AddCrlEntry(){} // RVA: 0x7FFACBD48530 | overloaded x5
        public void SetExtensions(){} // RVA: 0x7FFAC31D0C20
        public void GenerateTbsCertList(){} // RVA: 0x7FFACBD48750
    }

    public class V3TbsCertificateGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerTaggedObject version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger serialNumber; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signature; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name issuer; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time startDate; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time endDate; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name subject; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo subjectPublicKeyInfo; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions extensions; // 0x50
        public bool altNamePresentAndCritical; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString issuerUniqueID; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString subjectUniqueID; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD48E00
        public void SetSerialNumber(){} // RVA: 0x7FFAC2F87E80
        public void SetSignature(){} // RVA: 0x7FFAC2F4F0D0
        public void SetIssuer(){} // RVA: 0x7FFAC2F22E90
        public void SetStartDate(){} // RVA: 0x7FFAC2F4F890 | overloaded x2
        public void SetEndDate(){} // RVA: 0x7FFAC31D0C20 | overloaded x2
        public void SetSubject(){} // RVA: 0x7FFAC2F49200
        public void SetIssuerUniqueID(){} // RVA: 0x7FFAC2FBF380
        public void SetSubjectUniqueID(){} // RVA: 0x7FFAC2F9CD60
        public void SetSubjectPublicKeyInfo(){} // RVA: 0x7FFAC2F9C740
        public void SetExtensions(){} // RVA: 0x7FFACBD490B0
        public void GenerateTbsCertificate(){} // RVA: 0x7FFACBD49190
    }

    public class X509Attributes : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier RoleSyntax;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBD49670
    }

    public class X509CertificateStructure : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.TbsCertificateStructure TbsCertificate; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Version; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString SerialNumber; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD49770 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD49980 | overloaded x2
        public void get_TbsCertificate(){} // RVA: 0x7FFAC2F3C380
        public void get_Version(){} // RVA: 0x7FFACBD2F8C0
        public void get_SerialNumber(){} // RVA: 0x7FFAC37735E0
        public void get_Issuer(){} // RVA: 0x7FFAC3510100
        public void get_StartDate(){} // RVA: 0x7FFAC37735C0
        public void get_EndDate(){} // RVA: 0x7FFAC350FB30
        public void get_Subject(){} // RVA: 0x7FFAC3510F20
        public void get_SubjectPublicKeyInfo(){} // RVA: 0x7FFAC8DBB230
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAC2F247C0
        public void get_Signature(){} // RVA: 0x7FFAC2F4F0C0
        public void GetSignatureOctets(){} // RVA: 0x7FFAC8EBC310
        public void ToAsn1Object(){} // RVA: 0x7FFACBD49BD0
    }

    public class X509DefaultEntryConverter : X509NameEntryConverter
    {
        // ── Methods ──
        public void GetConvertedValue(){} // RVA: 0x7FFACBD49D30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class X509Extension : Object
    {
        public bool IsCritical; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString Value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC833CCF0 | overloaded x2
        public void get_IsCritical(){} // RVA: 0x7FFAC2FEB5E0
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void GetParsedValue(){} // RVA: 0x7FFACBD4A3A0
        public void GetHashCode(){} // RVA: 0x7FFACBD4A3B0
        public void Equals(){} // RVA: 0x7FFACBD4A3F0
        public void ConvertValueToObject(){} // RVA: 0x7FFACBD4A4C0
    }

    public class X509Extensions : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ExtensionOids;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SubjectKeyIdentifier; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier KeyUsage; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PrivateKeyUsagePeriod; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SubjectAlternativeName; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IssuerAlternativeName; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier BasicConstraints; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CrlNumber; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ReasonCode; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier InstructionCode; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier InvalidityDate; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DeltaCrlIndicator; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IssuingDistributionPoint; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CertificateIssuer; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier NameConstraints; // 0x70
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CrlDistributionPoints; // 0x78
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CertificatePolicies; // 0x80
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PolicyMappings; // 0x88
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier AuthorityKeyIdentifier; // 0x90
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PolicyConstraints; // 0x98
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ExtendedKeyUsage; // 0xA0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier FreshestCrl; // 0xA8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier InhibitAnyPolicy; // 0xB0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier AuthorityInfoAccess; // 0xB8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SubjectInfoAccess; // 0xC0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier LogoType; // 0xC8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier BiometricInfo; // 0xD0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier QCStatements; // 0xD8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier AuditIdentity; // 0xE0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier NoRevAvail; // 0xE8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier TargetInformation; // 0xF0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ExpiredCertsOnCrl; // 0xF8
        public System.Collections.IDictionary extensions; // 0x10
        public System.Collections.IList ordering; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD4A5F0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD4C0D0 | overloaded x7
        public void Oids(){} // RVA: 0x7FFACBD4C5B0
        public void get_ExtensionOids(){} // RVA: 0x7FFACBD4C610
        public void GetExtension(){} // RVA: 0x7FFACBD4C700
        public void ToAsn1Object(){} // RVA: 0x7FFACBD4C7B0
        public void Equivalent(){} // RVA: 0x7FFACBD4CDA0
        public void GetExtensionOids(){} // RVA: 0x7FFACBD4D180 | overloaded x2
        public void GetNonCriticalExtensionOids(){} // RVA: 0x7FFACBD4D160
        public void GetCriticalExtensionOids(){} // RVA: 0x7FFACBD4D170
        public void ToOidArray(){} // RVA: 0x7FFACBD4D600
        public void .cctor(){} // RVA: 0x7FFACBD4D6A0
    }

    public class X509ExtensionsGenerator : Object
    {
        public System.Collections.IDictionary IsEmpty; // 0x10
        public System.Collections.IList extOrdering; // 0x18

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFACBD4EB10
        public void AddExtension(){} // RVA: 0x7FFACBD4EDB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFACBD4F050
        public void Generate(){} // RVA: 0x7FFACBD4F0B0
        public void .ctor(){} // RVA: 0x7FFACBD4F120
    }

    public class X509Name : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DefaultReverse;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier O; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier OU; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier T; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CN; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Street; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SerialNumber; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier L; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ST; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Surname; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier GivenName; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Initials; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Generation; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier UniqueIdentifier; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier BusinessCategory; // 0x70
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PostalCode; // 0x78
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DnQualifier; // 0x80
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Pseudonym; // 0x88
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DateOfBirth; // 0x90
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PlaceOfBirth; // 0x98
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Gender; // 0xA0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CountryOfCitizenship; // 0xA8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CountryOfResidence; // 0xB0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier NameAtBirth; // 0xB8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PostalAddress; // 0xC0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DmdName; // 0xC8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier TelephoneNumber; // 0xD0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier OrganizationIdentifier; // 0xD8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Name; // 0xE0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier EmailAddress; // 0xE8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier UnstructuredName; // 0xF0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier UnstructuredAddress; // 0xF8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier E; // 0x100
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DC; // 0x108
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier UID; // 0x110
        public bool[] defaultReverse; // 0x118
        public System.Collections.Hashtable DefaultSymbols; // 0x120
        public System.Collections.Hashtable RFC2253Symbols; // 0x128
        public System.Collections.Hashtable RFC1779Symbols; // 0x130
        public System.Collections.Hashtable DefaultLookup; // 0x138
        public System.Collections.IList ordering; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509NameEntryConverter converter; // 0x18
        public System.Collections.IList values; // 0x20
        public System.Collections.IList added; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence seq; // 0x30

        // ── Methods ──
        public void get_DefaultReverse(){} // RVA: 0x7FFACBD4F2B0
        public void set_DefaultReverse(){} // RVA: 0x7FFACBD4F330
        public void .cctor(){} // RVA: 0x7FFACBD4F3B0
        public void GetInstance(){} // RVA: 0x7FFACBD52350 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD541A0 | overloaded x12
        public void DecodeOid(){} // RVA: 0x7FFACBD53FA0
        public void GetOidList(){} // RVA: 0x7FFACBD54BE0
        public void GetValueList(){} // RVA: 0x7FFACBD54C90 | overloaded x2
        public void ToAsn1Object(){} // RVA: 0x7FFACBD54F40
        public void Equivalent(){} // RVA: 0x7FFACBD55960 | overloaded x2
        public void equivalentStrings(){} // RVA: 0x7FFACBD55D50
        public void canonicalize(){} // RVA: 0x7FFACBD55E80
        public void decodeObject(){} // RVA: 0x7FFACBD56020
        public void stripInternalSpaces(){} // RVA: 0x7FFACBD56150
        public void AppendValue(){} // RVA: 0x7FFACBD56270
        public void ToString(){} // RVA: 0x7FFACBD56B10 | overloaded x2
    }

    public class X509NameEntryConverter : Object
    {
        // ── Methods ──
        public void ConvertHexEncoded(){} // RVA: 0x7FFACBD56B80
        public void CanBePrintable(){} // RVA: 0x7FFACBD56C10
        public void GetConvertedValue(){} // RVA: 0x7FFAC2C6A6F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class X509NameTokenizer : Object
    {
        public string value; // 0x10
        public int index; // 0x18
        public char separator; // 0x1C
        public System.Text.StringBuilder buffer; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD56C30 | overloaded x2
        public void HasMoreTokens(){} // RVA: 0x7FFACBD56D50
        public void NextToken(){} // RVA: 0x7FFACBD56D80
    }

    public class X509ObjectIdentifiers : Object
    {
        public string ID;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CommonName;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CountryName; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier LocalityName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier StateOrProvinceName; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Organization; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier OrganizationalUnitName; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_at_telephoneNumber; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_at_name; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_at_organizationIdentifier; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha1; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier RipeMD160; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier RipeMD160WithRsaEncryption; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdEARsa; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdPkix; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdPE; // 0x70
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAD; // 0x78
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdADCAIssuers; // 0x80
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdADOcsp; // 0x88
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier OcspAccessMethod; // 0x90
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CrlAccessMethod; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBD56F80
    }

}