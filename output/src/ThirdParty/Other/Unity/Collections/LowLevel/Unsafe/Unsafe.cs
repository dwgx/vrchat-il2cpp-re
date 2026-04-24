// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Collections.LowLevel.Unsafe
// Classes: 31
// Methods: 147

namespace ThirdParty.Other.Unity.Collections.LowLevel.Unsafe
{
    public class BurstLike : Object
    {
    }

    public class BurstRuntime : Object
    {
        // ── Methods ──
        public void GetHashCode64(){} // RVA: 0x7FFD4E078A90
        public void HashStringWithFNV1A64(){} // RVA: 0x7FFD54C70F00
    }

    public class HashMapHelper`1 : ValueType
    {
        public byte* IsCreated; // 0x10
        public VRC.Dynamics.ChainId* Keys; // 0x18
        public int* Next; // 0x20
        public int* Buckets; // 0x28
        public int Count; // 0x30
        public int Capacity; // 0x34
        public int Log2MinGrowth; // 0x38
        public int BucketCapacity; // 0x3C
        public int AllocatedIndex; // 0x40
        public int FirstFreeIdx; // 0x44
        public int SizeOfTValue; // 0x48
        public AllocatorHandle Allocator; // 0x4C
        public int kMinimumCapacity;

        // ── Methods ──
        public void CalcCapacityCeilPow2(){} // RVA: 0x7FFD4E0800D0
        public void GetBucketSize(){} // RVA: 0x7FFD4E080110
        public void get_IsCreated(){} // RVA: 0x7FFD4E079D00
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Init(){} // RVA: 0x7FFD4E2ADC40
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void Alloc(){} // RVA: 0x7FFD4E2ADC40
        public void Free(){} // RVA: 0x7FFD4E2ADC40
        public void Resize(){} // RVA: 0x7FFD4E090ED0
        public void ResizeExact(){} // RVA: 0x7FFD4E092E60
        public void CalculateDataSize(){} // RVA: 0x7FFD4E2ADC40
        public void GetBucket(){} // RVA: 0x7FFD4E07E6B0
        public void TryAdd(){} // RVA: 0x7FFD4E07E6B0
        public void Find(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetValue(){} // RVA: 0x7FFD4E2ADC40
        public void TryRemove(){} // RVA: 0x7FFD4E2ADC40
        public void GetKeyArray(){} // RVA: 0x7FFD4E2ADC40
        public void GetValueArray(){} // RVA: 0x7FFD4E2ADC40
    }

    public class KeyValue`2 : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* m_Buffer;
        public int m_Index;
        public int m_Next;
    }

    public class NativeArrayUnsafeUtility : Object
    {
        // ── Methods ──
        public void ConvertExistingDataToNativeArray(){} // RVA: 0x7FFD4E2ADC40
        public void GetUnsafePtr(){} // RVA: 0x7FFD4E2ADC40
        public void GetUnsafeReadOnlyPtr(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetUnsafeBufferPointerWithoutChecks(){} // RVA: 0x7FFD4E2ADC40
    }

    public class NativeContainerAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class NativeContainerIsAtomicWriteOnlyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class NativeContainerIsReadOnlyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class NativeContainerNeedsThreadIndexAttribute : Attribute
    {
    }

    public class NativeContainerSupportsDeallocateOnJobCompletionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class NativeContainerSupportsDeferredConvertListToArray : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class NativeContainerSupportsMinMaxWriteRestrictionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class NativeDisableContainerSafetyRestrictionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class NativeDisableUnsafePtrRestrictionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class NativeListUnsafeUtility : Object
    {
        // ── Methods ──
        public void GetUnsafeReadOnlyPtr(){} // RVA: 0x7FFD4E2ADC40
    }

    public class NativeSetClassTypeToNullOnScheduleAttribute : Attribute
    {
    }

    public class NativeSetThreadIndexAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class NativeSliceUnsafeUtility : Object
    {
        // ── Methods ──
        public void ConvertExistingDataToNativeSlice(){} // RVA: 0x7FFD4E2ADC40
        public void GetUnsafePtr(){} // RVA: 0x7FFD4E2ADC40
        public void GetUnsafeReadOnlyPtr(){} // RVA: 0x7FFD4E2ADC40
    }

    public class UnsafeBitArray : ValueType
    {
        public ulong* IsCreated; // 0x10
        public int Length; // 0x18
        public int Capacity; // 0x1C
        public AllocatorHandle Allocator; // 0x20

        // ── Methods ──
        public void Free(){} // RVA: 0x7FFD54934AF0
        public void get_IsCreated(){} // RVA: 0x7FFD511E6CA0
        public void Dispose(){} // RVA: 0x7FFD54934C00
    }

    public class UnsafeDisposeJob : ValueType
    {
        public void* Ptr; // 0x10
        public AllocatorHandle Allocator; // 0x18

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFD54934D40
    }

    public class UnsafeHashMap`2 : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.HashMapHelper`1<T> IsCreated;

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void get_IsCreated(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class UnsafeListExtensions : Object
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
    }

    public class UnsafeList`1 : ValueType
    {
        public ChainRoot* Length; // 0x10
        public int Capacity; // 0x18
        public int Item; // 0x1C
        public AllocatorHandle IsCreated; // 0x20
        public int padding; // 0x24

        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void set_Length(){} // RVA: 0x7FFD4E090ED0
        public void get_Capacity(){} // RVA: 0x7FFD4E079960
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void ElementAt(){} // RVA: 0x7FFD4E087DE0
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Create(){} // RVA: 0x7FFD4E2ADC40
        public void Destroy(){} // RVA: 0x7FFD4E2ADC40
        public void get_IsCreated(){} // RVA: 0x7FFD4E079D00
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Resize(){} // RVA: 0x7FFD4E092E60
        public void ResizeExact(){} // RVA: 0x7FFD4E097970
        public void SetCapacity(){} // RVA: 0x7FFD4E090ED0 | overloaded x2
        public void AddNoResize(){} // RVA: 0x7FFD4E2ADC40
        public void Add(){} // RVA: 0x7FFD4E090A40
        public void AddRange(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveAtSwapBack(){} // RVA: 0x7FFD4E090ED0
        public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class UnsafeParallelHashMapBase`2 : ValueType
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFD4E2ADC40
        public void TryAdd(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveKeyValue(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetFirstValueAtomic(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNextValueAtomic(){} // RVA: 0x7FFD4E2ADC40
    }

    public class UnsafeParallelHashMapData : ValueType
    {
        public byte* firstFreeTLS; // 0x10
        public byte* keys; // 0x18
        public byte* next; // 0x20
        public byte* buckets; // 0x28
        public int keyCapacity; // 0x30
        public int bucketCapacityMask; // 0x34
        public int allocatedIndexLength; // 0x38

        // ── Methods ──
        public void get_firstFreeTLS(){} // RVA: 0x7FFD52E61BE0
        public void GetBucketSize(){} // RVA: 0x7FFD511E6C90
        public void GrowCapacity(){} // RVA: 0x7FFD54934E00
        public void AllocateHashMap(){} // RVA: 0x7FFD4E2ADC40
        public void ReallocateHashMap(){} // RVA: 0x7FFD4E2ADC40
        public void DeallocateHashMap(){} // RVA: 0x7FFD54934E10
        public void CalculateDataSize(){} // RVA: 0x7FFD4E2ADC40
    }

    public class UnsafeParallelHashMap`2 : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* IsCreated; // 0x10
        public AllocatorHandle m_AllocatorLabel; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void get_IsCreated(){} // RVA: 0x7FFD4E079D00
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void AsParallelWriter(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class UnsafeParallelMultiHashMap`2 : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* IsCreated; // 0x10
        public AllocatorHandle m_AllocatorLabel; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetFirstValue(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNextValue(){} // RVA: 0x7FFD4E07D200
        public void get_IsCreated(){} // RVA: 0x7FFD4E079D00
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class UnsafeRingQueue`1 : ValueType
    {
        public T* IsCreated;
        public AllocatorHandle Allocator;
        public int m_Capacity;
        public int m_Filled;
        public int m_Write;
        public int m_Read;

        // ── Methods ──
        public void Free(){} // RVA: 0x7FFD4E2ADC40
        public void get_IsCreated(){} // RVA: 0x7FFD4E079D00
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class UnsafeStream : ValueType
    {
        public Block IsCreated; // 0x10

        // ── Methods ──
        public void AllocateForEach(){} // RVA: 0x7FFD54934F40
        public void get_IsCreated(){} // RVA: 0x7FFD511E6CA0
        public void Deallocate(){} // RVA: 0x7FFD549350D0
        public void Dispose(){} // RVA: 0x7FFD549318B0
    }

    public class UnsafeText : ValueType
    {
        public ÌÎÍÏ IsCreated; // 0x10

        // ── Methods ──
        public void get_IsCreated(){} // RVA: 0x7FFD54935220
        public void Free(){} // RVA: 0x7FFD54935290
        public void Dispose(){} // RVA: 0x7FFD549353B0
        public void GetUnsafePtr(){} // RVA: 0x7FFD4EEF9F60
        public void get_Length(){} // RVA: 0x7FFD54935410
        public void ToString(){} // RVA: 0x7FFD54935490
    }

    public class UnsafeUtility : Object
    {
        // ── Methods ──
        public void LeakRecord(){} // RVA: 0x7FFD54C70F90
        public void LeakErase(){} // RVA: 0x7FFD54C71000
        public void MallocTracked(){} // RVA: 0x7FFD54C71060
        public void FreeTracked(){} // RVA: 0x7FFD54C710E0
        public void Malloc(){} // RVA: 0x7FFD54C71140
        public void Free(){} // RVA: 0x7FFD54C711B0
        public void MemCpy(){} // RVA: 0x7FFD54C71210
        public void MemCpyStride(){} // RVA: 0x7FFD54C71280
        public void MemMove(){} // RVA: 0x7FFD54C71300
        public void MemSet(){} // RVA: 0x7FFD54C71370
        public void MemClear(){} // RVA: 0x7FFD54C713E0
        public void MemCmp(){} // RVA: 0x7FFD54C71440
        public void SizeOf(){} // RVA: 0x7FFD4E079990 | overloaded x2
        public void IsBlittable(){} // RVA: 0x7FFD54C71500
        public void IsBlittableValueType(){} // RVA: 0x7FFD54C71550
        public void GetReasonForTypeNonBlittableImpl(){} // RVA: 0x7FFD54C715E0
        public void IsArrayBlittable(){} // RVA: 0x7FFD54C71880
        public void GetReasonForArrayNonBlittable(){} // RVA: 0x7FFD54C71940
        public void AlignOf(){} // RVA: 0x7FFD4E079990
        public void CopyPtrToStructure(){} // RVA: 0x7FFD4E2ADC40
        public void InternalCopyPtrToStructure(){} // RVA: 0x7FFD4E2ADC40
        public void CopyStructureToPtr(){} // RVA: 0x7FFD4E2ADC40
        public void InternalCopyStructureToPtr(){} // RVA: 0x7FFD4E2ADC40
        public void ReadArrayElement(){} // RVA: 0x7FFD4E2ADC40
        public void ReadArrayElementWithStride(){} // RVA: 0x7FFD4E2ADC40
        public void WriteArrayElement(){} // RVA: 0x7FFD4E2ADC40
        public void WriteArrayElementWithStride(){} // RVA: 0x7FFD4E2ADC40
        public void AddressOf(){} // RVA: 0x7FFD4E2ADC40
        public void As(){} // RVA: 0x7FFD4E078F80
        public void AsRef(){} // RVA: 0x7FFD4E2ADC40
        public void EnumToInt(){} // RVA: 0x7FFD4E2ADC40
        public void InternalEnumToInt(){} // RVA: 0x7FFD4E090C80
        public void EnumEquals(){} // RVA: 0x7FFD4E2ADC40
    }

}