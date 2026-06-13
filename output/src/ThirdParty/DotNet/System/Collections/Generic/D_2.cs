// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Generic
// Classes: 100
// Methods: 5800

namespace ThirdParty.DotNet.System.Collections.Generic
{
    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<0x6588E360,System.Collections.Generic.Dictionary`2<0x6588F750,ÌÌÌÏÌÍÍÎÎÍÏÌÍÏÏÍÍÌÌÍÎÎÍ>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x6588E360> _comparer; // 0x30
        public KeyCollection<0x6588E360,System.Collections.Generic.Dictionary`2<0x6588F750,ÌÌÌÏÌÍÍÎÎÍÏÌÍÏÏÍÍÌÌÍÎÎÍ>> _keys; // 0x38
        public ValueCollection<0x6588E360,System.Collections.Generic.Dictionary`2<0x6588F750,ÌÌÌÏÌÍÍÎÎÍÏÌÍÏÏÍÍÌÌÍÎÎÍ>> _values; // 0x40
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
        public Entry<int,Unity.Profiling.ProfilerMarker>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,Unity.Profiling.ProfilerMarker> _keys; // 0x38
        public ValueCollection<int,Unity.Profiling.ProfilerMarker> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C5D700 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C5D790
        public void set_Item(){} // RVA: 0x2C5D830
        public void Add(){} // RVA: 0x2C5D860
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C5D890
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C5D8D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C5D990
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C57CE0
        public void ContainsValue(){} // RVA: 0x2C5DA70
        public void CopyTo(){} // RVA: 0x2C57DF0
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C5DB50
        public void FindEntry(){} // RVA: 0x2C58250
        public void Initialize(){} // RVA: 0x2C5DEA0
        public void TryInsert(){} // RVA: 0x2C5E020
        public void OnDeserialization(){} // RVA: 0x2C5E490
        public void Resize(){} // RVA: 0x2C5E9B0 | overloaded x2
        public void Remove(){} // RVA: 0x2C593A0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C595C0
        public void TryAdd(){} // RVA: 0x2C5EBA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C59670
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C5EBD0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C5EFA0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C5F090
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C59BF0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C5F140
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C5F2F0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C5A090
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C5A1A0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<0x6598D880,System.Type>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x6598D880> _comparer; // 0x30
        public KeyCollection<0x6598D880,System.Type> _keys; // 0x38
        public ValueCollection<0x6598D880,System.Type> _values; // 0x40
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
        public Entry<System.Type,Photon.Client.StructWrapping.StructWrapperPool>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,Photon.Client.StructWrapping.StructWrapperPool> _keys; // 0x38
        public ValueCollection<System.Type,Photon.Client.StructWrapping.StructWrapperPool> _values; // 0x40
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
        public Entry<byte,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<byte> _comparer; // 0x30
        public KeyCollection<byte,int> _keys; // 0x38
        public ValueCollection<byte,int> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C08F70 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C09000
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C09020
        public void set_Item(){} // RVA: 0x2C090C0
        public void Add(){} // RVA: 0x2C090F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C09120
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C09170
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C09230
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C09310
        public void ContainsValue(){} // RVA: 0x2C09340
        public void CopyTo(){} // RVA: 0x2C09420
        public void GetEnumerator(){} // RVA: 0x2C09520
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C095B0
        public void GetObjectData(){} // RVA: 0x2C09680
        public void FindEntry(){} // RVA: 0x2C099D0
        public void Initialize(){} // RVA: 0x2C09C30
        public void TryInsert(){} // RVA: 0x2C09DB0
        public void OnDeserialization(){} // RVA: 0x2C0A220
        public void Resize(){} // RVA: 0x2C0A730 | overloaded x2
        public void Remove(){} // RVA: 0x2C0AB20 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C0AD30
        public void TryAdd(){} // RVA: 0x2C0ADA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C0ADD0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C0ADE0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C095B0
        public void EnsureCapacity(){} // RVA: 0x2C0B1C0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C0B2B0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C0B360
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C0B380
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C0B4C0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C0B680
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C0B840
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0B950
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C0BA20
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<byte,string>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<byte> _comparer; // 0x30
        public KeyCollection<byte,string> _keys; // 0x38
        public ValueCollection<byte,string> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C0C6D0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C09000
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C0C760
        public void set_Item(){} // RVA: 0x2C0C800
        public void Add(){} // RVA: 0x2C0C830
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C0C860
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C0C8B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C0C970
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C0CA50
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C0CBB0
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C0CE70
        public void FindEntry(){} // RVA: 0x2C0D1C0
        public void Initialize(){} // RVA: 0x2C0D420
        public void TryInsert(){} // RVA: 0x2C0D5A0
        public void OnDeserialization(){} // RVA: 0x2C0DA90
        public void Resize(){} // RVA: 0x2C0DFB0 | overloaded x2
        public void Remove(){} // RVA: 0x2C0E3A0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C0E5D0
        public void TryAdd(){} // RVA: 0x2C0E690
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C0E6C0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C0E6D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C0EA70
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C0EB60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C0EC30
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C0ED50
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C0EF10
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C0F0D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C0F2C0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<byte,string[]>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<byte> _comparer; // 0x30
        public KeyCollection<byte,string[]> _keys; // 0x38
        public ValueCollection<byte,string[]> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C0C6D0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C09000
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C0C760
        public void set_Item(){} // RVA: 0x2C0C800
        public void Add(){} // RVA: 0x2C0C830
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C0C860
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C0C8B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C0C970
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C0CA50
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C0CBB0
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C0CE70
        public void FindEntry(){} // RVA: 0x2C0D1C0
        public void Initialize(){} // RVA: 0x2C0D420
        public void TryInsert(){} // RVA: 0x2C0D5A0
        public void OnDeserialization(){} // RVA: 0x2C0DA90
        public void Resize(){} // RVA: 0x2C0DFB0 | overloaded x2
        public void Remove(){} // RVA: 0x2C0E3A0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C0E5D0
        public void TryAdd(){} // RVA: 0x2C0E690
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C0E6C0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C0E6D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C0EA70
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C0EB60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C0EC30
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C0ED50
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C0EF10
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C0F0D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C0F2C0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,string>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,string> _keys; // 0x38
        public ValueCollection<int,string> _values; // 0x40
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
        public Entry<string,System.Collections.Generic.Dictionary`2<byte,string>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Collections.Generic.Dictionary`2<byte,string>> _keys; // 0x38
        public ValueCollection<string,System.Collections.Generic.Dictionary`2<byte,string>> _values; // 0x40
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
        public Entry<byte,Photon.Client.CustomType>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<byte> _comparer; // 0x30
        public KeyCollection<byte,Photon.Client.CustomType> _keys; // 0x38
        public ValueCollection<byte,Photon.Client.CustomType> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C0C6D0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C09000
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C0C760
        public void set_Item(){} // RVA: 0x2C0C800
        public void Add(){} // RVA: 0x2C0C830
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C0C860
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C0C8B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C0C970
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C0CA50
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C0CBB0
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C0CE70
        public void FindEntry(){} // RVA: 0x2C0D1C0
        public void Initialize(){} // RVA: 0x2C0D420
        public void TryInsert(){} // RVA: 0x2C0D5A0
        public void OnDeserialization(){} // RVA: 0x2C0DA90
        public void Resize(){} // RVA: 0x2C0DFB0 | overloaded x2
        public void Remove(){} // RVA: 0x2C0E3A0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C0E5D0
        public void TryAdd(){} // RVA: 0x2C0E690
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C0E6C0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C0E6D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C0EA70
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C0EB60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C0EC30
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C0ED50
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C0EF10
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C0F0D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C0F2C0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.Type,Photon.Client.CustomType>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,Photon.Client.CustomType> _keys; // 0x38
        public ValueCollection<System.Type,Photon.Client.CustomType> _values; // 0x40
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
        public Entry<string,System.ValueTuple`3<string,0x659F2610,0x659F2668>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.ValueTuple`3<string,0x659F2610,0x659F2668>> _keys; // 0x38
        public ValueCollection<string,System.ValueTuple`3<string,0x659F2610,0x659F2668>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CFA650 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CEB7D0
        public void set_Item(){} // RVA: 0x2CFA6E0
        public void Add(){} // RVA: 0x2CFA720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CFA760
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CFA7B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CFA890
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CEBB00
        public void ContainsValue(){} // RVA: 0x2CFA990
        public void CopyTo(){} // RVA: 0x2CEBC20
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2CFAA80
        public void FindEntry(){} // RVA: 0x2CEC0D0
        public void Initialize(){} // RVA: 0x2CFADD0
        public void TryInsert(){} // RVA: 0x2CFAF50
        public void OnDeserialization(){} // RVA: 0x2CFB410
        public void Resize(){} // RVA: 0x2CFB960 | overloaded x2
        public void Remove(){} // RVA: 0x2CED390 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CED610
        public void TryAdd(){} // RVA: 0x2CFBBF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CED710
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CFBC30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2CFC010
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CFC100
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CEDCA0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CFC1B0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CFC390
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CEE1B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEE2D0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.UI.ICanvasElement,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.UI.ICanvasElement> _comparer; // 0x30
        public KeyCollection<UnityEngine.UI.ICanvasElement,int> _keys; // 0x38
        public ValueCollection<UnityEngine.UI.ICanvasElement,int> _values; // 0x40
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
        public Entry<System.Type,System.Func`1<int>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,System.Func`1<int>> _keys; // 0x38
        public ValueCollection<System.Type,System.Func`1<int>> _values; // 0x40
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
        public Entry<System.Type,bool>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,bool> _keys; // 0x38
        public ValueCollection<System.Type,bool> _values; // 0x40
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
        public Entry<UnityEngine.Canvas,UnityEngine.UI.Collections.IndexedSet`1<UnityEngine.UI.Graphic>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Canvas> _comparer; // 0x30
        public KeyCollection<UnityEngine.Canvas,UnityEngine.UI.Collections.IndexedSet`1<UnityEngine.UI.Graphic>> _keys; // 0x38
        public ValueCollection<UnityEngine.Canvas,UnityEngine.UI.Collections.IndexedSet`1<UnityEngine.UI.Graphic>> _values; // 0x40
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
        public Entry<UnityEngine.UI.Graphic,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.UI.Graphic> _comparer; // 0x30
        public KeyCollection<UnityEngine.UI.Graphic,int> _keys; // 0x38
        public ValueCollection<UnityEngine.UI.Graphic,int> _values; // 0x40
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
        public Entry<UnityEngine.RectTransform,System.Collections.Generic.List`1<UnityEngine.Component>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.RectTransform> _comparer; // 0x30
        public KeyCollection<UnityEngine.RectTransform,System.Collections.Generic.List`1<UnityEngine.Component>> _keys; // 0x38
        public ValueCollection<UnityEngine.RectTransform,System.Collections.Generic.List`1<UnityEngine.Component>> _values; // 0x40
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
        public Entry<string,ExperimentSegment>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ExperimentSegment> _keys; // 0x38
        public ValueCollection<string,ExperimentSegment> _values; // 0x40
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
        public Entry<System.ReadOnlyMemory`1<char>,string>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.ReadOnlyMemory`1<char>> _comparer; // 0x30
        public KeyCollection<System.ReadOnlyMemory`1<char>,string> _keys; // 0x38
        public ValueCollection<System.ReadOnlyMemory`1<char>,string> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2BF4220 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2BF42B0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2BF42D0
        public void set_Item(){} // RVA: 0x2BF4380
        public void Add(){} // RVA: 0x2BF43C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2BF4400
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2BF4450
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2BF4520
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2BF4610
        public void ContainsValue(){} // RVA: 0x2BED020
        public void CopyTo(){} // RVA: 0x2BED150
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2BF4650
        public void FindEntry(){} // RVA: 0x2BF49A0
        public void Initialize(){} // RVA: 0x2BF4C60
        public void TryInsert(){} // RVA: 0x2BF4DE0
        public void OnDeserialization(){} // RVA: 0x2BF5380
        public void Resize(){} // RVA: 0x2BF58B0 | overloaded x2
        public void Remove(){} // RVA: 0x2BF5D60 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2BF6030
        public void TryAdd(){} // RVA: 0x2BF60F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2BEF290
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BF6130
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2BF64F0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2BF65E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2BF6690
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2BF67B0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2BF6980
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2BF6B50
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2BF6C70
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.Type,string>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,string> _keys; // 0x38
        public ValueCollection<System.Type,string> _values; // 0x40
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
        public Entry<string,ÍÏÎÎÎÏÍÍÍÎÌÎÌÍÌÎÏÌÎÎÌÌÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÍÏÎÎÎÏÍÍÍÎÌÎÌÍÌÎÏÌÎÎÌÌÌ> _keys; // 0x38
        public ValueCollection<string,ÍÏÎÎÎÏÍÍÍÎÌÎÌÍÌÎÏÌÎÎÌÌÌ> _values; // 0x40
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
        public Entry<int,VRC.Core.Networking.Tools.BunchCollection>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,VRC.Core.Networking.Tools.BunchCollection> _keys; // 0x38
        public ValueCollection<int,VRC.Core.Networking.Tools.BunchCollection> _values; // 0x40
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
        public Entry<Cinemachine.CinemachineBrain,UnityEngine.Rendering.PostProcessing.PostProcessLayer>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<Cinemachine.CinemachineBrain> _comparer; // 0x30
        public KeyCollection<Cinemachine.CinemachineBrain,UnityEngine.Rendering.PostProcessing.PostProcessLayer> _keys; // 0x38
        public ValueCollection<Cinemachine.CinemachineBrain,UnityEngine.Rendering.PostProcessing.PostProcessLayer> _values; // 0x40
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
        public Entry<string,Google.FlatBuffers8.StringOffset>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Google.FlatBuffers8.StringOffset> _keys; // 0x38
        public ValueCollection<string,Google.FlatBuffers8.StringOffset> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D2FD90 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D2FE20
        public void set_Item(){} // RVA: 0x2D2FE90
        public void Add(){} // RVA: 0x2D2FEC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D2FEF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D2FF40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D30000
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2D300E0
        public void CopyTo(){} // RVA: 0x2D301C0
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D30310
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D30660
        public void TryInsert(){} // RVA: 0x2D307E0
        public void OnDeserialization(){} // RVA: 0x2D30C50
        public void Resize(){} // RVA: 0x2D31190 | overloaded x2
        public void Remove(){} // RVA: 0x2D01960 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2D01BD0
        public void TryAdd(){} // RVA: 0x2D31410
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D31440
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D31450
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D31800
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D318F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D021E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D319A0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D31B70
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEAE30
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,Google.FlatBuffers32.StringOffset>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Google.FlatBuffers32.StringOffset> _keys; // 0x38
        public ValueCollection<string,Google.FlatBuffers32.StringOffset> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D2D7F0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D0AC60
        public void set_Item(){} // RVA: 0x2D2D880
        public void Add(){} // RVA: 0x2D2D8B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D2D8E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D2D930
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D2D9F0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2D2DAD0
        public void CopyTo(){} // RVA: 0x2D0B000
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D2DBB0
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D2DF00
        public void TryInsert(){} // RVA: 0x2D2E080
        public void OnDeserialization(){} // RVA: 0x2D2E4E0
        public void Resize(){} // RVA: 0x2D2EA20 | overloaded x2
        public void Remove(){} // RVA: 0x2D0C240 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2D0C4B0
        public void TryAdd(){} // RVA: 0x2D2ECA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D0C550
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D2ECD0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D2F080
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D2F170
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D0CAB0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D2F220
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D2F3F0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEAE30
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.ReadOnlyMemory`1<char>,object>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.ReadOnlyMemory`1<char>> _comparer; // 0x30
        public KeyCollection<System.ReadOnlyMemory`1<char>,object> _keys; // 0x38
        public ValueCollection<System.ReadOnlyMemory`1<char>,object> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2BF4220 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2BF42B0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2BF42D0
        public void set_Item(){} // RVA: 0x2BF4380
        public void Add(){} // RVA: 0x2BF43C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2BF4400
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2BF4450
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2BF4520
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2BF4610
        public void ContainsValue(){} // RVA: 0x2BED020
        public void CopyTo(){} // RVA: 0x2BED150
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2BF4650
        public void FindEntry(){} // RVA: 0x2BF49A0
        public void Initialize(){} // RVA: 0x2BF4C60
        public void TryInsert(){} // RVA: 0x2BF4DE0
        public void OnDeserialization(){} // RVA: 0x2BF5380
        public void Resize(){} // RVA: 0x2BF58B0 | overloaded x2
        public void Remove(){} // RVA: 0x2BF5D60 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2BF6030
        public void TryAdd(){} // RVA: 0x2BF60F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2BEF290
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BF6130
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2BF64F0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2BF65E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2BF6690
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2BF67B0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2BF6980
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2BF6B50
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2BF6C70
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,System.Reflection.PropertyInfo>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Reflection.PropertyInfo> _keys; // 0x38
        public ValueCollection<string,System.Reflection.PropertyInfo> _values; // 0x40
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
        public Entry<UnityEngine.UI.IClipper,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.UI.IClipper> _comparer; // 0x30
        public KeyCollection<UnityEngine.UI.IClipper,int> _keys; // 0x38
        public ValueCollection<UnityEngine.UI.IClipper,int> _values; // 0x40
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
        public Entry<string,Valve.VR.SteamVR_Action>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Valve.VR.SteamVR_Action> _keys; // 0x38
        public ValueCollection<string,Valve.VR.SteamVR_Action> _values; // 0x40
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
        public Entry<string,Valve.VR.SteamVR_ActionSet>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Valve.VR.SteamVR_ActionSet> _keys; // 0x38
        public ValueCollection<string,Valve.VR.SteamVR_ActionSet> _values; // 0x40
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
        public Entry<ulong,0x65925E40>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ulong> _comparer; // 0x30
        public KeyCollection<ulong,0x65925E40> _keys; // 0x38
        public ValueCollection<ulong,0x65925E40> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DE7980 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2DE7A10
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2DE7A30
        public void set_Item(){} // RVA: 0x2DE7AD0
        public void Add(){} // RVA: 0x2DE7B00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2DE7B30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2DE7B80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2DE7C40
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2DE7D20
        public void ContainsValue(){} // RVA: 0x2D1C4C0
        public void CopyTo(){} // RVA: 0x2CC4B30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2DE7D50
        public void FindEntry(){} // RVA: 0x2DE80A0
        public void Initialize(){} // RVA: 0x2DE8320
        public void TryInsert(){} // RVA: 0x2DE84A0
        public void OnDeserialization(){} // RVA: 0x2DE8910
        public void Resize(){} // RVA: 0x2DE8E30 | overloaded x2
        public void Remove(){} // RVA: 0x2DE9220 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2DE9430
        public void TryAdd(){} // RVA: 0x2DE94A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CC6390
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2DE94D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2DE98A0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2DE9990
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2DE9A40
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DE9B80
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DE9D40
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2DE9F00
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2DEA010
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<0x6595C5A8,Event`1<Valve.VR.VREvent_t>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x6595C5A8> _comparer; // 0x30
        public KeyCollection<0x6595C5A8,Event`1<Valve.VR.VREvent_t>> _keys; // 0x38
        public ValueCollection<0x6595C5A8,Event`1<Valve.VR.VREvent_t>> _values; // 0x40
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
        public Entry<0x65742368,byte[]>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x65742368> _comparer; // 0x30
        public KeyCollection<0x65742368,byte[]> _keys; // 0x38
        public ValueCollection<0x65742368,byte[]> _values; // 0x40
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
        public Entry<int,SizeGroup<UnityEngine.Keyframe>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,SizeGroup<UnityEngine.Keyframe>> _keys; // 0x38
        public ValueCollection<int,SizeGroup<UnityEngine.Keyframe>> _values; // 0x40
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
        public Entry<0x65747068,byte[]>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x65747068> _comparer; // 0x30
        public KeyCollection<0x65747068,byte[]> _keys; // 0x38
        public ValueCollection<0x65747068,byte[]> _values; // 0x40
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
        public Entry<int,char>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,char> _keys; // 0x38
        public ValueCollection<int,char> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C4D1A0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C40620
        public void set_Item(){} // RVA: 0x2C4D230
        public void Add(){} // RVA: 0x2C4D260
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C4D290
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C4D2E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C4D3A0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C40910
        public void ContainsValue(){} // RVA: 0x2C4D480
        public void CopyTo(){} // RVA: 0x2C40A20
        public void GetEnumerator(){} // RVA: 0x2C09520
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C095B0
        public void GetObjectData(){} // RVA: 0x2C4D560
        public void FindEntry(){} // RVA: 0x2C40E70
        public void Initialize(){} // RVA: 0x2C4D8B0
        public void TryInsert(){} // RVA: 0x2C4DA30
        public void OnDeserialization(){} // RVA: 0x2C4DEA0
        public void Resize(){} // RVA: 0x2C4E3B0 | overloaded x2
        public void Remove(){} // RVA: 0x2C41FB0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C421C0
        public void TryAdd(){} // RVA: 0x2C4E5A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C42260
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C4E5D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C095B0
        public void EnsureCapacity(){} // RVA: 0x2C4E9B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C4EAA0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C427F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C4EB50
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C4ED10
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C42CB0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0B950
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C42DC0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<long,FallbackMaterial>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<long> _comparer; // 0x30
        public KeyCollection<long,FallbackMaterial> _keys; // 0x38
        public ValueCollection<long,FallbackMaterial> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CC1460 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CBD800
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CC14F0
        public void set_Item(){} // RVA: 0x2CC1590
        public void Add(){} // RVA: 0x2CC15C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CC15F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CC1640
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CC1700
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CC17E0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2CC1810
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2CC1950
        public void FindEntry(){} // RVA: 0x2CC1CA0
        public void Initialize(){} // RVA: 0x2CC1F20
        public void TryInsert(){} // RVA: 0x2CC20A0
        public void OnDeserialization(){} // RVA: 0x2CC2580
        public void Resize(){} // RVA: 0x2CC2AA0 | overloaded x2
        public void Remove(){} // RVA: 0x2CC2E90 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CC30C0
        public void TryAdd(){} // RVA: 0x2CC3180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CC31B0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CC31C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2CC3550
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CC3640
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CC36F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CC3810
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CC39D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CC3B90
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CC3CA0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,UnityEngine.RenderInstancedDataLayout>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,UnityEngine.RenderInstancedDataLayout> _keys; // 0x38
        public ValueCollection<int,UnityEngine.RenderInstancedDataLayout> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C5FCB0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C4F780
        public void set_Item(){} // RVA: 0x2C5FD40
        public void Add(){} // RVA: 0x2C5FD80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C5FDC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C5FE10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C5FEE0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C4FAE0
        public void ContainsValue(){} // RVA: 0x2C5FFE0
        public void CopyTo(){} // RVA: 0x2C4FC00
        public void GetEnumerator(){} // RVA: 0x2C2DD60
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C2DE00
        public void GetObjectData(){} // RVA: 0x2C600D0
        public void FindEntry(){} // RVA: 0x2C50060
        public void Initialize(){} // RVA: 0x2C60420
        public void TryInsert(){} // RVA: 0x2C605A0
        public void OnDeserialization(){} // RVA: 0x2C60A10
        public void Resize(){} // RVA: 0x2C61290 | overloaded x2
        public void Remove(){} // RVA: 0x2C51510 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C51730
        public void TryAdd(){} // RVA: 0x2C61480
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C517F0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C614C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C2DE00
        public void EnsureCapacity(){} // RVA: 0x2C61890
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C61980
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C51D70
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C61A30
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C61BF0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C52230
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C30490
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C52340
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ÏÍÎÎÌÍÌÏÏÏÏÎÏÏÏÏÏÏÏÎÍÌÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÏÍÎÎÌÍÌÏÏÏÏÎÏÏÏÏÏÏÏÎÍÌÌ> _keys; // 0x38
        public ValueCollection<string,ÏÍÎÎÌÍÌÏÏÏÏÎÏÏÏÏÏÏÏÎÍÌÌ> _values; // 0x40
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
        public Entry<UIntPtr,object>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UIntPtr> _comparer; // 0x30
        public KeyCollection<UIntPtr,object> _keys; // 0x38
        public ValueCollection<UIntPtr,object> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CC77A0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CC4710
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CC7830
        public void set_Item(){} // RVA: 0x2CC78D0
        public void Add(){} // RVA: 0x2CC7900
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CC7930
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CC7980
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CC7A40
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CC4A20
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2CC1810
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2CC7B20
        public void FindEntry(){} // RVA: 0x2CC4F90
        public void Initialize(){} // RVA: 0x2CC7E70
        public void TryInsert(){} // RVA: 0x2CC7FF0
        public void OnDeserialization(){} // RVA: 0x2CC84D0
        public void Resize(){} // RVA: 0x2CC89F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CC8DD0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CC9000
        public void TryAdd(){} // RVA: 0x2CC90C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CC31B0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CC90F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2CC9480
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CC9570
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CC9620
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CC9740
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CC9900
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CC6DD0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CC9AC0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UIntPtr,ÏÍÎÎÌÍÌÏÏÏÏÎÏÏÏÏÏÏÏÎÍÌÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UIntPtr> _comparer; // 0x30
        public KeyCollection<UIntPtr,ÏÍÎÎÌÍÌÏÏÏÏÎÏÏÏÏÏÏÏÎÍÌÌ> _keys; // 0x38
        public ValueCollection<UIntPtr,ÏÍÎÎÌÍÌÏÏÏÏÎÏÏÏÏÏÏÏÎÍÌÌ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CC77A0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CC4710
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CC7830
        public void set_Item(){} // RVA: 0x2CC78D0
        public void Add(){} // RVA: 0x2CC7900
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CC7930
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CC7980
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CC7A40
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CC4A20
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2CC1810
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2CC7B20
        public void FindEntry(){} // RVA: 0x2CC4F90
        public void Initialize(){} // RVA: 0x2CC7E70
        public void TryInsert(){} // RVA: 0x2CC7FF0
        public void OnDeserialization(){} // RVA: 0x2CC84D0
        public void Resize(){} // RVA: 0x2CC89F0 | overloaded x2
        public void Remove(){} // RVA: 0x2CC8DD0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CC9000
        public void TryAdd(){} // RVA: 0x2CC90C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CC31B0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CC90F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2CC9480
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CC9570
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CC9620
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CC9740
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CC9900
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CC6DD0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CC9AC0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ulong,ÏÎÍÏÍÎÍÏÎÌÌÍÏÍÌÏÌÏÌÍÍÎÏ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ulong> _comparer; // 0x30
        public KeyCollection<ulong,ÏÎÍÏÍÎÍÏÎÌÌÍÏÍÌÏÌÏÌÍÍÎÏ> _keys; // 0x38
        public ValueCollection<ulong,ÏÎÍÏÍÎÍÏÎÌÌÍÏÍÌÏÌÏÌÍÍÎÏ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DF6850 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2DE7A10
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2DED5A0
        public void set_Item(){} // RVA: 0x2DF68E0
        public void Add(){} // RVA: 0x2DF6920
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2DF6960
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2DF69B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2DF6A90
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2DED910
        public void ContainsValue(){} // RVA: 0x2DF6B90
        public void CopyTo(){} // RVA: 0x2DBE9F0
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2DF6C80
        public void FindEntry(){} // RVA: 0x2DEDED0
        public void Initialize(){} // RVA: 0x2DF6FD0
        public void TryInsert(){} // RVA: 0x2DF7150
        public void OnDeserialization(){} // RVA: 0x2DF75D0
        public void Resize(){} // RVA: 0x2DF7E70 | overloaded x2
        public void Remove(){} // RVA: 0x2DF8260 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2DF8480
        public void TryAdd(){} // RVA: 0x2DF8500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2DC04E0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2DF8540
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2DF8920
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2DF8A10
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2DEF9B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DF8AC0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DF8C90
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2DEFE90
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2DF8E60
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ulong,ÌÏÎÍÏÍÍÌÍÌÎÍÏÎÍÏÎÌÏÍÍÎÏ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ulong> _comparer; // 0x30
        public KeyCollection<ulong,ÌÏÎÍÏÍÍÌÍÌÎÍÏÎÍÏÎÌÏÍÍÎÏ> _keys; // 0x38
        public ValueCollection<ulong,ÌÏÎÍÏÍÍÌÍÌÎÍÏÎÍÏÎÌÏÍÍÎÏ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DF2F70 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2DE7A10
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2DF3000
        public void set_Item(){} // RVA: 0x2DF30C0
        public void Add(){} // RVA: 0x2DF3110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2DF3160
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2DF31C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2DF32C0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2DF33E0
        public void ContainsValue(){} // RVA: 0x2DF3410
        public void CopyTo(){} // RVA: 0x2DF3520
        public void GetEnumerator(){} // RVA: 0x2C22F20
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C22FD0
        public void GetObjectData(){} // RVA: 0x2DF3690
        public void FindEntry(){} // RVA: 0x2DF39E0
        public void Initialize(){} // RVA: 0x2DF3C60
        public void TryInsert(){} // RVA: 0x2DF3DE0
        public void OnDeserialization(){} // RVA: 0x2DF42E0
        public void Resize(){} // RVA: 0x2DF4830 | overloaded x2
        public void Remove(){} // RVA: 0x2DF4C20 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2DF4E70
        public void TryAdd(){} // RVA: 0x2DF4F40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2DF4F90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2DF4FA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C22FD0
        public void EnsureCapacity(){} // RVA: 0x2DF53B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2DF54A0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2DF5550
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DF56A0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DF5870
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2DF5A40
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C25800
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2DF5B50
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.Type,System.Collections.Generic.List`1<string>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,System.Collections.Generic.List`1<string>> _keys; // 0x38
        public ValueCollection<System.Type,System.Collections.Generic.List`1<string>> _values; // 0x40
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
        public Entry<System.Type,System.Collections.Generic.List`1<System.Reflection.PropertyInfo>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,System.Collections.Generic.List`1<System.Reflection.PropertyInfo>> _keys; // 0x38
        public ValueCollection<System.Type,System.Collections.Generic.List`1<System.Reflection.PropertyInfo>> _values; // 0x40
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
        public Entry<int,SizeGroup<object>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,SizeGroup<object>> _keys; // 0x38
        public ValueCollection<int,SizeGroup<object>> _values; // 0x40
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
        public Entry<0x657CA3B0,string>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x657CA3B0> _comparer; // 0x30
        public KeyCollection<0x657CA3B0,string> _keys; // 0x38
        public ValueCollection<0x657CA3B0,string> _values; // 0x40
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
        public Entry<string,System.Threading.CancellationTokenSource>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Threading.CancellationTokenSource> _keys; // 0x38
        public ValueCollection<string,System.Threading.CancellationTokenSource> _values; // 0x40
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
        public Entry<string,byte>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,byte> _keys; // 0x38
        public ValueCollection<string,byte> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D02E90 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D003A0
        public void set_Item(){} // RVA: 0x2D02F20
        public void Add(){} // RVA: 0x2D02F50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D02F80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D02FD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D03090
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2D03170
        public void CopyTo(){} // RVA: 0x2D00740
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D03250
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D035A0
        public void TryInsert(){} // RVA: 0x2D03720
        public void OnDeserialization(){} // RVA: 0x2D03B60
        public void Resize(){} // RVA: 0x2D040A0 | overloaded x2
        public void Remove(){} // RVA: 0x2D01960 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2D01BD0
        public void TryAdd(){} // RVA: 0x2D04320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D01C80
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D04350
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D04700
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D047F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D021E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D048A0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D04A70
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEAE30
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,SizeGroup<ÏÎÎÌÎÍÍÍÍÍÍÎÌÍÌÍÍÍÏÎÏÌÌ>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,SizeGroup<ÏÎÎÌÎÍÍÍÍÍÍÎÌÍÌÍÍÍÏÎÏÌÌ>> _keys; // 0x38
        public ValueCollection<int,SizeGroup<ÏÎÎÌÎÍÍÍÍÍÍÎÌÍÌÍÍÍÏÎÏÌÌ>> _values; // 0x40
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
        public Entry<string,WebSocketSharp.Net.HttpHeaderInfo>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,WebSocketSharp.Net.HttpHeaderInfo> _keys; // 0x38
        public ValueCollection<string,WebSocketSharp.Net.HttpHeaderInfo> _values; // 0x40
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
        public Entry<string,VRC.Core.ApiFile>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,VRC.Core.ApiFile> _keys; // 0x38
        public ValueCollection<string,VRC.Core.ApiFile> _values; // 0x40
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
        public Entry<string,VRC.Core.APIUIColorPalette>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,VRC.Core.APIUIColorPalette> _keys; // 0x38
        public ValueCollection<string,VRC.Core.APIUIColorPalette> _values; // 0x40
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
        public Entry<0x657CA5C0,VRC.Core.UnityVersion>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x657CA5C0> _comparer; // 0x30
        public KeyCollection<0x657CA5C0,VRC.Core.UnityVersion> _keys; // 0x38
        public ValueCollection<0x657CA5C0,VRC.Core.UnityVersion> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CAD1C0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C780B0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CAD250
        public void set_Item(){} // RVA: 0x2CAD310
        public void Add(){} // RVA: 0x2CAD350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CAD390
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CAD3F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CAD4E0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C868F0
        public void ContainsValue(){} // RVA: 0x2CAD600
        public void CopyTo(){} // RVA: 0x2CAD710
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2CAD840
        public void FindEntry(){} // RVA: 0x2C86D60
        public void Initialize(){} // RVA: 0x2CADB90
        public void TryInsert(){} // RVA: 0x2CADD10
        public void OnDeserialization(){} // RVA: 0x2CAE190
        public void Resize(){} // RVA: 0x2CAEA40 | overloaded x2
        public void Remove(){} // RVA: 0x2CAEE30 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CAF060
        public void TryAdd(){} // RVA: 0x2CAF0E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CAF120
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CAF130
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2CAF530
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CAF620
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CAF6D0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CAF820
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CAF9F0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C88CC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CAFBC0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.ValueTuple`2<ushort,int>,System.ValueTuple`3<...<...>,byte,float>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.ValueTuple`2<ushort,int>> _comparer; // 0x30
        public KeyCollection<System.ValueTuple`2<ushort,int>,System.ValueTuple`3<...<...>,byte,float>> _keys; // 0x38
        public ValueCollection<System.ValueTuple`2<ushort,int>,System.ValueTuple`3<...<...>,byte,float>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C024C0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C02550
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C02570
        public void set_Item(){} // RVA: 0x2C02630
        public void Add(){} // RVA: 0x2C02670
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C026B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C02700
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C027E0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C028E0
        public void ContainsValue(){} // RVA: 0x2C02910
        public void CopyTo(){} // RVA: 0x2C02A00
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2C02B50
        public void FindEntry(){} // RVA: 0x2C02EA0
        public void Initialize(){} // RVA: 0x2C03150
        public void TryInsert(){} // RVA: 0x2C032D0
        public void OnDeserialization(){} // RVA: 0x2C03810
        public void Resize(){} // RVA: 0x2C03D40 | overloaded x2
        public void Remove(){} // RVA: 0x2C04170 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C043D0
        public void TryAdd(){} // RVA: 0x2C04490
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C044D0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C044E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2C048D0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C049C0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C04A70
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C04BB0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C04D80
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C04F50
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C05060
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.Type,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,int> _keys; // 0x38
        public ValueCollection<System.Type,int> _values; // 0x40
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
        public Entry<0x65A0B318,System.Collections.Generic.HashSet`1<System.Type>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x65A0B318> _comparer; // 0x30
        public KeyCollection<0x65A0B318,System.Collections.Generic.HashSet`1<System.Type>> _keys; // 0x38
        public ValueCollection<0x65A0B318,System.Collections.Generic.HashSet`1<System.Type>> _values; // 0x40
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
        public Entry<string,UnityEngine.Texture2D>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,UnityEngine.Texture2D> _keys; // 0x38
        public ValueCollection<string,UnityEngine.Texture2D> _values; // 0x40
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
        public Entry<string,System.Collections.Generic.List`1<...<...>>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Collections.Generic.List`1<...<...>>> _keys; // 0x38
        public ValueCollection<string,System.Collections.Generic.List`1<...<...>>> _values; // 0x40
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
        public Entry<System.ValueTuple`2<string,string>,System.Collections.Generic.IList`1<VRC.Core.UdonAnalytics.UdonAnalyticsEvent>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.ValueTuple`2<string,string>> _comparer; // 0x30
        public KeyCollection<System.ValueTuple`2<string,string>,System.Collections.Generic.IList`1<VRC.Core.UdonAnalytics.UdonAnalyticsEvent>> _keys; // 0x38
        public ValueCollection<System.ValueTuple`2<string,string>,System.Collections.Generic.IList`1<VRC.Core.UdonAnalytics.UdonAnalyticsEvent>> _values; // 0x40
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
        public Entry<string,System.Type>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Type> _keys; // 0x38
        public ValueCollection<string,System.Type> _values; // 0x40
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
        public Entry<int,UnityEngine.GameObject>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,UnityEngine.GameObject> _keys; // 0x38
        public ValueCollection<int,UnityEngine.GameObject> _values; // 0x40
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
        public Entry<int,SizeGroup<float>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,SizeGroup<float>> _keys; // 0x38
        public ValueCollection<int,SizeGroup<float>> _values; // 0x40
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
        public Entry<int,SizeGroup<bool>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,SizeGroup<bool>> _keys; // 0x38
        public ValueCollection<int,SizeGroup<bool>> _values; // 0x40
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
        public Entry<string,RealisticEyeMovements.EyeAndHeadAnimatorForExport>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,RealisticEyeMovements.EyeAndHeadAnimatorForExport> _keys; // 0x38
        public ValueCollection<string,RealisticEyeMovements.EyeAndHeadAnimatorForExport> _values; // 0x40
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
        public Entry<System.Type,System.Runtime.Serialization.Formatters.Binary.TypeInformation>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,System.Runtime.Serialization.Formatters.Binary.TypeInformation> _keys; // 0x38
        public ValueCollection<System.Type,System.Runtime.Serialization.Formatters.Binary.TypeInformation> _values; // 0x40
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
        public Entry<uint,ÌÏÏÎÎÎÌÍÍÍÎÍÌÌÌÍÏÌÎÍÌÏÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<uint> _comparer; // 0x30
        public KeyCollection<uint,ÌÏÏÎÎÎÌÍÍÍÎÍÌÌÌÍÏÌÎÍÌÏÌ> _keys; // 0x38
        public ValueCollection<uint,ÌÏÏÎÎÎÌÍÍÍÎÍÌÌÌÍÏÌÎÍÌÏÌ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDB130 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2DCB280
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2DDB1C0
        public void set_Item(){} // RVA: 0x2DDB260
        public void Add(){} // RVA: 0x2DDB290
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2DDB2C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2DDB300
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2DDB3C0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2DDB4A0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C5AD30
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2DDB4D0
        public void FindEntry(){} // RVA: 0x2DDB820
        public void Initialize(){} // RVA: 0x2DDBA80
        public void TryInsert(){} // RVA: 0x2DDBC00
        public void OnDeserialization(){} // RVA: 0x2DDC0E0
        public void Resize(){} // RVA: 0x2DDC600 | overloaded x2
        public void Remove(){} // RVA: 0x2DDC9E0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2DDCC10
        public void TryAdd(){} // RVA: 0x2DDCCD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C5C450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2DDCD00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2DDD0A0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2DDD190
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2DDD240
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DDD360
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DDD520
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2DDD6E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2DDD7F0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.Reflection.MethodInfo,System.Reflection.ParameterInfo[]>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Reflection.MethodInfo> _comparer; // 0x30
        public KeyCollection<System.Reflection.MethodInfo,System.Reflection.ParameterInfo[]> _keys; // 0x38
        public ValueCollection<System.Reflection.MethodInfo,System.Reflection.ParameterInfo[]> _values; // 0x40
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
        public Entry<string,ÍÌÏÌÌÍÍÍÌÏÌÌÍÍÎÌÏÍÌÍÏÏÏ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÍÌÏÌÌÍÍÍÌÏÌÌÍÍÎÌÏÍÌÍÏÏÏ> _keys; // 0x38
        public ValueCollection<string,ÍÌÏÌÌÍÍÍÌÏÌÌÍÍÎÌÏÍÌÍÏÏÏ> _values; // 0x40
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
        public Entry<string,ÏÎÌÎÏÌÏÏÎÏÍÏÌÌÌÏÎÎÎÏÏÎÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÏÎÌÎÏÌÏÏÎÏÍÏÌÌÌÏÎÎÎÏÏÎÌ> _keys; // 0x38
        public ValueCollection<string,ÏÎÌÎÏÌÏÏÎÏÍÏÌÌÌÏÎÎÎÏÏÎÌ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D44630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CE54B0
        public void set_Item(){} // RVA: 0x2D446C0
        public void Add(){} // RVA: 0x2D44710
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D44760
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D447C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D448C0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE5860
        public void ContainsValue(){} // RVA: 0x2D449E0
        public void CopyTo(){} // RVA: 0x2CE59A0
        public void GetEnumerator(){} // RVA: 0x2C22F20
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C22FD0
        public void GetObjectData(){} // RVA: 0x2D44AF0
        public void FindEntry(){} // RVA: 0x2CE5E80
        public void Initialize(){} // RVA: 0x2D44E40
        public void TryInsert(){} // RVA: 0x2D44FC0
        public void OnDeserialization(){} // RVA: 0x2D45490
        public void Resize(){} // RVA: 0x2D45A00 | overloaded x2
        public void Remove(){} // RVA: 0x2CE7160 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE7400
        public void TryAdd(){} // RVA: 0x2D45C80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CE7520
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D45CD0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C22FD0
        public void EnsureCapacity(){} // RVA: 0x2D460C0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D461B0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CE7AC0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D46260
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D46440
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE7FE0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C25800
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE8100
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.ParticleSystem,ÏÍÎÎÎÌÏÌÌÏÎÍÍÏÌÎÎÏÍÏÌÍÏ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.ParticleSystem> _comparer; // 0x30
        public KeyCollection<UnityEngine.ParticleSystem,ÏÍÎÎÎÌÏÌÌÏÎÍÍÏÌÎÎÏÍÏÌÍÏ> _keys; // 0x38
        public ValueCollection<UnityEngine.ParticleSystem,ÏÍÎÎÎÌÏÌÌÏÎÍÍÏÌÎÎÏÍÏÌÍÏ> _values; // 0x40
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
        public Entry<string,System.ValueTuple`2<string,System.DateTime>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.ValueTuple`2<string,System.DateTime>> _keys; // 0x38
        public ValueCollection<string,System.ValueTuple`2<string,System.DateTime>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CEB740 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CEB7D0
        public void set_Item(){} // RVA: 0x2CEB850
        public void Add(){} // RVA: 0x2CEB890
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CEB8D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CEB920
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CEBA00
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CEBB00
        public void ContainsValue(){} // RVA: 0x2CEBB30
        public void CopyTo(){} // RVA: 0x2CEBC20
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2CEBD80
        public void FindEntry(){} // RVA: 0x2CEC0D0
        public void Initialize(){} // RVA: 0x2CEC310
        public void TryInsert(){} // RVA: 0x2CEC490
        public void OnDeserialization(){} // RVA: 0x2CEC950
        public void Resize(){} // RVA: 0x2CECEA0 | overloaded x2
        public void Remove(){} // RVA: 0x2CED390 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CED610
        public void TryAdd(){} // RVA: 0x2CED6D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CED710
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CED720
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2CEDB00
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CEDBF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CEDCA0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CEDDF0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CEDFD0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CEE1B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEE2D0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.Type,System.Collections.Generic.Stack`1<object>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,System.Collections.Generic.Stack`1<object>> _keys; // 0x38
        public ValueCollection<System.Type,System.Collections.Generic.Stack`1<object>> _values; // 0x40
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
        public Entry<int,SizeGroup<System.Collections.Generic.List`1<ÎÏÏÌÎÎÍÍÏÍÎÏÌÎÏÍÎÍÍÍÍÏÎ>>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,SizeGroup<System.Collections.Generic.List`1<ÎÏÏÌÎÎÍÍÏÍÎÏÌÎÏÍÎÍÍÍÍÏÎ>>> _keys; // 0x38
        public ValueCollection<int,SizeGroup<System.Collections.Generic.List`1<ÎÏÏÌÎÎÍÍÏÍÎÏÌÎÏÍÎÍÍÍÍÏÎ>>> _values; // 0x40
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
        public Entry<int,byte[]>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,byte[]> _keys; // 0x38
        public ValueCollection<int,byte[]> _values; // 0x40
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
        public Entry<0x65916C98,Serializer32>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x65916C98> _comparer; // 0x30
        public KeyCollection<0x65916C98,Serializer32> _keys; // 0x38
        public ValueCollection<0x65916C98,Serializer32> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CB70E0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C780B0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CB3910
        public void set_Item(){} // RVA: 0x2CB7170
        public void Add(){} // RVA: 0x2CB71D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CB7230
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CB72A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CB73D0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CB3D90
        public void ContainsValue(){} // RVA: 0x2CB7520
        public void CopyTo(){} // RVA: 0x2CB3F10
        public void GetEnumerator(){} // RVA: 0x2C656F0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C657B0
        public void GetObjectData(){} // RVA: 0x2CB7670
        public void FindEntry(){} // RVA: 0x2CB4420
        public void Initialize(){} // RVA: 0x2CB79C0
        public void TryInsert(){} // RVA: 0x2CB7B40
        public void OnDeserialization(){} // RVA: 0x2CB8070
        public void Resize(){} // RVA: 0x2CB85E0 | overloaded x2
        public void Remove(){} // RVA: 0x2CB56D0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CB5940
        public void TryAdd(){} // RVA: 0x2CB87E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CB5A80
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CB8840
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C657B0
        public void EnsureCapacity(){} // RVA: 0x2CB8CC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CB8DB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CB60B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CB8E60
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CB9050
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CB65F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C681E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CB6700
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<0x65916C98,Serializer>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x65916C98> _comparer; // 0x30
        public KeyCollection<0x65916C98,Serializer> _keys; // 0x38
        public ValueCollection<0x65916C98,Serializer> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CB3880 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C780B0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CB3910
        public void set_Item(){} // RVA: 0x2CB39E0
        public void Add(){} // RVA: 0x2CB3A40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CB3AA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CB3B10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CB3C40
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CB3D90
        public void ContainsValue(){} // RVA: 0x2CB3DC0
        public void CopyTo(){} // RVA: 0x2CB3F10
        public void GetEnumerator(){} // RVA: 0x2C656F0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C657B0
        public void GetObjectData(){} // RVA: 0x2CB40D0
        public void FindEntry(){} // RVA: 0x2CB4420
        public void Initialize(){} // RVA: 0x2CB46A0
        public void TryInsert(){} // RVA: 0x2CB4820
        public void OnDeserialization(){} // RVA: 0x2CB4D50
        public void Resize(){} // RVA: 0x2CB52C0 | overloaded x2
        public void Remove(){} // RVA: 0x2CB56D0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CB5940
        public void TryAdd(){} // RVA: 0x2CB5A20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CB5A80
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CB5A90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C657B0
        public void EnsureCapacity(){} // RVA: 0x2CB5F10
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CB6000
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CB60B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CB6210
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CB6400
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CB65F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C681E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CB6700
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,SizeGroup<byte>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,SizeGroup<byte>> _keys; // 0x38
        public ValueCollection<int,SizeGroup<byte>> _values; // 0x40
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
        public Entry<System.Type,TypeHandler>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,TypeHandler> _keys; // 0x38
        public ValueCollection<System.Type,TypeHandler> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D86EB0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CF3BD0
        public void set_Item(){} // RVA: 0x2D86F40
        public void Add(){} // RVA: 0x2D86F90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D86FE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D87050
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D87170
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CF3FD0
        public void ContainsValue(){} // RVA: 0x2D872A0
        public void CopyTo(){} // RVA: 0x2CF4130
        public void GetEnumerator(){} // RVA: 0x2C26A50
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C26B00
        public void GetObjectData(){} // RVA: 0x2D873D0
        public void FindEntry(){} // RVA: 0x2CF4630
        public void Initialize(){} // RVA: 0x2D87720
        public void TryInsert(){} // RVA: 0x2D878A0
        public void OnDeserialization(){} // RVA: 0x2D87DC0
        public void Resize(){} // RVA: 0x2D88340 | overloaded x2
        public void Remove(){} // RVA: 0x2CF5970 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CF5C10
        public void TryAdd(){} // RVA: 0x2D885C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CF5D30
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D88610
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C26B00
        public void EnsureCapacity(){} // RVA: 0x2D88A40
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D88B30
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CF6310
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D88BE0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D88DD0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CF6850
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C29540
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CF6970
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.Type,object>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,object> _keys; // 0x38
        public ValueCollection<System.Type,object> _values; // 0x40
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
        public Entry<int,SizeGroup<int>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,SizeGroup<int>> _keys; // 0x38
        public ValueCollection<int,SizeGroup<int>> _values; // 0x40
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
        public Entry<int,SizeGroup<UnityEngine.Mesh>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,SizeGroup<UnityEngine.Mesh>> _keys; // 0x38
        public ValueCollection<int,SizeGroup<UnityEngine.Mesh>> _values; // 0x40
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
        public Entry<0x65898078,float>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x65898078> _comparer; // 0x30
        public KeyCollection<0x65898078,float> _keys; // 0x38
        public ValueCollection<0x65898078,float> _values; // 0x40
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
        public Entry<0x65898180,float>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x65898180> _comparer; // 0x30
        public KeyCollection<0x65898180,float> _keys; // 0x38
        public ValueCollection<0x65898180,float> _values; // 0x40
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
        public Entry<System.Threading.IAsyncLocal,object>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Threading.IAsyncLocal> _comparer; // 0x30
        public KeyCollection<System.Threading.IAsyncLocal,object> _keys; // 0x38
        public ValueCollection<System.Threading.IAsyncLocal,object> _values; // 0x40
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
        public Entry<object,ÌÍÏÌÌÍÏÏÌÌÌÌÌÍÌÎÌÏÏÏÌÏÎ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<object> _comparer; // 0x30
        public KeyCollection<object,ÌÍÏÌÌÍÏÏÌÌÌÌÌÍÌÎÌÏÏÏÌÏÎ> _keys; // 0x38
        public ValueCollection<object,ÌÍÏÌÌÍÏÏÌÌÌÌÌÍÌÎÌÏÏÏÌÏÎ> _values; // 0x40
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
        public Entry<UnityEngine.GameObject,System.Collections.Generic.List`1<ÌÍÏÌÌÍÏÏÌÌÌÌÌÍÌÎÌÏÏÏÌÏÎ>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.GameObject> _comparer; // 0x30
        public KeyCollection<UnityEngine.GameObject,System.Collections.Generic.List`1<ÌÍÏÌÌÍÏÏÌÌÌÌÌÍÌÎÌÏÏÏÌÏÎ>> _keys; // 0x38
        public ValueCollection<UnityEngine.GameObject,System.Collections.Generic.List`1<ÌÍÏÌÌÍÏÏÌÌÌÌÌÍÌÎÌÏÏÏÌÏÎ>> _values; // 0x40
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
        public Entry<byte,byte[]>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<byte> _comparer; // 0x30
        public KeyCollection<byte,byte[]> _keys; // 0x38
        public ValueCollection<byte,byte[]> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C0C6D0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C09000
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C0C760
        public void set_Item(){} // RVA: 0x2C0C800
        public void Add(){} // RVA: 0x2C0C830
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C0C860
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C0C8B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C0C970
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C0CA50
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2C0CBB0
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2C0CE70
        public void FindEntry(){} // RVA: 0x2C0D1C0
        public void Initialize(){} // RVA: 0x2C0D420
        public void TryInsert(){} // RVA: 0x2C0D5A0
        public void OnDeserialization(){} // RVA: 0x2C0DA90
        public void Resize(){} // RVA: 0x2C0DFB0 | overloaded x2
        public void Remove(){} // RVA: 0x2C0E3A0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C0E5D0
        public void TryAdd(){} // RVA: 0x2C0E690
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C0E6C0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C0E6D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2C0EA70
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C0EB60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C0EC30
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C0ED50
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C0EF10
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C0F0D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C0F2C0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<0x65971898,VRC.Profiling.ProfilerMarker>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x65971898> _comparer; // 0x30
        public KeyCollection<0x65971898,VRC.Profiling.ProfilerMarker> _keys; // 0x38
        public ValueCollection<0x65971898,VRC.Profiling.ProfilerMarker> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C864F0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C780B0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C86580
        public void set_Item(){} // RVA: 0x2C86640
        public void Add(){} // RVA: 0x2C86680
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C866C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C86710
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C867F0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C868F0
        public void ContainsValue(){} // RVA: 0x2C86920
        public void CopyTo(){} // RVA: 0x2C69410
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2C86A10
        public void FindEntry(){} // RVA: 0x2C86D60
        public void Initialize(){} // RVA: 0x2C86FC0
        public void TryInsert(){} // RVA: 0x2C87140
        public void OnDeserialization(){} // RVA: 0x2C87620
        public void Resize(){} // RVA: 0x2C87B50 | overloaded x2
        public void Remove(){} // RVA: 0x2C87F40 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C88170
        public void TryAdd(){} // RVA: 0x2C88230
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C6A970
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C88270
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2C88660
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C88750
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C88800
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C88940
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C88B00
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C88CC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C88DD0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<long,System.Collections.Generic.Dictionary`2<string,float>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<long> _comparer; // 0x30
        public KeyCollection<long,System.Collections.Generic.Dictionary`2<string,float>> _keys; // 0x38
        public ValueCollection<long,System.Collections.Generic.Dictionary`2<string,float>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CC1460 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CBD800
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CC14F0
        public void set_Item(){} // RVA: 0x2CC1590
        public void Add(){} // RVA: 0x2CC15C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CC15F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CC1640
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CC1700
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CC17E0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2CC1810
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2CC1950
        public void FindEntry(){} // RVA: 0x2CC1CA0
        public void Initialize(){} // RVA: 0x2CC1F20
        public void TryInsert(){} // RVA: 0x2CC20A0
        public void OnDeserialization(){} // RVA: 0x2CC2580
        public void Resize(){} // RVA: 0x2CC2AA0 | overloaded x2
        public void Remove(){} // RVA: 0x2CC2E90 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CC30C0
        public void TryAdd(){} // RVA: 0x2CC3180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CC31B0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CC31C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2CC3550
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CC3640
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CC36F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CC3810
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CC39D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CC3B90
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CC3CA0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,float>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,float> _keys; // 0x38
        public ValueCollection<string,float> _values; // 0x40
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
        public Entry<string,ÏÏÍÎÏÍÏÍÍÎÏÍÏÌÌÍÍÍÌÏÏÎÎ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÏÏÍÎÏÍÏÍÍÎÏÍÏÌÌÍÍÍÌÏÏÎÎ> _keys; // 0x38
        public ValueCollection<string,ÏÏÍÎÏÍÏÍÍÎÏÍÏÌÌÍÍÍÌÏÏÎÎ> _values; // 0x40
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
        public Entry<int,ÌÍÎÍÎÌÎÌÎÏÏÎÍÏÌÏÎÌÏÍÎÎÎ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,ÌÍÎÍÎÌÎÌÎÏÏÎÍÏÌÏÎÌÏÍÎÎÎ> _keys; // 0x38
        public ValueCollection<int,ÌÍÎÍÎÌÎÌÎÏÏÎÍÏÌÏÎÌÏÍÎÎÎ> _values; // 0x40
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
        public Entry<UnityEngine.Material,UnityEngine.Material>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Material> _comparer; // 0x30
        public KeyCollection<UnityEngine.Material,UnityEngine.Material> _keys; // 0x38
        public ValueCollection<UnityEngine.Material,UnityEngine.Material> _values; // 0x40
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
        public Entry<0x65972C88,string>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x65972C88> _comparer; // 0x30
        public KeyCollection<0x65972C88,string> _keys; // 0x38
        public ValueCollection<0x65972C88,string> _values; // 0x40
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
        public Entry<0x659729C8,string>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x659729C8> _comparer; // 0x30
        public KeyCollection<0x659729C8,string> _keys; // 0x38
        public ValueCollection<0x659729C8,string> _values; // 0x40
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
        public Entry<0x65713298,ÏÌÏÍÍÍÍÏÎÌÍÏÎÍÍÌÎÍÏÌÌÌÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x65713298> _comparer; // 0x30
        public KeyCollection<0x65713298,ÏÌÏÍÍÍÍÏÎÌÍÏÎÍÍÌÎÍÏÌÌÌÌ> _keys; // 0x38
        public ValueCollection<0x65713298,ÏÌÏÍÍÍÍÏÎÌÍÏÎÍÍÌÎÍÏÌÌÌÌ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CB9AC0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C780B0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CB9B50
        public void set_Item(){} // RVA: 0x2CB9C10
        public void Add(){} // RVA: 0x2CB9C50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CB9C90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CB9CF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CB9DF0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CB9F10
        public void ContainsValue(){} // RVA: 0x2CB9F40
        public void CopyTo(){} // RVA: 0x2CBA060
        public void GetEnumerator(){} // RVA: 0x2C74EE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C74F90
        public void GetObjectData(){} // RVA: 0x2CBA1E0
        public void FindEntry(){} // RVA: 0x2CBA530
        public void Initialize(){} // RVA: 0x2CBA7B0
        public void TryInsert(){} // RVA: 0x2CBA930
        public void OnDeserialization(){} // RVA: 0x2CBAE40
        public void Resize(){} // RVA: 0x2CBB390 | overloaded x2
        public void Remove(){} // RVA: 0x2CBB790 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CBB9E0
        public void TryAdd(){} // RVA: 0x2CBBAB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CBBAF0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CBBB00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C74F90
        public void EnsureCapacity(){} // RVA: 0x2CBBF30
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CBC020
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CBC0D0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CBC220
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CBC3F0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CBC5C0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C77580
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CBC6D0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.Animations.ParentConstraint,UnityEngine.Vector3[]>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Animations.ParentConstraint> _comparer; // 0x30
        public KeyCollection<UnityEngine.Animations.ParentConstraint,UnityEngine.Vector3[]> _keys; // 0x38
        public ValueCollection<UnityEngine.Animations.ParentConstraint,UnityEngine.Vector3[]> _values; // 0x40
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
        public Entry<VRC.Dynamics.ManagedTypes.VRCParentConstraintBase,UnityEngine.Vector3[]>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.Dynamics.ManagedTypes.VRCParentConstraintBase> _comparer; // 0x30
        public KeyCollection<VRC.Dynamics.ManagedTypes.VRCParentConstraintBase,UnityEngine.Vector3[]> _keys; // 0x38
        public ValueCollection<VRC.Dynamics.ManagedTypes.VRCParentConstraintBase,UnityEngine.Vector3[]> _values; // 0x40
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