// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Immutable
// Classes: 39
// Methods: 307

namespace ThirdParty.DotNet.System.Collections.Immutable
{
    public class AllocFreeConcurrentStack
    {
    }

    public class AllocFreeConcurrentStack`1
    {
        public object Count;

        // ── Methods ──
        public void TryAdd(){} // RVA: 0x283FA0
        public void TryTake(){} // RVA: 0xDCC0
        public void get_ThreadLocalStack(){} // RVA: 0xC960
        public void .cctor(){} // RVA: 0x24A80
    }

    public class DictionaryEnumerator`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void get_Entry(){} // RVA: 0xC770
        public void get_Key(){} // RVA: 0xCD60
        public void get_Value(){} // RVA: 0xCD60
        public void get_Current(){} // RVA: 0xCD60
        public void MoveNext(){} // RVA: 0xDBE0
        public void Reset(){} // RVA: 0x24A50
    }

    public class DisposableEnumeratorAdapter`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10 | overloaded x2
        public void get_Current(){} // RVA: 0x283FA0
        public void MoveNext(){} // RVA: 0xDBE0
        public void Dispose(){} // RVA: 0x24A50
        public void GetEnumerator(){} // RVA: 0x283FA0
    }

    public class IImmutableArray
    {
        // ── Methods ──
        public void get_Array(){} // RVA: 0xCD60
    }

    public class IImmutableDictionaryInternal`2
    {
        // ── Methods ──
        public void ContainsValue(){} // RVA: 0x283FA0
    }

    public class IImmutableDictionary`2
    {
    }

    public class IImmutableList`1
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x283FA0
    }

    public class IOrderedCollection`1
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0xD840
        public void get_Item(){} // RVA: 0x283FA0
    }

    public class ISecurePooledObjectUser
    {
        // ── Methods ──
        public void get_PoolUserId(){} // RVA: 0xD840
    }

    public class IStrongEnumerable`2
    {
        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0x283FA0
    }

    public class IStrongEnumerator`1
    {
    }

    public class ImmutableArray
    {
        // ── Methods ──
        public void CreateBuilder(){} // RVA: 0x127A0
        public void .cctor(){} // RVA: 0x62BD6D0
    }

    public class ImmutableArrayBuilderDebuggerProxy`1
    {
    }

    public class ImmutableArray`1
    {
        // ── Methods ──
        public void System.Collections.Generic.IList<T>.get_Item(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IList<T>.set_Item(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xDBE0
        public void System.Collections.Generic.ICollection<T>.get_Count(){} // RVA: 0xD840
        public void System.Collections.Generic.IReadOnlyCollection<T>.get_Count(){} // RVA: 0xD840
        public void System.Collections.Generic.IReadOnlyList<T>.get_Item(){} // RVA: 0x283FA0
        public void AsSpan(){} // RVA: 0x283FA0
        public void IndexOf(){} // RVA: 0x283FA0 | overloaded x2
        public void Contains(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IList<T>.Insert(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IList<T>.RemoveAt(){} // RVA: 0x24FA0
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<T>.Clear(){} // RVA: 0x24A50
        public void System.Collections.Generic.ICollection<T>.Remove(){} // RVA: 0x283FA0
        public void System.Collections.IList.Add(){} // RVA: 0x12590
        public void System.Collections.IList.Clear(){} // RVA: 0x24A50
        public void System.Collections.IList.Contains(){} // RVA: 0xDE40
        public void System.Collections.IList.IndexOf(){} // RVA: 0x12590
        public void System.Collections.IList.Insert(){} // RVA: 0x26C40
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xDBE0
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_Count(){} // RVA: 0xD840
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void System.Collections.IList.Remove(){} // RVA: 0x24B10
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x24FA0
        public void System.Collections.IList.get_Item(){} // RVA: 0x1BCC0
        public void System.Collections.IList.set_Item(){} // RVA: 0x26C40
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.IStructuralEquatable.Equals(){} // RVA: 0x11120
        public void System.Collections.IStructuralEquatable.GetHashCode(){} // RVA: 0x12590
        public void System.Collections.IStructuralComparable.CompareTo(){} // RVA: 0x17680
        public void .ctor(){} // RVA: 0x24B10
        public void get_Item(){} // RVA: 0x283FA0
        public void get_Length(){} // RVA: 0xD840
        public void get_IsDefault(){} // RVA: 0xDBE0
        public void System.Collections.Immutable.IImmutableArray.get_Array(){} // RVA: 0xCD60
        public void CopyTo(){} // RVA: 0x2BAA0
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void GetHashCode(){} // RVA: 0xD840
        public void Equals(){} // RVA: 0x283FA0 | overloaded x2
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void ThrowNullRefIfNotInitialized(){} // RVA: 0x24A50
        public void ThrowInvalidOperationIfNotInitialized(){} // RVA: 0x24A50
        public void .cctor(){} // RVA: 0x24A80
    }

    public class ImmutableDictionary
    {
        // ── Methods ──
        public void ToImmutableDictionary(){} // RVA: 0x1D550 | overloaded x2
    }

    public class ImmutableDictionaryBuilderDebuggerProxy`2
    {
    }

    public class ImmutableDictionaryDebuggerProxy`2
    {
    }

    public class ImmutableDictionary`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void get_Count(){} // RVA: 0xD840
        public void get_IsEmpty(){} // RVA: 0xDBE0
        public void get_ValueComparer(){} // RVA: 0xCD60
        public void get_Keys(){} // RVA: 0xCD60
        public void get_Values(){} // RVA: 0xCD60
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0xCD60
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0xCD60
        public void get_Origin(){} // RVA: 0x283FA0
        public void get_Item(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xDBE0
        public void ContainsKey(){} // RVA: 0x283FA0 | overloaded x2
        public void Contains(){} // RVA: 0x283FA0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x283FA0 | overloaded x2
        public void ContainsValue(){} // RVA: 0x283FA0
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear(){} // RVA: 0x24A50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xDBE0
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xDBE0
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DC60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0xDE40
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x24B10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0xCE10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DC60
        public void System.Collections.IDictionary.Clear(){} // RVA: 0x24A50
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void .cctor(){} // RVA: 0x24A80
    }

    public class ImmutableEnumerableDebuggerProxy`1
    {
    }

    public class ImmutableExtensions
    {
        // ── Methods ──
        public void AsOrderedCollection(){} // RVA: 0xCE50
        public void ClearFastWhenEmpty(){} // RVA: 0x24AE0
        public void TryGetCount(){} // RVA: 0xE230 | overloaded x2
    }

    public class ImmutableHashSet
    {
        // ── Methods ──
        public void ToImmutableHashSet(){} // RVA: 0xCE50 | overloaded x2
    }

    public class ImmutableHashSet`1 : System.Collections.Generic
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10 | overloaded x2
        public void get_Count(){} // RVA: 0xD840
        public void get_IsEmpty(){} // RVA: 0xDBE0
        public void get_KeyComparer(){} // RVA: 0xCD60
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void get_Origin(){} // RVA: 0x283FA0
        public void Union(){} // RVA: 0x1D640 | overloaded x3
        public void SetEquals(){} // RVA: 0x283FA0 | overloaded x2
        public void Contains(){} // RVA: 0x283FA0 | overloaded x2
        public void WithComparer(){} // RVA: 0xCE10
        public void System.Collections.Generic.ISet<T>.Add(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xDBE0
        public void System.Collections.Generic.ICollection<T>.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<T>.Clear(){} // RVA: 0x24A50
        public void System.Collections.Generic.ICollection<T>.Remove(){} // RVA: 0x283FA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void UpdateRoot(){} // RVA: 0x283FA0
        public void GetHashBucketEqualityComparer(){} // RVA: 0xCE50
        public void Wrap(){} // RVA: 0x1DD80
        public void .cctor(){} // RVA: 0x24A80
    }

    public class ImmutableList
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x283FA0
    }

    public class ImmutableListBuilderDebuggerProxy`1
    {
    }

    public class ImmutableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void get_IsEmpty(){} // RVA: 0xDBE0
        public void get_Count(){} // RVA: 0xD840
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void get_Item(){} // RVA: 0x283FA0
        public void System.Collections.Immutable.IOrderedCollection<T>.get_Item(){} // RVA: 0x283FA0
        public void CopyTo(){} // RVA: 0x2BAA0
        public void IndexOf(){} // RVA: 0x283FA0 | overloaded x2
        public void Contains(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.Generic.IList<T>.Insert(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IList<T>.RemoveAt(){} // RVA: 0x24FA0
        public void System.Collections.Generic.IList<T>.get_Item(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IList<T>.set_Item(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<T>.Clear(){} // RVA: 0x24A50
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xDBE0
        public void System.Collections.Generic.ICollection<T>.Remove(){} // RVA: 0x283FA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.IList.Add(){} // RVA: 0x12590
        public void System.Collections.IList.RemoveAt(){} // RVA: 0x24FA0
        public void System.Collections.IList.Clear(){} // RVA: 0x24A50
        public void System.Collections.IList.Contains(){} // RVA: 0xDE40
        public void System.Collections.IList.IndexOf(){} // RVA: 0x12590
        public void System.Collections.IList.Insert(){} // RVA: 0x26C40
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xDBE0
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xDBE0
        public void System.Collections.IList.Remove(){} // RVA: 0x24B10
        public void System.Collections.IList.get_Item(){} // RVA: 0x1BCC0
        public void System.Collections.IList.set_Item(){} // RVA: 0x26C40
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void IsCompatibleObject(){} // RVA: 0xDCC0
        public void .cctor(){} // RVA: 0x24A80
    }

    public class ImmutableSortedDictionary
    {
        // ── Methods ──
        public void ToImmutableSortedDictionary(){} // RVA: 0xCE50 | overloaded x2
    }

    public class ImmutableSortedDictionaryBuilderDebuggerProxy`2
    {
    }

    public class ImmutableSortedDictionary`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DC60 | overloaded x2
        public void Clear(){} // RVA: 0xCD60
        public void get_ValueComparer(){} // RVA: 0xCD60
        public void get_IsEmpty(){} // RVA: 0xDBE0
        public void get_Count(){} // RVA: 0xD840
        public void get_Keys(){} // RVA: 0xCD60
        public void get_Values(){} // RVA: 0xCD60
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys(){} // RVA: 0xCD60
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Values(){} // RVA: 0xCD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xDBE0
        public void get_KeyComparer(){} // RVA: 0xCD60
        public void get_Item(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(){} // RVA: 0x283FA0
        public void AddRange(){} // RVA: 0xCE10 | overloaded x2
        public void WithComparers(){} // RVA: 0x1E6A0
        public void ContainsValue(){} // RVA: 0x283FA0
        public void ContainsKey(){} // RVA: 0x283FA0
        public void Contains(){} // RVA: 0x283FA0
        public void TryGetValue(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear(){} // RVA: 0x24A50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xDBE0
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xDBE0
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DC60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0xDE40
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x24B10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0xCE10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DC60
        public void System.Collections.IDictionary.Clear(){} // RVA: 0x24A50
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void Wrap(){} // RVA: 0x1DD80 | overloaded x2
        public void TryCastToImmutableMap(){} // RVA: 0xE230
        public void FillFromEmpty(){} // RVA: 0x1D640
        public void .cctor(){} // RVA: 0x24A80
    }

    public class KeysCollectionAccessor`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void Contains(){} // RVA: 0x283FA0
    }

    public class KeysOrValuesCollectionAccessor`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x37D3C70
        public void get_IsReadOnly(){} // RVA: 0x3C2850
        public void get_Count(){} // RVA: 0x37D1FA0
        public void get_Dictionary(){} // RVA: 0x2F8380
        public void Add(){} // RVA: 0x34B0F90
        public void Clear(){} // RVA: 0x28A5A70
        public void Contains(){} // RVA: 0x283FA0
        public void CopyTo(){} // RVA: 0x37D3DC0
        public void Remove(){} // RVA: 0x34B0F90
        public void GetEnumerator(){} // RVA: 0x37D2320
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x28A93C0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x37D4200
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x3C2850
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x1A3F520
    }

    public class RefAsValueType`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
    }

    public class Requires
    {
        // ── Methods ──
        public void NotNull(){} // RVA: 0x283FA0
        public void NotNullAllowStructs(){} // RVA: 0x283FA0
        public void FailArgumentNullException(){} // RVA: 0x62BD7F0
        public void Range(){} // RVA: 0x62BD840
        public void FailRange(){} // RVA: 0x62BD870
        public void Argument(){} // RVA: 0x62BD910
        public void FailObjectDisposed(){} // RVA: 0x283FA0
    }

    public class SecureObjectPool
    {
        // ── Methods ──
        public void NewId(){} // RVA: 0x62BD790
    }

    public class SecureObjectPool`2
    {
        // ── Methods ──
        public void TryAdd(){} // RVA: 0x283FA0
        public void TryTake(){} // RVA: 0x283FA0
        public void PrepNew(){} // RVA: 0x283FA0
    }

    public class SecurePooledObject`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void get_Owner(){} // RVA: 0xD840
        public void set_Owner(){} // RVA: 0x24FA0
        public void Use(){} // RVA: 0x283FA0
        public void TryUse(){} // RVA: 0x11120
        public void IsOwned(){} // RVA: 0xDE40
    }

    public class SortedInt32KeyNode`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0xDBE0
        public void get_Height(){} // RVA: 0xD840
        public void get_Left(){} // RVA: 0xCD60
        public void get_Right(){} // RVA: 0xCD60
        public void get_Value(){} // RVA: 0x283FA0
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void SetItem(){} // RVA: 0x283FA0
        public void Remove(){} // RVA: 0x1CEE0
        public void GetValueOrDefault(){} // RVA: 0x283FA0
        public void TryGetValue(){} // RVA: 0xF140
        public void Freeze(){} // RVA: 0x24B10
        public void RotateLeft(){} // RVA: 0xCE50
        public void RotateRight(){} // RVA: 0xCE50
        public void DoubleLeft(){} // RVA: 0xCE50
        public void DoubleRight(){} // RVA: 0xCE50
        public void Balance(){} // RVA: 0xD920
        public void IsRightHeavy(){} // RVA: 0xDCC0
        public void IsLeftHeavy(){} // RVA: 0xDCC0
        public void MakeBalanced(){} // RVA: 0xCE50
        public void SetOrAdd(){} // RVA: 0x283FA0
        public void RemoveRecursive(){} // RVA: 0x1CEE0
        public void Mutate(){} // RVA: 0x1E6A0
        public void .cctor(){} // RVA: 0x24A80
    }

    public class ValidatedNotNullAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ValuesCollectionAccessor`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void Contains(){} // RVA: 0x283FA0
    }

}