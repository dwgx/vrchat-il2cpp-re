// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 27
// Methods: 289

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class RC2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87341A0
        public void get_EffectiveKeySize(){} // RVA: 0x7FFAF87342D0
        public void set_EffectiveKeySize(){} // RVA: 0x7FFAF87342E0
        public void get_KeySize(){} // RVA: 0x7FFAF3A8C9F0
        public void set_KeySize(){} // RVA: 0x7FFAF8734430
        public void Create(){} // RVA: 0x7FFAF8734500 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF87345E0
    }

    public class RC2CryptoServiceProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8734860
        public void get_EffectiveKeySize(){} // RVA: 0x7FFAF3A8C9F0
        public void set_EffectiveKeySize(){} // RVA: 0x7FFAF8734AB0
        public void get_UseSalt(){} // RVA: 0x7FFAF2E478E0
        public void set_UseSalt(){} // RVA: 0x7FFAF2E478F0
        public void CreateEncryptor(){} // RVA: 0x7FFAF8734B30
        public void CreateDecryptor(){} // RVA: 0x7FFAF8734C10
        public void GenerateKey(){} // RVA: 0x7FFAF8734CF0
        public void GenerateIV(){} // RVA: 0x7FFAF8734DE0
        public void .cctor(){} // RVA: 0x7FFAF8734EC0
    }

    public class RC2Transform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF875A700
        public void ECB(){} // RVA: 0x7FFAF875AD20
        public void .cctor(){} // RVA: 0x7FFAF875B840
    }

    public class RIPEMD160
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8739F40
        public void Create(){} // RVA: 0x7FFAF8739FA0 | overloaded x2
    }

    public class RIPEMD160Managed
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF873A080
        public void Initialize(){} // RVA: 0x7FFAF873A230
        public void HashCore(){} // RVA: 0x7FFAF873A290
        public void HashFinal(){} // RVA: 0x7FFAF873A2A0
        public void InitializeState(){} // RVA: 0x7FFAF873A2B0
        public void _HashData(){} // RVA: 0x7FFAF873A340
        public void _EndHash(){} // RVA: 0x7FFAF873A630
        public void MDTransform(){} // RVA: 0x7FFAF873A920
        public void F(){} // RVA: 0x7FFAF873CEF0
        public void G(){} // RVA: 0x7FFAF873CF00
        public void H(){} // RVA: 0x7FFAF873CF10
        public void I(){} // RVA: 0x7FFAF873CF20
        public void J(){} // RVA: 0x7FFAF873CF30
    }

    public class RNGCryptoServiceProvider
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF875B920
        public void .ctor(){} // RVA: 0x7FFAF875BAD0 | overloaded x4
        public void Check(){} // RVA: 0x7FFAF875BBC0
        public void RngOpen(){} // RVA: 0x7FFAF2D8D320
        public void RngInitialize(){} // RVA: 0x7FFAF875BC40
        public void RngGetBytes(){} // RVA: 0x7FFAF875BC50
        public void RngClose(){} // RVA: 0x7FFAF875BCE0
        public void GetBytes(){} // RVA: 0x7FFAF875BFA0 | overloaded x2
        public void GetNonZeroBytes(){} // RVA: 0x7FFAF875C1D0
        public void Finalize(){} // RVA: 0x7FFAF875C3C0
        public void Dispose(){} // RVA: 0x7FFAF2D8D310
    }

    public class RSA
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Create(){} // RVA: 0x7FFAF873FA80 | overloaded x4
        public void Encrypt(){} // RVA: 0x7FFAF873D080
        public void Decrypt(){} // RVA: 0x7FFAF873D0B0
        public void SignHash(){} // RVA: 0x7FFAF873D0E0
        public void VerifyHash(){} // RVA: 0x7FFAF8740AA0 | overloaded x2
        public void HashData(){} // RVA: 0x7FFAF873D170 | overloaded x2
        public void SignData(){} // RVA: 0x7FFAF873D510 | overloaded x3
        public void VerifyData(){} // RVA: 0x7FFAF8740600 | overloaded x4
        public void DerivedClassMustOverride(){} // RVA: 0x7FFAF873DD60
        public void HashAlgorithmNameNullOrEmpty(){} // RVA: 0x7FFAF873DDE0
        public void DecryptValue(){} // RVA: 0x7FFAF873DE70
        public void EncryptValue(){} // RVA: 0x7FFAF873DED0
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7FFAF873DF30
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAF873DF70
        public void FromXmlString(){} // RVA: 0x7FFAF873DFB0
        public void ToXmlString(){} // RVA: 0x7FFAF873EFB0
        public void ExportParameters(){}
        public void ImportParameters(){}
        public void TryDecrypt(){} // RVA: 0x7FFAF873FB70
        public void TryEncrypt(){} // RVA: 0x7FFAF873FD00
        public void TryHashData(){} // RVA: 0x7FFAF873FE90
        public void TrySignHash(){} // RVA: 0x7FFAF8740180
        public void TrySignData(){} // RVA: 0x7FFAF8740320
        public void ExportRSAPrivateKey(){} // RVA: 0x7FFAF8740B40
        public void ExportRSAPublicKey(){} // RVA: 0x7FFAF8740B80
        public void ImportRSAPrivateKey(){} // RVA: 0x7FFAF8740BC0
        public void ImportRSAPublicKey(){} // RVA: 0x7FFAF8740C00
        public void TryExportRSAPrivateKey(){} // RVA: 0x7FFAF8740C40
        public void TryExportRSAPublicKey(){} // RVA: 0x7FFAF8740C80
    }

    public class RSACryptoServiceProvider
    {
        // ── Methods ──
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAF8740CC0
        public void get_UseMachineKeyStore(){} // RVA: 0x7FFAF8740D00
        public void set_UseMachineKeyStore(){} // RVA: 0x7FFAF8740D50
        public void HashData(){} // RVA: 0x7FFAF8740E00 | overloaded x2
        public void GetAlgorithmId(){} // RVA: 0x7FFAF8740E40
        public void Encrypt(){} // RVA: 0x7FFAF8742BD0 | overloaded x2
        public void Decrypt(){} // RVA: 0x7FFAF8742660 | overloaded x2
        public void SignHash(){} // RVA: 0x7FFAF8743B60 | overloaded x3
        public void VerifyHash(){} // RVA: 0x7FFAF8743FD0 | overloaded x3
        public void PaddingModeNotSupported(){} // RVA: 0x7FFAF8741AB0
        public void .ctor(){} // RVA: 0x7FFAF8741CE0 | overloaded x4
        public void Common(){} // RVA: 0x7FFAF87423D0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF855C950
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7FFAF8742540
        public void get_KeySize(){} // RVA: 0x7FFAF8742580
        public void get_PersistKeyInCsp(){} // RVA: 0x7FFAF3198A80
        public void set_PersistKeyInCsp(){} // RVA: 0x7FFAF87425B0
        public void get_PublicOnly(){} // RVA: 0x7FFAF8742640
        public void DecryptValue(){} // RVA: 0x7FFAF8742B40
        public void EncryptValue(){} // RVA: 0x7FFAF8742F20
        public void ExportParameters(){} // RVA: 0x7FFAF8742F50
        public void ImportParameters(){} // RVA: 0x7FFAF87430F0
        public void GetHash(){} // RVA: 0x7FFAF8743150
        public void GetHashFromString(){} // RVA: 0x7FFAF8743470
        public void SignData(){} // RVA: 0x7FFAF87436F0 | overloaded x3
        public void GetHashNameFromOID(){} // RVA: 0x7FFAF87437C0
        public void InternalHashToHashAlgorithm(){} // RVA: 0x7FFAF8743BE0
        public void VerifyData(){} // RVA: 0x7FFAF8743D10
        public void Dispose(){} // RVA: 0x7FFAF8744060
        public void OnKeyGenerated(){} // RVA: 0x7FFAF87440B0
        public void get_CspKeyContainerInfo(){} // RVA: 0x7FFAF8744140
        public void ExportCspBlob(){} // RVA: 0x7FFAF8744200
        public void ImportCspBlob(){} // RVA: 0x7FFAF8744280
    }

    public class RSAEncryptionPadding
    {
        // ── Methods ──
        public void get_Pkcs1(){} // RVA: 0x7FFAF8724C90
        public void get_OaepSHA1(){} // RVA: 0x7FFAF8724CF0
        public void get_OaepSHA256(){} // RVA: 0x7FFAF8724D50
        public void get_OaepSHA384(){} // RVA: 0x7FFAF8724DB0
        public void get_OaepSHA512(){} // RVA: 0x7FFAF8724E10
        public void .ctor(){} // RVA: 0x7FFAF8725570 | overloaded x2
        public void CreateOaep(){} // RVA: 0x7FFAF8724E70
        public void get_Mode(){} // RVA: 0x7FFAF2DDA5C0
        public void get_OaepHashAlgorithm(){} // RVA: 0x7FFAF2D907C0
        public void GetHashCode(){} // RVA: 0x7FFAF8724F80
        public void CombineHashCodes(){} // RVA: 0x7FFAF66D2780
        public void Equals(){} // RVA: 0x7FFAF8725060 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAF8725160
        public void op_Inequality(){} // RVA: 0x7FFAF8725180
        public void ToString(){} // RVA: 0x7FFAF8725200
        public void .cctor(){} // RVA: 0x7FFAF8725270
    }

    public class RSAOAEPKeyExchangeDeformatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8744610 | overloaded x2
        public void get_Parameters(){} // RVA: 0x7FFAF2FC9240
        public void set_Parameters(){} // RVA: 0x7FFAF2D8D310
        public void DecryptKeyExchange(){} // RVA: 0x7FFAF8744770
        public void SetKey(){} // RVA: 0x7FFAF87449B0
        public void get_OverridesDecrypt(){} // RVA: 0x7FFAF8744B10
    }

    public class RSAOAEPKeyExchangeFormatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8744D20 | overloaded x2
        public void get_Parameter(){} // RVA: 0x7FFAF8744E80
        public void set_Parameter(){} // RVA: 0x7FFAF8744F00
        public void get_Parameters(){} // RVA: 0x7FFAF2FC9240
        public void get_Rng(){} // RVA: 0x7FFAF2DBB130
        public void set_Rng(){} // RVA: 0x7FFAF2D8EE90
        public void SetKey(){} // RVA: 0x7FFAF8745060
        public void CreateKeyExchange(){} // RVA: 0x7FFAF6ABEA10 | overloaded x2
        public void get_OverridesEncrypt(){} // RVA: 0x7FFAF87453C0
    }

    public class RSAPKCS1KeyExchangeDeformatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87455D0 | overloaded x2
        public void get_RNG(){} // RVA: 0x7FFAF2DBB0C0
        public void set_RNG(){} // RVA: 0x7FFAF2DBB0D0
        public void get_Parameters(){} // RVA: 0x7FFAF2FC9240
        public void set_Parameters(){} // RVA: 0x7FFAF2D8D310
        public void DecryptKeyExchange(){} // RVA: 0x7FFAF8745730
        public void SetKey(){} // RVA: 0x7FFAF8745990
        public void get_OverridesDecrypt(){} // RVA: 0x7FFAF8745AF0
    }

    public class RSAPKCS1KeyExchangeFormatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8745D00 | overloaded x2
        public void get_Parameters(){} // RVA: 0x7FFAF8745E60
        public void get_Rng(){} // RVA: 0x7FFAF2DA8380
        public void set_Rng(){} // RVA: 0x7FFAF2D8EE30
        public void SetKey(){} // RVA: 0x7FFAF8745EA0
        public void CreateKeyExchange(){} // RVA: 0x7FFAF6ABEA10 | overloaded x2
        public void get_OverridesEncrypt(){} // RVA: 0x7FFAF8746370
    }

    public class RSAPKCS1SHA1SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF874D1F0
    }

    public class RSAPKCS1SHA256SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF874D250
    }

    public class RSAPKCS1SHA384SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF874D2B0
    }

    public class RSAPKCS1SHA512SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF874D310
    }

    public class RSAPKCS1SignatureDeformatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF875C460 | overloaded x2
        public void SetHashAlgorithm(){} // RVA: 0x7FFAF875C480
        public void SetKey(){} // RVA: 0x7FFAF875C530
        public void VerifySignature(){} // RVA: 0x7FFAF875C690
    }

    public class RSAPKCS1SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF874CD60
        public void CreateDeformatter(){} // RVA: 0x7FFAF874CF90
        public void CreateFormatter(){} // RVA: 0x7FFAF874D0C0
    }

    public class RSAPKCS1SignatureFormatter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF875C460 | overloaded x2
        public void CreateSignature(){} // RVA: 0x7FFAF875C880
        public void SetHashAlgorithm(){} // RVA: 0x7FFAF875CA10
        public void SetKey(){} // RVA: 0x7FFAF875CAC0
    }

    public class RSAParameters
    {
    }

    public class RSASignaturePadding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87259B0 | overloaded x2
        public void get_Pkcs1(){} // RVA: 0x7FFAF87255A0
        public void get_Pss(){} // RVA: 0x7FFAF8725600
        public void get_Mode(){} // RVA: 0x7FFAF2DDA5C0
        public void GetHashCode(){} // RVA: 0x7FFAF2DDA5C0
        public void Equals(){} // RVA: 0x7FFAF87256C0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAF8725780
        public void op_Inequality(){} // RVA: 0x7FFAF87257A0
        public void ToString(){} // RVA: 0x7FFAF8725820
        public void .cctor(){} // RVA: 0x7FFAF8725880
    }

    public class RandomNumberGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Create(){} // RVA: 0x7FFAF8733670 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void GetBytes(){} // RVA: 0x7FFAF8733B10 | overloaded x3
        public void GetNonZeroBytes(){} // RVA: 0x7FFAF8733D60 | overloaded x2
        public void Fill(){} // RVA: 0x7FFAF8733A40
        public void FillSpan(){} // RVA: 0x7FFAF8733AB0
        public void GetInt32(){} // RVA: 0x7FFAF8734110 | overloaded x2
    }

    public class Rfc2898DeriveBytes
    {
        // ── Methods ──
        public void get_HashAlgorithm(){} // RVA: 0x7FFAF2E2E0E0
        public void .ctor(){} // RVA: 0x7FFAF871C4B0 | overloaded x8
        public void get_IterationCount(){} // RVA: 0x7FFAF3210030
        public void set_IterationCount(){} // RVA: 0x7FFAF871C6C0
        public void get_Salt(){} // RVA: 0x7FFAF871C750
        public void set_Salt(){} // RVA: 0x7FFAF871C7D0
        public void Dispose(){} // RVA: 0x7FFAF871C950
        public void GetBytes(){} // RVA: 0x7FFAF871CA20
        public void CryptDeriveKey(){} // RVA: 0x7FFAF871CBD0
        public void Reset(){} // RVA: 0x7FFAF871CC10
        public void OpenHmac(){} // RVA: 0x7FFAF871CC20
        public void Initialize(){} // RVA: 0x7FFAF871CF00
        public void Func(){} // RVA: 0x7FFAF871CFC0
    }

    public class Rijndael
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8735020
        public void Create(){} // RVA: 0x7FFAF87351A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF8735280
    }

    public class RijndaelManaged
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8735500
        public void CreateEncryptor(){} // RVA: 0x7FFAF87356A0
        public void CreateDecryptor(){} // RVA: 0x7FFAF87357D0
        public void GenerateKey(){} // RVA: 0x7FFAF8735900
        public void GenerateIV(){} // RVA: 0x7FFAF87359B0
        public void NewEncryptor(){} // RVA: 0x7FFAF8735A60
    }

    public class RijndaelManagedTransform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8739F10 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAF8736470 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAF8736460
        public void get_BlockSizeValue(){} // RVA: 0x7FFAF442C3B0
        public void get_InputBlockSize(){} // RVA: 0x7FFAF379F5B0
        public void get_OutputBlockSize(){} // RVA: 0x7FFAF3241DC0
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7FFAF2E72850
        public void get_CanReuseTransform(){} // RVA: 0x7FFAF2E72850
        public void TransformBlock(){} // RVA: 0x7FFAF8736740
        public void TransformFinalBlock(){} // RVA: 0x7FFAF8736C10
        public void Reset(){} // RVA: 0x7FFAF8737050
        public void EncryptData(){} // RVA: 0x7FFAF87371D0
        public void DecryptData(){} // RVA: 0x7FFAF8737FB0
        public void Enc(){} // RVA: 0x7FFAF8738EF0
        public void Dec(){} // RVA: 0x7FFAF8739100
        public void GenerateKeyExpansion(){} // RVA: 0x7FFAF8739330
        public void rot1(){} // RVA: 0x7FFAF87399A0
        public void rot2(){} // RVA: 0x7FFAF87399B0
        public void rot3(){} // RVA: 0x7FFAF87399C0
        public void SubWord(){} // RVA: 0x7FFAF87399D0
        public void MulX(){} // RVA: 0x7FFAF8739AB0
        public void .cctor(){} // RVA: 0x7FFAF8739AE0
    }

}