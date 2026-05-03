// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf.Collections
// Classes: 4
// Methods: 92

namespace ThirdParty.Google.Google.Protobuf.Collections
{
    public class Lists : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE80E2F7A0
        public void GetHashCode(){} // RVA: 0x7FFE80E2EE90
    }

    public class MapField`2 : Object
    {
        public System.Collections.Generic.EqualityComparer`1<T> ValueEqualityComparer;
        public System.Collections.Generic.EqualityComparer`1<U> KeyEqualityComparer;
        public System.Collections.Generic.Dictionary`2<U,System.Collections.Generic.LinkedListNode`1<System.Collections.Generic.KeyValuePair`2<U,T>>> map;
        public System.Collections.Generic.LinkedList`1<System.Collections.Generic.KeyValuePair`2<U,T>> list;
        public object field_4; // 0x212
        public object field_5; // 0x213
        public object field_6; // 0x214
        public object field_7; // 0x215
        public object field_8; // 0x216
        public object field_9; // 0x217
        public object field_10; // 0x218
        public object field_11; // 0x219
        public object field_12; // 0x21A

        // ── Methods ──
        public void Clone(){} // RVA: 0x7FFE80E2E2E0
        public void Add(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void ContainsKey(){} // RVA: 0x7FFE810A1420
        public void ContainsValue(){} // RVA: 0x7FFE810A1420
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void TryGetValue(){} // RVA: 0x7FFE810A1420
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFE810A1420
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFE810A1420
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void Equals(){} // RVA: 0x7FFE80E2F3B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void AddEntriesFrom(){} // RVA: 0x7FFE80E4F230
        public void WriteTo(){} // RVA: 0x7FFE80E4F230
        public void CalculateSize(){} // RVA: 0x7FFE80E33B00
        public void CalculateEntrySize(){} // RVA: 0x7FFE810A1420
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFE80E4F230
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFE80E2F3B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFE80E460A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFE80E2E390
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFE80E4F230
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class ProtobufEqualityComparers : Object
    {
        public System.Collections.Generic.EqualityComparer`1<double> _bitwiseDoubleEqualityComparer;
        public System.Collections.Generic.EqualityComparer`1<float> _bitwiseSingleEqualityComparer; // 0x8
        public System.Collections.Generic.EqualityComparer`1<System.Nullable`1<double>> _bitwiseNullableDoubleEqualityComparer; // 0x10
        public System.Collections.Generic.EqualityComparer`1<System.Nullable`1<float>> _bitwiseNullableSingleEqualityComparer; // 0x18

        // ── Methods ──
        public void GetEqualityComparer(){} // RVA: 0x7FFE80E2DEE0
        public void get_BitwiseDoubleEqualityComparer(){} // RVA: 0x7FFE865CEE60
        public void get_BitwiseSingleEqualityComparer(){} // RVA: 0x7FFE865CEEC0
        public void get_BitwiseNullableDoubleEqualityComparer(){} // RVA: 0x7FFE865CEF20
        public void get_BitwiseNullableSingleEqualityComparer(){} // RVA: 0x7FFE865CEF80
        public void .cctor(){} // RVA: 0x7FFE865CEFE0
    }

    public class RepeatedField`1 : Object
    {
        public System.Collections.Generic.EqualityComparer`1<T> EqualityComparer;
        public T[] EmptyArray;
        public int MinArraySize;
        public T[] array;
        public int count;
        public object field_5; // 0x22E
        public object field_6; // 0x22F

        // ── Methods ──
        public void Clone(){} // RVA: 0x7FFE80E2E2E0
        public void AddEntriesFrom(){} // RVA: 0x7FFE80E4F230
        public void CalculateSize(){} // RVA: 0x7FFE80E33B00
        public void CalculatePackedDataSize(){} // RVA: 0x7FFE80E33B00
        public void WriteTo(){} // RVA: 0x7FFE80E4F230
        public void EnsureSize(){} // RVA: 0x7FFE80E46530
        public void SetSize(){} // RVA: 0x7FFE80E46530
        public void Add(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void AddRange(){} // RVA: 0x7FFE80E460A0
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void Equals(){} // RVA: 0x7FFE80E2F3B0 | overloaded x2
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void IndexOf(){} // RVA: 0x7FFE810A1420
        public void Insert(){} // RVA: 0x7FFE810A1420
        public void RemoveAt(){} // RVA: 0x7FFE80E46530
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE80E3D230
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE80E48220
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE80E33B00
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE80E2F3B0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE80E33B00
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE80E48220
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

}