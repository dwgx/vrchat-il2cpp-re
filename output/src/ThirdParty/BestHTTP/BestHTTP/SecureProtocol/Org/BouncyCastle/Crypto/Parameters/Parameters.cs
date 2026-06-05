// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
// Classes: 78
// Methods: 431

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
    public class AeadParameters : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC0350E0 | overloaded x2
        public void get_Key(){} // RVA: 0x7FFAF2DBB0C0
        public void get_MacSize(){} // RVA: 0x7FFAF3241DC0
        public void GetAssociatedText(){} // RVA: 0x7FFAF2DA8380
        public void GetNonce(){} // RVA: 0x7FFAF2D907C0
    }

    public class CcmParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC035210
    }

    public class DHKeyGenerationParameters
    {
        public object Parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC035E60
        public void get_Parameters(){} // RVA: 0x7FFAF2DBB0C0
        public void GetStrength(){} // RVA: 0x7FFAFC035F20
    }

    public class DHKeyParameters
    {
        public object P;
        public object G;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC035FF0 | overloaded x2
        public void get_Parameters(){} // RVA: 0x7FFAF2D907C0
        public void get_AlgorithmOid(){} // RVA: 0x7FFAF2DBB0C0
        public void Equals(){} // RVA: 0x7FFAFC036190 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC036200
    }

    public class DHParameters
    {
        // ── Methods ──
        public void GetDefaultMParam(){} // RVA: 0x7FFAFC036290
        public void .ctor(){} // RVA: 0x7FFAFC036540 | overloaded x6
        public void get_P(){} // RVA: 0x7FFAF2DA8380
        public void get_G(){} // RVA: 0x7FFAF2D907C0
        public void get_Q(){} // RVA: 0x7FFAF2DBB0C0
        public void get_J(){} // RVA: 0x7FFAF2DBB130
        public void get_M(){} // RVA: 0x7FFAF2DE8CD0
        public void get_L(){} // RVA: 0x7FFAF2F76670
        public void get_ValidationParameters(){} // RVA: 0x7FFAF2F476A0
        public void Equals(){} // RVA: 0x7FFAFC036B20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC036BE0
    }

    public class DHPrivateKeyParameters
    {
        public object Y;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC036CE0 | overloaded x2
        public void get_X(){} // RVA: 0x7FFAF2DBB130
        public void Equals(){} // RVA: 0x7FFAFC036E80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC036F10
    }

    public class DHPublicKeyParameters
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFAFC036F60
        public void .ctor(){} // RVA: 0x7FFAFC037250 | overloaded x2
        public void get_Y(){} // RVA: 0x7FFAF2DBB130
        public void Equals(){} // RVA: 0x7FFAFC036E80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC036F10
    }

    public class DHValidationParameters
    {
        public object Parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC037410
        public void GetSeed(){} // RVA: 0x7FFAFC037570
        public void get_Counter(){} // RVA: 0x7FFAF306ED50
        public void Equals(){} // RVA: 0x7FFAFC037770 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC037870
    }

    public class DesEdeParameters
    {
        // ── Methods ──
        public void FixKey(){} // RVA: 0x7FFAFC035220
        public void .ctor(){} // RVA: 0x7FFAFC035450 | overloaded x2
        public void IsWeakKey(){} // RVA: 0x7FFAFC0355B0 | overloaded x3
        public void IsRealEdeKey(){} // RVA: 0x7FFAFC0355E0
        public void IsReal2Key(){} // RVA: 0x7FFAFC035720
        public void IsReal3Key(){} // RVA: 0x7FFAFC035790
    }

    public class DesParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC035940 | overloaded x2
        public void IsWeakKey(){} // RVA: 0x7FFAFC035B60 | overloaded x2
        public void SetOddParity(){} // RVA: 0x7FFAFC035CB0 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAFC035D80
    }

    public class DsaKeyGenerationParameters
    {
        public object Parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC037920
        public void get_Parameters(){} // RVA: 0x7FFAF2DBB0C0
    }

    public class DsaKeyParameters
    {
        public object L;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86557A0
        public void get_Parameters(){} // RVA: 0x7FFAF2D907C0
        public void Equals(){} // RVA: 0x7FFAFC036190 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC036200
    }

    public class DsaParameterGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC037B40 | overloaded x2
        public void get_L(){} // RVA: 0x7FFAF2DDA5C0
        public void get_N(){} // RVA: 0x7FFAF335BED0
        public void get_UsageIndex(){} // RVA: 0x7FFAF3241DC0
        public void get_Certainty(){} // RVA: 0x7FFAF306ED50
        public void get_Random(){} // RVA: 0x7FFAF2DBB0C0
    }

    public class DsaParameters
    {
        public object X;
        public object 5e=;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC037D00 | overloaded x2
        public void get_P(){} // RVA: 0x7FFAF2DA8380
        public void get_Q(){} // RVA: 0x7FFAF2D907C0
        public void get_G(){} // RVA: 0x7FFAF2DBB0C0
        public void get_ValidationParameters(){} // RVA: 0x7FFAF2DBB130
        public void Equals(){} // RVA: 0x7FFAFC037F70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC038010
    }

    public class DsaPrivateKeyParameters
    {
        public object Y;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC0380A0
        public void get_X(){} // RVA: 0x7FFAF2DBB0C0
        public void Equals(){} // RVA: 0x7FFAFC0382E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC038370
    }

    public class DsaPublicKeyParameters
    {
        public object Counter;

        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFAFC0383C0
        public void .ctor(){} // RVA: 0x7FFAFC038560
        public void get_Y(){} // RVA: 0x7FFAF2DBB0C0
        public void Equals(){} // RVA: 0x7FFAFC0382E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC038370
    }

    public class DsaValidationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC038950 | overloaded x2
        public void GetSeed(){} // RVA: 0x7FFAFC038AB0
        public void get_Counter(){} // RVA: 0x7FFAF306ED50
        public void get_UsageIndex(){} // RVA: 0x7FFAF442C3B0
        public void Equals(){} // RVA: 0x7FFAFC038BF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC038CF0
    }

    public class ECDomainParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC0391B0 | overloaded x3
        public void get_Curve(){} // RVA: 0x7FFAF2DA8380
        public void get_G(){} // RVA: 0x7FFAF2DBB0C0
        public void get_N(){} // RVA: 0x7FFAF2DBB130
        public void get_H(){} // RVA: 0x7FFAF30E74D0
        public void get_HInv(){} // RVA: 0x7FFAFC039370
        public void GetSeed(){} // RVA: 0x7FFAFC039520
        public void Equals(){} // RVA: 0x7FFAFC039690 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC039730
        public void ValidatePrivateScalar(){} // RVA: 0x7FFAFC0397D0
        public void ValidatePublicPoint(){} // RVA: 0x7FFAFC039930 | overloaded x2
    }

    public class ECGost3410Parameters
    {
        // ── Methods ──
        public void get_PublicKeyParamSet(){} // RVA: 0x7FFAF2E08730
        public void get_DigestParamSet(){} // RVA: 0x7FFAF2E2E0E0
        public void get_EncryptionParamSet(){} // RVA: 0x7FFAF2E55500
        public void .ctor(){} // RVA: 0x7FFAFC039C90 | overloaded x2
    }

    public class ECKeyGenerationParameters
    {
        public object AlgorithmName;
        public object Parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC039EF0 | overloaded x2
        public void get_DomainParameters(){} // RVA: 0x7FFAF2DBB0C0
        public void get_PublicKeyParamSet(){} // RVA: 0x7FFAF2DBB130
    }

    public class ECKeyParameters
    {
        public object D;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03A180 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFAF2D907C0
        public void get_Parameters(){} // RVA: 0x7FFAF2DBB0C0
        public void get_PublicKeyParamSet(){} // RVA: 0x7FFAF2DBB130
        public void Equals(){} // RVA: 0x7FFAFC03A460 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC03A4C0
        public void CreateKeyGenerationParameters(){} // RVA: 0x7FFAFC03A540
        public void VerifyAlgorithmName(){} // RVA: 0x7FFAFC03A680
        public void LookupParameters(){} // RVA: 0x7FFAFC03A7C0
        public void .cctor(){} // RVA: 0x7FFAFC03AAF0
    }

    public class ECNamedDomainParameters
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2E0A740
        public void .ctor(){} // RVA: 0x7FFAFC03AFE0 | overloaded x4
    }

    public class ECPrivateKeyParameters
    {
        public object Q;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03B460 | overloaded x4
        public void get_D(){} // RVA: 0x7FFAF30E74D0
        public void Equals(){} // RVA: 0x7FFAFC03B660 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC03B6F0
    }

    public class ECPublicKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03B9A0 | overloaded x4
        public void get_Q(){} // RVA: 0x7FFAF30E74D0
        public void Equals(){} // RVA: 0x7FFAFC03BBA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC03B6F0
    }

    public class Ed25519KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03BC30
    }

    public class Ed25519PrivateKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03BF30 | overloaded x3
        public void Encode(){} // RVA: 0x7FFAFC03C0D0
        public void GetEncoded(){} // RVA: 0x7FFAFC03C170
        public void GeneratePublicKey(){} // RVA: 0x7FFAFC03C220
        public void Sign(){} // RVA: 0x7FFAFC03C2F0
        public void .cctor(){} // RVA: 0x7FFAFC03C770
    }

    public class Ed25519PublicKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03C930 | overloaded x2
        public void Encode(){} // RVA: 0x7FFAFC03CAD0
        public void GetEncoded(){} // RVA: 0x7FFAFC03CB70
        public void .cctor(){} // RVA: 0x7FFAFC03CC20
    }

    public class Ed448KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03CCA0
    }

    public class Ed448PrivateKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03CFA0 | overloaded x3
        public void Encode(){} // RVA: 0x7FFAFC03D140
        public void GetEncoded(){} // RVA: 0x7FFAFC03D1E0
        public void GeneratePublicKey(){} // RVA: 0x7FFAFC03D290
        public void Sign(){} // RVA: 0x7FFAFC03D360
        public void .cctor(){} // RVA: 0x7FFAFC03D6E0
    }

    public class Ed448PublicKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03D8A0 | overloaded x2
        public void Encode(){} // RVA: 0x7FFAFC03DA40
        public void GetEncoded(){} // RVA: 0x7FFAFC03DAE0
        public void .cctor(){} // RVA: 0x7FFAFC03DB90
    }

    public class ElGamalKeyGenerationParameters
    {
        public object Parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03DC10
        public void get_Parameters(){} // RVA: 0x7FFAF2DBB0C0
        public void GetStrength(){} // RVA: 0x7FFAFC03DCD0
    }

    public class ElGamalKeyParameters
    {
        public object P;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86557A0
        public void get_Parameters(){} // RVA: 0x7FFAF2D907C0
        public void Equals(){} // RVA: 0x7FFAFC036190 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC036200
    }

    public class ElGamalParameters
    {
        public object X;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03DF70 | overloaded x2
        public void get_P(){} // RVA: 0x7FFAF2DA8380
        public void get_G(){} // RVA: 0x7FFAF2D907C0
        public void get_L(){} // RVA: 0x7FFAF3210030
        public void Equals(){} // RVA: 0x7FFAFC03E1F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC03E280
    }

    public class ElGamalPrivateKeyParameters
    {
        public object Y;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03E2E0
        public void get_X(){} // RVA: 0x7FFAF2DBB0C0
        public void Equals(){} // RVA: 0x7FFAFC03E520 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC038370
    }

    public class ElGamalPublicKeyParameters
    {
        public object Parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03E5B0
        public void get_Y(){} // RVA: 0x7FFAF2DBB0C0
        public void Equals(){} // RVA: 0x7FFAFC0382E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC038370
    }

    public class Gost3410KeyGenerationParameters
    {
        public object Parameters;
        public object PublicKeyParamSet;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03E7F0 | overloaded x2
        public void get_Parameters(){} // RVA: 0x7FFAF2DBB0C0
        public void get_PublicKeyParamSet(){} // RVA: 0x7FFAF2DBB130
        public void LookupParameters(){} // RVA: 0x7FFAFC03E920
    }

    public class Gost3410KeyParameters
    {
        public object P;
        public object Q;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03EBE0 | overloaded x2
        public void get_Parameters(){} // RVA: 0x7FFAF2D907C0
        public void get_PublicKeyParamSet(){} // RVA: 0x7FFAF2DBB0C0
        public void LookupParameters(){} // RVA: 0x7FFAFC03ECC0
    }

    public class Gost3410Parameters
    {
        public object X;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03F0C0 | overloaded x2
        public void get_P(){} // RVA: 0x7FFAF2DA8380
        public void get_Q(){} // RVA: 0x7FFAF2D907C0
        public void get_A(){} // RVA: 0x7FFAF2DBB0C0
        public void get_ValidationParameters(){} // RVA: 0x7FFAF2DBB130
        public void Equals(){} // RVA: 0x7FFAFC037F70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAFC038010
    }

    public class Gost3410PrivateKeyParameters
    {
        public object Y;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03F450 | overloaded x2
        public void get_X(){} // RVA: 0x7FFAF2DBB130
    }

    public class Gost3410PublicKeyParameters
    {
        public object C;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03F680 | overloaded x2
        public void get_Y(){} // RVA: 0x7FFAF2DBB130
    }

    public class Gost3410ValidationParameters
    {
        public object SkipExtract;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03F780 | overloaded x2
        public void get_C(){} // RVA: 0x7FFAF335BED0
        public void get_X0(){} // RVA: 0x7FFAF2DDA5C0
        public void get_CL(){} // RVA: 0x7FFAF2DBB0C0
        public void get_X0L(){} // RVA: 0x7FFAF2D907C0
        public void Equals(){} // RVA: 0x7FFAFC03F790
        public void GetHashCode(){} // RVA: 0x7FFAFC03F850
    }

    public class HkdfParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03FBC0 | overloaded x2
        public void SkipExtractParameters(){} // RVA: 0x7FFAFC03FBF0
        public void DefaultParameters(){} // RVA: 0x7FFAFC03FC70
        public void GetIkm(){} // RVA: 0x7FFAFC03FCE0
        public void get_SkipExtract(){} // RVA: 0x7FFAF2DA84E0
        public void GetSalt(){} // RVA: 0x7FFAFC03FD90
        public void GetInfo(){} // RVA: 0x7FFAFC03FE40
    }

    public class IesParameters
    {
        public object CipherKeySize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF53414C0
        public void GetDerivationV(){} // RVA: 0x7FFAF2DA8380
        public void GetEncodingV(){} // RVA: 0x7FFAF2D907C0
        public void get_MacKeySize(){} // RVA: 0x7FFAF3210030
    }

    public class IesWithCipherParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03FEF0
        public void get_CipherKeySize(){} // RVA: 0x7FFAF3241DC0
    }

    public class Iso18033KdfParameters : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void GetSeed(){} // RVA: 0x7FFAF2DA8380
    }

    public class KdfCounterParameters
    {
        public object Ki;
        public object UseCounter;
        public object R;
        public object FixedInputData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03FFE0 | overloaded x2
        public void get_Ki(){} // RVA: 0x7FFAF2DA8380
        public void get_FixedInputData(){} // RVA: 0x7FFAFC040420
        public void get_FixedInputDataCounterPrefix(){} // RVA: 0x7FFAFC0404D0
        public void get_FixedInputDataCounterSuffix(){} // RVA: 0x7FFAFC040580
        public void get_R(){} // RVA: 0x7FFAF3241DC0
    }

    public class KdfDoublePipelineIterationParameters
    {
        public object Ki;
        public object Iv;
        public object UseCounter;
        public object R;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC040630
        public void CreateWithCounter(){} // RVA: 0x7FFAFC040950
        public void CreateWithoutCounter(){} // RVA: 0x7FFAFC0409E0
        public void get_Ki(){} // RVA: 0x7FFAFC040A80
        public void get_UseCounter(){} // RVA: 0x7FFAF2DA84E0
        public void get_R(){} // RVA: 0x7FFAF442C3B0
        public void get_FixedInputData(){} // RVA: 0x7FFAFC040B30
        public void .cctor(){} // RVA: 0x7FFAFC040BE0
    }

    public class KdfFeedbackParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC040C20
        public void CreateWithCounter(){} // RVA: 0x7FFAFC041010
        public void CreateWithoutCounter(){} // RVA: 0x7FFAFC041100
        public void get_Ki(){} // RVA: 0x7FFAFC0411C0
        public void get_Iv(){} // RVA: 0x7FFAFC041270
        public void get_UseCounter(){} // RVA: 0x7FFAF2E7B9D0
        public void get_R(){} // RVA: 0x7FFAF379F5B0
        public void get_FixedInputData(){} // RVA: 0x7FFAFC041320
        public void .cctor(){} // RVA: 0x7FFAFC0413D0
    }

    public class KdfParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF877CD00
        public void GetSharedSecret(){} // RVA: 0x7FFAF2D907C0
        public void GetIV(){} // RVA: 0x7FFAF2DA8380
    }

    public class KeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC041550 | overloaded x2
        public void GetKey(){} // RVA: 0x7FFAFC0416F0
    }

    public class MgfParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC041850 | overloaded x2
        public void GetSeed(){} // RVA: 0x7FFAFC041930
    }

    public class MqvPrivateParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC0419D0 | overloaded x2
        public void get_StaticPrivateKey(){} // RVA: 0x7FFAF2DA8380
        public void get_EphemeralPrivateKey(){} // RVA: 0x7FFAF2D907C0
        public void get_EphemeralPublicKey(){} // RVA: 0x7FFAF2DBB0C0
    }

    public class MqvPublicParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC041C50
        public void get_StaticPublicKey(){} // RVA: 0x7FFAF2DA8380
        public void get_EphemeralPublicKey(){} // RVA: 0x7FFAF2D907C0
    }

    public class NaccacheSternKeyGenerationParameters
    {
        public object G;
        public object LowerSigmaBound;
        public object Modulus;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC041DB0 | overloaded x2
        public void get_Certainty(){} // RVA: 0x7FFAF3210030
        public void get_CountSmallPrimes(){} // RVA: 0x7FFAF379F5B0
        public void get_IsDebug(){} // RVA: 0x7FFAF2D8D320
    }

    public class NaccacheSternKeyParameters
    {
        public object PhiN;
        public object SmallPrimes;
        public object SmallPrimesList;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC041E90
        public void get_G(){} // RVA: 0x7FFAF2D907C0
        public void get_LowerSigmaBound(){} // RVA: 0x7FFAF3241DC0
        public void get_Modulus(){} // RVA: 0x7FFAF2DBB0C0
    }

    public class NaccacheSternPrivateKeyParameters
    {
        public object Parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC041F50 | overloaded x2
        public void get_PhiN(){} // RVA: 0x7FFAF30E74D0
        public void get_SmallPrimes(){} // RVA: 0x7FFAFC042030
        public void get_SmallPrimesList(){} // RVA: 0x7FFAF2F476A0
    }

    public class ParametersWithID
    {
        public object Parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC0421D0 | overloaded x2
        public void GetID(){} // RVA: 0x7FFAF2D907C0
        public void get_Parameters(){} // RVA: 0x7FFAF2DA8380
    }

    public class ParametersWithIV
    {
        public object Random;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC042330 | overloaded x2
        public void GetIV(){} // RVA: 0x7FFAFC0424C0
        public void get_Parameters(){} // RVA: 0x7FFAF2DA8380
    }

    public class ParametersWithRandom
    {
        public object Parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC0426B0 | overloaded x2
        public void GetRandom(){} // RVA: 0x7FFAF2D907C0
        public void get_Random(){} // RVA: 0x7FFAF2D907C0
        public void get_Parameters(){} // RVA: 0x7FFAF2DA8380
    }

    public class ParametersWithSBox
    {
        public object EffectiveKeyBits;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void GetSBox(){} // RVA: 0x7FFAF2D907C0
        public void get_Parameters(){} // RVA: 0x7FFAF2DA8380
    }

    public class ParametersWithSalt
    {
        public object Parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC042870 | overloaded x2
        public void GetSalt(){} // RVA: 0x7FFAF2DA8380
        public void get_Parameters(){} // RVA: 0x7FFAF2D907C0
    }

    public class RC2Parameters
    {
        public object Rounds;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC042A60 | overloaded x4
        public void get_EffectiveKeyBits(){} // RVA: 0x7FFAF306ED50
    }

    public class RC5Parameters
    {
        public object PublicKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC042A90
        public void get_Rounds(){} // RVA: 0x7FFAF306ED50
    }

    public class RsaBlindingParameters
    {
        public object PublicExponent;
        public object Certainty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC042B20
        public void get_PublicKey(){} // RVA: 0x7FFAF2DA8380
        public void get_BlindingFactor(){} // RVA: 0x7FFAF2D907C0
    }

    public class RsaKeyGenerationParameters
    {
        public object Modulus;
        public object Exponent;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC042C50
        public void get_PublicExponent(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Certainty(){} // RVA: 0x7FFAF3241DC0
        public void Equals(){} // RVA: 0x7FFAFC042CE0
        public void GetHashCode(){} // RVA: 0x7FFAFC042DA0
    }

    public class RsaKeyParameters
    {
        public object PublicExponent;
        public object P;

        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFAFC042DE0
        public void .ctor(){} // RVA: 0x7FFAFC042FB0
        public void get_Modulus(){} // RVA: 0x7FFAF2D907C0
        public void get_Exponent(){} // RVA: 0x7FFAF2DBB0C0
        public void Equals(){} // RVA: 0x7FFAFC043230
        public void GetHashCode(){} // RVA: 0x7FFAFC043330
        public void .cctor(){} // RVA: 0x7FFAFC0433E0
    }

    public class RsaPrivateCrtKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC043C90 | overloaded x2
        public void get_PublicExponent(){} // RVA: 0x7FFAF2DBB130
        public void get_P(){} // RVA: 0x7FFAF30E74D0
        public void get_Q(){} // RVA: 0x7FFAF2F476A0
        public void get_DP(){} // RVA: 0x7FFAF2E0A740
        public void get_DQ(){} // RVA: 0x7FFAF2E08730
        public void get_QInv(){} // RVA: 0x7FFAF2E2E0E0
        public void Equals(){} // RVA: 0x7FFAFC043CF0
        public void GetHashCode(){} // RVA: 0x7FFAFC043F00
        public void ValidateValue(){} // RVA: 0x7FFAFC044070
    }

    public class SM2KeyExchangePrivateParameters : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC045BC0
        public void get_IsInitiator(){} // RVA: 0x7FFAF2E575E0
        public void get_StaticPrivateKey(){} // RVA: 0x7FFAF2D907C0
        public void get_StaticPublicPoint(){} // RVA: 0x7FFAF2DBB0C0
        public void get_EphemeralPrivateKey(){} // RVA: 0x7FFAF2DBB130
        public void get_EphemeralPublicPoint(){} // RVA: 0x7FFAF30E74D0
    }

    public class SM2KeyExchangePublicParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC045E10
        public void get_StaticPublicKey(){} // RVA: 0x7FFAF2DA8380
        public void get_EphemeralPublicKey(){} // RVA: 0x7FFAF2D907C0
    }

    public class SkeinParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x2
        public void GetParameters(){} // RVA: 0x7FFAF2DA8380
        public void GetKey(){} // RVA: 0x7FFAFC044220
        public void GetPersonalisation(){} // RVA: 0x7FFAFC044380
        public void GetPublicKey(){} // RVA: 0x7FFAFC044450
        public void GetKeyIdentifier(){} // RVA: 0x7FFAFC044520
        public void GetNonce(){} // RVA: 0x7FFAFC0445F0
    }

    public class Srp6GroupParameters
    {
        public object Key;
        public object Tweak;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void get_G(){} // RVA: 0x7FFAF2D907C0
        public void get_N(){} // RVA: 0x7FFAF2DA8380
    }

    public class TweakableBlockCipherParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC045F70
        public void get_Key(){} // RVA: 0x7FFAF2D907C0
        public void get_Tweak(){} // RVA: 0x7FFAF2DA8380
    }

    public class X25519KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC0460F0
    }

    public class X25519PrivateKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC046400 | overloaded x3
        public void Encode(){} // RVA: 0x7FFAFC0465A0
        public void GetEncoded(){} // RVA: 0x7FFAFC046640
        public void GeneratePublicKey(){} // RVA: 0x7FFAFC0466F0
        public void GenerateSecret(){} // RVA: 0x7FFAFC046790
        public void .cctor(){} // RVA: 0x7FFAFC046950
    }

    public class X25519PublicKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC046AD0 | overloaded x2
        public void Encode(){} // RVA: 0x7FFAFC046C70
        public void GetEncoded(){} // RVA: 0x7FFAFC046D10
        public void .cctor(){} // RVA: 0x7FFAFC046DC0
    }

    public class X448KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC03CCA0
    }

    public class X448PrivateKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC047040 | overloaded x3
        public void Encode(){} // RVA: 0x7FFAFC0471E0
        public void GetEncoded(){} // RVA: 0x7FFAFC047280
        public void GeneratePublicKey(){} // RVA: 0x7FFAFC047330
        public void GenerateSecret(){} // RVA: 0x7FFAFC0473D0
        public void .cctor(){} // RVA: 0x7FFAFC047590
    }

    public class X448PublicKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC047710 | overloaded x2
        public void Encode(){} // RVA: 0x7FFAFC0478B0
        public void GetEncoded(){} // RVA: 0x7FFAFC047950
        public void .cctor(){} // RVA: 0x7FFAFC047A00
    }

}