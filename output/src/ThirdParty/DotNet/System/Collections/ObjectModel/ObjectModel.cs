// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.ObjectModel
// Classes: 5
// Methods: 89

namespace ThirdParty.DotNet.System.Collections.ObjectModel
{
    public class Collection`1 : Object
    {
        public System.Collections.Generic.IList`1<T> items; // 0x10
        public object Count;
        public 0x7FFE81116380 Items;
        public int Item; // 0xCAE8
        public object System.Collections.Generic.ICollection<T>.IsReadOnly;
        public IntPtr System.Collections.ICollection.IsSynchronized;
        public object System.Collections.ICollection.SyncRoot;
        public object System.Collections.IList.Item; // 0xD280
        public object System.Collections.IList.Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE84AC3DF0 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFE8622A460
        public void get_Items(){} // RVA: 0x7FFE81116380
        public void get_Item(){} // RVA: 0x7FFE81081080
        public void set_Item(){} // RVA: 0x7FFE8622BB80
        public void Add(){} // RVA: 0x7FFE8622BD20
        public void Clear(){} // RVA: 0x7FFE8622A6F0
        public void CopyTo(){} // RVA: 0x7FFE8622A770
        public void Contains(){} // RVA: 0x7FFE8622BEB0
        public void GetEnumerator(){} // RVA: 0x7FFE8622A840
        public void IndexOf(){} // RVA: 0x7FFE8622BFA0
        public void Insert(){} // RVA: 0x7FFE8622C090
        public void Remove(){} // RVA: 0x7FFE8622C230
        public void RemoveAt(){} // RVA: 0x7FFE8622AAE0
        public void ClearItems(){} // RVA: 0x7FFE8622ABC0
        public void InsertItem(){} // RVA: 0x7FFE8622C3B0
        public void RemoveItem(){} // RVA: 0x7FFE8622AC80
        public void SetItem(){} // RVA: 0x7FFE8622C4B0
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFE8622AD50
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8622C5B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE8622C600
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE8622C670
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE8622CA30
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE8622CB00
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFE8622AD50
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE8622CD60
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE8622CE10
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE8622D0E0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE8622D2D0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE8622D4C0
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE8622D780
        public void IsCompatibleObject(){} // RVA: 0x7FFE84211480
    }

    public class KeyedCollection`2 : Collection`1
    {
        public System.Collections.Generic.IEqualityComparer`1<U> comparer;
        public System.Collections.Generic.Dictionary`2<U,T> dict;
        public int keyCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4D070 | overloaded x3
        public void get_Items(){} // RVA: 0x7FFE80E2E2E0
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void TryGetValue(){} // RVA: 0x7FFE810A1420
        public void get_Dictionary(){} // RVA: 0x7FFE80E2E2E0
        public void ClearItems(){} // RVA: 0x7FFE80E45FE0
        public void GetKeyForItem(){} // RVA: 0x7FFE810A1420
        public void InsertItem(){} // RVA: 0x7FFE810A1420
        public void RemoveItem(){} // RVA: 0x7FFE80E46530
        public void SetItem(){} // RVA: 0x7FFE810A1420
        public void AddKey(){} // RVA: 0x7FFE810A1420
        public void CreateDictionary(){} // RVA: 0x7FFE80E45FE0
        public void RemoveKey(){} // RVA: 0x7FFE810A1420
    }

    public class ReadOnlyCollection`1 : Object
    {
        public System.Collections.Generic.IList`1<System.Collections.Generic.List`1<HIDElementDescriptor>> list; // 0x10
        public object _syncRoot; // 0x18
        public object IComparer`1;
        public object field_3; // 0xCE70
        public object field_4; // 0x3484
        public object field_5;
        public object field_6; // 0x7B70
        public object field_7;
        public object IComparer`1;
    }

    public class ReadOnlyDictionaryHelpers : Object
    {
        // ── Methods ──
        public void CopyToNonGenericICollectionHelper(){} // RVA: 0x7FFE80E4F370
    }

    public class ReadOnlyDictionary`2 : Object
    {
        public System.Collections.Generic.IDictionary`2<U,T> m_dictionary;
        public object _syncRoot;
        public KeyCollection<U,T> _keys;
        public ValueCollection<U,T> _values;
        public object field_4; // 0x87F
        public object field_5; // 0x880
        public object field_6; // 0x881
        public object field_7; // 0x882
        public object field_8; // 0x883
        public object field_9; // 0x884
        public object field_10; // 0x885
        public object field_11; // 0x886
        public object field_12; // 0x887
        public object field_13; // 0x888
        public object field_14; // 0x889
        public object field_15; // 0x88A
        public object field_16; // 0x88B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void ContainsKey(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void TryGetValue(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(){} // RVA: 0x7FFE810A1420
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFE810A1420
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void IsCompatibleKey(){} // RVA: 0x7FFE80E2F230
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFE80E4F230
        public void System.Collections.IDictionary.Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFE80E2F3B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFE80E460A0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFE80E2E390
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFE80E4F230
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFE80E2E2E0
    }

}