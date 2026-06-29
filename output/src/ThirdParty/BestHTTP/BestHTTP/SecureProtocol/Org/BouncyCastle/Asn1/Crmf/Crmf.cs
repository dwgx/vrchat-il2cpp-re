// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf
// Classes: 22
// Methods: 128

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Crmf
{
    public class AttributeTypeAndValue : Asn1Encodable
    {
        public object type;
        public object value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void GetInstance(){} // RVA: 0xA467060
        public void get_Type(){} // RVA: 0xB5DBF0
        public void get_Value(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA4674E0
    }

    public class CertId : Asn1Encodable
    {
        public object issuer;
        public object serialNumber;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4675F0
        public void GetInstance(){} // RVA: 0xA4679D0
        public void get_Issuer(){} // RVA: 0xB5DBF0
        public void get_SerialNumber(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA4679F0
    }

    public class CertReqMessages : Asn1Encodable
    {
        public object content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA467D10
        public void GetInstance(){} // RVA: 0xA467B00
        public void ToCertReqMsgArray(){} // RVA: 0xA467DD0
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class CertReqMsg : Asn1Encodable
    {
        public object certReq;
        public object popo;
        public object regInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4682D0
        public void GetInstance(){} // RVA: 0xA4682B0
        public void get_CertReq(){} // RVA: 0xB5DBF0
        public void get_Popo(){} // RVA: 0xB465B0
        public void GetRegInfo(){} // RVA: 0xA4684A0
        public void ToAsn1Object(){} // RVA: 0xA468630
    }

    public class CertRequest : Asn1Encodable
    {
        public object certReqId;
        public object certTemplate;
        public object controls;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC27FD0
        public void GetInstance(){} // RVA: 0xA468A30
        public void get_CertReqID(){} // RVA: 0xB5DBF0
        public void get_CertTemplate(){} // RVA: 0xB465B0
        public void get_Controls(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA468C90
    }

    public class CertTemplate : Asn1Encodable
    {
        public object seq;
        public object version;
        public object serialNumber;
        public object signingAlg;
        public object issuer;
        public object validity;
        public object subject;
        public object publicKey;
        public object issuerUID;
        public object subjectUID;
        public object extensions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA468EE0
        public void GetInstance(){} // RVA: 0xA469390
        public void get_Version(){} // RVA: 0xA469470
        public void get_SerialNumber(){} // RVA: 0xB700F0
        public void get_SigningAlg(){} // RVA: 0xB70160
        public void get_Issuer(){} // RVA: 0xD33E60
        public void get_Validity(){} // RVA: 0xD05CA0
        public void get_Subject(){} // RVA: 0xBC1B30
        public void get_PublicKey(){} // RVA: 0xBBF8F0
        public void get_IssuerUID(){} // RVA: 0xBE58B0
        public void get_SubjectUID(){} // RVA: 0xC0FFC0
        public void get_Extensions(){} // RVA: 0xBE2C60
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class CertTemplateBuilder : Object
    {
        public object version;
        public object serialNumber;
        public object signingAlg;
        public object issuer;
        public object validity;
        public object subject;
        public object publicKey;
        public object issuerUID;
        public object subjectUID;
        public object extensions;

        // ── Methods ──
        public void SetVersion(){} // RVA: 0xA4694D0
        public void SetSerialNumber(){} // RVA: 0xD33F30
        public void SetSigningAlg(){} // RVA: 0xA1D6890
        public void SetIssuer(){} // RVA: 0x26FED90
        public void SetValidity(){} // RVA: 0x26FEDF0
        public void SetSubject(){} // RVA: 0x26FEE50
        public void SetPublicKey(){} // RVA: 0x26FEEB0
        public void SetIssuerUID(){} // RVA: 0x26FEF10
        public void SetSubjectUID(){} // RVA: 0x26FEF70
        public void SetExtensions(){} // RVA: 0x26FEFD0
        public void Build(){} // RVA: 0xA469590
        public void AddOptional(){} // RVA: 0xA469BF0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Controls : Asn1Encodable
    {
        public object content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA469EB0
        public void GetInstance(){} // RVA: 0xA469CA0
        public void ToAttributeTypeAndValueArray(){} // RVA: 0xA469F70
        public void ToAsn1Object(){} // RVA: 0xB5DBF0
    }

    public class CrmfObjectIdentifiers : Object
    {
        public object id_pkix;
        public object id_pkip;
        public object id_regCtrl;
        public object id_regCtrl_regToken;
        public object id_regCtrl_authenticator;
        public object id_regCtrl_pkiPublicationInfo;
        public object id_regCtrl_pkiArchiveOptions;
        public object id_ct_encKeyWithID;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA46A0F0
    }

    public class EncKeyWithID : Asn1Encodable
    {
        public object privKeyInfo;
        public object identifier;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA46A6A0
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_PrivateKey(){} // RVA: 0xB5DBF0
        public void get_HasIdentifier(){} // RVA: 0x25E9250
        public void get_IsIdentifierUtf8String(){} // RVA: 0xA46AA20
        public void get_Identifier(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA46AAA0
    }

    public class EncryptedKey : Asn1Encodable
    {
        public object envelopedData;
        public object encryptedValue;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA46ACB0
        public void .ctor(){} // RVA: 0xBA9BA0
        public void get_IsEncryptedValue(){} // RVA: 0x25E9250
        public void get_Value(){} // RVA: 0x62A3B90
        public void ToAsn1Object(){} // RVA: 0xA46AF20
    }

    public class EncryptedValue : Asn1Encodable
    {
        public object intendedAlg;
        public object symmAlg;
        public object encSymmKey;
        public object keyAlg;
        public object valueHint;
        public object encValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA46B360
        public void GetInstance(){} // RVA: 0xA46B280
        public void get_IntendedAlg(){} // RVA: 0xB5DBF0
        public void get_SymmAlg(){} // RVA: 0xB465B0
        public void get_EncSymmKey(){} // RVA: 0xB700F0
        public void get_KeyAlg(){} // RVA: 0xB70160
        public void get_ValueHint(){} // RVA: 0xD33E60
        public void get_EncValue(){} // RVA: 0xD05CA0
        public void ToAsn1Object(){} // RVA: 0xA46B5C0
    }

    public class OptionalValidity : Asn1Encodable
    {
        public object notBefore;
        public object notAfter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void GetInstance(){} // RVA: 0xA46BB50
        public void get_NotBefore(){} // RVA: 0xB5DBF0
        public void get_NotAfter(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA46BC20
    }

    public class PKMacValue : Asn1Encodable
    {
        public object algID;
        public object macValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void GetInstance(){} // RVA: 0xA46D150
        public void get_AlgID(){} // RVA: 0xB5DBF0
        public void get_MacValue(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA46D2E0
    }

    public class PkiArchiveOptions : Asn1Encodable
    {
        public object encryptedPrivKey;
        public object keyGenParameters;
        public object archiveRemGenPrivKey;
        public object value;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA46BEC0
        public void .ctor(){} // RVA: 0xA46C310
        public void get_Type(){} // RVA: 0xA46C3C0
        public void get_Value(){} // RVA: 0xB5DBF0
        public void ToAsn1Object(){} // RVA: 0xA46C480
    }

    public class PkiPublicationInfo : Asn1Encodable
    {
        public object action;
        public object pubInfos;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA46C670
        public void GetInstance(){} // RVA: 0xA46C790
        public void get_Action(){} // RVA: 0xB5DBF0
        public void GetPubInfos(){} // RVA: 0xA46CA50
        public void ToAsn1Object(){} // RVA: 0xA46CBE0
    }

    public class PopoPrivKey : Asn1Encodable
    {
        public object thisMessage;
        public object subsequentMessage;
        public object dhMAC;
        public object agreeMAC;
        public object encryptedKey;
        public object tagNo;
        public object obj;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7470D50
        public void GetInstance(){} // RVA: 0xA46D690
        public void get_Type(){} // RVA: 0xB8F8F0
        public void get_Value(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA46D730
    }

    public class PopoSigningKey : Asn1Encodable
    {
        public object poposkInput;
        public object algorithmIdentifier;
        public object signature;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC27FD0
        public void GetInstance(){} // RVA: 0xA46DE90
        public void get_PoposkInput(){} // RVA: 0xB5DBF0
        public void get_AlgorithmIdentifier(){} // RVA: 0xB465B0
        public void get_Signature(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA46E060
    }

    public class PopoSigningKeyInput : Asn1Encodable
    {
        public object sender;
        public object publicKeyMac;
        public object publicKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E796B0
        public void GetInstance(){} // RVA: 0xA46E4C0
        public void get_Sender(){} // RVA: 0xB5DBF0
        public void get_PublicKeyMac(){} // RVA: 0xB465B0
        public void get_PublicKey(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA46E6A0
    }

    public class ProofOfPossession : Asn1Encodable
    {
        public object TYPE_RA_VERIFIED;
        public object TYPE_SIGNING_KEY;
        public object TYPE_KEY_ENCIPHERMENT;
        public object TYPE_KEY_AGREEMENT;
        public object tagNo;
        public object obj;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2574280
        public void GetInstance(){} // RVA: 0xA46EAC0
        public void get_Type(){} // RVA: 0xB8F8F0
        public void get_Object(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA46ED50
    }

    public class SinglePubInfo : Asn1Encodable
    {
        public object pubMethod;
        public object pubLocation;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA46EDD0
        public void GetInstance(){} // RVA: 0xA46EF10
        public void get_PubLocation(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA46F210
    }

    public class SubsequentMessage : DerInteger
    {
        public object encrCert;
        public object challengeResp;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA46F420
        public void ValueOf(){} // RVA: 0xA46F430
        public void .cctor(){} // RVA: 0xA46F550
    }

}