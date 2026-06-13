// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Specialized
// Classes: 13
// Methods: 160

namespace ThirdParty.DotNet.System.Collections.Specialized
{
    public class BitVector32
    {
        public uint Current; // 0x10

        // ── Methods ──
        public void get_Item(){} // RVA: 0x6CB47B0
        public void set_Item(){} // RVA: 0x6CB47D0
        public void CreateMask(){} // RVA: 0x6CB47F0 | overloaded x2
        public void Equals(){} // RVA: 0x6CB4870
        public void GetHashCode(){} // RVA: 0x6CB4900
        public void ToString(){} // RVA: 0x6CB4AB0 | overloaded x2
    }

    public class CaseSensitiveStringDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CB9750
        public void Add(){} // RVA: 0x6CBA810
    }

    public class CompatibleComparer
    {
        public System.Collections.IComparer _comparer; // 0x10
        public System.Collections.IComparer defaultComparer;
        public System.Collections.IHashCodeProvider _hcp; // 0x18
        public System.Collections.IHashCodeProvider defaultHashProvider; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void Equals(){} // RVA: 0x6CBDD80
        public void GetHashCode(){} // RVA: 0x6CBDEA0
        public void get_Comparer(){} // RVA: 0x2F8380
        public void get_HashCodeProvider(){} // RVA: 0x2E07C0
        public void get_DefaultComparer(){} // RVA: 0x6CBDF80
        public void get_DefaultHashCodeProvider(){} // RVA: 0x6CBE180
    }

    public class INotifyCollectionChanged
    {
    }

    public class ListDictionary
    {
        public DictionaryNode head; // 0x10
        public int version; // 0x18
        public int count; // 0x1C
        public System.Collections.IComparer comparer; // 0x20
        public object _syncRoot; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x30B0D0 | overloaded x2
        public void get_Item(){} // RVA: 0x6CB4C10
        public void set_Item(){} // RVA: 0x6CB4D50
        public void get_Count(){} // RVA: 0x197C3B0
        public void get_Keys(){} // RVA: 0x6CB4F00
        public void get_IsReadOnly(){} // RVA: 0x2DD320
        public void get_IsFixedSize(){} // RVA: 0x2DD320
        public void get_IsSynchronized(){} // RVA: 0x2DD320
        public void get_SyncRoot(){} // RVA: 0x6CB4FA0
        public void get_Values(){} // RVA: 0x6CB5050
        public void Add(){} // RVA: 0x6CB50F0
        public void Clear(){} // RVA: 0x5DFA190
        public void Contains(){} // RVA: 0x6CB5370
        public void CopyTo(){} // RVA: 0x6CB54A0
        public void GetEnumerator(){} // RVA: 0x6CB5730
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6CB5790
        public void Remove(){} // RVA: 0x6CB57F0
    }

    public class NameObjectCollectionBase
    {
        public string ReadOnlyName;
        public string CountName;
        public string ComparerName;
        public string HashCodeProviderName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x305200 | overloaded x6
        public void GetObjectData(){} // RVA: 0x6CBACC0
        public void OnDeserialization(){} // RVA: 0x6CBB9D0
        public void Reset(){} // RVA: 0x6CBC660 | overloaded x2
        public void FindEntry(){} // RVA: 0x6CBC810
        public void get_IsReadOnly(){} // RVA: 0x3A75E0
        public void BaseAdd(){} // RVA: 0x6CBC8D0
        public void BaseRemove(){} // RVA: 0x6CBCAE0
        public void BaseGet(){} // RVA: 0x6CBCEB0 | overloaded x2
        public void BaseSet(){} // RVA: 0x6CBCDA0
        public void BaseGetKey(){} // RVA: 0x6CBCF50
        public void GetEnumerator(){} // RVA: 0x6CBCFF0
        public void get_Count(){} // RVA: 0x5C64F90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x6CBD050
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x6CBD3A0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void BaseGetAllKeys(){} // RVA: 0x6CBD450
        public void .cctor(){} // RVA: 0x6CBD570
    }

    public class NameValueCollection
    {
        public string[] _all; // 0x58
        public string[] _allKeys; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CB7220 | overloaded x5
        public void InvalidateCachedArrays(){} // RVA: 0x6CB6600
        public void GetAsOneString(){} // RVA: 0x6CB66B0
        public void GetAsStringArray(){} // RVA: 0x6CB6920
        public void Add(){} // RVA: 0x6CB69D0
        public void Get(){} // RVA: 0x6CB6F40 | overloaded x2
        public void GetValues(){} // RVA: 0x6CB6FE0 | overloaded x2
        public void Set(){} // RVA: 0x6CB6C90
        public void Remove(){} // RVA: 0x6CB6EF0
        public void get_Item(){} // RVA: 0x65E70D0
        public void set_Item(){} // RVA: 0x6CB6F20
        public void GetKey(){} // RVA: 0x6CB7080
        public void get_AllKeys(){} // RVA: 0x6CB7090
    }

    public class NotifyCollectionChangedEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CB9E90 | overloaded x4
        public void InitializeAddOrRemove(){} // RVA: 0x6CBA070
        public void InitializeAdd(){} // RVA: 0x6CBA0A0
        public void InitializeRemove(){} // RVA: 0x6CBA1D0
        public void InitializeMoveOrReplace(){} // RVA: 0x6CBA300
    }

    public class NotifyCollectionChangedEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
    }

    public class OrderedDictionary
    {
        public System.Collections.ArrayList _objectsArray; // 0x10
        public System.Collections.Hashtable _objectsTable; // 0x18
        public int _initialCapacity; // 0x20
        public System.Collections.IEqualityComparer _comparer; // 0x28
        public bool _readOnly; // 0x30
        public object _syncRoot; // 0x38
        public System.Runtime.Serialization.SerializationInfo _siInfo; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x305200 | overloaded x4
        public void get_Count(){} // RVA: 0x6CB7330
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x303450
        public void get_IsReadOnly(){} // RVA: 0x303450
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void get_Keys(){} // RVA: 0x6CB7370
        public void get_objectsArray(){} // RVA: 0x6CB7420
        public void get_objectsTable(){} // RVA: 0x6CB74E0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x6CB75B0
        public void get_Item(){} // RVA: 0x6CB7660
        public void set_Item(){} // RVA: 0x6CB76A0
        public void get_Values(){} // RVA: 0x6CB7950
        public void Add(){} // RVA: 0x6CB7A00
        public void Clear(){} // RVA: 0x6CB7B40
        public void Contains(){} // RVA: 0x6CB7BF0
        public void CopyTo(){} // RVA: 0x6CB7C30
        public void IndexOfKey(){} // RVA: 0x6CB7C80
        public void Remove(){} // RVA: 0x6CB7DF0
        public void GetEnumerator(){} // RVA: 0x6CB7F30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6CB8000
        public void GetObjectData(){} // RVA: 0x6CB80D0
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x6CB8370
        public void OnDeserialization(){} // RVA: 0x6CB8390
    }

    public class ReadOnlyList
    {
        public System.Collections.IList _list; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_Count(){} // RVA: 0x6CBA360
        public void get_IsReadOnly(){} // RVA: 0x3C2850
        public void get_IsFixedSize(){} // RVA: 0x3C2850
        public void get_IsSynchronized(){} // RVA: 0x6CBA3B0
        public void get_Item(){} // RVA: 0x6CBA400
        public void set_Item(){} // RVA: 0x6CBA460
        public void get_SyncRoot(){} // RVA: 0x6CBA4B0
        public void Add(){} // RVA: 0x6CBA500
        public void Clear(){} // RVA: 0x6CBA550
        public void Contains(){} // RVA: 0x6CBA5A0
        public void CopyTo(){} // RVA: 0x6CBA600
        public void GetEnumerator(){} // RVA: 0x6CBA670
        public void IndexOf(){} // RVA: 0x6CBA6C0
        public void Insert(){} // RVA: 0x6CBA720
        public void Remove(){} // RVA: 0x6CBA770
        public void RemoveAt(){} // RVA: 0x6CBA7C0
    }

    public class StringCollection
    {
        public System.Collections.ArrayList data; // 0x10

        // ── Methods ──
        public void get_Item(){} // RVA: 0x6CB9200
        public void set_Item(){} // RVA: 0x6CB9290
        public void get_Count(){} // RVA: 0x5DFC050
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void Add(){} // RVA: 0x6CB92C0
        public void Clear(){} // RVA: 0x6774200
        public void Contains(){} // RVA: 0x5DFC5C0
        public void CopyTo(){} // RVA: 0x5DFC300
        public void IndexOf(){} // RVA: 0x5DFC860
        public void Insert(){} // RVA: 0x6CB92F0
        public void get_IsSynchronized(){} // RVA: 0x2DD320
        public void Remove(){} // RVA: 0x6B3D050
        public void RemoveAt(){} // RVA: 0x6CB9320
        public void get_SyncRoot(){} // RVA: 0x5DFC2D0
        public void System.Collections.IList.get_Item(){} // RVA: 0x6CB9200
        public void System.Collections.IList.set_Item(){} // RVA: 0x6CB9350
        public void System.Collections.IList.Add(){} // RVA: 0x6CB93E0
        public void System.Collections.IList.Contains(){} // RVA: 0x6CB9470
        public void System.Collections.IList.IndexOf(){} // RVA: 0x6CB9500
        public void System.Collections.IList.Insert(){} // RVA: 0x6CB9590
        public void System.Collections.IList.Remove(){} // RVA: 0x6CB9620
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x5DFC300
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x5BCD010
        public void .ctor(){} // RVA: 0x6CB96B0
    }

    public class StringDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CB9750
        public void Add(){} // RVA: 0x6CB9800
        public void GetEnumerator(){} // RVA: 0x6774200
    }

}