// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
// Classes: 78
// Methods: 431

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters
{
    public class AeadParameters : Object
    {
        public byte[] Key; // 0x10
        public byte[] MacSize; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.KeyParameter key; // 0x20
        public int macSize; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB8DE90 | overloaded x2
        public void get_Key(){} // RVA: 0x7FFAC2F4F0C0
        public void get_MacSize(){} // RVA: 0x7FFAC32EC4C0
        public void GetAssociatedText(){} // RVA: 0x7FFAC2F3C380
        public void GetNonce(){} // RVA: 0x7FFAC2F247C0
    }

    public class CcmParameters : AeadParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB8DFC0
    }

    public class DHKeyGenerationParameters : KeyGenerationParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters Parameters; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB8EC10
        public void get_Parameters(){} // RVA: 0x7FFAC2F4F0C0
        public void GetStrength(){} // RVA: 0x7FFACBB8ECD0
    }

    public class DHKeyParameters : AsymmetricKeyParameter
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHParameters Parameters; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier AlgorithmOid; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB8EDA0 | overloaded x2
        public void get_Parameters(){} // RVA: 0x7FFAC2F247C0
        public void get_AlgorithmOid(){} // RVA: 0x7FFAC2F4F0C0
        public void Equals(){} // RVA: 0x7FFACBB8EF40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBB8EFB0
    }

    public class DHParameters : Object
    {
        public int P;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger G; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger J; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger M; // 0x28
        public int L; // 0x30
        public int ValidationParameters; // 0x34
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DHValidationParameters validation; // 0x38

        // ── Methods ──
        public void GetDefaultMParam(){} // RVA: 0x7FFACBB8F040
        public void .ctor(){} // RVA: 0x7FFACBB8F2F0 | overloaded x6
        public void get_P(){} // RVA: 0x7FFAC2F3C380
        public void get_G(){} // RVA: 0x7FFAC2F247C0
        public void get_Q(){} // RVA: 0x7FFAC2F4F0C0
        public void get_J(){} // RVA: 0x7FFAC2F4F130
        public void get_M(){} // RVA: 0x7FFAC2F7CCD0
        public void get_L(){} // RVA: 0x7FFAC3ADEDC0
        public void get_ValidationParameters(){} // RVA: 0x7FFAC31D0140
        public void Equals(){} // RVA: 0x7FFACBB8F8D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBB8F990
    }

    public class DHPrivateKeyParameters : DHKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger X; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB8FA90 | overloaded x2
        public void get_X(){} // RVA: 0x7FFAC2F4F130
        public void Equals(){} // RVA: 0x7FFACBB8FC30 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBB8FCC0
    }

    public class DHPublicKeyParameters : DHKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Y; // 0x28

        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFACBB8FD10
        public void .ctor(){} // RVA: 0x7FFACBB90000 | overloaded x2
        public void get_Y(){} // RVA: 0x7FFAC2F4F130
        public void Equals(){} // RVA: 0x7FFACBB8FC30 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBB8FCC0
    }

    public class DHValidationParameters : Object
    {
        public byte[] Counter; // 0x10
        public int counter; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB901C0
        public void GetSeed(){} // RVA: 0x7FFACBB90320
        public void get_Counter(){} // RVA: 0x7FFAC3157800
        public void Equals(){} // RVA: 0x7FFACBB90520 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBB90620
    }

    public class DesEdeParameters : DesParameters
    {
        public int DesEdeKeyLength;

        // ── Methods ──
        public void FixKey(){} // RVA: 0x7FFACBB8DFD0
        public void .ctor(){} // RVA: 0x7FFACBB8E200 | overloaded x2
        public void IsWeakKey(){} // RVA: 0x7FFACBB8E360 | overloaded x3
        public void IsRealEdeKey(){} // RVA: 0x7FFACBB8E390
        public void IsReal2Key(){} // RVA: 0x7FFACBB8E4D0
        public void IsReal3Key(){} // RVA: 0x7FFACBB8E540
    }

    public class DesParameters : KeyParameter
    {
        public int DesKeyLength;
        public int N_DES_WEAK_KEYS;
        public byte[] DES_weak_keys;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB8E6F0 | overloaded x2
        public void IsWeakKey(){} // RVA: 0x7FFACBB8E910 | overloaded x2
        public void SetOddParity(){} // RVA: 0x7FFACBB8EA60 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFACBB8EB30
    }

    public class DsaKeyGenerationParameters : KeyGenerationParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DsaParameters Parameters; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB906D0
        public void get_Parameters(){} // RVA: 0x7FFAC2F4F0C0
    }

    public class DsaKeyParameters : AsymmetricKeyParameter
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DsaParameters Parameters; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC833CCF0
        public void get_Parameters(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFACBB8EF40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBB8EFB0
    }

    public class DsaParameterGenerationParameters : Object
    {
        public int L;
        public int N;
        public int UsageIndex; // 0x10
        public int Certainty; // 0x14
        public int Random; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x20
        public int usageIndex; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB908F0 | overloaded x2
        public void get_L(){} // RVA: 0x7FFAC2F6E5C0
        public void get_N(){} // RVA: 0x7FFAC33D5A20
        public void get_UsageIndex(){} // RVA: 0x7FFAC32EC4C0
        public void get_Certainty(){} // RVA: 0x7FFAC3157800
        public void get_Random(){} // RVA: 0x7FFAC2F4F0C0
    }

    public class DsaParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger P; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger G; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters ValidationParameters; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB90AB0 | overloaded x2
        public void get_P(){} // RVA: 0x7FFAC2F3C380
        public void get_Q(){} // RVA: 0x7FFAC2F247C0
        public void get_G(){} // RVA: 0x7FFAC2F4F0C0
        public void get_ValidationParameters(){} // RVA: 0x7FFAC2F4F130
        public void Equals(){} // RVA: 0x7FFACBB90D20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBB90DC0
    }

    public class DsaPrivateKeyParameters : DsaKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger X; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB90E50
        public void get_X(){} // RVA: 0x7FFAC2F4F0C0
        public void Equals(){} // RVA: 0x7FFACBB91090 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBB91120
    }

    public class DsaPublicKeyParameters : DsaKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Y; // 0x20

        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFACBB91170
        public void .ctor(){} // RVA: 0x7FFACBB91310
        public void get_Y(){} // RVA: 0x7FFAC2F4F0C0
        public void Equals(){} // RVA: 0x7FFACBB91090 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBB91120
    }

    public class DsaValidationParameters : Object
    {
        public byte[] Counter; // 0x10
        public int UsageIndex; // 0x18
        public int usageIndex; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB91700 | overloaded x2
        public void GetSeed(){} // RVA: 0x7FFACBB91860
        public void get_Counter(){} // RVA: 0x7FFAC3157800
        public void get_UsageIndex(){} // RVA: 0x7FFAC44357F0
        public void Equals(){} // RVA: 0x7FFACBB919A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBB91AA0
    }

    public class ECDomainParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECCurve Curve; // 0x10
        public byte[] G; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint N; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger H; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger HInv; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger hInv; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB91F60 | overloaded x3
        public void get_Curve(){} // RVA: 0x7FFAC2F3C380
        public void get_G(){} // RVA: 0x7FFAC2F4F0C0
        public void get_N(){} // RVA: 0x7FFAC2F4F130
        public void get_H(){} // RVA: 0x7FFAC31D95E0
        public void get_HInv(){} // RVA: 0x7FFACBB92120
        public void GetSeed(){} // RVA: 0x7FFACBB922D0
        public void Equals(){} // RVA: 0x7FFACBB92440 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBB924E0
        public void ValidatePrivateScalar(){} // RVA: 0x7FFACBB92580
        public void ValidatePublicPoint(){} // RVA: 0x7FFACBB926E0 | overloaded x2
    }

    public class ECGost3410Parameters : ECNamedDomainParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PublicKeyParamSet; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier DigestParamSet; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier EncryptionParamSet; // 0x58

        // ── Methods ──
        public void get_PublicKeyParamSet(){} // RVA: 0x7FFAC2F9C730
        public void get_DigestParamSet(){} // RVA: 0x7FFAC2FC20E0
        public void get_EncryptionParamSet(){} // RVA: 0x7FFAC2FE9500
        public void .ctor(){} // RVA: 0x7FFACBB92A40 | overloaded x2
    }

    public class ECKeyGenerationParameters : KeyGenerationParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECDomainParameters DomainParameters; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PublicKeyParamSet; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB92CA0 | overloaded x2
        public void get_DomainParameters(){} // RVA: 0x7FFAC2F4F0C0
        public void get_PublicKeyParamSet(){} // RVA: 0x7FFAC2F4F130
    }

    public class ECKeyParameters : AsymmetricKeyParameter
    {
        public string[] AlgorithmName;
        public string Parameters; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECDomainParameters PublicKeyParamSet; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB92F30 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFAC2F247C0
        public void get_Parameters(){} // RVA: 0x7FFAC2F4F0C0
        public void get_PublicKeyParamSet(){} // RVA: 0x7FFAC2F4F130
        public void Equals(){} // RVA: 0x7FFACBB93210 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBB93270
        public void CreateKeyGenerationParameters(){} // RVA: 0x7FFACBB932F0
        public void VerifyAlgorithmName(){} // RVA: 0x7FFACBB93430
        public void LookupParameters(){} // RVA: 0x7FFACBB93570
        public void .cctor(){} // RVA: 0x7FFACBB938A0
    }

    public class ECNamedDomainParameters : ECDomainParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier Name; // 0x40

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F9E740
        public void .ctor(){} // RVA: 0x7FFACBB93D90 | overloaded x4
    }

    public class ECPrivateKeyParameters : ECKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger D; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB94210 | overloaded x4
        public void get_D(){} // RVA: 0x7FFAC31D95E0
        public void Equals(){} // RVA: 0x7FFACBB94410 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBB944A0
    }

    public class ECPublicKeyParameters : ECKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint Q; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB94750 | overloaded x4
        public void get_Q(){} // RVA: 0x7FFAC31D95E0
        public void Equals(){} // RVA: 0x7FFACBB94950 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBB944A0
    }

    public class Ed25519KeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB949E0
    }

    public class Ed25519PrivateKeyParameters : AsymmetricKeyParameter
    {
        public int KeySize;
        public int SignatureSize; // 0x4
        public byte[] data; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB94CE0 | overloaded x3
        public void Encode(){} // RVA: 0x7FFACBB94E80
        public void GetEncoded(){} // RVA: 0x7FFACBB94F20
        public void GeneratePublicKey(){} // RVA: 0x7FFACBB94FD0
        public void Sign(){} // RVA: 0x7FFACBB950A0
        public void .cctor(){} // RVA: 0x7FFACBB95520
    }

    public class Ed25519PublicKeyParameters : AsymmetricKeyParameter
    {
        public int KeySize;
        public byte[] data; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB956E0 | overloaded x2
        public void Encode(){} // RVA: 0x7FFACBB95880
        public void GetEncoded(){} // RVA: 0x7FFACBB95920
        public void .cctor(){} // RVA: 0x7FFACBB959D0
    }

    public class Ed448KeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB95A50
    }

    public class Ed448PrivateKeyParameters : AsymmetricKeyParameter
    {
        public int KeySize;
        public int SignatureSize; // 0x4
        public byte[] data; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB95D50 | overloaded x3
        public void Encode(){} // RVA: 0x7FFACBB95EF0
        public void GetEncoded(){} // RVA: 0x7FFACBB95F90
        public void GeneratePublicKey(){} // RVA: 0x7FFACBB96040
        public void Sign(){} // RVA: 0x7FFACBB96110
        public void .cctor(){} // RVA: 0x7FFACBB96490
    }

    public class Ed448PublicKeyParameters : AsymmetricKeyParameter
    {
        public int KeySize;
        public byte[] data; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB96650 | overloaded x2
        public void Encode(){} // RVA: 0x7FFACBB967F0
        public void GetEncoded(){} // RVA: 0x7FFACBB96890
        public void .cctor(){} // RVA: 0x7FFACBB96940
    }

    public class ElGamalKeyGenerationParameters : KeyGenerationParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ElGamalParameters Parameters; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB969C0
        public void get_Parameters(){} // RVA: 0x7FFAC2F4F0C0
        public void GetStrength(){} // RVA: 0x7FFACBB96A80
    }

    public class ElGamalKeyParameters : AsymmetricKeyParameter
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ElGamalParameters Parameters; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC833CCF0
        public void get_Parameters(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFACBB8EF40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBB8EFB0
    }

    public class ElGamalParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger P; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger G; // 0x18
        public int L; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB96D20 | overloaded x2
        public void get_P(){} // RVA: 0x7FFAC2F3C380
        public void get_G(){} // RVA: 0x7FFAC2F247C0
        public void get_L(){} // RVA: 0x7FFAC30DBBE0
        public void Equals(){} // RVA: 0x7FFACBB96FA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBB97030
    }

    public class ElGamalPrivateKeyParameters : ElGamalKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger X; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB97090
        public void get_X(){} // RVA: 0x7FFAC2F4F0C0
        public void Equals(){} // RVA: 0x7FFACBB972D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBB91120
    }

    public class ElGamalPublicKeyParameters : ElGamalKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Y; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB97360
        public void get_Y(){} // RVA: 0x7FFAC2F4F0C0
        public void Equals(){} // RVA: 0x7FFACBB91090 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBB91120
    }

    public class Gost3410KeyGenerationParameters : KeyGenerationParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters Parameters; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PublicKeyParamSet; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB975A0 | overloaded x2
        public void get_Parameters(){} // RVA: 0x7FFAC2F4F0C0
        public void get_PublicKeyParamSet(){} // RVA: 0x7FFAC2F4F130
        public void LookupParameters(){} // RVA: 0x7FFACBB976D0
    }

    public class Gost3410KeyParameters : AsymmetricKeyParameter
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters Parameters; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerObjectIdentifier PublicKeyParamSet; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB97990 | overloaded x2
        public void get_Parameters(){} // RVA: 0x7FFAC2F247C0
        public void get_PublicKeyParamSet(){} // RVA: 0x7FFAC2F4F0C0
        public void LookupParameters(){} // RVA: 0x7FFACBB97A70
    }

    public class Gost3410Parameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger P; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger A; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Gost3410ValidationParameters ValidationParameters; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB97E70 | overloaded x2
        public void get_P(){} // RVA: 0x7FFAC2F3C380
        public void get_Q(){} // RVA: 0x7FFAC2F247C0
        public void get_A(){} // RVA: 0x7FFAC2F4F0C0
        public void get_ValidationParameters(){} // RVA: 0x7FFAC2F4F130
        public void Equals(){} // RVA: 0x7FFACBB90D20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFACBB90DC0
    }

    public class Gost3410PrivateKeyParameters : Gost3410KeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger X; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB98200 | overloaded x2
        public void get_X(){} // RVA: 0x7FFAC2F4F130
    }

    public class Gost3410PublicKeyParameters : Gost3410KeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Y; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB98430 | overloaded x2
        public void get_Y(){} // RVA: 0x7FFAC2F4F130
    }

    public class Gost3410ValidationParameters : Object
    {
        public int C; // 0x10
        public int X0; // 0x14
        public long CL; // 0x18
        public long X0L; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB98530 | overloaded x2
        public void get_C(){} // RVA: 0x7FFAC33D5A20
        public void get_X0(){} // RVA: 0x7FFAC2F6E5C0
        public void get_CL(){} // RVA: 0x7FFAC2F4F0C0
        public void get_X0L(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFACBB98540
        public void GetHashCode(){} // RVA: 0x7FFACBB98600
    }

    public class HkdfParameters : Object
    {
        public byte[] SkipExtract; // 0x10
        public bool skipExpand; // 0x18
        public byte[] salt; // 0x20
        public byte[] info; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB98970 | overloaded x2
        public void SkipExtractParameters(){} // RVA: 0x7FFACBB989A0
        public void DefaultParameters(){} // RVA: 0x7FFACBB98A20
        public void GetIkm(){} // RVA: 0x7FFACBB98A90
        public void get_SkipExtract(){} // RVA: 0x7FFAC2F3C4E0
        public void GetSalt(){} // RVA: 0x7FFACBB98B40
        public void GetInfo(){} // RVA: 0x7FFACBB98BF0
    }

    public class IesParameters : Object
    {
        public byte[] MacKeySize; // 0x10
        public byte[] encoding; // 0x18
        public int macKeySize; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC7E02DD0
        public void GetDerivationV(){} // RVA: 0x7FFAC2F3C380
        public void GetEncodingV(){} // RVA: 0x7FFAC2F247C0
        public void get_MacKeySize(){} // RVA: 0x7FFAC30DBBE0
    }

    public class IesWithCipherParameters : IesParameters
    {
        public int CipherKeySize; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB98CA0
        public void get_CipherKeySize(){} // RVA: 0x7FFAC32EC4C0
    }

    public class Iso18033KdfParameters : Object
    {
        public byte[] seed; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetSeed(){} // RVA: 0x7FFAC2F3C380
    }

    public class KdfCounterParameters : Object
    {
        public byte[] Ki; // 0x10
        public byte[] FixedInputData; // 0x18
        public byte[] FixedInputDataCounterPrefix; // 0x20
        public int FixedInputDataCounterSuffix; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB98D90 | overloaded x2
        public void get_Ki(){} // RVA: 0x7FFAC2F3C380
        public void get_FixedInputData(){} // RVA: 0x7FFACBB991D0
        public void get_FixedInputDataCounterPrefix(){} // RVA: 0x7FFACBB99280
        public void get_FixedInputDataCounterSuffix(){} // RVA: 0x7FFACBB99330
        public void get_R(){} // RVA: 0x7FFAC32EC4C0
    }

    public class KdfDoublePipelineIterationParameters : Object
    {
        public int Ki;
        public byte[] UseCounter; // 0x10
        public bool R; // 0x18
        public int FixedInputData; // 0x1C
        public byte[] fixedInputData; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB993E0
        public void CreateWithCounter(){} // RVA: 0x7FFACBB99700
        public void CreateWithoutCounter(){} // RVA: 0x7FFACBB99790
        public void get_Ki(){} // RVA: 0x7FFACBB99830
        public void get_UseCounter(){} // RVA: 0x7FFAC2F3C4E0
        public void get_R(){} // RVA: 0x7FFAC44357F0
        public void get_FixedInputData(){} // RVA: 0x7FFACBB998E0
        public void .cctor(){} // RVA: 0x7FFACBB99990
    }

    public class KdfFeedbackParameters : Object
    {
        public int Ki;
        public byte[] Iv; // 0x10
        public byte[] UseCounter; // 0x18
        public bool R; // 0x20
        public int FixedInputData; // 0x24
        public byte[] fixedInputData; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB999D0
        public void CreateWithCounter(){} // RVA: 0x7FFACBB99DC0
        public void CreateWithoutCounter(){} // RVA: 0x7FFACBB99EB0
        public void get_Ki(){} // RVA: 0x7FFACBB99F70
        public void get_Iv(){} // RVA: 0x7FFACBB9A020
        public void get_UseCounter(){} // RVA: 0x7FFAC300F9D0
        public void get_R(){} // RVA: 0x7FFAC3921980
        public void get_FixedInputData(){} // RVA: 0x7FFACBB9A0D0
        public void .cctor(){} // RVA: 0x7FFACBB9A180
    }

    public class KdfParameters : Object
    {
        public byte[] iv; // 0x10
        public byte[] shared; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84642F0
        public void GetSharedSecret(){} // RVA: 0x7FFAC2F247C0
        public void GetIV(){} // RVA: 0x7FFAC2F3C380
    }

    public class KeyParameter : Object
    {
        public byte[] key; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9A300 | overloaded x2
        public void GetKey(){} // RVA: 0x7FFACBB9A4A0
    }

    public class MgfParameters : Object
    {
        public byte[] seed; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9A600 | overloaded x2
        public void GetSeed(){} // RVA: 0x7FFACBB9A6E0
    }

    public class MqvPrivateParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters StaticPrivateKey; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters EphemeralPrivateKey; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters EphemeralPublicKey; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9A780 | overloaded x2
        public void get_StaticPrivateKey(){} // RVA: 0x7FFAC2F3C380
        public void get_EphemeralPrivateKey(){} // RVA: 0x7FFAC2F247C0
        public void get_EphemeralPublicKey(){} // RVA: 0x7FFAC2F4F0C0
    }

    public class MqvPublicParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters StaticPublicKey; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters EphemeralPublicKey; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9AA00
        public void get_StaticPublicKey(){} // RVA: 0x7FFAC2F3C380
        public void get_EphemeralPublicKey(){} // RVA: 0x7FFAC2F247C0
    }

    public class NaccacheSternKeyGenerationParameters : KeyGenerationParameters
    {
        public int Certainty; // 0x20
        public int CountSmallPrimes; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9AB60 | overloaded x2
        public void get_Certainty(){} // RVA: 0x7FFAC30DBBE0
        public void get_CountSmallPrimes(){} // RVA: 0x7FFAC3921980
        public void get_IsDebug(){} // RVA: 0x7FFAC2F21320
    }

    public class NaccacheSternKeyParameters : AsymmetricKeyParameter
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger G; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger LowerSigmaBound; // 0x20
        public int Modulus; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9AC40
        public void get_G(){} // RVA: 0x7FFAC2F247C0
        public void get_LowerSigmaBound(){} // RVA: 0x7FFAC32EC4C0
        public void get_Modulus(){} // RVA: 0x7FFAC2F4F0C0
    }

    public class NaccacheSternPrivateKeyParameters : NaccacheSternKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger PhiN; // 0x30
        public System.Collections.IList SmallPrimes; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9AD00 | overloaded x2
        public void get_PhiN(){} // RVA: 0x7FFAC31D95E0
        public void get_SmallPrimes(){} // RVA: 0x7FFACBB9ADE0
        public void get_SmallPrimesList(){} // RVA: 0x7FFAC31D0140
    }

    public class ParametersWithID : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ICipherParameters Parameters; // 0x10
        public byte[] id; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9AF80 | overloaded x2
        public void GetID(){} // RVA: 0x7FFAC2F247C0
        public void get_Parameters(){} // RVA: 0x7FFAC2F3C380
    }

    public class ParametersWithIV : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ICipherParameters Parameters; // 0x10
        public byte[] iv; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9B0E0 | overloaded x2
        public void GetIV(){} // RVA: 0x7FFACBB9B270
        public void get_Parameters(){} // RVA: 0x7FFAC2F3C380
    }

    public class ParametersWithRandom : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ICipherParameters Random; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom Parameters; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9B460 | overloaded x2
        public void GetRandom(){} // RVA: 0x7FFAC2F247C0
        public void get_Random(){} // RVA: 0x7FFAC2F247C0
        public void get_Parameters(){} // RVA: 0x7FFAC2F3C380
    }

    public class ParametersWithSBox : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ICipherParameters Parameters; // 0x10
        public byte[] sBox; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void GetSBox(){} // RVA: 0x7FFAC2F247C0
        public void get_Parameters(){} // RVA: 0x7FFAC2F3C380
    }

    public class ParametersWithSalt : Object
    {
        public byte[] Parameters; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ICipherParameters parameters; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9B620 | overloaded x2
        public void GetSalt(){} // RVA: 0x7FFAC2F3C380
        public void get_Parameters(){} // RVA: 0x7FFAC2F247C0
    }

    public class RC2Parameters : KeyParameter
    {
        public int EffectiveKeyBits; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9B810 | overloaded x4
        public void get_EffectiveKeyBits(){} // RVA: 0x7FFAC3157800
    }

    public class RC5Parameters : KeyParameter
    {
        public int Rounds; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9B840
        public void get_Rounds(){} // RVA: 0x7FFAC3157800
    }

    public class RsaBlindingParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters PublicKey; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger BlindingFactor; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9B8D0
        public void get_PublicKey(){} // RVA: 0x7FFAC2F3C380
        public void get_BlindingFactor(){} // RVA: 0x7FFAC2F247C0
    }

    public class RsaKeyGenerationParameters : KeyGenerationParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger PublicExponent; // 0x20
        public int Certainty; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9BA00
        public void get_PublicExponent(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Certainty(){} // RVA: 0x7FFAC32EC4C0
        public void Equals(){} // RVA: 0x7FFACBB9BA90
        public void GetHashCode(){} // RVA: 0x7FFACBB9BB50
    }

    public class RsaKeyParameters : AsymmetricKeyParameter
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Modulus;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Exponent; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger exponent; // 0x20

        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFACBB9BB90
        public void .ctor(){} // RVA: 0x7FFACBB9BD60
        public void get_Modulus(){} // RVA: 0x7FFAC2F247C0
        public void get_Exponent(){} // RVA: 0x7FFAC2F4F0C0
        public void Equals(){} // RVA: 0x7FFACBB9BFE0
        public void GetHashCode(){} // RVA: 0x7FFACBB9C0E0
        public void .cctor(){} // RVA: 0x7FFACBB9C190
    }

    public class RsaPrivateCrtKeyParameters : RsaKeyParameters
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger PublicExponent; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger P; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger DP; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger DQ; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger QInv; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9CA40 | overloaded x2
        public void get_PublicExponent(){} // RVA: 0x7FFAC2F4F130
        public void get_P(){} // RVA: 0x7FFAC31D95E0
        public void get_Q(){} // RVA: 0x7FFAC31D0140
        public void get_DP(){} // RVA: 0x7FFAC2F9E740
        public void get_DQ(){} // RVA: 0x7FFAC2F9C730
        public void get_QInv(){} // RVA: 0x7FFAC2FC20E0
        public void Equals(){} // RVA: 0x7FFACBB9CAA0
        public void GetHashCode(){} // RVA: 0x7FFACBB9CCB0
        public void ValidateValue(){} // RVA: 0x7FFACBB9CE20
    }

    public class SM2KeyExchangePrivateParameters : Object
    {
        public bool IsInitiator; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters StaticPrivateKey; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint StaticPublicPoint; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters EphemeralPrivateKey; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint EphemeralPublicPoint; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9E970
        public void get_IsInitiator(){} // RVA: 0x7FFAC2FEB5E0
        public void get_StaticPrivateKey(){} // RVA: 0x7FFAC2F247C0
        public void get_StaticPublicPoint(){} // RVA: 0x7FFAC2F4F0C0
        public void get_EphemeralPrivateKey(){} // RVA: 0x7FFAC2F4F130
        public void get_EphemeralPublicPoint(){} // RVA: 0x7FFAC31D95E0
    }

    public class SM2KeyExchangePublicParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters StaticPublicKey; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters EphemeralPublicKey; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9EBC0
        public void get_StaticPublicKey(){} // RVA: 0x7FFAC2F3C380
        public void get_EphemeralPublicKey(){} // RVA: 0x7FFAC2F247C0
    }

    public class SkeinParameters : Object
    {
        public int PARAM_TYPE_KEY;
        public int PARAM_TYPE_CONFIG;
        public int PARAM_TYPE_PERSONALISATION;
        public int PARAM_TYPE_PUBLIC_KEY;
        public int PARAM_TYPE_KEY_IDENTIFIER;
        public int PARAM_TYPE_NONCE;
        public int PARAM_TYPE_MESSAGE;
        public int PARAM_TYPE_OUTPUT;
        public System.Collections.IDictionary parameters; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void GetParameters(){} // RVA: 0x7FFAC2F3C380
        public void GetKey(){} // RVA: 0x7FFACBB9CFD0
        public void GetPersonalisation(){} // RVA: 0x7FFACBB9D130
        public void GetPublicKey(){} // RVA: 0x7FFACBB9D200
        public void GetKeyIdentifier(){} // RVA: 0x7FFACBB9D2D0
        public void GetNonce(){} // RVA: 0x7FFACBB9D3A0
    }

    public class Srp6GroupParameters : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger G; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger N; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void get_G(){} // RVA: 0x7FFAC2F247C0
        public void get_N(){} // RVA: 0x7FFAC2F3C380
    }

    public class TweakableBlockCipherParameters : Object
    {
        public byte[] Key; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.KeyParameter Tweak; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9ED20
        public void get_Key(){} // RVA: 0x7FFAC2F247C0
        public void get_Tweak(){} // RVA: 0x7FFAC2F3C380
    }

    public class X25519KeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9EEA0
    }

    public class X25519PrivateKeyParameters : AsymmetricKeyParameter
    {
        public int KeySize;
        public int SecretSize; // 0x4
        public byte[] data; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9F1B0 | overloaded x3
        public void Encode(){} // RVA: 0x7FFACBB9F350
        public void GetEncoded(){} // RVA: 0x7FFACBB9F3F0
        public void GeneratePublicKey(){} // RVA: 0x7FFACBB9F4A0
        public void GenerateSecret(){} // RVA: 0x7FFACBB9F540
        public void .cctor(){} // RVA: 0x7FFACBB9F700
    }

    public class X25519PublicKeyParameters : AsymmetricKeyParameter
    {
        public int KeySize;
        public byte[] data; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9F880 | overloaded x2
        public void Encode(){} // RVA: 0x7FFACBB9FA20
        public void GetEncoded(){} // RVA: 0x7FFACBB9FAC0
        public void .cctor(){} // RVA: 0x7FFACBB9FB70
    }

    public class X448KeyGenerationParameters : KeyGenerationParameters
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB95A50
    }

    public class X448PrivateKeyParameters : AsymmetricKeyParameter
    {
        public int KeySize;
        public int SecretSize; // 0x4
        public byte[] data; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB9FDF0 | overloaded x3
        public void Encode(){} // RVA: 0x7FFACBB9FF90
        public void GetEncoded(){} // RVA: 0x7FFACBBA0030
        public void GeneratePublicKey(){} // RVA: 0x7FFACBBA00E0
        public void GenerateSecret(){} // RVA: 0x7FFACBBA0180
        public void .cctor(){} // RVA: 0x7FFACBBA0340
    }

    public class X448PublicKeyParameters : AsymmetricKeyParameter
    {
        public int KeySize;
        public byte[] data; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBA04C0 | overloaded x2
        public void Encode(){} // RVA: 0x7FFACBBA0660
        public void GetEncoded(){} // RVA: 0x7FFACBBA0700
        public void .cctor(){} // RVA: 0x7FFACBBA07B0
    }

}