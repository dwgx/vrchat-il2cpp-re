// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf.Collections
// Classes: 4
// Methods: 92

namespace ThirdParty.Google.Google.Protobuf.Collections
{
    public class Lists : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E07A350
        public void GetHashCode(){} // RVA: 0x7FFD4E079A40
    }

    public class MapField`2 : Object
    {
        public System.Collections.Generic.EqualityComparer`1<T> Item;
        public System.Collections.Generic.EqualityComparer`1<U> Keys;
        public System.Collections.Generic.Dictionary`2<U,System.Collections.Generic.LinkedListNode`1<System.Collections.Generic.KeyValuePair`2<U,T>>> Values;
        public System.Collections.Generic.LinkedList`1<System.Collections.Generic.KeyValuePair`2<U,T>> Count;

        // ── Methods ──
        public void Clone(){} // RVA: 0x7FFD4E078E90
        public void Add(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void ContainsKey(){} // RVA: 0x7FFD4E2ADC40
        public void ContainsValue(){} // RVA: 0x7FFD4E2ADC40
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetValue(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void get_Keys(){} // RVA: 0x7FFD4E078E90
        public void get_Values(){} // RVA: 0x7FFD4E078E90
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFD4E2ADC40
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void AddEntriesFrom(){} // RVA: 0x7FFD4E099B30
        public void WriteTo(){} // RVA: 0x7FFD4E099B30
        public void CalculateSize(){} // RVA: 0x7FFD4E07E6B0
        public void CalculateEntrySize(){} // RVA: 0x7FFD4E2ADC40
        public void ToString(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFD4E099B30
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFD4E079F60
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFD4E090A40
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFD4E078F40
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFD4E099B30
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class ProtobufEqualityComparers : Object
    {
        public System.Collections.Generic.EqualityComparer`1<double> BitwiseDoubleEqualityComparer;
        public System.Collections.Generic.EqualityComparer`1<float> BitwiseSingleEqualityComparer; // 0x8
        public System.Collections.Generic.EqualityComparer`1<System.Nullable`1<double>> BitwiseNullableDoubleEqualityComparer; // 0x10
        public System.Collections.Generic.EqualityComparer`1<System.Nullable`1<float>> BitwiseNullableSingleEqualityComparer; // 0x18

        // ── Methods ──
        public void GetEqualityComparer(){} // RVA: 0x7FFD4E078A90
        public void get_BitwiseDoubleEqualityComparer(){} // RVA: 0x7FFD53645520
        public void get_BitwiseSingleEqualityComparer(){} // RVA: 0x7FFD53645580
        public void get_BitwiseNullableDoubleEqualityComparer(){} // RVA: 0x7FFD536455E0
        public void get_BitwiseNullableSingleEqualityComparer(){} // RVA: 0x7FFD53645640
        public void .cctor(){} // RVA: 0x7FFD536456A0
    }

    public class RepeatedField`1 : Object
    {
        public System.Collections.Generic.EqualityComparer`1<T> Count;
        public T[] IsReadOnly;
        public int Item;
        public T[] System.Collections.IList.IsFixedSize;
        public int System.Collections.ICollection.IsSynchronized;

        // ── Methods ──
        public void Clone(){} // RVA: 0x7FFD4E078E90
        public void AddEntriesFrom(){} // RVA: 0x7FFD4E099B30
        public void CalculateSize(){} // RVA: 0x7FFD4E07E6B0
        public void CalculatePackedDataSize(){} // RVA: 0x7FFD4E07E6B0
        public void WriteTo(){} // RVA: 0x7FFD4E099B30
        public void EnsureSize(){} // RVA: 0x7FFD4E090ED0
        public void SetSize(){} // RVA: 0x7FFD4E090ED0
        public void Add(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void AddRange(){} // RVA: 0x7FFD4E090A40
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x2
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void Insert(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void ToString(){} // RVA: 0x7FFD4E078E90
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFD4E087DE0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFD4E092BC0
        public void System.Collections.IList.Add(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFD4E079F60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFD4E092BC0
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

}