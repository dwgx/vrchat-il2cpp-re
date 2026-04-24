// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Generic
// Classes: 52
// Methods: 461

namespace ThirdParty.DotNet.System.Collections.Generic
{
    public class ArrayBuilder`1 : ValueType
    {
        public System.IO.FileInfo[][] _array; // 0x10
        public int _count; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090ED0
        public void ToArray(){} // RVA: 0x7FFD4E078E90
        public void UncheckedAdd(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ArraySortHelper`1 : Object
    {
        public System.Collections.Generic.ArraySortHelper`1<IJobSortable> s_defaultArraySortHelper;
    }

    public class ArraySortHelper`2 : Object
    {
        public System.Collections.Generic.ArraySortHelper`2<string,Token> Default;

        // ── Methods ──
        public void Sort(){}
        public void SwapIfGreaterWithItems(){}
        public void Swap(){} // RVA: 0x7FFD4E09A460
        public void IntrospectiveSort(){}
        public void IntroSort(){} // RVA: 0x7FFD4E2ADC40
        public void PickPivotAndPartition(){} // RVA: 0x7FFD4E2ADC40
        public void Heapsort(){}
        public void DownHeap(){} // RVA: 0x7FFD4E2ADC40
        public void InsertionSort(){}
        public void get_Default(){} // RVA: 0x7FFD4E078A90
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class ByteEqualityComparer : EqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD539C6460 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD539C64F0 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFD539C61B0
        public void LastIndexOf(){} // RVA: 0x7FFD511BD640
        public void .ctor(){} // RVA: 0x7FFD539C6550
    }

    public class CollectionExtensions : Object
    {
        // ── Methods ──
        public void GetValueOrDefault(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Comparer`1 : Object
    {
        public System.Collections.Generic.Comparer`1<SortingData> Default;

        // ── Methods ──
        public void get_Default(){} // RVA: 0x7FFD4E078A90
        public void CreateComparer(){} // RVA: 0x7FFD4E078A90
        public void Compare(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.IComparer.Compare(){} // RVA: 0x7FFD4E0837A0
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class Deque`1 : Object
    {
        public T[] Count;
        public int IsEmpty;
        public int _tail;
        public int _size;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_IsEmpty(){} // RVA: 0x7FFD4E079D00
        public void EnqueueTail(){} // RVA: 0x7FFD4E2ADC40
        public void DequeueHead(){} // RVA: 0x7FFD4E2ADC40
        public void DequeueTail(){} // RVA: 0x7FFD4E2ADC40
        public void Grow(){} // RVA: 0x7FFD4E090980
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class Dictionary`2 : Object
    {
        public int[] Comparer; // 0x10
        public Entry<0x664DC180,float>[] Count; // 0x18
        public int Keys; // 0x20
        public int System.Collections.Generic.IDictionary<TKey,TValue>.Keys; // 0x24
        public int System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys; // 0x28
        public int Values; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x664DC180> System.Collections.Generic.IDictionary<TKey,TValue>.Values; // 0x30
        public KeyCollection<0x664DC180,float> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values; // 0x38
        public ValueCollection<0x664DC180,float> Item; // 0x40
        public object System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly; // 0x48
        public string System.Collections.ICollection.IsSynchronized;
        public string System.Collections.ICollection.SyncRoot;
        public string System.Collections.IDictionary.IsFixedSize;
        public string System.Collections.IDictionary.IsReadOnly;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD50AEB820 | overloaded x9
        public void get_Comparer(){} // RVA: 0x7FFD50AB06C0
        public void get_Count(){} // RVA: 0x7FFD509BF370
        public void get_Keys(){} // RVA: 0x7FFD509BF380
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFD509BF380
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFD509BF380
        public void get_Values(){} // RVA: 0x7FFD509BF490
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFD509BF490
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFD509BF490
        public void get_Item(){} // RVA: 0x7FFD50AE6A20
        public void set_Item(){} // RVA: 0x7FFD50AEB8B0
        public void Add(){} // RVA: 0x7FFD50AEB8E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFD50AEB910
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFD50AEB960
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFD50AEBA20
        public void Clear(){} // RVA: 0x7FFD509BF8E0
        public void ContainsKey(){} // RVA: 0x7FFD50AB09A0
        public void ContainsValue(){} // RVA: 0x7FFD509DEB80
        public void CopyTo(){} // RVA: 0x7FFD50AEBB00
        public void GetEnumerator(){} // RVA: 0x7FFD509DEE00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFD509DEE90
        public void GetObjectData(){} // RVA: 0x7FFD50AEBC60
        public void FindEntry(){} // RVA: 0x7FFD50AB0F50
        public void Initialize(){} // RVA: 0x7FFD50AEBFC0
        public void TryInsert(){} // RVA: 0x7FFD50AEC140
        public void OnDeserialization(){} // RVA: 0x7FFD50AEC5A0
        public void Resize(){} // RVA: 0x7FFD50AECAE0 | overloaded x2
        public void Remove(){} // RVA: 0x7FFD50AB2200 | overloaded x2
        public void TryGetValue(){} // RVA: 0x7FFD50AB2480
        public void TryAdd(){} // RVA: 0x7FFD50AECD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFD4E341320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFD50AECD90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD50AECDB0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD509DEE90
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E341320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD50AED140
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFD4E341320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFD4E341320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFD509ECC80
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFD509E0C20
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFD50AED1F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFD50AED310
        public void IsCompatibleKey(){} // RVA: 0x7FFD509C25B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFD50AED4D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFD50AB2EB0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFD509E11F0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFD50AB2FD0
    }

    public class EnumEqualityComparer`1 : EqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4E079960 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E090980 | overloaded x2
        public void GetObjectData(){}
    }

    public class EnumerableHelpers : Object
    {
        // ── Methods ──
        public void ToArray(){} // RVA: 0x7FFD4E078FF0 | overloaded x2
    }

    public class EqualityComparer`1 : Object
    {
        public System.Collections.Generic.EqualityComparer`1<VRC.Dynamics.PhysBoneRootDefinition> Default;

        // ── Methods ──
        public void get_Default(){} // RVA: 0x7FFD50517970
        public void CreateComparer(){} // RVA: 0x7FFD50FB92A0
        public void Equals(){}
        public void GetHashCode(){}
        public void IndexOf(){} // RVA: 0x7FFD50D46A60
        public void LastIndexOf(){} // RVA: 0x7FFD50D46B00
        public void System.Collections.IEqualityComparer.GetHashCode(){} // RVA: 0x7FFD50D46BA0
        public void System.Collections.IEqualityComparer.Equals(){} // RVA: 0x7FFD50D46C80
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class GenericComparer`1 : Comparer`1
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFD4E2ADC40
        public void Equals(){} // RVA: 0x7FFD4E079F60
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class GenericEqualityComparer`1 : EqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD51193ED0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD50C759D0 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFD51194400
        public void LastIndexOf(){} // RVA: 0x7FFD511944F0
        public void .ctor(){} // RVA: 0x7FFD4E341310
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
        public int[] _buckets; // 0x10
        public Slot<UnityEngine.Texture>[] _slots; // 0x18
        public int _count; // 0x20
        public int _lastIndex; // 0x24
        public int _freeList; // 0x28
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Texture> _comparer; // 0x30
        public int _version; // 0x38
        public System.Runtime.Serialization.SerializationInfo _siInfo; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E092BC0 | overloaded x7
        public void CopyFrom(){} // RVA: 0x7FFD4E090A40
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E090A40 | overloaded x3
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void GetObjectData(){}
        public void OnDeserialization(){} // RVA: 0x7FFD4E090A40
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void UnionWith(){} // RVA: 0x7FFD4E090A40
        public void IntersectWith(){} // RVA: 0x7FFD4E090A40
        public void SetEquals(){} // RVA: 0x7FFD4E079F60
        public void RemoveWhere(){} // RVA: 0x7FFD4E07E6B0
        public void get_Comparer(){} // RVA: 0x7FFD4E078E90
        public void TrimExcess(){} // RVA: 0x7FFD4E090980
        public void Initialize(){} // RVA: 0x7FFD4E0800D0
        public void IncreaseCapacity(){} // RVA: 0x7FFD4E090980
        public void SetCapacity(){} // RVA: 0x7FFD4E090ED0
        public void AddIfNotPresent(){} // RVA: 0x7FFD4E2ADC40
        public void AddValue(){} // RVA: 0x7FFD4E2ADC40
        public void ContainsAllElements(){} // RVA: 0x7FFD4E079F60
        public void IntersectWithHashSetWithSameEC(){} // RVA: 0x7FFD4E090A40
        public void IntersectWithEnumerable(){} // RVA: 0x7FFD4E090A40
        public void InternalIndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void CheckUniqueAndUnfoundElements(){} // RVA: 0x7FFD4E2ADC40
        public void AreEqualityComparersEqual(){} // RVA: 0x7FFD4E07A350
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E2ADC40
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
        public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ICollection`1
    {
    }

    public class IComparer`1
    {
    }

    public class IDictionary`2
    {
    }

    public class IEnumerable`1
    {
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
        public void Add(){} // RVA: 0x7FFD4E2ADC40
    }

    public class InternalStringComparer : EqualityComparer`1
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFD511C2200
        public void Equals(){} // RVA: 0x7FFD539C6580
        public void IndexOf(){} // RVA: 0x7FFD539C65D0
        public void .ctor(){} // RVA: 0x7FFD539C6680
    }

    public class KeyValuePair`2 : ValueType
    {
        public 0x664DC180 key; // 0x10
        public float value; // 0x14
    }

    public class LargeArrayBuilder`1 : ValueType
    {
        public int _maxCapacity; // 0x10
        public System.IO.FileInfo[] _first; // 0x18
        public System.Collections.Generic.ArrayBuilder`1<System.IO.FileInfo[]> _buffers; // 0x20
        public System.IO.FileInfo[] _current; // 0x30
        public int _index; // 0x38
        public int _count; // 0x3C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090ED0 | overloaded x2
        public void AddRange(){} // RVA: 0x7FFD4E090A40
        public void AddWithBufferAllocation(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){}
        public void GetBuffer(){} // RVA: 0x7FFD4E087DE0
        public void ToArray(){} // RVA: 0x7FFD4E078E90
        public void TryMove(){} // RVA: 0x7FFD4E079F60
        public void AllocateBuffer(){} // RVA: 0x7FFD4E090980
    }

    public class LinkedListNode`1 : Object
    {
        public System.Collections.Generic.LinkedList`1<System.Action> list; // 0x10
        public System.Collections.Generic.LinkedListNode`1<System.Action> next; // 0x18
        public System.Collections.Generic.LinkedListNode`1<System.Action> prev; // 0x20
        public System.Action item; // 0x28
    }

    public class LinkedList`1 : Object
    {
        public System.Collections.Generic.LinkedListNode`1<System.Action> Count; // 0x10
        public int First; // 0x18
        public int System.Collections.Generic.ICollection<T>.IsReadOnly; // 0x1C
        public object System.Collections.ICollection.IsSynchronized; // 0x20
        public System.Runtime.Serialization.SerializationInfo System.Collections.ICollection.SyncRoot; // 0x28
        public string VersionName;
        public string CountName;
        public string ValuesName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E90 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFD4E577800
        public void get_First(){} // RVA: 0x7FFD4E35C380
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFD4E341320
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFD51535350
        public void AddFirst(){} // RVA: 0x7FFD51535370
        public void AddLast(){} // RVA: 0x7FFD515319B0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFD51531AE0
        public void Contains(){} // RVA: 0x7FFD51535500
        public void CopyTo(){} // RVA: 0x7FFD51535530
        public void Find(){} // RVA: 0x7FFD51535730
        public void GetEnumerator(){} // RVA: 0x7FFD515357F0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD51535820
        public void Remove(){} // RVA: 0x7FFD51532110 | overloaded x2
        public void RemoveFirst(){} // RVA: 0x7FFD515321D0
        public void GetObjectData(){} // RVA: 0x7FFD515359C0
        public void OnDeserialization(){} // RVA: 0x7FFD51535C10
        public void InternalInsertNodeBefore(){} // RVA: 0x7FFD51532940
        public void InternalInsertNodeToEmptyList(){} // RVA: 0x7FFD51532AE0
        public void InternalRemoveNode(){} // RVA: 0x7FFD51532C00
        public void ValidateNewNode(){} // RVA: 0x7FFD51532DD0
        public void ValidateNode(){} // RVA: 0x7FFD51532E70
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E341320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD515360D0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD51536180
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD51535820
    }

    public class List`1 : Object
    {
        public int DefaultCapacity;
        public IJobSortable[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public IJobSortable[] s_emptyArray;
    }

    public class LongEnumEqualityComparer`1 : EqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4E079960 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E090980 | overloaded x2
        public void GetObjectData(){}
    }

    public class LowLevelDictionary`2 : Object
    {
        public Entry<int,System.Threading.Tasks.Task>[] Item; // 0x10
        public int _numEntries; // 0x18
        public int _version; // 0x1C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E092BC0 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090ED0
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void Find(){} // RVA: 0x7FFD4E2ADC40
        public void UncheckedAdd(){} // RVA: 0x7FFD4E2ADC40
        public void ExpandBuckets(){} // RVA: 0x7FFD4E090980
        public void GetBucket(){} // RVA: 0x7FFD4E2ADC40
    }

    public class LowLevelListWithIList`1 : LowLevelList`1
    {
        public object System.Collections.Generic.ICollection<T>.IsReadOnly;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090ED0 | overloaded x2
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class LowLevelList`1 : Object
    {
        public int Capacity;
        public object[] Count; // 0x10
        public int Item; // 0x18
        public int _version; // 0x1C
        public object[] s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD51908C10 | overloaded x2
        public void get_Capacity(){} // RVA: 0x7FFD4E930620
        public void set_Capacity(){} // RVA: 0x7FFD51908DC0
        public void get_Count(){} // RVA: 0x7FFD4E577800
        public void get_Item(){} // RVA: 0x7FFD4E27B230
        public void set_Item(){} // RVA: 0x7FFD51909CB0
        public void Add(){} // RVA: 0x7FFD51909E60
        public void EnsureCapacity(){} // RVA: 0x7FFD5190A000
        public void AddRange(){} // RVA: 0x7FFD5190A060
        public void Clear(){} // RVA: 0x7FFD519091E0
        public void Contains(){} // RVA: 0x7FFD5190A080
        public void CopyTo(){} // RVA: 0x7FFD515A0EA0
        public void IndexOf(){} // RVA: 0x7FFD5190A290
        public void Insert(){} // RVA: 0x7FFD5190A3B0
        public void InsertRange(){} // RVA: 0x7FFD5190A5C0
        public void Remove(){} // RVA: 0x7FFD5190A9E0
        public void RemoveAll(){} // RVA: 0x7FFD5190AB00
        public void RemoveAt(){} // RVA: 0x7FFD5190AE40
        public void .cctor(){} // RVA: 0x7FFD515A3060
    }

    public class NullableComparer`1 : Comparer`1
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFD4E2ADC40
        public void Equals(){} // RVA: 0x7FFD4E079F60
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class NullableEqualityComparer`1 : EqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4E079960 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void LastIndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class ObjectComparer`1 : Comparer`1
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFD4E2ADC40
        public void Equals(){} // RVA: 0x7FFD4E079F60
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class ObjectEqualityComparer`1 : EqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD51A5FD90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD50C759D0 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFD51A5FF60
        public void LastIndexOf(){} // RVA: 0x7FFD51A60080
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class Queue`1 : Object
    {
        public ÏÎÎÏÏÎÍÏÌÎÎÎÍÍÎÏÌÍÌÏÎÏÍ[] Count; // 0x10
        public int System.Collections.ICollection.IsSynchronized; // 0x18
        public int System.Collections.ICollection.SyncRoot; // 0x1C
        public int _size; // 0x20
        public int _version; // 0x24
        public object _syncRoot; // 0x28
        public int MinimumGrow;
        public int GrowFactor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD51B5ED70 | overloaded x3
        public void get_Count(){} // RVA: 0x7FFD4E4FBBE0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E341320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD51B5EE60
        public void Clear(){} // RVA: 0x7FFD51B59B00
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD51B59B70
        public void Enqueue(){} // RVA: 0x7FFD51B5EF10
        public void GetEnumerator(){} // RVA: 0x7FFD51B5E950
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD51B5E9E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD51B5E9E0
        public void Dequeue(){} // RVA: 0x7FFD51B5F0C0
        public void TryDequeue(){} // RVA: 0x7FFD51B5F160
        public void Peek(){} // RVA: 0x7FFD51B5EB90
        public void Contains(){} // RVA: 0x7FFD51B5F230
        public void ToArray(){} // RVA: 0x7FFD51B5F340
        public void SetCapacity(){} // RVA: 0x7FFD51B5A700
        public void MoveNext(){} // RVA: 0x7FFD51958D20
        public void ThrowForEmptyQueue(){} // RVA: 0x7FFD51B5A840
    }

    public class SByteEnumEqualityComparer`1 : EnumEqualityComparer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ShortEnumEqualityComparer`1 : EnumEqualityComparer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4E2ADC40
    }

    public class SortedDictionary`2 : Object
    {
        public KeyCollection<0x664CA170,ÏÌÎÍÎÌÎÍÎÎÏÌÎÍÎÌÌÍÏÎÎÎÏ> System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly; // 0x10
        public ValueCollection<0x664CA170,ÏÌÎÍÎÌÎÍÎÎÏÌÎÍÎÌÌÍÏÎÎÎÏ> Item; // 0x18
        public System.Collections.Generic.TreeSet`1<System.Collections.Generic.KeyValuePair`2<0x664CA170,ÏÌÎÍÎÌÎÍÎÎÏÌÎÍÎÌÌÍÏÎÎÎÏ>> Count; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x3
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_Keys(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFD4E078E90
        public void get_Values(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFD4E078E90
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void ContainsKey(){} // RVA: 0x7FFD4E2ADC40
        public void ContainsValue(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetValue(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFD4E078F40
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFD4E099B30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFD4E099B30
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFD4E079F60
        public void IsCompatibleKey(){} // RVA: 0x7FFD4E079DE0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFD4E090A40
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
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
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFD4E2ADC40
        public void set_Capacity(){} // RVA: 0x7FFD4E090ED0
        public void get_Comparer(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFD4E099B30
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_Keys(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFD4E078E90
        public void get_Values(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFD4E078E90
        public void GetKeyListHelper(){} // RVA: 0x7FFD4E078E90
        public void GetValueListHelper(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFD4E079F60
        public void ContainsKey(){} // RVA: 0x7FFD4E2ADC40
        public void ContainsValue(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void EnsureCapacity(){} // RVA: 0x7FFD4E090ED0
        public void GetByIndex(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void GetKey(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFD4E078F40
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFD4E099B30
        public void IndexOfKey(){} // RVA: 0x7FFD4E2ADC40
        public void IndexOfValue(){} // RVA: 0x7FFD4E2ADC40
        public void Insert(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetValue(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFD4E090A40
        public void IsCompatibleKey(){} // RVA: 0x7FFD4E079DE0
    }

    public class SortedSet`1 : Object
    {
        public Node<Transmtn.DTO.Notifications.Notification> Count; // 0x10
        public System.Collections.Generic.IComparer`1<Transmtn.DTO.Notifications.Notification> System.Collections.Generic.ICollection<T>.IsReadOnly; // 0x18
        public int System.Collections.ICollection.IsSynchronized; // 0x20
        public int System.Collections.ICollection.SyncRoot; // 0x24
        public object Min; // 0x28
        public System.Runtime.Serialization.SerializationInfo MinInternal; // 0x30
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
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x3
        public void InOrderTreeWalk(){} // RVA: 0x7FFD4E079F60
        public void BreadthFirstTreeWalk(){} // RVA: 0x7FFD4E079F60
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void VersionCheck(){} // RVA: 0x7FFD4E090980
        public void IsWithinRange(){} // RVA: 0x7FFD4E2ADC40
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFD4E2ADC40
        public void AddIfNotPresent(){} // RVA: 0x7FFD4E2ADC40
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void DoRemove(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E097970 | overloaded x2
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void InsertionBalance(){} // RVA: 0x7FFD4E09B8C0
        public void ReplaceChildOrRoot(){} // RVA: 0x7FFD4E09AF60
        public void ReplaceNode(){} // RVA: 0x7FFD4E09B8C0
        public void FindNode(){} // RVA: 0x7FFD4E2ADC40
        public void UpdateVersion(){} // RVA: 0x7FFD4E090980
        public void RemoveWhere(){} // RVA: 0x7FFD4E07E6B0
        public void get_Min(){} // RVA: 0x7FFD4E2ADC40
        public void get_MinInternal(){} // RVA: 0x7FFD4E2ADC40
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){}
        public void GetObjectData(){}
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFD4E090A40
        public void OnDeserialization(){} // RVA: 0x7FFD4E090A40
        public void Log2(){} // RVA: 0x7FFD4E080110
    }

    public class StackExtensions : Object
    {
        // ── Methods ──
        public void TryPeek(){} // RVA: 0x7FFD4E07A350
        public void TryPop(){} // RVA: 0x7FFD4E07A350
    }

    public class Stack`1 : Object
    {
        public System.Collections.Generic.List`1<VRC.SDKBase.INetworkID>[] Count; // 0x10
        public int System.Collections.ICollection.IsSynchronized; // 0x18
        public int System.Collections.ICollection.SyncRoot; // 0x1C
        public object _syncRoot; // 0x20
        public int DefaultCapacity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090ED0 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void Peek(){} // RVA: 0x7FFD4E2ADC40
        public void Pop(){} // RVA: 0x7FFD4E2ADC40
        public void TryPop(){} // RVA: 0x7FFD4E079F60
        public void Push(){} // RVA: 0x7FFD4E2ADC40
        public void PushWithResize(){} // RVA: 0x7FFD4E2ADC40
        public void ThrowForEmptyStack(){} // RVA: 0x7FFD4E090980
    }

    public class TreeSet`1 : SortedSet`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x3
        public void AddIfNotPresent(){} // RVA: 0x7FFD4E2ADC40
    }

    public class TreeWalkPredicate`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E079F60
    }

    public class ValueListBuilder`1 : ValueType
    {
        public System.Span`1<int> Length; // 0x10
        public int[] Item; // 0x20
        public int _pos; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void get_Item(){} // RVA: 0x7FFD4E087DE0
        public void Append(){} // RVA: 0x7FFD4E2ADC40
        public void AsSpan(){} // RVA: 0x7FFD4E2ADC40
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void Grow(){} // RVA: 0x7FFD4E090980
        public void Pop(){} // RVA: 0x7FFD4E2ADC40
    }

}