// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
// Classes: 47
// Methods: 294

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
{
    public class Attribute : Asn1Encodable
    {
        public object attrType;
        public object attrValues;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA46F6B0
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_AttrType(){} // RVA: 0xB5DBF0
        public void get_AttrValues(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA46FAE0
    }

    public class AttributeTable : Object
    {
        public object attributes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4704F0
        public void AddAttribute(){} // RVA: 0xA470540
        public void get_Item(){} // RVA: 0xA470730
        public void Get(){} // RVA: 0xA4708D0
        public void GetAll(){} // RVA: 0xA4708E0
        public void get_Count(){} // RVA: 0xA470C70
        public void ToDictionary(){} // RVA: 0xA470F30
        public void ToHashtable(){} // RVA: 0xA470F90
        public void ToAsn1EncodableVector(){} // RVA: 0xA471000
        public void ToAttributes(){} // RVA: 0xA471370
        public void Add(){} // RVA: 0xA471470
        public void Remove(){} // RVA: 0xA471560
    }

    public class Attributes : Asn1Encodable
    {
        public object attributes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA46FBF0
        public void GetInstance(){} // RVA: 0xA46FCB0
        public void GetAttributes(){} // RVA: 0xA46FDC0
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class AuthEnvelopedData : Asn1Encodable
    {
        public object version;
        public object originatorInfo;
        public object recipientInfos;
        public object authEncryptedContentInfo;
        public object authAttrs;
        public object mac;
        public object unauthAttrs;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA473CE0
        public void GetInstance(){} // RVA: 0xA474370
        public void get_Version(){} // RVA: 0xB5DBF0
        public void get_OriginatorInfo(){} // RVA: 0xB465B0
        public void get_RecipientInfos(){} // RVA: 0xB700F0
        public void get_AuthEncryptedContentInfo(){} // RVA: 0xB70160
        public void get_AuthAttrs(){} // RVA: 0xD33E60
        public void get_Mac(){} // RVA: 0xD05CA0
        public void get_UnauthAttrs(){} // RVA: 0xBC1B30
        public void ToAsn1Object(){} // RVA: 0xA474530
    }

    public class AuthEnvelopedDataParser : Object
    {
        public object seq;
        public object version;
        public object nextObject;
        public object originatorInfoCalled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA474830
        public void get_Version(){} // RVA: 0xB465B0
        public void GetOriginatorInfo(){} // RVA: 0xA4749D0
        public void GetRecipientInfos(){} // RVA: 0xA474C90
        public void GetAuthEncryptedContentInfo(){} // RVA: 0xA474E00
        public void GetAuthAttrs(){} // RVA: 0xA474F90
        public void GetMac(){} // RVA: 0xA475190
        public void GetUnauthAttrs(){} // RVA: 0xA4752D0
    }

    public class AuthenticatedData : Asn1Encodable
    {
        public object version;
        public object originatorInfo;
        public object recipientInfos;
        public object macAlgorithm;
        public object digestAlgorithm;
        public object encapsulatedContentInfo;
        public object authAttrs;
        public object mac;
        public object unauthAttrs;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA471A00
        public void GetInstance(){} // RVA: 0xA472110
        public void get_Version(){} // RVA: 0xB5DBF0
        public void get_OriginatorInfo(){} // RVA: 0xB465B0
        public void get_RecipientInfos(){} // RVA: 0xB700F0
        public void get_MacAlgorithm(){} // RVA: 0xB70160
        public void get_DigestAlgorithm(){} // RVA: 0xD33E60
        public void get_EncapsulatedContentInfo(){} // RVA: 0xD05CA0
        public void get_AuthAttrs(){} // RVA: 0xBC1B30
        public void get_Mac(){} // RVA: 0xBBF8F0
        public void get_UnauthAttrs(){} // RVA: 0xBE58B0
        public void ToAsn1Object(){} // RVA: 0xA4722D0
        public void CalculateVersion(){} // RVA: 0xA472640
    }

    public class AuthenticatedDataParser : Object
    {
        public object seq;
        public object version;
        public object nextObject;
        public object originatorInfoCalled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4729F0
        public void get_Version(){} // RVA: 0xB465B0
        public void GetOriginatorInfo(){} // RVA: 0xA472B90
        public void GetRecipientInfos(){} // RVA: 0xA472E50
        public void GetMacAlgorithm(){} // RVA: 0xA472FC0
        public void GetDigestAlgorithm(){} // RVA: 0xA473160
        public void GetEnapsulatedContentInfo(){} // RVA: 0xA473340
        public void GetAuthAttrs(){} // RVA: 0xA4734D0
        public void GetMac(){} // RVA: 0xA4736D0
        public void GetUnauthAttrs(){} // RVA: 0xA473810
    }

    public class CmsAttributes : Object
    {
        public object ContentType;
        public object MessageDigest;
        public object SigningTime;
        public object CounterSignature;
        public object ContentHint;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA4754D0
    }

    public class CmsObjectIdentifiers : Object
    {
        public object Data;
        public object SignedData;
        public object EnvelopedData;
        public object SignedAndEnvelopedData;
        public object DigestedData;
        public object EncryptedData;
        public object AuthenticatedData;
        public object CompressedData;
        public object AuthEnvelopedData;
        public object timestampedData;
        public object id_ri;
        public object id_ri_ocsp_response;
        public object id_ri_scvp;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA4757B0
    }

    public class CompressedData : Asn1Encodable
    {
        public object version;
        public object compressionAlgorithm;
        public object encapContentInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4760A0
        public void GetInstance(){} // RVA: 0xA476300
        public void get_Version(){} // RVA: 0xB5DBF0
        public void get_CompressionAlgorithmIdentifier(){} // RVA: 0xB465B0
        public void get_EncapContentInfo(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA4764C0
    }

    public class CompressedDataParser : Object
    {
        public object _version;
        public object _compressionAlgorithm;
        public object _encapContentInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA476650
        public void get_Version(){} // RVA: 0xB5DBF0
        public void get_CompressionAlgorithmIdentifier(){} // RVA: 0xB465B0
        public void GetEncapContentInfo(){} // RVA: 0xB700F0
    }

    public class ContentInfo : Asn1Encodable
    {
        public object contentType;
        public object content;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA476AE0
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_ContentType(){} // RVA: 0xB5DBF0
        public void get_Content(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA476E30
    }

    public class ContentInfoParser : Object
    {
        public object contentType;
        public object content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA476FE0
        public void get_ContentType(){} // RVA: 0xB5DBF0
        public void GetContent(){} // RVA: 0xA477210
    }

    public class EncryptedContentInfo : Asn1Encodable
    {
        public object contentType;
        public object contentEncryptionAlgorithm;
        public object encryptedContent;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA477280
        public void GetInstance(){} // RVA: 0xA4775E0
        public void get_ContentType(){} // RVA: 0xB5DBF0
        public void get_ContentEncryptionAlgorithm(){} // RVA: 0xB465B0
        public void get_EncryptedContent(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA4777A0
    }

    public class EncryptedContentInfoParser : Object
    {
        public object _contentType;
        public object _contentEncryptionAlgorithm;
        public object _encryptedContent;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA477950
        public void get_ContentType(){} // RVA: 0xB5DBF0
        public void get_ContentEncryptionAlgorithm(){} // RVA: 0xB465B0
        public void GetEncryptedContent(){} // RVA: 0xA477C10
    }

    public class EncryptedData : Asn1Encodable
    {
        public object version;
        public object encryptedContentInfo;
        public object unprotectedAttrs;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA477C70
        public void .ctor(){} // RVA: 0xA478020
        public void get_Version(){} // RVA: 0xB5DBF0
        public void get_EncryptedContentInfo(){} // RVA: 0xB465B0
        public void get_UnprotectedAttrs(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA478270
    }

    public class EnvelopedData : Asn1Encodable
    {
        public object version;
        public object originatorInfo;
        public object recipientInfos;
        public object encryptedContentInfo;
        public object unprotectedAttrs;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4788B0
        public void GetInstance(){} // RVA: 0xA478D00
        public void get_Version(){} // RVA: 0xB5DBF0
        public void get_OriginatorInfo(){} // RVA: 0xB465B0
        public void get_RecipientInfos(){} // RVA: 0xB700F0
        public void get_EncryptedContentInfo(){} // RVA: 0xB70160
        public void get_UnprotectedAttrs(){} // RVA: 0xD33E60
        public void ToAsn1Object(){} // RVA: 0xA478DE0
        public void CalculateVersion(){} // RVA: 0xA479070
    }

    public class EnvelopedDataParser : Object
    {
        public object _seq;
        public object _version;
        public object _nextObject;
        public object _originatorInfoCalled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA479290
        public void get_Version(){} // RVA: 0xB465B0
        public void GetOriginatorInfo(){} // RVA: 0xA479430
        public void GetRecipientInfos(){} // RVA: 0xA4796F0
        public void GetEncryptedContentInfo(){} // RVA: 0xA479860
        public void GetUnprotectedAttrs(){} // RVA: 0xA4799F0
    }

    public class Evidence : Asn1Encodable
    {
        public object tstEvidence;
        public object otherEvidence;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA479BF0
        public void GetInstance(){} // RVA: 0xA479FE0
        public void get_TstEvidence(){} // RVA: 0xB5DBF0
        public void ToAsn1Object(){} // RVA: 0xA47A030
    }

    public class IssuerAndSerialNumber : Asn1Encodable
    {
        public object name;
        public object serialNumber;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA47A0C0
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_Name(){} // RVA: 0xB5DBF0
        public void get_SerialNumber(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA47A540
    }

    public class KekIdentifier : Asn1Encodable
    {
        public object keyIdentifier;
        public object date;
        public object other;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA47A860
        public void GetInstance(){} // RVA: 0xA47AD10
        public void get_KeyIdentifier(){} // RVA: 0xB5DBF0
        public void get_Date(){} // RVA: 0xB465B0
        public void get_Other(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA47AED0
    }

    public class KekRecipientInfo : Asn1Encodable
    {
        public object version;
        public object kekID;
        public object keyEncryptionAlgorithm;
        public object encryptedKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA47B2F0
        public void GetInstance(){} // RVA: 0xA47B640
        public void get_Version(){} // RVA: 0xB5DBF0
        public void get_KekID(){} // RVA: 0xB465B0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0xB700F0
        public void get_EncryptedKey(){} // RVA: 0xB70160
        public void ToAsn1Object(){} // RVA: 0xA47B800
    }

    public class KeyAgreeRecipientIdentifier : Asn1Encodable
    {
        public object issuerSerial;
        public object rKeyID;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA47B9C0
        public void .ctor(){} // RVA: 0xBA9BA0
        public void get_IssuerAndSerialNumber(){} // RVA: 0xB5DBF0
        public void get_RKeyID(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA47BD10
    }

    public class KeyAgreeRecipientInfo : Asn1Encodable
    {
        public object version;
        public object originator;
        public object ukm;
        public object keyEncryptionAlgorithm;
        public object recipientEncryptedKeys;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA47BFD0
        public void GetInstance(){} // RVA: 0xA47C510
        public void get_Version(){} // RVA: 0xB5DBF0
        public void get_Originator(){} // RVA: 0xB465B0
        public void get_UserKeyingMaterial(){} // RVA: 0xB700F0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0xB70160
        public void get_RecipientEncryptedKeys(){} // RVA: 0xD33E60
        public void ToAsn1Object(){} // RVA: 0xA47C6D0
    }

    public class KeyTransRecipientInfo : Asn1Encodable
    {
        public object version;
        public object rid;
        public object keyEncryptionAlgorithm;
        public object encryptedKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA47CD60
        public void GetInstance(){} // RVA: 0xA47D090
        public void get_Version(){} // RVA: 0xB5DBF0
        public void get_RecipientIdentifier(){} // RVA: 0xB465B0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0xB700F0
        public void get_EncryptedKey(){} // RVA: 0xB70160
        public void ToAsn1Object(){} // RVA: 0xA47D250
    }

    public class MetaData : Asn1Encodable
    {
        public object hashProtected;
        public object fileName;
        public object mediaType;
        public object otherMetaData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA47D3F0
        public void GetInstance(){} // RVA: 0xA47D890
        public void ToAsn1Object(){} // RVA: 0xA47D970
        public void get_IsHashProtected(){} // RVA: 0xA47DC00
        public void get_FileName(){} // RVA: 0xB465B0
        public void get_MediaType(){} // RVA: 0xB700F0
        public void get_OtherMetaData(){} // RVA: 0xB70160
    }

    public class OriginatorIdentifierOrKey : Asn1Encodable
    {
        public object id;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetInstance(){} // RVA: 0xA47DF50
        public void get_ID(){} // RVA: 0xB5DBF0
        public void get_IssuerAndSerialNumber(){} // RVA: 0xA47E380
        public void get_SubjectKeyIdentifier(){} // RVA: 0xA47E420
        public void get_OriginatorKey(){} // RVA: 0xA47E590
        public void get_OriginatorPublicKey(){} // RVA: 0xA47E5A0
        public void ToAsn1Object(){} // RVA: 0x10ACB60
    }

    public class OriginatorInfo : Asn1Encodable
    {
        public object certs;
        public object crls;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA47E660
        public void GetInstance(){} // RVA: 0xA47EA30
        public void get_Certificates(){} // RVA: 0xB5DBF0
        public void get_Crls(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA47EBF0
    }

    public class OriginatorPublicKey : Asn1Encodable
    {
        public object mAlgorithm;
        public object mPublicKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA47EEC0
        public void GetInstance(){} // RVA: 0xA47F040
        public void get_Algorithm(){} // RVA: 0xB5DBF0
        public void get_PublicKey(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA47F310
    }

    public class OtherKeyAttribute : Asn1Encodable
    {
        public object keyAttrId;
        public object keyAttr;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA47F420
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_KeyAttrId(){} // RVA: 0xB5DBF0
        public void get_KeyAttr(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA47F960
    }

    public class OtherRecipientInfo : Asn1Encodable
    {
        public object oriType;
        public object oriValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA47FA70
        public void GetInstance(){} // RVA: 0xA47FBE0
        public void get_OriType(){} // RVA: 0xB5DBF0
        public void get_OriValue(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA47FDC0
    }

    public class OtherRevocationInfoFormat : Asn1Encodable
    {
        public object otherRevInfoFormat;
        public object otherRevInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA47FED0
        public void GetInstance(){} // RVA: 0xA480040
        public void get_InfoFormat(){} // RVA: 0xB5DBF0
        public void get_Info(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA480260
    }

    public class PasswordRecipientInfo : Asn1Encodable
    {
        public object version;
        public object keyDerivationAlgorithm;
        public object keyEncryptionAlgorithm;
        public object encryptedKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4806B0
        public void GetInstance(){} // RVA: 0xA480C70
        public void get_Version(){} // RVA: 0xB5DBF0
        public void get_KeyDerivationAlgorithm(){} // RVA: 0xB465B0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0xB700F0
        public void get_EncryptedKey(){} // RVA: 0xB70160
        public void ToAsn1Object(){} // RVA: 0xA480E30
    }

    public class RecipientEncryptedKey : Asn1Encodable
    {
        public object identifier;
        public object encryptedKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void GetInstance(){} // RVA: 0xA481280
        public void get_Identifier(){} // RVA: 0xB5DBF0
        public void get_EncryptedKey(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA481450
    }

    public class RecipientIdentifier : Asn1Encodable
    {
        public object id;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetInstance(){} // RVA: 0xA481630
        public void get_IsTagged(){} // RVA: 0xA481970
        public void get_ID(){} // RVA: 0xA4819F0
        public void ToAsn1Object(){} // RVA: 0x10ACB60
    }

    public class RecipientInfo : Asn1Encodable
    {
        public object info;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetInstance(){} // RVA: 0xA481F30
        public void get_Version(){} // RVA: 0xA482170
        public void get_IsTagged(){} // RVA: 0xA482340
        public void get_Info(){} // RVA: 0xA4823C0
        public void GetKekInfo(){} // RVA: 0xA482560
        public void ToAsn1Object(){} // RVA: 0x10ACB60
    }

    public class RecipientKeyIdentifier : Asn1Encodable
    {
        public object subjectKeyIdentifier;
        public object date;
        public object other;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4827C0
        public void GetInstance(){} // RVA: 0xA482BE0
        public void get_SubjectKeyIdentifier(){} // RVA: 0xB5DBF0
        public void get_Date(){} // RVA: 0xB465B0
        public void get_OtherKeyAttribute(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA482DA0
    }

    public class ScvpReqRes : Asn1Encodable
    {
        public object request;
        public object response;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA482FF0
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_Request(){} // RVA: 0xB5DBF0
        public void get_Response(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA483360
    }

    public class SignedData : Asn1Encodable
    {
        public object Version1;
        public object Version3;
        public object Version4;
        public object Version5;
        public object version;
        public object digestAlgorithms;
        public object contentInfo;
        public object certificates;
        public object crls;
        public object signerInfos;
        public object certsBer;
        public object crlsBer;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA483540
        public void .ctor(){} // RVA: 0xA4840F0
        public void CalculateVersion(){} // RVA: 0xA483A40
        public void CheckForVersion3(){} // RVA: 0xA483F10
        public void get_Version(){} // RVA: 0xB5DBF0
        public void get_DigestAlgorithms(){} // RVA: 0xB465B0
        public void get_EncapContentInfo(){} // RVA: 0xB700F0
        public void get_Certificates(){} // RVA: 0xB70160
        public void get_CRLs(){} // RVA: 0xD33E60
        public void get_SignerInfos(){} // RVA: 0xD05CA0
        public void ToAsn1Object(){} // RVA: 0xA484710
        public void .cctor(){} // RVA: 0xA4849A0
    }

    public class SignedDataParser : Object
    {
        public object _seq;
        public object _version;
        public object _nextObject;
        public object _certsCalled;
        public object _crlsCalled;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA484C30
        public void .ctor(){} // RVA: 0xA484E20
        public void get_Version(){} // RVA: 0xB465B0
        public void GetDigestAlgorithms(){} // RVA: 0xA484FC0
        public void GetEncapContentInfo(){} // RVA: 0xA485060
        public void GetCertificates(){} // RVA: 0xA485130
        public void GetCrls(){} // RVA: 0xA4853B0
        public void GetSignerInfos(){} // RVA: 0xA485630
    }

    public class SignerIdentifier : Asn1Encodable
    {
        public object id;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetInstance(){} // RVA: 0xA485810
        public void get_IsTagged(){} // RVA: 0xA485B50
        public void get_ID(){} // RVA: 0xA485BD0
        public void ToAsn1Object(){} // RVA: 0x10ACB60
    }

    public class SignerInfo : Asn1Encodable
    {
        public object version;
        public object sid;
        public object digAlgorithm;
        public object authenticatedAttributes;
        public object digEncryptionAlgorithm;
        public object encryptedDigest;
        public object unauthenticatedAttributes;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA485D40
        public void .ctor(){} // RVA: 0xA486500
        public void get_Version(){} // RVA: 0xB5DBF0
        public void get_SignerID(){} // RVA: 0xB465B0
        public void get_AuthenticatedAttributes(){} // RVA: 0xB70160
        public void get_DigestAlgorithm(){} // RVA: 0xB700F0
        public void get_EncryptedDigest(){} // RVA: 0xD05CA0
        public void get_DigestEncryptionAlgorithm(){} // RVA: 0xD33E60
        public void get_UnauthenticatedAttributes(){} // RVA: 0xBC1B30
        public void ToAsn1Object(){} // RVA: 0xA486BA0
    }

    public class Time : Asn1Encodable
    {
        public object time;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA487480
        public void .ctor(){} // RVA: 0xA4870E0
        public void get_TimeString(){} // RVA: 0xA4876D0
        public void get_Date(){} // RVA: 0xA4877E0
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class TimeStampAndCrl : Asn1Encodable
    {
        public object timeStamp;
        public object crl;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4879C0
        public void GetInstance(){} // RVA: 0xA487B00
        public void get_TimeStampToken(){} // RVA: 0xB5DBF0
        public void get_Crl(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA487D00
    }

    public class TimeStampTokenEvidence : Asn1Encodable
    {
        public object timeStampAndCrls;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA488FF0
        public void GetInstance(){} // RVA: 0xA489470
        public void ToTimeStampAndCrlArray(){} // RVA: 0xA489550
        public void ToAsn1Object(){} // RVA: 0xA4895D0
    }

    public class TimeStampedData : Asn1Encodable
    {
        public object version;
        public object dataUri;
        public object metaData;
        public object content;
        public object temporalEvidence;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA488130
        public void GetInstance(){} // RVA: 0xA488580
        public void get_DataUri(){} // RVA: 0xB465B0
        public void get_MetaData(){} // RVA: 0xB700F0
        public void get_Content(){} // RVA: 0xB70160
        public void get_TemporalEvidence(){} // RVA: 0xD33E60
        public void ToAsn1Object(){} // RVA: 0xA488660
    }

    public class TimeStampedDataParser : Object
    {
        public object version;
        public object dataUri;
        public object metaData;
        public object content;
        public object temporalEvidence;
        public object parser;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4888B0
        public void GetInstance(){} // RVA: 0xA488CA0
        public void get_DataUri(){} // RVA: 0xB465B0
        public void get_MetaData(){} // RVA: 0xB700F0
        public void get_Content(){} // RVA: 0xB70160
        public void GetTemporalEvidence(){} // RVA: 0xA488E20
    }

}