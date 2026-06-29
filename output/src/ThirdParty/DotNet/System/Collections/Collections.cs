// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections
// Classes: 29
// Methods: 280

namespace ThirdParty.DotNet.System.Collections
{
    public class ArrayList : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x687E570
        public void set_Capacity(){} // RVA: 0x687E740
        public void get_Count(){} // RVA: 0xE62D00
        public void get_IsFixedSize(){} // RVA: 0xB43320
        public void get_IsReadOnly(){} // RVA: 0xB43320
        public void get_IsSynchronized(){} // RVA: 0xB43320
        public void get_SyncRoot(){} // RVA: 0x687E850
        public void get_Item(){} // RVA: 0x687E900
        public void set_Item(){} // RVA: 0x687E9B0
        public void Adapter(){} // RVA: 0x687EAA0
        public void Add(){} // RVA: 0x687EB50
        public void AddRange(){} // RVA: 0x687EC30
        public void Clear(){} // RVA: 0x4672860
        public void Clone(){} // RVA: 0x687EC50
        public void Contains(){} // RVA: 0x687ECF0
        public void CopyTo(){} // RVA: 0x687EEA0
        public void EnsureCapacity(){} // RVA: 0x687EF90
        public void GetEnumerator(){} // RVA: 0x687EFF0
        public void IndexOf(){} // RVA: 0x687F1F0
        public void Insert(){} // RVA: 0x687F220
        public void InsertRange(){} // RVA: 0x687F360
        public void ReadOnly(){} // RVA: 0x687F540
        public void Remove(){} // RVA: 0x687F5F0
        public void RemoveAt(){} // RVA: 0x687F640
        public void RemoveRange(){} // RVA: 0x687F710
        public void Reverse(){} // RVA: 0x687F960
        public void Sort(){} // RVA: 0x687FB40
        public void ToArray(){} // RVA: 0x687FD40
    }

    public class BitArray : Object
    {
        public object m_array;
        public object m_length;
        public object _version;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x687D040
        public void get_Item(){} // RVA: 0x687D180
        public void set_Item(){} // RVA: 0x687D190
        public void Get(){} // RVA: 0x687D1A0
        public void Set(){} // RVA: 0x687D290
        public void SetAll(){} // RVA: 0x687D3B0
        public void Or(){} // RVA: 0x687D430
        public void get_Length(){} // RVA: 0xE62D00
        public void set_Length(){} // RVA: 0x687D560
        public void CopyTo(){} // RVA: 0x687D700
        public void get_Count(){} // RVA: 0xE62D00
        public void get_SyncRoot(){} // RVA: 0x687DD10
        public void get_IsSynchronized(){} // RVA: 0xB43320
        public void Clone(){} // RVA: 0x687DDC0
        public void GetEnumerator(){} // RVA: 0x687DF30
        public void GetArrayLength(){} // RVA: 0x687DFE0
    }

    public class CaseInsensitiveComparer : Object
    {
        public object _compareInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6875510
        public void get_Default(){} // RVA: 0x68755D0
        public void Compare(){} // RVA: 0x6875740
    }

    public class CaseInsensitiveHashCodeProvider : Object
    {
        public object _compareInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6875950
        public void get_Default(){} // RVA: 0x6875A10
        public void GetHashCode(){} // RVA: 0x6875B40
    }

    public class CollectionBase : Object
    {
        public object _list;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6875C00
        public void get_InnerList(){} // RVA: 0xB5DBF0
        public void get_List(){} // RVA: 0x2303260
        public void get_Count(){} // RVA: 0x6875CA0
        public void Clear(){} // RVA: 0x6875CD0
        public void RemoveAt(){} // RVA: 0x6875D30
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x6875EC0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x6875EF0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x10694A0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x6875F20
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x6875F50
        public void System.Collections.IList.get_Item(){} // RVA: 0x6875F80
        public void System.Collections.IList.set_Item(){} // RVA: 0x6876050
        public void System.Collections.IList.Contains(){} // RVA: 0x6876210
        public void System.Collections.IList.Add(){} // RVA: 0x6876240
        public void System.Collections.IList.Remove(){} // RVA: 0x6876350
        public void System.Collections.IList.IndexOf(){} // RVA: 0x68764B0
        public void System.Collections.IList.Insert(){} // RVA: 0x68764E0
        public void GetEnumerator(){} // RVA: 0x66459E0
        public void OnSet(){} // RVA: 0xB43310
        public void OnInsert(){} // RVA: 0xB43310
        public void OnClear(){} // RVA: 0xB43310
        public void OnRemove(){} // RVA: 0xB43310
        public void OnValidate(){} // RVA: 0x6876660
        public void OnSetComplete(){} // RVA: 0xB43310
        public void OnInsertComplete(){} // RVA: 0xB43310
        public void OnClearComplete(){} // RVA: 0xB43310
        public void OnRemoveComplete(){} // RVA: 0xB43310
    }

    public class Comparer : Object
    {
        public object _compareInfo;
        public object Default;
        public object DefaultInvariant;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x68728E0
        public void GetObjectData(){} // RVA: 0x6872AD0
        public void Compare(){} // RVA: 0x6872D50
        public void .cctor(){} // RVA: 0x6872F00
    }

    public class CompatibleComparer : Object
    {
        public object _hcp;
        public object _comparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_HashCodeProvider(){} // RVA: 0xB5DBF0
        public void get_Comparer(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0x6875090
        public void Compare(){} // RVA: 0x68751C0
        public void GetHashCode(){} // RVA: 0x6875330
    }

    public class DictionaryEntry : ValueType
    {
        public object _key;
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76310
        public void get_Key(){} // RVA: 0x77900
        public void get_Value(){} // RVA: 0x77ED0
    }

    public class HashHelpers : Object
    {
        public object primes;
        public object s_serializationInfoTable;

        // ── Methods ──
        public void IsPrime(){} // RVA: 0x6873280
        public void GetPrime(){} // RVA: 0x6873330
        public void ExpandPrime(){} // RVA: 0x6873550
        public void get_SerializationInfoTable(){} // RVA: 0x68735D0
        public void .cctor(){} // RVA: 0x6873710
    }

    public class Hashtable : Object
    {
        public object _buckets;
        public object _count;
        public object _occupancy;
        public object _loadsize;
        public object _loadFactor;
        public object _version;
        public object _isWriterInProgress;
        public object _keys;
        public object _values;
        public object _keycomparer;
        public object _syncRoot;
        public object s_serializationInfoTable;

        // ── Methods ──
        public void get_SerializationInfoTable(){} // RVA: 0x68824F0
        public void .ctor(){} // RVA: 0x6882EC0
        public void InitHash(){} // RVA: 0x6882F30
        public void Add(){} // RVA: 0x6882F80
        public void Clear(){} // RVA: 0x6882FA0
        public void Clone(){} // RVA: 0x6883170
        public void Contains(){} // RVA: 0x6883280
        public void ContainsKey(){} // RVA: 0x68832A0
        public void CopyKeys(){} // RVA: 0x6883430
        public void CopyEntries(){} // RVA: 0x68834D0
        public void CopyTo(){} // RVA: 0x68835D0
        public void CopyValues(){} // RVA: 0x6883870
        public void get_Item(){} // RVA: 0x6883910
        public void set_Item(){} // RVA: 0x6883B90
        public void expand(){} // RVA: 0x6883BB0
        public void rehash(){} // RVA: 0x6883C80
        public void UpdateVersion(){} // RVA: 0x6883C60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6883E30
        public void GetEnumerator(){} // RVA: 0x6883EF0
        public void GetHash(){} // RVA: 0x6883FB0
        public void get_IsReadOnly(){} // RVA: 0xB43320
        public void get_IsFixedSize(){} // RVA: 0xB43320
        public void get_IsSynchronized(){} // RVA: 0xB43320
        public void KeyEquals(){} // RVA: 0x6884040
        public void get_Keys(){} // RVA: 0x6884120
        public void get_Values(){} // RVA: 0x6884220
        public void Insert(){} // RVA: 0x6884320
        public void putEntry(){} // RVA: 0x6884960
        public void Remove(){} // RVA: 0x6884B40
        public void get_SyncRoot(){} // RVA: 0x6884E40
        public void get_Count(){} // RVA: 0xE62D00
        public void Synchronized(){} // RVA: 0x6884EF0
        public void GetObjectData(){} // RVA: 0x6884FE0
        public void OnDeserialization(){} // RVA: 0x6885B40
    }

    public class HashtableExtensions : Object
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x30E2280
    }

    public class ICollection
    {
        // ── Methods ──
        public void CopyTo(){} // RVA: 0x899290
        public void get_Count(){} // RVA: 0x87C130
        public void get_SyncRoot(){} // RVA: 0x87C0A0
        public void get_IsSynchronized(){} // RVA: 0x87D280
    }

    public class IComparer
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x881CA0
    }

    public class IDictionary
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x87C540
        public void set_Item(){} // RVA: 0x8943B0
        public void get_Keys(){} // RVA: 0x87C0A0
        public void get_Values(){} // RVA: 0x87C0A0
        public void Contains(){} // RVA: 0x87D350
        public void Add(){} // RVA: 0x8943B0
        public void Clear(){} // RVA: 0x894290
        public void get_IsReadOnly(){} // RVA: 0x87D280
        public void get_IsFixedSize(){} // RVA: 0x87D280
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void Remove(){} // RVA: 0x894320
    }

    public class IDictionaryEnumerator
    {
        // ── Methods ──
        public void get_Key(){} // RVA: 0x87C0A0
        public void get_Value(){} // RVA: 0x87C0A0
        public void get_Entry(){} // RVA: 0x87BEB0
    }

    public class IDictionary[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IEnumerable
    {
        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0x87C0A0
    }

    public class IEnumerator
    {
        // ── Methods ──
        public void MoveNext(){} // RVA: 0x87D280
        public void get_Current(){} // RVA: 0x87C0A0
        public void Reset(){} // RVA: 0x894290
    }

    public class IEnumerator[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IEqualityComparer
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x87D3C0
        public void GetHashCode(){} // RVA: 0x87D050
    }

    public class IHashCodeProvider
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x87D050
    }

    public class IList
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x87C160
        public void set_Item(){} // RVA: 0x895750
        public void Add(){} // RVA: 0x87D050
        public void Contains(){} // RVA: 0x87D350
        public void Clear(){} // RVA: 0x894290
        public void get_IsReadOnly(){} // RVA: 0x87D280
        public void get_IsFixedSize(){} // RVA: 0x87D280
        public void IndexOf(){} // RVA: 0x87D050
        public void Insert(){} // RVA: 0x895750
        public void Remove(){} // RVA: 0x894320
        public void RemoveAt(){} // RVA: 0x8944F0
    }

    public class IStructuralComparable
    {
        // ── Methods ──
        public void CompareTo(){} // RVA: 0x881CA0
    }

    public class IStructuralEquatable
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x87D3C0
        public void GetHashCode(){} // RVA: 0x87D050
    }

    public class ListDictionaryInternal : Object
    {
        public object head;
        public object version;
        public object count;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Item(){} // RVA: 0x68737F0
        public void set_Item(){} // RVA: 0x68738C0
        public void get_Count(){} // RVA: 0x2244FB0
        public void get_Keys(){} // RVA: 0x6873A40
        public void get_IsReadOnly(){} // RVA: 0xB43320
        public void get_IsFixedSize(){} // RVA: 0xB43320
        public void get_IsSynchronized(){} // RVA: 0xB43320
        public void get_SyncRoot(){} // RVA: 0x6873AE0
        public void get_Values(){} // RVA: 0x6873B90
        public void Add(){} // RVA: 0x6873C30
        public void Clear(){} // RVA: 0x6873E00
        public void Contains(){} // RVA: 0x6873E60
        public void CopyTo(){} // RVA: 0x6873F30
        public void GetEnumerator(){} // RVA: 0x6874220
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6874280
        public void Remove(){} // RVA: 0x68742E0
    }

    public class Queue : Object
    {
        public object _array;
        public object _head;
        public object _tail;
        public object _size;
        public object _growFactor;
        public object _version;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6876890
        public void get_Count(){} // RVA: 0xFEAE90
        public void Clone(){} // RVA: 0x6876AE0
        public void get_IsSynchronized(){} // RVA: 0xB43320
        public void get_SyncRoot(){} // RVA: 0x6876BF0
        public void CopyTo(){} // RVA: 0x6876CA0
        public void Enqueue(){} // RVA: 0x6876EF0
        public void GetEnumerator(){} // RVA: 0x6877100
        public void Dequeue(){} // RVA: 0x6877240
        public void Peek(){} // RVA: 0x6877320
        public void GetElement(){} // RVA: 0x68773C0
        public void SetCapacity(){} // RVA: 0x6877400
    }

    public class ReadOnlyCollectionBase : Object
    {
        public object _list;

        // ── Methods ──
        public void get_InnerList(){} // RVA: 0x6877960
        public void get_Count(){} // RVA: 0x6877A10
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x6877A50
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x6877A90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x6877AD0
        public void GetEnumerator(){} // RVA: 0x6877B20
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SortedList : Object
    {
        public object keys;
        public object values;
        public object _size;
        public object version;
        public object comparer;
        public object keyList;
        public object valueList;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6878170
        public void Init(){} // RVA: 0x6877B70
        public void Add(){} // RVA: 0x68781E0
        public void set_Capacity(){} // RVA: 0x6878320
        public void get_Count(){} // RVA: 0xFEAE90
        public void get_Keys(){} // RVA: 0x68784D0
        public void get_Values(){} // RVA: 0x68784F0
        public void get_IsReadOnly(){} // RVA: 0xB43320
        public void get_IsFixedSize(){} // RVA: 0xB43320
        public void get_IsSynchronized(){} // RVA: 0xB43320
        public void get_SyncRoot(){} // RVA: 0x6878510
        public void Clear(){} // RVA: 0x4AF0B50
        public void Clone(){} // RVA: 0x68785C0
        public void Contains(){} // RVA: 0x68786D0
        public void ContainsKey(){} // RVA: 0x68786D0
        public void ContainsValue(){} // RVA: 0x6878700
        public void CopyTo(){} // RVA: 0x6878730
        public void EnsureCapacity(){} // RVA: 0x6878AB0
        public void GetByIndex(){} // RVA: 0x6878B10
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6878BC0
        public void GetEnumerator(){} // RVA: 0x6878C80
        public void GetKey(){} // RVA: 0x6878D40
        public void GetKeyList(){} // RVA: 0x6878DF0
        public void GetValueList(){} // RVA: 0x6878EF0
        public void get_Item(){} // RVA: 0x6878FF0
        public void set_Item(){} // RVA: 0x6879040
        public void IndexOfKey(){} // RVA: 0x6879170
        public void IndexOfValue(){} // RVA: 0x6879220
        public void Insert(){} // RVA: 0x6879280
        public void RemoveAt(){} // RVA: 0x68793F0
        public void Remove(){} // RVA: 0x6879510
        public void Synchronized(){} // RVA: 0x6879560
    }

    public class Stack : Object
    {
        public object _array;
        public object _size;
        public object _version;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x687C1B0
        public void get_Count(){} // RVA: 0xE62D00
        public void get_IsSynchronized(){} // RVA: 0xB43320
        public void get_SyncRoot(){} // RVA: 0x687C2B0
        public void Clear(){} // RVA: 0x4B46CB0
        public void Clone(){} // RVA: 0x687C360
        public void CopyTo(){} // RVA: 0x687C400
        public void GetEnumerator(){} // RVA: 0x687C720
        public void Peek(){} // RVA: 0x687C840
        public void Pop(){} // RVA: 0x687C8D0
        public void Push(){} // RVA: 0x687C980
    }

}