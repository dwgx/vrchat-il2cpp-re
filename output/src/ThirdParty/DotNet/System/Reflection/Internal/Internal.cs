// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Reflection.Internal
// Classes: 21
// Methods: 106

namespace ThirdParty.DotNet.System.Reflection.Internal
{
    public class AbstractMemoryBlock
    {
        // ── Methods ──
        public void get_Pointer(){} // RVA: 0x7FFAF2D33FA0
        public void get_Size(){} // RVA: 0x7FFAF2ABD840
        public void GetReader(){} // RVA: 0x7FFAF8D96690
        public void Dispose(){} // RVA: 0x7FFAF2AD4A50
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class CriticalDisposableObject
    {
        // ── Methods ──
        public void Release(){} // RVA: 0x7FFAF2AD4A50
        public void Dispose(){} // RVA: 0x7FFAF8D965B0
        public void Finalize(){} // RVA: 0x7FFAF8D96620
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class EmptyArray`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF2AD4A80
    }

    public class EncodingHelper
    {
        // ── Methods ──
        public void DecodeUtf8(){} // RVA: 0x7FFAF8D97FE0
        public void DecodeUtf8Prefixed(){} // RVA: 0x7FFAF8D980C0
        public void AcquireBuffer(){} // RVA: 0x7FFAF8D98320
        public void ReleaseBuffer(){} // RVA: 0x7FFAF8D983D0
        public void LoadGetStringPlatform(){} // RVA: 0x7FFAF8D98470
        public void GetStringUsingCreateStringFromEncoding(){} // RVA: 0x7FFAF8D98C70
        public void .cctor(){} // RVA: 0x7FFAF8D98D40
    }

    public class ExternalMemoryBlock
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8D96710
        public void Dispose(){} // RVA: 0x7FFAF8D96780
        public void get_Pointer(){} // RVA: 0x7FFAF2D907C0
        public void get_Size(){} // RVA: 0x7FFAF3210030
    }

    public class ExternalMemoryBlockProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4419380
        public void get_Size(){} // RVA: 0x7FFAF306ED50
        public void GetMemoryBlockImpl(){} // RVA: 0x7FFAF8D96790
        public void GetStream(){} // RVA: 0x7FFAF8D96860
        public void Dispose(){} // RVA: 0x7FFAF8D969C0
    }

    public class FileStreamReadLightUp
    {
        // ── Methods ──
        public void IsFileStream(){} // RVA: 0x7FFAF8D992F0
        public void GetSafeFileHandle(){} // RVA: 0x7FFAF8D99380
        public void TryReadFile(){} // RVA: 0x7FFAF8D99440
        public void .cctor(){} // RVA: 0x7FFAF8D995B0
    }

    public class Hash
    {
        // ── Methods ──
        public void Combine(){} // RVA: 0x7FFAF8D99630
    }

    public class ImmutableByteArrayInterop
    {
        // ── Methods ──
        public void DangerousCreateFromUnderlyingArray(){} // RVA: 0x7FFAF8D99640
    }

    public class LightUpHelper
    {
        // ── Methods ──
        public void GetMethod(){} // RVA: 0x7FFAF8D99700
    }

    public class MemoryBlock
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4775B50
        public void CreateChecked(){} // RVA: 0x7FFAF8D997E0
        public void CheckBounds(){} // RVA: 0x7FFAF8D998A0
        public void GetMemoryBlockAt(){} // RVA: 0x7FFAF8D998D0
        public void PeekByte(){} // RVA: 0x7FFAF8D99910
        public void PeekUInt32(){} // RVA: 0x7FFAF8D99940
        public void PeekCompressedInteger(){} // RVA: 0x7FFAF8D99990
        public void PeekUInt16(){} // RVA: 0x7FFAF8D99A40
        public void PeekReferenceUnchecked(){} // RVA: 0x7FFAF8D99A80
        public void PeekReference(){} // RVA: 0x7FFAF8D99AF0
        public void PeekHeapReference(){} // RVA: 0x7FFAF8D99B70
        public void PeekUtf8(){} // RVA: 0x7FFAF8D99C00
        public void PeekUtf8NullTerminated(){} // RVA: 0x7FFAF8D99D40
        public void GetUtf8NullTerminatedLength(){} // RVA: 0x7FFAF8D99EC0
        public void CompareUtf8NullTerminatedStringWithAsciiString(){} // RVA: 0x7FFAF8D99F20
        public void PeekBytes(){} // RVA: 0x7FFAF8D9A020
        public void IsOrderedByReferenceAscending(){} // RVA: 0x7FFAF8D9A130
        public void BuildPtrTable(){} // RVA: 0x7FFAF8D9A200
        public void ReadColumn(){} // RVA: 0x7FFAF8D9A4F0
        public void PeekHeapValueOffsetAndSize(){} // RVA: 0x7FFAF8D9A5D0
    }

    public class MemoryBlockProvider
    {
        // ── Methods ──
        public void GetMemoryBlock(){} // RVA: 0x7FFAF8D969D0
        public void GetMemoryBlockImpl(){}
        public void GetStream(){} // RVA: 0x7FFAF2ABCE10
        public void get_Size(){} // RVA: 0x7FFAF2ABD840
        public void Dispose(){} // RVA: 0x7FFAF8D96A40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class MemoryMapLightUp
    {
        // ── Methods ──
        public void get_IsAvailable(){} // RVA: 0x7FFAF2E72850
        public void CreateMemoryMap(){} // RVA: 0x7FFAF8D9A710
        public void CreateViewAccessor(){} // RVA: 0x7FFAF8D9A7B0
        public void TryGetSafeBufferAndPointerOffset(){} // RVA: 0x7FFAF8D9A8D0
    }

    public class MemoryMappedFileBlock
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8D96AB0
        public void Dispose(){} // RVA: 0x7FFAF8D96B80
        public void get_Pointer(){} // RVA: 0x7FFAF35DE530
        public void get_Size(){} // RVA: 0x7FFAF306ED50
    }

    public class NativeHeapMemoryBlock
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8D96FF0
        public void Dispose(){} // RVA: 0x7FFAF8D96B80
        public void get_Pointer(){} // RVA: 0x7FFAF35DECF0
        public void get_Size(){} // RVA: 0x7FFAF306ED50
    }

    public class ObjectPool`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2ADBAA0 | overloaded x2
        public void CreateInstance(){} // RVA: 0x7FFAF2D33FA0
        public void Allocate(){} // RVA: 0x7FFAF2D33FA0
        public void Free(){} // RVA: 0x7FFAF2D33FA0
    }

    public class PooledStringBuilder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8D9AA10
        public void Free(){} // RVA: 0x7FFAF8D9AB20
        public void ToStringAndFree(){} // RVA: 0x7FFAF8D9ABA0
        public void CreatePool(){} // RVA: 0x7FFAF8D9AC50
        public void GetInstance(){} // RVA: 0x7FFAF8D9AE10
        public void .cctor(){} // RVA: 0x7FFAF8D9AE90
    }

    public class ReadOnlyUnmanagedMemoryStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8D9B220
        public void ReadByte(){} // RVA: 0x7FFAF8D9B290
        public void Read(){} // RVA: 0x7FFAF8D9B2C0
        public void Flush(){} // RVA: 0x7FFAF2D8D310
        public void get_CanRead(){} // RVA: 0x7FFAF2E72850
        public void get_CanSeek(){} // RVA: 0x7FFAF2E72850
        public void get_CanWrite(){} // RVA: 0x7FFAF2D8D320
        public void get_Length(){} // RVA: 0x7FFAF8D9B390
        public void get_Position(){} // RVA: 0x7FFAF8D9B3A0
        public void set_Position(){} // RVA: 0x7FFAF8D9B3B0
        public void Seek(){} // RVA: 0x7FFAF8D9B3D0
        public void SetLength(){} // RVA: 0x7FFAF8D9B5D0
        public void Write(){} // RVA: 0x7FFAF8D9B610
    }

    public class StreamConstraints
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8D97290
    }

    public class StreamExtensions
    {
        // ── Methods ──
        public void CopyTo(){} // RVA: 0x7FFAF8D9B650
        public void GetAndValidateSize(){} // RVA: 0x7FFAF8D9B810
    }

    public class StreamMemoryBlockProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8D97300
        public void Dispose(){} // RVA: 0x7FFAF8D97430
        public void get_Size(){} // RVA: 0x7FFAF2DE8CD0
        public void ReadMemoryBlockNoLock(){} // RVA: 0x7FFAF8D974F0
        public void GetMemoryBlockImpl(){} // RVA: 0x7FFAF8D97770
        public void GetStream(){} // RVA: 0x7FFAF8D97950
        public void TryCreateMemoryMappedFileBlock(){} // RVA: 0x7FFAF8D97A40
    }

}