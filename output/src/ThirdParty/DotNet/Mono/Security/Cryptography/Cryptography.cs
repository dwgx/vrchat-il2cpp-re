// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Cryptography
// Classes: 22
// Methods: 241

namespace ThirdParty.DotNet.Mono.Security.Cryptography
{
    public class ARC4Managed
    {
        public byte[] key; // 0x48
        public byte[] state; // 0x50
        public byte x; // 0x58
        public byte y; // 0x59
        public bool m_disposed; // 0x5A

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

    public class CryptoConvert
    {
        // ── Methods ──
        public void ToInt32LE(){} // RVA: 0x5BDB0A0
        public void ToUInt32LE(){} // RVA: 0x5BDB0A0
        public void GetBytesLE(){} // RVA: 0x5C06990
        public void Trim(){} // RVA: 0x5C06A20
        public void FromCapiPrivateKeyBlob(){} // RVA: 0x5C06AF0
        public void GetParametersFromCapiPrivateKeyBlob(){} // RVA: 0x5C06BD0
        public void FromCapiPrivateKeyBlobDSA(){} // RVA: 0x5C07840
        public void ToCapiPrivateKeyBlob(){} // RVA: 0x5C085D0 | overloaded x2
        public void FromCapiPublicKeyBlob(){} // RVA: 0x5C08AC0
        public void GetParametersFromCapiPublicKeyBlob(){} // RVA: 0x5C08C20
        public void FromCapiPublicKeyBlobDSA(){} // RVA: 0x5C091D0
        public void ToCapiPublicKeyBlob(){} // RVA: 0x5C09D50 | overloaded x2
        public void FromCapiKeyBlob(){} // RVA: 0x5C0A240 | overloaded x2
        public void FromCapiKeyBlobDSA(){} // RVA: 0x5C0A590 | overloaded x2
    }

    public class DSAManaged
    {
        public bool keypairGenerated; // 0x20
        public bool m_disposed; // 0x21
        public Mono.Math.BigInteger p; // 0x28
        public Mono.Math.BigInteger q; // 0x30
        public Mono.Math.BigInteger g; // 0x38

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
        public System.Security.Cryptography.RandomNumberGenerator rng;

        // ── Methods ──
        public void get_Rng(){} // RVA: 0x5BDC5D0
        public void Key(){} // RVA: 0x5BDC690
    }

    public class KeyBuilder
    {
        public System.Security.Cryptography.RandomNumberGenerator Filename;

        // ── Methods ──
        public void get_Rng(){} // RVA: 0x5C0A6C0
        public void Key(){} // RVA: 0x5C0A780
        public void IV(){} // RVA: 0x5C0A7F0
    }

    public class KeyPairPersistence
    {
        public bool _userPathExists;
        public string _userPath; // 0x8
        public bool _machinePathExists; // 0x10
        public string _machinePath; // 0x18
        public System.Security.Cryptography.CspParameters _params; // 0x10
        public string _keyvalue; // 0x18
        public string _filename; // 0x20
        public string _container; // 0x28
        public object lockobj; // 0x20

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

    public class MD2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BDC7B0
        public void Create(){} // RVA: 0x5C0CEA0
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

    public class MD2Managed
    {
        // ── Methods ──
        public void Padding(){} // RVA: 0x5C0CEF0
        public void .ctor(){} // RVA: 0x5C0CF70
        public void Initialize(){} // RVA: 0x5BDCA70
        public void HashCore(){} // RVA: 0x5C0D150
        public void HashFinal(){} // RVA: 0x5C0D250
        public void MD2Transform(){} // RVA: 0x5C0D3B0
        public void .cctor(){} // RVA: 0x5C0D9F0
    }

    public class MD4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BDC7B0
        public void Create(){} // RVA: 0x5BDD460
    }

    public class MD4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BDC7B0
        public void Create(){} // RVA: 0x5C0DAD0
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

    public class MD4Managed
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C0DB20
        public void Initialize(){} // RVA: 0x5BDD700
        public void HashCore(){} // RVA: 0x5BDD7D0
        public void HashFinal(){} // RVA: 0x5C0DD70
        public void Padding(){} // RVA: 0x5C0E070
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

    public class PKCS1
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x5BDE9B0
        public void xor(){} // RVA: 0x5C0E0E0
        public void GetEmptyHash(){} // RVA: 0x5C0E190
        public void I2OSP(){} // RVA: 0x5C0E510 | overloaded x2
        public void OS2IP(){} // RVA: 0x5C0E5A0
        public void RSAEP(){} // RVA: 0x5BDEBA0
        public void RSADP(){} // RVA: 0x5C0E670
        public void RSASP1(){} // RVA: 0x5C0E670
        public void RSAVP1(){} // RVA: 0x5BDEBA0
        public void Encrypt_OAEP(){} // RVA: 0x5C0E6A0
        public void Decrypt_OAEP(){} // RVA: 0x5C0EBA0
        public void Sign_v15(){} // RVA: 0x5C0F200 | overloaded x2
        public void Verify_v15(){} // RVA: 0x5C0F4E0 | overloaded x3
        public void Encode_v15(){} // RVA: 0x5C0F850
        public void MGF1(){} // RVA: 0x5C0FCC0
        public void CreateFromName(){} // RVA: 0x5C10260
        public void .cctor(){} // RVA: 0x5C107E0
    }

    public class PKCS8
    {
    }

    public class RC4
    {
        public System.Security.Cryptography.KeySizes[] s_legalBlockSizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BE2850
        public void get_IV(){} // RVA: 0x5BE2980
        public void set_IV(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x5BE29C0
        public void .cctor(){} // RVA: 0x5BE2A10
    }

    public class RSAManaged
    {
        public bool isCRTpossible; // 0x20
        public bool keyBlinding; // 0x21
        public bool keypairGenerated; // 0x22
        public bool m_disposed; // 0x23

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

    public class RSAManaged
    {
        public bool isCRTpossible; // 0x20
        public bool keyBlinding; // 0x21
        public bool keypairGenerated; // 0x22
        public bool m_disposed; // 0x23
        public Mono.Math.BigInteger d; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C10AC0
        public void Finalize(){} // RVA: 0x5AAC950
        public void GenerateKeyPair(){} // RVA: 0x5C10C30
        public void get_KeySize(){} // RVA: 0x5C11410
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x5C114C0
        public void get_PublicOnly(){} // RVA: 0x5C11500
        public void get_SignatureAlgorithm(){} // RVA: 0x5C115A0
        public void DecryptValue(){} // RVA: 0x5C115E0
        public void EncryptValue(){} // RVA: 0x5C11A80
        public void ExportParameters(){} // RVA: 0x5C11C20
        public void ImportParameters(){} // RVA: 0x5C120F0
        public void Dispose(){} // RVA: 0x5C128B0
        public void add_KeyGenerated(){} // RVA: 0x5C12E40
        public void remove_KeyGenerated(){} // RVA: 0x5C12F30
        public void ToXmlString(){} // RVA: 0x5C13020
        public void get_IsCrtPossible(){} // RVA: 0x5C138A0
        public void GetPaddedValue(){} // RVA: 0x5C138B0
    }

    public class SymmetricTransform
    {
        public System.Security.Cryptography.SymmetricAlgorithm algo; // 0x10
        public bool encrypt; // 0x18
        public int BlockSizeByte; // 0x1C
        public byte[] temp; // 0x20
        public byte[] temp2; // 0x28

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