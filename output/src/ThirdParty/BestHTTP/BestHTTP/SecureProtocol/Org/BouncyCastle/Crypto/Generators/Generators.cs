// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Generators
// Classes: 37
// Methods: 203

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Generators
{
    public class BCrypt : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A031F60
        public void F(){} // RVA: 0x7FFE8A032070
        public void ProcessTable(){} // RVA: 0x7FFE8A032100
        public void InitState(){} // RVA: 0x7FFE8A032240
        public void CyclicXorKey(){} // RVA: 0x7FFE8A032380
        public void EncryptMagicString(){} // RVA: 0x7FFE8A032430
        public void ProcessTableWithSalt(){} // RVA: 0x7FFE8A032840
        public void DeriveRawKey(){} // RVA: 0x7FFE8A032A90
        public void PasswordToByteArray(){} // RVA: 0x7FFE8A0330C0
        public void Generate(){} // RVA: 0x7FFE8A0331F0
        public void .cctor(){} // RVA: 0x7FFE8A033530
    }

    public class BaseKdfBytesGenerator : Object
    {
        public int counterStart; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A53990
        public void Init(){} // RVA: 0x7FFE8A0317F0
        public void get_Digest(){} // RVA: 0x7FFE810FE7C0
        public void GenerateBytes(){} // RVA: 0x7FFE8A031AD0
    }

    public class DHBasicKeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A034090
        public void GenerateKeyPair(){} // RVA: 0x7FFE8A034190
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DHKeyGeneratorHelper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void CalculatePrivate(){} // RVA: 0x7FFE8A034310
        public void CalculatePublic(){} // RVA: 0x7FFE8A0345C0
        public void .cctor(){} // RVA: 0x7FFE8A0345F0
    }

    public class DHKeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A034690
        public void GenerateKeyPair(){} // RVA: 0x7FFE8A034790
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DHParametersGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A034910
        public void GenerateParameters(){} // RVA: 0x7FFE8A034970
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DHParametersHelper : Object
    {
        // ── Methods ──
        public void ConstructBigPrimeProducts(){} // RVA: 0x7FFE8A034AD0
        public void GenerateSafePrimes(){} // RVA: 0x7FFE8A034C50
        public void SelectGenerator(){} // RVA: 0x7FFE8A0353A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A0354E0
    }

    public class DesEdeKeyGenerator : DesKeyGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A033950 | overloaded x2
        public void engineInit(){} // RVA: 0x7FFE8A033960
        public void engineGenerateKey(){} // RVA: 0x7FFE8A033B60
    }

    public class DesKeyGenerator : CipherKeyGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A033950 | overloaded x2
        public void engineInit(){} // RVA: 0x7FFE8A033E00
        public void engineGenerateKey(){} // RVA: 0x7FFE8A033F30
    }

    public class DsaKeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A035880
        public void GenerateKeyPair(){} // RVA: 0x7FFE8A0359E0
        public void GeneratePrivateKey(){} // RVA: 0x7FFE8A035C50
        public void CalculatePublicKey(){} // RVA: 0x7FFE8A035DA0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A035DD0
    }

    public class DsaParametersGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void Init(){} // RVA: 0x7FFE8A036030 | overloaded x2
        public void GenerateParameters(){} // RVA: 0x7FFE8A036370
        public void GenerateParameters_FIPS186_2(){} // RVA: 0x7FFE8A0363A0
        public void CalculateGenerator_FIPS186_2(){} // RVA: 0x7FFE8A036C40
        public void GenerateParameters_FIPS186_3(){} // RVA: 0x7FFE8A036D90
        public void CalculateGenerator_FIPS186_3_Unverifiable(){} // RVA: 0x7FFE87739BD0
        public void CalculateGenerator_FIPS186_3_Verifiable(){} // RVA: 0x7FFE8A037620
        public void IsValidDsaStrength(){} // RVA: 0x7FFE8A037950
        public void Hash(){} // RVA: 0x7FFE8A037970
        public void GetDefaultN(){} // RVA: 0x7FFE8A037A10
        public void Inc(){} // RVA: 0x7FFE8A037A30
    }

    public class ECKeyPairGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A037AD0 | overloaded x2
        public void Init(){} // RVA: 0x7FFE8A037BD0
        public void GenerateKeyPair(){} // RVA: 0x7FFE8A0382C0
        public void CreateBasePointMultiplier(){} // RVA: 0x7FFE8A0385D0
        public void FindECCurveByOid(){} // RVA: 0x7FFE8A038610
        public void GetCorrespondingPublicKey(){} // RVA: 0x7FFE8A038730
    }

    public class Ed25519KeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE82B08880
        public void GenerateKeyPair(){} // RVA: 0x7FFE8A038850
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Ed448KeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE82B08880
        public void GenerateKeyPair(){} // RVA: 0x7FFE8A038A00
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ElGamalKeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A038BB0
        public void GenerateKeyPair(){} // RVA: 0x7FFE8A038CB0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ElGamalParametersGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A034910
        public void GenerateParameters(){} // RVA: 0x7FFE8A038EB0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Gost3410KeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A038FA0
        public void GenerateKeyPair(){} // RVA: 0x7FFE8A0392B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Gost3410ParametersGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A034910
        public void procedure_A(){} // RVA: 0x7FFE8A039750
        public void procedure_Aa(){} // RVA: 0x7FFE8A03A1C0
        public void procedure_B(){} // RVA: 0x7FFE8A03AC40
        public void procedure_Bb(){} // RVA: 0x7FFE8A03B850
        public void procedure_C(){} // RVA: 0x7FFE8A03C460
        public void GenerateParameters(){} // RVA: 0x7FFE8A03C610
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class HkdfBytesGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs.HMac hMacHash; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A03CB60
        public void Init(){} // RVA: 0x7FFE8A03CC50
        public void Extract(){} // RVA: 0x7FFE8A03CF20
        public void ExpandNext(){} // RVA: 0x7FFE8A03D080
        public void get_Digest(){} // RVA: 0x7FFE87119A80
        public void GenerateBytes(){} // RVA: 0x7FFE8A03D1C0
    }

    public class Kdf1BytesGenerator : BaseKdfBytesGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A03D360
    }

    public class Kdf2BytesGenerator : BaseKdfBytesGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8754A7C0
    }

    public class KdfCounterBytesGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger IntegerMax;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A03D3C0
        public void Init(){} // RVA: 0x7FFE8A03D4F0
        public void GetMac(){} // RVA: 0x7FFE81116380
        public void get_Digest(){} // RVA: 0x7FFE8A03D9C0
        public void GenerateBytes(){} // RVA: 0x7FFE8A03DA70
        public void generateNext(){} // RVA: 0x7FFE8A03DC40
        public void .cctor(){} // RVA: 0x7FFE8A03DE70
    }

    public class KdfDoublePipelineIterationBytesGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger IntegerMax;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A03DFC0
        public void Init(){} // RVA: 0x7FFE8A03E150
        public void generateNext(){} // RVA: 0x7FFE8A03E620
        public void get_Digest(){} // RVA: 0x7FFE8A03E8E0
        public void GenerateBytes(){} // RVA: 0x7FFE8A03E990
        public void GetMac(){} // RVA: 0x7FFE81116380
        public void .cctor(){} // RVA: 0x7FFE8A03EB60
    }

    public class KdfFeedbackBytesGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger IntegerMax;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A03ECB0
        public void Init(){} // RVA: 0x7FFE8A03EDE0
        public void get_Digest(){} // RVA: 0x7FFE8A03F340
        public void GenerateBytes(){} // RVA: 0x7FFE8A03F3F0
        public void generateNext(){} // RVA: 0x7FFE8A03F5C0
        public void GetMac(){} // RVA: 0x7FFE81116380
        public void .cctor(){} // RVA: 0x7FFE8A03F820
    }

    public class Mgf1BytesGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A03F970
        public void Init(){} // RVA: 0x7FFE8A03FA20
        public void get_Digest(){} // RVA: 0x7FFE81116380
        public void ItoOSP(){} // RVA: 0x7FFE89FD3BB0
        public void GenerateBytes(){} // RVA: 0x7FFE8A03FC70
    }

    public class NaccacheSternKeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A040150
        public void GenerateKeyPair(){} // RVA: 0x7FFE8A040250
        public void generatePrime(){} // RVA: 0x7FFE8A0418E0
        public void permuteList(){} // RVA: 0x7FFE8A041960
        public void findFirstPrimes(){} // RVA: 0x7FFE8A041D40
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A041F30
    }

    public class OpenBsdBCrypt : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A042010
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void CreateBcryptString(){} // RVA: 0x7FFE8A042440
        public void Generate(){} // RVA: 0x7FFE8A0427A0 | overloaded x2
        public void CheckPassword(){} // RVA: 0x7FFE8A042B60
        public void EncodeData(){} // RVA: 0x7FFE8A043020
        public void DecodeSaltString(){} // RVA: 0x7FFE8A043410
    }

    public class OpenSslPbeParametersGenerator : PbeParametersGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A043910
        public void Init(){} // RVA: 0x7FFE8A0439D0 | overloaded x2
        public void GenerateDerivedKey(){} // RVA: 0x7FFE8A0439F0
        public void GenerateDerivedParameters(){} // RVA: 0x7FFE8A044000 | overloaded x4
        public void GenerateDerivedMacParameters(){} // RVA: 0x7FFE8A044100
    }

    public class Pkcs12ParametersGenerator : PbeParametersGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A044190
        public void Adjust(){} // RVA: 0x7FFE8A044260
        public void GenerateDerivedKey(){} // RVA: 0x7FFE8A044320
        public void GenerateDerivedParameters(){} // RVA: 0x7FFE8A044BC0 | overloaded x4
        public void GenerateDerivedMacParameters(){} // RVA: 0x7FFE8A044CE0
    }

    public class Pkcs5S1ParametersGenerator : PbeParametersGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE90
        public void GenerateDerivedKey(){} // RVA: 0x7FFE8A044D80
        public void GenerateDerivedParameters(){} // RVA: 0x7FFE8A045320 | overloaded x4
        public void GenerateDerivedMacParameters(){} // RVA: 0x7FFE8A0454E0
    }

    public class Pkcs5S2ParametersGenerator : PbeParametersGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A045680 | overloaded x2
        public void F(){} // RVA: 0x7FFE8A0457E0
        public void GenerateDerivedKey(){} // RVA: 0x7FFE8A045A30
        public void GenerateDerivedParameters(){} // RVA: 0x7FFE8A045D70 | overloaded x4
        public void GenerateDerivedMacParameters(){} // RVA: 0x7FFE8A045E70
    }

    public class Poly1305KeyGenerator : CipherKeyGenerator
    {
        // ── Methods ──
        public void engineInit(){} // RVA: 0x7FFE8A045F00
        public void engineGenerateKey(){} // RVA: 0x7FFE8A045F80
        public void Clamp(){} // RVA: 0x7FFE8A0460D0
        public void CheckKey(){} // RVA: 0x7FFE8A046190
        public void CheckMask(){} // RVA: 0x7FFE8A0462A0
        public void .ctor(){} // RVA: 0x7FFE875FBBD0
    }

    public class RsaBlindingFactorGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A046310
        public void GenerateBlindingFactor(){} // RVA: 0x7FFE8A0466E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class RsaKeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A0468A0
        public void GenerateKeyPair(){} // RVA: 0x7FFE8A046B30
        public void ChooseRandomPrime(){} // RVA: 0x7FFE8A0470D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A047410
    }

    public class SCrypt : Object
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x7FFE8A0476B0
        public void MFcrypt(){} // RVA: 0x7FFE8A047A30
        public void SingleIterationPBKDF2(){} // RVA: 0x7FFE8A047E60
        public void SMix(){} // RVA: 0x7FFE8A047FB0
        public void BlockMix(){} // RVA: 0x7FFE8A048650
        public void Xor(){} // RVA: 0x7FFE8A0487F0
        public void Clear(){} // RVA: 0x7FFE8A048860
        public void ClearAll(){} // RVA: 0x7FFE8A048890
        public void IsPowerOf2(){} // RVA: 0x7FFE8A048910
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class X25519KeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE82B08880
        public void GenerateKeyPair(){} // RVA: 0x7FFE8A048920
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class X448KeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE82B08880
        public void GenerateKeyPair(){} // RVA: 0x7FFE8A048AC0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}