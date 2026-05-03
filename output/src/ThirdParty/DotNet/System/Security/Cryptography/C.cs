// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 10
// Methods: 104

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class Constants : Object
    {
    }

    public class CryptoAPITransform : Object
    {
        public bool m_disposed; // 0x10
        public object field_1; // 0x33A
        public object field_2; // 0x33B
        public object field_3; // 0x33C
        public object field_4; // 0x33D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81FCAC70
        public void get_CanReuseTransform(){} // RVA: 0x7FFE811E0850
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7FFE811E0850
        public void get_InputBlockSize(){} // RVA: 0x7FFE813240E0
        public void get_KeyHandle(){} // RVA: 0x7FFE813240E0
        public void get_OutputBlockSize(){} // RVA: 0x7FFE813240E0
        public void Dispose(){} // RVA: 0x7FFE867E1B50 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE867E1B50
        public void TransformBlock(){} // RVA: 0x7FFE813240E0
        public void TransformFinalBlock(){} // RVA: 0x7FFE813240E0
        public void Reset(){} // RVA: 0x7FFE810FB310
    }

    public class CryptoConfig : Object
    {
        public object lockObject;

        // ── Methods ──
        public void AddOID(){} // RVA: 0x7FFE867E1B60
        public void CreateFromName(){} // RVA: 0x7FFE867E1C00 | overloaded x2
        public void MapNameToOID(){} // RVA: 0x7FFE867E4700 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFE867E5190
        public void AddAlgorithm(){} // RVA: 0x7FFE867E5300
        public void EncodeOID(){} // RVA: 0x7FFE867E5950
        public void EncodeLongNumber(){} // RVA: 0x7FFE867E5E80
        public void get_AllowOnlyFipsAlgorithms(){} // RVA: 0x7FFE810FB320
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE867E6020
    }

    public class CryptoConfigForwarder : Object
    {
        // ── Methods ──
        public void CreateFromName(){} // RVA: 0x7FFE867F0920
        public void CreateDefaultHashAlgorithm(){} // RVA: 0x7FFE867B4450
    }

    public class CryptoStream : Stream
    {
        public System.IO.Stream _stream; // 0x28
        public System.Security.Cryptography.ICryptoTransform _transform; // 0x30
        public 0x664C4A74 _transformMode; // 0x38
        public byte[] _inputBuffer; // 0x40
        public int _inputBufferIndex; // 0x48
        public int _inputBlockSize; // 0x4C
        public byte[] _outputBuffer; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867AE4E0 | overloaded x2
        public void get_CanRead(){} // RVA: 0x7FFE81124020
        public void get_CanSeek(){} // RVA: 0x7FFE810FB320
        public void get_CanWrite(){} // RVA: 0x7FFE81EC3970
        public void get_Length(){} // RVA: 0x7FFE867AE8E0
        public void get_Position(){} // RVA: 0x7FFE867AE930
        public void set_Position(){} // RVA: 0x7FFE867AE980
        public void get_HasFlushedFinalBlock(){} // RVA: 0x7FFE8112FE50
        public void FlushFinalBlock(){} // RVA: 0x7FFE867AE9D0
        public void Flush(){} // RVA: 0x7FFE810FB310
        public void FlushAsync(){} // RVA: 0x7FFE867AEBE0
        public void Seek(){} // RVA: 0x7FFE867AEDA0
        public void SetLength(){} // RVA: 0x7FFE867AEDF0
        public void ReadAsync(){} // RVA: 0x7FFE867AEE40
        public void BeginRead(){} // RVA: 0x7FFE867AEEA0
        public void EndRead(){} // RVA: 0x7FFE867AEF50
        public void ReadAsyncInternal(){} // RVA: 0x7FFE867AEF90
        public void ReadByte(){} // RVA: 0x7FFE867AF210
        public void WriteByte(){} // RVA: 0x7FFE867AF460
        public void Read(){} // RVA: 0x7FFE867AF530
        public void CheckReadArguments(){} // RVA: 0x7FFE867AF680
        public void ReadAsyncCore(){} // RVA: 0x7FFE867AF830
        public void WriteAsync(){} // RVA: 0x7FFE867AFAA0
        public void BeginWrite(){} // RVA: 0x7FFE867AFB00
        public void EndWrite(){} // RVA: 0x7FFE867AFBB0
        public void WriteAsyncInternal(){} // RVA: 0x7FFE867AFBC0
        public void Write(){} // RVA: 0x7FFE867AFE60
        public void CheckWriteArguments(){} // RVA: 0x7FFE867AFF50
        public void WriteAsyncCore(){} // RVA: 0x7FFE867B0100
        public void Clear(){} // RVA: 0x7FFE867B03A0
        public void Dispose(){} // RVA: 0x7FFE867B03C0
        public void InitializeBuffer(){} // RVA: 0x7FFE867B05E0
        public void get_AsyncActiveSemaphore(){} // RVA: 0x7FFE867B0740
    }

    public class CryptographicException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x6
        public void ThrowCryptographicException(){} // RVA: 0x7FFE867B9020
    }

    public class CryptographicOperations : Object
    {
        // ── Methods ──
        public void FixedTimeEquals(){} // RVA: 0x7FFE867B4240
        public void ZeroMemory(){} // RVA: 0x7FFE867B4400
    }

    public class CryptographicUnexpectedOperationException : CryptographicException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x5
    }

    public class CspKeyContainerInfo : Object
    {
        public System.Security.Cryptography.CspParameters _params; // 0x10
        public bool _random; // 0x18
        public object field_2; // 0x340
        public object field_3; // 0x341
        public object field_4; // 0x342
        public object field_5; // 0x343
        public object field_6; // 0x344
        public object field_7; // 0x345
        public object field_8; // 0x346
        public object field_9; // 0x347
        public object field_10; // 0x348
        public object field_11; // 0x349
        public object field_12; // 0x34A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867E60D0
        public void get_Accessible(){} // RVA: 0x7FFE811E0850
        public void get_CryptoKeySecurity(){} // RVA: 0x7FFE813240E0
        public void get_Exportable(){} // RVA: 0x7FFE811E0850
        public void get_HardwareDevice(){} // RVA: 0x7FFE810FB320
        public void get_KeyContainerName(){} // RVA: 0x7FFE8189B810
        public void get_KeyNumber(){} // RVA: 0x7FFE867E6130
        public void get_MachineKeyStore(){} // RVA: 0x7FFE810FB320
        public void get_Protected(){} // RVA: 0x7FFE810FB320
        public void get_ProviderName(){} // RVA: 0x7FFE8189C080
        public void get_ProviderType(){} // RVA: 0x7FFE8677C0B0
        public void get_RandomlyGenerated(){} // RVA: 0x7FFE811164E0
        public void get_Removable(){} // RVA: 0x7FFE810FB320
        public void get_UniqueKeyContainerName(){} // RVA: 0x7FFE867E6150
    }

    public class CspParameters : Object
    {
        public int ProviderType; // 0x10
        public string ProviderName; // 0x18
        public string KeyContainerName; // 0x20
        public int KeyNumber; // 0x28

        // ── Methods ──
        public void get_Flags(){} // RVA: 0x7FFE81F84A50
        public void set_Flags(){} // RVA: 0x7FFE867B9210
        public void get_CryptoKeySecurity(){} // RVA: 0x7FFE8144E200
        public void set_CryptoKeySecurity(){} // RVA: 0x7FFE81129890
        public void get_KeyPassword(){} // RVA: 0x7FFE8143BA80
        public void set_KeyPassword(){} // RVA: 0x7FFE867B9300
        public void get_ParentWindowHandle(){} // RVA: 0x7FFE81178740
        public void set_ParentWindowHandle(){} // RVA: 0x7FFE867B9370
        public void .ctor(){} // RVA: 0x7FFE867B9710 | overloaded x8
    }

}