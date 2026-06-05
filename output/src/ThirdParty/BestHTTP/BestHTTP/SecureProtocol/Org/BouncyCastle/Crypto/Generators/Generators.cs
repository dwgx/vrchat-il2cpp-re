// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Generators
// Classes: 37
// Methods: 203

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Generators
{
    public class BCrypt
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC07FB80
        public void F(){} // RVA: 0x7FFAFC07FC90
        public void ProcessTable(){} // RVA: 0x7FFAFC07FD20
        public void InitState(){} // RVA: 0x7FFAFC07FE60
        public void CyclicXorKey(){} // RVA: 0x7FFAFC07FFA0
        public void EncryptMagicString(){} // RVA: 0x7FFAFC080050
        public void ProcessTableWithSalt(){} // RVA: 0x7FFAFC080460
        public void DeriveRawKey(){} // RVA: 0x7FFAFC0806B0
        public void PasswordToByteArray(){} // RVA: 0x7FFAFC080CE0
        public void Generate(){} // RVA: 0x7FFAFC080E10
        public void .cctor(){} // RVA: 0x7FFAFC081150
    }

    public class BaseKdfBytesGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4775AF0
        public void Init(){} // RVA: 0x7FFAFC07F410
        public void get_Digest(){} // RVA: 0x7FFAF2D907C0
        public void GenerateBytes(){} // RVA: 0x7FFAFC07F6F0
    }

    public class DHBasicKeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAFC081CB0
        public void GenerateKeyPair(){} // RVA: 0x7FFAFC081DB0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DHKeyGeneratorHelper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void CalculatePrivate(){} // RVA: 0x7FFAFC081F30
        public void CalculatePublic(){} // RVA: 0x7FFAFC0821E0
        public void .cctor(){} // RVA: 0x7FFAFC082210
    }

    public class DHKeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAFC0822B0
        public void GenerateKeyPair(){} // RVA: 0x7FFAFC0823B0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DHParametersGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAFC082530
        public void GenerateParameters(){} // RVA: 0x7FFAFC082590
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DHParametersHelper
    {
        // ── Methods ──
        public void ConstructBigPrimeProducts(){} // RVA: 0x7FFAFC0826F0
        public void GenerateSafePrimes(){} // RVA: 0x7FFAFC082870
        public void SelectGenerator(){} // RVA: 0x7FFAFC082FC0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC083100
    }

    public class DesEdeKeyGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC081570 | overloaded x2
        public void engineInit(){} // RVA: 0x7FFAFC081580
        public void engineGenerateKey(){} // RVA: 0x7FFAFC081780
    }

    public class DesKeyGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC081570 | overloaded x2
        public void engineInit(){} // RVA: 0x7FFAFC081A20
        public void engineGenerateKey(){} // RVA: 0x7FFAFC081B50
    }

    public class DsaKeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAFC0834A0
        public void GenerateKeyPair(){} // RVA: 0x7FFAFC083600
        public void GeneratePrivateKey(){} // RVA: 0x7FFAFC083870
        public void CalculatePublicKey(){} // RVA: 0x7FFAFC0839C0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC0839F0
    }

    public class DsaParametersGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x2
        public void Init(){} // RVA: 0x7FFAFC083C50 | overloaded x2
        public void GenerateParameters(){} // RVA: 0x7FFAFC083F90
        public void GenerateParameters_FIPS186_2(){} // RVA: 0x7FFAFC083FC0
        public void CalculateGenerator_FIPS186_2(){} // RVA: 0x7FFAFC084860
        public void GenerateParameters_FIPS186_3(){} // RVA: 0x7FFAFC0849B0
        public void CalculateGenerator_FIPS186_3_Unverifiable(){} // RVA: 0x7FFAF96A8D20
        public void CalculateGenerator_FIPS186_3_Verifiable(){} // RVA: 0x7FFAFC085240
        public void IsValidDsaStrength(){} // RVA: 0x7FFAFC085570
        public void Hash(){} // RVA: 0x7FFAFC085590
        public void GetDefaultN(){} // RVA: 0x7FFAFC085630
        public void Inc(){} // RVA: 0x7FFAFC085650
    }

    public class ECKeyPairGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC0856F0 | overloaded x2
        public void Init(){} // RVA: 0x7FFAFC0857F0
        public void GenerateKeyPair(){} // RVA: 0x7FFAFC085EE0
        public void CreateBasePointMultiplier(){} // RVA: 0x7FFAFC0861F0
        public void FindECCurveByOid(){} // RVA: 0x7FFAFC086230
        public void GetCorrespondingPublicKey(){} // RVA: 0x7FFAFC086350
    }

    public class Ed25519KeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF4828690
        public void GenerateKeyPair(){} // RVA: 0x7FFAFC086470
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Ed448KeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF4828690
        public void GenerateKeyPair(){} // RVA: 0x7FFAFC086620
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ElGamalKeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAFC0867D0
        public void GenerateKeyPair(){} // RVA: 0x7FFAFC0868D0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ElGamalParametersGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAFC082530
        public void GenerateParameters(){} // RVA: 0x7FFAFC086AD0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Gost3410KeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAFC086BC0
        public void GenerateKeyPair(){} // RVA: 0x7FFAFC086ED0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Gost3410ParametersGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAFC082530
        public void procedure_A(){} // RVA: 0x7FFAFC087370
        public void procedure_Aa(){} // RVA: 0x7FFAFC087DE0
        public void procedure_B(){} // RVA: 0x7FFAFC088860
        public void procedure_Bb(){} // RVA: 0x7FFAFC089470
        public void procedure_C(){} // RVA: 0x7FFAFC08A080
        public void GenerateParameters(){} // RVA: 0x7FFAFC08A230
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class HkdfBytesGenerator : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC08A780
        public void Init(){} // RVA: 0x7FFAFC08A870
        public void Extract(){} // RVA: 0x7FFAFC08AB40
        public void ExpandNext(){} // RVA: 0x7FFAFC08ACA0
        public void get_Digest(){} // RVA: 0x7FFAF908ABF0
        public void GenerateBytes(){} // RVA: 0x7FFAFC08ADE0
    }

    public class Kdf1BytesGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC08AF80
    }

    public class Kdf2BytesGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF94BB4C0
    }

    public class KdfCounterBytesGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC08AFE0
        public void Init(){} // RVA: 0x7FFAFC08B110
        public void GetMac(){} // RVA: 0x7FFAF2DA8380
        public void get_Digest(){} // RVA: 0x7FFAFC08B5E0
        public void GenerateBytes(){} // RVA: 0x7FFAFC08B690
        public void generateNext(){} // RVA: 0x7FFAFC08B860
        public void .cctor(){} // RVA: 0x7FFAFC08BA90
    }

    public class KdfDoublePipelineIterationBytesGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC08BBE0
        public void Init(){} // RVA: 0x7FFAFC08BD70
        public void generateNext(){} // RVA: 0x7FFAFC08C240
        public void get_Digest(){} // RVA: 0x7FFAFC08C500
        public void GenerateBytes(){} // RVA: 0x7FFAFC08C5B0
        public void GetMac(){} // RVA: 0x7FFAF2DA8380
        public void .cctor(){} // RVA: 0x7FFAFC08C780
    }

    public class KdfFeedbackBytesGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC08C8D0
        public void Init(){} // RVA: 0x7FFAFC08CA00
        public void get_Digest(){} // RVA: 0x7FFAFC08CF60
        public void GenerateBytes(){} // RVA: 0x7FFAFC08D010
        public void generateNext(){} // RVA: 0x7FFAFC08D1E0
        public void GetMac(){} // RVA: 0x7FFAF2DA8380
        public void .cctor(){} // RVA: 0x7FFAFC08D440
    }

    public class Mgf1BytesGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC08D590
        public void Init(){} // RVA: 0x7FFAFC08D640
        public void get_Digest(){} // RVA: 0x7FFAF2DA8380
        public void ItoOSP(){} // RVA: 0x7FFAFC0217E0
        public void GenerateBytes(){} // RVA: 0x7FFAFC08D890
    }

    public class NaccacheSternKeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAFC08DD70
        public void GenerateKeyPair(){} // RVA: 0x7FFAFC08DE70
        public void generatePrime(){} // RVA: 0x7FFAFC08F500
        public void permuteList(){} // RVA: 0x7FFAFC08F580
        public void findFirstPrimes(){} // RVA: 0x7FFAFC08F960
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC08FB50
    }

    public class OpenBsdBCrypt
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC08FC30
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void CreateBcryptString(){} // RVA: 0x7FFAFC090060
        public void Generate(){} // RVA: 0x7FFAFC0903C0 | overloaded x2
        public void CheckPassword(){} // RVA: 0x7FFAFC090780
        public void EncodeData(){} // RVA: 0x7FFAFC090C40
        public void DecodeSaltString(){} // RVA: 0x7FFAFC091030
    }

    public class OpenSslPbeParametersGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC091530
        public void Init(){} // RVA: 0x7FFAFC0915F0 | overloaded x2
        public void GenerateDerivedKey(){} // RVA: 0x7FFAFC091610
        public void GenerateDerivedParameters(){} // RVA: 0x7FFAFC091C20 | overloaded x4
        public void GenerateDerivedMacParameters(){} // RVA: 0x7FFAFC091D20
    }

    public class Pkcs12ParametersGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC091DB0
        public void Adjust(){} // RVA: 0x7FFAFC091E80
        public void GenerateDerivedKey(){} // RVA: 0x7FFAFC091F40
        public void GenerateDerivedParameters(){} // RVA: 0x7FFAFC0927E0 | overloaded x4
        public void GenerateDerivedMacParameters(){} // RVA: 0x7FFAFC092900
    }

    public class Pkcs5S1ParametersGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE90
        public void GenerateDerivedKey(){} // RVA: 0x7FFAFC0929A0
        public void GenerateDerivedParameters(){} // RVA: 0x7FFAFC092F40 | overloaded x4
        public void GenerateDerivedMacParameters(){} // RVA: 0x7FFAFC093100
    }

    public class Pkcs5S2ParametersGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC0932A0 | overloaded x2
        public void F(){} // RVA: 0x7FFAFC093400
        public void GenerateDerivedKey(){} // RVA: 0x7FFAFC093650
        public void GenerateDerivedParameters(){} // RVA: 0x7FFAFC093990 | overloaded x4
        public void GenerateDerivedMacParameters(){} // RVA: 0x7FFAFC093A90
    }

    public class Poly1305KeyGenerator
    {
        // ── Methods ──
        public void engineInit(){} // RVA: 0x7FFAFC093B20
        public void engineGenerateKey(){} // RVA: 0x7FFAFC093BA0
        public void Clamp(){} // RVA: 0x7FFAFC093CF0
        public void CheckKey(){} // RVA: 0x7FFAFC093DB0
        public void CheckMask(){} // RVA: 0x7FFAFC093EC0
        public void .ctor(){} // RVA: 0x7FFAF956C8E0
    }

    public class RsaBlindingFactorGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAFC093F30
        public void GenerateBlindingFactor(){} // RVA: 0x7FFAFC094300
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class RsaKeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAFC0944C0
        public void GenerateKeyPair(){} // RVA: 0x7FFAFC094750
        public void ChooseRandomPrime(){} // RVA: 0x7FFAFC094CF0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC095030
    }

    public class SCrypt
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x7FFAFC0952D0
        public void MFcrypt(){} // RVA: 0x7FFAFC095650
        public void SingleIterationPBKDF2(){} // RVA: 0x7FFAFC095A80
        public void SMix(){} // RVA: 0x7FFAFC095BD0
        public void BlockMix(){} // RVA: 0x7FFAFC096270
        public void Xor(){} // RVA: 0x7FFAFC096410
        public void Clear(){} // RVA: 0x7FFAFC096480
        public void ClearAll(){} // RVA: 0x7FFAFC0964B0
        public void IsPowerOf2(){} // RVA: 0x7FFAFC096530
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class X25519KeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF4828690
        public void GenerateKeyPair(){} // RVA: 0x7FFAFC096540
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class X448KeyPairGenerator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF4828690
        public void GenerateKeyPair(){} // RVA: 0x7FFAFC0966E0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}