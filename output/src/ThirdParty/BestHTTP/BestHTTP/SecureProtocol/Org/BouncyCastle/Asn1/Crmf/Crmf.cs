// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf
// Classes: 22
// Methods: 157

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf
{
    public class AttributeTypeAndValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x3
        public void GetInstance(){} // RVA: 0x97C1420
        public void get_Type(){} // RVA: 0x2F8380
        public void get_Value(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97C1720
    }

    public class CertId
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97C1830
        public void GetInstance(){} // RVA: 0x97C1C10 | overloaded x2
        public void get_Issuer(){} // RVA: 0x2F8380
        public void get_SerialNumber(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97C1C30
    }

    public class CertReqMessages
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97C1F50 | overloaded x2
        public void GetInstance(){} // RVA: 0x97C1D40
        public void ToCertReqMsgArray(){} // RVA: 0x97C2010
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class CertReqMsg
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97C2500 | overloaded x2
        public void GetInstance(){} // RVA: 0x97C24E0 | overloaded x2
        public void get_CertReq(){} // RVA: 0x2F8380
        public void get_Popo(){} // RVA: 0x2E07C0
        public void GetRegInfo(){} // RVA: 0x97C26C0
        public void ToAsn1Object(){} // RVA: 0x97C2830
    }

    public class CertRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3BCE00 | overloaded x3
        public void GetInstance(){} // RVA: 0x97C2C20
        public void get_CertReqID(){} // RVA: 0x2F8380
        public void get_CertTemplate(){} // RVA: 0x2E07C0
        public void get_Controls(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97C2E70
    }

    public class CertTemplate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97C30B0
        public void GetInstance(){} // RVA: 0x97C3570
        public void get_Version(){} // RVA: 0x97C3650
        public void get_SerialNumber(){} // RVA: 0x30B0C0
        public void get_SigningAlg(){} // RVA: 0x30B130
        public void get_Issuer(){} // RVA: 0x6374D0
        public void get_Validity(){} // RVA: 0x4976A0
        public void get_Subject(){} // RVA: 0x35A740
        public void get_PublicKey(){} // RVA: 0x358730
        public void get_IssuerUID(){} // RVA: 0x37E0E0
        public void get_SubjectUID(){} // RVA: 0x3A5500
        public void get_Extensions(){} // RVA: 0x37B370
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class CertTemplateBuilder
    {
        // ── Methods ──
        public void SetVersion(){} // RVA: 0x97C36B0
        public void SetSerialNumber(){} // RVA: 0x1C5A060
        public void SetSigningAlg(){} // RVA: 0x9534C50
        public void SetIssuer(){} // RVA: 0x1E7D3C0
        public void SetValidity(){} // RVA: 0x1E7D420
        public void SetSubject(){} // RVA: 0x1E7D480
        public void SetPublicKey(){} // RVA: 0x1E7D4E0
        public void SetIssuerUID(){} // RVA: 0x1E7D540
        public void SetSubjectUID(){} // RVA: 0x1E7D5A0
        public void SetExtensions(){} // RVA: 0x1E7D600
        public void Build(){} // RVA: 0x97C3770
        public void AddOptional(){} // RVA: 0x97C3DD0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Controls
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97C4090 | overloaded x2
        public void GetInstance(){} // RVA: 0x97C3E80
        public void ToAttributeTypeAndValueArray(){} // RVA: 0x97C4150
        public void ToAsn1Object(){} // RVA: 0x2F8380
    }

    public class CrmfObjectIdentifiers
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x97C42C0
    }

    public class EncKeyWithID
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97C4870
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x4
        public void get_PrivateKey(){} // RVA: 0x2F8380
        public void get_HasIdentifier(){} // RVA: 0x1D3B060
        public void get_IsIdentifierUtf8String(){} // RVA: 0x97C4BF0
        public void get_Identifier(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97C4C80
    }

    public class EncryptedKey : GetInstance
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97C4E80
        public void .ctor(){} // RVA: 0x343E80 | overloaded x2
        public void get_IsEncryptedValue(){} // RVA: 0x1D3B060
        public void get_Value(){} // RVA: 0x5779CE0
        public void ToAsn1Object(){} // RVA: 0x97C50E0
    }

    public class EncryptedValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97C5520 | overloaded x2
        public void GetInstance(){} // RVA: 0x97C5440
        public void get_IntendedAlg(){} // RVA: 0x2F8380
        public void get_SymmAlg(){} // RVA: 0x2E07C0
        public void get_EncSymmKey(){} // RVA: 0x30B0C0
        public void get_KeyAlg(){} // RVA: 0x30B130
        public void get_ValueHint(){} // RVA: 0x6374D0
        public void get_EncValue(){} // RVA: 0x4976A0
        public void ToAsn1Object(){} // RVA: 0x97C5780
    }

    public class OptionalValidity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void GetInstance(){} // RVA: 0x97C5D20
        public void get_NotBefore(){} // RVA: 0x2F8380
        public void get_NotAfter(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97C5DF0
    }

    public class PKMacValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x3
        public void GetInstance(){} // RVA: 0x97C72C0 | overloaded x2
        public void get_AlgID(){} // RVA: 0x2F8380
        public void get_MacValue(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97C7430
    }

    public class PkiArchiveOptions
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97C6080
        public void .ctor(){} // RVA: 0x97C64D0 | overloaded x4
        public void get_Type(){} // RVA: 0x97C6580
        public void get_Value(){} // RVA: 0x2F8380
        public void ToAsn1Object(){} // RVA: 0x97C6640
    }

    public class PkiPublicationInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97C6800
        public void GetInstance(){} // RVA: 0x97C6920
        public void get_Action(){} // RVA: 0x2F8380
        public void GetPubInfos(){} // RVA: 0x97C6BE0
        public void ToAsn1Object(){} // RVA: 0x97C6D50
    }

    public class PopoPrivKey : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A0B4C0 | overloaded x2
        public void GetInstance(){} // RVA: 0x97C77E0
        public void get_Type(){} // RVA: 0x32A5C0
        public void get_Value(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97C7880
    }

    public class PopoSigningKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3BCE00 | overloaded x2
        public void GetInstance(){} // RVA: 0x97C7FE0 | overloaded x2
        public void get_PoposkInput(){} // RVA: 0x2F8380
        public void get_AlgorithmIdentifier(){} // RVA: 0x2E07C0
        public void get_Signature(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97C81B0
    }

    public class PopoSigningKeyInput
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6408E20 | overloaded x3
        public void GetInstance(){} // RVA: 0x97C8610
        public void get_Sender(){} // RVA: 0x2F8380
        public void get_PublicKeyMac(){} // RVA: 0x2E07C0
        public void get_PublicKey(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x97C87F0
    }

    public class ProofOfPossession
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CC5AF0 | overloaded x4
        public void GetInstance(){} // RVA: 0x97C8C10
        public void get_Type(){} // RVA: 0x32A5C0
        public void get_Object(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97C8EA0
    }

    public class SinglePubInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97C8F20
        public void GetInstance(){} // RVA: 0x97C9060
        public void get_PubLocation(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97C9340
    }

    public class SubsequentMessage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97C9540
        public void ValueOf(){} // RVA: 0x97C9550
        public void .cctor(){} // RVA: 0x97C9670
    }

}