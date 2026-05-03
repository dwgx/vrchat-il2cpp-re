// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections
// Classes: 27
// Methods: 281

namespace ThirdParty.DotNet.System.Collections
{
    public class ArrayList : Object
    {
        public object[] _items; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public int _defaultCapacity;
        public int MaxArrayLength;
        public object field_6; // 0x80A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86945B30 | overloaded x3
        public void set_Capacity(){} // RVA: 0x7FFE86945D00
        public void get_Count(){} // RVA: 0x7FFE813DB630
        public void get_IsFixedSize(){} // RVA: 0x7FFE810FB320
        public void get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void get_SyncRoot(){} // RVA: 0x7FFE86945E10
        public void get_Item(){} // RVA: 0x7FFE86945EC0
        public void set_Item(){} // RVA: 0x7FFE86945F70
        public void Adapter(){} // RVA: 0x7FFE86946060
        public void Add(){} // RVA: 0x7FFE86946110
        public void AddRange(){} // RVA: 0x7FFE869461F0
        public void Clear(){} // RVA: 0x7FFE8486E330
        public void Clone(){} // RVA: 0x7FFE86946210
        public void Contains(){} // RVA: 0x7FFE869462B0
        public void CopyTo(){} // RVA: 0x7FFE86946470 | overloaded x3
        public void EnsureCapacity(){} // RVA: 0x7FFE86946560
        public void GetEnumerator(){} // RVA: 0x7FFE869465C0
        public void IndexOf(){} // RVA: 0x7FFE86946620
        public void Insert(){} // RVA: 0x7FFE86946650
        public void InsertRange(){} // RVA: 0x7FFE86946790
        public void ReadOnly(){} // RVA: 0x7FFE86946970
        public void Remove(){} // RVA: 0x7FFE86946A20
        public void RemoveAt(){} // RVA: 0x7FFE86946A70
        public void RemoveRange(){} // RVA: 0x7FFE86946B40
        public void Reverse(){} // RVA: 0x7FFE86946D90 | overloaded x2
        public void Sort(){} // RVA: 0x7FFE86946F70 | overloaded x2
        public void ToArray(){} // RVA: 0x7FFE86947170 | overloaded x2
    }

    public class BitArray : Object
    {
        public int[] m_array; // 0x10
        public int m_length; // 0x18
        public int _version; // 0x1C
        public object _syncRoot; // 0x20
        public int _ShrinkThreshold;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869445F0 | overloaded x3
        public void get_Item(){} // RVA: 0x7FFE86944730
        public void set_Item(){} // RVA: 0x7FFE86944740
        public void Get(){} // RVA: 0x7FFE86944750
        public void Set(){} // RVA: 0x7FFE86944850
        public void SetAll(){} // RVA: 0x7FFE86944980
        public void Or(){} // RVA: 0x7FFE869449F0
        public void get_Length(){} // RVA: 0x7FFE813DB630
        public void set_Length(){} // RVA: 0x7FFE86944B20
        public void CopyTo(){} // RVA: 0x7FFE86944CD0
        public void get_Count(){} // RVA: 0x7FFE813DB630
        public void get_SyncRoot(){} // RVA: 0x7FFE869452C0
        public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void Clone(){} // RVA: 0x7FFE86945370
        public void GetEnumerator(){} // RVA: 0x7FFE869454E0
        public void GetArrayLength(){} // RVA: 0x7FFE86945590
    }

    public class CaseInsensitiveComparer : Object
    {
        public System.Globalization.CompareInfo _compareInfo; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8693C6C0 | overloaded x2
        public void get_Default(){} // RVA: 0x7FFE8693C780
        public void Compare(){} // RVA: 0x7FFE8693C8F0
    }

    public class CaseInsensitiveHashCodeProvider : Object
    {
        public System.Globalization.CompareInfo _compareInfo; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8693CB10 | overloaded x2
        public void get_Default(){} // RVA: 0x7FFE8693CBD0
        public void GetHashCode(){} // RVA: 0x7FFE8693CD00
    }

    public class CollectionBase : Object
    {
        public System.Collections.ArrayList _list; // 0x10
        public object field_1; // 0x7D1
        public object field_2; // 0x7D2
        public object field_3; // 0x7D3
        public object field_4; // 0x7D4
        public object field_5; // 0x7D5
        public object field_6; // 0x7D6
        public object field_7; // 0x7D7

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8693CDF0
        public void get_InnerList(){} // RVA: 0x7FFE81116380
        public void get_List(){} // RVA: 0x7FFE827C4A80
        public void get_Count(){} // RVA: 0x7FFE8154F670
        public void Clear(){} // RVA: 0x7FFE8693CE90
        public void RemoveAt(){} // RVA: 0x7FFE8693CEF0
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFE8693D080
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE8693D0B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE8693D0E0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE8693D110
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE8693D140
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE8693D170
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE8693D240
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE8693D400
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE8693D430
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE8693D540
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE8693D6A0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE8693D6D0
        public void GetEnumerator(){} // RVA: 0x7FFE8670DE60
        public void OnSet(){} // RVA: 0x7FFE810FB310
        public void OnInsert(){} // RVA: 0x7FFE810FB310
        public void OnClear(){} // RVA: 0x7FFE810FB310
        public void OnRemove(){} // RVA: 0x7FFE810FB310
        public void OnValidate(){} // RVA: 0x7FFE8693D850
        public void OnSetComplete(){} // RVA: 0x7FFE810FB310
        public void OnInsertComplete(){} // RVA: 0x7FFE810FB310
        public void OnClearComplete(){} // RVA: 0x7FFE810FB310
        public void OnRemoveComplete(){} // RVA: 0x7FFE810FB310
    }

    public class Comparer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86939C90 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFE86939E70
        public void Compare(){} // RVA: 0x7FFE86939F10
        public void .cctor(){} // RVA: 0x7FFE8693A0D0
    }

    public class CompatibleComparer : Object
    {
        public System.Collections.IHashCodeProvider _hcp; // 0x10
        public System.Collections.IComparer _comparer; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void get_HashCodeProvider(){} // RVA: 0x7FFE81116380
        public void get_Comparer(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE8693C240
        public void Compare(){} // RVA: 0x7FFE8693C370
        public void GetHashCode(){} // RVA: 0x7FFE8693C4E0
    }

    public class DictionaryEntry : ValueType
    {
        public object _key; // 0x10
        public object _value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8272BDB0
        public void get_Key(){} // RVA: 0x7FFE8284EF60
        public void get_Value(){} // RVA: 0x7FFE826F4210
    }

    public class HashHelpers : Object
    {
        public int[] primes;

        // ── Methods ──
        public void IsPrime(){} // RVA: 0x7FFE8693A450
        public void GetPrime(){} // RVA: 0x7FFE8693A500
        public void ExpandPrime(){} // RVA: 0x7FFE8693A720
        public void get_SerializationInfoTable(){} // RVA: 0x7FFE8693A7A0
        public void .cctor(){} // RVA: 0x7FFE8693A8E0
    }

    public class Hashtable : Object
    {
        public int HashPrime;
        public int InitialSize;
        public string LoadFactorName;
        public string VersionName;
        public string ComparerName;
        public string HashCodeProviderName;
        public string HashSizeName;
        public string KeysName;
        public string ValuesName;

        // ── Methods ──
        public void get_SerializationInfoTable(){} // RVA: 0x7FFE86949990
        public void .ctor(){} // RVA: 0x7FFE8694A370 | overloaded x13
        public void InitHash(){} // RVA: 0x7FFE8694A3E0
        public void Add(){} // RVA: 0x7FFE8694A430
        public void Clear(){} // RVA: 0x7FFE8694A450
        public void Clone(){} // RVA: 0x7FFE8694A630
        public void Contains(){} // RVA: 0x7FFE8694A740
        public void ContainsKey(){} // RVA: 0x7FFE8694A760
        public void CopyKeys(){} // RVA: 0x7FFE8694A900
        public void CopyEntries(){} // RVA: 0x7FFE8694A9A0
        public void CopyTo(){} // RVA: 0x7FFE8694AAA0
        public void CopyValues(){} // RVA: 0x7FFE8694AD40
        public void get_Item(){} // RVA: 0x7FFE8694ADE0
        public void set_Item(){} // RVA: 0x7FFE8694B060
        public void expand(){} // RVA: 0x7FFE8694B080
        public void rehash(){} // RVA: 0x7FFE8694B150 | overloaded x2
        public void UpdateVersion(){} // RVA: 0x7FFE8694B130
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8694B2F0
        public void GetEnumerator(){} // RVA: 0x7FFE8694B3B0
        public void GetHash(){} // RVA: 0x7FFE8694B470
        public void get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void get_IsFixedSize(){} // RVA: 0x7FFE810FB320
        public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void KeyEquals(){} // RVA: 0x7FFE8694B500
        public void get_Keys(){} // RVA: 0x7FFE8694B5E0
        public void get_Values(){} // RVA: 0x7FFE8694B6E0
        public void Insert(){} // RVA: 0x7FFE8694B7E0
        public void putEntry(){} // RVA: 0x7FFE8694BE10
        public void Remove(){} // RVA: 0x7FFE8694BFE0
        public void get_SyncRoot(){} // RVA: 0x7FFE8694C2E0
        public void get_Count(){} // RVA: 0x7FFE813DB630
        public void Synchronized(){} // RVA: 0x7FFE8694C390
        public void GetObjectData(){} // RVA: 0x7FFE8694C480
        public void OnDeserialization(){} // RVA: 0x7FFE8694CF80
    }

    public class HashtableExtensions : Object
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7FFE80E329F0
    }

    public class ICollection
    {
        // ── Methods ──
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
    }

    public class IComparer
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFE80E38BF0
    }

    public class IDictionary
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFE80E2E390
        public void set_Item(){} // RVA: 0x7FFE80E4F230
        public void get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void Contains(){} // RVA: 0x7FFE80E2F3B0
        public void Add(){} // RVA: 0x7FFE80E4F230
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void Remove(){} // RVA: 0x7FFE80E460A0
    }

    public class IDictionaryEnumerator
    {
        // ── Methods ──
        public void get_Key(){} // RVA: 0x7FFE80E2E2E0
        public void get_Value(){} // RVA: 0x7FFE80E2E2E0
        public void get_Entry(){} // RVA: 0x7FFE80E2DCF0
    }

    public class IEnumerable
    {
        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IEnumerator
    {
        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFE80E2F150
        public void get_Current(){} // RVA: 0x7FFE80E2E2E0
        public void Reset(){} // RVA: 0x7FFE80E45FE0
    }

    public class IEqualityComparer
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE80E32650
        public void GetHashCode(){} // RVA: 0x7FFE80E33B00
    }

    public class IHashCodeProvider
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFE80E33B00
    }

    public class IList
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFE80E3D230
        public void set_Item(){} // RVA: 0x7FFE80E48220
        public void Add(){} // RVA: 0x7FFE80E33B00
        public void Contains(){} // RVA: 0x7FFE80E2F3B0
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void IndexOf(){} // RVA: 0x7FFE80E33B00
        public void Insert(){} // RVA: 0x7FFE80E48220
        public void Remove(){} // RVA: 0x7FFE80E460A0
        public void RemoveAt(){} // RVA: 0x7FFE80E46530
    }

    public class IStructuralComparable
    {
        // ── Methods ──
        public void CompareTo(){} // RVA: 0x7FFE80E38BF0
    }

    public class IStructuralEquatable
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE80E32650
        public void GetHashCode(){} // RVA: 0x7FFE80E33B00
    }

    public class ListDictionaryInternal : Object
    {
        public DictionaryNode head; // 0x10
        public int version; // 0x18
        public int count; // 0x1C
        public object _syncRoot; // 0x20
        public object field_4; // 0x7BD
        public object field_5; // 0x7BE
        public object field_6; // 0x7BF
        public object field_7; // 0x7C0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Item(){} // RVA: 0x7FFE8693A9C0
        public void set_Item(){} // RVA: 0x7FFE8693AA90
        public void get_Count(){} // RVA: 0x7FFE82707EE0
        public void get_Keys(){} // RVA: 0x7FFE8693AC10
        public void get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void get_IsFixedSize(){} // RVA: 0x7FFE810FB320
        public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void get_SyncRoot(){} // RVA: 0x7FFE8693ACB0
        public void get_Values(){} // RVA: 0x7FFE8693AD60
        public void Add(){} // RVA: 0x7FFE8693AE00
        public void Clear(){} // RVA: 0x7FFE8693AFD0
        public void Contains(){} // RVA: 0x7FFE8693B030
        public void CopyTo(){} // RVA: 0x7FFE8693B100
        public void GetEnumerator(){} // RVA: 0x7FFE8693B3F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8693B450
        public void Remove(){} // RVA: 0x7FFE8693B4B0
    }

    public class Queue : Object
    {
        public object[] _array; // 0x10
        public int _head; // 0x18
        public int _tail; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8693DA90 | overloaded x4
        public void get_Count(){} // RVA: 0x7FFE8151D690
        public void Clone(){} // RVA: 0x7FFE8693DCE0
        public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void get_SyncRoot(){} // RVA: 0x7FFE8693DDF0
        public void CopyTo(){} // RVA: 0x7FFE8693DEA0
        public void Enqueue(){} // RVA: 0x7FFE8693E0F0
        public void GetEnumerator(){} // RVA: 0x7FFE8693E2F0
        public void Dequeue(){} // RVA: 0x7FFE8693E430
        public void Peek(){} // RVA: 0x7FFE8693E510
        public void GetElement(){} // RVA: 0x7FFE8693E5B0
        public void SetCapacity(){} // RVA: 0x7FFE8693E5F0
    }

    public class ReadOnlyCollectionBase : Object
    {
        public System.Collections.ArrayList _list; // 0x10
        public object field_1; // 0x7DD
        public object field_2; // 0x7DE
        public object field_3; // 0x7DF

        // ── Methods ──
        public void get_InnerList(){} // RVA: 0x7FFE8693EB50
        public void get_Count(){} // RVA: 0x7FFE8693EC00
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE8693EC40
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE8693EC80
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE8693ECC0
        public void GetEnumerator(){} // RVA: 0x7FFE8693ED10
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SortedList : Object
    {
        public object[] keys; // 0x10
        public object[] values; // 0x18
        public int _size; // 0x20
        public int version; // 0x24
        public System.Collections.IComparer comparer; // 0x28
        public KeyList keyList; // 0x30
        public ValueList valueList; // 0x38
        public object _syncRoot; // 0x40
        public object field_8; // 0x7E1

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8693F360 | overloaded x3
        public void Init(){} // RVA: 0x7FFE8693ED60
        public void Add(){} // RVA: 0x7FFE8693F3D0
        public void set_Capacity(){} // RVA: 0x7FFE8693F510
        public void get_Count(){} // RVA: 0x7FFE8151D690
        public void get_Keys(){} // RVA: 0x7FFE8693F6C0
        public void get_Values(){} // RVA: 0x7FFE8693F6E0
        public void get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void get_IsFixedSize(){} // RVA: 0x7FFE810FB320
        public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void get_SyncRoot(){} // RVA: 0x7FFE8693F700
        public void Clear(){} // RVA: 0x7FFE84CB4480
        public void Clone(){} // RVA: 0x7FFE8693F7B0
        public void Contains(){} // RVA: 0x7FFE8693F8C0
        public void ContainsKey(){} // RVA: 0x7FFE8693F8C0
        public void ContainsValue(){} // RVA: 0x7FFE8693F8F0
        public void CopyTo(){} // RVA: 0x7FFE8693F920
        public void EnsureCapacity(){} // RVA: 0x7FFE8693FC90
        public void GetByIndex(){} // RVA: 0x7FFE8693FCF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8693FDA0
        public void GetEnumerator(){} // RVA: 0x7FFE8693FE60
        public void GetKey(){} // RVA: 0x7FFE8693FF20
        public void GetKeyList(){} // RVA: 0x7FFE8693FFD0
        public void GetValueList(){} // RVA: 0x7FFE869400D0
        public void get_Item(){} // RVA: 0x7FFE869401D0
        public void set_Item(){} // RVA: 0x7FFE86940220
        public void IndexOfKey(){} // RVA: 0x7FFE86940350
        public void IndexOfValue(){} // RVA: 0x7FFE86940400
        public void Insert(){} // RVA: 0x7FFE86940460
        public void RemoveAt(){} // RVA: 0x7FFE869405D0
        public void Remove(){} // RVA: 0x7FFE869406F0
        public void Synchronized(){} // RVA: 0x7FFE86940740
    }

    public class Stack : Object
    {
        public object[] _array; // 0x10
        public int _size; // 0x18
        public int _version; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86943760 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFE813DB630
        public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void get_SyncRoot(){} // RVA: 0x7FFE86943860
        public void Clear(){} // RVA: 0x7FFE84CFA360
        public void Clone(){} // RVA: 0x7FFE86943910
        public void CopyTo(){} // RVA: 0x7FFE869439B0
        public void GetEnumerator(){} // RVA: 0x7FFE86943CD0
        public void Peek(){} // RVA: 0x7FFE86943DF0
        public void Pop(){} // RVA: 0x7FFE86943E80
        public void Push(){} // RVA: 0x7FFE86943F30
    }

}