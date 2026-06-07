// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Reflection.Internal
// Classes: 21
// Methods: 106

namespace ThirdParty.DotNet.System.Reflection.Internal
{
    public class AbstractMemoryBlock
    {
        // ── Methods ──
        public void get_Pointer(){} // RVA: 0x283FA0
        public void get_Size(){} // RVA: 0xD840
        public void GetReader(){} // RVA: 0x62E6690
        public void Dispose(){} // RVA: 0x24A50
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class CriticalDisposableObject
    {
        // ── Methods ──
        public void Release(){} // RVA: 0x24A50
        public void Dispose(){} // RVA: 0x62E65B0
        public void Finalize(){} // RVA: 0x62E6620
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class EmptyArray`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x24A80
    }

    public class EncodingHelper
    {
        // ── Methods ──
        public void DecodeUtf8(){} // RVA: 0x62E7FE0
        public void DecodeUtf8Prefixed(){} // RVA: 0x62E80C0
        public void AcquireBuffer(){} // RVA: 0x62E8320
        public void ReleaseBuffer(){} // RVA: 0x62E83D0
        public void LoadGetStringPlatform(){} // RVA: 0x62E8470
        public void GetStringUsingCreateStringFromEncoding(){} // RVA: 0x62E8C70
        public void .cctor(){} // RVA: 0x62E8D40
    }

    public class ExternalMemoryBlock
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x62E6710
        public void Dispose(){} // RVA: 0x62E6780
        public void get_Pointer(){} // RVA: 0x2E07C0
        public void get_Size(){} // RVA: 0x760030
    }

    public class ExternalMemoryBlockProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1969380
        public void get_Size(){} // RVA: 0x5BED50
        public void GetMemoryBlockImpl(){} // RVA: 0x62E6790
        public void GetStream(){} // RVA: 0x62E6860
        public void Dispose(){} // RVA: 0x62E69C0
    }

    public class FileStreamReadLightUp
    {
        // ── Methods ──
        public void IsFileStream(){} // RVA: 0x62E92F0
        public void GetSafeFileHandle(){} // RVA: 0x62E9380
        public void TryReadFile(){} // RVA: 0x62E9440
        public void .cctor(){} // RVA: 0x62E95B0
    }

    public class Hash
    {
        // ── Methods ──
        public void Combine(){} // RVA: 0x62E9630
    }

    public class ImmutableByteArrayInterop
    {
        // ── Methods ──
        public void DangerousCreateFromUnderlyingArray(){} // RVA: 0x62E9640
    }

    public class LightUpHelper
    {
        // ── Methods ──
        public void GetMethod(){} // RVA: 0x62E9700
    }

    public class MemoryBlock
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CC5B50
        public void CreateChecked(){} // RVA: 0x62E97E0
        public void CheckBounds(){} // RVA: 0x62E98A0
        public void GetMemoryBlockAt(){} // RVA: 0x62E98D0
        public void PeekByte(){} // RVA: 0x62E9910
        public void PeekUInt32(){} // RVA: 0x62E9940
        public void PeekCompressedInteger(){} // RVA: 0x62E9990
        public void PeekUInt16(){} // RVA: 0x62E9A40
        public void PeekReferenceUnchecked(){} // RVA: 0x62E9A80
        public void PeekReference(){} // RVA: 0x62E9AF0
        public void PeekHeapReference(){} // RVA: 0x62E9B70
        public void PeekUtf8(){} // RVA: 0x62E9C00
        public void PeekUtf8NullTerminated(){} // RVA: 0x62E9D40
        public void GetUtf8NullTerminatedLength(){} // RVA: 0x62E9EC0
        public void CompareUtf8NullTerminatedStringWithAsciiString(){} // RVA: 0x62E9F20
        public void PeekBytes(){} // RVA: 0x62EA020
        public void IsOrderedByReferenceAscending(){} // RVA: 0x62EA130
        public void BuildPtrTable(){} // RVA: 0x62EA200
        public void ReadColumn(){} // RVA: 0x62EA4F0
        public void PeekHeapValueOffsetAndSize(){} // RVA: 0x62EA5D0
    }

    public class MemoryBlockProvider
    {
        // ── Methods ──
        public void GetMemoryBlock(){} // RVA: 0x62E69D0
        public void GetMemoryBlockImpl(){}
        public void GetStream(){} // RVA: 0xCE10
        public void get_Size(){} // RVA: 0xD840
        public void Dispose(){} // RVA: 0x62E6A40 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class MemoryMapLightUp
    {
        // ── Methods ──
        public void get_IsAvailable(){} // RVA: 0x3C2850
        public void CreateMemoryMap(){} // RVA: 0x62EA710
        public void CreateViewAccessor(){} // RVA: 0x62EA7B0
        public void TryGetSafeBufferAndPointerOffset(){} // RVA: 0x62EA8D0
    }

    public class MemoryMappedFileBlock
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x62E6AB0
        public void Dispose(){} // RVA: 0x62E6B80
        public void get_Pointer(){} // RVA: 0xB2E530
        public void get_Size(){} // RVA: 0x5BED50
    }

    public class NativeHeapMemoryBlock
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x62E6FF0
        public void Dispose(){} // RVA: 0x62E6B80
        public void get_Pointer(){} // RVA: 0xB2ECF0
        public void get_Size(){} // RVA: 0x5BED50
    }

    public class ObjectPool`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2BAA0 | overloaded x2
        public void CreateInstance(){} // RVA: 0x283FA0
        public void Allocate(){} // RVA: 0x283FA0
        public void Free(){} // RVA: 0x283FA0
    }

    public class PooledStringBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x62EAA10
        public void Free(){} // RVA: 0x62EAB20
        public void ToStringAndFree(){} // RVA: 0x62EABA0
        public void CreatePool(){} // RVA: 0x62EAC50
        public void GetInstance(){} // RVA: 0x62EAE10
        public void .cctor(){} // RVA: 0x62EAE90
    }

    public class ReadOnlyUnmanagedMemoryStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x62EB220
        public void ReadByte(){} // RVA: 0x62EB290
        public void Read(){} // RVA: 0x62EB2C0
        public void Flush(){} // RVA: 0x2DD310
        public void get_CanRead(){} // RVA: 0x3C2850
        public void get_CanSeek(){} // RVA: 0x3C2850
        public void get_CanWrite(){} // RVA: 0x2DD320
        public void get_Length(){} // RVA: 0x62EB390
        public void get_Position(){} // RVA: 0x62EB3A0
        public void set_Position(){} // RVA: 0x62EB3B0
        public void Seek(){} // RVA: 0x62EB3D0
        public void SetLength(){} // RVA: 0x62EB5D0
        public void Write(){} // RVA: 0x62EB610
    }

    public class StreamConstraints
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x62E7290
    }

    public class StreamExtensions
    {
        // ── Methods ──
        public void CopyTo(){} // RVA: 0x62EB650
        public void GetAndValidateSize(){} // RVA: 0x62EB810
    }

    public class StreamMemoryBlockProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x62E7300
        public void Dispose(){} // RVA: 0x62E7430
        public void get_Size(){} // RVA: 0x338CD0
        public void ReadMemoryBlockNoLock(){} // RVA: 0x62E74F0
        public void GetMemoryBlockImpl(){} // RVA: 0x62E7770
        public void GetStream(){} // RVA: 0x62E7950
        public void TryCreateMemoryMappedFileBlock(){} // RVA: 0x62E7A40
    }

}