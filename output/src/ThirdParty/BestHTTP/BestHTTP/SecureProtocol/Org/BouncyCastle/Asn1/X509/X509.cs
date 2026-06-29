// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509
// Classes: 71
// Methods: 452

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509
{
    public class AccessDescription : Asn1Encodable
    {
        public object IdADCAIssuers;
        public object IdADOcsp;
        public object accessMethod;
        public object accessLocation;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3C58C0
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_AccessMethod(){} // RVA: 0xB5DBF0
        public void get_AccessLocation(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA3C5C60
        public void ToString(){} // RVA: 0xA3C5D70
        public void .cctor(){} // RVA: 0xA3C5DE0
    }

    public class AlgorithmIdentifier : Asn1Encodable
    {
        public object algorithm;
        public object parameters;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3C5F90
        public void .ctor(){} // RVA: 0xA3C6130
        public void get_Algorithm(){} // RVA: 0xB5DBF0
        public void get_ObjectID(){} // RVA: 0xB5DBF0
        public void get_Parameters(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA3C6370
    }

    public class AttCertIssuer : Asn1Encodable
    {
        public object obj;
        public object choiceObj;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3C68B0
        public void .ctor(){} // RVA: 0xA3C69F0
        public void get_Issuer(){} // RVA: 0xB5DBF0
        public void ToAsn1Object(){} // RVA: 0xB465B0
    }

    public class AttCertValidityPeriod : Asn1Encodable
    {
        public object notBeforeTime;
        public object notAfterTime;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3C6CF0
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_NotBeforeTime(){} // RVA: 0xB5DBF0
        public void get_NotAfterTime(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA3C6ED0
    }

    public class AttributeCertificate : Asn1Encodable
    {
        public object acinfo;
        public object signatureAlgorithm;
        public object signatureValue;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3C74B0
        public void .ctor(){} // RVA: 0xA3C7590
        public void get_ACInfo(){} // RVA: 0xB5DBF0
        public void get_SignatureAlgorithm(){} // RVA: 0xB465B0
        public void get_SignatureValue(){} // RVA: 0xB700F0
        public void GetSignatureOctets(){} // RVA: 0x718D460
        public void ToAsn1Object(){} // RVA: 0xA3C7800
    }

    public class AttributeCertificateInfo : Asn1Encodable
    {
        public object version;
        public object holder;
        public object issuer;
        public object signature;
        public object serialNumber;
        public object attrCertValidityPeriod;
        public object attributes;
        public object issuerUniqueID;
        public object extensions;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3C7980
        public void .ctor(){} // RVA: 0xA3C7B60
        public void get_Version(){} // RVA: 0xB5DBF0
        public void get_Holder(){} // RVA: 0xB465B0
        public void get_Issuer(){} // RVA: 0xB700F0
        public void get_Signature(){} // RVA: 0xB70160
        public void get_SerialNumber(){} // RVA: 0xD33E60
        public void get_AttrCertValidityPeriod(){} // RVA: 0xD05CA0
        public void get_Attributes(){} // RVA: 0xBC1B30
        public void get_IssuerUniqueID(){} // RVA: 0xBBF8F0
        public void get_Extensions(){} // RVA: 0xBE58B0
        public void ToAsn1Object(){} // RVA: 0xA3C8120
    }

    public class AttributeTable : Object
    {
        public object attributes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3C8850
        public void Get(){} // RVA: 0xA3C8A90
        public void ToHashtable(){} // RVA: 0xA3C8B40
        public void ToDictionary(){} // RVA: 0xA3C8BB0
    }

    public class AttributeX509 : Asn1Encodable
    {
        public object attrType;
        public object attrValues;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3C6FE0
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_AttrType(){} // RVA: 0xB5DBF0
        public void GetAttributeValues(){} // RVA: 0x673B480
        public void get_AttrValues(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA3C73A0
    }

    public class AuthorityInformationAccess : Asn1Encodable
    {
        public object descriptions;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3C8C10
        public void .ctor(){} // RVA: 0xA3C9230
        public void GetAccessDescriptions(){} // RVA: 0xA3C9410
        public void ToAsn1Object(){} // RVA: 0xA3C9490
        public void ToString(){} // RVA: 0xA3C94F0
    }

    public class AuthorityKeyIdentifier : Asn1Encodable
    {
        public object keyidentifier;
        public object certissuer;
        public object certserno;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3C96A0
        public void .ctor(){} // RVA: 0xA3CA5D0
        public void GetKeyIdentifier(){} // RVA: 0xA3CA8E0
        public void get_AuthorityCertIssuer(){} // RVA: 0xB465B0
        public void get_AuthorityCertSerialNumber(){} // RVA: 0xA3CA910
        public void ToAsn1Object(){} // RVA: 0xA3CA930
        public void ToString(){} // RVA: 0xA3CAB50
    }

    public class BasicConstraints : Asn1Encodable
    {
        public object cA;
        public object pathLenConstraint;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3CAC10
        public void .ctor(){} // RVA: 0xA3CB1B0
        public void IsCA(){} // RVA: 0xA3CB310
        public void get_PathLenConstraint(){} // RVA: 0xA3CB330
        public void ToAsn1Object(){} // RVA: 0xA3CB350
        public void ToString(){} // RVA: 0xA3CB530
    }

    public class CertPolicyID : DerObjectIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3CCC00
    }

    public class CertificateList : Asn1Encodable
    {
        public object tbsCertList;
        public object sigAlgID;
        public object sig;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3CB720
        public void .ctor(){} // RVA: 0xA3CB800
        public void get_TbsCertList(){} // RVA: 0xB5DBF0
        public void GetRevokedCertificates(){} // RVA: 0xA3CBA50
        public void GetRevokedCertificateEnumeration(){} // RVA: 0xA3CBA70
        public void get_SignatureAlgorithm(){} // RVA: 0xB465B0
        public void get_Signature(){} // RVA: 0xB700F0
        public void GetSignatureOctets(){} // RVA: 0x718D460
        public void get_Version(){} // RVA: 0xA3CBB70
        public void get_Issuer(){} // RVA: 0x13F92F0
        public void get_ThisUpdate(){} // RVA: 0x13F9420
        public void get_NextUpdate(){} // RVA: 0x13F93E0
        public void ToAsn1Object(){} // RVA: 0xA3CBBE0
    }

    public class CertificatePair : Asn1Encodable
    {
        public object forward;
        public object reverse;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3CBD40
        public void .ctor(){} // RVA: 0x17C92C0
        public void ToAsn1Object(){} // RVA: 0xA3CC220
        public void get_Forward(){} // RVA: 0xB5DBF0
        public void get_Reverse(){} // RVA: 0xB465B0
    }

    public class CertificatePolicies : Asn1Encodable
    {
        public object policyInformation;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3CC590
        public void .ctor(){} // RVA: 0xA3CC760
        public void GetPolicyInformation(){} // RVA: 0xA3CC950
        public void ToAsn1Object(){} // RVA: 0xA3CC9D0
        public void ToString(){} // RVA: 0xA3CCA30
    }

    public class CrlDistPoint : Asn1Encodable
    {
        public object seq;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3CCC80
        public void .ctor(){} // RVA: 0xA3CCE90
        public void GetDistributionPoints(){} // RVA: 0xA3CCF50
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
        public void ToString(){} // RVA: 0xA3CD100
    }

    public class CrlEntry : Asn1Encodable
    {
        public object seq;
        public object userCertificate;
        public object revocationDate;
        public object crlEntryExtensions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3E0AD0
        public void get_UserCertificate(){} // RVA: 0xB465B0
        public void get_RevocationDate(){} // RVA: 0xB700F0
        public void get_Extensions(){} // RVA: 0xA3E0D10
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class CrlNumber : DerInteger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3810C0
        public void get_Number(){} // RVA: 0xA3CD2A0
        public void ToString(){} // RVA: 0xA3CD2B0
    }

    public class CrlReason : DerEnumerated
    {
        public object Unspecified;
        public object KeyCompromise;
        public object CACompromise;
        public object AffiliationChanged;
        public object Superseded;
        public object CessationOfOperation;
        public object CertificateHold;
        public object RemoveFromCrl;
        public object PrivilegeWithdrawn;
        public object AACompromise;
        public object ReasonString;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3CD380
        public void ToString(){} // RVA: 0xA3CD430
        public void .cctor(){} // RVA: 0xA3CD530
    }

    public class DigestInfo : Asn1Encodable
    {
        public object digest;
        public object algID;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3CD7B0
        public void .ctor(){} // RVA: 0xA3CD990
        public void get_AlgorithmID(){} // RVA: 0xB465B0
        public void GetDigest(){} // RVA: 0xB5DBF0
        public void ToAsn1Object(){} // RVA: 0xA3CDB50
    }

    public class DisplayText : Asn1Encodable
    {
        public object ContentTypeIA5String;
        public object ContentTypeBmpString;
        public object ContentTypeUtf8String;
        public object ContentTypeVisibleString;
        public object DisplayTextMaximumSize;
        public object contentType;
        public object contents;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xBA9BA0
        public void GetInstance(){} // RVA: 0xA3CE5A0
        public void ToAsn1Object(){} // RVA: 0xA3CE7A0
        public void GetString(){} // RVA: 0xA3CE820
    }

    public class DistributionPoint : Asn1Encodable
    {
        public object distributionPoint;
        public object reasons;
        public object cRLIssuer;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3CE890
        public void .ctor(){} // RVA: 0xC27FD0
        public void get_DistributionPointName(){} // RVA: 0xB5DBF0
        public void get_Reasons(){} // RVA: 0xB465B0
        public void get_CrlIssuer(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA3CEC10
        public void ToString(){} // RVA: 0xA3CEEB0
        public void appendObject(){} // RVA: 0xA3CF0D0
    }

    public class DistributionPointName : Asn1Encodable
    {
        public object name;
        public object type;
        public object FullName;
        public object NameRelativeToCrlIssuer;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3CF210
        public void .ctor(){} // RVA: 0xA3CF530
        public void get_PointType(){} // RVA: 0xE62D00
        public void get_Name(){} // RVA: 0xB5DBF0
        public void ToAsn1Object(){} // RVA: 0xA3CF640
        public void ToString(){} // RVA: 0xA3CF6C0
        public void appendObject(){} // RVA: 0xA3CF870
    }

    public class DsaParameter : Asn1Encodable
    {
        public object p;
        public object q;
        public object g;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3CF980
        public void .ctor(){} // RVA: 0xA3CFED0
        public void get_P(){} // RVA: 0xA3D0110
        public void get_Q(){} // RVA: 0xA3D0130
        public void get_G(){} // RVA: 0xA3D0150
        public void ToAsn1Object(){} // RVA: 0xA3D0170
    }

    public class ExtendedKeyUsage : Asn1Encodable
    {
        public object usageTable;
        public object seq;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3D02F0
        public void .ctor(){} // RVA: 0xA3D0B00
        public void HasKeyPurposeId(){} // RVA: 0xA3D1010
        public void GetUsages(){} // RVA: 0xA3D1070
        public void GetAllUsages(){} // RVA: 0xA3D1100
        public void get_Count(){} // RVA: 0xA3D11D0
        public void ToAsn1Object(){} // RVA: 0xB465B0
    }

    public class GeneralName : Asn1Encodable
    {
        public object OtherName;
        public object Rfc822Name;
        public object DnsName;
        public object X400Address;
        public object DirectoryName;
        public object EdiPartyName;
        public object UniformResourceIdentifier;
        public object IPAddress;
        public object RegisteredID;
        public object obj;
        public object tag;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3D12F0
        public void GetInstance(){} // RVA: 0xA3D1B60
        public void get_TagNo(){} // RVA: 0xE62D00
        public void get_Name(){} // RVA: 0xB5DBF0
        public void ToString(){} // RVA: 0xA3D1BB0
        public void toGeneralNameEncoding(){} // RVA: 0xA3D1D40
        public void parseIPv4Mask(){} // RVA: 0xA3D21D0
        public void parseIPv4(){} // RVA: 0xA3D2260
        public void parseMask(){} // RVA: 0xA3D24C0
        public void copyInts(){} // RVA: 0xA3D2570
        public void parseIPv6(){} // RVA: 0xA3D25F0
        public void ToAsn1Object(){} // RVA: 0xA3D2AF0
    }

    public class GeneralNames : Asn1Encodable
    {
        public object names;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3D2D50
        public void .ctor(){} // RVA: 0xA3D2F60
        public void GetNames(){} // RVA: 0xA3D3150
        public void ToAsn1Object(){} // RVA: 0xA3D31D0
        public void ToString(){} // RVA: 0xA3D3230
    }

    public class GeneralSubtree : Asn1Encodable
    {
        public object baseName;
        public object minimum;
        public object maximum;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3D39D0
        public void GetInstance(){} // RVA: 0xA3D3AD0
        public void get_Base(){} // RVA: 0xB5DBF0
        public void get_Minimum(){} // RVA: 0xA3D3BB0
        public void get_Maximum(){} // RVA: 0xA3CA910
        public void ToAsn1Object(){} // RVA: 0xA3D3C30
    }

    public class Holder : Asn1Encodable
    {
        public object baseCertificateID;
        public object entityName;
        public object objectDigestInfo;
        public object version;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3D3E80
        public void .ctor(){} // RVA: 0xA3D4780
        public void get_Version(){} // RVA: 0x1065D50
        public void get_BaseCertificateID(){} // RVA: 0xB5DBF0
        public void get_EntityName(){} // RVA: 0xB465B0
        public void get_ObjectDigestInfo(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA3D47F0
    }

    public class IetfAttrSyntax : Asn1Encodable
    {
        public object ValueOctets;
        public object ValueOid;
        public object ValueUtf8;
        public object policyAuthority;
        public object values;
        public object valueChoice;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3D4AA0
        public void get_PolicyAuthority(){} // RVA: 0xB5DBF0
        public void get_ValueType(){} // RVA: 0xFEAE90
        public void GetValues(){} // RVA: 0xA3D5130
        public void ToAsn1Object(){} // RVA: 0xA3D5650
    }

    public class IssuerSerial : Asn1Encodable
    {
        public object issuer;
        public object serial;
        public object issuerUid;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3D5AC0
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_Issuer(){} // RVA: 0xB5DBF0
        public void get_Serial(){} // RVA: 0xB465B0
        public void get_IssuerUid(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA3D5DA0
    }

    public class IssuingDistributionPoint : Asn1Encodable
    {
        public object _distributionPoint;
        public object _onlyContainsUserCerts;
        public object _onlyContainsCACerts;
        public object _onlySomeReasons;
        public object _indirectCRL;
        public object _onlyContainsAttributeCerts;
        public object seq;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3D6010
        public void .ctor(){} // RVA: 0xA3D6760
        public void get_OnlyContainsUserCerts(){} // RVA: 0xB5DD50
        public void get_OnlyContainsCACerts(){} // RVA: 0xF43F30
        public void get_IsIndirectCrl(){} // RVA: 0xF73960
        public void get_OnlyContainsAttributeCerts(){} // RVA: 0x14F7430
        public void get_DistributionPoint(){} // RVA: 0xB5DBF0
        public void get_OnlySomeReasons(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xD33E60
        public void ToString(){} // RVA: 0xA3D6AC0
        public void appendObject(){} // RVA: 0xA3D6EC0
    }

    public class KeyPurposeID : DerObjectIdentifier
    {
        public object IdKP;
        public object AnyExtendedKeyUsage;
        public object IdKPServerAuth;
        public object IdKPClientAuth;
        public object IdKPCodeSigning;
        public object IdKPEmailProtection;
        public object IdKPIpsecEndSystem;
        public object IdKPIpsecTunnel;
        public object IdKPIpsecUser;
        public object IdKPTimeStamping;
        public object IdKPOcspSigning;
        public object IdKPSmartCardLogon;
        public object IdKPMacAddress;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3D6FB0
        public void .cctor(){} // RVA: 0xA3D7010
    }

    public class KeyUsage : DerBitString
    {
        public object DigitalSignature;
        public object NonRepudiation;
        public object KeyEncipherment;
        public object DataEncipherment;
        public object KeyAgreement;
        public object KeyCertSign;
        public object CrlSign;
        public object EncipherOnly;
        public object DecipherOnly;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3D7AF0
        public void .ctor(){} // RVA: 0xA3D7D50
        public void ToString(){} // RVA: 0xA3D7E00
    }

    public class NameConstraints : Asn1Encodable
    {
        public object permitted;
        public object excluded;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3D7FF0
        public void .ctor(){} // RVA: 0xA3D8420
        public void CreateSequence(){} // RVA: 0xA3D8510
        public void get_PermittedSubtrees(){} // RVA: 0xB5DBF0
        public void get_ExcludedSubtrees(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA3D8840
    }

    public class NoticeReference : Asn1Encodable
    {
        public object organization;
        public object noticeNumbers;

        // ── Methods ──
        public void ConvertVector(){} // RVA: 0xA3D89F0
        public void .ctor(){} // RVA: 0xA3D9100
        public void GetInstance(){} // RVA: 0xA3D92D0
        public void get_Organization(){} // RVA: 0xB5DBF0
        public void GetNoticeNumbers(){} // RVA: 0xA3D93B0
        public void ToAsn1Object(){} // RVA: 0xA3D9560
    }

    public class ObjectDigestInfo : Asn1Encodable
    {
        public object PublicKey;
        public object PublicKeyCert;
        public object OtherObjectDigest;
        public object digestedObjectType;
        public object otherObjectTypeID;
        public object digestAlgorithm;
        public object objectDigest;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3D9840
        public void .ctor(){} // RVA: 0xA3D9A90
        public void get_DigestedObjectType(){} // RVA: 0xB5DBF0
        public void get_OtherObjectTypeID(){} // RVA: 0xB465B0
        public void get_DigestAlgorithm(){} // RVA: 0xB700F0
        public void get_ObjectDigest(){} // RVA: 0xB70160
        public void ToAsn1Object(){} // RVA: 0xA3D9DD0
    }

    public class PolicyInformation : Asn1Encodable
    {
        public object policyIdentifier;
        public object policyQualifiers;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void GetInstance(){} // RVA: 0xA3DA270
        public void get_PolicyIdentifier(){} // RVA: 0xB5DBF0
        public void get_PolicyQualifiers(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA3DA340
    }

    public class PolicyMappings : Asn1Encodable
    {
        public object seq;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3DA560
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class PolicyQualifierID : DerObjectIdentifier
    {
        public object IdQt;
        public object IdQtCps;
        public object IdQtUnotice;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3DABB0
        public void .cctor(){} // RVA: 0xA3DAC10
    }

    public class PolicyQualifierInfo : Asn1Encodable
    {
        public object policyQualifierId;
        public object qualifier;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3DAFF0
        public void GetInstance(){} // RVA: 0xA3DB1F0
        public void get_PolicyQualifierId(){} // RVA: 0xB5DBF0
        public void get_Qualifier(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA3DB2D0
    }

    public class PrivateKeyUsagePeriod : Asn1Encodable
    {
        public object _notBefore;
        public object _notAfter;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3DB3E0
        public void .ctor(){} // RVA: 0xA3DB640
        public void get_NotBefore(){} // RVA: 0xB5DBF0
        public void get_NotAfter(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA3DB8A0
    }

    public class ReasonFlags : DerBitString
    {
        public object Unused;
        public object KeyCompromise;
        public object CACompromise;
        public object AffiliationChanged;
        public object Superseded;
        public object CessationOfOperation;
        public object CertificateHold;
        public object PrivilegeWithdrawn;
        public object AACompromise;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3DBAB0
    }

    public class RoleSyntax : Asn1Encodable
    {
        public object roleAuthority;
        public object roleName;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3DBB60
        public void .ctor(){} // RVA: 0xA3DC160
        public void get_RoleAuthority(){} // RVA: 0xB5DBF0
        public void get_RoleName(){} // RVA: 0xB465B0
        public void GetRoleNameAsString(){} // RVA: 0xA3DC390
        public void GetRoleAuthorityAsString(){} // RVA: 0xA3DC440
        public void ToAsn1Object(){} // RVA: 0xA3DC5F0
        public void ToString(){} // RVA: 0xA3DC800
    }

    public class RsaPublicKeyStructure : Asn1Encodable
    {
        public object modulus;
        public object publicExponent;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3DCAF0
        public void .ctor(){} // RVA: 0xA3DCE50
        public void get_Modulus(){} // RVA: 0xB5DBF0
        public void get_PublicExponent(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA3DD030
    }

    public class SubjectDirectoryAttributes : Asn1Encodable
    {
        public object attributes;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3DD2F0
        public void .ctor(){} // RVA: 0xA3DD7F0
        public void ToAsn1Object(){} // RVA: 0xA3DD8E0
        public void get_Attributes(){} // RVA: 0xA3DDC50
    }

    public class SubjectKeyIdentifier : Asn1Encodable
    {
        public object keyIdentifier;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3DDD60
        public void .ctor(){} // RVA: 0xA3DE180
        public void GetKeyIdentifier(){} // RVA: 0xB5DBF0
        public void ToAsn1Object(){} // RVA: 0xA3DE1F0
        public void CreateSha1KeyIdentifier(){} // RVA: 0xA3DE2E0
        public void CreateTruncatedSha1KeyIdentifier(){} // RVA: 0xA3DE340
        public void GetDigest(){} // RVA: 0xA3DE470
    }

    public class SubjectPublicKeyInfo : Asn1Encodable
    {
        public object algID;
        public object keyData;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3DE5B0
        public void .ctor(){} // RVA: 0xA3DE8F0
        public void get_AlgorithmID(){} // RVA: 0xB5DBF0
        public void ParsePublicKey(){} // RVA: 0xA3DEB00
        public void GetPublicKey(){} // RVA: 0xA3DEB00
        public void get_PublicKeyData(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA3DEB40
    }

    public class Target : Asn1Encodable
    {
        public object targetName;
        public object targetGroup;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3DEC50
        public void .ctor(){} // RVA: 0xA3DF020
        public void get_TargetGroup(){} // RVA: 0xB465B0
        public void get_TargetName(){} // RVA: 0xB5DBF0
        public void ToAsn1Object(){} // RVA: 0xA3DF0E0
    }

    public class TargetInformation : Asn1Encodable
    {
        public object targets;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3DF270
        public void .ctor(){} // RVA: 0xA3DF6F0
        public void GetTargetsObjects(){} // RVA: 0xA3DF480
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class Targets : Asn1Encodable
    {
        public object targets;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3DF870
        public void .ctor(){} // RVA: 0xA3DFA80
        public void GetTargets(){} // RVA: 0xA3DFB40
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class TbsCertificateList : Asn1Encodable
    {
        public object seq;
        public object version;
        public object signature;
        public object issuer;
        public object thisUpdate;
        public object nextUpdate;
        public object revokedCertificates;
        public object crlExtensions;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3E0E50
        public void .ctor(){} // RVA: 0xA3E0FF0
        public void get_Version(){} // RVA: 0xA3E0A60
        public void get_VersionNumber(){} // RVA: 0xB465B0
        public void get_Signature(){} // RVA: 0xB700F0
        public void get_Issuer(){} // RVA: 0xB70160
        public void get_ThisUpdate(){} // RVA: 0xD33E60
        public void get_NextUpdate(){} // RVA: 0xD05CA0
        public void GetRevokedCertificates(){} // RVA: 0xA3E1660
        public void GetRevokedCertificateEnumeration(){} // RVA: 0xA3E1830
        public void get_Extensions(){} // RVA: 0xBBF8F0
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class TbsCertificateStructure : Asn1Encodable
    {
        public object seq;
        public object version;
        public object serialNumber;
        public object signature;
        public object issuer;
        public object startDate;
        public object endDate;
        public object subject;
        public object subjectPublicKeyInfo;
        public object issuerUniqueID;
        public object subjectUniqueID;
        public object extensions;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3DFEC0
        public void .ctor(){} // RVA: 0xA3DFFA0
        public void get_Version(){} // RVA: 0xA3E0A60
        public void get_VersionNumber(){} // RVA: 0xB465B0
        public void get_SerialNumber(){} // RVA: 0xB700F0
        public void get_Signature(){} // RVA: 0xB70160
        public void get_Issuer(){} // RVA: 0xD33E60
        public void get_StartDate(){} // RVA: 0xD05CA0
        public void get_EndDate(){} // RVA: 0xBC1B30
        public void get_Subject(){} // RVA: 0xBBF8F0
        public void get_SubjectPublicKeyInfo(){} // RVA: 0xBE58B0
        public void get_IssuerUniqueID(){} // RVA: 0xC0FFC0
        public void get_SubjectUniqueID(){} // RVA: 0xBE2C60
        public void get_Extensions(){} // RVA: 0xBBFF90
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class Time : Asn1Encodable
    {
        public object time;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3E2090
        public void .ctor(){} // RVA: 0xA3E1CF0
        public void GetTime(){} // RVA: 0xA3E22E0
        public void ToDateTime(){} // RVA: 0xA3E23F0
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
        public void ToString(){} // RVA: 0xA3E25D0
    }

    public class UserNotice : Asn1Encodable
    {
        public object noticeRef;
        public object explicitText;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3E2700
        public void GetInstance(){} // RVA: 0xA3E2A40
        public void get_NoticeRef(){} // RVA: 0xB5DBF0
        public void get_ExplicitText(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA3E2B20
    }

    public class V1TbsCertificateGenerator : Object
    {
        public object version;
        public object serialNumber;
        public object signature;
        public object issuer;
        public object startDate;
        public object endDate;
        public object subject;
        public object subjectPublicKeyInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3E2D00
        public void SetSerialNumber(){} // RVA: 0xBA9BA0
        public void SetSignature(){} // RVA: 0xB70100
        public void SetIssuer(){} // RVA: 0xB44DC0
        public void SetStartDate(){} // RVA: 0xA3E2E30
        public void SetEndDate(){} // RVA: 0xA3E2EF0
        public void SetSubject(){} // RVA: 0xB6A8C0
        public void SetSubjectPublicKeyInfo(){} // RVA: 0xBBF900
        public void GenerateTbsCertificate(){} // RVA: 0xA3E2FB0
    }

    public class V2AttributeCertificateInfoGenerator : Object
    {
        public object version;
        public object holder;
        public object issuer;
        public object signature;
        public object serialNumber;
        public object attributes;
        public object issuerUniqueID;
        public object extensions;
        public object startDate;
        public object endDate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3E3350
        public void SetHolder(){} // RVA: 0xBA9BA0
        public void AddAttribute(){} // RVA: 0xA3E3580
        public void SetSerialNumber(){} // RVA: 0xB708C0
        public void SetSignature(){} // RVA: 0xB44DC0
        public void SetIssuer(){} // RVA: 0xB70100
        public void SetStartDate(){} // RVA: 0xCA4DF0
        public void SetEndDate(){} // RVA: 0xC0FFD0
        public void SetIssuerUniqueID(){} // RVA: 0xB6A8C0
        public void SetExtensions(){} // RVA: 0xBBF900
        public void GenerateAttributeCertificateInfo(){} // RVA: 0xA3E35A0
    }

    public class V2Form : Asn1Encodable
    {
        public object issuerName;
        public object baseCertificateID;
        public object objectDigestInfo;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3E39C0
        public void .ctor(){} // RVA: 0xA3E3B00
        public void get_IssuerName(){} // RVA: 0xB5DBF0
        public void get_BaseCertificateID(){} // RVA: 0xB465B0
        public void get_ObjectDigestInfo(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA3E3DF0
    }

    public class V2TbsCertListGenerator : Object
    {
        public object version;
        public object signature;
        public object issuer;
        public object thisUpdate;
        public object nextUpdate;
        public object extensions;
        public object crlEntries;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3E4060
        public void SetSignature(){} // RVA: 0xBA9BA0
        public void SetIssuer(){} // RVA: 0xB70100
        public void SetThisUpdate(){} // RVA: 0xB44DC0
        public void SetNextUpdate(){} // RVA: 0xB708C0
        public void AddCrlEntry(){} // RVA: 0xA3E4B00
        public void SetExtensions(){} // RVA: 0xD09D70
        public void GenerateTbsCertList(){} // RVA: 0xA3E4D40
    }

    public class V3TbsCertificateGenerator : Object
    {
        public object version;
        public object serialNumber;
        public object signature;
        public object issuer;
        public object startDate;
        public object endDate;
        public object subject;
        public object subjectPublicKeyInfo;
        public object extensions;
        public object altNamePresentAndCritical;
        public object issuerUniqueID;
        public object subjectUniqueID;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3E5410
        public void SetSerialNumber(){} // RVA: 0xBA9BA0
        public void SetSignature(){} // RVA: 0xB70100
        public void SetIssuer(){} // RVA: 0xB44DC0
        public void SetStartDate(){} // RVA: 0xB708C0
        public void SetEndDate(){} // RVA: 0xD09D70
        public void SetSubject(){} // RVA: 0xB6A8C0
        public void SetIssuerUniqueID(){} // RVA: 0xBE2C70
        public void SetSubjectUniqueID(){} // RVA: 0xBBFFA0
        public void SetSubjectPublicKeyInfo(){} // RVA: 0xBBF900
        public void SetExtensions(){} // RVA: 0xA3E56C0
        public void GenerateTbsCertificate(){} // RVA: 0xA3E57A0
    }

    public class X509Attributes : Object
    {
        public object RoleSyntax;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA3E5C80
    }

    public class X509CertificateStructure : Asn1Encodable
    {
        public object tbsCert;
        public object sigAlgID;
        public object sig;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3E5D80
        public void .ctor(){} // RVA: 0xA3E5F90
        public void get_TbsCertificate(){} // RVA: 0xB5DBF0
        public void get_Version(){} // RVA: 0xA3CBB70
        public void get_SerialNumber(){} // RVA: 0x13F92B0
        public void get_Issuer(){} // RVA: 0x13F9420
        public void get_StartDate(){} // RVA: 0x13F93E0
        public void get_EndDate(){} // RVA: 0x13F9A90
        public void get_Subject(){} // RVA: 0x17EF240
        public void get_SubjectPublicKeyInfo(){} // RVA: 0x17F09D0
        public void get_SignatureAlgorithm(){} // RVA: 0xB465B0
        public void get_Signature(){} // RVA: 0xB700F0
        public void GetSignatureOctets(){} // RVA: 0x718D460
        public void ToAsn1Object(){} // RVA: 0xA3E61E0
    }

    public class X509CertificateStructure[] : Array
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

    public class X509DefaultEntryConverter : X509NameEntryConverter
    {
        // ── Methods ──
        public void GetConvertedValue(){} // RVA: 0xA3E6340
        public void .ctor(){} // RVA: 0xB43310
    }

    public class X509Extension : Object
    {
        public object critical;
        public object value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x661E600
        public void get_IsCritical(){} // RVA: 0xC120A0
        public void get_Value(){} // RVA: 0xB465B0
        public void GetParsedValue(){} // RVA: 0xA3E6A60
        public void GetHashCode(){} // RVA: 0xA3E6A70
        public void Equals(){} // RVA: 0xA3E6AB0
        public void ConvertValueToObject(){} // RVA: 0xA3E6B60
    }

    public class X509Extensions : Asn1Encodable
    {
        public object SubjectDirectoryAttributes;
        public object SubjectKeyIdentifier;
        public object KeyUsage;
        public object PrivateKeyUsagePeriod;
        public object SubjectAlternativeName;
        public object IssuerAlternativeName;
        public object BasicConstraints;
        public object CrlNumber;
        public object ReasonCode;
        public object InstructionCode;
        public object InvalidityDate;
        public object DeltaCrlIndicator;
        public object IssuingDistributionPoint;
        public object CertificateIssuer;
        public object NameConstraints;
        public object CrlDistributionPoints;
        public object CertificatePolicies;
        public object PolicyMappings;
        public object AuthorityKeyIdentifier;
        public object PolicyConstraints;
        public object ExtendedKeyUsage;
        public object FreshestCrl;
        public object InhibitAnyPolicy;
        public object AuthorityInfoAccess;
        public object SubjectInfoAccess;
        public object LogoType;
        public object BiometricInfo;
        public object QCStatements;
        public object AuditIdentity;
        public object NoRevAvail;
        public object TargetInformation;
        public object ExpiredCertsOnCrl;
        public object extensions;
        public object ordering;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA3E6C90
        public void .ctor(){} // RVA: 0xA3E8730
        public void Oids(){} // RVA: 0xA3E8C00
        public void get_ExtensionOids(){} // RVA: 0xA3E8C60
        public void GetExtension(){} // RVA: 0xA3E8D50
        public void ToAsn1Object(){} // RVA: 0xA3E8E00
        public void Equivalent(){} // RVA: 0xA3E93F0
        public void GetExtensionOids(){} // RVA: 0xA3E97C0
        public void GetNonCriticalExtensionOids(){} // RVA: 0xA3E97A0
        public void GetCriticalExtensionOids(){} // RVA: 0xA3E97B0
        public void ToOidArray(){} // RVA: 0xA3E9C40
        public void .cctor(){} // RVA: 0xA3E9CE0
    }

    public class X509ExtensionsGenerator : Object
    {
        public object extensions;
        public object extOrdering;

        // ── Methods ──
        public void Reset(){} // RVA: 0xA3EB150
        public void AddExtension(){} // RVA: 0xA3EB3F0
        public void get_IsEmpty(){} // RVA: 0xA3EB6B0
        public void Generate(){} // RVA: 0xA3EB710
        public void .ctor(){} // RVA: 0xA3EB780
    }

    public class X509Name : Asn1Encodable
    {
        public object C;
        public object O;
        public object OU;
        public object T;
        public object CN;
        public object Street;
        public object SerialNumber;
        public object L;
        public object ST;
        public object Surname;
        public object GivenName;
        public object Initials;
        public object Generation;
        public object UniqueIdentifier;
        public object BusinessCategory;
        public object PostalCode;
        public object DnQualifier;
        public object Pseudonym;
        public object DateOfBirth;
        public object PlaceOfBirth;
        public object Gender;
        public object CountryOfCitizenship;
        public object CountryOfResidence;
        public object NameAtBirth;
        public object PostalAddress;
        public object DmdName;
        public object TelephoneNumber;
        public object OrganizationIdentifier;
        public object Name;
        public object EmailAddress;
        public object UnstructuredName;
        public object UnstructuredAddress;
        public object E;
        public object DC;
        public object UID;
        public object defaultReverse;
        public object DefaultSymbols;
        public object RFC2253Symbols;
        public object RFC1779Symbols;
        public object DefaultLookup;
        public object ordering;
        public object converter;
        public object values;
        public object added;
        public object seq;

        // ── Methods ──
        public void get_DefaultReverse(){} // RVA: 0xA3EB910
        public void set_DefaultReverse(){} // RVA: 0xA3EB990
        public void .cctor(){} // RVA: 0xA3EBA10
        public void GetInstance(){} // RVA: 0xA3EE9B0
        public void .ctor(){} // RVA: 0xA3F07A0
        public void DecodeOid(){} // RVA: 0xA3F05A0
        public void GetOidList(){} // RVA: 0xA3F11D0
        public void GetValueList(){} // RVA: 0xA3F1280
        public void ToAsn1Object(){} // RVA: 0xA3F1520
        public void Equivalent(){} // RVA: 0xA3F1E80
        public void equivalentStrings(){} // RVA: 0xA3F2270
        public void canonicalize(){} // RVA: 0xA3F23A0
        public void decodeObject(){} // RVA: 0xA3F2540
        public void stripInternalSpaces(){} // RVA: 0xA3F2670
        public void AppendValue(){} // RVA: 0xA3F2790
        public void ToString(){} // RVA: 0xA3F3000
    }

    public class X509NameEntryConverter : Object
    {
        // ── Methods ──
        public void ConvertHexEncoded(){} // RVA: 0xA3F3070
        public void CanBePrintable(){} // RVA: 0xA3F3100
        public void GetConvertedValue(){} // RVA: 0x87C5F0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class X509NameTokenizer : Object
    {
        public object value;
        public object index;
        public object separator;
        public object buffer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA3F3120
        public void HasMoreTokens(){} // RVA: 0xA3F3240
        public void NextToken(){} // RVA: 0xA3F3270
    }

    public class X509ObjectIdentifiers : Object
    {
        public object ID;
        public object CommonName;
        public object CountryName;
        public object LocalityName;
        public object StateOrProvinceName;
        public object Organization;
        public object OrganizationalUnitName;
        public object id_at_telephoneNumber;
        public object id_at_name;
        public object id_at_organizationIdentifier;
        public object IdSha1;
        public object RipeMD160;
        public object RipeMD160WithRsaEncryption;
        public object IdEARsa;
        public object IdPkix;
        public object IdPE;
        public object IdAD;
        public object IdADCAIssuers;
        public object IdADOcsp;
        public object OcspAccessMethod;
        public object CrlAccessMethod;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA3F3470
    }

}