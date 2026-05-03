// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Cryptography
// Classes: 14
// Methods: 156

namespace ThirdParty.DotNet.Mono.Security.Cryptography
{
    public class ARC4Managed : RC4
    {
        public byte[] key; // 0x48
        public byte[] state; // 0x50
        public byte x; // 0x58
        public byte y; // 0x59
        public bool m_disposed; // 0x5A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8671AF60
        public void Finalize(){} // RVA: 0x7FFE8671B150
        public void Dispose(){} // RVA: 0x7FFE8671B1A0
        public void get_Key(){} // RVA: 0x7FFE8671B300
        public void set_Key(){} // RVA: 0x7FFE8671B3A0
        public void get_CanReuseTransform(){} // RVA: 0x7FFE810FB320
        public void CreateEncryptor(){} // RVA: 0x7FFE8671B620
        public void CreateDecryptor(){} // RVA: 0x7FFE8671B650
        public void GenerateIV(){} // RVA: 0x7FFE8671B690
        public void GenerateKey(){} // RVA: 0x7FFE8671B6F0
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7FFE811E0850
        public void get_InputBlockSize(){} // RVA: 0x7FFE811EDAF0
        public void get_OutputBlockSize(){} // RVA: 0x7FFE811EDAF0
        public void KeySetup(){} // RVA: 0x7FFE8671B880
        public void CheckInput(){} // RVA: 0x7FFE8671B990
        public void TransformBlock(){} // RVA: 0x7FFE8671BB30
        public void InternalTransformBlock(){} // RVA: 0x7FFE8671BCC0
        public void TransformFinalBlock(){} // RVA: 0x7FFE8671BE30
    }

    public class CryptoConvert : Object
    {
        // ── Methods ──
        public void ToInt32LE(){} // RVA: 0x7FFE8671BEF0
        public void ToUInt32LE(){} // RVA: 0x7FFE8671BEF0
        public void Trim(){} // RVA: 0x7FFE8671BF70
        public void FromCapiPrivateKeyBlob(){} // RVA: 0x7FFE8671C050 | overloaded x2
        public void GetParametersFromCapiPrivateKeyBlob(){} // RVA: 0x7FFE8671C280
        public void ToHex(){} // RVA: 0x7FFE8671CEF0
        public void FromHexChar(){} // RVA: 0x7FFE8671D130
        public void FromHex(){} // RVA: 0x7FFE8671D1C0
    }

    public class DSAManaged : DSA
    {
        public bool keypairGenerated; // 0x20
        public bool m_disposed; // 0x21
        public Mono.Math.BigInteger p; // 0x28
        public Mono.Math.BigInteger q; // 0x30
        public Mono.Math.BigInteger g; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86756680
        public void Finalize(){} // RVA: 0x7FFE865ED780
        public void Generate(){} // RVA: 0x7FFE867567C0
        public void GenerateKeyPair(){} // RVA: 0x7FFE86756810
        public void add(){} // RVA: 0x7FFE86756B00
        public void GenerateParams(){} // RVA: 0x7FFE86756B80
        public void get_Random(){} // RVA: 0x7FFE86757730
        public void get_KeySize(){} // RVA: 0x7FFE867577B0
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7FFE813240E0
        public void get_PublicOnly(){} // RVA: 0x7FFE867577E0
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFE86757850
        public void NormalizeArray(){} // RVA: 0x7FFE86757890
        public void ExportParameters(){} // RVA: 0x7FFE86757950
        public void ImportParameters(){} // RVA: 0x7FFE86757E90
        public void CreateSignature(){} // RVA: 0x7FFE867582C0
        public void VerifySignature(){} // RVA: 0x7FFE86758700
        public void Dispose(){} // RVA: 0x7FFE86758CE0
        public void add_KeyGenerated(){} // RVA: 0x7FFE86758FD0
        public void remove_KeyGenerated(){} // RVA: 0x7FFE867590C0
    }

    public class KeyBuilder : Object
    {
        public System.Security.Cryptography.RandomNumberGenerator rng;

        // ── Methods ──
        public void get_Rng(){} // RVA: 0x7FFE8671D420
        public void Key(){} // RVA: 0x7FFE8671D4E0
    }

    public class KeyPairPersistence : Object
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
        public void .ctor(){} // RVA: 0x7FFE8674B7D0 | overloaded x2
        public void get_Filename(){} // RVA: 0x7FFE8674B8F0
        public void get_KeyValue(){} // RVA: 0x7FFE810FE7C0
        public void set_KeyValue(){} // RVA: 0x7FFE8674BBF0
        public void get_Parameters(){} // RVA: 0x7FFE8674BC50
        public void Load(){} // RVA: 0x7FFE8674BC60
        public void Save(){} // RVA: 0x7FFE8674BE30
        public void Remove(){} // RVA: 0x7FFE8674C040
        public void get_UserPath(){} // RVA: 0x7FFE8674C130
        public void get_MachinePath(){} // RVA: 0x7FFE8674C7C0
        public void _CanSecure(){} // RVA: 0x7FFE810FB320
        public void _ProtectUser(){} // RVA: 0x7FFE810FB320
        public void _ProtectMachine(){} // RVA: 0x7FFE810FB320
        public void _IsUserProtected(){} // RVA: 0x7FFE810FB320
        public void _IsMachineProtected(){} // RVA: 0x7FFE810FB320
        public void CanSecure(){} // RVA: 0x7FFE8674CE50
        public void ProtectUser(){} // RVA: 0x7FFE8674CEC0
        public void ProtectMachine(){} // RVA: 0x7FFE8674CF40
        public void IsUserProtected(){} // RVA: 0x7FFE8674CFC0
        public void IsMachineProtected(){} // RVA: 0x7FFE8674D040
        public void get_CanChange(){} // RVA: 0x7FFE83BA1AA0
        public void get_UseDefaultKeyContainer(){} // RVA: 0x7FFE8674D0C0
        public void get_UseMachineKeyStore(){} // RVA: 0x7FFE8674D0E0
        public void get_ContainerName(){} // RVA: 0x7FFE8674D100
        public void Copy(){} // RVA: 0x7FFE8674D440
        public void FromXml(){} // RVA: 0x7FFE8674D500
        public void ToXml(){} // RVA: 0x7FFE8674D940
        public void .cctor(){} // RVA: 0x7FFE8674DBD0
    }

    public class MD2 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8671D600
        public void Create(){} // RVA: 0x7FFE8671D610
    }

    public class MD2Managed : MD2
    {
        // ── Methods ──
        public void Padding(){} // RVA: 0x7FFE8671D660
        public void .ctor(){} // RVA: 0x7FFE8671D6E0
        public void Initialize(){} // RVA: 0x7FFE8671D8C0
        public void HashCore(){} // RVA: 0x7FFE8671D930
        public void HashFinal(){} // RVA: 0x7FFE8671DA30
        public void MD2Transform(){} // RVA: 0x7FFE8671DB90
        public void .cctor(){} // RVA: 0x7FFE8671E1D0
    }

    public class MD4 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8671D600
        public void Create(){} // RVA: 0x7FFE8671E2B0
    }

    public class MD4Managed : MD4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8671E300
        public void Initialize(){} // RVA: 0x7FFE8671E550
        public void HashCore(){} // RVA: 0x7FFE8671E620
        public void HashFinal(){} // RVA: 0x7FFE8671E7B0
        public void Padding(){} // RVA: 0x7FFE8671EAB0
        public void F(){} // RVA: 0x7FFE8671EB20
        public void G(){} // RVA: 0x7FFE8671EB30
        public void H(){} // RVA: 0x7FFE8671EB40
        public void ROL(){} // RVA: 0x7FFE8671EB50
        public void FF(){} // RVA: 0x7FFE8671EB70
        public void GG(){} // RVA: 0x7FFE8671EBB0
        public void HH(){} // RVA: 0x7FFE8671EC00
        public void Encode(){} // RVA: 0x7FFE8671EC40
        public void Decode(){} // RVA: 0x7FFE8671ED10
        public void MD4Transform(){} // RVA: 0x7FFE8671EDC0
    }

    public class PKCS1 : Object
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFE8671F800
        public void I2OSP(){} // RVA: 0x7FFE8671F890
        public void OS2IP(){} // RVA: 0x7FFE8671F920
        public void RSAVP1(){} // RVA: 0x7FFE8671F9F0
        public void Verify_v15(){} // RVA: 0x7FFE8671FA20
        public void Encode_v15(){} // RVA: 0x7FFE8671FD90
        public void HashNameFromOid(){} // RVA: 0x7FFE86720200
        public void CreateFromOid(){} // RVA: 0x7FFE86720750
        public void CreateFromName(){} // RVA: 0x7FFE867207B0
        public void .cctor(){} // RVA: 0x7FFE86720CF0
    }

    public class PKCS8 : Object
    {
    }

    public class RC4 : SymmetricAlgorithm
    {
        public System.Security.Cryptography.KeySizes[] s_legalBlockSizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867236A0
        public void get_IV(){} // RVA: 0x7FFE867237D0
        public void set_IV(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE86723810
        public void .cctor(){} // RVA: 0x7FFE86723860
    }

    public class RSAManaged : RSA
    {
        public bool isCRTpossible; // 0x20
        public bool keyBlinding; // 0x21
        public bool keypairGenerated; // 0x22
        public bool m_disposed; // 0x23

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86723C40 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE865ED780
        public void GenerateKeyPair(){} // RVA: 0x7FFE86723DB0
        public void get_KeySize(){} // RVA: 0x7FFE86724590
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7FFE86724640
        public void get_PublicOnly(){} // RVA: 0x7FFE86724680
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFE86724720
        public void DecryptValue(){} // RVA: 0x7FFE86724760
        public void EncryptValue(){} // RVA: 0x7FFE86724C00
        public void ExportParameters(){} // RVA: 0x7FFE86724DA0
        public void ImportParameters(){} // RVA: 0x7FFE86725270
        public void Dispose(){} // RVA: 0x7FFE86725A30
        public void ToXmlString(){} // RVA: 0x7FFE86725FC0
        public void GetPaddedValue(){} // RVA: 0x7FFE86726840
    }

    public class SymmetricTransform : Object
    {
        public System.Security.Cryptography.SymmetricAlgorithm algo; // 0x10
        public bool encrypt; // 0x18
        public int BlockSizeByte; // 0x1C
        public byte[] temp; // 0x20
        public byte[] temp2; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867547C0
        public void Finalize(){} // RVA: 0x7FFE86754C20
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFE86754C70
        public void Dispose(){} // RVA: 0x7FFE86754CE0
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7FFE811E0850
        public void get_CanReuseTransform(){} // RVA: 0x7FFE810FB320
        public void get_InputBlockSize(){} // RVA: 0x7FFE82707EE0
        public void get_OutputBlockSize(){} // RVA: 0x7FFE82707EE0
        public void Transform(){} // RVA: 0x7FFE86754DE0
        public void ECB(){} // RVA: 0x7FFE80E4F230
        public void CBC(){} // RVA: 0x7FFE86754F60
        public void CFB(){} // RVA: 0x7FFE867550A0
        public void OFB(){} // RVA: 0x7FFE86755520
        public void CTS(){} // RVA: 0x7FFE86755570
        public void CheckInput(){} // RVA: 0x7FFE867555C0
        public void TransformBlock(){} // RVA: 0x7FFE86755760
        public void get_KeepLastBlock(){} // RVA: 0x7FFE86755A80
        public void InternalTransformBlock(){} // RVA: 0x7FFE86755AA0
        public void Random(){} // RVA: 0x7FFE86755C90
        public void ThrowBadPaddingException(){} // RVA: 0x7FFE86755DA0
        public void FinalEncrypt(){} // RVA: 0x7FFE86755F00
        public void FinalDecrypt(){} // RVA: 0x7FFE86756290
        public void TransformFinalBlock(){} // RVA: 0x7FFE867565B0
    }

}