// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Immutable
// Classes: 30
// Methods: 304

namespace ThirdParty.DotNet.System.Collections.Immutable
{
    public class AllocFreeConcurrentStack`1 : Object
    {
        public object ThreadLocalStack;

        // ── Methods ──
        public void TryAdd(){} // RVA: 0x7FFD4E2ADC40
        public void TryTake(){} // RVA: 0x7FFD4E079DE0
        public void get_ThreadLocalStack(){} // RVA: 0x7FFD4E078A90
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class DictionaryEnumerator`2 : Object
    {
        public object Entry;
        public object Key;
        public object Value;
        public object Current;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void get_Entry(){} // RVA: 0x7FFD4E0788A0
        public void get_Key(){} // RVA: 0x7FFD4E078E90
        public void get_Value(){} // RVA: 0x7FFD4E078E90
        public void get_Current(){} // RVA: 0x7FFD4E078E90
        public void MoveNext(){} // RVA: 0x7FFD4E079D00
        public void Reset(){} // RVA: 0x7FFD4E090980
    }

    public class DisposableEnumeratorAdapter`2 : ValueType
    {
        public object Current;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void get_Current(){} // RVA: 0x7FFD4E2ADC40
        public void MoveNext(){} // RVA: 0x7FFD4E079D00
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IImmutableDictionaryInternal`2
    {
        // ── Methods ──
        public void ContainsValue(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IImmutableDictionary`2
    {
    }

    public class IImmutableList`1
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IOrderedCollection`1
    {
        public object Count;
        public object Item;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ISecurePooledObjectUser
    {
        public object PoolUserId;

        // ── Methods ──
        public void get_PoolUserId(){} // RVA: 0x7FFD4E079960
    }

    public class IStrongEnumerable`2
    {
        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IStrongEnumerator`1
    {
    }

    public class ImmutableArray : Object
    {
        // ── Methods ──
        public void CreateBuilder(){} // RVA: 0x7FFD4E07E8C0
        public void .cctor(){} // RVA: 0x7FFD53E74A70
    }

    public class ImmutableArray`1 : ValueType
    {
        public object System.Collections.Generic.IList<T>.Item;
        public object System.Collections.Generic.ICollection<T>.IsReadOnly;
        public object System.Collections.Generic.ICollection<T>.Count;
        public object System.Collections.Generic.IReadOnlyCollection<T>.Count;
        public object System.Collections.Generic.IReadOnlyList<T>.Item;
        public object System.Collections.IList.IsFixedSize;
        public object System.Collections.IList.IsReadOnly;
        public object System.Collections.ICollection.Count;
        public object System.Collections.ICollection.IsSynchronized;
        public object System.Collections.ICollection.SyncRoot;
        public object System.Collections.IList.Item;
        public object Item;
        public object Length;
        public object IsDefault;
        public object System.Collections.Immutable.IImmutableArray.Array;

        // ── Methods ──
        public void System.Collections.Generic.IList<T>.get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IList<T>.set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.Generic.ICollection<T>.get_Count(){} // RVA: 0x7FFD4E079960
        public void System.Collections.Generic.IReadOnlyCollection<T>.get_Count(){} // RVA: 0x7FFD4E079960
        public void System.Collections.Generic.IReadOnlyList<T>.get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void AsSpan(){} // RVA: 0x7FFD4E2ADC40
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IList<T>.Insert(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IList<T>.RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<T>.Clear(){} // RVA: 0x7FFD4E090980
        public void System.Collections.Generic.ICollection<T>.Remove(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.IList.Add(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFD4E090980
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFD4E079F60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFD4E092BC0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFD4E079960
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFD4E090A40
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFD4E087DE0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFD4E092BC0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x7FFD4E07D200
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x7FFD4E0837A0
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void get_IsDefault(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.Immutable.IImmutableArray.get_Array(){} // RVA: 0x7FFD4E078E90
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void Equals(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void ThrowNullRefIfNotInitialized(){} // RVA: 0x7FFD4E090980
        public void ThrowInvalidOperationIfNotInitialized(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class ImmutableDictionary : Object
    {
        // ── Methods ──
        public void ToImmutableDictionary(){} // RVA: 0x7FFD4E089600 | overloaded x2
    }

    public class ImmutableDictionary`2 : Object
    {
        public object Count;
        public object IsEmpty;
        public object ValueComparer;
        public object Keys;
        public object Values;
        public object System.Collections.Generic.IDictionary<TKey,TValue>.Keys;
        public object System.Collections.Generic.IDictionary<TKey,TValue>.Values;
        public object Origin;
        public object Item;
        public object System.Collections.Generic.IDictionary<TKey,TValue>.Item;
        public object System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly;
        public object System.Collections.IDictionary.IsFixedSize;
        public object System.Collections.IDictionary.IsReadOnly;
        public object System.Collections.IDictionary.Keys;
        public object System.Collections.IDictionary.Values;
        public object System.Collections.IDictionary.Item;
        public object System.Collections.ICollection.SyncRoot;
        public object System.Collections.ICollection.IsSynchronized;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_IsEmpty(){} // RVA: 0x7FFD4E079D00
        public void get_ValueComparer(){} // RVA: 0x7FFD4E078E90
        public void get_Keys(){} // RVA: 0x7FFD4E078E90
        public void get_Values(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFD4E078E90
        public void get_Origin(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void ContainsKey(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Contains(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void TryGetValue(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ContainsValue(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear(){} // RVA: 0x7FFD4E090980
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFD4E099B30
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFD4E079F60
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFD4E090A40
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFD4E078F40
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFD4E099B30
        public void System.Collections.IDictionary.Clear(){} // RVA: 0x7FFD4E090980
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class ImmutableEnumerableDebuggerProxy`1 : Object
    {
    }

    public class ImmutableExtensions : Object
    {
        // ── Methods ──
        public void AsOrderedCollection(){} // RVA: 0x7FFD4E078F80
        public void ClearFastWhenEmpty(){} // RVA: 0x7FFD4E090A10
        public void TryGetCount(){} // RVA: 0x7FFD4E07A350 | overloaded x2
    }

    public class ImmutableHashSet : Object
    {
        // ── Methods ──
        public void ToImmutableHashSet(){} // RVA: 0x7FFD4E078F80 | overloaded x2
    }

    public class ImmutableHashSet`1 : Object
    {
        public object Count;
        public object IsEmpty;
        public object KeyComparer;
        public object System.Collections.ICollection.SyncRoot;
        public object System.Collections.ICollection.IsSynchronized;
        public object Origin;
        public object System.Collections.Generic.ICollection<T>.IsReadOnly;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_IsEmpty(){} // RVA: 0x7FFD4E079D00
        public void get_KeyComparer(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void get_Origin(){} // RVA: 0x7FFD4E2ADC40
        public void Union(){} // RVA: 0x7FFD4E0896F0 | overloaded x3
        public void SetEquals(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Contains(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void WithComparer(){} // RVA: 0x7FFD4E078F40
        public void System.Collections.Generic.ISet<T>.Add(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.Generic.ICollection<T>.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<T>.Clear(){} // RVA: 0x7FFD4E090980
        public void System.Collections.Generic.ICollection<T>.Remove(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void UpdateRoot(){} // RVA: 0x7FFD4E2ADC40
        public void GetHashBucketEqualityComparer(){} // RVA: 0x7FFD4E078F80
        public void Wrap(){} // RVA: 0x7FFD4E089DD0
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class ImmutableList : Object
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ImmutableList`1 : Object
    {
        public object IsEmpty;
        public object Count;
        public object System.Collections.ICollection.SyncRoot;
        public object System.Collections.ICollection.IsSynchronized;
        public object Item;
        public object System.Collections.Immutable.IOrderedCollection<T>.Item;
        public object System.Collections.Generic.IList<T>.Item;
        public object System.Collections.Generic.ICollection<T>.IsReadOnly;
        public object System.Collections.IList.IsFixedSize;
        public object System.Collections.IList.IsReadOnly;
        public object System.Collections.IList.Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void get_IsEmpty(){} // RVA: 0x7FFD4E079D00
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Immutable.IOrderedCollection<T>.get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IList<T>.Insert(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IList<T>.RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void System.Collections.Generic.IList<T>.get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IList<T>.set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<T>.Clear(){} // RVA: 0x7FFD4E090980
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.Generic.ICollection<T>.Remove(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.IList.Add(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void System.Collections.IList.Clear(){} // RVA: 0x7FFD4E090980
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFD4E079F60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFD4E07E6B0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFD4E092BC0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFD4E090A40
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFD4E087DE0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFD4E092BC0
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void IsCompatibleObject(){} // RVA: 0x7FFD4E079DE0
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class ImmutableSortedDictionary : Object
    {
        // ── Methods ──
        public void ToImmutableSortedDictionary(){} // RVA: 0x7FFD4E078F80 | overloaded x2
    }

    public class ImmutableSortedDictionary`2 : Object
    {
        public object ValueComparer;
        public object IsEmpty;
        public object Count;
        public object Keys;
        public object Values;
        public object System.Collections.Generic.IDictionary<TKey,TValue>.Keys;
        public object System.Collections.Generic.IDictionary<TKey,TValue>.Values;
        public object System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly;
        public object KeyComparer;
        public object Item;
        public object System.Collections.Generic.IDictionary<TKey,TValue>.Item;
        public object System.Collections.IDictionary.IsFixedSize;
        public object System.Collections.IDictionary.IsReadOnly;
        public object System.Collections.IDictionary.Keys;
        public object System.Collections.IDictionary.Values;
        public object System.Collections.IDictionary.Item;
        public object System.Collections.ICollection.SyncRoot;
        public object System.Collections.ICollection.IsSynchronized;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30 | overloaded x2
        public void Clear(){} // RVA: 0x7FFD4E078E90
        public void get_ValueComparer(){} // RVA: 0x7FFD4E078E90
        public void get_IsEmpty(){} // RVA: 0x7FFD4E079D00
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_Keys(){} // RVA: 0x7FFD4E078E90
        public void get_Values(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void get_KeyComparer(){} // RVA: 0x7FFD4E078E90
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void AddRange(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void WithComparers(){} // RVA: 0x7FFD4E08A6F0
        public void ContainsValue(){} // RVA: 0x7FFD4E2ADC40
        public void ContainsKey(){} // RVA: 0x7FFD4E2ADC40
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetValue(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear(){} // RVA: 0x7FFD4E090980
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFD4E099B30
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFD4E079F60
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFD4E090A40
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFD4E078F40
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFD4E099B30
        public void System.Collections.IDictionary.Clear(){} // RVA: 0x7FFD4E090980
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void Wrap(){} // RVA: 0x7FFD4E089DD0 | overloaded x2
        public void TryCastToImmutableMap(){} // RVA: 0x7FFD4E07A350
        public void FillFromEmpty(){} // RVA: 0x7FFD4E0896F0
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class KeysCollectionAccessor`2 : KeysOrValuesCollectionAccessor`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
    }

    public class KeysOrValuesCollectionAccessor`3 : Object
    {
        public object IsReadOnly;
        public object Count;
        public object Dictionary;
        public object System.Collections.ICollection.IsSynchronized;
        public object System.Collections.ICollection.SyncRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_Dictionary(){} // RVA: 0x7FFD4E078E90
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
    }

    public class RefAsValueType`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Requires : Object
    {
        // ── Methods ──
        public void NotNull(){} // RVA: 0x7FFD4E2ADC40
        public void NotNullAllowStructs(){} // RVA: 0x7FFD4E2ADC40
        public void FailArgumentNullException(){} // RVA: 0x7FFD53E74B90
        public void Range(){} // RVA: 0x7FFD53E74BE0
        public void FailRange(){} // RVA: 0x7FFD53E74C10
        public void Argument(){} // RVA: 0x7FFD53E74CB0
        public void FailObjectDisposed(){} // RVA: 0x7FFD4E2ADC40
    }

    public class SecureObjectPool`2 : Object
    {
        // ── Methods ──
        public void TryAdd(){} // RVA: 0x7FFD4E2ADC40
        public void TryTake(){} // RVA: 0x7FFD4E2ADC40
        public void PrepNew(){} // RVA: 0x7FFD4E2ADC40
    }

    public class SecurePooledObject`1 : Object
    {
        public object Owner;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void get_Owner(){} // RVA: 0x7FFD4E079960
        public void set_Owner(){} // RVA: 0x7FFD4E090ED0
        public void Use(){} // RVA: 0x7FFD4E2ADC40
        public void TryUse(){} // RVA: 0x7FFD4E07D200
        public void IsOwned(){} // RVA: 0x7FFD4E079F60
    }

    public class SortedInt32KeyNode`1 : Object
    {
        public object IsEmpty;
        public object Height;
        public object Left;
        public object Right;
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFD4E079D00
        public void get_Height(){} // RVA: 0x7FFD4E079960
        public void get_Left(){} // RVA: 0x7FFD4E078E90
        public void get_Right(){} // RVA: 0x7FFD4E078E90
        public void get_Value(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void SetItem(){} // RVA: 0x7FFD4E2ADC40
        public void Remove(){} // RVA: 0x7FFD4E088F90
        public void GetValueOrDefault(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetValue(){} // RVA: 0x7FFD4E07B260
        public void Freeze(){} // RVA: 0x7FFD4E090A40
        public void RotateLeft(){} // RVA: 0x7FFD4E078F80
        public void RotateRight(){} // RVA: 0x7FFD4E078F80
        public void DoubleLeft(){} // RVA: 0x7FFD4E078F80
        public void DoubleRight(){} // RVA: 0x7FFD4E078F80
        public void Balance(){} // RVA: 0x7FFD4E079A40
        public void IsRightHeavy(){} // RVA: 0x7FFD4E079DE0
        public void IsLeftHeavy(){} // RVA: 0x7FFD4E079DE0
        public void MakeBalanced(){} // RVA: 0x7FFD4E078F80
        public void SetOrAdd(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveRecursive(){} // RVA: 0x7FFD4E088F90
        public void Mutate(){} // RVA: 0x7FFD4E08A6F0
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class ValuesCollectionAccessor`2 : KeysOrValuesCollectionAccessor`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
    }

}