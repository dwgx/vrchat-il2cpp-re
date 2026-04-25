// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf
// Classes: 22
// Methods: 157

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf
{
    public class AttributeTypeAndValue : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Type; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable Value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBDCA200
        public void get_Type(){} // RVA: 0x7FFAC2F3C380
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDCA500
    }

    public class CertId : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName Issuer; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger SerialNumber; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDCA610
        public void GetInstance(){} // RVA: 0x7FFACBDCA9F0 | overloaded x2
        public void get_Issuer(){} // RVA: 0x7FFAC2F3C380
        public void get_SerialNumber(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDCAA10
    }

    public class CertReqMessages : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence content; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDCAD30 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDCAB20
        public void ToCertReqMsgArray(){} // RVA: 0x7FFACBDCADF0
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class CertReqMsg : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.CertRequest CertReq; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.ProofOfPossession Popo; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence regInfo; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDCB2E0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDCB2C0 | overloaded x2
        public void get_CertReq(){} // RVA: 0x7FFAC2F3C380
        public void get_Popo(){} // RVA: 0x7FFAC2F247C0
        public void GetRegInfo(){} // RVA: 0x7FFACBDCB4A0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDCB610
    }

    public class CertRequest : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger CertReqID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.CertTemplate CertTemplate; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.Controls Controls; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3000E00 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBDCBA00
        public void get_CertReqID(){} // RVA: 0x7FFAC2F3C380
        public void get_CertTemplate(){} // RVA: 0x7FFAC2F247C0
        public void get_Controls(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDCBC50
    }

    public class CertTemplate : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger SerialNumber; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger SigningAlg; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Issuer; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name Validity; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.OptionalValidity Subject; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name PublicKey; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo IssuerUID; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString SubjectUID; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString Extensions; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions extensions; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDCBE90
        public void GetInstance(){} // RVA: 0x7FFACBDCC350
        public void get_Version(){} // RVA: 0x7FFACBDCC430
        public void get_SerialNumber(){} // RVA: 0x7FFAC2F4F0C0
        public void get_SigningAlg(){} // RVA: 0x7FFAC2F4F130
        public void get_Issuer(){} // RVA: 0x7FFAC31D95E0
        public void get_Validity(){} // RVA: 0x7FFAC31D0140
        public void get_Subject(){} // RVA: 0x7FFAC2F9E740
        public void get_PublicKey(){} // RVA: 0x7FFAC2F9C730
        public void get_IssuerUID(){} // RVA: 0x7FFAC2FC20E0
        public void get_SubjectUID(){} // RVA: 0x7FFAC2FE9500
        public void get_Extensions(){} // RVA: 0x7FFAC2FBF370
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class CertTemplateBuilder : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger serialNumber; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signingAlg; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name issuer; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.OptionalValidity validity; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name subject; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo publicKey; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString issuerUID; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString subjectUID; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions extensions; // 0x58

        // ── Methods ──
        public void SetVersion(){} // RVA: 0x7FFACBDCC490
        public void SetSerialNumber(){} // RVA: 0x7FFAC46D4B40
        public void SetSigningAlg(){} // RVA: 0x7FFACBB3DA00
        public void SetIssuer(){} // RVA: 0x7FFAC499B040
        public void SetValidity(){} // RVA: 0x7FFAC499B0A0
        public void SetSubject(){} // RVA: 0x7FFAC499B100
        public void SetPublicKey(){} // RVA: 0x7FFAC499B160
        public void SetIssuerUID(){} // RVA: 0x7FFAC499B1C0
        public void SetSubjectUID(){} // RVA: 0x7FFAC499B220
        public void SetExtensions(){} // RVA: 0x7FFAC499B280
        public void Build(){} // RVA: 0x7FFACBDCC550
        public void AddOptional(){} // RVA: 0x7FFACBDCCBB0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Controls : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence content; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDCCE70 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDCCC60
        public void ToAttributeTypeAndValueArray(){} // RVA: 0x7FFACBDCCF30
        public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
    }

    public class CrmfObjectIdentifiers : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_pkix;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_pkip; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_regCtrl; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_regCtrl_regToken; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_regCtrl_authenticator; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_regCtrl_pkiPublicationInfo; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_regCtrl_pkiArchiveOptions; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier id_ct_encKeyWithID; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBDCD0A0
    }

    public class EncKeyWithID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo PrivateKey; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable HasIdentifier; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDCD650
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x4
        public void get_PrivateKey(){} // RVA: 0x7FFAC2F3C380
        public void get_HasIdentifier(){} // RVA: 0x7FFAC4860B40
        public void get_IsIdentifierUtf8String(){} // RVA: 0x7FFACBDCD9D0
        public void get_Identifier(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDCDA60
    }

    public class EncryptedKey : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.EnvelopedData IsEncryptedValue; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.EncryptedValue Value; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDCDC60
        public void .ctor(){} // RVA: 0x7FFAC2F87E80 | overloaded x2
        public void get_IsEncryptedValue(){} // RVA: 0x7FFAC4860B40
        public void get_Value(){} // RVA: 0x7FFAC7E06C90
        public void ToAsn1Object(){} // RVA: 0x7FFACBDCDEC0
    }

    public class EncryptedValue : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier IntendedAlg; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier SymmAlg; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString EncSymmKey; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier KeyAlg; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString ValueHint; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString EncValue; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDCE300 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDCE220
        public void get_IntendedAlg(){} // RVA: 0x7FFAC2F3C380
        public void get_SymmAlg(){} // RVA: 0x7FFAC2F247C0
        public void get_EncSymmKey(){} // RVA: 0x7FFAC2F4F0C0
        public void get_KeyAlg(){} // RVA: 0x7FFAC2F4F130
        public void get_ValueHint(){} // RVA: 0x7FFAC31D95E0
        public void get_EncValue(){} // RVA: 0x7FFAC31D0140
        public void ToAsn1Object(){} // RVA: 0x7FFACBDCE560
    }

    public class OptionalValidity : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time NotBefore; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time NotAfter; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDCEB00
        public void get_NotBefore(){} // RVA: 0x7FFAC2F3C380
        public void get_NotAfter(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDCEBD0
    }

    public class PKMacValue : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier AlgID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString MacValue; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBDD00A0 | overloaded x2
        public void get_AlgID(){} // RVA: 0x7FFAC2F3C380
        public void get_MacValue(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDD0210
    }

    public class PkiArchiveOptions : Asn1Encodable
    {
        public int Type;
        public int Value;
        public int archiveRemGenPrivKey;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable value; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBDCEE60
        public void .ctor(){} // RVA: 0x7FFACBDCF2B0 | overloaded x4
        public void get_Type(){} // RVA: 0x7FFACBDCF360
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void ToAsn1Object(){} // RVA: 0x7FFACBDCF420
    }

    public class PkiPublicationInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Action; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence pubInfos; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDCF5E0
        public void GetInstance(){} // RVA: 0x7FFACBDCF700
        public void get_Action(){} // RVA: 0x7FFAC2F3C380
        public void GetPubInfos(){} // RVA: 0x7FFACBDCF9C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDCFB30
    }

    public class PopoPrivKey : Asn1Encodable
    {
        public int Type;
        public int Value;
        public int dhMAC;
        public int agreeMAC;
        public int encryptedKey;
        public int tagNo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable obj; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91A2010 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDD05C0
        public void get_Type(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDD0660
    }

    public class PopoSigningKey : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.PopoSigningKeyInput PoposkInput; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier AlgorithmIdentifier; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString Signature; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3000E00 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBDD0DC0 | overloaded x2
        public void get_PoposkInput(){} // RVA: 0x7FFAC2F3C380
        public void get_AlgorithmIdentifier(){} // RVA: 0x7FFAC2F247C0
        public void get_Signature(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDD0F90
    }

    public class PopoSigningKeyInput : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName Sender; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.PKMacValue PublicKeyMac; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo PublicKey; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BA01A0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBDD13F0
        public void get_Sender(){} // RVA: 0x7FFAC2F3C380
        public void get_PublicKeyMac(){} // RVA: 0x7FFAC2F247C0
        public void get_PublicKey(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDD15D0
    }

    public class ProofOfPossession : Asn1Encodable
    {
        public int Type;
        public int Object;
        public int TYPE_KEY_ENCIPHERMENT;
        public int TYPE_KEY_AGREEMENT;
        public int tagNo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable obj; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47EB5F0 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFACBDD19F0
        public void get_Type(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Object(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDD1C80
    }

    public class SinglePubInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger PubLocation; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName pubLocation; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDD1D00
        public void GetInstance(){} // RVA: 0x7FFACBDD1E40
        public void get_PubLocation(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBDD2120
    }

    public class SubsequentMessage : DerInteger
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.SubsequentMessage encrCert;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.SubsequentMessage challengeResp; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBDD2320
        public void ValueOf(){} // RVA: 0x7FFACBDD2330
        public void .cctor(){} // RVA: 0x7FFACBDD2450
    }

}