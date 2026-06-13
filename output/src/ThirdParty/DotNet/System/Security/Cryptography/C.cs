// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 10
// Methods: 104

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class Constants
    {
    }

    public class CryptoAPITransform
    {
        public bool m_disposed; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BDA00
        public void get_CanReuseTransform(){} // RVA: 0x3C2850
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x3C2850
        public void get_InputBlockSize(){} // RVA: 0x519240
        public void get_KeyHandle(){} // RVA: 0x519240
        public void get_OutputBlockSize(){} // RVA: 0x519240
        public void Dispose(){} // RVA: 0x5CA0CB0 | overloaded x2
        public void Clear(){} // RVA: 0x5CA0CB0
        public void TransformBlock(){} // RVA: 0x519240
        public void TransformFinalBlock(){} // RVA: 0x519240
        public void Reset(){} // RVA: 0x2DD310
    }

    public class CryptoConfig
    {
        public object Accessible;

        // ── Methods ──
        public void AddOID(){} // RVA: 0x5CA0CC0
        public void CreateFromName(){} // RVA: 0x5CA0D60 | overloaded x2
        public void MapNameToOID(){} // RVA: 0x5CA3860 | overloaded x2
        public void Initialize(){} // RVA: 0x5CA42F0
        public void AddAlgorithm(){} // RVA: 0x5CA4460
        public void EncodeOID(){} // RVA: 0x5CA4AB0
        public void EncodeLongNumber(){} // RVA: 0x5CA4FE0
        public void get_AllowOnlyFipsAlgorithms(){} // RVA: 0x2DD320
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x5CA5180
    }

    public class CryptoConfigForwarder
    {
        // ── Methods ──
        public void CreateFromName(){} // RVA: 0x5CAFA20
        public void CreateDefaultHashAlgorithm(){} // RVA: 0x5C735B0
    }

    public class CryptoStream
    {
        public System.IO.Stream _stream; // 0x28
        public System.Security.Cryptography.ICryptoTransform _transform; // 0x30
        public 0x657E6AD0 _transformMode; // 0x38
        public byte[] _inputBuffer; // 0x40
        public int _inputBufferIndex; // 0x48
        public int _inputBlockSize; // 0x4C
        public byte[] _outputBuffer; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C6D640 | overloaded x2
        public void get_CanRead(){} // RVA: 0x306020
        public void get_CanSeek(){} // RVA: 0x2DD320
        public void get_CanWrite(){} // RVA: 0x115A230
        public void get_Length(){} // RVA: 0x5C6DA40
        public void get_Position(){} // RVA: 0x5C6DA90
        public void set_Position(){} // RVA: 0x5C6DAE0
        public void get_HasFlushedFinalBlock(){} // RVA: 0x311E50
        public void FlushFinalBlock(){} // RVA: 0x5C6DB30
        public void Flush(){} // RVA: 0x2DD310
        public void FlushAsync(){} // RVA: 0x5C6DD40
        public void Seek(){} // RVA: 0x5C6DF00
        public void SetLength(){} // RVA: 0x5C6DF50
        public void ReadAsync(){} // RVA: 0x5C6DFA0
        public void BeginRead(){} // RVA: 0x5C6E000
        public void EndRead(){} // RVA: 0x5C6E0B0
        public void ReadAsyncInternal(){} // RVA: 0x5C6E0F0
        public void ReadByte(){} // RVA: 0x5C6E370
        public void WriteByte(){} // RVA: 0x5C6E5C0
        public void Read(){} // RVA: 0x5C6E690
        public void CheckReadArguments(){} // RVA: 0x5C6E7E0
        public void ReadAsyncCore(){} // RVA: 0x5C6E990
        public void WriteAsync(){} // RVA: 0x5C6EC00
        public void BeginWrite(){} // RVA: 0x5C6EC60
        public void EndWrite(){} // RVA: 0x5C6ED10
        public void WriteAsyncInternal(){} // RVA: 0x5C6ED20
        public void Write(){} // RVA: 0x5C6EFC0
        public void CheckWriteArguments(){} // RVA: 0x5C6F0B0
        public void WriteAsyncCore(){} // RVA: 0x5C6F260
        public void Clear(){} // RVA: 0x5C6F500
        public void Dispose(){} // RVA: 0x5C6F520
        public void InitializeBuffer(){} // RVA: 0x5C6F740
        public void get_AsyncActiveSemaphore(){} // RVA: 0x5C6F8A0
    }

    public class CryptographicException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x6
        public void ThrowCryptographicException(){} // RVA: 0x5C78180
    }

    public class CryptographicOperations
    {
        // ── Methods ──
        public void FixedTimeEquals(){} // RVA: 0x5C733A0
        public void ZeroMemory(){} // RVA: 0x5C73560
    }

    public class CryptographicUnexpectedOperationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x5
    }

    public class CspKeyContainerInfo
    {
        public System.Security.Cryptography.CspParameters _params; // 0x10
        public bool _random; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x965E90
        public void get_Accessible(){} // RVA: 0x3C2850
        public void get_CryptoKeySecurity(){} // RVA: 0x519240
        public void get_Exportable(){} // RVA: 0x3C2850
        public void get_HardwareDevice(){} // RVA: 0x2DD320
        public void get_KeyContainerName(){} // RVA: 0xB2E530
        public void get_KeyNumber(){} // RVA: 0x5CA5230
        public void get_MachineKeyStore(){} // RVA: 0x2DD320
        public void get_Protected(){} // RVA: 0x2DD320
        public void get_ProviderName(){} // RVA: 0xB2EEA0
        public void get_ProviderType(){} // RVA: 0x5C3B260
        public void get_RandomlyGenerated(){} // RVA: 0x2F84E0
        public void get_Removable(){} // RVA: 0x2DD320
        public void get_UniqueKeyContainerName(){} // RVA: 0x5CA5250
    }

    public class CspParameters
    {
        public int Key; // 0x10
        public string ProviderName; // 0x18
        public string KeyContainerName; // 0x20
        public int KeyNumber; // 0x28

        // ── Methods ──
        public void get_Flags(){} // RVA: 0x1209F00
        public void set_Flags(){} // RVA: 0x5C78370
        public void get_CryptoKeySecurity(){} // RVA: 0x6374D0
        public void set_CryptoKeySecurity(){} // RVA: 0x30B890
        public void get_KeyPassword(){} // RVA: 0x4976A0
        public void set_KeyPassword(){} // RVA: 0x5C78460
        public void get_ParentWindowHandle(){} // RVA: 0x35A740
        public void set_ParentWindowHandle(){} // RVA: 0x5C784D0
        public void .ctor(){} // RVA: 0x5C78870 | overloaded x8
    }

}