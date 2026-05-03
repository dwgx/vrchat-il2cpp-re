// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Buffers
// Classes: 18
// Methods: 79

namespace ThirdParty.DotNet.System.Buffers
{
    public class ArrayBufferWriter`1 : Object
    {
        public T[] _buffer;
        public int _index;
        public object field_2; // 0x9C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void get_WrittenMemory(){} // RVA: 0x7FFE810A1420
        public void get_WrittenCount(){} // RVA: 0x7FFE80E2EDB0
        public void get_FreeCapacity(){} // RVA: 0x7FFE80E2EDB0
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Advance(){} // RVA: 0x7FFE80E46530
        public void GetMemory(){} // RVA: 0x7FFE810A1420
        public void CheckAndResizeBuffer(){} // RVA: 0x7FFE80E46530
        public void ThrowInvalidOperationException_AdvancedTooFar(){} // RVA: 0x7FFE80E47430
        public void ThrowOutOfMemoryException(){} // RVA: 0x7FFE80E47430
    }

    public class ArrayPoolEventSource : EventSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8694FE80
        public void BufferRented(){} // RVA: 0x7FFE8694FF10
        public void BufferAllocated(){} // RVA: 0x7FFE8694FFA0
        public void BufferReturned(){} // RVA: 0x7FFE86950040
        public void BufferTrimmed(){} // RVA: 0x7FFE86950070
        public void BufferTrimPoll(){} // RVA: 0x7FFE869500A0
        public void .cctor(){} // RVA: 0x7FFE869501C0
    }

    public class ArrayPool`1 : Object
    {
        public System.Buffers.ArrayPool`1<T> _shared;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0x7FFE80E2DEE0
        public void Create(){}
        public void Rent(){} // RVA: 0x7FFE80E3D230
        public void Return(){} // RVA: 0x7FFE80E4BC00
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class BuffersExtensions : Object
    {
        // ── Methods ──
        public void CopyTo(){} // RVA: 0x7FFE810A1420
        public void CopyToMultiSegment(){} // RVA: 0x7FFE810A1420
        public void ToArray(){} // RVA: 0x7FFE80E2E3D0
    }

    public class ConfigurableArrayPool`1 : ArrayPool`1
    {
        public Bucket<T>[] _buckets;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E484C0
        public void get_Id(){} // RVA: 0x7FFE80E2EDB0
        public void Rent(){} // RVA: 0x7FFE80E3D230
        public void Return(){} // RVA: 0x7FFE80E4BC00
    }

    public class DefaultArrayPool`1 : ArrayPool`1
    {
        public T[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E484C0 | overloaded x2
        public void get_Id(){} // RVA: 0x7FFE80E2EDB0
        public void Rent(){} // RVA: 0x7FFE80E3D230
        public void Return(){} // RVA: 0x7FFE80E4BC00
    }

    public class IBufferWriter`1
    {
        // ── Methods ──
        public void Advance(){} // RVA: 0x7FFE80E46530
        public void GetMemory(){} // RVA: 0x7FFE810A1420
        public void GetSpan(){} // RVA: 0x7FFE810A1420
    }

    public class IPinnable
    {
        // ── Methods ──
        public void Unpin(){} // RVA: 0x7FFE80E45FE0
    }

    public class MemoryHandle : ValueType
    {
        public void* _pointer; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869502F0
        public void get_Pointer(){} // RVA: 0x7FFE8284EF60
        public void Dispose(){} // RVA: 0x7FFE86950350
    }

    public class MemoryManager`1 : Object
    {
        // ── Methods ──
        public void get_Memory(){} // RVA: 0x7FFE810A1420
        public void GetSpan(){} // RVA: 0x7FFE810A1420
        public void Pin(){}
        public void TryGetArray(){} // RVA: 0x7FFE80E2F3B0
    }

    public class ReadOnlySequence : Object
    {
        // ── Methods ──
        public void ArrayToSequenceStart(){} // RVA: 0x7FFE82E53610
        public void ArrayToSequenceEnd(){} // RVA: 0x7FFE86950470
    }

    public class ReadOnlySequenceDebugView`1 : Object
    {
    }

    public class ReadOnlySequenceSegment`1 : Object
    {
        public System.ReadOnlyMemory`1<T> _memory;
        public System.Buffers.ReadOnlySequenceSegment`1<T> _next;
        public long _runningIndex;

        // ── Methods ──
        public void get_Memory(){} // RVA: 0x7FFE810A1420
        public void get_Next(){} // RVA: 0x7FFE80E2E2E0
        public void get_RunningIndex(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ReadOnlySequence`1 : ValueType
    {
        public object _startObject; // 0x10
        public object _endObject; // 0x18
        public int _startInteger; // 0x20
        public int _endInteger; // 0x24
        public System.Buffers.ReadOnlySequence`1<byte> Empty;
    }

    public class SpanAction`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class StandardFormat : ValueType
    {
        public byte _format; // 0x10
        public byte _precision; // 0x11
        public object 0; // 0x188
        public long field_3; // 0x39A8

        // ── Methods ──
        public void get_Symbol(){} // RVA: 0x7FFE82BC9920
        public void get_Precision(){} // RVA: 0x7FFE82BC9940
        public void get_HasPrecision(){} // RVA: 0x7FFE86950480
        public void get_IsDefault(){} // RVA: 0x7FFE86950490
        public void .ctor(){} // RVA: 0x7FFE869504A0
        public void op_Implicit(){} // RVA: 0x7FFE869504D0
        public void Parse(){} // RVA: 0x7FFE86950540 | overloaded x2
        public void ParseHelper(){} // RVA: 0x7FFE869505C0
        public void Equals(){} // RVA: 0x7FFE86950890 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86950880
        public void ToString(){} // RVA: 0x7FFE869508B0
        public void Format(){} // RVA: 0x7FFE869509C0
    }

    public class TlsOverPerCoreLockedStacksArrayPool`1 : ArrayPool`1
    {
        public int[] _bucketArraySizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void CreatePerCoreLockedStacks(){} // RVA: 0x7FFE80E3D230
        public void get_Id(){} // RVA: 0x7FFE80E2EDB0
        public void Rent(){} // RVA: 0x7FFE80E3D230
        public void Return(){} // RVA: 0x7FFE80E4BC00
        public void Trim(){} // RVA: 0x7FFE80E2F150
        public void Gen2GcCallbackFunc(){} // RVA: 0x7FFE80E2F230
        public void GetMemoryPressure(){} // RVA: 0x7FFE810A1420
        public void GetTrimBuffers(){} // RVA: 0x7FFE80E2F180
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class Utilities : Object
    {
        // ── Methods ──
        public void SelectBucketIndex(){} // RVA: 0x7FFE83783300
        public void GetMaxSizeForBucket(){} // RVA: 0x7FFE86950460
    }

}