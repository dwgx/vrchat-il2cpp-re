// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.ObjectModel
// Classes: 5
// Methods: 89

namespace ThirdParty.DotNet.System.Collections.ObjectModel
{
    public class Collection`1 : Object
    {
        public URA.?<T1717590928> Count; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_Items(){} // RVA: 0x7FFD4E078E90
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void Insert(){} // RVA: 0x7FFD4E2ADC40
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void ClearItems(){} // RVA: 0x7FFD4E090980
        public void InsertItem(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveItem(){} // RVA: 0x7FFD4E090ED0
        public void SetItem(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFD4E087DE0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFD4E092BC0
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IList.Add(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFD4E079F60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFD4E092BC0
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFD4E090A40
        public void IsCompatibleObject(){} // RVA: 0x7FFD4E079DE0
    }

    public class KeyedCollection`2 : Collection`1
    {
        public URA.hEraNames<T1717590912> Items;
        public URA.DateTime<T1717590912,T1717590928> Item;
        public int Dictionary;
        public int threshold;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E097970 | overloaded x3
        public void get_Items(){} // RVA: 0x7FFD4E078E90
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetValue(){} // RVA: 0x7FFD4E2ADC40
        public void get_Dictionary(){} // RVA: 0x7FFD4E078E90
        public void ClearItems(){} // RVA: 0x7FFD4E090980
        public void GetKeyForItem(){} // RVA: 0x7FFD4E2ADC40
        public void InsertItem(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveItem(){} // RVA: 0x7FFD4E090ED0
        public void SetItem(){} // RVA: 0x7FFD4E2ADC40
        public void AddKey(){} // RVA: 0x7FFD4E2ADC40
        public void CreateDictionary(){} // RVA: 0x7FFD4E090980
        public void RemoveKey(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ReadOnlyCollection`1 : Object
    {
        public URA.?<URA.mes<int,numeratorObject.NullAttribute>> list; // 0x10
        public object _syncRoot; // 0x18
    }

    public class ReadOnlyDictionaryHelpers : Object
    {
        // ── Methods ──
        public void CopyToNonGenericICollectionHelper(){} // RVA: 0x7FFD4E099C70
    }

    public class ReadOnlyDictionary`2 : Object
    {
        public URA.X_CALENDARS<T1717591040,T1717591056> Keys;
        public object Values;
        public ySuff<T1717591040,T1717591056> System.Collections.Generic.IDictionary<TKey,TValue>.Keys;
        public ff<T1717591040,T1717591056> System.Collections.Generic.IDictionary<TKey,TValue>.Values;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void get_Keys(){} // RVA: 0x7FFD4E078E90
        public void get_Values(){} // RVA: 0x7FFD4E078E90
        public void ContainsKey(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFD4E078E90
        public void TryGetValue(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFD4E078E90
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear(){} // RVA: 0x7FFD4E090980
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void IsCompatibleKey(){} // RVA: 0x7FFD4E079DE0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFD4E099B30
        public void System.Collections.IDictionary.Clear(){} // RVA: 0x7FFD4E090980
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFD4E079F60
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFD4E090A40
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFD4E078F40
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFD4E099B30
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFD4E078E90
    }

}