// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp
// Classes: 38
// Methods: 261

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp
{
    public class CAKeyUpdAnnContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC294230
        public void GetInstance(){} // RVA: 0x7FFAFC2943C0
        public void get_OldWithNew(){} // RVA: 0x7FFAF2DA8380
        public void get_NewWithOld(){} // RVA: 0x7FFAF2D907C0
        public void get_NewWithNew(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC2945A0
    }

    public class CertConfirmContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void GetInstance(){} // RVA: 0x7FFAFC294700
        public void ToCertStatusArray(){} // RVA: 0x7FFAFC294910
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class CertOrEncCert
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC295C90 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC295A00
        public void get_Certificate(){} // RVA: 0x7FFAF2DA8380
        public void get_EncryptedCert(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC295D40
    }

    public class CertRepMessage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC296270 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC296090
        public void GetCAPubs(){} // RVA: 0x7FFAFC296400
        public void GetResponse(){} // RVA: 0x7FFAFC296570
        public void ToAsn1Object(){} // RVA: 0x7FFAFC2968A0
    }

    public class CertResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC296F50 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC296D50
        public void get_CertReqID(){} // RVA: 0x7FFAF2DA8380
        public void get_Status(){} // RVA: 0x7FFAF2D907C0
        public void get_CertifiedKeyPair(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC297160
    }

    public class CertStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC297840 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC297B00
        public void get_CertHash(){} // RVA: 0x7FFAF2DA8380
        public void get_CertReqID(){} // RVA: 0x7FFAF2D907C0
        public void get_StatusInfo(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC297CE0
    }

    public class CertifiedKeyPair
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2953B0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC295070
        public void get_CertOrEncCert(){} // RVA: 0x7FFAF2DA8380
        public void get_PrivateKey(){} // RVA: 0x7FFAF2D907C0
        public void get_PublicationInfo(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC295510
    }

    public class Challenge
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC297F20
        public void GetInstance(){} // RVA: 0x7FFAFC298110
        public void get_Owf(){} // RVA: 0x7FFAF2DA8380
        public void ToAsn1Object(){} // RVA: 0x7FFAFC2982F0
    }

    public class CmpCertificate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC298540 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC298620
        public void get_IsX509v3PKCert(){} // RVA: 0x7FFAF39B1170
        public void get_X509v3PKCert(){} // RVA: 0x7FFAF2DA8380
        public void get_X509v2AttrCert(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC2989B0
    }

    public class CmpObjectIdentifiers
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC298AB0
    }

    public class CrlAnnContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void GetInstance(){} // RVA: 0x7FFAFC299B60
        public void ToCertificateListArray(){} // RVA: 0x7FFAFC299D70
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class ErrorMsgContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC29A4E0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC29A060
        public void get_PkiStatusInfo(){} // RVA: 0x7FFAF2DA8380
        public void get_ErrorCode(){} // RVA: 0x7FFAF2D907C0
        public void get_ErrorDetails(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC29A640
    }

    public class GenMsgContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC29AA90 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC29A880
        public void ToInfoTypeAndValueArray(){} // RVA: 0x7FFAFC29AB50
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class GenRepContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC29AED0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC29ACC0
        public void ToInfoTypeAndValueArray(){} // RVA: 0x7FFAFC29AF90
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class InfoTypeAndValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC29B270
        public void get_InfoType(){} // RVA: 0x7FFAF2DA8380
        public void get_InfoValue(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC29B580
    }

    public class KeyRecRepContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC29B780
        public void GetInstance(){} // RVA: 0x7FFAFC29B9F0
        public void get_Status(){} // RVA: 0x7FFAF2DA8380
        public void get_NewSigCert(){} // RVA: 0x7FFAF2D907C0
        public void GetCACerts(){} // RVA: 0x7FFAFC29BBD0
        public void GetKeyPairHist(){} // RVA: 0x7FFAFC29BD40
        public void ToAsn1Object(){} // RVA: 0x7FFAFC29BEB0
    }

    public class OobCertHash
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC29C290
        public void GetInstance(){} // RVA: 0x7FFAFC29C460
        public void get_HashAlg(){} // RVA: 0x7FFAF2DA8380
        public void get_CertID(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC29C640
    }

    public class PbmParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DD5A50 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC29CAE0
        public void get_Salt(){} // RVA: 0x7FFAF2DA8380
        public void get_Owf(){} // RVA: 0x7FFAF2D907C0
        public void get_IterationCount(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Mac(){} // RVA: 0x7FFAF2DBB130
        public void ToAsn1Object(){} // RVA: 0x7FFAFC29CF50
    }

    public class PkiBody
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC29D0F0
        public void .ctor(){} // RVA: 0x7FFAFC29D400 | overloaded x2
        public void GetBodyForType(){} // RVA: 0x7FFAFC29D470
        public void get_Type(){} // RVA: 0x7FFAF2DDA5C0
        public void get_Content(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC29E040
    }

    public class PkiConfirmContent
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC29E0C0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void ToAsn1Object(){} // RVA: 0x7FFAFC29E240
    }

    public class PkiFailureInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC29E300 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAFC29E3B0
    }

    public class PkiFreeText
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC29E4F0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC29E930 | overloaded x2
        public void get_Size(){} // RVA: 0x7FFAF32A0310
        public void get_Count(){} // RVA: 0x7FFAF32A0310
        public void get_Item(){} // RVA: 0x7FFAFC29E9F0
        public void GetStringAt(){} // RVA: 0x7FFAFC29EA90
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class PkiHeader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E6CE00 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC29F090
        public void get_Pvno(){} // RVA: 0x7FFAF2DA8380
        public void get_Sender(){} // RVA: 0x7FFAF2D907C0
        public void get_Recipient(){} // RVA: 0x7FFAF2DBB0C0
        public void get_MessageTime(){} // RVA: 0x7FFAF2DBB130
        public void get_ProtectionAlg(){} // RVA: 0x7FFAF30E74D0
        public void get_SenderKID(){} // RVA: 0x7FFAF2F476A0
        public void get_RecipKID(){} // RVA: 0x7FFAF2E0A740
        public void get_TransactionID(){} // RVA: 0x7FFAF2E08730
        public void get_SenderNonce(){} // RVA: 0x7FFAF2E2E0E0
        public void get_RecipNonce(){} // RVA: 0x7FFAF2E55500
        public void get_FreeText(){} // RVA: 0x7FFAF2E2B370
        public void GetGeneralInfo(){} // RVA: 0x7FFAFC29F3E0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC29F550
        public void .cctor(){} // RVA: 0x7FFAFC29FE90
    }

    public class PkiHeaderBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E6CE00 | overloaded x2
        public void SetMessageTime(){} // RVA: 0x7FFAF492D3C0
        public void SetProtectionAlg(){} // RVA: 0x7FFAF492D420
        public void SetSenderKID(){} // RVA: 0x7FFAF492D480 | overloaded x2
        public void SetRecipKID(){} // RVA: 0x7FFAF492D4E0 | overloaded x2
        public void SetTransactionID(){} // RVA: 0x7FFAF492D540 | overloaded x2
        public void SetSenderNonce(){} // RVA: 0x7FFAF492D5A0 | overloaded x2
        public void SetRecipNonce(){} // RVA: 0x7FFAF492D600 | overloaded x2
        public void SetFreeText(){} // RVA: 0x7FFAF492D660
        public void SetGeneralInfo(){} // RVA: 0x7FFAF9992F30 | overloaded x3
        public void MakeGeneralInfoSeq(){} // RVA: 0x7FFAFC2A0680 | overloaded x2
        public void Build(){} // RVA: 0x7FFAFC2A08F0
        public void AddOptional(){} // RVA: 0x7FFAFC2A1590
    }

    public class PkiMessage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2A1B80 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFAFC2A18C0
        public void get_Header(){} // RVA: 0x7FFAF2DA8380
        public void get_Body(){} // RVA: 0x7FFAF2D907C0
        public void get_Protection(){} // RVA: 0x7FFAF2DBB0C0
        public void GetExtraCerts(){} // RVA: 0x7FFAFC2A1BA0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC2A1D10
    }

    public class PkiMessages
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2A2270 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC2A2060
        public void ToPkiMessageArray(){} // RVA: 0x7FFAFC2A2330
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class PkiStatusEncodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC2A2630
        public void get_Value(){} // RVA: 0x7FFAFC2299D0
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
        public void .cctor(){} // RVA: 0x7FFAFC2A2810
    }

    public class PkiStatusInfo
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC2A2C60 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC2A3360 | overloaded x4
        public void get_Status(){} // RVA: 0x7FFAFC2299D0
        public void get_StatusString(){} // RVA: 0x7FFAF2D907C0
        public void get_FailInfo(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC2A34D0
    }

    public class PollRepContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E6CE00 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC2A38C0
        public void get_CertReqID(){} // RVA: 0x7FFAF2DA8380
        public void get_CheckAfter(){} // RVA: 0x7FFAF2D907C0
        public void get_Reason(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC2A3AA0
    }

    public class PollReqContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void GetInstance(){} // RVA: 0x7FFAFC2A3CE0
        public void GetCertReqIDs(){} // RVA: 0x7FFAFC2A3EF0
        public void SequenceToDerIntegerArray(){} // RVA: 0x7FFAFC2A4200
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class PopoDecKeyChallContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void GetInstance(){} // RVA: 0x7FFAFC2A4370
        public void ToChallengeArray(){} // RVA: 0x7FFAFC2A4580
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class PopoDecKeyRespContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void GetInstance(){} // RVA: 0x7FFAFC2A48B0
        public void ToDerIntegerArray(){} // RVA: 0x7FFAFC2A4AC0
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class ProtectedPart
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC2A4D90
        public void get_Header(){} // RVA: 0x7FFAF2DA8380
        public void get_Body(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC2A5090
    }

    public class RevAnnContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2A51A0
        public void GetInstance(){} // RVA: 0x7FFAFC2A56A0
        public void get_Status(){} // RVA: 0x7FFAF2DA8380
        public void get_CertID(){} // RVA: 0x7FFAF2D907C0
        public void get_WillBeRevokedAt(){} // RVA: 0x7FFAF2DBB0C0
        public void get_BadSinceDate(){} // RVA: 0x7FFAF2DBB130
        public void get_CrlDetails(){} // RVA: 0x7FFAF30E74D0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC2A5880
    }

    public class RevDetails
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC2A5CC0
        public void get_CertDetails(){} // RVA: 0x7FFAF2DA8380
        public void get_CrlEntryDetails(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC2A5FE0
    }

    public class RevRepContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2A61E0
        public void GetInstance(){} // RVA: 0x7FFAFC2A6320
        public void GetStatus(){} // RVA: 0x7FFAFC2A6610
        public void GetRevCerts(){} // RVA: 0x7FFAFC2A6780
        public void GetCrls(){} // RVA: 0x7FFAFC2A68F0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC2A6A60
    }

    public class RevRepContentBuilder
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAFC2A6DA0 | overloaded x2
        public void AddCrl(){} // RVA: 0x7FFAFC2A6E50
        public void Build(){} // RVA: 0x7FFAFC2A6E80
        public void .ctor(){} // RVA: 0x7FFAFC2A72A0
    }

    public class RevReqContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2A7650 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC2A7440
        public void ToRevDetailsArray(){} // RVA: 0x7FFAFC2A7710
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

}