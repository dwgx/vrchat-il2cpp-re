// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
// Classes: 47
// Methods: 294

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms
{
    public class Attribute : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B16040F0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_AttrType(){} // RVA: 0x7A80F2570
        public void get_AttrValues(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1604520
    }

    public class AttributeTable : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1604F30
        public void AddAttribute(){} // RVA: 0x7B1604F80
        public void get_Item(){} // RVA: 0x7B1605170
        public void Get(){} // RVA: 0x7B1605310
        public void GetAll(){} // RVA: 0x7B1605320
        public void get_Count(){} // RVA: 0x7B16056B0
        public void ToDictionary(){} // RVA: 0x7B1605970
        public void ToHashtable(){} // RVA: 0x7B16059D0
        public void ToAsn1EncodableVector(){} // RVA: 0x7B1605A40
        public void ToAttributes(){} // RVA: 0x7B1605DB0
        public void Add(){} // RVA: 0x7B1605EB0
        public void Remove(){} // RVA: 0x7B1605FA0
    }

    public class Attributes : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1604630
        public void GetInstance(){} // RVA: 0x7B16046F0
        public void GetAttributes(){} // RVA: 0x7B1604800
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class AuthEnvelopedData : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1608720
        public void GetInstance(){} // RVA: 0x7B1608DB0
        public void get_Version(){} // RVA: 0x7A80F2570
        public void get_OriginatorInfo(){} // RVA: 0x7A80DA7B0
        public void get_RecipientInfos(){} // RVA: 0x7A81052C0
        public void get_AuthEncryptedContentInfo(){} // RVA: 0x7A8105330
        public void get_AuthAttrs(){} // RVA: 0x7A83F69F0
        public void get_Mac(){} // RVA: 0x7A8292C30
        public void get_UnauthAttrs(){} // RVA: 0x7A8154D80
        public void ToAsn1Object(){} // RVA: 0x7B1608F70
    }

    public class AuthEnvelopedDataParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1609270
        public void get_Version(){} // RVA: 0x7A80DA7B0
        public void GetOriginatorInfo(){} // RVA: 0x7B1609410
        public void GetRecipientInfos(){} // RVA: 0x7B16096D0
        public void GetAuthEncryptedContentInfo(){} // RVA: 0x7B1609840
        public void GetAuthAttrs(){} // RVA: 0x7B16099D0
        public void GetMac(){} // RVA: 0x7B1609BD0
        public void GetUnauthAttrs(){} // RVA: 0x7B1609D10
    }

    public class AuthenticatedData : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1606440
        public void GetInstance(){} // RVA: 0x7B1606B50
        public void get_Version(){} // RVA: 0x7A80F2570
        public void get_OriginatorInfo(){} // RVA: 0x7A80DA7B0
        public void get_RecipientInfos(){} // RVA: 0x7A81052C0
        public void get_MacAlgorithm(){} // RVA: 0x7A8105330
        public void get_DigestAlgorithm(){} // RVA: 0x7A83F69F0
        public void get_EncapsulatedContentInfo(){} // RVA: 0x7A8292C30
        public void get_AuthAttrs(){} // RVA: 0x7A8154D80
        public void get_Mac(){} // RVA: 0x7A8152D80
        public void get_UnauthAttrs(){} // RVA: 0x7A8178B90
        public void ToAsn1Object(){} // RVA: 0x7B1606D10
        public void CalculateVersion(){} // RVA: 0x7B1607080
    }

    public class AuthenticatedDataParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1607430
        public void get_Version(){} // RVA: 0x7A80DA7B0
        public void GetOriginatorInfo(){} // RVA: 0x7B16075D0
        public void GetRecipientInfos(){} // RVA: 0x7B1607890
        public void GetMacAlgorithm(){} // RVA: 0x7B1607A00
        public void GetDigestAlgorithm(){} // RVA: 0x7B1607BA0
        public void GetEnapsulatedContentInfo(){} // RVA: 0x7B1607D80
        public void GetAuthAttrs(){} // RVA: 0x7B1607F10
        public void GetMac(){} // RVA: 0x7B1608110
        public void GetUnauthAttrs(){} // RVA: 0x7B1608250
    }

    public class CmsAttributes : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B1609F10
    }

    public class CmsObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B160A1F0
    }

    public class CompressedData : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B160AAE0
        public void GetInstance(){} // RVA: 0x7B160AD40
        public void get_Version(){} // RVA: 0x7A80F2570
        public void get_CompressionAlgorithmIdentifier(){} // RVA: 0x7A80DA7B0
        public void get_EncapContentInfo(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B160AF00
    }

    public class CompressedDataParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B160B090
        public void get_Version(){} // RVA: 0x7A80F2570
        public void get_CompressionAlgorithmIdentifier(){} // RVA: 0x7A80DA7B0
        public void GetEncapContentInfo(){} // RVA: 0x7A81052C0
    }

    public class ContentInfo : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B160B520
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_ContentType(){} // RVA: 0x7A80F2570
        public void get_Content(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B160B870
    }

    public class ContentInfoParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B160BA20
        public void get_ContentType(){} // RVA: 0x7A80F2570
        public void GetContent(){} // RVA: 0x7B160BC50
    }

    public class EncryptedContentInfo : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B160BCC0
        public void GetInstance(){} // RVA: 0x7B160C020
        public void get_ContentType(){} // RVA: 0x7A80F2570
        public void get_ContentEncryptionAlgorithm(){} // RVA: 0x7A80DA7B0
        public void get_EncryptedContent(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B160C1E0
    }

    public class EncryptedContentInfoParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B160C390
        public void get_ContentType(){} // RVA: 0x7A80F2570
        public void get_ContentEncryptionAlgorithm(){} // RVA: 0x7A80DA7B0
        public void GetEncryptedContent(){} // RVA: 0x7B160C650
    }

    public class EncryptedData : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B160C6B0
        public void .ctor(){} // RVA: 0x7B160CA60
        public void get_Version(){} // RVA: 0x7A80F2570
        public void get_EncryptedContentInfo(){} // RVA: 0x7A80DA7B0
        public void get_UnprotectedAttrs(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B160CCB0
    }

    public class EnvelopedData : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B160D2F0
        public void GetInstance(){} // RVA: 0x7B160D740
        public void get_Version(){} // RVA: 0x7A80F2570
        public void get_OriginatorInfo(){} // RVA: 0x7A80DA7B0
        public void get_RecipientInfos(){} // RVA: 0x7A81052C0
        public void get_EncryptedContentInfo(){} // RVA: 0x7A8105330
        public void get_UnprotectedAttrs(){} // RVA: 0x7A83F69F0
        public void ToAsn1Object(){} // RVA: 0x7B160D820
        public void CalculateVersion(){} // RVA: 0x7B160DAB0
    }

    public class EnvelopedDataParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B160DCD0
        public void get_Version(){} // RVA: 0x7A80DA7B0
        public void GetOriginatorInfo(){} // RVA: 0x7B160DE70
        public void GetRecipientInfos(){} // RVA: 0x7B160E130
        public void GetEncryptedContentInfo(){} // RVA: 0x7B160E2A0
        public void GetUnprotectedAttrs(){} // RVA: 0x7B160E430
    }

    public class Evidence : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B160E630
        public void GetInstance(){} // RVA: 0x7B160EA20
        public void get_TstEvidence(){} // RVA: 0x7A80F2570
        public void ToAsn1Object(){} // RVA: 0x7B160EA70
    }

    public class IssuerAndSerialNumber : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B160EB00
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_Name(){} // RVA: 0x7A80F2570
        public void get_SerialNumber(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B160EF80
    }

    public class KekIdentifier : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B160F2A0
        public void GetInstance(){} // RVA: 0x7B160F750
        public void get_KeyIdentifier(){} // RVA: 0x7A80F2570
        public void get_Date(){} // RVA: 0x7A80DA7B0
        public void get_Other(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B160F910
    }

    public class KekRecipientInfo : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B160FD30
        public void GetInstance(){} // RVA: 0x7B1610080
        public void get_Version(){} // RVA: 0x7A80F2570
        public void get_KekID(){} // RVA: 0x7A80DA7B0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0x7A81052C0
        public void get_EncryptedKey(){} // RVA: 0x7A8105330
        public void ToAsn1Object(){} // RVA: 0x7B1610240
    }

    public class KeyAgreeRecipientIdentifier : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1610400
        public void .ctor(){} // RVA: 0x7A813E420
        public void get_IssuerAndSerialNumber(){} // RVA: 0x7A80F2570
        public void get_RKeyID(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1610750
    }

    public class KeyAgreeRecipientInfo : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1610A10
        public void GetInstance(){} // RVA: 0x7B1610F50
        public void get_Version(){} // RVA: 0x7A80F2570
        public void get_Originator(){} // RVA: 0x7A80DA7B0
        public void get_UserKeyingMaterial(){} // RVA: 0x7A81052C0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0x7A8105330
        public void get_RecipientEncryptedKeys(){} // RVA: 0x7A83F69F0
        public void ToAsn1Object(){} // RVA: 0x7B1611110
    }

    public class KeyTransRecipientInfo : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16117A0
        public void GetInstance(){} // RVA: 0x7B1611AD0
        public void get_Version(){} // RVA: 0x7A80F2570
        public void get_RecipientIdentifier(){} // RVA: 0x7A80DA7B0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0x7A81052C0
        public void get_EncryptedKey(){} // RVA: 0x7A8105330
        public void ToAsn1Object(){} // RVA: 0x7B1611C90
    }

    public class MetaData : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1611E30
        public void GetInstance(){} // RVA: 0x7B16122D0
        public void ToAsn1Object(){} // RVA: 0x7B16123B0
        public void get_IsHashProtected(){} // RVA: 0x7B1612640
        public void get_FileName(){} // RVA: 0x7A80DA7B0
        public void get_MediaType(){} // RVA: 0x7A81052C0
        public void get_OtherMetaData(){} // RVA: 0x7A8105330
    }

    public class OriginatorIdentifierOrKey : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetInstance(){} // RVA: 0x7B1612990
        public void get_ID(){} // RVA: 0x7A80F2570
        public void get_IssuerAndSerialNumber(){} // RVA: 0x7B1612DC0
        public void get_SubjectKeyIdentifier(){} // RVA: 0x7B1612E60
        public void get_OriginatorKey(){} // RVA: 0x7B1612FD0
        public void get_OriginatorPublicKey(){} // RVA: 0x7B1612FE0
        public void ToAsn1Object(){} // RVA: 0x7A858AB20
    }

    public class OriginatorInfo : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16130A0
        public void GetInstance(){} // RVA: 0x7B1613470
        public void get_Certificates(){} // RVA: 0x7A80F2570
        public void get_Crls(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1613630
    }

    public class OriginatorPublicKey : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1613900
        public void GetInstance(){} // RVA: 0x7B1613A80
        public void get_Algorithm(){} // RVA: 0x7A80F2570
        public void get_PublicKey(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1613D50
    }

    public class OtherKeyAttribute : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1613E60
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_KeyAttrId(){} // RVA: 0x7A80F2570
        public void get_KeyAttr(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B16143A0
    }

    public class OtherRecipientInfo : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16144B0
        public void GetInstance(){} // RVA: 0x7B1614620
        public void get_OriType(){} // RVA: 0x7A80F2570
        public void get_OriValue(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1614800
    }

    public class OtherRevocationInfoFormat : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1614910
        public void GetInstance(){} // RVA: 0x7B1614A80
        public void get_InfoFormat(){} // RVA: 0x7A80F2570
        public void get_Info(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1614CA0
    }

    public class PasswordRecipientInfo : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16150F0
        public void GetInstance(){} // RVA: 0x7B16156B0
        public void get_Version(){} // RVA: 0x7A80F2570
        public void get_KeyDerivationAlgorithm(){} // RVA: 0x7A80DA7B0
        public void get_KeyEncryptionAlgorithm(){} // RVA: 0x7A81052C0
        public void get_EncryptedKey(){} // RVA: 0x7A8105330
        public void ToAsn1Object(){} // RVA: 0x7B1615870
    }

    public class RecipientEncryptedKey : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void GetInstance(){} // RVA: 0x7B1615CC0
        public void get_Identifier(){} // RVA: 0x7A80F2570
        public void get_EncryptedKey(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1615E90
    }

    public class RecipientIdentifier : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetInstance(){} // RVA: 0x7B1616070
        public void get_IsTagged(){} // RVA: 0x7B16163B0
        public void get_ID(){} // RVA: 0x7B1616430
        public void ToAsn1Object(){} // RVA: 0x7A858AB20
    }

    public class RecipientInfo : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetInstance(){} // RVA: 0x7B1616970
        public void get_Version(){} // RVA: 0x7B1616BB0
        public void get_IsTagged(){} // RVA: 0x7B1616D80
        public void get_Info(){} // RVA: 0x7B1616E00
        public void GetKekInfo(){} // RVA: 0x7B1616FA0
        public void ToAsn1Object(){} // RVA: 0x7A858AB20
    }

    public class RecipientKeyIdentifier : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1617200
        public void GetInstance(){} // RVA: 0x7B1617620
        public void get_SubjectKeyIdentifier(){} // RVA: 0x7A80F2570
        public void get_Date(){} // RVA: 0x7A80DA7B0
        public void get_OtherKeyAttribute(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B16177E0
    }

    public class ScvpReqRes : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1617A30
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_Request(){} // RVA: 0x7A80F2570
        public void get_Response(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1617DA0
    }

    public class SignedData : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1617F80
        public void .ctor(){} // RVA: 0x7B1618B30
        public void CalculateVersion(){} // RVA: 0x7B1618480
        public void CheckForVersion3(){} // RVA: 0x7B1618950
        public void get_Version(){} // RVA: 0x7A80F2570
        public void get_DigestAlgorithms(){} // RVA: 0x7A80DA7B0
        public void get_EncapContentInfo(){} // RVA: 0x7A81052C0
        public void get_Certificates(){} // RVA: 0x7A8105330
        public void get_CRLs(){} // RVA: 0x7A83F69F0
        public void get_SignerInfos(){} // RVA: 0x7A8292C30
        public void ToAsn1Object(){} // RVA: 0x7B1619150
        public void .cctor(){} // RVA: 0x7B16193E0
    }

    public class SignedDataParser : Object
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1619670
        public void .ctor(){} // RVA: 0x7B1619860
        public void get_Version(){} // RVA: 0x7A80DA7B0
        public void GetDigestAlgorithms(){} // RVA: 0x7B1619A00
        public void GetEncapContentInfo(){} // RVA: 0x7B1619AA0
        public void GetCertificates(){} // RVA: 0x7B1619B70
        public void GetCrls(){} // RVA: 0x7B1619DF0
        public void GetSignerInfos(){} // RVA: 0x7B161A070
    }

    public class SignerIdentifier : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetInstance(){} // RVA: 0x7B161A250
        public void get_IsTagged(){} // RVA: 0x7B161A590
        public void get_ID(){} // RVA: 0x7B161A610
        public void ToAsn1Object(){} // RVA: 0x7A858AB20
    }

    public class SignerInfo : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B161A780
        public void .ctor(){} // RVA: 0x7B161AF40
        public void get_Version(){} // RVA: 0x7A80F2570
        public void get_SignerID(){} // RVA: 0x7A80DA7B0
        public void get_AuthenticatedAttributes(){} // RVA: 0x7A8105330
        public void get_DigestAlgorithm(){} // RVA: 0x7A81052C0
        public void get_EncryptedDigest(){} // RVA: 0x7A8292C30
        public void get_DigestEncryptionAlgorithm(){} // RVA: 0x7A83F69F0
        public void get_UnauthenticatedAttributes(){} // RVA: 0x7A8154D80
        public void ToAsn1Object(){} // RVA: 0x7B161B5E0
    }

    public class Time : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B161BDF0
        public void .ctor(){} // RVA: 0x7B161BB20
        public void get_TimeString(){} // RVA: 0x7B161C040
        public void get_Date(){} // RVA: 0x7B161C150
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class TimeStampAndCrl : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B161C330
        public void GetInstance(){} // RVA: 0x7B161C470
        public void get_TimeStampToken(){} // RVA: 0x7A80F2570
        public void get_Crl(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B161C670
    }

    public class TimeStampTokenEvidence : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B161D960
        public void GetInstance(){} // RVA: 0x7B161DDE0
        public void ToTimeStampAndCrlArray(){} // RVA: 0x7B161DEC0
        public void ToAsn1Object(){} // RVA: 0x7B161DF40
    }

    public class TimeStampedData : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B161CAA0
        public void GetInstance(){} // RVA: 0x7B161CEF0
        public void get_DataUri(){} // RVA: 0x7A80DA7B0
        public void get_MetaData(){} // RVA: 0x7A81052C0
        public void get_Content(){} // RVA: 0x7A8105330
        public void get_TemporalEvidence(){} // RVA: 0x7A83F69F0
        public void ToAsn1Object(){} // RVA: 0x7B161CFD0
    }

    public class TimeStampedDataParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B161D220
        public void GetInstance(){} // RVA: 0x7B161D610
        public void get_DataUri(){} // RVA: 0x7A80DA7B0
        public void get_MetaData(){} // RVA: 0x7A81052C0
        public void get_Content(){} // RVA: 0x7A8105330
        public void GetTemporalEvidence(){} // RVA: 0x7B161D790
    }

}