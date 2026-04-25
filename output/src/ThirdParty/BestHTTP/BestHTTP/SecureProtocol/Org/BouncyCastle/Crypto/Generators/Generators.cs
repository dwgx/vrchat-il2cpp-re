// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Generators
// Classes: 37
// Methods: 203

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Generators
{
    public class BCrypt : Object
    {
        public uint[] MAGIC_STRING;
        public int MAGIC_STRING_LENGTH;
        public uint[] KP; // 0x8
        public uint[] KS0; // 0x10
        public uint[] KS1; // 0x18
        public uint[] KS2; // 0x20
        public uint[] KS3; // 0x28
        public int ROUNDS;
        public int SBOX_SK;
        public int SBOX_SK2;
        public int SBOX_SK3;
        public int P_SZ;
        public uint[] S; // 0x10
        public uint[] P; // 0x18
        public int SALT_SIZE_BYTES;
        public int MIN_COST;
        public int MAX_COST;
        public int MAX_PASSWORD_BYTES;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBD8940
        public void F(){} // RVA: 0x7FFACBBD8A50
        public void ProcessTable(){} // RVA: 0x7FFACBBD8AE0
        public void InitState(){} // RVA: 0x7FFACBBD8C20
        public void CyclicXorKey(){} // RVA: 0x7FFACBBD8D60
        public void EncryptMagicString(){} // RVA: 0x7FFACBBD8E10
        public void ProcessTableWithSalt(){} // RVA: 0x7FFACBBD9220
        public void DeriveRawKey(){} // RVA: 0x7FFACBBD9470
        public void PasswordToByteArray(){} // RVA: 0x7FFACBBD9AA0
        public void Generate(){} // RVA: 0x7FFACBBD9BD0
        public void .cctor(){} // RVA: 0x7FFACBBD9F10
    }

    public class BaseKdfBytesGenerator : Object
    {
        public int Digest; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x18
        public byte[] shared; // 0x20
        public byte[] iv; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47EB5F0
        public void Init(){} // RVA: 0x7FFACBBD81D0
        public void get_Digest(){} // RVA: 0x7FFAC2F247C0
        public void GenerateBytes(){} // RVA: 0x7FFACBBD84B0
    }

    public class DHBasicKeyPairGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHKeyGenerationParameters param; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBBDAA70
        public void GenerateKeyPair(){} // RVA: 0x7FFACBBDAB70
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DHKeyGeneratorHelper : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Generators.DHKeyGeneratorHelper Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void CalculatePrivate(){} // RVA: 0x7FFACBBDACF0
        public void CalculatePublic(){} // RVA: 0x7FFACBBDAFA0
        public void .cctor(){} // RVA: 0x7FFACBBDAFD0
    }

    public class DHKeyPairGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHKeyGenerationParameters param; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBBDB070
        public void GenerateKeyPair(){} // RVA: 0x7FFACBBDB170
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DHParametersGenerator : Object
    {
        public int size; // 0x10
        public int certainty; // 0x14
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x18

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBBDB2F0
        public void GenerateParameters(){} // RVA: 0x7FFACBBDB350
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DHParametersHelper : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Six;
        public int[][] primeLists; // 0x8
        public int[] primeProducts; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger[] BigPrimeProducts; // 0x18

        // ── Methods ──
        public void ConstructBigPrimeProducts(){} // RVA: 0x7FFACBBDB4B0
        public void GenerateSafePrimes(){} // RVA: 0x7FFACBBDB630
        public void SelectGenerator(){} // RVA: 0x7FFACBBDBD80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBBDBEC0
    }

    public class DesEdeKeyGenerator : DesKeyGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBDA330 | overloaded x2
        public void engineInit(){} // RVA: 0x7FFACBBDA340
        public void engineGenerateKey(){} // RVA: 0x7FFACBBDA540
    }

    public class DesKeyGenerator : CipherKeyGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBDA330 | overloaded x2
        public void engineInit(){} // RVA: 0x7FFACBBDA7E0
        public void engineGenerateKey(){} // RVA: 0x7FFACBBDA910
    }

    public class DsaKeyPairGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger One;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DsaKeyGenerationParameters param; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBBDC260
        public void GenerateKeyPair(){} // RVA: 0x7FFACBBDC3C0
        public void GeneratePrivateKey(){} // RVA: 0x7FFACBBDC630
        public void CalculatePublicKey(){} // RVA: 0x7FFACBBDC780
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBBDC7B0
    }

    public class DsaParametersGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x10
        public int L; // 0x18
        public int N; // 0x1C
        public int certainty; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x28
        public bool use186_3; // 0x30
        public int usageIndex; // 0x34

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void Init(){} // RVA: 0x7FFACBBDCA10 | overloaded x2
        public void GenerateParameters(){} // RVA: 0x7FFACBBDCD50
        public void GenerateParameters_FIPS186_2(){} // RVA: 0x7FFACBBDCD80
        public void CalculateGenerator_FIPS186_2(){} // RVA: 0x7FFACBBDD620
        public void GenerateParameters_FIPS186_3(){} // RVA: 0x7FFACBBDD770
        public void CalculateGenerator_FIPS186_3_Unverifiable(){} // RVA: 0x7FFAC93914A0
        public void CalculateGenerator_FIPS186_3_Verifiable(){} // RVA: 0x7FFACBBDE000
        public void IsValidDsaStrength(){} // RVA: 0x7FFACBBDE330
        public void Hash(){} // RVA: 0x7FFACBBDE350
        public void GetDefaultN(){} // RVA: 0x7FFACBBDE3F0
        public void Inc(){} // RVA: 0x7FFACBBDE410
    }

    public class ECKeyPairGenerator : Object
    {
        public string algorithm; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECDomainParameters parameters; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBDE4B0 | overloaded x2
        public void Init(){} // RVA: 0x7FFACBBDE5B0
        public void GenerateKeyPair(){} // RVA: 0x7FFACBBDECA0
        public void CreateBasePointMultiplier(){} // RVA: 0x7FFACBBDEFB0
        public void FindECCurveByOid(){} // RVA: 0x7FFACBBDEFF0
        public void GetCorrespondingPublicKey(){} // RVA: 0x7FFACBBDF110
    }

    public class Ed25519KeyPairGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC48A0450
        public void GenerateKeyPair(){} // RVA: 0x7FFACBBDF230
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Ed448KeyPairGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC48A0450
        public void GenerateKeyPair(){} // RVA: 0x7FFACBBDF3E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ElGamalKeyPairGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ElGamalKeyGenerationParameters param; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBBDF590
        public void GenerateKeyPair(){} // RVA: 0x7FFACBBDF690
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ElGamalParametersGenerator : Object
    {
        public int size; // 0x10
        public int certainty; // 0x14
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x18

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBBDB2F0
        public void GenerateParameters(){} // RVA: 0x7FFACBBDF890
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Gost3410KeyPairGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Gost3410KeyGenerationParameters param; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBBDF980
        public void GenerateKeyPair(){} // RVA: 0x7FFACBBDFC90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Gost3410ParametersGenerator : Object
    {
        public int size; // 0x10
        public int typeproc; // 0x14
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom init_random; // 0x18

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBBDB2F0
        public void procedure_A(){} // RVA: 0x7FFACBBE0130
        public void procedure_Aa(){} // RVA: 0x7FFACBBE0BA0
        public void procedure_B(){} // RVA: 0x7FFACBBE1620
        public void procedure_Bb(){} // RVA: 0x7FFACBBE2230
        public void procedure_C(){} // RVA: 0x7FFACBBE2E40
        public void GenerateParameters(){} // RVA: 0x7FFACBBE2FF0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class HkdfBytesGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Macs.HMac Digest; // 0x10
        public int hashLen; // 0x18
        public byte[] info; // 0x20
        public byte[] currentT; // 0x28
        public int generatedBytes; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBE3540
        public void Init(){} // RVA: 0x7FFACBBE3630
        public void Extract(){} // RVA: 0x7FFACBBE3900
        public void ExpandNext(){} // RVA: 0x7FFACBBE3A60
        public void get_Digest(){} // RVA: 0x7FFAC8D71650
        public void GenerateBytes(){} // RVA: 0x7FFACBBE3BA0
    }

    public class Kdf1BytesGenerator : BaseKdfBytesGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBE3D40
    }

    public class Kdf2BytesGenerator : BaseKdfBytesGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC91A2010
    }

    public class KdfCounterBytesGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Digest;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Two; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac prf; // 0x10
        public int h; // 0x18
        public byte[] fixedInputDataCtrPrefix; // 0x20
        public byte[] fixedInputData_afterCtr; // 0x28
        public int maxSizeExcl; // 0x30
        public byte[] ios; // 0x38
        public int generatedBytes; // 0x40
        public byte[] k; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBE3DA0
        public void Init(){} // RVA: 0x7FFACBBE3ED0
        public void GetMac(){} // RVA: 0x7FFAC2F3C380
        public void get_Digest(){} // RVA: 0x7FFACBBE43A0
        public void GenerateBytes(){} // RVA: 0x7FFACBBE4450
        public void generateNext(){} // RVA: 0x7FFACBBE4620
        public void .cctor(){} // RVA: 0x7FFACBBE4850
    }

    public class KdfDoublePipelineIterationBytesGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Digest;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Two; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac prf; // 0x10
        public int h; // 0x18
        public byte[] fixedInputData; // 0x20
        public int maxSizeExcl; // 0x28
        public byte[] ios; // 0x30
        public bool useCounter; // 0x38
        public int generatedBytes; // 0x3C
        public byte[] a; // 0x40
        public byte[] k; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBE49A0
        public void Init(){} // RVA: 0x7FFACBBE4B30
        public void generateNext(){} // RVA: 0x7FFACBBE5000
        public void get_Digest(){} // RVA: 0x7FFACBBE52C0
        public void GenerateBytes(){} // RVA: 0x7FFACBBE5370
        public void GetMac(){} // RVA: 0x7FFAC2F3C380
        public void .cctor(){} // RVA: 0x7FFACBBE5540
    }

    public class KdfFeedbackBytesGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Digest;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Two; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac prf; // 0x10
        public int h; // 0x18
        public byte[] fixedInputData; // 0x20
        public int maxSizeExcl; // 0x28
        public byte[] ios; // 0x30
        public byte[] iv; // 0x38
        public bool useCounter; // 0x40
        public int generatedBytes; // 0x44
        public byte[] k; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBE5690
        public void Init(){} // RVA: 0x7FFACBBE57C0
        public void get_Digest(){} // RVA: 0x7FFACBBE5D20
        public void GenerateBytes(){} // RVA: 0x7FFACBBE5DD0
        public void generateNext(){} // RVA: 0x7FFACBBE5FA0
        public void GetMac(){} // RVA: 0x7FFAC2F3C380
        public void .cctor(){} // RVA: 0x7FFACBBE6200
    }

    public class Mgf1BytesGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest Digest; // 0x10
        public byte[] seed; // 0x18
        public int hLen; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBE6350
        public void Init(){} // RVA: 0x7FFACBBE6400
        public void get_Digest(){} // RVA: 0x7FFAC2F3C380
        public void ItoOSP(){} // RVA: 0x7FFACBB7A590
        public void GenerateBytes(){} // RVA: 0x7FFACBBE6650
    }

    public class NaccacheSternKeyPairGenerator : Object
    {
        public int[] smallPrimes;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.NaccacheSternKeyGenerationParameters param; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBBE6B30
        public void GenerateKeyPair(){} // RVA: 0x7FFACBBE6C30
        public void generatePrime(){} // RVA: 0x7FFACBBE82C0
        public void permuteList(){} // RVA: 0x7FFACBBE8340
        public void findFirstPrimes(){} // RVA: 0x7FFACBBE8720
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBBE8910
    }

    public class OpenBsdBCrypt : Object
    {
        public byte[] EncodingTable;
        public byte[] DecodingTable; // 0x8
        public string DefaultVersion; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Collections.ISet AllowedVersions; // 0x18

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBBE89F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void CreateBcryptString(){} // RVA: 0x7FFACBBE8E20
        public void Generate(){} // RVA: 0x7FFACBBE9180 | overloaded x2
        public void CheckPassword(){} // RVA: 0x7FFACBBE9540
        public void EncodeData(){} // RVA: 0x7FFACBBE9A00
        public void DecodeSaltString(){} // RVA: 0x7FFACBBE9DF0
    }

    public class OpenSslPbeParametersGenerator : PbeParametersGenerator
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBEA2F0
        public void Init(){} // RVA: 0x7FFACBBEA3B0 | overloaded x2
        public void GenerateDerivedKey(){} // RVA: 0x7FFACBBEA3D0
        public void GenerateDerivedParameters(){} // RVA: 0x7FFACBBEA9E0 | overloaded x4
        public void GenerateDerivedMacParameters(){} // RVA: 0x7FFACBBEAAE0
    }

    public class Pkcs12ParametersGenerator : PbeParametersGenerator
    {
        public int KeyMaterial;
        public int IVMaterial;
        public int MacMaterial;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x28
        public int u; // 0x30
        public int v; // 0x34

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBEAB70
        public void Adjust(){} // RVA: 0x7FFACBBEAC40
        public void GenerateDerivedKey(){} // RVA: 0x7FFACBBEAD00
        public void GenerateDerivedParameters(){} // RVA: 0x7FFACBBEB5A0 | overloaded x4
        public void GenerateDerivedMacParameters(){} // RVA: 0x7FFACBBEB6C0
    }

    public class Pkcs5S1ParametersGenerator : PbeParametersGenerator
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E90
        public void GenerateDerivedKey(){} // RVA: 0x7FFACBBEB760
        public void GenerateDerivedParameters(){} // RVA: 0x7FFACBBEBD00 | overloaded x4
        public void GenerateDerivedMacParameters(){} // RVA: 0x7FFACBBEBEC0
    }

    public class Pkcs5S2ParametersGenerator : PbeParametersGenerator
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac hMac; // 0x28
        public byte[] state; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBEC060 | overloaded x2
        public void F(){} // RVA: 0x7FFACBBEC1C0
        public void GenerateDerivedKey(){} // RVA: 0x7FFACBBEC410
        public void GenerateDerivedParameters(){} // RVA: 0x7FFACBBEC750 | overloaded x4
        public void GenerateDerivedMacParameters(){} // RVA: 0x7FFACBBEC850
    }

    public class Poly1305KeyGenerator : CipherKeyGenerator
    {
        public byte R_MASK_LOW_2;
        public byte R_MASK_HIGH_4;

        // ── Methods ──
        public void engineInit(){} // RVA: 0x7FFACBBEC8E0
        public void engineGenerateKey(){} // RVA: 0x7FFACBBEC960
        public void Clamp(){} // RVA: 0x7FFACBBECAB0
        public void CheckKey(){} // RVA: 0x7FFACBBECB70
        public void CheckMask(){} // RVA: 0x7FFACBBECC80
        public void .ctor(){} // RVA: 0x7FFAC9253460
    }

    public class RsaBlindingFactorGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters key; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x18

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBBECCF0
        public void GenerateBlindingFactor(){} // RVA: 0x7FFACBBED0C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class RsaKeyPairGenerator : Object
    {
        public int[] SPECIAL_E_VALUES;
        public int SPECIAL_E_HIGHEST; // 0x8
        public int SPECIAL_E_BITS; // 0xC
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger One; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger DefaultPublicExponent; // 0x18
        public int DefaultTests;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.RsaKeyGenerationParameters parameters; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBBED280
        public void GenerateKeyPair(){} // RVA: 0x7FFACBBED510
        public void ChooseRandomPrime(){} // RVA: 0x7FFACBBEDAB0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBBEDDF0
    }

    public class SCrypt : Object
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x7FFACBBEE090
        public void MFcrypt(){} // RVA: 0x7FFACBBEE410
        public void SingleIterationPBKDF2(){} // RVA: 0x7FFACBBEE840
        public void SMix(){} // RVA: 0x7FFACBBEE990
        public void BlockMix(){} // RVA: 0x7FFACBBEF030
        public void Xor(){} // RVA: 0x7FFACBBEF1D0
        public void Clear(){} // RVA: 0x7FFACBBEF240
        public void ClearAll(){} // RVA: 0x7FFACBBEF270
        public void IsPowerOf2(){} // RVA: 0x7FFACBBEF2F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class X25519KeyPairGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC48A0450
        public void GenerateKeyPair(){} // RVA: 0x7FFACBBEF300
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class X448KeyPairGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC48A0450
        public void GenerateKeyPair(){} // RVA: 0x7FFACBBEF4A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}