// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Cryptography
// Classes: 21
// Methods: 230

namespace ThirdParty.DotNet.Mono.Security.Cryptography
{
    public class ARC4Managed : RC4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9C7C90
        public void Finalize(){} // RVA: 0x7AD9C7E80
        public void Dispose(){} // RVA: 0x7AD9C7ED0
        public void get_Key(){} // RVA: 0x7AD9C8030
        public void set_Key(){} // RVA: 0x7AD9C80D0
        public void get_CanReuseTransform(){} // RVA: 0x7A80D7320
        public void CreateEncryptor(){} // RVA: 0x7AD9C8360
        public void CreateDecryptor(){} // RVA: 0x7AD9C8390
        public void GenerateIV(){} // RVA: 0x7AD9C83D0
        public void GenerateKey(){} // RVA: 0x7AD9C8430
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7A81BD750
        public void get_InputBlockSize(){} // RVA: 0x7A81CA9D0
        public void get_OutputBlockSize(){} // RVA: 0x7A81CA9D0
        public void KeySetup(){} // RVA: 0x7AD9C85C0
        public void CheckInput(){} // RVA: 0x7AD9C86C0
        public void TransformBlock(){} // RVA: 0x7AD9C8860
        public void InternalTransformBlock(){} // RVA: 0x7AD9C89F0
        public void TransformFinalBlock(){} // RVA: 0x7AD9C8B80
    }

    public class CryptoConvert : Object
    {
        // ── Methods ──
        public void ToInt32LE(){} // RVA: 0x7AD9C8C40
        public void ToUInt32LE(){} // RVA: 0x7AD9C8C40
        public void Trim(){} // RVA: 0x7AD9C8CC0
        public void FromCapiPrivateKeyBlob(){} // RVA: 0x7AD9C8D90
        public void GetParametersFromCapiPrivateKeyBlob(){} // RVA: 0x7AD9C8FE0
        public void ToHex(){} // RVA: 0x7AD9C9C30
        public void FromHexChar(){} // RVA: 0x7AD9C9E90
        public void FromHex(){} // RVA: 0x7AD9C9F20
    }

    public class CryptoConvert : Object
    {
        // ── Methods ──
        public void ToInt32LE(){} // RVA: 0x7AD9C8C40
        public void ToUInt32LE(){} // RVA: 0x7AD9C8C40
        public void GetBytesLE(){} // RVA: 0x7AD9F47C0
        public void Trim(){} // RVA: 0x7AD9F4850
        public void FromCapiPrivateKeyBlob(){} // RVA: 0x7AD9F4910
        public void GetParametersFromCapiPrivateKeyBlob(){} // RVA: 0x7AD9F4A00
        public void FromCapiPrivateKeyBlobDSA(){} // RVA: 0x7AD9F5650
        public void ToCapiPrivateKeyBlob(){} // RVA: 0x7AD9F63D0
        public void FromCapiPublicKeyBlob(){} // RVA: 0x7AD9F68C0
        public void GetParametersFromCapiPublicKeyBlob(){} // RVA: 0x7AD9F6A30
        public void FromCapiPublicKeyBlobDSA(){} // RVA: 0x7AD9F7000
        public void ToCapiPublicKeyBlob(){} // RVA: 0x7AD9F7BB0
        public void FromCapiKeyBlob(){} // RVA: 0x7AD9F80A0
        public void FromCapiKeyBlobDSA(){} // RVA: 0x7AD9F8400
    }

    public class DSAManaged : DSA
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA03640
        public void Finalize(){} // RVA: 0x7AD899E40
        public void Generate(){} // RVA: 0x7ADA03780
        public void GenerateKeyPair(){} // RVA: 0x7ADA037D0
        public void add(){} // RVA: 0x7ADA03AC0
        public void GenerateParams(){} // RVA: 0x7ADA03B60
        public void get_Random(){} // RVA: 0x7ADA046F0
        public void get_KeySize(){} // RVA: 0x7ADA04770
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7A82D1450
        public void get_PublicOnly(){} // RVA: 0x7ADA047A0
        public void get_SignatureAlgorithm(){} // RVA: 0x7ADA04810
        public void NormalizeArray(){} // RVA: 0x7ADA04850
        public void ExportParameters(){} // RVA: 0x7ADA04910
        public void ImportParameters(){} // RVA: 0x7ADA04E50
        public void CreateSignature(){} // RVA: 0x7ADA05280
        public void VerifySignature(){} // RVA: 0x7ADA056B0
        public void Dispose(){} // RVA: 0x7ADA05C90
        public void add_KeyGenerated(){} // RVA: 0x7ADA05F40
        public void remove_KeyGenerated(){} // RVA: 0x7ADA06030
    }

    public class KeyBuilder : Object
    {
        // ── Methods ──
        public void get_Rng(){} // RVA: 0x7AD9CA180
        public void Key(){} // RVA: 0x7AD9CA240
    }

    public class KeyBuilder : Object
    {
        // ── Methods ──
        public void get_Rng(){} // RVA: 0x7AD9F8530
        public void Key(){} // RVA: 0x7AD9F85F0
        public void IV(){} // RVA: 0x7AD9F8660
    }

    public class KeyPairPersistence : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9F87F0
        public void get_Filename(){} // RVA: 0x7AD9F8910
        public void get_KeyValue(){} // RVA: 0x7A80DA7B0
        public void set_KeyValue(){} // RVA: 0x7AD9F8C10
        public void get_Parameters(){} // RVA: 0x7AD9F8C70
        public void Load(){} // RVA: 0x7AD9F8C80
        public void Save(){} // RVA: 0x7AD9F8E60
        public void Remove(){} // RVA: 0x7AD9F9070
        public void get_UserPath(){} // RVA: 0x7AD9F9160
        public void get_MachinePath(){} // RVA: 0x7AD9F97D0
        public void _CanSecure(){} // RVA: 0x7A80D7320
        public void _ProtectUser(){} // RVA: 0x7A80D7320
        public void _ProtectMachine(){} // RVA: 0x7A80D7320
        public void _IsUserProtected(){} // RVA: 0x7A80D7320
        public void _IsMachineProtected(){} // RVA: 0x7A80D7320
        public void CanSecure(){} // RVA: 0x7AD9F9E40
        public void ProtectUser(){} // RVA: 0x7AD9F9EB0
        public void ProtectMachine(){} // RVA: 0x7AD9F9F30
        public void IsUserProtected(){} // RVA: 0x7AD9F9FB0
        public void IsMachineProtected(){} // RVA: 0x7AD9FA030
        public void get_CanChange(){} // RVA: 0x7AACC9BD0
        public void get_UseDefaultKeyContainer(){} // RVA: 0x7AD9FA0B0
        public void get_UseMachineKeyStore(){} // RVA: 0x7AD9FA0D0
        public void get_ContainerName(){} // RVA: 0x7AD9FA0F0
        public void Copy(){} // RVA: 0x7AD9FA430
        public void FromXml(){} // RVA: 0x7AD9FA4F0
        public void ToXml(){} // RVA: 0x7AD9FA930
        public void .cctor(){} // RVA: 0x7AD9FABC0
    }

    public class MD2 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9CA360
        public void Create(){} // RVA: 0x7AD9CA370
    }

    public class MD2 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9CA360
        public void Create(){} // RVA: 0x7AD9FACE0
    }

    public class MD2Managed : MD2
    {
        // ── Methods ──
        public void Padding(){} // RVA: 0x7AD9CA3C0
        public void .ctor(){} // RVA: 0x7AD9CA450
        public void Initialize(){} // RVA: 0x7AD9CA630
        public void HashCore(){} // RVA: 0x7AD9CA6A0
        public void HashFinal(){} // RVA: 0x7AD9CA7A0
        public void MD2Transform(){} // RVA: 0x7AD9CA900
        public void .cctor(){} // RVA: 0x7AD9CAF80
    }

    public class MD2Managed : MD2
    {
        // ── Methods ──
        public void Padding(){} // RVA: 0x7AD9FAD30
        public void .ctor(){} // RVA: 0x7AD9FADC0
        public void Initialize(){} // RVA: 0x7AD9CA630
        public void HashCore(){} // RVA: 0x7AD9FAFA0
        public void HashFinal(){} // RVA: 0x7AD9FB0A0
        public void MD2Transform(){} // RVA: 0x7AD9FB200
        public void .cctor(){} // RVA: 0x7AD9FB880
    }

    public class MD4 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9CA360
        public void Create(){} // RVA: 0x7AD9CB060
    }

    public class MD4 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9CA360
        public void Create(){} // RVA: 0x7AD9FB960
    }

    public class MD4Managed : MD4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9CB0B0
        public void Initialize(){} // RVA: 0x7AD9CB300
        public void HashCore(){} // RVA: 0x7AD9CB3D0
        public void HashFinal(){} // RVA: 0x7AD9CB550
        public void Padding(){} // RVA: 0x7AD9CB820
        public void F(){} // RVA: 0x7AD9CB890
        public void G(){} // RVA: 0x7AD9CB8A0
        public void H(){} // RVA: 0x7AD9CB8B0
        public void ROL(){} // RVA: 0x7AD9CB8C0
        public void FF(){} // RVA: 0x7AD9CB8E0
        public void GG(){} // RVA: 0x7AD9CB920
        public void HH(){} // RVA: 0x7AD9CB970
        public void Encode(){} // RVA: 0x7AD9CB9B0
        public void Decode(){} // RVA: 0x7AD9CBA60
        public void MD4Transform(){} // RVA: 0x7AD9CBB10
    }

    public class MD4Managed : MD4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9FB9B0
        public void Initialize(){} // RVA: 0x7AD9CB300
        public void HashCore(){} // RVA: 0x7AD9CB3D0
        public void HashFinal(){} // RVA: 0x7AD9FBC00
        public void Padding(){} // RVA: 0x7AD9FBED0
        public void F(){} // RVA: 0x7AD9CB890
        public void G(){} // RVA: 0x7AD9CB8A0
        public void H(){} // RVA: 0x7AD9CB8B0
        public void ROL(){} // RVA: 0x7AD9CB8C0
        public void FF(){} // RVA: 0x7AD9CB8E0
        public void GG(){} // RVA: 0x7AD9CB920
        public void HH(){} // RVA: 0x7AD9CB970
        public void Encode(){} // RVA: 0x7AD9CB9B0
        public void Decode(){} // RVA: 0x7AD9CBA60
        public void MD4Transform(){} // RVA: 0x7AD9CBB10
    }

    public class PKCS1 : Object
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7AD9CC5C0
        public void I2OSP(){} // RVA: 0x7AD9CC650
        public void OS2IP(){} // RVA: 0x7AD9CC6E0
        public void RSAVP1(){} // RVA: 0x7AD9CC7C0
        public void Verify_v15(){} // RVA: 0x7AD9CC7F0
        public void Encode_v15(){} // RVA: 0x7AD9CCB70
        public void HashNameFromOid(){} // RVA: 0x7AD9CCFF0
        public void CreateFromOid(){} // RVA: 0x7AD9CD540
        public void CreateFromName(){} // RVA: 0x7AD9CD5A0
        public void .cctor(){} // RVA: 0x7AD9CDAE0
    }

    public class PKCS1 : Object
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7AD9CC5C0
        public void xor(){} // RVA: 0x7AD9FBF40
        public void GetEmptyHash(){} // RVA: 0x7AD9FBFF0
        public void I2OSP(){} // RVA: 0x7AD9FC360
        public void OS2IP(){} // RVA: 0x7AD9FC3F0
        public void RSAEP(){} // RVA: 0x7AD9CC7C0
        public void RSADP(){} // RVA: 0x7AD9FC4D0
        public void RSASP1(){} // RVA: 0x7AD9FC4D0
        public void RSAVP1(){} // RVA: 0x7AD9CC7C0
        public void Encrypt_OAEP(){} // RVA: 0x7AD9FC500
        public void Decrypt_OAEP(){} // RVA: 0x7AD9FCA10
        public void Sign_v15(){} // RVA: 0x7AD9FD080
        public void Verify_v15(){} // RVA: 0x7AD9FD360
        public void Encode_v15(){} // RVA: 0x7AD9FD6E0
        public void MGF1(){} // RVA: 0x7AD9FDB60
        public void CreateFromName(){} // RVA: 0x7AD9FE170
        public void .cctor(){} // RVA: 0x7AD9FE6F0
    }

    public class RC4 : SymmetricAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9D0470
        public void get_IV(){} // RVA: 0x7AD9D05A0
        public void set_IV(){} // RVA: 0x7A80D7310
        public void Create(){} // RVA: 0x7AD9D05E0
        public void .cctor(){} // RVA: 0x7AD9D0800
    }

    public class RSAManaged : RSA
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9D0BE0
        public void Finalize(){} // RVA: 0x7AD899E40
        public void GenerateKeyPair(){} // RVA: 0x7AD9D0D50
        public void get_KeySize(){} // RVA: 0x7AD9D1530
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7AD9D15E0
        public void get_PublicOnly(){} // RVA: 0x7AD9D1620
        public void get_SignatureAlgorithm(){} // RVA: 0x7AD9D16C0
        public void DecryptValue(){} // RVA: 0x7AD9D1700
        public void EncryptValue(){} // RVA: 0x7AD9D1B80
        public void ExportParameters(){} // RVA: 0x7AD9D1D20
        public void ImportParameters(){} // RVA: 0x7AD9D21F0
        public void Dispose(){} // RVA: 0x7AD9D29B0
        public void ToXmlString(){} // RVA: 0x7AD9D2E20
        public void GetPaddedValue(){} // RVA: 0x7AD9D36A0
    }

    public class RSAManaged : RSA
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9FE9D0
        public void Finalize(){} // RVA: 0x7AD899E40
        public void GenerateKeyPair(){} // RVA: 0x7AD9FEB40
        public void get_KeySize(){} // RVA: 0x7AD9FF320
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7AD9FF3D0
        public void get_PublicOnly(){} // RVA: 0x7AD9FF410
        public void get_SignatureAlgorithm(){} // RVA: 0x7AD9FF4B0
        public void DecryptValue(){} // RVA: 0x7AD9FF4F0
        public void EncryptValue(){} // RVA: 0x7AD9FF970
        public void ExportParameters(){} // RVA: 0x7AD9FFB10
        public void ImportParameters(){} // RVA: 0x7AD9FFFE0
        public void Dispose(){} // RVA: 0x7ADA007A0
        public void add_KeyGenerated(){} // RVA: 0x7ADA00C10
        public void remove_KeyGenerated(){} // RVA: 0x7ADA00D00
        public void ToXmlString(){} // RVA: 0x7ADA00DF0
        public void get_IsCrtPossible(){} // RVA: 0x7ADA01670
        public void GetPaddedValue(){} // RVA: 0x7ADA01680
    }

    public class SymmetricTransform : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA01730
        public void Finalize(){} // RVA: 0x7ADA01B90
        public void System.IDisposable.Dispose(){} // RVA: 0x7ADA01BE0
        public void Dispose(){} // RVA: 0x7ADA01C50
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7A81BD750
        public void get_CanReuseTransform(){} // RVA: 0x7A80D7320
        public void get_InputBlockSize(){} // RVA: 0x7A9739200
        public void get_OutputBlockSize(){} // RVA: 0x7A9739200
        public void Transform(){} // RVA: 0x7ADA01D50
        public void ECB(){} // RVA: 0x7A7E18890
        public void CBC(){} // RVA: 0x7ADA01ED0
        public void CFB(){} // RVA: 0x7ADA02020
        public void OFB(){} // RVA: 0x7ADA024B0
        public void CTS(){} // RVA: 0x7ADA02500
        public void CheckInput(){} // RVA: 0x7ADA02550
        public void TransformBlock(){} // RVA: 0x7ADA026F0
        public void get_KeepLastBlock(){} // RVA: 0x7ADA02A10
        public void InternalTransformBlock(){} // RVA: 0x7ADA02A30
        public void Random(){} // RVA: 0x7ADA02C20
        public void ThrowBadPaddingException(){} // RVA: 0x7ADA02D40
        public void FinalEncrypt(){} // RVA: 0x7ADA02EA0
        public void FinalDecrypt(){} // RVA: 0x7ADA03230
        public void TransformFinalBlock(){} // RVA: 0x7ADA03570
    }

}