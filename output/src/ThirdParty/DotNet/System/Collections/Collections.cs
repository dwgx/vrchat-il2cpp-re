// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections
// Classes: 27
// Methods: 281

namespace ThirdParty.DotNet.System.Collections
{
    public class ArrayList : Object
    {
        public object[] Capacity; // 0x10
        public int Count; // 0x18
        public int IsFixedSize; // 0x1C
        public object IsReadOnly; // 0x20
        public int IsSynchronized;
        public int SyncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC859C350 | overloaded x3
        public void set_Capacity(){} // RVA: 0x7FFAC859C520
        public void get_Count(){} // RVA: 0x7FFAC3157800
        public void get_IsFixedSize(){} // RVA: 0x7FFAC2F21320
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void get_SyncRoot(){} // RVA: 0x7FFAC859C630
        public void get_Item(){} // RVA: 0x7FFAC859C6E0
        public void set_Item(){} // RVA: 0x7FFAC859C790
        public void Adapter(){} // RVA: 0x7FFAC859C880
        public void Add(){} // RVA: 0x7FFAC859C930
        public void AddRange(){} // RVA: 0x7FFAC859CA10
        public void Clear(){} // RVA: 0x7FFAC64E91E0
        public void Clone(){} // RVA: 0x7FFAC859CA30
        public void Contains(){} // RVA: 0x7FFAC859CAD0
        public void CopyTo(){} // RVA: 0x7FFAC859CC90 | overloaded x3
        public void EnsureCapacity(){} // RVA: 0x7FFAC859CD80
        public void GetEnumerator(){} // RVA: 0x7FFAC859CDE0
        public void IndexOf(){} // RVA: 0x7FFAC859CE40
        public void Insert(){} // RVA: 0x7FFAC859CE70
        public void InsertRange(){} // RVA: 0x7FFAC859CFB0
        public void ReadOnly(){} // RVA: 0x7FFAC859D190
        public void Remove(){} // RVA: 0x7FFAC859D240
        public void RemoveAt(){} // RVA: 0x7FFAC859D290
        public void RemoveRange(){} // RVA: 0x7FFAC859D360
        public void Reverse(){} // RVA: 0x7FFAC859D5B0 | overloaded x2
        public void Sort(){} // RVA: 0x7FFAC859D790 | overloaded x2
        public void ToArray(){} // RVA: 0x7FFAC859D990 | overloaded x2
    }

    public class BitArray : Object
    {
        public int[] Item; // 0x10
        public int Length; // 0x18
        public int Count; // 0x1C
        public object SyncRoot; // 0x20
        public int IsSynchronized;
        public int BitsPerInt32;
        public int BytesPerInt32;
        public int BitsPerByte;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC859AE10 | overloaded x3
        public void get_Item(){} // RVA: 0x7FFAC859AF50
        public void set_Item(){} // RVA: 0x7FFAC859AF60
        public void Get(){} // RVA: 0x7FFAC859AF70
        public void Set(){} // RVA: 0x7FFAC859B070
        public void SetAll(){} // RVA: 0x7FFAC859B1A0
        public void Or(){} // RVA: 0x7FFAC859B210
        public void get_Length(){} // RVA: 0x7FFAC3157800
        public void set_Length(){} // RVA: 0x7FFAC859B340
        public void CopyTo(){} // RVA: 0x7FFAC859B4F0
        public void get_Count(){} // RVA: 0x7FFAC3157800
        public void get_SyncRoot(){} // RVA: 0x7FFAC859BAE0
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void Clone(){} // RVA: 0x7FFAC859BB90
        public void GetEnumerator(){} // RVA: 0x7FFAC859BD00
        public void GetArrayLength(){} // RVA: 0x7FFAC859BDB0
    }

    public class CaseInsensitiveComparer : Object
    {
        public System.Globalization.CompareInfo Default; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8592EB0 | overloaded x2
        public void get_Default(){} // RVA: 0x7FFAC8592F70
        public void Compare(){} // RVA: 0x7FFAC85930E0
    }

    public class CaseInsensitiveHashCodeProvider : Object
    {
        public System.Globalization.CompareInfo Default; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8593300 | overloaded x2
        public void get_Default(){} // RVA: 0x7FFAC85933C0
        public void GetHashCode(){} // RVA: 0x7FFAC85934F0
    }

    public class CollectionBase : Object
    {
        public System.Collections.ArrayList InnerList; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85935E0
        public void get_InnerList(){} // RVA: 0x7FFAC2F3C380
        public void get_List(){} // RVA: 0x7FFAC44F81E0
        public void get_Count(){} // RVA: 0x7FFAC8593680
        public void Clear(){} // RVA: 0x7FFAC85936B0
        public void RemoveAt(){} // RVA: 0x7FFAC8593710
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFAC85938A0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAC85938D0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC8593900
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC8593930
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC8593960
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAC8593990
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAC8593A60
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAC8593C20
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAC8593C50
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAC8593D60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAC8593EC0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAC8593EF0
        public void GetEnumerator(){} // RVA: 0x7FFAC8364560
        public void OnSet(){} // RVA: 0x7FFAC2F21310
        public void OnInsert(){} // RVA: 0x7FFAC2F21310
        public void OnClear(){} // RVA: 0x7FFAC2F21310
        public void OnRemove(){} // RVA: 0x7FFAC2F21310
        public void OnValidate(){} // RVA: 0x7FFAC8594070
        public void OnSetComplete(){} // RVA: 0x7FFAC2F21310
        public void OnInsertComplete(){} // RVA: 0x7FFAC2F21310
        public void OnClearComplete(){} // RVA: 0x7FFAC2F21310
        public void OnRemoveComplete(){} // RVA: 0x7FFAC2F21310
    }

    public class Comparer : Object
    {
        public System.Globalization.CompareInfo _compareInfo; // 0x10
        public System.Collections.Comparer Default;
        public System.Collections.Comparer DefaultInvariant; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8590480 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFAC8590660
        public void Compare(){} // RVA: 0x7FFAC8590700
        public void .cctor(){} // RVA: 0x7FFAC85908C0
    }

    public class CompatibleComparer : Object
    {
        public System.Collections.IHashCodeProvider HashCodeProvider; // 0x10
        public System.Collections.IComparer Comparer; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void get_HashCodeProvider(){} // RVA: 0x7FFAC2F3C380
        public void get_Comparer(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC8592A30
        public void Compare(){} // RVA: 0x7FFAC8592B60
        public void GetHashCode(){} // RVA: 0x7FFAC8592CD0
    }

    public class DictionaryEntry : ValueType
    {
        public object Key; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC41AE4B0
        public void get_Key(){} // RVA: 0x7FFAC3AD9F60
        public void get_Value(){} // RVA: 0x7FFAC4420220
    }

    public class HashHelpers : Object
    {
        public int[] SerializationInfoTable;
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<object,System.Runtime.Serialization.SerializationInfo> s_serializationInfoTable; // 0x8

        // ── Methods ──
        public void IsPrime(){} // RVA: 0x7FFAC8590C40
        public void GetPrime(){} // RVA: 0x7FFAC8590CF0
        public void ExpandPrime(){} // RVA: 0x7FFAC8590F10
        public void get_SerializationInfoTable(){} // RVA: 0x7FFAC8590F90
        public void .cctor(){} // RVA: 0x7FFAC85910D0
    }

    public class Hashtable : Object
    {
        public int SerializationInfoTable;
        public int Item;
        public string IsReadOnly;
        public string IsFixedSize;
        public string IsSynchronized;
        public string Keys;
        public string Values;
        public string SyncRoot;
        public string Count;
        public string KeyComparerName;
        public bucket[] _buckets; // 0x10
        public int _count; // 0x18
        public int _occupancy; // 0x1C
        public int _loadsize; // 0x20
        public float _loadFactor; // 0x24
        public int _version; // 0x28
        public bool _isWriterInProgress; // 0x2C
        public System.Collections.ICollection _keys; // 0x30
        public System.Collections.ICollection _values; // 0x38
        public System.Collections.IEqualityComparer _keycomparer; // 0x40
        public object _syncRoot; // 0x48
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<object,System.Runtime.Serialization.SerializationInfo> s_serializationInfoTable;

        // ── Methods ──
        public void get_SerializationInfoTable(){} // RVA: 0x7FFAC85A01B0
        public void .ctor(){} // RVA: 0x7FFAC85A0B90 | overloaded x13
        public void InitHash(){} // RVA: 0x7FFAC85A0C00
        public void Add(){} // RVA: 0x7FFAC85A0C50
        public void Clear(){} // RVA: 0x7FFAC85A0C70
        public void Clone(){} // RVA: 0x7FFAC85A0E50
        public void Contains(){} // RVA: 0x7FFAC85A0F60
        public void ContainsKey(){} // RVA: 0x7FFAC85A0F80
        public void CopyKeys(){} // RVA: 0x7FFAC85A1120
        public void CopyEntries(){} // RVA: 0x7FFAC85A11C0
        public void CopyTo(){} // RVA: 0x7FFAC85A12C0
        public void CopyValues(){} // RVA: 0x7FFAC85A1560
        public void get_Item(){} // RVA: 0x7FFAC85A1600
        public void set_Item(){} // RVA: 0x7FFAC85A1880
        public void expand(){} // RVA: 0x7FFAC85A18A0
        public void rehash(){} // RVA: 0x7FFAC85A1970 | overloaded x2
        public void UpdateVersion(){} // RVA: 0x7FFAC85A1950
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC85A1B10
        public void GetEnumerator(){} // RVA: 0x7FFAC85A1BD0
        public void GetHash(){} // RVA: 0x7FFAC85A1C90
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void get_IsFixedSize(){} // RVA: 0x7FFAC2F21320
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void KeyEquals(){} // RVA: 0x7FFAC85A1D20
        public void get_Keys(){} // RVA: 0x7FFAC85A1E00
        public void get_Values(){} // RVA: 0x7FFAC85A1F00
        public void Insert(){} // RVA: 0x7FFAC85A2000
        public void putEntry(){} // RVA: 0x7FFAC85A2630
        public void Remove(){} // RVA: 0x7FFAC85A2800
        public void get_SyncRoot(){} // RVA: 0x7FFAC85A2B00
        public void get_Count(){} // RVA: 0x7FFAC3157800
        public void Synchronized(){} // RVA: 0x7FFAC85A2BB0
        public void GetObjectData(){} // RVA: 0x7FFAC85A2CA0
        public void OnDeserialization(){} // RVA: 0x7FFAC85A37A0
    }

    public class HashtableExtensions : Object
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7FFAC2C5D5A0
    }

    public class ICollection
    {
        public object Count;
        public object SyncRoot;
        public object IsSynchronized;

        // ── Methods ──
        public void CopyTo(){} // RVA: 0x7FFAC2C77970
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_SyncRoot(){} // RVA: 0x7FFAC2C58E90
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2C59D00
    }

    public class IComparer
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFAC2C637A0
    }

    public class IDictionary
    {
        public object Item;
        public object Keys;
        public object Values;
        public object IsReadOnly;
        public object IsFixedSize;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFAC2C58F40
        public void set_Item(){} // RVA: 0x7FFAC2C79B30
        public void get_Keys(){} // RVA: 0x7FFAC2C58E90
        public void get_Values(){} // RVA: 0x7FFAC2C58E90
        public void Contains(){} // RVA: 0x7FFAC2C59F60
        public void Add(){} // RVA: 0x7FFAC2C79B30
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void get_IsFixedSize(){} // RVA: 0x7FFAC2C59D00
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void Remove(){} // RVA: 0x7FFAC2C70A40
    }

    public class IDictionaryEnumerator
    {
        public object Key;
        public object Value;
        public object Entry;

        // ── Methods ──
        public void get_Key(){} // RVA: 0x7FFAC2C58E90
        public void get_Value(){} // RVA: 0x7FFAC2C58E90
        public void get_Entry(){} // RVA: 0x7FFAC2C588A0
    }

    public class IEnumerable
    {
        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class IEnumerator
    {
        public object Current;

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFAC2C59D00
        public void get_Current(){} // RVA: 0x7FFAC2C58E90
        public void Reset(){} // RVA: 0x7FFAC2C70980
    }

    public class IEqualityComparer
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2C5D200
        public void GetHashCode(){} // RVA: 0x7FFAC2C5E6B0
    }

    public class IHashCodeProvider
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFAC2C5E6B0
    }

    public class IList
    {
        public object Item;
        public object IsReadOnly;
        public object IsFixedSize;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFAC2C67DE0
        public void set_Item(){} // RVA: 0x7FFAC2C72BC0
        public void Add(){} // RVA: 0x7FFAC2C5E6B0
        public void Contains(){} // RVA: 0x7FFAC2C59F60
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void get_IsFixedSize(){} // RVA: 0x7FFAC2C59D00
        public void IndexOf(){} // RVA: 0x7FFAC2C5E6B0
        public void Insert(){} // RVA: 0x7FFAC2C72BC0
        public void Remove(){} // RVA: 0x7FFAC2C70A40
        public void RemoveAt(){} // RVA: 0x7FFAC2C70ED0
    }

    public class IStructuralComparable
    {
        // ── Methods ──
        public void CompareTo(){} // RVA: 0x7FFAC2C637A0
    }

    public class IStructuralEquatable
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2C5D200
        public void GetHashCode(){} // RVA: 0x7FFAC2C5E6B0
    }

    public class ListDictionaryInternal : Object
    {
        public DictionaryNode Item; // 0x10
        public int Count; // 0x18
        public int Keys; // 0x1C
        public object IsReadOnly; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Item(){} // RVA: 0x7FFAC85911B0
        public void set_Item(){} // RVA: 0x7FFAC8591280
        public void get_Count(){} // RVA: 0x7FFAC44357F0
        public void get_Keys(){} // RVA: 0x7FFAC8591400
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void get_IsFixedSize(){} // RVA: 0x7FFAC2F21320
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void get_SyncRoot(){} // RVA: 0x7FFAC85914A0
        public void get_Values(){} // RVA: 0x7FFAC8591550
        public void Add(){} // RVA: 0x7FFAC85915F0
        public void Clear(){} // RVA: 0x7FFAC85917C0
        public void Contains(){} // RVA: 0x7FFAC8591820
        public void CopyTo(){} // RVA: 0x7FFAC85918F0
        public void GetEnumerator(){} // RVA: 0x7FFAC8591BE0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8591C40
        public void Remove(){} // RVA: 0x7FFAC8591CA0
    }

    public class Queue : Object
    {
        public object[] Count; // 0x10
        public int IsSynchronized; // 0x18
        public int SyncRoot; // 0x1C
        public int _size; // 0x20
        public int _growFactor; // 0x24
        public int _version; // 0x28
        public object _syncRoot; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85942B0 | overloaded x4
        public void get_Count(){} // RVA: 0x7FFAC30DBBE0
        public void Clone(){} // RVA: 0x7FFAC8594500
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void get_SyncRoot(){} // RVA: 0x7FFAC8594610
        public void CopyTo(){} // RVA: 0x7FFAC85946C0
        public void Enqueue(){} // RVA: 0x7FFAC8594910
        public void GetEnumerator(){} // RVA: 0x7FFAC8594B10
        public void Dequeue(){} // RVA: 0x7FFAC8594C50
        public void Peek(){} // RVA: 0x7FFAC8594D30
        public void GetElement(){} // RVA: 0x7FFAC8594DD0
        public void SetCapacity(){} // RVA: 0x7FFAC8594E10
    }

    public class ReadOnlyCollectionBase : Object
    {
        public System.Collections.ArrayList InnerList; // 0x10

        // ── Methods ──
        public void get_InnerList(){} // RVA: 0x7FFAC8595370
        public void get_Count(){} // RVA: 0x7FFAC8595420
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC8595460
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC85954A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC85954E0
        public void GetEnumerator(){} // RVA: 0x7FFAC8595530
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SortedList : Object
    {
        public object[] Capacity; // 0x10
        public object[] Count; // 0x18
        public int Keys; // 0x20
        public int Values; // 0x24
        public System.Collections.IComparer IsReadOnly; // 0x28
        public KeyList IsFixedSize; // 0x30
        public ValueList IsSynchronized; // 0x38
        public object SyncRoot; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8595B80 | overloaded x3
        public void Init(){} // RVA: 0x7FFAC8595580
        public void Add(){} // RVA: 0x7FFAC8595BF0
        public void set_Capacity(){} // RVA: 0x7FFAC8595D30
        public void get_Count(){} // RVA: 0x7FFAC30DBBE0
        public void get_Keys(){} // RVA: 0x7FFAC8595EE0
        public void get_Values(){} // RVA: 0x7FFAC8595F00
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void get_IsFixedSize(){} // RVA: 0x7FFAC2F21320
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void get_SyncRoot(){} // RVA: 0x7FFAC8595F20
        public void Clear(){} // RVA: 0x7FFAC6950820
        public void Clone(){} // RVA: 0x7FFAC8595FD0
        public void Contains(){} // RVA: 0x7FFAC85960E0
        public void ContainsKey(){} // RVA: 0x7FFAC85960E0
        public void ContainsValue(){} // RVA: 0x7FFAC8596110
        public void CopyTo(){} // RVA: 0x7FFAC8596140
        public void EnsureCapacity(){} // RVA: 0x7FFAC85964B0
        public void GetByIndex(){} // RVA: 0x7FFAC8596510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC85965C0
        public void GetEnumerator(){} // RVA: 0x7FFAC8596680
        public void GetKey(){} // RVA: 0x7FFAC8596740
        public void GetKeyList(){} // RVA: 0x7FFAC85967F0
        public void GetValueList(){} // RVA: 0x7FFAC85968F0
        public void get_Item(){} // RVA: 0x7FFAC85969F0
        public void set_Item(){} // RVA: 0x7FFAC8596A40
        public void IndexOfKey(){} // RVA: 0x7FFAC8596B70
        public void IndexOfValue(){} // RVA: 0x7FFAC8596C20
        public void Insert(){} // RVA: 0x7FFAC8596C80
        public void RemoveAt(){} // RVA: 0x7FFAC8596DF0
        public void Remove(){} // RVA: 0x7FFAC8596F10
        public void Synchronized(){} // RVA: 0x7FFAC8596F60
    }

    public class Stack : Object
    {
        public object[] Count; // 0x10
        public int IsSynchronized; // 0x18
        public int SyncRoot; // 0x1C
        public object _syncRoot; // 0x20
        public int _defaultCapacity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8599F80 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFAC3157800
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void get_SyncRoot(){} // RVA: 0x7FFAC859A080
        public void Clear(){} // RVA: 0x7FFAC6998DE0
        public void Clone(){} // RVA: 0x7FFAC859A130
        public void CopyTo(){} // RVA: 0x7FFAC859A1D0
        public void GetEnumerator(){} // RVA: 0x7FFAC859A4F0
        public void Peek(){} // RVA: 0x7FFAC859A610
        public void Pop(){} // RVA: 0x7FFAC859A6A0
        public void Push(){} // RVA: 0x7FFAC859A750
    }

}