// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Generators
// Classes: 37
// Methods: 203

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Generators
{
    public class BCrypt
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95CFB80
        public void F(){} // RVA: 0x95CFC90
        public void ProcessTable(){} // RVA: 0x95CFD20
        public void InitState(){} // RVA: 0x95CFE60
        public void CyclicXorKey(){} // RVA: 0x95CFFA0
        public void EncryptMagicString(){} // RVA: 0x95D0050
        public void ProcessTableWithSalt(){} // RVA: 0x95D0460
        public void DeriveRawKey(){} // RVA: 0x95D06B0
        public void PasswordToByteArray(){} // RVA: 0x95D0CE0
        public void Generate(){} // RVA: 0x95D0E10
        public void .cctor(){} // RVA: 0x95D1150
    }

    public class BaseKdfBytesGenerator
    {
        public int counterStart; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CC5AF0
        public void Init(){} // RVA: 0x95CF410
        public void get_Digest(){} // RVA: 0x2E07C0
        public void GenerateBytes(){} // RVA: 0x95CF6F0
    }

    public class DHBasicKeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x95D1CB0
        public void GenerateKeyPair(){} // RVA: 0x95D1DB0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DHKeyGeneratorHelper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void CalculatePrivate(){} // RVA: 0x95D1F30
        public void CalculatePublic(){} // RVA: 0x95D21E0
        public void .cctor(){} // RVA: 0x95D2210
    }

    public class DHKeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x95D22B0
        public void GenerateKeyPair(){} // RVA: 0x95D23B0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DHParametersGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x95D2530
        public void GenerateParameters(){} // RVA: 0x95D2590
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DHParametersHelper
    {
        // ── Methods ──
        public void ConstructBigPrimeProducts(){} // RVA: 0x95D26F0
        public void GenerateSafePrimes(){} // RVA: 0x95D2870
        public void SelectGenerator(){} // RVA: 0x95D2FC0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x95D3100
    }

    public class DesEdeKeyGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95D1570 | overloaded x2
        public void engineInit(){} // RVA: 0x95D1580
        public void engineGenerateKey(){} // RVA: 0x95D1780
    }

    public class DesKeyGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95D1570 | overloaded x2
        public void engineInit(){} // RVA: 0x95D1A20
        public void engineGenerateKey(){} // RVA: 0x95D1B50
    }

    public class DsaKeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x95D34A0
        public void GenerateKeyPair(){} // RVA: 0x95D3600
        public void GeneratePrivateKey(){} // RVA: 0x95D3870
        public void CalculatePublicKey(){} // RVA: 0x95D39C0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x95D39F0
    }

    public class DsaParametersGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void Init(){} // RVA: 0x95D3C50 | overloaded x2
        public void GenerateParameters(){} // RVA: 0x95D3F90
        public void GenerateParameters_FIPS186_2(){} // RVA: 0x95D3FC0
        public void CalculateGenerator_FIPS186_2(){} // RVA: 0x95D4860
        public void GenerateParameters_FIPS186_3(){} // RVA: 0x95D49B0
        public void CalculateGenerator_FIPS186_3_Unverifiable(){} // RVA: 0x6BF8D20
        public void CalculateGenerator_FIPS186_3_Verifiable(){} // RVA: 0x95D5240
        public void IsValidDsaStrength(){} // RVA: 0x95D5570
        public void Hash(){} // RVA: 0x95D5590
        public void GetDefaultN(){} // RVA: 0x95D5630
        public void Inc(){} // RVA: 0x95D5650
    }

    public class ECKeyPairGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95D56F0 | overloaded x2
        public void Init(){} // RVA: 0x95D57F0
        public void GenerateKeyPair(){} // RVA: 0x95D5EE0
        public void CreateBasePointMultiplier(){} // RVA: 0x95D61F0
        public void FindECCurveByOid(){} // RVA: 0x95D6230
        public void GetCorrespondingPublicKey(){} // RVA: 0x95D6350
    }

    public class Ed25519KeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x1D78690
        public void GenerateKeyPair(){} // RVA: 0x95D6470
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Ed448KeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x1D78690
        public void GenerateKeyPair(){} // RVA: 0x95D6620
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ElGamalKeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x95D67D0
        public void GenerateKeyPair(){} // RVA: 0x95D68D0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ElGamalParametersGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x95D2530
        public void GenerateParameters(){} // RVA: 0x95D6AD0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Gost3410KeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x95D6BC0
        public void GenerateKeyPair(){} // RVA: 0x95D6ED0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Gost3410ParametersGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x95D2530
        public void procedure_A(){} // RVA: 0x95D7370
        public void procedure_Aa(){} // RVA: 0x95D7DE0
        public void procedure_B(){} // RVA: 0x95D8860
        public void procedure_Bb(){} // RVA: 0x95D9470
        public void procedure_C(){} // RVA: 0x95DA080
        public void GenerateParameters(){} // RVA: 0x95DA230
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class HkdfBytesGenerator : .ctor
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs.HMac hMacHash; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95DA780
        public void Init(){} // RVA: 0x95DA870
        public void Extract(){} // RVA: 0x95DAB40
        public void ExpandNext(){} // RVA: 0x95DACA0
        public void get_Digest(){} // RVA: 0x65DABF0
        public void GenerateBytes(){} // RVA: 0x95DADE0
    }

    public class Kdf1BytesGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95DAF80
    }

    public class Kdf2BytesGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A0B4C0
    }

    public class KdfCounterBytesGenerator
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger IntegerMax;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95DAFE0
        public void Init(){} // RVA: 0x95DB110
        public void GetMac(){} // RVA: 0x2F8380
        public void get_Digest(){} // RVA: 0x95DB5E0
        public void GenerateBytes(){} // RVA: 0x95DB690
        public void generateNext(){} // RVA: 0x95DB860
        public void .cctor(){} // RVA: 0x95DBA90
    }

    public class KdfDoublePipelineIterationBytesGenerator
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger IntegerMax;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95DBBE0
        public void Init(){} // RVA: 0x95DBD70
        public void generateNext(){} // RVA: 0x95DC240
        public void get_Digest(){} // RVA: 0x95DC500
        public void GenerateBytes(){} // RVA: 0x95DC5B0
        public void GetMac(){} // RVA: 0x2F8380
        public void .cctor(){} // RVA: 0x95DC780
    }

    public class KdfFeedbackBytesGenerator
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger IntegerMax;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95DC8D0
        public void Init(){} // RVA: 0x95DCA00
        public void get_Digest(){} // RVA: 0x95DCF60
        public void GenerateBytes(){} // RVA: 0x95DD010
        public void generateNext(){} // RVA: 0x95DD1E0
        public void GetMac(){} // RVA: 0x2F8380
        public void .cctor(){} // RVA: 0x95DD440
    }

    public class Mgf1BytesGenerator
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95DD590
        public void Init(){} // RVA: 0x95DD640
        public void get_Digest(){} // RVA: 0x2F8380
        public void ItoOSP(){} // RVA: 0x95717E0
        public void GenerateBytes(){} // RVA: 0x95DD890
    }

    public class NaccacheSternKeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x95DDD70
        public void GenerateKeyPair(){} // RVA: 0x95DDE70
        public void generatePrime(){} // RVA: 0x95DF500
        public void permuteList(){} // RVA: 0x95DF580
        public void findFirstPrimes(){} // RVA: 0x95DF960
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x95DFB50
    }

    public class OpenBsdBCrypt
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x95DFC30
        public void .ctor(){} // RVA: 0x2DD310
        public void CreateBcryptString(){} // RVA: 0x95E0060
        public void Generate(){} // RVA: 0x95E03C0 | overloaded x2
        public void CheckPassword(){} // RVA: 0x95E0780
        public void EncodeData(){} // RVA: 0x95E0C40
        public void DecodeSaltString(){} // RVA: 0x95E1030
    }

    public class OpenSslPbeParametersGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95E1530
        public void Init(){} // RVA: 0x95E15F0 | overloaded x2
        public void GenerateDerivedKey(){} // RVA: 0x95E1610
        public void GenerateDerivedParameters(){} // RVA: 0x95E1C20 | overloaded x4
        public void GenerateDerivedMacParameters(){} // RVA: 0x95E1D20
    }

    public class Pkcs12ParametersGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95E1DB0
        public void Adjust(){} // RVA: 0x95E1E80
        public void GenerateDerivedKey(){} // RVA: 0x95E1F40
        public void GenerateDerivedParameters(){} // RVA: 0x95E27E0 | overloaded x4
        public void GenerateDerivedMacParameters(){} // RVA: 0x95E2900
    }

    public class Pkcs5S1ParametersGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE90
        public void GenerateDerivedKey(){} // RVA: 0x95E29A0
        public void GenerateDerivedParameters(){} // RVA: 0x95E2F40 | overloaded x4
        public void GenerateDerivedMacParameters(){} // RVA: 0x95E3100
    }

    public class Pkcs5S2ParametersGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95E32A0 | overloaded x2
        public void F(){} // RVA: 0x95E3400
        public void GenerateDerivedKey(){} // RVA: 0x95E3650
        public void GenerateDerivedParameters(){} // RVA: 0x95E3990 | overloaded x4
        public void GenerateDerivedMacParameters(){} // RVA: 0x95E3A90
    }

    public class Poly1305KeyGenerator
    {
        // ── Methods ──
        public void engineInit(){} // RVA: 0x95E3B20
        public void engineGenerateKey(){} // RVA: 0x95E3BA0
        public void Clamp(){} // RVA: 0x95E3CF0
        public void CheckKey(){} // RVA: 0x95E3DB0
        public void CheckMask(){} // RVA: 0x95E3EC0
        public void .ctor(){} // RVA: 0x6ABC8E0
    }

    public class RsaBlindingFactorGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x95E3F30
        public void GenerateBlindingFactor(){} // RVA: 0x95E4300
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class RsaKeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x95E44C0
        public void GenerateKeyPair(){} // RVA: 0x95E4750
        public void ChooseRandomPrime(){} // RVA: 0x95E4CF0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x95E5030
    }

    public class SCrypt
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x95E52D0
        public void MFcrypt(){} // RVA: 0x95E5650
        public void SingleIterationPBKDF2(){} // RVA: 0x95E5A80
        public void SMix(){} // RVA: 0x95E5BD0
        public void BlockMix(){} // RVA: 0x95E6270
        public void Xor(){} // RVA: 0x95E6410
        public void Clear(){} // RVA: 0x95E6480
        public void ClearAll(){} // RVA: 0x95E64B0
        public void IsPowerOf2(){} // RVA: 0x95E6530
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class X25519KeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x1D78690
        public void GenerateKeyPair(){} // RVA: 0x95E6540
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class X448KeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x1D78690
        public void GenerateKeyPair(){} // RVA: 0x95E66E0
        public void .ctor(){} // RVA: 0x2DD310
    }

}