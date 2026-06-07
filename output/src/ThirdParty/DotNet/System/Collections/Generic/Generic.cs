// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Generic
// Classes: 65
// Methods: 564

namespace ThirdParty.DotNet.System.Collections.Generic
{
    public class ArrayBuilder`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24FA0
        public void ToArray(){} // RVA: 0xCD60
        public void UncheckedAdd(){} // RVA: 0x283FA0
    }

    public class ArraySortHelper`1
    {
    }

    public class ArraySortHelper`2
    {
        public object Predicate;

        // ── Methods ──
        public void Sort(){}
        public void SwapIfGreaterWithItems(){}
        public void Swap(){} // RVA: 0x2E590
        public void IntrospectiveSort(){}
        public void IntroSort(){} // RVA: 0x283FA0
        public void PickPivotAndPartition(){} // RVA: 0x283FA0
        public void Heapsort(){}
        public void DownHeap(){} // RVA: 0x283FA0
        public void InsertionSort(){}
        public void get_Default(){} // RVA: 0xC960
        public void .ctor(){} // RVA: 0x24A50
        public void .cctor(){} // RVA: 0x24A80
    }

    public class BitHelper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64A49D0 | overloaded x2
        public void MarkBit(){} // RVA: 0x667D8C0
        public void IsMarked(){} // RVA: 0x667D930
        public void ToIntArrayLength(){} // RVA: 0x667D9B0
    }

    public class ByteEqualityComparer
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x5E0EDF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5E0EE80 | overloaded x2
        public void IndexOf(){} // RVA: 0x5E0EB40
        public void LastIndexOf(){} // RVA: 0x3470870
        public void .ctor(){} // RVA: 0x5E0EEE0
    }

    public class CollectionDebugView`1
    {
    }

    public class CollectionExtensions
    {
        // ── Methods ──
        public void GetValueOrDefault(){} // RVA: 0x283FA0 | overloaded x2
        public void Remove(){} // RVA: 0x283FA0
    }

    public class Comparer`1
    {
        // ── Methods ──
        public void get_Default(){} // RVA: 0xC960
        public void CreateComparer(){} // RVA: 0xC960
        public void Compare(){} // RVA: 0x283FA0
        public void System.Collections.IComparer.Compare(){} // RVA: 0x17680
        public void .ctor(){} // RVA: 0x24A50
    }

    public class Deque`1
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0xD840
        public void get_IsEmpty(){} // RVA: 0xDBE0
        public void EnqueueTail(){} // RVA: 0x283FA0
        public void DequeueHead(){} // RVA: 0x283FA0
        public void DequeueTail(){} // RVA: 0x283FA0
        public void Grow(){} // RVA: 0x24A50
        public void .ctor(){} // RVA: 0x24A50
    }

    public class DictionaryDebugView`2
    {
    }

    public class DictionaryKeyCollectionDebugView`2
    {
    }

    public class DictionaryValueCollectionDebugView`2
    {
    }

    public class Dictionary`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E30E30 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2E30EC0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2E30EE0
        public void set_Item(){} // RVA: 0x2E30F80
        public void Add(){} // RVA: 0x2E30FB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2E30FE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2E31030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2E310F0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2E311D0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2CC1810
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2E31200
        public void FindEntry(){} // RVA: 0x2E31550
        public void Initialize(){} // RVA: 0x2E31880
        public void TryInsert(){} // RVA: 0x2E31A00
        public void OnDeserialization(){} // RVA: 0x2E31FC0
        public void Resize(){} // RVA: 0x2E324E0 | overloaded x2
        public void Remove(){} // RVA: 0x2E32990 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2E32C70
        public void TryAdd(){} // RVA: 0x2E32D30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CC31B0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2E32D60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2E330F0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2E331E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2E33290
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2E333B0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2E33570
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2E33730
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2E33840
    }

    public class EnumEqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0xDE40 | overloaded x2
        public void GetHashCode(){} // RVA: 0xD840 | overloaded x2
        public void .ctor(){} // RVA: 0x24A50 | overloaded x2
        public void GetObjectData(){}
    }

    public class EnumerableHelpers
    {
        // ── Methods ──
        public void ToArray(){} // RVA: 0xCEC0 | overloaded x2
    }

    public class EqualityComparer`1
    {
        // ── Methods ──
        public void get_Default(){} // RVA: 0x26592B0
        public void CreateComparer(){} // RVA: 0x322F410
        public void Equals(){}
        public void GetHashCode(){}
        public void IndexOf(){} // RVA: 0x2F965B0
        public void LastIndexOf(){} // RVA: 0x2F96650
        public void System.Collections.IEqualityComparer.GetHashCode(){} // RVA: 0x2F966F0
        public void System.Collections.IEqualityComparer.Equals(){} // RVA: 0x2F967D0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class GenericComparer`1
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x283FA0
        public void Equals(){} // RVA: 0xDE40
        public void GetHashCode(){} // RVA: 0xD840
        public void .ctor(){} // RVA: 0x24A50
    }

    public class GenericEqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x3441970 | overloaded x2
        public void GetHashCode(){} // RVA: 0x2EC3450 | overloaded x2
        public void IndexOf(){} // RVA: 0x3441EA0
        public void LastIndexOf(){} // RVA: 0x3441F90
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class HashSet`1 : System.Collections.Generic
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x26C40 | overloaded x7
        public void CopyFrom(){} // RVA: 0x24B10
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x283FA0
        public void Clear(){} // RVA: 0x24A50
        public void Contains(){} // RVA: 0x283FA0
        public void CopyTo(){} // RVA: 0x24B10 | overloaded x3
        public void Remove(){} // RVA: 0x283FA0
        public void get_Count(){} // RVA: 0xD840
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xDBE0
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void GetObjectData(){}
        public void OnDeserialization(){} // RVA: 0x24B10
        public void Add(){} // RVA: 0x283FA0
        public void UnionWith(){} // RVA: 0x24B10
        public void IntersectWith(){} // RVA: 0x24B10
        public void SetEquals(){} // RVA: 0xDE40
        public void RemoveWhere(){} // RVA: 0x12590
        public void get_Comparer(){} // RVA: 0xCD60
        public void TrimExcess(){} // RVA: 0x24A50
        public void Initialize(){} // RVA: 0x13FB0
        public void IncreaseCapacity(){} // RVA: 0x24A50
        public void SetCapacity(){} // RVA: 0x24FA0
        public void AddIfNotPresent(){} // RVA: 0x283FA0
        public void AddValue(){} // RVA: 0x283FA0
        public void ContainsAllElements(){} // RVA: 0xDE40
        public void IntersectWithHashSetWithSameEC(){} // RVA: 0x24B10
        public void IntersectWithEnumerable(){} // RVA: 0x24B10
        public void InternalIndexOf(){} // RVA: 0x283FA0
        public void CheckUniqueAndUnfoundElements(){} // RVA: 0x283FA0
        public void AreEqualityComparersEqual(){} // RVA: 0xE230
        public void InternalGetHashCode(){} // RVA: 0x283FA0
    }

    public class IAsyncEnumerable`1
    {
        // ── Methods ──
        public void GetAsyncEnumerator(){}
    }

    public class IAsyncEnumerator`1
    {
        // ── Methods ──
        public void MoveNextAsync(){}
        public void get_Current(){} // RVA: 0x283FA0
    }

    public class ICollectionDebugView`1
    {
    }

    public class ICollection`1
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0xD840
        public void get_IsReadOnly(){} // RVA: 0xDBE0
        public void Add(){} // RVA: 0x24B10
        public void Clear(){} // RVA: 0x24A50
        public void Contains(){} // RVA: 0xDE40
        public void CopyTo(){} // RVA: 0x2BAA0
        public void Remove(){} // RVA: 0xDE40
    }

    public class IComparer`1
    {
    }

    public class IDictionaryDebugView`2
    {
    }

    public class IDictionary`2
    {
    }

    public class IEnumerable`1
    {
        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0xCD60
    }

    public class IEnumerator`1
    {
        // ── Methods ──
        public void get_Current(){} // RVA: 0xCD60
    }

    public class IEqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){}
        public void GetHashCode(){}
    }

    public class IList`1
    {
    }

    public class IReadOnlyCollection`1
    {
    }

    public class IReadOnlyDictionary`2
    {
    }

    public class IReadOnlyList`1
    {
    }

    public class ISet`1
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x283FA0
    }

    public class InternalStringComparer
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x3475430
        public void Equals(){} // RVA: 0x5E0EF10
        public void IndexOf(){} // RVA: 0x5E0EF60
        public void .ctor(){} // RVA: 0x5E0F010
    }

    public class IntrospectiveSortUtilities
    {
        // ── Methods ──
        public void FloorLog2PlusOne(){} // RVA: 0x5E0EAB0
        public void ThrowOrIgnoreBadComparer(){} // RVA: 0x5E0EAD0
    }

    public class KeyNotFoundException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x3
    }

    public class KeyValuePair
    {
        // ── Methods ──
        public void PairToString(){} // RVA: 0x5E0E920
    }

    public class KeyValuePair`2
    {
    }

    public class LargeArrayBuilder`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24FA0 | overloaded x2
        public void AddRange(){} // RVA: 0x24B10
        public void AddWithBufferAllocation(){} // RVA: 0x283FA0
        public void CopyTo(){}
        public void GetBuffer(){} // RVA: 0x1BCC0
        public void ToArray(){} // RVA: 0xCD60
        public void TryMove(){} // RVA: 0xDE40
        public void AllocateBuffer(){} // RVA: 0x24A50
    }

    public class LinkedListNode`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x37E5BA0
        public void get_List(){} // RVA: 0x2F8380
        public void get_Next(){} // RVA: 0x37E58D0
        public void get_Value(){} // RVA: 0x30B130
        public void set_Value(){} // RVA: 0x2DEE90
        public void Invalidate(){} // RVA: 0x37E5970
    }

    public class LinkedList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE90 | overloaded x2
        public void get_Count(){} // RVA: 0x5BED50
        public void get_First(){} // RVA: 0x2F8380
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x37E9DD0
        public void AddFirst(){} // RVA: 0x37E9DF0
        public void AddLast(){} // RVA: 0x37E6430 | overloaded x2
        public void Clear(){} // RVA: 0x37E6560
        public void Contains(){} // RVA: 0x37E9F80
        public void CopyTo(){} // RVA: 0x37E9FB0
        public void Find(){} // RVA: 0x37EA1B0
        public void GetEnumerator(){} // RVA: 0x37EA270
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x37EA2A0
        public void Remove(){} // RVA: 0x37E6B90 | overloaded x2
        public void RemoveFirst(){} // RVA: 0x37E6C50
        public void GetObjectData(){} // RVA: 0x37EA440
        public void OnDeserialization(){} // RVA: 0x37EA690
        public void InternalInsertNodeBefore(){} // RVA: 0x37E73C0
        public void InternalInsertNodeToEmptyList(){} // RVA: 0x37E7560
        public void InternalRemoveNode(){} // RVA: 0x37E7680
        public void ValidateNewNode(){} // RVA: 0x37E7850
        public void ValidateNode(){} // RVA: 0x37E78F0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x37EAB50
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37EAC00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x37EA2A0
    }

    public class List`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A05E70 | overloaded x3
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3872610
        public void get_Count(){} // RVA: 0x5BED50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3A060E0
        public void get_Item(){} // RVA: 0x3883BA0
        public void set_Item(){} // RVA: 0x39D5850
        public void IsCompatibleObject(){} // RVA: 0x38B4F70
        public void System.Collections.IList.get_Item(){} // RVA: 0x3883BA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3A06190
        public void Add(){} // RVA: 0x301D60
        public void AddWithResize(){} // RVA: 0x3A06290
        public void System.Collections.IList.Add(){} // RVA: 0x3A062F0
        public void AddRange(){} // RVA: 0x3A06420
        public void AsReadOnly(){} // RVA: 0x3872CE0
        public void BinarySearch(){} // RVA: 0x3A06520 | overloaded x3
        public void Clear(){} // RVA: 0x44B290
        public void Contains(){} // RVA: 0x3A06590
        public void System.Collections.IList.Contains(){} // RVA: 0x3A065F0
        public void ConvertAll(){} // RVA: 0xCE10
        public void CopyTo(){} // RVA: 0x38731B0 | overloaded x3
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3873110
        public void EnsureCapacity(){} // RVA: 0x3897DE0
        public void Exists(){} // RVA: 0x3A06720
        public void Find(){} // RVA: 0x398A930
        public void FindAll(){} // RVA: 0x3A06750
        public void FindIndex(){} // RVA: 0x398ABA0 | overloaded x2
        public void FindLastIndex(){} // RVA: 0x398AD20 | overloaded x2
        public void ForEach(){} // RVA: 0x38848A0
        public void GetEnumerator(){} // RVA: 0x3884940
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x38849D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x38849D0
        public void GetRange(){} // RVA: 0x3873B00
        public void IndexOf(){} // RVA: 0x3A06A40 | overloaded x3
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3A068B0
        public void Insert(){} // RVA: 0x3A06AA0
        public void System.Collections.IList.Insert(){} // RVA: 0x3A06B60
        public void InsertRange(){} // RVA: 0x3A06C50
        public void LastIndexOf(){} // RVA: 0x3A07010 | overloaded x3
        public void Remove(){} // RVA: 0x3A070C0
        public void System.Collections.IList.Remove(){} // RVA: 0x3A07150
        public void RemoveAll(){} // RVA: 0x3A07270
        public void RemoveAt(){} // RVA: 0x39D6C90
        public void RemoveRange(){} // RVA: 0x3874AD0
        public void Reverse(){} // RVA: 0x3A07420 | overloaded x2
        public void Sort(){} // RVA: 0x3A075B0 | overloaded x4
        public void ToArray(){} // RVA: 0x3874F20
        public void TrimExcess(){} // RVA: 0x3898D00
        public void TrueForAll(){} // RVA: 0x398BF00
        public void AddEnumerable(){} // RVA: 0x3A07670
        public void .cctor(){} // RVA: 0x3875370
    }

    public class LongEnumEqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0xDE40 | overloaded x2
        public void GetHashCode(){} // RVA: 0xD840 | overloaded x2
        public void .ctor(){} // RVA: 0x24A50 | overloaded x2
        public void GetObjectData(){}
    }

    public class LowLevelDictionary`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x26C40 | overloaded x2
        public void set_Item(){} // RVA: 0x283FA0
        public void Clear(){} // RVA: 0x24FA0
        public void Remove(){} // RVA: 0x283FA0
        public void Find(){} // RVA: 0x283FA0
        public void UncheckedAdd(){} // RVA: 0x283FA0
        public void ExpandBuckets(){} // RVA: 0x24A50
        public void GetBucket(){} // RVA: 0x283FA0
    }

    public class LowLevelListWithIList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24FA0 | overloaded x2
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xDBE0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    }

    public class LowLevelList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3BE51E0 | overloaded x2
        public void get_Capacity(){} // RVA: 0xF3F910
        public void set_Capacity(){} // RVA: 0x3BE5390
        public void get_Count(){} // RVA: 0x5BED50
        public void get_Item(){} // RVA: 0x263BC0
        public void set_Item(){} // RVA: 0x3BE6180
        public void Add(){} // RVA: 0x3BE6330
        public void EnsureCapacity(){} // RVA: 0x3BE64D0
        public void AddRange(){} // RVA: 0x3BE6530
        public void Clear(){} // RVA: 0x3BE57B0
        public void Contains(){} // RVA: 0x3BE6550
        public void CopyTo(){} // RVA: 0x38731B0
        public void IndexOf(){} // RVA: 0x3BE6760
        public void Insert(){} // RVA: 0x3BE6880
        public void InsertRange(){} // RVA: 0x3BE6A90
        public void Remove(){} // RVA: 0x3BE6EB0
        public void RemoveAll(){} // RVA: 0x3BE6FD0
        public void RemoveAt(){} // RVA: 0x3BE7310
        public void .cctor(){} // RVA: 0x3875370
    }

    public class NullableComparer`1
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x283FA0
        public void Equals(){} // RVA: 0xDE40
        public void GetHashCode(){} // RVA: 0xD840
        public void .ctor(){} // RVA: 0x24A50
    }

    public class NullableEqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0xDE40 | overloaded x2
        public void GetHashCode(){} // RVA: 0xD840 | overloaded x2
        public void IndexOf(){} // RVA: 0x283FA0
        public void LastIndexOf(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24A50
    }

    public class ObjectComparer`1
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x283FA0
        public void Equals(){} // RVA: 0xDE40
        public void GetHashCode(){} // RVA: 0xD840
        public void .ctor(){} // RVA: 0x24A50
    }

    public class ObjectEqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x3D25C00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x2EC3450 | overloaded x2
        public void IndexOf(){} // RVA: 0x3D25DD0
        public void LastIndexOf(){} // RVA: 0x3D25EF0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class QueueDebugView`1
    {
    }

    public class Queue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E1B3B0 | overloaded x3
        public void get_Count(){} // RVA: 0x760030
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3E1B4A0
        public void Clear(){} // RVA: 0x3E15E70
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3E15EE0
        public void Enqueue(){} // RVA: 0x3E1B550
        public void GetEnumerator(){} // RVA: 0x3E1AF90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3E1B020
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3E1B020
        public void Dequeue(){} // RVA: 0x3E1B700
        public void TryDequeue(){} // RVA: 0x3E1B7A0
        public void Peek(){} // RVA: 0x3E1B1D0
        public void Contains(){} // RVA: 0x3E1B870
        public void ToArray(){} // RVA: 0x3E1B980
        public void SetCapacity(){} // RVA: 0x3E16A70
        public void MoveNext(){} // RVA: 0x3C461A0
        public void ThrowForEmptyQueue(){} // RVA: 0x3E16BB0
    }

    public class ReferenceEqualityComparer : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Instance(){} // RVA: 0x62F69C0
        public void Equals(){} // RVA: 0x3473E20
        public void GetHashCode(){} // RVA: 0x5FF7850
        public void .cctor(){} // RVA: 0x62F6A20
    }

    public class SByteEnumEqualityComparer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50 | overloaded x2
        public void GetHashCode(){} // RVA: 0x283FA0
    }

    public class ShortEnumEqualityComparer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50 | overloaded x2
        public void GetHashCode(){} // RVA: 0x283FA0
    }

    public class SortedDictionary`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10 | overloaded x3
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xDBE0
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void get_Count(){} // RVA: 0xD840
        public void get_Keys(){} // RVA: 0xCD60
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0xCD60
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0xCD60
        public void get_Values(){} // RVA: 0xCD60
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0xCD60
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0xCD60
        public void Add(){} // RVA: 0x283FA0
        public void Clear(){} // RVA: 0x24A50
        public void ContainsKey(){} // RVA: 0x283FA0
        public void ContainsValue(){} // RVA: 0x283FA0
        public void CopyTo(){} // RVA: 0x2BAA0
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0xCD60
        public void Remove(){} // RVA: 0x283FA0
        public void TryGetValue(){} // RVA: 0x283FA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xDBE0
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xDBE0
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0xCE10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DC60
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DC60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0xDE40
        public void IsCompatibleKey(){} // RVA: 0xDCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x24B10
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    }

    public class SortedList`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10 | overloaded x2
        public void Add(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x283FA0
        public void set_Capacity(){} // RVA: 0x24FA0
        public void get_Comparer(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DC60
        public void get_Count(){} // RVA: 0xD840
        public void get_Keys(){} // RVA: 0xCD60
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0xCD60
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0xCD60
        public void get_Values(){} // RVA: 0xCD60
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0xCD60
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0xCD60
        public void GetKeyListHelper(){} // RVA: 0xCD60
        public void GetValueListHelper(){} // RVA: 0xCD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xDBE0
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xDBE0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void Clear(){} // RVA: 0x24A50
        public void System.Collections.IDictionary.Contains(){} // RVA: 0xDE40
        public void ContainsKey(){} // RVA: 0x283FA0
        public void ContainsValue(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void EnsureCapacity(){} // RVA: 0x24FA0
        public void GetByIndex(){} // RVA: 0x283FA0
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void GetKey(){} // RVA: 0x283FA0
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0xCE10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DC60
        public void IndexOfKey(){} // RVA: 0x283FA0
        public void IndexOfValue(){} // RVA: 0x283FA0
        public void Insert(){} // RVA: 0x283FA0
        public void TryGetValue(){} // RVA: 0x283FA0
        public void RemoveAt(){} // RVA: 0x24FA0
        public void Remove(){} // RVA: 0x283FA0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x24B10
        public void IsCompatibleKey(){} // RVA: 0xDCC0
    }

    public class SortedSet`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10 | overloaded x3
        public void InOrderTreeWalk(){} // RVA: 0xDE40
        public void BreadthFirstTreeWalk(){} // RVA: 0xDE40
        public void get_Count(){} // RVA: 0xD840
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void VersionCheck(){} // RVA: 0x24A50
        public void IsWithinRange(){} // RVA: 0x283FA0
        public void Add(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x283FA0
        public void AddIfNotPresent(){} // RVA: 0x283FA0
        public void Remove(){} // RVA: 0x283FA0
        public void DoRemove(){} // RVA: 0x283FA0
        public void Clear(){} // RVA: 0x24A50
        public void Contains(){} // RVA: 0x283FA0
        public void CopyTo(){} // RVA: 0x2BAA0 | overloaded x2
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void InsertionBalance(){} // RVA: 0x2F9F0
        public void ReplaceChildOrRoot(){} // RVA: 0x2F090
        public void ReplaceNode(){} // RVA: 0x2F9F0
        public void FindNode(){} // RVA: 0x283FA0
        public void UpdateVersion(){} // RVA: 0x24A50
        public void RemoveWhere(){} // RVA: 0x12590
        public void get_Min(){} // RVA: 0x283FA0
        public void get_MinInternal(){} // RVA: 0x283FA0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){}
        public void GetObjectData(){}
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x24B10
        public void OnDeserialization(){} // RVA: 0x24B10
        public void Log2(){} // RVA: 0x13FF0
    }

    public class StackDebugView`1
    {
    }

    public class StackExtensions
    {
        // ── Methods ──
        public void TryPeek(){} // RVA: 0xE230
        public void TryPop(){} // RVA: 0xE230
    }

    public class Stack`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24FA0 | overloaded x2
        public void get_Count(){} // RVA: 0xD840
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void Clear(){} // RVA: 0x24A50
        public void Contains(){} // RVA: 0x283FA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void Peek(){} // RVA: 0x283FA0
        public void Pop(){} // RVA: 0x283FA0
        public void TryPop(){} // RVA: 0xDE40
        public void Push(){} // RVA: 0x283FA0
        public void PushWithResize(){} // RVA: 0x283FA0
        public void ThrowForEmptyStack(){} // RVA: 0x24A50
    }

    public class TreeSet`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10 | overloaded x3
        public void AddIfNotPresent(){} // RVA: 0x283FA0
    }

    public class TreeWalkPredicate`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0xDE40
    }

    public class ValueListBuilder`1
    {
        public object Length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void get_Length(){} // RVA: 0xD840
        public void get_Item(){} // RVA: 0x1BCC0
        public void Append(){} // RVA: 0x283FA0
        public void AsSpan(){} // RVA: 0x283FA0
        public void Dispose(){} // RVA: 0x24A50
        public void Grow(){} // RVA: 0x24A50
        public void Pop(){} // RVA: 0x283FA0
    }

}