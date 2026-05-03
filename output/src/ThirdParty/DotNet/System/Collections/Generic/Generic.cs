// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Generic
// Classes: 65
// Methods: 497

namespace ThirdParty.DotNet.System.Collections.Generic
{
    public class ArrayBuilder`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E46530
        public void ToArray(){} // RVA: 0x7FFE80E2E2E0
        public void UncheckedAdd(){} // RVA: 0x7FFE810A1420
    }

    public class ArraySortHelper`1 : Object
    {
        public System.Collections.Generic.ArraySortHelper`1<UnityEngine.InputSystem.Controls.ButtonControl> s_defaultArraySortHelper;
    }

    public class ArraySortHelper`2 : Object
    {
        public System.Collections.Generic.ArraySortHelper`2<U,T> s_defaultArraySortHelper;

        // ── Methods ──
        public void Sort(){}
        public void SwapIfGreaterWithItems(){}
        public void Swap(){} // RVA: 0x7FFE80E4FB60
        public void IntrospectiveSort(){}
        public void IntroSort(){} // RVA: 0x7FFE810A1420
        public void PickPivotAndPartition(){} // RVA: 0x7FFE810A1420
        public void Heapsort(){}
        public void DownHeap(){} // RVA: 0x7FFE810A1420
        public void InsertionSort(){}
        public void get_Default(){} // RVA: 0x7FFE80E2DEE0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class BitHelper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FE3A80 | overloaded x2
        public void MarkBit(){} // RVA: 0x7FFE871BC7B0
        public void IsMarked(){} // RVA: 0x7FFE871BC820
        public void ToIntArrayLength(){} // RVA: 0x7FFE871BC8A0
    }

    public class ByteEqualityComparer : EqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE8694FC30 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8694FCC0 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFE8694F980
        public void LastIndexOf(){} // RVA: 0x7FFE84105630
        public void .ctor(){} // RVA: 0x7FFE8694FD20
    }

    public class CollectionDebugView`1 : Object
    {
    }

    public class CollectionExtensions : Object
    {
        // ── Methods ──
        public void GetValueOrDefault(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Remove(){} // RVA: 0x7FFE810A1420
    }

    public class Comparer`1 : Object
    {
        public System.Collections.Generic.Comparer`1<System.ValueTuple`2<bool,UnityEngine.GameObject>> defaultComparer;
    }

    public class Deque`1 : Object
    {
        public T[] _array;
        public int _head;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_IsEmpty(){} // RVA: 0x7FFE80E2F150
        public void EnqueueTail(){} // RVA: 0x7FFE810A1420
        public void DequeueHead(){} // RVA: 0x7FFE810A1420
        public void DequeueTail(){} // RVA: 0x7FFE810A1420
        public void Grow(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
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
        public int[] _buckets; // 0x10
        public Entry<string,Token>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Token> _keys; // 0x38
        public ValueCollection<string,Token> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
        public void field_14; // 0x6880
        public object field_15; // 0x1
        public object field_16; // 0x89C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE83A2DF90 | overloaded x9
        public void get_Comparer(){} // RVA: 0x7FFE8399BF40
        public void get_Count(){} // RVA: 0x7FFE838A44D0
        public void get_Keys(){} // RVA: 0x7FFE838A44E0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFE838A44E0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFE838A44E0
        public void get_Values(){} // RVA: 0x7FFE838A45F0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFE838A45F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFE838A45F0
        public void get_Item(){} // RVA: 0x7FFE8399F210
        public void set_Item(){} // RVA: 0x7FFE83A2E020
        public void Add(){} // RVA: 0x7FFE83A2E070
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFE83A2E0C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFE83A2E120
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFE83A2E220
        public void Clear(){} // RVA: 0x7FFE838A4A40
        public void ContainsKey(){} // RVA: 0x7FFE8399F5C0
        public void ContainsValue(){} // RVA: 0x7FFE83A2E340
        public void CopyTo(){} // RVA: 0x7FFE83A2E450
        public void GetEnumerator(){} // RVA: 0x7FFE838FE050
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFE838FE100
        public void GetObjectData(){} // RVA: 0x7FFE83A2E5D0
        public void FindEntry(){} // RVA: 0x7FFE8399FBE0
        public void Initialize(){} // RVA: 0x7FFE83A2E930
        public void TryInsert(){} // RVA: 0x7FFE83A2EAB0
        public void OnDeserialization(){} // RVA: 0x7FFE83A2EF80
        public void Resize(){} // RVA: 0x7FFE83A2F4F0 | overloaded x2
        public void Remove(){} // RVA: 0x7FFE839A0EC0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x7FFE839A1160
        public void TryAdd(){} // RVA: 0x7FFE83A2F770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFE83A2F7C0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE83A2F7E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE838FE100
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE83A2FBF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFE810FB320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFE838F65E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFE838C5AE0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFE839A1730
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFE83A2FCA0
        public void IsCompatibleKey(){} // RVA: 0x7FFE838A7710
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFE83A2FE80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFE839A1C50
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFE83900840
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFE839A1D70
    }

    public class EnumEqualityComparer`1 : EqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE83B92500 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE83B92580 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFE83B92680
    }

    public class EnumerableHelpers : Object
    {
        // ── Methods ──
        public void ToArray(){} // RVA: 0x7FFE80E2E440 | overloaded x2
    }

    public class EqualityComparer`1 : Object
    {
        public System.Collections.Generic.EqualityComparer`1<HIDPageUsage> defaultComparer;

        // ── Methods ──
        public void get_Default(){} // RVA: 0x7FFE833A7B20
        public void CreateComparer(){} // RVA: 0x7FFE83EEACD0
        public void Equals(){}
        public void GetHashCode(){}
        public void IndexOf(){} // RVA: 0x7FFE83C40560
        public void LastIndexOf(){} // RVA: 0x7FFE83C40600
        public void System.Collections.IEqualityComparer.GetHashCode(){} // RVA: 0x7FFE83C406A0
        public void System.Collections.IEqualityComparer.Equals(){} // RVA: 0x7FFE83C40780
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class GenericComparer`1 : Comparer`1
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFE810A1420
        public void Equals(){} // RVA: 0x7FFE80E2F3B0
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class GenericEqualityComparer`1 : EqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE840AD050 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE83B92580 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFE84106140
        public void LastIndexOf(){} // RVA: 0x7FFE84106280
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class HashSet`1 : Object
    {
        public int Lower31BitMask;
        public int StackAllocThreshold;
        public int ShrinkThreshold;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E48220 | overloaded x7
        public void CopyFrom(){} // RVA: 0x7FFE80E460A0
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFE810A1420
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E460A0 | overloaded x3
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void GetObjectData(){}
        public void OnDeserialization(){} // RVA: 0x7FFE80E460A0
        public void Add(){} // RVA: 0x7FFE810A1420
        public void UnionWith(){} // RVA: 0x7FFE80E460A0
        public void IntersectWith(){} // RVA: 0x7FFE80E460A0
        public void SetEquals(){} // RVA: 0x7FFE80E2F3B0
        public void RemoveWhere(){} // RVA: 0x7FFE80E33B00
        public void get_Comparer(){} // RVA: 0x7FFE80E2E2E0
        public void TrimExcess(){} // RVA: 0x7FFE80E45FE0
        public void Initialize(){} // RVA: 0x7FFE80E35520
        public void IncreaseCapacity(){} // RVA: 0x7FFE80E45FE0
        public void SetCapacity(){} // RVA: 0x7FFE80E46530
        public void AddIfNotPresent(){} // RVA: 0x7FFE810A1420
        public void AddValue(){} // RVA: 0x7FFE810A1420
        public void ContainsAllElements(){} // RVA: 0x7FFE80E2F3B0
        public void IntersectWithHashSetWithSameEC(){} // RVA: 0x7FFE80E460A0
        public void IntersectWithEnumerable(){} // RVA: 0x7FFE80E460A0
        public void InternalIndexOf(){} // RVA: 0x7FFE810A1420
        public void CheckUniqueAndUnfoundElements(){} // RVA: 0x7FFE810A1420
        public void AreEqualityComparersEqual(){} // RVA: 0x7FFE80E2F7A0
        public void InternalGetHashCode(){} // RVA: 0x7FFE810A1420
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
        public void get_Current(){} // RVA: 0x7FFE810A1420
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
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void ContainsKey(){} // RVA: 0x7FFE810A1420
        public void Add(){} // RVA: 0x7FFE810A1420
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void TryGetValue(){} // RVA: 0x7FFE810A1420
    }

    public class IEnumerable`1
    {
    }

    public class IEnumerator`1
    {
        // ── Methods ──
        public void get_Current(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IEqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE80E32650
        public void GetHashCode(){} // RVA: 0x7FFE80E33B00
    }

    public class IList`1
    {
    }

    public class IReadOnlyCollection`1
    {
    }

    public class IReadOnlyDictionary`2
    {
        // ── Methods ──
        public void ContainsKey(){} // RVA: 0x7FFE810A1420
        public void TryGetValue(){} // RVA: 0x7FFE810A1420
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void get_Values(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IReadOnlyList`1
    {
    }

    public class ISet`1
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE810A1420
    }

    public class InternalStringComparer : EqualityComparer`1
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFE8410A5B0
        public void Equals(){} // RVA: 0x7FFE8694FD50
        public void IndexOf(){} // RVA: 0x7FFE8694FDA0
        public void .ctor(){} // RVA: 0x7FFE8694FE50
    }

    public class IntrospectiveSortUtilities : Object
    {
        // ── Methods ──
        public void FloorLog2PlusOne(){} // RVA: 0x7FFE8694F8F0
        public void ThrowOrIgnoreBadComparer(){} // RVA: 0x7FFE8694F910
    }

    public class KeyNotFoundException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class KeyValuePair : Object
    {
        // ── Methods ──
        public void PairToString(){} // RVA: 0x7FFE8694F760
    }

    public class KeyValuePair`2 : ValueType
    {
        public object key; // 0x10
        public object value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8272BDB0
        public void get_Key(){} // RVA: 0x7FFE8284EF60
        public void get_Value(){} // RVA: 0x7FFE826F4210
        public void ToString(){} // RVA: 0x7FFE8445AA00
        public void Deconstruct(){} // RVA: 0x7FFE84459670
    }

    public class LargeArrayBuilder`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E46530 | overloaded x2
        public void AddRange(){} // RVA: 0x7FFE80E460A0
        public void AddWithBufferAllocation(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){}
        public void GetBuffer(){} // RVA: 0x7FFE80E3D230
        public void ToArray(){} // RVA: 0x7FFE80E2E2E0
        public void TryMove(){} // RVA: 0x7FFE80E2F3B0
        public void AllocateBuffer(){} // RVA: 0x7FFE80E45FE0
    }

    public class LinkedListNode`1 : Object
    {
        public System.Collections.Generic.LinkedList`1<T> list;
        public System.Collections.Generic.LinkedListNode`1<T> next;
        public System.Collections.Generic.LinkedListNode`1<T> prev;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void get_List(){} // RVA: 0x7FFE80E2E2E0
        public void get_Next(){} // RVA: 0x7FFE80E2E2E0
        public void get_Value(){} // RVA: 0x7FFE810A1420
        public void set_Value(){} // RVA: 0x7FFE810A1420
        public void Invalidate(){} // RVA: 0x7FFE80E45FE0
    }

    public class LinkedList`1 : Object
    {
        public System.Collections.Generic.LinkedListNode`1<T> head;
        public int count;
        public int version;
        public object _syncRoot;
        public System.Runtime.Serialization.SerializationInfo _siInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_First(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFE810A1420
        public void AddFirst(){} // RVA: 0x7FFE810A1420
        public void AddLast(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void Find(){} // RVA: 0x7FFE810A1420
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void Remove(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void RemoveFirst(){} // RVA: 0x7FFE80E45FE0
        public void GetObjectData(){}
        public void OnDeserialization(){} // RVA: 0x7FFE80E460A0
        public void InternalInsertNodeBefore(){} // RVA: 0x7FFE80E4F230
        public void InternalInsertNodeToEmptyList(){} // RVA: 0x7FFE80E460A0
        public void InternalRemoveNode(){} // RVA: 0x7FFE80E460A0
        public void ValidateNewNode(){} // RVA: 0x7FFE80E460A0
        public void ValidateNode(){} // RVA: 0x7FFE80E460A0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class List`1 : Object
    {
        public int DefaultCapacity;
        public ÌÌÏÎÎÎÍÎÌÏÎÌÌÏÏÍÍÍÌÍÍÏÏ[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public ÌÌÏÎÎÎÍÎÌÏÎÌÌÏÏÍÍÍÌÍÍÏÏ[] s_emptyArray;
        public void field_6; // 0xA5A0
        public object field_7; // 0xA5A0
        public object field_8; // 0xA5A0
    }

    public class LongEnumEqualityComparer`1 : EqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE80E2F3B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE80E45FE0 | overloaded x2
        public void GetObjectData(){}
    }

    public class LowLevelDictionary`2 : Object
    {
        public Entry<U,T>[] _buckets;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E48220 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void Clear(){} // RVA: 0x7FFE80E46530
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void Find(){} // RVA: 0x7FFE810A1420
        public void UncheckedAdd(){} // RVA: 0x7FFE810A1420
        public void ExpandBuckets(){} // RVA: 0x7FFE80E45FE0
        public void GetBucket(){} // RVA: 0x7FFE810A1420
    }

    public class LowLevelListWithIList`1 : LowLevelList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E46530 | overloaded x2
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class LowLevelList`1 : Object
    {
        public int _defaultCapacity;
        public T[] _items; // 0x10
        public int _size; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8486DD60 | overloaded x2
        public void get_Capacity(){} // RVA: 0x7FFE81CCB610
        public void set_Capacity(){} // RVA: 0x7FFE8486DF10
        public void get_Count(){} // RVA: 0x7FFE813DB630
        public void get_Item(){} // RVA: 0x7FFE81081080
        public void set_Item(){} // RVA: 0x7FFE8486ED00
        public void Add(){} // RVA: 0x7FFE8486EEB0
        public void EnsureCapacity(){} // RVA: 0x7FFE8486F050
        public void AddRange(){} // RVA: 0x7FFE8486F0B0
        public void Clear(){} // RVA: 0x7FFE8486E330
        public void Contains(){} // RVA: 0x7FFE8486F0D0
        public void CopyTo(){} // RVA: 0x7FFE844E5FF0
        public void IndexOf(){} // RVA: 0x7FFE8486F2E0
        public void Insert(){} // RVA: 0x7FFE8486F400
        public void InsertRange(){} // RVA: 0x7FFE8486F610
        public void Remove(){} // RVA: 0x7FFE8486FA30
        public void RemoveAll(){} // RVA: 0x7FFE8486FB50
        public void RemoveAt(){} // RVA: 0x7FFE8486FE90
        public void .cctor(){} // RVA: 0x7FFE844E81B0
    }

    public class NullableComparer`1 : Comparer`1
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFE810A1420
        public void Equals(){} // RVA: 0x7FFE80E2F3B0
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class NullableEqualityComparer`1 : EqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE80E2F3B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFE810A1420
        public void LastIndexOf(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class ObjectComparer`1 : Comparer`1
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFE810A1420
        public void Equals(){} // RVA: 0x7FFE80E2F3B0
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class ObjectEqualityComparer`1 : EqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE8499A350 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE83B92580 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFE849F2260
        public void LastIndexOf(){} // RVA: 0x7FFE849F2320
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class QueueDebugView`1 : Object
    {
    }

    public class Queue`1 : Object
    {
        public T[] _array;
        public int _head;
        public int _tail;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x3
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void Enqueue(){} // RVA: 0x7FFE810A1420
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void Dequeue(){} // RVA: 0x7FFE810A1420
        public void TryDequeue(){} // RVA: 0x7FFE80E2F3B0
        public void Peek(){} // RVA: 0x7FFE810A1420
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void ToArray(){} // RVA: 0x7FFE80E2E2E0
        public void SetCapacity(){} // RVA: 0x7FFE80E46530
        public void MoveNext(){} // RVA: 0x7FFE80E460A0
        public void ThrowForEmptyQueue(){} // RVA: 0x7FFE80E45FE0
    }

    public class ReferenceEqualityComparer : Object
    {
        public System.Collections.Generic.ReferenceEqualityComparer _instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Instance(){} // RVA: 0x7FFE86E373F0
        public void Equals(){} // RVA: 0x7FFE84108BE0
        public void GetHashCode(){} // RVA: 0x7FFE86B38630
        public void .cctor(){} // RVA: 0x7FFE86E37450
    }

    public class SByteEnumEqualityComparer`1 : EnumEqualityComparer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE810A1420
    }

    public class ShortEnumEqualityComparer`1 : EnumEqualityComparer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE810A1420
    }

    public class SortedDictionary`2 : Object
    {
        public KeyCollection<U,T> _keys;
        public ValueCollection<U,T> _values;
        public System.Collections.Generic.TreeSet`1<System.Collections.Generic.KeyValuePair`2<U,T>> _set;
        public object field_3; // 0x37D
        public object field_4; // 0x37E
        public object field_5; // 0x37F
        public object field_6; // 0x380
        public object field_7; // 0x381
        public object field_8; // 0x382
        public object field_9; // 0x383
        public object field_10; // 0x384
        public object field_11; // 0x385
        public object field_12; // 0x386
        public object field_13; // 0x387
        public object field_14; // 0x388
        public object field_15; // 0x389

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x3
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void Add(){} // RVA: 0x7FFE810A1420
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void ContainsKey(){} // RVA: 0x7FFE810A1420
        public void ContainsValue(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void TryGetValue(){} // RVA: 0x7FFE810A1420
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFE80E2E390
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFE80E4F230
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFE80E4F230
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFE80E2F3B0
        public void IsCompatibleKey(){} // RVA: 0x7FFE80E2F230
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFE80E460A0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class SortedList`2 : Object
    {
        public U[] keys;
        public T[] values;
        public int _size;
        public int version;
        public System.Collections.Generic.IComparer`1<U> comparer;
        public KeyList<U,T> keyList;
        public ValueList<U,T> valueList;
        public object _syncRoot;
        public int DefaultCapacity;
        public int MaxArrayLength;
        public object field_10; // 0x39F
        public object field_11; // 0x3A0
        public object field_12; // 0x3A1
        public object field_13; // 0x3A2
        public object field_14; // 0x3A3
        public object field_15; // 0x3A4
        public object field_16; // 0x3A5
        public object field_17; // 0x3A6

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void Add(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFE810A1420
        public void set_Capacity(){} // RVA: 0x7FFE80E46530
        public void get_Comparer(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFE80E4F230
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void GetKeyListHelper(){} // RVA: 0x7FFE80E2E2E0
        public void GetValueListHelper(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFE80E2F3B0
        public void ContainsKey(){} // RVA: 0x7FFE810A1420
        public void ContainsValue(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void EnsureCapacity(){} // RVA: 0x7FFE80E46530
        public void GetByIndex(){} // RVA: 0x7FFE810A1420
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void GetKey(){} // RVA: 0x7FFE810A1420
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFE80E2E390
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFE80E4F230
        public void IndexOfKey(){} // RVA: 0x7FFE810A1420
        public void IndexOfValue(){} // RVA: 0x7FFE810A1420
        public void Insert(){} // RVA: 0x7FFE810A1420
        public void TryGetValue(){} // RVA: 0x7FFE810A1420
        public void RemoveAt(){} // RVA: 0x7FFE80E46530
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFE80E460A0
        public void IsCompatibleKey(){} // RVA: 0x7FFE80E2F230
    }

    public class SortedSet`1 : Object
    {
        public Node<T> root;
        public System.Collections.Generic.IComparer`1<T> comparer;
        public int count;
        public int version;
        public object _syncRoot;
        public System.Runtime.Serialization.SerializationInfo siInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x3
        public void InOrderTreeWalk(){} // RVA: 0x7FFE80E2F3B0
        public void BreadthFirstTreeWalk(){} // RVA: 0x7FFE80E2F3B0
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void VersionCheck(){} // RVA: 0x7FFE80E45FE0
        public void IsWithinRange(){} // RVA: 0x7FFE810A1420
        public void Add(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFE810A1420
        public void AddIfNotPresent(){} // RVA: 0x7FFE810A1420
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void DoRemove(){} // RVA: 0x7FFE810A1420
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E4D070 | overloaded x2
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void InsertionBalance(){} // RVA: 0x7FFE80E50FC0
        public void ReplaceChildOrRoot(){} // RVA: 0x7FFE80E50660
        public void ReplaceNode(){} // RVA: 0x7FFE80E50FC0
        public void FindNode(){} // RVA: 0x7FFE810A1420
        public void UpdateVersion(){} // RVA: 0x7FFE80E45FE0
        public void RemoveWhere(){} // RVA: 0x7FFE80E33B00
        public void get_Min(){} // RVA: 0x7FFE810A1420
        public void get_MinInternal(){} // RVA: 0x7FFE810A1420
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){}
        public void GetObjectData(){}
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFE80E460A0
        public void OnDeserialization(){} // RVA: 0x7FFE80E460A0
        public void Log2(){} // RVA: 0x7FFE80E35560
    }

    public class StackDebugView`1 : Object
    {
    }

    public class StackExtensions : Object
    {
        // ── Methods ──
        public void TryPeek(){} // RVA: 0x7FFE80E2F7A0
        public void TryPop(){} // RVA: 0x7FFE80E2F7A0
    }

    public class Stack`1 : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.ParticleSystemRenderer>[] _array; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE84A97860 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFE813DB630
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE84CFBCF0
        public void Clear(){} // RVA: 0x7FFE84CFA360
        public void Contains(){} // RVA: 0x7FFE84CFBDA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE84CFA470
        public void GetEnumerator(){} // RVA: 0x7FFE84CFA720
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE84CFA7B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE84CFA7B0
        public void Peek(){} // RVA: 0x7FFE84CFA870
        public void Pop(){} // RVA: 0x7FFE84CFA8D0
        public void TryPop(){} // RVA: 0x7FFE84CFA950
        public void Push(){} // RVA: 0x7FFE84CFBE80
        public void PushWithResize(){} // RVA: 0x7FFE84CFBEF0
        public void ThrowForEmptyStack(){} // RVA: 0x7FFE84CFAAE0
    }

    public class TreeSet`1 : SortedSet`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x3
        public void AddIfNotPresent(){} // RVA: 0x7FFE810A1420
    }

    public class TreeWalkPredicate`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE80E2F3B0
    }

    public class ValueListBuilder`1 : ValueType
    {
        public System.Span`1<T> _span;
        public T[] _arrayFromPool;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void get_Length(){} // RVA: 0x7FFE80E2EDB0
        public void get_Item(){} // RVA: 0x7FFE80E3D230
        public void Append(){} // RVA: 0x7FFE810A1420
        public void AsSpan(){} // RVA: 0x7FFE810A1420
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void Grow(){} // RVA: 0x7FFE80E45FE0
        public void Pop(){} // RVA: 0x7FFE810A1420
    }

}