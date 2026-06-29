// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Generic
// Classes: 100
// Methods: 4767

namespace ThirdParty.DotNet.System.Collections.Generic
{
    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3862580
        public void get_Comparer(){} // RVA: 0x3862610
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x3862630
        public void set_Item(){} // RVA: 0x38626E0
        public void Add(){} // RVA: 0x3862720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3862760
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x38627B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3862880
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3862980
        public void ContainsValue(){} // RVA: 0x35DA4A0
        public void CopyTo(){} // RVA: 0x35DA5B0
        public void GetEnumerator(){} // RVA: 0x35DA740
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x35DA7F0
        public void GetObjectData(){} // RVA: 0x38629C0
        public void FindEntry(){} // RVA: 0x3862D50
        public void Initialize(){} // RVA: 0x38630C0
        public void TryInsert(){} // RVA: 0x3863240
        public void OnDeserialization(){} // RVA: 0x3863880
        public void Resize(){} // RVA: 0x3863DD0
        public void Remove(){} // RVA: 0x3864340
        public void TryGetValue(){} // RVA: 0x38646F0
        public void TryAdd(){} // RVA: 0x38647B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x35DC900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x38647F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x35DA7F0
        public void EnsureCapacity(){} // RVA: 0x3864BD0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3864CC0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3864D70
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3864E90
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3865050
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3865210
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x35DD700
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x3865330
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3844150
        public void get_Comparer(){} // RVA: 0x38441E0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x3844200
        public void set_Item(){} // RVA: 0x38442B0
        public void Add(){} // RVA: 0x38442F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3844330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3844380
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3844450
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3844550
        public void ContainsValue(){} // RVA: 0x35DA4A0
        public void CopyTo(){} // RVA: 0x35DA5B0
        public void GetEnumerator(){} // RVA: 0x35DA740
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x35DA7F0
        public void GetObjectData(){} // RVA: 0x3844590
        public void FindEntry(){} // RVA: 0x3844920
        public void Initialize(){} // RVA: 0x3844C90
        public void TryInsert(){} // RVA: 0x3844E10
        public void OnDeserialization(){} // RVA: 0x3845450
        public void Resize(){} // RVA: 0x38459A0
        public void Remove(){} // RVA: 0x3845F10
        public void TryGetValue(){} // RVA: 0x38462C0
        public void TryAdd(){} // RVA: 0x3846380
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x35DC900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x38463C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x35DA7F0
        public void EnsureCapacity(){} // RVA: 0x38467A0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3846890
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3846940
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3846A60
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3846C20
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3846DE0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x35DD700
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x3846F00
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void .ctor(){} // RVA: 0x373FC70
        public void set_Item(){} // RVA: 0x373FD00
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void get_Values(){} // RVA: 0x35D9F90
        public void .ctor(){} // RVA: 0x3672E70
        public void TryGetValue(){} // RVA: 0x3674810
        public void Add(){} // RVA: 0x3672F30
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void Remove(){} // RVA: 0x36745D0
        public void get_Comparer(){} // RVA: 0x3652CA0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x366FD80
        public void set_Item(){} // RVA: 0x3672F00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3672F60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3672FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3673060
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3670060
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3673140
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x36732B0
        public void FindEntry(){} // RVA: 0x3670620
        public void Initialize(){} // RVA: 0x3673640
        public void TryInsert(){} // RVA: 0x36737C0
        public void OnDeserialization(){} // RVA: 0x3673CA0
        public void Resize(){} // RVA: 0x36741D0
        public void TryAdd(){} // RVA: 0x36748D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3674900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3674910
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3674CE0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3674DD0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3674E80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3674FA0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3675140
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3672490
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36752E0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x36DD8D0
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3694660
        public void get_Comparer(){} // RVA: 0x3691360
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36946F0
        public void set_Item(){} // RVA: 0x3694790
        public void Add(){} // RVA: 0x36947C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x36947F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3694840
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3694900
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3691670
        public void ContainsValue(){} // RVA: 0x3603370
        public void CopyTo(){} // RVA: 0x366B180
        public void GetEnumerator(){} // RVA: 0x3603560
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x36035F0
        public void GetObjectData(){} // RVA: 0x36949E0
        public void FindEntry(){} // RVA: 0x3691A30
        public void Initialize(){} // RVA: 0x3694D70
        public void TryInsert(){} // RVA: 0x3694EF0
        public void OnDeserialization(){} // RVA: 0x3695350
        public void Resize(){} // RVA: 0x3695880
        public void Remove(){} // RVA: 0x3695A70
        public void TryGetValue(){} // RVA: 0x3695CA0
        public void TryAdd(){} // RVA: 0x3695D10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x366C600
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3695D40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x36035F0
        public void EnsureCapacity(){} // RVA: 0x3696130
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3696220
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x36962D0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3696410
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x36965B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36938C0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3605A40
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36939D0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3766AB0
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36E1E80
        public void set_Item(){} // RVA: 0x3766B40
        public void Add(){} // RVA: 0x3766B90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3766BE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3766C40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3766D40
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36E2230
        public void ContainsValue(){} // RVA: 0x3766E60
        public void CopyTo(){} // RVA: 0x36E2370
        public void GetEnumerator(){} // RVA: 0x361C990
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x361CA40
        public void GetObjectData(){} // RVA: 0x3766F70
        public void FindEntry(){} // RVA: 0x36E28C0
        public void Initialize(){} // RVA: 0x3767300
        public void TryInsert(){} // RVA: 0x3767480
        public void OnDeserialization(){} // RVA: 0x3767970
        public void Resize(){} // RVA: 0x3767F00
        public void Remove(){} // RVA: 0x36E3BE0
        public void TryGetValue(){} // RVA: 0x36E3E80
        public void TryAdd(){} // RVA: 0x3768190
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x36E3FA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37681E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x361CA40
        public void EnsureCapacity(){} // RVA: 0x37685F0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x37686E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x36E4560
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3768790
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3768960
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E4A60
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x361F360
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E4B80
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3658390
        public void get_Comparer(){} // RVA: 0x3652CA0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x3658420
        public void set_Item(){} // RVA: 0x36584C0
        public void Add(){} // RVA: 0x36584F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3658520
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3658570
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3658630
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3658710
        public void ContainsValue(){} // RVA: 0x3658740
        public void CopyTo(){} // RVA: 0x3658810
        public void GetEnumerator(){} // RVA: 0x3603560
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x36035F0
        public void GetObjectData(){} // RVA: 0x3658930
        public void FindEntry(){} // RVA: 0x3658CC0
        public void Initialize(){} // RVA: 0x3658F30
        public void TryInsert(){} // RVA: 0x36590B0
        public void OnDeserialization(){} // RVA: 0x3659520
        public void Resize(){} // RVA: 0x3659A60
        public void Remove(){} // RVA: 0x3659E50
        public void TryGetValue(){} // RVA: 0x365A080
        public void TryAdd(){} // RVA: 0x365A0F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x365A120
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x365A130
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x36035F0
        public void EnsureCapacity(){} // RVA: 0x365A530
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x365A620
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x365A6D0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x365A810
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x365A9C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x365AB70
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3605A40
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x365AC80
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x37989D0
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36F9C40
        public void set_Item(){} // RVA: 0x3798A60
        public void Add(){} // RVA: 0x3798AA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3798AE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3798B40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3798C40
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36F9FD0
        public void ContainsValue(){} // RVA: 0x3798D60
        public void CopyTo(){} // RVA: 0x3798E70
        public void GetEnumerator(){} // RVA: 0x368B880
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x368B930
        public void GetObjectData(){} // RVA: 0x3799040
        public void FindEntry(){} // RVA: 0x36FA650
        public void Initialize(){} // RVA: 0x37993D0
        public void TryInsert(){} // RVA: 0x3799550
        public void OnDeserialization(){} // RVA: 0x3799A50
        public void Resize(){} // RVA: 0x3799FE0
        public void Remove(){} // RVA: 0x379A4D0
        public void TryGetValue(){} // RVA: 0x379A770
        public void TryAdd(){} // RVA: 0x379A840
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x379A880
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x379A890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x368B930
        public void EnsureCapacity(){} // RVA: 0x379ACC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x379ADB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x36FC250
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x379AE60
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x379B040
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36FC770
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x368DFB0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x379B220
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x36DD8D0
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x364EFD0
        public void get_Comparer(){} // RVA: 0x364F960
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x364F980
        public void set_Item(){} // RVA: 0x364FA20
        public void Add(){} // RVA: 0x364FA50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x364FA80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x364FAD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x364FB90
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x364FC70
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x364FCA0
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x364FE00
        public void FindEntry(){} // RVA: 0x3650190
        public void Initialize(){} // RVA: 0x3650410
        public void TryInsert(){} // RVA: 0x3650590
        public void OnDeserialization(){} // RVA: 0x3650A80
        public void Resize(){} // RVA: 0x3650FC0
        public void Remove(){} // RVA: 0x36513D0
        public void TryGetValue(){} // RVA: 0x3651620
        public void TryAdd(){} // RVA: 0x36516E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3651710
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3651720
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3651AF0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3651BE0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3651C90
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3651DB0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3651F60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3652110
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x3652220
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3652310
        public void get_Comparer(){} // RVA: 0x3652CA0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x366FD80
        public void set_Item(){} // RVA: 0x3672F00
        public void Add(){} // RVA: 0x3672F30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3672F60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3672FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3673060
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3670060
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3673140
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x36732B0
        public void FindEntry(){} // RVA: 0x3670620
        public void Initialize(){} // RVA: 0x3673640
        public void TryInsert(){} // RVA: 0x36737C0
        public void OnDeserialization(){} // RVA: 0x3673CA0
        public void Resize(){} // RVA: 0x36741D0
        public void Remove(){} // RVA: 0x36745D0
        public void TryGetValue(){} // RVA: 0x3674810
        public void TryAdd(){} // RVA: 0x36748D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3674900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3674910
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3674CE0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3674DD0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3674E80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3674FA0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3675140
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3672490
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36752E0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x37942A0
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x3794330
        public void set_Item(){} // RVA: 0x37943F0
        public void Add(){} // RVA: 0x3794470
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x37944F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3794580
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3794700
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x37948A0
        public void ContainsValue(){} // RVA: 0x37948D0
        public void CopyTo(){} // RVA: 0x3794A60
        public void GetEnumerator(){} // RVA: 0x3794CC0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3794D80
        public void GetObjectData(){} // RVA: 0x3794EB0
        public void FindEntry(){} // RVA: 0x3795240
        public void Initialize(){} // RVA: 0x3795480
        public void TryInsert(){} // RVA: 0x3795600
        public void OnDeserialization(){} // RVA: 0x3795B50
        public void Resize(){} // RVA: 0x3796100
        public void Remove(){} // RVA: 0x3796600
        public void TryGetValue(){} // RVA: 0x3796910
        public void TryAdd(){} // RVA: 0x3796A30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3796AB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3796AC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3794D80
        public void EnsureCapacity(){} // RVA: 0x3796FD0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x37970C0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3797170
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3797330
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3797550
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3797770
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3797890
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x37979C0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3672E70
        public void get_Comparer(){} // RVA: 0x3652CA0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x366FD80
        public void set_Item(){} // RVA: 0x3672F00
        public void Add(){} // RVA: 0x3672F30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3672F60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3672FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3673060
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3670060
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3673140
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x36732B0
        public void FindEntry(){} // RVA: 0x3670620
        public void Initialize(){} // RVA: 0x3673640
        public void TryInsert(){} // RVA: 0x36737C0
        public void OnDeserialization(){} // RVA: 0x3673CA0
        public void Resize(){} // RVA: 0x36741D0
        public void Remove(){} // RVA: 0x36745D0
        public void TryGetValue(){} // RVA: 0x3674810
        public void TryAdd(){} // RVA: 0x36748D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3674900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3674910
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3674CE0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3674DD0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3674E80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3674FA0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3675140
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3672490
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36752E0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x369CA40
        public void get_Comparer(){} // RVA: 0x3691360
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x369CAD0
        public void set_Item(){} // RVA: 0x369CB70
        public void Add(){} // RVA: 0x369CBA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x369CBD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x369CC10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x369CCD0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x369CDB0
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3673140
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x369CDE0
        public void FindEntry(){} // RVA: 0x369D170
        public void Initialize(){} // RVA: 0x369D3D0
        public void TryInsert(){} // RVA: 0x369D550
        public void OnDeserialization(){} // RVA: 0x369DA30
        public void Resize(){} // RVA: 0x369DF60
        public void Remove(){} // RVA: 0x369E360
        public void TryGetValue(){} // RVA: 0x369E5A0
        public void TryAdd(){} // RVA: 0x369E660
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3674900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x369E690
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x369EA60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x369EB50
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x369EC00
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x369ED20
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x369EEC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x369F060
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x369F170
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x38219D0
        public void get_Comparer(){} // RVA: 0x381BDA0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x3821A60
        public void set_Item(){} // RVA: 0x3821B20
        public void Add(){} // RVA: 0x3821B60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3821BA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3821BF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3821CD0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3821DD0
        public void ContainsValue(){} // RVA: 0x3821E00
        public void CopyTo(){} // RVA: 0x3821EF0
        public void GetEnumerator(){} // RVA: 0x35DA740
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x35DA7F0
        public void GetObjectData(){} // RVA: 0x3822040
        public void FindEntry(){} // RVA: 0x38223D0
        public void Initialize(){} // RVA: 0x3822650
        public void TryInsert(){} // RVA: 0x38227D0
        public void OnDeserialization(){} // RVA: 0x3822CB0
        public void Resize(){} // RVA: 0x3823200
        public void Remove(){} // RVA: 0x3823600
        public void TryGetValue(){} // RVA: 0x3823850
        public void TryAdd(){} // RVA: 0x3823910
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3823950
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3823960
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x35DA7F0
        public void EnsureCapacity(){} // RVA: 0x3823D60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3823E50
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3823F00
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3824040
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3824200
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x38243C0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x35DD700
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x38244D0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x372ECA0
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36DE280
        public void set_Item(){} // RVA: 0x372ED30
        public void Add(){} // RVA: 0x372ED60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x372ED90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x372EDE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x372EEA0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x372EF80
        public void CopyTo(){} // RVA: 0x36E5800
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x372F050
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x372F3E0
        public void TryInsert(){} // RVA: 0x372F560
        public void OnDeserialization(){} // RVA: 0x372F9C0
        public void Resize(){} // RVA: 0x372FF10
        public void Remove(){} // RVA: 0x36E6D20
        public void TryGetValue(){} // RVA: 0x36E6F90
        public void TryAdd(){} // RVA: 0x37301A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x36E7040
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37301D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x37305A0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3730690
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x36E06E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3730740
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3730900
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E7940
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x37312A0
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36DE280
        public void set_Item(){} // RVA: 0x3731330
        public void Add(){} // RVA: 0x3731360
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3731390
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x37313E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x37314A0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3731580
        public void CopyTo(){} // RVA: 0x36E5800
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x3731650
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x37319E0
        public void TryInsert(){} // RVA: 0x3731B60
        public void OnDeserialization(){} // RVA: 0x3731FC0
        public void Resize(){} // RVA: 0x3732510
        public void Remove(){} // RVA: 0x36E6D20
        public void TryGetValue(){} // RVA: 0x36E6F90
        public void TryAdd(){} // RVA: 0x37327A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x36E7040
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37327D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3732BA0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3732C90
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x36E06E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3732D40
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3732F00
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E7940
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3733C90
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36DE280
        public void set_Item(){} // RVA: 0x3733D20
        public void Add(){} // RVA: 0x3733D50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3733D80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3733DD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3733E90
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3733F70
        public void CopyTo(){} // RVA: 0x36E5800
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x3734040
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x37343D0
        public void TryInsert(){} // RVA: 0x3734550
        public void OnDeserialization(){} // RVA: 0x37349B0
        public void Resize(){} // RVA: 0x3734F00
        public void Remove(){} // RVA: 0x36E6D20
        public void TryGetValue(){} // RVA: 0x36E6F90
        public void TryAdd(){} // RVA: 0x3735190
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x36E7040
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37351C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3735590
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3735680
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x36E06E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3735730
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x37358F0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E7940
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x380C6F0
        public void get_Comparer(){} // RVA: 0x37F7110
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x380C780
        public void set_Item(){} // RVA: 0x380C820
        public void Add(){} // RVA: 0x380C850
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x380C880
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x380C8C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x380C980
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x380CA60
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3673140
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x380CA90
        public void FindEntry(){} // RVA: 0x380CE20
        public void Initialize(){} // RVA: 0x380D080
        public void TryInsert(){} // RVA: 0x380D200
        public void OnDeserialization(){} // RVA: 0x380D6E0
        public void Resize(){} // RVA: 0x380DC10
        public void Remove(){} // RVA: 0x380E010
        public void TryGetValue(){} // RVA: 0x380E250
        public void TryAdd(){} // RVA: 0x380E310
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3674900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x380E340
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x380E710
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x380E800
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x380E8B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x380E9D0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x380EB70
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x380ED10
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x380EE20
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x380C6F0
        public void get_Comparer(){} // RVA: 0x37F7110
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x380C780
        public void set_Item(){} // RVA: 0x380C820
        public void Add(){} // RVA: 0x380C850
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x380C880
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x380C8C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x380C980
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x380CA60
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3673140
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x380CA90
        public void FindEntry(){} // RVA: 0x380CE20
        public void Initialize(){} // RVA: 0x380D080
        public void TryInsert(){} // RVA: 0x380D200
        public void OnDeserialization(){} // RVA: 0x380D6E0
        public void Resize(){} // RVA: 0x380DC10
        public void Remove(){} // RVA: 0x380E010
        public void TryGetValue(){} // RVA: 0x380E250
        public void TryAdd(){} // RVA: 0x380E310
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3674900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x380E340
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x380E710
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x380E800
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x380E8B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x380E9D0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x380EB70
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x380ED10
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x380EE20
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x369CA40
        public void get_Comparer(){} // RVA: 0x3691360
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x369CAD0
        public void set_Item(){} // RVA: 0x369CB70
        public void Add(){} // RVA: 0x369CBA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x369CBD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x369CC10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x369CCD0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x369CDB0
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3673140
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x369CDE0
        public void FindEntry(){} // RVA: 0x369D170
        public void Initialize(){} // RVA: 0x369D3D0
        public void TryInsert(){} // RVA: 0x369D550
        public void OnDeserialization(){} // RVA: 0x369DA30
        public void Resize(){} // RVA: 0x369DF60
        public void Remove(){} // RVA: 0x369E360
        public void TryGetValue(){} // RVA: 0x369E5A0
        public void TryAdd(){} // RVA: 0x369E660
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3674900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x369E690
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x369EA60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x369EB50
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x369EC00
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x369ED20
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x369EEC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x369F060
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x369F170
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3738820
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x3736320
        public void set_Item(){} // RVA: 0x37388B0
        public void Add(){} // RVA: 0x37388E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3738910
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3738960
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3738A20
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3738B00
        public void CopyTo(){} // RVA: 0x3722F30
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x3738BD0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3738F60
        public void TryInsert(){} // RVA: 0x37390E0
        public void OnDeserialization(){} // RVA: 0x3739530
        public void Resize(){} // RVA: 0x3739A80
        public void Remove(){} // RVA: 0x3724200
        public void TryGetValue(){} // RVA: 0x3724470
        public void TryAdd(){} // RVA: 0x3739D10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3724510
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3739D40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x373A110
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x373A200
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3724A90
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x373A2B0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x373A470
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E7940
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x369CBA0
        public void .ctor(){} // RVA: 0x369CA40
        public void get_Comparer(){} // RVA: 0x3691360
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x369CAD0
        public void set_Item(){} // RVA: 0x369CB70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x369CBD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x369CC10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x369CCD0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x369CDB0
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3673140
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x369CDE0
        public void FindEntry(){} // RVA: 0x369D170
        public void Initialize(){} // RVA: 0x369D3D0
        public void TryInsert(){} // RVA: 0x369D550
        public void OnDeserialization(){} // RVA: 0x369DA30
        public void Resize(){} // RVA: 0x369DF60
        public void Remove(){} // RVA: 0x369E360
        public void TryGetValue(){} // RVA: 0x369E5A0
        public void TryAdd(){} // RVA: 0x369E660
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3674900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x369E690
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x369EA60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x369EB50
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x369EC00
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x369ED20
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x369EEC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x369F060
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x369F170
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3675BB0
        public void get_Comparer(){} // RVA: 0x3652CA0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x3675C40
        public void set_Item(){} // RVA: 0x3675CE0
        public void Add(){} // RVA: 0x3675D10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3675D40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3675D80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3675E40
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3670060
        public void ContainsValue(){} // RVA: 0x3675F20
        public void CopyTo(){} // RVA: 0x3670160
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x3675FF0
        public void FindEntry(){} // RVA: 0x3670620
        public void Initialize(){} // RVA: 0x3676380
        public void TryInsert(){} // RVA: 0x3676500
        public void OnDeserialization(){} // RVA: 0x3676970
        public void Resize(){} // RVA: 0x3676EA0
        public void Remove(){} // RVA: 0x3671780
        public void TryGetValue(){} // RVA: 0x36719B0
        public void TryAdd(){} // RVA: 0x3677090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3671A60
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x36770C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x36774C0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x36775B0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3672010
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3677660
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3677800
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3672490
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36725A0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void set_Item(){} // RVA: 0x3613530
        public void .ctor(){} // RVA: 0x3613400
        public void get_Comparer(){} // RVA: 0x360D3A0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x3613490
        public void Add(){} // RVA: 0x3613560
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3613590
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x36135E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x36136A0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3613780
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3606DE0
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x36137B0
        public void FindEntry(){} // RVA: 0x3613B40
        public void Initialize(){} // RVA: 0x3613DA0
        public void TryInsert(){} // RVA: 0x3613F20
        public void OnDeserialization(){} // RVA: 0x3614410
        public void Resize(){} // RVA: 0x3614950
        public void Remove(){} // RVA: 0x3614D60
        public void TryGetValue(){} // RVA: 0x3614FB0
        public void TryAdd(){} // RVA: 0x3615070
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x36089A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x36150A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3615460
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3615550
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3615620
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3615740
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x36158F0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3615AA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x3615BB0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3602FA0
        public void get_Comparer(){} // RVA: 0x3603030
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x3603050
        public void set_Item(){} // RVA: 0x36030F0
        public void Add(){} // RVA: 0x3603120
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3603150
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x36031A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3603260
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3603340
        public void ContainsValue(){} // RVA: 0x3603370
        public void CopyTo(){} // RVA: 0x3603440
        public void GetEnumerator(){} // RVA: 0x3603560
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x36035F0
        public void GetObjectData(){} // RVA: 0x36036C0
        public void FindEntry(){} // RVA: 0x3603A50
        public void Initialize(){} // RVA: 0x3603CB0
        public void TryInsert(){} // RVA: 0x3603E30
        public void OnDeserialization(){} // RVA: 0x36042B0
        public void Resize(){} // RVA: 0x36047F0
        public void Remove(){} // RVA: 0x3604BF0
        public void TryGetValue(){} // RVA: 0x3604E20
        public void TryAdd(){} // RVA: 0x3604E90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3604EC0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3604ED0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x36035F0
        public void EnsureCapacity(){} // RVA: 0x36052D0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x36053C0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3605470
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3605490
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x36055D0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3605780
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3605930
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3605A40
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x3605B10
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x35E86B0
        public void get_Comparer(){} // RVA: 0x35E8740
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x35E8760
        public void set_Item(){} // RVA: 0x35E8800
        public void Add(){} // RVA: 0x35E8830
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x35E8860
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x35E88B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x35E8970
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x35E8A50
        public void ContainsValue(){} // RVA: 0x35E8A80
        public void CopyTo(){} // RVA: 0x35E8B70
        public void GetEnumerator(){} // RVA: 0x35E8C90
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x35E8D30
        public void GetObjectData(){} // RVA: 0x35E8E10
        public void FindEntry(){} // RVA: 0x35E91A0
        public void Initialize(){} // RVA: 0x35E9450
        public void TryInsert(){} // RVA: 0x35E95D0
        public void OnDeserialization(){} // RVA: 0x35E9AA0
        public void Resize(){} // RVA: 0x35E9FD0
        public void Remove(){} // RVA: 0x35EA400
        public void TryGetValue(){} // RVA: 0x35EA670
        public void TryAdd(){} // RVA: 0x35EA6E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x35EA710
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x35EA720
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x35E8D30
        public void EnsureCapacity(){} // RVA: 0x35EAB10
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x35EAC00
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x35EACB0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x35EADF0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x35EAFA0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x35EB150
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x35EB260
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x35EB340
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x3606A80
        public void .ctor(){} // RVA: 0x3606920
        public void get_Comparer(){} // RVA: 0x3603030
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36069B0
        public void set_Item(){} // RVA: 0x3606A50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3606AB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3606B00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3606BC0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3606CA0
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3606DE0
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x36070B0
        public void FindEntry(){} // RVA: 0x3607440
        public void Initialize(){} // RVA: 0x36076A0
        public void TryInsert(){} // RVA: 0x3607820
        public void OnDeserialization(){} // RVA: 0x3607D10
        public void Resize(){} // RVA: 0x3608250
        public void Remove(){} // RVA: 0x3608660
        public void TryGetValue(){} // RVA: 0x36088B0
        public void TryAdd(){} // RVA: 0x3608970
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x36089A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x36089B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3608D70
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3608E60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3608F30
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3609050
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3609200
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36093B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36095A0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3606920
        public void get_Comparer(){} // RVA: 0x3603030
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36069B0
        public void set_Item(){} // RVA: 0x3606A50
        public void Add(){} // RVA: 0x3606A80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3606AB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3606B00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3606BC0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3606CA0
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3606DE0
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x36070B0
        public void FindEntry(){} // RVA: 0x3607440
        public void Initialize(){} // RVA: 0x36076A0
        public void TryInsert(){} // RVA: 0x3607820
        public void OnDeserialization(){} // RVA: 0x3607D10
        public void Resize(){} // RVA: 0x3608250
        public void Remove(){} // RVA: 0x3608660
        public void TryGetValue(){} // RVA: 0x36088B0
        public void TryAdd(){} // RVA: 0x3608970
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x36089A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x36089B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3608D70
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3608E60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3608F30
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3609050
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3609200
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36093B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36095A0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3672E70
        public void get_Comparer(){} // RVA: 0x3652CA0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x366FD80
        public void set_Item(){} // RVA: 0x3672F00
        public void Add(){} // RVA: 0x3672F30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3672F60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3672FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3673060
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3670060
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3673140
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x36732B0
        public void FindEntry(){} // RVA: 0x3670620
        public void Initialize(){} // RVA: 0x3673640
        public void TryInsert(){} // RVA: 0x36737C0
        public void OnDeserialization(){} // RVA: 0x3673CA0
        public void Resize(){} // RVA: 0x36741D0
        public void Remove(){} // RVA: 0x36745D0
        public void TryGetValue(){} // RVA: 0x3674810
        public void TryAdd(){} // RVA: 0x36748D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3674900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3674910
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3674CE0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3674DD0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3674E80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3674FA0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3675140
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3672490
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36752E0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3672E70
        public void get_Comparer(){} // RVA: 0x3652CA0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x366FD80
        public void set_Item(){} // RVA: 0x3672F00
        public void Add(){} // RVA: 0x3672F30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3672F60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3672FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3673060
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3670060
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3673140
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x36732B0
        public void FindEntry(){} // RVA: 0x3670620
        public void Initialize(){} // RVA: 0x3673640
        public void TryInsert(){} // RVA: 0x36737C0
        public void OnDeserialization(){} // RVA: 0x3673CA0
        public void Resize(){} // RVA: 0x36741D0
        public void Remove(){} // RVA: 0x36745D0
        public void TryGetValue(){} // RVA: 0x3674810
        public void TryAdd(){} // RVA: 0x36748D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3674900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3674910
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3674CE0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3674DD0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3674E80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3674FA0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3675140
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3672490
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36752E0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3606920
        public void get_Comparer(){} // RVA: 0x3603030
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36069B0
        public void set_Item(){} // RVA: 0x3606A50
        public void Add(){} // RVA: 0x3606A80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3606AB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3606B00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3606BC0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3606CA0
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3606DE0
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x36070B0
        public void FindEntry(){} // RVA: 0x3607440
        public void Initialize(){} // RVA: 0x36076A0
        public void TryInsert(){} // RVA: 0x3607820
        public void OnDeserialization(){} // RVA: 0x3607D10
        public void Resize(){} // RVA: 0x3608250
        public void Remove(){} // RVA: 0x3608660
        public void TryGetValue(){} // RVA: 0x36088B0
        public void TryAdd(){} // RVA: 0x3608970
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x36089A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x36089B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3608D70
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3608E60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3608F30
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3609050
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3609200
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36093B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36095A0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x36F74A0
        public void .ctor(){} // RVA: 0x36F73D0
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36E8300
        public void set_Item(){} // RVA: 0x36F7460
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x36F74E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x36F7530
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x36F7610
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36E8630
        public void ContainsValue(){} // RVA: 0x36F7710
        public void CopyTo(){} // RVA: 0x36E8750
        public void GetEnumerator(){} // RVA: 0x35DA740
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x35DA7F0
        public void GetObjectData(){} // RVA: 0x36F7800
        public void FindEntry(){} // RVA: 0x36E8C70
        public void Initialize(){} // RVA: 0x36F7B90
        public void TryInsert(){} // RVA: 0x36F7D10
        public void OnDeserialization(){} // RVA: 0x36F81C0
        public void Resize(){} // RVA: 0x36F8730
        public void Remove(){} // RVA: 0x36E9F30
        public void TryGetValue(){} // RVA: 0x36EA1B0
        public void TryAdd(){} // RVA: 0x36F89C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x36EA2B0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x36F8A00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x35DA7F0
        public void EnsureCapacity(){} // RVA: 0x36F8DE0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x36F8ED0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x36EA840
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x36F8F80
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x36F9150
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36EAD30
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x35DD700
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36EAE50
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x36FD160
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36FD1F0
        public void set_Item(){} // RVA: 0x36FD260
        public void Add(){} // RVA: 0x36FD290
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x36FD2C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x36FD310
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x36FD3E0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x36FD4C0
        public void CopyTo(){} // RVA: 0x36FD580
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x36FD700
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x36FDA90
        public void TryInsert(){} // RVA: 0x36FDC10
        public void OnDeserialization(){} // RVA: 0x36FE070
        public void Resize(){} // RVA: 0x36FE5C0
        public void Remove(){} // RVA: 0x36FE850
        public void TryGetValue(){} // RVA: 0x36FEAC0
        public void TryAdd(){} // RVA: 0x36FEB40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x36FEB70
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x36FEB80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x36FEF50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x36FF040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x36FF0F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x36FF230
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x36FF3F0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E7940
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3690A00
        public void get_Comparer(){} // RVA: 0x3691360
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x369CAD0
        public void set_Item(){} // RVA: 0x369CB70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x369CBD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x369CC10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x369CCD0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x369CDB0
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3673140
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x369CDE0
        public void FindEntry(){} // RVA: 0x369D170
        public void Initialize(){} // RVA: 0x369D3D0
        public void TryInsert(){} // RVA: 0x369D550
        public void OnDeserialization(){} // RVA: 0x369DA30
        public void Resize(){} // RVA: 0x369DF60
        public void Remove(){} // RVA: 0x369E360
        public void TryGetValue(){} // RVA: 0x369E5A0
        public void TryAdd(){} // RVA: 0x369E660
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3674900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x369E690
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x369EA60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x369EB50
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x369EC00
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x369ED20
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x369EEC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x369F060
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x369F170
        public void Add(){} // RVA: 0x369CBA0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3690A00
        public void get_Comparer(){} // RVA: 0x3691360
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x369CAD0
        public void set_Item(){} // RVA: 0x369CB70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x369CBD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x369CC10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x369CCD0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x369CDB0
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3673140
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x369CDE0
        public void FindEntry(){} // RVA: 0x369D170
        public void Initialize(){} // RVA: 0x369D3D0
        public void TryInsert(){} // RVA: 0x369D550
        public void OnDeserialization(){} // RVA: 0x369DA30
        public void Resize(){} // RVA: 0x369DF60
        public void Remove(){} // RVA: 0x369E360
        public void TryGetValue(){} // RVA: 0x369E5A0
        public void TryAdd(){} // RVA: 0x369E660
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3674900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x369E690
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x369EA60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x369EB50
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x369EC00
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x369ED20
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x369EEC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x369F060
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x369F170
        public void Add(){} // RVA: 0x369CBA0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void ContainsKey(){} // RVA: 0x380CA60
        public void get_Item(){} // RVA: 0x380C780
        public void Add(){} // RVA: 0x380C850
        public void Clear(){} // RVA: 0x35DA3F0
        public void .ctor(){} // RVA: 0x380C6F0
        public void get_Comparer(){} // RVA: 0x37F7110
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void set_Item(){} // RVA: 0x380C820
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x380C880
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x380C8C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x380C980
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3673140
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x380CA90
        public void FindEntry(){} // RVA: 0x380CE20
        public void Initialize(){} // RVA: 0x380D080
        public void TryInsert(){} // RVA: 0x380D200
        public void OnDeserialization(){} // RVA: 0x380D6E0
        public void Resize(){} // RVA: 0x380DC10
        public void Remove(){} // RVA: 0x380E010
        public void TryGetValue(){} // RVA: 0x380E250
        public void TryAdd(){} // RVA: 0x380E310
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3674900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x380E340
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x380E710
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x380E800
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x380E8B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x380E9D0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x380EB70
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x380ED10
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x380EE20
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x380C780
        public void Add(){} // RVA: 0x380C850
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x380CA60
        public void .ctor(){} // RVA: 0x380C6F0
        public void get_Comparer(){} // RVA: 0x37F7110
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void set_Item(){} // RVA: 0x380C820
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x380C880
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x380C8C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x380C980
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3673140
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x380CA90
        public void FindEntry(){} // RVA: 0x380CE20
        public void Initialize(){} // RVA: 0x380D080
        public void TryInsert(){} // RVA: 0x380D200
        public void OnDeserialization(){} // RVA: 0x380D6E0
        public void Resize(){} // RVA: 0x380DC10
        public void Remove(){} // RVA: 0x380E010
        public void TryGetValue(){} // RVA: 0x380E250
        public void TryAdd(){} // RVA: 0x380E310
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3674900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x380E340
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x380E710
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x380E800
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x380E8B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x380E9D0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x380EB70
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x380ED10
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x380EE20
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x368B150
        public void get_Comparer(){} // RVA: 0x3652CA0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x368B1E0
        public void set_Item(){} // RVA: 0x368B2A0
        public void Add(){} // RVA: 0x368B2E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x368B320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x368B380
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x368B480
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x368B5A0
        public void ContainsValue(){} // RVA: 0x368B5D0
        public void CopyTo(){} // RVA: 0x368B6E0
        public void GetEnumerator(){} // RVA: 0x368B880
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x368B930
        public void GetObjectData(){} // RVA: 0x368BA30
        public void FindEntry(){} // RVA: 0x368BDC0
        public void Initialize(){} // RVA: 0x368C040
        public void TryInsert(){} // RVA: 0x368C1C0
        public void OnDeserialization(){} // RVA: 0x368C6D0
        public void Resize(){} // RVA: 0x368CC40
        public void Remove(){} // RVA: 0x368D050
        public void TryGetValue(){} // RVA: 0x368D2C0
        public void TryAdd(){} // RVA: 0x368D390
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x368D3D0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x368D3E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x368B930
        public void EnsureCapacity(){} // RVA: 0x368D830
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x368D920
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x368D9D0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x368DB20
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x368DCE0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x368DEA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x368DFB0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x368E0B0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3672E70
        public void get_Comparer(){} // RVA: 0x3652CA0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x366FD80
        public void set_Item(){} // RVA: 0x3672F00
        public void Add(){} // RVA: 0x3672F30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3672F60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3672FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3673060
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3670060
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3673140
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x36732B0
        public void FindEntry(){} // RVA: 0x3670620
        public void Initialize(){} // RVA: 0x3673640
        public void TryInsert(){} // RVA: 0x36737C0
        public void OnDeserialization(){} // RVA: 0x3673CA0
        public void Resize(){} // RVA: 0x36741D0
        public void Remove(){} // RVA: 0x36745D0
        public void TryGetValue(){} // RVA: 0x3674810
        public void TryAdd(){} // RVA: 0x36748D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3674900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3674910
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3674CE0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3674DD0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3674E80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3674FA0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3675140
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3672490
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36752E0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x36BD330
        public void get_Comparer(){} // RVA: 0x36B96E0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36BD3C0
        public void set_Item(){} // RVA: 0x36BD460
        public void Add(){} // RVA: 0x36BD490
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x36BD4C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x36BD510
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x36BD5D0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36BD6B0
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x36BD6E0
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x36BD850
        public void FindEntry(){} // RVA: 0x36BDBE0
        public void Initialize(){} // RVA: 0x36BDE60
        public void TryInsert(){} // RVA: 0x36BDFE0
        public void OnDeserialization(){} // RVA: 0x36BE4C0
        public void Resize(){} // RVA: 0x36BEA00
        public void Remove(){} // RVA: 0x36BEE00
        public void TryGetValue(){} // RVA: 0x36BF040
        public void TryAdd(){} // RVA: 0x36BF100
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x36BF130
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x36BF140
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x36BF4F0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x36BF5E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x36BF690
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x36BF7B0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x36BF950
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36BFAF0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36BFC00
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x37363C0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void TryGetValue(){} // RVA: 0x3724470
        public void Clear(){} // RVA: 0x35DA3F0
        public void Remove(){} // RVA: 0x3724200
        public void set_Item(){} // RVA: 0x3736390
        public void .ctor(){} // RVA: 0x3736290
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x3736320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x37363F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3736440
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3736500
        public void ContainsValue(){} // RVA: 0x36C09C0
        public void CopyTo(){} // RVA: 0x3722F30
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37365E0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3736970
        public void TryInsert(){} // RVA: 0x3736AF0
        public void OnDeserialization(){} // RVA: 0x3736F40
        public void Resize(){} // RVA: 0x3737490
        public void TryAdd(){} // RVA: 0x3737720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3724510
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3737750
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3737B20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3737C10
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3724A90
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3737CC0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3737E80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E7940
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void TryGetValue(){} // RVA: 0x36E0090
        public void Remove(){} // RVA: 0x36DFE10
        public void .ctor(){} // RVA: 0x36DD8D0
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x37363C0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void TryGetValue(){} // RVA: 0x3724470
        public void Clear(){} // RVA: 0x35DA3F0
        public void Remove(){} // RVA: 0x3724200
        public void set_Item(){} // RVA: 0x3736390
        public void .ctor(){} // RVA: 0x3736290
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3737750
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3737B20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3737C10
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3724A90
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3737CC0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3737E80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E7940
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x3736320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x37363F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3736440
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3736500
        public void ContainsValue(){} // RVA: 0x36C09C0
        public void CopyTo(){} // RVA: 0x3722F30
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37365E0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3736970
        public void TryInsert(){} // RVA: 0x3736AF0
        public void OnDeserialization(){} // RVA: 0x3736F40
        public void Resize(){} // RVA: 0x3737490
        public void TryAdd(){} // RVA: 0x3737720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3724510
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x35E1980
        public void get_Comparer(){} // RVA: 0x35E1A10
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x35E1A30
        public void set_Item(){} // RVA: 0x35E1AE0
        public void Add(){} // RVA: 0x35E1B20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x35E1B60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x35E1BB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x35E1C80
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x35E1D80
        public void ContainsValue(){} // RVA: 0x35DA4A0
        public void CopyTo(){} // RVA: 0x35DA5B0
        public void GetEnumerator(){} // RVA: 0x35DA740
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x35DA7F0
        public void GetObjectData(){} // RVA: 0x35E1DC0
        public void FindEntry(){} // RVA: 0x35E2150
        public void Initialize(){} // RVA: 0x35E2410
        public void TryInsert(){} // RVA: 0x35E2590
        public void OnDeserialization(){} // RVA: 0x35E2B30
        public void Resize(){} // RVA: 0x35E3080
        public void Remove(){} // RVA: 0x35E3540
        public void TryGetValue(){} // RVA: 0x35E3840
        public void TryAdd(){} // RVA: 0x35E3900
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x35DC900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x35E3940
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x35DA7F0
        public void EnsureCapacity(){} // RVA: 0x35E3D20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x35E3E10
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x35E3EC0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x35E3FE0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x35E41A0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x35E4360
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x35DD700
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x35E4480
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3672E70
        public void get_Comparer(){} // RVA: 0x3652CA0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x366FD80
        public void set_Item(){} // RVA: 0x3672F00
        public void Add(){} // RVA: 0x3672F30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3672F60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3672FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3673060
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3670060
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3673140
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x36732B0
        public void FindEntry(){} // RVA: 0x3670620
        public void Initialize(){} // RVA: 0x3673640
        public void TryInsert(){} // RVA: 0x36737C0
        public void OnDeserialization(){} // RVA: 0x3673CA0
        public void Resize(){} // RVA: 0x36741D0
        public void Remove(){} // RVA: 0x36745D0
        public void TryGetValue(){} // RVA: 0x3674810
        public void TryAdd(){} // RVA: 0x36748D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3674900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3674910
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3674CE0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3674DD0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3674E80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3674FA0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3675140
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3672490
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36752E0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void Add(){} // RVA: 0x373FD30
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3672E70
        public void get_Comparer(){} // RVA: 0x3652CA0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x366FD80
        public void set_Item(){} // RVA: 0x3672F00
        public void Add(){} // RVA: 0x3672F30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3672F60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3672FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3673060
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3670060
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3673140
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x36732B0
        public void FindEntry(){} // RVA: 0x3670620
        public void Initialize(){} // RVA: 0x3673640
        public void TryInsert(){} // RVA: 0x36737C0
        public void OnDeserialization(){} // RVA: 0x3673CA0
        public void Resize(){} // RVA: 0x36741D0
        public void Remove(){} // RVA: 0x36745D0
        public void TryGetValue(){} // RVA: 0x3674810
        public void TryAdd(){} // RVA: 0x36748D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3674900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3674910
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3674CE0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3674DD0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3674E80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3674FA0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3675140
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3672490
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36752E0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3672E70
        public void get_Comparer(){} // RVA: 0x3652CA0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x366FD80
        public void set_Item(){} // RVA: 0x3672F00
        public void Add(){} // RVA: 0x3672F30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3672F60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3672FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3673060
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3670060
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3673140
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x36732B0
        public void FindEntry(){} // RVA: 0x3670620
        public void Initialize(){} // RVA: 0x3673640
        public void TryInsert(){} // RVA: 0x36737C0
        public void OnDeserialization(){} // RVA: 0x3673CA0
        public void Resize(){} // RVA: 0x36741D0
        public void Remove(){} // RVA: 0x36745D0
        public void TryGetValue(){} // RVA: 0x3674810
        public void TryAdd(){} // RVA: 0x36748D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3674900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3674910
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3674CE0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3674DD0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3674E80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3674FA0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3675140
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3672490
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36752E0
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x36DD8D0
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
        public void Add(){} // RVA: 0x373FD30
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373FD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
        public void Remove(){} // RVA: 0x36DFE10
        public void TryGetValue(){} // RVA: 0x36E0090
        public void TryAdd(){} // RVA: 0x3741270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37412A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37412C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3741650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3741740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37417F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3741910
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3741AC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E0BA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36E0CC0
        public void Add(){} // RVA: 0x373FD30
    }

    public class Dictionary`2 : Object
    {
        public object _buckets;
        public object _entries;
        public object _count;
        public object _freeList;
        public object _freeCount;
        public object _version;
        public object _comparer;
        public object _keys;
        public object _values;
        public object _syncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x37A8210
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36E8300
        public void set_Item(){} // RVA: 0x37A82A0
        public void Add(){} // RVA: 0x37A82E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x37A8320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x37A8370
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x37A8450
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36E8630
        public void ContainsValue(){} // RVA: 0x37A8550
        public void CopyTo(){} // RVA: 0x37A8640
        public void GetEnumerator(){} // RVA: 0x35DA740
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x35DA7F0
        public void GetObjectData(){} // RVA: 0x37A87B0
        public void FindEntry(){} // RVA: 0x36E8C70
        public void Initialize(){} // RVA: 0x37A8B40
        public void TryInsert(){} // RVA: 0x37A8CC0
        public void OnDeserialization(){} // RVA: 0x37A9170
        public void Resize(){} // RVA: 0x37A96E0
        public void Remove(){} // RVA: 0x3788490
        public void TryGetValue(){} // RVA: 0x3788720
        public void TryAdd(){} // RVA: 0x37A9970
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37A99B0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37A99C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x35DA7F0
        public void EnsureCapacity(){} // RVA: 0x37A9DA0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x37A9E90
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x36EA840
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x37A9F40
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x37AA110
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36EAD30
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x35DD700
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36EAE50
    }

    public class Dictionary`2[] : Array
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

}