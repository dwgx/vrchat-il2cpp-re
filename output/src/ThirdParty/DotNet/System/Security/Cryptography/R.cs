// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 26
// Methods: 232

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class RC2 : SymmetricAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA721D0
        public void get_EffectiveKeySize(){} // RVA: 0x7ADA72300
        public void set_EffectiveKeySize(){} // RVA: 0x7ADA72310
        public void get_KeySize(){} // RVA: 0x7A8D863F0
        public void set_KeySize(){} // RVA: 0x7ADA72460
        public void Create(){} // RVA: 0x7ADA72530
        public void .cctor(){} // RVA: 0x7ADA72610
    }

    public class RC2CryptoServiceProvider : RC2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA72890
        public void get_EffectiveKeySize(){} // RVA: 0x7A8D863F0
        public void set_EffectiveKeySize(){} // RVA: 0x7ADA72AE0
        public void get_UseSalt(){} // RVA: 0x7A8192400
        public void set_UseSalt(){} // RVA: 0x7A8192410
        public void CreateEncryptor(){} // RVA: 0x7ADA72B60
        public void CreateDecryptor(){} // RVA: 0x7ADA72C40
        public void GenerateKey(){} // RVA: 0x7ADA72D20
        public void GenerateIV(){} // RVA: 0x7ADA72E10
        public void .cctor(){} // RVA: 0x7ADA72EF0
    }

    public class RC2Transform : SymmetricTransform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA98710
        public void ECB(){} // RVA: 0x7ADA98DE0
        public void .cctor(){} // RVA: 0x7ADA99920
    }

    public class RIPEMD160 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA78190
        public void Create(){} // RVA: 0x7ADA781F0
    }

    public class RIPEMD160Managed : RIPEMD160
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA782D0
        public void Initialize(){} // RVA: 0x7ADA78480
        public void HashCore(){} // RVA: 0x7ADA784E0
        public void HashFinal(){} // RVA: 0x7ADA784F0
        public void InitializeState(){} // RVA: 0x7ADA78500
        public void _HashData(){} // RVA: 0x7ADA78590
        public void _EndHash(){} // RVA: 0x7ADA78880
        public void MDTransform(){} // RVA: 0x7ADA78B50
        public void F(){} // RVA: 0x7ADA7B080
        public void G(){} // RVA: 0x7ADA7B090
        public void H(){} // RVA: 0x7ADA7B0A0
        public void I(){} // RVA: 0x7ADA7B0B0
        public void J(){} // RVA: 0x7ADA7B0C0
    }

    public class RNGCryptoServiceProvider : RandomNumberGenerator
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ADA99A00
        public void .ctor(){} // RVA: 0x7ADA99BB0
        public void Check(){} // RVA: 0x7ADA99CA0
        public void RngOpen(){} // RVA: 0x7A80D7320
        public void RngInitialize(){} // RVA: 0x7ADA99D20
        public void RngGetBytes(){} // RVA: 0x7ADA99D30
        public void RngClose(){} // RVA: 0x7ADA99DC0
        public void GetBytes(){} // RVA: 0x7ADA9A040
        public void GetNonZeroBytes(){} // RVA: 0x7ADA9A240
        public void Finalize(){} // RVA: 0x7ADA9A430
        public void Dispose(){} // RVA: 0x7A80D7310
    }

    public class RSA : AsymmetricAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Create(){} // RVA: 0x7ADA7DC10
        public void Encrypt(){} // RVA: 0x7ADA7B210
        public void Decrypt(){} // RVA: 0x7ADA7B240
        public void SignHash(){} // RVA: 0x7ADA7B270
        public void VerifyHash(){} // RVA: 0x7ADA7EC50
        public void HashData(){} // RVA: 0x7ADA7B300
        public void SignData(){} // RVA: 0x7ADA7B6A0
        public void VerifyData(){} // RVA: 0x7ADA7E7A0
        public void DerivedClassMustOverride(){} // RVA: 0x7ADA7BEF0
        public void HashAlgorithmNameNullOrEmpty(){} // RVA: 0x7ADA7BF70
        public void DecryptValue(){} // RVA: 0x7ADA7C000
        public void EncryptValue(){} // RVA: 0x7ADA7C060
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7ADA7C0C0
        public void get_SignatureAlgorithm(){} // RVA: 0x7ADA7C100
        public void FromXmlString(){} // RVA: 0x7ADA7C140
        public void ToXmlString(){} // RVA: 0x7ADA7D140
        public void ExportParameters(){} // RVA: 0x7A7E00E20
        public void ImportParameters(){} // RVA: 0x7A7E18800
        public void TryDecrypt(){} // RVA: 0x7ADA7DD10
        public void TryEncrypt(){} // RVA: 0x7ADA7DEA0
        public void TryHashData(){} // RVA: 0x7ADA7E030
        public void TrySignHash(){} // RVA: 0x7ADA7E320
        public void TrySignData(){} // RVA: 0x7ADA7E4C0
        public void ExportRSAPrivateKey(){} // RVA: 0x7ADA7ECF0
        public void ExportRSAPublicKey(){} // RVA: 0x7ADA7ED30
        public void ImportRSAPrivateKey(){} // RVA: 0x7ADA7ED70
        public void ImportRSAPublicKey(){} // RVA: 0x7ADA7EDB0
        public void TryExportRSAPrivateKey(){} // RVA: 0x7ADA7EDF0
        public void TryExportRSAPublicKey(){} // RVA: 0x7ADA7EE30
    }

    public class RSACryptoServiceProvider : RSA
    {
        // ── Methods ──
        public void get_SignatureAlgorithm(){} // RVA: 0x7ADA7EE70
        public void get_UseMachineKeyStore(){} // RVA: 0x7ADA7EEB0
        public void set_UseMachineKeyStore(){} // RVA: 0x7ADA7EF00
        public void HashData(){} // RVA: 0x7ADA7EFB0
        public void GetAlgorithmId(){} // RVA: 0x7ADA7EFF0
        public void Encrypt(){} // RVA: 0x7ADA80D80
        public void Decrypt(){} // RVA: 0x7ADA80810
        public void SignHash(){} // RVA: 0x7ADA81D10
        public void VerifyHash(){} // RVA: 0x7ADA82180
        public void PaddingModeNotSupported(){} // RVA: 0x7ADA7FC60
        public void .ctor(){} // RVA: 0x7ADA7FE90
        public void Common(){} // RVA: 0x7ADA80580
        public void Finalize(){} // RVA: 0x7AD899E40
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7ADA806F0
        public void get_KeySize(){} // RVA: 0x7ADA80730
        public void get_PersistKeyInCsp(){} // RVA: 0x7A84A5BD0
        public void set_PersistKeyInCsp(){} // RVA: 0x7ADA80760
        public void get_PublicOnly(){} // RVA: 0x7ADA807F0
        public void DecryptValue(){} // RVA: 0x7ADA80CF0
        public void EncryptValue(){} // RVA: 0x7ADA810D0
        public void ExportParameters(){} // RVA: 0x7ADA81100
        public void ImportParameters(){} // RVA: 0x7ADA812A0
        public void GetHash(){} // RVA: 0x7ADA81300
        public void GetHashFromString(){} // RVA: 0x7ADA81620
        public void SignData(){} // RVA: 0x7ADA818A0
        public void GetHashNameFromOID(){} // RVA: 0x7ADA81970
        public void InternalHashToHashAlgorithm(){} // RVA: 0x7ADA81D90
        public void VerifyData(){} // RVA: 0x7ADA81EC0
        public void Dispose(){} // RVA: 0x7ADA82210
        public void OnKeyGenerated(){} // RVA: 0x7ADA82260
        public void get_CspKeyContainerInfo(){} // RVA: 0x7ADA822F0
        public void ExportCspBlob(){} // RVA: 0x7ADA823B0
        public void ImportCspBlob(){} // RVA: 0x7ADA82430
    }

    public class RSAEncryptionPadding : Object
    {
        // ── Methods ──
        public void get_Pkcs1(){} // RVA: 0x7ADA62C80
        public void get_OaepSHA1(){} // RVA: 0x7ADA62CE0
        public void get_OaepSHA256(){} // RVA: 0x7ADA62D40
        public void get_OaepSHA384(){} // RVA: 0x7ADA62DA0
        public void get_OaepSHA512(){} // RVA: 0x7ADA62E00
        public void .ctor(){} // RVA: 0x7ADA63560
        public void CreateOaep(){} // RVA: 0x7ADA62E60
        public void get_Mode(){} // RVA: 0x7A8124910
        public void get_OaepHashAlgorithm(){} // RVA: 0x7A80DA7B0
        public void GetHashCode(){} // RVA: 0x7ADA62F70
        public void CombineHashCodes(){} // RVA: 0x7ABA13C70
        public void Equals(){} // RVA: 0x7ADA63050
        public void op_Equality(){} // RVA: 0x7ADA63150
        public void op_Inequality(){} // RVA: 0x7ADA63170
        public void ToString(){} // RVA: 0x7ADA631F0
        public void .cctor(){} // RVA: 0x7ADA63260
    }

    public class RSAOAEPKeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA827C0
        public void get_Parameters(){} // RVA: 0x7A82D1450
        public void set_Parameters(){} // RVA: 0x7A80D7310
        public void DecryptKeyExchange(){} // RVA: 0x7ADA82920
        public void SetKey(){} // RVA: 0x7ADA82B60
        public void get_OverridesDecrypt(){} // RVA: 0x7ADA82CC0
    }

    public class RSAOAEPKeyExchangeFormatter : AsymmetricKeyExchangeFormatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA82ED0
        public void get_Parameter(){} // RVA: 0x7ADA83030
        public void set_Parameter(){} // RVA: 0x7ADA830B0
        public void get_Parameters(){} // RVA: 0x7A82D1450
        public void get_Rng(){} // RVA: 0x7A8105330
        public void set_Rng(){} // RVA: 0x7A80D8E80
        public void SetKey(){} // RVA: 0x7ADA83210
        public void CreateKeyExchange(){} // RVA: 0x7ABE04E20
        public void get_OverridesEncrypt(){} // RVA: 0x7ADA83570
    }

    public class RSAPKCS1KeyExchangeDeformatter : AsymmetricKeyExchangeDeformatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA83780
        public void get_RNG(){} // RVA: 0x7A81052C0
        public void set_RNG(){} // RVA: 0x7A81052D0
        public void get_Parameters(){} // RVA: 0x7A82D1450
        public void set_Parameters(){} // RVA: 0x7A80D7310
        public void DecryptKeyExchange(){} // RVA: 0x7ADA838E0
        public void SetKey(){} // RVA: 0x7ADA83B40
        public void get_OverridesDecrypt(){} // RVA: 0x7ADA83CA0
    }

    public class RSAPKCS1KeyExchangeFormatter : AsymmetricKeyExchangeFormatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA83EB0
        public void get_Parameters(){} // RVA: 0x7ADA84010
        public void get_Rng(){} // RVA: 0x7A80F2570
        public void set_Rng(){} // RVA: 0x7A80D8E20
        public void SetKey(){} // RVA: 0x7ADA84050
        public void CreateKeyExchange(){} // RVA: 0x7ABE04E20
        public void get_OverridesEncrypt(){} // RVA: 0x7ADA84520
    }

    public class RSAPKCS1SHA1SignatureDescription : RSAPKCS1SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA8B5D0
    }

    public class RSAPKCS1SHA256SignatureDescription : RSAPKCS1SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA8B630
    }

    public class RSAPKCS1SHA384SignatureDescription : RSAPKCS1SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA8B690
    }

    public class RSAPKCS1SHA512SignatureDescription : RSAPKCS1SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA8B6F0
    }

    public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA9A4D0
        public void SetHashAlgorithm(){} // RVA: 0x7ADA9A4F0
        public void SetKey(){} // RVA: 0x7ADA9A5A0
        public void VerifySignature(){} // RVA: 0x7ADA9A700
    }

    public class RSAPKCS1SignatureDescription : SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA8B140
        public void CreateDeformatter(){} // RVA: 0x7ADA8B370
        public void CreateFormatter(){} // RVA: 0x7ADA8B4A0
    }

    public class RSAPKCS1SignatureFormatter : AsymmetricSignatureFormatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA9A4D0
        public void CreateSignature(){} // RVA: 0x7ADA9A8F0
        public void SetHashAlgorithm(){} // RVA: 0x7ADA9AA80
        public void SetKey(){} // RVA: 0x7ADA9AB30
    }

    public class RSASignaturePadding : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA639A0
        public void get_Pkcs1(){} // RVA: 0x7ADA63590
        public void get_Pss(){} // RVA: 0x7ADA635F0
        public void get_Mode(){} // RVA: 0x7A8124910
        public void GetHashCode(){} // RVA: 0x7A8124910
        public void Equals(){} // RVA: 0x7ADA636B0
        public void op_Equality(){} // RVA: 0x7ADA63770
        public void op_Inequality(){} // RVA: 0x7ADA63790
        public void ToString(){} // RVA: 0x7ADA63810
        public void .cctor(){} // RVA: 0x7ADA63870
    }

    public class RandomNumberGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Create(){} // RVA: 0x7ADA716B0
        public void Dispose(){} // RVA: 0x7A80D7310
        public void GetBytes(){} // RVA: 0x7ADA71B50
        public void GetNonZeroBytes(){} // RVA: 0x7ADA71D90
        public void Fill(){} // RVA: 0x7ADA71A80
        public void FillSpan(){} // RVA: 0x7ADA71AF0
        public void GetInt32(){} // RVA: 0x7ADA72140
    }

    public class Rfc2898DeriveBytes : DeriveBytes
    {
        // ── Methods ──
        public void get_HashAlgorithm(){} // RVA: 0x7A8178B90
        public void .ctor(){} // RVA: 0x7ADA5A4D0
        public void get_IterationCount(){} // RVA: 0x7A851DB90
        public void set_IterationCount(){} // RVA: 0x7ADA5A6E0
        public void get_Salt(){} // RVA: 0x7ADA5A770
        public void set_Salt(){} // RVA: 0x7ADA5A7F0
        public void Dispose(){} // RVA: 0x7ADA5A970
        public void GetBytes(){} // RVA: 0x7ADA5AA40
        public void CryptDeriveKey(){} // RVA: 0x7ADA5ABF0
        public void Reset(){} // RVA: 0x7ADA5AC30
        public void OpenHmac(){} // RVA: 0x7ADA5AC40
        public void Initialize(){} // RVA: 0x7ADA5AF20
        public void Func(){} // RVA: 0x7ADA5AFE0
    }

    public class Rijndael : SymmetricAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA73050
        public void Create(){} // RVA: 0x7ADA731D0
        public void .cctor(){} // RVA: 0x7ADA732B0
    }

    public class RijndaelManaged : Rijndael
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA73530
        public void CreateEncryptor(){} // RVA: 0x7ADA736D0
        public void CreateDecryptor(){} // RVA: 0x7ADA73800
        public void GenerateKey(){} // RVA: 0x7ADA73930
        public void GenerateIV(){} // RVA: 0x7ADA739E0
        public void NewEncryptor(){} // RVA: 0x7ADA73A90
    }

    public class RijndaelManagedTransform : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA78160
        public void Dispose(){} // RVA: 0x7ADA744E0
        public void Clear(){} // RVA: 0x7ADA744D0
        public void get_BlockSizeValue(){} // RVA: 0x7A9739200
        public void get_InputBlockSize(){} // RVA: 0x7A8AB15F0
        public void get_OutputBlockSize(){} // RVA: 0x7A854FDE0
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7A81BD750
        public void get_CanReuseTransform(){} // RVA: 0x7A81BD750
        public void TransformBlock(){} // RVA: 0x7ADA747B0
        public void TransformFinalBlock(){} // RVA: 0x7ADA74C80
        public void Reset(){} // RVA: 0x7ADA750B0
        public void EncryptData(){} // RVA: 0x7ADA75230
        public void DecryptData(){} // RVA: 0x7ADA760B0
        public void Enc(){} // RVA: 0x7ADA770E0
        public void Dec(){} // RVA: 0x7ADA772F0
        public void GenerateKeyExpansion(){} // RVA: 0x7ADA77520
        public void rot1(){} // RVA: 0x7ADA77BE0
        public void rot2(){} // RVA: 0x7ADA77BF0
        public void rot3(){} // RVA: 0x7ADA77C00
        public void SubWord(){} // RVA: 0x7ADA77C10
        public void MulX(){} // RVA: 0x7ADA77D00
        public void .cctor(){} // RVA: 0x7ADA77D30
    }

}