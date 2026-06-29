// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Security
// Classes: 22
// Methods: 127

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Security
{
    public class AgreementUtilities : Object
    {
        public object algorithms;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA5FC680
        public void GetBasicAgreement(){} // RVA: 0xA5FCA50
        public void GetBasicAgreementWithKdf(){} // RVA: 0xA5FCE00
        public void GetRawAgreement(){} // RVA: 0xA5FD3B0
        public void GetAlgorithmName(){} // RVA: 0xA5FD550
        public void GetMechanism(){} // RVA: 0xA5FD610
    }

    public class CipherUtilities : Object
    {
        public object algorithms;
        public object oids;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA5FD6F0
        public void .ctor(){} // RVA: 0xB43310
        public void GetObjectIdentifier(){} // RVA: 0xA5FF4D0
        public void get_Algorithms(){} // RVA: 0xA5FF6C0
        public void GetCipher(){} // RVA: 0xA5FF7A0
        public void GetAlgorithmName(){} // RVA: 0xA601C50
        public void GetDigitIndex(){} // RVA: 0xA601D10
        public void CreateBlockCipher(){} // RVA: 0xA601DF0
    }

    public class DigestUtilities : Object
    {
        public object algorithms;
        public object oids;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA6023E0
        public void GetObjectIdentifier(){} // RVA: 0xA604530
        public void get_Algorithms(){} // RVA: 0xA604720
        public void GetDigest(){} // RVA: 0xA604800
        public void GetAlgorithmName(){} // RVA: 0xA605700
        public void CalculateDigest(){} // RVA: 0xA605830
        public void DoFinal(){} // RVA: 0xA605A00
    }

    public class DotNetUtilities : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void ToX509Certificate(){} // RVA: 0xA605BA0
        public void FromX509Certificate(){} // RVA: 0xA605C20
        public void GetDsaKeyPair(){} // RVA: 0xA605D10
        public void GetDsaPublicKey(){} // RVA: 0xA606150
        public void GetRsaKeyPair(){} // RVA: 0xA6064F0
        public void GetRsaPublicKey(){} // RVA: 0xA606970
        public void GetKeyPair(){} // RVA: 0xA606A80
        public void ToRSA(){} // RVA: 0xA607250
        public void ToRSAParameters(){} // RVA: 0xA607A00
        public void ConvertRSAParametersField(){} // RVA: 0xA607DB0
        public void CreateRSAProvider(){} // RVA: 0xA608240
    }

    public class EncryptionException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x689ED90
    }

    public class GeneralSecurityException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA608450
    }

    public class GeneratorUtilities : Object
    {
        public object kgAlgorithms;
        public object kpgAlgorithms;
        public object defaultKeySizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA6084C0
        public void AddDefaultKeySizeEntries(){} // RVA: 0xA60BBC0
        public void AddKgAlgorithm(){} // RVA: 0xA60BD50
        public void AddKpgAlgorithm(){} // RVA: 0xA60BF80
        public void AddHMacKeyGenerator(){} // RVA: 0xA60C1B0
        public void GetCanonicalKeyGeneratorAlgorithm(){} // RVA: 0xA60C490
        public void GetCanonicalKeyPairGeneratorAlgorithm(){} // RVA: 0xA60C580
        public void GetKeyGenerator(){} // RVA: 0xA60C6D0
        public void GetKeyPairGenerator(){} // RVA: 0xA60CA80
        public void GetDefaultKeySize(){} // RVA: 0xA60D1C0
        public void FindDefaultKeySize(){} // RVA: 0xA60D3C0
    }

    public class InvalidKeyException : KeyException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA39E870
    }

    public class InvalidParameterException : KeyException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA39E870
    }

    public class KeyException : GeneralSecurityException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA39E870
    }

    public class MacUtilities : Object
    {
        public object algorithms;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA60D4D0
        public void GetMac(){} // RVA: 0xA60E6D0
        public void GetAlgorithmName(){} // RVA: 0xA60F7D0
        public void CalculateMac(){} // RVA: 0xA60F890
        public void DoFinal(){} // RVA: 0xA60FA70
    }

    public class NoSuchAlgorithmException : GeneralSecurityException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA39E870
    }

    public class ParameterUtilities : Object
    {
        public object algorithms;
        public object basicIVSizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA60FB90
        public void AddAlgorithm(){} // RVA: 0xA6117D0
        public void AddBasicIVSizeEntries(){} // RVA: 0xA6119B0
        public void GetCanonicalAlgorithmName(){} // RVA: 0xA611B40
        public void CreateKeyParameter(){} // RVA: 0xA611DD0
        public void GetCipherParameters(){} // RVA: 0xA6122B0
        public void GenerateParameters(){} // RVA: 0xA612890
        public void WithRandom(){} // RVA: 0xA6130F0
        public void CreateIVOctetString(){} // RVA: 0xA613170
        public void CreateIV(){} // RVA: 0xA6132E0
        public void FindBasicIVSize(){} // RVA: 0xA613360
    }

    public class PasswordException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x689ED90
    }

    public class PbeUtilities : Object
    {
        public object Pkcs5S1;
        public object Pkcs5S2;
        public object Pkcs12;
        public object OpenSsl;
        public object algorithms;
        public object algorithmType;
        public object oids;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA613470
        public void MakePbeGenerator(){} // RVA: 0xA616680
        public void GetObjectIdentifier(){} // RVA: 0xA616A50
        public void get_Algorithms(){} // RVA: 0xA616BF0
        public void IsPkcs12(){} // RVA: 0xA616C70
        public void IsPkcs5Scheme1(){} // RVA: 0xA616DE0
        public void IsPkcs5Scheme2(){} // RVA: 0xA616F50
        public void IsOpenSsl(){} // RVA: 0xA6170C0
        public void IsPbeAlgorithm(){} // RVA: 0xA617230
        public void GenerateAlgorithmParameters(){} // RVA: 0xA6173F0
        public void GenerateCipherParameters(){} // RVA: 0xA617880
        public void CreateEngine(){} // RVA: 0xA619050
        public void GetEncodingName(){} // RVA: 0xA6195A0
        public void FixDesParity(){} // RVA: 0xA619660
    }

    public class PrivateKeyFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void CreateKey(){} // RVA: 0xA619950
        public void GetRawKey(){} // RVA: 0xA61B950
        public void DecryptKey(){} // RVA: 0xA61BAA0
        public void EncryptKey(){} // RVA: 0xA61BB60
    }

    public class PublicKeyFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void CreateKey(){} // RVA: 0xA61BC40
        public void GetRawKey(){} // RVA: 0xA61DB90
        public void IsPkcsDHParam(){} // RVA: 0xA61DC20
        public void ReadPkcsDHParam(){} // RVA: 0xA61DDA0
    }

    public class SecureRandom : Random
    {
        public object counter;
        public object master;
        public object generator;
        public object DoubleScale;

        // ── Methods ──
        public void NextCounterValue(){} // RVA: 0xA61DF80
        public void get_Master(){} // RVA: 0xA61DFE0
        public void CreatePrng(){} // RVA: 0xA61E040
        public void GetNextBytes(){} // RVA: 0xA61E220
        public void GetInstance(){} // RVA: 0xA61E300
        public void GetSeed(){} // RVA: 0xA61E490
        public void .ctor(){} // RVA: 0xA61E6A0
        public void GenerateSeed(){} // RVA: 0xA61E750
        public void SetSeed(){} // RVA: 0xA61E8A0
        public void Next(){} // RVA: 0xA61EA10
        public void NextBytes(){} // RVA: 0xA61EB50
        public void NextDouble(){} // RVA: 0xA61EBE0
        public void NextInt(){} // RVA: 0xA61ECB0
        public void NextLong(){} // RVA: 0xA61ED60
        public void .cctor(){} // RVA: 0xA61EDB0
    }

    public class SecurityUtilityException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA61F040
    }

    public class SignatureException : GeneralSecurityException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA39E870
    }

    public class SignerUtilities : Object
    {
        public object algorithms;
        public object oids;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA61F0B0
        public void GetObjectIdentifier(){} // RVA: 0xA6256B0
        public void get_Algorithms(){} // RVA: 0xA6258A0
        public void GetDefaultX509Parameters(){} // RVA: 0xA625980
        public void GetPssX509Parameters(){} // RVA: 0xA625C10
        public void GetSigner(){} // RVA: 0xA625E80
        public void GetEncodingName(){} // RVA: 0xA627960
        public void InitSigner(){} // RVA: 0xA627AC0
    }

    public class WrapperUtilities : Object
    {
        public object algorithms;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA627BF0
        public void GetWrapper(){} // RVA: 0xA628290
        public void GetAlgorithmName(){} // RVA: 0xA628A20
    }

}