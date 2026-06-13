// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf.Collections
// Classes: 10
// Methods: 332

namespace ThirdParty.Google.Google.Protobuf.Collections
{
    public class Lists
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0xE230
        public void GetHashCode(){} // RVA: 0xD920
    }

    public class MapField`2
    {
        public System.Collections.Generic.EqualityComparer`1<T> ValueEqualityComparer;
        public System.Collections.Generic.EqualityComparer`1<U> KeyEqualityComparer;
        public System.Collections.Generic.Dictionary`2<U,System.Collections.Generic.LinkedListNode`1<System.Collections.Generic.KeyValuePair`2<...,...>>> map;
        public System.Collections.Generic.LinkedList`1<System.Collections.Generic.KeyValuePair`2<...,...>> list;

        // ── Methods ──
        public void Clone(){} // RVA: 0xCD60
        public void Add(){} // RVA: 0x24B10 | overloaded x2
        public void ContainsKey(){} // RVA: 0x283FA0
        public void ContainsValue(){} // RVA: 0x283FA0
        public void Remove(){} // RVA: 0x283FA0
        public void TryGetValue(){} // RVA: 0x283FA0
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void get_Keys(){} // RVA: 0xCD60
        public void get_Values(){} // RVA: 0xCD60
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x283FA0
        public void Clear(){} // RVA: 0x24A50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x283FA0
        public void get_Count(){} // RVA: 0xD840
        public void get_IsReadOnly(){} // RVA: 0xDBE0
        public void Equals(){} // RVA: 0xDE40 | overloaded x2
        public void GetHashCode(){} // RVA: 0xD840
        public void AddEntriesFrom(){} // RVA: 0x2DC60
        public void WriteTo(){} // RVA: 0x2DC60
        public void CalculateSize(){} // RVA: 0x12590
        public void CalculateEntrySize(){} // RVA: 0x283FA0
        public void ToString(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DC60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0xDE40
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x24B10
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xDBE0
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0xCD60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0xCE10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DC60
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0xCD60
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x24A50
        public void .cctor(){} // RVA: 0x24A80
    }

    public class ProtobufEqualityComparers
    {
        public System.Collections.Generic.EqualityComparer`1<double> storeName;
        public System.Collections.Generic.EqualityComparer`1<float> service; // 0x8
        public System.Collections.Generic.EqualityComparer`1<System.Nullable`1<double>> <BitwiseNullableDoubleEqualityComparer>k__BackingField; // 0x10
        public System.Collections.Generic.EqualityComparer`1<System.Nullable`1<float>> <BitwiseNullableSingleEqualityComparer>k__BackingField; // 0x18

        // ── Methods ──
        public void GetEqualityComparer(){} // RVA: 0xC960
        public void get_BitwiseDoubleEqualityComparer(){} // RVA: 0x5A8E100
        public void get_BitwiseSingleEqualityComparer(){} // RVA: 0x5A8E160
        public void get_BitwiseNullableDoubleEqualityComparer(){} // RVA: 0x5A8E1C0
        public void get_BitwiseNullableSingleEqualityComparer(){} // RVA: 0x5A8E220
        public void .cctor(){} // RVA: 0x5A8E280
    }

    public class RepeatedField`1
    {
        public System.Collections.Generic.EqualityComparer`1<T> EqualityComparer;
        public T[] EmptyArray;
        public int MinArraySize;
        public T[] array;
        public int count;

        // ── Methods ──
        public void Clone(){} // RVA: 0xCD60
        public void AddEntriesFrom(){} // RVA: 0x2DC60
        public void CalculateSize(){} // RVA: 0x12590
        public void CalculatePackedDataSize(){} // RVA: 0x12590
        public void WriteTo(){} // RVA: 0x2DC60
        public void EnsureSize(){} // RVA: 0x24FA0
        public void SetSize(){} // RVA: 0x24FA0
        public void Add(){} // RVA: 0x24B10 | overloaded x2
        public void Clear(){} // RVA: 0x24A50
        public void Contains(){} // RVA: 0x283FA0
        public void CopyTo(){} // RVA: 0x2BAA0
        public void Remove(){} // RVA: 0x283FA0
        public void get_Count(){} // RVA: 0xD840
        public void get_IsReadOnly(){} // RVA: 0xDBE0
        public void AddRange(){} // RVA: 0x24B10
        public void GetEnumerator(){} // RVA: 0xCD60
        public void Equals(){} // RVA: 0xDE40 | overloaded x2
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void GetHashCode(){} // RVA: 0xD840
        public void IndexOf(){} // RVA: 0x283FA0
        public void Insert(){} // RVA: 0x283FA0
        public void RemoveAt(){} // RVA: 0x24FA0
        public void ToString(){} // RVA: 0xCD60
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void System.Collections.IList.get_Item(){} // RVA: 0x1BCC0
        public void System.Collections.IList.set_Item(){} // RVA: 0x26C40
        public void System.Collections.IList.Add(){} // RVA: 0x12590
        public void System.Collections.IList.Contains(){} // RVA: 0xDE40
        public void System.Collections.IList.IndexOf(){} // RVA: 0x12590
        public void System.Collections.IList.Insert(){} // RVA: 0x26C40
        public void System.Collections.IList.Remove(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x24A50
        public void .cctor(){} // RVA: 0x24A80
    }

    public class RepeatedField`1
    {
        public System.Collections.Generic.EqualityComparer`1<string> EqualityComparer;
        public string[] EmptyArray; // 0x8
        public int MinArraySize;
        public string[] array; // 0x10
        public int count; // 0x18

        // ── Methods ──
        public void Clone(){} // RVA: 0x3FB5240
        public void AddEntriesFrom(){} // RVA: 0x3FB55E0
        public void CalculateSize(){} // RVA: 0x3FB58A0
        public void CalculatePackedDataSize(){} // RVA: 0x3FB5B50
        public void WriteTo(){} // RVA: 0x3FB5BF0
        public void EnsureSize(){} // RVA: 0x3FB5D30
        public void SetSize(){} // RVA: 0x3FB3A10
        public void Add(){} // RVA: 0x3FB6500 | overloaded x2
        public void Clear(){} // RVA: 0x3FB3B80
        public void Contains(){} // RVA: 0x3FB5F70
        public void CopyTo(){} // RVA: 0x38731B0
        public void Remove(){} // RVA: 0x3FB5FA0
        public void get_Count(){} // RVA: 0x5BED50
        public void get_IsReadOnly(){} // RVA: 0x2DD320
        public void AddRange(){} // RVA: 0x3FB6030
        public void GetEnumerator(){} // RVA: 0x3FB6520
        public void Equals(){} // RVA: 0x3FB66D0 | overloaded x2
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3FB6630
        public void GetHashCode(){} // RVA: 0x3FB6650
        public void IndexOf(){} // RVA: 0x3FB67F0
        public void Insert(){} // RVA: 0x3FB6960
        public void RemoveAt(){} // RVA: 0x3FB6AB0
        public void ToString(){} // RVA: 0x3FB6B60
        public void get_Item(){} // RVA: 0x3FB6C60
        public void set_Item(){} // RVA: 0x3FB6CE0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x38731B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x1A3F520
        public void System.Collections.IList.get_Item(){} // RVA: 0x3FB6DF0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3FB6E10
        public void System.Collections.IList.Add(){} // RVA: 0x3FB6F80
        public void System.Collections.IList.Contains(){} // RVA: 0x3FB7020
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3FB7110
        public void System.Collections.IList.Insert(){} // RVA: 0x3FB71F0
        public void System.Collections.IList.Remove(){} // RVA: 0x3FB73A0
        public void .ctor(){} // RVA: 0x3FB4F30
        public void .cctor(){} // RVA: 0x3FB74D0
    }

    public class RepeatedField`1
    {
        public System.Collections.Generic.EqualityComparer`1<int> EqualityComparer;
        public int[] EmptyArray; // 0x8
        public int MinArraySize;
        public int[] array; // 0x10
        public int count; // 0x18

        // ── Methods ──
        public void Clone(){} // RVA: 0x3FB2DC0
        public void AddEntriesFrom(){} // RVA: 0x3FB30E0
        public void CalculateSize(){} // RVA: 0x3FB3420
        public void CalculatePackedDataSize(){} // RVA: 0x3FB36D0
        public void WriteTo(){} // RVA: 0x3FB3770
        public void EnsureSize(){} // RVA: 0x3FB38B0
        public void SetSize(){} // RVA: 0x3FB3A10
        public void Add(){} // RVA: 0x3FB40C0 | overloaded x2
        public void Clear(){} // RVA: 0x3FB3B80
        public void Contains(){} // RVA: 0x3FB3C50
        public void CopyTo(){} // RVA: 0x38731B0
        public void Remove(){} // RVA: 0x3FB3C80
        public void get_Count(){} // RVA: 0x5BED50
        public void get_IsReadOnly(){} // RVA: 0x2DD320
        public void AddRange(){} // RVA: 0x3FB3D10
        public void GetEnumerator(){} // RVA: 0x3FB40E0
        public void Equals(){} // RVA: 0x3FB42F0 | overloaded x2
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3FB41F0
        public void GetHashCode(){} // RVA: 0x3FB42A0
        public void IndexOf(){} // RVA: 0x3FB4410
        public void Insert(){} // RVA: 0x3FB4520
        public void RemoveAt(){} // RVA: 0x3FB4620
        public void ToString(){} // RVA: 0x3FB46D0
        public void get_Item(){} // RVA: 0x3FB47D0
        public void set_Item(){} // RVA: 0x3FB4850
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x38731B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x1A3F520
        public void System.Collections.IList.get_Item(){} // RVA: 0x3FB4910
        public void System.Collections.IList.set_Item(){} // RVA: 0x3FB4960
        public void System.Collections.IList.Add(){} // RVA: 0x3FB4A70
        public void System.Collections.IList.Contains(){} // RVA: 0x3FB4B00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3FB4BE0
        public void System.Collections.IList.Insert(){} // RVA: 0x3FB4CB0
        public void System.Collections.IList.Remove(){} // RVA: 0x3FB4E00
        public void .ctor(){} // RVA: 0x3FB4F30
        public void .cctor(){} // RVA: 0x3FB4FF0
    }

    public class RepeatedField`1
    {
        public System.Collections.Generic.EqualityComparer`1<float> EqualityComparer;
        public float[] EmptyArray; // 0x8
        public int MinArraySize;
        public float[] array; // 0x10
        public int count; // 0x18

        // ── Methods ──
        public void Clone(){} // RVA: 0x3FB7720
        public void AddEntriesFrom(){} // RVA: 0x3FB7A40
        public void CalculateSize(){} // RVA: 0x3FB7D80
        public void CalculatePackedDataSize(){} // RVA: 0x3FB8030
        public void WriteTo(){} // RVA: 0x3FB80D0
        public void EnsureSize(){} // RVA: 0x3FB8220
        public void SetSize(){} // RVA: 0x3FB3A10
        public void Add(){} // RVA: 0x3FB8890 | overloaded x2
        public void Clear(){} // RVA: 0x3FB3B80
        public void Contains(){} // RVA: 0x3FB8410
        public void CopyTo(){} // RVA: 0x38731B0
        public void Remove(){} // RVA: 0x3FB8440
        public void get_Count(){} // RVA: 0x5BED50
        public void get_IsReadOnly(){} // RVA: 0x2DD320
        public void AddRange(){} // RVA: 0x3FB84D0
        public void GetEnumerator(){} // RVA: 0x3FB40E0
        public void Equals(){} // RVA: 0x3FB8980 | overloaded x2
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3FB41F0
        public void GetHashCode(){} // RVA: 0x3FB8920
        public void IndexOf(){} // RVA: 0x3FB8AA0
        public void Insert(){} // RVA: 0x3FB8BB0
        public void RemoveAt(){} // RVA: 0x3FB4620
        public void ToString(){} // RVA: 0x3FB8CB0
        public void get_Item(){} // RVA: 0x3FB8DB0
        public void set_Item(){} // RVA: 0x3FB8E40
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x38731B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x1A3F520
        public void System.Collections.IList.get_Item(){} // RVA: 0x3FB8F00
        public void System.Collections.IList.set_Item(){} // RVA: 0x3FB8F50
        public void System.Collections.IList.Add(){} // RVA: 0x3FB9070
        public void System.Collections.IList.Contains(){} // RVA: 0x3FB9100
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3FB91F0
        public void System.Collections.IList.Insert(){} // RVA: 0x3FB92D0
        public void System.Collections.IList.Remove(){} // RVA: 0x3FB9430
        public void .ctor(){} // RVA: 0x3FB4F30
        public void .cctor(){} // RVA: 0x3FB9560
    }

    public class RepeatedField`1
    {
        public System.Collections.Generic.EqualityComparer`1<Interval> EqualityComparer;
        public Interval[] EmptyArray; // 0x8
        public int MinArraySize;
        public Interval[] array; // 0x10
        public int count; // 0x18

        // ── Methods ──
        public void Clone(){} // RVA: 0x3FB5240
        public void AddEntriesFrom(){} // RVA: 0x3FB55E0
        public void CalculateSize(){} // RVA: 0x3FB58A0
        public void CalculatePackedDataSize(){} // RVA: 0x3FB5B50
        public void WriteTo(){} // RVA: 0x3FB5BF0
        public void EnsureSize(){} // RVA: 0x3FB5D30
        public void SetSize(){} // RVA: 0x3FB3A10
        public void Add(){} // RVA: 0x3FB6500 | overloaded x2
        public void Clear(){} // RVA: 0x3FB3B80
        public void Contains(){} // RVA: 0x3FB5F70
        public void CopyTo(){} // RVA: 0x38731B0
        public void Remove(){} // RVA: 0x3FB5FA0
        public void get_Count(){} // RVA: 0x5BED50
        public void get_IsReadOnly(){} // RVA: 0x2DD320
        public void AddRange(){} // RVA: 0x3FB6030
        public void GetEnumerator(){} // RVA: 0x3FB6520
        public void Equals(){} // RVA: 0x3FB66D0 | overloaded x2
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3FB6630
        public void GetHashCode(){} // RVA: 0x3FB6650
        public void IndexOf(){} // RVA: 0x3FB67F0
        public void Insert(){} // RVA: 0x3FB6960
        public void RemoveAt(){} // RVA: 0x3FB6AB0
        public void ToString(){} // RVA: 0x3FB6B60
        public void get_Item(){} // RVA: 0x3FB6C60
        public void set_Item(){} // RVA: 0x3FB6CE0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x38731B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x1A3F520
        public void System.Collections.IList.get_Item(){} // RVA: 0x3FB6DF0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3FB6E10
        public void System.Collections.IList.Add(){} // RVA: 0x3FB6F80
        public void System.Collections.IList.Contains(){} // RVA: 0x3FB7020
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3FB7110
        public void System.Collections.IList.Insert(){} // RVA: 0x3FB71F0
        public void System.Collections.IList.Remove(){} // RVA: 0x3FB73A0
        public void .ctor(){} // RVA: 0x3FB4F30
        public void .cctor(){} // RVA: 0x3FB74D0
    }

    public class RepeatedField`1
    {
        public System.Collections.Generic.EqualityComparer`1<RelativeKeypoint> EqualityComparer;
        public RelativeKeypoint[] EmptyArray; // 0x8
        public int MinArraySize;
        public RelativeKeypoint[] array; // 0x10
        public int count; // 0x18

        // ── Methods ──
        public void Clone(){} // RVA: 0x3FB5240
        public void AddEntriesFrom(){} // RVA: 0x3FB55E0
        public void CalculateSize(){} // RVA: 0x3FB58A0
        public void CalculatePackedDataSize(){} // RVA: 0x3FB5B50
        public void WriteTo(){} // RVA: 0x3FB5BF0
        public void EnsureSize(){} // RVA: 0x3FB5D30
        public void SetSize(){} // RVA: 0x3FB3A10
        public void Add(){} // RVA: 0x3FB6500 | overloaded x2
        public void Clear(){} // RVA: 0x3FB3B80
        public void Contains(){} // RVA: 0x3FB5F70
        public void CopyTo(){} // RVA: 0x38731B0
        public void Remove(){} // RVA: 0x3FB5FA0
        public void get_Count(){} // RVA: 0x5BED50
        public void get_IsReadOnly(){} // RVA: 0x2DD320
        public void AddRange(){} // RVA: 0x3FB6030
        public void GetEnumerator(){} // RVA: 0x3FB6520
        public void Equals(){} // RVA: 0x3FB66D0 | overloaded x2
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3FB6630
        public void GetHashCode(){} // RVA: 0x3FB6650
        public void IndexOf(){} // RVA: 0x3FB67F0
        public void Insert(){} // RVA: 0x3FB6960
        public void RemoveAt(){} // RVA: 0x3FB6AB0
        public void ToString(){} // RVA: 0x3FB6B60
        public void get_Item(){} // RVA: 0x3FB6C60
        public void set_Item(){} // RVA: 0x3FB6CE0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x38731B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x1A3F520
        public void System.Collections.IList.get_Item(){} // RVA: 0x3FB6DF0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3FB6E10
        public void System.Collections.IList.Add(){} // RVA: 0x3FB6F80
        public void System.Collections.IList.Contains(){} // RVA: 0x3FB7020
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3FB7110
        public void System.Collections.IList.Insert(){} // RVA: 0x3FB71F0
        public void System.Collections.IList.Remove(){} // RVA: 0x3FB73A0
        public void .ctor(){} // RVA: 0x3FB4F30
        public void .cctor(){} // RVA: 0x3FB74D0
    }

    public class RepeatedField`1
    {
        public System.Collections.Generic.EqualityComparer`1<AssociatedDetection> EqualityComparer;
        public AssociatedDetection[] EmptyArray; // 0x8
        public int MinArraySize;
        public AssociatedDetection[] array; // 0x10
        public int count; // 0x18

        // ── Methods ──
        public void Clone(){} // RVA: 0x3FB5240
        public void AddEntriesFrom(){} // RVA: 0x3FB55E0
        public void CalculateSize(){} // RVA: 0x3FB58A0
        public void CalculatePackedDataSize(){} // RVA: 0x3FB5B50
        public void WriteTo(){} // RVA: 0x3FB5BF0
        public void EnsureSize(){} // RVA: 0x3FB5D30
        public void SetSize(){} // RVA: 0x3FB3A10
        public void Add(){} // RVA: 0x3FB6500 | overloaded x2
        public void Clear(){} // RVA: 0x3FB3B80
        public void Contains(){} // RVA: 0x3FB5F70
        public void CopyTo(){} // RVA: 0x38731B0
        public void Remove(){} // RVA: 0x3FB5FA0
        public void get_Count(){} // RVA: 0x5BED50
        public void get_IsReadOnly(){} // RVA: 0x2DD320
        public void AddRange(){} // RVA: 0x3FB6030
        public void GetEnumerator(){} // RVA: 0x3FB6520
        public void Equals(){} // RVA: 0x3FB66D0 | overloaded x2
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3FB6630
        public void GetHashCode(){} // RVA: 0x3FB6650
        public void IndexOf(){} // RVA: 0x3FB67F0
        public void Insert(){} // RVA: 0x3FB6960
        public void RemoveAt(){} // RVA: 0x3FB6AB0
        public void ToString(){} // RVA: 0x3FB6B60
        public void get_Item(){} // RVA: 0x3FB6C60
        public void set_Item(){} // RVA: 0x3FB6CE0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x38731B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x1A3F520
        public void System.Collections.IList.get_Item(){} // RVA: 0x3FB6DF0
        public void System.Collections.IList.set_Item(){} // RVA: 0x3FB6E10
        public void System.Collections.IList.Add(){} // RVA: 0x3FB6F80
        public void System.Collections.IList.Contains(){} // RVA: 0x3FB7020
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3FB7110
        public void System.Collections.IList.Insert(){} // RVA: 0x3FB71F0
        public void System.Collections.IList.Remove(){} // RVA: 0x3FB73A0
        public void .ctor(){} // RVA: 0x3FB4F30
        public void .cctor(){} // RVA: 0x3FB74D0
    }

}