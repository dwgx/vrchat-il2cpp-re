// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Reflection.Internal
// Classes: 21
// Methods: 104

namespace ThirdParty.DotNet.System.Reflection.Internal
{
    public class AbstractMemoryBlock : Object
    {
        // ── Methods ──
        public void get_Pointer(){} // RVA: 0x7A8051B10
        public void get_Size(){} // RVA: 0x7A7E00710
        public void GetReader(){} // RVA: 0x7AE0D24C0
        public void Dispose(){} // RVA: 0x7A7E18770
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CriticalDisposableObject : CriticalFinalizerObject
    {
        // ── Methods ──
        public void Release(){} // RVA: 0x7A7E18770
        public void Dispose(){} // RVA: 0x7AE0D23E0
        public void Finalize(){} // RVA: 0x7AE0D2450
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class EmptyArray`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7A7E187D0
    }

    public class EncodingHelper : Object
    {
        // ── Methods ──
        public void DecodeUtf8(){} // RVA: 0x7AE0D3DD0
        public void DecodeUtf8Prefixed(){} // RVA: 0x7AE0D3EB0
        public void AcquireBuffer(){} // RVA: 0x7AE0D4110
        public void ReleaseBuffer(){} // RVA: 0x7AE0D41C0
        public void LoadGetStringPlatform(){} // RVA: 0x7AE0D4260
        public void GetStringUsingCreateStringFromEncoding(){} // RVA: 0x7AE0D4A60
        public void .cctor(){} // RVA: 0x7AE0D4B30
    }

    public class ExternalMemoryBlock : AbstractMemoryBlock
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE0D2540
        public void Dispose(){} // RVA: 0x7AE0D25B0
        public void get_Pointer(){} // RVA: 0x7A80DA7B0
        public void get_Size(){} // RVA: 0x7A851DB90
    }

    public class ExternalMemoryBlockProvider : MemoryBlockProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9725F90
        public void get_Size(){} // RVA: 0x7A83782A0
        public void GetMemoryBlockImpl(){} // RVA: 0x7AE0D25C0
        public void GetStream(){} // RVA: 0x7AE0D2690
        public void Dispose(){} // RVA: 0x7AE0D27F0
    }

    public class FileStreamReadLightUp : Object
    {
        // ── Methods ──
        public void IsFileStream(){} // RVA: 0x7AE0D50D0
        public void GetSafeFileHandle(){} // RVA: 0x7AE0D5150
        public void TryReadFile(){} // RVA: 0x7AE0D5210
        public void .cctor(){} // RVA: 0x7AE0D5380
    }

    public class Hash : Object
    {
        // ── Methods ──
        public void Combine(){} // RVA: 0x7AE0D5400
    }

    public class ImmutableByteArrayInterop : Object
    {
        // ── Methods ──
        public void DangerousCreateFromUnderlyingArray(){} // RVA: 0x7AE0D5410
    }

    public class LightUpHelper : Object
    {
        // ── Methods ──
        public void GetMethod(){} // RVA: 0x7AE0D54E0
    }

    public class MemoryBlock : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7670970
        public void CreateChecked(){} // RVA: 0x7AE0D55C0
        public void CheckBounds(){} // RVA: 0x7A7E6D6B0
        public void GetMemoryBlockAt(){} // RVA: 0x7A7E6D6E0
        public void PeekByte(){} // RVA: 0x7A7E6D730
        public void PeekUInt32(){} // RVA: 0x7A7E6D760
        public void PeekCompressedInteger(){} // RVA: 0x7A7E6D7B0
        public void PeekUInt16(){} // RVA: 0x7A7E6D7C0
        public void PeekReferenceUnchecked(){} // RVA: 0x7A7E6D800
        public void PeekReference(){} // RVA: 0x7A7E6D810
        public void PeekHeapReference(){} // RVA: 0x7A7E6D820
        public void PeekUtf8(){} // RVA: 0x7A7E6D830
        public void PeekUtf8NullTerminated(){} // RVA: 0x7A7E6D840
        public void GetUtf8NullTerminatedLength(){} // RVA: 0x7A7E6D860
        public void CompareUtf8NullTerminatedStringWithAsciiString(){} // RVA: 0x7A7E6D8C0
        public void PeekBytes(){} // RVA: 0x7A7E6D8D0
        public void IsOrderedByReferenceAscending(){} // RVA: 0x7A7E6D8E0
        public void BuildPtrTable(){} // RVA: 0x7A7E6D8F0
        public void ReadColumn(){} // RVA: 0x7A7E6D910
        public void PeekHeapValueOffsetAndSize(){} // RVA: 0x7A7E6D9F0
    }

    public class MemoryBlockProvider : Object
    {
        // ── Methods ──
        public void GetMemoryBlock(){} // RVA: 0x7AE0D2800
        public void GetMemoryBlockImpl(){} // RVA: 0x7A7E10B10
        public void GetStream(){} // RVA: 0x7A7E00B20
        public void get_Size(){} // RVA: 0x7A7E00710
        public void Dispose(){} // RVA: 0x7AE0D2870
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class MemoryMapLightUp : Object
    {
        // ── Methods ──
        public void get_IsAvailable(){} // RVA: 0x7A81BD750
        public void CreateMemoryMap(){} // RVA: 0x7AE0D64C0
        public void CreateViewAccessor(){} // RVA: 0x7AE0D6560
        public void TryGetSafeBufferAndPointerOffset(){} // RVA: 0x7AE0D6680
    }

    public class MemoryMappedFileBlock : AbstractMemoryBlock
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE0D28E0
        public void Dispose(){} // RVA: 0x7AE0D29D0
        public void get_Pointer(){} // RVA: 0x7A88F38D0
        public void get_Size(){} // RVA: 0x7A83782A0
    }

    public class NativeHeapMemoryBlock : AbstractMemoryBlock
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE0D2E40
        public void Dispose(){} // RVA: 0x7AE0D29D0
        public void get_Pointer(){} // RVA: 0x7A88F4180
        public void get_Size(){} // RVA: 0x7A83782A0
    }

    public class ObjectPool`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1D590
        public void CreateInstance(){} // RVA: 0x7A8051B10
        public void Allocate(){} // RVA: 0x7A8051B10
        public void Free(){} // RVA: 0x7A8051B10
    }

    public class PooledStringBuilder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE0D67C0
        public void Free(){} // RVA: 0x7AE0D68D0
        public void ToStringAndFree(){} // RVA: 0x7AE0D6950
        public void CreatePool(){} // RVA: 0x7AE0D6A00
        public void GetInstance(){} // RVA: 0x7AE0D6BC0
        public void .cctor(){} // RVA: 0x7AE0D6C40
    }

    public class ReadOnlyUnmanagedMemoryStream : Stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE0D6FD0
        public void ReadByte(){} // RVA: 0x7AE0D7040
        public void Read(){} // RVA: 0x7AE0D7070
        public void Flush(){} // RVA: 0x7A80D7310
        public void get_CanRead(){} // RVA: 0x7A81BD750
        public void get_CanSeek(){} // RVA: 0x7A81BD750
        public void get_CanWrite(){} // RVA: 0x7A80D7320
        public void get_Length(){} // RVA: 0x7AE0D7140
        public void get_Position(){} // RVA: 0x7AE0D7150
        public void set_Position(){} // RVA: 0x7AE0D7160
        public void Seek(){} // RVA: 0x7AE0D7180
        public void SetLength(){} // RVA: 0x7AE0D7380
        public void Write(){} // RVA: 0x7AE0D73C0
    }

    public class StreamConstraints : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E6D4D0
    }

    public class StreamExtensions : Object
    {
        // ── Methods ──
        public void CopyTo(){} // RVA: 0x7AE0D7400
        public void GetAndValidateSize(){} // RVA: 0x7AE0D75C0
    }

    public class StreamMemoryBlockProvider : MemoryBlockProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE0D3150
        public void Dispose(){} // RVA: 0x7AE0D3280
        public void get_Size(){} // RVA: 0x7A8133100
        public void ReadMemoryBlockNoLock(){} // RVA: 0x7AE0D3340
        public void GetMemoryBlockImpl(){} // RVA: 0x7AE0D35C0
        public void GetStream(){} // RVA: 0x7AE0D3780
        public void TryCreateMemoryMappedFileBlock(){} // RVA: 0x7AE0D3870
    }

}