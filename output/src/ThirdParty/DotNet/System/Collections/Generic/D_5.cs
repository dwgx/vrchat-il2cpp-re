// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Generic
// Classes: 100
// Methods: 4800

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
        public void .ctor(){} // RVA: 0x35F0540
        public void get_Comparer(){} // RVA: 0x35F05D0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x35F05F0
        public void set_Item(){} // RVA: 0x35F06A0
        public void Add(){} // RVA: 0x35F06E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x35F0720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x35F0770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x35F0840
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x35F0940
        public void ContainsValue(){} // RVA: 0x35DA4A0
        public void CopyTo(){} // RVA: 0x35E5310
        public void GetEnumerator(){} // RVA: 0x35DA740
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x35DA7F0
        public void GetObjectData(){} // RVA: 0x35F0980
        public void FindEntry(){} // RVA: 0x35F0D10
        public void Initialize(){} // RVA: 0x35F1050
        public void TryInsert(){} // RVA: 0x35F11D0
        public void OnDeserialization(){} // RVA: 0x35F17D0
        public void Resize(){} // RVA: 0x35F1D20
        public void Remove(){} // RVA: 0x35F2240
        public void TryGetValue(){} // RVA: 0x35F2590
        public void TryAdd(){} // RVA: 0x35F2650
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x35E7160
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x35F2690
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x35DA7F0
        public void EnsureCapacity(){} // RVA: 0x35F2A70
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x35F2B60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x35F2C10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x35F2D30
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x35F2EF0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x35F30B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x35DD700
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x35F31D0
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
        public void .ctor(){} // RVA: 0x3790FD0
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36F0810
        public void set_Item(){} // RVA: 0x3791060
        public void Add(){} // RVA: 0x37910B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3791100
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3791170
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3791290
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36F0C10
        public void ContainsValue(){} // RVA: 0x37913C0
        public void CopyTo(){} // RVA: 0x37914F0
        public void GetEnumerator(){} // RVA: 0x36205E0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3620690
        public void GetObjectData(){} // RVA: 0x37916B0
        public void FindEntry(){} // RVA: 0x36F12E0
        public void Initialize(){} // RVA: 0x3791A40
        public void TryInsert(){} // RVA: 0x3791BC0
        public void OnDeserialization(){} // RVA: 0x3792070
        public void Resize(){} // RVA: 0x3792610
        public void Remove(){} // RVA: 0x3792AF0
        public void TryGetValue(){} // RVA: 0x3792D80
        public void TryAdd(){} // RVA: 0x3792E10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3792E60
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3792E70
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3620690
        public void EnsureCapacity(){} // RVA: 0x37932B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x37933A0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x36F2FF0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3793450
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3793630
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36F3510
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3623170
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x3793810
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
        public void .ctor(){} // RVA: 0x37FDEF0
        public void get_Comparer(){} // RVA: 0x37F7110
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x37FDF80
        public void set_Item(){} // RVA: 0x37FE020
        public void Add(){} // RVA: 0x37FE050
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x37FE080
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x37FE0D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x37FE190
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x37FE270
        public void ContainsValue(){} // RVA: 0x3603370
        public void CopyTo(){} // RVA: 0x366B180
        public void GetEnumerator(){} // RVA: 0x3603560
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x36035F0
        public void GetObjectData(){} // RVA: 0x37FE2A0
        public void FindEntry(){} // RVA: 0x37FE630
        public void Initialize(){} // RVA: 0x37FE8A0
        public void TryInsert(){} // RVA: 0x37FEA20
        public void OnDeserialization(){} // RVA: 0x37FEE80
        public void Resize(){} // RVA: 0x37FF3B0
        public void Remove(){} // RVA: 0x37FF7A0
        public void TryGetValue(){} // RVA: 0x37FF9D0
        public void TryAdd(){} // RVA: 0x37FFA40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x366C600
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37FFA70
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x36035F0
        public void EnsureCapacity(){} // RVA: 0x37FFE60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x37FFF50
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3800000
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3800140
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x38002E0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3800480
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3605A40
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x3800590
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
        public void .ctor(){} // RVA: 0x365ED40
        public void get_Comparer(){} // RVA: 0x3652CA0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x365EDD0
        public void set_Item(){} // RVA: 0x365EE70
        public void Add(){} // RVA: 0x365EEA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x365EED0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x365EF20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x365EFE0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3658710
        public void ContainsValue(){} // RVA: 0x365F0C0
        public void CopyTo(){} // RVA: 0x365F180
        public void GetEnumerator(){} // RVA: 0x3603560
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x36035F0
        public void GetObjectData(){} // RVA: 0x365F2A0
        public void FindEntry(){} // RVA: 0x3658CC0
        public void Initialize(){} // RVA: 0x365F630
        public void TryInsert(){} // RVA: 0x365F7B0
        public void OnDeserialization(){} // RVA: 0x365FC10
        public void Resize(){} // RVA: 0x3660150
        public void Remove(){} // RVA: 0x3660340
        public void TryGetValue(){} // RVA: 0x3660570
        public void TryAdd(){} // RVA: 0x36605E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3660610
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3660620
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x36035F0
        public void EnsureCapacity(){} // RVA: 0x3660A20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3660B10
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3660BC0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3660D00
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3660EB0
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
        public void .ctor(){} // RVA: 0x366D7D0
        public void get_Comparer(){} // RVA: 0x3652CA0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x366AE90
        public void set_Item(){} // RVA: 0x366D860
        public void Add(){} // RVA: 0x366D890
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x366D8C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x366D910
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x366D9D0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3658710
        public void ContainsValue(){} // RVA: 0x366DAB0
        public void CopyTo(){} // RVA: 0x366B180
        public void GetEnumerator(){} // RVA: 0x3603560
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x36035F0
        public void GetObjectData(){} // RVA: 0x366DB80
        public void FindEntry(){} // RVA: 0x3658CC0
        public void Initialize(){} // RVA: 0x366DF10
        public void TryInsert(){} // RVA: 0x366E090
        public void OnDeserialization(){} // RVA: 0x366E4F0
        public void Resize(){} // RVA: 0x366EA20
        public void Remove(){} // RVA: 0x366C330
        public void TryGetValue(){} // RVA: 0x366C560
        public void TryAdd(){} // RVA: 0x366EC10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x366C600
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x366EC40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x36035F0
        public void EnsureCapacity(){} // RVA: 0x366F030
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x366F120
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x366CBA0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x366F1D0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x366F370
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
        public void .ctor(){} // RVA: 0x36A2ED0
        public void get_Comparer(){} // RVA: 0x3691360
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36A2F60
        public void set_Item(){} // RVA: 0x36A3020
        public void Add(){} // RVA: 0x36A3060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x36A30A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x36A30F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x36A31C0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36A32C0
        public void ContainsValue(){} // RVA: 0x36A32F0
        public void CopyTo(){} // RVA: 0x3665860
        public void GetEnumerator(){} // RVA: 0x3627BB0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3627C50
        public void GetObjectData(){} // RVA: 0x36A33E0
        public void FindEntry(){} // RVA: 0x36A3770
        public void Initialize(){} // RVA: 0x36A39D0
        public void TryInsert(){} // RVA: 0x36A3B50
        public void OnDeserialization(){} // RVA: 0x36A3FB0
        public void Resize(){} // RVA: 0x36A4870
        public void Remove(){} // RVA: 0x36A4C60
        public void TryGetValue(){} // RVA: 0x36A4E90
        public void TryAdd(){} // RVA: 0x36A4F10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x36674F0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x36A4F50
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3627C50
        public void EnsureCapacity(){} // RVA: 0x36A5340
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x36A5430
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x36A54E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x36A5620
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x36A57D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36A5980
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x362A4D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36A5A90
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
        public void .ctor(){} // RVA: 0x36AC160
        public void get_Comparer(){} // RVA: 0x3691360
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36AC1F0
        public void set_Item(){} // RVA: 0x36AC2B0
        public void Add(){} // RVA: 0x36AC2F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x36AC330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x36AC390
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x36AC480
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x369CDB0
        public void ContainsValue(){} // RVA: 0x36AC590
        public void CopyTo(){} // RVA: 0x36AC6A0
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x36AC7C0
        public void FindEntry(){} // RVA: 0x369D170
        public void Initialize(){} // RVA: 0x36ACB50
        public void TryInsert(){} // RVA: 0x36ACCD0
        public void OnDeserialization(){} // RVA: 0x36AD150
        public void Resize(){} // RVA: 0x36ADA40
        public void Remove(){} // RVA: 0x36ADE30
        public void TryGetValue(){} // RVA: 0x36AE070
        public void TryAdd(){} // RVA: 0x36AE0F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x36AE130
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x36AE140
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x36AE530
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x36AE620
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x36AE6D0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x36AE820
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x36AE9E0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x369F060
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36AEBA0
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
        public void .ctor(){} // RVA: 0x37A54F0
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x3794330
        public void set_Item(){} // RVA: 0x37A5580
        public void Add(){} // RVA: 0x37A5600
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x37A5680
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x37A5710
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x37A5890
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x37948A0
        public void ContainsValue(){} // RVA: 0x37A5A30
        public void CopyTo(){} // RVA: 0x3794A60
        public void GetEnumerator(){} // RVA: 0x3794CC0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3794D80
        public void GetObjectData(){} // RVA: 0x37A5BC0
        public void FindEntry(){} // RVA: 0x3795240
        public void Initialize(){} // RVA: 0x37A5F50
        public void TryInsert(){} // RVA: 0x37A60D0
        public void OnDeserialization(){} // RVA: 0x37A6620
        public void Resize(){} // RVA: 0x37A6BD0
        public void Remove(){} // RVA: 0x3796600
        public void TryGetValue(){} // RVA: 0x3796910
        public void TryAdd(){} // RVA: 0x37A6E60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3796AB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37A6EE0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3794D80
        public void EnsureCapacity(){} // RVA: 0x37A73F0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x37A74E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3797170
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x37A7590
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x37A77B0
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
        public void .ctor(){} // RVA: 0x362AEE0
        public void get_Comparer(){} // RVA: 0x3627610
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x362AF70
        public void set_Item(){} // RVA: 0x362B020
        public void Add(){} // RVA: 0x362B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x362B0A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x362B0F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x362B1C0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x362B2C0
        public void ContainsValue(){} // RVA: 0x35DA4A0
        public void CopyTo(){} // RVA: 0x362B300
        public void GetEnumerator(){} // RVA: 0x35DA740
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x35DA7F0
        public void GetObjectData(){} // RVA: 0x362B460
        public void FindEntry(){} // RVA: 0x362B7F0
        public void Initialize(){} // RVA: 0x362BB20
        public void TryInsert(){} // RVA: 0x362BCA0
        public void OnDeserialization(){} // RVA: 0x362C260
        public void Resize(){} // RVA: 0x362C7B0
        public void Remove(){} // RVA: 0x362CCC0
        public void TryGetValue(){} // RVA: 0x362D010
        public void TryAdd(){} // RVA: 0x362D0D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x362D110
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x362D120
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x35DA7F0
        public void EnsureCapacity(){} // RVA: 0x362D510
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x362D600
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x362D6B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x362D7D0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x362D990
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x362DB50
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x35DD700
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x362DC70
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
        public void .ctor(){} // RVA: 0x36A6490
        public void get_Comparer(){} // RVA: 0x3691360
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36A6520
        public void set_Item(){} // RVA: 0x36A65C0
        public void Add(){} // RVA: 0x36A65F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x36A6620
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x36A6670
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x36A6730
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3691670
        public void ContainsValue(){} // RVA: 0x367AE80
        public void CopyTo(){} // RVA: 0x367AF70
        public void GetEnumerator(){} // RVA: 0x3603560
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x36035F0
        public void GetObjectData(){} // RVA: 0x36A6810
        public void FindEntry(){} // RVA: 0x3691A30
        public void Initialize(){} // RVA: 0x36A6BA0
        public void TryInsert(){} // RVA: 0x36A6D20
        public void OnDeserialization(){} // RVA: 0x36A7180
        public void Resize(){} // RVA: 0x36A76B0
        public void Remove(){} // RVA: 0x36A78A0
        public void TryGetValue(){} // RVA: 0x3695CA0
        public void TryAdd(){} // RVA: 0x36A7AD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x367C380
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x36A7B00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x36035F0
        public void EnsureCapacity(){} // RVA: 0x36A7EF0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x36A7FE0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x36A8090
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x36A81D0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x36A8380
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
        public void .ctor(){} // RVA: 0x3786D10
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36E8300
        public void set_Item(){} // RVA: 0x3786DA0
        public void Add(){} // RVA: 0x3786DE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3786E20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3786E70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3786F50
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36E8630
        public void ContainsValue(){} // RVA: 0x3787050
        public void CopyTo(){} // RVA: 0x3787140
        public void GetEnumerator(){} // RVA: 0x35DA740
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x35DA7F0
        public void GetObjectData(){} // RVA: 0x37872D0
        public void FindEntry(){} // RVA: 0x36E8C70
        public void Initialize(){} // RVA: 0x3787660
        public void TryInsert(){} // RVA: 0x37877E0
        public void OnDeserialization(){} // RVA: 0x3787C90
        public void Resize(){} // RVA: 0x3788200
        public void Remove(){} // RVA: 0x3788490
        public void TryGetValue(){} // RVA: 0x3788720
        public void TryAdd(){} // RVA: 0x37887E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3788820
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3788830
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x35DA7F0
        public void EnsureCapacity(){} // RVA: 0x3788C10
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3788D00
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x36EA840
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3788DB0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3788F80
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
        public void Add(){} // RVA: 0x3613560
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
        public void set_Item(){} // RVA: 0x3613530
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
        public void .ctor(){} // RVA: 0x373AE10
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void set_Item(){} // RVA: 0x373AF10
        public void Add(){} // RVA: 0x373AF40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373AF70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373AFC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373B080
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3670090
        public void CopyTo(){} // RVA: 0x36E5800
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x373B160
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x373B4F0
        public void TryInsert(){} // RVA: 0x373B670
        public void OnDeserialization(){} // RVA: 0x373BAD0
        public void Resize(){} // RVA: 0x373C020
        public void Remove(){} // RVA: 0x36E6D20
        public void TryGetValue(){} // RVA: 0x36E6F90
        public void TryAdd(){} // RVA: 0x373C2B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x36E7040
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x373C2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x373C6B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x373C7A0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x36E06E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x373C850
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x373CA10
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
        public void .ctor(){} // RVA: 0x35FF9A0
        public void get_Comparer(){} // RVA: 0x35FFA30
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x35FFA50
        public void set_Item(){} // RVA: 0x35FFB00
        public void Add(){} // RVA: 0x35FFB40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x35FFB80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x35FFBD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x35FFCA0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x35FFDA0
        public void ContainsValue(){} // RVA: 0x35DA4A0
        public void CopyTo(){} // RVA: 0x35FFDE0
        public void GetEnumerator(){} // RVA: 0x35DA740
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x35DA7F0
        public void GetObjectData(){} // RVA: 0x35FFF50
        public void FindEntry(){} // RVA: 0x36002E0
        public void Initialize(){} // RVA: 0x36005A0
        public void TryInsert(){} // RVA: 0x3600720
        public void OnDeserialization(){} // RVA: 0x3600C60
        public void Resize(){} // RVA: 0x36011B0
        public void Remove(){} // RVA: 0x3601670
        public void TryGetValue(){} // RVA: 0x3601970
        public void TryAdd(){} // RVA: 0x3601A30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3601A70
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3601A80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x35DA7F0
        public void EnsureCapacity(){} // RVA: 0x3601E70
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3601F60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3602010
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3602130
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x36022F0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36024B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x35DD700
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36025D0
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
        public void .ctor(){} // RVA: 0x36F9BB0
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36F9C40
        public void set_Item(){} // RVA: 0x36F9CD0
        public void Add(){} // RVA: 0x36F9D10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x36F9D50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x36F9DB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x36F9EB0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36F9FD0
        public void ContainsValue(){} // RVA: 0x36FA000
        public void CopyTo(){} // RVA: 0x36FA110
        public void GetEnumerator(){} // RVA: 0x368B880
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x368B930
        public void GetObjectData(){} // RVA: 0x36FA2C0
        public void FindEntry(){} // RVA: 0x36FA650
        public void Initialize(){} // RVA: 0x36FA8A0
        public void TryInsert(){} // RVA: 0x36FAA20
        public void OnDeserialization(){} // RVA: 0x36FAEB0
        public void Resize(){} // RVA: 0x36FB440
        public void Remove(){} // RVA: 0x36FB920
        public void TryGetValue(){} // RVA: 0x36FBBB0
        public void TryAdd(){} // RVA: 0x36FBC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x36FBC80
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x36FBC90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x368B930
        public void EnsureCapacity(){} // RVA: 0x36FC0B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x36FC1A0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x36FC250
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x36FC3B0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x36FC590
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36FC770
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x368DFB0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36FC890
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
        public void .ctor(){} // RVA: 0x3840000
        public void get_Comparer(){} // RVA: 0x383C820
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x3840090
        public void set_Item(){} // RVA: 0x3840180
        public void Add(){} // RVA: 0x38401E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3840240
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x38402C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x38403C0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3840500
        public void ContainsValue(){} // RVA: 0x3840540
        public void CopyTo(){} // RVA: 0x3840650
        public void GetEnumerator(){} // RVA: 0x36205E0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3620690
        public void GetObjectData(){} // RVA: 0x3840810
        public void FindEntry(){} // RVA: 0x3840BA0
        public void Initialize(){} // RVA: 0x3840ED0
        public void TryInsert(){} // RVA: 0x3841050
        public void OnDeserialization(){} // RVA: 0x38416D0
        public void Resize(){} // RVA: 0x3841C60
        public void Remove(){} // RVA: 0x38420F0
        public void TryGetValue(){} // RVA: 0x38423D0
        public void TryAdd(){} // RVA: 0x38424B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3842510
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3842520
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3620690
        public void EnsureCapacity(){} // RVA: 0x3842990
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3842A80
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3842B30
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3842C90
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3842E90
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3843090
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3623170
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x38431C0
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
        public void .ctor(){} // RVA: 0x383C790
        public void get_Comparer(){} // RVA: 0x383C820
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x383C840
        public void set_Item(){} // RVA: 0x383C910
        public void Add(){} // RVA: 0x383C950
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x383C990
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x383C9F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x383CAC0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x383CBD0
        public void ContainsValue(){} // RVA: 0x37BA9C0
        public void CopyTo(){} // RVA: 0x383CC10
        public void GetEnumerator(){} // RVA: 0x361C990
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x361CA40
        public void GetObjectData(){} // RVA: 0x383CDD0
        public void FindEntry(){} // RVA: 0x383D160
        public void Initialize(){} // RVA: 0x383D490
        public void TryInsert(){} // RVA: 0x383D610
        public void OnDeserialization(){} // RVA: 0x383DC90
        public void Resize(){} // RVA: 0x383E210
        public void Remove(){} // RVA: 0x383E6A0
        public void TryGetValue(){} // RVA: 0x383E960
        public void TryAdd(){} // RVA: 0x383EA30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x383EA70
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x383EA80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x361CA40
        public void EnsureCapacity(){} // RVA: 0x383EEA0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x383EF90
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x383F040
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x383F170
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x383F350
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x383F530
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x361F360
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x383F660
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
        public void .ctor(){} // RVA: 0x379EC40
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x379ECD0
        public void set_Item(){} // RVA: 0x379ED90
        public void Add(){} // RVA: 0x379EE10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x379EE90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x379EF20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x379F0A0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x379F240
        public void ContainsValue(){} // RVA: 0x379F270
        public void CopyTo(){} // RVA: 0x379F400
        public void GetEnumerator(){} // RVA: 0x379F600
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x379F6E0
        public void GetObjectData(){} // RVA: 0x379F820
        public void FindEntry(){} // RVA: 0x379FBB0
        public void Initialize(){} // RVA: 0x379FDF0
        public void TryInsert(){} // RVA: 0x379FF70
        public void OnDeserialization(){} // RVA: 0x37A04C0
        public void Resize(){} // RVA: 0x37A0A70
        public void Remove(){} // RVA: 0x37A0F70
        public void TryGetValue(){} // RVA: 0x37A1280
        public void TryAdd(){} // RVA: 0x37A13A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37A1420
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37A1430
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x379F6E0
        public void EnsureCapacity(){} // RVA: 0x37A1960
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x37A1A50
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37A1B00
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x37A1CB0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x37A1ED0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x37A20F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x37A2210
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x37A2350
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
        public void set_Item(){} // RVA: 0x3736390
        public void Add(){} // RVA: 0x37363C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x37363F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3736440
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3736500
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
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
        public void Remove(){} // RVA: 0x3724200
        public void TryGetValue(){} // RVA: 0x3724470
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
        public void .ctor(){} // RVA: 0x367D6E0
        public void get_Comparer(){} // RVA: 0x3652CA0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x367D770
        public void set_Item(){} // RVA: 0x367D850
        public void Add(){} // RVA: 0x367D8C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x367D930
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x367D9B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x367DAF0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x367DC50
        public void ContainsValue(){} // RVA: 0x367DC80
        public void CopyTo(){} // RVA: 0x367DDE0
        public void GetEnumerator(){} // RVA: 0x367DF90
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x367E050
        public void GetObjectData(){} // RVA: 0x367E150
        public void FindEntry(){} // RVA: 0x367E4E0
        public void Initialize(){} // RVA: 0x367E760
        public void TryInsert(){} // RVA: 0x367E8E0
        public void OnDeserialization(){} // RVA: 0x367EDB0
        public void Resize(){} // RVA: 0x367F700
        public void Remove(){} // RVA: 0x367FB00
        public void TryGetValue(){} // RVA: 0x367FD80
        public void TryAdd(){} // RVA: 0x367FE30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x367FEA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x367FEB0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x367E050
        public void EnsureCapacity(){} // RVA: 0x3680370
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3680460
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3605470
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3680510
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3680680
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3680860
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3680A40
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3680B50
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x3680C50
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
        public void .ctor(){} // RVA: 0x362AEE0
        public void get_Comparer(){} // RVA: 0x3627610
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x362AF70
        public void set_Item(){} // RVA: 0x362B020
        public void Add(){} // RVA: 0x362B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x362B0A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x362B0F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x362B1C0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x362B2C0
        public void ContainsValue(){} // RVA: 0x35DA4A0
        public void CopyTo(){} // RVA: 0x362B300
        public void GetEnumerator(){} // RVA: 0x35DA740
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x35DA7F0
        public void GetObjectData(){} // RVA: 0x362B460
        public void FindEntry(){} // RVA: 0x362B7F0
        public void Initialize(){} // RVA: 0x362BB20
        public void TryInsert(){} // RVA: 0x362BCA0
        public void OnDeserialization(){} // RVA: 0x362C260
        public void Resize(){} // RVA: 0x362C7B0
        public void Remove(){} // RVA: 0x362CCC0
        public void TryGetValue(){} // RVA: 0x362D010
        public void TryAdd(){} // RVA: 0x362D0D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x362D110
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x362D120
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x35DA7F0
        public void EnsureCapacity(){} // RVA: 0x362D510
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x362D600
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x362D6B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x362D7D0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x362D990
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x362DB50
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x35DD700
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x362DC70
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
        public void set_Item(){} // RVA: 0x3736390
        public void Add(){} // RVA: 0x37363C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x37363F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3736440
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3736500
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
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
        public void Remove(){} // RVA: 0x3724200
        public void TryGetValue(){} // RVA: 0x3724470
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
        public void .ctor(){} // RVA: 0x3665350
        public void get_Comparer(){} // RVA: 0x3652CA0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36653E0
        public void set_Item(){} // RVA: 0x36654A0
        public void Add(){} // RVA: 0x36654E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3665520
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3665570
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3665640
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x3665740
        public void ContainsValue(){} // RVA: 0x3665770
        public void CopyTo(){} // RVA: 0x3665860
        public void GetEnumerator(){} // RVA: 0x3627BB0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3627C50
        public void GetObjectData(){} // RVA: 0x3665980
        public void FindEntry(){} // RVA: 0x3665D10
        public void Initialize(){} // RVA: 0x3665F70
        public void TryInsert(){} // RVA: 0x36660F0
        public void OnDeserialization(){} // RVA: 0x3666550
        public void Resize(){} // RVA: 0x3666E10
        public void Remove(){} // RVA: 0x3667200
        public void TryGetValue(){} // RVA: 0x3667430
        public void TryAdd(){} // RVA: 0x36674B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x36674F0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3667500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3627C50
        public void EnsureCapacity(){} // RVA: 0x36678F0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x36679E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3667A90
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3667BD0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3667D80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3667F30
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x362A4D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x3668040
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
        public void set_Item(){} // RVA: 0x3736390
        public void Add(){} // RVA: 0x37363C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x37363F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3736440
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3736500
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
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
        public void Remove(){} // RVA: 0x3724200
        public void TryGetValue(){} // RVA: 0x3724470
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
        public void .ctor(){} // RVA: 0x37544E0
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x3736320
        public void set_Item(){} // RVA: 0x3754570
        public void Add(){} // RVA: 0x37545A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x37545D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3754620
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x37546E0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x37547C0
        public void CopyTo(){} // RVA: 0x3722F30
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x3754890
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3754C20
        public void TryInsert(){} // RVA: 0x3754DA0
        public void OnDeserialization(){} // RVA: 0x37551F0
        public void Resize(){} // RVA: 0x3755740
        public void Remove(){} // RVA: 0x3724200
        public void TryGetValue(){} // RVA: 0x3724470
        public void TryAdd(){} // RVA: 0x37559D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3724510
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3755A00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x3755DD0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3755EC0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3724A90
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3755F70
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3756130
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
        public void .ctor(){} // RVA: 0x3729AC0
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36DE280
        public void set_Item(){} // RVA: 0x3729B50
        public void Add(){} // RVA: 0x3729B80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3729BB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3729C00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3729CC0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3729DA0
        public void CopyTo(){} // RVA: 0x36E5800
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x3729E70
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x372A200
        public void TryInsert(){} // RVA: 0x372A380
        public void OnDeserialization(){} // RVA: 0x372A7E0
        public void Resize(){} // RVA: 0x372AD30
        public void Remove(){} // RVA: 0x36E6D20
        public void TryGetValue(){} // RVA: 0x36E6F90
        public void TryAdd(){} // RVA: 0x372AFC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x36E7040
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x372AFF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x372B3C0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x372B4B0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3615600
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x36E06E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x372B560
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x372B720
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
        public void .ctor(){} // RVA: 0x37B7390
        public void get_Comparer(){} // RVA: 0x37B7420
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x37B7440
        public void set_Item(){} // RVA: 0x37B74E0
        public void Add(){} // RVA: 0x37B7510
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x37B7540
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x37B7580
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x37B7640
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x37B7720
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x3673140
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37B7750
        public void FindEntry(){} // RVA: 0x37B7AE0
        public void Initialize(){} // RVA: 0x37B7D50
        public void TryInsert(){} // RVA: 0x37B7ED0
        public void OnDeserialization(){} // RVA: 0x37B83B0
        public void Resize(){} // RVA: 0x37B88E0
        public void Remove(){} // RVA: 0x37B8CD0
        public void TryGetValue(){} // RVA: 0x37B8F10
        public void TryAdd(){} // RVA: 0x37B8FD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3674900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37B9000
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x37B93D0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x37B94C0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3608F10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x37B9570
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x37B9690
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x37B9840
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x37B99F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x36094C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x37B9B00
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
        public void .ctor(){} // RVA: 0x36F4210
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36F42A0
        public void set_Item(){} // RVA: 0x36F4330
        public void Add(){} // RVA: 0x36F4370
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x36F43B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x36F4410
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x36F4500
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36E2230
        public void ContainsValue(){} // RVA: 0x36F4610
        public void CopyTo(){} // RVA: 0x36F4720
        public void GetEnumerator(){} // RVA: 0x361C990
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x361CA40
        public void GetObjectData(){} // RVA: 0x36F48C0
        public void FindEntry(){} // RVA: 0x36E28C0
        public void Initialize(){} // RVA: 0x36F4C50
        public void TryInsert(){} // RVA: 0x36F4DD0
        public void OnDeserialization(){} // RVA: 0x36F5240
        public void Resize(){} // RVA: 0x36F57D0
        public void Remove(){} // RVA: 0x36F5CB0
        public void TryGetValue(){} // RVA: 0x36F5F30
        public void TryAdd(){} // RVA: 0x36F5FB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x36F5FF0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x36F6000
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x361CA40
        public void EnsureCapacity(){} // RVA: 0x36F6400
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x36F64F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x36F65A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x36F6700
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x36F68D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x36E4A60
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x361F360
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x36F6AA0
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
        public void .ctor(){} // RVA: 0x3747C00
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x3747C90
        public void set_Item(){} // RVA: 0x3747D00
        public void Add(){} // RVA: 0x3747D30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3747D60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3747DB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3747E80
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3747F60
        public void CopyTo(){} // RVA: 0x3748050
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37481E0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3748570
        public void TryInsert(){} // RVA: 0x37486F0
        public void OnDeserialization(){} // RVA: 0x3748B50
        public void Resize(){} // RVA: 0x37490A0
        public void Remove(){} // RVA: 0x3749330
        public void TryGetValue(){} // RVA: 0x3724470
        public void TryAdd(){} // RVA: 0x37495B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x37495E0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37495F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3606FD0
        public void EnsureCapacity(){} // RVA: 0x37499E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3749AD0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3749B80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3749CC0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3749E80
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
        public void .ctor(){} // RVA: 0x36E1DF0
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x36E1E80
        public void set_Item(){} // RVA: 0x36E1F10
        public void Add(){} // RVA: 0x36E1F60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x36E1FB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x36E2010
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x36E2110
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36E2230
        public void ContainsValue(){} // RVA: 0x36E2260
        public void CopyTo(){} // RVA: 0x36E2370
        public void GetEnumerator(){} // RVA: 0x361C990
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x361CA40
        public void GetObjectData(){} // RVA: 0x36E2530
        public void FindEntry(){} // RVA: 0x36E28C0
        public void Initialize(){} // RVA: 0x36E2B00
        public void TryInsert(){} // RVA: 0x36E2C80
        public void OnDeserialization(){} // RVA: 0x36E3170
        public void Resize(){} // RVA: 0x36E3700
        public void Remove(){} // RVA: 0x36E3BE0
        public void TryGetValue(){} // RVA: 0x36E3E80
        public void TryAdd(){} // RVA: 0x36E3F50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x36E3FA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x36E3FB0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x361CA40
        public void EnsureCapacity(){} // RVA: 0x36E43C0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x36E44B0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x36E4560
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x36E46C0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x36E4890
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
        public void .ctor(){} // RVA: 0x3699400
        public void get_Comparer(){} // RVA: 0x3691360
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x3699490
        public void set_Item(){} // RVA: 0x3699560
        public void Add(){} // RVA: 0x36995B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3699600
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3699670
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3699790
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x36998C0
        public void ContainsValue(){} // RVA: 0x36998F0
        public void CopyTo(){} // RVA: 0x3699A20
        public void GetEnumerator(){} // RVA: 0x36205E0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3620690
        public void GetObjectData(){} // RVA: 0x3699BB0
        public void FindEntry(){} // RVA: 0x3699F40
        public void Initialize(){} // RVA: 0x369A1A0
        public void TryInsert(){} // RVA: 0x369A320
        public void OnDeserialization(){} // RVA: 0x369A850
        public void Resize(){} // RVA: 0x369ADD0
        public void Remove(){} // RVA: 0x369B1D0
        public void TryGetValue(){} // RVA: 0x369B440
        public void TryAdd(){} // RVA: 0x369B510
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x369B560
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x369B570
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3620690
        public void EnsureCapacity(){} // RVA: 0x369B9D0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x369BAC0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x369BB70
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x369BCC0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x369BE90
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x369C060
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3623170
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x369C170
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
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void set_Item(){} // RVA: 0x373FD00
        public void Clear(){} // RVA: 0x35DA3F0
        public void get_Item(){} // RVA: 0x373AEA0
        public void Remove(){} // RVA: 0x36DFE10
        public void .ctor(){} // RVA: 0x373FC70
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x3606FD0
        public void GetObjectData(){} // RVA: 0x37400F0
        public void FindEntry(){} // RVA: 0x36DEB50
        public void Initialize(){} // RVA: 0x3740490
        public void TryInsert(){} // RVA: 0x3740610
        public void OnDeserialization(){} // RVA: 0x3740A90
        public void Resize(){} // RVA: 0x3740FE0
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
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void set_Item(){} // RVA: 0x373FD00
        public void Remove(){} // RVA: 0x36DFBC0
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void Clear(){} // RVA: 0x35DA3F0
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
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
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void set_Item(){} // RVA: 0x373FD00
        public void Remove(){} // RVA: 0x36DFBC0
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void Clear(){} // RVA: 0x35DA3F0
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
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
        public void .ctor(){} // RVA: 0x360D310
        public void get_Comparer(){} // RVA: 0x360D3A0
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x360D3C0
        public void set_Item(){} // RVA: 0x360D460
        public void Add(){} // RVA: 0x360D490
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x360D4C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x360D510
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x360D5D0
        public void Clear(){} // RVA: 0x35DA3F0
        public void ContainsKey(){} // RVA: 0x360D6B0
        public void ContainsValue(){} // RVA: 0x360D6E0
        public void CopyTo(){} // RVA: 0x360D7A0
        public void GetEnumerator(){} // RVA: 0x360D8C0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x360D950
        public void GetObjectData(){} // RVA: 0x360DA20
        public void FindEntry(){} // RVA: 0x360DDB0
        public void Initialize(){} // RVA: 0x360E010
        public void TryInsert(){} // RVA: 0x360E190
        public void OnDeserialization(){} // RVA: 0x360E610
        public void Resize(){} // RVA: 0x360EB50
        public void Remove(){} // RVA: 0x360EF50
        public void TryGetValue(){} // RVA: 0x360F180
        public void TryAdd(){} // RVA: 0x360F1F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x360F220
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x360F230
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x360D950
        public void EnsureCapacity(){} // RVA: 0x360F610
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x360F700
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x35DCE90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x35DCFB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x360F7B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x360F8F0
        public void IsCompatibleKey(){} // RVA: 0x35DD3B0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x360FAA0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x360FC50
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x360FD60
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x360FE30
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
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void set_Item(){} // RVA: 0x373FD00
        public void Remove(){} // RVA: 0x36DFBC0
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void Clear(){} // RVA: 0x35DA3F0
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
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
        public void GetEnumerator(){} // RVA: 0x3606F40
        public void set_Item(){} // RVA: 0x373FD00
        public void Remove(){} // RVA: 0x36DFBC0
        public void TryGetValue(){} // RVA: 0x36E0090
        public void .ctor(){} // RVA: 0x373FC70
        public void Clear(){} // RVA: 0x35DA3F0
        public void get_Comparer(){} // RVA: 0x36DE260
        public void get_Count(){} // RVA: 0x35D9E70
        public void get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x35D9E80
        public void get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x35D9F90
        public void get_Item(){} // RVA: 0x373AEA0
        public void Add(){} // RVA: 0x373FD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x373FD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x373FDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x373FE70
        public void ContainsKey(){} // RVA: 0x36DE540
        public void ContainsValue(){} // RVA: 0x3606CD0
        public void CopyTo(){} // RVA: 0x373FF50
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

}