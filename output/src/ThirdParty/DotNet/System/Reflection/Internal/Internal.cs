// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Reflection.Internal
// Classes: 21
// Methods: 106

namespace ThirdParty.DotNet.System.Reflection.Internal
{
    public class AbstractMemoryBlock : Object
    {
        // ── Methods ──
        public void get_Pointer(){} // RVA: 0x7FFE810A1420
        public void get_Size(){} // RVA: 0x7FFE80E2EDB0
        public void GetReader(){} // RVA: 0x7FFE86E270C0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CriticalDisposableObject : CriticalFinalizerObject
    {
        // ── Methods ──
        public void Release(){} // RVA: 0x7FFE80E45FE0
        public void Dispose(){} // RVA: 0x7FFE86E26FE0
        public void Finalize(){} // RVA: 0x7FFE86E27050
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class EmptyArray`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class EncodingHelper : Object
    {
        // ── Methods ──
        public void DecodeUtf8(){} // RVA: 0x7FFE86E28A10
        public void DecodeUtf8Prefixed(){} // RVA: 0x7FFE86E28AF0
        public void AcquireBuffer(){} // RVA: 0x7FFE86E28D50
        public void ReleaseBuffer(){} // RVA: 0x7FFE86E28E00
        public void LoadGetStringPlatform(){} // RVA: 0x7FFE86E28EA0
        public void GetStringUsingCreateStringFromEncoding(){} // RVA: 0x7FFE86E296A0
        public void .cctor(){} // RVA: 0x7FFE86E29770
    }

    public class ExternalMemoryBlock : AbstractMemoryBlock
    {
        public object _memoryOwner; // 0x10
        public byte* _buffer; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86E27140
        public void Dispose(){} // RVA: 0x7FFE86E271B0
        public void get_Pointer(){} // RVA: 0x7FFE810FE7C0
        public void get_Size(){} // RVA: 0x7FFE8151D690
    }

    public class ExternalMemoryBlockProvider : MemoryBlockProvider
    {
        public byte* _memory; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE826F4900
        public void get_Size(){} // RVA: 0x7FFE813DB630
        public void GetMemoryBlockImpl(){} // RVA: 0x7FFE86E271C0
        public void GetStream(){} // RVA: 0x7FFE86E27290
        public void Dispose(){} // RVA: 0x7FFE86E273F0
    }

    public class FileStreamReadLightUp : Object
    {
        // ── Methods ──
        public void IsFileStream(){} // RVA: 0x7FFE86E29D20
        public void GetSafeFileHandle(){} // RVA: 0x7FFE86E29DB0
        public void TryReadFile(){} // RVA: 0x7FFE86E29E70
        public void .cctor(){} // RVA: 0x7FFE86E29FE0
    }

    public class Hash : Object
    {
        // ── Methods ──
        public void Combine(){} // RVA: 0x7FFE86E2A060
    }

    public class ImmutableByteArrayInterop : Object
    {
        // ── Methods ──
        public void DangerousCreateFromUnderlyingArray(){} // RVA: 0x7FFE86E2A070
    }

    public class LightUpHelper : Object
    {
        // ── Methods ──
        public void GetMethod(){} // RVA: 0x7FFE86E2A130
    }

    public class MemoryBlock : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A539F0
        public void CreateChecked(){} // RVA: 0x7FFE86E2A210
        public void CheckBounds(){} // RVA: 0x7FFE86E2A2D0
        public void GetMemoryBlockAt(){} // RVA: 0x7FFE86E2A300
        public void PeekByte(){} // RVA: 0x7FFE86E2A340
        public void PeekUInt32(){} // RVA: 0x7FFE86E2A370
        public void PeekCompressedInteger(){} // RVA: 0x7FFE86E2A3C0
        public void PeekUInt16(){} // RVA: 0x7FFE86E2A470
        public void PeekReferenceUnchecked(){} // RVA: 0x7FFE86E2A4B0
        public void PeekReference(){} // RVA: 0x7FFE86E2A520
        public void PeekHeapReference(){} // RVA: 0x7FFE86E2A5A0
        public void PeekUtf8(){} // RVA: 0x7FFE86E2A630
        public void PeekUtf8NullTerminated(){} // RVA: 0x7FFE86E2A770
        public void GetUtf8NullTerminatedLength(){} // RVA: 0x7FFE86E2A8F0
        public void CompareUtf8NullTerminatedStringWithAsciiString(){} // RVA: 0x7FFE86E2A950
        public void PeekBytes(){} // RVA: 0x7FFE86E2AA50
        public void IsOrderedByReferenceAscending(){} // RVA: 0x7FFE86E2AB60
        public void BuildPtrTable(){} // RVA: 0x7FFE86E2AC30
        public void ReadColumn(){} // RVA: 0x7FFE86E2AF20
        public void PeekHeapValueOffsetAndSize(){} // RVA: 0x7FFE86E2B000
    }

    public class MemoryBlockProvider : Object
    {
        // ── Methods ──
        public void GetMemoryBlock(){} // RVA: 0x7FFE86E27400
        public void GetMemoryBlockImpl(){}
        public void GetStream(){} // RVA: 0x7FFE80E2E390
        public void get_Size(){} // RVA: 0x7FFE80E2EDB0
        public void Dispose(){} // RVA: 0x7FFE86E27470 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class MemoryMapLightUp : Object
    {
        // ── Methods ──
        public void get_IsAvailable(){} // RVA: 0x7FFE811E0850
        public void CreateMemoryMap(){} // RVA: 0x7FFE86E2B140
        public void CreateViewAccessor(){} // RVA: 0x7FFE86E2B1E0
        public void TryGetSafeBufferAndPointerOffset(){} // RVA: 0x7FFE86E2B300
    }

    public class MemoryMappedFileBlock : AbstractMemoryBlock
    {
        public DisposableData _data; // 0x10
        public int _size; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86E274E0
        public void Dispose(){} // RVA: 0x7FFE86E275B0
        public void get_Pointer(){} // RVA: 0x7FFE8189B810
        public void get_Size(){} // RVA: 0x7FFE813DB630
    }

    public class NativeHeapMemoryBlock : AbstractMemoryBlock
    {
        public DisposableData _data; // 0x10
        public int _size; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86E27A20
        public void Dispose(){} // RVA: 0x7FFE86E275B0
        public void get_Pointer(){} // RVA: 0x7FFE8189BB90
        public void get_Size(){} // RVA: 0x7FFE813DB630
    }

    public class ObjectPool`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4D070 | overloaded x2
        public void CreateInstance(){} // RVA: 0x7FFE810A1420
        public void Allocate(){} // RVA: 0x7FFE810A1420
        public void Free(){} // RVA: 0x7FFE810A1420
    }

    public class PooledStringBuilder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86E2B440
        public void Free(){} // RVA: 0x7FFE86E2B550
        public void ToStringAndFree(){} // RVA: 0x7FFE86E2B5D0
        public void CreatePool(){} // RVA: 0x7FFE86E2B680
        public void GetInstance(){} // RVA: 0x7FFE86E2B840
        public void .cctor(){} // RVA: 0x7FFE86E2B8C0
    }

    public class ReadOnlyUnmanagedMemoryStream : Stream
    {
        public byte* _data; // 0x28
        public int _length; // 0x30
        public int _position; // 0x34
        public object field_3; // 0x7F
        public object field_4; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86E2BC50
        public void ReadByte(){} // RVA: 0x7FFE86E2BCC0
        public void Read(){} // RVA: 0x7FFE86E2BCF0
        public void Flush(){} // RVA: 0x7FFE810FB310
        public void get_CanRead(){} // RVA: 0x7FFE811E0850
        public void get_CanSeek(){} // RVA: 0x7FFE811E0850
        public void get_CanWrite(){} // RVA: 0x7FFE810FB320
        public void get_Length(){} // RVA: 0x7FFE86E2BDC0
        public void get_Position(){} // RVA: 0x7FFE86E2BDD0
        public void set_Position(){} // RVA: 0x7FFE86E2BDE0
        public void Seek(){} // RVA: 0x7FFE86E2BE00
        public void SetLength(){} // RVA: 0x7FFE86E2C000
        public void Write(){} // RVA: 0x7FFE86E2C040
    }

    public class StreamConstraints : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86E27CC0
    }

    public class StreamExtensions : Object
    {
        // ── Methods ──
        public void CopyTo(){} // RVA: 0x7FFE86E2C080
        public void GetAndValidateSize(){} // RVA: 0x7FFE86E2C240
    }

    public class StreamMemoryBlockProvider : MemoryBlockProvider
    {
        public System.IO.Stream _stream; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86E27D30
        public void Dispose(){} // RVA: 0x7FFE86E27E60
        public void get_Size(){} // RVA: 0x7FFE81156CD0
        public void ReadMemoryBlockNoLock(){} // RVA: 0x7FFE86E27F20
        public void GetMemoryBlockImpl(){} // RVA: 0x7FFE86E281A0
        public void GetStream(){} // RVA: 0x7FFE86E28380
        public void TryCreateMemoryMappedFileBlock(){} // RVA: 0x7FFE86E28470
    }

}