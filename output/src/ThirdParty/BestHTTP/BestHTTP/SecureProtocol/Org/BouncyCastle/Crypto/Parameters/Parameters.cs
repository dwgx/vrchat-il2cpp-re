// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
// Classes: 78
// Methods: 431

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
    public class AeadParameters : .ctor
    {
        public byte[] associatedText; // 0x10
        public byte[] nonce; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95850E0 | overloaded x2
        public void get_Key(){} // RVA: 0x30B0C0
        public void get_MacSize(){} // RVA: 0x791DC0
        public void GetAssociatedText(){} // RVA: 0x2F8380
        public void GetNonce(){} // RVA: 0x2E07C0
    }

    public class CcmParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9585210
    }

    public class DHKeyGenerationParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters Parameters; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9585E60
        public void get_Parameters(){} // RVA: 0x30B0C0
        public void GetStrength(){} // RVA: 0x9585F20
    }

    public class DHKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters P; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier G; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9585FF0 | overloaded x2
        public void get_Parameters(){} // RVA: 0x2E07C0
        public void get_AlgorithmOid(){} // RVA: 0x30B0C0
        public void Equals(){} // RVA: 0x9586190 | overloaded x2
        public void GetHashCode(){} // RVA: 0x9586200
    }

    public class DHParameters
    {
        public int DefaultMinimumLength;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger p; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger g; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger j; // 0x28
        public int m; // 0x30
        public int l; // 0x34

        // ── Methods ──
        public void GetDefaultMParam(){} // RVA: 0x9586290
        public void .ctor(){} // RVA: 0x9586540 | overloaded x6
        public void get_P(){} // RVA: 0x2F8380
        public void get_G(){} // RVA: 0x2E07C0
        public void get_Q(){} // RVA: 0x30B0C0
        public void get_J(){} // RVA: 0x30B130
        public void get_M(){} // RVA: 0x338CD0
        public void get_L(){} // RVA: 0x4C6670
        public void get_ValidationParameters(){} // RVA: 0x4976A0
        public void Equals(){} // RVA: 0x9586B20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x9586BE0
    }

    public class DHPrivateKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Y; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9586CE0 | overloaded x2
        public void get_X(){} // RVA: 0x30B130
        public void Equals(){} // RVA: 0x9586E80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x9586F10
    }

    public class DHPublicKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger y; // 0x28

        // ── Methods ──
        public void Validate(){} // RVA: 0x9586F60
        public void .ctor(){} // RVA: 0x9587250 | overloaded x2
        public void get_Y(){} // RVA: 0x30B130
        public void Equals(){} // RVA: 0x9586E80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x9586F10
    }

    public class DHValidationParameters
    {
        public byte[] Parameters; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9587410
        public void GetSeed(){} // RVA: 0x9587570
        public void get_Counter(){} // RVA: 0x5BED50
        public void Equals(){} // RVA: 0x9587770 | overloaded x2
        public void GetHashCode(){} // RVA: 0x9587870
    }

    public class DesEdeParameters
    {
        // ── Methods ──
        public void FixKey(){} // RVA: 0x9585220
        public void .ctor(){} // RVA: 0x9585450 | overloaded x2
        public void IsWeakKey(){} // RVA: 0x95855B0 | overloaded x3
        public void IsRealEdeKey(){} // RVA: 0x95855E0
        public void IsReal2Key(){} // RVA: 0x9585720
        public void IsReal3Key(){} // RVA: 0x9585790
    }

    public class DesParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9585940 | overloaded x2
        public void IsWeakKey(){} // RVA: 0x9585B60 | overloaded x2
        public void SetOddParity(){} // RVA: 0x9585CB0 | overloaded x3
        public void .cctor(){} // RVA: 0x9585D80
    }

    public class DsaKeyGenerationParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DsaParameters Parameters; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9587920
        public void get_Parameters(){} // RVA: 0x30B0C0
    }

    public class DsaKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DsaParameters L; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BA57A0
        public void get_Parameters(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x9586190 | overloaded x2
        public void GetHashCode(){} // RVA: 0x9586200
    }

    public class DsaParameterGenerationParameters
    {
        public int DigitalSignatureUsage;
        public int KeyEstablishmentUsage;
        public int l; // 0x10
        public int n; // 0x14
        public int certainty; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9587B40 | overloaded x2
        public void get_L(){} // RVA: 0x32A5C0
        public void get_N(){} // RVA: 0x8ABED0
        public void get_UsageIndex(){} // RVA: 0x791DC0
        public void get_Certainty(){} // RVA: 0x5BED50
        public void get_Random(){} // RVA: 0x30B0C0
    }

    public class DsaParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger X; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger 5e=; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger g; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters validation; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9587D00 | overloaded x2
        public void get_P(){} // RVA: 0x2F8380
        public void get_Q(){} // RVA: 0x2E07C0
        public void get_G(){} // RVA: 0x30B0C0
        public void get_ValidationParameters(){} // RVA: 0x30B130
        public void Equals(){} // RVA: 0x9587F70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x9588010
    }

    public class DsaPrivateKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Y; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95880A0
        public void get_X(){} // RVA: 0x30B0C0
        public void Equals(){} // RVA: 0x95882E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x9588370
    }

    public class DsaPublicKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Counter; // 0x20

        // ── Methods ──
        public void Validate(){} // RVA: 0x95883C0
        public void .ctor(){} // RVA: 0x9588560
        public void get_Y(){} // RVA: 0x30B0C0
        public void Equals(){} // RVA: 0x95882E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x9588370
    }

    public class DsaValidationParameters
    {
        public byte[] seed; // 0x10
        public int counter; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9588950 | overloaded x2
        public void GetSeed(){} // RVA: 0x9588AB0
        public void get_Counter(){} // RVA: 0x5BED50
        public void get_UsageIndex(){} // RVA: 0x197C3B0
        public void Equals(){} // RVA: 0x9588BF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x9588CF0
    }

    public class ECDomainParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECCurve curve; // 0x10
        public byte[] seed; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint g; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger n; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger h; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95891B0 | overloaded x3
        public void get_Curve(){} // RVA: 0x2F8380
        public void get_G(){} // RVA: 0x30B0C0
        public void get_N(){} // RVA: 0x30B130
        public void get_H(){} // RVA: 0x6374D0
        public void get_HInv(){} // RVA: 0x9589370
        public void GetSeed(){} // RVA: 0x9589520
        public void Equals(){} // RVA: 0x9589690 | overloaded x2
        public void GetHashCode(){} // RVA: 0x9589730
        public void ValidatePrivateScalar(){} // RVA: 0x95897D0
        public void ValidatePublicPoint(){} // RVA: 0x9589930 | overloaded x2
    }

    public class ECGost3410Parameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier _publicKeyParamSet; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier _digestParamSet; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier _encryptionParamSet; // 0x58

        // ── Methods ──
        public void get_PublicKeyParamSet(){} // RVA: 0x358730
        public void get_DigestParamSet(){} // RVA: 0x37E0E0
        public void get_EncryptionParamSet(){} // RVA: 0x3A5500
        public void .ctor(){} // RVA: 0x9589C90 | overloaded x2
    }

    public class ECKeyGenerationParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECDomainParameters AlgorithmName; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Parameters; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9589EF0 | overloaded x2
        public void get_DomainParameters(){} // RVA: 0x30B0C0
        public void get_PublicKeyParamSet(){} // RVA: 0x30B130
    }

    public class ECKeyParameters
    {
        public string[] D;
        public string algorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECDomainParameters parameters; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x958A180 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x2E07C0
        public void get_Parameters(){} // RVA: 0x30B0C0
        public void get_PublicKeyParamSet(){} // RVA: 0x30B130
        public void Equals(){} // RVA: 0x958A460 | overloaded x2
        public void GetHashCode(){} // RVA: 0x958A4C0
        public void CreateKeyGenerationParameters(){} // RVA: 0x958A540
        public void VerifyAlgorithmName(){} // RVA: 0x958A680
        public void LookupParameters(){} // RVA: 0x958A7C0
        public void .cctor(){} // RVA: 0x958AAF0
    }

    public class ECNamedDomainParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier name; // 0x40

        // ── Methods ──
        public void get_Name(){} // RVA: 0x35A740
        public void .ctor(){} // RVA: 0x958AFE0 | overloaded x4
    }

    public class ECPrivateKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x958B460 | overloaded x4
        public void get_D(){} // RVA: 0x6374D0
        public void Equals(){} // RVA: 0x958B660 | overloaded x2
        public void GetHashCode(){} // RVA: 0x958B6F0
    }

    public class ECPublicKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint q; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x958B9A0 | overloaded x4
        public void get_Q(){} // RVA: 0x6374D0
        public void Equals(){} // RVA: 0x958BBA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x958B6F0
    }

    public class Ed25519KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x958BC30
    }

    public class Ed25519PrivateKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x958BF30 | overloaded x3
        public void Encode(){} // RVA: 0x958C0D0
        public void GetEncoded(){} // RVA: 0x958C170
        public void GeneratePublicKey(){} // RVA: 0x958C220
        public void Sign(){} // RVA: 0x958C2F0
        public void .cctor(){} // RVA: 0x958C770
    }

    public class Ed25519PublicKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x958C930 | overloaded x2
        public void Encode(){} // RVA: 0x958CAD0
        public void GetEncoded(){} // RVA: 0x958CB70
        public void .cctor(){} // RVA: 0x958CC20
    }

    public class Ed448KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x958CCA0
    }

    public class Ed448PrivateKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x958CFA0 | overloaded x3
        public void Encode(){} // RVA: 0x958D140
        public void GetEncoded(){} // RVA: 0x958D1E0
        public void GeneratePublicKey(){} // RVA: 0x958D290
        public void Sign(){} // RVA: 0x958D360
        public void .cctor(){} // RVA: 0x958D6E0
    }

    public class Ed448PublicKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x958D8A0 | overloaded x2
        public void Encode(){} // RVA: 0x958DA40
        public void GetEncoded(){} // RVA: 0x958DAE0
        public void .cctor(){} // RVA: 0x958DB90
    }

    public class ElGamalKeyGenerationParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ElGamalParameters Parameters; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x958DC10
        public void get_Parameters(){} // RVA: 0x30B0C0
        public void GetStrength(){} // RVA: 0x958DCD0
    }

    public class ElGamalKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ElGamalParameters P; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BA57A0
        public void get_Parameters(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x9586190 | overloaded x2
        public void GetHashCode(){} // RVA: 0x9586200
    }

    public class ElGamalParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger X; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger g; // 0x18
        public int l; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x958DF70 | overloaded x2
        public void get_P(){} // RVA: 0x2F8380
        public void get_G(){} // RVA: 0x2E07C0
        public void get_L(){} // RVA: 0x760030
        public void Equals(){} // RVA: 0x958E1F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x958E280
    }

    public class ElGamalPrivateKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Y; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x958E2E0
        public void get_X(){} // RVA: 0x30B0C0
        public void Equals(){} // RVA: 0x958E520 | overloaded x2
        public void GetHashCode(){} // RVA: 0x9588370
    }

    public class ElGamalPublicKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Parameters; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x958E5B0
        public void get_Y(){} // RVA: 0x30B0C0
        public void Equals(){} // RVA: 0x95882E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x9588370
    }

    public class Gost3410KeyGenerationParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters Parameters; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PublicKeyParamSet; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x958E7F0 | overloaded x2
        public void get_Parameters(){} // RVA: 0x30B0C0
        public void get_PublicKeyParamSet(){} // RVA: 0x30B130
        public void LookupParameters(){} // RVA: 0x958E920
    }

    public class Gost3410KeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters P; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Q; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x958EBE0 | overloaded x2
        public void get_Parameters(){} // RVA: 0x2E07C0
        public void get_PublicKeyParamSet(){} // RVA: 0x30B0C0
        public void LookupParameters(){} // RVA: 0x958ECC0
    }

    public class Gost3410Parameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger X; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger a; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Gost3410ValidationParameters validation; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x958F0C0 | overloaded x2
        public void get_P(){} // RVA: 0x2F8380
        public void get_Q(){} // RVA: 0x2E07C0
        public void get_A(){} // RVA: 0x30B0C0
        public void get_ValidationParameters(){} // RVA: 0x30B130
        public void Equals(){} // RVA: 0x9587F70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x9588010
    }

    public class Gost3410PrivateKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Y; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x958F450 | overloaded x2
        public void get_X(){} // RVA: 0x30B130
    }

    public class Gost3410PublicKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger C; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x958F680 | overloaded x2
        public void get_Y(){} // RVA: 0x30B130
    }

    public class Gost3410ValidationParameters
    {
        public int SkipExtract; // 0x10
        public int c; // 0x14
        public long x0L; // 0x18
        public long cL; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x958F780 | overloaded x2
        public void get_C(){} // RVA: 0x8ABED0
        public void get_X0(){} // RVA: 0x32A5C0
        public void get_CL(){} // RVA: 0x30B0C0
        public void get_X0L(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x958F790
        public void GetHashCode(){} // RVA: 0x958F850
    }

    public class HkdfParameters
    {
        public byte[] ikm; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x958FBC0 | overloaded x2
        public void SkipExtractParameters(){} // RVA: 0x958FBF0
        public void DefaultParameters(){} // RVA: 0x958FC70
        public void GetIkm(){} // RVA: 0x958FCE0
        public void get_SkipExtract(){} // RVA: 0x2F84E0
        public void GetSalt(){} // RVA: 0x958FD90
        public void GetInfo(){} // RVA: 0x958FE40
    }

    public class IesParameters
    {
        public byte[] CipherKeySize; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x28914C0
        public void GetDerivationV(){} // RVA: 0x2F8380
        public void GetEncodingV(){} // RVA: 0x2E07C0
        public void get_MacKeySize(){} // RVA: 0x760030
    }

    public class IesWithCipherParameters
    {
        public int cipherKeySize; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x958FEF0
        public void get_CipherKeySize(){} // RVA: 0x791DC0
    }

    public class Iso18033KdfParameters : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetSeed(){} // RVA: 0x2F8380
    }

    public class KdfCounterParameters
    {
        public byte[] Ki; // 0x10
        public byte[] UseCounter; // 0x18
        public byte[] R; // 0x20
        public int FixedInputData; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x958FFE0 | overloaded x2
        public void get_Ki(){} // RVA: 0x2F8380
        public void get_FixedInputData(){} // RVA: 0x9590420
        public void get_FixedInputDataCounterPrefix(){} // RVA: 0x95904D0
        public void get_FixedInputDataCounterSuffix(){} // RVA: 0x9590580
        public void get_R(){} // RVA: 0x791DC0
    }

    public class KdfDoublePipelineIterationParameters
    {
        public int Ki;
        public byte[] Iv; // 0x10
        public bool UseCounter; // 0x18
        public int R; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9590630
        public void CreateWithCounter(){} // RVA: 0x9590950
        public void CreateWithoutCounter(){} // RVA: 0x95909E0
        public void get_Ki(){} // RVA: 0x9590A80
        public void get_UseCounter(){} // RVA: 0x2F84E0
        public void get_R(){} // RVA: 0x197C3B0
        public void get_FixedInputData(){} // RVA: 0x9590B30
        public void .cctor(){} // RVA: 0x9590BE0
    }

    public class KdfFeedbackParameters
    {
        public int UNUSED_R;
        public byte[] ki; // 0x10
        public byte[] iv; // 0x18
        public bool useCounter; // 0x20
        public int r; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9590C20
        public void CreateWithCounter(){} // RVA: 0x9591010
        public void CreateWithoutCounter(){} // RVA: 0x9591100
        public void get_Ki(){} // RVA: 0x95911C0
        public void get_Iv(){} // RVA: 0x9591270
        public void get_UseCounter(){} // RVA: 0x3CB9D0
        public void get_R(){} // RVA: 0xCEF5B0
        public void get_FixedInputData(){} // RVA: 0x9591320
        public void .cctor(){} // RVA: 0x95913D0
    }

    public class KdfParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CCCD00
        public void GetSharedSecret(){} // RVA: 0x2E07C0
        public void GetIV(){} // RVA: 0x2F8380
    }

    public class KeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9591550 | overloaded x2
        public void GetKey(){} // RVA: 0x95916F0
    }

    public class MgfParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9591850 | overloaded x2
        public void GetSeed(){} // RVA: 0x9591930
    }

    public class MqvPrivateParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters staticPrivateKey; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters ephemeralPrivateKey; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters ephemeralPublicKey; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95919D0 | overloaded x2
        public void get_StaticPrivateKey(){} // RVA: 0x2F8380
        public void get_EphemeralPrivateKey(){} // RVA: 0x2E07C0
        public void get_EphemeralPublicKey(){} // RVA: 0x30B0C0
    }

    public class MqvPublicParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters staticPublicKey; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters ephemeralPublicKey; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9591C50
        public void get_StaticPublicKey(){} // RVA: 0x2F8380
        public void get_EphemeralPublicKey(){} // RVA: 0x2E07C0
    }

    public class NaccacheSternKeyGenerationParameters
    {
        public int G; // 0x20
        public int LowerSigmaBound; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9591DB0 | overloaded x2
        public void get_Certainty(){} // RVA: 0x760030
        public void get_CountSmallPrimes(){} // RVA: 0xCEF5B0
        public void get_IsDebug(){} // RVA: 0x2DD320
    }

    public class NaccacheSternKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger PhiN; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger SmallPrimes; // 0x20
        public int SmallPrimesList; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9591E90
        public void get_G(){} // RVA: 0x2E07C0
        public void get_LowerSigmaBound(){} // RVA: 0x791DC0
        public void get_Modulus(){} // RVA: 0x30B0C0
    }

    public class NaccacheSternPrivateKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Parameters; // 0x30
        public System.Collections.IList smallPrimes; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9591F50 | overloaded x2
        public void get_PhiN(){} // RVA: 0x6374D0
        public void get_SmallPrimes(){} // RVA: 0x9592030
        public void get_SmallPrimesList(){} // RVA: 0x4976A0
    }

    public class ParametersWithID
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ICipherParameters Parameters; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95921D0 | overloaded x2
        public void GetID(){} // RVA: 0x2E07C0
        public void get_Parameters(){} // RVA: 0x2F8380
    }

    public class ParametersWithIV
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ICipherParameters Random; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9592330 | overloaded x2
        public void GetIV(){} // RVA: 0x95924C0
        public void get_Parameters(){} // RVA: 0x2F8380
    }

    public class ParametersWithRandom
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ICipherParameters Parameters; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95926B0 | overloaded x2
        public void GetRandom(){} // RVA: 0x2E07C0
        public void get_Random(){} // RVA: 0x2E07C0
        public void get_Parameters(){} // RVA: 0x2F8380
    }

    public class ParametersWithSBox
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ICipherParameters EffectiveKeyBits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void GetSBox(){} // RVA: 0x2E07C0
        public void get_Parameters(){} // RVA: 0x2F8380
    }

    public class ParametersWithSalt
    {
        public byte[] Parameters; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9592870 | overloaded x2
        public void GetSalt(){} // RVA: 0x2F8380
        public void get_Parameters(){} // RVA: 0x2E07C0
    }

    public class RC2Parameters
    {
        public int Rounds; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9592A60 | overloaded x4
        public void get_EffectiveKeyBits(){} // RVA: 0x5BED50
    }

    public class RC5Parameters
    {
        public int PublicKey; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9592A90
        public void get_Rounds(){} // RVA: 0x5BED50
    }

    public class RsaBlindingParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters PublicExponent; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Certainty; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9592B20
        public void get_PublicKey(){} // RVA: 0x2F8380
        public void get_BlindingFactor(){} // RVA: 0x2E07C0
    }

    public class RsaKeyGenerationParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Modulus; // 0x20
        public int Exponent; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9592C50
        public void get_PublicExponent(){} // RVA: 0x30B0C0
        public void get_Certainty(){} // RVA: 0x791DC0
        public void Equals(){} // RVA: 0x9592CE0
        public void GetHashCode(){} // RVA: 0x9592DA0
    }

    public class RsaKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger PublicExponent;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger P; // 0x18

        // ── Methods ──
        public void Validate(){} // RVA: 0x9592DE0
        public void .ctor(){} // RVA: 0x9592FB0
        public void get_Modulus(){} // RVA: 0x2E07C0
        public void get_Exponent(){} // RVA: 0x30B0C0
        public void Equals(){} // RVA: 0x9593230
        public void GetHashCode(){} // RVA: 0x9593330
        public void .cctor(){} // RVA: 0x95933E0
    }

    public class RsaPrivateCrtKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger e; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger p; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger dP; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger dQ; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger qInv; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9593C90 | overloaded x2
        public void get_PublicExponent(){} // RVA: 0x30B130
        public void get_P(){} // RVA: 0x6374D0
        public void get_Q(){} // RVA: 0x4976A0
        public void get_DP(){} // RVA: 0x35A740
        public void get_DQ(){} // RVA: 0x358730
        public void get_QInv(){} // RVA: 0x37E0E0
        public void Equals(){} // RVA: 0x9593CF0
        public void GetHashCode(){} // RVA: 0x9593F00
        public void ValidateValue(){} // RVA: 0x9594070
    }

    public class SM2KeyExchangePrivateParameters : .ctor
    {
        public bool mInitiator; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters mStaticPrivateKey; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint mStaticPublicPoint; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters mEphemeralPrivateKey; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint mEphemeralPublicPoint; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9595BC0
        public void get_IsInitiator(){} // RVA: 0x3A75E0
        public void get_StaticPrivateKey(){} // RVA: 0x2E07C0
        public void get_StaticPublicPoint(){} // RVA: 0x30B0C0
        public void get_EphemeralPrivateKey(){} // RVA: 0x30B130
        public void get_EphemeralPublicPoint(){} // RVA: 0x6374D0
    }

    public class SM2KeyExchangePublicParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters mStaticPublicKey; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters mEphemeralPublicKey; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9595E10
        public void get_StaticPublicKey(){} // RVA: 0x2F8380
        public void get_EphemeralPublicKey(){} // RVA: 0x2E07C0
    }

    public class SkeinParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void GetParameters(){} // RVA: 0x2F8380
        public void GetKey(){} // RVA: 0x9594220
        public void GetPersonalisation(){} // RVA: 0x9594380
        public void GetPublicKey(){} // RVA: 0x9594450
        public void GetKeyIdentifier(){} // RVA: 0x9594520
        public void GetNonce(){} // RVA: 0x95945F0
    }

    public class Srp6GroupParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Key; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Tweak; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void get_G(){} // RVA: 0x2E07C0
        public void get_N(){} // RVA: 0x2F8380
    }

    public class TweakableBlockCipherParameters
    {
        public byte[] tweak; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.KeyParameter key; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9595F70
        public void get_Key(){} // RVA: 0x2E07C0
        public void get_Tweak(){} // RVA: 0x2F8380
    }

    public class X25519KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95960F0
    }

    public class X25519PrivateKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9596400 | overloaded x3
        public void Encode(){} // RVA: 0x95965A0
        public void GetEncoded(){} // RVA: 0x9596640
        public void GeneratePublicKey(){} // RVA: 0x95966F0
        public void GenerateSecret(){} // RVA: 0x9596790
        public void .cctor(){} // RVA: 0x9596950
    }

    public class X25519PublicKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9596AD0 | overloaded x2
        public void Encode(){} // RVA: 0x9596C70
        public void GetEncoded(){} // RVA: 0x9596D10
        public void .cctor(){} // RVA: 0x9596DC0
    }

    public class X448KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x958CCA0
    }

    public class X448PrivateKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9597040 | overloaded x3
        public void Encode(){} // RVA: 0x95971E0
        public void GetEncoded(){} // RVA: 0x9597280
        public void GeneratePublicKey(){} // RVA: 0x9597330
        public void GenerateSecret(){} // RVA: 0x95973D0
        public void .cctor(){} // RVA: 0x9597590
    }

    public class X448PublicKeyParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9597710 | overloaded x2
        public void Encode(){} // RVA: 0x95978B0
        public void GetEncoded(){} // RVA: 0x9597950
        public void .cctor(){} // RVA: 0x9597A00
    }

}