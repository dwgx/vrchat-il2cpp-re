// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Cryptography
// Classes: 22
// Methods: 241

namespace ThirdParty.DotNet.Mono.Security.Cryptography
{
    public class ARC4Managed
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF868A110
        public void Finalize(){} // RVA: 0x7FFAF868A300
        public void Dispose(){} // RVA: 0x7FFAF868A350
        public void get_Key(){} // RVA: 0x7FFAF868A4B0
        public void set_Key(){} // RVA: 0x7FFAF868A550
        public void get_CanReuseTransform(){} // RVA: 0x7FFAF2D8D320
        public void CreateEncryptor(){} // RVA: 0x7FFAF868A7D0
        public void CreateDecryptor(){} // RVA: 0x7FFAF868A800
        public void GenerateIV(){} // RVA: 0x7FFAF868A840
        public void GenerateKey(){} // RVA: 0x7FFAF868A8A0
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7FFAF2E72850
        public void get_InputBlockSize(){} // RVA: 0x7FFAF2E7FAF0
        public void get_OutputBlockSize(){} // RVA: 0x7FFAF2E7FAF0
        public void KeySetup(){} // RVA: 0x7FFAF868AA30
        public void CheckInput(){} // RVA: 0x7FFAF868AB40
        public void TransformBlock(){} // RVA: 0x7FFAF868ACE0
        public void InternalTransformBlock(){} // RVA: 0x7FFAF868AE70
        public void TransformFinalBlock(){} // RVA: 0x7FFAF868AFE0
    }

    public class CryptoConvert
    {
        // ── Methods ──
        public void ToInt32LE(){} // RVA: 0x7FFAF868B0A0
        public void ToUInt32LE(){} // RVA: 0x7FFAF868B0A0
        public void Trim(){} // RVA: 0x7FFAF868B120
        public void FromCapiPrivateKeyBlob(){} // RVA: 0x7FFAF868B200 | overloaded x2
        public void GetParametersFromCapiPrivateKeyBlob(){} // RVA: 0x7FFAF868B430
        public void ToHex(){} // RVA: 0x7FFAF868C0A0
        public void FromHexChar(){} // RVA: 0x7FFAF868C2E0
        public void FromHex(){} // RVA: 0x7FFAF868C370
    }

    public class CryptoConvert
    {
        // ── Methods ──
        public void ToInt32LE(){} // RVA: 0x7FFAF868B0A0
        public void ToUInt32LE(){} // RVA: 0x7FFAF868B0A0
        public void GetBytesLE(){} // RVA: 0x7FFAF86B6990
        public void Trim(){} // RVA: 0x7FFAF86B6A20
        public void FromCapiPrivateKeyBlob(){} // RVA: 0x7FFAF86B6AF0
        public void GetParametersFromCapiPrivateKeyBlob(){} // RVA: 0x7FFAF86B6BD0
        public void FromCapiPrivateKeyBlobDSA(){} // RVA: 0x7FFAF86B7840
        public void ToCapiPrivateKeyBlob(){} // RVA: 0x7FFAF86B85D0 | overloaded x2
        public void FromCapiPublicKeyBlob(){} // RVA: 0x7FFAF86B8AC0
        public void GetParametersFromCapiPublicKeyBlob(){} // RVA: 0x7FFAF86B8C20
        public void FromCapiPublicKeyBlobDSA(){} // RVA: 0x7FFAF86B91D0
        public void ToCapiPublicKeyBlob(){} // RVA: 0x7FFAF86B9D50 | overloaded x2
        public void FromCapiKeyBlob(){} // RVA: 0x7FFAF86BA240 | overloaded x2
        public void FromCapiKeyBlobDSA(){} // RVA: 0x7FFAF86BA590 | overloaded x2
    }

    public class DSAManaged
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86C5830
        public void Finalize(){} // RVA: 0x7FFAF855C950
        public void Generate(){} // RVA: 0x7FFAF86C5970
        public void GenerateKeyPair(){} // RVA: 0x7FFAF86C59C0
        public void add(){} // RVA: 0x7FFAF86C5CB0
        public void GenerateParams(){} // RVA: 0x7FFAF86C5D30
        public void get_Random(){} // RVA: 0x7FFAF86C68E0
        public void get_KeySize(){} // RVA: 0x7FFAF86C6960
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7FFAF2FC9240
        public void get_PublicOnly(){} // RVA: 0x7FFAF86C6990
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAF86C6A00
        public void NormalizeArray(){} // RVA: 0x7FFAF86C6A40
        public void ExportParameters(){} // RVA: 0x7FFAF86C6B00
        public void ImportParameters(){} // RVA: 0x7FFAF86C7040
        public void CreateSignature(){} // RVA: 0x7FFAF86C7470
        public void VerifySignature(){} // RVA: 0x7FFAF86C78B0
        public void Dispose(){} // RVA: 0x7FFAF86C7E90
        public void add_KeyGenerated(){} // RVA: 0x7FFAF86C8180
        public void remove_KeyGenerated(){} // RVA: 0x7FFAF86C8270
    }

    public class KeyBuilder
    {
        // ── Methods ──
        public void get_Rng(){} // RVA: 0x7FFAF868C5D0
        public void Key(){} // RVA: 0x7FFAF868C690
    }

    public class KeyBuilder
    {
        public object Filename;

        // ── Methods ──
        public void get_Rng(){} // RVA: 0x7FFAF86BA6C0
        public void Key(){} // RVA: 0x7FFAF86BA780
        public void IV(){} // RVA: 0x7FFAF86BA7F0
    }

    public class KeyPairPersistence
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86BA980 | overloaded x2
        public void get_Filename(){} // RVA: 0x7FFAF86BAAA0
        public void get_KeyValue(){} // RVA: 0x7FFAF2D907C0
        public void set_KeyValue(){} // RVA: 0x7FFAF86BADA0
        public void get_Parameters(){} // RVA: 0x7FFAF86BAE00
        public void Load(){} // RVA: 0x7FFAF86BAE10
        public void Save(){} // RVA: 0x7FFAF86BAFE0
        public void Remove(){} // RVA: 0x7FFAF86BB1F0
        public void get_UserPath(){} // RVA: 0x7FFAF86BB2E0
        public void get_MachinePath(){} // RVA: 0x7FFAF86BB970
        public void _CanSecure(){} // RVA: 0x7FFAF2D8D320
        public void _ProtectUser(){} // RVA: 0x7FFAF2D8D320
        public void _ProtectMachine(){} // RVA: 0x7FFAF2D8D320
        public void _IsUserProtected(){} // RVA: 0x7FFAF2D8D320
        public void _IsMachineProtected(){} // RVA: 0x7FFAF2D8D320
        public void CanSecure(){} // RVA: 0x7FFAF86BC000
        public void ProtectUser(){} // RVA: 0x7FFAF86BC070
        public void ProtectMachine(){} // RVA: 0x7FFAF86BC0F0
        public void IsUserProtected(){} // RVA: 0x7FFAF86BC170
        public void IsMachineProtected(){} // RVA: 0x7FFAF86BC1F0
        public void get_CanChange(){} // RVA: 0x7FFAF5982970
        public void get_UseDefaultKeyContainer(){} // RVA: 0x7FFAF86BC270
        public void get_UseMachineKeyStore(){} // RVA: 0x7FFAF86BC290
        public void get_ContainerName(){} // RVA: 0x7FFAF86BC2B0
        public void Copy(){} // RVA: 0x7FFAF86BC5F0
        public void FromXml(){} // RVA: 0x7FFAF86BC6B0
        public void ToXml(){} // RVA: 0x7FFAF86BCAF0
        public void .cctor(){} // RVA: 0x7FFAF86BCD80
    }

    public class MD2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF868C7B0
        public void Create(){} // RVA: 0x7FFAF868C7C0
    }

    public class MD2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF868C7B0
        public void Create(){} // RVA: 0x7FFAF86BCEA0
    }

    public class MD2Managed
    {
        // ── Methods ──
        public void Padding(){} // RVA: 0x7FFAF868C810
        public void .ctor(){} // RVA: 0x7FFAF868C890
        public void Initialize(){} // RVA: 0x7FFAF868CA70
        public void HashCore(){} // RVA: 0x7FFAF868CAE0
        public void HashFinal(){} // RVA: 0x7FFAF868CBE0
        public void MD2Transform(){} // RVA: 0x7FFAF868CD40
        public void .cctor(){} // RVA: 0x7FFAF868D380
    }

    public class MD2Managed
    {
        // ── Methods ──
        public void Padding(){} // RVA: 0x7FFAF86BCEF0
        public void .ctor(){} // RVA: 0x7FFAF86BCF70
        public void Initialize(){} // RVA: 0x7FFAF868CA70
        public void HashCore(){} // RVA: 0x7FFAF86BD150
        public void HashFinal(){} // RVA: 0x7FFAF86BD250
        public void MD2Transform(){} // RVA: 0x7FFAF86BD3B0
        public void .cctor(){} // RVA: 0x7FFAF86BD9F0
    }

    public class MD4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF868C7B0
        public void Create(){} // RVA: 0x7FFAF868D460
    }

    public class MD4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF868C7B0
        public void Create(){} // RVA: 0x7FFAF86BDAD0
    }

    public class MD4Managed
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF868D4B0
        public void Initialize(){} // RVA: 0x7FFAF868D700
        public void HashCore(){} // RVA: 0x7FFAF868D7D0
        public void HashFinal(){} // RVA: 0x7FFAF868D960
        public void Padding(){} // RVA: 0x7FFAF868DC60
        public void F(){} // RVA: 0x7FFAF868DCD0
        public void G(){} // RVA: 0x7FFAF868DCE0
        public void H(){} // RVA: 0x7FFAF868DCF0
        public void ROL(){} // RVA: 0x7FFAF868DD00
        public void FF(){} // RVA: 0x7FFAF868DD20
        public void GG(){} // RVA: 0x7FFAF868DD60
        public void HH(){} // RVA: 0x7FFAF868DDB0
        public void Encode(){} // RVA: 0x7FFAF868DDF0
        public void Decode(){} // RVA: 0x7FFAF868DEC0
        public void MD4Transform(){} // RVA: 0x7FFAF868DF70
    }

    public class MD4Managed
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86BDB20
        public void Initialize(){} // RVA: 0x7FFAF868D700
        public void HashCore(){} // RVA: 0x7FFAF868D7D0
        public void HashFinal(){} // RVA: 0x7FFAF86BDD70
        public void Padding(){} // RVA: 0x7FFAF86BE070
        public void F(){} // RVA: 0x7FFAF868DCD0
        public void G(){} // RVA: 0x7FFAF868DCE0
        public void H(){} // RVA: 0x7FFAF868DCF0
        public void ROL(){} // RVA: 0x7FFAF868DD00
        public void FF(){} // RVA: 0x7FFAF868DD20
        public void GG(){} // RVA: 0x7FFAF868DD60
        public void HH(){} // RVA: 0x7FFAF868DDB0
        public void Encode(){} // RVA: 0x7FFAF868DDF0
        public void Decode(){} // RVA: 0x7FFAF868DEC0
        public void MD4Transform(){} // RVA: 0x7FFAF868DF70
    }

    public class PKCS1
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFAF868E9B0
        public void I2OSP(){} // RVA: 0x7FFAF868EA40
        public void OS2IP(){} // RVA: 0x7FFAF868EAD0
        public void RSAVP1(){} // RVA: 0x7FFAF868EBA0
        public void Verify_v15(){} // RVA: 0x7FFAF868EBD0
        public void Encode_v15(){} // RVA: 0x7FFAF868EF40
        public void HashNameFromOid(){} // RVA: 0x7FFAF868F3B0
        public void CreateFromOid(){} // RVA: 0x7FFAF868F900
        public void CreateFromName(){} // RVA: 0x7FFAF868F960
        public void .cctor(){} // RVA: 0x7FFAF868FEA0
    }

    public class PKCS1
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFAF868E9B0
        public void xor(){} // RVA: 0x7FFAF86BE0E0
        public void GetEmptyHash(){} // RVA: 0x7FFAF86BE190
        public void I2OSP(){} // RVA: 0x7FFAF86BE510 | overloaded x2
        public void OS2IP(){} // RVA: 0x7FFAF86BE5A0
        public void RSAEP(){} // RVA: 0x7FFAF868EBA0
        public void RSADP(){} // RVA: 0x7FFAF86BE670
        public void RSASP1(){} // RVA: 0x7FFAF86BE670
        public void RSAVP1(){} // RVA: 0x7FFAF868EBA0
        public void Encrypt_OAEP(){} // RVA: 0x7FFAF86BE6A0
        public void Decrypt_OAEP(){} // RVA: 0x7FFAF86BEBA0
        public void Sign_v15(){} // RVA: 0x7FFAF86BF200 | overloaded x2
        public void Verify_v15(){} // RVA: 0x7FFAF86BF4E0 | overloaded x3
        public void Encode_v15(){} // RVA: 0x7FFAF86BF850
        public void MGF1(){} // RVA: 0x7FFAF86BFCC0
        public void CreateFromName(){} // RVA: 0x7FFAF86C0260
        public void .cctor(){} // RVA: 0x7FFAF86C07E0
    }

    public class PKCS8
    {
    }

    public class RC4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8692850
        public void get_IV(){} // RVA: 0x7FFAF8692980
        public void set_IV(){} // RVA: 0x7FFAF2D8D310
        public void Create(){} // RVA: 0x7FFAF86929C0
        public void .cctor(){} // RVA: 0x7FFAF8692A10
    }

    public class RSAManaged
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8692DF0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF855C950
        public void GenerateKeyPair(){} // RVA: 0x7FFAF8692F60
        public void get_KeySize(){} // RVA: 0x7FFAF8693740
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7FFAF86937F0
        public void get_PublicOnly(){} // RVA: 0x7FFAF8693830
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAF86938D0
        public void DecryptValue(){} // RVA: 0x7FFAF8693910
        public void EncryptValue(){} // RVA: 0x7FFAF8693DB0
        public void ExportParameters(){} // RVA: 0x7FFAF8693F50
        public void ImportParameters(){} // RVA: 0x7FFAF8694420
        public void Dispose(){} // RVA: 0x7FFAF8694BE0
        public void ToXmlString(){} // RVA: 0x7FFAF8695170
        public void GetPaddedValue(){} // RVA: 0x7FFAF86959F0
    }

    public class RSAManaged
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86C0AC0
        public void Finalize(){} // RVA: 0x7FFAF855C950
        public void GenerateKeyPair(){} // RVA: 0x7FFAF86C0C30
        public void get_KeySize(){} // RVA: 0x7FFAF86C1410
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7FFAF86C14C0
        public void get_PublicOnly(){} // RVA: 0x7FFAF86C1500
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAF86C15A0
        public void DecryptValue(){} // RVA: 0x7FFAF86C15E0
        public void EncryptValue(){} // RVA: 0x7FFAF86C1A80
        public void ExportParameters(){} // RVA: 0x7FFAF86C1C20
        public void ImportParameters(){} // RVA: 0x7FFAF86C20F0
        public void Dispose(){} // RVA: 0x7FFAF86C28B0
        public void add_KeyGenerated(){} // RVA: 0x7FFAF86C2E40
        public void remove_KeyGenerated(){} // RVA: 0x7FFAF86C2F30
        public void ToXmlString(){} // RVA: 0x7FFAF86C3020
        public void get_IsCrtPossible(){} // RVA: 0x7FFAF86C38A0
        public void GetPaddedValue(){} // RVA: 0x7FFAF86C38B0
    }

    public class SymmetricTransform
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86C3970
        public void Finalize(){} // RVA: 0x7FFAF86C3DD0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAF86C3E20
        public void Dispose(){} // RVA: 0x7FFAF86C3E90
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7FFAF2E72850
        public void get_CanReuseTransform(){} // RVA: 0x7FFAF2D8D320
        public void get_InputBlockSize(){} // RVA: 0x7FFAF442C3B0
        public void get_OutputBlockSize(){} // RVA: 0x7FFAF442C3B0
        public void Transform(){} // RVA: 0x7FFAF86C3F90
        public void ECB(){} // RVA: 0x7FFAF2ADDC60
        public void CBC(){} // RVA: 0x7FFAF86C4110
        public void CFB(){} // RVA: 0x7FFAF86C4250
        public void OFB(){} // RVA: 0x7FFAF86C46D0
        public void CTS(){} // RVA: 0x7FFAF86C4720
        public void CheckInput(){} // RVA: 0x7FFAF86C4770
        public void TransformBlock(){} // RVA: 0x7FFAF86C4910
        public void get_KeepLastBlock(){} // RVA: 0x7FFAF86C4C30
        public void InternalTransformBlock(){} // RVA: 0x7FFAF86C4C50
        public void Random(){} // RVA: 0x7FFAF86C4E40
        public void ThrowBadPaddingException(){} // RVA: 0x7FFAF86C4F50
        public void FinalEncrypt(){} // RVA: 0x7FFAF86C50B0
        public void FinalDecrypt(){} // RVA: 0x7FFAF86C5440
        public void TransformFinalBlock(){} // RVA: 0x7FFAF86C5760
    }

}