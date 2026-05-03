// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf
// Classes: 22
// Methods: 157

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf
{
    public class AttributeTypeAndValue : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier type; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A223820
        public void get_Type(){} // RVA: 0x7FFE81116380
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A223B20
    }

    public class CertId : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName issuer; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger serialNumber; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A223C30
        public void GetInstance(){} // RVA: 0x7FFE8A224010 | overloaded x2
        public void get_Issuer(){} // RVA: 0x7FFE81116380
        public void get_SerialNumber(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A224030
    }

    public class CertReqMessages : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A224350 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A224140
        public void ToCertReqMsgArray(){} // RVA: 0x7FFE8A224410
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class CertReqMsg : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.CertRequest certReq; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.ProofOfPossession popo; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A224900 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A2248E0 | overloaded x2
        public void get_CertReq(){} // RVA: 0x7FFE81116380
        public void get_Popo(){} // RVA: 0x7FFE810FE7C0
        public void GetRegInfo(){} // RVA: 0x7FFE8A224AC0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A224C30
    }

    public class CertRequest : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger certReqId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.CertTemplate certTemplate; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.Controls controls; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811DAE00 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A225020
        public void get_CertReqID(){} // RVA: 0x7FFE81116380
        public void get_CertTemplate(){} // RVA: 0x7FFE810FE7C0
        public void get_Controls(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A225270
    }

    public class CertTemplate : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence seq; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger serialNumber; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signingAlg; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name issuer; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.OptionalValidity validity; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name subject; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo publicKey; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString issuerUID; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString subjectUID; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2254B0
        public void GetInstance(){} // RVA: 0x7FFE8A225970
        public void get_Version(){} // RVA: 0x7FFE8A225A50
        public void get_SerialNumber(){} // RVA: 0x7FFE811290C0
        public void get_SigningAlg(){} // RVA: 0x7FFE81129130
        public void get_Issuer(){} // RVA: 0x7FFE8144E200
        public void get_Validity(){} // RVA: 0x7FFE8143BA80
        public void get_Subject(){} // RVA: 0x7FFE81178740
        public void get_PublicKey(){} // RVA: 0x7FFE81176730
        public void get_IssuerUID(){} // RVA: 0x7FFE8119C0E0
        public void get_SubjectUID(){} // RVA: 0x7FFE811C3500
        public void get_Extensions(){} // RVA: 0x7FFE81199370
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class CertTemplateBuilder : Object
    {
        // ── Methods ──
        public void SetVersion(){} // RVA: 0x7FFE8A225AB0
        public void SetSerialNumber(){} // RVA: 0x7FFE829DE9A0
        public void SetSigningAlg(){} // RVA: 0x7FFE89F97020
        public void SetIssuer(){} // RVA: 0x7FFE82C06B40
        public void SetValidity(){} // RVA: 0x7FFE82C06BA0
        public void SetSubject(){} // RVA: 0x7FFE82C06C00
        public void SetPublicKey(){} // RVA: 0x7FFE82C06C60
        public void SetIssuerUID(){} // RVA: 0x7FFE82C06CC0
        public void SetSubjectUID(){} // RVA: 0x7FFE82C06D20
        public void SetExtensions(){} // RVA: 0x7FFE82C06D80
        public void Build(){} // RVA: 0x7FFE8A225B70
        public void AddOptional(){} // RVA: 0x7FFE8A2261D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Controls : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A226490 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A226280
        public void ToAttributeTypeAndValueArray(){} // RVA: 0x7FFE8A226550
        public void ToAsn1Object(){} // RVA: 0x7FFE81116380
    }

    public class CrmfObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A2266C0
    }

    public class EncKeyWithID : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo privKeyInfo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable identifier; // 0x18
        public object field_2; // 0x855
        public object field_3; // 0x856

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A226C70
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x4
        public void get_PrivateKey(){} // RVA: 0x7FFE81116380
        public void get_HasIdentifier(){} // RVA: 0x7FFE82AC8EE0
        public void get_IsIdentifierUtf8String(){} // RVA: 0x7FFE8A226FF0
        public void get_Identifier(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A227080
    }

    public class EncryptedKey : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.EnvelopedData envelopedData; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.EncryptedValue encryptedValue; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A227280
        public void .ctor(){} // RVA: 0x7FFE81161E80 | overloaded x2
        public void get_IsEncryptedValue(){} // RVA: 0x7FFE82AC8EE0
        public void get_Value(){} // RVA: 0x7FFE8622A440
        public void ToAsn1Object(){} // RVA: 0x7FFE8A2274E0
    }

    public class EncryptedValue : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier intendedAlg; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier symmAlg; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString encSymmKey; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyAlg; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString valueHint; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString encValue; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A227920 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A227840
        public void get_IntendedAlg(){} // RVA: 0x7FFE81116380
        public void get_SymmAlg(){} // RVA: 0x7FFE810FE7C0
        public void get_EncSymmKey(){} // RVA: 0x7FFE811290C0
        public void get_KeyAlg(){} // RVA: 0x7FFE81129130
        public void get_ValueHint(){} // RVA: 0x7FFE8144E200
        public void get_EncValue(){} // RVA: 0x7FFE8143BA80
        public void ToAsn1Object(){} // RVA: 0x7FFE8A227B80
    }

    public class OptionalValidity : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time notBefore; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.Time notAfter; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A228120
        public void get_NotBefore(){} // RVA: 0x7FFE81116380
        public void get_NotAfter(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A2281F0
    }

    public class PKMacValue : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString macValue; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A2296C0 | overloaded x2
        public void get_AlgID(){} // RVA: 0x7FFE81116380
        public void get_MacValue(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A229830
    }

    public class PkiArchiveOptions : Asn1Encodable
    {
        public int encryptedPrivKey;
        public int keyGenParameters;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A228480
        public void .ctor(){} // RVA: 0x7FFE8A2288D0 | overloaded x4
        public void get_Type(){} // RVA: 0x7FFE8A228980
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void ToAsn1Object(){} // RVA: 0x7FFE8A228A40
    }

    public class PkiPublicationInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger action; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A228C00
        public void GetInstance(){} // RVA: 0x7FFE8A228D20
        public void get_Action(){} // RVA: 0x7FFE81116380
        public void GetPubInfos(){} // RVA: 0x7FFE8A228FE0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A229150
    }

    public class PopoPrivKey : Asn1Encodable
    {
        public int thisMessage;
        public int subsequentMessage;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8754A7C0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A229BE0
        public void get_Type(){} // RVA: 0x7FFE811485C0
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A229C80
    }

    public class PopoSigningKey : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.PopoSigningKeyInput poposkInput; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algorithmIdentifier; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString signature; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811DAE00 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A22A3E0 | overloaded x2
        public void get_PoposkInput(){} // RVA: 0x7FFE81116380
        public void get_AlgorithmIdentifier(){} // RVA: 0x7FFE810FE7C0
        public void get_Signature(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A22A5B0
    }

    public class PopoSigningKeyInput : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.GeneralName sender; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf.PKMacValue publicKeyMac; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo publicKey; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F49820 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A22AA10
        public void get_Sender(){} // RVA: 0x7FFE81116380
        public void get_PublicKeyMac(){} // RVA: 0x7FFE810FE7C0
        public void get_PublicKey(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A22ABF0
    }

    public class ProofOfPossession : Asn1Encodable
    {
        public int TYPE_RA_VERIFIED;
        public int TYPE_SIGNING_KEY;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A53990 | overloaded x4
        public void GetInstance(){} // RVA: 0x7FFE8A22B010
        public void get_Type(){} // RVA: 0x7FFE811485C0
        public void get_Object(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A22B2A0
    }

    public class SinglePubInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger pubMethod; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A22B320
        public void GetInstance(){} // RVA: 0x7FFE8A22B460
        public void get_PubLocation(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A22B740
    }

    public class SubsequentMessage : DerInteger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A22B940
        public void ValueOf(){} // RVA: 0x7FFE8A22B950
        public void .cctor(){} // RVA: 0x7FFE8A22BA70
    }

}