// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Generic
// Classes: 100
// Methods: 5046

namespace ThirdParty.DotNet.System.Collections.Generic
{
    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ÍÎÌÏÏÌÌÏÍÎÌÎÎÎÌÎÍÏÎÏÏÍÍ,ÌÏÌÏÏÌÎÌÏÏÌÌÏÌÎÌÏÌÍÏÎÌÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÍÎÌÏÏÌÌÏÍÎÌÎÎÎÌÎÍÏÎÏÏÍÍ> _comparer; // 0x30
        public KeyCollection<ÍÎÌÏÏÌÌÏÍÎÌÎÎÎÌÎÍÏÎÏÏÍÍ,ÌÏÌÏÏÌÎÌÏÏÌÌÏÌÎÌÏÌÍÏÎÌÌ> _keys; // 0x38
        public ValueCollection<ÍÎÌÏÏÌÌÏÍÎÌÎÎÎÌÎÍÏÎÏÏÍÍ,ÌÏÌÏÏÌÎÌÏÏÌÌÏÌÎÌÏÌÍÏÎÌÌ> _values; // 0x40
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
        public Entry<0x65888FD8,bool>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x65888FD8> _comparer; // 0x30
        public KeyCollection<0x65888FD8,bool> _keys; // 0x38
        public ValueCollection<0x65888FD8,bool> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C12F60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C12FF0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C13010
        public void set_Item(){} // RVA: 0x2C130B0
        public void Add(){} // RVA: 0x2C130E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C13110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C13160
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C13220
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C13300
        public void ContainsValue(){} // RVA: 0x2C13330
        public void CopyTo(){} // RVA: 0x2C13400
        public void GetEnumerator(){} // RVA: 0x2C134F0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C13580
        public void GetObjectData(){} // RVA: 0x2C13650
        public void FindEntry(){} // RVA: 0x2C139A0
        public void Initialize(){} // RVA: 0x2C13C10
        public void TryInsert(){} // RVA: 0x2C13D90
        public void OnDeserialization(){} // RVA: 0x2C14210
        public void Resize(){} // RVA: 0x2C14720 | overloaded x2
        public void Remove(){} // RVA: 0x2C14B10 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C14D30
        public void TryAdd(){} // RVA: 0x2C14DA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C14DD0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C14DE0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C13580
        public void EnsureCapacity(){} // RVA: 0x2C151A0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C15290
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C15340
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C15480
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C15640
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C15800
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C15910
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C159E0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ÍÏÍÍÌÏÍÎÏÏÍÏÏÎÍÌÏÍÏÍÍÍÎ,ÎÏÍÌÌÏÏÎÍÏÍÍÏÌÏÍÍÍÏÍÏÏÍ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÍÏÍÍÌÏÍÎÏÏÍÏÏÎÍÌÏÍÏÍÍÍÎ> _comparer; // 0x30
        public KeyCollection<ÍÏÍÍÌÏÍÎÏÏÍÏÏÎÍÌÏÍÏÍÍÍÎ,ÎÏÍÌÌÏÏÎÍÏÍÍÏÌÏÍÍÍÏÍÏÏÍ> _keys; // 0x38
        public ValueCollection<ÍÏÍÍÌÏÍÎÏÏÍÏÏÎÍÌÏÍÏÍÍÍÎ,ÎÏÍÌÌÏÏÎÍÏÍÍÏÌÏÍÍÍÏÍÏÏÍ> _values; // 0x40
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
        public Entry<ÍÍÎÌÍÎÏÏÏÌÍÍÏÏÏÌÌÎÌÏÍÍÌ,ÍÌÍÎÏÏÎÎÏÍÎÌÌÍÌÌÏÎÌÍÌÎÏ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÍÍÎÌÍÎÏÏÏÌÍÍÏÏÏÌÌÎÌÏÍÍÌ> _comparer; // 0x30
        public KeyCollection<ÍÍÎÌÍÎÏÏÏÌÍÍÏÏÏÌÌÎÌÏÍÍÌ,ÍÌÍÎÏÏÎÎÏÍÎÌÌÍÌÌÏÎÌÍÌÎÏ> _keys; // 0x38
        public ValueCollection<ÍÍÎÌÍÎÏÏÏÌÍÍÏÏÏÌÌÎÌÏÍÍÌ,ÍÌÍÎÏÏÎÎÏÍÎÌÌÍÌÌÏÎÌÍÌÎÏ> _values; // 0x40
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
        public Entry<ÌÍÍÎÎÌÏÌÍÏÌÌÏÌÌÏÌÍÎÏÍÌÏ,ÍÍÎÌÍÎÏÏÏÌÍÍÏÏÏÌÌÎÌÏÍÍÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÌÍÍÎÎÌÏÌÍÏÌÌÏÌÌÏÌÍÎÏÍÌÏ> _comparer; // 0x30
        public KeyCollection<ÌÍÍÎÎÌÏÌÍÏÌÌÏÌÌÏÌÍÎÏÍÌÏ,ÍÍÎÌÍÎÏÏÏÌÍÍÏÏÏÌÌÎÌÏÍÍÌ> _keys; // 0x38
        public ValueCollection<ÌÍÍÎÎÌÏÌÍÏÌÌÏÌÌÏÌÍÎÏÍÌÏ,ÍÍÎÌÍÎÏÏÏÌÍÍÏÏÏÌÌÎÌÏÍÍÌ> _values; // 0x40
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
        public Entry<string,ÎÍÍÍÏÍÌÍÏÏÍÍÌÍÎÏÌÌÍÏÍÏÎ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÎÍÍÍÏÍÌÍÏÏÍÍÌÍÎÏÌÌÍÏÍÏÎ> _keys; // 0x38
        public ValueCollection<string,ÎÍÍÍÏÍÌÍÏÏÍÍÌÍÎÏÌÌÍÏÍÏÎ> _values; // 0x40
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
        public Entry<string,ÏÎÌÍÎÌÏÏÏÍÎÍÍÏÏÍÌÍÍÏÍÍÏ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÏÎÌÍÎÌÏÏÏÍÎÍÍÏÏÍÌÍÍÏÍÍÏ> _keys; // 0x38
        public ValueCollection<string,ÏÎÌÍÎÌÏÏÏÍÎÍÍÏÏÍÌÍÍÏÍÍÏ> _values; // 0x40
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
        public Entry<string,ÍÎÍÏÍÏÏÎÎÎÎÎÌÎÍÍÏÌÎÍÎÌÍ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÍÎÍÏÍÏÏÎÎÎÎÎÌÎÍÍÏÌÎÍÎÌÍ> _keys; // 0x38
        public ValueCollection<string,ÍÎÍÏÍÏÏÎÎÎÎÎÌÎÍÍÏÌÎÍÎÌÍ> _values; // 0x40
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
        public Entry<int,ÏÎÎÌÎÍÍÍÍÍÍÎÌÍÌÍÍÍÏÎÏÌÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,ÏÎÎÌÎÍÍÍÍÍÍÎÌÍÌÍÍÍÏÎÏÌÌ> _keys; // 0x38
        public ValueCollection<int,ÏÎÎÌÎÍÍÍÍÍÍÎÌÍÌÍÍÍÏÎÏÌÌ> _values; // 0x40
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
        public Entry<UnityEngine.GameObject,ÏÎÎÌÎÍÍÍÍÍÍÎÌÍÌÍÍÍÏÎÏÌÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.GameObject> _comparer; // 0x30
        public KeyCollection<UnityEngine.GameObject,ÏÎÎÌÎÍÍÍÍÍÍÎÌÍÌÍÍÍÏÎÏÌÌ> _keys; // 0x38
        public ValueCollection<UnityEngine.GameObject,ÏÎÎÌÎÍÍÍÍÍÍÎÌÍÌÍÍÍÏÎÏÌÌ> _values; // 0x40
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
        public Entry<string,VRC.Core.ApiAvatarPart>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,VRC.Core.ApiAvatarPart> _keys; // 0x38
        public ValueCollection<string,VRC.Core.ApiAvatarPart> _values; // 0x40
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
        public Entry<string,VRC.Core.ApiProp>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,VRC.Core.ApiProp> _keys; // 0x38
        public ValueCollection<string,VRC.Core.ApiProp> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,UnityEngine.UIElements.StyleComplexSelector>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,UnityEngine.UIElements.StyleComplexSelector> _keys; // 0x38
        public ValueCollection<string,UnityEngine.UIElements.StyleComplexSelector> _values; // 0x40
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
        public Entry<System.Type,System.Func`2<string,...<...>>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,System.Func`2<string,...<...>>> _keys; // 0x38
        public ValueCollection<System.Type,System.Func`2<string,...<...>>> _values; // 0x40
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
        public Entry<uint,UnityEngine.TextCore.Text.Character>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<uint> _comparer; // 0x30
        public KeyCollection<uint,UnityEngine.TextCore.Text.Character> _keys; // 0x38
        public ValueCollection<uint,UnityEngine.TextCore.Text.Character> _values; // 0x40
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
        public Entry<uint,System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<uint> _comparer; // 0x30
        public KeyCollection<uint,System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord>> _keys; // 0x38
        public ValueCollection<uint,System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord>> _values; // 0x40
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
        public Entry<uint,UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<uint> _comparer; // 0x30
        public KeyCollection<uint,UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> _keys; // 0x38
        public ValueCollection<uint,UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DCB1F0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2DCB280
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2DCB2A0
        public void set_Item(){} // RVA: 0x2DCB370
        public void Add(){} // RVA: 0x2DCB3D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2DCB430
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2DCB4A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2DCB5D0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2DCB710
        public void ContainsValue(){} // RVA: 0x2DCB740
        public void CopyTo(){} // RVA: 0x2DCB880
        public void GetEnumerator(){} // RVA: 0x2C26A50
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C26B00
        public void GetObjectData(){} // RVA: 0x2DCB9E0
        public void FindEntry(){} // RVA: 0x2DCBD30
        public void Initialize(){} // RVA: 0x2DCBF90
        public void TryInsert(){} // RVA: 0x2DCC110
        public void OnDeserialization(){} // RVA: 0x2DCC5F0
        public void Resize(){} // RVA: 0x2DCCED0 | overloaded x2
        public void Remove(){} // RVA: 0x2DCD2B0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2DCD500
        public void TryAdd(){} // RVA: 0x2DCD5A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2DCD600
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2DCD610
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C26B00
        public void EnsureCapacity(){} // RVA: 0x2DCDA50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2DCDB40
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2DCDBF0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DCDD50
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DCDF40
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2DCE130
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C29540
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2DCE240
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<uint,UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<uint> _comparer; // 0x30
        public KeyCollection<uint,UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> _keys; // 0x38
        public ValueCollection<uint,UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD50D0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2DCB280
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2DD5160
        public void set_Item(){} // RVA: 0x2DD5220
        public void Add(){} // RVA: 0x2DD5270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2DD52C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2DD5320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2DD5420
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2DD5540
        public void ContainsValue(){} // RVA: 0x2DD5570
        public void CopyTo(){} // RVA: 0x2C49E10
        public void GetEnumerator(){} // RVA: 0x2C49F50
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C4A000
        public void GetObjectData(){} // RVA: 0x2DD5680
        public void FindEntry(){} // RVA: 0x2DD59D0
        public void Initialize(){} // RVA: 0x2DD5C40
        public void TryInsert(){} // RVA: 0x2DD5DC0
        public void OnDeserialization(){} // RVA: 0x2DD6260
        public void Resize(){} // RVA: 0x2DD6B10 | overloaded x2
        public void Remove(){} // RVA: 0x2DD6EF0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2DD7120
        public void TryAdd(){} // RVA: 0x2DD71B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C4BC70
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2DD7200
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C4A000
        public void EnsureCapacity(){} // RVA: 0x2DD7610
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2DD7700
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2DD77B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DD7900
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DD7AD0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2DD7CA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C4C830
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2DD7DB0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<uint,UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<uint> _comparer; // 0x30
        public KeyCollection<uint,UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> _keys; // 0x38
        public ValueCollection<uint,UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD86F0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2DCB280
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2DD5160
        public void set_Item(){} // RVA: 0x2DD8780
        public void Add(){} // RVA: 0x2DD87D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2DD8820
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2DD8880
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2DD8980
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2DD5540
        public void ContainsValue(){} // RVA: 0x2DD8AA0
        public void CopyTo(){} // RVA: 0x2C49E10
        public void GetEnumerator(){} // RVA: 0x2C49F50
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C4A000
        public void GetObjectData(){} // RVA: 0x2DD8BB0
        public void FindEntry(){} // RVA: 0x2DD59D0
        public void Initialize(){} // RVA: 0x2DD8F00
        public void TryInsert(){} // RVA: 0x2DD9080
        public void OnDeserialization(){} // RVA: 0x2DD9520
        public void Resize(){} // RVA: 0x2DD9DD0 | overloaded x2
        public void Remove(){} // RVA: 0x2DD6EF0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2DD7120
        public void TryAdd(){} // RVA: 0x2DD9FC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C4BC70
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2DDA010
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C4A000
        public void EnsureCapacity(){} // RVA: 0x2DDA420
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2DDA510
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2DD77B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DDA5C0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DDA790
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2DD7CA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C4C830
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2DD7DB0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<uint,UnityEngine.TextCore.Text.SpriteCharacter>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<uint> _comparer; // 0x30
        public KeyCollection<uint,UnityEngine.TextCore.Text.SpriteCharacter> _keys; // 0x38
        public ValueCollection<uint,UnityEngine.TextCore.Text.SpriteCharacter> _values; // 0x40
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
        public Entry<uint,UnityEngine.TextCore.Text.SpriteGlyph>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<uint> _comparer; // 0x30
        public KeyCollection<uint,UnityEngine.TextCore.Text.SpriteGlyph> _keys; // 0x38
        public ValueCollection<uint,UnityEngine.TextCore.Text.SpriteGlyph> _values; // 0x40
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
        public Entry<string,ÏÏÍÌÎÍÎÏÎÌÏÏÏÍÍÍÍÌÎÌÏÎÎ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÏÏÍÌÎÍÎÏÎÌÏÏÏÍÍÍÍÌÎÌÏÎÎ> _keys; // 0x38
        public ValueCollection<string,ÏÏÍÌÎÍÎÏÎÌÏÏÏÍÍÍÍÌÎÌÏÎÎ> _values; // 0x40
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
        public Entry<int,UnityEngine.TextCore.Text.TextStyle>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,UnityEngine.TextCore.Text.TextStyle> _keys; // 0x38
        public ValueCollection<int,UnityEngine.TextCore.Text.TextStyle> _values; // 0x40
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
        public Entry<int,UnityEngine.TextCore.Text.FontAsset>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,UnityEngine.TextCore.Text.FontAsset> _keys; // 0x38
        public ValueCollection<int,UnityEngine.TextCore.Text.FontAsset> _values; // 0x40
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
        public Entry<string,UnityEngine.UIElements.StyleSheets.StylePropertyValue>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,UnityEngine.UIElements.StyleSheets.StylePropertyValue> _keys; // 0x38
        public ValueCollection<string,UnityEngine.UIElements.StyleSheets.StylePropertyValue> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D32560 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CEB7D0
        public void set_Item(){} // RVA: 0x2D325F0
        public void Add(){} // RVA: 0x2D32630
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D32670
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D326C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D327A0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CEBB00
        public void ContainsValue(){} // RVA: 0x2D328A0
        public void CopyTo(){} // RVA: 0x2CEBC20
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2D32990
        public void FindEntry(){} // RVA: 0x2CEC0D0
        public void Initialize(){} // RVA: 0x2D32CE0
        public void TryInsert(){} // RVA: 0x2D32E60
        public void OnDeserialization(){} // RVA: 0x2D33320
        public void Resize(){} // RVA: 0x2D33870 | overloaded x2
        public void Remove(){} // RVA: 0x2CED390 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CED610
        public void TryAdd(){} // RVA: 0x2D33B00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CED710
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D33B40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2D33F20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D34010
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CEDCA0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D340C0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D342A0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CEE1B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEE2D0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ÏÏÎÏÏÎÏÌÏÎÍÏÍÎÏÎÌÌÌÎÎÎÍ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÏÏÎÏÏÎÏÌÏÎÍÏÍÎÏÎÌÌÌÎÎÎÍ> _keys; // 0x38
        public ValueCollection<string,ÏÏÎÏÏÎÏÌÏÎÍÏÍÎÏÎÌÌÌÎÎÎÍ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DA2240 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CEB7D0
        public void set_Item(){} // RVA: 0x2DA22D0
        public void Add(){} // RVA: 0x2DA2310
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2DA2350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2DA23A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2DA2480
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CEBB00
        public void ContainsValue(){} // RVA: 0x2DA2580
        public void CopyTo(){} // RVA: 0x2DA2670
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2DA27D0
        public void FindEntry(){} // RVA: 0x2CEC0D0
        public void Initialize(){} // RVA: 0x2DA2B20
        public void TryInsert(){} // RVA: 0x2DA2CA0
        public void OnDeserialization(){} // RVA: 0x2DA3160
        public void Resize(){} // RVA: 0x2DA36B0 | overloaded x2
        public void Remove(){} // RVA: 0x2D85570 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2D857F0
        public void TryAdd(){} // RVA: 0x2DA3940
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2DA3980
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2DA3990
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2DA3D70
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2DA3E60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CEDCA0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DA3F10
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DA40F0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CEE1B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEE2D0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,VRC.Core.ApiWorld>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,VRC.Core.ApiWorld> _keys; // 0x38
        public ValueCollection<string,VRC.Core.ApiWorld> _values; // 0x40
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
        public Entry<System.Type,System.Reflection.MethodInfo>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,System.Reflection.MethodInfo> _keys; // 0x38
        public ValueCollection<System.Type,System.Reflection.MethodInfo> _values; // 0x40
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
        public Entry<string,VRC.Core.ApiContainer>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,VRC.Core.ApiContainer> _keys; // 0x38
        public ValueCollection<string,VRC.Core.ApiContainer> _values; // 0x40
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
        public Entry<System.Type,System.Collections.Generic.Dictionary`2<System.ReadOnlyMemory`1<char>,object>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,System.Collections.Generic.Dictionary`2<System.ReadOnlyMemory`1<char>,object>> _keys; // 0x38
        public ValueCollection<System.Type,System.Collections.Generic.Dictionary`2<System.ReadOnlyMemory`1<char>,object>> _values; // 0x40
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
        public Entry<System.Type,System.Collections.Generic.Dictionary`2<string,System.Reflection.PropertyInfo>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,System.Collections.Generic.Dictionary`2<string,System.Reflection.PropertyInfo>> _keys; // 0x38
        public ValueCollection<System.Type,System.Collections.Generic.Dictionary`2<string,System.Reflection.PropertyInfo>> _values; // 0x40
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
        public Entry<System.Reflection.PropertyInfo,string>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Reflection.PropertyInfo> _comparer; // 0x30
        public KeyCollection<System.Reflection.PropertyInfo,string> _keys; // 0x38
        public ValueCollection<System.Reflection.PropertyInfo,string> _values; // 0x40
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
        public Entry<int,System.Collections.Generic.HashSet`1<string>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,System.Collections.Generic.HashSet`1<string>> _keys; // 0x38
        public ValueCollection<int,System.Collections.Generic.HashSet`1<string>> _values; // 0x40
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
        public Entry<DG.Tweening.Tween,DG.Tweening.Core.TweenLink>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<DG.Tweening.Tween> _comparer; // 0x30
        public KeyCollection<DG.Tweening.Tween,DG.Tweening.Core.TweenLink> _keys; // 0x38
        public ValueCollection<DG.Tweening.Tween,DG.Tweening.Core.TweenLink> _values; // 0x40
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
        public Entry<ÍÍÎÍÏÌÍÎÏÏÌÌÍÎÏÎÌÍÎÌÏÏÍ,UnityEngine.Texture2D>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÍÍÎÍÏÌÍÎÏÏÌÌÍÎÏÎÌÍÎÌÏÏÍ> _comparer; // 0x30
        public KeyCollection<ÍÍÎÍÏÌÍÎÏÏÌÌÍÎÏÎÌÍÎÌÏÏÍ,UnityEngine.Texture2D> _keys; // 0x38
        public ValueCollection<ÍÍÎÍÏÌÍÎÏÏÌÌÍÎÏÎÌÍÎÌÏÏÍ,UnityEngine.Texture2D> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E26630 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2E22E60
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2E266C0
        public void set_Item(){} // RVA: 0x2E26790
        public void Add(){} // RVA: 0x2E267D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2E26810
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2E26870
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2E26940
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2E26A60
        public void ContainsValue(){} // RVA: 0x2DB1590
        public void CopyTo(){} // RVA: 0x2E04FB0
        public void GetEnumerator(){} // RVA: 0x2C22F20
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C22FD0
        public void GetObjectData(){} // RVA: 0x2E26AA0
        public void FindEntry(){} // RVA: 0x2E26DF0
        public void Initialize(){} // RVA: 0x2E27150
        public void TryInsert(){} // RVA: 0x2E272D0
        public void OnDeserialization(){} // RVA: 0x2E27970
        public void Resize(){} // RVA: 0x2E27EC0 | overloaded x2
        public void Remove(){} // RVA: 0x2E283A0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2E286A0
        public void TryAdd(){} // RVA: 0x2E28770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2E06D30
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2E287B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C22FD0
        public void EnsureCapacity(){} // RVA: 0x2E28B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2E28C70
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2E28D20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2E28E50
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2E29040
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2E29230
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C25800
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2E29360
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ÍÍÎÍÏÌÍÎÏÏÌÌÍÎÏÎÌÍÎÌÏÏÍ,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÍÍÎÍÏÌÍÎÏÏÌÌÍÎÏÎÌÍÎÌÏÏÍ> _comparer; // 0x30
        public KeyCollection<ÍÍÎÍÏÌÍÎÏÏÌÌÍÎÏÎÌÍÎÌÏÏÍ,int> _keys; // 0x38
        public ValueCollection<ÍÍÎÍÏÌÍÎÏÏÌÌÍÎÏÎÌÍÎÌÏÏÍ,int> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E22DD0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2E22E60
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2E22E80
        public void set_Item(){} // RVA: 0x2E22F40
        public void Add(){} // RVA: 0x2E22F80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2E22FC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2E23020
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2E230F0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2E23210
        public void ContainsValue(){} // RVA: 0x2E23250
        public void CopyTo(){} // RVA: 0x2E23330
        public void GetEnumerator(){} // RVA: 0x2C22F20
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C22FD0
        public void GetObjectData(){} // RVA: 0x2E234B0
        public void FindEntry(){} // RVA: 0x2E23800
        public void Initialize(){} // RVA: 0x2E23B60
        public void TryInsert(){} // RVA: 0x2E23CE0
        public void OnDeserialization(){} // RVA: 0x2E24310
        public void Resize(){} // RVA: 0x2E24860 | overloaded x2
        public void Remove(){} // RVA: 0x2E24D40 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2E25030
        public void TryAdd(){} // RVA: 0x2E250C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2E25100
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2E25110
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C22FD0
        public void EnsureCapacity(){} // RVA: 0x2E25510
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2E25600
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2E256B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2E25800
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2E259F0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2E25BE0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C25800
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2E25D10
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.GameObject,PassthroughMeshInstance>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.GameObject> _comparer; // 0x30
        public KeyCollection<UnityEngine.GameObject,PassthroughMeshInstance> _keys; // 0x38
        public ValueCollection<UnityEngine.GameObject,PassthroughMeshInstance> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D80400 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2D80490
        public void set_Item(){} // RVA: 0x2D80550
        public void Add(){} // RVA: 0x2D805D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D80650
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D806E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D80840
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2D809C0
        public void ContainsValue(){} // RVA: 0x2D809F0
        public void CopyTo(){} // RVA: 0x2D80B70
        public void GetEnumerator(){} // RVA: 0x2CBE110
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2CBE1D0
        public void GetObjectData(){} // RVA: 0x2D80D80
        public void FindEntry(){} // RVA: 0x2D810D0
        public void Initialize(){} // RVA: 0x2D81310
        public void TryInsert(){} // RVA: 0x2D81490
        public void OnDeserialization(){} // RVA: 0x2D81970
        public void Resize(){} // RVA: 0x2D81F30 | overloaded x2
        public void Remove(){} // RVA: 0x2D82400 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2D826B0
        public void TryAdd(){} // RVA: 0x2D82770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D827F0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D82800
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2CBE1D0
        public void EnsureCapacity(){} // RVA: 0x2D82CB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D82DA0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2D82E50
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D83000
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D83220
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2D83440
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2CC0A80
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2D83560
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.Guid,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Guid> _comparer; // 0x30
        public KeyCollection<System.Guid,int> _keys; // 0x38
        public ValueCollection<System.Guid,int> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C2D730 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C2D7C0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C2D7E0
        public void set_Item(){} // RVA: 0x2C2D890
        public void Add(){} // RVA: 0x2C2D8D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C2D910
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C2D960
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C2DA30
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C2DB20
        public void ContainsValue(){} // RVA: 0x2C2DB60
        public void CopyTo(){} // RVA: 0x2C2DC40
        public void GetEnumerator(){} // RVA: 0x2C2DD60
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C2DE00
        public void GetObjectData(){} // RVA: 0x2C2DEE0
        public void FindEntry(){} // RVA: 0x2C2E230
        public void Initialize(){} // RVA: 0x2C2E4F0
        public void TryInsert(){} // RVA: 0x2C2E670
        public void OnDeserialization(){} // RVA: 0x2C2EBB0
        public void Resize(){} // RVA: 0x2C2F0E0 | overloaded x2
        public void Remove(){} // RVA: 0x2C2F570 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C2F820
        public void TryAdd(){} // RVA: 0x2C2F8A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C2F8E0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C2F8F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C2DE00
        public void EnsureCapacity(){} // RVA: 0x2C2FCC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C2FDB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C2FE60
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C2FFB0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C30190
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C30370
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C30490
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C30570
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<OVRSpace,SpaceQueryResult>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<OVRSpace> _comparer; // 0x30
        public KeyCollection<OVRSpace,SpaceQueryResult> _keys; // 0x38
        public ValueCollection<OVRSpace,SpaceQueryResult> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CDE050 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CDB110
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CDE0E0
        public void set_Item(){} // RVA: 0x2CDE1A0
        public void Add(){} // RVA: 0x2CDE1F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CDE240
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CDE2A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CDE3A0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CDE4C0
        public void ContainsValue(){} // RVA: 0x2CDE4F0
        public void CopyTo(){} // RVA: 0x2CDE600
        public void GetEnumerator(){} // RVA: 0x2C22F20
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C22FD0
        public void GetObjectData(){} // RVA: 0x2CDE730
        public void FindEntry(){} // RVA: 0x2CDEA80
        public void Initialize(){} // RVA: 0x2CDED10
        public void TryInsert(){} // RVA: 0x2CDEE90
        public void OnDeserialization(){} // RVA: 0x2CDF320
        public void Resize(){} // RVA: 0x2CDFBE0 | overloaded x2
        public void Remove(){} // RVA: 0x2CDFFD0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE0200
        public void TryAdd(){} // RVA: 0x2CE0290
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CE02E0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CE02F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C22FD0
        public void EnsureCapacity(){} // RVA: 0x2CE0700
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CE07F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CE08A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CE09F0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CE0BC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE0D90
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C25800
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE0EA0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<OVRGrabbable,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<OVRGrabbable> _comparer; // 0x30
        public KeyCollection<OVRGrabbable,int> _keys; // 0x38
        public ValueCollection<OVRGrabbable,int> _values; // 0x40
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
        public Entry<0x65703490,byte[]>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x65703490> _comparer; // 0x30
        public KeyCollection<0x65703490,byte[]> _keys; // 0x38
        public ValueCollection<0x65703490,byte[]> _values; // 0x40
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
        public Entry<string,ÏÌÍÌÌÎÌÎÏÎÏÏÎÍÌÍÌÏÎÎÏÌÍ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÏÌÍÌÌÎÌÎÏÎÏÏÎÍÌÍÌÏÎÎÏÌÍ> _keys; // 0x38
        public ValueCollection<string,ÏÌÍÌÌÎÌÎÏÎÏÏÎÍÌÍÌÏÎÎÏÌÍ> _values; // 0x40
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
        public Entry<0x658BF8A0,OVRGLTFAnimatinonNode>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x658BF8A0> _comparer; // 0x30
        public KeyCollection<0x658BF8A0,OVRGLTFAnimatinonNode> _keys; // 0x38
        public ValueCollection<0x658BF8A0,OVRGLTFAnimatinonNode> _values; // 0x40
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
        public Entry<string,OVRSimpleJSON.JSONNode>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,OVRSimpleJSON.JSONNode> _keys; // 0x38
        public ValueCollection<string,OVRSimpleJSON.JSONNode> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,UnityEngine.EventSystems.OVRPointerEventData>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,UnityEngine.EventSystems.OVRPointerEventData> _keys; // 0x38
        public ValueCollection<int,UnityEngine.EventSystems.OVRPointerEventData> _values; // 0x40
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
        public Entry<UnityEngine.Camera,bool>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Camera> _comparer; // 0x30
        public KeyCollection<UnityEngine.Camera,bool> _keys; // 0x38
        public ValueCollection<UnityEngine.Camera,bool> _values; // 0x40
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
        public Entry<UnityEngine.Camera,UnityEngine.Camera>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Camera> _comparer; // 0x30
        public KeyCollection<UnityEngine.Camera,UnityEngine.Camera> _keys; // 0x38
        public ValueCollection<UnityEngine.Camera,UnityEngine.Camera> _values; // 0x40
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
        public Entry<string,Newtonsoft.Json.Serialization.JsonProperty>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Newtonsoft.Json.Serialization.JsonProperty> _keys; // 0x38
        public ValueCollection<string,Newtonsoft.Json.Serialization.JsonProperty> _values; // 0x40
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
        public Entry<string,Newtonsoft.Json.Schema.JsonSchemaNode>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Newtonsoft.Json.Schema.JsonSchemaNode> _keys; // 0x38
        public ValueCollection<string,Newtonsoft.Json.Schema.JsonSchemaNode> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,System.IO.FileData>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.IO.FileData> _keys; // 0x38
        public ValueCollection<string,System.IO.FileData> _values; // 0x40
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
        public Entry<string,Valve.VR.SteamVR_Input_BindingFile_Source_Input_StringDictionary>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Valve.VR.SteamVR_Input_BindingFile_Source_Input_StringDictionary> _keys; // 0x38
        public ValueCollection<string,Valve.VR.SteamVR_Input_BindingFile_Source_Input_StringDictionary> _values; // 0x40
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
        public Entry<uint,TrackingReferenceObject>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<uint> _comparer; // 0x30
        public KeyCollection<uint,TrackingReferenceObject> _keys; // 0x38
        public ValueCollection<uint,TrackingReferenceObject> _values; // 0x40
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
        public Entry<Valve.VR.ISteamVR_Action_In_Source,ActionHintInfo>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<Valve.VR.ISteamVR_Action_In_Source> _comparer; // 0x30
        public KeyCollection<Valve.VR.ISteamVR_Action_In_Source,ActionHintInfo> _keys; // 0x38
        public ValueCollection<Valve.VR.ISteamVR_Action_In_Source,ActionHintInfo> _values; // 0x40
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
        public Entry<System.Type,VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider> _keys; // 0x38
        public ValueCollection<System.Type,VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<Cinemachine.CinemachineVirtualCameraBase,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<Cinemachine.CinemachineVirtualCameraBase> _comparer; // 0x30
        public KeyCollection<Cinemachine.CinemachineVirtualCameraBase,int> _keys; // 0x38
        public ValueCollection<Cinemachine.CinemachineVirtualCameraBase,int> _values; // 0x40
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
        public Entry<UnityEngine.AnimationClip,System.Collections.Generic.List`1<HashPair>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.AnimationClip> _comparer; // 0x30
        public KeyCollection<UnityEngine.AnimationClip,System.Collections.Generic.List`1<HashPair>> _keys; // 0x38
        public ValueCollection<UnityEngine.AnimationClip,System.Collections.Generic.List`1<HashPair>> _values; // 0x40
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
        public Entry<Cinemachine.ICinemachineCamera,object>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<Cinemachine.ICinemachineCamera> _comparer; // 0x30
        public KeyCollection<Cinemachine.ICinemachineCamera,object> _keys; // 0x38
        public ValueCollection<Cinemachine.ICinemachineCamera,object> _values; // 0x40
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
        public Entry<string,System.ValueTuple`2<UnityEngine.Transform,UnityEngine.Transform>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.ValueTuple`2<UnityEngine.Transform,UnityEngine.Transform>> _keys; // 0x38
        public ValueCollection<string,System.ValueTuple`2<UnityEngine.Transform,UnityEngine.Transform>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CF1230 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CEB7D0
        public void set_Item(){} // RVA: 0x2CF12C0
        public void Add(){} // RVA: 0x2CF1300
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CF1340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CF1390
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CF1470
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CEBB00
        public void ContainsValue(){} // RVA: 0x2CF1570
        public void CopyTo(){} // RVA: 0x2CF1660
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2CF17C0
        public void FindEntry(){} // RVA: 0x2CEC0D0
        public void Initialize(){} // RVA: 0x2CF1B10
        public void TryInsert(){} // RVA: 0x2CF1C90
        public void OnDeserialization(){} // RVA: 0x2CF2150
        public void Resize(){} // RVA: 0x2CF26A0 | overloaded x2
        public void Remove(){} // RVA: 0x2CED390 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CED610
        public void TryAdd(){} // RVA: 0x2CF2930
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CF2970
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CF2980
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2CF2D60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CF2E50
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CEDCA0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CF2F00
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CF30E0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CEE1B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEE2D0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,Valve.Newtonsoft.Json.Serialization.JsonProperty>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Valve.Newtonsoft.Json.Serialization.JsonProperty> _keys; // 0x38
        public ValueCollection<string,Valve.Newtonsoft.Json.Serialization.JsonProperty> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,TweenData>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,TweenData> _keys; // 0x38
        public ValueCollection<int,TweenData> _values; // 0x40
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
        public Entry<0x65994DB8,UnityEngine.Rendering.PostProcessing.Monitor>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x65994DB8> _comparer; // 0x30
        public KeyCollection<0x65994DB8,UnityEngine.Rendering.PostProcessing.Monitor> _keys; // 0x38
        public ValueCollection<0x65994DB8,UnityEngine.Rendering.PostProcessing.Monitor> _values; // 0x40
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
        public Entry<0x659956A8,System.Collections.Generic.List`1<SerializedBundleRef>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x659956A8> _comparer; // 0x30
        public KeyCollection<0x659956A8,System.Collections.Generic.List`1<SerializedBundleRef>> _keys; // 0x38
        public ValueCollection<0x659956A8,System.Collections.Generic.List`1<SerializedBundleRef>> _values; // 0x40
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
        public Entry<System.Type,UnityEngine.Rendering.PostProcessing.PostProcessBundle>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,UnityEngine.Rendering.PostProcessing.PostProcessBundle> _keys; // 0x38
        public ValueCollection<System.Type,UnityEngine.Rendering.PostProcessing.PostProcessBundle> _values; // 0x40
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
        public Entry<UnityEngine.Shader,UnityEngine.Rendering.PostProcessing.PropertySheet>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Shader> _comparer; // 0x30
        public KeyCollection<UnityEngine.Shader,UnityEngine.Rendering.PostProcessing.PropertySheet> _keys; // 0x38
        public ValueCollection<UnityEngine.Shader,UnityEngine.Rendering.PostProcessing.PropertySheet> _values; // 0x40
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
        public Entry<string,UnityEngine.GUIStyle>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,UnityEngine.GUIStyle> _keys; // 0x38
        public ValueCollection<string,UnityEngine.GUIStyle> _values; // 0x40
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
        public Entry<int,ÌÍÍÍÌÍÎÌÌÏÍÍÎÏÎÍÎÍÍÍÎÍÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,ÌÍÍÍÌÍÎÌÌÏÍÍÎÏÎÍÎÍÍÍÎÍÌ> _keys; // 0x38
        public ValueCollection<int,ÌÍÍÍÌÍÎÌÌÏÍÍÎÏÎÍÎÍÍÍÎÍÌ> _values; // 0x40
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
        public Entry<int,ÏÍÌÏÌÏÍÌÍÏÌÍÌÌÎÎÌÎÎÍÌÏÎ<UnityEngine.Vector2>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,ÏÍÌÏÌÏÍÌÍÏÌÍÌÌÎÎÌÎÎÍÌÏÎ<UnityEngine.Vector2>> _keys; // 0x38
        public ValueCollection<int,ÏÍÌÏÌÏÍÌÍÏÌÍÌÌÎÎÌÎÎÍÌÏÎ<UnityEngine.Vector2>> _values; // 0x40
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
        public Entry<int,ÏÍÌÏÌÏÍÌÍÏÌÍÌÌÎÎÌÎÎÍÌÏÎ<bool>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,ÏÍÌÏÌÏÍÌÍÏÌÍÌÌÎÎÌÎÎÍÌÏÎ<bool>> _keys; // 0x38
        public ValueCollection<int,ÏÍÌÏÌÏÍÌÍÏÌÍÌÌÎÎÌÎÎÍÌÏÎ<bool>> _values; // 0x40
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
        public Entry<VRC.UI.Core.Styles.StyleElement,string[]>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.UI.Core.Styles.StyleElement> _comparer; // 0x30
        public KeyCollection<VRC.UI.Core.Styles.StyleElement,string[]> _keys; // 0x38
        public ValueCollection<VRC.UI.Core.Styles.StyleElement,string[]> _values; // 0x40
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
        public Entry<System.Action`1<object>,object>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Action`1<object>> _comparer; // 0x30
        public KeyCollection<System.Action`1<object>,object> _keys; // 0x38
        public ValueCollection<System.Action`1<object>,object> _values; // 0x40
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
        public Entry<System.Func`3<object,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask>,System.ValueTuple`2<object,System.Threading.CancellationTokenSource>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Func`3<object,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask>> _comparer; // 0x30
        public KeyCollection<System.Func`3<object,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask>,System.ValueTuple`2<object,System.Threading.CancellationTokenSource>> _keys; // 0x38
        public ValueCollection<System.Func`3<object,System.Threading.CancellationToken,Cysharp.Threading.Tasks.UniTask>,System.ValueTuple`2<object,System.Threading.CancellationTokenSource>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CF1230 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CEB7D0
        public void set_Item(){} // RVA: 0x2CF12C0
        public void Add(){} // RVA: 0x2CF1300
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CF1340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CF1390
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CF1470
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CEBB00
        public void ContainsValue(){} // RVA: 0x2CF1570
        public void CopyTo(){} // RVA: 0x2CF1660
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2CF17C0
        public void FindEntry(){} // RVA: 0x2CEC0D0
        public void Initialize(){} // RVA: 0x2CF1B10
        public void TryInsert(){} // RVA: 0x2CF1C90
        public void OnDeserialization(){} // RVA: 0x2CF2150
        public void Resize(){} // RVA: 0x2CF26A0 | overloaded x2
        public void Remove(){} // RVA: 0x2CED390 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CED610
        public void TryAdd(){} // RVA: 0x2CF2930
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CF2970
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CF2980
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2CF2D60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CF2E50
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CEDCA0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CF2F00
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CF30E0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CEE1B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEE2D0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,System.Collections.IList>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Collections.IList> _keys; // 0x38
        public ValueCollection<string,System.Collections.IList> _values; // 0x40
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
        public Entry<string,System.Collections.IDictionary>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Collections.IDictionary> _keys; // 0x38
        public ValueCollection<string,System.Collections.IDictionary> _values; // 0x40
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
        public Entry<UnityEngine.Renderer,UnityEngine.MeshFilter>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Renderer> _comparer; // 0x30
        public KeyCollection<UnityEngine.Renderer,UnityEngine.MeshFilter> _keys; // 0x38
        public ValueCollection<UnityEngine.Renderer,UnityEngine.MeshFilter> _values; // 0x40
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
        public Entry<string,Unity.Properties.IProperty`1<UnityEngine.Vector2Int>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Unity.Properties.IProperty`1<UnityEngine.Vector2Int>> _keys; // 0x38
        public ValueCollection<string,Unity.Properties.IProperty`1<UnityEngine.Vector2Int>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,Unity.Properties.IProperty`1<UnityEngine.Vector3Int>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Unity.Properties.IProperty`1<UnityEngine.Vector3Int>> _keys; // 0x38
        public ValueCollection<string,Unity.Properties.IProperty`1<UnityEngine.Vector3Int>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,Unity.Properties.IProperty`1<UnityEngine.Rect>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Unity.Properties.IProperty`1<UnityEngine.Rect>> _keys; // 0x38
        public ValueCollection<string,Unity.Properties.IProperty`1<UnityEngine.Rect>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,Unity.Properties.IProperty`1<UnityEngine.RectInt>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Unity.Properties.IProperty`1<UnityEngine.RectInt>> _keys; // 0x38
        public ValueCollection<string,Unity.Properties.IProperty`1<UnityEngine.RectInt>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,Unity.Properties.IProperty`1<UnityEngine.Bounds>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Unity.Properties.IProperty`1<UnityEngine.Bounds>> _keys; // 0x38
        public ValueCollection<string,Unity.Properties.IProperty`1<UnityEngine.Bounds>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,Unity.Properties.IProperty`1<UnityEngine.BoundsInt>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Unity.Properties.IProperty`1<UnityEngine.BoundsInt>> _keys; // 0x38
        public ValueCollection<string,Unity.Properties.IProperty`1<UnityEngine.BoundsInt>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,Unity.Properties.IProperty`1<System.Version>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Unity.Properties.IProperty`1<System.Version>> _keys; // 0x38
        public ValueCollection<string,Unity.Properties.IProperty`1<System.Version>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,HeaderBucket>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,HeaderBucket> _keys; // 0x38
        public ValueCollection<string,HeaderBucket> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,System.UriParser>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.UriParser> _keys; // 0x38
        public ValueCollection<string,System.UriParser> _values; // 0x40
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
        public Entry<System.Guid,Mono.Net.Security.MobileTlsProvider>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Guid> _comparer; // 0x30
        public KeyCollection<System.Guid,Mono.Net.Security.MobileTlsProvider> _keys; // 0x38
        public ValueCollection<System.Guid,Mono.Net.Security.MobileTlsProvider> _values; // 0x40
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
        public Entry<string,System.Tuple`2<System.Guid,string>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Tuple`2<System.Guid,string>> _keys; // 0x38
        public ValueCollection<string,System.Tuple`2<System.Guid,string>> _values; // 0x40
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
        public Entry<int,ÏÏÍÍÌÍÎÍÏÎÎÏÏÎÍÍÌÌÌÍÌÌÏ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,ÏÏÍÍÌÍÎÍÏÎÎÏÏÎÍÍÌÌÌÍÌÌÏ> _keys; // 0x38
        public ValueCollection<int,ÏÏÍÍÌÍÎÍÏÎÎÏÏÎÍÍÌÌÌÍÌÌÏ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C71B40 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C3D1F0
        public void set_Item(){} // RVA: 0x2C71BD0
        public void Add(){} // RVA: 0x2C71C20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C71C70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C71CD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C71DD0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C3D5D0
        public void ContainsValue(){} // RVA: 0x2C71EF0
        public void CopyTo(){} // RVA: 0x2C72000
        public void GetEnumerator(){} // RVA: 0x2C22F20
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C22FD0
        public void GetObjectData(){} // RVA: 0x2C72170
        public void FindEntry(){} // RVA: 0x2C3DBD0
        public void Initialize(){} // RVA: 0x2C724C0
        public void TryInsert(){} // RVA: 0x2C72640
        public void OnDeserialization(){} // RVA: 0x2C72B40
        public void Resize(){} // RVA: 0x2C73090 | overloaded x2
        public void Remove(){} // RVA: 0x2C73280 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C734D0
        public void TryAdd(){} // RVA: 0x2C735A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C735F0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C73600
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C22FD0
        public void EnsureCapacity(){} // RVA: 0x2C73A00
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C73AF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C3F710
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C73BA0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C73D70
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C3FC00
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C25800
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C3FD10
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<VRC.UI.Core.Styles.StyleResource,ÍÎÏÍÌÏÍÏÌÏÍÏÍÌÏÌÍÎÎÌÌÎÎ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<VRC.UI.Core.Styles.StyleResource> _comparer; // 0x30
        public KeyCollection<VRC.UI.Core.Styles.StyleResource,ÍÎÏÍÌÏÍÏÌÏÍÏÍÌÏÌÍÎÎÌÌÎÎ> _keys; // 0x38
        public ValueCollection<VRC.UI.Core.Styles.StyleResource,ÍÎÏÍÌÏÍÏÌÏÍÏÍÌÏÌÍÎÎÌÌÎÎ> _values; // 0x40
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
        public Entry<int,System.ValueTuple`2<UnityEngine.Material,int>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,System.ValueTuple`2<UnityEngine.Material,int>> _keys; // 0x38
        public ValueCollection<int,System.ValueTuple`2<UnityEngine.Material,int>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C436D0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C43760
        public void set_Item(){} // RVA: 0x2C43820
        public void Add(){} // RVA: 0x2C43860
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C438A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C438F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C439D0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C43AD0
        public void ContainsValue(){} // RVA: 0x2C43B00
        public void CopyTo(){} // RVA: 0x2C43BF0
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2C43D40
        public void FindEntry(){} // RVA: 0x2C44090
        public void Initialize(){} // RVA: 0x2C442F0
        public void TryInsert(){} // RVA: 0x2C44470
        public void OnDeserialization(){} // RVA: 0x2C44950
        public void Resize(){} // RVA: 0x2C44E80 | overloaded x2
        public void Remove(){} // RVA: 0x2C45270 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C454A0
        public void TryAdd(){} // RVA: 0x2C45560
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C455A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C455B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2C459A0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C45A90
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C45B40
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C45C80
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C45E40
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C46000
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C46110
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ÌÍÍÍÎÎÏÌÍÌÍÌÎÎÍÌÎÌÏÌÏÏÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÌÍÍÍÎÎÏÌÍÌÍÌÎÎÍÌÎÌÏÌÏÏÌ> _keys; // 0x38
        public ValueCollection<string,ÌÍÍÍÎÎÏÌÍÌÍÌÎÎÍÌÎÌÏÌÏÏÌ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D9FB00 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CEB7D0
        public void set_Item(){} // RVA: 0x2D9FB90
        public void Add(){} // RVA: 0x2D9FBD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D9FC10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D9FC60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D9FD40
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CEBB00
        public void ContainsValue(){} // RVA: 0x2D9FE40
        public void CopyTo(){} // RVA: 0x2CEBC20
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2D9FF30
        public void FindEntry(){} // RVA: 0x2CEC0D0
        public void Initialize(){} // RVA: 0x2DA0280
        public void TryInsert(){} // RVA: 0x2DA0400
        public void OnDeserialization(){} // RVA: 0x2DA08C0
        public void Resize(){} // RVA: 0x2DA0E10 | overloaded x2
        public void Remove(){} // RVA: 0x2CED390 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CED610
        public void TryAdd(){} // RVA: 0x2DA10A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CED710
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2DA10E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2DA14C0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2DA15B0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CEDCA0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DA1660
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DA1840
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CEE1B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEE2D0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,System.Func`1<string>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Func`1<string>> _keys; // 0x38
        public ValueCollection<string,System.Func`1<string>> _values; // 0x40
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
        public Entry<0x65728168,byte[]>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x65728168> _comparer; // 0x30
        public KeyCollection<0x65728168,byte[]> _keys; // 0x38
        public ValueCollection<0x65728168,byte[]> _values; // 0x40
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
        public Entry<0x65704358,byte[]>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x65704358> _comparer; // 0x30
        public KeyCollection<0x65704358,byte[]> _keys; // 0x38
        public ValueCollection<0x65704358,byte[]> _values; // 0x40
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
        public Entry<float,ÏÎÌÎÏÍÌÏÏÌÏÎÏÎÏÌÍÌÍÌÎÎÏ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<float> _comparer; // 0x30
        public KeyCollection<float,ÏÎÌÎÏÍÌÏÏÌÏÎÏÎÏÌÍÌÍÌÎÎÏ> _keys; // 0x38
        public ValueCollection<float,ÏÎÌÎÏÍÌÏÏÌÏÎÏÎÏÌÍÌÍÌÎÎÏ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DBADB0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2DBAE40
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2DBAE60
        public void set_Item(){} // RVA: 0x2DBAF00
        public void Add(){} // RVA: 0x2DBAF30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2DBAF60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2DBAFB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2DBB070
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2DBB150
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2DBB180
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2DBB2D0
        public void FindEntry(){} // RVA: 0x2DBB620
        public void Initialize(){} // RVA: 0x2DBB8C0
        public void TryInsert(){} // RVA: 0x2DBBA40
        public void OnDeserialization(){} // RVA: 0x2DBBF50
        public void Resize(){} // RVA: 0x2DBC470 | overloaded x2
        public void Remove(){} // RVA: 0x2DBC890 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2DBCAD0
        public void TryAdd(){} // RVA: 0x2DBCB80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2DBCBB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2DBCBC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2DBCF60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2DBD050
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2DBD100
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DBD220
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DBD3F0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2DBD5C0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2DBD6D0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<0x6573FB30,byte[]>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x6573FB30> _comparer; // 0x30
        public KeyCollection<0x6573FB30,byte[]> _keys; // 0x38
        public ValueCollection<0x6573FB30,byte[]> _values; // 0x40
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
        public Entry<System.Type,System.Collections.Immutable.ImmutableArray`1<UnityEngine.RequireComponent>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,System.Collections.Immutable.ImmutableArray`1<UnityEngine.RequireComponent>> _keys; // 0x38
        public ValueCollection<System.Type,System.Collections.Immutable.ImmutableArray`1<UnityEngine.RequireComponent>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CE1880 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CE1930
        public void set_Item(){} // RVA: 0x2CE19A0
        public void Add(){} // RVA: 0x2CE19D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CE1A00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CE1A50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CE1B10
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2CE1C20
        public void CopyTo(){} // RVA: 0x2CE1D00
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2CE1E50
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2CE23E0
        public void TryInsert(){} // RVA: 0x2CE2560
        public void OnDeserialization(){} // RVA: 0x2CE2A30
        public void Resize(){} // RVA: 0x2CE2F70 | overloaded x2
        public void Remove(){} // RVA: 0x2CE3450 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE36D0
        public void TryAdd(){} // RVA: 0x2CE3790
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CE37C0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CE37D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2CE3B70
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CE3C60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CE3D10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CE3E50
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CE4020
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE4310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,System.Collections.Generic.HashSet`1<System.Type>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Collections.Generic.HashSet`1<System.Type>> _keys; // 0x38
        public ValueCollection<string,System.Collections.Generic.HashSet`1<System.Type>> _values; // 0x40
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
        public Entry<byte,object>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<byte> _comparer; // 0x30
        public KeyCollection<byte,object> _keys; // 0x38
        public ValueCollection<byte,object> _values; // 0x40
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
        public Entry<string,Newtonsoft.Json.Linq.JToken>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Newtonsoft.Json.Linq.JToken> _keys; // 0x38
        public ValueCollection<string,Newtonsoft.Json.Linq.JToken> _values; // 0x40
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
        public Entry<UnityEngine.GameObject,System.Collections.Generic.List`1<VRC.Dynamics.VRCConstraintBase>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.GameObject> _comparer; // 0x30
        public KeyCollection<UnityEngine.GameObject,System.Collections.Generic.List`1<VRC.Dynamics.VRCConstraintBase>> _keys; // 0x38
        public ValueCollection<UnityEngine.GameObject,System.Collections.Generic.List`1<VRC.Dynamics.VRCConstraintBase>> _values; // 0x40
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
        public Entry<string,VRC.Udon.Common.Interfaces.IUdonVariable>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,VRC.Udon.Common.Interfaces.IUdonVariable> _keys; // 0x38
        public ValueCollection<string,VRC.Udon.Common.Interfaces.IUdonVariable> _values; // 0x40
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