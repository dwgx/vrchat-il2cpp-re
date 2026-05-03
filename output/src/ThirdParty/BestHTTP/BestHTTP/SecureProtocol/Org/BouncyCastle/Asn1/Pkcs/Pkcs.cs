// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs
// Classes: 27
// Methods: 199

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs
{
    public class AttributePkcs : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier attrType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set attrValues; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1D4020
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void get_AttrType(){} // RVA: 0x7FFE81116380
        public void get_AttrValues(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1D4360
    }

    public class AuthenticatedSafe : Asn1Encodable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1D46D0 | overloaded x2
        public void GetContentInfo(){} // RVA: 0x7FFE8A1D47D0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1D4850
    }

    public class CertBag : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier certID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object certValue; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void get_CertID(){} // RVA: 0x7FFE81116380
        public void get_CertValue(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1D4AF0
    }

    public class CertificationRequest : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.CertificationRequestInfo reqInfo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgId; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1D4C80
        public void .ctor(){} // RVA: 0x7FFE8A1D4D90 | overloaded x3
        public void GetCertificationRequestInfo(){} // RVA: 0x7FFE81116380
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFE810FE7C0
        public void get_Signature(){} // RVA: 0x7FFE811290C0
        public void GetSignatureOctets(){} // RVA: 0x7FFE87264760
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1D50A0
    }

    public class CertificationRequestInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name subject; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo subjectPKInfo; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set attributes; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1D5200
        public void .ctor(){} // RVA: 0x7FFE8A1D5510 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFE81116380
        public void get_Subject(){} // RVA: 0x7FFE810FE7C0
        public void get_SubjectPublicKeyInfo(){} // RVA: 0x7FFE811290C0
        public void get_Attributes(){} // RVA: 0x7FFE81129130
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1D5940
        public void ValidateAttributes(){} // RVA: 0x7FFE8A1D5B80
    }

    public class ContentInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier contentType; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Encodable content; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1D5FA0
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void get_ContentType(){} // RVA: 0x7FFE81116380
        public void get_Content(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1D62B0
    }

    public class DHParameter : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger p; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger g; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger l; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1D6760 | overloaded x2
        public void get_P(){} // RVA: 0x7FFE8A18D380
        public void get_G(){} // RVA: 0x7FFE8A18D3A0
        public void get_L(){} // RVA: 0x7FFE8A1D6B00
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1D6B20
    }

    public class EncryptedData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence data; // 0x10
        public object field_1; // 0x781
        public object field_2; // 0x782

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1D6D60
        public void .ctor(){} // RVA: 0x7FFE8A1D7210 | overloaded x2
        public void get_ContentType(){} // RVA: 0x7FFE8A1D7450
        public void get_EncryptionAlgorithm(){} // RVA: 0x7FFE8A1D74F0
        public void get_Content(){} // RVA: 0x7FFE8A1D7530
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1D76B0
    }

    public class EncryptedPrivateKeyInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1D79D0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A1D7B80
        public void get_EncryptionAlgorithm(){} // RVA: 0x7FFE81116380
        public void GetEncryptedData(){} // RVA: 0x7FFE86802D70
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1D7D60
    }

    public class EncryptionScheme : AlgorithmIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1D7E70 | overloaded x3
        public void GetInstance(){} // RVA: 0x7FFE8A1D7F50
        public void get_Asn1Object(){} // RVA: 0x7FFE8A1D81E0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1D8220
    }

    public class IssuerAndSerialNumber : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Name name; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger certSerialNumber; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1D8360
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x3
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void get_CertificateSerialNumber(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1D88F0
    }

    public class KeyDerivationFunc : AlgorithmIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EE23A0 | overloaded x2
    }

    public class MacData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.DigestInfo digInfo; // 0x10
        public byte[] salt; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1D8A10
        public void .ctor(){} // RVA: 0x7FFE8A1D8F20 | overloaded x2
        public void get_Mac(){} // RVA: 0x7FFE81116380
        public void GetSalt(){} // RVA: 0x7FFE8A1D9110
        public void get_IterationCount(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1D9190
    }

    public class PbeParameter : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString salt; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1D95D0
        public void .ctor(){} // RVA: 0x7FFE8A1D9940 | overloaded x2
        public void GetSalt(){} // RVA: 0x7FFE86853DF0
        public void get_IterationCount(){} // RVA: 0x7FFE8A1B4A20
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1D9B40
    }

    public class PbeS2Parameters : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.KeyDerivationFunc func; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.EncryptionScheme scheme; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1D9C50
        public void .ctor(){} // RVA: 0x7FFE8A1D9D00 | overloaded x2
        public void get_KeyDerivationFunc(){} // RVA: 0x7FFE81116380
        public void get_EncryptionScheme(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1DA0F0
    }

    public class Pbkdf2Params : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algid_hmacWithSHA1;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString octStr; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger iterationCount; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger keyLength; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1DA200
        public void .ctor(){} // RVA: 0x7FFE8A1DAC60 | overloaded x5
        public void GetSalt(){} // RVA: 0x7FFE86853DF0
        public void get_IterationCount(){} // RVA: 0x7FFE8A1B4A20
        public void get_KeyLength(){} // RVA: 0x7FFE8A187C60
        public void get_IsDefaultPrf(){} // RVA: 0x7FFE8A1DACD0
        public void get_Prf(){} // RVA: 0x7FFE8A1DAD60
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1DADD0
        public void .cctor(){} // RVA: 0x7FFE8A1DB0A0
    }

    public class Pfx : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.ContentInfo contentInfo; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.MacData macData; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void get_AuthSafe(){} // RVA: 0x7FFE81116380
        public void get_MacData(){} // RVA: 0x7FFE810FE7C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1DB630
    }

    public class Pkcs12PbeParams : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger iterations; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1DBA50 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE8A1DBBF0
        public void get_Iterations(){} // RVA: 0x7FFE8A1DBDD0
        public void GetIV(){} // RVA: 0x7FFE86802D70
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1DBDF0
    }

    public class PkcsObjectIdentifiers : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A1DBF00
    }

    public class PrivateKeyInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier privateKeyAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString privateKey; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set attributes; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1DFAF0 | overloaded x2
        public void GetVersionValue(){} // RVA: 0x7FFE8A1DFBD0
        public void .ctor(){} // RVA: 0x7FFE8A1E0140 | overloaded x4
        public void get_Attributes(){} // RVA: 0x7FFE81129130
        public void get_HasPublicKey(){} // RVA: 0x7FFE85C00B10
        public void get_PrivateKeyAlgorithm(){} // RVA: 0x7FFE810FE7C0
        public void ParsePrivateKey(){} // RVA: 0x7FFE8A1E07F0
        public void ParsePublicKey(){} // RVA: 0x7FFE8A1E0830
        public void get_PublicKeyData(){} // RVA: 0x7FFE8144E200
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1E0870
    }

    public class RC2CbcParameter : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1E0B20
        public void .ctor(){} // RVA: 0x7FFE8A1E0FD0 | overloaded x3
        public void get_RC2ParameterVersion(){} // RVA: 0x7FFE8A1E1350
        public void GetIV(){} // RVA: 0x7FFE8A1E1370
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1E1450
    }

    public class RsaPrivateKeyStructure : Asn1Encodable
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
        public void GetInstance(){} // RVA: 0x7FFE8A1E24E0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A1E25C0 | overloaded x2
        public void get_Modulus(){} // RVA: 0x7FFE81116380
        public void get_PublicExponent(){} // RVA: 0x7FFE810FE7C0
        public void get_PrivateExponent(){} // RVA: 0x7FFE811290C0
        public void get_Prime1(){} // RVA: 0x7FFE81129130
        public void get_Prime2(){} // RVA: 0x7FFE8144E200
        public void get_Exponent1(){} // RVA: 0x7FFE8143BA80
        public void get_Exponent2(){} // RVA: 0x7FFE81178740
        public void get_Coefficient(){} // RVA: 0x7FFE81176730
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1E2CF0
    }

    public class RsaesOaepParameters : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier maskGenAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier pSourceAlgorithm; // 0x20

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1E1600
        public void .ctor(){} // RVA: 0x7FFE8A1E1950 | overloaded x3
        public void get_HashAlgorithm(){} // RVA: 0x7FFE81116380
        public void get_MaskGenAlgorithm(){} // RVA: 0x7FFE810FE7C0
        public void get_PSourceAlgorithm(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1E1C80
        public void .cctor(){} // RVA: 0x7FFE8A1E20E0
    }

    public class RsassaPssParameters : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier maskGenAlgorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger saltLength; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger trailerField; // 0x28

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1E35D0
        public void .ctor(){} // RVA: 0x7FFE8A1E3970 | overloaded x3
        public void get_HashAlgorithm(){} // RVA: 0x7FFE81116380
        public void get_MaskGenAlgorithm(){} // RVA: 0x7FFE810FE7C0
        public void get_SaltLength(){} // RVA: 0x7FFE811290C0
        public void get_TrailerField(){} // RVA: 0x7FFE81129130
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1E3DC0
        public void .cctor(){} // RVA: 0x7FFE8A1E4320
    }

    public class SafeBag : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier bagID; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Object bagValue; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set bagAttributes; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1E47A0 | overloaded x3
        public void get_BagID(){} // RVA: 0x7FFE81116380
        public void get_BagValue(){} // RVA: 0x7FFE810FE7C0
        public void get_BagAttributes(){} // RVA: 0x7FFE811290C0
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1E4B00
    }

    public class SignedData : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set digestAlgorithms; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.ContentInfo contentInfo; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set certificates; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set crls; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set signerInfos; // 0x38

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1E4DC0
        public void .ctor(){} // RVA: 0x7FFE8A1E4E70 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFE81116380
        public void get_DigestAlgorithms(){} // RVA: 0x7FFE810FE7C0
        public void get_ContentInfo(){} // RVA: 0x7FFE811290C0
        public void get_Certificates(){} // RVA: 0x7FFE81129130
        public void get_Crls(){} // RVA: 0x7FFE8144E200
        public void get_SignerInfos(){} // RVA: 0x7FFE8143BA80
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1E53F0
    }

    public class SignerInfo : Asn1Encodable
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerInteger version; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Pkcs.IssuerAndSerialNumber issuerAndSerialNumber; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digAlgorithm; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set authenticatedAttributes; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digEncryptionAlgorithm; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1OctetString encryptedDigest; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set unauthenticatedAttributes; // 0x40

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE8A1E5670
        public void .ctor(){} // RVA: 0x7FFE8A1E5850 | overloaded x2
        public void get_Version(){} // RVA: 0x7FFE81116380
        public void get_IssuerAndSerialNumber(){} // RVA: 0x7FFE810FE7C0
        public void get_AuthenticatedAttributes(){} // RVA: 0x7FFE81129130
        public void get_DigestAlgorithm(){} // RVA: 0x7FFE811290C0
        public void get_EncryptedDigest(){} // RVA: 0x7FFE8143BA80
        public void get_DigestEncryptionAlgorithm(){} // RVA: 0x7FFE8144E200
        public void get_UnauthenticatedAttributes(){} // RVA: 0x7FFE81178740
        public void ToAsn1Object(){} // RVA: 0x7FFE8A1E6070
    }

}