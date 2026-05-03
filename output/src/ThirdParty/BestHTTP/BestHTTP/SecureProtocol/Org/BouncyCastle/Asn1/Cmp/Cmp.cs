// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp
// Classes: 38
// Methods: 261

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp
{
    public class CAKeyUpdAnnContent : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.CmpCertificate oldWithNew; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.CmpCertificate newWithOld; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.CmpCertificate newWithNew; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A246630
        public void GetInstance(){} // RVA: 0x7FFE8A2467C0
        public void get_OldWithNew(){} // RVA: 0x7FFE81116380
        public void get_NewWithOld(){} // RVA: 0x7FFE810FE7C0
        public void get_NewWithNew(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A2469A0
    }

    public class CertConfirmContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetInstance(){} // RVA: 0x7FFE8A246B00
        public void ToCertStatusArray(){} // RVA: 0x7FFE8A246D10
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class CertOrEncCert : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.CmpCertificate certificate; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.EncryptedValue encryptedCert; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A248090 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A247E00
        public void get_Certificate(){} // RVA: 0x7FFE81116380
        public void get_EncryptedCert(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A248140
    }

    public class CertRepMessage : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A248670 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A248490
        public void GetCAPubs(){} // RVA: 0x7FFE8A248800
        public void GetResponse(){} // RVA: 0x7FFE8A248970
        public void ToAsn1Object(){} // RVA: 0x7FFE8A248CA0
    }

    public class CertResponse : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger certReqId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo status; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.CertifiedKeyPair certifiedKeyPair; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A249350 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A249150
        public void get_CertReqID(){} // RVA: 0x7FFE81116380
        public void get_Status(){} // RVA: 0x7FFE810FE7C0
        public void get_CertifiedKeyPair(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A249560
    }

    public class CertStatus : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString certHash; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger certReqId; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo statusInfo; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A249C40 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A249F00
        public void get_CertHash(){} // RVA: 0x7FFE81116380
        public void get_CertReqID(){} // RVA: 0x7FFE810FE7C0
        public void get_StatusInfo(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A24A0E0
    }

    public class CertifiedKeyPair : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.CertOrEncCert certOrEncCert; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.EncryptedValue privateKey; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.PkiPublicationInfo publicationInfo; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2477B0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A247470
        public void get_CertOrEncCert(){} // RVA: 0x7FFE81116380
        public void get_PrivateKey(){} // RVA: 0x7FFE810FE7C0
        public void get_PublicationInfo(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A247910
    }

    public class Challenge : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier owf; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A24A320
        public void GetInstance(){} // RVA: 0x7FFE8A24A510
        public void get_Owf(){} // RVA: 0x7FFE81116380
        public void ToAsn1Object(){} // RVA: 0x7FFE8A24A6F0
    }

    public class CmpCertificate : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509CertificateStructure x509v3PKCert; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AttributeCertificate x509v2AttrCert; // 0x18
        public object field_2; // 0x903

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A24A940 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A24AA20
        public void get_IsX509v3PKCert(){} // RVA: 0x7FFE81C8DC00
        public void get_X509v3PKCert(){} // RVA: 0x7FFE81116380
        public void get_X509v2AttrCert(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A24ADB0
    }

    public class CmpObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A24AEB0
    }

    public class CrlAnnContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetInstance(){} // RVA: 0x7FFE8A24BF60
        public void ToCertificateListArray(){} // RVA: 0x7FFE8A24C170
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class ErrorMsgContent : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo pkiStatusInfo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger errorCode; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiFreeText errorDetails; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A24C8E0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A24C460
        public void get_PkiStatusInfo(){} // RVA: 0x7FFE81116380
        public void get_ErrorCode(){} // RVA: 0x7FFE810FE7C0
        public void get_ErrorDetails(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A24CA40
    }

    public class GenMsgContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A24CE90 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A24CC80
        public void ToInfoTypeAndValueArray(){} // RVA: 0x7FFE8A24CF50
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class GenRepContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A24D2D0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A24D0C0
        public void ToInfoTypeAndValueArray(){} // RVA: 0x7FFE8A24D390
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class InfoTypeAndValue : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier infoType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable infoValue; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A24D670
        public void get_InfoType(){} // RVA: 0x7FFE81116380
        public void get_InfoValue(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A24D980
    }

    public class KeyRecRepContent : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo status; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.CmpCertificate newSigCert; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A24DB80
        public void GetInstance(){} // RVA: 0x7FFE8A24DDF0
        public void get_Status(){} // RVA: 0x7FFE81116380
        public void get_NewSigCert(){} // RVA: 0x7FFE810FE7C0
        public void GetCACerts(){} // RVA: 0x7FFE8A24DFD0
        public void GetKeyPairHist(){} // RVA: 0x7FFE8A24E140
        public void ToAsn1Object(){} // RVA: 0x7FFE8A24E2B0
    }

    public class OobCertHash : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlg; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.CertId certId; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A24E690
        public void GetInstance(){} // RVA: 0x7FFE8A24E860
        public void get_HashAlg(){} // RVA: 0x7FFE81116380
        public void get_CertID(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A24EA40
    }

    public class PbmParameter : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString salt; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier owf; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger iterationCount; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier mac; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81143A50 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A24EEE0
        public void get_Salt(){} // RVA: 0x7FFE81116380
        public void get_Owf(){} // RVA: 0x7FFE810FE7C0
        public void get_IterationCount(){} // RVA: 0x7FFE811290C0
        public void get_Mac(){} // RVA: 0x7FFE81129130
        public void ToAsn1Object(){} // RVA: 0x7FFE8A24F350
    }

    public class PkiBody : Asn1Encodable
    {
        public int TYPE_INIT_REQ;
        public int TYPE_INIT_REP;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A24F4F0
        public void .ctor(){} // RVA: 0x7FFE8A24F800 | overloaded x2
        public void GetBodyForType(){} // RVA: 0x7FFE8A24F870
        public void get_Type(){} // RVA: 0x7FFE811485C0
        public void get_Content(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A250440
    }

    public class PkiConfirmContent : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A2504C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void ToAsn1Object(){} // RVA: 0x7FFE8A250640
    }

    public class PkiFailureInfo : DerBitString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A250700 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE8A2507B0
    }

    public class PkiFreeText : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence strings; // 0x10
        public object field_1; // 0x915
        public object field_2; // 0x916

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A2508F0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A250D30 | overloaded x2
        public void get_Size(){} // RVA: 0x7FFE815889F0
        public void get_Count(){} // RVA: 0x7FFE815889F0
        public void get_Item(){} // RVA: 0x7FFE8A250DF0
        public void GetStringAt(){} // RVA: 0x7FFE8A250E90
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class PkiHeader : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName NULL_NAME;
        public int CMP_1999; // 0x8
        public int CMP_2000; // 0xC
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger pvno; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName sender; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName recipient; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime messageTime; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier protectionAlg; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString senderKID; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString recipKID; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString transactionID; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811DAE00 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A251490
        public void get_Pvno(){} // RVA: 0x7FFE81116380
        public void get_Sender(){} // RVA: 0x7FFE810FE7C0
        public void get_Recipient(){} // RVA: 0x7FFE811290C0
        public void get_MessageTime(){} // RVA: 0x7FFE81129130
        public void get_ProtectionAlg(){} // RVA: 0x7FFE8144E200
        public void get_SenderKID(){} // RVA: 0x7FFE8143BA80
        public void get_RecipKID(){} // RVA: 0x7FFE81178740
        public void get_TransactionID(){} // RVA: 0x7FFE81176730
        public void get_SenderNonce(){} // RVA: 0x7FFE8119C0E0
        public void get_RecipNonce(){} // RVA: 0x7FFE811C3500
        public void get_FreeText(){} // RVA: 0x7FFE81199370
        public void GetGeneralInfo(){} // RVA: 0x7FFE8A2517E0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A251950
        public void .cctor(){} // RVA: 0x7FFE8A252290
    }

    public class PkiHeaderBuilder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811DAE00 | overloaded x2
        public void SetMessageTime(){} // RVA: 0x7FFE82C06B40
        public void SetProtectionAlg(){} // RVA: 0x7FFE82C06BA0
        public void SetSenderKID(){} // RVA: 0x7FFE82C06C00 | overloaded x2
        public void SetRecipKID(){} // RVA: 0x7FFE82C06C60 | overloaded x2
        public void SetTransactionID(){} // RVA: 0x7FFE82C06CC0 | overloaded x2
        public void SetSenderNonce(){} // RVA: 0x7FFE82C06D20 | overloaded x2
        public void SetRecipNonce(){} // RVA: 0x7FFE82C06D80 | overloaded x2
        public void SetFreeText(){} // RVA: 0x7FFE82C06DE0
        public void SetGeneralInfo(){} // RVA: 0x7FFE87A23DC0 | overloaded x3
        public void MakeGeneralInfoSeq(){} // RVA: 0x7FFE8A252A80 | overloaded x2
        public void Build(){} // RVA: 0x7FFE8A252CF0
        public void AddOptional(){} // RVA: 0x7FFE8A253990
    }

    public class PkiMessage : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiHeader header; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiBody body; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString protection; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A253F80 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFE8A253CC0
        public void get_Header(){} // RVA: 0x7FFE81116380
        public void get_Body(){} // RVA: 0x7FFE810FE7C0
        public void get_Protection(){} // RVA: 0x7FFE811290C0
        public void GetExtraCerts(){} // RVA: 0x7FFE8A253FA0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A254110
    }

    public class PkiMessages : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A254670 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A254460
        public void ToPkiMessageArray(){} // RVA: 0x7FFE8A254730
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class PkiStatusEncodable : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable granted;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A254A30
        public void get_Value(){} // RVA: 0x7FFE8A1DBDD0
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
        public void .cctor(){} // RVA: 0x7FFE8A254C10
    }

    public class PkiStatusInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger status; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiFreeText statusString; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString failInfo; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A255060 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A255760 | overloaded x4
        public void get_Status(){} // RVA: 0x7FFE8A1DBDD0
        public void get_StatusString(){} // RVA: 0x7FFE810FE7C0
        public void get_FailInfo(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A2558D0
    }

    public class PollRepContent : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger certReqId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger checkAfter; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiFreeText reason; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811DAE00 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A255CC0
        public void get_CertReqID(){} // RVA: 0x7FFE81116380
        public void get_CheckAfter(){} // RVA: 0x7FFE810FE7C0
        public void get_Reason(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A255EA0
    }

    public class PollReqContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetInstance(){} // RVA: 0x7FFE8A2560E0
        public void GetCertReqIDs(){} // RVA: 0x7FFE8A2562F0
        public void SequenceToDerIntegerArray(){} // RVA: 0x7FFE8A256600
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class PopoDecKeyChallContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetInstance(){} // RVA: 0x7FFE8A256770
        public void ToChallengeArray(){} // RVA: 0x7FFE8A256980
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class PopoDecKeyRespContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetInstance(){} // RVA: 0x7FFE8A256CB0
        public void ToDerIntegerArray(){} // RVA: 0x7FFE8A256EC0
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class ProtectedPart : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiHeader header; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiBody body; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A257190
        public void get_Header(){} // RVA: 0x7FFE81116380
        public void get_Body(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A257490
    }

    public class RevAnnContent : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable status; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.CertId certId; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime willBeRevokedAt; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime badSinceDate; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions crlDetails; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2575A0
        public void GetInstance(){} // RVA: 0x7FFE8A257AA0
        public void get_Status(){} // RVA: 0x7FFE81116380
        public void get_CertID(){} // RVA: 0x7FFE810FE7C0
        public void get_WillBeRevokedAt(){} // RVA: 0x7FFE811290C0
        public void get_BadSinceDate(){} // RVA: 0x7FFE81129130
        public void get_CrlDetails(){} // RVA: 0x7FFE8144E200
        public void ToAsn1Object(){} // RVA: 0x7FFE8A257C80
    }

    public class RevDetails : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.CertTemplate certDetails; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions crlEntryDetails; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A2580C0
        public void get_CertDetails(){} // RVA: 0x7FFE81116380
        public void get_CrlEntryDetails(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A2583E0
    }

    public class RevRepContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2585E0
        public void GetInstance(){} // RVA: 0x7FFE8A258720
        public void GetStatus(){} // RVA: 0x7FFE8A258A10
        public void GetRevCerts(){} // RVA: 0x7FFE8A258B80
        public void GetCrls(){} // RVA: 0x7FFE8A258CF0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A258E60
    }

    public class RevRepContentBuilder : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE8A2591A0 | overloaded x2
        public void AddCrl(){} // RVA: 0x7FFE8A259250
        public void Build(){} // RVA: 0x7FFE8A259280
        public void .ctor(){} // RVA: 0x7FFE8A2596A0
    }

    public class RevReqContent : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A259A50 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A259840
        public void ToRevDetailsArray(){} // RVA: 0x7FFE8A259B10
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

}