// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Collections
// Classes: 69
// Methods: 358

namespace ThirdParty.Other.Unity.Collections
{
    public class AllocatorManager : Object
    {
        // ── Methods ──
        public void AllocateBlock(){} // RVA: 0x7FFD4E2ADC40
        public void Allocate(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void AllocateStruct(){} // RVA: 0x7FFD4E2ADC40
        public void FreeBlock(){} // RVA: 0x7FFD4E090C80
        public void Free(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void CheckDelegate(){} // RVA: 0x7FFD53201980
        public void UseDelegate(){} // RVA: 0x7FFD5492E690
        public void allocate_block(){} // RVA: 0x7FFD5492E6E0
        public void forward_mono_allocate_block(){} // RVA: 0x7FFD5492E780
        public void LegacyOf(){} // RVA: 0x7FFD5492E8A0
        public void TryLegacy(){} // RVA: 0x7FFD5492E8B0
        public void Try(){} // RVA: 0x7FFD5492EA50
        public void IsCustomAllocator(){} // RVA: 0x7FFD5492EDC0
        public void .cctor(){} // RVA: 0x7FFD5492EDD0
        public void Initialize$StackAllocator_Try_000000AB$BurstDirectCall(){} // RVA: 0x7FFD5492EF90
        public void Initialize$SlabAllocator_Try_000000B9$BurstDirectCall(){} // RVA: 0x7FFD5492EFE0
    }

    public class ArrayOfArrays`1 : ValueType
    {
        public object BlockSizeInElements;
        public object BlockSizeInBytes;
        public object BlockMask;
        public object Length;
        public object Item;

        // ── Methods ──
        public void get_BlockSizeInElements(){} // RVA: 0x7FFD4E079960
        public void get_BlockSizeInBytes(){} // RVA: 0x7FFD4E079960
        public void get_BlockMask(){} // RVA: 0x7FFD4E079960
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void LockfreeAdd(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item(){} // RVA: 0x7FFD4E087DE0
        public void Rewind(){} // RVA: 0x7FFD4E090980
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void RemoveAtSwapBack(){} // RVA: 0x7FFD4E090ED0
        public void BlockIndexOfElement(){} // RVA: 0x7FFD4E0800D0
        public void TrimExcess(){} // RVA: 0x7FFD4E090980
    }

    public class AutoFreeAllocator : ValueType
    {
        public object Handle;

        // ── Methods ──
        public void Update(){} // RVA: 0x7FFD54930620
        public void FreeAll(){} // RVA: 0x7FFD54930780
        public void Dispose(){} // RVA: 0x7FFD549308D0
        public void Try(){} // RVA: 0x7FFD54930A20 | overloaded x2
        public void get_Handle(){} // RVA: 0x7FFD4E3E2080
        public void Try$BurstManaged(){} // RVA: 0x7FFD54930A80
    }

    public class CollectionHelper : Object
    {
        // ── Methods ──
        public void Align(){} // RVA: 0x7FFD54931010
        public void Hash(){} // RVA: 0x7FFD54931030
        public void ShouldDeallocate(){} // RVA: 0x7FFD54931060
        public void AssumePositive(){} // RVA: 0x7FFD50006C10
        public void CreateNativeArray(){} // RVA: 0x7FFD4E2ADC40
    }

    public class DeallocateOnJobCompletionAttribute : Attribute
    {
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
        public void PaddingBytes(){} // RVA: 0x7FFD4E079990
    }

    public class FixedList128Bytes`1 : ValueType
    {
        public object length;
        public object buffer;
        public object Length;
        public object LengthInBytes;
        public object Buffer;

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFD4E078DC0
        public void get_buffer(){} // RVA: 0x7FFD4E2ADC40
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void get_LengthInBytes(){} // RVA: 0x7FFD4E079960
        public void get_Buffer(){} // RVA: 0x7FFD4E2ADC40
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void CompareTo(){} // RVA: 0x7FFD4E2ADC40 | overloaded x5
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class FixedList32Bytes`1 : ValueType
    {
        public object length;
        public object buffer;
        public object Length;
        public object LengthInBytes;
        public object Buffer;

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFD4E078DC0
        public void get_buffer(){} // RVA: 0x7FFD4E2ADC40
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void get_LengthInBytes(){} // RVA: 0x7FFD4E079960
        public void get_Buffer(){} // RVA: 0x7FFD4E2ADC40
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void CompareTo(){} // RVA: 0x7FFD4E2ADC40 | overloaded x5
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class FixedList4096Bytes`1 : ValueType
    {
        public object length;
        public object buffer;
        public object Length;
        public object LengthInBytes;
        public object Buffer;
        public object Item;

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFD4E078DC0
        public void get_buffer(){} // RVA: 0x7FFD4E2ADC40
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void get_LengthInBytes(){} // RVA: 0x7FFD4E079960
        public void get_Buffer(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void CompareTo(){} // RVA: 0x7FFD4E2ADC40 | overloaded x5
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class FixedList512Bytes`1 : ValueType
    {
        public object length;
        public object buffer;
        public object Length;
        public object LengthInBytes;
        public object Buffer;

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFD4E078DC0
        public void get_buffer(){} // RVA: 0x7FFD4E2ADC40
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void get_LengthInBytes(){} // RVA: 0x7FFD4E079960
        public void get_Buffer(){} // RVA: 0x7FFD4E2ADC40
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void CompareTo(){} // RVA: 0x7FFD4E2ADC40 | overloaded x5
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class FixedList64Bytes`1 : ValueType
    {
        public object length;
        public object buffer;
        public object Length;
        public object LengthInBytes;
        public object Buffer;

        // ── Methods ──
        public void get_length(){} // RVA: 0x7FFD4E078DC0
        public void get_buffer(){} // RVA: 0x7FFD4E2ADC40
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void get_LengthInBytes(){} // RVA: 0x7FFD4E079960
        public void get_Buffer(){} // RVA: 0x7FFD4E2ADC40
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void CompareTo(){} // RVA: 0x7FFD4E2ADC40 | overloaded x5
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class FixedStringMethods : Object
    {
        // ── Methods ──
        public void ConvertToString(){} // RVA: 0x7FFD4E078F80
    }

    public class GenerateTestsForBurstCompatibilityAttribute : Attribute
    {
        public object GenericTypeArguments;

        // ── Methods ──
        public void set_GenericTypeArguments(){} // RVA: 0x7FFD4E342E30
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class Hash128Long_00000A71$BurstDirectCall : Object
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFD54934460
        public void GetFunctionPointer(){} // RVA: 0x7FFD549345A0
        public void Constructor(){} // RVA: 0x7FFD54934710
        public void Initialize(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD54934710
        public void Invoke(){} // RVA: 0x7FFD549347D0
    }

    public class Hash128Long_00000A71$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54934380
        public void Invoke(){} // RVA: 0x7FFD51080E20
    }

    public class Hash64Long_00000A6A$BurstDirectCall : Object
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFD54933D30
        public void GetFunctionPointer(){} // RVA: 0x7FFD54933E70
        public void Constructor(){} // RVA: 0x7FFD54933FE0
        public void Initialize(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD54933FE0
        public void Invoke(){} // RVA: 0x7FFD549340A0
    }

    public class Hash64Long_00000A6A$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53790B30
        public void Invoke(){} // RVA: 0x7FFD4EC5F780
    }

    public class IIndexable`1
    {
        public object Length;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFD4E079960
    }

    public class INativeList`1
    {
    }

    public class IUTF8Bytes
    {
        // ── Methods ──
        public void GetUnsafePtr(){} // RVA: 0x7FFD4E2ADC40
    }

    public class KVPair`2 : ValueType
    {
    }

    public class ListExtensions : Object
    {
        // ── Methods ──
        public void RemoveAtSwapBack(){} // RVA: 0x7FFD4E096370
    }

    public class Memory : ValueType
    {
    }

    public class NativeArrayDispose : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFD54C70DA0
    }

    public class NativeArrayDisposeJob : ValueType
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFD54C70DA0
        public void RegisterNativeArrayDisposeJobReflectionData(){} // RVA: 0x7FFD54C70E00
    }

    public class NativeArrayExtensions : Object
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void Initialize(){} // RVA: 0x7FFD4E2ADC40
    }

    public class NativeArray`1 : ValueType
    {
        public object Length;
        public object Item;
        public object IsCreated;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void Allocate(){} // RVA: 0x7FFD4E092740
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void get_IsCreated(){} // RVA: 0x7FFD4E079D00
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void CopyFrom(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ToArray(){} // RVA: 0x7FFD4E078E90
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void Copy(){} // RVA: 0x7FFD4E2ADC40 | overloaded x5
        public void CopySafe(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void GetSubArray(){} // RVA: 0x7FFD4E2ADC40
        public void AsReadOnly(){} // RVA: 0x7FFD4E2ADC40
    }

    public class NativeBitArrayDispose : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFD549313E0
    }

    public class NativeBitArrayDisposeJob : ValueType
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFD549314F0
    }

    public class NativeDisableParallelForRestrictionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class NativeFixedLengthAttribute : Attribute
    {
    }

    public class NativeHashMapDispose : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFD54931500
    }

    public class NativeHashMapDisposeJob : ValueType
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFD54931680
    }

    public class NativeHashMap`2 : ValueType
    {
        public object IsCreated;
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void get_IsCreated(){} // RVA: 0x7FFD4E079D00
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void TryAdd(){} // RVA: 0x7FFD4E2ADC40
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetValue(){} // RVA: 0x7FFD4E2ADC40
        public void ContainsKey(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void GetKeyArray(){} // RVA: 0x7FFD4E2ADC40
        public void GetValueArray(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class NativeListDispose : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFD54931690
    }

    public class NativeListDisposeJob : ValueType
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFD54931690
    }

    public class NativeListExtensions : Object
    {
        // ── Methods ──
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
    }

    public class NativeList`1 : ValueType
    {
        public object Item;
        public object Length;
        public object Capacity;
        public object IsCreated;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFD4E092BC0
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void set_Length(){} // RVA: 0x7FFD4E090ED0
        public void get_Capacity(){} // RVA: 0x7FFD4E079960
        public void Add(){} // RVA: 0x7FFD4E090A40
        public void AddRange(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void RemoveAtSwapBack(){} // RVA: 0x7FFD4E090ED0
        public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void get_IsCreated(){} // RVA: 0x7FFD4E079D00
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void AsArray(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void SetCapacity(){} // RVA: 0x7FFD4E090ED0
    }

    public class NativeMatchesParallelForLengthAttribute : Attribute
    {
    }

    public class NativeParallelHashMapExtensions : Object
    {
        // ── Methods ──
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
    }

    public class NativeParallelHashMap`2 : ValueType
    {
        public object IsCreated;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void get_IsCreated(){} // RVA: 0x7FFD4E079D00
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void AsParallelWriter(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class NativeParallelMultiHashMapIterator`1 : ValueType
    {
    }

    public class NativeParallelMultiHashMap`2 : ValueType
    {
        public object IsCreated;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Initialize(){} // RVA: 0x7FFD4E092BC0
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetFirstValue(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetNextValue(){} // RVA: 0x7FFD4E07D200
        public void get_IsCreated(){} // RVA: 0x7FFD4E079D00
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class NativeQueueDispose : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFD549316D0
    }

    public class NativeQueueDisposeJob : ValueType
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFD549316D0
    }

    public class NativeQueue`1 : ValueType
    {
        public object IsCreated;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Enqueue(){} // RVA: 0x7FFD4E2ADC40
        public void TryDequeue(){} // RVA: 0x7FFD4E079F60
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void get_IsCreated(){} // RVA: 0x7FFD4E079D00
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void AsParallelWriter(){} // RVA: 0x7FFD4E2ADC40
    }

    public class NativeSliceExtensions : Object
    {
        // ── Methods ──
        public void Slice(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
    }

    public class NativeSlice`1 : ValueType
    {
        public object Item;
        public object Stride;
        public object Length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void op_Implicit(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void CopyFrom(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void get_Stride(){} // RVA: 0x7FFD4E079960
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
    }

    public class NativeStream : ValueType
    {
        public object IsCreated;

        // ── Methods ──
        public void get_IsCreated(){} // RVA: 0x7FFD511E6CA0
        public void Dispose(){} // RVA: 0x7FFD549318B0
        public void AllocateForEach(){} // RVA: 0x7FFD549318C0
    }

    public class ReadOnlyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class RewindableAllocator : ValueType
    {
        public object Handle;

        // ── Methods ──
        public void Rewind(){} // RVA: 0x7FFD54931A40
        public void Dispose(){} // RVA: 0x7FFD54931BD0
        public void TryAllocate(){} // RVA: 0x7FFD54931D20
        public void Try(){} // RVA: 0x7FFD549321F0 | overloaded x2
        public void get_Handle(){} // RVA: 0x7FFD4F8402A0
        public void Try$BurstManaged(){} // RVA: 0x7FFD54932250
    }

    public class Spinner : ValueType
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x7FFD5492E5E0
        public void Release(){} // RVA: 0x7FFD5492E600
    }

    public class Try_000000E3$BurstDirectCall : Object
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFD54930A90
        public void GetFunctionPointer(){} // RVA: 0x7FFD54930BD0
        public void Constructor(){} // RVA: 0x7FFD54930D40
        public void Initialize(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD54930D40
        public void Invoke(){} // RVA: 0x7FFD54930E00
    }

    public class Try_000000E3$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5337FAB0
        public void Invoke(){} // RVA: 0x7FFD4E49D370
    }

    public class Try_000009DF$BurstDirectCall : Object
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFD549323C0
        public void GetFunctionPointer(){} // RVA: 0x7FFD54932500
        public void Constructor(){} // RVA: 0x7FFD54932670
        public void Initialize(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD54932670
        public void Invoke(){} // RVA: 0x7FFD54932730
    }

    public class Try_000009DF$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5337FAB0
        public void Invoke(){} // RVA: 0x7FFD4E49D370
    }

    public class Unicode : ValueType
    {
        public object ReplacementCharacter;

        // ── Methods ──
        public void IsValidCodePoint(){} // RVA: 0x7FFD54932940
        public void NotTrailer(){} // RVA: 0x7FFD54932950
        public void get_ReplacementCharacter(){} // RVA: 0x7FFD53EA36C0
        public void Utf8ToUcs(){} // RVA: 0x7FFD54932960
        public void UcsToUtf16(){} // RVA: 0x7FFD54932B50
        public void Utf8ToUtf16(){} // RVA: 0x7FFD54932BF0
    }

    public class UnmanagedArray`1 : ValueType
    {
        public object Item;

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void get_Item(){} // RVA: 0x7FFD4E087DE0
    }

    public class UnsafeQueueBlockHeader : ValueType
    {
    }

    public class UnsafeQueueData : ValueType
    {
        // ── Methods ──
        public void GetCurrentWriteBlockTLS(){} // RVA: 0x7FFD54932D80
        public void SetCurrentWriteBlockTLS(){} // RVA: 0x7FFD54932D90
        public void AllocateWriteBlockMT(){} // RVA: 0x7FFD4E2ADC40
        public void AllocateQueue(){} // RVA: 0x7FFD4E2ADC40
        public void DeallocateQueue(){} // RVA: 0x7FFD54932DA0
    }

    public class UnsafeQueue`1 : ValueType
    {
        public object IsCreated;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Alloc(){} // RVA: 0x7FFD4E2ADC40
        public void Free(){} // RVA: 0x7FFD4E2ADC40
        public void Enqueue(){} // RVA: 0x7FFD4E2ADC40
        public void TryDequeue(){} // RVA: 0x7FFD4E079F60
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void get_IsCreated(){} // RVA: 0x7FFD4E079D00
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void AsParallelWriter(){} // RVA: 0x7FFD4E2ADC40
    }

    public class WriteOnlyAttribute : Attribute
    {
    }

    public class xxHash3 : Object
    {
        // ── Methods ──
        public void Avx2HashLongInternalLoop(){} // RVA: 0x7FFD4E9F2DD0
        public void Avx2ScrambleAcc(){} // RVA: 0x7FFD4E9F2DD0
        public void Avx2Accumulate(){} // RVA: 0x7FFD4E9F2DD0
        public void Avx2Accumulate512(){} // RVA: 0x7FFD4E9F2DD0
        public void Hash64Long(){} // RVA: 0x7FFD54932F20
        public void Hash128Long(){} // RVA: 0x7FFD54932FB0
        public void ToUint4(){} // RVA: 0x7FFD54933040
        public void Read64LE(){} // RVA: 0x7FFD4EEF9F60
        public void Write64LE(){} // RVA: 0x7FFD4F9DB120
        public void Mul32To64(){} // RVA: 0x7FFD539D6350
        public void XorShift64(){} // RVA: 0x7FFD543B3F70
        public void Mul128Fold64(){} // RVA: 0x7FFD54933060
        public void Avalanche(){} // RVA: 0x7FFD543B3BB0
        public void Mix2Acc(){} // RVA: 0x7FFD549330C0
        public void MergeAcc(){} // RVA: 0x7FFD54933120
        public void DefaultHashLongInternalLoop(){} // RVA: 0x7FFD54933310
        public void DefaultAccumulate(){} // RVA: 0x7FFD549336A0
        public void DefaultAccumulate512(){} // RVA: 0x7FFD54933880
        public void DefaultScrambleAcc(){} // RVA: 0x7FFD549339E0
        public void Hash64Long$BurstManaged(){} // RVA: 0x7FFD54933AC0
        public void Hash128Long$BurstManaged(){} // RVA: 0x7FFD54933BE0
    }

}