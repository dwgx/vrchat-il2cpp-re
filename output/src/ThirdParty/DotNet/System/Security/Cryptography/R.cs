// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 27
// Methods: 289

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class RC2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C841A0
        public void get_EffectiveKeySize(){} // RVA: 0x5C842D0
        public void set_EffectiveKeySize(){} // RVA: 0x5C842E0
        public void get_KeySize(){} // RVA: 0xFDC9F0
        public void set_KeySize(){} // RVA: 0x5C84430
        public void Create(){} // RVA: 0x5C84500 | overloaded x2
        public void .cctor(){} // RVA: 0x5C845E0
    }

    public class RC2CryptoServiceProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C84860
        public void get_EffectiveKeySize(){} // RVA: 0xFDC9F0
        public void set_EffectiveKeySize(){} // RVA: 0x5C84AB0
        public void get_UseSalt(){} // RVA: 0x3978E0
        public void set_UseSalt(){} // RVA: 0x3978F0
        public void CreateEncryptor(){} // RVA: 0x5C84B30
        public void CreateDecryptor(){} // RVA: 0x5C84C10
        public void GenerateKey(){} // RVA: 0x5C84CF0
        public void GenerateIV(){} // RVA: 0x5C84DE0
        public void .cctor(){} // RVA: 0x5C84EC0
    }

    public class RC2Transform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CAA700
        public void ECB(){} // RVA: 0x5CAAD20
        public void .cctor(){} // RVA: 0x5CAB840
    }

    public class RIPEMD160
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C89F40
        public void Create(){} // RVA: 0x5C89FA0 | overloaded x2
    }

    public class RIPEMD160Managed
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C8A080
        public void Initialize(){} // RVA: 0x5C8A230
        public void HashCore(){} // RVA: 0x5C8A290
        public void HashFinal(){} // RVA: 0x5C8A2A0
        public void InitializeState(){} // RVA: 0x5C8A2B0
        public void _HashData(){} // RVA: 0x5C8A340
        public void _EndHash(){} // RVA: 0x5C8A630
        public void MDTransform(){} // RVA: 0x5C8A920
        public void F(){} // RVA: 0x5C8CEF0
        public void G(){} // RVA: 0x5C8CF00
        public void H(){} // RVA: 0x5C8CF10
        public void I(){} // RVA: 0x5C8CF20
        public void J(){} // RVA: 0x5C8CF30
    }

    public class RNGCryptoServiceProvider
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5CAB920
        public void .ctor(){} // RVA: 0x5CABAD0 | overloaded x4
        public void Check(){} // RVA: 0x5CABBC0
        public void RngOpen(){} // RVA: 0x2DD320
        public void RngInitialize(){} // RVA: 0x5CABC40
        public void RngGetBytes(){} // RVA: 0x5CABC50
        public void RngClose(){} // RVA: 0x5CABCE0
        public void GetBytes(){} // RVA: 0x5CABFA0 | overloaded x2
        public void GetNonZeroBytes(){} // RVA: 0x5CAC1D0
        public void Finalize(){} // RVA: 0x5CAC3C0
        public void Dispose(){} // RVA: 0x2DD310
    }

    public class RSA
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x5C8FA80 | overloaded x4
        public void Encrypt(){} // RVA: 0x5C8D080
        public void Decrypt(){} // RVA: 0x5C8D0B0
        public void SignHash(){} // RVA: 0x5C8D0E0
        public void VerifyHash(){} // RVA: 0x5C90AA0 | overloaded x2
        public void HashData(){} // RVA: 0x5C8D170 | overloaded x2
        public void SignData(){} // RVA: 0x5C8D510 | overloaded x3
        public void VerifyData(){} // RVA: 0x5C90600 | overloaded x4
        public void DerivedClassMustOverride(){} // RVA: 0x5C8DD60
        public void HashAlgorithmNameNullOrEmpty(){} // RVA: 0x5C8DDE0
        public void DecryptValue(){} // RVA: 0x5C8DE70
        public void EncryptValue(){} // RVA: 0x5C8DED0
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x5C8DF30
        public void get_SignatureAlgorithm(){} // RVA: 0x5C8DF70
        public void FromXmlString(){} // RVA: 0x5C8DFB0
        public void ToXmlString(){} // RVA: 0x5C8EFB0
        public void ExportParameters(){}
        public void ImportParameters(){}
        public void TryDecrypt(){} // RVA: 0x5C8FB70
        public void TryEncrypt(){} // RVA: 0x5C8FD00
        public void TryHashData(){} // RVA: 0x5C8FE90
        public void TrySignHash(){} // RVA: 0x5C90180
        public void TrySignData(){} // RVA: 0x5C90320
        public void ExportRSAPrivateKey(){} // RVA: 0x5C90B40
        public void ExportRSAPublicKey(){} // RVA: 0x5C90B80
        public void ImportRSAPrivateKey(){} // RVA: 0x5C90BC0
        public void ImportRSAPublicKey(){} // RVA: 0x5C90C00
        public void TryExportRSAPrivateKey(){} // RVA: 0x5C90C40
        public void TryExportRSAPublicKey(){} // RVA: 0x5C90C80
    }

    public class RSACryptoServiceProvider
    {
        // ── Methods ──
        public void get_SignatureAlgorithm(){} // RVA: 0x5C90CC0
        public void get_UseMachineKeyStore(){} // RVA: 0x5C90D00
        public void set_UseMachineKeyStore(){} // RVA: 0x5C90D50
        public void HashData(){} // RVA: 0x5C90E00 | overloaded x2
        public void GetAlgorithmId(){} // RVA: 0x5C90E40
        public void Encrypt(){} // RVA: 0x5C92BD0 | overloaded x2
        public void Decrypt(){} // RVA: 0x5C92660 | overloaded x2
        public void SignHash(){} // RVA: 0x5C93B60 | overloaded x3
        public void VerifyHash(){} // RVA: 0x5C93FD0 | overloaded x3
        public void PaddingModeNotSupported(){} // RVA: 0x5C91AB0
        public void .ctor(){} // RVA: 0x5C91CE0 | overloaded x4
        public void Common(){} // RVA: 0x5C923D0 | overloaded x2
        public void Finalize(){} // RVA: 0x5AAC950
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x5C92540
        public void get_KeySize(){} // RVA: 0x5C92580
        public void get_PersistKeyInCsp(){} // RVA: 0x6E8A80
        public void set_PersistKeyInCsp(){} // RVA: 0x5C925B0
        public void get_PublicOnly(){} // RVA: 0x5C92640
        public void DecryptValue(){} // RVA: 0x5C92B40
        public void EncryptValue(){} // RVA: 0x5C92F20
        public void ExportParameters(){} // RVA: 0x5C92F50
        public void ImportParameters(){} // RVA: 0x5C930F0
        public void GetHash(){} // RVA: 0x5C93150
        public void GetHashFromString(){} // RVA: 0x5C93470
        public void SignData(){} // RVA: 0x5C936F0 | overloaded x3
        public void GetHashNameFromOID(){} // RVA: 0x5C937C0
        public void InternalHashToHashAlgorithm(){} // RVA: 0x5C93BE0
        public void VerifyData(){} // RVA: 0x5C93D10
        public void Dispose(){} // RVA: 0x5C94060
        public void OnKeyGenerated(){} // RVA: 0x5C940B0
        public void get_CspKeyContainerInfo(){} // RVA: 0x5C94140
        public void ExportCspBlob(){} // RVA: 0x5C94200
        public void ImportCspBlob(){} // RVA: 0x5C94280
    }

    public class RSAEncryptionPadding
    {
        // ── Methods ──
        public void get_Pkcs1(){} // RVA: 0x5C74C90
        public void get_OaepSHA1(){} // RVA: 0x5C74CF0
        public void get_OaepSHA256(){} // RVA: 0x5C74D50
        public void get_OaepSHA384(){} // RVA: 0x5C74DB0
        public void get_OaepSHA512(){} // RVA: 0x5C74E10
        public void .ctor(){} // RVA: 0x5C75570 | overloaded x2
        public void CreateOaep(){} // RVA: 0x5C74E70
        public void get_Mode(){} // RVA: 0x32A5C0
        public void get_OaepHashAlgorithm(){} // RVA: 0x2E07C0
        public void GetHashCode(){} // RVA: 0x5C74F80
        public void CombineHashCodes(){} // RVA: 0x3C22780
        public void Equals(){} // RVA: 0x5C75060 | overloaded x2
        public void op_Equality(){} // RVA: 0x5C75160
        public void op_Inequality(){} // RVA: 0x5C75180
        public void ToString(){} // RVA: 0x5C75200
        public void .cctor(){} // RVA: 0x5C75270
    }

    public class RSAOAEPKeyExchangeDeformatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C94610 | overloaded x2
        public void get_Parameters(){} // RVA: 0x519240
        public void set_Parameters(){} // RVA: 0x2DD310
        public void DecryptKeyExchange(){} // RVA: 0x5C94770
        public void SetKey(){} // RVA: 0x5C949B0
        public void get_OverridesDecrypt(){} // RVA: 0x5C94B10
    }

    public class RSAOAEPKeyExchangeFormatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C94D20 | overloaded x2
        public void get_Parameter(){} // RVA: 0x5C94E80
        public void set_Parameter(){} // RVA: 0x5C94F00
        public void get_Parameters(){} // RVA: 0x519240
        public void get_Rng(){} // RVA: 0x30B130
        public void set_Rng(){} // RVA: 0x2DEE90
        public void SetKey(){} // RVA: 0x5C95060
        public void CreateKeyExchange(){} // RVA: 0x400EA10 | overloaded x2
        public void get_OverridesEncrypt(){} // RVA: 0x5C953C0
    }

    public class RSAPKCS1KeyExchangeDeformatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C955D0 | overloaded x2
        public void get_RNG(){} // RVA: 0x30B0C0
        public void set_RNG(){} // RVA: 0x30B0D0
        public void get_Parameters(){} // RVA: 0x519240
        public void set_Parameters(){} // RVA: 0x2DD310
        public void DecryptKeyExchange(){} // RVA: 0x5C95730
        public void SetKey(){} // RVA: 0x5C95990
        public void get_OverridesDecrypt(){} // RVA: 0x5C95AF0
    }

    public class RSAPKCS1KeyExchangeFormatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C95D00 | overloaded x2
        public void get_Parameters(){} // RVA: 0x5C95E60
        public void get_Rng(){} // RVA: 0x2F8380
        public void set_Rng(){} // RVA: 0x2DEE30
        public void SetKey(){} // RVA: 0x5C95EA0
        public void CreateKeyExchange(){} // RVA: 0x400EA10 | overloaded x2
        public void get_OverridesEncrypt(){} // RVA: 0x5C96370
    }

    public class RSAPKCS1SHA1SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C9D1F0
    }

    public class RSAPKCS1SHA256SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C9D250
    }

    public class RSAPKCS1SHA384SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C9D2B0
    }

    public class RSAPKCS1SHA512SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C9D310
    }

    public class RSAPKCS1SignatureDeformatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CAC460 | overloaded x2
        public void SetHashAlgorithm(){} // RVA: 0x5CAC480
        public void SetKey(){} // RVA: 0x5CAC530
        public void VerifySignature(){} // RVA: 0x5CAC690
    }

    public class RSAPKCS1SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C9CD60
        public void CreateDeformatter(){} // RVA: 0x5C9CF90
        public void CreateFormatter(){} // RVA: 0x5C9D0C0
    }

    public class RSAPKCS1SignatureFormatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CAC460 | overloaded x2
        public void CreateSignature(){} // RVA: 0x5CAC880
        public void SetHashAlgorithm(){} // RVA: 0x5CACA10
        public void SetKey(){} // RVA: 0x5CACAC0
    }

    public class RSAParameters
    {
    }

    public class RSASignaturePadding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C759B0 | overloaded x2
        public void get_Pkcs1(){} // RVA: 0x5C755A0
        public void get_Pss(){} // RVA: 0x5C75600
        public void get_Mode(){} // RVA: 0x32A5C0
        public void GetHashCode(){} // RVA: 0x32A5C0
        public void Equals(){} // RVA: 0x5C756C0 | overloaded x2
        public void op_Equality(){} // RVA: 0x5C75780
        public void op_Inequality(){} // RVA: 0x5C757A0
        public void ToString(){} // RVA: 0x5C75820
        public void .cctor(){} // RVA: 0x5C75880
    }

    public class RandomNumberGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x5C83670 | overloaded x2
        public void Dispose(){} // RVA: 0x2DD310 | overloaded x2
        public void GetBytes(){} // RVA: 0x5C83B10 | overloaded x3
        public void GetNonZeroBytes(){} // RVA: 0x5C83D60 | overloaded x2
        public void Fill(){} // RVA: 0x5C83A40
        public void FillSpan(){} // RVA: 0x5C83AB0
        public void GetInt32(){} // RVA: 0x5C84110 | overloaded x2
    }

    public class Rfc2898DeriveBytes
    {
        // ── Methods ──
        public void get_HashAlgorithm(){} // RVA: 0x37E0E0
        public void .ctor(){} // RVA: 0x5C6C4B0 | overloaded x8
        public void get_IterationCount(){} // RVA: 0x760030
        public void set_IterationCount(){} // RVA: 0x5C6C6C0
        public void get_Salt(){} // RVA: 0x5C6C750
        public void set_Salt(){} // RVA: 0x5C6C7D0
        public void Dispose(){} // RVA: 0x5C6C950
        public void GetBytes(){} // RVA: 0x5C6CA20
        public void CryptDeriveKey(){} // RVA: 0x5C6CBD0
        public void Reset(){} // RVA: 0x5C6CC10
        public void OpenHmac(){} // RVA: 0x5C6CC20
        public void Initialize(){} // RVA: 0x5C6CF00
        public void Func(){} // RVA: 0x5C6CFC0
    }

    public class Rijndael
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C85020
        public void Create(){} // RVA: 0x5C851A0 | overloaded x2
        public void .cctor(){} // RVA: 0x5C85280
    }

    public class RijndaelManaged
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C85500
        public void CreateEncryptor(){} // RVA: 0x5C856A0
        public void CreateDecryptor(){} // RVA: 0x5C857D0
        public void GenerateKey(){} // RVA: 0x5C85900
        public void GenerateIV(){} // RVA: 0x5C859B0
        public void NewEncryptor(){} // RVA: 0x5C85A60
    }

    public class RijndaelManagedTransform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C89F10 | overloaded x2
        public void Dispose(){} // RVA: 0x5C86470 | overloaded x2
        public void Clear(){} // RVA: 0x5C86460
        public void get_BlockSizeValue(){} // RVA: 0x197C3B0
        public void get_InputBlockSize(){} // RVA: 0xCEF5B0
        public void get_OutputBlockSize(){} // RVA: 0x791DC0
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x3C2850
        public void get_CanReuseTransform(){} // RVA: 0x3C2850
        public void TransformBlock(){} // RVA: 0x5C86740
        public void TransformFinalBlock(){} // RVA: 0x5C86C10
        public void Reset(){} // RVA: 0x5C87050
        public void EncryptData(){} // RVA: 0x5C871D0
        public void DecryptData(){} // RVA: 0x5C87FB0
        public void Enc(){} // RVA: 0x5C88EF0
        public void Dec(){} // RVA: 0x5C89100
        public void GenerateKeyExpansion(){} // RVA: 0x5C89330
        public void rot1(){} // RVA: 0x5C899A0
        public void rot2(){} // RVA: 0x5C899B0
        public void rot3(){} // RVA: 0x5C899C0
        public void SubWord(){} // RVA: 0x5C899D0
        public void MulX(){} // RVA: 0x5C89AB0
        public void .cctor(){} // RVA: 0x5C89AE0
    }

}