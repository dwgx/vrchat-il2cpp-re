// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs
// Classes: 27
// Methods: 199

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs
{
    public class AttributePkcs : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier AttrType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set AttrValues; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD7AA00
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void get_AttrType(){} // RVA: 0x7FFAC2F3C380
        public void get_AttrValues(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD7AD40
    }

    public class AuthenticatedSafe : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.ContentInfo[] info; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD7B0B0 | overloaded x2
        public void GetContentInfo(){} // RVA: 0x7FFACBD7B1B0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD7B230
    }

    public class CertBag : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CertID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object CertValue; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void get_CertID(){} // RVA: 0x7FFAC2F3C380
        public void get_CertValue(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD7B4D0
    }

    public class CertificationRequest : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.CertificationRequestInfo SignatureAlgorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Signature; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString sigBits; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD7B660
        public void .ctor(){} // RVA: 0x7FFACBD7B770 | overloaded x3
        public void GetCertificationRequestInfo(){} // RVA: 0x7FFAC2F3C380
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAC2F247C0
        public void get_Signature(){} // RVA: 0x7FFAC2F4F0C0
        public void GetSignatureOctets(){} // RVA: 0x7FFAC8EBC310
        public void ToAsn1Object(){} // RVA: 0x7FFACBD7BA80
    }

    public class CertificationRequestInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name Subject; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo SubjectPublicKeyInfo; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set Attributes; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD7BBE0
        public void .ctor(){} // RVA: 0x7FFACBD7BEF0 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
        public void get_Subject(){} // RVA: 0x7FFAC2F247C0
        public void get_SubjectPublicKeyInfo(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Attributes(){} // RVA: 0x7FFAC2F4F130
        public void ToAsn1Object(){} // RVA: 0x7FFACBD7C320
        public void ValidateAttributes(){} // RVA: 0x7FFACBD7C560
    }

    public class ContentInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier ContentType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable Content; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD7C980
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void get_ContentType(){} // RVA: 0x7FFAC2F3C380
        public void get_Content(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD7CC90
    }

    public class DHParameter : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger P; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger G; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger L; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD7D140 | overloaded x2
        public void get_P(){} // RVA: 0x7FFACBD33D60
        public void get_G(){} // RVA: 0x7FFACBD33D80
        public void get_L(){} // RVA: 0x7FFACBD7D4E0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD7D500
    }

    public class EncryptedData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence ContentType; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD7D740
        public void .ctor(){} // RVA: 0x7FFACBD7DBF0 | overloaded x2
        public void get_ContentType(){} // RVA: 0x7FFACBD7DE30
        public void get_EncryptionAlgorithm(){} // RVA: 0x7FFACBD7DED0
        public void get_Content(){} // RVA: 0x7FFACBD7DF10
        public void ToAsn1Object(){} // RVA: 0x7FFACBD7E090
    }

    public class EncryptedPrivateKeyInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier EncryptionAlgorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString data; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD7E3B0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBD7E560
        public void get_EncryptionAlgorithm(){} // RVA: 0x7FFAC2F3C380
        public void GetEncryptedData(){} // RVA: 0x7FFAC8459460
        public void ToAsn1Object(){} // RVA: 0x7FFACBD7E740
    }

    public class EncryptionScheme : AlgorithmIdentifier
    {
        public object Asn1Object;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD7E850 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFACBD7E930
        public void get_Asn1Object(){} // RVA: 0x7FFACBD7EBC0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD7EC00
    }

    public class IssuerAndSerialNumber : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name Name; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger CertificateSerialNumber; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD7ED40
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x3
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void get_CertificateSerialNumber(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD7F2D0
    }

    public class KeyDerivationFunc : AlgorithmIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B38D30 | overloaded x2
    }

    public class MacData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.DigestInfo Mac; // 0x10
        public byte[] IterationCount; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger iterationCount; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD7F3F0
        public void .ctor(){} // RVA: 0x7FFACBD7F900 | overloaded x2
        public void get_Mac(){} // RVA: 0x7FFAC2F3C380
        public void GetSalt(){} // RVA: 0x7FFACBD7FAF0
        public void get_IterationCount(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD7FB70
    }

    public class PbeParameter : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString IterationCount; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger iterationCount; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD7FFB0
        public void .ctor(){} // RVA: 0x7FFACBD80320 | overloaded x2
        public void GetSalt(){} // RVA: 0x7FFAC84AA530
        public void get_IterationCount(){} // RVA: 0x7FFACBD5B400
        public void ToAsn1Object(){} // RVA: 0x7FFACBD80520
    }

    public class PbeS2Parameters : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.KeyDerivationFunc KeyDerivationFunc; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.EncryptionScheme EncryptionScheme; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD80630
        public void .ctor(){} // RVA: 0x7FFACBD806E0 | overloaded x2
        public void get_KeyDerivationFunc(){} // RVA: 0x7FFAC2F3C380
        public void get_EncryptionScheme(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD80AD0
    }

    public class Pbkdf2Params : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier IterationCount;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString KeyLength; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger IsDefaultPrf; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Prf; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier prf; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD80BE0
        public void .ctor(){} // RVA: 0x7FFACBD81640 | overloaded x5
        public void GetSalt(){} // RVA: 0x7FFAC84AA530
        public void get_IterationCount(){} // RVA: 0x7FFACBD5B400
        public void get_KeyLength(){} // RVA: 0x7FFACBD2E640
        public void get_IsDefaultPrf(){} // RVA: 0x7FFACBD816B0
        public void get_Prf(){} // RVA: 0x7FFACBD81740
        public void ToAsn1Object(){} // RVA: 0x7FFACBD817B0
        public void .cctor(){} // RVA: 0x7FFACBD81A80
    }

    public class Pfx : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.ContentInfo AuthSafe; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.MacData MacData; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void get_AuthSafe(){} // RVA: 0x7FFAC2F3C380
        public void get_MacData(){} // RVA: 0x7FFAC2F247C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD82010
    }

    public class Pkcs12PbeParams : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Iterations; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString iv; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD82430 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFACBD825D0
        public void get_Iterations(){} // RVA: 0x7FFACBD827B0
        public void GetIV(){} // RVA: 0x7FFAC8459460
        public void ToAsn1Object(){} // RVA: 0x7FFACBD827D0
    }

    public class PkcsObjectIdentifiers : Object
    {
        public string Pkcs1;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs1Oid;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier RsaEncryption; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier MD2WithRsaEncryption; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier MD4WithRsaEncryption; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier MD5WithRsaEncryption; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Sha1WithRsaEncryption; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SrsaOaepEncryptionSet; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdRsaesOaep; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdMgf1; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdPSpecified; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdRsassaPss; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Sha256WithRsaEncryption; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Sha384WithRsaEncryption; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Sha512WithRsaEncryption; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Sha224WithRsaEncryption; // 0x70
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Sha512_224WithRSAEncryption; // 0x78
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Sha512_256WithRSAEncryption; // 0x80
        public string Pkcs3;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DhKeyAgreement; // 0x88
        public string Pkcs5;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithMD2AndDesCbc; // 0x90
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithMD2AndRC2Cbc; // 0x98
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithMD5AndDesCbc; // 0xA0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithMD5AndRC2Cbc; // 0xA8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithSha1AndDesCbc; // 0xB0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithSha1AndRC2Cbc; // 0xB8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdPbeS2; // 0xC0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdPbkdf2; // 0xC8
        public string EncryptionAlgorithm;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DesEde3Cbc; // 0xD0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier RC2Cbc; // 0xD8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier rc4; // 0xE0
        public string DigestAlgorithm;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier MD2; // 0xE8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier MD4; // 0xF0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier MD5; // 0xF8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdHmacWithSha1; // 0x100
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdHmacWithSha224; // 0x108
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdHmacWithSha256; // 0x110
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdHmacWithSha384; // 0x118
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdHmacWithSha512; // 0x120
        public string Pkcs7;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Data; // 0x128
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SignedData; // 0x130
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier EnvelopedData; // 0x138
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SignedAndEnvelopedData; // 0x140
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DigestedData; // 0x148
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier EncryptedData; // 0x150
        public string Pkcs9;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtEmailAddress; // 0x158
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtUnstructuredName; // 0x160
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtContentType; // 0x168
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtMessageDigest; // 0x170
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtSigningTime; // 0x178
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtCounterSignature; // 0x180
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtChallengePassword; // 0x188
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtUnstructuredAddress; // 0x190
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtExtendedCertificateAttributes; // 0x198
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtSigningDescription; // 0x1A0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtExtensionRequest; // 0x1A8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtSmimeCapabilities; // 0x1B0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdSmime; // 0x1B8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtFriendlyName; // 0x1C0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs9AtLocalKeyID; // 0x1C8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier X509CertType; // 0x1D0
        public string CertTypes;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier X509Certificate; // 0x1D8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SdsiCertificate; // 0x1E0
        public string CrlTypes;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier X509Crl; // 0x1E8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAlg; // 0x1F0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAlgEsdh; // 0x1F8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAlgCms3DesWrap; // 0x200
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAlgCmsRC2Wrap; // 0x208
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAlgPwriKek; // 0x210
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAlgSsdh; // 0x218
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdRsaKem; // 0x220
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PreferSignedData; // 0x228
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CannotDecryptAny; // 0x230
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SmimeCapabilitiesVersions; // 0x238
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAReceiptRequest; // 0x240
        public string IdCT;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdCTAuthData; // 0x248
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdCTTstInfo; // 0x250
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdCTCompressedData; // 0x258
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdCTAuthEnvelopedData; // 0x260
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdCTTimestampedData; // 0x268
        public string IdCti;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdCtiEtsProofOfOrigin; // 0x270
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdCtiEtsProofOfReceipt; // 0x278
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdCtiEtsProofOfDelivery; // 0x280
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdCtiEtsProofOfSender; // 0x288
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdCtiEtsProofOfApproval; // 0x290
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdCtiEtsProofOfCreation; // 0x298
        public string IdAA;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAOid; // 0x2A0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAContentHint; // 0x2A8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAMsgSigDigest; // 0x2B0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAContentReference; // 0x2B8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEncrypKeyPref; // 0x2C0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAASigningCertificate; // 0x2C8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAASigningCertificateV2; // 0x2D0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAContentIdentifier; // 0x2D8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAASignatureTimeStampToken; // 0x2E0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsSigPolicyID; // 0x2E8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsCommitmentType; // 0x2F0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsSignerLocation; // 0x2F8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsSignerAttr; // 0x300
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsOtherSigCert; // 0x308
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsContentTimestamp; // 0x310
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsCertificateRefs; // 0x318
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsRevocationRefs; // 0x320
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsCertValues; // 0x328
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsRevocationValues; // 0x330
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsEscTimeStamp; // 0x338
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsCertCrlTimestamp; // 0x340
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAEtsArchiveTimestamp; // 0x348
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAADecryptKeyID; // 0x350
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAImplCryptoAlgs; // 0x358
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAAsymmDecryptKeyID; // 0x360
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAImplCompressAlgs; // 0x368
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAACommunityIdentifiers; // 0x370
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAASigPolicyID; // 0x378
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAACommitmentType; // 0x380
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAASignerLocation; // 0x388
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdAAOtherSigCert; // 0x390
        public string IdSpq;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdSpqEtsUri; // 0x398
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier IdSpqEtsUNotice; // 0x3A0
        public string Pkcs12;
        public string BagTypes;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier KeyBag; // 0x3A8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Pkcs8ShroudedKeyBag; // 0x3B0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CertBag; // 0x3B8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier CrlBag; // 0x3C0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SecretBag; // 0x3C8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier SafeContentsBag; // 0x3D0
        public string Pkcs12PbeIds;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithShaAnd128BitRC4; // 0x3D8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithShaAnd40BitRC4; // 0x3E0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithShaAnd3KeyTripleDesCbc; // 0x3E8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithShaAnd2KeyTripleDesCbc; // 0x3F0
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PbeWithShaAnd128BitRC2Cbc; // 0x3F8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PbewithShaAnd40BitRC2Cbc; // 0x400

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBD828E0
    }

    public class PrivateKeyInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Attributes; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HasPublicKey; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString PrivateKeyAlgorithm; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set PublicKeyData; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerBitString publicKey; // 0x30

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD864D0 | overloaded x2
        public void GetVersionValue(){} // RVA: 0x7FFACBD865B0
        public void .ctor(){} // RVA: 0x7FFACBD86B20 | overloaded x4
        public void get_Attributes(){} // RVA: 0x7FFAC2F4F130
        public void get_HasPublicKey(){} // RVA: 0x7FFAC781E0A0
        public void get_PrivateKeyAlgorithm(){} // RVA: 0x7FFAC2F247C0
        public void ParsePrivateKey(){} // RVA: 0x7FFACBD871D0
        public void ParsePublicKey(){} // RVA: 0x7FFACBD87210
        public void get_PublicKeyData(){} // RVA: 0x7FFAC31D95E0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD87250
    }

    public class RC2CbcParameter : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger RC2ParameterVersion; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString iv; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD87500
        public void .ctor(){} // RVA: 0x7FFACBD879B0 | overloaded x3
        public void get_RC2ParameterVersion(){} // RVA: 0x7FFACBD87D30
        public void GetIV(){} // RVA: 0x7FFACBD87D50
        public void ToAsn1Object(){} // RVA: 0x7FFACBD87E30
    }

    public class RsaPrivateKeyStructure : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Modulus; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger PublicExponent; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger PrivateExponent; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Prime1; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Prime2; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Exponent1; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Exponent2; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Coefficient; // 0x48

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD88EC0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBD88FA0 | overloaded x2
        public void get_Modulus(){} // RVA: 0x7FFAC2F3C380
        public void get_PublicExponent(){} // RVA: 0x7FFAC2F247C0
        public void get_PrivateExponent(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Prime1(){} // RVA: 0x7FFAC2F4F130
        public void get_Prime2(){} // RVA: 0x7FFAC31D95E0
        public void get_Exponent1(){} // RVA: 0x7FFAC31D0140
        public void get_Exponent2(){} // RVA: 0x7FFAC2F9E740
        public void get_Coefficient(){} // RVA: 0x7FFAC2F9C730
        public void ToAsn1Object(){} // RVA: 0x7FFACBD896D0
    }

    public class RsaesOaepParameters : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HashAlgorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier MaskGenAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier PSourceAlgorithm; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DefaultHashAlgorithm;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DefaultMaskGenFunction; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DefaultPSourceAlgorithm; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD87FE0
        public void .ctor(){} // RVA: 0x7FFACBD88330 | overloaded x3
        public void get_HashAlgorithm(){} // RVA: 0x7FFAC2F3C380
        public void get_MaskGenAlgorithm(){} // RVA: 0x7FFAC2F247C0
        public void get_PSourceAlgorithm(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD88660
        public void .cctor(){} // RVA: 0x7FFACBD88AC0
    }

    public class RsassaPssParameters : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HashAlgorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier MaskGenAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger SaltLength; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger TrailerField; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DefaultHashAlgorithm;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DefaultMaskGenFunction; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger DefaultSaltLength; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger DefaultTrailerField; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD89FB0
        public void .ctor(){} // RVA: 0x7FFACBD8A350 | overloaded x3
        public void get_HashAlgorithm(){} // RVA: 0x7FFAC2F3C380
        public void get_MaskGenAlgorithm(){} // RVA: 0x7FFAC2F247C0
        public void get_SaltLength(){} // RVA: 0x7FFAC2F4F0C0
        public void get_TrailerField(){} // RVA: 0x7FFAC2F4F130
        public void ToAsn1Object(){} // RVA: 0x7FFACBD8A7A0
        public void .cctor(){} // RVA: 0x7FFACBD8AD00
    }

    public class SafeBag : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier BagID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object BagValue; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set BagAttributes; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD8B180 | overloaded x3
        public void get_BagID(){} // RVA: 0x7FFAC2F3C380
        public void get_BagValue(){} // RVA: 0x7FFAC2F247C0
        public void get_BagAttributes(){} // RVA: 0x7FFAC2F4F0C0
        public void ToAsn1Object(){} // RVA: 0x7FFACBD8B4E0
    }

    public class SignedData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set DigestAlgorithms; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.ContentInfo ContentInfo; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set Certificates; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set Crls; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set SignerInfos; // 0x38

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD8B7A0
        public void .ctor(){} // RVA: 0x7FFACBD8B850 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
        public void get_DigestAlgorithms(){} // RVA: 0x7FFAC2F247C0
        public void get_ContentInfo(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Certificates(){} // RVA: 0x7FFAC2F4F130
        public void get_Crls(){} // RVA: 0x7FFAC31D95E0
        public void get_SignerInfos(){} // RVA: 0x7FFAC31D0140
        public void ToAsn1Object(){} // RVA: 0x7FFACBD8BDD0
    }

    public class SignerInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger Version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.IssuerAndSerialNumber IssuerAndSerialNumber; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier AuthenticatedAttributes; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set DigestAlgorithm; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier EncryptedDigest; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString DigestEncryptionAlgorithm; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set UnauthenticatedAttributes; // 0x40

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBD8C050
        public void .ctor(){} // RVA: 0x7FFACBD8C230 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
        public void get_IssuerAndSerialNumber(){} // RVA: 0x7FFAC2F247C0
        public void get_AuthenticatedAttributes(){} // RVA: 0x7FFAC2F4F130
        public void get_DigestAlgorithm(){} // RVA: 0x7FFAC2F4F0C0
        public void get_EncryptedDigest(){} // RVA: 0x7FFAC31D0140
        public void get_DigestEncryptionAlgorithm(){} // RVA: 0x7FFAC31D95E0
        public void get_UnauthenticatedAttributes(){} // RVA: 0x7FFAC2F9E740
        public void ToAsn1Object(){} // RVA: 0x7FFACBD8CA50
    }

}