// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 27
// Methods: 289

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class RC2 : SymmetricAlgorithm
    {
        public int EffectiveKeySizeValue; // 0x48
        public System.Security.Cryptography.KeySizes[] s_legalBlockSizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867C5040
        public void get_EffectiveKeySize(){} // RVA: 0x7FFE867C5170
        public void set_EffectiveKeySize(){} // RVA: 0x7FFE867C5180
        public void get_KeySize(){} // RVA: 0x7FFE81D46090
        public void set_KeySize(){} // RVA: 0x7FFE867C52D0
        public void Create(){} // RVA: 0x7FFE867C53A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE867C5480
    }

    public class RC2CryptoServiceProvider : RC2
    {
        public bool m_use40bitSalt; // 0x50
        public System.Security.Cryptography.KeySizes[] s_legalKeySizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867C5700
        public void get_EffectiveKeySize(){} // RVA: 0x7FFE81D46090
        public void set_EffectiveKeySize(){} // RVA: 0x7FFE867C5950
        public void get_UseSalt(){} // RVA: 0x7FFE811B58E0
        public void set_UseSalt(){} // RVA: 0x7FFE811B58F0
        public void CreateEncryptor(){} // RVA: 0x7FFE867C59D0
        public void CreateDecryptor(){} // RVA: 0x7FFE867C5AB0
        public void GenerateKey(){} // RVA: 0x7FFE867C5B90
        public void GenerateIV(){} // RVA: 0x7FFE867C5C80
        public void .cctor(){} // RVA: 0x7FFE867C5D60
    }

    public class RC2Transform : SymmetricTransform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867EB600
        public void ECB(){} // RVA: 0x7FFE867EBC20
        public void .cctor(){} // RVA: 0x7FFE867EC740
    }

    public class RIPEMD160 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867CADE0
        public void Create(){} // RVA: 0x7FFE867CAE40 | overloaded x2
    }

    public class RIPEMD160Managed : RIPEMD160
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867CAF20
        public void Initialize(){} // RVA: 0x7FFE867CB0D0
        public void HashCore(){} // RVA: 0x7FFE867CB130
        public void HashFinal(){} // RVA: 0x7FFE867CB140
        public void InitializeState(){} // RVA: 0x7FFE867CB150
        public void _HashData(){} // RVA: 0x7FFE867CB1E0
        public void _EndHash(){} // RVA: 0x7FFE867CB4D0
        public void MDTransform(){} // RVA: 0x7FFE867CB7C0
        public void F(){} // RVA: 0x7FFE867CDD90
        public void G(){} // RVA: 0x7FFE867CDDA0
        public void H(){} // RVA: 0x7FFE867CDDB0
        public void I(){} // RVA: 0x7FFE867CDDC0
        public void J(){} // RVA: 0x7FFE867CDDD0
    }

    public class RNGCryptoServiceProvider : RandomNumberGenerator
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE867EC820
        public void .ctor(){} // RVA: 0x7FFE867EC9D0 | overloaded x4
        public void Check(){} // RVA: 0x7FFE867ECAC0
        public void RngOpen(){} // RVA: 0x7FFE810FB320
        public void RngInitialize(){} // RVA: 0x7FFE867ECB40
        public void RngGetBytes(){} // RVA: 0x7FFE867ECB50
        public void RngClose(){} // RVA: 0x7FFE867ECBE0
        public void GetBytes(){} // RVA: 0x7FFE867ECEA0 | overloaded x2
        public void GetNonZeroBytes(){} // RVA: 0x7FFE867ED0D0
        public void Finalize(){} // RVA: 0x7FFE867ED2C0
        public void Dispose(){} // RVA: 0x7FFE810FB310
    }

    public class RSA : AsymmetricAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE867D0920 | overloaded x4
        public void Encrypt(){} // RVA: 0x7FFE867CDF20
        public void Decrypt(){} // RVA: 0x7FFE867CDF50
        public void SignHash(){} // RVA: 0x7FFE867CDF80
        public void VerifyHash(){} // RVA: 0x7FFE867D1940 | overloaded x2
        public void HashData(){} // RVA: 0x7FFE867CE010 | overloaded x2
        public void SignData(){} // RVA: 0x7FFE867CE3B0 | overloaded x3
        public void VerifyData(){} // RVA: 0x7FFE867D14A0 | overloaded x4
        public void DerivedClassMustOverride(){} // RVA: 0x7FFE867CEC00
        public void HashAlgorithmNameNullOrEmpty(){} // RVA: 0x7FFE867CEC80
        public void DecryptValue(){} // RVA: 0x7FFE867CED10
        public void EncryptValue(){} // RVA: 0x7FFE867CED70
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7FFE867CEDD0
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFE867CEE10
        public void FromXmlString(){} // RVA: 0x7FFE867CEE50
        public void ToXmlString(){} // RVA: 0x7FFE867CFE50
        public void ExportParameters(){}
        public void ImportParameters(){}
        public void TryDecrypt(){} // RVA: 0x7FFE867D0A10
        public void TryEncrypt(){} // RVA: 0x7FFE867D0BA0
        public void TryHashData(){} // RVA: 0x7FFE867D0D30
        public void TrySignHash(){} // RVA: 0x7FFE867D1020
        public void TrySignData(){} // RVA: 0x7FFE867D11C0
        public void ExportRSAPrivateKey(){} // RVA: 0x7FFE867D19E0
        public void ExportRSAPublicKey(){} // RVA: 0x7FFE867D1A20
        public void ImportRSAPrivateKey(){} // RVA: 0x7FFE867D1A60
        public void ImportRSAPublicKey(){} // RVA: 0x7FFE867D1AA0
        public void TryExportRSAPrivateKey(){} // RVA: 0x7FFE867D1AE0
        public void TryExportRSAPublicKey(){} // RVA: 0x7FFE867D1B20
    }

    public class RSACryptoServiceProvider : RSA
    {
        public 0x664C5204 s_UseMachineKeyStore;
        public int PROV_RSA_FULL;
        public int AT_KEYEXCHANGE;
        public int AT_SIGNATURE;
        public Mono.Security.Cryptography.KeyPairPersistence store; // 0x20
        public bool persistKey; // 0x28
        public bool persisted; // 0x29

        // ── Methods ──
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFE867D1B60
        public void get_UseMachineKeyStore(){} // RVA: 0x7FFE867D1BA0
        public void set_UseMachineKeyStore(){} // RVA: 0x7FFE867D1BF0
        public void HashData(){} // RVA: 0x7FFE867D1CA0 | overloaded x2
        public void GetAlgorithmId(){} // RVA: 0x7FFE867D1CE0
        public void Encrypt(){} // RVA: 0x7FFE867D3A70 | overloaded x2
        public void Decrypt(){} // RVA: 0x7FFE867D3500 | overloaded x2
        public void SignHash(){} // RVA: 0x7FFE867D4A00 | overloaded x3
        public void VerifyHash(){} // RVA: 0x7FFE867D4E70 | overloaded x3
        public void PaddingModeNotSupported(){} // RVA: 0x7FFE867D2950
        public void .ctor(){} // RVA: 0x7FFE867D2B80 | overloaded x4
        public void Common(){} // RVA: 0x7FFE867D3270 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE865ED780
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7FFE867D33E0
        public void get_KeySize(){} // RVA: 0x7FFE867D3420
        public void get_PersistKeyInCsp(){} // RVA: 0x7FFE815F1380
        public void set_PersistKeyInCsp(){} // RVA: 0x7FFE867D3450
        public void get_PublicOnly(){} // RVA: 0x7FFE867D34E0
        public void DecryptValue(){} // RVA: 0x7FFE867D39E0
        public void EncryptValue(){} // RVA: 0x7FFE867D3DC0
        public void ExportParameters(){} // RVA: 0x7FFE867D3DF0
        public void ImportParameters(){} // RVA: 0x7FFE867D3F90
        public void GetHash(){} // RVA: 0x7FFE867D3FF0
        public void GetHashFromString(){} // RVA: 0x7FFE867D4310
        public void SignData(){} // RVA: 0x7FFE867D4590 | overloaded x3
        public void GetHashNameFromOID(){} // RVA: 0x7FFE867D4660
        public void InternalHashToHashAlgorithm(){} // RVA: 0x7FFE867D4A80
        public void VerifyData(){} // RVA: 0x7FFE867D4BB0
        public void Dispose(){} // RVA: 0x7FFE867D4F00
        public void OnKeyGenerated(){} // RVA: 0x7FFE867D4F50
        public void get_CspKeyContainerInfo(){} // RVA: 0x7FFE867D4FE0
        public void ExportCspBlob(){} // RVA: 0x7FFE867D50A0
        public void ImportCspBlob(){} // RVA: 0x7FFE867D5120
    }

    public class RSAEncryptionPadding : Object
    {
        public System.Security.Cryptography.RSAEncryptionPadding s_pkcs1;
        public System.Security.Cryptography.RSAEncryptionPadding s_oaepSHA1; // 0x8
        public System.Security.Cryptography.RSAEncryptionPadding s_oaepSHA256; // 0x10
        public System.Security.Cryptography.RSAEncryptionPadding s_oaepSHA384; // 0x18
        public System.Security.Cryptography.RSAEncryptionPadding s_oaepSHA512; // 0x20
        public 0x664C4C2C _mode; // 0x10
        public System.Security.Cryptography.HashAlgorithmName _oaepHashAlgorithm; // 0x18

        // ── Methods ──
        public void get_Pkcs1(){} // RVA: 0x7FFE867B5B30
        public void get_OaepSHA1(){} // RVA: 0x7FFE867B5B90
        public void get_OaepSHA256(){} // RVA: 0x7FFE867B5BF0
        public void get_OaepSHA384(){} // RVA: 0x7FFE867B5C50
        public void get_OaepSHA512(){} // RVA: 0x7FFE867B5CB0
        public void .ctor(){} // RVA: 0x7FFE867B6410 | overloaded x2
        public void CreateOaep(){} // RVA: 0x7FFE867B5D10
        public void get_Mode(){} // RVA: 0x7FFE811485C0
        public void get_OaepHashAlgorithm(){} // RVA: 0x7FFE810FE7C0
        public void GetHashCode(){} // RVA: 0x7FFE867B5E20
        public void CombineHashCodes(){} // RVA: 0x7FFE84897A50
        public void Equals(){} // RVA: 0x7FFE867B5F00 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE867B6000
        public void op_Inequality(){} // RVA: 0x7FFE867B6020
        public void ToString(){} // RVA: 0x7FFE867B60A0
        public void .cctor(){} // RVA: 0x7FFE867B6110
    }

    public class RSAOAEPKeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
    {
        public System.Security.Cryptography.RSA _rsaKey; // 0x10
        public System.Nullable`1<bool> _rsaOverridesDecrypt; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867D54B0 | overloaded x2
        public void get_Parameters(){} // RVA: 0x7FFE813240E0
        public void set_Parameters(){} // RVA: 0x7FFE810FB310
        public void DecryptKeyExchange(){} // RVA: 0x7FFE867D5610
        public void SetKey(){} // RVA: 0x7FFE867D5850
        public void get_OverridesDecrypt(){} // RVA: 0x7FFE867D59B0
    }

    public class RSAOAEPKeyExchangeFormatter : AsymmetricKeyExchangeFormatter
    {
        public byte[] ParameterValue; // 0x10
        public System.Security.Cryptography.RSA _rsaKey; // 0x18
        public System.Nullable`1<bool> _rsaOverridesEncrypt; // 0x20
        public System.Security.Cryptography.RandomNumberGenerator RngValue; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867D5BC0 | overloaded x2
        public void get_Parameter(){} // RVA: 0x7FFE867D5D20
        public void set_Parameter(){} // RVA: 0x7FFE867D5DA0
        public void get_Parameters(){} // RVA: 0x7FFE813240E0
        public void get_Rng(){} // RVA: 0x7FFE81129130
        public void set_Rng(){} // RVA: 0x7FFE810FCE90
        public void SetKey(){} // RVA: 0x7FFE867D5F00
        public void CreateKeyExchange(){} // RVA: 0x7FFE84C79010 | overloaded x2
        public void get_OverridesEncrypt(){} // RVA: 0x7FFE867D6260
    }

    public class RSAPKCS1KeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
    {
        public System.Security.Cryptography.RSA _rsaKey; // 0x10
        public System.Nullable`1<bool> _rsaOverridesDecrypt; // 0x18
        public System.Security.Cryptography.RandomNumberGenerator RngValue; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867D6470 | overloaded x2
        public void get_RNG(){} // RVA: 0x7FFE811290C0
        public void set_RNG(){} // RVA: 0x7FFE811290D0
        public void get_Parameters(){} // RVA: 0x7FFE813240E0
        public void set_Parameters(){} // RVA: 0x7FFE810FB310
        public void DecryptKeyExchange(){} // RVA: 0x7FFE867D65D0
        public void SetKey(){} // RVA: 0x7FFE867D6830
        public void get_OverridesDecrypt(){} // RVA: 0x7FFE867D6990
    }

    public class RSAPKCS1KeyExchangeFormatter : AsymmetricKeyExchangeFormatter
    {
        public System.Security.Cryptography.RandomNumberGenerator RngValue; // 0x10
        public System.Security.Cryptography.RSA _rsaKey; // 0x18
        public System.Nullable`1<bool> _rsaOverridesEncrypt; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867D6BA0 | overloaded x2
        public void get_Parameters(){} // RVA: 0x7FFE867D6D00
        public void get_Rng(){} // RVA: 0x7FFE81116380
        public void set_Rng(){} // RVA: 0x7FFE810FCE30
        public void SetKey(){} // RVA: 0x7FFE867D6D40
        public void CreateKeyExchange(){} // RVA: 0x7FFE84C79010 | overloaded x2
        public void get_OverridesEncrypt(){} // RVA: 0x7FFE867D7210
    }

    public class RSAPKCS1SHA1SignatureDescription : RSAPKCS1SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867DE090
    }

    public class RSAPKCS1SHA256SignatureDescription : RSAPKCS1SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867DE0F0
    }

    public class RSAPKCS1SHA384SignatureDescription : RSAPKCS1SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867DE150
    }

    public class RSAPKCS1SHA512SignatureDescription : RSAPKCS1SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867DE1B0
    }

    public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867ED360 | overloaded x2
        public void SetHashAlgorithm(){} // RVA: 0x7FFE867ED380
        public void SetKey(){} // RVA: 0x7FFE867ED430
        public void VerifySignature(){} // RVA: 0x7FFE867ED590
    }

    public class RSAPKCS1SignatureDescription : SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867DDC00
        public void CreateDeformatter(){} // RVA: 0x7FFE867DDE30
        public void CreateFormatter(){} // RVA: 0x7FFE867DDF60
    }

    public class RSAPKCS1SignatureFormatter : AsymmetricSignatureFormatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867ED360 | overloaded x2
        public void CreateSignature(){} // RVA: 0x7FFE867ED780
        public void SetHashAlgorithm(){} // RVA: 0x7FFE867ED910
        public void SetKey(){} // RVA: 0x7FFE867ED9C0
    }

    public class RSAParameters : ValueType
    {
    }

    public class RSASignaturePadding : Object
    {
        public System.Security.Cryptography.RSASignaturePadding s_pkcs1;
        public System.Security.Cryptography.RSASignaturePadding s_pss; // 0x8
        public 0x664C4CDC _mode; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867B6850 | overloaded x2
        public void get_Pkcs1(){} // RVA: 0x7FFE867B6440
        public void get_Pss(){} // RVA: 0x7FFE867B64A0
        public void get_Mode(){} // RVA: 0x7FFE811485C0
        public void GetHashCode(){} // RVA: 0x7FFE811485C0
        public void Equals(){} // RVA: 0x7FFE867B6560 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE867B6620
        public void op_Inequality(){} // RVA: 0x7FFE867B6640
        public void ToString(){} // RVA: 0x7FFE867B66C0
        public void .cctor(){} // RVA: 0x7FFE867B6720
    }

    public class RandomNumberGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE867C4510 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void GetBytes(){} // RVA: 0x7FFE867C49B0 | overloaded x3
        public void GetNonZeroBytes(){} // RVA: 0x7FFE867C4C00 | overloaded x2
        public void Fill(){} // RVA: 0x7FFE867C48E0
        public void FillSpan(){} // RVA: 0x7FFE867C4950
        public void GetInt32(){} // RVA: 0x7FFE867C4FB0 | overloaded x2
    }

    public class Rfc2898DeriveBytes : DeriveBytes
    {
        public int MinimumSaltSize;
        public byte[] _password; // 0x10
        public byte[] _salt; // 0x18

        // ── Methods ──
        public void get_HashAlgorithm(){} // RVA: 0x7FFE8119C0E0
        public void .ctor(){} // RVA: 0x7FFE867AD350 | overloaded x8
        public void get_IterationCount(){} // RVA: 0x7FFE8151D690
        public void set_IterationCount(){} // RVA: 0x7FFE867AD560
        public void get_Salt(){} // RVA: 0x7FFE867AD5F0
        public void set_Salt(){} // RVA: 0x7FFE867AD670
        public void Dispose(){} // RVA: 0x7FFE867AD7F0
        public void GetBytes(){} // RVA: 0x7FFE867AD8C0
        public void CryptDeriveKey(){} // RVA: 0x7FFE867ADA70
        public void Reset(){} // RVA: 0x7FFE867ADAB0
        public void OpenHmac(){} // RVA: 0x7FFE867ADAC0
        public void Initialize(){} // RVA: 0x7FFE867ADDA0
        public void Func(){} // RVA: 0x7FFE867ADE60
    }

    public class Rijndael : SymmetricAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867C5EC0
        public void Create(){} // RVA: 0x7FFE867C6040 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE867C6120
    }

    public class RijndaelManaged : Rijndael
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867C63A0
        public void CreateEncryptor(){} // RVA: 0x7FFE867C6540
        public void CreateDecryptor(){} // RVA: 0x7FFE867C6670
        public void GenerateKey(){} // RVA: 0x7FFE867C67A0
        public void GenerateIV(){} // RVA: 0x7FFE867C6850
        public void NewEncryptor(){} // RVA: 0x7FFE867C6900
    }

    public class RijndaelManagedTransform : Object
    {
        public 0x664C504C m_cipherMode; // 0x10
        public 0x664C50A4 m_paddingValue; // 0x14
        public 0x664C5BFC m_transformMode; // 0x18
        public int m_blockSizeBits; // 0x1C
        public int m_blockSizeBytes; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867CADB0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFE867C7310 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE867C7300
        public void get_BlockSizeValue(){} // RVA: 0x7FFE82707EE0
        public void get_InputBlockSize(){} // RVA: 0x7FFE81A56130
        public void get_OutputBlockSize(){} // RVA: 0x7FFE81549710
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7FFE811E0850
        public void get_CanReuseTransform(){} // RVA: 0x7FFE811E0850
        public void TransformBlock(){} // RVA: 0x7FFE867C75E0
        public void TransformFinalBlock(){} // RVA: 0x7FFE867C7AB0
        public void Reset(){} // RVA: 0x7FFE867C7EF0
        public void EncryptData(){} // RVA: 0x7FFE867C8070
        public void DecryptData(){} // RVA: 0x7FFE867C8E50
        public void Enc(){} // RVA: 0x7FFE867C9D90
        public void Dec(){} // RVA: 0x7FFE867C9FA0
        public void GenerateKeyExpansion(){} // RVA: 0x7FFE867CA1D0
        public void rot1(){} // RVA: 0x7FFE867CA840
        public void rot2(){} // RVA: 0x7FFE867CA850
        public void rot3(){} // RVA: 0x7FFE867CA860
        public void SubWord(){} // RVA: 0x7FFE867CA870
        public void MulX(){} // RVA: 0x7FFE867CA950
        public void .cctor(){} // RVA: 0x7FFE867CA980
    }

}