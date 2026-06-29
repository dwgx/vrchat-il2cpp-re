// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Specialized
// Classes: 12
// Methods: 138

namespace ThirdParty.DotNet.System.Collections.Specialized
{
    public class BitVector32 : ValueType
    {
        public object _data;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x91F140
        public void set_Item(){} // RVA: 0x91F160
        public void CreateMask(){} // RVA: 0x7713230
        public void Equals(){} // RVA: 0x91F180
        public void GetHashCode(){} // RVA: 0x91F210
        public void ToString(){} // RVA: 0x91F270
    }

    public class CaseSensitiveStringDictionary : StringDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7718280
        public void Add(){} // RVA: 0x7719340
    }

    public class CompatibleComparer : Object
    {
        public object _comparer;
        public object defaultComparer;
        public object _hcp;
        public object defaultHashProvider;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void Equals(){} // RVA: 0x771C950
        public void GetHashCode(){} // RVA: 0x771CA70
        public void get_Comparer(){} // RVA: 0xB5DBF0
        public void get_HashCodeProvider(){} // RVA: 0xB465B0
        public void get_DefaultComparer(){} // RVA: 0x771CB50
        public void get_DefaultHashCodeProvider(){} // RVA: 0x771CD50
    }

    public class ListDictionary : Object
    {
        public object head;
        public object version;
        public object count;
        public object comparer;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB70100
        public void get_Item(){} // RVA: 0x7713670
        public void set_Item(){} // RVA: 0x77137B0
        public void get_Count(){} // RVA: 0x2244FB0
        public void get_Keys(){} // RVA: 0x7713960
        public void get_IsReadOnly(){} // RVA: 0xB43320
        public void get_IsFixedSize(){} // RVA: 0xB43320
        public void get_IsSynchronized(){} // RVA: 0xB43320
        public void get_SyncRoot(){} // RVA: 0x7713A00
        public void get_Values(){} // RVA: 0x7713AB0
        public void Add(){} // RVA: 0x7713B50
        public void Clear(){} // RVA: 0x6873E00
        public void Contains(){} // RVA: 0x7713DD0
        public void CopyTo(){} // RVA: 0x7713F00
        public void GetEnumerator(){} // RVA: 0x7714190
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x77141F0
        public void Remove(){} // RVA: 0x7714250
    }

    public class NameObjectCollectionBase : Object
    {
        public object ReadOnlyName;
        public object CountName;
        public object ComparerName;
        public object HashCodeProviderName;
        public object KeysName;
        public object ValuesName;
        public object KeyComparerName;
        public object VersionName;
        public object _readOnly;
        public object _entriesArray;
        public object _keyComparer;
        public object _entriesTable;
        public object _nullKeyEntry;
        public object _keys;
        public object _serializationInfo;
        public object _version;
        public object _syncRoot;
        public object defaultComparer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB6A8C0
        public void GetObjectData(){} // RVA: 0x77197F0
        public void OnDeserialization(){} // RVA: 0x771A550
        public void Reset(){} // RVA: 0x771B1E0
        public void FindEntry(){} // RVA: 0x771B3B0
        public void get_IsReadOnly(){} // RVA: 0xC120A0
        public void BaseAdd(){} // RVA: 0x771B470
        public void BaseRemove(){} // RVA: 0x771B680
        public void BaseGet(){} // RVA: 0x771BA50
        public void BaseSet(){} // RVA: 0x771B940
        public void BaseGetKey(){} // RVA: 0x771BAF0
        public void GetEnumerator(){} // RVA: 0x771BB90
        public void get_Count(){} // RVA: 0x66DD600
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x771BBF0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x771BF40
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void BaseGetAllKeys(){} // RVA: 0x771BFF0
        public void .cctor(){} // RVA: 0x771C140
    }

    public class NameValueCollection : NameObjectCollectionBase
    {
        public object _all;
        public object _allKeys;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7715CA0
        public void InvalidateCachedArrays(){} // RVA: 0x7715060
        public void GetAsOneString(){} // RVA: 0x7715110
        public void GetAsStringArray(){} // RVA: 0x7715370
        public void Add(){} // RVA: 0x7715420
        public void Get(){} // RVA: 0x77159A0
        public void GetValues(){} // RVA: 0x7715A40
        public void Set(){} // RVA: 0x77156E0
        public void Remove(){} // RVA: 0x7715950
        public void get_Item(){} // RVA: 0x7055120
        public void set_Item(){} // RVA: 0x7715980
        public void GetKey(){} // RVA: 0x7715AE0
        public void get_AllKeys(){} // RVA: 0x7715AF0
    }

    public class NotifyCollectionChangedEventArgs : EventArgs
    {
        public object _action;
        public object _newItems;
        public object _oldItems;
        public object _newStartingIndex;
        public object _oldStartingIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x77189C0
        public void InitializeAddOrRemove(){} // RVA: 0x7718BA0
        public void InitializeAdd(){} // RVA: 0x7718BD0
        public void InitializeRemove(){} // RVA: 0x7718D00
        public void InitializeMoveOrReplace(){} // RVA: 0x7718E30
    }

    public class NotifyCollectionChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class OrderedDictionary : Object
    {
        public object _objectsArray;
        public object _objectsTable;
        public object _initialCapacity;
        public object _comparer;
        public object _readOnly;
        public object _syncRoot;
        public object _siInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB6A8C0
        public void get_Count(){} // RVA: 0x7715DB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB68DF0
        public void get_IsReadOnly(){} // RVA: 0xB68DF0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void get_Keys(){} // RVA: 0x7715DF0
        public void get_objectsArray(){} // RVA: 0x7715EA0
        public void get_objectsTable(){} // RVA: 0x7715F60
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7716030
        public void get_Item(){} // RVA: 0x77160E0
        public void set_Item(){} // RVA: 0x7716120
        public void get_Values(){} // RVA: 0x77163D0
        public void Add(){} // RVA: 0x7716480
        public void Clear(){} // RVA: 0x77165C0
        public void Contains(){} // RVA: 0x7716670
        public void CopyTo(){} // RVA: 0x77166B0
        public void IndexOfKey(){} // RVA: 0x7716700
        public void Remove(){} // RVA: 0x7716870
        public void GetEnumerator(){} // RVA: 0x77169B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7716A80
        public void GetObjectData(){} // RVA: 0x7716B50
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7716FD0
        public void OnDeserialization(){} // RVA: 0x7716FF0
    }

    public class ReadOnlyList : Object
    {
        public object _list;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Count(){} // RVA: 0x7718E90
        public void get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void get_IsFixedSize(){} // RVA: 0xC2E4C0
        public void get_IsSynchronized(){} // RVA: 0x7718EE0
        public void get_Item(){} // RVA: 0x7718F30
        public void set_Item(){} // RVA: 0x7718F90
        public void get_SyncRoot(){} // RVA: 0x7718FE0
        public void Add(){} // RVA: 0x7719030
        public void Clear(){} // RVA: 0x7719080
        public void Contains(){} // RVA: 0x77190D0
        public void CopyTo(){} // RVA: 0x7719130
        public void GetEnumerator(){} // RVA: 0x77191A0
        public void IndexOf(){} // RVA: 0x77191F0
        public void Insert(){} // RVA: 0x7719250
        public void Remove(){} // RVA: 0x77192A0
        public void RemoveAt(){} // RVA: 0x77192F0
    }

    public class StringCollection : Object
    {
        public object data;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7717E90
        public void set_Item(){} // RVA: 0x7717EE0
        public void get_Count(){} // RVA: 0x6875CA0
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void Add(){} // RVA: 0x7717F10
        public void Clear(){} // RVA: 0x71DA540
        public void Contains(){} // RVA: 0x6876210
        public void CopyTo(){} // RVA: 0x6875F50
        public void IndexOf(){} // RVA: 0x68764B0
        public void Insert(){} // RVA: 0x7717F40
        public void get_IsSynchronized(){} // RVA: 0xB43320
        public void Remove(){} // RVA: 0x75A0920
        public void RemoveAt(){} // RVA: 0x7717F70
        public void get_SyncRoot(){} // RVA: 0x6875F20
        public void System.Collections.IList.get_Item(){} // RVA: 0x7717E90
        public void System.Collections.IList.set_Item(){} // RVA: 0x7717FA0
        public void System.Collections.IList.Add(){} // RVA: 0x7718000
        public void System.Collections.IList.Contains(){} // RVA: 0x7718060
        public void System.Collections.IList.IndexOf(){} // RVA: 0x77180C0
        public void System.Collections.IList.Insert(){} // RVA: 0x7718120
        public void System.Collections.IList.Remove(){} // RVA: 0x7718180
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x6875F50
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x66459E0
        public void .ctor(){} // RVA: 0x77181E0
    }

    public class StringDictionary : Object
    {
        public object contents;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7718280
        public void Add(){} // RVA: 0x7718330
        public void GetEnumerator(){} // RVA: 0x71DA540
    }

}