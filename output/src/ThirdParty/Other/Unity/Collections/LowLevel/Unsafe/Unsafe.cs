// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Collections.LowLevel.Unsafe
// Classes: 46
// Methods: 154

namespace ThirdParty.Other.Unity.Collections.LowLevel.Unsafe
{
    public class BurstLike
    {
    }

    public class BurstRuntime
    {
        // ── Methods ──
        public void GetHashCode64(){} // RVA: 0xC960
        public void HashStringWithFNV1A64(){} // RVA: 0x70B84C0
    }

    public class HashMapHelper`1
    {
        public object TableEntry;

        // ── Methods ──
        public void CalcCapacityCeilPow2(){} // RVA: 0x13FB0
        public void GetBucketSize(){} // RVA: 0x13FF0
        public void get_IsCreated(){} // RVA: 0xDBE0
        public void Clear(){} // RVA: 0x24A50
        public void Init(){} // RVA: 0x283FA0
        public void Dispose(){} // RVA: 0x24A50
        public void Alloc(){} // RVA: 0x283FA0
        public void Free(){} // RVA: 0x283FA0
        public void Resize(){} // RVA: 0x24FA0
        public void ResizeExact(){} // RVA: 0x26EE0
        public void CalculateDataSize(){} // RVA: 0x283FA0
        public void GetBucket(){} // RVA: 0x12590
        public void TryAdd(){} // RVA: 0x12590
        public void Find(){} // RVA: 0x283FA0
        public void TryGetValue(){} // RVA: 0x283FA0
        public void TryRemove(){} // RVA: 0x283FA0
        public void GetKeyArray(){} // RVA: 0x283FA0
        public void GetValueArray(){} // RVA: 0x283FA0
    }

    public class KeyValue`2
    {
    }

    public class NativeArrayUnsafeUtility
    {
        // ── Methods ──
        public void ConvertExistingDataToNativeArray(){} // RVA: 0x283FA0
        public void GetUnsafePtr(){} // RVA: 0x283FA0
        public void GetUnsafeReadOnlyPtr(){} // RVA: 0x283FA0 | overloaded x2
        public void GetUnsafeBufferPointerWithoutChecks(){} // RVA: 0x283FA0
    }

    public class NativeContainerAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NativeContainerIsAtomicWriteOnlyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NativeContainerIsReadOnlyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NativeContainerNeedsThreadIndexAttribute
    {
    }

    public class NativeContainerSupportsDeallocateOnJobCompletionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NativeContainerSupportsDeferredConvertListToArray
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NativeContainerSupportsMinMaxWriteRestrictionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NativeDisableContainerSafetyRestrictionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NativeDisableUnsafePtrRestrictionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NativeListUnsafeUtility
    {
        // ── Methods ──
        public void GetUnsafeReadOnlyPtr(){} // RVA: 0x283FA0
    }

    public class NativeSetClassTypeToNullOnScheduleAttribute
    {
    }

    public class NativeSetThreadIndexAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NativeSliceUnsafeUtility
    {
        // ── Methods ──
        public void ConvertExistingDataToNativeSlice(){} // RVA: 0x283FA0
        public void GetUnsafePtr(){} // RVA: 0x283FA0
        public void GetUnsafeReadOnlyPtr(){} // RVA: 0x283FA0
    }

    public class UnsafeBitArray
    {
        // ── Methods ──
        public void Free(){} // RVA: 0x6D7C390
        public void get_IsCreated(){} // RVA: 0x34C1790
        public void Dispose(){} // RVA: 0x6D7C4A0
    }

    public class UnsafeBitArrayDebugView
    {
    }

    public class UnsafeDisposeJob
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x6D7C5E0
    }

    public class UnsafeHashMapDebuggerTypeProxy`2
    {
    }

    public class UnsafeHashMap`2
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x24A50
        public void get_IsCreated(){} // RVA: 0xDBE0
        public void System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey,TValue>>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    }

    public class UnsafeListExtensions
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x283FA0
        public void Contains(){} // RVA: 0x283FA0
    }

    public class UnsafeListTDebugView`1
    {
    }

    public class UnsafeList`1
    {
        // ── Methods ──
        public void get_Length(){} // RVA: 0xD840
        public void set_Length(){} // RVA: 0x24FA0
        public void get_Capacity(){} // RVA: 0xD840
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void ElementAt(){} // RVA: 0x1BCC0
        public void .ctor(){} // RVA: 0x283FA0
        public void Create(){} // RVA: 0x283FA0
        public void Destroy(){} // RVA: 0x283FA0
        public void get_IsCreated(){} // RVA: 0xDBE0
        public void Dispose(){} // RVA: 0x24A50
        public void Clear(){} // RVA: 0x24A50
        public void Resize(){} // RVA: 0x26EE0
        public void ResizeExact(){} // RVA: 0x2BAA0
        public void SetCapacity(){} // RVA: 0x24FA0 | overloaded x2
        public void AddNoResize(){} // RVA: 0x283FA0
        public void Add(){} // RVA: 0x24B10
        public void AddRange(){} // RVA: 0x283FA0
        public void RemoveAtSwapBack(){} // RVA: 0x24FA0
        public void RemoveAt(){} // RVA: 0x24FA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
    }

    public class UnsafeParallelHashMapBase`2
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x283FA0
        public void TryAdd(){} // RVA: 0x283FA0
        public void RemoveKeyValue(){} // RVA: 0x283FA0
        public void TryGetFirstValueAtomic(){} // RVA: 0x283FA0
        public void TryGetNextValueAtomic(){} // RVA: 0x283FA0
    }

    public class UnsafeParallelHashMapData
    {
        // ── Methods ──
        public void get_firstFreeTLS(){} // RVA: 0x5358DA0
        public void GetBucketSize(){} // RVA: 0x34C1780
        public void GrowCapacity(){} // RVA: 0x6D7C6A0
        public void AllocateHashMap(){} // RVA: 0x283FA0
        public void ReallocateHashMap(){} // RVA: 0x283FA0
        public void DeallocateHashMap(){} // RVA: 0x6D7C6B0
        public void CalculateDataSize(){} // RVA: 0x283FA0
    }

    public class UnsafeParallelHashMapDataDispose
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x6D7C790
    }

    public class UnsafeParallelHashMapDataDisposeJob
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x6D7C790
    }

    public class UnsafeParallelHashMapDebuggerTypeProxy`2
    {
    }

    public class UnsafeParallelHashMapDisposeJob
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x6D7C790
    }

    public class UnsafeParallelHashMap`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void get_IsCreated(){} // RVA: 0xDBE0
        public void Clear(){} // RVA: 0x24A50
        public void Dispose(){} // RVA: 0x24A50
        public void AsParallelWriter(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    }

    public class UnsafeParallelMultiHashMapDebuggerTypeProxy`2
    {
    }

    public class UnsafeParallelMultiHashMap`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void Clear(){} // RVA: 0x24A50
        public void Add(){} // RVA: 0x283FA0
        public void Remove(){} // RVA: 0x283FA0
        public void TryGetFirstValue(){} // RVA: 0x283FA0
        public void TryGetNextValue(){} // RVA: 0x11120
        public void get_IsCreated(){} // RVA: 0xDBE0
        public void Dispose(){} // RVA: 0x24A50
        public void System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    }

    public class UnsafeRingQueueDebugView`1
    {
    }

    public class UnsafeRingQueue`1 : Allocator
    {
        // ── Methods ──
        public void Free(){} // RVA: 0x283FA0
        public void get_IsCreated(){} // RVA: 0xDBE0
        public void Dispose(){} // RVA: 0x24A50
    }

    public class UnsafeStream
    {
        // ── Methods ──
        public void AllocateForEach(){} // RVA: 0x6D7C7E0
        public void get_IsCreated(){} // RVA: 0x34C1790
        public void Deallocate(){} // RVA: 0x6D7C970
        public void Dispose(){} // RVA: 0x6D79150
    }

    public class UnsafeStreamBlock
    {
    }

    public class UnsafeStreamBlockData
    {
        // ── Methods ──
        public void Free(){} // RVA: 0x6D7C7A0
    }

    public class UnsafeStreamRange
    {
    }

    public class UnsafeText
    {
        // ── Methods ──
        public void get_IsCreated(){} // RVA: 0x6D7CAC0
        public void Free(){} // RVA: 0x6D7CB30
        public void Dispose(){} // RVA: 0x6D7CC50
        public void GetUnsafePtr(){} // RVA: 0x1AD4690
        public void get_Length(){} // RVA: 0x6D7CCB0
        public void ToString(){} // RVA: 0x6D7CD30
    }

    public class UnsafeTextExtensions
    {
        // ── Methods ──
        public void AsUnsafeListOfBytes(){} // RVA: 0x6D7CA30
        public void AsUnsafeListOfBytesRO(){} // RVA: 0x6D7CA70
    }

    public class UnsafeUtility
    {
        // ── Methods ──
        public void LeakRecord(){} // RVA: 0x70B8550
        public void LeakErase(){} // RVA: 0x70B85C0
        public void MallocTracked(){} // RVA: 0x70B8620
        public void FreeTracked(){} // RVA: 0x70B86A0
        public void Malloc(){} // RVA: 0x70B8700
        public void Free(){} // RVA: 0x70B8770
        public void MemCpy(){} // RVA: 0x70B87D0
        public void MemCpyStride(){} // RVA: 0x70B8840
        public void MemMove(){} // RVA: 0x70B88C0
        public void MemSet(){} // RVA: 0x70B8930
        public void MemClear(){} // RVA: 0x70B89A0
        public void MemCmp(){} // RVA: 0x70B8A00
        public void SizeOf(){} // RVA: 0xD870 | overloaded x2
        public void IsBlittable(){} // RVA: 0x70B8AC0
        public void IsBlittableValueType(){} // RVA: 0x70B8B10
        public void GetReasonForTypeNonBlittableImpl(){} // RVA: 0x70B8BA0
        public void IsArrayBlittable(){} // RVA: 0x70B8E40
        public void GetReasonForArrayNonBlittable(){} // RVA: 0x70B8F00
        public void AlignOf(){} // RVA: 0xD870
        public void CopyPtrToStructure(){} // RVA: 0x283FA0
        public void InternalCopyPtrToStructure(){} // RVA: 0x283FA0
        public void CopyStructureToPtr(){} // RVA: 0x283FA0
        public void InternalCopyStructureToPtr(){} // RVA: 0x283FA0
        public void ReadArrayElement(){} // RVA: 0x283FA0
        public void ReadArrayElementWithStride(){} // RVA: 0x283FA0
        public void WriteArrayElement(){} // RVA: 0x283FA0
        public void WriteArrayElementWithStride(){} // RVA: 0x283FA0
        public void AddressOf(){} // RVA: 0x283FA0
        public void As(){} // RVA: 0xCE50
        public void AsRef(){} // RVA: 0x283FA0
        public void EnumToInt(){} // RVA: 0x283FA0
        public void InternalEnumToInt(){} // RVA: 0x24D50
        public void EnumEquals(){} // RVA: 0x283FA0
    }

    public class UntypedUnsafeList
    {
    }

    public class WriteAccessRequiredAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

}