// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp
// Classes: 38
// Methods: 261

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp
{
    public class CAKeyUpdAnnContent : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.CmpCertificate OldWithNew; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.CmpCertificate NewWithOld; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.CmpCertificate NewWithNew; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDED010
        public void GetInstance(){} // RVA: 0x7FFACBDED1A0
        public void get_OldWithNew(){} // RVA: 0x7FFAC2F3C380
        public void get_NewWithOld(){} // RVA: 0x7FFAC2F247C0
        public void get_NewWithNew(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDED380
    }

    public class CertConfirmContent : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence content; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetInstance(){} // RVA: 0x7FFACBDED4E0
        public void ToCertStatusArray(){} // RVA: 0x7FFACBDED6F0
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class CertOrEncCert : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.CmpCertificate Certificate; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.EncryptedValue EncryptedCert; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDEEA70 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBDEE7E0
        public void get_Certificate(){} // RVA: 0x7FFAC2F3C380
        public void get_EncryptedCert(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDEEB20
    }

    public class CertRepMessage : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence caPubs; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence response; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDEF050 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDEEE70
        public void GetCAPubs(){} // RVA: 0x7FFACBDEF1E0
        public void GetResponse(){} // RVA: 0x7FFACBDEF350
        public void ToAsn1Object(){} // RVA: 0x7FFACBDEF680
    }

    public class CertResponse : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger CertReqID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo Status; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.CertifiedKeyPair CertifiedKeyPair; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString rspInfo; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDEFD30 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBDEFB30
        public void get_CertReqID(){} // RVA: 0x7FFAC2F3C380
        public void get_Status(){} // RVA: 0x7FFAC2F247C0
        public void get_CertifiedKeyPair(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDEFF40
    }

    public class CertStatus : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString CertHash; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger CertReqID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo StatusInfo; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDF0620 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBDF08E0
        public void get_CertHash(){} // RVA: 0x7FFAC2F3C380
        public void get_CertReqID(){} // RVA: 0x7FFAC2F247C0
        public void get_StatusInfo(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDF0AC0
    }

    public class CertifiedKeyPair : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.CertOrEncCert CertOrEncCert; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.EncryptedValue PrivateKey; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.PkiPublicationInfo PublicationInfo; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDEE190 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBDEDE50
        public void get_CertOrEncCert(){} // RVA: 0x7FFAC2F3C380
        public void get_PrivateKey(){} // RVA: 0x7FFAC2F247C0
        public void get_PublicationInfo(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDEE2F0
    }

    public class Challenge : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Owf; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString witness; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString challenge; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDF0D00
        public void GetInstance(){} // RVA: 0x7FFACBDF0EF0
        public void get_Owf(){} // RVA: 0x7FFAC2F3C380
        public void ToAsn1Object(){} // RVA: 0x7FFACBDF10D0
    }

    public class CmpCertificate : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509CertificateStructure IsX509v3PKCert; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AttributeCertificate X509v3PKCert; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDF1320 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDF1400
        public void get_IsX509v3PKCert(){} // RVA: 0x7FFAC34D2B40
        public void get_X509v3PKCert(){} // RVA: 0x7FFAC2F3C380
        public void get_X509v2AttrCert(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDF1790
    }

    public class CmpObjectIdentifiers : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier passwordBasedMac;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier dhBasedMac; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier it_caProtEncCert; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier it_signKeyPairTypes; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier it_encKeyPairTypes; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier it_preferredSymAlg; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier it_caKeyUpdateInfo; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier it_currentCRL; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier it_unsupportedOIDs; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier it_keyPairParamReq; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier it_keyPairParamRep; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier it_revPassphrase; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier it_implicitConfirm; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier it_confirmWaitTime; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier it_origPKIMessage; // 0x70
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier it_suppLangTags; // 0x78
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier regCtrl_regToken; // 0x80
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier regCtrl_authenticator; // 0x88
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier regCtrl_pkiPublicationInfo; // 0x90
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier regCtrl_pkiArchiveOptions; // 0x98
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier regCtrl_oldCertID; // 0xA0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier regCtrl_protocolEncrKey; // 0xA8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier regCtrl_altCertTemplate; // 0xB0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier regInfo_utf8Pairs; // 0xB8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier regInfo_certReq; // 0xC0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ct_encKeyWithID; // 0xC8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBDF1890
    }

    public class CrlAnnContent : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence content; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetInstance(){} // RVA: 0x7FFACBDF2940
        public void ToCertificateListArray(){} // RVA: 0x7FFACBDF2B50
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class ErrorMsgContent : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo PkiStatusInfo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger ErrorCode; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiFreeText ErrorDetails; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDF32C0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBDF2E40
        public void get_PkiStatusInfo(){} // RVA: 0x7FFAC2F3C380
        public void get_ErrorCode(){} // RVA: 0x7FFAC2F247C0
        public void get_ErrorDetails(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDF3420
    }

    public class GenMsgContent : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence content; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDF3870 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDF3660
        public void ToInfoTypeAndValueArray(){} // RVA: 0x7FFACBDF3930
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class GenRepContent : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence content; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDF3CB0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDF3AA0
        public void ToInfoTypeAndValueArray(){} // RVA: 0x7FFACBDF3D70
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class InfoTypeAndValue : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier InfoType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable InfoValue; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBDF4050
        public void get_InfoType(){} // RVA: 0x7FFAC2F3C380
        public void get_InfoValue(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDF4360
    }

    public class KeyRecRepContent : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo Status; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.CmpCertificate NewSigCert; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence caCerts; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence keyPairHist; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDF4560
        public void GetInstance(){} // RVA: 0x7FFACBDF47D0
        public void get_Status(){} // RVA: 0x7FFAC2F3C380
        public void get_NewSigCert(){} // RVA: 0x7FFAC2F247C0
        public void GetCACerts(){} // RVA: 0x7FFACBDF49B0
        public void GetKeyPairHist(){} // RVA: 0x7FFACBDF4B20
        public void ToAsn1Object(){} // RVA: 0x7FFACBDF4C90
    }

    public class OobCertHash : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HashAlg; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.CertId CertID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString hashVal; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDF5070
        public void GetInstance(){} // RVA: 0x7FFACBDF5240
        public void get_HashAlg(){} // RVA: 0x7FFAC2F3C380
        public void get_CertID(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDF5420
    }

    public class PbmParameter : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString Salt; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Owf; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger IterationCount; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Mac; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F69A50 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBDF58C0
        public void get_Salt(){} // RVA: 0x7FFAC2F3C380
        public void get_Owf(){} // RVA: 0x7FFAC2F247C0
        public void get_IterationCount(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Mac(){} // RVA: 0x7FFAC2F4F130
        public void ToAsn1Object(){} // RVA: 0x7FFACBDF5D30
    }

    public class PkiBody : Asn1Encodable
    {
        public int Type;
        public int Content;
        public int TYPE_CERT_REQ;
        public int TYPE_CERT_REP;
        public int TYPE_P10_CERT_REQ;
        public int TYPE_POPO_CHALL;
        public int TYPE_POPO_REP;
        public int TYPE_KEY_UPDATE_REQ;
        public int TYPE_KEY_UPDATE_REP;
        public int TYPE_KEY_RECOVERY_REQ;
        public int TYPE_KEY_RECOVERY_REP;
        public int TYPE_REVOCATION_REQ;
        public int TYPE_REVOCATION_REP;
        public int TYPE_CROSS_CERT_REQ;
        public int TYPE_CROSS_CERT_REP;
        public int TYPE_CA_KEY_UPDATE_ANN;
        public int TYPE_CERT_ANN;
        public int TYPE_REVOCATION_ANN;
        public int TYPE_CRL_ANN;
        public int TYPE_CONFIRM;
        public int TYPE_NESTED;
        public int TYPE_GEN_MSG;
        public int TYPE_GEN_REP;
        public int TYPE_ERROR;
        public int TYPE_CERT_CONFIRM;
        public int TYPE_POLL_REQ;
        public int TYPE_POLL_REP;
        public int tagNo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable body; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDF5ED0
        public void .ctor(){} // RVA: 0x7FFACBDF61E0 | overloaded x2
        public void GetBodyForType(){} // RVA: 0x7FFACBDF6250
        public void get_Type(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Content(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDF6E20
    }

    public class PkiConfirmContent : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDF6EA0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void ToAsn1Object(){} // RVA: 0x7FFACBDF7020
    }

    public class PkiFailureInfo : DerBitString
    {
        public int BadAlg;
        public int BadMessageCheck;
        public int BadRequest;
        public int BadTime;
        public int BadCertId;
        public int BadDataFormat;
        public int WrongAuthority;
        public int IncorrectData;
        public int MissingTimeStamp;
        public int BadPop;
        public int CertRevoked;
        public int CertConfirmed;
        public int WrongIntegrity;
        public int BadRecipientNonce;
        public int TimeNotAvailable;
        public int UnacceptedPolicy;
        public int UnacceptedExtension;
        public int AddInfoNotAvailable;
        public int BadSenderNonce;
        public int BadCertTemplate;
        public int SignerNotTrusted;
        public int TransactionIdInUse;
        public int UnsupportedVersion;
        public int NotAuthorized;
        public int SystemUnavail;
        public int SystemFailure;
        public int DuplicateCertReq;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDF70E0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFACBDF7190
    }

    public class PkiFreeText : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence Size; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDF72D0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBDF7710 | overloaded x2
        public void get_Size(){} // RVA: 0x7FFAC8D71620
        public void get_Count(){} // RVA: 0x7FFAC8D71620
        public void get_Item(){} // RVA: 0x7FFACBDF77D0
        public void GetStringAt(){} // RVA: 0x7FFACBDF7870
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class PkiHeader : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName Pvno;
        public int Sender; // 0x8
        public int Recipient; // 0xC
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger MessageTime; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName ProtectionAlg; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName SenderKID; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime RecipKID; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier TransactionID; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString SenderNonce; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString RecipNonce; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString FreeText; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString senderNonce; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString recipNonce; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiFreeText freeText; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence generalInfo; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3000E00 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBDF7E70
        public void get_Pvno(){} // RVA: 0x7FFAC2F3C380
        public void get_Sender(){} // RVA: 0x7FFAC2F247C0
        public void get_Recipient(){} // RVA: 0x7FFAC2F4F0C0
        public void get_MessageTime(){} // RVA: 0x7FFAC2F4F130
        public void get_ProtectionAlg(){} // RVA: 0x7FFAC31D95E0
        public void get_SenderKID(){} // RVA: 0x7FFAC31D0140
        public void get_RecipKID(){} // RVA: 0x7FFAC2F9E740
        public void get_TransactionID(){} // RVA: 0x7FFAC2F9C730
        public void get_SenderNonce(){} // RVA: 0x7FFAC2FC20E0
        public void get_RecipNonce(){} // RVA: 0x7FFAC2FE9500
        public void get_FreeText(){} // RVA: 0x7FFAC2FBF370
        public void GetGeneralInfo(){} // RVA: 0x7FFACBDF81C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDF8330
        public void .cctor(){} // RVA: 0x7FFACBDF8C70
    }

    public class PkiHeaderBuilder : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger pvno; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName sender; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName recipient; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime messageTime; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier protectionAlg; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString senderKID; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString recipKID; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString transactionID; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString senderNonce; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString recipNonce; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiFreeText freeText; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence generalInfo; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3000E00 | overloaded x2
        public void SetMessageTime(){} // RVA: 0x7FFAC499B040
        public void SetProtectionAlg(){} // RVA: 0x7FFAC499B0A0
        public void SetSenderKID(){} // RVA: 0x7FFAC499B100 | overloaded x2
        public void SetRecipKID(){} // RVA: 0x7FFAC499B160 | overloaded x2
        public void SetTransactionID(){} // RVA: 0x7FFAC499B1C0 | overloaded x2
        public void SetSenderNonce(){} // RVA: 0x7FFAC499B220 | overloaded x2
        public void SetRecipNonce(){} // RVA: 0x7FFAC499B280 | overloaded x2
        public void SetFreeText(){} // RVA: 0x7FFAC499B2E0
        public void SetGeneralInfo(){} // RVA: 0x7FFAC967B660 | overloaded x3
        public void MakeGeneralInfoSeq(){} // RVA: 0x7FFACBDF9460 | overloaded x2
        public void Build(){} // RVA: 0x7FFACBDF96D0
        public void AddOptional(){} // RVA: 0x7FFACBDFA370
    }

    public class PkiMessage : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiHeader Header; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiBody Body; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString Protection; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence extraCerts; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDFA960 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFACBDFA6A0
        public void get_Header(){} // RVA: 0x7FFAC2F3C380
        public void get_Body(){} // RVA: 0x7FFAC2F247C0
        public void get_Protection(){} // RVA: 0x7FFAC2F4F0C0
        public void GetExtraCerts(){} // RVA: 0x7FFACBDFA980
        public void ToAsn1Object(){} // RVA: 0x7FFACBDFAAF0
    }

    public class PkiMessages : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence content; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDFB050 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDFAE40
        public void ToPkiMessageArray(){} // RVA: 0x7FFACBDFB110
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class PkiStatusEncodable : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable Value;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable grantedWithMods; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable rejection; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable waiting; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable revocationWarning; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable revocationNotification; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable keyUpdateWaiting; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger status; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDFB410
        public void get_Value(){} // RVA: 0x7FFACBD827B0
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
        public void .cctor(){} // RVA: 0x7FFACBDFB5F0
    }

    public class PkiStatusInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Status; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiFreeText StatusString; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString FailInfo; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDFBA40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBDFC140 | overloaded x4
        public void get_Status(){} // RVA: 0x7FFACBD827B0
        public void get_StatusString(){} // RVA: 0x7FFAC2F247C0
        public void get_FailInfo(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDFC2B0
    }

    public class PollRepContent : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger CertReqID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger CheckAfter; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiFreeText Reason; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3000E00 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBDFC6A0
        public void get_CertReqID(){} // RVA: 0x7FFAC2F3C380
        public void get_CheckAfter(){} // RVA: 0x7FFAC2F247C0
        public void get_Reason(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDFC880
    }

    public class PollReqContent : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence content; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetInstance(){} // RVA: 0x7FFACBDFCAC0
        public void GetCertReqIDs(){} // RVA: 0x7FFACBDFCCD0
        public void SequenceToDerIntegerArray(){} // RVA: 0x7FFACBDFCFE0
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class PopoDecKeyChallContent : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence content; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetInstance(){} // RVA: 0x7FFACBDFD150
        public void ToChallengeArray(){} // RVA: 0x7FFACBDFD360
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class PopoDecKeyRespContent : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence content; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetInstance(){} // RVA: 0x7FFACBDFD690
        public void ToDerIntegerArray(){} // RVA: 0x7FFACBDFD8A0
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class ProtectedPart : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiHeader Header; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiBody Body; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDFDB70
        public void get_Header(){} // RVA: 0x7FFAC2F3C380
        public void get_Body(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDFDE70
    }

    public class RevAnnContent : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable Status; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.CertId CertID; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime WillBeRevokedAt; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime BadSinceDate; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions CrlDetails; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDFDF80
        public void GetInstance(){} // RVA: 0x7FFACBDFE480
        public void get_Status(){} // RVA: 0x7FFAC2F3C380
        public void get_CertID(){} // RVA: 0x7FFAC2F247C0
        public void get_WillBeRevokedAt(){} // RVA: 0x7FFAC2F4F0C0
        public void get_BadSinceDate(){} // RVA: 0x7FFAC2F4F130
        public void get_CrlDetails(){} // RVA: 0x7FFAC31D95E0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDFE660
    }

    public class RevDetails : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.CertTemplate CertDetails; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions CrlEntryDetails; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBDFEAA0
        public void get_CertDetails(){} // RVA: 0x7FFAC2F3C380
        public void get_CrlEntryDetails(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDFEDC0
    }

    public class RevRepContent : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence status; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence revCerts; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence crls; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDFEFC0
        public void GetInstance(){} // RVA: 0x7FFACBDFF100
        public void GetStatus(){} // RVA: 0x7FFACBDFF3F0
        public void GetRevCerts(){} // RVA: 0x7FFACBDFF560
        public void GetCrls(){} // RVA: 0x7FFACBDFF6D0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDFF840
    }

    public class RevRepContentBuilder : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1EncodableVector status; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1EncodableVector revCerts; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1EncodableVector crls; // 0x20

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBDFFB80 | overloaded x2
        public void AddCrl(){} // RVA: 0x7FFACBDFFC30
        public void Build(){} // RVA: 0x7FFACBDFFC60
        public void .ctor(){} // RVA: 0x7FFACBE00080
    }

    public class RevReqContent : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence content; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBE00430 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBE00220
        public void ToRevDetailsArray(){} // RVA: 0x7FFACBE004F0
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

}