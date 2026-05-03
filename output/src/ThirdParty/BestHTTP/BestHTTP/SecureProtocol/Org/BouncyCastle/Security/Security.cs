// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Security
// Classes: 22
// Methods: 200

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Security
{
    public class AgreementUtilities : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A3B0430
        public void GetBasicAgreement(){} // RVA: 0x7FFE8A3B0800 | overloaded x2
        public void GetBasicAgreementWithKdf(){} // RVA: 0x7FFE8A3B0BB0 | overloaded x2
        public void GetRawAgreement(){} // RVA: 0x7FFE8A3B1160 | overloaded x2
        public void GetAlgorithmName(){} // RVA: 0x7FFE8A3B1300
        public void GetMechanism(){} // RVA: 0x7FFE8A3B13D0
    }

    public class CipherUtilities : Object
    {
        public System.Collections.IDictionary algorithms;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A3B14C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void GetObjectIdentifier(){} // RVA: 0x7FFE8A3B3310
        public void get_Algorithms(){} // RVA: 0x7FFE8A3B3510
        public void GetCipher(){} // RVA: 0x7FFE8A3B35F0 | overloaded x2
        public void GetAlgorithmName(){} // RVA: 0x7FFE8A3B5A90
        public void GetDigitIndex(){} // RVA: 0x7FFE8A3B5B60
        public void CreateBlockCipher(){} // RVA: 0x7FFE8A3B5C20
    }

    public class DigestUtilities : Object
    {
        public System.Collections.IDictionary algorithms;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A3B6210
        public void GetObjectIdentifier(){} // RVA: 0x7FFE8A3B8390
        public void get_Algorithms(){} // RVA: 0x7FFE8A3B8590
        public void GetDigest(){} // RVA: 0x7FFE8A3B8670 | overloaded x2
        public void GetAlgorithmName(){} // RVA: 0x7FFE8A3B95B0
        public void CalculateDigest(){} // RVA: 0x7FFE8A3B96F0 | overloaded x2
        public void DoFinal(){} // RVA: 0x7FFE8A3B98C0 | overloaded x2
    }

    public class DotNetUtilities : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void ToX509Certificate(){} // RVA: 0x7FFE8A3B9A60 | overloaded x2
        public void FromX509Certificate(){} // RVA: 0x7FFE8A3B9AE0
        public void GetDsaKeyPair(){} // RVA: 0x7FFE8A3B9BD0 | overloaded x2
        public void GetDsaPublicKey(){} // RVA: 0x7FFE8A3BA010 | overloaded x2
        public void GetRsaKeyPair(){} // RVA: 0x7FFE8A3BA3B0 | overloaded x2
        public void GetRsaPublicKey(){} // RVA: 0x7FFE8A3BA830 | overloaded x2
        public void GetKeyPair(){} // RVA: 0x7FFE8A3BA940
        public void ToRSA(){} // RVA: 0x7FFE8A3BB0F0 | overloaded x6
        public void ToRSAParameters(){} // RVA: 0x7FFE8A3BB880 | overloaded x3
        public void ConvertRSAParametersField(){} // RVA: 0x7FFE8A3BBC30
        public void CreateRSAProvider(){} // RVA: 0x7FFE8A3BC0B0 | overloaded x2
    }

    public class EncryptionException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869662F0 | overloaded x2
    }

    public class GeneralSecurityException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A3BC2C0 | overloaded x3
    }

    public class GeneratorUtilities : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A3BC330
        public void AddDefaultKeySizeEntries(){} // RVA: 0x7FFE8A3BFA30
        public void AddKgAlgorithm(){} // RVA: 0x7FFE8A3BFBC0
        public void AddKpgAlgorithm(){} // RVA: 0x7FFE8A3BFDE0
        public void AddHMacKeyGenerator(){} // RVA: 0x7FFE8A3C0010
        public void GetCanonicalKeyGeneratorAlgorithm(){} // RVA: 0x7FFE8A3C02F0
        public void GetCanonicalKeyPairGeneratorAlgorithm(){} // RVA: 0x7FFE8A3C03F0
        public void GetKeyGenerator(){} // RVA: 0x7FFE8A3C0550 | overloaded x2
        public void GetKeyPairGenerator(){} // RVA: 0x7FFE8A3C0900 | overloaded x2
        public void GetDefaultKeySize(){} // RVA: 0x7FFE8A3C1050 | overloaded x2
        public void FindDefaultKeySize(){} // RVA: 0x7FFE8A3C1250
    }

    public class InvalidKeyException : KeyException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A15BF00 | overloaded x3
    }

    public class InvalidParameterException : KeyException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A15BF00 | overloaded x3
    }

    public class KeyException : GeneralSecurityException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A15BF00 | overloaded x3
    }

    public class MacUtilities : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A3C1370
        public void GetMac(){} // RVA: 0x7FFE8A3C2570 | overloaded x2
        public void GetAlgorithmName(){} // RVA: 0x7FFE8A3C3680
        public void CalculateMac(){} // RVA: 0x7FFE8A3C3750
        public void DoFinal(){} // RVA: 0x7FFE8A3C3930 | overloaded x2
    }

    public class NoSuchAlgorithmException : GeneralSecurityException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A15BF00 | overloaded x3
    }

    public class ParameterUtilities : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A3C3A50
        public void AddAlgorithm(){} // RVA: 0x7FFE8A3C5690
        public void AddBasicIVSizeEntries(){} // RVA: 0x7FFE8A3C5860
        public void GetCanonicalAlgorithmName(){} // RVA: 0x7FFE8A3C59F0
        public void CreateKeyParameter(){} // RVA: 0x7FFE8A3C5C90 | overloaded x4
        public void GetCipherParameters(){} // RVA: 0x7FFE8A3C6170 | overloaded x2
        public void GenerateParameters(){} // RVA: 0x7FFE8A3C6740 | overloaded x2
        public void WithRandom(){} // RVA: 0x7FFE8A3C6FA0
        public void CreateIVOctetString(){} // RVA: 0x7FFE8A3C7020
        public void CreateIV(){} // RVA: 0x7FFE8A3C7190
        public void FindBasicIVSize(){} // RVA: 0x7FFE8A3C7210
    }

    public class PasswordException : IOException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869662F0 | overloaded x2
    }

    public class PbeUtilities : Object
    {
        public string Pkcs5S1;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A3C7330
        public void MakePbeGenerator(){} // RVA: 0x7FFE8A3CA540
        public void GetObjectIdentifier(){} // RVA: 0x7FFE8A3CA910
        public void get_Algorithms(){} // RVA: 0x7FFE8A3CAAC0
        public void IsPkcs12(){} // RVA: 0x7FFE8A3CAB40
        public void IsPkcs5Scheme1(){} // RVA: 0x7FFE8A3CACC0
        public void IsPkcs5Scheme2(){} // RVA: 0x7FFE8A3CAE40
        public void IsOpenSsl(){} // RVA: 0x7FFE8A3CAFC0
        public void IsPbeAlgorithm(){} // RVA: 0x7FFE8A3CB140
        public void GenerateAlgorithmParameters(){} // RVA: 0x7FFE8A3CB310 | overloaded x2
        public void GenerateCipherParameters(){} // RVA: 0x7FFE8A3CB7A0 | overloaded x6
        public void CreateEngine(){} // RVA: 0x7FFE8A3CCF90 | overloaded x3
        public void GetEncodingName(){} // RVA: 0x7FFE8A3CD4F0
        public void FixDesParity(){} // RVA: 0x7FFE8A3CD5C0
    }

    public class PrivateKeyFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void CreateKey(){} // RVA: 0x7FFE8A3CD8B0 | overloaded x3
        public void GetRawKey(){} // RVA: 0x7FFE8A3CF8B0
        public void DecryptKey(){} // RVA: 0x7FFE8A3CFA00 | overloaded x4
        public void EncryptKey(){} // RVA: 0x7FFE8A3CFAC0 | overloaded x2
    }

    public class PublicKeyFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void CreateKey(){} // RVA: 0x7FFE8A3CFBA0 | overloaded x3
        public void GetRawKey(){} // RVA: 0x7FFE8A3D1A20
        public void IsPkcsDHParam(){} // RVA: 0x7FFE8A3D1AB0
        public void ReadPkcsDHParam(){} // RVA: 0x7FFE8A3D1C30
    }

    public class SecureRandom : Random
    {
        public long counter;

        // ── Methods ──
        public void NextCounterValue(){} // RVA: 0x7FFE8A3D1E10
        public void get_Master(){} // RVA: 0x7FFE8A3D1E70
        public void CreatePrng(){} // RVA: 0x7FFE8A3D1ED0
        public void GetNextBytes(){} // RVA: 0x7FFE8A3D20B0
        public void GetInstance(){} // RVA: 0x7FFE8A3D2190 | overloaded x2
        public void GetSeed(){} // RVA: 0x7FFE8A3D2320
        public void .ctor(){} // RVA: 0x7FFE8A3D2530 | overloaded x3
        public void GenerateSeed(){} // RVA: 0x7FFE8A3D25E0
        public void SetSeed(){} // RVA: 0x7FFE8A3D2730 | overloaded x2
        public void Next(){} // RVA: 0x7FFE8A3D28A0 | overloaded x3
        public void NextBytes(){} // RVA: 0x7FFE8A3D29E0 | overloaded x2
        public void NextDouble(){} // RVA: 0x7FFE8A3D2A70
        public void NextInt(){} // RVA: 0x7FFE8A3D2B40
        public void NextLong(){} // RVA: 0x7FFE8A3D2BF0
        public void .cctor(){} // RVA: 0x7FFE8A3D2C40
    }

    public class SecurityUtilityException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A3D2ED0 | overloaded x3
    }

    public class SignatureException : GeneralSecurityException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A15BF00 | overloaded x3
    }

    public class SignerUtilities : Object
    {
        public System.Collections.IDictionary algorithms;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A3D2F40
        public void GetObjectIdentifier(){} // RVA: 0x7FFE8A3D9540
        public void get_Algorithms(){} // RVA: 0x7FFE8A3D9740
        public void GetDefaultX509Parameters(){} // RVA: 0x7FFE8A3D9820 | overloaded x2
        public void GetPssX509Parameters(){} // RVA: 0x7FFE8A3D9AD0
        public void GetSigner(){} // RVA: 0x7FFE8A3D9D40 | overloaded x2
        public void GetEncodingName(){} // RVA: 0x7FFE8A3DB830
        public void InitSigner(){} // RVA: 0x7FFE8A3DB9A0 | overloaded x2
    }

    public class WrapperUtilities : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A3DBAD0
        public void GetWrapper(){} // RVA: 0x7FFE8A3DC1A0 | overloaded x2
        public void GetAlgorithmName(){} // RVA: 0x7FFE8A3DC960
    }

}