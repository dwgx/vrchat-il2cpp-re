// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Specialized
// Classes: 13
// Methods: 160

namespace ThirdParty.DotNet.System.Collections.Specialized
{
    public class BitVector32 : ValueType
    {
        public uint Item; // 0x10

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFAC944CF10
        public void set_Item(){} // RVA: 0x7FFAC944CF30
        public void CreateMask(){} // RVA: 0x7FFAC944CF50 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC944CFD0
        public void GetHashCode(){} // RVA: 0x7FFAC944D060
        public void ToString(){} // RVA: 0x7FFAC944D210 | overloaded x2
    }

    public class CaseSensitiveStringDictionary : StringDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9451EB0
        public void Add(){} // RVA: 0x7FFAC9452F70
    }

    public class CompatibleComparer : Object
    {
        public System.Collections.IComparer Comparer; // 0x10
        public System.Collections.IComparer HashCodeProvider;
        public System.Collections.IHashCodeProvider DefaultComparer; // 0x18
        public System.Collections.IHashCodeProvider DefaultHashCodeProvider; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void Equals(){} // RVA: 0x7FFAC94564E0
        public void GetHashCode(){} // RVA: 0x7FFAC9456600
        public void get_Comparer(){} // RVA: 0x7FFAC2F3C380
        public void get_HashCodeProvider(){} // RVA: 0x7FFAC2F247C0
        public void get_DefaultComparer(){} // RVA: 0x7FFAC94566E0
        public void get_DefaultHashCodeProvider(){} // RVA: 0x7FFAC94568E0
    }

    public class INotifyCollectionChanged
    {
    }

    public class ListDictionary : Object
    {
        public DictionaryNode Item; // 0x10
        public int Count; // 0x18
        public int Keys; // 0x1C
        public System.Collections.IComparer IsReadOnly; // 0x20
        public object IsFixedSize; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F4F0D0 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFAC944D370
        public void set_Item(){} // RVA: 0x7FFAC944D4B0
        public void get_Count(){} // RVA: 0x7FFAC44357F0
        public void get_Keys(){} // RVA: 0x7FFAC944D660
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void get_IsFixedSize(){} // RVA: 0x7FFAC2F21320
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void get_SyncRoot(){} // RVA: 0x7FFAC944D700
        public void get_Values(){} // RVA: 0x7FFAC944D7B0
        public void Add(){} // RVA: 0x7FFAC944D850
        public void Clear(){} // RVA: 0x7FFAC85917C0
        public void Contains(){} // RVA: 0x7FFAC944DAD0
        public void CopyTo(){} // RVA: 0x7FFAC944DC00
        public void GetEnumerator(){} // RVA: 0x7FFAC944DE90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC944DEF0
        public void Remove(){} // RVA: 0x7FFAC944DF50
    }

    public class NameObjectCollectionBase : Object
    {
        public string IsReadOnly;
        public string Count;
        public string System.Collections.ICollection.SyncRoot;
        public string System.Collections.ICollection.IsSynchronized;
        public string KeysName;
        public string ValuesName;
        public string KeyComparerName;
        public string VersionName;
        public bool _readOnly; // 0x10
        public System.Collections.ArrayList _entriesArray; // 0x18
        public System.Collections.IEqualityComparer _keyComparer; // 0x20
        public System.Collections.Hashtable _entriesTable; // 0x28
        public NameObjectEntry _nullKeyEntry; // 0x30
        public KeysCollection _keys; // 0x38
        public System.Runtime.Serialization.SerializationInfo _serializationInfo; // 0x40
        public int _version; // 0x48
        public object _syncRoot; // 0x50
        public System.StringComparer defaultComparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F49200 | overloaded x6
        public void GetObjectData(){} // RVA: 0x7FFAC9453420
        public void OnDeserialization(){} // RVA: 0x7FFAC9454130
        public void Reset(){} // RVA: 0x7FFAC9454DC0 | overloaded x2
        public void FindEntry(){} // RVA: 0x7FFAC9454F70
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2FEB5E0
        public void BaseAdd(){} // RVA: 0x7FFAC9455030
        public void BaseRemove(){} // RVA: 0x7FFAC9455240
        public void BaseGet(){} // RVA: 0x7FFAC9455610 | overloaded x2
        public void BaseSet(){} // RVA: 0x7FFAC9455500
        public void BaseGetKey(){} // RVA: 0x7FFAC94556B0
        public void GetEnumerator(){} // RVA: 0x7FFAC9455750
        public void get_Count(){} // RVA: 0x7FFAC83FC4F0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC94557B0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC9455B00
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void BaseGetAllKeys(){} // RVA: 0x7FFAC9455BB0
        public void .cctor(){} // RVA: 0x7FFAC9455CD0
    }

    public class NameValueCollection : NameObjectCollectionBase
    {
        public string[] Item; // 0x58
        public string[] AllKeys; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC944F980 | overloaded x5
        public void InvalidateCachedArrays(){} // RVA: 0x7FFAC944ED60
        public void GetAsOneString(){} // RVA: 0x7FFAC944EE10
        public void GetAsStringArray(){} // RVA: 0x7FFAC944F080
        public void Add(){} // RVA: 0x7FFAC944F130
        public void Get(){} // RVA: 0x7FFAC944F6A0 | overloaded x2
        public void GetValues(){} // RVA: 0x7FFAC944F740 | overloaded x2
        public void Set(){} // RVA: 0x7FFAC944F3F0
        public void Remove(){} // RVA: 0x7FFAC944F650
        public void get_Item(){} // RVA: 0x7FFAC8D7DB30
        public void set_Item(){} // RVA: 0x7FFAC944F680
        public void GetKey(){} // RVA: 0x7FFAC944F7E0
        public void get_AllKeys(){} // RVA: 0x7FFAC944F7F0
    }

    public class NotifyCollectionChangedEventArgs : EventArgs
    {
        public 0x6B137C60 _action; // 0x10
        public System.Collections.IList _newItems; // 0x18
        public System.Collections.IList _oldItems; // 0x20
        public int _newStartingIndex; // 0x28
        public int _oldStartingIndex; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC94525F0 | overloaded x4
        public void InitializeAddOrRemove(){} // RVA: 0x7FFAC94527D0
        public void InitializeAdd(){} // RVA: 0x7FFAC9452800
        public void InitializeRemove(){} // RVA: 0x7FFAC9452930
        public void InitializeMoveOrReplace(){} // RVA: 0x7FFAC9452A60
    }

    public class NotifyCollectionChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class OrderedDictionary : Object
    {
        public System.Collections.ArrayList Count; // 0x10
        public System.Collections.Hashtable System.Collections.IDictionary.IsFixedSize; // 0x18
        public int IsReadOnly; // 0x20
        public System.Collections.IEqualityComparer System.Collections.ICollection.IsSynchronized; // 0x28
        public bool Keys; // 0x30
        public object objectsArray; // 0x38
        public System.Runtime.Serialization.SerializationInfo objectsTable; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F49200 | overloaded x4
        public void get_Count(){} // RVA: 0x7FFAC944FA90
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAC2F47450
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F47450
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void get_Keys(){} // RVA: 0x7FFAC944FAD0
        public void get_objectsArray(){} // RVA: 0x7FFAC944FB80
        public void get_objectsTable(){} // RVA: 0x7FFAC944FC40
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC944FD10
        public void get_Item(){} // RVA: 0x7FFAC944FDC0
        public void set_Item(){} // RVA: 0x7FFAC944FE00
        public void get_Values(){} // RVA: 0x7FFAC94500B0
        public void Add(){} // RVA: 0x7FFAC9450160
        public void Clear(){} // RVA: 0x7FFAC94502A0
        public void Contains(){} // RVA: 0x7FFAC9450350
        public void CopyTo(){} // RVA: 0x7FFAC9450390
        public void IndexOfKey(){} // RVA: 0x7FFAC94503E0
        public void Remove(){} // RVA: 0x7FFAC9450550
        public void GetEnumerator(){} // RVA: 0x7FFAC9450690
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC9450760
        public void GetObjectData(){} // RVA: 0x7FFAC9450830
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFAC9450AD0
        public void OnDeserialization(){} // RVA: 0x7FFAC9450AF0
    }

    public class ReadOnlyList : Object
    {
        public System.Collections.IList Count; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Count(){} // RVA: 0x7FFAC9452AC0
        public void get_IsReadOnly(){} // RVA: 0x7FFAC3006850
        public void get_IsFixedSize(){} // RVA: 0x7FFAC3006850
        public void get_IsSynchronized(){} // RVA: 0x7FFAC9452B10
        public void get_Item(){} // RVA: 0x7FFAC9452B60
        public void set_Item(){} // RVA: 0x7FFAC9452BC0
        public void get_SyncRoot(){} // RVA: 0x7FFAC9452C10
        public void Add(){} // RVA: 0x7FFAC9452C60
        public void Clear(){} // RVA: 0x7FFAC9452CB0
        public void Contains(){} // RVA: 0x7FFAC9452D00
        public void CopyTo(){} // RVA: 0x7FFAC9452D60
        public void GetEnumerator(){} // RVA: 0x7FFAC9452DD0
        public void IndexOf(){} // RVA: 0x7FFAC9452E20
        public void Insert(){} // RVA: 0x7FFAC9452E80
        public void Remove(){} // RVA: 0x7FFAC9452ED0
        public void RemoveAt(){} // RVA: 0x7FFAC9452F20
    }

    public class StringCollection : Object
    {
        public System.Collections.ArrayList Item; // 0x10

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFAC9451960
        public void set_Item(){} // RVA: 0x7FFAC94519F0
        public void get_Count(){} // RVA: 0x7FFAC8593680
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAC2F21320
        public void Add(){} // RVA: 0x7FFAC9451A20
        public void Clear(){} // RVA: 0x7FFAC32F0BD0
        public void Contains(){} // RVA: 0x7FFAC8593C20
        public void CopyTo(){} // RVA: 0x7FFAC8593960
        public void IndexOf(){} // RVA: 0x7FFAC8593EC0
        public void Insert(){} // RVA: 0x7FFAC9451A50
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void Remove(){} // RVA: 0x7FFAC92D3BD0
        public void RemoveAt(){} // RVA: 0x7FFAC9451A80
        public void get_SyncRoot(){} // RVA: 0x7FFAC8593930
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAC9451960
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAC9451AB0
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAC9451B40
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAC9451BD0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAC9451C60
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAC9451CF0
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAC9451D80
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC8593960
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8364560
        public void .ctor(){} // RVA: 0x7FFAC9451E10
    }

    public class StringDictionary : Object
    {
        public System.Collections.Hashtable contents; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9451EB0
        public void Add(){} // RVA: 0x7FFAC9451F60
        public void GetEnumerator(){} // RVA: 0x7FFAC32F0BD0
    }

}