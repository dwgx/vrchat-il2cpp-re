// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp
// Classes: 38
// Methods: 212

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp
{
    public class CAKeyUpdAnnContent : Asn1Encodable
    {
        public object oldWithNew;
        public object newWithOld;
        public object newWithNew;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA489C60
        public void GetInstance(){} // RVA: 0xA489DF0
        public void get_OldWithNew(){} // RVA: 0xB5DBF0
        public void get_NewWithOld(){} // RVA: 0xB465B0
        public void get_NewWithNew(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA48A150
    }

    public class CertConfirmContent : Asn1Encodable
    {
        public object content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetInstance(){} // RVA: 0xA48A2B0
        public void ToCertStatusArray(){} // RVA: 0xA48A4C0
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class CertOrEncCert : Asn1Encodable
    {
        public object certificate;
        public object encryptedCert;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA48B850
        public void GetInstance(){} // RVA: 0xA48B5C0
        public void get_Certificate(){} // RVA: 0xB5DBF0
        public void get_EncryptedCert(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA48B900
    }

    public class CertRepMessage : Asn1Encodable
    {
        public object caPubs;
        public object response;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA48BE40
        public void GetInstance(){} // RVA: 0xA48BC60
        public void GetCAPubs(){} // RVA: 0xA48BFE0
        public void GetResponse(){} // RVA: 0xA48C170
        public void ToAsn1Object(){} // RVA: 0xA48C4B0
    }

    public class CertResponse : Asn1Encodable
    {
        public object certReqId;
        public object status;
        public object certifiedKeyPair;
        public object rspInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA48CB70
        public void GetInstance(){} // RVA: 0xA48C970
        public void get_CertReqID(){} // RVA: 0xB5DBF0
        public void get_Status(){} // RVA: 0xB465B0
        public void get_CertifiedKeyPair(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA48CD80
    }

    public class CertStatus : Asn1Encodable
    {
        public object certHash;
        public object certReqId;
        public object statusInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA48D470
        public void GetInstance(){} // RVA: 0xA48D750
        public void get_CertHash(){} // RVA: 0xB5DBF0
        public void get_CertReqID(){} // RVA: 0xB465B0
        public void get_StatusInfo(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA48D930
    }

    public class CertifiedKeyPair : Asn1Encodable
    {
        public object certOrEncCert;
        public object privateKey;
        public object publicationInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA48AF70
        public void GetInstance(){} // RVA: 0xA48AC30
        public void get_CertOrEncCert(){} // RVA: 0xB5DBF0
        public void get_PrivateKey(){} // RVA: 0xB465B0
        public void get_PublicationInfo(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA48B0D0
    }

    public class Challenge : Asn1Encodable
    {
        public object owf;
        public object witness;
        public object challenge;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA48DB80
        public void GetInstance(){} // RVA: 0xA48DD70
        public void get_Owf(){} // RVA: 0xB5DBF0
        public void ToAsn1Object(){} // RVA: 0xA48DF50
    }

    public class CmpCertificate : Asn1Encodable
    {
        public object x509v3PKCert;
        public object x509v2AttrCert;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA48E1A0
        public void GetInstance(){} // RVA: 0xA48E280
        public void get_IsX509v3PKCert(){} // RVA: 0x17B0810
        public void get_X509v3PKCert(){} // RVA: 0xB5DBF0
        public void get_X509v2AttrCert(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA48E610
    }

    public class CmpObjectIdentifiers : Object
    {
        public object passwordBasedMac;
        public object dhBasedMac;
        public object it_caProtEncCert;
        public object it_signKeyPairTypes;
        public object it_encKeyPairTypes;
        public object it_preferredSymAlg;
        public object it_caKeyUpdateInfo;
        public object it_currentCRL;
        public object it_unsupportedOIDs;
        public object it_keyPairParamReq;
        public object it_keyPairParamRep;
        public object it_revPassphrase;
        public object it_implicitConfirm;
        public object it_confirmWaitTime;
        public object it_origPKIMessage;
        public object it_suppLangTags;
        public object regCtrl_regToken;
        public object regCtrl_authenticator;
        public object regCtrl_pkiPublicationInfo;
        public object regCtrl_pkiArchiveOptions;
        public object regCtrl_oldCertID;
        public object regCtrl_protocolEncrKey;
        public object regCtrl_altCertTemplate;
        public object regInfo_utf8Pairs;
        public object regInfo_certReq;
        public object ct_encKeyWithID;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA48E710
    }

    public class CrlAnnContent : Asn1Encodable
    {
        public object content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetInstance(){} // RVA: 0xA48F7C0
        public void ToCertificateListArray(){} // RVA: 0xA48F9D0
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class ErrorMsgContent : Asn1Encodable
    {
        public object pkiStatusInfo;
        public object errorCode;
        public object errorDetails;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA490150
        public void GetInstance(){} // RVA: 0xA48FCD0
        public void get_PkiStatusInfo(){} // RVA: 0xB5DBF0
        public void get_ErrorCode(){} // RVA: 0xB465B0
        public void get_ErrorDetails(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA4902B0
    }

    public class GenMsgContent : Asn1Encodable
    {
        public object content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA490710
        public void GetInstance(){} // RVA: 0xA490500
        public void ToInfoTypeAndValueArray(){} // RVA: 0xA4907D0
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class GenRepContent : Asn1Encodable
    {
        public object content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA490B60
        public void GetInstance(){} // RVA: 0xA490950
        public void ToInfoTypeAndValueArray(){} // RVA: 0xA490C20
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class InfoTypeAndValue : Asn1Encodable
    {
        public object infoType;
        public object infoValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void GetInstance(){} // RVA: 0xA490F10
        public void get_InfoType(){} // RVA: 0xB5DBF0
        public void get_InfoValue(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA491250
    }

    public class KeyRecRepContent : Asn1Encodable
    {
        public object status;
        public object newSigCert;
        public object caCerts;
        public object keyPairHist;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA491460
        public void GetInstance(){} // RVA: 0xA4916D0
        public void get_Status(){} // RVA: 0xB5DBF0
        public void get_NewSigCert(){} // RVA: 0xB465B0
        public void GetCACerts(){} // RVA: 0xA4918B0
        public void GetKeyPairHist(){} // RVA: 0xA491A40
        public void ToAsn1Object(){} // RVA: 0xA491BD0
    }

    public class OobCertHash : Asn1Encodable
    {
        public object hashAlg;
        public object certId;
        public object hashVal;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA491FB0
        public void GetInstance(){} // RVA: 0xA492180
        public void get_HashAlg(){} // RVA: 0xB5DBF0
        public void get_CertID(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA492360
    }

    public class PbmParameter : Asn1Encodable
    {
        public object salt;
        public object owf;
        public object iterationCount;
        public object mac;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB8AE10
        public void GetInstance(){} // RVA: 0xA492810
        public void get_Salt(){} // RVA: 0xB5DBF0
        public void get_Owf(){} // RVA: 0xB465B0
        public void get_IterationCount(){} // RVA: 0xB700F0
        public void get_Mac(){} // RVA: 0xB70160
        public void ToAsn1Object(){} // RVA: 0xA492C80
    }

    public class PkiBody : Asn1Encodable
    {
        public object TYPE_INIT_REQ;
        public object TYPE_INIT_REP;
        public object TYPE_CERT_REQ;
        public object TYPE_CERT_REP;
        public object TYPE_P10_CERT_REQ;
        public object TYPE_POPO_CHALL;
        public object TYPE_POPO_REP;
        public object TYPE_KEY_UPDATE_REQ;
        public object TYPE_KEY_UPDATE_REP;
        public object TYPE_KEY_RECOVERY_REQ;
        public object TYPE_KEY_RECOVERY_REP;
        public object TYPE_REVOCATION_REQ;
        public object TYPE_REVOCATION_REP;
        public object TYPE_CROSS_CERT_REQ;
        public object TYPE_CROSS_CERT_REP;
        public object TYPE_CA_KEY_UPDATE_ANN;
        public object TYPE_CERT_ANN;
        public object TYPE_REVOCATION_ANN;
        public object TYPE_CRL_ANN;
        public object TYPE_CONFIRM;
        public object TYPE_NESTED;
        public object TYPE_GEN_MSG;
        public object TYPE_GEN_REP;
        public object TYPE_ERROR;
        public object TYPE_CERT_CONFIRM;
        public object TYPE_POLL_REQ;
        public object TYPE_POLL_REP;
        public object tagNo;
        public object body;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA492E20
        public void .ctor(){} // RVA: 0xA493130
        public void GetBodyForType(){} // RVA: 0xA4931A0
        public void get_Type(){} // RVA: 0xB8F8F0
        public void get_Content(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA493BC0
    }

    public class PkiConfirmContent : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA493CA0
        public void .ctor(){} // RVA: 0xB43310
        public void ToAsn1Object(){} // RVA: 0xA493E20
    }

    public class PkiFailureInfo : DerBitString
    {
        public object BadAlg;
        public object BadMessageCheck;
        public object BadRequest;
        public object BadTime;
        public object BadCertId;
        public object BadDataFormat;
        public object WrongAuthority;
        public object IncorrectData;
        public object MissingTimeStamp;
        public object BadPop;
        public object CertRevoked;
        public object CertConfirmed;
        public object WrongIntegrity;
        public object BadRecipientNonce;
        public object TimeNotAvailable;
        public object UnacceptedPolicy;
        public object UnacceptedExtension;
        public object AddInfoNotAvailable;
        public object BadSenderNonce;
        public object BadCertTemplate;
        public object SignerNotTrusted;
        public object TransactionIdInUse;
        public object UnsupportedVersion;
        public object NotAuthorized;
        public object SystemUnavail;
        public object SystemFailure;
        public object DuplicateCertReq;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA493EE0
        public void ToString(){} // RVA: 0xA493F90
    }

    public class PkiFreeText : Asn1Encodable
    {
        public object strings;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA4940D0
        public void .ctor(){} // RVA: 0xA494500
        public void get_Size(){} // RVA: 0x10ADE70
        public void get_Count(){} // RVA: 0x10ADE70
        public void get_Item(){} // RVA: 0xA4945C0
        public void GetStringAt(){} // RVA: 0xA494660
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class PkiHeader : Asn1Encodable
    {
        public object NULL_NAME;
        public object CMP_1999;
        public object CMP_2000;
        public object pvno;
        public object sender;
        public object recipient;
        public object messageTime;
        public object protectionAlg;
        public object senderKID;
        public object recipKID;
        public object transactionID;
        public object senderNonce;
        public object recipNonce;
        public object freeText;
        public object generalInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC27FD0
        public void GetInstance(){} // RVA: 0xA494C60
        public void get_Pvno(){} // RVA: 0xB5DBF0
        public void get_Sender(){} // RVA: 0xB465B0
        public void get_Recipient(){} // RVA: 0xB700F0
        public void get_MessageTime(){} // RVA: 0xB70160
        public void get_ProtectionAlg(){} // RVA: 0xD33E60
        public void get_SenderKID(){} // RVA: 0xD05CA0
        public void get_RecipKID(){} // RVA: 0xBC1B30
        public void get_TransactionID(){} // RVA: 0xBBF8F0
        public void get_SenderNonce(){} // RVA: 0xBE58B0
        public void get_RecipNonce(){} // RVA: 0xC0FFC0
        public void get_FreeText(){} // RVA: 0xBE2C60
        public void GetGeneralInfo(){} // RVA: 0xA494FC0
        public void ToAsn1Object(){} // RVA: 0xA495150
        public void .cctor(){} // RVA: 0xA495A90
    }

    public class PkiHeaderBuilder : Object
    {
        public object pvno;
        public object sender;
        public object recipient;
        public object messageTime;
        public object protectionAlg;
        public object senderKID;
        public object recipKID;
        public object transactionID;
        public object senderNonce;
        public object recipNonce;
        public object freeText;
        public object generalInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC27FD0
        public void SetMessageTime(){} // RVA: 0x26FED90
        public void SetProtectionAlg(){} // RVA: 0x26FEDF0
        public void SetSenderKID(){} // RVA: 0x26FEE50
        public void SetRecipKID(){} // RVA: 0x26FEEB0
        public void SetTransactionID(){} // RVA: 0x26FEF10
        public void SetSenderNonce(){} // RVA: 0x26FEF70
        public void SetRecipNonce(){} // RVA: 0x26FEFD0
        public void SetFreeText(){} // RVA: 0x26FF030
        public void SetGeneralInfo(){} // RVA: 0x792F350
        public void MakeGeneralInfoSeq(){} // RVA: 0xA496400
        public void Build(){} // RVA: 0xA496580
        public void AddOptional(){} // RVA: 0xA496C30
    }

    public class PkiMessage : Asn1Encodable
    {
        public object header;
        public object body;
        public object protection;
        public object extraCerts;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA497290
        public void GetInstance(){} // RVA: 0xA496FC0
        public void get_Header(){} // RVA: 0xB5DBF0
        public void get_Body(){} // RVA: 0xB465B0
        public void get_Protection(){} // RVA: 0xB700F0
        public void GetExtraCerts(){} // RVA: 0xA4972B0
        public void ToAsn1Object(){} // RVA: 0xA497440
    }

    public class PkiMessages : Asn1Encodable
    {
        public object content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4979A0
        public void GetInstance(){} // RVA: 0xA497790
        public void ToPkiMessageArray(){} // RVA: 0xA497A60
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class PkiStatusEncodable : Asn1Encodable
    {
        public object granted;
        public object grantedWithMods;
        public object rejection;
        public object waiting;
        public object revocationWarning;
        public object revocationNotification;
        public object keyUpdateWaiting;
        public object status;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetInstance(){} // RVA: 0xA497D60
        public void get_Value(){} // RVA: 0xA41F2D0
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
        public void .cctor(){} // RVA: 0xA497F40
    }

    public class PkiStatusInfo : Asn1Encodable
    {
        public object status;
        public object statusString;
        public object failInfo;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA498390
        public void .ctor(){} // RVA: 0xA498A90
        public void get_Status(){} // RVA: 0xA41F2D0
        public void get_StatusString(){} // RVA: 0xB465B0
        public void get_FailInfo(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA498C10
    }

    public class PollRepContent : Asn1Encodable
    {
        public object certReqId;
        public object checkAfter;
        public object reason;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC27FD0
        public void GetInstance(){} // RVA: 0xA499010
        public void get_CertReqID(){} // RVA: 0xB5DBF0
        public void get_CheckAfter(){} // RVA: 0xB465B0
        public void get_Reason(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA4991F0
    }

    public class PollReqContent : Asn1Encodable
    {
        public object content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetInstance(){} // RVA: 0xA499440
        public void GetCertReqIDs(){} // RVA: 0xA499650
        public void SequenceToDerIntegerArray(){} // RVA: 0xA499970
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class PopoDecKeyChallContent : Asn1Encodable
    {
        public object content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetInstance(){} // RVA: 0xA499AF0
        public void ToChallengeArray(){} // RVA: 0xA499D00
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class PopoDecKeyRespContent : Asn1Encodable
    {
        public object content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetInstance(){} // RVA: 0xA49A040
        public void ToDerIntegerArray(){} // RVA: 0xA49A250
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class ProtectedPart : Asn1Encodable
    {
        public object header;
        public object body;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void GetInstance(){} // RVA: 0xA49A530
        public void get_Header(){} // RVA: 0xB5DBF0
        public void get_Body(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA49A830
    }

    public class RevAnnContent : Asn1Encodable
    {
        public object status;
        public object certId;
        public object willBeRevokedAt;
        public object badSinceDate;
        public object crlDetails;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA49A940
        public void GetInstance(){} // RVA: 0xA49AE40
        public void get_Status(){} // RVA: 0xB5DBF0
        public void get_CertID(){} // RVA: 0xB465B0
        public void get_WillBeRevokedAt(){} // RVA: 0xB700F0
        public void get_BadSinceDate(){} // RVA: 0xB70160
        public void get_CrlDetails(){} // RVA: 0xD33E60
        public void ToAsn1Object(){} // RVA: 0xA49B020
    }

    public class RevDetails : Asn1Encodable
    {
        public object certDetails;
        public object crlEntryDetails;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void GetInstance(){} // RVA: 0xA49B470
        public void get_CertDetails(){} // RVA: 0xB5DBF0
        public void get_CrlEntryDetails(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA49B7B0
    }

    public class RevRepContent : Asn1Encodable
    {
        public object status;
        public object revCerts;
        public object crls;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA49B9C0
        public void GetInstance(){} // RVA: 0xA49BB00
        public void GetStatus(){} // RVA: 0xA49BDF0
        public void GetRevCerts(){} // RVA: 0xA49BF70
        public void GetCrls(){} // RVA: 0xA49C100
        public void ToAsn1Object(){} // RVA: 0xA49C290
    }

    public class RevRepContentBuilder : Object
    {
        public object status;
        public object revCerts;
        public object crls;

        // ── Methods ──
        public void Add(){} // RVA: 0xA49C5D0
        public void AddCrl(){} // RVA: 0xA49C680
        public void Build(){} // RVA: 0xA49C6B0
        public void .ctor(){} // RVA: 0xA49CAE0
    }

    public class RevReqContent : Asn1Encodable
    {
        public object content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA49CE90
        public void GetInstance(){} // RVA: 0xA49CC80
        public void ToRevDetailsArray(){} // RVA: 0xA49CF50
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

}