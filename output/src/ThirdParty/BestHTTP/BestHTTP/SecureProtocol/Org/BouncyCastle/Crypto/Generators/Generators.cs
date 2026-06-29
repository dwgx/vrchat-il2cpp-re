// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Generators
// Classes: 37
// Methods: 183

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Generators
{
    public class BCrypt : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1406F00
        public void F(){} // RVA: 0x7B1407010
        public void ProcessTable(){} // RVA: 0x7B14070A0
        public void InitState(){} // RVA: 0x7B1407200
        public void CyclicXorKey(){} // RVA: 0x7B1407340
        public void EncryptMagicString(){} // RVA: 0x7B1407410
        public void ProcessTableWithSalt(){} // RVA: 0x7B1407830
        public void DeriveRawKey(){} // RVA: 0x7B1407AE0
        public void PasswordToByteArray(){} // RVA: 0x7B1408010
        public void Generate(){} // RVA: 0x7B1408140
        public void .cctor(){} // RVA: 0x7B1408480
    }

    public class BaseKdfBytesGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9AC8120
        public void Init(){} // RVA: 0x7B14067B0
        public void get_Digest(){} // RVA: 0x7A80DA7B0
        public void GenerateBytes(){} // RVA: 0x7B1406A90
    }

    public class DHBasicKeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B1408FC0
        public void GenerateKeyPair(){} // RVA: 0x7B14090C0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DHKeyGeneratorHelper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void CalculatePrivate(){} // RVA: 0x7B1409290
        public void CalculatePublic(){} // RVA: 0x7B1409540
        public void .cctor(){} // RVA: 0x7B1409570
    }

    public class DHKeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B1409610
        public void GenerateKeyPair(){} // RVA: 0x7B1409710
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DHParametersGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B14098E0
        public void GenerateParameters(){} // RVA: 0x7B1409940
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DHParametersHelper : Object
    {
        // ── Methods ──
        public void ConstructBigPrimeProducts(){} // RVA: 0x7B1409AA0
        public void GenerateSafePrimes(){} // RVA: 0x7B1409C30
        public void SelectGenerator(){} // RVA: 0x7B140A3A0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B140A4E0
    }

    public class DesEdeKeyGenerator : DesKeyGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14088A0
        public void engineInit(){} // RVA: 0x7B14088B0
        public void engineGenerateKey(){} // RVA: 0x7B1408AB0
    }

    public class DesKeyGenerator : CipherKeyGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14088A0
        public void engineInit(){} // RVA: 0x7B1408D20
        public void engineGenerateKey(){} // RVA: 0x7B1408E60
    }

    public class DsaKeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B140A8B0
        public void GenerateKeyPair(){} // RVA: 0x7B140AA10
        public void GeneratePrivateKey(){} // RVA: 0x7B140AC80
        public void CalculatePublicKey(){} // RVA: 0x7B140ADD0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B140AE00
    }

    public class DsaParametersGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Init(){} // RVA: 0x7B140B060
        public void GenerateParameters(){} // RVA: 0x7B140B3A0
        public void GenerateParameters_FIPS186_2(){} // RVA: 0x7B140B3D0
        public void CalculateGenerator_FIPS186_2(){} // RVA: 0x7B140BCC0
        public void GenerateParameters_FIPS186_3(){} // RVA: 0x7B140BE10
        public void CalculateGenerator_FIPS186_3_Unverifiable(){} // RVA: 0x7AE9E7DE0
        public void CalculateGenerator_FIPS186_3_Verifiable(){} // RVA: 0x7B140C6A0
        public void IsValidDsaStrength(){} // RVA: 0x7B140C9F0
        public void Hash(){} // RVA: 0x7B140CA10
        public void GetDefaultN(){} // RVA: 0x7B140CAB0
        public void Inc(){} // RVA: 0x7B140CAD0
    }

    public class ECKeyPairGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B140CB80
        public void Init(){} // RVA: 0x7B140CC80
        public void GenerateKeyPair(){} // RVA: 0x7B140D360
        public void CreateBasePointMultiplier(){} // RVA: 0x7B140D670
        public void FindECCurveByOid(){} // RVA: 0x7B140D6B0
        public void GetCorrespondingPublicKey(){} // RVA: 0x7B140D7D0
    }

    public class Ed25519KeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A9B7BB50
        public void GenerateKeyPair(){} // RVA: 0x7B140D8F0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Ed448KeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A9B7BB50
        public void GenerateKeyPair(){} // RVA: 0x7B140DAA0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ElGamalKeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B140DC50
        public void GenerateKeyPair(){} // RVA: 0x7B140DD50
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ElGamalParametersGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B14098E0
        public void GenerateParameters(){} // RVA: 0x7B140DF50
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Gost3410KeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B140E040
        public void GenerateKeyPair(){} // RVA: 0x7B140E350
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Gost3410ParametersGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B14098E0
        public void procedure_A(){} // RVA: 0x7B140E7F0
        public void procedure_Aa(){} // RVA: 0x7B140F2C0
        public void procedure_B(){} // RVA: 0x7B140FDC0
        public void procedure_Bb(){} // RVA: 0x7B1410A00
        public void procedure_C(){} // RVA: 0x7B1411640
        public void GenerateParameters(){} // RVA: 0x7B14117F0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class HkdfBytesGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1411D40
        public void Init(){} // RVA: 0x7B1411E30
        public void Extract(){} // RVA: 0x7B1412110
        public void ExpandNext(){} // RVA: 0x7B1412270
        public void get_Digest(){} // RVA: 0x7AE3C9490
        public void GenerateBytes(){} // RVA: 0x7B14123B0
    }

    public class Kdf1BytesGenerator : BaseKdfBytesGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1412550
    }

    public class Kdf2BytesGenerator : BaseKdfBytesGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE7FB640
    }

    public class KdfCounterBytesGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14125B0
        public void Init(){} // RVA: 0x7B14126E0
        public void GetMac(){} // RVA: 0x7A80F2570
        public void get_Digest(){} // RVA: 0x7B1412BA0
        public void GenerateBytes(){} // RVA: 0x7B1412C50
        public void generateNext(){} // RVA: 0x7B1412E20
        public void .cctor(){} // RVA: 0x7B1413050
    }

    public class KdfDoublePipelineIterationBytesGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14131A0
        public void Init(){} // RVA: 0x7B1413330
        public void generateNext(){} // RVA: 0x7B14137F0
        public void get_Digest(){} // RVA: 0x7B1413AB0
        public void GenerateBytes(){} // RVA: 0x7B1413B60
        public void GetMac(){} // RVA: 0x7A80F2570
        public void .cctor(){} // RVA: 0x7B1413D30
    }

    public class KdfFeedbackBytesGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1413E80
        public void Init(){} // RVA: 0x7B1413FB0
        public void get_Digest(){} // RVA: 0x7B1414510
        public void GenerateBytes(){} // RVA: 0x7B14145C0
        public void generateNext(){} // RVA: 0x7B1414790
        public void GetMac(){} // RVA: 0x7A80F2570
        public void .cctor(){} // RVA: 0x7B14149F0
    }

    public class Mgf1BytesGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1414B40
        public void Init(){} // RVA: 0x7B1414BF0
        public void get_Digest(){} // RVA: 0x7A80F2570
        public void ItoOSP(){} // RVA: 0x7B13A8260
        public void GenerateBytes(){} // RVA: 0x7B1414E40
    }

    public class NaccacheSternKeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B1415320
        public void GenerateKeyPair(){} // RVA: 0x7B1415420
        public void generatePrime(){} // RVA: 0x7B1416AB0
        public void permuteList(){} // RVA: 0x7B1416B30
        public void findFirstPrimes(){} // RVA: 0x7B1416F00
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B1417100
    }

    public class OpenBsdBCrypt : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B14171E0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void CreateBcryptString(){} // RVA: 0x7B1417610
        public void Generate(){} // RVA: 0x7B1417970
        public void CheckPassword(){} // RVA: 0x7B1417D30
        public void EncodeData(){} // RVA: 0x7B14181F0
        public void DecodeSaltString(){} // RVA: 0x7B1418620
    }

    public class OpenSslPbeParametersGenerator : PbeParametersGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1418B30
        public void Init(){} // RVA: 0x7B1418BF0
        public void GenerateDerivedKey(){} // RVA: 0x7B1418C10
        public void GenerateDerivedParameters(){} // RVA: 0x7B1419220
        public void GenerateDerivedMacParameters(){} // RVA: 0x7B1419320
    }

    public class Pkcs12ParametersGenerator : PbeParametersGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14193B0
        public void Adjust(){} // RVA: 0x7B1419480
        public void GenerateDerivedKey(){} // RVA: 0x7B1419580
        public void GenerateDerivedParameters(){} // RVA: 0x7B1419E20
        public void GenerateDerivedMacParameters(){} // RVA: 0x7B1419F40
    }

    public class Pkcs5S1ParametersGenerator : PbeParametersGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E80
        public void GenerateDerivedKey(){} // RVA: 0x7B1419FE0
        public void GenerateDerivedParameters(){} // RVA: 0x7B141A580
        public void GenerateDerivedMacParameters(){} // RVA: 0x7B141A740
    }

    public class Pkcs5S2ParametersGenerator : PbeParametersGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B141A8E0
        public void F(){} // RVA: 0x7B141AA40
        public void GenerateDerivedKey(){} // RVA: 0x7B141ACC0
        public void GenerateDerivedParameters(){} // RVA: 0x7B141B010
        public void GenerateDerivedMacParameters(){} // RVA: 0x7B141B110
    }

    public class Poly1305KeyGenerator : CipherKeyGenerator
    {
        // ── Methods ──
        public void engineInit(){} // RVA: 0x7B141B1A0
        public void engineGenerateKey(){} // RVA: 0x7B141B220
        public void Clamp(){} // RVA: 0x7B141B370
        public void CheckKey(){} // RVA: 0x7B141B430
        public void CheckMask(){} // RVA: 0x7B141B540
        public void .ctor(){} // RVA: 0x7AE8AD0C0
    }

    public class RsaBlindingFactorGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B141B5B0
        public void GenerateBlindingFactor(){} // RVA: 0x7B141B980
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class RsaKeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B141BB40
        public void GenerateKeyPair(){} // RVA: 0x7B141BDE0
        public void ChooseRandomPrime(){} // RVA: 0x7B141C350
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B141C6A0
    }

    public class SCrypt : Object
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x7B141C940
        public void MFcrypt(){} // RVA: 0x7B141CCC0
        public void SingleIterationPBKDF2(){} // RVA: 0x7B141D100
        public void SMix(){} // RVA: 0x7B141D250
        public void BlockMix(){} // RVA: 0x7B141DBE0
        public void Xor(){} // RVA: 0x7B141DDA0
        public void Clear(){} // RVA: 0x7B141DE40
        public void ClearAll(){} // RVA: 0x7B141DE70
        public void IsPowerOf2(){} // RVA: 0x7B141DEF0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class X25519KeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A9B7BB50
        public void GenerateKeyPair(){} // RVA: 0x7B141DF00
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class X448KeyPairGenerator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A9B7BB50
        public void GenerateKeyPair(){} // RVA: 0x7B141E0A0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}