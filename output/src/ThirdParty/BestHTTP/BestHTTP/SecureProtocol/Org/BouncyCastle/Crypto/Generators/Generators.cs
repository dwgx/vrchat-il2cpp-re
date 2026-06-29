// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Generators
// Classes: 37
// Methods: 183

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Generators
{
    public class BCrypt : Object
    {
        public object MAGIC_STRING;
        public object MAGIC_STRING_LENGTH;
        public object KP;
        public object KS0;
        public object KS1;
        public object KS2;
        public object KS3;
        public object ROUNDS;
        public object SBOX_SK;
        public object SBOX_SK2;
        public object SBOX_SK3;
        public object P_SZ;
        public object S;
        public object P;
        public object SALT_SIZE_BYTES;
        public object MIN_COST;
        public object MAX_COST;
        public object MAX_PASSWORD_BYTES;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2724E0
        public void F(){} // RVA: 0xA2725F0
        public void ProcessTable(){} // RVA: 0xA272680
        public void InitState(){} // RVA: 0xA2727E0
        public void CyclicXorKey(){} // RVA: 0xA272920
        public void EncryptMagicString(){} // RVA: 0xA2729F0
        public void ProcessTableWithSalt(){} // RVA: 0xA272E10
        public void DeriveRawKey(){} // RVA: 0xA2730C0
        public void PasswordToByteArray(){} // RVA: 0xA2735F0
        public void Generate(){} // RVA: 0xA273720
        public void .cctor(){} // RVA: 0xA273A60
    }

    public class BaseKdfBytesGenerator : Object
    {
        public object counterStart;
        public object digest;
        public object shared;
        public object iv;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2574280
        public void Init(){} // RVA: 0xA271D90
        public void get_Digest(){} // RVA: 0xB465B0
        public void GenerateBytes(){} // RVA: 0xA272070
    }

    public class DHBasicKeyPairGenerator : Object
    {
        public object param;

        // ── Methods ──
        public void Init(){} // RVA: 0xA2745A0
        public void GenerateKeyPair(){} // RVA: 0xA2746A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DHKeyGeneratorHelper : Object
    {
        public object Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void CalculatePrivate(){} // RVA: 0xA274870
        public void CalculatePublic(){} // RVA: 0xA274B20
        public void .cctor(){} // RVA: 0xA274B50
    }

    public class DHKeyPairGenerator : Object
    {
        public object param;

        // ── Methods ──
        public void Init(){} // RVA: 0xA274BF0
        public void GenerateKeyPair(){} // RVA: 0xA274CF0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DHParametersGenerator : Object
    {
        public object size;
        public object certainty;
        public object random;

        // ── Methods ──
        public void Init(){} // RVA: 0xA274EC0
        public void GenerateParameters(){} // RVA: 0xA274F20
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DHParametersHelper : Object
    {
        public object Six;
        public object primeLists;
        public object primeProducts;
        public object BigPrimeProducts;

        // ── Methods ──
        public void ConstructBigPrimeProducts(){} // RVA: 0xA275080
        public void GenerateSafePrimes(){} // RVA: 0xA275210
        public void SelectGenerator(){} // RVA: 0xA275980
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA275AC0
    }

    public class DesEdeKeyGenerator : DesKeyGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA273E80
        public void engineInit(){} // RVA: 0xA273E90
        public void engineGenerateKey(){} // RVA: 0xA274090
    }

    public class DesKeyGenerator : CipherKeyGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA273E80
        public void engineInit(){} // RVA: 0xA274300
        public void engineGenerateKey(){} // RVA: 0xA274440
    }

    public class DsaKeyPairGenerator : Object
    {
        public object One;
        public object param;

        // ── Methods ──
        public void Init(){} // RVA: 0xA275E90
        public void GenerateKeyPair(){} // RVA: 0xA275FF0
        public void GeneratePrivateKey(){} // RVA: 0xA276260
        public void CalculatePublicKey(){} // RVA: 0xA2763B0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA2763E0
    }

    public class DsaParametersGenerator : Object
    {
        public object digest;
        public object L;
        public object N;
        public object certainty;
        public object random;
        public object use186_3;
        public object usageIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Init(){} // RVA: 0xA276640
        public void GenerateParameters(){} // RVA: 0xA276980
        public void GenerateParameters_FIPS186_2(){} // RVA: 0xA2769B0
        public void CalculateGenerator_FIPS186_2(){} // RVA: 0xA2772A0
        public void GenerateParameters_FIPS186_3(){} // RVA: 0xA2773F0
        public void CalculateGenerator_FIPS186_3_Unverifiable(){} // RVA: 0x7659E60
        public void CalculateGenerator_FIPS186_3_Verifiable(){} // RVA: 0xA277C80
        public void IsValidDsaStrength(){} // RVA: 0xA277FD0
        public void Hash(){} // RVA: 0xA277FF0
        public void GetDefaultN(){} // RVA: 0xA278090
        public void Inc(){} // RVA: 0xA2780B0
    }

    public class ECKeyPairGenerator : Object
    {
        public object algorithm;
        public object parameters;
        public object publicKeyParamSet;
        public object random;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA278160
        public void Init(){} // RVA: 0xA278260
        public void GenerateKeyPair(){} // RVA: 0xA278940
        public void CreateBasePointMultiplier(){} // RVA: 0xA278C50
        public void FindECCurveByOid(){} // RVA: 0xA278C90
        public void GetCorrespondingPublicKey(){} // RVA: 0xA278DB0
    }

    public class Ed25519KeyPairGenerator : Object
    {
        public object random;

        // ── Methods ──
        public void Init(){} // RVA: 0x262D430
        public void GenerateKeyPair(){} // RVA: 0xA278ED0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Ed448KeyPairGenerator : Object
    {
        public object random;

        // ── Methods ──
        public void Init(){} // RVA: 0x262D430
        public void GenerateKeyPair(){} // RVA: 0xA279080
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ElGamalKeyPairGenerator : Object
    {
        public object param;

        // ── Methods ──
        public void Init(){} // RVA: 0xA279230
        public void GenerateKeyPair(){} // RVA: 0xA279330
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ElGamalParametersGenerator : Object
    {
        public object size;
        public object certainty;
        public object random;

        // ── Methods ──
        public void Init(){} // RVA: 0xA274EC0
        public void GenerateParameters(){} // RVA: 0xA279530
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Gost3410KeyPairGenerator : Object
    {
        public object param;

        // ── Methods ──
        public void Init(){} // RVA: 0xA279620
        public void GenerateKeyPair(){} // RVA: 0xA279930
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Gost3410ParametersGenerator : Object
    {
        public object size;
        public object typeproc;
        public object init_random;

        // ── Methods ──
        public void Init(){} // RVA: 0xA274EC0
        public void procedure_A(){} // RVA: 0xA279DD0
        public void procedure_Aa(){} // RVA: 0xA27A8A0
        public void procedure_B(){} // RVA: 0xA27B3A0
        public void procedure_Bb(){} // RVA: 0xA27BFE0
        public void procedure_C(){} // RVA: 0xA27CC20
        public void GenerateParameters(){} // RVA: 0xA27CDD0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class HkdfBytesGenerator : Object
    {
        public object hMacHash;
        public object hashLen;
        public object info;
        public object currentT;
        public object generatedBytes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA27D320
        public void Init(){} // RVA: 0xA27D410
        public void Extract(){} // RVA: 0xA27D6F0
        public void ExpandNext(){} // RVA: 0xA27D850
        public void get_Digest(){} // RVA: 0x7048FE0
        public void GenerateBytes(){} // RVA: 0xA27D990
    }

    public class Kdf1BytesGenerator : BaseKdfBytesGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA27DB30
    }

    public class Kdf2BytesGenerator : BaseKdfBytesGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7470D50
    }

    public class KdfCounterBytesGenerator : Object
    {
        public object IntegerMax;
        public object Two;
        public object prf;
        public object h;
        public object fixedInputDataCtrPrefix;
        public object fixedInputData_afterCtr;
        public object maxSizeExcl;
        public object ios;
        public object generatedBytes;
        public object k;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA27DB90
        public void Init(){} // RVA: 0xA27DCC0
        public void GetMac(){} // RVA: 0xB5DBF0
        public void get_Digest(){} // RVA: 0xA27E180
        public void GenerateBytes(){} // RVA: 0xA27E230
        public void generateNext(){} // RVA: 0xA27E400
        public void .cctor(){} // RVA: 0xA27E630
    }

    public class KdfDoublePipelineIterationBytesGenerator : Object
    {
        public object IntegerMax;
        public object Two;
        public object prf;
        public object h;
        public object fixedInputData;
        public object maxSizeExcl;
        public object ios;
        public object useCounter;
        public object generatedBytes;
        public object a;
        public object k;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA27E780
        public void Init(){} // RVA: 0xA27E910
        public void generateNext(){} // RVA: 0xA27EDD0
        public void get_Digest(){} // RVA: 0xA27F090
        public void GenerateBytes(){} // RVA: 0xA27F140
        public void GetMac(){} // RVA: 0xB5DBF0
        public void .cctor(){} // RVA: 0xA27F310
    }

    public class KdfFeedbackBytesGenerator : Object
    {
        public object IntegerMax;
        public object Two;
        public object prf;
        public object h;
        public object fixedInputData;
        public object maxSizeExcl;
        public object ios;
        public object iv;
        public object useCounter;
        public object generatedBytes;
        public object k;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA27F460
        public void Init(){} // RVA: 0xA27F590
        public void get_Digest(){} // RVA: 0xA27FAF0
        public void GenerateBytes(){} // RVA: 0xA27FBA0
        public void generateNext(){} // RVA: 0xA27FD70
        public void GetMac(){} // RVA: 0xB5DBF0
        public void .cctor(){} // RVA: 0xA27FFD0
    }

    public class Mgf1BytesGenerator : Object
    {
        public object digest;
        public object seed;
        public object hLen;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA280120
        public void Init(){} // RVA: 0xA2801D0
        public void get_Digest(){} // RVA: 0xB5DBF0
        public void ItoOSP(){} // RVA: 0xA213980
        public void GenerateBytes(){} // RVA: 0xA2803F0
    }

    public class NaccacheSternKeyPairGenerator : Object
    {
        public object smallPrimes;
        public object param;

        // ── Methods ──
        public void Init(){} // RVA: 0xA2808D0
        public void GenerateKeyPair(){} // RVA: 0xA2809D0
        public void generatePrime(){} // RVA: 0xA282060
        public void permuteList(){} // RVA: 0xA2820E0
        public void findFirstPrimes(){} // RVA: 0xA2824B0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA2826B0
    }

    public class OpenBsdBCrypt : Object
    {
        public object EncodingTable;
        public object DecodingTable;
        public object DefaultVersion;
        public object AllowedVersions;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA282790
        public void .ctor(){} // RVA: 0xB43310
        public void CreateBcryptString(){} // RVA: 0xA282BC0
        public void Generate(){} // RVA: 0xA282F20
        public void CheckPassword(){} // RVA: 0xA2832E0
        public void EncodeData(){} // RVA: 0xA2837A0
        public void DecodeSaltString(){} // RVA: 0xA283BD0
    }

    public class OpenSslPbeParametersGenerator : PbeParametersGenerator
    {
        public object digest;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2840E0
        public void Init(){} // RVA: 0xA2841A0
        public void GenerateDerivedKey(){} // RVA: 0xA2841C0
        public void GenerateDerivedParameters(){} // RVA: 0xA2847B0
        public void GenerateDerivedMacParameters(){} // RVA: 0xA2848B0
    }

    public class Pkcs12ParametersGenerator : PbeParametersGenerator
    {
        public object KeyMaterial;
        public object IVMaterial;
        public object MacMaterial;
        public object digest;
        public object u;
        public object v;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA284940
        public void Adjust(){} // RVA: 0xA284A10
        public void GenerateDerivedKey(){} // RVA: 0xA284B10
        public void GenerateDerivedParameters(){} // RVA: 0xA2853B0
        public void GenerateDerivedMacParameters(){} // RVA: 0xA2854D0
    }

    public class Pkcs5S1ParametersGenerator : PbeParametersGenerator
    {
        public object digest;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44DC0
        public void GenerateDerivedKey(){} // RVA: 0xA285570
        public void GenerateDerivedParameters(){} // RVA: 0xA285B10
        public void GenerateDerivedMacParameters(){} // RVA: 0xA285CD0
    }

    public class Pkcs5S2ParametersGenerator : PbeParametersGenerator
    {
        public object hMac;
        public object state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA285E70
        public void F(){} // RVA: 0xA285FD0
        public void GenerateDerivedKey(){} // RVA: 0xA286250
        public void GenerateDerivedParameters(){} // RVA: 0xA2865A0
        public void GenerateDerivedMacParameters(){} // RVA: 0xA2866A0
    }

    public class Poly1305KeyGenerator : CipherKeyGenerator
    {
        public object R_MASK_LOW_2;
        public object R_MASK_HIGH_4;

        // ── Methods ──
        public void engineInit(){} // RVA: 0xA286730
        public void engineGenerateKey(){} // RVA: 0xA2867B0
        public void Clamp(){} // RVA: 0xA286900
        public void CheckKey(){} // RVA: 0xA2869C0
        public void CheckMask(){} // RVA: 0xA286AD0
        public void .ctor(){} // RVA: 0x7521270
    }

    public class RsaBlindingFactorGenerator : Object
    {
        public object key;
        public object random;

        // ── Methods ──
        public void Init(){} // RVA: 0xA286B40
        public void GenerateBlindingFactor(){} // RVA: 0xA286F10
        public void .ctor(){} // RVA: 0xB43310
    }

    public class RsaKeyPairGenerator : Object
    {
        public object SPECIAL_E_VALUES;
        public object SPECIAL_E_HIGHEST;
        public object SPECIAL_E_BITS;
        public object One;
        public object DefaultPublicExponent;
        public object DefaultTests;
        public object parameters;

        // ── Methods ──
        public void Init(){} // RVA: 0xA2870D0
        public void GenerateKeyPair(){} // RVA: 0xA287370
        public void ChooseRandomPrime(){} // RVA: 0xA2878E0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA287C30
    }

    public class SCrypt : Object
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0xA287ED0
        public void MFcrypt(){} // RVA: 0xA288250
        public void SingleIterationPBKDF2(){} // RVA: 0xA288690
        public void SMix(){} // RVA: 0xA2887E0
        public void BlockMix(){} // RVA: 0xA289170
        public void Xor(){} // RVA: 0xA289330
        public void Clear(){} // RVA: 0xA2893D0
        public void ClearAll(){} // RVA: 0xA289400
        public void IsPowerOf2(){} // RVA: 0xA289480
        public void .ctor(){} // RVA: 0xB43310
    }

    public class X25519KeyPairGenerator : Object
    {
        public object random;

        // ── Methods ──
        public void Init(){} // RVA: 0x262D430
        public void GenerateKeyPair(){} // RVA: 0xA289490
        public void .ctor(){} // RVA: 0xB43310
    }

    public class X448KeyPairGenerator : Object
    {
        public object random;

        // ── Methods ──
        public void Init(){} // RVA: 0x262D430
        public void GenerateKeyPair(){} // RVA: 0xA289630
        public void .ctor(){} // RVA: 0xB43310
    }

}