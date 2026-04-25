// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
// Classes: 47
// Methods: 373

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
{
    public class Attribute : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier AttrType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set AttrValues; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDD25B0
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void get_AttrType(){} // RVA: 0x7FFAC2F3C380
        public void get_AttrValues(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDD29E0
    }

    public class AttributeTable : Object
    {
        public System.Collections.IDictionary Item; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDD3430 | overloaded x5
        public void AddAttribute(){} // RVA: 0x7FFACBDD3480
        public void get_Item(){} // RVA: 0x7FFACBDD3670
        public void Get(){} // RVA: 0x7FFACBDD3810
        public void GetAll(){} // RVA: 0x7FFACBDD3820
        public void get_Count(){} // RVA: 0x7FFACBDD3BD0
        public void ToDictionary(){} // RVA: 0x7FFACBDD3EA0
        public void ToHashtable(){} // RVA: 0x7FFACBDD3F00
        public void ToAsn1EncodableVector(){} // RVA: 0x7FFACBDD3F70
        public void ToAttributes(){} // RVA: 0x7FFACBDD42F0
        public void Add(){} // RVA: 0x7FFACBDD43F0
        public void Remove(){} // RVA: 0x7FFACBDD44E0
    }

    public class Attributes : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set attributes; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDD2AF0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDD2BB0
        public void GetAttributes(){} // RVA: 0x7FFACBDD2CD0
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class AuthEnvelopedData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.OriginatorInfo OriginatorInfo; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set RecipientInfos; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo AuthEncryptedContentInfo; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set AuthAttrs; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString Mac; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set UnauthAttrs; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDD6C90 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDD7320 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
        public void get_OriginatorInfo(){} // RVA: 0x7FFAC2F247C0
        public void get_RecipientInfos(){} // RVA: 0x7FFAC2F4F0C0
        public void get_AuthEncryptedContentInfo(){} // RVA: 0x7FFAC2F4F130
        public void get_AuthAttrs(){} // RVA: 0x7FFAC31D95E0
        public void get_Mac(){} // RVA: 0x7FFAC31D0140
        public void get_UnauthAttrs(){} // RVA: 0x7FFAC2F9E740
        public void ToAsn1Object(){} // RVA: 0x7FFACBDD74E0
    }

    public class AuthEnvelopedDataParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1SequenceParser Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IAsn1Convertible nextObject; // 0x20
        public bool originatorInfoCalled; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDD77E0
        public void get_Version(){} // RVA: 0x7FFAC2F247C0
        public void GetOriginatorInfo(){} // RVA: 0x7FFACBDD7980
        public void GetRecipientInfos(){} // RVA: 0x7FFACBDD7C40
        public void GetAuthEncryptedContentInfo(){} // RVA: 0x7FFACBDD7DB0
        public void GetAuthAttrs(){} // RVA: 0x7FFACBDD7F40
        public void GetMac(){} // RVA: 0x7FFACBDD8140
        public void GetUnauthAttrs(){} // RVA: 0x7FFACBDD8280
    }

    public class AuthenticatedData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.OriginatorInfo OriginatorInfo; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set RecipientInfos; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier MacAlgorithm; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DigestAlgorithm; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo EncapsulatedContentInfo; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set AuthAttrs; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString Mac; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set UnauthAttrs; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDD4980 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDD50A0 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
        public void get_OriginatorInfo(){} // RVA: 0x7FFAC2F247C0
        public void get_RecipientInfos(){} // RVA: 0x7FFAC2F4F0C0
        public void get_MacAlgorithm(){} // RVA: 0x7FFAC2F4F130
        public void get_DigestAlgorithm(){} // RVA: 0x7FFAC31D95E0
        public void get_EncapsulatedContentInfo(){} // RVA: 0x7FFAC31D0140
        public void get_AuthAttrs(){} // RVA: 0x7FFAC2F9E740
        public void get_Mac(){} // RVA: 0x7FFAC2F9C730
        public void get_UnauthAttrs(){} // RVA: 0x7FFAC2FC20E0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDD5260
        public void CalculateVersion(){} // RVA: 0x7FFACBDD55D0
    }

    public class AuthenticatedDataParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1SequenceParser Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IAsn1Convertible nextObject; // 0x20
        public bool originatorInfoCalled; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDD59B0
        public void get_Version(){} // RVA: 0x7FFAC2F247C0
        public void GetOriginatorInfo(){} // RVA: 0x7FFACBDD5B50
        public void GetRecipientInfos(){} // RVA: 0x7FFACBDD5E10
        public void GetMacAlgorithm(){} // RVA: 0x7FFACBDD5F80
        public void GetDigestAlgorithm(){} // RVA: 0x7FFACBDD6120
        public void GetEnapsulatedContentInfo(){} // RVA: 0x7FFACBDD6300
        public void GetAuthAttrs(){} // RVA: 0x7FFACBDD6490
        public void GetMac(){} // RVA: 0x7FFACBDD6690
        public void GetUnauthAttrs(){} // RVA: 0x7FFACBDD67D0
    }

    public class CmsAttributes : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ContentType;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier MessageDigest; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SigningTime; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CounterSignature; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ContentHint; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBDD8480
    }

    public class CmsObjectIdentifiers : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Data;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SignedData; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier EnvelopedData; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SignedAndEnvelopedData; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DigestedData; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier EncryptedData; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier AuthenticatedData; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CompressedData; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier AuthEnvelopedData; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier timestampedData; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_ri; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_ri_ocsp_response; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_ri_scvp; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBDD8760
    }

    public class CompressedData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier CompressionAlgorithmIdentifier; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo EncapContentInfo; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDD9050 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDD92B0 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
        public void get_CompressionAlgorithmIdentifier(){} // RVA: 0x7FFAC2F247C0
        public void get_EncapContentInfo(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDD9470
    }

    public class CompressedDataParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier CompressionAlgorithmIdentifier; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfoParser _encapContentInfo; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDD9600
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
        public void get_CompressionAlgorithmIdentifier(){} // RVA: 0x7FFAC2F247C0
        public void GetEncapContentInfo(){} // RVA: 0x7FFAC2F4F0C0
    }

    public class ContentInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ContentType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable Content; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDD9A90 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void get_ContentType(){} // RVA: 0x7FFAC2F3C380
        public void get_Content(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDD9DE0
    }

    public class ContentInfoParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ContentType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1TaggedObjectParser content; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDD9F90
        public void get_ContentType(){} // RVA: 0x7FFAC2F3C380
        public void GetContent(){} // RVA: 0x7FFACBDDA1C0
    }

    public class EncryptedContentInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ContentType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier ContentEncryptionAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString EncryptedContent; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDDA230 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDDA590
        public void get_ContentType(){} // RVA: 0x7FFAC2F3C380
        public void get_ContentEncryptionAlgorithm(){} // RVA: 0x7FFAC2F247C0
        public void get_EncryptedContent(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDDA750
    }

    public class EncryptedContentInfoParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ContentType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier ContentEncryptionAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1TaggedObjectParser _encryptedContent; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDDA900
        public void get_ContentType(){} // RVA: 0x7FFAC2F3C380
        public void get_ContentEncryptionAlgorithm(){} // RVA: 0x7FFAC2F247C0
        public void GetEncryptedContent(){} // RVA: 0x7FFACBDDABC0
    }

    public class EncryptedData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo EncryptedContentInfo; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set UnprotectedAttrs; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDDAC20
        public void .ctor(){} // RVA: 0x7FFACBDDAFD0 | overloaded x3
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
        public void get_EncryptedContentInfo(){} // RVA: 0x7FFAC2F247C0
        public void get_UnprotectedAttrs(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDDB220
    }

    public class EnvelopedData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.OriginatorInfo OriginatorInfo; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set RecipientInfos; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo EncryptedContentInfo; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set UnprotectedAttrs; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDDB860 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBDDBCB0 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
        public void get_OriginatorInfo(){} // RVA: 0x7FFAC2F247C0
        public void get_RecipientInfos(){} // RVA: 0x7FFAC2F4F0C0
        public void get_EncryptedContentInfo(){} // RVA: 0x7FFAC2F4F130
        public void get_UnprotectedAttrs(){} // RVA: 0x7FFAC31D95E0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDDBD90
        public void CalculateVersion(){} // RVA: 0x7FFACBDDC020
    }

    public class EnvelopedDataParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1SequenceParser Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger _version; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.IAsn1Convertible _nextObject; // 0x20
        public bool _originatorInfoCalled; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDDC250
        public void get_Version(){} // RVA: 0x7FFAC2F247C0
        public void GetOriginatorInfo(){} // RVA: 0x7FFACBDDC3F0
        public void GetRecipientInfos(){} // RVA: 0x7FFACBDDC6B0
        public void GetEncryptedContentInfo(){} // RVA: 0x7FFACBDDC820
        public void GetUnprotectedAttrs(){} // RVA: 0x7FFACBDDC9B0
    }

    public class Evidence : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.TimeStampTokenEvidence TstEvidence; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence otherEvidence; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDDCBB0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDDCFA0 | overloaded x2
        public void get_TstEvidence(){} // RVA: 0x7FFAC2F3C380
        public void ToAsn1Object(){} // RVA: 0x7FFACBDDCFF0
    }

    public class IssuerAndSerialNumber : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name Name; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger SerialNumber; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDDD080
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x3
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void get_SerialNumber(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDDD500
    }

    public class KekIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString KeyIdentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime Date; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.OtherKeyAttribute Other; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDDD820 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDDDCD0 | overloaded x2
        public void get_KeyIdentifier(){} // RVA: 0x7FFAC2F3C380
        public void get_Date(){} // RVA: 0x7FFAC2F247C0
        public void get_Other(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDDDE90
    }

    public class KekRecipientInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.KekIdentifier KekID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier KeyEncryptionAlgorithm; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString EncryptedKey; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDDE290 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDDE790 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
        public void get_KekID(){} // RVA: 0x7FFAC2F247C0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0x7FFAC2F4F0C0
        public void get_EncryptedKey(){} // RVA: 0x7FFAC2F4F130
        public void ToAsn1Object(){} // RVA: 0x7FFACBDDE950
    }

    public class KeyAgreeRecipientIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber IssuerAndSerialNumber; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.RecipientKeyIdentifier RKeyID; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDDEB10 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F87E80 | overloaded x2
        public void get_IssuerAndSerialNumber(){} // RVA: 0x7FFAC2F3C380
        public void get_RKeyID(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDDEE60
    }

    public class KeyAgreeRecipientInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.OriginatorIdentifierOrKey Originator; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString UserKeyingMaterial; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier KeyEncryptionAlgorithm; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence RecipientEncryptedKeys; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDDF110 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDDF800 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
        public void get_Originator(){} // RVA: 0x7FFAC2F247C0
        public void get_UserKeyingMaterial(){} // RVA: 0x7FFAC2F4F0C0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0x7FFAC2F4F130
        public void get_RecipientEncryptedKeys(){} // RVA: 0x7FFAC31D95E0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDDF9C0
    }

    public class KeyTransRecipientInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.RecipientIdentifier RecipientIdentifier; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier KeyEncryptionAlgorithm; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString EncryptedKey; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDE0030 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDE0360
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
        public void get_RecipientIdentifier(){} // RVA: 0x7FFAC2F247C0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0x7FFAC2F4F0C0
        public void get_EncryptedKey(){} // RVA: 0x7FFAC2F4F130
        public void ToAsn1Object(){} // RVA: 0x7FFACBDE0520
    }

    public class MetaData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBoolean IsHashProtected; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerUtf8String FileName; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerIA5String MediaType; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.Attributes OtherMetaData; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDE06C0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDE0B60
        public void ToAsn1Object(){} // RVA: 0x7FFACBDE0C40
        public void get_IsHashProtected(){} // RVA: 0x7FFACBDE0EC0
        public void get_FileName(){} // RVA: 0x7FFAC2F247C0
        public void get_MediaType(){} // RVA: 0x7FFAC2F4F0C0
        public void get_OtherMetaData(){} // RVA: 0x7FFAC2F4F130
    }

    public class OriginatorIdentifierOrKey : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable ID; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x6
        public void GetInstance(){} // RVA: 0x7FFACBDE1210 | overloaded x2
        public void get_ID(){} // RVA: 0x7FFAC2F3C380
        public void get_IssuerAndSerialNumber(){} // RVA: 0x7FFACBDE1650
        public void get_SubjectKeyIdentifier(){} // RVA: 0x7FFACBDE16F0
        public void get_OriginatorKey(){} // RVA: 0x7FFACBDE1860
        public void get_OriginatorPublicKey(){} // RVA: 0x7FFACBDE1870
        public void ToAsn1Object(){} // RVA: 0x7FFAC87BB0A0
    }

    public class OriginatorInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set Certificates; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set Crls; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDE1930 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDE1CF0 | overloaded x2
        public void get_Certificates(){} // RVA: 0x7FFAC2F3C380
        public void get_Crls(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDE1EB0
    }

    public class OriginatorPublicKey : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Algorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString PublicKey; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDE2180 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDE2300 | overloaded x2
        public void get_Algorithm(){} // RVA: 0x7FFAC2F3C380
        public void get_PublicKey(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDE25D0
    }

    public class OtherKeyAttribute : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier KeyAttrId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable KeyAttr; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDE26E0
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void get_KeyAttrId(){} // RVA: 0x7FFAC2F3C380
        public void get_KeyAttr(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDE2A80
    }

    public class OtherRecipientInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier OriType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable OriValue; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDE2B90 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDE2D00 | overloaded x2
        public void get_OriType(){} // RVA: 0x7FFAC2F3C380
        public void get_OriValue(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDE2EE0
    }

    public class OtherRevocationInfoFormat : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier InfoFormat; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable Info; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDE2FF0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDE3160 | overloaded x2
        public void get_InfoFormat(){} // RVA: 0x7FFAC2F3C380
        public void get_Info(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDE3380
    }

    public class PasswordRecipientInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier KeyDerivationAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier KeyEncryptionAlgorithm; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString EncryptedKey; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDE37C0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBDE3F30 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
        public void get_KeyDerivationAlgorithm(){} // RVA: 0x7FFAC2F247C0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0x7FFAC2F4F0C0
        public void get_EncryptedKey(){} // RVA: 0x7FFAC2F4F130
        public void ToAsn1Object(){} // RVA: 0x7FFACBDE40F0
    }

    public class RecipientEncryptedKey : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientIdentifier Identifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString EncryptedKey; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDE4540 | overloaded x2
        public void get_Identifier(){} // RVA: 0x7FFAC2F3C380
        public void get_EncryptedKey(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDE4710
    }

    public class RecipientIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable IsTagged; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBDE48F0
        public void get_IsTagged(){} // RVA: 0x7FFACBDE4C30
        public void get_ID(){} // RVA: 0x7FFACBDE4CC0
        public void ToAsn1Object(){} // RVA: 0x7FFAC87BB0A0
    }

    public class RecipientInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable Version; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x6
        public void GetInstance(){} // RVA: 0x7FFACBDE5200
        public void get_Version(){} // RVA: 0x7FFACBDE5450
        public void get_IsTagged(){} // RVA: 0x7FFACBDE55F0
        public void get_Info(){} // RVA: 0x7FFACBDE5680
        public void GetKekInfo(){} // RVA: 0x7FFACBDE5800
        public void ToAsn1Object(){} // RVA: 0x7FFAC87BB0A0
    }

    public class RecipientKeyIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString SubjectKeyIdentifier; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime Date; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.OtherKeyAttribute OtherKeyAttribute; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDE5A60 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFACBDE6030 | overloaded x2
        public void get_SubjectKeyIdentifier(){} // RVA: 0x7FFAC2F3C380
        public void get_Date(){} // RVA: 0x7FFAC2F247C0
        public void get_OtherKeyAttribute(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDE61F0
    }

    public class ScvpReqRes : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo Request; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo Response; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDE6430
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x3
        public void get_Request(){} // RVA: 0x7FFAC2F3C380
        public void get_Response(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDE67A0
    }

    public class SignedData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger DigestAlgorithms; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger EncapContentInfo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Certificates; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger CRLs; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set SignerInfos; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo contentInfo; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set certificates; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set crls; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set signerInfos; // 0x38
        public bool certsBer; // 0x40
        public bool crlsBer; // 0x41

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDE6970
        public void .ctor(){} // RVA: 0x7FFACBDE7560 | overloaded x2
        public void CalculateVersion(){} // RVA: 0x7FFACBDE6E70
        public void CheckForVersion3(){} // RVA: 0x7FFACBDE7370
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
        public void get_DigestAlgorithms(){} // RVA: 0x7FFAC2F247C0
        public void get_EncapContentInfo(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Certificates(){} // RVA: 0x7FFAC2F4F130
        public void get_CRLs(){} // RVA: 0x7FFAC31D95E0
        public void get_SignerInfos(){} // RVA: 0x7FFAC31D0140
        public void ToAsn1Object(){} // RVA: 0x7FFACBDE7B80
        public void .cctor(){} // RVA: 0x7FFACBDE7E10
    }

    public class SignedDataParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1SequenceParser Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger _version; // 0x18
        public object _nextObject; // 0x20
        public bool _certsCalled; // 0x28
        public bool _crlsCalled; // 0x29

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDE80A0
        public void .ctor(){} // RVA: 0x7FFACBDE8290
        public void get_Version(){} // RVA: 0x7FFAC2F247C0
        public void GetDigestAlgorithms(){} // RVA: 0x7FFACBDE8430
        public void GetEncapContentInfo(){} // RVA: 0x7FFACBDE84D0
        public void GetCertificates(){} // RVA: 0x7FFACBDE85A0
        public void GetCrls(){} // RVA: 0x7FFACBDE8820
        public void GetSignerInfos(){} // RVA: 0x7FFACBDE8AA0
    }

    public class SignerIdentifier : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable IsTagged; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBDE8C80
        public void get_IsTagged(){} // RVA: 0x7FFACBDE8FC0
        public void get_ID(){} // RVA: 0x7FFACBDE9050
        public void ToAsn1Object(){} // RVA: 0x7FFAC87BB0A0
    }

    public class SignerInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.SignerIdentifier SignerID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier AuthenticatedAttributes; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set DigestAlgorithm; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier EncryptedDigest; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString DigestEncryptionAlgorithm; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set UnauthenticatedAttributes; // 0x40

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDE91A0
        public void .ctor(){} // RVA: 0x7FFACBDE9960 | overloaded x3
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
        public void get_SignerID(){} // RVA: 0x7FFAC2F247C0
        public void get_AuthenticatedAttributes(){} // RVA: 0x7FFAC2F4F130
        public void get_DigestAlgorithm(){} // RVA: 0x7FFAC2F4F0C0
        public void get_EncryptedDigest(){} // RVA: 0x7FFAC31D0140
        public void get_DigestEncryptionAlgorithm(){} // RVA: 0x7FFAC31D95E0
        public void get_UnauthenticatedAttributes(){} // RVA: 0x7FFAC2F9E740
        public void ToAsn1Object(){} // RVA: 0x7FFACBDEA000
    }

    public class Time : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object TimeString; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDEA810 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBDEA540 | overloaded x2
        public void get_TimeString(){} // RVA: 0x7FFACBDEAA60
        public void get_Date(){} // RVA: 0x7FFACBDEAB80
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class TimeStampAndCrl : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.ContentInfo TimeStampToken; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.CertificateList Crl; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDEAD90 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDEAED0
        public void get_TimeStampToken(){} // RVA: 0x7FFAC2F3C380
        public void get_Crl(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDEB0D0
    }

    public class TimeStampTokenEvidence : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.TimeStampAndCrl[] timeStampAndCrls; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDEC390 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBDEC820 | overloaded x2
        public void ToTimeStampAndCrlArray(){} // RVA: 0x7FFACBDEC900
        public void ToAsn1Object(){} // RVA: 0x7FFACBDEC980
    }

    public class TimeStampedData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger DataUri; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerIA5String MetaData; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.MetaData Content; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString TemporalEvidence; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.Evidence temporalEvidence; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDEB4E0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDEB930
        public void get_DataUri(){} // RVA: 0x7FFAC2F247C0
        public void get_MetaData(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Content(){} // RVA: 0x7FFAC2F4F130
        public void get_TemporalEvidence(){} // RVA: 0x7FFAC31D95E0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDEBA10
    }

    public class TimeStampedDataParser : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger DataUri; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerIA5String MetaData; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.MetaData Content; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetStringParser content; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.Evidence temporalEvidence; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1SequenceParser parser; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDEBC50
        public void GetInstance(){} // RVA: 0x7FFACBDEC040
        public void get_DataUri(){} // RVA: 0x7FFAC2F247C0
        public void get_MetaData(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Content(){} // RVA: 0x7FFAC2F4F130
        public void GetTemporalEvidence(){} // RVA: 0x7FFACBDEC1C0
    }

}