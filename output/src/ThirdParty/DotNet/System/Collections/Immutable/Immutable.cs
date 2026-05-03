// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Immutable
// Classes: 39
// Methods: 307

namespace ThirdParty.DotNet.System.Collections.Immutable
{
    public class AllocFreeConcurrentStack : Object
    {
    }

    public class AllocFreeConcurrentStack`1 : Object
    {
        public System.Type s_typeOfT;

        // ── Methods ──
        public void TryAdd(){} // RVA: 0x7FFE810A1420
        public void TryTake(){} // RVA: 0x7FFE80E2F230
        public void get_ThreadLocalStack(){} // RVA: 0x7FFE80E2DEE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class DictionaryEnumerator`2 : Object
    {
        public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<U,T>> _inner;
        public object field_1; // 0xA
        public object field_2; // 0xB
        public object field_3; // 0xC

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void get_Entry(){} // RVA: 0x7FFE80E2DCF0
        public void get_Key(){} // RVA: 0x7FFE80E2E2E0
        public void get_Value(){} // RVA: 0x7FFE80E2E2E0
        public void get_Current(){} // RVA: 0x7FFE80E2E2E0
        public void MoveNext(){} // RVA: 0x7FFE80E2F150
        public void Reset(){} // RVA: 0x7FFE80E45FE0
    }

    public class DisposableEnumeratorAdapter`2 : ValueType
    {
        public System.Collections.Generic.IEnumerator`1<T> _enumeratorObject;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void get_Current(){} // RVA: 0x7FFE810A1420
        public void MoveNext(){} // RVA: 0x7FFE80E2F150
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
    }

    public class IImmutableArray
    {
        // ── Methods ──
        public void get_Array(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IImmutableDictionaryInternal`2
    {
        // ── Methods ──
        public void ContainsValue(){} // RVA: 0x7FFE810A1420
    }

    public class IImmutableDictionary`2
    {
    }

    public class IImmutableList`1
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFE810A1420
    }

    public class IOrderedCollection`1
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_Item(){} // RVA: 0x7FFE810A1420
    }

    public class ISecurePooledObjectUser
    {
        // ── Methods ──
        public void get_PoolUserId(){} // RVA: 0x7FFE80E2EDB0
    }

    public class IStrongEnumerable`2
    {
        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
    }

    public class IStrongEnumerator`1
    {
    }

    public class ImmutableArray : Object
    {
        // ── Methods ──
        public void CreateBuilder(){} // RVA: 0x7FFE80E33D10
        public void .cctor(){} // RVA: 0x7FFE86DFE100
    }

    public class ImmutableArrayBuilderDebuggerProxy`1 : Object
    {
    }

    public class ImmutableArray`1 : ValueType
    {
        public System.Collections.Immutable.ImmutableArray`1<T> Empty;
        public T[] array;
        public System.Collections.Immutable.ImmutableArray`1<byte> Empty;
        public byte[] array; // 0x10
        public void System.Collections.Generic; // 0xF520
        public object field_5; // 0xF520
        public object field_6; // 0x1B8
        public object field_7; // 0x698
        public object field_8; // 0x6970
        public object field_9;
        public object System.Collections.Generic;
        public object field_11; // 0x7290
        public object field_12;
        public object field_13;
        public object field_14;

        // ── Methods ──
        public void System.Collections.Generic.IList<T>.get_Item(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IList<T>.set_Item(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.Generic.ICollection<T>.get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.Generic.IReadOnlyCollection<T>.get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.Generic.IReadOnlyList<T>.get_Item(){} // RVA: 0x7FFE810A1420
        public void AsSpan(){} // RVA: 0x7FFE810A1420
        public void IndexOf(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IList<T>.Insert(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IList<T>.RemoveAt(){} // RVA: 0x7FFE80E46530
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<T>.Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.Generic.ICollection<T>.Remove(){} // RVA: 0x7FFE810A1420
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE80E33B00
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE80E2F3B0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE80E33B00
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE80E48220
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE80E460A0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFE80E46530
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE80E3D230
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE80E48220
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFE80E32650
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFE80E33B00
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFE80E38BF0
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void get_Length(){} // RVA: 0x7FFE80E2EDB0
        public void get_IsDefault(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.Immutable.IImmutableArray.get_Array(){} // RVA: 0x7FFE80E2E2E0
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void Equals(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void ThrowNullRefIfNotInitialized(){} // RVA: 0x7FFE80E45FE0
        public void ThrowInvalidOperationIfNotInitialized(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class ImmutableDictionary : Object
    {
        // ── Methods ──
        public void ToImmutableDictionary(){} // RVA: 0x7FFE80E3EAC0 | overloaded x2
    }

    public class ImmutableDictionaryBuilderDebuggerProxy`2 : Object
    {
    }

    public class ImmutableDictionaryDebuggerProxy`2 : ImmutableEnumerableDebuggerProxy`1
    {
    }

    public class ImmutableDictionary`2 : Object
    {
        public System.Collections.Immutable.ImmutableDictionary`2<U,T> Empty;
        public System.Action`1<System.Collections.Generic.KeyValuePair`2<int,HashBucket<U,T>>> s_FreezeBucketAction;
        public int _count;
        public System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<U,T>> _root;
        public Comparers<U,T> _comparers;
        public object field_5; // 0x29
        public object field_6; // 0x2A
        public object field_7; // 0x2B
        public object field_8; // 0x2C
        public object field_9; // 0x2D
        public object field_10; // 0x2E
        public object field_11; // 0x2F
        public object field_12; // 0x30
        public object field_13; // 0x31
        public object field_14; // 0x32
        public object field_15; // 0x33
        public object field_16; // 0x34
        public object field_17; // 0x35

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_IsEmpty(){} // RVA: 0x7FFE80E2F150
        public void get_ValueComparer(){} // RVA: 0x7FFE80E2E2E0
        public void get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void get_Origin(){} // RVA: 0x7FFE810A1420
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void ContainsKey(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Contains(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void TryGetValue(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ContainsValue(){} // RVA: 0x7FFE810A1420
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFE80E4F230
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFE80E2F3B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFE80E460A0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFE80E2E390
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFE80E4F230
        public void System.Collections.IDictionary.Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class ImmutableEnumerableDebuggerProxy`1 : Object
    {
    }

    public class ImmutableExtensions : Object
    {
        // ── Methods ──
        public void AsOrderedCollection(){} // RVA: 0x7FFE80E2E3D0
        public void ClearFastWhenEmpty(){} // RVA: 0x7FFE80E46070
        public void TryGetCount(){} // RVA: 0x7FFE80E2F7A0 | overloaded x2
    }

    public class ImmutableHashSet : Object
    {
        // ── Methods ──
        public void ToImmutableHashSet(){} // RVA: 0x7FFE80E2E3D0 | overloaded x2
    }

    public class ImmutableHashSet`1 : Object
    {
        public System.Collections.Immutable.ImmutableHashSet`1<T> Empty;
        public System.Action`1<System.Collections.Generic.KeyValuePair`2<int,HashBucket<T>>> s_FreezeBucketAction;
        public System.Collections.Generic.IEqualityComparer`1<T> _equalityComparer;
        public int _count;
        public System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<T>> _root;
        public System.Collections.Generic.IEqualityComparer`1<HashBucket<T>> _hashBucketEqualityComparer;
        public System.Collections.Immutable.ImmutableHashSet`1<string> Empty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_IsEmpty(){} // RVA: 0x7FFE80E2F150
        public void get_KeyComparer(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void get_Origin(){} // RVA: 0x7FFE810A1420
        public void Union(){} // RVA: 0x7FFE80E3EBB0 | overloaded x3
        public void SetEquals(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Contains(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void WithComparer(){} // RVA: 0x7FFE80E2E390
        public void System.Collections.Generic.ISet<T>.Add(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.Generic.ICollection<T>.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<T>.Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.Generic.ICollection<T>.Remove(){} // RVA: 0x7FFE810A1420
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void UpdateRoot(){} // RVA: 0x7FFE810A1420
        public void GetHashBucketEqualityComparer(){} // RVA: 0x7FFE80E2E3D0
        public void Wrap(){} // RVA: 0x7FFE80E3F2F0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class ImmutableList : Object
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFE810A1420
    }

    public class ImmutableListBuilderDebuggerProxy`1 : Object
    {
    }

    public class ImmutableList`1 : Object
    {
        public System.Collections.Immutable.ImmutableList`1<T> Empty;
        public Node<T> _root;
        public object field_2; // 0x52
        public object field_3; // 0x53
        public object field_4; // 0x54
        public object field_5; // 0x55
        public object field_6; // 0x56
        public object field_7; // 0x57
        public object field_8; // 0x58
        public object field_9; // 0x59
        public object field_10; // 0x5A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void get_IsEmpty(){} // RVA: 0x7FFE80E2F150
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Immutable.IOrderedCollection<T>.get_Item(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void IndexOf(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IList<T>.Insert(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IList<T>.RemoveAt(){} // RVA: 0x7FFE80E46530
        public void System.Collections.Generic.IList<T>.get_Item(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IList<T>.set_Item(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<T>.Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.Generic.ICollection<T>.Remove(){} // RVA: 0x7FFE810A1420
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE80E33B00
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFE80E46530
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE80E2F3B0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE80E33B00
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE80E48220
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE80E460A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE80E3D230
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE80E48220
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
        public void IsCompatibleObject(){} // RVA: 0x7FFE80E2F230
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class ImmutableSortedDictionary : Object
    {
        // ── Methods ──
        public void ToImmutableSortedDictionary(){} // RVA: 0x7FFE80E2E3D0 | overloaded x2
    }

    public class ImmutableSortedDictionaryBuilderDebuggerProxy`2 : Object
    {
    }

    public class ImmutableSortedDictionary`2 : Object
    {
        public System.Collections.Immutable.ImmutableSortedDictionary`2<U,T> Empty;
        public Node<U,T> _root;
        public int _count;
        public System.Collections.Generic.IComparer`1<U> _keyComparer;
        public System.Collections.Generic.IEqualityComparer`1<T> _valueComparer;
        public object field_5; // 0x67
        public object field_6; // 0x68
        public object field_7; // 0x69
        public object field_8; // 0x6A
        public object field_9; // 0x6B
        public object field_10; // 0x6C
        public object field_11; // 0x6D
        public object field_12; // 0x6E
        public object field_13; // 0x6F
        public object field_14; // 0x70
        public object field_15; // 0x71
        public object field_16; // 0x72
        public object field_17; // 0x73

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4F230 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE80E2E2E0
        public void get_ValueComparer(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsEmpty(){} // RVA: 0x7FFE80E2F150
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void get_KeyComparer(){} // RVA: 0x7FFE80E2E2E0
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(){} // RVA: 0x7FFE810A1420
        public void AddRange(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void WithComparers(){} // RVA: 0x7FFE80E3FC10
        public void ContainsValue(){} // RVA: 0x7FFE810A1420
        public void ContainsKey(){} // RVA: 0x7FFE810A1420
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void TryGetValue(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFE80E4F230
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFE80E2F3B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFE80E460A0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFE80E2E390
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFE80E4F230
        public void System.Collections.IDictionary.Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
        public void Wrap(){} // RVA: 0x7FFE80E3F2F0 | overloaded x2
        public void TryCastToImmutableMap(){} // RVA: 0x7FFE80E2F7A0
        public void FillFromEmpty(){} // RVA: 0x7FFE80E3EBB0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class KeysCollectionAccessor`2 : KeysOrValuesCollectionAccessor`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void Contains(){} // RVA: 0x7FFE810A1420
    }

    public class KeysOrValuesCollectionAccessor`3 : Object
    {
        public System.Collections.Immutable.IImmutableDictionary`2<U,T> _dictionary; // 0x10
        public System.Collections.Generic.IEnumerable`1<U> _keysOrValues; // 0x18
        public object field_2; // 0x1250
        public object field_3;
        public object field_4; // 0xA8F3

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE844646B0
        public void get_IsReadOnly(){} // RVA: 0x7FFE811E0850
        public void get_Count(){} // RVA: 0x7FFE844629E0
        public void get_Dictionary(){} // RVA: 0x7FFE81116380
        public void Add(){} // RVA: 0x7FFE8411E510
        public void Clear(){} // RVA: 0x7FFE8360A6D0
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE84464800
        public void Remove(){} // RVA: 0x7FFE8411E510
        public void GetEnumerator(){} // RVA: 0x7FFE84462D60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8360DFD0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE84464C40
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE811E0850
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE827C4A80
    }

    public class RefAsValueType`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
    }

    public class Requires : Object
    {
        // ── Methods ──
        public void NotNull(){} // RVA: 0x7FFE810A1420
        public void NotNullAllowStructs(){} // RVA: 0x7FFE810A1420
        public void FailArgumentNullException(){} // RVA: 0x7FFE86DFE220
        public void Range(){} // RVA: 0x7FFE86DFE270
        public void FailRange(){} // RVA: 0x7FFE86DFE2A0
        public void Argument(){} // RVA: 0x7FFE86DFE340
        public void FailObjectDisposed(){} // RVA: 0x7FFE810A1420
    }

    public class SecureObjectPool : Object
    {
        // ── Methods ──
        public void NewId(){} // RVA: 0x7FFE86DFE1C0
    }

    public class SecureObjectPool`2 : Object
    {
        // ── Methods ──
        public void TryAdd(){} // RVA: 0x7FFE810A1420
        public void TryTake(){} // RVA: 0x7FFE810A1420
        public void PrepNew(){} // RVA: 0x7FFE810A1420
    }

    public class SecurePooledObject`1 : Object
    {
        public T _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void get_Owner(){} // RVA: 0x7FFE80E2EDB0
        public void set_Owner(){} // RVA: 0x7FFE80E46530
        public void Use(){} // RVA: 0x7FFE810A1420
        public void TryUse(){} // RVA: 0x7FFE80E32650
        public void IsOwned(){} // RVA: 0x7FFE80E2F3B0
    }

    public class SortedInt32KeyNode`1 : Object
    {
        public System.Collections.Immutable.SortedInt32KeyNode`1<T> EmptyNode;
        public int _key;
        public T _value;
        public bool _frozen;
        public byte _height;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFE80E2F150
        public void get_Height(){} // RVA: 0x7FFE80E2EDB0
        public void get_Left(){} // RVA: 0x7FFE80E2E2E0
        public void get_Right(){} // RVA: 0x7FFE80E2E2E0
        public void get_Value(){} // RVA: 0x7FFE810A1420
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
        public void SetItem(){} // RVA: 0x7FFE810A1420
        public void Remove(){} // RVA: 0x7FFE80E3E450
        public void GetValueOrDefault(){} // RVA: 0x7FFE810A1420
        public void TryGetValue(){} // RVA: 0x7FFE80E306B0
        public void Freeze(){} // RVA: 0x7FFE80E460A0
        public void RotateLeft(){} // RVA: 0x7FFE80E2E3D0
        public void RotateRight(){} // RVA: 0x7FFE80E2E3D0
        public void DoubleLeft(){} // RVA: 0x7FFE80E2E3D0
        public void DoubleRight(){} // RVA: 0x7FFE80E2E3D0
        public void Balance(){} // RVA: 0x7FFE80E2EE90
        public void IsRightHeavy(){} // RVA: 0x7FFE80E2F230
        public void IsLeftHeavy(){} // RVA: 0x7FFE80E2F230
        public void MakeBalanced(){} // RVA: 0x7FFE80E2E3D0
        public void SetOrAdd(){} // RVA: 0x7FFE810A1420
        public void RemoveRecursive(){} // RVA: 0x7FFE80E3E450
        public void Mutate(){} // RVA: 0x7FFE80E3FC10
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class ValidatedNotNullAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ValuesCollectionAccessor`2 : KeysOrValuesCollectionAccessor`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void Contains(){} // RVA: 0x7FFE810A1420
    }

}