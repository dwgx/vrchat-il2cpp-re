// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf
// Classes: 22
// Methods: 128

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf
{
    public class AttributeTypeAndValue : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void GetInstance(){} // RVA: 0x7B15FBAA0
        public void get_Type(){} // RVA: 0x7A80F2570
        public void get_Value(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15FBF20
    }

    public class CertId : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15FC030
        public void GetInstance(){} // RVA: 0x7B15FC410
        public void get_Issuer(){} // RVA: 0x7A80F2570
        public void get_SerialNumber(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15FC430
    }

    public class CertReqMessages : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15FC750
        public void GetInstance(){} // RVA: 0x7B15FC540
        public void ToCertReqMsgArray(){} // RVA: 0x7B15FC810
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class CertReqMsg : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15FCD10
        public void GetInstance(){} // RVA: 0x7B15FCCF0
        public void get_CertReq(){} // RVA: 0x7A80F2570
        public void get_Popo(){} // RVA: 0x7A80DA7B0
        public void GetRegInfo(){} // RVA: 0x7B15FCEE0
        public void ToAsn1Object(){} // RVA: 0x7B15FD070
    }

    public class CertRequest : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81B7C50
        public void GetInstance(){} // RVA: 0x7B15FD470
        public void get_CertReqID(){} // RVA: 0x7A80F2570
        public void get_CertTemplate(){} // RVA: 0x7A80DA7B0
        public void get_Controls(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B15FD6D0
    }

    public class CertTemplate : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15FD920
        public void GetInstance(){} // RVA: 0x7B15FDDD0
        public void get_Version(){} // RVA: 0x7B15FDEB0
        public void get_SerialNumber(){} // RVA: 0x7A81052C0
        public void get_SigningAlg(){} // RVA: 0x7A8105330
        public void get_Issuer(){} // RVA: 0x7A83F69F0
        public void get_Validity(){} // RVA: 0x7A8292C30
        public void get_Subject(){} // RVA: 0x7A8154D80
        public void get_PublicKey(){} // RVA: 0x7A8152D80
        public void get_IssuerUID(){} // RVA: 0x7A8178B90
        public void get_SubjectUID(){} // RVA: 0x7A81A0050
        public void get_Extensions(){} // RVA: 0x7A8175DF0
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class CertTemplateBuilder : Object
    {
        // ── Methods ──
        public void SetVersion(){} // RVA: 0x7B15FDF10
        public void SetSerialNumber(){} // RVA: 0x7A9A186C0
        public void SetSigningAlg(){} // RVA: 0x7B136AFB0
        public void SetIssuer(){} // RVA: 0x7A9C81D90
        public void SetValidity(){} // RVA: 0x7A9C81DF0
        public void SetSubject(){} // RVA: 0x7A9C81E50
        public void SetPublicKey(){} // RVA: 0x7A9C81EB0
        public void SetIssuerUID(){} // RVA: 0x7A9C81F10
        public void SetSubjectUID(){} // RVA: 0x7A9C81F70
        public void SetExtensions(){} // RVA: 0x7A9C81FD0
        public void Build(){} // RVA: 0x7B15FDFD0
        public void AddOptional(){} // RVA: 0x7B15FE630
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Controls : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15FE8F0
        public void GetInstance(){} // RVA: 0x7B15FE6E0
        public void ToAttributeTypeAndValueArray(){} // RVA: 0x7B15FE9B0
        public void ToAsn1Object(){} // RVA: 0x7A80F2570
    }

    public class CrmfObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B15FEB30
    }

    public class EncKeyWithID : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15FF0E0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_PrivateKey(){} // RVA: 0x7A80F2570
        public void get_HasIdentifier(){} // RVA: 0x7A9B3D890
        public void get_IsIdentifierUtf8String(){} // RVA: 0x7B15FF460
        public void get_Identifier(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B15FF4E0
    }

    public class EncryptedKey : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B15FF6F0
        public void .ctor(){} // RVA: 0x7A813E420
        public void get_IsEncryptedValue(){} // RVA: 0x7A9B3D890
        public void get_Value(){} // RVA: 0x7AD548C20
        public void ToAsn1Object(){} // RVA: 0x7B15FF960
    }

    public class EncryptedValue : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15FFDA0
        public void GetInstance(){} // RVA: 0x7B15FFCC0
        public void get_IntendedAlg(){} // RVA: 0x7A80F2570
        public void get_SymmAlg(){} // RVA: 0x7A80DA7B0
        public void get_EncSymmKey(){} // RVA: 0x7A81052C0
        public void get_KeyAlg(){} // RVA: 0x7A8105330
        public void get_ValueHint(){} // RVA: 0x7A83F69F0
        public void get_EncValue(){} // RVA: 0x7A8292C30
        public void ToAsn1Object(){} // RVA: 0x7B1600000
    }

    public class OptionalValidity : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void GetInstance(){} // RVA: 0x7B1600590
        public void get_NotBefore(){} // RVA: 0x7A80F2570
        public void get_NotAfter(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1600660
    }

    public class PKMacValue : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void GetInstance(){} // RVA: 0x7B1601B90
        public void get_AlgID(){} // RVA: 0x7A80F2570
        public void get_MacValue(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1601D20
    }

    public class PkiArchiveOptions : Asn1Encodable
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7B1600900
        public void .ctor(){} // RVA: 0x7B1600D50
        public void get_Type(){} // RVA: 0x7B1600E00
        public void get_Value(){} // RVA: 0x7A80F2570
        public void ToAsn1Object(){} // RVA: 0x7B1600EC0
    }

    public class PkiPublicationInfo : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16010B0
        public void GetInstance(){} // RVA: 0x7B16011D0
        public void get_Action(){} // RVA: 0x7A80F2570
        public void GetPubInfos(){} // RVA: 0x7B1601490
        public void ToAsn1Object(){} // RVA: 0x7B1601620
    }

    public class PopoPrivKey : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7FB640
        public void GetInstance(){} // RVA: 0x7B16020D0
        public void get_Type(){} // RVA: 0x7A8124910
        public void get_Value(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1602170
    }

    public class PopoSigningKey : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81B7C50
        public void GetInstance(){} // RVA: 0x7B16028D0
        public void get_PoposkInput(){} // RVA: 0x7A80F2570
        public void get_AlgorithmIdentifier(){} // RVA: 0x7A80DA7B0
        public void get_Signature(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B1602AA0
    }

    public class PopoSigningKeyInput : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE1F6C50
        public void GetInstance(){} // RVA: 0x7B1602F00
        public void get_Sender(){} // RVA: 0x7A80F2570
        public void get_PublicKeyMac(){} // RVA: 0x7A80DA7B0
        public void get_PublicKey(){} // RVA: 0x7A81052C0
        public void ToAsn1Object(){} // RVA: 0x7B16030E0
    }

    public class ProofOfPossession : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9AC8120
        public void GetInstance(){} // RVA: 0x7B1603500
        public void get_Type(){} // RVA: 0x7A8124910
        public void get_Object(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1603790
    }

    public class SinglePubInfo : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1603810
        public void GetInstance(){} // RVA: 0x7B1603950
        public void get_PubLocation(){} // RVA: 0x7A80DA7B0
        public void ToAsn1Object(){} // RVA: 0x7B1603C50
    }

    public class SubsequentMessage : DerInteger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1603E60
        public void ValueOf(){} // RVA: 0x7B1603E70
        public void .cctor(){} // RVA: 0x7B1603F90
    }

}