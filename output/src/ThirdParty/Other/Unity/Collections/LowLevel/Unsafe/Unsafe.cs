// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Collections.LowLevel.Unsafe
// Classes: 46
// Methods: 154

namespace ThirdParty.Other.Unity.Collections.LowLevel.Unsafe
{
    public class BurstLike : Object
    {
    }

    public class BurstRuntime : Object
    {
        // ── Methods ──
        public void GetHashCode64(){} // RVA: 0x7FFAC2C58A90
        public void HashStringWithFNV1A64(){} // RVA: 0x7FFAC9850F00
    }

    public class HashMapHelper`1 : ValueType
    {
        public byte* IsCreated;
        public T* Keys;
        public int* Next;
        public int* Buckets;
        public int Count;
        public int Capacity;
        public int Log2MinGrowth;
        public int BucketCapacity;
        public int AllocatedIndex;
        public int FirstFreeIdx;
        public int SizeOfTValue;
        public AllocatorHandle Allocator;
        public int kMinimumCapacity;

        // ── Methods ──
        public void CalcCapacityCeilPow2(){} // RVA: 0x7FFAC2C600D0
        public void GetBucketSize(){} // RVA: 0x7FFAC2C60110
        public void get_IsCreated(){} // RVA: 0x7FFAC2C59D00
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Init(){} // RVA: 0x7FFAC2E8DC40
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void Alloc(){} // RVA: 0x7FFAC2E8DC40
        public void Free(){} // RVA: 0x7FFAC2E8DC40
        public void Resize(){} // RVA: 0x7FFAC2C70ED0
        public void ResizeExact(){} // RVA: 0x7FFAC2C72E60
        public void CalculateDataSize(){} // RVA: 0x7FFAC2E8DC40
        public void GetBucket(){} // RVA: 0x7FFAC2C5E6B0
        public void TryAdd(){} // RVA: 0x7FFAC2C5E6B0
        public void Find(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetValue(){} // RVA: 0x7FFAC2E8DC40
        public void TryRemove(){} // RVA: 0x7FFAC2E8DC40
        public void GetKeyArray(){} // RVA: 0x7FFAC2E8DC40
        public void GetValueArray(){} // RVA: 0x7FFAC2E8DC40
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
        public void ConvertExistingDataToNativeArray(){} // RVA: 0x7FFAC2E8DC40
        public void GetUnsafePtr(){} // RVA: 0x7FFAC2E8DC40
        public void GetUnsafeReadOnlyPtr(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetUnsafeBufferPointerWithoutChecks(){} // RVA: 0x7FFAC2E8DC40
    }

    public class NativeContainerAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NativeContainerIsAtomicWriteOnlyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NativeContainerIsReadOnlyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NativeContainerNeedsThreadIndexAttribute : Attribute
    {
    }

    public class NativeContainerSupportsDeallocateOnJobCompletionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NativeContainerSupportsDeferredConvertListToArray : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NativeContainerSupportsMinMaxWriteRestrictionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NativeDisableContainerSafetyRestrictionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NativeDisableUnsafePtrRestrictionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NativeListUnsafeUtility : Object
    {
        // ── Methods ──
        public void GetUnsafeReadOnlyPtr(){} // RVA: 0x7FFAC2E8DC40
    }

    public class NativeSetClassTypeToNullOnScheduleAttribute : Attribute
    {
    }

    public class NativeSetThreadIndexAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NativeSliceUnsafeUtility : Object
    {
        // ── Methods ──
        public void ConvertExistingDataToNativeSlice(){} // RVA: 0x7FFAC2E8DC40
        public void GetUnsafePtr(){} // RVA: 0x7FFAC2E8DC40
        public void GetUnsafeReadOnlyPtr(){} // RVA: 0x7FFAC2E8DC40
    }

    public class UnsafeBitArray : ValueType
    {
        public ulong* IsCreated; // 0x10
        public int Length; // 0x18
        public int Capacity; // 0x1C
        public AllocatorHandle Allocator; // 0x20

        // ── Methods ──
        public void Free(){} // RVA: 0x7FFAC9514AF0
        public void get_IsCreated(){} // RVA: 0x7FFAC5DC6CA0
        public void Dispose(){} // RVA: 0x7FFAC9514C00
    }

    public class UnsafeBitArrayDebugView : Object
    {
    }

    public class UnsafeDisposeJob : ValueType
    {
        public void* Ptr; // 0x10
        public AllocatorHandle Allocator; // 0x18

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAC9514D40
    }

    public class UnsafeHashMapDebuggerTypeProxy`2 : Object
    {
    }

    public class UnsafeHashMap`2 : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.HashMapHelper`1<T> IsCreated;

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void get_IsCreated(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class UnsafeListExtensions : Object
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFAC2E8DC40
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
    }

    public class UnsafeListTDebugView`1 : Object
    {
    }

    public class UnsafeList`1 : ValueType
    {
        public U* Length;
        public int Capacity;
        public int Item;
        public AllocatorHandle IsCreated;
        public int padding;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFAC2C59960
        public void set_Length(){} // RVA: 0x7FFAC2C70ED0
        public void get_Capacity(){} // RVA: 0x7FFAC2C59960
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void ElementAt(){} // RVA: 0x7FFAC2C67DE0
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void Create(){} // RVA: 0x7FFAC2E8DC40
        public void Destroy(){} // RVA: 0x7FFAC2E8DC40
        public void get_IsCreated(){} // RVA: 0x7FFAC2C59D00
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Resize(){} // RVA: 0x7FFAC2C72E60
        public void ResizeExact(){} // RVA: 0x7FFAC2C77970
        public void SetCapacity(){} // RVA: 0x7FFAC2C70ED0 | overloaded x2
        public void AddNoResize(){} // RVA: 0x7FFAC2E8DC40
        public void Add(){} // RVA: 0x7FFAC2C70A40
        public void AddRange(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveAtSwapBack(){} // RVA: 0x7FFAC2C70ED0
        public void RemoveAt(){} // RVA: 0x7FFAC2C70ED0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class UnsafeParallelHashMapBase`2 : ValueType
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFAC2E8DC40
        public void TryAdd(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveKeyValue(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetFirstValueAtomic(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNextValueAtomic(){} // RVA: 0x7FFAC2E8DC40
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
        public void get_firstFreeTLS(){} // RVA: 0x7FFAC7A41BE0
        public void GetBucketSize(){} // RVA: 0x7FFAC5DC6C90
        public void GrowCapacity(){} // RVA: 0x7FFAC9514E00
        public void AllocateHashMap(){} // RVA: 0x7FFAC2E8DC40
        public void ReallocateHashMap(){} // RVA: 0x7FFAC2E8DC40
        public void DeallocateHashMap(){} // RVA: 0x7FFAC9514E10
        public void CalculateDataSize(){} // RVA: 0x7FFAC2E8DC40
    }

    public class UnsafeParallelHashMapDataDispose : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* m_Buffer; // 0x10
        public AllocatorHandle m_AllocatorLabel; // 0x18

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAC9514EF0
    }

    public class UnsafeParallelHashMapDataDisposeJob : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapDataDispose Data; // 0x10

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAC9514EF0
    }

    public class UnsafeParallelHashMapDebuggerTypeProxy`2 : Object
    {
    }

    public class UnsafeParallelHashMapDisposeJob : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* Data; // 0x10
        public AllocatorHandle Allocator; // 0x18

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAC9514EF0
    }

    public class UnsafeParallelHashMap`2 : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* IsCreated;
        public AllocatorHandle m_AllocatorLabel;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void get_IsCreated(){} // RVA: 0x7FFAC2C59D00
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void AsParallelWriter(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class UnsafeParallelMultiHashMapDebuggerTypeProxy`2 : Object
    {
    }

    public class UnsafeParallelMultiHashMap`2 : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* IsCreated;
        public AllocatorHandle m_AllocatorLabel;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetFirstValue(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetNextValue(){} // RVA: 0x7FFAC2C5D200
        public void get_IsCreated(){} // RVA: 0x7FFAC2C59D00
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class UnsafeRingQueueDebugView`1 : Object
    {
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
        public void Free(){} // RVA: 0x7FFAC2E8DC40
        public void get_IsCreated(){} // RVA: 0x7FFAC2C59D00
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class UnsafeStream : ValueType
    {
        public Block IsCreated; // 0x10

        // ── Methods ──
        public void AllocateForEach(){} // RVA: 0x7FFAC9514F40
        public void get_IsCreated(){} // RVA: 0x7FFAC5DC6CA0
        public void Deallocate(){} // RVA: 0x7FFAC95150D0
        public void Dispose(){} // RVA: 0x7FFAC95118B0
    }

    public class UnsafeStreamBlock : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock* Next; // 0x10
        public <Data>e__FixedBuffer Data; // 0x18
    }

    public class UnsafeStreamBlockData : ValueType
    {
        public AllocatorHandle Allocator; // 0x10
        public Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock** Blocks; // 0x18
        public int BlockCount; // 0x20
        public Block Ranges; // 0x28
        public int RangeCount; // 0x48

        // ── Methods ──
        public void Free(){} // RVA: 0x7FFAC9514F00
    }

    public class UnsafeStreamRange : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock* Block; // 0x10
        public int OffsetInFirstBlock; // 0x18
        public int ElementCount; // 0x1C
        public int LastOffset; // 0x20
        public int NumberOfBlocks; // 0x24
    }

    public class UnsafeText : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UntypedUnsafeList IsCreated; // 0x10

        // ── Methods ──
        public void get_IsCreated(){} // RVA: 0x7FFAC9515220
        public void Free(){} // RVA: 0x7FFAC9515290
        public void Dispose(){} // RVA: 0x7FFAC95153B0
        public void GetUnsafePtr(){} // RVA: 0x7FFAC3AD9F60
        public void get_Length(){} // RVA: 0x7FFAC9515410
        public void ToString(){} // RVA: 0x7FFAC9515490
    }

    public class UnsafeTextExtensions : Object
    {
        // ── Methods ──
        public void AsUnsafeListOfBytes(){} // RVA: 0x7FFAC9515190
        public void AsUnsafeListOfBytesRO(){} // RVA: 0x7FFAC95151D0
    }

    public class UnsafeUtility : Object
    {
        // ── Methods ──
        public void LeakRecord(){} // RVA: 0x7FFAC9850F90
        public void LeakErase(){} // RVA: 0x7FFAC9851000
        public void MallocTracked(){} // RVA: 0x7FFAC9851060
        public void FreeTracked(){} // RVA: 0x7FFAC98510E0
        public void Malloc(){} // RVA: 0x7FFAC9851140
        public void Free(){} // RVA: 0x7FFAC98511B0
        public void MemCpy(){} // RVA: 0x7FFAC9851210
        public void MemCpyStride(){} // RVA: 0x7FFAC9851280
        public void MemMove(){} // RVA: 0x7FFAC9851300
        public void MemSet(){} // RVA: 0x7FFAC9851370
        public void MemClear(){} // RVA: 0x7FFAC98513E0
        public void MemCmp(){} // RVA: 0x7FFAC9851440
        public void SizeOf(){} // RVA: 0x7FFAC2C59990 | overloaded x2
        public void IsBlittable(){} // RVA: 0x7FFAC9851500
        public void IsBlittableValueType(){} // RVA: 0x7FFAC9851550
        public void GetReasonForTypeNonBlittableImpl(){} // RVA: 0x7FFAC98515E0
        public void IsArrayBlittable(){} // RVA: 0x7FFAC9851880
        public void GetReasonForArrayNonBlittable(){} // RVA: 0x7FFAC9851940
        public void AlignOf(){} // RVA: 0x7FFAC2C59990
        public void CopyPtrToStructure(){} // RVA: 0x7FFAC2E8DC40
        public void InternalCopyPtrToStructure(){} // RVA: 0x7FFAC2E8DC40
        public void CopyStructureToPtr(){} // RVA: 0x7FFAC2E8DC40
        public void InternalCopyStructureToPtr(){} // RVA: 0x7FFAC2E8DC40
        public void ReadArrayElement(){} // RVA: 0x7FFAC2E8DC40
        public void ReadArrayElementWithStride(){} // RVA: 0x7FFAC2E8DC40
        public void WriteArrayElement(){} // RVA: 0x7FFAC2E8DC40
        public void WriteArrayElementWithStride(){} // RVA: 0x7FFAC2E8DC40
        public void AddressOf(){} // RVA: 0x7FFAC2E8DC40
        public void As(){} // RVA: 0x7FFAC2C58F80
        public void AsRef(){} // RVA: 0x7FFAC2E8DC40
        public void EnumToInt(){} // RVA: 0x7FFAC2E8DC40
        public void InternalEnumToInt(){} // RVA: 0x7FFAC2C70C80
        public void EnumEquals(){} // RVA: 0x7FFAC2E8DC40
    }

    public class UntypedUnsafeList : ValueType
    {
        public void* Ptr; // 0x10
        public int m_length; // 0x18
        public int m_capacity; // 0x1C
        public AllocatorHandle Allocator; // 0x20
        public int padding; // 0x24
    }

    public class WriteAccessRequiredAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}