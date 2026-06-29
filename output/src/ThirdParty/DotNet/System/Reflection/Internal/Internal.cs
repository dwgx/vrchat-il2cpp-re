// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Reflection.Internal
// Classes: 21
// Methods: 104

namespace ThirdParty.DotNet.System.Reflection.Internal
{
    public class AbstractMemoryBlock : Object
    {
        // ── Methods ──
        public void get_Pointer(){} // RVA: 0xA94080
        public void get_Size(){} // RVA: 0x87C130
        public void GetReader(){} // RVA: 0x6D53510
        public void Dispose(){} // RVA: 0x894290
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CriticalDisposableObject : CriticalFinalizerObject
    {
        // ── Methods ──
        public void Release(){} // RVA: 0x894290
        public void Dispose(){} // RVA: 0x6D53430
        public void Finalize(){} // RVA: 0x6D534A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class EmptyArray`1 : Object
    {
        public object Instance;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class EncodingHelper : Object
    {
        public object s_pool;
        public object s_getStringPlatform;

        // ── Methods ──
        public void DecodeUtf8(){} // RVA: 0x6D54E20
        public void DecodeUtf8Prefixed(){} // RVA: 0x6D54EF0
        public void AcquireBuffer(){} // RVA: 0x6D55140
        public void ReleaseBuffer(){} // RVA: 0x6D551F0
        public void LoadGetStringPlatform(){} // RVA: 0x6D55290
        public void GetStringUsingCreateStringFromEncoding(){} // RVA: 0x6D55A80
        public void .cctor(){} // RVA: 0x6D55B50
    }

    public class ExternalMemoryBlock : AbstractMemoryBlock
    {
        public object _memoryOwner;
        public object _buffer;
        public object _size;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6D53590
        public void Dispose(){} // RVA: 0x6D53600
        public void get_Pointer(){} // RVA: 0xB465B0
        public void get_Size(){} // RVA: 0xFEAE90
    }

    public class ExternalMemoryBlockProvider : MemoryBlockProvider
    {
        public object _memory;
        public object _size;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2232610
        public void get_Size(){} // RVA: 0xE62D00
        public void GetMemoryBlockImpl(){} // RVA: 0x6D53610
        public void GetStream(){} // RVA: 0x6D536E0
        public void Dispose(){} // RVA: 0x6D53840
    }

    public class FileStreamReadLightUp : Object
    {
        public object readFileNotAvailable;

        // ── Methods ──
        public void IsFileStream(){} // RVA: 0x6D560F0
        public void GetSafeFileHandle(){} // RVA: 0x6D56170
        public void TryReadFile(){} // RVA: 0x6D56230
        public void .cctor(){} // RVA: 0x6D563A0
    }

    public class Hash : Object
    {
        // ── Methods ──
        public void Combine(){} // RVA: 0x6D56420
    }

    public class ImmutableByteArrayInterop : Object
    {
        // ── Methods ──
        public void DangerousCreateFromUnderlyingArray(){} // RVA: 0x6D56430
    }

    public class LightUpHelper : Object
    {
        // ── Methods ──
        public void GetMethod(){} // RVA: 0x6D56500
    }

    public class MemoryBlock : ValueType
    {
        public object Pointer;
        public object Length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x856B0
        public void CreateChecked(){} // RVA: 0x6D565C0
        public void CheckBounds(){} // RVA: 0x8EC570
        public void GetMemoryBlockAt(){} // RVA: 0x8EC5A0
        public void PeekByte(){} // RVA: 0x8EC5F0
        public void PeekUInt32(){} // RVA: 0x8EC620
        public void PeekCompressedInteger(){} // RVA: 0x8EC670
        public void PeekUInt16(){} // RVA: 0x8EC680
        public void PeekReferenceUnchecked(){} // RVA: 0x8EC6C0
        public void PeekReference(){} // RVA: 0x8EC6D0
        public void PeekHeapReference(){} // RVA: 0x8EC6E0
        public void PeekUtf8(){} // RVA: 0x8EC6F0
        public void PeekUtf8NullTerminated(){} // RVA: 0x8EC700
        public void GetUtf8NullTerminatedLength(){} // RVA: 0x8EC720
        public void CompareUtf8NullTerminatedStringWithAsciiString(){} // RVA: 0x8EC780
        public void PeekBytes(){} // RVA: 0x8EC790
        public void IsOrderedByReferenceAscending(){} // RVA: 0x8EC7A0
        public void BuildPtrTable(){} // RVA: 0x8EC7B0
        public void ReadColumn(){} // RVA: 0x8EC7D0
        public void PeekHeapValueOffsetAndSize(){} // RVA: 0x8EC8B0
    }

    public class MemoryBlockProvider : Object
    {
        // ── Methods ──
        public void GetMemoryBlock(){} // RVA: 0x6D53850
        public void GetMemoryBlockImpl(){} // RVA: 0x88C530
        public void GetStream(){} // RVA: 0x87C540
        public void get_Size(){} // RVA: 0x87C130
        public void Dispose(){} // RVA: 0x6D538C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class MemoryMapLightUp : Object
    {
        // ── Methods ──
        public void get_IsAvailable(){} // RVA: 0xC2E4C0
        public void CreateMemoryMap(){} // RVA: 0x6D574B0
        public void CreateViewAccessor(){} // RVA: 0x6D57550
        public void TryGetSafeBufferAndPointerOffset(){} // RVA: 0x6D57670
    }

    public class MemoryMappedFileBlock : AbstractMemoryBlock
    {
        public object _data;
        public object _size;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6D53930
        public void Dispose(){} // RVA: 0x6D53A20
        public void get_Pointer(){} // RVA: 0x13F92B0
        public void get_Size(){} // RVA: 0xE62D00
    }

    public class NativeHeapMemoryBlock : AbstractMemoryBlock
    {
        public object _data;
        public object _size;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6D53E90
        public void Dispose(){} // RVA: 0x6D53A20
        public void get_Pointer(){} // RVA: 0x13F9340
        public void get_Size(){} // RVA: 0xE62D00
    }

    public class ObjectPool`1 : Object
    {
        public object _items;
        public object _factory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x899290
        public void CreateInstance(){} // RVA: 0xA94080
        public void Allocate(){} // RVA: 0xA94080
        public void Free(){} // RVA: 0xA94080
    }

    public class PooledStringBuilder : Object
    {
        public object Builder;
        public object _pool;
        public object s_poolInstance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6D577B0
        public void Free(){} // RVA: 0x6D578C0
        public void ToStringAndFree(){} // RVA: 0x6D57940
        public void CreatePool(){} // RVA: 0x6D579F0
        public void GetInstance(){} // RVA: 0x6D57BB0
        public void .cctor(){} // RVA: 0x6D57C30
    }

    public class ReadOnlyUnmanagedMemoryStream : Stream
    {
        public object _data;
        public object _length;
        public object _position;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6D57FC0
        public void ReadByte(){} // RVA: 0x6D58030
        public void Read(){} // RVA: 0x6D58060
        public void Flush(){} // RVA: 0xB43310
        public void get_CanRead(){} // RVA: 0xC2E4C0
        public void get_CanSeek(){} // RVA: 0xC2E4C0
        public void get_CanWrite(){} // RVA: 0xB43320
        public void get_Length(){} // RVA: 0x6D58130
        public void get_Position(){} // RVA: 0x6D58140
        public void set_Position(){} // RVA: 0x6D58150
        public void Seek(){} // RVA: 0x6D58170
        public void SetLength(){} // RVA: 0x6D58370
        public void Write(){} // RVA: 0x6D583B0
    }

    public class StreamConstraints : ValueType
    {
        public object GuardOpt;
        public object ImageStart;
        public object ImageSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8EC2F0
    }

    public class StreamExtensions : Object
    {
        // ── Methods ──
        public void CopyTo(){} // RVA: 0x6D583F0
        public void GetAndValidateSize(){} // RVA: 0x6D585B0
    }

    public class StreamMemoryBlockProvider : MemoryBlockProvider
    {
        public object _stream;
        public object _streamGuard;
        public object _leaveOpen;
        public object _useMemoryMap;
        public object _isFileStream;
        public object _imageStart;
        public object _imageSize;
        public object _lazyMemoryMap;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6D541A0
        public void Dispose(){} // RVA: 0x6D542D0
        public void get_Size(){} // RVA: 0xB9E080
        public void ReadMemoryBlockNoLock(){} // RVA: 0x6D54390
        public void GetMemoryBlockImpl(){} // RVA: 0x6D54610
        public void GetStream(){} // RVA: 0x6D547D0
        public void TryCreateMemoryMappedFileBlock(){} // RVA: 0x6D548C0
    }

}