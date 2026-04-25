// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.ObjectModel
// Classes: 5
// Methods: 89

namespace ThirdParty.DotNet.System.Collections.ObjectModel
{
    public class Collection`1 : Object
    {
        public System.Collections.Generic.IList`1<T> Count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_Items(){} // RVA: 0x7FFAC2C58E90
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void CopyTo(){} // RVA: 0x7FFAC2C77970
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void IndexOf(){} // RVA: 0x7FFAC2E8DC40
        public void Insert(){} // RVA: 0x7FFAC2E8DC40
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveAt(){} // RVA: 0x7FFAC2C70ED0
        public void ClearItems(){} // RVA: 0x7FFAC2C70980
        public void InsertItem(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveItem(){} // RVA: 0x7FFAC2C70ED0
        public void SetItem(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC2C77970
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAC2C67DE0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAC2C72BC0
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAC2C5E6B0
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAC2C59F60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAC2C5E6B0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAC2C72BC0
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAC2C70A40
        public void IsCompatibleObject(){} // RVA: 0x7FFAC2C59DE0
    }

    public class KeyedCollection`2 : Collection`1
    {
        public System.Collections.Generic.IEqualityComparer`1<U> Items;
        public System.Collections.Generic.Dictionary`2<U,T> Item;
        public int Dictionary;
        public int threshold;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C77970 | overloaded x3
        public void get_Items(){} // RVA: 0x7FFAC2C58E90
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetValue(){} // RVA: 0x7FFAC2E8DC40
        public void get_Dictionary(){} // RVA: 0x7FFAC2C58E90
        public void ClearItems(){} // RVA: 0x7FFAC2C70980
        public void GetKeyForItem(){} // RVA: 0x7FFAC2E8DC40
        public void InsertItem(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveItem(){} // RVA: 0x7FFAC2C70ED0
        public void SetItem(){} // RVA: 0x7FFAC2E8DC40
        public void AddKey(){} // RVA: 0x7FFAC2E8DC40
        public void CreateDictionary(){} // RVA: 0x7FFAC2C70980
        public void RemoveKey(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ReadOnlyCollection`1 : Object
    {
        public System.Collections.Generic.IList`1<Newtonsoft.Json.Utilities.StructMultiKey`2<string,string>> list; // 0x10
        public object _syncRoot; // 0x18
    }

    public class ReadOnlyDictionaryHelpers : Object
    {
        // ── Methods ──
        public void CopyToNonGenericICollectionHelper(){} // RVA: 0x7FFAC2C79C70
    }

    public class ReadOnlyDictionary`2 : Object
    {
        public System.Collections.Generic.IDictionary`2<U,T> Keys;
        public object Values;
        public KeyCollection<U,T> System.Collections.Generic.IDictionary<TKey,TValue>.Keys;
        public ValueCollection<U,T> System.Collections.Generic.IDictionary<TKey,TValue>.Values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void get_Keys(){} // RVA: 0x7FFAC2C58E90
        public void get_Values(){} // RVA: 0x7FFAC2C58E90
        public void ContainsKey(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAC2C58E90
        public void TryGetValue(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAC2C58E90
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAC2C77970
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear(){} // RVA: 0x7FFAC2C70980
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAC2E8DC40
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void IsCompatibleKey(){} // RVA: 0x7FFAC2C59DE0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAC2C79B30
        public void System.Collections.IDictionary.Clear(){} // RVA: 0x7FFAC2C70980
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAC2C59F60
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAC2C70A40
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAC2C58F40
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAC2C79B30
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC2C77970
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAC2C58E90
    }

}