// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs
// Classes: 27
// Methods: 199

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs
{
    public class AttributePkcs
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier attrType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set attrValues; // 0x18

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
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier certID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object certValue; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void get_CertID(){} // RVA: 0x2F8380
        public void get_CertValue(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x97726F0
    }

    public class CertificationRequest
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.CertificationRequestInfo reqInfo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgId; // 0x18

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
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name subject; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo subjectPKInfo; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set attributes; // 0x28

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
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier contentType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable content; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9773BA0
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void get_ContentType(){} // RVA: 0x2F8380
        public void get_Content(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9773EB0
    }

    public class DHParameter
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger p; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger g; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger l; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9774360 | overloaded x2
        public void get_P(){} // RVA: 0x972AF80
        public void get_G(){} // RVA: 0x972AFA0
        public void get_L(){} // RVA: 0x9774700
        public void ToAsn1Object(){} // RVA: 0x9774720
    }

    public class EncryptedData
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence data; // 0x10

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
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId; // 0x10

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
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name name; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger certSerialNumber; // 0x18

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
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.DigestInfo digInfo; // 0x10
        public byte[] salt; // 0x18

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
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString salt; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x97771D0
        public void .ctor(){} // RVA: 0x9777540 | overloaded x2
        public void GetSalt(){} // RVA: 0x5D12EF0
        public void get_IterationCount(){} // RVA: 0x9752620
        public void ToAsn1Object(){} // RVA: 0x9777740
    }

    public class PbeS2Parameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.KeyDerivationFunc func; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.EncryptionScheme scheme; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x9777850
        public void .ctor(){} // RVA: 0x9777900 | overloaded x2
        public void get_KeyDerivationFunc(){} // RVA: 0x2F8380
        public void get_EncryptionScheme(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9777CF0
    }

    public class Pbkdf2Params
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algid_hmacWithSHA1;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString octStr; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger iterationCount; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger keyLength; // 0x20

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
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.ContentInfo contentInfo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.MacData macData; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void get_AuthSafe(){} // RVA: 0x2F8380
        public void get_MacData(){} // RVA: 0x2E07C0
        public void ToAsn1Object(){} // RVA: 0x9779230
    }

    public class Pkcs12PbeParams
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger iterations; // 0x10

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
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier privateKeyAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString privateKey; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set attributes; // 0x28

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
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x977E720
        public void .ctor(){} // RVA: 0x977EBD0 | overloaded x3
        public void get_RC2ParameterVersion(){} // RVA: 0x977EF50
        public void GetIV(){} // RVA: 0x977EF70
        public void ToAsn1Object(){} // RVA: 0x977F050
    }

    public class RsaPrivateKeyStructure
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger modulus; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger publicExponent; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger privateExponent; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger prime1; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger prime2; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger exponent1; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger exponent2; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger coefficient; // 0x48

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
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier maskGenAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier pSourceAlgorithm; // 0x20

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
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier maskGenAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger saltLength; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger trailerField; // 0x28

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
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier bagID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object bagValue; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set bagAttributes; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x97823A0 | overloaded x3
        public void get_BagID(){} // RVA: 0x2F8380
        public void get_BagValue(){} // RVA: 0x2E07C0
        public void get_BagAttributes(){} // RVA: 0x30B0C0
        public void ToAsn1Object(){} // RVA: 0x9782700
    }

    public class SignedData
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set digestAlgorithms; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.ContentInfo contentInfo; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set certificates; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set crls; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set signerInfos; // 0x38

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
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.IssuerAndSerialNumber issuerAndSerialNumber; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digAlgorithm; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set authenticatedAttributes; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digEncryptionAlgorithm; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString encryptedDigest; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set unauthenticatedAttributes; // 0x40

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