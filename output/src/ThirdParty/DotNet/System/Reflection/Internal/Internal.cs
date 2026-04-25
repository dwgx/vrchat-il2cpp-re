// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Reflection.Internal
// Classes: 21
// Methods: 106

namespace ThirdParty.DotNet.System.Reflection.Internal
{
    public class AbstractMemoryBlock : Object
    {
        public object Pointer;
        public object Size;

        // ── Methods ──
        public void get_Pointer(){} // RVA: 0x7FFAC2E8DC40
        public void get_Size(){} // RVA: 0x7FFAC2C59960
        public void GetReader(){} // RVA: 0x7FFAC8A7DA30
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CriticalDisposableObject : CriticalFinalizerObject
    {
        // ── Methods ──
        public void Release(){} // RVA: 0x7FFAC2C70980
        public void Dispose(){} // RVA: 0x7FFAC8A7D950
        public void Finalize(){} // RVA: 0x7FFAC8A7D9C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EmptyArray`1 : Object
    {
        public T[] Instance;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class EncodingHelper : Object
    {
        public System.Reflection.Internal.ObjectPool`1<byte[]> s_pool;
        public Encoding_GetString s_getStringPlatform; // 0x8

        // ── Methods ──
        public void DecodeUtf8(){} // RVA: 0x7FFAC8A7F380
        public void DecodeUtf8Prefixed(){} // RVA: 0x7FFAC8A7F460
        public void AcquireBuffer(){} // RVA: 0x7FFAC8A7F6C0
        public void ReleaseBuffer(){} // RVA: 0x7FFAC8A7F770
        public void LoadGetStringPlatform(){} // RVA: 0x7FFAC8A7F810
        public void GetStringUsingCreateStringFromEncoding(){} // RVA: 0x7FFAC8A80010
        public void .cctor(){} // RVA: 0x7FFAC8A800E0
    }

    public class ExternalMemoryBlock : AbstractMemoryBlock
    {
        public object Pointer; // 0x10
        public byte* Size; // 0x18
        public int _size; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8A7DAB0
        public void Dispose(){} // RVA: 0x7FFAC8A7DB20
        public void get_Pointer(){} // RVA: 0x7FFAC2F247C0
        public void get_Size(){} // RVA: 0x7FFAC30DBBE0
    }

    public class ExternalMemoryBlockProvider : MemoryBlockProvider
    {
        public byte* Size; // 0x10
        public int _size; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4420710
        public void get_Size(){} // RVA: 0x7FFAC3157800
        public void GetMemoryBlockImpl(){} // RVA: 0x7FFAC8A7DB30
        public void GetStream(){} // RVA: 0x7FFAC8A7DC00
        public void Dispose(){} // RVA: 0x7FFAC8A7DD60
    }

    public class FileStreamReadLightUp : Object
    {
        public bool readFileNotAvailable;

        // ── Methods ──
        public void IsFileStream(){} // RVA: 0x7FFAC8A80690
        public void GetSafeFileHandle(){} // RVA: 0x7FFAC8A80720
        public void TryReadFile(){} // RVA: 0x7FFAC8A807E0
        public void .cctor(){} // RVA: 0x7FFAC8A80950
    }

    public class Hash : Object
    {
        // ── Methods ──
        public void Combine(){} // RVA: 0x7FFAC8A809D0
    }

    public class ImmutableByteArrayInterop : Object
    {
        // ── Methods ──
        public void DangerousCreateFromUnderlyingArray(){} // RVA: 0x7FFAC8A809E0
    }

    public class LightUpHelper : Object
    {
        // ── Methods ──
        public void GetMethod(){} // RVA: 0x7FFAC8A80AA0
    }

    public class MemoryBlock : ValueType
    {
        public byte* Pointer; // 0x10
        public int Length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47EB650
        public void CreateChecked(){} // RVA: 0x7FFAC8A80B80
        public void CheckBounds(){} // RVA: 0x7FFAC8A80C40
        public void GetMemoryBlockAt(){} // RVA: 0x7FFAC8A80C70
        public void PeekByte(){} // RVA: 0x7FFAC8A80CB0
        public void PeekUInt32(){} // RVA: 0x7FFAC8A80CE0
        public void PeekCompressedInteger(){} // RVA: 0x7FFAC8A80D30
        public void PeekUInt16(){} // RVA: 0x7FFAC8A80DE0
        public void PeekReferenceUnchecked(){} // RVA: 0x7FFAC8A80E20
        public void PeekReference(){} // RVA: 0x7FFAC8A80E90
        public void PeekHeapReference(){} // RVA: 0x7FFAC8A80F10
        public void PeekUtf8(){} // RVA: 0x7FFAC8A80FA0
        public void PeekUtf8NullTerminated(){} // RVA: 0x7FFAC8A810E0
        public void GetUtf8NullTerminatedLength(){} // RVA: 0x7FFAC8A81260
        public void CompareUtf8NullTerminatedStringWithAsciiString(){} // RVA: 0x7FFAC8A812C0
        public void PeekBytes(){} // RVA: 0x7FFAC8A813C0
        public void IsOrderedByReferenceAscending(){} // RVA: 0x7FFAC8A814D0
        public void BuildPtrTable(){} // RVA: 0x7FFAC8A815A0
        public void ReadColumn(){} // RVA: 0x7FFAC8A81890
        public void PeekHeapValueOffsetAndSize(){} // RVA: 0x7FFAC8A81970
    }

    public class MemoryBlockProvider : Object
    {
        public object Size;

        // ── Methods ──
        public void GetMemoryBlock(){} // RVA: 0x7FFAC8A7DD70
        public void GetMemoryBlockImpl(){}
        public void GetStream(){} // RVA: 0x7FFAC2C58F40
        public void get_Size(){} // RVA: 0x7FFAC2C59960
        public void Dispose(){} // RVA: 0x7FFAC8A7DDE0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MemoryMapLightUp : Object
    {
        public object IsAvailable;

        // ── Methods ──
        public void get_IsAvailable(){} // RVA: 0x7FFAC3006850
        public void CreateMemoryMap(){} // RVA: 0x7FFAC8A81AB0
        public void CreateViewAccessor(){} // RVA: 0x7FFAC8A81B50
        public void TryGetSafeBufferAndPointerOffset(){} // RVA: 0x7FFAC8A81C70
    }

    public class MemoryMappedFileBlock : AbstractMemoryBlock
    {
        public DisposableData Pointer; // 0x10
        public int Size; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8A7DE50
        public void Dispose(){} // RVA: 0x7FFAC8A7DF20
        public void get_Pointer(){} // RVA: 0x7FFAC37735E0
        public void get_Size(){} // RVA: 0x7FFAC3157800
    }

    public class NativeHeapMemoryBlock : AbstractMemoryBlock
    {
        public DisposableData Pointer; // 0x10
        public int Size; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8A7E390
        public void Dispose(){} // RVA: 0x7FFAC8A7DF20
        public void get_Pointer(){} // RVA: 0x7FFAC3511350
        public void get_Size(){} // RVA: 0x7FFAC3157800
    }

    public class ObjectPool`1 : Object
    {
        public Element<T>[] _items;
        public System.Func`1<T> _factory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C77970 | overloaded x2
        public void CreateInstance(){} // RVA: 0x7FFAC2E8DC40
        public void Allocate(){} // RVA: 0x7FFAC2E8DC40
        public void Free(){} // RVA: 0x7FFAC2E8DC40
    }

    public class PooledStringBuilder : Object
    {
        public System.Text.StringBuilder Builder; // 0x10
        public System.Reflection.Internal.ObjectPool`1<System.Reflection.Internal.PooledStringBuilder> _pool; // 0x18
        public System.Reflection.Internal.ObjectPool`1<System.Reflection.Internal.PooledStringBuilder> s_poolInstance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8A81DB0
        public void Free(){} // RVA: 0x7FFAC8A81EC0
        public void ToStringAndFree(){} // RVA: 0x7FFAC8A81F40
        public void CreatePool(){} // RVA: 0x7FFAC8A81FF0
        public void GetInstance(){} // RVA: 0x7FFAC8A821B0
        public void .cctor(){} // RVA: 0x7FFAC8A82230
    }

    public class ReadOnlyUnmanagedMemoryStream : Stream
    {
        public byte* CanRead; // 0x28
        public int CanSeek; // 0x30
        public int CanWrite; // 0x34

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8A825C0
        public void ReadByte(){} // RVA: 0x7FFAC8A82630
        public void Read(){} // RVA: 0x7FFAC8A82660
        public void Flush(){} // RVA: 0x7FFAC2F21310
        public void get_CanRead(){} // RVA: 0x7FFAC3006850
        public void get_CanSeek(){} // RVA: 0x7FFAC3006850
        public void get_CanWrite(){} // RVA: 0x7FFAC2F21320
        public void get_Length(){} // RVA: 0x7FFAC8A82730
        public void get_Position(){} // RVA: 0x7FFAC8A82740
        public void set_Position(){} // RVA: 0x7FFAC8A82750
        public void Seek(){} // RVA: 0x7FFAC8A82770
        public void SetLength(){} // RVA: 0x7FFAC8A82970
        public void Write(){} // RVA: 0x7FFAC8A829B0
    }

    public class StreamConstraints : ValueType
    {
        public object GuardOpt; // 0x10
        public long ImageStart; // 0x18
        public int ImageSize; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8A7E630
    }

    public class StreamExtensions : Object
    {
        // ── Methods ──
        public void CopyTo(){} // RVA: 0x7FFAC8A829F0
        public void GetAndValidateSize(){} // RVA: 0x7FFAC8A82BB0
    }

    public class StreamMemoryBlockProvider : MemoryBlockProvider
    {
        public System.IO.Stream Size; // 0x10
        public object _streamGuard; // 0x18
        public bool _leaveOpen; // 0x20
        public bool _useMemoryMap; // 0x21
        public bool _isFileStream; // 0x22
        public long _imageStart; // 0x28
        public int _imageSize; // 0x30
        public System.IDisposable _lazyMemoryMap; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8A7E6A0
        public void Dispose(){} // RVA: 0x7FFAC8A7E7D0
        public void get_Size(){} // RVA: 0x7FFAC2F7CCD0
        public void ReadMemoryBlockNoLock(){} // RVA: 0x7FFAC8A7E890
        public void GetMemoryBlockImpl(){} // RVA: 0x7FFAC8A7EB10
        public void GetStream(){} // RVA: 0x7FFAC8A7ECF0
        public void TryCreateMemoryMappedFileBlock(){} // RVA: 0x7FFAC8A7EDE0
    }

}