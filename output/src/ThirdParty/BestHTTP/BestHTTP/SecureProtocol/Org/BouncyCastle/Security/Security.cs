// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Security
// Classes: 22
// Methods: 200

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Security
{
    public class AgreementUtilities
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9954A00
        public void GetBasicAgreement(){} // RVA: 0x9954DD0 | overloaded x2
        public void GetBasicAgreementWithKdf(){} // RVA: 0x9955180 | overloaded x2
        public void GetRawAgreement(){} // RVA: 0x9955730 | overloaded x2
        public void GetAlgorithmName(){} // RVA: 0x99558D0
        public void GetMechanism(){} // RVA: 0x99559A0
    }

    public class CipherUtilities
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x9955A90
        public void .ctor(){} // RVA: 0x2DD310
        public void GetObjectIdentifier(){} // RVA: 0x99578E0
        public void get_Algorithms(){} // RVA: 0x9957AE0
        public void GetCipher(){} // RVA: 0x9957BC0 | overloaded x2
        public void GetAlgorithmName(){} // RVA: 0x995A060
        public void GetDigitIndex(){} // RVA: 0x995A130
        public void CreateBlockCipher(){} // RVA: 0x995A1F0
    }

    public class DigestUtilities
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x995A7E0
        public void GetObjectIdentifier(){} // RVA: 0x995C960
        public void get_Algorithms(){} // RVA: 0x995CB60
        public void GetDigest(){} // RVA: 0x995CC40 | overloaded x2
        public void GetAlgorithmName(){} // RVA: 0x995DB80
        public void CalculateDigest(){} // RVA: 0x995DCC0 | overloaded x2
        public void DoFinal(){} // RVA: 0x995DE90 | overloaded x2
    }

    public class DotNetUtilities
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void ToX509Certificate(){} // RVA: 0x995E030 | overloaded x2
        public void FromX509Certificate(){} // RVA: 0x995E0B0
        public void GetDsaKeyPair(){} // RVA: 0x995E1A0 | overloaded x2
        public void GetDsaPublicKey(){} // RVA: 0x995E5E0 | overloaded x2
        public void GetRsaKeyPair(){} // RVA: 0x995E980 | overloaded x2
        public void GetRsaPublicKey(){} // RVA: 0x995EE00 | overloaded x2
        public void GetKeyPair(){} // RVA: 0x995EF10
        public void ToRSA(){} // RVA: 0x995F6C0 | overloaded x6
        public void ToRSAParameters(){} // RVA: 0x995FE50 | overloaded x3
        public void ConvertRSAParametersField(){} // RVA: 0x9960200
        public void CreateRSAProvider(){} // RVA: 0x9960680 | overloaded x2
    }

    public class EncryptionException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E254B0 | overloaded x2
    }

    public class GeneralSecurityException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9960890 | overloaded x3
    }

    public class GeneratorUtilities
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9960900
        public void AddDefaultKeySizeEntries(){} // RVA: 0x9964000
        public void AddKgAlgorithm(){} // RVA: 0x9964190
        public void AddKpgAlgorithm(){} // RVA: 0x99643B0
        public void AddHMacKeyGenerator(){} // RVA: 0x99645E0
        public void GetCanonicalKeyGeneratorAlgorithm(){} // RVA: 0x99648C0
        public void GetCanonicalKeyPairGeneratorAlgorithm(){} // RVA: 0x99649C0
        public void GetKeyGenerator(){} // RVA: 0x9964B20 | overloaded x2
        public void GetKeyPairGenerator(){} // RVA: 0x9964ED0 | overloaded x2
        public void GetDefaultKeySize(){} // RVA: 0x9965620 | overloaded x2
        public void FindDefaultKeySize(){} // RVA: 0x9965820
    }

    public class InvalidKeyException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96F9B00 | overloaded x3
    }

    public class InvalidParameterException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96F9B00 | overloaded x3
    }

    public class KeyException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96F9B00 | overloaded x3
    }

    public class MacUtilities
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9965940
        public void GetMac(){} // RVA: 0x9966B40 | overloaded x2
        public void GetAlgorithmName(){} // RVA: 0x9967C50
        public void CalculateMac(){} // RVA: 0x9967D20
        public void DoFinal(){} // RVA: 0x9967F00 | overloaded x2
    }

    public class NoSuchAlgorithmException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96F9B00 | overloaded x3
    }

    public class ParameterUtilities
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9968020
        public void AddAlgorithm(){} // RVA: 0x9969C60
        public void AddBasicIVSizeEntries(){} // RVA: 0x9969E30
        public void GetCanonicalAlgorithmName(){} // RVA: 0x9969FC0
        public void CreateKeyParameter(){} // RVA: 0x996A260 | overloaded x4
        public void GetCipherParameters(){} // RVA: 0x996A740 | overloaded x2
        public void GenerateParameters(){} // RVA: 0x996AD10 | overloaded x2
        public void WithRandom(){} // RVA: 0x996B570
        public void CreateIVOctetString(){} // RVA: 0x996B5F0
        public void CreateIV(){} // RVA: 0x996B760
        public void FindBasicIVSize(){} // RVA: 0x996B7E0
    }

    public class PasswordException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E254B0 | overloaded x2
    }

    public class PbeUtilities
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x996B900
        public void MakePbeGenerator(){} // RVA: 0x996EB10
        public void GetObjectIdentifier(){} // RVA: 0x996EEE0
        public void get_Algorithms(){} // RVA: 0x996F090
        public void IsPkcs12(){} // RVA: 0x996F110
        public void IsPkcs5Scheme1(){} // RVA: 0x996F290
        public void IsPkcs5Scheme2(){} // RVA: 0x996F410
        public void IsOpenSsl(){} // RVA: 0x996F590
        public void IsPbeAlgorithm(){} // RVA: 0x996F710
        public void GenerateAlgorithmParameters(){} // RVA: 0x996F8E0 | overloaded x2
        public void GenerateCipherParameters(){} // RVA: 0x996FD70 | overloaded x6
        public void CreateEngine(){} // RVA: 0x9971560 | overloaded x3
        public void GetEncodingName(){} // RVA: 0x9971AC0
        public void FixDesParity(){} // RVA: 0x9971B90
    }

    public class PrivateKeyFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void CreateKey(){} // RVA: 0x9971E80 | overloaded x3
        public void GetRawKey(){} // RVA: 0x9973E80
        public void DecryptKey(){} // RVA: 0x9973FD0 | overloaded x4
        public void EncryptKey(){} // RVA: 0x9974090 | overloaded x2
    }

    public class PublicKeyFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void CreateKey(){} // RVA: 0x9974170 | overloaded x3
        public void GetRawKey(){} // RVA: 0x9975FF0
        public void IsPkcsDHParam(){} // RVA: 0x9976080
        public void ReadPkcsDHParam(){} // RVA: 0x9976200
    }

    public class SecureRandom
    {
        // ── Methods ──
        public void NextCounterValue(){} // RVA: 0x99763E0
        public void get_Master(){} // RVA: 0x9976440
        public void CreatePrng(){} // RVA: 0x99764A0
        public void GetNextBytes(){} // RVA: 0x9976680
        public void GetInstance(){} // RVA: 0x9976760 | overloaded x2
        public void GetSeed(){} // RVA: 0x99768F0
        public void .ctor(){} // RVA: 0x9976B00 | overloaded x3
        public void GenerateSeed(){} // RVA: 0x9976BB0
        public void SetSeed(){} // RVA: 0x9976D00 | overloaded x2
        public void Next(){} // RVA: 0x9976E70 | overloaded x3
        public void NextBytes(){} // RVA: 0x9976FB0 | overloaded x2
        public void NextDouble(){} // RVA: 0x9977040
        public void NextInt(){} // RVA: 0x9977110
        public void NextLong(){} // RVA: 0x99771C0
        public void .cctor(){} // RVA: 0x9977210
    }

    public class SecurityUtilityException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99774A0 | overloaded x3
    }

    public class SignatureException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96F9B00 | overloaded x3
    }

    public class SignerUtilities
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9977510
        public void GetObjectIdentifier(){} // RVA: 0x997DB10
        public void get_Algorithms(){} // RVA: 0x997DD10
        public void GetDefaultX509Parameters(){} // RVA: 0x997DDF0 | overloaded x2
        public void GetPssX509Parameters(){} // RVA: 0x997E0A0
        public void GetSigner(){} // RVA: 0x997E310 | overloaded x2
        public void GetEncodingName(){} // RVA: 0x997FE00
        public void InitSigner(){} // RVA: 0x997FF70 | overloaded x2
    }

    public class WrapperUtilities
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x99800A0
        public void GetWrapper(){} // RVA: 0x9980770 | overloaded x2
        public void GetAlgorithmName(){} // RVA: 0x9980F30
    }

}