// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Generic
// Classes: 42
// Methods: 1972

namespace ThirdParty.DotNet.System.Collections.Generic
{
    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<object,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<object> _comparer; // 0x30
        public KeyCollection<object,int> _keys; // 0x38
        public ValueCollection<object,int> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.Type,System.Delegate>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,System.Delegate> _keys; // 0x38
        public ValueCollection<System.Type,System.Delegate> _values; // 0x40
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
        public Entry<int,System.Type>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,System.Type> _keys; // 0x38
        public ValueCollection<int,System.Type> _values; // 0x40
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
        public Entry<UnityEngine.Object,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Object> _comparer; // 0x30
        public KeyCollection<UnityEngine.Object,int> _keys; // 0x38
        public ValueCollection<UnityEngine.Object,int> _values; // 0x40
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
        public Entry<System.Type,System.Type>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,System.Type> _keys; // 0x38
        public ValueCollection<System.Type,System.Type> _values; // 0x40
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
        public Entry<System.Type,VRC.Udon.Serialization.OdinSerializer.Serializer>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,VRC.Udon.Serialization.OdinSerializer.Serializer> _keys; // 0x38
        public ValueCollection<System.Type,VRC.Udon.Serialization.OdinSerializer.Serializer> _values; // 0x40
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
        public Entry<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,System.Collections.Generic.Dictionary`2<System.Type,...<...,...>>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy> _comparer; // 0x30
        public KeyCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,System.Collections.Generic.Dictionary`2<System.Type,...<...,...>>> _keys; // 0x38
        public ValueCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,System.Collections.Generic.Dictionary`2<System.Type,...<...,...>>> _values; // 0x40
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
        public Entry<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,System.Collections.Generic.Dictionary`2<System.Type,System.Reflection.MemberInfo[]>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy> _comparer; // 0x30
        public KeyCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,System.Collections.Generic.Dictionary`2<System.Type,System.Reflection.MemberInfo[]>> _keys; // 0x38
        public ValueCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,System.Collections.Generic.Dictionary`2<System.Type,System.Reflection.MemberInfo[]>> _values; // 0x40
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
        public Entry<System.Type,System.Reflection.MemberInfo[]>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,System.Reflection.MemberInfo[]> _keys; // 0x38
        public ValueCollection<System.Type,System.Reflection.MemberInfo[]> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.Type,...<...,...>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,...<...,...>> _keys; // 0x38
        public ValueCollection<System.Type,...<...,...>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,System.Reflection.MemberInfo>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Reflection.MemberInfo> _keys; // 0x38
        public ValueCollection<string,System.Reflection.MemberInfo> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<VRC.Udon.Common.Interfaces.IUdonProgram>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy> _comparer; // 0x30
        public KeyCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<VRC.Udon.Common.Interfaces.IUdonProgram>> _keys; // 0x38
        public ValueCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<VRC.Udon.Common.Interfaces.IUdonProgram>> _values; // 0x40
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
        public Entry<string,System.Reflection.Assembly>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Reflection.Assembly> _keys; // 0x38
        public ValueCollection<string,System.Reflection.Assembly> _values; // 0x40
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
        public Entry<System.Type,System.Collections.Generic.HashSet`1<System.Type>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,System.Collections.Generic.HashSet`1<System.Type>> _keys; // 0x38
        public ValueCollection<System.Type,System.Collections.Generic.HashSet`1<System.Type>> _values; // 0x40
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
        public Entry<System.Type,System.Collections.Generic.Dictionary`2<System.Type,System.Delegate>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,System.Collections.Generic.Dictionary`2<System.Type,System.Delegate>> _keys; // 0x38
        public ValueCollection<System.Type,System.Collections.Generic.Dictionary`2<System.Type,System.Delegate>> _values; // 0x40
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
        public Entry<System.Type,System.Collections.Generic.Dictionary`2<System.Type,System.Func`2<object,object>>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,System.Collections.Generic.Dictionary`2<System.Type,System.Func`2<object,object>>> _keys; // 0x38
        public ValueCollection<System.Type,System.Collections.Generic.Dictionary`2<System.Type,System.Func`2<object,object>>> _values; // 0x40
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
        public Entry<System.Type,System.Func`2<object,object>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,System.Func`2<object,object>> _keys; // 0x38
        public ValueCollection<System.Type,System.Func`2<object,object>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.Type,VRC.Udon.Serialization.OdinSerializer.IFormatter>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,VRC.Udon.Serialization.OdinSerializer.IFormatter> _keys; // 0x38
        public ValueCollection<System.Type,VRC.Udon.Serialization.OdinSerializer.IFormatter> _values; // 0x40
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
        public Entry<System.Type,System.Collections.Generic.Dictionary`2<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,System.Collections.Generic.Dictionary`2<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter>> _keys; // 0x38
        public ValueCollection<System.Type,System.Collections.Generic.Dictionary`2<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter>> _values; // 0x40
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
        public Entry<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy> _comparer; // 0x30
        public KeyCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter> _keys; // 0x38
        public ValueCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter> _values; // 0x40
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
        public Entry<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<byte[]>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy> _comparer; // 0x30
        public KeyCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<byte[]>> _keys; // 0x38
        public ValueCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<byte[]>> _values; // 0x40
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
        public Entry<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<VRC.Udon.Common.Interfaces.IUdonHeap>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy> _comparer; // 0x30
        public KeyCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<VRC.Udon.Common.Interfaces.IUdonHeap>> _keys; // 0x38
        public ValueCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<VRC.Udon.Common.Interfaces.IUdonHeap>> _values; // 0x40
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
        public Entry<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<VRC.Udon.Common.Interfaces.IUdonSymbolTable>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy> _comparer; // 0x30
        public KeyCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<VRC.Udon.Common.Interfaces.IUdonSymbolTable>> _keys; // 0x38
        public ValueCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<VRC.Udon.Common.Interfaces.IUdonSymbolTable>> _values; // 0x40
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
        public Entry<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<VRC.Udon.Common.Interfaces.IUdonSyncMetadataTable>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy> _comparer; // 0x30
        public KeyCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<VRC.Udon.Common.Interfaces.IUdonSyncMetadataTable>> _keys; // 0x38
        public ValueCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<VRC.Udon.Common.Interfaces.IUdonSyncMetadataTable>> _values; // 0x40
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
        public Entry<object,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<object> _comparer; // 0x30
        public KeyCollection<object,int> _keys; // 0x38
        public ValueCollection<object,int> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<...<...>>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy> _comparer; // 0x30
        public KeyCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<...<...>>> _keys; // 0x38
        public ValueCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<...<...>>> _values; // 0x40
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
        public Entry<object,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<object> _comparer; // 0x30
        public KeyCollection<object,int> _keys; // 0x38
        public ValueCollection<object,int> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<object,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<object> _comparer; // 0x30
        public KeyCollection<object,int> _keys; // 0x38
        public ValueCollection<object,int> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<System.ValueTuple`3<uint,System.Runtime.CompilerServices.IStrongBox,System.Type>>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy> _comparer; // 0x30
        public KeyCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<System.ValueTuple`3<uint,System.Runtime.CompilerServices.IStrongBox,System.Type>>> _keys; // 0x38
        public ValueCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<System.ValueTuple`3<uint,System.Runtime.CompilerServices.IStrongBox,System.Type>>> _values; // 0x40
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
        public Entry<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<System.Runtime.CompilerServices.IStrongBox>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy> _comparer; // 0x30
        public KeyCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<System.Runtime.CompilerServices.IStrongBox>> _keys; // 0x38
        public ValueCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<System.Runtime.CompilerServices.IStrongBox>> _values; // 0x40
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
        public Entry<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<System.Type>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy> _comparer; // 0x30
        public KeyCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<System.Type>> _keys; // 0x38
        public ValueCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<System.Type>> _values; // 0x40
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
        public Entry<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<VRC.SDKBase.VRCPlayerApi>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy> _comparer; // 0x30
        public KeyCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<VRC.SDKBase.VRCPlayerApi>> _keys; // 0x38
        public ValueCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<VRC.SDKBase.VRCPlayerApi>> _values; // 0x40
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
        public Entry<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<...<...>>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy> _comparer; // 0x30
        public KeyCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<...<...>>> _keys; // 0x38
        public ValueCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<...<...>>> _values; // 0x40
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
        public Entry<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<VRC.Udon.Common.Interfaces.IUdonSymbol>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy> _comparer; // 0x30
        public KeyCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<VRC.Udon.Common.Interfaces.IUdonSymbol>> _keys; // 0x38
        public ValueCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<VRC.Udon.Common.Interfaces.IUdonSymbol>> _values; // 0x40
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
        public Entry<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<object>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy> _comparer; // 0x30
        public KeyCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<object>> _keys; // 0x38
        public ValueCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<object>> _values; // 0x40
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
        public Entry<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<System.Collections.Generic.List`1<string>>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy> _comparer; // 0x30
        public KeyCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<System.Collections.Generic.List`1<string>>> _keys; // 0x38
        public ValueCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<System.Collections.Generic.List`1<string>>> _values; // 0x40
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
        public Entry<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<System.RuntimeType>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy> _comparer; // 0x30
        public KeyCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<System.RuntimeType>> _keys; // 0x38
        public ValueCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<System.RuntimeType>> _values; // 0x40
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
        public Entry<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<...<...>>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy> _comparer; // 0x30
        public KeyCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<...<...>>> _keys; // 0x38
        public ValueCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<...<...>>> _values; // 0x40
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
        public Entry<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<VRC.Udon.Common.Interfaces.IUdonSyncMetadata>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy> _comparer; // 0x30
        public KeyCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<VRC.Udon.Common.Interfaces.IUdonSyncMetadata>> _keys; // 0x38
        public ValueCollection<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter`1<VRC.Udon.Common.Interfaces.IUdonSyncMetadata>> _values; // 0x40
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
        public Entry<string,VRC.Udon.Common.Interfaces.IUdonSyncMetadata>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,VRC.Udon.Common.Interfaces.IUdonSyncMetadata> _keys; // 0x38
        public ValueCollection<string,VRC.Udon.Common.Interfaces.IUdonSyncMetadata> _values; // 0x40
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
        public Entry<System.Type,System.Action`2<VRC.Udon.Serialization.OdinSerializer.BinaryDataWriter,object>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,System.Action`2<VRC.Udon.Serialization.OdinSerializer.BinaryDataWriter,object>> _keys; // 0x38
        public ValueCollection<System.Type,System.Action`2<VRC.Udon.Serialization.OdinSerializer.BinaryDataWriter,object>> _values; // 0x40
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
        public Entry<object,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<object> _comparer; // 0x30
        public KeyCollection<object,int> _keys; // 0x38
        public ValueCollection<object,int> _values; // 0x40
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

}