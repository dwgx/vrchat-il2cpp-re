// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Security
// Classes: 22
// Methods: 200

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Security
{
    public class AgreementUtilities : Object
    {
        public System.Collections.IDictionary algorithms;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBF4F8C0
        public void GetBasicAgreement(){} // RVA: 0x7FFACBF4FC90 | overloaded x2
        public void GetBasicAgreementWithKdf(){} // RVA: 0x7FFACBF50040 | overloaded x2
        public void GetRawAgreement(){} // RVA: 0x7FFACBF505F0 | overloaded x2
        public void GetAlgorithmName(){} // RVA: 0x7FFACBF50790
        public void GetMechanism(){} // RVA: 0x7FFACBF50860
    }

    public class CipherUtilities : Object
    {
        public System.Collections.IDictionary Algorithms;
        public System.Collections.IDictionary oids; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBF50950
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void GetObjectIdentifier(){} // RVA: 0x7FFACBF527A0
        public void get_Algorithms(){} // RVA: 0x7FFACBF529A0
        public void GetCipher(){} // RVA: 0x7FFACBF52A80 | overloaded x2
        public void GetAlgorithmName(){} // RVA: 0x7FFACBF54F20
        public void GetDigitIndex(){} // RVA: 0x7FFACBF54FF0
        public void CreateBlockCipher(){} // RVA: 0x7FFACBF550B0
    }

    public class DigestUtilities : Object
    {
        public System.Collections.IDictionary Algorithms;
        public System.Collections.IDictionary oids; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBF556A0
        public void GetObjectIdentifier(){} // RVA: 0x7FFACBF57820
        public void get_Algorithms(){} // RVA: 0x7FFACBF57A20
        public void GetDigest(){} // RVA: 0x7FFACBF57B00 | overloaded x2
        public void GetAlgorithmName(){} // RVA: 0x7FFACBF58A40
        public void CalculateDigest(){} // RVA: 0x7FFACBF58B80 | overloaded x2
        public void DoFinal(){} // RVA: 0x7FFACBF58D50 | overloaded x2
    }

    public class DotNetUtilities : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void ToX509Certificate(){} // RVA: 0x7FFACBF58EF0 | overloaded x2
        public void FromX509Certificate(){} // RVA: 0x7FFACBF58F70
        public void GetDsaKeyPair(){} // RVA: 0x7FFACBF59060 | overloaded x2
        public void GetDsaPublicKey(){} // RVA: 0x7FFACBF594A0 | overloaded x2
        public void GetRsaKeyPair(){} // RVA: 0x7FFACBF59840 | overloaded x2
        public void GetRsaPublicKey(){} // RVA: 0x7FFACBF59CC0 | overloaded x2
        public void GetKeyPair(){} // RVA: 0x7FFACBF59DD0
        public void ToRSA(){} // RVA: 0x7FFACBF5A580 | overloaded x6
        public void ToRSAParameters(){} // RVA: 0x7FFACBF5AD10 | overloaded x3
        public void ConvertRSAParametersField(){} // RVA: 0x7FFACBF5B0C0
        public void CreateRSAProvider(){} // RVA: 0x7FFACBF5B540 | overloaded x2
    }

    public class EncryptionException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85BCB20 | overloaded x2
    }

    public class GeneralSecurityException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF5B750 | overloaded x3
    }

    public class GeneratorUtilities : Object
    {
        public System.Collections.IDictionary kgAlgorithms;
        public System.Collections.IDictionary kpgAlgorithms; // 0x8
        public System.Collections.IDictionary defaultKeySizes; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBF5B7C0
        public void AddDefaultKeySizeEntries(){} // RVA: 0x7FFACBF5EEC0
        public void AddKgAlgorithm(){} // RVA: 0x7FFACBF5F050
        public void AddKpgAlgorithm(){} // RVA: 0x7FFACBF5F270
        public void AddHMacKeyGenerator(){} // RVA: 0x7FFACBF5F4A0
        public void GetCanonicalKeyGeneratorAlgorithm(){} // RVA: 0x7FFACBF5F780
        public void GetCanonicalKeyPairGeneratorAlgorithm(){} // RVA: 0x7FFACBF5F880
        public void GetKeyGenerator(){} // RVA: 0x7FFACBF5F9E0 | overloaded x2
        public void GetKeyPairGenerator(){} // RVA: 0x7FFACBF5FD90 | overloaded x2
        public void GetDefaultKeySize(){} // RVA: 0x7FFACBF604E0 | overloaded x2
        public void FindDefaultKeySize(){} // RVA: 0x7FFACBF606E0
    }

    public class InvalidKeyException : KeyException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD028E0 | overloaded x3
    }

    public class InvalidParameterException : KeyException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD028E0 | overloaded x3
    }

    public class KeyException : GeneralSecurityException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD028E0 | overloaded x3
    }

    public class MacUtilities : Object
    {
        public System.Collections.IDictionary algorithms;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBF60800
        public void GetMac(){} // RVA: 0x7FFACBF61A00 | overloaded x2
        public void GetAlgorithmName(){} // RVA: 0x7FFACBF62B10
        public void CalculateMac(){} // RVA: 0x7FFACBF62BE0
        public void DoFinal(){} // RVA: 0x7FFACBF62DC0 | overloaded x2
    }

    public class NoSuchAlgorithmException : GeneralSecurityException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD028E0 | overloaded x3
    }

    public class ParameterUtilities : Object
    {
        public System.Collections.IDictionary algorithms;
        public System.Collections.IDictionary basicIVSizes; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBF62EE0
        public void AddAlgorithm(){} // RVA: 0x7FFACBF64B20
        public void AddBasicIVSizeEntries(){} // RVA: 0x7FFACBF64CF0
        public void GetCanonicalAlgorithmName(){} // RVA: 0x7FFACBF64E80
        public void CreateKeyParameter(){} // RVA: 0x7FFACBF65120 | overloaded x4
        public void GetCipherParameters(){} // RVA: 0x7FFACBF65600 | overloaded x2
        public void GenerateParameters(){} // RVA: 0x7FFACBF65BD0 | overloaded x2
        public void WithRandom(){} // RVA: 0x7FFACBF66430
        public void CreateIVOctetString(){} // RVA: 0x7FFACBF664B0
        public void CreateIV(){} // RVA: 0x7FFACBF66620
        public void FindBasicIVSize(){} // RVA: 0x7FFACBF666A0
    }

    public class PasswordException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85BCB20 | overloaded x2
    }

    public class PbeUtilities : Object
    {
        public string Algorithms;
        public string Pkcs5S2;
        public string Pkcs12;
        public string OpenSsl;
        public System.Collections.IDictionary algorithms;
        public System.Collections.IDictionary algorithmType; // 0x8
        public System.Collections.IDictionary oids; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBF667C0
        public void MakePbeGenerator(){} // RVA: 0x7FFACBF699D0
        public void GetObjectIdentifier(){} // RVA: 0x7FFACBF69DA0
        public void get_Algorithms(){} // RVA: 0x7FFACBF69F50
        public void IsPkcs12(){} // RVA: 0x7FFACBF69FD0
        public void IsPkcs5Scheme1(){} // RVA: 0x7FFACBF6A150
        public void IsPkcs5Scheme2(){} // RVA: 0x7FFACBF6A2D0
        public void IsOpenSsl(){} // RVA: 0x7FFACBF6A450
        public void IsPbeAlgorithm(){} // RVA: 0x7FFACBF6A5D0
        public void GenerateAlgorithmParameters(){} // RVA: 0x7FFACBF6A7A0 | overloaded x2
        public void GenerateCipherParameters(){} // RVA: 0x7FFACBF6AC30 | overloaded x6
        public void CreateEngine(){} // RVA: 0x7FFACBF6C420 | overloaded x3
        public void GetEncodingName(){} // RVA: 0x7FFACBF6C980
        public void FixDesParity(){} // RVA: 0x7FFACBF6CA50
    }

    public class PrivateKeyFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void CreateKey(){} // RVA: 0x7FFACBF6CD40 | overloaded x3
        public void GetRawKey(){} // RVA: 0x7FFACBF6ED40
        public void DecryptKey(){} // RVA: 0x7FFACBF6EE90 | overloaded x4
        public void EncryptKey(){} // RVA: 0x7FFACBF6EF50 | overloaded x2
    }

    public class PublicKeyFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void CreateKey(){} // RVA: 0x7FFACBF6F030 | overloaded x3
        public void GetRawKey(){} // RVA: 0x7FFACBF70EB0
        public void IsPkcsDHParam(){} // RVA: 0x7FFACBF70F40
        public void ReadPkcsDHParam(){} // RVA: 0x7FFACBF710C0
    }

    public class SecureRandom : Random
    {
        public long Master;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom master; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng.IRandomGenerator generator; // 0x20
        public double DoubleScale; // 0x10

        // ── Methods ──
        public void NextCounterValue(){} // RVA: 0x7FFACBF712A0
        public void get_Master(){} // RVA: 0x7FFACBF71300
        public void CreatePrng(){} // RVA: 0x7FFACBF71360
        public void GetNextBytes(){} // RVA: 0x7FFACBF71540
        public void GetInstance(){} // RVA: 0x7FFACBF71620 | overloaded x2
        public void GetSeed(){} // RVA: 0x7FFACBF717B0
        public void .ctor(){} // RVA: 0x7FFACBF719C0 | overloaded x3
        public void GenerateSeed(){} // RVA: 0x7FFACBF71A70
        public void SetSeed(){} // RVA: 0x7FFACBF71BC0 | overloaded x2
        public void Next(){} // RVA: 0x7FFACBF71D30 | overloaded x3
        public void NextBytes(){} // RVA: 0x7FFACBF71E70 | overloaded x2
        public void NextDouble(){} // RVA: 0x7FFACBF71F00
        public void NextInt(){} // RVA: 0x7FFACBF71FD0
        public void NextLong(){} // RVA: 0x7FFACBF72080
        public void .cctor(){} // RVA: 0x7FFACBF720D0
    }

    public class SecurityUtilityException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF72360 | overloaded x3
    }

    public class SignatureException : GeneralSecurityException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD028E0 | overloaded x3
    }

    public class SignerUtilities : Object
    {
        public System.Collections.IDictionary Algorithms;
        public System.Collections.IDictionary oids; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBF723D0
        public void GetObjectIdentifier(){} // RVA: 0x7FFACBF789D0
        public void get_Algorithms(){} // RVA: 0x7FFACBF78BD0
        public void GetDefaultX509Parameters(){} // RVA: 0x7FFACBF78CB0 | overloaded x2
        public void GetPssX509Parameters(){} // RVA: 0x7FFACBF78F60
        public void GetSigner(){} // RVA: 0x7FFACBF791D0 | overloaded x2
        public void GetEncodingName(){} // RVA: 0x7FFACBF7ACC0
        public void InitSigner(){} // RVA: 0x7FFACBF7AE30 | overloaded x2
    }

    public class WrapperUtilities : Object
    {
        public System.Collections.IDictionary algorithms;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBF7AF60
        public void GetWrapper(){} // RVA: 0x7FFACBF7B630 | overloaded x2
        public void GetAlgorithmName(){} // RVA: 0x7FFACBF7BDF0
    }

}