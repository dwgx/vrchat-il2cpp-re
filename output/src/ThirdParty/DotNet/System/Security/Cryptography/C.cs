// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 9
// Methods: 84

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class CryptoAPITransform : Object
    {
        public object m_disposed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF48510
        public void get_CanReuseTransform(){} // RVA: 0xC2E4C0
        public void get_CanTransformMultipleBlocks(){} // RVA: 0xC2E4C0
        public void get_InputBlockSize(){} // RVA: 0xDAC980
        public void get_KeyHandle(){} // RVA: 0xDAC980
        public void get_OutputBlockSize(){} // RVA: 0xDAC980
        public void Dispose(){} // RVA: 0x6719860
        public void Clear(){} // RVA: 0x6719860
        public void TransformBlock(){} // RVA: 0xDAC980
        public void TransformFinalBlock(){} // RVA: 0xDAC980
        public void Reset(){} // RVA: 0xB43310
    }

    public class CryptoConfig : Object
    {
        public object lockObject;
        public object algorithms;

        // ── Methods ──
        public void AddOID(){} // RVA: 0x6719870
        public void CreateFromName(){} // RVA: 0x6719910
        public void MapNameToOID(){} // RVA: 0x671C490
        public void Initialize(){} // RVA: 0x671CF20
        public void AddAlgorithm(){} // RVA: 0x671D090
        public void EncodeOID(){} // RVA: 0x671D6A0
        public void EncodeLongNumber(){} // RVA: 0x671DBE0
        public void get_AllowOnlyFipsAlgorithms(){} // RVA: 0xB43320
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x671DD90
    }

    public class CryptoConfigForwarder : Object
    {
        // ── Methods ──
        public void CreateFromName(){} // RVA: 0x67283C0
        public void CreateDefaultHashAlgorithm(){} // RVA: 0x66EBBB0
    }

    public class CryptoStream : Stream
    {
        public object _stream;
        public object _transform;
        public object _transformMode;
        public object _inputBuffer;
        public object _inputBufferIndex;
        public object _inputBlockSize;
        public object _outputBuffer;
        public object _outputBufferIndex;
        public object _outputBlockSize;
        public object _canRead;
        public object _canWrite;
        public object _finalBlockTransformed;
        public object _lazyAsyncActiveSemaphore;
        public object _leaveOpen;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66E5CA0
        public void get_CanRead(){} // RVA: 0xB6B1A0
        public void get_CanSeek(){} // RVA: 0xB43320
        public void get_CanWrite(){} // RVA: 0x1A1E0A0
        public void get_Length(){} // RVA: 0x66E60C0
        public void get_Position(){} // RVA: 0x66E6110
        public void set_Position(){} // RVA: 0x66E6160
        public void get_HasFlushedFinalBlock(){} // RVA: 0xB76DA0
        public void FlushFinalBlock(){} // RVA: 0x66E61B0
        public void Flush(){} // RVA: 0xB43310
        public void FlushAsync(){} // RVA: 0x66E63B0
        public void Seek(){} // RVA: 0x66E6530
        public void SetLength(){} // RVA: 0x66E6580
        public void ReadAsync(){} // RVA: 0x66E65D0
        public void BeginRead(){} // RVA: 0x66E6630
        public void EndRead(){} // RVA: 0x66E66E0
        public void ReadAsyncInternal(){} // RVA: 0x66E6720
        public void ReadByte(){} // RVA: 0x66E69A0
        public void WriteByte(){} // RVA: 0x66E6BF0
        public void Read(){} // RVA: 0x66E6CC0
        public void CheckReadArguments(){} // RVA: 0x66E6E00
        public void ReadAsyncCore(){} // RVA: 0x66E6FB0
        public void WriteAsync(){} // RVA: 0x66E7230
        public void BeginWrite(){} // RVA: 0x66E7290
        public void EndWrite(){} // RVA: 0x66E7340
        public void WriteAsyncInternal(){} // RVA: 0x66E7350
        public void Write(){} // RVA: 0x66E75F0
        public void CheckWriteArguments(){} // RVA: 0x66E76E0
        public void WriteAsyncCore(){} // RVA: 0x66E7890
        public void Clear(){} // RVA: 0x66E7B30
        public void Dispose(){} // RVA: 0x66E7B50
        public void InitializeBuffer(){} // RVA: 0x66E7D60
        public void get_AsyncActiveSemaphore(){} // RVA: 0x66E7EC0
    }

    public class CryptographicException : SystemException
    {
        public object FORMAT_MESSAGE_IGNORE_INSERTS;
        public object FORMAT_MESSAGE_FROM_SYSTEM;
        public object FORMAT_MESSAGE_ARGUMENT_ARRAY;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
        public void ThrowCryptographicException(){} // RVA: 0x66F07B0
    }

    public class CryptographicOperations : Object
    {
        // ── Methods ──
        public void FixedTimeEquals(){} // RVA: 0x66EB9A0
        public void ZeroMemory(){} // RVA: 0x66EBB60
    }

    public class CryptographicUnexpectedOperationException : CryptographicException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class CspKeyContainerInfo : Object
    {
        public object _params;
        public object _random;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x12306B0
        public void get_Accessible(){} // RVA: 0xC2E4C0
        public void get_CryptoKeySecurity(){} // RVA: 0xDAC980
        public void get_Exportable(){} // RVA: 0xC2E4C0
        public void get_HardwareDevice(){} // RVA: 0xB43320
        public void get_KeyContainerName(){} // RVA: 0x13F92B0
        public void get_KeyNumber(){} // RVA: 0x671DE40
        public void get_MachineKeyStore(){} // RVA: 0xB43320
        public void get_Protected(){} // RVA: 0xB43320
        public void get_ProviderName(){} // RVA: 0x13F9400
        public void get_ProviderType(){} // RVA: 0x66B3620
        public void get_RandomlyGenerated(){} // RVA: 0xB5DD50
        public void get_Removable(){} // RVA: 0xB43320
        public void get_UniqueKeyContainerName(){} // RVA: 0x671DE60
    }

    public class CspParameters : Object
    {
        public object ProviderType;
        public object ProviderName;
        public object KeyContainerName;
        public object KeyNumber;
        public object m_flags;
        public object m_cryptoKeySecurity;
        public object m_keyPassword;
        public object m_parentWindowHandle;

        // ── Methods ──
        public void get_Flags(){} // RVA: 0x1AE5AC0
        public void set_Flags(){} // RVA: 0x66F09A0
        public void get_CryptoKeySecurity(){} // RVA: 0xD33E60
        public void set_CryptoKeySecurity(){} // RVA: 0xB708C0
        public void get_KeyPassword(){} // RVA: 0xD05CA0
        public void set_KeyPassword(){} // RVA: 0x66F0A80
        public void get_ParentWindowHandle(){} // RVA: 0xBC1B30
        public void set_ParentWindowHandle(){} // RVA: 0x66F0AF0
        public void .ctor(){} // RVA: 0x66F0E90
    }

}