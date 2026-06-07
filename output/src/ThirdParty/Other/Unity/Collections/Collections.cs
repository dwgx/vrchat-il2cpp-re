// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Collections
// Classes: 96
// Methods: 373

namespace ThirdParty.Other.Unity.Collections
{
    public class AllocatorManager
    {
        // ── Methods ──
        public void AllocateBlock(){} // RVA: 0x283FA0
        public void Allocate(){} // RVA: 0x283FA0 | overloaded x2
        public void AllocateStruct(){} // RVA: 0x283FA0
        public void FreeBlock(){} // RVA: 0x24D50
        public void Free(){} // RVA: 0x283FA0 | overloaded x4
        public void CheckDelegate(){} // RVA: 0x57538A0
        public void UseDelegate(){} // RVA: 0x6D75F30
        public void allocate_block(){} // RVA: 0x6D75F80
        public void forward_mono_allocate_block(){} // RVA: 0x6D76020
        public void LegacyOf(){} // RVA: 0x6D76140
        public void TryLegacy(){} // RVA: 0x6D76150
        public void Try(){} // RVA: 0x6D762F0
        public void IsCustomAllocator(){} // RVA: 0x6D76660
        public void .cctor(){} // RVA: 0x6D76670
        public void Initialize$StackAllocator_Try_000000AB$BurstDirectCall(){} // RVA: 0x6D76830
        public void Initialize$SlabAllocator_Try_000000B9$BurstDirectCall(){} // RVA: 0x6D76880
    }

    public class ArrayOfArrays`1
    {
        // ── Methods ──
        public void get_BlockSizeInElements(){} // RVA: 0xD840
        public void get_BlockSizeInBytes(){} // RVA: 0xD840
        public void get_BlockMask(){} // RVA: 0xD840
        public void get_Length(){} // RVA: 0xD840
        public void LockfreeAdd(){} // RVA: 0x283FA0
        public void get_Item(){} // RVA: 0x1BCC0
        public void Rewind(){} // RVA: 0x24A50
        public void Clear(){} // RVA: 0x24A50
        public void Dispose(){} // RVA: 0x24A50
        public void RemoveAtSwapBack(){} // RVA: 0x24FA0
        public void BlockIndexOfElement(){} // RVA: 0x13FB0
        public void TrimExcess(){} // RVA: 0x24A50
    }

    public class AutoFreeAllocator
    {
        // ── Methods ──
        public void Update(){} // RVA: 0x6D77EC0
        public void FreeAll(){} // RVA: 0x6D78020
        public void Dispose(){} // RVA: 0x6D78170
        public void Try(){} // RVA: 0x6D782C0 | overloaded x2
        public void get_Handle(){} // RVA: 0x37E080
        public void Try$BurstManaged(){} // RVA: 0x6D78320
    }

    public class CollectionHelper
    {
        // ── Methods ──
        public void Align(){} // RVA: 0x6D788B0
        public void Hash(){} // RVA: 0x6D788D0
        public void ShouldDeallocate(){} // RVA: 0x6D78900
        public void AssumePositive(){} // RVA: 0x20C5210
        public void CreateNativeArray(){} // RVA: 0x283FA0
    }

    public class DeallocateOnJobCompletionAttribute
    {
    }

    public class ExcludeFromBurstCompatTestingAttribute
    {
        // ── Methods ──
        public void set_Reason(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class FixedBytes128Align8
    {
    }

    public class FixedBytes16Align8
    {
    }

    public class FixedBytes32Align8
    {
    }

    public class FixedBytes4096Align8
    {
    }

    public class FixedBytes512Align8
    {
    }

    public class FixedBytes64Align8
    {
    }

    public class FixedList
    {
        // ── Methods ──
        public void PaddingBytes(){} // RVA: 0xD870
    }

    public class FixedList128BytesDebugView`1
    {
    }

    public class FixedList128Bytes`1
    {
        // ── Methods ──
        public void get_length(){} // RVA: 0xCC90
        public void get_buffer(){} // RVA: 0x283FA0
        public void get_Length(){} // RVA: 0xD840
        public void get_LengthInBytes(){} // RVA: 0xD840
        public void get_Buffer(){} // RVA: 0x283FA0
        public void GetHashCode(){} // RVA: 0xD840
        public void CompareTo(){} // RVA: 0x283FA0 | overloaded x5
        public void Equals(){} // RVA: 0xDE40 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
    }

    public class FixedList32BytesDebugView`1
    {
    }

    public class FixedList32Bytes`1
    {
        // ── Methods ──
        public void get_length(){} // RVA: 0xCC90
        public void get_buffer(){} // RVA: 0x283FA0
        public void get_Length(){} // RVA: 0xD840
        public void get_LengthInBytes(){} // RVA: 0xD840
        public void get_Buffer(){} // RVA: 0x283FA0
        public void GetHashCode(){} // RVA: 0xD840
        public void CompareTo(){} // RVA: 0x283FA0 | overloaded x5
        public void Equals(){} // RVA: 0xDE40 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
    }

    public class FixedList4096BytesDebugView`1
    {
    }

    public class FixedList4096Bytes`1
    {
        // ── Methods ──
        public void get_length(){} // RVA: 0xCC90
        public void get_buffer(){} // RVA: 0x283FA0
        public void get_Length(){} // RVA: 0xD840
        public void get_LengthInBytes(){} // RVA: 0xD840
        public void get_Buffer(){} // RVA: 0x283FA0
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void GetHashCode(){} // RVA: 0xD840
        public void CompareTo(){} // RVA: 0x283FA0 | overloaded x5
        public void Equals(){} // RVA: 0xDE40 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
    }

    public class FixedList512BytesDebugView`1
    {
    }

    public class FixedList512Bytes`1
    {
        // ── Methods ──
        public void get_length(){} // RVA: 0xCC90
        public void get_buffer(){} // RVA: 0x283FA0
        public void get_Length(){} // RVA: 0xD840
        public void get_LengthInBytes(){} // RVA: 0xD840
        public void get_Buffer(){} // RVA: 0x283FA0
        public void GetHashCode(){} // RVA: 0xD840
        public void CompareTo(){} // RVA: 0x283FA0 | overloaded x5
        public void Equals(){} // RVA: 0xDE40 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
    }

    public class FixedList64BytesDebugView`1
    {
    }

    public class FixedList64Bytes`1
    {
        // ── Methods ──
        public void get_length(){} // RVA: 0xCC90
        public void get_buffer(){} // RVA: 0x283FA0
        public void get_Length(){} // RVA: 0xD840
        public void get_LengthInBytes(){} // RVA: 0xD840
        public void get_Buffer(){} // RVA: 0x283FA0
        public void GetHashCode(){} // RVA: 0xD840
        public void CompareTo(){} // RVA: 0x283FA0 | overloaded x5
        public void Equals(){} // RVA: 0xDE40 | overloaded x6
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
    }

    public class FixedStringMethods
    {
        // ── Methods ──
        public void ConvertToString(){} // RVA: 0xCE50
    }

    public class GenerateTestsForBurstCompatibilityAttribute
    {
        // ── Methods ──
        public void set_GenericTypeArguments(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Hash128Long_00000A71$BurstDirectCall
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x6D7BD00
        public void GetFunctionPointer(){} // RVA: 0x6D7BE40
        public void Constructor(){} // RVA: 0x6D7BFB0
        public void Initialize(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x6D7BFB0
        public void Invoke(){} // RVA: 0x6D7C070
    }

    public class Hash128Long_00000A71$PostfixBurstDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6D7BC20
        public void Invoke(){} // RVA: 0x331B260
    }

    public class Hash64Long_00000A6A$BurstDirectCall
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x6D7B5D0
        public void GetFunctionPointer(){} // RVA: 0x6D7B710
        public void Constructor(){} // RVA: 0x6D7B880
        public void Initialize(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x6D7B880
        public void Invoke(){} // RVA: 0x6D7B940
    }

    public class Hash64Long_00000A6A$PostfixBurstDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BD95E0
        public void Invoke(){} // RVA: 0xC09580
    }

    public class IIndexable`1
    {
        // ── Methods ──
        public void get_Length(){} // RVA: 0xD840
    }

    public class INativeList`1
    {
    }

    public class IUTF8Bytes
    {
        // ── Methods ──
        public void GetUnsafePtr(){} // RVA: 0x283FA0
    }

    public class KVPair`2
    {
    }

    public class ListExtensions
    {
        // ── Methods ──
        public void RemoveAtSwapBack(){} // RVA: 0x2A490
    }

    public class Long1024
    {
        // ── Methods ──
        public void get_Length(){} // RVA: 0x6D78920
        public void ElementAt(){} // RVA: 0x6D78930
    }

    public class Long512
    {
    }

    public class Long64
    {
    }

    public class Long8
    {
    }

    public class Memory
    {
    }

    public class NativeArrayDebugView`1
    {
    }

    public class NativeArrayDispose
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x70B8360
    }

    public class NativeArrayDisposeJob : Dispose
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x70B8360
        public void RegisterNativeArrayDisposeJobReflectionData(){} // RVA: 0x70B83C0
    }

    public class NativeArrayExtensions
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x283FA0
        public void Initialize(){} // RVA: 0x283FA0
    }

    public class NativeArrayReadOnlyDebugView`1
    {
    }

    public class NativeArray`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2BAA0 | overloaded x2
        public void Allocate(){} // RVA: 0x267C0
        public void get_Length(){} // RVA: 0xD840
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void get_IsCreated(){} // RVA: 0xDBE0
        public void Dispose(){} // RVA: 0x24A50
        public void CopyFrom(){} // RVA: 0x283FA0 | overloaded x2
        public void ToArray(){} // RVA: 0xCD60
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void Equals(){} // RVA: 0xDE40 | overloaded x2
        public void GetHashCode(){} // RVA: 0xD840
        public void Copy(){} // RVA: 0x283FA0 | overloaded x6
        public void CopySafe(){} // RVA: 0x283FA0 | overloaded x4
        public void GetSubArray(){} // RVA: 0x283FA0
        public void AsReadOnly(){} // RVA: 0x283FA0
    }

    public class NativeBitArrayDispose
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x6D78C80
    }

    public class NativeBitArrayDisposeJob
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x6D78D90
    }

    public class NativeDisableParallelForRestrictionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NativeFixedLengthAttribute
    {
    }

    public class NativeHashMapDebuggerTypeProxy`2
    {
    }

    public class NativeHashMapDispose
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x6D78DA0
    }

    public class NativeHashMapDisposeJob
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x6D78F20
    }

    public class NativeHashMap`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void Dispose(){} // RVA: 0x24A50
        public void get_IsCreated(){} // RVA: 0xDBE0
        public void Clear(){} // RVA: 0x24A50
        public void TryAdd(){} // RVA: 0x283FA0
        public void Add(){} // RVA: 0x283FA0
        public void Remove(){} // RVA: 0x283FA0
        public void TryGetValue(){} // RVA: 0x283FA0
        public void ContainsKey(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void GetKeyArray(){} // RVA: 0x283FA0
        public void GetValueArray(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey,TValue>>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    }

    public class NativeListDebugView`1
    {
    }

    public class NativeListDispose
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x6D78F30
    }

    public class NativeListDisposeJob
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x6D78F30
    }

    public class NativeListExtensions
    {
        // ── Methods ──
        public void Contains(){} // RVA: 0x283FA0
        public void IndexOf(){} // RVA: 0x283FA0
    }

    public class NativeList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0 | overloaded x2
        public void Initialize(){} // RVA: 0x26C40
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void get_Length(){} // RVA: 0xD840
        public void set_Length(){} // RVA: 0x24FA0
        public void get_Capacity(){} // RVA: 0xD840
        public void Add(){} // RVA: 0x24B10
        public void AddRange(){} // RVA: 0x283FA0 | overloaded x2
        public void RemoveAtSwapBack(){} // RVA: 0x24FA0
        public void RemoveAt(){} // RVA: 0x24FA0
        public void get_IsCreated(){} // RVA: 0xDBE0
        public void Dispose(){} // RVA: 0x24A50
        public void Clear(){} // RVA: 0x24A50
        public void AsArray(){} // RVA: 0x283FA0
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
        public void SetCapacity(){} // RVA: 0x24FA0
    }

    public class NativeMatchesParallelForLengthAttribute
    {
    }

    public class NativeParallelHashMapDebuggerTypeProxy`2
    {
    }

    public class NativeParallelHashMapExtensions
    {
        // ── Methods ──
        public void Remove(){} // RVA: 0x283FA0
    }

    public class NativeParallelHashMap`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void get_IsCreated(){} // RVA: 0xDBE0
        public void Dispose(){} // RVA: 0x24A50
        public void AsParallelWriter(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    }

    public class NativeParallelMultiHashMapDebuggerTypeProxy`2
    {
    }

    public class NativeParallelMultiHashMapIterator`1
    {
    }

    public class NativeParallelMultiHashMap`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void Initialize(){} // RVA: 0x26C40
        public void Add(){} // RVA: 0x283FA0
        public void TryGetFirstValue(){} // RVA: 0x283FA0
        public void TryGetNextValue(){} // RVA: 0x11120
        public void get_IsCreated(){} // RVA: 0xDBE0
        public void Dispose(){} // RVA: 0x24A50
        public void System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    }

    public class NativeQueueDispose
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x6D78F70
    }

    public class NativeQueueDisposeJob
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x6D78F70
    }

    public class NativeQueue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void Enqueue(){} // RVA: 0x283FA0
        public void TryDequeue(){} // RVA: 0xDE40
        public void Clear(){} // RVA: 0x24A50
        public void get_IsCreated(){} // RVA: 0xDBE0
        public void Dispose(){} // RVA: 0x24A50
        public void AsParallelWriter(){} // RVA: 0x283FA0
    }

    public class NativeReferenceDispose
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x6D78FB0
    }

    public class NativeReferenceDisposeJob
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x6D78FB0
    }

    public class NativeRingQueueDispose
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x6D78FF0
    }

    public class NativeRingQueueDisposeJob
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x6D79140
    }

    public class NativeSliceDebugView`1
    {
    }

    public class NativeSliceExtensions
    {
        // ── Methods ──
        public void Slice(){} // RVA: 0x283FA0 | overloaded x3
    }

    public class NativeSlice`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0 | overloaded x4
        public void op_Implicit(){} // RVA: 0x283FA0
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void CopyFrom(){} // RVA: 0x24B10 | overloaded x2
        public void get_Stride(){} // RVA: 0xD840
        public void get_Length(){} // RVA: 0xD840
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void Equals(){} // RVA: 0xDE40 | overloaded x2
        public void GetHashCode(){} // RVA: 0xD840
    }

    public class NativeStream
    {
        // ── Methods ──
        public void get_IsCreated(){} // RVA: 0x34C1790
        public void Dispose(){} // RVA: 0x6D79150
        public void AllocateForEach(){} // RVA: 0x6D79160
    }

    public class NativeStreamDispose
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x6D79150
    }

    public class NativeStreamDisposeJob
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x6D79150
    }

    public class NativeTextDispose
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x6D791B0
    }

    public class NativeTextDisposeJob
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x6D792D0
    }

    public class ReadOnlyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class RewindableAllocator
    {
        // ── Methods ──
        public void Rewind(){} // RVA: 0x6D792E0
        public void Dispose(){} // RVA: 0x6D79470
        public void TryAllocate(){} // RVA: 0x6D795C0
        public void Try(){} // RVA: 0x6D79A90 | overloaded x2
        public void get_Handle(){} // RVA: 0x19689E0
        public void Try$BurstManaged(){} // RVA: 0x6D79AF0
    }

    public class Spinner
    {
        // ── Methods ──
        public void Acquire(){} // RVA: 0x6D75E80
        public void Release(){} // RVA: 0x6D75EA0
    }

    public class Try_000000E3$BurstDirectCall
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x6D78330
        public void GetFunctionPointer(){} // RVA: 0x6D78470
        public void Constructor(){} // RVA: 0x6D785E0
        public void Initialize(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x6D785E0
        public void Invoke(){} // RVA: 0x6D786A0
    }

    public class Try_000000E3$PostfixBurstDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x58EC7E0
        public void Invoke(){} // RVA: 0x439370
    }

    public class Try_000009DF$BurstDirectCall
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x6D79C60
        public void GetFunctionPointer(){} // RVA: 0x6D79DA0
        public void Constructor(){} // RVA: 0x6D79F10
        public void Initialize(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x6D79F10
        public void Invoke(){} // RVA: 0x6D79FD0
    }

    public class Try_000009DF$PostfixBurstDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x58EC7E0
        public void Invoke(){} // RVA: 0x439370
    }

    public class Unicode
    {
        // ── Methods ──
        public void IsValidCodePoint(){} // RVA: 0x6D7A1E0
        public void NotTrailer(){} // RVA: 0x6D7A1F0
        public void get_ReplacementCharacter(){} // RVA: 0x62EC320
        public void Utf8ToUcs(){} // RVA: 0x6D7A200
        public void UcsToUtf16(){} // RVA: 0x6D7A3F0
        public void Utf8ToUtf16(){} // RVA: 0x6D7A490
    }

    public class UnmanagedArray`1
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x24A50
        public void get_Item(){} // RVA: 0x1BCC0
    }

    public class UnsafeQueueBlockHeader
    {
    }

    public class UnsafeQueueData
    {
        // ── Methods ──
        public void GetCurrentWriteBlockTLS(){} // RVA: 0x6D7A620
        public void SetCurrentWriteBlockTLS(){} // RVA: 0x6D7A630
        public void AllocateWriteBlockMT(){} // RVA: 0x283FA0
        public void AllocateQueue(){} // RVA: 0x283FA0
        public void DeallocateQueue(){} // RVA: 0x6D7A640
    }

    public class UnsafeQueueDispose
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x6D7A7B0
    }

    public class UnsafeQueueDisposeJob
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x6D7A7B0
    }

    public class UnsafeQueue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void Alloc(){} // RVA: 0x283FA0
        public void Free(){} // RVA: 0x283FA0
        public void Enqueue(){} // RVA: 0x283FA0
        public void TryDequeue(){} // RVA: 0xDE40
        public void Clear(){} // RVA: 0x24A50
        public void get_IsCreated(){} // RVA: 0xDBE0
        public void Dispose(){} // RVA: 0x24A50
        public void AsParallelWriter(){} // RVA: 0x283FA0
    }

    public class WriteOnlyAttribute
    {
    }

    public class xxHash3
    {
        // ── Methods ──
        public void Avx2HashLongInternalLoop(){} // RVA: 0x1020CE0
        public void Avx2ScrambleAcc(){} // RVA: 0x1020CE0
        public void Avx2Accumulate(){} // RVA: 0x1020CE0
        public void Avx2Accumulate512(){} // RVA: 0x1020CE0
        public void Hash64Long(){} // RVA: 0x6D7A7C0
        public void Hash128Long(){} // RVA: 0x6D7A850
        public void ToUint4(){} // RVA: 0x6D7A8E0
        public void Read64LE(){} // RVA: 0x1AD4690
        public void Write64LE(){} // RVA: 0x1B12320
        public void Mul32To64(){} // RVA: 0x5E1ECE0
        public void XorShift64(){} // RVA: 0x67FD0B0
        public void Mul128Fold64(){} // RVA: 0x6D7A900
        public void Avalanche(){} // RVA: 0x67FCCF0
        public void Mix2Acc(){} // RVA: 0x6D7A960
        public void MergeAcc(){} // RVA: 0x6D7A9C0
        public void DefaultHashLongInternalLoop(){} // RVA: 0x6D7ABB0
        public void DefaultAccumulate(){} // RVA: 0x6D7AF40
        public void DefaultAccumulate512(){} // RVA: 0x6D7B120
        public void DefaultScrambleAcc(){} // RVA: 0x6D7B280
        public void Hash64Long$BurstManaged(){} // RVA: 0x6D7B360
        public void Hash128Long$BurstManaged(){} // RVA: 0x6D7B480
    }

}