// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 26
// Methods: 232

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class RC2 : SymmetricAlgorithm
    {
        public object EffectiveKeySizeValue;
        public object s_legalBlockSizes;
        public object s_legalKeySizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66FC800
        public void get_EffectiveKeySize(){} // RVA: 0x66FC930
        public void set_EffectiveKeySize(){} // RVA: 0x66FC940
        public void get_KeySize(){} // RVA: 0x18A0130
        public void set_KeySize(){} // RVA: 0x66FCA90
        public void Create(){} // RVA: 0x66FCB60
        public void .cctor(){} // RVA: 0x66FCC40
    }

    public class RC2CryptoServiceProvider : RC2
    {
        public object m_use40bitSalt;
        public object s_legalKeySizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66FCEC0
        public void get_EffectiveKeySize(){} // RVA: 0x18A0130
        public void set_EffectiveKeySize(){} // RVA: 0x66FD110
        public void get_UseSalt(){} // RVA: 0xC00EC0
        public void set_UseSalt(){} // RVA: 0xC00ED0
        public void CreateEncryptor(){} // RVA: 0x66FD190
        public void CreateDecryptor(){} // RVA: 0x66FD270
        public void GenerateKey(){} // RVA: 0x66FD350
        public void GenerateIV(){} // RVA: 0x66FD440
        public void .cctor(){} // RVA: 0x66FD520
    }

    public class RC2Transform : SymmetricTransform
    {
        public object R0;
        public object R1;
        public object R2;
        public object R3;
        public object K;
        public object j;
        public object pitable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6722EF0
        public void ECB(){} // RVA: 0x67235A0
        public void .cctor(){} // RVA: 0x67240E0
    }

    public class RIPEMD160 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67027C0
        public void Create(){} // RVA: 0x6702820
    }

    public class RIPEMD160Managed : RIPEMD160
    {
        public object _buffer;
        public object _count;
        public object _stateMD160;
        public object _blockDWords;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6702900
        public void Initialize(){} // RVA: 0x6702AB0
        public void HashCore(){} // RVA: 0x6702B10
        public void HashFinal(){} // RVA: 0x6702B20
        public void InitializeState(){} // RVA: 0x6702B30
        public void _HashData(){} // RVA: 0x6702BC0
        public void _EndHash(){} // RVA: 0x6702EB0
        public void MDTransform(){} // RVA: 0x6703180
        public void F(){} // RVA: 0x67056B0
        public void G(){} // RVA: 0x67056C0
        public void H(){} // RVA: 0x67056D0
        public void I(){} // RVA: 0x67056E0
        public void J(){} // RVA: 0x67056F0
    }

    public class RNGCryptoServiceProvider : RandomNumberGenerator
    {
        public object _lock;
        public object _handle;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x67241C0
        public void .ctor(){} // RVA: 0x6724420
        public void Check(){} // RVA: 0x6724570
        public void RngOpen(){} // RVA: 0xC2E4C0
        public void RngInitialize(){} // RVA: 0x67245F0
        public void RngGetBytes(){} // RVA: 0x6724680
        public void RngClose(){} // RVA: 0xB43310
        public void GetBytes(){} // RVA: 0x6724970
        public void GetNonZeroBytes(){} // RVA: 0x6724B70
        public void Finalize(){} // RVA: 0x6724D60
        public void Dispose(){} // RVA: 0xB43310
    }

    public class RSA : AsymmetricAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x6708240
        public void Encrypt(){} // RVA: 0x6705840
        public void Decrypt(){} // RVA: 0x6705870
        public void SignHash(){} // RVA: 0x67058A0
        public void VerifyHash(){} // RVA: 0x6709280
        public void HashData(){} // RVA: 0x6705930
        public void SignData(){} // RVA: 0x6705CD0
        public void VerifyData(){} // RVA: 0x6708DD0
        public void DerivedClassMustOverride(){} // RVA: 0x6706520
        public void HashAlgorithmNameNullOrEmpty(){} // RVA: 0x67065A0
        public void DecryptValue(){} // RVA: 0x6706630
        public void EncryptValue(){} // RVA: 0x6706690
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x67066F0
        public void get_SignatureAlgorithm(){} // RVA: 0x6706730
        public void FromXmlString(){} // RVA: 0x6706770
        public void ToXmlString(){} // RVA: 0x6707770
        public void ExportParameters(){} // RVA: 0x87C840
        public void ImportParameters(){} // RVA: 0x894320
        public void TryDecrypt(){} // RVA: 0x6708340
        public void TryEncrypt(){} // RVA: 0x67084D0
        public void TryHashData(){} // RVA: 0x6708660
        public void TrySignHash(){} // RVA: 0x6708950
        public void TrySignData(){} // RVA: 0x6708AF0
        public void ExportRSAPrivateKey(){} // RVA: 0x6709320
        public void ExportRSAPublicKey(){} // RVA: 0x6709360
        public void ImportRSAPrivateKey(){} // RVA: 0x67093A0
        public void ImportRSAPublicKey(){} // RVA: 0x67093E0
        public void TryExportRSAPrivateKey(){} // RVA: 0x6709420
        public void TryExportRSAPublicKey(){} // RVA: 0x6709460
    }

    public class RSACryptoServiceProvider : RSA
    {
        public object s_UseMachineKeyStore;
        public object PROV_RSA_FULL;
        public object AT_KEYEXCHANGE;
        public object AT_SIGNATURE;
        public object store;
        public object persistKey;
        public object persisted;
        public object privateKeyExportable;
        public object m_disposed;
        public object rsa;

        // ── Methods ──
        public void get_SignatureAlgorithm(){} // RVA: 0x67094A0
        public void get_UseMachineKeyStore(){} // RVA: 0x67094E0
        public void set_UseMachineKeyStore(){} // RVA: 0x6709530
        public void HashData(){} // RVA: 0x67095E0
        public void GetAlgorithmId(){} // RVA: 0x6709620
        public void Encrypt(){} // RVA: 0x670B3A0
        public void Decrypt(){} // RVA: 0x670AE40
        public void SignHash(){} // RVA: 0x670C300
        public void VerifyHash(){} // RVA: 0x670C770
        public void PaddingModeNotSupported(){} // RVA: 0x670A290
        public void .ctor(){} // RVA: 0x670A4C0
        public void Common(){} // RVA: 0x670ABB0
        public void Finalize(){} // RVA: 0x6527310
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x670AD20
        public void get_KeySize(){} // RVA: 0x670AD60
        public void get_PersistKeyInCsp(){} // RVA: 0xF73960
        public void set_PersistKeyInCsp(){} // RVA: 0x670AD90
        public void get_PublicOnly(){} // RVA: 0x670AE20
        public void DecryptValue(){} // RVA: 0x670B310
        public void EncryptValue(){} // RVA: 0x670B6F0
        public void ExportParameters(){} // RVA: 0x670B720
        public void ImportParameters(){} // RVA: 0x670B8C0
        public void GetHash(){} // RVA: 0x670B920
        public void GetHashFromString(){} // RVA: 0x670BC10
        public void SignData(){} // RVA: 0x670BE90
        public void GetHashNameFromOID(){} // RVA: 0x670BF60
        public void InternalHashToHashAlgorithm(){} // RVA: 0x670C380
        public void VerifyData(){} // RVA: 0x670C4B0
        public void Dispose(){} // RVA: 0x670C800
        public void OnKeyGenerated(){} // RVA: 0x670C850
        public void get_CspKeyContainerInfo(){} // RVA: 0x670C8E0
        public void ExportCspBlob(){} // RVA: 0x670C9A0
        public void ImportCspBlob(){} // RVA: 0x670CA20
    }

    public class RSAEncryptionPadding : Object
    {
        public object s_pkcs1;
        public object s_oaepSHA1;
        public object s_oaepSHA256;
        public object s_oaepSHA384;
        public object s_oaepSHA512;
        public object _mode;
        public object _oaepHashAlgorithm;

        // ── Methods ──
        public void get_Pkcs1(){} // RVA: 0x66ED260
        public void get_OaepSHA1(){} // RVA: 0x66ED2C0
        public void get_OaepSHA256(){} // RVA: 0x66ED320
        public void get_OaepSHA384(){} // RVA: 0x66ED380
        public void get_OaepSHA512(){} // RVA: 0x66ED3E0
        public void .ctor(){} // RVA: 0x66EDB40
        public void CreateOaep(){} // RVA: 0x66ED440
        public void get_Mode(){} // RVA: 0xB8F8F0
        public void get_OaepHashAlgorithm(){} // RVA: 0xB465B0
        public void GetHashCode(){} // RVA: 0x66ED550
        public void CombineHashCodes(){} // RVA: 0x469E1D0
        public void Equals(){} // RVA: 0x66ED630
        public void op_Equality(){} // RVA: 0x66ED730
        public void op_Inequality(){} // RVA: 0x66ED750
        public void ToString(){} // RVA: 0x66ED7D0
        public void .cctor(){} // RVA: 0x66ED840
    }

    public class RSAOAEPKeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
    {
        public object _rsaKey;
        public object _rsaOverridesDecrypt;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x670CDB0
        public void get_Parameters(){} // RVA: 0xDAC980
        public void set_Parameters(){} // RVA: 0xB43310
        public void DecryptKeyExchange(){} // RVA: 0x670CF10
        public void SetKey(){} // RVA: 0x670D150
        public void get_OverridesDecrypt(){} // RVA: 0x670D2B0
    }

    public class RSAOAEPKeyExchangeFormatter : AsymmetricKeyExchangeFormatter
    {
        public object ParameterValue;
        public object _rsaKey;
        public object _rsaOverridesEncrypt;
        public object RngValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x670D500
        public void get_Parameter(){} // RVA: 0x670D660
        public void set_Parameter(){} // RVA: 0x670D6E0
        public void get_Parameters(){} // RVA: 0xDAC980
        public void get_Rng(){} // RVA: 0xB70160
        public void set_Rng(){} // RVA: 0xB44DC0
        public void SetKey(){} // RVA: 0x670D840
        public void CreateKeyExchange(){} // RVA: 0x4AB63B0
        public void get_OverridesEncrypt(){} // RVA: 0x670DBA0
    }

    public class RSAPKCS1KeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
    {
        public object _rsaKey;
        public object _rsaOverridesDecrypt;
        public object RngValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x670DDF0
        public void get_RNG(){} // RVA: 0xB700F0
        public void set_RNG(){} // RVA: 0xB70100
        public void get_Parameters(){} // RVA: 0xDAC980
        public void set_Parameters(){} // RVA: 0xB43310
        public void DecryptKeyExchange(){} // RVA: 0x670DF50
        public void SetKey(){} // RVA: 0x670E1B0
        public void get_OverridesDecrypt(){} // RVA: 0x670E310
    }

    public class RSAPKCS1KeyExchangeFormatter : AsymmetricKeyExchangeFormatter
    {
        public object RngValue;
        public object _rsaKey;
        public object _rsaOverridesEncrypt;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x670E560
        public void get_Parameters(){} // RVA: 0x670E6C0
        public void get_Rng(){} // RVA: 0xB5DBF0
        public void set_Rng(){} // RVA: 0xB44D60
        public void SetKey(){} // RVA: 0x670E700
        public void CreateKeyExchange(){} // RVA: 0x4AB63B0
        public void get_OverridesEncrypt(){} // RVA: 0x670EBC0
    }

    public class RSAPKCS1SHA1SignatureDescription : RSAPKCS1SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6715CB0
    }

    public class RSAPKCS1SHA256SignatureDescription : RSAPKCS1SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6715D10
    }

    public class RSAPKCS1SHA384SignatureDescription : RSAPKCS1SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6715D70
    }

    public class RSAPKCS1SHA512SignatureDescription : RSAPKCS1SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6715DD0
    }

    public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
    {
        public object rsa;
        public object hashName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6724DF0
        public void SetHashAlgorithm(){} // RVA: 0x6724E10
        public void SetKey(){} // RVA: 0x6724EC0
        public void VerifySignature(){} // RVA: 0x6725020
    }

    public class RSAPKCS1SignatureDescription : SignatureDescription
    {
        public object _hashAlgorithm;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6715820
        public void CreateDeformatter(){} // RVA: 0x6715A50
        public void CreateFormatter(){} // RVA: 0x6715B80
    }

    public class RSAPKCS1SignatureFormatter : AsymmetricSignatureFormatter
    {
        public object rsa;
        public object hash;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6724DF0
        public void CreateSignature(){} // RVA: 0x6725210
        public void SetHashAlgorithm(){} // RVA: 0x67253A0
        public void SetKey(){} // RVA: 0x6725450
    }

    public class RSASignaturePadding : Object
    {
        public object s_pkcs1;
        public object s_pss;
        public object _mode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66EDF80
        public void get_Pkcs1(){} // RVA: 0x66EDB70
        public void get_Pss(){} // RVA: 0x66EDBD0
        public void get_Mode(){} // RVA: 0xB8F8F0
        public void GetHashCode(){} // RVA: 0xB8F8F0
        public void Equals(){} // RVA: 0x66EDC90
        public void op_Equality(){} // RVA: 0x66EDD50
        public void op_Inequality(){} // RVA: 0x66EDD70
        public void ToString(){} // RVA: 0x66EDDF0
        public void .cctor(){} // RVA: 0x66EDE50
    }

    public class RandomNumberGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x66FBCE0
        public void Dispose(){} // RVA: 0xB43310
        public void GetBytes(){} // RVA: 0x66FC180
        public void GetNonZeroBytes(){} // RVA: 0x66FC3C0
        public void Fill(){} // RVA: 0x66FC0B0
        public void FillSpan(){} // RVA: 0x66FC120
        public void GetInt32(){} // RVA: 0x66FC770
    }

    public class Rfc2898DeriveBytes : DeriveBytes
    {
        public object MinimumSaltSize;
        public object _password;
        public object _salt;
        public object _iterations;
        public object _hmac;
        public object _blockSize;
        public object _buffer;
        public object _block;
        public object _startIndex;
        public object _endIndex;
        public object _hashAlgorithm;

        // ── Methods ──
        public void get_HashAlgorithm(){} // RVA: 0xBE58B0
        public void .ctor(){} // RVA: 0x66E4B20
        public void get_IterationCount(){} // RVA: 0xFEAE90
        public void set_IterationCount(){} // RVA: 0x66E4D30
        public void get_Salt(){} // RVA: 0x66E4DC0
        public void set_Salt(){} // RVA: 0x66E4E40
        public void Dispose(){} // RVA: 0x66E4FC0
        public void GetBytes(){} // RVA: 0x66E5090
        public void CryptDeriveKey(){} // RVA: 0x66E5240
        public void Reset(){} // RVA: 0x66E5280
        public void OpenHmac(){} // RVA: 0x66E5290
        public void Initialize(){} // RVA: 0x66E5570
        public void Func(){} // RVA: 0x66E5630
    }

    public class Rijndael : SymmetricAlgorithm
    {
        public object s_legalBlockSizes;
        public object s_legalKeySizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66FD680
        public void Create(){} // RVA: 0x66FD800
        public void .cctor(){} // RVA: 0x66FD8E0
    }

    public class RijndaelManaged : Rijndael
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66FDB60
        public void CreateEncryptor(){} // RVA: 0x66FDD00
        public void CreateDecryptor(){} // RVA: 0x66FDE30
        public void GenerateKey(){} // RVA: 0x66FDF60
        public void GenerateIV(){} // RVA: 0x66FE010
        public void NewEncryptor(){} // RVA: 0x66FE0C0
    }

    public class RijndaelManagedTransform : Object
    {
        public object m_cipherMode;
        public object m_paddingValue;
        public object m_transformMode;
        public object m_blockSizeBits;
        public object m_blockSizeBytes;
        public object m_inputBlockSize;
        public object m_outputBlockSize;
        public object m_encryptKeyExpansion;
        public object m_decryptKeyExpansion;
        public object m_Nr;
        public object m_Nb;
        public object m_Nk;
        public object m_encryptindex;
        public object m_decryptindex;
        public object m_IV;
        public object m_lastBlockBuffer;
        public object m_depadBuffer;
        public object m_shiftRegister;
        public object s_Sbox;
        public object s_Rcon;
        public object s_T;
        public object s_TF;
        public object s_iT;
        public object s_iTF;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6702790
        public void Dispose(){} // RVA: 0x66FEB10
        public void Clear(){} // RVA: 0x66FEB00
        public void get_BlockSizeValue(){} // RVA: 0x2244FB0
        public void get_InputBlockSize(){} // RVA: 0x15AF000
        public void get_OutputBlockSize(){} // RVA: 0x1065D50
        public void get_CanTransformMultipleBlocks(){} // RVA: 0xC2E4C0
        public void get_CanReuseTransform(){} // RVA: 0xC2E4C0
        public void TransformBlock(){} // RVA: 0x66FEDE0
        public void TransformFinalBlock(){} // RVA: 0x66FF2B0
        public void Reset(){} // RVA: 0x66FF6E0
        public void EncryptData(){} // RVA: 0x66FF860
        public void DecryptData(){} // RVA: 0x67006E0
        public void Enc(){} // RVA: 0x6701710
        public void Dec(){} // RVA: 0x6701920
        public void GenerateKeyExpansion(){} // RVA: 0x6701B50
        public void rot1(){} // RVA: 0x6702210
        public void rot2(){} // RVA: 0x6702220
        public void rot3(){} // RVA: 0x6702230
        public void SubWord(){} // RVA: 0x6702240
        public void MulX(){} // RVA: 0x6702330
        public void .cctor(){} // RVA: 0x6702360
    }

}