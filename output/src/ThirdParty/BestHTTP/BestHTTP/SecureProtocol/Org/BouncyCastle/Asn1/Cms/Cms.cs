// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
// Classes: 47
// Methods: 373

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
{
    public class Attribute : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier attrType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set attrValues; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A22BBD0
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void get_AttrType(){} // RVA: 0x7FFE81116380
        public void get_AttrValues(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A22C000
    }

    public class AttributeTable : Object
    {
        public System.Collections.IDictionary attributes; // 0x10
        public object field_1; // 0x875

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A22CA50 | overloaded x5
        public void AddAttribute(){} // RVA: 0x7FFE8A22CAA0
        public void get_Item(){} // RVA: 0x7FFE8A22CC90
        public void Get(){} // RVA: 0x7FFE8A22CE30
        public void GetAll(){} // RVA: 0x7FFE8A22CE40
        public void get_Count(){} // RVA: 0x7FFE8A22D1F0
        public void ToDictionary(){} // RVA: 0x7FFE8A22D4C0
        public void ToHashtable(){} // RVA: 0x7FFE8A22D520
        public void ToAsn1EncodableVector(){} // RVA: 0x7FFE8A22D590
        public void ToAttributes(){} // RVA: 0x7FFE8A22D910
        public void Add(){} // RVA: 0x7FFE8A22DA10
        public void Remove(){} // RVA: 0x7FFE8A22DB00
    }

    public class Attributes : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A22C110 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A22C1D0
        public void GetAttributes(){} // RVA: 0x7FFE8A22C2F0
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class AuthEnvelopedData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.OriginatorInfo originatorInfo; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set recipientInfos; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo authEncryptedContentInfo; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set authAttrs; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString mac; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set unauthAttrs; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2302B0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A230940 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFE81116380
        public void get_OriginatorInfo(){} // RVA: 0x7FFE810FE7C0
        public void get_RecipientInfos(){} // RVA: 0x7FFE811290C0
        public void get_AuthEncryptedContentInfo(){} // RVA: 0x7FFE81129130
        public void get_AuthAttrs(){} // RVA: 0x7FFE8144E200
        public void get_Mac(){} // RVA: 0x7FFE8143BA80
        public void get_UnauthAttrs(){} // RVA: 0x7FFE81178740
        public void ToAsn1Object(){} // RVA: 0x7FFE8A230B00
    }

    public class AuthEnvelopedDataParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1SequenceParser seq; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A230E00
        public void get_Version(){} // RVA: 0x7FFE810FE7C0
        public void GetOriginatorInfo(){} // RVA: 0x7FFE8A230FA0
        public void GetRecipientInfos(){} // RVA: 0x7FFE8A231260
        public void GetAuthEncryptedContentInfo(){} // RVA: 0x7FFE8A2313D0
        public void GetAuthAttrs(){} // RVA: 0x7FFE8A231560
        public void GetMac(){} // RVA: 0x7FFE8A231760
        public void GetUnauthAttrs(){} // RVA: 0x7FFE8A2318A0
    }

    public class AuthenticatedData : Asn1Encodable
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
        public void .ctor(){} // RVA: 0x7FFE8A22DFA0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A22E6C0 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFE81116380
        public void get_OriginatorInfo(){} // RVA: 0x7FFE810FE7C0
        public void get_RecipientInfos(){} // RVA: 0x7FFE811290C0
        public void get_MacAlgorithm(){} // RVA: 0x7FFE81129130
        public void get_DigestAlgorithm(){} // RVA: 0x7FFE8144E200
        public void get_EncapsulatedContentInfo(){} // RVA: 0x7FFE8143BA80
        public void get_AuthAttrs(){} // RVA: 0x7FFE81178740
        public void get_Mac(){} // RVA: 0x7FFE81176730
        public void get_UnauthAttrs(){} // RVA: 0x7FFE8119C0E0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A22E880
        public void CalculateVersion(){} // RVA: 0x7FFE8A22EBF0
    }

    public class AuthenticatedDataParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1SequenceParser seq; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A22EFD0
        public void get_Version(){} // RVA: 0x7FFE810FE7C0
        public void GetOriginatorInfo(){} // RVA: 0x7FFE8A22F170
        public void GetRecipientInfos(){} // RVA: 0x7FFE8A22F430
        public void GetMacAlgorithm(){} // RVA: 0x7FFE8A22F5A0
        public void GetDigestAlgorithm(){} // RVA: 0x7FFE8A22F740
        public void GetEnapsulatedContentInfo(){} // RVA: 0x7FFE8A22F920
        public void GetAuthAttrs(){} // RVA: 0x7FFE8A22FAB0
        public void GetMac(){} // RVA: 0x7FFE8A22FCB0
        public void GetUnauthAttrs(){} // RVA: 0x7FFE8A22FDF0
    }

    public class CmsAttributes : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A231AA0
    }

    public class CmsObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A231D80
    }

    public class CompressedData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier compressionAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo encapContentInfo; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A232670 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A2328D0 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFE81116380
        public void get_CompressionAlgorithmIdentifier(){} // RVA: 0x7FFE810FE7C0
        public void get_EncapContentInfo(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A232A90
    }

    public class CompressedDataParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger _version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier _compressionAlgorithm; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A232C20
        public void get_Version(){} // RVA: 0x7FFE81116380
        public void get_CompressionAlgorithmIdentifier(){} // RVA: 0x7FFE810FE7C0
        public void GetEncapContentInfo(){} // RVA: 0x7FFE811290C0
    }

    public class ContentInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier contentType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable content; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A2330B0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void get_ContentType(){} // RVA: 0x7FFE81116380
        public void get_Content(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A233400
    }

    public class ContentInfoParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier contentType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2335B0
        public void get_ContentType(){} // RVA: 0x7FFE81116380
        public void GetContent(){} // RVA: 0x7FFE8A2337E0
    }

    public class EncryptedContentInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier contentType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier contentEncryptionAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString encryptedContent; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A233850 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A233BB0
        public void get_ContentType(){} // RVA: 0x7FFE81116380
        public void get_ContentEncryptionAlgorithm(){} // RVA: 0x7FFE810FE7C0
        public void get_EncryptedContent(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A233D70
    }

    public class EncryptedContentInfoParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier _contentType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier _contentEncryptionAlgorithm; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A233F20
        public void get_ContentType(){} // RVA: 0x7FFE81116380
        public void get_ContentEncryptionAlgorithm(){} // RVA: 0x7FFE810FE7C0
        public void GetEncryptedContent(){} // RVA: 0x7FFE8A2341E0
    }

    public class EncryptedData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo encryptedContentInfo; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set unprotectedAttrs; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A234240
        public void .ctor(){} // RVA: 0x7FFE8A2345F0 | overloaded x3
        public void get_Version(){} // RVA: 0x7FFE81116380
        public void get_EncryptedContentInfo(){} // RVA: 0x7FFE810FE7C0
        public void get_UnprotectedAttrs(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A234840
    }

    public class EnvelopedData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.OriginatorInfo originatorInfo; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set recipientInfos; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo encryptedContentInfo; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set unprotectedAttrs; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A234E80 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A2352D0 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFE81116380
        public void get_OriginatorInfo(){} // RVA: 0x7FFE810FE7C0
        public void get_RecipientInfos(){} // RVA: 0x7FFE811290C0
        public void get_EncryptedContentInfo(){} // RVA: 0x7FFE81129130
        public void get_UnprotectedAttrs(){} // RVA: 0x7FFE8144E200
        public void ToAsn1Object(){} // RVA: 0x7FFE8A2353B0
        public void CalculateVersion(){} // RVA: 0x7FFE8A235640
    }

    public class EnvelopedDataParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1SequenceParser _seq; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A235870
        public void get_Version(){} // RVA: 0x7FFE810FE7C0
        public void GetOriginatorInfo(){} // RVA: 0x7FFE8A235A10
        public void GetRecipientInfos(){} // RVA: 0x7FFE8A235CD0
        public void GetEncryptedContentInfo(){} // RVA: 0x7FFE8A235E40
        public void GetUnprotectedAttrs(){} // RVA: 0x7FFE8A235FD0
    }

    public class Evidence : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.TimeStampTokenEvidence tstEvidence; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2361D0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A2365C0 | overloaded x2
        public void get_TstEvidence(){} // RVA: 0x7FFE81116380
        public void ToAsn1Object(){} // RVA: 0x7FFE8A236610
    }

    public class IssuerAndSerialNumber : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name name; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger serialNumber; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A2366A0
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x3
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void get_SerialNumber(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A236B20
    }

    public class KekIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString keyIdentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime date; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.OtherKeyAttribute other; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A236E40 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A2372F0 | overloaded x2
        public void get_KeyIdentifier(){} // RVA: 0x7FFE81116380
        public void get_Date(){} // RVA: 0x7FFE810FE7C0
        public void get_Other(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A2374B0
    }

    public class KekRecipientInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.KekIdentifier kekID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncryptionAlgorithm; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2378B0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A237DB0 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFE81116380
        public void get_KekID(){} // RVA: 0x7FFE810FE7C0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0x7FFE811290C0
        public void get_EncryptedKey(){} // RVA: 0x7FFE81129130
        public void ToAsn1Object(){} // RVA: 0x7FFE8A237F70
    }

    public class KeyAgreeRecipientIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber issuerSerial; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.RecipientKeyIdentifier rKeyID; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A238130 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE81161E80 | overloaded x2
        public void get_IssuerAndSerialNumber(){} // RVA: 0x7FFE81116380
        public void get_RKeyID(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A238480
    }

    public class KeyAgreeRecipientInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.OriginatorIdentifierOrKey originator; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString ukm; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncryptionAlgorithm; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence recipientEncryptedKeys; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A238730 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A238E20 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFE81116380
        public void get_Originator(){} // RVA: 0x7FFE810FE7C0
        public void get_UserKeyingMaterial(){} // RVA: 0x7FFE811290C0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0x7FFE81129130
        public void get_RecipientEncryptedKeys(){} // RVA: 0x7FFE8144E200
        public void ToAsn1Object(){} // RVA: 0x7FFE8A238FE0
    }

    public class KeyTransRecipientInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.RecipientIdentifier rid; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncryptionAlgorithm; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A239650 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A239980
        public void get_Version(){} // RVA: 0x7FFE81116380
        public void get_RecipientIdentifier(){} // RVA: 0x7FFE810FE7C0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0x7FFE811290C0
        public void get_EncryptedKey(){} // RVA: 0x7FFE81129130
        public void ToAsn1Object(){} // RVA: 0x7FFE8A239B40
    }

    public class MetaData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBoolean hashProtected; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerUtf8String fileName; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerIA5String mediaType; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.Attributes otherMetaData; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A239CE0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A23A180
        public void ToAsn1Object(){} // RVA: 0x7FFE8A23A260
        public void get_IsHashProtected(){} // RVA: 0x7FFE8A23A4E0
        public void get_FileName(){} // RVA: 0x7FFE810FE7C0
        public void get_MediaType(){} // RVA: 0x7FFE811290C0
        public void get_OtherMetaData(){} // RVA: 0x7FFE81129130
    }

    public class OriginatorIdentifierOrKey : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable id; // 0x10
        public object field_1; // 0x8B8
        public object field_2; // 0x8B9
        public object field_3; // 0x8BA
        public object field_4; // 0x8BB

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x6
        public void GetInstance(){} // RVA: 0x7FFE8A23A830 | overloaded x2
        public void get_ID(){} // RVA: 0x7FFE81116380
        public void get_IssuerAndSerialNumber(){} // RVA: 0x7FFE8A23AC70
        public void get_SubjectKeyIdentifier(){} // RVA: 0x7FFE8A23AD10
        public void get_OriginatorKey(){} // RVA: 0x7FFE8A23AE80
        public void get_OriginatorPublicKey(){} // RVA: 0x7FFE8A23AE90
        public void ToAsn1Object(){} // RVA: 0x7FFE815888E0
    }

    public class OriginatorInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set certs; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set crls; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A23AF50 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A23B310 | overloaded x2
        public void get_Certificates(){} // RVA: 0x7FFE81116380
        public void get_Crls(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A23B4D0
    }

    public class OriginatorPublicKey : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier mAlgorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString mPublicKey; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A23B7A0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A23B920 | overloaded x2
        public void get_Algorithm(){} // RVA: 0x7FFE81116380
        public void get_PublicKey(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A23BBF0
    }

    public class OtherKeyAttribute : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier keyAttrId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable keyAttr; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A23BD00
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void get_KeyAttrId(){} // RVA: 0x7FFE81116380
        public void get_KeyAttr(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A23C0A0
    }

    public class OtherRecipientInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier oriType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable oriValue; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A23C1B0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A23C320 | overloaded x2
        public void get_OriType(){} // RVA: 0x7FFE81116380
        public void get_OriValue(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A23C500
    }

    public class OtherRevocationInfoFormat : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier otherRevInfoFormat; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable otherRevInfo; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A23C610 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A23C780 | overloaded x2
        public void get_InfoFormat(){} // RVA: 0x7FFE81116380
        public void get_Info(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A23C9A0
    }

    public class PasswordRecipientInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyDerivationAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncryptionAlgorithm; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A23CDE0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A23D550 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFE81116380
        public void get_KeyDerivationAlgorithm(){} // RVA: 0x7FFE810FE7C0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0x7FFE811290C0
        public void get_EncryptedKey(){} // RVA: 0x7FFE81129130
        public void ToAsn1Object(){} // RVA: 0x7FFE8A23D710
    }

    public class RecipientEncryptedKey : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientIdentifier identifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A23DB60 | overloaded x2
        public void get_Identifier(){} // RVA: 0x7FFE81116380
        public void get_EncryptedKey(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A23DD30
    }

    public class RecipientIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable id; // 0x10
        public object field_1; // 0x8CD

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A23DF10
        public void get_IsTagged(){} // RVA: 0x7FFE8A23E250
        public void get_ID(){} // RVA: 0x7FFE8A23E2E0
        public void ToAsn1Object(){} // RVA: 0x7FFE815888E0
    }

    public class RecipientInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable info; // 0x10
        public object field_1; // 0x8CF
        public object field_2; // 0x8D0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x6
        public void GetInstance(){} // RVA: 0x7FFE8A23E820
        public void get_Version(){} // RVA: 0x7FFE8A23EA70
        public void get_IsTagged(){} // RVA: 0x7FFE8A23EC10
        public void get_Info(){} // RVA: 0x7FFE8A23ECA0
        public void GetKekInfo(){} // RVA: 0x7FFE8A23EE20
        public void ToAsn1Object(){} // RVA: 0x7FFE815888E0
    }

    public class RecipientKeyIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString subjectKeyIdentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime date; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.OtherKeyAttribute other; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A23F080 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFE8A23F650 | overloaded x2
        public void get_SubjectKeyIdentifier(){} // RVA: 0x7FFE81116380
        public void get_Date(){} // RVA: 0x7FFE810FE7C0
        public void get_OtherKeyAttribute(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A23F810
    }

    public class ScvpReqRes : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo request; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo response; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A23FA50
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x3
        public void get_Request(){} // RVA: 0x7FFE81116380
        public void get_Response(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A23FDC0
    }

    public class SignedData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version1;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version3; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version4; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version5; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set digestAlgorithms; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A23FF90
        public void .ctor(){} // RVA: 0x7FFE8A240B80 | overloaded x2
        public void CalculateVersion(){} // RVA: 0x7FFE8A240490
        public void CheckForVersion3(){} // RVA: 0x7FFE8A240990
        public void get_Version(){} // RVA: 0x7FFE81116380
        public void get_DigestAlgorithms(){} // RVA: 0x7FFE810FE7C0
        public void get_EncapContentInfo(){} // RVA: 0x7FFE811290C0
        public void get_Certificates(){} // RVA: 0x7FFE81129130
        public void get_CRLs(){} // RVA: 0x7FFE8144E200
        public void get_SignerInfos(){} // RVA: 0x7FFE8143BA80
        public void ToAsn1Object(){} // RVA: 0x7FFE8A2411A0
        public void .cctor(){} // RVA: 0x7FFE8A241430
    }

    public class SignedDataParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1SequenceParser _seq; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A2416C0
        public void .ctor(){} // RVA: 0x7FFE8A2418B0
        public void get_Version(){} // RVA: 0x7FFE810FE7C0
        public void GetDigestAlgorithms(){} // RVA: 0x7FFE8A241A50
        public void GetEncapContentInfo(){} // RVA: 0x7FFE8A241AF0
        public void GetCertificates(){} // RVA: 0x7FFE8A241BC0
        public void GetCrls(){} // RVA: 0x7FFE8A241E40
        public void GetSignerInfos(){} // RVA: 0x7FFE8A2420C0
    }

    public class SignerIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable id; // 0x10
        public object field_1; // 0x8DE

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A2422A0
        public void get_IsTagged(){} // RVA: 0x7FFE8A2425E0
        public void get_ID(){} // RVA: 0x7FFE8A242670
        public void ToAsn1Object(){} // RVA: 0x7FFE815888E0
    }

    public class SignerInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.SignerIdentifier sid; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digAlgorithm; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set authenticatedAttributes; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digEncryptionAlgorithm; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString encryptedDigest; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set unauthenticatedAttributes; // 0x40

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A2427C0
        public void .ctor(){} // RVA: 0x7FFE8A242F80 | overloaded x3
        public void get_Version(){} // RVA: 0x7FFE81116380
        public void get_SignerID(){} // RVA: 0x7FFE810FE7C0
        public void get_AuthenticatedAttributes(){} // RVA: 0x7FFE81129130
        public void get_DigestAlgorithm(){} // RVA: 0x7FFE811290C0
        public void get_EncryptedDigest(){} // RVA: 0x7FFE8143BA80
        public void get_DigestEncryptionAlgorithm(){} // RVA: 0x7FFE8144E200
        public void get_UnauthenticatedAttributes(){} // RVA: 0x7FFE81178740
        public void ToAsn1Object(){} // RVA: 0x7FFE8A243620
    }

    public class Time : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object time; // 0x10
        public object field_1; // 0x8E7

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A243E30 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A243B60 | overloaded x2
        public void get_TimeString(){} // RVA: 0x7FFE8A244080
        public void get_Date(){} // RVA: 0x7FFE8A2441A0
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class TimeStampAndCrl : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo timeStamp; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.CertificateList crl; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2443B0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A2444F0
        public void get_TimeStampToken(){} // RVA: 0x7FFE81116380
        public void get_Crl(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A2446F0
    }

    public class TimeStampTokenEvidence : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2459B0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A245E40 | overloaded x2
        public void ToTimeStampAndCrlArray(){} // RVA: 0x7FFE8A245F20
        public void ToAsn1Object(){} // RVA: 0x7FFE8A245FA0
    }

    public class TimeStampedData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerIA5String dataUri; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.MetaData metaData; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString content; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A244B00 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A244F50
        public void get_DataUri(){} // RVA: 0x7FFE810FE7C0
        public void get_MetaData(){} // RVA: 0x7FFE811290C0
        public void get_Content(){} // RVA: 0x7FFE81129130
        public void get_TemporalEvidence(){} // RVA: 0x7FFE8144E200
        public void ToAsn1Object(){} // RVA: 0x7FFE8A245030
    }

    public class TimeStampedDataParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerIA5String dataUri; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.MetaData metaData; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A245270
        public void GetInstance(){} // RVA: 0x7FFE8A245660
        public void get_DataUri(){} // RVA: 0x7FFE810FE7C0
        public void get_MetaData(){} // RVA: 0x7FFE811290C0
        public void get_Content(){} // RVA: 0x7FFE81129130
        public void GetTemporalEvidence(){} // RVA: 0x7FFE8A2457E0
    }

}