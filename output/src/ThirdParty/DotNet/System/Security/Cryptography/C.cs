// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 10
// Methods: 104

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class Constants : Object
    {
        public int S_OK;
        public int NTE_FILENOTFOUND;
        public int NTE_NO_KEY;
        public int NTE_BAD_KEYSET;
        public int NTE_KEYSET_NOT_DEF;
        public int KP_IV;
        public int KP_MODE;
        public int KP_MODE_BITS;
        public int KP_EFFECTIVE_KEYLEN;
        public int ALG_CLASS_SIGNATURE;
        public int ALG_CLASS_DATA_ENCRYPT;
        public int ALG_CLASS_HASH;
        public int ALG_CLASS_KEY_EXCHANGE;
        public int ALG_TYPE_DSS;
        public int ALG_TYPE_RSA;
        public int ALG_TYPE_BLOCK;
        public int ALG_TYPE_STREAM;
        public int ALG_TYPE_ANY;
        public int CALG_MD5;
        public int CALG_SHA1;
        public int CALG_SHA_256;
        public int CALG_SHA_384;
        public int CALG_SHA_512;
        public int CALG_RSA_KEYX;
        public int CALG_RSA_SIGN;
        public int CALG_DSS_SIGN;
        public int CALG_DES;
        public int CALG_RC2;
        public int CALG_3DES;
        public int CALG_3DES_112;
        public int CALG_AES_128;
        public int CALG_AES_192;
        public int CALG_AES_256;
        public int CALG_RC4;
        public int PROV_RSA_FULL;
        public int PROV_DSS_DH;
        public int PROV_RSA_AES;
        public int AT_KEYEXCHANGE;
        public int AT_SIGNATURE;
        public int PUBLICKEYBLOB;
        public int PRIVATEKEYBLOB;
        public int CRYPT_OAEP;
        public uint CRYPT_VERIFYCONTEXT;
        public uint CRYPT_NEWKEYSET;
        public uint CRYPT_DELETEKEYSET;
        public uint CRYPT_MACHINE_KEYSET;
        public uint CRYPT_SILENT;
        public uint CRYPT_EXPORTABLE;
        public uint CLR_KEYLEN;
        public uint CLR_PUBLICKEYONLY;
        public uint CLR_EXPORTABLE;
        public uint CLR_REMOVABLE;
        public uint CLR_HARDWARE;
        public uint CLR_ACCESSIBLE;
        public uint CLR_PROTECTED;
        public uint CLR_UNIQUE_CONTAINER;
        public uint CLR_ALGID;
        public uint CLR_PP_CLIENT_HWND;
        public uint CLR_PP_PIN;
        public string OID_RSA_SMIMEalgCMS3DESwrap;
        public string OID_RSA_MD5;
        public string OID_RSA_RC2CBC;
        public string OID_RSA_DES_EDE3_CBC;
        public string OID_OIWSEC_desCBC;
        public string OID_OIWSEC_SHA1;
        public string OID_OIWSEC_SHA256;
        public string OID_OIWSEC_SHA384;
        public string OID_OIWSEC_SHA512;
        public string OID_OIWSEC_RIPEMD160;
    }

    public class CryptoAPITransform : Object
    {
        public bool CanReuseTransform; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC322C880
        public void get_CanReuseTransform(){} // RVA: 0x7FFAC3006850
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7FFAC3006850
        public void get_InputBlockSize(){} // RVA: 0x7FFAC34F9180
        public void get_KeyHandle(){} // RVA: 0x7FFAC34F9180
        public void get_OutputBlockSize(){} // RVA: 0x7FFAC34F9180
        public void Dispose(){} // RVA: 0x7FFAC8438240 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAC8438240
        public void TransformBlock(){} // RVA: 0x7FFAC34F9180
        public void TransformFinalBlock(){} // RVA: 0x7FFAC34F9180
        public void Reset(){} // RVA: 0x7FFAC2F21310
    }

    public class CryptoConfig : Object
    {
        public object AllowOnlyFipsAlgorithms;
        public System.Collections.Generic.Dictionary`2<string,System.Type> algorithms; // 0x8

        // ── Methods ──
        public void AddOID(){} // RVA: 0x7FFAC8438250
        public void CreateFromName(){} // RVA: 0x7FFAC84382F0 | overloaded x2
        public void MapNameToOID(){} // RVA: 0x7FFAC843ADF0 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFAC843B880
        public void AddAlgorithm(){} // RVA: 0x7FFAC843B9F0
        public void EncodeOID(){} // RVA: 0x7FFAC843C040
        public void EncodeLongNumber(){} // RVA: 0x7FFAC843C570
        public void get_AllowOnlyFipsAlgorithms(){} // RVA: 0x7FFAC2F21320
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC843C710
    }

    public class CryptoConfigForwarder : Object
    {
        // ── Methods ──
        public void CreateFromName(){} // RVA: 0x7FFAC8447010
        public void CreateDefaultHashAlgorithm(){} // RVA: 0x7FFAC840AB40
    }

    public class CryptoStream : Stream
    {
        public System.IO.Stream CanRead; // 0x28
        public System.Security.Cryptography.ICryptoTransform CanSeek; // 0x30
        public 0x6B0CBB50 CanWrite; // 0x38
        public byte[] Length; // 0x40
        public int Position; // 0x48
        public int HasFlushedFinalBlock; // 0x4C
        public byte[] AsyncActiveSemaphore; // 0x50
        public int _outputBufferIndex; // 0x58
        public int _outputBlockSize; // 0x5C
        public bool _canRead; // 0x60
        public bool _canWrite; // 0x61
        public bool _finalBlockTransformed; // 0x62
        public System.Threading.SemaphoreSlim _lazyAsyncActiveSemaphore; // 0x68
        public bool _leaveOpen; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8404BD0 | overloaded x2
        public void get_CanRead(){} // RVA: 0x7FFAC2F4A020
        public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
        public void get_CanWrite(){} // RVA: 0x7FFAC3C11000
        public void get_Length(){} // RVA: 0x7FFAC8404FD0
        public void get_Position(){} // RVA: 0x7FFAC8405020
        public void set_Position(){} // RVA: 0x7FFAC8405070
        public void get_HasFlushedFinalBlock(){} // RVA: 0x7FFAC2F55E50
        public void FlushFinalBlock(){} // RVA: 0x7FFAC84050C0
        public void Flush(){} // RVA: 0x7FFAC2F21310
        public void FlushAsync(){} // RVA: 0x7FFAC84052D0
        public void Seek(){} // RVA: 0x7FFAC8405490
        public void SetLength(){} // RVA: 0x7FFAC84054E0
        public void ReadAsync(){} // RVA: 0x7FFAC8405530
        public void BeginRead(){} // RVA: 0x7FFAC8405590
        public void EndRead(){} // RVA: 0x7FFAC8405640
        public void ReadAsyncInternal(){} // RVA: 0x7FFAC8405680
        public void ReadByte(){} // RVA: 0x7FFAC8405900
        public void WriteByte(){} // RVA: 0x7FFAC8405B50
        public void Read(){} // RVA: 0x7FFAC8405C20
        public void CheckReadArguments(){} // RVA: 0x7FFAC8405D70
        public void ReadAsyncCore(){} // RVA: 0x7FFAC8405F20
        public void WriteAsync(){} // RVA: 0x7FFAC8406190
        public void BeginWrite(){} // RVA: 0x7FFAC84061F0
        public void EndWrite(){} // RVA: 0x7FFAC84062A0
        public void WriteAsyncInternal(){} // RVA: 0x7FFAC84062B0
        public void Write(){} // RVA: 0x7FFAC8406550
        public void CheckWriteArguments(){} // RVA: 0x7FFAC8406640
        public void WriteAsyncCore(){} // RVA: 0x7FFAC84067F0
        public void Clear(){} // RVA: 0x7FFAC8406A90
        public void Dispose(){} // RVA: 0x7FFAC8406AB0
        public void InitializeBuffer(){} // RVA: 0x7FFAC8406CD0
        public void get_AsyncActiveSemaphore(){} // RVA: 0x7FFAC8406E30
    }

    public class CryptographicException : SystemException
    {
        public int FORMAT_MESSAGE_IGNORE_INSERTS;
        public int FORMAT_MESSAGE_FROM_SYSTEM;
        public int FORMAT_MESSAGE_ARGUMENT_ARRAY;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x6
        public void ThrowCryptographicException(){} // RVA: 0x7FFAC840F710
    }

    public class CryptographicOperations : Object
    {
        // ── Methods ──
        public void FixedTimeEquals(){} // RVA: 0x7FFAC840A930
        public void ZeroMemory(){} // RVA: 0x7FFAC840AAF0
    }

    public class CryptographicUnexpectedOperationException : CryptographicException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x5
    }

    public class CspKeyContainerInfo : Object
    {
        public System.Security.Cryptography.CspParameters Accessible; // 0x10
        public bool CryptoKeySecurity; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC843C7C0
        public void get_Accessible(){} // RVA: 0x7FFAC3006850
        public void get_CryptoKeySecurity(){} // RVA: 0x7FFAC34F9180
        public void get_Exportable(){} // RVA: 0x7FFAC3006850
        public void get_HardwareDevice(){} // RVA: 0x7FFAC2F21320
        public void get_KeyContainerName(){} // RVA: 0x7FFAC37735E0
        public void get_KeyNumber(){} // RVA: 0x7FFAC843C820
        public void get_MachineKeyStore(){} // RVA: 0x7FFAC2F21320
        public void get_Protected(){} // RVA: 0x7FFAC2F21320
        public void get_ProviderName(){} // RVA: 0x7FFAC356B610
        public void get_ProviderType(){} // RVA: 0x7FFAC83D27B0
        public void get_RandomlyGenerated(){} // RVA: 0x7FFAC2F3C4E0
        public void get_Removable(){} // RVA: 0x7FFAC2F21320
        public void get_UniqueKeyContainerName(){} // RVA: 0x7FFAC843C840
    }

    public class CspParameters : Object
    {
        public int Flags; // 0x10
        public string CryptoKeySecurity; // 0x18
        public string KeyPassword; // 0x20
        public int ParentWindowHandle; // 0x28
        public int m_flags; // 0x2C
        public System.Security.AccessControl.CryptoKeySecurity m_cryptoKeySecurity; // 0x30
        public System.Security.SecureString m_keyPassword; // 0x38
        public UIntPtr m_parentWindowHandle; // 0x40

        // ── Methods ──
        public void get_Flags(){} // RVA: 0x7FFAC3C891D0
        public void set_Flags(){} // RVA: 0x7FFAC840F900
        public void get_CryptoKeySecurity(){} // RVA: 0x7FFAC31D95E0
        public void set_CryptoKeySecurity(){} // RVA: 0x7FFAC2F4F890
        public void get_KeyPassword(){} // RVA: 0x7FFAC31D0140
        public void set_KeyPassword(){} // RVA: 0x7FFAC840F9F0
        public void get_ParentWindowHandle(){} // RVA: 0x7FFAC2F9E740
        public void set_ParentWindowHandle(){} // RVA: 0x7FFAC840FA60
        public void .ctor(){} // RVA: 0x7FFAC840FE00 | overloaded x8
    }

}