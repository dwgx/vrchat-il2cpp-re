// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs
// Classes: 27
// Methods: 159

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs
{
    public class AttributePkcs : Asn1Encodable
    {
        public object attrType;
        public object attrValues;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA4170C0
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_AttrType(){} // RVA: 0xB5DBF0
        public void get_AttrValues(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA4173F0
    }

    public class AuthenticatedSafe : Asn1Encodable
    {
        public object info;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA417780
        public void GetContentInfo(){} // RVA: 0xA417880
        public void ToAsn1Object(){} // RVA: 0xA417900
    }

    public class CertBag : Asn1Encodable
    {
        public object certID;
        public object certValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_CertID(){} // RVA: 0xB5DBF0
        public void get_CertValue(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA417BA0
    }

    public class CertificationRequest : Asn1Encodable
    {
        public object reqInfo;
        public object sigAlgId;
        public object sigBits;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA417D30
        public void .ctor(){} // RVA: 0xA417E40
        public void GetCertificationRequestInfo(){} // RVA: 0xB5DBF0
        public void get_SignatureAlgorithm(){} // RVA: 0xB465B0
        public void get_Signature(){} // RVA: 0xB700F0
        public void GetSignatureOctets(){} // RVA: 0x718D460
        public void ToAsn1Object(){} // RVA: 0xA418150
    }

    public class CertificationRequestInfo : Asn1Encodable
    {
        public object version;
        public object subject;
        public object subjectPKInfo;
        public object attributes;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA4182B0
        public void .ctor(){} // RVA: 0xA4185C0
        public void get_Version(){} // RVA: 0xB5DBF0
        public void get_Subject(){} // RVA: 0xB465B0
        public void get_SubjectPublicKeyInfo(){} // RVA: 0xB700F0
        public void get_Attributes(){} // RVA: 0xB70160
        public void ToAsn1Object(){} // RVA: 0xA418A00
        public void ValidateAttributes(){} // RVA: 0xA418C40
    }

    public class ContentInfo : Asn1Encodable
    {
        public object contentType;
        public object content;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA419030
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_ContentType(){} // RVA: 0xB5DBF0
        public void get_Content(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA419340
    }

    public class DHParameter : Asn1Encodable
    {
        public object p;
        public object g;
        public object l;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4197F0
        public void get_P(){} // RVA: 0xA3D0110
        public void get_G(){} // RVA: 0xA3D0130
        public void get_L(){} // RVA: 0xA419B90
        public void ToAsn1Object(){} // RVA: 0xA419BB0
    }

    public class EncryptedData : Asn1Encodable
    {
        public object data;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA419E00
        public void .ctor(){} // RVA: 0xA41A2B0
        public void get_ContentType(){} // RVA: 0xA41A500
        public void get_EncryptionAlgorithm(){} // RVA: 0xA41A5A0
        public void get_Content(){} // RVA: 0xA41A5E0
        public void ToAsn1Object(){} // RVA: 0xA41A760
    }

    public class EncryptedPrivateKeyInfo : Asn1Encodable
    {
        public object algId;
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA41AA80
        public void GetInstance(){} // RVA: 0xA41AC30
        public void get_EncryptionAlgorithm(){} // RVA: 0xB5DBF0
        public void GetEncryptedData(){} // RVA: 0x673B450
        public void ToAsn1Object(){} // RVA: 0xA41AF70
    }

    public class EncryptionScheme : AlgorithmIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA41B080
        public void GetInstance(){} // RVA: 0xA41B160
        public void get_Asn1Object(){} // RVA: 0xA41B3F0
        public void ToAsn1Object(){} // RVA: 0xA41B430
    }

    public class IssuerAndSerialNumber : Asn1Encodable
    {
        public object name;
        public object certSerialNumber;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA41B570
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_Name(){} // RVA: 0xB5DBF0
        public void get_CertificateSerialNumber(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA41BB00
    }

    public class KeyDerivationFunc : AlgorithmIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E0F300
    }

    public class MacData : Asn1Encodable
    {
        public object digInfo;
        public object salt;
        public object iterationCount;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA41BC20
        public void .ctor(){} // RVA: 0xA41C130
        public void get_Mac(){} // RVA: 0xB5DBF0
        public void GetSalt(){} // RVA: 0xA41C320
        public void get_IterationCount(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA41C3A0
    }

    public class PbeParameter : Asn1Encodable
    {
        public object salt;
        public object iterationCount;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA41C7E0
        public void .ctor(){} // RVA: 0xA41CCC0
        public void GetSalt(){} // RVA: 0x678C250
        public void get_IterationCount(){} // RVA: 0xA3F7900
        public void ToAsn1Object(){} // RVA: 0xA41CEC0
    }

    public class PbeS2Parameters : Asn1Encodable
    {
        public object func;
        public object scheme;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA41CFD0
        public void .ctor(){} // RVA: 0xA41D080
        public void get_KeyDerivationFunc(){} // RVA: 0xB5DBF0
        public void get_EncryptionScheme(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA41D470
    }

    public class Pbkdf2Params : Asn1Encodable
    {
        public object algid_hmacWithSHA1;
        public object octStr;
        public object iterationCount;
        public object keyLength;
        public object prf;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA41D580
        public void .ctor(){} // RVA: 0xA41DFE0
        public void GetSalt(){} // RVA: 0x678C250
        public void get_IterationCount(){} // RVA: 0xA3F7900
        public void get_KeyLength(){} // RVA: 0xA3CA910
        public void get_IsDefaultPrf(){} // RVA: 0xA41E050
        public void get_Prf(){} // RVA: 0xA41E0E0
        public void ToAsn1Object(){} // RVA: 0xA41E150
        public void .cctor(){} // RVA: 0xA41E420
    }

    public class Pfx : Asn1Encodable
    {
        public object contentInfo;
        public object macData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_AuthSafe(){} // RVA: 0xB5DBF0
        public void get_MacData(){} // RVA: 0xB465B0
        public void ToAsn1Object(){} // RVA: 0xA41E9C0
    }

    public class Pkcs12PbeParams : Asn1Encodable
    {
        public object iterations;
        public object iv;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA41EDF0
        public void GetInstance(){} // RVA: 0xA41EF90
        public void get_Iterations(){} // RVA: 0xA41F2D0
        public void GetIV(){} // RVA: 0x673B450
        public void ToAsn1Object(){} // RVA: 0xA41F2F0
    }

    public class PkcsObjectIdentifiers : Object
    {
        public object Pkcs1;
        public object Pkcs1Oid;
        public object RsaEncryption;
        public object MD2WithRsaEncryption;
        public object MD4WithRsaEncryption;
        public object MD5WithRsaEncryption;
        public object Sha1WithRsaEncryption;
        public object SrsaOaepEncryptionSet;
        public object IdRsaesOaep;
        public object IdMgf1;
        public object IdPSpecified;
        public object IdRsassaPss;
        public object Sha256WithRsaEncryption;
        public object Sha384WithRsaEncryption;
        public object Sha512WithRsaEncryption;
        public object Sha224WithRsaEncryption;
        public object Sha512_224WithRSAEncryption;
        public object Sha512_256WithRSAEncryption;
        public object Pkcs3;
        public object DhKeyAgreement;
        public object Pkcs5;
        public object PbeWithMD2AndDesCbc;
        public object PbeWithMD2AndRC2Cbc;
        public object PbeWithMD5AndDesCbc;
        public object PbeWithMD5AndRC2Cbc;
        public object PbeWithSha1AndDesCbc;
        public object PbeWithSha1AndRC2Cbc;
        public object IdPbeS2;
        public object IdPbkdf2;
        public object EncryptionAlgorithm;
        public object DesEde3Cbc;
        public object RC2Cbc;
        public object rc4;
        public object DigestAlgorithm;
        public object MD2;
        public object MD4;
        public object MD5;
        public object IdHmacWithSha1;
        public object IdHmacWithSha224;
        public object IdHmacWithSha256;
        public object IdHmacWithSha384;
        public object IdHmacWithSha512;
        public object Pkcs7;
        public object Data;
        public object SignedData;
        public object EnvelopedData;
        public object SignedAndEnvelopedData;
        public object DigestedData;
        public object EncryptedData;
        public object Pkcs9;
        public object Pkcs9AtEmailAddress;
        public object Pkcs9AtUnstructuredName;
        public object Pkcs9AtContentType;
        public object Pkcs9AtMessageDigest;
        public object Pkcs9AtSigningTime;
        public object Pkcs9AtCounterSignature;
        public object Pkcs9AtChallengePassword;
        public object Pkcs9AtUnstructuredAddress;
        public object Pkcs9AtExtendedCertificateAttributes;
        public object Pkcs9AtSigningDescription;
        public object Pkcs9AtExtensionRequest;
        public object Pkcs9AtSmimeCapabilities;
        public object IdSmime;
        public object Pkcs9AtFriendlyName;
        public object Pkcs9AtLocalKeyID;
        public object X509CertType;
        public object CertTypes;
        public object X509Certificate;
        public object SdsiCertificate;
        public object CrlTypes;
        public object X509Crl;
        public object IdAlg;
        public object IdAlgEsdh;
        public object IdAlgCms3DesWrap;
        public object IdAlgCmsRC2Wrap;
        public object IdAlgPwriKek;
        public object IdAlgSsdh;
        public object IdRsaKem;
        public object PreferSignedData;
        public object CannotDecryptAny;
        public object SmimeCapabilitiesVersions;
        public object IdAAReceiptRequest;
        public object IdCT;
        public object IdCTAuthData;
        public object IdCTTstInfo;
        public object IdCTCompressedData;
        public object IdCTAuthEnvelopedData;
        public object IdCTTimestampedData;
        public object IdCti;
        public object IdCtiEtsProofOfOrigin;
        public object IdCtiEtsProofOfReceipt;
        public object IdCtiEtsProofOfDelivery;
        public object IdCtiEtsProofOfSender;
        public object IdCtiEtsProofOfApproval;
        public object IdCtiEtsProofOfCreation;
        public object IdAA;
        public object IdAAOid;
        public object IdAAContentHint;
        public object IdAAMsgSigDigest;
        public object IdAAContentReference;
        public object IdAAEncrypKeyPref;
        public object IdAASigningCertificate;
        public object IdAASigningCertificateV2;
        public object IdAAContentIdentifier;
        public object IdAASignatureTimeStampToken;
        public object IdAAEtsSigPolicyID;
        public object IdAAEtsCommitmentType;
        public object IdAAEtsSignerLocation;
        public object IdAAEtsSignerAttr;
        public object IdAAEtsOtherSigCert;
        public object IdAAEtsContentTimestamp;
        public object IdAAEtsCertificateRefs;
        public object IdAAEtsRevocationRefs;
        public object IdAAEtsCertValues;
        public object IdAAEtsRevocationValues;
        public object IdAAEtsEscTimeStamp;
        public object IdAAEtsCertCrlTimestamp;
        public object IdAAEtsArchiveTimestamp;
        public object IdAADecryptKeyID;
        public object IdAAImplCryptoAlgs;
        public object IdAAAsymmDecryptKeyID;
        public object IdAAImplCompressAlgs;
        public object IdAACommunityIdentifiers;
        public object IdAASigPolicyID;
        public object IdAACommitmentType;
        public object IdAASignerLocation;
        public object IdAAOtherSigCert;
        public object IdSpq;
        public object IdSpqEtsUri;
        public object IdSpqEtsUNotice;
        public object Pkcs12;
        public object BagTypes;
        public object KeyBag;
        public object Pkcs8ShroudedKeyBag;
        public object CertBag;
        public object CrlBag;
        public object SecretBag;
        public object SafeContentsBag;
        public object Pkcs12PbeIds;
        public object PbeWithShaAnd128BitRC4;
        public object PbeWithShaAnd40BitRC4;
        public object PbeWithShaAnd3KeyTripleDesCbc;
        public object PbeWithShaAnd2KeyTripleDesCbc;
        public object PbeWithShaAnd128BitRC2Cbc;
        public object PbewithShaAnd40BitRC2Cbc;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA41F400
    }

    public class PrivateKeyInfo : Asn1Encodable
    {
        public object version;
        public object privateKeyAlgorithm;
        public object privateKey;
        public object attributes;
        public object publicKey;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA422FF0
        public void GetVersionValue(){} // RVA: 0xA4230D0
        public void .ctor(){} // RVA: 0xA423640
        public void get_Attributes(){} // RVA: 0xB70160
        public void get_HasPublicKey(){} // RVA: 0x5BC22D0
        public void get_PrivateKeyAlgorithm(){} // RVA: 0xB465B0
        public void ParsePrivateKey(){} // RVA: 0xA423D10
        public void ParsePublicKey(){} // RVA: 0xA423D50
        public void get_PublicKeyData(){} // RVA: 0xD33E60
        public void ToAsn1Object(){} // RVA: 0xA423D90
    }

    public class RC2CbcParameter : Asn1Encodable
    {
        public object version;
        public object iv;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA424040
        public void .ctor(){} // RVA: 0xA4244F0
        public void get_RC2ParameterVersion(){} // RVA: 0xA424870
        public void GetIV(){} // RVA: 0xA424890
        public void ToAsn1Object(){} // RVA: 0xA424970
    }

    public class RsaPrivateKeyStructure : Asn1Encodable
    {
        public object modulus;
        public object publicExponent;
        public object privateExponent;
        public object prime1;
        public object prime2;
        public object exponent1;
        public object exponent2;
        public object coefficient;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA425A10
        public void .ctor(){} // RVA: 0xA425AF0
        public void get_Modulus(){} // RVA: 0xB5DBF0
        public void get_PublicExponent(){} // RVA: 0xB465B0
        public void get_PrivateExponent(){} // RVA: 0xB700F0
        public void get_Prime1(){} // RVA: 0xB70160
        public void get_Prime2(){} // RVA: 0xD33E60
        public void get_Exponent1(){} // RVA: 0xD05CA0
        public void get_Exponent2(){} // RVA: 0xBC1B30
        public void get_Coefficient(){} // RVA: 0xBBF8F0
        public void ToAsn1Object(){} // RVA: 0xA426220
    }

    public class RsaesOaepParameters : Asn1Encodable
    {
        public object hashAlgorithm;
        public object maskGenAlgorithm;
        public object pSourceAlgorithm;
        public object DefaultHashAlgorithm;
        public object DefaultMaskGenFunction;
        public object DefaultPSourceAlgorithm;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA424B20
        public void .ctor(){} // RVA: 0xA424E70
        public void get_HashAlgorithm(){} // RVA: 0xB5DBF0
        public void get_MaskGenAlgorithm(){} // RVA: 0xB465B0
        public void get_PSourceAlgorithm(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA425190
        public void .cctor(){} // RVA: 0xA425610
    }

    public class RsassaPssParameters : Asn1Encodable
    {
        public object hashAlgorithm;
        public object maskGenAlgorithm;
        public object saltLength;
        public object trailerField;
        public object DefaultHashAlgorithm;
        public object DefaultMaskGenFunction;
        public object DefaultSaltLength;
        public object DefaultTrailerField;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA426B10
        public void .ctor(){} // RVA: 0xA426EB0
        public void get_HashAlgorithm(){} // RVA: 0xB5DBF0
        public void get_MaskGenAlgorithm(){} // RVA: 0xB465B0
        public void get_SaltLength(){} // RVA: 0xB700F0
        public void get_TrailerField(){} // RVA: 0xB70160
        public void ToAsn1Object(){} // RVA: 0xA427300
        public void .cctor(){} // RVA: 0xA427880
    }

    public class SafeBag : Asn1Encodable
    {
        public object bagID;
        public object bagValue;
        public object bagAttributes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA427D00
        public void get_BagID(){} // RVA: 0xB5DBF0
        public void get_BagValue(){} // RVA: 0xB465B0
        public void get_BagAttributes(){} // RVA: 0xB700F0
        public void ToAsn1Object(){} // RVA: 0xA428060
    }

    public class SignedData : Asn1Encodable
    {
        public object version;
        public object digestAlgorithms;
        public object contentInfo;
        public object certificates;
        public object crls;
        public object signerInfos;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA428320
        public void .ctor(){} // RVA: 0xA4283D0
        public void get_Version(){} // RVA: 0xB5DBF0
        public void get_DigestAlgorithms(){} // RVA: 0xB465B0
        public void get_ContentInfo(){} // RVA: 0xB700F0
        public void get_Certificates(){} // RVA: 0xB70160
        public void get_Crls(){} // RVA: 0xD33E60
        public void get_SignerInfos(){} // RVA: 0xD05CA0
        public void ToAsn1Object(){} // RVA: 0xA428950
    }

    public class SignerInfo : Asn1Encodable
    {
        public object version;
        public object issuerAndSerialNumber;
        public object digAlgorithm;
        public object authenticatedAttributes;
        public object digEncryptionAlgorithm;
        public object encryptedDigest;
        public object unauthenticatedAttributes;

        // ── Methods ──
        public void GetInstance(){} // RVA: 0xA428BD0
        public void .ctor(){} // RVA: 0xA428DB0
        public void get_Version(){} // RVA: 0xB5DBF0
        public void get_IssuerAndSerialNumber(){} // RVA: 0xB465B0
        public void get_AuthenticatedAttributes(){} // RVA: 0xB70160
        public void get_DigestAlgorithm(){} // RVA: 0xB700F0
        public void get_EncryptedDigest(){} // RVA: 0xD05CA0
        public void get_DigestEncryptionAlgorithm(){} // RVA: 0xD33E60
        public void get_UnauthenticatedAttributes(){} // RVA: 0xBC1B30
        public void ToAsn1Object(){} // RVA: 0xA4295D0
    }

}