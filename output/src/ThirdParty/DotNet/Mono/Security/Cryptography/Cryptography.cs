// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Cryptography
// Classes: 14
// Methods: 156

namespace ThirdParty.DotNet.Mono.Security.Cryptography
{
    public class ARC4Managed : RC4
    {
        public byte[] Key; // 0x48
        public byte[] CanReuseTransform; // 0x50
        public byte CanTransformMultipleBlocks; // 0x58
        public byte InputBlockSize; // 0x59
        public bool OutputBlockSize; // 0x5A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8371660
        public void Finalize(){} // RVA: 0x7FFAC8371850
        public void Dispose(){} // RVA: 0x7FFAC83718A0
        public void get_Key(){} // RVA: 0x7FFAC8371A00
        public void set_Key(){} // RVA: 0x7FFAC8371AA0
        public void get_CanReuseTransform(){} // RVA: 0x7FFAC2F21320
        public void CreateEncryptor(){} // RVA: 0x7FFAC8371D20
        public void CreateDecryptor(){} // RVA: 0x7FFAC8371D50
        public void GenerateIV(){} // RVA: 0x7FFAC8371D90
        public void GenerateKey(){} // RVA: 0x7FFAC8371DF0
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7FFAC3006850
        public void get_InputBlockSize(){} // RVA: 0x7FFAC3013AF0
        public void get_OutputBlockSize(){} // RVA: 0x7FFAC3013AF0
        public void KeySetup(){} // RVA: 0x7FFAC8371F80
        public void CheckInput(){} // RVA: 0x7FFAC8372090
        public void TransformBlock(){} // RVA: 0x7FFAC8372230
        public void InternalTransformBlock(){} // RVA: 0x7FFAC83723C0
        public void TransformFinalBlock(){} // RVA: 0x7FFAC8372530
    }

    public class CryptoConvert : Object
    {
        // ── Methods ──
        public void ToInt32LE(){} // RVA: 0x7FFAC83725F0
        public void ToUInt32LE(){} // RVA: 0x7FFAC83725F0
        public void Trim(){} // RVA: 0x7FFAC8372670
        public void FromCapiPrivateKeyBlob(){} // RVA: 0x7FFAC8372750 | overloaded x2
        public void GetParametersFromCapiPrivateKeyBlob(){} // RVA: 0x7FFAC8372980
        public void ToHex(){} // RVA: 0x7FFAC83735F0
        public void FromHexChar(){} // RVA: 0x7FFAC8373830
        public void FromHex(){} // RVA: 0x7FFAC83738C0
    }

    public class DSAManaged : DSA
    {
        public bool Random; // 0x20
        public bool KeySize; // 0x21
        public Mono.Math.BigInteger KeyExchangeAlgorithm; // 0x28
        public Mono.Math.BigInteger PublicOnly; // 0x30
        public Mono.Math.BigInteger SignatureAlgorithm; // 0x38
        public Mono.Math.BigInteger x; // 0x40
        public Mono.Math.BigInteger y; // 0x48
        public Mono.Math.BigInteger j; // 0x50
        public Mono.Math.BigInteger seed; // 0x58
        public int counter; // 0x60
        public bool j_missing; // 0x64
        public System.Security.Cryptography.RandomNumberGenerator rng; // 0x68
        public KeyGeneratedEventHandler KeyGenerated; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83ACD80
        public void Finalize(){} // RVA: 0x7FFAC8243E40
        public void Generate(){} // RVA: 0x7FFAC83ACEC0
        public void GenerateKeyPair(){} // RVA: 0x7FFAC83ACF10
        public void add(){} // RVA: 0x7FFAC83AD200
        public void GenerateParams(){} // RVA: 0x7FFAC83AD280
        public void get_Random(){} // RVA: 0x7FFAC83ADE30
        public void get_KeySize(){} // RVA: 0x7FFAC83ADEB0
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7FFAC34F9180
        public void get_PublicOnly(){} // RVA: 0x7FFAC83ADEE0
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAC83ADF50
        public void NormalizeArray(){} // RVA: 0x7FFAC83ADF90
        public void ExportParameters(){} // RVA: 0x7FFAC83AE050
        public void ImportParameters(){} // RVA: 0x7FFAC83AE590
        public void CreateSignature(){} // RVA: 0x7FFAC83AE9C0
        public void VerifySignature(){} // RVA: 0x7FFAC83AEE00
        public void Dispose(){} // RVA: 0x7FFAC83AF3E0
        public void add_KeyGenerated(){} // RVA: 0x7FFAC83AF6D0
        public void remove_KeyGenerated(){} // RVA: 0x7FFAC83AF7C0
    }

    public class KeyBuilder : Object
    {
        public System.Security.Cryptography.RandomNumberGenerator Rng;

        // ── Methods ──
        public void get_Rng(){} // RVA: 0x7FFAC8373B20
        public void Key(){} // RVA: 0x7FFAC8373BE0
    }

    public class KeyPairPersistence : Object
    {
        public bool Filename;
        public string KeyValue; // 0x8
        public bool Parameters; // 0x10
        public string UserPath; // 0x18
        public System.Security.Cryptography.CspParameters MachinePath; // 0x10
        public string CanChange; // 0x18
        public string UseDefaultKeyContainer; // 0x20
        public string UseMachineKeyStore; // 0x28
        public object ContainerName; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83A1ED0 | overloaded x2
        public void get_Filename(){} // RVA: 0x7FFAC83A1FF0
        public void get_KeyValue(){} // RVA: 0x7FFAC2F247C0
        public void set_KeyValue(){} // RVA: 0x7FFAC83A22F0
        public void get_Parameters(){} // RVA: 0x7FFAC83A2350
        public void Load(){} // RVA: 0x7FFAC83A2360
        public void Save(){} // RVA: 0x7FFAC83A2530
        public void Remove(){} // RVA: 0x7FFAC83A2740
        public void get_UserPath(){} // RVA: 0x7FFAC83A2830
        public void get_MachinePath(){} // RVA: 0x7FFAC83A2EC0
        public void _CanSecure(){} // RVA: 0x7FFAC2F21320
        public void _ProtectUser(){} // RVA: 0x7FFAC2F21320
        public void _ProtectMachine(){} // RVA: 0x7FFAC2F21320
        public void _IsUserProtected(){} // RVA: 0x7FFAC2F21320
        public void _IsMachineProtected(){} // RVA: 0x7FFAC2F21320
        public void CanSecure(){} // RVA: 0x7FFAC83A3550
        public void ProtectUser(){} // RVA: 0x7FFAC83A35C0
        public void ProtectMachine(){} // RVA: 0x7FFAC83A3640
        public void IsUserProtected(){} // RVA: 0x7FFAC83A36C0
        public void IsMachineProtected(){} // RVA: 0x7FFAC83A3740
        public void get_CanChange(){} // RVA: 0x7FFAC58650E0
        public void get_UseDefaultKeyContainer(){} // RVA: 0x7FFAC83A37C0
        public void get_UseMachineKeyStore(){} // RVA: 0x7FFAC83A37E0
        public void get_ContainerName(){} // RVA: 0x7FFAC83A3800
        public void Copy(){} // RVA: 0x7FFAC83A3B40
        public void FromXml(){} // RVA: 0x7FFAC83A3C00
        public void ToXml(){} // RVA: 0x7FFAC83A4040
        public void .cctor(){} // RVA: 0x7FFAC83A42D0
    }

    public class MD2 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8373D00
        public void Create(){} // RVA: 0x7FFAC8373D10
    }

    public class MD2Managed : MD2
    {
        public byte[] state; // 0x28
        public byte[] checksum; // 0x30
        public byte[] buffer; // 0x38
        public int count; // 0x40
        public byte[] x; // 0x48
        public byte[] PI_SUBST;

        // ── Methods ──
        public void Padding(){} // RVA: 0x7FFAC8373D60
        public void .ctor(){} // RVA: 0x7FFAC8373DE0
        public void Initialize(){} // RVA: 0x7FFAC8373FC0
        public void HashCore(){} // RVA: 0x7FFAC8374030
        public void HashFinal(){} // RVA: 0x7FFAC8374130
        public void MD2Transform(){} // RVA: 0x7FFAC8374290
        public void .cctor(){} // RVA: 0x7FFAC83748D0
    }

    public class MD4 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8373D00
        public void Create(){} // RVA: 0x7FFAC83749B0
    }

    public class MD4Managed : MD4
    {
        public uint[] state; // 0x28
        public byte[] buffer; // 0x30
        public uint[] count; // 0x38
        public uint[] x; // 0x40
        public byte[] digest; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8374A00
        public void Initialize(){} // RVA: 0x7FFAC8374C50
        public void HashCore(){} // RVA: 0x7FFAC8374D20
        public void HashFinal(){} // RVA: 0x7FFAC8374EB0
        public void Padding(){} // RVA: 0x7FFAC83751B0
        public void F(){} // RVA: 0x7FFAC8375220
        public void G(){} // RVA: 0x7FFAC8375230
        public void H(){} // RVA: 0x7FFAC8375240
        public void ROL(){} // RVA: 0x7FFAC8375250
        public void FF(){} // RVA: 0x7FFAC8375270
        public void GG(){} // RVA: 0x7FFAC83752B0
        public void HH(){} // RVA: 0x7FFAC8375300
        public void Encode(){} // RVA: 0x7FFAC8375340
        public void Decode(){} // RVA: 0x7FFAC8375410
        public void MD4Transform(){} // RVA: 0x7FFAC83754C0
    }

    public class PKCS1 : Object
    {
        public byte[] emptySHA1;
        public byte[] emptySHA256; // 0x8
        public byte[] emptySHA384; // 0x10
        public byte[] emptySHA512; // 0x18

        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFAC8375F00
        public void I2OSP(){} // RVA: 0x7FFAC8375F90
        public void OS2IP(){} // RVA: 0x7FFAC8376020
        public void RSAVP1(){} // RVA: 0x7FFAC83760F0
        public void Verify_v15(){} // RVA: 0x7FFAC8376120
        public void Encode_v15(){} // RVA: 0x7FFAC8376490
        public void HashNameFromOid(){} // RVA: 0x7FFAC8376900
        public void CreateFromOid(){} // RVA: 0x7FFAC8376E50
        public void CreateFromName(){} // RVA: 0x7FFAC8376EB0
        public void .cctor(){} // RVA: 0x7FFAC83773F0
    }

    public class PKCS8 : Object
    {
    }

    public class RC4 : SymmetricAlgorithm
    {
        public System.Security.Cryptography.KeySizes[] IV;
        public System.Security.Cryptography.KeySizes[] s_legalKeySizes; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8379DA0
        public void get_IV(){} // RVA: 0x7FFAC8379ED0
        public void set_IV(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8379F10
        public void .cctor(){} // RVA: 0x7FFAC8379F60
    }

    public class RSAManaged : RSA
    {
        public bool KeySize; // 0x20
        public bool KeyExchangeAlgorithm; // 0x21
        public bool PublicOnly; // 0x22
        public bool SignatureAlgorithm; // 0x23
        public Mono.Math.BigInteger d; // 0x28
        public Mono.Math.BigInteger p; // 0x30
        public Mono.Math.BigInteger q; // 0x38
        public Mono.Math.BigInteger dp; // 0x40
        public Mono.Math.BigInteger dq; // 0x48
        public Mono.Math.BigInteger qInv; // 0x50
        public Mono.Math.BigInteger n; // 0x58
        public Mono.Math.BigInteger e; // 0x60
        public KeyGeneratedEventHandler KeyGenerated; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC837A340 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8243E40
        public void GenerateKeyPair(){} // RVA: 0x7FFAC837A4B0
        public void get_KeySize(){} // RVA: 0x7FFAC837AC90
        public void get_KeyExchangeAlgorithm(){} // RVA: 0x7FFAC837AD40
        public void get_PublicOnly(){} // RVA: 0x7FFAC837AD80
        public void get_SignatureAlgorithm(){} // RVA: 0x7FFAC837AE20
        public void DecryptValue(){} // RVA: 0x7FFAC837AE60
        public void EncryptValue(){} // RVA: 0x7FFAC837B300
        public void ExportParameters(){} // RVA: 0x7FFAC837B4A0
        public void ImportParameters(){} // RVA: 0x7FFAC837B970
        public void Dispose(){} // RVA: 0x7FFAC837C130
        public void ToXmlString(){} // RVA: 0x7FFAC837C6C0
        public void GetPaddedValue(){} // RVA: 0x7FFAC837CF40
    }

    public class SymmetricTransform : Object
    {
        public System.Security.Cryptography.SymmetricAlgorithm CanTransformMultipleBlocks; // 0x10
        public bool CanReuseTransform; // 0x18
        public int InputBlockSize; // 0x1C
        public byte[] OutputBlockSize; // 0x20
        public byte[] KeepLastBlock; // 0x28
        public byte[] workBuff; // 0x30
        public byte[] workout; // 0x38
        public 0x6B0CC180 padmode; // 0x40
        public int FeedBackByte; // 0x44
        public bool m_disposed; // 0x48
        public bool lastBlock; // 0x49
        public System.Security.Cryptography.RandomNumberGenerator _rng; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83AAEC0
        public void Finalize(){} // RVA: 0x7FFAC83AB320
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC83AB370
        public void Dispose(){} // RVA: 0x7FFAC83AB3E0
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7FFAC3006850
        public void get_CanReuseTransform(){} // RVA: 0x7FFAC2F21320
        public void get_InputBlockSize(){} // RVA: 0x7FFAC44357F0
        public void get_OutputBlockSize(){} // RVA: 0x7FFAC44357F0
        public void Transform(){} // RVA: 0x7FFAC83AB4E0
        public void ECB(){} // RVA: 0x7FFAC2C79B30
        public void CBC(){} // RVA: 0x7FFAC83AB660
        public void CFB(){} // RVA: 0x7FFAC83AB7A0
        public void OFB(){} // RVA: 0x7FFAC83ABC20
        public void CTS(){} // RVA: 0x7FFAC83ABC70
        public void CheckInput(){} // RVA: 0x7FFAC83ABCC0
        public void TransformBlock(){} // RVA: 0x7FFAC83ABE60
        public void get_KeepLastBlock(){} // RVA: 0x7FFAC83AC180
        public void InternalTransformBlock(){} // RVA: 0x7FFAC83AC1A0
        public void Random(){} // RVA: 0x7FFAC83AC390
        public void ThrowBadPaddingException(){} // RVA: 0x7FFAC83AC4A0
        public void FinalEncrypt(){} // RVA: 0x7FFAC83AC600
        public void FinalDecrypt(){} // RVA: 0x7FFAC83AC990
        public void TransformFinalBlock(){} // RVA: 0x7FFAC83ACCB0
    }

}