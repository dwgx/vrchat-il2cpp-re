// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Generic
// Classes: 65
// Methods: 484

namespace ThirdParty.DotNet.System.Collections.Generic
{
    public class ArrayBuilder`1 : ValueType
    {
        public T[] _array;
        public int _count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70ED0
        public void ToArray(){} // RVA: 0x7FFAC2C58E90
        public void UncheckedAdd(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ArraySortHelper`1 : Object
    {
        public System.Collections.Generic.ArraySortHelper`1<System.Collections.Generic.KeyValuePair`2<System.Tuple`2<string,System.Type>,UnityEngine.Object>> s_defaultArraySortHelper;
    }

    public class ArraySortHelper`2 : Object
    {
        public System.Collections.Generic.ArraySortHelper`2<U,T> Default;

        // ── Methods ──
        public void Sort(){}
        public void SwapIfGreaterWithItems(){}
        public void Swap(){} // RVA: 0x7FFAC2C7A460
        public void IntrospectiveSort(){}
        public void IntroSort(){} // RVA: 0x7FFAC2E8DC40
        public void PickPivotAndPartition(){} // RVA: 0x7FFAC2E8DC40
        public void Heapsort(){}
        public void DownHeap(){} // RVA: 0x7FFAC2E8DC40
        public void InsertionSort(){}
        public void get_Default(){} // RVA: 0x7FFAC2C58A90
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class BitHelper : Object
    {
        public int _length; // 0x10
        public int* _arrayPtr; // 0x18
        public int[] _array; // 0x20
        public bool _useStackAlloc; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C3B560 | overloaded x2
        public void MarkBit(){} // RVA: 0x7FFAC8E14380
        public void IsMarked(){} // RVA: 0x7FFAC8E143F0
        public void ToIntArrayLength(){} // RVA: 0x7FFAC8E14470
    }

    public class ByteEqualityComparer : EqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC85A6460 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC85A64F0 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFAC85A61B0
        public void LastIndexOf(){} // RVA: 0x7FFAC5D9D640
        public void .ctor(){} // RVA: 0x7FFAC85A6550
    }

    public class CollectionDebugView`1 : Object
    {
    }

    public class CollectionExtensions : Object
    {
        // ── Methods ──
        public void GetValueOrDefault(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Comparer`1 : Object
    {
        public System.Collections.Generic.Comparer`1<T> Default;

        // ── Methods ──
        public void get_Default(){} // RVA: 0x7FFAC2C58A90
        public void CreateComparer(){} // RVA: 0x7FFAC2C58A90
        public void Compare(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.IComparer.Compare(){} // RVA: 0x7FFAC2C637A0
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class Deque`1 : Object
    {
        public T[] Count;
        public int IsEmpty;
        public int _tail;
        public int _size;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_IsEmpty(){} // RVA: 0x7FFAC2C59D00
        public void EnqueueTail(){} // RVA: 0x7FFAC2E8DC40
        public void DequeueHead(){} // RVA: 0x7FFAC2E8DC40
        public void DequeueTail(){} // RVA: 0x7FFAC2E8DC40
        public void Grow(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class DictionaryDebugView`2 : Object
    {
    }

    public class DictionaryKeyCollectionDebugView`2 : Object
    {
    }

    public class DictionaryValueCollectionDebugView`2 : Object
    {
    }

    public class Dictionary`2 : Object
    {
        public int[] Comparer; // 0x10
        public Entry<string,ÍÍÏÌÍÎÏÏÏÎÏÌÏÏÎÍÏÍÌÏÏÍÌ>[] Count; // 0x18
        public int Keys; // 0x20
        public int System.Collections.Generic.IDictionary<TKey,TValue>.Keys; // 0x24
        public int System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys; // 0x28
        public int Values; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> System.Collections.Generic.IDictionary<TKey,TValue>.Values; // 0x30
        public KeyCollection<string,ÍÍÏÌÍÎÏÏÏÎÏÌÏÏÎÍÏÍÌÏÏÍÌ> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values; // 0x38
        public ValueCollection<string,ÍÍÏÌÍÎÏÏÏÎÏÌÏÏÎÍÏÍÌÏÏÍÌ> Item; // 0x40
        public object System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly; // 0x48
        public string System.Collections.ICollection.IsSynchronized;
        public string System.Collections.ICollection.SyncRoot;
        public string System.Collections.IDictionary.IsFixedSize;
        public string System.Collections.IDictionary.IsReadOnly;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC56CB820 | overloaded x9
        public void get_Comparer(){} // RVA: 0x7FFAC56906C0
        public void get_Count(){} // RVA: 0x7FFAC559F370
        public void get_Keys(){} // RVA: 0x7FFAC559F380
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAC559F380
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAC559F380
        public void get_Values(){} // RVA: 0x7FFAC559F490
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAC559F490
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAC559F490
        public void get_Item(){} // RVA: 0x7FFAC56C6A20
        public void set_Item(){} // RVA: 0x7FFAC56CB8B0
        public void Add(){} // RVA: 0x7FFAC56CB8E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAC56CB910
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAC56CB960
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAC56CBA20
        public void Clear(){} // RVA: 0x7FFAC559F8E0
        public void ContainsKey(){} // RVA: 0x7FFAC56909A0
        public void ContainsValue(){} // RVA: 0x7FFAC55BEB80
        public void CopyTo(){} // RVA: 0x7FFAC56CBB00
        public void GetEnumerator(){} // RVA: 0x7FFAC55BEE00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFAC55BEE90
        public void GetObjectData(){} // RVA: 0x7FFAC56CBC60
        public void FindEntry(){} // RVA: 0x7FFAC5690F50
        public void Initialize(){} // RVA: 0x7FFAC56CBFC0
        public void TryInsert(){} // RVA: 0x7FFAC56CC140
        public void OnDeserialization(){} // RVA: 0x7FFAC56CC5A0
        public void Resize(){} // RVA: 0x7FFAC56CCAE0 | overloaded x2
        public void Remove(){} // RVA: 0x7FFAC5692200 | overloaded x2
        public void TryGetValue(){} // RVA: 0x7FFAC5692480
        public void TryAdd(){} // RVA: 0x7FFAC56CCD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAC56CCD90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC56CCDB0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC55BEE90
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC56CD140
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAC55CCC80
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAC55C0C20
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAC56CD1F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAC56CD310
        public void IsCompatibleKey(){} // RVA: 0x7FFAC55A25B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAC56CD4D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAC5692EB0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAC55C11F0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAC5692FD0
    }

    public class EnumEqualityComparer`1 : EqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2C59F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2C70980 | overloaded x2
        public void GetObjectData(){}
    }

    public class EnumerableHelpers : Object
    {
        // ── Methods ──
        public void ToArray(){} // RVA: 0x7FFAC2C58FF0 | overloaded x2
    }

    public class EqualityComparer`1 : Object
    {
        public System.Collections.Generic.EqualityComparer`1<HIDPageUsage> Default;

        // ── Methods ──
        public void get_Default(){} // RVA: 0x7FFAC50F7970
        public void CreateComparer(){} // RVA: 0x7FFAC5B992A0
        public void Equals(){}
        public void GetHashCode(){}
        public void IndexOf(){} // RVA: 0x7FFAC5926A60
        public void LastIndexOf(){} // RVA: 0x7FFAC5926B00
        public void System.Collections.IEqualityComparer.GetHashCode(){} // RVA: 0x7FFAC5926BA0
        public void System.Collections.IEqualityComparer.Equals(){} // RVA: 0x7FFAC5926C80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class GenericComparer`1 : Comparer`1
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFAC2E8DC40
        public void Equals(){} // RVA: 0x7FFAC2C59F60
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class GenericEqualityComparer`1 : EqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC5D73ED0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC58559D0 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFAC5D74400
        public void LastIndexOf(){} // RVA: 0x7FFAC5D744F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class HashSet`1 : Object
    {
        public int Count;
        public int System.Collections.Generic.ICollection<T>.IsReadOnly;
        public int Comparer;
        public string CapacityName;
        public string ElementsName;
        public string ComparerName;
        public string VersionName;
        public int[] _buckets;
        public Slot<T>[] _slots;
        public int _count;
        public int _lastIndex;
        public int _freeList;
        public System.Collections.Generic.IEqualityComparer`1<T> _comparer;
        public int _version;
        public System.Runtime.Serialization.SerializationInfo _siInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C72BC0 | overloaded x7
        public void CopyFrom(){} // RVA: 0x7FFAC2C70A40
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFAC2E8DC40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo(){} // RVA: 0x7FFAC2C70A40 | overloaded x3
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void GetObjectData(){}
        public void OnDeserialization(){} // RVA: 0x7FFAC2C70A40
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void UnionWith(){} // RVA: 0x7FFAC2C70A40
        public void IntersectWith(){} // RVA: 0x7FFAC2C70A40
        public void SetEquals(){} // RVA: 0x7FFAC2C59F60
        public void RemoveWhere(){} // RVA: 0x7FFAC2C5E6B0
        public void get_Comparer(){} // RVA: 0x7FFAC2C58E90
        public void TrimExcess(){} // RVA: 0x7FFAC2C70980
        public void Initialize(){} // RVA: 0x7FFAC2C600D0
        public void IncreaseCapacity(){} // RVA: 0x7FFAC2C70980
        public void SetCapacity(){} // RVA: 0x7FFAC2C70ED0
        public void AddIfNotPresent(){} // RVA: 0x7FFAC2E8DC40
        public void AddValue(){} // RVA: 0x7FFAC2E8DC40
        public void ContainsAllElements(){} // RVA: 0x7FFAC2C59F60
        public void IntersectWithHashSetWithSameEC(){} // RVA: 0x7FFAC2C70A40
        public void IntersectWithEnumerable(){} // RVA: 0x7FFAC2C70A40
        public void InternalIndexOf(){} // RVA: 0x7FFAC2E8DC40
        public void CheckUniqueAndUnfoundElements(){} // RVA: 0x7FFAC2E8DC40
        public void AreEqualityComparersEqual(){} // RVA: 0x7FFAC2C5A350
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IAsyncEnumerable`1
    {
        // ── Methods ──
        public void GetAsyncEnumerator(){}
    }

    public class IAsyncEnumerator`1
    {
        public object Current;

        // ── Methods ──
        public void MoveNextAsync(){}
        public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ICollectionDebugView`1 : Object
    {
    }

    public class ICollection`1
    {
    }

    public class IComparer`1
    {
    }

    public class IDictionaryDebugView`2 : Object
    {
    }

    public class IDictionary`2
    {
    }

    public class IEnumerable`1
    {
        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class IEnumerator`1
    {
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
        public void Add(){} // RVA: 0x7FFAC2E8DC40
    }

    public class InternalStringComparer : EqualityComparer`1
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFAC5DA2200
        public void Equals(){} // RVA: 0x7FFAC85A6580
        public void IndexOf(){} // RVA: 0x7FFAC85A65D0
        public void .ctor(){} // RVA: 0x7FFAC85A6680
    }

    public class IntrospectiveSortUtilities : Object
    {
        // ── Methods ──
        public void FloorLog2PlusOne(){} // RVA: 0x7FFAC85A6110
        public void ThrowOrIgnoreBadComparer(){} // RVA: 0x7FFAC85A6130
    }

    public class KeyNotFoundException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class KeyValuePair : Object
    {
        // ── Methods ──
        public void PairToString(){} // RVA: 0x7FFAC85A5F80
    }

    public class KeyValuePair`2 : ValueType
    {
        public Transmtn.DTO.Notifications.Notification[][] key; // 0x10
        public object value; // 0x18
    }

    public class LargeArrayBuilder`1 : ValueType
    {
        public int _maxCapacity;
        public T[] _first;
        public System.Collections.Generic.ArrayBuilder`1<T[]> _buffers;
        public T[] _current;
        public int _index;
        public int _count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70ED0 | overloaded x2
        public void AddRange(){} // RVA: 0x7FFAC2C70A40
        public void AddWithBufferAllocation(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo(){}
        public void GetBuffer(){} // RVA: 0x7FFAC2C67DE0
        public void ToArray(){} // RVA: 0x7FFAC2C58E90
        public void TryMove(){} // RVA: 0x7FFAC2C59F60
        public void AllocateBuffer(){} // RVA: 0x7FFAC2C70980
    }

    public class LinkedListNode`1 : Object
    {
        public System.Collections.Generic.LinkedList`1<System.Action`1<UnityEngine.Object>> List; // 0x10
        public System.Collections.Generic.LinkedListNode`1<System.Action`1<UnityEngine.Object>> Next; // 0x18
        public System.Collections.Generic.LinkedListNode`1<System.Action`1<UnityEngine.Object>> Value; // 0x20
        public System.Action`1<UnityEngine.Object> item; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC6111120
        public void get_List(){} // RVA: 0x7FFAC2F3C380
        public void get_Next(){} // RVA: 0x7FFAC6110E50
        public void get_Value(){} // RVA: 0x7FFAC2F4F130
        public void set_Value(){} // RVA: 0x7FFAC2F22E90
        public void Invalidate(){} // RVA: 0x7FFAC6110EF0
    }

    public class LinkedList`1 : Object
    {
        public System.Collections.Generic.LinkedListNode`1<System.Action`1<UnityEngine.Object>> Count; // 0x10
        public int First; // 0x18
        public int System.Collections.Generic.ICollection<T>.IsReadOnly; // 0x1C
        public object System.Collections.ICollection.IsSynchronized; // 0x20
        public System.Runtime.Serialization.SerializationInfo System.Collections.ICollection.SyncRoot; // 0x28
        public string VersionName;
        public string CountName;
        public string ValuesName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E90 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFAC3157800
        public void get_First(){} // RVA: 0x7FFAC2F3C380
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFAC6115350
        public void AddFirst(){} // RVA: 0x7FFAC6115370
        public void AddLast(){} // RVA: 0x7FFAC61119B0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAC6111AE0
        public void Contains(){} // RVA: 0x7FFAC6115500
        public void CopyTo(){} // RVA: 0x7FFAC6115530
        public void Find(){} // RVA: 0x7FFAC6115730
        public void GetEnumerator(){} // RVA: 0x7FFAC61157F0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC6115820
        public void Remove(){} // RVA: 0x7FFAC6112110 | overloaded x2
        public void RemoveFirst(){} // RVA: 0x7FFAC61121D0
        public void GetObjectData(){} // RVA: 0x7FFAC61159C0
        public void OnDeserialization(){} // RVA: 0x7FFAC6115C10
        public void InternalInsertNodeBefore(){} // RVA: 0x7FFAC6112940
        public void InternalInsertNodeToEmptyList(){} // RVA: 0x7FFAC6112AE0
        public void InternalRemoveNode(){} // RVA: 0x7FFAC6112C00
        public void ValidateNewNode(){} // RVA: 0x7FFAC6112DD0
        public void ValidateNode(){} // RVA: 0x7FFAC6112E70
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC61160D0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC6116180
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC6115820
    }

    public class List`1 : Object
    {
        public int DefaultCapacity;
        public Newtonsoft.Json.Utilities.StructMultiKey`2<string,string>[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public Newtonsoft.Json.Utilities.StructMultiKey`2<string,string>[] s_emptyArray;
    }

    public class LongEnumEqualityComparer`1 : EqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2C59F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2C70980 | overloaded x2
        public void GetObjectData(){}
    }

    public class LowLevelDictionary`2 : Object
    {
        public Entry<U,T>[] Item;
        public int _numEntries;
        public int _version;
        public System.Collections.Generic.IEqualityComparer`1<U> _comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C72BC0 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void Clear(){} // RVA: 0x7FFAC2C70ED0
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void Find(){} // RVA: 0x7FFAC2E8DC40
        public void UncheckedAdd(){} // RVA: 0x7FFAC2E8DC40
        public void ExpandBuckets(){} // RVA: 0x7FFAC2C70980
        public void GetBucket(){} // RVA: 0x7FFAC2E8DC40
    }

    public class LowLevelListWithIList`1 : LowLevelList`1
    {
        public object System.Collections.Generic.ICollection<T>.IsReadOnly;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70ED0 | overloaded x2
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class LowLevelList`1 : Object
    {
        public int Capacity;
        public T[] Count; // 0x10
        public int Item; // 0x18
        public int _version; // 0x1C
        public T[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC64E8C10 | overloaded x2
        public void get_Capacity(){} // RVA: 0x7FFAC3510620
        public void set_Capacity(){} // RVA: 0x7FFAC64E8DC0
        public void get_Count(){} // RVA: 0x7FFAC3157800
        public void get_Item(){} // RVA: 0x7FFAC2E5B230
        public void set_Item(){} // RVA: 0x7FFAC64E9CB0
        public void Add(){} // RVA: 0x7FFAC64E9E60
        public void EnsureCapacity(){} // RVA: 0x7FFAC64EA000
        public void AddRange(){} // RVA: 0x7FFAC64EA060
        public void Clear(){} // RVA: 0x7FFAC64E91E0
        public void Contains(){} // RVA: 0x7FFAC64EA080
        public void CopyTo(){} // RVA: 0x7FFAC6180EA0
        public void IndexOf(){} // RVA: 0x7FFAC64EA290
        public void Insert(){} // RVA: 0x7FFAC64EA3B0
        public void InsertRange(){} // RVA: 0x7FFAC64EA5C0
        public void Remove(){} // RVA: 0x7FFAC64EA9E0
        public void RemoveAll(){} // RVA: 0x7FFAC64EAB00
        public void RemoveAt(){} // RVA: 0x7FFAC64EAE40
        public void .cctor(){} // RVA: 0x7FFAC6183060
    }

    public class NullableComparer`1 : Comparer`1
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFAC2E8DC40
        public void Equals(){} // RVA: 0x7FFAC2C59F60
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class NullableEqualityComparer`1 : EqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2C59F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFAC2E8DC40
        public void LastIndexOf(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class ObjectComparer`1 : Comparer`1
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFAC2E8DC40
        public void Equals(){} // RVA: 0x7FFAC2C59F60
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class ObjectEqualityComparer`1 : EqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC663FD90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC58559D0 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFAC663FF60
        public void LastIndexOf(){} // RVA: 0x7FFAC6640080
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class QueueDebugView`1 : Object
    {
    }

    public class Queue`1 : Object
    {
        public string[] Count; // 0x10
        public int System.Collections.ICollection.IsSynchronized; // 0x18
        public int System.Collections.ICollection.SyncRoot; // 0x1C
        public int _size; // 0x20
        public int _version; // 0x24
        public object _syncRoot; // 0x28
        public int MinimumGrow;
        public int GrowFactor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC673ED70 | overloaded x3
        public void get_Count(){} // RVA: 0x7FFAC30DBBE0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC673EE60
        public void Clear(){} // RVA: 0x7FFAC6739B00
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC6739B70
        public void Enqueue(){} // RVA: 0x7FFAC673EF10
        public void GetEnumerator(){} // RVA: 0x7FFAC673E950
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC673E9E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC673E9E0
        public void Dequeue(){} // RVA: 0x7FFAC673F0C0
        public void TryDequeue(){} // RVA: 0x7FFAC673F160
        public void Peek(){} // RVA: 0x7FFAC673EB90
        public void Contains(){} // RVA: 0x7FFAC673F230
        public void ToArray(){} // RVA: 0x7FFAC673F340
        public void SetCapacity(){} // RVA: 0x7FFAC673A700
        public void MoveNext(){} // RVA: 0x7FFAC6538D20
        public void ThrowForEmptyQueue(){} // RVA: 0x7FFAC673A840
    }

    public class ReferenceEqualityComparer : Object
    {
        public System.Collections.Generic.ReferenceEqualityComparer Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Instance(){} // RVA: 0x7FFAC8A8DD60
        public void Equals(){} // RVA: 0x7FFAC5DA0BF0
        public void GetHashCode(){} // RVA: 0x7FFAC878EEC0
        public void .cctor(){} // RVA: 0x7FFAC8A8DDC0
    }

    public class SByteEnumEqualityComparer`1 : EnumEqualityComparer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ShortEnumEqualityComparer`1 : EnumEqualityComparer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC2E8DC40
    }

    public class SortedDictionary`2 : Object
    {
        public KeyCollection<U,T> System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly;
        public ValueCollection<U,T> Item;
        public System.Collections.Generic.TreeSet`1<System.Collections.Generic.KeyValuePair`2<U,T>> Count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x3
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_Keys(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAC2C58E90
        public void get_Values(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAC2C58E90
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void ContainsKey(){} // RVA: 0x7FFAC2E8DC40
        public void ContainsValue(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo(){} // RVA: 0x7FFAC2C77970
        public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetValue(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC2C77970
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAC2C58F40
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAC2C79B30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAC2C79B30
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAC2C59F60
        public void IsCompatibleKey(){} // RVA: 0x7FFAC2C59DE0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAC2C70A40
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class SortedList`2 : Object
    {
        public U[] Capacity;
        public T[] Comparer;
        public int Count;
        public int Keys;
        public System.Collections.Generic.IComparer`1<U> System.Collections.Generic.IDictionary<TKey,TValue>.Keys;
        public KeyList<U,T> System.Collections.IDictionary.Keys;
        public ValueList<U,T> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys;
        public object Values;
        public int System.Collections.Generic.IDictionary<TKey,TValue>.Values;
        public int System.Collections.IDictionary.Values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAC2E8DC40
        public void set_Capacity(){} // RVA: 0x7FFAC2C70ED0
        public void get_Comparer(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAC2C79B30
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_Keys(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAC2C58E90
        public void get_Values(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAC2C58E90
        public void GetKeyListHelper(){} // RVA: 0x7FFAC2C58E90
        public void GetValueListHelper(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC2C58E90
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAC2C59F60
        public void ContainsKey(){} // RVA: 0x7FFAC2E8DC40
        public void ContainsValue(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAC2C77970
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC2C77970
        public void EnsureCapacity(){} // RVA: 0x7FFAC2C70ED0
        public void GetByIndex(){} // RVA: 0x7FFAC2E8DC40
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void GetKey(){} // RVA: 0x7FFAC2E8DC40
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAC2C58F40
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAC2C79B30
        public void IndexOfKey(){} // RVA: 0x7FFAC2E8DC40
        public void IndexOfValue(){} // RVA: 0x7FFAC2E8DC40
        public void Insert(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetValue(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveAt(){} // RVA: 0x7FFAC2C70ED0
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAC2C70A40
        public void IsCompatibleKey(){} // RVA: 0x7FFAC2C59DE0
    }

    public class SortedSet`1 : Object
    {
        public Node<T> Count;
        public System.Collections.Generic.IComparer`1<T> System.Collections.Generic.ICollection<T>.IsReadOnly;
        public int System.Collections.ICollection.IsSynchronized;
        public int System.Collections.ICollection.SyncRoot;
        public object Min;
        public System.Runtime.Serialization.SerializationInfo MinInternal;
        public string ComparerName;
        public string CountName;
        public string ItemsName;
        public string VersionName;
        public string TreeName;
        public string NodeValueName;
        public string EnumStartName;
        public string ReverseName;
        public string EnumVersionName;
        public string MinName;
        public string MaxName;
        public string LowerBoundActiveName;
        public string UpperBoundActiveName;
        public int StackAllocThreshold;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x3
        public void InOrderTreeWalk(){} // RVA: 0x7FFAC2C59F60
        public void BreadthFirstTreeWalk(){} // RVA: 0x7FFAC2C59F60
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC2C58E90
        public void VersionCheck(){} // RVA: 0x7FFAC2C70980
        public void IsWithinRange(){} // RVA: 0x7FFAC2E8DC40
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFAC2E8DC40
        public void AddIfNotPresent(){} // RVA: 0x7FFAC2E8DC40
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void DoRemove(){} // RVA: 0x7FFAC2E8DC40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo(){} // RVA: 0x7FFAC2C77970 | overloaded x2
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC2C77970
        public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void InsertionBalance(){} // RVA: 0x7FFAC2C7B8C0
        public void ReplaceChildOrRoot(){} // RVA: 0x7FFAC2C7AF60
        public void ReplaceNode(){} // RVA: 0x7FFAC2C7B8C0
        public void FindNode(){} // RVA: 0x7FFAC2E8DC40
        public void UpdateVersion(){} // RVA: 0x7FFAC2C70980
        public void RemoveWhere(){} // RVA: 0x7FFAC2C5E6B0
        public void get_Min(){} // RVA: 0x7FFAC2E8DC40
        public void get_MinInternal(){} // RVA: 0x7FFAC2E8DC40
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){}
        public void GetObjectData(){}
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFAC2C70A40
        public void OnDeserialization(){} // RVA: 0x7FFAC2C70A40
        public void Log2(){} // RVA: 0x7FFAC2C60110
    }

    public class StackDebugView`1 : Object
    {
    }

    public class StackExtensions : Object
    {
        // ── Methods ──
        public void TryPeek(){} // RVA: 0x7FFAC2C5A350
        public void TryPop(){} // RVA: 0x7FFAC2C5A350
    }

    public class Stack`1 : Object
    {
        public T[] Count;
        public int System.Collections.ICollection.IsSynchronized;
        public int System.Collections.ICollection.SyncRoot;
        public object _syncRoot;
        public int DefaultCapacity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70ED0 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC2C58E90
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC2C77970
        public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void Peek(){} // RVA: 0x7FFAC2E8DC40
        public void Pop(){} // RVA: 0x7FFAC2E8DC40
        public void TryPop(){} // RVA: 0x7FFAC2C59F60
        public void Push(){} // RVA: 0x7FFAC2E8DC40
        public void PushWithResize(){} // RVA: 0x7FFAC2E8DC40
        public void ThrowForEmptyStack(){} // RVA: 0x7FFAC2C70980
    }

    public class TreeSet`1 : SortedSet`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x3
        public void AddIfNotPresent(){} // RVA: 0x7FFAC2E8DC40
    }

    public class TreeWalkPredicate`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2C59F60
    }

    public class ValueListBuilder`1 : ValueType
    {
        public System.Span`1<T> Length;
        public T[] Item;
        public int _pos;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void get_Length(){} // RVA: 0x7FFAC2C59960
        public void get_Item(){} // RVA: 0x7FFAC2C67DE0
        public void Append(){} // RVA: 0x7FFAC2E8DC40
        public void AsSpan(){} // RVA: 0x7FFAC2E8DC40
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void Grow(){} // RVA: 0x7FFAC2C70980
        public void Pop(){} // RVA: 0x7FFAC2E8DC40
    }

}