// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Generic
// Classes: 100
// Methods: 5401

namespace ThirdParty.DotNet.System.Collections.Generic
{
    public class Deque`1
    {
        public T[] _array;
        public int _head;

        // ── Methods ──
        public void get_Count(){} // RVA: 0xD840
        public void get_IsEmpty(){} // RVA: 0xDBE0
        public void EnqueueTail(){} // RVA: 0x283FA0
        public void DequeueHead(){} // RVA: 0x283FA0
        public void DequeueTail(){} // RVA: 0x283FA0
        public void Grow(){} // RVA: 0x24A50
        public void .ctor(){} // RVA: 0x24A50
    }

    public class DictionaryDebugView`2
    {
    }

    public class DictionaryKeyCollectionDebugView`2
    {
    }

    public class DictionaryKeyCollectionDebugView`2
    {
    }

    public class DictionaryValueCollectionDebugView`2
    {
    }

    public class DictionaryValueCollectionDebugView`2
    {
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ÍÍÎÍÏÏÏÎÌÏÌÎÍÎÏÎÏÌÌÍÎÍÎ,ÍÏÍÌÎÌÍÏÍÏÎÎÏÍÎÍÏÎÌÌÌÎÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÍÍÎÍÏÏÏÎÌÏÌÎÍÎÏÎÏÌÌÍÎÍÎ> _comparer; // 0x30
        public KeyCollection<ÍÍÎÍÏÏÏÎÌÏÌÎÍÎÏÎÏÌÌÍÎÍÎ,ÍÏÍÌÎÌÍÏÍÏÎÎÏÍÎÍÏÎÌÌÌÎÌ> _keys; // 0x38
        public ValueCollection<ÍÍÎÍÏÏÏÎÌÏÌÎÍÎÏÎÏÌÌÍÎÍÎ,ÍÏÍÌÎÌÍÏÍÏÎÎÏÍÎÍÏÎÌÌÌÎÌ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E30E30 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2E30EC0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2E30EE0
        public void set_Item(){} // RVA: 0x2E30F80
        public void Add(){} // RVA: 0x2E30FB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2E30FE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2E31030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2E310F0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2E311D0
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2CC1810
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2E31200
        public void FindEntry(){} // RVA: 0x2E31550
        public void Initialize(){} // RVA: 0x2E31880
        public void TryInsert(){} // RVA: 0x2E31A00
        public void OnDeserialization(){} // RVA: 0x2E31FC0
        public void Resize(){} // RVA: 0x2E324E0 | overloaded x2
        public void Remove(){} // RVA: 0x2E32990 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2E32C70
        public void TryAdd(){} // RVA: 0x2E32D30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CC31B0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2E32D60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2E330F0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2E331E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2E33290
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2E333B0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2E33570
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2E33730
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2E33840
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,ÏÎÌÎÏÍÌÏÏÌÏÎÏÎÏÌÍÌÍÌÎÎÏ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,ÏÎÌÎÏÍÌÏÏÌÏÎÏÎÏÌÍÌÍÌÎÎÏ> _keys; // 0x38
        public ValueCollection<int,ÏÎÌÎÏÍÌÏÏÌÏÎÏÎÏÌÍÌÍÌÎÎÏ> _values; // 0x40
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
        public Entry<ÎÌÍÎÌÌÏÏÏÏÌÏÌÍÍÍÎÌÍÌÌÎÎ,ÌÎÏÎÍÌÌÌÎÏÎÌÏÎÍÎÌÏÍÏÏÍÍ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÎÌÍÎÌÌÏÏÏÏÌÏÌÍÍÍÎÌÍÌÌÎÎ> _comparer; // 0x30
        public KeyCollection<ÎÌÍÎÌÌÏÏÏÏÌÏÌÍÍÍÎÌÍÌÌÎÎ,ÌÎÏÎÍÌÌÌÎÏÎÌÏÎÍÎÌÏÍÏÏÍÍ> _keys; // 0x38
        public ValueCollection<ÎÌÍÎÌÌÏÏÏÏÌÏÌÍÍÍÎÌÍÌÌÎÎ,ÌÎÏÎÍÌÌÌÎÏÎÌÏÎÍÎÌÏÍÏÏÍÍ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E34260 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2E342F0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2E34310
        public void set_Item(){} // RVA: 0x2E343C0
        public void Add(){} // RVA: 0x2E34400
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2E34440
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2E34490
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2E34560
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2E34650
        public void ContainsValue(){} // RVA: 0x2BED020
        public void CopyTo(){} // RVA: 0x2BED150
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2E34690
        public void FindEntry(){} // RVA: 0x2E349E0
        public void Initialize(){} // RVA: 0x2E34D50
        public void TryInsert(){} // RVA: 0x2E34ED0
        public void OnDeserialization(){} // RVA: 0x2E35510
        public void Resize(){} // RVA: 0x2E35A40 | overloaded x2
        public void Remove(){} // RVA: 0x2E35F90 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2E36310
        public void TryAdd(){} // RVA: 0x2E363D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2BEF290
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2E36410
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2E367D0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2E368C0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2E36970
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2E36A90
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2E36C60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2E36E30
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2E36F50
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ÎÏÏÏÎÍÎÏÎÏÍÌÍÍÌÌÍÌÎÎÌÎÍ,ÏÎÌÎÏÍÌÏÏÌÏÎÏÎÏÌÍÌÍÌÎÎÏ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÎÏÏÏÎÍÎÏÎÏÍÌÍÍÌÌÍÌÎÎÌÎÍ> _comparer; // 0x30
        public KeyCollection<ÎÏÏÏÎÍÎÏÎÏÍÌÍÍÌÌÍÌÎÎÌÎÍ,ÏÎÌÎÏÍÌÏÏÌÏÎÏÎÏÌÍÌÍÌÎÎÏ> _keys; // 0x38
        public ValueCollection<ÎÏÏÏÎÍÎÏÎÏÍÌÍÍÌÌÍÌÎÎÌÎÍ,ÏÎÌÎÏÍÌÏÏÌÏÎÏÎÏÌÍÌÍÌÎÎÏ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E58480 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2E58510
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2E58530
        public void set_Item(){} // RVA: 0x2E585D0
        public void Add(){} // RVA: 0x2E58600
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2E58630
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2E58680
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2E58740
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2E58820
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2CC1810
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2E58850
        public void FindEntry(){} // RVA: 0x2E58BA0
        public void Initialize(){} // RVA: 0x2E58ED0
        public void TryInsert(){} // RVA: 0x2E59050
        public void OnDeserialization(){} // RVA: 0x2E59610
        public void Resize(){} // RVA: 0x2E59B30 | overloaded x2
        public void Remove(){} // RVA: 0x2E59FE0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2E5A2C0
        public void TryAdd(){} // RVA: 0x2E5A380
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CC31B0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2E5A3B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2E5A740
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2E5A830
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2E5A8E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2E5AA00
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2E5ABC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2E5AD80
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2E5AE90
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ÍÏÍÌÎÌÍÏÍÏÎÎÏÍÎÍÏÎÌÌÌÎÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÍÏÍÌÎÌÍÏÍÏÎÎÏÍÎÍÏÎÌÌÌÎÌ> _keys; // 0x38
        public ValueCollection<string,ÍÏÍÌÎÌÍÏÍÏÎÎÏÍÎÍÏÎÌÌÌÎÌ> _values; // 0x40
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
        public Entry<System.Action`1<UnityEngine.Object>,System.Collections.Generic.LinkedListNode`1<System.Action`1<UnityEngine.Object>>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Action`1<UnityEngine.Object>> _comparer; // 0x30
        public KeyCollection<System.Action`1<UnityEngine.Object>,System.Collections.Generic.LinkedListNode`1<System.Action`1<UnityEngine.Object>>> _keys; // 0x38
        public ValueCollection<System.Action`1<UnityEngine.Object>,System.Collections.Generic.LinkedListNode`1<System.Action`1<UnityEngine.Object>>> _values; // 0x40
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
        public Entry<System.Action`1<bool>,System.Collections.Generic.LinkedListNode`1<System.Action`1<bool>>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Action`1<bool>> _comparer; // 0x30
        public KeyCollection<System.Action`1<bool>,System.Collections.Generic.LinkedListNode`1<System.Action`1<bool>>> _keys; // 0x38
        public ValueCollection<System.Action`1<bool>,System.Collections.Generic.LinkedListNode`1<System.Action`1<bool>>> _values; // 0x40
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
        public Entry<System.Action`2<bool,UnityEngine.Object>,System.Collections.Generic.LinkedListNode`1<System.Action`2<bool,UnityEngine.Object>>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Action`2<bool,UnityEngine.Object>> _comparer; // 0x30
        public KeyCollection<System.Action`2<bool,UnityEngine.Object>,System.Collections.Generic.LinkedListNode`1<System.Action`2<bool,UnityEngine.Object>>> _keys; // 0x38
        public ValueCollection<System.Action`2<bool,UnityEngine.Object>,System.Collections.Generic.LinkedListNode`1<System.Action`2<bool,UnityEngine.Object>>> _values; // 0x40
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
        public Entry<System.Action`2<object,TMPro.Compute_DT_EventArgs>,System.Collections.Generic.LinkedListNode`1<System.Action`2<object,TMPro.Compute_DT_EventArgs>>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Action`2<object,TMPro.Compute_DT_EventArgs>> _comparer; // 0x30
        public KeyCollection<System.Action`2<object,TMPro.Compute_DT_EventArgs>,System.Collections.Generic.LinkedListNode`1<System.Action`2<object,TMPro.Compute_DT_EventArgs>>> _keys; // 0x38
        public ValueCollection<System.Action`2<object,TMPro.Compute_DT_EventArgs>,System.Collections.Generic.LinkedListNode`1<System.Action`2<object,TMPro.Compute_DT_EventArgs>>> _values; // 0x40
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
        public Entry<System.Action`2<bool,UnityEngine.Material>,System.Collections.Generic.LinkedListNode`1<System.Action`2<bool,UnityEngine.Material>>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Action`2<bool,UnityEngine.Material>> _comparer; // 0x30
        public KeyCollection<System.Action`2<bool,UnityEngine.Material>,System.Collections.Generic.LinkedListNode`1<System.Action`2<bool,UnityEngine.Material>>> _keys; // 0x38
        public ValueCollection<System.Action`2<bool,UnityEngine.Material>,System.Collections.Generic.LinkedListNode`1<System.Action`2<bool,UnityEngine.Material>>> _values; // 0x40
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
        public Entry<System.Action`3<UnityEngine.GameObject,UnityEngine.Material,UnityEngine.Material>,System.Collections.Generic.LinkedListNode`1<System.Action`3<UnityEngine.GameObject,UnityEngine.Material,UnityEngine.Material>>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Action`3<UnityEngine.GameObject,UnityEngine.Material,UnityEngine.Material>> _comparer; // 0x30
        public KeyCollection<System.Action`3<UnityEngine.GameObject,UnityEngine.Material,UnityEngine.Material>,System.Collections.Generic.LinkedListNode`1<System.Action`3<UnityEngine.GameObject,UnityEngine.Material,UnityEngine.Material>>> _keys; // 0x38
        public ValueCollection<System.Action`3<UnityEngine.GameObject,UnityEngine.Material,UnityEngine.Material>,System.Collections.Generic.LinkedListNode`1<System.Action`3<UnityEngine.GameObject,UnityEngine.Material,UnityEngine.Material>>> _values; // 0x40
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
        public Entry<System.Action,System.Collections.Generic.LinkedListNode`1<System.Action>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Action> _comparer; // 0x30
        public KeyCollection<System.Action,System.Collections.Generic.LinkedListNode`1<System.Action>> _keys; // 0x38
        public ValueCollection<System.Action,System.Collections.Generic.LinkedListNode`1<System.Action>> _values; // 0x40
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
        public Entry<string,Token>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Token> _keys; // 0x38
        public ValueCollection<string,Token> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D776E0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CE54B0
        public void set_Item(){} // RVA: 0x2D77770
        public void Add(){} // RVA: 0x2D777C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D77810
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D77870
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D77970
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE5860
        public void ContainsValue(){} // RVA: 0x2D77A90
        public void CopyTo(){} // RVA: 0x2D77BA0
        public void GetEnumerator(){} // RVA: 0x2C22F20
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C22FD0
        public void GetObjectData(){} // RVA: 0x2D77D20
        public void FindEntry(){} // RVA: 0x2CE5E80
        public void Initialize(){} // RVA: 0x2D78080
        public void TryInsert(){} // RVA: 0x2D78200
        public void OnDeserialization(){} // RVA: 0x2D786D0
        public void Resize(){} // RVA: 0x2D78C40 | overloaded x2
        public void Remove(){} // RVA: 0x2CE7160 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CE7400
        public void TryAdd(){} // RVA: 0x2D78EC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D78F10
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D78F30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C22FD0
        public void EnsureCapacity(){} // RVA: 0x2D79340
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D79430
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CE7AC0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D794E0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D796C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE7FE0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C25800
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CE8100
    }

    public class Dictionary`2
    {
        public int[] _buckets;
        public Entry<U,T>[] _entries;
        public int _count;
        public int _freeList;
        public int _freeCount;
        public int _version;
        public System.Collections.Generic.IEqualityComparer`1<U> _comparer;
        public KeyCollection<U,T> _keys;
        public ValueCollection<U,T> _values;
        public object _syncRoot;
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DC60 | overloaded x9
        public void get_Comparer(){} // RVA: 0xCD60
        public void get_Count(){} // RVA: 0xD840
        public void get_Keys(){} // RVA: 0xCD60
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0xCD60
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0xCD60
        public void get_Values(){} // RVA: 0xCD60
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0xCD60
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0xCD60
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void Add(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x283FA0
        public void Clear(){} // RVA: 0x24A50
        public void ContainsKey(){} // RVA: 0x283FA0
        public void ContainsValue(){} // RVA: 0x283FA0
        public void CopyTo(){} // RVA: 0x2BAA0
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0xCD60
        public void GetObjectData(){}
        public void FindEntry(){} // RVA: 0x283FA0
        public void Initialize(){} // RVA: 0x13FB0
        public void TryInsert(){} // RVA: 0x283FA0
        public void OnDeserialization(){} // RVA: 0x24B10
        public void Resize(){} // RVA: 0x26980 | overloaded x2
        public void Remove(){} // RVA: 0x283FA0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x283FA0
        public void TryAdd(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xDBE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void EnsureCapacity(){} // RVA: 0x13FB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xDBE0
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xDBE0
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0xCE10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DC60
        public void IsCompatibleKey(){} // RVA: 0xDCC0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DC60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0xDE40
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x24B10
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<U,System.Collections.Generic.Dictionary`2<V,T>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<U> _comparer; // 0x30
        public KeyCollection<U,System.Collections.Generic.Dictionary`2<V,T>> _keys; // 0x38
        public ValueCollection<U,System.Collections.Generic.Dictionary`2<V,T>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DFD2F0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2DFD380
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2DFD3B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2DFD3B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2DFD3B0
        public void get_Values(){} // RVA: 0x2DFD490
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2DFD490
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2DFD490
        public void get_Item(){} // RVA: 0x263BC0
        public void set_Item(){} // RVA: 0x2DFD7B0
        public void Add(){} // RVA: 0x2DFD940
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x263BC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x263BC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x263BC0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2DFE1C0
        public void ContainsValue(){} // RVA: 0x2DFE2B0
        public void CopyTo(){} // RVA: 0x2DFE850
        public void GetEnumerator(){} // RVA: 0x263BC0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2DFED50
        public void GetObjectData(){} // RVA: 0x2DFEE10
        public void FindEntry(){} // RVA: 0x2DFF1A0
        public void Initialize(){} // RVA: 0x2DFFAA0
        public void TryInsert(){} // RVA: 0x2DFFC20
        public void OnDeserialization(){} // RVA: 0x2E00A30
        public void Resize(){} // RVA: 0x2E01120 | overloaded x2
        public void Remove(){} // RVA: 0x2E01D20 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2E024C0
        public void TryAdd(){} // RVA: 0x2E026F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2E02890
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2E028B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2DFED50
        public void EnsureCapacity(){} // RVA: 0x2E02FD0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2E030D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2E03180
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2E031B0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2E031E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2E034A0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2E038F0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2E03D40
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2E03F40
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2E04000
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,System.LocalDataStoreSlot>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.LocalDataStoreSlot> _keys; // 0x38
        public ValueCollection<string,System.LocalDataStoreSlot> _values; // 0x40
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
        public Entry<string,System.Collections.Generic.IDictionary`2<int,int>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Collections.Generic.IDictionary`2<int,int>> _keys; // 0x38
        public ValueCollection<string,System.Collections.Generic.IDictionary`2<int,int>> _values; // 0x40
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
        public Entry<string,object>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,object> _keys; // 0x38
        public ValueCollection<string,object> _values; // 0x40
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
        public Entry<int,UnityEngine.InputSystem.InputDevice>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,UnityEngine.InputSystem.InputDevice> _keys; // 0x38
        public ValueCollection<int,UnityEngine.InputSystem.InputDevice> _values; // 0x40
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
        public Entry<UnityEngine.InputSystem.Utilities.InternedString,string>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.InputSystem.Utilities.InternedString> _comparer; // 0x30
        public KeyCollection<UnityEngine.InputSystem.Utilities.InternedString,string> _keys; // 0x38
        public ValueCollection<UnityEngine.InputSystem.Utilities.InternedString,string> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CCDC60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CCA550
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CCDCF0
        public void set_Item(){} // RVA: 0x2CCDDA0
        public void Add(){} // RVA: 0x2CCDDE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CCDE20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CCDE70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CCDF40
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CCE030
        public void ContainsValue(){} // RVA: 0x2BED020
        public void CopyTo(){} // RVA: 0x2BF7D70
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2CCE070
        public void FindEntry(){} // RVA: 0x2CCE3C0
        public void Initialize(){} // RVA: 0x2CCE6A0
        public void TryInsert(){} // RVA: 0x2CCE820
        public void OnDeserialization(){} // RVA: 0x2CCEE50
        public void Resize(){} // RVA: 0x2CCF380 | overloaded x2
        public void Remove(){} // RVA: 0x2CCF840 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CCFB10
        public void TryAdd(){} // RVA: 0x2CCFBD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2BF9A20
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CCFC10
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2CCFFD0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CD00C0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CD0170
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CD0290
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CD0460
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CD0630
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CD0750
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Utilities.InternedString[]>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.InputSystem.Utilities.InternedString> _comparer; // 0x30
        public KeyCollection<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Utilities.InternedString[]> _keys; // 0x38
        public ValueCollection<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Utilities.InternedString[]> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CCDC60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CCA550
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CCDCF0
        public void set_Item(){} // RVA: 0x2CCDDA0
        public void Add(){} // RVA: 0x2CCDDE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CCDE20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CCDE70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CCDF40
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CCE030
        public void ContainsValue(){} // RVA: 0x2BED020
        public void CopyTo(){} // RVA: 0x2BF7D70
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2CCE070
        public void FindEntry(){} // RVA: 0x2CCE3C0
        public void Initialize(){} // RVA: 0x2CCE6A0
        public void TryInsert(){} // RVA: 0x2CCE820
        public void OnDeserialization(){} // RVA: 0x2CCEE50
        public void Resize(){} // RVA: 0x2CCF380 | overloaded x2
        public void Remove(){} // RVA: 0x2CCF840 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CCFB10
        public void TryAdd(){} // RVA: 0x2CCFBD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2BF9A20
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CCFC10
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2CCFFD0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CD00C0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CD0170
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CD0290
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CD0460
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CD0630
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CD0750
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.InputSystem.Utilities.InternedString,PrecompiledLayout>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.InputSystem.Utilities.InternedString> _comparer; // 0x30
        public KeyCollection<UnityEngine.InputSystem.Utilities.InternedString,PrecompiledLayout> _keys; // 0x38
        public ValueCollection<UnityEngine.InputSystem.Utilities.InternedString,PrecompiledLayout> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CD1190 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CCA550
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CCA570
        public void set_Item(){} // RVA: 0x2CD1220
        public void Add(){} // RVA: 0x2CD1270
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CD12C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CD1320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CD1400
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CCA930
        public void ContainsValue(){} // RVA: 0x2CD1510
        public void CopyTo(){} // RVA: 0x2CCAA60
        public void GetEnumerator(){} // RVA: 0x2C22F20
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C22FD0
        public void GetObjectData(){} // RVA: 0x2CD1600
        public void FindEntry(){} // RVA: 0x2CCAF10
        public void Initialize(){} // RVA: 0x2CD1950
        public void TryInsert(){} // RVA: 0x2CD1AD0
        public void OnDeserialization(){} // RVA: 0x2CD2100
        public void Resize(){} // RVA: 0x2CD2650 | overloaded x2
        public void Remove(){} // RVA: 0x2CCC3A0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CCC680
        public void TryAdd(){} // RVA: 0x2CD2840
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CCC790
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CD2890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C22FD0
        public void EnsureCapacity(){} // RVA: 0x2CD2C70
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CD2D60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C0B360
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CCCD20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CD2E10
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CD2FF0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CCD230
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C25800
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CCD350
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.InputSystem.Utilities.InternedString,System.Type>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.InputSystem.Utilities.InternedString> _comparer; // 0x30
        public KeyCollection<UnityEngine.InputSystem.Utilities.InternedString,System.Type> _keys; // 0x38
        public ValueCollection<UnityEngine.InputSystem.Utilities.InternedString,System.Type> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CCDC60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CCA550
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CCDCF0
        public void set_Item(){} // RVA: 0x2CCDDA0
        public void Add(){} // RVA: 0x2CCDDE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CCDE20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CCDE70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CCDF40
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CCE030
        public void ContainsValue(){} // RVA: 0x2BED020
        public void CopyTo(){} // RVA: 0x2BF7D70
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2CCE070
        public void FindEntry(){} // RVA: 0x2CCE3C0
        public void Initialize(){} // RVA: 0x2CCE6A0
        public void TryInsert(){} // RVA: 0x2CCE820
        public void OnDeserialization(){} // RVA: 0x2CCEE50
        public void Resize(){} // RVA: 0x2CCF380 | overloaded x2
        public void Remove(){} // RVA: 0x2CCF840 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CCFB10
        public void TryAdd(){} // RVA: 0x2CCFBD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2BF9A20
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CCFC10
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2CCFFD0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CD00C0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CD0170
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CD0290
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CD0460
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CD0630
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CD0750
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Utilities.InternedString>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.InputSystem.Utilities.InternedString> _comparer; // 0x30
        public KeyCollection<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Utilities.InternedString> _keys; // 0x38
        public ValueCollection<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Utilities.InternedString> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CCA4C0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CCA550
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CCA570
        public void set_Item(){} // RVA: 0x2CCA640
        public void Add(){} // RVA: 0x2CCA690
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CCA6E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CCA740
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CCA820
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CCA930
        public void ContainsValue(){} // RVA: 0x2CCA970
        public void CopyTo(){} // RVA: 0x2CCAA60
        public void GetEnumerator(){} // RVA: 0x2C22F20
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C22FD0
        public void GetObjectData(){} // RVA: 0x2CCABC0
        public void FindEntry(){} // RVA: 0x2CCAF10
        public void Initialize(){} // RVA: 0x2CCB1F0
        public void TryInsert(){} // RVA: 0x2CCB370
        public void OnDeserialization(){} // RVA: 0x2CCB9A0
        public void Resize(){} // RVA: 0x2CCBEF0 | overloaded x2
        public void Remove(){} // RVA: 0x2CCC3A0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CCC680
        public void TryAdd(){} // RVA: 0x2CCC740
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CCC790
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CCC7A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C22FD0
        public void EnsureCapacity(){} // RVA: 0x2CCCB80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CCCC70
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CCCD20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CCCE70
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CCD050
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CCD230
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C25800
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CCD350
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<UnityEngine.InputSystem.Utilities.InternedString,System.Func`1<UnityEngine.InputSystem.Layouts.InputControlLayout>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.InputSystem.Utilities.InternedString> _comparer; // 0x30
        public KeyCollection<UnityEngine.InputSystem.Utilities.InternedString,System.Func`1<UnityEngine.InputSystem.Layouts.InputControlLayout>> _keys; // 0x38
        public ValueCollection<UnityEngine.InputSystem.Utilities.InternedString,System.Func`1<UnityEngine.InputSystem.Layouts.InputControlLayout>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2CCDC60 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CCA550
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CCDCF0
        public void set_Item(){} // RVA: 0x2CCDDA0
        public void Add(){} // RVA: 0x2CCDDE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2CCDE20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2CCDE70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2CCDF40
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CCE030
        public void ContainsValue(){} // RVA: 0x2BED020
        public void CopyTo(){} // RVA: 0x2BF7D70
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2CCE070
        public void FindEntry(){} // RVA: 0x2CCE3C0
        public void Initialize(){} // RVA: 0x2CCE6A0
        public void TryInsert(){} // RVA: 0x2CCE820
        public void OnDeserialization(){} // RVA: 0x2CCEE50
        public void Resize(){} // RVA: 0x2CCF380 | overloaded x2
        public void Remove(){} // RVA: 0x2CCF840 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CCFB10
        public void TryAdd(){} // RVA: 0x2CCFBD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2BF9A20
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2CCFC10
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2CCFFD0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2CD00C0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C1B030
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CD0170
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2CD0290
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2CD0460
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CD0630
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CD0750
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.Type,UnityEngine.ISubsystem>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,UnityEngine.ISubsystem> _keys; // 0x38
        public ValueCollection<System.Type,UnityEngine.ISubsystem> _values; // 0x40
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
        public Entry<object,object>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<object> _comparer; // 0x30
        public KeyCollection<object,object> _keys; // 0x38
        public ValueCollection<object,object> _values; // 0x40
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
        public Entry<int,ÏÏÎÎÎÍÍÍÍÎÎÏÌÏÎÎÌÍÍÌÍÍÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,ÏÏÎÎÎÍÍÍÍÎÎÏÌÏÎÎÌÍÍÌÍÍÌ> _keys; // 0x38
        public ValueCollection<int,ÏÏÎÎÎÍÍÍÍÎÎÏÌÏÎÎÌÍÍÌÍÍÌ> _values; // 0x40
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
        public Entry<string,string>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,string> _keys; // 0x38
        public ValueCollection<string,string> _values; // 0x40
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
        public Entry<int,System.Collections.Generic.List`1<ÌÍÎÌÏÏÏÌÍÍÌÎÏÎÌÎÎÍÎÏÌÌÍ>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,System.Collections.Generic.List`1<ÌÍÎÌÏÏÏÌÍÍÌÎÏÎÌÎÎÍÎÏÌÌÍ>> _keys; // 0x38
        public ValueCollection<int,System.Collections.Generic.List`1<ÌÍÎÌÏÏÏÌÍÍÌÎÏÎÌÎÎÍÎÏÌÌÍ>> _values; // 0x40
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
        public Entry<ÌÍÌÌÎÎÌÏÌÍÎÎÎÏÏÏÌÎÏÌÍÌÎ,ÍÌÌÍÎÏÍÎÏÌÏÏÍÏÎÍÏÏÎÏÎÌÎ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÌÍÌÌÎÎÌÏÌÍÎÎÎÏÏÏÌÎÏÌÍÌÎ> _comparer; // 0x30
        public KeyCollection<ÌÍÌÌÎÎÌÏÌÍÎÎÎÏÏÏÌÎÏÌÍÌÎ,ÍÌÌÍÎÏÍÎÏÌÏÏÍÏÎÍÏÏÎÏÎÌÎ> _keys; // 0x38
        public ValueCollection<ÌÍÌÌÎÎÌÏÌÍÎÎÎÏÏÏÌÎÏÌÍÌÎ,ÍÌÌÍÎÏÍÎÏÌÏÏÍÏÎÍÏÏÎÏÎÌÎ> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DA4AF0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CEB7D0
        public void set_Item(){} // RVA: 0x2DA4B80
        public void Add(){} // RVA: 0x2DA4BC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2DA4C00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2DA4C50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2DA4D30
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CEBB00
        public void ContainsValue(){} // RVA: 0x2DA4E30
        public void CopyTo(){} // RVA: 0x2D08200
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2DA4F20
        public void FindEntry(){} // RVA: 0x2CEC0D0
        public void Initialize(){} // RVA: 0x2DA5270
        public void TryInsert(){} // RVA: 0x2DA53F0
        public void OnDeserialization(){} // RVA: 0x2DA5840
        public void Resize(){} // RVA: 0x2DA5D90 | overloaded x2
        public void Remove(){} // RVA: 0x2D096A0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2D09910
        public void TryAdd(){} // RVA: 0x2DA6020
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2D099D0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2DA6060
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2DA6430
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2DA6520
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2C0EC10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CEDCA0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DA65D0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DA67B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CEE1B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2D0A310
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,System.Collections.Generic.List`1<ÎÏÏÌÎÎÍÍÏÍÎÏÌÎÏÍÎÍÍÍÍÏÎ>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Collections.Generic.List`1<ÎÏÏÌÎÎÍÍÏÍÎÏÌÎÏÍÎÍÍÍÍÏÎ>> _keys; // 0x38
        public ValueCollection<string,System.Collections.Generic.List`1<ÎÏÏÌÎÎÍÍÏÍÎÏÌÎÏÍÎÍÍÍÍÏÎ>> _values; // 0x40
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
        public Entry<int,ÍÌÏÍÎÍÌÍÌÌÏÍÍÏÌÎÎÍÌÌÎÌÏ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,ÍÌÏÍÎÍÌÍÌÌÏÍÍÏÌÎÎÍÌÌÎÌÏ> _keys; // 0x38
        public ValueCollection<int,ÍÌÏÍÎÍÌÍÌÌÏÍÍÏÌÎÎÍÌÌÎÌÏ> _values; // 0x40
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
        public Entry<System.Type,ÏÍÏÏÏÏÎÎÌÌÌÏÏÎÏÏÌÎÍÍÌÏÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,ÏÍÏÏÏÏÎÎÌÌÌÏÏÎÏÏÌÎÍÍÌÏÌ> _keys; // 0x38
        public ValueCollection<System.Type,ÏÍÏÏÏÏÎÎÌÌÌÏÏÎÏÏÌÎÍÍÌÏÌ> _values; // 0x40
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
        public Entry<System.Type,ÌÏÌÏÎÎÌÌÍÏÌÏÌÏÏÏÏÌÌÏÎÍÏ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,ÌÏÌÏÎÎÌÌÍÏÌÏÌÏÏÏÏÌÌÏÎÍÏ> _keys; // 0x38
        public ValueCollection<System.Type,ÌÏÌÏÎÎÌÌÍÏÌÏÌÏÏÏÏÌÌÏÎÍÏ> _values; // 0x40
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
        public Entry<CachedCodeEntryKey,CachedCodeEntry>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<CachedCodeEntryKey> _comparer; // 0x30
        public KeyCollection<CachedCodeEntryKey,CachedCodeEntry> _keys; // 0x38
        public ValueCollection<CachedCodeEntryKey,CachedCodeEntry> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E12BD0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2E12C60
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2E12C80
        public void set_Item(){} // RVA: 0x2E12D50
        public void Add(){} // RVA: 0x2E12D90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2E12DD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2E12E30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2E12F00
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2E13020
        public void ContainsValue(){} // RVA: 0x2DB1590
        public void CopyTo(){} // RVA: 0x2E13060
        public void GetEnumerator(){} // RVA: 0x2C22F20
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C22FD0
        public void GetObjectData(){} // RVA: 0x2E131F0
        public void FindEntry(){} // RVA: 0x2E13540
        public void Initialize(){} // RVA: 0x2E13860
        public void TryInsert(){} // RVA: 0x2E139E0
        public void OnDeserialization(){} // RVA: 0x2E13FE0
        public void Resize(){} // RVA: 0x2E14530 | overloaded x2
        public void Remove(){} // RVA: 0x2E14A00 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2E14D00
        public void TryAdd(){} // RVA: 0x2E14DD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2E14E10
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2E14E20
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C22FD0
        public void EnsureCapacity(){} // RVA: 0x2E151F0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2E152E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2E15390
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2E154C0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2E156B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2E158A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C25800
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2E159D0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,int> _keys; // 0x38
        public ValueCollection<string,int> _values; // 0x40
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
        public Entry<ulong,System.Action`1<...[]>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ulong> _comparer; // 0x30
        public KeyCollection<ulong,System.Action`1<...[]>> _keys; // 0x38
        public ValueCollection<ulong,System.Action`1<...[]>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEA8D0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2DE7A10
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2DEA960
        public void set_Item(){} // RVA: 0x2DEAA00
        public void Add(){} // RVA: 0x2DEAA30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2DEAA60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2DEAAB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2DEAB70
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2DE7D20
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2CC1810
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2DEAC50
        public void FindEntry(){} // RVA: 0x2DE80A0
        public void Initialize(){} // RVA: 0x2DEAFA0
        public void TryInsert(){} // RVA: 0x2DEB120
        public void OnDeserialization(){} // RVA: 0x2DEB600
        public void Resize(){} // RVA: 0x2DEBB20 | overloaded x2
        public void Remove(){} // RVA: 0x2DEBF10 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2DEC140
        public void TryAdd(){} // RVA: 0x2DEC200
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CC31B0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2DEC230
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2DEC5C0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2DEC6B0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2DEC760
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DEC880
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DECA40
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2DE9F00
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2DECC00
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ulong,SingleAnchorDelegatePair>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ulong> _comparer; // 0x30
        public KeyCollection<ulong,SingleAnchorDelegatePair> _keys; // 0x38
        public ValueCollection<ulong,SingleAnchorDelegatePair> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DF08B0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2DE7A10
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2DED5A0
        public void set_Item(){} // RVA: 0x2DF0940
        public void Add(){} // RVA: 0x2DF0980
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2DF09C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2DF0A10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2DF0AF0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2DED910
        public void ContainsValue(){} // RVA: 0x2DF0BF0
        public void CopyTo(){} // RVA: 0x2C02A00
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2DF0CE0
        public void FindEntry(){} // RVA: 0x2DEDED0
        public void Initialize(){} // RVA: 0x2DF1030
        public void TryInsert(){} // RVA: 0x2DF11B0
        public void OnDeserialization(){} // RVA: 0x2DF1690
        public void Resize(){} // RVA: 0x2DF1BC0 | overloaded x2
        public void Remove(){} // RVA: 0x2DEF0E0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2DEF310
        public void TryAdd(){} // RVA: 0x2DF1DC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C044D0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2DF1E00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2DF21F0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2DF22E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2DEF9B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DF2390
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DF2560
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2DEFE90
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2DEFFA0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ulong,System.Action`2<UnboundAnchor,bool>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ulong> _comparer; // 0x30
        public KeyCollection<ulong,System.Action`2<UnboundAnchor,bool>> _keys; // 0x38
        public ValueCollection<ulong,System.Action`2<UnboundAnchor,bool>> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEA8D0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2DE7A10
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2DEA960
        public void set_Item(){} // RVA: 0x2DEAA00
        public void Add(){} // RVA: 0x2DEAA30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2DEAA60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2DEAAB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2DEAB70
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2DE7D20
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2CC1810
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2DEAC50
        public void FindEntry(){} // RVA: 0x2DE80A0
        public void Initialize(){} // RVA: 0x2DEAFA0
        public void TryInsert(){} // RVA: 0x2DEB120
        public void OnDeserialization(){} // RVA: 0x2DEB600
        public void Resize(){} // RVA: 0x2DEBB20 | overloaded x2
        public void Remove(){} // RVA: 0x2DEBF10 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2DEC140
        public void TryAdd(){} // RVA: 0x2DEC200
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CC31B0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2DEC230
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2DEC5C0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2DEC6B0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2DEC760
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DEC880
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DECA40
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2DE9F00
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2DECC00
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ulong,OVRSpatialAnchor>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ulong> _comparer; // 0x30
        public KeyCollection<ulong,OVRSpatialAnchor> _keys; // 0x38
        public ValueCollection<ulong,OVRSpatialAnchor> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEA8D0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2DE7A10
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2DEA960
        public void set_Item(){} // RVA: 0x2DEAA00
        public void Add(){} // RVA: 0x2DEAA30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2DEAA60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2DEAAB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2DEAB70
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2DE7D20
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2CC1810
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2DEAC50
        public void FindEntry(){} // RVA: 0x2DE80A0
        public void Initialize(){} // RVA: 0x2DEAFA0
        public void TryInsert(){} // RVA: 0x2DEB120
        public void OnDeserialization(){} // RVA: 0x2DEB600
        public void Resize(){} // RVA: 0x2DEBB20 | overloaded x2
        public void Remove(){} // RVA: 0x2DEBF10 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2DEC140
        public void TryAdd(){} // RVA: 0x2DEC200
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CC31B0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2DEC230
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2DEC5C0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2DEC6B0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2DEC760
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DEC880
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DECA40
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2DE9F00
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2DECC00
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.Guid,OVRSpatialAnchor>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Guid> _comparer; // 0x30
        public KeyCollection<System.Guid,OVRSpatialAnchor> _keys; // 0x38
        public ValueCollection<System.Guid,OVRSpatialAnchor> _values; // 0x40
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
        public Entry<0x65895580,0x65895268>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x65895580> _comparer; // 0x30
        public KeyCollection<0x65895580,0x65895268> _keys; // 0x38
        public ValueCollection<0x65895580,0x65895268> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C7DAF0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C780B0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C7B380
        public void set_Item(){} // RVA: 0x2C7DB80
        public void Add(){} // RVA: 0x2C7DBB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C7DBE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C7DC30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C7DCF0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C783C0
        public void ContainsValue(){} // RVA: 0x2C55790
        public void CopyTo(){} // RVA: 0x2C52F40
        public void GetEnumerator(){} // RVA: 0x2C09520
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C095B0
        public void GetObjectData(){} // RVA: 0x2C7DDD0
        public void FindEntry(){} // RVA: 0x2C78740
        public void Initialize(){} // RVA: 0x2C7E120
        public void TryInsert(){} // RVA: 0x2C7E2A0
        public void OnDeserialization(){} // RVA: 0x2C7E710
        public void Resize(){} // RVA: 0x2C7EC20 | overloaded x2
        public void Remove(){} // RVA: 0x2C7C6B0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C7C8C0
        public void TryAdd(){} // RVA: 0x2C7EE10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C54310
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C7EE40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C095B0
        public void EnsureCapacity(){} // RVA: 0x2C7F200
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C7F2F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C7CEC0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C7F3A0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C7F550
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C7A570
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0B950
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C7A680
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<0x65895580,bool>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x65895580> _comparer; // 0x30
        public KeyCollection<0x65895580,bool> _keys; // 0x38
        public ValueCollection<0x65895580,bool> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C78020 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C780B0
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C780D0
        public void set_Item(){} // RVA: 0x2C78170
        public void Add(){} // RVA: 0x2C781A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C781D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C78220
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C782E0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C783C0
        public void ContainsValue(){} // RVA: 0x2C47100
        public void CopyTo(){} // RVA: 0x2C471D0
        public void GetEnumerator(){} // RVA: 0x2C09520
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C095B0
        public void GetObjectData(){} // RVA: 0x2C783F0
        public void FindEntry(){} // RVA: 0x2C78740
        public void Initialize(){} // RVA: 0x2C789A0
        public void TryInsert(){} // RVA: 0x2C78B20
        public void OnDeserialization(){} // RVA: 0x2C78F90
        public void Resize(){} // RVA: 0x2C794A0 | overloaded x2
        public void Remove(){} // RVA: 0x2C79880 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C79A90
        public void TryAdd(){} // RVA: 0x2C79B00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C485C0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C79B30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C095B0
        public void EnsureCapacity(){} // RVA: 0x2C79F10
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C7A000
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C7A0B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C7A1F0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C7A3B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C7A570
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0B950
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C7A680
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.Type,AttributeInfo>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,AttributeInfo> _keys; // 0x38
        public ValueCollection<System.Type,AttributeInfo> _values; // 0x40
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
        public Entry<string,System.Globalization.ISimpleCollator>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Globalization.ISimpleCollator> _keys; // 0x38
        public ValueCollection<string,System.Globalization.ISimpleCollator> _values; // 0x40
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
        public Entry<string,System.Globalization.CultureInfo>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Globalization.CultureInfo> _keys; // 0x38
        public ValueCollection<string,System.Globalization.CultureInfo> _values; // 0x40
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
        public Entry<int,System.Globalization.CultureInfo>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,System.Globalization.CultureInfo> _keys; // 0x38
        public ValueCollection<int,System.Globalization.CultureInfo> _values; // 0x40
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
        public Entry<int,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,int> _keys; // 0x38
        public ValueCollection<int,int> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C52BC0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C52C50
        public void set_Item(){} // RVA: 0x2C52CF0
        public void Add(){} // RVA: 0x2C52D20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C52D50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C52DA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C52E60
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C40910
        public void ContainsValue(){} // RVA: 0x2C09340
        public void CopyTo(){} // RVA: 0x2C52F40
        public void GetEnumerator(){} // RVA: 0x2C09520
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C095B0
        public void GetObjectData(){} // RVA: 0x2C53020
        public void FindEntry(){} // RVA: 0x2C40E70
        public void Initialize(){} // RVA: 0x2C53370
        public void TryInsert(){} // RVA: 0x2C534F0
        public void OnDeserialization(){} // RVA: 0x2C53960
        public void Resize(){} // RVA: 0x2C53E70 | overloaded x2
        public void Remove(){} // RVA: 0x2C54060 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C54270
        public void TryAdd(){} // RVA: 0x2C542E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C54310
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C54320
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C095B0
        public void EnsureCapacity(){} // RVA: 0x2C546E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C547D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C54880
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C549C0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C54B70
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C42CB0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0B950
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C42DC0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,System.Collections.Generic.List`1<int>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,System.Collections.Generic.List`1<int>> _keys; // 0x38
        public ValueCollection<int,System.Collections.Generic.List`1<int>> _values; // 0x40
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
        public Entry<int,Unity.Services.Core.Internal.IServiceComponent>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,Unity.Services.Core.Internal.IServiceComponent> _keys; // 0x38
        public ValueCollection<int,Unity.Services.Core.Internal.IServiceComponent> _values; // 0x40
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
        public Entry<int,Unity.Services.Core.Internal.IInitializablePackage>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,Unity.Services.Core.Internal.IInitializablePackage> _keys; // 0x38
        public ValueCollection<int,Unity.Services.Core.Internal.IInitializablePackage> _values; // 0x40
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
        public Entry<int,object>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,object> _keys; // 0x38
        public ValueCollection<int,object> _values; // 0x40
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
        public Entry<System.Type,Unity.Services.Core.Telemetry.Internal.IMetrics>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,Unity.Services.Core.Telemetry.Internal.IMetrics> _keys; // 0x38
        public ValueCollection<System.Type,Unity.Services.Core.Telemetry.Internal.IMetrics> _values; // 0x40
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
        public Entry<int,System.Threading.Tasks.Task>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,System.Threading.Tasks.Task> _keys; // 0x38
        public ValueCollection<int,System.Threading.Tasks.Task> _values; // 0x40
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
        public Entry<string,System.TimeZoneInfo>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.TimeZoneInfo> _keys; // 0x38
        public ValueCollection<string,System.TimeZoneInfo> _values; // 0x40
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
        public Entry<string,0x657DD8B8>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,0x657DD8B8> _keys; // 0x38
        public ValueCollection<string,0x657DD8B8> _values; // 0x40
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
        public Entry<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCacheKey,object>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCacheKey> _comparer; // 0x30
        public KeyCollection<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCacheKey,object> _keys; // 0x38
        public ValueCollection<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCacheKey,object> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DB1100 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2DB1190
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2DB11B0
        public void set_Item(){} // RVA: 0x2DB1280
        public void Add(){} // RVA: 0x2DB12C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2DB1300
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2DB1360
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2DB1430
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2DB1550
        public void ContainsValue(){} // RVA: 0x2DB1590
        public void CopyTo(){} // RVA: 0x2DB16B0
        public void GetEnumerator(){} // RVA: 0x2C22F20
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C22FD0
        public void GetObjectData(){} // RVA: 0x2DB1810
        public void FindEntry(){} // RVA: 0x2DB1B60
        public void Initialize(){} // RVA: 0x2DB1E80
        public void TryInsert(){} // RVA: 0x2DB2000
        public void OnDeserialization(){} // RVA: 0x2DB2680
        public void Resize(){} // RVA: 0x2DB2BD0 | overloaded x2
        public void Remove(){} // RVA: 0x2DB3050 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2DB32F0
        public void TryAdd(){} // RVA: 0x2DB33C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2DB3400
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2DB3410
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C22FD0
        public void EnsureCapacity(){} // RVA: 0x2DB37E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2DB38D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2DB3980
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DB3AB0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DB3CA0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2DB3E90
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C25800
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2DB3FC0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,ServiceDescriptorCacheItem>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier> _comparer; // 0x30
        public KeyCollection<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,ServiceDescriptorCacheItem> _keys; // 0x38
        public ValueCollection<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,ServiceDescriptorCacheItem> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DB8110 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2DB4A60
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2DB4A80
        public void set_Item(){} // RVA: 0x2DB81A0
        public void Add(){} // RVA: 0x2DB81F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2DB8240
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2DB82A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2DB8380
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2DB4E40
        public void ContainsValue(){} // RVA: 0x2DB8490
        public void CopyTo(){} // RVA: 0x2CCAA60
        public void GetEnumerator(){} // RVA: 0x2C22F20
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C22FD0
        public void GetObjectData(){} // RVA: 0x2DB8580
        public void FindEntry(){} // RVA: 0x2DB5420
        public void Initialize(){} // RVA: 0x2DB88D0
        public void TryInsert(){} // RVA: 0x2DB8A50
        public void OnDeserialization(){} // RVA: 0x2DB9060
        public void Resize(){} // RVA: 0x2DB95B0 | overloaded x2
        public void Remove(){} // RVA: 0x2DB97A0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2DB9A70
        public void TryAdd(){} // RVA: 0x2DB9B30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CCC790
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2DB9B80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C22FD0
        public void EnsureCapacity(){} // RVA: 0x2DB9F60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2DBA050
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2DB71F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DBA100
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DBA2E0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2DB7700
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C25800
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2DB7820
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,ChainItemInfo>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier> _comparer; // 0x30
        public KeyCollection<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,ChainItemInfo> _keys; // 0x38
        public ValueCollection<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,ChainItemInfo> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DB49D0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2DB4A60
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2DB4A80
        public void set_Item(){} // RVA: 0x2DB4B50
        public void Add(){} // RVA: 0x2DB4BA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2DB4BF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2DB4C50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2DB4D30
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2DB4E40
        public void ContainsValue(){} // RVA: 0x2DB4E80
        public void CopyTo(){} // RVA: 0x2DB4F70
        public void GetEnumerator(){} // RVA: 0x2C22F20
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C22FD0
        public void GetObjectData(){} // RVA: 0x2DB50D0
        public void FindEntry(){} // RVA: 0x2DB5420
        public void Initialize(){} // RVA: 0x2DB56F0
        public void TryInsert(){} // RVA: 0x2DB5870
        public void OnDeserialization(){} // RVA: 0x2DB5E80
        public void Resize(){} // RVA: 0x2DB63D0 | overloaded x2
        public void Remove(){} // RVA: 0x2DB6870 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2DB6B40
        public void TryAdd(){} // RVA: 0x2DB6C10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2DB6C60
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2DB6C70
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C22FD0
        public void EnsureCapacity(){} // RVA: 0x2DB7050
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2DB7140
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2DB71F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DB7340
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DB7520
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2DB7700
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C25800
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2DB7820
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<int,float>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,float> _keys; // 0x38
        public ValueCollection<int,float> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C62550 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C625E0
        public void set_Item(){} // RVA: 0x2C62680
        public void Add(){} // RVA: 0x2C626B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C626E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C62730
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C627F0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C40910
        public void ContainsValue(){} // RVA: 0x2C628D0
        public void CopyTo(){} // RVA: 0x2C629B0
        public void GetEnumerator(){} // RVA: 0x2C09520
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C095B0
        public void GetObjectData(){} // RVA: 0x2C62A90
        public void FindEntry(){} // RVA: 0x2C40E70
        public void Initialize(){} // RVA: 0x2C62DE0
        public void TryInsert(){} // RVA: 0x2C62F60
        public void OnDeserialization(){} // RVA: 0x2C633C0
        public void Resize(){} // RVA: 0x2C638D0 | overloaded x2
        public void Remove(){} // RVA: 0x2C54060 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C54270
        public void TryAdd(){} // RVA: 0x2C63AC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C63AF0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C63B00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C095B0
        public void EnsureCapacity(){} // RVA: 0x2C63EE0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C63FD0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C0B360
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C64080
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C641C0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C64380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C42CB0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0B950
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C42DC0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,CategoryPrefix>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,CategoryPrefix> _keys; // 0x38
        public ValueCollection<string,CategoryPrefix> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D7DB90 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CEB7D0
        public void set_Item(){} // RVA: 0x2D7DC20
        public void Add(){} // RVA: 0x2D7DC60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D7DCA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D7DCF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D7DDD0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CEBB00
        public void ContainsValue(){} // RVA: 0x2D7DED0
        public void CopyTo(){} // RVA: 0x2CEBC20
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2D7DFC0
        public void FindEntry(){} // RVA: 0x2CEC0D0
        public void Initialize(){} // RVA: 0x2D7E310
        public void TryInsert(){} // RVA: 0x2D7E490
        public void OnDeserialization(){} // RVA: 0x2D7E950
        public void Resize(){} // RVA: 0x2D7EEA0 | overloaded x2
        public void Remove(){} // RVA: 0x2CED390 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CED610
        public void TryAdd(){} // RVA: 0x2D7F130
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CED710
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D7F170
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2D7F550
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D7F640
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CEDCA0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D7F6F0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D7F8D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CEE1B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEE2D0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,BestHTTP.HTTPRequest>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,BestHTTP.HTTPRequest> _keys; // 0x38
        public ValueCollection<string,BestHTTP.HTTPRequest> _values; // 0x40
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
        public Entry<string,EndpointAccessEntry>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,EndpointAccessEntry> _keys; // 0x38
        public ValueCollection<string,EndpointAccessEntry> _values; // 0x40
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
        public Entry<0x657CFBB0,string>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x657CFBB0> _comparer; // 0x30
        public KeyCollection<0x657CFBB0,string> _keys; // 0x38
        public ValueCollection<0x657CFBB0,string> _values; // 0x40
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
        public Entry<0x657CFBB0,int>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x657CFBB0> _comparer; // 0x30
        public KeyCollection<0x657CFBB0,int> _keys; // 0x38
        public ValueCollection<0x657CFBB0,int> _values; // 0x40
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
        public Entry<int,System.Action`1<UnityEngine.Texture>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,System.Action`1<UnityEngine.Texture>> _keys; // 0x38
        public ValueCollection<int,System.Action`1<UnityEngine.Texture>> _values; // 0x40
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
        public Entry<string,ÎÌÌÌÌÏÌÍÎÏÎÌÎÎÍÎÍÏÌÎÏÌÌ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÎÌÌÌÌÏÌÍÎÏÎÌÎÎÍÎÍÏÌÎÏÌÌ> _keys; // 0x38
        public ValueCollection<string,ÎÌÌÌÌÏÌÍÎÏÎÌÎÎÍÎÍÏÌÎÏÌÌ> _values; // 0x40
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
        public Entry<int,0x65885B98>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,0x65885B98> _keys; // 0x38
        public ValueCollection<int,0x65885B98> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C554B0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C52C50
        public void set_Item(){} // RVA: 0x2C55540
        public void Add(){} // RVA: 0x2C55570
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C555A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C555F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C556B0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C40910
        public void ContainsValue(){} // RVA: 0x2C55790
        public void CopyTo(){} // RVA: 0x2C52F40
        public void GetEnumerator(){} // RVA: 0x2C09520
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C095B0
        public void GetObjectData(){} // RVA: 0x2C55870
        public void FindEntry(){} // RVA: 0x2C40E70
        public void Initialize(){} // RVA: 0x2C55BC0
        public void TryInsert(){} // RVA: 0x2C55D40
        public void OnDeserialization(){} // RVA: 0x2C561B0
        public void Resize(){} // RVA: 0x2C566C0 | overloaded x2
        public void Remove(){} // RVA: 0x2C54060 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C54270
        public void TryAdd(){} // RVA: 0x2C568B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C54310
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C568E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C095B0
        public void EnsureCapacity(){} // RVA: 0x2C56CA0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C56D90
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C54880
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C56E40
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C56FF0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C42CB0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0B950
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C42DC0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<ÏÍÏÎÎÎÏÍÌÍÎÎÌÎÏÌÏÌÌÎÎÏÎ,UnityEngine.Sprite>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÏÍÏÎÎÎÏÍÌÍÎÎÌÎÏÌÏÌÌÎÎÏÎ> _comparer; // 0x30
        public KeyCollection<ÏÍÏÎÎÎÏÍÌÍÎÎÌÎÏÌÏÌÌÎÎÏÎ,UnityEngine.Sprite> _keys; // 0x38
        public ValueCollection<ÏÍÏÎÎÎÏÍÌÍÎÎÌÎÏÌÏÌÌÎÎÏÎ,UnityEngine.Sprite> _values; // 0x40
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
        public Entry<System.Type,0x658E2370>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,0x658E2370> _keys; // 0x38
        public ValueCollection<System.Type,0x658E2370> _values; // 0x40
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
        public Entry<System.Type,System.AttributeUsageAttribute>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,System.AttributeUsageAttribute> _keys; // 0x38
        public ValueCollection<System.Type,System.AttributeUsageAttribute> _values; // 0x40
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
        public Entry<Newtonsoft.Json.Serialization.JsonProperty,0x658E5288>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<Newtonsoft.Json.Serialization.JsonProperty> _comparer; // 0x30
        public KeyCollection<Newtonsoft.Json.Serialization.JsonProperty,0x658E5288> _keys; // 0x38
        public ValueCollection<Newtonsoft.Json.Serialization.JsonProperty,0x658E5288> _values; // 0x40
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
        public Entry<System.Type,0x658E0CC0>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x30
        public KeyCollection<System.Type,0x658E0CC0> _keys; // 0x38
        public ValueCollection<System.Type,0x658E0CC0> _values; // 0x40
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
        public Entry<ÍÎÌÏÏÌÌÏÍÎÌÎÎÎÌÎÍÏÎÏÏÍÍ,System.Collections.Generic.List`1<ÌÏÏÏÎÎÍÌÍÏÏÌÏÍÎÏÍÌÌÌÌÎÎ>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ÍÎÌÏÏÌÌÏÍÎÌÎÎÎÌÎÍÏÎÏÏÍÍ> _comparer; // 0x30
        public KeyCollection<ÍÎÌÏÏÌÌÏÍÎÌÎÎÎÌÎÍÏÎÏÏÍÍ,System.Collections.Generic.List`1<ÌÏÏÏÎÎÍÌÍÏÏÌÏÍÎÏÍÌÌÌÌÎÎ>> _keys; // 0x38
        public ValueCollection<ÍÎÌÏÏÌÌÏÍÎÌÎÎÎÌÎÍÏÎÏÏÍÍ,System.Collections.Generic.List`1<ÌÏÏÏÎÎÍÌÍÏÏÌÏÍÎÏÍÌÌÌÌÎÎ>> _values; // 0x40
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
        public Entry<UnityEngine.Material,bool>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<UnityEngine.Material> _comparer; // 0x30
        public KeyCollection<UnityEngine.Material,bool> _keys; // 0x38
        public ValueCollection<UnityEngine.Material,bool> _values; // 0x40
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
        public Entry<string,System.Collections.Generic.List`1<BestHTTP.ConnectionBase>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,System.Collections.Generic.List`1<BestHTTP.ConnectionBase>> _keys; // 0x38
        public ValueCollection<string,System.Collections.Generic.List`1<BestHTTP.ConnectionBase>> _values; // 0x40
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
        public Entry<ulong,BestHTTP.Caching.HTTPCacheFileInfo>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ulong> _comparer; // 0x30
        public KeyCollection<ulong,BestHTTP.Caching.HTTPCacheFileInfo> _keys; // 0x38
        public ValueCollection<ulong,BestHTTP.Caching.HTTPCacheFileInfo> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEA8D0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2DE7A10
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2DEA960
        public void set_Item(){} // RVA: 0x2DEAA00
        public void Add(){} // RVA: 0x2DEAA30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2DEAA60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2DEAAB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2DEAB70
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2DE7D20
        public void ContainsValue(){} // RVA: 0x2C0CA80
        public void CopyTo(){} // RVA: 0x2CC1810
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2DEAC50
        public void FindEntry(){} // RVA: 0x2DE80A0
        public void Initialize(){} // RVA: 0x2DEAFA0
        public void TryInsert(){} // RVA: 0x2DEB120
        public void OnDeserialization(){} // RVA: 0x2DEB600
        public void Resize(){} // RVA: 0x2DEBB20 | overloaded x2
        public void Remove(){} // RVA: 0x2DEBF10 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2DEC140
        public void TryAdd(){} // RVA: 0x2DEC200
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CC31B0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2DEC230
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2DEC5C0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2DEC6B0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2DEC760
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DEC880
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DECA40
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2DE9F00
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2DECC00
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<System.Uri,BestHTTP.Caching.HTTPCacheFileInfo>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<System.Uri> _comparer; // 0x30
        public KeyCollection<System.Uri,BestHTTP.Caching.HTTPCacheFileInfo> _keys; // 0x38
        public ValueCollection<System.Uri,BestHTTP.Caching.HTTPCacheFileInfo> _values; // 0x40
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
        public Entry<int,UnityEngine.Touch>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,UnityEngine.Touch> _keys; // 0x38
        public ValueCollection<int,UnityEngine.Touch> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2C64E40 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2C37860
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2C64ED0
        public void set_Item(){} // RVA: 0x2C64FB0
        public void Add(){} // RVA: 0x2C65020
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2C65090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2C65110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2C65260
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2C653C0
        public void ContainsValue(){} // RVA: 0x2C653F0
        public void CopyTo(){} // RVA: 0x2C65550
        public void GetEnumerator(){} // RVA: 0x2C656F0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C657B0
        public void GetObjectData(){} // RVA: 0x2C658B0
        public void FindEntry(){} // RVA: 0x2C65C00
        public void Initialize(){} // RVA: 0x2C65E80
        public void TryInsert(){} // RVA: 0x2C66000
        public void OnDeserialization(){} // RVA: 0x2C664D0
        public void Resize(){} // RVA: 0x2C66DD0 | overloaded x2
        public void Remove(){} // RVA: 0x2C671C0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2C67420
        public void TryAdd(){} // RVA: 0x2C674D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2C67540
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2C67550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C657B0
        public void EnsureCapacity(){} // RVA: 0x2C679E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2C67AD0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2C0B360
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2C67B80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2C67CF0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2C67EE0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2C680D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C681E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2C682E0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,ÎÍÏÎÏÎÎÏÍÎÏÏÎÌÎÎÌÍÏÌÎÏÍ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,ÎÍÏÎÏÎÎÏÍÎÏÏÎÌÎÎÌÍÏÌÎÏÍ> _keys; // 0x38
        public ValueCollection<string,ÎÍÏÎÏÎÎÏÍÎÏÏÎÌÎÎÌÍÏÌÎÏÍ> _values; // 0x40
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
        public Entry<int,System.Text.Encoding>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,System.Text.Encoding> _keys; // 0x38
        public ValueCollection<int,System.Text.Encoding> _values; // 0x40
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
        public Entry<int,System.Collections.Generic.List`1<VRC.Dynamics.VRCConstraintBase>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x30
        public KeyCollection<int,System.Collections.Generic.List`1<VRC.Dynamics.VRCConstraintBase>> _keys; // 0x38
        public ValueCollection<int,System.Collections.Generic.List`1<VRC.Dynamics.VRCConstraintBase>> _values; // 0x40
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
        public Entry<string,byte[]>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,byte[]> _keys; // 0x38
        public ValueCollection<string,byte[]> _values; // 0x40
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
        public Entry<0x659B0DA0,System.Collections.Generic.List`1<Callback>>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x659B0DA0> _comparer; // 0x30
        public KeyCollection<0x659B0DA0,System.Collections.Generic.List`1<Callback>> _keys; // 0x38
        public ValueCollection<0x659B0DA0,System.Collections.Generic.List`1<Callback>> _values; // 0x40
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
        public Entry<ulong,ResultCallback>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<ulong> _comparer; // 0x30
        public KeyCollection<ulong,ResultCallback> _keys; // 0x38
        public ValueCollection<ulong,ResultCallback> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DED510 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2DE7A10
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2DED5A0
        public void set_Item(){} // RVA: 0x2DED660
        public void Add(){} // RVA: 0x2DED6A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2DED6E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2DED730
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2DED810
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2DED910
        public void ContainsValue(){} // RVA: 0x2DED940
        public void CopyTo(){} // RVA: 0x2DEDA30
        public void GetEnumerator(){} // RVA: 0x2BED2D0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2BED380
        public void GetObjectData(){} // RVA: 0x2DEDB80
        public void FindEntry(){} // RVA: 0x2DEDED0
        public void Initialize(){} // RVA: 0x2DEE150
        public void TryInsert(){} // RVA: 0x2DEE2D0
        public void OnDeserialization(){} // RVA: 0x2DEE7B0
        public void Resize(){} // RVA: 0x2DEECE0 | overloaded x2
        public void Remove(){} // RVA: 0x2DEF0E0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2DEF310
        public void TryAdd(){} // RVA: 0x2DEF3D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2DEF410
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2DEF420
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2BED380
        public void EnsureCapacity(){} // RVA: 0x2DEF810
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2DEF900
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2DEF9B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DEFAF0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DEFCC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2DEFE90
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2BF0090
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2DEFFA0
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,Steamworks.Data.InputActionSetHandle_t>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Steamworks.Data.InputActionSetHandle_t> _keys; // 0x38
        public ValueCollection<string,Steamworks.Data.InputActionSetHandle_t> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D127F0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CE1930
        public void set_Item(){} // RVA: 0x2D12880
        public void Add(){} // RVA: 0x2D128B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D128E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D12930
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D129F0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2D12AD0
        public void CopyTo(){} // RVA: 0x2CE8D80
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D12BB0
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D12F00
        public void TryInsert(){} // RVA: 0x2D13080
        public void OnDeserialization(){} // RVA: 0x2D134E0
        public void Resize(){} // RVA: 0x2D13A20 | overloaded x2
        public void Remove(){} // RVA: 0x2CEA210 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CEA480
        public void TryAdd(){} // RVA: 0x2D13CA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CEA530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D13CD0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D14080
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D14170
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CE3D10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D14220
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D143F0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEAE30
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,Steamworks.Data.InputAnalogActionHandle_t>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Steamworks.Data.InputAnalogActionHandle_t> _keys; // 0x38
        public ValueCollection<string,Steamworks.Data.InputAnalogActionHandle_t> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D14D90 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CE1930
        public void set_Item(){} // RVA: 0x2D14E20
        public void Add(){} // RVA: 0x2D14E50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D14E80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D14ED0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D14F90
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2D15070
        public void CopyTo(){} // RVA: 0x2CE8D80
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D15150
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D154A0
        public void TryInsert(){} // RVA: 0x2D15620
        public void OnDeserialization(){} // RVA: 0x2D15A80
        public void Resize(){} // RVA: 0x2D15FC0 | overloaded x2
        public void Remove(){} // RVA: 0x2CEA210 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CEA480
        public void TryAdd(){} // RVA: 0x2D16240
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CEA530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D16270
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D16620
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D16710
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CE3D10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D167C0
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D16990
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEAE30
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<string,Steamworks.Data.InputDigitalActionHandle_t>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,Steamworks.Data.InputDigitalActionHandle_t> _keys; // 0x38
        public ValueCollection<string,Steamworks.Data.InputDigitalActionHandle_t> _values; // 0x40
        public object _syncRoot; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2D175D0 | overloaded x9
        public void get_Comparer(){} // RVA: 0x2CE1910
        public void get_Count(){} // RVA: 0x2BECA00
        public void get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2BECA10
        public void get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2BECB20
        public void get_Item(){} // RVA: 0x2CE1930
        public void set_Item(){} // RVA: 0x2D17660
        public void Add(){} // RVA: 0x2D17690
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2D176C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2D17710
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2D177D0
        public void Clear(){} // RVA: 0x2BECF70
        public void ContainsKey(){} // RVA: 0x2CE1BF0
        public void ContainsValue(){} // RVA: 0x2D178B0
        public void CopyTo(){} // RVA: 0x2CE8D80
        public void GetEnumerator(){} // RVA: 0x2C0CD00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x2C0CD90
        public void GetObjectData(){} // RVA: 0x2D17990
        public void FindEntry(){} // RVA: 0x2CE21A0
        public void Initialize(){} // RVA: 0x2D17CE0
        public void TryInsert(){} // RVA: 0x2D17E60
        public void OnDeserialization(){} // RVA: 0x2D182C0
        public void Resize(){} // RVA: 0x2D18800 | overloaded x2
        public void Remove(){} // RVA: 0x2CEA210 | overloaded x2
        public void TryGetValue(){} // RVA: 0x2CEA480
        public void TryAdd(){} // RVA: 0x2D18A80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2CEA530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2D18AB0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2C0CD90
        public void EnsureCapacity(){} // RVA: 0x2D18E60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2D18F50
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2BEF800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2BEF920
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2CE3D10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2D19000
        public void IsCompatibleKey(){} // RVA: 0x2BEFD30
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2D191D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2CE41F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2C0F1E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2CEAE30
    }

    public class Dictionary`2
    {
        public int[] _buckets; // 0x10
        public Entry<uint,Steamworks.SocketManager>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<uint> _comparer; // 0x30
        public KeyCollection<uint,Steamworks.SocketManager> _keys; // 0x38
        public ValueCollection<uint,Steamworks.SocketManager> _values; // 0x40
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
        public Entry<uint,Steamworks.ConnectionManager>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<uint> _comparer; // 0x30
        public KeyCollection<uint,Steamworks.ConnectionManager> _keys; // 0x38
        public ValueCollection<uint,Steamworks.ConnectionManager> _values; // 0x40
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
        public Entry<string,0x6588F750>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public KeyCollection<string,0x6588F750> _keys; // 0x38
        public ValueCollection<string,0x6588F750> _values; // 0x40
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
        public Entry<0x6588F750,ÌÌÌÏÌÍÍÎÎÍÏÌÍÏÏÍÍÌÌÍÎÎÍ>[] _entries; // 0x18
        public int _count; // 0x20
        public int _freeList; // 0x24
        public int _freeCount; // 0x28
        public int _version; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<0x6588F750> _comparer; // 0x30
        public KeyCollection<0x6588F750,ÌÌÌÏÌÍÍÎÎÍÏÌÍÏÏÍÍÌÌÍÎÎÍ> _keys; // 0x38
        public ValueCollection<0x6588F750,ÌÌÌÏÌÍÍÎÎÍÏÌÍÏÏÍÍÌÌÍÎÎÍ> _values; // 0x40
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

}