// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Concurrent
// Classes: 75
// Methods: 2567

namespace ThirdParty.DotNet.System.Collections.Concurrent
{
    public class BlockingCollection`1 : Object
    {
        public object NON_BOUNDED; // 0x30DCFD70
        public object _isDisposed; // 0x30DCFD70
        public object _currentAdders; // 0x30DCFD70

        // ── Original Methods ──
        public void get_IsAddingCompleted(){} // RVA: 0x7ffaa864a040
        public void get_IsCompleted(){} // RVA: 0x7ffaa864a040
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa864a040
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaa86491d0
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void Initialize(){}
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void TryAddWithNoTimeValidation(){} // RVA: 0x7ffaa887e5c0
        public void TryTake(){} // RVA: 0x7ffaa887e5c0
        public void TryTakeWithNoTimeValidation(){} // RVA: 0x7ffaa887e5c0
        public void CancelWaitingConsumers(){} // RVA: 0x7ffaa8660cc0
        public void Dispose(){} // RVA: 0x7ffaa86613a0
        public void Dispose(){} // RVA: 0x7ffaa86613a0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaa8667cb0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void ValidateMillisecondsTimeout(){} // RVA: 0x7ffaa8662110
        // ── Binary Analysis Named ──
        public void CheckDisposed(){} // RVA: 0x7ffaa8660cc0
    }

    public class CDSCollectionETWBCLProvider : EventSource
    {
        public object p00; // 0x31A7C1B0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadfc7050
        public void ConcurrentStack_FastPushFailed(){} // RVA: 0x7ffaa94a7020
        public void ConcurrentStack_FastPopFailed(){} // RVA: 0x7ffaa94a7020
        public void ConcurrentDictionary_AcquiringAllLocks(){} // RVA: 0x7ffaa94a7020
        public void .cctor(){} // RVA: 0x7ffaadfc7060
    }

    public class ConcurrentBag`1 : Object
    {
        public object _emptyToNonEmptyListTransitionCount; // 0x30E1C8C0
        public object Count; // 0x17000369

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7ffaa887e5c0
        public void TryTake(){} // RVA: 0x7ffaa864a2a0
        public void CreateWorkStealingQueueForCurrentThread(){} // RVA: 0x7ffaa86491d0
        public void TrySteal(){}
        public void TryStealFromTo(){} // RVA: 0x7ffaa887e5c0
        public void CopyTo(){} // RVA: 0x7ffaa8667cb0
        public void CopyFromEachQueueToArray(){}
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaa8667cb0
        public void ToArray(){} // RVA: 0x7ffaa86491d0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        public void get_DangerousCount(){} // RVA: 0x7ffaa8649ca0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa864a040
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaa86491d0
        public void get_GlobalQueuesLock(){} // RVA: 0x7ffaa86491d0
        public void FreezeBag(){} // RVA: 0x7ffaa8660d80
        public void UnfreezeBag(){} // RVA: 0x7ffaa86613a0
        // ── Binary Analysis Named ──
        public void GetCurrentThreadWorkStealingQueue(){}
        public void GetUnownedWorkStealingQueue(){} // RVA: 0x7ffaa86491d0
        public void GetEnumerator(){} // RVA: 0x7ffaa86491d0
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x300AAD18
        public object _serializationConcurrencyLevel; // 0x300AAD18
        public object MaxLockNumber; // 0x300AAD18
        public object `; // 0x81DB9A68

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaadf0680
        public void .ctor(){} // RVA: 0x7ffaaadf0d50
        public void .ctor(){} // RVA: 0x7ffaaadf0d50
        public void .ctor(){} // RVA: 0x7ffaaadf0d50
        public void InitializeFromCollection(){} // RVA: 0x7ffaaadf09e0
        public void .ctor(){} // RVA: 0x7ffaaadf0d50
        public void .ctor(){} // RVA: 0x7ffaaadf0d50
        public void TryAdd(){} // RVA: 0x7ffaaadf1110
        public void ContainsKey(){} // RVA: 0x7ffaaadf1260
        public void TryRemove(){} // RVA: 0x7ffaaadf12a0
        public void TryRemoveInternal(){} // RVA: 0x7ffaaadf12e0
        public void TryGetValue(){} // RVA: 0x7ffaaadf18a0
        public void TryGetValueInternal(){} // RVA: 0x7ffaaadf19d0
        public void TryUpdateInternal(){} // RVA: 0x7ffaaadf1bb0
        public void Clear(){} // RVA: 0x7ffaaadf2130
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaadf23d0
        public void ToArray(){} // RVA: 0x7ffaaadf26e0
        public void CopyToPairs(){} // RVA: 0x7ffaaadf2940
        public void CopyToEntries(){} // RVA: 0x7ffaaadf2a50
        public void CopyToObjects(){} // RVA: 0x7ffaaadf2b80
        public void TryAddInternal(){} // RVA: 0x7ffaaadf2d90
        public void get_Item(){} // RVA: 0x7ffaaadf3510
        public void set_Item(){} // RVA: 0x7ffaaadf35e0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaadf3800
        public void AddOrUpdate(){} // RVA: 0x7ffaaadf3f20
        public void AddOrUpdate(){} // RVA: 0x7ffaaadf3f20
        public void get_IsEmpty(){} // RVA: 0x7ffaaadf4180
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaadf42b0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaadf4450
        public void get_Keys(){} // RVA: 0x7ffaaadf44b0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaadf44b0
        public void get_Values(){} // RVA: 0x7ffaaadf44d0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaadf44d0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaadf44f0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaadf45d0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaadf4670
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaadf46c0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaadf46e0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaadf4910
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaadf4a40
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaadf44b0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaadf4b20
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaadf44d0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaadf4c60
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaadf4d80
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaadf50c0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaadf56a0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaadf5e60
        public void AcquireAllLocks(){} // RVA: 0x7ffaaadf5eb0
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaadf6720
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaadf6840
        public void .cctor(){} // RVA: 0x7ffaaadf6b10
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaadf2cf0
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaadf3b30
        public void GetOrAdd(){} // RVA: 0x7ffaaadf3b30
        public void GetOrAdd(){} // RVA: 0x7ffaaadf3b30
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaadf6190
        public void GetValues(){} // RVA: 0x7ffaaadf6460
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x30C78960
        public object _serializationConcurrencyLevel; // 0x30C78960
        public object MaxLockNumber; // 0x30C78960

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaa864a070
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void InitializeFromCollection(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void TryAdd(){} // RVA: 0x7ffaa887e5c0
        public void ContainsKey(){} // RVA: 0x7ffaa887e5c0
        public void TryRemove(){} // RVA: 0x7ffaa887e5c0
        public void TryRemoveInternal(){} // RVA: 0x7ffaa887e5c0
        public void TryGetValue(){} // RVA: 0x7ffaa887e5c0
        public void TryGetValueInternal(){} // RVA: 0x7ffaa887e5c0
        public void TryUpdateInternal(){} // RVA: 0x7ffaa887e5c0
        public void Clear(){} // RVA: 0x7ffaa8660cc0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaa8667cb0
        public void ToArray(){} // RVA: 0x7ffaa86491d0
        public void CopyToPairs(){} // RVA: 0x7ffaa8667cb0
        public void CopyToEntries(){} // RVA: 0x7ffaa8667cb0
        public void CopyToObjects(){} // RVA: 0x7ffaa8667cb0
        public void TryAddInternal(){} // RVA: 0x7ffaa887e5c0
        public void get_Item(){} // RVA: 0x7ffaa887e5c0
        public void set_Item(){} // RVA: 0x7ffaa887e5c0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaa8660d50
        public void ThrowKeyNullException(){} // RVA: 0x7ffaa8660cf0
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        public void AddOrUpdate(){} // RVA: 0x7ffaa887e5c0
        public void AddOrUpdate(){} // RVA: 0x7ffaa887e5c0
        public void get_IsEmpty(){} // RVA: 0x7ffaa864a040
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaa887e5c0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaa887e5c0
        public void get_Keys(){} // RVA: 0x7ffaa86491d0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaa86491d0
        public void get_Values(){} // RVA: 0x7ffaa86491d0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaa86491d0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaa887e5c0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaa887e5c0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa864a040
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaa887e5c0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaa8669e70
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaa864a2a0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa864a040
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa864a040
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaa86491d0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaa8660d80
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaa86491d0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaa8649280
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaa8669e70
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaa8667cb0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa864a040
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaa86491d0
        public void GrowTable(){} // RVA: 0x7ffaa8660d80
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaa8649cd0
        public void AcquireAllLocks(){} // RVA: 0x7ffaa8660d80
        public void AcquireLocks(){}
        public void ReleaseLocks(){} // RVA: 0x7ffaa86631a0
        public void OnSerializing(){} // RVA: 0x7ffaa8660d80
        public void OnSerialized(){} // RVA: 0x7ffaa8660d80
        public void OnDeserialized(){} // RVA: 0x7ffaa8660d80
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void GetCountInternal(){} // RVA: 0x7ffaa8649ca0
        public void GetOrAdd(){} // RVA: 0x7ffaa887e5c0
        public void GetOrAdd(){} // RVA: 0x7ffaa887e5c0
        public void GetOrAdd(){} // RVA: 0x7ffaa887e5c0
        public void GetBucket(){} // RVA: 0x7ffaa8650100
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaa887e5c0
        public void GetKeys(){} // RVA: 0x7ffaa86491d0
        public void GetValues(){} // RVA: 0x7ffaa86491d0
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x34F811F0
        public object _serializationConcurrencyLevel; // 0x34F811F0
        public object MaxLockNumber; // 0x34F811F0

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae2e800
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae2eb60
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void TryAdd(){} // RVA: 0x7ffaaae2f240
        public void ContainsKey(){} // RVA: 0x7ffaaae2f340
        public void TryRemove(){} // RVA: 0x7ffaaae2f440
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae2f4c0
        public void TryGetValue(){} // RVA: 0x7ffaaae2f970
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae2fa70
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae2fbc0
        public void Clear(){} // RVA: 0x7ffaaae300b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae30350
        public void ToArray(){} // RVA: 0x7ffaaae305b0
        public void CopyToPairs(){} // RVA: 0x7ffaaae307d0
        public void CopyToEntries(){} // RVA: 0x7ffaaae308f0
        public void CopyToObjects(){} // RVA: 0x7ffaaae309f0
        public void TryAddInternal(){} // RVA: 0x7ffaaae30b50
        public void get_Item(){} // RVA: 0x7ffaaae311d0
        public void set_Item(){} // RVA: 0x7ffaaae31320
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae31420
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void get_IsEmpty(){} // RVA: 0x7ffaaae31e40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae31f70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae31fe0
        public void get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae32070
        public void get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae320b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae32120
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae32270
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae04a40
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae32320
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae32540
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae04da0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae32650
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae32780
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae32900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae32b20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae330b0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae33830
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae33880
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae33ef0
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae33fb0
        public void .cctor(){} // RVA: 0x7ffaaae34280
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae03540
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae33970
        public void GetValues(){} // RVA: 0x7ffaaae33c30
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x3500E720
        public object _serializationConcurrencyLevel; // 0x3500E720
        public object MaxLockNumber; // 0x3500E720

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae41450
        public void .ctor(){} // RVA: 0x7ffaaae41b20
        public void .ctor(){} // RVA: 0x7ffaaae41b20
        public void .ctor(){} // RVA: 0x7ffaaae41b20
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae417b0
        public void .ctor(){} // RVA: 0x7ffaaae41b20
        public void .ctor(){} // RVA: 0x7ffaaae41b20
        public void TryAdd(){} // RVA: 0x7ffaaae41ee0
        public void ContainsKey(){} // RVA: 0x7ffaaadf1260
        public void TryRemove(){} // RVA: 0x7ffaaadf12a0
        public void TryRemoveInternal(){} // RVA: 0x7ffaaadf12e0
        public void TryGetValue(){} // RVA: 0x7ffaaadf18a0
        public void TryGetValueInternal(){} // RVA: 0x7ffaaadf19d0
        public void TryUpdateInternal(){} // RVA: 0x7ffaaadf1bb0
        public void Clear(){} // RVA: 0x7ffaaae42030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae422d0
        public void ToArray(){} // RVA: 0x7ffaaae425f0
        public void CopyToPairs(){} // RVA: 0x7ffaaae42960
        public void CopyToEntries(){} // RVA: 0x7ffaaadf2a50
        public void CopyToObjects(){} // RVA: 0x7ffaaadf2b80
        public void TryAddInternal(){} // RVA: 0x7ffaaae42a70
        public void get_Item(){} // RVA: 0x7ffaaadf3510
        public void set_Item(){} // RVA: 0x7ffaaae43180
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae432d0
        public void AddOrUpdate(){} // RVA: 0x7ffaaae43960
        public void AddOrUpdate(){} // RVA: 0x7ffaaae43960
        public void get_IsEmpty(){} // RVA: 0x7ffaaae43bc0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae43cf0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaadf4450
        public void get_Keys(){} // RVA: 0x7ffaaae43e90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae43e90
        public void get_Values(){} // RVA: 0x7ffaaae43eb0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae43eb0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaadf44f0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaadf45d0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaadf4670
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaadf46c0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaadf46e0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaadf4910
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaadf4a40
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae43e90
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaadf4b20
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae43eb0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaadf4c60
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae43ed0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae440f0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae446d0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae44e60
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae44eb0
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae45530
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae455f0
        public void .cctor(){} // RVA: 0x7ffaaae458c0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaadf2cf0
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae43570
        public void GetOrAdd(){} // RVA: 0x7ffaaae43570
        public void GetOrAdd(){} // RVA: 0x7ffaaae43570
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae44fa0
        public void GetValues(){} // RVA: 0x7ffaaae45270
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x35029C78
        public object _serializationConcurrencyLevel; // 0x35029C78
        public object MaxLockNumber; // 0x35029C78

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae41450
        public void .ctor(){} // RVA: 0x7ffaaae41b20
        public void .ctor(){} // RVA: 0x7ffaaae41b20
        public void .ctor(){} // RVA: 0x7ffaaae41b20
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae417b0
        public void .ctor(){} // RVA: 0x7ffaaae41b20
        public void .ctor(){} // RVA: 0x7ffaaae41b20
        public void TryAdd(){} // RVA: 0x7ffaaae41ee0
        public void ContainsKey(){} // RVA: 0x7ffaaadf1260
        public void TryRemove(){} // RVA: 0x7ffaaadf12a0
        public void TryRemoveInternal(){} // RVA: 0x7ffaaadf12e0
        public void TryGetValue(){} // RVA: 0x7ffaaadf18a0
        public void TryGetValueInternal(){} // RVA: 0x7ffaaadf19d0
        public void TryUpdateInternal(){} // RVA: 0x7ffaaadf1bb0
        public void Clear(){} // RVA: 0x7ffaaae42030
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae422d0
        public void ToArray(){} // RVA: 0x7ffaaae425f0
        public void CopyToPairs(){} // RVA: 0x7ffaaae42960
        public void CopyToEntries(){} // RVA: 0x7ffaaadf2a50
        public void CopyToObjects(){} // RVA: 0x7ffaaadf2b80
        public void TryAddInternal(){} // RVA: 0x7ffaaae42a70
        public void get_Item(){} // RVA: 0x7ffaaadf3510
        public void set_Item(){} // RVA: 0x7ffaaae43180
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae432d0
        public void AddOrUpdate(){} // RVA: 0x7ffaaae43960
        public void AddOrUpdate(){} // RVA: 0x7ffaaae43960
        public void get_IsEmpty(){} // RVA: 0x7ffaaae43bc0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae43cf0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaadf4450
        public void get_Keys(){} // RVA: 0x7ffaaae43e90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae43e90
        public void get_Values(){} // RVA: 0x7ffaaae43eb0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae43eb0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaadf44f0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaadf45d0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaadf4670
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaadf46c0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaadf46e0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaadf4910
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaadf4a40
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae43e90
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaadf4b20
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae43eb0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaadf4c60
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae43ed0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae440f0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae446d0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae44e60
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae44eb0
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae45530
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae455f0
        public void .cctor(){} // RVA: 0x7ffaaae458c0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaadf2cf0
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae43570
        public void GetOrAdd(){} // RVA: 0x7ffaaae43570
        public void GetOrAdd(){} // RVA: 0x7ffaaae43570
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae44fa0
        public void GetValues(){} // RVA: 0x7ffaaae45270
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x3502A0A8
        public object _serializationConcurrencyLevel; // 0x3502A0A8
        public object MaxLockNumber; // 0x3502A0A8

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae34490
        public void .ctor(){} // RVA: 0x7ffaaae34b80
        public void .ctor(){} // RVA: 0x7ffaaae34b80
        public void .ctor(){} // RVA: 0x7ffaaae34b80
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae347f0
        public void .ctor(){} // RVA: 0x7ffaaae34b80
        public void .ctor(){} // RVA: 0x7ffaaae34b80
        public void TryAdd(){} // RVA: 0x7ffaaae34f40
        public void ContainsKey(){} // RVA: 0x7ffaaae350b0
        public void TryRemove(){} // RVA: 0x7ffaaae35100
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae35150
        public void TryGetValue(){} // RVA: 0x7ffaaae356a0
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae357e0
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae35970
        public void Clear(){} // RVA: 0x7ffaaae35ee0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae36180
        public void ToArray(){} // RVA: 0x7ffaaae363c0
        public void CopyToPairs(){} // RVA: 0x7ffaaae36620
        public void CopyToEntries(){} // RVA: 0x7ffaaae36740
        public void CopyToObjects(){} // RVA: 0x7ffaaae36880
        public void TryAddInternal(){} // RVA: 0x7ffaaae36aa0
        public void get_Item(){} // RVA: 0x7ffaaae371a0
        public void set_Item(){} // RVA: 0x7ffaaae37280
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae373f0
        public void AddOrUpdate(){} // RVA: 0x7ffaaae37c10
        public void AddOrUpdate(){} // RVA: 0x7ffaaae37c10
        public void get_IsEmpty(){} // RVA: 0x7ffaaae37fb0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae380e0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae382a0
        public void get_Keys(){} // RVA: 0x7ffaaae38310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae38310
        public void get_Values(){} // RVA: 0x7ffaaae38330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae38330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae38350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae383d0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae38480
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae384e0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae38500
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae38740
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae38880
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae38310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae38960
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae38330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae38aa0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae38bd0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae38e00
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae393f0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae39ba0
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae39bf0
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae3a270
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae3a330
        public void .cctor(){} // RVA: 0x7ffaaae3a600
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae36a00
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae376c0
        public void GetOrAdd(){} // RVA: 0x7ffaaae376c0
        public void GetOrAdd(){} // RVA: 0x7ffaaae376c0
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae39ce0
        public void GetValues(){} // RVA: 0x7ffaaae39fb0
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x35070E88
        public object _serializationConcurrencyLevel; // 0x35070E88
        public object MaxLockNumber; // 0x35070E88
        public object h00; // 0x350716E8

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae2e800
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae2eb60
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void TryAdd(){} // RVA: 0x7ffaaae2f240
        public void ContainsKey(){} // RVA: 0x7ffaaae2f340
        public void TryRemove(){} // RVA: 0x7ffaaae2f440
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae2f4c0
        public void TryGetValue(){} // RVA: 0x7ffaaae2f970
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae2fa70
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae2fbc0
        public void Clear(){} // RVA: 0x7ffaaae300b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae30350
        public void ToArray(){} // RVA: 0x7ffaaae305b0
        public void CopyToPairs(){} // RVA: 0x7ffaaae307d0
        public void CopyToEntries(){} // RVA: 0x7ffaaae308f0
        public void CopyToObjects(){} // RVA: 0x7ffaaae309f0
        public void TryAddInternal(){} // RVA: 0x7ffaaae30b50
        public void get_Item(){} // RVA: 0x7ffaaae311d0
        public void set_Item(){} // RVA: 0x7ffaaae31320
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae31420
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void get_IsEmpty(){} // RVA: 0x7ffaaae31e40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae31f70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae31fe0
        public void get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae32070
        public void get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae320b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae32120
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae32270
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae04a40
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae32320
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae32540
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae04da0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae32650
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae32780
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae32900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae32b20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae330b0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae33830
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae33880
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae33ef0
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae33fb0
        public void .cctor(){} // RVA: 0x7ffaaae34280
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae03540
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae33970
        public void GetValues(){} // RVA: 0x7ffaaae33c30
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x354EE678
        public object _serializationConcurrencyLevel; // 0x354EE678
        public object MaxLockNumber; // 0x354EE678
        public object p녁A; // 0x1D0001

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae2e800
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae2eb60
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void TryAdd(){} // RVA: 0x7ffaaae2f240
        public void ContainsKey(){} // RVA: 0x7ffaaae2f340
        public void TryRemove(){} // RVA: 0x7ffaaae2f440
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae2f4c0
        public void TryGetValue(){} // RVA: 0x7ffaaae2f970
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae2fa70
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae2fbc0
        public void Clear(){} // RVA: 0x7ffaaae300b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae30350
        public void ToArray(){} // RVA: 0x7ffaaae305b0
        public void CopyToPairs(){} // RVA: 0x7ffaaae307d0
        public void CopyToEntries(){} // RVA: 0x7ffaaae308f0
        public void CopyToObjects(){} // RVA: 0x7ffaaae309f0
        public void TryAddInternal(){} // RVA: 0x7ffaaae30b50
        public void get_Item(){} // RVA: 0x7ffaaae311d0
        public void set_Item(){} // RVA: 0x7ffaaae31320
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae31420
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void get_IsEmpty(){} // RVA: 0x7ffaaae31e40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae31f70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae31fe0
        public void get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae32070
        public void get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae320b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae32120
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae32270
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae04a40
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae32320
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae32540
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae04da0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae32650
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae32780
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae32900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae32b20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae330b0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae33830
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae33880
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae33ef0
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae33fb0
        public void .cctor(){} // RVA: 0x7ffaaae34280
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae03540
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae33970
        public void GetValues(){} // RVA: 0x7ffaaae33c30
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x354FFCB8
        public object _serializationConcurrencyLevel; // 0x354FFCB8
        public object MaxLockNumber; // 0x354FFCB8

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae2e800
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae2eb60
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void TryAdd(){} // RVA: 0x7ffaaae2f240
        public void ContainsKey(){} // RVA: 0x7ffaaae2f340
        public void TryRemove(){} // RVA: 0x7ffaaae2f440
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae2f4c0
        public void TryGetValue(){} // RVA: 0x7ffaaae2f970
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae2fa70
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae2fbc0
        public void Clear(){} // RVA: 0x7ffaaae300b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae30350
        public void ToArray(){} // RVA: 0x7ffaaae305b0
        public void CopyToPairs(){} // RVA: 0x7ffaaae307d0
        public void CopyToEntries(){} // RVA: 0x7ffaaae308f0
        public void CopyToObjects(){} // RVA: 0x7ffaaae309f0
        public void TryAddInternal(){} // RVA: 0x7ffaaae30b50
        public void get_Item(){} // RVA: 0x7ffaaae311d0
        public void set_Item(){} // RVA: 0x7ffaaae31320
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae31420
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void get_IsEmpty(){} // RVA: 0x7ffaaae31e40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae31f70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae31fe0
        public void get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae32070
        public void get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae320b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae32120
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae32270
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae04a40
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae32320
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae32540
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae04da0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae32650
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae32780
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae32900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae32b20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae330b0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae33830
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae33880
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae33ef0
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae33fb0
        public void .cctor(){} // RVA: 0x7ffaaae34280
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae03540
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae33970
        public void GetValues(){} // RVA: 0x7ffaaae33c30
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x35500468
        public object _serializationConcurrencyLevel; // 0x35500468
        public object MaxLockNumber; // 0x35500468

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae2e800
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae2eb60
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void TryAdd(){} // RVA: 0x7ffaaae2f240
        public void ContainsKey(){} // RVA: 0x7ffaaae2f340
        public void TryRemove(){} // RVA: 0x7ffaaae2f440
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae2f4c0
        public void TryGetValue(){} // RVA: 0x7ffaaae2f970
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae2fa70
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae2fbc0
        public void Clear(){} // RVA: 0x7ffaaae300b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae30350
        public void ToArray(){} // RVA: 0x7ffaaae305b0
        public void CopyToPairs(){} // RVA: 0x7ffaaae307d0
        public void CopyToEntries(){} // RVA: 0x7ffaaae308f0
        public void CopyToObjects(){} // RVA: 0x7ffaaae309f0
        public void TryAddInternal(){} // RVA: 0x7ffaaae30b50
        public void get_Item(){} // RVA: 0x7ffaaae311d0
        public void set_Item(){} // RVA: 0x7ffaaae31320
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae31420
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void get_IsEmpty(){} // RVA: 0x7ffaaae31e40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae31f70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae31fe0
        public void get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae32070
        public void get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae320b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae32120
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae32270
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae04a40
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae32320
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae32540
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae04da0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae32650
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae32780
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae32900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae32b20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae330b0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae33830
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae33880
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae33ef0
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae33fb0
        public void .cctor(){} // RVA: 0x7ffaaae34280
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae03540
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae33970
        public void GetValues(){} // RVA: 0x7ffaaae33c30
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x355101E0
        public object _serializationConcurrencyLevel; // 0x355101E0
        public object MaxLockNumber; // 0x355101E0

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae2e800
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae2eb60
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void TryAdd(){} // RVA: 0x7ffaaae2f240
        public void ContainsKey(){} // RVA: 0x7ffaaae2f340
        public void TryRemove(){} // RVA: 0x7ffaaae2f440
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae2f4c0
        public void TryGetValue(){} // RVA: 0x7ffaaae2f970
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae2fa70
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae2fbc0
        public void Clear(){} // RVA: 0x7ffaaae300b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae30350
        public void ToArray(){} // RVA: 0x7ffaaae305b0
        public void CopyToPairs(){} // RVA: 0x7ffaaae307d0
        public void CopyToEntries(){} // RVA: 0x7ffaaae308f0
        public void CopyToObjects(){} // RVA: 0x7ffaaae309f0
        public void TryAddInternal(){} // RVA: 0x7ffaaae30b50
        public void get_Item(){} // RVA: 0x7ffaaae311d0
        public void set_Item(){} // RVA: 0x7ffaaae31320
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae31420
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void get_IsEmpty(){} // RVA: 0x7ffaaae31e40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae31f70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae31fe0
        public void get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae32070
        public void get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae320b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae32120
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae32270
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae04a40
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae32320
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae32540
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae04da0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae32650
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae32780
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae32900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae32b20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae330b0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae33830
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae33880
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae33ef0
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae33fb0
        public void .cctor(){} // RVA: 0x7ffaaae34280
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae03540
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae33970
        public void GetValues(){} // RVA: 0x7ffaaae33c30
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x35823FB8
        public object _serializationConcurrencyLevel; // 0x35823FB8
        public object MaxLockNumber; // 0x35823FB8
        public object `; // 0x357BE8A0

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaadf0680
        public void .ctor(){} // RVA: 0x7ffaaadf0d50
        public void .ctor(){} // RVA: 0x7ffaaadf0d50
        public void .ctor(){} // RVA: 0x7ffaaadf0d50
        public void InitializeFromCollection(){} // RVA: 0x7ffaaadf09e0
        public void .ctor(){} // RVA: 0x7ffaaadf0d50
        public void .ctor(){} // RVA: 0x7ffaaadf0d50
        public void TryAdd(){} // RVA: 0x7ffaaadf1110
        public void ContainsKey(){} // RVA: 0x7ffaaadf1260
        public void TryRemove(){} // RVA: 0x7ffaaadf12a0
        public void TryRemoveInternal(){} // RVA: 0x7ffaaadf12e0
        public void TryGetValue(){} // RVA: 0x7ffaaadf18a0
        public void TryGetValueInternal(){} // RVA: 0x7ffaaadf19d0
        public void TryUpdateInternal(){} // RVA: 0x7ffaaadf1bb0
        public void Clear(){} // RVA: 0x7ffaaadf2130
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaadf23d0
        public void ToArray(){} // RVA: 0x7ffaaadf26e0
        public void CopyToPairs(){} // RVA: 0x7ffaaadf2940
        public void CopyToEntries(){} // RVA: 0x7ffaaadf2a50
        public void CopyToObjects(){} // RVA: 0x7ffaaadf2b80
        public void TryAddInternal(){} // RVA: 0x7ffaaadf2d90
        public void get_Item(){} // RVA: 0x7ffaaadf3510
        public void set_Item(){} // RVA: 0x7ffaaadf35e0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaadf3800
        public void AddOrUpdate(){} // RVA: 0x7ffaaadf3f20
        public void AddOrUpdate(){} // RVA: 0x7ffaaadf3f20
        public void get_IsEmpty(){} // RVA: 0x7ffaaadf4180
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaadf42b0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaadf4450
        public void get_Keys(){} // RVA: 0x7ffaaadf44b0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaadf44b0
        public void get_Values(){} // RVA: 0x7ffaaadf44d0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaadf44d0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaadf44f0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaadf45d0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaadf4670
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaadf46c0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaadf46e0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaadf4910
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaadf4a40
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaadf44b0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaadf4b20
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaadf44d0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaadf4c60
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaadf4d80
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaadf50c0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaadf56a0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaadf5e60
        public void AcquireAllLocks(){} // RVA: 0x7ffaaadf5eb0
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaadf6720
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaadf6840
        public void .cctor(){} // RVA: 0x7ffaaadf6b10
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaadf2cf0
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaadf3b30
        public void GetOrAdd(){} // RVA: 0x7ffaaadf3b30
        public void GetOrAdd(){} // RVA: 0x7ffaaadf3b30
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaadf6190
        public void GetValues(){} // RVA: 0x7ffaaadf6460
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x358326F0
        public object _serializationConcurrencyLevel; // 0x358326F0
        public object MaxLockNumber; // 0x358326F0

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae2e800
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae2eb60
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void TryAdd(){} // RVA: 0x7ffaaae2f240
        public void ContainsKey(){} // RVA: 0x7ffaaae2f340
        public void TryRemove(){} // RVA: 0x7ffaaae2f440
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae2f4c0
        public void TryGetValue(){} // RVA: 0x7ffaaae2f970
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae2fa70
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae2fbc0
        public void Clear(){} // RVA: 0x7ffaaae300b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae30350
        public void ToArray(){} // RVA: 0x7ffaaae305b0
        public void CopyToPairs(){} // RVA: 0x7ffaaae307d0
        public void CopyToEntries(){} // RVA: 0x7ffaaae308f0
        public void CopyToObjects(){} // RVA: 0x7ffaaae309f0
        public void TryAddInternal(){} // RVA: 0x7ffaaae30b50
        public void get_Item(){} // RVA: 0x7ffaaae311d0
        public void set_Item(){} // RVA: 0x7ffaaae31320
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae31420
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void get_IsEmpty(){} // RVA: 0x7ffaaae31e40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae31f70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae31fe0
        public void get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae32070
        public void get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae320b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae32120
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae32270
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae04a40
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae32320
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae32540
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae04da0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae32650
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae32780
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae32900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae32b20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae330b0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae33830
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae33880
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae33ef0
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae33fb0
        public void .cctor(){} // RVA: 0x7ffaaae34280
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae03540
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae33970
        public void GetValues(){} // RVA: 0x7ffaaae33c30
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x3583BDA8
        public object _serializationConcurrencyLevel; // 0x3583BDA8
        public object MaxLockNumber; // 0x3583BDA8

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae2e800
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae2eb60
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void TryAdd(){} // RVA: 0x7ffaaae2f240
        public void ContainsKey(){} // RVA: 0x7ffaaae2f340
        public void TryRemove(){} // RVA: 0x7ffaaae2f440
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae2f4c0
        public void TryGetValue(){} // RVA: 0x7ffaaae2f970
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae2fa70
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae2fbc0
        public void Clear(){} // RVA: 0x7ffaaae300b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae30350
        public void ToArray(){} // RVA: 0x7ffaaae305b0
        public void CopyToPairs(){} // RVA: 0x7ffaaae307d0
        public void CopyToEntries(){} // RVA: 0x7ffaaae308f0
        public void CopyToObjects(){} // RVA: 0x7ffaaae309f0
        public void TryAddInternal(){} // RVA: 0x7ffaaae30b50
        public void get_Item(){} // RVA: 0x7ffaaae311d0
        public void set_Item(){} // RVA: 0x7ffaaae31320
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae31420
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void get_IsEmpty(){} // RVA: 0x7ffaaae31e40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae31f70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae31fe0
        public void get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae32070
        public void get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae320b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae32120
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae32270
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae04a40
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae32320
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae32540
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae04da0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae32650
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae32780
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae32900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae32b20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae330b0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae33830
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae33880
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae33ef0
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae33fb0
        public void .cctor(){} // RVA: 0x7ffaaae34280
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae03540
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae33970
        public void GetValues(){} // RVA: 0x7ffaaae33c30
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x3585B710
        public object _serializationConcurrencyLevel; // 0x3585B710
        public object MaxLockNumber; // 0x3585B710

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae2e800
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae2eb60
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void TryAdd(){} // RVA: 0x7ffaaae2f240
        public void ContainsKey(){} // RVA: 0x7ffaaae2f340
        public void TryRemove(){} // RVA: 0x7ffaaae2f440
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae2f4c0
        public void TryGetValue(){} // RVA: 0x7ffaaae2f970
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae2fa70
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae2fbc0
        public void Clear(){} // RVA: 0x7ffaaae300b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae30350
        public void ToArray(){} // RVA: 0x7ffaaae305b0
        public void CopyToPairs(){} // RVA: 0x7ffaaae307d0
        public void CopyToEntries(){} // RVA: 0x7ffaaae308f0
        public void CopyToObjects(){} // RVA: 0x7ffaaae309f0
        public void TryAddInternal(){} // RVA: 0x7ffaaae30b50
        public void get_Item(){} // RVA: 0x7ffaaae311d0
        public void set_Item(){} // RVA: 0x7ffaaae31320
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae31420
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void get_IsEmpty(){} // RVA: 0x7ffaaae31e40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae31f70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae31fe0
        public void get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae32070
        public void get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae320b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae32120
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae32270
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae04a40
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae32320
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae32540
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae04da0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae32650
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae32780
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae32900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae32b20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae330b0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae33830
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae33880
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae33ef0
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae33fb0
        public void .cctor(){} // RVA: 0x7ffaaae34280
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae03540
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae33970
        public void GetValues(){} // RVA: 0x7ffaaae33c30
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x35868538
        public object _serializationConcurrencyLevel; // 0x35868538
        public object MaxLockNumber; // 0x35868538

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae2e800
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae2eb60
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void TryAdd(){} // RVA: 0x7ffaaae2f240
        public void ContainsKey(){} // RVA: 0x7ffaaae2f340
        public void TryRemove(){} // RVA: 0x7ffaaae2f440
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae2f4c0
        public void TryGetValue(){} // RVA: 0x7ffaaae2f970
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae2fa70
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae2fbc0
        public void Clear(){} // RVA: 0x7ffaaae300b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae30350
        public void ToArray(){} // RVA: 0x7ffaaae305b0
        public void CopyToPairs(){} // RVA: 0x7ffaaae307d0
        public void CopyToEntries(){} // RVA: 0x7ffaaae308f0
        public void CopyToObjects(){} // RVA: 0x7ffaaae309f0
        public void TryAddInternal(){} // RVA: 0x7ffaaae30b50
        public void get_Item(){} // RVA: 0x7ffaaae311d0
        public void set_Item(){} // RVA: 0x7ffaaae31320
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae31420
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void get_IsEmpty(){} // RVA: 0x7ffaaae31e40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae31f70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae31fe0
        public void get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae32070
        public void get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae320b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae32120
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae32270
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae04a40
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae32320
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae32540
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae04da0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae32650
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae32780
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae32900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae32b20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae330b0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae33830
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae33880
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae33ef0
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae33fb0
        public void .cctor(){} // RVA: 0x7ffaaae34280
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae03540
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae33970
        public void GetValues(){} // RVA: 0x7ffaaae33c30
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x35E75F48
        public object _serializationConcurrencyLevel; // 0x35E75F48
        public object MaxLockNumber; // 0x35E75F48

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae60a20
        public void .ctor(){} // RVA: 0x7ffaaae610e0
        public void .ctor(){} // RVA: 0x7ffaaae610e0
        public void .ctor(){} // RVA: 0x7ffaaae610e0
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae60d80
        public void .ctor(){} // RVA: 0x7ffaaae610e0
        public void .ctor(){} // RVA: 0x7ffaaae610e0
        public void TryAdd(){} // RVA: 0x7ffaaae614a0
        public void ContainsKey(){} // RVA: 0x7ffaaae61560
        public void TryRemove(){} // RVA: 0x7ffaaae61590
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae615d0
        public void TryGetValue(){} // RVA: 0x7ffaaae61a90
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae61b40
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae61c90
        public void Clear(){} // RVA: 0x7ffaaae621a0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae62440
        public void ToArray(){} // RVA: 0x7ffaaae62730
        public void CopyToPairs(){} // RVA: 0x7ffaaae62a70
        public void CopyToEntries(){} // RVA: 0x7ffaaae08dd0
        public void CopyToObjects(){} // RVA: 0x7ffaaae62b60
        public void TryAddInternal(){} // RVA: 0x7ffaaae62cb0
        public void get_Item(){} // RVA: 0x7ffaaae63340
        public void set_Item(){} // RVA: 0x7ffaaae63400
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae634c0
        public void AddOrUpdate(){} // RVA: 0x7ffaaae63af0
        public void AddOrUpdate(){} // RVA: 0x7ffaaae63af0
        public void get_IsEmpty(){} // RVA: 0x7ffaaae63dc0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae63ef0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae63f60
        public void get_Keys(){} // RVA: 0x7ffaaae63fb0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae63fb0
        public void get_Values(){} // RVA: 0x7ffaaae63fd0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae63fd0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae63ff0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae64060
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae64100
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae0a570
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae64150
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae64370
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae0a8d0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae63fb0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae64490
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae63fd0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae645c0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae646d0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae64960
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae64fa0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae65710
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae65760
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae65dd0
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae65e90
        public void .cctor(){} // RVA: 0x7ffaaae66160
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae03540
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae636c0
        public void GetOrAdd(){} // RVA: 0x7ffaaae636c0
        public void GetOrAdd(){} // RVA: 0x7ffaaae636c0
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae65850
        public void GetValues(){} // RVA: 0x7ffaaae65b10
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x35FC1DB8
        public object _serializationConcurrencyLevel; // 0x35FC1DB8
        public object MaxLockNumber; // 0x35FC1DB8

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae011e0
        public void .ctor(){} // RVA: 0x7ffaaae018a0
        public void .ctor(){} // RVA: 0x7ffaaae018a0
        public void .ctor(){} // RVA: 0x7ffaaae018a0
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae01540
        public void .ctor(){} // RVA: 0x7ffaaae018a0
        public void .ctor(){} // RVA: 0x7ffaaae018a0
        public void TryAdd(){} // RVA: 0x7ffaaae01c60
        public void ContainsKey(){} // RVA: 0x7ffaaae01d20
        public void TryRemove(){} // RVA: 0x7ffaaae01d50
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae01d90
        public void TryGetValue(){} // RVA: 0x7ffaaae02240
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae022f0
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae02440
        public void Clear(){} // RVA: 0x7ffaaae02930
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae02bd0
        public void ToArray(){} // RVA: 0x7ffaaae02ed0
        public void CopyToPairs(){} // RVA: 0x7ffaaae031c0
        public void CopyToEntries(){} // RVA: 0x7ffaaae032b0
        public void CopyToObjects(){} // RVA: 0x7ffaaae033e0
        public void TryAddInternal(){} // RVA: 0x7ffaaae035e0
        public void get_Item(){} // RVA: 0x7ffaaae03c60
        public void set_Item(){} // RVA: 0x7ffaaae03d10
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae03dd0
        public void AddOrUpdate(){} // RVA: 0x7ffaaae043e0
        public void AddOrUpdate(){} // RVA: 0x7ffaaae043e0
        public void get_IsEmpty(){} // RVA: 0x7ffaaae046b0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae047e0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae04850
        public void get_Keys(){} // RVA: 0x7ffaaae048a0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae048a0
        public void get_Values(){} // RVA: 0x7ffaaae048c0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae048c0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae048e0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae04950
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae049f0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae04a40
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae04a60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae04c80
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae04da0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae048a0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae04e80
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae048c0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae04fa0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae050b0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae052c0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae05920
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae060a0
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae060f0
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae06750
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae06810
        public void .cctor(){} // RVA: 0x7ffaaae06ae0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae03540
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae03fd0
        public void GetOrAdd(){} // RVA: 0x7ffaaae03fd0
        public void GetOrAdd(){} // RVA: 0x7ffaaae03fd0
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae061e0
        public void GetValues(){} // RVA: 0x7ffaaae06490
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x35FE24C0
        public object _serializationConcurrencyLevel; // 0x35FE24C0
        public object MaxLockNumber; // 0x35FE24C0

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae2e800
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae2eb60
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void TryAdd(){} // RVA: 0x7ffaaae2f240
        public void ContainsKey(){} // RVA: 0x7ffaaae2f340
        public void TryRemove(){} // RVA: 0x7ffaaae2f440
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae2f4c0
        public void TryGetValue(){} // RVA: 0x7ffaaae2f970
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae2fa70
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae2fbc0
        public void Clear(){} // RVA: 0x7ffaaae300b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae30350
        public void ToArray(){} // RVA: 0x7ffaaae305b0
        public void CopyToPairs(){} // RVA: 0x7ffaaae307d0
        public void CopyToEntries(){} // RVA: 0x7ffaaae308f0
        public void CopyToObjects(){} // RVA: 0x7ffaaae309f0
        public void TryAddInternal(){} // RVA: 0x7ffaaae30b50
        public void get_Item(){} // RVA: 0x7ffaaae311d0
        public void set_Item(){} // RVA: 0x7ffaaae31320
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae31420
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void get_IsEmpty(){} // RVA: 0x7ffaaae31e40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae31f70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae31fe0
        public void get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae32070
        public void get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae320b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae32120
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae32270
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae04a40
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae32320
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae32540
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae04da0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae32650
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae32780
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae32900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae32b20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae330b0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae33830
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae33880
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae33ef0
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae33fb0
        public void .cctor(){} // RVA: 0x7ffaaae34280
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae03540
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae33970
        public void GetValues(){} // RVA: 0x7ffaaae33c30
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x36013A98
        public object _serializationConcurrencyLevel; // 0x36013A98
        public object MaxLockNumber; // 0x36013A98

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae45ad0
        public void .ctor(){} // RVA: 0x7ffaaae460f0
        public void .ctor(){} // RVA: 0x7ffaaae460f0
        public void .ctor(){} // RVA: 0x7ffaaae460f0
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae45e30
        public void .ctor(){} // RVA: 0x7ffaaae460f0
        public void .ctor(){} // RVA: 0x7ffaaae460f0
        public void TryAdd(){} // RVA: 0x7ffaaae464b0
        public void ContainsKey(){} // RVA: 0x7ffaaae46570
        public void TryRemove(){} // RVA: 0x7ffaaae465a0
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae465d0
        public void TryGetValue(){} // RVA: 0x7ffaaae46a70
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae46b20
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae46c70
        public void Clear(){} // RVA: 0x7ffaaae47150
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae473f0
        public void ToArray(){} // RVA: 0x7ffaaae476b0
        public void CopyToPairs(){} // RVA: 0x7ffaaae479c0
        public void CopyToEntries(){} // RVA: 0x7ffaaae47a50
        public void CopyToObjects(){} // RVA: 0x7ffaaae47ba0
        public void TryAddInternal(){} // RVA: 0x7ffaaae47cc0
        public void get_Item(){} // RVA: 0x7ffaaae48320
        public void set_Item(){} // RVA: 0x7ffaaae483d0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae48490
        public void AddOrUpdate(){} // RVA: 0x7ffaaae48a70
        public void AddOrUpdate(){} // RVA: 0x7ffaaae48a70
        public void get_IsEmpty(){} // RVA: 0x7ffaaae48d10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae48e40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae48f60
        public void get_Keys(){} // RVA: 0x7ffaaae48fb0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae48fb0
        public void get_Values(){} // RVA: 0x7ffaaae48fd0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae48fd0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae48ff0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae49070
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae49100
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaadfa4d0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae49150
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae49360
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaadfa830
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae48fb0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae49480
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae48fd0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae495a0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae49790
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae499a0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae49fe0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae4a750
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae4a7a0
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae4adf0
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae4aeb0
        public void .cctor(){} // RVA: 0x7ffaaae4b180
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaadf8f70
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae48690
        public void GetOrAdd(){} // RVA: 0x7ffaaae48690
        public void GetOrAdd(){} // RVA: 0x7ffaaae48690
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae4a890
        public void GetValues(){} // RVA: 0x7ffaaae4ab40
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x36013EC8
        public object _serializationConcurrencyLevel; // 0x36013EC8
        public object MaxLockNumber; // 0x36013EC8

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaadf6d20
        public void .ctor(){} // RVA: 0x7ffaaadf7340
        public void .ctor(){} // RVA: 0x7ffaaadf7340
        public void .ctor(){} // RVA: 0x7ffaaadf7340
        public void InitializeFromCollection(){} // RVA: 0x7ffaaadf7080
        public void .ctor(){} // RVA: 0x7ffaaadf7340
        public void .ctor(){} // RVA: 0x7ffaaadf7340
        public void TryAdd(){} // RVA: 0x7ffaaadf7700
        public void ContainsKey(){} // RVA: 0x7ffaaadf77c0
        public void TryRemove(){} // RVA: 0x7ffaaadf77f0
        public void TryRemoveInternal(){} // RVA: 0x7ffaaadf7820
        public void TryGetValue(){} // RVA: 0x7ffaaadf7cd0
        public void TryGetValueInternal(){} // RVA: 0x7ffaaadf7d80
        public void TryUpdateInternal(){} // RVA: 0x7ffaaadf7ed0
        public void Clear(){} // RVA: 0x7ffaaadf83c0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaadf8660
        public void ToArray(){} // RVA: 0x7ffaaadf8930
        public void CopyToPairs(){} // RVA: 0x7ffaaadf8c50
        public void CopyToEntries(){} // RVA: 0x7ffaaadf8cf0
        public void CopyToObjects(){} // RVA: 0x7ffaaadf8e40
        public void TryAddInternal(){} // RVA: 0x7ffaaadf9010
        public void get_Item(){} // RVA: 0x7ffaaadf9670
        public void set_Item(){} // RVA: 0x7ffaaadf9720
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaadf97e0
        public void AddOrUpdate(){} // RVA: 0x7ffaaadf9de0
        public void AddOrUpdate(){} // RVA: 0x7ffaaadf9de0
        public void get_IsEmpty(){} // RVA: 0x7ffaaadfa090
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaadfa1c0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaadfa2e0
        public void get_Keys(){} // RVA: 0x7ffaaadfa330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaadfa330
        public void get_Values(){} // RVA: 0x7ffaaadfa350
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaadfa350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaadfa370
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaadfa3f0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaadfa480
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaadfa4d0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaadfa4f0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaadfa710
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaadfa830
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaadfa330
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaadfa910
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaadfa350
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaadfaa30
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaadfac20
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaadfae30
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaadfb4b0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaadfbc20
        public void AcquireAllLocks(){} // RVA: 0x7ffaaadfbc70
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaadfc2d0
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaadfc390
        public void .cctor(){} // RVA: 0x7ffaaadfc660
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaadf8f70
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaadf99e0
        public void GetOrAdd(){} // RVA: 0x7ffaaadf99e0
        public void GetOrAdd(){} // RVA: 0x7ffaaadf99e0
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaadfbd60
        public void GetValues(){} // RVA: 0x7ffaaadfc020
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x36154588
        public object _serializationConcurrencyLevel; // 0x36154588
        public object MaxLockNumber; // 0x36154588

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae2e800
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae2eb60
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void TryAdd(){} // RVA: 0x7ffaaae2f240
        public void ContainsKey(){} // RVA: 0x7ffaaae2f340
        public void TryRemove(){} // RVA: 0x7ffaaae2f440
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae2f4c0
        public void TryGetValue(){} // RVA: 0x7ffaaae2f970
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae2fa70
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae2fbc0
        public void Clear(){} // RVA: 0x7ffaaae300b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae30350
        public void ToArray(){} // RVA: 0x7ffaaae305b0
        public void CopyToPairs(){} // RVA: 0x7ffaaae307d0
        public void CopyToEntries(){} // RVA: 0x7ffaaae308f0
        public void CopyToObjects(){} // RVA: 0x7ffaaae309f0
        public void TryAddInternal(){} // RVA: 0x7ffaaae30b50
        public void get_Item(){} // RVA: 0x7ffaaae311d0
        public void set_Item(){} // RVA: 0x7ffaaae31320
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae31420
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void get_IsEmpty(){} // RVA: 0x7ffaaae31e40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae31f70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae31fe0
        public void get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae32070
        public void get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae320b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae32120
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae32270
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae04a40
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae32320
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae32540
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae04da0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae32650
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae32780
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae32900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae32b20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae330b0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae33830
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae33880
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae33ef0
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae33fb0
        public void .cctor(){} // RVA: 0x7ffaaae34280
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae03540
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae33970
        public void GetValues(){} // RVA: 0x7ffaaae33c30
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x361549B8
        public object _serializationConcurrencyLevel; // 0x361549B8
        public object MaxLockNumber; // 0x361549B8

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae2e800
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae2eb60
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void TryAdd(){} // RVA: 0x7ffaaae2f240
        public void ContainsKey(){} // RVA: 0x7ffaaae2f340
        public void TryRemove(){} // RVA: 0x7ffaaae2f440
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae2f4c0
        public void TryGetValue(){} // RVA: 0x7ffaaae2f970
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae2fa70
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae2fbc0
        public void Clear(){} // RVA: 0x7ffaaae300b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae30350
        public void ToArray(){} // RVA: 0x7ffaaae305b0
        public void CopyToPairs(){} // RVA: 0x7ffaaae307d0
        public void CopyToEntries(){} // RVA: 0x7ffaaae308f0
        public void CopyToObjects(){} // RVA: 0x7ffaaae309f0
        public void TryAddInternal(){} // RVA: 0x7ffaaae30b50
        public void get_Item(){} // RVA: 0x7ffaaae311d0
        public void set_Item(){} // RVA: 0x7ffaaae31320
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae31420
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void get_IsEmpty(){} // RVA: 0x7ffaaae31e40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae31f70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae31fe0
        public void get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae32070
        public void get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae320b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae32120
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae32270
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae04a40
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae32320
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae32540
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae04da0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae32650
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae32780
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae32900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae32b20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae330b0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae33830
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae33880
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae33ef0
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae33fb0
        public void .cctor(){} // RVA: 0x7ffaaae34280
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae03540
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae33970
        public void GetValues(){} // RVA: 0x7ffaaae33c30
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x3681DCF0
        public object _serializationConcurrencyLevel; // 0x3681DCF0
        public object MaxLockNumber; // 0x3681DCF0

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae2e800
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae2eb60
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void TryAdd(){} // RVA: 0x7ffaaae2f240
        public void ContainsKey(){} // RVA: 0x7ffaaae2f340
        public void TryRemove(){} // RVA: 0x7ffaaae2f440
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae2f4c0
        public void TryGetValue(){} // RVA: 0x7ffaaae2f970
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae2fa70
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae2fbc0
        public void Clear(){} // RVA: 0x7ffaaae300b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae30350
        public void ToArray(){} // RVA: 0x7ffaaae305b0
        public void CopyToPairs(){} // RVA: 0x7ffaaae307d0
        public void CopyToEntries(){} // RVA: 0x7ffaaae308f0
        public void CopyToObjects(){} // RVA: 0x7ffaaae309f0
        public void TryAddInternal(){} // RVA: 0x7ffaaae30b50
        public void get_Item(){} // RVA: 0x7ffaaae311d0
        public void set_Item(){} // RVA: 0x7ffaaae31320
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae31420
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void get_IsEmpty(){} // RVA: 0x7ffaaae31e40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae31f70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae31fe0
        public void get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae32070
        public void get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae320b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae32120
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae32270
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae04a40
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae32320
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae32540
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae04da0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae32650
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae32780
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae32900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae32b20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae330b0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae33830
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae33880
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae33ef0
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae33fb0
        public void .cctor(){} // RVA: 0x7ffaaae34280
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae03540
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae33970
        public void GetValues(){} // RVA: 0x7ffaaae33c30
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x3776E678
        public object _serializationConcurrencyLevel; // 0x3776E678
        public object MaxLockNumber; // 0x3776E678

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae0c8a0
        public void .ctor(){} // RVA: 0x7ffaaae0cf60
        public void .ctor(){} // RVA: 0x7ffaaae0cf60
        public void .ctor(){} // RVA: 0x7ffaaae0cf60
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae0cc00
        public void .ctor(){} // RVA: 0x7ffaaae0cf60
        public void .ctor(){} // RVA: 0x7ffaaae0cf60
        public void TryAdd(){} // RVA: 0x7ffaaae0d320
        public void ContainsKey(){} // RVA: 0x7ffaaae0d3e0
        public void TryRemove(){} // RVA: 0x7ffaaae07860
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae078a0
        public void TryGetValue(){} // RVA: 0x7ffaaae07d50
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae07e00
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae07f50
        public void Clear(){} // RVA: 0x7ffaaae0d410
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae0d6b0
        public void ToArray(){} // RVA: 0x7ffaaae0d990
        public void CopyToPairs(){} // RVA: 0x7ffaaae08cf0
        public void CopyToEntries(){} // RVA: 0x7ffaaae08dd0
        public void CopyToObjects(){} // RVA: 0x7ffaaae08f00
        public void TryAddInternal(){} // RVA: 0x7ffaaae0dcc0
        public void get_Item(){} // RVA: 0x7ffaaae0e340
        public void set_Item(){} // RVA: 0x7ffaaae0e400
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae0e4c0
        public void AddOrUpdate(){} // RVA: 0x7ffaaae0eae0
        public void AddOrUpdate(){} // RVA: 0x7ffaaae0eae0
        public void get_IsEmpty(){} // RVA: 0x7ffaaae0edb0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae0eee0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae0a380
        public void get_Keys(){} // RVA: 0x7ffaaae0ef50
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae0ef50
        public void get_Values(){} // RVA: 0x7ffaaae0ef70
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae0ef70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae0a410
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae0ef90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae0a520
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae0a570
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae0a590
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae0f030
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae0a8d0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae0ef50
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae0a9b0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae0ef70
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae0f150
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae0f260
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae0f4f0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae0fb30
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae102b0
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae10300
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae10970
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae10a30
        public void .cctor(){} // RVA: 0x7ffaaae10d00
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae03540
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae0e6c0
        public void GetOrAdd(){} // RVA: 0x7ffaaae0e6c0
        public void GetOrAdd(){} // RVA: 0x7ffaaae0e6c0
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae103f0
        public void GetValues(){} // RVA: 0x7ffaaae106b0
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x379F22D0
        public object _serializationConcurrencyLevel; // 0x379F22D0
        public object MaxLockNumber; // 0x379F22D0

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae2e800
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae2eb60
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void TryAdd(){} // RVA: 0x7ffaaae2f240
        public void ContainsKey(){} // RVA: 0x7ffaaae2f340
        public void TryRemove(){} // RVA: 0x7ffaaae2f440
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae2f4c0
        public void TryGetValue(){} // RVA: 0x7ffaaae2f970
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae2fa70
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae2fbc0
        public void Clear(){} // RVA: 0x7ffaaae300b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae30350
        public void ToArray(){} // RVA: 0x7ffaaae305b0
        public void CopyToPairs(){} // RVA: 0x7ffaaae307d0
        public void CopyToEntries(){} // RVA: 0x7ffaaae308f0
        public void CopyToObjects(){} // RVA: 0x7ffaaae309f0
        public void TryAddInternal(){} // RVA: 0x7ffaaae30b50
        public void get_Item(){} // RVA: 0x7ffaaae311d0
        public void set_Item(){} // RVA: 0x7ffaaae31320
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae31420
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void get_IsEmpty(){} // RVA: 0x7ffaaae31e40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae31f70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae31fe0
        public void get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae32070
        public void get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae320b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae32120
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae32270
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae04a40
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae32320
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae32540
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae04da0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae32650
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae32780
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae32900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae32b20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae330b0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae33830
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae33880
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae33ef0
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae33fb0
        public void .cctor(){} // RVA: 0x7ffaaae34280
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae03540
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae33970
        public void GetValues(){} // RVA: 0x7ffaaae33c30
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x37ADF630
        public object _serializationConcurrencyLevel; // 0x37ADF630
        public object MaxLockNumber; // 0x37ADF630
        public object `; // 0x869FB3E8

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaadf0680
        public void .ctor(){} // RVA: 0x7ffaaadf0d50
        public void .ctor(){} // RVA: 0x7ffaaadf0d50
        public void .ctor(){} // RVA: 0x7ffaaadf0d50
        public void InitializeFromCollection(){} // RVA: 0x7ffaaadf09e0
        public void .ctor(){} // RVA: 0x7ffaaadf0d50
        public void .ctor(){} // RVA: 0x7ffaaadf0d50
        public void TryAdd(){} // RVA: 0x7ffaaadf1110
        public void ContainsKey(){} // RVA: 0x7ffaaadf1260
        public void TryRemove(){} // RVA: 0x7ffaaadf12a0
        public void TryRemoveInternal(){} // RVA: 0x7ffaaadf12e0
        public void TryGetValue(){} // RVA: 0x7ffaaadf18a0
        public void TryGetValueInternal(){} // RVA: 0x7ffaaadf19d0
        public void TryUpdateInternal(){} // RVA: 0x7ffaaadf1bb0
        public void Clear(){} // RVA: 0x7ffaaadf2130
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaadf23d0
        public void ToArray(){} // RVA: 0x7ffaaadf26e0
        public void CopyToPairs(){} // RVA: 0x7ffaaadf2940
        public void CopyToEntries(){} // RVA: 0x7ffaaadf2a50
        public void CopyToObjects(){} // RVA: 0x7ffaaadf2b80
        public void TryAddInternal(){} // RVA: 0x7ffaaadf2d90
        public void get_Item(){} // RVA: 0x7ffaaadf3510
        public void set_Item(){} // RVA: 0x7ffaaadf35e0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaadf3800
        public void AddOrUpdate(){} // RVA: 0x7ffaaadf3f20
        public void AddOrUpdate(){} // RVA: 0x7ffaaadf3f20
        public void get_IsEmpty(){} // RVA: 0x7ffaaadf4180
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaadf42b0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaadf4450
        public void get_Keys(){} // RVA: 0x7ffaaadf44b0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaadf44b0
        public void get_Values(){} // RVA: 0x7ffaaadf44d0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaadf44d0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaadf44f0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaadf45d0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaadf4670
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaadf46c0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaadf46e0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaadf4910
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaadf4a40
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaadf44b0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaadf4b20
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaadf44d0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaadf4c60
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaadf4d80
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaadf50c0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaadf56a0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaadf5e60
        public void AcquireAllLocks(){} // RVA: 0x7ffaaadf5eb0
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaadf6720
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaadf6840
        public void .cctor(){} // RVA: 0x7ffaaadf6b10
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaadf2cf0
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaadf3b30
        public void GetOrAdd(){} // RVA: 0x7ffaaadf3b30
        public void GetOrAdd(){} // RVA: 0x7ffaaadf3b30
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaadf6190
        public void GetValues(){} // RVA: 0x7ffaaadf6460
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x39F43AE0
        public object _serializationConcurrencyLevel; // 0x39F43AE0
        public object MaxLockNumber; // 0x39F43AE0

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae2e800
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae2eb60
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void TryAdd(){} // RVA: 0x7ffaaae2f240
        public void ContainsKey(){} // RVA: 0x7ffaaae2f340
        public void TryRemove(){} // RVA: 0x7ffaaae2f440
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae2f4c0
        public void TryGetValue(){} // RVA: 0x7ffaaae2f970
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae2fa70
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae2fbc0
        public void Clear(){} // RVA: 0x7ffaaae300b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae30350
        public void ToArray(){} // RVA: 0x7ffaaae305b0
        public void CopyToPairs(){} // RVA: 0x7ffaaae307d0
        public void CopyToEntries(){} // RVA: 0x7ffaaae308f0
        public void CopyToObjects(){} // RVA: 0x7ffaaae309f0
        public void TryAddInternal(){} // RVA: 0x7ffaaae30b50
        public void get_Item(){} // RVA: 0x7ffaaae311d0
        public void set_Item(){} // RVA: 0x7ffaaae31320
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae31420
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void get_IsEmpty(){} // RVA: 0x7ffaaae31e40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae31f70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae31fe0
        public void get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae32070
        public void get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae320b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae32120
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae32270
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae04a40
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae32320
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae32540
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae04da0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae32650
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae32780
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae32900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae32b20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae330b0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae33830
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae33880
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae33ef0
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae33fb0
        public void .cctor(){} // RVA: 0x7ffaaae34280
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae03540
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae33970
        public void GetValues(){} // RVA: 0x7ffaaae33c30
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x39F4D310
        public object _serializationConcurrencyLevel; // 0x39F4D310
        public object MaxLockNumber; // 0x39F4D310

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae2e800
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae2eb60
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void TryAdd(){} // RVA: 0x7ffaaae2f240
        public void ContainsKey(){} // RVA: 0x7ffaaae2f340
        public void TryRemove(){} // RVA: 0x7ffaaae2f440
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae2f4c0
        public void TryGetValue(){} // RVA: 0x7ffaaae2f970
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae2fa70
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae2fbc0
        public void Clear(){} // RVA: 0x7ffaaae300b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae30350
        public void ToArray(){} // RVA: 0x7ffaaae305b0
        public void CopyToPairs(){} // RVA: 0x7ffaaae307d0
        public void CopyToEntries(){} // RVA: 0x7ffaaae308f0
        public void CopyToObjects(){} // RVA: 0x7ffaaae309f0
        public void TryAddInternal(){} // RVA: 0x7ffaaae30b50
        public void get_Item(){} // RVA: 0x7ffaaae311d0
        public void set_Item(){} // RVA: 0x7ffaaae31320
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae31420
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void get_IsEmpty(){} // RVA: 0x7ffaaae31e40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae31f70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae31fe0
        public void get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae32070
        public void get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae320b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae32120
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae32270
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae04a40
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae32320
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae32540
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae04da0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae32650
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae32780
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae32900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae32b20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae330b0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae33830
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae33880
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae33ef0
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae33fb0
        public void .cctor(){} // RVA: 0x7ffaaae34280
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae03540
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae33970
        public void GetValues(){} // RVA: 0x7ffaaae33c30
    }

    public class ConcurrentDictionary`2 : Object
    {
        public object _growLockArray; // 0x39F60F88
        public object _serializationConcurrencyLevel; // 0x39F60F88
        public object MaxLockNumber; // 0x39F60F88
        public object @Do8; // 0x1D0001

        // ── Original Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7ffaaae2e800
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void InitializeFromCollection(){} // RVA: 0x7ffaaae2eb60
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void .ctor(){} // RVA: 0x7ffaaae2ee80
        public void TryAdd(){} // RVA: 0x7ffaaae2f240
        public void ContainsKey(){} // RVA: 0x7ffaaae2f340
        public void TryRemove(){} // RVA: 0x7ffaaae2f440
        public void TryRemoveInternal(){} // RVA: 0x7ffaaae2f4c0
        public void TryGetValue(){} // RVA: 0x7ffaaae2f970
        public void TryGetValueInternal(){} // RVA: 0x7ffaaae2fa70
        public void TryUpdateInternal(){} // RVA: 0x7ffaaae2fbc0
        public void Clear(){} // RVA: 0x7ffaaae300b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7ffaaae30350
        public void ToArray(){} // RVA: 0x7ffaaae305b0
        public void CopyToPairs(){} // RVA: 0x7ffaaae307d0
        public void CopyToEntries(){} // RVA: 0x7ffaaae308f0
        public void CopyToObjects(){} // RVA: 0x7ffaaae309f0
        public void TryAddInternal(){} // RVA: 0x7ffaaae30b50
        public void get_Item(){} // RVA: 0x7ffaaae311d0
        public void set_Item(){} // RVA: 0x7ffaaae31320
        public void ThrowKeyNotFoundException(){} // RVA: 0x7ffaaadf3730
        public void ThrowKeyNullException(){} // RVA: 0x7ffaaadf37b0
        public void get_Count(){} // RVA: 0x7ffaaae31420
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void AddOrUpdate(){} // RVA: 0x7ffaaae31b20
        public void get_IsEmpty(){} // RVA: 0x7ffaaae31e40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7ffaaae31f70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7ffaaae31fe0
        public void get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7ffaaae32070
        public void get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7ffaaae320b0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7ffaaae32120
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7ffaaae32270
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae04a40
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7ffaaae32320
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7ffaaae32540
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7ffaaae04da0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7ffaaae32070
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7ffaaae32650
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7ffaaae32090
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7ffaaae32780
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7ffaaae32900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae32b20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void GrowTable(){} // RVA: 0x7ffaaae330b0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7ffaaae33830
        public void AcquireAllLocks(){} // RVA: 0x7ffaaae33880
        public void AcquireLocks(){} // RVA: 0x7ffaaadf5fa0
        public void ReleaseLocks(){} // RVA: 0x7ffaaadf6100
        public void OnSerializing(){} // RVA: 0x7ffaaae33ef0
        public void OnSerialized(){} // RVA: 0x7ffaaadf67e0
        public void OnDeserialized(){} // RVA: 0x7ffaaae33fb0
        public void .cctor(){} // RVA: 0x7ffaaae34280
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaae03540
        public void GetCountInternal(){} // RVA: 0x7ffaaadf38b0
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetOrAdd(){} // RVA: 0x7ffaaae31660
        public void GetBucket(){} // RVA: 0x7ffaaadf5e30
        public void GetBucketAndLockNo(){} // RVA: 0x7ffaaadf5e40
        public void GetKeys(){} // RVA: 0x7ffaaae33970
        public void GetValues(){} // RVA: 0x7ffaaae33c30
    }

    public class ConcurrentQueue`1 : Object
    {
        public object _head; // 0x300DA408

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae6fea0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae70060
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae6de90
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7ffaaae70160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7ffaaae70180
        public void get_IsEmpty(){} // RVA: 0x7ffaaae701a0
        public void ToArray(){} // RVA: 0x7ffaaae70270
        public void get_Count(){} // RVA: 0x7ffaaae706c0
        public void CopyTo(){} // RVA: 0x7ffaaae70a30
        public void SnapForObservation(){} // RVA: 0x7ffaaae70f00
        public void Enumerate(){} // RVA: 0x7ffaaae71300
        public void Enqueue(){} // RVA: 0x7ffaaae71480
        public void EnqueueSlow(){} // RVA: 0x7ffaaae71500
        public void TryDequeue(){} // RVA: 0x7ffaaae719d0
        public void TryDequeueSlow(){} // RVA: 0x7ffaaae71a60
        public void TryPeek(){} // RVA: 0x7ffaaae71c90
        // ── Binary Analysis Named ──
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetEnumerator(){} // RVA: 0x7ffaaae70e60
        public void GetItemWhenAvailable(){} // RVA: 0x7ffaaae711a0
    }

    public class ConcurrentQueue`1 : Object
    {
        public object _head; // 0x30C52700
        public object System.Collections.ICollection.IsSynchronized; // 0x1700083B

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaa8667cb0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa864a040
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaa86491d0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7ffaa887e5c0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7ffaa864a2a0
        public void get_IsEmpty(){} // RVA: 0x7ffaa864a040
        public void ToArray(){} // RVA: 0x7ffaa86491d0
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        public void CopyTo(){} // RVA: 0x7ffaa8667cb0
        public void SnapForObservation(){} // RVA: 0x7ffaa866bc00
        public void Enumerate(){} // RVA: 0x7ffaa887e5c0
        public void Enqueue(){} // RVA: 0x7ffaa887e5c0
        public void EnqueueSlow(){} // RVA: 0x7ffaa887e5c0
        public void TryDequeue(){} // RVA: 0x7ffaa864a2a0
        public void TryDequeueSlow(){} // RVA: 0x7ffaa864a2a0
        public void TryPeek(){}
        // ── Binary Analysis Named ──
        public void GetCount(){} // RVA: 0x7ffaa887e5c0
        public void GetCount(){} // RVA: 0x7ffaa887e5c0
        public void GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void GetItemWhenAvailable(){} // RVA: 0x7ffaa887e5c0
    }

    public class ConcurrentQueue`1 : Object
    {
        public object _head; // 0x351D9A18

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae6fea0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae70060
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae6de90
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7ffaaae70160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7ffaaae70180
        public void get_IsEmpty(){} // RVA: 0x7ffaaae701a0
        public void ToArray(){} // RVA: 0x7ffaaae70270
        public void get_Count(){} // RVA: 0x7ffaaae706c0
        public void CopyTo(){} // RVA: 0x7ffaaae70a30
        public void SnapForObservation(){} // RVA: 0x7ffaaae70f00
        public void Enumerate(){} // RVA: 0x7ffaaae71300
        public void Enqueue(){} // RVA: 0x7ffaaae71480
        public void EnqueueSlow(){} // RVA: 0x7ffaaae71500
        public void TryDequeue(){} // RVA: 0x7ffaaae719d0
        public void TryDequeueSlow(){} // RVA: 0x7ffaaae71a60
        public void TryPeek(){} // RVA: 0x7ffaaae71c90
        // ── Binary Analysis Named ──
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetEnumerator(){} // RVA: 0x7ffaaae70e60
        public void GetItemWhenAvailable(){} // RVA: 0x7ffaaae711a0
    }

    public class ConcurrentQueue`1 : Object
    {
        public object _head; // 0x358EA628

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae6fea0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae70060
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae6de90
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7ffaaae70160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7ffaaae70180
        public void get_IsEmpty(){} // RVA: 0x7ffaaae701a0
        public void ToArray(){} // RVA: 0x7ffaaae70270
        public void get_Count(){} // RVA: 0x7ffaaae706c0
        public void CopyTo(){} // RVA: 0x7ffaaae70a30
        public void SnapForObservation(){} // RVA: 0x7ffaaae70f00
        public void Enumerate(){} // RVA: 0x7ffaaae71300
        public void Enqueue(){} // RVA: 0x7ffaaae71480
        public void EnqueueSlow(){} // RVA: 0x7ffaaae71500
        public void TryDequeue(){} // RVA: 0x7ffaaae719d0
        public void TryDequeueSlow(){} // RVA: 0x7ffaaae71a60
        public void TryPeek(){} // RVA: 0x7ffaaae71c90
        // ── Binary Analysis Named ──
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetEnumerator(){} // RVA: 0x7ffaaae70e60
        public void GetItemWhenAvailable(){} // RVA: 0x7ffaaae711a0
    }

    public class ConcurrentQueue`1 : Object
    {
        public object _head; // 0x35F529B8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae7a450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae7a610
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae6de90
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7ffaaae7a710
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7ffaaae7a7b0
        public void get_IsEmpty(){} // RVA: 0x7ffaaae7a7d0
        public void ToArray(){} // RVA: 0x7ffaaae7a8a0
        public void get_Count(){} // RVA: 0x7ffaaae7ad10
        public void CopyTo(){} // RVA: 0x7ffaaae7b080
        public void SnapForObservation(){} // RVA: 0x7ffaaae7b640
        public void Enumerate(){} // RVA: 0x7ffaaae6f420
        public void Enqueue(){} // RVA: 0x7ffaaae7ba40
        public void EnqueueSlow(){} // RVA: 0x7ffaaae7bad0
        public void TryDequeue(){} // RVA: 0x7ffaaae7bfb0
        public void TryDequeueSlow(){} // RVA: 0x7ffaaae7c040
        public void TryPeek(){} // RVA: 0x7ffaaae7c270
        // ── Binary Analysis Named ──
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetEnumerator(){} // RVA: 0x7ffaaae7b5a0
        public void GetItemWhenAvailable(){} // RVA: 0x7ffaaae7b8e0
    }

    public class ConcurrentQueue`1 : Object
    {
        public object _head; // 0x3603C548

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae6fea0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae70060
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae6de90
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7ffaaae70160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7ffaaae70180
        public void get_IsEmpty(){} // RVA: 0x7ffaaae701a0
        public void ToArray(){} // RVA: 0x7ffaaae70270
        public void get_Count(){} // RVA: 0x7ffaaae706c0
        public void CopyTo(){} // RVA: 0x7ffaaae70a30
        public void SnapForObservation(){} // RVA: 0x7ffaaae70f00
        public void Enumerate(){} // RVA: 0x7ffaaae71300
        public void Enqueue(){} // RVA: 0x7ffaaae71480
        public void EnqueueSlow(){} // RVA: 0x7ffaaae71500
        public void TryDequeue(){} // RVA: 0x7ffaaae719d0
        public void TryDequeueSlow(){} // RVA: 0x7ffaaae71a60
        public void TryPeek(){} // RVA: 0x7ffaaae71c90
        // ── Binary Analysis Named ──
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetEnumerator(){} // RVA: 0x7ffaaae70e60
        public void GetItemWhenAvailable(){} // RVA: 0x7ffaaae711a0
    }

    public class ConcurrentQueue`1 : Object
    {
        public object _head; // 0x366F3910

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae6fea0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae70060
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae6de90
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7ffaaae70160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7ffaaae70180
        public void get_IsEmpty(){} // RVA: 0x7ffaaae701a0
        public void ToArray(){} // RVA: 0x7ffaaae70270
        public void get_Count(){} // RVA: 0x7ffaaae706c0
        public void CopyTo(){} // RVA: 0x7ffaaae70a30
        public void SnapForObservation(){} // RVA: 0x7ffaaae70f00
        public void Enumerate(){} // RVA: 0x7ffaaae71300
        public void Enqueue(){} // RVA: 0x7ffaaae71480
        public void EnqueueSlow(){} // RVA: 0x7ffaaae71500
        public void TryDequeue(){} // RVA: 0x7ffaaae719d0
        public void TryDequeueSlow(){} // RVA: 0x7ffaaae71a60
        public void TryPeek(){} // RVA: 0x7ffaaae71c90
        // ── Binary Analysis Named ──
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetEnumerator(){} // RVA: 0x7ffaaae70e60
        public void GetItemWhenAvailable(){} // RVA: 0x7ffaaae711a0
    }

    public class ConcurrentQueue`1 : Object
    {
        public object _head; // 0x379DC458

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae6fea0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae70060
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae6de90
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7ffaaae70160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7ffaaae70180
        public void get_IsEmpty(){} // RVA: 0x7ffaaae701a0
        public void ToArray(){} // RVA: 0x7ffaaae70270
        public void get_Count(){} // RVA: 0x7ffaaae706c0
        public void CopyTo(){} // RVA: 0x7ffaaae70a30
        public void SnapForObservation(){} // RVA: 0x7ffaaae70f00
        public void Enumerate(){} // RVA: 0x7ffaaae71300
        public void Enqueue(){} // RVA: 0x7ffaaae71480
        public void EnqueueSlow(){} // RVA: 0x7ffaaae71500
        public void TryDequeue(){} // RVA: 0x7ffaaae719d0
        public void TryDequeueSlow(){} // RVA: 0x7ffaaae71a60
        public void TryPeek(){} // RVA: 0x7ffaaae71c90
        // ── Binary Analysis Named ──
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetEnumerator(){} // RVA: 0x7ffaaae70e60
        public void GetItemWhenAvailable(){} // RVA: 0x7ffaaae711a0
    }

    public class ConcurrentQueue`1 : Object
    {
        public object _head; // 0x37A7DC08

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae6fea0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae70060
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae6de90
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7ffaaae70160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7ffaaae70180
        public void get_IsEmpty(){} // RVA: 0x7ffaaae701a0
        public void ToArray(){} // RVA: 0x7ffaaae70270
        public void get_Count(){} // RVA: 0x7ffaaae706c0
        public void CopyTo(){} // RVA: 0x7ffaaae70a30
        public void SnapForObservation(){} // RVA: 0x7ffaaae70f00
        public void Enumerate(){} // RVA: 0x7ffaaae71300
        public void Enqueue(){} // RVA: 0x7ffaaae71480
        public void EnqueueSlow(){} // RVA: 0x7ffaaae71500
        public void TryDequeue(){} // RVA: 0x7ffaaae719d0
        public void TryDequeueSlow(){} // RVA: 0x7ffaaae71a60
        public void TryPeek(){} // RVA: 0x7ffaaae71c90
        // ── Binary Analysis Named ──
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetEnumerator(){} // RVA: 0x7ffaaae70e60
        public void GetItemWhenAvailable(){} // RVA: 0x7ffaaae711a0
    }

    public class ConcurrentQueue`1 : Object
    {
        public object _head; // 0x37A84380

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae6fea0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae70060
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae6de90
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7ffaaae70160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7ffaaae70180
        public void get_IsEmpty(){} // RVA: 0x7ffaaae701a0
        public void ToArray(){} // RVA: 0x7ffaaae70270
        public void get_Count(){} // RVA: 0x7ffaaae706c0
        public void CopyTo(){} // RVA: 0x7ffaaae70a30
        public void SnapForObservation(){} // RVA: 0x7ffaaae70f00
        public void Enumerate(){} // RVA: 0x7ffaaae71300
        public void Enqueue(){} // RVA: 0x7ffaaae71480
        public void EnqueueSlow(){} // RVA: 0x7ffaaae71500
        public void TryDequeue(){} // RVA: 0x7ffaaae719d0
        public void TryDequeueSlow(){} // RVA: 0x7ffaaae71a60
        public void TryPeek(){} // RVA: 0x7ffaaae71c90
        // ── Binary Analysis Named ──
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetEnumerator(){} // RVA: 0x7ffaaae70e60
        public void GetItemWhenAvailable(){} // RVA: 0x7ffaaae711a0
    }

    public class ConcurrentQueue`1 : Object
    {
        public object _head; // 0x37A8C8E0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae6fea0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae70060
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae6de90
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7ffaaae70160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7ffaaae70180
        public void get_IsEmpty(){} // RVA: 0x7ffaaae701a0
        public void ToArray(){} // RVA: 0x7ffaaae70270
        public void get_Count(){} // RVA: 0x7ffaaae706c0
        public void CopyTo(){} // RVA: 0x7ffaaae70a30
        public void SnapForObservation(){} // RVA: 0x7ffaaae70f00
        public void Enumerate(){} // RVA: 0x7ffaaae71300
        public void Enqueue(){} // RVA: 0x7ffaaae71480
        public void EnqueueSlow(){} // RVA: 0x7ffaaae71500
        public void TryDequeue(){} // RVA: 0x7ffaaae719d0
        public void TryDequeueSlow(){} // RVA: 0x7ffaaae71a60
        public void TryPeek(){} // RVA: 0x7ffaaae71c90
        // ── Binary Analysis Named ──
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetEnumerator(){} // RVA: 0x7ffaaae70e60
        public void GetItemWhenAvailable(){} // RVA: 0x7ffaaae711a0
    }

    public class ConcurrentQueue`1 : Object
    {
        public object _head; // 0x37BF90D0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae6fea0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae70060
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae6de90
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7ffaaae70160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7ffaaae70180
        public void get_IsEmpty(){} // RVA: 0x7ffaaae701a0
        public void ToArray(){} // RVA: 0x7ffaaae70270
        public void get_Count(){} // RVA: 0x7ffaaae706c0
        public void CopyTo(){} // RVA: 0x7ffaaae70a30
        public void SnapForObservation(){} // RVA: 0x7ffaaae70f00
        public void Enumerate(){} // RVA: 0x7ffaaae71300
        public void Enqueue(){} // RVA: 0x7ffaaae71480
        public void EnqueueSlow(){} // RVA: 0x7ffaaae71500
        public void TryDequeue(){} // RVA: 0x7ffaaae719d0
        public void TryDequeueSlow(){} // RVA: 0x7ffaaae71a60
        public void TryPeek(){} // RVA: 0x7ffaaae71c90
        // ── Binary Analysis Named ──
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetEnumerator(){} // RVA: 0x7ffaaae70e60
        public void GetItemWhenAvailable(){} // RVA: 0x7ffaaae711a0
    }

    public class ConcurrentQueue`1 : Object
    {
        public object _head; // 0x37F96A18

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae6fea0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae70060
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae6de90
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7ffaaae70160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7ffaaae70180
        public void get_IsEmpty(){} // RVA: 0x7ffaaae701a0
        public void ToArray(){} // RVA: 0x7ffaaae70270
        public void get_Count(){} // RVA: 0x7ffaaae706c0
        public void CopyTo(){} // RVA: 0x7ffaaae70a30
        public void SnapForObservation(){} // RVA: 0x7ffaaae70f00
        public void Enumerate(){} // RVA: 0x7ffaaae71300
        public void Enqueue(){} // RVA: 0x7ffaaae71480
        public void EnqueueSlow(){} // RVA: 0x7ffaaae71500
        public void TryDequeue(){} // RVA: 0x7ffaaae719d0
        public void TryDequeueSlow(){} // RVA: 0x7ffaaae71a60
        public void TryPeek(){} // RVA: 0x7ffaaae71c90
        // ── Binary Analysis Named ──
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetEnumerator(){} // RVA: 0x7ffaaae70e60
        public void GetItemWhenAvailable(){} // RVA: 0x7ffaaae711a0
    }

    public class ConcurrentQueue`1 : Object
    {
        public object _head; // 0x3868C7E0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaae6fea0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaae70060
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaaded960
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaae6de90
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7ffaaae70160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7ffaaae70180
        public void get_IsEmpty(){} // RVA: 0x7ffaaae701a0
        public void ToArray(){} // RVA: 0x7ffaaae70270
        public void get_Count(){} // RVA: 0x7ffaaae706c0
        public void CopyTo(){} // RVA: 0x7ffaaae70a30
        public void SnapForObservation(){} // RVA: 0x7ffaaae70f00
        public void Enumerate(){} // RVA: 0x7ffaaae71300
        public void Enqueue(){} // RVA: 0x7ffaaae71480
        public void EnqueueSlow(){} // RVA: 0x7ffaaae71500
        public void TryDequeue(){} // RVA: 0x7ffaaae719d0
        public void TryDequeueSlow(){} // RVA: 0x7ffaaae71a60
        public void TryPeek(){} // RVA: 0x7ffaaae71c90
        // ── Binary Analysis Named ──
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetCount(){} // RVA: 0x7ffaaae6e970
        public void GetEnumerator(){} // RVA: 0x7ffaaae70e60
        public void GetItemWhenAvailable(){} // RVA: 0x7ffaaae711a0
    }

    public class ConcurrentStack`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa864a040
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaa86491d0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaa8667cb0
        public void Push(){} // RVA: 0x7ffaa887e5c0
        public void PushCore(){} // RVA: 0x7ffaa8669e70
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7ffaa887e5c0
        public void TryPop(){} // RVA: 0x7ffaa864a2a0
        public void TryPopCore(){} // RVA: 0x7ffaa864a2a0
        public void TryPopCore(){} // RVA: 0x7ffaa864a2a0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7ffaa864a2a0
        public void ToArray(){} // RVA: 0x7ffaa86491d0
        public void ToList(){} // RVA: 0x7ffaa8649280
        public void ToList(){} // RVA: 0x7ffaa8649280
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaa8649280
        public void GetEnumerator(){} // RVA: 0x7ffaa8649280
    }

    public class IProducerConsumerCollection`1
    {
    }

    public class IProducerConsumerCollection`1
    {
        // ── Original Methods ──
        public void TryAdd(){} // RVA: 0x7ffaa887e5c0
        public void TryTake(){} // RVA: 0x7ffaa864a2a0
        public void ToArray(){} // RVA: 0x7ffaa86491d0
    }

    public class IProducerConsumerCollection`1
    {
    }

    public class IProducerConsumerCollection`1
    {
    }

    public class IProducerConsumerCollection`1
    {
    }

    public class IProducerConsumerCollection`1
    {
    }

    public class IProducerConsumerCollection`1
    {
    }

    public class IProducerConsumerCollection`1
    {
    }

    public class IProducerConsumerCollection`1
    {
    }

    public class IProducerConsumerCollection`1
    {
    }

    public class IProducerConsumerCollection`1
    {
    }

    public class IProducerConsumerCollection`1
    {
    }

    public class IProducerConsumerCollection`1
    {
    }

    public class IProducerConsumerCollection`1
    {
    }

    public class OrderablePartitioner`1 : Partitioner`1
    {
        public object _keysNormalized; // 0x30E7CDE8, was: <KeysNormalized>k__BackingFiel

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac0f0390
        public void set_KeysOrderedInEachPartition(){} // RVA: 0x7ffaa89fc5f0
        public void set_KeysOrderedAcrossPartitions(){} // RVA: 0x7ffaa919b040
        public void set_KeysNormalized(){} // RVA: 0x7ffaa9e38fe0
        // ── Binary Analysis Named ──
        public void GetOrderableDynamicPartitions(){} // RVA: 0x7ffaac0f0290
        public void GetDynamicPartitions(){} // RVA: 0x7ffaac0f0440
    }

    public class OrderablePartitioner`1 : Partitioner`1
    {
        public object _keysNormalized; // 0x30ECCB90, was: <KeysNormalized>k__BackingFiel

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8661530
        public void set_KeysOrderedInEachPartition(){} // RVA: 0x7ffaa86613a0
        public void set_KeysOrderedAcrossPartitions(){} // RVA: 0x7ffaa86613a0
        public void set_KeysNormalized(){} // RVA: 0x7ffaa86613a0
        // ── Binary Analysis Named ──
        public void GetOrderableDynamicPartitions(){} // RVA: 0x7ffaa86491d0
        public void GetDynamicPartitions(){} // RVA: 0x7ffaa86491d0
    }

    public class OrderablePartitioner`1 : Partitioner`1
    {
        public object _keysNormalized; // 0x366ECB70, was: <KeysNormalized>k__BackingFiel

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac0f0280
        public void set_KeysOrderedInEachPartition(){} // RVA: 0x7ffaa89fc5f0
        public void set_KeysOrderedAcrossPartitions(){} // RVA: 0x7ffaa919b040
        public void set_KeysNormalized(){} // RVA: 0x7ffaa9e38fe0
        // ── Binary Analysis Named ──
        public void GetOrderableDynamicPartitions(){} // RVA: 0x7ffaac0f0290
        public void GetDynamicPartitions(){} // RVA: 0x7ffaac0f02e0
    }

    public class OrderablePartitioner`1 : Partitioner`1
    {
        public object _keysNormalized; // 0x387447E0, was: <KeysNormalized>k__BackingFiel

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac0f0280
        public void set_KeysOrderedInEachPartition(){} // RVA: 0x7ffaa89fc5f0
        public void set_KeysOrderedAcrossPartitions(){} // RVA: 0x7ffaa919b040
        public void set_KeysNormalized(){} // RVA: 0x7ffaa9e38fe0
        // ── Binary Analysis Named ──
        public void GetOrderableDynamicPartitions(){} // RVA: 0x7ffaac0f0290
        public void GetDynamicPartitions(){} // RVA: 0x7ffaac0f02e0
    }

    public class PaddedHeadAndTail : ValueType
    {
    }

    public class Partitioner : Object
    {
        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffaa86583d0
        public void Create(){} // RVA: 0x7ffaa86583d0
        // ── Binary Analysis Named ──
        public void GetDefaultChunkSize(){} // RVA: 0x7ffaa8649cd0
    }

    public class Partitioner`1 : Object
    {
        // ── Original Methods ──
        public void get_SupportsDynamicPartitions(){} // RVA: 0x7ffaa8932320
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetDynamicPartitions(){} // RVA: 0x7ffaac0f0290
    }

    public class Partitioner`1 : Object
    {
        // ── Original Methods ──
        public void get_SupportsDynamicPartitions(){} // RVA: 0x7ffaa8932320
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetDynamicPartitions(){} // RVA: 0x7ffaac0f0290
    }

    public class Partitioner`1 : Object
    {
        // ── Original Methods ──
        public void get_SupportsDynamicPartitions(){} // RVA: 0x7ffaa864a040
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetDynamicPartitions(){} // RVA: 0x7ffaa86491d0
    }

    public class Partitioner`1 : Object
    {
        // ── Original Methods ──
        public void get_SupportsDynamicPartitions(){} // RVA: 0x7ffaa8932320
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetDynamicPartitions(){} // RVA: 0x7ffaac0f0290
    }

    public class Partitioner`1 : Object
    {
        // ── Original Methods ──
        public void get_SupportsDynamicPartitions(){} // RVA: 0x7ffaa8932320
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetDynamicPartitions(){} // RVA: 0x7ffaac0f0290
    }

    public class SingleProducerSingleConsumerQueue`1 : Object
    {
        public object _head; // 0x3508C448

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void Enqueue(){} // RVA: 0x7ffaa887e5c0
        public void EnqueueSlow(){} // RVA: 0x7ffaa887e5c0
        public void TryDequeue(){} // RVA: 0x7ffaa864a2a0
        public void TryPeek(){} // RVA: 0x7ffaa864a2a0
        public void TryDequeueSlow(){} // RVA: 0x7ffaa887e5c0
        public void get_IsEmpty(){} // RVA: 0x7ffaa864a040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaa86491d0
    }

    public class SingleProducerSingleConsumerQueue`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac340850
        public void Enqueue(){} // RVA: 0x7ffaac340970
        public void EnqueueSlow(){} // RVA: 0x7ffaac340a10
        public void TryDequeue(){} // RVA: 0x7ffaac340d10
        public void TryPeek(){} // RVA: 0x7ffaac340e30
        public void TryDequeueSlow(){} // RVA: 0x7ffaac340f00
        public void get_IsEmpty(){} // RVA: 0x7ffaac3411a0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaac341290
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaac341200
    }

}