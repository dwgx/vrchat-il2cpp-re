// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 27
// Methods: 289

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class RC2 : SymmetricAlgorithm
    {
        public int EffectiveKeySize; // 0x48
        public System.Security.Cryptography.KeySizes[] KeySize;
        public System.Security.Cryptography.KeySizes[] s_legalKeySizes; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC841B730
        public void get_EffectiveKeySize(){} // RVA: 0x7FFAC841B860
        public void set_EffectiveKeySize(){} // RVA: 0x7FFAC841B870
        public void get_KeySize(){} // RVA: 0x7FFAC358A870
        public void set_KeySize(){} // RVA: 0x7FFAC841B9C0
        public void Create(){} // RVA: 0x7FFAC841BA90 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC841BB70
    }

    public class RC2CryptoServiceProvider : RC2
    {
        public bool EffectiveKeySize; // 0x50
        public System.Security.Cryptography.KeySizes[] UseSalt;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC841BDF0
        public void get_EffectiveKeySize(){} // RVA: 0x7FFAC358A870
        public void set_EffectiveKeySize(){} // RVA: 0x7FFAC841C040
        public void get_UseSalt(){} // RVA: 0x7FFAC2FDB8E0
        public void set_UseSalt(){} // RVA: 0x7FFAC2FDB8F0
        public void CreateEncryptor(){} // RVA: 0x7FFAC841C0C0
        public void CreateDecryptor(){} // RVA: 0x7FFAC841C1A0
        public void GenerateKey(){} // RVA: 0x7FFAC841C280
        public void GenerateIV(){} // RVA: 0x7FFAC841C370
        public void .cctor(){} // RVA: 0x7FFAC841C450
    }

    public class RC2Transform : SymmetricTransform
    {
        public ushort R0; // 0x58
        public ushort R1; // 0x5A
        public ushort R2; // 0x5C
        public ushort R3; // 0x5E
        public ushort[] K; // 0x60
        public int j; // 0x68
        public byte[] pitable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8441CF0
        public void ECB(){} // RVA: 0x7FFAC8442310
        public void .cctor(){} // RVA: 0x7FFAC8442E30
    }

    public class RIPEMD160 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84214D0
        public void Create(){} // RVA: 0x7FFAC8421530 | overloaded x2
    }

    public class RIPEMD160Managed : RIPEMD160
    {
        public byte[] _buffer; // 0x28
        public long _count; // 0x30
        public uint[] _stateMD160; // 0x38
        public uint[] _blockDWords; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8421610
        public void Initialize(){} // RVA: 0x7FFAC84217C0
        public void HashCore(){} // RVA: 0x7FFAC8421820
        public void HashFinal(){} // RVA: 0x7FFAC8421830
        public void InitializeState(){} // RVA: 0x7FFAC8421840
        public void _HashData(){} // RVA: 0x7FFAC84218D0
        public void _EndHash(){} // RVA: 0x7FFAC8421BC0
        public void MDTransform(){} // RVA: 0x7FFAC8421EB0
        public void F(){} // RVA: 0x7FFAC8424480
        public void G(){} // RVA: 0x7FFAC8424490
        public void H(){} // RVA: 0x7FFAC84244A0
        public void I(){} // RVA: 0x7FFAC84244B0
        public void J(){} // RVA: 0x7FFAC84244C0
    }

    public class RNGCryptoServiceProvider : RandomNumberGenerator
    {
        public object _lock;
        public UIntPtr _handle; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC8442F10
        public void .ctor(){} // RVA: 0x7FFAC84430C0 | overloaded x4
        public void Check(){} // RVA: 0x7FFAC84431B0
        public void RngOpen(){} // RVA: 0x7FFAC2F21320
        public void RngInitialize(){} // RVA: 0x7FFAC8443230
        public void RngGetBytes(){} // RVA: 0x7FFAC8443240
        public void RngClose(){} // RVA: 0x7FFAC84432D0
        public void GetBytes(){} // RVA: 0x7FFAC8443590 | overloaded x2
        public void GetNonZeroBytes(){} // RVA: 0x7FFAC84437C0
        public void Finalize(){} // RVA: 0x7FFAC84439B0
        public void Dispose(){} // RVA: 0x7FFAC2F21310
    }

    public class RSA : AsymmetricAlgorithm
    {
        public object KeyExchangeAlgorithm;
        public object SignatureAlgorithm;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8427010 | overloaded x4
        public void Encrypt(){} // RVA: 0x7FFAC8424610
        public void Decrypt(){} // RVA: 0x7FFAC8424640
        public void SignHash(){} // RVA: 0x7FFAC8424670
        public void VerifyHash(){} // RVA: 0x7FFAC8428030 | overloaded x2
        public void HashData(){} // RVA: 0x7FFAC8424700 | overloaded x2
        public void SignData(){} // RVA: 0x7FFAC8424AA0 | overloaded x3
        public void VerifyData(){} // RVA: 0x7FFAC8427B90 | overloaded x4
        public void DerivedClassMustOverride(){} // RVA: 0x7FFAC84252F0
        public void HashAlgorithmNameNullOrEmpty(){} // RVA: 0x7FFAC8425370
        public void DecryptValue(){} // RVA: 0x7FFAC8425400
        public void EncryptValue(){} // RVA: 0x7FFAC8425460
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7FFAC84254C0
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAC8425500
        public void FromXmlString(){} // RVA: 0x7FFAC8425540
        public void ToXmlString(){} // RVA: 0x7FFAC8426540
        public void ExportParameters(){}
        public void ImportParameters(){}
        public void TryDecrypt(){} // RVA: 0x7FFAC8427100
        public void TryEncrypt(){} // RVA: 0x7FFAC8427290
        public void TryHashData(){} // RVA: 0x7FFAC8427420
        public void TrySignHash(){} // RVA: 0x7FFAC8427710
        public void TrySignData(){} // RVA: 0x7FFAC84278B0
        public void ExportRSAPrivateKey(){} // RVA: 0x7FFAC84280D0
        public void ExportRSAPublicKey(){} // RVA: 0x7FFAC8428110
        public void ImportRSAPrivateKey(){} // RVA: 0x7FFAC8428150
        public void ImportRSAPublicKey(){} // RVA: 0x7FFAC8428190
        public void TryExportRSAPrivateKey(){} // RVA: 0x7FFAC84281D0
        public void TryExportRSAPublicKey(){} // RVA: 0x7FFAC8428210
    }

    public class RSACryptoServiceProvider : RSA
    {
        public 0x6B0CC2E0 SignatureAlgorithm;
        public int UseMachineKeyStore;
        public int KeyExchangeAlgorithm;
        public int KeySize;
        public Mono.Security.Cryptography.KeyPairPersistence PersistKeyInCsp; // 0x20
        public bool PublicOnly; // 0x28
        public bool CspKeyContainerInfo; // 0x29
        public bool privateKeyExportable; // 0x2A
        public bool m_disposed; // 0x2B
        public Mono.Security.Cryptography.RSAManaged rsa; // 0x30

        // ── Methods ──
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAC8428250
        public void get_UseMachineKeyStore(){} // RVA: 0x7FFAC8428290
        public void set_UseMachineKeyStore(){} // RVA: 0x7FFAC84282E0
        public void HashData(){} // RVA: 0x7FFAC8428390 | overloaded x2
        public void GetAlgorithmId(){} // RVA: 0x7FFAC84283D0
        public void Encrypt(){} // RVA: 0x7FFAC842A160 | overloaded x2
        public void Decrypt(){} // RVA: 0x7FFAC8429BF0 | overloaded x2
        public void SignHash(){} // RVA: 0x7FFAC842B0F0 | overloaded x3
        public void VerifyHash(){} // RVA: 0x7FFAC842B560 | overloaded x3
        public void PaddingModeNotSupported(){} // RVA: 0x7FFAC8429040
        public void .ctor(){} // RVA: 0x7FFAC8429270 | overloaded x4
        public void Common(){} // RVA: 0x7FFAC8429960 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8243E40
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7FFAC8429AD0
        public void get_KeySize(){} // RVA: 0x7FFAC8429B10
        public void get_PersistKeyInCsp(){} // RVA: 0x7FFAC30F6BA0
        public void set_PersistKeyInCsp(){} // RVA: 0x7FFAC8429B40
        public void get_PublicOnly(){} // RVA: 0x7FFAC8429BD0
        public void DecryptValue(){} // RVA: 0x7FFAC842A0D0
        public void EncryptValue(){} // RVA: 0x7FFAC842A4B0
        public void ExportParameters(){} // RVA: 0x7FFAC842A4E0
        public void ImportParameters(){} // RVA: 0x7FFAC842A680
        public void GetHash(){} // RVA: 0x7FFAC842A6E0
        public void GetHashFromString(){} // RVA: 0x7FFAC842AA00
        public void SignData(){} // RVA: 0x7FFAC842AC80 | overloaded x3
        public void GetHashNameFromOID(){} // RVA: 0x7FFAC842AD50
        public void InternalHashToHashAlgorithm(){} // RVA: 0x7FFAC842B170
        public void VerifyData(){} // RVA: 0x7FFAC842B2A0
        public void Dispose(){} // RVA: 0x7FFAC842B5F0
        public void OnKeyGenerated(){} // RVA: 0x7FFAC842B640
        public void get_CspKeyContainerInfo(){} // RVA: 0x7FFAC842B6D0
        public void ExportCspBlob(){} // RVA: 0x7FFAC842B790
        public void ImportCspBlob(){} // RVA: 0x7FFAC842B810
    }

    public class RSAEncryptionPadding : Object
    {
        public System.Security.Cryptography.RSAEncryptionPadding Pkcs1;
        public System.Security.Cryptography.RSAEncryptionPadding OaepSHA1; // 0x8
        public System.Security.Cryptography.RSAEncryptionPadding OaepSHA256; // 0x10
        public System.Security.Cryptography.RSAEncryptionPadding OaepSHA384; // 0x18
        public System.Security.Cryptography.RSAEncryptionPadding OaepSHA512; // 0x20
        public 0x6B0CBD08 Mode; // 0x10
        public System.Security.Cryptography.HashAlgorithmName OaepHashAlgorithm; // 0x18

        // ── Methods ──
        public void get_Pkcs1(){} // RVA: 0x7FFAC840C220
        public void get_OaepSHA1(){} // RVA: 0x7FFAC840C280
        public void get_OaepSHA256(){} // RVA: 0x7FFAC840C2E0
        public void get_OaepSHA384(){} // RVA: 0x7FFAC840C340
        public void get_OaepSHA512(){} // RVA: 0x7FFAC840C3A0
        public void .ctor(){} // RVA: 0x7FFAC840CB00 | overloaded x2
        public void CreateOaep(){} // RVA: 0x7FFAC840C400
        public void get_Mode(){} // RVA: 0x7FFAC2F6E5C0
        public void get_OaepHashAlgorithm(){} // RVA: 0x7FFAC2F247C0
        public void GetHashCode(){} // RVA: 0x7FFAC840C510
        public void CombineHashCodes(){} // RVA: 0x7FFAC6511FF0
        public void Equals(){} // RVA: 0x7FFAC840C5F0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC840C6F0
        public void op_Inequality(){} // RVA: 0x7FFAC840C710
        public void ToString(){} // RVA: 0x7FFAC840C790
        public void .cctor(){} // RVA: 0x7FFAC840C800
    }

    public class RSAOAEPKeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
    {
        public System.Security.Cryptography.RSA Parameters; // 0x10
        public System.Nullable`1<bool> OverridesDecrypt; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC842BBA0 | overloaded x2
        public void get_Parameters(){} // RVA: 0x7FFAC34F9180
        public void set_Parameters(){} // RVA: 0x7FFAC2F21310
        public void DecryptKeyExchange(){} // RVA: 0x7FFAC842BD00
        public void SetKey(){} // RVA: 0x7FFAC842BF40
        public void get_OverridesDecrypt(){} // RVA: 0x7FFAC842C0A0
    }

    public class RSAOAEPKeyExchangeFormatter : AsymmetricKeyExchangeFormatter
    {
        public byte[] Parameter; // 0x10
        public System.Security.Cryptography.RSA Parameters; // 0x18
        public System.Nullable`1<bool> Rng; // 0x20
        public System.Security.Cryptography.RandomNumberGenerator OverridesEncrypt; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC842C2B0 | overloaded x2
        public void get_Parameter(){} // RVA: 0x7FFAC842C410
        public void set_Parameter(){} // RVA: 0x7FFAC842C490
        public void get_Parameters(){} // RVA: 0x7FFAC34F9180
        public void get_Rng(){} // RVA: 0x7FFAC2F4F130
        public void set_Rng(){} // RVA: 0x7FFAC2F22E90
        public void SetKey(){} // RVA: 0x7FFAC842C5F0
        public void CreateKeyExchange(){} // RVA: 0x7FFAC6916740 | overloaded x2
        public void get_OverridesEncrypt(){} // RVA: 0x7FFAC842C950
    }

    public class RSAPKCS1KeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
    {
        public System.Security.Cryptography.RSA RNG; // 0x10
        public System.Nullable`1<bool> Parameters; // 0x18
        public System.Security.Cryptography.RandomNumberGenerator OverridesDecrypt; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC842CB60 | overloaded x2
        public void get_RNG(){} // RVA: 0x7FFAC2F4F0C0
        public void set_RNG(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Parameters(){} // RVA: 0x7FFAC34F9180
        public void set_Parameters(){} // RVA: 0x7FFAC2F21310
        public void DecryptKeyExchange(){} // RVA: 0x7FFAC842CCC0
        public void SetKey(){} // RVA: 0x7FFAC842CF20
        public void get_OverridesDecrypt(){} // RVA: 0x7FFAC842D080
    }

    public class RSAPKCS1KeyExchangeFormatter : AsymmetricKeyExchangeFormatter
    {
        public System.Security.Cryptography.RandomNumberGenerator Parameters; // 0x10
        public System.Security.Cryptography.RSA Rng; // 0x18
        public System.Nullable`1<bool> OverridesEncrypt; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC842D290 | overloaded x2
        public void get_Parameters(){} // RVA: 0x7FFAC842D3F0
        public void get_Rng(){} // RVA: 0x7FFAC2F3C380
        public void set_Rng(){} // RVA: 0x7FFAC2F22E30
        public void SetKey(){} // RVA: 0x7FFAC842D430
        public void CreateKeyExchange(){} // RVA: 0x7FFAC6916740 | overloaded x2
        public void get_OverridesEncrypt(){} // RVA: 0x7FFAC842D900
    }

    public class RSAPKCS1SHA1SignatureDescription : RSAPKCS1SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8434780
    }

    public class RSAPKCS1SHA256SignatureDescription : RSAPKCS1SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84347E0
    }

    public class RSAPKCS1SHA384SignatureDescription : RSAPKCS1SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8434840
    }

    public class RSAPKCS1SHA512SignatureDescription : RSAPKCS1SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84348A0
    }

    public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
    {
        public System.Security.Cryptography.RSA rsa; // 0x10
        public string hashName; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8443A50 | overloaded x2
        public void SetHashAlgorithm(){} // RVA: 0x7FFAC8443A70
        public void SetKey(){} // RVA: 0x7FFAC8443B20
        public void VerifySignature(){} // RVA: 0x7FFAC8443C80
    }

    public class RSAPKCS1SignatureDescription : SignatureDescription
    {
        public string _hashAlgorithm; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84342F0
        public void CreateDeformatter(){} // RVA: 0x7FFAC8434520
        public void CreateFormatter(){} // RVA: 0x7FFAC8434650
    }

    public class RSAPKCS1SignatureFormatter : AsymmetricSignatureFormatter
    {
        public System.Security.Cryptography.RSA rsa; // 0x10
        public string hash; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8443A50 | overloaded x2
        public void CreateSignature(){} // RVA: 0x7FFAC8443E70
        public void SetHashAlgorithm(){} // RVA: 0x7FFAC8444000
        public void SetKey(){} // RVA: 0x7FFAC84440B0
    }

    public class RSAParameters : ValueType
    {
        public byte[] Exponent; // 0x10
        public byte[] Modulus; // 0x18
        public byte[] P; // 0x20
        public byte[] Q; // 0x28
        public byte[] DP; // 0x30
        public byte[] DQ; // 0x38
        public byte[] InverseQ; // 0x40
        public byte[] D; // 0x48
    }

    public class RSASignaturePadding : Object
    {
        public System.Security.Cryptography.RSASignaturePadding Pkcs1;
        public System.Security.Cryptography.RSASignaturePadding Pss; // 0x8
        public 0x6B0CBDB8 Mode; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC840CF40 | overloaded x2
        public void get_Pkcs1(){} // RVA: 0x7FFAC840CB30
        public void get_Pss(){} // RVA: 0x7FFAC840CB90
        public void get_Mode(){} // RVA: 0x7FFAC2F6E5C0
        public void GetHashCode(){} // RVA: 0x7FFAC2F6E5C0
        public void Equals(){} // RVA: 0x7FFAC840CC50 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC840CD10
        public void op_Inequality(){} // RVA: 0x7FFAC840CD30
        public void ToString(){} // RVA: 0x7FFAC840CDB0
        public void .cctor(){} // RVA: 0x7FFAC840CE10
    }

    public class RandomNumberGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC841AC00 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void GetBytes(){} // RVA: 0x7FFAC841B0A0 | overloaded x3
        public void GetNonZeroBytes(){} // RVA: 0x7FFAC841B2F0 | overloaded x2
        public void Fill(){} // RVA: 0x7FFAC841AFD0
        public void FillSpan(){} // RVA: 0x7FFAC841B040
        public void GetInt32(){} // RVA: 0x7FFAC841B6A0 | overloaded x2
    }

    public class Rfc2898DeriveBytes : DeriveBytes
    {
        public int HashAlgorithm;
        public byte[] IterationCount; // 0x10
        public byte[] Salt; // 0x18
        public uint _iterations; // 0x20
        public System.Security.Cryptography.HMAC _hmac; // 0x28
        public int _blockSize; // 0x30
        public byte[] _buffer; // 0x38
        public uint _block; // 0x40
        public int _startIndex; // 0x44
        public int _endIndex; // 0x48
        public System.Security.Cryptography.HashAlgorithmName <HashAlgorithm>k__BackingField; // 0x50

        // ── Methods ──
        public void get_HashAlgorithm(){} // RVA: 0x7FFAC2FC20E0
        public void .ctor(){} // RVA: 0x7FFAC8403A40 | overloaded x8
        public void get_IterationCount(){} // RVA: 0x7FFAC30DBBE0
        public void set_IterationCount(){} // RVA: 0x7FFAC8403C50
        public void get_Salt(){} // RVA: 0x7FFAC8403CE0
        public void set_Salt(){} // RVA: 0x7FFAC8403D60
        public void Dispose(){} // RVA: 0x7FFAC8403EE0
        public void GetBytes(){} // RVA: 0x7FFAC8403FB0
        public void CryptDeriveKey(){} // RVA: 0x7FFAC8404160
        public void Reset(){} // RVA: 0x7FFAC84041A0
        public void OpenHmac(){} // RVA: 0x7FFAC84041B0
        public void Initialize(){} // RVA: 0x7FFAC8404490
        public void Func(){} // RVA: 0x7FFAC8404550
    }

    public class Rijndael : SymmetricAlgorithm
    {
        public System.Security.Cryptography.KeySizes[] s_legalBlockSizes;
        public System.Security.Cryptography.KeySizes[] s_legalKeySizes; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC841C5B0
        public void Create(){} // RVA: 0x7FFAC841C730 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC841C810
    }

    public class RijndaelManaged : Rijndael
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC841CA90
        public void CreateEncryptor(){} // RVA: 0x7FFAC841CC30
        public void CreateDecryptor(){} // RVA: 0x7FFAC841CD60
        public void GenerateKey(){} // RVA: 0x7FFAC841CE90
        public void GenerateIV(){} // RVA: 0x7FFAC841CF40
        public void NewEncryptor(){} // RVA: 0x7FFAC841CFF0
    }

    public class RijndaelManagedTransform : Object
    {
        public 0x6B0CC128 BlockSizeValue; // 0x10
        public 0x6B0CC180 InputBlockSize; // 0x14
        public 0x6B0CCCD8 OutputBlockSize; // 0x18
        public int CanTransformMultipleBlocks; // 0x1C
        public int CanReuseTransform; // 0x20
        public int m_inputBlockSize; // 0x24
        public int m_outputBlockSize; // 0x28
        public int[] m_encryptKeyExpansion; // 0x30
        public int[] m_decryptKeyExpansion; // 0x38
        public int m_Nr; // 0x40
        public int m_Nb; // 0x44
        public int m_Nk; // 0x48
        public int[] m_encryptindex; // 0x50
        public int[] m_decryptindex; // 0x58
        public int[] m_IV; // 0x60
        public int[] m_lastBlockBuffer; // 0x68
        public byte[] m_depadBuffer; // 0x70
        public byte[] m_shiftRegister; // 0x78
        public byte[] s_Sbox;
        public int[] s_Rcon; // 0x8
        public int[] s_T; // 0x10
        public int[] s_TF; // 0x18
        public int[] s_iT; // 0x20
        public int[] s_iTF; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84214A0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC841DA00 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAC841D9F0
        public void get_BlockSizeValue(){} // RVA: 0x7FFAC44357F0
        public void get_InputBlockSize(){} // RVA: 0x7FFAC3921980
        public void get_OutputBlockSize(){} // RVA: 0x7FFAC32EC4C0
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7FFAC3006850
        public void get_CanReuseTransform(){} // RVA: 0x7FFAC3006850
        public void TransformBlock(){} // RVA: 0x7FFAC841DCD0
        public void TransformFinalBlock(){} // RVA: 0x7FFAC841E1A0
        public void Reset(){} // RVA: 0x7FFAC841E5E0
        public void EncryptData(){} // RVA: 0x7FFAC841E760
        public void DecryptData(){} // RVA: 0x7FFAC841F540
        public void Enc(){} // RVA: 0x7FFAC8420480
        public void Dec(){} // RVA: 0x7FFAC8420690
        public void GenerateKeyExpansion(){} // RVA: 0x7FFAC84208C0
        public void rot1(){} // RVA: 0x7FFAC8420F30
        public void rot2(){} // RVA: 0x7FFAC8420F40
        public void rot3(){} // RVA: 0x7FFAC8420F50
        public void SubWord(){} // RVA: 0x7FFAC8420F60
        public void MulX(){} // RVA: 0x7FFAC8421040
        public void .cctor(){} // RVA: 0x7FFAC8421070
    }

}