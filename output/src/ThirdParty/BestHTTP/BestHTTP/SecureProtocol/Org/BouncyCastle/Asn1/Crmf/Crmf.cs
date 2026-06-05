// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf
// Classes: 22
// Methods: 157

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf
{
    public class AttributeTypeAndValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC271420
        public void get_Type(){} // RVA: 0x7FFAF2DA8380
        public void get_Value(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC271720
    }

    public class CertId
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC271830
        public void GetInstance(){} // RVA: 0x7FFAFC271C10 | overloaded x2
        public void get_Issuer(){} // RVA: 0x7FFAF2DA8380
        public void get_SerialNumber(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC271C30
    }

    public class CertReqMessages
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC271F50 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC271D40
        public void ToCertReqMsgArray(){} // RVA: 0x7FFAFC272010
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class CertReqMsg
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC272500 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC2724E0 | overloaded x2
        public void get_CertReq(){} // RVA: 0x7FFAF2DA8380
        public void get_Popo(){} // RVA: 0x7FFAF2D907C0
        public void GetRegInfo(){} // RVA: 0x7FFAFC2726C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC272830
    }

    public class CertRequest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E6CE00 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC272C20
        public void get_CertReqID(){} // RVA: 0x7FFAF2DA8380
        public void get_CertTemplate(){} // RVA: 0x7FFAF2D907C0
        public void get_Controls(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC272E70
    }

    public class CertTemplate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2730B0
        public void GetInstance(){} // RVA: 0x7FFAFC273570
        public void get_Version(){} // RVA: 0x7FFAFC273650
        public void get_SerialNumber(){} // RVA: 0x7FFAF2DBB0C0
        public void get_SigningAlg(){} // RVA: 0x7FFAF2DBB130
        public void get_Issuer(){} // RVA: 0x7FFAF30E74D0
        public void get_Validity(){} // RVA: 0x7FFAF2F476A0
        public void get_Subject(){} // RVA: 0x7FFAF2E0A740
        public void get_PublicKey(){} // RVA: 0x7FFAF2E08730
        public void get_IssuerUID(){} // RVA: 0x7FFAF2E2E0E0
        public void get_SubjectUID(){} // RVA: 0x7FFAF2E55500
        public void get_Extensions(){} // RVA: 0x7FFAF2E2B370
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class CertTemplateBuilder
    {
        // ── Methods ──
        public void SetVersion(){} // RVA: 0x7FFAFC2736B0
        public void SetSerialNumber(){} // RVA: 0x7FFAF470A060
        public void SetSigningAlg(){} // RVA: 0x7FFAFBFE4C50
        public void SetIssuer(){} // RVA: 0x7FFAF492D3C0
        public void SetValidity(){} // RVA: 0x7FFAF492D420
        public void SetSubject(){} // RVA: 0x7FFAF492D480
        public void SetPublicKey(){} // RVA: 0x7FFAF492D4E0
        public void SetIssuerUID(){} // RVA: 0x7FFAF492D540
        public void SetSubjectUID(){} // RVA: 0x7FFAF492D5A0
        public void SetExtensions(){} // RVA: 0x7FFAF492D600
        public void Build(){} // RVA: 0x7FFAFC273770
        public void AddOptional(){} // RVA: 0x7FFAFC273DD0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Controls
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC274090 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC273E80
        public void ToAttributeTypeAndValueArray(){} // RVA: 0x7FFAFC274150
        public void ToAsn1Object(){} // RVA: 0x7FFAF2DA8380
    }

    public class CrmfObjectIdentifiers
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC2742C0
    }

    public class EncKeyWithID
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC274870
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x4
        public void get_PrivateKey(){} // RVA: 0x7FFAF2DA8380
        public void get_HasIdentifier(){} // RVA: 0x7FFAF47EB060
        public void get_IsIdentifierUtf8String(){} // RVA: 0x7FFAFC274BF0
        public void get_Identifier(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC274C80
    }

    public class EncryptedKey : GetInstance
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC274E80
        public void .ctor(){} // RVA: 0x7FFAF2DF3E80 | overloaded x2
        public void get_IsEncryptedValue(){} // RVA: 0x7FFAF47EB060
        public void get_Value(){} // RVA: 0x7FFAF8229CE0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC2750E0
    }

    public class EncryptedValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC275520 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC275440
        public void get_IntendedAlg(){} // RVA: 0x7FFAF2DA8380
        public void get_SymmAlg(){} // RVA: 0x7FFAF2D907C0
        public void get_EncSymmKey(){} // RVA: 0x7FFAF2DBB0C0
        public void get_KeyAlg(){} // RVA: 0x7FFAF2DBB130
        public void get_ValueHint(){} // RVA: 0x7FFAF30E74D0
        public void get_EncValue(){} // RVA: 0x7FFAF2F476A0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC275780
    }

    public class OptionalValidity
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC275D20
        public void get_NotBefore(){} // RVA: 0x7FFAF2DA8380
        public void get_NotAfter(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC275DF0
    }

    public class PKMacValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC2772C0 | overloaded x2
        public void get_AlgID(){} // RVA: 0x7FFAF2DA8380
        public void get_MacValue(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC277430
    }

    public class PkiArchiveOptions
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFAFC276080
        public void .ctor(){} // RVA: 0x7FFAFC2764D0 | overloaded x4
        public void get_Type(){} // RVA: 0x7FFAFC276580
        public void get_Value(){} // RVA: 0x7FFAF2DA8380
        public void ToAsn1Object(){} // RVA: 0x7FFAFC276640
    }

    public class PkiPublicationInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC276800
        public void GetInstance(){} // RVA: 0x7FFAFC276920
        public void get_Action(){} // RVA: 0x7FFAF2DA8380
        public void GetPubInfos(){} // RVA: 0x7FFAFC276BE0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC276D50
    }

    public class PopoPrivKey : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF94BB4C0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC2777E0
        public void get_Type(){} // RVA: 0x7FFAF2DDA5C0
        public void get_Value(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC277880
    }

    public class PopoSigningKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E6CE00 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAFC277FE0 | overloaded x2
        public void get_PoposkInput(){} // RVA: 0x7FFAF2DA8380
        public void get_AlgorithmIdentifier(){} // RVA: 0x7FFAF2D907C0
        public void get_Signature(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC2781B0
    }

    public class PopoSigningKeyInput
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8EB8E20 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFAFC278610
        public void get_Sender(){} // RVA: 0x7FFAF2DA8380
        public void get_PublicKeyMac(){} // RVA: 0x7FFAF2D907C0
        public void get_PublicKey(){} // RVA: 0x7FFAF2DBB0C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC2787F0
    }

    public class ProofOfPossession
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4775AF0 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFAFC278C10
        public void get_Type(){} // RVA: 0x7FFAF2DDA5C0
        public void get_Object(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC278EA0
    }

    public class SinglePubInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC278F20
        public void GetInstance(){} // RVA: 0x7FFAFC279060
        public void get_PubLocation(){} // RVA: 0x7FFAF2D907C0
        public void ToAsn1Object(){} // RVA: 0x7FFAFC279340
    }

    public class SubsequentMessage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC279540
        public void ValueOf(){} // RVA: 0x7FFAFC279550
        public void .cctor(){} // RVA: 0x7FFAFC279670
    }

}