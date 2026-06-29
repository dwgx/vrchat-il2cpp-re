// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 9
// Methods: 84

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class CryptoAPITransform : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A847A460
        public void get_CanReuseTransform(){} // RVA: 0x7A81BD750
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7A81BD750
        public void get_InputBlockSize(){} // RVA: 0x7A82D1450
        public void get_KeyHandle(){} // RVA: 0x7A82D1450
        public void get_OutputBlockSize(){} // RVA: 0x7A82D1450
        public void Dispose(){} // RVA: 0x7ADA8F0A0
        public void Clear(){} // RVA: 0x7ADA8F0A0
        public void TransformBlock(){} // RVA: 0x7A82D1450
        public void TransformFinalBlock(){} // RVA: 0x7A82D1450
        public void Reset(){} // RVA: 0x7A80D7310
    }

    public class CryptoConfig : Object
    {
        // ── Methods ──
        public void AddOID(){} // RVA: 0x7ADA8F0B0
        public void CreateFromName(){} // RVA: 0x7ADA8F150
        public void MapNameToOID(){} // RVA: 0x7ADA91CA0
        public void Initialize(){} // RVA: 0x7ADA92730
        public void AddAlgorithm(){} // RVA: 0x7ADA928A0
        public void EncodeOID(){} // RVA: 0x7ADA92EC0
        public void EncodeLongNumber(){} // RVA: 0x7ADA93400
        public void get_AllowOnlyFipsAlgorithms(){} // RVA: 0x7A80D7320
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7ADA935B0
    }

    public class CryptoConfigForwarder : Object
    {
        // ── Methods ──
        public void CreateFromName(){} // RVA: 0x7ADA9DAA0
        public void CreateDefaultHashAlgorithm(){} // RVA: 0x7ADA615A0
    }

    public class CryptoStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA5B650
        public void get_CanRead(){} // RVA: 0x7A8100260
        public void get_CanSeek(){} // RVA: 0x7A80D7320
        public void get_CanWrite(){} // RVA: 0x7A8F1FD00
        public void get_Length(){} // RVA: 0x7ADA5BA70
        public void get_Position(){} // RVA: 0x7ADA5BAC0
        public void set_Position(){} // RVA: 0x7ADA5BB10
        public void get_HasFlushedFinalBlock(){} // RVA: 0x7A810C000
        public void FlushFinalBlock(){} // RVA: 0x7ADA5BB60
        public void Flush(){} // RVA: 0x7A80D7310
        public void FlushAsync(){} // RVA: 0x7ADA5BD60
        public void Seek(){} // RVA: 0x7ADA5BF20
        public void SetLength(){} // RVA: 0x7ADA5BF70
        public void ReadAsync(){} // RVA: 0x7ADA5BFC0
        public void BeginRead(){} // RVA: 0x7ADA5C020
        public void EndRead(){} // RVA: 0x7ADA5C0D0
        public void ReadAsyncInternal(){} // RVA: 0x7ADA5C110
        public void ReadByte(){} // RVA: 0x7ADA5C390
        public void WriteByte(){} // RVA: 0x7ADA5C5E0
        public void Read(){} // RVA: 0x7ADA5C6B0
        public void CheckReadArguments(){} // RVA: 0x7ADA5C7F0
        public void ReadAsyncCore(){} // RVA: 0x7ADA5C9A0
        public void WriteAsync(){} // RVA: 0x7ADA5CC20
        public void BeginWrite(){} // RVA: 0x7ADA5CC80
        public void EndWrite(){} // RVA: 0x7ADA5CD30
        public void WriteAsyncInternal(){} // RVA: 0x7ADA5CD40
        public void Write(){} // RVA: 0x7ADA5CFE0
        public void CheckWriteArguments(){} // RVA: 0x7ADA5D0D0
        public void WriteAsyncCore(){} // RVA: 0x7ADA5D280
        public void Clear(){} // RVA: 0x7ADA5D520
        public void Dispose(){} // RVA: 0x7ADA5D540
        public void InitializeBuffer(){} // RVA: 0x7ADA5D750
        public void get_AsyncActiveSemaphore(){} // RVA: 0x7ADA5D8B0
    }

    public class CryptographicException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F7860
        public void ThrowCryptographicException(){} // RVA: 0x7ADA66160
    }

    public class CryptographicOperations : Object
    {
        // ── Methods ──
        public void FixedTimeEquals(){} // RVA: 0x7ADA61390
        public void ZeroMemory(){} // RVA: 0x7ADA61550
    }

    public class CryptographicUnexpectedOperationException : CryptographicException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F7860
    }

    public class CspKeyContainerInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A86FFE10
        public void get_Accessible(){} // RVA: 0x7A81BD750
        public void get_CryptoKeySecurity(){} // RVA: 0x7A82D1450
        public void get_Exportable(){} // RVA: 0x7A81BD750
        public void get_HardwareDevice(){} // RVA: 0x7A80D7320
        public void get_KeyContainerName(){} // RVA: 0x7A88F38D0
        public void get_KeyNumber(){} // RVA: 0x7ADA93660
        public void get_MachineKeyStore(){} // RVA: 0x7A80D7320
        public void get_Protected(){} // RVA: 0x7A80D7320
        public void get_ProviderName(){} // RVA: 0x7A88F4330
        public void get_ProviderType(){} // RVA: 0x7ADA292A0
        public void get_RandomlyGenerated(){} // RVA: 0x7A80F26D0
        public void get_Removable(){} // RVA: 0x7A80D7320
        public void get_UniqueKeyContainerName(){} // RVA: 0x7ADA93680
    }

    public class CspParameters : Object
    {
        // ── Methods ──
        public void get_Flags(){} // RVA: 0x7A8F9ACE0
        public void set_Flags(){} // RVA: 0x7ADA66350
        public void get_CryptoKeySecurity(){} // RVA: 0x7A83F69F0
        public void set_CryptoKeySecurity(){} // RVA: 0x7A8105A90
        public void get_KeyPassword(){} // RVA: 0x7A8292C30
        public void set_KeyPassword(){} // RVA: 0x7ADA66440
        public void get_ParentWindowHandle(){} // RVA: 0x7A8154D80
        public void set_ParentWindowHandle(){} // RVA: 0x7ADA664B0
        public void .ctor(){} // RVA: 0x7ADA66850
    }

}