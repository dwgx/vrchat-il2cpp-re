// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Cryptography
// Classes: 21
// Methods: 230

namespace ThirdParty.DotNet.Mono.Security.Cryptography
{
    public class ARC4Managed : RC4
    {
        public object key;
        public object state;
        public object x;
        public object y;
        public object m_disposed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6652AA0
        public void Finalize(){} // RVA: 0x6652C90
        public void Dispose(){} // RVA: 0x6652CE0
        public void get_Key(){} // RVA: 0x6652E40
        public void set_Key(){} // RVA: 0x6652EE0
        public void get_CanReuseTransform(){} // RVA: 0xB43320
        public void CreateEncryptor(){} // RVA: 0x6653170
        public void CreateDecryptor(){} // RVA: 0x66531A0
        public void GenerateIV(){} // RVA: 0x66531E0
        public void GenerateKey(){} // RVA: 0x6653240
        public void get_CanTransformMultipleBlocks(){} // RVA: 0xC2E4C0
        public void get_InputBlockSize(){} // RVA: 0xC3CCE0
        public void get_OutputBlockSize(){} // RVA: 0xC3CCE0
        public void KeySetup(){} // RVA: 0x66533D0
        public void CheckInput(){} // RVA: 0x66534D0
        public void TransformBlock(){} // RVA: 0x6653670
        public void InternalTransformBlock(){} // RVA: 0x6653800
        public void TransformFinalBlock(){} // RVA: 0x6653990
    }

    public class CryptoConvert : Object
    {
        // ── Methods ──
        public void ToInt32LE(){} // RVA: 0x6653A50
        public void ToUInt32LE(){} // RVA: 0x6653A50
        public void Trim(){} // RVA: 0x6653AD0
        public void FromCapiPrivateKeyBlob(){} // RVA: 0x6653BA0
        public void GetParametersFromCapiPrivateKeyBlob(){} // RVA: 0x6653DF0
        public void ToHex(){} // RVA: 0x6654A40
        public void FromHexChar(){} // RVA: 0x6654CA0
        public void FromHex(){} // RVA: 0x6654D30
    }

    public class CryptoConvert : Object
    {
        // ── Methods ──
        public void ToInt32LE(){} // RVA: 0x6653A50
        public void ToUInt32LE(){} // RVA: 0x6653A50
        public void GetBytesLE(){} // RVA: 0x667F360
        public void Trim(){} // RVA: 0x667F3F0
        public void FromCapiPrivateKeyBlob(){} // RVA: 0x667F4B0
        public void GetParametersFromCapiPrivateKeyBlob(){} // RVA: 0x667F5A0
        public void FromCapiPrivateKeyBlobDSA(){} // RVA: 0x66801F0
        public void ToCapiPrivateKeyBlob(){} // RVA: 0x6680F70
        public void FromCapiPublicKeyBlob(){} // RVA: 0x6681460
        public void GetParametersFromCapiPublicKeyBlob(){} // RVA: 0x66815D0
        public void FromCapiPublicKeyBlobDSA(){} // RVA: 0x6681BA0
        public void ToCapiPublicKeyBlob(){} // RVA: 0x6682750
        public void FromCapiKeyBlob(){} // RVA: 0x6682C40
        public void FromCapiKeyBlobDSA(){} // RVA: 0x6682FA0
    }

    public class DSAManaged : DSA
    {
        public object keypairGenerated;
        public object m_disposed;
        public object p;
        public object q;
        public object g;
        public object x;
        public object y;
        public object j;
        public object seed;
        public object counter;
        public object j_missing;
        public object rng;
        public object KeyGenerated;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x668E190
        public void Finalize(){} // RVA: 0x6527310
        public void Generate(){} // RVA: 0x668E2D0
        public void GenerateKeyPair(){} // RVA: 0x668E320
        public void add(){} // RVA: 0x668E610
        public void GenerateParams(){} // RVA: 0x668E6B0
        public void get_Random(){} // RVA: 0x668F240
        public void get_KeySize(){} // RVA: 0x668F2C0
        public void get_KeyExchangeAlgorithm(){} // RVA: 0xDAC980
        public void get_PublicOnly(){} // RVA: 0x668F2F0
        public void get_SignatureAlgorithm(){} // RVA: 0x668F360
        public void NormalizeArray(){} // RVA: 0x668F3A0
        public void ExportParameters(){} // RVA: 0x668F460
        public void ImportParameters(){} // RVA: 0x668F9A0
        public void CreateSignature(){} // RVA: 0x668FDD0
        public void VerifySignature(){} // RVA: 0x6690200
        public void Dispose(){} // RVA: 0x66907E0
        public void add_KeyGenerated(){} // RVA: 0x6690A90
        public void remove_KeyGenerated(){} // RVA: 0x6690B80
    }

    public class KeyBuilder : Object
    {
        public object rng;

        // ── Methods ──
        public void get_Rng(){} // RVA: 0x6654F90
        public void Key(){} // RVA: 0x6655050
    }

    public class KeyBuilder : Object
    {
        public object rng;

        // ── Methods ──
        public void get_Rng(){} // RVA: 0x66830D0
        public void Key(){} // RVA: 0x6683190
        public void IV(){} // RVA: 0x6683200
    }

    public class KeyPairPersistence : Object
    {
        public object _userPathExists;
        public object _userPath;
        public object _machinePathExists;
        public object _machinePath;
        public object _params;
        public object _keyvalue;
        public object _filename;
        public object _container;
        public object lockobj;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6683390
        public void get_Filename(){} // RVA: 0x66834B0
        public void get_KeyValue(){} // RVA: 0xB465B0
        public void set_KeyValue(){} // RVA: 0x66837A0
        public void get_Parameters(){} // RVA: 0x6683800
        public void Load(){} // RVA: 0x6683810
        public void Save(){} // RVA: 0x66839F0
        public void Remove(){} // RVA: 0x6683C00
        public void get_UserPath(){} // RVA: 0x6683CF0
        public void get_MachinePath(){} // RVA: 0x6684360
        public void _CanSecure(){} // RVA: 0xB43320
        public void _ProtectUser(){} // RVA: 0xB43320
        public void _ProtectMachine(){} // RVA: 0xB43320
        public void _IsUserProtected(){} // RVA: 0xB43320
        public void _IsMachineProtected(){} // RVA: 0xB43320
        public void CanSecure(){} // RVA: 0x66849D0
        public void ProtectUser(){} // RVA: 0x6684A40
        public void ProtectMachine(){} // RVA: 0x6684AC0
        public void IsUserProtected(){} // RVA: 0x6684B40
        public void IsMachineProtected(){} // RVA: 0x6684BC0
        public void get_CanChange(){} // RVA: 0x3911580
        public void get_UseDefaultKeyContainer(){} // RVA: 0x6684C40
        public void get_UseMachineKeyStore(){} // RVA: 0x6684C60
        public void get_ContainerName(){} // RVA: 0x6684C80
        public void Copy(){} // RVA: 0x6684FC0
        public void FromXml(){} // RVA: 0x6685080
        public void ToXml(){} // RVA: 0x66854C0
        public void .cctor(){} // RVA: 0x6685740
    }

    public class MD2 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6655170
        public void Create(){} // RVA: 0x6655180
    }

    public class MD2 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6655170
        public void Create(){} // RVA: 0x6685860
    }

    public class MD2Managed : MD2
    {
        public object state;
        public object checksum;
        public object buffer;
        public object count;
        public object x;
        public object PI_SUBST;

        // ── Methods ──
        public void Padding(){} // RVA: 0x66551D0
        public void .ctor(){} // RVA: 0x6655260
        public void Initialize(){} // RVA: 0x6655440
        public void HashCore(){} // RVA: 0x66554B0
        public void HashFinal(){} // RVA: 0x66555B0
        public void MD2Transform(){} // RVA: 0x6655710
        public void .cctor(){} // RVA: 0x6655D90
    }

    public class MD2Managed : MD2
    {
        public object state;
        public object checksum;
        public object buffer;
        public object count;
        public object x;
        public object PI_SUBST;

        // ── Methods ──
        public void Padding(){} // RVA: 0x66858B0
        public void .ctor(){} // RVA: 0x6685940
        public void Initialize(){} // RVA: 0x6655440
        public void HashCore(){} // RVA: 0x6685B20
        public void HashFinal(){} // RVA: 0x6685C20
        public void MD2Transform(){} // RVA: 0x6685D80
        public void .cctor(){} // RVA: 0x6686400
    }

    public class MD4 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6655170
        public void Create(){} // RVA: 0x6655E70
    }

    public class MD4 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6655170
        public void Create(){} // RVA: 0x66864E0
    }

    public class MD4Managed : MD4
    {
        public object state;
        public object buffer;
        public object count;
        public object x;
        public object digest;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6655EC0
        public void Initialize(){} // RVA: 0x6656110
        public void HashCore(){} // RVA: 0x66561E0
        public void HashFinal(){} // RVA: 0x6656360
        public void Padding(){} // RVA: 0x6656630
        public void F(){} // RVA: 0x66566A0
        public void G(){} // RVA: 0x66566B0
        public void H(){} // RVA: 0x66566C0
        public void ROL(){} // RVA: 0x66566D0
        public void FF(){} // RVA: 0x66566F0
        public void GG(){} // RVA: 0x6656730
        public void HH(){} // RVA: 0x6656780
        public void Encode(){} // RVA: 0x66567C0
        public void Decode(){} // RVA: 0x6656870
        public void MD4Transform(){} // RVA: 0x6656920
    }

    public class MD4Managed : MD4
    {
        public object state;
        public object buffer;
        public object count;
        public object x;
        public object digest;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6686530
        public void Initialize(){} // RVA: 0x6656110
        public void HashCore(){} // RVA: 0x66561E0
        public void HashFinal(){} // RVA: 0x6686780
        public void Padding(){} // RVA: 0x6686A50
        public void F(){} // RVA: 0x66566A0
        public void G(){} // RVA: 0x66566B0
        public void H(){} // RVA: 0x66566C0
        public void ROL(){} // RVA: 0x66566D0
        public void FF(){} // RVA: 0x66566F0
        public void GG(){} // RVA: 0x6656730
        public void HH(){} // RVA: 0x6656780
        public void Encode(){} // RVA: 0x66567C0
        public void Decode(){} // RVA: 0x6656870
        public void MD4Transform(){} // RVA: 0x6656920
    }

    public class PKCS1 : Object
    {
        public object emptySHA1;
        public object emptySHA256;
        public object emptySHA384;
        public object emptySHA512;

        // ── Methods ──
        public void Compare(){} // RVA: 0x66573D0
        public void I2OSP(){} // RVA: 0x6657460
        public void OS2IP(){} // RVA: 0x66574F0
        public void RSAVP1(){} // RVA: 0x66575D0
        public void Verify_v15(){} // RVA: 0x6657600
        public void Encode_v15(){} // RVA: 0x6657980
        public void HashNameFromOid(){} // RVA: 0x6657E00
        public void CreateFromOid(){} // RVA: 0x6658350
        public void CreateFromName(){} // RVA: 0x66583B0
        public void .cctor(){} // RVA: 0x66588E0
    }

    public class PKCS1 : Object
    {
        public object emptySHA1;
        public object emptySHA256;
        public object emptySHA384;
        public object emptySHA512;

        // ── Methods ──
        public void Compare(){} // RVA: 0x66573D0
        public void xor(){} // RVA: 0x6686AC0
        public void GetEmptyHash(){} // RVA: 0x6686B70
        public void I2OSP(){} // RVA: 0x6686EE0
        public void OS2IP(){} // RVA: 0x6686F70
        public void RSAEP(){} // RVA: 0x66575D0
        public void RSADP(){} // RVA: 0x6687050
        public void RSASP1(){} // RVA: 0x6687050
        public void RSAVP1(){} // RVA: 0x66575D0
        public void Encrypt_OAEP(){} // RVA: 0x6687080
        public void Decrypt_OAEP(){} // RVA: 0x6687590
        public void Sign_v15(){} // RVA: 0x6687C00
        public void Verify_v15(){} // RVA: 0x6687EE0
        public void Encode_v15(){} // RVA: 0x6688260
        public void MGF1(){} // RVA: 0x66886E0
        public void CreateFromName(){} // RVA: 0x6688CF0
        public void .cctor(){} // RVA: 0x6689260
    }

    public class RC4 : SymmetricAlgorithm
    {
        public object s_legalBlockSizes;
        public object s_legalKeySizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x665B270
        public void get_IV(){} // RVA: 0x665B3A0
        public void set_IV(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x665B3E0
        public void .cctor(){} // RVA: 0x665B600
    }

    public class RSAManaged : RSA
    {
        public object isCRTpossible;
        public object keyBlinding;
        public object keypairGenerated;
        public object m_disposed;
        public object d;
        public object p;
        public object q;
        public object dp;
        public object dq;
        public object qInv;
        public object n;
        public object e;
        public object KeyGenerated;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x665B9E0
        public void Finalize(){} // RVA: 0x6527310
        public void GenerateKeyPair(){} // RVA: 0x665BB50
        public void get_KeySize(){} // RVA: 0x665C330
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x665C3E0
        public void get_PublicOnly(){} // RVA: 0x665C420
        public void get_SignatureAlgorithm(){} // RVA: 0x665C4C0
        public void DecryptValue(){} // RVA: 0x665C500
        public void EncryptValue(){} // RVA: 0x665C980
        public void ExportParameters(){} // RVA: 0x665CB20
        public void ImportParameters(){} // RVA: 0x665CFF0
        public void Dispose(){} // RVA: 0x665D7B0
        public void ToXmlString(){} // RVA: 0x665DC20
        public void GetPaddedValue(){} // RVA: 0x665E4A0
    }

    public class RSAManaged : RSA
    {
        public object isCRTpossible;
        public object keyBlinding;
        public object keypairGenerated;
        public object m_disposed;
        public object d;
        public object p;
        public object q;
        public object dp;
        public object dq;
        public object qInv;
        public object n;
        public object e;
        public object KeyGenerated;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6689540
        public void Finalize(){} // RVA: 0x6527310
        public void GenerateKeyPair(){} // RVA: 0x66896B0
        public void get_KeySize(){} // RVA: 0x6689E90
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x6689F40
        public void get_PublicOnly(){} // RVA: 0x6689F80
        public void get_SignatureAlgorithm(){} // RVA: 0x668A020
        public void DecryptValue(){} // RVA: 0x668A060
        public void EncryptValue(){} // RVA: 0x668A4E0
        public void ExportParameters(){} // RVA: 0x668A680
        public void ImportParameters(){} // RVA: 0x668AB50
        public void Dispose(){} // RVA: 0x668B310
        public void add_KeyGenerated(){} // RVA: 0x668B780
        public void remove_KeyGenerated(){} // RVA: 0x668B870
        public void ToXmlString(){} // RVA: 0x668B960
        public void get_IsCrtPossible(){} // RVA: 0x668C1E0
        public void GetPaddedValue(){} // RVA: 0x668C1F0
    }

    public class SymmetricTransform : Object
    {
        public object algo;
        public object encrypt;
        public object BlockSizeByte;
        public object temp;
        public object temp2;
        public object workBuff;
        public object workout;
        public object padmode;
        public object FeedBackByte;
        public object m_disposed;
        public object lastBlock;
        public object _rng;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x668C2A0
        public void Finalize(){} // RVA: 0x668C6F0
        public void System.IDisposable.Dispose(){} // RVA: 0x668C740
        public void Dispose(){} // RVA: 0x668C7B0
        public void get_CanTransformMultipleBlocks(){} // RVA: 0xC2E4C0
        public void get_CanReuseTransform(){} // RVA: 0xB43320
        public void get_InputBlockSize(){} // RVA: 0x2244FB0
        public void get_OutputBlockSize(){} // RVA: 0x2244FB0
        public void Transform(){} // RVA: 0x668C8B0
        public void ECB(){} // RVA: 0x8943B0
        public void CBC(){} // RVA: 0x668CA30
        public void CFB(){} // RVA: 0x668CB80
        public void OFB(){} // RVA: 0x668D010
        public void CTS(){} // RVA: 0x668D060
        public void CheckInput(){} // RVA: 0x668D0B0
        public void TransformBlock(){} // RVA: 0x668D250
        public void get_KeepLastBlock(){} // RVA: 0x668D570
        public void InternalTransformBlock(){} // RVA: 0x668D590
        public void Random(){} // RVA: 0x668D780
        public void ThrowBadPaddingException(){} // RVA: 0x668D8A0
        public void FinalEncrypt(){} // RVA: 0x668D9F0
        public void FinalDecrypt(){} // RVA: 0x668DD80
        public void TransformFinalBlock(){} // RVA: 0x668E0C0
    }

}