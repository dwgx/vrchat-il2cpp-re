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
        public void GetHashCode64(){} // RVA: 0x7FFE80E2DEE0
        public void HashStringWithFNV1A64(){} // RVA: 0x7FFE87BF94A0
    }

    public class HashMapHelper`1 : ValueType
    {
        public byte* Ptr;

        // ── Methods ──
        public void CalcCapacityCeilPow2(){} // RVA: 0x7FFE80E35520
        public void GetBucketSize(){} // RVA: 0x7FFE80E35560
        public void get_IsCreated(){} // RVA: 0x7FFE80E2F150
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Init(){} // RVA: 0x7FFE810A1420
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void Alloc(){} // RVA: 0x7FFE810A1420
        public void Free(){} // RVA: 0x7FFE810A1420
        public void Resize(){} // RVA: 0x7FFE80E46530
        public void ResizeExact(){} // RVA: 0x7FFE80E484C0
        public void CalculateDataSize(){} // RVA: 0x7FFE810A1420
        public void GetBucket(){} // RVA: 0x7FFE80E33B00
        public void TryAdd(){} // RVA: 0x7FFE80E33B00
        public void Find(){} // RVA: 0x7FFE810A1420
        public void TryGetValue(){} // RVA: 0x7FFE810A1420
        public void TryRemove(){} // RVA: 0x7FFE810A1420
        public void GetKeyArray(){} // RVA: 0x7FFE810A1420
        public void GetValueArray(){} // RVA: 0x7FFE810A1420
    }

    public class KeyValue`2 : ValueType
    {
    }

    public class NativeArrayUnsafeUtility : Object
    {
        // ── Methods ──
        public void ConvertExistingDataToNativeArray(){} // RVA: 0x7FFE810A1420
        public void GetUnsafePtr(){} // RVA: 0x7FFE810A1420
        public void GetUnsafeReadOnlyPtr(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetUnsafeBufferPointerWithoutChecks(){} // RVA: 0x7FFE810A1420
    }

    public class NativeContainerAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NativeContainerIsAtomicWriteOnlyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NativeContainerIsReadOnlyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NativeContainerNeedsThreadIndexAttribute : Attribute
    {
    }

    public class NativeContainerSupportsDeallocateOnJobCompletionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NativeContainerSupportsDeferredConvertListToArray : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NativeContainerSupportsMinMaxWriteRestrictionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NativeDisableContainerSafetyRestrictionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NativeDisableUnsafePtrRestrictionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NativeListUnsafeUtility : Object
    {
        // ── Methods ──
        public void GetUnsafeReadOnlyPtr(){} // RVA: 0x7FFE810A1420
    }

    public class NativeSetClassTypeToNullOnScheduleAttribute : Attribute
    {
    }

    public class NativeSetThreadIndexAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NativeSliceUnsafeUtility : Object
    {
        // ── Methods ──
        public void ConvertExistingDataToNativeSlice(){} // RVA: 0x7FFE810A1420
        public void GetUnsafePtr(){} // RVA: 0x7FFE810A1420
        public void GetUnsafeReadOnlyPtr(){} // RVA: 0x7FFE810A1420
    }

    public class UnsafeBitArray : ValueType
    {
        public ulong* Ptr; // 0x10

        // ── Methods ──
        public void Free(){} // RVA: 0x7FFE878BD230
        public void get_IsCreated(){} // RVA: 0x7FFE8412EC80
        public void Dispose(){} // RVA: 0x7FFE878BD340
    }

    public class UnsafeBitArrayDebugView : Object
    {
    }

    public class UnsafeDisposeJob : ValueType
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE878BD480
    }

    public class UnsafeHashMapDebuggerTypeProxy`2 : Object
    {
    }

    public class UnsafeHashMap`2 : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.HashMapHelper`1<T> m_Data;

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void get_IsCreated(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class UnsafeListExtensions : Object
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFE810A1420
        public void Contains(){} // RVA: 0x7FFE810A1420
    }

    public class UnsafeListTDebugView`1 : Object
    {
    }

    public class UnsafeList`1 : ValueType
    {
        public U* Ptr;
        public int m_length;
        public int m_capacity;
        public AllocatorHandle Allocator;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFE80E2EDB0
        public void set_Length(){} // RVA: 0x7FFE80E46530
        public void get_Capacity(){} // RVA: 0x7FFE80E2EDB0
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void ElementAt(){} // RVA: 0x7FFE80E3D230
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void Create(){} // RVA: 0x7FFE810A1420
        public void Destroy(){} // RVA: 0x7FFE810A1420
        public void get_IsCreated(){} // RVA: 0x7FFE80E2F150
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Resize(){} // RVA: 0x7FFE80E484C0
        public void ResizeExact(){} // RVA: 0x7FFE80E4D070
        public void SetCapacity(){} // RVA: 0x7FFE80E46530 | overloaded x2
        public void AddNoResize(){} // RVA: 0x7FFE810A1420
        public void Add(){} // RVA: 0x7FFE80E460A0
        public void AddRange(){} // RVA: 0x7FFE810A1420
        public void RemoveAtSwapBack(){} // RVA: 0x7FFE80E46530
        public void RemoveAt(){} // RVA: 0x7FFE80E46530
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class UnsafeParallelHashMapBase`2 : ValueType
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFE810A1420
        public void TryAdd(){} // RVA: 0x7FFE810A1420
        public void RemoveKeyValue(){} // RVA: 0x7FFE810A1420
        public void TryGetFirstValueAtomic(){} // RVA: 0x7FFE810A1420
        public void TryGetNextValueAtomic(){} // RVA: 0x7FFE810A1420
    }

    public class UnsafeParallelHashMapData : ValueType
    {
        public byte* values; // 0x10

        // ── Methods ──
        public void get_firstFreeTLS(){} // RVA: 0x7FFE85E285F0
        public void GetBucketSize(){} // RVA: 0x7FFE8412EC70
        public void GrowCapacity(){} // RVA: 0x7FFE878BD540
        public void AllocateHashMap(){} // RVA: 0x7FFE810A1420
        public void ReallocateHashMap(){} // RVA: 0x7FFE810A1420
        public void DeallocateHashMap(){} // RVA: 0x7FFE878BD550
        public void CalculateDataSize(){} // RVA: 0x7FFE810A1420
    }

    public class UnsafeParallelHashMapDataDispose : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE878BD630
    }

    public class UnsafeParallelHashMapDataDisposeJob : ValueType
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE878BD630
    }

    public class UnsafeParallelHashMapDebuggerTypeProxy`2 : Object
    {
    }

    public class UnsafeParallelHashMapDisposeJob : ValueType
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE878BD630
    }

    public class UnsafeParallelHashMap`2 : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* m_Buffer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void get_IsCreated(){} // RVA: 0x7FFE80E2F150
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void AsParallelWriter(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class UnsafeParallelMultiHashMapDebuggerTypeProxy`2 : Object
    {
    }

    public class UnsafeParallelMultiHashMap`2 : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* m_Buffer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Add(){} // RVA: 0x7FFE810A1420
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void TryGetFirstValue(){} // RVA: 0x7FFE810A1420
        public void TryGetNextValue(){} // RVA: 0x7FFE80E32650
        public void get_IsCreated(){} // RVA: 0x7FFE80E2F150
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class UnsafeRingQueueDebugView`1 : Object
    {
    }

    public class UnsafeRingQueue`1 : ValueType
    {
        public T* Ptr;

        // ── Methods ──
        public void Free(){} // RVA: 0x7FFE810A1420
        public void get_IsCreated(){} // RVA: 0x7FFE80E2F150
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class UnsafeStream : ValueType
    {
        public Block m_BlockData; // 0x10

        // ── Methods ──
        public void AllocateForEach(){} // RVA: 0x7FFE878BD680
        public void get_IsCreated(){} // RVA: 0x7FFE8412EC80
        public void Deallocate(){} // RVA: 0x7FFE878BD810
        public void Dispose(){} // RVA: 0x7FFE878B9FF0
    }

    public class UnsafeStreamBlock : ValueType
    {
    }

    public class UnsafeStreamBlockData : ValueType
    {
        // ── Methods ──
        public void Free(){} // RVA: 0x7FFE878BD640
    }

    public class UnsafeStreamRange : ValueType
    {
    }

    public class UnsafeText : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UntypedUnsafeList m_UntypedListData; // 0x10
        public object field_1; // 0x4E

        // ── Methods ──
        public void get_IsCreated(){} // RVA: 0x7FFE878BD960
        public void Free(){} // RVA: 0x7FFE878BD9D0
        public void Dispose(){} // RVA: 0x7FFE878BDAF0
        public void GetUnsafePtr(){} // RVA: 0x7FFE8284EF60
        public void get_Length(){} // RVA: 0x7FFE878BDB50
        public void ToString(){} // RVA: 0x7FFE878BDBD0
    }

    public class UnsafeTextExtensions : Object
    {
        // ── Methods ──
        public void AsUnsafeListOfBytes(){} // RVA: 0x7FFE878BD8D0
        public void AsUnsafeListOfBytesRO(){} // RVA: 0x7FFE878BD910
    }

    public class UnsafeUtility : Object
    {
        // ── Methods ──
        public void LeakRecord(){} // RVA: 0x7FFE87BF9530
        public void LeakErase(){} // RVA: 0x7FFE87BF95A0
        public void MallocTracked(){} // RVA: 0x7FFE87BF9600
        public void FreeTracked(){} // RVA: 0x7FFE87BF9680
        public void Malloc(){} // RVA: 0x7FFE87BF96E0
        public void Free(){} // RVA: 0x7FFE87BF9750
        public void MemCpy(){} // RVA: 0x7FFE87BF97B0
        public void MemCpyStride(){} // RVA: 0x7FFE87BF9820
        public void MemMove(){} // RVA: 0x7FFE87BF98A0
        public void MemSet(){} // RVA: 0x7FFE87BF9910
        public void MemClear(){} // RVA: 0x7FFE87BF9980
        public void MemCmp(){} // RVA: 0x7FFE87BF99E0
        public void SizeOf(){} // RVA: 0x7FFE80E2EDE0 | overloaded x2
        public void IsBlittable(){} // RVA: 0x7FFE87BF9AA0
        public void IsBlittableValueType(){} // RVA: 0x7FFE87BF9AF0
        public void GetReasonForTypeNonBlittableImpl(){} // RVA: 0x7FFE87BF9B80
        public void IsArrayBlittable(){} // RVA: 0x7FFE87BF9E20
        public void GetReasonForArrayNonBlittable(){} // RVA: 0x7FFE87BF9EE0
        public void AlignOf(){} // RVA: 0x7FFE80E2EDE0
        public void CopyPtrToStructure(){} // RVA: 0x7FFE810A1420
        public void InternalCopyPtrToStructure(){} // RVA: 0x7FFE810A1420
        public void CopyStructureToPtr(){} // RVA: 0x7FFE810A1420
        public void InternalCopyStructureToPtr(){} // RVA: 0x7FFE810A1420
        public void ReadArrayElement(){} // RVA: 0x7FFE810A1420
        public void ReadArrayElementWithStride(){} // RVA: 0x7FFE810A1420
        public void WriteArrayElement(){} // RVA: 0x7FFE810A1420
        public void WriteArrayElementWithStride(){} // RVA: 0x7FFE810A1420
        public void AddressOf(){} // RVA: 0x7FFE810A1420
        public void As(){} // RVA: 0x7FFE80E2E3D0
        public void AsRef(){} // RVA: 0x7FFE810A1420
        public void EnumToInt(){} // RVA: 0x7FFE810A1420
        public void InternalEnumToInt(){} // RVA: 0x7FFE80E462E0
        public void EnumEquals(){} // RVA: 0x7FFE810A1420
    }

    public class UntypedUnsafeList : ValueType
    {
    }

    public class WriteAccessRequiredAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}