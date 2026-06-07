// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp
// Classes: 38
// Methods: 261

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp
{
    public class CAKeyUpdAnnContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97E4230
        public void GetInstance(){} // RVA: 0x97E43C0
        public void get_OldWithNew(){} // RVA: 0x2F8380
        public void get_NewWithOld(){} // RVA: 0x2E07C0
        public void get_NewWithNew(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97E45A0
    }

    public class CertConfirmContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetInstance(){} // RVA: 0x97E4700
        public void ToCertStatusArray(){} // RVA: 0x97E4910
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class CertOrEncCert
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97E5C90 | overloaded x3
        public void GetInstance(){} // RVA: 0x97E5A00
        public void get_Certificate(){} // RVA: 0x2F8380
        public void get_EncryptedCert(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97E5D40
    }

    public class CertRepMessage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97E6270 | overloaded x2
        public void GetInstance(){} // RVA: 0x97E6090
        public void GetCAPubs(){} // RVA: 0x97E6400
        public void GetResponse(){} // RVA: 0x97E6570
        public void ToAsn1Object(){} // RVA: 0x97E68A0
    }

    public class CertResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97E6F50 | overloaded x3
        public void GetInstance(){} // RVA: 0x97E6D50
        public void get_CertReqID(){} // RVA: 0x2F8380
        public void get_Status(){} // RVA: 0x2E07C0
        public void get_CertifiedKeyPair(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97E7160
    }

    public class CertStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97E7840 | overloaded x3
        public void GetInstance(){} // RVA: 0x97E7B00
        public void get_CertHash(){} // RVA: 0x2F8380
        public void get_CertReqID(){} // RVA: 0x2E07C0
        public void get_StatusInfo(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97E7CE0
    }

    public class CertifiedKeyPair
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97E53B0 | overloaded x3
        public void GetInstance(){} // RVA: 0x97E5070
        public void get_CertOrEncCert(){} // RVA: 0x2F8380
        public void get_PrivateKey(){} // RVA: 0x2E07C0
        public void get_PublicationInfo(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97E5510
    }

    public class Challenge
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97E7F20
        public void GetInstance(){} // RVA: 0x97E8110
        public void get_Owf(){} // RVA: 0x2F8380
        public void ToAsn1Object(){} // RVA: 0x97E82F0
    }

    public class CmpCertificate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97E8540 | overloaded x2
        public void GetInstance(){} // RVA: 0x97E8620
        public void get_IsX509v3PKCert(){} // RVA: 0xF01170
        public void get_X509v3PKCert(){} // RVA: 0x2F8380
        public void get_X509v2AttrCert(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97E89B0
    }

    public class CmpObjectIdentifiers
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x97E8AB0
    }

    public class CrlAnnContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetInstance(){} // RVA: 0x97E9B60
        public void ToCertificateListArray(){} // RVA: 0x97E9D70
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class ErrorMsgContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97EA4E0 | overloaded x3
        public void GetInstance(){} // RVA: 0x97EA060
        public void get_PkiStatusInfo(){} // RVA: 0x2F8380
        public void get_ErrorCode(){} // RVA: 0x2E07C0
        public void get_ErrorDetails(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97EA640
    }

    public class GenMsgContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97EAA90 | overloaded x2
        public void GetInstance(){} // RVA: 0x97EA880
        public void ToInfoTypeAndValueArray(){} // RVA: 0x97EAB50
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class GenRepContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97EAED0 | overloaded x2
        public void GetInstance(){} // RVA: 0x97EACC0
        public void ToInfoTypeAndValueArray(){} // RVA: 0x97EAF90
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class InfoTypeAndValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x3
        public void GetInstance(){} // RVA: 0x97EB270
        public void get_InfoType(){} // RVA: 0x2F8380
        public void get_InfoValue(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97EB580
    }

    public class KeyRecRepContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97EB780
        public void GetInstance(){} // RVA: 0x97EB9F0
        public void get_Status(){} // RVA: 0x2F8380
        public void get_NewSigCert(){} // RVA: 0x2E07C0
        public void GetCACerts(){} // RVA: 0x97EBBD0
        public void GetKeyPairHist(){} // RVA: 0x97EBD40
        public void ToAsn1Object(){} // RVA: 0x97EBEB0
    }

    public class OobCertHash
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97EC290
        public void GetInstance(){} // RVA: 0x97EC460
        public void get_HashAlg(){} // RVA: 0x2F8380
        public void get_CertID(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97EC640
    }

    public class PbmParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x325A50 | overloaded x3
        public void GetInstance(){} // RVA: 0x97ECAE0
        public void get_Salt(){} // RVA: 0x2F8380
        public void get_Owf(){} // RVA: 0x2E07C0
        public void get_IterationCount(){} // RVA: 0x30B0C0
        public void get_Mac(){} // RVA: 0x30B130
        public void ToAsn1Object(){} // RVA: 0x97ECF50
    }

    public class PkiBody
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97ED0F0
        public void .ctor(){} // RVA: 0x97ED400 | overloaded x2
        public void GetBodyForType(){} // RVA: 0x97ED470
        public void get_Type(){} // RVA: 0x32A5C0
        public void get_Content(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97EE040
    }

    public class PkiConfirmContent
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97EE0C0
        public void .ctor(){} // RVA: 0x2DD310
        public void ToAsn1Object(){} // RVA: 0x97EE240
    }

    public class PkiFailureInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97EE300 | overloaded x2
        public void ToString(){} // RVA: 0x97EE3B0
    }

    public class PkiFreeText
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97EE4F0 | overloaded x2
        public void .ctor(){} // RVA: 0x97EE930 | overloaded x2
        public void get_Size(){} // RVA: 0x7F0310
        public void get_Count(){} // RVA: 0x7F0310
        public void get_Item(){} // RVA: 0x97EE9F0
        public void GetStringAt(){} // RVA: 0x97EEA90
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class PkiHeader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3BCE00 | overloaded x3
        public void GetInstance(){} // RVA: 0x97EF090
        public void get_Pvno(){} // RVA: 0x2F8380
        public void get_Sender(){} // RVA: 0x2E07C0
        public void get_Recipient(){} // RVA: 0x30B0C0
        public void get_MessageTime(){} // RVA: 0x30B130
        public void get_ProtectionAlg(){} // RVA: 0x6374D0
        public void get_SenderKID(){} // RVA: 0x4976A0
        public void get_RecipKID(){} // RVA: 0x35A740
        public void get_TransactionID(){} // RVA: 0x358730
        public void get_SenderNonce(){} // RVA: 0x37E0E0
        public void get_RecipNonce(){} // RVA: 0x3A5500
        public void get_FreeText(){} // RVA: 0x37B370
        public void GetGeneralInfo(){} // RVA: 0x97EF3E0
        public void ToAsn1Object(){} // RVA: 0x97EF550
        public void .cctor(){} // RVA: 0x97EFE90
    }

    public class PkiHeaderBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3BCE00 | overloaded x2
        public void SetMessageTime(){} // RVA: 0x1E7D3C0
        public void SetProtectionAlg(){} // RVA: 0x1E7D420
        public void SetSenderKID(){} // RVA: 0x1E7D480 | overloaded x2
        public void SetRecipKID(){} // RVA: 0x1E7D4E0 | overloaded x2
        public void SetTransactionID(){} // RVA: 0x1E7D540 | overloaded x2
        public void SetSenderNonce(){} // RVA: 0x1E7D5A0 | overloaded x2
        public void SetRecipNonce(){} // RVA: 0x1E7D600 | overloaded x2
        public void SetFreeText(){} // RVA: 0x1E7D660
        public void SetGeneralInfo(){} // RVA: 0x6EE2F30 | overloaded x3
        public void MakeGeneralInfoSeq(){} // RVA: 0x97F0680 | overloaded x2
        public void Build(){} // RVA: 0x97F08F0
        public void AddOptional(){} // RVA: 0x97F1590
    }

    public class PkiMessage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97F1B80 | overloaded x4
        public void GetInstance(){} // RVA: 0x97F18C0
        public void get_Header(){} // RVA: 0x2F8380
        public void get_Body(){} // RVA: 0x2E07C0
        public void get_Protection(){} // RVA: 0x30B0C0
        public void GetExtraCerts(){} // RVA: 0x97F1BA0
        public void ToAsn1Object(){} // RVA: 0x97F1D10
    }

    public class PkiMessages
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97F2270 | overloaded x2
        public void GetInstance(){} // RVA: 0x97F2060
        public void ToPkiMessageArray(){} // RVA: 0x97F2330
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class PkiStatusEncodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void GetInstance(){} // RVA: 0x97F2630
        public void get_Value(){} // RVA: 0x97799D0
        public void ToAsn1Object(){} // RVA: 0x2F8380
        public void .cctor(){} // RVA: 0x97F2810
    }

    public class PkiStatusInfo
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97F2C60 | overloaded x2
        public void .ctor(){} // RVA: 0x97F3360 | overloaded x4
        public void get_Status(){} // RVA: 0x97799D0
        public void get_StatusString(){} // RVA: 0x2E07C0
        public void get_FailInfo(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97F34D0
    }

    public class PollRepContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3BCE00 | overloaded x3
        public void GetInstance(){} // RVA: 0x97F38C0
        public void get_CertReqID(){} // RVA: 0x2F8380
        public void get_CheckAfter(){} // RVA: 0x2E07C0
        public void get_Reason(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97F3AA0
    }

    public class PollReqContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetInstance(){} // RVA: 0x97F3CE0
        public void GetCertReqIDs(){} // RVA: 0x97F3EF0
        public void SequenceToDerIntegerArray(){} // RVA: 0x97F4200
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class PopoDecKeyChallContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetInstance(){} // RVA: 0x97F4370
        public void ToChallengeArray(){} // RVA: 0x97F4580
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class PopoDecKeyRespContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetInstance(){} // RVA: 0x97F48B0
        public void ToDerIntegerArray(){} // RVA: 0x97F4AC0
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class ProtectedPart
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void GetInstance(){} // RVA: 0x97F4D90
        public void get_Header(){} // RVA: 0x2F8380
        public void get_Body(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97F5090
    }

    public class RevAnnContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97F51A0
        public void GetInstance(){} // RVA: 0x97F56A0
        public void get_Status(){} // RVA: 0x2F8380
        public void get_CertID(){} // RVA: 0x2E07C0
        public void get_WillBeRevokedAt(){} // RVA: 0x30B0C0
        public void get_BadSinceDate(){} // RVA: 0x30B130
        public void get_CrlDetails(){} // RVA: 0x6374D0
        public void ToAsn1Object(){} // RVA: 0x97F5880
    }

    public class RevDetails
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x3
        public void GetInstance(){} // RVA: 0x97F5CC0
        public void get_CertDetails(){} // RVA: 0x2F8380
        public void get_CrlEntryDetails(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97F5FE0
    }

    public class RevRepContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97F61E0
        public void GetInstance(){} // RVA: 0x97F6320
        public void GetStatus(){} // RVA: 0x97F6610
        public void GetRevCerts(){} // RVA: 0x97F6780
        public void GetCrls(){} // RVA: 0x97F68F0
        public void ToAsn1Object(){} // RVA: 0x97F6A60
    }

    public class RevRepContentBuilder
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x97F6DA0 | overloaded x2
        public void AddCrl(){} // RVA: 0x97F6E50
        public void Build(){} // RVA: 0x97F6E80
        public void .ctor(){} // RVA: 0x97F72A0
    }

    public class RevReqContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97F7650 | overloaded x2
        public void GetInstance(){} // RVA: 0x97F7440
        public void ToRevDetailsArray(){} // RVA: 0x97F7710
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

}