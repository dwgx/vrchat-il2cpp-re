// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Buffers
// Classes: 14
// Methods: 74

namespace ThirdParty.DotNet.System.Buffers
{
    public class ArrayBufferWriter`1 : Object
    {
        public byte[] WrittenMemory; // 0x10
        public int WrittenCount; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void get_WrittenMemory(){} // RVA: 0x7FFD4E2ADC40
        public void get_WrittenCount(){} // RVA: 0x7FFD4E079960
        public void get_FreeCapacity(){} // RVA: 0x7FFD4E079960
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Advance(){} // RVA: 0x7FFD4E090ED0
        public void GetMemory(){} // RVA: 0x7FFD4E2ADC40
        public void CheckAndResizeBuffer(){} // RVA: 0x7FFD4E090ED0
        public void ThrowInvalidOperationException_AdvancedTooFar(){} // RVA: 0x7FFD4E091DD0
        public void ThrowOutOfMemoryException(){} // RVA: 0x7FFD4E091DD0
    }

    public class ArrayPoolEventSource : EventSource
    {
        public System.Buffers.ArrayPoolEventSource Log;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD539C66B0
        public void BufferRented(){} // RVA: 0x7FFD539C6740
        public void BufferAllocated(){} // RVA: 0x7FFD539C67D0
        public void BufferReturned(){} // RVA: 0x7FFD539C6870
        public void BufferTrimmed(){} // RVA: 0x7FFD539C68A0
        public void BufferTrimPoll(){} // RVA: 0x7FFD539C68D0
        public void .cctor(){} // RVA: 0x7FFD539C69F0
    }

    public class ArrayPool`1 : Object
    {
        public System.Buffers.ArrayPool`1<0x66560128> Shared;

        // ── Methods ──
        public void get_Shared(){} // RVA: 0x7FFD4E078A90
        public void Create(){}
        public void Rent(){} // RVA: 0x7FFD4E087DE0
        public void Return(){} // RVA: 0x7FFD4E096500
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class BuffersExtensions : Object
    {
        // ── Methods ──
        public void CopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void CopyToMultiSegment(){} // RVA: 0x7FFD4E2ADC40
        public void ToArray(){} // RVA: 0x7FFD4E078F80
    }

    public class ConfigurableArrayPool`1 : ArrayPool`1
    {
        public Bucket<0x665C6FB8<Transmtn.DTO.Notifications.Notification>>[] Id; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E092E60
        public void get_Id(){} // RVA: 0x7FFD4E079960
        public void Rent(){} // RVA: 0x7FFD4E087DE0
        public void Return(){} // RVA: 0x7FFD4E096500
    }

    public class DefaultArrayPool`1 : ArrayPool`1
    {
        public T[] Id;
        public Bucket<T>[] _buckets;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E092E60 | overloaded x2
        public void get_Id(){} // RVA: 0x7FFD4E079960
        public void Rent(){} // RVA: 0x7FFD4E087DE0
        public void Return(){} // RVA: 0x7FFD4E096500
    }

    public class IBufferWriter`1
    {
        // ── Methods ──
        public void Advance(){} // RVA: 0x7FFD4E090ED0
        public void GetMemory(){} // RVA: 0x7FFD4E2ADC40
        public void GetSpan(){} // RVA: 0x7FFD4E2ADC40
    }

    public class MemoryHandle : ValueType
    {
        public void* Pointer; // 0x10
        public System.Runtime.InteropServices.GCHandle _handle; // 0x18
        public 0x66440AD0 _pinnable; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD539C6B20
        public void get_Pointer(){} // RVA: 0x7FFD4EEF9F60
        public void Dispose(){} // RVA: 0x7FFD539C6B80
    }

    public class MemoryManager`1 : Object
    {
        public int Memory;

        // ── Methods ──
        public void get_Memory(){} // RVA: 0x7FFD4E2ADC40
        public void GetSpan(){} // RVA: 0x7FFD4E2ADC40
        public void Pin(){}
        public void TryGetArray(){} // RVA: 0x7FFD4E079F60
    }

    public class ReadOnlySequenceSegment`1 : Object
    {
        public System.ReadOnlyMemory`1<T> Memory;
        public System.Buffers.ReadOnlySequenceSegment`1<T> Next;
        public long RunningIndex;

        // ── Methods ──
        public void get_Memory(){} // RVA: 0x7FFD4E2ADC40
        public void get_Next(){} // RVA: 0x7FFD4E078E90
        public void get_RunningIndex(){} // RVA: 0x7FFD4E078E90
    }

    public class ReadOnlySequence`1 : ValueType
    {
        public System.SequencePosition _sequenceStart;
        public System.SequencePosition _sequenceEnd;
        public System.Buffers.ReadOnlySequence`1<T> Empty;
    }

    public class SpanAction`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class StandardFormat : ValueType
    {
        public byte Symbol; // 0x10
        public byte Precision; // 0x11

        // ── Methods ──
        public void get_Symbol(){} // RVA: 0x7FFD4FD7DDF0
        public void get_Precision(){} // RVA: 0x7FFD4FD7DE10
        public void get_HasPrecision(){} // RVA: 0x7FFD539C6CB0
        public void get_IsDefault(){} // RVA: 0x7FFD539C6CC0
        public void .ctor(){} // RVA: 0x7FFD539C6CD0
        public void op_Implicit(){} // RVA: 0x7FFD539C6D00
        public void Parse(){} // RVA: 0x7FFD539C6D70 | overloaded x2
        public void ParseHelper(){} // RVA: 0x7FFD539C6DF0
        public void Equals(){} // RVA: 0x7FFD539C70C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD539C70B0
        public void ToString(){} // RVA: 0x7FFD539C70E0
        public void Format(){} // RVA: 0x7FFD539C71F0
    }

    public class TlsOverPerCoreLockedStacksArrayPool`1 : ArrayPool`1
    {
        public int[] Id; // 0x10
        public PerCoreLockedStacks<0x665C6FB8<Transmtn.DTO.Notifications.Notification>>[] _buckets; // 0x18
        public 0x665C6FB8<Transmtn.DTO.Notifications.Notification>[][] t_tlsBuckets; // 0xFFFF
        public int _callbackCreated; // 0x20
        public bool s_trimBuffers;
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<0x665C6FB8<Transmtn.DTO.Notifications.Notification>[][],object> s_allTlsBuckets; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void CreatePerCoreLockedStacks(){} // RVA: 0x7FFD4E087DE0
        public void get_Id(){} // RVA: 0x7FFD4E079960
        public void Rent(){} // RVA: 0x7FFD4E087DE0
        public void Return(){} // RVA: 0x7FFD4E096500
        public void Trim(){} // RVA: 0x7FFD4E079D00
        public void Gen2GcCallbackFunc(){} // RVA: 0x7FFD4E079DE0
        public void GetMemoryPressure(){} // RVA: 0x7FFD4E2ADC40
        public void GetTrimBuffers(){} // RVA: 0x7FFD4E079D30
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

}