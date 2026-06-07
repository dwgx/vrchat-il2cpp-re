// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Buffers
// Classes: 18
// Methods: 79

namespace ThirdParty.DotNet.System.Buffers
{
    public class ArrayBufferWriter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void get_WrittenMemory(){} // RVA: 0x283FA0
        public void get_WrittenCount(){} // RVA: 0xD840
        public void get_FreeCapacity(){} // RVA: 0xD840
        public void Clear(){} // RVA: 0x24A50
        public void Advance(){} // RVA: 0x24FA0
        public void GetMemory(){} // RVA: 0x283FA0
        public void CheckAndResizeBuffer(){} // RVA: 0x24FA0
        public void ThrowInvalidOperationException_AdvancedTooFar(){} // RVA: 0x25E50
        public void ThrowOutOfMemoryException(){} // RVA: 0x25E50
    }

    public class ArrayPoolEventSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E0F040
        public void BufferRented(){} // RVA: 0x5E0F0D0
        public void BufferAllocated(){} // RVA: 0x5E0F160
        public void BufferReturned(){} // RVA: 0x5E0F200
        public void BufferTrimmed(){} // RVA: 0x5E0F230
        public void BufferTrimPoll(){} // RVA: 0x5E0F260
        public void .cctor(){} // RVA: 0x5E0F380
    }

    public class ArrayPool`1
    {
        // ── Methods ──
        public void get_Shared(){} // RVA: 0xC960
        public void Create(){}
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void .ctor(){} // RVA: 0x24A50
        public void .cctor(){} // RVA: 0x24A80
    }

    public class BuffersExtensions
    {
        // ── Methods ──
        public void CopyTo(){} // RVA: 0x283FA0
        public void CopyToMultiSegment(){} // RVA: 0x283FA0
        public void ToArray(){} // RVA: 0xCE50
    }

    public class ConfigurableArrayPool`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x26EE0
        public void get_Id(){} // RVA: 0xD840
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
    }

    public class DefaultArrayPool`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x26EE0 | overloaded x2
        public void get_Id(){} // RVA: 0xD840
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
    }

    public class IBufferWriter`1
    {
        // ── Methods ──
        public void Advance(){} // RVA: 0x24FA0
        public void GetMemory(){} // RVA: 0x283FA0
        public void GetSpan(){} // RVA: 0x283FA0
    }

    public class IPinnable
    {
        // ── Methods ──
        public void Unpin(){} // RVA: 0x24A50
    }

    public class MemoryHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E0F4B0
        public void get_Pointer(){} // RVA: 0x1AD4690
        public void Dispose(){} // RVA: 0x5E0F510
    }

    public class MemoryManager`1
    {
        // ── Methods ──
        public void get_Memory(){} // RVA: 0x283FA0
        public void GetSpan(){} // RVA: 0x283FA0
        public void Pin(){}
        public void TryGetArray(){} // RVA: 0xDE40
    }

    public class ReadOnlySequence
    {
        // ── Methods ──
        public void ArrayToSequenceStart(){} // RVA: 0x20C5210
        public void ArrayToSequenceEnd(){} // RVA: 0x5E0F630
    }

    public class ReadOnlySequenceDebugView`1
    {
    }

    public class ReadOnlySequenceSegment`1
    {
        public object Memory;
        public object Next;
        public object RunningIndex;

        // ── Methods ──
        public void get_Memory(){} // RVA: 0x283FA0
        public void get_Next(){} // RVA: 0xCD60
        public void get_RunningIndex(){} // RVA: 0xCD60
    }

    public class ReadOnlySequence`1
    {
        public object System.Threading.Tasks;
    }

    public class SpanAction`2
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x283FA0
    }

    public class StandardFormat
    {
        // ── Methods ──
        public void get_Symbol(){} // RVA: 0x1E40360
        public void get_Precision(){} // RVA: 0x1E40380
        public void get_HasPrecision(){} // RVA: 0x5E0F640
        public void get_IsDefault(){} // RVA: 0x5E0F650
        public void .ctor(){} // RVA: 0x5E0F660
        public void op_Implicit(){} // RVA: 0x5E0F690
        public void Parse(){} // RVA: 0x5E0F700 | overloaded x2
        public void ParseHelper(){} // RVA: 0x5E0F780
        public void Equals(){} // RVA: 0x5E0FA50 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5E0FA40
        public void ToString(){} // RVA: 0x5E0FA70
        public void Format(){} // RVA: 0x5E0FB80
    }

    public class TlsOverPerCoreLockedStacksArrayPool`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void CreatePerCoreLockedStacks(){} // RVA: 0x1BCC0
        public void get_Id(){} // RVA: 0xD840
        public void Rent(){} // RVA: 0x1BCC0
        public void Return(){} // RVA: 0x2A620
        public void Trim(){} // RVA: 0xDBE0
        public void Gen2GcCallbackFunc(){} // RVA: 0xDCC0
        public void GetMemoryPressure(){} // RVA: 0x283FA0
        public void GetTrimBuffers(){} // RVA: 0xDC10
        public void .cctor(){} // RVA: 0x24A80
    }

    public class Utilities
    {
        // ── Methods ──
        public void SelectBucketIndex(){} // RVA: 0x2ABFA50
        public void GetMaxSizeForBucket(){} // RVA: 0x5E0F620
    }

}