// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
// Classes: 78
// Methods: 431

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
    public class AeadParameters : Object
    {
        public byte[] associatedText; // 0x10
        public byte[] nonce; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FE74B0 | overloaded x2
        public void get_Key(){} // RVA: 0x7FFE811290C0
        public void get_MacSize(){} // RVA: 0x7FFE81549710
        public void GetAssociatedText(){} // RVA: 0x7FFE81116380
        public void GetNonce(){} // RVA: 0x7FFE810FE7C0
    }

    public class CcmParameters : AeadParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FE75E0
    }

    public class DHKeyGenerationParameters : KeyGenerationParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters parameters; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FE8230
        public void get_Parameters(){} // RVA: 0x7FFE811290C0
        public void GetStrength(){} // RVA: 0x7FFE89FE82F0
    }

    public class DHKeyParameters : AsymmetricKeyParameter
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters parameters; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier algorithmOid; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FE83C0 | overloaded x2
        public void get_Parameters(){} // RVA: 0x7FFE810FE7C0
        public void get_AlgorithmOid(){} // RVA: 0x7FFE811290C0
        public void Equals(){} // RVA: 0x7FFE89FE8560 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE89FE85D0
    }

    public class DHParameters : Object
    {
        public int DefaultMinimumLength;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger p; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger g; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger j; // 0x28
        public int m; // 0x30
        public int l; // 0x34

        // ── Methods ──
        public void GetDefaultMParam(){} // RVA: 0x7FFE89FE8660
        public void .ctor(){} // RVA: 0x7FFE89FE8910 | overloaded x6
        public void get_P(){} // RVA: 0x7FFE81116380
        public void get_G(){} // RVA: 0x7FFE810FE7C0
        public void get_Q(){} // RVA: 0x7FFE811290C0
        public void get_J(){} // RVA: 0x7FFE81129130
        public void get_M(){} // RVA: 0x7FFE81156CD0
        public void get_L(){} // RVA: 0x7FFE82447220
        public void get_ValidationParameters(){} // RVA: 0x7FFE8143BA80
        public void Equals(){} // RVA: 0x7FFE89FE8EF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE89FE8FB0
    }

    public class DHPrivateKeyParameters : DHKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger x; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FE90B0 | overloaded x2
        public void get_X(){} // RVA: 0x7FFE81129130
        public void Equals(){} // RVA: 0x7FFE89FE9250 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE89FE92E0
    }

    public class DHPublicKeyParameters : DHKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger y; // 0x28

        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFE89FE9330
        public void .ctor(){} // RVA: 0x7FFE89FE9620 | overloaded x2
        public void get_Y(){} // RVA: 0x7FFE81129130
        public void Equals(){} // RVA: 0x7FFE89FE9250 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE89FE92E0
    }

    public class DHValidationParameters : Object
    {
        public byte[] seed; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FE97E0
        public void GetSeed(){} // RVA: 0x7FFE89FE9940
        public void get_Counter(){} // RVA: 0x7FFE813DB630
        public void Equals(){} // RVA: 0x7FFE89FE9B40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE89FE9C40
    }

    public class DesEdeParameters : DesParameters
    {
        // ── Methods ──
        public void FixKey(){} // RVA: 0x7FFE89FE75F0
        public void .ctor(){} // RVA: 0x7FFE89FE7820 | overloaded x2
        public void IsWeakKey(){} // RVA: 0x7FFE89FE7980 | overloaded x3
        public void IsRealEdeKey(){} // RVA: 0x7FFE89FE79B0
        public void IsReal2Key(){} // RVA: 0x7FFE89FE7AF0
        public void IsReal3Key(){} // RVA: 0x7FFE89FE7B60
    }

    public class DesParameters : KeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FE7D10 | overloaded x2
        public void IsWeakKey(){} // RVA: 0x7FFE89FE7F30 | overloaded x2
        public void SetOddParity(){} // RVA: 0x7FFE89FE8080 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFE89FE8150
    }

    public class DsaKeyGenerationParameters : KeyGenerationParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DsaParameters parameters; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FE9CF0
        public void get_Parameters(){} // RVA: 0x7FFE811290C0
    }

    public class DsaKeyParameters : AsymmetricKeyParameter
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DsaParameters parameters; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866E65F0
        public void get_Parameters(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE89FE8560 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE89FE85D0
    }

    public class DsaParameterGenerationParameters : Object
    {
        public int DigitalSignatureUsage;
        public int KeyEstablishmentUsage;
        public int l; // 0x10
        public int n; // 0x14
        public int certainty; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FE9F10 | overloaded x2
        public void get_L(){} // RVA: 0x7FFE811485C0
        public void get_N(){} // RVA: 0x7FFE8164B230
        public void get_UsageIndex(){} // RVA: 0x7FFE81549710
        public void get_Certainty(){} // RVA: 0x7FFE813DB630
        public void get_Random(){} // RVA: 0x7FFE811290C0
    }

    public class DsaParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger p; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger g; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters validation; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FEA0D0 | overloaded x2
        public void get_P(){} // RVA: 0x7FFE81116380
        public void get_Q(){} // RVA: 0x7FFE810FE7C0
        public void get_G(){} // RVA: 0x7FFE811290C0
        public void get_ValidationParameters(){} // RVA: 0x7FFE81129130
        public void Equals(){} // RVA: 0x7FFE89FEA340 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE89FEA3E0
    }

    public class DsaPrivateKeyParameters : DsaKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger x; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FEA470
        public void get_X(){} // RVA: 0x7FFE811290C0
        public void Equals(){} // RVA: 0x7FFE89FEA6B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE89FEA740
    }

    public class DsaPublicKeyParameters : DsaKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger y; // 0x20

        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFE89FEA790
        public void .ctor(){} // RVA: 0x7FFE89FEA930
        public void get_Y(){} // RVA: 0x7FFE811290C0
        public void Equals(){} // RVA: 0x7FFE89FEA6B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE89FEA740
    }

    public class DsaValidationParameters : Object
    {
        public byte[] seed; // 0x10
        public int counter; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FEAD20 | overloaded x2
        public void GetSeed(){} // RVA: 0x7FFE89FEAE80
        public void get_Counter(){} // RVA: 0x7FFE813DB630
        public void get_UsageIndex(){} // RVA: 0x7FFE82707EE0
        public void Equals(){} // RVA: 0x7FFE89FEAFC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE89FEB0C0
    }

    public class ECDomainParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECCurve curve; // 0x10
        public byte[] seed; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint g; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger n; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger h; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FEB580 | overloaded x3
        public void get_Curve(){} // RVA: 0x7FFE81116380
        public void get_G(){} // RVA: 0x7FFE811290C0
        public void get_N(){} // RVA: 0x7FFE81129130
        public void get_H(){} // RVA: 0x7FFE8144E200
        public void get_HInv(){} // RVA: 0x7FFE89FEB740
        public void GetSeed(){} // RVA: 0x7FFE89FEB8F0
        public void Equals(){} // RVA: 0x7FFE89FEBA60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE89FEBB00
        public void ValidatePrivateScalar(){} // RVA: 0x7FFE89FEBBA0
        public void ValidatePublicPoint(){} // RVA: 0x7FFE89FEBD00 | overloaded x2
    }

    public class ECGost3410Parameters : ECNamedDomainParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier _publicKeyParamSet; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier _digestParamSet; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier _encryptionParamSet; // 0x58

        // ── Methods ──
        public void get_PublicKeyParamSet(){} // RVA: 0x7FFE81176730
        public void get_DigestParamSet(){} // RVA: 0x7FFE8119C0E0
        public void get_EncryptionParamSet(){} // RVA: 0x7FFE811C3500
        public void .ctor(){} // RVA: 0x7FFE89FEC060 | overloaded x2
    }

    public class ECKeyGenerationParameters : KeyGenerationParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECDomainParameters domainParams; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FEC2C0 | overloaded x2
        public void get_DomainParameters(){} // RVA: 0x7FFE811290C0
        public void get_PublicKeyParamSet(){} // RVA: 0x7FFE81129130
    }

    public class ECKeyParameters : AsymmetricKeyParameter
    {
        public string[] algorithms;
        public string algorithm; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECDomainParameters parameters; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FEC550 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE810FE7C0
        public void get_Parameters(){} // RVA: 0x7FFE811290C0
        public void get_PublicKeyParamSet(){} // RVA: 0x7FFE81129130
        public void Equals(){} // RVA: 0x7FFE89FEC830 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE89FEC890
        public void CreateKeyGenerationParameters(){} // RVA: 0x7FFE89FEC910
        public void VerifyAlgorithmName(){} // RVA: 0x7FFE89FECA50
        public void LookupParameters(){} // RVA: 0x7FFE89FECB90
        public void .cctor(){} // RVA: 0x7FFE89FECEC0
    }

    public class ECNamedDomainParameters : ECDomainParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier name; // 0x40

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81178740
        public void .ctor(){} // RVA: 0x7FFE89FED3B0 | overloaded x4
    }

    public class ECPrivateKeyParameters : ECKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger d; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FED830 | overloaded x4
        public void get_D(){} // RVA: 0x7FFE8144E200
        public void Equals(){} // RVA: 0x7FFE89FEDA30 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE89FEDAC0
    }

    public class ECPublicKeyParameters : ECKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint q; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FEDD70 | overloaded x4
        public void get_Q(){} // RVA: 0x7FFE8144E200
        public void Equals(){} // RVA: 0x7FFE89FEDF70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE89FEDAC0
    }

    public class Ed25519KeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FEE000
    }

    public class Ed25519PrivateKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FEE300 | overloaded x3
        public void Encode(){} // RVA: 0x7FFE89FEE4A0
        public void GetEncoded(){} // RVA: 0x7FFE89FEE540
        public void GeneratePublicKey(){} // RVA: 0x7FFE89FEE5F0
        public void Sign(){} // RVA: 0x7FFE89FEE6C0
        public void .cctor(){} // RVA: 0x7FFE89FEEB40
    }

    public class Ed25519PublicKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FEED00 | overloaded x2
        public void Encode(){} // RVA: 0x7FFE89FEEEA0
        public void GetEncoded(){} // RVA: 0x7FFE89FEEF40
        public void .cctor(){} // RVA: 0x7FFE89FEEFF0
    }

    public class Ed448KeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FEF070
    }

    public class Ed448PrivateKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FEF370 | overloaded x3
        public void Encode(){} // RVA: 0x7FFE89FEF510
        public void GetEncoded(){} // RVA: 0x7FFE89FEF5B0
        public void GeneratePublicKey(){} // RVA: 0x7FFE89FEF660
        public void Sign(){} // RVA: 0x7FFE89FEF730
        public void .cctor(){} // RVA: 0x7FFE89FEFAB0
    }

    public class Ed448PublicKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FEFC70 | overloaded x2
        public void Encode(){} // RVA: 0x7FFE89FEFE10
        public void GetEncoded(){} // RVA: 0x7FFE89FEFEB0
        public void .cctor(){} // RVA: 0x7FFE89FEFF60
    }

    public class ElGamalKeyGenerationParameters : KeyGenerationParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ElGamalParameters parameters; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FEFFE0
        public void get_Parameters(){} // RVA: 0x7FFE811290C0
        public void GetStrength(){} // RVA: 0x7FFE89FF00A0
    }

    public class ElGamalKeyParameters : AsymmetricKeyParameter
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ElGamalParameters parameters; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866E65F0
        public void get_Parameters(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE89FE8560 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE89FE85D0
    }

    public class ElGamalParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger p; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger g; // 0x18
        public int l; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF0340 | overloaded x2
        public void get_P(){} // RVA: 0x7FFE81116380
        public void get_G(){} // RVA: 0x7FFE810FE7C0
        public void get_L(){} // RVA: 0x7FFE8151D690
        public void Equals(){} // RVA: 0x7FFE89FF05C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE89FF0650
    }

    public class ElGamalPrivateKeyParameters : ElGamalKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger x; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF06B0
        public void get_X(){} // RVA: 0x7FFE811290C0
        public void Equals(){} // RVA: 0x7FFE89FF08F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE89FEA740
    }

    public class ElGamalPublicKeyParameters : ElGamalKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger y; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF0980
        public void get_Y(){} // RVA: 0x7FFE811290C0
        public void Equals(){} // RVA: 0x7FFE89FEA6B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE89FEA740
    }

    public class Gost3410KeyGenerationParameters : KeyGenerationParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters parameters; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF0BC0 | overloaded x2
        public void get_Parameters(){} // RVA: 0x7FFE811290C0
        public void get_PublicKeyParamSet(){} // RVA: 0x7FFE81129130
        public void LookupParameters(){} // RVA: 0x7FFE89FF0CF0
    }

    public class Gost3410KeyParameters : AsymmetricKeyParameter
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters parameters; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF0FB0 | overloaded x2
        public void get_Parameters(){} // RVA: 0x7FFE810FE7C0
        public void get_PublicKeyParamSet(){} // RVA: 0x7FFE811290C0
        public void LookupParameters(){} // RVA: 0x7FFE89FF1090
    }

    public class Gost3410Parameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger p; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger a; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Gost3410ValidationParameters validation; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF1490 | overloaded x2
        public void get_P(){} // RVA: 0x7FFE81116380
        public void get_Q(){} // RVA: 0x7FFE810FE7C0
        public void get_A(){} // RVA: 0x7FFE811290C0
        public void get_ValidationParameters(){} // RVA: 0x7FFE81129130
        public void Equals(){} // RVA: 0x7FFE89FEA340 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE89FEA3E0
    }

    public class Gost3410PrivateKeyParameters : Gost3410KeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger x; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF1820 | overloaded x2
        public void get_X(){} // RVA: 0x7FFE81129130
    }

    public class Gost3410PublicKeyParameters : Gost3410KeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger y; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF1A50 | overloaded x2
        public void get_Y(){} // RVA: 0x7FFE81129130
    }

    public class Gost3410ValidationParameters : Object
    {
        public int x0; // 0x10
        public int c; // 0x14
        public long x0L; // 0x18
        public long cL; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF1B50 | overloaded x2
        public void get_C(){} // RVA: 0x7FFE8164B230
        public void get_X0(){} // RVA: 0x7FFE811485C0
        public void get_CL(){} // RVA: 0x7FFE811290C0
        public void get_X0L(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE89FF1B60
        public void GetHashCode(){} // RVA: 0x7FFE89FF1C20
    }

    public class HkdfParameters : Object
    {
        public byte[] ikm; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF1F90 | overloaded x2
        public void SkipExtractParameters(){} // RVA: 0x7FFE89FF1FC0
        public void DefaultParameters(){} // RVA: 0x7FFE89FF2040
        public void GetIkm(){} // RVA: 0x7FFE89FF20B0
        public void get_SkipExtract(){} // RVA: 0x7FFE811164E0
        public void GetSalt(){} // RVA: 0x7FFE89FF2160
        public void GetInfo(){} // RVA: 0x7FFE89FF2210
    }

    public class IesParameters : Object
    {
        public byte[] derivation; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE862265A0
        public void GetDerivationV(){} // RVA: 0x7FFE81116380
        public void GetEncodingV(){} // RVA: 0x7FFE810FE7C0
        public void get_MacKeySize(){} // RVA: 0x7FFE8151D690
    }

    public class IesWithCipherParameters : IesParameters
    {
        public int cipherKeySize; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF22C0
        public void get_CipherKeySize(){} // RVA: 0x7FFE81549710
    }

    public class Iso18033KdfParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetSeed(){} // RVA: 0x7FFE81116380
    }

    public class KdfCounterParameters : Object
    {
        public byte[] ki; // 0x10
        public byte[] fixedInputDataCounterPrefix; // 0x18
        public byte[] fixedInputDataCounterSuffix; // 0x20
        public int r; // 0x28
        public object field_4; // 0x4FC

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF23B0 | overloaded x2
        public void get_Ki(){} // RVA: 0x7FFE81116380
        public void get_FixedInputData(){} // RVA: 0x7FFE89FF27F0
        public void get_FixedInputDataCounterPrefix(){} // RVA: 0x7FFE89FF28A0
        public void get_FixedInputDataCounterSuffix(){} // RVA: 0x7FFE89FF2950
        public void get_R(){} // RVA: 0x7FFE81549710
    }

    public class KdfDoublePipelineIterationParameters : Object
    {
        public int UNUSED_R;
        public byte[] ki; // 0x10
        public bool useCounter; // 0x18
        public int r; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF2A00
        public void CreateWithCounter(){} // RVA: 0x7FFE89FF2D20
        public void CreateWithoutCounter(){} // RVA: 0x7FFE89FF2DB0
        public void get_Ki(){} // RVA: 0x7FFE89FF2E50
        public void get_UseCounter(){} // RVA: 0x7FFE811164E0
        public void get_R(){} // RVA: 0x7FFE82707EE0
        public void get_FixedInputData(){} // RVA: 0x7FFE89FF2F00
        public void .cctor(){} // RVA: 0x7FFE89FF2FB0
    }

    public class KdfFeedbackParameters : Object
    {
        public int UNUSED_R;
        public byte[] ki; // 0x10
        public byte[] iv; // 0x18
        public bool useCounter; // 0x20
        public int r; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF2FF0
        public void CreateWithCounter(){} // RVA: 0x7FFE89FF33E0
        public void CreateWithoutCounter(){} // RVA: 0x7FFE89FF34D0
        public void get_Ki(){} // RVA: 0x7FFE89FF3590
        public void get_Iv(){} // RVA: 0x7FFE89FF3640
        public void get_UseCounter(){} // RVA: 0x7FFE811E99D0
        public void get_R(){} // RVA: 0x7FFE81A56130
        public void get_FixedInputData(){} // RVA: 0x7FFE89FF36F0
        public void .cctor(){} // RVA: 0x7FFE89FF37A0
    }

    public class KdfParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8680DC00
        public void GetSharedSecret(){} // RVA: 0x7FFE810FE7C0
        public void GetIV(){} // RVA: 0x7FFE81116380
    }

    public class KeyParameter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF3920 | overloaded x2
        public void GetKey(){} // RVA: 0x7FFE89FF3AC0
    }

    public class MgfParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF3C20 | overloaded x2
        public void GetSeed(){} // RVA: 0x7FFE89FF3D00
    }

    public class MqvPrivateParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters staticPrivateKey; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters ephemeralPrivateKey; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters ephemeralPublicKey; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF3DA0 | overloaded x2
        public void get_StaticPrivateKey(){} // RVA: 0x7FFE81116380
        public void get_EphemeralPrivateKey(){} // RVA: 0x7FFE810FE7C0
        public void get_EphemeralPublicKey(){} // RVA: 0x7FFE811290C0
    }

    public class MqvPublicParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters staticPublicKey; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters ephemeralPublicKey; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF4020
        public void get_StaticPublicKey(){} // RVA: 0x7FFE81116380
        public void get_EphemeralPublicKey(){} // RVA: 0x7FFE810FE7C0
    }

    public class NaccacheSternKeyGenerationParameters : KeyGenerationParameters
    {
        public int certainty; // 0x20
        public int countSmallPrimes; // 0x24
        public object field_2; // 0x50F

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF4180 | overloaded x2
        public void get_Certainty(){} // RVA: 0x7FFE8151D690
        public void get_CountSmallPrimes(){} // RVA: 0x7FFE81A56130
        public void get_IsDebug(){} // RVA: 0x7FFE810FB320
    }

    public class NaccacheSternKeyParameters : AsymmetricKeyParameter
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger g; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger n; // 0x20
        public int lowerSigmaBound; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF4260
        public void get_G(){} // RVA: 0x7FFE810FE7C0
        public void get_LowerSigmaBound(){} // RVA: 0x7FFE81549710
        public void get_Modulus(){} // RVA: 0x7FFE811290C0
    }

    public class NaccacheSternPrivateKeyParameters : NaccacheSternKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger phiN; // 0x30
        public System.Collections.IList smallPrimes; // 0x38
        public object field_2; // 0x515

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF4320 | overloaded x2
        public void get_PhiN(){} // RVA: 0x7FFE8144E200
        public void get_SmallPrimes(){} // RVA: 0x7FFE89FF4400
        public void get_SmallPrimesList(){} // RVA: 0x7FFE8143BA80
    }

    public class ParametersWithID : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ICipherParameters parameters; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF45A0 | overloaded x2
        public void GetID(){} // RVA: 0x7FFE810FE7C0
        public void get_Parameters(){} // RVA: 0x7FFE81116380
    }

    public class ParametersWithIV : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ICipherParameters parameters; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF4700 | overloaded x2
        public void GetIV(){} // RVA: 0x7FFE89FF4890
        public void get_Parameters(){} // RVA: 0x7FFE81116380
    }

    public class ParametersWithRandom : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ICipherParameters parameters; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF4A80 | overloaded x2
        public void GetRandom(){} // RVA: 0x7FFE810FE7C0
        public void get_Random(){} // RVA: 0x7FFE810FE7C0
        public void get_Parameters(){} // RVA: 0x7FFE81116380
    }

    public class ParametersWithSBox : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ICipherParameters parameters; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void GetSBox(){} // RVA: 0x7FFE810FE7C0
        public void get_Parameters(){} // RVA: 0x7FFE81116380
    }

    public class ParametersWithSalt : Object
    {
        public byte[] salt; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF4C40 | overloaded x2
        public void GetSalt(){} // RVA: 0x7FFE81116380
        public void get_Parameters(){} // RVA: 0x7FFE810FE7C0
    }

    public class RC2Parameters : KeyParameter
    {
        public int bits; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF4E30 | overloaded x4
        public void get_EffectiveKeyBits(){} // RVA: 0x7FFE813DB630
    }

    public class RC5Parameters : KeyParameter
    {
        public int rounds; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF4E60
        public void get_Rounds(){} // RVA: 0x7FFE813DB630
    }

    public class RsaBlindingParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters publicKey; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger blindingFactor; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF4EF0
        public void get_PublicKey(){} // RVA: 0x7FFE81116380
        public void get_BlindingFactor(){} // RVA: 0x7FFE810FE7C0
    }

    public class RsaKeyGenerationParameters : KeyGenerationParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger publicExponent; // 0x20
        public int certainty; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF5020
        public void get_PublicExponent(){} // RVA: 0x7FFE811290C0
        public void get_Certainty(){} // RVA: 0x7FFE81549710
        public void Equals(){} // RVA: 0x7FFE89FF50B0
        public void GetHashCode(){} // RVA: 0x7FFE89FF5170
    }

    public class RsaKeyParameters : AsymmetricKeyParameter
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger SmallPrimesProduct;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger modulus; // 0x18

        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFE89FF51B0
        public void .ctor(){} // RVA: 0x7FFE89FF5380
        public void get_Modulus(){} // RVA: 0x7FFE810FE7C0
        public void get_Exponent(){} // RVA: 0x7FFE811290C0
        public void Equals(){} // RVA: 0x7FFE89FF5600
        public void GetHashCode(){} // RVA: 0x7FFE89FF5700
        public void .cctor(){} // RVA: 0x7FFE89FF57B0
    }

    public class RsaPrivateCrtKeyParameters : RsaKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger e; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger p; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger dP; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger dQ; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger qInv; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF6060 | overloaded x2
        public void get_PublicExponent(){} // RVA: 0x7FFE81129130
        public void get_P(){} // RVA: 0x7FFE8144E200
        public void get_Q(){} // RVA: 0x7FFE8143BA80
        public void get_DP(){} // RVA: 0x7FFE81178740
        public void get_DQ(){} // RVA: 0x7FFE81176730
        public void get_QInv(){} // RVA: 0x7FFE8119C0E0
        public void Equals(){} // RVA: 0x7FFE89FF60C0
        public void GetHashCode(){} // RVA: 0x7FFE89FF62D0
        public void ValidateValue(){} // RVA: 0x7FFE89FF6440
    }

    public class SM2KeyExchangePrivateParameters : Object
    {
        public bool mInitiator; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters mStaticPrivateKey; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint mStaticPublicPoint; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters mEphemeralPrivateKey; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint mEphemeralPublicPoint; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF7F90
        public void get_IsInitiator(){} // RVA: 0x7FFE811C55E0
        public void get_StaticPrivateKey(){} // RVA: 0x7FFE810FE7C0
        public void get_StaticPublicPoint(){} // RVA: 0x7FFE811290C0
        public void get_EphemeralPrivateKey(){} // RVA: 0x7FFE81129130
        public void get_EphemeralPublicPoint(){} // RVA: 0x7FFE8144E200
    }

    public class SM2KeyExchangePublicParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters mStaticPublicKey; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters mEphemeralPublicKey; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF81E0
        public void get_StaticPublicKey(){} // RVA: 0x7FFE81116380
        public void get_EphemeralPublicKey(){} // RVA: 0x7FFE810FE7C0
    }

    public class SkeinParameters : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void GetParameters(){} // RVA: 0x7FFE81116380
        public void GetKey(){} // RVA: 0x7FFE89FF65F0
        public void GetPersonalisation(){} // RVA: 0x7FFE89FF6750
        public void GetPublicKey(){} // RVA: 0x7FFE89FF6820
        public void GetKeyIdentifier(){} // RVA: 0x7FFE89FF68F0
        public void GetNonce(){} // RVA: 0x7FFE89FF69C0
    }

    public class Srp6GroupParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger n; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger g; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void get_G(){} // RVA: 0x7FFE810FE7C0
        public void get_N(){} // RVA: 0x7FFE81116380
    }

    public class TweakableBlockCipherParameters : Object
    {
        public byte[] tweak; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.KeyParameter key; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF8340
        public void get_Key(){} // RVA: 0x7FFE810FE7C0
        public void get_Tweak(){} // RVA: 0x7FFE81116380
    }

    public class X25519KeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF84C0
    }

    public class X25519PrivateKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF87D0 | overloaded x3
        public void Encode(){} // RVA: 0x7FFE89FF8970
        public void GetEncoded(){} // RVA: 0x7FFE89FF8A10
        public void GeneratePublicKey(){} // RVA: 0x7FFE89FF8AC0
        public void GenerateSecret(){} // RVA: 0x7FFE89FF8B60
        public void .cctor(){} // RVA: 0x7FFE89FF8D20
    }

    public class X25519PublicKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF8EA0 | overloaded x2
        public void Encode(){} // RVA: 0x7FFE89FF9040
        public void GetEncoded(){} // RVA: 0x7FFE89FF90E0
        public void .cctor(){} // RVA: 0x7FFE89FF9190
    }

    public class X448KeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FEF070
    }

    public class X448PrivateKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF9410 | overloaded x3
        public void Encode(){} // RVA: 0x7FFE89FF95B0
        public void GetEncoded(){} // RVA: 0x7FFE89FF9650
        public void GeneratePublicKey(){} // RVA: 0x7FFE89FF9700
        public void GenerateSecret(){} // RVA: 0x7FFE89FF97A0
        public void .cctor(){} // RVA: 0x7FFE89FF9960
    }

    public class X448PublicKeyParameters : AsymmetricKeyParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FF9AE0 | overloaded x2
        public void Encode(){} // RVA: 0x7FFE89FF9C80
        public void GetEncoded(){} // RVA: 0x7FFE89FF9D20
        public void .cctor(){} // RVA: 0x7FFE89FF9DD0
    }

}