// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Buffers
// Classes: 69
// Methods: 362

namespace ThirdParty.DotNet.System.Buffers
{
    public class ArrayBufferWriter`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void get_WrittenMemory(){} // RVA: 0x7ffaa887e5c0
        public void get_WrittenCount(){} // RVA: 0x7ffaa8649ca0
        public void get_FreeCapacity(){} // RVA: 0x7ffaa8649ca0
        public void Clear(){} // RVA: 0x7ffaa8660cc0
        public void Advance(){} // RVA: 0x7ffaa8661210
        public void ThrowInvalidOperationException_AdvancedTooFar(){} // RVA: 0x7ffaa8662110
        public void ThrowOutOfMemoryException(){} // RVA: 0x7ffaa8662110
        // ── Binary Analysis Named ──
        public void GetMemory(){} // RVA: 0x7ffaa887e5c0
        public void CheckAndResizeBuffer(){} // RVA: 0x7ffaa8661210
    }

    public class ArrayBufferWriter`1 : Object
    {
        public object _buffer; // 0x30CE3870

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8661210
        public void .ctor(){} // RVA: 0x7ffaa8661210
        public void get_WrittenMemory(){} // RVA: 0x7ffaa887e5c0
        public void get_WrittenSpan(){} // RVA: 0x7ffaa887e5c0
        public void get_WrittenCount(){} // RVA: 0x7ffaa8649ca0
        public void get_Capacity(){} // RVA: 0x7ffaa8649ca0
        public void get_FreeCapacity(){} // RVA: 0x7ffaa8649ca0
        public void Clear(){} // RVA: 0x7ffaa8660cc0
        public void ResetWrittenCount(){} // RVA: 0x7ffaa8660cc0
        public void Advance(){} // RVA: 0x7ffaa8661210
        public void ThrowInvalidOperationException_AdvancedTooFar(){} // RVA: 0x7ffaa8662110
        public void ThrowOutOfMemoryException(){} // RVA: 0x7ffaa8662110
        // ── Binary Analysis Named ──
        public void GetMemory(){} // RVA: 0x7ffaa887e5c0
        public void GetSpan(){} // RVA: 0x7ffaa887e5c0
        public void CheckAndResizeBuffer(){} // RVA: 0x7ffaa8661210
    }

    public class ArrayBufferWriter`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8661210
        public void .ctor(){} // RVA: 0x7ffaa8661210
        public void get_WrittenSpan(){} // RVA: 0x7ffaa887e5c0
        public void get_WrittenCount(){} // RVA: 0x7ffaa8649ca0
        public void get_FreeCapacity(){} // RVA: 0x7ffaa8649ca0
        public void Clear(){} // RVA: 0x7ffaa8660cc0
        public void Advance(){} // RVA: 0x7ffaa8661210
        public void ThrowInvalidOperationException_AdvancedTooFar(){} // RVA: 0x7ffaa8662110
        // ── Binary Analysis Named ──
        public void GetMemory(){} // RVA: 0x7ffaa887e5c0
        public void GetSpan(){} // RVA: 0x7ffaa887e5c0
        public void CheckAndResizeBuffer(){} // RVA: 0x7ffaa8661210
    }

    public class ArrayBufferWriter`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc57150
        public void .ctor(){} // RVA: 0x7ffaabc57150
        public void get_WrittenSpan(){} // RVA: 0x7ffaabc57240
        public void get_WrittenCount(){} // RVA: 0x7ffaa8b945a0
        public void get_FreeCapacity(){} // RVA: 0x7ffaa9f186b0
        public void Clear(){} // RVA: 0x7ffaabc57300
        public void Advance(){} // RVA: 0x7ffaabc57390
        public void ThrowInvalidOperationException_AdvancedTooFar(){} // RVA: 0x7ffaabc57780
        // ── Binary Analysis Named ──
        public void GetMemory(){} // RVA: 0x7ffaabc57440
        public void GetSpan(){} // RVA: 0x7ffaabc57540
        public void CheckAndResizeBuffer(){} // RVA: 0x7ffaabc57600
    }

    public class ArrayPoolEventSource : EventSource
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadfc78d0
        public void BufferRented(){} // RVA: 0x7ffaadfc7960
        public void BufferAllocated(){} // RVA: 0x7ffaadfc79f0
        public void BufferReturned(){} // RVA: 0x7ffaadfc7a90
        public void BufferTrimmed(){} // RVA: 0x7ffaadfc7ac0
        public void BufferTrimPoll(){} // RVA: 0x7ffaadfc7af0
        public void .cctor(){} // RVA: 0x7ffaadfc7c10
    }

    public class ArrayPool`1 : Object
    {
        // ── Original Methods ──
        public void get_Shared(){} // RVA: 0x7ffaa8648dd0
        public void Create(){}
        public void Rent(){} // RVA: 0x7ffaa8658120
        public void Return(){} // RVA: 0x7ffaa8666840
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
    }

    public class ArrayPool`1 : Object
    {
        // ── Original Methods ──
        public void get_Shared(){} // RVA: 0x7ffaa8648dd0
        public void EnsureSharedCreated(){} // RVA: 0x7ffaa8648dd0
        public void Create(){} // RVA: 0x7ffaa8648dd0
        public void Rent(){} // RVA: 0x7ffaa8658120
        public void Return(){} // RVA: 0x7ffaa8666840
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class ArrayPool`1 : Object
    {
        // ── Original Methods ──
        public void get_Shared(){} // RVA: 0x7ffaaa656420
        public void Create(){} // RVA: 0x7ffaabd9b8d0
        public void Rent(){} // RVA: 0x7ffaa8658120
        public void Return(){} // RVA: 0x7ffaa8666840
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaabd9b9a0
    }

    public class ArrayPool`1 : Object
    {
        // ── Original Methods ──
        public void get_Shared(){} // RVA: 0x7ffaabd9b640
        public void EnsureSharedCreated(){} // RVA: 0x7ffaabd9b6f0
        public void Create(){} // RVA: 0x7ffaabd9b820
        public void Rent(){} // RVA: 0x7ffaa8658120
        public void Return(){} // RVA: 0x7ffaa8666840
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ArrayPool`1 : Object
    {
        // ── Original Methods ──
        public void get_Shared(){} // RVA: 0x7ffaaa656420
        public void Create(){} // RVA: 0x7ffaabd9b8d0
        public void Rent(){} // RVA: 0x7ffaa8658120
        public void Return(){} // RVA: 0x7ffaa8666840
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaabd9b9a0
    }

    public class ArrayPool`1 : Object
    {
        // ── Original Methods ──
        public void get_Shared(){} // RVA: 0x7ffaaa656420
        public void Create(){} // RVA: 0x7ffaabd9a330
        public void Rent(){} // RVA: 0x7ffaa8658120
        public void Return(){} // RVA: 0x7ffaa8666840
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaabd9a3d0
    }

    public class ArrayPool`1 : Object
    {
    }

    public class ArrayPool`1 : Object
    {
    }

    public class ArrayPool`1 : Object
    {
    }

    public class ArrayPool`1 : Object
    {
        // ── Original Methods ──
        public void get_Shared(){} // RVA: 0x7ffaaa656420
        public void Create(){} // RVA: 0x7ffaabd99f90
        public void Rent(){} // RVA: 0x7ffaa8658120
        public void Return(){} // RVA: 0x7ffaa8666840
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaabd9a030
    }

    public class ArrayPool`1 : Object
    {
        // ── Original Methods ──
        public void get_Shared(){} // RVA: 0x7ffaaa656420
        public void Create(){} // RVA: 0x7ffaabd9ab60
        public void Rent(){} // RVA: 0x7ffaa8658120
        public void Return(){} // RVA: 0x7ffaa8666840
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaabd9ac00
    }

    public class ArrayPool`1 : Object
    {
        // ── Original Methods ──
        public void get_Shared(){} // RVA: 0x7ffaaa656420
        public void Create(){} // RVA: 0x7ffaabd980a0
        public void Rent(){} // RVA: 0x7ffaa8658120
        public void Return(){} // RVA: 0x7ffaa8666840
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaabd98140
    }

    public class ArrayPool`1 : Object
    {
    }

    public class ArrayPool`1 : Object
    {
        // ── Original Methods ──
        public void get_Shared(){} // RVA: 0x7ffaaa656420
        public void Create(){} // RVA: 0x7ffaabd99b00
        public void Rent(){} // RVA: 0x7ffaa8658120
        public void Return(){} // RVA: 0x7ffaa8666840
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaabd99ba0
    }

    public class ArrayPool`1 : Object
    {
        // ── Original Methods ──
        public void get_Shared(){} // RVA: 0x7ffaaa656420
        public void Create(){} // RVA: 0x7ffaabd987e0
        public void Rent(){} // RVA: 0x7ffaa8658120
        public void Return(){} // RVA: 0x7ffaa8666840
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaabd98880
    }

    public class ArrayPool`1 : Object
    {
    }

    public class ArrayPool`1 : Object
    {
        // ── Original Methods ──
        public void get_Shared(){} // RVA: 0x7ffaaa656420
        public void Create(){} // RVA: 0x7ffaabd96e80
        public void Rent(){} // RVA: 0x7ffaa8658120
        public void Return(){} // RVA: 0x7ffaa8666840
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaabd96f20
    }

    public class ArrayPool`1 : Object
    {
        // ── Original Methods ──
        public void get_Shared(){} // RVA: 0x7ffaaa656420
        public void Create(){} // RVA: 0x7ffaabd9ab60
        public void Rent(){} // RVA: 0x7ffaa8658120
        public void Return(){} // RVA: 0x7ffaa8666840
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaabd9ac00
    }

    public class ArrayPool`1 : Object
    {
    }

    public class ArrayPool`1 : Object
    {
        // ── Original Methods ──
        public void get_Shared(){} // RVA: 0x7ffaaa656420
        public void Create(){} // RVA: 0x7ffaabd96e80
        public void Rent(){} // RVA: 0x7ffaa8658120
        public void Return(){} // RVA: 0x7ffaa8666840
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaabd96f20
    }

    public class ArrayPool`1 : Object
    {
        // ── Original Methods ──
        public void get_Shared(){} // RVA: 0x7ffaaa656420
        public void Create(){} // RVA: 0x7ffaabd9ab60
        public void Rent(){} // RVA: 0x7ffaa8658120
        public void Return(){} // RVA: 0x7ffaa8666840
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaabd9ac00
    }

    public class ArrayPool`1 : Object
    {
    }

    public class BuffersExtensions : Object
    {
        // ── Original Methods ──
        public void CopyTo(){} // RVA: 0x7ffaa887e5c0
        public void CopyToMultiSegment(){} // RVA: 0x7ffaa887e5c0
        public void ToArray(){} // RVA: 0x7ffaa86492c0
    }

    public class BuffersExtensions : Object
    {
        // ── Original Methods ──
        public void CopyTo(){} // RVA: 0x7ffaa887e5c0
        public void CopyToMultiSegment(){} // RVA: 0x7ffaa887e5c0
        public void ToArray(){} // RVA: 0x7ffaa86492c0
    }

    public class ConfigurableArrayPool`1 : ArrayPool`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa86631a0
        public void get_Id(){} // RVA: 0x7ffaa8649ca0
        public void Rent(){} // RVA: 0x7ffaa8658120
        public void Return(){} // RVA: 0x7ffaa8666840
    }

    public class ConfigurableArrayPool`1 : ArrayPool`1
    {
    }

    public class ConfigurableArrayPool`1 : ArrayPool`1
    {
    }

    public class ConfigurableArrayPool`1 : ArrayPool`1
    {
    }

    public class ConfigurableArrayPool`1 : ArrayPool`1
    {
    }

    public class ConfigurableArrayPool`1 : ArrayPool`1
    {
    }

    public class ConfigurableArrayPool`1 : ArrayPool`1
    {
    }

    public class ConfigurableArrayPool`1 : ArrayPool`1
    {
    }

    public class ConfigurableArrayPool`1 : ArrayPool`1
    {
    }

    public class ConfigurableArrayPool`1 : ArrayPool`1
    {
    }

    public class ConfigurableArrayPool`1 : ArrayPool`1
    {
    }

    public class DefaultArrayPool`1 : ArrayPool`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa86631a0
        public void .ctor(){} // RVA: 0x7ffaa86631a0
        public void get_Id(){} // RVA: 0x7ffaa8649ca0
        public void Rent(){} // RVA: 0x7ffaa8658120
        public void Return(){} // RVA: 0x7ffaa8666840
    }

    public class IBufferWriter`1
    {
        // ── Original Methods ──
        public void Advance(){} // RVA: 0x7ffaa8661210
        // ── Binary Analysis Named ──
        public void GetMemory(){} // RVA: 0x7ffaa887e5c0
        public void GetSpan(){} // RVA: 0x7ffaa887e5c0
    }

    public class IBufferWriter`1
    {
        // ── Original Methods ──
        public void Advance(){} // RVA: 0x7ffaa8661210
        // ── Binary Analysis Named ──
        public void GetMemory(){} // RVA: 0x7ffaa887e5c0
    }

    public class IBufferWriter`1
    {
    }

    public class MemoryHandle : ValueType
    {
        public object _pinnable; // 0x31229C10
        public object Pointer; // 0x170008F4

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadfc7d40
        public void get_Pointer(){} // RVA: 0x7ffaa950bda0
        public void Dispose(){} // RVA: 0x7ffaadfc7da0
    }

    public class MemoryManager`1 : Object
    {
        // ── Original Methods ──
        public void get_Memory(){} // RVA: 0x7ffaa887e5c0
        public void Pin(){}
        public void TryGetArray(){} // RVA: 0x7ffaa864a2a0
        // ── Binary Analysis Named ──
        public void GetSpan(){} // RVA: 0x7ffaa887e5c0
    }

    public class MemoryManager`1 : Object
    {
        // ── Original Methods ──
        public void get_Memory(){} // RVA: 0x7ffaa887e5c0
        public void TryGetArray(){} // RVA: 0x7ffaa864a2a0
        // ── Binary Analysis Named ──
        public void GetSpan(){} // RVA: 0x7ffaa887e5c0
    }

    public class MemoryManager`1 : Object
    {
    }

    public class MemoryManager`1 : Object
    {
    }

    public class ReadOnlySequenceSegment`1 : Object
    {
        public object _runningIndex; // 0x312EA110, was: <RunningIndex>k__BackingField

        // ── Original Methods ──
        public void get_Memory(){} // RVA: 0x7ffaa887e5c0
        public void get_Next(){} // RVA: 0x7ffaa86491d0
        public void get_RunningIndex(){} // RVA: 0x7ffaa86491d0
    }

    public class ReadOnlySequenceSegment`1 : Object
    {
        public object _runningIndex; // 0x312EA290, was: <RunningIndex>k__BackingField

        // ── Original Methods ──
        public void get_Memory(){} // RVA: 0x7ffaa887e5c0
        public void get_Next(){} // RVA: 0x7ffaa86491d0
        public void get_RunningIndex(){} // RVA: 0x7ffaa86491d0
    }

    public class ReadOnlySequence`1 : ValueType
    {
    }

    public class ReadOnlySequence`1 : ValueType
    {
        public object _startInteger; // 0x30B2B670
        public object _startObject; // 0x84B2C980

        // ── Original Methods ──
        public void get_Length(){} // RVA: 0x7ffaa86491d0
        public void get_IsEmpty(){} // RVA: 0x7ffaa864a040
        public void get_IsSingleSegment(){} // RVA: 0x7ffaa864a040
        public void get_First(){} // RVA: 0x7ffaa887e5c0
        public void get_Start(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void Slice(){} // RVA: 0x7ffaa887e5c0
        public void Slice(){} // RVA: 0x7ffaa887e5c0
        public void Slice(){} // RVA: 0x7ffaa887e5c0
        public void ToString(){} // RVA: 0x7ffaa86491d0
        public void TryGet(){}
        public void TryGetBuffer(){}
        public void Seek(){} // RVA: 0x7ffaa887e5c0
        public void Seek(){} // RVA: 0x7ffaa887e5c0
        public void SeekMultiSegment(){} // RVA: 0x7ffaa887e5c0
        public void BoundsCheck(){} // RVA: 0x7ffaa887e5c0
        public void SliceImpl(){} // RVA: 0x7ffaa887e5c0
        public void SliceImpl(){} // RVA: 0x7ffaa887e5c0
        public void TryGetString(){}
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaa887e5c0
        public void GetPosition(){} // RVA: 0x7ffaa887e5c0
        public void GetFirstBuffer(){} // RVA: 0x7ffaa887e5c0
        public void GetFirstBufferSlow(){} // RVA: 0x7ffaa887e5c0
        public void GetEndPosition(){} // RVA: 0x7ffaa887e5c0
        public void GetSequenceType(){} // RVA: 0x7ffaa887e5c0
        public void GetIndex(){} // RVA: 0x7ffaa8650450
        public void GetIndex(){} // RVA: 0x7ffaa8650450
        public void GetLength(){} // RVA: 0x7ffaa86491d0
    }

    public class ReadOnlySequence`1 : ValueType
    {
        public object Empty; // 0x312EA410

        // ── Original Methods ──
        public void get_Length(){} // RVA: 0x7ffaa86491d0
        public void get_IsEmpty(){} // RVA: 0x7ffaa864a040
        public void get_IsSingleSegment(){} // RVA: 0x7ffaa864a040
        public void get_First(){} // RVA: 0x7ffaa887e5c0
        public void get_Start(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void Slice(){} // RVA: 0x7ffaa887e5c0
        public void Slice(){} // RVA: 0x7ffaa887e5c0
        public void ToString(){} // RVA: 0x7ffaa86491d0
        public void TryGet(){}
        public void TryGetBuffer(){}
        public void SeekMultiSegment(){} // RVA: 0x7ffaa887e5c0
        public void BoundsCheck(){} // RVA: 0x7ffaa887e5c0
        public void SliceImpl(){} // RVA: 0x7ffaa887e5c0
        public void TryGetString(){}
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        // ── Binary Analysis Named ──
        public void GetFirstBuffer(){} // RVA: 0x7ffaa887e5c0
        public void GetEndPosition(){} // RVA: 0x7ffaa887e5c0
        public void GetSequenceType(){} // RVA: 0x7ffaa887e5c0
        public void GetIndex(){} // RVA: 0x7ffaa8649d80
        public void GetLength(){} // RVA: 0x7ffaa86491d0
    }

    public class SpanAction`2 : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7ffaa887e5c0
    }

    public class SpanAction`2 : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac37c1f0
        public void Invoke(){} // RVA: 0x7ffaac37c2c0
    }

    public class SpanAction`2 : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac37c120
        public void Invoke(){} // RVA: 0x7ffaab6c19a0
    }

    public class StandardFormat : ValueType
    {
        // ── Original Methods ──
        public void get_Symbol(){} // RVA: 0x7ffaaa365870
        public void get_Precision(){} // RVA: 0x7ffaaa365890
        public void get_HasPrecision(){} // RVA: 0x7ffaadfc7ed0
        public void get_IsDefault(){} // RVA: 0x7ffaadfc7ee0
        public void .ctor(){} // RVA: 0x7ffaadfc7ef0
        public void op_Implicit(){} // RVA: 0x7ffaadfc7f20
        public void Parse(){} // RVA: 0x7ffaadfc7f90
        public void Parse(){} // RVA: 0x7ffaadfc7f90
        public void ParseHelper(){} // RVA: 0x7ffaadfc8010
        public void Equals(){} // RVA: 0x7ffaadfc82e0
        public void Equals(){} // RVA: 0x7ffaadfc82e0
        public void ToString(){} // RVA: 0x7ffaadfc8300
        public void Format(){} // RVA: 0x7ffaadfc8410
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaadfc82d0
    }

    public class TlsOverPerCoreLockedStacksArrayPool`1 : ArrayPool`1
    {
        public object t_tlsBuckets; // 0x31228030
        public object s_allTlsBuckets; // 0x31228030
        public object t_tlsBuckets; // 0x34FB6A10

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void CreatePerCoreLockedStacks(){} // RVA: 0x7ffaa8658120
        public void get_Id(){} // RVA: 0x7ffaa8649ca0
        public void Rent(){} // RVA: 0x7ffaa8658120
        public void Return(){} // RVA: 0x7ffaa8666840
        public void Trim(){} // RVA: 0x7ffaa864a040
        public void Gen2GcCallbackFunc(){} // RVA: 0x7ffaa864a120
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        // ── Binary Analysis Named ──
        public void GetMemoryPressure(){} // RVA: 0x7ffaa887e5c0
        public void GetTrimBuffers(){} // RVA: 0x7ffaa864a070
    }

    public class TlsOverPerCoreLockedStacksArrayPool`1 : ArrayPool`1
    {
        public object t_tlsBuckets; // 0x34FB6A10
        public object s_allTlsBuckets; // 0x34FB6A10

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac6d0700
        public void CreatePerCoreLockedStacks(){} // RVA: 0x7ffaac6d08b0
        public void get_Id(){} // RVA: 0x7ffaaae81700
        public void Rent(){} // RVA: 0x7ffaac6d09a0
        public void Return(){} // RVA: 0x7ffaac6d0ce0
        public void Trim(){} // RVA: 0x7ffaac6d1290
        public void Gen2GcCallbackFunc(){} // RVA: 0x7ffaac6d16b0
        public void .cctor(){} // RVA: 0x7ffaac6baff0
        // ── Binary Analysis Named ──
        public void GetMemoryPressure(){} // RVA: 0x7ffaac6d17c0
        public void GetTrimBuffers(){} // RVA: 0x7ffaa8a17850
    }

    public class TlsOverPerCoreLockedStacksArrayPool`1 : ArrayPool`1
    {
        public object t_tlsBuckets; // 0x357CE6A0
        public object s_allTlsBuckets; // 0x357CE6A0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac6c4b50
        public void CreatePerCoreLockedStacks(){} // RVA: 0x7ffaac6c4d00
        public void get_Id(){} // RVA: 0x7ffaaae81700
        public void Rent(){} // RVA: 0x7ffaac6c4df0
        public void Return(){} // RVA: 0x7ffaac6c5130
        public void Trim(){} // RVA: 0x7ffaac6c56e0
        public void Gen2GcCallbackFunc(){} // RVA: 0x7ffaac6c5b00
        public void .cctor(){} // RVA: 0x7ffaac6baff0
        // ── Binary Analysis Named ──
        public void GetMemoryPressure(){} // RVA: 0x7ffaac6c5c10
        public void GetTrimBuffers(){} // RVA: 0x7ffaa8a17850
    }

    public class TlsOverPerCoreLockedStacksArrayPool`1 : ArrayPool`1
    {
        public object t_tlsBuckets; // 0x35D677C0
        public object s_allTlsBuckets; // 0x35D677C0
        public object `Ǐf; // 0x1D0000

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac6d2920
        public void CreatePerCoreLockedStacks(){} // RVA: 0x7ffaac6d2ad0
        public void get_Id(){} // RVA: 0x7ffaaae81700
        public void Rent(){} // RVA: 0x7ffaac6d2bc0
        public void Return(){} // RVA: 0x7ffaac6d2f00
        public void Trim(){} // RVA: 0x7ffaac6d34b0
        public void Gen2GcCallbackFunc(){} // RVA: 0x7ffaac6d38d0
        public void .cctor(){} // RVA: 0x7ffaac6baff0
        // ── Binary Analysis Named ──
        public void GetMemoryPressure(){} // RVA: 0x7ffaac6d39e0
        public void GetTrimBuffers(){} // RVA: 0x7ffaa8a17850
    }

    public class TlsOverPerCoreLockedStacksArrayPool`1 : ArrayPool`1
    {
        public object t_tlsBuckets; // 0x35E8B2C8
        public object s_allTlsBuckets; // 0x35E8B2C8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac6cf5f0
        public void CreatePerCoreLockedStacks(){} // RVA: 0x7ffaac6cf7a0
        public void get_Id(){} // RVA: 0x7ffaaae81700
        public void Rent(){} // RVA: 0x7ffaac6cf890
        public void Return(){} // RVA: 0x7ffaac6cfbd0
        public void Trim(){} // RVA: 0x7ffaac6d0180
        public void Gen2GcCallbackFunc(){} // RVA: 0x7ffaac6d05a0
        public void .cctor(){} // RVA: 0x7ffaac6baff0
        // ── Binary Analysis Named ──
        public void GetMemoryPressure(){} // RVA: 0x7ffaac6d06b0
        public void GetTrimBuffers(){} // RVA: 0x7ffaa8a17850
    }

    public class TlsOverPerCoreLockedStacksArrayPool`1 : ArrayPool`1
    {
        public object t_tlsBuckets; // 0x3683ADE0
        public object s_allTlsBuckets; // 0x3683ADE0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac6c8f90
        public void CreatePerCoreLockedStacks(){} // RVA: 0x7ffaac6c9140
        public void get_Id(){} // RVA: 0x7ffaaae81700
        public void Rent(){} // RVA: 0x7ffaac6c9230
        public void Return(){} // RVA: 0x7ffaac6c9570
        public void Trim(){} // RVA: 0x7ffaac6c9b20
        public void Gen2GcCallbackFunc(){} // RVA: 0x7ffaac6c9f40
        public void .cctor(){} // RVA: 0x7ffaac6baff0
        // ── Binary Analysis Named ──
        public void GetMemoryPressure(){} // RVA: 0x7ffaac6ca050
        public void GetTrimBuffers(){} // RVA: 0x7ffaa8a17850
    }

    public class TlsOverPerCoreLockedStacksArrayPool`1 : ArrayPool`1
    {
        public object t_tlsBuckets; // 0x37C98A48
        public object s_allTlsBuckets; // 0x37C98A48

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac6b9ee0
        public void CreatePerCoreLockedStacks(){} // RVA: 0x7ffaac6ba090
        public void get_Id(){} // RVA: 0x7ffaaae81700
        public void Rent(){} // RVA: 0x7ffaac6ba180
        public void Return(){} // RVA: 0x7ffaac6ba4c0
        public void Trim(){} // RVA: 0x7ffaac6baa70
        public void Gen2GcCallbackFunc(){} // RVA: 0x7ffaac6bae90
        public void .cctor(){} // RVA: 0x7ffaac6baff0
        // ── Binary Analysis Named ──
        public void GetMemoryPressure(){} // RVA: 0x7ffaac6bafa0
        public void GetTrimBuffers(){} // RVA: 0x7ffaa8a17850
    }

    public class TlsOverPerCoreLockedStacksArrayPool`1 : ArrayPool`1
    {
        public object t_tlsBuckets; // 0x37CA5310
        public object s_allTlsBuckets; // 0x37CA5310

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac6d5c50
        public void CreatePerCoreLockedStacks(){} // RVA: 0x7ffaac6d5e00
        public void get_Id(){} // RVA: 0x7ffaaae81700
        public void Rent(){} // RVA: 0x7ffaac6d5ef0
        public void Return(){} // RVA: 0x7ffaac6d6230
        public void Trim(){} // RVA: 0x7ffaac6d6820
        public void Gen2GcCallbackFunc(){} // RVA: 0x7ffaac6d6c40
        public void .cctor(){} // RVA: 0x7ffaac6baff0
        // ── Binary Analysis Named ──
        public void GetMemoryPressure(){} // RVA: 0x7ffaac6d6d50
        public void GetTrimBuffers(){} // RVA: 0x7ffaa8a17850
    }

    public class TlsOverPerCoreLockedStacksArrayPool`1 : ArrayPool`1
    {
        public object t_tlsBuckets; // 0x37F75620
        public object s_allTlsBuckets; // 0x37F75620

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac6b9ee0
        public void CreatePerCoreLockedStacks(){} // RVA: 0x7ffaac6ba090
        public void get_Id(){} // RVA: 0x7ffaaae81700
        public void Rent(){} // RVA: 0x7ffaac6ba180
        public void Return(){} // RVA: 0x7ffaac6ba4c0
        public void Trim(){} // RVA: 0x7ffaac6baa70
        public void Gen2GcCallbackFunc(){} // RVA: 0x7ffaac6bae90
        public void .cctor(){} // RVA: 0x7ffaac6baff0
        // ── Binary Analysis Named ──
        public void GetMemoryPressure(){} // RVA: 0x7ffaac6bafa0
        public void GetTrimBuffers(){} // RVA: 0x7ffaa8a17850
    }

    public class TlsOverPerCoreLockedStacksArrayPool`1 : ArrayPool`1
    {
        public object t_tlsBuckets; // 0x39CBB5D8
        public object s_allTlsBuckets; // 0x39CBB5D8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac6d5c50
        public void CreatePerCoreLockedStacks(){} // RVA: 0x7ffaac6d5e00
        public void get_Id(){} // RVA: 0x7ffaaae81700
        public void Rent(){} // RVA: 0x7ffaac6d5ef0
        public void Return(){} // RVA: 0x7ffaac6d6230
        public void Trim(){} // RVA: 0x7ffaac6d6820
        public void Gen2GcCallbackFunc(){} // RVA: 0x7ffaac6d6c40
        public void .cctor(){} // RVA: 0x7ffaac6baff0
        // ── Binary Analysis Named ──
        public void GetMemoryPressure(){} // RVA: 0x7ffaac6d6d50
        public void GetTrimBuffers(){} // RVA: 0x7ffaa8a17850
    }

    public class TlsOverPerCoreLockedStacksArrayPool`1 : ArrayPool`1
    {
        public object t_tlsBuckets; // 0x39CC3498
        public object s_allTlsBuckets; // 0x39CC3498

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac6d5c50
        public void CreatePerCoreLockedStacks(){} // RVA: 0x7ffaac6d5e00
        public void get_Id(){} // RVA: 0x7ffaaae81700
        public void Rent(){} // RVA: 0x7ffaac6d5ef0
        public void Return(){} // RVA: 0x7ffaac6d6230
        public void Trim(){} // RVA: 0x7ffaac6d6820
        public void Gen2GcCallbackFunc(){} // RVA: 0x7ffaac6d6c40
        public void .cctor(){} // RVA: 0x7ffaac6baff0
        // ── Binary Analysis Named ──
        public void GetMemoryPressure(){} // RVA: 0x7ffaac6d6d50
        public void GetTrimBuffers(){} // RVA: 0x7ffaa8a17850
    }

}