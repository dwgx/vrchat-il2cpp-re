// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs
// Classes: 27
// Methods: 199

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs
{
    public class AttributePkcs
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9771C20
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void get_AttrType(){} // RVA: 0x2F8380
        public void get_AttrValues(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9771F60
    }

    public class AuthenticatedSafe
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97722D0 | overloaded x2
        public void GetContentInfo(){} // RVA: 0x97723D0
        public void ToAsn1Object(){} // RVA: 0x9772450
    }

    public class CertBag
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void get_CertID(){} // RVA: 0x2F8380
        public void get_CertValue(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97726F0
    }

    public class CertificationRequest
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9772880
        public void .ctor(){} // RVA: 0x9772990 | overloaded x3
        public void GetCertificationRequestInfo(){} // RVA: 0x2F8380
        public void get_SignatureAlgorithm(){} // RVA: 0x2E07C0
        public void get_Signature(){} // RVA: 0x30B0C0
        public void GetSignatureOctets(){} // RVA: 0x6725860
        public void ToAsn1Object(){} // RVA: 0x9772CA0
    }

    public class CertificationRequestInfo
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9772E00
        public void .ctor(){} // RVA: 0x9773110 | overloaded x2
        public void get_Version(){} // RVA: 0x2F8380
        public void get_Subject(){} // RVA: 0x2E07C0
        public void get_SubjectPublicKeyInfo(){} // RVA: 0x30B0C0
        public void get_Attributes(){} // RVA: 0x30B130
        public void ToAsn1Object(){} // RVA: 0x9773540
        public void ValidateAttributes(){} // RVA: 0x9773780
    }

    public class ContentInfo
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9773BA0
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void get_ContentType(){} // RVA: 0x2F8380
        public void get_Content(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9773EB0
    }

    public class DHParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9774360 | overloaded x2
        public void get_P(){} // RVA: 0x972AF80
        public void get_G(){} // RVA: 0x972AFA0
        public void get_L(){} // RVA: 0x9774700
        public void ToAsn1Object(){} // RVA: 0x9774720
    }

    public class EncryptedData
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9774960
        public void .ctor(){} // RVA: 0x9774E10 | overloaded x2
        public void get_ContentType(){} // RVA: 0x9775050
        public void get_EncryptionAlgorithm(){} // RVA: 0x97750F0
        public void get_Content(){} // RVA: 0x9775130
        public void ToAsn1Object(){} // RVA: 0x97752B0
    }

    public class EncryptedPrivateKeyInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97755D0 | overloaded x2
        public void GetInstance(){} // RVA: 0x9775780
        public void get_EncryptionAlgorithm(){} // RVA: 0x2F8380
        public void GetEncryptedData(){} // RVA: 0x5CC1E70
        public void ToAsn1Object(){} // RVA: 0x9775960
    }

    public class EncryptionScheme
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9775A70 | overloaded x3
        public void GetInstance(){} // RVA: 0x9775B50
        public void get_Asn1Object(){} // RVA: 0x9775DE0
        public void ToAsn1Object(){} // RVA: 0x9775E20
    }

    public class IssuerAndSerialNumber
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9775F60
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x3
        public void get_Name(){} // RVA: 0x2F8380
        public void get_CertificateSerialNumber(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97764F0
    }

    public class KeyDerivationFunc
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x63A1980 | overloaded x2
    }

    public class MacData
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9776610
        public void .ctor(){} // RVA: 0x9776B20 | overloaded x2
        public void get_Mac(){} // RVA: 0x2F8380
        public void GetSalt(){} // RVA: 0x9776D10
        public void get_IterationCount(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x9776D90
    }

    public class PbeParameter
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97771D0
        public void .ctor(){} // RVA: 0x9777540 | overloaded x2
        public void GetSalt(){} // RVA: 0x5D12EF0
        public void get_IterationCount(){} // RVA: 0x9752620
        public void ToAsn1Object(){} // RVA: 0x9777740
    }

    public class PbeS2Parameters
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9777850
        public void .ctor(){} // RVA: 0x9777900 | overloaded x2
        public void get_KeyDerivationFunc(){} // RVA: 0x2F8380
        public void get_EncryptionScheme(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9777CF0
    }

    public class Pbkdf2Params
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9777E00
        public void .ctor(){} // RVA: 0x9778860 | overloaded x5
        public void GetSalt(){} // RVA: 0x5D12EF0
        public void get_IterationCount(){} // RVA: 0x9752620
        public void get_KeyLength(){} // RVA: 0x9725860
        public void get_IsDefaultPrf(){} // RVA: 0x97788D0
        public void get_Prf(){} // RVA: 0x9778960
        public void ToAsn1Object(){} // RVA: 0x97789D0
        public void .cctor(){} // RVA: 0x9778CA0
    }

    public class Pfx
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void get_AuthSafe(){} // RVA: 0x2F8380
        public void get_MacData(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9779230
    }

    public class Pkcs12PbeParams
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9779650 | overloaded x2
        public void GetInstance(){} // RVA: 0x97797F0
        public void get_Iterations(){} // RVA: 0x97799D0
        public void GetIV(){} // RVA: 0x5CC1E70
        public void ToAsn1Object(){} // RVA: 0x97799F0
    }

    public class PkcsObjectIdentifiers
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9779B00
    }

    public class PrivateKeyInfo
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x977D6F0 | overloaded x2
        public void GetVersionValue(){} // RVA: 0x977D7D0
        public void .ctor(){} // RVA: 0x977DD40 | overloaded x4
        public void get_Attributes(){} // RVA: 0x30B130
        public void get_HasPublicKey(){} // RVA: 0x51555E0
        public void get_PrivateKeyAlgorithm(){} // RVA: 0x2E07C0
        public void ParsePrivateKey(){} // RVA: 0x977E3F0
        public void ParsePublicKey(){} // RVA: 0x977E430
        public void get_PublicKeyData(){} // RVA: 0x6374D0
        public void ToAsn1Object(){} // RVA: 0x977E470
    }

    public class RC2CbcParameter
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x977E720
        public void .ctor(){} // RVA: 0x977EBD0 | overloaded x3
        public void get_RC2ParameterVersion(){} // RVA: 0x977EF50
        public void GetIV(){} // RVA: 0x977EF70
        public void ToAsn1Object(){} // RVA: 0x977F050
    }

    public class RsaPrivateKeyStructure
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97800E0 | overloaded x2
        public void .ctor(){} // RVA: 0x97801C0 | overloaded x2
        public void get_Modulus(){} // RVA: 0x2F8380
        public void get_PublicExponent(){} // RVA: 0x2E07C0
        public void get_PrivateExponent(){} // RVA: 0x30B0C0
        public void get_Prime1(){} // RVA: 0x30B130
        public void get_Prime2(){} // RVA: 0x6374D0
        public void get_Exponent1(){} // RVA: 0x4976A0
        public void get_Exponent2(){} // RVA: 0x35A740
        public void get_Coefficient(){} // RVA: 0x358730
        public void ToAsn1Object(){} // RVA: 0x97808F0
    }

    public class RsaesOaepParameters
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x977F200
        public void .ctor(){} // RVA: 0x977F550 | overloaded x3
        public void get_HashAlgorithm(){} // RVA: 0x2F8380
        public void get_MaskGenAlgorithm(){} // RVA: 0x2E07C0
        public void get_PSourceAlgorithm(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x977F880
        public void .cctor(){} // RVA: 0x977FCE0
    }

    public class RsassaPssParameters
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97811D0
        public void .ctor(){} // RVA: 0x9781570 | overloaded x3
        public void get_HashAlgorithm(){} // RVA: 0x2F8380
        public void get_MaskGenAlgorithm(){} // RVA: 0x2E07C0
        public void get_SaltLength(){} // RVA: 0x30B0C0
        public void get_TrailerField(){} // RVA: 0x30B130
        public void ToAsn1Object(){} // RVA: 0x97819C0
        public void .cctor(){} // RVA: 0x9781F20
    }

    public class SafeBag
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x97823A0 | overloaded x3
        public void get_BagID(){} // RVA: 0x2F8380
        public void get_BagValue(){} // RVA: 0x2E07C0
        public void get_BagAttributes(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x9782700
    }

    public class SignedData
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97829C0
        public void .ctor(){} // RVA: 0x9782A70 | overloaded x2
        public void get_Version(){} // RVA: 0x2F8380
        public void get_DigestAlgorithms(){} // RVA: 0x2E07C0
        public void get_ContentInfo(){} // RVA: 0x30B0C0
        public void get_Certificates(){} // RVA: 0x30B130
        public void get_Crls(){} // RVA: 0x6374D0
        public void get_SignerInfos(){} // RVA: 0x4976A0
        public void ToAsn1Object(){} // RVA: 0x9782FF0
    }

    public class SignerInfo
    {
        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9783270
        public void .ctor(){} // RVA: 0x9783450 | overloaded x2
        public void get_Version(){} // RVA: 0x2F8380
        public void get_IssuerAndSerialNumber(){} // RVA: 0x2E07C0
        public void get_AuthenticatedAttributes(){} // RVA: 0x30B130
        public void get_DigestAlgorithm(){} // RVA: 0x30B0C0
        public void get_EncryptedDigest(){} // RVA: 0x4976A0
        public void get_DigestEncryptionAlgorithm(){} // RVA: 0x6374D0
        public void get_UnauthenticatedAttributes(){} // RVA: 0x35A740
        public void ToAsn1Object(){} // RVA: 0x9783C70
    }

}