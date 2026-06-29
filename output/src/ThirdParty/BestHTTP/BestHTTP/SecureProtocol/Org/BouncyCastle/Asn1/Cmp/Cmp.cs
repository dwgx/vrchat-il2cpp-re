// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp
// Classes: 38
// Methods: 212

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp
{
    public class CAKeyUpdAnnContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B161E5D0
        public void GetInstance(){} // RVA: 0x7B161E760
        public void get_OldWithNew(){} // RVA: 0x7A80F2570
        public void get_NewWithOld(){} // RVA: 0x7A80DA7B0
        public void get_NewWithNew(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B161EAC0
    }

    public class CertConfirmContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetInstance(){} // RVA: 0x7B161EC20
        public void ToCertStatusArray(){} // RVA: 0x7B161EE30
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class CertOrEncCert : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16201C0
        public void GetInstance(){} // RVA: 0x7B161FF30
        public void get_Certificate(){} // RVA: 0x7A80F2570
        public void get_EncryptedCert(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1620270
    }

    public class CertRepMessage : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16207B0
        public void GetInstance(){} // RVA: 0x7B16205D0
        public void GetCAPubs(){} // RVA: 0x7B1620950
        public void GetResponse(){} // RVA: 0x7B1620AE0
        public void ToAsn1Object(){} // RVA: 0x7B1620E20
    }

    public class CertResponse : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16214E0
        public void GetInstance(){} // RVA: 0x7B16212E0
        public void get_CertReqID(){} // RVA: 0x7A80F2570
        public void get_Status(){} // RVA: 0x7A80DA7B0
        public void get_CertifiedKeyPair(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B16216F0
    }

    public class CertStatus : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1621DE0
        public void GetInstance(){} // RVA: 0x7B16220C0
        public void get_CertHash(){} // RVA: 0x7A80F2570
        public void get_CertReqID(){} // RVA: 0x7A80DA7B0
        public void get_StatusInfo(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B16222A0
    }

    public class CertifiedKeyPair : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B161F8E0
        public void GetInstance(){} // RVA: 0x7B161F5A0
        public void get_CertOrEncCert(){} // RVA: 0x7A80F2570
        public void get_PrivateKey(){} // RVA: 0x7A80DA7B0
        public void get_PublicationInfo(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B161FA40
    }

    public class Challenge : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16224F0
        public void GetInstance(){} // RVA: 0x7B16226E0
        public void get_Owf(){} // RVA: 0x7A80F2570
        public void ToAsn1Object(){} // RVA: 0x7B16228C0
    }

    public class CmpCertificate : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1622B10
        public void GetInstance(){} // RVA: 0x7B1622BF0
        public void get_IsX509v3PKCert(){} // RVA: 0x7A8CCB4F0
        public void get_X509v3PKCert(){} // RVA: 0x7A80F2570
        public void get_X509v2AttrCert(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1622F80
    }

    public class CmpObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B1623080
    }

    public class CrlAnnContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetInstance(){} // RVA: 0x7B1624130
        public void ToCertificateListArray(){} // RVA: 0x7B1624340
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class ErrorMsgContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1624AC0
        public void GetInstance(){} // RVA: 0x7B1624640
        public void get_PkiStatusInfo(){} // RVA: 0x7A80F2570
        public void get_ErrorCode(){} // RVA: 0x7A80DA7B0
        public void get_ErrorDetails(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B1624C20
    }

    public class GenMsgContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1625080
        public void GetInstance(){} // RVA: 0x7B1624E70
        public void ToInfoTypeAndValueArray(){} // RVA: 0x7B1625140
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class GenRepContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16254D0
        public void GetInstance(){} // RVA: 0x7B16252C0
        public void ToInfoTypeAndValueArray(){} // RVA: 0x7B1625590
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class InfoTypeAndValue : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void GetInstance(){} // RVA: 0x7B1625880
        public void get_InfoType(){} // RVA: 0x7A80F2570
        public void get_InfoValue(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1625BC0
    }

    public class KeyRecRepContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1625DD0
        public void GetInstance(){} // RVA: 0x7B1626040
        public void get_Status(){} // RVA: 0x7A80F2570
        public void get_NewSigCert(){} // RVA: 0x7A80DA7B0
        public void GetCACerts(){} // RVA: 0x7B1626220
        public void GetKeyPairHist(){} // RVA: 0x7B16263B0
        public void ToAsn1Object(){} // RVA: 0x7B1626540
    }

    public class OobCertHash : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1626920
        public void GetInstance(){} // RVA: 0x7B1626AF0
        public void get_HashAlg(){} // RVA: 0x7A80F2570
        public void get_CertID(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1626CD0
    }

    public class PbmParameter : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A811FE30
        public void GetInstance(){} // RVA: 0x7B1627180
        public void get_Salt(){} // RVA: 0x7A80F2570
        public void get_Owf(){} // RVA: 0x7A80DA7B0
        public void get_IterationCount(){} // RVA: 0x7A81052C0
        public void get_Mac(){} // RVA: 0x7A8105330
        public void ToAsn1Object(){} // RVA: 0x7B16275F0
    }

    public class PkiBody : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1627790
        public void .ctor(){} // RVA: 0x7B1627AA0
        public void GetBodyForType(){} // RVA: 0x7B1627B10
        public void get_Type(){} // RVA: 0x7A8124910
        public void get_Content(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1628530
    }

    public class PkiConfirmContent : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1628610
        public void .ctor(){} // RVA: 0x7A80D7310
        public void ToAsn1Object(){} // RVA: 0x7B1628790
    }

    public class PkiFailureInfo : DerBitString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1628850
        public void ToString(){} // RVA: 0x7B1628900
    }

    public class PkiFreeText : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1628A40
        public void .ctor(){} // RVA: 0x7B1628E70
        public void get_Size(){} // RVA: 0x7A858ABE0
        public void get_Count(){} // RVA: 0x7A858ABE0
        public void get_Item(){} // RVA: 0x7B1628F30
        public void GetStringAt(){} // RVA: 0x7B1628FD0
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class PkiHeader : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81B7C50
        public void GetInstance(){} // RVA: 0x7B16295D0
        public void get_Pvno(){} // RVA: 0x7A80F2570
        public void get_Sender(){} // RVA: 0x7A80DA7B0
        public void get_Recipient(){} // RVA: 0x7A81052C0
        public void get_MessageTime(){} // RVA: 0x7A8105330
        public void get_ProtectionAlg(){} // RVA: 0x7A83F69F0
        public void get_SenderKID(){} // RVA: 0x7A8292C30
        public void get_RecipKID(){} // RVA: 0x7A8154D80
        public void get_TransactionID(){} // RVA: 0x7A8152D80
        public void get_SenderNonce(){} // RVA: 0x7A8178B90
        public void get_RecipNonce(){} // RVA: 0x7A81A0050
        public void get_FreeText(){} // RVA: 0x7A8175DF0
        public void GetGeneralInfo(){} // RVA: 0x7B1629930
        public void ToAsn1Object(){} // RVA: 0x7B1629AC0
        public void .cctor(){} // RVA: 0x7B162A400
    }

    public class PkiHeaderBuilder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81B7C50
        public void SetMessageTime(){} // RVA: 0x7A9C81D90
        public void SetProtectionAlg(){} // RVA: 0x7A9C81DF0
        public void SetSenderKID(){} // RVA: 0x7A9C81E50
        public void SetRecipKID(){} // RVA: 0x7A9C81EB0
        public void SetTransactionID(){} // RVA: 0x7A9C81F10
        public void SetSenderNonce(){} // RVA: 0x7A9C81F70
        public void SetRecipNonce(){} // RVA: 0x7A9C81FD0
        public void SetFreeText(){} // RVA: 0x7A9C82030
        public void SetGeneralInfo(){} // RVA: 0x7AECC1820
        public void MakeGeneralInfoSeq(){} // RVA: 0x7B162AD70
        public void Build(){} // RVA: 0x7B162AEF0
        public void AddOptional(){} // RVA: 0x7B162B5A0
    }

    public class PkiMessage : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B162BC00
        public void GetInstance(){} // RVA: 0x7B162B930
        public void get_Header(){} // RVA: 0x7A80F2570
        public void get_Body(){} // RVA: 0x7A80DA7B0
        public void get_Protection(){} // RVA: 0x7A81052C0
        public void GetExtraCerts(){} // RVA: 0x7B162BC20
        public void ToAsn1Object(){} // RVA: 0x7B162BDB0
    }

    public class PkiMessages : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B162C310
        public void GetInstance(){} // RVA: 0x7B162C100
        public void ToPkiMessageArray(){} // RVA: 0x7B162C3D0
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class PkiStatusEncodable : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetInstance(){} // RVA: 0x7B162C6D0
        public void get_Value(){} // RVA: 0x7B15B3D20
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
        public void .cctor(){} // RVA: 0x7B162C8B0
    }

    public class PkiStatusInfo : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B162CD00
        public void .ctor(){} // RVA: 0x7B162D400
        public void get_Status(){} // RVA: 0x7B15B3D20
        public void get_StatusString(){} // RVA: 0x7A80DA7B0
        public void get_FailInfo(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B162D580
    }

    public class PollRepContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81B7C50
        public void GetInstance(){} // RVA: 0x7B162D980
        public void get_CertReqID(){} // RVA: 0x7A80F2570
        public void get_CheckAfter(){} // RVA: 0x7A80DA7B0
        public void get_Reason(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B162DB60
    }

    public class PollReqContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetInstance(){} // RVA: 0x7B162DDB0
        public void GetCertReqIDs(){} // RVA: 0x7B162DFC0
        public void SequenceToDerIntegerArray(){} // RVA: 0x7B162E2E0
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class PopoDecKeyChallContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetInstance(){} // RVA: 0x7B162E460
        public void ToChallengeArray(){} // RVA: 0x7B162E670
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class PopoDecKeyRespContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetInstance(){} // RVA: 0x7B162E9B0
        public void ToDerIntegerArray(){} // RVA: 0x7B162EBC0
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class ProtectedPart : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void GetInstance(){} // RVA: 0x7B162EEA0
        public void get_Header(){} // RVA: 0x7A80F2570
        public void get_Body(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B162F1A0
    }

    public class RevAnnContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B162F2B0
        public void GetInstance(){} // RVA: 0x7B162F7B0
        public void get_Status(){} // RVA: 0x7A80F2570
        public void get_CertID(){} // RVA: 0x7A80DA7B0
        public void get_WillBeRevokedAt(){} // RVA: 0x7A81052C0
        public void get_BadSinceDate(){} // RVA: 0x7A8105330
        public void get_CrlDetails(){} // RVA: 0x7A83F69F0
        public void ToAsn1Object(){} // RVA: 0x7B162F990
    }

    public class RevDetails : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void GetInstance(){} // RVA: 0x7B162FDE0
        public void get_CertDetails(){} // RVA: 0x7A80F2570
        public void get_CrlEntryDetails(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1630120
    }

    public class RevRepContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1630330
        public void GetInstance(){} // RVA: 0x7B1630470
        public void GetStatus(){} // RVA: 0x7B1630760
        public void GetRevCerts(){} // RVA: 0x7B16308E0
        public void GetCrls(){} // RVA: 0x7B1630A70
        public void ToAsn1Object(){} // RVA: 0x7B1630C00
    }

    public class RevRepContentBuilder : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7B1630F40
        public void AddCrl(){} // RVA: 0x7B1630FF0
        public void Build(){} // RVA: 0x7B1631020
        public void .ctor(){} // RVA: 0x7B1631450
    }

    public class RevReqContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1631800
        public void GetInstance(){} // RVA: 0x7B16315F0
        public void ToRevDetailsArray(){} // RVA: 0x7B16318C0
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

}