// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Security
// Classes: 22
// Methods: 127

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Security
{
    public class AgreementUtilities : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B1790440
        public void GetBasicAgreement(){} // RVA: 0x7B1790810
        public void GetBasicAgreementWithKdf(){} // RVA: 0x7B1790BC0
        public void GetRawAgreement(){} // RVA: 0x7B1791170
        public void GetAlgorithmName(){} // RVA: 0x7B1791310
        public void GetMechanism(){} // RVA: 0x7B17913E0
    }

    public class CipherUtilities : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B17914D0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void GetObjectIdentifier(){} // RVA: 0x7B1793320
        public void get_Algorithms(){} // RVA: 0x7B1793520
        public void GetCipher(){} // RVA: 0x7B1793600
        public void GetAlgorithmName(){} // RVA: 0x7B1795AC0
        public void GetDigitIndex(){} // RVA: 0x7B1795B90
        public void CreateBlockCipher(){} // RVA: 0x7B1795C50
    }

    public class DigestUtilities : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B1796240
        public void GetObjectIdentifier(){} // RVA: 0x7B17983C0
        public void get_Algorithms(){} // RVA: 0x7B17985C0
        public void GetDigest(){} // RVA: 0x7B17986A0
        public void GetAlgorithmName(){} // RVA: 0x7B17995E0
        public void CalculateDigest(){} // RVA: 0x7B1799720
        public void DoFinal(){} // RVA: 0x7B17998F0
    }

    public class DotNetUtilities : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void ToX509Certificate(){} // RVA: 0x7B1799A90
        public void FromX509Certificate(){} // RVA: 0x7B1799B10
        public void GetDsaKeyPair(){} // RVA: 0x7B1799C00
        public void GetDsaPublicKey(){} // RVA: 0x7B179A040
        public void GetRsaKeyPair(){} // RVA: 0x7B179A3E0
        public void GetRsaPublicKey(){} // RVA: 0x7B179A860
        public void GetKeyPair(){} // RVA: 0x7B179A970
        public void ToRSA(){} // RVA: 0x7B179B140
        public void ToRSAParameters(){} // RVA: 0x7B179B8F0
        public void ConvertRSAParametersField(){} // RVA: 0x7B179BCA0
        public void CreateRSAProvider(){} // RVA: 0x7B179C130
    }

    public class EncryptionException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC13C20
    }

    public class GeneralSecurityException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B179C340
    }

    public class GeneratorUtilities : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B179C3B0
        public void AddDefaultKeySizeEntries(){} // RVA: 0x7B179FAB0
        public void AddKgAlgorithm(){} // RVA: 0x7B179FC50
        public void AddKpgAlgorithm(){} // RVA: 0x7B179FE80
        public void AddHMacKeyGenerator(){} // RVA: 0x7B17A00B0
        public void GetCanonicalKeyGeneratorAlgorithm(){} // RVA: 0x7B17A0390
        public void GetCanonicalKeyPairGeneratorAlgorithm(){} // RVA: 0x7B17A0490
        public void GetKeyGenerator(){} // RVA: 0x7B17A05F0
        public void GetKeyPairGenerator(){} // RVA: 0x7B17A09A0
        public void GetDefaultKeySize(){} // RVA: 0x7B17A10F0
        public void FindDefaultKeySize(){} // RVA: 0x7B17A12F0
    }

    public class InvalidKeyException : KeyException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15335C0
    }

    public class InvalidParameterException : KeyException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15335C0
    }

    public class KeyException : GeneralSecurityException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15335C0
    }

    public class MacUtilities : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B17A1410
        public void GetMac(){} // RVA: 0x7B17A2610
        public void GetAlgorithmName(){} // RVA: 0x7B17A3720
        public void CalculateMac(){} // RVA: 0x7B17A37F0
        public void DoFinal(){} // RVA: 0x7B17A39D0
    }

    public class NoSuchAlgorithmException : GeneralSecurityException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15335C0
    }

    public class ParameterUtilities : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B17A3AF0
        public void AddAlgorithm(){} // RVA: 0x7B17A5730
        public void AddBasicIVSizeEntries(){} // RVA: 0x7B17A5910
        public void GetCanonicalAlgorithmName(){} // RVA: 0x7B17A5AB0
        public void CreateKeyParameter(){} // RVA: 0x7B17A5D50
        public void GetCipherParameters(){} // RVA: 0x7B17A6230
        public void GenerateParameters(){} // RVA: 0x7B17A6810
        public void WithRandom(){} // RVA: 0x7B17A7070
        public void CreateIVOctetString(){} // RVA: 0x7B17A70F0
        public void CreateIV(){} // RVA: 0x7B17A7260
        public void FindBasicIVSize(){} // RVA: 0x7B17A72E0
    }

    public class PasswordException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADC13C20
    }

    public class PbeUtilities : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B17A7400
        public void MakePbeGenerator(){} // RVA: 0x7B17AA610
        public void GetObjectIdentifier(){} // RVA: 0x7B17AA9E0
        public void get_Algorithms(){} // RVA: 0x7B17AAB90
        public void IsPkcs12(){} // RVA: 0x7B17AAC10
        public void IsPkcs5Scheme1(){} // RVA: 0x7B17AAD90
        public void IsPkcs5Scheme2(){} // RVA: 0x7B17AAF10
        public void IsOpenSsl(){} // RVA: 0x7B17AB090
        public void IsPbeAlgorithm(){} // RVA: 0x7B17AB210
        public void GenerateAlgorithmParameters(){} // RVA: 0x7B17AB3E0
        public void GenerateCipherParameters(){} // RVA: 0x7B17AB870
        public void CreateEngine(){} // RVA: 0x7B17AD080
        public void GetEncodingName(){} // RVA: 0x7B17AD5E0
        public void FixDesParity(){} // RVA: 0x7B17AD6B0
    }

    public class PrivateKeyFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void CreateKey(){} // RVA: 0x7B17AD9A0
        public void GetRawKey(){} // RVA: 0x7B17AF9A0
        public void DecryptKey(){} // RVA: 0x7B17AFAF0
        public void EncryptKey(){} // RVA: 0x7B17AFBB0
    }

    public class PublicKeyFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void CreateKey(){} // RVA: 0x7B17AFC90
        public void GetRawKey(){} // RVA: 0x7B17B1BE0
        public void IsPkcsDHParam(){} // RVA: 0x7B17B1C70
        public void ReadPkcsDHParam(){} // RVA: 0x7B17B1DF0
    }

    public class SecureRandom : Random
    {
        // ── Methods ──
        public void NextCounterValue(){} // RVA: 0x7B17B1FD0
        public void get_Master(){} // RVA: 0x7B17B2030
        public void CreatePrng(){} // RVA: 0x7B17B2090
        public void GetNextBytes(){} // RVA: 0x7B17B2270
        public void GetInstance(){} // RVA: 0x7B17B2350
        public void GetSeed(){} // RVA: 0x7B17B24E0
        public void .ctor(){} // RVA: 0x7B17B26F0
        public void GenerateSeed(){} // RVA: 0x7B17B27A0
        public void SetSeed(){} // RVA: 0x7B17B28F0
        public void Next(){} // RVA: 0x7B17B2A60
        public void NextBytes(){} // RVA: 0x7B17B2BA0
        public void NextDouble(){} // RVA: 0x7B17B2C30
        public void NextInt(){} // RVA: 0x7B17B2D00
        public void NextLong(){} // RVA: 0x7B17B2DB0
        public void .cctor(){} // RVA: 0x7B17B2E00
    }

    public class SecurityUtilityException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B17B3090
    }

    public class SignatureException : GeneralSecurityException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B15335C0
    }

    public class SignerUtilities : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B17B3100
        public void GetObjectIdentifier(){} // RVA: 0x7B17B9700
        public void get_Algorithms(){} // RVA: 0x7B17B9900
        public void GetDefaultX509Parameters(){} // RVA: 0x7B17B99E0
        public void GetPssX509Parameters(){} // RVA: 0x7B17B9C90
        public void GetSigner(){} // RVA: 0x7B17B9F00
        public void GetEncodingName(){} // RVA: 0x7B17BB9F0
        public void InitSigner(){} // RVA: 0x7B17BBB60
    }

    public class WrapperUtilities : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B17BBC90
        public void GetWrapper(){} // RVA: 0x7B17BC360
        public void GetAlgorithmName(){} // RVA: 0x7B17BCB30
    }

}