// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
// Classes: 78
// Methods: 343

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
    public class AeadParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13BB950
        public void get_Key(){} // RVA: 0x7A81052C0
        public void get_MacSize(){} // RVA: 0x7A854FDE0
        public void GetAssociatedText(){} // RVA: 0x7A80F2570
        public void GetNonce(){} // RVA: 0x7A80DA7B0
    }

    public class CcmParameters : AeadParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13BBA80
    }

    public class DHKeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13BC700
        public void get_Parameters(){} // RVA: 0x7A81052C0
        public void GetStrength(){} // RVA: 0x7B13BC7C0
    }

    public class DHKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13BC890
        public void get_Parameters(){} // RVA: 0x7A80DA7B0
        public void get_AlgorithmOid(){} // RVA: 0x7A81052C0
        public void Equals(){} // RVA: 0x7B13BCA10
        public void GetHashCode(){} // RVA: 0x7B13BCA80
    }

    public class DHParameters : Object
    {
        // ── Methods ──
        public void GetDefaultMParam(){} // RVA: 0x7B13BCB10
        public void .ctor(){} // RVA: 0x7B13BCDC0
        public void get_P(){} // RVA: 0x7A80F2570
        public void get_G(){} // RVA: 0x7A80DA7B0
        public void get_Q(){} // RVA: 0x7A81052C0
        public void get_J(){} // RVA: 0x7A8105330
        public void get_M(){} // RVA: 0x7A8133100
        public void get_L(){} // RVA: 0x7A82C2070
        public void get_ValidationParameters(){} // RVA: 0x7A8292C30
        public void Equals(){} // RVA: 0x7B13BD390
        public void GetHashCode(){} // RVA: 0x7B13BD450
    }

    public class DHPrivateKeyParameters : DHKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13BD550
        public void get_X(){} // RVA: 0x7A8105330
        public void Equals(){} // RVA: 0x7B13BD6D0
        public void GetHashCode(){} // RVA: 0x7B13BD760
    }

    public class DHPublicKeyParameters : DHKeyParameters
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x7B13BD7B0
        public void .ctor(){} // RVA: 0x7B13BDAA0
        public void get_Y(){} // RVA: 0x7A8105330
        public void Equals(){} // RVA: 0x7B13BD6D0
        public void GetHashCode(){} // RVA: 0x7B13BD760
    }

    public class DHValidationParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13BDC40
        public void GetSeed(){} // RVA: 0x7B13BDDA0
        public void get_Counter(){} // RVA: 0x7A83782A0
        public void Equals(){} // RVA: 0x7B13BDF80
        public void GetHashCode(){} // RVA: 0x7B13BE090
    }

    public class DesEdeParameters : DesParameters
    {
        // ── Methods ──
        public void FixKey(){} // RVA: 0x7B13BBA90
        public void .ctor(){} // RVA: 0x7B13BBCC0
        public void IsWeakKey(){} // RVA: 0x7B13BBE20
        public void IsRealEdeKey(){} // RVA: 0x7B13BBE50
        public void IsReal2Key(){} // RVA: 0x7B13BBF80
        public void IsReal3Key(){} // RVA: 0x7B13BBFF0
    }

    public class DesParameters : KeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13BC190
        public void IsWeakKey(){} // RVA: 0x7B13BC3F0
        public void SetOddParity(){} // RVA: 0x7B13BC540
        public void .cctor(){} // RVA: 0x7B13BC620
    }

    public class DsaKeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13BE140
        public void get_Parameters(){} // RVA: 0x7A81052C0
    }

    public class DsaKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD993240
        public void get_Parameters(){} // RVA: 0x7A80DA7B0
        public void Equals(){} // RVA: 0x7B13BCA10
        public void GetHashCode(){} // RVA: 0x7B13BCA80
    }

    public class DsaParameterGenerationParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13BE340
        public void get_L(){} // RVA: 0x7A8124910
        public void get_N(){} // RVA: 0x7A8668BC0
        public void get_UsageIndex(){} // RVA: 0x7A854FDE0
        public void get_Certainty(){} // RVA: 0x7A83782A0
        public void get_Random(){} // RVA: 0x7A81052C0
    }

    public class DsaParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13BE500
        public void get_P(){} // RVA: 0x7A80F2570
        public void get_Q(){} // RVA: 0x7A80DA7B0
        public void get_G(){} // RVA: 0x7A81052C0
        public void get_ValidationParameters(){} // RVA: 0x7A8105330
        public void Equals(){} // RVA: 0x7B13BE750
        public void GetHashCode(){} // RVA: 0x7B13BE7F0
    }

    public class DsaPrivateKeyParameters : DsaKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13BE880
        public void get_X(){} // RVA: 0x7A81052C0
        public void Equals(){} // RVA: 0x7B13BEAA0
        public void GetHashCode(){} // RVA: 0x7B13BEB30
    }

    public class DsaPublicKeyParameters : DsaKeyParameters
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x7B13BEB80
        public void .ctor(){} // RVA: 0x7B13BED20
        public void get_Y(){} // RVA: 0x7A81052C0
        public void Equals(){} // RVA: 0x7B13BEAA0
        public void GetHashCode(){} // RVA: 0x7B13BEB30
    }

    public class DsaValidationParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13BF0F0
        public void GetSeed(){} // RVA: 0x7B13BF260
        public void get_Counter(){} // RVA: 0x7A83782A0
        public void get_UsageIndex(){} // RVA: 0x7A9739200
        public void Equals(){} // RVA: 0x7B13BF390
        public void GetHashCode(){} // RVA: 0x7B13BF4A0
    }

    public class ECDomainParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13BF960
        public void get_Curve(){} // RVA: 0x7A80F2570
        public void get_G(){} // RVA: 0x7A81052C0
        public void get_N(){} // RVA: 0x7A8105330
        public void get_H(){} // RVA: 0x7A83F69F0
        public void get_HInv(){} // RVA: 0x7B13BFB20
        public void GetSeed(){} // RVA: 0x7B13BFCA0
        public void Equals(){} // RVA: 0x7B13BFE00
        public void GetHashCode(){} // RVA: 0x7B13BFEA0
        public void ValidatePrivateScalar(){} // RVA: 0x7B13BFF40
        public void ValidatePublicPoint(){} // RVA: 0x7B13C00A0
    }

    public class ECGost3410Parameters : ECNamedDomainParameters
    {
        // ── Methods ──
        public void get_PublicKeyParamSet(){} // RVA: 0x7A8152D80
        public void get_DigestParamSet(){} // RVA: 0x7A8178B90
        public void get_EncryptionParamSet(){} // RVA: 0x7A81A0050
        public void .ctor(){} // RVA: 0x7B13C0400
    }

    public class ECKeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C0660
        public void get_DomainParameters(){} // RVA: 0x7A81052C0
        public void get_PublicKeyParamSet(){} // RVA: 0x7A8105330
    }

    public class ECKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C08F0
        public void get_AlgorithmName(){} // RVA: 0x7A80DA7B0
        public void get_Parameters(){} // RVA: 0x7A81052C0
        public void get_PublicKeyParamSet(){} // RVA: 0x7A8105330
        public void Equals(){} // RVA: 0x7B13C0BC0
        public void GetHashCode(){} // RVA: 0x7B13C0C20
        public void CreateKeyGenerationParameters(){} // RVA: 0x7B13C0CA0
        public void VerifyAlgorithmName(){} // RVA: 0x7B13C0DE0
        public void LookupParameters(){} // RVA: 0x7B13C0F20
        public void .cctor(){} // RVA: 0x7B13C1250
    }

    public class ECNamedDomainParameters : ECDomainParameters
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A8154D80
        public void .ctor(){} // RVA: 0x7B13C1740
    }

    public class ECPrivateKeyParameters : ECKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C1BC0
        public void get_D(){} // RVA: 0x7A83F69F0
        public void Equals(){} // RVA: 0x7B13C1DA0
        public void GetHashCode(){} // RVA: 0x7B13C1E30
    }

    public class ECPublicKeyParameters : ECKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C20E0
        public void get_Q(){} // RVA: 0x7A83F69F0
        public void Equals(){} // RVA: 0x7B13C22C0
        public void GetHashCode(){} // RVA: 0x7B13C1E30
    }

    public class Ed25519KeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C2350
    }

    public class Ed25519PrivateKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C2650
        public void Encode(){} // RVA: 0x7B13C2810
        public void GetEncoded(){} // RVA: 0x7B13C28B0
        public void GeneratePublicKey(){} // RVA: 0x7B13C2960
        public void Sign(){} // RVA: 0x7B13C2A30
        public void .cctor(){} // RVA: 0x7B13C2EB0
    }

    public class Ed25519PublicKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C3070
        public void Encode(){} // RVA: 0x7B13C3230
        public void GetEncoded(){} // RVA: 0x7B13C32D0
        public void .cctor(){} // RVA: 0x7B13C3380
    }

    public class Ed448KeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C3400
    }

    public class Ed448PrivateKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C3700
        public void Encode(){} // RVA: 0x7B13C38C0
        public void GetEncoded(){} // RVA: 0x7B13C3960
        public void GeneratePublicKey(){} // RVA: 0x7B13C3A10
        public void Sign(){} // RVA: 0x7B13C3AE0
        public void .cctor(){} // RVA: 0x7B13C3E60
    }

    public class Ed448PublicKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C4020
        public void Encode(){} // RVA: 0x7B13C41E0
        public void GetEncoded(){} // RVA: 0x7B13C4280
        public void .cctor(){} // RVA: 0x7B13C4330
    }

    public class ElGamalKeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C43B0
        public void get_Parameters(){} // RVA: 0x7A81052C0
        public void GetStrength(){} // RVA: 0x7B13C4470
    }

    public class ElGamalKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD993240
        public void get_Parameters(){} // RVA: 0x7A80DA7B0
        public void Equals(){} // RVA: 0x7B13BCA10
        public void GetHashCode(){} // RVA: 0x7B13BCA80
    }

    public class ElGamalParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C46F0
        public void get_P(){} // RVA: 0x7A80F2570
        public void get_G(){} // RVA: 0x7A80DA7B0
        public void get_L(){} // RVA: 0x7A851DB90
        public void Equals(){} // RVA: 0x7B13C4950
        public void GetHashCode(){} // RVA: 0x7B13C49E0
    }

    public class ElGamalPrivateKeyParameters : ElGamalKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C4A40
        public void get_X(){} // RVA: 0x7A81052C0
        public void Equals(){} // RVA: 0x7B13C4C60
        public void GetHashCode(){} // RVA: 0x7B13BEB30
    }

    public class ElGamalPublicKeyParameters : ElGamalKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C4CF0
        public void get_Y(){} // RVA: 0x7A81052C0
        public void Equals(){} // RVA: 0x7B13BEAA0
        public void GetHashCode(){} // RVA: 0x7B13BEB30
    }

    public class Gost3410KeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C4F10
        public void get_Parameters(){} // RVA: 0x7A81052C0
        public void get_PublicKeyParamSet(){} // RVA: 0x7A8105330
        public void LookupParameters(){} // RVA: 0x7B13C5040
    }

    public class Gost3410KeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C5300
        public void get_Parameters(){} // RVA: 0x7A80DA7B0
        public void get_PublicKeyParamSet(){} // RVA: 0x7A81052C0
        public void LookupParameters(){} // RVA: 0x7B13C53E0
    }

    public class Gost3410Parameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C57E0
        public void get_P(){} // RVA: 0x7A80F2570
        public void get_Q(){} // RVA: 0x7A80DA7B0
        public void get_A(){} // RVA: 0x7A81052C0
        public void get_ValidationParameters(){} // RVA: 0x7A8105330
        public void Equals(){} // RVA: 0x7B13BE750
        public void GetHashCode(){} // RVA: 0x7B13BE7F0
    }

    public class Gost3410PrivateKeyParameters : Gost3410KeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C5B50
        public void get_X(){} // RVA: 0x7A8105330
    }

    public class Gost3410PublicKeyParameters : Gost3410KeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C5D80
        public void get_Y(){} // RVA: 0x7A8105330
    }

    public class Gost3410ValidationParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C5E80
        public void get_C(){} // RVA: 0x7A8668BC0
        public void get_X0(){} // RVA: 0x7A8124910
        public void get_CL(){} // RVA: 0x7A81052C0
        public void get_X0L(){} // RVA: 0x7A80DA7B0
        public void Equals(){} // RVA: 0x7B13C5E90
        public void GetHashCode(){} // RVA: 0x7B13C5F30
    }

    public class HkdfParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C62B0
        public void SkipExtractParameters(){} // RVA: 0x7B13C62E0
        public void DefaultParameters(){} // RVA: 0x7B13C6360
        public void GetIkm(){} // RVA: 0x7B13C63D0
        public void get_SkipExtract(){} // RVA: 0x7A80F26D0
        public void GetSalt(){} // RVA: 0x7B13C6480
        public void GetInfo(){} // RVA: 0x7B13C6530
    }

    public class IesParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA69B920
        public void GetDerivationV(){} // RVA: 0x7A80F2570
        public void GetEncodingV(){} // RVA: 0x7A80DA7B0
        public void get_MacKeySize(){} // RVA: 0x7A851DB90
    }

    public class IesWithCipherParameters : IesParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C65E0
        public void get_CipherKeySize(){} // RVA: 0x7A854FDE0
    }

    public class Iso18033KdfParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetSeed(){} // RVA: 0x7A80F2570
    }

    public class KdfCounterParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C66D0
        public void get_Ki(){} // RVA: 0x7A80F2570
        public void get_FixedInputData(){} // RVA: 0x7B13C6B30
        public void get_FixedInputDataCounterPrefix(){} // RVA: 0x7B13C6BE0
        public void get_FixedInputDataCounterSuffix(){} // RVA: 0x7B13C6C90
        public void get_R(){} // RVA: 0x7A854FDE0
    }

    public class KdfDoublePipelineIterationParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C6D40
        public void CreateWithCounter(){} // RVA: 0x7B13C7070
        public void CreateWithoutCounter(){} // RVA: 0x7B13C7100
        public void get_Ki(){} // RVA: 0x7B13C71A0
        public void get_UseCounter(){} // RVA: 0x7A80F26D0
        public void get_R(){} // RVA: 0x7A9739200
        public void get_FixedInputData(){} // RVA: 0x7B13C7250
        public void .cctor(){} // RVA: 0x7B13C7300
    }

    public class KdfFeedbackParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C7340
        public void CreateWithCounter(){} // RVA: 0x7B13C7740
        public void CreateWithoutCounter(){} // RVA: 0x7B13C7830
        public void get_Ki(){} // RVA: 0x7B13C78F0
        public void get_Iv(){} // RVA: 0x7B13C79A0
        public void get_UseCounter(){} // RVA: 0x7A81C68D0
        public void get_R(){} // RVA: 0x7A8AB15F0
        public void get_FixedInputData(){} // RVA: 0x7B13C7A50
        public void .cctor(){} // RVA: 0x7B13C7B00
    }

    public class KdfParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADABAF10
        public void GetSharedSecret(){} // RVA: 0x7A80DA7B0
        public void GetIV(){} // RVA: 0x7A80F2570
    }

    public class KeyParameter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C7C80
        public void GetKey(){} // RVA: 0x7B13C7E20
    }

    public class MgfParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C7F80
        public void GetSeed(){} // RVA: 0x7B13C8060
    }

    public class MqvPrivateParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C8100
        public void get_StaticPrivateKey(){} // RVA: 0x7A80F2570
        public void get_EphemeralPrivateKey(){} // RVA: 0x7A80DA7B0
        public void get_EphemeralPublicKey(){} // RVA: 0x7A81052C0
    }

    public class MqvPublicParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C8380
        public void get_StaticPublicKey(){} // RVA: 0x7A80F2570
        public void get_EphemeralPublicKey(){} // RVA: 0x7A80DA7B0
    }

    public class NaccacheSternKeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C84E0
        public void get_Certainty(){} // RVA: 0x7A851DB90
        public void get_CountSmallPrimes(){} // RVA: 0x7A8AB15F0
        public void get_IsDebug(){} // RVA: 0x7A80D7320
    }

    public class NaccacheSternKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C85C0
        public void get_G(){} // RVA: 0x7A80DA7B0
        public void get_LowerSigmaBound(){} // RVA: 0x7A854FDE0
        public void get_Modulus(){} // RVA: 0x7A81052C0
    }

    public class NaccacheSternPrivateKeyParameters : NaccacheSternKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C8680
        public void get_PhiN(){} // RVA: 0x7A83F69F0
        public void get_SmallPrimes(){} // RVA: 0x7B13C8760
        public void get_SmallPrimesList(){} // RVA: 0x7A8292C30
    }

    public class ParametersWithID : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C8900
        public void GetID(){} // RVA: 0x7A80DA7B0
        public void get_Parameters(){} // RVA: 0x7A80F2570
    }

    public class ParametersWithIV : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C8A60
        public void GetIV(){} // RVA: 0x7B13C8BF0
        public void get_Parameters(){} // RVA: 0x7A80F2570
    }

    public class ParametersWithRandom : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C8DE0
        public void GetRandom(){} // RVA: 0x7A80DA7B0
        public void get_Random(){} // RVA: 0x7A80DA7B0
        public void get_Parameters(){} // RVA: 0x7A80F2570
    }

    public class ParametersWithSBox : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void GetSBox(){} // RVA: 0x7A80DA7B0
        public void get_Parameters(){} // RVA: 0x7A80F2570
    }

    public class ParametersWithSalt : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C90E0
        public void GetSalt(){} // RVA: 0x7A80F2570
        public void get_Parameters(){} // RVA: 0x7A80DA7B0
    }

    public class RC2Parameters : KeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C92F0
        public void get_EffectiveKeyBits(){} // RVA: 0x7A83782A0
    }

    public class RC5Parameters : KeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C9320
        public void get_Rounds(){} // RVA: 0x7A83782A0
    }

    public class RsaBlindingParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C93B0
        public void get_PublicKey(){} // RVA: 0x7A80F2570
        public void get_BlindingFactor(){} // RVA: 0x7A80DA7B0
    }

    public class RsaKeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C94E0
        public void get_PublicExponent(){} // RVA: 0x7A81052C0
        public void get_Certainty(){} // RVA: 0x7A854FDE0
        public void Equals(){} // RVA: 0x7B13C9570
        public void GetHashCode(){} // RVA: 0x7B13C9620
    }

    public class RsaKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x7B13C9660
        public void .ctor(){} // RVA: 0x7B13C9830
        public void get_Modulus(){} // RVA: 0x7A80DA7B0
        public void get_Exponent(){} // RVA: 0x7A81052C0
        public void Equals(){} // RVA: 0x7B13C9AB0
        public void GetHashCode(){} // RVA: 0x7B13C9B80
        public void .cctor(){} // RVA: 0x7B13C9C30
    }

    public class RsaPrivateCrtKeyParameters : RsaKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13CA4E0
        public void get_PublicExponent(){} // RVA: 0x7A8105330
        public void get_P(){} // RVA: 0x7A83F69F0
        public void get_Q(){} // RVA: 0x7A8292C30
        public void get_DP(){} // RVA: 0x7A8154D80
        public void get_DQ(){} // RVA: 0x7A8152D80
        public void get_QInv(){} // RVA: 0x7A8178B90
        public void Equals(){} // RVA: 0x7B13CA540
        public void GetHashCode(){} // RVA: 0x7B13CA730
        public void ValidateValue(){} // RVA: 0x7B13CA8A0
    }

    public class SM2KeyExchangePrivateParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13CC3E0
        public void get_IsInitiator(){} // RVA: 0x7A81A2200
        public void get_StaticPrivateKey(){} // RVA: 0x7A80DA7B0
        public void get_StaticPublicPoint(){} // RVA: 0x7A81052C0
        public void get_EphemeralPrivateKey(){} // RVA: 0x7A8105330
        public void get_EphemeralPublicPoint(){} // RVA: 0x7A83F69F0
    }

    public class SM2KeyExchangePublicParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13CC630
        public void get_StaticPublicKey(){} // RVA: 0x7A80F2570
        public void get_EphemeralPublicKey(){} // RVA: 0x7A80DA7B0
    }

    public class SkeinParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetParameters(){} // RVA: 0x7A80F2570
        public void GetKey(){} // RVA: 0x7B13CAA50
        public void GetPersonalisation(){} // RVA: 0x7B13CABB0
        public void GetPublicKey(){} // RVA: 0x7B13CAC80
        public void GetKeyIdentifier(){} // RVA: 0x7B13CAD50
        public void GetNonce(){} // RVA: 0x7B13CAE20
    }

    public class Srp6GroupParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_G(){} // RVA: 0x7A80DA7B0
        public void get_N(){} // RVA: 0x7A80F2570
    }

    public class TweakableBlockCipherParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13CC790
        public void get_Key(){} // RVA: 0x7A80DA7B0
        public void get_Tweak(){} // RVA: 0x7A80F2570
    }

    public class X25519KeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13CC910
    }

    public class X25519PrivateKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13CCC20
        public void Encode(){} // RVA: 0x7B13CCDE0
        public void GetEncoded(){} // RVA: 0x7B13CCE80
        public void GeneratePublicKey(){} // RVA: 0x7B13CCF30
        public void GenerateSecret(){} // RVA: 0x7B13CCFD0
        public void .cctor(){} // RVA: 0x7B13CD190
    }

    public class X25519PublicKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13CD310
        public void Encode(){} // RVA: 0x7B13CD4D0
        public void GetEncoded(){} // RVA: 0x7B13CD570
        public void .cctor(){} // RVA: 0x7B13CD620
    }

    public class X448KeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13C3400
    }

    public class X448PrivateKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13CD8A0
        public void Encode(){} // RVA: 0x7B13CDA60
        public void GetEncoded(){} // RVA: 0x7B13CDB00
        public void GeneratePublicKey(){} // RVA: 0x7B13CDBB0
        public void GenerateSecret(){} // RVA: 0x7B13CDD50
        public void .cctor(){} // RVA: 0x7B13CDF10
    }

    public class X448PublicKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13CE090
        public void Encode(){} // RVA: 0x7B13CE250
        public void GetEncoded(){} // RVA: 0x7B13CE2F0
        public void .cctor(){} // RVA: 0x7B13CE3A0
    }

}