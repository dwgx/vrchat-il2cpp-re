// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Specialized
// Classes: 13
// Methods: 160

namespace ThirdParty.DotNet.System.Collections.Specialized
{
    public class BitVector32 : ValueType
    {
        public uint _data; // 0x10

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFE877F5650
        public void set_Item(){} // RVA: 0x7FFE877F5670
        public void CreateMask(){} // RVA: 0x7FFE877F5690 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE877F5710
        public void GetHashCode(){} // RVA: 0x7FFE877F57A0
        public void ToString(){} // RVA: 0x7FFE877F5950 | overloaded x2
    }

    public class CaseSensitiveStringDictionary : StringDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877FA5F0
        public void Add(){} // RVA: 0x7FFE877FB6B0
    }

    public class CompatibleComparer : Object
    {
        public System.Collections.IComparer _comparer; // 0x10
        public System.Collections.IComparer defaultComparer;
        public System.Collections.IHashCodeProvider _hcp; // 0x18
        public System.Collections.IHashCodeProvider defaultHashProvider; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void Equals(){} // RVA: 0x7FFE877FEC20
        public void GetHashCode(){} // RVA: 0x7FFE877FED40
        public void get_Comparer(){} // RVA: 0x7FFE81116380
        public void get_HashCodeProvider(){} // RVA: 0x7FFE810FE7C0
        public void get_DefaultComparer(){} // RVA: 0x7FFE877FEE20
        public void get_DefaultHashCodeProvider(){} // RVA: 0x7FFE877FF020
    }

    public class INotifyCollectionChanged
    {
    }

    public class ListDictionary : Object
    {
        public DictionaryNode head; // 0x10
        public int version; // 0x18
        public int count; // 0x1C
        public System.Collections.IComparer comparer; // 0x20
        public object _syncRoot; // 0x28
        public object field_5; // 0x328
        public object field_6; // 0x329
        public object field_7; // 0x32A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811290D0 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFE877F5AB0
        public void set_Item(){} // RVA: 0x7FFE877F5BF0
        public void get_Count(){} // RVA: 0x7FFE82707EE0
        public void get_Keys(){} // RVA: 0x7FFE877F5DA0
        public void get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void get_IsFixedSize(){} // RVA: 0x7FFE810FB320
        public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void get_SyncRoot(){} // RVA: 0x7FFE877F5E40
        public void get_Values(){} // RVA: 0x7FFE877F5EF0
        public void Add(){} // RVA: 0x7FFE877F5F90
        public void Clear(){} // RVA: 0x7FFE8693AFD0
        public void Contains(){} // RVA: 0x7FFE877F6210
        public void CopyTo(){} // RVA: 0x7FFE877F6340
        public void GetEnumerator(){} // RVA: 0x7FFE877F65D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE877F6630
        public void Remove(){} // RVA: 0x7FFE877F6690
    }

    public class NameObjectCollectionBase : Object
    {
        public string ReadOnlyName;
        public string CountName;
        public string ComparerName;
        public string HashCodeProviderName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81123200 | overloaded x6
        public void GetObjectData(){} // RVA: 0x7FFE877FBB60
        public void OnDeserialization(){} // RVA: 0x7FFE877FC870
        public void Reset(){} // RVA: 0x7FFE877FD500 | overloaded x2
        public void FindEntry(){} // RVA: 0x7FFE877FD6B0
        public void get_IsReadOnly(){} // RVA: 0x7FFE811C55E0
        public void BaseAdd(){} // RVA: 0x7FFE877FD770
        public void BaseRemove(){} // RVA: 0x7FFE877FD980
        public void BaseGet(){} // RVA: 0x7FFE877FDD50 | overloaded x2
        public void BaseSet(){} // RVA: 0x7FFE877FDC40
        public void BaseGetKey(){} // RVA: 0x7FFE877FDDF0
        public void GetEnumerator(){} // RVA: 0x7FFE877FDE90
        public void get_Count(){} // RVA: 0x7FFE85B0C750
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE877FDEF0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE877FE240
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void BaseGetAllKeys(){} // RVA: 0x7FFE877FE2F0
        public void .cctor(){} // RVA: 0x7FFE877FE410
    }

    public class NameValueCollection : NameObjectCollectionBase
    {
        public string[] _all; // 0x58
        public string[] _allKeys; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877F80C0 | overloaded x5
        public void InvalidateCachedArrays(){} // RVA: 0x7FFE877F74A0
        public void GetAsOneString(){} // RVA: 0x7FFE877F7550
        public void GetAsStringArray(){} // RVA: 0x7FFE877F77C0
        public void Add(){} // RVA: 0x7FFE877F7870
        public void Get(){} // RVA: 0x7FFE877F7DE0 | overloaded x2
        public void GetValues(){} // RVA: 0x7FFE877F7E80 | overloaded x2
        public void Set(){} // RVA: 0x7FFE877F7B30
        public void Remove(){} // RVA: 0x7FFE877F7D90
        public void get_Item(){} // RVA: 0x7FFE87125F60
        public void set_Item(){} // RVA: 0x7FFE877F7DC0
        public void GetKey(){} // RVA: 0x7FFE877F7F20
        public void get_AllKeys(){} // RVA: 0x7FFE877F7F30
    }

    public class NotifyCollectionChangedEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877FAD30 | overloaded x4
        public void InitializeAddOrRemove(){} // RVA: 0x7FFE877FAF10
        public void InitializeAdd(){} // RVA: 0x7FFE877FAF40
        public void InitializeRemove(){} // RVA: 0x7FFE877FB070
        public void InitializeMoveOrReplace(){} // RVA: 0x7FFE877FB1A0
    }

    public class NotifyCollectionChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class OrderedDictionary : Object
    {
        public System.Collections.ArrayList _objectsArray; // 0x10
        public System.Collections.Hashtable _objectsTable; // 0x18
        public int _initialCapacity; // 0x20
        public System.Collections.IEqualityComparer _comparer; // 0x28
        public bool _readOnly; // 0x30
        public object _syncRoot; // 0x38
        public System.Runtime.Serialization.SerializationInfo _siInfo; // 0x40
        public object field_7; // 0x33A
        public object field_8; // 0x33B
        public object field_9; // 0x33C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81123200 | overloaded x4
        public void get_Count(){} // RVA: 0x7FFE877F81D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFE81121450
        public void get_IsReadOnly(){} // RVA: 0x7FFE81121450
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void get_Keys(){} // RVA: 0x7FFE877F8210
        public void get_objectsArray(){} // RVA: 0x7FFE877F82C0
        public void get_objectsTable(){} // RVA: 0x7FFE877F8380
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE877F8450
        public void get_Item(){} // RVA: 0x7FFE877F8500
        public void set_Item(){} // RVA: 0x7FFE877F8540
        public void get_Values(){} // RVA: 0x7FFE877F87F0
        public void Add(){} // RVA: 0x7FFE877F88A0
        public void Clear(){} // RVA: 0x7FFE877F89E0
        public void Contains(){} // RVA: 0x7FFE877F8A90
        public void CopyTo(){} // RVA: 0x7FFE877F8AD0
        public void IndexOfKey(){} // RVA: 0x7FFE877F8B20
        public void Remove(){} // RVA: 0x7FFE877F8C90
        public void GetEnumerator(){} // RVA: 0x7FFE877F8DD0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE877F8EA0
        public void GetObjectData(){} // RVA: 0x7FFE877F8F70
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFE877F9210
        public void OnDeserialization(){} // RVA: 0x7FFE877F9230
    }

    public class ReadOnlyList : Object
    {
        public System.Collections.IList _list; // 0x10
        public object field_1; // 0x352
        public object field_2; // 0x353
        public object field_3; // 0x354
        public object field_4; // 0x355
        public object field_5; // 0x356

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Count(){} // RVA: 0x7FFE877FB200
        public void get_IsReadOnly(){} // RVA: 0x7FFE811E0850
        public void get_IsFixedSize(){} // RVA: 0x7FFE811E0850
        public void get_IsSynchronized(){} // RVA: 0x7FFE877FB250
        public void get_Item(){} // RVA: 0x7FFE877FB2A0
        public void set_Item(){} // RVA: 0x7FFE877FB300
        public void get_SyncRoot(){} // RVA: 0x7FFE877FB350
        public void Add(){} // RVA: 0x7FFE877FB3A0
        public void Clear(){} // RVA: 0x7FFE877FB3F0
        public void Contains(){} // RVA: 0x7FFE877FB440
        public void CopyTo(){} // RVA: 0x7FFE877FB4A0
        public void GetEnumerator(){} // RVA: 0x7FFE877FB510
        public void IndexOf(){} // RVA: 0x7FFE877FB560
        public void Insert(){} // RVA: 0x7FFE877FB5C0
        public void Remove(){} // RVA: 0x7FFE877FB610
        public void RemoveAt(){} // RVA: 0x7FFE877FB660
    }

    public class StringCollection : Object
    {
        public System.Collections.ArrayList data; // 0x10
        public object field_1; // 0x34B
        public object field_2; // 0x34C
        public object field_3; // 0x34D
        public object field_4; // 0x34E
        public object field_5; // 0x34F
        public object field_6; // 0x350

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFE877FA0A0
        public void set_Item(){} // RVA: 0x7FFE877FA130
        public void get_Count(){} // RVA: 0x7FFE8154F670
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE810FB320
        public void Add(){} // RVA: 0x7FFE877FA160
        public void Clear(){} // RVA: 0x7FFE872B3100
        public void Contains(){} // RVA: 0x7FFE8693D400
        public void CopyTo(){} // RVA: 0x7FFE8693D140
        public void IndexOf(){} // RVA: 0x7FFE8693D6A0
        public void Insert(){} // RVA: 0x7FFE877FA190
        public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void Remove(){} // RVA: 0x7FFE8767C300
        public void RemoveAt(){} // RVA: 0x7FFE877FA1C0
        public void get_SyncRoot(){} // RVA: 0x7FFE8693D110
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE877FA0A0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE877FA1F0
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE877FA280
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE877FA310
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE877FA3A0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE877FA430
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE877FA4C0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE8693D140
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8670DE60
        public void .ctor(){} // RVA: 0x7FFE877FA550
    }

    public class StringDictionary : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877FA5F0
        public void Add(){} // RVA: 0x7FFE877FA6A0
        public void GetEnumerator(){} // RVA: 0x7FFE872B3100
    }

}