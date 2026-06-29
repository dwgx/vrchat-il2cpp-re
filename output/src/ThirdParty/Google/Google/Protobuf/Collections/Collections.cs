// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Google.Google.Protobuf.Collections
// Classes: 10
// Methods: 316

namespace ThirdParty.Google.Google.Protobuf.Collections
{
    public class Lists : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x87D880
        public void GetHashCode(){} // RVA: 0x87D090
    }

    public class MapField`2 : Object
    {
        public object ValueEqualityComparer;
        public object KeyEqualityComparer;
        public object map;
        public object list;

        // ── Methods ──
        public void Clone(){} // RVA: 0x87C0A0
        public void Add(){} // RVA: 0x894320
        public void ContainsKey(){} // RVA: 0xA94080
        public void ContainsValue(){} // RVA: 0xA94080
        public void Remove(){} // RVA: 0xA94080
        public void TryGetValue(){} // RVA: 0xA94080
        public void get_Item(){} // RVA: 0xA94080
        public void set_Item(){} // RVA: 0xA94080
        public void get_Keys(){} // RVA: 0x87C0A0
        public void get_Values(){} // RVA: 0x87C0A0
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0xA94080
        public void Clear(){} // RVA: 0x894290
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0xA94080
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x899290
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0xA94080
        public void get_Count(){} // RVA: 0x87C130
        public void get_IsReadOnly(){} // RVA: 0x87D280
        public void Equals(){} // RVA: 0x87D350
        public void GetHashCode(){} // RVA: 0x87C130
        public void AddEntriesFrom(){} // RVA: 0x8943B0
        public void WriteTo(){} // RVA: 0x8943B0
        public void CalculateSize(){} // RVA: 0x87D050
        public void CalculateEntrySize(){} // RVA: 0xA94080
        public void ToString(){} // RVA: 0x87C0A0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x8943B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x87D350
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x894320
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x899290
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x87D280
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x87C0A0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x87C0A0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x87D280
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x87C0A0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x87C540
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x8943B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x87C0A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0x894290
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class ProtobufEqualityComparers : Object
    {
        public object _bitwiseDoubleEqualityComparer;
        public object _bitwiseSingleEqualityComparer;
        public object _bitwiseNullableDoubleEqualityComparer;
        public object _bitwiseNullableSingleEqualityComparer;

        // ── Methods ──
        public void GetEqualityComparer(){} // RVA: 0x2996600
        public void get_BitwiseDoubleEqualityComparer(){} // RVA: 0x65083C0
        public void get_BitwiseSingleEqualityComparer(){} // RVA: 0x6508420
        public void get_BitwiseNullableDoubleEqualityComparer(){} // RVA: 0x6508480
        public void get_BitwiseNullableSingleEqualityComparer(){} // RVA: 0x65084E0
        public void .cctor(){} // RVA: 0x6508540
    }

    public class RepeatedField`1 : Object
    {
        public object EqualityComparer;
        public object EmptyArray;
        public object MinArraySize;
        public object array;
        public object count;

        // ── Methods ──
        public void Clone(){} // RVA: 0x4A68E60
        public void AddEntriesFrom(){} // RVA: 0x4A691F0
        public void CalculateSize(){} // RVA: 0x4A694B0
        public void CalculatePackedDataSize(){} // RVA: 0x4A69750
        public void WriteTo(){} // RVA: 0x4A69800
        public void EnsureSize(){} // RVA: 0x4A69960
        public void SetSize(){} // RVA: 0x4A675F0
        public void Add(){} // RVA: 0x4A6A120
        public void Clear(){} // RVA: 0x4A67760
        public void Contains(){} // RVA: 0x4A69BA0
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void Remove(){} // RVA: 0x4A69BD0
        public void get_Count(){} // RVA: 0xE62D00
        public void get_IsReadOnly(){} // RVA: 0xB43320
        public void AddRange(){} // RVA: 0x4A69C60
        public void GetEnumerator(){} // RVA: 0x4A6A140
        public void Equals(){} // RVA: 0x4A6A300
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4A6A250
        public void GetHashCode(){} // RVA: 0x4A6A270
        public void IndexOf(){} // RVA: 0x4A6A430
        public void Insert(){} // RVA: 0x4A6A5A0
        public void RemoveAt(){} // RVA: 0x4A6A6F0
        public void ToString(){} // RVA: 0x4A6A7A0
        public void get_Item(){} // RVA: 0x4A6A8A0
        public void set_Item(){} // RVA: 0x4A6A920
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2303260
        public void System.Collections.IList.get_Item(){} // RVA: 0x4A6AA30
        public void System.Collections.IList.set_Item(){} // RVA: 0x4A6AA50
        public void System.Collections.IList.Add(){} // RVA: 0x4A6ABC0
        public void System.Collections.IList.Contains(){} // RVA: 0x4A6AC60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4A6AD50
        public void System.Collections.IList.Insert(){} // RVA: 0x4A6AE30
        public void System.Collections.IList.Remove(){} // RVA: 0x4A6AFE0
        public void .ctor(){} // RVA: 0x4A68B50
        public void .cctor(){} // RVA: 0x4A6B110
    }

    public class RepeatedField`1 : Object
    {
        public object EqualityComparer;
        public object EmptyArray;
        public object MinArraySize;
        public object array;
        public object count;

        // ── Methods ──
        public void Clone(){} // RVA: 0x4A68E60
        public void AddEntriesFrom(){} // RVA: 0x4A691F0
        public void CalculateSize(){} // RVA: 0x4A694B0
        public void CalculatePackedDataSize(){} // RVA: 0x4A69750
        public void WriteTo(){} // RVA: 0x4A69800
        public void EnsureSize(){} // RVA: 0x4A69960
        public void SetSize(){} // RVA: 0x4A675F0
        public void Add(){} // RVA: 0x4A6A120
        public void Clear(){} // RVA: 0x4A67760
        public void Contains(){} // RVA: 0x4A69BA0
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void Remove(){} // RVA: 0x4A69BD0
        public void get_Count(){} // RVA: 0xE62D00
        public void get_IsReadOnly(){} // RVA: 0xB43320
        public void AddRange(){} // RVA: 0x4A69C60
        public void GetEnumerator(){} // RVA: 0x4A6A140
        public void Equals(){} // RVA: 0x4A6A300
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4A6A250
        public void GetHashCode(){} // RVA: 0x4A6A270
        public void IndexOf(){} // RVA: 0x4A6A430
        public void Insert(){} // RVA: 0x4A6A5A0
        public void RemoveAt(){} // RVA: 0x4A6A6F0
        public void ToString(){} // RVA: 0x4A6A7A0
        public void get_Item(){} // RVA: 0x4A6A8A0
        public void set_Item(){} // RVA: 0x4A6A920
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2303260
        public void System.Collections.IList.get_Item(){} // RVA: 0x4A6AA30
        public void System.Collections.IList.set_Item(){} // RVA: 0x4A6AA50
        public void System.Collections.IList.Add(){} // RVA: 0x4A6ABC0
        public void System.Collections.IList.Contains(){} // RVA: 0x4A6AC60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4A6AD50
        public void System.Collections.IList.Insert(){} // RVA: 0x4A6AE30
        public void System.Collections.IList.Remove(){} // RVA: 0x4A6AFE0
        public void .ctor(){} // RVA: 0x4A68B50
        public void .cctor(){} // RVA: 0x4A6B110
    }

    public class RepeatedField`1 : Object
    {
        public object EqualityComparer;
        public object EmptyArray;
        public object MinArraySize;
        public object array;
        public object count;

        // ── Methods ──
        public void Clone(){} // RVA: 0x87C0A0
        public void AddEntriesFrom(){} // RVA: 0x8943B0
        public void CalculateSize(){} // RVA: 0x87D050
        public void CalculatePackedDataSize(){} // RVA: 0x87D050
        public void WriteTo(){} // RVA: 0x8943B0
        public void EnsureSize(){} // RVA: 0x8944F0
        public void SetSize(){} // RVA: 0x8944F0
        public void Add(){} // RVA: 0x894320
        public void Clear(){} // RVA: 0x894290
        public void Contains(){} // RVA: 0xA94080
        public void CopyTo(){} // RVA: 0x899290
        public void Remove(){} // RVA: 0xA94080
        public void get_Count(){} // RVA: 0x87C130
        public void get_IsReadOnly(){} // RVA: 0x87D280
        public void AddRange(){} // RVA: 0x894320
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void Equals(){} // RVA: 0x87D350
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void GetHashCode(){} // RVA: 0x87C130
        public void IndexOf(){} // RVA: 0xA94080
        public void Insert(){} // RVA: 0xA94080
        public void RemoveAt(){} // RVA: 0x8944F0
        public void ToString(){} // RVA: 0x87C0A0
        public void get_Item(){} // RVA: 0xA94080
        public void set_Item(){} // RVA: 0xA94080
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x87D280
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x899290
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x87D280
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x87C0A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x87C160
        public void System.Collections.IList.set_Item(){} // RVA: 0x895750
        public void System.Collections.IList.Add(){} // RVA: 0x87D050
        public void System.Collections.IList.Contains(){} // RVA: 0x87D350
        public void System.Collections.IList.IndexOf(){} // RVA: 0x87D050
        public void System.Collections.IList.Insert(){} // RVA: 0x895750
        public void System.Collections.IList.Remove(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0x894290
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class RepeatedField`1 : Object
    {
        public object EqualityComparer;
        public object EmptyArray;
        public object MinArraySize;
        public object array;
        public object count;

        // ── Methods ──
        public void Clone(){} // RVA: 0x4A68E60
        public void AddEntriesFrom(){} // RVA: 0x4A691F0
        public void CalculateSize(){} // RVA: 0x4A694B0
        public void CalculatePackedDataSize(){} // RVA: 0x4A69750
        public void WriteTo(){} // RVA: 0x4A69800
        public void EnsureSize(){} // RVA: 0x4A69960
        public void SetSize(){} // RVA: 0x4A675F0
        public void Add(){} // RVA: 0x4A6A120
        public void Clear(){} // RVA: 0x4A67760
        public void Contains(){} // RVA: 0x4A69BA0
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void Remove(){} // RVA: 0x4A69BD0
        public void get_Count(){} // RVA: 0xE62D00
        public void get_IsReadOnly(){} // RVA: 0xB43320
        public void AddRange(){} // RVA: 0x4A69C60
        public void GetEnumerator(){} // RVA: 0x4A6A140
        public void Equals(){} // RVA: 0x4A6A300
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4A6A250
        public void GetHashCode(){} // RVA: 0x4A6A270
        public void IndexOf(){} // RVA: 0x4A6A430
        public void Insert(){} // RVA: 0x4A6A5A0
        public void RemoveAt(){} // RVA: 0x4A6A6F0
        public void ToString(){} // RVA: 0x4A6A7A0
        public void get_Item(){} // RVA: 0x4A6A8A0
        public void set_Item(){} // RVA: 0x4A6A920
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2303260
        public void System.Collections.IList.get_Item(){} // RVA: 0x4A6AA30
        public void System.Collections.IList.set_Item(){} // RVA: 0x4A6AA50
        public void System.Collections.IList.Add(){} // RVA: 0x4A6ABC0
        public void System.Collections.IList.Contains(){} // RVA: 0x4A6AC60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4A6AD50
        public void System.Collections.IList.Insert(){} // RVA: 0x4A6AE30
        public void System.Collections.IList.Remove(){} // RVA: 0x4A6AFE0
        public void .ctor(){} // RVA: 0x4A68B50
        public void .cctor(){} // RVA: 0x4A6B110
    }

    public class RepeatedField`1 : Object
    {
        public object EqualityComparer;
        public object EmptyArray;
        public object MinArraySize;
        public object array;
        public object count;

        // ── Methods ──
        public void Clone(){} // RVA: 0x4A66960
        public void AddEntriesFrom(){} // RVA: 0x4A66CA0
        public void CalculateSize(){} // RVA: 0x4A66FE0
        public void CalculatePackedDataSize(){} // RVA: 0x4A67280
        public void WriteTo(){} // RVA: 0x4A67330
        public void EnsureSize(){} // RVA: 0x4A67490
        public void SetSize(){} // RVA: 0x4A675F0
        public void Add(){} // RVA: 0x4A67CB0
        public void Clear(){} // RVA: 0x4A67760
        public void Contains(){} // RVA: 0x4A67830
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void Remove(){} // RVA: 0x4A67860
        public void get_Count(){} // RVA: 0xE62D00
        public void get_IsReadOnly(){} // RVA: 0xB43320
        public void AddRange(){} // RVA: 0x4A678F0
        public void GetEnumerator(){} // RVA: 0x4A67CD0
        public void Equals(){} // RVA: 0x4A67EF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4A67DE0
        public void GetHashCode(){} // RVA: 0x4A67E90
        public void IndexOf(){} // RVA: 0x4A68020
        public void Insert(){} // RVA: 0x4A68140
        public void RemoveAt(){} // RVA: 0x4A68240
        public void ToString(){} // RVA: 0x4A682F0
        public void get_Item(){} // RVA: 0x4A683F0
        public void set_Item(){} // RVA: 0x4A68470
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2303260
        public void System.Collections.IList.get_Item(){} // RVA: 0x4A68530
        public void System.Collections.IList.set_Item(){} // RVA: 0x4A68580
        public void System.Collections.IList.Add(){} // RVA: 0x4A68690
        public void System.Collections.IList.Contains(){} // RVA: 0x4A68720
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4A68800
        public void System.Collections.IList.Insert(){} // RVA: 0x4A688D0
        public void System.Collections.IList.Remove(){} // RVA: 0x4A68A20
        public void .ctor(){} // RVA: 0x4A68B50
        public void .cctor(){} // RVA: 0x4A68C10
    }

    public class RepeatedField`1 : Object
    {
        public object EqualityComparer;
        public object EmptyArray;
        public object MinArraySize;
        public object array;
        public object count;

        // ── Methods ──
        public void Clone(){} // RVA: 0x4A6B360
        public void AddEntriesFrom(){} // RVA: 0x4A6B6A0
        public void CalculateSize(){} // RVA: 0x4A6B9E0
        public void CalculatePackedDataSize(){} // RVA: 0x4A6BC80
        public void WriteTo(){} // RVA: 0x4A6BD30
        public void EnsureSize(){} // RVA: 0x4A6BE90
        public void SetSize(){} // RVA: 0x4A675F0
        public void Add(){} // RVA: 0x4A6C500
        public void Clear(){} // RVA: 0x4A67760
        public void Contains(){} // RVA: 0x4A6C080
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void Remove(){} // RVA: 0x4A6C0B0
        public void get_Count(){} // RVA: 0xE62D00
        public void get_IsReadOnly(){} // RVA: 0xB43320
        public void AddRange(){} // RVA: 0x4A6C140
        public void GetEnumerator(){} // RVA: 0x4A67CD0
        public void Equals(){} // RVA: 0x4A6C610
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4A67DE0
        public void GetHashCode(){} // RVA: 0x4A6C590
        public void IndexOf(){} // RVA: 0x4A6C740
        public void Insert(){} // RVA: 0x4A6C860
        public void RemoveAt(){} // RVA: 0x4A68240
        public void ToString(){} // RVA: 0x4A6C960
        public void get_Item(){} // RVA: 0x4A6CA60
        public void set_Item(){} // RVA: 0x4A6CAF0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2303260
        public void System.Collections.IList.get_Item(){} // RVA: 0x4A6CBB0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4A6CC00
        public void System.Collections.IList.Add(){} // RVA: 0x4A6CD20
        public void System.Collections.IList.Contains(){} // RVA: 0x4A6CDB0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4A6CEA0
        public void System.Collections.IList.Insert(){} // RVA: 0x4A6CF80
        public void System.Collections.IList.Remove(){} // RVA: 0x4A6D0E0
        public void .ctor(){} // RVA: 0x4A68B50
        public void .cctor(){} // RVA: 0x4A6D210
    }

    public class RepeatedField`1 : Object
    {
        public object EqualityComparer;
        public object EmptyArray;
        public object MinArraySize;
        public object array;
        public object count;

        // ── Methods ──
        public void Clone(){} // RVA: 0x4A68E60
        public void AddEntriesFrom(){} // RVA: 0x4A691F0
        public void CalculateSize(){} // RVA: 0x4A694B0
        public void CalculatePackedDataSize(){} // RVA: 0x4A69750
        public void WriteTo(){} // RVA: 0x4A69800
        public void EnsureSize(){} // RVA: 0x4A69960
        public void SetSize(){} // RVA: 0x4A675F0
        public void Add(){} // RVA: 0x4A6A120
        public void Clear(){} // RVA: 0x4A67760
        public void Contains(){} // RVA: 0x4A69BA0
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void Remove(){} // RVA: 0x4A69BD0
        public void get_Count(){} // RVA: 0xE62D00
        public void get_IsReadOnly(){} // RVA: 0xB43320
        public void AddRange(){} // RVA: 0x4A69C60
        public void GetEnumerator(){} // RVA: 0x4A6A140
        public void Equals(){} // RVA: 0x4A6A300
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4A6A250
        public void GetHashCode(){} // RVA: 0x4A6A270
        public void IndexOf(){} // RVA: 0x4A6A430
        public void Insert(){} // RVA: 0x4A6A5A0
        public void RemoveAt(){} // RVA: 0x4A6A6F0
        public void ToString(){} // RVA: 0x4A6A7A0
        public void get_Item(){} // RVA: 0x4A6A8A0
        public void set_Item(){} // RVA: 0x4A6A920
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2303260
        public void System.Collections.IList.get_Item(){} // RVA: 0x4A6AA30
        public void System.Collections.IList.set_Item(){} // RVA: 0x4A6AA50
        public void System.Collections.IList.Add(){} // RVA: 0x4A6ABC0
        public void System.Collections.IList.Contains(){} // RVA: 0x4A6AC60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4A6AD50
        public void System.Collections.IList.Insert(){} // RVA: 0x4A6AE30
        public void System.Collections.IList.Remove(){} // RVA: 0x4A6AFE0
        public void .ctor(){} // RVA: 0x4A68B50
        public void .cctor(){} // RVA: 0x4A6B110
    }

}