// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
// Classes: 47
// Methods: 373

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
{
    public class Attribute
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier attrType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set attrValues; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97C97D0
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void get_AttrType(){} // RVA: 0x2F8380
        public void get_AttrValues(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97C9C00
    }

    public class AttributeTable
    {
        public System.Collections.IDictionary Version; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97CA650 | overloaded x5
        public void AddAttribute(){} // RVA: 0x97CA6A0
        public void get_Item(){} // RVA: 0x97CA890
        public void Get(){} // RVA: 0x97CAA30
        public void GetAll(){} // RVA: 0x97CAA40
        public void get_Count(){} // RVA: 0x97CADF0
        public void ToDictionary(){} // RVA: 0x97CB0C0
        public void ToHashtable(){} // RVA: 0x97CB120
        public void ToAsn1EncodableVector(){} // RVA: 0x97CB190
        public void ToAttributes(){} // RVA: 0x97CB510
        public void Add(){} // RVA: 0x97CB610
        public void Remove(){} // RVA: 0x97CB700
    }

    public class Attributes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97C9D10 | overloaded x2
        public void GetInstance(){} // RVA: 0x97C9DD0
        public void GetAttributes(){} // RVA: 0x97C9EF0
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class AuthEnvelopedData
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.OriginatorInfo originatorInfo; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set recipientInfos; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo authEncryptedContentInfo; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set authAttrs; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString mac; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set unauthAttrs; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97CDEB0 | overloaded x2
        public void GetInstance(){} // RVA: 0x97CE540 | overloaded x2
        public void get_Version(){} // RVA: 0x2F8380
        public void get_OriginatorInfo(){} // RVA: 0x2E07C0
        public void get_RecipientInfos(){} // RVA: 0x30B0C0
        public void get_AuthEncryptedContentInfo(){} // RVA: 0x30B130
        public void get_AuthAttrs(){} // RVA: 0x6374D0
        public void get_Mac(){} // RVA: 0x4976A0
        public void get_UnauthAttrs(){} // RVA: 0x35A740
        public void ToAsn1Object(){} // RVA: 0x97CE700
    }

    public class AuthEnvelopedDataParser
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1SequenceParser seq; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97CEA00
        public void get_Version(){} // RVA: 0x2E07C0
        public void GetOriginatorInfo(){} // RVA: 0x97CEBA0
        public void GetRecipientInfos(){} // RVA: 0x97CEE60
        public void GetAuthEncryptedContentInfo(){} // RVA: 0x97CEFD0
        public void GetAuthAttrs(){} // RVA: 0x97CF160
        public void GetMac(){} // RVA: 0x97CF360
        public void GetUnauthAttrs(){} // RVA: 0x97CF4A0
    }

    public class AuthenticatedData
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.OriginatorInfo originatorInfo; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set recipientInfos; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier macAlgorithm; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digestAlgorithm; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo encapsulatedContentInfo; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set authAttrs; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString mac; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set unauthAttrs; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97CBBA0 | overloaded x2
        public void GetInstance(){} // RVA: 0x97CC2C0 | overloaded x2
        public void get_Version(){} // RVA: 0x2F8380
        public void get_OriginatorInfo(){} // RVA: 0x2E07C0
        public void get_RecipientInfos(){} // RVA: 0x30B0C0
        public void get_MacAlgorithm(){} // RVA: 0x30B130
        public void get_DigestAlgorithm(){} // RVA: 0x6374D0
        public void get_EncapsulatedContentInfo(){} // RVA: 0x4976A0
        public void get_AuthAttrs(){} // RVA: 0x35A740
        public void get_Mac(){} // RVA: 0x358730
        public void get_UnauthAttrs(){} // RVA: 0x37E0E0
        public void ToAsn1Object(){} // RVA: 0x97CC480
        public void CalculateVersion(){} // RVA: 0x97CC7F0
    }

    public class AuthenticatedDataParser
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1SequenceParser Version; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97CCBD0
        public void get_Version(){} // RVA: 0x2E07C0
        public void GetOriginatorInfo(){} // RVA: 0x97CCD70
        public void GetRecipientInfos(){} // RVA: 0x97CD030
        public void GetMacAlgorithm(){} // RVA: 0x97CD1A0
        public void GetDigestAlgorithm(){} // RVA: 0x97CD340
        public void GetEnapsulatedContentInfo(){} // RVA: 0x97CD520
        public void GetAuthAttrs(){} // RVA: 0x97CD6B0
        public void GetMac(){} // RVA: 0x97CD8B0
        public void GetUnauthAttrs(){} // RVA: 0x97CD9F0
    }

    public class CmsAttributes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x97CF6A0
    }

    public class CmsObjectIdentifiers
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x97CF980
    }

    public class CompressedData
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier compressionAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo encapContentInfo; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97D0270 | overloaded x2
        public void GetInstance(){} // RVA: 0x97D04D0 | overloaded x2
        public void get_Version(){} // RVA: 0x2F8380
        public void get_CompressionAlgorithmIdentifier(){} // RVA: 0x2E07C0
        public void get_EncapContentInfo(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97D0690
    }

    public class CompressedDataParser
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger ContentType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Content; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97D0820
        public void get_Version(){} // RVA: 0x2F8380
        public void get_CompressionAlgorithmIdentifier(){} // RVA: 0x2E07C0
        public void GetEncapContentInfo(){} // RVA: 0x30B0C0
    }

    public class ContentInfo
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier contentType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable content; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97D0CB0 | overloaded x2
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void get_ContentType(){} // RVA: 0x2F8380
        public void get_Content(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97D1000
    }

    public class ContentInfoParser
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ContentType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97D11B0
        public void get_ContentType(){} // RVA: 0x2F8380
        public void GetContent(){} // RVA: 0x97D13E0
    }

    public class EncryptedContentInfo
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier contentType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier contentEncryptionAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString encryptedContent; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97D1450 | overloaded x2
        public void GetInstance(){} // RVA: 0x97D17B0
        public void get_ContentType(){} // RVA: 0x2F8380
        public void get_ContentEncryptionAlgorithm(){} // RVA: 0x2E07C0
        public void get_EncryptedContent(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97D1970
    }

    public class EncryptedContentInfoParser
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier EncryptedContentInfo; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97D1B20
        public void get_ContentType(){} // RVA: 0x2F8380
        public void get_ContentEncryptionAlgorithm(){} // RVA: 0x2E07C0
        public void GetEncryptedContent(){} // RVA: 0x97D1DE0
    }

    public class EncryptedData
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo encryptedContentInfo; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set unprotectedAttrs; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97D1E40
        public void .ctor(){} // RVA: 0x97D21F0 | overloaded x3
        public void get_Version(){} // RVA: 0x2F8380
        public void get_EncryptedContentInfo(){} // RVA: 0x2E07C0
        public void get_UnprotectedAttrs(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97D2440
    }

    public class EnvelopedData
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.OriginatorInfo originatorInfo; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set recipientInfos; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo encryptedContentInfo; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set unprotectedAttrs; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97D2A80 | overloaded x3
        public void GetInstance(){} // RVA: 0x97D2ED0 | overloaded x2
        public void get_Version(){} // RVA: 0x2F8380
        public void get_OriginatorInfo(){} // RVA: 0x2E07C0
        public void get_RecipientInfos(){} // RVA: 0x30B0C0
        public void get_EncryptedContentInfo(){} // RVA: 0x30B130
        public void get_UnprotectedAttrs(){} // RVA: 0x6374D0
        public void ToAsn1Object(){} // RVA: 0x97D2FB0
        public void CalculateVersion(){} // RVA: 0x97D3240
    }

    public class EnvelopedDataParser
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1SequenceParser TstEvidence; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97D3470
        public void get_Version(){} // RVA: 0x2E07C0
        public void GetOriginatorInfo(){} // RVA: 0x97D3610
        public void GetRecipientInfos(){} // RVA: 0x97D38D0
        public void GetEncryptedContentInfo(){} // RVA: 0x97D3A40
        public void GetUnprotectedAttrs(){} // RVA: 0x97D3BD0
    }

    public class Evidence : .ctor
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.TimeStampTokenEvidence tstEvidence; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97D3DD0 | overloaded x2
        public void GetInstance(){} // RVA: 0x97D41C0 | overloaded x2
        public void get_TstEvidence(){} // RVA: 0x2F8380
        public void ToAsn1Object(){} // RVA: 0x97D4210
    }

    public class IssuerAndSerialNumber
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name name; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger serialNumber; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97D42A0
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x3
        public void get_Name(){} // RVA: 0x2F8380
        public void get_SerialNumber(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97D4720
    }

    public class KekIdentifier
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString keyIdentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime date; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.OtherKeyAttribute other; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97D4A40 | overloaded x2
        public void GetInstance(){} // RVA: 0x97D4EF0 | overloaded x2
        public void get_KeyIdentifier(){} // RVA: 0x2F8380
        public void get_Date(){} // RVA: 0x2E07C0
        public void get_Other(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97D50B0
    }

    public class KekRecipientInfo
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.KekIdentifier kekID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncryptionAlgorithm; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97D54B0 | overloaded x2
        public void GetInstance(){} // RVA: 0x97D59B0 | overloaded x2
        public void get_Version(){} // RVA: 0x2F8380
        public void get_KekID(){} // RVA: 0x2E07C0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0x30B0C0
        public void get_EncryptedKey(){} // RVA: 0x30B130
        public void ToAsn1Object(){} // RVA: 0x97D5B70
    }

    public class KeyAgreeRecipientIdentifier
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber issuerSerial; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.RecipientKeyIdentifier rKeyID; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97D5D30 | overloaded x2
        public void .ctor(){} // RVA: 0x343E80 | overloaded x2
        public void get_IssuerAndSerialNumber(){} // RVA: 0x2F8380
        public void get_RKeyID(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97D6080
    }

    public class KeyAgreeRecipientInfo
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.OriginatorIdentifierOrKey originator; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString ukm; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncryptionAlgorithm; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence recipientEncryptedKeys; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97D6330 | overloaded x2
        public void GetInstance(){} // RVA: 0x97D6A20 | overloaded x2
        public void get_Version(){} // RVA: 0x2F8380
        public void get_Originator(){} // RVA: 0x2E07C0
        public void get_UserKeyingMaterial(){} // RVA: 0x30B0C0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0x30B130
        public void get_RecipientEncryptedKeys(){} // RVA: 0x6374D0
        public void ToAsn1Object(){} // RVA: 0x97D6BE0
    }

    public class KeyTransRecipientInfo
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.RecipientIdentifier rid; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncryptionAlgorithm; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97D7250 | overloaded x2
        public void GetInstance(){} // RVA: 0x97D7580
        public void get_Version(){} // RVA: 0x2F8380
        public void get_RecipientIdentifier(){} // RVA: 0x2E07C0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0x30B0C0
        public void get_EncryptedKey(){} // RVA: 0x30B130
        public void ToAsn1Object(){} // RVA: 0x97D7740
    }

    public class MetaData
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBoolean hashProtected; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerUtf8String fileName; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerIA5String mediaType; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.Attributes otherMetaData; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97D78E0 | overloaded x2
        public void GetInstance(){} // RVA: 0x97D7D80
        public void ToAsn1Object(){} // RVA: 0x97D7E60
        public void get_IsHashProtected(){} // RVA: 0x97D80E0
        public void get_FileName(){} // RVA: 0x2E07C0
        public void get_MediaType(){} // RVA: 0x30B0C0
        public void get_OtherMetaData(){} // RVA: 0x30B130
    }

    public class OriginatorIdentifierOrKey
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable id; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x6
        public void GetInstance(){} // RVA: 0x97D8430 | overloaded x2
        public void get_ID(){} // RVA: 0x2F8380
        public void get_IssuerAndSerialNumber(){} // RVA: 0x97D8870
        public void get_SubjectKeyIdentifier(){} // RVA: 0x97D8910
        public void get_OriginatorKey(){} // RVA: 0x97D8A80
        public void get_OriginatorPublicKey(){} // RVA: 0x97D8A90
        public void ToAsn1Object(){} // RVA: 0x7F0250
    }

    public class OriginatorInfo
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set certs; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set crls; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97D8B50 | overloaded x2
        public void GetInstance(){} // RVA: 0x97D8F10 | overloaded x2
        public void get_Certificates(){} // RVA: 0x2F8380
        public void get_Crls(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97D90D0
    }

    public class OriginatorPublicKey
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier mAlgorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString mPublicKey; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97D93A0 | overloaded x2
        public void GetInstance(){} // RVA: 0x97D9520 | overloaded x2
        public void get_Algorithm(){} // RVA: 0x2F8380
        public void get_PublicKey(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97D97F0
    }

    public class OtherKeyAttribute
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier keyAttrId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable keyAttr; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97D9900
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void get_KeyAttrId(){} // RVA: 0x2F8380
        public void get_KeyAttr(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97D9CA0
    }

    public class OtherRecipientInfo
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier oriType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable oriValue; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97D9DB0 | overloaded x2
        public void GetInstance(){} // RVA: 0x97D9F20 | overloaded x2
        public void get_OriType(){} // RVA: 0x2F8380
        public void get_OriValue(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97DA100
    }

    public class OtherRevocationInfoFormat
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier otherRevInfoFormat; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable otherRevInfo; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97DA210 | overloaded x2
        public void GetInstance(){} // RVA: 0x97DA380 | overloaded x2
        public void get_InfoFormat(){} // RVA: 0x2F8380
        public void get_Info(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97DA5A0
    }

    public class PasswordRecipientInfo
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyDerivationAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncryptionAlgorithm; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97DA9E0 | overloaded x3
        public void GetInstance(){} // RVA: 0x97DB150 | overloaded x2
        public void get_Version(){} // RVA: 0x2F8380
        public void get_KeyDerivationAlgorithm(){} // RVA: 0x2E07C0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0x30B0C0
        public void get_EncryptedKey(){} // RVA: 0x30B130
        public void ToAsn1Object(){} // RVA: 0x97DB310
    }

    public class RecipientEncryptedKey
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientIdentifier identifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void GetInstance(){} // RVA: 0x97DB760 | overloaded x2
        public void get_Identifier(){} // RVA: 0x2F8380
        public void get_EncryptedKey(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97DB930
    }

    public class RecipientIdentifier
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable id; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void GetInstance(){} // RVA: 0x97DBB10
        public void get_IsTagged(){} // RVA: 0x97DBE50
        public void get_ID(){} // RVA: 0x97DBEE0
        public void ToAsn1Object(){} // RVA: 0x7F0250
    }

    public class RecipientInfo
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable info; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x6
        public void GetInstance(){} // RVA: 0x97DC420
        public void get_Version(){} // RVA: 0x97DC670
        public void get_IsTagged(){} // RVA: 0x97DC810
        public void get_Info(){} // RVA: 0x97DC8A0
        public void GetKekInfo(){} // RVA: 0x97DCA20
        public void ToAsn1Object(){} // RVA: 0x7F0250
    }

    public class RecipientKeyIdentifier
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString subjectKeyIdentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime date; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.OtherKeyAttribute other; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97DCC80 | overloaded x4
        public void GetInstance(){} // RVA: 0x97DD250 | overloaded x2
        public void get_SubjectKeyIdentifier(){} // RVA: 0x2F8380
        public void get_Date(){} // RVA: 0x2E07C0
        public void get_OtherKeyAttribute(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97DD410
    }

    public class ScvpReqRes
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo request; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo response; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97DD650
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x3
        public void get_Request(){} // RVA: 0x2F8380
        public void get_Response(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97DD9C0
    }

    public class SignedData
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version1;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version3; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version4; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version5; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set digestAlgorithms; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97DDB90
        public void .ctor(){} // RVA: 0x97DE780 | overloaded x2
        public void CalculateVersion(){} // RVA: 0x97DE090
        public void CheckForVersion3(){} // RVA: 0x97DE590
        public void get_Version(){} // RVA: 0x2F8380
        public void get_DigestAlgorithms(){} // RVA: 0x2E07C0
        public void get_EncapContentInfo(){} // RVA: 0x30B0C0
        public void get_Certificates(){} // RVA: 0x30B130
        public void get_CRLs(){} // RVA: 0x6374D0
        public void get_SignerInfos(){} // RVA: 0x4976A0
        public void ToAsn1Object(){} // RVA: 0x97DEDA0
        public void .cctor(){} // RVA: 0x97DF030
    }

    public class SignedDataParser
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1SequenceParser IsTagged; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97DF2C0
        public void .ctor(){} // RVA: 0x97DF4B0
        public void get_Version(){} // RVA: 0x2E07C0
        public void GetDigestAlgorithms(){} // RVA: 0x97DF650
        public void GetEncapContentInfo(){} // RVA: 0x97DF6F0
        public void GetCertificates(){} // RVA: 0x97DF7C0
        public void GetCrls(){} // RVA: 0x97DFA40
        public void GetSignerInfos(){} // RVA: 0x97DFCC0
    }

    public class SignerIdentifier
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable id; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void GetInstance(){} // RVA: 0x97DFEA0
        public void get_IsTagged(){} // RVA: 0x97E01E0
        public void get_ID(){} // RVA: 0x97E0270
        public void ToAsn1Object(){} // RVA: 0x7F0250
    }

    public class SignerInfo
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.SignerIdentifier sid; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digAlgorithm; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set authenticatedAttributes; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digEncryptionAlgorithm; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString encryptedDigest; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set unauthenticatedAttributes; // 0x40

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97E03C0
        public void .ctor(){} // RVA: 0x97E0B80 | overloaded x3
        public void get_Version(){} // RVA: 0x2F8380
        public void get_SignerID(){} // RVA: 0x2E07C0
        public void get_AuthenticatedAttributes(){} // RVA: 0x30B130
        public void get_DigestAlgorithm(){} // RVA: 0x30B0C0
        public void get_EncryptedDigest(){} // RVA: 0x4976A0
        public void get_DigestEncryptionAlgorithm(){} // RVA: 0x6374D0
        public void get_UnauthenticatedAttributes(){} // RVA: 0x35A740
        public void ToAsn1Object(){} // RVA: 0x97E1220
    }

    public class Time
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object time; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97E1A30 | overloaded x2
        public void .ctor(){} // RVA: 0x97E1760 | overloaded x2
        public void get_TimeString(){} // RVA: 0x97E1C80
        public void get_Date(){} // RVA: 0x97E1DA0
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class TimeStampAndCrl
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo timeStamp; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.CertificateList crl; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97E1FB0 | overloaded x2
        public void GetInstance(){} // RVA: 0x97E20F0
        public void get_TimeStampToken(){} // RVA: 0x2F8380
        public void get_Crl(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97E22F0
    }

    public class TimeStampTokenEvidence
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97E35B0 | overloaded x3
        public void GetInstance(){} // RVA: 0x97E3A40 | overloaded x2
        public void ToTimeStampAndCrlArray(){} // RVA: 0x97E3B20
        public void ToAsn1Object(){} // RVA: 0x97E3BA0
    }

    public class TimeStampedData
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerIA5String dataUri; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.MetaData metaData; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString content; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97E2700 | overloaded x2
        public void GetInstance(){} // RVA: 0x97E2B50
        public void get_DataUri(){} // RVA: 0x2E07C0
        public void get_MetaData(){} // RVA: 0x30B0C0
        public void get_Content(){} // RVA: 0x30B130
        public void get_TemporalEvidence(){} // RVA: 0x6374D0
        public void ToAsn1Object(){} // RVA: 0x97E2C30
    }

    public class TimeStampedDataParser
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerIA5String dataUri; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.MetaData metaData; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97E2E70
        public void GetInstance(){} // RVA: 0x97E3260
        public void get_DataUri(){} // RVA: 0x2E07C0
        public void get_MetaData(){} // RVA: 0x30B0C0
        public void get_Content(){} // RVA: 0x30B130
        public void GetTemporalEvidence(){} // RVA: 0x97E33E0
    }

}