// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Generic
// Classes: 100
// Methods: 4358

namespace ThirdParty.DotNet.System.Collections.Generic
{
    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAADC720
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAADC7B0
        public void set_Item(){} // RVA: 0x7AAADC840
        public void Add(){} // RVA: 0x7AAADC890
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAADC8E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAADC940
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAADCA40
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAADCB60
        public void ContainsValue(){} // RVA: 0x7AAADCB90
        public void CopyTo(){} // RVA: 0x7AAADCCA0
        public void GetEnumerator(){} // RVA: 0x7AAA17100
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA171B0
        public void GetObjectData(){} // RVA: 0x7AAADCE60
        public void FindEntry(){} // RVA: 0x7AAADD1B0
        public void Initialize(){} // RVA: 0x7AAADD3F0
        public void TryInsert(){} // RVA: 0x7AAADD570
        public void OnDeserialization(){} // RVA: 0x7AAADDA60
        public void Resize(){} // RVA: 0x7AAADDFB0
        public void Remove(){} // RVA: 0x7AAADE490
        public void TryGetValue(){} // RVA: 0x7AAADE730
        public void TryAdd(){} // RVA: 0x7AAADE800
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAADE850
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAADE860
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA171B0
        public void EnsureCapacity(){} // RVA: 0x7AAADEC70
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAADED60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA9E3240
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAADEE10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAADEF70
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAADF150
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADF330
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA19A70
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADF450
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAA75220
        public void get_Comparer(){} // RVA: 0x7AAA6D400
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAA752B0
        public void set_Item(){} // RVA: 0x7AAA75380
        public void Add(){} // RVA: 0x7AAA753D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAA75420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAA75490
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAA755B0
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAA756E0
        public void ContainsValue(){} // RVA: 0x7AAA75710
        public void CopyTo(){} // RVA: 0x7AAA75840
        public void GetEnumerator(){} // RVA: 0x7AAA1AF80
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA1B030
        public void GetObjectData(){} // RVA: 0x7AAA759D0
        public void FindEntry(){} // RVA: 0x7AAA75D20
        public void Initialize(){} // RVA: 0x7AAA75F80
        public void TryInsert(){} // RVA: 0x7AAA76100
        public void OnDeserialization(){} // RVA: 0x7AAA76630
        public void Resize(){} // RVA: 0x7AAA76B80
        public void Remove(){} // RVA: 0x7AAA76F80
        public void TryGetValue(){} // RVA: 0x7AAA771F0
        public void TryAdd(){} // RVA: 0x7AAA772C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA77310
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAA77320
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA1B030
        public void EnsureCapacity(){} // RVA: 0x7AAA77780
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAA77870
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA9E3240
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAA77920
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAA77A70
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAA77C50
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAA77E30
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA1DAC0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAA77F40
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAA4F720
        public void get_Comparer(){} // RVA: 0x7AAA2C1E0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAA4C690
        public void set_Item(){} // RVA: 0x7AAA4F7B0
        public void Add(){} // RVA: 0x7AAA4F7E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAA4F810
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAA4F850
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAA4F910
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAA4C970
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAA4F9F0
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAA4FB60
        public void FindEntry(){} // RVA: 0x7AAA4CEF0
        public void Initialize(){} // RVA: 0x7AAA4FEB0
        public void TryInsert(){} // RVA: 0x7AAA50030
        public void OnDeserialization(){} // RVA: 0x7AAA50510
        public void Resize(){} // RVA: 0x7AAA50A10
        public void Remove(){} // RVA: 0x7AAA50E10
        public void TryGetValue(){} // RVA: 0x7AAA51050
        public void TryAdd(){} // RVA: 0x7AAA51110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA51140
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAA51150
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAA51520
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAA51610
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAA516C0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAA517E0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAA51990
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAA4ED50
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAA51B40
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Clear(){} // RVA: 0x7AA9E0810
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void Remove(){} // RVA: 0x7AAADAF10
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Remove(){} // RVA: 0x7AAADACC0
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void Clear(){} // RVA: 0x7AA9E0810
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Remove(){} // RVA: 0x7AAADACC0
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void Clear(){} // RVA: 0x7AA9E0810
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAA072B0
        public void get_Comparer(){} // RVA: 0x7AAA07340
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAA07360
        public void set_Item(){} // RVA: 0x7AAA07400
        public void Add(){} // RVA: 0x7AAA07430
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAA07460
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAA074B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAA07570
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAA07650
        public void ContainsValue(){} // RVA: 0x7AAA07680
        public void CopyTo(){} // RVA: 0x7AAA07740
        public void GetEnumerator(){} // RVA: 0x7AAA07860
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA078F0
        public void GetObjectData(){} // RVA: 0x7AAA079C0
        public void FindEntry(){} // RVA: 0x7AAA07D10
        public void Initialize(){} // RVA: 0x7AAA07F70
        public void TryInsert(){} // RVA: 0x7AAA080F0
        public void OnDeserialization(){} // RVA: 0x7AAA08570
        public void Resize(){} // RVA: 0x7AAA08A70
        public void Remove(){} // RVA: 0x7AAA08E70
        public void TryGetValue(){} // RVA: 0x7AAA090A0
        public void TryAdd(){} // RVA: 0x7AAA09110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA09140
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAA09150
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA078F0
        public void EnsureCapacity(){} // RVA: 0x7AAA09530
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAA09620
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA9E3240
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAA096D0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAA09810
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAA099D0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAA09B90
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA09CA0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAA09D70
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Remove(){} // RVA: 0x7AAADACC0
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void Clear(){} // RVA: 0x7AA9E0810
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Remove(){} // RVA: 0x7AAADACC0
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void Clear(){} // RVA: 0x7AA9E0810
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Remove(){} // RVA: 0x7AAADACC0
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void Clear(){} // RVA: 0x7AA9E0810
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void .ctor(){} // RVA: 0x7AAAD8A50
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AABCD470
        public void get_Comparer(){} // RVA: 0x7AABBD740
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AABCD500
        public void set_Item(){} // RVA: 0x7AABCD5A0
        public void Add(){} // RVA: 0x7AABCD5D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AABCD600
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AABCD640
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AABCD700
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AABCD7E0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAA4F9F0
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AABCD810
        public void FindEntry(){} // RVA: 0x7AABCDB60
        public void Initialize(){} // RVA: 0x7AABCDDC0
        public void TryInsert(){} // RVA: 0x7AABCDF40
        public void OnDeserialization(){} // RVA: 0x7AABCE420
        public void Resize(){} // RVA: 0x7AABCE920
        public void Remove(){} // RVA: 0x7AABCED20
        public void TryGetValue(){} // RVA: 0x7AABCEF60
        public void TryAdd(){} // RVA: 0x7AABCF020
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA51140
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AABCF050
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AABCF420
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AABCF510
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AABCF5C0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AABCF6E0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AABCF890
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AABCFA40
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AABCFB50
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAA4F720
        public void get_Comparer(){} // RVA: 0x7AAA2C1E0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAA4C690
        public void set_Item(){} // RVA: 0x7AAA4F7B0
        public void Add(){} // RVA: 0x7AAA4F7E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAA4F810
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAA4F850
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAA4F910
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAA4C970
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAA4F9F0
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAA4FB60
        public void FindEntry(){} // RVA: 0x7AAA4CEF0
        public void Initialize(){} // RVA: 0x7AAA4FEB0
        public void TryInsert(){} // RVA: 0x7AAA50030
        public void OnDeserialization(){} // RVA: 0x7AAA50510
        public void Resize(){} // RVA: 0x7AAA50A10
        public void Remove(){} // RVA: 0x7AAA50E10
        public void TryGetValue(){} // RVA: 0x7AAA51050
        public void TryAdd(){} // RVA: 0x7AAA51110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA51140
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAA51150
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAA51520
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAA51610
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAA516C0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAA517E0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAA51990
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAA4ED50
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAA51B40
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AABCAA50
        public void get_Comparer(){} // RVA: 0x7AABBD740
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AABC7490
        public void set_Item(){} // RVA: 0x7AABCAAE0
        public void Add(){} // RVA: 0x7AABCAB30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AABCAB80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AABCABE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AABCACE0
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AABC7870
        public void ContainsValue(){} // RVA: 0x7AABCAE00
        public void CopyTo(){} // RVA: 0x7AAA3E6F0
        public void GetEnumerator(){} // RVA: 0x7AAA3E830
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA3E8E0
        public void GetObjectData(){} // RVA: 0x7AABCAF10
        public void FindEntry(){} // RVA: 0x7AABC7D00
        public void Initialize(){} // RVA: 0x7AABCB260
        public void TryInsert(){} // RVA: 0x7AABCB3E0
        public void OnDeserialization(){} // RVA: 0x7AABCB860
        public void Resize(){} // RVA: 0x7AABCC100
        public void Remove(){} // RVA: 0x7AABC9200
        public void TryGetValue(){} // RVA: 0x7AABC9450
        public void TryAdd(){} // RVA: 0x7AABCC2F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA40550
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AABCC340
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA3E8E0
        public void EnsureCapacity(){} // RVA: 0x7AABCC760
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AABCC850
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA9E3240
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AABC9AF0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AABCC900
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AABCCAD0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AABC9FE0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA41120
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AABCA0F0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AABCD470
        public void get_Comparer(){} // RVA: 0x7AABBD740
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AABCD500
        public void set_Item(){} // RVA: 0x7AABCD5A0
        public void Add(){} // RVA: 0x7AABCD5D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AABCD600
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AABCD640
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AABCD700
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AABCD7E0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAA4F9F0
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AABCD810
        public void FindEntry(){} // RVA: 0x7AABCDB60
        public void Initialize(){} // RVA: 0x7AABCDDC0
        public void TryInsert(){} // RVA: 0x7AABCDF40
        public void OnDeserialization(){} // RVA: 0x7AABCE420
        public void Resize(){} // RVA: 0x7AABCE920
        public void Remove(){} // RVA: 0x7AABCED20
        public void TryGetValue(){} // RVA: 0x7AABCEF60
        public void TryAdd(){} // RVA: 0x7AABCF020
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA51140
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AABCF050
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AABCF420
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AABCF510
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AABCF5C0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AABCF6E0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AABCF890
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AABCFA40
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AABCFB50
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AABCD470
        public void get_Comparer(){} // RVA: 0x7AABBD740
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AABCD500
        public void set_Item(){} // RVA: 0x7AABCD5A0
        public void Add(){} // RVA: 0x7AABCD5D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AABCD600
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AABCD640
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AABCD700
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AABCD7E0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAA4F9F0
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AABCD810
        public void FindEntry(){} // RVA: 0x7AABCDB60
        public void Initialize(){} // RVA: 0x7AABCDDC0
        public void TryInsert(){} // RVA: 0x7AABCDF40
        public void OnDeserialization(){} // RVA: 0x7AABCE420
        public void Resize(){} // RVA: 0x7AABCE920
        public void Remove(){} // RVA: 0x7AABCED20
        public void TryGetValue(){} // RVA: 0x7AABCEF60
        public void TryAdd(){} // RVA: 0x7AABCF020
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA51140
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AABCF050
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AABCF420
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AABCF510
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AABCF5C0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AABCF6E0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AABCF890
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AABCFA40
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AABCFB50
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AABBD6B0
        public void get_Comparer(){} // RVA: 0x7AABBD740
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AABBD760
        public void set_Item(){} // RVA: 0x7AABBD830
        public void Add(){} // RVA: 0x7AABBD890
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AABBD8F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AABBD960
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AABBDA90
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AABBDBD0
        public void ContainsValue(){} // RVA: 0x7AABBDC00
        public void CopyTo(){} // RVA: 0x7AABBDD40
        public void GetEnumerator(){} // RVA: 0x7AAA1AF80
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA1B030
        public void GetObjectData(){} // RVA: 0x7AABBDEB0
        public void FindEntry(){} // RVA: 0x7AABBE200
        public void Initialize(){} // RVA: 0x7AABBE460
        public void TryInsert(){} // RVA: 0x7AABBE5E0
        public void OnDeserialization(){} // RVA: 0x7AABBEAB0
        public void Resize(){} // RVA: 0x7AABBF390
        public void Remove(){} // RVA: 0x7AABBF780
        public void TryGetValue(){} // RVA: 0x7AABBF9E0
        public void TryAdd(){} // RVA: 0x7AABBFA80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AABBFAE0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AABBFAF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA1B030
        public void EnsureCapacity(){} // RVA: 0x7AABBFF50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AABC0040
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA9E3240
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AABC00F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AABC0250
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AABC0440
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AABC0630
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA1DAC0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AABC0740
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AABC7400
        public void get_Comparer(){} // RVA: 0x7AABBD740
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AABC7490
        public void set_Item(){} // RVA: 0x7AABC7550
        public void Add(){} // RVA: 0x7AABC75A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AABC75F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AABC7650
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AABC7750
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AABC7870
        public void ContainsValue(){} // RVA: 0x7AABC78A0
        public void CopyTo(){} // RVA: 0x7AAA3E6F0
        public void GetEnumerator(){} // RVA: 0x7AAA3E830
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA3E8E0
        public void GetObjectData(){} // RVA: 0x7AABC79B0
        public void FindEntry(){} // RVA: 0x7AABC7D00
        public void Initialize(){} // RVA: 0x7AABC7F70
        public void TryInsert(){} // RVA: 0x7AABC80F0
        public void OnDeserialization(){} // RVA: 0x7AABC8570
        public void Resize(){} // RVA: 0x7AABC8E10
        public void Remove(){} // RVA: 0x7AABC9200
        public void TryGetValue(){} // RVA: 0x7AABC9450
        public void TryAdd(){} // RVA: 0x7AABC94E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA40550
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AABC9530
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA3E8E0
        public void EnsureCapacity(){} // RVA: 0x7AABC9950
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AABC9A40
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA9E3240
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AABC9AF0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AABC9C40
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AABC9E10
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AABC9FE0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA41120
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AABCA0F0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAA4F720
        public void get_Comparer(){} // RVA: 0x7AAA2C1E0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAA4C690
        public void set_Item(){} // RVA: 0x7AAA4F7B0
        public void Add(){} // RVA: 0x7AAA4F7E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAA4F810
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAA4F850
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAA4F910
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAA4C970
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAA4F9F0
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAA4FB60
        public void FindEntry(){} // RVA: 0x7AAA4CEF0
        public void Initialize(){} // RVA: 0x7AAA4FEB0
        public void TryInsert(){} // RVA: 0x7AAA50030
        public void OnDeserialization(){} // RVA: 0x7AAA50510
        public void Resize(){} // RVA: 0x7AAA50A10
        public void Remove(){} // RVA: 0x7AAA50E10
        public void TryGetValue(){} // RVA: 0x7AAA51050
        public void TryAdd(){} // RVA: 0x7AAA51110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA51140
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAA51150
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAA51520
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAA51610
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAA516C0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAA517E0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAA51990
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAA4ED50
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAA51B40
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAA4F720
        public void get_Comparer(){} // RVA: 0x7AAA2C1E0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAA4C690
        public void set_Item(){} // RVA: 0x7AAA4F7B0
        public void Add(){} // RVA: 0x7AAA4F7E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAA4F810
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAA4F850
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAA4F910
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAA4C970
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAA4F9F0
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAA4FB60
        public void FindEntry(){} // RVA: 0x7AAA4CEF0
        public void Initialize(){} // RVA: 0x7AAA4FEB0
        public void TryInsert(){} // RVA: 0x7AAA50030
        public void OnDeserialization(){} // RVA: 0x7AAA50510
        public void Resize(){} // RVA: 0x7AAA50A10
        public void Remove(){} // RVA: 0x7AAA50E10
        public void TryGetValue(){} // RVA: 0x7AAA51050
        public void TryAdd(){} // RVA: 0x7AAA51110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA51140
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAA51150
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAA51520
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAA51610
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAA516C0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAA517E0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAA51990
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAA4ED50
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAA51B40
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB29DF0
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAAE30A0
        public void set_Item(){} // RVA: 0x7AAB29E80
        public void Add(){} // RVA: 0x7AAB29EC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB29F00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB29F50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB2A030
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAE33D0
        public void ContainsValue(){} // RVA: 0x7AAB2A130
        public void CopyTo(){} // RVA: 0x7AAAE34F0
        public void GetEnumerator(){} // RVA: 0x7AA9E0B60
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AA9E0C10
        public void GetObjectData(){} // RVA: 0x7AAB2A220
        public void FindEntry(){} // RVA: 0x7AAAE39D0
        public void Initialize(){} // RVA: 0x7AAB2A570
        public void TryInsert(){} // RVA: 0x7AAB2A6F0
        public void OnDeserialization(){} // RVA: 0x7AAB2ABA0
        public void Resize(){} // RVA: 0x7AAB2B0D0
        public void Remove(){} // RVA: 0x7AAAE4C50
        public void TryGetValue(){} // RVA: 0x7AAAE4ED0
        public void TryAdd(){} // RVA: 0x7AAB2B360
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAAE4FD0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB2B3A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA9E0C10
        public void EnsureCapacity(){} // RVA: 0x7AAB2B780
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB2B870
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA9E3240
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAAE5560
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB2B920
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB2BB00
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAAE5A70
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA9E3AD0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAAE5B90
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAC20420
        public void get_Comparer(){} // RVA: 0x7AAC1CBD0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAC204B0
        public void set_Item(){} // RVA: 0x7AAC20580
        public void Add(){} // RVA: 0x7AAC205C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAC20600
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAC20660
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAC20730
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAC20840
        public void ContainsValue(){} // RVA: 0x7AABA3360
        public void CopyTo(){} // RVA: 0x7AABF7630
        public void GetEnumerator(){} // RVA: 0x7AAA17100
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA171B0
        public void GetObjectData(){} // RVA: 0x7AAC20880
        public void FindEntry(){} // RVA: 0x7AAC20BD0
        public void Initialize(){} // RVA: 0x7AAC20F30
        public void TryInsert(){} // RVA: 0x7AAC210B0
        public void OnDeserialization(){} // RVA: 0x7AAC21760
        public void Resize(){} // RVA: 0x7AAC21CA0
        public void Remove(){} // RVA: 0x7AAC221B0
        public void TryGetValue(){} // RVA: 0x7AAC224E0
        public void TryAdd(){} // RVA: 0x7AAC225B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AABF9410
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAC225F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA171B0
        public void EnsureCapacity(){} // RVA: 0x7AAC22A10
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAC22B00
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA9E3240
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAC22BB0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAC22CE0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAC22ED0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAC230C0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA19A70
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAC231F0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAC1CB40
        public void get_Comparer(){} // RVA: 0x7AAC1CBD0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAC1CBF0
        public void set_Item(){} // RVA: 0x7AAC1CCB0
        public void Add(){} // RVA: 0x7AAC1CCF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAC1CD30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAC1CD90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAC1CE60
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAC1CF70
        public void ContainsValue(){} // RVA: 0x7AAC1CFB0
        public void CopyTo(){} // RVA: 0x7AAC1D080
        public void GetEnumerator(){} // RVA: 0x7AAA17100
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA171B0
        public void GetObjectData(){} // RVA: 0x7AAC1D210
        public void FindEntry(){} // RVA: 0x7AAC1D560
        public void Initialize(){} // RVA: 0x7AAC1D8C0
        public void TryInsert(){} // RVA: 0x7AAC1DA40
        public void OnDeserialization(){} // RVA: 0x7AAC1E070
        public void Resize(){} // RVA: 0x7AAC1E5B0
        public void Remove(){} // RVA: 0x7AAC1EAC0
        public void TryGetValue(){} // RVA: 0x7AAC1EDE0
        public void TryAdd(){} // RVA: 0x7AAC1EE70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAC1EEB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAC1EEC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA171B0
        public void EnsureCapacity(){} // RVA: 0x7AAC1F300
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAC1F3F0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA9E3240
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAC1F4A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAC1F5F0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAC1F7E0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAC1F9D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA19A70
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAC1FB00
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB72160
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB721F0
        public void set_Item(){} // RVA: 0x7AAB722B0
        public void Add(){} // RVA: 0x7AAB72330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB723B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB72440
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB725A0
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAB72720
        public void ContainsValue(){} // RVA: 0x7AAB72750
        public void CopyTo(){} // RVA: 0x7AAB728D0
        public void GetEnumerator(){} // RVA: 0x7AAAB4EB0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAAB4F70
        public void GetObjectData(){} // RVA: 0x7AAB72B00
        public void FindEntry(){} // RVA: 0x7AAB72E50
        public void Initialize(){} // RVA: 0x7AAB73090
        public void TryInsert(){} // RVA: 0x7AAB73210
        public void OnDeserialization(){} // RVA: 0x7AAB736F0
        public void Resize(){} // RVA: 0x7AAB73C80
        public void Remove(){} // RVA: 0x7AAB74160
        public void TryGetValue(){} // RVA: 0x7AAB74430
        public void TryAdd(){} // RVA: 0x7AAB744F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB74570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB74580
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAAB4F70
        public void EnsureCapacity(){} // RVA: 0x7AAB74A40
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB74B30
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA9E3240
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB74BE0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB74D90
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB74FB0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAB751D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAAB7880
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAB752F0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAA21E50
        public void get_Comparer(){} // RVA: 0x7AAA21EE0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAA21F00
        public void set_Item(){} // RVA: 0x7AAA21FB0
        public void Add(){} // RVA: 0x7AAA21FF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAA22030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAA22080
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAA22150
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAA22250
        public void ContainsValue(){} // RVA: 0x7AAA22290
        public void CopyTo(){} // RVA: 0x7AAA22360
        public void GetEnumerator(){} // RVA: 0x7AAA22480
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA22520
        public void GetObjectData(){} // RVA: 0x7AAA22600
        public void FindEntry(){} // RVA: 0x7AAA22950
        public void Initialize(){} // RVA: 0x7AAA22C90
        public void TryInsert(){} // RVA: 0x7AAA22E10
        public void OnDeserialization(){} // RVA: 0x7AAA23360
        public void Resize(){} // RVA: 0x7AAA23880
        public void Remove(){} // RVA: 0x7AAA23D80
        public void TryGetValue(){} // RVA: 0x7AAA240C0
        public void TryAdd(){} // RVA: 0x7AAA24140
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA24180
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAA24190
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA22520
        public void EnsureCapacity(){} // RVA: 0x7AAA24580
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAA24670
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA9E3240
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAA24720
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAA24870
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAA24A50
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAA24C30
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA24D50
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAA24E30
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAAD5AB0
        public void get_Comparer(){} // RVA: 0x7AAAD2B30
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAAD5B40
        public void set_Item(){} // RVA: 0x7AAAD5C00
        public void Add(){} // RVA: 0x7AAAD5C50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAAD5CA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAAD5D00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAAD5E00
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD5F20
        public void ContainsValue(){} // RVA: 0x7AAAD5F50
        public void CopyTo(){} // RVA: 0x7AAAD6060
        public void GetEnumerator(){} // RVA: 0x7AAA17100
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA171B0
        public void GetObjectData(){} // RVA: 0x7AAAD61A0
        public void FindEntry(){} // RVA: 0x7AAAD64F0
        public void Initialize(){} // RVA: 0x7AAAD6780
        public void TryInsert(){} // RVA: 0x7AAAD6900
        public void OnDeserialization(){} // RVA: 0x7AAAD6D90
        public void Resize(){} // RVA: 0x7AAAD7660
        public void Remove(){} // RVA: 0x7AAAD7A60
        public void TryGetValue(){} // RVA: 0x7AAAD7CB0
        public void TryAdd(){} // RVA: 0x7AAAD7D40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAAD7D90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAAD7DA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA171B0
        public void EnsureCapacity(){} // RVA: 0x7AAAD81C0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAAD82B0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA9E3240
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAAD8360
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAAD84B0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAAD8680
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAAD8850
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA19A70
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAAD8960
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB11330
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB113C0
        public void set_Item(){} // RVA: 0x7AAB11430
        public void Add(){} // RVA: 0x7AAB11460
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB11490
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB114E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB115A0
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAABBDC0
        public void CopyTo(){} // RVA: 0x7AAB02840
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB11680
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB119D0
        public void TryInsert(){} // RVA: 0x7AAB11B50
        public void OnDeserialization(){} // RVA: 0x7AAB11FA0
        public void Resize(){} // RVA: 0x7AAB124C0
        public void Remove(){} // RVA: 0x7AAB03AA0
        public void TryGetValue(){} // RVA: 0x7AAB03D10
        public void TryAdd(){} // RVA: 0x7AAB12750
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB03DB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB12780
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB12B50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB12C40
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB04330
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB12CF0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB12EC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAAE21B0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB93AB0
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAAE30A0
        public void set_Item(){} // RVA: 0x7AAB93B40
        public void Add(){} // RVA: 0x7AAB93B80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB93BC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB93C10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB93CF0
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAE33D0
        public void ContainsValue(){} // RVA: 0x7AAB93DF0
        public void CopyTo(){} // RVA: 0x7AAB93EE0
        public void GetEnumerator(){} // RVA: 0x7AA9E0B60
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AA9E0C10
        public void GetObjectData(){} // RVA: 0x7AAB94050
        public void FindEntry(){} // RVA: 0x7AAAE39D0
        public void Initialize(){} // RVA: 0x7AAB943A0
        public void TryInsert(){} // RVA: 0x7AAB94520
        public void OnDeserialization(){} // RVA: 0x7AAB949D0
        public void Resize(){} // RVA: 0x7AAB94F00
        public void Remove(){} // RVA: 0x7AAB77310
        public void TryGetValue(){} // RVA: 0x7AAB775A0
        public void TryAdd(){} // RVA: 0x7AAB95190
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB951D0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB951E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA9E0C10
        public void EnsureCapacity(){} // RVA: 0x7AAB955C0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB956B0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA9E3240
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAAE5560
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB95760
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB95940
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAAE5A70
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA9E3AD0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAAE5B90
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAA4F720
        public void get_Comparer(){} // RVA: 0x7AAA2C1E0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAA4C690
        public void set_Item(){} // RVA: 0x7AAA4F7B0
        public void Add(){} // RVA: 0x7AAA4F7E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAA4F810
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAA4F850
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAA4F910
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAA4C970
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAA4F9F0
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAA4FB60
        public void FindEntry(){} // RVA: 0x7AAA4CEF0
        public void Initialize(){} // RVA: 0x7AAA4FEB0
        public void TryInsert(){} // RVA: 0x7AAA50030
        public void OnDeserialization(){} // RVA: 0x7AAA50510
        public void Resize(){} // RVA: 0x7AAA50A10
        public void Remove(){} // RVA: 0x7AAA50E10
        public void TryGetValue(){} // RVA: 0x7AAA51050
        public void TryAdd(){} // RVA: 0x7AAA51110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA51140
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAA51150
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAA51520
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAA51610
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAA516C0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAA517E0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAA51990
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAA4ED50
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAA51B40
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAAF7E90
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAAF7F20
        public void set_Item(){} // RVA: 0x7AAAF7F90
        public void Add(){} // RVA: 0x7AAAF7FC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAAF7FF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAAF8040
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAAF8110
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAAF81F0
        public void CopyTo(){} // RVA: 0x7AAAF82B0
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAAF8430
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAAF8780
        public void TryInsert(){} // RVA: 0x7AAAF8900
        public void OnDeserialization(){} // RVA: 0x7AAAF8D60
        public void Resize(){} // RVA: 0x7AAAF9280
        public void Remove(){} // RVA: 0x7AAAF9510
        public void TryGetValue(){} // RVA: 0x7AAAF9780
        public void TryAdd(){} // RVA: 0x7AAAF9800
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAAF9830
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAAF9840
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAAF9C10
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAAF9D00
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAAF9DB0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAAF9EF0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAAFA0C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAAE21B0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void Clear(){} // RVA: 0x7AA9E0810
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void .ctor(){} // RVA: 0x7AAAD8B00
        public void Remove(){} // RVA: 0x7AAADACC0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AABCD470
        public void get_Comparer(){} // RVA: 0x7AABBD740
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AABCD500
        public void set_Item(){} // RVA: 0x7AABCD5A0
        public void Add(){} // RVA: 0x7AABCD5D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AABCD600
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AABCD640
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AABCD700
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AABCD7E0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAA4F9F0
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AABCD810
        public void FindEntry(){} // RVA: 0x7AABCDB60
        public void Initialize(){} // RVA: 0x7AABCDDC0
        public void TryInsert(){} // RVA: 0x7AABCDF40
        public void OnDeserialization(){} // RVA: 0x7AABCE420
        public void Resize(){} // RVA: 0x7AABCE920
        public void Remove(){} // RVA: 0x7AABCED20
        public void TryGetValue(){} // RVA: 0x7AABCEF60
        public void TryAdd(){} // RVA: 0x7AABCF020
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA51140
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AABCF050
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AABCF420
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AABCF510
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AABCF5C0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AABCF6E0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AABCF890
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AABCFA40
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AABCFB50
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB11330
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB113C0
        public void set_Item(){} // RVA: 0x7AAB11430
        public void Add(){} // RVA: 0x7AAB11460
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB11490
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB114E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB115A0
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAABBDC0
        public void CopyTo(){} // RVA: 0x7AAB02840
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB11680
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB119D0
        public void TryInsert(){} // RVA: 0x7AAB11B50
        public void OnDeserialization(){} // RVA: 0x7AAB11FA0
        public void Resize(){} // RVA: 0x7AAB124C0
        public void Remove(){} // RVA: 0x7AAB03AA0
        public void TryGetValue(){} // RVA: 0x7AAB03D10
        public void TryAdd(){} // RVA: 0x7AAB12750
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB03DB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB12780
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB12B50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB12C40
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB04330
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB12CF0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB12EC0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAAE21B0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAAE8AE0
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAAE30A0
        public void set_Item(){} // RVA: 0x7AAAE8B70
        public void Add(){} // RVA: 0x7AAAE8BB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAAE8BF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAAE8C40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAAE8D20
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAE33D0
        public void ContainsValue(){} // RVA: 0x7AAAE8E20
        public void CopyTo(){} // RVA: 0x7AAAE8F10
        public void GetEnumerator(){} // RVA: 0x7AA9E0B60
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AA9E0C10
        public void GetObjectData(){} // RVA: 0x7AAAE9080
        public void FindEntry(){} // RVA: 0x7AAAE39D0
        public void Initialize(){} // RVA: 0x7AAAE93D0
        public void TryInsert(){} // RVA: 0x7AAAE9550
        public void OnDeserialization(){} // RVA: 0x7AAAE9A00
        public void Resize(){} // RVA: 0x7AAAE9F30
        public void Remove(){} // RVA: 0x7AAAE4C50
        public void TryGetValue(){} // RVA: 0x7AAAE4ED0
        public void TryAdd(){} // RVA: 0x7AAAEA1C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAAEA200
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAAEA210
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA9E0C10
        public void EnsureCapacity(){} // RVA: 0x7AAAEA5F0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAAEA6E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA9E3240
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAAE5560
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAAEA790
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAAEA970
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAAE5A70
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA9E3AD0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAAE5B90
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void Clear(){} // RVA: 0x7AA9E0810
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void .ctor(){} // RVA: 0x7AAAD8B00
        public void Remove(){} // RVA: 0x7AAADACC0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAA4F720
        public void get_Comparer(){} // RVA: 0x7AAA2C1E0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAA4C690
        public void set_Item(){} // RVA: 0x7AAA4F7B0
        public void Add(){} // RVA: 0x7AAA4F7E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAA4F810
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAA4F850
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAA4F910
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAA4C970
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAA4F9F0
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAA4FB60
        public void FindEntry(){} // RVA: 0x7AAA4CEF0
        public void Initialize(){} // RVA: 0x7AAA4FEB0
        public void TryInsert(){} // RVA: 0x7AAA50030
        public void OnDeserialization(){} // RVA: 0x7AAA50510
        public void Resize(){} // RVA: 0x7AAA50A10
        public void Remove(){} // RVA: 0x7AAA50E10
        public void TryGetValue(){} // RVA: 0x7AAA51050
        public void TryAdd(){} // RVA: 0x7AAA51110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA51140
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAA51150
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAA51520
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAA51610
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAA516C0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAA517E0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAA51990
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAA4ED50
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAA51B40
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAA78800
        public void get_Comparer(){} // RVA: 0x7AAA6D400
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAA78890
        public void set_Item(){} // RVA: 0x7AAA78930
        public void Add(){} // RVA: 0x7AAA78960
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAA78990
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAA789D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAA78A90
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAA78B70
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAA4F9F0
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAA78BA0
        public void FindEntry(){} // RVA: 0x7AAA78EF0
        public void Initialize(){} // RVA: 0x7AAA79150
        public void TryInsert(){} // RVA: 0x7AAA792D0
        public void OnDeserialization(){} // RVA: 0x7AAA797B0
        public void Resize(){} // RVA: 0x7AAA79CB0
        public void Remove(){} // RVA: 0x7AAA7A0B0
        public void TryGetValue(){} // RVA: 0x7AAA7A2F0
        public void TryAdd(){} // RVA: 0x7AAA7A3B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA51140
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAA7A3E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAA7A7B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAA7A8A0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAA7A950
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAA7AA70
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAA7AC20
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAA7ADD0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAA7AEE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAA78800
        public void get_Comparer(){} // RVA: 0x7AAA6D400
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAA78890
        public void set_Item(){} // RVA: 0x7AAA78930
        public void Add(){} // RVA: 0x7AAA78960
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAA78990
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAA789D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAA78A90
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAA78B70
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAA4F9F0
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAA78BA0
        public void FindEntry(){} // RVA: 0x7AAA78EF0
        public void Initialize(){} // RVA: 0x7AAA79150
        public void TryInsert(){} // RVA: 0x7AAA792D0
        public void OnDeserialization(){} // RVA: 0x7AAA797B0
        public void Resize(){} // RVA: 0x7AAA79CB0
        public void Remove(){} // RVA: 0x7AAA7A0B0
        public void TryGetValue(){} // RVA: 0x7AAA7A2F0
        public void TryAdd(){} // RVA: 0x7AAA7A3B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA51140
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAA7A3E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAA7A7B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAA7A8A0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAA7A950
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAA7AA70
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAA7AC20
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAA7ADD0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAA7AEE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAA4F720
        public void get_Comparer(){} // RVA: 0x7AAA2C1E0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAA4C690
        public void set_Item(){} // RVA: 0x7AAA4F7B0
        public void Add(){} // RVA: 0x7AAA4F7E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAA4F810
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAA4F850
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAA4F910
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAA4C970
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAA4F9F0
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAA4FB60
        public void FindEntry(){} // RVA: 0x7AAA4CEF0
        public void Initialize(){} // RVA: 0x7AAA4FEB0
        public void TryInsert(){} // RVA: 0x7AAA50030
        public void OnDeserialization(){} // RVA: 0x7AAA50510
        public void Resize(){} // RVA: 0x7AAA50A10
        public void Remove(){} // RVA: 0x7AAA50E10
        public void TryGetValue(){} // RVA: 0x7AAA51050
        public void TryAdd(){} // RVA: 0x7AAA51110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA51140
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAA51150
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAA51520
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAA51610
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAA516C0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAA517E0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAA51990
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAA4ED50
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAA51B40
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAA4F720
        public void get_Comparer(){} // RVA: 0x7AAA2C1E0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAA4C690
        public void set_Item(){} // RVA: 0x7AAA4F7B0
        public void Add(){} // RVA: 0x7AAA4F7E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAA4F810
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAA4F850
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAA4F910
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAA4C970
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAA4F9F0
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAA4FB60
        public void FindEntry(){} // RVA: 0x7AAA4CEF0
        public void Initialize(){} // RVA: 0x7AAA4FEB0
        public void TryInsert(){} // RVA: 0x7AAA50030
        public void OnDeserialization(){} // RVA: 0x7AAA50510
        public void Resize(){} // RVA: 0x7AAA50A10
        public void Remove(){} // RVA: 0x7AAA50E10
        public void TryGetValue(){} // RVA: 0x7AAA51050
        public void TryAdd(){} // RVA: 0x7AAA51110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA51140
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAA51150
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAA51520
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAA51610
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAA516C0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAA517E0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAA51990
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAA4ED50
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAA51B40
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAA4F720
        public void get_Comparer(){} // RVA: 0x7AAA2C1E0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAA4C690
        public void set_Item(){} // RVA: 0x7AAA4F7B0
        public void Add(){} // RVA: 0x7AAA4F7E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAA4F810
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAA4F850
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAA4F910
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAA4C970
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAA4F9F0
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAA4FB60
        public void FindEntry(){} // RVA: 0x7AAA4CEF0
        public void Initialize(){} // RVA: 0x7AAA4FEB0
        public void TryInsert(){} // RVA: 0x7AAA50030
        public void OnDeserialization(){} // RVA: 0x7AAA50510
        public void Resize(){} // RVA: 0x7AAA50A10
        public void Remove(){} // RVA: 0x7AAA50E10
        public void TryGetValue(){} // RVA: 0x7AAA51050
        public void TryAdd(){} // RVA: 0x7AAA51110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA51140
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAA51150
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAA51520
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAA51610
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAA516C0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAA517E0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAA51990
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAA4ED50
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAA51B40
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAAE8AE0
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAAE30A0
        public void set_Item(){} // RVA: 0x7AAAE8B70
        public void Add(){} // RVA: 0x7AAAE8BB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAAE8BF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAAE8C40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAAE8D20
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAE33D0
        public void ContainsValue(){} // RVA: 0x7AAAE8E20
        public void CopyTo(){} // RVA: 0x7AAAE8F10
        public void GetEnumerator(){} // RVA: 0x7AA9E0B60
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AA9E0C10
        public void GetObjectData(){} // RVA: 0x7AAAE9080
        public void FindEntry(){} // RVA: 0x7AAAE39D0
        public void Initialize(){} // RVA: 0x7AAAE93D0
        public void TryInsert(){} // RVA: 0x7AAAE9550
        public void OnDeserialization(){} // RVA: 0x7AAAE9A00
        public void Resize(){} // RVA: 0x7AAAE9F30
        public void Remove(){} // RVA: 0x7AAAE4C50
        public void TryGetValue(){} // RVA: 0x7AAAE4ED0
        public void TryAdd(){} // RVA: 0x7AAAEA1C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAAEA200
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAAEA210
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA9E0C10
        public void EnsureCapacity(){} // RVA: 0x7AAAEA5F0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAAEA6E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA9E3240
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAAE5560
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAAEA790
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAAEA970
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAAE5A70
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA9E3AD0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAAE5B90
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7AAB1B030
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void .ctor(){} // RVA: 0x7AAAD8A50
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7AAB1B030
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void .ctor(){} // RVA: 0x7AAAD8A50
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7AAB1B030
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void .ctor(){} // RVA: 0x7AAAD8A50
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7AAB1B030
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void .ctor(){} // RVA: 0x7AAAD8A50
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7AAB1B030
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void .ctor(){} // RVA: 0x7AAAD8A50
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7AAB1B030
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void .ctor(){} // RVA: 0x7AAAD8A50
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7AAB1B030
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void .ctor(){} // RVA: 0x7AAAD8A50
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAA382D0
        public void get_Comparer(){} // RVA: 0x7AAA2C1E0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAA38360
        public void set_Item(){} // RVA: 0x7AAA38420
        public void Add(){} // RVA: 0x7AAA38460
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAA384A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAA384F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAA385D0
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAA386D0
        public void ContainsValue(){} // RVA: 0x7AAA38700
        public void CopyTo(){} // RVA: 0x7AAA387F0
        public void GetEnumerator(){} // RVA: 0x7AA9E0B60
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AA9E0C10
        public void GetObjectData(){} // RVA: 0x7AAA38970
        public void FindEntry(){} // RVA: 0x7AAA38CC0
        public void Initialize(){} // RVA: 0x7AAA38F20
        public void TryInsert(){} // RVA: 0x7AAA390A0
        public void OnDeserialization(){} // RVA: 0x7AAA39580
        public void Resize(){} // RVA: 0x7AAA39AA0
        public void Remove(){} // RVA: 0x7AAA39EA0
        public void TryGetValue(){} // RVA: 0x7AAA3A0F0
        public void TryAdd(){} // RVA: 0x7AAA3A1B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA3A1F0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAA3A200
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA9E0C10
        public void EnsureCapacity(){} // RVA: 0x7AAA3A610
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAA3A700
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA9E3240
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAA3A7B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAA3A8F0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAA3AAB0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAA3AC70
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA9E3AD0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAA3AD80
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAA66DD0
        public void get_Comparer(){} // RVA: 0x7AAA2C1E0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAA31D00
        public void set_Item(){} // RVA: 0x7AAA66E60
        public void Add(){} // RVA: 0x7AAA66EB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAA66F00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAA66F60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAA67060
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAA320E0
        public void ContainsValue(){} // RVA: 0x7AAA67180
        public void CopyTo(){} // RVA: 0x7AAA67290
        public void GetEnumerator(){} // RVA: 0x7AAA17100
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA171B0
        public void GetObjectData(){} // RVA: 0x7AAA67420
        public void FindEntry(){} // RVA: 0x7AAA32700
        public void Initialize(){} // RVA: 0x7AAA67770
        public void TryInsert(){} // RVA: 0x7AAA678F0
        public void OnDeserialization(){} // RVA: 0x7AAA67DF0
        public void Resize(){} // RVA: 0x7AAA68330
        public void Remove(){} // RVA: 0x7AAA68520
        public void TryGetValue(){} // RVA: 0x7AAA68780
        public void TryAdd(){} // RVA: 0x7AAA68850
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA688A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAA688B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA171B0
        public void EnsureCapacity(){} // RVA: 0x7AAA68CF0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAA68DE0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA9E3240
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAA34290
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAA68E90
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAA69060
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAA34780
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA19A70
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAA34890
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB91390
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAAE30A0
        public void set_Item(){} // RVA: 0x7AAB91420
        public void Add(){} // RVA: 0x7AAB91460
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB914A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB914F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB915D0
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAE33D0
        public void ContainsValue(){} // RVA: 0x7AAB916D0
        public void CopyTo(){} // RVA: 0x7AAAE34F0
        public void GetEnumerator(){} // RVA: 0x7AA9E0B60
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AA9E0C10
        public void GetObjectData(){} // RVA: 0x7AAB917C0
        public void FindEntry(){} // RVA: 0x7AAAE39D0
        public void Initialize(){} // RVA: 0x7AAB91B10
        public void TryInsert(){} // RVA: 0x7AAB91C90
        public void OnDeserialization(){} // RVA: 0x7AAB92140
        public void Resize(){} // RVA: 0x7AAB92670
        public void Remove(){} // RVA: 0x7AAAE4C50
        public void TryGetValue(){} // RVA: 0x7AAAE4ED0
        public void TryAdd(){} // RVA: 0x7AAB92900
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAAE4FD0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB92940
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA9E0C10
        public void EnsureCapacity(){} // RVA: 0x7AAB92D20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB92E10
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA9E3240
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAAE5560
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB92EC0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB930A0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAAE5A70
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA9E3AD0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAAE5B90
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7AAB1B030
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7AAA0D420
        public void .ctor(){} // RVA: 0x7AAA0D2C0
        public void get_Comparer(){} // RVA: 0x7AAA07340
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAA0D350
        public void set_Item(){} // RVA: 0x7AAA0D3F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAA0D450
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAA0D4A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAA0D560
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAA0D640
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAA00A80
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAA0D670
        public void FindEntry(){} // RVA: 0x7AAA0D9C0
        public void Initialize(){} // RVA: 0x7AAA0DC20
        public void TryInsert(){} // RVA: 0x7AAA0DDA0
        public void OnDeserialization(){} // RVA: 0x7AAA0E290
        public void Resize(){} // RVA: 0x7AAA0E790
        public void Remove(){} // RVA: 0x7AAA0EBA0
        public void TryGetValue(){} // RVA: 0x7AAA0EDF0
        public void TryAdd(){} // RVA: 0x7AAA0EEB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA025C0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAA0EEE0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAA0F2A0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAA0F390
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAA0F460
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAA0F580
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAA0F740
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAA0F900
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAA0FA10
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7AAA0D420
        public void .ctor(){} // RVA: 0x7AAA0D2C0
        public void get_Comparer(){} // RVA: 0x7AAA07340
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAA0D350
        public void set_Item(){} // RVA: 0x7AAA0D3F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAA0D450
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAA0D4A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAA0D560
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAA0D640
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAA00A80
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAA0D670
        public void FindEntry(){} // RVA: 0x7AAA0D9C0
        public void Initialize(){} // RVA: 0x7AAA0DC20
        public void TryInsert(){} // RVA: 0x7AAA0DDA0
        public void OnDeserialization(){} // RVA: 0x7AAA0E290
        public void Resize(){} // RVA: 0x7AAA0E790
        public void Remove(){} // RVA: 0x7AAA0EBA0
        public void TryGetValue(){} // RVA: 0x7AAA0EDF0
        public void TryAdd(){} // RVA: 0x7AAA0EEB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA025C0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAA0EEE0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAA0F2A0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAA0F390
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA9E3360
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAA0F460
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAA0F580
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAA0F740
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAA0F900
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAA0FA10
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AABACEB0
        public void get_Comparer(){} // RVA: 0x7AABACF40
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AABACF60
        public void set_Item(){} // RVA: 0x7AABAD000
        public void Add(){} // RVA: 0x7AABAD030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AABAD060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AABAD0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AABAD170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AABAD250
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AABAD280
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AABAD3E0
        public void FindEntry(){} // RVA: 0x7AABAD730
        public void Initialize(){} // RVA: 0x7AABAD9D0
        public void TryInsert(){} // RVA: 0x7AABADB50
        public void OnDeserialization(){} // RVA: 0x7AABAE070
        public void Resize(){} // RVA: 0x7AABAE570
        public void Remove(){} // RVA: 0x7AABAE9A0
        public void TryGetValue(){} // RVA: 0x7AABAEC20
        public void TryAdd(){} // RVA: 0x7AABAECD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AABAED00
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AABAED10
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AABAF0F0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AABAF1E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA9E3240
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AABAF290
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AABAF3B0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AABAF580
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AABAF750
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AABAF860
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7AAB1B030
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void ContainsKey(){} // RVA: 0x7AAA00940
        public void Remove(){} // RVA: 0x7AAA02280
        public void get_Item(){} // RVA: 0x7AAA00650
        public void .ctor(){} // RVA: 0x7AAA005C0
        public void get_Comparer(){} // RVA: 0x7AA9FD280
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void set_Item(){} // RVA: 0x7AAA006F0
        public void Add(){} // RVA: 0x7AAA00720
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAA00750
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAA007A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAA00860
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAA00A80
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAA00D50
        public void FindEntry(){} // RVA: 0x7AAA010A0
        public void Initialize(){} // RVA: 0x7AAA01300
        public void TryInsert(){} // RVA: 0x7AAA01480
        public void OnDeserialization(){} // RVA: 0x7AAA01970
        public void Resize(){} // RVA: 0x7AAA01E70
        public void TryGetValue(){} // RVA: 0x7AAA024D0
        public void TryAdd(){} // RVA: 0x7AAA02590
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA025C0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAA025D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAA02990
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAA02A80
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA9E3240
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAA02B50
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAA02C70
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAA02E30
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAA02FF0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAA031E0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void ContainsKey(){} // RVA: 0x7AAA4C970
        public void .ctor(){} // RVA: 0x7AAA4F720
        public void get_Item(){} // RVA: 0x7AAA4C690
        public void set_Item(){} // RVA: 0x7AAA4F7B0
        public void get_Comparer(){} // RVA: 0x7AAA2C1E0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void Add(){} // RVA: 0x7AAA4F7E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAA4F810
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAA4F850
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAA4F910
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAA4F9F0
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAA4FB60
        public void FindEntry(){} // RVA: 0x7AAA4CEF0
        public void Initialize(){} // RVA: 0x7AAA4FEB0
        public void TryInsert(){} // RVA: 0x7AAA50030
        public void OnDeserialization(){} // RVA: 0x7AAA50510
        public void Resize(){} // RVA: 0x7AAA50A10
        public void Remove(){} // RVA: 0x7AAA50E10
        public void TryGetValue(){} // RVA: 0x7AAA51050
        public void TryAdd(){} // RVA: 0x7AAA51110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA51140
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAA51150
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAA51520
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAA51610
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAA516C0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAA517E0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAA51990
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAA4ED50
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAA51B40
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7AAB1B030
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void Add(){} // RVA: 0x7AAB1B030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7AAB1B030
        public void .ctor(){} // RVA: 0x7AAB1AF70
        public void get_Comparer(){} // RVA: 0x7AAAD93D0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAB16270
        public void set_Item(){} // RVA: 0x7AAB1B000
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAB1B060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAB1B0B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAB1B170
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAAD96B0
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAB1B250
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAB1B3F0
        public void FindEntry(){} // RVA: 0x7AAAD9C80
        public void Initialize(){} // RVA: 0x7AAB1B750
        public void TryInsert(){} // RVA: 0x7AAB1B8D0
        public void OnDeserialization(){} // RVA: 0x7AAB1BD50
        public void Resize(){} // RVA: 0x7AAB1C270
        public void Remove(){} // RVA: 0x7AAADAF10
        public void TryGetValue(){} // RVA: 0x7AAADB190
        public void TryAdd(){} // RVA: 0x7AAB1C500
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAB1C530
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAB1C550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAB1C8E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAB1C9D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAB1CA80
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAB1CBA0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAB1CD60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAADBCC0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAADBDE0
    }

    public class Dictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAA4F720
        public void get_Comparer(){} // RVA: 0x7AAA2C1E0
        public void get_Count(){} // RVA: 0x7AA9E0290
        public void get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA9E02A0
        public void get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA9E03B0
        public void get_Item(){} // RVA: 0x7AAA4C690
        public void set_Item(){} // RVA: 0x7AAA4F7B0
        public void Add(){} // RVA: 0x7AAA4F7E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AAA4F810
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AAA4F850
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AAA4F910
        public void Clear(){} // RVA: 0x7AA9E0810
        public void ContainsKey(){} // RVA: 0x7AAA4C970
        public void ContainsValue(){} // RVA: 0x7AAA00970
        public void CopyTo(){} // RVA: 0x7AAA4F9F0
        public void GetEnumerator(){} // RVA: 0x7AAA00BE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void GetObjectData(){} // RVA: 0x7AAA4FB60
        public void FindEntry(){} // RVA: 0x7AAA4CEF0
        public void Initialize(){} // RVA: 0x7AAA4FEB0
        public void TryInsert(){} // RVA: 0x7AAA50030
        public void OnDeserialization(){} // RVA: 0x7AAA50510
        public void Resize(){} // RVA: 0x7AAA50A10
        public void Remove(){} // RVA: 0x7AAA50E10
        public void TryGetValue(){} // RVA: 0x7AAA51050
        public void TryAdd(){} // RVA: 0x7AAA51110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AAA51140
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AAA51150
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AAA00C70
        public void EnsureCapacity(){} // RVA: 0x7AAA51520
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AAA51610
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AAA0F440
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AAA02B30
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AAA516C0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AAA517E0
        public void IsCompatibleKey(){} // RVA: 0x7AA9E3770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AAA51990
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AAA4ED50
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AAA03100
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AAA51B40
    }

}