// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Cryptography
// Classes: 14
// Methods: 156

namespace ThirdParty.DotNet.Mono.Security.Cryptography
{
    public class ARC4Managed
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BDA110
        public void Finalize(){} // RVA: 0x5BDA300
        public void Dispose(){} // RVA: 0x5BDA350
        public void get_Key(){} // RVA: 0x5BDA4B0
        public void set_Key(){} // RVA: 0x5BDA550
        public void get_CanReuseTransform(){} // RVA: 0x2DD320
        public void CreateEncryptor(){} // RVA: 0x5BDA7D0
        public void CreateDecryptor(){} // RVA: 0x5BDA800
        public void GenerateIV(){} // RVA: 0x5BDA840
        public void GenerateKey(){} // RVA: 0x5BDA8A0
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x3C2850
        public void get_InputBlockSize(){} // RVA: 0x3CFAF0
        public void get_OutputBlockSize(){} // RVA: 0x3CFAF0
        public void KeySetup(){} // RVA: 0x5BDAA30
        public void CheckInput(){} // RVA: 0x5BDAB40
        public void TransformBlock(){} // RVA: 0x5BDACE0
        public void InternalTransformBlock(){} // RVA: 0x5BDAE70
        public void TransformFinalBlock(){} // RVA: 0x5BDAFE0
    }

    public class CryptoConvert
    {
        // ── Methods ──
        public void ToInt32LE(){} // RVA: 0x5BDB0A0
        public void ToUInt32LE(){} // RVA: 0x5BDB0A0
        public void Trim(){} // RVA: 0x5BDB120
        public void FromCapiPrivateKeyBlob(){} // RVA: 0x5BDB200 | overloaded x2
        public void GetParametersFromCapiPrivateKeyBlob(){} // RVA: 0x5BDB430
        public void ToHex(){} // RVA: 0x5BDC0A0
        public void FromHexChar(){} // RVA: 0x5BDC2E0
        public void FromHex(){} // RVA: 0x5BDC370
    }

    public class DSAManaged
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C15830
        public void Finalize(){} // RVA: 0x5AAC950
        public void Generate(){} // RVA: 0x5C15970
        public void GenerateKeyPair(){} // RVA: 0x5C159C0
        public void add(){} // RVA: 0x5C15CB0
        public void GenerateParams(){} // RVA: 0x5C15D30
        public void get_Random(){} // RVA: 0x5C168E0
        public void get_KeySize(){} // RVA: 0x5C16960
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x519240
        public void get_PublicOnly(){} // RVA: 0x5C16990
        public void get_SignatureAlgorithm(){} // RVA: 0x5C16A00
        public void NormalizeArray(){} // RVA: 0x5C16A40
        public void ExportParameters(){} // RVA: 0x5C16B00
        public void ImportParameters(){} // RVA: 0x5C17040
        public void CreateSignature(){} // RVA: 0x5C17470
        public void VerifySignature(){} // RVA: 0x5C178B0
        public void Dispose(){} // RVA: 0x5C17E90
        public void add_KeyGenerated(){} // RVA: 0x5C18180
        public void remove_KeyGenerated(){} // RVA: 0x5C18270
    }

    public class KeyBuilder
    {
        // ── Methods ──
        public void get_Rng(){} // RVA: 0x5BDC5D0
        public void Key(){} // RVA: 0x5BDC690
    }

    public class KeyPairPersistence
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C0A980 | overloaded x2
        public void get_Filename(){} // RVA: 0x5C0AAA0
        public void get_KeyValue(){} // RVA: 0x2E07C0
        public void set_KeyValue(){} // RVA: 0x5C0ADA0
        public void get_Parameters(){} // RVA: 0x5C0AE00
        public void Load(){} // RVA: 0x5C0AE10
        public void Save(){} // RVA: 0x5C0AFE0
        public void Remove(){} // RVA: 0x5C0B1F0
        public void get_UserPath(){} // RVA: 0x5C0B2E0
        public void get_MachinePath(){} // RVA: 0x5C0B970
        public void _CanSecure(){} // RVA: 0x2DD320
        public void _ProtectUser(){} // RVA: 0x2DD320
        public void _ProtectMachine(){} // RVA: 0x2DD320
        public void _IsUserProtected(){} // RVA: 0x2DD320
        public void _IsMachineProtected(){} // RVA: 0x2DD320
        public void CanSecure(){} // RVA: 0x5C0C000
        public void ProtectUser(){} // RVA: 0x5C0C070
        public void ProtectMachine(){} // RVA: 0x5C0C0F0
        public void IsUserProtected(){} // RVA: 0x5C0C170
        public void IsMachineProtected(){} // RVA: 0x5C0C1F0
        public void get_CanChange(){} // RVA: 0x2ED2970
        public void get_UseDefaultKeyContainer(){} // RVA: 0x5C0C270
        public void get_UseMachineKeyStore(){} // RVA: 0x5C0C290
        public void get_ContainerName(){} // RVA: 0x5C0C2B0
        public void Copy(){} // RVA: 0x5C0C5F0
        public void FromXml(){} // RVA: 0x5C0C6B0
        public void ToXml(){} // RVA: 0x5C0CAF0
        public void .cctor(){} // RVA: 0x5C0CD80
    }

    public class MD2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BDC7B0
        public void Create(){} // RVA: 0x5BDC7C0
    }

    public class MD2Managed
    {
        // ── Methods ──
        public void Padding(){} // RVA: 0x5BDC810
        public void .ctor(){} // RVA: 0x5BDC890
        public void Initialize(){} // RVA: 0x5BDCA70
        public void HashCore(){} // RVA: 0x5BDCAE0
        public void HashFinal(){} // RVA: 0x5BDCBE0
        public void MD2Transform(){} // RVA: 0x5BDCD40
        public void .cctor(){} // RVA: 0x5BDD380
    }

    public class MD4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BDC7B0
        public void Create(){} // RVA: 0x5BDD460
    }

    public class MD4Managed
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BDD4B0
        public void Initialize(){} // RVA: 0x5BDD700
        public void HashCore(){} // RVA: 0x5BDD7D0
        public void HashFinal(){} // RVA: 0x5BDD960
        public void Padding(){} // RVA: 0x5BDDC60
        public void F(){} // RVA: 0x5BDDCD0
        public void G(){} // RVA: 0x5BDDCE0
        public void H(){} // RVA: 0x5BDDCF0
        public void ROL(){} // RVA: 0x5BDDD00
        public void FF(){} // RVA: 0x5BDDD20
        public void GG(){} // RVA: 0x5BDDD60
        public void HH(){} // RVA: 0x5BDDDB0
        public void Encode(){} // RVA: 0x5BDDDF0
        public void Decode(){} // RVA: 0x5BDDEC0
        public void MD4Transform(){} // RVA: 0x5BDDF70
    }

    public class PKCS1
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x5BDE9B0
        public void I2OSP(){} // RVA: 0x5BDEA40
        public void OS2IP(){} // RVA: 0x5BDEAD0
        public void RSAVP1(){} // RVA: 0x5BDEBA0
        public void Verify_v15(){} // RVA: 0x5BDEBD0
        public void Encode_v15(){} // RVA: 0x5BDEF40
        public void HashNameFromOid(){} // RVA: 0x5BDF3B0
        public void CreateFromOid(){} // RVA: 0x5BDF900
        public void CreateFromName(){} // RVA: 0x5BDF960
        public void .cctor(){} // RVA: 0x5BDFEA0
    }

    public class PKCS8
    {
    }

    public class RC4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BE2850
        public void get_IV(){} // RVA: 0x5BE2980
        public void set_IV(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x5BE29C0
        public void .cctor(){} // RVA: 0x5BE2A10
    }

    public class RSAManaged
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BE2DF0 | overloaded x2
        public void Finalize(){} // RVA: 0x5AAC950
        public void GenerateKeyPair(){} // RVA: 0x5BE2F60
        public void get_KeySize(){} // RVA: 0x5BE3740
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x5BE37F0
        public void get_PublicOnly(){} // RVA: 0x5BE3830
        public void get_SignatureAlgorithm(){} // RVA: 0x5BE38D0
        public void DecryptValue(){} // RVA: 0x5BE3910
        public void EncryptValue(){} // RVA: 0x5BE3DB0
        public void ExportParameters(){} // RVA: 0x5BE3F50
        public void ImportParameters(){} // RVA: 0x5BE4420
        public void Dispose(){} // RVA: 0x5BE4BE0
        public void ToXmlString(){} // RVA: 0x5BE5170
        public void GetPaddedValue(){} // RVA: 0x5BE59F0
    }

    public class SymmetricTransform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C13970
        public void Finalize(){} // RVA: 0x5C13DD0
        public void System.IDisposable.Dispose(){} // RVA: 0x5C13E20
        public void Dispose(){} // RVA: 0x5C13E90
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x3C2850
        public void get_CanReuseTransform(){} // RVA: 0x2DD320
        public void get_InputBlockSize(){} // RVA: 0x197C3B0
        public void get_OutputBlockSize(){} // RVA: 0x197C3B0
        public void Transform(){} // RVA: 0x5C13F90
        public void ECB(){} // RVA: 0x2DC60
        public void CBC(){} // RVA: 0x5C14110
        public void CFB(){} // RVA: 0x5C14250
        public void OFB(){} // RVA: 0x5C146D0
        public void CTS(){} // RVA: 0x5C14720
        public void CheckInput(){} // RVA: 0x5C14770
        public void TransformBlock(){} // RVA: 0x5C14910
        public void get_KeepLastBlock(){} // RVA: 0x5C14C30
        public void InternalTransformBlock(){} // RVA: 0x5C14C50
        public void Random(){} // RVA: 0x5C14E40
        public void ThrowBadPaddingException(){} // RVA: 0x5C14F50
        public void FinalEncrypt(){} // RVA: 0x5C150B0
        public void FinalDecrypt(){} // RVA: 0x5C15440
        public void TransformFinalBlock(){} // RVA: 0x5C15760
    }

}