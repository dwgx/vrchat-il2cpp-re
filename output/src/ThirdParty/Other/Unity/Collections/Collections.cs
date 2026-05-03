// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Collections
// Classes: 96
// Methods: 372

namespace ThirdParty.Other.Unity.Collections
{
    public class AllocatorManager : Object
    {
        // ── Methods ──
        public void AllocateBlock(){} // RVA: 0x7FFE810A1420
        public void Allocate(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void AllocateStruct(){} // RVA: 0x7FFE810A1420
        public void FreeBlock(){} // RVA: 0x7FFE80E462E0
        public void Free(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void CheckDelegate(){} // RVA: 0x7FFE86204180
        public void UseDelegate(){} // RVA: 0x7FFE878B6DD0
        public void allocate_block(){} // RVA: 0x7FFE878B6E20
        public void forward_mono_allocate_block(){} // RVA: 0x7FFE878B6EC0
        public void LegacyOf(){} // RVA: 0x7FFE878B6FE0
        public void TryLegacy(){} // RVA: 0x7FFE878B6FF0
        public void Try(){} // RVA: 0x7FFE878B7190
        public void IsCustomAllocator(){} // RVA: 0x7FFE878B7500
        public void .cctor(){} // RVA: 0x7FFE878B7510
        public void Initialize$StackAllocator_Try_000000AB$BurstDirectCall(){} // RVA: 0x7FFE878B76D0
        public void Initialize$SlabAllocator_Try_000000B9$BurstDirectCall(){} // RVA: 0x7FFE878B7720
    }

    public class ArrayOfArrays`1 : ValueType
    {
        public AllocatorHandle m_backingAllocatorHandle;
        public int m_lengthInElements;
        public int m_capacityInElements;
        public int m_log2BlockSizeInElements;
        public int m_blocks;

        // ── Methods ──
        public void get_BlockSizeInElements(){} // RVA: 0x7FFE80E2EDB0
        public void get_BlockSizeInBytes(){} // RVA: 0x7FFE80E2EDB0
        public void get_BlockMask(){} // RVA: 0x7FFE80E2EDB0
        public void get_Length(){} // RVA: 0x7FFE80E2EDB0
        public void LockfreeAdd(){} // RVA: 0x7FFE810A1420
        public void get_Item(){} // RVA: 0x7FFE80E3D230
        public void Rewind(){} // RVA: 0x7FFE80E45FE0
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void RemoveAtSwapBack(){} // RVA: 0x7FFE80E46530
        public void BlockIndexOfElement(){} // RVA: 0x7FFE80E35520
        public void TrimExcess(){} // RVA: 0x7FFE80E45FE0
    }

    public class AutoFreeAllocator : ValueType
    {
        public Unity.Collections.ArrayOfArrays`1<UIntPtr> m_allocated; // 0x10

        // ── Methods ──
        public void Update(){} // RVA: 0x7FFE878B8D60
        public void FreeAll(){} // RVA: 0x7FFE878B8EC0
        public void Dispose(){} // RVA: 0x7FFE878B9010
        public void Try(){} // RVA: 0x7FFE878B9160 | overloaded x2
        public void get_Handle(){} // RVA: 0x7FFE8119C080
        public void Try$BurstManaged(){} // RVA: 0x7FFE878B91C0
    }

    public class CollectionHelper : Object
    {
        // ── Methods ──
        public void Align(){} // RVA: 0x7FFE878B9750
        public void Hash(){} // RVA: 0x7FFE878B9770
        public void ShouldDeallocate(){} // RVA: 0x7FFE878B97A0
        public void AssumePositive(){} // RVA: 0x7FFE82E53610
        public void CreateNativeArray(){} // RVA: 0x7FFE810A1420
    }

    public class DeallocateOnJobCompletionAttribute : Attribute
    {
    }

    public class ExcludeFromBurstCompatTestingAttribute : Attribute
    {
        public string _reason; // 0x10

        // ── Methods ──
        public void set_Reason(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class FixedBytes128Align8 : ValueType
    {
    }

    public class FixedBytes16Align8 : ValueType
    {
    }

    public class FixedBytes32Align8 : ValueType
    {
    }

    public class FixedBytes4096Align8 : ValueType
    {
    }

    public class FixedBytes512Align8 : ValueType
    {
    }

    public class FixedBytes64Align8 : ValueType
    {
    }

    public class FixedList : ValueType
    {
        // ── Methods ──
        public void PaddingBytes(){} // RVA: 0x7FFE80E2EDE0
    }

    public class FixedList128BytesDebugView`1 : Object
    {
    }

    public class FixedList128Bytes`1 : ValueType
    {
        public Unity.Collections.FixedBytes128Align8 data;
        public Unity.Collections.FixedBytes128Align8 data; // 0x10
        public Unity.Collections.FixedBytes16Align8 offset0000; // 0x10
        public Unity.Collections.FixedBytes16Align8 offset0016; // 0x20
        public Unity.Collections.FixedBytes16Align8 offset0032; // 0x30

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFE80E2E210
        public void get_buffer(){} // RVA: 0x7FFE810A1420
        public void get_Length(){} // RVA: 0x7FFE80E2EDB0
        public void get_LengthInBytes(){} // RVA: 0x7FFE80E2EDB0
        public void get_Buffer(){} // RVA: 0x7FFE810A1420
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void CompareTo(){} // RVA: 0x7FFE810A1420 | overloaded x5
        public void Equals(){} // RVA: 0x7FFE80E2F3B0 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class FixedList32BytesDebugView`1 : Object
    {
    }

    public class FixedList32Bytes`1 : ValueType
    {
        public Unity.Collections.FixedBytes32Align8 data;
        public Unity.Collections.FixedBytes32Align8 data; // 0x10
        public Unity.Collections.FixedBytes16Align8 offset0000; // 0x10
        public Unity.Collections.FixedBytes16Align8 offset0016; // 0x20
        public object field_4; // 0x1C68

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFE80E2E210
        public void get_buffer(){} // RVA: 0x7FFE810A1420
        public void get_Length(){} // RVA: 0x7FFE80E2EDB0
        public void get_LengthInBytes(){} // RVA: 0x7FFE80E2EDB0
        public void get_Buffer(){} // RVA: 0x7FFE810A1420
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void CompareTo(){} // RVA: 0x7FFE810A1420 | overloaded x5
        public void Equals(){} // RVA: 0x7FFE80E2F3B0 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class FixedList4096BytesDebugView`1 : Object
    {
    }

    public class FixedList4096Bytes`1 : ValueType
    {
        public Unity.Collections.FixedBytes4096Align8 data;
        public Unity.Collections.FixedBytes4096Align8 data; // 0x10
        public ulong byte0000; // 0x10
        public ulong byte0008; // 0x18
        public object field_4; // 0xB
        public object field_5; // 0xC

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFE80E2E210
        public void get_buffer(){} // RVA: 0x7FFE810A1420
        public void get_Length(){} // RVA: 0x7FFE80E2EDB0
        public void get_LengthInBytes(){} // RVA: 0x7FFE80E2EDB0
        public void get_Buffer(){} // RVA: 0x7FFE810A1420
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void CompareTo(){} // RVA: 0x7FFE810A1420 | overloaded x5
        public void Equals(){} // RVA: 0x7FFE80E2F3B0 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class FixedList512BytesDebugView`1 : Object
    {
    }

    public class FixedList512Bytes`1 : ValueType
    {
        public Unity.Collections.FixedBytes512Align8 data;
        public Unity.Collections.FixedBytes512Align8 data; // 0x10
        public Unity.Collections.FixedBytes16Align8 offset0000; // 0x10
        public Unity.Collections.FixedBytes16Align8 offset0016; // 0x20
        public Unity.Collections.FixedBytes16Align8 offset0032; // 0x30

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFE80E2E210
        public void get_buffer(){} // RVA: 0x7FFE810A1420
        public void get_Length(){} // RVA: 0x7FFE80E2EDB0
        public void get_LengthInBytes(){} // RVA: 0x7FFE80E2EDB0
        public void get_Buffer(){} // RVA: 0x7FFE810A1420
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void CompareTo(){} // RVA: 0x7FFE810A1420 | overloaded x5
        public void Equals(){} // RVA: 0x7FFE80E2F3B0 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class FixedList64BytesDebugView`1 : Object
    {
    }

    public class FixedList64Bytes`1 : ValueType
    {
        public Unity.Collections.FixedBytes64Align8 data;
        public Unity.Collections.FixedBytes64Align8 data; // 0x10
        public Unity.Collections.FixedBytes16Align8 offset0000; // 0x10
        public Unity.Collections.FixedBytes16Align8 offset0016; // 0x20
        public Unity.Collections.FixedBytes16Align8 offset0032; // 0x30

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFE80E2E210
        public void get_buffer(){} // RVA: 0x7FFE810A1420
        public void get_Length(){} // RVA: 0x7FFE80E2EDB0
        public void get_LengthInBytes(){} // RVA: 0x7FFE80E2EDB0
        public void get_Buffer(){} // RVA: 0x7FFE810A1420
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void CompareTo(){} // RVA: 0x7FFE810A1420 | overloaded x5
        public void Equals(){} // RVA: 0x7FFE80E2F3B0 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class FixedStringMethods : Object
    {
        // ── Methods ──
        public void ConvertToString(){} // RVA: 0x7FFE80E2E3D0
    }

    public class GenerateTestsForBurstCompatibilityAttribute : Attribute
    {
        public System.Type[] _genericTypeArguments; // 0x10

        // ── Methods ──
        public void set_GenericTypeArguments(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Hash128Long_00000A71$BurstDirectCall : Object
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFE878BCBA0
        public void GetFunctionPointer(){} // RVA: 0x7FFE878BCCE0
        public void Constructor(){} // RVA: 0x7FFE878BCE50
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE878BCE50
        public void Invoke(){} // RVA: 0x7FFE878BCF10
    }

    public class Hash128Long_00000A71$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE878BCAC0
        public void Invoke(){} // RVA: 0x7FFE83F99C10
    }

    public class Hash64Long_00000A6A$BurstDirectCall : Object
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFE878BC470
        public void GetFunctionPointer(){} // RVA: 0x7FFE878BC5B0
        public void Constructor(){} // RVA: 0x7FFE878BC720
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE878BC720
        public void Invoke(){} // RVA: 0x7FFE878BC7E0
    }

    public class Hash64Long_00000A6A$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8671A430
        public void Invoke(){} // RVA: 0x7FFE81998A70
    }

    public class IIndexable`1
    {
        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFE80E2EDB0
    }

    public class INativeList`1
    {
    }

    public class IUTF8Bytes
    {
        // ── Methods ──
        public void GetUnsafePtr(){} // RVA: 0x7FFE810A1420
    }

    public class KVPair`2 : ValueType
    {
    }

    public class ListExtensions : Object
    {
        // ── Methods ──
        public void RemoveAtSwapBack(){} // RVA: 0x7FFE80E4BA70
    }

    public class Long1024 : ValueType
    {
        public Unity.Collections.Long512 f0; // 0x10

        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFE878B97C0
        public void ElementAt(){} // RVA: 0x7FFE878B97D0
    }

    public class Long512 : ValueType
    {
    }

    public class Long64 : ValueType
    {
    }

    public class Long8 : ValueType
    {
    }

    public class Memory : ValueType
    {
    }

    public class NativeArrayDebugView`1 : Object
    {
    }

    public class NativeArrayDispose : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE87BF9340
    }

    public class NativeArrayDisposeJob : ValueType
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE87BF9340
        public void RegisterNativeArrayDisposeJobReflectionData(){} // RVA: 0x7FFE87BF93A0
    }

    public class NativeArrayExtensions : Object
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFE810A1420
        public void Initialize(){} // RVA: 0x7FFE810A1420
    }

    public class NativeArrayReadOnlyDebugView`1 : Object
    {
    }

    public class NativeArray`1 : ValueType
    {
        public void* m_Buffer;
        public int m_Length;
        public 0x6657168C m_AllocatorLabel;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void Allocate(){} // RVA: 0x7FFE80E47DA0
        public void get_Length(){} // RVA: 0x7FFE80E2EDB0
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void get_IsCreated(){} // RVA: 0x7FFE80E2F150
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void CopyFrom(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ToArray(){} // RVA: 0x7FFE80E2E2E0
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void Equals(){} // RVA: 0x7FFE80E2F3B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void Copy(){} // RVA: 0x7FFE810A1420 | overloaded x5
        public void CopySafe(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void GetSubArray(){} // RVA: 0x7FFE810A1420
        public void AsReadOnly(){} // RVA: 0x7FFE810A1420
    }

    public class NativeBitArrayDispose : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE878B9B20
    }

    public class NativeBitArrayDisposeJob : ValueType
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE878B9C30
    }

    public class NativeDisableParallelForRestrictionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NativeFixedLengthAttribute : Attribute
    {
    }

    public class NativeHashMapDebuggerTypeProxy`2 : Object
    {
    }

    public class NativeHashMapDispose : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE878B9C40
    }

    public class NativeHashMapDisposeJob : ValueType
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE878B9DC0
    }

    public class NativeHashMap`2 : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.HashMapHelper`1<T>* m_Data;
        public Unity.Collections.LowLevel.Unsafe.HashMapHelper`1<UnityEngine.Vector3Int>* m_Data; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void get_IsCreated(){} // RVA: 0x7FFE80E2F150
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void TryAdd(){} // RVA: 0x7FFE810A1420
        public void Add(){} // RVA: 0x7FFE810A1420
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void TryGetValue(){} // RVA: 0x7FFE810A1420
        public void ContainsKey(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void GetKeyArray(){} // RVA: 0x7FFE810A1420
        public void GetValueArray(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class NativeListDebugView`1 : Object
    {
    }

    public class NativeListDispose : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE878B9DD0
    }

    public class NativeListDisposeJob : ValueType
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE878B9DD0
    }

    public class NativeListExtensions : Object
    {
        // ── Methods ──
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void IndexOf(){} // RVA: 0x7FFE810A1420
    }

    public class NativeList`1 : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeList`1<T>* m_ListData;
        public Unity.Collections.LowLevel.Unsafe.UnsafeList`1<int>* m_ListData; // 0x10
        public object field_2; // 0xFDB0
        public object field_3;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFE80E48220
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void get_Length(){} // RVA: 0x7FFE80E2EDB0
        public void set_Length(){} // RVA: 0x7FFE80E46530
        public void get_Capacity(){} // RVA: 0x7FFE80E2EDB0
        public void Add(){} // RVA: 0x7FFE80E460A0
        public void AddRange(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void RemoveAtSwapBack(){} // RVA: 0x7FFE80E46530
        public void RemoveAt(){} // RVA: 0x7FFE80E46530
        public void get_IsCreated(){} // RVA: 0x7FFE80E2F150
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void AsArray(){} // RVA: 0x7FFE810A1420
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void SetCapacity(){} // RVA: 0x7FFE80E46530
    }

    public class NativeMatchesParallelForLengthAttribute : Attribute
    {
    }

    public class NativeParallelHashMapDebuggerTypeProxy`2 : Object
    {
    }

    public class NativeParallelHashMapExtensions : Object
    {
        // ── Methods ──
        public void Remove(){} // RVA: 0x7FFE810A1420
    }

    public class NativeParallelHashMap`2 : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap`2<T,T> m_HashMapData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void get_IsCreated(){} // RVA: 0x7FFE80E2F150
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void AsParallelWriter(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class NativeParallelMultiHashMapDebuggerTypeProxy`2 : Object
    {
    }

    public class NativeParallelMultiHashMapIterator`1 : ValueType
    {
    }

    public class NativeParallelMultiHashMap`2 : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeParallelMultiHashMap`2<T,T> m_MultiHashMapData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void Initialize(){} // RVA: 0x7FFE80E48220
        public void Add(){} // RVA: 0x7FFE810A1420
        public void TryGetFirstValue(){} // RVA: 0x7FFE810A1420
        public void TryGetNextValue(){} // RVA: 0x7FFE80E32650
        public void get_IsCreated(){} // RVA: 0x7FFE80E2F150
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class NativeQueueDispose : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE878B9E10
    }

    public class NativeQueueDisposeJob : ValueType
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE878B9E10
    }

    public class NativeQueue`1 : ValueType
    {
        public Unity.Collections.UnsafeQueue`1<T>* m_Queue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void Enqueue(){} // RVA: 0x7FFE810A1420
        public void TryDequeue(){} // RVA: 0x7FFE80E2F3B0
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void get_IsCreated(){} // RVA: 0x7FFE80E2F150
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void AsParallelWriter(){} // RVA: 0x7FFE810A1420
    }

    public class NativeReferenceDispose : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE878B9E50
    }

    public class NativeReferenceDisposeJob : ValueType
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE878B9E50
    }

    public class NativeRingQueueDispose : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE878B9E90
    }

    public class NativeRingQueueDisposeJob : ValueType
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE878B9FE0
    }

    public class NativeSliceDebugView`1 : Object
    {
    }

    public class NativeSliceExtensions : Object
    {
        // ── Methods ──
        public void Slice(){} // RVA: 0x7FFE810A1420 | overloaded x3
    }

    public class NativeSlice`1 : ValueType
    {
        public byte* m_Buffer;
        public int m_Stride;
        public int m_Length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void op_Implicit(){} // RVA: 0x7FFE810A1420
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void CopyFrom(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void get_Stride(){} // RVA: 0x7FFE80E2EDB0
        public void get_Length(){} // RVA: 0x7FFE80E2EDB0
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void Equals(){} // RVA: 0x7FFE80E2F3B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
    }

    public class NativeStream : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeStream m_Stream; // 0x10

        // ── Methods ──
        public void get_IsCreated(){} // RVA: 0x7FFE8412EC80
        public void Dispose(){} // RVA: 0x7FFE878B9FF0
        public void AllocateForEach(){} // RVA: 0x7FFE878BA000
    }

    public class NativeStreamDispose : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE878B9FF0
    }

    public class NativeStreamDisposeJob : ValueType
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE878B9FF0
    }

    public class NativeTextDispose : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE878BA050
    }

    public class NativeTextDisposeJob : ValueType
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE878BA170
    }

    public class ReadOnlyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class RewindableAllocator : ValueType
    {
        public Unity.Collections.Spinner m_spinner; // 0x10

        // ── Methods ──
        public void Rewind(){} // RVA: 0x7FFE878BA180
        public void Dispose(){} // RVA: 0x7FFE878BA310
        public void TryAllocate(){} // RVA: 0x7FFE878BA460
        public void Try(){} // RVA: 0x7FFE878BA930 | overloaded x2
        public void get_Handle(){} // RVA: 0x7FFE826F42A0
        public void Try$BurstManaged(){} // RVA: 0x7FFE878BA990
    }

    public class Spinner : ValueType
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x7FFE878B6D20
        public void Release(){} // RVA: 0x7FFE878B6D40
    }

    public class Try_000000E3$BurstDirectCall : Object
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFE878B91D0
        public void GetFunctionPointer(){} // RVA: 0x7FFE878B9310
        public void Constructor(){} // RVA: 0x7FFE878B9480
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE878B9480
        public void Invoke(){} // RVA: 0x7FFE878B9540
    }

    public class Try_000000E3$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8638D700
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class Try_000009DF$BurstDirectCall : Object
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFE878BAB00
        public void GetFunctionPointer(){} // RVA: 0x7FFE878BAC40
        public void Constructor(){} // RVA: 0x7FFE878BADB0
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE878BADB0
        public void Invoke(){} // RVA: 0x7FFE878BAE70
    }

    public class Try_000009DF$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8638D700
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class Unicode : ValueType
    {
        // ── Methods ──
        public void IsValidCodePoint(){} // RVA: 0x7FFE878BB080
        public void NotTrailer(){} // RVA: 0x7FFE878BB090
        public void get_ReplacementCharacter(){} // RVA: 0x7FFE86E2CD50
        public void Utf8ToUcs(){} // RVA: 0x7FFE878BB0A0
        public void UcsToUtf16(){} // RVA: 0x7FFE878BB290
        public void Utf8ToUtf16(){} // RVA: 0x7FFE878BB330
    }

    public class UnmanagedArray`1 : ValueType
    {
        public UIntPtr m_pointer;

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void get_Item(){} // RVA: 0x7FFE80E3D230
    }

    public class UnsafeQueueBlockHeader : ValueType
    {
    }

    public class UnsafeQueueData : ValueType
    {
        // ── Methods ──
        public void GetCurrentWriteBlockTLS(){} // RVA: 0x7FFE878BB4C0
        public void SetCurrentWriteBlockTLS(){} // RVA: 0x7FFE878BB4D0
        public void AllocateWriteBlockMT(){} // RVA: 0x7FFE810A1420
        public void AllocateQueue(){} // RVA: 0x7FFE810A1420
        public void DeallocateQueue(){} // RVA: 0x7FFE878BB4E0
    }

    public class UnsafeQueueDispose : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE878BB650
    }

    public class UnsafeQueueDisposeJob : ValueType
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE878BB650
    }

    public class UnsafeQueue`1 : ValueType
    {
        public Unity.Collections.UnsafeQueueData* m_Buffer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void Alloc(){} // RVA: 0x7FFE810A1420
        public void Free(){} // RVA: 0x7FFE810A1420
        public void Enqueue(){} // RVA: 0x7FFE810A1420
        public void TryDequeue(){} // RVA: 0x7FFE80E2F3B0
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void get_IsCreated(){} // RVA: 0x7FFE80E2F150
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void AsParallelWriter(){} // RVA: 0x7FFE810A1420
    }

    public class WriteOnlyAttribute : Attribute
    {
    }

    public class xxHash3 : Object
    {
        // ── Methods ──
        public void Avx2HashLongInternalLoop(){} // RVA: 0x7FFE81D95990
        public void Avx2ScrambleAcc(){} // RVA: 0x7FFE81D95990
        public void Avx2Accumulate(){} // RVA: 0x7FFE81D95990
        public void Avx2Accumulate512(){} // RVA: 0x7FFE81D95990
        public void Hash64Long(){} // RVA: 0x7FFE878BB660
        public void Hash128Long(){} // RVA: 0x7FFE878BB6F0
        public void ToUint4(){} // RVA: 0x7FFE878BB780
        public void Read64LE(){} // RVA: 0x7FFE8284EF60
        public void Write64LE(){} // RVA: 0x7FFE82889220
        public void Mul32To64(){} // RVA: 0x7FFE8695FB20
        public void XorShift64(){} // RVA: 0x7FFE8733C390
        public void Mul128Fold64(){} // RVA: 0x7FFE878BB7A0
        public void Avalanche(){} // RVA: 0x7FFE8733BFD0
        public void Mix2Acc(){} // RVA: 0x7FFE878BB800
        public void MergeAcc(){} // RVA: 0x7FFE878BB860
        public void DefaultHashLongInternalLoop(){} // RVA: 0x7FFE878BBA50
        public void DefaultAccumulate(){} // RVA: 0x7FFE878BBDE0
        public void DefaultAccumulate512(){} // RVA: 0x7FFE878BBFC0
        public void DefaultScrambleAcc(){} // RVA: 0x7FFE878BC120
        public void Hash64Long$BurstManaged(){} // RVA: 0x7FFE878BC200
        public void Hash128Long$BurstManaged(){} // RVA: 0x7FFE878BC320
    }

}