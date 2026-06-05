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
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF316DA00
        public void get_CanReuseTransform(){} // RVA: 0x7FFAF2E72850
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7FFAF2E72850
        public void get_InputBlockSize(){} // RVA: 0x7FFAF2FC9240
        public void get_KeyHandle(){} // RVA: 0x7FFAF2FC9240
        public void get_OutputBlockSize(){} // RVA: 0x7FFAF2FC9240
        public void Dispose(){} // RVA: 0x7FFAF8750CB0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAF8750CB0
        public void TransformBlock(){} // RVA: 0x7FFAF2FC9240
        public void TransformFinalBlock(){} // RVA: 0x7FFAF2FC9240
        public void Reset(){} // RVA: 0x7FFAF2D8D310
    }

    public class CryptoConfig
    {
        public object Accessible;

        // ── Methods ──
        public void AddOID(){} // RVA: 0x7FFAF8750CC0
        public void CreateFromName(){} // RVA: 0x7FFAF8750D60 | overloaded x2
        public void MapNameToOID(){} // RVA: 0x7FFAF8753860 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFAF87542F0
        public void AddAlgorithm(){} // RVA: 0x7FFAF8754460
        public void EncodeOID(){} // RVA: 0x7FFAF8754AB0
        public void EncodeLongNumber(){} // RVA: 0x7FFAF8754FE0
        public void get_AllowOnlyFipsAlgorithms(){} // RVA: 0x7FFAF2D8D320
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF8755180
    }

    public class CryptoConfigForwarder
    {
        // ── Methods ──
        public void CreateFromName(){} // RVA: 0x7FFAF875FA20
        public void CreateDefaultHashAlgorithm(){} // RVA: 0x7FFAF87235B0
    }

    public class CryptoStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF871D640 | overloaded x2
        public void get_CanRead(){} // RVA: 0x7FFAF2DB6020
        public void get_CanSeek(){} // RVA: 0x7FFAF2D8D320
        public void get_CanWrite(){} // RVA: 0x7FFAF3C0A230
        public void get_Length(){} // RVA: 0x7FFAF871DA40
        public void get_Position(){} // RVA: 0x7FFAF871DA90
        public void set_Position(){} // RVA: 0x7FFAF871DAE0
        public void get_HasFlushedFinalBlock(){} // RVA: 0x7FFAF2DC1E50
        public void FlushFinalBlock(){} // RVA: 0x7FFAF871DB30
        public void Flush(){} // RVA: 0x7FFAF2D8D310
        public void FlushAsync(){} // RVA: 0x7FFAF871DD40
        public void Seek(){} // RVA: 0x7FFAF871DF00
        public void SetLength(){} // RVA: 0x7FFAF871DF50
        public void ReadAsync(){} // RVA: 0x7FFAF871DFA0
        public void BeginRead(){} // RVA: 0x7FFAF871E000
        public void EndRead(){} // RVA: 0x7FFAF871E0B0
        public void ReadAsyncInternal(){} // RVA: 0x7FFAF871E0F0
        public void ReadByte(){} // RVA: 0x7FFAF871E370
        public void WriteByte(){} // RVA: 0x7FFAF871E5C0
        public void Read(){} // RVA: 0x7FFAF871E690
        public void CheckReadArguments(){} // RVA: 0x7FFAF871E7E0
        public void ReadAsyncCore(){} // RVA: 0x7FFAF871E990
        public void WriteAsync(){} // RVA: 0x7FFAF871EC00
        public void BeginWrite(){} // RVA: 0x7FFAF871EC60
        public void EndWrite(){} // RVA: 0x7FFAF871ED10
        public void WriteAsyncInternal(){} // RVA: 0x7FFAF871ED20
        public void Write(){} // RVA: 0x7FFAF871EFC0
        public void CheckWriteArguments(){} // RVA: 0x7FFAF871F0B0
        public void WriteAsyncCore(){} // RVA: 0x7FFAF871F260
        public void Clear(){} // RVA: 0x7FFAF871F500
        public void Dispose(){} // RVA: 0x7FFAF871F520
        public void InitializeBuffer(){} // RVA: 0x7FFAF871F740
        public void get_AsyncActiveSemaphore(){} // RVA: 0x7FFAF871F8A0
    }

    public class CryptographicException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE1C0 | overloaded x6
        public void ThrowCryptographicException(){} // RVA: 0x7FFAF8728180
    }

    public class CryptographicOperations
    {
        // ── Methods ──
        public void FixedTimeEquals(){} // RVA: 0x7FFAF87233A0
        public void ZeroMemory(){} // RVA: 0x7FFAF8723560
    }

    public class CryptographicUnexpectedOperationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE1C0 | overloaded x5
    }

    public class CspKeyContainerInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF3415E90
        public void get_Accessible(){} // RVA: 0x7FFAF2E72850
        public void get_CryptoKeySecurity(){} // RVA: 0x7FFAF2FC9240
        public void get_Exportable(){} // RVA: 0x7FFAF2E72850
        public void get_HardwareDevice(){} // RVA: 0x7FFAF2D8D320
        public void get_KeyContainerName(){} // RVA: 0x7FFAF35DE530
        public void get_KeyNumber(){} // RVA: 0x7FFAF8755230
        public void get_MachineKeyStore(){} // RVA: 0x7FFAF2D8D320
        public void get_Protected(){} // RVA: 0x7FFAF2D8D320
        public void get_ProviderName(){} // RVA: 0x7FFAF35DEEA0
        public void get_ProviderType(){} // RVA: 0x7FFAF86EB260
        public void get_RandomlyGenerated(){} // RVA: 0x7FFAF2DA84E0
        public void get_Removable(){} // RVA: 0x7FFAF2D8D320
        public void get_UniqueKeyContainerName(){} // RVA: 0x7FFAF8755250
    }

    public class CspParameters
    {
        public object Key;

        // ── Methods ──
        public void get_Flags(){} // RVA: 0x7FFAF3CB9F00
        public void set_Flags(){} // RVA: 0x7FFAF8728370
        public void get_CryptoKeySecurity(){} // RVA: 0x7FFAF30E74D0
        public void set_CryptoKeySecurity(){} // RVA: 0x7FFAF2DBB890
        public void get_KeyPassword(){} // RVA: 0x7FFAF2F476A0
        public void set_KeyPassword(){} // RVA: 0x7FFAF8728460
        public void get_ParentWindowHandle(){} // RVA: 0x7FFAF2E0A740
        public void set_ParentWindowHandle(){} // RVA: 0x7FFAF87284D0
        public void .ctor(){} // RVA: 0x7FFAF8728870 | overloaded x8
    }

}