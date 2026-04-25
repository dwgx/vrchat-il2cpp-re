// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Buffers
// Classes: 18
// Methods: 79

namespace ThirdParty.DotNet.System.Buffers
{
    public class ArrayBufferWriter`1 : Object
    {
        public T[] WrittenMemory;
        public int WrittenCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void get_WrittenMemory(){} // RVA: 0x7FFAC2E8DC40
        public void get_WrittenCount(){} // RVA: 0x7FFAC2C59960
        public void get_FreeCapacity(){} // RVA: 0x7FFAC2C59960
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Advance(){} // RVA: 0x7FFAC2C70ED0
        public void GetMemory(){} // RVA: 0x7FFAC2E8DC40
        public void CheckAndResizeBuffer(){} // RVA: 0x7FFAC2C70ED0
        public void ThrowInvalidOperationException_AdvancedTooFar(){} // RVA: 0x7FFAC2C71DD0
        public void ThrowOutOfMemoryException(){} // RVA: 0x7FFAC2C71DD0
    }

    public class ArrayPoolEventSource : EventSource
    {
        public System.Buffers.ArrayPoolEventSource Log;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85A66B0
        public void BufferRented(){} // RVA: 0x7FFAC85A6740
        public void BufferAllocated(){} // RVA: 0x7FFAC85A67D0
        public void BufferReturned(){} // RVA: 0x7FFAC85A6870
        public void BufferTrimmed(){} // RVA: 0x7FFAC85A68A0
        public void BufferTrimPoll(){} // RVA: 0x7FFAC85A68D0
        public void .cctor(){} // RVA: 0x7FFAC85A69F0
    }

    public class ArrayPool`1 : Object
    {
        public System.Buffers.ArrayPool`1<T> Shared;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0x7FFAC2C58A90
        public void Create(){}
        public void Rent(){} // RVA: 0x7FFAC2C67DE0
        public void Return(){} // RVA: 0x7FFAC2C76500
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class BuffersExtensions : Object
    {
        // ── Methods ──
        public void CopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void CopyToMultiSegment(){} // RVA: 0x7FFAC2E8DC40
        public void ToArray(){} // RVA: 0x7FFAC2C58F80
    }

    public class ConfigurableArrayPool`1 : ArrayPool`1
    {
        public Bucket<T>[] Id;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C72E60
        public void get_Id(){} // RVA: 0x7FFAC2C59960
        public void Rent(){} // RVA: 0x7FFAC2C67DE0
        public void Return(){} // RVA: 0x7FFAC2C76500
    }

    public class DefaultArrayPool`1 : ArrayPool`1
    {
        public T[] Id;
        public Bucket<T>[] _buckets;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C72E60 | overloaded x2
        public void get_Id(){} // RVA: 0x7FFAC2C59960
        public void Rent(){} // RVA: 0x7FFAC2C67DE0
        public void Return(){} // RVA: 0x7FFAC2C76500
    }

    public class IBufferWriter`1
    {
        // ── Methods ──
        public void Advance(){} // RVA: 0x7FFAC2C70ED0
        public void GetMemory(){} // RVA: 0x7FFAC2E8DC40
        public void GetSpan(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IPinnable
    {
        // ── Methods ──
        public void Unpin(){} // RVA: 0x7FFAC2C70980
    }

    public class MemoryHandle : ValueType
    {
        public void* Pointer; // 0x10
        public System.Runtime.InteropServices.GCHandle _handle; // 0x18
        public System.Buffers.IPinnable _pinnable; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85A6B20
        public void get_Pointer(){} // RVA: 0x7FFAC3AD9F60
        public void Dispose(){} // RVA: 0x7FFAC85A6B80
    }

    public class MemoryManager`1 : Object
    {
        public object Memory;

        // ── Methods ──
        public void get_Memory(){} // RVA: 0x7FFAC2E8DC40
        public void GetSpan(){} // RVA: 0x7FFAC2E8DC40
        public void Pin(){}
        public void TryGetArray(){} // RVA: 0x7FFAC2C59F60
    }

    public class ReadOnlySequence : Object
    {
        // ── Methods ──
        public void ArrayToSequenceStart(){} // RVA: 0x7FFAC4BE6C10
        public void ArrayToSequenceEnd(){} // RVA: 0x7FFAC85A6CA0
    }

    public class ReadOnlySequenceDebugView`1 : Object
    {
    }

    public class ReadOnlySequenceSegment`1 : Object
    {
        public System.ReadOnlyMemory`1<T> Memory;
        public System.Buffers.ReadOnlySequenceSegment`1<T> Next;
        public long RunningIndex;

        // ── Methods ──
        public void get_Memory(){} // RVA: 0x7FFAC2E8DC40
        public void get_Next(){} // RVA: 0x7FFAC2C58E90
        public void get_RunningIndex(){} // RVA: 0x7FFAC2C58E90
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
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class StandardFormat : ValueType
    {
        public byte Symbol; // 0x10
        public byte Precision; // 0x11

        // ── Methods ──
        public void get_Symbol(){} // RVA: 0x7FFAC495DDF0
        public void get_Precision(){} // RVA: 0x7FFAC495DE10
        public void get_HasPrecision(){} // RVA: 0x7FFAC85A6CB0
        public void get_IsDefault(){} // RVA: 0x7FFAC85A6CC0
        public void .ctor(){} // RVA: 0x7FFAC85A6CD0
        public void op_Implicit(){} // RVA: 0x7FFAC85A6D00
        public void Parse(){} // RVA: 0x7FFAC85A6D70 | overloaded x2
        public void ParseHelper(){} // RVA: 0x7FFAC85A6DF0
        public void Equals(){} // RVA: 0x7FFAC85A70C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC85A70B0
        public void ToString(){} // RVA: 0x7FFAC85A70E0
        public void Format(){} // RVA: 0x7FFAC85A71F0
    }

    public class TlsOverPerCoreLockedStacksArrayPool`1 : ArrayPool`1
    {
        public int[] Id;
        public PerCoreLockedStacks<T>[] _buckets;
        public T[][] t_tlsBuckets; // 0xFFFF
        public int _callbackCreated;
        public bool s_trimBuffers;
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<T[][],object> s_allTlsBuckets;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void CreatePerCoreLockedStacks(){} // RVA: 0x7FFAC2C67DE0
        public void get_Id(){} // RVA: 0x7FFAC2C59960
        public void Rent(){} // RVA: 0x7FFAC2C67DE0
        public void Return(){} // RVA: 0x7FFAC2C76500
        public void Trim(){} // RVA: 0x7FFAC2C59D00
        public void Gen2GcCallbackFunc(){} // RVA: 0x7FFAC2C59DE0
        public void GetMemoryPressure(){} // RVA: 0x7FFAC2E8DC40
        public void GetTrimBuffers(){} // RVA: 0x7FFAC2C59D30
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class Utilities : Object
    {
        // ── Methods ──
        public void SelectBucketIndex(){} // RVA: 0x7FFAC54858F0
        public void GetMaxSizeForBucket(){} // RVA: 0x7FFAC85A6C90
    }

}