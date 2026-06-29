// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
// Classes: 78
// Methods: 343

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
    public class AeadParameters : Object
    {
        public object associatedText;
        public object nonce;
        public object key;
        public object macSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA226FC0
        public void get_Key(){} // RVA: 0xB700F0
        public void get_MacSize(){} // RVA: 0x1065D50
        public void GetAssociatedText(){} // RVA: 0xB5DBF0
        public void GetNonce(){} // RVA: 0xB465B0
    }

    public class CcmParameters : AeadParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2270F0
    }

    public class DHKeyGenerationParameters : KeyGenerationParameters
    {
        public object parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA227D70
        public void get_Parameters(){} // RVA: 0xB700F0
        public void GetStrength(){} // RVA: 0xA227E30
    }

    public class DHKeyParameters : AsymmetricKeyParameter
    {
        public object parameters;
        public object algorithmOid;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA227F00
        public void get_Parameters(){} // RVA: 0xB465B0
        public void get_AlgorithmOid(){} // RVA: 0xB700F0
        public void Equals(){} // RVA: 0xA228080
        public void GetHashCode(){} // RVA: 0xA2280F0
    }

    public class DHParameters : Object
    {
        public object DefaultMinimumLength;
        public object p;
        public object g;
        public object q;
        public object j;
        public object m;
        public object l;
        public object validation;

        // ── Methods ──
        public void GetDefaultMParam(){} // RVA: 0xA228160
        public void .ctor(){} // RVA: 0xA228410
        public void get_P(){} // RVA: 0xB5DBF0
        public void get_G(){} // RVA: 0xB465B0
        public void get_Q(){} // RVA: 0xB700F0
        public void get_J(){} // RVA: 0xB70160
        public void get_M(){} // RVA: 0xB9E080
        public void get_L(){} // RVA: 0xE9CE60
        public void get_ValidationParameters(){} // RVA: 0xD05CA0
        public void Equals(){} // RVA: 0xA2289E0
        public void GetHashCode(){} // RVA: 0xA228AA0
    }

    public class DHPrivateKeyParameters : DHKeyParameters
    {
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA228BA0
        public void get_X(){} // RVA: 0xB70160
        public void Equals(){} // RVA: 0xA228D20
        public void GetHashCode(){} // RVA: 0xA228DB0
    }

    public class DHPublicKeyParameters : DHKeyParameters
    {
        public object y;

        // ── Methods ──
        public void Validate(){} // RVA: 0xA228E40
        public void .ctor(){} // RVA: 0xA229130
        public void get_Y(){} // RVA: 0xB70160
        public void Equals(){} // RVA: 0xA228D20
        public void GetHashCode(){} // RVA: 0xA228DB0
    }

    public class DHValidationParameters : Object
    {
        public object seed;
        public object counter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2292D0
        public void GetSeed(){} // RVA: 0xA229430
        public void get_Counter(){} // RVA: 0xE62D00
        public void Equals(){} // RVA: 0xA229610
        public void GetHashCode(){} // RVA: 0xA229720
    }

    public class DesEdeParameters : DesParameters
    {
        public object DesEdeKeyLength;

        // ── Methods ──
        public void FixKey(){} // RVA: 0xA227100
        public void .ctor(){} // RVA: 0xA227330
        public void IsWeakKey(){} // RVA: 0xA227490
        public void IsRealEdeKey(){} // RVA: 0xA2274C0
        public void IsReal2Key(){} // RVA: 0xA2275F0
        public void IsReal3Key(){} // RVA: 0xA227660
    }

    public class DesParameters : KeyParameter
    {
        public object DesKeyLength;
        public object N_DES_WEAK_KEYS;
        public object DES_weak_keys;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA227800
        public void IsWeakKey(){} // RVA: 0xA227A60
        public void SetOddParity(){} // RVA: 0xA227BB0
        public void .cctor(){} // RVA: 0xA227C90
    }

    public class DsaKeyGenerationParameters : KeyGenerationParameters
    {
        public object parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2297D0
        public void get_Parameters(){} // RVA: 0xB700F0
    }

    public class DsaKeyParameters : AsymmetricKeyParameter
    {
        public object parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x661E600
        public void get_Parameters(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0xA228080
        public void GetHashCode(){} // RVA: 0xA2280F0
    }

    public class DsaParameterGenerationParameters : Object
    {
        public object DigitalSignatureUsage;
        public object KeyEstablishmentUsage;
        public object l;
        public object n;
        public object certainty;
        public object random;
        public object usageIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2299D0
        public void get_L(){} // RVA: 0xB8F8F0
        public void get_N(){} // RVA: 0x116A650
        public void get_UsageIndex(){} // RVA: 0x1065D50
        public void get_Certainty(){} // RVA: 0xE62D00
        public void get_Random(){} // RVA: 0xB700F0
    }

    public class DsaParameters : Object
    {
        public object p;
        public object q;
        public object g;
        public object validation;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA229B90
        public void get_P(){} // RVA: 0xB5DBF0
        public void get_Q(){} // RVA: 0xB465B0
        public void get_G(){} // RVA: 0xB700F0
        public void get_ValidationParameters(){} // RVA: 0xB70160
        public void Equals(){} // RVA: 0xA229DE0
        public void GetHashCode(){} // RVA: 0xA229E80
    }

    public class DsaPrivateKeyParameters : DsaKeyParameters
    {
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA229F10
        public void get_X(){} // RVA: 0xB700F0
        public void Equals(){} // RVA: 0xA22A130
        public void GetHashCode(){} // RVA: 0xA22A1C0
    }

    public class DsaPublicKeyParameters : DsaKeyParameters
    {
        public object y;

        // ── Methods ──
        public void Validate(){} // RVA: 0xA22A250
        public void .ctor(){} // RVA: 0xA22A3F0
        public void get_Y(){} // RVA: 0xB700F0
        public void Equals(){} // RVA: 0xA22A130
        public void GetHashCode(){} // RVA: 0xA22A1C0
    }

    public class DsaValidationParameters : Object
    {
        public object seed;
        public object counter;
        public object usageIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA22A7C0
        public void GetSeed(){} // RVA: 0xA22A930
        public void get_Counter(){} // RVA: 0xE62D00
        public void get_UsageIndex(){} // RVA: 0x2244FB0
        public void Equals(){} // RVA: 0xA22AA60
        public void GetHashCode(){} // RVA: 0xA22AB70
    }

    public class ECDomainParameters : Object
    {
        public object curve;
        public object seed;
        public object g;
        public object n;
        public object h;
        public object hInv;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA22B030
        public void get_Curve(){} // RVA: 0xB5DBF0
        public void get_G(){} // RVA: 0xB700F0
        public void get_N(){} // RVA: 0xB70160
        public void get_H(){} // RVA: 0xD33E60
        public void get_HInv(){} // RVA: 0xA22B1F0
        public void GetSeed(){} // RVA: 0xA22B370
        public void Equals(){} // RVA: 0xA22B4D0
        public void GetHashCode(){} // RVA: 0xA22B570
        public void ValidatePrivateScalar(){} // RVA: 0xA22B610
        public void ValidatePublicPoint(){} // RVA: 0xA22B770
    }

    public class ECGost3410Parameters : ECNamedDomainParameters
    {
        public object _publicKeyParamSet;
        public object _digestParamSet;
        public object _encryptionParamSet;

        // ── Methods ──
        public void get_PublicKeyParamSet(){} // RVA: 0xBBF8F0
        public void get_DigestParamSet(){} // RVA: 0xBE58B0
        public void get_EncryptionParamSet(){} // RVA: 0xC0FFC0
        public void .ctor(){} // RVA: 0xA22BAD0
    }

    public class ECKeyGenerationParameters : KeyGenerationParameters
    {
        public object domainParams;
        public object publicKeyParamSet;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA22BD30
        public void get_DomainParameters(){} // RVA: 0xB700F0
        public void get_PublicKeyParamSet(){} // RVA: 0xB70160
    }

    public class ECKeyParameters : AsymmetricKeyParameter
    {
        public object algorithms;
        public object algorithm;
        public object parameters;
        public object publicKeyParamSet;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA22BFC0
        public void get_AlgorithmName(){} // RVA: 0xB465B0
        public void get_Parameters(){} // RVA: 0xB700F0
        public void get_PublicKeyParamSet(){} // RVA: 0xB70160
        public void Equals(){} // RVA: 0xA22C290
        public void GetHashCode(){} // RVA: 0xA22C2F0
        public void CreateKeyGenerationParameters(){} // RVA: 0xA22C350
        public void VerifyAlgorithmName(){} // RVA: 0xA22C490
        public void LookupParameters(){} // RVA: 0xA22C5D0
        public void .cctor(){} // RVA: 0xA22C900
    }

    public class ECNamedDomainParameters : ECDomainParameters
    {
        public object name;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xBC1B30
        public void .ctor(){} // RVA: 0xA22CDF0
    }

    public class ECPrivateKeyParameters : ECKeyParameters
    {
        public object d;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA22D270
        public void get_D(){} // RVA: 0xD33E60
        public void Equals(){} // RVA: 0xA22D450
        public void GetHashCode(){} // RVA: 0xA22D4E0
    }

    public class ECPublicKeyParameters : ECKeyParameters
    {
        public object q;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA22D7D0
        public void get_Q(){} // RVA: 0xD33E60
        public void Equals(){} // RVA: 0xA22D9B0
        public void GetHashCode(){} // RVA: 0xA22D4E0
    }

    public class Ed25519KeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA22DA40
    }

    public class Ed25519PrivateKeyParameters : AsymmetricKeyParameter
    {
        public object KeySize;
        public object SignatureSize;
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA22DD40
        public void Encode(){} // RVA: 0xA22DF00
        public void GetEncoded(){} // RVA: 0xA22DFA0
        public void GeneratePublicKey(){} // RVA: 0xA22E050
        public void Sign(){} // RVA: 0xA22E120
        public void .cctor(){} // RVA: 0xA22E5A0
    }

    public class Ed25519PublicKeyParameters : AsymmetricKeyParameter
    {
        public object KeySize;
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA22E760
        public void Encode(){} // RVA: 0xA22E920
        public void GetEncoded(){} // RVA: 0xA22E9C0
        public void .cctor(){} // RVA: 0xA22EA70
    }

    public class Ed448KeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA22EAF0
    }

    public class Ed448PrivateKeyParameters : AsymmetricKeyParameter
    {
        public object KeySize;
        public object SignatureSize;
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA22EDF0
        public void Encode(){} // RVA: 0xA22EFB0
        public void GetEncoded(){} // RVA: 0xA22F050
        public void GeneratePublicKey(){} // RVA: 0xA22F100
        public void Sign(){} // RVA: 0xA22F1D0
        public void .cctor(){} // RVA: 0xA22F550
    }

    public class Ed448PublicKeyParameters : AsymmetricKeyParameter
    {
        public object KeySize;
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA22F710
        public void Encode(){} // RVA: 0xA22F8D0
        public void GetEncoded(){} // RVA: 0xA22F970
        public void .cctor(){} // RVA: 0xA22FA20
    }

    public class ElGamalKeyGenerationParameters : KeyGenerationParameters
    {
        public object parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA22FAA0
        public void get_Parameters(){} // RVA: 0xB700F0
        public void GetStrength(){} // RVA: 0xA22FB60
    }

    public class ElGamalKeyParameters : AsymmetricKeyParameter
    {
        public object parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x661E600
        public void get_Parameters(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0xA228080
        public void GetHashCode(){} // RVA: 0xA2280F0
    }

    public class ElGamalParameters : Object
    {
        public object p;
        public object g;
        public object l;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA22FDE0
        public void get_P(){} // RVA: 0xB5DBF0
        public void get_G(){} // RVA: 0xB465B0
        public void get_L(){} // RVA: 0xFEAE90
        public void Equals(){} // RVA: 0xA230040
        public void GetHashCode(){} // RVA: 0xA2300D0
    }

    public class ElGamalPrivateKeyParameters : ElGamalKeyParameters
    {
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA230130
        public void get_X(){} // RVA: 0xB700F0
        public void Equals(){} // RVA: 0xA230350
        public void GetHashCode(){} // RVA: 0xA22A1C0
    }

    public class ElGamalPublicKeyParameters : ElGamalKeyParameters
    {
        public object y;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2303E0
        public void get_Y(){} // RVA: 0xB700F0
        public void Equals(){} // RVA: 0xA22A130
        public void GetHashCode(){} // RVA: 0xA22A1C0
    }

    public class Gost3410KeyGenerationParameters : KeyGenerationParameters
    {
        public object parameters;
        public object publicKeyParamSet;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA230600
        public void get_Parameters(){} // RVA: 0xB700F0
        public void get_PublicKeyParamSet(){} // RVA: 0xB70160
        public void LookupParameters(){} // RVA: 0xA230730
    }

    public class Gost3410KeyParameters : AsymmetricKeyParameter
    {
        public object parameters;
        public object publicKeyParamSet;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2309F0
        public void get_Parameters(){} // RVA: 0xB465B0
        public void get_PublicKeyParamSet(){} // RVA: 0xB700F0
        public void LookupParameters(){} // RVA: 0xA230AD0
    }

    public class Gost3410Parameters : Object
    {
        public object p;
        public object q;
        public object a;
        public object validation;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA230ED0
        public void get_P(){} // RVA: 0xB5DBF0
        public void get_Q(){} // RVA: 0xB465B0
        public void get_A(){} // RVA: 0xB700F0
        public void get_ValidationParameters(){} // RVA: 0xB70160
        public void Equals(){} // RVA: 0xA229DE0
        public void GetHashCode(){} // RVA: 0xA229E80
    }

    public class Gost3410PrivateKeyParameters : Gost3410KeyParameters
    {
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA231240
        public void get_X(){} // RVA: 0xB70160
    }

    public class Gost3410PublicKeyParameters : Gost3410KeyParameters
    {
        public object y;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA231470
        public void get_Y(){} // RVA: 0xB70160
    }

    public class Gost3410ValidationParameters : Object
    {
        public object x0;
        public object c;
        public object x0L;
        public object cL;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA231570
        public void get_C(){} // RVA: 0x116A650
        public void get_X0(){} // RVA: 0xB8F8F0
        public void get_CL(){} // RVA: 0xB700F0
        public void get_X0L(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0xA231580
        public void GetHashCode(){} // RVA: 0xA231620
    }

    public class HkdfParameters : Object
    {
        public object ikm;
        public object skipExpand;
        public object salt;
        public object info;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2319A0
        public void SkipExtractParameters(){} // RVA: 0xA2319D0
        public void DefaultParameters(){} // RVA: 0xA231A50
        public void GetIkm(){} // RVA: 0xA231AC0
        public void get_SkipExtract(){} // RVA: 0xB5DD50
        public void GetSalt(){} // RVA: 0xA231B70
        public void GetInfo(){} // RVA: 0xA231C20
    }

    public class IesParameters : Object
    {
        public object derivation;
        public object encoding;
        public object macKeySize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x31D5D40
        public void GetDerivationV(){} // RVA: 0xB5DBF0
        public void GetEncodingV(){} // RVA: 0xB465B0
        public void get_MacKeySize(){} // RVA: 0xFEAE90
    }

    public class IesWithCipherParameters : IesParameters
    {
        public object cipherKeySize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA231CD0
        public void get_CipherKeySize(){} // RVA: 0x1065D50
    }

    public class Iso18033KdfParameters : Object
    {
        public object seed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetSeed(){} // RVA: 0xB5DBF0
    }

    public class KdfCounterParameters : Object
    {
        public object ki;
        public object fixedInputDataCounterPrefix;
        public object fixedInputDataCounterSuffix;
        public object r;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA231DC0
        public void get_Ki(){} // RVA: 0xB5DBF0
        public void get_FixedInputData(){} // RVA: 0xA232220
        public void get_FixedInputDataCounterPrefix(){} // RVA: 0xA2322D0
        public void get_FixedInputDataCounterSuffix(){} // RVA: 0xA232380
        public void get_R(){} // RVA: 0x1065D50
    }

    public class KdfDoublePipelineIterationParameters : Object
    {
        public object UNUSED_R;
        public object ki;
        public object useCounter;
        public object r;
        public object fixedInputData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA232430
        public void CreateWithCounter(){} // RVA: 0xA232760
        public void CreateWithoutCounter(){} // RVA: 0xA2327F0
        public void get_Ki(){} // RVA: 0xA232890
        public void get_UseCounter(){} // RVA: 0xB5DD50
        public void get_R(){} // RVA: 0x2244FB0
        public void get_FixedInputData(){} // RVA: 0xA232940
        public void .cctor(){} // RVA: 0xA2329F0
    }

    public class KdfFeedbackParameters : Object
    {
        public object UNUSED_R;
        public object ki;
        public object iv;
        public object useCounter;
        public object r;
        public object fixedInputData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA232A30
        public void CreateWithCounter(){} // RVA: 0xA232E30
        public void CreateWithoutCounter(){} // RVA: 0xA232F20
        public void get_Ki(){} // RVA: 0xA232FE0
        public void get_Iv(){} // RVA: 0xA233090
        public void get_UseCounter(){} // RVA: 0xC38360
        public void get_R(){} // RVA: 0x15AF000
        public void get_FixedInputData(){} // RVA: 0xA233140
        public void .cctor(){} // RVA: 0xA2331F0
    }

    public class KdfParameters : Object
    {
        public object iv;
        public object shared;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67462E0
        public void GetSharedSecret(){} // RVA: 0xB465B0
        public void GetIV(){} // RVA: 0xB5DBF0
    }

    public class KeyParameter : Object
    {
        public object key;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA233370
        public void GetKey(){} // RVA: 0xA233510
    }

    public class MgfParameters : Object
    {
        public object seed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA233670
        public void GetSeed(){} // RVA: 0xA233750
    }

    public class MqvPrivateParameters : Object
    {
        public object staticPrivateKey;
        public object ephemeralPrivateKey;
        public object ephemeralPublicKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2337F0
        public void get_StaticPrivateKey(){} // RVA: 0xB5DBF0
        public void get_EphemeralPrivateKey(){} // RVA: 0xB465B0
        public void get_EphemeralPublicKey(){} // RVA: 0xB700F0
    }

    public class MqvPublicParameters : Object
    {
        public object staticPublicKey;
        public object ephemeralPublicKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA233A70
        public void get_StaticPublicKey(){} // RVA: 0xB5DBF0
        public void get_EphemeralPublicKey(){} // RVA: 0xB465B0
    }

    public class NaccacheSternKeyGenerationParameters : KeyGenerationParameters
    {
        public object certainty;
        public object countSmallPrimes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA233BD0
        public void get_Certainty(){} // RVA: 0xFEAE90
        public void get_CountSmallPrimes(){} // RVA: 0x15AF000
        public void get_IsDebug(){} // RVA: 0xB43320
    }

    public class NaccacheSternKeyParameters : AsymmetricKeyParameter
    {
        public object g;
        public object n;
        public object lowerSigmaBound;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA233CB0
        public void get_G(){} // RVA: 0xB465B0
        public void get_LowerSigmaBound(){} // RVA: 0x1065D50
        public void get_Modulus(){} // RVA: 0xB700F0
    }

    public class NaccacheSternPrivateKeyParameters : NaccacheSternKeyParameters
    {
        public object phiN;
        public object smallPrimes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA233D70
        public void get_PhiN(){} // RVA: 0xD33E60
        public void get_SmallPrimes(){} // RVA: 0xA233E50
        public void get_SmallPrimesList(){} // RVA: 0xD05CA0
    }

    public class ParametersWithID : Object
    {
        public object parameters;
        public object id;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA233FF0
        public void GetID(){} // RVA: 0xB465B0
        public void get_Parameters(){} // RVA: 0xB5DBF0
    }

    public class ParametersWithIV : Object
    {
        public object parameters;
        public object iv;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA234150
        public void GetIV(){} // RVA: 0xA2342E0
        public void get_Parameters(){} // RVA: 0xB5DBF0
    }

    public class ParametersWithRandom : Object
    {
        public object parameters;
        public object random;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2344D0
        public void GetRandom(){} // RVA: 0xB465B0
        public void get_Random(){} // RVA: 0xB465B0
        public void get_Parameters(){} // RVA: 0xB5DBF0
    }

    public class ParametersWithSBox : Object
    {
        public object parameters;
        public object sBox;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void GetSBox(){} // RVA: 0xB465B0
        public void get_Parameters(){} // RVA: 0xB5DBF0
    }

    public class ParametersWithSalt : Object
    {
        public object salt;
        public object parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2347D0
        public void GetSalt(){} // RVA: 0xB5DBF0
        public void get_Parameters(){} // RVA: 0xB465B0
    }

    public class RC2Parameters : KeyParameter
    {
        public object bits;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2349E0
        public void get_EffectiveKeyBits(){} // RVA: 0xE62D00
    }

    public class RC5Parameters : KeyParameter
    {
        public object rounds;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA234A10
        public void get_Rounds(){} // RVA: 0xE62D00
    }

    public class RsaBlindingParameters : Object
    {
        public object publicKey;
        public object blindingFactor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA234AA0
        public void get_PublicKey(){} // RVA: 0xB5DBF0
        public void get_BlindingFactor(){} // RVA: 0xB465B0
    }

    public class RsaKeyGenerationParameters : KeyGenerationParameters
    {
        public object publicExponent;
        public object certainty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA234BD0
        public void get_PublicExponent(){} // RVA: 0xB700F0
        public void get_Certainty(){} // RVA: 0x1065D50
        public void Equals(){} // RVA: 0xA234C60
        public void GetHashCode(){} // RVA: 0xA234D10
    }

    public class RsaKeyParameters : AsymmetricKeyParameter
    {
        public object SmallPrimesProduct;
        public object modulus;
        public object exponent;

        // ── Methods ──
        public void Validate(){} // RVA: 0xA234D50
        public void .ctor(){} // RVA: 0xA234F20
        public void get_Modulus(){} // RVA: 0xB465B0
        public void get_Exponent(){} // RVA: 0xB700F0
        public void Equals(){} // RVA: 0xA2351A0
        public void GetHashCode(){} // RVA: 0xA235270
        public void .cctor(){} // RVA: 0xA235300
    }

    public class RsaPrivateCrtKeyParameters : RsaKeyParameters
    {
        public object e;
        public object p;
        public object q;
        public object dP;
        public object dQ;
        public object qInv;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA235BB0
        public void get_PublicExponent(){} // RVA: 0xB70160
        public void get_P(){} // RVA: 0xD33E60
        public void get_Q(){} // RVA: 0xD05CA0
        public void get_DP(){} // RVA: 0xBC1B30
        public void get_DQ(){} // RVA: 0xBBF8F0
        public void get_QInv(){} // RVA: 0xBE58B0
        public void Equals(){} // RVA: 0xA235C10
        public void GetHashCode(){} // RVA: 0xA235E00
        public void ValidateValue(){} // RVA: 0xA235F70
    }

    public class SM2KeyExchangePrivateParameters : Object
    {
        public object mInitiator;
        public object mStaticPrivateKey;
        public object mStaticPublicPoint;
        public object mEphemeralPrivateKey;
        public object mEphemeralPublicPoint;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2379D0
        public void get_IsInitiator(){} // RVA: 0xC120A0
        public void get_StaticPrivateKey(){} // RVA: 0xB465B0
        public void get_StaticPublicPoint(){} // RVA: 0xB700F0
        public void get_EphemeralPrivateKey(){} // RVA: 0xB70160
        public void get_EphemeralPublicPoint(){} // RVA: 0xD33E60
    }

    public class SM2KeyExchangePublicParameters : Object
    {
        public object mStaticPublicKey;
        public object mEphemeralPublicKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA237C20
        public void get_StaticPublicKey(){} // RVA: 0xB5DBF0
        public void get_EphemeralPublicKey(){} // RVA: 0xB465B0
    }

    public class SkeinParameters : Object
    {
        public object PARAM_TYPE_KEY;
        public object PARAM_TYPE_CONFIG;
        public object PARAM_TYPE_PERSONALISATION;
        public object PARAM_TYPE_PUBLIC_KEY;
        public object PARAM_TYPE_KEY_IDENTIFIER;
        public object PARAM_TYPE_NONCE;
        public object PARAM_TYPE_MESSAGE;
        public object PARAM_TYPE_OUTPUT;
        public object parameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetParameters(){} // RVA: 0xB5DBF0
        public void GetKey(){} // RVA: 0xA236120
        public void GetPersonalisation(){} // RVA: 0xA236270
        public void GetPublicKey(){} // RVA: 0xA236330
        public void GetKeyIdentifier(){} // RVA: 0xA2363F0
        public void GetNonce(){} // RVA: 0xA2364B0
    }

    public class Srp6GroupParameters : Object
    {
        public object n;
        public object g;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_G(){} // RVA: 0xB465B0
        public void get_N(){} // RVA: 0xB5DBF0
    }

    public class TweakableBlockCipherParameters : Object
    {
        public object tweak;
        public object key;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA237D80
        public void get_Key(){} // RVA: 0xB465B0
        public void get_Tweak(){} // RVA: 0xB5DBF0
    }

    public class X25519KeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA237F00
    }

    public class X25519PrivateKeyParameters : AsymmetricKeyParameter
    {
        public object KeySize;
        public object SecretSize;
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA238210
        public void Encode(){} // RVA: 0xA2383D0
        public void GetEncoded(){} // RVA: 0xA238470
        public void GeneratePublicKey(){} // RVA: 0xA238520
        public void GenerateSecret(){} // RVA: 0xA2385C0
        public void .cctor(){} // RVA: 0xA238780
    }

    public class X25519PublicKeyParameters : AsymmetricKeyParameter
    {
        public object KeySize;
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA238900
        public void Encode(){} // RVA: 0xA238AC0
        public void GetEncoded(){} // RVA: 0xA238B60
        public void .cctor(){} // RVA: 0xA238C10
    }

    public class X448KeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA22EAF0
    }

    public class X448PrivateKeyParameters : AsymmetricKeyParameter
    {
        public object KeySize;
        public object SecretSize;
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA238E90
        public void Encode(){} // RVA: 0xA239050
        public void GetEncoded(){} // RVA: 0xA2390F0
        public void GeneratePublicKey(){} // RVA: 0xA2391A0
        public void GenerateSecret(){} // RVA: 0xA239340
        public void .cctor(){} // RVA: 0xA239500
    }

    public class X448PublicKeyParameters : AsymmetricKeyParameter
    {
        public object KeySize;
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA239680
        public void Encode(){} // RVA: 0xA239840
        public void GetEncoded(){} // RVA: 0xA2398E0
        public void .cctor(){} // RVA: 0xA239990
    }

}