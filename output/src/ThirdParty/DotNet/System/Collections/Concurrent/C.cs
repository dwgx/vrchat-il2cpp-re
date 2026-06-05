// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Concurrent
// Classes: 68
// Methods: 3389

namespace ThirdParty.DotNet.System.Collections.Concurrent
{
    public class CDSCollectionETWBCLProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88BE7D0
        public void ConcurrentStack_FastPushFailed(){} // RVA: 0x7FFAF3AD0CE0
        public void ConcurrentStack_FastPopFailed(){} // RVA: 0x7FFAF3AD0CE0
        public void ConcurrentDictionary_AcquiringAllLocks(){} // RVA: 0x7FFAF3AD0CE0
        public void .cctor(){} // RVA: 0x7FFAF88BE7E0
    }

    public class CDSCollectionETWBCLProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88BE7D0
        public void ConcurrentBag_TryTakeSteals(){} // RVA: 0x7FFAF3AD0CE0
        public void ConcurrentBag_TryPeekSteals(){} // RVA: 0x7FFAF3AD0CE0
        public void .cctor(){} // RVA: 0x7FFAF976E380
    }

    public class ConcurrentBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
        public void Add(){} // RVA: 0x7FFAF2D33FA0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF2D33FA0
        public void TryTake(){} // RVA: 0x7FFAF2ABDE40
        public void GetCurrentThreadWorkStealingQueue(){}
        public void CreateWorkStealingQueueForCurrentThread(){} // RVA: 0x7FFAF2ABCD60
        public void GetUnownedWorkStealingQueue(){} // RVA: 0x7FFAF2ABCD60
        public void TrySteal(){}
        public void TryStealFromTo(){} // RVA: 0x7FFAF2D33FA0
        public void CopyTo(){} // RVA: 0x7FFAF2ADBAA0
        public void CopyFromEachQueueToArray(){}
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF2ADBAA0
        public void ToArray(){} // RVA: 0x7FFAF2ABCD60
        public void GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void get_Count(){} // RVA: 0x7FFAF2ABD840
        public void get_DangerousCount(){} // RVA: 0x7FFAF2ABD840
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2ABDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF2ABCD60
        public void get_GlobalQueuesLock(){} // RVA: 0x7FFAF2ABCD60
        public void FreezeBag(){} // RVA: 0x7FFAF2AD4B10
        public void UnfreezeBag(){} // RVA: 0x7FFAF2AD5130
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54A7910
        public void .ctor(){} // RVA: 0x7FFAF54A7FE0 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54A7C70
        public void TryAdd(){} // RVA: 0x7FFAF54A83A0
        public void ContainsKey(){} // RVA: 0x7FFAF54A84F0
        public void TryRemove(){} // RVA: 0x7FFAF54A8530
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54A8570
        public void TryGetValue(){} // RVA: 0x7FFAF54A8B30
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54A8C60
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54A8E40
        public void Clear(){} // RVA: 0x7FFAF54A93C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54A9660
        public void ToArray(){} // RVA: 0x7FFAF54A9970
        public void CopyToPairs(){} // RVA: 0x7FFAF54A9BD0
        public void CopyToEntries(){} // RVA: 0x7FFAF54A9CE0
        public void CopyToObjects(){} // RVA: 0x7FFAF54A9E10
        public void GetEnumerator(){} // RVA: 0x7FFAF54A9F80
        public void TryAddInternal(){} // RVA: 0x7FFAF54AA020
        public void get_Item(){} // RVA: 0x7FFAF54AA7A0
        public void set_Item(){} // RVA: 0x7FFAF54AA870
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54AAA90
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54AADC0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54AB1B0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54AB410
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54AB540
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54AB6E0
        public void get_Keys(){} // RVA: 0x7FFAF54AB740
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54AB740
        public void get_Values(){} // RVA: 0x7FFAF54AB760
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54AB760
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54AB780
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54AB860
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54AB900
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54AB950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54AB970
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54ABBA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54ABCD0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54AB740
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54ABDB0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54AB760
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54ABEF0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54AC010
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54AC350
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54AC930
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54AD0F0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54AD140
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54AD420
        public void GetValues(){} // RVA: 0x7FFAF54AD6F0
        public void OnSerializing(){} // RVA: 0x7FFAF54AD9B0
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54ADAD0
        public void .cctor(){} // RVA: 0x7FFAF54ADDA0
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF2ABDC10
        public void .ctor(){} // RVA: 0x7FFAF2D33FA0 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF2AD4B10
        public void TryAdd(){} // RVA: 0x7FFAF2D33FA0
        public void ContainsKey(){} // RVA: 0x7FFAF2D33FA0
        public void TryRemove(){} // RVA: 0x7FFAF2D33FA0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF2D33FA0
        public void TryGetValue(){} // RVA: 0x7FFAF2D33FA0
        public void TryGetValueInternal(){} // RVA: 0x7FFAF2D33FA0
        public void TryUpdateInternal(){} // RVA: 0x7FFAF2D33FA0
        public void Clear(){} // RVA: 0x7FFAF2AD4A50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF2ADBAA0
        public void ToArray(){} // RVA: 0x7FFAF2ABCD60
        public void CopyToPairs(){} // RVA: 0x7FFAF2ADBAA0
        public void CopyToEntries(){} // RVA: 0x7FFAF2ADBAA0
        public void CopyToObjects(){} // RVA: 0x7FFAF2ADBAA0
        public void GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void TryAddInternal(){} // RVA: 0x7FFAF2D33FA0
        public void get_Item(){} // RVA: 0x7FFAF2D33FA0
        public void set_Item(){} // RVA: 0x7FFAF2D33FA0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF2AD4AE0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF2AD4A80
        public void get_Count(){} // RVA: 0x7FFAF2ABD840
        public void GetCountInternal(){} // RVA: 0x7FFAF2ABD840
        public void GetOrAdd(){} // RVA: 0x7FFAF2D33FA0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF2ABDBE0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF2D33FA0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF2D33FA0
        public void get_Keys(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF2ABCD60
        public void get_Values(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF2D33FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF2D33FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2ABDBE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF2D33FA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF2ADDC60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF2ABDE40
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2ABDBE0
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2ABDBE0
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF2AD4B10
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF2ABCE10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF2ADDC60
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF2ADBAA0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2ABDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF2ABCD60
        public void GrowTable(){} // RVA: 0x7FFAF2AD4B10
        public void GetBucket(){} // RVA: 0x7FFAF2AC3CA0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF2D33FA0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF2ABD870
        public void AcquireAllLocks(){} // RVA: 0x7FFAF2AD4B10
        public void AcquireLocks(){}
        public void ReleaseLocks(){} // RVA: 0x7FFAF2AD6EE0
        public void GetKeys(){} // RVA: 0x7FFAF2ABCD60
        public void GetValues(){} // RVA: 0x7FFAF2ABCD60
        public void OnSerializing(){} // RVA: 0x7FFAF2AD4B10
        public void OnSerialized(){} // RVA: 0x7FFAF2AD4B10
        public void OnDeserialized(){} // RVA: 0x7FFAF2AD4B10
        public void .cctor(){} // RVA: 0x7FFAF2AD4A80
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54F86E0
        public void .ctor(){} // RVA: 0x7FFAF54F8DB0 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54F8A40
        public void TryAdd(){} // RVA: 0x7FFAF54F9170
        public void ContainsKey(){} // RVA: 0x7FFAF54A84F0
        public void TryRemove(){} // RVA: 0x7FFAF54A8530
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54A8570
        public void TryGetValue(){} // RVA: 0x7FFAF54A8B30
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54A8C60
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54A8E40
        public void Clear(){} // RVA: 0x7FFAF54F92C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54F9560
        public void ToArray(){} // RVA: 0x7FFAF54F9880
        public void CopyToPairs(){} // RVA: 0x7FFAF54F9BF0
        public void CopyToEntries(){} // RVA: 0x7FFAF54A9CE0
        public void CopyToObjects(){} // RVA: 0x7FFAF54A9E10
        public void GetEnumerator(){} // RVA: 0x7FFAF54A9F80
        public void TryAddInternal(){} // RVA: 0x7FFAF54F9D00
        public void get_Item(){} // RVA: 0x7FFAF54AA7A0
        public void set_Item(){} // RVA: 0x7FFAF54FA410
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54FA560
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54FA800 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54FABF0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54FAE50
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54FAF80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54AB6E0
        public void get_Keys(){} // RVA: 0x7FFAF54FB120
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54FB120
        public void get_Values(){} // RVA: 0x7FFAF54FB140
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54FB140
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54AB780
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54AB860
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54AB900
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54AB950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54AB970
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54ABBA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54ABCD0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54FB120
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54ABDB0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54FB140
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54ABEF0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54FB160
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54FB380
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54FB960
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54FC0F0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54FC140
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54FC230
        public void GetValues(){} // RVA: 0x7FFAF54FC500
        public void OnSerializing(){} // RVA: 0x7FFAF54FC7C0
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54FC880
        public void .cctor(){} // RVA: 0x7FFAF54FCB50
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54F86E0
        public void .ctor(){} // RVA: 0x7FFAF54F8DB0 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54F8A40
        public void TryAdd(){} // RVA: 0x7FFAF54F9170
        public void ContainsKey(){} // RVA: 0x7FFAF54A84F0
        public void TryRemove(){} // RVA: 0x7FFAF54A8530
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54A8570
        public void TryGetValue(){} // RVA: 0x7FFAF54A8B30
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54A8C60
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54A8E40
        public void Clear(){} // RVA: 0x7FFAF54F92C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54F9560
        public void ToArray(){} // RVA: 0x7FFAF54F9880
        public void CopyToPairs(){} // RVA: 0x7FFAF54F9BF0
        public void CopyToEntries(){} // RVA: 0x7FFAF54A9CE0
        public void CopyToObjects(){} // RVA: 0x7FFAF54A9E10
        public void GetEnumerator(){} // RVA: 0x7FFAF54A9F80
        public void TryAddInternal(){} // RVA: 0x7FFAF54F9D00
        public void get_Item(){} // RVA: 0x7FFAF54AA7A0
        public void set_Item(){} // RVA: 0x7FFAF54FA410
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54FA560
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54FA800 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54FABF0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54FAE50
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54FAF80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54AB6E0
        public void get_Keys(){} // RVA: 0x7FFAF54FB120
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54FB120
        public void get_Values(){} // RVA: 0x7FFAF54FB140
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54FB140
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54AB780
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54AB860
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54AB900
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54AB950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54AB970
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54ABBA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54ABCD0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54FB120
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54ABDB0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54FB140
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54ABEF0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54FB160
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54FB380
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54FB960
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54FC0F0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54FC140
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54FC230
        public void GetValues(){} // RVA: 0x7FFAF54FC500
        public void OnSerializing(){} // RVA: 0x7FFAF54FC7C0
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54FC880
        public void .cctor(){} // RVA: 0x7FFAF54FCB50
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54EB720
        public void .ctor(){} // RVA: 0x7FFAF54EBE10 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54EBA80
        public void TryAdd(){} // RVA: 0x7FFAF54EC1D0
        public void ContainsKey(){} // RVA: 0x7FFAF54EC340
        public void TryRemove(){} // RVA: 0x7FFAF54EC390
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54EC3E0
        public void TryGetValue(){} // RVA: 0x7FFAF54EC930
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54ECA70
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54ECC00
        public void Clear(){} // RVA: 0x7FFAF54ED170
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54ED410
        public void ToArray(){} // RVA: 0x7FFAF54ED650
        public void CopyToPairs(){} // RVA: 0x7FFAF54ED8B0
        public void CopyToEntries(){} // RVA: 0x7FFAF54ED9D0
        public void CopyToObjects(){} // RVA: 0x7FFAF54EDB10
        public void GetEnumerator(){} // RVA: 0x7FFAF54EDC90
        public void TryAddInternal(){} // RVA: 0x7FFAF54EDD30
        public void get_Item(){} // RVA: 0x7FFAF54EE430
        public void set_Item(){} // RVA: 0x7FFAF54EE510
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54EE680
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54EE950 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54EEEA0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54EF240
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54EF370
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54EF530
        public void get_Keys(){} // RVA: 0x7FFAF54EF5A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54EF5A0
        public void get_Values(){} // RVA: 0x7FFAF54EF5C0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54EF5C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54EF5E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54EF660
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54EF710
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54EF770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54EF790
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54EF9D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54EFB10
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54EF5A0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54EFBF0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54EF5C0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54EFD30
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54EFE60
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54F0090
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54F0680
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54F0E30
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54F0E80
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54F0F70
        public void GetValues(){} // RVA: 0x7FFAF54F1240
        public void OnSerializing(){} // RVA: 0x7FFAF54F1500
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54F15C0
        public void .cctor(){} // RVA: 0x7FFAF54F1890
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54A7910
        public void .ctor(){} // RVA: 0x7FFAF54A7FE0 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54A7C70
        public void TryAdd(){} // RVA: 0x7FFAF54A83A0
        public void ContainsKey(){} // RVA: 0x7FFAF54A84F0
        public void TryRemove(){} // RVA: 0x7FFAF54A8530
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54A8570
        public void TryGetValue(){} // RVA: 0x7FFAF54A8B30
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54A8C60
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54A8E40
        public void Clear(){} // RVA: 0x7FFAF54A93C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54A9660
        public void ToArray(){} // RVA: 0x7FFAF54A9970
        public void CopyToPairs(){} // RVA: 0x7FFAF54A9BD0
        public void CopyToEntries(){} // RVA: 0x7FFAF54A9CE0
        public void CopyToObjects(){} // RVA: 0x7FFAF54A9E10
        public void GetEnumerator(){} // RVA: 0x7FFAF54A9F80
        public void TryAddInternal(){} // RVA: 0x7FFAF54AA020
        public void get_Item(){} // RVA: 0x7FFAF54AA7A0
        public void set_Item(){} // RVA: 0x7FFAF54AA870
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54AAA90
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54AADC0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54AB1B0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54AB410
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54AB540
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54AB6E0
        public void get_Keys(){} // RVA: 0x7FFAF54AB740
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54AB740
        public void get_Values(){} // RVA: 0x7FFAF54AB760
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54AB760
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54AB780
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54AB860
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54AB900
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54AB950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54AB970
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54ABBA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54ABCD0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54AB740
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54ABDB0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54AB760
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54ABEF0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54AC010
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54AC350
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54AC930
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54AD0F0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54AD140
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54AD420
        public void GetValues(){} // RVA: 0x7FFAF54AD6F0
        public void OnSerializing(){} // RVA: 0x7FFAF54AD9B0
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54ADAD0
        public void .cctor(){} // RVA: 0x7FFAF54ADDA0
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF553DCF0
        public void .ctor(){} // RVA: 0x7FFAF553E3B0 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF553E050
        public void TryAdd(){} // RVA: 0x7FFAF553E770
        public void ContainsKey(){} // RVA: 0x7FFAF553E830
        public void TryRemove(){} // RVA: 0x7FFAF553E860
        public void TryRemoveInternal(){} // RVA: 0x7FFAF553E8A0
        public void TryGetValue(){} // RVA: 0x7FFAF553ED60
        public void TryGetValueInternal(){} // RVA: 0x7FFAF553EE10
        public void TryUpdateInternal(){} // RVA: 0x7FFAF553EF60
        public void Clear(){} // RVA: 0x7FFAF553F470
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF553F710
        public void ToArray(){} // RVA: 0x7FFAF553FA00
        public void CopyToPairs(){} // RVA: 0x7FFAF553FD40
        public void CopyToEntries(){} // RVA: 0x7FFAF54C0060
        public void CopyToObjects(){} // RVA: 0x7FFAF553FE30
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF553FF80
        public void get_Item(){} // RVA: 0x7FFAF5540610
        public void set_Item(){} // RVA: 0x7FFAF55406D0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF5540790
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF5540990 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF5540DC0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF5541090
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF55411C0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF5541230
        public void get_Keys(){} // RVA: 0x7FFAF5541280
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF5541280
        public void get_Values(){} // RVA: 0x7FFAF55412A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF55412A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF55412C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF5541330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF55413D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54C1800
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF5541420
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF5541640
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54C1B60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF5541280
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF5541760
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF55412A0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF5541890
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF55419A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF5541C30
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF5542270
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF55429E0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF5542A30
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF5542B20
        public void GetValues(){} // RVA: 0x7FFAF5542DE0
        public void OnSerializing(){} // RVA: 0x7FFAF55430A0
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF5543160
        public void .cctor(){} // RVA: 0x7FFAF5543430
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54B8470
        public void .ctor(){} // RVA: 0x7FFAF54B8B30 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54B87D0
        public void TryAdd(){} // RVA: 0x7FFAF54B8EF0
        public void ContainsKey(){} // RVA: 0x7FFAF54B8FB0
        public void TryRemove(){} // RVA: 0x7FFAF54B8FE0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54B9020
        public void TryGetValue(){} // RVA: 0x7FFAF54B94D0
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54B9580
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54B96D0
        public void Clear(){} // RVA: 0x7FFAF54B9BC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54B9E60
        public void ToArray(){} // RVA: 0x7FFAF54BA160
        public void CopyToPairs(){} // RVA: 0x7FFAF54BA450
        public void CopyToEntries(){} // RVA: 0x7FFAF54BA540
        public void CopyToObjects(){} // RVA: 0x7FFAF54BA670
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54BA870
        public void get_Item(){} // RVA: 0x7FFAF54BAEF0
        public void set_Item(){} // RVA: 0x7FFAF54BAFA0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54BB060
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54BB260 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54BB670 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54BB940
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54BBA70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54BBAE0
        public void get_Keys(){} // RVA: 0x7FFAF54BBB30
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54BBB30
        public void get_Values(){} // RVA: 0x7FFAF54BBB50
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54BBB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54BBB70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54BBBE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54BBC80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54BBCF0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54BBF10
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54BBB30
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54BC110
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54BBB50
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54BC230
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54BC340
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54BC550
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54BCBB0
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54BD330
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54BD380
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54BD470
        public void GetValues(){} // RVA: 0x7FFAF54BD720
        public void OnSerializing(){} // RVA: 0x7FFAF54BD9E0
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54BDAA0
        public void .cctor(){} // RVA: 0x7FFAF54BDD70
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54FCD60
        public void .ctor(){} // RVA: 0x7FFAF54FD380 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54FD0C0
        public void TryAdd(){} // RVA: 0x7FFAF54FD740
        public void ContainsKey(){} // RVA: 0x7FFAF54FD800
        public void TryRemove(){} // RVA: 0x7FFAF54FD830
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54FD860
        public void TryGetValue(){} // RVA: 0x7FFAF54FDD00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54FDDB0
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54FDF00
        public void Clear(){} // RVA: 0x7FFAF54FE3E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54FE680
        public void ToArray(){} // RVA: 0x7FFAF54FE940
        public void CopyToPairs(){} // RVA: 0x7FFAF54FEC50
        public void CopyToEntries(){} // RVA: 0x7FFAF54FECE0
        public void CopyToObjects(){} // RVA: 0x7FFAF54FEE30
        public void GetEnumerator(){} // RVA: 0x7FFAF54B0200
        public void TryAddInternal(){} // RVA: 0x7FFAF54FEF50
        public void get_Item(){} // RVA: 0x7FFAF54FF5B0
        public void set_Item(){} // RVA: 0x7FFAF54FF660
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54FF720
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54FF920 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54FFD00 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54FFFA0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF55000D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF55001F0
        public void get_Keys(){} // RVA: 0x7FFAF5500240
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF5500240
        public void get_Values(){} // RVA: 0x7FFAF5500260
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF5500260
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF5500280
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF5500300
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF5500390
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54B1760
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF55003E0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF55005F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54B1AC0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF5500240
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF5500710
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF5500260
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF5500830
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF5500A20
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF5500C30
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF5501270
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF55019E0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF5501A30
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF5501B20
        public void GetValues(){} // RVA: 0x7FFAF5501DD0
        public void OnSerializing(){} // RVA: 0x7FFAF5502080
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF5502140
        public void .cctor(){} // RVA: 0x7FFAF5502410
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54ADFB0
        public void .ctor(){} // RVA: 0x7FFAF54AE5D0 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54AE310
        public void TryAdd(){} // RVA: 0x7FFAF54AE990
        public void ContainsKey(){} // RVA: 0x7FFAF54AEA50
        public void TryRemove(){} // RVA: 0x7FFAF54AEA80
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54AEAB0
        public void TryGetValue(){} // RVA: 0x7FFAF54AEF60
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54AF010
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54AF160
        public void Clear(){} // RVA: 0x7FFAF54AF650
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54AF8F0
        public void ToArray(){} // RVA: 0x7FFAF54AFBC0
        public void CopyToPairs(){} // RVA: 0x7FFAF54AFEE0
        public void CopyToEntries(){} // RVA: 0x7FFAF54AFF80
        public void CopyToObjects(){} // RVA: 0x7FFAF54B00D0
        public void GetEnumerator(){} // RVA: 0x7FFAF54B0200
        public void TryAddInternal(){} // RVA: 0x7FFAF54B02A0
        public void get_Item(){} // RVA: 0x7FFAF54B0900
        public void set_Item(){} // RVA: 0x7FFAF54B09B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54B0A70
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54B0C70 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54B1070 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54B1320
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54B1450
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54B1570
        public void get_Keys(){} // RVA: 0x7FFAF54B15C0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54B15C0
        public void get_Values(){} // RVA: 0x7FFAF54B15E0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54B15E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54B1600
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54B1680
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54B1710
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54B1760
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54B1780
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54B19A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54B1AC0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54B15C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54B1BA0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54B15E0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54B1CC0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54B1EB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54B20C0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54B2740
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54B2EB0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54B2F00
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54B2FF0
        public void GetValues(){} // RVA: 0x7FFAF54B32B0
        public void OnSerializing(){} // RVA: 0x7FFAF54B3560
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54B3620
        public void .cctor(){} // RVA: 0x7FFAF54B38F0
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54C3B30
        public void .ctor(){} // RVA: 0x7FFAF54C41F0 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54C3E90
        public void TryAdd(){} // RVA: 0x7FFAF54C45B0
        public void ContainsKey(){} // RVA: 0x7FFAF54C4670
        public void TryRemove(){} // RVA: 0x7FFAF54BEAF0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54BEB30
        public void TryGetValue(){} // RVA: 0x7FFAF54BEFE0
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54BF090
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54BF1E0
        public void Clear(){} // RVA: 0x7FFAF54C46A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54C4940
        public void ToArray(){} // RVA: 0x7FFAF54C4C20
        public void CopyToPairs(){} // RVA: 0x7FFAF54BFF80
        public void CopyToEntries(){} // RVA: 0x7FFAF54C0060
        public void CopyToObjects(){} // RVA: 0x7FFAF54C0190
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54C4F50
        public void get_Item(){} // RVA: 0x7FFAF54C55D0
        public void set_Item(){} // RVA: 0x7FFAF54C5690
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54C5750
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54C5950 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54C5D70 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54C6040
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54C6170
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54C1610
        public void get_Keys(){} // RVA: 0x7FFAF54C61E0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54C61E0
        public void get_Values(){} // RVA: 0x7FFAF54C6200
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54C6200
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54C16A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54C6220
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54C17B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54C1800
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54C1820
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54C62C0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54C1B60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54C61E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54C1C40
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54C6200
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54C63E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54C64F0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54C6780
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54C6DC0
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54C7540
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54C7590
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54C7680
        public void GetValues(){} // RVA: 0x7FFAF54C7940
        public void OnSerializing(){} // RVA: 0x7FFAF54C7C00
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54C7CC0
        public void .cctor(){} // RVA: 0x7FFAF54C7F90
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54D43F0
        public void .ctor(){} // RVA: 0x7FFAF54D4AF0 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54D4750
        public void TryAdd(){} // RVA: 0x7FFAF54D4EB0
        public void ContainsKey(){} // RVA: 0x7FFAF54CEEE0
        public void TryRemove(){} // RVA: 0x7FFAF54D4FB0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54D5030
        public void TryGetValue(){} // RVA: 0x7FFAF54CF500
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54CF600
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54D54D0
        public void Clear(){} // RVA: 0x7FFAF54D59C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54D5C60
        public void ToArray(){} // RVA: 0x7FFAF54D5F60
        public void CopyToPairs(){} // RVA: 0x7FFAF54D0530
        public void CopyToEntries(){} // RVA: 0x7FFAF54D0630
        public void CopyToObjects(){} // RVA: 0x7FFAF54D0760
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54D62B0
        public void get_Item(){} // RVA: 0x7FFAF54D0F20
        public void set_Item(){} // RVA: 0x7FFAF54D6910
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54D6A10
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54D6C50 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54D70D0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54D73C0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54D74F0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54D7560
        public void get_Keys(){} // RVA: 0x7FFAF54D75F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54D75F0
        public void get_Values(){} // RVA: 0x7FFAF54D7610
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54D7610
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54D7630
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54D76A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54D77E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54C1800
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54D7890
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54D7AB0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54C1B60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54D75F0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54D7BC0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54D7610
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54D24B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54D7CE0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54D7F70
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54D85D0
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54D8D50
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54D8DA0
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54D8E90
        public void GetValues(){} // RVA: 0x7FFAF54D9150
        public void OnSerializing(){} // RVA: 0x7FFAF54D9410
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54D94D0
        public void .cctor(){} // RVA: 0x7FFAF54D97A0
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54B8470
        public void .ctor(){} // RVA: 0x7FFAF54B8B30 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54B87D0
        public void TryAdd(){} // RVA: 0x7FFAF54B8EF0
        public void ContainsKey(){} // RVA: 0x7FFAF54B8FB0
        public void TryRemove(){} // RVA: 0x7FFAF54B8FE0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54B9020
        public void TryGetValue(){} // RVA: 0x7FFAF54B94D0
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54B9580
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54B96D0
        public void Clear(){} // RVA: 0x7FFAF54B9BC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54B9E60
        public void ToArray(){} // RVA: 0x7FFAF54BA160
        public void CopyToPairs(){} // RVA: 0x7FFAF54BA450
        public void CopyToEntries(){} // RVA: 0x7FFAF54BA540
        public void CopyToObjects(){} // RVA: 0x7FFAF54BA670
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54BA870
        public void get_Item(){} // RVA: 0x7FFAF54BAEF0
        public void set_Item(){} // RVA: 0x7FFAF54BAFA0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54BB060
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54BB260 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54BB670 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54BB940
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54BBA70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54BBAE0
        public void get_Keys(){} // RVA: 0x7FFAF54BBB30
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54BBB30
        public void get_Values(){} // RVA: 0x7FFAF54BBB50
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54BBB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54BBB70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54BBBE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54BBC80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54BBCF0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54BBF10
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54BBB30
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54BC110
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54BBB50
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54BC230
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54BC340
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54BC550
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54BCBB0
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54BD330
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54BD380
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54BD470
        public void GetValues(){} // RVA: 0x7FFAF54BD720
        public void OnSerializing(){} // RVA: 0x7FFAF54BD9E0
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54BDAA0
        public void .cctor(){} // RVA: 0x7FFAF54BDD70
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54CE320
        public void .ctor(){} // RVA: 0x7FFAF54CEA20 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54CE680
        public void TryAdd(){} // RVA: 0x7FFAF54CEDE0
        public void ContainsKey(){} // RVA: 0x7FFAF54CEEE0
        public void TryRemove(){} // RVA: 0x7FFAF54CEFE0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54CF060
        public void TryGetValue(){} // RVA: 0x7FFAF54CF500
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54CF600
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54CF750
        public void Clear(){} // RVA: 0x7FFAF54CFC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54CFEE0
        public void ToArray(){} // RVA: 0x7FFAF54D01E0
        public void CopyToPairs(){} // RVA: 0x7FFAF54D0530
        public void CopyToEntries(){} // RVA: 0x7FFAF54D0630
        public void CopyToObjects(){} // RVA: 0x7FFAF54D0760
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54D08C0
        public void get_Item(){} // RVA: 0x7FFAF54D0F20
        public void set_Item(){} // RVA: 0x7FFAF54D1060
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54D1160
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54D13A0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54D1820 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54D1B10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54D1C40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54D1CB0
        public void get_Keys(){} // RVA: 0x7FFAF54D1D40
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54D1D40
        public void get_Values(){} // RVA: 0x7FFAF54D1D60
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54D1D60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54D1D80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54D1DF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54D1F30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54C1800
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54D1FE0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54D2210
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54C1B60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54D1D40
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54D2390
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54D1D60
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54D24B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54D2720
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54D29B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54D3010
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54D3790
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54D37E0
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54D38D0
        public void GetValues(){} // RVA: 0x7FFAF54D3B90
        public void OnSerializing(){} // RVA: 0x7FFAF54D3E50
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54D3F10
        public void .cctor(){} // RVA: 0x7FFAF54D41E0
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54E5A90
        public void .ctor(){} // RVA: 0x7FFAF54E6110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54E5DF0
        public void TryAdd(){} // RVA: 0x7FFAF54E64D0
        public void ContainsKey(){} // RVA: 0x7FFAF54E65D0
        public void TryRemove(){} // RVA: 0x7FFAF54E66D0
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54E6750
        public void TryGetValue(){} // RVA: 0x7FFAF54E6C00
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54E6D00
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54E6E50
        public void Clear(){} // RVA: 0x7FFAF54E7340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54E75E0
        public void ToArray(){} // RVA: 0x7FFAF54E7840
        public void CopyToPairs(){} // RVA: 0x7FFAF54E7A60
        public void CopyToEntries(){} // RVA: 0x7FFAF54E7B80
        public void CopyToObjects(){} // RVA: 0x7FFAF54E7C80
        public void GetEnumerator(){} // RVA: 0x7FFAF54BA7D0
        public void TryAddInternal(){} // RVA: 0x7FFAF54E7DE0
        public void get_Item(){} // RVA: 0x7FFAF54E8460
        public void set_Item(){} // RVA: 0x7FFAF54E85B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54E86B0
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54E88F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54E8DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54E90D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54E9200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54E9270
        public void get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54E9340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54E93B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54E9500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54BBCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54E95B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54E97D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54BC030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54E9300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54E98E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54E9320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54E9A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54E9B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54E9DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54EA340
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54EAAC0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54EAB10
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54EAC00
        public void GetValues(){} // RVA: 0x7FFAF54EAEC0
        public void OnSerializing(){} // RVA: 0x7FFAF54EB180
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54EB240
        public void .cctor(){} // RVA: 0x7FFAF54EB510
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAF54A7910
        public void .ctor(){} // RVA: 0x7FFAF54A7FE0 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAF54A7C70
        public void TryAdd(){} // RVA: 0x7FFAF54A83A0
        public void ContainsKey(){} // RVA: 0x7FFAF54A84F0
        public void TryRemove(){} // RVA: 0x7FFAF54A8530
        public void TryRemoveInternal(){} // RVA: 0x7FFAF54A8570
        public void TryGetValue(){} // RVA: 0x7FFAF54A8B30
        public void TryGetValueInternal(){} // RVA: 0x7FFAF54A8C60
        public void TryUpdateInternal(){} // RVA: 0x7FFAF54A8E40
        public void Clear(){} // RVA: 0x7FFAF54A93C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAF54A9660
        public void ToArray(){} // RVA: 0x7FFAF54A9970
        public void CopyToPairs(){} // RVA: 0x7FFAF54A9BD0
        public void CopyToEntries(){} // RVA: 0x7FFAF54A9CE0
        public void CopyToObjects(){} // RVA: 0x7FFAF54A9E10
        public void GetEnumerator(){} // RVA: 0x7FFAF54A9F80
        public void TryAddInternal(){} // RVA: 0x7FFAF54AA020
        public void get_Item(){} // RVA: 0x7FFAF54AA7A0
        public void set_Item(){} // RVA: 0x7FFAF54AA870
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAF54AA9C0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAF54AAA40
        public void get_Count(){} // RVA: 0x7FFAF54AAA90
        public void GetCountInternal(){} // RVA: 0x7FFAF54AAB40
        public void GetOrAdd(){} // RVA: 0x7FFAF54AADC0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAF54AB1B0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAF54AB410
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAF54AB540
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAF54AB6E0
        public void get_Keys(){} // RVA: 0x7FFAF54AB740
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAF54AB740
        public void get_Values(){} // RVA: 0x7FFAF54AB760
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAF54AB760
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAF54AB780
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAF54AB860
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAF54AB900
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF54AB950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAF54AB970
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAF54ABBA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAF54ABCD0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAF54AB740
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAF54ABDB0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAF54AB760
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAF54ABEF0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAF54AC010
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF54AC350
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void GrowTable(){} // RVA: 0x7FFAF54AC930
        public void GetBucket(){} // RVA: 0x7FFAF54AD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAF54AD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAF54AD0F0
        public void AcquireAllLocks(){} // RVA: 0x7FFAF54AD140
        public void AcquireLocks(){} // RVA: 0x7FFAF54AD230
        public void ReleaseLocks(){} // RVA: 0x7FFAF54AD390
        public void GetKeys(){} // RVA: 0x7FFAF54AD420
        public void GetValues(){} // RVA: 0x7FFAF54AD6F0
        public void OnSerializing(){} // RVA: 0x7FFAF54AD9B0
        public void OnSerialized(){} // RVA: 0x7FFAF54ADA70
        public void OnDeserialized(){} // RVA: 0x7FFAF54ADAD0
        public void .cctor(){} // RVA: 0x7FFAF54ADDA0
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF554F570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF554F730
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF554F830
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF554F850
        public void get_IsEmpty(){} // RVA: 0x7FFAF554F870
        public void ToArray(){} // RVA: 0x7FFAF554F940
        public void get_Count(){} // RVA: 0x7FFAF554FD90
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF5550100
        public void GetEnumerator(){} // RVA: 0x7FFAF5550530
        public void SnapForObservation(){} // RVA: 0x7FFAF55505D0
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF5550870
        public void Enumerate(){} // RVA: 0x7FFAF554E7D0
        public void Enqueue(){} // RVA: 0x7FFAF55509D0
        public void EnqueueSlow(){} // RVA: 0x7FFAF5550A50
        public void TryDequeue(){} // RVA: 0x7FFAF5550F20
        public void TryDequeueSlow(){} // RVA: 0x7FFAF5550FB0
        public void TryPeek(){} // RVA: 0x7FFAF55511E0
        public void Clear(){} // RVA: 0x7FFAF55512A0
    }

    public class ConcurrentQueue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF2ADBAA0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2ABDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF2D33FA0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF2ABDE40
        public void get_IsEmpty(){} // RVA: 0x7FFAF2ABDBE0
        public void ToArray(){} // RVA: 0x7FFAF2ABCD60
        public void get_Count(){} // RVA: 0x7FFAF2ABD840
        public void GetCount(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF2ADBAA0
        public void GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void SnapForObservation(){} // RVA: 0x7FFAF2ADF9F0
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF2D33FA0
        public void Enumerate(){} // RVA: 0x7FFAF2D33FA0
        public void Enqueue(){} // RVA: 0x7FFAF2D33FA0
        public void EnqueueSlow(){} // RVA: 0x7FFAF2D33FA0
        public void TryDequeue(){} // RVA: 0x7FFAF2ABDE40
        public void TryDequeueSlow(){} // RVA: 0x7FFAF2ABDE40
        public void TryPeek(){}
        public void Clear(){} // RVA: 0x7FFAF2AD4A50
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF554F570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF554F730
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF554F830
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF554F850
        public void get_IsEmpty(){} // RVA: 0x7FFAF554F870
        public void ToArray(){} // RVA: 0x7FFAF554F940
        public void get_Count(){} // RVA: 0x7FFAF554FD90
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF5550100
        public void GetEnumerator(){} // RVA: 0x7FFAF5550530
        public void SnapForObservation(){} // RVA: 0x7FFAF55505D0
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF5550870
        public void Enumerate(){} // RVA: 0x7FFAF554E7D0
        public void Enqueue(){} // RVA: 0x7FFAF55509D0
        public void EnqueueSlow(){} // RVA: 0x7FFAF5550A50
        public void TryDequeue(){} // RVA: 0x7FFAF5550F20
        public void TryDequeueSlow(){} // RVA: 0x7FFAF5550FB0
        public void TryPeek(){} // RVA: 0x7FFAF55511E0
        public void Clear(){} // RVA: 0x7FFAF55512A0
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF554F570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF554F730
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF554F830
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF554F850
        public void get_IsEmpty(){} // RVA: 0x7FFAF554F870
        public void ToArray(){} // RVA: 0x7FFAF554F940
        public void get_Count(){} // RVA: 0x7FFAF554FD90
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF5550100
        public void GetEnumerator(){} // RVA: 0x7FFAF5550530
        public void SnapForObservation(){} // RVA: 0x7FFAF55505D0
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF5550870
        public void Enumerate(){} // RVA: 0x7FFAF554E7D0
        public void Enqueue(){} // RVA: 0x7FFAF55509D0
        public void EnqueueSlow(){} // RVA: 0x7FFAF5550A50
        public void TryDequeue(){} // RVA: 0x7FFAF5550F20
        public void TryDequeueSlow(){} // RVA: 0x7FFAF5550FB0
        public void TryPeek(){} // RVA: 0x7FFAF55511E0
        public void Clear(){} // RVA: 0x7FFAF55512A0
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF555A560
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF555A720
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF555A820
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF555A8C0
        public void get_IsEmpty(){} // RVA: 0x7FFAF555A8E0
        public void ToArray(){} // RVA: 0x7FFAF555A9B0
        public void get_Count(){} // RVA: 0x7FFAF555AE20
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF555B190
        public void GetEnumerator(){} // RVA: 0x7FFAF555B6B0
        public void SnapForObservation(){} // RVA: 0x7FFAF555B750
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF555B9F0
        public void Enumerate(){} // RVA: 0x7FFAF554C6F0
        public void Enqueue(){} // RVA: 0x7FFAF555BB50
        public void EnqueueSlow(){} // RVA: 0x7FFAF555BBE0
        public void TryDequeue(){} // RVA: 0x7FFAF555C0C0
        public void TryDequeueSlow(){} // RVA: 0x7FFAF555C150
        public void TryPeek(){} // RVA: 0x7FFAF555C380
        public void Clear(){} // RVA: 0x7FFAF555C450
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF554F570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF554F730
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF554F830
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF554F850
        public void get_IsEmpty(){} // RVA: 0x7FFAF554F870
        public void ToArray(){} // RVA: 0x7FFAF554F940
        public void get_Count(){} // RVA: 0x7FFAF554FD90
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF5550100
        public void GetEnumerator(){} // RVA: 0x7FFAF5550530
        public void SnapForObservation(){} // RVA: 0x7FFAF55505D0
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF5550870
        public void Enumerate(){} // RVA: 0x7FFAF554E7D0
        public void Enqueue(){} // RVA: 0x7FFAF55509D0
        public void EnqueueSlow(){} // RVA: 0x7FFAF5550A50
        public void TryDequeue(){} // RVA: 0x7FFAF5550F20
        public void TryDequeueSlow(){} // RVA: 0x7FFAF5550FB0
        public void TryPeek(){} // RVA: 0x7FFAF55511E0
        public void Clear(){} // RVA: 0x7FFAF55512A0
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF554F570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF554F730
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF554F830
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF554F850
        public void get_IsEmpty(){} // RVA: 0x7FFAF554F870
        public void ToArray(){} // RVA: 0x7FFAF554F940
        public void get_Count(){} // RVA: 0x7FFAF554FD90
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF5550100
        public void GetEnumerator(){} // RVA: 0x7FFAF5550530
        public void SnapForObservation(){} // RVA: 0x7FFAF55505D0
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF5550870
        public void Enumerate(){} // RVA: 0x7FFAF554E7D0
        public void Enqueue(){} // RVA: 0x7FFAF55509D0
        public void EnqueueSlow(){} // RVA: 0x7FFAF5550A50
        public void TryDequeue(){} // RVA: 0x7FFAF5550F20
        public void TryDequeueSlow(){} // RVA: 0x7FFAF5550FB0
        public void TryPeek(){} // RVA: 0x7FFAF55511E0
        public void Clear(){} // RVA: 0x7FFAF55512A0
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF554F570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF554F730
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF554F830
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF554F850
        public void get_IsEmpty(){} // RVA: 0x7FFAF554F870
        public void ToArray(){} // RVA: 0x7FFAF554F940
        public void get_Count(){} // RVA: 0x7FFAF554FD90
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF5550100
        public void GetEnumerator(){} // RVA: 0x7FFAF5550530
        public void SnapForObservation(){} // RVA: 0x7FFAF55505D0
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF5550870
        public void Enumerate(){} // RVA: 0x7FFAF554E7D0
        public void Enqueue(){} // RVA: 0x7FFAF55509D0
        public void EnqueueSlow(){} // RVA: 0x7FFAF5550A50
        public void TryDequeue(){} // RVA: 0x7FFAF5550F20
        public void TryDequeueSlow(){} // RVA: 0x7FFAF5550FB0
        public void TryPeek(){} // RVA: 0x7FFAF55511E0
        public void Clear(){} // RVA: 0x7FFAF55512A0
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF554F570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF554F730
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF554F830
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF554F850
        public void get_IsEmpty(){} // RVA: 0x7FFAF554F870
        public void ToArray(){} // RVA: 0x7FFAF554F940
        public void get_Count(){} // RVA: 0x7FFAF554FD90
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF5550100
        public void GetEnumerator(){} // RVA: 0x7FFAF5550530
        public void SnapForObservation(){} // RVA: 0x7FFAF55505D0
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF5550870
        public void Enumerate(){} // RVA: 0x7FFAF554E7D0
        public void Enqueue(){} // RVA: 0x7FFAF55509D0
        public void EnqueueSlow(){} // RVA: 0x7FFAF5550A50
        public void TryDequeue(){} // RVA: 0x7FFAF5550F20
        public void TryDequeueSlow(){} // RVA: 0x7FFAF5550FB0
        public void TryPeek(){} // RVA: 0x7FFAF55511E0
        public void Clear(){} // RVA: 0x7FFAF55512A0
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF554F570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF554F730
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF554F830
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF554F850
        public void get_IsEmpty(){} // RVA: 0x7FFAF554F870
        public void ToArray(){} // RVA: 0x7FFAF554F940
        public void get_Count(){} // RVA: 0x7FFAF554FD90
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF5550100
        public void GetEnumerator(){} // RVA: 0x7FFAF5550530
        public void SnapForObservation(){} // RVA: 0x7FFAF55505D0
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF5550870
        public void Enumerate(){} // RVA: 0x7FFAF554E7D0
        public void Enqueue(){} // RVA: 0x7FFAF55509D0
        public void EnqueueSlow(){} // RVA: 0x7FFAF5550A50
        public void TryDequeue(){} // RVA: 0x7FFAF5550F20
        public void TryDequeueSlow(){} // RVA: 0x7FFAF5550FB0
        public void TryPeek(){} // RVA: 0x7FFAF55511E0
        public void Clear(){} // RVA: 0x7FFAF55512A0
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF554F570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF554F730
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF554F830
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF554F850
        public void get_IsEmpty(){} // RVA: 0x7FFAF554F870
        public void ToArray(){} // RVA: 0x7FFAF554F940
        public void get_Count(){} // RVA: 0x7FFAF554FD90
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF5550100
        public void GetEnumerator(){} // RVA: 0x7FFAF5550530
        public void SnapForObservation(){} // RVA: 0x7FFAF55505D0
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF5550870
        public void Enumerate(){} // RVA: 0x7FFAF554E7D0
        public void Enqueue(){} // RVA: 0x7FFAF55509D0
        public void EnqueueSlow(){} // RVA: 0x7FFAF5550A50
        public void TryDequeue(){} // RVA: 0x7FFAF5550F20
        public void TryDequeueSlow(){} // RVA: 0x7FFAF5550FB0
        public void TryPeek(){} // RVA: 0x7FFAF55511E0
        public void Clear(){} // RVA: 0x7FFAF55512A0
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF554F570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF554F730
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF554F830
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF554F850
        public void get_IsEmpty(){} // RVA: 0x7FFAF554F870
        public void ToArray(){} // RVA: 0x7FFAF554F940
        public void get_Count(){} // RVA: 0x7FFAF554FD90
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF5550100
        public void GetEnumerator(){} // RVA: 0x7FFAF5550530
        public void SnapForObservation(){} // RVA: 0x7FFAF55505D0
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF5550870
        public void Enumerate(){} // RVA: 0x7FFAF554E7D0
        public void Enqueue(){} // RVA: 0x7FFAF55509D0
        public void EnqueueSlow(){} // RVA: 0x7FFAF5550A50
        public void TryDequeue(){} // RVA: 0x7FFAF5550F20
        public void TryDequeueSlow(){} // RVA: 0x7FFAF5550FB0
        public void TryPeek(){} // RVA: 0x7FFAF55511E0
        public void Clear(){} // RVA: 0x7FFAF55512A0
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF554F570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF554F730
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF554F830
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF554F850
        public void get_IsEmpty(){} // RVA: 0x7FFAF554F870
        public void ToArray(){} // RVA: 0x7FFAF554F940
        public void get_Count(){} // RVA: 0x7FFAF554FD90
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF5550100
        public void GetEnumerator(){} // RVA: 0x7FFAF5550530
        public void SnapForObservation(){} // RVA: 0x7FFAF55505D0
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF5550870
        public void Enumerate(){} // RVA: 0x7FFAF554E7D0
        public void Enqueue(){} // RVA: 0x7FFAF55509D0
        public void EnqueueSlow(){} // RVA: 0x7FFAF5550A50
        public void TryDequeue(){} // RVA: 0x7FFAF5550F20
        public void TryDequeueSlow(){} // RVA: 0x7FFAF5550FB0
        public void TryPeek(){} // RVA: 0x7FFAF55511E0
        public void Clear(){} // RVA: 0x7FFAF55512A0
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF554F570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF554F730
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF554F830
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF554F850
        public void get_IsEmpty(){} // RVA: 0x7FFAF554F870
        public void ToArray(){} // RVA: 0x7FFAF554F940
        public void get_Count(){} // RVA: 0x7FFAF554FD90
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF5550100
        public void GetEnumerator(){} // RVA: 0x7FFAF5550530
        public void SnapForObservation(){} // RVA: 0x7FFAF55505D0
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF5550870
        public void Enumerate(){} // RVA: 0x7FFAF554E7D0
        public void Enqueue(){} // RVA: 0x7FFAF55509D0
        public void EnqueueSlow(){} // RVA: 0x7FFAF5550A50
        public void TryDequeue(){} // RVA: 0x7FFAF5550F20
        public void TryDequeueSlow(){} // RVA: 0x7FFAF5550FB0
        public void TryPeek(){} // RVA: 0x7FFAF55511E0
        public void Clear(){} // RVA: 0x7FFAF55512A0
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF554F570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF554F730
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF554F830
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF554F850
        public void get_IsEmpty(){} // RVA: 0x7FFAF554F870
        public void ToArray(){} // RVA: 0x7FFAF554F940
        public void get_Count(){} // RVA: 0x7FFAF554FD90
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF5550100
        public void GetEnumerator(){} // RVA: 0x7FFAF5550530
        public void SnapForObservation(){} // RVA: 0x7FFAF55505D0
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF5550870
        public void Enumerate(){} // RVA: 0x7FFAF554E7D0
        public void Enqueue(){} // RVA: 0x7FFAF55509D0
        public void EnqueueSlow(){} // RVA: 0x7FFAF5550A50
        public void TryDequeue(){} // RVA: 0x7FFAF5550F20
        public void TryDequeueSlow(){} // RVA: 0x7FFAF5550FB0
        public void TryPeek(){} // RVA: 0x7FFAF55511E0
        public void Clear(){} // RVA: 0x7FFAF55512A0
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF554F570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF554F730
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF554F830
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF554F850
        public void get_IsEmpty(){} // RVA: 0x7FFAF554F870
        public void ToArray(){} // RVA: 0x7FFAF554F940
        public void get_Count(){} // RVA: 0x7FFAF554FD90
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF5550100
        public void GetEnumerator(){} // RVA: 0x7FFAF5550530
        public void SnapForObservation(){} // RVA: 0x7FFAF55505D0
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF5550870
        public void Enumerate(){} // RVA: 0x7FFAF554E7D0
        public void Enqueue(){} // RVA: 0x7FFAF55509D0
        public void EnqueueSlow(){} // RVA: 0x7FFAF5550A50
        public void TryDequeue(){} // RVA: 0x7FFAF5550F20
        public void TryDequeueSlow(){} // RVA: 0x7FFAF5550FB0
        public void TryPeek(){} // RVA: 0x7FFAF55511E0
        public void Clear(){} // RVA: 0x7FFAF55512A0
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF555C6A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF555C860
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF555C960
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF555C980
        public void get_IsEmpty(){} // RVA: 0x7FFAF555C9A0
        public void ToArray(){} // RVA: 0x7FFAF555CA70
        public void get_Count(){} // RVA: 0x7FFAF555CEC0
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF555D230
        public void GetEnumerator(){} // RVA: 0x7FFAF555D660
        public void SnapForObservation(){} // RVA: 0x7FFAF555D700
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF555D9A0
        public void Enumerate(){} // RVA: 0x7FFAF554E7D0
        public void Enqueue(){} // RVA: 0x7FFAF555DB00
        public void EnqueueSlow(){} // RVA: 0x7FFAF555DB80
        public void TryDequeue(){} // RVA: 0x7FFAF555E060
        public void TryDequeueSlow(){} // RVA: 0x7FFAF555E0F0
        public void TryPeek(){} // RVA: 0x7FFAF555E320
        public void Clear(){} // RVA: 0x7FFAF555E3E0
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF55581C0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF5558380
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF5558480
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF55584F0
        public void get_IsEmpty(){} // RVA: 0x7FFAF5558510
        public void ToArray(){} // RVA: 0x7FFAF55585F0
        public void get_Count(){} // RVA: 0x7FFAF5558AA0
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF5558E10
        public void GetEnumerator(){} // RVA: 0x7FFAF55592A0
        public void SnapForObservation(){} // RVA: 0x7FFAF5559340
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF55595E0
        public void Enumerate(){} // RVA: 0x7FFAF5559780
        public void Enqueue(){} // RVA: 0x7FFAF5559910
        public void EnqueueSlow(){} // RVA: 0x7FFAF5559A20
        public void TryDequeue(){} // RVA: 0x7FFAF5559F50
        public void TryDequeueSlow(){} // RVA: 0x7FFAF5559FE0
        public void TryPeek(){} // RVA: 0x7FFAF555A220
        public void Clear(){} // RVA: 0x7FFAF555A310
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF554F570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF554F730
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF554F830
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF554F850
        public void get_IsEmpty(){} // RVA: 0x7FFAF554F870
        public void ToArray(){} // RVA: 0x7FFAF554F940
        public void get_Count(){} // RVA: 0x7FFAF554FD90
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF5550100
        public void GetEnumerator(){} // RVA: 0x7FFAF5550530
        public void SnapForObservation(){} // RVA: 0x7FFAF55505D0
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF5550870
        public void Enumerate(){} // RVA: 0x7FFAF554E7D0
        public void Enqueue(){} // RVA: 0x7FFAF55509D0
        public void EnqueueSlow(){} // RVA: 0x7FFAF5550A50
        public void TryDequeue(){} // RVA: 0x7FFAF5550F20
        public void TryDequeueSlow(){} // RVA: 0x7FFAF5550FB0
        public void TryPeek(){} // RVA: 0x7FFAF55511E0
        public void Clear(){} // RVA: 0x7FFAF55512A0
    }

    public class ConcurrentQueue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF554AEA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF554B060
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF554B1B0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF554B250
        public void get_IsEmpty(){} // RVA: 0x7FFAF554B2F0
        public void ToArray(){} // RVA: 0x7FFAF554B3C0
        public void get_Count(){} // RVA: 0x7FFAF554B830
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF554BD90
        public void GetEnumerator(){} // RVA: 0x7FFAF554C250
        public void SnapForObservation(){} // RVA: 0x7FFAF554C2F0
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF554C590
        public void Enumerate(){} // RVA: 0x7FFAF554C6F0
        public void Enqueue(){} // RVA: 0x7FFAF554C870
        public void EnqueueSlow(){} // RVA: 0x7FFAF554C900
        public void TryDequeue(){} // RVA: 0x7FFAF554CDE0
        public void TryDequeueSlow(){} // RVA: 0x7FFAF554CE70
        public void TryPeek(){} // RVA: 0x7FFAF554D0A0
        public void Clear(){} // RVA: 0x7FFAF554D170
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF554F570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF554F730
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF554F830
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF554F850
        public void get_IsEmpty(){} // RVA: 0x7FFAF554F870
        public void ToArray(){} // RVA: 0x7FFAF554F940
        public void get_Count(){} // RVA: 0x7FFAF554FD90
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF5550100
        public void GetEnumerator(){} // RVA: 0x7FFAF5550530
        public void SnapForObservation(){} // RVA: 0x7FFAF55505D0
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF5550870
        public void Enumerate(){} // RVA: 0x7FFAF554E7D0
        public void Enqueue(){} // RVA: 0x7FFAF55509D0
        public void EnqueueSlow(){} // RVA: 0x7FFAF5550A50
        public void TryDequeue(){} // RVA: 0x7FFAF5550F20
        public void TryDequeueSlow(){} // RVA: 0x7FFAF5550FB0
        public void TryPeek(){} // RVA: 0x7FFAF55511E0
        public void Clear(){} // RVA: 0x7FFAF55512A0
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF554F570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF554F730
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF554F830
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF554F850
        public void get_IsEmpty(){} // RVA: 0x7FFAF554F870
        public void ToArray(){} // RVA: 0x7FFAF554F940
        public void get_Count(){} // RVA: 0x7FFAF554FD90
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF5550100
        public void GetEnumerator(){} // RVA: 0x7FFAF5550530
        public void SnapForObservation(){} // RVA: 0x7FFAF55505D0
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF5550870
        public void Enumerate(){} // RVA: 0x7FFAF554E7D0
        public void Enqueue(){} // RVA: 0x7FFAF55509D0
        public void EnqueueSlow(){} // RVA: 0x7FFAF5550A50
        public void TryDequeue(){} // RVA: 0x7FFAF5550F20
        public void TryDequeueSlow(){} // RVA: 0x7FFAF5550FB0
        public void TryPeek(){} // RVA: 0x7FFAF55511E0
        public void Clear(){} // RVA: 0x7FFAF55512A0
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF554F570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF554F730
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF554F830
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF554F850
        public void get_IsEmpty(){} // RVA: 0x7FFAF554F870
        public void ToArray(){} // RVA: 0x7FFAF554F940
        public void get_Count(){} // RVA: 0x7FFAF554FD90
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF5550100
        public void GetEnumerator(){} // RVA: 0x7FFAF5550530
        public void SnapForObservation(){} // RVA: 0x7FFAF55505D0
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF5550870
        public void Enumerate(){} // RVA: 0x7FFAF554E7D0
        public void Enqueue(){} // RVA: 0x7FFAF55509D0
        public void EnqueueSlow(){} // RVA: 0x7FFAF5550A50
        public void TryDequeue(){} // RVA: 0x7FFAF5550F20
        public void TryDequeueSlow(){} // RVA: 0x7FFAF5550FB0
        public void TryPeek(){} // RVA: 0x7FFAF55511E0
        public void Clear(){} // RVA: 0x7FFAF55512A0
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF554F570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF554F730
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF554B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF554F830
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF554F850
        public void get_IsEmpty(){} // RVA: 0x7FFAF554F870
        public void ToArray(){} // RVA: 0x7FFAF554F940
        public void get_Count(){} // RVA: 0x7FFAF554FD90
        public void GetCount(){} // RVA: 0x7FFAF554BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAF5550100
        public void GetEnumerator(){} // RVA: 0x7FFAF5550530
        public void SnapForObservation(){} // RVA: 0x7FFAF55505D0
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAF5550870
        public void Enumerate(){} // RVA: 0x7FFAF554E7D0
        public void Enqueue(){} // RVA: 0x7FFAF55509D0
        public void EnqueueSlow(){} // RVA: 0x7FFAF5550A50
        public void TryDequeue(){} // RVA: 0x7FFAF5550F20
        public void TryDequeueSlow(){} // RVA: 0x7FFAF5550FB0
        public void TryPeek(){} // RVA: 0x7FFAF55511E0
        public void Clear(){} // RVA: 0x7FFAF55512A0
    }

    public class ConcurrentStack`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
        public void get_Count(){} // RVA: 0x7FFAF2ABD840
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2ABDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF2ADBAA0
        public void Push(){} // RVA: 0x7FFAF2D33FA0
        public void PushCore(){} // RVA: 0x7FFAF2ADDC60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF2D33FA0
        public void TryPop(){} // RVA: 0x7FFAF2ABDE40
        public void TryPopCore(){} // RVA: 0x7FFAF2ABDE40 | overloaded x2
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF2ABDE40
        public void ToArray(){} // RVA: 0x7FFAF2ABCD60
        public void ToList(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
    }

    public class ConcurrentStack`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_Count(){} // RVA: 0x7FFAF555FA10
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAF54A4BF0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAF555FA30
        public void Push(){} // RVA: 0x7FFAF555FB10
        public void PushCore(){} // RVA: 0x7FFAF555FCF0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAF555FED0
        public void TryPop(){} // RVA: 0x7FFAF555FEF0
        public void TryPopCore(){} // RVA: 0x7FFAF5560120 | overloaded x2
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAF5560520
        public void ToArray(){} // RVA: 0x7FFAF5560540
        public void ToList(){} // RVA: 0x7FFAF55605E0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFAF5560780 | overloaded x2
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF5560820
    }

}