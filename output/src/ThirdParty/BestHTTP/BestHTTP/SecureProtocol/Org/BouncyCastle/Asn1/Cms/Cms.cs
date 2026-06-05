// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
// Classes: 47
// Methods: 373

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
{
    public class Attribute
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC2797D0
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x2
        public void get_AttrType(){} // RVA: 0x7FFAF2DA8380
        public void get_AttrValues(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC279C00
    }

    public class AttributeTable
    {
        public object Version;
        public object OriginatorInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC27A650 | overloaded x5
        public void AddAttribute(){} // RVA: 0x7FFAFC27A6A0
        public void get_Item(){} // RVA: 0x7FFAFC27A890
        public void Get(){} // RVA: 0x7FFAFC27AA30
        public void GetAll(){} // RVA: 0x7FFAFC27AA40
        public void get_Count(){} // RVA: 0x7FFAFC27ADF0
        public void ToDictionary(){} // RVA: 0x7FFAFC27B0C0
        public void ToHashtable(){} // RVA: 0x7FFAFC27B120
        public void ToAsn1EncodableVector(){} // RVA: 0x7FFAFC27B190
        public void ToAttributes(){} // RVA: 0x7FFAFC27B510
        public void Add(){} // RVA: 0x7FFAFC27B610
        public void Remove(){} // RVA: 0x7FFAFC27B700
    }

    public class Attributes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC279D10 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC279DD0
        public void GetAttributes(){} // RVA: 0x7FFAFC279EF0
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class AuthEnvelopedData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC27DEB0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC27E540 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAF2DA8380
        public void get_OriginatorInfo(){} // RVA: 0x7FFAF2D907C0
        public void get_RecipientInfos(){} // RVA: 0x7FFAF2DBB0C0
        public void get_AuthEncryptedContentInfo(){} // RVA: 0x7FFAF2DBB130
        public void get_AuthAttrs(){} // RVA: 0x7FFAF30E74D0
        public void get_Mac(){} // RVA: 0x7FFAF2F476A0
        public void get_UnauthAttrs(){} // RVA: 0x7FFAF2E0A740
        public void ToAsn1Object(){} // RVA: 0x7FFAFC27E700
    }

    public class AuthEnvelopedDataParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC27EA00
        public void get_Version(){} // RVA: 0x7FFAF2D907C0
        public void GetOriginatorInfo(){} // RVA: 0x7FFAFC27EBA0
        public void GetRecipientInfos(){} // RVA: 0x7FFAFC27EE60
        public void GetAuthEncryptedContentInfo(){} // RVA: 0x7FFAFC27EFD0
        public void GetAuthAttrs(){} // RVA: 0x7FFAFC27F160
        public void GetMac(){} // RVA: 0x7FFAFC27F360
        public void GetUnauthAttrs(){} // RVA: 0x7FFAFC27F4A0
    }

    public class AuthenticatedData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC27BBA0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC27C2C0 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAF2DA8380
        public void get_OriginatorInfo(){} // RVA: 0x7FFAF2D907C0
        public void get_RecipientInfos(){} // RVA: 0x7FFAF2DBB0C0
        public void get_MacAlgorithm(){} // RVA: 0x7FFAF2DBB130
        public void get_DigestAlgorithm(){} // RVA: 0x7FFAF30E74D0
        public void get_EncapsulatedContentInfo(){} // RVA: 0x7FFAF2F476A0
        public void get_AuthAttrs(){} // RVA: 0x7FFAF2E0A740
        public void get_Mac(){} // RVA: 0x7FFAF2E08730
        public void get_UnauthAttrs(){} // RVA: 0x7FFAF2E2E0E0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC27C480
        public void CalculateVersion(){} // RVA: 0x7FFAFC27C7F0
    }

    public class AuthenticatedDataParser
    {
        public object Version;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC27CBD0
        public void get_Version(){} // RVA: 0x7FFAF2D907C0
        public void GetOriginatorInfo(){} // RVA: 0x7FFAFC27CD70
        public void GetRecipientInfos(){} // RVA: 0x7FFAFC27D030
        public void GetMacAlgorithm(){} // RVA: 0x7FFAFC27D1A0
        public void GetDigestAlgorithm(){} // RVA: 0x7FFAFC27D340
        public void GetEnapsulatedContentInfo(){} // RVA: 0x7FFAFC27D520
        public void GetAuthAttrs(){} // RVA: 0x7FFAFC27D6B0
        public void GetMac(){} // RVA: 0x7FFAFC27D8B0
        public void GetUnauthAttrs(){} // RVA: 0x7FFAFC27D9F0
    }

    public class CmsAttributes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC27F6A0
    }

    public class CmsObjectIdentifiers
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC27F980
    }

    public class CompressedData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC280270 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC2804D0 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAF2DA8380
        public void get_CompressionAlgorithmIdentifier(){} // RVA: 0x7FFAF2D907C0
        public void get_EncapContentInfo(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC280690
    }

    public class CompressedDataParser
    {
        public object ContentType;
        public object Content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC280820
        public void get_Version(){} // RVA: 0x7FFAF2DA8380
        public void get_CompressionAlgorithmIdentifier(){} // RVA: 0x7FFAF2D907C0
        public void GetEncapContentInfo(){} // RVA: 0x7FFAF2DBB0C0
    }

    public class ContentInfo
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC280CB0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x2
        public void get_ContentType(){} // RVA: 0x7FFAF2DA8380
        public void get_Content(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC281000
    }

    public class ContentInfoParser
    {
        public object ContentType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2811B0
        public void get_ContentType(){} // RVA: 0x7FFAF2DA8380
        public void GetContent(){} // RVA: 0x7FFAFC2813E0
    }

    public class EncryptedContentInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC281450 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC2817B0
        public void get_ContentType(){} // RVA: 0x7FFAF2DA8380
        public void get_ContentEncryptionAlgorithm(){} // RVA: 0x7FFAF2D907C0
        public void get_EncryptedContent(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC281970
    }

    public class EncryptedContentInfoParser
    {
        public object Version;
        public object EncryptedContentInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC281B20
        public void get_ContentType(){} // RVA: 0x7FFAF2DA8380
        public void get_ContentEncryptionAlgorithm(){} // RVA: 0x7FFAF2D907C0
        public void GetEncryptedContent(){} // RVA: 0x7FFAFC281DE0
    }

    public class EncryptedData
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC281E40
        public void .ctor(){} // RVA: 0x7FFAFC2821F0 | overloaded x3
        public void get_Version(){} // RVA: 0x7FFAF2DA8380
        public void get_EncryptedContentInfo(){} // RVA: 0x7FFAF2D907C0
        public void get_UnprotectedAttrs(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC282440
    }

    public class EnvelopedData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC282A80 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC282ED0 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAF2DA8380
        public void get_OriginatorInfo(){} // RVA: 0x7FFAF2D907C0
        public void get_RecipientInfos(){} // RVA: 0x7FFAF2DBB0C0
        public void get_EncryptedContentInfo(){} // RVA: 0x7FFAF2DBB130
        public void get_UnprotectedAttrs(){} // RVA: 0x7FFAF30E74D0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC282FB0
        public void CalculateVersion(){} // RVA: 0x7FFAFC283240
    }

    public class EnvelopedDataParser
    {
        public object TstEvidence;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC283470
        public void get_Version(){} // RVA: 0x7FFAF2D907C0
        public void GetOriginatorInfo(){} // RVA: 0x7FFAFC283610
        public void GetRecipientInfos(){} // RVA: 0x7FFAFC2838D0
        public void GetEncryptedContentInfo(){} // RVA: 0x7FFAFC283A40
        public void GetUnprotectedAttrs(){} // RVA: 0x7FFAFC283BD0
    }

    public class Evidence : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC283DD0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC2841C0 | overloaded x2
        public void get_TstEvidence(){} // RVA: 0x7FFAF2DA8380
        public void ToAsn1Object(){} // RVA: 0x7FFAFC284210
    }

    public class IssuerAndSerialNumber
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC2842A0
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x3
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void get_SerialNumber(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC284720
    }

    public class KekIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC284A40 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC284EF0 | overloaded x2
        public void get_KeyIdentifier(){} // RVA: 0x7FFAF2DA8380
        public void get_Date(){} // RVA: 0x7FFAF2D907C0
        public void get_Other(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC2850B0
    }

    public class KekRecipientInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2854B0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC2859B0 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAF2DA8380
        public void get_KekID(){} // RVA: 0x7FFAF2D907C0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0x7FFAF2DBB0C0
        public void get_EncryptedKey(){} // RVA: 0x7FFAF2DBB130
        public void ToAsn1Object(){} // RVA: 0x7FFAFC285B70
    }

    public class KeyAgreeRecipientIdentifier
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC285D30 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF2DF3E80 | overloaded x2
        public void get_IssuerAndSerialNumber(){} // RVA: 0x7FFAF2DA8380
        public void get_RKeyID(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC286080
    }

    public class KeyAgreeRecipientInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC286330 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC286A20 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAF2DA8380
        public void get_Originator(){} // RVA: 0x7FFAF2D907C0
        public void get_UserKeyingMaterial(){} // RVA: 0x7FFAF2DBB0C0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0x7FFAF2DBB130
        public void get_RecipientEncryptedKeys(){} // RVA: 0x7FFAF30E74D0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC286BE0
    }

    public class KeyTransRecipientInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC287250 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC287580
        public void get_Version(){} // RVA: 0x7FFAF2DA8380
        public void get_RecipientIdentifier(){} // RVA: 0x7FFAF2D907C0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0x7FFAF2DBB0C0
        public void get_EncryptedKey(){} // RVA: 0x7FFAF2DBB130
        public void ToAsn1Object(){} // RVA: 0x7FFAFC287740
    }

    public class MetaData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2878E0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC287D80
        public void ToAsn1Object(){} // RVA: 0x7FFAFC287E60
        public void get_IsHashProtected(){} // RVA: 0x7FFAFC2880E0
        public void get_FileName(){} // RVA: 0x7FFAF2D907C0
        public void get_MediaType(){} // RVA: 0x7FFAF2DBB0C0
        public void get_OtherMetaData(){} // RVA: 0x7FFAF2DBB130
    }

    public class OriginatorIdentifierOrKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x6
        public void GetInstance(){} // RVA: 0x7FFAFC288430 | overloaded x2
        public void get_ID(){} // RVA: 0x7FFAF2DA8380
        public void get_IssuerAndSerialNumber(){} // RVA: 0x7FFAFC288870
        public void get_SubjectKeyIdentifier(){} // RVA: 0x7FFAFC288910
        public void get_OriginatorKey(){} // RVA: 0x7FFAFC288A80
        public void get_OriginatorPublicKey(){} // RVA: 0x7FFAFC288A90
        public void ToAsn1Object(){} // RVA: 0x7FFAF32A0250
    }

    public class OriginatorInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC288B50 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC288F10 | overloaded x2
        public void get_Certificates(){} // RVA: 0x7FFAF2DA8380
        public void get_Crls(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC2890D0
    }

    public class OriginatorPublicKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2893A0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC289520 | overloaded x2
        public void get_Algorithm(){} // RVA: 0x7FFAF2DA8380
        public void get_PublicKey(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC2897F0
    }

    public class OtherKeyAttribute
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC289900
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x2
        public void get_KeyAttrId(){} // RVA: 0x7FFAF2DA8380
        public void get_KeyAttr(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC289CA0
    }

    public class OtherRecipientInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC289DB0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC289F20 | overloaded x2
        public void get_OriType(){} // RVA: 0x7FFAF2DA8380
        public void get_OriValue(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC28A100
    }

    public class OtherRevocationInfoFormat
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC28A210 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC28A380 | overloaded x2
        public void get_InfoFormat(){} // RVA: 0x7FFAF2DA8380
        public void get_Info(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC28A5A0
    }

    public class PasswordRecipientInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC28A9E0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC28B150 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAF2DA8380
        public void get_KeyDerivationAlgorithm(){} // RVA: 0x7FFAF2D907C0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0x7FFAF2DBB0C0
        public void get_EncryptedKey(){} // RVA: 0x7FFAF2DBB130
        public void ToAsn1Object(){} // RVA: 0x7FFAFC28B310
    }

    public class RecipientEncryptedKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC28B760 | overloaded x2
        public void get_Identifier(){} // RVA: 0x7FFAF2DA8380
        public void get_EncryptedKey(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC28B930
    }

    public class RecipientIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC28BB10
        public void get_IsTagged(){} // RVA: 0x7FFAFC28BE50
        public void get_ID(){} // RVA: 0x7FFAFC28BEE0
        public void ToAsn1Object(){} // RVA: 0x7FFAF32A0250
    }

    public class RecipientInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x6
        public void GetInstance(){} // RVA: 0x7FFAFC28C420
        public void get_Version(){} // RVA: 0x7FFAFC28C670
        public void get_IsTagged(){} // RVA: 0x7FFAFC28C810
        public void get_Info(){} // RVA: 0x7FFAFC28C8A0
        public void GetKekInfo(){} // RVA: 0x7FFAFC28CA20
        public void ToAsn1Object(){} // RVA: 0x7FFAF32A0250
    }

    public class RecipientKeyIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC28CC80 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFAFC28D250 | overloaded x2
        public void get_SubjectKeyIdentifier(){} // RVA: 0x7FFAF2DA8380
        public void get_Date(){} // RVA: 0x7FFAF2D907C0
        public void get_OtherKeyAttribute(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC28D410
    }

    public class ScvpReqRes
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC28D650
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x3
        public void get_Request(){} // RVA: 0x7FFAF2DA8380
        public void get_Response(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC28D9C0
    }

    public class SignedData
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC28DB90
        public void .ctor(){} // RVA: 0x7FFAFC28E780 | overloaded x2
        public void CalculateVersion(){} // RVA: 0x7FFAFC28E090
        public void CheckForVersion3(){} // RVA: 0x7FFAFC28E590
        public void get_Version(){} // RVA: 0x7FFAF2DA8380
        public void get_DigestAlgorithms(){} // RVA: 0x7FFAF2D907C0
        public void get_EncapContentInfo(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Certificates(){} // RVA: 0x7FFAF2DBB130
        public void get_CRLs(){} // RVA: 0x7FFAF30E74D0
        public void get_SignerInfos(){} // RVA: 0x7FFAF2F476A0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC28EDA0
        public void .cctor(){} // RVA: 0x7FFAFC28F030
    }

    public class SignedDataParser
    {
        public object IsTagged;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC28F2C0
        public void .ctor(){} // RVA: 0x7FFAFC28F4B0
        public void get_Version(){} // RVA: 0x7FFAF2D907C0
        public void GetDigestAlgorithms(){} // RVA: 0x7FFAFC28F650
        public void GetEncapContentInfo(){} // RVA: 0x7FFAFC28F6F0
        public void GetCertificates(){} // RVA: 0x7FFAFC28F7C0
        public void GetCrls(){} // RVA: 0x7FFAFC28FA40
        public void GetSignerInfos(){} // RVA: 0x7FFAFC28FCC0
    }

    public class SignerIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC28FEA0
        public void get_IsTagged(){} // RVA: 0x7FFAFC2901E0
        public void get_ID(){} // RVA: 0x7FFAFC290270
        public void ToAsn1Object(){} // RVA: 0x7FFAF32A0250
    }

    public class SignerInfo
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC2903C0
        public void .ctor(){} // RVA: 0x7FFAFC290B80 | overloaded x3
        public void get_Version(){} // RVA: 0x7FFAF2DA8380
        public void get_SignerID(){} // RVA: 0x7FFAF2D907C0
        public void get_AuthenticatedAttributes(){} // RVA: 0x7FFAF2DBB130
        public void get_DigestAlgorithm(){} // RVA: 0x7FFAF2DBB0C0
        public void get_EncryptedDigest(){} // RVA: 0x7FFAF2F476A0
        public void get_DigestEncryptionAlgorithm(){} // RVA: 0x7FFAF30E74D0
        public void get_UnauthenticatedAttributes(){} // RVA: 0x7FFAF2E0A740
        public void ToAsn1Object(){} // RVA: 0x7FFAFC291220
    }

    public class Time
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC291A30 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC291760 | overloaded x2
        public void get_TimeString(){} // RVA: 0x7FFAFC291C80
        public void get_Date(){} // RVA: 0x7FFAFC291DA0
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class TimeStampAndCrl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC291FB0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC2920F0
        public void get_TimeStampToken(){} // RVA: 0x7FFAF2DA8380
        public void get_Crl(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC2922F0
    }

    public class TimeStampTokenEvidence
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2935B0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC293A40 | overloaded x2
        public void ToTimeStampAndCrlArray(){} // RVA: 0x7FFAFC293B20
        public void ToAsn1Object(){} // RVA: 0x7FFAFC293BA0
    }

    public class TimeStampedData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC292700 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC292B50
        public void get_DataUri(){} // RVA: 0x7FFAF2D907C0
        public void get_MetaData(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Content(){} // RVA: 0x7FFAF2DBB130
        public void get_TemporalEvidence(){} // RVA: 0x7FFAF30E74D0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC292C30
    }

    public class TimeStampedDataParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC292E70
        public void GetInstance(){} // RVA: 0x7FFAFC293260
        public void get_DataUri(){} // RVA: 0x7FFAF2D907C0
        public void get_MetaData(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Content(){} // RVA: 0x7FFAF2DBB130
        public void GetTemporalEvidence(){} // RVA: 0x7FFAFC2933E0
    }

}