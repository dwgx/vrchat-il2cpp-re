// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Generic
// Classes: 100
// Methods: 5684

namespace ThirdParty.DotNet.System.Collections.Generic
{
    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,UnityEngine.AnimatorControllerParameter>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,UnityEngine.AnimatorControllerParameter> _keys; // 0x38
        public ValueCollection<int,UnityEngine.AnimatorControllerParameter> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C5AA60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C57A00
        public void set_Item(){} // RVA: 0x2C5AAF0
        public void Add(){} // RVA: 0x2C5AB20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C5AB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C5AB90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C5AC50
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C57CE0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C5AE80
        public void FindEntry(){} // RVA: 0x2C58250
        public void Initialize(){} // RVA: 0x2C5B1D0
        public void TryInsert(){} // RVA: 0x2C5B350
        public void OnDeserialization(){} // RVA: 0x2C5B830
        public void Resize(){} // RVA: 0x2C5BD50 | overloaded x2
        public void Remove(){} // RVA: 0x2C5C130 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C5C360
        public void TryAdd(){} // RVA: 0x2C5C420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C5C460
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C5C800
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C5C8F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C5C9A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C5CAC0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C5CC80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C5A090
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C5CE40
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,VRC.Core.ApiAvatar>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,VRC.Core.ApiAvatar> _keys; // 0x38
        public ValueCollection<string,VRC.Core.ApiAvatar> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<0x657CA5C0,string>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x657CA5C0> _comparer; // 0x30
        public KeyCollection<0x657CA5C0,string> _keys; // 0x38
        public ValueCollection<0x657CA5C0,string> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C83520 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C780B0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C835B0
        public void set_Item(){} // RVA: 0x2C83650
        public void Add(){} // RVA: 0x2C83680
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C836B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C836F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C837B0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C83890
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C838C0
        public void FindEntry(){} // RVA: 0x2C83C10
        public void Initialize(){} // RVA: 0x2C83E70
        public void TryInsert(){} // RVA: 0x2C83FF0
        public void OnDeserialization(){} // RVA: 0x2C844D0
        public void Resize(){} // RVA: 0x2C849F0 | overloaded x2
        public void Remove(){} // RVA: 0x2C84DD0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C85000
        public void TryAdd(){} // RVA: 0x2C850C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C850F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C85490
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C85580
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C85630
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C85750
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C85910
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C85AD0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C85BE0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,System.Collections.Generic.List`1<uint>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Collections.Generic.List`1<uint>> _keys; // 0x38
        public ValueCollection<string,System.Collections.Generic.List`1<uint>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.ValueTuple`2<string,string>,string>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.ValueTuple`2<string,string>> _comparer; // 0x30
        public KeyCollection<System.ValueTuple`2<string,string>,string> _keys; // 0x38
        public ValueCollection<System.ValueTuple`2<string,string>,string> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2BFEFC0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2BFF050
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2BFF070
        public void set_Item(){} // RVA: 0x2BFF120
        public void Add(){} // RVA: 0x2BFF160
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2BFF1A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2BFF1F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2BFF2C0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2BFF3B0
        public void ContainsValue(){} // RVA: 0x2BED020
        public void CopyTo(){} // RVA: 0x2BF7D70
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2BFF3F0
        public void FindEntry(){} // RVA: 0x2BFF740
        public void Initialize(){} // RVA: 0x2BFFA00
        public void TryInsert(){} // RVA: 0x2BFFB80
        public void OnDeserialization(){} // RVA: 0x2C00190
        public void Resize(){} // RVA: 0x2C006C0 | overloaded x2
        public void Remove(){} // RVA: 0x2C00B70 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C00E40
        public void TryAdd(){} // RVA: 0x2C00F00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2BF9A20
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C00F40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2C01300
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C013F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C014A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C015C0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C01790
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C01960
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C01A80
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ÏÎÎÌÎÍÍÍÍÍÍÎÌÍÌÍÍÍÏÎÏÌÌ,ÍÌÍÎÏÎÎÎÍÏÌÍÏÍÏÏÌÏÎÏÌÍÏ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÏÎÎÌÎÍÍÍÍÍÍÎÌÍÌÍÍÍÏÎÏÌÌ> _comparer; // 0x30
        public KeyCollection<ÏÎÎÌÎÍÍÍÍÍÍÎÌÍÌÍÍÍÏÎÏÌÌ,ÍÌÍÎÏÎÎÎÍÏÌÍÏÍÏÏÌÏÎÏÌÍÏ> _keys; // 0x38
        public ValueCollection<ÏÎÎÌÎÍÍÍÍÍÍÎÌÍÌÍÍÍÏÎÏÌÌ,ÍÌÍÎÏÎÎÎÍÏÌÍÏÍÏÏÌÏÎÏÌÍÏ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.Transform,UnityEngine.Transform>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Transform> _comparer; // 0x30
        public KeyCollection<UnityEngine.Transform,UnityEngine.Transform> _keys; // 0x38
        public ValueCollection<UnityEngine.Transform,UnityEngine.Transform> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.Transform,HeadChopData>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Transform> _comparer; // 0x30
        public KeyCollection<UnityEngine.Transform,HeadChopData> _keys; // 0x38
        public ValueCollection<UnityEngine.Transform,HeadChopData> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D8E380 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CF3BD0
        public void set_Item(){} // RVA: 0x2D8E410
        public void Add(){} // RVA: 0x2D8E460
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D8E4B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D8E520
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D8E640
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CF3FD0
        public void ContainsValue(){} // RVA: 0x2D8E770
        public void CopyTo(){} // RVA: 0x2D8E8A0
        public void GetEnumerator(){} // RVA: 0x2C26A50
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C26B00
        public void GetObjectData(){} // RVA: 0x2D8EA40
        public void FindEntry(){} // RVA: 0x2CF4630
        public void Initialize(){} // RVA: 0x2D8ED90
        public void TryInsert(){} // RVA: 0x2D8EF10
        public void OnDeserialization(){} // RVA: 0x2D8F3C0
        public void Resize(){} // RVA: 0x2D8F940 | overloaded x2
        public void Remove(){} // RVA: 0x2D8FE10 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2D900A0
        public void TryAdd(){} // RVA: 0x2D90130
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D90180
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D90190
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C26B00
        public void EnsureCapacity(){} // RVA: 0x2D905B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D906A0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CF6310
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D90750
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D90940
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CF6850
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C29540
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2D90B30
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,TMPro.TMP_Style>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,TMPro.TMP_Style> _keys; // 0x38
        public ValueCollection<int,TMPro.TMP_Style> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C5AA60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C57A00
        public void set_Item(){} // RVA: 0x2C5AAF0
        public void Add(){} // RVA: 0x2C5AB20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C5AB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C5AB90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C5AC50
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C57CE0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C5AE80
        public void FindEntry(){} // RVA: 0x2C58250
        public void Initialize(){} // RVA: 0x2C5B1D0
        public void TryInsert(){} // RVA: 0x2C5B350
        public void OnDeserialization(){} // RVA: 0x2C5B830
        public void Resize(){} // RVA: 0x2C5BD50 | overloaded x2
        public void Remove(){} // RVA: 0x2C5C130 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C5C360
        public void TryAdd(){} // RVA: 0x2C5C420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C5C460
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C5C800
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C5C8F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C5C9A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C5CAC0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C5CC80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C5A090
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C5CE40
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,bool>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,bool> _keys; // 0x38
        public ValueCollection<int,bool> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C46D80 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C46E10
        public void set_Item(){} // RVA: 0x2C46EB0
        public void Add(){} // RVA: 0x2C46EE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C46F10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C46F60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C47020
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C40910
        public void ContainsValue(){} // RVA: 0x2C47100
        public void CopyTo(){} // RVA: 0x2C471D0
        public void GetEnumerator(){} // RVA: 0x2C09520
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C095B0
        public void GetObjectData(){} // RVA: 0x2C472D0
        public void FindEntry(){} // RVA: 0x2C40E70
        public void Initialize(){} // RVA: 0x2C47620
        public void TryInsert(){} // RVA: 0x2C477A0
        public void OnDeserialization(){} // RVA: 0x2C47C10
        public void Resize(){} // RVA: 0x2C48120 | overloaded x2
        public void Remove(){} // RVA: 0x2C48310 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C48520
        public void TryAdd(){} // RVA: 0x2C48590
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C485C0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C485D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C095B0
        public void EnsureCapacity(){} // RVA: 0x2C489B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C48AA0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C48B50
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C48C90
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C48E50
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C42CB0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0B950
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C42DC0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ÍÎÎÏÏÌÏÏÍÏÎÎÍÌÏÌÌÌÍÌÍÍÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÍÎÎÏÏÌÏÏÍÏÎÎÍÌÏÌÌÌÍÌÍÍÌ> _keys; // 0x38
        public ValueCollection<string,ÍÎÎÏÏÌÏÏÍÏÎÎÍÌÏÌÌÌÍÌÍÍÌ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D99F70 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D956F0
        public void set_Item(){} // RVA: 0x2D9A000
        public void Add(){} // RVA: 0x2D9A080
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D9A100
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D9A190
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D9A310
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2D95C60
        public void ContainsValue(){} // RVA: 0x2D9A4B0
        public void CopyTo(){} // RVA: 0x2D95E20
        public void GetEnumerator(){} // RVA: 0x2D96060
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2D96120
        public void GetObjectData(){} // RVA: 0x2D9A640
        public void FindEntry(){} // RVA: 0x2D965A0
        public void Initialize(){} // RVA: 0x2D9A990
        public void TryInsert(){} // RVA: 0x2D9AB10
        public void OnDeserialization(){} // RVA: 0x2D9B060
        public void Resize(){} // RVA: 0x2D9B600 | overloaded x2
        public void Remove(){} // RVA: 0x2D97950 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2D97C50
        public void TryAdd(){} // RVA: 0x2D9B880
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D97DF0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D9B900
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2D96120
        public void EnsureCapacity(){} // RVA: 0x2D9BE00
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D9BEF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D984A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D9BFA0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D9C1D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2D98AC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2D98BE0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2D98D10
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.Guid,Mediapipe.Unity.Experimental.TextureFrame>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Guid> _comparer; // 0x30
        public KeyCollection<System.Guid,Mediapipe.Unity.Experimental.TextureFrame> _keys; // 0x38
        public ValueCollection<System.Guid,Mediapipe.Unity.Experimental.TextureFrame> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C30E80 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C2D7C0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C30F10
        public void set_Item(){} // RVA: 0x2C30FC0
        public void Add(){} // RVA: 0x2C31000
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C31040
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C31090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C31160
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C31250
        public void ContainsValue(){} // RVA: 0x2BED020
        public void CopyTo(){} // RVA: 0x2C31290
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2C313E0
        public void FindEntry(){} // RVA: 0x2C31730
        public void Initialize(){} // RVA: 0x2C319F0
        public void TryInsert(){} // RVA: 0x2C31B70
        public void OnDeserialization(){} // RVA: 0x2C32130
        public void Resize(){} // RVA: 0x2C32660 | overloaded x2
        public void Remove(){} // RVA: 0x2C32B00 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C32DC0
        public void TryAdd(){} // RVA: 0x2C32E80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C32EC0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C32ED0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2C33290
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C33380
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C33430
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C33550
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C33720
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C338F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C33A10
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,UnityEngine.Transform>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,UnityEngine.Transform> _keys; // 0x38
        public ValueCollection<string,UnityEngine.Transform> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<0x65715E98,float>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x65715E98> _comparer; // 0x30
        public KeyCollection<0x65715E98,float> _keys; // 0x38
        public ValueCollection<0x65715E98,float> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CAAB70 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C780B0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CAAC00
        public void set_Item(){} // RVA: 0x2CAACA0
        public void Add(){} // RVA: 0x2CAACD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CAAD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CAAD50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CAAE10
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C783C0
        public void ContainsValue(){} // RVA: 0x2C628D0
        public void CopyTo(){} // RVA: 0x2C629B0
        public void GetEnumerator(){} // RVA: 0x2C09520
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C095B0
        public void GetObjectData(){} // RVA: 0x2CAAEF0
        public void FindEntry(){} // RVA: 0x2C78740
        public void Initialize(){} // RVA: 0x2CAB240
        public void TryInsert(){} // RVA: 0x2CAB3C0
        public void OnDeserialization(){} // RVA: 0x2CAB820
        public void Resize(){} // RVA: 0x2CABD30 | overloaded x2
        public void Remove(){} // RVA: 0x2C7C6B0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C7C8C0
        public void TryAdd(){} // RVA: 0x2CABF20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C63AF0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CABF50
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C095B0
        public void EnsureCapacity(){} // RVA: 0x2CAC330
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CAC420
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CAC4D0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CAC610
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CAC7D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C7A570
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0B950
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C7A680
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ItemAttribute>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ItemAttribute> _keys; // 0x38
        public ValueCollection<string,ItemAttribute> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,System.Collections.Generic.List`1<ÏÌÎÌÌÌÎÍÌÎÎÌÍÍÌÎÍÎÎÏÎÌÏ>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Collections.Generic.List`1<ÏÌÎÌÌÌÎÍÌÎÎÌÍÍÌÎÍÎÎÏÎÌÏ>> _keys; // 0x38
        public ValueCollection<string,System.Collections.Generic.List`1<ÏÌÎÌÌÌÎÍÌÎÎÌÍÍÌÎÍÎÎÏÎÌÏ>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.GameObject,VRC.SDKBase.Network.NetworkIDPair>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.GameObject> _comparer; // 0x30
        public KeyCollection<UnityEngine.GameObject,VRC.SDKBase.Network.NetworkIDPair> _keys; // 0x38
        public ValueCollection<UnityEngine.GameObject,VRC.SDKBase.Network.NetworkIDPair> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<0x65A0B318,System.Type>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x65A0B318> _comparer; // 0x30
        public KeyCollection<0x65A0B318,System.Type> _keys; // 0x38
        public ValueCollection<0x65A0B318,System.Type> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C83520 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C780B0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C835B0
        public void set_Item(){} // RVA: 0x2C83650
        public void Add(){} // RVA: 0x2C83680
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C836B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C836F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C837B0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C83890
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C838C0
        public void FindEntry(){} // RVA: 0x2C83C10
        public void Initialize(){} // RVA: 0x2C83E70
        public void TryInsert(){} // RVA: 0x2C83FF0
        public void OnDeserialization(){} // RVA: 0x2C844D0
        public void Resize(){} // RVA: 0x2C849F0 | overloaded x2
        public void Remove(){} // RVA: 0x2C84DD0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C85000
        public void TryAdd(){} // RVA: 0x2C850C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C850F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C85490
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C85580
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C85630
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C85750
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C85910
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C85AD0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C85BE0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,System.Collections.Generic.List`1<T>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,System.Collections.Generic.List`1<T>> _keys; // 0x38
        public ValueCollection<int,System.Collections.Generic.List`1<T>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C5AA60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C57A00
        public void set_Item(){} // RVA: 0x2C5AAF0
        public void Add(){} // RVA: 0x2C5AB20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C5AB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C5AB90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C5AC50
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C57CE0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C5AE80
        public void FindEntry(){} // RVA: 0x2C58250
        public void Initialize(){} // RVA: 0x2C5B1D0
        public void TryInsert(){} // RVA: 0x2C5B350
        public void OnDeserialization(){} // RVA: 0x2C5B830
        public void Resize(){} // RVA: 0x2C5BD50 | overloaded x2
        public void Remove(){} // RVA: 0x2C5C130 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C5C360
        public void TryAdd(){} // RVA: 0x2C5C420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C5C460
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C5C800
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C5C8F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C5C9A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C5CAC0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C5CC80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C5A090
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C5CE40
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,VRC.Core.Networking.FlatBuffers.FlatBuffers32.WorldMetadataT>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,VRC.Core.Networking.FlatBuffers.FlatBuffers32.WorldMetadataT> _keys; // 0x38
        public ValueCollection<string,VRC.Core.Networking.FlatBuffers.FlatBuffers32.WorldMetadataT> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,VRC.Core.Networking.FlatBuffers.FlatBuffers32.ObjectMetadataPairT>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,VRC.Core.Networking.FlatBuffers.FlatBuffers32.ObjectMetadataPairT> _keys; // 0x38
        public ValueCollection<int,VRC.Core.Networking.FlatBuffers.FlatBuffers32.ObjectMetadataPairT> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C5AA60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C57A00
        public void set_Item(){} // RVA: 0x2C5AAF0
        public void Add(){} // RVA: 0x2C5AB20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C5AB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C5AB90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C5AC50
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C57CE0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C5AE80
        public void FindEntry(){} // RVA: 0x2C58250
        public void Initialize(){} // RVA: 0x2C5B1D0
        public void TryInsert(){} // RVA: 0x2C5B350
        public void OnDeserialization(){} // RVA: 0x2C5B830
        public void Resize(){} // RVA: 0x2C5BD50 | overloaded x2
        public void Remove(){} // RVA: 0x2C5C130 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C5C360
        public void TryAdd(){} // RVA: 0x2C5C420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C5C460
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C5C800
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C5C8F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C5C9A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C5CAC0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C5CC80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C5A090
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C5CE40
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,ÏÏÌÏÎÍÍÎÏÏÏÏÌÌÌÎÍÍÏÎÌÌÍ<bool>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,ÏÏÌÏÎÍÍÎÏÏÏÏÌÌÌÎÍÍÏÎÌÌÍ<bool>> _keys; // 0x38
        public ValueCollection<int,ÏÏÌÏÎÍÍÎÏÏÏÏÌÌÌÎÍÍÏÎÌÌÍ<bool>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C5AA60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C57A00
        public void set_Item(){} // RVA: 0x2C5AAF0
        public void Add(){} // RVA: 0x2C5AB20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C5AB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C5AB90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C5AC50
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C57CE0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C5AE80
        public void FindEntry(){} // RVA: 0x2C58250
        public void Initialize(){} // RVA: 0x2C5B1D0
        public void TryInsert(){} // RVA: 0x2C5B350
        public void OnDeserialization(){} // RVA: 0x2C5B830
        public void Resize(){} // RVA: 0x2C5BD50 | overloaded x2
        public void Remove(){} // RVA: 0x2C5C130 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C5C360
        public void TryAdd(){} // RVA: 0x2C5C420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C5C460
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C5C800
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C5C8F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C5C9A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C5CAC0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C5CC80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C5A090
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C5CE40
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.Threading.Thread,System.Diagnostics.StackTrace>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Threading.Thread> _comparer; // 0x30
        public KeyCollection<System.Threading.Thread,System.Diagnostics.StackTrace> _keys; // 0x38
        public ValueCollection<System.Threading.Thread,System.Diagnostics.StackTrace> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<BlobHandles.BlobHandle,OscCore.OscActionPair>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<BlobHandles.BlobHandle> _comparer; // 0x30
        public KeyCollection<BlobHandles.BlobHandle,OscCore.OscActionPair> _keys; // 0x38
        public ValueCollection<BlobHandles.BlobHandle,OscCore.OscActionPair> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C05A80 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C05B10
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C05B30
        public void set_Item(){} // RVA: 0x2C05BE0
        public void Add(){} // RVA: 0x2C05C20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C05C60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C05CB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C05D80
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C05E70
        public void ContainsValue(){} // RVA: 0x2BED020
        public void CopyTo(){} // RVA: 0x2C05EB0
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2C06010
        public void FindEntry(){} // RVA: 0x2C06360
        public void Initialize(){} // RVA: 0x2C06620
        public void TryInsert(){} // RVA: 0x2C067A0
        public void OnDeserialization(){} // RVA: 0x2C06CE0
        public void Resize(){} // RVA: 0x2C07210 | overloaded x2
        public void Remove(){} // RVA: 0x2C076B0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C07970
        public void TryAdd(){} // RVA: 0x2C07A30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C07A70
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C07A80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2C07E40
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C07F30
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C07FE0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C08100
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C082D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C084A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C085C0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,BlobHandles.BlobString>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,BlobHandles.BlobString> _keys; // 0x38
        public ValueCollection<string,BlobHandles.BlobString> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CFCDF0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CFCE80
        public void set_Item(){} // RVA: 0x2CFCF10
        public void Add(){} // RVA: 0x2CFCF50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CFCF90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CFCFF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CFD0F0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CFD210
        public void ContainsValue(){} // RVA: 0x2CFD240
        public void CopyTo(){} // RVA: 0x2CFD360
        public void GetEnumerator(){} // RVA: 0x2C74EE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C74F90
        public void GetObjectData(){} // RVA: 0x2CFD4F0
        public void FindEntry(){} // RVA: 0x2CFD840
        public void Initialize(){} // RVA: 0x2CFDA90
        public void TryInsert(){} // RVA: 0x2CFDC10
        public void OnDeserialization(){} // RVA: 0x2CFE080
        public void Resize(){} // RVA: 0x2CFE5F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CFEAE0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CFED60
        public void TryAdd(){} // RVA: 0x2CFEDF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CFEE30
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CFEE40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C74F90
        public void EnsureCapacity(){} // RVA: 0x2CFF250
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CFF340
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CFF3F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CFF550
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CFF740
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CFF930
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C77580
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CFFA50
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,VRC.OSCQuery.OSCQueryNode>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,VRC.OSCQuery.OSCQueryNode> _keys; // 0x38
        public ValueCollection<string,VRC.OSCQuery.OSCQueryNode> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<VRC.OSCQuery.OSCQueryServiceProfile,OscCore.OscClient>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.OSCQuery.OSCQueryServiceProfile> _comparer; // 0x30
        public KeyCollection<VRC.OSCQuery.OSCQueryServiceProfile,OscCore.OscClient> _keys; // 0x38
        public ValueCollection<VRC.OSCQuery.OSCQueryServiceProfile,OscCore.OscClient> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.MeshFilter,UnityEngine.Color>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.MeshFilter> _comparer; // 0x30
        public KeyCollection<UnityEngine.MeshFilter,UnityEngine.Color> _keys; // 0x38
        public ValueCollection<UnityEngine.MeshFilter,UnityEngine.Color> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D07DD0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CEB7D0
        public void set_Item(){} // RVA: 0x2D07E60
        public void Add(){} // RVA: 0x2D07EA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D07EE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D07F30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D08010
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CEBB00
        public void ContainsValue(){} // RVA: 0x2D08110
        public void CopyTo(){} // RVA: 0x2D08200
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2D08350
        public void FindEntry(){} // RVA: 0x2CEC0D0
        public void Initialize(){} // RVA: 0x2D086A0
        public void TryInsert(){} // RVA: 0x2D08820
        public void OnDeserialization(){} // RVA: 0x2D08C70
        public void Resize(){} // RVA: 0x2D091C0 | overloaded x2
        public void Remove(){} // RVA: 0x2D096A0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2D09910
        public void TryAdd(){} // RVA: 0x2D09990
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D099D0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D099E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2D09DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D09EA0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CEDCA0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D09F50
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D0A130
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CEE1B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2D0A310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<0x659C0BA8,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x659C0BA8> _comparer; // 0x30
        public KeyCollection<0x659C0BA8,int> _keys; // 0x38
        public ValueCollection<0x659C0BA8,int> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C7B2F0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C780B0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C7B380
        public void set_Item(){} // RVA: 0x2C7B420
        public void Add(){} // RVA: 0x2C7B450
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C7B480
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C7B4D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C7B590
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C783C0
        public void ContainsValue(){} // RVA: 0x2C09340
        public void CopyTo(){} // RVA: 0x2C52F40
        public void GetEnumerator(){} // RVA: 0x2C09520
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C095B0
        public void GetObjectData(){} // RVA: 0x2C7B670
        public void FindEntry(){} // RVA: 0x2C78740
        public void Initialize(){} // RVA: 0x2C7B9C0
        public void TryInsert(){} // RVA: 0x2C7BB40
        public void OnDeserialization(){} // RVA: 0x2C7BFB0
        public void Resize(){} // RVA: 0x2C7C4C0 | overloaded x2
        public void Remove(){} // RVA: 0x2C7C6B0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C7C8C0
        public void TryAdd(){} // RVA: 0x2C7C930
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C54310
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C7C960
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C095B0
        public void EnsureCapacity(){} // RVA: 0x2C7CD20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C7CE10
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C7CEC0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C7D000
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C7D1B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C7A570
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0B950
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C7A680
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ÍÎÍÌÍÏÍÌÏÏÌÌÌÎÌÎÎÍÌÍÌÌÎ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÍÎÍÌÍÏÍÌÏÏÌÌÌÎÌÎÎÍÌÍÌÌÎ> _keys; // 0x38
        public ValueCollection<string,ÍÎÍÌÍÏÍÌÏÏÌÌÌÎÌÎÎÍÌÍÌÌÎ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D95660 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D956F0
        public void set_Item(){} // RVA: 0x2D957B0
        public void Add(){} // RVA: 0x2D95830
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D958B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D95940
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D95AC0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2D95C60
        public void ContainsValue(){} // RVA: 0x2D95C90
        public void CopyTo(){} // RVA: 0x2D95E20
        public void GetEnumerator(){} // RVA: 0x2D96060
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2D96120
        public void GetObjectData(){} // RVA: 0x2D96250
        public void FindEntry(){} // RVA: 0x2D965A0
        public void Initialize(){} // RVA: 0x2D967E0
        public void TryInsert(){} // RVA: 0x2D96960
        public void OnDeserialization(){} // RVA: 0x2D96EB0
        public void Resize(){} // RVA: 0x2D97450 | overloaded x2
        public void Remove(){} // RVA: 0x2D97950 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2D97C50
        public void TryAdd(){} // RVA: 0x2D97D70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D97DF0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D97E00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2D96120
        public void EnsureCapacity(){} // RVA: 0x2D98300
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D983F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D984A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D98660
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D98890
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2D98AC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2D98BE0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2D98D10
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ÌÎÎÎÎÍÎÌÌÌÏÍÍÏÍÎÍÏÎÌÍÍÎ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÌÎÎÎÎÍÎÌÌÌÏÍÍÏÍÎÍÏÎÌÍÍÎ> _keys; // 0x38
        public ValueCollection<string,ÌÎÎÎÎÍÎÌÌÌÏÍÍÏÍÎÍÏÎÌÍÍÎ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D915D0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D91660
        public void set_Item(){} // RVA: 0x2D91720
        public void Add(){} // RVA: 0x2D917A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D91820
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D918B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D91A30
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2D91BD0
        public void ContainsValue(){} // RVA: 0x2D91C00
        public void CopyTo(){} // RVA: 0x2D91D90
        public void GetEnumerator(){} // RVA: 0x2D91F80
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2D91FD0
        public void GetObjectData(){} // RVA: 0x2D92110
        public void FindEntry(){} // RVA: 0x2D92460
        public void Initialize(){} // RVA: 0x2D926A0
        public void TryInsert(){} // RVA: 0x2D92820
        public void OnDeserialization(){} // RVA: 0x2D92D70
        public void Resize(){} // RVA: 0x2D93310 | overloaded x2
        public void Remove(){} // RVA: 0x2D93800 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2D93B00
        public void TryAdd(){} // RVA: 0x2D93C20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D93CA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D93CB0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2D91FD0
        public void EnsureCapacity(){} // RVA: 0x2D941D0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D942C0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D94370
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D94520
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D94750
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2D94980
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2D94AA0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2D94BE0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,System.Collections.Generic.List`1<VRC.Core.ApiModeration>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Collections.Generic.List`1<VRC.Core.ApiModeration>> _keys; // 0x38
        public ValueCollection<string,System.Collections.Generic.List`1<VRC.Core.ApiModeration>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,System.Collections.Generic.List`1<VRC.Core.ApiPlayerModeration>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Collections.Generic.List`1<VRC.Core.ApiPlayerModeration>> _keys; // 0x38
        public ValueCollection<string,System.Collections.Generic.List`1<VRC.Core.ApiPlayerModeration>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,System.Collections.Generic.List`1<VRC.Core.ApiAvatarModeration>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Collections.Generic.List`1<VRC.Core.ApiAvatarModeration>> _keys; // 0x38
        public ValueCollection<string,System.Collections.Generic.List`1<VRC.Core.ApiAvatarModeration>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,System.ValueTuple`2<bool,bool>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,System.ValueTuple`2<bool,bool>> _keys; // 0x38
        public ValueCollection<int,System.ValueTuple`2<bool,bool>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C40590 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C40620
        public void set_Item(){} // RVA: 0x2C406C0
        public void Add(){} // RVA: 0x2C406F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C40720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C40770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C40830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C40910
        public void ContainsValue(){} // RVA: 0x2C40940
        public void CopyTo(){} // RVA: 0x2C40A20
        public void GetEnumerator(){} // RVA: 0x2C09520
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C095B0
        public void GetObjectData(){} // RVA: 0x2C40B20
        public void FindEntry(){} // RVA: 0x2C40E70
        public void Initialize(){} // RVA: 0x2C410D0
        public void TryInsert(){} // RVA: 0x2C41250
        public void OnDeserialization(){} // RVA: 0x2C416C0
        public void Resize(){} // RVA: 0x2C41BD0 | overloaded x2
        public void Remove(){} // RVA: 0x2C41FB0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C421C0
        public void TryAdd(){} // RVA: 0x2C42230
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C42260
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C42270
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C095B0
        public void EnsureCapacity(){} // RVA: 0x2C42650
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C42740
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C427F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C42930
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C42AF0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C42CB0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0B950
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C42DC0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<short,ÌÍÍÌÍÍÍÎÌÍÎÎÏÌÌÌÏÏÏÏÌÏÏ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<short> _comparer; // 0x30
        public KeyCollection<short,ÌÍÍÌÍÍÍÎÌÍÎÎÏÌÌÌÏÏÏÏÌÏÏ> _keys; // 0x38
        public ValueCollection<short,ÌÍÍÌÍÍÍÎÌÍÎÎÏÌÌÌÏÏÏÏÌÏÏ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C34550 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C345E0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C34600
        public void set_Item(){} // RVA: 0x2C346A0
        public void Add(){} // RVA: 0x2C346D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C34700
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C34750
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C34810
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C348F0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C34920
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C34A70
        public void FindEntry(){} // RVA: 0x2C34DC0
        public void Initialize(){} // RVA: 0x2C35040
        public void TryInsert(){} // RVA: 0x2C351C0
        public void OnDeserialization(){} // RVA: 0x2C356B0
        public void Resize(){} // RVA: 0x2C35BD0 | overloaded x2
        public void Remove(){} // RVA: 0x2C35FC0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C361F0
        public void TryAdd(){} // RVA: 0x2C362B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C362E0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C362F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C36690
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C36780
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C36830
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C36950
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C36B10
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C36CD0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C36DE0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ÌÍÍÌÍÍÍÎÌÍÎÎÏÌÌÌÏÏÏÏÌÏÏ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÌÍÍÌÍÍÍÎÌÍÎÎÏÌÌÌÏÏÏÏÌÏÏ> _keys; // 0x38
        public ValueCollection<string,ÌÍÍÌÍÍÍÎÌÍÎÎÏÌÌÌÏÏÏÏÌÏÏ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,System.Collections.Generic.Dictionary`2<ÌÍÍÌÍÍÍÎÌÍÎÎÏÌÌÌÏÏÏÏÌÏÏ,float>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,System.Collections.Generic.Dictionary`2<ÌÍÍÌÍÍÍÎÌÍÎÎÏÌÌÌÏÏÏÏÌÏÏ,float>> _keys; // 0x38
        public ValueCollection<int,System.Collections.Generic.Dictionary`2<ÌÍÍÌÍÍÍÎÌÍÎÎÏÌÌÌÏÏÏÏÌÏÏ,float>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C5AA60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C57A00
        public void set_Item(){} // RVA: 0x2C5AAF0
        public void Add(){} // RVA: 0x2C5AB20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C5AB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C5AB90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C5AC50
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C57CE0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C5AE80
        public void FindEntry(){} // RVA: 0x2C58250
        public void Initialize(){} // RVA: 0x2C5B1D0
        public void TryInsert(){} // RVA: 0x2C5B350
        public void OnDeserialization(){} // RVA: 0x2C5B830
        public void Resize(){} // RVA: 0x2C5BD50 | overloaded x2
        public void Remove(){} // RVA: 0x2C5C130 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C5C360
        public void TryAdd(){} // RVA: 0x2C5C420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C5C460
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C5C800
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C5C8F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C5C9A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C5CAC0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C5CC80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C5A090
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C5CE40
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ÌÍÍÌÍÍÍÎÌÍÎÎÏÌÌÌÏÏÏÏÌÏÏ,float>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÌÍÍÌÍÍÍÎÌÍÎÎÏÌÌÌÏÏÏÏÌÏÏ> _comparer; // 0x30
        public KeyCollection<ÌÍÍÌÍÍÍÎÌÍÎÎÏÌÌÌÏÏÏÏÌÏÏ,float> _keys; // 0x38
        public ValueCollection<ÌÍÍÌÍÍÍÎÌÍÎÎÏÌÌÌÏÏÏÏÌÏÏ,float> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ÍÍÎÍÎÎÍÏÏÌÎÏÎÎÍÎÌÌÌÍÎÍÏ<System.Collections.Generic.List`1<ÎÎÎÌÌÌÌÍÏÏÏÎÏÎÎÎÍÍÌÏÍÏÏ>>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÍÍÎÍÎÎÍÏÏÌÎÏÎÎÍÎÌÌÌÍÎÍÏ<System.Collections.Generic.List`1<ÎÎÎÌÌÌÌÍÏÏÏÎÏÎÎÎÍÍÌÏÍÏÏ>>> _keys; // 0x38
        public ValueCollection<string,ÍÍÎÍÎÎÍÏÏÌÎÏÎÎÍÎÌÌÌÍÎÍÏ<System.Collections.Generic.List`1<ÎÎÎÌÌÌÌÍÏÏÏÎÏÎÎÎÍÍÌÏÍÏÏ>>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ÏÏÌÏÎÏÌÍÌÍÌÍÏÎÌÌÏÎÎÍÍÏÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÏÏÌÏÎÏÌÍÌÍÌÍÏÎÌÌÏÎÎÍÍÏÌ> _keys; // 0x38
        public ValueCollection<string,ÏÏÌÏÎÏÌÍÌÍÌÍÏÎÌÌÏÎÎÍÍÏÌ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ÏÍÌÏÌÌÍÎÌÎÍÍÎÎÏÌÎÍÍÎÍÎÏ,ÌÌÍÍÌÍÏÍÌÏÍÏÏÏÌÍÌÏÎÏÎÍÎ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÏÍÌÏÌÌÍÎÌÎÍÍÎÎÏÌÎÍÍÎÍÎÏ> _comparer; // 0x30
        public KeyCollection<ÏÍÌÏÌÌÍÎÌÎÍÍÎÎÏÌÎÍÍÎÍÎÏ,ÌÌÍÍÌÍÏÍÌÏÍÏÏÏÌÍÌÏÎÏÎÍÎ> _keys; // 0x38
        public ValueCollection<ÏÍÌÏÌÌÍÎÌÎÍÍÎÎÏÌÎÍÍÎÍÎÏ,ÌÌÍÍÌÍÏÍÌÏÍÏÏÏÌÍÌÏÎÏÎÍÎ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E08270 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2E04BB0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2E08300
        public void set_Item(){} // RVA: 0x2E083F0
        public void Add(){} // RVA: 0x2E08450
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2E084B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2E08530
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2E08630
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2E08770
        public void ContainsValue(){} // RVA: 0x2E087B0
        public void CopyTo(){} // RVA: 0x2E088C0
        public void GetEnumerator(){} // RVA: 0x2C26A50
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C26B00
        public void GetObjectData(){} // RVA: 0x2E08A50
        public void FindEntry(){} // RVA: 0x2E08DA0
        public void Initialize(){} // RVA: 0x2E090C0
        public void TryInsert(){} // RVA: 0x2E09240
        public void OnDeserialization(){} // RVA: 0x2E098C0
        public void Resize(){} // RVA: 0x2E09E40 | overloaded x2
        public void Remove(){} // RVA: 0x2E0A2C0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2E0A580
        public void TryAdd(){} // RVA: 0x2E0A660
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2E0A6C0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2E0A6D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C26B00
        public void EnsureCapacity(){} // RVA: 0x2E0AB00
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2E0ABF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2E0ACA0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2E0AE00
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2E0B010
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2E0B220
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C29540
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2E0B350
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ÏÍÌÏÌÌÍÎÌÎÍÍÎÎÏÌÎÍÍÎÍÎÏ,Cysharp.Threading.Tasks.UniTaskCompletionSource`1<ÌÌÍÍÌÍÏÍÌÏÍÏÏÏÌÍÌÏÎÏÎÍÎ>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÏÍÌÏÌÌÍÎÌÎÍÍÎÎÏÌÎÍÍÎÍÎÏ> _comparer; // 0x30
        public KeyCollection<ÏÍÌÏÌÌÍÎÌÎÍÍÎÎÏÌÎÍÍÎÍÎÏ,Cysharp.Threading.Tasks.UniTaskCompletionSource`1<ÌÌÍÍÌÍÏÍÌÏÍÏÏÏÌÍÌÏÎÏÎÍÎ>> _keys; // 0x38
        public ValueCollection<ÏÍÌÏÌÌÍÎÌÎÍÍÎÎÏÌÎÍÍÎÍÎÏ,Cysharp.Threading.Tasks.UniTaskCompletionSource`1<ÌÌÍÍÌÍÏÍÌÏÍÏÏÏÌÍÌÏÎÏÎÍÎ>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E04B20 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2E04BB0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2E04BD0
        public void set_Item(){} // RVA: 0x2E04CA0
        public void Add(){} // RVA: 0x2E04CE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2E04D20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2E04D80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2E04E50
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2E04F70
        public void ContainsValue(){} // RVA: 0x2DB1590
        public void CopyTo(){} // RVA: 0x2E04FB0
        public void GetEnumerator(){} // RVA: 0x2C22F20
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C22FD0
        public void GetObjectData(){} // RVA: 0x2E05140
        public void FindEntry(){} // RVA: 0x2E05490
        public void Initialize(){} // RVA: 0x2E057B0
        public void TryInsert(){} // RVA: 0x2E05930
        public void OnDeserialization(){} // RVA: 0x2E05FB0
        public void Resize(){} // RVA: 0x2E06500 | overloaded x2
        public void Remove(){} // RVA: 0x2E06980 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2E06C20
        public void TryAdd(){} // RVA: 0x2E06CF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2E06D30
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2E06D40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C22FD0
        public void EnsureCapacity(){} // RVA: 0x2E07110
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2E07200
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2E072B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2E073E0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2E075D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2E077C0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C25800
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2E078F0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,UnityEngine.UIElements.Panel>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,UnityEngine.UIElements.Panel> _keys; // 0x38
        public ValueCollection<int,UnityEngine.UIElements.Panel> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C5AA60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C57A00
        public void set_Item(){} // RVA: 0x2C5AAF0
        public void Add(){} // RVA: 0x2C5AB20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C5AB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C5AB90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C5AC50
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C57CE0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C5AE80
        public void FindEntry(){} // RVA: 0x2C58250
        public void Initialize(){} // RVA: 0x2C5B1D0
        public void TryInsert(){} // RVA: 0x2C5B350
        public void OnDeserialization(){} // RVA: 0x2C5B830
        public void Resize(){} // RVA: 0x2C5BD50 | overloaded x2
        public void Remove(){} // RVA: 0x2C5C130 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C5C360
        public void TryAdd(){} // RVA: 0x2C5C420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C5C460
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C5C800
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C5C8F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C5C9A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C5CAC0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C5CC80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C5A090
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C5CE40
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.Transform,bool>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Transform> _comparer; // 0x30
        public KeyCollection<UnityEngine.Transform,bool> _keys; // 0x38
        public ValueCollection<UnityEngine.Transform,bool> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D00310 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D003A0
        public void set_Item(){} // RVA: 0x2D00410
        public void Add(){} // RVA: 0x2D00440
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D00470
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D004C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D00580
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2D00660
        public void CopyTo(){} // RVA: 0x2D00740
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D00890
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D00BE0
        public void TryInsert(){} // RVA: 0x2D00D60
        public void OnDeserialization(){} // RVA: 0x2D011A0
        public void Resize(){} // RVA: 0x2D016E0 | overloaded x2
        public void Remove(){} // RVA: 0x2D01960 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2D01BD0
        public void TryAdd(){} // RVA: 0x2D01C50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D01C80
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D01C90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D02040
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D02130
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D021E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D02320
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D024F0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEAE30
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.GameObject,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.GameObject> _comparer; // 0x30
        public KeyCollection<UnityEngine.GameObject,int> _keys; // 0x38
        public ValueCollection<UnityEngine.GameObject,int> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D19B70 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D19C00
        public void set_Item(){} // RVA: 0x2D19C70
        public void Add(){} // RVA: 0x2D19CA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D19CD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D19D20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D19DE0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2CC4A50
        public void CopyTo(){} // RVA: 0x2D19EC0
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D1A010
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D1A360
        public void TryInsert(){} // RVA: 0x2D1A4E0
        public void OnDeserialization(){} // RVA: 0x2D1A920
        public void Resize(){} // RVA: 0x2D1AE60 | overloaded x2
        public void Remove(){} // RVA: 0x2D0C240 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2D0C4B0
        public void TryAdd(){} // RVA: 0x2D1B0E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D1B110
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D1B120
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D1B4D0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D1B5C0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D0CAB0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D1B670
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D1B840
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEAE30
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,System.Collections.Generic.List`1<string>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Collections.Generic.List`1<string>> _keys; // 0x38
        public ValueCollection<string,System.Collections.Generic.List`1<string>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.Camera,UnityEngine.Rendering.CommandBuffer>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Camera> _comparer; // 0x30
        public KeyCollection<UnityEngine.Camera,UnityEngine.Rendering.CommandBuffer> _keys; // 0x38
        public ValueCollection<UnityEngine.Camera,UnityEngine.Rendering.CommandBuffer> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,System.Collections.Generic.List`1<VRC.Core.ApiModel>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,System.Collections.Generic.List`1<VRC.Core.ApiModel>> _keys; // 0x38
        public ValueCollection<int,System.Collections.Generic.List`1<VRC.Core.ApiModel>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C5AA60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C57A00
        public void set_Item(){} // RVA: 0x2C5AAF0
        public void Add(){} // RVA: 0x2C5AB20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C5AB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C5AB90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C5AC50
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C57CE0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C5AE80
        public void FindEntry(){} // RVA: 0x2C58250
        public void Initialize(){} // RVA: 0x2C5B1D0
        public void TryInsert(){} // RVA: 0x2C5B350
        public void OnDeserialization(){} // RVA: 0x2C5B830
        public void Resize(){} // RVA: 0x2C5BD50 | overloaded x2
        public void Remove(){} // RVA: 0x2C5C130 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C5C360
        public void TryAdd(){} // RVA: 0x2C5C420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C5C460
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C5C800
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C5C8F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C5C9A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C5CAC0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C5CC80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C5A090
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C5CE40
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ÍÎÎÍÎÍÌÎÏÎÎÍÌÎÌÌÍÍÍÎÌÍÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÍÎÎÍÎÍÌÎÏÎÎÍÌÎÌÌÍÍÍÎÌÍÌ> _keys; // 0x38
        public ValueCollection<string,ÍÎÎÍÎÍÌÎÏÎÎÍÌÎÌÌÍÍÍÎÌÍÌ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.Guid,ÎÏÌÏÌÍÎÌÏÍÎÌÎÏÏÎÎÌÍÌÎÌÎ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Guid> _comparer; // 0x30
        public KeyCollection<System.Guid,ÎÏÌÏÌÍÎÌÏÍÎÌÎÏÏÎÎÌÍÌÎÌÎ> _keys; // 0x38
        public ValueCollection<System.Guid,ÎÏÌÏÌÍÎÌÏÍÎÌÎÏÏÎÎÌÍÌÎÌÎ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C30E80 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C2D7C0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C30F10
        public void set_Item(){} // RVA: 0x2C30FC0
        public void Add(){} // RVA: 0x2C31000
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C31040
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C31090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C31160
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C31250
        public void ContainsValue(){} // RVA: 0x2BED020
        public void CopyTo(){} // RVA: 0x2C31290
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2C313E0
        public void FindEntry(){} // RVA: 0x2C31730
        public void Initialize(){} // RVA: 0x2C319F0
        public void TryInsert(){} // RVA: 0x2C31B70
        public void OnDeserialization(){} // RVA: 0x2C32130
        public void Resize(){} // RVA: 0x2C32660 | overloaded x2
        public void Remove(){} // RVA: 0x2C32B00 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C32DC0
        public void TryAdd(){} // RVA: 0x2C32E80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C32EC0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C32ED0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2C33290
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C33380
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C33430
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C33550
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C33720
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C338F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C33A10
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<0x65704148,byte[]>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x65704148> _comparer; // 0x30
        public KeyCollection<0x65704148,byte[]> _keys; // 0x38
        public ValueCollection<0x65704148,byte[]> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C18EF0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C12FF0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C18F80
        public void set_Item(){} // RVA: 0x2C19020
        public void Add(){} // RVA: 0x2C19050
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C19080
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C190D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C19190
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C19270
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C0CBB0
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C192A0
        public void FindEntry(){} // RVA: 0x2C195F0
        public void Initialize(){} // RVA: 0x2C19850
        public void TryInsert(){} // RVA: 0x2C199D0
        public void OnDeserialization(){} // RVA: 0x2C19EC0
        public void Resize(){} // RVA: 0x2C1A3E0 | overloaded x2
        public void Remove(){} // RVA: 0x2C1A7D0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C1AA00
        public void TryAdd(){} // RVA: 0x2C1AAC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C0E6C0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C1AAF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C1AE90
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C1AF80
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C1B050
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C1B170
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C1B330
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C1B4F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C1B600
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,System.Collections.Generic.List`1<ÌÏÎÌÍÏÎÌÍÏÎÍÎÌÏÌÌÌÏÍÌÌÌ>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Collections.Generic.List`1<ÌÏÎÌÍÏÎÌÍÏÎÍÎÌÏÌÌÌÏÍÌÌÌ>> _keys; // 0x38
        public ValueCollection<string,System.Collections.Generic.List`1<ÌÏÎÌÍÏÎÌÍÏÎÍÎÌÏÌÌÌÏÍÌÌÌ>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ÌÏÎÌÍÏÎÌÍÏÎÍÎÌÏÌÌÌÏÍÌÌÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÌÏÎÌÍÏÎÌÍÏÎÍÎÌÏÌÌÌÏÍÌÌÌ> _keys; // 0x38
        public ValueCollection<string,ÌÏÎÌÍÏÎÌÍÏÎÍÎÌÏÌÌÌÏÍÌÌÌ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<0x657CA3B0,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x657CA3B0> _comparer; // 0x30
        public KeyCollection<0x657CA3B0,int> _keys; // 0x38
        public ValueCollection<0x657CA3B0,int> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C7B2F0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C780B0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C7B380
        public void set_Item(){} // RVA: 0x2C7B420
        public void Add(){} // RVA: 0x2C7B450
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C7B480
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C7B4D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C7B590
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C783C0
        public void ContainsValue(){} // RVA: 0x2C09340
        public void CopyTo(){} // RVA: 0x2C52F40
        public void GetEnumerator(){} // RVA: 0x2C09520
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C095B0
        public void GetObjectData(){} // RVA: 0x2C7B670
        public void FindEntry(){} // RVA: 0x2C78740
        public void Initialize(){} // RVA: 0x2C7B9C0
        public void TryInsert(){} // RVA: 0x2C7BB40
        public void OnDeserialization(){} // RVA: 0x2C7BFB0
        public void Resize(){} // RVA: 0x2C7C4C0 | overloaded x2
        public void Remove(){} // RVA: 0x2C7C6B0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C7C8C0
        public void TryAdd(){} // RVA: 0x2C7C930
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C54310
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C7C960
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C095B0
        public void EnsureCapacity(){} // RVA: 0x2C7CD20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C7CE10
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C7CEC0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C7D000
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C7D1B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C7A570
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0B950
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C7A680
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,CacheEntry>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,CacheEntry> _keys; // 0x38
        public ValueCollection<string,CacheEntry> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D49690 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CE54B0
        public void set_Item(){} // RVA: 0x2D49720
        public void Add(){} // RVA: 0x2D49770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D497C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D49820
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D49920
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE5860
        public void ContainsValue(){} // RVA: 0x2D49A40
        public void CopyTo(){} // RVA: 0x2CE59A0
        public void GetEnumerator(){} // RVA: 0x2C22F20
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C22FD0
        public void GetObjectData(){} // RVA: 0x2D49B50
        public void FindEntry(){} // RVA: 0x2CE5E80
        public void Initialize(){} // RVA: 0x2D49EA0
        public void TryInsert(){} // RVA: 0x2D4A020
        public void OnDeserialization(){} // RVA: 0x2D4A4F0
        public void Resize(){} // RVA: 0x2D4AA60 | overloaded x2
        public void Remove(){} // RVA: 0x2CE7160 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE7400
        public void TryAdd(){} // RVA: 0x2D4ACE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CE7520
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D4AD30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C22FD0
        public void EnsureCapacity(){} // RVA: 0x2D4B120
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D4B210
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CE7AC0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D4B2C0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D4B4A0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE7FE0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C25800
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE8100
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,PhysSound.PhysSoundAudioSet>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,PhysSound.PhysSoundAudioSet> _keys; // 0x38
        public ValueCollection<int,PhysSound.PhysSoundAudioSet> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C5AA60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C57A00
        public void set_Item(){} // RVA: 0x2C5AAF0
        public void Add(){} // RVA: 0x2C5AB20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C5AB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C5AB90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C5AC50
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C57CE0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C5AE80
        public void FindEntry(){} // RVA: 0x2C58250
        public void Initialize(){} // RVA: 0x2C5B1D0
        public void TryInsert(){} // RVA: 0x2C5B350
        public void OnDeserialization(){} // RVA: 0x2C5B830
        public void Resize(){} // RVA: 0x2C5BD50 | overloaded x2
        public void Remove(){} // RVA: 0x2C5C130 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C5C360
        public void TryAdd(){} // RVA: 0x2C5C420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C5C460
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C5C800
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C5C8F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C5C9A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C5CAC0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C5CC80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C5A090
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C5CE40
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,PhysSound.PhysSoundAudioContainer>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,PhysSound.PhysSoundAudioContainer> _keys; // 0x38
        public ValueCollection<int,PhysSound.PhysSoundAudioContainer> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C5AA60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C57A00
        public void set_Item(){} // RVA: 0x2C5AAF0
        public void Add(){} // RVA: 0x2C5AB20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C5AB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C5AB90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C5AC50
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C57CE0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C5AE80
        public void FindEntry(){} // RVA: 0x2C58250
        public void Initialize(){} // RVA: 0x2C5B1D0
        public void TryInsert(){} // RVA: 0x2C5B350
        public void OnDeserialization(){} // RVA: 0x2C5B830
        public void Resize(){} // RVA: 0x2C5BD50 | overloaded x2
        public void Remove(){} // RVA: 0x2C5C130 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C5C360
        public void TryAdd(){} // RVA: 0x2C5C420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C5C460
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C5C800
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C5C8F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C5C9A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C5CAC0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C5CC80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C5A090
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C5CE40
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,ÌÍÍÍÏÏÌÎÌÎÍÏÍÎÌÏÌÏÌÏÌÎÏ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,ÌÍÍÍÏÏÌÎÌÎÍÏÍÎÌÏÌÏÌÏÌÎÏ> _keys; // 0x38
        public ValueCollection<int,ÌÍÍÍÏÏÌÎÌÎÍÏÍÎÌÏÌÏÌÏÌÎÏ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C5AA60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C57A00
        public void set_Item(){} // RVA: 0x2C5AAF0
        public void Add(){} // RVA: 0x2C5AB20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C5AB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C5AB90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C5AC50
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C57CE0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C5AE80
        public void FindEntry(){} // RVA: 0x2C58250
        public void Initialize(){} // RVA: 0x2C5B1D0
        public void TryInsert(){} // RVA: 0x2C5B350
        public void OnDeserialization(){} // RVA: 0x2C5B830
        public void Resize(){} // RVA: 0x2C5BD50 | overloaded x2
        public void Remove(){} // RVA: 0x2C5C130 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C5C360
        public void TryAdd(){} // RVA: 0x2C5C420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C5C460
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C5C800
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C5C8F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C5C9A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C5CAC0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C5CC80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C5A090
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C5CE40
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ÌÍÌÌÎÎÌÏÌÍÎÎÎÏÏÏÌÎÏÌÍÌÎ,ÏÏÏÎÍÏÌÌÎÌÌÎÏÎÌÏÌÌÍÍÍÍÍ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÌÍÌÌÎÎÌÏÌÍÎÎÎÏÏÏÌÎÏÌÍÌÎ> _comparer; // 0x30
        public KeyCollection<ÌÍÌÌÎÎÌÏÌÍÎÎÎÏÏÏÌÎÏÌÍÌÎ,ÏÏÏÎÍÏÌÌÎÌÌÎÏÎÌÏÌÌÍÍÍÍÍ> _keys; // 0x38
        public ValueCollection<ÌÍÌÌÎÎÌÏÌÍÎÎÎÏÏÏÌÎÏÌÍÌÎ,ÏÏÏÎÍÏÌÌÎÌÌÎÏÎÌÏÌÌÍÍÍÍÍ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ÏÏÎÍÎÎÍÎÌÌÍÍÎÍÍÏÏÎÍÌÏÎÌ,ÏÌÌÎÍÏÏÏÎÎÎÏÏÌÏÌÏÌÎÌÍÌÎ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÏÏÎÍÎÎÍÎÌÌÍÍÎÍÍÏÏÎÍÌÏÎÌ> _comparer; // 0x30
        public KeyCollection<ÏÏÎÍÎÎÍÎÌÌÍÍÎÍÍÏÏÎÍÌÏÎÌ,ÏÌÌÎÍÏÏÏÎÎÎÏÏÌÏÌÏÌÎÌÍÌÎ> _keys; // 0x38
        public ValueCollection<ÏÏÎÍÎÎÍÎÌÌÍÍÎÍÍÏÏÎÍÌÏÎÌ,ÏÌÌÎÍÏÏÏÎÎÎÏÏÌÏÌÏÌÎÌÍÌÎ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E2D5E0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2E2D670
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2E2D690
        public void set_Item(){} // RVA: 0x2E2D750
        public void Add(){} // RVA: 0x2E2D790
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2E2D7D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2E2D830
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2E2D900
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2E2DA20
        public void ContainsValue(){} // RVA: 0x2CD4040
        public void CopyTo(){} // RVA: 0x2E2DA60
        public void GetEnumerator(){} // RVA: 0x2C74EE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C74F90
        public void GetObjectData(){} // RVA: 0x2E2DC00
        public void FindEntry(){} // RVA: 0x2E2DF50
        public void Initialize(){} // RVA: 0x2E2E280
        public void TryInsert(){} // RVA: 0x2E2E400
        public void OnDeserialization(){} // RVA: 0x2E2EA10
        public void Resize(){} // RVA: 0x2E2EF60 | overloaded x2
        public void Remove(){} // RVA: 0x2E2F450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2E2F750
        public void TryAdd(){} // RVA: 0x2E2F820
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2E2F860
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2E2F870
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C74F90
        public void EnsureCapacity(){} // RVA: 0x2E2FC80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2E2FD70
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2E2FE20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2E2FF50
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2E30130
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2E30310
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C77580
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2E30430
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.Transform,0x659C0BA8>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Transform> _comparer; // 0x30
        public KeyCollection<UnityEngine.Transform,0x659C0BA8> _keys; // 0x38
        public ValueCollection<UnityEngine.Transform,0x659C0BA8> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D1C1E0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D19C00
        public void set_Item(){} // RVA: 0x2D1C270
        public void Add(){} // RVA: 0x2D1C2A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D1C2D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D1C320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D1C3E0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2D1C4C0
        public void CopyTo(){} // RVA: 0x2D19EC0
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D1C5A0
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D1C8F0
        public void TryInsert(){} // RVA: 0x2D1CA70
        public void OnDeserialization(){} // RVA: 0x2D1CEB0
        public void Resize(){} // RVA: 0x2D1D3F0 | overloaded x2
        public void Remove(){} // RVA: 0x2D0C240 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2D0C4B0
        public void TryAdd(){} // RVA: 0x2D1D670
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D1B110
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D1D6A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D1DA50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D1DB40
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D0CAB0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D1DBF0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D1DDC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEAE30
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,UnityEngine.Color>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,UnityEngine.Color> _keys; // 0x38
        public ValueCollection<int,UnityEngine.Color> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C4F6F0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C4F780
        public void set_Item(){} // RVA: 0x2C4F840
        public void Add(){} // RVA: 0x2C4F880
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C4F8C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C4F910
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C4F9E0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C4FAE0
        public void ContainsValue(){} // RVA: 0x2C4FB10
        public void CopyTo(){} // RVA: 0x2C4FC00
        public void GetEnumerator(){} // RVA: 0x2C2DD60
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C2DE00
        public void GetObjectData(){} // RVA: 0x2C4FD10
        public void FindEntry(){} // RVA: 0x2C50060
        public void Initialize(){} // RVA: 0x2C502C0
        public void TryInsert(){} // RVA: 0x2C50440
        public void OnDeserialization(){} // RVA: 0x2C508B0
        public void Resize(){} // RVA: 0x2C51130 | overloaded x2
        public void Remove(){} // RVA: 0x2C51510 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C51730
        public void TryAdd(){} // RVA: 0x2C517B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C517F0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C51800
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C2DE00
        public void EnsureCapacity(){} // RVA: 0x2C51BD0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C51CC0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C51D70
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C51EB0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C52070
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C52230
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C30490
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C52340
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ÏÎÏÍÎÏÏÍÍÎÏÌÏÌÎÎÌÎÏÍÎÎÎ,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÏÎÏÍÎÏÏÍÍÎÏÌÏÌÎÎÌÎÏÍÎÎÎ> _comparer; // 0x30
        public KeyCollection<ÏÎÏÍÎÏÏÍÍÎÏÌÏÌÎÎÌÎÏÍÎÎÎ,int> _keys; // 0x38
        public ValueCollection<ÏÎÏÍÎÏÏÍÍÎÏÌÏÌÎÎÌÎÏÍÎÎÎ,int> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D19B70 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D19C00
        public void set_Item(){} // RVA: 0x2D19C70
        public void Add(){} // RVA: 0x2D19CA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D19CD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D19D20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D19DE0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2CC4A50
        public void CopyTo(){} // RVA: 0x2D19EC0
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D1A010
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D1A360
        public void TryInsert(){} // RVA: 0x2D1A4E0
        public void OnDeserialization(){} // RVA: 0x2D1A920
        public void Resize(){} // RVA: 0x2D1AE60 | overloaded x2
        public void Remove(){} // RVA: 0x2D0C240 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2D0C4B0
        public void TryAdd(){} // RVA: 0x2D1B0E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D1B110
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D1B120
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D1B4D0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D1B5C0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D0CAB0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D1B670
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D1B840
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEAE30
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,uint>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,uint> _keys; // 0x38
        public ValueCollection<string,uint> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D37490 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D19C00
        public void set_Item(){} // RVA: 0x2D37520
        public void Add(){} // RVA: 0x2D37550
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D37580
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D375D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D37690
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2D37770
        public void CopyTo(){} // RVA: 0x2D19EC0
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D37850
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D37BA0
        public void TryInsert(){} // RVA: 0x2D37D20
        public void OnDeserialization(){} // RVA: 0x2D38160
        public void Resize(){} // RVA: 0x2D386A0 | overloaded x2
        public void Remove(){} // RVA: 0x2D0C240 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2D0C4B0
        public void TryAdd(){} // RVA: 0x2D38920
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D1B110
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D38950
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D38D00
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D38DF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D0CAB0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D38EA0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D39070
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEAE30
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,VRC.SDK3.Props.VRCPropApi>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,VRC.SDK3.Props.VRCPropApi> _keys; // 0x38
        public ValueCollection<int,VRC.SDK3.Props.VRCPropApi> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C5AA60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C57A00
        public void set_Item(){} // RVA: 0x2C5AAF0
        public void Add(){} // RVA: 0x2C5AB20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C5AB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C5AB90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C5AC50
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C57CE0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C5AE80
        public void FindEntry(){} // RVA: 0x2C58250
        public void Initialize(){} // RVA: 0x2C5B1D0
        public void TryInsert(){} // RVA: 0x2C5B350
        public void OnDeserialization(){} // RVA: 0x2C5B830
        public void Resize(){} // RVA: 0x2C5BD50 | overloaded x2
        public void Remove(){} // RVA: 0x2C5C130 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C5C360
        public void TryAdd(){} // RVA: 0x2C5C420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C5C460
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C5C800
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C5C8F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C5C9A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C5CAC0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C5CC80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C5A090
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C5CE40
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,ÎÍÎÌÍÍÎÌÏÍÏÌÍÍÍÌÍÍÏÍÏÍÍ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,ÎÍÎÌÍÍÎÌÏÍÏÌÍÍÍÌÍÍÏÍÏÍÍ> _keys; // 0x38
        public ValueCollection<int,ÎÍÎÌÍÍÎÌÏÍÏÌÍÍÍÌÍÍÏÍÏÍÍ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C5AA60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C57A00
        public void set_Item(){} // RVA: 0x2C5AAF0
        public void Add(){} // RVA: 0x2C5AB20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C5AB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C5AB90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C5AC50
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C57CE0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C5AE80
        public void FindEntry(){} // RVA: 0x2C58250
        public void Initialize(){} // RVA: 0x2C5B1D0
        public void TryInsert(){} // RVA: 0x2C5B350
        public void OnDeserialization(){} // RVA: 0x2C5B830
        public void Resize(){} // RVA: 0x2C5BD50 | overloaded x2
        public void Remove(){} // RVA: 0x2C5C130 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C5C360
        public void TryAdd(){} // RVA: 0x2C5C420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C5C460
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C5C800
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C5C8F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C5C9A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C5CAC0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C5CC80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C5A090
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C5CE40
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ÌÌÎÏÌÎÍÎÍÎÏÍÏÎÏÏÍÏÏÎÌÍÍ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÌÌÎÏÌÎÍÎÍÎÏÍÏÎÏÏÍÏÏÎÌÍÍ> _keys; // 0x38
        public ValueCollection<string,ÌÌÎÏÌÎÍÎÍÎÏÍÏÎÏÏÍÏÏÎÌÍÍ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,Cysharp.Threading.Tasks.UniTaskCompletionSource`1<ÌÌÎÏÌÎÍÎÍÎÏÍÏÎÏÏÍÏÏÎÌÍÍ>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,Cysharp.Threading.Tasks.UniTaskCompletionSource`1<ÌÌÎÏÌÎÍÎÍÎÏÍÏÎÏÏÍÏÏÎÌÍÍ>> _keys; // 0x38
        public ValueCollection<int,Cysharp.Threading.Tasks.UniTaskCompletionSource`1<ÌÌÎÏÌÎÍÎÍÎÏÍÏÎÏÏÍÏÏÎÌÍÍ>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C5AA60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C57A00
        public void set_Item(){} // RVA: 0x2C5AAF0
        public void Add(){} // RVA: 0x2C5AB20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C5AB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C5AB90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C5AC50
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C57CE0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C5AE80
        public void FindEntry(){} // RVA: 0x2C58250
        public void Initialize(){} // RVA: 0x2C5B1D0
        public void TryInsert(){} // RVA: 0x2C5B350
        public void OnDeserialization(){} // RVA: 0x2C5B830
        public void Resize(){} // RVA: 0x2C5BD50 | overloaded x2
        public void Remove(){} // RVA: 0x2C5C130 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C5C360
        public void TryAdd(){} // RVA: 0x2C5C420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C5C460
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C5C800
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C5C8F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C5C9A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C5CAC0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C5CC80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C5A090
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C5CE40
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,ÌÎÌÏÎÏÎÎÎÍÎÎÌÎÎÍÏÎÌÏÌÌÍ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,ÌÎÌÏÎÏÎÎÎÍÎÎÌÎÎÍÏÎÌÏÌÌÍ> _keys; // 0x38
        public ValueCollection<int,ÌÎÌÏÎÏÎÎÎÍÎÎÌÎÎÍÏÎÌÏÌÌÍ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C5AA60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C57A00
        public void set_Item(){} // RVA: 0x2C5AAF0
        public void Add(){} // RVA: 0x2C5AB20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C5AB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C5AB90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C5AC50
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C57CE0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C5AE80
        public void FindEntry(){} // RVA: 0x2C58250
        public void Initialize(){} // RVA: 0x2C5B1D0
        public void TryInsert(){} // RVA: 0x2C5B350
        public void OnDeserialization(){} // RVA: 0x2C5B830
        public void Resize(){} // RVA: 0x2C5BD50 | overloaded x2
        public void Remove(){} // RVA: 0x2C5C130 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C5C360
        public void TryAdd(){} // RVA: 0x2C5C420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C5C460
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C5C800
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C5C8F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C5C9A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C5CAC0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C5CC80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C5A090
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C5CE40
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ÏÎÎÌÎÍÍÍÍÍÍÎÌÍÌÍÍÍÏÎÏÌÌ,ÍÏÎÎÎÎÎÏÍÌÎÌÌÍÏÎÌÏÏÌÏÍÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÏÎÎÌÎÍÍÍÍÍÍÎÌÍÌÍÍÍÏÎÏÌÌ> _comparer; // 0x30
        public KeyCollection<ÏÎÎÌÎÍÍÍÍÍÍÎÌÍÌÍÍÍÏÎÏÌÌ,ÍÏÎÎÎÎÎÏÍÌÎÌÌÍÏÎÌÏÏÌÏÍÌ> _keys; // 0x38
        public ValueCollection<ÏÎÎÌÎÍÍÍÍÍÍÎÌÍÌÍÍÍÏÎÏÌÌ,ÍÏÎÎÎÎÎÏÍÌÎÌÌÍÏÎÌÏÏÌÏÍÌ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.GameObject,VRC.SDKBase.VRCDroneApi>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.GameObject> _comparer; // 0x30
        public KeyCollection<UnityEngine.GameObject,VRC.SDKBase.VRCDroneApi> _keys; // 0x38
        public ValueCollection<UnityEngine.GameObject,VRC.SDKBase.VRCDroneApi> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.Tuple`2<...,...>,UnityEngine.Object>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Tuple`2<...,...>> _comparer; // 0x30
        public KeyCollection<System.Tuple`2<...,...>,UnityEngine.Object> _keys; // 0x38
        public ValueCollection<System.Tuple`2<...,...>,UnityEngine.Object> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,UnityEngine.Sprite>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,UnityEngine.Sprite> _keys; // 0x38
        public ValueCollection<string,UnityEngine.Sprite> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,System.Collections.Generic.List`1<ÍÏÎÌÏÍÍÌÍÏÍÍÌÌÌÏÎÌÍÌÍÍÌ>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,System.Collections.Generic.List`1<ÍÏÎÌÏÍÍÌÍÏÍÍÌÌÌÏÎÌÍÌÍÍÌ>> _keys; // 0x38
        public ValueCollection<int,System.Collections.Generic.List`1<ÍÏÎÌÏÍÍÌÍÏÍÍÌÌÌÏÎÌÍÌÍÍÌ>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C5AA60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C57A00
        public void set_Item(){} // RVA: 0x2C5AAF0
        public void Add(){} // RVA: 0x2C5AB20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C5AB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C5AB90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C5AC50
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C57CE0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C5AE80
        public void FindEntry(){} // RVA: 0x2C58250
        public void Initialize(){} // RVA: 0x2C5B1D0
        public void TryInsert(){} // RVA: 0x2C5B350
        public void OnDeserialization(){} // RVA: 0x2C5B830
        public void Resize(){} // RVA: 0x2C5BD50 | overloaded x2
        public void Remove(){} // RVA: 0x2C5C130 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C5C360
        public void TryAdd(){} // RVA: 0x2C5C420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C5C460
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C5C800
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C5C8F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C5C9A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C5CAC0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C5CC80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C5A090
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C5CE40
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,System.DateTime>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.DateTime> _keys; // 0x38
        public ValueCollection<string,System.DateTime> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D0D760 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CE1930
        public void set_Item(){} // RVA: 0x2D0D7F0
        public void Add(){} // RVA: 0x2D0D820
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D0D850
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D0D8A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D0D960
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2D0DA40
        public void CopyTo(){} // RVA: 0x2CE8D80
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D0DB20
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D0DE70
        public void TryInsert(){} // RVA: 0x2D0DFF0
        public void OnDeserialization(){} // RVA: 0x2D0E450
        public void Resize(){} // RVA: 0x2D0E990 | overloaded x2
        public void Remove(){} // RVA: 0x2CEA210 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CEA480
        public void TryAdd(){} // RVA: 0x2D0EC10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CEA530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D0EC40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D0EFF0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D0F0E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CE3D10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D0F190
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D0F360
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEAE30
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,VRC.Core.FavoriteModel>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,VRC.Core.FavoriteModel> _keys; // 0x38
        public ValueCollection<string,VRC.Core.FavoriteModel> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.SceneManagement.Scene,System.Collections.Generic.List`1<ÏÌÍÍÍÏÌÌÎÍÏÎÌÏÏÌÍÌÍÍÏÏÍ>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.SceneManagement.Scene> _comparer; // 0x30
        public KeyCollection<UnityEngine.SceneManagement.Scene,System.Collections.Generic.List`1<ÏÌÍÍÍÏÌÌÎÍÏÎÌÏÏÌÍÌÍÍÏÏÍ>> _keys; // 0x38
        public ValueCollection<UnityEngine.SceneManagement.Scene,System.Collections.Generic.List`1<ÏÌÍÍÍÏÌÌÎÍÏÎÌÏÏÌÍÌÍÍÏÏÍ>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DADFF0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2DAE080
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2DAE0A0
        public void set_Item(){} // RVA: 0x2DAE140
        public void Add(){} // RVA: 0x2DAE170
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2DAE1A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2DAE1E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2DAE2A0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2DAE380
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2DAE3B0
        public void FindEntry(){} // RVA: 0x2DAE700
        public void Initialize(){} // RVA: 0x2DAE960
        public void TryInsert(){} // RVA: 0x2DAEAE0
        public void OnDeserialization(){} // RVA: 0x2DAEFC0
        public void Resize(){} // RVA: 0x2DAF4E0 | overloaded x2
        public void Remove(){} // RVA: 0x2DAF8C0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2DAFAF0
        public void TryAdd(){} // RVA: 0x2DAFBB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2DAFBE0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2DAFF80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2DB0070
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2DB0120
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DB0240
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DB0400
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2DB05C0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2DB06D0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ÍÍÎÏÏÏÎÎÎÏÎÏÍÌÌÍÏÎÏÏÏÍÎ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÍÍÎÏÏÏÎÎÎÏÎÏÍÌÌÍÏÎÏÏÏÍÎ> _keys; // 0x38
        public ValueCollection<string,ÍÍÎÏÏÏÎÎÎÏÎÏÍÌÌÍÏÎÏÏÏÍÎ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ÍÌÌÌÏÌÏÍÎÍÎÍÍÌÏÍÌÍÍÎÍÌÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÍÌÌÌÏÌÏÍÎÍÎÍÍÌÏÍÌÍÍÎÍÌÌ> _keys; // 0x38
        public ValueCollection<string,ÍÌÌÌÏÌÏÍÎÍÎÍÍÌÏÍÌÍÍÎÍÌÌ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ÎÌÏÏÍÎÍÎÌÍÎÌÍÌÌÎÎÎÍÎÏÏÏ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÎÌÏÏÍÎÍÎÌÍÎÌÍÌÌÎÎÎÍÎÏÏÏ> _keys; // 0x38
        public ValueCollection<string,ÎÌÏÏÍÎÍÎÌÍÎÌÍÌÌÎÎÎÍÎÏÏÏ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.Transform,System.ValueTuple`3<int,UnityEngine.Vector3,float>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Transform> _comparer; // 0x30
        public KeyCollection<UnityEngine.Transform,System.ValueTuple`3<int,UnityEngine.Vector3,float>> _keys; // 0x38
        public ValueCollection<UnityEngine.Transform,System.ValueTuple`3<int,UnityEngine.Vector3,float>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CF7530 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CF75C0
        public void set_Item(){} // RVA: 0x2CF7650
        public void Add(){} // RVA: 0x2CF7690
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CF76D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CF7730
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CF7820
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE5860
        public void ContainsValue(){} // RVA: 0x2CF7940
        public void CopyTo(){} // RVA: 0x2CF7A50
        public void GetEnumerator(){} // RVA: 0x2C22F20
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C22FD0
        public void GetObjectData(){} // RVA: 0x2CF7BE0
        public void FindEntry(){} // RVA: 0x2CE5E80
        public void Initialize(){} // RVA: 0x2CF7F30
        public void TryInsert(){} // RVA: 0x2CF80B0
        public void OnDeserialization(){} // RVA: 0x2CF8510
        public void Resize(){} // RVA: 0x2CF8A80 | overloaded x2
        public void Remove(){} // RVA: 0x2CF8F50 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CF91D0
        public void TryAdd(){} // RVA: 0x2CF9250
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CF9290
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CF92A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C22FD0
        public void EnsureCapacity(){} // RVA: 0x2CF9680
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CF9770
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CF9820
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CF9980
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CF9B60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE7FE0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C25800
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CF9D40
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.Behaviour,bool>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Behaviour> _comparer; // 0x30
        public KeyCollection<UnityEngine.Behaviour,bool> _keys; // 0x38
        public ValueCollection<UnityEngine.Behaviour,bool> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D00310 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D003A0
        public void set_Item(){} // RVA: 0x2D00410
        public void Add(){} // RVA: 0x2D00440
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D00470
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D004C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D00580
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2D00660
        public void CopyTo(){} // RVA: 0x2D00740
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D00890
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D00BE0
        public void TryInsert(){} // RVA: 0x2D00D60
        public void OnDeserialization(){} // RVA: 0x2D011A0
        public void Resize(){} // RVA: 0x2D016E0 | overloaded x2
        public void Remove(){} // RVA: 0x2D01960 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2D01BD0
        public void TryAdd(){} // RVA: 0x2D01C50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D01C80
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D01C90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D02040
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D02130
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D021E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D02320
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D024F0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEAE30
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ÍÎÍÏÍÌÏÎÎÏÏÌÌÏÍÍÎÌÍÌÌÌÍ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÍÎÍÏÍÌÏÎÎÏÏÌÌÏÍÍÎÌÍÌÌÌÍ> _keys; // 0x38
        public ValueCollection<string,ÍÎÍÏÍÌÏÎÎÏÏÌÌÏÍÍÎÌÍÌÌÌÍ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.BoxCollider,bool>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.BoxCollider> _comparer; // 0x30
        public KeyCollection<UnityEngine.BoxCollider,bool> _keys; // 0x38
        public ValueCollection<UnityEngine.BoxCollider,bool> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D00310 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D003A0
        public void set_Item(){} // RVA: 0x2D00410
        public void Add(){} // RVA: 0x2D00440
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D00470
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D004C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D00580
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2D00660
        public void CopyTo(){} // RVA: 0x2D00740
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D00890
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D00BE0
        public void TryInsert(){} // RVA: 0x2D00D60
        public void OnDeserialization(){} // RVA: 0x2D011A0
        public void Resize(){} // RVA: 0x2D016E0 | overloaded x2
        public void Remove(){} // RVA: 0x2D01960 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2D01BD0
        public void TryAdd(){} // RVA: 0x2D01C50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D01C80
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D01C90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D02040
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D02130
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D021E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D02320
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D024F0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEAE30
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,System.Func`3<object,object,int>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,System.Func`3<object,object,int>> _keys; // 0x38
        public ValueCollection<int,System.Func`3<object,object,int>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C5AA60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C57A00
        public void set_Item(){} // RVA: 0x2C5AAF0
        public void Add(){} // RVA: 0x2C5AB20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C5AB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C5AB90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C5AC50
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C57CE0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C5AE80
        public void FindEntry(){} // RVA: 0x2C58250
        public void Initialize(){} // RVA: 0x2C5B1D0
        public void TryInsert(){} // RVA: 0x2C5B350
        public void OnDeserialization(){} // RVA: 0x2C5B830
        public void Resize(){} // RVA: 0x2C5BD50 | overloaded x2
        public void Remove(){} // RVA: 0x2C5C130 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C5C360
        public void TryAdd(){} // RVA: 0x2C5C420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C5C460
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C5C800
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C5C8F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C5C9A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C5CAC0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C5CC80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C5A090
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C5CE40
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<object,float>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<object> _comparer; // 0x30
        public KeyCollection<object,float> _keys; // 0x38
        public ValueCollection<object,float> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D2ACA0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D2AD30
        public void set_Item(){} // RVA: 0x2D2ADA0
        public void Add(){} // RVA: 0x2D2ADD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D2AE00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D2AE50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D2AF10
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2D2AFF0
        public void CopyTo(){} // RVA: 0x2D2B0D0
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D2B250
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D2B5A0
        public void TryInsert(){} // RVA: 0x2D2B720
        public void OnDeserialization(){} // RVA: 0x2D2BB60
        public void Resize(){} // RVA: 0x2D2C0A0 | overloaded x2
        public void Remove(){} // RVA: 0x2D2C320 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2D0C4B0
        public void TryAdd(){} // RVA: 0x2D2C590
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D2C5C0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D2C5D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D2C9A0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D2CA90
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D2CB40
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D2CC80
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D2CE50
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEAE30
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.GameObject,System.Collections.Generic.List`1<ÌÍÏÏÏÏÎÏÏÏÍÌÏÍÎÎÌÎÌÎÌÏÏ>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.GameObject> _comparer; // 0x30
        public KeyCollection<UnityEngine.GameObject,System.Collections.Generic.List`1<ÌÍÏÏÏÏÎÏÏÏÍÌÏÍÎÎÌÎÌÎÌÏÏ>> _keys; // 0x38
        public ValueCollection<UnityEngine.GameObject,System.Collections.Generic.List`1<ÌÍÏÏÏÏÎÏÏÏÍÌÏÍÎÎÌÎÌÎÌÏÏ>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ÏÏÌÍÌÏÏÏÌÎÍÍÏÎÍÎÍÎÏÏÏÏÏ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÏÏÌÍÌÏÏÏÌÎÍÍÏÎÍÎÍÎÏÏÏÏÏ> _keys; // 0x38
        public ValueCollection<string,ÏÏÌÍÌÏÏÏÌÎÍÍÏÎÍÎÍÎÏÏÏÏÏ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,Cysharp.Threading.Tasks.UniTask`1<ÍÎÌÏÎÏÏÍÎÎÌÍÏÍÌÍÌÍÌÏÍÍÌ>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Cysharp.Threading.Tasks.UniTask`1<ÍÎÌÏÎÏÏÍÎÎÌÍÏÍÌÍÌÍÌÏÍÍÌ>> _keys; // 0x38
        public ValueCollection<string,Cysharp.Threading.Tasks.UniTask`1<ÍÎÌÏÎÏÏÍÎÎÌÍÏÍÌÍÌÍÌÏÍÍÌ>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CE5420 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CE54B0
        public void set_Item(){} // RVA: 0x2CE5540
        public void Add(){} // RVA: 0x2CE5590
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CE55E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CE5640
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CE5740
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE5860
        public void ContainsValue(){} // RVA: 0x2CE5890
        public void CopyTo(){} // RVA: 0x2CE59A0
        public void GetEnumerator(){} // RVA: 0x2C22F20
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C22FD0
        public void GetObjectData(){} // RVA: 0x2CE5B30
        public void FindEntry(){} // RVA: 0x2CE5E80
        public void Initialize(){} // RVA: 0x2CE60C0
        public void TryInsert(){} // RVA: 0x2CE6240
        public void OnDeserialization(){} // RVA: 0x2CE6710
        public void Resize(){} // RVA: 0x2CE6C80 | overloaded x2
        public void Remove(){} // RVA: 0x2CE7160 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE7400
        public void TryAdd(){} // RVA: 0x2CE74D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CE7520
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CE7530
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C22FD0
        public void EnsureCapacity(){} // RVA: 0x2CE7920
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CE7A10
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CE7AC0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CE7C20
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CE7E00
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE7FE0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C25800
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE8100
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ÍÎÌÏÎÏÏÍÎÎÌÍÏÍÌÍÌÍÌÏÍÍÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÍÎÌÏÎÏÏÍÎÎÌÍÏÍÌÍÌÍÌÏÍÍÌ> _keys; // 0x38
        public ValueCollection<string,ÍÎÌÏÎÏÏÍÎÎÌÍÏÍÌÍÌÍÌÏÍÍÌ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<object,ÏÍÍÍÏÏÎÏÏÌÎÌÌÍÍÌÌÌÍÍÏÏÏ[]>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<object> _comparer; // 0x30
        public KeyCollection<object,ÏÍÍÍÏÏÎÏÏÌÎÌÌÍÍÌÌÌÍÍÏÏÏ[]> _keys; // 0x38
        public ValueCollection<object,ÏÍÍÍÏÏÎÏÏÌÎÌÌÍÍÌÌÌÍÍÏÏÏ[]> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<object,System.Collections.Generic.List`1<ÎÌÎÌÏÍÎÌÌÏÎÌÏÍÌÌÎÎÎÌÎÏÎ>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<object> _comparer; // 0x30
        public KeyCollection<object,System.Collections.Generic.List`1<ÎÌÎÌÏÍÎÌÌÏÎÌÏÍÌÌÎÎÎÌÎÏÎ>> _keys; // 0x38
        public ValueCollection<object,System.Collections.Generic.List`1<ÎÌÎÌÏÍÎÌÌÏÎÌÏÍÌÌÎÎÎÌÎÏÎ>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,UnityEngine.UI.Toggle>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,UnityEngine.UI.Toggle> _keys; // 0x38
        public ValueCollection<string,UnityEngine.UI.Toggle> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<0x657860F8,VRC.Localization.LocalizableString>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x657860F8> _comparer; // 0x30
        public KeyCollection<0x657860F8,VRC.Localization.LocalizableString> _keys; // 0x38
        public ValueCollection<0x657860F8,VRC.Localization.LocalizableString> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C7FF80 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C780B0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C80010
        public void set_Item(){} // RVA: 0x2C800E0
        public void Add(){} // RVA: 0x2C80130
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C80180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C801F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C80310
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C80440
        public void ContainsValue(){} // RVA: 0x2C80470
        public void CopyTo(){} // RVA: 0x2C805A0
        public void GetEnumerator(){} // RVA: 0x2C26A50
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C26B00
        public void GetObjectData(){} // RVA: 0x2C80720
        public void FindEntry(){} // RVA: 0x2C80A70
        public void Initialize(){} // RVA: 0x2C80CD0
        public void TryInsert(){} // RVA: 0x2C80E50
        public void OnDeserialization(){} // RVA: 0x2C81380
        public void Resize(){} // RVA: 0x2C818E0 | overloaded x2
        public void Remove(){} // RVA: 0x2C81CD0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C81F30
        public void TryAdd(){} // RVA: 0x2C82000
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C82050
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C82060
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C26B00
        public void EnsureCapacity(){} // RVA: 0x2C824A0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C82590
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C82640
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C82790
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C82970
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C82B50
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C29540
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C82C60
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ÏÏÎÎÎÎÍÌÎÎÌÏÌÎÏÏÏÌÌÏÍÍÌ,ÎÏÌÎÎÌÎÏÏÏÏÌÏÎÎÏÌÏÍÏÎÎÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÏÏÎÎÎÎÍÌÎÎÌÏÌÎÏÏÏÌÌÏÍÍÌ> _comparer; // 0x30
        public KeyCollection<ÏÏÎÎÎÎÍÌÎÎÌÏÌÎÏÏÏÌÌÏÍÍÌ,ÎÏÌÎÎÌÎÏÏÏÏÌÏÎÎÏÌÏÍÏÎÎÌ> _keys; // 0x38
        public ValueCollection<ÏÏÎÎÎÎÍÌÎÎÌÏÌÎÏÏÏÌÌÏÍÍÌ,ÎÏÌÎÎÌÎÏÏÏÏÌÏÎÎÏÌÏÍÏÎÎÌ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ÌÎÌÌÍÌÏÎÍÏÍÍÏÏÌÍÏÍÏÌÏÏÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÌÎÌÌÍÌÏÎÍÏÍÍÏÏÌÍÏÍÏÌÏÏÌ> _keys; // 0x38
        public ValueCollection<string,ÌÎÌÌÍÌÏÎÍÏÍÍÏÏÌÍÏÍÏÌÏÏÌ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,ÎÌÏÏÎÌÌÌÍÎÏÌÍÎÍÍÎÌÎÍÌÎÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,ÎÌÏÏÎÌÌÌÍÎÏÌÍÎÍÍÎÌÎÍÌÎÌ> _keys; // 0x38
        public ValueCollection<int,ÎÌÏÏÎÌÌÌÍÎÏÌÍÎÍÍÎÌÎÍÌÎÌ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C5AA60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C57A00
        public void set_Item(){} // RVA: 0x2C5AAF0
        public void Add(){} // RVA: 0x2C5AB20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C5AB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C5AB90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C5AC50
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C57CE0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C5AE80
        public void FindEntry(){} // RVA: 0x2C58250
        public void Initialize(){} // RVA: 0x2C5B1D0
        public void TryInsert(){} // RVA: 0x2C5B350
        public void OnDeserialization(){} // RVA: 0x2C5B830
        public void Resize(){} // RVA: 0x2C5BD50 | overloaded x2
        public void Remove(){} // RVA: 0x2C5C130 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C5C360
        public void TryAdd(){} // RVA: 0x2C5C420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C5C460
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C5C800
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C5C8F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C5C9A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C5CAC0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C5CC80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C5A090
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C5CE40
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ÍÍÎÌÍÌÍÌÍÎÎÏÎÍÌÎÎÌÌÎÍÌÌ,UnityEngine.RectTransform>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÍÍÎÌÍÌÍÌÍÎÎÏÎÍÌÎÎÌÌÎÍÌÌ> _comparer; // 0x30
        public KeyCollection<ÍÍÎÌÍÌÍÌÍÎÎÏÎÍÌÎÎÌÌÎÍÌÌ,UnityEngine.RectTransform> _keys; // 0x38
        public ValueCollection<ÍÍÎÌÍÌÍÌÍÎÎÏÎÍÌÎÎÌÌÎÍÌÌ,UnityEngine.RectTransform> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ÎÎÍÌÌÌÍÌÌÏÎÌÌÍÍÎÎÎÍÌÏÏÏ,ÌÏÌÏÏÌÎÌÏÏÌÌÏÌÎÌÏÌÍÏÎÌÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÎÎÍÌÌÌÍÌÌÏÎÌÌÍÍÎÎÎÍÌÏÏÏ> _comparer; // 0x30
        public KeyCollection<ÎÎÍÌÌÌÍÌÌÏÎÌÌÍÍÎÎÎÍÌÏÏÏ,ÌÏÌÏÏÌÎÌÏÏÌÌÏÌÎÌÏÌÍÏÎÌÌ> _keys; // 0x38
        public ValueCollection<ÎÎÍÌÌÌÍÌÌÏÎÌÌÍÍÎÎÎÍÌÏÏÏ,ÌÏÌÏÏÌÎÌÏÏÌÌÏÌÎÌÏÌÍÏÎÌÌ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D23630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D1E7F0
        public void set_Item(){} // RVA: 0x2D236C0
        public void Add(){} // RVA: 0x2D236F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D23720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D23770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D23830
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2D23910
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D23A70
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D23DD0
        public void TryInsert(){} // RVA: 0x2D23F50
        public void OnDeserialization(){} // RVA: 0x2D243B0
        public void Resize(){} // RVA: 0x2D248F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2D24B70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D24BA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D24BC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D24F50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D25040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D250F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D25210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D253D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

}